using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000185 RID: 389
	internal interface IBinaryFloatParseAndFormatInfo<[IsUnmanaged] TSelf> : IBinaryFloatingPointIeee754<TSelf>, IBinaryNumber<TSelf>, IBitwiseOperators<TSelf, TSelf, TSelf>, INumber<TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>, IModulusOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf>, IFloatingPointIeee754<TSelf>, IExponentialFunctions<TSelf>, IFloatingPointConstants<TSelf>, IFloatingPoint<TSelf>, ISignedNumber<TSelf>, IHyperbolicFunctions<TSelf>, ILogarithmicFunctions<TSelf>, IPowerFunctions<TSelf>, IRootFunctions<TSelf>, ITrigonometricFunctions<TSelf>, IMinMaxValue<TSelf> where TSelf : struct, ValueType, IBinaryFloatParseAndFormatInfo<TSelf>
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060019A7 RID: 6567
		int NumberBufferLength { get; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060019A8 RID: 6568
		ulong ZeroBits { get; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060019A9 RID: 6569
		ulong InfinityBits { get; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060019AA RID: 6570
		ulong NormalMantissaMask { get; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060019AB RID: 6571
		ulong DenormalMantissaMask { get; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060019AC RID: 6572
		int MinBinaryExponent { get; }

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060019AD RID: 6573
		int MaxBinaryExponent { get; }

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060019AE RID: 6574
		int MinDecimalExponent { get; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060019AF RID: 6575
		int MaxDecimalExponent { get; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060019B0 RID: 6576
		int ExponentBias { get; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060019B1 RID: 6577
		ushort ExponentBits { get; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060019B2 RID: 6578
		int OverflowDecimalExponent { get; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060019B3 RID: 6579
		int InfinityExponent { get; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060019B4 RID: 6580
		ushort NormalMantissaBits { get; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060019B5 RID: 6581
		ushort DenormalMantissaBits { get; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060019B6 RID: 6582
		int MinFastFloatDecimalExponent { get; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060019B7 RID: 6583
		int MaxFastFloatDecimalExponent { get; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060019B8 RID: 6584
		int MinExponentRoundToEven { get; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060019B9 RID: 6585
		int MaxExponentRoundToEven { get; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060019BA RID: 6586
		int MaxExponentFastPath { get; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060019BB RID: 6587
		ulong MaxMantissaFastPath { get; }

		// Token: 0x060019BC RID: 6588
		public abstract static TSelf BitsToFloat(ulong bits);

		// Token: 0x060019BD RID: 6589
		public abstract static ulong FloatToBits(TSelf value);

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060019BE RID: 6590
		int MaxRoundTripDigits { get; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060019BF RID: 6591
		int MaxPrecisionCustomFormat { get; }
	}
}
