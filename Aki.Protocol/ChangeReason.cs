using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016CF RID: 5839
	public enum ChangeReason
	{
		// Token: 0x0400C634 RID: 50740
		[OriginalName("None")]
		None,
		// Token: 0x0400C635 RID: 50741
		[OriginalName("QuestFix")]
		QuestFix,
		// Token: 0x0400C636 RID: 50742
		[OriginalName("QuestFinish")]
		QuestFinish,
		// Token: 0x0400C637 RID: 50743
		[OriginalName("ActionFinish")]
		ActionFinish,
		// Token: 0x0400C638 RID: 50744
		[OriginalName("ActionRevert")]
		ActionRevert,
		// Token: 0x0400C639 RID: 50745
		[OriginalName("ConditionFinish")]
		ConditionFinish,
		// Token: 0x0400C63A RID: 50746
		[OriginalName("Gm")]
		Gm,
		// Token: 0x0400C63B RID: 50747
		[OriginalName("SpeakerChange")]
		SpeakerChange
	}
}
