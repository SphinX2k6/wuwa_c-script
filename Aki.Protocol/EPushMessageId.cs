using System;

namespace Aki.Protocol
{
	// Token: 0x02000009 RID: 9
	public enum EPushMessageId
	{
		// Token: 0x0400140A RID: 5130
		ExitGamePush = 114,
		// Token: 0x0400140B RID: 5131
		CheckClientPush = 116,
		// Token: 0x0400140C RID: 5132
		AceAntiDataPush = 25028,
		// Token: 0x0400140D RID: 5133
		BattlePassEnterPush = 19788,
		// Token: 0x0400140E RID: 5134
		ApplyBuffS2cResponsePush = 16890,
		// Token: 0x0400140F RID: 5135
		RemoveBuffS2cResponsePush = 23971,
		// Token: 0x04001410 RID: 5136
		RemoveBuffByIdS2cResponsePush = 19162,
		// Token: 0x04001411 RID: 5137
		PhotographPush = 26905,
		// Token: 0x04001412 RID: 5138
		TestSpawnTemplateEntityPush = 19647,
		// Token: 0x04001413 RID: 5139
		CharacterDeathPush = 16870,
		// Token: 0x04001414 RID: 5140
		InstFightEndPush = 27255,
		// Token: 0x04001415 RID: 5141
		MapOpenPush = 21465,
		// Token: 0x04001416 RID: 5142
		NetTestDataPush = 21765,
		// Token: 0x04001417 RID: 5143
		MaxMessageIdPush = 23839,
		// Token: 0x04001418 RID: 5144
		MovePackagePush = 24756,
		// Token: 0x04001419 RID: 5145
		UDPMovePackagePush = 24978,
		// Token: 0x0400141A RID: 5146
		EntitySimplyMoveInfoPackagePush = 18037,
		// Token: 0x0400141B RID: 5147
		MoveSceneItemPush = 21046,
		// Token: 0x0400141C RID: 5148
		HoldWeaponPush = 26659,
		// Token: 0x0400141D RID: 5149
		DiscardWeaponPush = 20752,
		// Token: 0x0400141E RID: 5150
		TimeStopPush = 23351,
		// Token: 0x0400141F RID: 5151
		RobotDestinationPush = 20295,
		// Token: 0x04001420 RID: 5152
		PlayerNetStatePush = 17456,
		// Token: 0x04001421 RID: 5153
		EntityTimeFlowPush = 25999,
		// Token: 0x04001422 RID: 5154
		RoleTrialUiEndPush = 26138,
		// Token: 0x04001423 RID: 5155
		RoleSkinTrialUiEndPush = 22109,
		// Token: 0x04001424 RID: 5156
		AiInformationPush = 20879,
		// Token: 0x04001425 RID: 5157
		AiBlackboardsPush = 21837,
		// Token: 0x04001426 RID: 5158
		AiBlackboardCdPush = 25416,
		// Token: 0x04001427 RID: 5159
		AiHatePush = 25194,
		// Token: 0x04001428 RID: 5160
		ApplyGameplayEffectPush = 29488,
		// Token: 0x04001429 RID: 5161
		RemoveGameplayEffectPush = 20358,
		// Token: 0x0400142A RID: 5162
		ActivateBuffPush = 20926,
		// Token: 0x0400142B RID: 5163
		BuffStackCountPush = 21666,
		// Token: 0x0400142C RID: 5164
		BuffEffectPush = 20706,
		// Token: 0x0400142D RID: 5165
		ChangeStateConfirmPush = 16165,
		// Token: 0x0400142E RID: 5166
		FsmPlayMontagePush = 23876,
		// Token: 0x0400142F RID: 5167
		LogicStateInitPush = 20507,
		// Token: 0x04001430 RID: 5168
		SwitchLogicStatePush = 27786,
		// Token: 0x04001431 RID: 5169
		AnimationGameplayTagPush = 20216,
		// Token: 0x04001432 RID: 5170
		BoneVisibleChangePush = 19234,
		// Token: 0x04001433 RID: 5171
		EntityStaticHookMovePush = 27494,
		// Token: 0x04001434 RID: 5172
		EndSkillPush = 15273,
		// Token: 0x04001435 RID: 5173
		InterruptSkillInDelayPush = 24695,
		// Token: 0x04001436 RID: 5174
		UseSkillFailPush = 22464,
		// Token: 0x04001437 RID: 5175
		HitEndPush = 21148,
		// Token: 0x04001438 RID: 5176
		CaughtPush = 19906,
		// Token: 0x04001439 RID: 5177
		CreateBulletPush = 15442,
		// Token: 0x0400143A RID: 5178
		DestroyBulletPush = 22933,
		// Token: 0x0400143B RID: 5179
		ModifyBulletParamsPush = 21952,
		// Token: 0x0400143C RID: 5180
		PassiveSkillAddPush = 21813,
		// Token: 0x0400143D RID: 5181
		PassiveSkillRemovePush = 15649,
		// Token: 0x0400143E RID: 5182
		EnterViewDirectionPush = 28007,
		// Token: 0x0400143F RID: 5183
		ExitViewDirectionPush = 19441,
		// Token: 0x04001440 RID: 5184
		TriggerExitSkillPush = 20414,
		// Token: 0x04001441 RID: 5185
		EntityIsVisiblePush = 23399,
		// Token: 0x04001442 RID: 5186
		ActorVisiblePush = 22507,
		// Token: 0x04001443 RID: 5187
		SwitchCharacterStatePush = 19156,
		// Token: 0x04001444 RID: 5188
		BattleStateChangePush = 29436,
		// Token: 0x04001445 RID: 5189
		ToughCalcExtraRatioChangePush = 24319,
		// Token: 0x04001446 RID: 5190
		MonsterBoomPush = 26387,
		// Token: 0x04001447 RID: 5191
		ANStartPush = 22773,
		// Token: 0x04001448 RID: 5192
		GameplayTagPush = 20435,
		// Token: 0x04001449 RID: 5193
		GameplayCuePush = 19183,
		// Token: 0x0400144A RID: 5194
		ExecuteQtePush = 24316,
		// Token: 0x0400144B RID: 5195
		ClientCurrentRoleReportPush = 20213,
		// Token: 0x0400144C RID: 5196
		PartUpdatePush = 29042,
		// Token: 0x0400144D RID: 5197
		AnimationStateInitPush = 29933,
		// Token: 0x0400144E RID: 5198
		AnimationStateChangedPush = 20495,
		// Token: 0x0400144F RID: 5199
		DrownPush = 18544,
		// Token: 0x04001450 RID: 5200
		DrownEndTeleportPush = 20074,
		// Token: 0x04001451 RID: 5201
		MonsterDrownPush = 24106,
		// Token: 0x04001452 RID: 5202
		MaterialPush = 24645,
		// Token: 0x04001453 RID: 5203
		RTimeStopAnimPush = 23930,
		// Token: 0x04001454 RID: 5204
		RTimeStopPush = 19986,
		// Token: 0x04001455 RID: 5205
		RTimeStopInstPush = 20510,
		// Token: 0x04001456 RID: 5206
		PlayEntityMontagePush = 22159,
		// Token: 0x04001457 RID: 5207
		BeforeHitPush = 21067,
		// Token: 0x04001458 RID: 5208
		NewLinkBurstPush = 22970,
		// Token: 0x04001459 RID: 5209
		RefreshBuffDurationPush = 27178,
		// Token: 0x0400145A RID: 5210
		SlowTimePush = 28835,
		// Token: 0x0400145B RID: 5211
		RoleGoDownPush = 21463,
		// Token: 0x0400145C RID: 5212
		FsmConditionPassPush = 19070,
		// Token: 0x0400145D RID: 5213
		SimpleCombatEntitySyncAttributePush = 29113,
		// Token: 0x0400145E RID: 5214
		CharacterMoveToPointEndPush = 21734,
		// Token: 0x0400145F RID: 5215
		SunSpiritActionOperationEndPush = 20253,
		// Token: 0x04001460 RID: 5216
		BuffEffectExecutePush = 18099,
		// Token: 0x04001461 RID: 5217
		VisionTriggerPush = 19341,
		// Token: 0x04001462 RID: 5218
		SceneBlockSplitClientLoginPush = 18577,
		// Token: 0x04001463 RID: 5219
		SceneBlockChangePush = 19606,
		// Token: 0x04001464 RID: 5220
		SceneBlockSplitSwitchStatePush = 15490,
		// Token: 0x04001465 RID: 5221
		RoadNetworkEntityUpdateCurRoadPush = 24166,
		// Token: 0x04001466 RID: 5222
		SceneBlockSplitPlayerNeedBlockPush = 16044,
		// Token: 0x04001467 RID: 5223
		MotorAnimReplaySampleUdpPush = 25977,
		// Token: 0x04001468 RID: 5224
		MotorIsEnablePush = 28828,
		// Token: 0x04001469 RID: 5225
		MotorSummonAndRidePush = 23028,
		// Token: 0x0400146A RID: 5226
		MotorFightRefreshBossPush = 15231,
		// Token: 0x0400146B RID: 5227
		BlackScreenStatePush = 16136,
		// Token: 0x0400146C RID: 5228
		MotorCycleCruiseStatePush = 28153,
		// Token: 0x0400146D RID: 5229
		BulletPatternPush = 27859,
		// Token: 0x0400146E RID: 5230
		FlowerPollutionSplinePush = 21867,
		// Token: 0x0400146F RID: 5231
		QuickHackRamVerifyPush = 25141,
		// Token: 0x04001470 RID: 5232
		MotorPositionStatePush = 22169,
		// Token: 0x04001471 RID: 5233
		KurotatoSyncEntityDealDamagePush = 26756,
		// Token: 0x04001472 RID: 5234
		MotorOnlineProgressReportPush = 15835,
		// Token: 0x04001473 RID: 5235
		QuickHackOpenPush = 16504,
		// Token: 0x04001474 RID: 5236
		DodgeInfoPush = 29777,
		// Token: 0x04001475 RID: 5237
		RoleTrialSceneRollbackPush = 15207,
		// Token: 0x04001476 RID: 5238
		SwitchDarkTideWeaponPush = 15777,
		// Token: 0x04001477 RID: 5239
		PlayerNetStateBackServerPush = 23205,
		// Token: 0x04001478 RID: 5240
		ZitherPlayNotePush = 27243,
		// Token: 0x04001479 RID: 5241
		FollowerChairPresentationPush = 18876
	}
}
