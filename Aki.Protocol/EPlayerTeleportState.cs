using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001674 RID: 5748
	public enum EPlayerTeleportState
	{
		// Token: 0x0400C1C8 RID: 49608
		[OriginalName("Default")]
		Default,
		// Token: 0x0400C1C9 RID: 49609
		[OriginalName("Teleporting")]
		Teleporting,
		// Token: 0x0400C1CA RID: 49610
		[OriginalName("TeleportTimeOut")]
		TeleportTimeOut
	}
}
