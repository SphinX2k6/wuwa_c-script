using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Unicode;

namespace System.Globalization
{
	// Token: 0x0200030D RID: 781
	[NullableContext(1)]
	[Nullable(0)]
	public class StringInfo
	{
		// Token: 0x06003903 RID: 14595 RVA: 0x000BC8CB File Offset: 0x000BAACB
		public StringInfo() : this(string.Empty)
		{
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x000BC8D8 File Offset: 0x000BAAD8
		public StringInfo(string value)
		{
			this.String = value;
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x000BC8E8 File Offset: 0x000BAAE8
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			StringInfo stringInfo = value as StringInfo;
			return stringInfo != null && this._str.Equals(stringInfo._str);
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x000BC912 File Offset: 0x000BAB12
		public override int GetHashCode()
		{
			return this._str.GetHashCode();
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x000BC91F File Offset: 0x000BAB1F
		[Nullable(2)]
		private int[] Indexes
		{
			get
			{
				if (this._indexes == null && this.String.Length > 0)
				{
					this._indexes = StringInfo.ParseCombiningCharacters(this.String);
				}
				return this._indexes;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06003908 RID: 14600 RVA: 0x000BC94E File Offset: 0x000BAB4E
		// (set) Token: 0x06003909 RID: 14601 RVA: 0x000BC956 File Offset: 0x000BAB56
		public string String
		{
			get
			{
				return this._str;
			}
			[MemberNotNull("_str")]
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this._str = value;
				this._indexes = null;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600390A RID: 14602 RVA: 0x000BC971 File Offset: 0x000BAB71
		public int LengthInTextElements
		{
			get
			{
				int[] indexes = this.Indexes;
				if (indexes == null)
				{
					return 0;
				}
				return indexes.Length;
			}
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x000BC981 File Offset: 0x000BAB81
		public string SubstringByTextElements(int startingTextElement)
		{
			int[] indexes = this.Indexes;
			return this.SubstringByTextElements(startingTextElement, ((indexes != null) ? indexes.Length : 0) - startingTextElement);
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x000BC99C File Offset: 0x000BAB9C
		public string SubstringByTextElements(int startingTextElement, int lengthInTextElements)
		{
			int[] array = this.Indexes ?? Array.Empty<int>();
			if (startingTextElement >= array.Length)
			{
				throw new ArgumentOutOfRangeException("startingTextElement", startingTextElement, SR.Arg_ArgumentOutOfRangeException);
			}
			if (lengthInTextElements > array.Length - startingTextElement)
			{
				throw new ArgumentOutOfRangeException("lengthInTextElements", lengthInTextElements, SR.Arg_ArgumentOutOfRangeException);
			}
			int num = array[startingTextElement];
			Index index = new Index(0, true);
			if (startingTextElement + lengthInTextElements < array.Length)
			{
				index = array[startingTextElement + lengthInTextElements];
			}
			string @string = this.String;
			int num2 = num;
			return @string.Substring(num2, index.GetOffset(@string.Length) - num2);
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x000BCA30 File Offset: 0x000BAC30
		public static string GetNextTextElement(string str)
		{
			return StringInfo.GetNextTextElement(str, 0);
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x000BCA3C File Offset: 0x000BAC3C
		public static string GetNextTextElement(string str, int index)
		{
			int nextTextElementLength = StringInfo.GetNextTextElementLength(str, index);
			return str.Substring(index, nextTextElementLength);
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x000BCA59 File Offset: 0x000BAC59
		public static int GetNextTextElementLength(string str)
		{
			return StringInfo.GetNextTextElementLength(str, 0);
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x000BCA62 File Offset: 0x000BAC62
		public static int GetNextTextElementLength(string str, int index)
		{
			if (str == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.str);
			}
			if (index > str.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return StringInfo.GetNextTextElementLength(str.AsSpan(index));
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x000BCA88 File Offset: 0x000BAC88
		[NullableContext(0)]
		public static int GetNextTextElementLength(ReadOnlySpan<char> str)
		{
			return TextSegmentationUtility.GetLengthOfFirstUtf16ExtendedGraphemeCluster(str);
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x000BCA90 File Offset: 0x000BAC90
		public static TextElementEnumerator GetTextElementEnumerator(string str)
		{
			return StringInfo.GetTextElementEnumerator(str, 0);
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x000BCA99 File Offset: 0x000BAC99
		public static TextElementEnumerator GetTextElementEnumerator(string str, int index)
		{
			if (str == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.str);
			}
			if (index > str.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return new TextElementEnumerator(str, index);
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x000BCABC File Offset: 0x000BACBC
		public unsafe static int[] ParseCombiningCharacters(string str)
		{
			if (str == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.str);
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)256], 64);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			ReadOnlySpan<char> str2 = str;
			while (!str2.IsEmpty)
			{
				valueListBuilder.Append(str.Length - str2.Length);
				str2 = str2.Slice(StringInfo.GetNextTextElementLength(str2));
			}
			int[] result = valueListBuilder.AsSpan().ToArray();
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x04000B4C RID: 2892
		private string _str;

		// Token: 0x04000B4D RID: 2893
		private int[] _indexes;
	}
}
