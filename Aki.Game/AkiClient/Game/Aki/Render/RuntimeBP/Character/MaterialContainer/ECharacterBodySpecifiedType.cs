using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003E20 RID: 15904
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/ECharacterBodySpecifiedType.ECharacterBodySpecifiedType")]
	public enum ECharacterBodySpecifiedType : byte
	{
		// Token: 0x04014362 RID: 82786
		All,
		// Token: 0x04014363 RID: 82787
		Body,
		// Token: 0x04014364 RID: 82788
		Weapon,
		// Token: 0x04014365 RID: 82789
		Hulu,
		// Token: 0x04014366 RID: 82790
		WeaponAndHulu,
		// Token: 0x04014367 RID: 82791
		Other,
		// Token: 0x04014368 RID: 82792
		ExtraBody,
		// Token: 0x04014369 RID: 82793
		External,
		// Token: 0x0401436A RID: 82794
		ECharacterBodySpecifiedType_MAX
	}
}
