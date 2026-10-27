using System;

// Token: 0x02002A6D RID: 10861
public interface ISkipTeleportStateCondition : ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E0B RID: 7691
	// (get) Token: 0x06016A06 RID: 92678
	// (set) Token: 0x06016A07 RID: 92679
	int MarkId { get; set; }

	// Token: 0x17001E0C RID: 7692
	// (get) Token: 0x06016A08 RID: 92680
	// (set) Token: 0x06016A09 RID: 92681
	ETeleportState CheckTeleportState { get; set; }
}
