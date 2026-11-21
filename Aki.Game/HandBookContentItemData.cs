using System;
using System.Runtime.CompilerServices;

// Token: 0x020012B3 RID: 4787
[NullableContext(1)]
[Nullable(0)]
public class HandBookContentItemData
{
	// Token: 0x0600BDAB RID: 48555 RVA: 0x0038001D File Offset: 0x0037E21D
	public HandBookContentItemData(string title, string desc)
	{
		this.Title = title;
		this.Desc = desc;
	}

	// Token: 0x04006D10 RID: 27920
	public string Title;

	// Token: 0x04006D11 RID: 27921
	public string Desc;
}
