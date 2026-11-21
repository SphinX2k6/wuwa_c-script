using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D7 RID: 5591
	public enum FailedNodeStatus
	{
		// Token: 0x0400AABE RID: 43710
		[OriginalName("FNS_NotActive")]
		FnsNotActive,
		// Token: 0x0400AABF RID: 43711
		[OriginalName("FNS_Enter")]
		FnsEnter,
		// Token: 0x0400AAC0 RID: 43712
		[OriginalName("FNS_Action")]
		FnsAction
	}
}
