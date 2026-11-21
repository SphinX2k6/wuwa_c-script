using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016A1 RID: 5793
	public enum RogueSelectOp
	{
		// Token: 0x0400C544 RID: 50500
		[OriginalName("NormalSelect")]
		NormalSelect,
		// Token: 0x0400C545 RID: 50501
		[OriginalName("Refresh")]
		Refresh = -1,
		// Token: 0x0400C546 RID: 50502
		[OriginalName("GiveUp")]
		GiveUp = -2
	}
}
