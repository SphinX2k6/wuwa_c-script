using System;
using System.Runtime.CompilerServices;

// Token: 0x020007DA RID: 2010
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingPopularityUpData
{
	// Token: 0x06005BBA RID: 23482 RVA: 0x001D99C3 File Offset: 0x001D7BC3
	public MoonChasingPopularityUpData(int roleId, int lastPopularity, int currentPopularity, string dialogName, string title)
	{
		this.RoleId = roleId;
		this.LastPopularity = lastPopularity;
		this.CurrentPopularity = currentPopularity;
		this.DialogName = dialogName;
		this.Title = title;
	}

	// Token: 0x04003D49 RID: 15689
	public int RoleId;

	// Token: 0x04003D4A RID: 15690
	public int LastPopularity;

	// Token: 0x04003D4B RID: 15691
	public int CurrentPopularity;

	// Token: 0x04003D4C RID: 15692
	public string DialogName = string.Empty;

	// Token: 0x04003D4D RID: 15693
	public string Title;
}
