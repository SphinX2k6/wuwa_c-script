using System;

namespace Aki.Protocol
{
	// Token: 0x02001537 RID: 5431
	public enum ECombatRequestDataMessage
	{
		// Token: 0x0400A42B RID: 42027
		CreateBulletRequest = 16833,
		// Token: 0x0400A42C RID: 42028
		DestroyBulletRequest = 26218,
		// Token: 0x0400A42D RID: 42029
		DamageExecuteRequest = 22022,
		// Token: 0x0400A42E RID: 42030
		ApplyGameplayEffectRequest = 22973,
		// Token: 0x0400A42F RID: 42031
		RemoveGameplayEffectRequest = 19884,
		// Token: 0x0400A430 RID: 42032
		HitRequest = 15093,
		// Token: 0x0400A431 RID: 42033
		HitEndRequest = 25554,
		// Token: 0x0400A432 RID: 42034
		SkillRequest = 29518,
		// Token: 0x0400A433 RID: 42035
		UseSkillRequest = 21005,
		// Token: 0x0400A434 RID: 42036
		EndSkillRequest = 24580,
		// Token: 0x0400A435 RID: 42037
		PartUpdateRequest = 23337,
		// Token: 0x0400A436 RID: 42038
		MaterialRequest = 18588,
		// Token: 0x0400A437 RID: 42039
		GameplayCueRequest = 20103,
		// Token: 0x0400A438 RID: 42040
		EntityIsVisibleRequest = 24121,
		// Token: 0x0400A439 RID: 42041
		SwitchCharacterStateRequest = 27567,
		// Token: 0x0400A43A RID: 42042
		LogicStateInitRequest = 26172,
		// Token: 0x0400A43B RID: 42043
		SwitchLogicStateRequest = 18438,
		// Token: 0x0400A43C RID: 42044
		AnimationStateChangedRequest = 26812,
		// Token: 0x0400A43D RID: 42045
		AnimationStateInitRequest = 16475,
		// Token: 0x0400A43E RID: 42046
		ModifyBulletParamsRequest = 16767,
		// Token: 0x0400A43F RID: 42047
		DrownRequest = 18070,
		// Token: 0x0400A440 RID: 42048
		OrderApplyBuffRequest = 21800,
		// Token: 0x0400A441 RID: 42049
		OrderRemoveBuffRequest = 29255,
		// Token: 0x0400A442 RID: 42050
		ActivateBuffRequest = 17149,
		// Token: 0x0400A443 RID: 42051
		OrderRemoveBuffByTagsRequest = 22742,
		// Token: 0x0400A444 RID: 42052
		AiInformationRequest = 27094,
		// Token: 0x0400A445 RID: 42053
		ToughCalcExtraRatioChangeRequest = 23954,
		// Token: 0x0400A446 RID: 42054
		BattleStateChangeRequest = 19661,
		// Token: 0x0400A447 RID: 42055
		AnimationGameplayTagRequest = 25863,
		// Token: 0x0400A448 RID: 42056
		BoneVisibleChangeRequest = 20124,
		// Token: 0x0400A449 RID: 42057
		AiBlackboardsRequest = 17413,
		// Token: 0x0400A44A RID: 42058
		AiBlackboardCdRequest = 28767,
		// Token: 0x0400A44B RID: 42059
		AiHateRequest = 27946,
		// Token: 0x0400A44C RID: 42060
		MonsterBoomRequest = 27664,
		// Token: 0x0400A44D RID: 42061
		CaughtRequest = 21766,
		// Token: 0x0400A44E RID: 42062
		EntityStaticHookMoveRequest = 18356,
		// Token: 0x0400A44F RID: 42063
		ChangeStateRequest = 25799,
		// Token: 0x0400A450 RID: 42064
		ChangeStateConfirmRequest = 27052,
		// Token: 0x0400A451 RID: 42065
		FsmConditionPassRequest = 22886,
		// Token: 0x0400A452 RID: 42066
		BuffStackCountRequest = 19820,
		// Token: 0x0400A453 RID: 42067
		ANStartRequest = 23064,
		// Token: 0x0400A454 RID: 42068
		UseSkillFailRequest = 22140,
		// Token: 0x0400A455 RID: 42069
		EnterViewDirectionRequest = 18587,
		// Token: 0x0400A456 RID: 42070
		ExitViewDirectionRequest = 25488,
		// Token: 0x0400A457 RID: 42071
		PassiveSkillAddRequest = 23740,
		// Token: 0x0400A458 RID: 42072
		InterruptSkillInDelayRequest = 17561,
		// Token: 0x0400A459 RID: 42073
		TriggerExitSkillRequest = 29898,
		// Token: 0x0400A45A RID: 42074
		ActorVisibleRequest = 20487,
		// Token: 0x0400A45B RID: 42075
		BuffEffectRequest = 22540,
		// Token: 0x0400A45C RID: 42076
		FragileChangeRequest = 29703,
		// Token: 0x0400A45D RID: 42077
		RTimeStopRequest = 17578,
		// Token: 0x0400A45E RID: 42078
		DrownEndTeleportRequest = 20649,
		// Token: 0x0400A45F RID: 42079
		MonsterDrownRequest = 21217,
		// Token: 0x0400A460 RID: 42080
		PassiveSkillRemoveRequest = 21925,
		// Token: 0x0400A461 RID: 42081
		RTimeStopInstRequest = 21786,
		// Token: 0x0400A462 RID: 42082
		FsmStateBehaviorRequest = 15369,
		// Token: 0x0400A463 RID: 42083
		FsmPlayMontageRequest = 25452,
		// Token: 0x0400A464 RID: 42084
		RTimeStopAnimRequest = 28204,
		// Token: 0x0400A465 RID: 42085
		SwitchRoleRequest = 20789,
		// Token: 0x0400A466 RID: 42086
		GameplayTagRequest = 25844,
		// Token: 0x0400A467 RID: 42087
		ExecuteQteRequest = 29269,
		// Token: 0x0400A468 RID: 42088
		CombineEntitiesRequest = 19641,
		// Token: 0x0400A469 RID: 42089
		DissolveCombineRelationRequest = 21623,
		// Token: 0x0400A46A RID: 42090
		ClientCurrentRoleReportRequest = 27281,
		// Token: 0x0400A46B RID: 42091
		GaSwitchCommonEnemyProCampRequest = 17625,
		// Token: 0x0400A46C RID: 42092
		ChangeSummonEntityStateRequest = 26759,
		// Token: 0x0400A46D RID: 42093
		CombatMaxCaseMessageRequest = 22467
	}
}
