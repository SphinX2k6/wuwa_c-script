using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200173A RID: 5946
	[EnumExtensions]
	public enum EExecClientBattleActionType
	{
		// Token: 0x04004E4D RID: 20045
		SendTagEventToControlCharacter,
		// Token: 0x04004E4E RID: 20046
		TriggerHookPointSkill,
		// Token: 0x04004E4F RID: 20047
		TriggerMotorSkill,
		// Token: 0x04004E50 RID: 20048
		FollowShooterSkill,
		// Token: 0x04004E51 RID: 20049
		GroupAiCommunicate,
		// Token: 0x04004E52 RID: 20050
		ChangeAnimalEmotionBubble,
		// Token: 0x04004E53 RID: 20051
		MonsterNpcInteract,
		// Token: 0x04004E54 RID: 20052
		RoboSoldierSpecialHookSkill,
		// Token: 0x04004E55 RID: 20053
		AssistCharacterMoveToPoint,
		// Token: 0x04004E56 RID: 20054
		AssistCharacterStopMoveToPoint,
		// Token: 0x04004E57 RID: 20055
		MechExecute
	}
}
