using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003E23 RID: 15907
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/ECharacterSlotType.ECharacterSlotType")]
	public enum ECharacterSlotType : byte
	{
		// Token: 0x04014378 RID: 82808
		Error,
		// Token: 0x04014379 RID: 82809
		Body,
		// Token: 0x0401437A RID: 82810
		Outline,
		// Token: 0x0401437B RID: 82811
		EyeMask,
		// Token: 0x0401437C RID: 82812
		HairEyeTransparent,
		// Token: 0x0401437D RID: 82813
		FaceShadow,
		// Token: 0x0401437E RID: 82814
		ECharacterSlotType_MAX
	}
}
