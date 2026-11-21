using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000184 RID: 388
	internal interface IBinaryIntegerParseAndFormatInfo<[IsUnmanaged] TSelf> : IBinaryInteger<TSelf>, IBinaryNumber<TSelf>, IBitwiseOperators<TSelf, TSelf, TSelf>, INumber<TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>, IModulusOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf>, IShiftOperators<TSelf, int, TSelf>, IMinMaxValue<TSelf> where TSelf : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TSelf>
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600199F RID: 6559
		bool IsSigned { get; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060019A0 RID: 6560
		int MaxDigitCount { get; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060019A1 RID: 6561
		int MaxHexDigitCount { get; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060019A2 RID: 6562
		TSelf MaxValueDiv10 { get; }

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060019A3 RID: 6563
		string OverflowMessage { get; }

		// Token: 0x060019A4 RID: 6564
		public abstract static bool IsGreaterThanAsUnsigned(TSelf left, TSelf right);

		// Token: 0x060019A5 RID: 6565
		public abstract static TSelf MultiplyBy10(TSelf value);

		// Token: 0x060019A6 RID: 6566
		public abstract static TSelf MultiplyBy16(TSelf value);
	}
}
