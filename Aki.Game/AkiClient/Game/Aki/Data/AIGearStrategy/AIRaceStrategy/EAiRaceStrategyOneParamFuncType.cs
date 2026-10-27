using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003FC4 RID: 16324
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/EAiRaceStrategyOneParamFuncType.EAiRaceStrategyOneParamFuncType")]
	public enum EAiRaceStrategyOneParamFuncType : byte
	{
		// Token: 0x04015772 RID: 87922
		Constant,
		// Token: 0x04015773 RID: 87923
		Linear,
		// Token: 0x04015774 RID: 87924
		Quadratic,
		// Token: 0x04015775 RID: 87925
		Comparison,
		// Token: 0x04015776 RID: 87926
		EAiRaceStrategyOneParamFuncType_MAX
	}
}
