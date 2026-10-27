using System;

// Token: 0x02002A6C RID: 10860
public interface ISkipQuestStateCondition : ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E09 RID: 7689
	// (get) Token: 0x06016A02 RID: 92674
	// (set) Token: 0x06016A03 RID: 92675
	int QuestId { get; set; }

	// Token: 0x17001E0A RID: 7690
	// (get) Token: 0x06016A04 RID: 92676
	// (set) Token: 0x06016A05 RID: 92677
	ESkipQuestState CheckQuestState { get; set; }
}
