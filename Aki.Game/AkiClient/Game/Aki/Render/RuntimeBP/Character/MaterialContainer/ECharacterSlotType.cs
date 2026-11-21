using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x0200313A RID: 12602
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/ECharacterSlotType.ECharacterSlotType")]
	public enum ECharacterSlotType : byte
	{
		// Token: 0x0401081D RID: 67613
		Error,
		// Token: 0x0401081E RID: 67614
		Body,
		// Token: 0x0401081F RID: 67615
		Outline,
		// Token: 0x04010820 RID: 67616
		EyeMask,
		// Token: 0x04010821 RID: 67617
		HairEyeTransparent,
		// Token: 0x04010822 RID: 67618
		FaceShadow,
		// Token: 0x04010823 RID: 67619
		ECharacterSlotType_MAX
	}
}
