using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B5 RID: 693
	public interface IRootFunctions<TSelf> : IFloatingPointConstants<TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<!0> where TSelf : IRootFunctions<TSelf>
	{
		// Token: 0x06003369 RID: 13161
		[NullableContext(1)]
		public abstract static TSelf Cbrt(TSelf x);

		// Token: 0x0600336A RID: 13162
		[NullableContext(1)]
		public abstract static TSelf Hypot(TSelf x, TSelf y);

		// Token: 0x0600336B RID: 13163
		[NullableContext(1)]
		public abstract static TSelf RootN(TSelf x, int n);

		// Token: 0x0600336C RID: 13164
		[NullableContext(1)]
		public abstract static TSelf Sqrt(TSelf x);
	}
}
