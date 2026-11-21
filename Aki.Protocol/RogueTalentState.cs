using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016A5 RID: 5797
	public enum RogueTalentState
	{
		// Token: 0x0400C55B RID: 50523
		[OriginalName("Unlock")]
		Unlock,
		// Token: 0x0400C55C RID: 50524
		[OriginalName("Lock")]
		Lock = -1,
		// Token: 0x0400C55D RID: 50525
		[OriginalName("Active")]
		Active = 1
	}
}
