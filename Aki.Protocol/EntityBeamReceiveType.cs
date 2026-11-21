using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001644 RID: 5700
	public enum EntityBeamReceiveType
	{
		// Token: 0x0400C272 RID: 49778
		[OriginalName("BeginAction")]
		BeginAction,
		// Token: 0x0400C273 RID: 49779
		[OriginalName("CompleteAction")]
		CompleteAction,
		// Token: 0x0400C274 RID: 49780
		[OriginalName("StopAction")]
		StopAction
	}
}
