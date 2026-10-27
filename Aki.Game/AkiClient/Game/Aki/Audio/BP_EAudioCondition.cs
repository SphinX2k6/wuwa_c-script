using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x0200442F RID: 17455
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_EAudioCondition.BP_EAudioCondition")]
	public enum BP_EAudioCondition : byte
	{
		// Token: 0x04018017 RID: 98327
		FightState,
		// Token: 0x04018018 RID: 98328
		Time,
		// Token: 0x04018019 RID: 98329
		Weather,
		// Token: 0x0401801A RID: 98330
		BP_MAX
	}
}
