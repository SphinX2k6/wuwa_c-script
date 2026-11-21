using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C4 RID: 5572
	public enum SlientFirstAwardState
	{
		// Token: 0x0400A9E7 RID: 43495
		[OriginalName("NotUnlock")]
		NotUnlock,
		// Token: 0x0400A9E8 RID: 43496
		[OriginalName("NotFinish")]
		NotFinish,
		// Token: 0x0400A9E9 RID: 43497
		[OriginalName("IsFinish")]
		IsFinish,
		// Token: 0x0400A9EA RID: 43498
		[OriginalName("IsReceive")]
		IsReceive
	}
}
