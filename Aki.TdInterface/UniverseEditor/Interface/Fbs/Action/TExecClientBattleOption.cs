using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BF RID: 30399
	public enum TExecClientBattleOption : byte
	{
		// Token: 0x04012717 RID: 75543
		NONE,
		// Token: 0x04012718 RID: 75544
		IAssistCharacterMoveToPoint,
		// Token: 0x04012719 RID: 75545
		IAssistCharacterStopMoveToPoint,
		// Token: 0x0401271A RID: 75546
		IChangeAnimalEmotionBubble,
		// Token: 0x0401271B RID: 75547
		IClientGroupAiCommunicate,
		// Token: 0x0401271C RID: 75548
		IClientSendTagEventToControlCharacter,
		// Token: 0x0401271D RID: 75549
		IFollowShooterSkillSkill,
		// Token: 0x0401271E RID: 75550
		IMonsterNpcInteract,
		// Token: 0x0401271F RID: 75551
		IRoboSoldierSpecialTriggerHookSkill,
		// Token: 0x04012720 RID: 75552
		ITriggerHookPointSkill,
		// Token: 0x04012721 RID: 75553
		ITriggerMotorSkill
	}
}
