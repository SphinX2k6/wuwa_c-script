using System;

namespace Aki.Protocol
{
	// Token: 0x020015AE RID: 5550
	public enum ECombatPushDataMessage
	{
		// Token: 0x0400A8CC RID: 43212
		ApplyBuffS2cResponsePush = 17435,
		// Token: 0x0400A8CD RID: 43213
		RemoveBuffS2cResponsePush = 16300,
		// Token: 0x0400A8CE RID: 43214
		RemoveBuffByIdS2cResponsePush = 15939,
		// Token: 0x0400A8CF RID: 43215
		CreateBulletPush = 26882,
		// Token: 0x0400A8D0 RID: 43216
		DestroyBulletPush = 28662,
		// Token: 0x0400A8D1 RID: 43217
		ApplyGameplayEffectPush = 17445,
		// Token: 0x0400A8D2 RID: 43218
		RemoveGameplayEffectPush = 29542,
		// Token: 0x0400A8D3 RID: 43219
		HitEndPush = 15924,
		// Token: 0x0400A8D4 RID: 43220
		EndSkillPush = 18120,
		// Token: 0x0400A8D5 RID: 43221
		PartUpdatePush = 25777,
		// Token: 0x0400A8D6 RID: 43222
		MaterialPush = 27552,
		// Token: 0x0400A8D7 RID: 43223
		GameplayCuePush = 21343,
		// Token: 0x0400A8D8 RID: 43224
		EntityIsVisiblePush = 29093,
		// Token: 0x0400A8D9 RID: 43225
		SwitchCharacterStatePush = 17009,
		// Token: 0x0400A8DA RID: 43226
		LogicStateInitPush = 16642,
		// Token: 0x0400A8DB RID: 43227
		SwitchLogicStatePush = 18461,
		// Token: 0x0400A8DC RID: 43228
		AnimationStateChangedPush = 24970,
		// Token: 0x0400A8DD RID: 43229
		AnimationStateInitPush = 22251,
		// Token: 0x0400A8DE RID: 43230
		ModifyBulletParamsPush = 16856,
		// Token: 0x0400A8DF RID: 43231
		DrownPush = 29058,
		// Token: 0x0400A8E0 RID: 43232
		ActivateBuffPush = 16028,
		// Token: 0x0400A8E1 RID: 43233
		AiInformationPush = 22125,
		// Token: 0x0400A8E2 RID: 43234
		ToughCalcExtraRatioChangePush = 24735,
		// Token: 0x0400A8E3 RID: 43235
		BattleStateChangePush = 19385,
		// Token: 0x0400A8E4 RID: 43236
		AnimationGameplayTagPush = 15510,
		// Token: 0x0400A8E5 RID: 43237
		BoneVisibleChangePush = 20838,
		// Token: 0x0400A8E6 RID: 43238
		AiBlackboardsPush = 16697,
		// Token: 0x0400A8E7 RID: 43239
		AiBlackboardCdPush = 18641,
		// Token: 0x0400A8E8 RID: 43240
		AiHatePush = 22440,
		// Token: 0x0400A8E9 RID: 43241
		MonsterBoomPush = 25242,
		// Token: 0x0400A8EA RID: 43242
		CaughtPush = 16870,
		// Token: 0x0400A8EB RID: 43243
		EntityStaticHookMovePush = 20537,
		// Token: 0x0400A8EC RID: 43244
		ChangeStateConfirmPush = 24241,
		// Token: 0x0400A8ED RID: 43245
		BuffStackCountPush = 17747,
		// Token: 0x0400A8EE RID: 43246
		ANStartPush = 19776,
		// Token: 0x0400A8EF RID: 43247
		UseSkillFailPush = 15749,
		// Token: 0x0400A8F0 RID: 43248
		EnterViewDirectionPush = 19916,
		// Token: 0x0400A8F1 RID: 43249
		ExitViewDirectionPush = 16646,
		// Token: 0x0400A8F2 RID: 43250
		PassiveSkillAddPush = 19744,
		// Token: 0x0400A8F3 RID: 43251
		InterruptSkillInDelayPush = 25432,
		// Token: 0x0400A8F4 RID: 43252
		TriggerExitSkillPush = 24805,
		// Token: 0x0400A8F5 RID: 43253
		ActorVisiblePush = 16875,
		// Token: 0x0400A8F6 RID: 43254
		BuffEffectPush = 26677,
		// Token: 0x0400A8F7 RID: 43255
		RTimeStopPush = 21080,
		// Token: 0x0400A8F8 RID: 43256
		DrownEndTeleportPush = 23918,
		// Token: 0x0400A8F9 RID: 43257
		MonsterDrownPush = 26858,
		// Token: 0x0400A8FA RID: 43258
		PassiveSkillRemovePush = 21698,
		// Token: 0x0400A8FB RID: 43259
		RTimeStopInstPush = 20960,
		// Token: 0x0400A8FC RID: 43260
		FsmPlayMontagePush = 28981,
		// Token: 0x0400A8FD RID: 43261
		RTimeStopAnimPush = 28729,
		// Token: 0x0400A8FE RID: 43262
		GameplayTagPush = 24743,
		// Token: 0x0400A8FF RID: 43263
		ExecuteQtePush = 16952,
		// Token: 0x0400A900 RID: 43264
		ClientCurrentRoleReportPush = 29219,
		// Token: 0x0400A901 RID: 43265
		PlayEntityMontagePush = 24591,
		// Token: 0x0400A902 RID: 43266
		BeforeHitPush = 21161,
		// Token: 0x0400A903 RID: 43267
		NewLinkBurstPush = 28450,
		// Token: 0x0400A904 RID: 43268
		RefreshBuffDurationPush = 24982,
		// Token: 0x0400A905 RID: 43269
		RoleGoDownPush = 16452,
		// Token: 0x0400A906 RID: 43270
		FsmConditionPassPush = 24334,
		// Token: 0x0400A907 RID: 43271
		BuffEffectExecutePush = 18599,
		// Token: 0x0400A908 RID: 43272
		VisionTriggerPush = 28446,
		// Token: 0x0400A909 RID: 43273
		MotorIsEnablePush = 16848,
		// Token: 0x0400A90A RID: 43274
		MotorSummonAndRidePush = 18805,
		// Token: 0x0400A90B RID: 43275
		BulletPatternPush = 15914,
		// Token: 0x0400A90C RID: 43276
		QuickHackRamVerifyPush = 22375,
		// Token: 0x0400A90D RID: 43277
		QuickHackOpenPush = 25808,
		// Token: 0x0400A90E RID: 43278
		DodgeInfoPush = 17078,
		// Token: 0x0400A90F RID: 43279
		RoleTrialSceneRollbackPush = 22790
	}
}
