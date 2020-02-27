using System;

namespace MethodsSofiaChumpitazi
{
    class Program
    {
        static void MyMessage(int arithmeticopt) // Creating my message class where full name and arithmetic operations should displlay
        {
            try
            {
                Console.WriteLine("Name: Sofia Chumpitazi");
                // Declaring random integer variable as shown in the example video by the instructor
                Random randomInteger = new Random();

                // Declaring variables for integers. These variables will be used for the arithmetic operations
                int firstNumber = randomInteger.Next(6);
                int secondNumber = randomInteger.Next(3);

                // I did not use string because I'm not representing text as a sequence.
                // Instead, I used int to declare numeric variables used for arithmetic operations
                int multiplication = firstNumber * secondNumber;
                int division = firstNumber / secondNumber;
                int addition = firstNumber + secondNumber;
                int substraction = firstNumber - secondNumber;

                // Declare string variable assigned to arithmetic operations. User should be able to see this display on their screen.
                string times = "The number " + firstNumber + " times " + secondNumber + " is equal to: " + multiplication;
                string divide = "The number " + firstNumber + " divided by " + secondNumber + " is equal to: " + division;
                string plus = "The number " + firstNumber + " plus " + secondNumber + " is equal to: " + addition;
                string minus = "The number " + firstNumber + " minus " + secondNumber + " is equal to: " + substraction;

                // If and else statement to put conditions on string variables
                if (arithmeticopt == 0)
                {
                    // Multiplication for range of numbers using parameter 0
                    Console.WriteLine(times);
                }
                else if (arithmeticopt == 1)
                {
                    // Division for range of numbers using paremeter 1
                    Console.WriteLine(divide);
                }
                else if (arithmeticopt == 2)
                {
                    // Addition for range of numbers using parameter 2
                    Console.WriteLine(plus);
                }
                else if (arithmeticopt == 3)
                {
                    // Substraction for range of number using parameter 3
                    Console.WriteLine(minus);
                }
                else
                // Flag for unknown number outside the range 
                {
                    Console.WriteLine("Unknown Flag: The arithmetic operation's parameter have a range of 0 to 3 only.");
                }

            }

            // It should display an error message if the arithmetich op is outside the range 
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error Message : " + ex);
            }

        }
        static void Main(string[] args)
        {

            // FULL NAME  displayed on the console
            MyMessage(4);// The number inside the parenthesis will indicate the arithmetic operation used 
        }






    }
}
