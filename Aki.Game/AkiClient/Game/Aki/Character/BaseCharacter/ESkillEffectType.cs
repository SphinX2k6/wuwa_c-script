using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200332C RID: 13100
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillEffectType.ESkillEffectType")]
	public enum ESkillEffectType : byte
	{
		// Token: 0x04012178 RID: 74104
		None,
		// Token: 0x04012179 RID: 74105
		EndEffect,
		// Token: 0x0401217A RID: 74106
		DestroyEffect,
		// Token: 0x0401217B RID: 74107
		ESkillEffectType_MAX
	}
}
