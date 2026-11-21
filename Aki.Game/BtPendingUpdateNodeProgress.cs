using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001237 RID: 4663
[RequiredMember]
public class BtPendingUpdateNodeProgress : BehaviorTreePendingProcess
{
	// Token: 0x0600B964 RID: 47460 RVA: 0x0036BE4D File Offset: 0x0036A04D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingUpdateNodeProgress()
	{
	}

	// Token: 0x04006AA3 RID: 27299
	[RequiredMember]
	public int NodeId;

	// Token: 0x04006AA4 RID: 27300
	[Nullable(2)]
	[RequiredMember]
	public ChildQuestNodeProgress NodeInfo;
}
