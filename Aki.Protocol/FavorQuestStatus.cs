using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015AE RID: 5550
	public enum FavorQuestStatus
	{
		// Token: 0x0400BC5C RID: 48220
		[OriginalName("Locked")]
		Locked,
		// Token: 0x0400BC5D RID: 48221
		[OriginalName("CanAccept")]
		CanAccept,
		// Token: 0x0400BC5E RID: 48222
		[OriginalName("Accepted")]
		Accepted,
		// Token: 0x0400BC5F RID: 48223
		[OriginalName("Completed")]
		Completed
	}
}
