using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D0 RID: 17104
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorBuffTargetType.ESkillBehaviorBuffTargetType")]
	public enum ESkillBehaviorBuffTargetType : byte
	{
		// Token: 0x04017464 RID: 95332
		施法者,
		// Token: 0x04017465 RID: 95333
		技能目标,
		// Token: 0x04017466 RID: 95334
		ESkillBehaviorBuffTargetType_MAX
	}
}
