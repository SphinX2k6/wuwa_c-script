using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Interaction.Enum
{
	// Token: 0x02003F20 RID: 16160
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Enum/EInteractionType.EInteractionType")]
	public enum EInteractionType : byte
	{
		// Token: 0x04015008 RID: 86024
		剧情交互,
		// Token: 0x04015009 RID: 86025
		直接交互,
		// Token: 0x0401500A RID: 86026
		EInteractionType_MAX
	}
}
