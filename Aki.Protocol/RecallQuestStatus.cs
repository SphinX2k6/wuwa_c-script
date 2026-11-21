using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001691 RID: 5777
	public enum RecallQuestStatus
	{
		// Token: 0x0400C4FA RID: 50426
		[OriginalName("RecallQuestStatusInActive")]
		InActive,
		// Token: 0x0400C4FB RID: 50427
		[OriginalName("RecallQuestStatusReady")]
		Ready,
		// Token: 0x0400C4FC RID: 50428
		[OriginalName("RecallQuestStatusProgress")]
		Progress,
		// Token: 0x0400C4FD RID: 50429
		[OriginalName("RecallQuestStatusFinish")]
		Finish,
		// Token: 0x0400C4FE RID: 50430
		[OriginalName("RecallQuestStatusDelete")]
		Delete
	}
}
