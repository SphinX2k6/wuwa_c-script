using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001236 RID: 4662
[RequiredMember]
public class BtPendingUpdateChildQuestNodeStatus : BehaviorTreePendingProcess
{
	// Token: 0x0600B963 RID: 47459 RVA: 0x0036BE45 File Offset: 0x0036A045
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateChildQuestNodeStatus()
	{
	}

	// Token: 0x04006AA0 RID: 27296
	[RequiredMember]
	public int NodeId;

	// Token: 0x04006AA1 RID: 27297
	[RequiredMember]
	public ChildQuestNodeStatus NodeStatus;

	// Token: 0x04006AA2 RID: 27298
	[RequiredMember]
	public ENodeStatusUpdateReason Reason;
}
