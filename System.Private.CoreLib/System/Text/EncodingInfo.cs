using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x0200022E RID: 558
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class EncodingInfo
	{
		// Token: 0x06002AB0 RID: 10928 RVA: 0x00085590 File Offset: 0x00083790
		public EncodingInfo(EncodingProvider provider, int codePage, string name, string displayName) : this(codePage, name, displayName)
		{
			ArgumentNullException.ThrowIfNull(provider, "provider");
			ArgumentNullException.ThrowIfNull(name, "name");
			ArgumentNullException.ThrowIfNull(displayName, "displayName");
			this.Provider = provider;
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000855C5 File Offset: 0x000837C5
		internal EncodingInfo(int codePage, string name, string displayName)
		{
			this.CodePage = codePage;
			this.Name = name;
			this.DisplayName = displayName;
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x000855E2 File Offset: 0x000837E2
		public int CodePage { get; }

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x000855EA File Offset: 0x000837EA
		public string Name { get; }

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x000855F2 File Offset: 0x000837F2
		public string DisplayName { get; }

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000855FA File Offset: 0x000837FA
		public Encoding GetEncoding()
		{
			EncodingProvider provider = this.Provider;
			return ((provider != null) ? provider.GetEncoding(this.CodePage) : null) ?? Encoding.GetEncoding(this.CodePage);
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00085624 File Offset: 0x00083824
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			EncodingInfo encodingInfo = value as EncodingInfo;
			return encodingInfo != null && this.CodePage == encodingInfo.CodePage;
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x0008564B File Offset: 0x0008384B
		public override int GetHashCode()
		{
			return this.CodePage;
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x00085653 File Offset: 0x00083853
		[Nullable(2)]
		internal EncodingProvider Provider { get; }
	}
}
