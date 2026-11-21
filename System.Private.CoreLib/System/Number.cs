using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;

namespace System
{
	// Token: 0x02000179 RID: 377
	internal static class Number
	{
		// Token: 0x060018B7 RID: 6327 RVA: 0x0004CF60 File Offset: 0x0004B160
		public unsafe static void Dragon4<[IsUnmanaged] TNumber>(TNumber value, int cutoffNumber, bool isSignificantDigits, ref Number.NumberBuffer number) where TNumber : struct, ValueType, IBinaryFloatParseAndFormatInfo<TNumber>
		{
			if (INumberBase<TNumber>.IsNegative(value))
			{
				-value;
			}
			int exponent;
			ulong num = Number.ExtractFractionAndBiasedExponent<TNumber>(value, out exponent);
			bool hasUnequalMargins = false;
			uint mantissaHighBitIdx;
			if (num >> (int)IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaBits != 0UL)
			{
				mantissaHighBitIdx = (uint)IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaBits;
				hasUnequalMargins = (num == 1UL << (int)(IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaBits & 31));
			}
			else
			{
				mantissaHighBitIdx = (uint)BitOperations.Log2(num);
			}
			int num3;
			int num2 = (int)Number.Dragon4(num, exponent, mantissaHighBitIdx, hasUnequalMargins, cutoffNumber, isSignificantDigits, number.Digits, out num3);
			number.Scale = num3 + 1;
			*number.Digits[num2] = 0;
			number.DigitsCount = num2;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0004D008 File Offset: 0x0004B208
		private unsafe static uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, int cutoffNumber, bool isSignificantDigits, Span<byte> buffer, out int decimalExponent)
		{
			int num = 0;
			Number.BigInteger bigInteger;
			Number.BigInteger bigInteger2;
			Number.BigInteger bigInteger3;
			Number.BigInteger* ptr;
			if (hasUnequalMargins)
			{
				Number.BigInteger bigInteger4;
				if (exponent > 0)
				{
					Number.BigInteger.SetUInt64(out bigInteger, 4UL * mantissa);
					bigInteger.ShiftLeft((uint)exponent);
					Number.BigInteger.SetUInt32(out bigInteger2, 4U);
					Number.BigInteger.Pow2((uint)exponent, out bigInteger3);
					Number.BigInteger.Pow2((uint)(exponent + 1), out bigInteger4);
				}
				else
				{
					Number.BigInteger.SetUInt64(out bigInteger, 4UL * mantissa);
					Number.BigInteger.Pow2((uint)(-exponent + 2), out bigInteger2);
					Number.BigInteger.SetUInt32(out bigInteger3, 1U);
					Number.BigInteger.SetUInt32(out bigInteger4, 2U);
				}
				ptr = &bigInteger4;
			}
			else
			{
				if (exponent > 0)
				{
					Number.BigInteger.SetUInt64(out bigInteger, 2UL * mantissa);
					bigInteger.ShiftLeft((uint)exponent);
					Number.BigInteger.SetUInt32(out bigInteger2, 2U);
					Number.BigInteger.Pow2((uint)exponent, out bigInteger3);
				}
				else
				{
					Number.BigInteger.SetUInt64(out bigInteger, 2UL * mantissa);
					Number.BigInteger.Pow2((uint)(-exponent + 1), out bigInteger2);
					Number.BigInteger.SetUInt32(out bigInteger3, 1U);
				}
				ptr = &bigInteger3;
			}
			int num2 = (int)Math.Ceiling((double)(mantissaHighBitIdx + (uint)exponent) * 0.3010299956639812 - 0.69);
			if (num2 > 0)
			{
				bigInteger2.MultiplyPow10((uint)num2);
			}
			else if (num2 < 0)
			{
				Number.BigInteger bigInteger5;
				Number.BigInteger.Pow10((uint)(-(uint)num2), out bigInteger5);
				bigInteger.Multiply(ref bigInteger5);
				bigInteger3.Multiply(ref bigInteger5);
				if (ptr != &bigInteger3)
				{
					Number.BigInteger.Multiply(ref bigInteger3, 2U, out *ptr);
				}
			}
			bool flag = mantissa % 2UL == 0UL;
			bool flag2;
			if (cutoffNumber == -1)
			{
				Number.BigInteger bigInteger6;
				Number.BigInteger.Add(ref bigInteger, ref *ptr, out bigInteger6);
				int num3 = Number.BigInteger.Compare(ref bigInteger6, ref bigInteger2);
				flag2 = (flag ? (num3 >= 0) : (num3 > 0));
			}
			else
			{
				flag2 = (Number.BigInteger.Compare(ref bigInteger, ref bigInteger2) >= 0);
			}
			if (flag2)
			{
				num2++;
			}
			else
			{
				bigInteger.Multiply10();
				bigInteger3.Multiply10();
				if (ptr != &bigInteger3)
				{
					Number.BigInteger.Multiply(ref bigInteger3, 2U, out *ptr);
				}
			}
			int num4 = num2 - buffer.Length;
			if (cutoffNumber != -1)
			{
				int num5;
				if (isSignificantDigits)
				{
					num5 = num2 - cutoffNumber;
				}
				else
				{
					num5 = -cutoffNumber;
				}
				if (num5 > num4)
				{
					num4 = num5;
				}
			}
			num2 = (decimalExponent = num2 - 1);
			uint block = bigInteger2.GetBlock((uint)(bigInteger2.GetLength() - 1));
			if (block < 8U || block > 429496729U)
			{
				uint num6 = (uint)BitOperations.Log2(block);
				uint shift = (59U - num6) % 32U;
				bigInteger2.ShiftLeft(shift);
				bigInteger.ShiftLeft(shift);
				bigInteger3.ShiftLeft(shift);
				if (ptr != &bigInteger3)
				{
					Number.BigInteger.Multiply(ref bigInteger3, 2U, out *ptr);
				}
			}
			uint num7;
			bool flag3;
			bool flag4;
			if (cutoffNumber == -1)
			{
				for (;;)
				{
					num7 = Number.BigInteger.HeuristicDivide(ref bigInteger, ref bigInteger2);
					Number.BigInteger bigInteger7;
					Number.BigInteger.Add(ref bigInteger, ref *ptr, out bigInteger7);
					int num8 = Number.BigInteger.Compare(ref bigInteger, ref bigInteger3);
					int num9 = Number.BigInteger.Compare(ref bigInteger7, ref bigInteger2);
					if (flag)
					{
						flag3 = (num8 <= 0);
						flag4 = (num9 >= 0);
					}
					else
					{
						flag3 = (num8 < 0);
						flag4 = (num9 > 0);
					}
					if (flag3 || flag4 || num2 == num4)
					{
						break;
					}
					*buffer[num] = (byte)(48U + num7);
					num++;
					bigInteger.Multiply10();
					bigInteger3.Multiply10();
					if (ptr != &bigInteger3)
					{
						Number.BigInteger.Multiply(ref bigInteger3, 2U, out *ptr);
					}
					num2--;
				}
			}
			else
			{
				if (num2 < num4)
				{
					num7 = Number.BigInteger.HeuristicDivide(ref bigInteger, ref bigInteger2);
					if (num7 > 5U || (num7 == 5U && !bigInteger.IsZero()))
					{
						decimalExponent++;
						num7 = 1U;
					}
					*buffer[num] = (byte)(48U + num7);
					return (uint)(num + 1);
				}
				flag3 = false;
				flag4 = false;
				for (;;)
				{
					num7 = Number.BigInteger.HeuristicDivide(ref bigInteger, ref bigInteger2);
					if (bigInteger.IsZero() || num2 <= num4)
					{
						break;
					}
					*buffer[num] = (byte)(48U + num7);
					num++;
					bigInteger.Multiply10();
					num2--;
				}
			}
			bool flag5 = flag3;
			if (flag3 == flag4)
			{
				bigInteger.ShiftLeft(1U);
				int num10 = Number.BigInteger.Compare(ref bigInteger, ref bigInteger2);
				flag5 = (num10 < 0);
				if (num10 == 0)
				{
					flag5 = ((num7 & 1U) == 0U);
				}
			}
			if (flag5)
			{
				*buffer[num] = (byte)(48U + num7);
				num++;
			}
			else if (num7 == 9U)
			{
				while (num != 0)
				{
					num--;
					if (*buffer[num] != 57)
					{
						ref byte ptr2 = ref buffer[num];
						ptr2 += 1;
						return (uint)(num + 1);
					}
				}
				*buffer[num] = 49;
				num++;
				decimalExponent++;
			}
			else
			{
				*buffer[num] = (byte)(48U + num7 + 1U);
				num++;
			}
			return (uint)num;
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0004D410 File Offset: 0x0004B610
		public unsafe static string FormatDecimal(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
			int nMaxDigits;
			char c = Number.ParseFormatSpecifier(format, out nMaxDigits);
			byte* digits = stackalloc byte[(UIntPtr)31];
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Decimal, digits, 31);
			Number.DecimalToNumber(ref value, ref numberBuffer);
			char* pointer = stackalloc char[(UIntPtr)64];
			ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(new Span<char>((void*)pointer, 32));
			if (c != '\0')
			{
				Number.NumberToString<char>(ref valueListBuilder, ref numberBuffer, c, nMaxDigits, info);
			}
			else
			{
				Number.NumberToStringFormat<char>(ref valueListBuilder, ref numberBuffer, format, info);
			}
			string result = valueListBuilder.AsSpan().ToString();
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0004D490 File Offset: 0x0004B690
		public unsafe static bool TryFormatDecimal<[IsUnmanaged] TChar>(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int nMaxDigits;
			char c = Number.ParseFormatSpecifier(format, out nMaxDigits);
			byte* digits = stackalloc byte[(UIntPtr)31];
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Decimal, digits, 31);
			Number.DecimalToNumber(ref value, ref numberBuffer);
			TChar* pointer = stackalloc TChar[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(TChar))];
			ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(new Span<TChar>((void*)pointer, 32));
			if (c != '\0')
			{
				Number.NumberToString<TChar>(ref valueListBuilder, ref numberBuffer, c, nMaxDigits, info);
			}
			else
			{
				Number.NumberToStringFormat<TChar>(ref valueListBuilder, ref numberBuffer, format, info);
			}
			bool result = valueListBuilder.TryCopyTo(destination, out charsWritten);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0004D50C File Offset: 0x0004B70C
		internal unsafe static void DecimalToNumber([ScopedRef] ref decimal d, ref Number.NumberBuffer number)
		{
			byte* digitsPtr = number.DigitsPtr;
			number.DigitsCount = 29;
			number.IsNegative = decimal.IsNegative(d);
			byte* ptr = digitsPtr + 29;
			while ((d.Mid | d.High) != 0U)
			{
				ptr = Number.UInt32ToDecChars<byte>(ptr, decimal.DecDivMod1E9(ref d), 9);
			}
			ptr = Number.UInt32ToDecChars<byte>(ptr, d.Low, 0);
			int num = (int)((long)(digitsPtr + 29 - ptr));
			number.DigitsCount = num;
			number.Scale = num - (int)d.Scale;
			byte* digitsPtr2 = number.DigitsPtr;
			while (--num >= 0)
			{
				*(digitsPtr2++) = *(ptr++);
			}
			*digitsPtr2 = 0;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0004D5AC File Offset: 0x0004B7AC
		private static int GetFloatingPointMaxDigitsAndPrecision(char fmt, ref int precision, NumberFormatInfo info, out bool isSignificantDigits)
		{
			if (fmt == '\0')
			{
				isSignificantDigits = true;
				return precision;
			}
			int result = precision;
			if (fmt <= 'R')
			{
				switch (fmt)
				{
				case 'C':
					break;
				case 'D':
					goto IL_EF;
				case 'E':
					goto IL_9E;
				case 'F':
					goto IL_B1;
				case 'G':
					goto IL_C3;
				default:
					switch (fmt)
					{
					case 'N':
						goto IL_B1;
					case 'O':
					case 'Q':
						goto IL_EF;
					case 'P':
						goto IL_CF;
					case 'R':
						goto IL_E7;
					default:
						goto IL_EF;
					}
					break;
				}
			}
			else
			{
				switch (fmt)
				{
				case 'c':
					break;
				case 'd':
					goto IL_EF;
				case 'e':
					goto IL_9E;
				case 'f':
					goto IL_B1;
				case 'g':
					goto IL_C3;
				default:
					switch (fmt)
					{
					case 'n':
						goto IL_B1;
					case 'o':
					case 'q':
						goto IL_EF;
					case 'p':
						goto IL_CF;
					case 'r':
						goto IL_E7;
					default:
						goto IL_EF;
					}
					break;
				}
			}
			if (precision == -1)
			{
				precision = info.CurrencyDecimalDigits;
			}
			isSignificantDigits = false;
			return result;
			IL_9E:
			if (precision == -1)
			{
				precision = 6;
			}
			precision++;
			isSignificantDigits = true;
			return result;
			IL_B1:
			if (precision == -1)
			{
				precision = info.NumberDecimalDigits;
			}
			isSignificantDigits = false;
			return result;
			IL_C3:
			if (precision == 0)
			{
				precision = -1;
			}
			isSignificantDigits = true;
			return result;
			IL_CF:
			if (precision == -1)
			{
				precision = info.PercentDecimalDigits;
			}
			precision += 2;
			isSignificantDigits = false;
			return result;
			IL_E7:
			precision = -1;
			isSignificantDigits = true;
			return result;
			IL_EF:
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			goto IL_E7;
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0004D6B0 File Offset: 0x0004B8B0
		public unsafe static string FormatFloat<[IsUnmanaged] TNumber>(TNumber value, string format, NumberFormatInfo info) where TNumber : struct, ValueType, IBinaryFloatParseAndFormatInfo<TNumber>
		{
			Span<char> initialSpan = new Span<char>(stackalloc byte[(UIntPtr)64], 32);
			ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(initialSpan);
			string result = Number.FormatFloat<TNumber, char>(ref valueListBuilder, value, format, info) ?? valueListBuilder.AsSpan().ToString();
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0004D704 File Offset: 0x0004B904
		public unsafe static bool TryFormatFloat<[IsUnmanaged] TNumber, [IsUnmanaged] TChar>(TNumber value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<TChar> destination, out int charsWritten) where TNumber : struct, ValueType, IBinaryFloatParseAndFormatInfo<TNumber> where TChar : struct, ValueType, IUtfChar<TChar>
		{
			Span<TChar> initialSpan = new Span<TChar>(stackalloc byte[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(TChar))], 32);
			ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(initialSpan);
			string text = Number.FormatFloat<TNumber, TChar>(ref valueListBuilder, value, format, info);
			bool result = (text != null) ? Number.TryCopyTo<TChar>(text, destination, out charsWritten) : valueListBuilder.TryCopyTo(destination, out charsWritten);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0004D758 File Offset: 0x0004B958
		private unsafe static string FormatFloat<[IsUnmanaged] TNumber, [IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, TNumber value, ReadOnlySpan<char> format, NumberFormatInfo info) where TNumber : struct, ValueType, IBinaryFloatParseAndFormatInfo<TNumber> where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (INumberBase<TNumber>.IsFinite(value))
			{
				int maxPrecisionCustomFormat;
				char c = Number.ParseFormatSpecifier(format, out maxPrecisionCustomFormat);
				byte* digits = stackalloc byte[(UIntPtr)IBinaryFloatParseAndFormatInfo<TNumber>.NumberBufferLength];
				if (c == '\0')
				{
					maxPrecisionCustomFormat = IBinaryFloatParseAndFormatInfo<TNumber>.MaxPrecisionCustomFormat;
				}
				Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.FloatingPoint, digits, IBinaryFloatParseAndFormatInfo<TNumber>.NumberBufferLength);
				numberBuffer.IsNegative = INumberBase<TNumber>.IsNegative(value);
				bool flag;
				int nMaxDigits = Number.GetFloatingPointMaxDigitsAndPrecision(c, ref maxPrecisionCustomFormat, info, out flag);
				if (value != default(TNumber) && (!flag || !Number.Grisu3.TryRun<TNumber>(value, maxPrecisionCustomFormat, ref numberBuffer)))
				{
					Number.Dragon4<TNumber>(value, maxPrecisionCustomFormat, flag, ref numberBuffer);
				}
				if (c != '\0')
				{
					if (maxPrecisionCustomFormat == -1)
					{
						nMaxDigits = Math.Max(numberBuffer.DigitsCount, IBinaryFloatParseAndFormatInfo<TNumber>.MaxRoundTripDigits);
					}
					Number.NumberToString<TChar>(ref vlb, ref numberBuffer, c, nMaxDigits, info);
				}
				else
				{
					Number.NumberToStringFormat<TChar>(ref vlb, ref numberBuffer, format, info);
				}
				return null;
			}
			if (INumberBase<TNumber>.IsNaN(value))
			{
				if (typeof(TChar) == typeof(char))
				{
					return info.NaNSymbol;
				}
				vlb.Append(info.NaNSymbolTChar<TChar>());
				return null;
			}
			else
			{
				if (!(typeof(TChar) == typeof(char)))
				{
					vlb.Append(INumberBase<TNumber>.IsNegative(value) ? info.NegativeInfinitySymbolTChar<TChar>() : info.PositiveInfinitySymbolTChar<TChar>());
					return null;
				}
				if (!INumberBase<TNumber>.IsNegative(value))
				{
					return info.PositiveInfinitySymbol;
				}
				return info.NegativeInfinitySymbol;
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0004D8D4 File Offset: 0x0004BAD4
		private static bool TryCopyTo<[IsUnmanaged] TChar>(string source, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (!(typeof(TChar) == typeof(char)))
			{
				return Encoding.UTF8.TryGetBytes(source, Unsafe.BitCast<Span<TChar>, Span<byte>>(destination), out charsWritten);
			}
			if (source.TryCopyTo(Unsafe.BitCast<Span<TChar>, Span<char>>(destination)))
			{
				charsWritten = source.Length;
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0004D930 File Offset: 0x0004BB30
		internal static char GetHexBase(char fmt)
		{
			return fmt - '!';
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0004D937 File Offset: 0x0004BB37
		public static string FormatInt32(int value, int hexMask, string format, IFormatProvider provider)
		{
			if (!string.IsNullOrEmpty(format))
			{
				return Number.<FormatInt32>g__FormatInt32Slow|18_0(value, hexMask, format, provider);
			}
			if (value < 0)
			{
				return Number.NegativeInt32ToDecStr(value, -1, NumberFormatInfo.GetInstance(provider).NegativeSign);
			}
			return Number.UInt32ToDecStr((uint)value);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0004D968 File Offset: 0x0004BB68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryFormatInt32<[IsUnmanaged] TChar>(int value, int hexMask, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length != 0)
			{
				return Number.<TryFormatInt32>g__TryFormatInt32Slow|19_0<TChar>(value, hexMask, format, provider, destination, out charsWritten);
			}
			if (value < 0)
			{
				return Number.TryNegativeInt32ToDecStr<TChar>(value, -1, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
			}
			return Number.TryUInt32ToDecStr<TChar>((uint)value, destination, out charsWritten);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0004D9A6 File Offset: 0x0004BBA6
		public static string FormatUInt32(uint value, string format, IFormatProvider provider)
		{
			if (string.IsNullOrEmpty(format))
			{
				return Number.UInt32ToDecStr(value);
			}
			return Number.<FormatUInt32>g__FormatUInt32Slow|20_0(value, format, provider);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0004D9BF File Offset: 0x0004BBBF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryFormatUInt32<[IsUnmanaged] TChar>(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length == 0)
			{
				return Number.TryUInt32ToDecStr<TChar>(value, destination, out charsWritten);
			}
			return Number.<TryFormatUInt32>g__TryFormatUInt32Slow|21_0<TChar>(value, format, provider, destination, out charsWritten);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0004D9DF File Offset: 0x0004BBDF
		public static string FormatInt64(long value, string format, IFormatProvider provider)
		{
			if (!string.IsNullOrEmpty(format))
			{
				return Number.<FormatInt64>g__FormatInt64Slow|22_0(value, format, provider);
			}
			if (value < 0L)
			{
				return Number.NegativeInt64ToDecStr(value, -1, NumberFormatInfo.GetInstance(provider).NegativeSign);
			}
			return Number.UInt64ToDecStr((ulong)value);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0004DA10 File Offset: 0x0004BC10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryFormatInt64<[IsUnmanaged] TChar>(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length != 0)
			{
				return Number.<TryFormatInt64>g__TryFormatInt64Slow|23_0<TChar>(value, format, provider, destination, out charsWritten);
			}
			if (value < 0L)
			{
				return Number.TryNegativeInt64ToDecStr<TChar>(value, -1, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
			}
			return Number.TryUInt64ToDecStr<TChar>((ulong)value, destination, out charsWritten);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0004DA4B File Offset: 0x0004BC4B
		public static string FormatUInt64(ulong value, string format, IFormatProvider provider)
		{
			if (string.IsNullOrEmpty(format))
			{
				return Number.UInt64ToDecStr(value);
			}
			return Number.<FormatUInt64>g__FormatUInt64Slow|24_0(value, format, provider);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0004DA64 File Offset: 0x0004BC64
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryFormatUInt64<[IsUnmanaged] TChar>(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length == 0)
			{
				return Number.TryUInt64ToDecStr<TChar>(value, destination, out charsWritten);
			}
			return Number.<TryFormatUInt64>g__TryFormatUInt64Slow|25_0<TChar>(value, format, provider, destination, out charsWritten);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0004DA84 File Offset: 0x0004BC84
		public static string FormatInt128(Int128 value, string format, IFormatProvider provider)
		{
			if (!string.IsNullOrEmpty(format))
			{
				return Number.<FormatInt128>g__FormatInt128Slow|26_0(value, format, provider);
			}
			if (!Int128.IsPositive(value))
			{
				return Number.NegativeInt128ToDecStr(value, -1, NumberFormatInfo.GetInstance(provider).NegativeSign);
			}
			return Number.UInt128ToDecStr((UInt128)value, -1);
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
		public static bool TryFormatInt128<[IsUnmanaged] TChar>(Int128 value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length != 0)
			{
				return Number.<TryFormatInt128>g__TryFormatInt128Slow|27_0<TChar>(value, format, provider, destination, out charsWritten);
			}
			if (!Int128.IsPositive(value))
			{
				return Number.TryNegativeInt128ToDecStr<TChar>(value, -1, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
			}
			return Number.TryUInt128ToDecStr<TChar>((UInt128)value, -1, destination, out charsWritten);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0004DB0F File Offset: 0x0004BD0F
		public static string FormatUInt128(UInt128 value, string format, IFormatProvider provider)
		{
			if (string.IsNullOrEmpty(format))
			{
				return Number.UInt128ToDecStr(value, -1);
			}
			return Number.<FormatUInt128>g__FormatUInt128Slow|28_0(value, format, provider);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0004DB29 File Offset: 0x0004BD29
		public static bool TryFormatUInt128<[IsUnmanaged] TChar>(UInt128 value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length == 0)
			{
				return Number.TryUInt128ToDecStr<TChar>(value, -1, destination, out charsWritten);
			}
			return Number.<TryFormatUInt128>g__TryFormatUInt128Slow|29_0<TChar>(value, format, provider, destination, out charsWritten);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0004DB4C File Offset: 0x0004BD4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void Int32ToNumber(int value, ref Number.NumberBuffer number)
		{
			number.DigitsCount = 10;
			if (value >= 0)
			{
				number.IsNegative = false;
			}
			else
			{
				number.IsNegative = true;
				value = -value;
			}
			byte* digitsPtr = number.DigitsPtr;
			byte* ptr = Number.UInt32ToDecChars<byte>(digitsPtr + 10, (uint)value, 0);
			int num = (int)((long)(digitsPtr + 10 - ptr));
			number.DigitsCount = num;
			number.Scale = num;
			byte* digitsPtr2 = number.DigitsPtr;
			while (--num >= 0)
			{
				*(digitsPtr2++) = *(ptr++);
			}
			*digitsPtr2 = 0;
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0004DBC3 File Offset: 0x0004BDC3
		public static string Int32ToDecStr(int value)
		{
			if (value < 0)
			{
				return Number.NegativeInt32ToDecStr(value, -1, NumberFormatInfo.CurrentInfo.NegativeSign);
			}
			return Number.UInt32ToDecStr((uint)value);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0004DBE4 File Offset: 0x0004BDE4
		private unsafe static string NegativeInt32ToDecStr(int value, int digits, string sNegative)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, FormattingHelpers.CountDigits((uint)(-(uint)value))) + sNegative.Length;
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3 = Number.UInt32ToDecChars<char>(ptr + num, (uint)(-(uint)value), digits);
			for (int i = sNegative.Length - 1; i >= 0; i--)
			{
				*(--ptr3) = sNegative[i];
			}
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0004DC5C File Offset: 0x0004BE5C
		internal unsafe static bool TryNegativeInt32ToDecStr<[IsUnmanaged] TChar>(int value, int digits, ReadOnlySpan<TChar> sNegative, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, FormattingHelpers.CountDigits((uint)(-(uint)value))) + sNegative.Length;
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = Number.UInt32ToDecChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), (uint)(-(uint)value), digits);
				for (int i = sNegative.Length - 1; i >= 0; i--)
				{
					*(ptr -= sizeof(TChar) / sizeof(TChar)) = *sNegative[i];
				}
			}
			return true;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0004DCEC File Offset: 0x0004BEEC
		private unsafe static string Int32ToHexStr(int value, char hexBase, int digits)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, FormattingHelpers.CountHexDigits((ulong)value));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.Int32ToHexChars<char>(ptr + num, (uint)value, (int)hexBase, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0004DD38 File Offset: 0x0004BF38
		internal unsafe static bool TryInt32ToHexStr<[IsUnmanaged] TChar>(int value, char hexBase, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, FormattingHelpers.CountHexDigits((ulong)value));
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				Number.Int32ToHexChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), (uint)value, (int)hexBase, digits);
			}
			return true;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0004DD90 File Offset: 0x0004BF90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static TChar* Int32ToHexChars<[IsUnmanaged] TChar>(TChar* buffer, uint value, int hexBase, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			while (--digits >= 0 || value != 0U)
			{
				byte b = (byte)(value & 15U);
				*(buffer -= sizeof(TChar) / sizeof(TChar)) = IUtfChar<TChar>.CastFrom((int)b + ((b < 10) ? 48 : hexBase));
				value >>= 4;
			}
			return buffer;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0004DDE0 File Offset: 0x0004BFE0
		private unsafe static string UInt32ToBinaryStr(uint value, int digits)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, (int)(32U - uint.LeadingZeroCount(value)));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt32ToBinaryChars<char>(ptr + num, value, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0004DE2C File Offset: 0x0004C02C
		private unsafe static bool TryUInt32ToBinaryStr<[IsUnmanaged] TChar>(uint value, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, (int)(32U - uint.LeadingZeroCount(value)));
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				Number.UInt32ToBinaryChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), value, digits);
			}
			return true;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0004DE81 File Offset: 0x0004C081
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static TChar* UInt32ToBinaryChars<[IsUnmanaged] TChar>(TChar* buffer, uint value, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			while (--digits >= 0 || value != 0U)
			{
				*(buffer -= sizeof(TChar) / sizeof(TChar)) = IUtfChar<TChar>.CastFrom((int)(48 + (byte)(value & 1U)));
				value >>= 1;
			}
			return buffer;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0004DEBC File Offset: 0x0004C0BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void UInt32ToNumber(uint value, ref Number.NumberBuffer number)
		{
			number.DigitsCount = 10;
			number.IsNegative = false;
			byte* digitsPtr = number.DigitsPtr;
			byte* ptr = Number.UInt32ToDecChars<byte>(digitsPtr + 10, value, 0);
			int num = (int)((long)(digitsPtr + 10 - ptr));
			number.DigitsCount = num;
			number.Scale = num;
			byte* digitsPtr2 = number.DigitsPtr;
			while (--num >= 0)
			{
				*(digitsPtr2++) = *(ptr++);
			}
			*digitsPtr2 = 0;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0004DF24 File Offset: 0x0004C124
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void WriteTwoDigits<[IsUnmanaged] TChar>(uint value, TChar* ptr) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			Unsafe.CopyBlockUnaligned(ref *(byte*)ptr, Unsafe.Add<byte>(MemoryMarshal.GetArrayDataReference<byte>((typeof(TChar) == typeof(char)) ? Number.TwoDigitsCharsAsBytes : Number.TwoDigitsBytes), (UIntPtr)(sizeof(TChar) * 2 * (int)value)), (uint)(sizeof(TChar) * 2));
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0004DF7C File Offset: 0x0004C17C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void WriteFourDigits<[IsUnmanaged] TChar>(uint value, TChar* ptr) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			ValueTuple<uint, uint> valueTuple = Math.DivRem(value, 100U);
			value = valueTuple.Item1;
			uint item = valueTuple.Item2;
			ref byte arrayDataReference = ref MemoryMarshal.GetArrayDataReference<byte>((typeof(TChar) == typeof(char)) ? Number.TwoDigitsCharsAsBytes : Number.TwoDigitsBytes);
			Unsafe.CopyBlockUnaligned(ref *(byte*)ptr, Unsafe.Add<byte>(ref arrayDataReference, (UIntPtr)(sizeof(TChar) * 2 * (int)value)), (uint)(sizeof(TChar) * 2));
			Unsafe.CopyBlockUnaligned(ref *(byte*)(ptr + (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)), Unsafe.Add<byte>(ref arrayDataReference, (UIntPtr)(sizeof(TChar) * 2 * (int)item)), (uint)(sizeof(TChar) * 2));
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0004E014 File Offset: 0x0004C214
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void WriteDigits<[IsUnmanaged] TChar>(uint value, TChar* ptr, int count) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			TChar* ptr2;
			for (ptr2 = ptr + (IntPtr)count * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar) - sizeof(TChar) / sizeof(TChar); ptr2 != ptr; ptr2 -= sizeof(TChar) / sizeof(TChar))
			{
				uint num = 48U + value;
				value /= 10U;
				*ptr2 = IUtfChar<TChar>.CastFrom(num - value * 10U);
			}
			*ptr2 = IUtfChar<TChar>.CastFrom(48U + value);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0004E07C File Offset: 0x0004C27C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static TChar* UInt32ToDecChars<[IsUnmanaged] TChar>(TChar* bufferEnd, uint value) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (value >= 10U)
			{
				while (value >= 100U)
				{
					bufferEnd -= (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					ValueTuple<uint, uint> valueTuple = Math.DivRem(value, 100U);
					value = valueTuple.Item1;
					Number.WriteTwoDigits<TChar>(valueTuple.Item2, bufferEnd);
				}
				if (value >= 10U)
				{
					bufferEnd -= (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					Number.WriteTwoDigits<TChar>(value, bufferEnd);
					return bufferEnd;
				}
			}
			*(bufferEnd -= sizeof(TChar) / sizeof(TChar)) = IUtfChar<TChar>.CastFrom(value + 48U);
			return bufferEnd;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0004E0F8 File Offset: 0x0004C2F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static TChar* UInt32ToDecChars<[IsUnmanaged] TChar>(TChar* bufferEnd, uint value, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			while (value >= 100U)
			{
				bufferEnd -= (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				digits -= 2;
				ValueTuple<uint, uint> valueTuple = Math.DivRem(value, 100U);
				value = valueTuple.Item1;
				uint item = valueTuple.Item2;
				Number.WriteTwoDigits<TChar>(item, bufferEnd);
			}
			while (value != 0U || digits > 0)
			{
				digits--;
				ValueTuple<uint, uint> valueTuple2 = Math.DivRem(value, 10U);
				value = valueTuple2.Item1;
				uint item = valueTuple2.Item2;
				*(bufferEnd -= sizeof(TChar) / sizeof(TChar)) = IUtfChar<TChar>.CastFrom(item + 48U);
			}
			return bufferEnd;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0004E17F File Offset: 0x0004C37F
		internal static string UInt32ToDecStr(uint value)
		{
			if (value < 10U)
			{
				return Number.UInt32ToDecStrForKnownSmallNumber(value);
			}
			return Number.UInt32ToDecStr_NoSmallNumberCheck(value);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0004E193 File Offset: 0x0004C393
		internal static string UInt32ToDecStrForKnownSmallNumber(uint value)
		{
			return Number.s_smallNumberCache[(int)value] ?? Number.<UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|47_0(value);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0004E1A8 File Offset: 0x0004C3A8
		private unsafe static string UInt32ToDecStr_NoSmallNumberCheck(uint value)
		{
			int num = FormattingHelpers.CountDigits(value);
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt32ToDecChars<char>(ptr + num, value);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0004E1E4 File Offset: 0x0004C3E4
		private unsafe static string UInt32ToDecStr(uint value, int digits)
		{
			if (digits <= 1)
			{
				return Number.UInt32ToDecStr(value);
			}
			int num = Math.Max(digits, FormattingHelpers.CountDigits(value));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt32ToDecChars<char>(ptr + num, value, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0004E230 File Offset: 0x0004C430
		internal unsafe static bool TryUInt32ToDecStr<[IsUnmanaged] TChar>(uint value, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = FormattingHelpers.CountDigits(value);
			if (num <= destination.Length)
			{
				charsWritten = num;
				fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
				{
					Number.UInt32ToDecChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), value);
				}
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0004E274 File Offset: 0x0004C474
		internal unsafe static bool TryUInt32ToDecStr<[IsUnmanaged] TChar>(uint value, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = FormattingHelpers.CountDigits(value);
			int num2 = Math.Max(digits, num);
			if (num2 <= destination.Length)
			{
				charsWritten = num2;
				fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
				{
					TChar* bufferEnd = reference + (IntPtr)num2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					TChar* ptr = (digits > num) ? Number.UInt32ToDecChars<TChar>(bufferEnd, value, digits) : Number.UInt32ToDecChars<TChar>(bufferEnd, value);
				}
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0004E2D0 File Offset: 0x0004C4D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void Int64ToNumber(long value, ref Number.NumberBuffer number)
		{
			number.DigitsCount = 19;
			if (value >= 0L)
			{
				number.IsNegative = false;
			}
			else
			{
				number.IsNegative = true;
				value = -value;
			}
			byte* digitsPtr = number.DigitsPtr;
			byte* ptr = Number.UInt64ToDecChars<byte>(digitsPtr + 19, (ulong)value, 0);
			int num = (int)((long)(digitsPtr + 19 - ptr));
			number.DigitsCount = num;
			number.Scale = num;
			byte* digitsPtr2 = number.DigitsPtr;
			while (--num >= 0)
			{
				*(digitsPtr2++) = *(ptr++);
			}
			*digitsPtr2 = 0;
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0004E348 File Offset: 0x0004C548
		public static string Int64ToDecStr(long value)
		{
			if (value < 0L)
			{
				return Number.NegativeInt64ToDecStr(value, -1, NumberFormatInfo.CurrentInfo.NegativeSign);
			}
			return Number.UInt64ToDecStr((ulong)value);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0004E368 File Offset: 0x0004C568
		private unsafe static string NegativeInt64ToDecStr(long value, int digits, string sNegative)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, FormattingHelpers.CountDigits((ulong)(-(ulong)value))) + sNegative.Length;
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3 = Number.UInt64ToDecChars<char>(ptr + num, (ulong)(-(ulong)value), digits);
			for (int i = sNegative.Length - 1; i >= 0; i--)
			{
				*(--ptr3) = sNegative[i];
			}
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0004E3E0 File Offset: 0x0004C5E0
		internal unsafe static bool TryNegativeInt64ToDecStr<[IsUnmanaged] TChar>(long value, int digits, ReadOnlySpan<TChar> sNegative, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, FormattingHelpers.CountDigits((ulong)(-(ulong)value))) + sNegative.Length;
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = Number.UInt64ToDecChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), (ulong)(-(ulong)value), digits);
				for (int i = sNegative.Length - 1; i >= 0; i--)
				{
					*(ptr -= sizeof(TChar) / sizeof(TChar)) = *sNegative[i];
				}
			}
			return true;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0004E470 File Offset: 0x0004C670
		private unsafe static string Int64ToHexStr(long value, char hexBase, int digits)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, FormattingHelpers.CountHexDigits((ulong)value));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.Int64ToHexChars<char>(ptr + num, (ulong)value, (int)hexBase, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0004E4BC File Offset: 0x0004C6BC
		internal unsafe static bool TryInt64ToHexStr<[IsUnmanaged] TChar>(long value, char hexBase, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, FormattingHelpers.CountHexDigits((ulong)value));
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				Number.Int64ToHexChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), (ulong)value, (int)hexBase, digits);
			}
			return true;
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0004E514 File Offset: 0x0004C714
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static TChar* Int64ToHexChars<[IsUnmanaged] TChar>(TChar* buffer, ulong value, int hexBase, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			while (--digits >= 0 || value != 0UL)
			{
				byte b = (byte)(value & 15UL);
				*(buffer -= sizeof(TChar) / sizeof(TChar)) = IUtfChar<TChar>.CastFrom((int)b + ((b < 10) ? 48 : hexBase));
				value >>= 4;
			}
			return buffer;
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0004E564 File Offset: 0x0004C764
		private unsafe static string UInt64ToBinaryStr(ulong value, int digits)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, 64 - (int)ulong.LeadingZeroCount(value));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt64ToBinaryChars<char>(ptr + num, value, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0004E5B0 File Offset: 0x0004C7B0
		private unsafe static bool TryUInt64ToBinaryStr<[IsUnmanaged] TChar>(ulong value, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			int num = Math.Max(digits, 64 - (int)ulong.LeadingZeroCount(value));
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				Number.UInt64ToBinaryChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), value, digits);
			}
			return true;
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0004E606 File Offset: 0x0004C806
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static TChar* UInt64ToBinaryChars<[IsUnmanaged] TChar>(TChar* buffer, ulong value, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			while (--digits >= 0 || value != 0UL)
			{
				*(buffer -= sizeof(TChar) / sizeof(TChar)) = IUtfChar<TChar>.CastFrom((int)(48 + (byte)(value & 1UL)));
				value >>= 1;
			}
			return buffer;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0004E640 File Offset: 0x0004C840
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void UInt64ToNumber(ulong value, ref Number.NumberBuffer number)
		{
			number.DigitsCount = 20;
			number.IsNegative = false;
			byte* digitsPtr = number.DigitsPtr;
			byte* ptr = Number.UInt64ToDecChars<byte>(digitsPtr + 20, value, 0);
			int num = (int)((long)(digitsPtr + 20 - ptr));
			number.DigitsCount = num;
			number.Scale = num;
			byte* digitsPtr2 = number.DigitsPtr;
			while (--num >= 0)
			{
				*(digitsPtr2++) = *(ptr++);
			}
			*digitsPtr2 = 0;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0004E6A8 File Offset: 0x0004C8A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static TChar* UInt64ToDecChars<[IsUnmanaged] TChar>(TChar* bufferEnd, ulong value) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (value >= 10UL)
			{
				while (value >= 100UL)
				{
					bufferEnd -= (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					ValueTuple<ulong, ulong> valueTuple = Math.DivRem(value, 100UL);
					value = valueTuple.Item1;
					Number.WriteTwoDigits<TChar>((uint)valueTuple.Item2, bufferEnd);
				}
				if (value >= 10UL)
				{
					bufferEnd -= (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					Number.WriteTwoDigits<TChar>((uint)value, bufferEnd);
					return bufferEnd;
				}
			}
			*(bufferEnd -= sizeof(TChar) / sizeof(TChar)) = IUtfChar<TChar>.CastFrom(value + 48UL);
			return bufferEnd;
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0004E72C File Offset: 0x0004C92C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static TChar* UInt64ToDecChars<[IsUnmanaged] TChar>(TChar* bufferEnd, ulong value, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			while (value >= 100UL)
			{
				bufferEnd -= (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				digits -= 2;
				ValueTuple<ulong, ulong> valueTuple = Math.DivRem(value, 100UL);
				value = valueTuple.Item1;
				ulong item = valueTuple.Item2;
				Number.WriteTwoDigits<TChar>((uint)item, bufferEnd);
			}
			while (value != 0UL || digits > 0)
			{
				digits--;
				ValueTuple<ulong, ulong> valueTuple2 = Math.DivRem(value, 10UL);
				value = valueTuple2.Item1;
				ulong item = valueTuple2.Item2;
				*(bufferEnd -= sizeof(TChar) / sizeof(TChar)) = IUtfChar<TChar>.CastFrom(item + 48UL);
			}
			return bufferEnd;
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0004E7B8 File Offset: 0x0004C9B8
		internal unsafe static string UInt64ToDecStr(ulong value)
		{
			if (value < 10UL)
			{
				return Number.UInt32ToDecStrForKnownSmallNumber((uint)value);
			}
			int num = FormattingHelpers.CountDigits(value);
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt64ToDecChars<char>(ptr + num, value);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0004E800 File Offset: 0x0004CA00
		internal unsafe static string UInt64ToDecStr(ulong value, int digits)
		{
			if (digits <= 1)
			{
				return Number.UInt64ToDecStr(value);
			}
			int num = Math.Max(digits, FormattingHelpers.CountDigits(value));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt64ToDecChars<char>(ptr + num, value, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0004E84C File Offset: 0x0004CA4C
		internal unsafe static bool TryUInt64ToDecStr<[IsUnmanaged] TChar>(ulong value, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = FormattingHelpers.CountDigits(value);
			if (num <= destination.Length)
			{
				charsWritten = num;
				fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
				{
					Number.UInt64ToDecChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), value);
				}
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0004E890 File Offset: 0x0004CA90
		internal unsafe static bool TryUInt64ToDecStr<[IsUnmanaged] TChar>(ulong value, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = FormattingHelpers.CountDigits(value);
			int num2 = Math.Max(digits, num);
			if (num2 <= destination.Length)
			{
				charsWritten = num2;
				fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
				{
					TChar* bufferEnd = reference + (IntPtr)num2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					TChar* ptr = (digits > num) ? Number.UInt64ToDecChars<TChar>(bufferEnd, value, digits) : Number.UInt64ToDecChars<TChar>(bufferEnd, value);
				}
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0004E8EC File Offset: 0x0004CAEC
		private unsafe static void Int128ToNumber(Int128 value, ref Number.NumberBuffer number)
		{
			number.DigitsCount = 39;
			if (Int128.IsPositive(value))
			{
				number.IsNegative = false;
			}
			else
			{
				number.IsNegative = true;
				value = -value;
			}
			byte* digitsPtr = number.DigitsPtr;
			byte* ptr = Number.UInt128ToDecChars<byte>(digitsPtr + 39, (UInt128)value, 0);
			int num = (int)((long)(digitsPtr + 39 - ptr));
			number.DigitsCount = num;
			number.Scale = num;
			byte* digitsPtr2 = number.DigitsPtr;
			while (--num >= 0)
			{
				*(digitsPtr2++) = *(ptr++);
			}
			*digitsPtr2 = 0;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0004E970 File Offset: 0x0004CB70
		public static string Int128ToDecStr(Int128 value)
		{
			if (!Int128.IsPositive(value))
			{
				return Number.NegativeInt128ToDecStr(value, -1, NumberFormatInfo.CurrentInfo.NegativeSign);
			}
			return Number.UInt128ToDecStr((UInt128)value, -1);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0004E998 File Offset: 0x0004CB98
		private unsafe static string NegativeInt128ToDecStr(Int128 value, int digits, string sNegative)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			UInt128 value2 = (UInt128)(-value);
			int num = Math.Max(digits, FormattingHelpers.CountDigits(value2)) + sNegative.Length;
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3 = Number.UInt128ToDecChars<char>(ptr + num, value2, digits);
			for (int i = sNegative.Length - 1; i >= 0; i--)
			{
				*(--ptr3) = sNegative[i];
			}
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0004EA1C File Offset: 0x0004CC1C
		private unsafe static bool TryNegativeInt128ToDecStr<[IsUnmanaged] TChar>(Int128 value, int digits, ReadOnlySpan<TChar> sNegative, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			UInt128 value2 = (UInt128)(-value);
			int num = Math.Max(digits, FormattingHelpers.CountDigits(value2)) + sNegative.Length;
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = Number.UInt128ToDecChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), value2, digits);
				for (int i = sNegative.Length - 1; i >= 0; i--)
				{
					*(ptr -= sizeof(TChar) / sizeof(TChar)) = *sNegative[i];
				}
			}
			return true;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0004EABC File Offset: 0x0004CCBC
		private unsafe static string Int128ToHexStr(Int128 value, char hexBase, int digits)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			UInt128 value2 = (UInt128)value;
			int num = Math.Max(digits, FormattingHelpers.CountHexDigits(value2));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.Int128ToHexChars<char>(ptr + num, value2, (int)hexBase, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0004EB0C File Offset: 0x0004CD0C
		private unsafe static bool TryInt128ToHexStr<[IsUnmanaged] TChar>(Int128 value, char hexBase, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			UInt128 value2 = (UInt128)value;
			int num = Math.Max(digits, FormattingHelpers.CountHexDigits(value2));
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				Number.Int128ToHexChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), value2, (int)hexBase, digits);
			}
			return true;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0004EB68 File Offset: 0x0004CD68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static TChar* Int128ToHexChars<[IsUnmanaged] TChar>(TChar* buffer, UInt128 value, int hexBase, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			ulong lower = value.Lower;
			ulong upper = value.Upper;
			if (upper != 0UL)
			{
				buffer = Number.Int64ToHexChars<TChar>(buffer, lower, hexBase, 16);
				return Number.Int64ToHexChars<TChar>(buffer, upper, hexBase, digits - 16);
			}
			return Number.Int64ToHexChars<TChar>(buffer, lower, hexBase, Math.Max(digits, 1));
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0004EBB0 File Offset: 0x0004CDB0
		private unsafe static string UInt128ToBinaryStr(Int128 value, int digits)
		{
			if (digits < 1)
			{
				digits = 1;
			}
			UInt128 value2 = (UInt128)value;
			int num = Math.Max(digits, 128 - (int)UInt128.LeadingZeroCount((UInt128)value));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt128ToBinaryChars<char>(ptr + num, value2, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0004EC10 File Offset: 0x0004CE10
		private unsafe static bool TryUInt128ToBinaryStr<[IsUnmanaged] TChar>(Int128 value, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (digits < 1)
			{
				digits = 1;
			}
			UInt128 value2 = (UInt128)value;
			int num = Math.Max(digits, 128 - (int)UInt128.LeadingZeroCount((UInt128)value));
			if (num > destination.Length)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				Number.UInt128ToBinaryChars<TChar>(reference + (IntPtr)num * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), value2, digits);
			}
			return true;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0004EC7C File Offset: 0x0004CE7C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static TChar* UInt128ToBinaryChars<[IsUnmanaged] TChar>(TChar* buffer, UInt128 value, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			ulong lower = value.Lower;
			ulong upper = value.Upper;
			if (upper != 0UL)
			{
				buffer = Number.UInt64ToBinaryChars<TChar>(buffer, lower, 64);
				return Number.UInt64ToBinaryChars<TChar>(buffer, upper, digits - 64);
			}
			return Number.UInt64ToBinaryChars<TChar>(buffer, lower, Math.Max(digits, 1));
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0004ECC4 File Offset: 0x0004CEC4
		private unsafe static void UInt128ToNumber(UInt128 value, ref Number.NumberBuffer number)
		{
			number.DigitsCount = 39;
			number.IsNegative = false;
			byte* digitsPtr = number.DigitsPtr;
			byte* ptr = Number.UInt128ToDecChars<byte>(digitsPtr + 39, value, 0);
			int num = (int)((long)(digitsPtr + 39 - ptr));
			number.DigitsCount = num;
			number.Scale = num;
			byte* digitsPtr2 = number.DigitsPtr;
			while (--num >= 0)
			{
				*(digitsPtr2++) = *(ptr++);
			}
			*digitsPtr2 = 0;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0004ED2C File Offset: 0x0004CF2C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong Int128DivMod1E19(ref UInt128 value)
		{
			UInt128 right = new UInt128(0UL, 10000000000000000000UL);
			ValueTuple<UInt128, UInt128> valueTuple = UInt128.DivRem(value, right);
			value = valueTuple.Item1;
			UInt128 item = valueTuple.Item2;
			return item.Lower;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0004ED72 File Offset: 0x0004CF72
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static TChar* UInt128ToDecChars<[IsUnmanaged] TChar>(TChar* bufferEnd, UInt128 value) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			while (value.Upper != 0UL)
			{
				bufferEnd = Number.UInt64ToDecChars<TChar>(bufferEnd, Number.Int128DivMod1E19(ref value), 19);
			}
			return Number.UInt64ToDecChars<TChar>(bufferEnd, value.Lower);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0004ED9D File Offset: 0x0004CF9D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static TChar* UInt128ToDecChars<[IsUnmanaged] TChar>(TChar* bufferEnd, UInt128 value, int digits) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			while (value.Upper != 0UL)
			{
				bufferEnd = Number.UInt64ToDecChars<TChar>(bufferEnd, Number.Int128DivMod1E19(ref value), 19);
				digits -= 19;
			}
			return Number.UInt64ToDecChars<TChar>(bufferEnd, value.Lower, digits);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0004EDD0 File Offset: 0x0004CFD0
		internal unsafe static string UInt128ToDecStr(UInt128 value)
		{
			if (value.Upper == 0UL)
			{
				return Number.UInt64ToDecStr(value.Lower);
			}
			int num = FormattingHelpers.CountDigits(value);
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt128ToDecChars<char>(ptr + num, value);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0004EE20 File Offset: 0x0004D020
		internal unsafe static string UInt128ToDecStr(UInt128 value, int digits)
		{
			if (digits <= 1)
			{
				return Number.UInt128ToDecStr(value);
			}
			int num = Math.Max(digits, FormattingHelpers.CountDigits(value));
			string text = string.FastAllocateString(num);
			char* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			Number.UInt128ToDecChars<char>(ptr + num, value, digits);
			char* ptr2 = null;
			return text;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0004EE6C File Offset: 0x0004D06C
		private unsafe static bool TryUInt128ToDecStr<[IsUnmanaged] TChar>(UInt128 value, int digits, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = FormattingHelpers.CountDigits(value);
			int num2 = Math.Max(digits, num);
			if (num2 <= destination.Length)
			{
				charsWritten = num2;
				fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
				{
					TChar* bufferEnd = reference + (IntPtr)num2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					TChar* ptr = (digits > num) ? Number.UInt128ToDecChars<TChar>(bufferEnd, value, digits) : Number.UInt128ToDecChars<TChar>(bufferEnd, value);
				}
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0004EEC8 File Offset: 0x0004D0C8
		private static ulong ExtractFractionAndBiasedExponent<[IsUnmanaged] TNumber>(TNumber value, out int exponent) where TNumber : struct, ValueType, IBinaryFloatParseAndFormatInfo<TNumber>
		{
			ulong num = IBinaryFloatParseAndFormatInfo<TNumber>.FloatToBits(value);
			ulong num2 = num & IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaMask;
			exponent = ((int)(num >> (int)IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaBits) & IBinaryFloatParseAndFormatInfo<TNumber>.InfinityExponent);
			if (exponent != 0)
			{
				num2 |= 1UL << (int)IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaBits;
				exponent -= IBinaryFloatParseAndFormatInfo<TNumber>.ExponentBias + (int)IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaBits;
			}
			else
			{
				exponent = IBinaryFloatParseAndFormatInfo<TNumber>.MinBinaryExponent - (int)IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaBits;
			}
			return num2;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0004EF5F File Offset: 0x0004D15F
		private static ReadOnlySpan<double> Pow10DoubleTable
		{
			get
			{
				return RuntimeHelpers.CreateSpan<double>(fieldof(<PrivateImplementationDetails>.54163634AEBD5768E4BE0AF562CC018EB2E45008D13F13F14366BE52C290193D8).FieldHandle);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0004EF6B File Offset: 0x0004D16B
		private static ReadOnlySpan<ulong> Pow5128Table
		{
			get
			{
				return RuntimeHelpers.CreateSpan<ulong>(fieldof(<PrivateImplementationDetails>.DAE47E3594BB0B39D42660EF3FE3DC5DE5885C0A29AE0E5C21A39E79669EFE868).FieldHandle);
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0004EF78 File Offset: 0x0004D178
		private unsafe static void AccumulateDecimalDigitsIntoBigInteger([ScopedRef] ref Number.NumberBuffer number, uint firstIndex, uint lastIndex, out Number.BigInteger result)
		{
			Number.BigInteger.SetZero(out result);
			byte* ptr = number.DigitsPtr + firstIndex;
			uint num2;
			for (uint num = lastIndex - firstIndex; num != 0U; num -= num2)
			{
				num2 = Math.Min(num, 9U);
				uint value = Number.DigitsToUInt32(ptr, (int)num2);
				result.MultiplyPow10(num2);
				result.Add(value);
				ptr += num2;
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0004EFC8 File Offset: 0x0004D1C8
		private static ulong AssembleFloatingPointBits<[IsUnmanaged] TFloat>(ulong initialMantissa, int initialExponent, bool hasZeroTail) where TFloat : struct, ValueType, IBinaryFloatParseAndFormatInfo<TFloat>
		{
			uint num = Number.BigInteger.CountSignificantBits(initialMantissa);
			int num2 = (int)((uint)IBinaryFloatParseAndFormatInfo<TFloat>.NormalMantissaBits - num);
			int num3 = initialExponent - num2;
			ulong num4 = initialMantissa;
			int num5 = num3;
			if (num3 > IBinaryFloatParseAndFormatInfo<TFloat>.MaxBinaryExponent)
			{
				return IBinaryFloatParseAndFormatInfo<TFloat>.InfinityBits;
			}
			if (num3 < IBinaryFloatParseAndFormatInfo<TFloat>.MinBinaryExponent)
			{
				int num6 = num2 + num3 + IBinaryFloatParseAndFormatInfo<TFloat>.ExponentBias - 1;
				num5 = -IBinaryFloatParseAndFormatInfo<TFloat>.ExponentBias;
				if (num6 < 0)
				{
					num4 = Number.RightShiftWithRounding(num4, -num6, hasZeroTail);
					if (num4 == 0UL)
					{
						return IBinaryFloatParseAndFormatInfo<TFloat>.ZeroBits;
					}
					if (num4 > IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaMask)
					{
						num5 = initialExponent - (num6 + 1) - num2;
					}
				}
				else
				{
					num4 <<= num6;
				}
			}
			else if (num2 < 0)
			{
				num4 = Number.RightShiftWithRounding(num4, -num2, hasZeroTail);
				if (num4 > IBinaryFloatParseAndFormatInfo<TFloat>.NormalMantissaMask)
				{
					num4 >>= 1;
					num5++;
					if (num5 > IBinaryFloatParseAndFormatInfo<TFloat>.MaxBinaryExponent)
					{
						return IBinaryFloatParseAndFormatInfo<TFloat>.InfinityBits;
					}
				}
			}
			else if (num2 > 0)
			{
				num4 <<= num2;
			}
			num4 &= IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaMask;
			return (ulong)((long)(num5 + IBinaryFloatParseAndFormatInfo<TFloat>.ExponentBias) << (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits | (long)num4);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0004F0FC File Offset: 0x0004D2FC
		private static ulong ConvertBigIntegerToFloatingPointBits<[IsUnmanaged] TFloat>(ref Number.BigInteger value, uint integerBitsOfPrecision, bool hasNonZeroFractionalPart) where TFloat : struct, ValueType, IBinaryFloatParseAndFormatInfo<TFloat>
		{
			int denormalMantissaBits = (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits;
			if (integerBitsOfPrecision <= 64U)
			{
				return Number.AssembleFloatingPointBits<TFloat>(value.ToUInt64(), denormalMantissaBits, !hasNonZeroFractionalPart);
			}
			ValueTuple<uint, uint> valueTuple = Math.DivRem(integerBitsOfPrecision, 32U);
			uint item = valueTuple.Item1;
			uint item2 = valueTuple.Item2;
			uint num = item - 1U;
			uint num2 = num - 1U;
			int num3 = denormalMantissaBits + (int)(num2 * 32U);
			bool flag = !hasNonZeroFractionalPart;
			ulong initialMantissa;
			if (item2 == 0U)
			{
				initialMantissa = ((ulong)value.GetBlock(num) << 32) + (ulong)value.GetBlock(num2);
			}
			else
			{
				int num4 = (int)item2;
				int num5 = 64 - num4;
				int num6 = num5 - 32;
				num3 += (int)item2;
				uint block = value.GetBlock(num2);
				uint num7 = block >> num4;
				ulong num8 = (ulong)value.GetBlock(num) << num6;
				initialMantissa = ((ulong)value.GetBlock(item) << num5) + num8 + (ulong)num7;
				uint num9 = (1U << (int)item2) - 1U;
				flag &= ((block & num9) == 0U);
			}
			for (uint num10 = 0U; num10 != num2; num10 += 1U)
			{
				flag &= (value.GetBlock(num10) == 0U);
			}
			return Number.AssembleFloatingPointBits<TFloat>(initialMantissa, num3, flag);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0004F20C File Offset: 0x0004D40C
		private unsafe static uint DigitsToUInt32(byte* p, int count)
		{
			byte* ptr = p + count;
			uint num = 0U;
			while (p == ptr - 8)
			{
				num = num * 100000000U + Number.ParseEightDigitsUnrolled(p);
				p += 8;
			}
			while (p != ptr)
			{
				num = 10U * num + (uint)(*p) - 48U;
				p++;
			}
			return num;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0004F254 File Offset: 0x0004D454
		private unsafe static ulong DigitsToUInt64(byte* p, int count)
		{
			byte* ptr = p + count;
			ulong num = 0UL;
			while ((long)(ptr - p) >= 8L)
			{
				num = num * 100000000UL + (ulong)Number.ParseEightDigitsUnrolled(p);
				p += 8;
			}
			while (p != ptr)
			{
				num = 10UL * num + (ulong)(*p) - 48UL;
				p++;
			}
			return num;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0004F2A4 File Offset: 0x0004D4A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static uint ParseEightDigitsUnrolled(byte* chars)
		{
			ulong num = Unsafe.ReadUnaligned<ulong>((void*)chars);
			if (!BitConverter.IsLittleEndian)
			{
			}
			num -= 3472328296227680304UL;
			num = num * 10UL + (num >> 8);
			num = (num & 1095216660735UL) * 4294967296000100UL + (num >> 16 & 1095216660735UL) * 42949672960001UL >> 32;
			return (uint)num;
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0004F30C File Offset: 0x0004D50C
		private unsafe static ulong NumberToFloatingPointBits<[IsUnmanaged] TFloat>(ref Number.NumberBuffer number) where TFloat : struct, ValueType, IBinaryFloatParseAndFormatInfo<TFloat>
		{
			uint digitsCount = (uint)number.DigitsCount;
			uint num = (uint)Math.Max(0, number.Scale);
			uint num2 = Math.Min(num, digitsCount);
			uint num3 = digitsCount - num2;
			if (digitsCount <= 19U)
			{
				ulong num4 = Number.DigitsToUInt64(number.DigitsPtr, (int)digitsCount);
				int num5 = (int)((long)number.Scale - (long)((ulong)num2) - (long)((ulong)num3));
				int num6 = Math.Abs(num5);
				if (num4 <= IBinaryFloatParseAndFormatInfo<TFloat>.MaxMantissaFastPath && num6 <= IBinaryFloatParseAndFormatInfo<TFloat>.MaxExponentFastPath)
				{
					double num7 = num4;
					double num8 = *Number.Pow10DoubleTable[num6];
					if (num3 != 0U)
					{
						num7 /= num8;
					}
					else
					{
						num7 *= num8;
					}
					return IBinaryFloatParseAndFormatInfo<TFloat>.FloatToBits(INumberBase<TFloat>.CreateSaturating<double>(num7));
				}
				ValueTuple<int, ulong> valueTuple = Number.ComputeFloat<TFloat>((long)num5, num4);
				if (valueTuple.Item1 > 0)
				{
					return valueTuple.Item2 | (ulong)valueTuple.Item1 << (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits;
				}
			}
			return Number.NumberToFloatingPointBitsSlow<TFloat>(ref number, num, num2, num3);
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0004F40C File Offset: 0x0004D60C
		private static ulong NumberToFloatingPointBitsSlow<[IsUnmanaged] TFloat>(ref Number.NumberBuffer number, uint positiveExponent, uint integerDigitsPresent, uint fractionalDigitsPresent) where TFloat : struct, ValueType, IBinaryFloatParseAndFormatInfo<TFloat>
		{
			uint num = (uint)(IBinaryFloatParseAndFormatInfo<TFloat>.NormalMantissaBits + 1);
			uint digitsCount = (uint)number.DigitsCount;
			uint num2 = positiveExponent - integerDigitsPresent;
			uint lastIndex = digitsCount;
			Number.BigInteger bigInteger;
			Number.AccumulateDecimalDigitsIntoBigInteger(ref number, 0U, integerDigitsPresent, out bigInteger);
			if (num2 > 0U)
			{
				if ((ulong)num2 > (ulong)((long)IBinaryFloatParseAndFormatInfo<TFloat>.OverflowDecimalExponent))
				{
					return IBinaryFloatParseAndFormatInfo<TFloat>.InfinityBits;
				}
				bigInteger.MultiplyPow10(num2);
			}
			uint num3 = Number.BigInteger.CountSignificantBits(ref bigInteger);
			if (num3 >= num || fractionalDigitsPresent == 0U)
			{
				return Number.ConvertBigIntegerToFloatingPointBits<TFloat>(ref bigInteger, num3, fractionalDigitsPresent > 0U);
			}
			uint num4 = fractionalDigitsPresent;
			if (number.Scale < 0)
			{
				num4 += (uint)(-(uint)number.Scale);
			}
			if (num3 == 0U && (ulong)num4 - (ulong)((long)digitsCount) > (ulong)((long)IBinaryFloatParseAndFormatInfo<TFloat>.OverflowDecimalExponent))
			{
				return IBinaryFloatParseAndFormatInfo<TFloat>.ZeroBits;
			}
			Number.BigInteger bigInteger2;
			Number.AccumulateDecimalDigitsIntoBigInteger(ref number, integerDigitsPresent, lastIndex, out bigInteger2);
			if (bigInteger2.IsZero())
			{
				return Number.ConvertBigIntegerToFloatingPointBits<TFloat>(ref bigInteger, num3, fractionalDigitsPresent > 0U);
			}
			Number.BigInteger bigInteger3;
			Number.BigInteger.Pow10(num4, out bigInteger3);
			uint num5 = Number.BigInteger.CountSignificantBits(ref bigInteger2);
			uint num6 = Number.BigInteger.CountSignificantBits(ref bigInteger3);
			uint num7 = 0U;
			if (num6 > num5)
			{
				num7 = num6 - num5;
			}
			if (num7 > 0U)
			{
				bigInteger2.ShiftLeft(num7);
			}
			uint num8 = num - num3;
			uint num9 = num8;
			if (num3 > 0U)
			{
				if (num7 > num9)
				{
					return Number.ConvertBigIntegerToFloatingPointBits<TFloat>(ref bigInteger, num3, fractionalDigitsPresent > 0U);
				}
				num9 -= num7;
			}
			uint num10 = num7;
			if (Number.BigInteger.Compare(ref bigInteger2, ref bigInteger3) < 0)
			{
				num10 += 1U;
			}
			bigInteger2.ShiftLeft(num9);
			Number.BigInteger bigInteger4;
			Number.BigInteger bigInteger5;
			Number.BigInteger.DivRem(ref bigInteger2, ref bigInteger3, out bigInteger4, out bigInteger5);
			ulong num11 = bigInteger4.ToUInt64();
			bool flag = !number.HasNonZeroTail && bigInteger5.IsZero();
			uint num12 = Number.BigInteger.CountSignificantBits(num11);
			if (num12 > num8)
			{
				int num13 = (int)(num12 - num8);
				flag = (flag && (num11 & (1UL << num13) - 1UL) == 0UL);
				num11 >>= num13;
			}
			ulong initialMantissa = (bigInteger.ToUInt64() << (int)num8) + num11;
			int initialExponent = (int)((num3 > 0U) ? (num3 - 2U) : (-num10 - 1U));
			return Number.AssembleFloatingPointBits<TFloat>(initialMantissa, initialExponent, flag);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0004F5FC File Offset: 0x0004D7FC
		private static ulong RightShiftWithRounding(ulong value, int shift, bool hasZeroTail)
		{
			if (shift >= 64)
			{
				return 0UL;
			}
			ulong num = (1UL << shift - 1) - 1UL;
			ulong num2 = 1UL << shift - 1;
			ulong num3 = 1UL << shift;
			bool lsbBit = (value & num3) > 0UL;
			bool roundBit = (value & num2) > 0UL;
			bool hasTailBits = !hasZeroTail || (value & num) > 0UL;
			return (value >> shift) + (ulong)((Number.ShouldRoundUp(lsbBit, roundBit, hasTailBits) > false) ? 1L : 0L);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0004F665 File Offset: 0x0004D865
		private static bool ShouldRoundUp(bool lsbBit, bool roundBit, bool hasTailBits)
		{
			return roundBit && (hasTailBits || lsbBit);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0004F670 File Offset: 0x0004D870
		[return: TupleElementNames(new string[]
		{
			"Exponent",
			"Mantissa"
		})]
		internal static ValueTuple<int, ulong> ComputeFloat<[IsUnmanaged] TFloat>(long q, ulong w) where TFloat : struct, ValueType, IBinaryFloatParseAndFormatInfo<TFloat>
		{
			ulong num = 0UL;
			if (w == 0UL || q < (long)IBinaryFloatParseAndFormatInfo<TFloat>.MinFastFloatDecimalExponent)
			{
				return default(ValueTuple<int, ulong>);
			}
			int num2;
			if (q > (long)IBinaryFloatParseAndFormatInfo<TFloat>.MaxFastFloatDecimalExponent)
			{
				num2 = IBinaryFloatParseAndFormatInfo<TFloat>.InfinityExponent;
				num = 0UL;
				return new ValueTuple<int, ulong>(num2, num);
			}
			int num3 = BitOperations.LeadingZeroCount(w);
			w <<= num3;
			ValueTuple<ulong, ulong> valueTuple = Number.ComputeProductApproximation((int)(IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits + 3), q, w);
			if (valueTuple.Item2 == 18446744073709551615UL && (q < -27L || q > 55L))
			{
				num2 = -1;
				return new ValueTuple<int, ulong>(num2, num);
			}
			int num4 = (int)(valueTuple.Item1 >> 63);
			num = valueTuple.Item1 >> num4 + 64 - (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits - 3;
			num2 = Number.CalculatePower((int)q) + num4 - num3 - -IBinaryFloatParseAndFormatInfo<TFloat>.MaxBinaryExponent;
			if (num2 > 0)
			{
				if (valueTuple.Item2 <= 1UL && q >= (long)IBinaryFloatParseAndFormatInfo<TFloat>.MinExponentRoundToEven && q <= (long)IBinaryFloatParseAndFormatInfo<TFloat>.MaxExponentRoundToEven && (num & 3UL) == 1UL && num << num4 + 64 - (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits - 3 == valueTuple.Item1)
				{
					num &= 18446744073709551614UL;
				}
				num += (num & 1UL);
				num >>= 1;
				if (num >= 2UL << (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits)
				{
					num = 1UL << (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits;
					num2++;
				}
				num &= ~(1UL << (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits);
				if (num2 >= IBinaryFloatParseAndFormatInfo<TFloat>.InfinityExponent)
				{
					num2 = IBinaryFloatParseAndFormatInfo<TFloat>.InfinityExponent;
					num = 0UL;
				}
				return new ValueTuple<int, ulong>(num2, num);
			}
			if (-num2 + 1 >= 64)
			{
				num2 = 0;
				num = 0UL;
				return new ValueTuple<int, ulong>(num2, num);
			}
			num >>= -num2 + 1;
			num += (num & 1UL);
			num >>= 1;
			num2 = ((num >= 1UL << (int)IBinaryFloatParseAndFormatInfo<TFloat>.DenormalMantissaBits) ? 1 : 0);
			return new ValueTuple<int, ulong>(num2, num);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0004F868 File Offset: 0x0004DA68
		[return: TupleElementNames(new string[]
		{
			"high",
			"low"
		})]
		private unsafe static ValueTuple<ulong, ulong> ComputeProductApproximation(int bitPrecision, long q, ulong w)
		{
			int num = 2 * (int)(q - -342L);
			ulong num3;
			ulong num2 = Math.BigMul(w, (ulong)(*Number.Pow5128Table[num]), out num3);
			ulong num4 = (bitPrecision < 64) ? (ulong.MaxValue >> bitPrecision) : ulong.MaxValue;
			if ((num2 & num4) == num4)
			{
				ulong num6;
				ulong num5 = Math.BigMul(w, (ulong)(*Number.Pow5128Table[num + 1]), out num6);
				num3 += num5;
				if (num5 > num3)
				{
					num2 += 1UL;
				}
			}
			return new ValueTuple<ulong, ulong>(num2, num3);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0004F8E3 File Offset: 0x0004DAE3
		internal static int CalculatePower(int q)
		{
			return (217706 * q >> 16) + 63;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0004F8F4 File Offset: 0x0004DAF4
		private unsafe static bool TryNumberBufferToBinaryInteger<[IsUnmanaged] TInteger>(ref Number.NumberBuffer number, ref TInteger value) where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			int num = number.Scale;
			if (num > IBinaryIntegerParseAndFormatInfo<TInteger>.MaxDigitCount || num < number.DigitsCount || (!IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned && number.IsNegative) || number.HasNonZeroTail)
			{
				return false;
			}
			byte* digitsPtr = number.DigitsPtr;
			TInteger tinteger = INumberBase<TInteger>.Zero;
			while (--num >= 0)
			{
				if (IBinaryIntegerParseAndFormatInfo<TInteger>.IsGreaterThanAsUnsigned(tinteger, IBinaryIntegerParseAndFormatInfo<TInteger>.MaxValueDiv10))
				{
					return false;
				}
				tinteger = IBinaryIntegerParseAndFormatInfo<TInteger>.MultiplyBy10(tinteger);
				if (*digitsPtr != 0)
				{
					TInteger tinteger2 = tinteger + INumberBase<TInteger>.CreateTruncating<int>((int)(*(digitsPtr++) - 48));
					if (!IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned && tinteger2 < tinteger)
					{
						return false;
					}
					tinteger = tinteger2;
				}
			}
			if (IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned)
			{
				if (number.IsNegative)
				{
					tinteger = -tinteger;
					if (tinteger > INumberBase<TInteger>.Zero)
					{
						return false;
					}
				}
				else if (tinteger < INumberBase<TInteger>.Zero)
				{
					return false;
				}
			}
			value = tinteger;
			return true;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0004FA28 File Offset: 0x0004DC28
		internal static TInteger ParseBinaryInteger<[IsUnmanaged] TChar, [IsUnmanaged] TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			TInteger result;
			Number.ParsingStatus parsingStatus = Number.TryParseBinaryInteger<TChar, TInteger>(value, styles, info, out result);
			if (parsingStatus != Number.ParsingStatus.OK)
			{
				Number.ThrowOverflowOrFormatException<TChar, TInteger>(parsingStatus, value);
			}
			return result;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0004FA4B File Offset: 0x0004DC4B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Number.ParsingStatus TryParseBinaryInteger<[IsUnmanaged] TChar, [IsUnmanaged] TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out TInteger result) where TChar : struct, ValueType, IUtfChar<TChar> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			if ((styles & ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign)) == NumberStyles.None)
			{
				return Number.TryParseBinaryIntegerStyle<TChar, TInteger>(value, styles, info, out result);
			}
			if ((styles & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
			{
				return Number.TryParseBinaryIntegerHexNumberStyle<TChar, TInteger>(value, styles, out result);
			}
			if ((styles & NumberStyles.AllowBinarySpecifier) != NumberStyles.None)
			{
				return Number.TryParseBinaryIntegerHexOrBinaryNumberStyle<TChar, TInteger, Number.BinaryParser<TInteger>>(value, styles, out result);
			}
			return Number.TryParseBinaryIntegerNumber<TChar, TInteger>(value, styles, info, out result);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0004FA8C File Offset: 0x0004DC8C
		private unsafe static Number.ParsingStatus TryParseBinaryIntegerNumber<[IsUnmanaged] TChar, [IsUnmanaged] TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out TInteger result) where TChar : struct, ValueType, IUtfChar<TChar> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			result = INumberBase<TInteger>.Zero;
			int num = IBinaryIntegerParseAndFormatInfo<TInteger>.MaxDigitCount + 1;
			Span<byte> digits = new Span<byte>(stackalloc byte[(UIntPtr)num], num);
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits);
			if (!Number.TryStringToNumber<TChar>(value, styles, ref numberBuffer, info))
			{
				return Number.ParsingStatus.Failed;
			}
			if (!Number.TryNumberBufferToBinaryInteger<TInteger>(ref numberBuffer, ref result))
			{
				return Number.ParsingStatus.Overflow;
			}
			return Number.ParsingStatus.OK;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0004FAE8 File Offset: 0x0004DCE8
		internal unsafe static Number.ParsingStatus TryParseBinaryIntegerStyle<[IsUnmanaged] TChar, [IsUnmanaged] TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out TInteger result) where TChar : struct, ValueType, IUtfChar<TChar> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			if (value.IsEmpty)
			{
				goto IL_4AB;
			}
			int num = 0;
			uint num2 = IUtfChar<TChar>.CastToUInt32(*value[0]);
			if ((styles & NumberStyles.AllowLeadingWhite) != NumberStyles.None && Number.IsWhite(num2))
			{
				do
				{
					num++;
					if (num >= value.Length)
					{
						goto IL_4AB;
					}
					num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
				}
				while (Number.IsWhite(num2));
			}
			bool flag = false;
			if ((styles & NumberStyles.AllowLeadingSign) != NumberStyles.None)
			{
				if (info.HasInvariantNumberSigns)
				{
					if (num2 == 45U)
					{
						flag = true;
						num++;
						if (num >= value.Length)
						{
							goto IL_4AB;
						}
						num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
					}
					else if (num2 == 43U)
					{
						num++;
						if (num >= value.Length)
						{
							goto IL_4AB;
						}
						num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
					}
				}
				else if (info.AllowHyphenDuringParsing() && num2 == 45U)
				{
					flag = true;
					num++;
					if (num >= value.Length)
					{
						goto IL_4AB;
					}
					num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
				}
				else
				{
					value = value.Slice(num);
					num = 0;
					ReadOnlySpan<TChar> value2 = info.PositiveSignTChar<TChar>();
					ReadOnlySpan<TChar> value3 = info.NegativeSignTChar<TChar>();
					if (!value2.IsEmpty && value.StartsWith(value2))
					{
						num += value2.Length;
						if (num >= value.Length)
						{
							goto IL_4AB;
						}
						num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
					}
					else if (!value3.IsEmpty && value.StartsWith(value3))
					{
						flag = true;
						num += value3.Length;
						if (num >= value.Length)
						{
							goto IL_4AB;
						}
						num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
					}
				}
			}
			bool flag2 = !IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned && flag;
			TInteger tinteger = INumberBase<TInteger>.Zero;
			if (!Number.IsDigit(num2))
			{
				goto IL_4AB;
			}
			if (num2 == 48U)
			{
				do
				{
					num++;
					if (num >= value.Length)
					{
						goto IL_474;
					}
					num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
				}
				while (num2 == 48U);
				if (!Number.IsDigit(num2))
				{
					if (!IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned)
					{
						flag2 = false;
					}
					goto IL_4D7;
				}
			}
			tinteger = INumberBase<TInteger>.CreateTruncating<uint>(num2 - 48U);
			num++;
			int i = 0;
			while (i < IBinaryIntegerParseAndFormatInfo<TInteger>.MaxDigitCount - 2)
			{
				if (num >= value.Length)
				{
					if (!IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned)
					{
						goto IL_471;
					}
					goto IL_474;
				}
				else
				{
					num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
					if (!Number.IsDigit(num2))
					{
						goto IL_4D7;
					}
					num++;
					tinteger = IBinaryIntegerParseAndFormatInfo<TInteger>.MultiplyBy10(tinteger);
					tinteger += INumberBase<TInteger>.CreateTruncating<uint>(num2 - 48U);
					i++;
				}
			}
			if (num >= value.Length)
			{
				if (IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned)
				{
					goto IL_474;
				}
			}
			else
			{
				num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
				if (!Number.IsDigit(num2))
				{
					goto IL_4D7;
				}
				num++;
				if (!IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned)
				{
					flag2 |= (tinteger > IBinaryIntegerParseAndFormatInfo<TInteger>.MaxValueDiv10 || (tinteger == IBinaryIntegerParseAndFormatInfo<TInteger>.MaxValueDiv10 && num2 > 53U));
				}
				else
				{
					flag2 = (tinteger > IBinaryIntegerParseAndFormatInfo<TInteger>.MaxValueDiv10);
				}
				tinteger = IBinaryIntegerParseAndFormatInfo<TInteger>.MultiplyBy10(tinteger);
				tinteger += INumberBase<TInteger>.CreateTruncating<uint>(num2 - 48U);
				if (IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned)
				{
					flag2 |= IBinaryIntegerParseAndFormatInfo<TInteger>.IsGreaterThanAsUnsigned(tinteger, IMinMaxValue<TInteger>.MaxValue + (flag ? INumberBase<TInteger>.One : INumberBase<TInteger>.Zero));
				}
				if (num < value.Length)
				{
					num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
					while (Number.IsDigit(num2))
					{
						flag2 = true;
						num++;
						if (num >= value.Length)
						{
							goto IL_4C1;
						}
						num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
					}
					goto IL_4D7;
				}
			}
			IL_471:
			if (flag2)
			{
				goto IL_4C1;
			}
			IL_474:
			if (!IBinaryIntegerParseAndFormatInfo<TInteger>.IsSigned)
			{
				result = tinteger;
			}
			else
			{
				result = (flag ? (-tinteger) : tinteger);
			}
			return Number.ParsingStatus.OK;
			IL_4C1:
			result = INumberBase<TInteger>.Zero;
			return Number.ParsingStatus.Overflow;
			IL_4D7:
			if (Number.IsWhite(num2))
			{
				if ((styles & NumberStyles.AllowTrailingWhite) == NumberStyles.None)
				{
					goto IL_4AB;
				}
				num++;
				while (num < value.Length && Number.IsWhite(IUtfChar<TChar>.CastToUInt32(*value[num])))
				{
					num++;
				}
				if (num >= value.Length)
				{
					goto IL_471;
				}
			}
			if (!Number.TrailingZeros<TChar>(value, num))
			{
				goto IL_4AB;
			}
			goto IL_471;
			IL_4AB:
			result = INumberBase<TInteger>.Zero;
			return Number.ParsingStatus.Failed;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00050029 File Offset: 0x0004E229
		internal static Number.ParsingStatus TryParseBinaryIntegerHexNumberStyle<[IsUnmanaged] TChar, [IsUnmanaged] TInteger>(ReadOnlySpan<TChar> value, NumberStyles styles, out TInteger result) where TChar : struct, ValueType, IUtfChar<TChar> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			return Number.TryParseBinaryIntegerHexOrBinaryNumberStyle<TChar, TInteger, Number.HexParser<TInteger>>(value, styles, out result);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00050034 File Offset: 0x0004E234
		private unsafe static Number.ParsingStatus TryParseBinaryIntegerHexOrBinaryNumberStyle<[IsUnmanaged] TChar, [IsUnmanaged] TInteger, TParser>(ReadOnlySpan<TChar> value, NumberStyles styles, out TInteger result) where TChar : struct, ValueType, IUtfChar<TChar> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger> where TParser : struct, Number.IHexOrBinaryParser<TInteger>
		{
			if (value.IsEmpty)
			{
				goto IL_1F0;
			}
			int num = 0;
			uint num2 = IUtfChar<TChar>.CastToUInt32(*value[0]);
			if ((styles & NumberStyles.AllowLeadingWhite) != NumberStyles.None && Number.IsWhite(num2))
			{
				do
				{
					num++;
					if (num >= value.Length)
					{
						goto IL_1F0;
					}
					num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
				}
				while (Number.IsWhite(num2));
			}
			bool flag = false;
			TInteger tinteger = INumberBase<TInteger>.Zero;
			if (!Number.IHexOrBinaryParser<TInteger>.IsValidChar(num2))
			{
				goto IL_1F0;
			}
			if (num2 == 48U)
			{
				do
				{
					num++;
					if (num >= value.Length)
					{
						goto IL_1E3;
					}
					num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
				}
				while (num2 == 48U);
				if (!Number.IHexOrBinaryParser<TInteger>.IsValidChar(num2))
				{
					goto IL_21C;
				}
			}
			tinteger = INumberBase<TInteger>.CreateTruncating<uint>(Number.IHexOrBinaryParser<TInteger>.FromChar(num2));
			num++;
			for (int i = 0; i < Number.IHexOrBinaryParser<TInteger>.MaxDigitCount - 1; i++)
			{
				if (num >= value.Length)
				{
					goto IL_1E3;
				}
				num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
				uint num3 = Number.IHexOrBinaryParser<TInteger>.FromChar(num2);
				if (num3 > Number.IHexOrBinaryParser<TInteger>.MaxDigitValue)
				{
					goto IL_21C;
				}
				num++;
				tinteger = Number.IHexOrBinaryParser<TInteger>.ShiftLeftForNextDigit(tinteger);
				tinteger += INumberBase<TInteger>.CreateTruncating<uint>(num3);
			}
			if (num < value.Length)
			{
				num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
				if (Number.IHexOrBinaryParser<TInteger>.IsValidChar(num2))
				{
					do
					{
						num++;
						if (num >= value.Length)
						{
							goto IL_206;
						}
						num2 = IUtfChar<TChar>.CastToUInt32(*value[num]);
					}
					while (Number.IHexOrBinaryParser<TInteger>.IsValidChar(num2));
					flag = true;
				}
				goto IL_21C;
			}
			IL_1E3:
			result = tinteger;
			return Number.ParsingStatus.OK;
			IL_206:
			result = INumberBase<TInteger>.Zero;
			return Number.ParsingStatus.Overflow;
			IL_21C:
			if (!Number.IsWhite(num2))
			{
				goto IL_269;
			}
			if ((styles & NumberStyles.AllowTrailingWhite) == NumberStyles.None)
			{
				goto IL_1F0;
			}
			num++;
			while (num < value.Length && Number.IsWhite(IUtfChar<TChar>.CastToUInt32(*value[num])))
			{
				num++;
			}
			if (num < value.Length)
			{
				goto IL_269;
			}
			IL_1E0:
			if (!flag)
			{
				goto IL_1E3;
			}
			goto IL_206;
			IL_269:
			if (!Number.TrailingZeros<TChar>(value, num))
			{
				goto IL_1F0;
			}
			goto IL_1E0;
			IL_1F0:
			result = INumberBase<TInteger>.Zero;
			return Number.ParsingStatus.Failed;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000502BC File Offset: 0x0004E4BC
		internal static decimal ParseDecimal<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			decimal result;
			Number.ParsingStatus parsingStatus = Number.TryParseDecimal<TChar>(value, styles, info, out result);
			if (parsingStatus != Number.ParsingStatus.OK)
			{
				if (parsingStatus == Number.ParsingStatus.Failed)
				{
					Number.ThrowFormatException<TChar>(value);
				}
				Number.ThrowOverflowException(SR.Overflow_Decimal);
			}
			return result;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000502EC File Offset: 0x0004E4EC
		internal unsafe static bool TryNumberToDecimal(ref Number.NumberBuffer number, ref decimal value)
		{
			byte* ptr = number.DigitsPtr;
			int i = number.Scale;
			bool isNegative = number.IsNegative;
			uint num = (uint)(*ptr);
			if (num == 0U)
			{
				value = new decimal(0, 0, 0, isNegative, (byte)Math.Clamp(-i, 0, 28));
				return true;
			}
			if (i > 29)
			{
				return false;
			}
			ulong num2 = 0UL;
			while (i > -28)
			{
				i--;
				num2 *= 10UL;
				num2 += (ulong)(num - 48U);
				num = (uint)(*(++ptr));
				if (num2 >= 1844674407370955161UL)
				{
					break;
				}
				if (num == 0U)
				{
					while (i > 0)
					{
						i--;
						num2 *= 10UL;
						if (num2 >= 1844674407370955161UL)
						{
							break;
						}
					}
					break;
				}
			}
			uint num3 = 0U;
			while ((i > 0 || (num != 0U && i > -28)) && (num3 < 429496729U || (num3 == 429496729U && (num2 < 11068046444225730969UL || (num2 == 11068046444225730969UL && num <= 53U)))))
			{
				ulong num4 = (ulong)((uint)num2) * 10UL;
				ulong num5 = (ulong)((uint)(num2 >> 32)) * 10UL + (num4 >> 32);
				num2 = (ulong)((uint)num4) + (num5 << 32);
				num3 = (uint)(num5 >> 32) + num3 * 10U;
				if (num != 0U)
				{
					num -= 48U;
					num2 += (ulong)num;
					if (num2 < (ulong)num)
					{
						num3 += 1U;
					}
					num = (uint)(*(++ptr));
				}
				i--;
			}
			if (num >= 53U)
			{
				if (num == 53U && (num2 & 1UL) == 0UL)
				{
					num = (uint)(*(++ptr));
					bool flag = !number.HasNonZeroTail;
					while (num > 0U && flag)
					{
						flag &= (num == 48U);
						num = (uint)(*(++ptr));
					}
					if (flag)
					{
						goto IL_1A8;
					}
				}
				if ((num2 += 1UL) == 0UL && (num3 += 1U) == 0U)
				{
					num2 = 11068046444225730970UL;
					num3 = 429496729U;
					i++;
				}
			}
			IL_1A8:
			if (i > 0)
			{
				return false;
			}
			if (i <= -29)
			{
				value = new decimal(0, 0, 0, isNegative, 28);
			}
			else
			{
				value = new decimal((int)num2, (int)(num2 >> 32), (int)num3, isNegative, (byte)(-(byte)i));
			}
			return true;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x000504DC File Offset: 0x0004E6DC
		internal static TFloat ParseFloat<[IsUnmanaged] TChar, [IsUnmanaged] TFloat>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar> where TFloat : struct, ValueType, IBinaryFloatParseAndFormatInfo<TFloat>
		{
			TFloat result;
			if (!Number.TryParseFloat<TChar, TFloat>(value, styles, info, out result))
			{
				Number.ThrowFormatException<TChar>(value);
			}
			return result;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000504FC File Offset: 0x0004E6FC
		internal unsafe static Number.ParsingStatus TryParseDecimal<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out decimal result) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			Span<byte> digits = new Span<byte>(stackalloc byte[(UIntPtr)31], 31);
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Decimal, digits);
			result = 0m;
			if (!Number.TryStringToNumber<TChar>(value, styles, ref numberBuffer, info))
			{
				return Number.ParsingStatus.Failed;
			}
			if (!Number.TryNumberToDecimal(ref numberBuffer, ref result))
			{
				return Number.ParsingStatus.Overflow;
			}
			return Number.ParsingStatus.OK;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00050541 File Offset: 0x0004E741
		internal unsafe static bool SpanStartsWith<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> span, TChar c) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			return !span.IsEmpty && *span[0] == c;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00050568 File Offset: 0x0004E768
		internal static bool SpanStartsWith<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> span, ReadOnlySpan<TChar> value, StringComparison comparisonType) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (typeof(TChar) == typeof(char))
			{
				ReadOnlySpan<char> span2 = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<char>>(span);
				ReadOnlySpan<char> value2 = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<char>>(value);
				return span2.StartsWith(value2, comparisonType);
			}
			ReadOnlySpan<byte> span3 = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<byte>>(span);
			ReadOnlySpan<byte> value3 = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<byte>>(value);
			return span3.StartsWithUtf8(value3, comparisonType);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000505B9 File Offset: 0x0004E7B9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ReadOnlySpan<TChar> SpanTrim<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> span) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (typeof(TChar) == typeof(char))
			{
				return Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<char>>(span).Trim());
			}
			return Unsafe.BitCast<ReadOnlySpan<byte>, ReadOnlySpan<TChar>>(Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<byte>>(span).TrimUtf8());
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000505F8 File Offset: 0x0004E7F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool SpanEqualsOrdinalIgnoreCase<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> span, ReadOnlySpan<TChar> value) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (typeof(TChar) == typeof(char))
			{
				ReadOnlySpan<char> span2 = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<char>>(span);
				ReadOnlySpan<char> value2 = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<char>>(value);
				return span2.EqualsOrdinalIgnoreCase(value2);
			}
			ReadOnlySpan<byte> span3 = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<byte>>(span);
			ReadOnlySpan<byte> value3 = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<byte>>(value);
			return span3.EqualsOrdinalIgnoreCaseUtf8(value3);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00050648 File Offset: 0x0004E848
		internal unsafe static bool TryParseFloat<[IsUnmanaged] TChar, [IsUnmanaged] TFloat>(ReadOnlySpan<TChar> value, NumberStyles styles, NumberFormatInfo info, out TFloat result) where TChar : struct, ValueType, IUtfChar<TChar> where TFloat : struct, ValueType, IBinaryFloatParseAndFormatInfo<TFloat>
		{
			int numberBufferLength = IBinaryFloatParseAndFormatInfo<TFloat>.NumberBufferLength;
			Span<byte> digits = new Span<byte>(stackalloc byte[(UIntPtr)numberBufferLength], numberBufferLength);
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.FloatingPoint, digits);
			if (Number.TryStringToNumber<TChar>(value, styles, ref numberBuffer, info))
			{
				result = Number.NumberToFloat<TFloat>(ref numberBuffer);
				return true;
			}
			ReadOnlySpan<TChar> span = Number.SpanTrim<TChar>(value);
			ReadOnlySpan<TChar> value2 = info.PositiveInfinitySymbolTChar<TChar>();
			if (Number.SpanEqualsOrdinalIgnoreCase<TChar>(span, value2))
			{
				result = IFloatingPointIeee754<TFloat>.PositiveInfinity;
				return true;
			}
			if (Number.SpanEqualsOrdinalIgnoreCase<TChar>(span, info.NegativeInfinitySymbolTChar<TChar>()))
			{
				result = IFloatingPointIeee754<TFloat>.NegativeInfinity;
				return true;
			}
			ReadOnlySpan<TChar> value3 = info.NaNSymbolTChar<TChar>();
			if (Number.SpanEqualsOrdinalIgnoreCase<TChar>(span, value3))
			{
				result = IFloatingPointIeee754<TFloat>.NaN;
				return true;
			}
			ReadOnlySpan<TChar> value4 = info.PositiveSignTChar<TChar>();
			if (!Number.SpanStartsWith<TChar>(span, value4, StringComparison.OrdinalIgnoreCase))
			{
				ReadOnlySpan<TChar> value5 = info.NegativeSignTChar<TChar>();
				if (Number.SpanStartsWith<TChar>(span, value5, StringComparison.OrdinalIgnoreCase))
				{
					if (Number.SpanEqualsOrdinalIgnoreCase<TChar>(span.Slice(value5.Length), value3))
					{
						result = IFloatingPointIeee754<TFloat>.NaN;
						return true;
					}
					if (info.AllowHyphenDuringParsing() && Number.SpanStartsWith<TChar>(span, IUtfChar<TChar>.CastFrom('-')) && Number.SpanEqualsOrdinalIgnoreCase<TChar>(span.Slice(1), value3))
					{
						result = IFloatingPointIeee754<TFloat>.NaN;
						return true;
					}
				}
				result = INumberBase<TFloat>.Zero;
				return false;
			}
			span = span.Slice(value4.Length);
			if (Number.SpanEqualsOrdinalIgnoreCase<TChar>(span, value2))
			{
				result = IFloatingPointIeee754<TFloat>.PositiveInfinity;
				return true;
			}
			if (Number.SpanEqualsOrdinalIgnoreCase<TChar>(span, value3))
			{
				result = IFloatingPointIeee754<TFloat>.NaN;
				return true;
			}
			result = INumberBase<TFloat>.Zero;
			return false;
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00050804 File Offset: 0x0004EA04
		[DoesNotReturn]
		internal static void ThrowOverflowOrFormatException<[IsUnmanaged] TChar, [IsUnmanaged] TInteger>(Number.ParsingStatus status, ReadOnlySpan<TChar> value) where TChar : struct, ValueType, IUtfChar<TChar> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			if (status == Number.ParsingStatus.Failed)
			{
				Number.ThrowFormatException<TChar>(value);
			}
			Number.ThrowOverflowException<TInteger>();
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00050818 File Offset: 0x0004EA18
		[DoesNotReturn]
		internal static void ThrowFormatException<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> value) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			string message;
			if (typeof(TChar) == typeof(byte))
			{
				ReadOnlySpan<byte> readOnlySpan = Unsafe.BitCast<ReadOnlySpan<TChar>, ReadOnlySpan<byte>>(value);
				message = (Utf8.IsValid(readOnlySpan) ? SR.Format(SR.Format_InvalidStringWithValue, Encoding.UTF8.GetString(readOnlySpan)) : SR.Format_InvalidString);
			}
			else
			{
				message = SR.Format(SR.Format_InvalidStringWithValue, value.ToString());
			}
			throw new FormatException(message);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0005088C File Offset: 0x0004EA8C
		[DoesNotReturn]
		internal static void ThrowOverflowException<[IsUnmanaged] TInteger>() where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			throw new OverflowException(IBinaryIntegerParseAndFormatInfo<TInteger>.OverflowMessage);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0005089E File Offset: 0x0004EA9E
		[DoesNotReturn]
		internal static void ThrowOverflowException(string message)
		{
			throw new OverflowException(message);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000508A8 File Offset: 0x0004EAA8
		internal static TFloat NumberToFloat<[IsUnmanaged] TFloat>(ref Number.NumberBuffer number) where TFloat : struct, ValueType, IBinaryFloatParseAndFormatInfo<TFloat>
		{
			TFloat tfloat;
			if (number.DigitsCount == 0 || number.Scale < IBinaryFloatParseAndFormatInfo<TFloat>.MinDecimalExponent)
			{
				tfloat = INumberBase<TFloat>.Zero;
			}
			else if (number.Scale > IBinaryFloatParseAndFormatInfo<TFloat>.MaxDecimalExponent)
			{
				tfloat = IFloatingPointIeee754<TFloat>.PositiveInfinity;
			}
			else
			{
				tfloat = IBinaryFloatParseAndFormatInfo<TFloat>.BitsToFloat(Number.NumberToFloatingPointBits<TFloat>(ref number));
			}
			if (!number.IsNegative)
			{
				return tfloat;
			}
			return -tfloat;
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00050928 File Offset: 0x0004EB28
		internal unsafe static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
		{
			char c = '\0';
			if (format.Length > 0)
			{
				c = (char)(*format[0]);
				if (char.IsAsciiLetter(c))
				{
					if (format.Length == 1)
					{
						digits = -1;
						return c;
					}
					if (format.Length == 2)
					{
						int num = (int)(*format[1] - 48);
						if (num < 10)
						{
							digits = num;
							return c;
						}
					}
					else if (format.Length == 3)
					{
						int num2 = (int)(*format[1] - 48);
						int num3 = (int)(*format[2] - 48);
						if (num2 < 10 && num3 < 10)
						{
							digits = num2 * 10 + num3;
							return c;
						}
					}
					int num4 = 0;
					int num5 = 1;
					while (num5 < format.Length && char.IsAsciiDigit((char)(*format[num5])))
					{
						if (num4 >= 100000000)
						{
							ThrowHelper.ThrowFormatException_BadFormatSpecifier();
						}
						num4 = num4 * 10 + (int)(*format[num5++]) - 48;
					}
					if (num5 >= format.Length || *format[num5] == 0)
					{
						digits = num4;
						return c;
					}
				}
			}
			digits = -1;
			if (format.Length != 0 && c != '\0')
			{
				return '\0';
			}
			return 'G';
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00050A38 File Offset: 0x0004EC38
		internal unsafe static void NumberToString<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, ref Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			bool isCorrectlyRounded = number.Kind == Number.NumberBufferKind.FloatingPoint;
			if (format <= 'R')
			{
				switch (format)
				{
				case 'C':
					break;
				case 'D':
					goto IL_1F1;
				case 'E':
					goto IL_123;
				case 'F':
					goto IL_B4;
				case 'G':
					goto IL_158;
				default:
					switch (format)
					{
					case 'N':
						goto IL_FC;
					case 'O':
					case 'Q':
						goto IL_1F1;
					case 'P':
						goto IL_1B3;
					case 'R':
						goto IL_1E5;
					default:
						goto IL_1F1;
					}
					break;
				}
			}
			else
			{
				switch (format)
				{
				case 'c':
					break;
				case 'd':
					goto IL_1F1;
				case 'e':
					goto IL_123;
				case 'f':
					goto IL_B4;
				case 'g':
					goto IL_158;
				default:
					switch (format)
					{
					case 'n':
						goto IL_FC;
					case 'o':
					case 'q':
						goto IL_1F1;
					case 'p':
						goto IL_1B3;
					case 'r':
						goto IL_1E5;
					default:
						goto IL_1F1;
					}
					break;
				}
			}
			if (nMaxDigits < 0)
			{
				nMaxDigits = info.CurrencyDecimalDigits;
			}
			Number.RoundNumber(ref number, number.Scale + nMaxDigits, isCorrectlyRounded);
			Number.FormatCurrency<TChar>(ref vlb, ref number, nMaxDigits, info);
			return;
			IL_B4:
			if (nMaxDigits < 0)
			{
				nMaxDigits = info.NumberDecimalDigits;
			}
			Number.RoundNumber(ref number, number.Scale + nMaxDigits, isCorrectlyRounded);
			if (number.IsNegative)
			{
				vlb.Append(info.NegativeSignTChar<TChar>());
			}
			Number.FormatFixed<TChar>(ref vlb, ref number, nMaxDigits, null, info.NumberDecimalSeparatorTChar<TChar>(), null);
			return;
			IL_FC:
			if (nMaxDigits < 0)
			{
				nMaxDigits = info.NumberDecimalDigits;
			}
			Number.RoundNumber(ref number, number.Scale + nMaxDigits, isCorrectlyRounded);
			Number.FormatNumber<TChar>(ref vlb, ref number, nMaxDigits, info);
			return;
			IL_123:
			if (nMaxDigits < 0)
			{
				nMaxDigits = 6;
			}
			nMaxDigits++;
			Number.RoundNumber(ref number, nMaxDigits, isCorrectlyRounded);
			if (number.IsNegative)
			{
				vlb.Append(info.NegativeSignTChar<TChar>());
			}
			Number.FormatScientific<TChar>(ref vlb, ref number, nMaxDigits, info, format);
			return;
			IL_158:
			bool suppressScientific = false;
			if (nMaxDigits < 1)
			{
				if (number.Kind == Number.NumberBufferKind.Decimal && nMaxDigits == -1)
				{
					suppressScientific = true;
					if (*number.Digits[0] == 0)
					{
						goto IL_1A3;
					}
					goto IL_18E;
				}
				else
				{
					nMaxDigits = number.DigitsCount;
				}
			}
			Number.RoundNumber(ref number, nMaxDigits, isCorrectlyRounded);
			IL_18E:
			if (number.IsNegative)
			{
				vlb.Append(info.NegativeSignTChar<TChar>());
			}
			IL_1A3:
			Number.FormatGeneral<TChar>(ref vlb, ref number, nMaxDigits, info, format - '\u0002', suppressScientific);
			return;
			IL_1B3:
			if (nMaxDigits < 0)
			{
				nMaxDigits = info.PercentDecimalDigits;
			}
			number.Scale += 2;
			Number.RoundNumber(ref number, number.Scale + nMaxDigits, isCorrectlyRounded);
			Number.FormatPercent<TChar>(ref vlb, ref number, nMaxDigits, info);
			return;
			IL_1E5:
			format -= '\v';
			goto IL_158;
			IL_1F1:
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00050C3C File Offset: 0x0004EE3C
		internal unsafe static void NumberToStringFormat<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, ref Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = 0;
			byte* digitsPtr = number.DigitsPtr;
			int num2 = Number.FindSection(format, (*digitsPtr == 0) ? 2 : ((number.IsNegative > false) ? 1 : 0));
			int num3;
			int num4;
			int num5;
			int num6;
			bool flag;
			bool flag2;
			int i;
			for (;;)
			{
				num3 = 0;
				num4 = -1;
				num5 = int.MaxValue;
				num6 = 0;
				flag = false;
				int num7 = -1;
				flag2 = false;
				int num8 = 0;
				i = num2;
				fixed (char* reference = MemoryMarshal.GetReference<char>(format))
				{
					char* ptr = reference;
					char c;
					while (i < format.Length && (c = ptr[(IntPtr)(i++) * 2]) != '\0' && c != ';')
					{
						if (c <= 'E')
						{
							switch (c)
							{
							case '"':
							case '\'':
								while (i < format.Length && ptr[i] != '\0')
								{
									if (ptr[(IntPtr)(i++) * 2] == c)
									{
										break;
									}
								}
								continue;
							case '#':
								num3++;
								continue;
							case '$':
							case '&':
								continue;
							case '%':
								num8 += 2;
								continue;
							default:
								switch (c)
								{
								case ',':
									if (num3 > 0 && num4 < 0)
									{
										if (num7 >= 0)
										{
											if (num7 == num3)
											{
												num++;
												continue;
											}
											flag2 = true;
										}
										num7 = num3;
										num = 1;
										continue;
									}
									continue;
								case '-':
								case '/':
									continue;
								case '.':
									if (num4 < 0)
									{
										num4 = num3;
										continue;
									}
									continue;
								case '0':
									if (num5 == 2147483647)
									{
										num5 = num3;
									}
									num3++;
									num6 = num3;
									continue;
								default:
									if (c != 'E')
									{
										continue;
									}
									break;
								}
								break;
							}
						}
						else if (c != '\\')
						{
							if (c != 'e')
							{
								if (c != '‰')
								{
									continue;
								}
								num8 += 3;
								continue;
							}
						}
						else
						{
							if (i < format.Length && ptr[i] != '\0')
							{
								i++;
								continue;
							}
							continue;
						}
						if ((i < format.Length && ptr[i] == '0') || (i + 1 < format.Length && (ptr[i] == '+' || ptr[i] == '-') && ptr[i + 1] == '0'))
						{
							while (++i < format.Length && ptr[i] == '0')
							{
							}
							flag = true;
						}
					}
				}
				if (num4 < 0)
				{
					num4 = num3;
				}
				if (num7 >= 0)
				{
					if (num7 == num4)
					{
						num8 -= num * 3;
					}
					else
					{
						flag2 = true;
					}
				}
				if (*digitsPtr == 0)
				{
					break;
				}
				number.Scale += num8;
				int pos = flag ? num3 : (number.Scale + num3 - num4);
				Number.RoundNumber(ref number, pos, false);
				if (*digitsPtr != 0)
				{
					goto IL_2A5;
				}
				i = Number.FindSection(format, 2);
				if (i == num2)
				{
					goto IL_2A5;
				}
				num2 = i;
			}
			if (number.Kind != Number.NumberBufferKind.FloatingPoint)
			{
				number.IsNegative = false;
			}
			number.Scale = 0;
			IL_2A5:
			num5 = ((num5 < num4) ? (num4 - num5) : 0);
			num6 = ((num6 > num4) ? (num4 - num6) : 0);
			int num9;
			int j;
			if (flag)
			{
				num9 = num4;
				j = 0;
			}
			else
			{
				num9 = ((number.Scale > num4) ? number.Scale : num4);
				j = number.Scale - num4;
			}
			i = num2;
			Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)16], 4);
			int num10 = -1;
			if (flag2 && info.NumberGroupSeparator.Length > 0)
			{
				int[] array = info.NumberGroupSizes();
				int num11 = 0;
				int num12 = 0;
				int num13 = array.Length;
				if (num13 != 0)
				{
					num12 = array[num11];
				}
				int num14 = num12;
				int num15 = num9 + ((j < 0) ? j : 0);
				int num16 = (num5 > num15) ? num5 : num15;
				while (num16 > num12 && num14 != 0)
				{
					num10++;
					if (num10 >= span.Length)
					{
						int[] array2 = new int[span.Length * 2];
						span.CopyTo(array2);
						span = array2;
					}
					*span[num10] = num12;
					if (num11 < num13 - 1)
					{
						num11++;
						num14 = array[num11];
					}
					num12 += num14;
				}
			}
			if (number.IsNegative && num2 == 0 && number.Scale != 0)
			{
				vlb.Append(info.NegativeSignTChar<TChar>());
			}
			bool flag3 = false;
			fixed (char* reference = MemoryMarshal.GetReference<char>(format))
			{
				char* ptr2 = reference;
				byte* ptr3 = digitsPtr;
				char c;
				while (i < format.Length && (c = ptr2[(IntPtr)(i++) * 2]) != '\0' && c != ';')
				{
					if (j > 0)
					{
						if (c == '#' || c == '.' || c == '0')
						{
							while (j > 0)
							{
								vlb.Append(IUtfChar<TChar>.CastFrom((char)((*ptr3 != 0) ? (*(ptr3++)) : 48)));
								if (flag2 && num9 > 1 && num10 >= 0 && num9 == *span[num10] + 1)
								{
									vlb.Append(info.NumberGroupSeparatorTChar<TChar>());
									num10--;
								}
								num9--;
								j--;
							}
						}
					}
					if (c <= 'E')
					{
						switch (c)
						{
						case '"':
						case '\'':
							while (i < format.Length && ptr2[i] != '\0' && ptr2[i] != c)
							{
								Number.AppendUnknownChar<TChar>(ref vlb, ptr2[(IntPtr)(i++) * 2]);
							}
							if (i < format.Length && ptr2[i] != '\0')
							{
								i++;
								continue;
							}
							continue;
						case '#':
							break;
						case '$':
						case '&':
							goto IL_7C4;
						case '%':
							vlb.Append(info.PercentSymbolTChar<TChar>());
							continue;
						default:
							switch (c)
							{
							case ',':
								continue;
							case '-':
							case '/':
								goto IL_7C4;
							case '.':
								if (num9 == 0 && !flag3 && (num6 < 0 || (num4 < num3 && *ptr3 != 0)))
								{
									vlb.Append(info.NumberDecimalSeparatorTChar<TChar>());
									flag3 = true;
									continue;
								}
								continue;
							case '0':
								break;
							default:
								if (c != 'E')
								{
									goto IL_7C4;
								}
								goto IL_656;
							}
							break;
						}
						if (j < 0)
						{
							j++;
							c = ((num9 <= num5) ? '0' : '\0');
						}
						else
						{
							c = (char)((*ptr3 != 0) ? (*(ptr3++)) : ((num9 > num6) ? 48 : 0));
						}
						if (c != '\0')
						{
							vlb.Append(IUtfChar<TChar>.CastFrom(c));
							if (flag2 && num9 > 1 && num10 >= 0 && num9 == *span[num10] + 1)
							{
								vlb.Append(info.NumberGroupSeparatorTChar<TChar>());
								num10--;
							}
						}
						num9--;
						continue;
					}
					if (c != '\\')
					{
						if (c != 'e')
						{
							if (c != '‰')
							{
								goto IL_7C4;
							}
							vlb.Append(info.PerMilleSymbolTChar<TChar>());
							continue;
						}
					}
					else
					{
						if (i < format.Length && ptr2[i] != '\0')
						{
							Number.AppendUnknownChar<TChar>(ref vlb, ptr2[(IntPtr)(i++) * 2]);
							continue;
						}
						continue;
					}
					IL_656:
					bool positiveSign = false;
					int num17 = 0;
					if (flag)
					{
						if (i < format.Length && ptr2[i] == '0')
						{
							num17++;
						}
						else if (i + 1 < format.Length && ptr2[i] == '+' && ptr2[i + 1] == '0')
						{
							positiveSign = true;
						}
						else if (i + 1 >= format.Length || ptr2[i] != '-' || ptr2[i + 1] != '0')
						{
							vlb.Append(IUtfChar<TChar>.CastFrom(c));
							continue;
						}
						while (++i < format.Length && ptr2[i] == '0')
						{
							num17++;
						}
						if (num17 > 10)
						{
							num17 = 10;
						}
						int value = (*digitsPtr == 0) ? 0 : (number.Scale - num4);
						Number.FormatExponent<TChar>(ref vlb, info, value, c, num17, positiveSign);
						flag = false;
						continue;
					}
					vlb.Append(IUtfChar<TChar>.CastFrom(c));
					if (i < format.Length)
					{
						if (ptr2[i] == '+' || ptr2[i] == '-')
						{
							Number.AppendUnknownChar<TChar>(ref vlb, ptr2[(IntPtr)(i++) * 2]);
						}
						while (i < format.Length)
						{
							if (ptr2[i] != '0')
							{
								break;
							}
							Number.AppendUnknownChar<TChar>(ref vlb, ptr2[(IntPtr)(i++) * 2]);
						}
						continue;
					}
					continue;
					IL_7C4:
					Number.AppendUnknownChar<TChar>(ref vlb, c);
				}
			}
			if (number.IsNegative && num2 == 0 && number.Scale == 0 && vlb.Length > 0)
			{
				vlb.Insert(0, info.NegativeSignTChar<TChar>());
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0005146C File Offset: 0x0004F66C
		private static void FormatCurrency<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, ref Number.NumberBuffer number, int nMaxDigits, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			foreach (char c in number.IsNegative ? Number.s_negCurrencyFormats[info.CurrencyNegativePattern] : Number.s_posCurrencyFormats[info.CurrencyPositivePattern])
			{
				if (c != '#')
				{
					if (c != '$')
					{
						if (c != '-')
						{
							vlb.Append(IUtfChar<TChar>.CastFrom(c));
						}
						else
						{
							vlb.Append(info.NegativeSignTChar<TChar>());
						}
					}
					else
					{
						vlb.Append(info.CurrencySymbolTChar<TChar>());
					}
				}
				else
				{
					Number.FormatFixed<TChar>(ref vlb, ref number, nMaxDigits, info.CurrencyGroupSizes(), info.CurrencyDecimalSeparatorTChar<TChar>(), info.CurrencyGroupSeparatorTChar<TChar>());
				}
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00051510 File Offset: 0x0004F710
		private unsafe static void FormatFixed<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, ref Number.NumberBuffer number, int nMaxDigits, int[] groupDigits, ReadOnlySpan<TChar> sDecimal, ReadOnlySpan<TChar> sGroup) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int i = number.Scale;
			byte* ptr = number.DigitsPtr;
			if (i > 0)
			{
				if (groupDigits != null)
				{
					int num = 0;
					int num2 = i;
					int num3 = 0;
					if (groupDigits.Length != 0)
					{
						int num4 = groupDigits[num];
						while (i > num4)
						{
							num3 = groupDigits[num];
							if (num3 == 0)
							{
								break;
							}
							num2 += sGroup.Length;
							if (num < groupDigits.Length - 1)
							{
								num++;
							}
							num4 += groupDigits[num];
							ArgumentOutOfRangeException.ThrowIfNegative<int>(num4 | num2, string.Empty);
						}
						num3 = ((num4 == 0) ? 0 : groupDigits[0]);
					}
					num = 0;
					int num5 = 0;
					int digitsCount = number.DigitsCount;
					int num6 = (i < digitsCount) ? i : digitsCount;
					fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(vlb.AppendSpan(num2)))
					{
						TChar* ptr2 = reference + (IntPtr)num2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar) - sizeof(TChar) / sizeof(TChar);
						for (int j = i - 1; j >= 0; j--)
						{
							TChar* ptr3 = ptr2;
							ptr2 = ptr3 - sizeof(TChar) / sizeof(TChar);
							*ptr3 = IUtfChar<TChar>.CastFrom((char)((j < num6) ? ptr[j] : 48));
							if (num3 > 0)
							{
								num5++;
								if (num5 == num3 && j != 0)
								{
									for (int k = sGroup.Length - 1; k >= 0; k--)
									{
										TChar* ptr4 = ptr2;
										ptr2 = ptr4 - sizeof(TChar) / sizeof(TChar);
										*ptr4 = *sGroup[k];
									}
									if (num < groupDigits.Length - 1)
									{
										num++;
										num3 = groupDigits[num];
									}
									num5 = 0;
								}
							}
						}
						ptr += num6;
					}
				}
				else
				{
					do
					{
						vlb.Append(IUtfChar<TChar>.CastFrom((char)((*ptr != 0) ? (*(ptr++)) : 48)));
					}
					while (--i > 0);
				}
			}
			else
			{
				vlb.Append(IUtfChar<TChar>.CastFrom('0'));
			}
			if (nMaxDigits > 0)
			{
				vlb.Append(sDecimal);
				if (i < 0 && nMaxDigits > 0)
				{
					int num7 = Math.Min(-i, nMaxDigits);
					for (int l = 0; l < num7; l++)
					{
						vlb.Append(IUtfChar<TChar>.CastFrom('0'));
					}
					i += num7;
					nMaxDigits -= num7;
				}
				while (nMaxDigits > 0)
				{
					vlb.Append(IUtfChar<TChar>.CastFrom((char)((*ptr != 0) ? (*(ptr++)) : 48)));
					nMaxDigits--;
				}
			}
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0005172E File Offset: 0x0004F92E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void AppendUnknownChar<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, char ch) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (sizeof(TChar) == 2 || char.IsAscii(ch))
			{
				vlb.Append(IUtfChar<TChar>.CastFrom(ch));
				return;
			}
			Number.<AppendUnknownChar>g__AppendNonAsciiBytes|156_0<TChar>(ref vlb, ch);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0005175C File Offset: 0x0004F95C
		private static void FormatNumber<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, ref Number.NumberBuffer number, int nMaxDigits, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			foreach (char c in number.IsNegative ? Number.s_negNumberFormats[info.NumberNegativePattern] : "#")
			{
				if (c != '#')
				{
					if (c != '-')
					{
						vlb.Append(IUtfChar<TChar>.CastFrom(c));
					}
					else
					{
						vlb.Append(info.NegativeSignTChar<TChar>());
					}
				}
				else
				{
					Number.FormatFixed<TChar>(ref vlb, ref number, nMaxDigits, info.NumberGroupSizes(), info.NumberDecimalSeparatorTChar<TChar>(), info.NumberGroupSeparatorTChar<TChar>());
				}
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000517E8 File Offset: 0x0004F9E8
		private unsafe static void FormatScientific<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, ref Number.NumberBuffer number, int nMaxDigits, NumberFormatInfo info, char expChar) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			byte* digitsPtr = number.DigitsPtr;
			vlb.Append(IUtfChar<TChar>.CastFrom((char)((*digitsPtr != 0) ? (*(digitsPtr++)) : 48)));
			if (nMaxDigits != 1)
			{
				vlb.Append(info.NumberDecimalSeparatorTChar<TChar>());
			}
			while (--nMaxDigits > 0)
			{
				vlb.Append(IUtfChar<TChar>.CastFrom((char)((*digitsPtr != 0) ? (*(digitsPtr++)) : 48)));
			}
			int value = (*number.Digits[0] == 0) ? 0 : (number.Scale - 1);
			Number.FormatExponent<TChar>(ref vlb, info, value, expChar, 3, true);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0005187C File Offset: 0x0004FA7C
		private unsafe static void FormatExponent<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			vlb.Append(IUtfChar<TChar>.CastFrom(expChar));
			if (value < 0)
			{
				vlb.Append(info.NegativeSignTChar<TChar>());
				value = -value;
			}
			else if (positiveSign)
			{
				vlb.Append(info.PositiveSignTChar<TChar>());
			}
			TChar* ptr = stackalloc TChar[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(TChar))];
			TChar* ptr2 = Number.UInt32ToDecChars<TChar>(ptr + (IntPtr)10 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), (uint)value, minDigits);
			vlb.Append(new ReadOnlySpan<TChar>((void*)ptr2, (int)((long)((ptr + (IntPtr)10 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar) - ptr2) / (IntPtr)sizeof(TChar) * (IntPtr)sizeof(TChar)))));
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00051908 File Offset: 0x0004FB08
		private unsafe static void FormatGeneral<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, ref Number.NumberBuffer number, int nMaxDigits, NumberFormatInfo info, char expChar, bool suppressScientific) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int i = number.Scale;
			bool flag = false;
			if (!suppressScientific && (i > nMaxDigits || i < -3))
			{
				i = 1;
				flag = true;
			}
			byte* digitsPtr = number.DigitsPtr;
			if (i > 0)
			{
				do
				{
					vlb.Append(IUtfChar<TChar>.CastFrom((char)((*digitsPtr != 0) ? (*(digitsPtr++)) : 48)));
				}
				while (--i > 0);
			}
			else
			{
				vlb.Append(IUtfChar<TChar>.CastFrom('0'));
			}
			if (*digitsPtr != 0 || i < 0)
			{
				vlb.Append(info.NumberDecimalSeparatorTChar<TChar>());
				while (i < 0)
				{
					vlb.Append(IUtfChar<TChar>.CastFrom('0'));
					i++;
				}
				while (*digitsPtr != 0)
				{
					vlb.Append(IUtfChar<TChar>.CastFrom(*(digitsPtr++)));
				}
			}
			if (flag)
			{
				Number.FormatExponent<TChar>(ref vlb, info, number.Scale - 1, expChar, 2, true);
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x000519DC File Offset: 0x0004FBDC
		private static void FormatPercent<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, ref Number.NumberBuffer number, int nMaxDigits, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			foreach (char c in number.IsNegative ? Number.s_negPercentFormats[info.PercentNegativePattern] : Number.s_posPercentFormats[info.PercentPositivePattern])
			{
				if (c != '#')
				{
					if (c != '%')
					{
						if (c != '-')
						{
							vlb.Append(IUtfChar<TChar>.CastFrom(c));
						}
						else
						{
							vlb.Append(info.NegativeSignTChar<TChar>());
						}
					}
					else
					{
						vlb.Append(info.PercentSymbolTChar<TChar>());
					}
				}
				else
				{
					Number.FormatFixed<TChar>(ref vlb, ref number, nMaxDigits, info.PercentGroupSizes(), info.PercentDecimalSeparatorTChar<TChar>(), info.PercentGroupSeparatorTChar<TChar>());
				}
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00051A80 File Offset: 0x0004FC80
		internal unsafe static void RoundNumber(ref Number.NumberBuffer number, int pos, bool isCorrectlyRounded)
		{
			byte* digitsPtr = number.DigitsPtr;
			int num = 0;
			while (num < pos && digitsPtr[num] != 0)
			{
				num++;
			}
			if (num == pos && Number.<RoundNumber>g__ShouldRoundUp|162_0(digitsPtr, num, number.Kind, isCorrectlyRounded))
			{
				while (num > 0 && digitsPtr[num - 1] == 57)
				{
					num--;
				}
				if (num > 0)
				{
					byte* ptr = digitsPtr + (num - 1);
					*ptr += 1;
				}
				else
				{
					number.Scale++;
					*digitsPtr = 49;
					num = 1;
				}
			}
			else
			{
				while (num > 0 && digitsPtr[num - 1] == 48)
				{
					num--;
				}
			}
			if (num == 0)
			{
				if (number.Kind != Number.NumberBufferKind.FloatingPoint)
				{
					number.IsNegative = false;
				}
				number.Scale = 0;
			}
			digitsPtr[num] = 0;
			number.DigitsCount = num;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00051B2C File Offset: 0x0004FD2C
		private unsafe static int FindSection(ReadOnlySpan<char> format, int section)
		{
			if (section == 0)
			{
				return 0;
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(format))
			{
				char* ptr = reference;
				int i = 0;
				while (i < format.Length)
				{
					char c2;
					char c = c2 = ptr[(IntPtr)(i++) * 2];
					if (c2 <= '"')
					{
						if (c2 == '\0')
						{
							return 0;
						}
						if (c2 != '"')
						{
							continue;
						}
					}
					else if (c2 != '\'')
					{
						if (c2 != ';')
						{
							if (c2 != '\\')
							{
								continue;
							}
							if (i < format.Length && ptr[i] != '\0')
							{
								i++;
								continue;
							}
							continue;
						}
						else
						{
							if (--section != 0)
							{
								continue;
							}
							if (i < format.Length && ptr[i] != '\0' && ptr[i] != ';')
							{
								return i;
							}
							return 0;
						}
					}
					while (i < format.Length && ptr[i] != '\0')
					{
						if (ptr[(IntPtr)(i++) * 2] == c)
						{
							break;
						}
					}
				}
				return 0;
			}
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00051BF6 File Offset: 0x0004FDF6
		private static int[] NumberGroupSizes(this NumberFormatInfo info)
		{
			return info._numberGroupSizes;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00051BFE File Offset: 0x0004FDFE
		private static int[] CurrencyGroupSizes(this NumberFormatInfo info)
		{
			return info._currencyGroupSizes;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00051C06 File Offset: 0x0004FE06
		private static int[] PercentGroupSizes(this NumberFormatInfo info)
		{
			return info._percentGroupSizes;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00051C10 File Offset: 0x0004FE10
		private unsafe static bool TryParseNumber<[IsUnmanaged] TChar>([ScopedRef] ref TChar* str, TChar* strEnd, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			ReadOnlySpan<TChar> value = ReadOnlySpan<TChar>.Empty;
			bool flag = false;
			ReadOnlySpan<TChar> value2;
			ReadOnlySpan<TChar> value3;
			if ((styles & NumberStyles.AllowCurrencySymbol) != NumberStyles.None)
			{
				value = info.CurrencySymbolTChar<TChar>();
				value2 = info.CurrencyDecimalSeparatorTChar<TChar>();
				value3 = info.CurrencyGroupSeparatorTChar<TChar>();
				flag = true;
			}
			else
			{
				value2 = info.NumberDecimalSeparatorTChar<TChar>();
				value3 = info.NumberGroupSeparatorTChar<TChar>();
			}
			int num = 0;
			TChar* ptr = str;
			uint num2 = (ptr < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U;
			for (;;)
			{
				if (!Number.IsWhite(num2) || (styles & NumberStyles.AllowLeadingWhite) == NumberStyles.None || ((num & 1) != 0 && (num & 32) == 0 && info.NumberNegativePattern != 2))
				{
					TChar* ptr2;
					if ((styles & NumberStyles.AllowLeadingSign) != NumberStyles.None && (num & 1) == 0 && ((ptr2 = Number.MatchChars<TChar>(ptr, strEnd, info.PositiveSignTChar<TChar>())) != null || ((ptr2 = Number.MatchNegativeSignChars<TChar>(ptr, strEnd, info)) != null && (number.IsNegative = true))))
					{
						num |= 1;
						ptr = ptr2 - sizeof(TChar) / sizeof(TChar);
					}
					else if (num2 == 40U && (styles & NumberStyles.AllowParentheses) != NumberStyles.None && (num & 1) == 0)
					{
						num |= 3;
						number.IsNegative = true;
					}
					else
					{
						if (value.IsEmpty || (ptr2 = Number.MatchChars<TChar>(ptr, strEnd, value)) == null)
						{
							break;
						}
						num |= 32;
						value = ReadOnlySpan<TChar>.Empty;
						ptr = ptr2 - sizeof(TChar) / sizeof(TChar);
					}
				}
				num2 = (((ptr += sizeof(TChar) / sizeof(TChar)) < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
			}
			int num3 = 0;
			int num4 = 0;
			int num5 = number.Digits.Length - 1;
			int num6 = 0;
			for (;;)
			{
				TChar* ptr2;
				if (Number.IsDigit(num2))
				{
					num |= 4;
					if (num2 != 48U || (num & 8) != 0)
					{
						if (num3 < num5)
						{
							*number.Digits[num3] = (byte)num2;
							if (num2 != 48U || number.Kind != Number.NumberBufferKind.Integer)
							{
								num4 = num3 + 1;
							}
						}
						else if (num2 != 48U)
						{
							number.HasNonZeroTail = true;
						}
						if ((num & 16) == 0)
						{
							number.Scale++;
						}
						if (num3 < num5)
						{
							if (num2 == 48U)
							{
								num6++;
							}
							else
							{
								num6 = 0;
							}
						}
						num3++;
						num |= 8;
					}
					else if ((num & 16) != 0)
					{
						number.Scale--;
					}
				}
				else if ((styles & NumberStyles.AllowDecimalPoint) != NumberStyles.None && (num & 16) == 0 && ((ptr2 = Number.MatchChars<TChar>(ptr, strEnd, value2)) != null || (flag && (num & 32) == 0 && (ptr2 = Number.MatchChars<TChar>(ptr, strEnd, info.NumberDecimalSeparatorTChar<TChar>())) != null)))
				{
					num |= 16;
					ptr = ptr2 - sizeof(TChar) / sizeof(TChar);
				}
				else
				{
					if ((styles & NumberStyles.AllowThousands) == NumberStyles.None || (num & 4) == 0 || (num & 16) != 0 || ((ptr2 = Number.MatchChars<TChar>(ptr, strEnd, value3)) == null && (!flag || (num & 32) != 0 || (ptr2 = Number.MatchChars<TChar>(ptr, strEnd, info.NumberGroupSeparatorTChar<TChar>())) == null)))
					{
						break;
					}
					ptr = ptr2 - sizeof(TChar) / sizeof(TChar);
				}
				num2 = (((ptr += sizeof(TChar) / sizeof(TChar)) < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
			}
			bool flag2 = false;
			number.DigitsCount = num4;
			*number.Digits[num4] = 0;
			if ((num & 4) != 0)
			{
				if ((num2 == 69U || num2 == 101U) && (styles & NumberStyles.AllowExponent) != NumberStyles.None)
				{
					TChar* ptr3 = ptr;
					num2 = (((ptr += sizeof(TChar) / sizeof(TChar)) < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
					TChar* ptr2;
					if ((ptr2 = Number.MatchChars<TChar>(ptr, strEnd, info.PositiveSignTChar<TChar>())) != null)
					{
						num2 = (((ptr = ptr2) < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
					}
					else if ((ptr2 = Number.MatchNegativeSignChars<TChar>(ptr, strEnd, info)) != null)
					{
						num2 = (((ptr = ptr2) < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
						flag2 = true;
					}
					if (Number.IsDigit(num2))
					{
						int i = 0;
						while (i < 100000000)
						{
							i = i * 10 + (int)(num2 - 48U);
							num2 = (((ptr += sizeof(TChar) / sizeof(TChar)) < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
							if (!Number.IsDigit(num2))
							{
								IL_457:
								if (flag2)
								{
									i = -i;
								}
								number.Scale += i;
								goto IL_48E;
							}
						}
						i = int.MaxValue;
						number.Scale = 0;
						while (Number.IsDigit(num2))
						{
							num2 = (((ptr += sizeof(TChar) / sizeof(TChar)) < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
						}
						goto IL_457;
					}
					ptr = ptr3;
					num2 = ((ptr < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
				}
				IL_48E:
				if (number.Kind == Number.NumberBufferKind.FloatingPoint && !number.HasNonZeroTail)
				{
					int num7 = num4 - number.Scale;
					if (num7 > 0)
					{
						num6 = Math.Min(num6, num7);
						number.DigitsCount = num4 - num6;
						*number.Digits[number.DigitsCount] = 0;
					}
				}
				for (;;)
				{
					if (!Number.IsWhite(num2) || (styles & NumberStyles.AllowTrailingWhite) == NumberStyles.None)
					{
						TChar* ptr2;
						if ((styles & NumberStyles.AllowTrailingSign) != NumberStyles.None && (num & 1) == 0 && ((ptr2 = Number.MatchChars<TChar>(ptr, strEnd, info.PositiveSignTChar<TChar>())) != null || ((ptr2 = Number.MatchNegativeSignChars<TChar>(ptr, strEnd, info)) != null && (number.IsNegative = true))))
						{
							num |= 1;
							ptr = ptr2 - sizeof(TChar) / sizeof(TChar);
						}
						else if (num2 == 41U && (num & 2) != 0)
						{
							num &= -3;
						}
						else
						{
							if (value.IsEmpty || (ptr2 = Number.MatchChars<TChar>(ptr, strEnd, value)) == null)
							{
								break;
							}
							value = ReadOnlySpan<TChar>.Empty;
							ptr = ptr2 - sizeof(TChar) / sizeof(TChar);
						}
					}
					num2 = (((ptr += sizeof(TChar) / sizeof(TChar)) < strEnd) ? IUtfChar<TChar>.CastToUInt32(*ptr) : 0U);
				}
				if ((num & 2) == 0)
				{
					if ((num & 8) == 0)
					{
						if (number.Kind != Number.NumberBufferKind.Decimal)
						{
							number.Scale = 0;
						}
						if (number.Kind == Number.NumberBufferKind.Integer && (num & 16) == 0)
						{
							number.IsNegative = false;
						}
					}
					str = ptr;
					return true;
				}
			}
			str = ptr;
			return false;
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00052204 File Offset: 0x00050404
		internal unsafe static bool TryStringToNumber<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> value, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(value))
			{
				TChar* ptr = reference;
				TChar* ptr2 = ptr;
				if (!Number.TryParseNumber<TChar>(ref ptr2, ptr2 + (IntPtr)value.Length * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), styles, ref number, info) || ((int)((long)((ptr2 - ptr) / (IntPtr)sizeof(TChar) * (IntPtr)sizeof(TChar))) < value.Length && !Number.TrailingZeros<TChar>(value, (int)((long)((ptr2 - ptr) / (IntPtr)sizeof(TChar) * (IntPtr)sizeof(TChar))))))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00052269 File Offset: 0x00050469
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool TrailingZeros<[IsUnmanaged] TChar>(ReadOnlySpan<TChar> value, int index) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			return !value.Slice(index).ContainsAnyExcept(IUtfChar<TChar>.CastFrom('\0'));
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00052287 File Offset: 0x00050487
		private static bool IsWhite(uint ch)
		{
			return ch == 32U || ch - 9U <= 4U;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0005229A File Offset: 0x0005049A
		private static bool IsDigit(uint ch)
		{
			return ch - 48U <= 9U;
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x000392BF File Offset: 0x000374BF
		private static bool IsSpaceReplacingChar(uint c)
		{
			return c == 160U || c == 8239U;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000522A8 File Offset: 0x000504A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static TChar* MatchNegativeSignChars<[IsUnmanaged] TChar>(TChar* p, TChar* pEnd, NumberFormatInfo info) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			TChar* ptr = Number.MatchChars<TChar>(p, pEnd, info.NegativeSignTChar<TChar>());
			if (ptr == null && info.AllowHyphenDuringParsing() && p < pEnd && IUtfChar<TChar>.CastToUInt32(*p) == 45U)
			{
				ptr = p + sizeof(TChar) / sizeof(TChar);
			}
			return ptr;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000522F4 File Offset: 0x000504F4
		private unsafe static TChar* MatchChars<[IsUnmanaged] TChar>(TChar* p, TChar* pEnd, ReadOnlySpan<TChar> value) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(value))
			{
				TChar* ptr = reference;
				if (IUtfChar<TChar>.CastToUInt32(*ptr) != 0U)
				{
					do
					{
						uint num = (p < pEnd) ? IUtfChar<TChar>.CastToUInt32(*p) : 0U;
						uint num2 = IUtfChar<TChar>.CastToUInt32(*ptr);
						if (num != num2 && (!Number.IsSpaceReplacingChar(num2) || num != 32U))
						{
							goto IL_81;
						}
						p += sizeof(TChar) / sizeof(TChar);
						ptr += sizeof(TChar) / sizeof(TChar);
					}
					while (IUtfChar<TChar>.CastToUInt32(*ptr) != 0U);
					return p;
				}
				IL_81:;
			}
			return null;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00052570 File Offset: 0x00050770
		[CompilerGenerated]
		internal unsafe static string <FormatInt32>g__FormatInt32Slow|18_0(int value, int hexMask, string format, IFormatProvider provider)
		{
			ReadOnlySpan<char> format2 = format;
			int num;
			char c = Number.ParseFormatSpecifier(format2, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				if (value < 0)
				{
					return Number.NegativeInt32ToDecStr(value, num, NumberFormatInfo.GetInstance(provider).NegativeSign);
				}
				return Number.UInt32ToDecStr((uint)value, num);
			}
			else
			{
				if (c2 == 'X')
				{
					return Number.Int32ToHexStr(value & hexMask, Number.GetHexBase(c), num);
				}
				if (c2 == 'B')
				{
					return Number.UInt32ToBinaryStr((uint)(value & hexMask), num);
				}
				NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
				byte* digits = stackalloc byte[(UIntPtr)11];
				Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 11);
				Number.Int32ToNumber(value, ref numberBuffer);
				char* pointer = stackalloc char[(UIntPtr)64];
				ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(new Span<char>((void*)pointer, 32));
				if (c != '\0')
				{
					Number.NumberToString<char>(ref valueListBuilder, ref numberBuffer, c, num, instance);
				}
				else
				{
					Number.NumberToStringFormat<char>(ref valueListBuilder, ref numberBuffer, format2, instance);
				}
				string result = valueListBuilder.AsSpan().ToString();
				valueListBuilder.Dispose();
				return result;
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00052660 File Offset: 0x00050860
		[CompilerGenerated]
		internal unsafe static bool <TryFormatInt32>g__TryFormatInt32Slow|19_0<[IsUnmanaged] TChar>(int value, int hexMask, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num;
			char c = Number.ParseFormatSpecifier(format, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				if (value < 0)
				{
					return Number.TryNegativeInt32ToDecStr<TChar>(value, num, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
				}
				return Number.TryUInt32ToDecStr<TChar>((uint)value, num, destination, out charsWritten);
			}
			else
			{
				if (c2 == 'X')
				{
					return Number.TryInt32ToHexStr<TChar>(value & hexMask, Number.GetHexBase(c), num, destination, out charsWritten);
				}
				if (c2 == 'B')
				{
					return Number.TryUInt32ToBinaryStr<TChar>((uint)(value & hexMask), num, destination, out charsWritten);
				}
				NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
				byte* digits = stackalloc byte[(UIntPtr)11];
				Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 11);
				Number.Int32ToNumber(value, ref numberBuffer);
				TChar* pointer = stackalloc TChar[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(TChar))];
				ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(new Span<TChar>((void*)pointer, 32));
				if (c != '\0')
				{
					Number.NumberToString<TChar>(ref valueListBuilder, ref numberBuffer, c, num, instance);
				}
				else
				{
					Number.NumberToStringFormat<TChar>(ref valueListBuilder, ref numberBuffer, format, instance);
				}
				bool result = valueListBuilder.TryCopyTo(destination, out charsWritten);
				valueListBuilder.Dispose();
				return result;
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00052754 File Offset: 0x00050954
		[CompilerGenerated]
		internal unsafe static string <FormatUInt32>g__FormatUInt32Slow|20_0(uint value, string format, IFormatProvider provider)
		{
			ReadOnlySpan<char> format2 = format;
			int num;
			char c = Number.ParseFormatSpecifier(format2, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				return Number.UInt32ToDecStr(value, num);
			}
			if (c2 == 'X')
			{
				return Number.Int32ToHexStr((int)value, Number.GetHexBase(c), num);
			}
			if (c2 == 'B')
			{
				return Number.UInt32ToBinaryStr(value, num);
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			byte* digits = stackalloc byte[(UIntPtr)11];
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 11);
			Number.UInt32ToNumber(value, ref numberBuffer);
			char* pointer = stackalloc char[(UIntPtr)64];
			ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(new Span<char>((void*)pointer, 32));
			if (c != '\0')
			{
				Number.NumberToString<char>(ref valueListBuilder, ref numberBuffer, c, num, instance);
			}
			else
			{
				Number.NumberToStringFormat<char>(ref valueListBuilder, ref numberBuffer, format2, instance);
			}
			string result = valueListBuilder.AsSpan().ToString();
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0005282C File Offset: 0x00050A2C
		[CompilerGenerated]
		internal unsafe static bool <TryFormatUInt32>g__TryFormatUInt32Slow|21_0<[IsUnmanaged] TChar>(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num;
			char c = Number.ParseFormatSpecifier(format, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				return Number.TryUInt32ToDecStr<TChar>(value, num, destination, out charsWritten);
			}
			if (c2 == 'X')
			{
				return Number.TryInt32ToHexStr<TChar>((int)value, Number.GetHexBase(c), num, destination, out charsWritten);
			}
			if (c2 == 'B')
			{
				return Number.TryUInt32ToBinaryStr<TChar>(value, num, destination, out charsWritten);
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			byte* digits = stackalloc byte[(UIntPtr)11];
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 11);
			Number.UInt32ToNumber(value, ref numberBuffer);
			TChar* pointer = stackalloc TChar[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(TChar))];
			ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(new Span<TChar>((void*)pointer, 32));
			if (c != '\0')
			{
				Number.NumberToString<TChar>(ref valueListBuilder, ref numberBuffer, c, num, instance);
			}
			else
			{
				Number.NumberToStringFormat<TChar>(ref valueListBuilder, ref numberBuffer, format, instance);
			}
			bool result = valueListBuilder.TryCopyTo(destination, out charsWritten);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000528FC File Offset: 0x00050AFC
		[CompilerGenerated]
		internal unsafe static string <FormatInt64>g__FormatInt64Slow|22_0(long value, string format, IFormatProvider provider)
		{
			ReadOnlySpan<char> format2 = format;
			int num;
			char c = Number.ParseFormatSpecifier(format2, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				if (value < 0L)
				{
					return Number.NegativeInt64ToDecStr(value, num, NumberFormatInfo.GetInstance(provider).NegativeSign);
				}
				return Number.UInt64ToDecStr((ulong)value, num);
			}
			else
			{
				if (c2 == 'X')
				{
					return Number.Int64ToHexStr(value, Number.GetHexBase(c), num);
				}
				if (c2 == 'B')
				{
					return Number.UInt64ToBinaryStr((ulong)value, num);
				}
				NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
				byte* digits = stackalloc byte[(UIntPtr)20];
				Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 20);
				Number.Int64ToNumber(value, ref numberBuffer);
				char* pointer = stackalloc char[(UIntPtr)64];
				ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(new Span<char>((void*)pointer, 32));
				if (c != '\0')
				{
					Number.NumberToString<char>(ref valueListBuilder, ref numberBuffer, c, num, instance);
				}
				else
				{
					Number.NumberToStringFormat<char>(ref valueListBuilder, ref numberBuffer, format2, instance);
				}
				string result = valueListBuilder.AsSpan().ToString();
				valueListBuilder.Dispose();
				return result;
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000529EC File Offset: 0x00050BEC
		[CompilerGenerated]
		internal unsafe static bool <TryFormatInt64>g__TryFormatInt64Slow|23_0<[IsUnmanaged] TChar>(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num;
			char c = Number.ParseFormatSpecifier(format, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				if (value < 0L)
				{
					return Number.TryNegativeInt64ToDecStr<TChar>(value, num, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
				}
				return Number.TryUInt64ToDecStr<TChar>((ulong)value, num, destination, out charsWritten);
			}
			else
			{
				if (c2 == 'X')
				{
					return Number.TryInt64ToHexStr<TChar>(value, Number.GetHexBase(c), num, destination, out charsWritten);
				}
				if (c2 == 'B')
				{
					return Number.TryUInt64ToBinaryStr<TChar>((ulong)value, num, destination, out charsWritten);
				}
				NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
				byte* digits = stackalloc byte[(UIntPtr)20];
				Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 20);
				Number.Int64ToNumber(value, ref numberBuffer);
				char* pointer = stackalloc char[(UIntPtr)64];
				ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(new Span<TChar>((void*)pointer, 32));
				if (c != '\0')
				{
					Number.NumberToString<TChar>(ref valueListBuilder, ref numberBuffer, c, num, instance);
				}
				else
				{
					Number.NumberToStringFormat<TChar>(ref valueListBuilder, ref numberBuffer, format, instance);
				}
				bool result = valueListBuilder.TryCopyTo(destination, out charsWritten);
				valueListBuilder.Dispose();
				return result;
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00052AD0 File Offset: 0x00050CD0
		[CompilerGenerated]
		internal unsafe static string <FormatUInt64>g__FormatUInt64Slow|24_0(ulong value, string format, IFormatProvider provider)
		{
			ReadOnlySpan<char> format2 = format;
			int num;
			char c = Number.ParseFormatSpecifier(format2, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				return Number.UInt64ToDecStr(value, num);
			}
			if (c2 == 'X')
			{
				return Number.Int64ToHexStr((long)value, Number.GetHexBase(c), num);
			}
			if (c2 == 'B')
			{
				return Number.UInt64ToBinaryStr(value, num);
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			byte* digits = stackalloc byte[(UIntPtr)21];
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 21);
			Number.UInt64ToNumber(value, ref numberBuffer);
			char* pointer = stackalloc char[(UIntPtr)64];
			ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(new Span<char>((void*)pointer, 32));
			if (c != '\0')
			{
				Number.NumberToString<char>(ref valueListBuilder, ref numberBuffer, c, num, instance);
			}
			else
			{
				Number.NumberToStringFormat<char>(ref valueListBuilder, ref numberBuffer, format2, instance);
			}
			string result = valueListBuilder.AsSpan().ToString();
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00052BA8 File Offset: 0x00050DA8
		[CompilerGenerated]
		internal unsafe static bool <TryFormatUInt64>g__TryFormatUInt64Slow|25_0<[IsUnmanaged] TChar>(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num;
			char c = Number.ParseFormatSpecifier(format, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				return Number.TryUInt64ToDecStr<TChar>(value, num, destination, out charsWritten);
			}
			if (c2 == 'X')
			{
				return Number.TryInt64ToHexStr<TChar>((long)value, Number.GetHexBase(c), num, destination, out charsWritten);
			}
			if (c2 == 'B')
			{
				return Number.TryUInt64ToBinaryStr<TChar>(value, num, destination, out charsWritten);
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			byte* digits = stackalloc byte[(UIntPtr)21];
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 21);
			Number.UInt64ToNumber(value, ref numberBuffer);
			TChar* pointer = stackalloc TChar[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(TChar))];
			ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(new Span<TChar>((void*)pointer, 32));
			if (c != '\0')
			{
				Number.NumberToString<TChar>(ref valueListBuilder, ref numberBuffer, c, num, instance);
			}
			else
			{
				Number.NumberToStringFormat<TChar>(ref valueListBuilder, ref numberBuffer, format, instance);
			}
			bool result = valueListBuilder.TryCopyTo(destination, out charsWritten);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00052C78 File Offset: 0x00050E78
		[CompilerGenerated]
		internal unsafe static string <FormatInt128>g__FormatInt128Slow|26_0(Int128 value, string format, IFormatProvider provider)
		{
			ReadOnlySpan<char> format2 = format;
			int num;
			char c = Number.ParseFormatSpecifier(format2, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				if (!Int128.IsPositive(value))
				{
					return Number.NegativeInt128ToDecStr(value, num, NumberFormatInfo.GetInstance(provider).NegativeSign);
				}
				return Number.UInt128ToDecStr((UInt128)value, num);
			}
			else
			{
				if (c2 == 'X')
				{
					return Number.Int128ToHexStr(value, Number.GetHexBase(c), num);
				}
				if (c2 == 'B')
				{
					return Number.UInt128ToBinaryStr(value, num);
				}
				NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
				byte* digits = stackalloc byte[(UIntPtr)40];
				Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 40);
				Number.Int128ToNumber(value, ref numberBuffer);
				char* pointer = stackalloc char[(UIntPtr)64];
				ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(new Span<char>((void*)pointer, 32));
				if (c != '\0')
				{
					Number.NumberToString<char>(ref valueListBuilder, ref numberBuffer, c, num, instance);
				}
				else
				{
					Number.NumberToStringFormat<char>(ref valueListBuilder, ref numberBuffer, format2, instance);
				}
				string result = valueListBuilder.AsSpan().ToString();
				valueListBuilder.Dispose();
				return result;
			}
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00052D70 File Offset: 0x00050F70
		[CompilerGenerated]
		internal unsafe static bool <TryFormatInt128>g__TryFormatInt128Slow|27_0<[IsUnmanaged] TChar>(Int128 value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num;
			char c = Number.ParseFormatSpecifier(format, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				if (!Int128.IsPositive(value))
				{
					return Number.TryNegativeInt128ToDecStr<TChar>(value, num, NumberFormatInfo.GetInstance(provider).NegativeSignTChar<TChar>(), destination, out charsWritten);
				}
				return Number.TryUInt128ToDecStr<TChar>((UInt128)value, num, destination, out charsWritten);
			}
			else
			{
				if (c2 == 'X')
				{
					return Number.TryInt128ToHexStr<TChar>(value, Number.GetHexBase(c), num, destination, out charsWritten);
				}
				if (c2 == 'B')
				{
					return Number.TryUInt128ToBinaryStr<TChar>(value, num, destination, out charsWritten);
				}
				NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
				byte* digits = stackalloc byte[(UIntPtr)40];
				Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 40);
				Number.Int128ToNumber(value, ref numberBuffer);
				TChar* pointer = stackalloc TChar[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(TChar))];
				ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(new Span<TChar>((void*)pointer, 32));
				if (c != '\0')
				{
					Number.NumberToString<TChar>(ref valueListBuilder, ref numberBuffer, c, num, instance);
				}
				else
				{
					Number.NumberToStringFormat<TChar>(ref valueListBuilder, ref numberBuffer, format, instance);
				}
				bool result = valueListBuilder.TryCopyTo(destination, out charsWritten);
				valueListBuilder.Dispose();
				return result;
			}
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00052E64 File Offset: 0x00051064
		[CompilerGenerated]
		internal unsafe static string <FormatUInt128>g__FormatUInt128Slow|28_0(UInt128 value, string format, IFormatProvider provider)
		{
			ReadOnlySpan<char> format2 = format;
			int num;
			char c = Number.ParseFormatSpecifier(format2, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				return Number.UInt128ToDecStr(value, num);
			}
			if (c2 == 'X')
			{
				return Number.Int128ToHexStr((Int128)value, Number.GetHexBase(c), num);
			}
			if (c2 == 'B')
			{
				return Number.UInt128ToBinaryStr((Int128)value, num);
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			byte* digits = stackalloc byte[(UIntPtr)40];
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 40);
			Number.UInt128ToNumber(value, ref numberBuffer);
			char* pointer = stackalloc char[(UIntPtr)64];
			ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(new Span<char>((void*)pointer, 32));
			if (c != '\0')
			{
				Number.NumberToString<char>(ref valueListBuilder, ref numberBuffer, c, num, instance);
			}
			else
			{
				Number.NumberToStringFormat<char>(ref valueListBuilder, ref numberBuffer, format2, instance);
			}
			string result = valueListBuilder.AsSpan().ToString();
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00052F44 File Offset: 0x00051144
		[CompilerGenerated]
		internal unsafe static bool <TryFormatUInt128>g__TryFormatUInt128Slow|29_0<[IsUnmanaged] TChar>(UInt128 value, ReadOnlySpan<char> format, IFormatProvider provider, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num;
			char c = Number.ParseFormatSpecifier(format, out num);
			char c2 = c & '￟';
			if ((c2 == 'G') ? (num < 1) : (c2 == 'D'))
			{
				return Number.TryUInt128ToDecStr<TChar>(value, num, destination, out charsWritten);
			}
			if (c2 == 'X')
			{
				return Number.TryInt128ToHexStr<TChar>((Int128)value, Number.GetHexBase(c), num, destination, out charsWritten);
			}
			if (c2 == 'B')
			{
				return Number.TryUInt128ToBinaryStr<TChar>((Int128)value, num, destination, out charsWritten);
			}
			NumberFormatInfo instance = NumberFormatInfo.GetInstance(provider);
			byte* digits = stackalloc byte[(UIntPtr)40];
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Integer, digits, 40);
			Number.UInt128ToNumber(value, ref numberBuffer);
			TChar* pointer = stackalloc TChar[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(TChar))];
			ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(new Span<TChar>((void*)pointer, 32));
			if (c != '\0')
			{
				Number.NumberToString<TChar>(ref valueListBuilder, ref numberBuffer, c, num, instance);
			}
			else
			{
				Number.NumberToStringFormat<TChar>(ref valueListBuilder, ref numberBuffer, format, instance);
			}
			bool result = valueListBuilder.TryCopyTo(destination, out charsWritten);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00053020 File Offset: 0x00051220
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string <UInt32ToDecStrForKnownSmallNumber>g__CreateAndCacheString|47_0(uint value)
		{
			return Number.s_smallNumberCache[(int)value] = Number.UInt32ToDecStr_NoSmallNumberCheck(value);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00053040 File Offset: 0x00051240
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void <AppendUnknownChar>g__AppendNonAsciiBytes|156_0<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> vlb, char ch) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			Rune rune = new Rune(ch);
			rune.EncodeToUtf8(MemoryMarshal.AsBytes<TChar>(vlb.AppendSpan(rune.Utf8SequenceLength)));
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00053070 File Offset: 0x00051270
		[CompilerGenerated]
		internal unsafe static bool <RoundNumber>g__ShouldRoundUp|162_0(byte* dig, int i, Number.NumberBufferKind numberKind, bool isCorrectlyRounded)
		{
			byte b = dig[i];
			return b != 0 && !isCorrectlyRounded && b >= 53;
		}

		// Token: 0x04000515 RID: 1301
		private static readonly string[] s_smallNumberCache = new string[10];

		// Token: 0x04000516 RID: 1302
		private static readonly byte[] TwoDigitsCharsAsBytes = MemoryMarshal.AsBytes<char>("00010203040506070809101112131415161718192021222324252627282930313233343536373839404142434445464748495051525354555657585960616263646566676869707172737475767778798081828384858687888990919293949596979899").ToArray();

		// Token: 0x04000517 RID: 1303
		private static readonly byte[] TwoDigitsBytes = new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.655761BC5B553103BD6B01577097EA28941852F328FFD28398C7ECA4763ADAAA), 200).ToArray();

		// Token: 0x04000518 RID: 1304
		private static readonly string[] s_posCurrencyFormats = new string[]
		{
			"$#",
			"#$",
			"$ #",
			"# $"
		};

		// Token: 0x04000519 RID: 1305
		private static readonly string[] s_negCurrencyFormats = new string[]
		{
			"($#)",
			"-$#",
			"$-#",
			"$#-",
			"(#$)",
			"-#$",
			"#-$",
			"#$-",
			"-# $",
			"-$ #",
			"# $-",
			"$ #-",
			"$ -#",
			"#- $",
			"($ #)",
			"(# $)",
			"$- #"
		};

		// Token: 0x0400051A RID: 1306
		private static readonly string[] s_posPercentFormats = new string[]
		{
			"# %",
			"#%",
			"%#",
			"% #"
		};

		// Token: 0x0400051B RID: 1307
		private static readonly string[] s_negPercentFormats = new string[]
		{
			"-# %",
			"-#%",
			"-%#",
			"%-#",
			"%#-",
			"#-%",
			"#%-",
			"-% #",
			"# %-",
			"% #-",
			"% -#",
			"#- %"
		};

		// Token: 0x0400051C RID: 1308
		private static readonly string[] s_negNumberFormats = new string[]
		{
			"(#)",
			"-#",
			"- #",
			"#-",
			"# -"
		};

		// Token: 0x0200017A RID: 378
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal ref struct BigInteger
		{
			// Token: 0x17000276 RID: 630
			// (get) Token: 0x06001953 RID: 6483 RVA: 0x0002A94C File Offset: 0x00028B4C
			private static ReadOnlySpan<uint> Pow10UInt32Table
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.A516EECB41051151F0183A8B0B6F6693C43F7D9E1815F85CAAAB18E00A5269A24).FieldHandle);
				}
			}

			// Token: 0x17000277 RID: 631
			// (get) Token: 0x06001954 RID: 6484 RVA: 0x00053094 File Offset: 0x00051294
			private static ReadOnlySpan<int> Pow10BigNumTableIndices
			{
				get
				{
					return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.872CF31969B30D16D8B7FD68ABCEBFD7F8F3336BA347CD8712D80E58CB1EB6674).FieldHandle);
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06001955 RID: 6485 RVA: 0x000530A0 File Offset: 0x000512A0
			private static ReadOnlySpan<uint> Pow10BigNumTable
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.BAB9BE2886696BD36593C4F3A85B4FA59F85A673FE44AB7EBB4F314165F9B6F14).FieldHandle);
				}
			}

			// Token: 0x06001956 RID: 6486 RVA: 0x000530AC File Offset: 0x000512AC
			public unsafe static void Add([ScopedRef] ref Number.BigInteger lhs, [ScopedRef] ref Number.BigInteger rhs, out Number.BigInteger result)
			{
				ref Number.BigInteger ptr = ref (lhs._length < rhs._length) ? ref rhs : ref lhs;
				ref Number.BigInteger ptr2 = ref (lhs._length < rhs._length) ? ref lhs : ref rhs;
				int length = ptr._length;
				int length2 = ptr2._length;
				result._length = length;
				ulong num = 0UL;
				int i = 0;
				int j = 0;
				int num2 = 0;
				while (j < length2)
				{
					ulong num3 = num + (ulong)(*(ref ptr._blocks.FixedElementField + (IntPtr)i * 4)) + (ulong)(*(ref ptr2._blocks.FixedElementField + (IntPtr)j * 4));
					num = num3 >> 32;
					*(ref result._blocks.FixedElementField + (IntPtr)num2 * 4) = (uint)num3;
					i++;
					j++;
					num2++;
				}
				while (i < length)
				{
					ulong num4 = num + (ulong)(*(ref ptr._blocks.FixedElementField + (IntPtr)i * 4));
					num = num4 >> 32;
					*(ref result._blocks.FixedElementField + (IntPtr)num2 * 4) = (uint)num4;
					i++;
					num2++;
				}
				int num5 = length;
				if (num != 0UL)
				{
					if (num5 >= 116)
					{
						Number.BigInteger.SetZero(out result);
						return;
					}
					*(ref result._blocks.FixedElementField + (IntPtr)num2 * 4) = 1U;
					result._length++;
				}
			}

			// Token: 0x06001957 RID: 6487 RVA: 0x000531DC File Offset: 0x000513DC
			public unsafe static int Compare([ScopedRef] ref Number.BigInteger lhs, [ScopedRef] ref Number.BigInteger rhs)
			{
				int length = lhs._length;
				int length2 = rhs._length;
				int num = length - length2;
				if (num != 0)
				{
					return num;
				}
				if (length == 0)
				{
					return 0;
				}
				int i = length - 1;
				while (i >= 0)
				{
					long num2 = (long)((ulong)(*(ref lhs._blocks.FixedElementField + (IntPtr)i * 4)) - (ulong)(*(ref rhs._blocks.FixedElementField + (IntPtr)i * 4)));
					if (num2 != 0L)
					{
						if (num2 <= 0L)
						{
							return -1;
						}
						return 1;
					}
					else
					{
						i--;
					}
				}
				return 0;
			}

			// Token: 0x06001958 RID: 6488 RVA: 0x00053249 File Offset: 0x00051449
			public static uint CountSignificantBits(uint value)
			{
				return (uint)(32 - BitOperations.LeadingZeroCount(value));
			}

			// Token: 0x06001959 RID: 6489 RVA: 0x00053254 File Offset: 0x00051454
			public static uint CountSignificantBits(ulong value)
			{
				return (uint)(64 - BitOperations.LeadingZeroCount(value));
			}

			// Token: 0x0600195A RID: 6490 RVA: 0x00053260 File Offset: 0x00051460
			public unsafe static uint CountSignificantBits(ref Number.BigInteger value)
			{
				if (value.IsZero())
				{
					return 0U;
				}
				uint num = (uint)(value._length - 1);
				return num * 32U + Number.BigInteger.CountSignificantBits(*(ref value._blocks.FixedElementField + (IntPtr)((ulong)num * 4UL)));
			}

			// Token: 0x0600195B RID: 6491 RVA: 0x000532A0 File Offset: 0x000514A0
			public unsafe static void DivRem([ScopedRef] ref Number.BigInteger lhs, [ScopedRef] ref Number.BigInteger rhs, out Number.BigInteger quo, out Number.BigInteger rem)
			{
				if (lhs.IsZero())
				{
					Number.BigInteger.SetZero(out quo);
					Number.BigInteger.SetZero(out rem);
					return;
				}
				int length = lhs._length;
				int length2 = rhs._length;
				if (length == 1 && length2 == 1)
				{
					ValueTuple<uint, uint> valueTuple = Math.DivRem(lhs._blocks.FixedElementField, rhs._blocks.FixedElementField);
					uint item = valueTuple.Item1;
					uint item2 = valueTuple.Item2;
					Number.BigInteger.SetUInt32(out quo, item);
					Number.BigInteger.SetUInt32(out rem, item2);
					return;
				}
				if (length2 == 1)
				{
					int num = length;
					ulong right = (ulong)rhs._blocks.FixedElementField;
					ulong num2 = 0UL;
					for (int i = num - 1; i >= 0; i--)
					{
						ValueTuple<ulong, ulong> valueTuple2 = Math.DivRem(num2 << 32 | (ulong)(*(ref lhs._blocks.FixedElementField + (IntPtr)i * 4)), right);
						ulong item3 = valueTuple2.Item1;
						num2 = valueTuple2.Item2;
						if (item3 == 0UL && i == num - 1)
						{
							num--;
						}
						else
						{
							*(ref quo._blocks.FixedElementField + (IntPtr)i * 4) = (uint)item3;
						}
					}
					quo._length = num;
					Number.BigInteger.SetUInt32(out rem, (uint)num2);
					return;
				}
				if (length2 > length)
				{
					Number.BigInteger.SetZero(out quo);
					Number.BigInteger.SetValue(out rem, ref lhs);
					return;
				}
				int num3 = length - length2 + 1;
				Number.BigInteger.SetValue(out rem, ref lhs);
				int num4 = length;
				uint num5 = *(ref rhs._blocks.FixedElementField + (IntPtr)(length2 - 1) * 4);
				uint num6 = *(ref rhs._blocks.FixedElementField + (IntPtr)(length2 - 2) * 4);
				int num7 = BitOperations.LeadingZeroCount(num5);
				int num8 = 32 - num7;
				if (num7 > 0)
				{
					num5 = (num5 << num7 | num6 >> num8);
					num6 <<= num7;
					if (length2 > 2)
					{
						num6 |= *(ref rhs._blocks.FixedElementField + (IntPtr)(length2 - 3) * 4) >> num8;
					}
				}
				for (int j = length; j >= length2; j--)
				{
					int num9 = j - length2;
					uint num10 = (j < length) ? (*(ref rem._blocks.FixedElementField + (IntPtr)j * 4)) : 0U;
					ulong num11 = (ulong)num10 << 32 | (ulong)(*(ref rem._blocks.FixedElementField + (IntPtr)(j - 1) * 4));
					uint num12 = (j > 1) ? (*(ref rem._blocks.FixedElementField + (IntPtr)(j - 2) * 4)) : 0U;
					if (num7 > 0)
					{
						num11 = (num11 << num7 | (ulong)(num12 >> num8));
						num12 <<= num7;
						if (j > 2)
						{
							num12 |= *(ref rem._blocks.FixedElementField + (IntPtr)(j - 3) * 4) >> num8;
						}
					}
					ulong num13 = num11 / (ulong)num5;
					if (num13 > (ulong)-1)
					{
						num13 = (ulong)-1;
					}
					while (Number.BigInteger.DivideGuessTooBig(num13, num11, num12, num5, num6))
					{
						num13 -= 1UL;
					}
					if (num13 > 0UL && Number.BigInteger.SubtractDivisor(ref rem, num9, ref rhs, num13) != num10)
					{
						Number.BigInteger.AddDivisor(ref rem, num9, ref rhs);
						num13 -= 1UL;
					}
					if (num3 != 0)
					{
						if (num13 == 0UL && num9 == num3 - 1)
						{
							num3--;
						}
						else
						{
							*(ref quo._blocks.FixedElementField + (IntPtr)num9 * 4) = (uint)num13;
						}
					}
					if (j < num4)
					{
						num4--;
					}
				}
				quo._length = num3;
				int num14 = num4 - 1;
				while (num14 >= 0 && *(ref rem._blocks.FixedElementField + (IntPtr)num14 * 4) == 0U)
				{
					num4--;
					num14--;
				}
				rem._length = num4;
			}

			// Token: 0x0600195C RID: 6492 RVA: 0x000535D0 File Offset: 0x000517D0
			public unsafe static uint HeuristicDivide(ref Number.BigInteger dividend, ref Number.BigInteger divisor)
			{
				int num = divisor._length;
				if (dividend._length < num)
				{
					return 0U;
				}
				int num2 = num - 1;
				uint num3 = *(ref dividend._blocks.FixedElementField + (IntPtr)num2 * 4) / (*(ref divisor._blocks.FixedElementField + (IntPtr)num2 * 4) + 1U);
				if (num3 != 0U)
				{
					int num4 = 0;
					ulong num5 = 0UL;
					ulong num6 = 0UL;
					do
					{
						ulong num7 = (ulong)(*(ref divisor._blocks.FixedElementField + (IntPtr)num4 * 4)) * (ulong)num3 + num6;
						num6 = num7 >> 32;
						ulong num8 = (ulong)(*(ref dividend._blocks.FixedElementField + (IntPtr)num4 * 4)) - (ulong)((uint)num7) - num5;
						num5 = (num8 >> 32 & 1UL);
						*(ref dividend._blocks.FixedElementField + (IntPtr)num4 * 4) = (uint)num8;
						num4++;
					}
					while (num4 < num);
					while (num > 0 && *(ref dividend._blocks.FixedElementField + (IntPtr)(num - 1) * 4) == 0U)
					{
						num--;
					}
					dividend._length = num;
				}
				if (Number.BigInteger.Compare(ref dividend, ref divisor) >= 0)
				{
					num3 += 1U;
					int num9 = 0;
					ulong num10 = 0UL;
					do
					{
						ulong num11 = (ulong)(*(ref dividend._blocks.FixedElementField + (IntPtr)num9 * 4)) - (ulong)(*(ref divisor._blocks.FixedElementField + (IntPtr)num9 * 4)) - num10;
						num10 = (num11 >> 32 & 1UL);
						*(ref dividend._blocks.FixedElementField + (IntPtr)num9 * 4) = (uint)num11;
						num9++;
					}
					while (num9 < num);
					while (num > 0 && *(ref dividend._blocks.FixedElementField + (IntPtr)(num - 1) * 4) == 0U)
					{
						num--;
					}
					dividend._length = num;
				}
				return num3;
			}

			// Token: 0x0600195D RID: 6493 RVA: 0x00053748 File Offset: 0x00051948
			public unsafe static void Multiply([ScopedRef] ref Number.BigInteger lhs, uint value, out Number.BigInteger result)
			{
				if (lhs._length <= 1)
				{
					Number.BigInteger.SetUInt64(out result, (ulong)lhs.ToUInt32() * (ulong)value);
					return;
				}
				if (value > 1U)
				{
					int length = lhs._length;
					int i = 0;
					uint num = 0U;
					while (i < length)
					{
						ulong num2 = (ulong)(*(ref lhs._blocks.FixedElementField + (IntPtr)i * 4)) * (ulong)value + (ulong)num;
						*(ref result._blocks.FixedElementField + (IntPtr)i * 4) = (uint)num2;
						num = (uint)(num2 >> 32);
						i++;
					}
					int num3 = length;
					if (num != 0U)
					{
						if (num3 >= 116)
						{
							Number.BigInteger.SetZero(out result);
							return;
						}
						*(ref result._blocks.FixedElementField + (IntPtr)i * 4) = num;
						num3++;
					}
					result._length = num3;
					return;
				}
				if (value == 0U)
				{
					Number.BigInteger.SetZero(out result);
					return;
				}
				Number.BigInteger.SetValue(out result, ref lhs);
			}

			// Token: 0x0600195E RID: 6494 RVA: 0x00053800 File Offset: 0x00051A00
			public unsafe static void Multiply([ScopedRef] ref Number.BigInteger lhs, [ScopedRef] ref Number.BigInteger rhs, out Number.BigInteger result)
			{
				if (lhs._length <= 1)
				{
					Number.BigInteger.Multiply(ref rhs, lhs.ToUInt32(), out result);
					return;
				}
				if (rhs._length <= 1)
				{
					Number.BigInteger.Multiply(ref lhs, rhs.ToUInt32(), out result);
					return;
				}
				ref Number.BigInteger ptr = ref lhs;
				int length = lhs._length;
				ref Number.BigInteger ptr2 = ref rhs;
				int length2 = rhs._length;
				if (length < length2)
				{
					ptr = ref rhs;
					length = rhs._length;
					ptr2 = ref lhs;
					length2 = lhs._length;
				}
				int num = length2 + length;
				if (num > 116)
				{
					Number.BigInteger.SetZero(out result);
					return;
				}
				result._length = num;
				result.Clear((uint)num);
				int i = 0;
				int num2 = 0;
				while (i < length2)
				{
					if (*(ref ptr2._blocks.FixedElementField + (IntPtr)i * 4) != 0U)
					{
						int num3 = 0;
						int num4 = num2;
						ulong num5 = 0UL;
						do
						{
							ulong num6 = (ulong)(*(ref result._blocks.FixedElementField + (IntPtr)num4 * 4)) + (ulong)(*(ref ptr2._blocks.FixedElementField + (IntPtr)i * 4)) * (ulong)(*(ref ptr._blocks.FixedElementField + (IntPtr)num3 * 4)) + num5;
							num5 = num6 >> 32;
							*(ref result._blocks.FixedElementField + (IntPtr)num4 * 4) = (uint)num6;
							num4++;
							num3++;
						}
						while (num3 < length);
						*(ref result._blocks.FixedElementField + (IntPtr)num4 * 4) = (uint)num5;
					}
					i++;
					num2++;
				}
				if (num > 0 && *(ref result._blocks.FixedElementField + (IntPtr)(num - 1) * 4) == 0U)
				{
					result._length--;
				}
			}

			// Token: 0x0600195F RID: 6495 RVA: 0x00053970 File Offset: 0x00051B70
			public unsafe static void Pow2(uint exponent, out Number.BigInteger result)
			{
				uint num2;
				uint num = Number.BigInteger.DivRem32(exponent, out num2);
				result._length = (int)(num + 1U);
				if (result._length > 116)
				{
					Number.BigInteger.SetZero(out result);
					return;
				}
				if (num > 0U)
				{
					result.Clear(num);
				}
				*(ref result._blocks.FixedElementField + (IntPtr)((ulong)num * 4UL)) = 1U << (int)num2;
			}

			// Token: 0x06001960 RID: 6496 RVA: 0x000539C4 File Offset: 0x00051BC4
			public unsafe static void Pow10(uint exponent, out Number.BigInteger result)
			{
				Number.BigInteger bigInteger;
				Number.BigInteger.SetUInt32(out bigInteger, *Number.BigInteger.Pow10UInt32Table[(int)(exponent & 7U)]);
				ref Number.BigInteger ptr = ref bigInteger;
				Number.BigInteger bigInteger2;
				Number.BigInteger.SetZero(out bigInteger2);
				ref Number.BigInteger ptr2 = ref bigInteger2;
				exponent >>= 3;
				uint num = 0U;
				while (exponent != 0U)
				{
					if ((exponent & 1U) != 0U)
					{
						fixed (uint* ptr3 = Number.BigInteger.Pow10BigNumTable[*Number.BigInteger.Pow10BigNumTableIndices[(int)num]])
						{
							ref Number.BigInteger rhs = ref *(Number.BigInteger*)ptr3;
							Number.BigInteger.Multiply(ref ptr, ref rhs, out ptr2);
						}
						ref Number.BigInteger ptr4 = ref ptr2;
						ptr2 = ref ptr;
						ptr = ref ptr4;
					}
					num += 1U;
					exponent >>= 1;
				}
				Number.BigInteger.SetValue(out result, ref ptr);
			}

			// Token: 0x06001961 RID: 6497 RVA: 0x00053A54 File Offset: 0x00051C54
			private unsafe static uint AddDivisor(ref Number.BigInteger lhs, int lhsStartIndex, ref Number.BigInteger rhs)
			{
				int length = rhs._length;
				ulong num = 0UL;
				for (int i = 0; i < length; i++)
				{
					ref uint ptr = ref lhs._blocks.FixedElementField + (IntPtr)(lhsStartIndex + i) * 4;
					ulong num2 = (ulong)ptr + num + (ulong)(*(ref rhs._blocks.FixedElementField + (IntPtr)i * 4));
					ptr = (uint)num2;
					num = num2 >> 32;
				}
				return (uint)num;
			}

			// Token: 0x06001962 RID: 6498 RVA: 0x00053AAC File Offset: 0x00051CAC
			private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo)
			{
				ulong num = (ulong)divHi * q;
				ulong num2 = (ulong)divLo * q;
				num += num2 >> 32;
				num2 &= (ulong)-1;
				return num >= valHi && (num > valHi || (num2 >= (ulong)valLo && num2 > (ulong)valLo));
			}

			// Token: 0x06001963 RID: 6499 RVA: 0x00053AEC File Offset: 0x00051CEC
			private unsafe static uint SubtractDivisor(ref Number.BigInteger lhs, int lhsStartIndex, ref Number.BigInteger rhs, ulong q)
			{
				int length = rhs._length;
				ulong num = 0UL;
				for (int i = 0; i < length; i++)
				{
					num += (ulong)(*(ref rhs._blocks.FixedElementField + (IntPtr)i * 4)) * q;
					uint num2 = (uint)num;
					num >>= 32;
					ref uint ptr = ref lhs._blocks.FixedElementField + (IntPtr)(lhsStartIndex + i) * 4;
					if (ptr < num2)
					{
						num += 1UL;
					}
					ptr -= num2;
				}
				return (uint)num;
			}

			// Token: 0x06001964 RID: 6500 RVA: 0x00053B54 File Offset: 0x00051D54
			public unsafe void Add(uint value)
			{
				int length = this._length;
				if (length == 0)
				{
					Number.BigInteger.SetUInt32(out this, value);
					return;
				}
				this._blocks.FixedElementField = this._blocks.FixedElementField + value;
				if (this._blocks.FixedElementField >= value)
				{
					return;
				}
				for (int i = 1; i < length; i++)
				{
					*(ref this._blocks.FixedElementField + (IntPtr)i * 4) += 1U;
					if (*(ref this._blocks.FixedElementField + (IntPtr)i * 4) > 0U)
					{
						return;
					}
				}
				if (length >= 116)
				{
					Number.BigInteger.SetZero(out this);
					return;
				}
				*(ref this._blocks.FixedElementField + (IntPtr)length * 4) = 1U;
				this._length = length + 1;
			}

			// Token: 0x06001965 RID: 6501 RVA: 0x00053BF0 File Offset: 0x00051DF0
			public unsafe uint GetBlock(uint index)
			{
				return *(ref this._blocks.FixedElementField + (IntPtr)((ulong)index * 4UL));
			}

			// Token: 0x06001966 RID: 6502 RVA: 0x00053C05 File Offset: 0x00051E05
			public int GetLength()
			{
				return this._length;
			}

			// Token: 0x06001967 RID: 6503 RVA: 0x00053C0D File Offset: 0x00051E0D
			public bool IsZero()
			{
				return this._length == 0;
			}

			// Token: 0x06001968 RID: 6504 RVA: 0x00053C18 File Offset: 0x00051E18
			public void Multiply(uint value)
			{
				Number.BigInteger.Multiply(ref this, value, out this);
			}

			// Token: 0x06001969 RID: 6505 RVA: 0x00053C24 File Offset: 0x00051E24
			public void Multiply([ScopedRef] ref Number.BigInteger value)
			{
				if (value._length <= 1)
				{
					Number.BigInteger.Multiply(ref this, value.ToUInt32(), out this);
					return;
				}
				Number.BigInteger bigInteger;
				Number.BigInteger.SetValue(out bigInteger, ref this);
				Number.BigInteger.Multiply(ref bigInteger, ref value, out this);
			}

			// Token: 0x0600196A RID: 6506 RVA: 0x00053C5C File Offset: 0x00051E5C
			public unsafe void Multiply10()
			{
				if (this.IsZero())
				{
					return;
				}
				int num = 0;
				int length = this._length;
				ulong num2 = 0UL;
				do
				{
					ulong num3 = (ulong)(*(ref this._blocks.FixedElementField + (IntPtr)num * 4));
					ulong num4 = (num3 << 3) + (num3 << 1) + num2;
					num2 = num4 >> 32;
					*(ref this._blocks.FixedElementField + (IntPtr)num * 4) = (uint)num4;
					num++;
				}
				while (num < length);
				if (num2 != 0UL)
				{
					if (length >= 116)
					{
						Number.BigInteger.SetZero(out this);
						return;
					}
					*(ref this._blocks.FixedElementField + (IntPtr)num * 4) = (uint)num2;
					this._length = length + 1;
				}
			}

			// Token: 0x0600196B RID: 6507 RVA: 0x00053CEC File Offset: 0x00051EEC
			public unsafe void MultiplyPow10(uint exponent)
			{
				if (exponent <= 9U)
				{
					this.Multiply(*Number.BigInteger.Pow10UInt32Table[(int)exponent]);
					return;
				}
				if (!this.IsZero())
				{
					Number.BigInteger bigInteger;
					Number.BigInteger.Pow10(exponent, out bigInteger);
					this.Multiply(ref bigInteger);
				}
			}

			// Token: 0x0600196C RID: 6508 RVA: 0x00053D2C File Offset: 0x00051F2C
			public static void SetUInt32(out Number.BigInteger result, uint value)
			{
				if (value == 0U)
				{
					Number.BigInteger.SetZero(out result);
					return;
				}
				result._blocks.FixedElementField = value;
				result._length = 1;
			}

			// Token: 0x0600196D RID: 6509 RVA: 0x00053D4C File Offset: 0x00051F4C
			public unsafe static void SetUInt64(out Number.BigInteger result, ulong value)
			{
				if (value <= (ulong)-1)
				{
					Number.BigInteger.SetUInt32(out result, (uint)value);
					return;
				}
				result._blocks.FixedElementField = (uint)value;
				*(ref result._blocks.FixedElementField + 4) = (uint)(value >> 32);
				result._length = 2;
			}

			// Token: 0x0600196E RID: 6510 RVA: 0x00053D84 File Offset: 0x00051F84
			public static void SetValue(out Number.BigInteger result, [ScopedRef] ref Number.BigInteger value)
			{
				int length = value._length;
				result._length = length;
				Buffer.Memmove<uint>(ref result._blocks.FixedElementField, ref value._blocks.FixedElementField, (UIntPtr)((IntPtr)length));
			}

			// Token: 0x0600196F RID: 6511 RVA: 0x00053DBC File Offset: 0x00051FBC
			public static void SetZero(out Number.BigInteger result)
			{
				result._length = 0;
			}

			// Token: 0x06001970 RID: 6512 RVA: 0x00053DC8 File Offset: 0x00051FC8
			public unsafe void ShiftLeft(uint shift)
			{
				int length = this._length;
				if (length == 0 || shift == 0U)
				{
					return;
				}
				uint num2;
				uint num = Number.BigInteger.DivRem32(shift, out num2);
				int i = length - 1;
				int num3 = i + (int)num;
				if (num2 == 0U)
				{
					if (length >= 116)
					{
						Number.BigInteger.SetZero(out this);
						return;
					}
					while (i >= 0)
					{
						*(ref this._blocks.FixedElementField + (IntPtr)num3 * 4) = *(ref this._blocks.FixedElementField + (IntPtr)i * 4);
						i--;
						num3--;
					}
					this._length += (int)num;
					this.Clear(num);
					return;
				}
				else
				{
					num3++;
					if (length >= 116)
					{
						Number.BigInteger.SetZero(out this);
						return;
					}
					this._length = num3 + 1;
					uint num4 = 32U - num2;
					uint num5 = 0U;
					uint num6 = *(ref this._blocks.FixedElementField + (IntPtr)i * 4);
					uint num7 = num6 >> (int)num4;
					while (i > 0)
					{
						*(ref this._blocks.FixedElementField + (IntPtr)num3 * 4) = (num5 | num7);
						num5 = num6 << (int)num2;
						i--;
						num3--;
						num6 = *(ref this._blocks.FixedElementField + (IntPtr)i * 4);
						num7 = num6 >> (int)num4;
					}
					*(ref this._blocks.FixedElementField + (IntPtr)num3 * 4) = (num5 | num7);
					*(ref this._blocks.FixedElementField + (IntPtr)(num3 - 1) * 4) = num6 << (int)num2;
					this.Clear(num);
					if (*(ref this._blocks.FixedElementField + (IntPtr)(this._length - 1) * 4) == 0U)
					{
						this._length--;
					}
					return;
				}
			}

			// Token: 0x06001971 RID: 6513 RVA: 0x00053F3B File Offset: 0x0005213B
			public uint ToUInt32()
			{
				if (this._length > 0)
				{
					return this._blocks.FixedElementField;
				}
				return 0U;
			}

			// Token: 0x06001972 RID: 6514 RVA: 0x00053F54 File Offset: 0x00052154
			public unsafe ulong ToUInt64()
			{
				if (this._length > 1)
				{
					return ((ulong)(*(ref this._blocks.FixedElementField + 4)) << 32) + (ulong)this._blocks.FixedElementField;
				}
				if (this._length > 0)
				{
					return (ulong)this._blocks.FixedElementField;
				}
				return 0UL;
			}

			// Token: 0x06001973 RID: 6515 RVA: 0x00053FA4 File Offset: 0x000521A4
			private void Clear(uint length)
			{
				NativeMemory.Clear(Unsafe.AsPointer<uint>(ref this._blocks.FixedElementField), (UIntPtr)(length * 4U));
			}

			// Token: 0x06001974 RID: 6516 RVA: 0x00053FBF File Offset: 0x000521BF
			private static uint DivRem32(uint value, out uint remainder)
			{
				remainder = (value & 31U);
				return value >> 5;
			}

			// Token: 0x0400051D RID: 1309
			private int _length;

			// Token: 0x0400051E RID: 1310
			[FixedBuffer(typeof(uint), 116)]
			private Number.BigInteger.<_blocks>e__FixedBuffer _blocks;

			// Token: 0x0200017B RID: 379
			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Size = 464)]
			public struct <_blocks>e__FixedBuffer
			{
				// Token: 0x0400051F RID: 1311
				public uint FixedElementField;
			}
		}

		// Token: 0x0200017C RID: 380
		[CompilerFeatureRequired("RefStructs")]
		internal readonly ref struct DiyFp
		{
			// Token: 0x06001975 RID: 6517 RVA: 0x00053FCC File Offset: 0x000521CC
			public static Number.DiyFp CreateAndGetBoundaries<[IsUnmanaged] TNumber>(TNumber value, out Number.DiyFp mMinus, out Number.DiyFp mPlus) where TNumber : struct, ValueType, IBinaryFloatParseAndFormatInfo<TNumber>
			{
				Number.DiyFp result = Number.DiyFp.Create<TNumber>(value);
				result.GetBoundaries((int)IBinaryFloatParseAndFormatInfo<TNumber>.DenormalMantissaBits, out mMinus, out mPlus);
				return result;
			}

			// Token: 0x06001976 RID: 6518 RVA: 0x00053FF8 File Offset: 0x000521F8
			public static Number.DiyFp Create<[IsUnmanaged] TNumber>(TNumber value) where TNumber : struct, ValueType, IBinaryFloatParseAndFormatInfo<TNumber>
			{
				int num;
				return new Number.DiyFp(Number.ExtractFractionAndBiasedExponent<TNumber>(value, out num), num);
			}

			// Token: 0x06001977 RID: 6519 RVA: 0x00054013 File Offset: 0x00052213
			public DiyFp(ulong f, int e)
			{
				this.f = f;
				this.e = e;
			}

			// Token: 0x06001978 RID: 6520 RVA: 0x00054024 File Offset: 0x00052224
			public Number.DiyFp Multiply(in Number.DiyFp other)
			{
				uint num = (uint)(this.f >> 32);
				uint num2 = (uint)this.f;
				uint num3 = (uint)(other.f >> 32);
				uint num4 = (uint)other.f;
				ulong num5 = (ulong)num * (ulong)num3;
				ulong num6 = (ulong)num2 * (ulong)num3;
				ulong num7 = (ulong)num * (ulong)num4;
				ulong num8 = ((ulong)num2 * (ulong)num4 >> 32) + (ulong)((uint)num7) + (ulong)((uint)num6);
				num8 += (ulong)int.MinValue;
				return new Number.DiyFp(num5 + (num7 >> 32) + (num6 >> 32) + (num8 >> 32), this.e + other.e + 64);
			}

			// Token: 0x06001979 RID: 6521 RVA: 0x000540B0 File Offset: 0x000522B0
			public Number.DiyFp Normalize()
			{
				int num = BitOperations.LeadingZeroCount(this.f);
				return new Number.DiyFp(this.f << num, this.e - num);
			}

			// Token: 0x0600197A RID: 6522 RVA: 0x000540E1 File Offset: 0x000522E1
			public Number.DiyFp Subtract(in Number.DiyFp other)
			{
				return new Number.DiyFp(this.f - other.f, this.e);
			}

			// Token: 0x0600197B RID: 6523 RVA: 0x000540FC File Offset: 0x000522FC
			private void GetBoundaries(int implicitBitIndex, out Number.DiyFp mMinus, out Number.DiyFp mPlus)
			{
				mPlus = new Number.DiyFp((this.f << 1) + 1UL, this.e - 1).Normalize();
				if (this.f == 1UL << implicitBitIndex)
				{
					mMinus = new Number.DiyFp((this.f << 2) - 1UL, this.e - 2);
				}
				else
				{
					mMinus = new Number.DiyFp((this.f << 1) - 1UL, this.e - 1);
				}
				mMinus = new Number.DiyFp(mMinus.f << mMinus.e - mPlus.e, mPlus.e);
			}

			// Token: 0x04000520 RID: 1312
			public readonly ulong f;

			// Token: 0x04000521 RID: 1313
			public readonly int e;
		}

		// Token: 0x0200017D RID: 381
		internal static class Grisu3
		{
			// Token: 0x17000279 RID: 633
			// (get) Token: 0x0600197C RID: 6524 RVA: 0x000541A4 File Offset: 0x000523A4
			private static ReadOnlySpan<short> CachedPowersBinaryExponent
			{
				get
				{
					return RuntimeHelpers.CreateSpan<short>(fieldof(<PrivateImplementationDetails>.538F052AB907338D0E8980BC5D8AD76919B39F0248ACDFAFAAA0CC76E39948F72).FieldHandle);
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x0600197D RID: 6525 RVA: 0x000541B0 File Offset: 0x000523B0
			private static ReadOnlySpan<short> CachedPowersDecimalExponent
			{
				get
				{
					return RuntimeHelpers.CreateSpan<short>(fieldof(<PrivateImplementationDetails>.B2DCA9FD613841289369C721661A31B454A090D2146EFE106203F7821567907D2).FieldHandle);
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x0600197E RID: 6526 RVA: 0x000541BC File Offset: 0x000523BC
			private static ReadOnlySpan<ulong> CachedPowersSignificand
			{
				get
				{
					return RuntimeHelpers.CreateSpan<ulong>(fieldof(<PrivateImplementationDetails>.02BF302F66F50150BCF5E322DA879E92E417084D14FBE4F5345DDCB68F863E518).FieldHandle);
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x0600197F RID: 6527 RVA: 0x0002A94C File Offset: 0x00028B4C
			private static ReadOnlySpan<uint> SmallPowersOfTen
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.A516EECB41051151F0183A8B0B6F6693C43F7D9E1815F85CAAAB18E00A5269A24).FieldHandle);
				}
			}

			// Token: 0x06001980 RID: 6528 RVA: 0x000541C8 File Offset: 0x000523C8
			public unsafe static bool TryRun<[IsUnmanaged] TNumber>(TNumber value, int requestedDigits, ref Number.NumberBuffer number) where TNumber : struct, ValueType, IBinaryFloatParseAndFormatInfo<TNumber>
			{
				TNumber value2 = INumberBase<TNumber>.IsNegative(value) ? (-value) : value;
				int num;
				int num2;
				bool flag;
				if (requestedDigits == -1)
				{
					Number.DiyFp diyFp2;
					Number.DiyFp diyFp3;
					Number.DiyFp diyFp = Number.DiyFp.CreateAndGetBoundaries<TNumber>(value2, out diyFp2, out diyFp3).Normalize();
					flag = Number.Grisu3.TryRunShortest(diyFp2, diyFp, diyFp3, number.Digits, out num, out num2);
				}
				else
				{
					Number.DiyFp diyFp4 = Number.DiyFp.Create<TNumber>(value2).Normalize();
					flag = Number.Grisu3.TryRunCounted(diyFp4, requestedDigits, number.Digits, out num, out num2);
				}
				if (flag)
				{
					number.Scale = num + num2;
					*number.Digits[num] = 0;
					number.DigitsCount = num;
				}
				return flag;
			}

			// Token: 0x06001981 RID: 6529 RVA: 0x0005426C File Offset: 0x0005246C
			private static bool TryRunCounted(in Number.DiyFp w, int requestedDigits, Span<byte> buffer, out int length, out int decimalExponent)
			{
				int minExponent = -60 - (w.e + 64);
				int maxExponent = -32 - (w.e + 64);
				int num;
				Number.DiyFp cachedPowerForBinaryExponentRange = Number.Grisu3.GetCachedPowerForBinaryExponentRange(minExponent, maxExponent, out num);
				Number.DiyFp diyFp = w.Multiply(cachedPowerForBinaryExponentRange);
				int num2;
				bool result = Number.Grisu3.TryDigitGenCounted(diyFp, requestedDigits, buffer, out length, out num2);
				decimalExponent = -num + num2;
				return result;
			}

			// Token: 0x06001982 RID: 6530 RVA: 0x000542B8 File Offset: 0x000524B8
			private static bool TryRunShortest(in Number.DiyFp boundaryMinus, in Number.DiyFp w, in Number.DiyFp boundaryPlus, Span<byte> buffer, out int length, out int decimalExponent)
			{
				int minExponent = -60 - (w.e + 64);
				int maxExponent = -32 - (w.e + 64);
				int num;
				Number.DiyFp cachedPowerForBinaryExponentRange = Number.Grisu3.GetCachedPowerForBinaryExponentRange(minExponent, maxExponent, out num);
				Number.DiyFp diyFp = w.Multiply(cachedPowerForBinaryExponentRange);
				Number.DiyFp diyFp2 = boundaryMinus.Multiply(cachedPowerForBinaryExponentRange);
				Number.DiyFp diyFp3 = boundaryPlus.Multiply(cachedPowerForBinaryExponentRange);
				int num2;
				bool result = Number.Grisu3.TryDigitGenShortest(diyFp2, diyFp, diyFp3, buffer, out length, out num2);
				decimalExponent = -num + num2;
				return result;
			}

			// Token: 0x06001983 RID: 6531 RVA: 0x0005431C File Offset: 0x0005251C
			private unsafe static uint BiggestPowerTen(uint number, int numberBits, out int exponentPlusOne)
			{
				int num = (numberBits + 1) * 1233 >> 12;
				uint num2 = *Number.Grisu3.SmallPowersOfTen[num];
				if (number < num2)
				{
					num--;
					num2 = *Number.Grisu3.SmallPowersOfTen[num];
				}
				exponentPlusOne = num + 1;
				return num2;
			}

			// Token: 0x06001984 RID: 6532 RVA: 0x00054364 File Offset: 0x00052564
			private unsafe static bool TryDigitGenCounted(in Number.DiyFp w, int requestedDigits, Span<byte> buffer, out int length, out int kappa)
			{
				ulong num = 1UL;
				Number.DiyFp diyFp = new Number.DiyFp(1UL << -w.e, w.e);
				uint num2 = (uint)(w.f >> -diyFp.e);
				ulong num3 = w.f & diyFp.f - 1UL;
				if (num3 == 0UL && (requestedDigits >= 11 || num2 < *Number.Grisu3.SmallPowersOfTen[requestedDigits - 1]))
				{
					length = 0;
					kappa = 0;
					return false;
				}
				uint num4 = Number.Grisu3.BiggestPowerTen(num2, 64 - -diyFp.e, out kappa);
				length = 0;
				while (kappa > 0)
				{
					ValueTuple<uint, uint> valueTuple = Math.DivRem(num2, num4);
					uint item = valueTuple.Item1;
					num2 = valueTuple.Item2;
					*buffer[length] = (byte)(48U + item);
					length++;
					requestedDigits--;
					kappa--;
					if (requestedDigits == 0)
					{
						break;
					}
					num4 /= 10U;
				}
				if (requestedDigits == 0)
				{
					ulong rest = ((ulong)num2 << -diyFp.e) + num3;
					return Number.Grisu3.TryRoundWeedCounted(buffer, length, rest, (ulong)num4 << -diyFp.e, num, ref kappa);
				}
				while (requestedDigits > 0 && num3 > num)
				{
					num3 *= 10UL;
					num *= 10UL;
					uint num5 = (uint)(num3 >> -diyFp.e);
					*buffer[length] = (byte)(48U + num5);
					length++;
					requestedDigits--;
					kappa--;
					num3 &= diyFp.f - 1UL;
				}
				if (requestedDigits != 0)
				{
					*buffer[0] = 0;
					length = 0;
					kappa = 0;
					return false;
				}
				return Number.Grisu3.TryRoundWeedCounted(buffer, length, num3, diyFp.f, num, ref kappa);
			}

			// Token: 0x06001985 RID: 6533 RVA: 0x000544E4 File Offset: 0x000526E4
			private unsafe static bool TryDigitGenShortest(in Number.DiyFp low, in Number.DiyFp w, in Number.DiyFp high, Span<byte> buffer, out int length, out int kappa)
			{
				ulong num = 1UL;
				Number.DiyFp diyFp = new Number.DiyFp(low.f - num, low.e);
				Number.DiyFp diyFp2 = new Number.DiyFp(high.f + num, high.e);
				Number.DiyFp diyFp3 = diyFp2.Subtract(diyFp);
				Number.DiyFp diyFp4 = new Number.DiyFp(1UL << -w.e, w.e);
				uint num2 = (uint)(diyFp2.f >> -diyFp4.e);
				ulong num3 = diyFp2.f & diyFp4.f - 1UL;
				uint num4 = Number.Grisu3.BiggestPowerTen(num2, 64 - -diyFp4.e, out kappa);
				length = 0;
				while (kappa > 0)
				{
					ValueTuple<uint, uint> valueTuple = Math.DivRem(num2, num4);
					uint item = valueTuple.Item1;
					num2 = valueTuple.Item2;
					*buffer[length] = (byte)(48U + item);
					length++;
					kappa--;
					ulong num5 = ((ulong)num2 << -diyFp4.e) + num3;
					if (num5 < diyFp3.f)
					{
						return Number.Grisu3.TryRoundWeedShortest(buffer, length, diyFp2.Subtract(w).f, diyFp3.f, num5, (ulong)num4 << -diyFp4.e, num);
					}
					num4 /= 10U;
				}
				do
				{
					num3 *= 10UL;
					num *= 10UL;
					diyFp3 = new Number.DiyFp(diyFp3.f * 10UL, diyFp3.e);
					uint num6 = (uint)(num3 >> -diyFp4.e);
					*buffer[length] = (byte)(48U + num6);
					length++;
					kappa--;
					num3 &= diyFp4.f - 1UL;
				}
				while (num3 >= diyFp3.f);
				return Number.Grisu3.TryRoundWeedShortest(buffer, length, diyFp2.Subtract(w).f * num, diyFp3.f, num3, diyFp4.f, num);
			}

			// Token: 0x06001986 RID: 6534 RVA: 0x000546B8 File Offset: 0x000528B8
			private unsafe static Number.DiyFp GetCachedPowerForBinaryExponentRange(int minExponent, int maxExponent, out int decimalExponent)
			{
				double num = Math.Ceiling((double)(minExponent + 64 - 1) * 0.3010299956639812);
				int index = (348 + (int)num - 1) / 8 + 1;
				decimalExponent = (int)(*Number.Grisu3.CachedPowersDecimalExponent[index]);
				return new Number.DiyFp((ulong)(*Number.Grisu3.CachedPowersSignificand[index]), (int)(*Number.Grisu3.CachedPowersBinaryExponent[index]));
			}

			// Token: 0x06001987 RID: 6535 RVA: 0x00054720 File Offset: 0x00052920
			private unsafe static bool TryRoundWeedCounted(Span<byte> buffer, int length, ulong rest, ulong tenKappa, ulong unit, ref int kappa)
			{
				if (unit >= tenKappa || tenKappa - unit <= unit)
				{
					return false;
				}
				if (tenKappa - rest > rest && tenKappa - 2UL * rest >= 2UL * unit)
				{
					return true;
				}
				if (rest > unit && (tenKappa <= rest - unit || tenKappa - (rest - unit) <= rest - unit))
				{
					ref byte ptr = ref buffer[length - 1];
					ptr += 1;
					int num = length - 1;
					while (num > 0 && *buffer[num] == 58)
					{
						*buffer[num] = 48;
						ref byte ptr2 = ref buffer[num - 1];
						ptr2 += 1;
						num--;
					}
					if (*buffer[0] == 58)
					{
						*buffer[0] = 49;
						kappa++;
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001988 RID: 6536 RVA: 0x000547D4 File Offset: 0x000529D4
			private static bool TryRoundWeedShortest(Span<byte> buffer, int length, ulong distanceTooHighW, ulong unsafeInterval, ulong rest, ulong tenKappa, ulong unit)
			{
				ulong num = distanceTooHighW - unit;
				ulong num2 = distanceTooHighW + unit;
				while (rest < num && unsafeInterval - rest >= tenKappa && (rest + tenKappa < num || num - rest >= rest + tenKappa - num))
				{
					ref byte ptr = ref buffer[length - 1];
					ptr -= 1;
					rest += tenKappa;
				}
				return (rest >= num2 || unsafeInterval - rest < tenKappa || (rest + tenKappa >= num2 && num2 - rest <= rest + tenKappa - num2)) && 2UL * unit <= rest && rest <= unsafeInterval - 4UL * unit;
			}
		}

		// Token: 0x0200017E RID: 382
		private interface IHexOrBinaryParser<[IsUnmanaged] TInteger> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06001989 RID: 6537
			NumberStyles AllowedStyles { get; }

			// Token: 0x0600198A RID: 6538
			public abstract static bool IsValidChar(uint ch);

			// Token: 0x0600198B RID: 6539
			public abstract static uint FromChar(uint ch);

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x0600198C RID: 6540
			uint MaxDigitValue { get; }

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x0600198D RID: 6541
			int MaxDigitCount { get; }

			// Token: 0x0600198E RID: 6542
			public abstract static TInteger ShiftLeftForNextDigit(TInteger value);
		}

		// Token: 0x0200017F RID: 383
		private readonly struct HexParser<[IsUnmanaged] TInteger> : Number.IHexOrBinaryParser<TInteger> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			// Token: 0x17000280 RID: 640
			// (get) Token: 0x0600198F RID: 6543 RVA: 0x00054863 File Offset: 0x00052A63
			public static NumberStyles AllowedStyles
			{
				get
				{
					return NumberStyles.HexNumber;
				}
			}

			// Token: 0x06001990 RID: 6544 RVA: 0x00021015 File Offset: 0x0001F215
			public static bool IsValidChar(uint ch)
			{
				return HexConverter.IsHexChar((int)ch);
			}

			// Token: 0x06001991 RID: 6545 RVA: 0x0005486A File Offset: 0x00052A6A
			public static uint FromChar(uint ch)
			{
				return (uint)HexConverter.FromChar((int)ch);
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06001992 RID: 6546 RVA: 0x000299CE File Offset: 0x00027BCE
			public static uint MaxDigitValue
			{
				get
				{
					return 15U;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06001993 RID: 6547 RVA: 0x00054872 File Offset: 0x00052A72
			public static int MaxDigitCount
			{
				get
				{
					return IBinaryIntegerParseAndFormatInfo<TInteger>.MaxHexDigitCount;
				}
			}

			// Token: 0x06001994 RID: 6548 RVA: 0x0005487F File Offset: 0x00052A7F
			public static TInteger ShiftLeftForNextDigit(TInteger value)
			{
				return IBinaryIntegerParseAndFormatInfo<TInteger>.MultiplyBy16(value);
			}
		}

		// Token: 0x02000180 RID: 384
		private readonly struct BinaryParser<[IsUnmanaged] TInteger> : Number.IHexOrBinaryParser<!0> where TInteger : struct, ValueType, IBinaryIntegerParseAndFormatInfo<TInteger>
		{
			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06001995 RID: 6549 RVA: 0x0005488D File Offset: 0x00052A8D
			public static NumberStyles AllowedStyles
			{
				get
				{
					return NumberStyles.BinaryNumber;
				}
			}

			// Token: 0x06001996 RID: 6550 RVA: 0x00054894 File Offset: 0x00052A94
			public static bool IsValidChar(uint ch)
			{
				return ch - 48U <= 1U;
			}

			// Token: 0x06001997 RID: 6551 RVA: 0x000548A0 File Offset: 0x00052AA0
			public static uint FromChar(uint ch)
			{
				return ch - 48U;
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06001998 RID: 6552 RVA: 0x000070DD File Offset: 0x000052DD
			public static uint MaxDigitValue
			{
				get
				{
					return 1U;
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x06001999 RID: 6553 RVA: 0x000548A6 File Offset: 0x00052AA6
			public static int MaxDigitCount
			{
				get
				{
					return sizeof(TInteger) * 8;
				}
			}

			// Token: 0x0600199A RID: 6554 RVA: 0x000548B0 File Offset: 0x00052AB0
			public static TInteger ShiftLeftForNextDigit(TInteger value)
			{
				return value << 1;
			}
		}

		// Token: 0x02000181 RID: 385
		[CompilerFeatureRequired("RefStructs")]
		internal ref struct NumberBuffer
		{
			// Token: 0x17000286 RID: 646
			// (get) Token: 0x0600199B RID: 6555 RVA: 0x000548BF File Offset: 0x00052ABF
			public unsafe readonly byte* DigitsPtr
			{
				get
				{
					return (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(this.Digits));
				}
			}

			// Token: 0x0600199C RID: 6556 RVA: 0x000548D1 File Offset: 0x00052AD1
			public unsafe NumberBuffer(Number.NumberBufferKind kind, byte* digits, int digitsLength)
			{
				this = new Number.NumberBuffer(kind, new Span<byte>((void*)digits, digitsLength));
			}

			// Token: 0x0600199D RID: 6557 RVA: 0x000548E1 File Offset: 0x00052AE1
			public unsafe NumberBuffer(Number.NumberBufferKind kind, Span<byte> digits)
			{
				this.DigitsCount = 0;
				this.Scale = 0;
				this.IsNegative = false;
				this.HasNonZeroTail = false;
				this.Kind = kind;
				this.Digits = digits;
				*this.Digits[0] = 0;
			}

			// Token: 0x0600199E RID: 6558 RVA: 0x0005491C File Offset: 0x00052B1C
			public unsafe override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append('[');
				stringBuilder.Append('"');
				for (int i = 0; i < this.Digits.Length; i++)
				{
					byte b = *this.Digits[i];
					if (b == 0)
					{
						break;
					}
					stringBuilder.Append((char)b);
				}
				stringBuilder.Append('"');
				stringBuilder.Append(", Length = ").Append(this.DigitsCount);
				stringBuilder.Append(", Scale = ").Append(this.Scale);
				stringBuilder.Append(", IsNegative = ").Append(this.IsNegative);
				stringBuilder.Append(", HasNonZeroTail = ").Append(this.HasNonZeroTail);
				stringBuilder.Append(", Kind = ").Append(this.Kind);
				stringBuilder.Append(']');
				return stringBuilder.ToString();
			}

			// Token: 0x04000522 RID: 1314
			public int DigitsCount;

			// Token: 0x04000523 RID: 1315
			public int Scale;

			// Token: 0x04000524 RID: 1316
			public bool IsNegative;

			// Token: 0x04000525 RID: 1317
			public bool HasNonZeroTail;

			// Token: 0x04000526 RID: 1318
			public Number.NumberBufferKind Kind;

			// Token: 0x04000527 RID: 1319
			public Span<byte> Digits;
		}

		// Token: 0x02000182 RID: 386
		internal enum NumberBufferKind : byte
		{
			// Token: 0x04000529 RID: 1321
			Unknown,
			// Token: 0x0400052A RID: 1322
			Integer,
			// Token: 0x0400052B RID: 1323
			Decimal,
			// Token: 0x0400052C RID: 1324
			FloatingPoint
		}

		// Token: 0x02000183 RID: 387
		internal enum ParsingStatus
		{
			// Token: 0x0400052E RID: 1326
			OK,
			// Token: 0x0400052F RID: 1327
			Failed,
			// Token: 0x04000530 RID: 1328
			Overflow
		}
	}
}
