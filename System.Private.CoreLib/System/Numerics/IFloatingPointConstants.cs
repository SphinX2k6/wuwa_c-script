using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A9 RID: 681
	[NullableContext(1)]
	public interface IFloatingPointConstants<[Nullable(0)] TSelf> : INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : IFloatingPointConstants<TSelf>
	{
		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x0600330D RID: 13069
		TSelf E { get; }

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x0600330E RID: 13070
		TSelf Pi { get; }

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600330F RID: 13071
		TSelf Tau { get; }
	}
}
