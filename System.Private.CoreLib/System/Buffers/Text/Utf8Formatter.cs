using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Buffers.Text
{
	// Token: 0x020003AE RID: 942
	public static class Utf8Formatter
	{
		// Token: 0x06003D82 RID: 15746 RVA: 0x000CD3E4 File Offset: 0x000CB5E4
		public unsafe static bool TryFormat(bool value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			char symbolOrDefault = FormattingHelpers.GetSymbolOrDefault(format, 'G');
			if (value)
			{
				if (symbolOrDefault == 'G')
				{
					if (!new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.1F419139F10195A90BB89635E7CCFD5D1614E64DA16F8F068BF684FEC5073111), 4).TryCopyTo(destination))
					{
						goto IL_8C;
					}
				}
				else
				{
					if (symbolOrDefault != 'l')
					{
						goto IL_87;
					}
					if (!new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.DEBC2F07DB78D52D2DEF07B7BC620D7042367501D9439A62BA09B559A98E0957), 4).TryCopyTo(destination))
					{
						goto IL_8C;
					}
				}
				bytesWritten = 4;
				return true;
			}
			if (symbolOrDefault == 'G')
			{
				if (!new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.819738269F2DACAAE5A199D3E902828E334B698E7AC1C904F4E5E39931943931), 5).TryCopyTo(destination))
				{
					goto IL_8C;
				}
			}
			else
			{
				if (symbolOrDefault != 'l')
				{
					goto IL_87;
				}
				if (!new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.98151954F217A510702D236DE168CC35D0AB2F99C4479CC9B07EEEDE7EF73A66), 5).TryCopyTo(destination))
				{
					goto IL_8C;
				}
			}
			bytesWritten = 5;
			return true;
			IL_87:
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			IL_8C:
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x000CD484 File Offset: 0x000CB684
		public static bool TryFormat(DateTimeOffset value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			if (format.IsDefault)
			{
				return DateTimeFormat.TryFormatInvariantG<byte>(value.DateTime, value.Offset, destination, out bytesWritten);
			}
			char symbol = format.Symbol;
			if (symbol <= 'O')
			{
				if (symbol == 'G')
				{
					return DateTimeFormat.TryFormatInvariantG<byte>(value.DateTime, Utf8Formatter.NullOffset, destination, out bytesWritten);
				}
				if (symbol != 'O')
				{
					goto IL_91;
				}
				return DateTimeFormat.TryFormatO<byte>(value.DateTime, value.Offset, destination, out bytesWritten);
			}
			else if (symbol != 'R')
			{
				if (symbol != 'l')
				{
					goto IL_91;
				}
				return Utf8Formatter.TryFormatDateTimeL(value.UtcDateTime, destination, out bytesWritten);
			}
			IL_44:
			return DateTimeFormat.TryFormatR<byte>(value.UtcDateTime, Utf8Formatter.NullOffset, destination, out bytesWritten);
			IL_91:
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			goto IL_44;
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x000CD528 File Offset: 0x000CB728
		public static bool TryFormat(DateTime value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			char symbolOrDefault = FormattingHelpers.GetSymbolOrDefault(format, 'G');
			if (symbolOrDefault <= 'O')
			{
				if (symbolOrDefault == 'G')
				{
					return DateTimeFormat.TryFormatInvariantG<byte>(value, Utf8Formatter.NullOffset, destination, out bytesWritten);
				}
				if (symbolOrDefault != 'O')
				{
					goto IL_5A;
				}
				return DateTimeFormat.TryFormatO<byte>(value, Utf8Formatter.NullOffset, destination, out bytesWritten);
			}
			else if (symbolOrDefault != 'R')
			{
				if (symbolOrDefault != 'l')
				{
					goto IL_5A;
				}
				return Utf8Formatter.TryFormatDateTimeL(value, destination, out bytesWritten);
			}
			IL_27:
			return DateTimeFormat.TryFormatR<byte>(value, Utf8Formatter.NullOffset, destination, out bytesWritten);
			IL_5A:
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			goto IL_27;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x000CD595 File Offset: 0x000CB795
		private static bool TryFormatDateTimeL(DateTime value, Span<byte> destination, out int bytesWritten)
		{
			if (DateTimeFormat.TryFormatR<byte>(value, Utf8Formatter.NullOffset, destination, out bytesWritten))
			{
				Ascii.ToLowerInPlace(destination.Slice(0, bytesWritten), out bytesWritten);
				return true;
			}
			return false;
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06003D86 RID: 15750 RVA: 0x000CD5BA File Offset: 0x000CB7BA
		private static TimeSpan NullOffset
		{
			get
			{
				return new TimeSpan(long.MinValue);
			}
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x000CD5CA File Offset: 0x000CB7CA
		public static bool TryFormat(decimal value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			return FormattingHelpers.TryFormat<decimal>(value, destination, out bytesWritten, format);
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x000CD5D5 File Offset: 0x000CB7D5
		public static bool TryFormat(double value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			return FormattingHelpers.TryFormat<double>(value, destination, out bytesWritten, format);
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x000CD5E0 File Offset: 0x000CB7E0
		public static bool TryFormat(float value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			return FormattingHelpers.TryFormat<float>(value, destination, out bytesWritten, format);
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x000CD5EC File Offset: 0x000CB7EC
		public static bool TryFormat(Guid value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			char symbolOrDefault = FormattingHelpers.GetSymbolOrDefault(format, 'D');
			int flags;
			if (symbolOrDefault <= 'D')
			{
				if (symbolOrDefault == 'B')
				{
					flags = -2139260122;
					goto IL_4B;
				}
				if (symbolOrDefault != 'D')
				{
					goto IL_44;
				}
			}
			else
			{
				if (symbolOrDefault == 'N')
				{
					flags = 32;
					goto IL_4B;
				}
				if (symbolOrDefault != 'P')
				{
					goto IL_44;
				}
				flags = -2144786394;
				goto IL_4B;
			}
			IL_27:
			flags = -2147483612;
			goto IL_4B;
			IL_44:
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			goto IL_27;
			IL_4B:
			return value.TryFormatCore<byte>(destination, out bytesWritten, flags);
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x000CD64E File Offset: 0x000CB84E
		public static bool TryFormat(byte value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			return Utf8Formatter.TryFormat((uint)value, destination, out bytesWritten, format);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x000CD659 File Offset: 0x000CB859
		[CLSCompliant(false)]
		public static bool TryFormat(sbyte value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			return Utf8Formatter.TryFormat((int)value, 255, destination, out bytesWritten, format);
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x000CD64E File Offset: 0x000CB84E
		[CLSCompliant(false)]
		public static bool TryFormat(ushort value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			return Utf8Formatter.TryFormat((uint)value, destination, out bytesWritten, format);
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x000CD669 File Offset: 0x000CB869
		public static bool TryFormat(short value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			return Utf8Formatter.TryFormat((int)value, 65535, destination, out bytesWritten, format);
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x000CD67C File Offset: 0x000CB87C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryFormat(uint value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			if (format.IsDefault)
			{
				return Number.TryUInt32ToDecStr<byte>(value, destination, out bytesWritten);
			}
			int num = (int)(format.Symbol | ' ');
			if (num <= 103)
			{
				if (num != 100)
				{
					if (num != 103)
					{
						goto IL_85;
					}
					goto IL_75;
				}
			}
			else
			{
				if (num == 110)
				{
					return FormattingHelpers.TryFormat<uint>(value, destination, out bytesWritten, format);
				}
				if (num == 114)
				{
					goto IL_75;
				}
				if (num != 120)
				{
					goto IL_85;
				}
				return Number.TryInt32ToHexStr<byte>((int)value, Number.GetHexBase(format.Symbol), (int)format.PrecisionOrZero, destination, out bytesWritten);
			}
			IL_3F:
			return Number.TryUInt32ToDecStr<byte>(value, (int)format.PrecisionOrZero, destination, out bytesWritten);
			IL_75:
			if (format.HasPrecision)
			{
				Utf8Formatter.ThrowGWithPrecisionNotSupported();
				goto IL_3F;
			}
			goto IL_3F;
			IL_85:
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			goto IL_3F;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x000CD714 File Offset: 0x000CB914
		public static bool TryFormat(int value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			return Utf8Formatter.TryFormat(value, -1, destination, out bytesWritten, format);
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x000CD720 File Offset: 0x000CB920
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryFormat(int value, int hexMask, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			if (!format.IsDefault)
			{
				int num = (int)(format.Symbol | ' ');
				if (num <= 103)
				{
					if (num != 100)
					{
						if (num != 103)
						{
							goto IL_C6;
						}
						goto IL_B6;
					}
				}
				else
				{
					if (num == 110)
					{
						return FormattingHelpers.TryFormat<int>(value, destination, out bytesWritten, format);
					}
					if (num == 114)
					{
						goto IL_B6;
					}
					if (num != 120)
					{
						goto IL_C6;
					}
					return Number.TryInt32ToHexStr<byte>(value & hexMask, Number.GetHexBase(format.Symbol), (int)format.PrecisionOrZero, destination, out bytesWritten);
				}
				IL_5E:
				if (value < 0)
				{
					return Number.TryNegativeInt32ToDecStr<byte>(value, (int)format.PrecisionOrZero, new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.24EA1EBD0BAFD39482DB46EC2D8959E61353A90EFC072719E1308F86C3A106BA), 1), destination, out bytesWritten);
				}
				return Number.TryUInt32ToDecStr<byte>((uint)value, (int)format.PrecisionOrZero, destination, out bytesWritten);
				IL_B6:
				if (format.HasPrecision)
				{
					Utf8Formatter.ThrowGWithPrecisionNotSupported();
					goto IL_5E;
				}
				goto IL_5E;
				IL_C6:
				ThrowHelper.ThrowFormatException_BadFormatSpecifier();
				goto IL_5E;
			}
			if (value < 0)
			{
				return Number.TryNegativeInt32ToDecStr<byte>(value, (int)format.PrecisionOrZero, new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.24EA1EBD0BAFD39482DB46EC2D8959E61353A90EFC072719E1308F86C3A106BA), 1), destination, out bytesWritten);
			}
			return Number.TryUInt32ToDecStr<byte>((uint)value, destination, out bytesWritten);
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x000CD7FC File Offset: 0x000CB9FC
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryFormat(ulong value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			if (format.IsDefault)
			{
				return Number.TryUInt64ToDecStr<byte>(value, destination, out bytesWritten);
			}
			int num = (int)(format.Symbol | ' ');
			if (num <= 103)
			{
				if (num != 100)
				{
					if (num != 103)
					{
						goto IL_85;
					}
					goto IL_75;
				}
			}
			else
			{
				if (num == 110)
				{
					return FormattingHelpers.TryFormat<ulong>(value, destination, out bytesWritten, format);
				}
				if (num == 114)
				{
					goto IL_75;
				}
				if (num != 120)
				{
					goto IL_85;
				}
				return Number.TryInt64ToHexStr<byte>((long)value, Number.GetHexBase(format.Symbol), (int)format.PrecisionOrZero, destination, out bytesWritten);
			}
			IL_3F:
			return Number.TryUInt64ToDecStr<byte>(value, (int)format.PrecisionOrZero, destination, out bytesWritten);
			IL_75:
			if (format.HasPrecision)
			{
				Utf8Formatter.ThrowGWithPrecisionNotSupported();
				goto IL_3F;
			}
			goto IL_3F;
			IL_85:
			ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			goto IL_3F;
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x000CD894 File Offset: 0x000CBA94
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static bool TryFormat(long value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			if (!format.IsDefault)
			{
				int num = (int)(format.Symbol | ' ');
				if (num <= 103)
				{
					if (num != 100)
					{
						if (num != 103)
						{
							goto IL_C5;
						}
						goto IL_B5;
					}
				}
				else
				{
					if (num == 110)
					{
						return FormattingHelpers.TryFormat<long>(value, destination, out bytesWritten, format);
					}
					if (num == 114)
					{
						goto IL_B5;
					}
					if (num != 120)
					{
						goto IL_C5;
					}
					return Number.TryInt64ToHexStr<byte>(value, Number.GetHexBase(format.Symbol), (int)format.PrecisionOrZero, destination, out bytesWritten);
				}
				IL_5F:
				if (value < 0L)
				{
					return Number.TryNegativeInt64ToDecStr<byte>(value, (int)format.PrecisionOrZero, new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.24EA1EBD0BAFD39482DB46EC2D8959E61353A90EFC072719E1308F86C3A106BA), 1), destination, out bytesWritten);
				}
				return Number.TryUInt64ToDecStr<byte>((ulong)value, (int)format.PrecisionOrZero, destination, out bytesWritten);
				IL_B5:
				if (format.HasPrecision)
				{
					Utf8Formatter.ThrowGWithPrecisionNotSupported();
					goto IL_5F;
				}
				goto IL_5F;
				IL_C5:
				ThrowHelper.ThrowFormatException_BadFormatSpecifier();
				goto IL_5F;
			}
			if (value < 0L)
			{
				return Number.TryNegativeInt64ToDecStr<byte>(value, (int)format.PrecisionOrZero, new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.24EA1EBD0BAFD39482DB46EC2D8959E61353A90EFC072719E1308F86C3A106BA), 1), destination, out bytesWritten);
			}
			return Number.TryUInt64ToDecStr<byte>((ulong)value, destination, out bytesWritten);
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x000CD96C File Offset: 0x000CBB6C
		private static void ThrowGWithPrecisionNotSupported()
		{
			throw new NotSupportedException(SR.Argument_GWithPrecisionNotSupported);
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x000CD978 File Offset: 0x000CBB78
		public static bool TryFormat(TimeSpan value, Span<byte> destination, out int bytesWritten, StandardFormat format = default(StandardFormat))
		{
			TimeSpanFormat.StandardFormat format2 = TimeSpanFormat.StandardFormat.C;
			ReadOnlySpan<byte> decimalSeparator = default(ReadOnlySpan<byte>);
			char symbolOrDefault = FormattingHelpers.GetSymbolOrDefault(format, 'c');
			if (symbolOrDefault != 'c' && (symbolOrDefault | ' ') != 't')
			{
				decimalSeparator = DateTimeFormatInfo.InvariantInfo.DecimalSeparatorTChar<byte>();
				if (symbolOrDefault == 'g')
				{
					format2 = TimeSpanFormat.StandardFormat.g;
				}
				else
				{
					format2 = TimeSpanFormat.StandardFormat.G;
					if (symbolOrDefault != 'G')
					{
						ThrowHelper.ThrowFormatException_BadFormatSpecifier();
					}
				}
			}
			return TimeSpanFormat.TryFormatStandard<byte>(value, format2, decimalSeparator, destination, out bytesWritten);
		}
	}
}
