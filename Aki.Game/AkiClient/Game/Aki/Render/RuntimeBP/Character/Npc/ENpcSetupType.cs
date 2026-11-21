using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x0200311D RID: 12573
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/ENpcSetupType.ENpcSetupType")]
	public enum ENpcSetupType : byte
	{
		// Token: 0x04010617 RID: 67095
		NpcSetupType1,
		// Token: 0x04010618 RID: 67096
		NpcSetupType2,
		// Token: 0x04010619 RID: 67097
		ENpcSetupType_MAX
	}
}
