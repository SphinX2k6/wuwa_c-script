using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200163B RID: 5691
	public enum FloroRanchPlayTaskType
	{
		// Token: 0x0400C1DA RID: 49626
		[OriginalName("DayStart")]
		DayStart,
		// Token: 0x0400C1DB RID: 49627
		[OriginalName("DaySettleActions")]
		DaySettleActions,
		// Token: 0x0400C1DC RID: 49628
		[OriginalName("Event")]
		Event,
		// Token: 0x0400C1DD RID: 49629
		[OriginalName("Shop")]
		Shop,
		// Token: 0x0400C1DE RID: 49630
		[OriginalName("Gacha")]
		Gacha,
		// Token: 0x0400C1DF RID: 49631
		[OriginalName("StageStart")]
		StageStart,
		// Token: 0x0400C1E0 RID: 49632
		[OriginalName("StageEnd")]
		StageEnd,
		// Token: 0x0400C1E1 RID: 49633
		[OriginalName("WageSettleTask")]
		WageSettleTask
	}
}
