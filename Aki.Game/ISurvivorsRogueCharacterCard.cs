using System;

// Token: 0x02002B8E RID: 11150
public interface ISurvivorsRogueCharacterCard : ISurvivorsRogueCardBase
{
	// Token: 0x17001F05 RID: 7941
	// (get) Token: 0x060171CD RID: 94669
	ESurvivorsRogueItemType Type { get; }

	// Token: 0x17001F06 RID: 7942
	// (get) Token: 0x060171CE RID: 94670
	int Id { get; }

	// Token: 0x17001F07 RID: 7943
	// (get) Token: 0x060171CF RID: 94671
	int? PropertyId { get; }

	// Token: 0x17001F08 RID: 7944
	// (get) Token: 0x060171D0 RID: 94672
	int? LvUpCount { get; }
}
