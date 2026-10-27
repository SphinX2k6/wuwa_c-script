using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D75 RID: 7541
[RequiredMember]
public class BtPendingUpdateNodeProgress : BehaviorTreePendingProcess
{
	// Token: 0x0600E546 RID: 58694 RVA: 0x003601F9 File Offset: 0x0035E3F9
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateNodeProgress()
	{
	}

	// Token: 0x040069C3 RID: 27075
	[RequiredMember]
	public int NodeId;

	// Token: 0x040069C4 RID: 27076
	[Nullable(2)]
	[RequiredMember]
	public ChildQuestNodeProgress NodeInfo;
}
