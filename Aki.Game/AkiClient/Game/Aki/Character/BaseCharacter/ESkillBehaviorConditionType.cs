using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003327 RID: 13095
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorConditionType.ESkillBehaviorConditionType")]
	public enum ESkillBehaviorConditionType : byte
	{
		// Token: 0x0401214D RID: 74061
		是否有技能目标,
		// Token: 0x0401214E RID: 74062
		与技能目标锁定点距离,
		// Token: 0x0401214F RID: 74063
		与技能目标锁定点角度,
		// Token: 0x04012150 RID: 74064
		施法者标签检测,
		// Token: 0x04012151 RID: 74065
		施法者属性检测,
		// Token: 0x04012152 RID: 74066
		空中高度检测,
		// Token: 0x04012153 RID: 74067
		与技能目标锁定点高度,
		// Token: 0x04012154 RID: 74068
		是否有技能目标和是否战斗单位,
		// Token: 0x04012155 RID: 74069
		是否有摇杆输入,
		// Token: 0x04012156 RID: 74070
		ESkillBehaviorConditionType_MAX
	}
}
