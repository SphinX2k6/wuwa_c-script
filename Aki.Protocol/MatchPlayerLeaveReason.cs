using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015FC RID: 5628
	public enum MatchPlayerLeaveReason
	{
		// Token: 0x0400BF36 RID: 48950
		[OriginalName("NotConfirm")]
		NotConfirm,
		// Token: 0x0400BF37 RID: 48951
		[OriginalName("Refuse")]
		Refuse,
		// Token: 0x0400BF38 RID: 48952
		[OriginalName("Initiative")]
		Initiative,
		// Token: 0x0400BF39 RID: 48953
		[OriginalName("BeKick")]
		BeKick,
		// Token: 0x0400BF3A RID: 48954
		[OriginalName("HostLeave")]
		HostLeave,
		// Token: 0x0400BF3B RID: 48955
		[OriginalName("EnterInstance")]
		EnterInstance,
		// Token: 0x0400BF3C RID: 48956
		[OriginalName("MatchServerDisable")]
		MatchServerDisable,
		// Token: 0x0400BF3D RID: 48957
		[OriginalName("MatchGM")]
		MatchGm,
		// Token: 0x0400BF3E RID: 48958
		[OriginalName("EnterBigWorldInst")]
		EnterBigWorldInst,
		// Token: 0x0400BF3F RID: 48959
		[OriginalName("EnableFunction")]
		EnableFunction,
		// Token: 0x0400BF40 RID: 48960
		[OriginalName("DisabledOnlineNodeEvent")]
		DisabledOnlineNodeEvent,
		// Token: 0x0400BF41 RID: 48961
		[OriginalName("DoCloseOnlineMatching")]
		DoCloseOnlineMatching,
		// Token: 0x0400BF42 RID: 48962
		[OriginalName("PlayFlow")]
		PlayFlow,
		// Token: 0x0400BF43 RID: 48963
		[OriginalName("MatchClientVersion")]
		MatchClientVersion
	}
}
