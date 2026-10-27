using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155B RID: 5467
	public enum NodeStatus
	{
		// Token: 0x0400A5FD RID: 42493
		[OriginalName("NotActive")]
		NotActive,
		// Token: 0x0400A5FE RID: 42494
		[OriginalName("BeforeActivate")]
		BeforeActivate,
		// Token: 0x0400A5FF RID: 42495
		[OriginalName("Activated")]
		Activated,
		// Token: 0x0400A600 RID: 42496
		[OriginalName("Completing")]
		Completing,
		// Token: 0x0400A601 RID: 42497
		[OriginalName("CompletedSuccess")]
		CompletedSuccess,
		// Token: 0x0400A602 RID: 42498
		[OriginalName("CompletedFailed")]
		CompletedFailed,
		// Token: 0x0400A603 RID: 42499
		[OriginalName("Suspend")]
		Suspend,
		// Token: 0x0400A604 RID: 42500
		[OriginalName("Destroy")]
		Destroy
	}
}
