using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DF1 RID: 7665
[NullableContext(1)]
[Nullable(0)]
public class HandBookContentItemData
{
	// Token: 0x0600E98C RID: 59788 RVA: 0x00374315 File Offset: 0x00372515
	public HandBookContentItemData(string title, string desc)
	{
		this.Title = title;
		this.Desc = desc;
	}

	// Token: 0x04006C2F RID: 27695
	public string Title;

	// Token: 0x04006C30 RID: 27696
	public string Desc;
}
