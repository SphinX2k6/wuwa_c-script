using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003248 RID: 12872
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/EAiRaceStrategyMultiParamFuncType.EAiRaceStrategyMultiParamFuncType")]
	public enum EAiRaceStrategyMultiParamFuncType : byte
	{
		// Token: 0x040114FD RID: 70909
		Sum,
		// Token: 0x040114FE RID: 70910
		Max,
		// Token: 0x040114FF RID: 70911
		Min,
		// Token: 0x04011500 RID: 70912
		Avg,
		// Token: 0x04011501 RID: 70913
		EAiRaceStrategyMultiParamFuncType_MAX
	}
}
