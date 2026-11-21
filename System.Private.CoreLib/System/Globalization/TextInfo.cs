using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Unicode;

namespace System.Globalization
{
	// Token: 0x02000313 RID: 787
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class TextInfo : ICloneable, IDeserializationCallback
	{
		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x000BD080 File Offset: 0x000BB280
		private bool HasEmptyCultureName
		{
			get
			{
				return this._cultureName.Length == 0;
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x000BD090 File Offset: 0x000BB290
		internal TextInfo(CultureData cultureData)
		{
			this._cultureData = cultureData;
			this._cultureName = this._cultureData.CultureName;
			this._textInfoName = this._cultureData.TextInfoName;
			if (GlobalizationMode.UseNls)
			{
				this._sortHandle = CompareInfo.NlsGetSortHandle(this._textInfoName);
			}
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x000BD0E4 File Offset: 0x000BB2E4
		private TextInfo(CultureData cultureData, bool readOnly) : this(cultureData)
		{
			this.SetReadOnlyState(readOnly);
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x0000ACEC File Offset: 0x00008EEC
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x000BD0F4 File Offset: 0x000BB2F4
		public int ANSICodePage
		{
			get
			{
				return this._cultureData.ANSICodePage;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x000BD101 File Offset: 0x000BB301
		public int OEMCodePage
		{
			get
			{
				return this._cultureData.OEMCodePage;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x000BD10E File Offset: 0x000BB30E
		public int MacCodePage
		{
			get
			{
				return this._cultureData.MacCodePage;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x000BD11B File Offset: 0x000BB31B
		public int EBCDICCodePage
		{
			get
			{
				return this._cultureData.EBCDICCodePage;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06003953 RID: 14675 RVA: 0x000BD128 File Offset: 0x000BB328
		public int LCID
		{
			get
			{
				return CultureInfo.GetCultureInfo(this._textInfoName).LCID;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x000BD13A File Offset: 0x000BB33A
		public string CultureName
		{
			get
			{
				return this._textInfoName;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x000BD142 File Offset: 0x000BB342
		public bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x000BD14A File Offset: 0x000BB34A
		public object Clone()
		{
			object obj = base.MemberwiseClone();
			((TextInfo)obj).SetReadOnlyState(false);
			return obj;
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x000BD15E File Offset: 0x000BB35E
		public static TextInfo ReadOnly(TextInfo textInfo)
		{
			ArgumentNullException.ThrowIfNull(textInfo, "textInfo");
			if (textInfo.IsReadOnly)
			{
				return textInfo;
			}
			TextInfo textInfo2 = (TextInfo)textInfo.MemberwiseClone();
			textInfo2.SetReadOnlyState(true);
			return textInfo2;
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x000BD187 File Offset: 0x000BB387
		private void VerifyWritable()
		{
			if (this._isReadOnly)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
			}
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x000BD19C File Offset: 0x000BB39C
		internal void SetReadOnlyState(bool readOnly)
		{
			this._isReadOnly = readOnly;
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x000BD1A8 File Offset: 0x000BB3A8
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x000BD1D3 File Offset: 0x000BB3D3
		public string ListSeparator
		{
			get
			{
				string result;
				if ((result = this._listSeparator) == null)
				{
					result = (this._listSeparator = this._cultureData.ListSeparator);
				}
				return result;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this.VerifyWritable();
				this._listSeparator = value;
			}
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x000BD1ED File Offset: 0x000BB3ED
		public char ToLower(char c)
		{
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.ToLower(c);
			}
			if (UnicodeUtility.IsAsciiCodePoint((uint)c) && this.IsAsciiCasingSameAsInvariant)
			{
				return TextInfo.ToLowerAsciiInvariant(c);
			}
			return this.ChangeCase(c, false);
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x000BD21C File Offset: 0x000BB41C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToLowerInvariant(char c)
		{
			if (UnicodeUtility.IsAsciiCodePoint((uint)c))
			{
				return TextInfo.ToLowerAsciiInvariant(c);
			}
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.ToLower(c);
			}
			return TextInfo.Invariant.ChangeCase(c, false);
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x000BD247 File Offset: 0x000BB447
		public string ToLower(string str)
		{
			ArgumentNullException.ThrowIfNull(str, "str");
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.ToLower(str);
			}
			return this.ChangeCaseCommon<TextInfo.ToLowerConversion>(str);
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x000BD26C File Offset: 0x000BB46C
		private unsafe char ChangeCase(char c, bool toUpper)
		{
			char result = '\0';
			this.ChangeCaseCore(&c, 1, &result, 1, toUpper);
			return result;
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x000BD28B File Offset: 0x000BB48B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToUpperOrdinal(char c)
		{
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.ToUpper(c);
			}
			if (!GlobalizationMode.UseNls)
			{
				return OrdinalCasing.ToUpper(c);
			}
			if (!char.IsAscii(c))
			{
				return TextInfo.Invariant.ChangeCase(c, true);
			}
			return TextInfo.ToUpperAsciiInvariant(c);
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x000BD2C4 File Offset: 0x000BB4C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ChangeCaseToLower(ReadOnlySpan<char> source, Span<char> destination)
		{
			this.ChangeCaseCommon<TextInfo.ToLowerConversion>(source, destination);
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x000BD2CE File Offset: 0x000BB4CE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ChangeCaseToUpper(ReadOnlySpan<char> source, Span<char> destination)
		{
			this.ChangeCaseCommon<TextInfo.ToUpperConversion>(source, destination);
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x000BD2D8 File Offset: 0x000BB4D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe void ChangeCaseCommon<TConversion>(ReadOnlySpan<char> source, Span<char> destination) where TConversion : struct
		{
			if (source.IsEmpty)
			{
				return;
			}
			bool flag = typeof(TConversion) == typeof(TextInfo.ToUpperConversion);
			int num = 0;
			if (this.IsAsciiCasingSameAsInvariant && (flag ? Ascii.ToUpper(source, destination, out num) : Ascii.ToLower(source, destination, out num)) != OperationStatus.InvalidData)
			{
				return;
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(destination))
				{
					char* ptr2 = reference2;
					this.ChangeCaseCore(ptr + num, source.Length - num, ptr2 + num, destination.Length - num, flag);
				}
			}
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x000BD374 File Offset: 0x000BB574
		private unsafe string ChangeCaseCommon<TConversion>(string source) where TConversion : struct
		{
			bool flag = typeof(TConversion) == typeof(TextInfo.ToUpperConversion);
			if (source.Length == 0)
			{
				return string.Empty;
			}
			char* ptr;
			if (source == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = source.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			if (this.IsAsciiCasingSameAsInvariant)
			{
				if (source.Length >= 2)
				{
					UIntPtr uintPtr2 = (UIntPtr)(source.Length - 2);
					do
					{
						uint value = Unsafe.ReadUnaligned<uint>((void*)(ptr2 + (ulong)uintPtr * 2UL / 2UL));
						if (!Utf16Utility.AllCharsInUInt32AreAscii(value))
						{
							goto IL_121;
						}
						if (flag ? Utf16Utility.UInt32ContainsAnyLowercaseAsciiChar(value) : Utf16Utility.UInt32ContainsAnyUppercaseAsciiChar(value))
						{
							goto IL_D1;
						}
						uintPtr += (UIntPtr)((IntPtr)2);
					}
					while (uintPtr <= uintPtr2);
				}
				if ((source.Length & 1) != 0)
				{
					uint num = (uint)ptr2[(ulong)uintPtr * 2UL / 2UL];
					if (num > 127U)
					{
						goto IL_121;
					}
					if (flag ? (num - 97U <= 25U) : (num - 65U <= 25U))
					{
						goto IL_D1;
					}
				}
				return source;
				IL_D1:
				string text = string.FastAllocateString(source.Length);
				Span<char> destination = new Span<char>(text.GetRawStringData(), text.Length);
				source.AsSpan(0, (int)uintPtr).CopyTo(destination);
				this.ChangeCaseCommon<TConversion>(source.AsSpan((int)uintPtr), destination.Slice((int)uintPtr));
				return text;
			}
			IL_121:
			string text2 = string.FastAllocateString(source.Length);
			if (uintPtr > (UIntPtr)((IntPtr)0))
			{
				Span<char> destination2 = new Span<char>(text2.GetRawStringData(), text2.Length);
				source.AsSpan(0, (int)uintPtr).CopyTo(destination2);
			}
			char* ptr3;
			if (text2 == null)
			{
				ptr3 = null;
			}
			else
			{
				fixed (char* ptr4 = text2.GetPinnableReference())
				{
					ptr3 = ptr4;
				}
			}
			char* ptr5 = ptr3;
			this.ChangeCaseCore(ptr2 + (ulong)uintPtr * 2UL / 2UL, source.Length - (int)uintPtr, ptr5 + (ulong)uintPtr * 2UL / 2UL, text2.Length - (int)uintPtr, flag);
			char* ptr4 = null;
			return text2;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x000BD524 File Offset: 0x000BB724
		internal unsafe static string ToLowerAsciiInvariant(string s)
		{
			if (s.Length == 0)
			{
				return string.Empty;
			}
			int i = s.AsSpan().IndexOfAnyInRange('A', 'Z');
			if (i < 0)
			{
				return s;
			}
			char* ptr;
			if (s == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = s.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			string text = string.FastAllocateString(s.Length);
			char* ptr3;
			if (text == null)
			{
				ptr3 = null;
			}
			else
			{
				fixed (char* ptr4 = text.GetPinnableReference())
				{
					ptr3 = ptr4;
				}
			}
			char* ptr5 = ptr3;
			s.AsSpan(0, i).CopyTo(new Span<char>((void*)ptr5, text.Length));
			ptr5[i] = (ptr2[i] | ' ');
			for (i++; i < s.Length; i++)
			{
				ptr5[i] = TextInfo.ToLowerAsciiInvariant(ptr2[i]);
			}
			char* ptr4 = null;
			return text;
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x000BD5E3 File Offset: 0x000BB7E3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static char ToLowerAsciiInvariant(char c)
		{
			if (char.IsAsciiLetterUpper(c))
			{
				c = (char)((byte)(c | ' '));
			}
			return c;
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x000BD5F5 File Offset: 0x000BB7F5
		public char ToUpper(char c)
		{
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.ToUpper(c);
			}
			if (UnicodeUtility.IsAsciiCodePoint((uint)c) && this.IsAsciiCasingSameAsInvariant)
			{
				return TextInfo.ToUpperAsciiInvariant(c);
			}
			return this.ChangeCase(c, true);
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x000BD624 File Offset: 0x000BB824
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToUpperInvariant(char c)
		{
			if (UnicodeUtility.IsAsciiCodePoint((uint)c))
			{
				return TextInfo.ToUpperAsciiInvariant(c);
			}
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.ToUpper(c);
			}
			return TextInfo.Invariant.ChangeCase(c, true);
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x000BD64F File Offset: 0x000BB84F
		public string ToUpper(string str)
		{
			ArgumentNullException.ThrowIfNull(str, "str");
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.ToUpper(str);
			}
			return this.ChangeCaseCommon<TextInfo.ToUpperConversion>(str);
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x000BD671 File Offset: 0x000BB871
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ToUpperAsciiInvariant(char c)
		{
			if (char.IsAsciiLetterLower(c))
			{
				c &= '_';
			}
			return c;
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x000BD683 File Offset: 0x000BB883
		private bool IsAsciiCasingSameAsInvariant
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (this._isAsciiCasingSameAsInvariant == TextInfo.Tristate.NotInitialized)
				{
					this.PopulateIsAsciiCasingSameAsInvariant();
				}
				return this._isAsciiCasingSameAsInvariant == TextInfo.Tristate.True;
			}
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x000BD69C File Offset: 0x000BB89C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PopulateIsAsciiCasingSameAsInvariant()
		{
			this._isAsciiCasingSameAsInvariant = ((CultureInfo.GetCultureInfo(this._textInfoName).CompareInfo.Compare("abcdefghijklmnopqrstuvwxyz", "ABCDEFGHIJKLMNOPQRSTUVWXYZ", CompareOptions.IgnoreCase) == 0) ? TextInfo.Tristate.True : TextInfo.Tristate.False);
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x000BD6DA File Offset: 0x000BB8DA
		public bool IsRightToLeft
		{
			get
			{
				return this._cultureData.IsRightToLeft;
			}
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			TextInfo textInfo = obj as TextInfo;
			return textInfo != null && this.CultureName.Equals(textInfo.CultureName);
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x000BD712 File Offset: 0x000BB912
		public override int GetHashCode()
		{
			return this.CultureName.GetHashCode();
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x000BD71F File Offset: 0x000BB91F
		public override string ToString()
		{
			return "TextInfo - " + this._cultureData.CultureName;
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x000BD738 File Offset: 0x000BB938
		public string ToTitleCase(string str)
		{
			ArgumentNullException.ThrowIfNull(str, "str");
			if (str.Length == 0)
			{
				return str;
			}
			StringBuilder stringBuilder = new StringBuilder();
			string text = null;
			bool flag = this.CultureName.StartsWith("nl-", StringComparison.OrdinalIgnoreCase);
			for (int i = 0; i < str.Length; i++)
			{
				int num;
				UnicodeCategory unicodeCategoryInternal = CharUnicodeInfo.GetUnicodeCategoryInternal(str, i, out num);
				if (char.CheckLetter(unicodeCategoryInternal))
				{
					if (flag && i < str.Length - 1 && (str[i] == 'i' || str[i] == 'I') && (str[i + 1] == 'j' || str[i + 1] == 'J'))
					{
						stringBuilder.Append("IJ");
						i += 2;
					}
					else
					{
						i = this.AddTitlecaseLetter(ref stringBuilder, ref str, i, num) + 1;
					}
					int num2 = i;
					bool flag2 = unicodeCategoryInternal == UnicodeCategory.LowercaseLetter;
					while (i < str.Length)
					{
						unicodeCategoryInternal = CharUnicodeInfo.GetUnicodeCategoryInternal(str, i, out num);
						if (TextInfo.IsLetterCategory(unicodeCategoryInternal))
						{
							if (unicodeCategoryInternal == UnicodeCategory.LowercaseLetter)
							{
								flag2 = true;
							}
							i += num;
						}
						else if (str[i] == '\'')
						{
							i++;
							if (flag2)
							{
								if (text == null)
								{
									text = this.ToLower(str);
								}
								stringBuilder.Append(text, num2, i - num2);
							}
							else
							{
								stringBuilder.Append(str, num2, i - num2);
							}
							num2 = i;
							flag2 = true;
						}
						else
						{
							if (TextInfo.IsWordSeparator(unicodeCategoryInternal))
							{
								break;
							}
							i += num;
						}
					}
					int num3 = i - num2;
					if (num3 > 0)
					{
						if (flag2)
						{
							if (text == null)
							{
								text = this.ToLower(str);
							}
							stringBuilder.Append(text, num2, num3);
						}
						else
						{
							stringBuilder.Append(str, num2, num3);
						}
					}
					if (i < str.Length)
					{
						i = TextInfo.AddNonLetter(ref stringBuilder, ref str, i, num);
					}
				}
				else
				{
					i = TextInfo.AddNonLetter(ref stringBuilder, ref str, i, num);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x000BD8EB File Offset: 0x000BBAEB
		private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
		{
			if (charLen == 2)
			{
				result.Append(input[inputIndex++]);
				result.Append(input[inputIndex]);
			}
			else
			{
				result.Append(input[inputIndex]);
			}
			return inputIndex;
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x000BD92C File Offset: 0x000BBB2C
		private unsafe int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
		{
			if (charLen == 2)
			{
				ReadOnlySpan<char> source = input.AsSpan(inputIndex, 2);
				if (GlobalizationMode.Invariant)
				{
					char value;
					char value2;
					SurrogateCasing.ToUpper((char)(*source[0]), (char)(*source[1]), out value, out value2);
					result.Append(value);
					result.Append(value2);
				}
				else
				{
					Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)4], 2);
					this.ChangeCaseToUpper(source, span);
					result.Append(span);
				}
				inputIndex++;
			}
			else
			{
				char c = input[inputIndex];
				switch (c)
				{
				case 'Ǆ':
				case 'ǅ':
				case 'ǆ':
					result.Append('ǅ');
					break;
				case 'Ǉ':
				case 'ǈ':
				case 'ǉ':
					result.Append('ǈ');
					break;
				case 'Ǌ':
				case 'ǋ':
				case 'ǌ':
					result.Append('ǋ');
					break;
				default:
					switch (c)
					{
					case 'Ǳ':
					case 'ǲ':
					case 'ǳ':
						result.Append('ǲ');
						break;
					default:
						result.Append(GlobalizationMode.Invariant ? InvariantModeCasing.ToUpper(input[inputIndex]) : this.ToUpper(input[inputIndex]));
						break;
					}
					break;
				}
			}
			return inputIndex;
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x000BDA68 File Offset: 0x000BBC68
		private unsafe void ChangeCaseCore(char* src, int srcLen, char* dstBuffer, int dstBufferCapacity, bool bToUpper)
		{
			if (GlobalizationMode.UseNls)
			{
				this.NlsChangeCase(src, srcLen, dstBuffer, dstBufferCapacity, bToUpper);
				return;
			}
			this.IcuChangeCase(src, srcLen, dstBuffer, dstBufferCapacity, bToUpper);
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x000BDA8C File Offset: 0x000BBC8C
		private static bool IsWordSeparator(UnicodeCategory category)
		{
			return (536672256 & 1 << (int)category) != 0;
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x000BDA9D File Offset: 0x000BBC9D
		private static bool IsLetterCategory(UnicodeCategory uc)
		{
			return uc == UnicodeCategory.UppercaseLetter || uc == UnicodeCategory.LowercaseLetter || uc == UnicodeCategory.TitlecaseLetter || uc == UnicodeCategory.ModifierLetter || uc == UnicodeCategory.OtherLetter;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x000BDAB4 File Offset: 0x000BBCB4
		private static bool NeedsTurkishCasing(string localeName)
		{
			return CultureInfo.GetCultureInfo(localeName).CompareInfo.Compare("ı", "I", CompareOptions.IgnoreCase) == 0;
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x000BDAD4 File Offset: 0x000BBCD4
		internal unsafe void IcuChangeCase(char* src, int srcLen, char* dstBuffer, int dstBufferCapacity, bool bToUpper)
		{
			if (this.HasEmptyCultureName)
			{
				Interop.Globalization.ChangeCaseInvariant(src, srcLen, dstBuffer, dstBufferCapacity, bToUpper);
				return;
			}
			if (this._needsTurkishCasing == TextInfo.Tristate.NotInitialized)
			{
				this._needsTurkishCasing = (TextInfo.NeedsTurkishCasing(this._textInfoName) ? TextInfo.Tristate.True : TextInfo.Tristate.False);
			}
			if (this._needsTurkishCasing == TextInfo.Tristate.True)
			{
				Interop.Globalization.ChangeCaseTurkish(src, srcLen, dstBuffer, dstBufferCapacity, bToUpper);
				return;
			}
			Interop.Globalization.ChangeCase(src, srcLen, dstBuffer, dstBufferCapacity, bToUpper);
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x000BDB38 File Offset: 0x000BBD38
		private unsafe void NlsChangeCase(char* pSource, int pSourceLen, char* pResult, int pResultLen, bool toUpper)
		{
			uint num = TextInfo.IsInvariantLocale(this._textInfoName) ? 0U : 16777216U;
			if (Interop.Kernel32.LCMapStringEx((this._sortHandle != IntPtr.Zero) ? null : this._textInfoName, num | (toUpper ? 512U : 256U), pSource, pSourceLen, (void*)pResult, pSourceLen, null, null, this._sortHandle) == 0)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ReadOnly);
			}
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x000BDBA3 File Offset: 0x000BBDA3
		private static bool IsInvariantLocale(string localeName)
		{
			return localeName == "";
		}

		// Token: 0x04000B60 RID: 2912
		private string _listSeparator;

		// Token: 0x04000B61 RID: 2913
		private bool _isReadOnly;

		// Token: 0x04000B62 RID: 2914
		private readonly string _cultureName;

		// Token: 0x04000B63 RID: 2915
		private readonly CultureData _cultureData;

		// Token: 0x04000B64 RID: 2916
		private readonly string _textInfoName;

		// Token: 0x04000B65 RID: 2917
		private TextInfo.Tristate _isAsciiCasingSameAsInvariant;

		// Token: 0x04000B66 RID: 2918
		internal static readonly TextInfo Invariant = new TextInfo(CultureData.Invariant, true)
		{
			_isAsciiCasingSameAsInvariant = TextInfo.Tristate.True
		};

		// Token: 0x04000B67 RID: 2919
		private TextInfo.Tristate _needsTurkishCasing;

		// Token: 0x04000B68 RID: 2920
		private IntPtr _sortHandle;

		// Token: 0x02000314 RID: 788
		private enum Tristate : byte
		{
			// Token: 0x04000B6A RID: 2922
			NotInitialized,
			// Token: 0x04000B6B RID: 2923
			False,
			// Token: 0x04000B6C RID: 2924
			True
		}

		// Token: 0x02000315 RID: 789
		private readonly struct ToUpperConversion
		{
		}

		// Token: 0x02000316 RID: 790
		private readonly struct ToLowerConversion
		{
		}
	}
}
