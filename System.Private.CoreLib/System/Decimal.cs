using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020000F5 RID: 245
	[NonVersionable]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Decimal : ISpanFormattable, IFormattable, IComparable, IConvertible, IComparable<decimal>, IEquatable<decimal>, ISerializable, IDeserializationCallback, IFloatingPoint<decimal>, IFloatingPointConstants<decimal>, INumberBase<decimal>, IAdditionOperators<decimal, decimal, decimal>, IAdditiveIdentity<decimal, decimal>, IDecrementOperators<decimal>, IDivisionOperators<decimal, decimal, decimal>, IEqualityOperators<decimal, decimal, bool>, IIncrementOperators<decimal>, IMultiplicativeIdentity<decimal, decimal>, IMultiplyOperators<decimal, decimal, decimal>, ISpanParsable<decimal>, IParsable<decimal>, ISubtractionOperators<decimal, decimal, decimal>, IUnaryPlusOperators<decimal, decimal>, IUnaryNegationOperators<decimal, decimal>, IUtf8SpanFormattable, IUtf8SpanParsable<decimal>, INumber<decimal>, IComparisonOperators<decimal, decimal, bool>, IModulusOperators<decimal, decimal, decimal>, ISignedNumber<decimal>, IMinMaxValue<decimal>
	{
		// Token: 0x06000F21 RID: 3873 RVA: 0x00028E6A File Offset: 0x0002706A
		public Decimal(int value)
		{
			if (value >= 0)
			{
				this._flags = 0;
			}
			else
			{
				this._flags = int.MinValue;
				value = -value;
			}
			this._lo64 = (ulong)value;
			this._hi32 = 0U;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00028E97 File Offset: 0x00027097
		[CLSCompliant(false)]
		public Decimal(uint value)
		{
			this._flags = 0;
			this._lo64 = (ulong)value;
			this._hi32 = 0U;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00028EAF File Offset: 0x000270AF
		public Decimal(long value)
		{
			if (value >= 0L)
			{
				this._flags = 0;
			}
			else
			{
				this._flags = int.MinValue;
				value = -value;
			}
			this._lo64 = (ulong)value;
			this._hi32 = 0U;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00028EDC File Offset: 0x000270DC
		[CLSCompliant(false)]
		public Decimal(ulong value)
		{
			this._flags = 0;
			this._lo64 = value;
			this._hi32 = 0U;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00028EF3 File Offset: 0x000270F3
		public Decimal(float value)
		{
			decimal.DecCalc.VarDecFromR4(value, decimal.AsMutable(ref this));
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00028F01 File Offset: 0x00027101
		public Decimal(double value)
		{
			decimal.DecCalc.VarDecFromR8(value, decimal.AsMutable(ref this));
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00028F10 File Offset: 0x00027110
		private Decimal(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			this._flags = info.GetInt32("flags");
			this._hi32 = (uint)info.GetInt32("hi");
			this._lo64 = (ulong)info.GetInt32("lo") + (ulong)((ulong)((long)info.GetInt32("mid")) << 32);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00028F6C File Offset: 0x0002716C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("flags", this._flags);
			info.AddValue("hi", (int)this.High);
			info.AddValue("lo", (int)this.Low);
			info.AddValue("mid", (int)this.Mid);
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00028FC8 File Offset: 0x000271C8
		public static decimal FromOACurrency(long cy)
		{
			bool isNegative = false;
			ulong num;
			if (cy < 0L)
			{
				isNegative = true;
				num = (ulong)(-(ulong)cy);
			}
			else
			{
				num = (ulong)cy;
			}
			int num2 = 4;
			if (num != 0UL)
			{
				while (num2 != 0 && num % 10UL == 0UL)
				{
					num2--;
					num /= 10UL;
				}
			}
			return new decimal((int)num, (int)(num >> 32), 0, isNegative, (byte)num2);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00029010 File Offset: 0x00027210
		public static long ToOACurrency(decimal value)
		{
			return decimal.DecCalc.VarCyFromDec(decimal.AsMutable(ref value));
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0002901E File Offset: 0x0002721E
		private static bool IsValid(int flags)
		{
			return (flags & 2130771967) == 0 && (flags & 16711680) <= 1835008;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0002903C File Offset: 0x0002723C
		[NullableContext(1)]
		public Decimal(int[] bits)
		{
			if (bits == null)
			{
				throw new ArgumentNullException("bits");
			}
			this = new decimal(bits);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0002905C File Offset: 0x0002725C
		public unsafe Decimal(ReadOnlySpan<int> bits)
		{
			if (bits.Length == 4)
			{
				int flags = *bits[3];
				if (decimal.IsValid(flags))
				{
					this._lo64 = (ulong)(*bits[0]) + ((ulong)(*bits[1]) << 32);
					this._hi32 = (uint)(*bits[2]);
					this._flags = flags;
					return;
				}
			}
			throw new ArgumentException(SR.Arg_DecBitCtor);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000290C4 File Offset: 0x000272C4
		public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
		{
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>((int)scale, 28, "scale");
			this._lo64 = (ulong)lo + ((ulong)mid << 32);
			this._hi32 = (uint)hi;
			this._flags = (int)scale << 16;
			if (isNegative)
			{
				this._flags |= int.MinValue;
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00029115 File Offset: 0x00027315
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			if (!decimal.IsValid(this._flags))
			{
				throw new SerializationException(SR.Overflow_Decimal);
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0002912F File Offset: 0x0002732F
		private Decimal(int lo, int mid, int hi, int flags)
		{
			if (decimal.IsValid(flags))
			{
				this._lo64 = (ulong)lo + ((ulong)mid << 32);
				this._hi32 = (uint)hi;
				this._flags = flags;
				return;
			}
			throw new ArgumentException(SR.Arg_DecBitCtor);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00029162 File Offset: 0x00027362
		private Decimal(in decimal d, int flags)
		{
			this = d;
			this._flags = flags;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00029177 File Offset: 0x00027377
		public byte Scale
		{
			get
			{
				return (byte)(this._flags >> 16);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00029183 File Offset: 0x00027383
		private sbyte Exponent
		{
			get
			{
				return (sbyte)(95 - this.Scale);
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0002918F File Offset: 0x0002738F
		public static decimal Add(decimal d1, decimal d2)
		{
			decimal.DecCalc.DecAddSub(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2), false);
			return d1;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x000291A8 File Offset: 0x000273A8
		public static decimal Ceiling(decimal d)
		{
			int flags = d._flags;
			if ((flags & 16711680) != 0)
			{
				decimal.DecCalc.InternalRound(decimal.AsMutable(ref d), (uint)((byte)(flags >> 16)), MidpointRounding.ToPositiveInfinity);
			}
			return d;
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x000291D8 File Offset: 0x000273D8
		public static int Compare(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2);
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x000291E4 File Offset: 0x000273E4
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is decimal))
			{
				throw new ArgumentException(SR.Arg_MustBeDecimal);
			}
			decimal num = (decimal)value;
			return decimal.DecCalc.VarDecCmp(this, num);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00029218 File Offset: 0x00027418
		public int CompareTo(decimal value)
		{
			return decimal.DecCalc.VarDecCmp(this, value);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00029222 File Offset: 0x00027422
		public static decimal Divide(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecDiv(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00029238 File Offset: 0x00027438
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			if (value is decimal)
			{
				decimal num = (decimal)value;
				return decimal.DecCalc.VarDecCmp(this, num) == 0;
			}
			return false;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00029261 File Offset: 0x00027461
		public bool Equals(decimal value)
		{
			return decimal.DecCalc.VarDecCmp(this, value) == 0;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0002926E File Offset: 0x0002746E
		public override int GetHashCode()
		{
			return decimal.DecCalc.GetHashCode(this);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00029276 File Offset: 0x00027476
		public static bool Equals(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) == 0;
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00029284 File Offset: 0x00027484
		public static decimal Floor(decimal d)
		{
			int flags = d._flags;
			if ((flags & 16711680) != 0)
			{
				decimal.DecCalc.InternalRound(decimal.AsMutable(ref d), (uint)((byte)(flags >> 16)), MidpointRounding.ToNegativeInfinity);
			}
			return d;
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x000292B4 File Offset: 0x000274B4
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.FormatDecimal(this, null, NumberFormatInfo.CurrentInfo);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000292CC File Offset: 0x000274CC
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatDecimal(this, format, NumberFormatInfo.CurrentInfo);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x000292E4 File Offset: 0x000274E4
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatDecimal(this, null, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x000292FD File Offset: 0x000274FD
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatDecimal(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00029316 File Offset: 0x00027516
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatDecimal<char>(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0002932D File Offset: 0x0002752D
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatDecimal<byte>(this, format, NumberFormatInfo.GetInstance(provider), utf8Destination, out bytesWritten);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00029344 File Offset: 0x00027544
		[NullableContext(1)]
		public static decimal Parse(string s)
		{
			return decimal.Parse(s, NumberStyles.Number, null);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0002934F File Offset: 0x0002754F
		[NullableContext(1)]
		public static decimal Parse(string s, NumberStyles style)
		{
			return decimal.Parse(s, style, null);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00029359 File Offset: 0x00027559
		[NullableContext(1)]
		public static decimal Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return decimal.Parse(s, NumberStyles.Number, provider);
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00029364 File Offset: 0x00027564
		[NullableContext(1)]
		public static decimal Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return decimal.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0002937D File Offset: 0x0002757D
		public static decimal Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Number, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.ParseDecimal<char>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00029392 File Offset: 0x00027592
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out decimal result)
		{
			return decimal.TryParse(s, NumberStyles.Number, null, out result);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x0002939E File Offset: 0x0002759E
		public static bool TryParse(ReadOnlySpan<char> s, out decimal result)
		{
			return decimal.TryParse(s, NumberStyles.Number, null, out result);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000293AA File Offset: 0x000275AA
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out decimal result)
		{
			return decimal.TryParse(utf8Text, NumberStyles.Number, null, out result);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000293B6 File Offset: 0x000275B6
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out decimal result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				result = 0m;
				return false;
			}
			return Number.TryParseDecimal<char>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000293E0 File Offset: 0x000275E0
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out decimal result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.TryParseDecimal<char>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000293F9 File Offset: 0x000275F9
		[NullableContext(1)]
		public static int[] GetBits(decimal d)
		{
			return new int[]
			{
				(int)d.Low,
				(int)d.Mid,
				(int)d.High,
				d._flags
			};
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00029428 File Offset: 0x00027628
		public unsafe static int GetBits(decimal d, Span<int> destination)
		{
			if (destination.Length <= 3)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			*destination[0] = (int)d.Low;
			*destination[1] = (int)d.Mid;
			*destination[2] = (int)d.High;
			*destination[3] = d._flags;
			return 4;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00029484 File Offset: 0x00027684
		public unsafe static bool TryGetBits(decimal d, Span<int> destination, out int valuesWritten)
		{
			if (destination.Length <= 3)
			{
				valuesWritten = 0;
				return false;
			}
			*destination[0] = (int)d.Low;
			*destination[1] = (int)d.Mid;
			*destination[2] = (int)d.High;
			*destination[3] = d._flags;
			valuesWritten = 4;
			return true;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000294E4 File Offset: 0x000276E4
		internal static void GetBytes(in decimal d, Span<byte> buffer)
		{
			BinaryPrimitives.WriteInt32LittleEndian(buffer, (int)d.Low);
			BinaryPrimitives.WriteInt32LittleEndian(buffer.Slice(4), (int)d.Mid);
			BinaryPrimitives.WriteInt32LittleEndian(buffer.Slice(8), (int)d.High);
			BinaryPrimitives.WriteInt32LittleEndian(buffer.Slice(12), d._flags);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00029538 File Offset: 0x00027738
		internal static decimal ToDecimal(ReadOnlySpan<byte> span)
		{
			int lo = BinaryPrimitives.ReadInt32LittleEndian(span);
			int mid = BinaryPrimitives.ReadInt32LittleEndian(span.Slice(4));
			int hi = BinaryPrimitives.ReadInt32LittleEndian(span.Slice(8));
			int flags = BinaryPrimitives.ReadInt32LittleEndian(span.Slice(12));
			return new decimal(lo, mid, hi, flags);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0002957E File Offset: 0x0002777E
		public static decimal Remainder(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecMod(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00029594 File Offset: 0x00027794
		public static decimal Multiply(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecMul(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000295AA File Offset: 0x000277AA
		public static decimal Negate(decimal d)
		{
			return new decimal(ref d, d._flags ^ int.MinValue);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x000295BF File Offset: 0x000277BF
		public static decimal Round(decimal d)
		{
			return decimal.Round(ref d, 0, MidpointRounding.ToEven);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000295CA File Offset: 0x000277CA
		public static decimal Round(decimal d, int decimals)
		{
			return decimal.Round(ref d, decimals, MidpointRounding.ToEven);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000295D5 File Offset: 0x000277D5
		public static decimal Round(decimal d, MidpointRounding mode)
		{
			return decimal.Round(ref d, 0, mode);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000295E0 File Offset: 0x000277E0
		public static decimal Round(decimal d, int decimals, MidpointRounding mode)
		{
			return decimal.Round(ref d, decimals, mode);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000295EC File Offset: 0x000277EC
		private static decimal Round(ref decimal d, int decimals, MidpointRounding mode)
		{
			if (decimals > 28)
			{
				throw new ArgumentOutOfRangeException("decimals", SR.ArgumentOutOfRange_DecimalRound);
			}
			if (mode > MidpointRounding.ToPositiveInfinity)
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidEnumValue, mode, "MidpointRounding"), "mode");
			}
			int num = (int)d.Scale - decimals;
			if (num > 0)
			{
				decimal.DecCalc.InternalRound(decimal.AsMutable(ref d), (uint)num, mode);
			}
			return d;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00029652 File Offset: 0x00027852
		public static decimal Subtract(decimal d1, decimal d2)
		{
			decimal.DecCalc.DecAddSub(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2), true);
			return d1;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0002966C File Offset: 0x0002786C
		public static byte ToByte(decimal value)
		{
			uint num;
			try
			{
				num = decimal.ToUInt32(value);
			}
			catch (OverflowException)
			{
				Number.ThrowOverflowException<byte>();
				throw;
			}
			if (num != (uint)((byte)num))
			{
				Number.ThrowOverflowException<byte>();
			}
			return (byte)num;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000296A8 File Offset: 0x000278A8
		[CLSCompliant(false)]
		public static sbyte ToSByte(decimal value)
		{
			int num;
			try
			{
				num = decimal.ToInt32(value);
			}
			catch (OverflowException)
			{
				Number.ThrowOverflowException<sbyte>();
				throw;
			}
			if (num != (int)((sbyte)num))
			{
				Number.ThrowOverflowException<sbyte>();
			}
			return (sbyte)num;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x000296E4 File Offset: 0x000278E4
		public static short ToInt16(decimal value)
		{
			int num;
			try
			{
				num = decimal.ToInt32(value);
			}
			catch (OverflowException)
			{
				Number.ThrowOverflowException<short>();
				throw;
			}
			if (num != (int)((short)num))
			{
				Number.ThrowOverflowException<short>();
			}
			return (short)num;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00029720 File Offset: 0x00027920
		public static double ToDouble(decimal d)
		{
			return decimal.DecCalc.VarR8FromDec(d);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0002972C File Offset: 0x0002792C
		public static int ToInt32(decimal d)
		{
			decimal.Truncate(ref d);
			if ((d.High | d.Mid) == 0U)
			{
				int num = (int)d.Low;
				if (!decimal.IsNegative(d))
				{
					if (num >= 0)
					{
						return num;
					}
				}
				else
				{
					num = -num;
					if (num <= 0)
					{
						return num;
					}
				}
			}
			throw new OverflowException(SR.Overflow_Int32);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0002977C File Offset: 0x0002797C
		public static long ToInt64(decimal d)
		{
			decimal.Truncate(ref d);
			if (d.High == 0U)
			{
				long num = (long)d.Low64;
				if (!decimal.IsNegative(d))
				{
					if (num >= 0L)
					{
						return num;
					}
				}
				else
				{
					num = -num;
					if (num <= 0L)
					{
						return num;
					}
				}
			}
			throw new OverflowException(SR.Overflow_Int64);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000297C4 File Offset: 0x000279C4
		[CLSCompliant(false)]
		public static ushort ToUInt16(decimal value)
		{
			uint num;
			try
			{
				num = decimal.ToUInt32(value);
			}
			catch (OverflowException)
			{
				Number.ThrowOverflowException<ushort>();
				throw;
			}
			if (num != (uint)((ushort)num))
			{
				Number.ThrowOverflowException<ushort>();
			}
			return (ushort)num;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00029800 File Offset: 0x00027A00
		[CLSCompliant(false)]
		public static uint ToUInt32(decimal d)
		{
			decimal.Truncate(ref d);
			if ((d.High | d.Mid) == 0U)
			{
				uint low = d.Low;
				if (!decimal.IsNegative(d) || low == 0U)
				{
					return low;
				}
			}
			throw new OverflowException(SR.Overflow_UInt32);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00029844 File Offset: 0x00027A44
		[CLSCompliant(false)]
		public static ulong ToUInt64(decimal d)
		{
			decimal.Truncate(ref d);
			if (d.High == 0U)
			{
				ulong low = d.Low64;
				if (!decimal.IsNegative(d) || low == 0UL)
				{
					return low;
				}
			}
			throw new OverflowException(SR.Overflow_UInt64);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00029880 File Offset: 0x00027A80
		public static float ToSingle(decimal d)
		{
			return decimal.DecCalc.VarR4FromDec(d);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00029889 File Offset: 0x00027A89
		public static decimal Truncate(decimal d)
		{
			decimal.Truncate(ref d);
			return d;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00029894 File Offset: 0x00027A94
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Truncate(ref decimal d)
		{
			int flags = d._flags;
			if ((flags & 16711680) != 0)
			{
				decimal.DecCalc.InternalRound(decimal.AsMutable(ref d), (uint)((byte)(flags >> 16)), MidpointRounding.ToZero);
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000298C2 File Offset: 0x00027AC2
		public static implicit operator decimal(byte value)
		{
			return new decimal((uint)value);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x000298CA File Offset: 0x00027ACA
		[CLSCompliant(false)]
		public static implicit operator decimal(sbyte value)
		{
			return new decimal((int)value);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x000298CA File Offset: 0x00027ACA
		public static implicit operator decimal(short value)
		{
			return new decimal((int)value);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000298C2 File Offset: 0x00027AC2
		[CLSCompliant(false)]
		public static implicit operator decimal(ushort value)
		{
			return new decimal((uint)value);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x000298C2 File Offset: 0x00027AC2
		public static implicit operator decimal(char value)
		{
			return new decimal((uint)value);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000298CA File Offset: 0x00027ACA
		public static implicit operator decimal(int value)
		{
			return new decimal(value);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000298C2 File Offset: 0x00027AC2
		[CLSCompliant(false)]
		public static implicit operator decimal(uint value)
		{
			return new decimal(value);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x000298D2 File Offset: 0x00027AD2
		public static implicit operator decimal(long value)
		{
			return new decimal(value);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x000298DA File Offset: 0x00027ADA
		[CLSCompliant(false)]
		public static implicit operator decimal(ulong value)
		{
			return new decimal(value);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x000298E2 File Offset: 0x00027AE2
		public static explicit operator decimal(float value)
		{
			return new decimal(value);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000298EA File Offset: 0x00027AEA
		public static explicit operator decimal(double value)
		{
			return new decimal(value);
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000298F2 File Offset: 0x00027AF2
		public static explicit operator byte(decimal value)
		{
			return decimal.ToByte(value);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000298FA File Offset: 0x00027AFA
		[CLSCompliant(false)]
		public static explicit operator sbyte(decimal value)
		{
			return decimal.ToSByte(value);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00029904 File Offset: 0x00027B04
		public static explicit operator char(decimal value)
		{
			ushort result;
			try
			{
				result = decimal.ToUInt16(value);
			}
			catch (OverflowException innerException)
			{
				throw new OverflowException(SR.Overflow_Char, innerException);
			}
			return (char)result;
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00029938 File Offset: 0x00027B38
		public static explicit operator short(decimal value)
		{
			return decimal.ToInt16(value);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00029940 File Offset: 0x00027B40
		[CLSCompliant(false)]
		public static explicit operator ushort(decimal value)
		{
			return decimal.ToUInt16(value);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00029948 File Offset: 0x00027B48
		public static explicit operator int(decimal value)
		{
			return decimal.ToInt32(value);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00029950 File Offset: 0x00027B50
		[CLSCompliant(false)]
		public static explicit operator uint(decimal value)
		{
			return decimal.ToUInt32(value);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00029958 File Offset: 0x00027B58
		public static explicit operator long(decimal value)
		{
			return decimal.ToInt64(value);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00029960 File Offset: 0x00027B60
		[CLSCompliant(false)]
		public static explicit operator ulong(decimal value)
		{
			return decimal.ToUInt64(value);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00029880 File Offset: 0x00027A80
		public static explicit operator float(decimal value)
		{
			return decimal.DecCalc.VarR4FromDec(value);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00029720 File Offset: 0x00027920
		public static explicit operator double(decimal value)
		{
			return decimal.DecCalc.VarR8FromDec(value);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00007B62 File Offset: 0x00005D62
		public static decimal operator +(decimal d)
		{
			return d;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x000295AA File Offset: 0x000277AA
		public static decimal operator -(decimal d)
		{
			return new decimal(ref d, d._flags ^ int.MinValue);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00029968 File Offset: 0x00027B68
		public static decimal operator ++(decimal d)
		{
			return decimal.Add(d, 1m);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00029975 File Offset: 0x00027B75
		public static decimal operator --(decimal d)
		{
			return decimal.Subtract(d, 1m);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0002918F File Offset: 0x0002738F
		public static decimal operator +(decimal d1, decimal d2)
		{
			decimal.DecCalc.DecAddSub(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2), false);
			return d1;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00029652 File Offset: 0x00027852
		public static decimal operator -(decimal d1, decimal d2)
		{
			decimal.DecCalc.DecAddSub(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2), true);
			return d1;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00029594 File Offset: 0x00027794
		public static decimal operator *(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecMul(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00029222 File Offset: 0x00027422
		public static decimal operator /(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecDiv(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0002957E File Offset: 0x0002777E
		public static decimal operator %(decimal d1, decimal d2)
		{
			decimal.DecCalc.VarDecMod(decimal.AsMutable(ref d1), decimal.AsMutable(ref d2));
			return d1;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00029276 File Offset: 0x00027476
		public static bool operator ==(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) == 0;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00029982 File Offset: 0x00027B82
		public static bool operator !=(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) != 0;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00029990 File Offset: 0x00027B90
		public static bool operator <(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) < 0;
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0002999E File Offset: 0x00027B9E
		public static bool operator <=(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) <= 0;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000299AF File Offset: 0x00027BAF
		public static bool operator >(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) > 0;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000299BD File Offset: 0x00027BBD
		public static bool operator >=(decimal d1, decimal d2)
		{
			return decimal.DecCalc.VarDecCmp(d1, d2) >= 0;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000299CE File Offset: 0x00027BCE
		public TypeCode GetTypeCode()
		{
			return TypeCode.Decimal;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000299D2 File Offset: 0x00027BD2
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000299DF File Offset: 0x00027BDF
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Decimal", "Char"));
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000299FA File Offset: 0x00027BFA
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00029A07 File Offset: 0x00027C07
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00029A14 File Offset: 0x00027C14
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00029A21 File Offset: 0x00027C21
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00029A2E File Offset: 0x00027C2E
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00029A3B File Offset: 0x00027C3B
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00029A48 File Offset: 0x00027C48
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00029A55 File Offset: 0x00027C55
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00029A62 File Offset: 0x00027C62
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return decimal.DecCalc.VarR4FromDec(this);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00029A6A File Offset: 0x00027C6A
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return decimal.DecCalc.VarR8FromDec(this);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00029A72 File Offset: 0x00027C72
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00029A7A File Offset: 0x00027C7A
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Decimal", "DateTime"));
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00029A95 File Offset: 0x00027C95
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00029AA9 File Offset: 0x00027CA9
		decimal IAdditiveIdentity<decimal, decimal>.AdditiveIdentity
		{
			get
			{
				return 0m;
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00029AB0 File Offset: 0x00027CB0
		[NullableContext(1)]
		public static TInteger ConvertToInteger<[Nullable(0)] TInteger>(decimal value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<decimal>(value);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00029AB0 File Offset: 0x00027CB0
		[NullableContext(1)]
		public static TInteger ConvertToIntegerNative<[Nullable(0)] TInteger>(decimal value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<decimal>(value);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000070DD File Offset: 0x000052DD
		int IFloatingPoint<decimal>.GetExponentByteCount()
		{
			return 1;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00029AC0 File Offset: 0x00027CC0
		int IFloatingPoint<decimal>.GetExponentShortestBitLength()
		{
			sbyte exponent = this.Exponent;
			return (int)(8 - sbyte.LeadingZeroCount(exponent));
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00029ADC File Offset: 0x00027CDC
		int IFloatingPoint<decimal>.GetSignificandByteCount()
		{
			return 12;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00029AE0 File Offset: 0x00027CE0
		int IFloatingPoint<decimal>.GetSignificandBitLength()
		{
			return 96;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00029AE4 File Offset: 0x00027CE4
		bool IFloatingPoint<decimal>.TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 1)
			{
				sbyte exponent = this.Exponent;
				Unsafe.WriteUnaligned<sbyte>(MemoryMarshal.GetReference<byte>(destination), exponent);
				bytesWritten = 1;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00029B18 File Offset: 0x00027D18
		bool IFloatingPoint<decimal>.TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 1)
			{
				sbyte exponent = this.Exponent;
				Unsafe.WriteUnaligned<sbyte>(MemoryMarshal.GetReference<byte>(destination), exponent);
				bytesWritten = 1;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00029B4C File Offset: 0x00027D4C
		bool IFloatingPoint<decimal>.TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 12)
			{
				uint value = this._hi32;
				ulong value2 = this._lo64;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				value2 = BinaryPrimitives.ReverseEndianness(value2);
				ref byte reference = ref MemoryMarshal.GetReference<byte>(destination);
				Unsafe.WriteUnaligned<uint>(ref reference, value);
				Unsafe.WriteUnaligned<ulong>(Unsafe.AddByteOffset<byte>(ref reference, (IntPtr)4), value2);
				bytesWritten = 12;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00029BAC File Offset: 0x00027DAC
		bool IFloatingPoint<decimal>.TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 12)
			{
				ulong lo = this._lo64;
				uint hi = this._hi32;
				if (!BitConverter.IsLittleEndian)
				{
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(destination);
				Unsafe.WriteUnaligned<ulong>(ref reference, lo);
				Unsafe.WriteUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref reference, (IntPtr)8), hi);
				bytesWritten = 12;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00029BFD File Offset: 0x00027DFD
		decimal IFloatingPointConstants<decimal>.E
		{
			get
			{
				return 2.7182818284590452353602874714m;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00029C16 File Offset: 0x00027E16
		decimal IFloatingPointConstants<decimal>.Pi
		{
			get
			{
				return 3.1415926535897932384626433833m;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00029C2F File Offset: 0x00027E2F
		decimal IFloatingPointConstants<decimal>.Tau
		{
			get
			{
				return 6.2831853071795864769252867666m;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00029C48 File Offset: 0x00027E48
		decimal IMinMaxValue<decimal>.MinValue
		{
			get
			{
				return -79228162514264337593543950335m;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x00029C54 File Offset: 0x00027E54
		decimal IMinMaxValue<decimal>.MaxValue
		{
			get
			{
				return 79228162514264337593543950335m;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00029C60 File Offset: 0x00027E60
		decimal IMultiplicativeIdentity<decimal, decimal>.MultiplicativeIdentity
		{
			get
			{
				return 1m;
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00029C67 File Offset: 0x00027E67
		public static decimal Clamp(decimal value, decimal min, decimal max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00029C71 File Offset: 0x00027E71
		public static decimal CopySign(decimal value, decimal sign)
		{
			return new decimal(ref value, (value._flags & int.MaxValue) | (sign._flags & int.MinValue));
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00029C93 File Offset: 0x00027E93
		public static decimal Max(decimal x, decimal y)
		{
			if (decimal.DecCalc.VarDecCmp(x, y) < 0)
			{
				return y;
			}
			return x;
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x000105EB File Offset: 0x0000E7EB
		decimal INumber<decimal>.MaxNumber(decimal x, decimal y)
		{
			return decimal.Max(x, y);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00029CA4 File Offset: 0x00027EA4
		public static decimal Min(decimal x, decimal y)
		{
			if (decimal.DecCalc.VarDecCmp(x, y) >= 0)
			{
				return y;
			}
			return x;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00010687 File Offset: 0x0000E887
		decimal INumber<decimal>.MinNumber(decimal x, decimal y)
		{
			return decimal.Min(x, y);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00029CB5 File Offset: 0x00027EB5
		public static int Sign(decimal d)
		{
			if ((d.Low64 | (ulong)d.High) != 0UL)
			{
				return d._flags >> 31 | 1;
			}
			return 0;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00029C60 File Offset: 0x00027E60
		decimal INumberBase<decimal>.One
		{
			get
			{
				return 1m;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00029CD6 File Offset: 0x00027ED6
		int INumberBase<decimal>.Radix
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00029AA9 File Offset: 0x00027CA9
		decimal INumberBase<decimal>.Zero
		{
			get
			{
				return 0m;
			}
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00029CDA File Offset: 0x00027EDA
		public static decimal Abs(decimal value)
		{
			return new decimal(ref value, value._flags & int.MaxValue);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00029CF0 File Offset: 0x00027EF0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			decimal result;
			if (typeof(TOther) == typeof(decimal))
			{
				result = (decimal)((object)value);
			}
			else if (!decimal.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<decimal>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00029D48 File Offset: 0x00027F48
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			decimal result;
			if (typeof(TOther) == typeof(decimal))
			{
				result = (decimal)((object)value);
			}
			else if (!decimal.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<decimal>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00029DA0 File Offset: 0x00027FA0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			decimal result;
			if (typeof(TOther) == typeof(decimal))
			{
				result = (decimal)((object)value);
			}
			else if (!decimal.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<decimal>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00029DF8 File Offset: 0x00027FF8
		public static bool IsCanonical(decimal value)
		{
			if ((byte)(value._flags >> 16) == 0)
			{
				return true;
			}
			if (value._hi32 == 0U)
			{
				return value._lo64 % 10UL > 0UL;
			}
			return new UInt128((ulong)value._hi32, value._lo64) % 10U != 0U;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<decimal>.IsComplexNumber(decimal value)
		{
			return false;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00029E54 File Offset: 0x00028054
		public static bool IsEvenInteger(decimal value)
		{
			decimal num = decimal.Truncate(value);
			return value == num && (num._lo64 & 1UL) == 0UL;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<decimal>.IsFinite(decimal value)
		{
			return true;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<decimal>.IsImaginaryNumber(decimal value)
		{
			return false;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<decimal>.IsInfinity(decimal value)
		{
			return false;
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00029E80 File Offset: 0x00028080
		public static bool IsInteger(decimal value)
		{
			return value == decimal.Truncate(value);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<decimal>.IsNaN(decimal value)
		{
			return false;
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00029E8E File Offset: 0x0002808E
		public static bool IsNegative(decimal value)
		{
			return value._flags < 0;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<decimal>.IsNegativeInfinity(decimal value)
		{
			return false;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000231D3 File Offset: 0x000213D3
		bool INumberBase<decimal>.IsNormal(decimal value)
		{
			return value != 0m;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00029E9C File Offset: 0x0002809C
		public static bool IsOddInteger(decimal value)
		{
			decimal num = decimal.Truncate(value);
			return value == num && (num._lo64 & 1UL) > 0UL;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00029EC8 File Offset: 0x000280C8
		public static bool IsPositive(decimal value)
		{
			return value._flags >= 0;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<decimal>.IsPositiveInfinity(decimal value)
		{
			return false;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<decimal>.IsRealNumber(decimal value)
		{
			return true;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<decimal>.IsSubnormal(decimal value)
		{
			return false;
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00029ED6 File Offset: 0x000280D6
		bool INumberBase<decimal>.IsZero(decimal value)
		{
			return value == 0m;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00029EE4 File Offset: 0x000280E4
		public static decimal MaxMagnitude(decimal x, decimal y)
		{
			decimal d = decimal.Abs(x);
			decimal d2 = decimal.Abs(y);
			if (d > d2)
			{
				return x;
			}
			if (!(d == d2))
			{
				return y;
			}
			if (!decimal.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00029F20 File Offset: 0x00028120
		decimal INumberBase<decimal>.MaxMagnitudeNumber(decimal x, decimal y)
		{
			return decimal.MaxMagnitude(x, y);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00029F2C File Offset: 0x0002812C
		public static decimal MinMagnitude(decimal x, decimal y)
		{
			decimal d = decimal.Abs(x);
			decimal d2 = decimal.Abs(y);
			if (d < d2)
			{
				return x;
			}
			if (!(d == d2))
			{
				return y;
			}
			if (!decimal.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00029F68 File Offset: 0x00028168
		decimal INumberBase<decimal>.MinMagnitudeNumber(decimal x, decimal y)
		{
			return decimal.MinMagnitude(x, y);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00029F71 File Offset: 0x00028171
		decimal INumberBase<decimal>.MultiplyAddEstimate(decimal left, decimal right, decimal addend)
		{
			return left * right + addend;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00029F80 File Offset: 0x00028180
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<decimal>.TryConvertFromChecked<TOther>(TOther value, out decimal result) where TOther : INumberBase<TOther>
		{
			return decimal.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00029F8C File Offset: 0x0002818C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out decimal result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte value2 = (byte)((object)value);
				result = value2;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char value3 = (char)((object)value);
				result = value3;
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort value4 = (ushort)((object)value);
				result = value4;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint value5 = (uint)((object)value);
				result = value5;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong value6 = (ulong)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value7 = (UInt128)((object)value);
				result = (decimal)value7;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = (ulong)uintPtr;
				return true;
			}
			result = 0m;
			return false;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0002A11B File Offset: 0x0002831B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<decimal>.TryConvertFromSaturating<TOther>(TOther value, out decimal result) where TOther : INumberBase<TOther>
		{
			return decimal.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0002A11B File Offset: 0x0002831B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<decimal>.TryConvertFromTruncating<TOther>(TOther value, out decimal result) where TOther : INumberBase<TOther>
		{
			return decimal.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0002A124 File Offset: 0x00028324
		private static bool TryConvertFrom<TOther>(TOther value, out decimal result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte value2 = (byte)((object)value);
				result = value2;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char value3 = (char)((object)value);
				result = value3;
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort value4 = (ushort)((object)value);
				result = value4;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint value5 = (uint)((object)value);
				result = value5;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong value6 = (ulong)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)((object)value);
				result = ((@uint >= new UInt128((ulong)-1, ulong.MaxValue)) ? 79228162514264337593543950335m : ((decimal)@uint));
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = (ulong)uintPtr;
				return true;
			}
			result = 0m;
			return false;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0002A2D4 File Offset: 0x000284D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<decimal>.TryConvertToChecked<TOther>(decimal value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
				Int128 @int = (Int128)value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = checked((IntPtr)((long)value));
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
				float num5 = (float)value;
				result = (TOther)((object)num5);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0002A4D3 File Offset: 0x000286D3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<decimal>.TryConvertToSaturating<TOther>(decimal value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return decimal.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0002A4D3 File Offset: 0x000286D3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<decimal>.TryConvertToTruncating<TOther>(decimal value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return decimal.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0002A4DC File Offset: 0x000286DC
		private static bool TryConvertTo<TOther>(decimal value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
				short num2 = (value >= 32767m) ? short.MaxValue : ((value <= -32768m) ? short.MinValue : ((short)value));
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (value >= 2147483647m) ? int.MaxValue : ((value <= -2147483648m) ? int.MinValue : ((int)value));
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (value >= 9223372036854775807m) ? long.MaxValue : ((value <= -9223372036854775808m) ? long.MinValue : ((long)value));
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (Int128)value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (value >= (long)IntPtr.MaxValue) ? IntPtr.MaxValue : ((value <= (long)IntPtr.MinValue) ? IntPtr.MinValue : ((IntPtr)((long)value)));
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (value >= 127m) ? sbyte.MaxValue : ((value <= -128m) ? sbyte.MinValue : ((sbyte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)value;
				result = (TOther)((object)num5);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0002A7DB File Offset: 0x000289DB
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out decimal result)
		{
			return decimal.TryParse(s, NumberStyles.Number, provider, out result);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0002A7E7 File Offset: 0x000289E7
		decimal ISignedNumber<decimal>.NegativeOne
		{
			get
			{
				return -1m;
			}
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0002A7EE File Offset: 0x000289EE
		public static decimal Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return decimal.Parse(s, NumberStyles.Number, provider);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0002A7F9 File Offset: 0x000289F9
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out decimal result)
		{
			return decimal.TryParse(s, NumberStyles.Number, provider, out result);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0002A805 File Offset: 0x00028A05
		public static decimal Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Number, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseDecimal<byte>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0002A81A File Offset: 0x00028A1A
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out decimal result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseDecimal<byte>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0002A833 File Offset: 0x00028A33
		public static decimal Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return decimal.Parse(utf8Text, NumberStyles.Number, provider);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0002A83E File Offset: 0x00028A3E
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out decimal result)
		{
			return decimal.TryParse(utf8Text, NumberStyles.Number, provider, out result);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0002A84A File Offset: 0x00028A4A
		internal uint High
		{
			get
			{
				return this._hi32;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0002A852 File Offset: 0x00028A52
		internal uint Low
		{
			get
			{
				return (uint)this._lo64;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0002A85B File Offset: 0x00028A5B
		internal uint Mid
		{
			get
			{
				return (uint)(this._lo64 >> 32);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0002A867 File Offset: 0x00028A67
		internal ulong Low64
		{
			get
			{
				return this._lo64;
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0002A86F File Offset: 0x00028A6F
		private static ref decimal.DecCalc AsMutable(ref decimal d)
		{
			return Unsafe.As<decimal, decimal.DecCalc>(ref d);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0002A877 File Offset: 0x00028A77
		internal static uint DecDivMod1E9(ref decimal value)
		{
			return decimal.DecCalc.DecDivMod1E9(decimal.AsMutable(ref value));
		}

		// Token: 0x04000358 RID: 856
		public const decimal Zero = 0m;

		// Token: 0x04000359 RID: 857
		public const decimal One = 1m;

		// Token: 0x0400035A RID: 858
		public const decimal MinusOne = -1m;

		// Token: 0x0400035B RID: 859
		public const decimal MaxValue = 79228162514264337593543950335m;

		// Token: 0x0400035C RID: 860
		public const decimal MinValue = -79228162514264337593543950335m;

		// Token: 0x0400035D RID: 861
		private const decimal AdditiveIdentity = 0m;

		// Token: 0x0400035E RID: 862
		private const decimal MultiplicativeIdentity = 1m;

		// Token: 0x0400035F RID: 863
		private const decimal NegativeOne = -1m;

		// Token: 0x04000360 RID: 864
		private readonly int _flags;

		// Token: 0x04000361 RID: 865
		private readonly uint _hi32;

		// Token: 0x04000362 RID: 866
		private readonly ulong _lo64;

		// Token: 0x020000F6 RID: 246
		[StructLayout(LayoutKind.Explicit)]
		private struct DecCalc
		{
			// Token: 0x1700017E RID: 382
			// (get) Token: 0x06000FEB RID: 4075 RVA: 0x0002A8F1 File Offset: 0x00028AF1
			// (set) Token: 0x06000FEC RID: 4076 RVA: 0x0002A8F9 File Offset: 0x00028AF9
			private uint High
			{
				get
				{
					return this.uhi;
				}
				set
				{
					this.uhi = value;
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06000FED RID: 4077 RVA: 0x0002A902 File Offset: 0x00028B02
			// (set) Token: 0x06000FEE RID: 4078 RVA: 0x0002A90A File Offset: 0x00028B0A
			private uint Low
			{
				get
				{
					return this.ulo;
				}
				set
				{
					this.ulo = value;
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0002A913 File Offset: 0x00028B13
			// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x0002A91B File Offset: 0x00028B1B
			private uint Mid
			{
				get
				{
					return this.umid;
				}
				set
				{
					this.umid = value;
				}
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0002A924 File Offset: 0x00028B24
			private bool IsNegative
			{
				get
				{
					return this.uflags < 0U;
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0002A92F File Offset: 0x00028B2F
			private int Scale
			{
				get
				{
					return (int)((byte)(this.uflags >> 16));
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0002A93B File Offset: 0x00028B3B
			// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0002A943 File Offset: 0x00028B43
			private ulong Low64
			{
				get
				{
					return this.ulomid;
				}
				set
				{
					this.ulomid = value;
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x0002A94C File Offset: 0x00028B4C
			private static ReadOnlySpan<uint> UInt32Powers10
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.A516EECB41051151F0183A8B0B6F6693C43F7D9E1815F85CAAAB18E00A5269A24).FieldHandle);
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0002A958 File Offset: 0x00028B58
			private static ReadOnlySpan<ulong> UInt64Powers10
			{
				get
				{
					return RuntimeHelpers.CreateSpan<ulong>(fieldof(<PrivateImplementationDetails>.DD471F12FFA94CC557A02A91C2CBB95F551AB28C8BBF297B2F953B8886BCCF6D8).FieldHandle);
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x0002A964 File Offset: 0x00028B64
			private static ReadOnlySpan<double> DoublePowers10
			{
				get
				{
					return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.67856A16DB0550FDAB4D1A9B208B0C155C4679CA116BF867B74ED2A0AA4D29558).FieldHandle);
				}
			}

			// Token: 0x06000FF8 RID: 4088 RVA: 0x0002A970 File Offset: 0x00028B70
			private static uint GetExponent(float f)
			{
				return (uint)((byte)(BitConverter.SingleToUInt32Bits(f) >> 23));
			}

			// Token: 0x06000FF9 RID: 4089 RVA: 0x0002A97C File Offset: 0x00028B7C
			private static uint GetExponent(double d)
			{
				return (uint)(BitConverter.DoubleToUInt64Bits(d) >> 52) & 2047U;
			}

			// Token: 0x06000FFA RID: 4090 RVA: 0x0002A990 File Offset: 0x00028B90
			private static void UInt64x64To128(ulong a, ulong b, ref decimal.DecCalc result)
			{
				ulong low;
				ulong num = Math.BigMul(a, b, out low);
				if (num > (ulong)-1)
				{
					Number.ThrowOverflowException(SR.Overflow_Decimal);
				}
				result.Low64 = low;
				result.High = (uint)num;
			}

			// Token: 0x06000FFB RID: 4091 RVA: 0x0002A9C8 File Offset: 0x00028BC8
			private static uint Div96By32(ref decimal.DecCalc.Buf12 bufNum, uint den)
			{
				if (bufNum.U2 != 0U)
				{
					ulong num = bufNum.High64;
					ulong num2 = num / (ulong)den;
					bufNum.High64 = num2;
					num = (num - (ulong)((uint)num2 * den) << 32 | (ulong)bufNum.U0);
					if (num == 0UL)
					{
						return 0U;
					}
					uint num3 = (uint)(num / (ulong)den);
					bufNum.U0 = num3;
					return (uint)num - num3 * den;
				}
				else
				{
					ulong num = bufNum.Low64;
					if (num == 0UL)
					{
						return 0U;
					}
					ulong num2 = num / (ulong)den;
					bufNum.Low64 = num2;
					return (uint)(num - num2 * (ulong)den);
				}
			}

			// Token: 0x06000FFC RID: 4092 RVA: 0x0002AA3C File Offset: 0x00028C3C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
			{
				ulong num = high64 / (ulong)pow;
				uint num2 = (uint)(((high64 - num * (ulong)pow << 32) + (ulong)low) / (ulong)pow);
				if (low == num2 * pow)
				{
					high64 = num;
					low = num2;
					return true;
				}
				return false;
			}

			// Token: 0x06000FFD RID: 4093 RVA: 0x0002AA74 File Offset: 0x00028C74
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static void Unscale(ref uint low, ref ulong high64, ref int scale)
			{
				while ((byte)low == 0 && scale >= 8 && decimal.DecCalc.Div96ByConst(ref high64, ref low, 100000000U))
				{
					scale -= 8;
				}
				if ((low & 15U) == 0U && scale >= 4 && decimal.DecCalc.Div96ByConst(ref high64, ref low, 10000U))
				{
					scale -= 4;
				}
				if ((low & 3U) == 0U && scale >= 2 && decimal.DecCalc.Div96ByConst(ref high64, ref low, 100U))
				{
					scale -= 2;
				}
				if ((low & 1U) == 0U && scale >= 1 && decimal.DecCalc.Div96ByConst(ref high64, ref low, 10U))
				{
					scale--;
				}
			}

			// Token: 0x06000FFE RID: 4094 RVA: 0x0002AAFC File Offset: 0x00028CFC
			private static uint Div96By64(ref decimal.DecCalc.Buf12 bufNum, ulong den)
			{
				uint u = bufNum.U2;
				if (u == 0U)
				{
					ulong num = bufNum.Low64;
					if (num < den)
					{
						return 0U;
					}
					ref decimal.DecCalc.Buf12 ptr = ref bufNum;
					ValueTuple<ulong, ulong> valueTuple = Math.DivRem(num, den);
					uint item = (uint)valueTuple.Item1;
					ptr.Low64 = valueTuple.Item2;
					return item;
				}
				else
				{
					uint num2 = (uint)(den >> 32);
					ulong num;
					uint num3;
					if (u >= num2)
					{
						num = bufNum.Low64;
						num -= den << 32;
						num3 = 0U;
						do
						{
							num3 -= 1U;
							num += den;
						}
						while (num >= den);
						bufNum.Low64 = num;
						return num3;
					}
					ulong high = bufNum.High64;
					if (high < (ulong)num2)
					{
						return 0U;
					}
					num3 = (uint)(high / (ulong)num2);
					num = ((ulong)bufNum.U0 | high - (ulong)(num3 * num2) << 32);
					ulong num4 = Math.BigMul(num3, (uint)den);
					num -= num4;
					if (num > ~num4)
					{
						do
						{
							num3 -= 1U;
							num += den;
						}
						while (num >= den);
					}
					bufNum.Low64 = num;
					return num3;
				}
			}

			// Token: 0x06000FFF RID: 4095 RVA: 0x0002ABC8 File Offset: 0x00028DC8
			private static uint Div128By96(ref decimal.DecCalc.Buf16 bufNum, ref decimal.DecCalc.Buf12 bufDen)
			{
				ulong high = bufNum.High64;
				uint u = bufDen.U2;
				if (high < (ulong)u)
				{
					return 0U;
				}
				uint num = (uint)(high / (ulong)u);
				uint num2 = (uint)high - num * u;
				ulong num3 = Math.BigMul(num, bufDen.U0);
				ulong num4 = Math.BigMul(num, bufDen.U1);
				num4 += num3 >> 32;
				num3 = ((ulong)((uint)num3) | num4 << 32);
				num4 >>= 32;
				ulong num5 = bufNum.Low64;
				num5 -= num3;
				num2 -= (uint)num4;
				if (num5 > ~num3)
				{
					num2 -= 1U;
					if (num2 < ~(uint)num4)
					{
						goto IL_B4;
					}
				}
				else if (num2 <= ~(uint)num4)
				{
					goto IL_B4;
				}
				num3 = bufDen.Low64;
				do
				{
					num -= 1U;
					num5 += num3;
					num2 += u;
				}
				while ((num5 >= num3 || num2++ >= u) && num2 >= u);
				IL_B4:
				bufNum.Low64 = num5;
				bufNum.U2 = num2;
				return num;
			}

			// Token: 0x06001000 RID: 4096 RVA: 0x0002AC9C File Offset: 0x00028E9C
			private static uint IncreaseScale(ref decimal.DecCalc.Buf12 bufNum, uint power)
			{
				ulong num = Math.BigMul(bufNum.U0, power);
				bufNum.U0 = (uint)num;
				num >>= 32;
				num += Math.BigMul(bufNum.U1, power);
				bufNum.U1 = (uint)num;
				num >>= 32;
				num += Math.BigMul(bufNum.U2, power);
				bufNum.U2 = (uint)num;
				return (uint)(num >> 32);
			}

			// Token: 0x06001001 RID: 4097 RVA: 0x0002ACFC File Offset: 0x00028EFC
			private static void IncreaseScale64(ref decimal.DecCalc.Buf12 bufNum, uint power)
			{
				ulong num = Math.BigMul(bufNum.U0, power);
				bufNum.U0 = (uint)num;
				num >>= 32;
				num += Math.BigMul(bufNum.U1, power);
				bufNum.High64 = num;
			}

			// Token: 0x06001002 RID: 4098 RVA: 0x0002AD3C File Offset: 0x00028F3C
			private unsafe static int ScaleResult(decimal.DecCalc.Buf24* bufRes, uint hiRes, int scale)
			{
				int num = 0;
				if (hiRes > 2U)
				{
					num = (int)(hiRes * 32U - 64U - 1U);
					num -= BitOperations.LeadingZeroCount(*(uint*)(bufRes + (ulong)hiRes * 4UL / (ulong)sizeof(decimal.DecCalc.Buf24)));
					num = (num * 77 >> 8) + 1;
					if (num > scale)
					{
						goto IL_1CC;
					}
				}
				if (num < scale - 28)
				{
					num = scale - 28;
				}
				if (num != 0)
				{
					scale -= num;
					uint num2 = 0U;
					uint num3 = 0U;
					for (;;)
					{
						num2 |= num3;
						uint num5;
						uint num4;
						switch (num)
						{
						case 1:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 10U);
							break;
						case 2:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 100U);
							break;
						case 3:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 1000U);
							break;
						case 4:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 10000U);
							break;
						case 5:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 100000U);
							break;
						case 6:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 1000000U);
							break;
						case 7:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 10000000U);
							break;
						case 8:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 100000000U);
							break;
						default:
							num4 = decimal.DecCalc.DivByConst((uint*)bufRes, hiRes, out num5, out num3, 1000000000U);
							break;
						}
						*(int*)(bufRes + (ulong)hiRes * 4UL / (ulong)sizeof(decimal.DecCalc.Buf24)) = (int)num5;
						if (num5 == 0U && hiRes != 0U)
						{
							hiRes -= 1U;
						}
						num -= 9;
						if (num <= 0)
						{
							if (hiRes > 2U)
							{
								if (scale == 0)
								{
									goto IL_1CC;
								}
								num = 1;
								scale--;
							}
							else
							{
								num4 >>= 1;
								if (num4 > num3 || (num4 >= num3 && ((*(uint*)bufRes & 1U) | num2) == 0U))
								{
									break;
								}
								uint num6 = *(uint*)bufRes + 1U;
								*(int*)bufRes = (int)num6;
								if (num6 != 0U)
								{
									break;
								}
								uint num7 = 0U;
								do
								{
									decimal.DecCalc.Buf24* ptr = bufRes + (ulong)(num7 += 1U) * 4UL / (ulong)sizeof(decimal.DecCalc.Buf24);
									num6 = *(uint*)ptr + 1U;
									*(int*)ptr = (int)num6;
								}
								while (num6 == 0U);
								if (num7 <= 2U)
								{
									break;
								}
								if (scale == 0)
								{
									goto IL_1CC;
								}
								hiRes = num7;
								num2 = 0U;
								num3 = 0U;
								num = 1;
								scale--;
							}
						}
					}
				}
				return scale;
				IL_1CC:
				Number.ThrowOverflowException(SR.Overflow_Decimal);
				return 0;
			}

			// Token: 0x06001003 RID: 4099 RVA: 0x0002AF20 File Offset: 0x00029120
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private unsafe static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power)
			{
				ValueTuple<uint, uint> valueTuple = Math.DivRem(result[(ulong)hiRes * 4UL / 4UL], power);
				quotient = valueTuple.Item1;
				remainder = valueTuple.Item2;
				for (uint num = hiRes - 1U; num >= 0U; num -= 1U)
				{
					ulong num2 = (ulong)result[(ulong)num * 4UL / 4UL] + ((ulong)remainder << 32);
					remainder = (uint)num2 - (result[(ulong)num * 4UL / 4UL] = (uint)(num2 / (ulong)power)) * power;
				}
				return power;
			}

			// Token: 0x06001004 RID: 4100 RVA: 0x0002AF8C File Offset: 0x0002918C
			private static int OverflowUnscale(ref decimal.DecCalc.Buf12 bufQuo, int scale, bool sticky)
			{
				if (--scale < 0)
				{
					Number.ThrowOverflowException(SR.Overflow_Decimal);
				}
				bufQuo.U2 = 429496729U;
				ulong num = 25769803776UL + (ulong)bufQuo.U1;
				uint num2 = (uint)(num / 10UL);
				bufQuo.U1 = num2;
				ulong num3 = (num - (ulong)(num2 * 10U) << 32) + (ulong)bufQuo.U0;
				num2 = (uint)(num3 / 10UL);
				bufQuo.U0 = num2;
				uint num4 = (uint)(num3 - (ulong)(num2 * 10U));
				if (num4 > 5U || (num4 == 5U && (sticky || (bufQuo.U0 & 1U) != 0U)))
				{
					decimal.DecCalc.Add32To96(ref bufQuo, 1U);
				}
				return scale;
			}

			// Token: 0x06001005 RID: 4101 RVA: 0x0002B01C File Offset: 0x0002921C
			private static int SearchScale(ref decimal.DecCalc.Buf12 bufQuo, int scale)
			{
				uint u = bufQuo.U2;
				ulong low = bufQuo.Low64;
				int num = 0;
				if (u <= 429496729U)
				{
					decimal.DecCalc.PowerOvfl[] powerOvflValues = decimal.DecCalc.PowerOvflValues;
					if (scale > 19)
					{
						num = 28 - scale;
						if (u < powerOvflValues[num - 1].Hi)
						{
							goto IL_D1;
						}
					}
					else if (u < 4U || (u == 4U && low <= 5441186219426131129UL))
					{
						return 9;
					}
					if (u > 42949U)
					{
						if (u > 4294967U)
						{
							num = 2;
							if (u > 42949672U)
							{
								num--;
							}
						}
						else
						{
							num = 4;
							if (u > 429496U)
							{
								num--;
							}
						}
					}
					else if (u > 429U)
					{
						num = 6;
						if (u > 4294U)
						{
							num--;
						}
					}
					else
					{
						num = 8;
						if (u > 42U)
						{
							num--;
						}
					}
					if (u == powerOvflValues[num - 1].Hi && low > powerOvflValues[num - 1].MidLo)
					{
						num--;
					}
				}
				IL_D1:
				if (num + scale < 0)
				{
					Number.ThrowOverflowException(SR.Overflow_Decimal);
				}
				return num;
			}

			// Token: 0x06001006 RID: 4102 RVA: 0x0002B10C File Offset: 0x0002930C
			private static bool Add32To96(ref decimal.DecCalc.Buf12 bufNum, uint value)
			{
				if ((bufNum.Low64 += (ulong)value) < (ulong)value)
				{
					uint num = bufNum.U2 + 1U;
					bufNum.U2 = num;
					if (num == 0U)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06001007 RID: 4103 RVA: 0x0002B144 File Offset: 0x00029344
			internal unsafe static void DecAddSub(ref decimal.DecCalc d1, ref decimal.DecCalc d2, bool sign)
			{
				ulong num = d1.Low64;
				uint num2 = d1.High;
				uint num3 = d1.uflags;
				uint num4 = d2.uflags;
				uint num5 = num4 ^ num3;
				sign ^= ((num5 & 2147483648U) > 0U);
				if ((num5 & 16711680U) != 0U)
				{
					uint num6 = num3;
					num3 = ((num4 & 16711680U) | (num3 & 2147483648U));
					int i = (int)(num3 - num6) >> 16;
					if (i < 0)
					{
						i = -i;
						num3 = num6;
						if (sign)
						{
							num3 ^= 2147483648U;
						}
						num = d2.Low64;
						num2 = d2.High;
						d2 = d1;
					}
					ulong num9;
					if (num2 == 0U)
					{
						if (num <= (ulong)-1)
						{
							if ((uint)num == 0U)
							{
								uint num7 = num3 & 2147483648U;
								if (sign)
								{
									num7 ^= 2147483648U;
								}
								d1 = d2;
								d1.uflags = ((d2.uflags & 16711680U) | num7);
								return;
							}
							while (i > 9)
							{
								i -= 9;
								num = Math.BigMul((uint)num, 1000000000U);
								if (num > (ulong)-1)
								{
									goto IL_10F;
								}
							}
							num = Math.BigMul((uint)num, *decimal.DecCalc.UInt32Powers10[i]);
							goto IL_46E;
						}
						do
						{
							IL_10F:
							uint b = 1000000000U;
							if (i < 9)
							{
								b = *decimal.DecCalc.UInt32Powers10[i];
							}
							ulong num8 = Math.BigMul((uint)num, b);
							num9 = Math.BigMul((uint)(num >> 32), b) + (num8 >> 32);
							num = (ulong)((uint)num8) + (num9 << 32);
							num2 = (uint)(num9 >> 32);
							if ((i -= 9) <= 0)
							{
								goto IL_46E;
							}
						}
						while (num2 == 0U);
					}
					do
					{
						uint b = 1000000000U;
						if (i < 9)
						{
							b = *decimal.DecCalc.UInt32Powers10[i];
						}
						ulong num8 = Math.BigMul((uint)num, b);
						num9 = Math.BigMul((uint)(num >> 32), b) + (num8 >> 32);
						num = (ulong)((uint)num8) + (num9 << 32);
						num9 >>= 32;
						num9 += Math.BigMul(num2, b);
						i -= 9;
						if (num9 > (ulong)-1)
						{
							goto IL_1EA;
						}
						num2 = (uint)num9;
					}
					while (i > 0);
					goto IL_46E;
					IL_1EA:
					decimal.DecCalc.Buf24 buf;
					Unsafe.SkipInit<decimal.DecCalc.Buf24>(out buf);
					buf.Low64 = num;
					buf.Mid64 = num9;
					uint num10 = 3U;
					while (i > 0)
					{
						uint b = 1000000000U;
						if (i < 9)
						{
							b = *decimal.DecCalc.UInt32Powers10[i];
						}
						num9 = 0UL;
						uint* ptr = (uint*)(&buf);
						uint num11 = 0U;
						do
						{
							num9 += Math.BigMul(ptr[(ulong)num11 * 4UL / 4UL], b);
							ptr[(ulong)num11 * 4UL / 4UL] = (uint)num9;
							num11 += 1U;
							num9 >>= 32;
						}
						while (num11 <= num10);
						if ((uint)num9 != 0U)
						{
							ptr[(IntPtr)((ulong)(num10 += 1U) * 4UL)] = (uint)num9;
						}
						i -= 9;
					}
					num9 = buf.Low64;
					num = d2.Low64;
					uint u = buf.U2;
					num2 = d2.High;
					if (sign)
					{
						num = num9 - num;
						num2 = u - num2;
						if (num > num9)
						{
							num2 -= 1U;
							if (num2 < u)
							{
								goto IL_37A;
							}
						}
						else if (num2 <= u)
						{
							goto IL_37A;
						}
						uint* ptr2 = (uint*)(&buf);
						uint num12 = 3U;
						uint num13;
						do
						{
							uint* ptr3 = ptr2 + (IntPtr)((ulong)num12++ * 4UL);
							num13 = *ptr3;
							*ptr3 = num13 - 1U;
						}
						while (num13 == 0U);
						if (ptr2[(ulong)num10 * 4UL / 4UL] == 0U && (num10 -= 1U) <= 2U)
						{
							goto IL_4D7;
						}
					}
					else
					{
						num += num9;
						num2 += u;
						if (num < num9)
						{
							num2 += 1U;
							if (num2 > u)
							{
								goto IL_37A;
							}
						}
						else if (num2 >= u)
						{
							goto IL_37A;
						}
						uint* ptr4 = (uint*)(&buf);
						uint num14 = 3U;
						do
						{
							uint* ptr5 = ptr4 + (IntPtr)((ulong)num14++ * 4UL);
							uint num13 = *ptr5 + 1U;
							*ptr5 = num13;
							if (num13 != 0U)
							{
								goto IL_37A;
							}
						}
						while (num10 >= num14);
						ptr4[(ulong)num14 * 4UL / 4UL] = 1U;
						num10 = num14;
					}
					IL_37A:
					buf.Low64 = num;
					buf.U2 = num2;
					i = decimal.DecCalc.ScaleResult(&buf, num10, (int)((byte)(num3 >> 16)));
					num3 = ((num3 & 4278255615U) | (uint)((uint)i << 16));
					num = buf.Low64;
					num2 = buf.U2;
					goto IL_4D7;
				}
				IL_46E:
				ulong num15 = num;
				uint num16 = num2;
				if (sign)
				{
					num = num15 - d2.Low64;
					num2 = num16 - d2.High;
					if (num > num15)
					{
						num2 -= 1U;
						if (num2 < num16)
						{
							goto IL_4D7;
						}
					}
					else if (num2 <= num16)
					{
						goto IL_4D7;
					}
					num3 ^= 2147483648U;
					num2 = ~num2;
					num = -num;
					if (num == 0UL)
					{
						num2 += 1U;
					}
				}
				else
				{
					num = num15 + d2.Low64;
					num2 = num16 + d2.High;
					if (num < num15)
					{
						num2 += 1U;
						if (num2 > num16)
						{
							goto IL_4D7;
						}
					}
					else if (num2 >= num16)
					{
						goto IL_4D7;
					}
					if ((num3 & 16711680U) == 0U)
					{
						Number.ThrowOverflowException(SR.Overflow_Decimal);
					}
					num3 -= 65536U;
					ulong num17 = (ulong)num2 + 4294967296UL;
					num2 = (uint)(num17 / 10UL);
					ulong num18 = (num17 - (ulong)(num2 * 10U) << 32) + (num >> 32);
					uint num19 = (uint)(num18 / 10UL);
					ulong num20 = (num18 - (ulong)(num19 * 10U) << 32) + (ulong)((uint)num);
					num = (ulong)num19;
					num <<= 32;
					num19 = (uint)(num20 / 10UL);
					num += (ulong)num19;
					num19 = (uint)num20 - num19 * 10U;
					if (num19 >= 5U && (num19 > 5U || (num & 1UL) != 0UL) && (num += 1UL) == 0UL)
					{
						num2 += 1U;
					}
				}
				IL_4D7:
				d1.uflags = num3;
				d1.High = num2;
				d1.Low64 = num;
			}

			// Token: 0x06001008 RID: 4104 RVA: 0x0002B640 File Offset: 0x00029840
			internal unsafe static long VarCyFromDec(ref decimal.DecCalc pdecIn)
			{
				int num = pdecIn.Scale - 4;
				long num4;
				if (num < 0)
				{
					if (pdecIn.High != 0U)
					{
						goto IL_9F;
					}
					uint a = *decimal.DecCalc.UInt32Powers10[-num];
					ulong num2 = Math.BigMul(a, pdecIn.Mid);
					if (num2 > (ulong)-1)
					{
						goto IL_9F;
					}
					ulong num3 = Math.BigMul(a, pdecIn.Low);
					num3 += (num2 <<= 32);
					if (num3 < num2)
					{
						goto IL_9F;
					}
					num4 = (long)num3;
				}
				else
				{
					if (num != 0)
					{
						decimal.DecCalc.InternalRound(ref pdecIn, (uint)num, MidpointRounding.ToEven);
					}
					if (pdecIn.High != 0U)
					{
						goto IL_9F;
					}
					num4 = (long)pdecIn.Low64;
				}
				if (num4 >= 0L || (num4 == -9223372036854775808L && pdecIn.IsNegative))
				{
					if (pdecIn.IsNegative)
					{
						num4 = -num4;
					}
					return num4;
				}
				IL_9F:
				throw new OverflowException(SR.Overflow_Currency);
			}

			// Token: 0x06001009 RID: 4105 RVA: 0x0002B6F8 File Offset: 0x000298F8
			internal static int VarDecCmp(in decimal d1, in decimal d2)
			{
				if ((d2.Low64 | (ulong)d2.High) == 0UL)
				{
					if ((d1.Low64 | (ulong)d1.High) == 0UL)
					{
						return 0;
					}
					return d1._flags >> 31 | 1;
				}
				else
				{
					if ((d1.Low64 | (ulong)d1.High) == 0UL)
					{
						return -(d2._flags >> 31 | 1);
					}
					int num = (d1._flags >> 31) - (d2._flags >> 31);
					if (num != 0)
					{
						return num;
					}
					return decimal.DecCalc.VarDecCmpSub(d1, d2);
				}
			}

			// Token: 0x0600100A RID: 4106 RVA: 0x0002B770 File Offset: 0x00029970
			private unsafe static int VarDecCmpSub(in decimal d1, in decimal d2)
			{
				int flags = d2._flags;
				int num = flags >> 31 | 1;
				int num2 = flags - d1._flags;
				ulong num3 = d1.Low64;
				uint num4 = d1.High;
				ulong num5 = d2.Low64;
				uint num6 = d2.High;
				if (num2 != 0)
				{
					num2 >>= 16;
					if (num2 < 0)
					{
						num2 = -num2;
						num = -num;
						ulong num7 = num3;
						num3 = num5;
						num5 = num7;
						uint num8 = num4;
						num4 = num6;
						num6 = num8;
					}
					for (;;)
					{
						uint b = (num2 >= 9) ? 1000000000U : (*decimal.DecCalc.UInt32Powers10[num2]);
						ulong num9 = Math.BigMul((uint)num3, b);
						ulong num10 = Math.BigMul((uint)(num3 >> 32), b) + (num9 >> 32);
						num3 = (ulong)((uint)num9) + (num10 << 32);
						num10 >>= 32;
						num10 += Math.BigMul(num4, b);
						if (num10 > (ulong)-1)
						{
							break;
						}
						num4 = (uint)num10;
						if ((num2 -= 9) <= 0)
						{
							goto IL_C5;
						}
					}
					return num;
				}
				IL_C5:
				uint num11 = num4 - num6;
				if (num11 != 0U)
				{
					if (num11 > num4)
					{
						num = -num;
					}
					return num;
				}
				ulong num12 = num3 - num5;
				if (num12 == 0UL)
				{
					num = 0;
				}
				else if (num12 > num3)
				{
					num = -num;
				}
				return num;
			}

			// Token: 0x0600100B RID: 4107 RVA: 0x0002B870 File Offset: 0x00029A70
			internal unsafe static void VarDecMul(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
				int num = (int)((byte)(d1.uflags + d2.uflags >> 16));
				decimal.DecCalc.Buf24 buf;
				Unsafe.SkipInit<decimal.DecCalc.Buf24>(out buf);
				uint num5;
				if ((d1.High | d1.Mid) == 0U)
				{
					if ((d2.High | d2.Mid) == 0U)
					{
						ulong num2 = Math.BigMul(d1.Low, d2.Low);
						if (num > 28)
						{
							if (num > 47)
							{
								goto IL_3C3;
							}
							num -= 29;
							ulong num3 = (ulong)(*decimal.DecCalc.UInt64Powers10[num]);
							ValueTuple<ulong, ulong> valueTuple = Math.DivRem(num2, num3);
							num2 = valueTuple.Item1;
							ulong item = valueTuple.Item2;
							num3 >>= 1;
							if (item >= num3 && (item > num3 || ((uint)num2 & 1U) > 0U))
							{
								num2 += 1UL;
							}
							num = 28;
						}
						d1.Low64 = num2;
						d1.uflags = (((d2.uflags ^ d1.uflags) & 2147483648U) | (uint)((uint)num << 16));
						return;
					}
					ulong num4 = Math.BigMul(d1.Low, d2.Low);
					buf.U0 = (uint)num4;
					num4 = Math.BigMul(d1.Low, d2.Mid) + (num4 >> 32);
					buf.U1 = (uint)num4;
					num4 >>= 32;
					if (d2.High != 0U)
					{
						num4 += Math.BigMul(d1.Low, d2.High);
						if (num4 > (ulong)-1)
						{
							buf.Mid64 = num4;
							num5 = 3U;
							goto IL_377;
						}
					}
					buf.U2 = (uint)num4;
					num5 = 2U;
				}
				else if ((d2.High | d2.Mid) == 0U)
				{
					ulong num4 = Math.BigMul(d2.Low, d1.Low);
					buf.U0 = (uint)num4;
					num4 = Math.BigMul(d2.Low, d1.Mid) + (num4 >> 32);
					buf.U1 = (uint)num4;
					num4 >>= 32;
					if (d1.High != 0U)
					{
						num4 += Math.BigMul(d2.Low, d1.High);
						if (num4 > (ulong)-1)
						{
							buf.Mid64 = num4;
							num5 = 3U;
							goto IL_377;
						}
					}
					buf.U2 = (uint)num4;
					num5 = 2U;
				}
				else
				{
					ulong num4 = Math.BigMul(d1.Low, d2.Low);
					buf.U0 = (uint)num4;
					ulong num6 = Math.BigMul(d1.Low, d2.Mid) + (num4 >> 32);
					num4 = Math.BigMul(d1.Mid, d2.Low);
					num4 += num6;
					buf.U1 = (uint)num4;
					if (num4 < num6)
					{
						num6 = (num4 >> 32 | 4294967296UL);
					}
					else
					{
						num6 = num4 >> 32;
					}
					num4 = Math.BigMul(d1.Mid, d2.Mid) + num6;
					if ((d1.High | d2.High) > 0U)
					{
						num6 = Math.BigMul(d1.Low, d2.High);
						num4 += num6;
						uint num7 = 0U;
						if (num4 < num6)
						{
							num7 = 1U;
						}
						num6 = Math.BigMul(d1.High, d2.Low);
						num4 += num6;
						buf.U2 = (uint)num4;
						if (num4 < num6)
						{
							num7 += 1U;
						}
						num6 = ((ulong)num7 << 32 | num4 >> 32);
						num4 = Math.BigMul(d1.Mid, d2.High);
						num4 += num6;
						num7 = 0U;
						if (num4 < num6)
						{
							num7 = 1U;
						}
						num6 = Math.BigMul(d1.High, d2.Mid);
						num4 += num6;
						buf.U3 = (uint)num4;
						if (num4 < num6)
						{
							num7 += 1U;
						}
						num4 = ((ulong)num7 << 32 | num4 >> 32);
						buf.High64 = Math.BigMul(d1.High, d2.High) + num4;
						num5 = 5U;
					}
					else
					{
						buf.Mid64 = num4;
						num5 = 3U;
					}
				}
				uint* ptr = (uint*)(&buf);
				while (ptr[num5] == 0U)
				{
					if (num5 == 0U)
					{
						goto IL_3C3;
					}
					num5 -= 1U;
				}
				IL_377:
				if (num5 > 2U || num > 28)
				{
					num = decimal.DecCalc.ScaleResult(&buf, num5, num);
				}
				d1.Low64 = buf.Low64;
				d1.High = buf.U2;
				d1.uflags = (((d2.uflags ^ d1.uflags) & 2147483648U) | (uint)((uint)num << 16));
				return;
				IL_3C3:
				d1 = default(decimal.DecCalc);
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x0002BC48 File Offset: 0x00029E48
			internal unsafe static void VarDecFromR4(float input, out decimal.DecCalc result)
			{
				result = default(decimal.DecCalc);
				int num = (int)(decimal.DecCalc.GetExponent(input) - 126U);
				if (num < -94)
				{
					return;
				}
				if (num > 96)
				{
					Number.ThrowOverflowException(SR.Overflow_Decimal);
				}
				uint num2 = 0U;
				if (input < 0f)
				{
					input = -input;
					num2 = 2147483648U;
				}
				double num3 = (double)input;
				int num4 = 6 - (num * 19728 >> 16);
				if (num4 >= 0)
				{
					if (num4 > 28)
					{
						num4 = 28;
					}
					num3 *= *decimal.DecCalc.DoublePowers10[num4];
				}
				else if (num4 != -1 || num3 >= 10000000.0)
				{
					num3 /= *decimal.DecCalc.DoublePowers10[-num4];
				}
				else
				{
					num4 = 0;
				}
				if (num3 < 1000000.0 && num4 < 28)
				{
					num3 *= 10.0;
					num4++;
				}
				uint num5;
				if (Sse41.IsSupported)
				{
					num5 = (uint)((int)Math.Round(num3));
				}
				else
				{
					num5 = (uint)((int)num3);
					num3 -= (double)num5;
					if (num3 > 0.5 || (num3 == 0.5 && (num5 & 1U) != 0U))
					{
						num5 += 1U;
					}
				}
				if (num5 == 0U)
				{
					return;
				}
				if (num4 < 0)
				{
					num4 = -num4;
					if (num4 < 10)
					{
						result.Low64 = Math.BigMul(num5, *decimal.DecCalc.UInt32Powers10[num4]);
					}
					else if (num4 > 18)
					{
						decimal.DecCalc.UInt64x64To128(Math.BigMul(num5, *decimal.DecCalc.UInt32Powers10[num4 - 18]), 1000000000000000000UL, ref result);
					}
					else
					{
						ulong num6 = Math.BigMul(num5, *decimal.DecCalc.UInt32Powers10[num4 - 9]);
						ulong num7 = Math.BigMul(1000000000U, (uint)(num6 >> 32));
						num6 = Math.BigMul(1000000000U, (uint)num6);
						result.Low = (uint)num6;
						num7 += num6 >> 32;
						result.Mid = (uint)num7;
						num7 >>= 32;
						result.High = (uint)num7;
					}
				}
				else
				{
					int num8 = num4;
					if (num8 > 6)
					{
						num8 = 6;
					}
					if ((num5 & 15U) == 0U && num8 >= 4)
					{
						ValueTuple<uint, uint> valueTuple = Math.DivRem(num5, 10000U);
						uint item = valueTuple.Item1;
						if (valueTuple.Item2 == 0U)
						{
							num5 = item;
							num4 -= 4;
							num8 -= 4;
						}
					}
					if ((num5 & 3U) == 0U && num8 >= 2)
					{
						ValueTuple<uint, uint> valueTuple2 = Math.DivRem(num5, 100U);
						uint item2 = valueTuple2.Item1;
						if (valueTuple2.Item2 == 0U)
						{
							num5 = item2;
							num4 -= 2;
							num8 -= 2;
						}
					}
					if ((num5 & 1U) == 0U && num8 >= 1)
					{
						ValueTuple<uint, uint> valueTuple3 = Math.DivRem(num5, 10U);
						uint item3 = valueTuple3.Item1;
						if (valueTuple3.Item2 == 0U)
						{
							num5 = item3;
							num4--;
						}
					}
					num2 |= (uint)((uint)num4 << 16);
					result.Low = num5;
				}
				result.uflags = num2;
			}

			// Token: 0x0600100D RID: 4109 RVA: 0x0002BED4 File Offset: 0x0002A0D4
			internal unsafe static void VarDecFromR8(double input, out decimal.DecCalc result)
			{
				result = default(decimal.DecCalc);
				int num = (int)(decimal.DecCalc.GetExponent(input) - 1022U);
				if (num < -94)
				{
					return;
				}
				if (num > 96)
				{
					Number.ThrowOverflowException(SR.Overflow_Decimal);
				}
				uint num2 = 0U;
				if (input < 0.0)
				{
					input = -input;
					num2 = 2147483648U;
				}
				double num3 = input;
				int num4 = 14 - (num * 19728 >> 16);
				if (num4 >= 0)
				{
					if (num4 > 28)
					{
						num4 = 28;
					}
					num3 *= *decimal.DecCalc.DoublePowers10[num4];
				}
				else if (num4 != -1 || num3 >= 1000000000000000.0)
				{
					num3 /= *decimal.DecCalc.DoublePowers10[-num4];
				}
				else
				{
					num4 = 0;
				}
				if (num3 < 100000000000000.0 && num4 < 28)
				{
					num3 *= 10.0;
					num4++;
				}
				ulong num5;
				if (Sse41.IsSupported)
				{
					num5 = (ulong)((long)Math.Round(num3));
				}
				else
				{
					num5 = (ulong)((long)num3);
					num3 -= (double)num5;
					if (num3 > 0.5 || (num3 == 0.5 && (num5 & 1UL) != 0UL))
					{
						num5 += 1UL;
					}
				}
				if (num5 == 0UL)
				{
					return;
				}
				if (num4 < 0)
				{
					num4 = -num4;
					if (num4 < 10)
					{
						uint b = *decimal.DecCalc.UInt32Powers10[num4];
						ulong num6 = Math.BigMul((uint)num5, b);
						ulong num7 = Math.BigMul((uint)(num5 >> 32), b);
						result.Low = (uint)num6;
						num7 += num6 >> 32;
						result.Mid = (uint)num7;
						num7 >>= 32;
						result.High = (uint)num7;
					}
					else
					{
						decimal.DecCalc.UInt64x64To128(num5, (ulong)(*decimal.DecCalc.UInt64Powers10[num4 - 1]), ref result);
					}
				}
				else
				{
					int num8 = num4;
					if (num8 > 14)
					{
						num8 = 14;
					}
					if ((byte)num5 == 0 && num8 >= 8)
					{
						ulong num9 = num5 / 100000000UL;
						if ((uint)num5 == (uint)(num9 * 100000000UL))
						{
							num5 = num9;
							num4 -= 8;
							num8 -= 8;
						}
					}
					if (((uint)num5 & 15U) == 0U && num8 >= 4)
					{
						ulong num10 = num5 / 10000UL;
						if ((uint)num5 == (uint)(num10 * 10000UL))
						{
							num5 = num10;
							num4 -= 4;
							num8 -= 4;
						}
					}
					if (((uint)num5 & 3U) == 0U && num8 >= 2)
					{
						ulong num11 = num5 / 100UL;
						if ((uint)num5 == (uint)(num11 * 100UL))
						{
							num5 = num11;
							num4 -= 2;
							num8 -= 2;
						}
					}
					if (((uint)num5 & 1U) == 0U && num8 >= 1)
					{
						ulong num12 = num5 / 10UL;
						if ((uint)num5 == (uint)(num12 * 10UL))
						{
							num5 = num12;
							num4--;
						}
					}
					num2 |= (uint)((uint)num4 << 16);
					result.Low64 = num5;
				}
				result.uflags = num2;
			}

			// Token: 0x0600100E RID: 4110 RVA: 0x0002C14F File Offset: 0x0002A34F
			internal static float VarR4FromDec(in decimal value)
			{
				return (float)decimal.DecCalc.VarR8FromDec(value);
			}

			// Token: 0x0600100F RID: 4111 RVA: 0x0002C158 File Offset: 0x0002A358
			internal unsafe static double VarR8FromDec(in decimal value)
			{
				double num = (value.Low64 + value.High * 1.8446744073709552E+19) / *decimal.DecCalc.DoublePowers10[(int)value.Scale];
				if (decimal.IsNegative(value))
				{
					num = -num;
				}
				return num;
			}

			// Token: 0x06001010 RID: 4112 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
			internal static int GetHashCode(in decimal d)
			{
				if ((d.Low64 | (ulong)d.High) == 0UL)
				{
					return 0;
				}
				uint num = (uint)d._flags;
				if ((num & 16711680U) == 0U || (d.Low & 1U) != 0U)
				{
					return (int)(num ^ d.High ^ d.Mid ^ d.Low);
				}
				int num2 = (int)((byte)(num >> 16));
				uint low = d.Low;
				ulong num3 = (ulong)d.High << 32 | (ulong)d.Mid;
				decimal.DecCalc.Unscale(ref low, ref num3, ref num2);
				num = ((num & 4278255615U) | (uint)((uint)num2 << 16));
				return (int)(num ^ (uint)(num3 >> 32) ^ (uint)num3 ^ low);
			}

			// Token: 0x06001011 RID: 4113 RVA: 0x0002C23C File Offset: 0x0002A43C
			internal unsafe static void VarDecDiv(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
				decimal.DecCalc.Buf12 buf;
				Unsafe.SkipInit<decimal.DecCalc.Buf12>(out buf);
				int num = (int)((sbyte)(d1.uflags - d2.uflags >> 16));
				bool flag = false;
				if ((d2.High | d2.Mid) == 0U)
				{
					uint low = d2.Low;
					if (low == 0U)
					{
						throw new DivideByZeroException();
					}
					buf.Low64 = d1.Low64;
					buf.U2 = d1.High;
					uint num2 = decimal.DecCalc.Div96By32(ref buf, low);
					for (;;)
					{
						int num3;
						if (num2 == 0U)
						{
							if (num >= 0)
							{
								goto IL_409;
							}
							num3 = Math.Min(9, -num);
						}
						else
						{
							flag = true;
							if (num == 28 || (num3 = decimal.DecCalc.SearchScale(ref buf, num)) == 0)
							{
								break;
							}
						}
						uint num4 = *decimal.DecCalc.UInt32Powers10[num3];
						num += num3;
						if (decimal.DecCalc.IncreaseScale(ref buf, num4) != 0U)
						{
							goto IL_4C1;
						}
						ulong num5 = Math.BigMul(num2, num4);
						uint num6 = (uint)(num5 / (ulong)low);
						num2 = (uint)num5 - num6 * low;
						if (!decimal.DecCalc.Add32To96(ref buf, num6))
						{
							goto Block_11;
						}
					}
					uint num7 = num2 << 1;
					if (num7 < num2)
					{
						goto IL_480;
					}
					if (num7 < low)
					{
						goto IL_409;
					}
					if (num7 > low)
					{
						goto IL_480;
					}
					if ((buf.U0 & 1U) != 0U)
					{
						goto IL_480;
					}
					goto IL_409;
					Block_11:
					num = decimal.DecCalc.OverflowUnscale(ref buf, num, num2 > 0U);
				}
				else
				{
					uint num7 = d2.High;
					if (num7 == 0U)
					{
						num7 = d2.Mid;
					}
					int num3 = BitOperations.LeadingZeroCount(num7);
					decimal.DecCalc.Buf16 buf2;
					Unsafe.SkipInit<decimal.DecCalc.Buf16>(out buf2);
					buf2.Low64 = d1.Low64 << num3;
					buf2.High64 = (ulong)d1.Mid + ((ulong)d1.High << 32) >> 32 - num3;
					ulong num8 = d2.Low64 << num3;
					if (d2.High == 0U)
					{
						buf.U2 = 0U;
						buf.U1 = decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf2.U1), num8);
						buf.U0 = decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf2), num8);
						for (;;)
						{
							if (buf2.Low64 == 0UL)
							{
								if (num >= 0)
								{
									goto IL_409;
								}
								num3 = Math.Min(9, -num);
							}
							else
							{
								flag = true;
								if (num == 28 || (num3 = decimal.DecCalc.SearchScale(ref buf, num)) == 0)
								{
									break;
								}
							}
							uint num4 = *decimal.DecCalc.UInt32Powers10[num3];
							num += num3;
							if (decimal.DecCalc.IncreaseScale(ref buf, num4) != 0U)
							{
								goto IL_4C1;
							}
							decimal.DecCalc.IncreaseScale64(ref *(decimal.DecCalc.Buf12*)(&buf2), num4);
							num7 = decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf2), num8);
							if (!decimal.DecCalc.Add32To96(ref buf, num7))
							{
								goto Block_22;
							}
						}
						ulong num9 = buf2.Low64;
						if (num9 < 0UL || (num9 <<= 1) > num8)
						{
							goto IL_480;
						}
						if (num9 == num8 && (buf.U0 & 1U) != 0U)
						{
							goto IL_480;
						}
						goto IL_409;
						Block_22:
						num = decimal.DecCalc.OverflowUnscale(ref buf, num, buf2.Low64 > 0UL);
					}
					else
					{
						decimal.DecCalc.Buf12 buf3;
						Unsafe.SkipInit<decimal.DecCalc.Buf12>(out buf3);
						buf3.Low64 = num8;
						buf3.U2 = (uint)((ulong)d2.Mid + ((ulong)d2.High << 32) >> 32 - num3);
						buf.Low64 = (ulong)decimal.DecCalc.Div128By96(ref buf2, ref buf3);
						buf.U2 = 0U;
						for (;;)
						{
							if ((buf2.Low64 | (ulong)buf2.U2) == 0UL)
							{
								if (num >= 0)
								{
									goto IL_409;
								}
								num3 = Math.Min(9, -num);
							}
							else
							{
								flag = true;
								if (num == 28 || (num3 = decimal.DecCalc.SearchScale(ref buf, num)) == 0)
								{
									break;
								}
							}
							uint num4 = *decimal.DecCalc.UInt32Powers10[num3];
							num += num3;
							if (decimal.DecCalc.IncreaseScale(ref buf, num4) != 0U)
							{
								goto IL_4C1;
							}
							buf2.U3 = decimal.DecCalc.IncreaseScale(ref *(decimal.DecCalc.Buf12*)(&buf2), num4);
							num7 = decimal.DecCalc.Div128By96(ref buf2, ref buf3);
							if (!decimal.DecCalc.Add32To96(ref buf, num7))
							{
								goto Block_33;
							}
						}
						if (buf2.U2 < 0U)
						{
							goto IL_480;
						}
						num7 = buf2.U1 >> 31;
						buf2.Low64 <<= 1;
						buf2.U2 = (buf2.U2 << 1) + num7;
						if (buf2.U2 > buf3.U2)
						{
							goto IL_480;
						}
						if (buf2.U2 != buf3.U2)
						{
							goto IL_409;
						}
						if (buf2.Low64 > buf3.Low64)
						{
							goto IL_480;
						}
						if (buf2.Low64 == buf3.Low64 && (buf.U0 & 1U) != 0U)
						{
							goto IL_480;
						}
						goto IL_409;
						Block_33:
						num = decimal.DecCalc.OverflowUnscale(ref buf, num, (buf2.Low64 | buf2.High64) > 0UL);
					}
				}
				IL_409:
				if (flag)
				{
					uint u = buf.U0;
					ulong high = buf.High64;
					decimal.DecCalc.Unscale(ref u, ref high, ref num);
					d1.Low = u;
					d1.Mid = (uint)high;
					d1.High = (uint)(high >> 32);
				}
				else
				{
					d1.Low64 = buf.Low64;
					d1.High = buf.U2;
				}
				d1.uflags = (((d1.uflags ^ d2.uflags) & 2147483648U) | (uint)((uint)num << 16));
				return;
				IL_480:
				ulong num10 = buf.Low64 + 1UL;
				buf.Low64 = num10;
				if (num10 != 0UL)
				{
					goto IL_409;
				}
				uint num11 = buf.U2 + 1U;
				buf.U2 = num11;
				if (num11 == 0U)
				{
					num = decimal.DecCalc.OverflowUnscale(ref buf, num, true);
					goto IL_409;
				}
				goto IL_409;
				IL_4C1:
				Number.ThrowOverflowException(SR.Overflow_Decimal);
			}

			// Token: 0x06001012 RID: 4114 RVA: 0x0002C714 File Offset: 0x0002A914
			internal unsafe static void VarDecMod(ref decimal.DecCalc d1, ref decimal.DecCalc d2)
			{
				if ((d2.ulo | d2.umid | d2.uhi) == 0U)
				{
					throw new DivideByZeroException();
				}
				if ((d1.ulo | d1.umid | d1.uhi) == 0U)
				{
					return;
				}
				d2.uflags = ((d2.uflags & 2147483647U) | (d1.uflags & 2147483648U));
				int num = decimal.DecCalc.VarDecCmpSub(Unsafe.As<decimal.DecCalc, decimal>(ref d1), Unsafe.As<decimal.DecCalc, decimal>(ref d2));
				if (num == 0)
				{
					d1.ulo = 0U;
					d1.umid = 0U;
					d1.uhi = 0U;
					if (d2.uflags > d1.uflags)
					{
						d1.uflags = d2.uflags;
					}
					return;
				}
				if ((num ^ (int)(d1.uflags & 2147483648U)) < 0)
				{
					return;
				}
				int num2 = (int)((sbyte)(d1.uflags - d2.uflags >> 16));
				if (num2 > 0)
				{
					do
					{
						uint num3 = (num2 >= 9) ? 1000000000U : (*decimal.DecCalc.UInt32Powers10[num2]);
						ulong num4 = Math.BigMul(d2.Low, num3);
						d2.Low = (uint)num4;
						num4 >>= 32;
						num4 += ((ulong)d2.Mid + ((ulong)d2.High << 32)) * (ulong)num3;
						d2.Mid = (uint)num4;
						d2.High = (uint)(num4 >> 32);
					}
					while ((num2 -= 9) > 0);
					num2 = 0;
				}
				for (;;)
				{
					if (num2 < 0)
					{
						d1.uflags = d2.uflags;
						decimal.DecCalc.Buf12 buf;
						Unsafe.SkipInit<decimal.DecCalc.Buf12>(out buf);
						buf.Low64 = d1.Low64;
						buf.U2 = d1.High;
						uint num6;
						do
						{
							int num5 = decimal.DecCalc.SearchScale(ref buf, 28 + num2);
							if (num5 == 0)
							{
								break;
							}
							num6 = ((num5 >= 9) ? 1000000000U : (*decimal.DecCalc.UInt32Powers10[num5]));
							num2 += num5;
							ulong num7 = Math.BigMul(buf.U0, num6);
							buf.U0 = (uint)num7;
							num7 >>= 32;
							buf.High64 = num7 + buf.High64 * (ulong)num6;
						}
						while (num6 == 1000000000U && num2 < 0);
						d1.Low64 = buf.Low64;
						d1.High = buf.U2;
					}
					if (d1.High == 0U)
					{
						break;
					}
					if ((d2.High | d2.Mid) != 0U)
					{
						goto IL_262;
					}
					uint low = d2.Low;
					ulong num8 = (ulong)d1.High << 32 | (ulong)d1.Mid;
					num8 = (num8 % (ulong)low << 32 | (ulong)d1.Low);
					d1.Low64 = num8 % (ulong)low;
					d1.High = 0U;
					if (num2 >= 0)
					{
						return;
					}
				}
				d1.Low64 %= d2.Low64;
				return;
				IL_262:
				decimal.DecCalc.VarDecModFull(ref d1, ref d2, num2);
			}

			// Token: 0x06001013 RID: 4115 RVA: 0x0002C994 File Offset: 0x0002AB94
			private unsafe static void VarDecModFull(ref decimal.DecCalc d1, ref decimal.DecCalc d2, int scale)
			{
				uint num = d2.High;
				if (num == 0U)
				{
					num = d2.Mid;
				}
				int num2 = BitOperations.LeadingZeroCount(num);
				decimal.DecCalc.Buf28 buf;
				Unsafe.SkipInit<decimal.DecCalc.Buf28>(out buf);
				buf.Buf24.Low64 = d1.Low64 << num2;
				buf.Buf24.Mid64 = (ulong)d1.Mid + ((ulong)d1.High << 32) >> 32 - num2;
				uint num3 = 3U;
				while (scale < 0)
				{
					uint b = (scale <= -9) ? 1000000000U : (*decimal.DecCalc.UInt32Powers10[-scale]);
					uint* ptr = (uint*)(&buf);
					ulong num4 = Math.BigMul(buf.Buf24.U0, b);
					buf.Buf24.U0 = (uint)num4;
					int num5 = 1;
					while ((long)num5 <= (long)((ulong)num3))
					{
						num4 >>= 32;
						num4 += Math.BigMul(ptr[num5], b);
						ptr[num5] = (uint)num4;
						num5++;
					}
					if (num4 > 2147483647UL)
					{
						ptr[(IntPtr)((ulong)(num3 += 1U) * 4UL)] = (uint)(num4 >> 32);
					}
					scale += 9;
				}
				if (d2.High == 0U)
				{
					ulong den = d2.Low64 << num2;
					switch (num3)
					{
					case 4U:
						goto IL_167;
					case 5U:
						break;
					case 6U:
						decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf.Buf24.U4), den);
						break;
					default:
						goto IL_17C;
					}
					decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf.Buf24.U3), den);
					IL_167:
					decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf.Buf24.U2), den);
					IL_17C:
					decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf.Buf24.U1), den);
					decimal.DecCalc.Div96By64(ref *(decimal.DecCalc.Buf12*)(&buf), den);
					d1.Low64 = buf.Buf24.Low64 >> num2;
					d1.High = 0U;
					return;
				}
				decimal.DecCalc.Buf12 buf2;
				Unsafe.SkipInit<decimal.DecCalc.Buf12>(out buf2);
				buf2.Low64 = d2.Low64 << num2;
				buf2.U2 = (uint)((ulong)d2.Mid + ((ulong)d2.High << 32) >> 32 - num2);
				switch (num3)
				{
				case 4U:
					goto IL_236;
				case 5U:
					break;
				case 6U:
					decimal.DecCalc.Div128By96(ref *(decimal.DecCalc.Buf16*)(&buf.Buf24.U3), ref buf2);
					break;
				default:
					goto IL_24B;
				}
				decimal.DecCalc.Div128By96(ref *(decimal.DecCalc.Buf16*)(&buf.Buf24.U2), ref buf2);
				IL_236:
				decimal.DecCalc.Div128By96(ref *(decimal.DecCalc.Buf16*)(&buf.Buf24.U1), ref buf2);
				IL_24B:
				decimal.DecCalc.Div128By96(ref *(decimal.DecCalc.Buf16*)(&buf), ref buf2);
				d1.Low64 = (buf.Buf24.Low64 >> num2) + ((ulong)buf.Buf24.U2 << 32 - num2 << 32);
				d1.High = buf.Buf24.U2 >> num2;
			}

			// Token: 0x06001014 RID: 4116 RVA: 0x0002CC3C File Offset: 0x0002AE3C
			internal unsafe static void InternalRound(ref decimal.DecCalc d, uint scale, MidpointRounding mode)
			{
				d.uflags -= scale << 16;
				uint num = 0U;
				uint num5;
				while (scale >= 9U)
				{
					scale -= 9U;
					uint num2 = d.uhi;
					uint num4;
					if (num2 == 0U)
					{
						ulong low = d.Low64;
						ulong num3 = low / 1000000000UL;
						d.Low64 = num3;
						num4 = (uint)(low - num3 * 1000000000UL);
					}
					else
					{
						ValueTuple<uint, uint> valueTuple = Math.DivRem(num2, 1000000000U);
						d.uhi = valueTuple.Item1;
						num4 = valueTuple.Item2;
						num2 = d.umid;
						if ((num2 | num4) != 0U)
						{
							num4 = num2 - (d.umid = (uint)(((ulong)num4 << 32 | (ulong)num2) / 1000000000UL)) * 1000000000U;
						}
						num2 = d.ulo;
						if ((num2 | num4) != 0U)
						{
							num4 = num2 - (d.ulo = (uint)(((ulong)num4 << 32 | (ulong)num2) / 1000000000UL)) * 1000000000U;
						}
					}
					num5 = 1000000000U;
					if (scale == 0U)
					{
						IL_1B3:
						if (mode != MidpointRounding.ToZero)
						{
							if (mode == MidpointRounding.ToEven)
							{
								num4 <<= 1;
								if ((num | (d.ulo & 1U)) != 0U)
								{
									num4 += 1U;
								}
								if (num5 >= num4)
								{
									return;
								}
							}
							else if (mode == MidpointRounding.AwayFromZero)
							{
								num4 <<= 1;
								if (num5 > num4)
								{
									return;
								}
							}
							else if (mode == MidpointRounding.ToNegativeInfinity)
							{
								if ((num4 | num) == 0U)
								{
									return;
								}
								if (!d.IsNegative)
								{
									return;
								}
							}
							else if ((num4 | num) == 0U || d.IsNegative)
							{
								return;
							}
							ulong num6 = d.Low64 + 1UL;
							d.Low64 = num6;
							if (num6 == 0UL)
							{
								d.uhi += 1U;
							}
						}
						return;
					}
					num |= num4;
				}
				num5 = *decimal.DecCalc.UInt32Powers10[(int)scale];
				uint num7 = d.uhi;
				if (num7 == 0U)
				{
					ulong low2 = d.Low64;
					if (low2 != 0UL)
					{
						ulong num8 = low2 / (ulong)num5;
						d.Low64 = num8;
						uint num4 = (uint)(low2 - num8 * (ulong)num5);
						goto IL_1B3;
					}
					if (mode > MidpointRounding.ToZero)
					{
						uint num4 = 0U;
						goto IL_1B3;
					}
					return;
				}
				else
				{
					ValueTuple<uint, uint> valueTuple = Math.DivRem(num7, num5);
					d.uhi = valueTuple.Item1;
					uint num4 = valueTuple.Item2;
					num7 = d.umid;
					if ((num7 | num4) != 0U)
					{
						num4 = num7 - (d.umid = (uint)(((ulong)num4 << 32 | (ulong)num7) / (ulong)num5)) * num5;
					}
					num7 = d.ulo;
					if ((num7 | num4) != 0U)
					{
						num4 = num7 - (d.ulo = (uint)(((ulong)num4 << 32 | (ulong)num7) / (ulong)num5)) * num5;
						goto IL_1B3;
					}
					goto IL_1B3;
				}
			}

			// Token: 0x06001015 RID: 4117 RVA: 0x0002CE6C File Offset: 0x0002B06C
			internal static uint DecDivMod1E9(ref decimal.DecCalc value)
			{
				ulong num = ((ulong)value.uhi << 32) + (ulong)value.umid;
				ulong num2 = num / 1000000000UL;
				value.uhi = (uint)(num2 >> 32);
				value.umid = (uint)num2;
				ulong num3 = (num - (ulong)((uint)num2 * 1000000000U) << 32) + (ulong)value.ulo;
				uint num4 = (uint)(num3 / 1000000000UL);
				value.ulo = num4;
				return (uint)num3 - num4 * 1000000000U;
			}

			// Token: 0x04000363 RID: 867
			[FieldOffset(0)]
			private uint uflags;

			// Token: 0x04000364 RID: 868
			[FieldOffset(4)]
			private uint uhi;

			// Token: 0x04000365 RID: 869
			[FieldOffset(8)]
			private uint ulo;

			// Token: 0x04000366 RID: 870
			[FieldOffset(12)]
			private uint umid;

			// Token: 0x04000367 RID: 871
			[FieldOffset(8)]
			private ulong ulomid;

			// Token: 0x04000368 RID: 872
			private static readonly decimal.DecCalc.PowerOvfl[] PowerOvflValues = new decimal.DecCalc.PowerOvfl[]
			{
				new decimal.DecCalc.PowerOvfl(429496729U, 2576980377U, 2576980377U),
				new decimal.DecCalc.PowerOvfl(42949672U, 4123168604U, 687194767U),
				new decimal.DecCalc.PowerOvfl(4294967U, 1271310319U, 2645699854U),
				new decimal.DecCalc.PowerOvfl(429496U, 3133608139U, 694066715U),
				new decimal.DecCalc.PowerOvfl(42949U, 2890341191U, 2216890319U),
				new decimal.DecCalc.PowerOvfl(4294U, 4154504685U, 2369172679U),
				new decimal.DecCalc.PowerOvfl(429U, 2133437386U, 4102387834U),
				new decimal.DecCalc.PowerOvfl(42U, 4078814305U, 410238783U)
			};

			// Token: 0x020000F7 RID: 247
			private readonly struct PowerOvfl
			{
				// Token: 0x06001017 RID: 4119 RVA: 0x0002CFC5 File Offset: 0x0002B1C5
				public PowerOvfl(uint hi, uint mid, uint lo)
				{
					this.Hi = hi;
					this.MidLo = ((ulong)mid << 32) + (ulong)lo;
				}

				// Token: 0x04000369 RID: 873
				public readonly uint Hi;

				// Token: 0x0400036A RID: 874
				public readonly ulong MidLo;
			}

			// Token: 0x020000F8 RID: 248
			[StructLayout(LayoutKind.Explicit)]
			private struct Buf12
			{
				// Token: 0x17000187 RID: 391
				// (get) Token: 0x06001018 RID: 4120 RVA: 0x0002CFDC File Offset: 0x0002B1DC
				// (set) Token: 0x06001019 RID: 4121 RVA: 0x0002CFE4 File Offset: 0x0002B1E4
				public ulong Low64
				{
					get
					{
						return this.ulo64LE;
					}
					set
					{
						this.ulo64LE = value;
					}
				}

				// Token: 0x17000188 RID: 392
				// (get) Token: 0x0600101A RID: 4122 RVA: 0x0002CFED File Offset: 0x0002B1ED
				// (set) Token: 0x0600101B RID: 4123 RVA: 0x0002CFF5 File Offset: 0x0002B1F5
				public ulong High64
				{
					get
					{
						return this.uhigh64LE;
					}
					set
					{
						this.uhigh64LE = value;
					}
				}

				// Token: 0x0400036B RID: 875
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x0400036C RID: 876
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x0400036D RID: 877
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x0400036E RID: 878
				[FieldOffset(0)]
				private ulong ulo64LE;

				// Token: 0x0400036F RID: 879
				[FieldOffset(4)]
				private ulong uhigh64LE;
			}

			// Token: 0x020000F9 RID: 249
			[StructLayout(LayoutKind.Explicit)]
			private struct Buf16
			{
				// Token: 0x17000189 RID: 393
				// (get) Token: 0x0600101C RID: 4124 RVA: 0x0002CFFE File Offset: 0x0002B1FE
				// (set) Token: 0x0600101D RID: 4125 RVA: 0x0002D006 File Offset: 0x0002B206
				public ulong Low64
				{
					get
					{
						return this.ulo64LE;
					}
					set
					{
						this.ulo64LE = value;
					}
				}

				// Token: 0x1700018A RID: 394
				// (get) Token: 0x0600101E RID: 4126 RVA: 0x0002D00F File Offset: 0x0002B20F
				// (set) Token: 0x0600101F RID: 4127 RVA: 0x0002D017 File Offset: 0x0002B217
				public ulong High64
				{
					get
					{
						return this.uhigh64LE;
					}
					set
					{
						this.uhigh64LE = value;
					}
				}

				// Token: 0x04000370 RID: 880
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x04000371 RID: 881
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x04000372 RID: 882
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x04000373 RID: 883
				[FieldOffset(12)]
				public uint U3;

				// Token: 0x04000374 RID: 884
				[FieldOffset(0)]
				private ulong ulo64LE;

				// Token: 0x04000375 RID: 885
				[FieldOffset(8)]
				private ulong uhigh64LE;
			}

			// Token: 0x020000FA RID: 250
			[StructLayout(LayoutKind.Explicit)]
			private struct Buf24
			{
				// Token: 0x1700018B RID: 395
				// (get) Token: 0x06001020 RID: 4128 RVA: 0x0002D020 File Offset: 0x0002B220
				// (set) Token: 0x06001021 RID: 4129 RVA: 0x0002D028 File Offset: 0x0002B228
				public ulong Low64
				{
					get
					{
						return this.ulo64LE;
					}
					set
					{
						this.ulo64LE = value;
					}
				}

				// Token: 0x1700018C RID: 396
				// (set) Token: 0x06001022 RID: 4130 RVA: 0x0002D031 File Offset: 0x0002B231
				public ulong Mid64
				{
					set
					{
						this.umid64LE = value;
					}
				}

				// Token: 0x1700018D RID: 397
				// (set) Token: 0x06001023 RID: 4131 RVA: 0x0002D03A File Offset: 0x0002B23A
				public ulong High64
				{
					set
					{
						this.uhigh64LE = value;
					}
				}

				// Token: 0x04000376 RID: 886
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x04000377 RID: 887
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x04000378 RID: 888
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x04000379 RID: 889
				[FieldOffset(12)]
				public uint U3;

				// Token: 0x0400037A RID: 890
				[FieldOffset(16)]
				public uint U4;

				// Token: 0x0400037B RID: 891
				[FieldOffset(20)]
				public uint U5;

				// Token: 0x0400037C RID: 892
				[FieldOffset(0)]
				private ulong ulo64LE;

				// Token: 0x0400037D RID: 893
				[FieldOffset(8)]
				private ulong umid64LE;

				// Token: 0x0400037E RID: 894
				[FieldOffset(16)]
				private ulong uhigh64LE;
			}

			// Token: 0x020000FB RID: 251
			private struct Buf28
			{
				// Token: 0x0400037F RID: 895
				public decimal.DecCalc.Buf24 Buf24;

				// Token: 0x04000380 RID: 896
				public uint U6;
			}
		}
	}
}
