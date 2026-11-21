using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace System.Buffers
{
	// Token: 0x02000397 RID: 919
	internal static class StringSearchValues
	{
		// Token: 0x06003C60 RID: 15456 RVA: 0x000C9934 File Offset: 0x000C7B34
		public unsafe static SearchValues<string> Create(ReadOnlySpan<string> values, bool ignoreCase)
		{
			if (values.Length == 0)
			{
				return new EmptySearchValues<string>();
			}
			if (values.Length == 1)
			{
				object obj = *values[0];
				ArgumentNullException.ThrowIfNull(obj, "values");
				string value = StringSearchValues.<Create>g__NormalizeIfNeeded|3_1(obj, ignoreCase);
				bool allAscii;
				bool asciiLettersOnly;
				bool flag;
				int i;
				StringSearchValues.AnalyzeValues(new ReadOnlySpan<string>(ref value), ref ignoreCase, out allAscii, out asciiLettersOnly, out flag, out i);
				return StringSearchValues.CreateForSingleValue(value, null, ignoreCase, allAscii, asciiLettersOnly);
			}
			HashSet<string> hashSet = new HashSet<string>(values.Length, ignoreCase ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal);
			ReadOnlySpan<string> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text = *readOnlySpan[i];
				ArgumentNullException.ThrowIfNull(text, "values");
				hashSet.Add(text);
			}
			if (hashSet.Contains(string.Empty))
			{
				return new SingleStringSearchValuesFallback<SearchValues.FalseConst>(string.Empty, hashSet);
			}
			Span<string> span = new string[hashSet.Count];
			int num = 0;
			foreach (string value2 in hashSet)
			{
				*span[num++] = StringSearchValues.<Create>g__NormalizeIfNeeded|3_1(value2, ignoreCase);
			}
			span.Sort((string a, string b) => a.Length.CompareTo(b.Length));
			HashSet<string> hashSet2 = null;
			AhoCorasickBuilder ahoCorasickBuilder = new AhoCorasickBuilder(span, ignoreCase, ref hashSet2);
			if (hashSet2 != null)
			{
				span = StringSearchValues.<Create>g__RemoveUnreachableValues|3_2(span, hashSet2);
			}
			SearchValues<string> result = StringSearchValues.CreateFromNormalizedValues(span, hashSet, ignoreCase, ref ahoCorasickBuilder);
			ahoCorasickBuilder.Dispose();
			return result;
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x000C9AC8 File Offset: 0x000C7CC8
		private unsafe static SearchValues<string> CreateFromNormalizedValues(ReadOnlySpan<string> values, HashSet<string> uniqueValues, bool ignoreCase, ref AhoCorasickBuilder ahoCorasickBuilder)
		{
			bool allAscii;
			bool flag;
			bool flag2;
			int minLength;
			StringSearchValues.AnalyzeValues(values, ref ignoreCase, out allAscii, out flag, out flag2, out minLength);
			if (values.Length == 1)
			{
				return StringSearchValues.CreateForSingleValue(*values[0], uniqueValues, ignoreCase, allAscii, flag);
			}
			if (Ssse3.IsSupported || false)
			{
				SearchValues<string> searchValues = StringSearchValues.TryGetTeddyAcceleratedValues(values, uniqueValues, ignoreCase, allAscii, flag, flag2, minLength);
				if (searchValues != null)
				{
					return searchValues;
				}
			}
			AhoCorasick ahoCorasick = ahoCorasickBuilder.Build();
			if (!ignoreCase)
			{
				return StringSearchValues.<CreateFromNormalizedValues>g__PickAhoCorasickImplementation|4_0<StringSearchValuesHelper.CaseSensitive>(ahoCorasick, uniqueValues);
			}
			if (flag2)
			{
				if (StringSearchValues.ContainsIncompleteSurrogatePairs(values))
				{
					return new MultiStringIgnoreCaseSearchValuesFallback(uniqueValues);
				}
				return StringSearchValues.<CreateFromNormalizedValues>g__PickAhoCorasickImplementation|4_0<StringSearchValuesHelper.CaseInsensitiveUnicode>(ahoCorasick, uniqueValues);
			}
			else
			{
				if (flag)
				{
					return StringSearchValues.<CreateFromNormalizedValues>g__PickAhoCorasickImplementation|4_0<StringSearchValuesHelper.CaseInsensitiveAsciiLetters>(ahoCorasick, uniqueValues);
				}
				return StringSearchValues.<CreateFromNormalizedValues>g__PickAhoCorasickImplementation|4_0<StringSearchValuesHelper.CaseInsensitiveAscii>(ahoCorasick, uniqueValues);
			}
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x000C9B64 File Offset: 0x000C7D64
		private unsafe static SearchValues<string> TryGetTeddyAcceleratedValues(ReadOnlySpan<string> values, HashSet<string> uniqueValues, bool ignoreCase, bool allAscii, bool asciiLettersOnly, bool nonAsciiAffectedByCaseConversion, int minLength)
		{
			if (minLength == 1)
			{
				return null;
			}
			if (values.Length > 80)
			{
				return null;
			}
			int num = (minLength == 2) ? 2 : 3;
			ReadOnlySpan<string> readOnlySpan;
			if (Ssse3.IsSupported)
			{
				readOnlySpan = values;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					if ((*readOnlySpan[i]).AsSpan(0, num).Contains('\0'))
					{
						return null;
					}
				}
			}
			if (!allAscii)
			{
				readOnlySpan = values;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					if (!Ascii.IsValid((*readOnlySpan[i]).AsSpan(0, num)))
					{
						return null;
					}
				}
			}
			if (!ignoreCase)
			{
				return StringSearchValues.PickTeddyImplementation<StringSearchValuesHelper.CaseSensitive, StringSearchValuesHelper.CaseSensitive>(values, uniqueValues, num);
			}
			if (asciiLettersOnly)
			{
				return StringSearchValues.PickTeddyImplementation<StringSearchValuesHelper.CaseInsensitiveAsciiLetters, StringSearchValuesHelper.CaseInsensitiveAsciiLetters>(values, uniqueValues, num);
			}
			bool flag = true;
			bool flag2 = true;
			readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				ReadOnlySpan<char> span = (*readOnlySpan[i]).AsSpan(0, num);
				flag = (flag && !span.ContainsAnyExcept(StringSearchValues.s_asciiLetters));
				flag2 = (flag2 && !span.ContainsAny(StringSearchValues.s_asciiLetters));
			}
			string[] array;
			if (!flag2 && values.Length < 8 && StringSearchValues.TryGenerateAllCasePermutationsForPrefixes(values, num, 8, out array))
			{
				flag2 = true;
				values = array;
			}
			if (flag2)
			{
				if (!nonAsciiAffectedByCaseConversion)
				{
					return StringSearchValues.PickTeddyImplementation<StringSearchValuesHelper.CaseSensitive, StringSearchValuesHelper.CaseInsensitiveAscii>(values, uniqueValues, num);
				}
				return StringSearchValues.PickTeddyImplementation<StringSearchValuesHelper.CaseSensitive, StringSearchValuesHelper.CaseInsensitiveUnicode>(values, uniqueValues, num);
			}
			else if (nonAsciiAffectedByCaseConversion)
			{
				if (!flag)
				{
					return StringSearchValues.PickTeddyImplementation<StringSearchValuesHelper.CaseInsensitiveAscii, StringSearchValuesHelper.CaseInsensitiveUnicode>(values, uniqueValues, num);
				}
				return StringSearchValues.PickTeddyImplementation<StringSearchValuesHelper.CaseInsensitiveAsciiLetters, StringSearchValuesHelper.CaseInsensitiveUnicode>(values, uniqueValues, num);
			}
			else
			{
				if (!flag)
				{
					return StringSearchValues.PickTeddyImplementation<StringSearchValuesHelper.CaseInsensitiveAscii, StringSearchValuesHelper.CaseInsensitiveAscii>(values, uniqueValues, num);
				}
				return StringSearchValues.PickTeddyImplementation<StringSearchValuesHelper.CaseInsensitiveAsciiLetters, StringSearchValuesHelper.CaseInsensitiveAscii>(values, uniqueValues, num);
			}
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x000C9CE0 File Offset: 0x000C7EE0
		private static SearchValues<string> PickTeddyImplementation<TStartCaseSensitivity, TCaseSensitivity>(ReadOnlySpan<string> values, HashSet<string> uniqueValues, int n) where TStartCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
		{
			if (values.Length > 8)
			{
				string[][] buckets = TeddyBucketizer.Bucketize(values, 8, n);
				if (n != 2)
				{
					return new AsciiStringSearchValuesTeddyBucketizedN3<TStartCaseSensitivity, TCaseSensitivity>(buckets, values, uniqueValues);
				}
				return new AsciiStringSearchValuesTeddyBucketizedN2<TStartCaseSensitivity, TCaseSensitivity>(buckets, values, uniqueValues);
			}
			else
			{
				if (n != 2)
				{
					return new AsciiStringSearchValuesTeddyNonBucketizedN3<TStartCaseSensitivity, TCaseSensitivity>(values, uniqueValues);
				}
				return new AsciiStringSearchValuesTeddyNonBucketizedN2<TStartCaseSensitivity, TCaseSensitivity>(values, uniqueValues);
			}
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x000C9D2C File Offset: 0x000C7F2C
		private unsafe static bool TryGenerateAllCasePermutationsForPrefixes(ReadOnlySpan<string> values, int n, int maxValues, [NotNullWhen(true)] out string[] newValues)
		{
			int num = 0;
			ReadOnlySpan<string> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text = *readOnlySpan[i];
				int num2 = 1;
				ReadOnlySpan<char> readOnlySpan2 = text.AsSpan(0, n);
				for (int j = 0; j < readOnlySpan2.Length; j++)
				{
					if (char.IsAsciiLetter((char)(*readOnlySpan2[j])))
					{
						num2 *= 2;
					}
				}
				num += num2;
			}
			if (num > maxValues)
			{
				newValues = null;
				return false;
			}
			newValues = new string[num];
			num = 0;
			readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text2 = *readOnlySpan[i];
				int num3 = num;
				newValues[num++] = text2;
				for (int k = 0; k < n; k++)
				{
					char c = text2[k];
					if (char.IsAsciiLetter(c))
					{
						Span<string> span = newValues.AsSpan(num3, num - num3);
						for (int j = 0; j < span.Length; j++)
						{
							string text3 = *span[j];
							string[] array = newValues;
							int num4 = num++;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 3);
							defaultInterpolatedStringHandler.AppendFormatted(text3.AsSpan(0, k));
							defaultInterpolatedStringHandler.AppendFormatted<char>(c ^ ' ');
							defaultInterpolatedStringHandler.AppendFormatted(text3.AsSpan(k + 1));
							array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x000C9E7C File Offset: 0x000C807C
		private static SearchValues<string> CreateForSingleValue(string value, HashSet<string> uniqueValues, bool ignoreCase, bool allAscii, bool asciiLettersOnly)
		{
			int maxValue = int.MaxValue;
			if (Vector128.IsHardwareAccelerated && value.Length > 1 && value.Length <= maxValue)
			{
				int length = value.Length;
				SearchValues<string> searchValues;
				if (length >= 4)
				{
					if (length >= 8)
					{
						searchValues = StringSearchValues.TryCreateSingleValuesThreeChars<StringSearchValuesHelper.ValueLength8OrLongerOrUnknown>(value, uniqueValues, ignoreCase, allAscii, asciiLettersOnly);
					}
					else
					{
						searchValues = StringSearchValues.TryCreateSingleValuesThreeChars<StringSearchValuesHelper.ValueLength4To7>(value, uniqueValues, ignoreCase, allAscii, asciiLettersOnly);
					}
				}
				else
				{
					searchValues = StringSearchValues.TryCreateSingleValuesThreeChars<StringSearchValuesHelper.ValueLengthLessThan4>(value, uniqueValues, ignoreCase, allAscii, asciiLettersOnly);
				}
				SearchValues<string> searchValues2 = searchValues;
				if (searchValues2 != null)
				{
					return searchValues2;
				}
			}
			if (uniqueValues == null)
			{
				uniqueValues = new HashSet<string>(1, ignoreCase ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal)
				{
					value
				};
			}
			if (!ignoreCase)
			{
				return new SingleStringSearchValuesFallback<SearchValues.FalseConst>(value, uniqueValues);
			}
			return new SingleStringSearchValuesFallback<SearchValues.TrueConst>(value, uniqueValues);
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x000C9F24 File Offset: 0x000C8124
		private static SearchValues<string> TryCreateSingleValuesThreeChars<TValueLength>(string value, HashSet<string> uniqueValues, bool ignoreCase, bool allAscii, bool asciiLettersOnly) where TValueLength : struct, StringSearchValuesHelper.IValueLength
		{
			if (!ignoreCase)
			{
				return new SingleStringSearchValuesThreeChars<TValueLength, StringSearchValuesHelper.CaseSensitive>(uniqueValues, value);
			}
			if (asciiLettersOnly)
			{
				return new SingleStringSearchValuesThreeChars<TValueLength, StringSearchValuesHelper.CaseInsensitiveAsciiLetters>(uniqueValues, value);
			}
			if (allAscii)
			{
				return new SingleStringSearchValuesThreeChars<TValueLength, StringSearchValuesHelper.CaseInsensitiveAscii>(uniqueValues, value);
			}
			if (char.IsAscii(value[0]) && value.AsSpan(1).ContainsAnyInRange('\0', '\u007f'))
			{
				return new SingleStringSearchValuesThreeChars<TValueLength, StringSearchValuesHelper.CaseInsensitiveUnicode>(uniqueValues, value);
			}
			return null;
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x000C9F7C File Offset: 0x000C817C
		private unsafe static void AnalyzeValues(ReadOnlySpan<string> values, ref bool ignoreCase, out bool allAscii, out bool asciiLettersOnly, out bool nonAsciiAffectedByCaseConversion, out int minLength)
		{
			allAscii = true;
			asciiLettersOnly = true;
			minLength = int.MaxValue;
			ReadOnlySpan<string> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text = *readOnlySpan[i];
				allAscii = (allAscii && Ascii.IsValid(text));
				asciiLettersOnly = (asciiLettersOnly && !text.AsSpan().ContainsAnyExcept(StringSearchValues.s_asciiLetters));
				minLength = Math.Min(minLength, text.Length);
			}
			nonAsciiAffectedByCaseConversion = (ignoreCase && !allAscii);
			if (ignoreCase && !nonAsciiAffectedByCaseConversion && !asciiLettersOnly)
			{
				ignoreCase = false;
				readOnlySpan = values;
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					if ((*readOnlySpan[i]).AsSpan().ContainsAny(StringSearchValues.s_asciiLetters))
					{
						ignoreCase = true;
						return;
					}
				}
			}
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x000CA048 File Offset: 0x000C8248
		private unsafe static bool ContainsIncompleteSurrogatePairs(ReadOnlySpan<string> values)
		{
			ReadOnlySpan<string> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text = *readOnlySpan[i];
				int j = text.AsSpan().IndexOfAnyInRange('\ud800', '\udfff');
				if (j >= 0)
				{
					while (j < text.Length)
					{
						if (char.IsHighSurrogate(text[j]))
						{
							if (j + 1 >= text.Length || !char.IsLowSurrogate(text[j + 1]))
							{
								return true;
							}
							j++;
						}
						else if (char.IsLowSurrogate(text[j]))
						{
							return true;
						}
						j++;
					}
				}
			}
			return false;
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x000CA10C File Offset: 0x000C830C
		[CompilerGenerated]
		internal static string <Create>g__NormalizeIfNeeded|3_1(string value, bool ignoreCase)
		{
			if (ignoreCase && value.AsSpan().ContainsAnyExcept(StringSearchValues.s_allAsciiExceptLowercase))
			{
				string text = string.FastAllocateString(value.Length);
				Ordinal.ToUpperOrdinal(value, new Span<char>(text.GetRawStringData(), text.Length));
				value = text;
			}
			return value;
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x000CA15C File Offset: 0x000C835C
		[CompilerGenerated]
		internal unsafe static Span<string> <Create>g__RemoveUnreachableValues|3_2(Span<string> values, HashSet<string> unreachableValues)
		{
			int length = 0;
			Span<string> span = values;
			for (int i = 0; i < span.Length; i++)
			{
				string text = *span[i];
				if (!unreachableValues.Contains(text))
				{
					*values[length++] = text;
				}
			}
			return values.Slice(0, length);
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x000CA1A9 File Offset: 0x000C83A9
		[CompilerGenerated]
		internal static SearchValues<string> <CreateFromNormalizedValues>g__PickAhoCorasickImplementation|4_0<TCaseSensitivity>(AhoCorasick ahoCorasick, HashSet<string> uniqueValues) where TCaseSensitivity : struct, StringSearchValuesHelper.ICaseSensitivity
		{
			if (!ahoCorasick.ShouldUseAsciiFastScan)
			{
				return new StringSearchValuesAhoCorasick<TCaseSensitivity, AhoCorasick.NoFastScan>(ahoCorasick, uniqueValues);
			}
			return new StringSearchValuesAhoCorasick<TCaseSensitivity, AhoCorasick.IndexOfAnyAsciiFastScan>(ahoCorasick, uniqueValues);
		}

		// Token: 0x04000CC0 RID: 3264
		private static readonly SearchValues<char> s_asciiLetters = SearchValues.Create("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");

		// Token: 0x04000CC1 RID: 3265
		private static readonly SearchValues<char> s_allAsciiExceptLowercase = SearchValues.Create("\0\u0001\u0002\u0003\u0004\u0005\u0006\a\b\t\n\v\f\r\u000e\u000f\u0010\u0011\u0012\u0013\u0014\u0015\u0016\u0017\u0018\u0019\u001a\u001b\u001c\u001d\u001e\u001f !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`{|}~\u007f");
	}
}
