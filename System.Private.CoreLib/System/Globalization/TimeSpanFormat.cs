using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x02000318 RID: 792
	internal static class TimeSpanFormat
	{
		// Token: 0x06003997 RID: 14743 RVA: 0x000BDDE4 File Offset: 0x000BBFE4
		internal unsafe static string Format(TimeSpan value, string format, IFormatProvider formatProvider)
		{
			if (string.IsNullOrEmpty(format))
			{
				return TimeSpanFormat.FormatC(value);
			}
			if (format.Length != 1)
			{
				Span<char> initialSpan = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(initialSpan);
				TimeSpanFormat.FormatCustomized<char>(value, format, DateTimeFormatInfo.GetInstance(formatProvider), ref valueListBuilder);
				string result = valueListBuilder.AsSpan().ToString();
				valueListBuilder.Dispose();
				return result;
			}
			char c = format[0];
			if (c == 'c' || (c | ' ') == 't')
			{
				return TimeSpanFormat.FormatC(value);
			}
			if ((c | ' ') == 'g')
			{
				return TimeSpanFormat.FormatG(value, DateTimeFormatInfo.GetInstance(formatProvider), (c == 'G') ? TimeSpanFormat.StandardFormat.G : TimeSpanFormat.StandardFormat.g);
			}
			throw new FormatException(SR.Format_InvalidString);
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x000BDE9C File Offset: 0x000BC09C
		internal unsafe static bool TryFormat<[IsUnmanaged] TChar>(TimeSpan value, Span<TChar> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length == 0)
			{
				return TimeSpanFormat.TryFormatStandard<TChar>(value, TimeSpanFormat.StandardFormat.C, null, destination, out charsWritten);
			}
			if (format.Length != 1)
			{
				Span<TChar> initialSpan = new Span<TChar>(stackalloc byte[checked(unchecked((UIntPtr)256) * (UIntPtr)sizeof(TChar))], 256);
				ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(initialSpan);
				TimeSpanFormat.FormatCustomized<TChar>(value, format, DateTimeFormatInfo.GetInstance(formatProvider), ref valueListBuilder);
				bool result = valueListBuilder.TryCopyTo(destination, out charsWritten);
				valueListBuilder.Dispose();
				return result;
			}
			char c = (char)(*format[0]);
			if (c == 'c' || (c | ' ') == 't')
			{
				return TimeSpanFormat.TryFormatStandard<TChar>(value, TimeSpanFormat.StandardFormat.C, null, destination, out charsWritten);
			}
			TimeSpanFormat.StandardFormat standardFormat;
			if (c != 'g')
			{
				if (c != 'G')
				{
					throw new FormatException(SR.Format_InvalidString);
				}
				standardFormat = TimeSpanFormat.StandardFormat.G;
			}
			else
			{
				standardFormat = TimeSpanFormat.StandardFormat.g;
			}
			TimeSpanFormat.StandardFormat format2 = standardFormat;
			return TimeSpanFormat.TryFormatStandard<TChar>(value, format2, DateTimeFormatInfo.GetInstance(formatProvider).DecimalSeparatorTChar<TChar>(), destination, out charsWritten);
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x000BDF68 File Offset: 0x000BC168
		internal unsafe static string FormatC(TimeSpan value)
		{
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)52], 26);
			int length;
			TimeSpanFormat.TryFormatStandard<char>(value, TimeSpanFormat.StandardFormat.C, null, destination, out length);
			return new string(destination.Slice(0, length));
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x000BDFA8 File Offset: 0x000BC1A8
		private unsafe static string FormatG(TimeSpan value, DateTimeFormatInfo dtfi, TimeSpanFormat.StandardFormat format)
		{
			string decimalSeparator = dtfi.DecimalSeparator;
			int num = 25 + decimalSeparator.Length;
			Span<char> span;
			if (num < 128)
			{
				int num2 = num;
				span = new Span<char>(stackalloc byte[checked(unchecked((UIntPtr)num2) * 2)], num2);
			}
			else
			{
				span = new char[num];
			}
			Span<char> destination = span;
			int length;
			TimeSpanFormat.TryFormatStandard<char>(value, format, decimalSeparator, destination, out length);
			return new string(destination.Slice(0, length));
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x000BE018 File Offset: 0x000BC218
		internal unsafe static bool TryFormatStandard<[IsUnmanaged] TChar>(TimeSpan value, TimeSpanFormat.StandardFormat format, ReadOnlySpan<TChar> decimalSeparator, Span<TChar> destination, out int written) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = 8;
			long num2 = value.Ticks;
			uint num3;
			ulong num4;
			if (num2 < 0L)
			{
				num = 9;
				num2 = -num2;
				if (num2 < 0L)
				{
					num3 = 4775808U;
					num4 = 922337203685UL;
					goto IL_4C;
				}
			}
			ValueTuple<ulong, ulong> valueTuple = Math.DivRem((ulong)num2, 10000000UL);
			num4 = valueTuple.Item1;
			num3 = (uint)valueTuple.Item2;
			IL_4C:
			int num5 = 0;
			if (format != TimeSpanFormat.StandardFormat.C)
			{
				if (format != TimeSpanFormat.StandardFormat.G)
				{
					if (num3 != 0U)
					{
						num5 = 7 - FormattingHelpers.CountDecimalTrailingZeros(num3, out num3);
						num += num5;
						num += decimalSeparator.Length;
					}
				}
				else
				{
					num5 = 7;
					num += num5;
					num += decimalSeparator.Length;
				}
			}
			else if (num3 != 0U)
			{
				num5 = 7;
				num += num5 + 1;
			}
			ulong num6 = 0UL;
			ulong num7 = 0UL;
			if (num4 > 0UL)
			{
				ValueTuple<ulong, ulong> valueTuple2 = Math.DivRem(num4, 60UL);
				num6 = valueTuple2.Item1;
				num7 = valueTuple2.Item2;
			}
			ulong num8 = 0UL;
			ulong num9 = 0UL;
			if (num6 > 0UL)
			{
				ValueTuple<ulong, ulong> valueTuple3 = Math.DivRem(num6, 60UL);
				num8 = valueTuple3.Item1;
				num9 = valueTuple3.Item2;
			}
			uint num10 = 0U;
			uint num11 = 0U;
			if (num8 > 0UL)
			{
				ValueTuple<uint, uint> valueTuple4 = Math.DivRem((uint)num8, 24U);
				num10 = valueTuple4.Item1;
				num11 = valueTuple4.Item2;
			}
			int num12 = 2;
			if (format == TimeSpanFormat.StandardFormat.g && num11 < 10U)
			{
				num12 = 1;
				num--;
			}
			int num13 = 0;
			if (num10 > 0U)
			{
				num13 = FormattingHelpers.CountDigits(num10);
				num += num13 + 1;
			}
			else if (format == TimeSpanFormat.StandardFormat.G)
			{
				num += 2;
				num13 = 1;
			}
			if (destination.Length < num)
			{
				written = 0;
				return false;
			}
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				if (value.Ticks < 0L)
				{
					TChar* ptr2 = ptr;
					ptr = ptr2 + sizeof(TChar) / sizeof(TChar);
					*ptr2 = IUtfChar<TChar>.CastFrom('-');
				}
				if (num13 != 0)
				{
					Number.WriteDigits<TChar>(num10, ptr, num13);
					ptr += (IntPtr)num13 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					TChar* ptr3 = ptr;
					ptr = ptr3 + sizeof(TChar) / sizeof(TChar);
					*ptr3 = IUtfChar<TChar>.CastFrom((format == TimeSpanFormat.StandardFormat.C) ? '.' : ':');
				}
				if (num12 == 2)
				{
					Number.WriteTwoDigits<TChar>(num11, ptr);
					ptr += (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				}
				else
				{
					TChar* ptr4 = ptr;
					ptr = ptr4 + sizeof(TChar) / sizeof(TChar);
					*ptr4 = IUtfChar<TChar>.CastFrom(48U + num11);
				}
				TChar* ptr5 = ptr;
				ptr = ptr5 + sizeof(TChar) / sizeof(TChar);
				*ptr5 = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)num9, ptr);
				ptr += (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				TChar* ptr6 = ptr;
				ptr = ptr6 + sizeof(TChar) / sizeof(TChar);
				*ptr6 = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)num7, ptr);
				ptr += (IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				if (num5 != 0)
				{
					if (format == TimeSpanFormat.StandardFormat.C)
					{
						TChar* ptr7 = ptr;
						ptr = ptr7 + sizeof(TChar) / sizeof(TChar);
						*ptr7 = IUtfChar<TChar>.CastFrom('.');
					}
					else if (decimalSeparator.Length == 1)
					{
						TChar* ptr8 = ptr;
						ptr = ptr8 + sizeof(TChar) / sizeof(TChar);
						*ptr8 = *decimalSeparator[0];
					}
					else
					{
						decimalSeparator.CopyTo(new Span<TChar>((void*)ptr, decimalSeparator.Length));
						ptr += (IntPtr)decimalSeparator.Length * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
					}
					Number.WriteDigits<TChar>(num3, ptr, num5);
					ptr += (IntPtr)num5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar);
				}
			}
			written = num;
			return true;
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x000BE334 File Offset: 0x000BC534
		private unsafe static void FormatCustomized<[IsUnmanaged] TChar>(TimeSpan value, [ScopedRef] ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, ref ValueListBuilder<TChar> result) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = (int)(value.Ticks / 864000000000L);
			long num2 = value.Ticks % 864000000000L;
			if (value.Ticks < 0L)
			{
				num = -num;
				num2 = -num2;
			}
			int value2 = (int)(num2 / 36000000000L % 24L);
			int value3 = (int)(num2 / 600000000L % 60L);
			int value4 = (int)(num2 / 10000000L % 60L);
			int num3 = (int)(num2 % 10000000L);
			int i = 0;
			while (i < format.Length)
			{
				char c = (char)(*format[i]);
				int num5;
				if (c <= 'F')
				{
					if (c <= '%')
					{
						if (c != '"')
						{
							if (c != '%')
							{
								goto IL_290;
							}
							int num4 = DateTimeFormat.ParseNextChar(format, i);
							if (num4 >= 0 && num4 != 37)
							{
								char c2 = (char)num4;
								TimeSpanFormat.FormatCustomized<TChar>(value, new ReadOnlySpan<char>(ref c2), dtfi, ref result);
								num5 = 2;
								goto IL_29B;
							}
							goto IL_290;
						}
					}
					else if (c != '\'')
					{
						if (c != 'F')
						{
							goto IL_290;
						}
						num5 = DateTimeFormat.ParseRepeatPattern(format, i, c);
						if (num5 > 7)
						{
							goto IL_290;
						}
						int num6 = num3;
						num6 /= TimeSpanParse.Pow10UpToMaxFractionDigits(7 - num5);
						int num7 = num5;
						while (num7 > 0 && num6 % 10 == 0)
						{
							num6 /= 10;
							num7--;
						}
						if (num7 > 0)
						{
							DateTimeFormat.FormatFraction<TChar>(ref result, num6, DateTimeFormat.fixedNumberFormats[num7 - 1]);
							goto IL_29B;
						}
						goto IL_29B;
					}
					num5 = DateTimeFormat.ParseQuoteString<TChar>(format, i, ref result);
				}
				else if (c <= 'h')
				{
					if (c != '\\')
					{
						switch (c)
						{
						case 'd':
							num5 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							if (num5 > 8)
							{
								goto IL_290;
							}
							DateTimeFormat.FormatDigits<TChar>(ref result, num, num5);
							break;
						case 'e':
						case 'g':
							goto IL_290;
						case 'f':
						{
							num5 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							if (num5 > 7)
							{
								goto IL_290;
							}
							int num6 = num3;
							num6 /= TimeSpanParse.Pow10UpToMaxFractionDigits(7 - num5);
							DateTimeFormat.FormatFraction<TChar>(ref result, num6, DateTimeFormat.fixedNumberFormats[num5 - 1]);
							break;
						}
						case 'h':
							num5 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							if (num5 > 2)
							{
								goto IL_290;
							}
							DateTimeFormat.FormatDigits<TChar>(ref result, value2, num5);
							break;
						default:
							goto IL_290;
						}
					}
					else
					{
						int num4 = DateTimeFormat.ParseNextChar(format, i);
						if (num4 < 0)
						{
							goto IL_290;
						}
						result.Append(IUtfChar<TChar>.CastFrom(num4));
						num5 = 2;
					}
				}
				else if (c != 'm')
				{
					if (c != 's')
					{
						goto IL_290;
					}
					num5 = DateTimeFormat.ParseRepeatPattern(format, i, c);
					if (num5 > 2)
					{
						goto IL_290;
					}
					DateTimeFormat.FormatDigits<TChar>(ref result, value4, num5);
				}
				else
				{
					num5 = DateTimeFormat.ParseRepeatPattern(format, i, c);
					if (num5 > 2)
					{
						goto IL_290;
					}
					DateTimeFormat.FormatDigits<TChar>(ref result, value3, num5);
				}
				IL_29B:
				i += num5;
				continue;
				IL_290:
				throw new FormatException(SR.Format_InvalidString);
			}
		}

		// Token: 0x04000B70 RID: 2928
		internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals = TimeSpanFormat.FormatLiterals.InitInvariant(false);

		// Token: 0x04000B71 RID: 2929
		internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals = TimeSpanFormat.FormatLiterals.InitInvariant(true);

		// Token: 0x02000319 RID: 793
		internal enum StandardFormat
		{
			// Token: 0x04000B73 RID: 2931
			C,
			// Token: 0x04000B74 RID: 2932
			G,
			// Token: 0x04000B75 RID: 2933
			g
		}

		// Token: 0x0200031A RID: 794
		internal struct FormatLiterals
		{
			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x0600399E RID: 14750 RVA: 0x000BE609 File Offset: 0x000BC809
			internal string Start
			{
				get
				{
					return this._literals[0];
				}
			}

			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x0600399F RID: 14751 RVA: 0x000BE613 File Offset: 0x000BC813
			internal string DayHourSep
			{
				get
				{
					return this._literals[1];
				}
			}

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x060039A0 RID: 14752 RVA: 0x000BE61D File Offset: 0x000BC81D
			internal string HourMinuteSep
			{
				get
				{
					return this._literals[2];
				}
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x060039A1 RID: 14753 RVA: 0x000BE627 File Offset: 0x000BC827
			internal string MinuteSecondSep
			{
				get
				{
					return this._literals[3];
				}
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x060039A2 RID: 14754 RVA: 0x000BE631 File Offset: 0x000BC831
			internal string SecondFractionSep
			{
				get
				{
					return this._literals[4];
				}
			}

			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x060039A3 RID: 14755 RVA: 0x000BE63B File Offset: 0x000BC83B
			internal string End
			{
				get
				{
					return this._literals[5];
				}
			}

			// Token: 0x060039A4 RID: 14756 RVA: 0x000BE648 File Offset: 0x000BC848
			internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative)
			{
				TimeSpanFormat.FormatLiterals formatLiterals = new TimeSpanFormat.FormatLiterals
				{
					_literals = new string[6]
				};
				formatLiterals._literals[0] = (isNegative ? "-" : string.Empty);
				formatLiterals._literals[1] = ".";
				formatLiterals._literals[2] = ":";
				formatLiterals._literals[3] = ":";
				formatLiterals._literals[4] = ".";
				formatLiterals._literals[5] = string.Empty;
				formatLiterals.AppCompatLiteral = ":.";
				formatLiterals.dd = 2;
				formatLiterals.hh = 2;
				formatLiterals.mm = 2;
				formatLiterals.ss = 2;
				formatLiterals.ff = 7;
				return formatLiterals;
			}

			// Token: 0x060039A5 RID: 14757 RVA: 0x000BE6F8 File Offset: 0x000BC8F8
			internal unsafe void Init(ReadOnlySpan<char> format, bool useInvariantFieldLengths)
			{
				this.dd = (this.hh = (this.mm = (this.ss = (this.ff = 0))));
				this._literals = new string[6];
				for (int i = 0; i < this._literals.Length; i++)
				{
					this._literals[i] = string.Empty;
				}
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
				bool flag = false;
				char c = '\'';
				int num = 0;
				int j = 0;
				while (j < format.Length)
				{
					char c2 = (char)(*format[j]);
					if (c2 <= 'F')
					{
						if (c2 <= '%')
						{
							if (c2 != '"')
							{
								if (c2 != '%')
								{
									goto IL_1E2;
								}
								goto IL_1E2;
							}
						}
						else if (c2 != '\'')
						{
							if (c2 != 'F')
							{
								goto IL_1E2;
							}
							goto IL_1CD;
						}
						if (flag && c == (char)(*format[j]))
						{
							this._literals[num] = valueStringBuilder.AsSpan().ToString();
							valueStringBuilder.Length = 0;
							flag = false;
						}
						else if (!flag)
						{
							c = (char)(*format[j]);
							flag = true;
						}
					}
					else if (c2 <= 'h')
					{
						if (c2 != '\\')
						{
							switch (c2)
							{
							case 'd':
								if (!flag)
								{
									num = 1;
									this.dd++;
								}
								break;
							case 'e':
							case 'g':
								goto IL_1E2;
							case 'f':
								goto IL_1CD;
							case 'h':
								if (!flag)
								{
									num = 2;
									this.hh++;
								}
								break;
							default:
								goto IL_1E2;
							}
						}
						else
						{
							if (flag)
							{
								goto IL_1E2;
							}
							j++;
						}
					}
					else if (c2 != 'm')
					{
						if (c2 != 's')
						{
							goto IL_1E2;
						}
						if (!flag)
						{
							num = 4;
							this.ss++;
						}
					}
					else if (!flag)
					{
						num = 3;
						this.mm++;
					}
					IL_1F3:
					j++;
					continue;
					IL_1CD:
					if (!flag)
					{
						num = 5;
						this.ff++;
						goto IL_1F3;
					}
					goto IL_1F3;
					IL_1E2:
					valueStringBuilder.Append((char)(*format[j]));
					goto IL_1F3;
				}
				valueStringBuilder.Dispose();
				this.AppCompatLiteral = this.MinuteSecondSep + this.SecondFractionSep;
				if (useInvariantFieldLengths)
				{
					this.dd = 2;
					this.hh = 2;
					this.mm = 2;
					this.ss = 2;
					this.ff = 7;
					return;
				}
				if (this.dd < 1 || this.dd > 2)
				{
					this.dd = 2;
				}
				if (this.hh < 1 || this.hh > 2)
				{
					this.hh = 2;
				}
				if (this.mm < 1 || this.mm > 2)
				{
					this.mm = 2;
				}
				if (this.ss < 1 || this.ss > 2)
				{
					this.ss = 2;
				}
				if (this.ff < 1 || this.ff > 7)
				{
					this.ff = 7;
				}
			}

			// Token: 0x04000B76 RID: 2934
			internal string AppCompatLiteral;

			// Token: 0x04000B77 RID: 2935
			internal int dd;

			// Token: 0x04000B78 RID: 2936
			internal int hh;

			// Token: 0x04000B79 RID: 2937
			internal int mm;

			// Token: 0x04000B7A RID: 2938
			internal int ss;

			// Token: 0x04000B7B RID: 2939
			internal int ff;

			// Token: 0x04000B7C RID: 2940
			private string[] _literals;
		}
	}
}
