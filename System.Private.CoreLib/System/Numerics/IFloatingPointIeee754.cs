using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002AA RID: 682
	[NullableContext(1)]
	public interface IFloatingPointIeee754<[Nullable(0)] TSelf> : IExponentialFunctions<TSelf>, IFloatingPointConstants<TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf>, IFloatingPoint<TSelf>, INumber<TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IModulusOperators<TSelf, TSelf, TSelf>, ISignedNumber<TSelf>, IHyperbolicFunctions<TSelf>, ILogarithmicFunctions<TSelf>, IPowerFunctions<TSelf>, IRootFunctions<TSelf>, ITrigonometricFunctions<TSelf> where TSelf : IFloatingPointIeee754<TSelf>
	{
		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06003310 RID: 13072
		TSelf Epsilon { get; }

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06003311 RID: 13073
		TSelf NaN { get; }

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06003312 RID: 13074
		TSelf NegativeInfinity { get; }

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06003313 RID: 13075
		TSelf NegativeZero { get; }

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06003314 RID: 13076
		TSelf PositiveInfinity { get; }

		// Token: 0x06003315 RID: 13077
		public abstract static TSelf Atan2(TSelf y, TSelf x);

		// Token: 0x06003316 RID: 13078
		public abstract static TSelf Atan2Pi(TSelf y, TSelf x);

		// Token: 0x06003317 RID: 13079
		public abstract static TSelf BitDecrement(TSelf x);

		// Token: 0x06003318 RID: 13080
		public abstract static TSelf BitIncrement(TSelf x);

		// Token: 0x06003319 RID: 13081
		public abstract static TSelf FusedMultiplyAdd(TSelf left, TSelf right, TSelf addend);

		// Token: 0x0600331A RID: 13082
		public abstract static TSelf Ieee754Remainder(TSelf left, TSelf right);

		// Token: 0x0600331B RID: 13083
		public abstract static int ILogB(TSelf x);

		// Token: 0x0600331C RID: 13084 RVA: 0x000A325A File Offset: 0x000A145A
		public virtual static TSelf Lerp(TSelf value1, TSelf value2, TSelf amount)
		{
			return INumberBase<TSelf>.MultiplyAddEstimate(value1, INumberBase<TSelf>.One - amount, value2 * amount);
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000A328C File Offset: 0x000A148C
		public virtual static TSelf ReciprocalEstimate(TSelf x)
		{
			return INumberBase<TSelf>.One / x;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000A32A5 File Offset: 0x000A14A5
		public virtual static TSelf ReciprocalSqrtEstimate(TSelf x)
		{
			return INumberBase<TSelf>.One / IRootFunctions<TSelf>.Sqrt(x);
		}

		// Token: 0x0600331F RID: 13087
		public abstract static TSelf ScaleB(TSelf x, int n);
	}
}
