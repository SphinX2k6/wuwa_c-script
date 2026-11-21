using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016ED RID: 5869
	public enum WorldTeamLeaveReason
	{
		// Token: 0x0400C6D9 RID: 50905
		[OriginalName("Initiative")]
		Initiative,
		// Token: 0x0400C6DA RID: 50906
		[OriginalName("BeKick")]
		BeKick,
		// Token: 0x0400C6DB RID: 50907
		[OriginalName("Dissolve")]
		Dissolve,
		// Token: 0x0400C6DC RID: 50908
		[OriginalName("Logout")]
		Logout,
		// Token: 0x0400C6DD RID: 50909
		[OriginalName("ToOwnBigWorld")]
		ToOwnBigWorld,
		// Token: 0x0400C6DE RID: 50910
		[OriginalName("PSNAccountLogin")]
		PsnaccountLogin,
		// Token: 0x0400C6DF RID: 50911
		[OriginalName("CheckClientVersionFailed")]
		CheckClientVersionFailed,
		// Token: 0x0400C6E0 RID: 50912
		[OriginalName("SceneBlockSplitFail")]
		SceneBlockSplitFail,
		// Token: 0x0400C6E1 RID: 50913
		[OriginalName("XboxaccountLogin")]
		XboxaccountLogin,
		// Token: 0x0400C6E2 RID: 50914
		[OriginalName("InstPlayEnd")]
		InstPlayEnd
	}
}
