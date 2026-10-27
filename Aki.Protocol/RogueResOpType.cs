using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200163F RID: 5695
	public enum RogueResOpType
	{
		// Token: 0x0400C09E RID: 49310
		[OriginalName("Unkonw")]
		Unkonw,
		// Token: 0x0400C09F RID: 49311
		[OriginalName("Move")]
		Move,
		// Token: 0x0400C0A0 RID: 49312
		[OriginalName("GridEvent")]
		GridEvent,
		// Token: 0x0400C0A1 RID: 49313
		[OriginalName("SelectView")]
		SelectView,
		// Token: 0x0400C0A2 RID: 49314
		[OriginalName("ShowView")]
		ShowView,
		// Token: 0x0400C0A3 RID: 49315
		[OriginalName("RogueGotoLevelPlay")]
		RogueGotoLevelPlay,
		// Token: 0x0400C0A4 RID: 49316
		[OriginalName("RollBuffBondLinkId")]
		RollBuffBondLinkId,
		// Token: 0x0400C0A5 RID: 49317
		[OriginalName("FallbackView")]
		FallbackView = 9,
		// Token: 0x0400C0A6 RID: 49318
		[OriginalName("LightBlockByLocationEffect")]
		LightBlockByLocationEffect,
		// Token: 0x0400C0A7 RID: 49319
		[OriginalName("MapTeleportByLocationEffect")]
		MapTeleportByLocationEffect,
		// Token: 0x0400C0A8 RID: 49320
		[OriginalName("ChangeEventByPos")]
		ChangeEventByPos
	}
}
