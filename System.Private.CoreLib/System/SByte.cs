using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020001A1 RID: 417
	[CLSCompliant(false)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct SByte : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<sbyte>, IEquatable<sbyte>, IBinaryInteger<sbyte>, IBinaryNumber<sbyte>, IBitwiseOperators<sbyte, sbyte, sbyte>, INumber<sbyte>, IComparisonOperators<sbyte, sbyte, bool>, IEqualityOperators<sbyte, sbyte, bool>, IModulusOperators<sbyte, sbyte, sbyte>, INumberBase<sbyte>, IAdditionOperators<sbyte, sbyte, sbyte>, IAdditiveIdentity<sbyte, sbyte>, IDecrementOperators<sbyte>, IDivisionOperators<sbyte, sbyte, sbyte>, IIncrementOperators<sbyte>, IMultiplicativeIdentity<sbyte, sbyte>, IMultiplyOperators<sbyte, sbyte, sbyte>, ISpanParsable<sbyte>, IParsable<sbyte>, ISubtractionOperators<sbyte, sbyte, sbyte>, IUnaryPlusOperators<sbyte, sbyte>, IUnaryNegationOperators<sbyte, sbyte>, IUtf8SpanFormattable, IUtf8SpanParsable<sbyte>, IShiftOperators<sbyte, int, sbyte>, IMinMaxValue<sbyte>, ISignedNumber<sbyte>, IBinaryIntegerParseAndFormatInfo<sbyte>
	{
		// Token: 0x06001AC4 RID: 6852 RVA: 0x0005711E File Offset: 0x0005531E
		[NullableContext(2)]
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is sbyte))
			{
				throw new ArgumentException(SR.Arg_MustBeSByte);
			}
			return (int)(this - (sbyte)obj);
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00057141 File Offset: 0x00055341
		public int CompareTo(sbyte value)
		{
			return (int)(this - value);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00057147 File Offset: 0x00055347
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is sbyte && this == (sbyte)obj;
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0005715D File Offset: 0x0005535D
		[NonVersionable]
		public bool Equals(sbyte obj)
		{
			return this == obj;
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00057164 File Offset: 0x00055364
		public override int GetHashCode()
		{
			return (int)this;
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00057168 File Offset: 0x00055368
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.Int32ToDecStr((int)this);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00057171 File Offset: 0x00055371
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0005717B File Offset: 0x0005537B
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, 0, null, provider);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00057187 File Offset: 0x00055387
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatInt32((int)this, 255, format, provider);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00057197 File Offset: 0x00055397
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt32<char>((int)this, 255, format, provider, destination, out charsWritten);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x000571AA File Offset: 0x000553AA
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt32<byte>((int)this, 255, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000571BD File Offset: 0x000553BD
		[NullableContext(1)]
		public static sbyte Parse(string s)
		{
			return sbyte.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x000571C7 File Offset: 0x000553C7
		[NullableContext(1)]
		public static sbyte Parse(string s, NumberStyles style)
		{
			return sbyte.Parse(s, style, null);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000571D1 File Offset: 0x000553D1
		[NullableContext(1)]
		public static sbyte Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return sbyte.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000571DB File Offset: 0x000553DB
		[NullableContext(1)]
		public static sbyte Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return sbyte.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x000571F4 File Offset: 0x000553F4
		public static sbyte Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, sbyte>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00057209 File Offset: 0x00055409
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out sbyte result)
		{
			return sbyte.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00057214 File Offset: 0x00055414
		public static bool TryParse(ReadOnlySpan<char> s, out sbyte result)
		{
			return sbyte.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0005721F File Offset: 0x0005541F
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out sbyte result)
		{
			return sbyte.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0005722A File Offset: 0x0005542A
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out sbyte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseBinaryInteger<char, sbyte>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00057250 File Offset: 0x00055450
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out sbyte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, sbyte>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00022705 File Offset: 0x00020905
		public TypeCode GetTypeCode()
		{
			return TypeCode.SByte;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00057269 File Offset: 0x00055469
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00057272 File Offset: 0x00055472
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00057164 File Offset: 0x00055364
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0005727B File Offset: 0x0005547B
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00057284 File Offset: 0x00055484
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0005728D File Offset: 0x0005548D
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00057164 File Offset: 0x00055364
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)this;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00057296 File Offset: 0x00055496
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0005729F File Offset: 0x0005549F
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x000572A8 File Offset: 0x000554A8
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000572B1 File Offset: 0x000554B1
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x000572BA File Offset: 0x000554BA
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000572C3 File Offset: 0x000554C3
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x000572CC File Offset: 0x000554CC
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "SByte", "DateTime"));
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000572E7 File Offset: 0x000554E7
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000572F7 File Offset: 0x000554F7
		sbyte IAdditionOperators<sbyte, sbyte, sbyte>.op_Addition(sbyte left, sbyte right)
		{
			return left + right;
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x000572FD File Offset: 0x000554FD
		sbyte IAdditionOperators<sbyte, sbyte, sbyte>.op_CheckedAddition(sbyte left, sbyte right)
		{
			return checked(left + right);
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x00007B65 File Offset: 0x00005D65
		sbyte IAdditiveIdentity<sbyte, sbyte>.AdditiveIdentity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00057303 File Offset: 0x00055503
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<sbyte, sbyte> DivRem(sbyte left, sbyte right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0005730C File Offset: 0x0005550C
		public static sbyte LeadingZeroCount(sbyte value)
		{
			return (sbyte)(BitOperations.LeadingZeroCount((uint)((byte)value)) - 24);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00057319 File Offset: 0x00055519
		public static sbyte PopCount(sbyte value)
		{
			return (sbyte)BitOperations.PopCount((uint)((byte)value));
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00057323 File Offset: 0x00055523
		public static sbyte RotateLeft(sbyte value, int rotateAmount)
		{
			return (sbyte)((int)value << (rotateAmount & 7) | (byte)value >> (8 - rotateAmount & 7));
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0005733A File Offset: 0x0005553A
		public static sbyte RotateRight(sbyte value, int rotateAmount)
		{
			return (sbyte)((byte)value >> (rotateAmount & 7) | (int)value << (8 - rotateAmount & 7));
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00057351 File Offset: 0x00055551
		public static sbyte TrailingZeroCount(sbyte value)
		{
			return (sbyte)(BitOperations.TrailingZeroCount((int)value << 24) - 24);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00057360 File Offset: 0x00055560
		unsafe bool IBinaryInteger<sbyte>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out sbyte value)
		{
			sbyte b = 0;
			if (source.Length != 0)
			{
				sbyte b2 = (sbyte)(*source[0]);
				b2 = (sbyte)(b2 >> 31);
				isUnsigned |= (b2 == 0);
				if (isUnsigned && sbyte.IsNegative(b2))
				{
					value = b;
					return false;
				}
				if (source.Length > 1)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 1).ContainsAnyExcept((byte)b2))
					{
						value = b;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[source.Length - 1])))
					{
						value = b;
						return false;
					}
				}
				b = (sbyte)(*Unsafe.Add<byte>(MemoryMarshal.GetReference<byte>(source), source.Length - 1));
			}
			value = b;
			return true;
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00057408 File Offset: 0x00055608
		unsafe bool IBinaryInteger<sbyte>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out sbyte value)
		{
			sbyte b = 0;
			if (source.Length != 0)
			{
				sbyte b2 = (sbyte)(*source[source.Length - 1]);
				b2 = (sbyte)(b2 >> 31);
				isUnsigned |= (b2 == 0);
				if (isUnsigned && sbyte.IsNegative(b2))
				{
					value = b;
					return false;
				}
				if (source.Length > 1)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(1, ptr.Length - 1).ContainsAnyExcept((byte)b2))
					{
						value = b;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[0])))
					{
						value = b;
						return false;
					}
				}
				b = (sbyte)(*MemoryMarshal.GetReference<byte>(source));
			}
			value = b;
			return true;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000574A0 File Offset: 0x000556A0
		int IBinaryInteger<sbyte>.GetShortestBitLength()
		{
			sbyte b = this;
			if (b >= 0)
			{
				return (int)(8 - sbyte.LeadingZeroCount(b));
			}
			return (int)(9 - sbyte.LeadingZeroCount(~b));
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000070DD File Offset: 0x000052DD
		int IBinaryInteger<sbyte>.GetByteCount()
		{
			return 1;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000574C8 File Offset: 0x000556C8
		bool IBinaryInteger<sbyte>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 1)
			{
				sbyte value = this;
				Unsafe.WriteUnaligned<sbyte>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 1;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000574F8 File Offset: 0x000556F8
		bool IBinaryInteger<sbyte>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 1)
			{
				sbyte value = this;
				Unsafe.WriteUnaligned<sbyte>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 1;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x0003F19A File Offset: 0x0003D39A
		sbyte IBinaryNumber<sbyte>.AllBitsSet
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0003F19D File Offset: 0x0003D39D
		public static bool IsPow2(sbyte value)
		{
			return BitOperations.IsPow2((int)value);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00057527 File Offset: 0x00055727
		public static sbyte Log2(sbyte value)
		{
			if (value < 0)
			{
				ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			return (sbyte)BitOperations.Log2((uint)((byte)value));
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0005753A File Offset: 0x0005573A
		sbyte IBitwiseOperators<sbyte, sbyte, sbyte>.op_BitwiseAnd(sbyte left, sbyte right)
		{
			return left & right;
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00057540 File Offset: 0x00055740
		sbyte IBitwiseOperators<sbyte, sbyte, sbyte>.op_BitwiseOr(sbyte left, sbyte right)
		{
			return left | right;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00057546 File Offset: 0x00055746
		sbyte IBitwiseOperators<sbyte, sbyte, sbyte>.op_ExclusiveOr(sbyte left, sbyte right)
		{
			return left ^ right;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0005754C File Offset: 0x0005574C
		sbyte IBitwiseOperators<sbyte, sbyte, sbyte>.op_OnesComplement(sbyte value)
		{
			return ~value;
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00020126 File Offset: 0x0001E326
		bool IComparisonOperators<sbyte, sbyte, bool>.op_LessThan(sbyte left, sbyte right)
		{
			return left < right;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0002012C File Offset: 0x0001E32C
		bool IComparisonOperators<sbyte, sbyte, bool>.op_LessThanOrEqual(sbyte left, sbyte right)
		{
			return left <= right;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00020135 File Offset: 0x0001E335
		bool IComparisonOperators<sbyte, sbyte, bool>.op_GreaterThan(sbyte left, sbyte right)
		{
			return left > right;
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0002013B File Offset: 0x0001E33B
		bool IComparisonOperators<sbyte, sbyte, bool>.op_GreaterThanOrEqual(sbyte left, sbyte right)
		{
			return left >= right;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00057551 File Offset: 0x00055751
		sbyte IDecrementOperators<sbyte>.op_Decrement(sbyte value)
		{
			return value -= 1;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0005755A File Offset: 0x0005575A
		sbyte IDecrementOperators<sbyte>.op_CheckedDecrement(sbyte value)
		{
			return checked(value -= 1);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00057563 File Offset: 0x00055763
		sbyte IDivisionOperators<sbyte, sbyte, sbyte>.op_Division(sbyte left, sbyte right)
		{
			return left / right;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<sbyte, sbyte, bool>.op_Equality(sbyte left, sbyte right)
		{
			return left == right;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<sbyte, sbyte, bool>.op_Inequality(sbyte left, sbyte right)
		{
			return left != right;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00057569 File Offset: 0x00055769
		sbyte IIncrementOperators<sbyte>.op_Increment(sbyte value)
		{
			return value += 1;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00057572 File Offset: 0x00055772
		sbyte IIncrementOperators<sbyte>.op_CheckedIncrement(sbyte value)
		{
			return checked(value += 1);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0005757B File Offset: 0x0005577B
		sbyte IMinMaxValue<sbyte>.MinValue
		{
			get
			{
				return -128;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0005757F File Offset: 0x0005577F
		sbyte IMinMaxValue<sbyte>.MaxValue
		{
			get
			{
				return 127;
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00057583 File Offset: 0x00055783
		sbyte IModulusOperators<sbyte, sbyte, sbyte>.op_Modulus(sbyte left, sbyte right)
		{
			return left % right;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x000070DD File Offset: 0x000052DD
		sbyte IMultiplicativeIdentity<sbyte, sbyte>.MultiplicativeIdentity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00057589 File Offset: 0x00055789
		sbyte IMultiplyOperators<sbyte, sbyte, sbyte>.op_Multiply(sbyte left, sbyte right)
		{
			return left * right;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0005758F File Offset: 0x0005578F
		sbyte IMultiplyOperators<sbyte, sbyte, sbyte>.op_CheckedMultiply(sbyte left, sbyte right)
		{
			return checked(left * right);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00057595 File Offset: 0x00055795
		public static sbyte Clamp(sbyte value, sbyte min, sbyte max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000575A0 File Offset: 0x000557A0
		public static sbyte CopySign(sbyte value, sbyte sign)
		{
			sbyte b = value;
			if (b < 0)
			{
				b = -b;
			}
			if (sign >= 0)
			{
				if (b < 0)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
				return b;
			}
			return -b;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000575C9 File Offset: 0x000557C9
		public static sbyte Max(sbyte x, sbyte y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x000575D2 File Offset: 0x000557D2
		sbyte INumber<sbyte>.MaxNumber(sbyte x, sbyte y)
		{
			return sbyte.Max(x, y);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000575DB File Offset: 0x000557DB
		public static sbyte Min(sbyte x, sbyte y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x000575E4 File Offset: 0x000557E4
		sbyte INumber<sbyte>.MinNumber(sbyte x, sbyte y)
		{
			return sbyte.Min(x, y);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x000575ED File Offset: 0x000557ED
		public static int Sign(sbyte value)
		{
			return Math.Sign(value);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x000070DD File Offset: 0x000052DD
		sbyte INumberBase<sbyte>.One
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<sbyte>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x00007B65 File Offset: 0x00005D65
		sbyte INumberBase<sbyte>.Zero
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000575F5 File Offset: 0x000557F5
		public static sbyte Abs(sbyte value)
		{
			return Math.Abs(value);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00057600 File Offset: 0x00055800
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			sbyte result;
			if (typeof(TOther) == typeof(sbyte))
			{
				result = (sbyte)((object)value);
			}
			else if (!sbyte.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<sbyte>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00057658 File Offset: 0x00055858
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			sbyte result;
			if (typeof(TOther) == typeof(sbyte))
			{
				result = (sbyte)((object)value);
			}
			else if (!sbyte.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<sbyte>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000576B0 File Offset: 0x000558B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			sbyte result;
			if (typeof(TOther) == typeof(sbyte))
			{
				result = (sbyte)((object)value);
			}
			else if (!sbyte.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<sbyte>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<sbyte>.IsCanonical(sbyte value)
		{
			return true;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<sbyte>.IsComplexNumber(sbyte value)
		{
			return false;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000202BE File Offset: 0x0001E4BE
		public static bool IsEvenInteger(sbyte value)
		{
			return (value & 1) == 0;
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<sbyte>.IsFinite(sbyte value)
		{
			return true;
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<sbyte>.IsImaginaryNumber(sbyte value)
		{
			return false;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<sbyte>.IsInfinity(sbyte value)
		{
			return false;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<sbyte>.IsNaN(sbyte value)
		{
			return false;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<sbyte>.IsInteger(sbyte value)
		{
			return true;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0003F38A File Offset: 0x0003D58A
		public static bool IsNegative(sbyte value)
		{
			return value < 0;
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<sbyte>.IsNegativeInfinity(sbyte value)
		{
			return false;
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000201AE File Offset: 0x0001E3AE
		bool INumberBase<sbyte>.IsNormal(sbyte value)
		{
			return value != 0;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000202C6 File Offset: 0x0001E4C6
		public static bool IsOddInteger(sbyte value)
		{
			return (value & 1) != 0;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00004FFE File Offset: 0x000031FE
		public static bool IsPositive(sbyte value)
		{
			return value >= 0;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<sbyte>.IsPositiveInfinity(sbyte value)
		{
			return false;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<sbyte>.IsRealNumber(sbyte value)
		{
			return true;
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<sbyte>.IsSubnormal(sbyte value)
		{
			return false;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x000202CE File Offset: 0x0001E4CE
		bool INumberBase<sbyte>.IsZero(sbyte value)
		{
			return value == 0;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00057708 File Offset: 0x00055908
		public static sbyte MaxMagnitude(sbyte x, sbyte y)
		{
			sbyte b = x;
			if (b < 0)
			{
				b = -b;
				if (b < 0)
				{
					return x;
				}
			}
			sbyte b2 = y;
			if (b2 < 0)
			{
				b2 = -b2;
				if (b2 < 0)
				{
					return y;
				}
			}
			if (b > b2)
			{
				return x;
			}
			if (b != b2)
			{
				return y;
			}
			if (!sbyte.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0005774C File Offset: 0x0005594C
		sbyte INumberBase<sbyte>.MaxMagnitudeNumber(sbyte x, sbyte y)
		{
			return sbyte.MaxMagnitude(x, y);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00057758 File Offset: 0x00055958
		public static sbyte MinMagnitude(sbyte x, sbyte y)
		{
			sbyte b = x;
			if (b < 0)
			{
				b = -b;
				if (b < 0)
				{
					return y;
				}
			}
			sbyte b2 = y;
			if (b2 < 0)
			{
				b2 = -b2;
				if (b2 < 0)
				{
					return x;
				}
			}
			if (b < b2)
			{
				return x;
			}
			if (b != b2)
			{
				return y;
			}
			if (!sbyte.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0005779C File Offset: 0x0005599C
		sbyte INumberBase<sbyte>.MinMagnitudeNumber(sbyte x, sbyte y)
		{
			return sbyte.MinMagnitude(x, y);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000577A5 File Offset: 0x000559A5
		sbyte INumberBase<sbyte>.MultiplyAddEstimate(sbyte left, sbyte right, sbyte addend)
		{
			return left * right + addend;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000577AD File Offset: 0x000559AD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<sbyte>.TryConvertFromChecked<TOther>(TOther value, out sbyte result) where TOther : INumberBase<TOther>
		{
			return sbyte.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000577B8 File Offset: 0x000559B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out sbyte result) where TOther : INumberBase<TOther>
		{
			checked
			{
				if (typeof(TOther) == typeof(double))
				{
					double num = (double)((object)value);
					result = (sbyte)num;
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
					result = (sbyte)num2;
					return true;
				}
				if (typeof(TOther) == typeof(int))
				{
					int num3 = (int)((object)value);
					result = (sbyte)num3;
					return true;
				}
				if (typeof(TOther) == typeof(long))
				{
					long num4 = (long)((object)value);
					result = (sbyte)num4;
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
					result = (sbyte)intPtr;
					return true;
				}
				if (typeof(TOther) == typeof(float))
				{
					float num5 = (float)((object)value);
					result = (sbyte)num5;
					return true;
				}
				result = 0;
				return false;
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00057941 File Offset: 0x00055B41
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<sbyte>.TryConvertFromSaturating<TOther>(TOther value, out sbyte result) where TOther : INumberBase<TOther>
		{
			return sbyte.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0005794C File Offset: 0x00055B4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out sbyte result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 127.0) ? 127 : ((num <= -128.0) ? -128 : ((sbyte)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half >= 127) ? 127 : ((half <= -128) ? -128 : ((sbyte)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = ((num2 >= 127) ? 127 : ((num2 <= -128) ? -128 : ((sbyte)num2)));
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = ((num3 >= 127) ? 127 : ((num3 <= -128) ? -128 : ((sbyte)num3)));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)((object)value);
				result = ((num4 >= 127L) ? 127 : ((num4 <= -128L) ? -128 : ((sbyte)num4)));
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (Int128)((object)value);
				result = ((@int >= 127) ? 127 : ((@int <= -128) ? -128 : ((sbyte)@int)));
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = ((intPtr >= (IntPtr)127) ? 127 : ((intPtr <= (IntPtr)(-128)) ? -128 : ((sbyte)intPtr)));
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)((object)value);
				result = ((num5 >= 127f) ? 127 : ((num5 <= -128f) ? -128 : ((sbyte)num5)));
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00057BAD File Offset: 0x00055DAD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<sbyte>.TryConvertFromTruncating<TOther>(TOther value, out sbyte result) where TOther : INumberBase<TOther>
		{
			return sbyte.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00057BB8 File Offset: 0x00055DB8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out sbyte result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 127.0) ? 127 : ((num <= -128.0) ? -128 : ((sbyte)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half >= 127) ? 127 : ((half <= -128) ? -128 : ((sbyte)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (sbyte)num2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = (sbyte)num3;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)((object)value);
				result = (sbyte)num4;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value2 = (Int128)((object)value);
				result = (sbyte)value2;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = (sbyte)intPtr;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)((object)value);
				result = ((num5 >= 127f) ? 127 : ((num5 <= -128f) ? -128 : ((sbyte)num5)));
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00057DA4 File Offset: 0x00055FA4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<sbyte>.TryConvertToChecked<TOther>(sbyte value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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

		// Token: 0x06001B3B RID: 6971 RVA: 0x00057F54 File Offset: 0x00056154
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<sbyte>.TryConvertToSaturating<TOther>(sbyte value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value <= 0) ? 0 : ((byte)value);
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

		// Token: 0x06001B3C RID: 6972 RVA: 0x00058138 File Offset: 0x00056338
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<sbyte>.TryConvertToTruncating<TOther>(sbyte value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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

		// Token: 0x06001B3D RID: 6973 RVA: 0x000582E4 File Offset: 0x000564E4
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out sbyte result)
		{
			return sbyte.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000582EF File Offset: 0x000564EF
		sbyte IShiftOperators<sbyte, int, sbyte>.op_LeftShift(sbyte value, int shiftAmount)
		{
			return (sbyte)(value << shiftAmount);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000582F8 File Offset: 0x000564F8
		sbyte IShiftOperators<sbyte, int, sbyte>.op_RightShift(sbyte value, int shiftAmount)
		{
			return (sbyte)(value >> shiftAmount);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00058301 File Offset: 0x00056501
		sbyte IShiftOperators<sbyte, int, sbyte>.op_UnsignedRightShift(sbyte value, int shiftAmount)
		{
			return (sbyte)((uint)((byte)value) >> shiftAmount);
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x0003F19A File Offset: 0x0003D39A
		sbyte ISignedNumber<sbyte>.NegativeOne
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0005830B File Offset: 0x0005650B
		public static sbyte Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return sbyte.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00058315 File Offset: 0x00056515
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out sbyte result)
		{
			return sbyte.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00058320 File Offset: 0x00056520
		sbyte ISubtractionOperators<sbyte, sbyte, sbyte>.op_Subtraction(sbyte left, sbyte right)
		{
			return left - right;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00058326 File Offset: 0x00056526
		sbyte ISubtractionOperators<sbyte, sbyte, sbyte>.op_CheckedSubtraction(sbyte left, sbyte right)
		{
			return checked(left - right);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0005832C File Offset: 0x0005652C
		sbyte IUnaryNegationOperators<sbyte, sbyte>.op_UnaryNegation(sbyte value)
		{
			return -value;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00058331 File Offset: 0x00056531
		sbyte IUnaryNegationOperators<sbyte, sbyte>.op_CheckedUnaryNegation(sbyte value)
		{
			return checked(0 - value);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00058337 File Offset: 0x00056537
		sbyte IUnaryPlusOperators<sbyte, sbyte>.op_UnaryPlus(sbyte value)
		{
			return value;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0005833B File Offset: 0x0005653B
		public static sbyte Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, sbyte>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00058350 File Offset: 0x00056550
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out sbyte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, sbyte>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00058369 File Offset: 0x00056569
		public static sbyte Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return sbyte.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00058373 File Offset: 0x00056573
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out sbyte result)
		{
			return sbyte.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x000070DD File Offset: 0x000052DD
		bool IBinaryIntegerParseAndFormatInfo<sbyte>.IsSigned
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0001FC46 File Offset: 0x0001DE46
		int IBinaryIntegerParseAndFormatInfo<sbyte>.MaxDigitCount
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int IBinaryIntegerParseAndFormatInfo<sbyte>.MaxHexDigitCount
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00029ADC File Offset: 0x00027CDC
		sbyte IBinaryIntegerParseAndFormatInfo<sbyte>.MaxValueDiv10
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x0005837E File Offset: 0x0005657E
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<sbyte>.OverflowMessage
		{
			get
			{
				return SR.Overflow_SByte;
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00058385 File Offset: 0x00056585
		bool IBinaryIntegerParseAndFormatInfo<sbyte>.IsGreaterThanAsUnsigned(sbyte left, sbyte right)
		{
			return (byte)left > (byte)right;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0005838D File Offset: 0x0005658D
		sbyte IBinaryIntegerParseAndFormatInfo<sbyte>.MultiplyBy10(sbyte value)
		{
			return value * 10;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00058394 File Offset: 0x00056594
		sbyte IBinaryIntegerParseAndFormatInfo<sbyte>.MultiplyBy16(sbyte value)
		{
			return value * 16;
		}

		// Token: 0x04000563 RID: 1379
		private readonly sbyte m_value;

		// Token: 0x04000564 RID: 1380
		public const sbyte MaxValue = 127;

		// Token: 0x04000565 RID: 1381
		public const sbyte MinValue = -128;
	}
}
