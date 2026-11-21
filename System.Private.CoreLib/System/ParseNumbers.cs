using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200018D RID: 397
	internal static class ParseNumbers
	{
		// Token: 0x06001A05 RID: 6661 RVA: 0x00054F6C File Offset: 0x0005316C
		public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags)
		{
			int num = 0;
			return ParseNumbers.StringToLong(s, radix, flags, ref num);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00054F88 File Offset: 0x00053188
		public unsafe static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			int num = currPos;
			int num2 = (-1 == radix) ? 10 : radix;
			if (num2 != 2 && num2 != 10 && num2 != 8 && num2 != 16)
			{
				throw new ArgumentException(SR.Arg_InvalidBase, "radix");
			}
			int length = s.Length;
			if (num < 0 || num >= length)
			{
				throw new ArgumentOutOfRangeException(SR.ArgumentOutOfRange_IndexMustBeLess);
			}
			if ((flags & 4096) == 0)
			{
				ParseNumbers.EatWhiteSpace(s, ref num);
				if (num == length)
				{
					throw new FormatException(SR.Format_EmptyInputString);
				}
			}
			int num3 = 1;
			if (*s[num] == 45)
			{
				if (num2 != 10)
				{
					throw new ArgumentException(SR.Arg_CannotHaveNegativeValue);
				}
				if ((flags & 512) != 0)
				{
					throw new OverflowException(SR.Overflow_NegativeUnsigned);
				}
				num3 = -1;
				num++;
			}
			else if (*s[num] == 43)
			{
				num++;
			}
			if ((radix == -1 || radix == 16) && num + 1 < length && *s[num] == 48 && (*s[num + 1] == 120 || *s[num + 1] == 88))
			{
				num2 = 16;
				num += 2;
			}
			int num4 = num;
			long num5 = ParseNumbers.GrabLongs(num2, s, ref num, (flags & 512) != 0);
			if (num == num4)
			{
				throw new FormatException(SR.Format_NoParsibleDigits);
			}
			if ((flags & 4096) != 0 && num < length)
			{
				throw new FormatException(SR.Format_ExtraJunkAtEnd);
			}
			currPos = num;
			if (num5 == -9223372036854775808L && num3 == 1 && num2 == 10 && (flags & 512) == 0)
			{
				Number.ThrowOverflowException<long>();
			}
			if (num2 == 10)
			{
				num5 *= (long)num3;
			}
			return num5;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00055104 File Offset: 0x00053304
		public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags)
		{
			int num = 0;
			return ParseNumbers.StringToInt(s, radix, flags, ref num);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00055120 File Offset: 0x00053320
		public unsafe static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			int num = currPos;
			int num2 = (-1 == radix) ? 10 : radix;
			if (num2 != 2 && num2 != 10 && num2 != 8 && num2 != 16)
			{
				throw new ArgumentException(SR.Arg_InvalidBase, "radix");
			}
			int length = s.Length;
			if (num < 0 || num >= length)
			{
				throw new ArgumentOutOfRangeException(SR.ArgumentOutOfRange_IndexMustBeLess);
			}
			if ((flags & 4096) == 0)
			{
				ParseNumbers.EatWhiteSpace(s, ref num);
				if (num == length)
				{
					throw new FormatException(SR.Format_EmptyInputString);
				}
			}
			int num3 = 1;
			if (*s[num] == 45)
			{
				if (num2 != 10)
				{
					throw new ArgumentException(SR.Arg_CannotHaveNegativeValue);
				}
				if ((flags & 512) != 0)
				{
					throw new OverflowException(SR.Overflow_NegativeUnsigned);
				}
				num3 = -1;
				num++;
			}
			else if (*s[num] == 43)
			{
				num++;
			}
			if ((radix == -1 || radix == 16) && num + 1 < length && *s[num] == 48 && (*s[num + 1] == 120 || *s[num + 1] == 88))
			{
				num2 = 16;
				num += 2;
			}
			int num4 = num;
			int num5 = ParseNumbers.GrabInts(num2, s, ref num, (flags & 512) != 0);
			if (num == num4)
			{
				throw new FormatException(SR.Format_NoParsibleDigits);
			}
			if ((flags & 4096) != 0 && num < length)
			{
				throw new FormatException(SR.Format_ExtraJunkAtEnd);
			}
			currPos = num;
			if ((flags & 1024) != 0)
			{
				if (num5 > 255)
				{
					Number.ThrowOverflowException<sbyte>();
				}
			}
			else if ((flags & 2048) != 0)
			{
				if (num5 > 65535)
				{
					Number.ThrowOverflowException<short>();
				}
			}
			else if (num5 == -2147483648 && num3 == 1 && num2 == 10 && (flags & 512) == 0)
			{
				Number.ThrowOverflowException<int>();
			}
			if (num2 == 10)
			{
				num5 *= num3;
			}
			return num5;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000552C8 File Offset: 0x000534C8
		private unsafe static void EatWhiteSpace(ReadOnlySpan<char> s, ref int i)
		{
			int num = i;
			while (num < s.Length && char.IsWhiteSpace((char)(*s[num])))
			{
				num++;
			}
			i = num;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x000552FC File Offset: 0x000534FC
		private unsafe static long GrabLongs(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			ulong num = 0UL;
			if (radix == 10 && !isUnsigned)
			{
				ulong num2 = 922337203685477580UL;
				int num3;
				while (i < s.Length && ParseNumbers.IsDigit((char)(*s[i]), radix, out num3))
				{
					if (num > num2 || num < 0UL)
					{
						Number.ThrowOverflowException<long>();
					}
					num = num * (ulong)((long)radix) + (ulong)((long)num3);
					i++;
				}
				if (num < 0UL && num != 9223372036854775808UL)
				{
					Number.ThrowOverflowException<long>();
				}
			}
			else
			{
				ulong num2 = (radix == 10) ? 1844674407370955161UL : ((radix == 16) ? 1152921504606846975UL : ((radix == 8) ? 2305843009213693951UL : 9223372036854775807UL));
				int num4;
				while (i < s.Length && ParseNumbers.IsDigit((char)(*s[i]), radix, out num4))
				{
					if (num > num2)
					{
						Number.ThrowOverflowException<ulong>();
					}
					ulong num5 = num * (ulong)((long)radix) + (ulong)((long)num4);
					if (num5 < num)
					{
						Number.ThrowOverflowException<ulong>();
					}
					num = num5;
					i++;
				}
			}
			return (long)num;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x000553F4 File Offset: 0x000535F4
		private unsafe static int GrabInts(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			uint num = 0U;
			if (radix == 10 && !isUnsigned)
			{
				uint num2 = 214748364U;
				int num3;
				while (i < s.Length && ParseNumbers.IsDigit((char)(*s[i]), radix, out num3))
				{
					if (num > num2 || num < 0U)
					{
						Number.ThrowOverflowException<int>();
					}
					num = num * (uint)radix + (uint)num3;
					i++;
				}
				if (num < 0U && num != 2147483648U)
				{
					Number.ThrowOverflowException<int>();
				}
			}
			else
			{
				uint num2 = (radix == 10) ? 429496729U : ((radix == 16) ? 268435455U : ((radix == 8) ? 536870911U : 2147483647U));
				int num4;
				while (i < s.Length && ParseNumbers.IsDigit((char)(*s[i]), radix, out num4))
				{
					if (num > num2)
					{
						Number.ThrowOverflowException<uint>();
					}
					uint num5 = num * (uint)radix + (uint)num4;
					if (num5 < num)
					{
						Number.ThrowOverflowException<uint>();
					}
					num = num5;
					i++;
				}
			}
			return (int)num;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000554C8 File Offset: 0x000536C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsDigit(char c, int radix, out int result)
		{
			int num;
			if (c - '0' <= '\t')
			{
				num = (result = (int)(c - '0'));
			}
			else if (c - 'A' <= '\u0019')
			{
				num = (result = (int)(c - 'A' + '\n'));
			}
			else
			{
				if (c - 'a' > '\u0019')
				{
					result = -1;
					return false;
				}
				num = (result = (int)(c - 'a' + '\n'));
			}
			return num < radix;
		}
	}
}
