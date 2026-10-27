using System;

// Token: 0x02001726 RID: 5926
public interface ICalabashUpgradeSuccessViedData
{
	// Token: 0x17000E18 RID: 3608
	// (get) Token: 0x0600AB37 RID: 43831
	// (set) Token: 0x0600AB38 RID: 43832
	bool AddExp { get; set; }

	// Token: 0x17000E19 RID: 3609
	// (get) Token: 0x0600AB39 RID: 43833
	// (set) Token: 0x0600AB3A RID: 43834
	int PreLevel { get; set; }

	// Token: 0x17000E1A RID: 3610
	// (get) Token: 0x0600AB3B RID: 43835
	// (set) Token: 0x0600AB3C RID: 43836
	int PreExp { get; set; }

	// Token: 0x17000E1B RID: 3611
	// (get) Token: 0x0600AB3D RID: 43837
	// (set) Token: 0x0600AB3E RID: 43838
	int CurLevel { get; set; }

	// Token: 0x17000E1C RID: 3612
	// (get) Token: 0x0600AB3F RID: 43839
	// (set) Token: 0x0600AB40 RID: 43840
	int CurExp { get; set; }
}
