using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001659 RID: 5721
	public enum ChangeReason
	{
		// Token: 0x0400C12D RID: 49453
		[OriginalName("None")]
		None,
		// Token: 0x0400C12E RID: 49454
		[OriginalName("QuestFix")]
		QuestFix,
		// Token: 0x0400C12F RID: 49455
		[OriginalName("QuestFinish")]
		QuestFinish,
		// Token: 0x0400C130 RID: 49456
		[OriginalName("ActionFinish")]
		ActionFinish,
		// Token: 0x0400C131 RID: 49457
		[OriginalName("ActionRevert")]
		ActionRevert,
		// Token: 0x0400C132 RID: 49458
		[OriginalName("ConditionFinish")]
		ConditionFinish,
		// Token: 0x0400C133 RID: 49459
		[OriginalName("Gm")]
		Gm,
		// Token: 0x0400C134 RID: 49460
		[OriginalName("SpeakerChange")]
		SpeakerChange
	}
}
