using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001B6 RID: 438
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string>
	{
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x00066120 File Offset: 0x00064320
		public static StringComparer InvariantCulture
		{
			get
			{
				return CultureAwareComparer.InvariantCaseSensitiveInstance;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x00066127 File Offset: 0x00064327
		public static StringComparer InvariantCultureIgnoreCase
		{
			get
			{
				return CultureAwareComparer.InvariantIgnoreCaseInstance;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x0006612E File Offset: 0x0006432E
		public static StringComparer CurrentCulture
		{
			get
			{
				return new CultureAwareComparer(CultureInfo.CurrentCulture, CompareOptions.None);
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x0006613B File Offset: 0x0006433B
		public static StringComparer CurrentCultureIgnoreCase
		{
			get
			{
				return new CultureAwareComparer(CultureInfo.CurrentCulture, CompareOptions.IgnoreCase);
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x00066148 File Offset: 0x00064348
		public static StringComparer Ordinal
		{
			get
			{
				return OrdinalCaseSensitiveComparer.Instance;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0006614F File Offset: 0x0006434F
		public static StringComparer OrdinalIgnoreCase
		{
			get
			{
				return OrdinalIgnoreCaseComparer.Instance;
			}
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00066158 File Offset: 0x00064358
		public static StringComparer FromComparison(StringComparison comparisonType)
		{
			StringComparer result;
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
				result = StringComparer.CurrentCulture;
				break;
			case StringComparison.CurrentCultureIgnoreCase:
				result = StringComparer.CurrentCultureIgnoreCase;
				break;
			case StringComparison.InvariantCulture:
				result = StringComparer.InvariantCulture;
				break;
			case StringComparison.InvariantCultureIgnoreCase:
				result = StringComparer.InvariantCultureIgnoreCase;
				break;
			case StringComparison.Ordinal:
				result = StringComparer.Ordinal;
				break;
			case StringComparison.OrdinalIgnoreCase:
				result = StringComparer.OrdinalIgnoreCase;
				break;
			default:
				throw new ArgumentException(SR.NotSupported_StringComparison, "comparisonType");
			}
			return result;
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x000661C6 File Offset: 0x000643C6
		public static StringComparer Create(CultureInfo culture, bool ignoreCase)
		{
			ArgumentNullException.ThrowIfNull(culture, "culture");
			return new CultureAwareComparer(culture, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x000661E0 File Offset: 0x000643E0
		public static StringComparer Create(CultureInfo culture, CompareOptions options)
		{
			ArgumentNullException.ThrowIfNull(culture, "culture");
			return new CultureAwareComparer(culture, options);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x000661F4 File Offset: 0x000643F4
		[NullableContext(2)]
		public static bool IsWellKnownOrdinalComparer(IEqualityComparer<string> comparer, out bool ignoreCase)
		{
			IInternalStringEqualityComparer internalStringEqualityComparer = comparer as IInternalStringEqualityComparer;
			if (internalStringEqualityComparer != null)
			{
				comparer = internalStringEqualityComparer.GetUnderlyingEqualityComparer();
			}
			StringComparer stringComparer = comparer as StringComparer;
			if (stringComparer != null)
			{
				return stringComparer.IsWellKnownOrdinalComparerCore(out ignoreCase);
			}
			if (!(comparer is StringEqualityComparer) && !(comparer is GenericEqualityComparer<string>))
			{
				ignoreCase = false;
				return false;
			}
			ignoreCase = false;
			return true;
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00066240 File Offset: 0x00064440
		private protected virtual bool IsWellKnownOrdinalComparerCore(out bool ignoreCase)
		{
			ignoreCase = false;
			return false;
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00066248 File Offset: 0x00064448
		[NullableContext(2)]
		public static bool IsWellKnownCultureAwareComparer(IEqualityComparer<string> comparer, [NotNullWhen(true)] out CompareInfo compareInfo, out CompareOptions compareOptions)
		{
			IInternalStringEqualityComparer internalStringEqualityComparer = comparer as IInternalStringEqualityComparer;
			if (internalStringEqualityComparer != null)
			{
				comparer = internalStringEqualityComparer.GetUnderlyingEqualityComparer();
			}
			StringComparer stringComparer = comparer as StringComparer;
			if (stringComparer != null)
			{
				return stringComparer.IsWellKnownCultureAwareComparerCore(out compareInfo, out compareOptions);
			}
			compareInfo = null;
			compareOptions = CompareOptions.None;
			return false;
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00066281 File Offset: 0x00064481
		private protected virtual bool IsWellKnownCultureAwareComparerCore([NotNullWhen(true)] out CompareInfo compareInfo, out CompareOptions compareOptions)
		{
			compareInfo = null;
			compareOptions = CompareOptions.None;
			return false;
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x0006628C File Offset: 0x0006448C
		[NullableContext(2)]
		public int Compare(object x, object y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			string text = x as string;
			if (text != null)
			{
				string text2 = y as string;
				if (text2 != null)
				{
					return this.Compare(text, text2);
				}
			}
			IComparable comparable = x as IComparable;
			if (comparable != null)
			{
				return comparable.CompareTo(y);
			}
			throw new ArgumentException(SR.Argument_ImplementIComparable);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x000662E4 File Offset: 0x000644E4
		[NullableContext(2)]
		public bool Equals(object x, object y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			string text = x as string;
			if (text != null)
			{
				string text2 = y as string;
				if (text2 != null)
				{
					return this.Equals(text, text2);
				}
			}
			return x.Equals(y);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00066324 File Offset: 0x00064524
		public int GetHashCode(object obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			string text = obj as string;
			if (text != null)
			{
				return this.GetHashCode(text);
			}
			return obj.GetHashCode();
		}

		// Token: 0x06002173 RID: 8563
		[NullableContext(2)]
		public abstract int Compare(string x, string y);

		// Token: 0x06002174 RID: 8564
		[NullableContext(2)]
		public abstract bool Equals(string x, string y);

		// Token: 0x06002175 RID: 8565
		public abstract int GetHashCode(string obj);
	}
}
