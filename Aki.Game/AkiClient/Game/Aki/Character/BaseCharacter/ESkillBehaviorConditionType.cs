using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042D2 RID: 17106
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorConditionType.ESkillBehaviorConditionType")]
	public enum ESkillBehaviorConditionType : byte
	{
		// Token: 0x04017470 RID: 95344
		是否有技能目标,
		// Token: 0x04017471 RID: 95345
		与技能目标锁定点距离,
		// Token: 0x04017472 RID: 95346
		与技能目标锁定点角度,
		// Token: 0x04017473 RID: 95347
		施法者标签检测,
		// Token: 0x04017474 RID: 95348
		施法者属性检测,
		// Token: 0x04017475 RID: 95349
		空中高度检测,
		// Token: 0x04017476 RID: 95350
		与技能目标锁定点高度,
		// Token: 0x04017477 RID: 95351
		是否有技能目标和是否战斗单位,
		// Token: 0x04017478 RID: 95352
		是否有摇杆输入,
		// Token: 0x04017479 RID: 95353
		ESkillBehaviorConditionType_MAX
	}
}
