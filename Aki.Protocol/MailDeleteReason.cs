using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F5 RID: 5621
	public enum MailDeleteReason
	{
		// Token: 0x0400BEA8 RID: 48808
		[OriginalName("OverTime")]
		OverTime,
		// Token: 0x0400BEA9 RID: 48809
		[OriginalName("OverSize")]
		OverSize,
		// Token: 0x0400BEAA RID: 48810
		[OriginalName("OfflineEvent")]
		OfflineEvent,
		// Token: 0x0400BEAB RID: 48811
		[OriginalName("PublicCancelled")]
		PublicCancelled,
		// Token: 0x0400BEAC RID: 48812
		[OriginalName("PlayerDelete")]
		PlayerDelete
	}
}
