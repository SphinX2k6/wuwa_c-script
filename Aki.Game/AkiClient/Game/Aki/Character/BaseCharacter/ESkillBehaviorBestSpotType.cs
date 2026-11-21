using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003324 RID: 13092
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorBestSpotType.ESkillBehaviorBestSpotType")]
	public enum ESkillBehaviorBestSpotType : byte
	{
		// Token: 0x04012139 RID: 74041
		撞墙停止,
		// Token: 0x0401213A RID: 74042
		撞墙停止_技能施法者不穿墙,
		// Token: 0x0401213B RID: 74043
		四向查询,
		// Token: 0x0401213C RID: 74044
		四向查询_技能施法者不穿墙,
		// Token: 0x0401213D RID: 74045
		四向查询_前台角色不穿墙_QTE专用_,
		// Token: 0x0401213E RID: 74046
		编队位置,
		// Token: 0x0401213F RID: 74047
		ESkillBehaviorBestSpotType_MAX
	}
}
