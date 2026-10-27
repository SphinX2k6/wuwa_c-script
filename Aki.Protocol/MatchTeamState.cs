using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015FB RID: 5627
	public enum MatchTeamState
	{
		// Token: 0x0400BF31 RID: 48945
		[OriginalName("WaiteConfirm")]
		WaiteConfirm,
		// Token: 0x0400BF32 RID: 48946
		[OriginalName("ReadyConfirm")]
		ReadyConfirm,
		// Token: 0x0400BF33 RID: 48947
		[OriginalName("EnterInst")]
		EnterInst,
		// Token: 0x0400BF34 RID: 48948
		[OriginalName("EnterInstStart")]
		EnterInstStart
	}
}
