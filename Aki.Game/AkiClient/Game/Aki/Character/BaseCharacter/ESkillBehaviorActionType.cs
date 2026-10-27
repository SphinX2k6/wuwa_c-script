using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042CE RID: 17102
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESkillBehaviorActionType.ESkillBehaviorActionType")]
	public enum ESkillBehaviorActionType : byte
	{
		// Token: 0x0401744B RID: 95307
		设置位置,
		// Token: 0x0401744C RID: 95308
		设置朝向,
		// Token: 0x0401744D RID: 95309
		播放特效,
		// Token: 0x0401744E RID: 95310
		创建子弹,
		// Token: 0x0401744F RID: 95311
		镜头效果,
		// Token: 0x04017450 RID: 95312
		特写镜头,
		// Token: 0x04017451 RID: 95313
		设置移动状态,
		// Token: 0x04017452 RID: 95314
		设置碰撞,
		// Token: 0x04017453 RID: 95315
		伴生物使用技能,
		// Token: 0x04017454 RID: 95316
		Buff增删,
		// Token: 0x04017455 RID: 95317
		Tag增删,
		// Token: 0x04017456 RID: 95318
		退出脆弱,
		// Token: 0x04017457 RID: 95319
		播放蒙太奇,
		// Token: 0x04017458 RID: 95320
		更新自定义数据,
		// Token: 0x04017459 RID: 95321
		批量生成子弹,
		// Token: 0x0401745A RID: 95322
		ESkillBehaviorActionType_MAX
	}
}
