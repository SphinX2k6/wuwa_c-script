using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016B6 RID: 5814
	public enum RogueResOpType
	{
		// Token: 0x0400C5A9 RID: 50601
		[OriginalName("Unkonw")]
		Unkonw,
		// Token: 0x0400C5AA RID: 50602
		[OriginalName("Move")]
		Move,
		// Token: 0x0400C5AB RID: 50603
		[OriginalName("GridEvent")]
		GridEvent,
		// Token: 0x0400C5AC RID: 50604
		[OriginalName("SelectView")]
		SelectView,
		// Token: 0x0400C5AD RID: 50605
		[OriginalName("ShowView")]
		ShowView,
		// Token: 0x0400C5AE RID: 50606
		[OriginalName("RogueGotoLevelPlay")]
		RogueGotoLevelPlay,
		// Token: 0x0400C5AF RID: 50607
		[OriginalName("RollBuffBondLinkId")]
		RollBuffBondLinkId,
		// Token: 0x0400C5B0 RID: 50608
		[OriginalName("FallbackView")]
		FallbackView = 9,
		// Token: 0x0400C5B1 RID: 50609
		[OriginalName("LightBlockByLocationEffect")]
		LightBlockByLocationEffect,
		// Token: 0x0400C5B2 RID: 50610
		[OriginalName("MapTeleportByLocationEffect")]
		MapTeleportByLocationEffect,
		// Token: 0x0400C5B3 RID: 50611
		[OriginalName("ChangeEventByPos")]
		ChangeEventByPos
	}
}
