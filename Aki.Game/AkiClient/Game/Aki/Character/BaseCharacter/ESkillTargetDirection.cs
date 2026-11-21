using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003330 RID: 13104
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillTargetDirection.ESkillTargetDirection")]
	public enum ESkillTargetDirection : byte
	{
		// Token: 0x0401219A RID: 74138
		技能目标方向,
		// Token: 0x0401219B RID: 74139
		摇杆方向,
		// Token: 0x0401219C RID: 74140
		角色方向,
		// Token: 0x0401219D RID: 74141
		相机方向,
		// Token: 0x0401219E RID: 74142
		技能目标方向_载具专用_,
		// Token: 0x0401219F RID: 74143
		ESkillTargetDirection_MAX
	}
}
