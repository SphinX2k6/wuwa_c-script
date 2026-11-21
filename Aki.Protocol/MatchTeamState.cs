using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200166E RID: 5742
	public enum MatchTeamState
	{
		// Token: 0x0400C42B RID: 50219
		[OriginalName("WaiteConfirm")]
		WaiteConfirm,
		// Token: 0x0400C42C RID: 50220
		[OriginalName("ReadyConfirm")]
		ReadyConfirm,
		// Token: 0x0400C42D RID: 50221
		[OriginalName("EnterInst")]
		EnterInst,
		// Token: 0x0400C42E RID: 50222
		[OriginalName("EnterInstStart")]
		EnterInstStart
	}
}
