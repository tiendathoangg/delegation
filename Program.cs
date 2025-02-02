using System;
using SplashKitSDK;

namespace draft
{
// Step 1: Declare Delegate
public delegate double DiscountDelegate(double price);

public class DiscountCalculator
{
    //Step 2: Create methods that match the delegate signature
    public double CalculatePercentageDiscount(double price) => price * 0.9;
    public double CalculateAmountDiscount(double price) => price - 5;
}


public class Program
{
    static void Main()
    {
        //Step 3: Create a delegate and point it to a method: 

        DiscountCalculator discountCalculator = new DiscountCalculator();
        DiscountDelegate discountDelegate = discountCalculator.CalculatePercentageDiscount;
        Console.WriteLine(discountDelegate(100)); // Output: 90

        //Step 4: Change to the other method if you want the delegate point to: 

        discountDelegate = discountCalculator.CalculateAmountDiscount;
        Console.WriteLine(discountDelegate(100)); // Output: 95
    }
}
}

