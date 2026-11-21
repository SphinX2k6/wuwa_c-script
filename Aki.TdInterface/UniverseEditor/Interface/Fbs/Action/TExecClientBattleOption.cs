using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ECD RID: 32461
	public enum TExecClientBattleOption : byte
	{
		// Token: 0x04013768 RID: 79720
		NONE,
		// Token: 0x04013769 RID: 79721
		IAssistCharacterMoveToPoint,
		// Token: 0x0401376A RID: 79722
		IAssistCharacterStopMoveToPoint,
		// Token: 0x0401376B RID: 79723
		IChangeAnimalEmotionBubble,
		// Token: 0x0401376C RID: 79724
		IClientGroupAiCommunicate,
		// Token: 0x0401376D RID: 79725
		IClientSendTagEventToControlCharacter,
		// Token: 0x0401376E RID: 79726
		IFollowShooterSkillSkill,
		// Token: 0x0401376F RID: 79727
		IMechExecute,
		// Token: 0x04013770 RID: 79728
		IMonsterNpcInteract,
		// Token: 0x04013771 RID: 79729
		IRoboSoldierSpecialTriggerHookSkill,
		// Token: 0x04013772 RID: 79730
		ITriggerHookPointSkill,
		// Token: 0x04013773 RID: 79731
		ITriggerMotorSkill
	}
}
