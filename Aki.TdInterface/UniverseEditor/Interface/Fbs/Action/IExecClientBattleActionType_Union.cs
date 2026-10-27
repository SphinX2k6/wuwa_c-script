using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670B RID: 26379
	public enum IExecClientBattleActionType_Union : byte
	{
		// Token: 0x04010DE7 RID: 69095
		NONE,
		// Token: 0x04010DE8 RID: 69096
		IExecClientBattleActionType,
		// Token: 0x04010DE9 RID: 69097
		IClientSendTagEventToControlCharacter,
		// Token: 0x04010DEA RID: 69098
		ITriggerHookPointSkill,
		// Token: 0x04010DEB RID: 69099
		ITriggerMotorSkill,
		// Token: 0x04010DEC RID: 69100
		IFollowShooterSkillSkill,
		// Token: 0x04010DED RID: 69101
		IClientGroupAiCommunicate,
		// Token: 0x04010DEE RID: 69102
		IChangeAnimalEmotionBubble,
		// Token: 0x04010DEF RID: 69103
		IMonsterNpcInteract,
		// Token: 0x04010DF0 RID: 69104
		IRoboSoldierSpecialTriggerHookSkill,
		// Token: 0x04010DF1 RID: 69105
		IAssistCharacterMoveToPoint,
		// Token: 0x04010DF2 RID: 69106
		IAssistCharacterStopMoveToPoint
	}
}
