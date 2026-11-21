using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020001B7 RID: 439
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class CultureAwareComparer : StringComparer, IAlternateEqualityComparer<ReadOnlySpan<char>, string>, ISerializable
	{
		// Token: 0x06002177 RID: 8567 RVA: 0x00066354 File Offset: 0x00064554
		internal CultureAwareComparer(CultureInfo culture, CompareOptions options) : this(culture.CompareInfo, options)
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00066363 File Offset: 0x00064563
		internal CultureAwareComparer(CompareInfo compareInfo, CompareOptions options)
		{
			this._compareInfo = compareInfo;
			if ((options & ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort)) != CompareOptions.None)
			{
				throw new ArgumentException(SR.Argument_InvalidFlag, "options");
			}
			this._options = options;
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00066394 File Offset: 0x00064594
		private CultureAwareComparer(SerializationInfo info, StreamingContext context)
		{
			this._compareInfo = (CompareInfo)info.GetValue("_compareInfo", typeof(CompareInfo));
			bool boolean = info.GetBoolean("_ignoreCase");
			object valueNoThrow = info.GetValueNoThrow("_options", typeof(CompareOptions));
			if (valueNoThrow != null)
			{
				this._options = (CompareOptions)valueNoThrow;
			}
			this._options |= (boolean ? CompareOptions.IgnoreCase : CompareOptions.None);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0006640C File Offset: 0x0006460C
		public override int Compare(string x, string y)
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
			return this._compareInfo.Compare(x, y, this._options);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00066431 File Offset: 0x00064631
		public override bool Equals(string x, string y)
		{
			return x == y || (x != null && y != null && this._compareInfo.Compare(x, y, this._options) == 0);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00066457 File Offset: 0x00064657
		[NullableContext(1)]
		public override int GetHashCode(string obj)
		{
			ArgumentNullException.ThrowIfNull(obj, "obj");
			return this._compareInfo.GetHashCode(obj, this._options);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00066476 File Offset: 0x00064676
		int IAlternateEqualityComparer<ReadOnlySpan<char>, string>.GetHashCode(ReadOnlySpan<char> span)
		{
			return this._compareInfo.GetHashCode(span, this._options);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x0006648A File Offset: 0x0006468A
		bool IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Equals(ReadOnlySpan<char> span, string target)
		{
			return (!span.IsEmpty || target != null) && this._compareInfo.Compare(span, target, this._options) == 0;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000664B5 File Offset: 0x000646B5
		string IAlternateEqualityComparer<ReadOnlySpan<char>, string>.Create(ReadOnlySpan<char> span)
		{
			return span.ToString();
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x000664C4 File Offset: 0x000646C4
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			CultureAwareComparer cultureAwareComparer = obj as CultureAwareComparer;
			return cultureAwareComparer != null && this._options == cultureAwareComparer._options && this._compareInfo.Equals(cultureAwareComparer._compareInfo);
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x000664FC File Offset: 0x000646FC
		public override int GetHashCode()
		{
			return this._compareInfo.GetHashCode() ^ (int)(this._options & (CompareOptions)2147483647);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00066516 File Offset: 0x00064716
		[NullableContext(1)]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_compareInfo", this._compareInfo);
			info.AddValue("_options", this._options);
			info.AddValue("_ignoreCase", (this._options & CompareOptions.IgnoreCase) > CompareOptions.None);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00066555 File Offset: 0x00064755
		private protected override bool IsWellKnownCultureAwareComparerCore([NotNullWhen(true)] out CompareInfo compareInfo, out CompareOptions compareOptions)
		{
			compareInfo = this._compareInfo;
			compareOptions = this._options;
			return true;
		}

		// Token: 0x04000580 RID: 1408
		internal static readonly CultureAwareComparer InvariantCaseSensitiveInstance = new CultureAwareComparer(CompareInfo.Invariant, CompareOptions.None);

		// Token: 0x04000581 RID: 1409
		internal static readonly CultureAwareComparer InvariantIgnoreCaseInstance = new CultureAwareComparer(CompareInfo.Invariant, CompareOptions.IgnoreCase);

		// Token: 0x04000582 RID: 1410
		private readonly CompareInfo _compareInfo;

		// Token: 0x04000583 RID: 1411
		private readonly CompareOptions _options;
	}
}
