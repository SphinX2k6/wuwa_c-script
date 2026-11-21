using System;

namespace Aki.Protocol
{
	// Token: 0x020015AC RID: 5548
	public enum ECombatNotifyDataMessage
	{
		// Token: 0x0400A83B RID: 43067
		CreateBulletNotify = 15915,
		// Token: 0x0400A83C RID: 43068
		DestroyBulletNotify = 16659,
		// Token: 0x0400A83D RID: 43069
		DamageExecuteNotify = 28829,
		// Token: 0x0400A83E RID: 43070
		ApplyGameplayEffectNotify = 26040,
		// Token: 0x0400A83F RID: 43071
		RemoveGameplayEffectNotify = 18172,
		// Token: 0x0400A840 RID: 43072
		HitNotify = 20656,
		// Token: 0x0400A841 RID: 43073
		SkillNotify = 19915,
		// Token: 0x0400A842 RID: 43074
		UseSkillNotify = 19813,
		// Token: 0x0400A843 RID: 43075
		EndSkillNotify = 27580,
		// Token: 0x0400A844 RID: 43076
		EntityLoadCompleteNotify = 21435,
		// Token: 0x0400A845 RID: 43077
		PartUpdateNotify = 24482,
		// Token: 0x0400A846 RID: 43078
		PartComponentInitNotify = 25520,
		// Token: 0x0400A847 RID: 43079
		MaterialNotify = 26008,
		// Token: 0x0400A848 RID: 43080
		GameplayCueNotify = 21307,
		// Token: 0x0400A849 RID: 43081
		EntityIsVisibleNotify = 27390,
		// Token: 0x0400A84A RID: 43082
		SwitchCharacterStateNotify = 17711,
		// Token: 0x0400A84B RID: 43083
		PlayerRebackSceneNotify = 26270,
		// Token: 0x0400A84C RID: 43084
		LogicStateInitNotify = 16553,
		// Token: 0x0400A84D RID: 43085
		SwitchLogicStateNotify = 25764,
		// Token: 0x0400A84E RID: 43086
		AttributeChangedNotify = 26859,
		// Token: 0x0400A84F RID: 43087
		AnimationStateChangedNotify = 24252,
		// Token: 0x0400A850 RID: 43088
		AnimationStateInitNotify = 23601,
		// Token: 0x0400A851 RID: 43089
		ModifyBulletParamsNotify = 28690,
		// Token: 0x0400A852 RID: 43090
		DrownNotify = 16564,
		// Token: 0x0400A853 RID: 43091
		OrderApplyBuffNotify = 19792,
		// Token: 0x0400A854 RID: 43092
		OrderRemoveBuffNotify = 20935,
		// Token: 0x0400A855 RID: 43093
		ActivateBuffNotify = 29719,
		// Token: 0x0400A856 RID: 43094
		OrderRemoveBuffByTagsNotify = 23871,
		// Token: 0x0400A857 RID: 43095
		AiInformationNotify = 26510,
		// Token: 0x0400A858 RID: 43096
		BattleStateChangeNotify = 17671,
		// Token: 0x0400A859 RID: 43097
		AnimationGameplayTagNotify = 17808,
		// Token: 0x0400A85A RID: 43098
		BoneVisibleChangeNotify = 29713,
		// Token: 0x0400A85B RID: 43099
		AiBlackboardCdNotify = 26019,
		// Token: 0x0400A85C RID: 43100
		CaughtNotify = 29446,
		// Token: 0x0400A85D RID: 43101
		EntityStaticHookMoveNotify = 26154,
		// Token: 0x0400A85E RID: 43102
		ChangeStateNotify = 19168,
		// Token: 0x0400A85F RID: 43103
		ChangeStateConfirmNotify = 27547,
		// Token: 0x0400A860 RID: 43104
		BuffStackCountNotify = 19317,
		// Token: 0x0400A861 RID: 43105
		MontagePlayNotify = 19227,
		// Token: 0x0400A862 RID: 43106
		ANStartNotify = 16944,
		// Token: 0x0400A863 RID: 43107
		FsmResetNotify = 28366,
		// Token: 0x0400A864 RID: 43108
		DamageRecordNotify = 15583,
		// Token: 0x0400A865 RID: 43109
		AiHateNotify = 17752,
		// Token: 0x0400A866 RID: 43110
		FsmBlackboardNotify = 21151,
		// Token: 0x0400A867 RID: 43111
		CharacterBattleStateChangeNotify = 16199,
		// Token: 0x0400A868 RID: 43112
		ApplyBuffS2cRequestNotify = 17614,
		// Token: 0x0400A869 RID: 43113
		RemoveBuffS2cRequestNotify = 28392,
		// Token: 0x0400A86A RID: 43114
		ActorVisibleNotify = 29002,
		// Token: 0x0400A86B RID: 43115
		RecoverPropChangedNotify = 17789,
		// Token: 0x0400A86C RID: 43116
		RemoveBuffByIdS2cRequestNotify = 25284,
		// Token: 0x0400A86D RID: 43117
		ShieldUpdateNotify = 27866,
		// Token: 0x0400A86E RID: 43118
		PlayerBattleStateChangeNotify = 15313,
		// Token: 0x0400A86F RID: 43119
		FsmCustomBlackboardNotify = 18543,
		// Token: 0x0400A870 RID: 43120
		PassiveSkillAddNotify = 25025,
		// Token: 0x0400A871 RID: 43121
		PassiveSkillRemoveNotify = 21248,
		// Token: 0x0400A872 RID: 43122
		ExecuteQteNotify = 24112,
		// Token: 0x0400A873 RID: 43123
		ModifyEntityCampNotify = 21724,
		// Token: 0x0400A874 RID: 43124
		AddCombineEntitiesRelationNotify = 24720,
		// Token: 0x0400A875 RID: 43125
		RemoveCombineRelationNotify = 18044,
		// Token: 0x0400A876 RID: 43126
		TestDamageRecordNotify = 25211,
		// Token: 0x0400A877 RID: 43127
		BuffDurationNotify = 24676,
		// Token: 0x0400A878 RID: 43128
		EntityLivingStatusNotify = 24917,
		// Token: 0x0400A879 RID: 43129
		NewLinkNotify = 21875,
		// Token: 0x0400A87A RID: 43130
		ApplyBuffFailedNotify = 19969,
		// Token: 0x0400A87B RID: 43131
		PackAnimChangedNotify = 23124,
		// Token: 0x0400A87C RID: 43132
		VisionTriggerNotify = 24819,
		// Token: 0x0400A87D RID: 43133
		RemoveBuffByServerIdS2cRequestNotify = 15505,
		// Token: 0x0400A87E RID: 43134
		TransformBuffStackNotify = 21805,
		// Token: 0x0400A87F RID: 43135
		MotorSummonAndRideNotify = 21704,
		// Token: 0x0400A880 RID: 43136
		BulletPatternNotify = 24460,
		// Token: 0x0400A881 RID: 43137
		FsmMontageDurationNotify = 24356,
		// Token: 0x0400A882 RID: 43138
		CombatValNotify = 18757,
		// Token: 0x0400A883 RID: 43139
		CombatValDecayBeginNotify = 27363,
		// Token: 0x0400A884 RID: 43140
		SquadPropChangedNotify = 20340,
		// Token: 0x0400A885 RID: 43141
		DamageShowNotify = 16964,
		// Token: 0x0400A886 RID: 43142
		CombatDataMaxNotify = 27399
	}
}
