using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001679 RID: 5753
	public enum PayUpdateType
	{
		// Token: 0x0400C470 RID: 50288
		[OriginalName("None")]
		None,
		// Token: 0x0400C471 RID: 50289
		[OriginalName("Daily")]
		Daily,
		// Token: 0x0400C472 RID: 50290
		[OriginalName("Weekly")]
		Weekly,
		// Token: 0x0400C473 RID: 50291
		[OriginalName("Monthly")]
		Monthly,
		// Token: 0x0400C474 RID: 50292
		[OriginalName("Forever")]
		Forever
	}
}
