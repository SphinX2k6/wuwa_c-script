using System;

namespace Aki.Protocol
{
	// Token: 0x02001536 RID: 5430
	public enum ECombatNotifyDataMessage
	{
		// Token: 0x0400A3DE RID: 41950
		CreateBulletNotify = 29868,
		// Token: 0x0400A3DF RID: 41951
		DestroyBulletNotify = 16776,
		// Token: 0x0400A3E0 RID: 41952
		DamageExecuteNotify = 28964,
		// Token: 0x0400A3E1 RID: 41953
		ApplyGameplayEffectNotify = 25830,
		// Token: 0x0400A3E2 RID: 41954
		RemoveGameplayEffectNotify = 18345,
		// Token: 0x0400A3E3 RID: 41955
		HitNotify = 27776,
		// Token: 0x0400A3E4 RID: 41956
		SkillNotify = 20156,
		// Token: 0x0400A3E5 RID: 41957
		UseSkillNotify = 20528,
		// Token: 0x0400A3E6 RID: 41958
		EndSkillNotify = 25131,
		// Token: 0x0400A3E7 RID: 41959
		EntityLoadCompleteNotify = 29145,
		// Token: 0x0400A3E8 RID: 41960
		PartUpdateNotify = 23036,
		// Token: 0x0400A3E9 RID: 41961
		PartComponentInitNotify = 27435,
		// Token: 0x0400A3EA RID: 41962
		MaterialNotify = 29636,
		// Token: 0x0400A3EB RID: 41963
		GameplayCueNotify = 29715,
		// Token: 0x0400A3EC RID: 41964
		EntityIsVisibleNotify = 17405,
		// Token: 0x0400A3ED RID: 41965
		SwitchCharacterStateNotify = 15678,
		// Token: 0x0400A3EE RID: 41966
		PlayerRebackSceneNotify = 25253,
		// Token: 0x0400A3EF RID: 41967
		LogicStateInitNotify = 24779,
		// Token: 0x0400A3F0 RID: 41968
		SwitchLogicStateNotify = 19887,
		// Token: 0x0400A3F1 RID: 41969
		AttributeChangedNotify = 27832,
		// Token: 0x0400A3F2 RID: 41970
		AnimationStateChangedNotify = 15580,
		// Token: 0x0400A3F3 RID: 41971
		AnimationStateInitNotify = 27651,
		// Token: 0x0400A3F4 RID: 41972
		ModifyBulletParamsNotify = 17666,
		// Token: 0x0400A3F5 RID: 41973
		DrownNotify = 26523,
		// Token: 0x0400A3F6 RID: 41974
		OrderApplyBuffNotify = 26471,
		// Token: 0x0400A3F7 RID: 41975
		OrderRemoveBuffNotify = 17807,
		// Token: 0x0400A3F8 RID: 41976
		ActivateBuffNotify = 28221,
		// Token: 0x0400A3F9 RID: 41977
		OrderRemoveBuffByTagsNotify = 24520,
		// Token: 0x0400A3FA RID: 41978
		AiInformationNotify = 27868,
		// Token: 0x0400A3FB RID: 41979
		BattleStateChangeNotify = 22142,
		// Token: 0x0400A3FC RID: 41980
		AnimationGameplayTagNotify = 17636,
		// Token: 0x0400A3FD RID: 41981
		BoneVisibleChangeNotify = 16295,
		// Token: 0x0400A3FE RID: 41982
		AiBlackboardCdNotify = 26627,
		// Token: 0x0400A3FF RID: 41983
		CaughtNotify = 17797,
		// Token: 0x0400A400 RID: 41984
		EntityStaticHookMoveNotify = 26938,
		// Token: 0x0400A401 RID: 41985
		ChangeStateNotify = 21371,
		// Token: 0x0400A402 RID: 41986
		ChangeStateConfirmNotify = 20811,
		// Token: 0x0400A403 RID: 41987
		BuffStackCountNotify = 29363,
		// Token: 0x0400A404 RID: 41988
		MontagePlayNotify = 17788,
		// Token: 0x0400A405 RID: 41989
		ANStartNotify = 24660,
		// Token: 0x0400A406 RID: 41990
		FsmResetNotify = 16867,
		// Token: 0x0400A407 RID: 41991
		DamageRecordNotify = 22979,
		// Token: 0x0400A408 RID: 41992
		AiHateNotify = 21698,
		// Token: 0x0400A409 RID: 41993
		FsmBlackboardNotify = 18761,
		// Token: 0x0400A40A RID: 41994
		CharacterBattleStateChangeNotify = 25768,
		// Token: 0x0400A40B RID: 41995
		ApplyBuffS2cRequestNotify = 18641,
		// Token: 0x0400A40C RID: 41996
		RemoveBuffS2cRequestNotify = 20022,
		// Token: 0x0400A40D RID: 41997
		ActorVisibleNotify = 23346,
		// Token: 0x0400A40E RID: 41998
		RecoverPropChangedNotify = 29454,
		// Token: 0x0400A40F RID: 41999
		RemoveBuffByIdS2cRequestNotify = 19482,
		// Token: 0x0400A410 RID: 42000
		ShieldUpdateNotify = 26592,
		// Token: 0x0400A411 RID: 42001
		PlayerBattleStateChangeNotify = 25044,
		// Token: 0x0400A412 RID: 42002
		FsmCustomBlackboardNotify = 19239,
		// Token: 0x0400A413 RID: 42003
		PassiveSkillAddNotify = 22690,
		// Token: 0x0400A414 RID: 42004
		PassiveSkillRemoveNotify = 22034,
		// Token: 0x0400A415 RID: 42005
		ExecuteQteNotify = 20131,
		// Token: 0x0400A416 RID: 42006
		ModifyEntityCampNotify = 28258,
		// Token: 0x0400A417 RID: 42007
		AddCombineEntitiesRelationNotify = 25278,
		// Token: 0x0400A418 RID: 42008
		RemoveCombineRelationNotify = 17117,
		// Token: 0x0400A419 RID: 42009
		TestDamageRecordNotify = 22542,
		// Token: 0x0400A41A RID: 42010
		BuffDurationNotify = 16974,
		// Token: 0x0400A41B RID: 42011
		EntityLivingStatusNotify = 23945,
		// Token: 0x0400A41C RID: 42012
		NewLinkNotify = 23833,
		// Token: 0x0400A41D RID: 42013
		ApplyBuffFailedNotify = 22435,
		// Token: 0x0400A41E RID: 42014
		PackAnimChangedNotify = 27418,
		// Token: 0x0400A41F RID: 42015
		VisionTriggerNotify = 21314,
		// Token: 0x0400A420 RID: 42016
		RemoveBuffByServerIdS2cRequestNotify = 23494,
		// Token: 0x0400A421 RID: 42017
		TransformBuffStackNotify = 27991,
		// Token: 0x0400A422 RID: 42018
		MotorSummonAndRideNotify = 20643,
		// Token: 0x0400A423 RID: 42019
		BulletPatternNotify = 29108,
		// Token: 0x0400A424 RID: 42020
		FsmMontageDurationNotify = 20087,
		// Token: 0x0400A425 RID: 42021
		SwitchDarkTideWeaponSlotNotify = 18091,
		// Token: 0x0400A426 RID: 42022
		CombatValNotify = 28115,
		// Token: 0x0400A427 RID: 42023
		CombatValDecayBeginNotify = 19990,
		// Token: 0x0400A428 RID: 42024
		SquadPropChangedNotify = 21485,
		// Token: 0x0400A429 RID: 42025
		CombatDataMaxNotify = 28947
	}
}
