using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Unicode;

namespace System.Globalization
{
	// Token: 0x020002CF RID: 719
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class CompareInfo : IDeserializationCallback
	{
		// Token: 0x06003473 RID: 13427 RVA: 0x000A78F7 File Offset: 0x000A5AF7
		internal CompareInfo(CultureInfo culture)
		{
			this.m_name = culture._name;
			this.InitSort(culture);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x000A7912 File Offset: 0x000A5B12
		public static CompareInfo GetCompareInfo(int culture, Assembly assembly)
		{
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			if (assembly != typeof(object).Module.Assembly)
			{
				throw new ArgumentException(SR.Argument_OnlyMscorlib, "assembly");
			}
			return CompareInfo.GetCompareInfo(culture);
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x000A7954 File Offset: 0x000A5B54
		public static CompareInfo GetCompareInfo(string name, Assembly assembly)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			if (assembly != typeof(object).Module.Assembly)
			{
				throw new ArgumentException(SR.Argument_OnlyMscorlib, "assembly");
			}
			return CompareInfo.GetCompareInfo(name);
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x000A79A9 File Offset: 0x000A5BA9
		public static CompareInfo GetCompareInfo(int culture)
		{
			if (CultureData.IsCustomCultureId(culture))
			{
				throw new ArgumentException(SR.Argument_CustomCultureCannotBePassedByNumber, "culture");
			}
			return CultureInfo.GetCultureInfo(culture).CompareInfo;
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x000A79CE File Offset: 0x000A5BCE
		public static CompareInfo GetCompareInfo(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			return CultureInfo.GetCultureInfo(name).CompareInfo;
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x000A79E6 File Offset: 0x000A5BE6
		public static bool IsSortable(char ch)
		{
			return CompareInfo.IsSortable(new ReadOnlySpan<char>(ref ch));
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x000A79F4 File Offset: 0x000A5BF4
		public static bool IsSortable(string text)
		{
			ArgumentNullException.ThrowIfNull(text, "text");
			return CompareInfo.IsSortable(text.AsSpan());
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x000A7A0C File Offset: 0x000A5C0C
		[NullableContext(0)]
		public static bool IsSortable(ReadOnlySpan<char> text)
		{
			if (text.Length == 0)
			{
				return false;
			}
			if (GlobalizationMode.Invariant)
			{
				return true;
			}
			if (!GlobalizationMode.UseNls)
			{
				return CompareInfo.IcuIsSortable(text);
			}
			return CompareInfo.NlsIsSortable(text);
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x000A7A38 File Offset: 0x000A5C38
		public unsafe static bool IsSortable(Rune value)
		{
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)4], 2);
			int length = value.EncodeToUtf16(destination);
			return CompareInfo.IsSortable(destination.Slice(0, length));
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x000A7A6C File Offset: 0x000A5C6C
		[MemberNotNull("_sortName")]
		private void InitSort(CultureInfo culture)
		{
			this._sortName = culture.SortName;
			if (GlobalizationMode.UseNls)
			{
				this.NlsInitSortHandle();
				return;
			}
			this.IcuInitSortHandle(culture.InteropName);
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000A7A94 File Offset: 0x000A5C94
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
			this.m_name = null;
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x000A7A9D File Offset: 0x000A5C9D
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialized();
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x000A7A9D File Offset: 0x000A5C9D
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x000A7AA5 File Offset: 0x000A5CA5
		private void OnDeserialized()
		{
			if (this.m_name == null)
			{
				this.m_name = CultureInfo.GetCultureInfo(this.culture)._name;
				return;
			}
			this.InitSort(CultureInfo.GetCultureInfo(this.m_name));
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x000A7AD7 File Offset: 0x000A5CD7
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			this.culture = CultureInfo.GetCultureInfo(this.Name).LCID;
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06003482 RID: 13442 RVA: 0x000A7AEF File Offset: 0x000A5CEF
		public string Name
		{
			get
			{
				if (this.m_name == "zh-CHT" || this.m_name == "zh-CHS")
				{
					return this.m_name;
				}
				return this._sortName;
			}
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x000A7B22 File Offset: 0x000A5D22
		[NullableContext(2)]
		public int Compare(string string1, string string2)
		{
			return this.Compare(string1, string2, CompareOptions.None);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x000A7B30 File Offset: 0x000A5D30
		[NullableContext(2)]
		public int Compare(string string1, string string2, CompareOptions options)
		{
			int result;
			if (string1 == null)
			{
				result = ((string2 == null) ? 0 : -1);
			}
			else
			{
				if (string2 != null)
				{
					return this.Compare(string1.AsSpan(), string2.AsSpan(), options);
				}
				result = 1;
			}
			CompareInfo.CheckCompareOptionsForCompare(options);
			return result;
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x000A7B6C File Offset: 0x000A5D6C
		internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2)
		{
			if (!GlobalizationMode.Invariant)
			{
				return this.CompareStringCore(string1, string2, CompareOptions.IgnoreCase);
			}
			return InvariantModeCasing.CompareStringIgnoreCase(MemoryMarshal.GetReference<char>(string1), string1.Length, MemoryMarshal.GetReference<char>(string2), string2.Length);
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x000A7B9E File Offset: 0x000A5D9E
		[NullableContext(2)]
		public int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			return this.Compare(string1, offset1, length1, string2, offset2, length2, CompareOptions.None);
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x000A7BB0 File Offset: 0x000A5DB0
		[NullableContext(2)]
		public int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options)
		{
			return this.Compare(string1, offset1, (string1 == null) ? 0 : (string1.Length - offset1), string2, offset2, (string2 == null) ? 0 : (string2.Length - offset2), options);
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x000A7BDC File Offset: 0x000A5DDC
		[NullableContext(2)]
		public int Compare(string string1, int offset1, string string2, int offset2)
		{
			return this.Compare(string1, offset1, string2, offset2, CompareOptions.None);
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x000A7BEC File Offset: 0x000A5DEC
		[NullableContext(2)]
		public int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			ReadOnlySpan<char> string3 = default(ReadOnlySpan<char>);
			ReadOnlySpan<char> string4 = default(ReadOnlySpan<char>);
			if (string1 == null)
			{
				if (offset1 != 0)
				{
					goto IL_6E;
				}
				if (length1 != 0)
				{
					goto IL_6E;
				}
			}
			else if (!string1.TryGetSpan(offset1, length1, out string3))
			{
				goto IL_6E;
			}
			if (string2 == null)
			{
				if (offset2 != 0)
				{
					goto IL_6E;
				}
				if (length2 != 0)
				{
					goto IL_6E;
				}
			}
			else if (!string2.TryGetSpan(offset2, length2, out string4))
			{
				goto IL_6E;
			}
			int result;
			if (string1 == null)
			{
				result = ((string2 == null) ? 0 : -1);
			}
			else
			{
				if (string2 != null)
				{
					return this.Compare(string3, string4, options);
				}
				result = 1;
			}
			CompareInfo.CheckCompareOptionsForCompare(options);
			return result;
			IL_6E:
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length1, "length1");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length2, "length2");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset1, "offset1");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(offset2, "offset2");
			if (offset1 > ((string1 == null) ? 0 : string1.Length) - length1)
			{
				throw new ArgumentOutOfRangeException("string1", SR.ArgumentOutOfRange_OffsetLength);
			}
			throw new ArgumentOutOfRangeException("string2", SR.ArgumentOutOfRange_OffsetLength);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x000A7CC8 File Offset: 0x000A5EC8
		[NullableContext(0)]
		public int Compare(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options = CompareOptions.None)
		{
			if (string1 == string2)
			{
				CompareInfo.CheckCompareOptionsForCompare(options);
				return 0;
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) == CompareOptions.None)
			{
				if (!GlobalizationMode.Invariant)
				{
					return this.CompareStringCore(string1, string2, options);
				}
				if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
				{
					return string1.SequenceCompareTo(string2);
				}
				return Ordinal.CompareStringIgnoreCase(MemoryMarshal.GetReference<char>(string1), string1.Length, MemoryMarshal.GetReference<char>(string2), string2.Length);
			}
			else
			{
				if (options == CompareOptions.Ordinal)
				{
					return string1.SequenceCompareTo(string2);
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return Ordinal.CompareStringIgnoreCase(MemoryMarshal.GetReference<char>(string1), string1.Length, MemoryMarshal.GetReference<char>(string2), string2.Length);
				}
				CompareInfo.ThrowCompareOptionsCheckFailed(options);
				return -1;
			}
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x000A7D6C File Offset: 0x000A5F6C
		[StackTraceHidden]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void CheckCompareOptionsForCompare(CompareOptions options)
		{
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None && options != CompareOptions.Ordinal && options != CompareOptions.OrdinalIgnoreCase)
			{
				CompareInfo.ThrowCompareOptionsCheckFailed(options);
			}
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x000A7D8D File Offset: 0x000A5F8D
		[DoesNotReturn]
		[StackTraceHidden]
		private static void ThrowCompareOptionsCheckFailed(CompareOptions options)
		{
			throw new ArgumentException(((options & CompareOptions.Ordinal) != CompareOptions.None) ? SR.Argument_CompareOptionOrdinal : SR.Argument_InvalidFlag, "options");
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x000A7DAE File Offset: 0x000A5FAE
		private int CompareStringCore(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuCompareString(string1, string2, options);
			}
			return this.NlsCompareString(string1, string2, options);
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x000A7DCA File Offset: 0x000A5FCA
		public bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			if (prefix == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.prefix);
			}
			return this.IsPrefix(source.AsSpan(), prefix.AsSpan(), options);
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x000A7DF4 File Offset: 0x000A5FF4
		[NullableContext(0)]
		public bool IsPrefix(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options = CompareOptions.None)
		{
			if (prefix.IsEmpty)
			{
				return true;
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) == CompareOptions.None)
			{
				if (!GlobalizationMode.Invariant)
				{
					return this.StartsWithCore(source, prefix, options, null);
				}
				if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
				{
					return source.StartsWith(prefix);
				}
				return source.StartsWithOrdinalIgnoreCase(prefix);
			}
			else
			{
				if (options == CompareOptions.Ordinal)
				{
					return source.StartsWith(prefix);
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return source.StartsWithOrdinalIgnoreCase(prefix);
				}
				CompareInfo.ThrowCompareOptionsCheckFailed(options);
				return false;
			}
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x000A7E64 File Offset: 0x000A6064
		[NullableContext(0)]
		public unsafe bool IsPrefix(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options, out int matchLength)
		{
			bool flag;
			if (GlobalizationMode.Invariant || prefix.IsEmpty || (options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				flag = this.IsPrefix(source, prefix, options);
				matchLength = (flag ? prefix.Length : 0);
			}
			else
			{
				int num = 0;
				flag = this.StartsWithCore(source, prefix, options, &num);
				matchLength = num;
			}
			return flag;
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x000A7EB7 File Offset: 0x000A60B7
		private unsafe bool StartsWithCore(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options, int* matchLengthPtr)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuStartsWith(source, prefix, options, matchLengthPtr);
			}
			return this.NlsStartsWith(source, prefix, options, matchLengthPtr);
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x000A7ED7 File Offset: 0x000A60D7
		public bool IsPrefix(string source, string prefix)
		{
			return this.IsPrefix(source, prefix, CompareOptions.None);
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x000A7EE2 File Offset: 0x000A60E2
		public bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			if (suffix == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.suffix);
			}
			return this.IsSuffix(source.AsSpan(), suffix.AsSpan(), options);
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x000A7F0C File Offset: 0x000A610C
		[NullableContext(0)]
		public bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options = CompareOptions.None)
		{
			if (suffix.IsEmpty)
			{
				return true;
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) == CompareOptions.None)
			{
				if (!GlobalizationMode.Invariant)
				{
					return this.EndsWithCore(source, suffix, options, null);
				}
				if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
				{
					return source.EndsWith(suffix);
				}
				return source.EndsWithOrdinalIgnoreCase(suffix);
			}
			else
			{
				if (options == CompareOptions.Ordinal)
				{
					return source.EndsWith(suffix);
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return source.EndsWithOrdinalIgnoreCase(suffix);
				}
				CompareInfo.ThrowCompareOptionsCheckFailed(options);
				return false;
			}
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x000A7F7C File Offset: 0x000A617C
		[NullableContext(0)]
		public unsafe bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options, out int matchLength)
		{
			bool flag;
			if (GlobalizationMode.Invariant || suffix.IsEmpty || (options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) != CompareOptions.None)
			{
				flag = this.IsSuffix(source, suffix, options);
				matchLength = (flag ? suffix.Length : 0);
			}
			else
			{
				int num = 0;
				flag = this.EndsWithCore(source, suffix, options, &num);
				matchLength = num;
			}
			return flag;
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x000A7FCF File Offset: 0x000A61CF
		public bool IsSuffix(string source, string suffix)
		{
			return this.IsSuffix(source, suffix, CompareOptions.None);
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x000A7FDA File Offset: 0x000A61DA
		private unsafe bool EndsWithCore(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options, int* matchLengthPtr)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuEndsWith(source, suffix, options, matchLengthPtr);
			}
			return this.NlsEndsWith(source, suffix, options, matchLengthPtr);
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x000A7FFA File Offset: 0x000A61FA
		public int IndexOf(string source, char value)
		{
			return this.IndexOf(source, value, CompareOptions.None);
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x000A8005 File Offset: 0x000A6205
		public int IndexOf(string source, string value)
		{
			return this.IndexOf(source, value, CompareOptions.None);
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x000A8010 File Offset: 0x000A6210
		public int IndexOf(string source, char value, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			return this.IndexOf(source, new ReadOnlySpan<char>(ref value), options);
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x000A8030 File Offset: 0x000A6230
		public int IndexOf(string source, string value, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return this.IndexOf(source.AsSpan(), value.AsSpan(), options);
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x000A8058 File Offset: 0x000A6258
		public int IndexOf(string source, char value, int startIndex)
		{
			return this.IndexOf(source, value, startIndex, CompareOptions.None);
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x000A8064 File Offset: 0x000A6264
		public int IndexOf(string source, string value, int startIndex)
		{
			return this.IndexOf(source, value, startIndex, CompareOptions.None);
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x000A8070 File Offset: 0x000A6270
		public int IndexOf(string source, char value, int startIndex, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			return this.IndexOf(source, value, startIndex, source.Length - startIndex, options);
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x000A808F File Offset: 0x000A628F
		public int IndexOf(string source, string value, int startIndex, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			return this.IndexOf(source, value, startIndex, source.Length - startIndex, options);
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000A80AE File Offset: 0x000A62AE
		public int IndexOf(string source, char value, int startIndex, int count)
		{
			return this.IndexOf(source, value, startIndex, count, CompareOptions.None);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x000A80BC File Offset: 0x000A62BC
		public int IndexOf(string source, string value, int startIndex, int count)
		{
			return this.IndexOf(source, value, startIndex, count, CompareOptions.None);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x000A80CC File Offset: 0x000A62CC
		public int IndexOf(string source, char value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			ReadOnlySpan<char> source2;
			if (!source.TryGetSpan(startIndex, count, out source2))
			{
				if (startIndex > source.Length)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				else
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
				}
			}
			int num = this.IndexOf(source2, new ReadOnlySpan<char>(ref value), options);
			if (num >= 0)
			{
				num += startIndex;
			}
			return num;
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x000A8124 File Offset: 0x000A6324
		public int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			ReadOnlySpan<char> source2;
			if (!source.TryGetSpan(startIndex, count, out source2))
			{
				if (startIndex > source.Length)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				else
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
				}
			}
			int num = this.IndexOf(source2, value, options);
			if (num >= 0)
			{
				num += startIndex;
			}
			return num;
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x000A8184 File Offset: 0x000A6384
		[NullableContext(0)]
		public int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options = CompareOptions.None)
		{
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) == CompareOptions.None)
			{
				if (!GlobalizationMode.Invariant)
				{
					if (value.IsEmpty)
					{
						return 0;
					}
					return this.IndexOfCore(source, value, options, null, true);
				}
				else
				{
					if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
					{
						return source.IndexOf(value);
					}
					return Ordinal.IndexOfOrdinalIgnoreCase(source, value);
				}
			}
			else
			{
				if (options == CompareOptions.Ordinal)
				{
					return source.IndexOf(value);
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return Ordinal.IndexOfOrdinalIgnoreCase(source, value);
				}
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidFlag, ExceptionArgument.options);
				return -1;
			}
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x000A81F8 File Offset: 0x000A63F8
		[NullableContext(0)]
		public unsafe int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options, out int matchLength)
		{
			int num;
			int result = this.IndexOf(source, value, &num, options, true);
			matchLength = num;
			return result;
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x000A8218 File Offset: 0x000A6418
		[NullableContext(0)]
		public unsafe int IndexOf(ReadOnlySpan<char> source, Rune value, CompareOptions options = CompareOptions.None)
		{
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)4], 2);
			int length = value.EncodeToUtf16(destination);
			return this.IndexOf(source, destination.Slice(0, length), options);
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x000A8250 File Offset: 0x000A6450
		private unsafe int IndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, int* matchLengthPtr, CompareOptions options, bool fromBeginning)
		{
			*matchLengthPtr = 0;
			int num = 0;
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) == CompareOptions.None)
			{
				if (!GlobalizationMode.Invariant)
				{
					if (!value.IsEmpty)
					{
						return this.IndexOfCore(source, value, options, matchLengthPtr, fromBeginning);
					}
					if (!fromBeginning)
					{
						return source.Length;
					}
					return 0;
				}
				else if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
				{
					num = (fromBeginning ? source.IndexOf(value) : source.LastIndexOf(value));
				}
				else
				{
					num = (fromBeginning ? Ordinal.IndexOfOrdinalIgnoreCase(source, value) : Ordinal.LastIndexOfOrdinalIgnoreCase(source, value));
				}
			}
			else if (options == CompareOptions.Ordinal)
			{
				num = (fromBeginning ? source.IndexOf(value) : source.LastIndexOf(value));
			}
			else if (options == CompareOptions.OrdinalIgnoreCase)
			{
				num = (fromBeginning ? Ordinal.IndexOfOrdinalIgnoreCase(source, value) : Ordinal.LastIndexOfOrdinalIgnoreCase(source, value));
			}
			else
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidFlag, ExceptionArgument.options);
			}
			if (num >= 0)
			{
				*matchLengthPtr = value.Length;
			}
			return num;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x000A8320 File Offset: 0x000A6520
		private unsafe int IndexOfCore(ReadOnlySpan<char> source, ReadOnlySpan<char> target, CompareOptions options, int* matchLengthPtr, bool fromBeginning)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuIndexOfCore(source, target, options, matchLengthPtr, fromBeginning);
			}
			return this.NlsIndexOfCore(source, target, options, matchLengthPtr, fromBeginning);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x000A8344 File Offset: 0x000A6544
		public int LastIndexOf(string source, char value)
		{
			return this.LastIndexOf(source, value, CompareOptions.None);
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000A834F File Offset: 0x000A654F
		public int LastIndexOf(string source, string value)
		{
			return this.LastIndexOf(source, value, CompareOptions.None);
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x000A835A File Offset: 0x000A655A
		public int LastIndexOf(string source, char value, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			return this.LastIndexOf(source, new ReadOnlySpan<char>(ref value), options);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x000A837A File Offset: 0x000A657A
		public int LastIndexOf(string source, string value, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return this.LastIndexOf(source.AsSpan(), value.AsSpan(), options);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x000A83A2 File Offset: 0x000A65A2
		public int LastIndexOf(string source, char value, int startIndex)
		{
			return this.LastIndexOf(source, value, startIndex, startIndex + 1, CompareOptions.None);
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000A83B1 File Offset: 0x000A65B1
		public int LastIndexOf(string source, string value, int startIndex)
		{
			return this.LastIndexOf(source, value, startIndex, startIndex + 1, CompareOptions.None);
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x000A83C0 File Offset: 0x000A65C0
		public int LastIndexOf(string source, char value, int startIndex, CompareOptions options)
		{
			return this.LastIndexOf(source, value, startIndex, startIndex + 1, options);
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x000A83D0 File Offset: 0x000A65D0
		public int LastIndexOf(string source, string value, int startIndex, CompareOptions options)
		{
			return this.LastIndexOf(source, value, startIndex, startIndex + 1, options);
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x000A83E0 File Offset: 0x000A65E0
		public int LastIndexOf(string source, char value, int startIndex, int count)
		{
			return this.LastIndexOf(source, value, startIndex, count, CompareOptions.None);
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x000A83EE File Offset: 0x000A65EE
		public int LastIndexOf(string source, string value, int startIndex, int count)
		{
			return this.LastIndexOf(source, value, startIndex, count, CompareOptions.None);
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x000A83FC File Offset: 0x000A65FC
		public int LastIndexOf(string source, char value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			while (startIndex >= source.Length)
			{
				if (startIndex == -1 && source.Length == 0)
				{
					count = 0;
					break;
				}
				if (startIndex != source.Length)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
					break;
				}
				startIndex--;
				if (count > 0)
				{
					count--;
				}
			}
			startIndex = startIndex - count + 1;
			ReadOnlySpan<char> source2;
			if (!source.TryGetSpan(startIndex, count, out source2))
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			int num = this.LastIndexOf(source2, new ReadOnlySpan<char>(ref value), options);
			if (num >= 0)
			{
				num += startIndex;
			}
			return num;
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x000A8484 File Offset: 0x000A6684
		public int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			while (startIndex >= source.Length)
			{
				if (startIndex == -1 && source.Length == 0)
				{
					count = 0;
					break;
				}
				if (startIndex != source.Length)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
					break;
				}
				startIndex--;
				if (count > 0)
				{
					count--;
				}
			}
			startIndex = startIndex - count + 1;
			ReadOnlySpan<char> source2;
			if (!source.TryGetSpan(startIndex, count, out source2))
			{
				ThrowHelper.ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count();
			}
			int num = this.LastIndexOf(source2, value, options);
			if (num >= 0)
			{
				num += startIndex;
			}
			return num;
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x000A8514 File Offset: 0x000A6714
		[NullableContext(0)]
		public int LastIndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options = CompareOptions.None)
		{
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) == CompareOptions.None)
			{
				if (!GlobalizationMode.Invariant)
				{
					if (value.IsEmpty)
					{
						return source.Length;
					}
					return this.IndexOfCore(source, value, options, null, false);
				}
				else
				{
					if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
					{
						return source.LastIndexOf(value);
					}
					return Ordinal.LastIndexOfOrdinalIgnoreCase(source, value);
				}
			}
			else
			{
				if (options == CompareOptions.Ordinal)
				{
					return source.LastIndexOf(value);
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return Ordinal.LastIndexOfOrdinalIgnoreCase(source, value);
				}
				throw new ArgumentException(SR.Argument_InvalidFlag, "options");
			}
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x000A8590 File Offset: 0x000A6790
		[NullableContext(0)]
		public unsafe int LastIndexOf(ReadOnlySpan<char> source, ReadOnlySpan<char> value, CompareOptions options, out int matchLength)
		{
			int num;
			int result = this.IndexOf(source, value, &num, options, false);
			matchLength = num;
			return result;
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x000A85B0 File Offset: 0x000A67B0
		[NullableContext(0)]
		public unsafe int LastIndexOf(ReadOnlySpan<char> source, Rune value, CompareOptions options = CompareOptions.None)
		{
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)4], 2);
			int length = value.EncodeToUtf16(destination);
			return this.LastIndexOf(source, destination.Slice(0, length), options);
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x000A85E7 File Offset: 0x000A67E7
		public SortKey GetSortKey(string source, CompareOptions options)
		{
			if (GlobalizationMode.Invariant)
			{
				return this.InvariantCreateSortKey(source, options);
			}
			return this.CreateSortKeyCore(source, options);
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x000A8601 File Offset: 0x000A6801
		public SortKey GetSortKey(string source)
		{
			if (GlobalizationMode.Invariant)
			{
				return this.InvariantCreateSortKey(source, CompareOptions.None);
			}
			return this.CreateSortKeyCore(source, CompareOptions.None);
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x000A861B File Offset: 0x000A681B
		private SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuCreateSortKey(source, options);
			}
			return this.NlsCreateSortKey(source, options);
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x000A8635 File Offset: 0x000A6835
		[NullableContext(0)]
		public int GetSortKey(ReadOnlySpan<char> source, Span<byte> destination, CompareOptions options = CompareOptions.None)
		{
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidFlag, ExceptionArgument.options);
			}
			if (GlobalizationMode.Invariant)
			{
				return CompareInfo.InvariantGetSortKey(source, destination, options);
			}
			return this.GetSortKeyCore(source, destination, options);
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x000A8662 File Offset: 0x000A6862
		private int GetSortKeyCore(ReadOnlySpan<char> source, Span<byte> destination, CompareOptions options)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetSortKey(source, destination, options);
			}
			return this.NlsGetSortKey(source, destination, options);
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000A867E File Offset: 0x000A687E
		[NullableContext(0)]
		public int GetSortKeyLength(ReadOnlySpan<char> source, CompareOptions options = CompareOptions.None)
		{
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidFlag, ExceptionArgument.options);
			}
			if (GlobalizationMode.Invariant)
			{
				return CompareInfo.InvariantGetSortKeyLength(source, options);
			}
			return this.GetSortKeyLengthCore(source, options);
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x000A86A9 File Offset: 0x000A68A9
		private int GetSortKeyLengthCore(ReadOnlySpan<char> source, CompareOptions options)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetSortKeyLength(source, options);
			}
			return this.NlsGetSortKeyLength(source, options);
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x000A86C4 File Offset: 0x000A68C4
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			CompareInfo compareInfo = value as CompareInfo;
			return compareInfo != null && this.Name == compareInfo.Name;
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x000A86EE File Offset: 0x000A68EE
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x000A86FB File Offset: 0x000A68FB
		public int GetHashCode(string source, CompareOptions options)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			return this.GetHashCode(source.AsSpan(), options);
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x000A8714 File Offset: 0x000A6914
		[NullableContext(0)]
		public int GetHashCode(ReadOnlySpan<char> source, CompareOptions options)
		{
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) == CompareOptions.None)
			{
				if (!GlobalizationMode.Invariant)
				{
					return this.GetHashCodeOfStringCore(source, options);
				}
				return CompareInfo.InvariantGetHashCode(source, options);
			}
			else
			{
				if (options == CompareOptions.Ordinal)
				{
					return string.GetHashCode(source);
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return string.GetHashCodeOrdinalIgnoreCase(source);
				}
				CompareInfo.ThrowCompareOptionsCheckFailed(options);
				return -1;
			}
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x000A8767 File Offset: 0x000A6967
		private int GetHashCodeOfStringCore(ReadOnlySpan<char> source, CompareOptions options)
		{
			if (!GlobalizationMode.UseNls)
			{
				return this.IcuGetHashCodeOfString(source, options);
			}
			return this.NlsGetHashCodeOfString(source, options);
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x000A8781 File Offset: 0x000A6981
		public override string ToString()
		{
			return "CompareInfo - " + this.Name;
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x000A8794 File Offset: 0x000A6994
		public SortVersion Version
		{
			get
			{
				if (this.m_SortVersion == null)
				{
					if (GlobalizationMode.Invariant)
					{
						this.m_SortVersion = new SortVersion(0, 127, new Guid(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 127));
					}
					else
					{
						this.m_SortVersion = (GlobalizationMode.UseNls ? this.NlsGetSortVersion() : this.IcuGetSortVersion());
					}
				}
				return this.m_SortVersion;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x000A87F8 File Offset: 0x000A69F8
		public int LCID
		{
			get
			{
				return CultureInfo.GetCultureInfo(this.Name).LCID;
			}
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x000A880A File Offset: 0x000A6A0A
		private void IcuInitSortHandle(string interopCultureName)
		{
			this._isAsciiEqualityOrdinal = this.GetIsAsciiEqualityOrdinal(interopCultureName);
			if (!GlobalizationMode.Invariant)
			{
				this._sortHandle = CompareInfo.SortHandleCache.GetCachedSortHandle(interopCultureName);
			}
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x000A882C File Offset: 0x000A6A2C
		private bool GetIsAsciiEqualityOrdinal(string interopCultureName)
		{
			return GlobalizationMode.Invariant || this._sortName.Length == 0 || (this._sortName.Length >= 2 && this._sortName[0] == 'e' && this._sortName[1] == 'n' && (this._sortName.Length == 2 || this._sortName[2] == '-'));
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x000A88A4 File Offset: 0x000A6AA4
		private unsafe int IcuCompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(string1))
			{
				char* lpStr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(string2))
				{
					char* lpStr2 = reference2;
					return Interop.Globalization.CompareString(this._sortHandle, lpStr, string1.Length, lpStr2, string2.Length, options);
				}
			}
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x000A88E4 File Offset: 0x000A6AE4
		private unsafe int IcuIndexOfCore(ReadOnlySpan<char> source, ReadOnlySpan<char> target, CompareOptions options, int* matchLengthPtr, bool fromBeginning)
		{
			if (this._isAsciiEqualityOrdinal && CompareInfo.CanUseAsciiOrdinalForOptions(options))
			{
				if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
				{
					return this.IndexOfOrdinalIgnoreCaseHelper(source, target, options, matchLengthPtr, fromBeginning);
				}
				return this.IndexOfOrdinalHelper(source, target, options, matchLengthPtr, fromBeginning);
			}
			else
			{
				fixed (char* reference = MemoryMarshal.GetReference<char>(source))
				{
					char* pSource = reference;
					fixed (char* reference2 = MemoryMarshal.GetReference<char>(target))
					{
						char* target2 = reference2;
						if (fromBeginning)
						{
							return Interop.Globalization.IndexOf(this._sortHandle, target2, target.Length, pSource, source.Length, options, matchLengthPtr);
						}
						return Interop.Globalization.LastIndexOf(this._sortHandle, target2, target.Length, pSource, source.Length, options, matchLengthPtr);
					}
				}
			}
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x000A8978 File Offset: 0x000A6B78
		private unsafe int IndexOfOrdinalIgnoreCaseHelper(ReadOnlySpan<char> source, ReadOnlySpan<char> target, CompareOptions options, int* matchLengthPtr, bool fromBeginning)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(target))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr;
					char* ptr4 = ptr2;
					if (!target.ContainsAnyExcept(CompareInfo.s_nonSpecialAsciiChars))
					{
						if (target.Length > source.Length)
						{
							if (!source.ContainsAnyExcept(CompareInfo.s_nonSpecialAsciiChars))
							{
								return -1;
							}
						}
						else
						{
							int num;
							int num2;
							int num3;
							if (fromBeginning)
							{
								num = 0;
								num2 = source.Length - target.Length + 1;
								num3 = 1;
							}
							else
							{
								num = source.Length - target.Length;
								num2 = -1;
								num3 = -1;
							}
							int num4 = num;
							IL_167:
							while (num4 != num2)
							{
								int i = 0;
								int num5 = num4;
								while (i < target.Length)
								{
									char c = ptr3[num5];
									char c2 = ptr4[i];
									if (c >= '\u0080' || *CompareInfo.HighCharTable[(int)c] != 0)
									{
										goto IL_197;
									}
									if (c != c2)
									{
										if (char.IsAsciiLetterLower(c))
										{
											c -= ' ';
										}
										if (char.IsAsciiLetterLower(c2))
										{
											c2 -= ' ';
										}
										if (c != c2)
										{
											if (num5 < source.Length - 1 && (ptr3 + num5)[1] >= '\u0080')
											{
												goto IL_197;
											}
											num4 += num3;
											goto IL_167;
										}
									}
									i++;
									num5++;
								}
								if (num5 >= source.Length || ptr3[num5] < '\u0080')
								{
									if (matchLengthPtr != null)
									{
										*matchLengthPtr = target.Length;
									}
									return num4;
								}
								goto IL_197;
							}
							if (!(fromBeginning ? source.Slice(num2) : source.Slice(0, num)).ContainsAnyExcept(CompareInfo.s_nonSpecialAsciiChars))
							{
								return -1;
							}
						}
					}
					IL_197:
					if (fromBeginning)
					{
						return Interop.Globalization.IndexOf(this._sortHandle, ptr4, target.Length, ptr3, source.Length, options, matchLengthPtr);
					}
					return Interop.Globalization.LastIndexOf(this._sortHandle, ptr4, target.Length, ptr3, source.Length, options, matchLengthPtr);
				}
			}
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x000A8B60 File Offset: 0x000A6D60
		private unsafe int IndexOfOrdinalHelper(ReadOnlySpan<char> source, ReadOnlySpan<char> target, CompareOptions options, int* matchLengthPtr, bool fromBeginning)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(target))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr;
					char* ptr4 = ptr2;
					if (!target.ContainsAnyExcept(CompareInfo.s_nonSpecialAsciiChars))
					{
						if (target.Length <= source.Length)
						{
							int num;
							int num2;
							int num3;
							if (fromBeginning)
							{
								num = 0;
								num2 = source.Length - target.Length + 1;
								num3 = 1;
							}
							else
							{
								num = source.Length - target.Length;
								num2 = -1;
								num3 = -1;
							}
							int num4 = num;
							IL_136:
							while (num4 != num2)
							{
								int i = 0;
								int num5 = num4;
								while (i < target.Length)
								{
									char c = ptr3[num5];
									char c2 = ptr4[i];
									if (c >= '\u0080' || *CompareInfo.HighCharTable[(int)c] != 0)
									{
										goto IL_141;
									}
									if (c != c2)
									{
										if (num5 < source.Length - 1 && (ptr3 + num5)[1] >= '\u0080')
										{
											goto IL_141;
										}
										num4 += num3;
										goto IL_136;
									}
									else
									{
										i++;
										num5++;
									}
								}
								if (num5 >= source.Length || ptr3[num5] < '\u0080')
								{
									if (matchLengthPtr != null)
									{
										*matchLengthPtr = target.Length;
									}
									return num4;
								}
								goto IL_141;
							}
							return -1;
						}
						if (!source.ContainsAnyExcept(CompareInfo.s_nonSpecialAsciiChars))
						{
							return -1;
						}
					}
					IL_141:
					if (fromBeginning)
					{
						return Interop.Globalization.IndexOf(this._sortHandle, ptr4, target.Length, ptr3, source.Length, options, matchLengthPtr);
					}
					return Interop.Globalization.LastIndexOf(this._sortHandle, ptr4, target.Length, ptr3, source.Length, options, matchLengthPtr);
				}
			}
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x000A8CF4 File Offset: 0x000A6EF4
		private unsafe bool IcuStartsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options, int* matchLengthPtr)
		{
			if (!this._isAsciiEqualityOrdinal || !CompareInfo.CanUseAsciiOrdinalForOptions(options))
			{
				fixed (char* reference = MemoryMarshal.GetReference<char>(source))
				{
					char* source2 = reference;
					fixed (char* reference2 = MemoryMarshal.GetReference<char>(prefix))
					{
						char* target = reference2;
						return Interop.Globalization.StartsWith(this._sortHandle, target, prefix.Length, source2, source.Length, options, matchLengthPtr);
					}
				}
			}
			if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
			{
				return this.StartsWithOrdinalIgnoreCaseHelper(source, prefix, options, matchLengthPtr);
			}
			return this.StartsWithOrdinalHelper(source, prefix, options, matchLengthPtr);
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000A8D60 File Offset: 0x000A6F60
		private unsafe bool StartsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options, int* matchLengthPtr)
		{
			int num = Math.Min(source.Length, prefix.Length);
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(prefix))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr;
					char* ptr4 = ptr2;
					while (num != 0)
					{
						int num2 = (int)(*ptr3);
						int num3 = (int)(*ptr4);
						if (num2 < 128 && num3 < 128 && *CompareInfo.HighCharTable[num2] == 0 && *CompareInfo.HighCharTable[num3] == 0)
						{
							if (num2 == num3)
							{
								ptr3++;
								ptr4++;
								num--;
								continue;
							}
							if (num2 - 97 <= 25)
							{
								num2 -= 32;
							}
							if (num3 - 97 <= 25)
							{
								num3 -= 32;
							}
							if (num2 == num3)
							{
								ptr3++;
								ptr4++;
								num--;
								continue;
							}
							if ((ptr3 >= ptr + source.Length - 1 || ptr3[1] < '\u0080') && (ptr4 >= ptr2 + prefix.Length - 1 || ptr4[1] < '\u0080'))
							{
								return false;
							}
						}
						IL_190:
						return Interop.Globalization.StartsWith(this._sortHandle, ptr2, prefix.Length, ptr, source.Length, options, matchLengthPtr);
					}
					if (source.Length >= prefix.Length)
					{
						if (source.Length > prefix.Length)
						{
							int num4 = (int)(*ptr3);
							if (num4 >= 128 || *CompareInfo.HighCharTable[num4] != 0)
							{
								goto IL_190;
							}
						}
						if (matchLengthPtr != null)
						{
							*matchLengthPtr = prefix.Length;
						}
						return true;
					}
					int num5 = (int)(*ptr4);
					if (num5 < 128 && *CompareInfo.HighCharTable[num5] == 0)
					{
						return false;
					}
					goto IL_190;
				}
			}
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000A8F1C File Offset: 0x000A711C
		private unsafe bool StartsWithOrdinalHelper(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options, int* matchLengthPtr)
		{
			int num = Math.Min(source.Length, prefix.Length);
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(prefix))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr;
					char* ptr4 = ptr2;
					while (num != 0)
					{
						int num2 = (int)(*ptr3);
						int num3 = (int)(*ptr4);
						if (num2 < 128 && num3 < 128 && *CompareInfo.HighCharTable[num2] == 0 && *CompareInfo.HighCharTable[num3] == 0)
						{
							if (num2 == num3)
							{
								ptr3++;
								ptr4++;
								num--;
								continue;
							}
							if ((ptr3 >= ptr + source.Length - 1 || ptr3[1] < '\u0080') && (ptr4 >= ptr2 + prefix.Length - 1 || ptr4[1] < '\u0080'))
							{
								return false;
							}
						}
						IL_158:
						return Interop.Globalization.StartsWith(this._sortHandle, ptr2, prefix.Length, ptr, source.Length, options, matchLengthPtr);
					}
					if (source.Length >= prefix.Length)
					{
						if (source.Length > prefix.Length)
						{
							int num4 = (int)(*ptr3);
							if (num4 >= 128 || *CompareInfo.HighCharTable[num4] != 0)
							{
								goto IL_158;
							}
						}
						if (matchLengthPtr != null)
						{
							*matchLengthPtr = prefix.Length;
						}
						return true;
					}
					int num5 = (int)(*ptr4);
					if (num5 < 128 && *CompareInfo.HighCharTable[num5] == 0)
					{
						return false;
					}
					goto IL_158;
				}
			}
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x000A90A0 File Offset: 0x000A72A0
		private unsafe bool IcuEndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options, int* matchLengthPtr)
		{
			if (!this._isAsciiEqualityOrdinal || !CompareInfo.CanUseAsciiOrdinalForOptions(options))
			{
				fixed (char* reference = MemoryMarshal.GetReference<char>(source))
				{
					char* source2 = reference;
					fixed (char* reference2 = MemoryMarshal.GetReference<char>(suffix))
					{
						char* target = reference2;
						return Interop.Globalization.EndsWith(this._sortHandle, target, suffix.Length, source2, source.Length, options, matchLengthPtr);
					}
				}
			}
			if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
			{
				return this.EndsWithOrdinalIgnoreCaseHelper(source, suffix, options, matchLengthPtr);
			}
			return this.EndsWithOrdinalHelper(source, suffix, options, matchLengthPtr);
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000A910C File Offset: 0x000A730C
		private unsafe bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options, int* matchLengthPtr)
		{
			int num = Math.Min(source.Length, suffix.Length);
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(suffix))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr + source.Length - 1;
					char* ptr4 = ptr2 + suffix.Length - 1;
					while (num != 0)
					{
						int num2 = (int)(*ptr3);
						int num3 = (int)(*ptr4);
						if (num2 < 128 && num3 < 128 && *CompareInfo.HighCharTable[num2] == 0 && *CompareInfo.HighCharTable[num3] == 0)
						{
							if (num2 == num3)
							{
								ptr3--;
								ptr4--;
								num--;
								continue;
							}
							if (num2 - 97 <= 25)
							{
								num2 -= 32;
							}
							if (num3 - 97 <= 25)
							{
								num3 -= 32;
							}
							if (num2 == num3)
							{
								ptr3--;
								ptr4--;
								num--;
								continue;
							}
							if ((ptr3 == ptr || *(ptr3 - 1) < '\u0080') && (ptr4 == ptr2 || *(ptr4 - 1) < '\u0080'))
							{
								return false;
							}
						}
						IL_190:
						return Interop.Globalization.EndsWith(this._sortHandle, ptr2, suffix.Length, ptr, source.Length, options, matchLengthPtr);
					}
					if (source.Length >= suffix.Length)
					{
						if (source.Length > suffix.Length)
						{
							int num4 = (int)(*ptr3);
							if (num4 >= 128 || *CompareInfo.HighCharTable[num4] != 0)
							{
								goto IL_190;
							}
						}
						if (matchLengthPtr != null)
						{
							*matchLengthPtr = suffix.Length;
						}
						return true;
					}
					int num5 = (int)(*ptr4);
					if (num5 < 128 && *CompareInfo.HighCharTable[num5] == 0)
					{
						return false;
					}
					goto IL_190;
				}
			}
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x000A92C8 File Offset: 0x000A74C8
		private unsafe bool EndsWithOrdinalHelper(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options, int* matchLengthPtr)
		{
			int num = Math.Min(source.Length, suffix.Length);
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* ptr = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(suffix))
				{
					char* ptr2 = reference2;
					char* ptr3 = ptr + source.Length - 1;
					char* ptr4 = ptr2 + suffix.Length - 1;
					while (num != 0)
					{
						int num2 = (int)(*ptr3);
						int num3 = (int)(*ptr4);
						if (num2 < 128 && num3 < 128 && *CompareInfo.HighCharTable[num2] == 0 && *CompareInfo.HighCharTable[num3] == 0)
						{
							if (num2 == num3)
							{
								ptr3--;
								ptr4--;
								num--;
								continue;
							}
							if ((ptr3 == ptr || *(ptr3 - 1) < '\u0080') && (ptr4 == ptr2 || *(ptr4 - 1) < '\u0080'))
							{
								return false;
							}
						}
						IL_158:
						return Interop.Globalization.EndsWith(this._sortHandle, ptr2, suffix.Length, ptr, source.Length, options, matchLengthPtr);
					}
					if (source.Length >= suffix.Length)
					{
						if (source.Length > suffix.Length)
						{
							int num4 = (int)(*ptr3);
							if (num4 >= 128 || *CompareInfo.HighCharTable[num4] != 0)
							{
								goto IL_158;
							}
						}
						if (matchLengthPtr != null)
						{
							*matchLengthPtr = suffix.Length;
						}
						return true;
					}
					int num5 = (int)(*ptr4);
					if (num5 < 128 && *CompareInfo.HighCharTable[num5] == 0)
					{
						return false;
					}
					goto IL_158;
				}
			}
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x000A944C File Offset: 0x000A764C
		private unsafe SortKey IcuCreateSortKey(string source, CompareOptions options)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException(SR.Argument_InvalidFlag, "options");
			}
			char* ptr;
			if (source == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = source.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* str = ptr;
			int sortKey = Interop.Globalization.GetSortKey(this._sortHandle, str, source.Length, null, 0, options);
			byte[] array = new byte[sortKey];
			byte[] array2;
			byte* sortKey2;
			if ((array2 = array) == null || array2.Length == 0)
			{
				sortKey2 = null;
			}
			else
			{
				sortKey2 = &array2[0];
			}
			if (Interop.Globalization.GetSortKey(this._sortHandle, str, source.Length, sortKey2, sortKey, options) != sortKey)
			{
				throw new ArgumentException(SR.Arg_ExternalException);
			}
			array2 = null;
			char* ptr2 = null;
			return new SortKey(this, source, options, array);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x000A94FC File Offset: 0x000A76FC
		private unsafe int IcuGetSortKey(ReadOnlySpan<char> source, Span<byte> destination, CompareOptions options)
		{
			int sortKey2;
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* str = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(destination))
				{
					byte* sortKey = reference2;
					sortKey2 = Interop.Globalization.GetSortKey(this._sortHandle, str, source.Length, sortKey, destination.Length, options);
				}
			}
			if (sortKey2 > destination.Length)
			{
				if (sortKey2 <= destination.Length)
				{
					throw new ArgumentException(SR.Arg_ExternalException);
				}
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			return sortKey2;
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x000A956C File Offset: 0x000A776C
		private unsafe int IcuGetSortKeyLength(ReadOnlySpan<char> source, CompareOptions options)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* str = reference;
				return Interop.Globalization.GetSortKey(this._sortHandle, str, source.Length, null, 0, options);
			}
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x000A959C File Offset: 0x000A779C
		private static bool IcuIsSortable(ReadOnlySpan<char> text)
		{
			Rune value;
			int start;
			while (Rune.DecodeFromUtf16(text, out value, out start) == OperationStatus.Done)
			{
				UnicodeCategory unicodeCategory = Rune.GetUnicodeCategory(value);
				if (unicodeCategory == UnicodeCategory.PrivateUse || unicodeCategory == UnicodeCategory.OtherNotAssigned)
				{
					return false;
				}
				text = text.Slice(start);
				if (text.IsEmpty)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x000A95E0 File Offset: 0x000A77E0
		private unsafe int IcuGetHashCodeOfString(ReadOnlySpan<char> source, CompareOptions options)
		{
			int num = (source.Length > 262144) ? 0 : (4 * source.Length);
			byte[] array = null;
			Span<byte> span;
			if (num <= 1024)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)1024], 1024);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(num));
			}
			Span<byte> span2 = span;
			fixed (char* nonNullPinnableReference = MemoryMarshal.GetNonNullPinnableReference<char>(source))
			{
				char* str = nonNullPinnableReference;
				fixed (byte* reference = MemoryMarshal.GetReference<byte>(span2))
				{
					byte* sortKey = reference;
					num = Interop.Globalization.GetSortKey(this._sortHandle, str, source.Length, sortKey, span2.Length, options);
				}
				if (num > span2.Length)
				{
					if (array != null)
					{
						ArrayPool<byte>.Shared.Return(array, false);
					}
					span2 = (array = ArrayPool<byte>.Shared.Rent(num));
					fixed (byte* reference = MemoryMarshal.GetReference<byte>(span2))
					{
						byte* sortKey2 = reference;
						num = Interop.Globalization.GetSortKey(this._sortHandle, str, source.Length, sortKey2, span2.Length, options);
					}
				}
			}
			if (num == 0 || num > span2.Length)
			{
				throw new ArgumentException(SR.Arg_ExternalException);
			}
			int result = Marvin.ComputeHash32(span2.Slice(0, num), Marvin.DefaultSeed);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x000A9718 File Offset: 0x000A7918
		private static bool CanUseAsciiOrdinalForOptions(CompareOptions options)
		{
			return (options & CompareOptions.IgnoreSymbols) == CompareOptions.None;
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x000A9720 File Offset: 0x000A7920
		private SortVersion IcuGetSortVersion()
		{
			int sortVersion = Interop.Globalization.GetSortVersion(this._sortHandle);
			return new SortVersion(sortVersion, this.LCID, new Guid(sortVersion, 0, 0, 0, 0, 0, 0, (byte)(this.LCID >> 24), (byte)((this.LCID & 16711680) >> 16), (byte)((this.LCID & 65280) >> 8), (byte)(this.LCID & 255)));
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x000A9787 File Offset: 0x000A7987
		[Nullable(0)]
		private unsafe static ReadOnlySpan<bool> HighCharTable
		{
			get
			{
				return new ReadOnlySpan<bool>((void*)(&<PrivateImplementationDetails>.F8919BA0F50317229A66884F9CE4E004B755100D8A4000A28D468B0627472F4D), 128);
			}
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x000A9798 File Offset: 0x000A7998
		private SortKey InvariantCreateSortKey(string source, CompareOptions options)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException(SR.Argument_InvalidFlag, "options");
			}
			byte[] array;
			if (source.Length == 0)
			{
				array = Array.Empty<byte>();
			}
			else
			{
				array = new byte[source.Length * 2];
				if ((options & (CompareOptions.IgnoreCase | CompareOptions.OrdinalIgnoreCase)) != CompareOptions.None)
				{
					CompareInfo.InvariantCreateSortKeyOrdinalIgnoreCase(source, array);
				}
				else
				{
					CompareInfo.InvariantCreateSortKeyOrdinal(source, array);
				}
			}
			return new SortKey(this, source, options, array);
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x000A9820 File Offset: 0x000A7A20
		private unsafe static void InvariantCreateSortKeyOrdinal(ReadOnlySpan<char> source, Span<byte> sortKey)
		{
			for (int i = 0; i < source.Length; i++)
			{
				BinaryPrimitives.WriteUInt16BigEndian(sortKey, *source[i]);
				sortKey = sortKey.Slice(2);
			}
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x000A9858 File Offset: 0x000A7A58
		private unsafe static void InvariantCreateSortKeyOrdinalIgnoreCase(ReadOnlySpan<char> source, Span<byte> sortKey)
		{
			int i = 0;
			while (i < source.Length)
			{
				char c = (char)(*source[i]);
				if (!char.IsHighSurrogate(c) || i >= source.Length - 1)
				{
					goto IL_76;
				}
				char c2 = (char)(*source[i + 1]);
				if (!char.IsLowSurrogate(c2))
				{
					goto IL_76;
				}
				char value;
				char value2;
				SurrogateCasing.ToUpper(c, c2, out value, out value2);
				Span<byte> destination = sortKey.Slice(0, 4);
				BinaryPrimitives.WriteUInt16BigEndian(destination, (ushort)value);
				BinaryPrimitives.WriteUInt16BigEndian(destination.Slice(2), (ushort)value2);
				sortKey = sortKey.Slice(4);
				i++;
				IL_8C:
				i++;
				continue;
				IL_76:
				BinaryPrimitives.WriteUInt16BigEndian(sortKey, (ushort)InvariantModeCasing.ToUpper(c));
				sortKey = sortKey.Slice(2);
				goto IL_8C;
			}
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x000A9902 File Offset: 0x000A7B02
		private static int InvariantGetSortKey(ReadOnlySpan<char> source, Span<byte> destination, CompareOptions options)
		{
			if (destination.Length < source.Length * 2)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
			{
				CompareInfo.InvariantCreateSortKeyOrdinal(source, destination);
			}
			else
			{
				CompareInfo.InvariantCreateSortKeyOrdinalIgnoreCase(source, destination);
			}
			return source.Length * 2;
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x000A9939 File Offset: 0x000A7B39
		private static int InvariantGetSortKeyLength(ReadOnlySpan<char> source, CompareOptions options)
		{
			int num = source.Length * 2;
			if (num < 0)
			{
				throw new ArgumentException(SR.ArgumentOutOfRange_GetByteCountOverflow, "source");
			}
			return num;
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000A9958 File Offset: 0x000A7B58
		private static int InvariantGetHashCode(ReadOnlySpan<char> source, CompareOptions options)
		{
			if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
			{
				return string.GetHashCode(source);
			}
			return string.GetHashCodeOrdinalIgnoreCase(source);
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x000A996C File Offset: 0x000A7B6C
		private void NlsInitSortHandle()
		{
			this._sortHandle = CompareInfo.NlsGetSortHandle(this._sortName);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x000A9980 File Offset: 0x000A7B80
		internal unsafe static IntPtr NlsGetSortHandle(string cultureName)
		{
			if (GlobalizationMode.Invariant)
			{
				return IntPtr.Zero;
			}
			IntPtr intPtr;
			if (Interop.Kernel32.LCMapStringEx(cultureName, 536870912U, null, 0, (void*)(&intPtr), 8, null, null, IntPtr.Zero) > 0)
			{
				int num = 0;
				char c = 'a';
				if (Interop.Kernel32.LCMapStringEx(null, 262144U, &c, 1, (void*)(&num), 4, null, null, intPtr) > 1)
				{
					return intPtr;
				}
			}
			return IntPtr.Zero;
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x000A99E4 File Offset: 0x000A7BE4
		private unsafe static int FindStringOrdinal(uint dwFindStringOrdinalFlags, ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool bIgnoreCase)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* lpStringSource = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(value))
				{
					char* lpStringValue = reference2;
					return Interop.Kernel32.FindStringOrdinal(dwFindStringOrdinalFlags, lpStringSource, source.Length, lpStringValue, value.Length, bIgnoreCase ? Interop.BOOL.TRUE : Interop.BOOL.FALSE);
				}
			}
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x000A9A22 File Offset: 0x000A7C22
		internal static int NlsIndexOfOrdinalCore(ReadOnlySpan<char> source, ReadOnlySpan<char> value, bool ignoreCase, bool fromBeginning)
		{
			return CompareInfo.FindStringOrdinal(fromBeginning ? 4194304U : 8388608U, source, value, ignoreCase);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x000A9A3C File Offset: 0x000A7C3C
		private unsafe int NlsGetHashCodeOfString(ReadOnlySpan<char> source, CompareOptions options)
		{
			if (!Environment.IsWindows8OrAbove)
			{
				source = source.ToString();
			}
			int num = source.Length;
			if (num == 0)
			{
				source = string.Empty;
				num = -1;
			}
			uint dwMapFlags = (uint)(1024 | CompareInfo.GetNativeCompareFlags(options));
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* lpSrcStr = reference;
				int num2 = Interop.Kernel32.LCMapStringEx((this._sortHandle != IntPtr.Zero) ? null : this._sortName, dwMapFlags, lpSrcStr, num, null, 0, null, null, this._sortHandle);
				if (num2 == 0)
				{
					throw new ArgumentException(SR.Arg_ExternalException);
				}
				byte[] array = null;
				Span<byte> span;
				if (num2 <= 512)
				{
					span = new Span<byte>(stackalloc byte[(UIntPtr)512], 512);
				}
				else
				{
					span = (array = ArrayPool<byte>.Shared.Rent(num2));
				}
				Span<byte> span2 = span;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(span2))
				{
					byte* lpDestStr = reference2;
					if (Interop.Kernel32.LCMapStringEx((this._sortHandle != IntPtr.Zero) ? null : this._sortName, dwMapFlags, lpSrcStr, num, (void*)lpDestStr, num2, null, null, this._sortHandle) != num2)
					{
						throw new ArgumentException(SR.Arg_ExternalException);
					}
				}
				int result = Marvin.ComputeHash32(span2.Slice(0, num2), Marvin.DefaultSeed);
				if (array != null)
				{
					ArrayPool<byte>.Shared.Return(array, false);
				}
				return result;
			}
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x000A9B84 File Offset: 0x000A7D84
		internal unsafe static int NlsCompareStringOrdinalIgnoreCase(ref char string1, int count1, ref char string2, int count2)
		{
			fixed (char* ptr = &string1)
			{
				char* lpString = ptr;
				fixed (char* ptr2 = &string2)
				{
					char* lpString2 = ptr2;
					int num = Interop.Kernel32.CompareStringOrdinal(lpString, count1, lpString2, count2, true);
					if (num == 0)
					{
						throw new ArgumentException(SR.Arg_ExternalException);
					}
					return num - 2;
				}
			}
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x000A9BB4 File Offset: 0x000A7DB4
		private unsafe int NlsCompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options)
		{
			object obj = (this._sortHandle != IntPtr.Zero) ? null : this._sortName;
			if (string1.IsEmpty)
			{
				string1 = string.Empty;
			}
			if (string2.IsEmpty)
			{
				string2 = string.Empty;
			}
			object obj2 = obj;
			char* lpLocaleName;
			if (obj2 == null)
			{
				lpLocaleName = null;
			}
			else
			{
				fixed (char* pinnableReference = obj2.GetPinnableReference())
				{
					lpLocaleName = pinnableReference;
				}
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(string1))
			{
				char* lpString = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(string2))
				{
					char* lpString2 = reference2;
					int num = Interop.Kernel32.CompareStringEx(lpLocaleName, (uint)CompareInfo.GetNativeCompareFlags(options), lpString, string1.Length, lpString2, string2.Length, null, null, this._sortHandle);
					if (num == 0)
					{
						throw new ArgumentException(SR.Arg_ExternalException);
					}
					return num - 2;
				}
			}
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x000A9C5C File Offset: 0x000A7E5C
		private unsafe int FindString(uint dwFindNLSStringFlags, ReadOnlySpan<char> lpStringSource, ReadOnlySpan<char> lpStringValue, int* pcchFound)
		{
			object obj = (this._sortHandle != IntPtr.Zero) ? null : this._sortName;
			int num = lpStringSource.Length;
			if (num == 0)
			{
				lpStringSource = string.Empty;
				num = -1;
			}
			object obj2 = obj;
			char* lpLocaleName;
			if (obj2 == null)
			{
				lpLocaleName = null;
			}
			else
			{
				fixed (char* pinnableReference = obj2.GetPinnableReference())
				{
					lpLocaleName = pinnableReference;
				}
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(lpStringSource))
			{
				char* lpStringSource2 = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(lpStringValue))
				{
					char* lpStringValue2 = reference2;
					return Interop.Kernel32.FindNLSStringEx(lpLocaleName, dwFindNLSStringFlags, lpStringSource2, num, lpStringValue2, lpStringValue.Length, pcchFound, null, null, this._sortHandle);
				}
			}
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x000A9CDC File Offset: 0x000A7EDC
		private unsafe int NlsIndexOfCore(ReadOnlySpan<char> source, ReadOnlySpan<char> target, CompareOptions options, int* matchLengthPtr, bool fromBeginning)
		{
			uint num = fromBeginning ? 4194304U : 8388608U;
			return this.FindString(num | (uint)CompareInfo.GetNativeCompareFlags(options), source, target, matchLengthPtr);
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x000A9D0C File Offset: 0x000A7F0C
		private unsafe bool NlsStartsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> prefix, CompareOptions options, int* matchLengthPtr)
		{
			int num = this.FindString((uint)(1048576 | CompareInfo.GetNativeCompareFlags(options)), source, prefix, matchLengthPtr);
			if (num >= 0)
			{
				if (matchLengthPtr != null)
				{
					*matchLengthPtr += num;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x000A9D44 File Offset: 0x000A7F44
		private unsafe bool NlsEndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options, int* matchLengthPtr)
		{
			int num = this.FindString((uint)(2097152 | CompareInfo.GetNativeCompareFlags(options)), source, suffix, null);
			if (num >= 0)
			{
				if (matchLengthPtr != null)
				{
					*matchLengthPtr = source.Length - num;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x000A9D84 File Offset: 0x000A7F84
		private unsafe SortKey NlsCreateSortKey(string source, CompareOptions options)
		{
			ArgumentNullException.ThrowIfNull(source, "source");
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException(SR.Argument_InvalidFlag, "options");
			}
			uint dwMapFlags = (uint)(1024 | CompareInfo.GetNativeCompareFlags(options));
			int num = source.Length;
			if (num == 0)
			{
				num = -1;
			}
			char* ptr;
			if (source == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = source.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* lpSrcStr = ptr;
			int num2 = Interop.Kernel32.LCMapStringEx((this._sortHandle != IntPtr.Zero) ? null : this._sortName, dwMapFlags, lpSrcStr, num, null, 0, null, null, this._sortHandle);
			if (num2 == 0)
			{
				throw new ArgumentException(SR.Arg_ExternalException);
			}
			byte[] array = new byte[num2];
			byte[] array2;
			byte* lpDestStr;
			if ((array2 = array) == null || array2.Length == 0)
			{
				lpDestStr = null;
			}
			else
			{
				lpDestStr = &array2[0];
			}
			if (Interop.Kernel32.LCMapStringEx((this._sortHandle != IntPtr.Zero) ? null : this._sortName, dwMapFlags, lpSrcStr, num, (void*)lpDestStr, array.Length, null, null, this._sortHandle) != num2)
			{
				throw new ArgumentException(SR.Arg_ExternalException);
			}
			array2 = null;
			char* ptr2 = null;
			return new SortKey(this, source, options, array);
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000A9E90 File Offset: 0x000A8090
		private unsafe int NlsGetSortKey(ReadOnlySpan<char> source, Span<byte> destination, CompareOptions options)
		{
			if (destination.IsEmpty)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			if (!Environment.IsWindows8OrAbove)
			{
				source = source.ToString();
			}
			uint dwMapFlags = (uint)(1024 | CompareInfo.GetNativeCompareFlags(options));
			int num = source.Length;
			if (num == 0)
			{
				source = string.Empty;
				num = -1;
			}
			int num3;
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* lpSrcStr = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(destination))
				{
					byte* lpDestStr = reference2;
					if (!Environment.IsWindows8OrAbove)
					{
						int num2 = Interop.Kernel32.LCMapStringEx((this._sortHandle != IntPtr.Zero) ? null : this._sortName, dwMapFlags, lpSrcStr, num, null, 0, null, null, this._sortHandle);
						if (num2 > destination.Length)
						{
							ThrowHelper.ThrowArgumentException_DestinationTooShort();
						}
						if (num2 <= 0)
						{
							throw new ArgumentException(SR.Arg_ExternalException);
						}
					}
					num3 = Interop.Kernel32.LCMapStringEx((this._sortHandle != IntPtr.Zero) ? null : this._sortName, dwMapFlags, lpSrcStr, num, (void*)lpDestStr, destination.Length, null, null, this._sortHandle);
				}
			}
			if (num3 > 0)
			{
				return num3;
			}
			if (Marshal.GetLastPInvokeError() == 122)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
				return num3;
			}
			throw new ArgumentException(SR.Arg_ExternalException);
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x000A9FA8 File Offset: 0x000A81A8
		private unsafe int NlsGetSortKeyLength(ReadOnlySpan<char> source, CompareOptions options)
		{
			uint dwMapFlags = (uint)(1024 | CompareInfo.GetNativeCompareFlags(options));
			int num = source.Length;
			if (num == 0)
			{
				source = string.Empty;
				num = -1;
			}
			int num2;
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* lpSrcStr = reference;
				num2 = Interop.Kernel32.LCMapStringEx((this._sortHandle != IntPtr.Zero) ? null : this._sortName, dwMapFlags, lpSrcStr, num, null, 0, null, null, this._sortHandle);
			}
			if (num2 <= 0)
			{
				throw new ArgumentException(SR.Arg_ExternalException);
			}
			return num2;
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x000AA024 File Offset: 0x000A8224
		private unsafe static bool NlsIsSortable(ReadOnlySpan<char> text)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(text))
			{
				char* lpString = reference;
				return Interop.Kernel32.IsNLSDefinedString(1, 0U, IntPtr.Zero, lpString, text.Length);
			}
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000AA050 File Offset: 0x000A8250
		private static int GetNativeCompareFlags(CompareOptions options)
		{
			int num = 134217728;
			if ((options & CompareOptions.IgnoreCase) != CompareOptions.None)
			{
				num |= 1;
			}
			if ((options & CompareOptions.IgnoreKanaType) != CompareOptions.None)
			{
				num |= 65536;
			}
			if ((options & CompareOptions.IgnoreNonSpace) != CompareOptions.None)
			{
				num |= 2;
			}
			if ((options & CompareOptions.IgnoreSymbols) != CompareOptions.None)
			{
				num |= 4;
			}
			if ((options & CompareOptions.IgnoreWidth) != CompareOptions.None)
			{
				num |= 131072;
			}
			if ((options & CompareOptions.StringSort) != CompareOptions.None)
			{
				num |= 4096;
			}
			if (options == CompareOptions.Ordinal)
			{
				num = 1073741824;
			}
			return num;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000AA0BC File Offset: 0x000A82BC
		private unsafe SortVersion NlsGetSortVersion()
		{
			Interop.Kernel32.NlsVersionInfoEx nlsVersionInfoEx = default(Interop.Kernel32.NlsVersionInfoEx);
			nlsVersionInfoEx.dwNLSVersionInfoSize = sizeof(Interop.Kernel32.NlsVersionInfoEx);
			Interop.Kernel32.GetNLSVersionEx(1, this._sortName, &nlsVersionInfoEx);
			return new SortVersion(nlsVersionInfoEx.dwNLSVersion, (nlsVersionInfoEx.dwEffectiveId == 0) ? this.LCID : nlsVersionInfoEx.dwEffectiveId, nlsVersionInfoEx.guidCustomVersion);
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000AA118 File Offset: 0x000A8318
		internal bool IsPrefixUtf8(ReadOnlySpan<byte> source, ReadOnlySpan<byte> prefix, CompareOptions options = CompareOptions.None)
		{
			if (prefix.IsEmpty)
			{
				return true;
			}
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth)) == CompareOptions.None)
			{
				if (!GlobalizationMode.Invariant)
				{
					return this.StartsWithCoreUtf8(source, prefix, options);
				}
				if ((options & CompareOptions.IgnoreCase) == CompareOptions.None)
				{
					return source.StartsWith(prefix);
				}
				return source.StartsWithOrdinalIgnoreCaseUtf8(prefix);
			}
			else
			{
				if (options == CompareOptions.Ordinal)
				{
					return source.StartsWith(prefix);
				}
				if (options == CompareOptions.OrdinalIgnoreCase)
				{
					return source.StartsWithOrdinalIgnoreCaseUtf8(prefix);
				}
				CompareInfo.ThrowCompareOptionsCheckFailed(options);
				return false;
			}
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x000AA184 File Offset: 0x000A8384
		private unsafe bool StartsWithCoreUtf8(ReadOnlySpan<byte> source, ReadOnlySpan<byte> prefix, CompareOptions options)
		{
			int maxCharCount = Encoding.UTF8.GetMaxCharCount(source.Length);
			char[] array;
			Span<char> span;
			if (maxCharCount <= 256)
			{
				array = null;
				span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			}
			else
			{
				array = ArrayPool<char>.Shared.Rent(maxCharCount);
				span = array.AsSpan(0, maxCharCount);
			}
			int num;
			int length;
			if (Utf8.ToUtf16PreservingReplacement(source, span, out num, out length, true, true) != OperationStatus.Done)
			{
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
				return false;
			}
			span = span.Slice(0, length);
			int maxCharCount2 = Encoding.UTF8.GetMaxCharCount(prefix.Length);
			char[] array2;
			Span<char> span2;
			if (maxCharCount2 < 256)
			{
				array2 = null;
				span2 = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			}
			else
			{
				array2 = ArrayPool<char>.Shared.Rent(maxCharCount2);
				span2 = array2.AsSpan(0, maxCharCount2);
			}
			int length2;
			if (Utf8.ToUtf16PreservingReplacement(prefix, span2, out num, out length2, true, true) != OperationStatus.Done)
			{
				if (array2 != null)
				{
					ArrayPool<char>.Shared.Return(array2, false);
				}
				if (array != null)
				{
					ArrayPool<char>.Shared.Return(array, false);
				}
				return false;
			}
			span2 = span2.Slice(0, length2);
			bool result = this.StartsWithCore(span, span2, options, null);
			if (array2 != null)
			{
				ArrayPool<char>.Shared.Return(array2, false);
			}
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x0400094A RID: 2378
		internal static readonly CompareInfo Invariant = CultureInfo.InvariantCulture.CompareInfo;

		// Token: 0x0400094B RID: 2379
		[OptionalField(VersionAdded = 2)]
		private string m_name;

		// Token: 0x0400094C RID: 2380
		[NonSerialized]
		private IntPtr _sortHandle;

		// Token: 0x0400094D RID: 2381
		[NonSerialized]
		private string _sortName;

		// Token: 0x0400094E RID: 2382
		[OptionalField(VersionAdded = 3)]
		private SortVersion m_SortVersion;

		// Token: 0x0400094F RID: 2383
		private int culture;

		// Token: 0x04000950 RID: 2384
		private static readonly SearchValues<char> s_nonSpecialAsciiChars = SearchValues.Create("\t\v\f !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~");

		// Token: 0x04000951 RID: 2385
		[NonSerialized]
		private bool _isAsciiEqualityOrdinal;

		// Token: 0x020002D0 RID: 720
		private static class SortHandleCache
		{
			// Token: 0x060034F5 RID: 13557 RVA: 0x000AA2EC File Offset: 0x000A84EC
			internal static IntPtr GetCachedSortHandle(string sortName)
			{
				Dictionary<string, IntPtr> obj = CompareInfo.SortHandleCache.s_sortNameToSortHandleCache;
				IntPtr result;
				lock (obj)
				{
					IntPtr intPtr;
					if (!CompareInfo.SortHandleCache.s_sortNameToSortHandleCache.TryGetValue(sortName, out intPtr))
					{
						Interop.Globalization.ResultCode sortHandle = Interop.Globalization.GetSortHandle(sortName, out intPtr);
						if (sortHandle == Interop.Globalization.ResultCode.OutOfMemory)
						{
							throw new OutOfMemoryException();
						}
						if (sortHandle != Interop.Globalization.ResultCode.Success)
						{
							throw new ExternalException(SR.Arg_ExternalException);
						}
						try
						{
							CompareInfo.SortHandleCache.s_sortNameToSortHandleCache.Add(sortName, intPtr);
						}
						catch
						{
							Interop.Globalization.CloseSortHandle(intPtr);
							throw;
						}
					}
					result = intPtr;
				}
				return result;
			}

			// Token: 0x04000952 RID: 2386
			private static readonly Dictionary<string, IntPtr> s_sortNameToSortHandleCache = new Dictionary<string, IntPtr>();
		}
	}
}
