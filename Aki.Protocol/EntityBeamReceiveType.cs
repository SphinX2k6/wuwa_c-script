using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D2 RID: 5586
	public enum EntityBeamReceiveType
	{
		// Token: 0x0400BD7E RID: 48510
		[OriginalName("BeginAction")]
		BeginAction,
		// Token: 0x0400BD7F RID: 48511
		[OriginalName("CompleteAction")]
		CompleteAction,
		// Token: 0x0400BD80 RID: 48512
		[OriginalName("StopAction")]
		StopAction
	}
}
