using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003325 RID: 13093
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorBuffTargetType.ESkillBehaviorBuffTargetType")]
	public enum ESkillBehaviorBuffTargetType : byte
	{
		// Token: 0x04012141 RID: 74049
		施法者,
		// Token: 0x04012142 RID: 74050
		技能目标,
		// Token: 0x04012143 RID: 74051
		ESkillBehaviorBuffTargetType_MAX
	}
}
