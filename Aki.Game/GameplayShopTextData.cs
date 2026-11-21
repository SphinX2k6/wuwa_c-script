using System;
using System.Runtime.CompilerServices;

// Token: 0x02001825 RID: 6181
[NullableContext(1)]
[Nullable(0)]
public class GameplayShopTextData
{
	// Token: 0x0600F2FE RID: 62206 RVA: 0x004741E4 File Offset: 0x004723E4
	public void SetContent(string content)
	{
		this.Content = content;
		this.Data = null;
	}

	// Token: 0x0600F2FF RID: 62207 RVA: 0x004741F4 File Offset: 0x004723F4
	[NullableContext(2)]
	public void SetData(TableTextArgNew data)
	{
		this.Data = data;
		this.Content = "";
	}

	// Token: 0x040088CA RID: 35018
	public string Content = "";

	// Token: 0x040088CB RID: 35019
	[Nullable(2)]
	public TableTextArgNew Data;
}
