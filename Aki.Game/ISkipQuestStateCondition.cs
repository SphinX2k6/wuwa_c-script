using System;

// Token: 0x02001FE7 RID: 8167
public interface ISkipQuestStateCondition : ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E61 RID: 7777
	// (get) Token: 0x06014423 RID: 82979
	// (set) Token: 0x06014424 RID: 82980
	int QuestId { get; set; }

	// Token: 0x17001E62 RID: 7778
	// (get) Token: 0x06014425 RID: 82981
	// (set) Token: 0x06014426 RID: 82982
	ESkipQuestState CheckQuestState { get; set; }
}
