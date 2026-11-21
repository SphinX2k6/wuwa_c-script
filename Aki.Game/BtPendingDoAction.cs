using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200123A RID: 4666
[RequiredMember]
public class BtPendingDoAction : BehaviorTreePendingProcess
{
	// Token: 0x0600B967 RID: 47463 RVA: 0x0036BE65 File Offset: 0x0036A065
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public BtPendingDoAction()
	{
	}

	// Token: 0x04006AA7 RID: 27303
	[Nullable(1)]
	[RequiredMember]
	public GameCtxPb Context;

	// Token: 0x04006AA8 RID: 27304
	[RequiredMember]
	public int NodeId;

	// Token: 0x04006AA9 RID: 27305
	[RequiredMember]
	public int PlayerId;

	// Token: 0x04006AAA RID: 27306
	[RequiredMember]
	public int SessionId;

	// Token: 0x04006AAB RID: 27307
	[RequiredMember]
	public int StartIndex;

	// Token: 0x04006AAC RID: 27308
	[RequiredMember]
	public int EndIndex;

	// Token: 0x04006AAD RID: 27309
	[RequiredMember]
	public bool NeedFinishReq;
}
