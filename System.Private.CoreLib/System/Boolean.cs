using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020000DF RID: 223
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Boolean : IComparable, IConvertible, IComparable<bool>, IEquatable<bool>, ISpanParsable<bool>, IParsable<bool>
	{
		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001F9D9 File Offset: 0x0001DBD9
		public override int GetHashCode()
		{
			return (this > false) ? 1 : 0;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		[NullableContext(1)]
		public override string ToString()
		{
			if (!this)
			{
				return "False";
			}
			return "True";
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0001F9F1 File Offset: 0x0001DBF1
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return this.ToString();
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0001F9FC File Offset: 0x0001DBFC
		public unsafe bool TryFormat(Span<char> destination, out int charsWritten)
		{
			if (this)
			{
				if (destination.Length > 3)
				{
					if (!BitConverter.IsLittleEndian)
					{
					}
					ulong num = 28429475166421076UL;
					MemoryMarshal.Write<ulong>(MemoryMarshal.AsBytes<char>(destination), num);
					charsWritten = 4;
					return true;
				}
			}
			else if (destination.Length > 4)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				ulong num2 = 32370086184550470UL;
				MemoryMarshal.Write<ulong>(MemoryMarshal.AsBytes<char>(destination), num2);
				*destination[4] = 'e';
				charsWritten = 5;
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0001FA76 File Offset: 0x0001DC76
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is bool && this == (bool)obj;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001FA8C File Offset: 0x0001DC8C
		[NonVersionable]
		public bool Equals(bool obj)
		{
			return this == obj;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0001FA93 File Offset: 0x0001DC93
		[NullableContext(2)]
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is bool))
			{
				throw new ArgumentException(SR.Arg_MustBeBoolean);
			}
			if (this == (bool)obj)
			{
				return 0;
			}
			if (!this)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0001FAC0 File Offset: 0x0001DCC0
		public int CompareTo(bool value)
		{
			if (this == value)
			{
				return 0;
			}
			if (!this)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		internal static bool IsTrueStringIgnoreCase(ReadOnlySpan<char> value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			ulong num = 28429475166421108UL;
			return value.Length == 4 && (MemoryMarshal.Read<ulong>(MemoryMarshal.AsBytes<char>(value)) | 9007336695791648UL) == num;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0001FB14 File Offset: 0x0001DD14
		internal unsafe static bool IsFalseStringIgnoreCase(ReadOnlySpan<char> value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			ulong num = 32370086184550502UL;
			return value.Length == 5 && ((MemoryMarshal.Read<ulong>(MemoryMarshal.AsBytes<char>(value)) | 9007336695791648UL) == num & (*value[4] | 32) == 101);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0001FB67 File Offset: 0x0001DD67
		[NullableContext(1)]
		public static bool Parse(string value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			return bool.Parse(value.AsSpan());
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001FB80 File Offset: 0x0001DD80
		public static bool Parse(ReadOnlySpan<char> value)
		{
			bool result;
			if (!bool.TryParse(value, out result))
			{
				ThrowHelper.ThrowFormatException_BadBoolean(value);
			}
			return result;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001FB9E File Offset: 0x0001DD9E
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string value, out bool result)
		{
			return bool.TryParse(value.AsSpan(), out result);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001FBAC File Offset: 0x0001DDAC
		public static bool TryParse(ReadOnlySpan<char> value, out bool result)
		{
			if (bool.IsTrueStringIgnoreCase(value))
			{
				result = true;
				return true;
			}
			if (bool.IsFalseStringIgnoreCase(value))
			{
				result = false;
				return true;
			}
			return bool.<TryParse>g__TryParseUncommon|20_0(value, out result);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001FBD0 File Offset: 0x0001DDD0
		private unsafe static ReadOnlySpan<char> TrimWhiteSpaceAndNull(ReadOnlySpan<char> value)
		{
			int num = 0;
			while (num < value.Length && (char.IsWhiteSpace((char)(*value[num])) || *value[num] == 0))
			{
				num++;
			}
			int num2 = value.Length - 1;
			while (num2 >= num && (char.IsWhiteSpace((char)(*value[num2])) || *value[num2] == 0))
			{
				num2--;
			}
			return value.Slice(num, num2 - num + 1);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001FC46 File Offset: 0x0001DE46
		public TypeCode GetTypeCode()
		{
			return TypeCode.Boolean;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0001FC49 File Offset: 0x0001DE49
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001FC4D File Offset: 0x0001DE4D
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Boolean", "Char"));
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0001FC68 File Offset: 0x0001DE68
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0001FC71 File Offset: 0x0001DE71
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0001FC7A File Offset: 0x0001DE7A
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0001FC83 File Offset: 0x0001DE83
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0001FC8C File Offset: 0x0001DE8C
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0001FC95 File Offset: 0x0001DE95
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0001FC9E File Offset: 0x0001DE9E
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0001FCA7 File Offset: 0x0001DEA7
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0001FCB9 File Offset: 0x0001DEB9
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0001FCC2 File Offset: 0x0001DEC2
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001FCCB File Offset: 0x0001DECB
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Boolean", "DateTime"));
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001FCE6 File Offset: 0x0001DEE6
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001FCF6 File Offset: 0x0001DEF6
		bool IParsable<bool>.Parse(string s, IFormatProvider provider)
		{
			return bool.Parse(s);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001FCFE File Offset: 0x0001DEFE
		bool IParsable<bool>.TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out bool result)
		{
			return bool.TryParse(s, out result);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001FD07 File Offset: 0x0001DF07
		bool ISpanParsable<bool>.Parse(ReadOnlySpan<char> s, IFormatProvider provider)
		{
			return bool.Parse(s);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001FD0F File Offset: 0x0001DF0F
		bool ISpanParsable<bool>.TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out bool result)
		{
			return bool.TryParse(s, out result);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0001FD30 File Offset: 0x0001DF30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool <TryParse>g__TryParseUncommon|20_0(ReadOnlySpan<char> value, out bool result)
		{
			int length = value.Length;
			if (length >= 5)
			{
				value = bool.TrimWhiteSpaceAndNull(value);
				if (value.Length != length)
				{
					if (bool.IsTrueStringIgnoreCase(value))
					{
						result = true;
						return true;
					}
					result = false;
					return bool.IsFalseStringIgnoreCase(value);
				}
			}
			result = false;
			return false;
		}

		// Token: 0x04000300 RID: 768
		private readonly bool m_value;

		// Token: 0x04000301 RID: 769
		[Nullable(1)]
		public static readonly string TrueString = "True";

		// Token: 0x04000302 RID: 770
		[Nullable(1)]
		public static readonly string FalseString = "False";
	}
}
