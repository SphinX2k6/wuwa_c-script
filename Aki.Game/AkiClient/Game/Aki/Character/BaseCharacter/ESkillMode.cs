using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042DC RID: 17116
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillMode.ESkillMode")]
	public enum ESkillMode : byte
	{
		// Token: 0x040174CC RID: 95436
		Simple,
		// Token: 0x040174CD RID: 95437
		GameplayAbility,
		// Token: 0x040174CE RID: 95438
		Code,
		// Token: 0x040174CF RID: 95439
		ESkillMode_MAX
	}
}
