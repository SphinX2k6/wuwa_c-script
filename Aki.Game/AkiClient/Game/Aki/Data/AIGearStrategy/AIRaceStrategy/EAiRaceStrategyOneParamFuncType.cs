using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003249 RID: 12873
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/EAiRaceStrategyOneParamFuncType.EAiRaceStrategyOneParamFuncType")]
	public enum EAiRaceStrategyOneParamFuncType : byte
	{
		// Token: 0x04011503 RID: 70915
		Constant,
		// Token: 0x04011504 RID: 70916
		Linear,
		// Token: 0x04011505 RID: 70917
		Quadratic,
		// Token: 0x04011506 RID: 70918
		Comparison,
		// Token: 0x04011507 RID: 70919
		EAiRaceStrategyOneParamFuncType_MAX
	}
}
