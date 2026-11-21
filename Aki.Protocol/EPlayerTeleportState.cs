using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016F0 RID: 5872
	public enum EPlayerTeleportState
	{
		// Token: 0x0400C6F1 RID: 50929
		[OriginalName("Default")]
		Default,
		// Token: 0x0400C6F2 RID: 50930
		[OriginalName("Teleporting")]
		Teleporting,
		// Token: 0x0400C6F3 RID: 50931
		[OriginalName("TeleportTimeOut")]
		TeleportTimeOut
	}
}
