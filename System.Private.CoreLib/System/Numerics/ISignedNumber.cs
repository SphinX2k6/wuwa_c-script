using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B7 RID: 695
	public interface ISignedNumber<TSelf> : INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<!0> where TSelf : ISignedNumber<TSelf>
	{
		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06003370 RID: 13168
		[Nullable(1)]
		TSelf NegativeOne { [NullableContext(1)] get; }
	}
}
