using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155E RID: 5470
	public enum ChildQuestNodeStatus
	{
		// Token: 0x0400A620 RID: 42528
		[OriginalName("CQNS_NotActive")]
		CqnsNotActive,
		// Token: 0x0400A621 RID: 42529
		[OriginalName("CQNS_Enter")]
		CqnsEnter,
		// Token: 0x0400A622 RID: 42530
		[OriginalName("CQNS_EnterAction")]
		CqnsEnterAction,
		// Token: 0x0400A623 RID: 42531
		[OriginalName("CQNS_Progress")]
		CqnsProgress,
		// Token: 0x0400A624 RID: 42532
		[OriginalName("CQNS_Finished")]
		CqnsFinished,
		// Token: 0x0400A625 RID: 42533
		[OriginalName("CQNS_FinishAction")]
		CqnsFinishAction,
		// Token: 0x0400A626 RID: 42534
		[OriginalName("CQNS_Fail")]
		CqnsFail
	}
}
