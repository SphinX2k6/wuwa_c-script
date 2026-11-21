using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D1 RID: 5585
	public enum NodeStatus
	{
		// Token: 0x0400AA8A RID: 43658
		[OriginalName("NotActive")]
		NotActive,
		// Token: 0x0400AA8B RID: 43659
		[OriginalName("BeforeActivate")]
		BeforeActivate,
		// Token: 0x0400AA8C RID: 43660
		[OriginalName("Activated")]
		Activated,
		// Token: 0x0400AA8D RID: 43661
		[OriginalName("Completing")]
		Completing,
		// Token: 0x0400AA8E RID: 43662
		[OriginalName("CompletedSuccess")]
		CompletedSuccess,
		// Token: 0x0400AA8F RID: 43663
		[OriginalName("CompletedFailed")]
		CompletedFailed,
		// Token: 0x0400AA90 RID: 43664
		[OriginalName("Suspend")]
		Suspend,
		// Token: 0x0400AA91 RID: 43665
		[OriginalName("Destroy")]
		Destroy
	}
}
