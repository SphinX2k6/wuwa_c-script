using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016A8 RID: 5800
	public enum GridDataUpdateReason
	{
		// Token: 0x0400C567 RID: 50535
		[OriginalName("GridUpdate")]
		GridUpdate,
		// Token: 0x0400C568 RID: 50536
		[OriginalName("ByMoveOp")]
		ByMoveOp,
		// Token: 0x0400C569 RID: 50537
		[OriginalName("Teleport")]
		Teleport,
		// Token: 0x0400C56A RID: 50538
		[OriginalName("LightBlockByLocation")]
		LightBlockByLocation = 4
	}
}
