using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001603 RID: 5635
	public enum FsmStateBehaviorType
	{
		// Token: 0x0400AC31 RID: 44081
		[OriginalName("BT_Enter")]
		BtEnter,
		// Token: 0x0400AC32 RID: 44082
		[OriginalName("BT_Exit")]
		BtExit,
		// Token: 0x0400AC33 RID: 44083
		[OriginalName("BT_BindStart")]
		BtBindStart,
		// Token: 0x0400AC34 RID: 44084
		[OriginalName("BT_BindEnd")]
		BtBindEnd,
		// Token: 0x0400AC35 RID: 44085
		[OriginalName("BT_Task")]
		BtTask
	}
}
