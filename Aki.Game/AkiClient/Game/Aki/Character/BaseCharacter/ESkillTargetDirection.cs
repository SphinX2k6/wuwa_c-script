using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042DE RID: 17118
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillTargetDirection.ESkillTargetDirection")]
	public enum ESkillTargetDirection : byte
	{
		// Token: 0x040174D8 RID: 95448
		技能目标方向,
		// Token: 0x040174D9 RID: 95449
		摇杆方向,
		// Token: 0x040174DA RID: 95450
		角色方向,
		// Token: 0x040174DB RID: 95451
		相机方向,
		// Token: 0x040174DC RID: 95452
		技能目标方向_载具专用_,
		// Token: 0x040174DD RID: 95453
		ESkillTargetDirection_MAX
	}
}
