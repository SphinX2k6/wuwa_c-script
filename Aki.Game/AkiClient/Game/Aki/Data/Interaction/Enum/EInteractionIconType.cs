using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Interaction.Enum
{
	// Token: 0x02003F1F RID: 16159
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Enum/EinteractionIconType.EInteractionIconType")]
	public enum EInteractionIconType : byte
	{
		// Token: 0x04015003 RID: 86019
		Dialogue,
		// Token: 0x04015004 RID: 86020
		Shop,
		// Token: 0x04015005 RID: 86021
		Other,
		// Token: 0x04015006 RID: 86022
		EInteractionIconType_MAX
	}
}
