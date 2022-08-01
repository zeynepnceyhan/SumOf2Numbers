namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, sum;
            Console.WriteLine("First number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;
            Console.WriteLine("The sum of these two numbers: " + sum);
            Console.ReadLine();
        }

    }

}