using System;
using System.Runtime.CompilerServices;

// Token: 0x02001326 RID: 4902
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingPopularityUpData
{
	// Token: 0x0600881F RID: 34847 RVA: 0x001D0B57 File Offset: 0x001CED57
	public MoonChasingPopularityUpData(int roleId, int lastPopularity, int currentPopularity, string dialogName, string title)
	{
		this.RoleId = roleId;
		this.LastPopularity = lastPopularity;
		this.CurrentPopularity = currentPopularity;
		this.DialogName = dialogName;
		this.Title = title;
	}

	// Token: 0x04003CB1 RID: 15537
	public int RoleId;

	// Token: 0x04003CB2 RID: 15538
	public int LastPopularity;

	// Token: 0x04003CB3 RID: 15539
	public int CurrentPopularity;

	// Token: 0x04003CB4 RID: 15540
	public string DialogName = string.Empty;

	// Token: 0x04003CB5 RID: 15541
	public string Title;
}
