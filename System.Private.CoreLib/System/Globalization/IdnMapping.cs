using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x020002FB RID: 763
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class IdnMapping
	{
		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x0600377E RID: 14206 RVA: 0x000B62A0 File Offset: 0x000B44A0
		// (set) Token: 0x0600377F RID: 14207 RVA: 0x000B62A8 File Offset: 0x000B44A8
		public bool AllowUnassigned
		{
			get
			{
				return this._allowUnassigned;
			}
			set
			{
				this._allowUnassigned = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06003780 RID: 14208 RVA: 0x000B62B1 File Offset: 0x000B44B1
		// (set) Token: 0x06003781 RID: 14209 RVA: 0x000B62B9 File Offset: 0x000B44B9
		public bool UseStd3AsciiRules
		{
			get
			{
				return this._useStd3AsciiRules;
			}
			set
			{
				this._useStd3AsciiRules = value;
			}
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x000B62C2 File Offset: 0x000B44C2
		public string GetAscii(string unicode)
		{
			return this.GetAscii(unicode, 0);
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x000B62CC File Offset: 0x000B44CC
		public string GetAscii(string unicode, int index)
		{
			ArgumentNullException.ThrowIfNull(unicode, "unicode");
			return this.GetAscii(unicode, index, unicode.Length - index);
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x000B62EC File Offset: 0x000B44EC
		public unsafe string GetAscii(string unicode, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(unicode, "unicode");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (index > unicode.Length)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (index > unicode.Length - count)
			{
				throw new ArgumentOutOfRangeException("unicode", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (count == 0)
			{
				throw new ArgumentException(SR.Argument_IdnBadLabelSize, "unicode");
			}
			if (unicode[index + count - 1] == '\0')
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidCharSequence, index + count - 1), "unicode");
			}
			if (GlobalizationMode.Invariant)
			{
				return this.GetAsciiInvariant(unicode, index, count);
			}
			char* ptr;
			if (unicode == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = unicode.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetAsciiCore(unicode, ptr2 + index, count);
			}
			return this.NlsGetAsciiCore(unicode, ptr2 + index, count);
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x000B63D3 File Offset: 0x000B45D3
		public string GetUnicode(string ascii)
		{
			return this.GetUnicode(ascii, 0);
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x000B63DD File Offset: 0x000B45DD
		public string GetUnicode(string ascii, int index)
		{
			ArgumentNullException.ThrowIfNull(ascii, "ascii");
			return this.GetUnicode(ascii, index, ascii.Length - index);
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x000B63FC File Offset: 0x000B45FC
		public unsafe string GetUnicode(string ascii, int index, int count)
		{
			ArgumentNullException.ThrowIfNull(ascii, "ascii");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (index > ascii.Length)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (index > ascii.Length - count)
			{
				throw new ArgumentOutOfRangeException("ascii", SR.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (count > 0 && ascii[index + count - 1] == '\0')
			{
				throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
			}
			if (GlobalizationMode.Invariant)
			{
				return this.GetUnicodeInvariant(ascii, index, count);
			}
			char* ptr;
			if (ascii == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = ascii.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetUnicodeCore(ascii, ptr2 + index, count);
			}
			return this.NlsGetUnicodeCore(ascii, ptr2 + index, count);
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x000B64C8 File Offset: 0x000B46C8
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			IdnMapping idnMapping = obj as IdnMapping;
			return idnMapping != null && this._allowUnassigned == idnMapping._allowUnassigned && this._useStd3AsciiRules == idnMapping._useStd3AsciiRules;
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x000B64FD File Offset: 0x000B46FD
		public override int GetHashCode()
		{
			return (this._allowUnassigned ? 100 : 200) + (this._useStd3AsciiRules ? 1000 : 2000);
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x000B6525 File Offset: 0x000B4725
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static string GetStringForOutput(string originalString, char* input, int inputLength, char* output, int outputLength)
		{
			if (originalString.Length == inputLength && inputLength == outputLength && Ordinal.EqualsIgnoreCase(ref *input, ref *output, inputLength))
			{
				return originalString;
			}
			return new string(output, 0, outputLength);
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x000B654C File Offset: 0x000B474C
		private string GetAsciiInvariant(string unicode, int index, int count)
		{
			if (index > 0 || count < unicode.Length)
			{
				unicode = unicode.Substring(index, count);
			}
			if (IdnMapping.ValidateStd3AndAscii(unicode, this.UseStd3AsciiRules, true))
			{
				return unicode;
			}
			string text = unicode;
			if (text[text.Length - 1] <= '\u001f')
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidCharSequence, unicode.Length - 1), "unicode");
			}
			if (this.UseStd3AsciiRules)
			{
				IdnMapping.ValidateStd3AndAscii(unicode, true, false);
			}
			return IdnMapping.PunycodeEncode(unicode);
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x000B65CC File Offset: 0x000B47CC
		private static bool ValidateStd3AndAscii(string unicode, bool bUseStd3, bool bCheckAscii)
		{
			if (unicode.Length == 0)
			{
				throw new ArgumentException(SR.Argument_IdnBadLabelSize, "unicode");
			}
			int num = -1;
			for (int i = 0; i < unicode.Length; i++)
			{
				if (unicode[i] <= '\u001f')
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidCharSequence, i), "unicode");
				}
				if (bCheckAscii && unicode[i] >= '\u007f')
				{
					return false;
				}
				if (IdnMapping.IsDot(unicode[i]))
				{
					if (i == num + 1)
					{
						throw new ArgumentException(SR.Argument_IdnBadLabelSize, "unicode");
					}
					if (i - num > 64)
					{
						throw new ArgumentException(SR.Argument_IdnBadLabelSize, "unicode");
					}
					if (bUseStd3 && i > 0)
					{
						IdnMapping.ValidateStd3(unicode[i - 1], true);
					}
					num = i;
				}
				else if (bUseStd3)
				{
					IdnMapping.ValidateStd3(unicode[i], i == num + 1);
				}
			}
			if (num == -1 && unicode.Length > 63)
			{
				throw new ArgumentException(SR.Argument_IdnBadLabelSize, "unicode");
			}
			if (unicode.Length > 255 - ((!IdnMapping.IsDot(unicode[unicode.Length - 1])) ? 1 : 0))
			{
				throw new ArgumentException(SR.Format(SR.Argument_IdnBadNameSize, 255 - ((!IdnMapping.IsDot(unicode[unicode.Length - 1])) ? 1 : 0)), "unicode");
			}
			if (bUseStd3 && !IdnMapping.IsDot(unicode[unicode.Length - 1]))
			{
				IdnMapping.ValidateStd3(unicode[unicode.Length - 1], true);
			}
			return true;
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x000B6750 File Offset: 0x000B4950
		private static string PunycodeEncode(string unicode)
		{
			if (unicode.Length == 0)
			{
				throw new ArgumentException(SR.Argument_IdnBadLabelSize, "unicode");
			}
			StringBuilder stringBuilder = new StringBuilder(unicode.Length);
			int i = 0;
			int num = 0;
			int num2 = 0;
			while (i < unicode.Length)
			{
				i = unicode.AsSpan(num).IndexOfAny(".。．｡");
				i = ((i < 0) ? unicode.Length : (i + num));
				if (i == num)
				{
					if (i != unicode.Length)
					{
						throw new ArgumentException(SR.Argument_IdnBadLabelSize, "unicode");
					}
					break;
				}
				else
				{
					stringBuilder.Append("xn--");
					bool flag = false;
					if (CharUnicodeInfo.GetBidiCategory(unicode, num) == StrongBidiCategory.StrongRightToLeft)
					{
						flag = true;
						int num3 = i - 1;
						if (char.IsLowSurrogate(unicode, num3))
						{
							num3--;
						}
						if (CharUnicodeInfo.GetBidiCategory(unicode, num3) != StrongBidiCategory.StrongRightToLeft)
						{
							throw new ArgumentException(SR.Argument_IdnBadBidi, "unicode");
						}
					}
					int j = 0;
					for (int k = num; k < i; k++)
					{
						StrongBidiCategory bidiCategory = CharUnicodeInfo.GetBidiCategory(unicode, k);
						if (flag && bidiCategory == StrongBidiCategory.StrongLeftToRight)
						{
							throw new ArgumentException(SR.Argument_IdnBadBidi, "unicode");
						}
						if (!flag && bidiCategory == StrongBidiCategory.StrongRightToLeft)
						{
							throw new ArgumentException(SR.Argument_IdnBadBidi, "unicode");
						}
						if (IdnMapping.Basic((uint)unicode[k]))
						{
							stringBuilder.Append(IdnMapping.EncodeBasic(unicode[k]));
							j++;
						}
						else if (char.IsSurrogatePair(unicode, k))
						{
							k++;
						}
					}
					int num4 = j;
					if (num4 == i - num)
					{
						stringBuilder.Remove(num2, "xn--".Length);
					}
					else
					{
						if (unicode.AsSpan(num).StartsWith("xn--", StringComparison.OrdinalIgnoreCase))
						{
							throw new ArgumentException(SR.Argument_IdnBadPunycode, "unicode");
						}
						int num5 = 0;
						if (num4 > 0)
						{
							stringBuilder.Append('-');
						}
						int num6 = 128;
						int num7 = 0;
						int num8 = 72;
						while (j < i - num)
						{
							int num9 = 134217727;
							int num10;
							for (int l = num; l < i; l += (IdnMapping.IsSupplementary(num10) ? 2 : 1))
							{
								num10 = char.ConvertToUtf32(unicode, l);
								if (num10 >= num6 && num10 < num9)
								{
									num9 = num10;
								}
							}
							num7 += (num9 - num6) * (j - num5 + 1);
							num6 = num9;
							for (int l = num; l < i; l += (IdnMapping.IsSupplementary(num10) ? 2 : 1))
							{
								num10 = char.ConvertToUtf32(unicode, l);
								if (num10 < num6)
								{
									num7++;
								}
								if (num10 == num6)
								{
									int num11 = num7;
									int num12 = 36;
									for (;;)
									{
										int num13 = (num12 <= num8) ? 1 : ((num12 >= num8 + 26) ? 26 : (num12 - num8));
										if (num11 < num13)
										{
											break;
										}
										stringBuilder.Append(IdnMapping.EncodeDigit(num13 + (num11 - num13) % (36 - num13)));
										num11 = (num11 - num13) / (36 - num13);
										num12 += 36;
									}
									stringBuilder.Append(IdnMapping.EncodeDigit(num11));
									num8 = IdnMapping.Adapt(num7, j - num5 + 1, j == num4);
									num7 = 0;
									j++;
									if (IdnMapping.IsSupplementary(num9))
									{
										j++;
										num5++;
									}
								}
							}
							num7++;
							num6++;
						}
					}
					if (stringBuilder.Length - num2 > 63)
					{
						throw new ArgumentException(SR.Argument_IdnBadLabelSize, "unicode");
					}
					if (i != unicode.Length)
					{
						stringBuilder.Append('.');
					}
					num = i + 1;
					num2 = stringBuilder.Length;
				}
			}
			if (stringBuilder.Length > 255 - ((!IdnMapping.IsDot(unicode[unicode.Length - 1])) ? 1 : 0))
			{
				throw new ArgumentException(SR.Format(SR.Argument_IdnBadNameSize, 255 - ((!IdnMapping.IsDot(unicode[unicode.Length - 1])) ? 1 : 0)), "unicode");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x000B6B0B File Offset: 0x000B4D0B
		private static bool IsDot(char c)
		{
			return c == '.' || c == '。' || c == '．' || c == '｡';
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x000B6B2C File Offset: 0x000B4D2C
		private static bool IsSupplementary(int cTest)
		{
			return cTest >= 65536;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x000B6B39 File Offset: 0x000B4D39
		private static bool Basic(uint cp)
		{
			return cp < 128U;
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x000B6B44 File Offset: 0x000B4D44
		private static void ValidateStd3(char c, bool bNextToDot)
		{
			if (c <= ',' || c == '/' || (c >= ':' && c <= '@') || (c >= '[' && c <= '`') || (c >= '{' && c <= '\u007f') || (c == '-' && bNextToDot))
			{
				throw new ArgumentException(SR.Format(SR.Argument_IdnBadStd3, c), "c");
			}
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x000B6BA0 File Offset: 0x000B4DA0
		private string GetUnicodeInvariant(string ascii, int index, int count)
		{
			if (index > 0 || count < ascii.Length)
			{
				ascii = ascii.Substring(index, count);
			}
			string text = IdnMapping.PunycodeDecode(ascii);
			if (!ascii.Equals(this.GetAscii(text), StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentException(SR.Argument_IdnIllegalName, "ascii");
			}
			return text;
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x000B6BEC File Offset: 0x000B4DEC
		private static string PunycodeDecode(string ascii)
		{
			if (ascii.Length == 0)
			{
				throw new ArgumentException(SR.Argument_IdnBadLabelSize, "ascii");
			}
			if (ascii.Length > 255 - ((!IdnMapping.IsDot(ascii[ascii.Length - 1])) ? 1 : 0))
			{
				throw new ArgumentException(SR.Format(SR.Argument_IdnBadNameSize, 255 - ((!IdnMapping.IsDot(ascii[ascii.Length - 1])) ? 1 : 0)), "ascii");
			}
			StringBuilder stringBuilder = new StringBuilder(ascii.Length);
			int i = 0;
			int num = 0;
			int num2 = 0;
			while (i < ascii.Length)
			{
				i = ascii.IndexOf('.', num);
				if (i < 0 || i > ascii.Length)
				{
					i = ascii.Length;
				}
				if (i == num)
				{
					if (i != ascii.Length)
					{
						throw new ArgumentException(SR.Argument_IdnBadLabelSize, "ascii");
					}
					break;
				}
				else
				{
					if (i - num > 63)
					{
						throw new ArgumentException(SR.Argument_IdnBadLabelSize, "ascii");
					}
					if (ascii.Length < "xn--".Length + num || string.Compare(ascii, num, "xn--", 0, "xn--".Length, StringComparison.OrdinalIgnoreCase) != 0)
					{
						stringBuilder.Append(ascii, num, i - num);
					}
					else
					{
						num += "xn--".Length;
						int num3 = ascii.LastIndexOf('-', i - 1);
						if (num3 == i - 1)
						{
							throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
						}
						int num4;
						if (num3 <= num)
						{
							num4 = 0;
						}
						else
						{
							num4 = num3 - num;
							for (int j = num; j < num + num4; j++)
							{
								if (ascii[j] > '\u007f')
								{
									throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
								}
								stringBuilder.Append(char.IsAsciiLetterUpper(ascii[j]) ? (ascii[j] - 'A' + 'a') : ascii[j]);
							}
						}
						int k = num + ((num4 > 0) ? (num4 + 1) : 0);
						int num5 = 128;
						int num6 = 72;
						int num7 = 0;
						int num8 = 0;
						IL_3B5:
						while (k < i)
						{
							int num9 = num7;
							int num10 = 1;
							int num11 = 36;
							while (k < i)
							{
								int num12 = IdnMapping.DecodeDigit(ascii[k++]);
								if (num12 > (134217727 - num7) / num10)
								{
									throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
								}
								num7 += num12 * num10;
								int num13 = (num11 <= num6) ? 1 : ((num11 >= num6 + 26) ? 26 : (num11 - num6));
								if (num12 >= num13)
								{
									if (num10 > 134217727 / (36 - num13))
									{
										throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
									}
									num10 *= 36 - num13;
									num11 += 36;
								}
								else
								{
									num6 = IdnMapping.Adapt(num7 - num9, stringBuilder.Length - num2 - num8 + 1, num9 == 0);
									if (num7 / (stringBuilder.Length - num2 - num8 + 1) > 134217727 - num5)
									{
										throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
									}
									num5 += num7 / (stringBuilder.Length - num2 - num8 + 1);
									num7 %= stringBuilder.Length - num2 - num8 + 1;
									if (num5 < 0 || num5 > 1114111 || (num5 >= 55296 && num5 <= 57343))
									{
										throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
									}
									string value = char.ConvertFromUtf32(num5);
									int num14;
									if (num8 > 0)
									{
										int l = num7;
										num14 = num2;
										while (l > 0)
										{
											if (num14 >= stringBuilder.Length)
											{
												throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
											}
											if (char.IsSurrogate(stringBuilder[num14]))
											{
												num14++;
											}
											l--;
											num14++;
										}
									}
									else
									{
										num14 = num2 + num7;
									}
									stringBuilder.Insert(num14, value);
									if (IdnMapping.IsSupplementary(num5))
									{
										num8++;
									}
									num7++;
									goto IL_3B5;
								}
							}
							throw new ArgumentException(SR.Argument_IdnBadPunycode, "ascii");
						}
						bool flag = false;
						StrongBidiCategory bidiCategory = CharUnicodeInfo.GetBidiCategory(stringBuilder, num2);
						if (bidiCategory == StrongBidiCategory.StrongRightToLeft)
						{
							flag = true;
						}
						for (int m = num2; m < stringBuilder.Length; m++)
						{
							if (!char.IsLowSurrogate(stringBuilder[m]))
							{
								bidiCategory = CharUnicodeInfo.GetBidiCategory(stringBuilder, m);
								if ((flag && bidiCategory == StrongBidiCategory.StrongLeftToRight) || (!flag && bidiCategory == StrongBidiCategory.StrongRightToLeft))
								{
									throw new ArgumentException(SR.Argument_IdnBadBidi, "ascii");
								}
							}
						}
						if (flag && bidiCategory != StrongBidiCategory.StrongRightToLeft)
						{
							throw new ArgumentException(SR.Argument_IdnBadBidi, "ascii");
						}
					}
					if (i - num > 63)
					{
						throw new ArgumentException(SR.Argument_IdnBadLabelSize, "ascii");
					}
					if (i != ascii.Length)
					{
						stringBuilder.Append('.');
					}
					num = i + 1;
					num2 = stringBuilder.Length;
				}
			}
			bool length = stringBuilder.Length != 0;
			bool flag2 = 255 != 0;
			StringBuilder stringBuilder2 = stringBuilder;
			if (length > flag2 - !IdnMapping.IsDot(stringBuilder2[stringBuilder2.Length - 1]))
			{
				string argument_IdnBadNameSize = SR.Argument_IdnBadNameSize;
				int num15 = 255;
				StringBuilder stringBuilder3 = stringBuilder;
				throw new ArgumentException(SR.Format(argument_IdnBadNameSize, num15 - ((!IdnMapping.IsDot(stringBuilder3[stringBuilder3.Length - 1])) ? 1 : 0)), "ascii");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x000B70D7 File Offset: 0x000B52D7
		private static int DecodeDigit(char cp)
		{
			if (char.IsAsciiDigit(cp))
			{
				return (int)(cp - '0' + '\u001a');
			}
			if (char.IsAsciiLetterLower(cp))
			{
				return (int)(cp - 'a');
			}
			if (char.IsAsciiLetterUpper(cp))
			{
				return (int)(cp - 'A');
			}
			throw new ArgumentException(SR.Argument_IdnBadPunycode, "cp");
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000B7114 File Offset: 0x000B5314
		private static int Adapt(int delta, int numpoints, bool firsttime)
		{
			delta = (firsttime ? (delta / 700) : (delta / 2));
			delta += delta / numpoints;
			uint num = 0U;
			while (delta > 455)
			{
				delta /= 35;
				num += 36U;
			}
			return (int)((ulong)num + (ulong)((long)(36 * delta / (delta + 38))));
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x000B715E File Offset: 0x000B535E
		private static char EncodeBasic(char bcp)
		{
			if (char.IsAsciiLetterUpper(bcp))
			{
				bcp += ' ';
			}
			return bcp;
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x000B7170 File Offset: 0x000B5370
		private static char EncodeDigit(int d)
		{
			if (d > 25)
			{
				return (char)(d - 26 + 48);
			}
			return (char)(d + 97);
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x000B7188 File Offset: 0x000B5388
		private unsafe string IcuGetAsciiCore(string unicodeString, char* unicode, int count)
		{
			uint icuFlags = this.IcuFlags;
			IdnMapping.CheckInvalidIdnCharacters(unicode, count, icuFlags, "unicode");
			int num = (int)Math.Min((long)count * 3L + 4L, 512L);
			int num2;
			if (num < 512)
			{
				char* ptr = stackalloc char[checked(unchecked((UIntPtr)num) * 2)];
				num2 = Interop.Globalization.ToAscii(icuFlags, unicode, count, ptr, num);
				if (num2 > 0 && num2 <= num)
				{
					return IdnMapping.GetStringForOutput(unicodeString, unicode, count, ptr, num2);
				}
			}
			else
			{
				num2 = Interop.Globalization.ToAscii(icuFlags, unicode, count, null, 0);
			}
			if (num2 == 0)
			{
				throw new ArgumentException(SR.Argument_IdnIllegalName, "unicode");
			}
			char[] array = new char[num2];
			fixed (char* ptr2 = &array[0])
			{
				char* ptr3 = ptr2;
				num2 = Interop.Globalization.ToAscii(icuFlags, unicode, count, ptr3, num2);
				if (num2 == 0 || num2 > array.Length)
				{
					throw new ArgumentException(SR.Argument_IdnIllegalName, "unicode");
				}
				return IdnMapping.GetStringForOutput(unicodeString, unicode, count, ptr3, num2);
			}
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x000B7254 File Offset: 0x000B5454
		private unsafe string IcuGetUnicodeCore(string asciiString, char* ascii, int count)
		{
			uint icuFlags = this.IcuFlags;
			IdnMapping.CheckInvalidIdnCharacters(ascii, count, icuFlags, "ascii");
			if (count < 512)
			{
				char* output = stackalloc char[checked(unchecked((UIntPtr)count) * 2)];
				return this.IcuGetUnicodeCore(asciiString, ascii, count, icuFlags, output, count, true);
			}
			fixed (char* ptr = &(new char[count])[0])
			{
				char* output2 = ptr;
				return this.IcuGetUnicodeCore(asciiString, ascii, count, icuFlags, output2, count, true);
			}
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x000B72B0 File Offset: 0x000B54B0
		private unsafe string IcuGetUnicodeCore(string asciiString, char* ascii, int count, uint flags, char* output, int outputLength, bool reattempt)
		{
			int num = Interop.Globalization.ToUnicode(flags, ascii, count, output, outputLength);
			if (num == 0)
			{
				throw new ArgumentException(SR.Argument_IdnIllegalName, "ascii");
			}
			if (num <= outputLength)
			{
				return IdnMapping.GetStringForOutput(asciiString, ascii, count, output, num);
			}
			if (reattempt)
			{
				char[] array;
				char* output2;
				if ((array = new char[num]) == null || array.Length == 0)
				{
					output2 = null;
				}
				else
				{
					output2 = &array[0];
				}
				return this.IcuGetUnicodeCore(asciiString, ascii, count, flags, output2, num, false);
			}
			throw new ArgumentException(SR.Argument_IdnIllegalName, "ascii");
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600379B RID: 14235 RVA: 0x000B732E File Offset: 0x000B552E
		private uint IcuFlags
		{
			get
			{
				return ((this.AllowUnassigned > false) ? 1U : 0U) | (this.UseStd3AsciiRules ? 2U : 0U);
			}
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x000B7348 File Offset: 0x000B5548
		private unsafe static void CheckInvalidIdnCharacters(char* s, int count, uint flags, string paramName)
		{
			if ((flags & 2U) == 0U)
			{
				for (int i = 0; i < count; i++)
				{
					char c = s[i];
					if (c <= '\u001f' || c == '\u007f')
					{
						throw new ArgumentException(SR.Argument_IdnIllegalName, paramName);
					}
				}
			}
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x000B7384 File Offset: 0x000B5584
		private unsafe string NlsGetAsciiCore(string unicodeString, char* unicode, int count)
		{
			uint nlsFlags = this.NlsFlags;
			int num = Interop.Normaliz.IdnToAscii(nlsFlags, unicode, count, null, 0);
			if (num == 0)
			{
				IdnMapping.ThrowForZeroLength(true);
			}
			if (num < 512)
			{
				char* output = stackalloc char[checked(unchecked((UIntPtr)num) * 2)];
				return IdnMapping.NlsGetAsciiCore(unicodeString, unicode, count, nlsFlags, output, num);
			}
			fixed (char* ptr = &(new char[num])[0])
			{
				char* output2 = ptr;
				return IdnMapping.NlsGetAsciiCore(unicodeString, unicode, count, nlsFlags, output2, num);
			}
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x000B73E8 File Offset: 0x000B55E8
		private unsafe static string NlsGetAsciiCore(string unicodeString, char* unicode, int count, uint flags, char* output, int outputLength)
		{
			int num = Interop.Normaliz.IdnToAscii(flags, unicode, count, output, outputLength);
			if (num == 0)
			{
				IdnMapping.ThrowForZeroLength(true);
			}
			return IdnMapping.GetStringForOutput(unicodeString, unicode, count, output, num);
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x000B7418 File Offset: 0x000B5618
		private unsafe string NlsGetUnicodeCore(string asciiString, char* ascii, int count)
		{
			uint nlsFlags = this.NlsFlags;
			int num = Interop.Normaliz.IdnToUnicode(nlsFlags, ascii, count, null, 0);
			if (num == 0)
			{
				IdnMapping.ThrowForZeroLength(false);
			}
			if (num < 512)
			{
				char* output = stackalloc char[checked(unchecked((UIntPtr)num) * 2)];
				return IdnMapping.NlsGetUnicodeCore(asciiString, ascii, count, nlsFlags, output, num);
			}
			fixed (char* ptr = &(new char[num])[0])
			{
				char* output2 = ptr;
				return IdnMapping.NlsGetUnicodeCore(asciiString, ascii, count, nlsFlags, output2, num);
			}
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x000B747C File Offset: 0x000B567C
		private unsafe static string NlsGetUnicodeCore(string asciiString, char* ascii, int count, uint flags, char* output, int outputLength)
		{
			int num = Interop.Normaliz.IdnToUnicode(flags, ascii, count, output, outputLength);
			if (num == 0)
			{
				IdnMapping.ThrowForZeroLength(false);
			}
			return IdnMapping.GetStringForOutput(asciiString, ascii, count, output, num);
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060037A1 RID: 14241 RVA: 0x000B732E File Offset: 0x000B552E
		private uint NlsFlags
		{
			get
			{
				return ((this.AllowUnassigned > false) ? 1U : 0U) | (this.UseStd3AsciiRules ? 2U : 0U);
			}
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x000B74AA File Offset: 0x000B56AA
		[DoesNotReturn]
		private static void ThrowForZeroLength(bool unicode)
		{
			throw new ArgumentException((Marshal.GetLastPInvokeError() == 123) ? SR.Argument_IdnIllegalName : (unicode ? SR.Argument_InvalidCharSequenceNoIndex : SR.Argument_IdnBadPunycode), unicode ? "unicode" : "ascii");
		}

		// Token: 0x04000AE4 RID: 2788
		private bool _allowUnassigned;

		// Token: 0x04000AE5 RID: 2789
		private bool _useStd3AsciiRules;
	}
}
