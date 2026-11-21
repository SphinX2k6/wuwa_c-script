using System;

// Token: 0x02000BDE RID: 3038
public interface ICalabashUpgradeSuccessViedData
{
	// Token: 0x17000E39 RID: 3641
	// (get) Token: 0x06007F19 RID: 32537
	// (set) Token: 0x06007F1A RID: 32538
	bool AddExp { get; set; }

	// Token: 0x17000E3A RID: 3642
	// (get) Token: 0x06007F1B RID: 32539
	// (set) Token: 0x06007F1C RID: 32540
	int PreLevel { get; set; }

	// Token: 0x17000E3B RID: 3643
	// (get) Token: 0x06007F1D RID: 32541
	// (set) Token: 0x06007F1E RID: 32542
	int PreExp { get; set; }

	// Token: 0x17000E3C RID: 3644
	// (get) Token: 0x06007F1F RID: 32543
	// (set) Token: 0x06007F20 RID: 32544
	int CurLevel { get; set; }

	// Token: 0x17000E3D RID: 3645
	// (get) Token: 0x06007F21 RID: 32545
	// (set) Token: 0x06007F22 RID: 32546
	int CurExp { get; set; }
}
