using System;

namespace Aki.Protocol
{
	// Token: 0x02000008 RID: 8
	public enum ENotifyMessageId
	{
		// Token: 0x04000F6B RID: 3947
		LoginNotify = 109,
		// Token: 0x04000F6C RID: 3948
		LogoutNotify,
		// Token: 0x04000F6D RID: 3949
		PushDataCompleteNotify = 113,
		// Token: 0x04000F6E RID: 3950
		SwitchNodeNotify = 115,
		// Token: 0x04000F6F RID: 3951
		AceAntiDataNotify = 28711,
		// Token: 0x04000F70 RID: 3952
		AchievementProgressNotify = 25834,
		// Token: 0x04000F71 RID: 3953
		AchievementListProgressNotify = 23250,
		// Token: 0x04000F72 RID: 3954
		AchievementGroupProgressNotify = 15821,
		// Token: 0x04000F73 RID: 3955
		ActionNotify = 24784,
		// Token: 0x04000F74 RID: 3956
		ActionErrorCodeNotify = 20519,
		// Token: 0x04000F75 RID: 3957
		OperationRestrictionNotify = 19069,
		// Token: 0x04000F76 RID: 3958
		ActivityUpdateNotify = 22413,
		// Token: 0x04000F77 RID: 3959
		ActivityDisableNotify = 18208,
		// Token: 0x04000F78 RID: 3960
		SignActivitySignStateNotify = 23272,
		// Token: 0x04000F79 RID: 3961
		SignActivityKeepTimeNotify = 20038,
		// Token: 0x04000F7A RID: 3962
		HarvestActivityPointNotify = 29118,
		// Token: 0x04000F7B RID: 3963
		HarvestActivityLevelNotify = 22544,
		// Token: 0x04000F7C RID: 3964
		HarvestActivityResultNotify = 28748,
		// Token: 0x04000F7D RID: 3965
		PhantomCollectUpdateNotify = 28121,
		// Token: 0x04000F7E RID: 3966
		AdventureUpdateNotify = 25180,
		// Token: 0x04000F7F RID: 3967
		SlientFirstAwardNotify = 18295,
		// Token: 0x04000F80 RID: 3968
		UpdateMonsterUnlockNotify = 22978,
		// Token: 0x04000F81 RID: 3969
		FollowDetectionTargetUpdateNotify = 26429,
		// Token: 0x04000F82 RID: 3970
		AddUnlockedGuideNotify = 23741,
		// Token: 0x04000F83 RID: 3971
		AddUnlockedDetectionTextNotify = 15632,
		// Token: 0x04000F84 RID: 3972
		AdviceSettingNotify = 18981,
		// Token: 0x04000F85 RID: 3973
		AdviceContentUpdateNotify = 26061,
		// Token: 0x04000F86 RID: 3974
		AdviceVoteUpdateNotify = 25803,
		// Token: 0x04000F87 RID: 3975
		AdviceUpdateNotify = 25178,
		// Token: 0x04000F88 RID: 3976
		AiInformationNotify = 27868,
		// Token: 0x04000F89 RID: 3977
		AiBlackboardCdNotify = 26627,
		// Token: 0x04000F8A RID: 3978
		AiHateNotify = 21698,
		// Token: 0x04000F8B RID: 3979
		AiControlSwitchNotify = 29617,
		// Token: 0x04000F8C RID: 3980
		PreAiControlSwitchNotify = 18803,
		// Token: 0x04000F8D RID: 3981
		BanChatNotify = 23311,
		// Token: 0x04000F8E RID: 3982
		PlayerRenameNotify = 17369,
		// Token: 0x04000F8F RID: 3983
		BasicInfoNotify = 15380,
		// Token: 0x04000F90 RID: 3984
		UnlockHeadPhotoNotify = 29887,
		// Token: 0x04000F91 RID: 3985
		UnlockHeadFrameNotify = 20396,
		// Token: 0x04000F92 RID: 3986
		HeadIdUpdateNotify = 17973,
		// Token: 0x04000F93 RID: 3987
		RoleShowListUpdateNotify = 27519,
		// Token: 0x04000F94 RID: 3988
		UnlockCardNotify = 19442,
		// Token: 0x04000F95 RID: 3989
		BattlePassPaidNotify = 17586,
		// Token: 0x04000F96 RID: 3990
		BattlePassExpUpdateNotify = 21684,
		// Token: 0x04000F97 RID: 3991
		BattlePassTaskUpdateNotify = 26276,
		// Token: 0x04000F98 RID: 3992
		BehaviorTreeInfoNotify = 27985,
		// Token: 0x04000F99 RID: 3993
		BehaviorTreeDeleteNotify = 27847,
		// Token: 0x04000F9A RID: 3994
		UpdateNodeProgressNotify = 27949,
		// Token: 0x04000F9B RID: 3995
		UpdateChildQuestNodeStatusNotify = 20398,
		// Token: 0x04000F9C RID: 3996
		UpdateNodeStatusNotify = 18896,
		// Token: 0x04000F9D RID: 3997
		BtSuspendNotify = 27231,
		// Token: 0x04000F9E RID: 3998
		OccupationInfoNotify = 27173,
		// Token: 0x04000F9F RID: 3999
		AddOccupationInfoNotify = 25073,
		// Token: 0x04000FA0 RID: 4000
		RemoveOccupationInfoNotify = 28337,
		// Token: 0x04000FA1 RID: 4001
		TimeOccupationNotify = 26393,
		// Token: 0x04000FA2 RID: 4002
		BtRollbackNotify = 29964,
		// Token: 0x04000FA3 RID: 4003
		BtRollbackStartNotify = 29608,
		// Token: 0x04000FA4 RID: 4004
		BtRollbackInfoNotify = 20660,
		// Token: 0x04000FA5 RID: 4005
		SneakNotify = 24240,
		// Token: 0x04000FA6 RID: 4006
		UpdateTimerInfoNotify = 28030,
		// Token: 0x04000FA7 RID: 4007
		BtVarUpdateNotify = 17997,
		// Token: 0x04000FA8 RID: 4008
		UpdateEnableSystemNotify = 25057,
		// Token: 0x04000FA9 RID: 4009
		WorldBlackboardNotify = 27748,
		// Token: 0x04000FAA RID: 4010
		EntityBlackboardNotify = 16442,
		// Token: 0x04000FAB RID: 4011
		RemovePlacementFromBoardNotify = 19759,
		// Token: 0x04000FAC RID: 4012
		AddPlacementNotify = 17686,
		// Token: 0x04000FAD RID: 4013
		PlacementInfoChangeNotify = 24946,
		// Token: 0x04000FAE RID: 4014
		PlaceItemOnBoardNotify = 22990,
		// Token: 0x04000FAF RID: 4015
		CommitBoardSuccessNotify = 17294,
		// Token: 0x04000FB0 RID: 4016
		MovePlacementNotify = 29257,
		// Token: 0x04000FB1 RID: 4017
		BoardGridDynamicConfigChangeNotify = 29632,
		// Token: 0x04000FB2 RID: 4018
		ApplyGameplayEffectNotify = 25830,
		// Token: 0x04000FB3 RID: 4019
		RemoveGameplayEffectNotify = 18345,
		// Token: 0x04000FB4 RID: 4020
		OrderApplyBuffNotify = 26471,
		// Token: 0x04000FB5 RID: 4021
		OrderRemoveBuffNotify = 17807,
		// Token: 0x04000FB6 RID: 4022
		ApplyBuffS2cRequestNotify = 18641,
		// Token: 0x04000FB7 RID: 4023
		RemoveBuffS2cRequestNotify = 20022,
		// Token: 0x04000FB8 RID: 4024
		RemoveBuffByIdS2cRequestNotify = 19482,
		// Token: 0x04000FB9 RID: 4025
		ActivateBuffNotify = 28221,
		// Token: 0x04000FBA RID: 4026
		OrderRemoveBuffByTagsNotify = 24520,
		// Token: 0x04000FBB RID: 4027
		BuffStackCountNotify = 29363,
		// Token: 0x04000FBC RID: 4028
		BuffItemNotify = 19044,
		// Token: 0x04000FBD RID: 4029
		BuffItemUpdateNotify = 28896,
		// Token: 0x04000FBE RID: 4030
		CalabashMsgNotify = 18974,
		// Token: 0x04000FBF RID: 4031
		CalabashExpAddNotify = 18431,
		// Token: 0x04000FC0 RID: 4032
		CalabashDevelopRewardUnlockNotify = 19666,
		// Token: 0x04000FC1 RID: 4033
		CalabashLevelsRewardNotify = 15335,
		// Token: 0x04000FC2 RID: 4034
		ChatNotify = 29969,
		// Token: 0x04000FC3 RID: 4035
		SysInfoNotify = 22193,
		// Token: 0x04000FC4 RID: 4036
		SysErrorNotify = 16045,
		// Token: 0x04000FC5 RID: 4037
		ConsoleNotify = 21407,
		// Token: 0x04000FC6 RID: 4038
		PrivateMessageNotify = 24284,
		// Token: 0x04000FC7 RID: 4039
		PrivateChatHistoryNotify = 24594,
		// Token: 0x04000FC8 RID: 4040
		ChatMutePlayerListNotify = 18916,
		// Token: 0x04000FC9 RID: 4041
		ChannelChatMessageNotify = 29952,
		// Token: 0x04000FCA RID: 4042
		ChannelChatHistoryNotify = 18271,
		// Token: 0x04000FCB RID: 4043
		CombatReceivePackNotify = 25706,
		// Token: 0x04000FCC RID: 4044
		ControlInfoNotify = 22077,
		// Token: 0x04000FCD RID: 4045
		AddForbidControlNotify = 29379,
		// Token: 0x04000FCE RID: 4046
		RemoveForbidControlNotify = 27763,
		// Token: 0x04000FCF RID: 4047
		CookingInfoUpdateNotify = 18067,
		// Token: 0x04000FD0 RID: 4048
		CookingFormulaUpdateNotify = 22353,
		// Token: 0x04000FD1 RID: 4049
		DailyAdventureTaskUpdateNotify = 19886,
		// Token: 0x04000FD2 RID: 4050
		DamageRecordNotify = 22979,
		// Token: 0x04000FD3 RID: 4051
		GmVoxelInfoNotify = 26875,
		// Token: 0x04000FD4 RID: 4052
		GmIsOverlapNotify = 25221,
		// Token: 0x04000FD5 RID: 4053
		DropInBagNotify = 21527,
		// Token: 0x04000FD6 RID: 4054
		ElevatorMoveNotify = 17500,
		// Token: 0x04000FD7 RID: 4055
		EnergyUpdateNotify = 19527,
		// Token: 0x04000FD8 RID: 4056
		ChangeStateNotify = 21371,
		// Token: 0x04000FD9 RID: 4057
		ChangeStateConfirmNotify = 20811,
		// Token: 0x04000FDA RID: 4058
		FsmResetNotify = 16867,
		// Token: 0x04000FDB RID: 4059
		FsmBlackboardNotify = 18761,
		// Token: 0x04000FDC RID: 4060
		FsmCustomBlackboardNotify = 19239,
		// Token: 0x04000FDD RID: 4061
		EntityAddNotify = 25185,
		// Token: 0x04000FDE RID: 4062
		EntityRemoveNotify = 17769,
		// Token: 0x04000FDF RID: 4063
		CommonOrganActionListNotify = 26803,
		// Token: 0x04000FE0 RID: 4064
		EntranceStateNotify = 25077,
		// Token: 0x04000FE1 RID: 4065
		LogicStateInitNotify = 24779,
		// Token: 0x04000FE2 RID: 4066
		SwitchLogicStateNotify = 19887,
		// Token: 0x04000FE3 RID: 4067
		AnimationGameplayTagNotify = 17636,
		// Token: 0x04000FE4 RID: 4068
		AnimalDieNotify = 28384,
		// Token: 0x04000FE5 RID: 4069
		EntityStateReadyNotify = 23517,
		// Token: 0x04000FE6 RID: 4070
		EntityAddDynamicInteractNotify = 26347,
		// Token: 0x04000FE7 RID: 4071
		EntityChangeDynamicInteractTextNotify = 23782,
		// Token: 0x04000FE8 RID: 4072
		EntityRemoveDynamicInteractNotify = 19212,
		// Token: 0x04000FE9 RID: 4073
		EntityInteractingNotify = 29944,
		// Token: 0x04000FEA RID: 4074
		EntityAddBubbleNotify = 21249,
		// Token: 0x04000FEB RID: 4075
		EntityRemoveBubbleNotify = 20077,
		// Token: 0x04000FEC RID: 4076
		BoneVisibleChangeNotify = 16295,
		// Token: 0x04000FED RID: 4077
		EntityEquipChangeNotify = 16817,
		// Token: 0x04000FEE RID: 4078
		EntityStaticHookMoveNotify = 26938,
		// Token: 0x04000FEF RID: 4079
		SilenceNpcNotify = 21690,
		// Token: 0x04000FF0 RID: 4080
		ExploreLevelNotify = 26692,
		// Token: 0x04000FF1 RID: 4081
		ExploreToolUpdateNotify = 27860,
		// Token: 0x04000FF2 RID: 4082
		ExploreToolAllNotify = 27129,
		// Token: 0x04000FF3 RID: 4083
		ExploreSkillRouletteUpdateNotify = 25292,
		// Token: 0x04000FF4 RID: 4084
		VisionExploreSkillNotify = 15314,
		// Token: 0x04000FF5 RID: 4085
		ExploreToolAuthorizationNotify = 18264,
		// Token: 0x04000FF6 RID: 4086
		RoleFavorListNotify = 19733,
		// Token: 0x04000FF7 RID: 4087
		RoleFavorActiveNotify = 26927,
		// Token: 0x04000FF8 RID: 4088
		RoleFavorLevelUpdateNotify = 23198,
		// Token: 0x04000FF9 RID: 4089
		RoleFavorNewCanUnLockNotify = 17127,
		// Token: 0x04000FFA RID: 4090
		RoleFavorExpTipsNotify = 28482,
		// Token: 0x04000FFB RID: 4091
		RoleFavorFinishConditionNotify = 29435,
		// Token: 0x04000FFC RID: 4092
		RoleFavorNewQuestUpdateNotify = 27058,
		// Token: 0x04000FFD RID: 4093
		RoleMotionNewCanUnLockNotify = 21957,
		// Token: 0x04000FFE RID: 4094
		RoleMotionActiveNotify = 22861,
		// Token: 0x04000FFF RID: 4095
		RoleMotionListNotify = 16513,
		// Token: 0x04001000 RID: 4096
		RoleMotionFinishConditionNotify = 20870,
		// Token: 0x04001001 RID: 4097
		SkillNotify = 20156,
		// Token: 0x04001002 RID: 4098
		UseSkillNotify = 20528,
		// Token: 0x04001003 RID: 4099
		EndSkillNotify = 25131,
		// Token: 0x04001004 RID: 4100
		HitNotify = 27776,
		// Token: 0x04001005 RID: 4101
		CaughtNotify = 17797,
		// Token: 0x04001006 RID: 4102
		CreateBulletNotify = 29868,
		// Token: 0x04001007 RID: 4103
		DestroyBulletNotify = 16776,
		// Token: 0x04001008 RID: 4104
		ModifyBulletParamsNotify = 17666,
		// Token: 0x04001009 RID: 4105
		DamageExecuteNotify = 28964,
		// Token: 0x0400100A RID: 4106
		PassiveSkillAddNotify = 22690,
		// Token: 0x0400100B RID: 4107
		PassiveSkillRemoveNotify = 22034,
		// Token: 0x0400100C RID: 4108
		SwitchBattleModeNotify = 24226,
		// Token: 0x0400100D RID: 4109
		BattleLogNotify = 29071,
		// Token: 0x0400100E RID: 4110
		EntityIsVisibleNotify = 17405,
		// Token: 0x0400100F RID: 4111
		ActorVisibleNotify = 23346,
		// Token: 0x04001010 RID: 4112
		SwitchCharacterStateNotify = 15678,
		// Token: 0x04001011 RID: 4113
		BattleStateChangeNotify = 22142,
		// Token: 0x04001012 RID: 4114
		MontagePlayNotify = 17788,
		// Token: 0x04001013 RID: 4115
		ANStartNotify = 24660,
		// Token: 0x04001014 RID: 4116
		CharacterBattleStateChangeNotify = 25768,
		// Token: 0x04001015 RID: 4117
		PlayerBattleStateChangeNotify = 25044,
		// Token: 0x04001016 RID: 4118
		ShieldUpdateNotify = 26592,
		// Token: 0x04001017 RID: 4119
		SwitchRoleNotify = 21436,
		// Token: 0x04001018 RID: 4120
		DieSwitchRoleNotify = 28430,
		// Token: 0x04001019 RID: 4121
		UpdateFormationNotify = 23626,
		// Token: 0x0400101A RID: 4122
		FormationAutoAddRoleNotify = 24318,
		// Token: 0x0400101B RID: 4123
		FormationUpdateNotify = 16510,
		// Token: 0x0400101C RID: 4124
		FlowStartNotify = 23786,
		// Token: 0x0400101D RID: 4125
		FlowEndNotify = 22237,
		// Token: 0x0400101E RID: 4126
		FlowShowEntityNotify = 21334,
		// Token: 0x0400101F RID: 4127
		ShowPasserByNpcNotify = 24738,
		// Token: 0x04001020 RID: 4128
		FlowServerSkipNotify = 21461,
		// Token: 0x04001021 RID: 4129
		ForgeItemInfoUpdateNotify = 18614,
		// Token: 0x04001022 RID: 4130
		PbFormationAutoAddRoleNotify = 17889,
		// Token: 0x04001023 RID: 4131
		PhantomFormationChangeNotify = 28651,
		// Token: 0x04001024 RID: 4132
		FriendAddedNotify = 28906,
		// Token: 0x04001025 RID: 4133
		FriendDeletedNotify = 25733,
		// Token: 0x04001026 RID: 4134
		FriendApplyReceivedNotify = 17851,
		// Token: 0x04001027 RID: 4135
		FriendApplyDeletedNotify = 25186,
		// Token: 0x04001028 RID: 4136
		FriendRecentlyTeamUpdateNotify = 17712,
		// Token: 0x04001029 RID: 4137
		FuncOpenNotify = 23390,
		// Token: 0x0400102A RID: 4138
		FuncOpenConfirmNotify = 24775,
		// Token: 0x0400102B RID: 4139
		FuncOpenUpdateNotify = 16322,
		// Token: 0x0400102C RID: 4140
		GachaResultNotify = 26700,
		// Token: 0x0400102D RID: 4141
		GatherTaskRecordNotify = 25315,
		// Token: 0x0400102E RID: 4142
		GatherClueInfoNotify = 22089,
		// Token: 0x0400102F RID: 4143
		SubmitItemInfoNotify = 22231,
		// Token: 0x04001030 RID: 4144
		GuideCondDoneNotify = 16087,
		// Token: 0x04001031 RID: 4145
		IllustratedUnlockNotify = 23144,
		// Token: 0x04001032 RID: 4146
		InfluenceInfoUpdateNotify = 23919,
		// Token: 0x04001033 RID: 4147
		InstDataNotify = 27555,
		// Token: 0x04001034 RID: 4148
		UpdateEnterInfoNotify = 26418,
		// Token: 0x04001035 RID: 4149
		InstPlayDataNotify = 15456,
		// Token: 0x04001036 RID: 4150
		InstSettleNotify = 18806,
		// Token: 0x04001037 RID: 4151
		InstResultNotify = 15136,
		// Token: 0x04001038 RID: 4152
		ExchangeRewardInfoNotify = 20442,
		// Token: 0x04001039 RID: 4153
		ExchangeSharedInfoNotify = 22397,
		// Token: 0x0400103A RID: 4154
		InstTimeoutNotify = 21516,
		// Token: 0x0400103B RID: 4155
		ItemRewardNotify = 21938,
		// Token: 0x0400103C RID: 4156
		ItemGiftUseNotify = 28048,
		// Token: 0x0400103D RID: 4157
		NormalItemUpdateNotify = 20661,
		// Token: 0x0400103E RID: 4158
		NormalItemRemoveNotify = 29178,
		// Token: 0x0400103F RID: 4159
		NormalItemAddNotify = 15755,
		// Token: 0x04001040 RID: 4160
		WeaponItemAddNotify = 24339,
		// Token: 0x04001041 RID: 4161
		WeaponItemRemoveNotify = 16873,
		// Token: 0x04001042 RID: 4162
		PhantomItemAddNotify = 17848,
		// Token: 0x04001043 RID: 4163
		PhantomItemRemoveNotify = 29775,
		// Token: 0x04001044 RID: 4164
		ItemFuncValueUpdateNotify = 23784,
		// Token: 0x04001045 RID: 4165
		ItemObtainNotify = 25181,
		// Token: 0x04001046 RID: 4166
		ItemPkgOpenNotify = 29428,
		// Token: 0x04001047 RID: 4167
		ValidTimeItemUpdateNotify = 19123,
		// Token: 0x04001048 RID: 4168
		ValidTimeItemRemoveNotify = 18573,
		// Token: 0x04001049 RID: 4169
		ValidTimeItemAddNotify = 21350,
		// Token: 0x0400104A RID: 4170
		EnterLevelPlayNotify = 28880,
		// Token: 0x0400104B RID: 4171
		LeaveLevelPlayNotify = 23737,
		// Token: 0x0400104C RID: 4172
		LevelPlayInfoNotify = 19789,
		// Token: 0x0400104D RID: 4173
		LevelPlayFirstNotify = 22014,
		// Token: 0x0400104E RID: 4174
		LevelPlayStateNotify = 17840,
		// Token: 0x0400104F RID: 4175
		LevelPlayOpenTimeNotify = 16016,
		// Token: 0x04001050 RID: 4176
		LevelPlayRewardNotify = 28898,
		// Token: 0x04001051 RID: 4177
		LevelPlayRewardCountResetNotify = 15831,
		// Token: 0x04001052 RID: 4178
		LivenessCountUpdateNotify = 20808,
		// Token: 0x04001053 RID: 4179
		LivenessUpdateNotify = 15921,
		// Token: 0x04001054 RID: 4180
		LivenessRefreshNotify = 27908,
		// Token: 0x04001055 RID: 4181
		EquipTakeOnNotify = 28760,
		// Token: 0x04001056 RID: 4182
		LordGymUnlockNotify = 19541,
		// Token: 0x04001057 RID: 4183
		LordGymLevelPlayResultNotify = 29109,
		// Token: 0x04001058 RID: 4184
		MailInfosNotify = 25021,
		// Token: 0x04001059 RID: 4185
		MailDeleteNotify = 16201,
		// Token: 0x0400105A RID: 4186
		MailAddNotify = 29640,
		// Token: 0x0400105B RID: 4187
		MapMarkShowIdInfoUpdateNotify = 20835,
		// Token: 0x0400105C RID: 4188
		MapUnlockFieldNotify = 18018,
		// Token: 0x0400105D RID: 4189
		MapCancelTraceNotify = 25230,
		// Token: 0x0400105E RID: 4190
		MapTraceNotify = 23529,
		// Token: 0x0400105F RID: 4191
		MapMarkInfoNotify = 16185,
		// Token: 0x04001060 RID: 4192
		UnlockMarkNotify = 26611,
		// Token: 0x04001061 RID: 4193
		RemoveMarkInfoNotify = 24260,
		// Token: 0x04001062 RID: 4194
		AddMarkInfoNotify = 28060,
		// Token: 0x04001063 RID: 4195
		StartMatchNotify = 23153,
		// Token: 0x04001064 RID: 4196
		CancelMatchNotify = 15420,
		// Token: 0x04001065 RID: 4197
		MatchFailNotify = 22367,
		// Token: 0x04001066 RID: 4198
		MatchTeamNotify = 15432,
		// Token: 0x04001067 RID: 4199
		MatchConfirmNotify = 17104,
		// Token: 0x04001068 RID: 4200
		MatchingNotify = 17009,
		// Token: 0x04001069 RID: 4201
		MatchTeamStateNotify = 15902,
		// Token: 0x0400106A RID: 4202
		MatchChangeRoleNotify = 15946,
		// Token: 0x0400106B RID: 4203
		MatchChangeReadyNotify = 15244,
		// Token: 0x0400106C RID: 4204
		LeaveMatchTeamNotify = 19226,
		// Token: 0x0400106D RID: 4205
		EnterMatchTeamNotify = 28195,
		// Token: 0x0400106E RID: 4206
		TeamMatchFlagNotify = 29741,
		// Token: 0x0400106F RID: 4207
		TeamMatchInviteNotify = 24891,
		// Token: 0x04001070 RID: 4208
		TeamMatchAcceptInviteNotify = 16329,
		// Token: 0x04001071 RID: 4209
		MatchChangePlayerUiStateNotify = 20049,
		// Token: 0x04001072 RID: 4210
		MessageDecodeFailNotify = 19803,
		// Token: 0x04001073 RID: 4211
		MonsterGachaDataChangeNotify = 15337,
		// Token: 0x04001074 RID: 4212
		MonthCardDailyRewardNotify = 20826,
		// Token: 0x04001075 RID: 4213
		MonthCardUseNotify = 29912,
		// Token: 0x04001076 RID: 4214
		NetTestDataNotify = 17969,
		// Token: 0x04001077 RID: 4215
		NewBieCourseRewardNotify = 21899,
		// Token: 0x04001078 RID: 4216
		ParkourChallengeOpenNotify = 25157,
		// Token: 0x04001079 RID: 4217
		ParkourChallengeEndNotify = 15236,
		// Token: 0x0400107A RID: 4218
		PartComponentInitNotify = 27435,
		// Token: 0x0400107B RID: 4219
		PartUpdateNotify = 23036,
		// Token: 0x0400107C RID: 4220
		PayItemSuccessNotify = 25980,
		// Token: 0x0400107D RID: 4221
		ResetSpecialBonusNotify = 29227,
		// Token: 0x0400107E RID: 4222
		PayGiftSuccessNotify = 23642,
		// Token: 0x0400107F RID: 4223
		PayShopInfoNotify = 26161,
		// Token: 0x04001080 RID: 4224
		PayShopUnlockNotify = 26780,
		// Token: 0x04001081 RID: 4225
		PayShopDirectBuyNotify = 27230,
		// Token: 0x04001082 RID: 4226
		PayShopConditionFinishNotify = 16372,
		// Token: 0x04001083 RID: 4227
		PhantomEquipInfoNotify = 15372,
		// Token: 0x04001084 RID: 4228
		PhantomItemUpdateNotify = 28162,
		// Token: 0x04001085 RID: 4229
		RolePhantomPropUpdateNotify = 23392,
		// Token: 0x04001086 RID: 4230
		PhantomUpdateNotify = 28427,
		// Token: 0x04001087 RID: 4231
		PhantomSkinAddNotify = 24383,
		// Token: 0x04001088 RID: 4232
		PhantomUnlockNotify = 18900,
		// Token: 0x04001089 RID: 4233
		PlayerAttrNotify = 20778,
		// Token: 0x0400108A RID: 4234
		PassiveSkillNotify = 26386,
		// Token: 0x0400108B RID: 4235
		PlayerVarNotify = 23542,
		// Token: 0x0400108C RID: 4236
		PressNotify = 28317,
		// Token: 0x0400108D RID: 4237
		PressGameNotify = 17678,
		// Token: 0x0400108E RID: 4238
		FormationAttrNotify = 26658,
		// Token: 0x0400108F RID: 4239
		RecoverPropChangedNotify = 29454,
		// Token: 0x04001090 RID: 4240
		JSPatchNotify = 25006,
		// Token: 0x04001091 RID: 4241
		QuestListNotify = 23759,
		// Token: 0x04001092 RID: 4242
		TraceQuestNotify = 26198,
		// Token: 0x04001093 RID: 4243
		QuestReadyListNotify = 24620,
		// Token: 0x04001094 RID: 4244
		QuestShowListNotify = 17562,
		// Token: 0x04001095 RID: 4245
		QuestStateUpdateNotify = 28378,
		// Token: 0x04001096 RID: 4246
		QuestFinishListNotify = 17000,
		// Token: 0x04001097 RID: 4247
		DailyQuestUnlockAreaNotify = 27366,
		// Token: 0x04001098 RID: 4248
		DailyQuestStateNotify = 22047,
		// Token: 0x04001099 RID: 4249
		DailyQuestCancelNotify = 20367,
		// Token: 0x0400109A RID: 4250
		RoleQuestStateNotify = 22674,
		// Token: 0x0400109B RID: 4251
		RoleQuestNewUnlockNotify = 26215,
		// Token: 0x0400109C RID: 4252
		DestroyQuestsNotify = 17308,
		// Token: 0x0400109D RID: 4253
		AutoQuestNotify = 16961,
		// Token: 0x0400109E RID: 4254
		QuestRedDotNotify = 23522,
		// Token: 0x0400109F RID: 4255
		ReceiveRechallengeNotify = 17918,
		// Token: 0x040010A0 RID: 4256
		InviteRechallengeNotify = 19929,
		// Token: 0x040010A1 RID: 4257
		ReceiveRechallengePlayerIdsNotify = 15842,
		// Token: 0x040010A2 RID: 4258
		PlayerDeadNotify = 27670,
		// Token: 0x040010A3 RID: 4259
		PlayerReviveNotify = 27617,
		// Token: 0x040010A4 RID: 4260
		RoguelikeCurrencyNotify = 17560,
		// Token: 0x040010A5 RID: 4261
		RoguelikeCurrencyUpdateNotify = 29332,
		// Token: 0x040010A6 RID: 4262
		RoguelikeInfoNotify = 16321,
		// Token: 0x040010A7 RID: 4263
		RoguelikeChooseDataNotify = 24553,
		// Token: 0x040010A8 RID: 4264
		RoguelikeEventGainNotify = 24233,
		// Token: 0x040010A9 RID: 4265
		RoguelikeResultNotify = 27722,
		// Token: 0x040010AA RID: 4266
		RoguelikeSubLevelNotify = 24792,
		// Token: 0x040010AB RID: 4267
		RoguelikeRoomInfoNotify = 20950,
		// Token: 0x040010AC RID: 4268
		RoguelikeTalentUnlockNotify = 25010,
		// Token: 0x040010AD RID: 4269
		PbGetRoleListNotify = 18368,
		// Token: 0x040010AE RID: 4270
		PbRoleActiveNotify = 27050,
		// Token: 0x040010AF RID: 4271
		PbRolePropsNotify = 28533,
		// Token: 0x040010B0 RID: 4272
		PbRoleExpNotify = 27992,
		// Token: 0x040010B1 RID: 4273
		PbRoleResonLockFinishNotify = 22856,
		// Token: 0x040010B2 RID: 4274
		PbRoleScenePropsNotify = 28749,
		// Token: 0x040010B3 RID: 4275
		PbRoleSkillLevelNotify = 17396,
		// Token: 0x040010B4 RID: 4276
		RoleChangeNameNotify = 26144,
		// Token: 0x040010B5 RID: 4277
		RoleTrialOpenNotify = 16081,
		// Token: 0x040010B6 RID: 4278
		RoleTrialCloseNotify = 29420,
		// Token: 0x040010B7 RID: 4279
		RoleSkillNodeNotify = 18129,
		// Token: 0x040010B8 RID: 4280
		RoleChangeNotify = 28197,
		// Token: 0x040010B9 RID: 4281
		RoleChangeUnlockNotify = 26358,
		// Token: 0x040010BA RID: 4282
		RoleTrialSettleNotify = 25527,
		// Token: 0x040010BB RID: 4283
		EntityLivingStatusNotify = 23945,
		// Token: 0x040010BC RID: 4284
		UpdatePlayerAllFightRoleNotify = 21051,
		// Token: 0x040010BD RID: 4285
		UpdatePlayersFightRolesInfoNotify = 18899,
		// Token: 0x040010BE RID: 4286
		UpdatePlayerSingleFightRoleNotify = 18580,
		// Token: 0x040010BF RID: 4287
		ChangePlayerFightRoleNotify = 27633,
		// Token: 0x040010C0 RID: 4288
		SceneAreaStateNotify = 27914,
		// Token: 0x040010C1 RID: 4289
		HostTeleportUnlockNotify = 22223,
		// Token: 0x040010C2 RID: 4290
		HostFogIdUnlockNotify = 28107,
		// Token: 0x040010C3 RID: 4291
		SyncSceneTimeNotify = 26685,
		// Token: 0x040010C4 RID: 4292
		ChangeSceneModeNotify = 29411,
		// Token: 0x040010C5 RID: 4293
		ScenePlayerOfflineNotify = 20659,
		// Token: 0x040010C6 RID: 4294
		JoinSceneNotify = 18559,
		// Token: 0x040010C7 RID: 4295
		OtherJoinSceneNotify = 22868,
		// Token: 0x040010C8 RID: 4296
		LeaveSceneNotify = 28361,
		// Token: 0x040010C9 RID: 4297
		MovePackageNotify = 17992,
		// Token: 0x040010CA RID: 4298
		UDPMovePackageNotify = 25437,
		// Token: 0x040010CB RID: 4299
		MoveSceneItemNotify = 24344,
		// Token: 0x040010CC RID: 4300
		ChangeMonsterRoleNotify = 28069,
		// Token: 0x040010CD RID: 4301
		EntityOnLandedNotify = 25577,
		// Token: 0x040010CE RID: 4302
		AttributeInitNotify = 19205,
		// Token: 0x040010CF RID: 4303
		AttributeChangedNotify = 27832,
		// Token: 0x040010D0 RID: 4304
		MonsterLevelNotify = 24635,
		// Token: 0x040010D1 RID: 4305
		MonsterLevelArrayNotify = 27665,
		// Token: 0x040010D2 RID: 4306
		MonsterAttributeNotify = 26755,
		// Token: 0x040010D3 RID: 4307
		MonsterAttributeArrayNotify = 27454,
		// Token: 0x040010D4 RID: 4308
		AnimationStateInitNotify = 27651,
		// Token: 0x040010D5 RID: 4309
		AnimationStateChangedNotify = 15580,
		// Token: 0x040010D6 RID: 4310
		GameplayTagInitNotify = 17063,
		// Token: 0x040010D7 RID: 4311
		GameplayTagChangedNotify = 28388,
		// Token: 0x040010D8 RID: 4312
		EntityCommonTagNotify = 19566,
		// Token: 0x040010D9 RID: 4313
		ChangeControlRoleNotify = 26484,
		// Token: 0x040010DA RID: 4314
		HardnessModeChangedNotify = 24870,
		// Token: 0x040010DB RID: 4315
		SummonEntityNotify = 15942,
		// Token: 0x040010DC RID: 4316
		VisionSkillCallNotify = 27773,
		// Token: 0x040010DD RID: 4317
		InstanceTimerNotify = 28918,
		// Token: 0x040010DE RID: 4318
		UpdateInstanceTimerNotify = 20590,
		// Token: 0x040010DF RID: 4319
		RemoveInstanceTimerNotify = 26626,
		// Token: 0x040010E0 RID: 4320
		UpdateInstanceOwnerInfoNotify = 16427,
		// Token: 0x040010E1 RID: 4321
		UpdateOwnerMingSuGenNotify = 27693,
		// Token: 0x040010E2 RID: 4322
		AddSysBuffNotify = 21803,
		// Token: 0x040010E3 RID: 4323
		UpdateSysBuffNotify = 29655,
		// Token: 0x040010E4 RID: 4324
		RemoveSysBuffNotify = 24831,
		// Token: 0x040010E5 RID: 4325
		SceneDateNotify = 29275,
		// Token: 0x040010E6 RID: 4326
		HoldWeaponNotify = 29731,
		// Token: 0x040010E7 RID: 4327
		EnterAoiNotify = 20418,
		// Token: 0x040010E8 RID: 4328
		AddEntityAoiNotify = 21738,
		// Token: 0x040010E9 RID: 4329
		LeaveAoiNotify = 24943,
		// Token: 0x040010EA RID: 4330
		RemoveEntityAoiNotify = 22294,
		// Token: 0x040010EB RID: 4331
		PlayerAoiRangeNotify = 17657,
		// Token: 0x040010EC RID: 4332
		SceneGamePlayInfoNotify = 18306,
		// Token: 0x040010ED RID: 4333
		SceneGamePlayFirstNotify = 28356,
		// Token: 0x040010EE RID: 4334
		SceneGamePlayStatusNotify = 20225,
		// Token: 0x040010EF RID: 4335
		SceneGamePlayScopeNotify = 25818,
		// Token: 0x040010F0 RID: 4336
		SceneGamePlayOpenTimeNotify = 21473,
		// Token: 0x040010F1 RID: 4337
		ResetLocationForZRangeNotify = 26153,
		// Token: 0x040010F2 RID: 4338
		BeControlledPosInFoundationNotify = 23053,
		// Token: 0x040010F3 RID: 4339
		BeControlledNotify = 28228,
		// Token: 0x040010F4 RID: 4340
		BeControlledShowNotify = 16761,
		// Token: 0x040010F5 RID: 4341
		RelationIdNotify = 17936,
		// Token: 0x040010F6 RID: 4342
		EntityPosResetNotify = 25086,
		// Token: 0x040010F7 RID: 4343
		WeatherNotify = 18291,
		// Token: 0x040010F8 RID: 4344
		PlayerRebackSceneNotify = 25253,
		// Token: 0x040010F9 RID: 4345
		DrownNotify = 26523,
		// Token: 0x040010FA RID: 4346
		EnableNearbyTrackingNotify = 27628,
		// Token: 0x040010FB RID: 4347
		SceneSubLevelsChangedNotify = 23168,
		// Token: 0x040010FC RID: 4348
		SceneSubLevelsNotify = 22380,
		// Token: 0x040010FD RID: 4349
		SceneLoadingTimeOutNotify = 27994,
		// Token: 0x040010FE RID: 4350
		SceneLoadingFinishNotify = 22001,
		// Token: 0x040010FF RID: 4351
		ResetPointEntityNotify = 16945,
		// Token: 0x04001100 RID: 4352
		SceneTestNotify = 22242,
		// Token: 0x04001101 RID: 4353
		SceneChangeDataLayerNotify = 16684,
		// Token: 0x04001102 RID: 4354
		EntityLoadCompleteNotify = 29145,
		// Token: 0x04001103 RID: 4355
		MaterialNotify = 29636,
		// Token: 0x04001104 RID: 4356
		SceneStepGroupInfoNotify = 24473,
		// Token: 0x04001105 RID: 4357
		SceneStepInfoNotify = 23865,
		// Token: 0x04001106 RID: 4358
		ThrowDamageNotify = 29882,
		// Token: 0x04001107 RID: 4359
		ThrowDamageRecoveryNotify = 26175,
		// Token: 0x04001108 RID: 4360
		SettingNotify = 22267,
		// Token: 0x04001109 RID: 4361
		ShopInfoNotify = 19667,
		// Token: 0x0400110A RID: 4362
		ShopUnlockNotify = 21280,
		// Token: 0x0400110B RID: 4363
		SneakGameStateNotify = 15930,
		// Token: 0x0400110C RID: 4364
		SpecialItemNotify = 26157,
		// Token: 0x0400110D RID: 4365
		SynthesisInfoUpdateNotify = 19611,
		// Token: 0x0400110E RID: 4366
		SynthesisLevelUpdateNotify = 17684,
		// Token: 0x0400110F RID: 4367
		TeleportUpdateNotify = 23109,
		// Token: 0x04001110 RID: 4368
		TeleportNotify = 18633,
		// Token: 0x04001111 RID: 4369
		FallFinishNotify = 24409,
		// Token: 0x04001112 RID: 4370
		TemporaryTeleportAllInfoNotify = 23653,
		// Token: 0x04001113 RID: 4371
		AddTemporaryTeleportInfoNotify = 15428,
		// Token: 0x04001114 RID: 4372
		RemoveTemporaryTeleportNotify = 19531,
		// Token: 0x04001115 RID: 4373
		TemporaryTeleportChangeNotify = 19202,
		// Token: 0x04001116 RID: 4374
		ThirdPartySharedNotify = 23622,
		// Token: 0x04001117 RID: 4375
		TimeCheckNotify = 20474,
		// Token: 0x04001118 RID: 4376
		TowerEndNotify = 15343,
		// Token: 0x04001119 RID: 4377
		TowerFloorUpdateNotify = 20319,
		// Token: 0x0400111A RID: 4378
		TowerDifficultyUpdateNotify = 17198,
		// Token: 0x0400111B RID: 4379
		TowerInfoUpdateNotify = 23114,
		// Token: 0x0400111C RID: 4380
		TutorialUnlockNotify = 28355,
		// Token: 0x0400111D RID: 4381
		VisionSkillChangeNotify = 15184,
		// Token: 0x0400111E RID: 4382
		WeaponAllInfoNotify = 19780,
		// Token: 0x0400111F RID: 4383
		WeaponAddNotify = 18560,
		// Token: 0x04001120 RID: 4384
		WeaponRemoveNotify = 25207,
		// Token: 0x04001121 RID: 4385
		ApplyJoinWorldNotify = 15258,
		// Token: 0x04001122 RID: 4386
		AgreeJoinResultNotify = 20337,
		// Token: 0x04001123 RID: 4387
		ApplyerEnterSceneNotify = 20705,
		// Token: 0x04001124 RID: 4388
		AllApplyJoinNotify = 28635,
		// Token: 0x04001125 RID: 4389
		WorldTeamPlayerInfoChangeNotify = 24636,
		// Token: 0x04001126 RID: 4390
		JoinWorldTeamNotify = 24920,
		// Token: 0x04001127 RID: 4391
		PlayerLeaveWorldTeamNotify = 15054,
		// Token: 0x04001128 RID: 4392
		PlayerEnterWorldTeamNotify = 19236,
		// Token: 0x04001129 RID: 4393
		RobotDestinationNotify = 20116,
		// Token: 0x0400112A RID: 4394
		UpdateWorldTeamPlayerFightInfoNotify = 18073,
		// Token: 0x0400112B RID: 4395
		PlayerNetStateNotify = 20034,
		// Token: 0x0400112C RID: 4396
		PlayerTeleportStateNotify = 27500,
		// Token: 0x0400112D RID: 4397
		SignatureUpdateNotify = 20375,
		// Token: 0x0400112E RID: 4398
		EntityAttachChangeNotify = 15996,
		// Token: 0x0400112F RID: 4399
		BattleScoreNotify = 17365,
		// Token: 0x04001130 RID: 4400
		LongShanStageUpdateNotify = 24809,
		// Token: 0x04001131 RID: 4401
		MultiMapInfoNotify = 29652,
		// Token: 0x04001132 RID: 4402
		UnlockMapBlockNotify = 15090,
		// Token: 0x04001133 RID: 4403
		UnlockMultiMapNotify = 21647,
		// Token: 0x04001134 RID: 4404
		EntityAccessRangeNotify = 24009,
		// Token: 0x04001135 RID: 4405
		PlayerAccessRangeNotify = 19051,
		// Token: 0x04001136 RID: 4406
		TrampleGearTransitionNotify = 26985,
		// Token: 0x04001137 RID: 4407
		PlayerSkillInfoPbNotify = 20458,
		// Token: 0x04001138 RID: 4408
		SwitchSceneGroupNotify = 23134,
		// Token: 0x04001139 RID: 4409
		UpdateSceneGroupDataNotify = 17286,
		// Token: 0x0400113A RID: 4410
		AfterJoinSceneNotify = 22156,
		// Token: 0x0400113B RID: 4411
		AudioStateUpdateNotify = 16806,
		// Token: 0x0400113C RID: 4412
		BossRushResultNotify = 28412,
		// Token: 0x0400113D RID: 4413
		BossRushLevelInfoNotify = 24337,
		// Token: 0x0400113E RID: 4414
		TrackMoonConditionNotify = 29252,
		// Token: 0x0400113F RID: 4415
		EntityVarUpdateNotify = 18216,
		// Token: 0x04001140 RID: 4416
		RoguelikeGainDataUpdateNotify = 26618,
		// Token: 0x04001141 RID: 4417
		OutputDebugInfoNotify = 19792,
		// Token: 0x04001142 RID: 4418
		PhotoMemoryUpdateNotify = 28595,
		// Token: 0x04001143 RID: 4419
		PhotoMemoryCollectNotify = 16791,
		// Token: 0x04001144 RID: 4420
		ChangeSceneModeEndNotify = 27746,
		// Token: 0x04001145 RID: 4421
		SceneItemSetPosSenderNotify = 16894,
		// Token: 0x04001146 RID: 4422
		TrackMoonTargetUpdateNotify = 22048,
		// Token: 0x04001147 RID: 4423
		PlayerLivingStatesNotify = 22492,
		// Token: 0x04001148 RID: 4424
		TrackMoonIllustratedNotify = 18595,
		// Token: 0x04001149 RID: 4425
		BossRushFailResultNotify = 28650,
		// Token: 0x0400114A RID: 4426
		TowerDefenceInfoUpdateNotify = 18554,
		// Token: 0x0400114B RID: 4427
		TowerDefenceInstanceInfoUpdateNotify = 27413,
		// Token: 0x0400114C RID: 4428
		TowerDefencePhantomInfoUpdateNotify = 24798,
		// Token: 0x0400114D RID: 4429
		TowerDefenceEndNotify = 27964,
		// Token: 0x0400114E RID: 4430
		ConnectorConnectEntityNotify = 21398,
		// Token: 0x0400114F RID: 4431
		NameModifyNotify = 24589,
		// Token: 0x04001150 RID: 4432
		FirecrackerEntityCreatedNotify = 21194,
		// Token: 0x04001151 RID: 4433
		PlayerFollowerNotify = 27918,
		// Token: 0x04001152 RID: 4434
		GameplayCueNotify = 29715,
		// Token: 0x04001153 RID: 4435
		TowerDefenceEnterInstNotify = 21747,
		// Token: 0x04001154 RID: 4436
		ServerCommandNotify = 21667,
		// Token: 0x04001155 RID: 4437
		RoguelikeRoleRoomNotify = 15652,
		// Token: 0x04001156 RID: 4438
		SetNpcPerformStateNotify = 20027,
		// Token: 0x04001157 RID: 4439
		BattleAntiCheatingLogNotify = 24393,
		// Token: 0x04001158 RID: 4440
		TimeResetNotify = 21493,
		// Token: 0x04001159 RID: 4441
		ActionOpenSystemBoardNotify = 28172,
		// Token: 0x0400115A RID: 4442
		SceneItemMoveTargetNotify = 15478,
		// Token: 0x0400115B RID: 4443
		TrackMoonRolePropChangeNotify = 24089,
		// Token: 0x0400115C RID: 4444
		CorniceChallengeEndNotify = 16495,
		// Token: 0x0400115D RID: 4445
		QuestChangeTraceNotify = 16354,
		// Token: 0x0400115E RID: 4446
		TrackMoonTokenCoinNotify = 20701,
		// Token: 0x0400115F RID: 4447
		RiskHarvestEndNotify = 25092,
		// Token: 0x04001160 RID: 4448
		RiskHarvestInstUpdateNotify = 20169,
		// Token: 0x04001161 RID: 4449
		RiskHarvestArtifactNotify = 23260,
		// Token: 0x04001162 RID: 4450
		RiskHarvestBuffUpdateNotify = 17563,
		// Token: 0x04001163 RID: 4451
		RiskHarvestBuffUnlockNotify = 18477,
		// Token: 0x04001164 RID: 4452
		BtRangeFailWarningNotify = 15770,
		// Token: 0x04001165 RID: 4453
		BtCancelRangeFailWarningNotify = 19492,
		// Token: 0x04001166 RID: 4454
		RiskHarvestActivityUpdateNotify = 26346,
		// Token: 0x04001167 RID: 4455
		BlackCoastThemeStageUpdateNotify = 26169,
		// Token: 0x04001168 RID: 4456
		PlayerPsnSessionNotify = 16152,
		// Token: 0x04001169 RID: 4457
		PortalReplaceNotify = 18706,
		// Token: 0x0400116A RID: 4458
		FightDataCheckNotify = 17021,
		// Token: 0x0400116B RID: 4459
		TowerDefenceRoleReviveNotify = 16084,
		// Token: 0x0400116C RID: 4460
		TowerDefencePlayerReviveNotify = 18289,
		// Token: 0x0400116D RID: 4461
		LevelPlayerRewardHintNotify = 29490,
		// Token: 0x0400116E RID: 4462
		AppGradeNotify = 15895,
		// Token: 0x0400116F RID: 4463
		LinkingStateNotify = 28844,
		// Token: 0x04001170 RID: 4464
		LinkExitNotify = 26223,
		// Token: 0x04001171 RID: 4465
		RogueWhiteCatDataUpdateNotify = 26688,
		// Token: 0x04001172 RID: 4466
		UpdateEnableFunctionNotify = 24510,
		// Token: 0x04001173 RID: 4467
		InputSettingUpdateNotify = 18450,
		// Token: 0x04001174 RID: 4468
		MapCustomMarkUpdateNotify = 20105,
		// Token: 0x04001175 RID: 4469
		PayGiftConditionFinishNotify = 22528,
		// Token: 0x04001176 RID: 4470
		GetDebugInfoNotify = 15849,
		// Token: 0x04001177 RID: 4471
		TeleportDungeonActionNotify = 18177,
		// Token: 0x04001178 RID: 4472
		SceneItemAttributeChangeNotify = 18254,
		// Token: 0x04001179 RID: 4473
		AchievementCountChangeNotify = 28476,
		// Token: 0x0400117A RID: 4474
		ContextIdNotify = 16119,
		// Token: 0x0400117B RID: 4475
		ExecuteQteNotify = 20131,
		// Token: 0x0400117C RID: 4476
		SyncPlayerLocationNotify = 16455,
		// Token: 0x0400117D RID: 4477
		MailBindInfoNotify = 16566,
		// Token: 0x0400117E RID: 4478
		PrivateChatClearNotify = 21637,
		// Token: 0x0400117F RID: 4479
		ScratchCardCountInfoNotify = 29035,
		// Token: 0x04001180 RID: 4480
		WeaponSkinAddNotify = 21360,
		// Token: 0x04001181 RID: 4481
		WeaponSkinUnLoadNotify = 20040,
		// Token: 0x04001182 RID: 4482
		ItemRelateFoundationNotify = 20976,
		// Token: 0x04001183 RID: 4483
		VehicleUpdateNotify = 23879,
		// Token: 0x04001184 RID: 4484
		EntityPreloadNotify = 24436,
		// Token: 0x04001185 RID: 4485
		QuestRollBackEndNotify = 15053,
		// Token: 0x04001186 RID: 4486
		TreasureBoxSlotAllInfoNotify = 20020,
		// Token: 0x04001187 RID: 4487
		RogueWhiteCatLimitedUpdateNotify = 17645,
		// Token: 0x04001188 RID: 4488
		EntityEquipSkinChangeNotify = 23591,
		// Token: 0x04001189 RID: 4489
		QuestGiveUpNotify = 29826,
		// Token: 0x0400118A RID: 4490
		BattleScoreEnableNotify = 20406,
		// Token: 0x0400118B RID: 4491
		ModifyEntityCampNotify = 28258,
		// Token: 0x0400118C RID: 4492
		AlertAreaNotify = 26602,
		// Token: 0x0400118D RID: 4493
		AddCombineEntitiesRelationNotify = 25278,
		// Token: 0x0400118E RID: 4494
		RemoveCombineRelationNotify = 17117,
		// Token: 0x0400118F RID: 4495
		RogueLevelPlayNotify = 21815,
		// Token: 0x04001190 RID: 4496
		ActionRelatedEntityInfoNotify = 16914,
		// Token: 0x04001191 RID: 4497
		GachaNewNotify = 18079,
		// Token: 0x04001192 RID: 4498
		TestDamageRecordNotify = 22542,
		// Token: 0x04001193 RID: 4499
		RogueBossLinkSettleNotify = 21333,
		// Token: 0x04001194 RID: 4500
		RogueBlackFlowerNotify = 18190,
		// Token: 0x04001195 RID: 4501
		CombatDataMaxNotify = 28947,
		// Token: 0x04001196 RID: 4502
		MowTowerFirstScoreNotify = 22248,
		// Token: 0x04001197 RID: 4503
		MowTowerResultNotify = 26088,
		// Token: 0x04001198 RID: 4504
		RoleSkinUpdateNotify = 18921,
		// Token: 0x04001199 RID: 4505
		RoleSkinAddNotify = 23089,
		// Token: 0x0400119A RID: 4506
		SceneItemAiEnableNotify = 26846,
		// Token: 0x0400119B RID: 4507
		SceneItemAiDisableNotify = 29959,
		// Token: 0x0400119C RID: 4508
		TeamMatchInviteRetToHostNotify = 25396,
		// Token: 0x0400119D RID: 4509
		SceneItemAiPatrolPointNotify = 15402,
		// Token: 0x0400119E RID: 4510
		SceneItemBlackboardNotify = 28473,
		// Token: 0x0400119F RID: 4511
		TeleportDungeonForbidNotify = 17358,
		// Token: 0x040011A0 RID: 4512
		EntityGravityUpdateNotify = 19228,
		// Token: 0x040011A1 RID: 4513
		MowTowerLevelsInfoUpdateNotify = 15746,
		// Token: 0x040011A2 RID: 4514
		VehiclePassengerUpdateNotify = 21681,
		// Token: 0x040011A3 RID: 4515
		AnimalCollectStateNotify = 20565,
		// Token: 0x040011A4 RID: 4516
		TurntableTaskUpdateNotify = 26417,
		// Token: 0x040011A5 RID: 4517
		MapTravelInfoUpdateNotify = 17425,
		// Token: 0x040011A6 RID: 4518
		ExploreProgressRewardIdsNotify = 18889,
		// Token: 0x040011A7 RID: 4519
		BoardCanMovePlacementNotify = 26498,
		// Token: 0x040011A8 RID: 4520
		FarmGoldResultNotify = 21768,
		// Token: 0x040011A9 RID: 4521
		FarmGoldLevelNotify = 26870,
		// Token: 0x040011AA RID: 4522
		TeamTeleportStartNotify = 27952,
		// Token: 0x040011AB RID: 4523
		SplineMoveNotify = 19766,
		// Token: 0x040011AC RID: 4524
		TeleportVehicleNotify = 22384,
		// Token: 0x040011AD RID: 4525
		PlayerHeadAddNotify = 24903,
		// Token: 0x040011AE RID: 4526
		VehicleUpdateEntityNotify = 25063,
		// Token: 0x040011AF RID: 4527
		DetectionPreOpenNotify = 19627,
		// Token: 0x040011B0 RID: 4528
		FishingInfoUpdateNotify = 22579,
		// Token: 0x040011B1 RID: 4529
		FishingShipInfoUpdateNotify = 22031,
		// Token: 0x040011B2 RID: 4530
		FishingTechInfoUpdateNotify = 17814,
		// Token: 0x040011B3 RID: 4531
		FishingIllustratedInfoUpdateNotify = 18459,
		// Token: 0x040011B4 RID: 4532
		FishingIllustratedRewardInfoUpdateNotify = 27592,
		// Token: 0x040011B5 RID: 4533
		FishingSceneFishCageInfoUpdateNotify = 18416,
		// Token: 0x040011B6 RID: 4534
		SceneFishPointInfoUpdateNotify = 26043,
		// Token: 0x040011B7 RID: 4535
		FishingShipForceBackNotify = 28191,
		// Token: 0x040011B8 RID: 4536
		FishingItemAddNotify = 27090,
		// Token: 0x040011B9 RID: 4537
		FishingNoticeUpdateNotify = 25001,
		// Token: 0x040011BA RID: 4538
		HookLockPointInfoNotify = 24148,
		// Token: 0x040011BB RID: 4539
		HandInInfoUpdateNotify = 18524,
		// Token: 0x040011BC RID: 4540
		RoleSkinTrialSettleNotify = 20469,
		// Token: 0x040011BD RID: 4541
		BuffDurationNotify = 16974,
		// Token: 0x040011BE RID: 4542
		TeleportFlowNotify = 17285,
		// Token: 0x040011BF RID: 4543
		FishingEntrustUpdateNotify = 23340,
		// Token: 0x040011C0 RID: 4544
		FishingPortUnlockNotify = 29311,
		// Token: 0x040011C1 RID: 4545
		RogueWeeklyRoomInfoNotify = 21270,
		// Token: 0x040011C2 RID: 4546
		RogueWeeklySubLevelNotify = 29246,
		// Token: 0x040011C3 RID: 4547
		RogueWeeklyResultNotify = 23363,
		// Token: 0x040011C4 RID: 4548
		SlashAndTowerResultNotify = 15320,
		// Token: 0x040011C5 RID: 4549
		SlashAndTowerLevelPlayNotify = 17693,
		// Token: 0x040011C6 RID: 4550
		SceneTempFishPointInfoUpdateNotify = 16713,
		// Token: 0x040011C7 RID: 4551
		BossRushTaskUpdateNotify = 23983,
		// Token: 0x040011C8 RID: 4552
		CharacterLookAtNotify = 25173,
		// Token: 0x040011C9 RID: 4553
		FishingActivityLimitTaskNotify = 21833,
		// Token: 0x040011CA RID: 4554
		FishingActivityMileStoneNotify = 16931,
		// Token: 0x040011CB RID: 4555
		FishingBoatDieNotify = 26943,
		// Token: 0x040011CC RID: 4556
		TeamParkourTaskNotify = 19512,
		// Token: 0x040011CD RID: 4557
		TeamParkourSettleNotify = 25201,
		// Token: 0x040011CE RID: 4558
		RogueWeeklyInstInfoNotify = 26665,
		// Token: 0x040011CF RID: 4559
		ThroughTrainForceRemindNotify = 19334,
		// Token: 0x040011D0 RID: 4560
		FishingActivityMilestoneItemNumNotify = 23932,
		// Token: 0x040011D1 RID: 4561
		AddHackingEntityNotify = 17276,
		// Token: 0x040011D2 RID: 4562
		RemoveHackingEntityNotify = 22506,
		// Token: 0x040011D3 RID: 4563
		BossRushSelectBuffNotify = 16943,
		// Token: 0x040011D4 RID: 4564
		ActionGroupCreateNotify = 21691,
		// Token: 0x040011D5 RID: 4565
		ActionGroupCompleteNotify = 25820,
		// Token: 0x040011D6 RID: 4566
		ShopInfoUpdateNotify = 26089,
		// Token: 0x040011D7 RID: 4567
		RogueWeeklyCurrencyNotify = 18949,
		// Token: 0x040011D8 RID: 4568
		RogueWeeklyCurrencyUpdateNotify = 18251,
		// Token: 0x040011D9 RID: 4569
		FishingGhostStateNotify = 27726,
		// Token: 0x040011DA RID: 4570
		FishingSkinUnlockNotify = 17605,
		// Token: 0x040011DB RID: 4571
		BabelActivityLevelInfoNotify = 28436,
		// Token: 0x040011DC RID: 4572
		BabelActivityBuffInfoNotify = 24665,
		// Token: 0x040011DD RID: 4573
		BabelActivityTaskInfoNotify = 22425,
		// Token: 0x040011DE RID: 4574
		BabelActivityDailyTaskInfoNotify = 20204,
		// Token: 0x040011DF RID: 4575
		AddGuestNotify = 26842,
		// Token: 0x040011E0 RID: 4576
		RemoveGuestNotify = 15691,
		// Token: 0x040011E1 RID: 4577
		BabelActivitySettleInfoNotify = 29450,
		// Token: 0x040011E2 RID: 4578
		RogueWeeklyBlackFlowerNotify = 24088,
		// Token: 0x040011E3 RID: 4579
		PlayerTitleUpdateNotify = 21787,
		// Token: 0x040011E4 RID: 4580
		DressPlayerTitleUpdateNotify = 19326,
		// Token: 0x040011E5 RID: 4581
		ReplaceVehicleEntityNotify = 18061,
		// Token: 0x040011E6 RID: 4582
		BabelActivityDeTermInfoNotify = 23405,
		// Token: 0x040011E7 RID: 4583
		AbyssRoleInfoUpdateNotify = 27295,
		// Token: 0x040011E8 RID: 4584
		AbyssPluginItemInfoUpdateNotify = 25376,
		// Token: 0x040011E9 RID: 4585
		AbyssRewardsUpdateNotify = 21674,
		// Token: 0x040011EA RID: 4586
		AbyssChallengeUpdateNotify = 19331,
		// Token: 0x040011EB RID: 4587
		AbyssChallengeResultNotify = 18887,
		// Token: 0x040011EC RID: 4588
		AbyssLikeNotify = 17176,
		// Token: 0x040011ED RID: 4589
		AbyssChallengeSubLevelNotify = 19107,
		// Token: 0x040011EE RID: 4590
		AbyssChallengeRoomInfoNotify = 19560,
		// Token: 0x040011EF RID: 4591
		AbyssRoleSelectUpdateNotify = 24255,
		// Token: 0x040011F0 RID: 4592
		FishingPortUpdateNotify = 27457,
		// Token: 0x040011F1 RID: 4593
		BabelActivityUseReviveCountNotify = 15978,
		// Token: 0x040011F2 RID: 4594
		AbyssReviveNotify = 23441,
		// Token: 0x040011F3 RID: 4595
		GravityFlipUpdateTypeNotify = 19748,
		// Token: 0x040011F4 RID: 4596
		ClientVersionNoMatchNotify = 27011,
		// Token: 0x040011F5 RID: 4597
		RacingBetsPlayerInfoUpdateNotify = 28840,
		// Token: 0x040011F6 RID: 4598
		FishingNetCabinUpdateNotify = 29286,
		// Token: 0x040011F7 RID: 4599
		ExploreActivityTaskInfoNotify = 21764,
		// Token: 0x040011F8 RID: 4600
		RacingBetsTaskNotify = 17279,
		// Token: 0x040011F9 RID: 4601
		EntityHeadInfoNotify = 29559,
		// Token: 0x040011FA RID: 4602
		RogueResTalentUnlockNotify = 25233,
		// Token: 0x040011FB RID: 4603
		RogueResEndingUpdateNotify = 27739,
		// Token: 0x040011FC RID: 4604
		RogueResTaskUpdateNotify = 18189,
		// Token: 0x040011FD RID: 4605
		RogueResIllustrationUpdateNotify = 25481,
		// Token: 0x040011FE RID: 4606
		BabelActivityInstInfoNotify = 26859,
		// Token: 0x040011FF RID: 4607
		MoveSplineStatusNotify = 18808,
		// Token: 0x04001200 RID: 4608
		AbyssRoleAddNotify = 21949,
		// Token: 0x04001201 RID: 4609
		AbyssPluginItemAddNotify = 27619,
		// Token: 0x04001202 RID: 4610
		AbyssPluginItemRemoveNotify = 21718,
		// Token: 0x04001203 RID: 4611
		AvignonTaskNotify = 26663,
		// Token: 0x04001204 RID: 4612
		RogueResOpDataNotify = 28593,
		// Token: 0x04001205 RID: 4613
		RogueResInstOptionsNotify = 20056,
		// Token: 0x04001206 RID: 4614
		DebugFightErrInfoNotify = 15787,
		// Token: 0x04001207 RID: 4615
		ActionFinishImmediatelyNotify = 22694,
		// Token: 0x04001208 RID: 4616
		SummonRandomNotify = 25992,
		// Token: 0x04001209 RID: 4617
		BabelActivityItemNumUpdateNotify = 28972,
		// Token: 0x0400120A RID: 4618
		H5CircumFluenceActivityDataNotify = 24475,
		// Token: 0x0400120B RID: 4619
		RoleFlyEquipNotify = 29874,
		// Token: 0x0400120C RID: 4620
		RogueResRoomInfoNotify = 20943,
		// Token: 0x0400120D RID: 4621
		RacingBetsSettleNotify = 19536,
		// Token: 0x0400120E RID: 4622
		RogueResCurrencyNotify = 29732,
		// Token: 0x0400120F RID: 4623
		RogueResCurrencyUpdateNotify = 15356,
		// Token: 0x04001210 RID: 4624
		RogueResInstGlobalDataNotify = 23490,
		// Token: 0x04001211 RID: 4625
		RogueResGridDataUpdateNotify = 15986,
		// Token: 0x04001212 RID: 4626
		RogueResGainDataTotalNotify = 24073,
		// Token: 0x04001213 RID: 4627
		RogueResGainDataUpdateNotify = 29611,
		// Token: 0x04001214 RID: 4628
		RoleFlyEquipChangeNotify = 20739,
		// Token: 0x04001215 RID: 4629
		AbyssReviveTimeNotify = 19368,
		// Token: 0x04001216 RID: 4630
		DangoMonopolyTaskUpdateNotify = 19371,
		// Token: 0x04001217 RID: 4631
		RogueResPlayerStatusUpdateNotify = 29412,
		// Token: 0x04001218 RID: 4632
		RogueResFovUpdateNotify = 27113,
		// Token: 0x04001219 RID: 4633
		RogueResMoodUpdateNotify = 18361,
		// Token: 0x0400121A RID: 4634
		DangoMonopolySceneGridInfoNotify = 28572,
		// Token: 0x0400121B RID: 4635
		RogueResOpDataUpdateNotify = 15468,
		// Token: 0x0400121C RID: 4636
		EntityFlyEquipChangeNotify = 17450,
		// Token: 0x0400121D RID: 4637
		FlyEquipAddNotify = 16449,
		// Token: 0x0400121E RID: 4638
		NewLinkNotify = 23833,
		// Token: 0x0400121F RID: 4639
		ChapterUpdateNotify = 28416,
		// Token: 0x04001220 RID: 4640
		InspirationUpdateNotify = 24547,
		// Token: 0x04001221 RID: 4641
		ScheduleRewardUpdateNotify = 24945,
		// Token: 0x04001222 RID: 4642
		ActivityResultUpdateNotify = 22058,
		// Token: 0x04001223 RID: 4643
		CiacconaActivityStateUnlockUpdateNotify = 27426,
		// Token: 0x04001224 RID: 4644
		RogueResInstOptionsUpdateNotify = 29683,
		// Token: 0x04001225 RID: 4645
		RogueResElementUpdateNotify = 17669,
		// Token: 0x04001226 RID: 4646
		RacingBetLegMatchResultNotify = 24273,
		// Token: 0x04001227 RID: 4647
		RogueResTeamLevelUpdateNotify = 29805,
		// Token: 0x04001228 RID: 4648
		ConfirmResourceQuestNotify = 27650,
		// Token: 0x04001229 RID: 4649
		WaitQuestConfirmResourceNotify = 27440,
		// Token: 0x0400122A RID: 4650
		DetectionInvisibleNotify = 26507,
		// Token: 0x0400122B RID: 4651
		PlayerGravityUpdateNotify = 28738,
		// Token: 0x0400122C RID: 4652
		DangoMonopolyTaskAddNotify = 23445,
		// Token: 0x0400122D RID: 4653
		DangoMonopolyTaskRemoveNotify = 20133,
		// Token: 0x0400122E RID: 4654
		RogueResRoleBondUpdateNotify = 19491,
		// Token: 0x0400122F RID: 4655
		RogueResTotalShopItemUpdateNotify = 23383,
		// Token: 0x04001230 RID: 4656
		SystemMarkHideInfoNotify = 17890,
		// Token: 0x04001231 RID: 4657
		PhantomBattleChallengeInfoUpdateNotify = 20648,
		// Token: 0x04001232 RID: 4658
		PhantomBattleTaskInfoNotify = 26339,
		// Token: 0x04001233 RID: 4659
		PhantomBattleMasterInfoNotify = 18038,
		// Token: 0x04001234 RID: 4660
		PhantomBattleBadgeInfoUpdateNotify = 22202,
		// Token: 0x04001235 RID: 4661
		PhantomBattleBadgeRewardInfoUpdateNotify = 25204,
		// Token: 0x04001236 RID: 4662
		PhantomBattleCardInfoUpdateNotify = 16880,
		// Token: 0x04001237 RID: 4663
		PhantomBattleCardRewardInfoUpdateNotify = 19146,
		// Token: 0x04001238 RID: 4664
		PhantomBattleRoleInfoUpdateNotify = 26654,
		// Token: 0x04001239 RID: 4665
		PhantomBattleCardGroupInfoNotify = 22666,
		// Token: 0x0400123A RID: 4666
		PhantomBattleBoardInfoNotify = 24606,
		// Token: 0x0400123B RID: 4667
		PhantomBattleHandCardInfoUpdateNotify = 25772,
		// Token: 0x0400123C RID: 4668
		PhantomBattleDealCardNotify = 26464,
		// Token: 0x0400123D RID: 4669
		PhantomBattleDealCardReplaceNotify = 27437,
		// Token: 0x0400123E RID: 4670
		PhantomBattleRoundChangeNotify = 24896,
		// Token: 0x0400123F RID: 4671
		BirthDayInfoNotify = 19209,
		// Token: 0x04001240 RID: 4672
		EntityRewardItemNotify = 15063,
		// Token: 0x04001241 RID: 4673
		DangoMonopolyRewardNotify = 18421,
		// Token: 0x04001242 RID: 4674
		ApplyBuffFailedNotify = 22435,
		// Token: 0x04001243 RID: 4675
		ConsumptiveTaskInfoNotify = 22419,
		// Token: 0x04001244 RID: 4676
		TemplateEntitySpawnerContentNotify = 27757,
		// Token: 0x04001245 RID: 4677
		NpcPhantomBattleFightInfoNotify = 15338,
		// Token: 0x04001246 RID: 4678
		PhantomBattleDeployNotify = 18865,
		// Token: 0x04001247 RID: 4679
		PhantomBattleGamerStatusInfoNotify = 26461,
		// Token: 0x04001248 RID: 4680
		PhantomBattleCardAttrInfoNotify = 26580,
		// Token: 0x04001249 RID: 4681
		PhantomBattleSelectTargetEffectNotify = 22838,
		// Token: 0x0400124A RID: 4682
		PhantomBattleSkillTriggerInfoNotify = 24105,
		// Token: 0x0400124B RID: 4683
		PhantomBattleBuffTriggerInfoNotify = 18740,
		// Token: 0x0400124C RID: 4684
		InstSaveDataNotify = 29945,
		// Token: 0x0400124D RID: 4685
		RogueResMoodRangeUpdateNotify = 29633,
		// Token: 0x0400124E RID: 4686
		MoraleInfoNotify = 18749,
		// Token: 0x0400124F RID: 4687
		QuestFocusInfoNotify = 18164,
		// Token: 0x04001250 RID: 4688
		PhantomBattleBvBLoadingNotify = 24799,
		// Token: 0x04001251 RID: 4689
		PhantomBattleBvBFightNotify = 27009,
		// Token: 0x04001252 RID: 4690
		PhantomBattleBvBSettleNotify = 19121,
		// Token: 0x04001253 RID: 4691
		DirectTrainPreOpenCloseNotify = 23904,
		// Token: 0x04001254 RID: 4692
		PhantomBattleBoardSettleNotify = 21589,
		// Token: 0x04001255 RID: 4693
		DebugDrawPosNotify = 20812,
		// Token: 0x04001256 RID: 4694
		RacingBetLegMatchSettleNotify = 24713,
		// Token: 0x04001257 RID: 4695
		PhantomBattleAddBuffInfoNotify = 16131,
		// Token: 0x04001258 RID: 4696
		DirectTrainInfoNotify = 28529,
		// Token: 0x04001259 RID: 4697
		PhantomBattleDiscardCardNotify = 17903,
		// Token: 0x0400125A RID: 4698
		PhantomBattleFourCTaskInfoUpdateNotify = 27016,
		// Token: 0x0400125B RID: 4699
		PhantomBattleFourCTaskDealCardNotify = 29973,
		// Token: 0x0400125C RID: 4700
		SlashAndTowerOverNotify = 25940,
		// Token: 0x0400125D RID: 4701
		QuestReviewInfoNotify = 28644,
		// Token: 0x0400125E RID: 4702
		NewbieCarnivalTaskDataUpdateNotify = 29644,
		// Token: 0x0400125F RID: 4703
		TimeLockInfoNotify = 21913,
		// Token: 0x04001260 RID: 4704
		PhantomBattleCardUpdateNotify = 19936,
		// Token: 0x04001261 RID: 4705
		NewbieCarnivalTaskJumpUpdateNotify = 20522,
		// Token: 0x04001262 RID: 4706
		StartSetQuestFocusNotify = 17380,
		// Token: 0x04001263 RID: 4707
		PhantomBattleCardPosChangeNotify = 20505,
		// Token: 0x04001264 RID: 4708
		RogueResFormationUpdateNotify = 29375,
		// Token: 0x04001265 RID: 4709
		PhantomBattleChallengeUpdateNotify = 26160,
		// Token: 0x04001266 RID: 4710
		FloroRanchUpdatePlayerInfoNotify = 22040,
		// Token: 0x04001267 RID: 4711
		ActionOperationScreenNotify = 18224,
		// Token: 0x04001268 RID: 4712
		PhantomBattleSelectReserveCardNotify = 24681,
		// Token: 0x04001269 RID: 4713
		PhantomBattleBurnBuffNotify = 21033,
		// Token: 0x0400126A RID: 4714
		LifePointChallengeUpdateNotify = 15515,
		// Token: 0x0400126B RID: 4715
		TestCmdNotify = 21962,
		// Token: 0x0400126C RID: 4716
		ShopBuyNotify = 21076,
		// Token: 0x0400126D RID: 4717
		QuestLockInfoNotify = 17210,
		// Token: 0x0400126E RID: 4718
		GridCellUpdateNotify = 25103,
		// Token: 0x0400126F RID: 4719
		InteractQuestSuspendEntityNotify = 28715,
		// Token: 0x04001270 RID: 4720
		FloroRanchPlayGmInfoUpdateNotify = 19286,
		// Token: 0x04001271 RID: 4721
		ResetQuestFocusModeNotify = 27177,
		// Token: 0x04001272 RID: 4722
		TrapDefensePreviewStartNotify = 28509,
		// Token: 0x04001273 RID: 4723
		RoleGoDownNotify = 24225,
		// Token: 0x04001274 RID: 4724
		StopHoldHandNotify = 29128,
		// Token: 0x04001275 RID: 4725
		LowMemoryChangeSceneStartNotify = 26026,
		// Token: 0x04001276 RID: 4726
		TrapDefenseRewardGainingGroupsNotify = 15832,
		// Token: 0x04001277 RID: 4727
		TrapDefenseSyncGainingGroupsNotify = 15348,
		// Token: 0x04001278 RID: 4728
		SimpleCombatEntityBuffUpdateNotify = 17893,
		// Token: 0x04001279 RID: 4729
		TrapDefenseSystemInfoNotify = 25227,
		// Token: 0x0400127A RID: 4730
		ItemPkgFullNotify = 29804,
		// Token: 0x0400127B RID: 4731
		TrapDefenseChallengeUpdateNotify = 28586,
		// Token: 0x0400127C RID: 4732
		TrapDefenseRewardUpdateNotify = 29453,
		// Token: 0x0400127D RID: 4733
		TrapDefenseSpecialRewardUpdateNotify = 24748,
		// Token: 0x0400127E RID: 4734
		TrapDefenseDevelopInfoUpdateNotify = 27912,
		// Token: 0x0400127F RID: 4735
		TrapDefenseTechUpdateNotify = 28334,
		// Token: 0x04001280 RID: 4736
		FunPlayChallengeInfoUpdateNotify = 21748,
		// Token: 0x04001281 RID: 4737
		FunPlayChallengeSettleNotify = 20471,
		// Token: 0x04001282 RID: 4738
		TrapDefenseChallengeResultNotify = 19080,
		// Token: 0x04001283 RID: 4739
		TrapDefenseStepUpdateNotify = 25839,
		// Token: 0x04001284 RID: 4740
		TrapDefenseSystemInfoUpdateNotify = 16215,
		// Token: 0x04001285 RID: 4741
		TrapDefenseSpawnMonsterWaveEndNotify = 29527,
		// Token: 0x04001286 RID: 4742
		TrapDefenseMonsterConsecutiveKillsNotify = 19882,
		// Token: 0x04001287 RID: 4743
		TrapDefenseBdUpdateNotify = 19038,
		// Token: 0x04001288 RID: 4744
		SimpleCombatEntitySubTypeChangeNotify = 26830,
		// Token: 0x04001289 RID: 4745
		TrapDefenseEntityDataChangeNotify = 22179,
		// Token: 0x0400128A RID: 4746
		TrapDefenseTechPointUpdateNotify = 22033,
		// Token: 0x0400128B RID: 4747
		CommonUiSettingNotify = 29215,
		// Token: 0x0400128C RID: 4748
		TrapDefenseItemUpdateNotify = 23792,
		// Token: 0x0400128D RID: 4749
		LineCrossActivityUpdateNotify = 19172,
		// Token: 0x0400128E RID: 4750
		TrapDefenseGainingGroupUpdateNotify = 28590,
		// Token: 0x0400128F RID: 4751
		PhotoFightResultNotify = 26116,
		// Token: 0x04001290 RID: 4752
		PhotoFightLevelInfoNotify = 16757,
		// Token: 0x04001291 RID: 4753
		SimpleCombatEntityBuffLayerCountNotify = 22102,
		// Token: 0x04001292 RID: 4754
		EntityCalabashSkinChangeNotify = 15059,
		// Token: 0x04001293 RID: 4755
		SurvivorsOpDataUpdateNotify = 15846,
		// Token: 0x04001294 RID: 4756
		SurvivorsOpDataForceChangeNotify = 24578,
		// Token: 0x04001295 RID: 4757
		SurvivorsGainDataUpdateNotify = 19888,
		// Token: 0x04001296 RID: 4758
		SurvivorsInstGlobalDataNotify = 25324,
		// Token: 0x04001297 RID: 4759
		SurvivorsStepUpdateNotify = 27029,
		// Token: 0x04001298 RID: 4760
		QuestTreeInfoNotify = 15465,
		// Token: 0x04001299 RID: 4761
		CalabashSkinTakeOnNotify = 27504,
		// Token: 0x0400129A RID: 4762
		CalabashSkinUpdateNotify = 23736,
		// Token: 0x0400129B RID: 4763
		YuXueModeInfoNotify = 27043,
		// Token: 0x0400129C RID: 4764
		TrapDefenseBdGroupUnlockNotify = 21201,
		// Token: 0x0400129D RID: 4765
		SurvivorsSpawnMonsterWaveEndNotify = 21097,
		// Token: 0x0400129E RID: 4766
		SurvivorsMonsterConsecutiveKillsNotify = 23401,
		// Token: 0x0400129F RID: 4767
		SurvivorsVarRecordNotify = 25152,
		// Token: 0x040012A0 RID: 4768
		SurvivorsTaskDataUpdateNotify = 24480,
		// Token: 0x040012A1 RID: 4769
		SurvivorsHandBooskUnlockNotify = 23073,
		// Token: 0x040012A2 RID: 4770
		SurvivorsTalentUnlockNotify = 20550,
		// Token: 0x040012A3 RID: 4771
		SurvivorsChallengeInfoUpdateNotify = 20450,
		// Token: 0x040012A4 RID: 4772
		WeaponSkinUpdateNotify = 26225,
		// Token: 0x040012A5 RID: 4773
		RoleSkinChangeNotify = 18513,
		// Token: 0x040012A6 RID: 4774
		PlayerHeadUpdateNotify = 19263,
		// Token: 0x040012A7 RID: 4775
		RoleUpdateDevelopTargetNotify = 24438,
		// Token: 0x040012A8 RID: 4776
		InfrFireAddNotify = 19099,
		// Token: 0x040012A9 RID: 4777
		InfrRoadUpdateNotify = 16869,
		// Token: 0x040012AA RID: 4778
		CharacterMoveToPointNotify = 27358,
		// Token: 0x040012AB RID: 4779
		InfrFireUpdateNotify = 23308,
		// Token: 0x040012AC RID: 4780
		PackAnimChangedNotify = 27418,
		// Token: 0x040012AD RID: 4781
		RogueWeeklyInteractionResultNotify = 20079,
		// Token: 0x040012AE RID: 4782
		HonamiStoryLimitTaskInfoUpdateNotify = 21435,
		// Token: 0x040012AF RID: 4783
		HonamiStoryAreaTaskInfoRefreshNotify = 28536,
		// Token: 0x040012B0 RID: 4784
		HonamiStoryAreaTaskInfoUpdateNotify = 22423,
		// Token: 0x040012B1 RID: 4785
		HonamiStoryBagInfoUpdateNotify = 24569,
		// Token: 0x040012B2 RID: 4786
		HonamiStoryRoleUpdateNotify = 15005,
		// Token: 0x040012B3 RID: 4787
		HonamiStoryAddWeaponNotify = 24790,
		// Token: 0x040012B4 RID: 4788
		HonamiStoryItemCollectionInfoUpdateNotify = 20304,
		// Token: 0x040012B5 RID: 4789
		HonamiStoryMascotInfoUpdateNotify = 19969,
		// Token: 0x040012B6 RID: 4790
		HonamiStoryAreaInfoUpdateNotify = 21643,
		// Token: 0x040012B7 RID: 4791
		HonamiStoryInstInfoNotify = 16347,
		// Token: 0x040012B8 RID: 4792
		HonamiStoryPollutionUpdateNotify = 20668,
		// Token: 0x040012B9 RID: 4793
		HonamiStoryInstSettleNotify = 21849,
		// Token: 0x040012BA RID: 4794
		HonamiStoryInstTopTowerSettleNotify = 15272,
		// Token: 0x040012BB RID: 4795
		HonamiStorySafeLeaveNotify = 23728,
		// Token: 0x040012BC RID: 4796
		HonamiStoryPollutionBoxSteadyLimitNotify = 17022,
		// Token: 0x040012BD RID: 4797
		HonamiStoryScoreRewardInfoUpdateNotify = 16232,
		// Token: 0x040012BE RID: 4798
		EntityHonamiStoryEnhanceLevelNotify = 29068,
		// Token: 0x040012BF RID: 4799
		SunSpiritListNotify = 21877,
		// Token: 0x040012C0 RID: 4800
		SunSpiritCollectNotify = 24685,
		// Token: 0x040012C1 RID: 4801
		SunSpiritUpdateNotify = 24091,
		// Token: 0x040012C2 RID: 4802
		RollBlockOpenGamePlayNotify = 21277,
		// Token: 0x040012C3 RID: 4803
		RollBlockCloseGamePlayNotify = 19604,
		// Token: 0x040012C4 RID: 4804
		RollBlockSyncInfoNotify = 21853,
		// Token: 0x040012C5 RID: 4805
		HonamiStoryLimitShopConsumeNumNotify = 27498,
		// Token: 0x040012C6 RID: 4806
		SurvivorsComboParamUpdateNotify = 27463,
		// Token: 0x040012C7 RID: 4807
		SunSpiritActionOperationNotify = 22508,
		// Token: 0x040012C8 RID: 4808
		HonamiStoryBagSizeUpdateNotify = 23119,
		// Token: 0x040012C9 RID: 4809
		MotorTaskInfoNotify = 22685,
		// Token: 0x040012CA RID: 4810
		PhantomInteractionInfoUpdateNotify = 18664,
		// Token: 0x040012CB RID: 4811
		PhantomInteractionUnlockNotify = 16490,
		// Token: 0x040012CC RID: 4812
		ChangeSceneRoadNotify = 18972,
		// Token: 0x040012CD RID: 4813
		MotorTaskUpdateNotify = 23000,
		// Token: 0x040012CE RID: 4814
		MotorTechUnlockNotify = 22153,
		// Token: 0x040012CF RID: 4815
		MotorTechTreeUnlockNotify = 16286,
		// Token: 0x040012D0 RID: 4816
		MotorDataNotify = 25061,
		// Token: 0x040012D1 RID: 4817
		DetectionTargetChangeNotify = 25568,
		// Token: 0x040012D2 RID: 4818
		AreaTerminalInfoNotify = 22310,
		// Token: 0x040012D3 RID: 4819
		HonamiStoryTopInfoNotify = 23604,
		// Token: 0x040012D4 RID: 4820
		RbBlockStateChangeNotify = 19426,
		// Token: 0x040012D5 RID: 4821
		HonamiStorySetFormationNotify = 27708,
		// Token: 0x040012D6 RID: 4822
		VisionTriggerNotify = 21314,
		// Token: 0x040012D7 RID: 4823
		SceneBlockSplitHumanChangleNotify = 26500,
		// Token: 0x040012D8 RID: 4824
		SceneBlockSplitHumanFullNotify = 28122,
		// Token: 0x040012D9 RID: 4825
		RemoveBuffByServerIdS2cRequestNotify = 23494,
		// Token: 0x040012DA RID: 4826
		MotorExpAddNotify = 28144,
		// Token: 0x040012DB RID: 4827
		SceneBlockSplitHumanSwitchStateNotify = 22518,
		// Token: 0x040012DC RID: 4828
		HonamiStoryTalentInfoUpdateNotify = 28280,
		// Token: 0x040012DD RID: 4829
		PhantomBattleAreaSkillCdNotify = 22971,
		// Token: 0x040012DE RID: 4830
		PhantomBattleAreaSkillNotify = 25473,
		// Token: 0x040012DF RID: 4831
		PhantomBattleCardDurableEmptyNotify = 17095,
		// Token: 0x040012E0 RID: 4832
		ArtemisNodeUpdateNotify = 15008,
		// Token: 0x040012E1 RID: 4833
		SceneBlockSplitPopWindowNotify = 22587,
		// Token: 0x040012E2 RID: 4834
		DecalAddNotify = 16035,
		// Token: 0x040012E3 RID: 4835
		DecalRemoveNotify = 28009,
		// Token: 0x040012E4 RID: 4836
		RoleSceneVoiceSwitchNotify = 17013,
		// Token: 0x040012E5 RID: 4837
		CoopRoleInfoUpdateNotify = 28969,
		// Token: 0x040012E6 RID: 4838
		HonamiStoryResidentTaskInfoUpdateNotify = 24495,
		// Token: 0x040012E7 RID: 4839
		HonamiStoryTotalRevenueNotify = 25388,
		// Token: 0x040012E8 RID: 4840
		MotorOutlookAddNotify = 22787,
		// Token: 0x040012E9 RID: 4841
		MotorOutlookOwnedChangeNotify = 29827,
		// Token: 0x040012EA RID: 4842
		MotorOutlookEquippedChangeNotify = 16900,
		// Token: 0x040012EB RID: 4843
		RollBlockUpdateGamePlayNotify = 22853,
		// Token: 0x040012EC RID: 4844
		MotorcycleTaskUpdateNotify = 20935,
		// Token: 0x040012ED RID: 4845
		PhantomBattleCallCardNotify = 15843,
		// Token: 0x040012EE RID: 4846
		EntityMotorOutlookChangeNotify = 22728,
		// Token: 0x040012EF RID: 4847
		ShortMessageUpdateNotify = 19211,
		// Token: 0x040012F0 RID: 4848
		InfrLibraryTaskUpdateNotify = 21906,
		// Token: 0x040012F1 RID: 4849
		RoadNetworkEntityStartNavNotify = 28503,
		// Token: 0x040012F2 RID: 4850
		RollBlockResetGamePlayNotify = 27566,
		// Token: 0x040012F3 RID: 4851
		MotorOutlookRegionInfoNotify = 23727,
		// Token: 0x040012F4 RID: 4852
		VehicleShareNotify = 25947,
		// Token: 0x040012F5 RID: 4853
		RoadBookInfoUpdateNotify = 19177,
		// Token: 0x040012F6 RID: 4854
		MotorParkourLevelRewardUpdateNotify = 17426,
		// Token: 0x040012F7 RID: 4855
		MotorParkourResultNotify = 16702,
		// Token: 0x040012F8 RID: 4856
		InfrThemeActivityTaskDataUpdateNotify = 24908,
		// Token: 0x040012F9 RID: 4857
		SkinRewardInfoUpdateNotify = 26166,
		// Token: 0x040012FA RID: 4858
		NewTowerResultNotify = 22039,
		// Token: 0x040012FB RID: 4859
		MotorFightTalentTreeUpdateNotify = 28750,
		// Token: 0x040012FC RID: 4860
		MotorFightItemUpdateNotify = 29340,
		// Token: 0x040012FD RID: 4861
		MotorFightRoleUpdateNotify = 28456,
		// Token: 0x040012FE RID: 4862
		MotorFightLevelUpdateNotify = 16531,
		// Token: 0x040012FF RID: 4863
		MotorFightTaskUpdateNotify = 24956,
		// Token: 0x04001300 RID: 4864
		HonamiStoryLifeSupportNotify = 25628,
		// Token: 0x04001301 RID: 4865
		FireShopCoinNotify = 25358,
		// Token: 0x04001302 RID: 4866
		EncircleChallengeUpdateNotify = 22754,
		// Token: 0x04001303 RID: 4867
		HookLockBatchCollectNotify = 15974,
		// Token: 0x04001304 RID: 4868
		NewTowerUpdateRecordNotify = 15739,
		// Token: 0x04001305 RID: 4869
		PhantomDirectRefiningWeeklyResetNotify = 23980,
		// Token: 0x04001306 RID: 4870
		ShortMessageItemUpdateNotify = 29198,
		// Token: 0x04001307 RID: 4871
		MotorBattleContextNotify = 18170,
		// Token: 0x04001308 RID: 4872
		PhantomBattleReconstructCardNotify = 18858,
		// Token: 0x04001309 RID: 4873
		RollBlockUpdateAvailableInputsNotify = 23864,
		// Token: 0x0400130A RID: 4874
		NewPlayerSupportActivityTaskUpdateNotify = 27935,
		// Token: 0x0400130B RID: 4875
		MotorParkourStartNotify = 21824,
		// Token: 0x0400130C RID: 4876
		RegressTrialRoleUnlockNotify = 26108,
		// Token: 0x0400130D RID: 4877
		WeatherControlUnlockNotify = 15470,
		// Token: 0x0400130E RID: 4878
		TotalTopUpRewardNotify = 26650,
		// Token: 0x0400130F RID: 4879
		BookItemUpdateNotify = 26909,
		// Token: 0x04001310 RID: 4880
		EffectiveWeekCardInfoNotify = 16179,
		// Token: 0x04001311 RID: 4881
		NewPlayerSupportActivityTrialRoleUpdateNotify = 16807,
		// Token: 0x04001312 RID: 4882
		MotorFightRefreshSubLevelNotify = 27381,
		// Token: 0x04001313 RID: 4883
		H5ViewActivityDataNotify = 25838,
		// Token: 0x04001314 RID: 4884
		PhantomBattleSkillEffectFailNotify = 23479,
		// Token: 0x04001315 RID: 4885
		NewTowerTaskDataUpdateNotify = 23458,
		// Token: 0x04001316 RID: 4886
		NewTowerLevelUnlockNotify = 27780,
		// Token: 0x04001317 RID: 4887
		RoleConfigInfoNotify = 18250,
		// Token: 0x04001318 RID: 4888
		RoleConfigInfoUpdateNotify = 24298,
		// Token: 0x04001319 RID: 4889
		SceneRoadSyncNotify = 29415,
		// Token: 0x0400131A RID: 4890
		MotorFightGameOverNotify = 24027,
		// Token: 0x0400131B RID: 4891
		TotalTopUpActivityInfoNotify = 27743,
		// Token: 0x0400131C RID: 4892
		TransformBuffStackNotify = 27991,
		// Token: 0x0400131D RID: 4893
		RegressActivityTrialRoleUpdateNotify = 23826,
		// Token: 0x0400131E RID: 4894
		MotorFightRoundInfoNotify = 18494,
		// Token: 0x0400131F RID: 4895
		MotorFightBossDropNotify = 23836,
		// Token: 0x04001320 RID: 4896
		NewTowerRoundUpdateNotify = 20449,
		// Token: 0x04001321 RID: 4897
		RollBlockItemUpdateNotify = 23026,
		// Token: 0x04001322 RID: 4898
		MotorFightMonsterDropNotify = 15577,
		// Token: 0x04001323 RID: 4899
		MotorAnimReplaySampleUdpNotify = 25598,
		// Token: 0x04001324 RID: 4900
		SpringFestivalAreaUnlockNotify = 17922,
		// Token: 0x04001325 RID: 4901
		GivebackInfoUpdateNotify = 20857,
		// Token: 0x04001326 RID: 4902
		MotorFightScoreNotify = 18508,
		// Token: 0x04001327 RID: 4903
		RoleDevelopConfigUpdateNotify = 25367,
		// Token: 0x04001328 RID: 4904
		MotorLockedTechUpdateNotify = 18686,
		// Token: 0x04001329 RID: 4905
		ActionResetPosPrePerformanceNotify = 15572,
		// Token: 0x0400132A RID: 4906
		MotorFightAddBuffNotify = 27308,
		// Token: 0x0400132B RID: 4907
		LevelPlayGainRewardInfoNotify = 18892,
		// Token: 0x0400132C RID: 4908
		SpringFestivalUpdateNotify = 17951,
		// Token: 0x0400132D RID: 4909
		PhantomMusicNotify = 16079,
		// Token: 0x0400132E RID: 4910
		FlagChallengeTaskInfoUpdateNotify = 17747,
		// Token: 0x0400132F RID: 4911
		FlagChallengeLevelInfoUpdateNotify = 15056,
		// Token: 0x04001330 RID: 4912
		FlagStrongholdInfoUpdateNotify = 23830,
		// Token: 0x04001331 RID: 4913
		FlagChallengePerRoleLevelNotify = 17390,
		// Token: 0x04001332 RID: 4914
		FlagChallengeTempRoleLevelNotify = 25219,
		// Token: 0x04001333 RID: 4915
		FlagChallengeInstNotify = 19288,
		// Token: 0x04001334 RID: 4916
		MotorDevelopTaskUpdateNotify = 15550,
		// Token: 0x04001335 RID: 4917
		SpringFestivalAtmosphereUpdateNotify = 15997,
		// Token: 0x04001336 RID: 4918
		FlagChallengeSettleNotify = 20618,
		// Token: 0x04001337 RID: 4919
		KurotatoStepUpdateNotify = 16601,
		// Token: 0x04001338 RID: 4920
		GivebackUnlockNotify = 21002,
		// Token: 0x04001339 RID: 4921
		MotorFightAddEnemyBuffNotify = 16034,
		// Token: 0x0400133A RID: 4922
		MotorFightRefreshCollectionTimesChangeNotify = 20476,
		// Token: 0x0400133B RID: 4923
		FurnitureUnlockNotify = 19142,
		// Token: 0x0400133C RID: 4924
		MotorFightAddCollectionNotify = 25419,
		// Token: 0x0400133D RID: 4925
		MotorSummonAndRideNotify = 20643,
		// Token: 0x0400133E RID: 4926
		KurotatoChestRewardNotify = 25333,
		// Token: 0x0400133F RID: 4927
		KurotatoUpgradeRewardNotify = 18341,
		// Token: 0x04001340 RID: 4928
		KurotatoShopRewardNotify = 25121,
		// Token: 0x04001341 RID: 4929
		KurotatoSystemInfoNotify = 28540,
		// Token: 0x04001342 RID: 4930
		KurotatoItemUpdateNotify = 18788,
		// Token: 0x04001343 RID: 4931
		ConfirmCompleteRefMp4QuestNotify = 23244,
		// Token: 0x04001344 RID: 4932
		FeiXuePreheatInfoUpdateNotify = 24082,
		// Token: 0x04001345 RID: 4933
		StorageInfoNotify = 24801,
		// Token: 0x04001346 RID: 4934
		RhythmRoleUpdateNotify = 24501,
		// Token: 0x04001347 RID: 4935
		RhythmSubLevelUpdateNotify = 23745,
		// Token: 0x04001348 RID: 4936
		RhythmTaskUpdateNotify = 20813,
		// Token: 0x04001349 RID: 4937
		DropCatchLevelRewardUpdateNotify = 29378,
		// Token: 0x0400134A RID: 4938
		SplinePositionNotify = 28528,
		// Token: 0x0400134B RID: 4939
		TimeScheduleTriggerNotify = 20242,
		// Token: 0x0400134C RID: 4940
		KurotatoWeaponUpdateNotify = 17722,
		// Token: 0x0400134D RID: 4941
		NewTowerSeasonTaskDataUpdateNotify = 16522,
		// Token: 0x0400134E RID: 4942
		WillSwitchSceneGroupNotify = 25350,
		// Token: 0x0400134F RID: 4943
		RhythmShipStartNotify = 22158,
		// Token: 0x04001350 RID: 4944
		FlagChallengeBoxExpNotify = 15006,
		// Token: 0x04001351 RID: 4945
		ConsumptiveTotalScoreNotify = 18727,
		// Token: 0x04001352 RID: 4946
		EnterAreaNotify = 29588,
		// Token: 0x04001353 RID: 4947
		RecallInfoNotify = 18029,
		// Token: 0x04001354 RID: 4948
		EntityDressOrnamentChangeNotify = 19511,
		// Token: 0x04001355 RID: 4949
		OrnamentInfoNotify = 27306,
		// Token: 0x04001356 RID: 4950
		OrnamentUnlockNotify = 22041,
		// Token: 0x04001357 RID: 4951
		OrnamentDressInfoUpdateNotify = 21795,
		// Token: 0x04001358 RID: 4952
		SimpleCombatEntityAttributeUpdateNotify = 16764,
		// Token: 0x04001359 RID: 4953
		AvoidBlockSettlementNotify = 23738,
		// Token: 0x0400135A RID: 4954
		AvoidBlockRoundInfoNotify = 16725,
		// Token: 0x0400135B RID: 4955
		CompleteMarkNotify = 27290,
		// Token: 0x0400135C RID: 4956
		FlagChallengeUnlockTeleporterNotify = 28693,
		// Token: 0x0400135D RID: 4957
		PlayerXboxSessionNotify = 27434,
		// Token: 0x0400135E RID: 4958
		PinballSettleNotify = 19382,
		// Token: 0x0400135F RID: 4959
		PinballInGameStateChangeNotify = 27614,
		// Token: 0x04001360 RID: 4960
		KurotatoPropertyUpdateNotify = 15776,
		// Token: 0x04001361 RID: 4961
		PinballUpdateNotify = 26492,
		// Token: 0x04001362 RID: 4962
		BulletPatternNotify = 29108,
		// Token: 0x04001363 RID: 4963
		BeamReceiveNotify = 18439,
		// Token: 0x04001364 RID: 4964
		InfrV2TreeUpdateNotify = 17953,
		// Token: 0x04001365 RID: 4965
		RogueInstExtraInfoUpdateNotify = 25441,
		// Token: 0x04001366 RID: 4966
		InfrV2FireUpdateNotify = 26200,
		// Token: 0x04001367 RID: 4967
		InfrV2TaskDataUpdateNotify = 21917,
		// Token: 0x04001368 RID: 4968
		WuWuTaskUpdateNotify = 16006,
		// Token: 0x04001369 RID: 4969
		ThemeCeleWuWuTaskNotify = 15267,
		// Token: 0x0400136A RID: 4970
		BossPilingTaskInfoUpdateNotify = 29797,
		// Token: 0x0400136B RID: 4971
		BossPilingLevelInfoUpdateNotify = 19428,
		// Token: 0x0400136C RID: 4972
		BossPilingInstNotify = 15085,
		// Token: 0x0400136D RID: 4973
		BossPilingBuffUpdateNotify = 23086,
		// Token: 0x0400136E RID: 4974
		BossPilingSettleNotify = 21250,
		// Token: 0x0400136F RID: 4975
		MotorDecalUpdateNotify = 26984,
		// Token: 0x04001370 RID: 4976
		MotorOutlookFullChangeNotify = 24893,
		// Token: 0x04001371 RID: 4977
		PinballInGameStarChangeNotify = 24193,
		// Token: 0x04001372 RID: 4978
		FsmMontageDurationNotify = 20087,
		// Token: 0x04001373 RID: 4979
		QuestBranchUpdateNotify = 15721,
		// Token: 0x04001374 RID: 4980
		MotorPositionStateNotify = 24502,
		// Token: 0x04001375 RID: 4981
		GachaAccumulateInfoNotify = 19571,
		// Token: 0x04001376 RID: 4982
		InfrV2TreeFinishCondUpdateNotify = 18202,
		// Token: 0x04001377 RID: 4983
		EdgeRunnerUpdateNotify = 20220,
		// Token: 0x04001378 RID: 4984
		KurotatoLevelDataUpdateNotify = 19312,
		// Token: 0x04001379 RID: 4985
		KurotatoRoleUnlockNotify = 18201,
		// Token: 0x0400137A RID: 4986
		KurotatoWeaponUnlockNotify = 19005,
		// Token: 0x0400137B RID: 4987
		KurotatoItemUnlockNotify = 18731,
		// Token: 0x0400137C RID: 4988
		KurotatoResTaskUpdateNotify = 26283,
		// Token: 0x0400137D RID: 4989
		KurotatoLimitTaskUpdateNotify = 20647,
		// Token: 0x0400137E RID: 4990
		PinballUpdateWaveNotify = 27589,
		// Token: 0x0400137F RID: 4991
		WeeklyFrameworkInfoUpdateNotify = 27476,
		// Token: 0x04001380 RID: 4992
		KurotatoSettlementNotify = 15404,
		// Token: 0x04001381 RID: 4993
		EdgeRunnerLordGymLevelPlayResultNotify = 25758,
		// Token: 0x04001382 RID: 4994
		MotorOnlineRankSnapshotNotify = 28537,
		// Token: 0x04001383 RID: 4995
		FloroRanchPlayWeeklyNotify = 27695,
		// Token: 0x04001384 RID: 4996
		StorageInfoUpdateNotify = 23161,
		// Token: 0x04001385 RID: 4997
		KurotatoRoleRecordNotify = 18134,
		// Token: 0x04001386 RID: 4998
		OnlineMotorSettleNotify = 22637,
		// Token: 0x04001387 RID: 4999
		OnlineMotorUpdateNotify = 18930,
		// Token: 0x04001388 RID: 5000
		PinballStartNotify = 20511,
		// Token: 0x04001389 RID: 5001
		DollDeliveryNotify = 22651,
		// Token: 0x0400138A RID: 5002
		PinballFixSpawnFinishNotify = 16738,
		// Token: 0x0400138B RID: 5003
		EdgeRunnerPreUnlockAvailableNotify = 24277,
		// Token: 0x0400138C RID: 5004
		InfrV2InfoNotify = 26813,
		// Token: 0x0400138D RID: 5005
		RemovePreloadFlowsNotify = 19296,
		// Token: 0x0400138E RID: 5006
		PinballSpawnFirstFinishNotify = 23508,
		// Token: 0x0400138F RID: 5007
		FloroRanchPlayWeeklyEndNotify = 26360,
		// Token: 0x04001390 RID: 5008
		KurotatoDieNotify = 19556,
		// Token: 0x04001391 RID: 5009
		MotorOnlineRankRuleIdsNotify = 28493,
		// Token: 0x04001392 RID: 5010
		OnlineMotorStartNotify = 18191,
		// Token: 0x04001393 RID: 5011
		NewPlayerSupportActivityTrialRoleUpdateV2Notify = 24111,
		// Token: 0x04001394 RID: 5012
		OnlineMotorEndNotify = 21868,
		// Token: 0x04001395 RID: 5013
		NewPlayerSupportV2GachaRoleUpdateNotify = 25759,
		// Token: 0x04001396 RID: 5014
		RealmBetweenInfoUpdateNotify = 27851,
		// Token: 0x04001397 RID: 5015
		RogueTowerTrialReChallengeNotify = 15826,
		// Token: 0x04001398 RID: 5016
		RogueTowerTrialResultNotify = 18837,
		// Token: 0x04001399 RID: 5017
		RogueTowerTrialSelectBossNotify = 19931,
		// Token: 0x0400139A RID: 5018
		SheriffAnomalyInfoUpdateNotify = 20999,
		// Token: 0x0400139B RID: 5019
		SheriffCriminalUpdateNotify = 22065,
		// Token: 0x0400139C RID: 5020
		MiniWriteLetterLoginNotify = 26135,
		// Token: 0x0400139D RID: 5021
		TimeScheduleIdleNotify = 25662,
		// Token: 0x0400139E RID: 5022
		GachaDiscountNotify = 26843,
		// Token: 0x0400139F RID: 5023
		KurotatoRefineWeaponNotify = 23546,
		// Token: 0x040013A0 RID: 5024
		RecallQuestListNotify = 25593,
		// Token: 0x040013A1 RID: 5025
		TraceRecallQuestNotify = 19408,
		// Token: 0x040013A2 RID: 5026
		RecallQuestChangeTraceNotify = 24980,
		// Token: 0x040013A3 RID: 5027
		RecallQuestRollBackEndNotify = 23374,
		// Token: 0x040013A4 RID: 5028
		RecallQuestStatusUpdateNotify = 20791,
		// Token: 0x040013A5 RID: 5029
		RecallQuestFinishListNotify = 16834,
		// Token: 0x040013A6 RID: 5030
		DestroyRecallQuestsNotify = 24930,
		// Token: 0x040013A7 RID: 5031
		NewbieAdventureTaskUpdateNotify = 22437,
		// Token: 0x040013A8 RID: 5032
		NewbieCourseV2RewardNotify = 23862,
		// Token: 0x040013A9 RID: 5033
		NewbieMainTaskUpdateNotify = 29029,
		// Token: 0x040013AA RID: 5034
		RecallQuestGiveUpNotify = 22166,
		// Token: 0x040013AB RID: 5035
		RecallItemBagDeltaNotify = 16700,
		// Token: 0x040013AC RID: 5036
		ActivityRecommendNotify = 18576,
		// Token: 0x040013AD RID: 5037
		RecallItemBagRemoveNotify = 16328,
		// Token: 0x040013AE RID: 5038
		NewTowerMonsterHpInfoNotify = 27762,
		// Token: 0x040013AF RID: 5039
		LordGymGroupInfoUpdateNotify = 23018,
		// Token: 0x040013B0 RID: 5040
		KurotatoAllItemUpdateNotify = 15679,
		// Token: 0x040013B1 RID: 5041
		SimpleCombatBeginNotify = 27378,
		// Token: 0x040013B2 RID: 5042
		SimpleCombatEndNotify = 27894,
		// Token: 0x040013B3 RID: 5043
		RoverRogueResultNotify = 26373,
		// Token: 0x040013B4 RID: 5044
		RoverRogueRoomInfoNotify = 28630,
		// Token: 0x040013B5 RID: 5045
		RoverRogueChooseDataNotify = 26956,
		// Token: 0x040013B6 RID: 5046
		RoverRogueSubLevelNotify = 29516,
		// Token: 0x040013B7 RID: 5047
		RoverRogueShopUpdateNotify = 21564,
		// Token: 0x040013B8 RID: 5048
		RoverRogueInfoNotify = 19891,
		// Token: 0x040013B9 RID: 5049
		RoverRogueGainDataUpdateNotify = 23339,
		// Token: 0x040013BA RID: 5050
		RoverRogueCurrencyNotify = 17019,
		// Token: 0x040013BB RID: 5051
		PlayerRecallInfoNotify = 26036,
		// Token: 0x040013BC RID: 5052
		DangoBrawlInstBaseNotify = 20779,
		// Token: 0x040013BD RID: 5053
		DangoBrawlInstEventSelectNotify = 15046,
		// Token: 0x040013BE RID: 5054
		DangoBrawlInstPrepareNotify = 29564,
		// Token: 0x040013BF RID: 5055
		DangoBrawlRoundSwitchNotify = 27098,
		// Token: 0x040013C0 RID: 5056
		DangoBrawlCoinUpdateNotify = 17630,
		// Token: 0x040013C1 RID: 5057
		DangoBrawlSettleNotify = 17267,
		// Token: 0x040013C2 RID: 5058
		RoverRogueGainGetOrLoseNotify = 20460,
		// Token: 0x040013C3 RID: 5059
		RoverRogueUpdateReviveTimesNotify = 18452,
		// Token: 0x040013C4 RID: 5060
		KurotatoNextWaveTypeNotify = 20306,
		// Token: 0x040013C5 RID: 5061
		RoverRogueBlessGroupSelectNotify = 28895,
		// Token: 0x040013C6 RID: 5062
		DirectTrainInfoUpdateNotify = 20905,
		// Token: 0x040013C7 RID: 5063
		LeaveQuestRecallNotify = 16941,
		// Token: 0x040013C8 RID: 5064
		RoverRogueEventNotify = 15360,
		// Token: 0x040013C9 RID: 5065
		DangoBrawlFighterAttrChangeNotify = 25853,
		// Token: 0x040013CA RID: 5066
		DangoBrawlTaskUpdateNotify = 28545,
		// Token: 0x040013CB RID: 5067
		DangoBrawlRoleUnlockNotify = 18339,
		// Token: 0x040013CC RID: 5068
		DangoBrawlItemUnlockNotify = 29171,
		// Token: 0x040013CD RID: 5069
		PlayerNetStateS2cNotify = 27482,
		// Token: 0x040013CE RID: 5070
		DarkTideBagUpdateNotify = 25791,
		// Token: 0x040013CF RID: 5071
		SwitchDarkTideWeaponSlotNotify = 18091,
		// Token: 0x040013D0 RID: 5072
		AllDarkTideMapMarkNotify = 22844,
		// Token: 0x040013D1 RID: 5073
		DarkTideMapMarkUpdateNotify = 18648,
		// Token: 0x040013D2 RID: 5074
		DarkTideItemMarkUpdateNotify = 20455,
		// Token: 0x040013D3 RID: 5075
		KurotatoReChallengeCountNotify = 19995,
		// Token: 0x040013D4 RID: 5076
		RoverRogueLootChangeNotify = 18535,
		// Token: 0x040013D5 RID: 5077
		DarkTidePoisonCircleDayInitNotify = 18257,
		// Token: 0x040013D6 RID: 5078
		DarkTidePoisonCircleStartShrinkNotify = 24836,
		// Token: 0x040013D7 RID: 5079
		DarkTidePoisonCircleStopShrinkNotify = 19681,
		// Token: 0x040013D8 RID: 5080
		RecallExploreSkillRouletteNotify = 15696,
		// Token: 0x040013D9 RID: 5081
		RoverRogueTalentUnlockNotify = 22418,
		// Token: 0x040013DA RID: 5082
		RoverRogueTaskUpdateNotify = 24544,
		// Token: 0x040013DB RID: 5083
		DangoBrawlFightActionNotify = 23382,
		// Token: 0x040013DC RID: 5084
		DangoBrawlBagUpdateNotify = 23151,
		// Token: 0x040013DD RID: 5085
		DarkTideExtraBagSyncNotify = 29192,
		// Token: 0x040013DE RID: 5086
		PlayerTitleInfoUpdateNotify = 29816,
		// Token: 0x040013DF RID: 5087
		PlayInstShareFirstInfoNotify = 26879,
		// Token: 0x040013E0 RID: 5088
		RoverRogueResourcesUpdateNotify = 29726,
		// Token: 0x040013E1 RID: 5089
		ZitherPlayNoteNotify = 18156,
		// Token: 0x040013E2 RID: 5090
		ElementalAbilityUpdateNotify = 29547,
		// Token: 0x040013E3 RID: 5091
		QingXiaoTaskUpdateNotify = 21503,
		// Token: 0x040013E4 RID: 5092
		EntityElementalAbilityEnableNotify = 16164,
		// Token: 0x040013E5 RID: 5093
		SheriffZoneItemUpdateNotify = 28846,
		// Token: 0x040013E6 RID: 5094
		DangoBrawlStartFightNotify = 17934,
		// Token: 0x040013E7 RID: 5095
		GiantSystemInfoNotify = 27770,
		// Token: 0x040013E8 RID: 5096
		GiantResponseNotify = 22958,
		// Token: 0x040013E9 RID: 5097
		GiantModelEnableNotify = 29470,
		// Token: 0x040013EA RID: 5098
		GiantEcoUnlockNotify = 27800,
		// Token: 0x040013EB RID: 5099
		CombatValNotify = 28115,
		// Token: 0x040013EC RID: 5100
		CombatValDecayBeginNotify = 19990,
		// Token: 0x040013ED RID: 5101
		DangoBrawlChallengeUnlockNotify = 26771,
		// Token: 0x040013EE RID: 5102
		PlayerHandFoundationCoreChangeNotify = 19181,
		// Token: 0x040013EF RID: 5103
		EntityFoundationCoreChangeNotify = 23251,
		// Token: 0x040013F0 RID: 5104
		TimePointRewardActivityConditionNotify = 26647,
		// Token: 0x040013F1 RID: 5105
		RecallMapMarkInfoNotify = 16779,
		// Token: 0x040013F2 RID: 5106
		DangoBrawlSaveMatchBriefNotify = 26533,
		// Token: 0x040013F3 RID: 5107
		RecallMapMarkUpdateNotify = 16865,
		// Token: 0x040013F4 RID: 5108
		GiantItemUnlockNotify = 18458,
		// Token: 0x040013F5 RID: 5109
		GiantItemAccessUnlockNotify = 22982,
		// Token: 0x040013F6 RID: 5110
		GiantItemAccessProgressChangeNotify = 18717,
		// Token: 0x040013F7 RID: 5111
		GiantTotalStableValueUpdateNotify = 29495,
		// Token: 0x040013F8 RID: 5112
		SquadPropChangedNotify = 21485,
		// Token: 0x040013F9 RID: 5113
		GiantActivityNodeActiveNotify = 26790,
		// Token: 0x040013FA RID: 5114
		DangoBrawlLoseCountUpdateNotify = 16325,
		// Token: 0x040013FB RID: 5115
		RoverRogueShopInfoUpdateNotify = 20174,
		// Token: 0x040013FC RID: 5116
		BanItemUseNotify = 15908,
		// Token: 0x040013FD RID: 5117
		TreasureChestCountNotify = 21988,
		// Token: 0x040013FE RID: 5118
		DangoBrawlItemGiveCoinNotify = 15390,
		// Token: 0x040013FF RID: 5119
		DangoBrawlItemEffectShowNotify = 25822,
		// Token: 0x04001400 RID: 5120
		DangoBrawlActivityLimitCoinUpdateNotify = 27996,
		// Token: 0x04001401 RID: 5121
		TreasureChestCountIncrementNotify = 19516,
		// Token: 0x04001402 RID: 5122
		PhantomEquipGroupInfoNotify = 18815,
		// Token: 0x04001403 RID: 5123
		RecallItemBagObtainNotify = 24789,
		// Token: 0x04001404 RID: 5124
		RecallItemRewardNotify = 22016,
		// Token: 0x04001405 RID: 5125
		FollowerChairPresentationChangeNotify = 15976,
		// Token: 0x04001406 RID: 5126
		RecallInstSaveDataNotify = 18912,
		// Token: 0x04001407 RID: 5127
		GuideGroupResetNotify = 29256,
		// Token: 0x04001408 RID: 5128
		ServerConfigVersionInfoNotify = 19359
	}
}
