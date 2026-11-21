using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x020002A0 RID: 672
	[NullableContext(1)]
	public interface IBinaryInteger<[Nullable(0)] TSelf> : IBinaryNumber<TSelf>, IBitwiseOperators<TSelf, TSelf, TSelf>, INumber<TSelf>, IComparable, IComparable<TSelf>, IComparisonOperators<TSelf, TSelf, bool>, IEqualityOperators<TSelf, TSelf, bool>, IModulusOperators<TSelf, TSelf, TSelf>, INumberBase<TSelf>, IAdditionOperators<TSelf, TSelf, TSelf>, IAdditiveIdentity<TSelf, TSelf>, IDecrementOperators<TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEquatable<TSelf>, IIncrementOperators<TSelf>, IMultiplicativeIdentity<TSelf, TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, ISpanFormattable, IFormattable, ISpanParsable<TSelf>, IParsable<TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUtf8SpanFormattable, IUtf8SpanParsable<TSelf>, IShiftOperators<TSelf, int, TSelf> where TSelf : IBinaryInteger<TSelf>
	{
		// Token: 0x060032C1 RID: 12993 RVA: 0x000A2C04 File Offset: 0x000A0E04
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public virtual static ValueTuple<TSelf, TSelf> DivRem(TSelf left, TSelf right)
		{
			TSelf tself = left / right;
			return new ValueTuple<TSelf, TSelf>(tself, left - tself * right);
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x000A2C40 File Offset: 0x000A0E40
		public virtual static TSelf LeadingZeroCount(TSelf value)
		{
			if (!typeof(TSelf).IsValueType)
			{
				ArgumentNullException.ThrowIfNull(value, "value");
			}
			TSelf tself = INumberBase<TSelf>.CreateChecked<long>((long)value.GetByteCount() * 8L);
			if (value == INumberBase<TSelf>.Zero)
			{
				return INumberBase<TSelf>.CreateChecked<TSelf>(tself);
			}
			if (!INumberBase<TSelf>.IsNegative(value))
			{
				return tself - INumberBase<TSelf>.One ^ IBinaryNumber<TSelf>.Log2(value);
			}
			return INumberBase<TSelf>.Zero;
		}

		// Token: 0x060032C3 RID: 12995
		public abstract static TSelf PopCount(TSelf value);

		// Token: 0x060032C4 RID: 12996 RVA: 0x000A2CFC File Offset: 0x000A0EFC
		public virtual static TSelf ReadBigEndian(byte[] source, bool isUnsigned)
		{
			TSelf result;
			if (!IBinaryInteger<TSelf>.TryReadBigEndian(source, isUnsigned, out result))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return result;
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000A2D28 File Offset: 0x000A0F28
		public virtual static TSelf ReadBigEndian(byte[] source, int startIndex, bool isUnsigned)
		{
			TSelf result;
			if (!IBinaryInteger<TSelf>.TryReadBigEndian(source.AsSpan(startIndex), isUnsigned, out result))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return result;
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000A2D58 File Offset: 0x000A0F58
		[NullableContext(0)]
		[return: Nullable(1)]
		public virtual static TSelf ReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned)
		{
			TSelf result;
			if (!IBinaryInteger<TSelf>.TryReadBigEndian(source, isUnsigned, out result))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return result;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x000A2D7C File Offset: 0x000A0F7C
		public virtual static TSelf ReadLittleEndian(byte[] source, bool isUnsigned)
		{
			TSelf result;
			if (!IBinaryInteger<TSelf>.TryReadLittleEndian(source, isUnsigned, out result))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return result;
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x000A2DA8 File Offset: 0x000A0FA8
		public virtual static TSelf ReadLittleEndian(byte[] source, int startIndex, bool isUnsigned)
		{
			TSelf result;
			if (!IBinaryInteger<TSelf>.TryReadLittleEndian(source.AsSpan(startIndex), isUnsigned, out result))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return result;
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x000A2DD8 File Offset: 0x000A0FD8
		[NullableContext(0)]
		[return: Nullable(1)]
		public virtual static TSelf ReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned)
		{
			TSelf result;
			if (!IBinaryInteger<TSelf>.TryReadLittleEndian(source, isUnsigned, out result))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return result;
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000A2DFC File Offset: 0x000A0FFC
		public virtual static TSelf RotateLeft(TSelf value, int rotateAmount)
		{
			if (!typeof(TSelf).IsValueType)
			{
				ArgumentNullException.ThrowIfNull(value, "value");
			}
			int num = checked(value.GetByteCount() * 8);
			return value << rotateAmount | IShiftOperators<TSelf, int, TSelf>.op_UnsignedRightShift(value, num - rotateAmount);
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x000A2E64 File Offset: 0x000A1064
		public virtual static TSelf RotateRight(TSelf value, int rotateAmount)
		{
			if (!typeof(TSelf).IsValueType)
			{
				ArgumentNullException.ThrowIfNull(value, "value");
			}
			int num = checked(value.GetByteCount() * 8);
			return IShiftOperators<TSelf, int, TSelf>.op_UnsignedRightShift(value, rotateAmount) | value << num - rotateAmount;
		}

		// Token: 0x060032CC RID: 13004
		public abstract static TSelf TrailingZeroCount(TSelf value);

		// Token: 0x060032CD RID: 13005
		[NullableContext(0)]
		public abstract static bool TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, [Nullable(1)] out TSelf value);

		// Token: 0x060032CE RID: 13006
		[NullableContext(0)]
		public abstract static bool TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, [Nullable(1)] out TSelf value);

		// Token: 0x060032CF RID: 13007
		int GetByteCount();

		// Token: 0x060032D0 RID: 13008
		int GetShortestBitLength();

		// Token: 0x060032D1 RID: 13009
		[NullableContext(0)]
		bool TryWriteBigEndian(Span<byte> destination, out int bytesWritten);

		// Token: 0x060032D2 RID: 13010
		[NullableContext(0)]
		bool TryWriteLittleEndian(Span<byte> destination, out int bytesWritten);

		// Token: 0x060032D3 RID: 13011 RVA: 0x000A2ECC File Offset: 0x000A10CC
		int WriteBigEndian(byte[] destination)
		{
			int result;
			if (!this.TryWriteBigEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x000A2EF0 File Offset: 0x000A10F0
		int WriteBigEndian(byte[] destination, int startIndex)
		{
			int result;
			if (!this.TryWriteBigEndian(destination.AsSpan(startIndex), out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x000A2F14 File Offset: 0x000A1114
		[NullableContext(0)]
		int WriteBigEndian(Span<byte> destination)
		{
			int result;
			if (!this.TryWriteBigEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x000A2F34 File Offset: 0x000A1134
		int WriteLittleEndian(byte[] destination)
		{
			int result;
			if (!this.TryWriteLittleEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x000A2F58 File Offset: 0x000A1158
		int WriteLittleEndian(byte[] destination, int startIndex)
		{
			int result;
			if (!this.TryWriteLittleEndian(destination.AsSpan(startIndex), out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x000A2F7C File Offset: 0x000A117C
		[NullableContext(0)]
		int WriteLittleEndian(Span<byte> destination)
		{
			int result;
			if (!this.TryWriteLittleEndian(destination, out result))
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return result;
		}
	}
}
