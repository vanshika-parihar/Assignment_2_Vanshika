////Assignment 2 DIS
///Vanshika Kanwar Parihar U36889732
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2_Vanshika
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine();

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
            Console.ReadLine();
        }
        //Question 1
        private static void ShuffleArray(int[] input, int n)
        {
            try
            {
                if (input.Length == 2 * n)                              //Count of input number needs to be equal 2n.
                {

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(input[i] + " " + input[n + i] + " ");  //printing ith and (n+i)th term
                    }
                }
                else                                                    //Count of numbers is either less or more than 2n.
                    Console.WriteLine("Enter the correct number of terms.");
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 2:
        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int count = 0;                                          // count variable as 0.
                for (int i = 0; i < ar2.Length; i++)                    // for loop for finding non zeros and doing in-place replacement.
                {
                    try                                                 // checking for integer input.
                    {
                        if (ar2[i] != 0)                     //if the number if equal to 0.
                        {
                            ar2[count] = ar2[i];                        //shifing the non zero numbers to the front.
                            count++;                                    //increase the count variable.
                        }
                    } // end of try.
                    catch                                               //for consisting of non integer input.
                    {
                        Console.WriteLine("Please enter only integers");
                    } //end of catch.
                } //end of for loop.
                while (count < ar2.Length)                              // while loop for repositioning zeros at the back.
                {
                    ar2[count] = 0;                                   //substituting the back end elements to 0.
                    count++;                                            // increase the count variable
                }
                foreach (var x in ar2)                                  // printing the values of the array
                    Console.Write(x + " ");
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 3
        private static void CoolPairs(int[] nums)
        {
            try
            {
                int x = 0;
                Dictionary<int, int> dict = new Dictionary<int, int>();
                foreach (var num in nums)                              //going through each number in the array
                {
                    if (dict.ContainsKey(num))                          //if the number exists in the key
                        dict[num]++;                                      //increase the count as a value for that key
                    else                                                //if the number does not exists in the key
                        dict[num] = 1;                                    //keep the value at that key as 1
                }

                foreach (var pair in dict)                              //going through each pair of the dictionary
                    if (pair.Value > 1)                                 //if the number was repeated
                        x = x + (pair.Value * (pair.Value - 1) / 2);      //calculating total numbr of good paris using the formula mentioned above
                Console.WriteLine(x);                                   //printing the total count
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                // assuming that there will only be one unique pair that will sum to the target
                Dictionary<int, int> dict = new Dictionary<int, int>();
                int complement;
                int n;
                int[] index_arr = new int[2];
                for (int i = 0; i < nums.Length; i++)                                   // looping through all the elements of the array
                {
                    n = nums[i];
                    complement = target - n;                                     // number that would sum up to target value
                    if (dict.TryGetValue(complement, out int comp_index))          // if the dict contains a value at key = complement number, take it out as a int variable index
                    {
                        index_arr[0] = comp_index;                               // index of comp. number
                        index_arr[1] = i;                                        // index of array number
                    }
                    dict.Add(n, i);                                              // add the number and its index to the dict                                               //
                }
                foreach (int x in index_arr)
                    Console.Write(x + " ");
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw;
            }

        }

        //Question 5
        private static void RestoreString(string str, int[] indices)
        {
            try
            {
                char[] c_arr = new char[indices.Length];              //character array
                for (int i = 0; i < indices.Length; i++)
                {
                    c_arr[indices[i]] = str[i];                       //populating the character array at "indices array values" with string characters
                }
                foreach (var v in c_arr)
                    Console.Write(v);                                 //printing all the characters of the character array
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 6
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                Dictionary<int, int> my_dict1 = new Dictionary<int, int>(); // dictionary 1
                Dictionary<int, int> my_dict2 = new Dictionary<int, int>(); // dictionary 2
                if (s1 == null || s2 == null)                                 // if any of the string empty, return false
                    return false;
                if (s1.Length != s2.Length)                                   // if the length of both the arrays do not match, return false
                    return false;
                if (s1.Equals(s2))                                            // if both the strings are alike, return true
                    return true;
                int l = s1.Length;
                for (int i = 0; i < l; i++)                                       // going through all the characters in both the strings
                {
                    if (!my_dict1.ContainsKey(s1[i]))                        // if the dict1 does not contain x[i], 
                        my_dict1.Add(s1[i], s2[i]);                           // add it with y[i] as value
                    if (!my_dict2.ContainsKey(s2[i]))                        // if the dict2 does not contain y[i],
                        my_dict2.Add(s2[i], s1[i]);                           // add it with x[i] as value
                }
                for (int j = 0; j < l; j++)                                        // going through all the characters in both the strings
                {
                    if (s1[j] != my_dict2[s2[j]])                             // if x[j] if not eual to the value of dict2 at key y[j]
                        return false;                                       // return false
                    if (s2[j] != my_dict1[s1[j]])                             // if x[j] if not eual to the value of dict2 at key y[j]
                        return false;                                       // return false
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 7
        private static void HighFive(int[,] items)
        {
            try
            {
                Dictionary<int, List<int>> mydict = new Dictionary<int, List<int>>();       //initialized dictionary for storing the 2d array values
                Dictionary<int, int> output = new Dictionary<int, int>();                   // output dictionary
                for (int i = 0; i < items.GetLength(0); i++)
                {

                    if (mydict.ContainsKey(items[i, 0]))                                    // if contains key than add the score column value to dict value list
                    {
                        mydict[items[i, 0]].Add(items[i, 1]);
                    }
                    else                                                                    // if doednt contain key then add it to the dictionary with its value
                    {
                        mydict.Add(items[i, 0], new List<int>());
                        mydict[items[i, 0]].Add(items[i, 1]);
                    }
                }
                for (int i = mydict.Count - 1; i >= 0; i--)                                 // running through ALL THE ELEMENTS IN THE DICTIONARY
                {
                    int sum = 0;
                    int avg = 0;
                    var item = mydict.ElementAt(i);
                    var itemKey = item.Key;
                    var itemValue = item.Value;
                    var newList = mydict[itemKey].OrderByDescending(x => x).ToList();       // sorted the value of a key in descending order
                    for (int j = 0; j < 5; j++)                                             // for loop for finding the avg of top five scores
                    {
                        sum = sum + newList[j];
                    }
                    avg = sum / 5;
                    output.Add(itemKey, avg);                                               // adding the id with its top five average score
                }
                output = output.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value); // sorting the dictionary by keys
                foreach (KeyValuePair<int, int> kvp2 in output)                             // loop for printing all the values
                {
                    Console.WriteLine(kvp2.Key + " " + kvp2.Value);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 8
        private static bool HappyNumber(int n)
        {
            try
            {
                List<int> num_list = new List<int>();
                int r = 0;                                             // remainder variable
                while (n != 1 && !num_list.Contains(n))            //run the loop till n is not equal to 1 and is not present in the list
                {
                    num_list.Add(n);                                 // added the number to the list
                    int sum = 0;                                       // setting sum as 0 for each outer while loop
                    while (n != 0)                                   // running the inner while loop for all the digits of the number
                    {
                        r = n % 10;                                  // finding the unit digit
                        sum = sum + r * r;                             // sum of all digits' square
                        n = n / 10;
                    }
                    n = sum;                                         // setting next number to be the sum
                }
                return n == 1;                                       // return true if num == 1, else false
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 9
        private static int Stocks(int[] prices)
        {
            try
            {
                int buying_price = prices[0];                          // setting first buying price to be the first element of the prices array
                int max_profit = 0;                                 // max profit is set to 0
                int cal_profit;                                     // looping through the array
                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] < buying_price)                      // if condition for setting buying prize as minimum
                    {
                        buying_price = prices[i];
                    }
                    cal_profit = prices[i] - buying_price;             // calculating profit for each number in the array

                    if (cal_profit > max_profit)                    //If calculated profit is more than max_profit, keep it as max_profit
                    {
                        max_profit = cal_profit;
                    }
                }
                return max_profit;                                  // return max_profit 
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 10
        private static void Stairs(int steps)
        {
            try
            {
                /*The person can reach nth stair from either (n-1)th stair or from (n-2)th stair. 
                * Hence, for each stair n, we try to find out the number of ways to reach n-1th stair 
                * and n-2th stair and add them to give the answer for the nth stair.*/
                if (steps == 1)                                     // return 1 for 1 step
                    Console.WriteLine(1);
                if (steps == 2)                                     // return 2 for 2 steps
                    Console.WriteLine(2);
                else                                            // for more than 2 steps
                {
                    int[] arr = new int[steps + 1];                 // initializing an array of size n+1
                    arr[1] = 1;                                 // first element of array as 1
                    arr[2] = 2;                                 // second element of array as 2
                    for (int i = 3; i <= steps; i++)
                    {
                        arr[i] = arr[i - 1] + arr[i - 2];       // using the concept of Fibonacci series, finding the ith term of the array(number of ways).
                    }
                    Console.WriteLine(arr[steps]);                              // returning the total number of ways to reach nth step
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
