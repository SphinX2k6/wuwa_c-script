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
	// Token: 0x0200014B RID: 331
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Int16 : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<short>, IEquatable<short>, IBinaryInteger<short>, IBinaryNumber<short>, IBitwiseOperators<short, short, short>, INumber<short>, IComparisonOperators<short, short, bool>, IEqualityOperators<short, short, bool>, IModulusOperators<short, short, short>, INumberBase<short>, IAdditionOperators<short, short, short>, IAdditiveIdentity<short, short>, IDecrementOperators<short>, IDivisionOperators<short, short, short>, IIncrementOperators<short>, IMultiplicativeIdentity<short, short>, IMultiplyOperators<short, short, short>, ISpanParsable<short>, IParsable<short>, ISubtractionOperators<short, short, short>, IUnaryPlusOperators<short, short>, IUnaryNegationOperators<short, short>, IUtf8SpanFormattable, IUtf8SpanParsable<short>, IShiftOperators<short, int, short>, IMinMaxValue<short>, ISignedNumber<short>, IBinaryIntegerParseAndFormatInfo<short>
	{
		// Token: 0x060013F4 RID: 5108 RVA: 0x0003ED00 File Offset: 0x0003CF00
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is short)
			{
				return (int)(this - (short)value);
			}
			throw new ArgumentException(SR.Arg_MustBeInt16);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0003ED23 File Offset: 0x0003CF23
		public int CompareTo(short value)
		{
			return (int)(this - value);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0003ED29 File Offset: 0x0003CF29
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is short && this == (short)obj;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0003ED3F File Offset: 0x0003CF3F
		[NonVersionable]
		public bool Equals(short obj)
		{
			return this == obj;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0003ED46 File Offset: 0x0003CF46
		public override int GetHashCode()
		{
			return (int)this;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0003ED4A File Offset: 0x0003CF4A
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.Int32ToDecStr((int)this);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0003ED53 File Offset: 0x0003CF53
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, 0, null, provider);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0003ED5F File Offset: 0x0003CF5F
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0003ED69 File Offset: 0x0003CF69
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, 65535, format, provider);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0003ED79 File Offset: 0x0003CF79
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt32<char>((int)this, 65535, format, provider, destination, out charsWritten);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt32<byte>((int)this, 65535, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0003ED9F File Offset: 0x0003CF9F
		[NullableContext(1)]
		public static short Parse(string s)
		{
			return short.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0003EDA9 File Offset: 0x0003CFA9
		[NullableContext(1)]
		public static short Parse(string s, NumberStyles style)
		{
			return short.Parse(s, style, null);
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0003EDB3 File Offset: 0x0003CFB3
		[NullableContext(1)]
		public static short Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return short.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0003EDBD File Offset: 0x0003CFBD
		[NullableContext(1)]
		public static short Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return short.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0003EDD6 File Offset: 0x0003CFD6
		public static short Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, short>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0003EDEB File Offset: 0x0003CFEB
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out short result)
		{
			return short.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0003EDF6 File Offset: 0x0003CFF6
		public static bool TryParse(ReadOnlySpan<char> s, out short result)
		{
			return short.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0003EE01 File Offset: 0x0003D001
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out short result)
		{
			return short.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0003EE0C File Offset: 0x0003D00C
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out short result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseBinaryInteger<char, short>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0003EE32 File Offset: 0x0003D032
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out short result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, short>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0003EE4B File Offset: 0x0003D04B
		public TypeCode GetTypeCode()
		{
			return TypeCode.Int16;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0003EE4E File Offset: 0x0003D04E
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0003EE57 File Offset: 0x0003D057
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0003EE60 File Offset: 0x0003D060
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0003EE69 File Offset: 0x0003D069
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0003ED46 File Offset: 0x0003CF46
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0003EE72 File Offset: 0x0003D072
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x0003EE7B File Offset: 0x0003D07B
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0003EE84 File Offset: 0x0003D084
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0003EE8D File Offset: 0x0003D08D
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0003EE96 File Offset: 0x0003D096
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0003EE9F File Offset: 0x0003D09F
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0003EEA8 File Offset: 0x0003D0A8
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0003EEB1 File Offset: 0x0003D0B1
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0003EEBA File Offset: 0x0003D0BA
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Int16", "DateTime"));
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0003EED5 File Offset: 0x0003D0D5
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0003EEE5 File Offset: 0x0003D0E5
		short IAdditionOperators<short, short, short>.op_Addition(short left, short right)
		{
			return left + right;
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0003EEEB File Offset: 0x0003D0EB
		short IAdditionOperators<short, short, short>.op_CheckedAddition(short left, short right)
		{
			return checked(left + right);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00007B65 File Offset: 0x00005D65
		short IAdditiveIdentity<short, short>.AdditiveIdentity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0003EEF1 File Offset: 0x0003D0F1
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<short, short> DivRem(short left, short right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0003EEFA File Offset: 0x0003D0FA
		public static short LeadingZeroCount(short value)
		{
			return (short)(BitOperations.LeadingZeroCount((uint)((ushort)value)) - 16);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0003EF07 File Offset: 0x0003D107
		public static short PopCount(short value)
		{
			return (short)BitOperations.PopCount((uint)((ushort)value));
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0003EF11 File Offset: 0x0003D111
		public static short RotateLeft(short value, int rotateAmount)
		{
			return (short)((int)value << (rotateAmount & 15) | (ushort)value >> (16 - rotateAmount & 15));
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0003EF2B File Offset: 0x0003D12B
		public static short RotateRight(short value, int rotateAmount)
		{
			return (short)((ushort)value >> (rotateAmount & 15) | (int)value << (16 - rotateAmount & 15));
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0003EF45 File Offset: 0x0003D145
		public static short TrailingZeroCount(short value)
		{
			return (short)((byte)(BitOperations.TrailingZeroCount((int)value << 16) - 16));
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0003EF54 File Offset: 0x0003D154
		unsafe bool IBinaryInteger<short>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out short value)
		{
			short num = 0;
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[0]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 2)
				{
					value = num;
					return false;
				}
				if (source.Length > 2)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 2).ContainsAnyExcept((byte)b))
					{
						value = num;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[source.Length - 2])))
					{
						value = num;
						return false;
					}
				}
				ref byte ptr2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 2)
				{
					ptr2 = Unsafe.Add<byte>(ref ptr2, source.Length - 2);
					num = Unsafe.ReadUnaligned<short>(ref ptr2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					num = BinaryPrimitives.ReverseEndianness(num);
				}
				else if (isUnsigned)
				{
					num = (short)ptr2;
				}
				else
				{
					num = (short)((sbyte)ptr2);
				}
			}
			value = num;
			return true;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0003F034 File Offset: 0x0003D234
		unsafe bool IBinaryInteger<short>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out short value)
		{
			short num = 0;
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[source.Length - 1]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 2)
				{
					value = num;
					return false;
				}
				if (source.Length > 2)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(2, ptr.Length - 2).ContainsAnyExcept((byte)b))
					{
						value = num;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[1])))
					{
						value = num;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 2)
				{
					num = Unsafe.ReadUnaligned<short>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_B4;
					}
				}
				if (isUnsigned)
				{
					num = (short)reference;
				}
				else
				{
					num = (short)((sbyte)reference);
				}
			}
			IL_B4:
			value = num;
			return true;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0003F0FC File Offset: 0x0003D2FC
		int IBinaryInteger<short>.GetShortestBitLength()
		{
			short num = this;
			if (num >= 0)
			{
				return (int)(16 - short.LeadingZeroCount(num));
			}
			return (int)(17 - short.LeadingZeroCount(~num));
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int IBinaryInteger<short>.GetByteCount()
		{
			return 2;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0003F128 File Offset: 0x0003D328
		bool IBinaryInteger<short>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				short value = BinaryPrimitives.ReverseEndianness(this);
				Unsafe.WriteUnaligned<short>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0003F164 File Offset: 0x0003D364
		bool IBinaryInteger<short>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				short value = this;
				Unsafe.WriteUnaligned<short>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0003F19A File Offset: 0x0003D39A
		short IBinaryNumber<short>.AllBitsSet
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0003F19D File Offset: 0x0003D39D
		public static bool IsPow2(short value)
		{
			return BitOperations.IsPow2((int)value);
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0003F1A5 File Offset: 0x0003D3A5
		public static short Log2(short value)
		{
			if (value < 0)
			{
				ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			return (short)BitOperations.Log2((uint)((ushort)value));
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
		short IBitwiseOperators<short, short, short>.op_BitwiseAnd(short left, short right)
		{
			return left & right;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0003F1BE File Offset: 0x0003D3BE
		short IBitwiseOperators<short, short, short>.op_BitwiseOr(short left, short right)
		{
			return left | right;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0003F1C4 File Offset: 0x0003D3C4
		short IBitwiseOperators<short, short, short>.op_ExclusiveOr(short left, short right)
		{
			return left ^ right;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0003F1CA File Offset: 0x0003D3CA
		short IBitwiseOperators<short, short, short>.op_OnesComplement(short value)
		{
			return ~value;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00020126 File Offset: 0x0001E326
		bool IComparisonOperators<short, short, bool>.op_LessThan(short left, short right)
		{
			return left < right;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0002012C File Offset: 0x0001E32C
		bool IComparisonOperators<short, short, bool>.op_LessThanOrEqual(short left, short right)
		{
			return left <= right;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00020135 File Offset: 0x0001E335
		bool IComparisonOperators<short, short, bool>.op_GreaterThan(short left, short right)
		{
			return left > right;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0002013B File Offset: 0x0001E33B
		bool IComparisonOperators<short, short, bool>.op_GreaterThanOrEqual(short left, short right)
		{
			return left >= right;
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0003F1CF File Offset: 0x0003D3CF
		short IDecrementOperators<short>.op_Decrement(short value)
		{
			return value -= 1;
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0003F1D8 File Offset: 0x0003D3D8
		short IDecrementOperators<short>.op_CheckedDecrement(short value)
		{
			return checked(value -= 1);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0003F1E1 File Offset: 0x0003D3E1
		short IDivisionOperators<short, short, short>.op_Division(short left, short right)
		{
			return left / right;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<short, short, bool>.op_Equality(short left, short right)
		{
			return left == right;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<short, short, bool>.op_Inequality(short left, short right)
		{
			return left != right;
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0003F1E7 File Offset: 0x0003D3E7
		short IIncrementOperators<short>.op_Increment(short value)
		{
			return value += 1;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0003F1F0 File Offset: 0x0003D3F0
		short IIncrementOperators<short>.op_CheckedIncrement(short value)
		{
			return checked(value += 1);
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0003F1F9 File Offset: 0x0003D3F9
		short IMinMaxValue<short>.MinValue
		{
			get
			{
				return -32768;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0003F200 File Offset: 0x0003D400
		short IMinMaxValue<short>.MaxValue
		{
			get
			{
				return 32767;
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0003F207 File Offset: 0x0003D407
		short IModulusOperators<short, short, short>.op_Modulus(short left, short right)
		{
			return left % right;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x000070DD File Offset: 0x000052DD
		short IMultiplicativeIdentity<short, short>.MultiplicativeIdentity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0003F20D File Offset: 0x0003D40D
		short IMultiplyOperators<short, short, short>.op_Multiply(short left, short right)
		{
			return left * right;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0003F213 File Offset: 0x0003D413
		short IMultiplyOperators<short, short, short>.op_CheckedMultiply(short left, short right)
		{
			return checked(left * right);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0003F219 File Offset: 0x0003D419
		public static short Clamp(short value, short min, short max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0003F224 File Offset: 0x0003D424
		public static short CopySign(short value, short sign)
		{
			short num = value;
			if (num < 0)
			{
				num = -num;
			}
			if (sign >= 0)
			{
				if (num < 0)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
				return num;
			}
			return -num;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0003F24D File Offset: 0x0003D44D
		public static short Max(short x, short y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0003F256 File Offset: 0x0003D456
		short INumber<short>.MaxNumber(short x, short y)
		{
			return short.Max(x, y);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0003F25F File Offset: 0x0003D45F
		public static short Min(short x, short y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0003F268 File Offset: 0x0003D468
		short INumber<short>.MinNumber(short x, short y)
		{
			return short.Min(x, y);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0003F271 File Offset: 0x0003D471
		public static int Sign(short value)
		{
			return Math.Sign(value);
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x000070DD File Offset: 0x000052DD
		short INumberBase<short>.One
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<short>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x00007B65 File Offset: 0x00005D65
		short INumberBase<short>.Zero
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0003F279 File Offset: 0x0003D479
		public static short Abs(short value)
		{
			return Math.Abs(value);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0003F284 File Offset: 0x0003D484
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			short result;
			if (typeof(TOther) == typeof(short))
			{
				result = (short)((object)value);
			}
			else if (!short.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<short>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0003F2DC File Offset: 0x0003D4DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			short result;
			if (typeof(TOther) == typeof(short))
			{
				result = (short)((object)value);
			}
			else if (!short.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<short>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0003F334 File Offset: 0x0003D534
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			short result;
			if (typeof(TOther) == typeof(short))
			{
				result = (short)((object)value);
			}
			else if (!short.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<short>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<short>.IsCanonical(short value)
		{
			return true;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<short>.IsComplexNumber(short value)
		{
			return false;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x000202BE File Offset: 0x0001E4BE
		public static bool IsEvenInteger(short value)
		{
			return (value & 1) == 0;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<short>.IsFinite(short value)
		{
			return true;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<short>.IsImaginaryNumber(short value)
		{
			return false;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<short>.IsInfinity(short value)
		{
			return false;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<short>.IsInteger(short value)
		{
			return true;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<short>.IsNaN(short value)
		{
			return false;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0003F38A File Offset: 0x0003D58A
		public static bool IsNegative(short value)
		{
			return value < 0;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<short>.IsNegativeInfinity(short value)
		{
			return false;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000201AE File Offset: 0x0001E3AE
		bool INumberBase<short>.IsNormal(short value)
		{
			return value != 0;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x000202C6 File Offset: 0x0001E4C6
		public static bool IsOddInteger(short value)
		{
			return (value & 1) != 0;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00004FFE File Offset: 0x000031FE
		public static bool IsPositive(short value)
		{
			return value >= 0;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<short>.IsPositiveInfinity(short value)
		{
			return false;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<short>.IsRealNumber(short value)
		{
			return true;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<short>.IsSubnormal(short value)
		{
			return false;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000202CE File Offset: 0x0001E4CE
		bool INumberBase<short>.IsZero(short value)
		{
			return value == 0;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0003F390 File Offset: 0x0003D590
		public static short MaxMagnitude(short x, short y)
		{
			short num = x;
			if (num < 0)
			{
				num = -num;
				if (num < 0)
				{
					return x;
				}
			}
			short num2 = y;
			if (num2 < 0)
			{
				num2 = -num2;
				if (num2 < 0)
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
			if (!short.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0003F3D4 File Offset: 0x0003D5D4
		short INumberBase<short>.MaxMagnitudeNumber(short x, short y)
		{
			return short.MaxMagnitude(x, y);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0003F3E0 File Offset: 0x0003D5E0
		public static short MinMagnitude(short x, short y)
		{
			short num = x;
			if (num < 0)
			{
				num = -num;
				if (num < 0)
				{
					return y;
				}
			}
			short num2 = y;
			if (num2 < 0)
			{
				num2 = -num2;
				if (num2 < 0)
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
			if (!short.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0003F424 File Offset: 0x0003D624
		short INumberBase<short>.MinMagnitudeNumber(short x, short y)
		{
			return short.MinMagnitude(x, y);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0003F42D File Offset: 0x0003D62D
		short INumberBase<short>.MultiplyAddEstimate(short left, short right, short addend)
		{
			return left * right + addend;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0003F435 File Offset: 0x0003D635
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<short>.TryConvertFromChecked<TOther>(TOther value, out short result) where TOther : INumberBase<TOther>
		{
			return short.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0003F440 File Offset: 0x0003D640
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out short result) where TOther : INumberBase<TOther>
		{
			checked
			{
				if (typeof(TOther) == typeof(double))
				{
					double num = (double)((object)value);
					result = (short)num;
					return true;
				}
				if (typeof(TOther) == typeof(Half))
				{
					Half value2 = (Half)((object)value);
					result = Half.op_CheckedExplicit(value2);
					return true;
				}
				if (typeof(TOther) == typeof(int))
				{
					int num2 = (int)((object)value);
					result = (short)num2;
					return true;
				}
				if (typeof(TOther) == typeof(long))
				{
					long num3 = (long)((object)value);
					result = (short)num3;
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
					result = (short)intPtr;
					return true;
				}
				if (typeof(TOther) == typeof(sbyte))
				{
					sbyte b = (sbyte)((object)value);
					result = (short)b;
					return true;
				}
				if (typeof(TOther) == typeof(float))
				{
					float num4 = (float)((object)value);
					result = (short)num4;
					return true;
				}
				result = 0;
				return false;
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0003F5C8 File Offset: 0x0003D7C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<short>.TryConvertFromSaturating<TOther>(TOther value, out short result) where TOther : INumberBase<TOther>
		{
			return short.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0003F5D4 File Offset: 0x0003D7D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out short result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 32767.0) ? 32767 : ((num <= -32768.0) ? -32768 : ((short)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half >= BitConverter.UInt16BitsToHalf(30720)) ? 32767 : ((half <= BitConverter.UInt16BitsToHalf(63488)) ? -32768 : ((short)half)));
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num2 = (int)((object)value);
				result = ((num2 >= 32767) ? 32767 : ((num2 <= -32768) ? -32768 : ((short)num2)));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((object)value);
				result = ((num3 >= 32767L) ? 32767 : ((num3 <= -32768L) ? -32768 : ((short)num3)));
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (Int128)((object)value);
				result = ((@int >= 32767) ? 32767 : ((@int <= -32768) ? -32768 : ((short)@int)));
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = ((intPtr >= (IntPtr)32767) ? 32767 : ((intPtr <= (IntPtr)(-32768)) ? -32768 : ((short)intPtr)));
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (short)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)((object)value);
				result = ((num4 >= 32767f) ? 32767 : ((num4 <= -32768f) ? -32768 : ((short)num4)));
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0003F868 File Offset: 0x0003DA68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<short>.TryConvertFromTruncating<TOther>(TOther value, out short result) where TOther : INumberBase<TOther>
		{
			return short.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0003F874 File Offset: 0x0003DA74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out short result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 32767.0) ? 32767 : ((num <= -32768.0) ? -32768 : ((short)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half >= BitConverter.UInt16BitsToHalf(30720)) ? 32767 : ((half <= BitConverter.UInt16BitsToHalf(63488)) ? -32768 : ((short)half)));
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num2 = (int)((object)value);
				result = (short)num2;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((object)value);
				result = (short)num3;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value2 = (Int128)((object)value);
				result = (short)value2;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = (short)intPtr;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (short)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)((object)value);
				result = ((num4 >= 32767f) ? 32767 : ((num4 <= -32768f) ? -32768 : ((short)num4)));
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0003FA74 File Offset: 0x0003DC74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<short>.TryConvertToChecked<TOther>(short value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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

		// Token: 0x0600146B RID: 5227 RVA: 0x0003FC24 File Offset: 0x0003DE24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<short>.TryConvertToSaturating<TOther>(short value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= 255) ? byte.MaxValue : ((value <= 0) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value <= 0) ? '\0' : ((char)value);
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
				ushort num2 = (value <= 0) ? 0 : ((ushort)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((value <= 0) ? 0 : value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((value <= 0) ? 0L : ((long)value));
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (value <= 0) ? UInt128.MinValue : ((UInt128)value);
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((value <= 0) ? ((IntPtr)0) : ((IntPtr)value));
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0003FE18 File Offset: 0x0003E018
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<short>.TryConvertToTruncating<TOther>(short value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
				result = (TOther)((object)((uint)value));
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num3 = (ulong)((long)value);
				result = (TOther)((object)num3);
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
				UIntPtr uintPtr = (UIntPtr)((IntPtr)value);
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0003FFC4 File Offset: 0x0003E1C4
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out short result)
		{
			return short.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0003FFCF File Offset: 0x0003E1CF
		short IShiftOperators<short, int, short>.op_LeftShift(short value, int shiftAmount)
		{
			return (short)(value << shiftAmount);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
		short IShiftOperators<short, int, short>.op_RightShift(short value, int shiftAmount)
		{
			return (short)(value >> shiftAmount);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0003FFE1 File Offset: 0x0003E1E1
		short IShiftOperators<short, int, short>.op_UnsignedRightShift(short value, int shiftAmount)
		{
			return (short)((uint)((ushort)value) >> shiftAmount);
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0003F19A File Offset: 0x0003D39A
		short ISignedNumber<short>.NegativeOne
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0003FFEB File Offset: 0x0003E1EB
		public static short Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return short.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x0003FFF5 File Offset: 0x0003E1F5
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out short result)
		{
			return short.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00040000 File Offset: 0x0003E200
		short ISubtractionOperators<short, short, short>.op_Subtraction(short left, short right)
		{
			return left - right;
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00040006 File Offset: 0x0003E206
		short ISubtractionOperators<short, short, short>.op_CheckedSubtraction(short left, short right)
		{
			return checked(left - right);
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0004000C File Offset: 0x0003E20C
		short IUnaryNegationOperators<short, short>.op_UnaryNegation(short value)
		{
			return -value;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00040011 File Offset: 0x0003E211
		short IUnaryNegationOperators<short, short>.op_CheckedUnaryNegation(short value)
		{
			return checked(0 - value);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00040017 File Offset: 0x0003E217
		short IUnaryPlusOperators<short, short>.op_UnaryPlus(short value)
		{
			return value;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0004001B File Offset: 0x0003E21B
		public static short Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, short>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00040030 File Offset: 0x0003E230
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out short result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, short>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00040049 File Offset: 0x0003E249
		public static short Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return short.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00040053 File Offset: 0x0003E253
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out short result)
		{
			return short.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x000070DD File Offset: 0x000052DD
		bool IBinaryIntegerParseAndFormatInfo<short>.IsSigned
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x00022705 File Offset: 0x00020905
		int IBinaryIntegerParseAndFormatInfo<short>.MaxDigitCount
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x000211FB File Offset: 0x0001F3FB
		int IBinaryIntegerParseAndFormatInfo<short>.MaxHexDigitCount
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0004005E File Offset: 0x0003E25E
		short IBinaryIntegerParseAndFormatInfo<short>.MaxValueDiv10
		{
			get
			{
				return 3276;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x00040065 File Offset: 0x0003E265
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<short>.OverflowMessage
		{
			get
			{
				return SR.Overflow_Int16;
			}
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0004006C File Offset: 0x0003E26C
		bool IBinaryIntegerParseAndFormatInfo<short>.IsGreaterThanAsUnsigned(short left, short right)
		{
			return (ushort)left > (ushort)right;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00040074 File Offset: 0x0003E274
		short IBinaryIntegerParseAndFormatInfo<short>.MultiplyBy10(short value)
		{
			return value * 10;
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0004007B File Offset: 0x0003E27B
		short IBinaryIntegerParseAndFormatInfo<short>.MultiplyBy16(short value)
		{
			return value * 16;
		}

		// Token: 0x040004BC RID: 1212
		private readonly short m_value;

		// Token: 0x040004BD RID: 1213
		public const short MaxValue = 32767;

		// Token: 0x040004BE RID: 1214
		public const short MinValue = -32768;
	}
}
