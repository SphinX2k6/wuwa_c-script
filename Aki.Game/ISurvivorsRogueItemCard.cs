using System;

// Token: 0x02002B92 RID: 11154
public interface ISurvivorsRogueItemCard : ISurvivorsRogueCardBase
{
	// Token: 0x17001F13 RID: 7955
	// (get) Token: 0x060171E2 RID: 94690
	ESurvivorsRogueItemType Type { get; }

	// Token: 0x17001F14 RID: 7956
	// (get) Token: 0x060171E3 RID: 94691
	int Id { get; }

	// Token: 0x17001F15 RID: 7957
	// (get) Token: 0x060171E4 RID: 94692
	bool? IsNew { get; }
}
