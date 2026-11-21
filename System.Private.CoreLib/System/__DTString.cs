using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000129 RID: 297
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct __DTString
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x00038D20 File Offset: 0x00036F20
		internal int Length
		{
			get
			{
				return this.Value.Length;
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00038D2D File Offset: 0x00036F2D
		internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi, bool checkDigitToken)
		{
			this = new __DTString(str, dtfi);
			this.m_checkDigitToken = checkDigitToken;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00038D3E File Offset: 0x00036F3E
		internal __DTString(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi)
		{
			this.Index = -1;
			this.Value = str;
			this.m_current = '\0';
			this.m_info = dtfi.CompareInfo;
			this.m_checkDigitToken = ((dtfi.FormatFlags & DateTimeFormatFlags.UseDigitPrefixInTokens) > DateTimeFormatFlags.None);
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00038D73 File Offset: 0x00036F73
		internal CompareInfo CompareInfo
		{
			get
			{
				return this.m_info;
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00038D7B File Offset: 0x00036F7B
		internal unsafe bool GetNext()
		{
			this.Index++;
			if (this.Index < this.Length)
			{
				this.m_current = (char)(*this.Value[this.Index]);
				return true;
			}
			return false;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00038DB4 File Offset: 0x00036FB4
		internal bool AtEnd()
		{
			return this.Index >= this.Length;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00038DC7 File Offset: 0x00036FC7
		internal unsafe bool Advance(int count)
		{
			this.Index += count;
			if (this.Index < this.Length)
			{
				this.m_current = (char)(*this.Value[this.Index]);
				return true;
			}
			return false;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00038E00 File Offset: 0x00037000
		internal unsafe void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi)
		{
			tokenValue = 0;
			if (this.Index >= this.Length)
			{
				tokenType = TokenType.EndOfString;
				return;
			}
			IL_15:
			while (!char.IsAsciiDigit(this.m_current))
			{
				if (char.IsWhiteSpace(this.m_current))
				{
					for (;;)
					{
						int num = this.Index + 1;
						this.Index = num;
						if (num >= this.Length)
						{
							break;
						}
						this.m_current = (char)(*this.Value[this.Index]);
						if (!char.IsWhiteSpace(this.m_current))
						{
							goto IL_15;
						}
					}
					tokenType = TokenType.EndOfString;
					return;
				}
				dtfi.Tokenize(TokenType.RegularTokenMask, out tokenType, out tokenValue, ref this);
				return;
			}
			tokenValue = (int)(this.m_current - '0');
			int index = this.Index;
			for (;;)
			{
				int num = this.Index + 1;
				this.Index = num;
				if (num >= this.Length)
				{
					break;
				}
				this.m_current = (char)(*this.Value[this.Index]);
				int num2 = (int)(this.m_current - '0');
				if (num2 < 0 || num2 > 9)
				{
					break;
				}
				tokenValue = tokenValue * 10 + num2;
			}
			if (this.Index - index > 8)
			{
				tokenType = TokenType.NumberToken;
				tokenValue = -1;
			}
			else if (this.Index - index < 3)
			{
				tokenType = TokenType.NumberToken;
			}
			else
			{
				tokenType = TokenType.YearNumberToken;
			}
			if (!this.m_checkDigitToken)
			{
				return;
			}
			int index2 = this.Index;
			char current = this.m_current;
			this.Index = index;
			this.m_current = (char)(*this.Value[this.Index]);
			TokenType tokenType2;
			int num3;
			if (dtfi.Tokenize(TokenType.RegularTokenMask, out tokenType2, out num3, ref this))
			{
				tokenType = tokenType2;
				tokenValue = num3;
				return;
			}
			this.Index = index2;
			this.m_current = current;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00038F80 File Offset: 0x00037180
		internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
		{
			indexBeforeSeparator = this.Index;
			charBeforeSeparator = this.m_current;
			if (!this.SkipWhiteSpaceAndRtlMarkCurrent())
			{
				return TokenType.SEP_End;
			}
			TokenType result;
			if (!char.IsAsciiDigit(this.m_current))
			{
				int num;
				if (!dtfi.Tokenize(TokenType.SeparatorTokenMask, out result, out num, ref this))
				{
					result = TokenType.SEP_Space;
				}
			}
			else
			{
				result = TokenType.SEP_Space;
			}
			return result;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00038FDC File Offset: 0x000371DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool MatchSpecifiedWord(string target)
		{
			return this.Index + target.Length <= this.Length && this.m_info.Compare(this.Value.Slice(this.Index, target.Length), target, CompareOptions.IgnoreCase) == 0;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0003902C File Offset: 0x0003722C
		internal unsafe bool MatchSpecifiedWords(string target, bool checkWordBoundary, [ScopedRef] ref int matchLength)
		{
			int num = this.Value.Length - this.Index;
			matchLength = target.Length;
			if (matchLength > num || this.m_info.Compare(this.Value.Slice(this.Index, matchLength), target, CompareOptions.IgnoreCase) != 0)
			{
				int num2 = 0;
				int num3 = this.Index;
				int num4 = target.AsSpan(num2).IndexOfAny(" \u00a0\u202f");
				if (num4 < 0)
				{
					return false;
				}
				num4 += num2;
				for (;;)
				{
					int num5 = num4 - num2;
					if (num3 >= this.Value.Length - num5)
					{
						break;
					}
					if (num5 == 0)
					{
						matchLength--;
					}
					else
					{
						if (!char.IsWhiteSpace((char)(*this.Value[num3 + num5])))
						{
							return false;
						}
						if (this.m_info.CompareOptionIgnoreCase(this.Value.Slice(num3, num5), target.AsSpan(num2, num5)) != 0)
						{
							return false;
						}
						num3 = num3 + num5 + 1;
					}
					num2 = num4 + 1;
					while (num3 < this.Value.Length && char.IsWhiteSpace((char)(*this.Value[num3])))
					{
						num3++;
						matchLength++;
					}
					num4 = target.AsSpan(num2).IndexOfAny(" \u00a0\u202f");
					if (num4 < 0)
					{
						goto IL_134;
					}
					num4 += num2;
				}
				return false;
				IL_134:
				if (num2 < target.Length)
				{
					int num6 = target.Length - num2;
					if (num3 > this.Value.Length - num6)
					{
						return false;
					}
					if (this.m_info.CompareOptionIgnoreCase(this.Value.Slice(num3, num6), target.AsSpan(num2, num6)) != 0)
					{
						return false;
					}
				}
			}
			if (checkWordBoundary)
			{
				int num7 = this.Index + matchLength;
				if (num7 < this.Value.Length && char.IsLetter((char)(*this.Value[num7])))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000391F0 File Offset: 0x000373F0
		internal bool Match(string str)
		{
			int num = this.Index + 1;
			this.Index = num;
			if (num < this.Length && this.Value.Slice(this.Index).StartsWith(str))
			{
				this.Index += str.Length - 1;
				return true;
			}
			return false;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0003924C File Offset: 0x0003744C
		internal unsafe bool Match(char ch)
		{
			int num = this.Index + 1;
			this.Index = num;
			if (num >= this.Length)
			{
				return false;
			}
			if (*this.Value[this.Index] == (ushort)ch || (ch == ' ' && __DTString.IsSpaceReplacingChar((char)(*this.Value[this.Index]))))
			{
				this.m_current = ch;
				return true;
			}
			this.Index--;
			return false;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000392BF File Offset: 0x000374BF
		private static bool IsSpaceReplacingChar(char c)
		{
			return c == '\u00a0' || c == '\u202f';
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000392D4 File Offset: 0x000374D4
		internal int MatchLongestWords(string[] words, [ScopedRef] ref int maxMatchStrLen)
		{
			int result = -1;
			for (int i = 0; i < words.Length; i++)
			{
				string text = words[i];
				int length = text.Length;
				if (this.MatchSpecifiedWords(text, false, ref length) && length > maxMatchStrLen)
				{
					maxMatchStrLen = length;
					result = i;
				}
			}
			return result;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00039314 File Offset: 0x00037514
		internal unsafe int GetRepeatCount()
		{
			char c = (char)(*this.Value[this.Index]);
			int num = this.Index + 1;
			while (num < this.Length && *this.Value[num] == (ushort)c)
			{
				num++;
			}
			int result = num - this.Index;
			this.Index = num - 1;
			return result;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00039370 File Offset: 0x00037570
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe bool GetNextDigit()
		{
			int num = this.Index + 1;
			this.Index = num;
			return num < this.Length && char.IsAsciiDigit((char)(*this.Value[this.Index]));
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000393AF File Offset: 0x000375AF
		internal unsafe char GetChar()
		{
			return (char)(*this.Value[this.Index]);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000393C3 File Offset: 0x000375C3
		internal unsafe int GetDigit()
		{
			return (int)(*this.Value[this.Index] - 48);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000393DA File Offset: 0x000375DA
		internal unsafe void SkipWhiteSpaces()
		{
			while (this.Index + 1 < this.Length)
			{
				if (!char.IsWhiteSpace((char)(*this.Value[this.Index + 1])))
				{
					return;
				}
				this.Index++;
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00039418 File Offset: 0x00037618
		internal unsafe bool SkipWhiteSpaceAndRtlMarkCurrent()
		{
			if (this.Index >= this.Length)
			{
				return false;
			}
			if (!char.IsWhiteSpace(this.m_current) && this.m_current != '‏')
			{
				return true;
			}
			do
			{
				int num = this.Index + 1;
				this.Index = num;
				if (num >= this.Length)
				{
					return false;
				}
				this.m_current = (char)(*this.Value[this.Index]);
			}
			while (char.IsWhiteSpace(this.m_current) || this.m_current == '‏');
			return true;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x000394A0 File Offset: 0x000376A0
		internal unsafe void TrimTail()
		{
			int num = this.Length - 1;
			while (num >= 0 && char.IsWhiteSpace((char)(*this.Value[num])))
			{
				num--;
			}
			this.Value = this.Value.Slice(0, num + 1);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x000394EC File Offset: 0x000376EC
		internal unsafe void RemoveTrailingInQuoteSpaces()
		{
			int num = this.Length - 1;
			if (num <= 1)
			{
				return;
			}
			char c = (char)(*this.Value[num]);
			if ((c == '\'' || c == '"') && char.IsWhiteSpace((char)(*this.Value[num - 1])))
			{
				num--;
				while (num >= 1 && char.IsWhiteSpace((char)(*this.Value[num - 1])))
				{
					num--;
				}
				Span<char> span = new char[num + 1];
				*span[num] = c;
				this.Value.Slice(0, num).CopyTo(span);
				this.Value = span;
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00039594 File Offset: 0x00037794
		internal unsafe void RemoveLeadingInQuoteSpaces()
		{
			if (this.Length <= 2)
			{
				return;
			}
			int num = 0;
			char c = (char)(*this.Value[num]);
			if (c != '\'')
			{
				if (c != '"')
				{
					return;
				}
			}
			while (num + 1 < this.Length && char.IsWhiteSpace((char)(*this.Value[num + 1])))
			{
				num++;
			}
			if (num != 0)
			{
				Span<char> span = new char[this.Value.Length - num];
				*span[0] = c;
				this.Value.Slice(num + 1).CopyTo(span.Slice(1));
				this.Value = span;
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0003963C File Offset: 0x0003783C
		internal unsafe DTSubString GetSubString()
		{
			DTSubString dtsubString = default(DTSubString);
			dtsubString.index = this.Index;
			dtsubString.s = this.Value;
			while (this.Index + dtsubString.length < this.Length)
			{
				char c = (char)(*this.Value[this.Index + dtsubString.length]);
				DTSubStringType dtsubStringType = char.IsAsciiDigit(c) ? DTSubStringType.Number : DTSubStringType.Other;
				if (dtsubString.length == 0)
				{
					dtsubString.type = dtsubStringType;
				}
				else if (dtsubString.type != dtsubStringType)
				{
					break;
				}
				dtsubString.length++;
				if (dtsubStringType != DTSubStringType.Number)
				{
					break;
				}
				if (dtsubString.length > 8)
				{
					dtsubString.type = DTSubStringType.Invalid;
					return dtsubString;
				}
				int num = (int)(c - '0');
				dtsubString.value = dtsubString.value * 10 + num;
			}
			if (dtsubString.length == 0)
			{
				dtsubString.type = DTSubStringType.End;
				return dtsubString;
			}
			return dtsubString;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00039714 File Offset: 0x00037914
		internal unsafe void ConsumeSubString(DTSubString sub)
		{
			this.Index = sub.index + sub.length;
			if (this.Index < this.Length)
			{
				this.m_current = (char)(*this.Value[this.Index]);
			}
		}

		// Token: 0x0400040E RID: 1038
		internal ReadOnlySpan<char> Value;

		// Token: 0x0400040F RID: 1039
		internal int Index;

		// Token: 0x04000410 RID: 1040
		internal char m_current;

		// Token: 0x04000411 RID: 1041
		private readonly CompareInfo m_info;

		// Token: 0x04000412 RID: 1042
		private readonly bool m_checkDigitToken;
	}
}
