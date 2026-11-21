using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200166F RID: 5743
	public enum MatchPlayerLeaveReason
	{
		// Token: 0x0400C430 RID: 50224
		[OriginalName("NotConfirm")]
		NotConfirm,
		// Token: 0x0400C431 RID: 50225
		[OriginalName("Refuse")]
		Refuse,
		// Token: 0x0400C432 RID: 50226
		[OriginalName("Initiative")]
		Initiative,
		// Token: 0x0400C433 RID: 50227
		[OriginalName("BeKick")]
		BeKick,
		// Token: 0x0400C434 RID: 50228
		[OriginalName("HostLeave")]
		HostLeave,
		// Token: 0x0400C435 RID: 50229
		[OriginalName("EnterInstance")]
		EnterInstance,
		// Token: 0x0400C436 RID: 50230
		[OriginalName("MatchServerDisable")]
		MatchServerDisable,
		// Token: 0x0400C437 RID: 50231
		[OriginalName("MatchGM")]
		MatchGm,
		// Token: 0x0400C438 RID: 50232
		[OriginalName("EnterBigWorldInst")]
		EnterBigWorldInst,
		// Token: 0x0400C439 RID: 50233
		[OriginalName("EnableFunction")]
		EnableFunction,
		// Token: 0x0400C43A RID: 50234
		[OriginalName("DisabledOnlineNodeEvent")]
		DisabledOnlineNodeEvent,
		// Token: 0x0400C43B RID: 50235
		[OriginalName("DoCloseOnlineMatching")]
		DoCloseOnlineMatching,
		// Token: 0x0400C43C RID: 50236
		[OriginalName("PlayFlow")]
		PlayFlow,
		// Token: 0x0400C43D RID: 50237
		[OriginalName("MatchClientVersion")]
		MatchClientVersion
	}
}
