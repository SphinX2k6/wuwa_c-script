using System;

// Token: 0x02002A72 RID: 10866
public class QuestStateConditionImpl : ISkipQuestStateCondition, ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E0F RID: 7695
	// (get) Token: 0x06016A17 RID: 92695 RVA: 0x005BC1F0 File Offset: 0x005BA3F0
	// (set) Token: 0x06016A18 RID: 92696 RVA: 0x005BC1F8 File Offset: 0x005BA3F8
	public ESkipConditionType ConditionType { get; set; }

	// Token: 0x17001E10 RID: 7696
	// (get) Token: 0x06016A19 RID: 92697 RVA: 0x005BC201 File Offset: 0x005BA401
	// (set) Token: 0x06016A1A RID: 92698 RVA: 0x005BC209 File Offset: 0x005BA409
	public int QuestId { get; set; }

	// Token: 0x17001E11 RID: 7697
	// (get) Token: 0x06016A1B RID: 92699 RVA: 0x005BC212 File Offset: 0x005BA412
	// (set) Token: 0x06016A1C RID: 92700 RVA: 0x005BC21A File Offset: 0x005BA41A
	public ESkipQuestState CheckQuestState { get; set; }
}
