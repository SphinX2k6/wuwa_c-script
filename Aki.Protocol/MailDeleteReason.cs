using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001668 RID: 5736
	public enum MailDeleteReason
	{
		// Token: 0x0400C39F RID: 50079
		[OriginalName("OverTime")]
		OverTime,
		// Token: 0x0400C3A0 RID: 50080
		[OriginalName("OverSize")]
		OverSize,
		// Token: 0x0400C3A1 RID: 50081
		[OriginalName("OfflineEvent")]
		OfflineEvent,
		// Token: 0x0400C3A2 RID: 50082
		[OriginalName("PublicCancelled")]
		PublicCancelled,
		// Token: 0x0400C3A3 RID: 50083
		[OriginalName("PlayerDelete")]
		PlayerDelete
	}
}
