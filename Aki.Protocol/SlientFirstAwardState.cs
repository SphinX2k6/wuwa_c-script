using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154E RID: 5454
	public enum SlientFirstAwardState
	{
		// Token: 0x0400A589 RID: 42377
		[OriginalName("NotUnlock")]
		NotUnlock,
		// Token: 0x0400A58A RID: 42378
		[OriginalName("NotFinish")]
		NotFinish,
		// Token: 0x0400A58B RID: 42379
		[OriginalName("IsFinish")]
		IsFinish,
		// Token: 0x0400A58C RID: 42380
		[OriginalName("IsReceive")]
		IsReceive
	}
}
