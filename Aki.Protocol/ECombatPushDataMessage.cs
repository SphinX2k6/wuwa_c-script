using System;

namespace Aki.Protocol
{
	// Token: 0x02001538 RID: 5432
	public enum ECombatPushDataMessage
	{
		// Token: 0x0400A46F RID: 42095
		ApplyBuffS2cResponsePush = 16890,
		// Token: 0x0400A470 RID: 42096
		RemoveBuffS2cResponsePush = 23971,
		// Token: 0x0400A471 RID: 42097
		RemoveBuffByIdS2cResponsePush = 19162,
		// Token: 0x0400A472 RID: 42098
		CreateBulletPush = 15442,
		// Token: 0x0400A473 RID: 42099
		DestroyBulletPush = 22933,
		// Token: 0x0400A474 RID: 42100
		ApplyGameplayEffectPush = 29488,
		// Token: 0x0400A475 RID: 42101
		RemoveGameplayEffectPush = 20358,
		// Token: 0x0400A476 RID: 42102
		HitEndPush = 21148,
		// Token: 0x0400A477 RID: 42103
		EndSkillPush = 15273,
		// Token: 0x0400A478 RID: 42104
		PartUpdatePush = 29042,
		// Token: 0x0400A479 RID: 42105
		MaterialPush = 24645,
		// Token: 0x0400A47A RID: 42106
		GameplayCuePush = 19183,
		// Token: 0x0400A47B RID: 42107
		EntityIsVisiblePush = 23399,
		// Token: 0x0400A47C RID: 42108
		SwitchCharacterStatePush = 19156,
		// Token: 0x0400A47D RID: 42109
		LogicStateInitPush = 20507,
		// Token: 0x0400A47E RID: 42110
		SwitchLogicStatePush = 27786,
		// Token: 0x0400A47F RID: 42111
		AnimationStateChangedPush = 20495,
		// Token: 0x0400A480 RID: 42112
		AnimationStateInitPush = 29933,
		// Token: 0x0400A481 RID: 42113
		ModifyBulletParamsPush = 21952,
		// Token: 0x0400A482 RID: 42114
		DrownPush = 18544,
		// Token: 0x0400A483 RID: 42115
		ActivateBuffPush = 20926,
		// Token: 0x0400A484 RID: 42116
		AiInformationPush = 20879,
		// Token: 0x0400A485 RID: 42117
		ToughCalcExtraRatioChangePush = 24319,
		// Token: 0x0400A486 RID: 42118
		BattleStateChangePush = 29436,
		// Token: 0x0400A487 RID: 42119
		AnimationGameplayTagPush = 20216,
		// Token: 0x0400A488 RID: 42120
		BoneVisibleChangePush = 19234,
		// Token: 0x0400A489 RID: 42121
		AiBlackboardsPush = 21837,
		// Token: 0x0400A48A RID: 42122
		AiBlackboardCdPush = 25416,
		// Token: 0x0400A48B RID: 42123
		AiHatePush = 25194,
		// Token: 0x0400A48C RID: 42124
		MonsterBoomPush = 26387,
		// Token: 0x0400A48D RID: 42125
		CaughtPush = 19906,
		// Token: 0x0400A48E RID: 42126
		EntityStaticHookMovePush = 27494,
		// Token: 0x0400A48F RID: 42127
		ChangeStateConfirmPush = 16165,
		// Token: 0x0400A490 RID: 42128
		BuffStackCountPush = 21666,
		// Token: 0x0400A491 RID: 42129
		ANStartPush = 22773,
		// Token: 0x0400A492 RID: 42130
		UseSkillFailPush = 22464,
		// Token: 0x0400A493 RID: 42131
		EnterViewDirectionPush = 28007,
		// Token: 0x0400A494 RID: 42132
		ExitViewDirectionPush = 19441,
		// Token: 0x0400A495 RID: 42133
		PassiveSkillAddPush = 21813,
		// Token: 0x0400A496 RID: 42134
		InterruptSkillInDelayPush = 24695,
		// Token: 0x0400A497 RID: 42135
		TriggerExitSkillPush = 20414,
		// Token: 0x0400A498 RID: 42136
		ActorVisiblePush = 22507,
		// Token: 0x0400A499 RID: 42137
		BuffEffectPush = 20706,
		// Token: 0x0400A49A RID: 42138
		RTimeStopPush = 19986,
		// Token: 0x0400A49B RID: 42139
		DrownEndTeleportPush = 20074,
		// Token: 0x0400A49C RID: 42140
		MonsterDrownPush = 24106,
		// Token: 0x0400A49D RID: 42141
		PassiveSkillRemovePush = 15649,
		// Token: 0x0400A49E RID: 42142
		RTimeStopInstPush = 20510,
		// Token: 0x0400A49F RID: 42143
		FsmPlayMontagePush = 23876,
		// Token: 0x0400A4A0 RID: 42144
		RTimeStopAnimPush = 23930,
		// Token: 0x0400A4A1 RID: 42145
		GameplayTagPush = 20435,
		// Token: 0x0400A4A2 RID: 42146
		ExecuteQtePush = 24316,
		// Token: 0x0400A4A3 RID: 42147
		ClientCurrentRoleReportPush = 20213,
		// Token: 0x0400A4A4 RID: 42148
		PlayEntityMontagePush = 22159,
		// Token: 0x0400A4A5 RID: 42149
		BeforeHitPush = 21067,
		// Token: 0x0400A4A6 RID: 42150
		NewLinkBurstPush = 22970,
		// Token: 0x0400A4A7 RID: 42151
		RefreshBuffDurationPush = 27178,
		// Token: 0x0400A4A8 RID: 42152
		RoleGoDownPush = 21463,
		// Token: 0x0400A4A9 RID: 42153
		FsmConditionPassPush = 19070,
		// Token: 0x0400A4AA RID: 42154
		BuffEffectExecutePush = 18099,
		// Token: 0x0400A4AB RID: 42155
		VisionTriggerPush = 19341,
		// Token: 0x0400A4AC RID: 42156
		MotorIsEnablePush = 28828,
		// Token: 0x0400A4AD RID: 42157
		MotorSummonAndRidePush = 23028,
		// Token: 0x0400A4AE RID: 42158
		BulletPatternPush = 27859,
		// Token: 0x0400A4AF RID: 42159
		QuickHackRamVerifyPush = 25141,
		// Token: 0x0400A4B0 RID: 42160
		QuickHackOpenPush = 16504,
		// Token: 0x0400A4B1 RID: 42161
		DodgeInfoPush = 29777,
		// Token: 0x0400A4B2 RID: 42162
		SwitchDarkTideWeaponPush = 15777,
		// Token: 0x0400A4B3 RID: 42163
		RoleTrialSceneRollbackPush = 15207
	}
}
