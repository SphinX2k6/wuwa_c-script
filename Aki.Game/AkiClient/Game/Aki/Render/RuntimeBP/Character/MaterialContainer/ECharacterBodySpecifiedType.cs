using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003137 RID: 12599
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/ECharacterBodySpecifiedType.ECharacterBodySpecifiedType")]
	public enum ECharacterBodySpecifiedType : byte
	{
		// Token: 0x04010807 RID: 67591
		All,
		// Token: 0x04010808 RID: 67592
		Body,
		// Token: 0x04010809 RID: 67593
		Weapon,
		// Token: 0x0401080A RID: 67594
		Hulu,
		// Token: 0x0401080B RID: 67595
		WeaponAndHulu,
		// Token: 0x0401080C RID: 67596
		Other,
		// Token: 0x0401080D RID: 67597
		ExtraBody,
		// Token: 0x0401080E RID: 67598
		External,
		// Token: 0x0401080F RID: 67599
		ECharacterBodySpecifiedType_MAX
	}
}
