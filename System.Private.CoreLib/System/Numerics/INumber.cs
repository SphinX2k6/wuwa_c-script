using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002B2 RID: 690
	[NullableContext(1)]
	public interface INumber<[Nullable(0)] TSelf> : IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>, IModulusOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf> where TSelf : INumber<TSelf>
	{
		// Token: 0x06003335 RID: 13109 RVA: 0x000A3355 File Offset: 0x000A1555
		public virtual static TSelf Clamp(TSelf value, TSelf min, TSelf max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<TSelf>(min, max);
			}
			return INumber<TSelf>.Min(INumber<TSelf>.Max(value, min), max);
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x000A3388 File Offset: 0x000A1588
		public virtual static TSelf CopySign(TSelf value, TSelf sign)
		{
			TSelf tself = value;
			if (INumberBase<TSelf>.IsNegative(value) != INumberBase<TSelf>.IsNegative(sign))
			{
				tself = IUnaryNegationOperators<TSelf, TSelf>.op_CheckedUnaryNegation(tself);
			}
			return tself;
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x000A33C0 File Offset: 0x000A15C0
		public virtual static TSelf Max(TSelf x, TSelf y)
		{
			if (x != y)
			{
				if (INumberBase<TSelf>.IsNaN(x))
				{
					return x;
				}
				if (!(y < x))
				{
					return y;
				}
				return x;
			}
			else
			{
				if (!INumberBase<TSelf>.IsNegative(y))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x000A3410 File Offset: 0x000A1610
		public virtual static TSelf MaxNumber(TSelf x, TSelf y)
		{
			if (x != y)
			{
				if (INumberBase<TSelf>.IsNaN(y))
				{
					return x;
				}
				if (!(y < x))
				{
					return y;
				}
				return x;
			}
			else
			{
				if (!INumberBase<TSelf>.IsNegative(y))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x000A3460 File Offset: 0x000A1660
		public virtual static TSelf Min(TSelf x, TSelf y)
		{
			if (x != y)
			{
				if (INumberBase<TSelf>.IsNaN(x))
				{
					return x;
				}
				if (!(x < y))
				{
					return y;
				}
				return x;
			}
			else
			{
				if (!INumberBase<TSelf>.IsNegative(x))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x000A34B0 File Offset: 0x000A16B0
		public virtual static TSelf MinNumber(TSelf x, TSelf y)
		{
			if (x != y)
			{
				if (INumberBase<TSelf>.IsNaN(y))
				{
					return x;
				}
				if (!(x < y))
				{
					return y;
				}
				return x;
			}
			else
			{
				if (!INumberBase<TSelf>.IsNegative(x))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x000A3500 File Offset: 0x000A1700
		public virtual static int Sign(TSelf value)
		{
			if (!(value != INumberBase<TSelf>.Zero))
			{
				return 0;
			}
			if (INumberBase<TSelf>.IsNaN(value))
			{
				ThrowHelper.ThrowArithmeticException(SR.Arithmetic_NaN);
			}
			if (!INumberBase<TSelf>.IsNegative(value))
			{
				return 1;
			}
			return -1;
		}
	}
}
