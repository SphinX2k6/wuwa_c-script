using System;

// Token: 0x0200210A RID: 8458
public interface ISurvivorsRogueCharacterCard : ISurvivorsRogueCardBase
{
	// Token: 0x17001F5D RID: 8029
	// (get) Token: 0x06014BFE RID: 84990
	ESurvivorsRogueItemType Type { get; }

	// Token: 0x17001F5E RID: 8030
	// (get) Token: 0x06014BFF RID: 84991
	int Id { get; }

	// Token: 0x17001F5F RID: 8031
	// (get) Token: 0x06014C00 RID: 84992
	int? PropertyId { get; }

	// Token: 0x17001F60 RID: 8032
	// (get) Token: 0x06014C01 RID: 84993
	int? LvUpCount { get; }
}
