using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D7 RID: 17111
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillDir.ESkillDir")]
	public enum ESkillDir : byte
	{
		// Token: 0x0401749B RID: 95387
		角色面朝方向,
		// Token: 0x0401749C RID: 95388
		废弃1,
		// Token: 0x0401749D RID: 95389
		就近锁定目标瞄准点,
		// Token: 0x0401749E RID: 95390
		摇杆方向,
		// Token: 0x0401749F RID: 95391
		相机方向,
		// Token: 0x040174A0 RID: 95392
		ESkillDir_MAX
	}
}
