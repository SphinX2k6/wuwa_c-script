using System;

// Token: 0x02001729 RID: 5929
public interface IRefineAttrItemData
{
	// Token: 0x17000E22 RID: 3618
	// (get) Token: 0x0600AB4C RID: 43852
	// (set) Token: 0x0600AB4D RID: 43853
	int PropItemId { get; set; }

	// Token: 0x17000E23 RID: 3619
	// (get) Token: 0x0600AB4E RID: 43854
	// (set) Token: 0x0600AB4F RID: 43855
	int PropIndexId { get; set; }

	// Token: 0x17000E24 RID: 3620
	// (get) Token: 0x0600AB50 RID: 43856
	// (set) Token: 0x0600AB51 RID: 43857
	bool IsRecommend { get; set; }

	// Token: 0x17000E25 RID: 3621
	// (get) Token: 0x0600AB52 RID: 43858
	// (set) Token: 0x0600AB53 RID: 43859
	bool IsDisable { get; set; }
}
