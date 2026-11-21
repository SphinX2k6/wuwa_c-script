using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A7 RID: 679
	[NullableContext(1)]
	public interface IExponentialFunctions<[Nullable(0)] TSelf> : IFloatingPointConstants<TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : IExponentialFunctions<TSelf>
	{
		// Token: 0x060032EA RID: 13034
		public abstract static TSelf Exp(TSelf x);

		// Token: 0x060032EB RID: 13035 RVA: 0x000A2FD2 File Offset: 0x000A11D2
		public virtual static TSelf ExpM1(TSelf x)
		{
			return IExponentialFunctions<TSelf>.Exp(x) - INumberBase<TSelf>.One;
		}

		// Token: 0x060032EC RID: 13036
		public abstract static TSelf Exp2(TSelf x);

		// Token: 0x060032ED RID: 13037 RVA: 0x000A2FF6 File Offset: 0x000A11F6
		public virtual static TSelf Exp2M1(TSelf x)
		{
			return IExponentialFunctions<TSelf>.Exp2(x) - INumberBase<TSelf>.One;
		}

		// Token: 0x060032EE RID: 13038
		public abstract static TSelf Exp10(TSelf x);

		// Token: 0x060032EF RID: 13039 RVA: 0x000A301A File Offset: 0x000A121A
		public virtual static TSelf Exp10M1(TSelf x)
		{
			return IExponentialFunctions<TSelf>.Exp10(x) - INumberBase<TSelf>.One;
		}
	}
}
