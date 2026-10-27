using System;
using System.Runtime.CompilerServices;

// Token: 0x020019B2 RID: 6578
[NullableContext(1)]
[Nullable(0)]
public class CommonTabTitleData
{
	// Token: 0x0600BFDB RID: 49115 RVA: 0x002B4875 File Offset: 0x002B2A75
	public CommonTabTitleData(string textId, params object[] args)
	{
		this.TextId = textId;
		this.Args = args;
	}

	// Token: 0x17001016 RID: 4118
	// (get) Token: 0x0600BFDC RID: 49116 RVA: 0x002B488B File Offset: 0x002B2A8B
	public string TextId { get; }

	// Token: 0x17001017 RID: 4119
	// (get) Token: 0x0600BFDD RID: 49117 RVA: 0x002B4893 File Offset: 0x002B2A93
	public object[] Args { get; }

	// Token: 0x04005646 RID: 22086
	[Nullable(2)]
	public string RawText;
}
