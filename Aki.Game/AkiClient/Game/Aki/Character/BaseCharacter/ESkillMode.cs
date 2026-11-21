using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200332E RID: 13102
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillMode.ESkillMode")]
	public enum ESkillMode : byte
	{
		// Token: 0x0401218E RID: 74126
		Simple,
		// Token: 0x0401218F RID: 74127
		GameplayAbility,
		// Token: 0x04012190 RID: 74128
		Code,
		// Token: 0x04012191 RID: 74129
		ESkillMode_MAX
	}
}
