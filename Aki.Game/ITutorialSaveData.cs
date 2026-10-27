using System;

// Token: 0x02002C2D RID: 11309
public interface ITutorialSaveData
{
	// Token: 0x17001FBB RID: 8123
	// (get) Token: 0x060178E8 RID: 96488
	// (set) Token: 0x060178E9 RID: 96489
	int TimeStamp { get; set; }

	// Token: 0x17001FBC RID: 8124
	// (get) Token: 0x060178EA RID: 96490
	// (set) Token: 0x060178EB RID: 96491
	int TutorialId { get; set; }

	// Token: 0x17001FBD RID: 8125
	// (get) Token: 0x060178EC RID: 96492
	// (set) Token: 0x060178ED RID: 96493
	bool HasRedDot { get; set; }

	// Token: 0x17001FBE RID: 8126
	// (get) Token: 0x060178EE RID: 96494
	// (set) Token: 0x060178EF RID: 96495
	bool IsExcludedFromWiki { get; set; }
}
