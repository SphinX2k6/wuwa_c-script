using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001539 RID: 5433
	public enum AceBattleAntiCheatingLogType
	{
		// Token: 0x0400A4B5 RID: 42165
		[OriginalName("LogType_SecGetReportData2Flow")]
		LogTypeSecGetReportData2Flow,
		// Token: 0x0400A4B6 RID: 42166
		[OriginalName("LogType_SecFBRoundStartFlow")]
		LogTypeSecFbroundStartFlow,
		// Token: 0x0400A4B7 RID: 42167
		[OriginalName("LogType_SecFBRoundEndFlow")]
		LogTypeSecFbroundEndFlow,
		// Token: 0x0400A4B8 RID: 42168
		[OriginalName("LogType_SecRoleFightFlow_BigWorldStart")]
		LogTypeSecRoleFightFlowBigWorldStart,
		// Token: 0x0400A4B9 RID: 42169
		[OriginalName("LogType_SecRoleFightFlow_BigWorldEnd")]
		LogTypeSecRoleFightFlowBigWorldEnd,
		// Token: 0x0400A4BA RID: 42170
		[OriginalName("LogType_SecRoleFightFlow_InstStart")]
		LogTypeSecRoleFightFlowInstStart,
		// Token: 0x0400A4BB RID: 42171
		[OriginalName("LogType_SecRoleFightFlow_InstEnd")]
		LogTypeSecRoleFightFlowInstEnd,
		// Token: 0x0400A4BC RID: 42172
		[OriginalName("LogType_SecWorldInfoFlow_Start")]
		LogTypeSecWorldInfoFlowStart,
		// Token: 0x0400A4BD RID: 42173
		[OriginalName("LogType_SecWorldInfoFlow_End")]
		LogTypeSecWorldInfoFlowEnd,
		// Token: 0x0400A4BE RID: 42174
		[OriginalName("LogType_SecWorldStartFlow")]
		LogTypeSecWorldStartFlow,
		// Token: 0x0400A4BF RID: 42175
		[OriginalName("LogType_SecWorldSEndFlow")]
		LogTypeSecWorldSendFlow
	}
}
