using System;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

namespace System
{
	// Token: 0x020000E3 RID: 227
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible, ISpanFormattable, IFormattable, IBinaryInteger<char>, IBinaryNumber<char>, IBitwiseOperators<char, char, char>, INumber<char>, IComparisonOperators<char, char, bool>, IEqualityOperators<char, char, bool>, IModulusOperators<char, char, char>, INumberBase<char>, IAdditionOperators<char, char, char>, IAdditiveIdentity<char, char>, IDecrementOperators<char>, IDivisionOperators<char, char, char>, IIncrementOperators<char>, IMultiplicativeIdentity<char, char>, IMultiplyOperators<char, char, char>, ISpanParsable<char>, IParsable<char>, ISubtractionOperators<char, char, char>, IUnaryPlusOperators<char, char>, IUnaryNegationOperators<char, char>, IUtf8SpanFormattable, IUtf8SpanParsable<char>, IShiftOperators<char, int, char>, IMinMaxValue<char>, IUnsignedNumber<char>, IUtfChar<char>, IBinaryIntegerParseAndFormatInfo<char>
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00020E73 File Offset: 0x0001F073
		private unsafe static ReadOnlySpan<byte> Latin1CharInfo
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.1D715D2A2ED1CDD8C368F519DF4B8B9748F65E031AEA80652432FBBA5C35DFE6), 256);
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00020E84 File Offset: 0x0001F084
		private static bool IsLatin1(char c)
		{
			return (int)c < char.Latin1CharInfo.Length;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00020EA1 File Offset: 0x0001F0A1
		public static bool IsAscii(char c)
		{
			return c <= '\u007f';
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00020EAC File Offset: 0x0001F0AC
		private unsafe static UnicodeCategory GetLatin1UnicodeCategory(char c)
		{
			return (UnicodeCategory)(*char.Latin1CharInfo[(int)c] & 31);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00020ECB File Offset: 0x0001F0CB
		public override int GetHashCode()
		{
			return (int)(this | (int)this << 16);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00020ED5 File Offset: 0x0001F0D5
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is char && this == (char)obj;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00020EEB File Offset: 0x0001F0EB
		[NonVersionable]
		public bool Equals(char obj)
		{
			return this == obj;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00020EF2 File Offset: 0x0001F0F2
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is char))
			{
				throw new ArgumentException(SR.Arg_MustBeChar);
			}
			return (int)(this - (char)value);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00020F15 File Offset: 0x0001F115
		public int CompareTo(char value)
		{
			return (int)(this - value);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00020F1B File Offset: 0x0001F11B
		[NullableContext(1)]
		public override string ToString()
		{
			return char.ToString(this);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00020F1B File Offset: 0x0001F11B
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return char.ToString(this);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00020F24 File Offset: 0x0001F124
		[NullableContext(1)]
		public static string ToString(char c)
		{
			return string.CreateFromChar(c);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00020F2C File Offset: 0x0001F12C
		unsafe bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			if (!destination.IsEmpty)
			{
				*destination[0] = this;
				charsWritten = 1;
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00020F4C File Offset: 0x0001F14C
		bool IUtf8SpanFormattable.TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return new Rune(this).TryEncodeToUtf8(utf8Destination, out bytesWritten);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00020F1B File Offset: 0x0001F11B
		string IFormattable.ToString(string format, IFormatProvider formatProvider)
		{
			return char.ToString(this);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00020F6A File Offset: 0x0001F16A
		[NullableContext(1)]
		public static char Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return char.Parse(s.AsSpan());
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00020F81 File Offset: 0x0001F181
		internal unsafe static char Parse(ReadOnlySpan<char> s)
		{
			if (s.Length != 1)
			{
				ThrowHelper.ThrowFormatException_NeedSingleChar();
			}
			return (char)(*s[0]);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00020F9B File Offset: 0x0001F19B
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out char result)
		{
			if (s == null)
			{
				result = '\0';
				return false;
			}
			return char.TryParse(s.AsSpan(), out result);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00020FB1 File Offset: 0x0001F1B1
		internal unsafe static bool TryParse(ReadOnlySpan<char> s, out char result)
		{
			if (s.Length != 1)
			{
				result = '\0';
				return false;
			}
			result = (char)(*s[0]);
			return true;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00020FCE File Offset: 0x0001F1CE
		public static bool IsAsciiLetter(char c)
		{
			return (c | ' ') - 'a' <= '\u0019';
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00020FDE File Offset: 0x0001F1DE
		public static bool IsAsciiLetterLower(char c)
		{
			return char.IsBetween(c, 'a', 'z');
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00020FEA File Offset: 0x0001F1EA
		public static bool IsAsciiLetterUpper(char c)
		{
			return char.IsBetween(c, 'A', 'Z');
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00020FF6 File Offset: 0x0001F1F6
		public static bool IsAsciiDigit(char c)
		{
			return char.IsBetween(c, '0', '9');
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00021002 File Offset: 0x0001F202
		public static bool IsAsciiLetterOrDigit(char c)
		{
			return char.IsAsciiLetter(c) | char.IsBetween(c, '0', '9');
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00021015 File Offset: 0x0001F215
		public static bool IsAsciiHexDigit(char c)
		{
			return HexConverter.IsHexChar((int)c);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0002101D File Offset: 0x0001F21D
		public static bool IsAsciiHexDigitUpper(char c)
		{
			return HexConverter.IsHexUpperChar((int)c);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00021025 File Offset: 0x0001F225
		public static bool IsAsciiHexDigitLower(char c)
		{
			return HexConverter.IsHexLowerChar((int)c);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0002102D File Offset: 0x0001F22D
		public static bool IsDigit(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.IsBetween(c, '0', '9');
			}
			return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.DecimalDigitNumber;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0002104B File Offset: 0x0001F24B
		public static bool IsBetween(char c, char minInclusive, char maxInclusive)
		{
			return c - minInclusive <= maxInclusive - minInclusive;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0002104B File Offset: 0x0001F24B
		private static bool IsBetween(UnicodeCategory c, UnicodeCategory min, UnicodeCategory max)
		{
			return c - min <= max - min;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00021058 File Offset: 0x0001F258
		internal static bool CheckLetter(UnicodeCategory uc)
		{
			return char.IsBetween(uc, UnicodeCategory.UppercaseLetter, UnicodeCategory.OtherLetter);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00021064 File Offset: 0x0001F264
		public unsafe static bool IsLetter(char c)
		{
			if (char.IsAscii(c))
			{
				return (*char.Latin1CharInfo[(int)c] & 96) > 0;
			}
			return char.CheckLetter(CharUnicodeInfo.GetUnicodeCategory(c));
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0002109C File Offset: 0x0001F29C
		private unsafe static bool IsWhiteSpaceLatin1(char c)
		{
			return (*char.Latin1CharInfo[(int)c] & 128) > 0;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000210C1 File Offset: 0x0001F2C1
		public static bool IsWhiteSpace(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.IsWhiteSpaceLatin1(c);
			}
			return CharUnicodeInfo.GetIsWhiteSpace(c);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000210D8 File Offset: 0x0001F2D8
		public unsafe static bool IsUpper(char c)
		{
			if (char.IsLatin1(c))
			{
				return (*char.Latin1CharInfo[(int)c] & 64) > 0;
			}
			return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0002110C File Offset: 0x0001F30C
		public unsafe static bool IsLower(char c)
		{
			if (char.IsLatin1(c))
			{
				return (*char.Latin1CharInfo[(int)c] & 32) > 0;
			}
			return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00021140 File Offset: 0x0001F340
		internal static bool CheckPunctuation(UnicodeCategory uc)
		{
			return char.IsBetween(uc, UnicodeCategory.ConnectorPunctuation, UnicodeCategory.OtherPunctuation);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0002114C File Offset: 0x0001F34C
		public static bool IsPunctuation(char c)
		{
			return char.CheckPunctuation(char.IsLatin1(c) ? char.GetLatin1UnicodeCategory(c) : CharUnicodeInfo.GetUnicodeCategory(c));
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00021169 File Offset: 0x0001F369
		internal static bool CheckLetterOrDigit(UnicodeCategory uc)
		{
			return (287 & 1 << (int)uc) != 0;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0002117A File Offset: 0x0001F37A
		public static bool IsLetterOrDigit(char c)
		{
			return char.CheckLetterOrDigit(char.IsLatin1(c) ? char.GetLatin1UnicodeCategory(c) : CharUnicodeInfo.GetUnicodeCategory(c));
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00021197 File Offset: 0x0001F397
		[NullableContext(1)]
		public static char ToUpper(char c, CultureInfo culture)
		{
			if (culture == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.culture);
			}
			return culture.TextInfo.ToUpper(c);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000211AF File Offset: 0x0001F3AF
		public static char ToUpper(char c)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToUpper(c);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000211C1 File Offset: 0x0001F3C1
		public static char ToUpperInvariant(char c)
		{
			return TextInfo.ToUpperInvariant(c);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000211C9 File Offset: 0x0001F3C9
		[NullableContext(1)]
		public static char ToLower(char c, CultureInfo culture)
		{
			if (culture == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.culture);
			}
			return culture.TextInfo.ToLower(c);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000211E1 File Offset: 0x0001F3E1
		public static char ToLower(char c)
		{
			return CultureInfo.CurrentCulture.TextInfo.ToLower(c);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000211F3 File Offset: 0x0001F3F3
		public static char ToLowerInvariant(char c)
		{
			return TextInfo.ToLowerInvariant(c);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000211FB File Offset: 0x0001F3FB
		public TypeCode GetTypeCode()
		{
			return TypeCode.Char;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000211FE File Offset: 0x0001F3FE
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Char", "Boolean"));
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00021219 File Offset: 0x0001F419
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0002121D File Offset: 0x0001F41D
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00021226 File Offset: 0x0001F426
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0002122F File Offset: 0x0001F42F
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00021238 File Offset: 0x0001F438
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00021241 File Offset: 0x0001F441
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0002124A File Offset: 0x0001F44A
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00021253 File Offset: 0x0001F453
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0002125C File Offset: 0x0001F45C
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00021265 File Offset: 0x0001F465
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Char", "Single"));
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00021280 File Offset: 0x0001F480
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Char", "Double"));
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0002129B File Offset: 0x0001F49B
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Char", "Decimal"));
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000212B6 File Offset: 0x0001F4B6
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Char", "DateTime"));
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000212D1 File Offset: 0x0001F4D1
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000212E1 File Offset: 0x0001F4E1
		public static bool IsControl(char c)
		{
			return ((int)(c + '\u0001') & -129) <= 32;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000212F3 File Offset: 0x0001F4F3
		[NullableContext(1)]
		public static bool IsControl(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return char.IsControl(s[index]);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0002131C File Offset: 0x0001F51C
		[NullableContext(1)]
		public static bool IsDigit(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			if (char.IsLatin1(c))
			{
				return char.IsBetween(c, '0', '9');
			}
			return CharUnicodeInfo.GetUnicodeCategoryInternal(s, index) == UnicodeCategory.DecimalDigitNumber;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00021368 File Offset: 0x0001F568
		[NullableContext(1)]
		public unsafe static bool IsLetter(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			if (char.IsAscii(c))
			{
				return (*char.Latin1CharInfo[(int)c] & 96) > 0;
			}
			return char.CheckLetter(CharUnicodeInfo.GetUnicodeCategoryInternal(s, index));
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000213C4 File Offset: 0x0001F5C4
		[NullableContext(1)]
		public static bool IsLetterOrDigit(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			return char.CheckLetterOrDigit(char.IsLatin1(c) ? char.GetLatin1UnicodeCategory(c) : CharUnicodeInfo.GetUnicodeCategoryInternal(s, index));
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00021410 File Offset: 0x0001F610
		[NullableContext(1)]
		public unsafe static bool IsLower(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			if (char.IsLatin1(c))
			{
				return (*char.Latin1CharInfo[(int)c] & 32) > 0;
			}
			return CharUnicodeInfo.GetUnicodeCategoryInternal(s, index) == UnicodeCategory.LowercaseLetter;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00021467 File Offset: 0x0001F667
		internal static bool CheckNumber(UnicodeCategory uc)
		{
			return char.IsBetween(uc, UnicodeCategory.DecimalDigitNumber, UnicodeCategory.OtherNumber);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00021472 File Offset: 0x0001F672
		public static bool IsNumber(char c)
		{
			if (!char.IsLatin1(c))
			{
				return char.CheckNumber(CharUnicodeInfo.GetUnicodeCategory(c));
			}
			if (char.IsAscii(c))
			{
				return char.IsBetween(c, '0', '9');
			}
			return char.CheckNumber(char.GetLatin1UnicodeCategory(c));
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000214A8 File Offset: 0x0001F6A8
		[NullableContext(1)]
		public static bool IsNumber(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			if (!char.IsLatin1(c))
			{
				return char.CheckNumber(CharUnicodeInfo.GetUnicodeCategoryInternal(s, index));
			}
			if (char.IsAscii(c))
			{
				return char.IsBetween(c, '0', '9');
			}
			return char.CheckNumber(char.GetLatin1UnicodeCategory(c));
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0002150C File Offset: 0x0001F70C
		[NullableContext(1)]
		public static bool IsPunctuation(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			return char.CheckPunctuation(char.IsLatin1(c) ? char.GetLatin1UnicodeCategory(c) : CharUnicodeInfo.GetUnicodeCategoryInternal(s, index));
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00021557 File Offset: 0x0001F757
		internal static bool CheckSeparator(UnicodeCategory uc)
		{
			return char.IsBetween(uc, UnicodeCategory.SpaceSeparator, UnicodeCategory.ParagraphSeparator);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00021563 File Offset: 0x0001F763
		private static bool IsSeparatorLatin1(char c)
		{
			return c == ' ' || c == '\u00a0';
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00021574 File Offset: 0x0001F774
		public static bool IsSeparator(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.IsSeparatorLatin1(c);
			}
			return char.CheckSeparator(CharUnicodeInfo.GetUnicodeCategory(c));
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00021590 File Offset: 0x0001F790
		[NullableContext(1)]
		public static bool IsSeparator(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			if (char.IsLatin1(c))
			{
				return char.IsSeparatorLatin1(c);
			}
			return char.CheckSeparator(CharUnicodeInfo.GetUnicodeCategoryInternal(s, index));
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000215DA File Offset: 0x0001F7DA
		public static bool IsSurrogate(char c)
		{
			return char.IsBetween(c, '\ud800', '\udfff');
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000215EC File Offset: 0x0001F7EC
		[NullableContext(1)]
		public static bool IsSurrogate(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return char.IsSurrogate(s[index]);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00021614 File Offset: 0x0001F814
		internal static bool CheckSymbol(UnicodeCategory uc)
		{
			return char.IsBetween(uc, UnicodeCategory.MathSymbol, UnicodeCategory.OtherSymbol);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00021620 File Offset: 0x0001F820
		public static bool IsSymbol(char c)
		{
			return char.CheckSymbol(char.IsLatin1(c) ? char.GetLatin1UnicodeCategory(c) : CharUnicodeInfo.GetUnicodeCategory(c));
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00021640 File Offset: 0x0001F840
		[NullableContext(1)]
		public static bool IsSymbol(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			return char.CheckSymbol(char.IsLatin1(c) ? char.GetLatin1UnicodeCategory(c) : CharUnicodeInfo.GetUnicodeCategoryInternal(s, index));
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0002168C File Offset: 0x0001F88C
		[NullableContext(1)]
		public unsafe static bool IsUpper(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			char c = s[index];
			if (char.IsLatin1(c))
			{
				return (*char.Latin1CharInfo[(int)c] & 64) > 0;
			}
			return CharUnicodeInfo.GetUnicodeCategoryInternal(s, index) == UnicodeCategory.UppercaseLetter;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000216E3 File Offset: 0x0001F8E3
		[NullableContext(1)]
		public static bool IsWhiteSpace(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return char.IsWhiteSpace(s[index]);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0002170B File Offset: 0x0001F90B
		public static UnicodeCategory GetUnicodeCategory(char c)
		{
			if (char.IsLatin1(c))
			{
				return char.GetLatin1UnicodeCategory(c);
			}
			return CharUnicodeInfo.GetUnicodeCategory((int)c);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00021722 File Offset: 0x0001F922
		[NullableContext(1)]
		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			if (char.IsLatin1(s[index]))
			{
				return char.GetLatin1UnicodeCategory(s[index]);
			}
			return CharUnicodeInfo.GetUnicodeCategoryInternal(s, index);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00021760 File Offset: 0x0001F960
		public static double GetNumericValue(char c)
		{
			return CharUnicodeInfo.GetNumericValue(c);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00021768 File Offset: 0x0001F968
		[NullableContext(1)]
		public static double GetNumericValue(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return CharUnicodeInfo.GetNumericValueInternal(s, index);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0002178B File Offset: 0x0001F98B
		public static bool IsHighSurrogate(char c)
		{
			return char.IsBetween(c, '\ud800', '\udbff');
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0002179D File Offset: 0x0001F99D
		[NullableContext(1)]
		public static bool IsHighSurrogate(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return char.IsHighSurrogate(s[index]);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000217C5 File Offset: 0x0001F9C5
		public static bool IsLowSurrogate(char c)
		{
			return char.IsBetween(c, '\udc00', '\udfff');
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000217D7 File Offset: 0x0001F9D7
		[NullableContext(1)]
		public static bool IsLowSurrogate(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return char.IsLowSurrogate(s[index]);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000217FF File Offset: 0x0001F9FF
		[NullableContext(1)]
		public static bool IsSurrogatePair(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return index + 1 < s.Length && char.IsSurrogatePair(s[index], s[index + 1]);
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00021840 File Offset: 0x0001FA40
		public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
		{
			uint num = (uint)(highSurrogate - '\ud800');
			uint num2 = (uint)(lowSurrogate - '\udc00');
			return (num | num2) <= 1023U;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00021868 File Offset: 0x0001FA68
		[NullableContext(1)]
		public static string ConvertFromUtf32(int utf32)
		{
			if (!UnicodeUtility.IsValidUnicodeScalar((uint)utf32))
			{
				throw new ArgumentOutOfRangeException("utf32", SR.ArgumentOutOfRange_InvalidUTF32);
			}
			return Rune.UnsafeCreate((uint)utf32).ToString();
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000218A4 File Offset: 0x0001FAA4
		public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
		{
			uint num = (uint)(highSurrogate - '\ud800');
			uint num2 = (uint)(lowSurrogate - '\udc00');
			if ((num | num2) > 1023U)
			{
				char.ConvertToUtf32_ThrowInvalidArgs(num);
			}
			return (int)((num << 10) + (uint)(lowSurrogate - '\udc00') + 65536U);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000218E3 File Offset: 0x0001FAE3
		[StackTraceHidden]
		private static void ConvertToUtf32_ThrowInvalidArgs(uint highSurrogateOffset)
		{
			if (highSurrogateOffset > 1023U)
			{
				throw new ArgumentOutOfRangeException("highSurrogate", SR.ArgumentOutOfRange_InvalidHighSurrogate);
			}
			throw new ArgumentOutOfRangeException("lowSurrogate", SR.ArgumentOutOfRange_InvalidLowSurrogate);
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0002190C File Offset: 0x0001FB0C
		[NullableContext(1)]
		public static int ConvertToUtf32(string s, int index)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (index >= s.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			int num = (int)(s[index] - '\ud800');
			if (num <= 2047)
			{
				bool flag = true;
				if (num <= 1023)
				{
					if (index + 1 < s.Length)
					{
						int num2 = (int)(s[index + 1] - '\udc00');
						if (num2 <= 1023)
						{
							return num * 1024 + num2 + 65536;
						}
					}
					flag = false;
				}
				throw new ArgumentException(SR.Format(flag ? SR.Argument_InvalidLowSurrogate : SR.Argument_InvalidHighSurrogate, index), "s");
			}
			return (int)s[index];
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000219B5 File Offset: 0x0001FBB5
		char IAdditionOperators<char, char, char>.op_Addition(char left, char right)
		{
			return left + right;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000219BB File Offset: 0x0001FBBB
		char IAdditionOperators<char, char, char>.op_CheckedAddition(char left, char right)
		{
			return checked(left + right);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00007B65 File Offset: 0x00005D65
		char IAdditiveIdentity<char, char>.AdditiveIdentity
		{
			get
			{
				return '\0';
			}
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000219C1 File Offset: 0x0001FBC1
		char IBinaryInteger<char>.LeadingZeroCount(char value)
		{
			return (char)(BitOperations.LeadingZeroCount((uint)value) - 16);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000219CD File Offset: 0x0001FBCD
		char IBinaryInteger<char>.PopCount(char value)
		{
			return (char)BitOperations.PopCount((uint)value);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000219D6 File Offset: 0x0001FBD6
		char IBinaryInteger<char>.RotateLeft(char value, int rotateAmount)
		{
			return value << (rotateAmount & 15 & 31) | value >> (16 - rotateAmount & 15 & 31);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x000219EF File Offset: 0x0001FBEF
		char IBinaryInteger<char>.RotateRight(char value, int rotateAmount)
		{
			return value >> (rotateAmount & 15 & 31) | value << (16 - rotateAmount & 15 & 31);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00021A08 File Offset: 0x0001FC08
		char IBinaryInteger<char>.TrailingZeroCount(char value)
		{
			return (char)(BitOperations.TrailingZeroCount((int)((int)value << 16)) - 16);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00021A18 File Offset: 0x0001FC18
		unsafe bool IBinaryInteger<char>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out char value)
		{
			char c = '\0';
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[0])))
				{
					value = c;
					return false;
				}
				if (source.Length > 2)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 2).ContainsAnyExcept(0))
					{
						value = c;
						return false;
					}
				}
				ref byte ptr2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 2)
				{
					ptr2 = Unsafe.Add<byte>(ref ptr2, source.Length - 2);
					c = Unsafe.ReadUnaligned<char>(ref ptr2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					c = BinaryPrimitives.ReverseEndianness(c);
				}
				else
				{
					c = (char)ptr2;
				}
			}
			value = c;
			return true;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		unsafe bool IBinaryInteger<char>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out char value)
		{
			char c = '\0';
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[source.Length - 1])))
				{
					value = c;
					return false;
				}
				if (source.Length > 2)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(2, ptr.Length - 2).ContainsAnyExcept(0))
					{
						value = c;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 2)
				{
					c = Unsafe.ReadUnaligned<char>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_76;
					}
				}
				c = (char)reference;
			}
			IL_76:
			value = c;
			return true;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00021B37 File Offset: 0x0001FD37
		int IBinaryInteger<char>.GetShortestBitLength()
		{
			return (int)(16 - ushort.LeadingZeroCount((ushort)this));
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int IBinaryInteger<char>.GetByteCount()
		{
			return 2;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00021B44 File Offset: 0x0001FD44
		bool IBinaryInteger<char>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				ushort value = (ushort)BinaryPrimitives.ReverseEndianness(this);
				Unsafe.WriteUnaligned<ushort>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00021B80 File Offset: 0x0001FD80
		bool IBinaryInteger<char>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				ushort value = (ushort)this;
				Unsafe.WriteUnaligned<ushort>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00021BB6 File Offset: 0x0001FDB6
		char IBinaryNumber<char>.AllBitsSet
		{
			get
			{
				return '￿';
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00021BBD File Offset: 0x0001FDBD
		bool IBinaryNumber<char>.IsPow2(char value)
		{
			return ushort.IsPow2((ushort)value);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00021BC5 File Offset: 0x0001FDC5
		char IBinaryNumber<char>.Log2(char value)
		{
			return (char)ushort.Log2((ushort)value);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00021BCD File Offset: 0x0001FDCD
		char IBitwiseOperators<char, char, char>.op_BitwiseAnd(char left, char right)
		{
			return left & right;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00021BD3 File Offset: 0x0001FDD3
		char IBitwiseOperators<char, char, char>.op_BitwiseOr(char left, char right)
		{
			return left | right;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00021BD9 File Offset: 0x0001FDD9
		char IBitwiseOperators<char, char, char>.op_ExclusiveOr(char left, char right)
		{
			return left ^ right;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00021BDF File Offset: 0x0001FDDF
		char IBitwiseOperators<char, char, char>.op_OnesComplement(char value)
		{
			return ~value;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00020126 File Offset: 0x0001E326
		bool IComparisonOperators<char, char, bool>.op_LessThan(char left, char right)
		{
			return left < right;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0002012C File Offset: 0x0001E32C
		bool IComparisonOperators<char, char, bool>.op_LessThanOrEqual(char left, char right)
		{
			return left <= right;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00020135 File Offset: 0x0001E335
		bool IComparisonOperators<char, char, bool>.op_GreaterThan(char left, char right)
		{
			return left > right;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0002013B File Offset: 0x0001E33B
		bool IComparisonOperators<char, char, bool>.op_GreaterThanOrEqual(char left, char right)
		{
			return left >= right;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00021BE4 File Offset: 0x0001FDE4
		char IDecrementOperators<char>.op_Decrement(char value)
		{
			return value -= '\u0001';
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00021BED File Offset: 0x0001FDED
		char IDecrementOperators<char>.op_CheckedDecrement(char value)
		{
			return checked(value -= '\u0001');
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00021BF6 File Offset: 0x0001FDF6
		char IDivisionOperators<char, char, char>.op_Division(char left, char right)
		{
			return left / right;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<char, char, bool>.op_Equality(char left, char right)
		{
			return left == right;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<char, char, bool>.op_Inequality(char left, char right)
		{
			return left != right;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00021BFC File Offset: 0x0001FDFC
		char IIncrementOperators<char>.op_Increment(char value)
		{
			return value += '\u0001';
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00021C05 File Offset: 0x0001FE05
		char IIncrementOperators<char>.op_CheckedIncrement(char value)
		{
			return checked(value += '\u0001');
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00007B65 File Offset: 0x00005D65
		char IMinMaxValue<char>.MinValue
		{
			get
			{
				return '\0';
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00021BB6 File Offset: 0x0001FDB6
		char IMinMaxValue<char>.MaxValue
		{
			get
			{
				return '￿';
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00021C0E File Offset: 0x0001FE0E
		char IModulusOperators<char, char, char>.op_Modulus(char left, char right)
		{
			return left % right;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000070DD File Offset: 0x000052DD
		char IMultiplicativeIdentity<char, char>.MultiplicativeIdentity
		{
			get
			{
				return '\u0001';
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00021C14 File Offset: 0x0001FE14
		char IMultiplyOperators<char, char, char>.op_Multiply(char left, char right)
		{
			return left * right;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00021C1A File Offset: 0x0001FE1A
		char IMultiplyOperators<char, char, char>.op_CheckedMultiply(char left, char right)
		{
			return checked(left * right);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x000070DD File Offset: 0x000052DD
		char INumberBase<char>.One
		{
			get
			{
				return '\u0001';
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<char>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00007B65 File Offset: 0x00005D65
		char INumberBase<char>.Zero
		{
			get
			{
				return '\0';
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00007B62 File Offset: 0x00005D62
		char INumberBase<char>.Abs(char value)
		{
			return value;
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<char>.IsCanonical(char value)
		{
			return true;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<char>.IsComplexNumber(char value)
		{
			return false;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000202BE File Offset: 0x0001E4BE
		bool INumberBase<char>.IsEvenInteger(char value)
		{
			return (value & '\u0001') == '\0';
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<char>.IsFinite(char value)
		{
			return true;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<char>.IsImaginaryNumber(char value)
		{
			return false;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<char>.IsInfinity(char value)
		{
			return false;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<char>.IsInteger(char value)
		{
			return true;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<char>.IsNaN(char value)
		{
			return false;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<char>.IsNegative(char value)
		{
			return false;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<char>.IsNegativeInfinity(char value)
		{
			return false;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000201AE File Offset: 0x0001E3AE
		bool INumberBase<char>.IsNormal(char value)
		{
			return value > '\0';
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000202C6 File Offset: 0x0001E4C6
		bool INumberBase<char>.IsOddInteger(char value)
		{
			return (value & '\u0001') > '\0';
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<char>.IsPositive(char value)
		{
			return true;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<char>.IsPositiveInfinity(char value)
		{
			return false;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<char>.IsRealNumber(char value)
		{
			return true;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<char>.IsSubnormal(char value)
		{
			return false;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000202CE File Offset: 0x0001E4CE
		bool INumberBase<char>.IsZero(char value)
		{
			return value == '\0';
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00021C20 File Offset: 0x0001FE20
		char INumberBase<char>.MaxMagnitude(char x, char y)
		{
			return (char)Math.Max((ushort)x, (ushort)y);
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00021C20 File Offset: 0x0001FE20
		char INumberBase<char>.MaxMagnitudeNumber(char x, char y)
		{
			return (char)Math.Max((ushort)x, (ushort)y);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00021C29 File Offset: 0x0001FE29
		char INumberBase<char>.MinMagnitude(char x, char y)
		{
			return (char)Math.Min((ushort)x, (ushort)y);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00021C29 File Offset: 0x0001FE29
		char INumberBase<char>.MinMagnitudeNumber(char x, char y)
		{
			return (char)Math.Min((ushort)x, (ushort)y);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00021C32 File Offset: 0x0001FE32
		char INumberBase<char>.MultiplyAddEstimate(char left, char right, char addend)
		{
			return left * right + addend;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00021C3A File Offset: 0x0001FE3A
		char INumberBase<char>.Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			return char.Parse(s);
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00021C42 File Offset: 0x0001FE42
		char INumberBase<char>.Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
		{
			return char.Parse(s);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00021C4C File Offset: 0x0001FE4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<char>.TryConvertFromChecked<TOther>(TOther value, out char result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (char)b;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal value2 = (decimal)((object)value);
				result = (char)value2;
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num = (ushort)((object)value);
				result = (char)num;
				return true;
			}
			checked
			{
				if (typeof(TOther) == typeof(uint))
				{
					uint num2 = (uint)((object)value);
					result = (char)num2;
					return true;
				}
				if (typeof(TOther) == typeof(ulong))
				{
					ulong num3 = (ulong)((object)value);
					result = (char)num3;
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
					result = (char)uintPtr;
					return true;
				}
				result = '\0';
				return false;
			}
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<char>.TryConvertFromSaturating<TOther>(TOther value, out char result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (char)b;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 65535m) ? '￿' : ((num <= 0m) ? '\0' : ((char)num)));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (char)num2;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((object)value);
				result = ((num3 >= 65535U) ? '￿' : ((char)num3));
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((object)value);
				result = ((num4 >= 65535UL) ? '￿' : ((char)num4));
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)((object)value);
				result = ((@uint >= '￿') ? '￿' : ((char)@uint));
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = ((uintPtr >= (UIntPtr)((IntPtr)65535)) ? '￿' : ((char)uintPtr));
				return true;
			}
			result = '\0';
			return false;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00021F70 File Offset: 0x00020170
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<char>.TryConvertFromTruncating<TOther>(TOther value, out char result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (char)b;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 65535m) ? '￿' : ((num <= 0m) ? '\0' : ((char)num)));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (char)num2;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((object)value);
				result = (char)num3;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((object)value);
				result = (char)num4;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value2 = (UInt128)((object)value);
				result = (char)value2;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = (char)uintPtr;
				return true;
			}
			result = '\0';
			return false;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000220F4 File Offset: 0x000202F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<char>.TryConvertToChecked<TOther>(char value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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

		// Token: 0x06000C0C RID: 3084 RVA: 0x000222D4 File Offset: 0x000204D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<char>.TryConvertToSaturating<TOther>(char value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
				short num2 = (value >= '翿') ? short.MaxValue : ((short)value);
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
				sbyte b = (value >= '\u007f') ? sbyte.MaxValue : ((sbyte)value);
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

		// Token: 0x06000C0D RID: 3085 RVA: 0x000224CC File Offset: 0x000206CC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<char>.TryConvertToTruncating<TOther>(char value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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

		// Token: 0x06000C0E RID: 3086 RVA: 0x000226AB File Offset: 0x000208AB
		bool INumberBase<char>.TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out char result)
		{
			return char.TryParse(s, out result);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000226B4 File Offset: 0x000208B4
		bool INumberBase<char>.TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out char result)
		{
			return char.TryParse(s, out result);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00021C3A File Offset: 0x0001FE3A
		char IParsable<char>.Parse(string s, IFormatProvider provider)
		{
			return char.Parse(s);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000226BD File Offset: 0x000208BD
		bool IParsable<char>.TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out char result)
		{
			return char.TryParse(s, out result);
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000226C6 File Offset: 0x000208C6
		char IShiftOperators<char, int, char>.op_LeftShift(char value, int shiftAmount)
		{
			return value << (shiftAmount & 31);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000226CF File Offset: 0x000208CF
		char IShiftOperators<char, int, char>.op_RightShift(char value, int shiftAmount)
		{
			return value >> (shiftAmount & 31);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000226D8 File Offset: 0x000208D8
		char IShiftOperators<char, int, char>.op_UnsignedRightShift(char value, int shiftAmount)
		{
			return value >> (shiftAmount & 31);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00021C42 File Offset: 0x0001FE42
		char ISpanParsable<char>.Parse(ReadOnlySpan<char> s, IFormatProvider provider)
		{
			return char.Parse(s);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000226E1 File Offset: 0x000208E1
		bool ISpanParsable<char>.TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out char result)
		{
			return char.TryParse(s, out result);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000226EA File Offset: 0x000208EA
		char ISubtractionOperators<char, char, char>.op_Subtraction(char left, char right)
		{
			return left - right;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000226F0 File Offset: 0x000208F0
		char ISubtractionOperators<char, char, char>.op_CheckedSubtraction(char left, char right)
		{
			return checked(left - right);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000226F6 File Offset: 0x000208F6
		char IUnaryNegationOperators<char, char>.op_UnaryNegation(char value)
		{
			return -value;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000226FB File Offset: 0x000208FB
		char IUnaryNegationOperators<char, char>.op_CheckedUnaryNegation(char value)
		{
			return checked('\0' - value);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00022701 File Offset: 0x00020901
		char IUnaryPlusOperators<char, char>.op_UnaryPlus(char value)
		{
			return value;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00007B62 File Offset: 0x00005D62
		char IUtfChar<char>.CastFrom(byte value)
		{
			return (char)value;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00007B62 File Offset: 0x00005D62
		char IUtfChar<char>.CastFrom(char value)
		{
			return value;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00022701 File Offset: 0x00020901
		char IUtfChar<char>.CastFrom(int value)
		{
			return (char)value;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00022701 File Offset: 0x00020901
		char IUtfChar<char>.CastFrom(uint value)
		{
			return (char)value;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00022701 File Offset: 0x00020901
		char IUtfChar<char>.CastFrom(ulong value)
		{
			return (char)value;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00007B62 File Offset: 0x00005D62
		uint IUtfChar<char>.CastToUInt32(char value)
		{
			return (uint)value;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IBinaryIntegerParseAndFormatInfo<char>.IsSigned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00022705 File Offset: 0x00020905
		int IBinaryIntegerParseAndFormatInfo<char>.MaxDigitCount
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x000211FB File Offset: 0x0001F3FB
		int IBinaryIntegerParseAndFormatInfo<char>.MaxHexDigitCount
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00022708 File Offset: 0x00020908
		char IBinaryIntegerParseAndFormatInfo<char>.MaxValueDiv10
		{
			get
			{
				return 'ᦙ';
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0002270F File Offset: 0x0002090F
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<char>.OverflowMessage
		{
			get
			{
				return SR.Overflow_Char;
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00020135 File Offset: 0x0001E335
		bool IBinaryIntegerParseAndFormatInfo<char>.IsGreaterThanAsUnsigned(char left, char right)
		{
			return left > right;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00022716 File Offset: 0x00020916
		char IBinaryIntegerParseAndFormatInfo<char>.MultiplyBy10(char value)
		{
			return value * '\n';
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0002271D File Offset: 0x0002091D
		char IBinaryIntegerParseAndFormatInfo<char>.MultiplyBy16(char value)
		{
			return value * '\u0010';
		}

		// Token: 0x04000307 RID: 775
		private readonly char m_value;

		// Token: 0x04000308 RID: 776
		public const char MaxValue = '￿';

		// Token: 0x04000309 RID: 777
		public const char MinValue = '\0';
	}
}
