using System;

// Token: 0x020008B1 RID: 2225
public interface IDamageLayoutItemData
{
	// Token: 0x17000C57 RID: 3159
	// (get) Token: 0x06006429 RID: 25641
	// (set) Token: 0x0600642A RID: 25642
	int RoleId { get; set; }

	// Token: 0x17000C58 RID: 3160
	// (get) Token: 0x0600642B RID: 25643
	// (set) Token: 0x0600642C RID: 25644
	float Damage { get; set; }

	// Token: 0x17000C59 RID: 3161
	// (get) Token: 0x0600642D RID: 25645
	// (set) Token: 0x0600642E RID: 25646
	bool IsWin { get; set; }
}
