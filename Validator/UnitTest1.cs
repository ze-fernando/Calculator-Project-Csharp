using DIO_project;

namespace Validator;

public class UnitTest1
{
    [Theory]
    [InlineData(5,5,10)]
    public void soma(int a, int b, int c){
        int res = Calculator.soma(a,b);

        Assert.Equal(c, res);
    }

    [Theory]
    [InlineData(5,5,0)]
    public void sub(int a, int b, int c){
        int res = Calculator.subtracao(a,b);

        Assert.Equal(c, res);
    }

    [Theory]
    [InlineData(5,5,25)]
    public void mult(int a, int b, int c){
        int res = Calculator.multiplicacao(a,b);

        Assert.Equal(c, res);
    }

    [Theory]
    [InlineData(10,5,2)]
    public void div(int a, int b, int c){
        int res = Calculator.divisao(a,b);

        Assert.Equal(c, res);
    }
}