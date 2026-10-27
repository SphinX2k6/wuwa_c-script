using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E7 RID: 17127
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EWanderDirectionType.EWanderDirectionType")]
	public enum EWanderDirectionType : byte
	{
		// Token: 0x04017511 RID: 95505
		FBLR,
		// Token: 0x04017512 RID: 95506
		FB,
		// Token: 0x04017513 RID: 95507
		LR,
		// Token: 0x04017514 RID: 95508
		EWanderDirectionType_MAX
	}
}
