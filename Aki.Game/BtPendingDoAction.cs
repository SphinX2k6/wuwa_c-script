using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001D78 RID: 7544
[RequiredMember]
public class BtPendingDoAction : BehaviorTreePendingProcess
{
	// Token: 0x0600E549 RID: 58697 RVA: 0x00360211 File Offset: 0x0035E411
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingDoAction()
	{
	}

	// Token: 0x040069C7 RID: 27079
	[Nullable(1)]
	[RequiredMember]
	public GameCtxPb Context;

	// Token: 0x040069C8 RID: 27080
	[RequiredMember]
	public int NodeId;

	// Token: 0x040069C9 RID: 27081
	[RequiredMember]
	public int PlayerId;

	// Token: 0x040069CA RID: 27082
	[RequiredMember]
	public int SessionId;

	// Token: 0x040069CB RID: 27083
	[RequiredMember]
	public int StartIndex;

	// Token: 0x040069CC RID: 27084
	[RequiredMember]
	public int EndIndex;

	// Token: 0x040069CD RID: 27085
	[RequiredMember]
	public bool NeedFinishReq;
}
