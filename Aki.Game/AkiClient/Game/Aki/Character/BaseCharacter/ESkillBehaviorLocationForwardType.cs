using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003328 RID: 13096
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorLocationForwardType.ESkillBehaviorLocationForwardType")]
	public enum ESkillBehaviorLocationForwardType : byte
	{
		// Token: 0x04012158 RID: 74072
		位置基准目标正方向,
		// Token: 0x04012159 RID: 74073
		技能施法者正方向,
		// Token: 0x0401215A RID: 74074
		水平面上基准目标朝向技能施法者的方向,
		// Token: 0x0401215B RID: 74075
		镜头方向,
		// Token: 0x0401215C RID: 74076
		水平面上基准目标朝向前台角色的方向,
		// Token: 0x0401215D RID: 74077
		ESkillBehaviorLocationForwardType_MAX
	}
}
