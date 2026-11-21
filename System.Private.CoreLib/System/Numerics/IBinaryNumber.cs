using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A1 RID: 673
	public interface IBinaryNumber<TSelf> : IBitwiseOperators<TSelf, TSelf, TSelf>, INumber<TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>, IModulusOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : IBinaryNumber<TSelf>
	{
		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x000A2F9A File Offset: 0x000A119A
		[Nullable(1)]
		TSelf AllBitsSet
		{
			[NullableContext(1)]
			get
			{
				return ~INumberBase<TSelf>.Zero;
			}
		}

		// Token: 0x060032DA RID: 13018
		[NullableContext(1)]
		public abstract static bool IsPow2(TSelf value);

		// Token: 0x060032DB RID: 13019
		[NullableContext(1)]
		public abstract static TSelf Log2(TSelf value);
	}
}
