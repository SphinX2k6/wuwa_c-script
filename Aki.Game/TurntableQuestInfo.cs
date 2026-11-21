using System;

// Token: 0x020009F2 RID: 2546
public class TurntableQuestInfo : ITurntableQuestInfo
{
	// Token: 0x17000D73 RID: 3443
	// (get) Token: 0x06006F45 RID: 28485 RVA: 0x00224703 File Offset: 0x00222903
	// (set) Token: 0x06006F46 RID: 28486 RVA: 0x0022470B File Offset: 0x0022290B
	public int QuestState { get; set; }

	// Token: 0x17000D74 RID: 3444
	// (get) Token: 0x06006F47 RID: 28487 RVA: 0x00224714 File Offset: 0x00222914
	// (set) Token: 0x06006F48 RID: 28488 RVA: 0x0022471C File Offset: 0x0022291C
	public long QuestUnlockStamp { get; set; }
}
