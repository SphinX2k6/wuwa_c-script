using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003E22 RID: 15906
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/ECharacterSlotSpecifiedType.ECharacterSlotSpecifiedType")]
	public enum ECharacterSlotSpecifiedType : byte
	{
		// Token: 0x04014372 RID: 82802
		All,
		// Token: 0x04014373 RID: 82803
		BodyAndOutline,
		// Token: 0x04014374 RID: 82804
		Body,
		// Token: 0x04014375 RID: 82805
		Outline,
		// Token: 0x04014376 RID: 82806
		ECharacterSlotSpecifiedType_MAX
	}
}
