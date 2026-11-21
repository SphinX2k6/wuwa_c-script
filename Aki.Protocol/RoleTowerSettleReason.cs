using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020016AD RID: 5805
	public enum RoleTowerSettleReason
	{
		// Token: 0x0400C57C RID: 50556
		[OriginalName("RoleTowerSettleReasonNone")]
		None,
		// Token: 0x0400C57D RID: 50557
		[OriginalName("RoleTowerSettleReasonAllPass")]
		AllPass,
		// Token: 0x0400C57E RID: 50558
		[OriginalName("RoleTowerSettleReasonTimeOut")]
		TimeOut,
		// Token: 0x0400C57F RID: 50559
		[OriginalName("RoleTowerSettleReasonTeamDead")]
		TeamDead,
		// Token: 0x0400C580 RID: 50560
		[OriginalName("RoleTowerSettleReasonManual")]
		Manual
	}
}
