using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D4 RID: 5588
	public enum ChildQuestNodeStatus
	{
		// Token: 0x0400AAAD RID: 43693
		[OriginalName("CQNS_NotActive")]
		CqnsNotActive,
		// Token: 0x0400AAAE RID: 43694
		[OriginalName("CQNS_Enter")]
		CqnsEnter,
		// Token: 0x0400AAAF RID: 43695
		[OriginalName("CQNS_EnterAction")]
		CqnsEnterAction,
		// Token: 0x0400AAB0 RID: 43696
		[OriginalName("CQNS_Progress")]
		CqnsProgress,
		// Token: 0x0400AAB1 RID: 43697
		[OriginalName("CQNS_Finished")]
		CqnsFinished,
		// Token: 0x0400AAB2 RID: 43698
		[OriginalName("CQNS_FinishAction")]
		CqnsFinishAction,
		// Token: 0x0400AAB3 RID: 43699
		[OriginalName("CQNS_Fail")]
		CqnsFail
	}
}
