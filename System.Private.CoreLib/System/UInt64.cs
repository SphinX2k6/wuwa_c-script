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
	// Token: 0x020001E9 RID: 489
	[CLSCompliant(false)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct UInt64 : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<ulong>, IEquatable<ulong>, IBinaryInteger<ulong>, IBinaryNumber<ulong>, IBitwiseOperators<ulong, ulong, ulong>, INumber<ulong>, IComparisonOperators<ulong, ulong, bool>, IEqualityOperators<ulong, ulong, bool>, IModulusOperators<ulong, ulong, ulong>, INumberBase<ulong>, IAdditionOperators<ulong, ulong, ulong>, IAdditiveIdentity<ulong, ulong>, IDecrementOperators<ulong>, IDivisionOperators<ulong, ulong, ulong>, IIncrementOperators<ulong>, IMultiplicativeIdentity<ulong, ulong>, IMultiplyOperators<ulong, ulong, ulong>, ISpanParsable<ulong>, IParsable<ulong>, ISubtractionOperators<ulong, ulong, ulong>, IUnaryPlusOperators<ulong, ulong>, IUnaryNegationOperators<ulong, ulong>, IUtf8SpanFormattable, IUtf8SpanParsable<ulong>, IShiftOperators<ulong, int, ulong>, IMinMaxValue<ulong>, IUnsignedNumber<ulong>, IBinaryIntegerParseAndFormatInfo<ulong>
	{
		// Token: 0x060025CD RID: 9677 RVA: 0x00073E65 File Offset: 0x00072065
		public static UInt128 BigMul(ulong left, ulong right)
		{
			return Math.BigMul(left, right);
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00073E70 File Offset: 0x00072070
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is ulong))
			{
				throw new ArgumentException(SR.Arg_MustBeUInt64);
			}
			ulong num = (ulong)value;
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

		// Token: 0x060025CF RID: 9679 RVA: 0x00073EAB File Offset: 0x000720AB
		public int CompareTo(ulong value)
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

		// Token: 0x060025D0 RID: 9680 RVA: 0x00073EBC File Offset: 0x000720BC
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is ulong && this == (ulong)obj;
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x0004145E File Offset: 0x0003F65E
		[NonVersionable]
		public bool Equals(ulong obj)
		{
			return this == obj;
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00073ED2 File Offset: 0x000720D2
		public override int GetHashCode()
		{
			return (int)this ^ (int)(this >> 32);
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00073EDE File Offset: 0x000720DE
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.UInt64ToDecStr(this);
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x00073EDE File Offset: 0x000720DE
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.UInt64ToDecStr(this);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00073EE7 File Offset: 0x000720E7
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatUInt64(this, format, null);
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00073EF2 File Offset: 0x000720F2
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatUInt64(this, format, provider);
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00073EFD File Offset: 0x000720FD
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt64<char>(this, format, provider, destination, out charsWritten);
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00073F0B File Offset: 0x0007210B
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt64<byte>(this, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00073F19 File Offset: 0x00072119
		[NullableContext(1)]
		public static ulong Parse(string s)
		{
			return ulong.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00073F23 File Offset: 0x00072123
		[NullableContext(1)]
		public static ulong Parse(string s, NumberStyles style)
		{
			return ulong.Parse(s, style, null);
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00073F2D File Offset: 0x0007212D
		[NullableContext(1)]
		public static ulong Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return ulong.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00073F37 File Offset: 0x00072137
		[NullableContext(1)]
		public static ulong Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return ulong.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00073F50 File Offset: 0x00072150
		public static ulong Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, ulong>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00073F65 File Offset: 0x00072165
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out ulong result)
		{
			return ulong.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00073F70 File Offset: 0x00072170
		public static bool TryParse(ReadOnlySpan<char> s, out ulong result)
		{
			return ulong.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x00073F7B File Offset: 0x0007217B
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out ulong result)
		{
			return ulong.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x00073F86 File Offset: 0x00072186
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out ulong result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0UL;
				return false;
			}
			return Number.TryParseBinaryInteger<char, ulong>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00073FAD File Offset: 0x000721AD
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out ulong result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, ulong>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00029ADC File Offset: 0x00027CDC
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt64;
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00073FC6 File Offset: 0x000721C6
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00073FCF File Offset: 0x000721CF
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00073FD8 File Offset: 0x000721D8
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00073FE1 File Offset: 0x000721E1
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00073FEA File Offset: 0x000721EA
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00073FF3 File Offset: 0x000721F3
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00073FFC File Offset: 0x000721FC
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00074005 File Offset: 0x00072205
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x0007400E File Offset: 0x0007220E
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000415AC File Offset: 0x0003F7AC
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00074017 File Offset: 0x00072217
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00074020 File Offset: 0x00072220
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00074029 File Offset: 0x00072229
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00074032 File Offset: 0x00072232
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "UInt64", "DateTime"));
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0007404D File Offset: 0x0007224D
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0002EA29 File Offset: 0x0002CC29
		ulong IAdditionOperators<ulong, ulong, ulong>.op_Addition(ulong left, ulong right)
		{
			return left + right;
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00073023 File Offset: 0x00071223
		ulong IAdditionOperators<ulong, ulong, ulong>.op_CheckedAddition(ulong left, ulong right)
		{
			return checked(left + right);
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x000304C1 File Offset: 0x0002E6C1
		ulong IAdditiveIdentity<ulong, ulong>.AdditiveIdentity
		{
			get
			{
				return 0UL;
			}
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x0007405D File Offset: 0x0007225D
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<ulong, ulong> DivRem(ulong left, ulong right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00041608 File Offset: 0x0003F808
		[Intrinsic]
		public static ulong LeadingZeroCount(ulong value)
		{
			return (ulong)((long)BitOperations.LeadingZeroCount(value));
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00041611 File Offset: 0x0003F811
		[Intrinsic]
		public static ulong PopCount(ulong value)
		{
			return (ulong)((long)BitOperations.PopCount(value));
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x0004161A File Offset: 0x0003F81A
		[Intrinsic]
		public static ulong RotateLeft(ulong value, int rotateAmount)
		{
			return BitOperations.RotateLeft(value, rotateAmount);
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00041623 File Offset: 0x0003F823
		[Intrinsic]
		public static ulong RotateRight(ulong value, int rotateAmount)
		{
			return BitOperations.RotateRight(value, rotateAmount);
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00074066 File Offset: 0x00072266
		[Intrinsic]
		public static ulong TrailingZeroCount(ulong value)
		{
			return (ulong)((long)BitOperations.TrailingZeroCount(value));
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00074070 File Offset: 0x00072270
		unsafe bool IBinaryInteger<ulong>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out ulong value)
		{
			ulong num = 0UL;
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[0])))
				{
					value = num;
					return false;
				}
				if (source.Length > 8)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 8).ContainsAnyExcept(0))
					{
						value = num;
						return false;
					}
				}
				ref byte source2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 8)
				{
					source2 = Unsafe.Add<byte>(ref source2, source.Length - 8);
					num = Unsafe.ReadUnaligned<ulong>(ref source2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					num = BinaryPrimitives.ReverseEndianness(num);
				}
				else
				{
					for (int i = 0; i < source.Length; i++)
					{
						num <<= 8;
						num |= (ulong)(*Unsafe.Add<byte>(ref source2, i));
					}
				}
			}
			value = num;
			return true;
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x0007412C File Offset: 0x0007232C
		unsafe bool IBinaryInteger<ulong>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out ulong value)
		{
			ulong num = 0UL;
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[source.Length - 1])))
				{
					value = num;
					return false;
				}
				if (source.Length > 8)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(8, ptr.Length - 8).ContainsAnyExcept(0))
					{
						value = num;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 8)
				{
					num = Unsafe.ReadUnaligned<ulong>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_A4;
					}
				}
				for (int i = 0; i < source.Length; i++)
				{
					ulong num2 = (ulong)(*Unsafe.Add<byte>(ref reference, i));
					num2 <<= i * 8;
					num |= num2;
				}
			}
			IL_A4:
			value = num;
			return true;
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000741E1 File Offset: 0x000723E1
		int IBinaryInteger<ulong>.GetShortestBitLength()
		{
			return 64 - BitOperations.LeadingZeroCount(this);
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int IBinaryInteger<ulong>.GetByteCount()
		{
			return 8;
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x000741F0 File Offset: 0x000723F0
		bool IBinaryInteger<ulong>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				ulong value = BinaryPrimitives.ReverseEndianness(this);
				Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x0007422C File Offset: 0x0007242C
		bool IBinaryInteger<ulong>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				ulong value = this;
				Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x0004190E File Offset: 0x0003FB0E
		ulong IBinaryNumber<ulong>.AllBitsSet
		{
			get
			{
				return 18446744073709551615UL;
			}
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00074262 File Offset: 0x00072462
		public static bool IsPow2(ulong value)
		{
			return BitOperations.IsPow2(value);
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0007426A File Offset: 0x0007246A
		[Intrinsic]
		public static ulong Log2(ulong value)
		{
			return (ulong)((long)BitOperations.Log2(value));
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00040597 File Offset: 0x0003E797
		ulong IBitwiseOperators<ulong, ulong, ulong>.op_BitwiseAnd(ulong left, ulong right)
		{
			return left & right;
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x0004059C File Offset: 0x0003E79C
		ulong IBitwiseOperators<ulong, ulong, ulong>.op_BitwiseOr(ulong left, ulong right)
		{
			return left | right;
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x000405A1 File Offset: 0x0003E7A1
		ulong IBitwiseOperators<ulong, ulong, ulong>.op_ExclusiveOr(ulong left, ulong right)
		{
			return left ^ right;
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x000405A6 File Offset: 0x0003E7A6
		ulong IBitwiseOperators<ulong, ulong, ulong>.op_OnesComplement(ulong value)
		{
			return ~value;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00073232 File Offset: 0x00071432
		bool IComparisonOperators<ulong, ulong, bool>.op_LessThan(ulong left, ulong right)
		{
			return left < right;
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x0002E7F1 File Offset: 0x0002C9F1
		bool IComparisonOperators<ulong, ulong, bool>.op_LessThanOrEqual(ulong left, ulong right)
		{
			return left <= right;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000413DF File Offset: 0x0003F5DF
		bool IComparisonOperators<ulong, ulong, bool>.op_GreaterThan(ulong left, ulong right)
		{
			return left > right;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0002E7FA File Offset: 0x0002C9FA
		bool IComparisonOperators<ulong, ulong, bool>.op_GreaterThanOrEqual(ulong left, ulong right)
		{
			return left >= right;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0004192D File Offset: 0x0003FB2D
		ulong IDecrementOperators<ulong>.op_Decrement(ulong value)
		{
			return value -= 1UL;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00074273 File Offset: 0x00072473
		ulong IDecrementOperators<ulong>.op_CheckedDecrement(ulong value)
		{
			return checked(value -= 1UL);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00073240 File Offset: 0x00071440
		ulong IDivisionOperators<ulong, ulong, ulong>.op_Division(ulong left, ulong right)
		{
			return left / right;
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<ulong, ulong, bool>.op_Equality(ulong left, ulong right)
		{
			return left == right;
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<ulong, ulong, bool>.op_Inequality(ulong left, ulong right)
		{
			return left != right;
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x0004193F File Offset: 0x0003FB3F
		ulong IIncrementOperators<ulong>.op_Increment(ulong value)
		{
			return value += 1UL;
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x0007427C File Offset: 0x0007247C
		ulong IIncrementOperators<ulong>.op_CheckedIncrement(ulong value)
		{
			return checked(value += 1UL);
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000304C1 File Offset: 0x0002E6C1
		ulong IMinMaxValue<ulong>.MinValue
		{
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x0004190E File Offset: 0x0003FB0E
		ulong IMinMaxValue<ulong>.MaxValue
		{
			get
			{
				return 18446744073709551615UL;
			}
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x0007324D File Offset: 0x0007144D
		ulong IModulusOperators<ulong, ulong, ulong>.op_Modulus(ulong left, ulong right)
		{
			return left % right;
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x00041967 File Offset: 0x0003FB67
		ulong IMultiplicativeIdentity<ulong, ulong>.MultiplicativeIdentity
		{
			get
			{
				return 1UL;
			}
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0002EE5D File Offset: 0x0002D05D
		ulong IMultiplyOperators<ulong, ulong, ulong>.op_Multiply(ulong left, ulong right)
		{
			return left * right;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00073252 File Offset: 0x00071452
		ulong IMultiplyOperators<ulong, ulong, ulong>.op_CheckedMultiply(ulong left, ulong right)
		{
			return checked(left * right);
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x00074285 File Offset: 0x00072485
		public static ulong Clamp(ulong value, ulong min, ulong max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00007B62 File Offset: 0x00005D62
		ulong INumber<ulong>.CopySign(ulong value, ulong sign)
		{
			return value;
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x0007428F File Offset: 0x0007248F
		public static ulong Max(ulong x, ulong y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00074298 File Offset: 0x00072498
		ulong INumber<ulong>.MaxNumber(ulong x, ulong y)
		{
			return ulong.Max(x, y);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000742A1 File Offset: 0x000724A1
		public static ulong Min(ulong x, ulong y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x000742AA File Offset: 0x000724AA
		ulong INumber<ulong>.MinNumber(ulong x, ulong y)
		{
			return ulong.Min(x, y);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x000231A1 File Offset: 0x000213A1
		public static int Sign(ulong value)
		{
			return (value > 0UL) ? 1 : 0;
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x00041967 File Offset: 0x0003FB67
		ulong INumberBase<ulong>.One
		{
			get
			{
				return 1UL;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<ulong>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x000304C1 File Offset: 0x0002E6C1
		ulong INumberBase<ulong>.Zero
		{
			get
			{
				return 0UL;
			}
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x00007B62 File Offset: 0x00005D62
		ulong INumberBase<ulong>.Abs(ulong value)
		{
			return value;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000742B4 File Offset: 0x000724B4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			ulong result;
			if (typeof(TOther) == typeof(ulong))
			{
				result = (ulong)((object)value);
			}
			else if (!ulong.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<ulong>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x0007430C File Offset: 0x0007250C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			ulong result;
			if (typeof(TOther) == typeof(ulong))
			{
				result = (ulong)((object)value);
			}
			else if (!ulong.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<ulong>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x00074364 File Offset: 0x00072564
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			ulong result;
			if (typeof(TOther) == typeof(ulong))
			{
				result = (ulong)((object)value);
			}
			else if (!ulong.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<ulong>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ulong>.IsCanonical(ulong value)
		{
			return true;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ulong>.IsComplexNumber(ulong value)
		{
			return false;
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00041ADE File Offset: 0x0003FCDE
		public static bool IsEvenInteger(ulong value)
		{
			return (value & 1UL) == 0UL;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ulong>.IsFinite(ulong value)
		{
			return true;
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ulong>.IsImaginaryNumber(ulong value)
		{
			return false;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ulong>.IsInfinity(ulong value)
		{
			return false;
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ulong>.IsInteger(ulong value)
		{
			return true;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ulong>.IsNaN(ulong value)
		{
			return false;
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ulong>.IsNegative(ulong value)
		{
			return false;
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ulong>.IsNegativeInfinity(ulong value)
		{
			return false;
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000231A1 File Offset: 0x000213A1
		bool INumberBase<ulong>.IsNormal(ulong value)
		{
			return value > 0UL;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00041AEF File Offset: 0x0003FCEF
		public static bool IsOddInteger(ulong value)
		{
			return (value & 1UL) > 0UL;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ulong>.IsPositive(ulong value)
		{
			return true;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ulong>.IsPositiveInfinity(ulong value)
		{
			return false;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<ulong>.IsRealNumber(ulong value)
		{
			return true;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<ulong>.IsSubnormal(ulong value)
		{
			return false;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00041B03 File Offset: 0x0003FD03
		bool INumberBase<ulong>.IsZero(ulong value)
		{
			return value == 0UL;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00074298 File Offset: 0x00072498
		ulong INumberBase<ulong>.MaxMagnitude(ulong x, ulong y)
		{
			return ulong.Max(x, y);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00074298 File Offset: 0x00072498
		ulong INumberBase<ulong>.MaxMagnitudeNumber(ulong x, ulong y)
		{
			return ulong.Max(x, y);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000742AA File Offset: 0x000724AA
		ulong INumberBase<ulong>.MinMagnitude(ulong x, ulong y)
		{
			return ulong.Min(x, y);
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000742AA File Offset: 0x000724AA
		ulong INumberBase<ulong>.MinMagnitudeNumber(ulong x, ulong y)
		{
			return ulong.Min(x, y);
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		ulong INumberBase<ulong>.MultiplyAddEstimate(ulong left, ulong right, ulong addend)
		{
			return left * right + addend;
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000743BA File Offset: 0x000725BA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ulong>.TryConvertFromChecked<TOther>(TOther value, out ulong result) where TOther : INumberBase<TOther>
		{
			return ulong.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000743C4 File Offset: 0x000725C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out ulong result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (ulong)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (ulong)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal value2 = (decimal)((object)value);
				result = (ulong)value2;
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num = (ushort)((object)value);
				result = (ulong)num;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num2 = (uint)((object)value);
				result = (ulong)num2;
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
				result = (ulong)uintPtr;
				return true;
			}
			result = 0UL;
			return false;
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0007451F File Offset: 0x0007271F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ulong>.TryConvertFromSaturating<TOther>(TOther value, out ulong result) where TOther : INumberBase<TOther>
		{
			return ulong.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00074528 File Offset: 0x00072728
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out ulong result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (ulong)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (ulong)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 18446744073709551615m) ? 18446744073709551615UL : ((num <= 0m) ? 0UL : ((ulong)num)));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (ulong)num2;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((object)value);
				result = (ulong)num3;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)((object)value);
				result = ((@uint >= 18446744073709551615UL) ? 18446744073709551615UL : ((ulong)@uint));
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = (ulong)uintPtr;
				return true;
			}
			result = 0UL;
			return false;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000746BB File Offset: 0x000728BB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ulong>.TryConvertFromTruncating<TOther>(TOther value, out ulong result) where TOther : INumberBase<TOther>
		{
			return ulong.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000746C4 File Offset: 0x000728C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out ulong result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (ulong)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (ulong)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 18446744073709551615m) ? 18446744073709551615UL : ((num <= 0m) ? 0UL : ((ulong)num)));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (ulong)num2;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((object)value);
				result = (ulong)num3;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value2 = (UInt128)((object)value);
				result = (ulong)value2;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = (ulong)uintPtr;
				return true;
			}
			result = 0UL;
			return false;
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x00074844 File Offset: 0x00072A44
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ulong>.TryConvertToChecked<TOther>(ulong value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			checked
			{
				if (typeof(TOther) == typeof(short))
				{
					short num2 = (short)value;
					result = (TOther)((object)num2);
					return true;
				}
				if (typeof(TOther) == typeof(int))
				{
					int num3 = (int)value;
					result = (TOther)((object)num3);
					return true;
				}
				if (typeof(TOther) == typeof(long))
				{
					long num4 = (long)value;
					result = (TOther)((object)num4);
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
					IntPtr intPtr = (IntPtr)value;
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
					float num5 = value;
					result = (TOther)((object)num5);
					return true;
				}
				result = default(TOther);
				return false;
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x00074A28 File Offset: 0x00072C28
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ulong>.TryConvertToSaturating<TOther>(ulong value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = value;
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
				short num2 = (value >= 32767UL) ? short.MaxValue : ((short)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (value >= 2147483647UL) ? int.MaxValue : ((int)value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)((value >= 9223372036854775807UL) ? 9223372036854775807UL : value);
				result = (TOther)((object)num4);
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
				IntPtr intPtr = (value >= (ulong)((long)IntPtr.MaxValue)) ? IntPtr.MaxValue : ((IntPtr)value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (value >= 127UL) ? sbyte.MaxValue : ((sbyte)value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = value;
				result = (TOther)((object)num5);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x00074C5C File Offset: 0x00072E5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<ulong>.TryConvertToTruncating<TOther>(ulong value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = value;
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
				int num3 = (int)value;
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				result = (TOther)((object)((long)value));
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
				IntPtr intPtr = (IntPtr)value;
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
				float num4 = value;
				result = (TOther)((object)num4);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00074E3D File Offset: 0x0007303D
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out ulong result)
		{
			return ulong.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00042743 File Offset: 0x00040943
		ulong IShiftOperators<ulong, int, ulong>.op_LeftShift(ulong value, int shiftAmount)
		{
			return value << shiftAmount;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00042753 File Offset: 0x00040953
		ulong IShiftOperators<ulong, int, ulong>.op_RightShift(ulong value, int shiftAmount)
		{
			return value >> shiftAmount;
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00042753 File Offset: 0x00040953
		ulong IShiftOperators<ulong, int, ulong>.op_UnsignedRightShift(ulong value, int shiftAmount)
		{
			return value >> shiftAmount;
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00074E48 File Offset: 0x00073048
		public static ulong Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return ulong.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00074E52 File Offset: 0x00073052
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out ulong result)
		{
			return ulong.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x0002FA55 File Offset: 0x0002DC55
		ulong ISubtractionOperators<ulong, ulong, ulong>.op_Subtraction(ulong left, ulong right)
		{
			return left - right;
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x00073E05 File Offset: 0x00072005
		ulong ISubtractionOperators<ulong, ulong, ulong>.op_CheckedSubtraction(ulong left, ulong right)
		{
			return checked(left - right);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x00074E5D File Offset: 0x0007305D
		ulong IUnaryNegationOperators<ulong, ulong>.op_UnaryNegation(ulong value)
		{
			return 0UL - value;
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00074E63 File Offset: 0x00073063
		ulong IUnaryNegationOperators<ulong, ulong>.op_CheckedUnaryNegation(ulong value)
		{
			return checked(0UL - value);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00007B62 File Offset: 0x00005D62
		ulong IUnaryPlusOperators<ulong, ulong>.op_UnaryPlus(ulong value)
		{
			return value;
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00074E69 File Offset: 0x00073069
		public static ulong Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, ulong>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00074E7E File Offset: 0x0007307E
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out ulong result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, ulong>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00074E97 File Offset: 0x00073097
		public static ulong Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return ulong.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00074EA1 File Offset: 0x000730A1
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out ulong result)
		{
			return ulong.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IBinaryIntegerParseAndFormatInfo<ulong>.IsSigned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x00074EAC File Offset: 0x000730AC
		int IBinaryIntegerParseAndFormatInfo<ulong>.MaxDigitCount
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x00027484 File Offset: 0x00025684
		int IBinaryIntegerParseAndFormatInfo<ulong>.MaxHexDigitCount
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x00074EB0 File Offset: 0x000730B0
		ulong IBinaryIntegerParseAndFormatInfo<ulong>.MaxValueDiv10
		{
			get
			{
				return 1844674407370955161UL;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x00074EBB File Offset: 0x000730BB
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<ulong>.OverflowMessage
		{
			get
			{
				return SR.Overflow_UInt64;
			}
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000413DF File Offset: 0x0003F5DF
		bool IBinaryIntegerParseAndFormatInfo<ulong>.IsGreaterThanAsUnsigned(ulong left, ulong right)
		{
			return left > right;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000427CF File Offset: 0x000409CF
		ulong IBinaryIntegerParseAndFormatInfo<ulong>.MultiplyBy10(ulong value)
		{
			return value * 10UL;
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000427D6 File Offset: 0x000409D6
		ulong IBinaryIntegerParseAndFormatInfo<ulong>.MultiplyBy16(ulong value)
		{
			return value * 16UL;
		}

		// Token: 0x040006E8 RID: 1768
		private readonly ulong m_value;

		// Token: 0x040006E9 RID: 1769
		public const ulong MaxValue = 18446744073709551615UL;

		// Token: 0x040006EA RID: 1770
		public const ulong MinValue = 0UL;
	}
}
