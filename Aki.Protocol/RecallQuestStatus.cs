using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200161E RID: 5662
	public enum RecallQuestStatus
	{
		// Token: 0x0400C000 RID: 49152
		[OriginalName("RecallQuestStatusInActive")]
		InActive,
		// Token: 0x0400C001 RID: 49153
		[OriginalName("RecallQuestStatusReady")]
		Ready,
		// Token: 0x0400C002 RID: 49154
		[OriginalName("RecallQuestStatusProgress")]
		Progress,
		// Token: 0x0400C003 RID: 49155
		[OriginalName("RecallQuestStatusFinish")]
		Finish,
		// Token: 0x0400C004 RID: 49156
		[OriginalName("RecallQuestStatusDelete")]
		Delete
	}
}
