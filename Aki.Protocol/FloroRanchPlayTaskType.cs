using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015C9 RID: 5577
	public enum FloroRanchPlayTaskType
	{
		// Token: 0x0400BCE7 RID: 48359
		[OriginalName("DayStart")]
		DayStart,
		// Token: 0x0400BCE8 RID: 48360
		[OriginalName("DaySettleActions")]
		DaySettleActions,
		// Token: 0x0400BCE9 RID: 48361
		[OriginalName("Event")]
		Event,
		// Token: 0x0400BCEA RID: 48362
		[OriginalName("Shop")]
		Shop,
		// Token: 0x0400BCEB RID: 48363
		[OriginalName("Gacha")]
		Gacha,
		// Token: 0x0400BCEC RID: 48364
		[OriginalName("StageStart")]
		StageStart,
		// Token: 0x0400BCED RID: 48365
		[OriginalName("StageEnd")]
		StageEnd,
		// Token: 0x0400BCEE RID: 48366
		[OriginalName("WageSettleTask")]
		WageSettleTask
	}
}
