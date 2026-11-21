using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001620 RID: 5664
	public enum FavorQuestStatus
	{
		// Token: 0x0400C14F RID: 49487
		[OriginalName("Locked")]
		Locked,
		// Token: 0x0400C150 RID: 49488
		[OriginalName("CanAccept")]
		CanAccept,
		// Token: 0x0400C151 RID: 49489
		[OriginalName("Accepted")]
		Accepted,
		// Token: 0x0400C152 RID: 49490
		[OriginalName("Completed")]
		Completed
	}
}
