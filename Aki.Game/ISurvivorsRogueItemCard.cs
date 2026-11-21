using System;

// Token: 0x0200210E RID: 8462
public interface ISurvivorsRogueItemCard : ISurvivorsRogueCardBase
{
	// Token: 0x17001F6B RID: 8043
	// (get) Token: 0x06014C13 RID: 85011
	ESurvivorsRogueItemType Type { get; }

	// Token: 0x17001F6C RID: 8044
	// (get) Token: 0x06014C14 RID: 85012
	int Id { get; }

	// Token: 0x17001F6D RID: 8045
	// (get) Token: 0x06014C15 RID: 85013
	bool? IsNew { get; }
}
