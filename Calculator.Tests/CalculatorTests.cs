namespace Calculator.Tests;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Additional_MustReturnCorrectValue()
    {
        var calculator = new Practices.Calculator();
        Assert.That(calculator.Additional(20, 10) == 30);
    }

    [Test]
    public void Subtraction_MustReturnCorrectValue()
    {
        var calculator = new Practices.Calculator();
        Assert.That(calculator.Subtraction(20, 10) == 10);
    }
    
    [Test]
    public void Miltiplication_MustReturnCorrectValue()
    {
        var calculator = new Practices.Calculator();
        Assert.That(calculator.Miltiplication(20, 10) == 200);
    }
    
    [Test]
    public void Division_MustReturnCorrectValue()
    {
        var calculator = new Practices.Calculator();
        Assert.That(calculator.Division(20, 10) == 2);
    }
    
    [Test]
    public void Division_MustThrowException() {
        var calculator = new Practices.Calculator();
        Assert.Throws < DivideByZeroException > (() => calculator.Division(20, 0));
    }
}