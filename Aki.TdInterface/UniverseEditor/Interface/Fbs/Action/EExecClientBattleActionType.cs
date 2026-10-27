using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02005F67 RID: 24423
	public enum EExecClientBattleActionType : byte
	{
		// Token: 0x0400FD3E RID: 64830
		SendTagEventToControlCharacter,
		// Token: 0x0400FD3F RID: 64831
		TriggerHookPointSkill,
		// Token: 0x0400FD40 RID: 64832
		TriggerMotorSkill,
		// Token: 0x0400FD41 RID: 64833
		FollowShooterSkill,
		// Token: 0x0400FD42 RID: 64834
		GroupAiCommunicate,
		// Token: 0x0400FD43 RID: 64835
		ChangeAnimalEmotionBubble,
		// Token: 0x0400FD44 RID: 64836
		MonsterNpcInteract,
		// Token: 0x0400FD45 RID: 64837
		RoboSoldierSpecialHookSkill,
		// Token: 0x0400FD46 RID: 64838
		AssistCharacterMoveToPoint,
		// Token: 0x0400FD47 RID: 64839
		AssistCharacterStopMoveToPoint
	}
}
