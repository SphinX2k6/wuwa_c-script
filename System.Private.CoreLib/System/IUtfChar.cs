using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000158 RID: 344
	internal interface IUtfChar<[IsUnmanaged] TSelf> : IBinaryInteger<TSelf>, IBinaryNumber<TSelf>, IBitwiseOperators<TSelf, TSelf, TSelf>, INumber<TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>, IModulusOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf>, IShiftOperators<TSelf, int, TSelf> where TSelf : struct, ValueType, IUtfChar<TSelf>
	{
		// Token: 0x06001702 RID: 5890
		public abstract static TSelf CastFrom(byte value);

		// Token: 0x06001703 RID: 5891
		public abstract static TSelf CastFrom(char value);

		// Token: 0x06001704 RID: 5892
		public abstract static TSelf CastFrom(int value);

		// Token: 0x06001705 RID: 5893
		public abstract static TSelf CastFrom(uint value);

		// Token: 0x06001706 RID: 5894
		public abstract static TSelf CastFrom(ulong value);

		// Token: 0x06001707 RID: 5895
		public abstract static uint CastToUInt32(TSelf value);
	}
}
