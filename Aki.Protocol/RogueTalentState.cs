using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001632 RID: 5682
	public enum RogueTalentState
	{
		// Token: 0x0400C061 RID: 49249
		[OriginalName("Unlock")]
		Unlock,
		// Token: 0x0400C062 RID: 49250
		[OriginalName("Lock")]
		Lock = -1,
		// Token: 0x0400C063 RID: 49251
		[OriginalName("Active")]
		Active = 1
	}
}
