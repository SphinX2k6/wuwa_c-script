using System;

// Token: 0x02001806 RID: 6150
public class BattlePassUpLevelViewData : IBattlePassUpLevelViewData
{
	// Token: 0x170016F2 RID: 5874
	// (get) Token: 0x0600F14B RID: 61771 RVA: 0x0046DF74 File Offset: 0x0046C174
	// (set) Token: 0x0600F14C RID: 61772 RVA: 0x0046DF7C File Offset: 0x0046C17C
	public int IncreasedLevel { get; set; }

	// Token: 0x170016F3 RID: 5875
	// (get) Token: 0x0600F14D RID: 61773 RVA: 0x0046DF85 File Offset: 0x0046C185
	// (set) Token: 0x0600F14E RID: 61774 RVA: 0x0046DF8D File Offset: 0x0046C18D
	public bool FirstUnlockPass { get; set; }
}
