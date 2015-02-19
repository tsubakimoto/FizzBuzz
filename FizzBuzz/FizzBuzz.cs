namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string Say(int n)
        {
            if (n < 1)
                throw new System.ArgumentOutOfRangeException();

            if (n % 3 == 0 && n % 5 == 0)
                return "Fizz Buzz";

            if (n % 3 == 0)
                return "Fizz";

            if (n % 5 == 0)
                return "Buzz";

            return n.ToString();
        }
    }
}
