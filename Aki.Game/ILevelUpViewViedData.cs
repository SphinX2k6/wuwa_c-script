using System;

// Token: 0x0200153A RID: 5434
public interface ILevelUpViewViedData
{
	// Token: 0x1700144B RID: 5195
	// (get) Token: 0x0600D9A2 RID: 55714
	// (set) Token: 0x0600D9A3 RID: 55715
	bool AddExp { get; set; }

	// Token: 0x1700144C RID: 5196
	// (get) Token: 0x0600D9A4 RID: 55716
	// (set) Token: 0x0600D9A5 RID: 55717
	int PreLevel { get; set; }

	// Token: 0x1700144D RID: 5197
	// (get) Token: 0x0600D9A6 RID: 55718
	// (set) Token: 0x0600D9A7 RID: 55719
	int PreExp { get; set; }

	// Token: 0x1700144E RID: 5198
	// (get) Token: 0x0600D9A8 RID: 55720
	// (set) Token: 0x0600D9A9 RID: 55721
	int CurLevel { get; set; }

	// Token: 0x1700144F RID: 5199
	// (get) Token: 0x0600D9AA RID: 55722
	// (set) Token: 0x0600D9AB RID: 55723
	int CurExp { get; set; }
}
