using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Interaction.Enum
{
	// Token: 0x02003F22 RID: 16162
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Enum/EInteractOptionType.EInteractOptionType")]
	public enum EInteractOptionType : byte
	{
		// Token: 0x04015011 RID: 86033
		任务,
		// Token: 0x04015012 RID: 86034
		剧情,
		// Token: 0x04015013 RID: 86035
		事件,
		// Token: 0x04015014 RID: 86036
		EInteractOptionType_MAX
	}
}
