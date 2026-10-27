using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001591 RID: 5521
	public enum FsmStateBehaviorType
	{
		// Token: 0x0400A7B2 RID: 42930
		[OriginalName("BT_Enter")]
		BtEnter,
		// Token: 0x0400A7B3 RID: 42931
		[OriginalName("BT_Exit")]
		BtExit,
		// Token: 0x0400A7B4 RID: 42932
		[OriginalName("BT_BindStart")]
		BtBindStart,
		// Token: 0x0400A7B5 RID: 42933
		[OriginalName("BT_BindEnd")]
		BtBindEnd,
		// Token: 0x0400A7B6 RID: 42934
		[OriginalName("BT_Task")]
		BtTask
	}
}
