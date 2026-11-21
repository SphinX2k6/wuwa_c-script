using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003138 RID: 12600
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/ECharacterBodyType.ECharacterBodyType")]
	public enum ECharacterBodyType : byte
	{
		// Token: 0x04010811 RID: 67601
		Body,
		// Token: 0x04010812 RID: 67602
		Weapon,
		// Token: 0x04010813 RID: 67603
		Hulu,
		// Token: 0x04010814 RID: 67604
		Other,
		// Token: 0x04010815 RID: 67605
		ECharacterBodyType_MAX
	}
}
