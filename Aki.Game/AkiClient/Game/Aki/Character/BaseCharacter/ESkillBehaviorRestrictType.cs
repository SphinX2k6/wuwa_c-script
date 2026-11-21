using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200332A RID: 13098
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorRestrictType.ESkillBehaviorRestrictType")]
	public enum ESkillBehaviorRestrictType : byte
	{
		// Token: 0x0401216A RID: 74090
		小队前台角色当前位置,
		// Token: 0x0401216B RID: 74091
		技能施法者当前位置,
		// Token: 0x0401216C RID: 74092
		技能施法者出生位置_怪物专用_,
		// Token: 0x0401216D RID: 74093
		ESkillBehaviorRestrictType_MAX
	}
}
