using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003323 RID: 13091
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorActionType.ESkillBehaviorActionType")]
	public enum ESkillBehaviorActionType : byte
	{
		// Token: 0x04012128 RID: 74024
		设置位置,
		// Token: 0x04012129 RID: 74025
		设置朝向,
		// Token: 0x0401212A RID: 74026
		播放特效,
		// Token: 0x0401212B RID: 74027
		创建子弹,
		// Token: 0x0401212C RID: 74028
		镜头效果,
		// Token: 0x0401212D RID: 74029
		特写镜头,
		// Token: 0x0401212E RID: 74030
		设置移动状态,
		// Token: 0x0401212F RID: 74031
		设置碰撞,
		// Token: 0x04012130 RID: 74032
		伴生物使用技能,
		// Token: 0x04012131 RID: 74033
		Buff增删,
		// Token: 0x04012132 RID: 74034
		Tag增删,
		// Token: 0x04012133 RID: 74035
		退出脆弱,
		// Token: 0x04012134 RID: 74036
		播放蒙太奇,
		// Token: 0x04012135 RID: 74037
		更新自定义数据,
		// Token: 0x04012136 RID: 74038
		批量生成子弹,
		// Token: 0x04012137 RID: 74039
		ESkillBehaviorActionType_MAX
	}
}
