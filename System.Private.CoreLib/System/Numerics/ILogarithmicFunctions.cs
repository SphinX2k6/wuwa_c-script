using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002AD RID: 685
	[NullableContext(1)]
	public interface ILogarithmicFunctions<[Nullable(0)] TSelf> : IFloatingPointConstants<TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : ILogarithmicFunctions<TSelf>
	{
		// Token: 0x06003328 RID: 13096
		public abstract static TSelf Log(TSelf x);

		// Token: 0x06003329 RID: 13097
		public abstract static TSelf Log(TSelf x, TSelf newBase);

		// Token: 0x0600332A RID: 13098 RVA: 0x000A32DA File Offset: 0x000A14DA
		public virtual static TSelf LogP1(TSelf x)
		{
			return ILogarithmicFunctions<TSelf>.Log(x + INumberBase<TSelf>.One);
		}

		// Token: 0x0600332B RID: 13099
		public abstract static TSelf Log2(TSelf x);

		// Token: 0x0600332C RID: 13100 RVA: 0x000A32FE File Offset: 0x000A14FE
		public virtual static TSelf Log2P1(TSelf x)
		{
			return ILogarithmicFunctions<TSelf>.Log2(x + INumberBase<TSelf>.One);
		}

		// Token: 0x0600332D RID: 13101
		public abstract static TSelf Log10(TSelf x);

		// Token: 0x0600332E RID: 13102 RVA: 0x000A3322 File Offset: 0x000A1522
		public virtual static TSelf Log10P1(TSelf x)
		{
			return ILogarithmicFunctions<TSelf>.Log10(x + INumberBase<TSelf>.One);
		}
	}
}
