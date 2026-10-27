using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001635 RID: 5685
	public enum GridDataUpdateReason
	{
		// Token: 0x0400C06D RID: 49261
		[OriginalName("GridUpdate")]
		GridUpdate,
		// Token: 0x0400C06E RID: 49262
		[OriginalName("ByMoveOp")]
		ByMoveOp,
		// Token: 0x0400C06F RID: 49263
		[OriginalName("Teleport")]
		Teleport,
		// Token: 0x0400C070 RID: 49264
		[OriginalName("LightBlockByLocation")]
		LightBlockByLocation = 4
	}
}
