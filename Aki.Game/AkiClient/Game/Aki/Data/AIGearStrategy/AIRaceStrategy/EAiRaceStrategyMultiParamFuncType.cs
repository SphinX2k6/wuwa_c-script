using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy
{
	// Token: 0x02003FC3 RID: 16323
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/AIGearStrategy/AIRaceStrategy/EAiRaceStrategyMultiParamFuncType.EAiRaceStrategyMultiParamFuncType")]
	public enum EAiRaceStrategyMultiParamFuncType : byte
	{
		// Token: 0x0401576C RID: 87916
		Sum,
		// Token: 0x0401576D RID: 87917
		Max,
		// Token: 0x0401576E RID: 87918
		Min,
		// Token: 0x0401576F RID: 87919
		Avg,
		// Token: 0x04015770 RID: 87920
		EAiRaceStrategyMultiParamFuncType_MAX
	}
}
