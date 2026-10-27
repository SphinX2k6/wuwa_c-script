using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D3 RID: 17107
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorLocationForwardType.ESkillBehaviorLocationForwardType")]
	public enum ESkillBehaviorLocationForwardType : byte
	{
		// Token: 0x0401747B RID: 95355
		位置基准目标正方向,
		// Token: 0x0401747C RID: 95356
		技能施法者正方向,
		// Token: 0x0401747D RID: 95357
		水平面上基准目标朝向技能施法者的方向,
		// Token: 0x0401747E RID: 95358
		镜头方向,
		// Token: 0x0401747F RID: 95359
		水平面上基准目标朝向前台角色的方向,
		// Token: 0x04017480 RID: 95360
		ESkillBehaviorLocationForwardType_MAX
	}
}
