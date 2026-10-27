using System;

// Token: 0x0200153A RID: 5434
public class TurntableQuestInfo : ITurntableQuestInfo
{
	// Token: 0x17000D52 RID: 3410
	// (get) Token: 0x06009B67 RID: 39783 RVA: 0x0021A953 File Offset: 0x00218B53
	// (set) Token: 0x06009B68 RID: 39784 RVA: 0x0021A95B File Offset: 0x00218B5B
	public int QuestState { get; set; }

	// Token: 0x17000D53 RID: 3411
	// (get) Token: 0x06009B69 RID: 39785 RVA: 0x0021A964 File Offset: 0x00218B64
	// (set) Token: 0x06009B6A RID: 39786 RVA: 0x0021A96C File Offset: 0x00218B6C
	public long QuestUnlockStamp { get; set; }
}
