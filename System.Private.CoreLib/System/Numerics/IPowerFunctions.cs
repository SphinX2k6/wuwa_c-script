using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B4 RID: 692
	public interface IPowerFunctions<TSelf> : INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<!0> where TSelf : IPowerFunctions<TSelf>
	{
		// Token: 0x06003368 RID: 13160
		[NullableContext(1)]
		public abstract static TSelf Pow(TSelf x, TSelf y);
	}
}
