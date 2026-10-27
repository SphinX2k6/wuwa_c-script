using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc
{
	// Token: 0x02003DFC RID: 15868
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Npc/ENpcSetupType.ENpcSetupType")]
	public enum ENpcSetupType : byte
	{
		// Token: 0x040140F1 RID: 82161
		NpcSetupType1,
		// Token: 0x040140F2 RID: 82162
		NpcSetupType2,
		// Token: 0x040140F3 RID: 82163
		ENpcSetupType_MAX
	}
}
