using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042DF RID: 17119
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillTargetMode.ESkillTargetMode")]
	public enum ESkillTargetMode : byte
	{
		// Token: 0x040174DF RID: 95455
		NotChange,
		// Token: 0x040174E0 RID: 95456
		HateOrLockOn,
		// Token: 0x040174E1 RID: 95457
		ChangeWhenTargetDie,
		// Token: 0x040174E2 RID: 95458
		ESkillTargetMode_MAX
	}
}
