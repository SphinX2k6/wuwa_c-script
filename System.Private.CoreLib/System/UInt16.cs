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
	// Token: 0x020001E7 RID: 487
	[CLSCompliant(false)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct UInt16 : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<ushort>, IEquatable<ushort>, IBinaryInteger<ushort>, IBinaryNumber<ushort>, IBitwiseOperators<ushort, ushort, ushort>, INumber<ushort>, IComparisonOperators<ushort, ushort, bool>, IEqualityOperators<ushort, ushort, bool>, IModulusOperators<ushort, ushort, ushort>, INumberBase<ushort>, IAdditionOperators<ushort, ushort, ushort>, IAdditiveIdentity<ushort, ushort>, IDecrementOperators<ushort>, IDivisionOperators<ushort, ushort, ushort>, IIncrementOperators<ushort>, IMultiplicativeIdentity<ushort, ushort>, IMultiplyOperators<ushort, ushort, ushort>, ISpanParsable<ushort>, IParsable<ushort>, ISubtractionOperators<ushort, ushort, ushort>, IUnaryPlusOperators<ushort, ushort>, IUnaryNegationOperators<ushort, ushort>, IUtf8SpanFormattable, IUtf8SpanParsable<ushort>, IShiftOperators<ushort, int, ushort>, IMinMaxValue<ushort>, IUnsignedNumber<ushort>, IBinaryIntegerParseAndFormatInfo<ushort>
	{
		// Token: 0x060024AC RID: 9388 RVA: 0x00071EC3 File Offset: 0x000700C3
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is ushort)
			{
				return (int)(this - (ushort)value);
			}
			throw new ArgumentException(SR.Arg_MustBeUInt16);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00020F15 File Offset: 0x0001F115
		public int CompareTo(ushort value)
		{
			return (int)(this - value);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00071EE6 File Offset: 0x000700E6
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is ushort && this == (ushort)obj;
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00020EEB File Offset: 0x0001F0EB
		[NonVersionable]
		public bool Equals(ushort obj)
		{
			return this == obj;
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00021219 File Offset: 0x0001F419
		public override int GetHashCode()
		{
			return (int)this;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00071EFC File Offset: 0x000700FC
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.UInt32ToDecStr((uint)this);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00071EFC File Offset: 0x000700FC
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.UInt32ToDecStr((uint)this);
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00071F05 File Offset: 0x00070105
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatUInt32((uint)this, format, null);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x00071F10 File Offset: 0x00070110
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatUInt32((uint)this, format, provider);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00071F1B File Offset: 0x0007011B
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32<char>((uint)this, format, provider, destination, out charsWritten);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00071F29 File Offset: 0x00070129
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32<byte>((uint)this, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00071F37 File Offset: 0x00070137
		[NullableContext(1)]
		public static ushort Parse(string s)
		{
			return ushort.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00071F41 File Offset: 0x00070141
		[NullableContext(1)]
		public static ushort Parse(string s, NumberStyles style)
		{
			return ushort.Parse(s, style, null);
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00071F4B File Offset: 0x0007014B
		[NullableContext(1)]
		public static ushort Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return ushort.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00071F55 File Offset: 0x00070155
		[NullableContext(1)]
		public static ushort Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return ushort.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00071F6E File Offset: 0x0007016E
		public static ushort Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, ushort>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00071F83 File Offset: 0x00070183
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out ushort result)
		{
			return ushort.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x00071F8E File Offset: 0x0007018E
		public static bool TryParse(ReadOnlySpan<char> s, out ushort result)
		{
			return ushort.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x00071F99 File Offset: 0x00070199
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out ushort result)
		{
			return ushort.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x00071FA4 File Offset: 0x000701A4
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out ushort result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseBinaryInteger<char, ushort>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00071FCA File Offset: 0x000701CA
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out ushort result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, ushort>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt16;
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00071FE3 File Offset: 0x000701E3
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00071FEC File Offset: 0x000701EC
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00071FF5 File Offset: 0x000701F5
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00071FFE File Offset: 0x000701FE
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00072007 File Offset: 0x00070207
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00021219 File Offset: 0x0001F419
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00072010 File Offset: 0x00070210
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00072019 File Offset: 0x00070219
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00072022 File Offset: 0x00070222
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0007202B File Offset: 0x0007022B
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00072034 File Offset: 0x00070234
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0007203D File Offset: 0x0007023D
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00072046 File Offset: 0x00070246
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0007204F File Offset: 0x0007024F
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "UInt16", "DateTime"));
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0007206A File Offset: 0x0007026A
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000219B5 File Offset: 0x0001FBB5
		ushort IAdditionOperators<ushort, ushort, ushort>.op_Addition(ushort left, ushort right)
		{
			return left + right;
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000219BB File Offset: 0x0001FBBB
		ushort IAdditionOperators<ushort, ushort, ushort>.op_CheckedAddition(ushort left, ushort right)
		{
			return checked(left + right);
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060024D3 RID: 9427 RVA: 0x00007B65 File Offset: 0x00005D65
		ushort IAdditiveIdentity<ushort, ushort>.AdditiveIdentity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x0007207A File Offset: 0x0007027A
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<ushort, ushort> DivRem(ushort left, ushort right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000219C1 File Offset: 0x0001FBC1
		public static ushort LeadingZeroCount(ushort value)
		{
			return (ushort)(BitOperations.LeadingZeroCount((uint)value) - 16);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000219CD File Offset: 0x0001FBCD
		public static ushort PopCount(ushort value)
		{
			return (ushort)BitOperations.PopCount((uint)value);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000219D6 File Offset: 0x0001FBD6
		public static ushort RotateLeft(ushort value, int rotateAmount)
		{
			return (ushort)((int)value << (rotateAmount & 15) | value >> (16 - rotateAmount & 15));
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000219EF File Offset: 0x0001FBEF
		public static ushort RotateRight(ushort value, int rotateAmount)
		{
			return (ushort)(value >> (rotateAmount & 15) | (int)value << (16 - rotateAmount & 15));
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00021A08 File Offset: 0x0001FC08
		public static ushort TrailingZeroCount(ushort value)
		{
			return (ushort)(BitOperations.TrailingZeroCount((int)value << 16) - 16);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00072084 File Offset: 0x00070284
		unsafe bool IBinaryInteger<ushort>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out ushort value)
		{
			ushort num = 0;
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[0])))
				{
					value = num;
					return false;
				}
				if (source.Length > 2)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 2).ContainsAnyExcept(0))
					{
						value = num;
						return false;
					}
				}
				ref byte ptr2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 2)
				{
					ptr2 = Unsafe.Add<byte>(ref ptr2, source.Length - 2);
					num = Unsafe.ReadUnaligned<ushort>(ref ptr2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					num = BinaryPrimitives.ReverseEndianness(num);
				}
				else
				{
					num = (ushort)ptr2;
				}
			}
			value = num;
			return true;
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x0007211C File Offset: 0x0007031C
		unsafe bool IBinaryInteger<ushort>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out ushort value)
		{
			ushort num = 0;
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[source.Length - 1])))
				{
					value = num;
					return false;
				}
				if (source.Length > 2)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(2, ptr.Length - 2).ContainsAnyExcept(0))
					{
						value = num;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 2)
				{
					num = Unsafe.ReadUnaligned<ushort>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_76;
					}
				}
				num = (ushort)reference;
			}
			IL_76:
			value = num;
			return true;
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00021B37 File Offset: 0x0001FD37
		int IBinaryInteger<ushort>.GetShortestBitLength()
		{
			return (int)(16 - ushort.LeadingZeroCount(this));
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int IBinaryInteger<ushort>.GetByteCount()
		{
			return 2;
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000721A4 File Offset: 0x000703A4
		bool IBinaryInteger<ushort>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				ushort value = BinaryPrimitives.ReverseEndianness(this);
				Unsafe.WriteUnaligned<ushort>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000721E0 File Offset: 0x000703E0
		bool IBinaryInteger<ushort>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				ushort value = this;
				Unsafe.WriteUnaligned<ushort>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x00021BB6 File Offset: 0x0001FDB6
		ushort IBinaryNumber<ushort>.AllBitsSet
		{
			get
			{
				return 65535;
			}
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000200FE File Offset: 0x0001E2FE
		public static bool IsPow2(ushort value)
		{
			return BitOperations.IsPow2((uint)value);
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00072216 File Offset: 0x00070416
		public static ushort Log2(ushort value)
		{
			return (ushort)BitOperations.Log2((uint)value);
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00021BCD File Offset: 0x0001FDCD
		ushort IBitwiseOperators<ushort, ushort, ushort>.op_BitwiseAnd(ushort left, ushort right)
		{
			return left & right;
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00021BD3 File Offset: 0x0001FDD3
		ushort IBitwiseOperators<ushort, ushort, ushort>.op_BitwiseOr(ushort left, ushort right)
		{
			return left | right;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00021BD9 File Offset: 0x0001FDD9
		ushort IBitwiseOperators<ushort, ushort, ushort>.op_ExclusiveOr(ushort left, ushort right)
		{
			return left ^ right;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00021BDF File Offset: 0x0001FDDF
		ushort IBitwiseOperators<ushort, ushort, ushort>.op_OnesComplement(ushort value)
		{
			return ~value;
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00020126 File Offset: 0x0001E326
		bool IComparisonOperators<ushort, ushort, bool>.op_LessThan(ushort left, ushort right)
		{
			return left < right;
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x0002012C File Offset: 0x0001E32C
		bool IComparisonOperators<ushort, ushort, bool>.op_LessThanOrEqual(ushort left, ushort right)
		{
			return left <= right;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00020135 File Offset: 0x0001E335
		bool IComparisonOperators<ushort, ushort, bool>.op_GreaterThan(ushort left, ushort right)
		{
			return left > right;
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0002013B File Offset: 0x0001E33B
		bool IComparisonOperators<ushort, ushort, bool>.op_GreaterThanOrEqual(ushort left, ushort right)
		{
			return left >= right;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00021BE4 File Offset: 0x0001FDE4
		ushort IDecrementOperators<ushort>.op_Decrement(ushort value)
		{
			return value -= 1;
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00021BED File Offset: 0x0001FDED
		ushort IDecrementOperators<ushort>.op_CheckedDecrement(ushort value)
		{
			return checked(value -= 1);
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00021BF6 File Offset: 0x0001FDF6
		ushort IDivisionOperators<ushort, ushort, ushort>.op_Division(ushort left, ushort right)
		{
			return left / right;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<ushort, ushort, bool>.op_Equality(ushort left, ushort right)
		{
			return left == right;
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<ushort, ushort, bool>.op_Inequality(ushort left, ushort right)
		{
			return left != right;
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00021BFC File Offset: 0x0001FDFC
		ushort IIncrementOperators<ushort>.op_Increment(ushort value)
		{
			return value += 1;
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00021C05 File Offset: 0x0001FE05
		ushort IIncrementOperators<ushort>.op_CheckedIncrement(ushort value)
		{
			return checked(value += 1);
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x00007B65 File Offset: 0x00005D65
		ushort IMinMaxValue<ushort>.MinValue
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x00021BB6 File Offset: 0x0001FDB6
		ushort IMinMaxValue<ushort>.MaxValue
		{
			get
			{
				return 65535;
			}
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00021C0E File Offset: 0x0001FE0E
		ushort IModulusOperators<ushort, ushort, ushort>.op_Modulus(ushort left, ushort right)
		{
			return left % right;
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000070DD File Offset: 0x000052DD
		ushort IMultiplicativeIdentity<ushort, ushort>.MultiplicativeIdentity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00021C14 File Offset: 0x0001FE14
		ushort IMultiplyOperators<ushort, ushort, ushort>.op_Multiply(ushort left, ushort right)
		{
			return left * right;
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00021C1A File Offset: 0x0001FE1A
		ushort IMultiplyOperators<ushort, ushort, ushort>.op_CheckedMultiply(ushort left, ushort right)
		{
			return checked(left * right);
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0007221F File Offset: 0x0007041F
		public static ushort Clamp(ushort value, ushort min, ushort max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00007B62 File Offset: 0x00005D62
		ushort INumber<ushort>.CopySign(ushort value, ushort sign)
		{
			return value;
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00021C20 File Offset: 0x0001FE20
		public static ushort Max(ushort x, ushort y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00072229 File Offset: 0x00070429
		ushort INumber<ushort>.MaxNumber(ushort x, ushort y)
		{
			return ushort.Max(x, y);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00021C29 File Offset: 0x0001FE29
		public static ushort Min(ushort x, ushort y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00072232 File Offset: 0x00070432
		ushort INumber<ushort>.MinNumber(ushort x, ushort y)
		{
			return ushort.Min(x, y);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000201AE File Offset: 0x0001E3AE
		public static int Sign(ushort value)
		{
			return (value > 0) ? 1 : 0;
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000070DD File Offset: 0x000052DD
		ushort INumberBase<ushort>.One
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<ushort>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x00007B65 File Offset: 0x00005D65
		ushort INumberBase<ushort>.Zero
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00007B62 File Offset: 0x00005D62
		ushort INumberBase<ushort>.Abs(ushort value)
		{
			return value;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0007223C File Offset: 0x0007043C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			ushort result;
			if (typeof(TOther) == typeof(ushort))
			{
				result = (ushort)((object)value);
			}
			else if (!ushort.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<ushort>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00072294 File Offset: 0x00070494
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			ushort result;
			if (typeof(TOther) == typeof(ushort))
			{
				result = (ushort)((object)value);
			}
			else if (!ushort.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<ushort>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000722EC File Offset: 0x000704EC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			ushort result;
			if (typeof(TOther) == typeof(ushort))
			{
				result = (ushort)((object)value);
			}
			else if (!ushort.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<ushort>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ushort>.IsCanonical(ushort value)
		{
			return true;
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ushort>.IsComplexNumber(ushort value)
		{
			return false;
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000202BE File Offset: 0x0001E4BE
		public static bool IsEvenInteger(ushort value)
		{
			return (value & 1) == 0;
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ushort>.IsFinite(ushort value)
		{
			return true;
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ushort>.IsImaginaryNumber(ushort value)
		{
			return false;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ushort>.IsInfinity(ushort value)
		{
			return false;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ushort>.IsInteger(ushort value)
		{
			return true;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ushort>.IsNaN(ushort value)
		{
			return false;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ushort>.IsNegative(ushort value)
		{
			return false;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ushort>.IsNegativeInfinity(ushort value)
		{
			return false;
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000201AE File Offset: 0x0001E3AE
		bool INumberBase<ushort>.IsNormal(ushort value)
		{
			return value > 0;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000202C6 File Offset: 0x0001E4C6
		public static bool IsOddInteger(ushort value)
		{
			return (value & 1) > 0;
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ushort>.IsPositive(ushort value)
		{
			return true;
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ushort>.IsPositiveInfinity(ushort value)
		{
			return false;
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ushort>.IsRealNumber(ushort value)
		{
			return true;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ushort>.IsSubnormal(ushort value)
		{
			return false;
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x000202CE File Offset: 0x0001E4CE
		bool INumberBase<ushort>.IsZero(ushort value)
		{
			return value == 0;
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x00072229 File Offset: 0x00070429
		ushort INumberBase<ushort>.MaxMagnitude(ushort x, ushort y)
		{
			return ushort.Max(x, y);
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x00072229 File Offset: 0x00070429
		ushort INumberBase<ushort>.MaxMagnitudeNumber(ushort x, ushort y)
		{
			return ushort.Max(x, y);
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x00072232 File Offset: 0x00070432
		ushort INumberBase<ushort>.MinMagnitude(ushort x, ushort y)
		{
			return ushort.Min(x, y);
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x00072232 File Offset: 0x00070432
		ushort INumberBase<ushort>.MinMagnitudeNumber(ushort x, ushort y)
		{
			return ushort.Min(x, y);
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x00021C32 File Offset: 0x0001FE32
		ushort INumberBase<ushort>.MultiplyAddEstimate(ushort left, ushort right, ushort addend)
		{
			return left * right + addend;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x00072342 File Offset: 0x00070542
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ushort>.TryConvertFromChecked<TOther>(TOther value, out ushort result) where TOther : INumberBase<TOther>
		{
			return ushort.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x0007234C File Offset: 0x0007054C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out ushort result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (ushort)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (ushort)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal value2 = (decimal)((object)value);
				result = (ushort)value2;
				return true;
			}
			checked
			{
				if (typeof(TOther) == typeof(uint))
				{
					uint num = (uint)((object)value);
					result = (ushort)num;
					return true;
				}
				if (typeof(TOther) == typeof(ulong))
				{
					ulong num2 = (ulong)((object)value);
					result = (ushort)num2;
					return true;
				}
				if (typeof(TOther) == typeof(UInt128))
				{
					UInt128 value3 = (UInt128)((object)value);
					result = UInt128.op_CheckedExplicit(value3);
					return true;
				}
				if (typeof(TOther) == typeof(UIntPtr))
				{
					UIntPtr uintPtr = (UIntPtr)((object)value);
					result = (ushort)uintPtr;
					return true;
				}
				result = 0;
				return false;
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000724A4 File Offset: 0x000706A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ushort>.TryConvertFromSaturating<TOther>(TOther value, out ushort result) where TOther : INumberBase<TOther>
		{
			return ushort.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000724B0 File Offset: 0x000706B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out ushort result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (ushort)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (ushort)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 65535m) ? 65535 : ((num <= 0m) ? 0 : ((ushort)num)));
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num2 = (uint)((object)value);
				result = ((num2 >= 65535U) ? 65535 : ((ushort)num2));
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num3 = (ulong)((object)value);
				result = ((num3 >= 65535UL) ? 65535 : ((ushort)num3));
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)((object)value);
				result = ((@uint >= 65535) ? 65535 : ((ushort)@uint));
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = ((uintPtr >= (UIntPtr)((IntPtr)65535)) ? 65535 : ((ushort)uintPtr));
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x0007267C File Offset: 0x0007087C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ushort>.TryConvertFromTruncating<TOther>(TOther value, out ushort result) where TOther : INumberBase<TOther>
		{
			return ushort.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00072688 File Offset: 0x00070888
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out ushort result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (ushort)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (ushort)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 65535m) ? 65535 : ((num <= 0m) ? 0 : ((ushort)num)));
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num2 = (uint)((object)value);
				result = (ushort)num2;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num3 = (ulong)((object)value);
				result = (ushort)num3;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value2 = (UInt128)((object)value);
				result = (ushort)value2;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = (ushort)uintPtr;
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0007280C File Offset: 0x00070A0C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ushort>.TryConvertToChecked<TOther>(ushort value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = checked((short)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				result = (TOther)((object)((int)value));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((ulong)value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((UIntPtr)value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = checked((sbyte)value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)value;
				result = (TOther)((object)num4);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000729EC File Offset: 0x00070BEC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ushort>.TryConvertToSaturating<TOther>(ushort value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (value >= 32767) ? short.MaxValue : ((short)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				result = (TOther)((object)((int)value));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((ulong)value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((UIntPtr)value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (value >= 127) ? sbyte.MaxValue : ((sbyte)value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)value;
				result = (TOther)((object)num4);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00072BE4 File Offset: 0x00070DE4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ushort>.TryConvertToTruncating<TOther>(ushort value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)value;
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				result = (TOther)((object)((int)value));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((ulong)value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((UIntPtr)value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)value;
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)value;
				result = (TOther)((object)num4);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00072DC3 File Offset: 0x00070FC3
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out ushort result)
		{
			return ushort.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x000226C6 File Offset: 0x000208C6
		ushort IShiftOperators<ushort, int, ushort>.op_LeftShift(ushort value, int shiftAmount)
		{
			return (ushort)(value << shiftAmount);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x000226CF File Offset: 0x000208CF
		ushort IShiftOperators<ushort, int, ushort>.op_RightShift(ushort value, int shiftAmount)
		{
			return (ushort)(value >> shiftAmount);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000226D8 File Offset: 0x000208D8
		ushort IShiftOperators<ushort, int, ushort>.op_UnsignedRightShift(ushort value, int shiftAmount)
		{
			return (ushort)((uint)value >> shiftAmount);
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00072DCE File Offset: 0x00070FCE
		public static ushort Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return ushort.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00072DD8 File Offset: 0x00070FD8
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out ushort result)
		{
			return ushort.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000226EA File Offset: 0x000208EA
		ushort ISubtractionOperators<ushort, ushort, ushort>.op_Subtraction(ushort left, ushort right)
		{
			return left - right;
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x000226F0 File Offset: 0x000208F0
		ushort ISubtractionOperators<ushort, ushort, ushort>.op_CheckedSubtraction(ushort left, ushort right)
		{
			return checked(left - right);
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000226F6 File Offset: 0x000208F6
		ushort IUnaryNegationOperators<ushort, ushort>.op_UnaryNegation(ushort value)
		{
			return -value;
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x000226FB File Offset: 0x000208FB
		ushort IUnaryNegationOperators<ushort, ushort>.op_CheckedUnaryNegation(ushort value)
		{
			return checked(0 - value);
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00022701 File Offset: 0x00020901
		ushort IUnaryPlusOperators<ushort, ushort>.op_UnaryPlus(ushort value)
		{
			return value;
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00072DE3 File Offset: 0x00070FE3
		public static ushort Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, ushort>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00072DF8 File Offset: 0x00070FF8
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out ushort result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, ushort>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00072E11 File Offset: 0x00071011
		public static ushort Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return ushort.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00072E1B File Offset: 0x0007101B
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out ushort result)
		{
			return ushort.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IBinaryIntegerParseAndFormatInfo<ushort>.IsSigned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x00022705 File Offset: 0x00020905
		int IBinaryIntegerParseAndFormatInfo<ushort>.MaxDigitCount
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x000211FB File Offset: 0x0001F3FB
		int IBinaryIntegerParseAndFormatInfo<ushort>.MaxHexDigitCount
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x00022708 File Offset: 0x00020908
		ushort IBinaryIntegerParseAndFormatInfo<ushort>.MaxValueDiv10
		{
			get
			{
				return 6553;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x00072E26 File Offset: 0x00071026
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<ushort>.OverflowMessage
		{
			get
			{
				return SR.Overflow_UInt16;
			}
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00020135 File Offset: 0x0001E335
		bool IBinaryIntegerParseAndFormatInfo<ushort>.IsGreaterThanAsUnsigned(ushort left, ushort right)
		{
			return left > right;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00022716 File Offset: 0x00020916
		ushort IBinaryIntegerParseAndFormatInfo<ushort>.MultiplyBy10(ushort value)
		{
			return value * 10;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0002271D File Offset: 0x0002091D
		ushort IBinaryIntegerParseAndFormatInfo<ushort>.MultiplyBy16(ushort value)
		{
			return value * 16;
		}

		// Token: 0x040006E2 RID: 1762
		private readonly ushort m_value;

		// Token: 0x040006E3 RID: 1763
		public const ushort MaxValue = 65535;

		// Token: 0x040006E4 RID: 1764
		public const ushort MinValue = 0;
	}
}
