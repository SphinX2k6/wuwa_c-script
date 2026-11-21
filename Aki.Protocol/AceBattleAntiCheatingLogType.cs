using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015AF RID: 5551
	public enum AceBattleAntiCheatingLogType
	{
		// Token: 0x0400A911 RID: 43281
		[OriginalName("LogType_SecGetReportData2Flow")]
		LogTypeSecGetReportData2Flow,
		// Token: 0x0400A912 RID: 43282
		[OriginalName("LogType_SecFBRoundStartFlow")]
		LogTypeSecFbroundStartFlow,
		// Token: 0x0400A913 RID: 43283
		[OriginalName("LogType_SecFBRoundEndFlow")]
		LogTypeSecFbroundEndFlow,
		// Token: 0x0400A914 RID: 43284
		[OriginalName("LogType_SecRoleFightFlow_BigWorldStart")]
		LogTypeSecRoleFightFlowBigWorldStart,
		// Token: 0x0400A915 RID: 43285
		[OriginalName("LogType_SecRoleFightFlow_BigWorldEnd")]
		LogTypeSecRoleFightFlowBigWorldEnd,
		// Token: 0x0400A916 RID: 43286
		[OriginalName("LogType_SecRoleFightFlow_InstStart")]
		LogTypeSecRoleFightFlowInstStart,
		// Token: 0x0400A917 RID: 43287
		[OriginalName("LogType_SecRoleFightFlow_InstEnd")]
		LogTypeSecRoleFightFlowInstEnd,
		// Token: 0x0400A918 RID: 43288
		[OriginalName("LogType_SecWorldInfoFlow_Start")]
		LogTypeSecWorldInfoFlowStart,
		// Token: 0x0400A919 RID: 43289
		[OriginalName("LogType_SecWorldInfoFlow_End")]
		LogTypeSecWorldInfoFlowEnd,
		// Token: 0x0400A91A RID: 43290
		[OriginalName("LogType_SecWorldStartFlow")]
		LogTypeSecWorldStartFlow,
		// Token: 0x0400A91B RID: 43291
		[OriginalName("LogType_SecWorldSEndFlow")]
		LogTypeSecWorldSendFlow
	}
}
