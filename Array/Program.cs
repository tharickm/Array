/*
    Author: Tharick Moulton
    Date: 1/28/2019
    Comments: This C# Console application code demonstrates the use of
              Arrays. 
*/


using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int countdown = 25;
            Console.WriteLine("");
            Console.WriteLine("First, let's manually populate an array with integers.");
            Console.WriteLine("Then, let's iterate through the elements in the array with a do while loop");
            // Here is the manually populated array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("");

            Console.WriteLine("The value is " + numbers[countdown] + " in element #" + countdown + " of the array.");
            Console.WriteLine("Here are the values in each element of the array:");
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("");
            // Iterate through the array with a Foreach Loop
            do
            {
                Console.WriteLine("Element value = " + countdown.ToString());
                countdown--;
            } while (countdown > 0);
            // End of do while loop
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("Press any key to exit the program ...");
            // Pause the program and await the user to press a key to end the program
            Console.ReadKey(true);
        }// End of main

    }// End of class

}// End of namespace
