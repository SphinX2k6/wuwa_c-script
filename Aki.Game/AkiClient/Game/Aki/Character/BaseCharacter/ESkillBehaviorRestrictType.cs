using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D5 RID: 17109
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorRestrictType.ESkillBehaviorRestrictType")]
	public enum ESkillBehaviorRestrictType : byte
	{
		// Token: 0x0401748D RID: 95373
		小队前台角色当前位置,
		// Token: 0x0401748E RID: 95374
		技能施法者当前位置,
		// Token: 0x0401748F RID: 95375
		技能施法者出生位置_怪物专用_,
		// Token: 0x04017490 RID: 95376
		ESkillBehaviorRestrictType_MAX
	}
}
