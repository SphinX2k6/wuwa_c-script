using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x0200030B RID: 779
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SortKey
	{
		// Token: 0x060038F3 RID: 14579 RVA: 0x000BC677 File Offset: 0x000BA877
		internal SortKey(CompareInfo compareInfo, string str, CompareOptions options, byte[] keyData)
		{
			this._keyData = keyData;
			this._compareInfo = compareInfo;
			this._options = options;
			this._string = str;
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060038F4 RID: 14580 RVA: 0x000BC69C File Offset: 0x000BA89C
		public string OriginalString
		{
			get
			{
				return this._string;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x000BC6A4 File Offset: 0x000BA8A4
		public byte[] KeyData
		{
			get
			{
				return (byte[])this._keyData.Clone();
			}
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x000BC6B8 File Offset: 0x000BA8B8
		public static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			ArgumentNullException.ThrowIfNull(sortkey1, "sortkey1");
			ArgumentNullException.ThrowIfNull(sortkey2, "sortkey2");
			byte[] keyData = sortkey1._keyData;
			byte[] keyData2 = sortkey2._keyData;
			return new ReadOnlySpan<byte>(keyData).SequenceCompareTo(keyData2);
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x000BC6F8 File Offset: 0x000BA8F8
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			SortKey sortKey = value as SortKey;
			return sortKey != null && new ReadOnlySpan<byte>(this._keyData).SequenceEqual(sortKey._keyData);
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x000BC72C File Offset: 0x000BA92C
		public override int GetHashCode()
		{
			return this._compareInfo.GetHashCode(this._string, this._options);
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x000BC748 File Offset: 0x000BA948
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
			defaultInterpolatedStringHandler.AppendLiteral("SortKey - ");
			defaultInterpolatedStringHandler.AppendFormatted(this._compareInfo.Name);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<CompareOptions>(this._options);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted(this._string);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x04000B46 RID: 2886
		private readonly CompareInfo _compareInfo;

		// Token: 0x04000B47 RID: 2887
		private readonly CompareOptions _options;

		// Token: 0x04000B48 RID: 2888
		private readonly string _string;

		// Token: 0x04000B49 RID: 2889
		private readonly byte[] _keyData;
	}
}
