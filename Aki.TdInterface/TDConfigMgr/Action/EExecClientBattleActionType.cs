using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015DA RID: 5594
	[EnumExtensions]
	public enum EExecClientBattleActionType
	{
		// Token: 0x04004A8E RID: 19086
		SendTagEventToControlCharacter,
		// Token: 0x04004A8F RID: 19087
		TriggerHookPointSkill,
		// Token: 0x04004A90 RID: 19088
		TriggerMotorSkill,
		// Token: 0x04004A91 RID: 19089
		FollowShooterSkill,
		// Token: 0x04004A92 RID: 19090
		GroupAiCommunicate,
		// Token: 0x04004A93 RID: 19091
		ChangeAnimalEmotionBubble,
		// Token: 0x04004A94 RID: 19092
		MonsterNpcInteract,
		// Token: 0x04004A95 RID: 19093
		RoboSoldierSpecialHookSkill,
		// Token: 0x04004A96 RID: 19094
		AssistCharacterMoveToPoint,
		// Token: 0x04004A97 RID: 19095
		AssistCharacterStopMoveToPoint
	}
}
