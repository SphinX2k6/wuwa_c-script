using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x0200014D RID: 333
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Int64 : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<long>, IEquatable<long>, IBinaryInteger<long>, IBinaryNumber<long>, IBitwiseOperators<long, long, long>, INumber<long>, IComparisonOperators<long, long, bool>, IEqualityOperators<long, long, bool>, IModulusOperators<long, long, long>, INumberBase<long>, IAdditionOperators<long, long, long>, IAdditiveIdentity<long, long>, IDecrementOperators<long>, IDivisionOperators<long, long, long>, IIncrementOperators<long>, IMultiplicativeIdentity<long, long>, IMultiplyOperators<long, long, long>, ISpanParsable<long>, IParsable<long>, ISubtractionOperators<long, long, long>, IUnaryPlusOperators<long, long>, IUnaryNegationOperators<long, long>, IUtf8SpanFormattable, IUtf8SpanParsable<long>, IShiftOperators<long, int, long>, IMinMaxValue<long>, ISignedNumber<long>, IBinaryIntegerParseAndFormatInfo<long>
	{
		// Token: 0x06001517 RID: 5399 RVA: 0x000413F1 File Offset: 0x0003F5F1
		public static Int128 BigMul(long left, long right)
		{
			return Math.BigMul(left, right);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000413FC File Offset: 0x0003F5FC
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is long))
			{
				throw new ArgumentException(SR.Arg_MustBeInt64);
			}
			long num = (long)value;
			if (this < num)
			{
				return -1;
			}
			if (this > num)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00041437 File Offset: 0x0003F637
		public int CompareTo(long value)
		{
			if (this < value)
			{
				return -1;
			}
			if (this > value)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00041448 File Offset: 0x0003F648
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is long && this == (long)obj;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0004145E File Offset: 0x0003F65E
		[NonVersionable]
		public bool Equals(long obj)
		{
			return this == obj;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00041465 File Offset: 0x0003F665
		public override int GetHashCode()
		{
			return (int)this ^ (int)(this >> 32);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00041471 File Offset: 0x0003F671
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.Int64ToDecStr(this);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0004147A File Offset: 0x0003F67A
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatInt64(this, null, provider);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00041485 File Offset: 0x0003F685
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatInt64(this, format, null);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00041490 File Offset: 0x0003F690
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatInt64(this, format, provider);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0004149B File Offset: 0x0003F69B
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt64<char>(this, format, provider, destination, out charsWritten);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000414A9 File Offset: 0x0003F6A9
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt64<byte>(this, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000414B7 File Offset: 0x0003F6B7
		[NullableContext(1)]
		public static long Parse(string s)
		{
			return long.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000414C1 File Offset: 0x0003F6C1
		[NullableContext(1)]
		public static long Parse(string s, NumberStyles style)
		{
			return long.Parse(s, style, null);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000414CB File Offset: 0x0003F6CB
		[NullableContext(1)]
		public static long Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return long.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000414D5 File Offset: 0x0003F6D5
		[NullableContext(1)]
		public static long Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return long.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000414EE File Offset: 0x0003F6EE
		public static long Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, long>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00041503 File Offset: 0x0003F703
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out long result)
		{
			return long.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0004150E File Offset: 0x0003F70E
		public static bool TryParse(ReadOnlySpan<char> s, out long result)
		{
			return long.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00041519 File Offset: 0x0003F719
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out long result)
		{
			return long.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00041524 File Offset: 0x0003F724
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out long result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0L;
				return false;
			}
			return Number.TryParseBinaryInteger<char, long>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0004154B File Offset: 0x0003F74B
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out long result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, long>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00030502 File Offset: 0x0002E702
		public TypeCode GetTypeCode()
		{
			return TypeCode.Int64;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00041564 File Offset: 0x0003F764
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0004156D File Offset: 0x0003F76D
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00041576 File Offset: 0x0003F776
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0004157F File Offset: 0x0003F77F
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00041588 File Offset: 0x0003F788
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00041591 File Offset: 0x0003F791
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0004159A File Offset: 0x0003F79A
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000415A3 File Offset: 0x0003F7A3
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000415AC File Offset: 0x0003F7AC
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000415B0 File Offset: 0x0003F7B0
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000415B9 File Offset: 0x0003F7B9
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000415C2 File Offset: 0x0003F7C2
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000415CB File Offset: 0x0003F7CB
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000415D4 File Offset: 0x0003F7D4
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Int64", "DateTime"));
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x000415EF File Offset: 0x0003F7EF
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0002EA29 File Offset: 0x0002CC29
		long IAdditionOperators<long, long, long>.op_Addition(long left, long right)
		{
			return left + right;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x00040289 File Offset: 0x0003E489
		long IAdditionOperators<long, long, long>.op_CheckedAddition(long left, long right)
		{
			return checked(left + right);
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000304C1 File Offset: 0x0002E6C1
		long IAdditiveIdentity<long, long>.AdditiveIdentity
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x000415FF File Offset: 0x0003F7FF
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<long, long> DivRem(long left, long right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00041608 File Offset: 0x0003F808
		[Intrinsic]
		public static long LeadingZeroCount(long value)
		{
			return (long)BitOperations.LeadingZeroCount((ulong)value);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00041611 File Offset: 0x0003F811
		[Intrinsic]
		public static long PopCount(long value)
		{
			return (long)BitOperations.PopCount((ulong)value);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0004161A File Offset: 0x0003F81A
		[Intrinsic]
		public static long RotateLeft(long value, int rotateAmount)
		{
			return (long)BitOperations.RotateLeft((ulong)value, rotateAmount);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00041623 File Offset: 0x0003F823
		[Intrinsic]
		public static long RotateRight(long value, int rotateAmount)
		{
			return (long)BitOperations.RotateRight((ulong)value, rotateAmount);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0004162C File Offset: 0x0003F82C
		[Intrinsic]
		public static long TrailingZeroCount(long value)
		{
			return (long)BitOperations.TrailingZeroCount(value);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x00041638 File Offset: 0x0003F838
		unsafe bool IBinaryInteger<long>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out long value)
		{
			long num = 0L;
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[0]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 8)
				{
					value = num;
					return false;
				}
				if (source.Length > 8)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 8).ContainsAnyExcept((byte)b))
					{
						value = num;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[source.Length - 8])))
					{
						value = num;
						return false;
					}
				}
				ref byte source2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 8)
				{
					source2 = Unsafe.Add<byte>(ref source2, source.Length - 8);
					num = Unsafe.ReadUnaligned<long>(ref source2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					num = BinaryPrimitives.ReverseEndianness(num);
				}
				else
				{
					for (int i = 0; i < source.Length; i++)
					{
						num <<= 8;
						num |= (long)((ulong)(*Unsafe.Add<byte>(ref source2, i)));
					}
					if (!isUnsigned)
					{
						num |= -9223372036854775808L >> (8 - source.Length) * 8 - 1;
					}
				}
			}
			value = num;
			return true;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00041754 File Offset: 0x0003F954
		unsafe bool IBinaryInteger<long>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out long value)
		{
			long num = 0L;
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[source.Length - 1]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 8)
				{
					value = num;
					return false;
				}
				if (source.Length > 8)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(8, ptr.Length - 8).ContainsAnyExcept((byte)b))
					{
						value = num;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[7])))
					{
						value = num;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 8)
				{
					num = Unsafe.ReadUnaligned<long>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_108;
					}
				}
				for (int i = 0; i < source.Length; i++)
				{
					num <<= 8;
					num |= (long)((ulong)(*Unsafe.Add<byte>(ref reference, i)));
				}
				num <<= (8 - source.Length) * 8;
				num = BinaryPrimitives.ReverseEndianness(num);
				if (!isUnsigned)
				{
					num |= -9223372036854775808L >> (8 - source.Length) * 8 - 1;
				}
			}
			IL_108:
			value = num;
			return true;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00041870 File Offset: 0x0003FA70
		int IBinaryInteger<long>.GetShortestBitLength()
		{
			long num = this;
			if (num >= 0L)
			{
				return 64 - BitOperations.LeadingZeroCount((ulong)num);
			}
			return 65 - BitOperations.LeadingZeroCount((ulong)(~(ulong)num));
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int IBinaryInteger<long>.GetByteCount()
		{
			return 8;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0004189C File Offset: 0x0003FA9C
		bool IBinaryInteger<long>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				long value = BinaryPrimitives.ReverseEndianness(this);
				Unsafe.WriteUnaligned<long>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000418D8 File Offset: 0x0003FAD8
		bool IBinaryInteger<long>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				long value = this;
				Unsafe.WriteUnaligned<long>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0004190E File Offset: 0x0003FB0E
		long IBinaryNumber<long>.AllBitsSet
		{
			get
			{
				return -1L;
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00041912 File Offset: 0x0003FB12
		public static bool IsPow2(long value)
		{
			return BitOperations.IsPow2(value);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0004191A File Offset: 0x0003FB1A
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long Log2(long value)
		{
			if (value < 0L)
			{
				ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			return (long)BitOperations.Log2((ulong)value);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00040597 File Offset: 0x0003E797
		long IBitwiseOperators<long, long, long>.op_BitwiseAnd(long left, long right)
		{
			return left & right;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0004059C File Offset: 0x0003E79C
		long IBitwiseOperators<long, long, long>.op_BitwiseOr(long left, long right)
		{
			return left | right;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x000405A1 File Offset: 0x0003E7A1
		long IBitwiseOperators<long, long, long>.op_ExclusiveOr(long left, long right)
		{
			return left ^ right;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000405A6 File Offset: 0x0003E7A6
		long IBitwiseOperators<long, long, long>.op_OnesComplement(long value)
		{
			return ~value;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00020126 File Offset: 0x0001E326
		bool IComparisonOperators<long, long, bool>.op_LessThan(long left, long right)
		{
			return left < right;
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0002012C File Offset: 0x0001E32C
		bool IComparisonOperators<long, long, bool>.op_LessThanOrEqual(long left, long right)
		{
			return left <= right;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00020135 File Offset: 0x0001E335
		bool IComparisonOperators<long, long, bool>.op_GreaterThan(long left, long right)
		{
			return left > right;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0002013B File Offset: 0x0001E33B
		bool IComparisonOperators<long, long, bool>.op_GreaterThanOrEqual(long left, long right)
		{
			return left >= right;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0004192D File Offset: 0x0003FB2D
		long IDecrementOperators<long>.op_Decrement(long value)
		{
			return value -= 1L;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00041936 File Offset: 0x0003FB36
		long IDecrementOperators<long>.op_CheckedDecrement(long value)
		{
			return checked(value -= 1L);
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0002EAEC File Offset: 0x0002CCEC
		long IDivisionOperators<long, long, long>.op_Division(long left, long right)
		{
			return left / right;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<long, long, bool>.op_Equality(long left, long right)
		{
			return left == right;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<long, long, bool>.op_Inequality(long left, long right)
		{
			return left != right;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0004193F File Offset: 0x0003FB3F
		long IIncrementOperators<long>.op_Increment(long value)
		{
			return value += 1L;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00041948 File Offset: 0x0003FB48
		long IIncrementOperators<long>.op_CheckedIncrement(long value)
		{
			return checked(value += 1L);
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00041951 File Offset: 0x0003FB51
		long IMinMaxValue<long>.MinValue
		{
			get
			{
				return -9223372036854775808L;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0004195C File Offset: 0x0003FB5C
		long IMinMaxValue<long>.MaxValue
		{
			get
			{
				return 9223372036854775807L;
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0002EE4D File Offset: 0x0002D04D
		long IModulusOperators<long, long, long>.op_Modulus(long left, long right)
		{
			return left % right;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00041967 File Offset: 0x0003FB67
		long IMultiplicativeIdentity<long, long>.MultiplicativeIdentity
		{
			get
			{
				return 1L;
			}
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0002EE5D File Offset: 0x0002D05D
		long IMultiplyOperators<long, long, long>.op_Multiply(long left, long right)
		{
			return left * right;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x000405D8 File Offset: 0x0003E7D8
		long IMultiplyOperators<long, long, long>.op_CheckedMultiply(long left, long right)
		{
			return checked(left * right);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0004196B File Offset: 0x0003FB6B
		public static long Clamp(long value, long min, long max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00041978 File Offset: 0x0003FB78
		public static long CopySign(long value, long sign)
		{
			long num = value;
			if (num < 0L)
			{
				num = -num;
			}
			if (sign >= 0L)
			{
				if (num < 0L)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
				return num;
			}
			return -num;
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x000419A2 File Offset: 0x0003FBA2
		public static long Max(long x, long y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x000419AB File Offset: 0x0003FBAB
		long INumber<long>.MaxNumber(long x, long y)
		{
			return long.Max(x, y);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000419B4 File Offset: 0x0003FBB4
		public static long Min(long x, long y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x000419BD File Offset: 0x0003FBBD
		long INumber<long>.MinNumber(long x, long y)
		{
			return long.Min(x, y);
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x000419C6 File Offset: 0x0003FBC6
		public static int Sign(long value)
		{
			return Math.Sign(value);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00041967 File Offset: 0x0003FB67
		long INumberBase<long>.One
		{
			get
			{
				return 1L;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<long>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x000304C1 File Offset: 0x0002E6C1
		long INumberBase<long>.Zero
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000419CE File Offset: 0x0003FBCE
		public static long Abs(long value)
		{
			return Math.Abs(value);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000419D8 File Offset: 0x0003FBD8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			long result;
			if (typeof(TOther) == typeof(long))
			{
				result = (long)((object)value);
			}
			else if (!long.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<long>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00041A30 File Offset: 0x0003FC30
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			long result;
			if (typeof(TOther) == typeof(long))
			{
				result = (long)((object)value);
			}
			else if (!long.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<long>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00041A88 File Offset: 0x0003FC88
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			long result;
			if (typeof(TOther) == typeof(long))
			{
				result = (long)((object)value);
			}
			else if (!long.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<long>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<long>.IsCanonical(long value)
		{
			return true;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<long>.IsComplexNumber(long value)
		{
			return false;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00041ADE File Offset: 0x0003FCDE
		public static bool IsEvenInteger(long value)
		{
			return (value & 1L) == 0L;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<long>.IsFinite(long value)
		{
			return true;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<long>.IsImaginaryNumber(long value)
		{
			return false;
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<long>.IsInfinity(long value)
		{
			return false;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<long>.IsInteger(long value)
		{
			return true;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<long>.IsNaN(long value)
		{
			return false;
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00041AE8 File Offset: 0x0003FCE8
		public static bool IsNegative(long value)
		{
			return value < 0L;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<long>.IsNegativeInfinity(long value)
		{
			return false;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000231A1 File Offset: 0x000213A1
		bool INumberBase<long>.IsNormal(long value)
		{
			return value != 0L;
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00041AEF File Offset: 0x0003FCEF
		public static bool IsOddInteger(long value)
		{
			return (value & 1L) != 0L;
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00041AF9 File Offset: 0x0003FCF9
		public static bool IsPositive(long value)
		{
			return value >= 0L;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<long>.IsPositiveInfinity(long value)
		{
			return false;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<long>.IsRealNumber(long value)
		{
			return true;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<long>.IsSubnormal(long value)
		{
			return false;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00041B03 File Offset: 0x0003FD03
		bool INumberBase<long>.IsZero(long value)
		{
			return value == 0L;
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00041B0C File Offset: 0x0003FD0C
		public static long MaxMagnitude(long x, long y)
		{
			long num = x;
			if (num < 0L)
			{
				num = -num;
				if (num < 0L)
				{
					return x;
				}
			}
			long num2 = y;
			if (num2 < 0L)
			{
				num2 = -num2;
				if (num2 < 0L)
				{
					return y;
				}
			}
			if (num > num2)
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!long.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x00041B52 File Offset: 0x0003FD52
		long INumberBase<long>.MaxMagnitudeNumber(long x, long y)
		{
			return long.MaxMagnitude(x, y);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00041B5C File Offset: 0x0003FD5C
		public static long MinMagnitude(long x, long y)
		{
			long num = x;
			if (num < 0L)
			{
				num = -num;
				if (num < 0L)
				{
					return y;
				}
			}
			long num2 = y;
			if (num2 < 0L)
			{
				num2 = -num2;
				if (num2 < 0L)
				{
					return x;
				}
			}
			if (num < num2)
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!long.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00041BA2 File Offset: 0x0003FDA2
		long INumberBase<long>.MinMagnitudeNumber(long x, long y)
		{
			return long.MinMagnitude(x, y);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		long INumberBase<long>.MultiplyAddEstimate(long left, long right, long addend)
		{
			return left * right + addend;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00041BAB File Offset: 0x0003FDAB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<long>.TryConvertFromChecked<TOther>(TOther value, out long result) where TOther : INumberBase<TOther>
		{
			return long.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00041BB4 File Offset: 0x0003FDB4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out long result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = checked((long)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half value2 = (Half)((object)value);
				result = Half.op_CheckedExplicit(value2);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (long)num2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = (long)num3;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value3 = (Int128)((object)value);
				result = Int128.op_CheckedExplicit(value3);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = (long)intPtr;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (long)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)((object)value);
				result = checked((long)num4);
				return true;
			}
			result = 0L;
			return false;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00041D3E File Offset: 0x0003FF3E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<long>.TryConvertFromSaturating<TOther>(TOther value, out long result) where TOther : INumberBase<TOther>
		{
			return long.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00041D48 File Offset: 0x0003FF48
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out long result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 9.223372036854776E+18) ? 9223372036854775807L : ((num <= -9.223372036854776E+18) ? -9223372036854775808L : ((long)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half == Half.PositiveInfinity) ? 9223372036854775807L : ((half == Half.NegativeInfinity) ? -9223372036854775808L : ((long)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (long)num2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = (long)num3;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (Int128)((object)value);
				result = ((@int >= 9223372036854775807L) ? 9223372036854775807L : ((@int <= -9223372036854775808L) ? -9223372036854775808L : ((long)@int)));
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = (long)intPtr;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (long)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)((object)value);
				result = ((num4 >= 9.223372E+18f) ? 9223372036854775807L : ((num4 <= -9.223372E+18f) ? -9223372036854775808L : ((long)num4)));
				return true;
			}
			result = 0L;
			return false;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00041F9C File Offset: 0x0004019C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<long>.TryConvertFromTruncating<TOther>(TOther value, out long result) where TOther : INumberBase<TOther>
		{
			return long.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00041FA8 File Offset: 0x000401A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out long result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 9.223372036854776E+18) ? 9223372036854775807L : ((num <= -9.223372036854776E+18) ? -9223372036854775808L : ((long)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half == Half.PositiveInfinity) ? 9223372036854775807L : ((half == Half.NegativeInfinity) ? -9223372036854775808L : ((long)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (long)num2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = (long)num3;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value2 = (Int128)((object)value);
				result = (long)value2;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = (long)intPtr;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (long)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)((object)value);
				result = ((num4 >= 9.223372E+18f) ? 9223372036854775807L : ((num4 <= -9.223372E+18f) ? -9223372036854775808L : ((long)num4)));
				return true;
			}
			result = 0L;
			return false;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000421B8 File Offset: 0x000403B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<long>.TryConvertToChecked<TOther>(long value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			checked
			{
				if (typeof(TOther) == typeof(byte))
				{
					byte b = (byte)value;
					result = (TOther)((object)b);
					return true;
				}
				if (typeof(TOther) == typeof(char))
				{
					char c = (char)value;
					result = (TOther)((object)c);
					return true;
				}
				if (typeof(TOther) == typeof(decimal))
				{
					decimal num = value;
					result = (TOther)((object)num);
					return true;
				}
				if (typeof(TOther) == typeof(ushort))
				{
					ushort num2 = (ushort)value;
					result = (TOther)((object)num2);
					return true;
				}
				if (typeof(TOther) == typeof(uint))
				{
					uint num3 = (uint)value;
					result = (TOther)((object)num3);
					return true;
				}
				if (typeof(TOther) == typeof(ulong))
				{
					ulong num4 = (ulong)value;
					result = (TOther)((object)num4);
					return true;
				}
				if (typeof(TOther) == typeof(UInt128))
				{
					UInt128 @uint = UInt128.op_CheckedExplicit(value);
					result = (TOther)((object)@uint);
					return true;
				}
				if (typeof(TOther) == typeof(UIntPtr))
				{
					UIntPtr uintPtr = (UIntPtr)value;
					result = (TOther)((object)uintPtr);
					return true;
				}
				result = default(TOther);
				return false;
			}
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00042368 File Offset: 0x00040568
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<long>.TryConvertToSaturating<TOther>(long value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= 255L) ? byte.MaxValue : ((value <= 0L) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value >= 65535L) ? char.MaxValue : ((value <= 0L) ? '\0' : ((char)value));
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (value >= 65535L) ? ushort.MaxValue : ((value <= 0L) ? 0 : ((ushort)value));
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (value >= (long)((ulong)-1)) ? uint.MaxValue : ((value <= 0L) ? 0U : ((uint)value));
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((value <= 0L) ? 0L : value);
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (value <= 0L) ? UInt128.MinValue : ((UInt128)value);
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((value <= 0L) ? ((IntPtr)0) : ((IntPtr)((UIntPtr)value)));
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0004258C File Offset: 0x0004078C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<long>.TryConvertToTruncating<TOther>(long value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)value;
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)value;
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)value;
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)value;
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				result = (TOther)((object)((ulong)value));
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)value;
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)value;
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00042738 File Offset: 0x00040938
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out long result)
		{
			return long.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00042743 File Offset: 0x00040943
		long IShiftOperators<long, int, long>.op_LeftShift(long value, int shiftAmount)
		{
			return value << shiftAmount;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x0004274B File Offset: 0x0004094B
		long IShiftOperators<long, int, long>.op_RightShift(long value, int shiftAmount)
		{
			return value >> shiftAmount;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00042753 File Offset: 0x00040953
		long IShiftOperators<long, int, long>.op_UnsignedRightShift(long value, int shiftAmount)
		{
			return (long)((ulong)value >> shiftAmount);
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x0004190E File Offset: 0x0003FB0E
		long ISignedNumber<long>.NegativeOne
		{
			get
			{
				return -1L;
			}
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0004275B File Offset: 0x0004095B
		public static long Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return long.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00042765 File Offset: 0x00040965
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out long result)
		{
			return long.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0002FA55 File Offset: 0x0002DC55
		long ISubtractionOperators<long, long, long>.op_Subtraction(long left, long right)
		{
			return left - right;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00041384 File Offset: 0x0003F584
		long ISubtractionOperators<long, long, long>.op_CheckedSubtraction(long left, long right)
		{
			return checked(left - right);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0003046E File Offset: 0x0002E66E
		long IUnaryNegationOperators<long, long>.op_UnaryNegation(long value)
		{
			return -value;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00042770 File Offset: 0x00040970
		long IUnaryNegationOperators<long, long>.op_CheckedUnaryNegation(long value)
		{
			return checked(0L - value);
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00007B62 File Offset: 0x00005D62
		long IUnaryPlusOperators<long, long>.op_UnaryPlus(long value)
		{
			return value;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00042776 File Offset: 0x00040976
		public static long Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, long>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0004278B File Offset: 0x0004098B
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out long result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, long>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000427A4 File Offset: 0x000409A4
		public static long Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return long.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000427AE File Offset: 0x000409AE
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out long result)
		{
			return long.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x000070DD File Offset: 0x000052DD
		bool IBinaryIntegerParseAndFormatInfo<long>.IsSigned
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x000427B9 File Offset: 0x000409B9
		int IBinaryIntegerParseAndFormatInfo<long>.MaxDigitCount
		{
			get
			{
				return 19;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00027484 File Offset: 0x00025684
		int IBinaryIntegerParseAndFormatInfo<long>.MaxHexDigitCount
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000427BD File Offset: 0x000409BD
		long IBinaryIntegerParseAndFormatInfo<long>.MaxValueDiv10
		{
			get
			{
				return 922337203685477580L;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000427C8 File Offset: 0x000409C8
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<long>.OverflowMessage
		{
			get
			{
				return SR.Overflow_Int64;
			}
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000413DF File Offset: 0x0003F5DF
		bool IBinaryIntegerParseAndFormatInfo<long>.IsGreaterThanAsUnsigned(long left, long right)
		{
			return left > right;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x000427CF File Offset: 0x000409CF
		long IBinaryIntegerParseAndFormatInfo<long>.MultiplyBy10(long value)
		{
			return value * 10L;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000427D6 File Offset: 0x000409D6
		long IBinaryIntegerParseAndFormatInfo<long>.MultiplyBy16(long value)
		{
			return value * 16L;
		}

		// Token: 0x040004C2 RID: 1218
		private readonly long m_value;

		// Token: 0x040004C3 RID: 1219
		public const long MaxValue = 9223372036854775807L;

		// Token: 0x040004C4 RID: 1220
		public const long MinValue = -9223372036854775808L;
	}
}
