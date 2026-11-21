using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x02000296 RID: 662
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct TotalOrderIeee754Comparer<[Nullable(0)] T> : IComparer<T>, IEqualityComparer<T>, IEquatable<TotalOrderIeee754Comparer<T>> where T : IFloatingPointIeee754<T>
	{
		// Token: 0x060030F5 RID: 12533 RVA: 0x0009FDE4 File Offset: 0x0009DFE4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Compare(T x, T y)
		{
			if (typeof(T) == typeof(float))
			{
				return TotalOrderIeee754Comparer<T>.<Compare>g__CompareIntegerSemantic|0_0<int>(BitConverter.SingleToInt32Bits((float)((object)x)), BitConverter.SingleToInt32Bits((float)((object)y)));
			}
			if (typeof(T) == typeof(double))
			{
				return TotalOrderIeee754Comparer<T>.<Compare>g__CompareIntegerSemantic|0_0<long>(BitConverter.DoubleToInt64Bits((double)((object)x)), BitConverter.DoubleToInt64Bits((double)((object)y)));
			}
			if (typeof(T) == typeof(Half))
			{
				return TotalOrderIeee754Comparer<T>.<Compare>g__CompareIntegerSemantic|0_0<short>(BitConverter.HalfToInt16Bits((Half)((object)x)), BitConverter.HalfToInt16Bits((Half)((object)y)));
			}
			return TotalOrderIeee754Comparer<T>.<Compare>g__CompareGeneric|0_1(x, y);
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x0009FEBB File Offset: 0x0009E0BB
		public bool Equals(T x, T y)
		{
			return this.Compare(x, y) == 0;
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x0009FEC8 File Offset: 0x0009E0C8
		[NullableContext(1)]
		public int GetHashCode([DisallowNull] T obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			return obj.GetHashCode();
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x000070DD File Offset: 0x000052DD
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TotalOrderIeee754Comparer<T> other)
		{
			return true;
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x0009FEE7 File Offset: 0x0009E0E7
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is TotalOrderIeee754Comparer<T>;
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0009FEF2 File Offset: 0x0009E0F2
		public override int GetHashCode()
		{
			return EqualityComparer<T>.Default.GetHashCode();
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x0009FEFE File Offset: 0x0009E0FE
		[CompilerGenerated]
		internal static int <Compare>g__CompareIntegerSemantic|0_0<TInteger>(TInteger x, TInteger y) where TInteger : struct, IBinaryInteger<TInteger>, ISignedNumber<TInteger>
		{
			if (!INumberBase<TInteger>.IsNegative(x) || !INumberBase<TInteger>.IsNegative(y))
			{
				return x.CompareTo(y);
			}
			return y.CompareTo(x);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x0009FF3C File Offset: 0x0009E13C
		[CompilerGenerated]
		internal static int <Compare>g__CompareGeneric|0_1(T x, T y)
		{
			if (x == null)
			{
				if (y != null)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (y == null)
				{
					return 1;
				}
				if (x < y)
				{
					return -1;
				}
				if (x > y)
				{
					return 1;
				}
				if (x == y)
				{
					if (!INumberBase<T>.IsZero(x))
					{
						return 0;
					}
					if (!INumberBase<T>.IsNegative(x))
					{
						return (!INumberBase<T>.IsPositive(y)) ? 1 : 0;
					}
					if (!INumberBase<T>.IsNegative(y))
					{
						return -1;
					}
					return 0;
				}
				else if (INumberBase<T>.IsNaN(x))
				{
					if (INumberBase<T>.IsNaN(y))
					{
						if (INumberBase<T>.IsNegative(x))
						{
							if (!INumberBase<T>.IsPositive(y))
							{
								return TotalOrderIeee754Comparer<T>.<Compare>g__CompareSignificand|0_2(y, x);
							}
							return -1;
						}
						else
						{
							if (!INumberBase<T>.IsNegative(y))
							{
								return TotalOrderIeee754Comparer<T>.<Compare>g__CompareSignificand|0_2(x, y);
							}
							return 1;
						}
					}
					else
					{
						if (!INumberBase<T>.IsPositive(x))
						{
							return -1;
						}
						return 1;
					}
				}
				else
				{
					if (!INumberBase<T>.IsNaN(y))
					{
						ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
						return 0;
					}
					if (!INumberBase<T>.IsPositive(y))
					{
						return 1;
					}
					return -1;
				}
			}
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000A006C File Offset: 0x0009E26C
		[CompilerGenerated]
		internal unsafe static int <Compare>g__CompareSignificand|0_2(T x, T y)
		{
			int significandBitLength = x.GetSignificandBitLength();
			int significandBitLength2 = y.GetSignificandBitLength();
			if (significandBitLength == significandBitLength2)
			{
				int significandByteCount = x.GetSignificandByteCount();
				int significandByteCount2 = y.GetSignificandByteCount();
				Span<byte> span;
				if (significandByteCount <= 256)
				{
					int num = significandByteCount;
					span = new Span<byte>(stackalloc byte[(UIntPtr)num], num);
				}
				else
				{
					span = new byte[significandByteCount];
				}
				Span<byte> span2 = span;
				if (significandByteCount2 <= 256)
				{
					int num = significandByteCount2;
					span = new Span<byte>(stackalloc byte[(UIntPtr)num], num);
				}
				else
				{
					span = new byte[significandByteCount2];
				}
				Span<byte> span3 = span;
				x.WriteSignificandBigEndian(span2);
				y.WriteSignificandBigEndian(span3);
				return span2.SequenceCompareTo(span3);
			}
			return significandBitLength.CompareTo(significandBitLength2);
		}
	}
}
