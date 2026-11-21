using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8B RID: 28043
	public enum IExecClientBattleActionType_Union : byte
	{
		// Token: 0x04011C18 RID: 72728
		NONE,
		// Token: 0x04011C19 RID: 72729
		IExecClientBattleActionType,
		// Token: 0x04011C1A RID: 72730
		IClientSendTagEventToControlCharacter,
		// Token: 0x04011C1B RID: 72731
		ITriggerHookPointSkill,
		// Token: 0x04011C1C RID: 72732
		ITriggerMotorSkill,
		// Token: 0x04011C1D RID: 72733
		IFollowShooterSkillSkill,
		// Token: 0x04011C1E RID: 72734
		IClientGroupAiCommunicate,
		// Token: 0x04011C1F RID: 72735
		IChangeAnimalEmotionBubble,
		// Token: 0x04011C20 RID: 72736
		IMonsterNpcInteract,
		// Token: 0x04011C21 RID: 72737
		IRoboSoldierSpecialTriggerHookSkill,
		// Token: 0x04011C22 RID: 72738
		IAssistCharacterMoveToPoint,
		// Token: 0x04011C23 RID: 72739
		IAssistCharacterStopMoveToPoint,
		// Token: 0x04011C24 RID: 72740
		IMechExecute
	}
}
