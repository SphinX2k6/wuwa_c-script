using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003329 RID: 13097
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorLocationType.ESkillBehaviorLocationType")]
	public enum ESkillBehaviorLocationType : byte
	{
		// Token: 0x0401215F RID: 74079
		技能施法者,
		// Token: 0x04012160 RID: 74080
		技能目标锁定点,
		// Token: 0x04012161 RID: 74081
		当前小队锁定目标,
		// Token: 0x04012162 RID: 74082
		小队当前角色,
		// Token: 0x04012163 RID: 74083
		召唤者_伴生物专用_,
		// Token: 0x04012164 RID: 74084
		当前小队摄像机,
		// Token: 0x04012165 RID: 74085
		黑板位置,
		// Token: 0x04012166 RID: 74086
		子弹位置,
		// Token: 0x04012167 RID: 74087
		伴生物位置,
		// Token: 0x04012168 RID: 74088
		ESkillBehaviorLocationType_MAX
	}
}
