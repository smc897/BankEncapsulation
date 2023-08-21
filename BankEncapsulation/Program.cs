namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            Console.WriteLine("Enter an amount to add to the balance: ");
            double addTo = Double.Parse(Console.ReadLine());
            b.Deposit(addTo);
            Console.WriteLine($"new balance is: {b.GetBalance()}");
        }
    }
}
