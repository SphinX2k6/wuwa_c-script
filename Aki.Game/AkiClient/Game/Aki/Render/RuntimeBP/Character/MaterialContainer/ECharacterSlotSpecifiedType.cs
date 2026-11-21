using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003139 RID: 12601
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/ECharacterSlotSpecifiedType.ECharacterSlotSpecifiedType")]
	public enum ECharacterSlotSpecifiedType : byte
	{
		// Token: 0x04010817 RID: 67607
		All,
		// Token: 0x04010818 RID: 67608
		BodyAndOutline,
		// Token: 0x04010819 RID: 67609
		Body,
		// Token: 0x0401081A RID: 67610
		Outline,
		// Token: 0x0401081B RID: 67611
		ECharacterSlotSpecifiedType_MAX
	}
}
