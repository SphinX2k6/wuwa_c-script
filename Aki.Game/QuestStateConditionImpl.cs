using System;

// Token: 0x02001FED RID: 8173
public class QuestStateConditionImpl : ISkipQuestStateCondition, ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E67 RID: 7783
	// (get) Token: 0x06014438 RID: 83000 RVA: 0x005E8378 File Offset: 0x005E6578
	// (set) Token: 0x06014439 RID: 83001 RVA: 0x005E8380 File Offset: 0x005E6580
	public ESkipConditionType ConditionType { get; set; }

	// Token: 0x17001E68 RID: 7784
	// (get) Token: 0x0601443A RID: 83002 RVA: 0x005E8389 File Offset: 0x005E6589
	// (set) Token: 0x0601443B RID: 83003 RVA: 0x005E8391 File Offset: 0x005E6591
	public int QuestId { get; set; }

	// Token: 0x17001E69 RID: 7785
	// (get) Token: 0x0601443C RID: 83004 RVA: 0x005E839A File Offset: 0x005E659A
	// (set) Token: 0x0601443D RID: 83005 RVA: 0x005E83A2 File Offset: 0x005E65A2
	public ESkipQuestState CheckQuestState { get; set; }
}
