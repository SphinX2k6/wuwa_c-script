using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003334 RID: 13108
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EWanderDirectionType.EWanderDirectionType")]
	public enum EWanderDirectionType : byte
	{
		// Token: 0x040121B7 RID: 74167
		FBLR,
		// Token: 0x040121B8 RID: 74168
		FB,
		// Token: 0x040121B9 RID: 74169
		LR,
		// Token: 0x040121BA RID: 74170
		EWanderDirectionType_MAX
	}
}
