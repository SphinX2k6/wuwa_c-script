using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002AB RID: 683
	[NullableContext(1)]
	public interface IHyperbolicFunctions<[Nullable(0)] TSelf> : IFloatingPointConstants<TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : IHyperbolicFunctions<TSelf>
	{
		// Token: 0x06003320 RID: 13088
		public abstract static TSelf Acosh(TSelf x);

		// Token: 0x06003321 RID: 13089
		public abstract static TSelf Asinh(TSelf x);

		// Token: 0x06003322 RID: 13090
		public abstract static TSelf Atanh(TSelf x);

		// Token: 0x06003323 RID: 13091
		public abstract static TSelf Cosh(TSelf x);

		// Token: 0x06003324 RID: 13092
		public abstract static TSelf Sinh(TSelf x);

		// Token: 0x06003325 RID: 13093
		public abstract static TSelf Tanh(TSelf x);
	}
}
