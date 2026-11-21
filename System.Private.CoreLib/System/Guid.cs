using System;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x02000133 RID: 307
	[NonVersionable]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Guid : ISpanFormattable, IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanParsable<Guid>, IParsable<Guid>, IUtf8SpanFormattable
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x000398B4 File Offset: 0x00037AB4
		public static Guid AllBitsSet
		{
			get
			{
				return new Guid(uint.MaxValue, ushort.MaxValue, ushort.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000398F9 File Offset: 0x00037AF9
		[NullableContext(1)]
		public Guid(byte[] b)
		{
			if (b == null)
			{
				throw new ArgumentNullException("b");
			}
			this = new Guid(new ReadOnlySpan<byte>(b));
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00039916 File Offset: 0x00037B16
		public Guid(ReadOnlySpan<byte> b)
		{
			if (b.Length != 16)
			{
				Guid.ThrowGuidArrayCtorArgumentException();
			}
			this = MemoryMarshal.Read<Guid>(b);
			if (!BitConverter.IsLittleEndian)
			{
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0003993C File Offset: 0x00037B3C
		public Guid(ReadOnlySpan<byte> b, bool bigEndian)
		{
			if (b.Length != 16)
			{
				Guid.ThrowGuidArrayCtorArgumentException();
			}
			this = MemoryMarshal.Read<Guid>(b);
			if (BitConverter.IsLittleEndian == bigEndian)
			{
				this._a = BinaryPrimitives.ReverseEndianness(this._a);
				this._b = BinaryPrimitives.ReverseEndianness(this._b);
				this._c = BinaryPrimitives.ReverseEndianness(this._c);
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000399A0 File Offset: 0x00037BA0
		[DoesNotReturn]
		[StackTraceHidden]
		private static void ThrowGuidArrayCtorArgumentException()
		{
			throw new ArgumentException(SR.Format(SR.Arg_GuidArrayCtor, "16"), "b");
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000399BC File Offset: 0x00037BBC
		[CLSCompliant(false)]
		public Guid(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			this._a = (int)a;
			this._b = (short)b;
			this._c = (short)c;
			this._d = d;
			this._e = e;
			this._f = f;
			this._g = g;
			this._h = h;
			this._i = i;
			this._j = j;
			this._k = k;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00039A20 File Offset: 0x00037C20
		[NullableContext(1)]
		public Guid(int a, short b, short c, byte[] d)
		{
			ArgumentNullException.ThrowIfNull(d, "d");
			if (d.Length != 8)
			{
				throw new ArgumentException(SR.Format(SR.Arg_GuidArrayCtor, "8"), "d");
			}
			this._a = a;
			this._b = b;
			this._c = c;
			this._d = d[0];
			this._e = d[1];
			this._f = d[2];
			this._g = d[3];
			this._h = d[4];
			this._i = d[5];
			this._j = d[6];
			this._k = d[7];
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00039AC0 File Offset: 0x00037CC0
		public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			this._a = a;
			this._b = b;
			this._c = c;
			this._d = d;
			this._e = e;
			this._f = f;
			this._g = g;
			this._h = h;
			this._i = i;
			this._j = j;
			this._k = k;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00039B24 File Offset: 0x00037D24
		[NullableContext(1)]
		public Guid(string g)
		{
			ArgumentNullException.ThrowIfNull(g, "g");
			Guid.GuidResult guidResult = new Guid.GuidResult(Guid.GuidParseThrowStyle.All);
			Guid.TryParseGuid(g, ref guidResult);
			this = guidResult.ToGuid();
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00039B5F File Offset: 0x00037D5F
		public int Variant
		{
			get
			{
				return this._d >> 4;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00039B69 File Offset: 0x00037D69
		public int Version
		{
			get
			{
				return (int)((uint)((ushort)this._c) >> 12);
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00039B75 File Offset: 0x00037D75
		public static Guid CreateVersion7()
		{
			return Guid.CreateVersion7(DateTimeOffset.UtcNow);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00039B84 File Offset: 0x00037D84
		public unsafe static Guid CreateVersion7(DateTimeOffset timestamp)
		{
			Guid guid = Guid.NewGuid();
			long num = timestamp.ToUnixTimeMilliseconds();
			ArgumentOutOfRangeException.ThrowIfNegative<long>(num, "timestamp");
			*Unsafe.AsRef<int>(ref guid._a) = (int)(num >> 16);
			*Unsafe.AsRef<short>(ref guid._b) = (short)num;
			*Unsafe.AsRef<short>(ref guid._c) = (short)(((int)guid._c & -61441) | 28672);
			*Unsafe.AsRef<byte>(ref guid._d) = (byte)(((int)guid._d & -193) | 128);
			return guid;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00039C0C File Offset: 0x00037E0C
		[NullableContext(1)]
		public static Guid Parse(string input)
		{
			ArgumentNullException.ThrowIfNull(input, "input");
			return Guid.Parse(input);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00039C24 File Offset: 0x00037E24
		public static Guid Parse(ReadOnlySpan<char> input)
		{
			Guid.GuidResult guidResult = new Guid.GuidResult(Guid.GuidParseThrowStyle.AllButOverflow);
			Guid.TryParseGuid(input, ref guidResult);
			return guidResult.ToGuid();
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00039C49 File Offset: 0x00037E49
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string input, out Guid result)
		{
			if (input == null)
			{
				result = default(Guid);
				return false;
			}
			return Guid.TryParse(input, out result);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00039C64 File Offset: 0x00037E64
		public static bool TryParse(ReadOnlySpan<char> input, out Guid result)
		{
			Guid.GuidResult guidResult = new Guid.GuidResult(Guid.GuidParseThrowStyle.None);
			if (Guid.TryParseGuid(input, ref guidResult))
			{
				result = guidResult.ToGuid();
				return true;
			}
			result = default(Guid);
			return false;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00039C9A File Offset: 0x00037E9A
		[NullableContext(1)]
		public static Guid ParseExact(string input, [StringSyntax("GuidFormat")] string format)
		{
			ArgumentNullException.ThrowIfNull(input, "input");
			ArgumentNullException.ThrowIfNull(format, "format");
			return Guid.ParseExact(input, format);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00039CC4 File Offset: 0x00037EC4
		public unsafe static Guid ParseExact(ReadOnlySpan<char> input, [StringSyntax("GuidFormat")] ReadOnlySpan<char> format)
		{
			if (format.Length != 1)
			{
				Guid.ThrowBadGuidFormatSpecification();
			}
			input = input.Trim();
			Guid.GuidResult guidResult = new Guid.GuidResult(Guid.GuidParseThrowStyle.AllButOverflow);
			char c = (char)(*format[0] | 32);
			if (c <= 'd')
			{
				if (c == 'b')
				{
					bool flag = Guid.TryParseExactB(input, ref guidResult);
					goto IL_91;
				}
				if (c == 'd')
				{
					bool flag = Guid.TryParseExactD(input, ref guidResult);
					goto IL_91;
				}
			}
			else
			{
				if (c == 'n')
				{
					bool flag = Guid.TryParseExactN(input, ref guidResult);
					goto IL_91;
				}
				if (c == 'p')
				{
					bool flag = Guid.TryParseExactP(input, ref guidResult);
					goto IL_91;
				}
				if (c == 'x')
				{
					bool flag = Guid.TryParseExactX(input, ref guidResult);
					goto IL_91;
				}
			}
			throw new FormatException(SR.Format_InvalidGuidFormatSpecification);
			IL_91:
			return guidResult.ToGuid();
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00039D69 File Offset: 0x00037F69
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string input, [NotNullWhen(true)] [StringSyntax("GuidFormat")] string format, out Guid result)
		{
			if (input == null)
			{
				result = default(Guid);
				return false;
			}
			return Guid.TryParseExact(input, format, out result);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00039D8C File Offset: 0x00037F8C
		public unsafe static bool TryParseExact(ReadOnlySpan<char> input, [StringSyntax("GuidFormat")] ReadOnlySpan<char> format, out Guid result)
		{
			if (format.Length != 1 || input.Length < 32)
			{
				result = default(Guid);
				return false;
			}
			input = input.Trim();
			Guid.GuidResult guidResult = new Guid.GuidResult(Guid.GuidParseThrowStyle.None);
			bool flag = false;
			char c = (char)(*format[0] | 32);
			if (c <= 'd')
			{
				if (c != 'b')
				{
					if (c == 'd')
					{
						flag = Guid.TryParseExactD(input, ref guidResult);
					}
				}
				else
				{
					flag = Guid.TryParseExactB(input, ref guidResult);
				}
			}
			else if (c != 'n')
			{
				if (c != 'p')
				{
					if (c == 'x')
					{
						flag = Guid.TryParseExactX(input, ref guidResult);
					}
				}
				else
				{
					flag = Guid.TryParseExactP(input, ref guidResult);
				}
			}
			else
			{
				flag = Guid.TryParseExactN(input, ref guidResult);
			}
			if (flag)
			{
				result = guidResult.ToGuid();
				return true;
			}
			result = default(Guid);
			return false;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00039E48 File Offset: 0x00038048
		private unsafe static bool TryParseGuid(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			guidString = guidString.Trim();
			if (guidString.Length < 32)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidUnrecognized);
				return false;
			}
			char c = (char)(*guidString[0]);
			bool result2;
			if (c != '(')
			{
				if (c != '{')
				{
					result2 = ((*guidString[8] == 45) ? Guid.TryParseExactD(guidString, ref result) : Guid.TryParseExactN(guidString, ref result));
				}
				else
				{
					result2 = ((*guidString[9] == 45) ? Guid.TryParseExactB(guidString, ref result) : Guid.TryParseExactX(guidString, ref result));
				}
			}
			else
			{
				result2 = Guid.TryParseExactP(guidString, ref result);
			}
			return result2;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00039ED4 File Offset: 0x000380D4
		private unsafe static bool TryParseExactB(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			if (guidString.Length != 38 || *guidString[0] != 123 || *guidString[37] != 125)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidInvLen);
				return false;
			}
			return Guid.TryParseExactD(guidString.Slice(1, 36), ref result);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00039F20 File Offset: 0x00038120
		private unsafe static bool TryParseExactD(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			if (guidString.Length != 36 || *guidString[8] != 45 || *guidString[13] != 45 || *guidString[18] != 45 || *guidString[23] != 45)
			{
				result.SetFailure((guidString.Length != 36) ? Guid.ParseFailure.Format_GuidInvLen : Guid.ParseFailure.Format_GuidDashes);
				return false;
			}
			Span<byte> span = MemoryMarshal.AsBytes<Guid.GuidResult>(new Span<Guid.GuidResult>(ref result));
			int num = 0;
			*span[0] = Guid.DecodeByte((char)(*guidString[6]), (char)(*guidString[7]), ref num);
			*span[1] = Guid.DecodeByte((char)(*guidString[4]), (char)(*guidString[5]), ref num);
			*span[2] = Guid.DecodeByte((char)(*guidString[2]), (char)(*guidString[3]), ref num);
			*span[3] = Guid.DecodeByte((char)(*guidString[0]), (char)(*guidString[1]), ref num);
			*span[4] = Guid.DecodeByte((char)(*guidString[11]), (char)(*guidString[12]), ref num);
			*span[5] = Guid.DecodeByte((char)(*guidString[9]), (char)(*guidString[10]), ref num);
			*span[6] = Guid.DecodeByte((char)(*guidString[16]), (char)(*guidString[17]), ref num);
			*span[7] = Guid.DecodeByte((char)(*guidString[14]), (char)(*guidString[15]), ref num);
			*span[8] = Guid.DecodeByte((char)(*guidString[19]), (char)(*guidString[20]), ref num);
			*span[9] = Guid.DecodeByte((char)(*guidString[21]), (char)(*guidString[22]), ref num);
			*span[10] = Guid.DecodeByte((char)(*guidString[24]), (char)(*guidString[25]), ref num);
			*span[11] = Guid.DecodeByte((char)(*guidString[26]), (char)(*guidString[27]), ref num);
			*span[12] = Guid.DecodeByte((char)(*guidString[28]), (char)(*guidString[29]), ref num);
			*span[13] = Guid.DecodeByte((char)(*guidString[30]), (char)(*guidString[31]), ref num);
			*span[14] = Guid.DecodeByte((char)(*guidString[32]), (char)(*guidString[33]), ref num);
			*span[15] = Guid.DecodeByte((char)(*guidString[34]), (char)(*guidString[35]), ref num);
			if (num >= 0)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return true;
			}
			if (guidString.ContainsAny('X', 'x', '+') && Guid.<TryParseExactD>g__TryCompatParsing|46_0(guidString, ref result))
			{
				return true;
			}
			result.SetFailure(Guid.ParseFailure.Format_GuidInvalidChar);
			return false;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0003A204 File Offset: 0x00038404
		private unsafe static bool TryParseExactN(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			if (guidString.Length != 32)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidInvLen);
				return false;
			}
			Span<byte> span = MemoryMarshal.AsBytes<Guid.GuidResult>(new Span<Guid.GuidResult>(ref result));
			int num = 0;
			*span[0] = Guid.DecodeByte((char)(*guidString[6]), (char)(*guidString[7]), ref num);
			*span[1] = Guid.DecodeByte((char)(*guidString[4]), (char)(*guidString[5]), ref num);
			*span[2] = Guid.DecodeByte((char)(*guidString[2]), (char)(*guidString[3]), ref num);
			*span[3] = Guid.DecodeByte((char)(*guidString[0]), (char)(*guidString[1]), ref num);
			*span[4] = Guid.DecodeByte((char)(*guidString[10]), (char)(*guidString[11]), ref num);
			*span[5] = Guid.DecodeByte((char)(*guidString[8]), (char)(*guidString[9]), ref num);
			*span[6] = Guid.DecodeByte((char)(*guidString[14]), (char)(*guidString[15]), ref num);
			*span[7] = Guid.DecodeByte((char)(*guidString[12]), (char)(*guidString[13]), ref num);
			*span[8] = Guid.DecodeByte((char)(*guidString[16]), (char)(*guidString[17]), ref num);
			*span[9] = Guid.DecodeByte((char)(*guidString[18]), (char)(*guidString[19]), ref num);
			*span[10] = Guid.DecodeByte((char)(*guidString[20]), (char)(*guidString[21]), ref num);
			*span[11] = Guid.DecodeByte((char)(*guidString[22]), (char)(*guidString[23]), ref num);
			*span[12] = Guid.DecodeByte((char)(*guidString[24]), (char)(*guidString[25]), ref num);
			*span[13] = Guid.DecodeByte((char)(*guidString[26]), (char)(*guidString[27]), ref num);
			*span[14] = Guid.DecodeByte((char)(*guidString[28]), (char)(*guidString[29]), ref num);
			*span[15] = Guid.DecodeByte((char)(*guidString[30]), (char)(*guidString[31]), ref num);
			if (num >= 0)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return true;
			}
			result.SetFailure(Guid.ParseFailure.Format_GuidInvalidChar);
			return false;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0003A488 File Offset: 0x00038688
		private unsafe static bool TryParseExactP(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			if (guidString.Length != 38 || *guidString[0] != 40 || *guidString[37] != 41)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidInvLen);
				return false;
			}
			return Guid.TryParseExactD(guidString.Slice(1, 36), ref result);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0003A4D4 File Offset: 0x000386D4
		private unsafe static bool TryParseExactX(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			guidString = Guid.EatAllWhitespace(guidString);
			if (guidString.Length == 0 || *guidString[0] != 123)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidBrace);
				return false;
			}
			if (!Guid.IsHexPrefix(guidString, 1))
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidHexPrefix);
				return false;
			}
			int num = 3;
			int num2 = guidString.Slice(num).IndexOf(',');
			if (num2 <= 0)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidComma);
				return false;
			}
			bool flag = false;
			if (!Guid.TryParseHex(guidString.Slice(num, num2), out result._a, ref flag) || flag)
			{
				result.SetFailure(flag ? Guid.ParseFailure.Overflow_UInt32 : Guid.ParseFailure.Format_GuidInvalidChar);
				return false;
			}
			if (!Guid.IsHexPrefix(guidString, num + num2 + 1))
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidHexPrefix);
				return false;
			}
			num = num + num2 + 3;
			num2 = guidString.Slice(num).IndexOf(',');
			if (num2 <= 0)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidComma);
				return false;
			}
			if (!Guid.TryParseHex(guidString.Slice(num, num2), out result._b, ref flag) || flag)
			{
				result.SetFailure(flag ? Guid.ParseFailure.Overflow_UInt32 : Guid.ParseFailure.Format_GuidInvalidChar);
				return false;
			}
			if (!Guid.IsHexPrefix(guidString, num + num2 + 1))
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidHexPrefix);
				return false;
			}
			num = num + num2 + 3;
			num2 = guidString.Slice(num).IndexOf(',');
			if (num2 <= 0)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidComma);
				return false;
			}
			if (!Guid.TryParseHex(guidString.Slice(num, num2), out result._c, ref flag) || flag)
			{
				result.SetFailure(flag ? Guid.ParseFailure.Overflow_UInt32 : Guid.ParseFailure.Format_GuidInvalidChar);
				return false;
			}
			if (guidString.Length <= num + num2 + 1 || *guidString[num + num2 + 1] != 123)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidBrace);
				return false;
			}
			num2++;
			for (int i = 0; i < 8; i++)
			{
				if (!Guid.IsHexPrefix(guidString, num + num2 + 1))
				{
					result.SetFailure(Guid.ParseFailure.Format_GuidHexPrefix);
					return false;
				}
				num = num + num2 + 3;
				if (i < 7)
				{
					num2 = guidString.Slice(num).IndexOf(',');
					if (num2 <= 0)
					{
						result.SetFailure(Guid.ParseFailure.Format_GuidComma);
						return false;
					}
				}
				else
				{
					num2 = guidString.Slice(num).IndexOf('}');
					if (num2 <= 0)
					{
						result.SetFailure(Guid.ParseFailure.Format_GuidBraceAfterLastNumber);
						return false;
					}
				}
				uint num3;
				if (!Guid.TryParseHex(guidString.Slice(num, num2), out num3, ref flag) || flag || num3 > 255U)
				{
					result.SetFailure(flag ? Guid.ParseFailure.Overflow_UInt32 : ((num3 > 255U) ? Guid.ParseFailure.Overflow_Byte : Guid.ParseFailure.Format_GuidInvalidChar));
					return false;
				}
				*Unsafe.Add<byte>(ref result._d, i) = (byte)num3;
			}
			if (num + num2 + 1 >= guidString.Length || *guidString[num + num2 + 1] != 125)
			{
				result.SetFailure(Guid.ParseFailure.Format_GuidEndBrace);
				return false;
			}
			if (num + num2 + 1 != guidString.Length - 1)
			{
				result.SetFailure(Guid.ParseFailure.Format_ExtraJunkAtEnd);
				return false;
			}
			return true;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0003A760 File Offset: 0x00038960
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static byte DecodeByte(char ch1, char ch2, ref int invalidIfNegative)
		{
			ReadOnlySpan<byte> charToHexLookup = HexConverter.CharToHexLookup;
			int num = (int)((sbyte)(*charToHexLookup[(int)((byte)ch1)]));
			int num2 = (int)((sbyte)(*charToHexLookup[(int)((byte)ch2)]));
			int num3 = num << 4 | num2;
			num3 = (((ch1 | ch2) >> 8 == '\0') ? num3 : -1);
			invalidIfNegative |= num3;
			return (byte)num3;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0003A7A4 File Offset: 0x000389A4
		private static bool TryParseHex(ReadOnlySpan<char> guidString, out ushort result, ref bool overflow)
		{
			uint num;
			bool result2 = Guid.TryParseHex(guidString, out num, ref overflow);
			result = (ushort)num;
			return result2;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0003A7C0 File Offset: 0x000389C0
		private static bool TryParseHex(ReadOnlySpan<char> guidString, out uint result)
		{
			bool flag = false;
			return Guid.TryParseHex(guidString, out result, ref flag);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0003A7D8 File Offset: 0x000389D8
		private unsafe static bool TryParseHex(ReadOnlySpan<char> guidString, out uint result, ref bool overflow)
		{
			if (guidString.Length > 0)
			{
				if (*guidString[0] == 43)
				{
					guidString = guidString.Slice(1);
				}
				if (guidString.Length > 1 && *guidString[0] == 48 && (*guidString[1] | 32) == 120)
				{
					guidString = guidString.Slice(2);
				}
			}
			int i = 0;
			while (i < guidString.Length && *guidString[i] == 48)
			{
				i++;
			}
			int num = 0;
			uint num2 = 0U;
			while (i < guidString.Length)
			{
				int num3 = HexConverter.FromChar((int)(*guidString[i]));
				if (num3 == 255)
				{
					if (num > 8)
					{
						overflow = true;
					}
					result = 0U;
					return false;
				}
				num2 = num2 * 16U + (uint)num3;
				num++;
				i++;
			}
			if (num > 8)
			{
				overflow = true;
			}
			result = num2;
			return true;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0003A8A4 File Offset: 0x00038AA4
		private unsafe static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str)
		{
			int i = 0;
			while (i < str.Length && !char.IsWhiteSpace((char)(*str[i])))
			{
				i++;
			}
			if (i == str.Length)
			{
				return str;
			}
			char[] array = new char[str.Length];
			int length = 0;
			if (i > 0)
			{
				length = i;
				str.Slice(0, i).CopyTo(array);
			}
			while (i < str.Length)
			{
				char c = (char)(*str[i]);
				if (!char.IsWhiteSpace(c))
				{
					array[length++] = c;
				}
				i++;
			}
			return new ReadOnlySpan<char>(array, 0, length);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0003A940 File Offset: 0x00038B40
		private unsafe static bool IsHexPrefix(ReadOnlySpan<char> str, int i)
		{
			return i + 1 < str.Length && *str[i] == 48 && (*str[i + 1] | 32) == 120;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0003A970 File Offset: 0x00038B70
		[NullableContext(1)]
		public byte[] ToByteArray()
		{
			byte[] array = new byte[16];
			bool isLittleEndian = BitConverter.IsLittleEndian;
			MemoryMarshal.TryWrite<Guid>(array, this);
			return array;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0003A99C File Offset: 0x00038B9C
		[NullableContext(1)]
		public byte[] ToByteArray(bool bigEndian)
		{
			byte[] array = new byte[16];
			if (BitConverter.IsLittleEndian != bigEndian)
			{
				MemoryMarshal.TryWrite<Guid>(array, this);
			}
			else
			{
				Guid guid = new Guid(MemoryMarshal.AsBytes<Guid>(new ReadOnlySpan<Guid>(ref this)), bigEndian);
				MemoryMarshal.TryWrite<Guid>(array, guid);
			}
			return array;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0003A9EA File Offset: 0x00038BEA
		public bool TryWriteBytes(Span<byte> destination)
		{
			if (destination.Length < 16)
			{
				return false;
			}
			bool isLittleEndian = BitConverter.IsLittleEndian;
			MemoryMarshal.TryWrite<Guid>(destination, this);
			return true;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0003AA0C File Offset: 0x00038C0C
		public bool TryWriteBytes(Span<byte> destination, bool bigEndian, out int bytesWritten)
		{
			if (destination.Length < 16)
			{
				bytesWritten = 0;
				return false;
			}
			if (BitConverter.IsLittleEndian != bigEndian)
			{
				MemoryMarshal.TryWrite<Guid>(destination, this);
			}
			else
			{
				Guid guid = new Guid(MemoryMarshal.AsBytes<Guid>(new ReadOnlySpan<Guid>(ref this)), bigEndian);
				MemoryMarshal.TryWrite<Guid>(destination, guid);
			}
			bytesWritten = 16;
			return true;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0003AA5C File Offset: 0x00038C5C
		public unsafe override int GetHashCode()
		{
			ref int ptr = ref Unsafe.AsRef<int>(ref this._a);
			return ptr ^ *Unsafe.Add<int>(ref ptr, 1) ^ *Unsafe.Add<int>(ref ptr, 2) ^ *Unsafe.Add<int>(ref ptr, 3);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0003AA94 File Offset: 0x00038C94
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object o)
		{
			if (o is Guid)
			{
				Guid guid = (Guid)o;
				return Guid.EqualsCore(this, guid);
			}
			return false;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0003AABA File Offset: 0x00038CBA
		public bool Equals(Guid g)
		{
			return Guid.EqualsCore(this, g);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0003AAC4 File Offset: 0x00038CC4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool EqualsCore(in Guid left, in Guid right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return Vector128.LoadUnsafe<byte>(Unsafe.As<Guid, byte>(Unsafe.AsRef<Guid>(ref left))) == Vector128.LoadUnsafe<byte>(Unsafe.As<Guid, byte>(Unsafe.AsRef<Guid>(ref right)));
			}
			ref int ptr = ref Unsafe.AsRef<int>(ref left._a);
			ref int ptr2 = ref Unsafe.AsRef<int>(ref right._a);
			return ptr == ptr2 && *Unsafe.Add<int>(ref ptr, 1) == *Unsafe.Add<int>(ref ptr2, 1) && *Unsafe.Add<int>(ref ptr, 2) == *Unsafe.Add<int>(ref ptr2, 2) && *Unsafe.Add<int>(ref ptr, 3) == *Unsafe.Add<int>(ref ptr2, 3);
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0003AB54 File Offset: 0x00038D54
		private static int GetResult(uint me, uint them)
		{
			if (me >= them)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0003AB60 File Offset: 0x00038D60
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is Guid)
			{
				Guid value2 = (Guid)value;
				return this.CompareTo(value2);
			}
			throw new ArgumentException(SR.Arg_MustBeGuid, "value");
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0003AB9C File Offset: 0x00038D9C
		public int CompareTo(Guid value)
		{
			if (value._a != this._a)
			{
				return Guid.GetResult((uint)this._a, (uint)value._a);
			}
			if (value._b != this._b)
			{
				return Guid.GetResult((uint)this._b, (uint)value._b);
			}
			if (value._c != this._c)
			{
				return Guid.GetResult((uint)this._c, (uint)value._c);
			}
			if (value._d != this._d)
			{
				return Guid.GetResult((uint)this._d, (uint)value._d);
			}
			if (value._e != this._e)
			{
				return Guid.GetResult((uint)this._e, (uint)value._e);
			}
			if (value._f != this._f)
			{
				return Guid.GetResult((uint)this._f, (uint)value._f);
			}
			if (value._g != this._g)
			{
				return Guid.GetResult((uint)this._g, (uint)value._g);
			}
			if (value._h != this._h)
			{
				return Guid.GetResult((uint)this._h, (uint)value._h);
			}
			if (value._i != this._i)
			{
				return Guid.GetResult((uint)this._i, (uint)value._i);
			}
			if (value._j != this._j)
			{
				return Guid.GetResult((uint)this._j, (uint)value._j);
			}
			if (value._k != this._k)
			{
				return Guid.GetResult((uint)this._k, (uint)value._k);
			}
			return 0;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0003AD0A File Offset: 0x00038F0A
		public static bool operator ==(Guid a, Guid b)
		{
			return Guid.EqualsCore(a, b);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0003AD15 File Offset: 0x00038F15
		public static bool operator !=(Guid a, Guid b)
		{
			return !Guid.EqualsCore(a, b);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0003AD24 File Offset: 0x00038F24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static int HexsToChars<[IsUnmanaged] TChar>(TChar* guidChars, int a, int b) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			*guidChars = IUtfChar<TChar>.CastFrom(HexConverter.ToCharLower(a >> 4));
			guidChars[sizeof(TChar) / sizeof(TChar)] = IUtfChar<TChar>.CastFrom(HexConverter.ToCharLower(a));
			guidChars[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(HexConverter.ToCharLower(b >> 4));
			guidChars[(IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(HexConverter.ToCharLower(b));
			return 4;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0003ADB0 File Offset: 0x00038FB0
		private unsafe static int HexsToCharsHexOutput<[IsUnmanaged] TChar>(TChar* guidChars, int a, int b) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			*guidChars = IUtfChar<TChar>.CastFrom('0');
			guidChars[sizeof(TChar) / sizeof(TChar)] = IUtfChar<TChar>.CastFrom('x');
			guidChars[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(HexConverter.ToCharLower(a >> 4));
			guidChars[(IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(HexConverter.ToCharLower(a));
			guidChars[(IntPtr)4 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(',');
			guidChars[(IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('0');
			guidChars[(IntPtr)6 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('x');
			guidChars[(IntPtr)7 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(HexConverter.ToCharLower(b >> 4));
			guidChars[(IntPtr)8 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(HexConverter.ToCharLower(b));
			return 9;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0003AECB File Offset: 0x000390CB
		[NullableContext(1)]
		public override string ToString()
		{
			return this.ToString("d", null);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0003AED9 File Offset: 0x000390D9
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("GuidFormat")] string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0003AEE4 File Offset: 0x000390E4
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("GuidFormat")] string format, IFormatProvider provider)
		{
			int length;
			if (string.IsNullOrEmpty(format))
			{
				length = 36;
			}
			else
			{
				if (format.Length != 1)
				{
					Guid.ThrowBadGuidFormatSpecification();
				}
				int num = (int)(format[0] | ' ');
				if (num <= 100)
				{
					if (num != 98)
					{
						if (num != 100)
						{
							goto IL_5C;
						}
						length = 36;
						goto IL_63;
					}
				}
				else
				{
					if (num == 110)
					{
						length = 32;
						goto IL_63;
					}
					if (num != 112)
					{
						if (num != 120)
						{
							goto IL_5C;
						}
						length = 68;
						goto IL_63;
					}
				}
				length = 38;
				goto IL_63;
				IL_5C:
				length = 0;
				Guid.ThrowBadGuidFormatSpecification();
			}
			IL_63:
			string text = string.FastAllocateString(length);
			int num2;
			this.TryFormatCore<char>(new Span<char>(text.GetRawStringData(), text.Length), out num2, format);
			return text;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0003AF7C File Offset: 0x0003917C
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("GuidFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>))
		{
			return this.TryFormatCore<char>(destination, out charsWritten, format);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0003AF7C File Offset: 0x0003917C
		bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("GuidFormat")] ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return this.TryFormatCore<char>(destination, out charsWritten, format);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0003AF87 File Offset: 0x00039187
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("GuidFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>))
		{
			return this.TryFormatCore<byte>(utf8Destination, out bytesWritten, format);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0003AF87 File Offset: 0x00039187
		bool IUtf8SpanFormattable.TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("GuidFormat")] ReadOnlySpan<char> format, IFormatProvider provider)
		{
			return this.TryFormatCore<byte>(utf8Destination, out bytesWritten, format);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0003AF94 File Offset: 0x00039194
		private unsafe bool TryFormatCore<[IsUnmanaged] TChar>(Span<TChar> destination, out int charsWritten, ReadOnlySpan<char> format) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int flags;
			if (format.Length == 0)
			{
				flags = -2147483612;
			}
			else
			{
				if (format.Length != 1)
				{
					Guid.ThrowBadGuidFormatSpecification();
				}
				int num = (int)(*format[0] | 32);
				if (num <= 100)
				{
					if (num == 98)
					{
						flags = -2139260122;
						goto IL_7C;
					}
					if (num == 100)
					{
						flags = -2147483612;
						goto IL_7C;
					}
				}
				else
				{
					if (num == 110)
					{
						flags = 32;
						goto IL_7C;
					}
					if (num == 112)
					{
						flags = -2144786394;
						goto IL_7C;
					}
					if (num == 120)
					{
						return this.TryFormatX<TChar>(destination, out charsWritten);
					}
				}
				flags = 0;
				Guid.ThrowBadGuidFormatSpecification();
			}
			IL_7C:
			return this.TryFormatCore<TChar>(destination, out charsWritten, flags);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0003B028 File Offset: 0x00039228
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe bool TryFormatCore<[IsUnmanaged] TChar>(Span<TChar> destination, out int charsWritten, int flags) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if ((int)((byte)flags) > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = (int)((byte)flags);
			flags >>= 8;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				if ((byte)flags != 0)
				{
					TChar* ptr2 = ptr;
					ptr = ptr2 + sizeof(TChar) / sizeof(TChar);
					*ptr2 = IUtfChar<TChar>.CastFrom((byte)flags);
				}
				flags >>= 8;
				if (Ssse3.IsSupported || false)
				{
					bool isLittleEndian = BitConverter.IsLittleEndian;
					ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> valueTuple = Guid.FormatGuidVector128Utf8(this, flags < 0);
					Vector128<byte> item = valueTuple.Item1;
					Vector128<byte> item2 = valueTuple.Item2;
					Vector128<byte> item3 = valueTuple.Item3;
					if (typeof(TChar) == typeof(byte))
					{
						byte* ptr3 = (byte*)ptr;
						if (flags < 0)
						{
							item.Store(ptr3);
							item2.Store(ptr3 + 20);
							item3.Store(ptr3 + 8);
							ptr += (IntPtr)36 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
						}
						else
						{
							item.Store(ptr3);
							item2.Store(ptr3 + 16);
							ptr += (IntPtr)32 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
						}
					}
					else
					{
						ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple2 = Vector128.Widen(item);
						Vector128<ushort> item4 = valueTuple2.Item1;
						Vector128<ushort> item5 = valueTuple2.Item2;
						ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple3 = Vector128.Widen(item2);
						Vector128<ushort> item6 = valueTuple3.Item1;
						Vector128<ushort> item7 = valueTuple3.Item2;
						ushort* ptr4 = (ushort*)ptr;
						if (flags < 0)
						{
							ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple4 = Vector128.Widen(item3);
							Vector128<ushort> item8 = valueTuple4.Item1;
							Vector128<ushort> item9 = valueTuple4.Item2;
							item4.Store(ptr4);
							item6.Store(ptr4 + 20);
							item7.Store(ptr4 + 28);
							item8.Store(ptr4 + 8);
							item9.Store(ptr4 + 16);
							ptr += (IntPtr)36 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
						}
						else
						{
							item4.Store(ptr4);
							item5.Store(ptr4 + 8);
							item6.Store(ptr4 + 16);
							item7.Store(ptr4 + 24);
							ptr += (IntPtr)32 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
						}
					}
				}
				else
				{
					ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, this._a >> 24, this._a >> 16) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, this._a >> 8, this._a) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					if (flags < 0)
					{
						TChar* ptr5 = ptr;
						ptr = ptr5 + sizeof(TChar) / sizeof(TChar);
						*ptr5 = IUtfChar<TChar>.CastFrom('-');
					}
					ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, this._b >> 8, (int)this._b) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					if (flags < 0)
					{
						TChar* ptr6 = ptr;
						ptr = ptr6 + sizeof(TChar) / sizeof(TChar);
						*ptr6 = IUtfChar<TChar>.CastFrom('-');
					}
					ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, this._c >> 8, (int)this._c) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					if (flags < 0)
					{
						TChar* ptr7 = ptr;
						ptr = ptr7 + sizeof(TChar) / sizeof(TChar);
						*ptr7 = IUtfChar<TChar>.CastFrom('-');
					}
					ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, (int)this._d, (int)this._e) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					if (flags < 0)
					{
						TChar* ptr8 = ptr;
						ptr = ptr8 + sizeof(TChar) / sizeof(TChar);
						*ptr8 = IUtfChar<TChar>.CastFrom('-');
					}
					ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, (int)this._f, (int)this._g) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, (int)this._h, (int)this._i) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, (int)this._j, (int)this._k) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				}
				if ((byte)flags != 0)
				{
					*ptr = IUtfChar<TChar>.CastFrom((byte)flags);
				}
			}
			return true;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0003B39C File Offset: 0x0003959C
		private unsafe bool TryFormatX<[IsUnmanaged] TChar>(Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (destination.Length < 68)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = 68;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				TChar* ptr2 = ptr;
				ptr = ptr2 + sizeof(TChar) / sizeof(TChar);
				*ptr2 = IUtfChar<TChar>.CastFrom('{');
				TChar* ptr3 = ptr;
				ptr = ptr3 + sizeof(TChar) / sizeof(TChar);
				*ptr3 = IUtfChar<TChar>.CastFrom('0');
				TChar* ptr4 = ptr;
				ptr = ptr4 + sizeof(TChar) / sizeof(TChar);
				*ptr4 = IUtfChar<TChar>.CastFrom('x');
				ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, this._a >> 24, this._a >> 16) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, this._a >> 8, this._a) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				TChar* ptr5 = ptr;
				ptr = ptr5 + sizeof(TChar) / sizeof(TChar);
				*ptr5 = IUtfChar<TChar>.CastFrom(',');
				TChar* ptr6 = ptr;
				ptr = ptr6 + sizeof(TChar) / sizeof(TChar);
				*ptr6 = IUtfChar<TChar>.CastFrom('0');
				TChar* ptr7 = ptr;
				ptr = ptr7 + sizeof(TChar) / sizeof(TChar);
				*ptr7 = IUtfChar<TChar>.CastFrom('x');
				ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, this._b >> 8, (int)this._b) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				TChar* ptr8 = ptr;
				ptr = ptr8 + sizeof(TChar) / sizeof(TChar);
				*ptr8 = IUtfChar<TChar>.CastFrom(',');
				TChar* ptr9 = ptr;
				ptr = ptr9 + sizeof(TChar) / sizeof(TChar);
				*ptr9 = IUtfChar<TChar>.CastFrom('0');
				TChar* ptr10 = ptr;
				ptr = ptr10 + sizeof(TChar) / sizeof(TChar);
				*ptr10 = IUtfChar<TChar>.CastFrom('x');
				ptr += (IntPtr)Guid.HexsToChars<TChar>(ptr, this._c >> 8, (int)this._c) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				TChar* ptr11 = ptr;
				ptr = ptr11 + sizeof(TChar) / sizeof(TChar);
				*ptr11 = IUtfChar<TChar>.CastFrom(',');
				TChar* ptr12 = ptr;
				ptr = ptr12 + sizeof(TChar) / sizeof(TChar);
				*ptr12 = IUtfChar<TChar>.CastFrom('{');
				ptr += (IntPtr)Guid.HexsToCharsHexOutput<TChar>(ptr, (int)this._d, (int)this._e) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				TChar* ptr13 = ptr;
				ptr = ptr13 + sizeof(TChar) / sizeof(TChar);
				*ptr13 = IUtfChar<TChar>.CastFrom(',');
				ptr += (IntPtr)Guid.HexsToCharsHexOutput<TChar>(ptr, (int)this._f, (int)this._g) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				TChar* ptr14 = ptr;
				ptr = ptr14 + sizeof(TChar) / sizeof(TChar);
				*ptr14 = IUtfChar<TChar>.CastFrom(',');
				ptr += (IntPtr)Guid.HexsToCharsHexOutput<TChar>(ptr, (int)this._h, (int)this._i) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				TChar* ptr15 = ptr;
				ptr = ptr15 + sizeof(TChar) / sizeof(TChar);
				*ptr15 = IUtfChar<TChar>.CastFrom(',');
				ptr += (IntPtr)Guid.HexsToCharsHexOutput<TChar>(ptr, (int)this._j, (int)this._k) * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				TChar* ptr16 = ptr;
				ptr = ptr16 + sizeof(TChar) / sizeof(TChar);
				*ptr16 = IUtfChar<TChar>.CastFrom('}');
				*ptr = IUtfChar<TChar>.CastFrom('}');
			}
			return true;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0003B678 File Offset: 0x00039878
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>> FormatGuidVector128Utf8(Guid value, bool useDashes)
		{
			Vector128<byte> hexMap = Vector128.Create(48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 97, 98, 99, 100, 101, 102);
			ValueTuple<Vector128<byte>, Vector128<byte>> valueTuple = HexConverter.AsciiToHexVector128(*Unsafe.As<Guid, Vector128<byte>>(ref value), hexMap);
			Vector128<byte> vector = valueTuple.Item1;
			Vector128<byte> item = valueTuple.Item2;
			vector = Vector128.Shuffle(vector.AsInt16<byte>(), Vector128.Create(3, 2, 1, 0, 5, 4, 7, 6)).AsByte<short>();
			if (useDashes)
			{
				Vector128<byte> item2 = Vector128.Shuffle(vector, Vector128.Create(506097522914230528L, 940406845091678463L).AsByte<long>());
				Vector128<byte> item3 = Vector128.Shuffle(item, Vector128.Create(506097527142154753L, 1084818905618843912L).AsByte<long>());
				Vector128<byte> right = Vector128.Create(49478023249965L, 3242591731709706240L).AsByte<long>();
				if (false)
				{
				}
				Vector128<byte> left = Vector128.Shuffle(vector, Vector128.Create(940406845091678463UL, 18446744073709489934UL).AsByte<ulong>());
				Vector128<byte> right2 = Vector128.Shuffle(item, Vector128.Create(ulong.MaxValue, 18375533107936755711UL).AsByte<ulong>());
				Vector128<byte> item4 = left | right2 | right;
				return new ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>>(item2, item3, item4);
			}
			return new ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>>(vector, item, default(Vector128<byte>));
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0003B7BC File Offset: 0x000399BC
		public static bool operator <(Guid left, Guid right)
		{
			if (left._a != right._a)
			{
				return left._a < right._a;
			}
			if (left._b != right._b)
			{
				return left._b < right._b;
			}
			if (left._c != right._c)
			{
				return left._c < right._c;
			}
			if (left._d != right._d)
			{
				return left._d < right._d;
			}
			if (left._e != right._e)
			{
				return left._e < right._e;
			}
			if (left._f != right._f)
			{
				return left._f < right._f;
			}
			if (left._g != right._g)
			{
				return left._g < right._g;
			}
			if (left._h != right._h)
			{
				return left._h < right._h;
			}
			if (left._i != right._i)
			{
				return left._i < right._i;
			}
			if (left._j != right._j)
			{
				return left._j < right._j;
			}
			return left._k != right._k && left._k < right._k;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0003B90C File Offset: 0x00039B0C
		public static bool operator <=(Guid left, Guid right)
		{
			if (left._a != right._a)
			{
				return left._a < right._a;
			}
			if (left._b != right._b)
			{
				return left._b < right._b;
			}
			if (left._c != right._c)
			{
				return left._c < right._c;
			}
			if (left._d != right._d)
			{
				return left._d < right._d;
			}
			if (left._e != right._e)
			{
				return left._e < right._e;
			}
			if (left._f != right._f)
			{
				return left._f < right._f;
			}
			if (left._g != right._g)
			{
				return left._g < right._g;
			}
			if (left._h != right._h)
			{
				return left._h < right._h;
			}
			if (left._i != right._i)
			{
				return left._i < right._i;
			}
			if (left._j != right._j)
			{
				return left._j < right._j;
			}
			return left._k == right._k || left._k < right._k;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0003BA5C File Offset: 0x00039C5C
		public static bool operator >(Guid left, Guid right)
		{
			if (left._a != right._a)
			{
				return left._a > right._a;
			}
			if (left._b != right._b)
			{
				return left._b > right._b;
			}
			if (left._c != right._c)
			{
				return left._c > right._c;
			}
			if (left._d != right._d)
			{
				return left._d > right._d;
			}
			if (left._e != right._e)
			{
				return left._e > right._e;
			}
			if (left._f != right._f)
			{
				return left._f > right._f;
			}
			if (left._g != right._g)
			{
				return left._g > right._g;
			}
			if (left._h != right._h)
			{
				return left._h > right._h;
			}
			if (left._i != right._i)
			{
				return left._i > right._i;
			}
			if (left._j != right._j)
			{
				return left._j > right._j;
			}
			return left._k != right._k && left._k > right._k;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0003BBAC File Offset: 0x00039DAC
		public static bool operator >=(Guid left, Guid right)
		{
			if (left._a != right._a)
			{
				return left._a > right._a;
			}
			if (left._b != right._b)
			{
				return left._b > right._b;
			}
			if (left._c != right._c)
			{
				return left._c > right._c;
			}
			if (left._d != right._d)
			{
				return left._d > right._d;
			}
			if (left._e != right._e)
			{
				return left._e > right._e;
			}
			if (left._f != right._f)
			{
				return left._f > right._f;
			}
			if (left._g != right._g)
			{
				return left._g > right._g;
			}
			if (left._h != right._h)
			{
				return left._h > right._h;
			}
			if (left._i != right._i)
			{
				return left._i > right._i;
			}
			if (left._j != right._j)
			{
				return left._j > right._j;
			}
			return left._k == right._k || left._k > right._k;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0003BCF9 File Offset: 0x00039EF9
		[NullableContext(1)]
		public static Guid Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return Guid.Parse(s);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0003BD01 File Offset: 0x00039F01
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out Guid result)
		{
			return Guid.TryParse(s, out result);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0003BD0A File Offset: 0x00039F0A
		public static Guid Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return Guid.Parse(s);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0003BD12 File Offset: 0x00039F12
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out Guid result)
		{
			return Guid.TryParse(s, out result);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0003BD1B File Offset: 0x00039F1B
		[DoesNotReturn]
		private static void ThrowBadGuidFormatSpecification()
		{
			throw new FormatException(SR.Format_InvalidGuidFormatSpecification);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0003BD28 File Offset: 0x00039F28
		public unsafe static Guid NewGuid()
		{
			Guid result;
			int num = Interop.Ole32.CoCreateGuid(&result);
			if (num != 0)
			{
				Guid.ThrowForHr(num);
			}
			return result;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0003BD48 File Offset: 0x00039F48
		private static void ThrowForHr(int hr)
		{
			throw new Exception
			{
				HResult = hr
			};
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0003BD58 File Offset: 0x00039F58
		[CompilerGenerated]
		internal static bool <TryParseExactD>g__TryCompatParsing|46_0(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			uint num;
			if (Guid.TryParseHex(guidString.Slice(0, 8), out result._a) && Guid.TryParseHex(guidString.Slice(9, 4), out num))
			{
				result._b = (ushort)num;
				if (Guid.TryParseHex(guidString.Slice(14, 4), out num))
				{
					result._c = (ushort)num;
					if (Guid.TryParseHex(guidString.Slice(19, 4), out num))
					{
						if (!BitConverter.IsLittleEndian)
						{
						}
						result._de = BinaryPrimitives.ReverseEndianness((ushort)num);
						if (Guid.TryParseHex(guidString.Slice(24, 4), out num))
						{
							if (!BitConverter.IsLittleEndian)
							{
							}
							result._fg = BinaryPrimitives.ReverseEndianness((ushort)num);
							if (Number.TryParseBinaryIntegerHexNumberStyle<char, uint>(guidString.Slice(28, 8), NumberStyles.AllowHexSpecifier, out num) == Number.ParsingStatus.OK)
							{
								if (!BitConverter.IsLittleEndian)
								{
								}
								result._hijk = BinaryPrimitives.ReverseEndianness(num);
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x04000487 RID: 1159
		public static readonly Guid Empty;

		// Token: 0x04000488 RID: 1160
		private readonly int _a;

		// Token: 0x04000489 RID: 1161
		private readonly short _b;

		// Token: 0x0400048A RID: 1162
		private readonly short _c;

		// Token: 0x0400048B RID: 1163
		private readonly byte _d;

		// Token: 0x0400048C RID: 1164
		private readonly byte _e;

		// Token: 0x0400048D RID: 1165
		private readonly byte _f;

		// Token: 0x0400048E RID: 1166
		private readonly byte _g;

		// Token: 0x0400048F RID: 1167
		private readonly byte _h;

		// Token: 0x04000490 RID: 1168
		private readonly byte _i;

		// Token: 0x04000491 RID: 1169
		private readonly byte _j;

		// Token: 0x04000492 RID: 1170
		private readonly byte _k;

		// Token: 0x02000134 RID: 308
		private enum GuidParseThrowStyle : byte
		{
			// Token: 0x04000494 RID: 1172
			None,
			// Token: 0x04000495 RID: 1173
			All,
			// Token: 0x04000496 RID: 1174
			AllButOverflow
		}

		// Token: 0x02000135 RID: 309
		private enum ParseFailure
		{
			// Token: 0x04000498 RID: 1176
			Format_ExtraJunkAtEnd,
			// Token: 0x04000499 RID: 1177
			Format_GuidBraceAfterLastNumber,
			// Token: 0x0400049A RID: 1178
			Format_GuidBrace,
			// Token: 0x0400049B RID: 1179
			Format_GuidComma,
			// Token: 0x0400049C RID: 1180
			Format_GuidDashes,
			// Token: 0x0400049D RID: 1181
			Format_GuidEndBrace,
			// Token: 0x0400049E RID: 1182
			Format_GuidHexPrefix,
			// Token: 0x0400049F RID: 1183
			Format_GuidInvalidChar,
			// Token: 0x040004A0 RID: 1184
			Format_GuidInvLen,
			// Token: 0x040004A1 RID: 1185
			Format_GuidUnrecognized,
			// Token: 0x040004A2 RID: 1186
			Overflow_Byte,
			// Token: 0x040004A3 RID: 1187
			Overflow_UInt32
		}

		// Token: 0x02000136 RID: 310
		[StructLayout(LayoutKind.Explicit)]
		private struct GuidResult
		{
			// Token: 0x06001299 RID: 4761 RVA: 0x0003BE36 File Offset: 0x0003A036
			internal GuidResult(Guid.GuidParseThrowStyle canThrow)
			{
				this = default(Guid.GuidResult);
				this._throwStyle = canThrow;
			}

			// Token: 0x0600129A RID: 4762 RVA: 0x0003BE48 File Offset: 0x0003A048
			internal readonly void SetFailure(Guid.ParseFailure failureKind)
			{
				if (this._throwStyle == Guid.GuidParseThrowStyle.None)
				{
					return;
				}
				if (failureKind == Guid.ParseFailure.Overflow_UInt32 && this._throwStyle == Guid.GuidParseThrowStyle.All)
				{
					throw new OverflowException(SR.Overflow_UInt32);
				}
				string message;
				switch (failureKind)
				{
				case Guid.ParseFailure.Format_ExtraJunkAtEnd:
					message = SR.Format_ExtraJunkAtEnd;
					break;
				case Guid.ParseFailure.Format_GuidBraceAfterLastNumber:
					message = SR.Format_GuidBraceAfterLastNumber;
					break;
				case Guid.ParseFailure.Format_GuidBrace:
					message = SR.Format_GuidBrace;
					break;
				case Guid.ParseFailure.Format_GuidComma:
					message = SR.Format_GuidComma;
					break;
				case Guid.ParseFailure.Format_GuidDashes:
					message = SR.Format_GuidDashes;
					break;
				case Guid.ParseFailure.Format_GuidEndBrace:
					message = SR.Format_GuidEndBrace;
					break;
				case Guid.ParseFailure.Format_GuidHexPrefix:
					message = SR.Format_GuidHexPrefix;
					break;
				case Guid.ParseFailure.Format_GuidInvalidChar:
					message = SR.Format_GuidInvalidChar;
					break;
				case Guid.ParseFailure.Format_GuidInvLen:
					message = SR.Format_GuidInvLen;
					break;
				default:
					message = SR.Format_GuidUnrecognized;
					break;
				}
				throw new FormatException(message);
			}

			// Token: 0x0600129B RID: 4763 RVA: 0x0003BEF7 File Offset: 0x0003A0F7
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe readonly Guid ToGuid()
			{
				return *Unsafe.As<Guid.GuidResult, Guid>(Unsafe.AsRef<Guid.GuidResult>(ref this));
			}

			// Token: 0x040004A4 RID: 1188
			[FieldOffset(0)]
			internal uint _a;

			// Token: 0x040004A5 RID: 1189
			[FieldOffset(4)]
			internal uint _bc;

			// Token: 0x040004A6 RID: 1190
			[FieldOffset(4)]
			internal ushort _b;

			// Token: 0x040004A7 RID: 1191
			[FieldOffset(6)]
			internal ushort _c;

			// Token: 0x040004A8 RID: 1192
			[FieldOffset(8)]
			internal uint _defg;

			// Token: 0x040004A9 RID: 1193
			[FieldOffset(8)]
			internal ushort _de;

			// Token: 0x040004AA RID: 1194
			[FieldOffset(8)]
			internal byte _d;

			// Token: 0x040004AB RID: 1195
			[FieldOffset(10)]
			internal ushort _fg;

			// Token: 0x040004AC RID: 1196
			[FieldOffset(12)]
			internal uint _hijk;

			// Token: 0x040004AD RID: 1197
			[FieldOffset(16)]
			private readonly Guid.GuidParseThrowStyle _throwStyle;
		}
	}
}
