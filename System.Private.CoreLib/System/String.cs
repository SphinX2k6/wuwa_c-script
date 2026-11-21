using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Versioning;
using System.Text;
using System.Text.Unicode;

namespace System
{
	// Token: 0x02000098 RID: 152
	[NullableContext(1)]
	[Nullable(0)]
	[NonVersionable]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class String : IComparable, IEnumerable, IConvertible, IEnumerable<char>, IComparable<string>, IEquatable<string>, ICloneable, ISpanParsable<string>, IParsable<string>
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x00015B19 File Offset: 0x00013D19
		public static string Intern(string str)
		{
			ArgumentNullException.ThrowIfNull(str, "str");
			return string.InternalIntern(str);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00015B2C File Offset: 0x00013D2C
		public static string IsInterned(string str)
		{
			ArgumentNullException.ThrowIfNull(str, "str");
			return string.InternalIsInterned(str);
		}

		// Token: 0x0600067E RID: 1662
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern string FastAllocateString(int length);

		// Token: 0x0600067F RID: 1663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string InternalIsInterned(string str);

		// Token: 0x06000680 RID: 1664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string InternalIntern(string str);

		// Token: 0x06000681 RID: 1665 RVA: 0x00015B40 File Offset: 0x00013D40
		private unsafe static void memset(byte* dest, int val, int len)
		{
			if (len < 8)
			{
				while (len != 0)
				{
					*dest = (byte)val;
					dest++;
					len--;
				}
				return;
			}
			long num = (long)val;
			if (num != 0L)
			{
				num |= num << 8;
				num |= num << 16;
				num |= num << 32;
			}
			int num2 = dest & 7;
			if (num2 != 0)
			{
				num2 = 8 - num2;
				len -= num2;
				do
				{
					*dest = (byte)val;
					dest++;
					num2--;
				}
				while (num2 != 0);
			}
			while (len >= 16)
			{
				*(long*)dest = num;
				*(long*)(dest + 8) = num;
				dest += 16;
				len -= 16;
			}
			while (len >= 8)
			{
				*(long*)dest = num;
				dest += 8;
				len -= 8;
			}
			while (len > 0)
			{
				*dest = (byte)val;
				dest++;
				len--;
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00015BE2 File Offset: 0x00013DE2
		private unsafe static void memcpy(byte* dest, byte* src, int size)
		{
			SpanHelpers.Memmove(ref *dest, ref *src, (UIntPtr)((IntPtr)size));
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00015BED File Offset: 0x00013DED
		internal unsafe static void bzero(byte* dest, int len)
		{
			string.memset(dest, 0, len);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00015BF7 File Offset: 0x00013DF7
		internal unsafe static void bzero_aligned_1(byte* dest, int len)
		{
			*dest = 0;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00015BFC File Offset: 0x00013DFC
		internal unsafe static void bzero_aligned_2(byte* dest, int len)
		{
			*(short*)dest = 0;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00015C01 File Offset: 0x00013E01
		internal unsafe static void bzero_aligned_4(byte* dest, int len)
		{
			*(int*)dest = 0;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00015C06 File Offset: 0x00013E06
		internal unsafe static void bzero_aligned_8(byte* dest, int len)
		{
			*(long*)dest = 0L;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00015C0C File Offset: 0x00013E0C
		internal unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
			*dest = *src;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00015C12 File Offset: 0x00013E12
		internal unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
			*(short*)dest = *(short*)src;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00015C18 File Offset: 0x00013E18
		internal unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
			*(int*)dest = *(int*)src;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00015C1E File Offset: 0x00013E1E
		internal unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
			*(long*)dest = *(long*)src;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00015C24 File Offset: 0x00013E24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool EqualsHelper(string strA, string strB)
		{
			return SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(strA.GetRawStringData()), Unsafe.As<char, byte>(strB.GetRawStringData()), (UIntPtr)(strA.Length * 2));
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00015C4A File Offset: 0x00013E4A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
		{
			return SpanHelpers.SequenceCompareTo(Unsafe.Add<char>(strA.GetRawStringData(), (IntPtr)((UIntPtr)indexA)), countA, Unsafe.Add<char>(strB.GetRawStringData(), (IntPtr)((UIntPtr)indexB)), countB);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00015C6F File Offset: 0x00013E6F
		internal static bool EqualsOrdinalIgnoreCase(string strA, string strB)
		{
			return strA == strB || (strA != null && strB != null && strA.Length == strB.Length && string.EqualsOrdinalIgnoreCaseNoLengthCheck(strA, strB));
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00015C96 File Offset: 0x00013E96
		private static bool EqualsOrdinalIgnoreCaseNoLengthCheck(string strA, string strB)
		{
			return Ordinal.EqualsIgnoreCase(strA.GetRawStringData(), strB.GetRawStringData(), strB.Length);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00015CB0 File Offset: 0x00013EB0
		private unsafe static int CompareOrdinalHelper(string strA, string strB)
		{
			int i = Math.Min(strA.Length, strB.Length);
			fixed (char* ptr = &strA._firstChar)
			{
				char* ptr2 = ptr;
				fixed (char* ptr3 = &strB._firstChar)
				{
					char* ptr4 = ptr3;
					char* ptr5 = ptr2;
					char* ptr6 = ptr4;
					if (ptr5[1] == ptr6[1])
					{
						i -= 2;
						ptr5 += 2;
						ptr6 += 2;
						while (i >= 12)
						{
							if (*(long*)ptr5 == *(long*)ptr6)
							{
								if (*(long*)(ptr5 + 4) == *(long*)(ptr6 + 4))
								{
									if (*(long*)(ptr5 + 8) == *(long*)(ptr6 + 8))
									{
										i -= 12;
										ptr5 += 12;
										ptr6 += 12;
										continue;
									}
									ptr5 += 4;
									ptr6 += 4;
								}
								ptr5 += 4;
								ptr6 += 4;
							}
							if (*(int*)ptr5 == *(int*)ptr6)
							{
								ptr5 += 2;
								ptr6 += 2;
							}
							IL_10E:
							if (*ptr5 != *ptr6)
							{
								return (int)(*ptr5 - *ptr6);
							}
							goto IL_11E;
						}
						while (i > 0)
						{
							if (*(int*)ptr5 != *(int*)ptr6)
							{
								goto IL_10E;
							}
							i -= 2;
							ptr5 += 2;
							ptr6 += 2;
						}
						return strA.Length - strB.Length;
					}
					IL_11E:
					return (int)(ptr5[1] - ptr6[1]);
				}
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00015DE6 File Offset: 0x00013FE6
		[NullableContext(2)]
		public static int Compare(string strA, string strB)
		{
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00015DF0 File Offset: 0x00013FF0
		[NullableContext(2)]
		public static int Compare(string strA, string strB, bool ignoreCase)
		{
			StringComparison comparisonType = ignoreCase ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
			return string.Compare(strA, strB, comparisonType);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00015E10 File Offset: 0x00014010
		[NullableContext(2)]
		public static int Compare(string strA, string strB, StringComparison comparisonType)
		{
			if (strA == strB)
			{
				string.CheckStringComparison(comparisonType);
				return 0;
			}
			if (strA == null)
			{
				string.CheckStringComparison(comparisonType);
				return -1;
			}
			if (strB == null)
			{
				string.CheckStringComparison(comparisonType);
				return 1;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(strA, strB, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.Ordinal:
				if (strA._firstChar != strB._firstChar)
				{
					return (int)(strA._firstChar - strB._firstChar);
				}
				return string.CompareOrdinalHelper(strA, strB);
			case StringComparison.OrdinalIgnoreCase:
				return Ordinal.CompareStringIgnoreCase(strA.GetRawStringData(), strA.Length, strB.GetRawStringData(), strB.Length);
			default:
				throw new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00015EDB File Offset: 0x000140DB
		[NullableContext(2)]
		public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
		{
			return (culture ?? CultureInfo.CurrentCulture).CompareInfo.Compare(strA, strB, options);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00015EF4 File Offset: 0x000140F4
		[NullableContext(2)]
		public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
		{
			CompareOptions options = ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None;
			return string.Compare(strA, strB, culture, options);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00015F12 File Offset: 0x00014112
		[NullableContext(2)]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length)
		{
			return string.Compare(strA, indexA, strB, indexB, length, false);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00015F20 File Offset: 0x00014120
		[NullableContext(2)]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase)
		{
			int num = length;
			int num2 = length;
			if (strA != null)
			{
				num = Math.Min(num, strA.Length - indexA);
			}
			if (strB != null)
			{
				num2 = Math.Min(num2, strB.Length - indexB);
			}
			CompareOptions options = ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None;
			return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, options);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00015F78 File Offset: 0x00014178
		[NullableContext(2)]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture)
		{
			CompareOptions options = ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None;
			return string.Compare(strA, indexA, strB, indexB, length, culture, options);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00015F9C File Offset: 0x0001419C
		[NullableContext(2)]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options)
		{
			CultureInfo cultureInfo = culture ?? CultureInfo.CurrentCulture;
			int num = length;
			int num2 = length;
			if (strA != null)
			{
				num = Math.Min(num, strA.Length - indexA);
			}
			if (strB != null)
			{
				num2 = Math.Min(num2, strB.Length - indexB);
			}
			return cultureInfo.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, options);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00015FF0 File Offset: 0x000141F0
		[NullableContext(2)]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			if (strA == null || strB == null)
			{
				if (strA == strB)
				{
					return 0;
				}
				if (strA != null)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
				if (indexA < 0 || indexB < 0)
				{
					throw new ArgumentOutOfRangeException((indexA < 0) ? "indexA" : "indexB", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				if (strA.Length - indexA < 0 || strB.Length - indexB < 0)
				{
					throw new ArgumentOutOfRangeException((strA.Length - indexA < 0) ? "indexA" : "indexB", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				if (length == 0 || (strA == strB && indexA == indexB))
				{
					return 0;
				}
				int num = Math.Min(length, strA.Length - indexA);
				int num2 = Math.Min(length, strB.Length - indexB);
				switch (comparisonType)
				{
				case StringComparison.CurrentCulture:
				case StringComparison.CurrentCultureIgnoreCase:
					return CultureInfo.CurrentCulture.CompareInfo.Compare(strA, indexA, num, strB, indexB, num2, string.GetCaseCompareOfComparisonCulture(comparisonType));
				case StringComparison.InvariantCulture:
				case StringComparison.InvariantCultureIgnoreCase:
					return CompareInfo.Invariant.Compare(strA, indexA, num, strB, indexB, num2, string.GetCaseCompareOfComparisonCulture(comparisonType));
				case StringComparison.Ordinal:
					return string.CompareOrdinalHelper(strA, indexA, num, strB, indexB, num2);
				default:
					return Ordinal.CompareStringIgnoreCase(Unsafe.Add<char>(strA.GetRawStringData(), indexA), num, Unsafe.Add<char>(strB.GetRawStringData(), indexB), num2);
				}
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00016129 File Offset: 0x00014329
		[NullableContext(2)]
		public static int CompareOrdinal(string strA, string strB)
		{
			if (strA == strB)
			{
				return 0;
			}
			if (strA == null)
			{
				return -1;
			}
			if (strB == null)
			{
				return 1;
			}
			if (strA._firstChar != strB._firstChar)
			{
				return (int)(strA._firstChar - strB._firstChar);
			}
			return string.CompareOrdinalHelper(strA, strB);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001615E File Offset: 0x0001435E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			return SpanHelpers.SequenceCompareTo(MemoryMarshal.GetReference<char>(strA), strA.Length, MemoryMarshal.GetReference<char>(strB), strB.Length);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00016180 File Offset: 0x00014380
		[NullableContext(2)]
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			if (strA == null || strB == null)
			{
				if (strA == strB)
				{
					return 0;
				}
				if (strA != null)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
				if (indexA < 0 || indexB < 0)
				{
					throw new ArgumentOutOfRangeException((indexA < 0) ? "indexA" : "indexB", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				int num = Math.Min(length, strA.Length - indexA);
				int num2 = Math.Min(length, strB.Length - indexB);
				if (num < 0 || num2 < 0)
				{
					throw new ArgumentOutOfRangeException((num < 0) ? "indexA" : "indexB", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				if (length == 0 || (strA == strB && indexA == indexB))
				{
					return 0;
				}
				return string.CompareOrdinalHelper(strA, indexA, num, strB, indexB, num2);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001622C File Offset: 0x0001442C
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			string text = value as string;
			if (text == null)
			{
				throw new ArgumentException(SR.Arg_MustBeString);
			}
			return this.CompareTo(text);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00015DE6 File Offset: 0x00013FE6
		[NullableContext(2)]
		public int CompareTo(string strB)
		{
			return string.Compare(this, strB, StringComparison.CurrentCulture);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001625A File Offset: 0x0001445A
		public bool EndsWith(string value)
		{
			return this.EndsWith(value, StringComparison.CurrentCulture);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00016264 File Offset: 0x00014464
		[Intrinsic]
		public bool EndsWith(string value, StringComparison comparisonType)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value.Length == 0)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsSuffix(this, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsSuffix(this, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.Ordinal:
			{
				int num = this.Length - value.Length;
				return num <= this.Length && this.AsSpan(num).SequenceEqual(value);
			}
			case StringComparison.OrdinalIgnoreCase:
				return this.Length >= value.Length && Ordinal.EqualsIgnoreCase(Unsafe.Add<char>(this.GetRawStringData(), this.Length - value.Length), value.GetRawStringData(), value.Length);
			default:
				throw new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001635B File Offset: 0x0001455B
		public bool EndsWith(string value, bool ignoreCase, [Nullable(2)] CultureInfo culture)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			return this == value || (culture ?? CultureInfo.CurrentCulture).CompareInfo.IsSuffix(this, value, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001638C File Offset: 0x0001458C
		public unsafe bool EndsWith(char value)
		{
			if (RuntimeHelpers.IsKnownConstant(value) && value != '\0')
			{
				UIntPtr uintPtr = (UIntPtr)this.Length;
				return *Unsafe.Add<char>(ref this._firstChar, (IntPtr)(uintPtr - (UIntPtr)((IntPtr)1))) == value;
			}
			int num = this.Length - 1;
			return num < this.Length && this[num] == value;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000163E0 File Offset: 0x000145E0
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (this == obj)
			{
				return true;
			}
			string text = obj as string;
			return text != null && this.Length == text.Length && string.EqualsHelper(this, text);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00016416 File Offset: 0x00014616
		[NullableContext(2)]
		[Intrinsic]
		public bool Equals([NotNullWhen(true)] string value)
		{
			return this == value || (value != null && this.Length == value.Length && string.EqualsHelper(this, value));
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001643C File Offset: 0x0001463C
		[NullableContext(2)]
		[Intrinsic]
		public bool Equals([NotNullWhen(true)] string value, StringComparison comparisonType)
		{
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value == null)
			{
				string.CheckStringComparison(comparisonType);
				return false;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(this, value, string.GetCaseCompareOfComparisonCulture(comparisonType)) == 0;
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(this, value, string.GetCaseCompareOfComparisonCulture(comparisonType)) == 0;
			case StringComparison.Ordinal:
				return this.Length == value.Length && string.EqualsHelper(this, value);
			case StringComparison.OrdinalIgnoreCase:
				return this.Length == value.Length && string.EqualsOrdinalIgnoreCaseNoLengthCheck(this, value);
			default:
				throw new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000164F0 File Offset: 0x000146F0
		[NullableContext(2)]
		[Intrinsic]
		public static bool Equals(string a, string b)
		{
			return a == b || (a != null && b != null && a.Length == b.Length && string.EqualsHelper(a, b));
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00016518 File Offset: 0x00014718
		[NullableContext(2)]
		[Intrinsic]
		public static bool Equals(string a, string b, StringComparison comparisonType)
		{
			if (a == b)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (a == null || b == null)
			{
				string.CheckStringComparison(comparisonType);
				return false;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(a, b, string.GetCaseCompareOfComparisonCulture(comparisonType)) == 0;
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(a, b, string.GetCaseCompareOfComparisonCulture(comparisonType)) == 0;
			case StringComparison.Ordinal:
				return a.Length == b.Length && string.EqualsHelper(a, b);
			case StringComparison.OrdinalIgnoreCase:
				return a.Length == b.Length && string.EqualsOrdinalIgnoreCaseNoLengthCheck(a, b);
			default:
				throw new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000165CF File Offset: 0x000147CF
		[NullableContext(2)]
		public static bool operator ==(string a, string b)
		{
			return string.Equals(a, b);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000165D8 File Offset: 0x000147D8
		[NullableContext(2)]
		public static bool operator !=(string a, string b)
		{
			return !string.Equals(a, b);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000165E4 File Offset: 0x000147E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			ulong defaultSeed = Marvin.DefaultSeed;
			return Marvin.ComputeHash32(Unsafe.As<char, byte>(ref this._firstChar), (uint)(this._stringLength * 2), (uint)defaultSeed, (uint)(defaultSeed >> 32));
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00016616 File Offset: 0x00014816
		public int GetHashCode(StringComparison comparisonType)
		{
			return StringComparer.FromComparison(comparisonType).GetHashCode(this);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00016624 File Offset: 0x00014824
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal int GetHashCodeOrdinalIgnoreCase()
		{
			ulong defaultSeed = Marvin.DefaultSeed;
			return Marvin.ComputeHash32OrdinalIgnoreCase(ref this._firstChar, this._stringLength, (uint)defaultSeed, (uint)(defaultSeed >> 32));
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00016650 File Offset: 0x00014850
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetHashCode(ReadOnlySpan<char> value)
		{
			ulong defaultSeed = Marvin.DefaultSeed;
			return Marvin.ComputeHash32(Unsafe.As<char, byte>(MemoryMarshal.GetReference<char>(value)), (uint)(value.Length * 2), (uint)defaultSeed, (uint)(defaultSeed >> 32));
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00016684 File Offset: 0x00014884
		[NullableContext(0)]
		public static int GetHashCode(ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.GetHashCode(value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.GetHashCode(value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.Ordinal:
				return string.GetHashCode(value);
			case StringComparison.OrdinalIgnoreCase:
				return string.GetHashCodeOrdinalIgnoreCase(value);
			default:
				ThrowHelper.ThrowArgumentException(ExceptionResource.NotSupported_StringComparison, ExceptionArgument.comparisonType);
				return 0;
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000166F4 File Offset: 0x000148F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int GetHashCodeOrdinalIgnoreCase(ReadOnlySpan<char> value)
		{
			ulong defaultSeed = Marvin.DefaultSeed;
			return Marvin.ComputeHash32OrdinalIgnoreCase(MemoryMarshal.GetReference<char>(value), value.Length, (uint)defaultSeed, (uint)(defaultSeed >> 32));
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00016720 File Offset: 0x00014920
		internal unsafe int GetNonRandomizedHashCode()
		{
			fixed (char* ptr = &this._firstChar)
			{
				uint* ptr2 = (uint*)ptr;
				uint num = 352654597U;
				uint num2 = num;
				uint* ptr3 = ptr2;
				int i = this.Length;
				while (i > 2)
				{
					i -= 4;
					num = (BitOperations.RotateLeft(num, 5) + num ^ *ptr3);
					num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ ptr3[1]);
					ptr3 += 2;
				}
				if (i > 0)
				{
					num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ *ptr3);
				}
				return (int)(num + num2 * 1566083941U);
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00016794 File Offset: 0x00014994
		internal unsafe static int GetNonRandomizedHashCode(ReadOnlySpan<char> span)
		{
			uint num = 352654597U;
			uint num2 = num;
			int num3 = span.Length;
			fixed (char* reference = MemoryMarshal.GetReference<char>(span))
			{
				uint* ptr = (uint*)reference;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_C6;
					case 1:
						goto IL_AD;
					case 2:
						goto IL_99;
					case 3:
						goto IL_6A;
					default:
						do
						{
							num3 -= 4;
							num = (BitOperations.RotateLeft(num, 5) + num ^ Unsafe.ReadUnaligned<uint>((void*)ptr));
							num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ Unsafe.ReadUnaligned<uint>((void*)(ptr + 1)));
							ptr += 2;
						}
						while (num3 >= 4);
						break;
					}
				}
				IL_6A:
				num = (BitOperations.RotateLeft(num, 5) + num ^ Unsafe.ReadUnaligned<uint>((void*)ptr));
				uint num4 = (uint)(*(ushort*)(ptr + 1));
				if (!BitConverter.IsLittleEndian)
				{
				}
				num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ num4);
				goto IL_C6;
				IL_99:
				num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ Unsafe.ReadUnaligned<uint>((void*)ptr));
				goto IL_C6;
				IL_AD:
				uint num5 = (uint)(*(ushort*)ptr);
				if (!BitConverter.IsLittleEndian)
				{
				}
				num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ num5);
				IL_C6:;
			}
			return (int)(num + num2 * 1566083941U);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00016874 File Offset: 0x00014A74
		internal unsafe int GetNonRandomizedHashCodeOrdinalIgnoreCase()
		{
			uint num = 352654597U;
			uint num2 = num;
			int i = this.Length;
			try
			{
				fixed (char* ptr = &this._firstChar)
				{
					uint* ptr2 = (uint*)ptr;
					while (i > 2)
					{
						uint num3 = *ptr2;
						uint num4 = ptr2[1];
						if (!Utf16Utility.AllCharsInUInt32AreAscii(num3 | num4))
						{
							goto IL_A4;
						}
						i -= 4;
						num = (BitOperations.RotateLeft(num, 5) + num ^ (num3 | 2097184U));
						num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ (num4 | 2097184U));
						ptr2 += 2;
					}
					if (i > 0)
					{
						uint num5 = *ptr2;
						if (!Utf16Utility.AllCharsInUInt32AreAscii(num5))
						{
							goto IL_A4;
						}
						num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ (num5 | 2097184U));
					}
				}
			}
			finally
			{
				char* ptr = null;
			}
			return (int)(num + num2 * 1566083941U);
			IL_A4:
			return string.GetNonRandomizedHashCodeOrdinalIgnoreCaseSlow(num, num2, this.AsSpan(this.Length - i));
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001694C File Offset: 0x00014B4C
		internal unsafe static int GetNonRandomizedHashCodeOrdinalIgnoreCase(ReadOnlySpan<char> span)
		{
			uint num = 352654597U;
			uint num2 = num;
			int num3 = span.Length;
			try
			{
				fixed (char* ptr = MemoryMarshal.GetReference<char>(span))
				{
					uint* ptr2 = (uint*)ptr;
					uint num4;
					uint num5;
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_124;
						case 1:
							goto IL_100;
						case 2:
							goto IL_DA;
						case 3:
							goto IL_90;
						default:
							do
							{
								num4 = Unsafe.ReadUnaligned<uint>((void*)ptr2);
								num5 = Unsafe.ReadUnaligned<uint>((void*)(ptr2 + 1));
								if (!Utf16Utility.AllCharsInUInt32AreAscii(num4 | num5))
								{
									goto Block_3;
								}
								num3 -= 4;
								num = (BitOperations.RotateLeft(num, 5) + num ^ (num4 | 2097184U));
								num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ (num5 | 2097184U));
								ptr2 += 2;
							}
							while (num3 >= 4);
							break;
						}
					}
					Block_3:
					goto IL_135;
					IL_90:
					num4 = Unsafe.ReadUnaligned<uint>((void*)ptr2);
					num5 = (uint)(*(ushort*)(ptr2 + 1));
					if (!BitConverter.IsLittleEndian)
					{
					}
					if (!Utf16Utility.AllCharsInUInt32AreAscii(num4 | num5))
					{
						goto IL_135;
					}
					num = (BitOperations.RotateLeft(num, 5) + num ^ (num4 | 2097184U));
					num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ (num5 | 2097184U));
					goto IL_12B;
					IL_DA:
					num4 = Unsafe.ReadUnaligned<uint>((void*)ptr2);
					if (!Utf16Utility.AllCharsInUInt32AreAscii(num4))
					{
						goto IL_135;
					}
					num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ (num4 | 2097184U));
					goto IL_12B;
					IL_100:
					num4 = (uint)(*(ushort*)ptr2);
					if (!BitConverter.IsLittleEndian)
					{
					}
					if (num4 > 127U)
					{
						goto IL_135;
					}
					num2 = (BitOperations.RotateLeft(num2, 5) + num2 ^ (num4 | 2097184U));
					IL_124:;
				}
			}
			finally
			{
				char* ptr = null;
			}
			IL_12B:
			return (int)(num + num2 * 1566083941U);
			IL_135:
			return string.GetNonRandomizedHashCodeOrdinalIgnoreCaseSlow(num, num2, span.Slice(span.Length - num3));
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00016AC4 File Offset: 0x00014CC4
		private unsafe static int GetNonRandomizedHashCodeOrdinalIgnoreCaseSlow(uint hash1, uint hash2, ReadOnlySpan<char> str)
		{
			int i = str.Length;
			char[] array = null;
			Span<char> span;
			if (i < 256)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(i + 1));
			}
			Span<char> destination = span;
			Ordinal.ToUpperOrdinal(str, destination);
			*destination[i] = '\0';
			fixed (char* pinnableReference = destination.GetPinnableReference())
			{
				uint* ptr = (uint*)pinnableReference;
				while (i > 2)
				{
					i -= 4;
					hash1 = (BitOperations.RotateLeft(hash1, 5) + hash1 ^ (*ptr | 2097184U));
					hash2 = (BitOperations.RotateLeft(hash2, 5) + hash2 ^ (ptr[1] | 2097184U));
					ptr += 2;
				}
				if (i > 0)
				{
					hash2 = (BitOperations.RotateLeft(hash2, 5) + hash2 ^ (*ptr | 2097184U));
				}
			}
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return (int)(hash1 + hash2 * 1566083941U);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00016BA3 File Offset: 0x00014DA3
		public bool StartsWith(string value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			return this.StartsWith(value, StringComparison.CurrentCulture);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00016BB8 File Offset: 0x00014DB8
		[Intrinsic]
		public bool StartsWith(string value, StringComparison comparisonType)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			if (this == value)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			if (value.Length == 0)
			{
				string.CheckStringComparison(comparisonType);
				return true;
			}
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix(this, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsPrefix(this, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.Ordinal:
				return this.Length >= value.Length && this._firstChar == value._firstChar && (value.Length == 1 || SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(this.GetRawStringData()), Unsafe.As<char, byte>(value.GetRawStringData()), (UIntPtr)((IntPtr)value.Length * (IntPtr)2)));
			case StringComparison.OrdinalIgnoreCase:
				return this.Length >= value.Length && Ordinal.EqualsIgnoreCase(this.GetRawStringData(), value.GetRawStringData(), value.Length);
			default:
				throw new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00016CC0 File Offset: 0x00014EC0
		public bool StartsWith(string value, bool ignoreCase, [Nullable(2)] CultureInfo culture)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			return this == value || (culture ?? CultureInfo.CurrentCulture).CompareInfo.IsPrefix(this, value, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00016CF0 File Offset: 0x00014EF0
		public bool StartsWith(char value)
		{
			if (RuntimeHelpers.IsKnownConstant(value) && value != '\0')
			{
				return this._firstChar == value;
			}
			return this.Length != 0 && this._firstChar == value;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00016D1A File Offset: 0x00014F1A
		internal static void CheckStringComparison(StringComparison comparisonType)
		{
			if (comparisonType > StringComparison.OrdinalIgnoreCase)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.NotSupported_StringComparison, ExceptionArgument.comparisonType);
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00016D29 File Offset: 0x00014F29
		internal static CompareOptions GetCaseCompareOfComparisonCulture(StringComparison comparisonType)
		{
			return (CompareOptions)(comparisonType & StringComparison.CurrentCultureIgnoreCase);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00016D2E File Offset: 0x00014F2E
		private static CompareOptions GetCompareOptionsFromOrdinalStringComparison(StringComparison comparisonType)
		{
			return (CompareOptions)((comparisonType & -comparisonType) << 28);
		}

		// Token: 0x060006BD RID: 1725
		[NullableContext(2)]
		[DynamicDependency("Ctor(System.Char[])")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char[] value);

		// Token: 0x060006BE RID: 1726 RVA: 0x00016D38 File Offset: 0x00014F38
		private static string Ctor(char[] value)
		{
			if (value == null || value.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(value.Length);
			UIntPtr elementCount = (UIntPtr)text.Length;
			Buffer.Memmove<char>(ref text._firstChar, MemoryMarshal.GetArrayDataReference<char>(value), elementCount);
			return text;
		}

		// Token: 0x060006BF RID: 1727
		[DynamicDependency("Ctor(System.Char[],System.Int32,System.Int32)")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char[] value, int startIndex, int length);

		// Token: 0x060006C0 RID: 1728 RVA: 0x00016D74 File Offset: 0x00014F74
		private static string Ctor(char[] value, int startIndex, int length)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(startIndex, value.Length - length, "startIndex");
			if (length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(length);
			UIntPtr elementCount = (UIntPtr)text.Length;
			Buffer.Memmove<char>(ref text._firstChar, Unsafe.Add<char>(MemoryMarshal.GetArrayDataReference<char>(value), startIndex), elementCount);
			return text;
		}

		// Token: 0x060006C1 RID: 1729
		[NullableContext(0)]
		[CLSCompliant(false)]
		[DynamicDependency("Ctor(System.Char*)")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(char* value);

		// Token: 0x060006C2 RID: 1730 RVA: 0x00016DE4 File Offset: 0x00014FE4
		private unsafe static string Ctor(char* ptr)
		{
			if (ptr == null)
			{
				return string.Empty;
			}
			int num = string.wcslen(ptr);
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			UIntPtr elementCount = (UIntPtr)text.Length;
			Buffer.Memmove<char>(ref text._firstChar, ref *ptr, elementCount);
			return text;
		}

		// Token: 0x060006C3 RID: 1731
		[NullableContext(0)]
		[CLSCompliant(false)]
		[DynamicDependency("Ctor(System.Char*,System.Int32,System.Int32)")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(char* value, int startIndex, int length);

		// Token: 0x060006C4 RID: 1732 RVA: 0x00016E28 File Offset: 0x00015028
		private unsafe static string Ctor(char* ptr, int startIndex, int length)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			char* ptr2 = ptr + startIndex;
			if (ptr2 < ptr)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_PartialWCHAR);
			}
			if (length == 0)
			{
				return string.Empty;
			}
			if (ptr == null)
			{
				throw new ArgumentOutOfRangeException("ptr", SR.ArgumentOutOfRange_PartialWCHAR);
			}
			string text = string.FastAllocateString(length);
			UIntPtr elementCount = (UIntPtr)text.Length;
			Buffer.Memmove<char>(ref text._firstChar, ref *ptr2, elementCount);
			return text;
		}

		// Token: 0x060006C5 RID: 1733
		[NullableContext(0)]
		[CLSCompliant(false)]
		[DynamicDependency("Ctor(System.SByte*)")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(sbyte* value);

		// Token: 0x060006C6 RID: 1734 RVA: 0x00016EA0 File Offset: 0x000150A0
		private unsafe static string Ctor(sbyte* value)
		{
			if (value == null)
			{
				return string.Empty;
			}
			int numBytes = string.strlen((byte*)value);
			return string.CreateStringForSByteConstructor((byte*)value, numBytes);
		}

		// Token: 0x060006C7 RID: 1735
		[NullableContext(0)]
		[CLSCompliant(false)]
		[DynamicDependency("Ctor(System.SByte*,System.Int32,System.Int32)")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(sbyte* value, int startIndex, int length);

		// Token: 0x060006C8 RID: 1736 RVA: 0x00016EC8 File Offset: 0x000150C8
		private unsafe static string Ctor(sbyte* value, int startIndex, int length)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			if (value == null)
			{
				if (length == 0)
				{
					return string.Empty;
				}
				ArgumentNullException.Throw("value");
			}
			byte* ptr = (byte*)(value + startIndex);
			if (ptr < (byte*)value)
			{
				throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_PartialWCHAR);
			}
			return string.CreateStringForSByteConstructor(ptr, length);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00016F24 File Offset: 0x00015124
		private unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
		{
			if (numBytes == 0)
			{
				return string.Empty;
			}
			int num = Interop.Kernel32.MultiByteToWideChar(0U, 1U, pb, numBytes, null, 0);
			if (num == 0)
			{
				throw new ArgumentException(SR.Arg_InvalidANSIString);
			}
			string text = string.FastAllocateString(num);
			fixed (char* ptr = &text._firstChar)
			{
				char* lpWideCharStr = ptr;
				num = Interop.Kernel32.MultiByteToWideChar(0U, 1U, pb, numBytes, lpWideCharStr, num);
			}
			if (num == 0)
			{
				throw new ArgumentException(SR.Arg_InvalidANSIString);
			}
			return text;
		}

		// Token: 0x060006CA RID: 1738
		[NullableContext(0)]
		[CLSCompliant(false)]
		[DynamicDependency("Ctor(System.SByte*,System.Int32,System.Int32,System.Text.Encoding)")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe extern String(sbyte* value, int startIndex, int length, [Nullable(1)] Encoding enc);

		// Token: 0x060006CB RID: 1739 RVA: 0x00016F84 File Offset: 0x00015184
		private unsafe static string Ctor(sbyte* value, int startIndex, int length, Encoding enc)
		{
			if (enc == null)
			{
				return new string(value, startIndex, length);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			if (value == null)
			{
				if (length == 0)
				{
					return string.Empty;
				}
				ArgumentNullException.Throw("value");
			}
			byte* ptr = (byte*)(value + startIndex);
			if (ptr < (byte*)value)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_PartialWCHAR);
			}
			return enc.GetString(new ReadOnlySpan<byte>((void*)ptr, length));
		}

		// Token: 0x060006CC RID: 1740
		[DynamicDependency("Ctor(System.Char,System.Int32)")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(char c, int count);

		// Token: 0x060006CD RID: 1741 RVA: 0x00016FF0 File Offset: 0x000151F0
		private static string Ctor(char c, int count)
		{
			if (count <= 0)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				return string.Empty;
			}
			string text = string.FastAllocateString(count);
			if (c != '\0')
			{
				SpanHelpers.Fill<char>(ref text._firstChar, (UIntPtr)count, c);
			}
			return text;
		}

		// Token: 0x060006CE RID: 1742
		[NullableContext(0)]
		[DynamicDependency("Ctor(System.ReadOnlySpan{System.Char})")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern String(ReadOnlySpan<char> value);

		// Token: 0x060006CF RID: 1743 RVA: 0x0001702B File Offset: 0x0001522B
		private static string Ctor(ReadOnlySpan<char> value)
		{
			if (value.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(value.Length);
			Buffer.Memmove<char>(ref text._firstChar, MemoryMarshal.GetReference<char>(value), (UIntPtr)value.Length);
			return text;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00017064 File Offset: 0x00015264
		public static string Create<[Nullable(2)] TState>(int length, TState state, SpanAction<char, TState> action)
		{
			if (action == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.action);
			}
			if (length <= 0)
			{
				if (length == 0)
				{
					return string.Empty;
				}
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length);
			}
			string text = string.FastAllocateString(length);
			action(new Span<char>(text.GetRawStringData(), length), state);
			return text;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000170AA File Offset: 0x000152AA
		public static string Create([Nullable(2)] IFormatProvider provider, [InterpolatedStringHandlerArgument("provider")] ref DefaultInterpolatedStringHandler handler)
		{
			return handler.ToStringAndClear();
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000170B2 File Offset: 0x000152B2
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string Create([Nullable(2)] IFormatProvider provider, Span<char> initialBuffer, [InterpolatedStringHandlerArgument(new string[]
		{
			"provider",
			"initialBuffer"
		})] ref DefaultInterpolatedStringHandler handler)
		{
			return handler.ToStringAndClear();
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000170BC File Offset: 0x000152BC
		[NullableContext(0)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator ReadOnlySpan<char>([Nullable(2)] string value)
		{
			if (value == null)
			{
				return default(ReadOnlySpan<char>);
			}
			return new ReadOnlySpan<char>(value.GetRawStringData(), value.Length);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000170E7 File Offset: 0x000152E7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool TryGetSpan(int startIndex, int count, out ReadOnlySpan<char> slice)
		{
			if ((ulong)startIndex + (ulong)count > (ulong)this.Length)
			{
				slice = default(ReadOnlySpan<char>);
				return false;
			}
			slice = new ReadOnlySpan<char>(Unsafe.Add<char>(ref this._firstChar, (IntPtr)((UIntPtr)startIndex)), count);
			return true;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00007B62 File Offset: 0x00005D62
		public object Clone()
		{
			return this;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001711C File Offset: 0x0001531C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This API should not be used to create mutable strings. See https://go.microsoft.com/fwlink/?linkid=2084035 for alternatives.")]
		public static string Copy(string str)
		{
			ArgumentNullException.ThrowIfNull(str, "str");
			string text = string.FastAllocateString(str.Length);
			UIntPtr elementCount = (UIntPtr)text.Length;
			Buffer.Memmove<char>(ref text._firstChar, ref str._firstChar, elementCount);
			return text;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0001715C File Offset: 0x0001535C
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			ArgumentNullException.ThrowIfNull(destination, "destination");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(sourceIndex, "sourceIndex");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(count, this.Length - sourceIndex, "sourceIndex");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(destinationIndex, destination.Length - count, "destinationIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(destinationIndex, "destinationIndex");
			Buffer.Memmove<char>(Unsafe.Add<char>(MemoryMarshal.GetArrayDataReference<char>(destination), destinationIndex), Unsafe.Add<char>(ref this._firstChar, sourceIndex), (UIntPtr)count);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000171DB File Offset: 0x000153DB
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CopyTo(Span<char> destination)
		{
			if (this.Length <= destination.Length)
			{
				Buffer.Memmove<char>(destination._reference, ref this._firstChar, (UIntPtr)this.Length);
				return;
			}
			ThrowHelper.ThrowArgumentException_DestinationTooShort();
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0001720C File Offset: 0x0001540C
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryCopyTo(Span<char> destination)
		{
			bool result = false;
			if (this.Length <= destination.Length)
			{
				Buffer.Memmove<char>(destination._reference, ref this._firstChar, (UIntPtr)this.Length);
				result = true;
			}
			return result;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00017246 File Offset: 0x00015446
		public char[] ToCharArray()
		{
			if (this.Length == 0)
			{
				return Array.Empty<char>();
			}
			char[] array = new char[this.Length];
			Buffer.Memmove<char>(MemoryMarshal.GetArrayDataReference<char>(array), ref this._firstChar, (UIntPtr)this.Length);
			return array;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001727C File Offset: 0x0001547C
		public char[] ToCharArray(int startIndex, int length)
		{
			ArgumentOutOfRangeException.ThrowIfGreaterThan<uint>((uint)startIndex, (uint)this.Length, "startIndex");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(startIndex, this.Length - length, "startIndex");
			if (length <= 0)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
				return Array.Empty<char>();
			}
			char[] array = new char[length];
			Buffer.Memmove<char>(MemoryMarshal.GetArrayDataReference<char>(array), Unsafe.Add<char>(ref this._firstChar, startIndex), (UIntPtr)length);
			return array;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000172E1 File Offset: 0x000154E1
		[NullableContext(2)]
		public static bool IsNullOrEmpty([NotNullWhen(false)] string value)
		{
			return value == null || value.Length == 0;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000172F4 File Offset: 0x000154F4
		[NullableContext(2)]
		public static bool IsNullOrWhiteSpace([NotNullWhen(false)] string value)
		{
			if (value == null)
			{
				return true;
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (!char.IsWhiteSpace(value[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00017328 File Offset: 0x00015528
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NonVersionable]
		public ref readonly char GetPinnableReference()
		{
			return ref this._firstChar;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00017328 File Offset: 0x00015528
		internal ref char GetRawStringData()
		{
			return ref this._firstChar;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00017330 File Offset: 0x00015530
		internal ref ushort GetRawStringDataAsUInt16()
		{
			return Unsafe.As<char, ushort>(ref this._firstChar);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00017340 File Offset: 0x00015540
		internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
		{
			int charCount = encoding.GetCharCount(bytes, byteLength);
			if (charCount == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(charCount);
			fixed (char* ptr = &text._firstChar)
			{
				char* chars = ptr;
				encoding.GetChars(bytes, byteLength, chars, charCount);
			}
			return text;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001737D File Offset: 0x0001557D
		internal static string CreateFromChar(char c)
		{
			string text = string.FastAllocateString(1);
			text._firstChar = c;
			return text;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0001738C File Offset: 0x0001558C
		internal unsafe static string CreateFromChar(char c1, char c2)
		{
			string text = string.FastAllocateString(2);
			text._firstChar = c1;
			*Unsafe.Add<char>(ref text._firstChar, 1) = c2;
			return text;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00007B62 File Offset: 0x00005D62
		public override string ToString()
		{
			return this;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00007B62 File Offset: 0x00005D62
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000173A9 File Offset: 0x000155A9
		public CharEnumerator GetEnumerator()
		{
			return new CharEnumerator(this);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000173A9 File Offset: 0x000155A9
		IEnumerator<char> IEnumerable<char>.GetEnumerator()
		{
			return new CharEnumerator(this);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000173A9 File Offset: 0x000155A9
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new CharEnumerator(this);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000173B1 File Offset: 0x000155B1
		public StringRuneEnumerator EnumerateRunes()
		{
			return new StringRuneEnumerator(this);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000173B9 File Offset: 0x000155B9
		internal unsafe static int wcslen(char* ptr)
		{
			return SpanHelpers.IndexOfNullCharacter(ptr);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000173C1 File Offset: 0x000155C1
		internal unsafe static int strlen(byte* ptr)
		{
			return SpanHelpers.IndexOfNullByte(ptr);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000173C9 File Offset: 0x000155C9
		public TypeCode GetTypeCode()
		{
			return TypeCode.String;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000173CD File Offset: 0x000155CD
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this, provider);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000173D6 File Offset: 0x000155D6
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this, provider);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000173DF File Offset: 0x000155DF
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this, provider);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000173E8 File Offset: 0x000155E8
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this, provider);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000173F1 File Offset: 0x000155F1
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this, provider);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000173FA File Offset: 0x000155FA
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this, provider);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00017403 File Offset: 0x00015603
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this, provider);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0001740C File Offset: 0x0001560C
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this, provider);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00017415 File Offset: 0x00015615
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this, provider);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001741E File Offset: 0x0001561E
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this, provider);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00017427 File Offset: 0x00015627
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this, provider);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00017430 File Offset: 0x00015630
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this, provider);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00017439 File Offset: 0x00015639
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this, provider);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00017442 File Offset: 0x00015642
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return Convert.ToDateTime(this, provider);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0000E0EE File Offset: 0x0000C2EE
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001744B File Offset: 0x0001564B
		public bool IsNormalized()
		{
			return this.IsNormalized(NormalizationForm.FormC);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00017454 File Offset: 0x00015654
		public bool IsNormalized(NormalizationForm normalizationForm)
		{
			return (Ascii.IsValid(this) && (normalizationForm == NormalizationForm.FormC || normalizationForm == NormalizationForm.FormKC || normalizationForm == NormalizationForm.FormD || normalizationForm == NormalizationForm.FormKD)) || Normalization.IsNormalized(this, normalizationForm);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001747C File Offset: 0x0001567C
		public string Normalize()
		{
			return this.Normalize(NormalizationForm.FormC);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00017485 File Offset: 0x00015685
		public string Normalize(NormalizationForm normalizationForm)
		{
			if (Ascii.IsValid(this) && (normalizationForm == NormalizationForm.FormC || normalizationForm == NormalizationForm.FormKC || normalizationForm == NormalizationForm.FormD || normalizationForm == NormalizationForm.FormKD))
			{
				return this;
			}
			return Normalization.Normalize(this, normalizationForm);
		}

		// Token: 0x1700007C RID: 124
		[IndexerName("Chars")]
		public unsafe char this[int index]
		{
			[Intrinsic]
			get
			{
				if (index >= this._stringLength)
				{
					ThrowHelper.ThrowIndexOutOfRangeException();
				}
				return *Unsafe.Add<char>(ref this._firstChar, (IntPtr)((UIntPtr)index));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x000174CB File Offset: 0x000156CB
		public int Length
		{
			[Intrinsic]
			get
			{
				return this._stringLength;
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000174D3 File Offset: 0x000156D3
		string IParsable<string>.Parse(string s, IFormatProvider provider)
		{
			ArgumentNullException.ThrowIfNull(s, "s");
			return s;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000174E1 File Offset: 0x000156E1
		bool IParsable<string>.TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out string result)
		{
			result = s;
			return s != null;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000174EA File Offset: 0x000156EA
		string ISpanParsable<string>.Parse(ReadOnlySpan<char> s, IFormatProvider provider)
		{
			if (s.Length > 1073741791)
			{
				ThrowHelper.ThrowFormatInvalidString();
			}
			return s.ToString();
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0001750C File Offset: 0x0001570C
		bool ISpanParsable<string>.TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out string result)
		{
			if (s.Length <= 1073741791)
			{
				result = s.ToString();
				return true;
			}
			result = null;
			return false;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00017531 File Offset: 0x00015731
		private static void CopyStringContent(string dest, int destPos, string src)
		{
			Buffer.Memmove<char>(Unsafe.Add<char>(ref dest._firstChar, destPos), ref src._firstChar, (UIntPtr)src.Length);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00017551 File Offset: 0x00015751
		public static string Concat([Nullable(2)] object arg0)
		{
			return ((arg0 != null) ? arg0.ToString() : null) ?? string.Empty;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00017568 File Offset: 0x00015768
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Concat(object arg0, object arg1)
		{
			return ((arg0 != null) ? arg0.ToString() : null) + ((arg1 != null) ? arg1.ToString() : null);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00017587 File Offset: 0x00015787
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Concat(object arg0, object arg1, object arg2)
		{
			return ((arg0 != null) ? arg0.ToString() : null) + ((arg1 != null) ? arg1.ToString() : null) + ((arg2 != null) ? arg2.ToString() : null);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000175B2 File Offset: 0x000157B2
		public static string Concat([Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			ArgumentNullException.ThrowIfNull(args, "args");
			return string.Concat(args);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000175CC File Offset: 0x000157CC
		public unsafe static string Concat([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> args)
		{
			if (args.Length <= 1)
			{
				string result;
				if (!args.IsEmpty)
				{
					object obj = *args[0];
					if ((result = ((obj != null) ? obj.ToString() : null)) == null)
					{
						return string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
			string[] array = new string[args.Length];
			int num = 0;
			for (int i = 0; i < args.Length; i++)
			{
				object obj2 = *args[i];
				string text = ((obj2 != null) ? obj2.ToString() : null) ?? string.Empty;
				array[i] = text;
				num += text.Length;
				if (num < 0)
				{
					ThrowHelper.ThrowOutOfMemoryException_StringTooLong();
				}
			}
			if (num == 0)
			{
				return string.Empty;
			}
			string text2 = string.FastAllocateString(num);
			int num2 = 0;
			foreach (string text3 in array)
			{
				string.CopyStringContent(text2, num2, text3);
				num2 += text3.Length;
			}
			return text2;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000176AE File Offset: 0x000158AE
		public static string Concat<[Nullable(2)] T>(IEnumerable<T> values)
		{
			return string.JoinCore<T>(ReadOnlySpan<char>.Empty, values);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000176BC File Offset: 0x000158BC
		public unsafe static string Concat([Nullable(new byte[]
		{
			1,
			2
		})] IEnumerable<string> values)
		{
			ArgumentNullException.ThrowIfNull(values, "values");
			string result;
			using (IEnumerator<string> enumerator = values.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					result = string.Empty;
				}
				else
				{
					string text = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
						ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
						valueStringBuilder.Append(text);
						do
						{
							valueStringBuilder.Append(enumerator.Current);
						}
						while (enumerator.MoveNext());
						result = valueStringBuilder.ToString();
					}
				}
			}
			return result;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0001776C File Offset: 0x0001596C
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Concat(string str0, string str1)
		{
			if (string.IsNullOrEmpty(str0))
			{
				if (string.IsNullOrEmpty(str1))
				{
					return string.Empty;
				}
				return str1;
			}
			else
			{
				if (string.IsNullOrEmpty(str1))
				{
					return str0;
				}
				int length = str0.Length;
				int num = length + str1.Length;
				if (num < 0)
				{
					ThrowHelper.ThrowOutOfMemoryException_StringTooLong();
				}
				string text = string.FastAllocateString(num);
				string.CopyStringContent(text, 0, str0);
				string.CopyStringContent(text, length, str1);
				return text;
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000177C8 File Offset: 0x000159C8
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Concat(string str0, string str1, string str2)
		{
			if (string.IsNullOrEmpty(str0))
			{
				return str1 + str2;
			}
			if (string.IsNullOrEmpty(str1))
			{
				return str0 + str2;
			}
			if (string.IsNullOrEmpty(str2))
			{
				return str0 + str1;
			}
			long num = (long)str0.Length + (long)str1.Length + (long)str2.Length;
			if (num > 2147483647L)
			{
				ThrowHelper.ThrowOutOfMemoryException_StringTooLong();
			}
			string text = string.FastAllocateString((int)num);
			string.CopyStringContent(text, 0, str0);
			string.CopyStringContent(text, str0.Length, str1);
			string.CopyStringContent(text, str0.Length + str1.Length, str2);
			return text;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001785C File Offset: 0x00015A5C
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Concat(string str0, string str1, string str2, string str3)
		{
			if (string.IsNullOrEmpty(str0))
			{
				return str1 + str2 + str3;
			}
			if (string.IsNullOrEmpty(str1))
			{
				return str0 + str2 + str3;
			}
			if (string.IsNullOrEmpty(str2))
			{
				return str0 + str1 + str3;
			}
			if (string.IsNullOrEmpty(str3))
			{
				return str0 + str1 + str2;
			}
			long num = (long)str0.Length + (long)str1.Length + (long)str2.Length + (long)str3.Length;
			if (num > 2147483647L)
			{
				ThrowHelper.ThrowOutOfMemoryException_StringTooLong();
			}
			string text = string.FastAllocateString((int)num);
			string.CopyStringContent(text, 0, str0);
			string.CopyStringContent(text, str0.Length, str1);
			string.CopyStringContent(text, str0.Length + str1.Length, str2);
			string.CopyStringContent(text, str0.Length + str1.Length + str2.Length, str3);
			return text;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00017924 File Offset: 0x00015B24
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string Concat(ReadOnlySpan<char> str0, ReadOnlySpan<char> str1)
		{
			int num = checked(str0.Length + str1.Length);
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			Span<char> destination = new Span<char>(ref text._firstChar, text.Length);
			str0.CopyTo(destination);
			str1.CopyTo(destination.Slice(str0.Length));
			return text;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00017984 File Offset: 0x00015B84
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string Concat(ReadOnlySpan<char> str0, ReadOnlySpan<char> str1, ReadOnlySpan<char> str2)
		{
			int num = checked(str0.Length + str1.Length + str2.Length);
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			Span<char> destination = new Span<char>(ref text._firstChar, text.Length);
			str0.CopyTo(destination);
			destination = destination.Slice(str0.Length);
			str1.CopyTo(destination);
			destination = destination.Slice(str1.Length);
			str2.CopyTo(destination);
			return text;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00017A04 File Offset: 0x00015C04
		[NullableContext(0)]
		[return: Nullable(1)]
		public static string Concat(ReadOnlySpan<char> str0, ReadOnlySpan<char> str1, ReadOnlySpan<char> str2, ReadOnlySpan<char> str3)
		{
			int num = checked(str0.Length + str1.Length + str2.Length + str3.Length);
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			Span<char> destination = new Span<char>(ref text._firstChar, text.Length);
			str0.CopyTo(destination);
			destination = destination.Slice(str0.Length);
			str1.CopyTo(destination);
			destination = destination.Slice(str1.Length);
			str2.CopyTo(destination);
			destination = destination.Slice(str2.Length);
			str3.CopyTo(destination);
			return text;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00017AA4 File Offset: 0x00015CA4
		internal static string Concat(ReadOnlySpan<char> str0, ReadOnlySpan<char> str1, ReadOnlySpan<char> str2, ReadOnlySpan<char> str3, ReadOnlySpan<char> str4)
		{
			int num = checked(str0.Length + str1.Length + str2.Length + str3.Length + str4.Length);
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			Span<char> destination = new Span<char>(ref text._firstChar, text.Length);
			str0.CopyTo(destination);
			destination = destination.Slice(str0.Length);
			str1.CopyTo(destination);
			destination = destination.Slice(str1.Length);
			str2.CopyTo(destination);
			destination = destination.Slice(str2.Length);
			str3.CopyTo(destination);
			destination = destination.Slice(str3.Length);
			str4.CopyTo(destination);
			return text;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00017B60 File Offset: 0x00015D60
		public static string Concat([Nullable(new byte[]
		{
			1,
			2
		})] params string[] values)
		{
			ArgumentNullException.ThrowIfNull(values, "values");
			return string.Concat(values);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00017B78 File Offset: 0x00015D78
		public unsafe static string Concat([ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<string> values)
		{
			if (values.Length <= 1)
			{
				string result;
				if (!values.IsEmpty)
				{
					if ((result = *values[0]) == null)
					{
						return string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
			long num = 0L;
			for (int i = 0; i < values.Length; i++)
			{
				string text = *values[i];
				if (text != null)
				{
					num += (long)text.Length;
				}
			}
			if (num > 2147483647L)
			{
				ThrowHelper.ThrowOutOfMemoryException_StringTooLong();
			}
			int num2 = (int)num;
			if (num2 == 0)
			{
				return string.Empty;
			}
			string text2 = string.FastAllocateString(num2);
			int num3 = 0;
			for (int j = 0; j < values.Length; j++)
			{
				string text3 = *values[j];
				if (!string.IsNullOrEmpty(text3))
				{
					int length = text3.Length;
					if (length > num2 - num3)
					{
						num3 = -1;
						break;
					}
					string.CopyStringContent(text2, num3, text3);
					num3 += length;
				}
			}
			if (num3 != num2)
			{
				return string.Concat(values.ToArray());
			}
			return text2;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00017C6C File Offset: 0x00015E6C
		public static string Format([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			return string.FormatHelper(null, format, new ReadOnlySpan<object>(ref arg0));
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00017C7C File Offset: 0x00015E7C
		public static string Format([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0, [Nullable(2)] object arg1)
		{
			TwoObjects twoObjects = new TwoObjects(arg0, arg1);
			return string.FormatHelper(null, format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<TwoObjects, object>(twoObjects, 2));
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00017CA4 File Offset: 0x00015EA4
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Format([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
		{
			ThreeObjects threeObjects = new ThreeObjects(arg0, arg1, arg2);
			return string.FormatHelper(null, format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<ThreeObjects, object>(threeObjects, 3));
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00017CCA File Offset: 0x00015ECA
		public static string Format([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			if (args == null)
			{
				ArgumentNullException.Throw((format == null) ? "format" : "args");
			}
			return string.FormatHelper(null, format, args);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00017CF0 File Offset: 0x00015EF0
		public static string Format([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> args)
		{
			return string.FormatHelper(null, format, args);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00017CFA File Offset: 0x00015EFA
		public static string Format([Nullable(2)] IFormatProvider provider, [StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			return string.FormatHelper(provider, format, new ReadOnlySpan<object>(ref arg0));
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00017D0C File Offset: 0x00015F0C
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Format(IFormatProvider provider, [Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
		{
			TwoObjects twoObjects = new TwoObjects(arg0, arg1);
			return string.FormatHelper(provider, format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<TwoObjects, object>(twoObjects, 2));
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00017D34 File Offset: 0x00015F34
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string Format(IFormatProvider provider, [Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
		{
			ThreeObjects threeObjects = new ThreeObjects(arg0, arg1, arg2);
			return string.FormatHelper(provider, format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<ThreeObjects, object>(threeObjects, 3));
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00017D5B File Offset: 0x00015F5B
		public static string Format([Nullable(2)] IFormatProvider provider, [StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			if (args == null)
			{
				ArgumentNullException.Throw((format == null) ? "format" : "args");
			}
			return string.FormatHelper(provider, format, args);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00017D81 File Offset: 0x00015F81
		public static string Format([Nullable(2)] IFormatProvider provider, [StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> args)
		{
			return string.FormatHelper(provider, format, args);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00017D8C File Offset: 0x00015F8C
		private unsafe static string FormatHelper(IFormatProvider provider, string format, ReadOnlySpan<object> args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.EnsureCapacity(format.Length + args.Length * 8);
			valueStringBuilder.AppendFormatHelper(provider, format, args);
			return valueStringBuilder.ToString();
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00017DF0 File Offset: 0x00015FF0
		public static string Format<[Nullable(2)] TArg0>([Nullable(2)] IFormatProvider provider, CompositeFormat format, TArg0 arg0)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(1);
			return string.Format<TArg0, int, int>(provider, format, arg0, 0, 0, default(ReadOnlySpan<object>));
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00017E24 File Offset: 0x00016024
		public static string Format<[Nullable(2)] TArg0, [Nullable(2)] TArg1>([Nullable(2)] IFormatProvider provider, CompositeFormat format, TArg0 arg0, TArg1 arg1)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(2);
			return string.Format<TArg0, TArg1, int>(provider, format, arg0, arg1, 0, default(ReadOnlySpan<object>));
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00017E58 File Offset: 0x00016058
		public static string Format<[Nullable(2)] TArg0, [Nullable(2)] TArg1, [Nullable(2)] TArg2>([Nullable(2)] IFormatProvider provider, CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(3);
			return string.Format<TArg0, TArg1, TArg2>(provider, format, arg0, arg1, arg2, default(ReadOnlySpan<object>));
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00017E8B File Offset: 0x0001608B
		public static string Format([Nullable(2)] IFormatProvider provider, CompositeFormat format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			ArgumentNullException.ThrowIfNull(args, "args");
			return string.Format(provider, format, args);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00017EB0 File Offset: 0x000160B0
		public unsafe static string Format([Nullable(2)] IFormatProvider provider, CompositeFormat format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(args.Length);
			string result;
			switch (args.Length)
			{
			case 0:
				result = format.Format;
				break;
			case 1:
				result = string.Format<object, int, int>(provider, format, *args[0], 0, 0, args);
				break;
			case 2:
				result = string.Format<object, object, int>(provider, format, *args[0], *args[1], 0, args);
				break;
			default:
				result = string.Format<object, object, object>(provider, format, *args[0], *args[1], *args[2], args);
				break;
			}
			return result;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00017F54 File Offset: 0x00016154
		private unsafe static string Format<TArg0, TArg1, TArg2>(IFormatProvider provider, CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2, ReadOnlySpan<object> args)
		{
			if (format._formattedCount == 0)
			{
				return format.Format;
			}
			int literalLength = format._literalLength;
			int i = format._formattedCount;
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(literalLength, i, provider, initialBuffer);
			foreach (ValueTuple<string, int, int, string> valueTuple in format._segments)
			{
				string item = valueTuple.Item1;
				if (item != null)
				{
					defaultInterpolatedStringHandler.AppendLiteral(item);
				}
				else
				{
					int item2 = valueTuple.Item2;
					switch (item2)
					{
					case 0:
						defaultInterpolatedStringHandler.AppendFormatted<TArg0>(arg0, valueTuple.Item3, valueTuple.Item4);
						break;
					case 1:
						defaultInterpolatedStringHandler.AppendFormatted<TArg1>(arg1, valueTuple.Item3, valueTuple.Item4);
						break;
					case 2:
						defaultInterpolatedStringHandler.AppendFormatted<TArg2>(arg2, valueTuple.Item3, valueTuple.Item4);
						break;
					default:
						defaultInterpolatedStringHandler.AppendFormatted(*args[item2], valueTuple.Item3, valueTuple.Item4);
						break;
					}
				}
			}
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00018070 File Offset: 0x00016270
		public string Insert(int startIndex, string value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<uint>((uint)startIndex, (uint)this.Length, "startIndex");
			int length = this.Length;
			int length2 = value.Length;
			if (length == 0)
			{
				return value;
			}
			if (length2 == 0)
			{
				return this;
			}
			string text = string.FastAllocateString(length + length2);
			Buffer.Memmove<char>(ref text._firstChar, ref this._firstChar, (UIntPtr)((IntPtr)startIndex));
			Buffer.Memmove<char>(Unsafe.Add<char>(ref text._firstChar, startIndex), ref value._firstChar, (UIntPtr)((IntPtr)length2));
			Buffer.Memmove<char>(Unsafe.Add<char>(ref text._firstChar, startIndex + length2), Unsafe.Add<char>(ref this._firstChar, startIndex), (UIntPtr)((IntPtr)(length - startIndex)));
			return text;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00018108 File Offset: 0x00016308
		public static string Join(char separator, [Nullable(new byte[]
		{
			1,
			2
		})] params string[] value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return string.JoinCore(new ReadOnlySpan<char>(ref separator), new ReadOnlySpan<string>(value));
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00018125 File Offset: 0x00016325
		public static string Join(char separator, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<string> value)
		{
			return string.JoinCore(new ReadOnlySpan<char>(ref separator), value);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00018134 File Offset: 0x00016334
		public static string Join([Nullable(2)] string separator, [Nullable(new byte[]
		{
			1,
			2
		})] params string[] value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return string.JoinCore(separator.AsSpan(), new ReadOnlySpan<string>(value));
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00018150 File Offset: 0x00016350
		public static string Join([Nullable(2)] string separator, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<string> value)
		{
			return string.JoinCore(separator.AsSpan(), value);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0001815E File Offset: 0x0001635E
		public static string Join(char separator, [Nullable(new byte[]
		{
			1,
			2
		})] string[] value, int startIndex, int count)
		{
			return string.JoinCore(new ReadOnlySpan<char>(ref separator), value, startIndex, count);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0001816F File Offset: 0x0001636F
		public static string Join([Nullable(2)] string separator, [Nullable(new byte[]
		{
			1,
			2
		})] string[] value, int startIndex, int count)
		{
			return string.JoinCore(separator.AsSpan(), value, startIndex, count);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00018180 File Offset: 0x00016380
		private static string JoinCore(ReadOnlySpan<char> separator, string[] value, int startIndex, int count)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(startIndex, value.Length - count, "startIndex");
			return string.JoinCore(separator, new ReadOnlySpan<string>(value, startIndex, count));
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000181CC File Offset: 0x000163CC
		public unsafe static string Join([Nullable(2)] string separator, [Nullable(new byte[]
		{
			1,
			2
		})] IEnumerable<string> values)
		{
			List<string> list = values as List<string>;
			if (list != null)
			{
				return string.JoinCore(separator.AsSpan(), CollectionsMarshal.AsSpan<string>(list));
			}
			string[] array = values as string[];
			if (array != null)
			{
				return string.JoinCore(separator.AsSpan(), new ReadOnlySpan<string>(array));
			}
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			string result;
			using (IEnumerator<string> enumerator = values.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					result = string.Empty;
				}
				else
				{
					string text = enumerator.Current;
					if (!enumerator.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
						ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
						valueStringBuilder.Append(text);
						do
						{
							valueStringBuilder.Append(separator);
							valueStringBuilder.Append(enumerator.Current);
						}
						while (enumerator.MoveNext());
						result = valueStringBuilder.ToString();
					}
				}
			}
			return result;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000182C4 File Offset: 0x000164C4
		public static string Join(char separator, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return string.JoinCore(new ReadOnlySpan<char>(ref separator), values);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000182E1 File Offset: 0x000164E1
		public static string Join(char separator, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> values)
		{
			return string.JoinCore(new ReadOnlySpan<char>(ref separator), values);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000182F0 File Offset: 0x000164F0
		public static string Join([Nullable(2)] string separator, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return string.JoinCore(separator.AsSpan(), values);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001830C File Offset: 0x0001650C
		public static string Join([Nullable(2)] string separator, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> values)
		{
			return string.JoinCore(separator.AsSpan(), values);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0001831C File Offset: 0x0001651C
		private unsafe static string JoinCore(ReadOnlySpan<char> separator, ReadOnlySpan<object> values)
		{
			if (values.IsEmpty)
			{
				return string.Empty;
			}
			object obj = *values[0];
			string text = (obj != null) ? obj.ToString() : null;
			if (values.Length == 1)
			{
				return text ?? string.Empty;
			}
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.Append(text);
			for (int i = 1; i < values.Length; i++)
			{
				valueStringBuilder.Append(separator);
				object obj2 = *values[i];
				if (obj2 != null)
				{
					valueStringBuilder.Append(obj2.ToString());
				}
			}
			return valueStringBuilder.ToString();
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000183CA File Offset: 0x000165CA
		public static string Join<[Nullable(2)] T>(char separator, IEnumerable<T> values)
		{
			return string.JoinCore<T>(new ReadOnlySpan<char>(ref separator), values);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000183D9 File Offset: 0x000165D9
		public static string Join<[Nullable(2)] T>([Nullable(2)] string separator, IEnumerable<T> values)
		{
			return string.JoinCore<T>(separator.AsSpan(), values);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000183E8 File Offset: 0x000165E8
		private unsafe static string JoinCore<T>(ReadOnlySpan<char> separator, IEnumerable<T> values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			if (typeof(T) == typeof(string))
			{
				if (values.GetType() == typeof(List<string>))
				{
					return string.JoinCore(separator, CollectionsMarshal.AsSpan<string>(Unsafe.As<List<string>>(values)));
				}
				string[] array = values as string[];
				if (array != null)
				{
					return string.JoinCore(separator, new ReadOnlySpan<string>(array));
				}
			}
			string result;
			using (IEnumerator<T> enumerator = values.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					result = string.Empty;
				}
				else if (typeof(T) == typeof(char))
				{
					IEnumerator<char> enumerator2 = Unsafe.As<IEnumerator<char>>(enumerator);
					char c = enumerator2.Current;
					if (!enumerator2.MoveNext())
					{
						result = string.CreateFromChar(c);
					}
					else
					{
						Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
						ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
						valueStringBuilder.Append(c);
						do
						{
							if (!separator.IsEmpty)
							{
								valueStringBuilder.Append(separator);
							}
							c = enumerator2.Current;
							valueStringBuilder.Append(c);
						}
						while (enumerator2.MoveNext());
						result = valueStringBuilder.ToString();
					}
				}
				else
				{
					T t;
					if (typeof(T).IsValueType)
					{
						t = default(T);
						if (t is ISpanFormattable)
						{
							T value = enumerator.Current;
							if (!enumerator.MoveNext())
							{
								return value.ToString() ?? string.Empty;
							}
							IFormatProvider currentCulture = CultureInfo.CurrentCulture;
							Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 0, currentCulture, initialBuffer);
							defaultInterpolatedStringHandler.AppendFormatted<T>(value);
							do
							{
								if (!separator.IsEmpty)
								{
									defaultInterpolatedStringHandler.AppendFormatted(separator);
								}
								defaultInterpolatedStringHandler.AppendFormatted<T>(enumerator.Current);
							}
							while (enumerator.MoveNext());
							return defaultInterpolatedStringHandler.ToStringAndClear();
						}
					}
					t = enumerator.Current;
					string text = (t != null) ? t.ToString() : null;
					if (!enumerator.MoveNext())
					{
						result = (text ?? string.Empty);
					}
					else
					{
						Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
						ValueStringBuilder valueStringBuilder2 = new ValueStringBuilder(initialBuffer);
						valueStringBuilder2.Append(text);
						do
						{
							if (!separator.IsEmpty)
							{
								valueStringBuilder2.Append(separator);
							}
							t = enumerator.Current;
							valueStringBuilder2.Append((t != null) ? t.ToString() : null);
						}
						while (enumerator.MoveNext());
						result = valueStringBuilder2.ToString();
					}
				}
			}
			return result;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000186C0 File Offset: 0x000168C0
		private unsafe static string JoinCore(ReadOnlySpan<char> separator, ReadOnlySpan<string> values)
		{
			if (values.Length <= 1)
			{
				string result;
				if (!values.IsEmpty)
				{
					if ((result = *values[0]) == null)
					{
						return string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
				return result;
			}
			long num = (long)(values.Length - 1) * (long)separator.Length;
			if (num > 2147483647L)
			{
				ThrowHelper.ThrowOutOfMemoryException_StringTooLong();
			}
			int num2 = (int)num;
			ReadOnlySpan<string> readOnlySpan = values;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				string text = *readOnlySpan[i];
				if (text != null)
				{
					num2 += text.Length;
					if (num2 < 0)
					{
						ThrowHelper.ThrowOutOfMemoryException_StringTooLong();
					}
				}
			}
			if (num2 == 0)
			{
				return string.Empty;
			}
			string text2 = string.FastAllocateString(num2);
			int num3 = 0;
			for (int j = 0; j < values.Length; j++)
			{
				string text3 = *values[j];
				if (text3 != null)
				{
					int length = text3.Length;
					if (length > num2 - num3)
					{
						num3 = -1;
						break;
					}
					string.CopyStringContent(text2, num3, text3);
					num3 += length;
				}
				if (j < values.Length - 1)
				{
					ref char ptr = ref Unsafe.Add<char>(ref text2._firstChar, num3);
					if (separator.Length == 1)
					{
						ptr = (char)(*separator[0]);
					}
					else
					{
						separator.CopyTo(new Span<char>(ref ptr, separator.Length));
					}
					num3 += separator.Length;
				}
			}
			if (num3 != num2)
			{
				return string.JoinCore(separator, values.ToArray().AsSpan<string>());
			}
			return text2;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00018826 File Offset: 0x00016A26
		public string PadLeft(int totalWidth)
		{
			return this.PadLeft(totalWidth, ' ');
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00018834 File Offset: 0x00016A34
		public string PadLeft(int totalWidth, char paddingChar)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(totalWidth, "totalWidth");
			int length = this.Length;
			int num = totalWidth - length;
			if (num <= 0)
			{
				return this;
			}
			string text = string.FastAllocateString(totalWidth);
			new Span<char>(ref text._firstChar, num).Fill(paddingChar);
			Buffer.Memmove<char>(Unsafe.Add<char>(ref text._firstChar, num), ref this._firstChar, (UIntPtr)((IntPtr)length));
			return text;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00018891 File Offset: 0x00016A91
		public string PadRight(int totalWidth)
		{
			return this.PadRight(totalWidth, ' ');
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001889C File Offset: 0x00016A9C
		public string PadRight(int totalWidth, char paddingChar)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(totalWidth, "totalWidth");
			int length = this.Length;
			int num = totalWidth - length;
			if (num <= 0)
			{
				return this;
			}
			string text = string.FastAllocateString(totalWidth);
			Buffer.Memmove<char>(ref text._firstChar, ref this._firstChar, (UIntPtr)((IntPtr)length));
			new Span<char>(Unsafe.Add<char>(ref text._firstChar, length), num).Fill(paddingChar);
			return text;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000188FC File Offset: 0x00016AFC
		public string Remove(int startIndex, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			int length = this.Length;
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(count, length - startIndex, "count");
			if (count == 0)
			{
				return this;
			}
			int num = length - count;
			if (num == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(num);
			Buffer.Memmove<char>(ref text._firstChar, ref this._firstChar, (UIntPtr)((IntPtr)startIndex));
			Buffer.Memmove<char>(Unsafe.Add<char>(ref text._firstChar, startIndex), Unsafe.Add<char>(ref this._firstChar, startIndex + count), (UIntPtr)((IntPtr)(num - startIndex)));
			return text;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00018982 File Offset: 0x00016B82
		public string Remove(int startIndex)
		{
			if ((ulong)startIndex > (ulong)((long)this.Length))
			{
				throw new ArgumentOutOfRangeException("startIndex", (startIndex < 0) ? SR.ArgumentOutOfRange_StartIndex : SR.ArgumentOutOfRange_StartIndexLargerThanLength);
			}
			return this.Substring(0, startIndex);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000189B2 File Offset: 0x00016BB2
		public string Replace(string oldValue, [Nullable(2)] string newValue, bool ignoreCase, [Nullable(2)] CultureInfo culture)
		{
			return this.ReplaceCore(oldValue, newValue, (culture != null) ? culture.CompareInfo : null, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000189D4 File Offset: 0x00016BD4
		public string Replace(string oldValue, [Nullable(2)] string newValue, StringComparison comparisonType)
		{
			string result;
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				result = this.ReplaceCore(oldValue, newValue, CultureInfo.CurrentCulture.CompareInfo, string.GetCaseCompareOfComparisonCulture(comparisonType));
				break;
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				result = this.ReplaceCore(oldValue, newValue, CompareInfo.Invariant, string.GetCaseCompareOfComparisonCulture(comparisonType));
				break;
			case StringComparison.Ordinal:
				result = this.Replace(oldValue, newValue);
				break;
			case StringComparison.OrdinalIgnoreCase:
				result = this.ReplaceCore(oldValue, newValue, CompareInfo.Invariant, CompareOptions.OrdinalIgnoreCase);
				break;
			default:
				throw new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
			return result;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00018A63 File Offset: 0x00016C63
		private string ReplaceCore(string oldValue, string newValue, CompareInfo ci, CompareOptions options)
		{
			ArgumentException.ThrowIfNullOrEmpty(oldValue, "oldValue");
			return string.ReplaceCore(this, oldValue.AsSpan(), newValue.AsSpan(), ci ?? CultureInfo.CurrentCulture.CompareInfo, options) ?? this;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00018AA0 File Offset: 0x00016CA0
		private unsafe static string ReplaceCore(ReadOnlySpan<char> searchSpace, ReadOnlySpan<char> oldValue, ReadOnlySpan<char> newValue, CompareInfo compareInfo, CompareOptions options)
		{
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			valueStringBuilder.EnsureCapacity(searchSpace.Length);
			bool flag = false;
			for (;;)
			{
				int num2;
				int num = compareInfo.IndexOf(searchSpace, oldValue, options, out num2);
				if (num < 0 || num2 == 0)
				{
					break;
				}
				valueStringBuilder.Append(searchSpace.Slice(0, num));
				valueStringBuilder.Append(newValue);
				searchSpace = searchSpace.Slice(num + num2);
				flag = true;
			}
			if (!flag)
			{
				valueStringBuilder.Dispose();
				return null;
			}
			valueStringBuilder.Append(searchSpace);
			return valueStringBuilder.ToString();
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00018B38 File Offset: 0x00016D38
		public string Replace(char oldChar, char newChar)
		{
			if (oldChar == newChar)
			{
				return this;
			}
			int num = this.IndexOf(oldChar);
			if (num < 0)
			{
				return this;
			}
			UIntPtr uintPtr = (UIntPtr)(this.Length - num);
			string text = string.FastAllocateString(this.Length);
			int num2 = num;
			if (num2 > 0)
			{
				Buffer.Memmove<char>(ref text._firstChar, ref this._firstChar, (UIntPtr)num2);
			}
			ref ushort ptr = ref Unsafe.Add<ushort>(this.GetRawStringDataAsUInt16(), (UIntPtr)num2);
			ref ushort ptr2 = ref Unsafe.Add<ushort>(text.GetRawStringDataAsUInt16(), (UIntPtr)num2);
			UIntPtr uintPtr2 = (UIntPtr)this.Length;
			if (false)
			{
			}
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated && uintPtr2 >= (UIntPtr)Vector128<ushort>.Count)
			{
				UIntPtr uintPtr3 = uintPtr2 - uintPtr & (UIntPtr)(Vector128<ushort>.Count - 1);
				ptr = Unsafe.Subtract<ushort>(ref ptr, uintPtr3);
				ptr2 = Unsafe.Subtract<ushort>(ref ptr2, uintPtr3);
				uintPtr += uintPtr3;
			}
			SpanHelpers.ReplaceValueType<ushort>(ref ptr, ref ptr2, (ushort)oldChar, (ushort)newChar, uintPtr);
			return text;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00018C00 File Offset: 0x00016E00
		public unsafe string Replace(string oldValue, [Nullable(2)] string newValue)
		{
			ArgumentException.ThrowIfNullOrEmpty(oldValue, "oldValue");
			if (newValue == null)
			{
				newValue = string.Empty;
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			if (oldValue.Length == 1)
			{
				if (newValue.Length == 1)
				{
					return this.Replace(oldValue[0], newValue[0]);
				}
				char value = oldValue[0];
				int num = 0;
				if (PackedSpanHelpers.PackedIndexOfIsSupported && PackedSpanHelpers.CanUsePackedIndexOf<char>(value))
				{
					for (;;)
					{
						int num2 = PackedSpanHelpers.IndexOf(Unsafe.Add<char>(ref this._firstChar, num), value, this.Length - num);
						if (num2 < 0)
						{
							break;
						}
						valueListBuilder.Append(num + num2);
						num += num2 + 1;
					}
				}
				else
				{
					for (;;)
					{
						int num3 = SpanHelpers.NonPackedIndexOfChar(Unsafe.Add<char>(ref this._firstChar, num), value, this.Length - num);
						if (num3 < 0)
						{
							break;
						}
						valueListBuilder.Append(num + num3);
						num += num3 + 1;
					}
				}
			}
			else
			{
				int num4 = 0;
				for (;;)
				{
					int num5 = SpanHelpers.IndexOf(Unsafe.Add<char>(ref this._firstChar, num4), this.Length - num4, ref oldValue._firstChar, oldValue.Length);
					if (num5 < 0)
					{
						break;
					}
					valueListBuilder.Append(num4 + num5);
					num4 += num5 + oldValue.Length;
				}
			}
			if (valueListBuilder.Length == 0)
			{
				return this;
			}
			string result = this.ReplaceHelper(oldValue.Length, newValue, valueListBuilder.AsSpan());
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00018D60 File Offset: 0x00016F60
		private unsafe string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices)
		{
			long num = (long)this.Length + (long)(newValue.Length - oldValueLength) * (long)indices.Length;
			if (num > 2147483647L)
			{
				ThrowHelper.ThrowOutOfMemoryException_StringTooLong();
			}
			string text = string.FastAllocateString((int)num);
			Span<char> span = new Span<char>(ref text._firstChar, text.Length);
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < indices.Length; i++)
			{
				int num4 = *indices[i];
				int num5 = num4 - num2;
				if (num5 != 0)
				{
					this.AsSpan(num2, num5).CopyTo(span.Slice(num3));
					num3 += num5;
				}
				num2 = num4 + oldValueLength;
				newValue.CopyTo(span.Slice(num3));
				num3 += newValue.Length;
			}
			this.AsSpan(num2).CopyTo(span.Slice(num3));
			return text;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00018E2D File Offset: 0x0001702D
		public string ReplaceLineEndings()
		{
			return this.ReplaceLineEndings("\r\n");
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00018E3A File Offset: 0x0001703A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ReplaceLineEndings(string replacementText)
		{
			if (!(replacementText == "\n"))
			{
				return this.ReplaceLineEndingsCore(replacementText);
			}
			return this.ReplaceLineEndingsWithLineFeed();
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00018E58 File Offset: 0x00017058
		private unsafe string ReplaceLineEndingsCore(string replacementText)
		{
			ArgumentNullException.ThrowIfNull(replacementText, "replacementText");
			int num2;
			int num = string.IndexOfNewlineChar(this, replacementText, out num2);
			if (num < 0)
			{
				return this;
			}
			ReadOnlySpan<char> str = this.AsSpan(0, num);
			ReadOnlySpan<char> readOnlySpan = this.AsSpan(num + num2);
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			for (;;)
			{
				int num3 = string.IndexOfNewlineChar(readOnlySpan, replacementText, out num2);
				if (num3 < 0)
				{
					break;
				}
				valueStringBuilder.Append(replacementText);
				valueStringBuilder.Append(readOnlySpan.Slice(0, num3));
				readOnlySpan = readOnlySpan.Slice(num3 + num2);
			}
			string result = str + valueStringBuilder.AsSpan() + replacementText + readOnlySpan;
			valueStringBuilder.Dispose();
			return result;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00018F08 File Offset: 0x00017108
		private unsafe static int IndexOfNewlineChar(ReadOnlySpan<char> text, string replacementText, out int stride)
		{
			stride = 0;
			int num = 0;
			for (;;)
			{
				int num2 = text.IndexOfAny(string.SearchValuesStorage.NewLineChars);
				if (num2 >= text.Length)
				{
					break;
				}
				num += num2;
				stride = 1;
				if (*text[num2] == 13)
				{
					int num3 = num2 + 1;
					if (num3 < text.Length && *text[num3] == 10)
					{
						stride = 2;
						if (replacementText != "\r\n")
						{
							return num;
						}
					}
					else if (replacementText != "\r")
					{
						return num;
					}
				}
				else if (replacementText.Length != 1 || replacementText[0] != (char)(*text[num2]))
				{
					return num;
				}
				num += stride;
				text = text.Slice(num2 + stride);
			}
			return -1;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00018FB8 File Offset: 0x000171B8
		private unsafe string ReplaceLineEndingsWithLineFeed()
		{
			int num = this.AsSpan().IndexOfAny("\r\f\u0085\u2028\u2029");
			if (num >= this.Length)
			{
				return this;
			}
			int num2 = (this[num] == '\r' && num + 1 < this.Length && this[num + 1] == '\n') ? 2 : 1;
			ReadOnlySpan<char> readOnlySpan = this.AsSpan(num + num2);
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			for (;;)
			{
				int num3 = readOnlySpan.IndexOfAny("\r\f\u0085\u2028\u2029");
				if (num3 >= readOnlySpan.Length)
				{
					break;
				}
				num2 = ((*readOnlySpan[num3] == 13 && num3 + 1 < readOnlySpan.Length && *readOnlySpan[num3 + 1] == 10) ? 2 : 1);
				valueStringBuilder.Append('\n');
				valueStringBuilder.Append(readOnlySpan.Slice(0, num3));
				readOnlySpan = readOnlySpan.Slice(num3 + num2);
			}
			valueStringBuilder.Append('\n');
			string result = this.AsSpan(0, num) + valueStringBuilder.AsSpan() + readOnlySpan;
			valueStringBuilder.Dispose();
			return result;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000190CF File Offset: 0x000172CF
		public string[] Split(char separator, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(new ReadOnlySpan<char>(ref separator), int.MaxValue, options);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000190E4 File Offset: 0x000172E4
		public string[] Split(char separator, int count, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(new ReadOnlySpan<char>(ref separator), count, options);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000190F5 File Offset: 0x000172F5
		public string[] Split([Nullable(2)] params char[] separator)
		{
			return this.SplitInternal(separator, int.MaxValue, StringSplitOptions.None);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00019109 File Offset: 0x00017309
		[NullableContext(0)]
		[return: Nullable(1)]
		public string[] Split([ParamCollection] [ScopedRef] ReadOnlySpan<char> separator)
		{
			return this.SplitInternal(separator, int.MaxValue, StringSplitOptions.None);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00019118 File Offset: 0x00017318
		public string[] Split([Nullable(2)] char[] separator, int count)
		{
			return this.SplitInternal(separator, count, StringSplitOptions.None);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00019128 File Offset: 0x00017328
		public string[] Split([Nullable(2)] char[] separator, StringSplitOptions options)
		{
			return this.SplitInternal(separator, int.MaxValue, options);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001913C File Offset: 0x0001733C
		public string[] Split([Nullable(2)] char[] separator, int count, StringSplitOptions options)
		{
			return this.SplitInternal(separator, count, options);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0001914C File Offset: 0x0001734C
		private unsafe string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			string.CheckStringSplitOptions(options);
			while (count > 1 && this.Length != 0)
			{
				if (separators.IsEmpty && count > this.Length)
				{
					options &= ~StringSplitOptions.TrimEntries;
				}
				Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
				ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
				string.MakeSeparatorListAny(this, separators, ref valueListBuilder);
				ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
				if (sepList.Length != 0)
				{
					string[] result = (options != StringSplitOptions.None) ? this.SplitWithPostProcessing(sepList, default(ReadOnlySpan<int>), 1, count, options) : this.SplitWithoutPostProcessing(sepList, default(ReadOnlySpan<int>), 1, count);
					valueListBuilder.Dispose();
					return result;
				}
				count = 1;
			}
			return this.CreateSplitArrayOfThisAsSoleValue(options, count);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00019207 File Offset: 0x00017407
		public string[] Split([Nullable(2)] string separator, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(separator ?? string.Empty, null, int.MaxValue, options);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00019220 File Offset: 0x00017420
		public string[] Split([Nullable(2)] string separator, int count, StringSplitOptions options = StringSplitOptions.None)
		{
			return this.SplitInternal(separator ?? string.Empty, null, count, options);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00019235 File Offset: 0x00017435
		public string[] Split([Nullable(new byte[]
		{
			2,
			1
		})] string[] separator, StringSplitOptions options)
		{
			return this.SplitInternal(null, separator, int.MaxValue, options);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00019245 File Offset: 0x00017445
		public string[] Split([Nullable(new byte[]
		{
			2,
			1
		})] string[] separator, int count, StringSplitOptions options)
		{
			return this.SplitInternal(null, separator, count, options);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00019254 File Offset: 0x00017454
		private unsafe string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			string.CheckStringSplitOptions(options);
			bool flag = separator != null;
			if (!flag && (separators == null || separators.Length == 0))
			{
				return this.SplitInternal(default(ReadOnlySpan<char>), count, options);
			}
			while (count > 1 && this.Length != 0)
			{
				if (flag)
				{
					if (separator.Length != 0)
					{
						return this.SplitInternal(separator, count, options);
					}
					count = 1;
				}
				else
				{
					Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
					ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
					initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
					ValueListBuilder<int> valueListBuilder2 = new ValueListBuilder<int>(initialSpan);
					string.MakeSeparatorListAny(this, separators, ref valueListBuilder, ref valueListBuilder2);
					ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
					ReadOnlySpan<int> lengthList = valueListBuilder2.AsSpan();
					if (sepList.Length == 0)
					{
						return this.CreateSplitArrayOfThisAsSoleValue(options, count);
					}
					string[] result = (options != StringSplitOptions.None) ? this.SplitWithPostProcessing(sepList, lengthList, 0, count, options) : this.SplitWithoutPostProcessing(sepList, lengthList, 0, count);
					valueListBuilder.Dispose();
					valueListBuilder2.Dispose();
					return result;
				}
			}
			return this.CreateSplitArrayOfThisAsSoleValue(options, count);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00019368 File Offset: 0x00017568
		private string[] CreateSplitArrayOfThisAsSoleValue(StringSplitOptions options, int count)
		{
			if (count != 0)
			{
				string text = this;
				if ((options & StringSplitOptions.TrimEntries) != StringSplitOptions.None)
				{
					text = text.Trim();
				}
				if ((options & StringSplitOptions.RemoveEmptyEntries) == StringSplitOptions.None || text.Length != 0)
				{
					return new string[]
					{
						text
					};
				}
			}
			return Array.Empty<string>();
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000193A4 File Offset: 0x000175A4
		private unsafe string[] SplitInternal(string separator, int count, StringSplitOptions options)
		{
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			string.MakeSeparatorList(this, separator, ref valueListBuilder);
			ReadOnlySpan<int> sepList = valueListBuilder.AsSpan();
			if (sepList.Length == 0)
			{
				return this.CreateSplitArrayOfThisAsSoleValue(options, count);
			}
			string[] result = (options != StringSplitOptions.None) ? this.SplitWithPostProcessing(sepList, default(ReadOnlySpan<int>), separator.Length, count, options) : this.SplitWithoutPostProcessing(sepList, default(ReadOnlySpan<int>), separator.Length, count);
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00019434 File Offset: 0x00017634
		private unsafe string[] SplitWithoutPostProcessing(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			int num = 0;
			int num2 = 0;
			count--;
			int num3 = (sepList.Length < count) ? sepList.Length : count;
			string[] array = new string[num3 + 1];
			int num4 = 0;
			while (num4 < num3 && num < this.Length)
			{
				array[num2++] = this.Substring(num, *sepList[num4] - num);
				num = *sepList[num4] + (lengthList.IsEmpty ? defaultLength : (*lengthList[num4]));
				num4++;
			}
			if (num < this.Length && num3 >= 0)
			{
				array[num2] = this.Substring(num);
			}
			else if (num2 == num3)
			{
				array[num2] = string.Empty;
			}
			return array;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000194E8 File Offset: 0x000176E8
		private unsafe string[] SplitWithPostProcessing(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count, StringSplitOptions options)
		{
			int length = sepList.Length;
			string[] array = new string[(length < count) ? (length + 1) : count];
			int num = 0;
			int num2 = 0;
			int i = 0;
			ReadOnlySpan<char> span;
			while (i < length)
			{
				span = this.AsSpan(num, *sepList[i] - num);
				if ((options & StringSplitOptions.TrimEntries) != StringSplitOptions.None)
				{
					span = span.Trim();
				}
				if (!span.IsEmpty || (options & StringSplitOptions.RemoveEmptyEntries) == StringSplitOptions.None)
				{
					array[num2++] = span.ToString();
				}
				num = *sepList[i] + (lengthList.IsEmpty ? defaultLength : (*lengthList[i]));
				if (num2 == count - 1)
				{
					if ((options & StringSplitOptions.RemoveEmptyEntries) != StringSplitOptions.None)
					{
						while (++i < length)
						{
							span = this.AsSpan(num, *sepList[i] - num);
							if ((options & StringSplitOptions.TrimEntries) != StringSplitOptions.None)
							{
								span = span.Trim();
							}
							if (!span.IsEmpty)
							{
								break;
							}
							num = *sepList[i] + (lengthList.IsEmpty ? defaultLength : (*lengthList[i]));
						}
						break;
					}
					break;
				}
				else
				{
					i++;
				}
			}
			span = this.AsSpan(num);
			if ((options & StringSplitOptions.TrimEntries) != StringSplitOptions.None)
			{
				span = span.Trim();
			}
			if (!span.IsEmpty || (options & StringSplitOptions.RemoveEmptyEntries) == StringSplitOptions.None)
			{
				array[num2++] = span.ToString();
			}
			Array.Resize<string>(ref array, num2);
			return array;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00019640 File Offset: 0x00017840
		internal unsafe static void MakeSeparatorListAny(ReadOnlySpan<char> source, ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder)
		{
			if (separators.Length == 0)
			{
				for (int i = 0; i < source.Length; i++)
				{
					if (char.IsWhiteSpace((char)(*source[i])))
					{
						sepListBuilder.Append(i);
					}
				}
				return;
			}
			if (separators.Length > 3)
			{
				ProbabilisticMap probabilisticMap = new ProbabilisticMap(separators);
				ref uint charMap = ref Unsafe.As<ProbabilisticMap, uint>(ref probabilisticMap);
				for (int j = 0; j < source.Length; j++)
				{
					if (ProbabilisticMap.Contains(ref charMap, separators, (int)(*source[j])))
					{
						sepListBuilder.Append(j);
					}
				}
				return;
			}
			char c = (char)(*separators[0]);
			char c2 = (char)((separators.Length > 1) ? (*separators[1]) : ((ushort)c));
			char c3 = (char)((separators.Length > 2) ? (*separators[2]) : ((ushort)c2));
			if (Vector128.IsHardwareAccelerated && source.Length >= Vector128<ushort>.Count * 2)
			{
				string.MakeSeparatorListVectorized(source, ref sepListBuilder, c, c2, c3);
				return;
			}
			for (int k = 0; k < source.Length; k++)
			{
				char c4 = (char)(*source[k]);
				if (c4 == c || c4 == c2 || c4 == c3)
				{
					sepListBuilder.Append(k);
				}
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00019764 File Offset: 0x00017964
		private unsafe static void MakeSeparatorListVectorized(ReadOnlySpan<char> sourceSpan, ref ValueListBuilder<int> sepListBuilder, char c, char c2, char c3)
		{
			if (!Vector128.IsHardwareAccelerated)
			{
				throw new PlatformNotSupportedException();
			}
			UIntPtr uintPtr = (UIntPtr)sourceSpan.Length;
			UIntPtr uintPtr2 = (UIntPtr)((IntPtr)0);
			ref char reference = ref MemoryMarshal.GetReference<char>(sourceSpan);
			if (false)
			{
			}
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated)
			{
				Vector128<ushort> right = Vector128.Create((ushort)c);
				Vector128<ushort> right2 = Vector128.Create((ushort)c2);
				Vector128<ushort> right3 = Vector128.Create((ushort)c3);
				do
				{
					Vector128<ushort> left = Vector128.LoadUnsafe(ref reference, uintPtr2);
					Vector128<ushort> left2 = Vector128.Equals<ushort>(left, right);
					Vector128<ushort> right4 = Vector128.Equals<ushort>(left, right2);
					Vector128<ushort> right5 = Vector128.Equals<ushort>(left, right3);
					Vector128<byte> vector = (left2 | right4 | right5).AsByte<ushort>();
					if (vector != Vector128<byte>.Zero)
					{
						uint num = vector.ExtractMostSignificantBits<byte>() & 21845U;
						do
						{
							uint num2 = (uint)(BitOperations.TrailingZeroCount(num) / 2);
							sepListBuilder.Append((int)(uintPtr2 + (UIntPtr)num2));
							num = BitOperations.ResetLowestSetBit(num);
						}
						while (num != 0U);
					}
					uintPtr2 += (UIntPtr)((IntPtr)Vector128<ushort>.Count);
				}
				while (uintPtr2 <= uintPtr - (UIntPtr)((IntPtr)Vector128<ushort>.Count));
			}
			while (uintPtr2 < uintPtr)
			{
				char c4 = *Unsafe.Add<char>(ref reference, uintPtr2);
				if (c4 == c || c4 == c2 || c4 == c3)
				{
					sepListBuilder.Append((int)uintPtr2);
				}
				uintPtr2++;
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00019880 File Offset: 0x00017A80
		internal static void MakeSeparatorList(ReadOnlySpan<char> source, ReadOnlySpan<char> separator, ref ValueListBuilder<int> sepListBuilder)
		{
			int num = 0;
			while (!source.IsEmpty)
			{
				int num2 = source.IndexOf(separator);
				if (num2 < 0)
				{
					break;
				}
				num += num2;
				sepListBuilder.Append(num);
				num += separator.Length;
				source = source.Slice(num2 + separator.Length);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000198D0 File Offset: 0x00017AD0
		internal unsafe static void MakeSeparatorListAny(ReadOnlySpan<char> source, ReadOnlySpan<string> separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder)
		{
			for (int i = 0; i < source.Length; i++)
			{
				for (int j = 0; j < separators.Length; j++)
				{
					string text = *separators[j];
					if (!string.IsNullOrEmpty(text))
					{
						int length = text.Length;
						if (*source[i] == (ushort)text[0] && length <= source.Length - i && (length == 1 || source.Slice(i, length).SequenceEqual(text)))
						{
							sepListBuilder.Append(i);
							lengthListBuilder.Append(length);
							i += length - 1;
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001996B File Offset: 0x00017B6B
		internal static void CheckStringSplitOptions(StringSplitOptions options)
		{
			if ((options & ~(StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)) != StringSplitOptions.None)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidFlag, ExceptionArgument.options);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001997C File Offset: 0x00017B7C
		public string Substring(int startIndex)
		{
			if (startIndex == 0)
			{
				return this;
			}
			int num = this.Length - startIndex;
			if (num == 0)
			{
				return string.Empty;
			}
			if (startIndex > this.Length)
			{
				this.ThrowSubstringArgumentOutOfRange(startIndex, num);
			}
			return this.InternalSubString(startIndex, num);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000199B9 File Offset: 0x00017BB9
		public string Substring(int startIndex, int length)
		{
			if ((ulong)startIndex + (ulong)length > (ulong)this.Length)
			{
				this.ThrowSubstringArgumentOutOfRange(startIndex, length);
			}
			if (length == 0)
			{
				return string.Empty;
			}
			if (length == this.Length)
			{
				return this;
			}
			return this.InternalSubString(startIndex, length);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000199ED File Offset: 0x00017BED
		[DoesNotReturn]
		private void ThrowSubstringArgumentOutOfRange(int startIndex, int length)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			if (startIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_StartIndexLargerThanLength);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			throw new ArgumentOutOfRangeException("length", SR.ArgumentOutOfRange_IndexLength);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00019A30 File Offset: 0x00017C30
		private string InternalSubString(int startIndex, int length)
		{
			string text = string.FastAllocateString(length);
			UIntPtr elementCount = (UIntPtr)length;
			Buffer.Memmove<char>(ref text._firstChar, Unsafe.Add<char>(ref this._firstChar, (IntPtr)((UIntPtr)startIndex)), elementCount);
			return text;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00019A5F File Offset: 0x00017C5F
		public string ToLower()
		{
			return this.ToLower(null);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00019A68 File Offset: 0x00017C68
		public string ToLower([Nullable(2)] CultureInfo culture)
		{
			return (culture ?? CultureInfo.CurrentCulture).TextInfo.ToLower(this);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00019A7F File Offset: 0x00017C7F
		public string ToLowerInvariant()
		{
			return TextInfo.Invariant.ToLower(this);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00019A8C File Offset: 0x00017C8C
		public string ToUpper()
		{
			return this.ToUpper(null);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00019A95 File Offset: 0x00017C95
		public string ToUpper([Nullable(2)] CultureInfo culture)
		{
			return (culture ?? CultureInfo.CurrentCulture).TextInfo.ToUpper(this);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00019AAC File Offset: 0x00017CAC
		public string ToUpperInvariant()
		{
			return TextInfo.Invariant.ToUpper(this);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00019AB9 File Offset: 0x00017CB9
		public string Trim()
		{
			if (this.Length == 0 || (!char.IsWhiteSpace(this._firstChar) && !char.IsWhiteSpace(this[this.Length - 1])))
			{
				return this;
			}
			return this.TrimWhiteSpaceHelper(TrimType.Both);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00019AEE File Offset: 0x00017CEE
		public unsafe string Trim(char trimChar)
		{
			if (this.Length == 0 || (this._firstChar != trimChar && this[this.Length - 1] != trimChar))
			{
				return this;
			}
			return this.TrimHelper(&trimChar, 1, TrimType.Both);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00019B20 File Offset: 0x00017D20
		public unsafe string Trim([Nullable(2)] params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(TrimType.Both);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, TrimType.Both);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00019B54 File Offset: 0x00017D54
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe string Trim([ParamCollection] [ScopedRef] ReadOnlySpan<char> trimChars)
		{
			if (trimChars.IsEmpty)
			{
				return this.TrimWhiteSpaceHelper(TrimType.Both);
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(trimChars))
			{
				char* trimChars2 = reference;
				return this.TrimHelper(trimChars2, trimChars.Length, TrimType.Both);
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00019B8B File Offset: 0x00017D8B
		public string TrimStart()
		{
			return this.TrimWhiteSpaceHelper(TrimType.Head);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00019B94 File Offset: 0x00017D94
		public unsafe string TrimStart(char trimChar)
		{
			return this.TrimHelper(&trimChar, 1, TrimType.Head);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00019BA4 File Offset: 0x00017DA4
		public unsafe string TrimStart([Nullable(2)] params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(TrimType.Head);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, TrimType.Head);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00019BD8 File Offset: 0x00017DD8
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe string TrimStart([ParamCollection] [ScopedRef] ReadOnlySpan<char> trimChars)
		{
			if (trimChars.IsEmpty)
			{
				return this.TrimWhiteSpaceHelper(TrimType.Head);
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(trimChars))
			{
				char* trimChars2 = reference;
				return this.TrimHelper(trimChars2, trimChars.Length, TrimType.Head);
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00019C0F File Offset: 0x00017E0F
		public string TrimEnd()
		{
			return this.TrimWhiteSpaceHelper(TrimType.Tail);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00019C18 File Offset: 0x00017E18
		public unsafe string TrimEnd(char trimChar)
		{
			return this.TrimHelper(&trimChar, 1, TrimType.Tail);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00019C28 File Offset: 0x00017E28
		public unsafe string TrimEnd([Nullable(2)] params char[] trimChars)
		{
			if (trimChars == null || trimChars.Length == 0)
			{
				return this.TrimWhiteSpaceHelper(TrimType.Tail);
			}
			fixed (char* ptr = &trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, TrimType.Tail);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00019C5C File Offset: 0x00017E5C
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe string TrimEnd([ParamCollection] [ScopedRef] ReadOnlySpan<char> trimChars)
		{
			if (trimChars.IsEmpty)
			{
				return this.TrimWhiteSpaceHelper(TrimType.Tail);
			}
			fixed (char* ptr = trimChars[0])
			{
				char* trimChars2 = ptr;
				return this.TrimHelper(trimChars2, trimChars.Length, TrimType.Tail);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00019C98 File Offset: 0x00017E98
		private string TrimWhiteSpaceHelper(TrimType trimType)
		{
			int num = this.Length - 1;
			int num2 = 0;
			if ((trimType & TrimType.Head) != (TrimType)0)
			{
				num2 = 0;
				while (num2 < this.Length && char.IsWhiteSpace(this[num2]))
				{
					num2++;
				}
			}
			if ((trimType & TrimType.Tail) != (TrimType)0)
			{
				num = this.Length - 1;
				while (num >= num2 && char.IsWhiteSpace(this[num]))
				{
					num--;
				}
			}
			return this.CreateTrimmedString(num2, num);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00019D04 File Offset: 0x00017F04
		private unsafe string TrimHelper(char* trimChars, int trimCharsLength, TrimType trimType)
		{
			int i = this.Length - 1;
			int j = 0;
			if ((trimType & TrimType.Head) != (TrimType)0)
			{
				for (j = 0; j < this.Length; j++)
				{
					char c = this[j];
					int num = 0;
					while (num < trimCharsLength && trimChars[num] != c)
					{
						num++;
					}
					if (num == trimCharsLength)
					{
						break;
					}
				}
			}
			if ((trimType & TrimType.Tail) != (TrimType)0)
			{
				for (i = this.Length - 1; i >= j; i--)
				{
					char c2 = this[i];
					int num2 = 0;
					while (num2 < trimCharsLength && trimChars[num2] != c2)
					{
						num2++;
					}
					if (num2 == trimCharsLength)
					{
						break;
					}
				}
			}
			return this.CreateTrimmedString(j, i);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00019DA4 File Offset: 0x00017FA4
		private string CreateTrimmedString(int start, int end)
		{
			int num = end - start + 1;
			if (num == this.Length)
			{
				return this;
			}
			if (num != 0)
			{
				return this.InternalSubString(start, num);
			}
			return string.Empty;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00019DD4 File Offset: 0x00017FD4
		public bool Contains(string value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (RuntimeHelpers.IsKnownConstant(value) && value.Length == 1)
			{
				return this.Contains(value[0]);
			}
			return SpanHelpers.IndexOf(ref this._firstChar, this.Length, ref value._firstChar, value.Length) >= 0;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00019E2C File Offset: 0x0001802C
		public bool Contains(string value, StringComparison comparisonType)
		{
			return this.IndexOf(value, comparisonType) >= 0;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00019E3C File Offset: 0x0001803C
		public bool Contains(char value)
		{
			return SpanHelpers.ContainsValueType<short>(Unsafe.As<char, short>(ref this._firstChar), (short)value, this.Length);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00019E56 File Offset: 0x00018056
		public bool Contains(char value, StringComparison comparisonType)
		{
			return this.IndexOf(value, comparisonType) != -1;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00019E66 File Offset: 0x00018066
		public int IndexOf(char value)
		{
			return SpanHelpers.IndexOfChar(ref this._firstChar, value, this.Length);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00019E7A File Offset: 0x0001807A
		public int IndexOf(char value, int startIndex)
		{
			return this.IndexOf(value, startIndex, this.Length - startIndex);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00019E8C File Offset: 0x0001808C
		public int IndexOf(char value, StringComparison comparisonType)
		{
			int result;
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				result = CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
				break;
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				result = CompareInfo.Invariant.IndexOf(this, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
				break;
			case StringComparison.Ordinal:
				result = this.IndexOf(value);
				break;
			case StringComparison.OrdinalIgnoreCase:
				result = this.IndexOfCharOrdinalIgnoreCase(value);
				break;
			default:
				throw new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
			return result;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00019F10 File Offset: 0x00018110
		private int IndexOfCharOrdinalIgnoreCase(char value)
		{
			if (!char.IsAscii(value))
			{
				return Ordinal.IndexOfOrdinalIgnoreCase(this, new ReadOnlySpan<char>(ref value));
			}
			if (!char.IsAsciiLetter(value))
			{
				return SpanHelpers.IndexOfChar(ref this._firstChar, value, this.Length);
			}
			char c = value | ' ';
			char value2 = (char)((int)value & -33);
			if (!PackedSpanHelpers.PackedIndexOfIsSupported)
			{
				return SpanHelpers.IndexOfAnyChar(ref this._firstChar, c, value2, this.Length);
			}
			return PackedSpanHelpers.IndexOfAnyIgnoreCase(ref this._firstChar, c, this.Length);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00019F8C File Offset: 0x0001818C
		public int IndexOf(char value, int startIndex, int count)
		{
			if (startIndex > this.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (count > this.Length - startIndex)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
			}
			int num = SpanHelpers.IndexOfChar(Unsafe.Add<char>(ref this._firstChar, startIndex), value, count);
			if (num >= 0)
			{
				return num + startIndex;
			}
			return num;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00019FD9 File Offset: 0x000181D9
		public int IndexOfAny(char[] anyOf)
		{
			if (anyOf == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.anyOf);
			}
			return new ReadOnlySpan<char>(ref this._firstChar, this.Length).IndexOfAny(anyOf);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0001A001 File Offset: 0x00018201
		public int IndexOfAny(char[] anyOf, int startIndex)
		{
			return this.IndexOfAny(anyOf, startIndex, this.Length - startIndex);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0001A014 File Offset: 0x00018214
		public int IndexOfAny(char[] anyOf, int startIndex, int count)
		{
			if (anyOf == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.anyOf);
			}
			if (startIndex > this.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (count > this.Length - startIndex)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
			}
			int num = new ReadOnlySpan<char>(Unsafe.Add<char>(ref this._firstChar, startIndex), count).IndexOfAny(anyOf);
			if (num >= 0)
			{
				return num + startIndex;
			}
			return num;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001A075 File Offset: 0x00018275
		public int IndexOf(string value)
		{
			return this.IndexOf(value, StringComparison.CurrentCulture);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0001A07F File Offset: 0x0001827F
		public int IndexOf(string value, int startIndex)
		{
			return this.IndexOf(value, startIndex, StringComparison.CurrentCulture);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001A08A File Offset: 0x0001828A
		public int IndexOf(string value, int startIndex, int count)
		{
			return this.IndexOf(value, startIndex, count, StringComparison.CurrentCulture);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0001A096 File Offset: 0x00018296
		public int IndexOf(string value, StringComparison comparisonType)
		{
			return this.IndexOf(value, 0, this.Length, comparisonType);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001A0A7 File Offset: 0x000182A7
		public int IndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			return this.IndexOf(value, startIndex, this.Length - startIndex, comparisonType);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001A0BC File Offset: 0x000182BC
		public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			int result;
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				result = CultureInfo.CurrentCulture.CompareInfo.IndexOf(this, value, startIndex, count, string.GetCaseCompareOfComparisonCulture(comparisonType));
				break;
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				result = CompareInfo.Invariant.IndexOf(this, value, startIndex, count, string.GetCaseCompareOfComparisonCulture(comparisonType));
				break;
			case StringComparison.Ordinal:
			case StringComparison.OrdinalIgnoreCase:
				result = Ordinal.IndexOf(this, value, startIndex, count, comparisonType == StringComparison.OrdinalIgnoreCase);
				break;
			default:
				throw (value == null) ? new ArgumentNullException("value") : new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
			return result;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001A150 File Offset: 0x00018350
		public int LastIndexOf(char value)
		{
			return SpanHelpers.LastIndexOfValueType<short>(Unsafe.As<char, short>(ref this._firstChar), (short)value, this.Length);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001A16A File Offset: 0x0001836A
		public int LastIndexOf(char value, int startIndex)
		{
			return this.LastIndexOf(value, startIndex, startIndex + 1);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001A178 File Offset: 0x00018378
		public int LastIndexOf(char value, int startIndex, int count)
		{
			if (this.Length == 0)
			{
				return -1;
			}
			if (startIndex >= this.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			if (count > startIndex + 1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
			}
			int num = startIndex + 1 - count;
			int num2 = SpanHelpers.LastIndexOfValueType<short>(Unsafe.As<char, short>(Unsafe.Add<char>(ref this._firstChar, num)), (short)value, count);
			if (num2 >= 0)
			{
				return num2 + num;
			}
			return num2;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0001A1D6 File Offset: 0x000183D6
		public int LastIndexOfAny(char[] anyOf)
		{
			if (anyOf == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.anyOf);
			}
			return new ReadOnlySpan<char>(ref this._firstChar, this.Length).LastIndexOfAny(anyOf);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0001A1FE File Offset: 0x000183FE
		public int LastIndexOfAny(char[] anyOf, int startIndex)
		{
			return this.LastIndexOfAny(anyOf, startIndex, startIndex + 1);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0001A20C File Offset: 0x0001840C
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
		{
			if (anyOf == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.anyOf);
			}
			if (this.Length == 0)
			{
				return -1;
			}
			if (startIndex >= this.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			if (count < 0 || count - 1 > startIndex)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
			}
			int num = startIndex + 1 - count;
			int num2 = new ReadOnlySpan<char>(Unsafe.Add<char>(ref this._firstChar, num), count).LastIndexOfAny(anyOf);
			if (num2 >= 0)
			{
				return num2 + num;
			}
			return num2;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0001A27C File Offset: 0x0001847C
		public int LastIndexOf(string value)
		{
			return this.LastIndexOf(value, this.Length - 1, this.Length, StringComparison.CurrentCulture);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0001A294 File Offset: 0x00018494
		public int LastIndexOf(string value, int startIndex)
		{
			return this.LastIndexOf(value, startIndex, startIndex + 1, StringComparison.CurrentCulture);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0001A2A2 File Offset: 0x000184A2
		public int LastIndexOf(string value, int startIndex, int count)
		{
			return this.LastIndexOf(value, startIndex, count, StringComparison.CurrentCulture);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0001A2AE File Offset: 0x000184AE
		public int LastIndexOf(string value, StringComparison comparisonType)
		{
			return this.LastIndexOf(value, this.Length - 1, this.Length, comparisonType);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0001A2C6 File Offset: 0x000184C6
		public int LastIndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			return this.LastIndexOf(value, startIndex, startIndex + 1, comparisonType);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0001A2D4 File Offset: 0x000184D4
		public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			int result;
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				result = CultureInfo.CurrentCulture.CompareInfo.LastIndexOf(this, value, startIndex, count, string.GetCaseCompareOfComparisonCulture(comparisonType));
				break;
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				result = CompareInfo.Invariant.LastIndexOf(this, value, startIndex, count, string.GetCaseCompareOfComparisonCulture(comparisonType));
				break;
			case StringComparison.Ordinal:
			case StringComparison.OrdinalIgnoreCase:
				result = CompareInfo.Invariant.LastIndexOf(this, value, startIndex, count, string.GetCompareOptionsFromOrdinalStringComparison(comparisonType));
				break;
			default:
				throw (value == null) ? new ArgumentNullException("value") : new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
			return result;
		}

		// Token: 0x04000297 RID: 663
		[Intrinsic]
		public static readonly string Empty;

		// Token: 0x04000298 RID: 664
		[NonSerialized]
		private readonly int _stringLength;

		// Token: 0x04000299 RID: 665
		[NonSerialized]
		private char _firstChar;

		// Token: 0x02000099 RID: 153
		internal static class SearchValuesStorage
		{
			// Token: 0x0400029A RID: 666
			public static readonly SearchValues<char> NewLineChars = SearchValues.Create("\r\f\u0085\u2028\u2029\n");

			// Token: 0x0400029B RID: 667
			public static readonly SearchValues<char> WhiteSpaceChars = SearchValues.Create("\t\n\v\f\r \u0085\u00a0\u1680\u2000\u2001\u2002\u2003\u2004\u2005\u2006\u2007\u2008\u2009\u200a\u2028\u2029\u202f\u205f\u3000");
		}
	}
}
