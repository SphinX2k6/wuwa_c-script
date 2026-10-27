using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D74 RID: 7540
[RequiredMember]
public class BtPendingUpdateChildQuestNodeStatus : BehaviorTreePendingProcess
{
	// Token: 0x0600E545 RID: 58693 RVA: 0x003601F1 File Offset: 0x0035E3F1
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateChildQuestNodeStatus()
	{
	}

	// Token: 0x040069C0 RID: 27072
	[RequiredMember]
	public int NodeId;

	// Token: 0x040069C1 RID: 27073
	[RequiredMember]
	public ChildQuestNodeStatus NodeStatus;

	// Token: 0x040069C2 RID: 27074
	[RequiredMember]
	public ENodeStatusUpdateReason Reason;
}
