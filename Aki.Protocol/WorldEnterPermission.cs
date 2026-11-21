using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016E9 RID: 5865
	public enum WorldEnterPermission
	{
		// Token: 0x0400C6CB RID: 50891
		[OriginalName("ConfirmJoin")]
		ConfirmJoin,
		// Token: 0x0400C6CC RID: 50892
		[OriginalName("DirectJoin")]
		DirectJoin,
		// Token: 0x0400C6CD RID: 50893
		[OriginalName("ForbidJoin")]
		ForbidJoin,
		// Token: 0x0400C6CE RID: 50894
		[OriginalName("OnlyFriendJoin")]
		OnlyFriendJoin
	}
}
