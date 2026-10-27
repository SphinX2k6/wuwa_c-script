using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001671 RID: 5745
	public enum WorldTeamLeaveReason
	{
		// Token: 0x0400C1B0 RID: 49584
		[OriginalName("Initiative")]
		Initiative,
		// Token: 0x0400C1B1 RID: 49585
		[OriginalName("BeKick")]
		BeKick,
		// Token: 0x0400C1B2 RID: 49586
		[OriginalName("Dissolve")]
		Dissolve,
		// Token: 0x0400C1B3 RID: 49587
		[OriginalName("Logout")]
		Logout,
		// Token: 0x0400C1B4 RID: 49588
		[OriginalName("ToOwnBigWorld")]
		ToOwnBigWorld,
		// Token: 0x0400C1B5 RID: 49589
		[OriginalName("PSNAccountLogin")]
		PsnaccountLogin,
		// Token: 0x0400C1B6 RID: 49590
		[OriginalName("CheckClientVersionFailed")]
		CheckClientVersionFailed,
		// Token: 0x0400C1B7 RID: 49591
		[OriginalName("SceneBlockSplitFail")]
		SceneBlockSplitFail,
		// Token: 0x0400C1B8 RID: 49592
		[OriginalName("XboxaccountLogin")]
		XboxaccountLogin,
		// Token: 0x0400C1B9 RID: 49593
		[OriginalName("InstPlayEnd")]
		InstPlayEnd
	}
}
