using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B9 RID: 697
	[NullableContext(1)]
	public interface ITrigonometricFunctions<[Nullable(0)] TSelf> : IFloatingPointConstants<TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<!0> where TSelf : ITrigonometricFunctions<TSelf>
	{
		// Token: 0x06003373 RID: 13171
		public abstract static TSelf Acos(TSelf x);

		// Token: 0x06003374 RID: 13172
		public abstract static TSelf AcosPi(TSelf x);

		// Token: 0x06003375 RID: 13173
		public abstract static TSelf Asin(TSelf x);

		// Token: 0x06003376 RID: 13174
		public abstract static TSelf AsinPi(TSelf x);

		// Token: 0x06003377 RID: 13175
		public abstract static TSelf Atan(TSelf x);

		// Token: 0x06003378 RID: 13176
		public abstract static TSelf AtanPi(TSelf x);

		// Token: 0x06003379 RID: 13177
		public abstract static TSelf Cos(TSelf x);

		// Token: 0x0600337A RID: 13178
		public abstract static TSelf CosPi(TSelf x);

		// Token: 0x0600337B RID: 13179 RVA: 0x000A39D3 File Offset: 0x000A1BD3
		public virtual static TSelf DegreesToRadians(TSelf degrees)
		{
			return degrees * IFloatingPointConstants<TSelf>.Pi / INumberBase<TSelf>.CreateChecked<int>(180);
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x000A3A07 File Offset: 0x000A1C07
		public virtual static TSelf RadiansToDegrees(TSelf radians)
		{
			return radians * INumberBase<TSelf>.CreateChecked<int>(180) / IFloatingPointConstants<TSelf>.Pi;
		}

		// Token: 0x0600337D RID: 13181
		public abstract static TSelf Sin(TSelf x);

		// Token: 0x0600337E RID: 13182
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public abstract static ValueTuple<TSelf, TSelf> SinCos(TSelf x);

		// Token: 0x0600337F RID: 13183
		[return: TupleElementNames(new string[]
		{
			"SinPi",
			"CosPi"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public abstract static ValueTuple<TSelf, TSelf> SinCosPi(TSelf x);

		// Token: 0x06003380 RID: 13184
		public abstract static TSelf SinPi(TSelf x);

		// Token: 0x06003381 RID: 13185
		public abstract static TSelf Tan(TSelf x);

		// Token: 0x06003382 RID: 13186
		public abstract static TSelf TanPi(TSelf x);
	}
}
