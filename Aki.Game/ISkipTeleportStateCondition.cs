using System;

// Token: 0x02001FE8 RID: 8168
public interface ISkipTeleportStateCondition : ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E63 RID: 7779
	// (get) Token: 0x06014427 RID: 82983
	// (set) Token: 0x06014428 RID: 82984
	int MarkId { get; set; }

	// Token: 0x17001E64 RID: 7780
	// (get) Token: 0x06014429 RID: 82985
	// (set) Token: 0x0601442A RID: 82986
	ETeleportState CheckTeleportState { get; set; }
}
