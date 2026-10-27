using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D4 RID: 17108
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorLocationType.ESkillBehaviorLocationType")]
	public enum ESkillBehaviorLocationType : byte
	{
		// Token: 0x04017482 RID: 95362
		技能施法者,
		// Token: 0x04017483 RID: 95363
		技能目标锁定点,
		// Token: 0x04017484 RID: 95364
		当前小队锁定目标,
		// Token: 0x04017485 RID: 95365
		小队当前角色,
		// Token: 0x04017486 RID: 95366
		召唤者_伴生物专用_,
		// Token: 0x04017487 RID: 95367
		当前小队摄像机,
		// Token: 0x04017488 RID: 95368
		黑板位置,
		// Token: 0x04017489 RID: 95369
		子弹位置,
		// Token: 0x0401748A RID: 95370
		伴生物位置,
		// Token: 0x0401748B RID: 95371
		ESkillBehaviorLocationType_MAX
	}
}
