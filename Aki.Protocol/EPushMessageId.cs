using System;

namespace Aki.Protocol
{
	// Token: 0x02000009 RID: 9
	public enum EPushMessageId
	{
		// Token: 0x0400143F RID: 5183
		ExitGamePush = 114,
		// Token: 0x04001440 RID: 5184
		CheckClientPush = 116,
		// Token: 0x04001441 RID: 5185
		AceAntiDataPush = 21559,
		// Token: 0x04001442 RID: 5186
		BattlePassEnterPush = 20512,
		// Token: 0x04001443 RID: 5187
		ApplyBuffS2cResponsePush = 17435,
		// Token: 0x04001444 RID: 5188
		RemoveBuffS2cResponsePush = 16300,
		// Token: 0x04001445 RID: 5189
		RemoveBuffByIdS2cResponsePush = 15939,
		// Token: 0x04001446 RID: 5190
		PhotographPush = 27304,
		// Token: 0x04001447 RID: 5191
		TestSpawnTemplateEntityPush = 28168,
		// Token: 0x04001448 RID: 5192
		CharacterDeathPush = 23389,
		// Token: 0x04001449 RID: 5193
		InstFightEndPush = 27687,
		// Token: 0x0400144A RID: 5194
		MapOpenPush = 19992,
		// Token: 0x0400144B RID: 5195
		NetTestDataPush = 24898,
		// Token: 0x0400144C RID: 5196
		MaxMessageIdPush = 22976,
		// Token: 0x0400144D RID: 5197
		MovePackagePush = 18855,
		// Token: 0x0400144E RID: 5198
		UDPMovePackagePush = 18826,
		// Token: 0x0400144F RID: 5199
		EntitySimplyMoveInfoPackagePush = 23337,
		// Token: 0x04001450 RID: 5200
		MoveSceneItemPush = 20741,
		// Token: 0x04001451 RID: 5201
		HoldWeaponPush = 24879,
		// Token: 0x04001452 RID: 5202
		DiscardWeaponPush = 20653,
		// Token: 0x04001453 RID: 5203
		TimeStopPush = 16707,
		// Token: 0x04001454 RID: 5204
		RobotDestinationPush = 24844,
		// Token: 0x04001455 RID: 5205
		PlayerNetStatePush = 24558,
		// Token: 0x04001456 RID: 5206
		EntityTimeFlowPush = 25621,
		// Token: 0x04001457 RID: 5207
		RoleTrialUiEndPush = 29512,
		// Token: 0x04001458 RID: 5208
		RoleSkinTrialUiEndPush = 26571,
		// Token: 0x04001459 RID: 5209
		AiInformationPush = 22125,
		// Token: 0x0400145A RID: 5210
		AiBlackboardsPush = 16697,
		// Token: 0x0400145B RID: 5211
		AiBlackboardCdPush = 18641,
		// Token: 0x0400145C RID: 5212
		AiHatePush = 22440,
		// Token: 0x0400145D RID: 5213
		ApplyGameplayEffectPush = 17445,
		// Token: 0x0400145E RID: 5214
		RemoveGameplayEffectPush = 29542,
		// Token: 0x0400145F RID: 5215
		ActivateBuffPush = 16028,
		// Token: 0x04001460 RID: 5216
		BuffStackCountPush = 17747,
		// Token: 0x04001461 RID: 5217
		BuffEffectPush = 26677,
		// Token: 0x04001462 RID: 5218
		ChangeStateConfirmPush = 24241,
		// Token: 0x04001463 RID: 5219
		FsmPlayMontagePush = 28981,
		// Token: 0x04001464 RID: 5220
		LogicStateInitPush = 16642,
		// Token: 0x04001465 RID: 5221
		SwitchLogicStatePush = 18461,
		// Token: 0x04001466 RID: 5222
		AnimationGameplayTagPush = 15510,
		// Token: 0x04001467 RID: 5223
		BoneVisibleChangePush = 20838,
		// Token: 0x04001468 RID: 5224
		EntityStaticHookMovePush = 20537,
		// Token: 0x04001469 RID: 5225
		EndSkillPush = 18120,
		// Token: 0x0400146A RID: 5226
		InterruptSkillInDelayPush = 25432,
		// Token: 0x0400146B RID: 5227
		UseSkillFailPush = 15749,
		// Token: 0x0400146C RID: 5228
		HitEndPush = 15924,
		// Token: 0x0400146D RID: 5229
		CaughtPush = 16870,
		// Token: 0x0400146E RID: 5230
		CreateBulletPush = 26882,
		// Token: 0x0400146F RID: 5231
		DestroyBulletPush = 28662,
		// Token: 0x04001470 RID: 5232
		ModifyBulletParamsPush = 16856,
		// Token: 0x04001471 RID: 5233
		PassiveSkillAddPush = 19744,
		// Token: 0x04001472 RID: 5234
		PassiveSkillRemovePush = 21698,
		// Token: 0x04001473 RID: 5235
		EnterViewDirectionPush = 19916,
		// Token: 0x04001474 RID: 5236
		ExitViewDirectionPush = 16646,
		// Token: 0x04001475 RID: 5237
		TriggerExitSkillPush = 24805,
		// Token: 0x04001476 RID: 5238
		EntityIsVisiblePush = 29093,
		// Token: 0x04001477 RID: 5239
		ActorVisiblePush = 16875,
		// Token: 0x04001478 RID: 5240
		SwitchCharacterStatePush = 17009,
		// Token: 0x04001479 RID: 5241
		BattleStateChangePush = 19385,
		// Token: 0x0400147A RID: 5242
		ToughCalcExtraRatioChangePush = 24735,
		// Token: 0x0400147B RID: 5243
		MonsterBoomPush = 25242,
		// Token: 0x0400147C RID: 5244
		ANStartPush = 19776,
		// Token: 0x0400147D RID: 5245
		GameplayTagPush = 24743,
		// Token: 0x0400147E RID: 5246
		GameplayCuePush = 21343,
		// Token: 0x0400147F RID: 5247
		ExecuteQtePush = 16952,
		// Token: 0x04001480 RID: 5248
		ClientCurrentRoleReportPush = 29219,
		// Token: 0x04001481 RID: 5249
		PartUpdatePush = 25777,
		// Token: 0x04001482 RID: 5250
		AnimationStateInitPush = 22251,
		// Token: 0x04001483 RID: 5251
		AnimationStateChangedPush = 24970,
		// Token: 0x04001484 RID: 5252
		DrownPush = 29058,
		// Token: 0x04001485 RID: 5253
		DrownEndTeleportPush = 23918,
		// Token: 0x04001486 RID: 5254
		MonsterDrownPush = 26858,
		// Token: 0x04001487 RID: 5255
		MaterialPush = 27552,
		// Token: 0x04001488 RID: 5256
		RTimeStopAnimPush = 28729,
		// Token: 0x04001489 RID: 5257
		RTimeStopPush = 21080,
		// Token: 0x0400148A RID: 5258
		RTimeStopInstPush = 20960,
		// Token: 0x0400148B RID: 5259
		PlayEntityMontagePush = 24591,
		// Token: 0x0400148C RID: 5260
		BeforeHitPush = 21161,
		// Token: 0x0400148D RID: 5261
		NewLinkBurstPush = 28450,
		// Token: 0x0400148E RID: 5262
		RefreshBuffDurationPush = 24982,
		// Token: 0x0400148F RID: 5263
		SlowTimePush = 19838,
		// Token: 0x04001490 RID: 5264
		RoleGoDownPush = 16452,
		// Token: 0x04001491 RID: 5265
		FsmConditionPassPush = 24334,
		// Token: 0x04001492 RID: 5266
		SimpleCombatEntitySyncAttributePush = 24434,
		// Token: 0x04001493 RID: 5267
		CharacterMoveToPointEndPush = 27483,
		// Token: 0x04001494 RID: 5268
		SunSpiritActionOperationEndPush = 22214,
		// Token: 0x04001495 RID: 5269
		BuffEffectExecutePush = 18599,
		// Token: 0x04001496 RID: 5270
		VisionTriggerPush = 28446,
		// Token: 0x04001497 RID: 5271
		SceneBlockSplitClientLoginPush = 24812,
		// Token: 0x04001498 RID: 5272
		SceneBlockChangePush = 18483,
		// Token: 0x04001499 RID: 5273
		SceneBlockSplitSwitchStatePush = 29772,
		// Token: 0x0400149A RID: 5274
		RoadNetworkEntityUpdateCurRoadPush = 17914,
		// Token: 0x0400149B RID: 5275
		SceneBlockSplitPlayerNeedBlockPush = 29579,
		// Token: 0x0400149C RID: 5276
		MotorAnimReplaySampleUdpPush = 18728,
		// Token: 0x0400149D RID: 5277
		MotorIsEnablePush = 16848,
		// Token: 0x0400149E RID: 5278
		MotorSummonAndRidePush = 18805,
		// Token: 0x0400149F RID: 5279
		MotorFightRefreshBossPush = 23084,
		// Token: 0x040014A0 RID: 5280
		BlackScreenStatePush = 15727,
		// Token: 0x040014A1 RID: 5281
		MotorCycleCruiseStatePush = 28534,
		// Token: 0x040014A2 RID: 5282
		BulletPatternPush = 15914,
		// Token: 0x040014A3 RID: 5283
		FlowerPollutionSplinePush = 18370,
		// Token: 0x040014A4 RID: 5284
		QuickHackRamVerifyPush = 22375,
		// Token: 0x040014A5 RID: 5285
		MotorPositionStatePush = 28875,
		// Token: 0x040014A6 RID: 5286
		KurotatoSyncEntityDealDamagePush = 23335,
		// Token: 0x040014A7 RID: 5287
		MotorOnlineProgressReportPush = 18346,
		// Token: 0x040014A8 RID: 5288
		QuickHackOpenPush = 25808,
		// Token: 0x040014A9 RID: 5289
		DodgeInfoPush = 17078,
		// Token: 0x040014AA RID: 5290
		RoleTrialSceneRollbackPush = 22790,
		// Token: 0x040014AB RID: 5291
		PlayerNetStateBackServerPush = 19999,
		// Token: 0x040014AC RID: 5292
		ZitherPlayNotePush = 16749,
		// Token: 0x040014AD RID: 5293
		FollowerChairPresentationPush = 24462
	}
}
