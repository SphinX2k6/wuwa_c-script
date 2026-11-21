using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065AC RID: 26028
	public enum EExecClientBattleActionType : byte
	{
		// Token: 0x04010AC1 RID: 68289
		SendTagEventToControlCharacter,
		// Token: 0x04010AC2 RID: 68290
		TriggerHookPointSkill,
		// Token: 0x04010AC3 RID: 68291
		TriggerMotorSkill,
		// Token: 0x04010AC4 RID: 68292
		FollowShooterSkill,
		// Token: 0x04010AC5 RID: 68293
		GroupAiCommunicate,
		// Token: 0x04010AC6 RID: 68294
		ChangeAnimalEmotionBubble,
		// Token: 0x04010AC7 RID: 68295
		MonsterNpcInteract,
		// Token: 0x04010AC8 RID: 68296
		RoboSoldierSpecialHookSkill,
		// Token: 0x04010AC9 RID: 68297
		AssistCharacterMoveToPoint,
		// Token: 0x04010ACA RID: 68298
		AssistCharacterStopMoveToPoint,
		// Token: 0x04010ACB RID: 68299
		MechExecute
	}
}
