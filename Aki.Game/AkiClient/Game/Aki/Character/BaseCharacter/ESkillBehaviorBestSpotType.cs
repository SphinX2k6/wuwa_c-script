using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042CF RID: 17103
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorBestSpotType.ESkillBehaviorBestSpotType")]
	public enum ESkillBehaviorBestSpotType : byte
	{
		// Token: 0x0401745C RID: 95324
		撞墙停止,
		// Token: 0x0401745D RID: 95325
		撞墙停止_技能施法者不穿墙,
		// Token: 0x0401745E RID: 95326
		四向查询,
		// Token: 0x0401745F RID: 95327
		四向查询_技能施法者不穿墙,
		// Token: 0x04017460 RID: 95328
		四向查询_前台角色不穿墙_QTE专用_,
		// Token: 0x04017461 RID: 95329
		编队位置,
		// Token: 0x04017462 RID: 95330
		ESkillBehaviorBestSpotType_MAX
	}
}
