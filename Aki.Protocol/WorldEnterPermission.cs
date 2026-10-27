using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200166D RID: 5741
	public enum WorldEnterPermission
	{
		// Token: 0x0400C1A2 RID: 49570
		[OriginalName("ConfirmJoin")]
		ConfirmJoin,
		// Token: 0x0400C1A3 RID: 49571
		[OriginalName("DirectJoin")]
		DirectJoin,
		// Token: 0x0400C1A4 RID: 49572
		[OriginalName("ForbidJoin")]
		ForbidJoin,
		// Token: 0x0400C1A5 RID: 49573
		[OriginalName("OnlyFriendJoin")]
		OnlyFriendJoin
	}
}
