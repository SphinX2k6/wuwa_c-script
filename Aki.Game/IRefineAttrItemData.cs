using System;

// Token: 0x02000BE1 RID: 3041
public interface IRefineAttrItemData
{
	// Token: 0x17000E43 RID: 3651
	// (get) Token: 0x06007F2E RID: 32558
	// (set) Token: 0x06007F2F RID: 32559
	int PropItemId { get; set; }

	// Token: 0x17000E44 RID: 3652
	// (get) Token: 0x06007F30 RID: 32560
	// (set) Token: 0x06007F31 RID: 32561
	int PropIndexId { get; set; }

	// Token: 0x17000E45 RID: 3653
	// (get) Token: 0x06007F32 RID: 32562
	// (set) Token: 0x06007F33 RID: 32563
	bool IsRecommend { get; set; }

	// Token: 0x17000E46 RID: 3654
	// (get) Token: 0x06007F34 RID: 32564
	// (set) Token: 0x06007F35 RID: 32565
	bool IsDisable { get; set; }
}
