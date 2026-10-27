using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001597 RID: 5527
	public enum EntityState
	{
		// Token: 0x0400A7D0 RID: 42960
		[OriginalName("Default")]
		Default,
		// Token: 0x0400A7D1 RID: 42961
		[OriginalName("Sleep")]
		Sleep,
		// Token: 0x0400A7D2 RID: 42962
		[OriginalName("Born")]
		Born,
		// Token: 0x0400A7D3 RID: 42963
		[OriginalName("Other")]
		Other
	}
}
