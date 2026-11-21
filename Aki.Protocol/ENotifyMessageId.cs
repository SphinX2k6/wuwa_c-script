using System;

namespace Aki.Protocol
{
	// Token: 0x02000008 RID: 8
	public enum ENotifyMessageId
	{
		// Token: 0x04000F96 RID: 3990
		LoginNotify = 109,
		// Token: 0x04000F97 RID: 3991
		LogoutNotify,
		// Token: 0x04000F98 RID: 3992
		PushDataCompleteNotify = 113,
		// Token: 0x04000F99 RID: 3993
		SwitchNodeNotify = 115,
		// Token: 0x04000F9A RID: 3994
		AceAntiDataNotify = 24754,
		// Token: 0x04000F9B RID: 3995
		AchievementProgressNotify = 29757,
		// Token: 0x04000F9C RID: 3996
		AchievementListProgressNotify = 29111,
		// Token: 0x04000F9D RID: 3997
		AchievementGroupProgressNotify = 18514,
		// Token: 0x04000F9E RID: 3998
		ActionNotify = 27631,
		// Token: 0x04000F9F RID: 3999
		ActionErrorCodeNotify = 21270,
		// Token: 0x04000FA0 RID: 4000
		OperationRestrictionNotify = 15930,
		// Token: 0x04000FA1 RID: 4001
		ActivityUpdateNotify = 17864,
		// Token: 0x04000FA2 RID: 4002
		ActivityDisableNotify = 18605,
		// Token: 0x04000FA3 RID: 4003
		SignActivitySignStateNotify = 27234,
		// Token: 0x04000FA4 RID: 4004
		SignActivityKeepTimeNotify = 16823,
		// Token: 0x04000FA5 RID: 4005
		HarvestActivityPointNotify = 23843,
		// Token: 0x04000FA6 RID: 4006
		HarvestActivityLevelNotify = 22145,
		// Token: 0x04000FA7 RID: 4007
		HarvestActivityResultNotify = 22031,
		// Token: 0x04000FA8 RID: 4008
		PhantomCollectUpdateNotify = 23250,
		// Token: 0x04000FA9 RID: 4009
		AdventureUpdateNotify = 22975,
		// Token: 0x04000FAA RID: 4010
		SlientFirstAwardNotify = 17464,
		// Token: 0x04000FAB RID: 4011
		UpdateMonsterUnlockNotify = 17351,
		// Token: 0x04000FAC RID: 4012
		FollowDetectionTargetUpdateNotify = 17471,
		// Token: 0x04000FAD RID: 4013
		AddUnlockedGuideNotify = 28351,
		// Token: 0x04000FAE RID: 4014
		AddUnlockedDetectionTextNotify = 17144,
		// Token: 0x04000FAF RID: 4015
		AdviceSettingNotify = 22745,
		// Token: 0x04000FB0 RID: 4016
		AdviceContentUpdateNotify = 16880,
		// Token: 0x04000FB1 RID: 4017
		AdviceVoteUpdateNotify = 15493,
		// Token: 0x04000FB2 RID: 4018
		AdviceUpdateNotify = 21702,
		// Token: 0x04000FB3 RID: 4019
		AiInformationNotify = 26510,
		// Token: 0x04000FB4 RID: 4020
		AiBlackboardCdNotify = 26019,
		// Token: 0x04000FB5 RID: 4021
		AiHateNotify = 17752,
		// Token: 0x04000FB6 RID: 4022
		AiControlSwitchNotify = 16041,
		// Token: 0x04000FB7 RID: 4023
		PreAiControlSwitchNotify = 29939,
		// Token: 0x04000FB8 RID: 4024
		BanChatNotify = 23415,
		// Token: 0x04000FB9 RID: 4025
		PlayerRenameNotify = 16634,
		// Token: 0x04000FBA RID: 4026
		BasicInfoNotify = 21993,
		// Token: 0x04000FBB RID: 4027
		UnlockHeadPhotoNotify = 23177,
		// Token: 0x04000FBC RID: 4028
		UnlockHeadFrameNotify = 19052,
		// Token: 0x04000FBD RID: 4029
		HeadIdUpdateNotify = 24865,
		// Token: 0x04000FBE RID: 4030
		RoleShowListUpdateNotify = 27858,
		// Token: 0x04000FBF RID: 4031
		UnlockCardNotify = 22072,
		// Token: 0x04000FC0 RID: 4032
		BattlePassPaidNotify = 17219,
		// Token: 0x04000FC1 RID: 4033
		BattlePassExpUpdateNotify = 20892,
		// Token: 0x04000FC2 RID: 4034
		BattlePassTaskUpdateNotify = 17567,
		// Token: 0x04000FC3 RID: 4035
		BehaviorTreeInfoNotify = 16786,
		// Token: 0x04000FC4 RID: 4036
		BehaviorTreeDeleteNotify = 28831,
		// Token: 0x04000FC5 RID: 4037
		UpdateNodeProgressNotify = 21488,
		// Token: 0x04000FC6 RID: 4038
		UpdateChildQuestNodeStatusNotify = 22070,
		// Token: 0x04000FC7 RID: 4039
		UpdateNodeStatusNotify = 23007,
		// Token: 0x04000FC8 RID: 4040
		BtSuspendNotify = 29172,
		// Token: 0x04000FC9 RID: 4041
		OccupationInfoNotify = 16517,
		// Token: 0x04000FCA RID: 4042
		AddOccupationInfoNotify = 19074,
		// Token: 0x04000FCB RID: 4043
		RemoveOccupationInfoNotify = 23251,
		// Token: 0x04000FCC RID: 4044
		TimeOccupationNotify = 17295,
		// Token: 0x04000FCD RID: 4045
		BtRollbackNotify = 18266,
		// Token: 0x04000FCE RID: 4046
		BtRollbackStartNotify = 26088,
		// Token: 0x04000FCF RID: 4047
		BtRollbackInfoNotify = 26092,
		// Token: 0x04000FD0 RID: 4048
		SneakNotify = 20617,
		// Token: 0x04000FD1 RID: 4049
		UpdateTimerInfoNotify = 27863,
		// Token: 0x04000FD2 RID: 4050
		BtVarUpdateNotify = 25834,
		// Token: 0x04000FD3 RID: 4051
		UpdateEnableSystemNotify = 17615,
		// Token: 0x04000FD4 RID: 4052
		WorldBlackboardNotify = 23585,
		// Token: 0x04000FD5 RID: 4053
		EntityBlackboardNotify = 17963,
		// Token: 0x04000FD6 RID: 4054
		RemovePlacementFromBoardNotify = 22490,
		// Token: 0x04000FD7 RID: 4055
		AddPlacementNotify = 19989,
		// Token: 0x04000FD8 RID: 4056
		PlacementInfoChangeNotify = 19545,
		// Token: 0x04000FD9 RID: 4057
		PlaceItemOnBoardNotify = 15283,
		// Token: 0x04000FDA RID: 4058
		CommitBoardSuccessNotify = 21576,
		// Token: 0x04000FDB RID: 4059
		MovePlacementNotify = 21148,
		// Token: 0x04000FDC RID: 4060
		BoardGridDynamicConfigChangeNotify = 23350,
		// Token: 0x04000FDD RID: 4061
		ApplyGameplayEffectNotify = 26040,
		// Token: 0x04000FDE RID: 4062
		RemoveGameplayEffectNotify = 18172,
		// Token: 0x04000FDF RID: 4063
		OrderApplyBuffNotify = 19792,
		// Token: 0x04000FE0 RID: 4064
		OrderRemoveBuffNotify = 20935,
		// Token: 0x04000FE1 RID: 4065
		ApplyBuffS2cRequestNotify = 17614,
		// Token: 0x04000FE2 RID: 4066
		RemoveBuffS2cRequestNotify = 28392,
		// Token: 0x04000FE3 RID: 4067
		RemoveBuffByIdS2cRequestNotify = 25284,
		// Token: 0x04000FE4 RID: 4068
		ActivateBuffNotify = 29719,
		// Token: 0x04000FE5 RID: 4069
		OrderRemoveBuffByTagsNotify = 23871,
		// Token: 0x04000FE6 RID: 4070
		BuffStackCountNotify = 19317,
		// Token: 0x04000FE7 RID: 4071
		BuffItemNotify = 19426,
		// Token: 0x04000FE8 RID: 4072
		BuffItemUpdateNotify = 15200,
		// Token: 0x04000FE9 RID: 4073
		CalabashMsgNotify = 29927,
		// Token: 0x04000FEA RID: 4074
		CalabashExpAddNotify = 20523,
		// Token: 0x04000FEB RID: 4075
		CalabashDevelopRewardUnlockNotify = 17081,
		// Token: 0x04000FEC RID: 4076
		CalabashLevelsRewardNotify = 19440,
		// Token: 0x04000FED RID: 4077
		ChatNotify = 27064,
		// Token: 0x04000FEE RID: 4078
		SysInfoNotify = 23221,
		// Token: 0x04000FEF RID: 4079
		SysErrorNotify = 27956,
		// Token: 0x04000FF0 RID: 4080
		ConsoleNotify = 19286,
		// Token: 0x04000FF1 RID: 4081
		PrivateMessageNotify = 21956,
		// Token: 0x04000FF2 RID: 4082
		PrivateChatHistoryNotify = 16299,
		// Token: 0x04000FF3 RID: 4083
		ChatMutePlayerListNotify = 29806,
		// Token: 0x04000FF4 RID: 4084
		ChannelChatMessageNotify = 19107,
		// Token: 0x04000FF5 RID: 4085
		ChannelChatHistoryNotify = 24562,
		// Token: 0x04000FF6 RID: 4086
		CombatReceivePackNotify = 29973,
		// Token: 0x04000FF7 RID: 4087
		ControlInfoNotify = 22309,
		// Token: 0x04000FF8 RID: 4088
		AddForbidControlNotify = 19356,
		// Token: 0x04000FF9 RID: 4089
		RemoveForbidControlNotify = 25975,
		// Token: 0x04000FFA RID: 4090
		CookingInfoUpdateNotify = 24324,
		// Token: 0x04000FFB RID: 4091
		CookingFormulaUpdateNotify = 28308,
		// Token: 0x04000FFC RID: 4092
		DailyAdventureTaskUpdateNotify = 28227,
		// Token: 0x04000FFD RID: 4093
		DamageRecordNotify = 15583,
		// Token: 0x04000FFE RID: 4094
		GmVoxelInfoNotify = 23572,
		// Token: 0x04000FFF RID: 4095
		GmIsOverlapNotify = 26170,
		// Token: 0x04001000 RID: 4096
		DropInBagNotify = 28463,
		// Token: 0x04001001 RID: 4097
		ElevatorMoveNotify = 19828,
		// Token: 0x04001002 RID: 4098
		EnergyUpdateNotify = 24514,
		// Token: 0x04001003 RID: 4099
		ChangeStateNotify = 19168,
		// Token: 0x04001004 RID: 4100
		ChangeStateConfirmNotify = 27547,
		// Token: 0x04001005 RID: 4101
		FsmResetNotify = 28366,
		// Token: 0x04001006 RID: 4102
		FsmBlackboardNotify = 21151,
		// Token: 0x04001007 RID: 4103
		FsmCustomBlackboardNotify = 18543,
		// Token: 0x04001008 RID: 4104
		EntityAddNotify = 20302,
		// Token: 0x04001009 RID: 4105
		EntityRemoveNotify = 17927,
		// Token: 0x0400100A RID: 4106
		CommonOrganActionListNotify = 25907,
		// Token: 0x0400100B RID: 4107
		EntranceStateNotify = 25612,
		// Token: 0x0400100C RID: 4108
		LogicStateInitNotify = 16553,
		// Token: 0x0400100D RID: 4109
		SwitchLogicStateNotify = 25764,
		// Token: 0x0400100E RID: 4110
		AnimationGameplayTagNotify = 17808,
		// Token: 0x0400100F RID: 4111
		AnimalDieNotify = 24686,
		// Token: 0x04001010 RID: 4112
		EntityStateReadyNotify = 27022,
		// Token: 0x04001011 RID: 4113
		EntityAddDynamicInteractNotify = 17186,
		// Token: 0x04001012 RID: 4114
		EntityChangeDynamicInteractTextNotify = 25073,
		// Token: 0x04001013 RID: 4115
		EntityRemoveDynamicInteractNotify = 18312,
		// Token: 0x04001014 RID: 4116
		EntityInteractingNotify = 17894,
		// Token: 0x04001015 RID: 4117
		EntityAddBubbleNotify = 22334,
		// Token: 0x04001016 RID: 4118
		EntityRemoveBubbleNotify = 21182,
		// Token: 0x04001017 RID: 4119
		BoneVisibleChangeNotify = 29713,
		// Token: 0x04001018 RID: 4120
		EntityEquipChangeNotify = 27672,
		// Token: 0x04001019 RID: 4121
		EntityStaticHookMoveNotify = 26154,
		// Token: 0x0400101A RID: 4122
		SilenceNpcNotify = 17104,
		// Token: 0x0400101B RID: 4123
		ExploreLevelNotify = 24649,
		// Token: 0x0400101C RID: 4124
		ExploreToolUpdateNotify = 26462,
		// Token: 0x0400101D RID: 4125
		ExploreToolAllNotify = 23555,
		// Token: 0x0400101E RID: 4126
		ExploreSkillRouletteUpdateNotify = 25728,
		// Token: 0x0400101F RID: 4127
		VisionExploreSkillNotify = 17772,
		// Token: 0x04001020 RID: 4128
		ExploreToolAuthorizationNotify = 16622,
		// Token: 0x04001021 RID: 4129
		RoleFavorListNotify = 29381,
		// Token: 0x04001022 RID: 4130
		RoleFavorActiveNotify = 18931,
		// Token: 0x04001023 RID: 4131
		RoleFavorLevelUpdateNotify = 18110,
		// Token: 0x04001024 RID: 4132
		RoleFavorNewCanUnLockNotify = 24807,
		// Token: 0x04001025 RID: 4133
		RoleFavorExpTipsNotify = 18293,
		// Token: 0x04001026 RID: 4134
		RoleFavorFinishConditionNotify = 25609,
		// Token: 0x04001027 RID: 4135
		RoleFavorNewQuestUpdateNotify = 26296,
		// Token: 0x04001028 RID: 4136
		RoleMotionNewCanUnLockNotify = 29340,
		// Token: 0x04001029 RID: 4137
		RoleMotionActiveNotify = 23591,
		// Token: 0x0400102A RID: 4138
		RoleMotionListNotify = 16046,
		// Token: 0x0400102B RID: 4139
		RoleMotionFinishConditionNotify = 25957,
		// Token: 0x0400102C RID: 4140
		SkillNotify = 19915,
		// Token: 0x0400102D RID: 4141
		UseSkillNotify = 19813,
		// Token: 0x0400102E RID: 4142
		EndSkillNotify = 27580,
		// Token: 0x0400102F RID: 4143
		HitNotify = 20656,
		// Token: 0x04001030 RID: 4144
		CaughtNotify = 29446,
		// Token: 0x04001031 RID: 4145
		CreateBulletNotify = 15915,
		// Token: 0x04001032 RID: 4146
		DestroyBulletNotify = 16659,
		// Token: 0x04001033 RID: 4147
		ModifyBulletParamsNotify = 28690,
		// Token: 0x04001034 RID: 4148
		DamageExecuteNotify = 28829,
		// Token: 0x04001035 RID: 4149
		PassiveSkillAddNotify = 25025,
		// Token: 0x04001036 RID: 4150
		PassiveSkillRemoveNotify = 21248,
		// Token: 0x04001037 RID: 4151
		SwitchBattleModeNotify = 24840,
		// Token: 0x04001038 RID: 4152
		BattleLogNotify = 19877,
		// Token: 0x04001039 RID: 4153
		EntityIsVisibleNotify = 27390,
		// Token: 0x0400103A RID: 4154
		ActorVisibleNotify = 29002,
		// Token: 0x0400103B RID: 4155
		SwitchCharacterStateNotify = 17711,
		// Token: 0x0400103C RID: 4156
		BattleStateChangeNotify = 17671,
		// Token: 0x0400103D RID: 4157
		MontagePlayNotify = 19227,
		// Token: 0x0400103E RID: 4158
		ANStartNotify = 16944,
		// Token: 0x0400103F RID: 4159
		CharacterBattleStateChangeNotify = 16199,
		// Token: 0x04001040 RID: 4160
		PlayerBattleStateChangeNotify = 15313,
		// Token: 0x04001041 RID: 4161
		ShieldUpdateNotify = 27866,
		// Token: 0x04001042 RID: 4162
		SwitchRoleNotify = 26835,
		// Token: 0x04001043 RID: 4163
		DieSwitchRoleNotify = 23281,
		// Token: 0x04001044 RID: 4164
		UpdateFormationNotify = 20593,
		// Token: 0x04001045 RID: 4165
		FormationAutoAddRoleNotify = 28861,
		// Token: 0x04001046 RID: 4166
		FormationUpdateNotify = 19741,
		// Token: 0x04001047 RID: 4167
		FlowStartNotify = 25049,
		// Token: 0x04001048 RID: 4168
		FlowEndNotify = 29697,
		// Token: 0x04001049 RID: 4169
		FlowShowEntityNotify = 28233,
		// Token: 0x0400104A RID: 4170
		ShowPasserByNpcNotify = 29077,
		// Token: 0x0400104B RID: 4171
		FlowServerSkipNotify = 21217,
		// Token: 0x0400104C RID: 4172
		ForgeItemInfoUpdateNotify = 28572,
		// Token: 0x0400104D RID: 4173
		PbFormationAutoAddRoleNotify = 21027,
		// Token: 0x0400104E RID: 4174
		PhantomFormationChangeNotify = 16773,
		// Token: 0x0400104F RID: 4175
		FriendAddedNotify = 23136,
		// Token: 0x04001050 RID: 4176
		FriendDeletedNotify = 15578,
		// Token: 0x04001051 RID: 4177
		FriendApplyReceivedNotify = 17101,
		// Token: 0x04001052 RID: 4178
		FriendApplyDeletedNotify = 18666,
		// Token: 0x04001053 RID: 4179
		FriendRecentlyTeamUpdateNotify = 26784,
		// Token: 0x04001054 RID: 4180
		FuncOpenNotify = 19093,
		// Token: 0x04001055 RID: 4181
		FuncOpenConfirmNotify = 19104,
		// Token: 0x04001056 RID: 4182
		FuncOpenUpdateNotify = 18542,
		// Token: 0x04001057 RID: 4183
		GachaResultNotify = 20485,
		// Token: 0x04001058 RID: 4184
		GatherTaskRecordNotify = 25663,
		// Token: 0x04001059 RID: 4185
		GatherClueInfoNotify = 19010,
		// Token: 0x0400105A RID: 4186
		SubmitItemInfoNotify = 22681,
		// Token: 0x0400105B RID: 4187
		GuideCondDoneNotify = 18752,
		// Token: 0x0400105C RID: 4188
		IllustratedUnlockNotify = 29822,
		// Token: 0x0400105D RID: 4189
		InfluenceInfoUpdateNotify = 26930,
		// Token: 0x0400105E RID: 4190
		InstDataNotify = 18211,
		// Token: 0x0400105F RID: 4191
		UpdateEnterInfoNotify = 24015,
		// Token: 0x04001060 RID: 4192
		InstPlayDataNotify = 18768,
		// Token: 0x04001061 RID: 4193
		InstSettleNotify = 21939,
		// Token: 0x04001062 RID: 4194
		InstResultNotify = 26696,
		// Token: 0x04001063 RID: 4195
		ExchangeRewardInfoNotify = 22486,
		// Token: 0x04001064 RID: 4196
		ExchangeSharedInfoNotify = 23282,
		// Token: 0x04001065 RID: 4197
		InstTimeoutNotify = 27732,
		// Token: 0x04001066 RID: 4198
		ItemRewardNotify = 22096,
		// Token: 0x04001067 RID: 4199
		ItemGiftUseNotify = 18287,
		// Token: 0x04001068 RID: 4200
		NormalItemUpdateNotify = 27265,
		// Token: 0x04001069 RID: 4201
		NormalItemRemoveNotify = 19848,
		// Token: 0x0400106A RID: 4202
		NormalItemAddNotify = 24714,
		// Token: 0x0400106B RID: 4203
		WeaponItemAddNotify = 22519,
		// Token: 0x0400106C RID: 4204
		WeaponItemRemoveNotify = 19935,
		// Token: 0x0400106D RID: 4205
		PhantomItemAddNotify = 25657,
		// Token: 0x0400106E RID: 4206
		PhantomItemRemoveNotify = 15222,
		// Token: 0x0400106F RID: 4207
		ItemFuncValueUpdateNotify = 25472,
		// Token: 0x04001070 RID: 4208
		ItemObtainNotify = 18089,
		// Token: 0x04001071 RID: 4209
		ItemPkgOpenNotify = 17095,
		// Token: 0x04001072 RID: 4210
		ValidTimeItemUpdateNotify = 15855,
		// Token: 0x04001073 RID: 4211
		ValidTimeItemRemoveNotify = 20989,
		// Token: 0x04001074 RID: 4212
		ValidTimeItemAddNotify = 19758,
		// Token: 0x04001075 RID: 4213
		EnterLevelPlayNotify = 28613,
		// Token: 0x04001076 RID: 4214
		LeaveLevelPlayNotify = 25269,
		// Token: 0x04001077 RID: 4215
		LevelPlayInfoNotify = 28525,
		// Token: 0x04001078 RID: 4216
		LevelPlayFirstNotify = 28089,
		// Token: 0x04001079 RID: 4217
		LevelPlayStateNotify = 19272,
		// Token: 0x0400107A RID: 4218
		LevelPlayOpenTimeNotify = 27112,
		// Token: 0x0400107B RID: 4219
		LevelPlayRewardNotify = 25939,
		// Token: 0x0400107C RID: 4220
		LevelPlayRewardCountResetNotify = 24225,
		// Token: 0x0400107D RID: 4221
		LivenessCountUpdateNotify = 22746,
		// Token: 0x0400107E RID: 4222
		LivenessUpdateNotify = 20096,
		// Token: 0x0400107F RID: 4223
		LivenessRefreshNotify = 17669,
		// Token: 0x04001080 RID: 4224
		EquipTakeOnNotify = 25950,
		// Token: 0x04001081 RID: 4225
		LordGymUnlockNotify = 25755,
		// Token: 0x04001082 RID: 4226
		LordGymLevelPlayResultNotify = 17494,
		// Token: 0x04001083 RID: 4227
		MailInfosNotify = 20632,
		// Token: 0x04001084 RID: 4228
		MailDeleteNotify = 29079,
		// Token: 0x04001085 RID: 4229
		MailAddNotify = 21273,
		// Token: 0x04001086 RID: 4230
		MapMarkShowIdInfoUpdateNotify = 16700,
		// Token: 0x04001087 RID: 4231
		MapUnlockFieldNotify = 22762,
		// Token: 0x04001088 RID: 4232
		MapCancelTraceNotify = 17682,
		// Token: 0x04001089 RID: 4233
		MapTraceNotify = 26739,
		// Token: 0x0400108A RID: 4234
		MapMarkInfoNotify = 27725,
		// Token: 0x0400108B RID: 4235
		UnlockMarkNotify = 25945,
		// Token: 0x0400108C RID: 4236
		RemoveMarkInfoNotify = 26990,
		// Token: 0x0400108D RID: 4237
		AddMarkInfoNotify = 19623,
		// Token: 0x0400108E RID: 4238
		StartMatchNotify = 23110,
		// Token: 0x0400108F RID: 4239
		CancelMatchNotify = 18579,
		// Token: 0x04001090 RID: 4240
		MatchFailNotify = 23326,
		// Token: 0x04001091 RID: 4241
		MatchTeamNotify = 25195,
		// Token: 0x04001092 RID: 4242
		MatchConfirmNotify = 29850,
		// Token: 0x04001093 RID: 4243
		MatchingNotify = 20424,
		// Token: 0x04001094 RID: 4244
		MatchTeamStateNotify = 19812,
		// Token: 0x04001095 RID: 4245
		MatchChangeRoleNotify = 24116,
		// Token: 0x04001096 RID: 4246
		MatchChangeReadyNotify = 17363,
		// Token: 0x04001097 RID: 4247
		LeaveMatchTeamNotify = 21476,
		// Token: 0x04001098 RID: 4248
		EnterMatchTeamNotify = 23456,
		// Token: 0x04001099 RID: 4249
		TeamMatchFlagNotify = 15636,
		// Token: 0x0400109A RID: 4250
		TeamMatchInviteNotify = 24663,
		// Token: 0x0400109B RID: 4251
		TeamMatchAcceptInviteNotify = 24254,
		// Token: 0x0400109C RID: 4252
		MatchChangePlayerUiStateNotify = 16156,
		// Token: 0x0400109D RID: 4253
		MessageDecodeFailNotify = 25607,
		// Token: 0x0400109E RID: 4254
		MonsterGachaDataChangeNotify = 15207,
		// Token: 0x0400109F RID: 4255
		MonthCardDailyRewardNotify = 28994,
		// Token: 0x040010A0 RID: 4256
		MonthCardUseNotify = 17882,
		// Token: 0x040010A1 RID: 4257
		NetTestDataNotify = 15406,
		// Token: 0x040010A2 RID: 4258
		NewBieCourseRewardNotify = 18692,
		// Token: 0x040010A3 RID: 4259
		ParkourChallengeOpenNotify = 21077,
		// Token: 0x040010A4 RID: 4260
		ParkourChallengeEndNotify = 21009,
		// Token: 0x040010A5 RID: 4261
		PartComponentInitNotify = 25520,
		// Token: 0x040010A6 RID: 4262
		PartUpdateNotify = 24482,
		// Token: 0x040010A7 RID: 4263
		PayItemSuccessNotify = 25610,
		// Token: 0x040010A8 RID: 4264
		ResetSpecialBonusNotify = 21478,
		// Token: 0x040010A9 RID: 4265
		PayGiftSuccessNotify = 23351,
		// Token: 0x040010AA RID: 4266
		PayShopInfoNotify = 29139,
		// Token: 0x040010AB RID: 4267
		PayShopUnlockNotify = 16644,
		// Token: 0x040010AC RID: 4268
		PayShopDirectBuyNotify = 18553,
		// Token: 0x040010AD RID: 4269
		PayShopConditionFinishNotify = 17751,
		// Token: 0x040010AE RID: 4270
		PhantomEquipInfoNotify = 29430,
		// Token: 0x040010AF RID: 4271
		PhantomItemUpdateNotify = 16679,
		// Token: 0x040010B0 RID: 4272
		RolePhantomPropUpdateNotify = 23146,
		// Token: 0x040010B1 RID: 4273
		PhantomUpdateNotify = 17025,
		// Token: 0x040010B2 RID: 4274
		PhantomSkinAddNotify = 20095,
		// Token: 0x040010B3 RID: 4275
		PhantomUnlockNotify = 27009,
		// Token: 0x040010B4 RID: 4276
		PlayerAttrNotify = 17685,
		// Token: 0x040010B5 RID: 4277
		PassiveSkillNotify = 17786,
		// Token: 0x040010B6 RID: 4278
		PlayerVarNotify = 27186,
		// Token: 0x040010B7 RID: 4279
		PressNotify = 15929,
		// Token: 0x040010B8 RID: 4280
		PressGameNotify = 22674,
		// Token: 0x040010B9 RID: 4281
		FormationAttrNotify = 16879,
		// Token: 0x040010BA RID: 4282
		RecoverPropChangedNotify = 17789,
		// Token: 0x040010BB RID: 4283
		JSPatchNotify = 19879,
		// Token: 0x040010BC RID: 4284
		QuestListNotify = 18320,
		// Token: 0x040010BD RID: 4285
		TraceQuestNotify = 25995,
		// Token: 0x040010BE RID: 4286
		QuestReadyListNotify = 29359,
		// Token: 0x040010BF RID: 4287
		QuestShowListNotify = 24184,
		// Token: 0x040010C0 RID: 4288
		QuestStateUpdateNotify = 25205,
		// Token: 0x040010C1 RID: 4289
		QuestFinishListNotify = 17785,
		// Token: 0x040010C2 RID: 4290
		DailyQuestUnlockAreaNotify = 16310,
		// Token: 0x040010C3 RID: 4291
		DailyQuestStateNotify = 26923,
		// Token: 0x040010C4 RID: 4292
		DailyQuestCancelNotify = 29129,
		// Token: 0x040010C5 RID: 4293
		RoleQuestStateNotify = 15015,
		// Token: 0x040010C6 RID: 4294
		RoleQuestNewUnlockNotify = 16834,
		// Token: 0x040010C7 RID: 4295
		DestroyQuestsNotify = 20252,
		// Token: 0x040010C8 RID: 4296
		AutoQuestNotify = 20792,
		// Token: 0x040010C9 RID: 4297
		QuestRedDotNotify = 19285,
		// Token: 0x040010CA RID: 4298
		ReceiveRechallengeNotify = 29770,
		// Token: 0x040010CB RID: 4299
		InviteRechallengeNotify = 28944,
		// Token: 0x040010CC RID: 4300
		ReceiveRechallengePlayerIdsNotify = 29063,
		// Token: 0x040010CD RID: 4301
		PlayerDeadNotify = 23671,
		// Token: 0x040010CE RID: 4302
		PlayerReviveNotify = 22493,
		// Token: 0x040010CF RID: 4303
		RoguelikeCurrencyNotify = 29861,
		// Token: 0x040010D0 RID: 4304
		RoguelikeCurrencyUpdateNotify = 24300,
		// Token: 0x040010D1 RID: 4305
		RoguelikeInfoNotify = 15467,
		// Token: 0x040010D2 RID: 4306
		RoguelikeChooseDataNotify = 26262,
		// Token: 0x040010D3 RID: 4307
		RoguelikeEventGainNotify = 17169,
		// Token: 0x040010D4 RID: 4308
		RoguelikeResultNotify = 22995,
		// Token: 0x040010D5 RID: 4309
		RoguelikeSubLevelNotify = 29131,
		// Token: 0x040010D6 RID: 4310
		RoguelikeRoomInfoNotify = 18663,
		// Token: 0x040010D7 RID: 4311
		RoguelikeTalentUnlockNotify = 17875,
		// Token: 0x040010D8 RID: 4312
		PbGetRoleListNotify = 23798,
		// Token: 0x040010D9 RID: 4313
		PbRoleActiveNotify = 16014,
		// Token: 0x040010DA RID: 4314
		PbRolePropsNotify = 17579,
		// Token: 0x040010DB RID: 4315
		PbRoleExpNotify = 26249,
		// Token: 0x040010DC RID: 4316
		PbRoleResonLockFinishNotify = 26928,
		// Token: 0x040010DD RID: 4317
		PbRoleScenePropsNotify = 18564,
		// Token: 0x040010DE RID: 4318
		PbRoleSkillLevelNotify = 16361,
		// Token: 0x040010DF RID: 4319
		RoleChangeNameNotify = 27785,
		// Token: 0x040010E0 RID: 4320
		RoleTrialOpenNotify = 17675,
		// Token: 0x040010E1 RID: 4321
		RoleTrialCloseNotify = 16731,
		// Token: 0x040010E2 RID: 4322
		RoleSkillNodeNotify = 24848,
		// Token: 0x040010E3 RID: 4323
		RoleChangeNotify = 18718,
		// Token: 0x040010E4 RID: 4324
		RoleChangeUnlockNotify = 20322,
		// Token: 0x040010E5 RID: 4325
		RoleTrialSettleNotify = 22045,
		// Token: 0x040010E6 RID: 4326
		EntityLivingStatusNotify = 24917,
		// Token: 0x040010E7 RID: 4327
		UpdatePlayerAllFightRoleNotify = 20791,
		// Token: 0x040010E8 RID: 4328
		UpdatePlayersFightRolesInfoNotify = 16745,
		// Token: 0x040010E9 RID: 4329
		UpdatePlayerSingleFightRoleNotify = 28925,
		// Token: 0x040010EA RID: 4330
		ChangePlayerFightRoleNotify = 25527,
		// Token: 0x040010EB RID: 4331
		SceneAreaStateNotify = 15646,
		// Token: 0x040010EC RID: 4332
		HostTeleportUnlockNotify = 25070,
		// Token: 0x040010ED RID: 4333
		HostFogIdUnlockNotify = 21721,
		// Token: 0x040010EE RID: 4334
		SyncSceneTimeNotify = 28973,
		// Token: 0x040010EF RID: 4335
		ChangeSceneModeNotify = 20701,
		// Token: 0x040010F0 RID: 4336
		ScenePlayerOfflineNotify = 21816,
		// Token: 0x040010F1 RID: 4337
		JoinSceneNotify = 20597,
		// Token: 0x040010F2 RID: 4338
		OtherJoinSceneNotify = 22182,
		// Token: 0x040010F3 RID: 4339
		LeaveSceneNotify = 21944,
		// Token: 0x040010F4 RID: 4340
		MovePackageNotify = 17980,
		// Token: 0x040010F5 RID: 4341
		UDPMovePackageNotify = 21168,
		// Token: 0x040010F6 RID: 4342
		MoveSceneItemNotify = 26459,
		// Token: 0x040010F7 RID: 4343
		ChangeMonsterRoleNotify = 22631,
		// Token: 0x040010F8 RID: 4344
		EntityOnLandedNotify = 29646,
		// Token: 0x040010F9 RID: 4345
		AttributeInitNotify = 21138,
		// Token: 0x040010FA RID: 4346
		AttributeChangedNotify = 26859,
		// Token: 0x040010FB RID: 4347
		MonsterLevelNotify = 28638,
		// Token: 0x040010FC RID: 4348
		MonsterLevelArrayNotify = 19542,
		// Token: 0x040010FD RID: 4349
		MonsterAttributeNotify = 25923,
		// Token: 0x040010FE RID: 4350
		MonsterAttributeArrayNotify = 24398,
		// Token: 0x040010FF RID: 4351
		AnimationStateInitNotify = 23601,
		// Token: 0x04001100 RID: 4352
		AnimationStateChangedNotify = 24252,
		// Token: 0x04001101 RID: 4353
		GameplayTagInitNotify = 17191,
		// Token: 0x04001102 RID: 4354
		GameplayTagChangedNotify = 17995,
		// Token: 0x04001103 RID: 4355
		EntityCommonTagNotify = 20031,
		// Token: 0x04001104 RID: 4356
		ChangeControlRoleNotify = 29562,
		// Token: 0x04001105 RID: 4357
		HardnessModeChangedNotify = 22866,
		// Token: 0x04001106 RID: 4358
		SummonEntityNotify = 19653,
		// Token: 0x04001107 RID: 4359
		VisionSkillCallNotify = 23392,
		// Token: 0x04001108 RID: 4360
		InstanceTimerNotify = 15453,
		// Token: 0x04001109 RID: 4361
		UpdateInstanceTimerNotify = 17805,
		// Token: 0x0400110A RID: 4362
		RemoveInstanceTimerNotify = 27135,
		// Token: 0x0400110B RID: 4363
		UpdateInstanceOwnerInfoNotify = 29689,
		// Token: 0x0400110C RID: 4364
		UpdateOwnerMingSuGenNotify = 28808,
		// Token: 0x0400110D RID: 4365
		AddSysBuffNotify = 19225,
		// Token: 0x0400110E RID: 4366
		UpdateSysBuffNotify = 23927,
		// Token: 0x0400110F RID: 4367
		RemoveSysBuffNotify = 23366,
		// Token: 0x04001110 RID: 4368
		SceneDateNotify = 25540,
		// Token: 0x04001111 RID: 4369
		HoldWeaponNotify = 15700,
		// Token: 0x04001112 RID: 4370
		EnterAoiNotify = 20155,
		// Token: 0x04001113 RID: 4371
		AddEntityAoiNotify = 21567,
		// Token: 0x04001114 RID: 4372
		LeaveAoiNotify = 19141,
		// Token: 0x04001115 RID: 4373
		RemoveEntityAoiNotify = 17978,
		// Token: 0x04001116 RID: 4374
		PlayerAoiRangeNotify = 17622,
		// Token: 0x04001117 RID: 4375
		SceneGamePlayInfoNotify = 21532,
		// Token: 0x04001118 RID: 4376
		SceneGamePlayFirstNotify = 21553,
		// Token: 0x04001119 RID: 4377
		SceneGamePlayStatusNotify = 24317,
		// Token: 0x0400111A RID: 4378
		SceneGamePlayScopeNotify = 18816,
		// Token: 0x0400111B RID: 4379
		SceneGamePlayOpenTimeNotify = 17378,
		// Token: 0x0400111C RID: 4380
		ResetLocationForZRangeNotify = 21097,
		// Token: 0x0400111D RID: 4381
		BeControlledPosInFoundationNotify = 23363,
		// Token: 0x0400111E RID: 4382
		BeControlledNotify = 17537,
		// Token: 0x0400111F RID: 4383
		BeControlledShowNotify = 23631,
		// Token: 0x04001120 RID: 4384
		RelationIdNotify = 26419,
		// Token: 0x04001121 RID: 4385
		EntityPosResetNotify = 19731,
		// Token: 0x04001122 RID: 4386
		WeatherNotify = 21865,
		// Token: 0x04001123 RID: 4387
		PlayerRebackSceneNotify = 26270,
		// Token: 0x04001124 RID: 4388
		DrownNotify = 16564,
		// Token: 0x04001125 RID: 4389
		EnableNearbyTrackingNotify = 26906,
		// Token: 0x04001126 RID: 4390
		SceneSubLevelsChangedNotify = 22107,
		// Token: 0x04001127 RID: 4391
		SceneSubLevelsNotify = 21860,
		// Token: 0x04001128 RID: 4392
		SceneLoadingTimeOutNotify = 15159,
		// Token: 0x04001129 RID: 4393
		SceneLoadingFinishNotify = 28319,
		// Token: 0x0400112A RID: 4394
		ResetPointEntityNotify = 29014,
		// Token: 0x0400112B RID: 4395
		SceneTestNotify = 25522,
		// Token: 0x0400112C RID: 4396
		SceneChangeDataLayerNotify = 15688,
		// Token: 0x0400112D RID: 4397
		EntityLoadCompleteNotify = 21435,
		// Token: 0x0400112E RID: 4398
		MaterialNotify = 26008,
		// Token: 0x0400112F RID: 4399
		SceneStepGroupInfoNotify = 17210,
		// Token: 0x04001130 RID: 4400
		SceneStepInfoNotify = 16336,
		// Token: 0x04001131 RID: 4401
		ThrowDamageNotify = 18961,
		// Token: 0x04001132 RID: 4402
		ThrowDamageRecoveryNotify = 29960,
		// Token: 0x04001133 RID: 4403
		SettingNotify = 17038,
		// Token: 0x04001134 RID: 4404
		ShopInfoNotify = 18614,
		// Token: 0x04001135 RID: 4405
		ShopUnlockNotify = 23429,
		// Token: 0x04001136 RID: 4406
		SneakGameStateNotify = 25864,
		// Token: 0x04001137 RID: 4407
		SpecialItemNotify = 20874,
		// Token: 0x04001138 RID: 4408
		SynthesisInfoUpdateNotify = 26909,
		// Token: 0x04001139 RID: 4409
		SynthesisLevelUpdateNotify = 18205,
		// Token: 0x0400113A RID: 4410
		TeleportUpdateNotify = 25294,
		// Token: 0x0400113B RID: 4411
		TeleportNotify = 25575,
		// Token: 0x0400113C RID: 4412
		FallFinishNotify = 22427,
		// Token: 0x0400113D RID: 4413
		TemporaryTeleportAllInfoNotify = 27094,
		// Token: 0x0400113E RID: 4414
		AddTemporaryTeleportInfoNotify = 22362,
		// Token: 0x0400113F RID: 4415
		RemoveTemporaryTeleportNotify = 21656,
		// Token: 0x04001140 RID: 4416
		TemporaryTeleportChangeNotify = 28744,
		// Token: 0x04001141 RID: 4417
		ThirdPartySharedNotify = 17110,
		// Token: 0x04001142 RID: 4418
		TimeCheckNotify = 18938,
		// Token: 0x04001143 RID: 4419
		TowerEndNotify = 28183,
		// Token: 0x04001144 RID: 4420
		TowerFloorUpdateNotify = 17128,
		// Token: 0x04001145 RID: 4421
		TowerDifficultyUpdateNotify = 24752,
		// Token: 0x04001146 RID: 4422
		TowerInfoUpdateNotify = 27219,
		// Token: 0x04001147 RID: 4423
		TutorialUnlockNotify = 25322,
		// Token: 0x04001148 RID: 4424
		VisionSkillChangeNotify = 25196,
		// Token: 0x04001149 RID: 4425
		WeaponAllInfoNotify = 16632,
		// Token: 0x0400114A RID: 4426
		WeaponAddNotify = 20872,
		// Token: 0x0400114B RID: 4427
		WeaponRemoveNotify = 15552,
		// Token: 0x0400114C RID: 4428
		ApplyJoinWorldNotify = 27800,
		// Token: 0x0400114D RID: 4429
		AgreeJoinResultNotify = 21974,
		// Token: 0x0400114E RID: 4430
		ApplyerEnterSceneNotify = 24262,
		// Token: 0x0400114F RID: 4431
		AllApplyJoinNotify = 16708,
		// Token: 0x04001150 RID: 4432
		WorldTeamPlayerInfoChangeNotify = 27539,
		// Token: 0x04001151 RID: 4433
		JoinWorldTeamNotify = 17115,
		// Token: 0x04001152 RID: 4434
		PlayerLeaveWorldTeamNotify = 21585,
		// Token: 0x04001153 RID: 4435
		PlayerEnterWorldTeamNotify = 21617,
		// Token: 0x04001154 RID: 4436
		RobotDestinationNotify = 21753,
		// Token: 0x04001155 RID: 4437
		UpdateWorldTeamPlayerFightInfoNotify = 20243,
		// Token: 0x04001156 RID: 4438
		PlayerNetStateNotify = 25067,
		// Token: 0x04001157 RID: 4439
		PlayerTeleportStateNotify = 27864,
		// Token: 0x04001158 RID: 4440
		SignatureUpdateNotify = 28884,
		// Token: 0x04001159 RID: 4441
		EntityAttachChangeNotify = 26817,
		// Token: 0x0400115A RID: 4442
		BattleScoreNotify = 25993,
		// Token: 0x0400115B RID: 4443
		LongShanStageUpdateNotify = 22723,
		// Token: 0x0400115C RID: 4444
		MultiMapInfoNotify = 20261,
		// Token: 0x0400115D RID: 4445
		UnlockMapBlockNotify = 15704,
		// Token: 0x0400115E RID: 4446
		UnlockMultiMapNotify = 29531,
		// Token: 0x0400115F RID: 4447
		EntityAccessRangeNotify = 23916,
		// Token: 0x04001160 RID: 4448
		PlayerAccessRangeNotify = 24586,
		// Token: 0x04001161 RID: 4449
		TrampleGearTransitionNotify = 28029,
		// Token: 0x04001162 RID: 4450
		PlayerSkillInfoPbNotify = 29311,
		// Token: 0x04001163 RID: 4451
		SwitchSceneGroupNotify = 21909,
		// Token: 0x04001164 RID: 4452
		UpdateSceneGroupDataNotify = 22332,
		// Token: 0x04001165 RID: 4453
		AfterJoinSceneNotify = 28489,
		// Token: 0x04001166 RID: 4454
		AudioStateUpdateNotify = 17667,
		// Token: 0x04001167 RID: 4455
		BossRushResultNotify = 16040,
		// Token: 0x04001168 RID: 4456
		BossRushLevelInfoNotify = 28132,
		// Token: 0x04001169 RID: 4457
		TrackMoonConditionNotify = 23338,
		// Token: 0x0400116A RID: 4458
		EntityVarUpdateNotify = 28972,
		// Token: 0x0400116B RID: 4459
		RoguelikeGainDataUpdateNotify = 22913,
		// Token: 0x0400116C RID: 4460
		OutputDebugInfoNotify = 26742,
		// Token: 0x0400116D RID: 4461
		PhotoMemoryUpdateNotify = 20573,
		// Token: 0x0400116E RID: 4462
		PhotoMemoryCollectNotify = 21614,
		// Token: 0x0400116F RID: 4463
		ChangeSceneModeEndNotify = 17107,
		// Token: 0x04001170 RID: 4464
		SceneItemSetPosSenderNotify = 15429,
		// Token: 0x04001171 RID: 4465
		TrackMoonTargetUpdateNotify = 20094,
		// Token: 0x04001172 RID: 4466
		PlayerLivingStatesNotify = 26412,
		// Token: 0x04001173 RID: 4467
		TrackMoonIllustratedNotify = 28408,
		// Token: 0x04001174 RID: 4468
		BossRushFailResultNotify = 19850,
		// Token: 0x04001175 RID: 4469
		TowerDefenceInfoUpdateNotify = 20433,
		// Token: 0x04001176 RID: 4470
		TowerDefenceInstanceInfoUpdateNotify = 18881,
		// Token: 0x04001177 RID: 4471
		TowerDefencePhantomInfoUpdateNotify = 19510,
		// Token: 0x04001178 RID: 4472
		TowerDefenceEndNotify = 21135,
		// Token: 0x04001179 RID: 4473
		ConnectorConnectEntityNotify = 29082,
		// Token: 0x0400117A RID: 4474
		NameModifyNotify = 26559,
		// Token: 0x0400117B RID: 4475
		FirecrackerEntityCreatedNotify = 27748,
		// Token: 0x0400117C RID: 4476
		PlayerFollowerNotify = 27250,
		// Token: 0x0400117D RID: 4477
		GameplayCueNotify = 21307,
		// Token: 0x0400117E RID: 4478
		TowerDefenceEnterInstNotify = 29765,
		// Token: 0x0400117F RID: 4479
		ServerCommandNotify = 27430,
		// Token: 0x04001180 RID: 4480
		RoguelikeRoleRoomNotify = 26103,
		// Token: 0x04001181 RID: 4481
		SetNpcPerformStateNotify = 16291,
		// Token: 0x04001182 RID: 4482
		BattleAntiCheatingLogNotify = 27447,
		// Token: 0x04001183 RID: 4483
		TimeResetNotify = 19363,
		// Token: 0x04001184 RID: 4484
		ActionOpenSystemBoardNotify = 21125,
		// Token: 0x04001185 RID: 4485
		SceneItemMoveTargetNotify = 22412,
		// Token: 0x04001186 RID: 4486
		TrackMoonRolePropChangeNotify = 27561,
		// Token: 0x04001187 RID: 4487
		CorniceChallengeEndNotify = 18364,
		// Token: 0x04001188 RID: 4488
		QuestChangeTraceNotify = 22862,
		// Token: 0x04001189 RID: 4489
		TrackMoonTokenCoinNotify = 19882,
		// Token: 0x0400118A RID: 4490
		RiskHarvestEndNotify = 25888,
		// Token: 0x0400118B RID: 4491
		RiskHarvestInstUpdateNotify = 18648,
		// Token: 0x0400118C RID: 4492
		RiskHarvestArtifactNotify = 21422,
		// Token: 0x0400118D RID: 4493
		RiskHarvestBuffUpdateNotify = 28221,
		// Token: 0x0400118E RID: 4494
		RiskHarvestBuffUnlockNotify = 16190,
		// Token: 0x0400118F RID: 4495
		BtRangeFailWarningNotify = 22612,
		// Token: 0x04001190 RID: 4496
		BtCancelRangeFailWarningNotify = 29677,
		// Token: 0x04001191 RID: 4497
		RiskHarvestActivityUpdateNotify = 18015,
		// Token: 0x04001192 RID: 4498
		BlackCoastThemeStageUpdateNotify = 25531,
		// Token: 0x04001193 RID: 4499
		PlayerPsnSessionNotify = 15107,
		// Token: 0x04001194 RID: 4500
		PortalReplaceNotify = 28606,
		// Token: 0x04001195 RID: 4501
		FightDataCheckNotify = 22139,
		// Token: 0x04001196 RID: 4502
		TowerDefenceRoleReviveNotify = 18859,
		// Token: 0x04001197 RID: 4503
		TowerDefencePlayerReviveNotify = 29503,
		// Token: 0x04001198 RID: 4504
		LevelPlayerRewardHintNotify = 27910,
		// Token: 0x04001199 RID: 4505
		AppGradeNotify = 26027,
		// Token: 0x0400119A RID: 4506
		LinkingStateNotify = 27470,
		// Token: 0x0400119B RID: 4507
		LinkExitNotify = 16547,
		// Token: 0x0400119C RID: 4508
		RogueWhiteCatDataUpdateNotify = 27640,
		// Token: 0x0400119D RID: 4509
		UpdateEnableFunctionNotify = 21861,
		// Token: 0x0400119E RID: 4510
		InputSettingUpdateNotify = 25153,
		// Token: 0x0400119F RID: 4511
		MapCustomMarkUpdateNotify = 24503,
		// Token: 0x040011A0 RID: 4512
		PayGiftConditionFinishNotify = 23030,
		// Token: 0x040011A1 RID: 4513
		GetDebugInfoNotify = 20169,
		// Token: 0x040011A2 RID: 4514
		TeleportDungeonActionNotify = 25362,
		// Token: 0x040011A3 RID: 4515
		SceneItemAttributeChangeNotify = 17296,
		// Token: 0x040011A4 RID: 4516
		AchievementCountChangeNotify = 20230,
		// Token: 0x040011A5 RID: 4517
		ContextIdNotify = 17290,
		// Token: 0x040011A6 RID: 4518
		ExecuteQteNotify = 24112,
		// Token: 0x040011A7 RID: 4519
		SyncPlayerLocationNotify = 24978,
		// Token: 0x040011A8 RID: 4520
		MailBindInfoNotify = 21177,
		// Token: 0x040011A9 RID: 4521
		PrivateChatClearNotify = 19574,
		// Token: 0x040011AA RID: 4522
		ScratchCardCountInfoNotify = 16808,
		// Token: 0x040011AB RID: 4523
		WeaponSkinAddNotify = 17173,
		// Token: 0x040011AC RID: 4524
		WeaponSkinUnLoadNotify = 17893,
		// Token: 0x040011AD RID: 4525
		ItemRelateFoundationNotify = 19604,
		// Token: 0x040011AE RID: 4526
		VehicleUpdateNotify = 28018,
		// Token: 0x040011AF RID: 4527
		EntityPreloadNotify = 28870,
		// Token: 0x040011B0 RID: 4528
		QuestRollBackEndNotify = 27925,
		// Token: 0x040011B1 RID: 4529
		TreasureBoxSlotAllInfoNotify = 27789,
		// Token: 0x040011B2 RID: 4530
		RogueWhiteCatLimitedUpdateNotify = 28734,
		// Token: 0x040011B3 RID: 4531
		EntityEquipSkinChangeNotify = 17965,
		// Token: 0x040011B4 RID: 4532
		QuestGiveUpNotify = 26304,
		// Token: 0x040011B5 RID: 4533
		BattleScoreEnableNotify = 24023,
		// Token: 0x040011B6 RID: 4534
		ModifyEntityCampNotify = 21724,
		// Token: 0x040011B7 RID: 4535
		AlertAreaNotify = 25643,
		// Token: 0x040011B8 RID: 4536
		AddCombineEntitiesRelationNotify = 24720,
		// Token: 0x040011B9 RID: 4537
		RemoveCombineRelationNotify = 18044,
		// Token: 0x040011BA RID: 4538
		RogueLevelPlayNotify = 29192,
		// Token: 0x040011BB RID: 4539
		ActionRelatedEntityInfoNotify = 24779,
		// Token: 0x040011BC RID: 4540
		GachaNewNotify = 15278,
		// Token: 0x040011BD RID: 4541
		TestDamageRecordNotify = 25211,
		// Token: 0x040011BE RID: 4542
		RogueBossLinkSettleNotify = 19729,
		// Token: 0x040011BF RID: 4543
		RogueBlackFlowerNotify = 24206,
		// Token: 0x040011C0 RID: 4544
		CombatDataMaxNotify = 27399,
		// Token: 0x040011C1 RID: 4545
		MowTowerFirstScoreNotify = 28712,
		// Token: 0x040011C2 RID: 4546
		MowTowerResultNotify = 17664,
		// Token: 0x040011C3 RID: 4547
		RoleSkinUpdateNotify = 26056,
		// Token: 0x040011C4 RID: 4548
		RoleSkinAddNotify = 20442,
		// Token: 0x040011C5 RID: 4549
		SceneItemAiEnableNotify = 26148,
		// Token: 0x040011C6 RID: 4550
		SceneItemAiDisableNotify = 21693,
		// Token: 0x040011C7 RID: 4551
		TeamMatchInviteRetToHostNotify = 15606,
		// Token: 0x040011C8 RID: 4552
		SceneItemAiPatrolPointNotify = 28782,
		// Token: 0x040011C9 RID: 4553
		SceneItemBlackboardNotify = 20724,
		// Token: 0x040011CA RID: 4554
		TeleportDungeonForbidNotify = 28830,
		// Token: 0x040011CB RID: 4555
		EntityGravityUpdateNotify = 26798,
		// Token: 0x040011CC RID: 4556
		MowTowerLevelsInfoUpdateNotify = 16031,
		// Token: 0x040011CD RID: 4557
		VehiclePassengerUpdateNotify = 20875,
		// Token: 0x040011CE RID: 4558
		AnimalCollectStateNotify = 28587,
		// Token: 0x040011CF RID: 4559
		TurntableTaskUpdateNotify = 20220,
		// Token: 0x040011D0 RID: 4560
		MapTravelInfoUpdateNotify = 23579,
		// Token: 0x040011D1 RID: 4561
		ExploreProgressRewardIdsNotify = 25441,
		// Token: 0x040011D2 RID: 4562
		BoardCanMovePlacementNotify = 27769,
		// Token: 0x040011D3 RID: 4563
		FarmGoldResultNotify = 20566,
		// Token: 0x040011D4 RID: 4564
		FarmGoldLevelNotify = 24429,
		// Token: 0x040011D5 RID: 4565
		TeamTeleportStartNotify = 25696,
		// Token: 0x040011D6 RID: 4566
		SplineMoveNotify = 26842,
		// Token: 0x040011D7 RID: 4567
		TeleportVehicleNotify = 22711,
		// Token: 0x040011D8 RID: 4568
		PlayerHeadAddNotify = 29216,
		// Token: 0x040011D9 RID: 4569
		VehicleUpdateEntityNotify = 16415,
		// Token: 0x040011DA RID: 4570
		DetectionPreOpenNotify = 23923,
		// Token: 0x040011DB RID: 4571
		FishingInfoUpdateNotify = 19875,
		// Token: 0x040011DC RID: 4572
		FishingShipInfoUpdateNotify = 16082,
		// Token: 0x040011DD RID: 4573
		FishingTechInfoUpdateNotify = 29078,
		// Token: 0x040011DE RID: 4574
		FishingIllustratedInfoUpdateNotify = 28244,
		// Token: 0x040011DF RID: 4575
		FishingIllustratedRewardInfoUpdateNotify = 26235,
		// Token: 0x040011E0 RID: 4576
		FishingSceneFishCageInfoUpdateNotify = 25515,
		// Token: 0x040011E1 RID: 4577
		SceneFishPointInfoUpdateNotify = 17940,
		// Token: 0x040011E2 RID: 4578
		FishingShipForceBackNotify = 28002,
		// Token: 0x040011E3 RID: 4579
		FishingItemAddNotify = 22817,
		// Token: 0x040011E4 RID: 4580
		FishingNoticeUpdateNotify = 15366,
		// Token: 0x040011E5 RID: 4581
		HookLockPointInfoNotify = 21402,
		// Token: 0x040011E6 RID: 4582
		HandInInfoUpdateNotify = 25098,
		// Token: 0x040011E7 RID: 4583
		RoleSkinTrialSettleNotify = 25987,
		// Token: 0x040011E8 RID: 4584
		BuffDurationNotify = 24676,
		// Token: 0x040011E9 RID: 4585
		TeleportFlowNotify = 27892,
		// Token: 0x040011EA RID: 4586
		FishingEntrustUpdateNotify = 28710,
		// Token: 0x040011EB RID: 4587
		FishingPortUnlockNotify = 23503,
		// Token: 0x040011EC RID: 4588
		RogueWeeklyRoomInfoNotify = 18827,
		// Token: 0x040011ED RID: 4589
		RogueWeeklySubLevelNotify = 21204,
		// Token: 0x040011EE RID: 4590
		RogueWeeklyResultNotify = 19127,
		// Token: 0x040011EF RID: 4591
		SlashAndTowerResultNotify = 24868,
		// Token: 0x040011F0 RID: 4592
		SlashAndTowerLevelPlayNotify = 18154,
		// Token: 0x040011F1 RID: 4593
		SceneTempFishPointInfoUpdateNotify = 16073,
		// Token: 0x040011F2 RID: 4594
		BossRushTaskUpdateNotify = 28139,
		// Token: 0x040011F3 RID: 4595
		CharacterLookAtNotify = 24799,
		// Token: 0x040011F4 RID: 4596
		FishingActivityLimitTaskNotify = 28644,
		// Token: 0x040011F5 RID: 4597
		FishingActivityMileStoneNotify = 19138,
		// Token: 0x040011F6 RID: 4598
		FishingBoatDieNotify = 19589,
		// Token: 0x040011F7 RID: 4599
		TeamParkourTaskNotify = 18720,
		// Token: 0x040011F8 RID: 4600
		TeamParkourSettleNotify = 16281,
		// Token: 0x040011F9 RID: 4601
		RogueWeeklyInstInfoNotify = 15788,
		// Token: 0x040011FA RID: 4602
		ThroughTrainForceRemindNotify = 29505,
		// Token: 0x040011FB RID: 4603
		FishingActivityMilestoneItemNumNotify = 24887,
		// Token: 0x040011FC RID: 4604
		AddHackingEntityNotify = 28303,
		// Token: 0x040011FD RID: 4605
		RemoveHackingEntityNotify = 20772,
		// Token: 0x040011FE RID: 4606
		BossRushSelectBuffNotify = 23543,
		// Token: 0x040011FF RID: 4607
		ActionGroupCreateNotify = 25896,
		// Token: 0x04001200 RID: 4608
		ActionGroupCompleteNotify = 17755,
		// Token: 0x04001201 RID: 4609
		ShopInfoUpdateNotify = 28209,
		// Token: 0x04001202 RID: 4610
		RogueWeeklyCurrencyNotify = 25282,
		// Token: 0x04001203 RID: 4611
		RogueWeeklyCurrencyUpdateNotify = 15390,
		// Token: 0x04001204 RID: 4612
		FishingGhostStateNotify = 15355,
		// Token: 0x04001205 RID: 4613
		FishingSkinUnlockNotify = 18702,
		// Token: 0x04001206 RID: 4614
		BabelActivityLevelInfoNotify = 21440,
		// Token: 0x04001207 RID: 4615
		BabelActivityBuffInfoNotify = 21577,
		// Token: 0x04001208 RID: 4616
		BabelActivityTaskInfoNotify = 21420,
		// Token: 0x04001209 RID: 4617
		BabelActivityDailyTaskInfoNotify = 23786,
		// Token: 0x0400120A RID: 4618
		AddGuestNotify = 15984,
		// Token: 0x0400120B RID: 4619
		RemoveGuestNotify = 18978,
		// Token: 0x0400120C RID: 4620
		BabelActivitySettleInfoNotify = 16355,
		// Token: 0x0400120D RID: 4621
		RogueWeeklyBlackFlowerNotify = 22410,
		// Token: 0x0400120E RID: 4622
		PlayerTitleUpdateNotify = 24894,
		// Token: 0x0400120F RID: 4623
		DressPlayerTitleUpdateNotify = 19561,
		// Token: 0x04001210 RID: 4624
		ReplaceVehicleEntityNotify = 28957,
		// Token: 0x04001211 RID: 4625
		BabelActivityDeTermInfoNotify = 24618,
		// Token: 0x04001212 RID: 4626
		AbyssRoleInfoUpdateNotify = 17390,
		// Token: 0x04001213 RID: 4627
		AbyssPluginItemInfoUpdateNotify = 23091,
		// Token: 0x04001214 RID: 4628
		AbyssRewardsUpdateNotify = 21881,
		// Token: 0x04001215 RID: 4629
		AbyssChallengeUpdateNotify = 20812,
		// Token: 0x04001216 RID: 4630
		AbyssChallengeResultNotify = 27258,
		// Token: 0x04001217 RID: 4631
		AbyssLikeNotify = 22047,
		// Token: 0x04001218 RID: 4632
		AbyssChallengeSubLevelNotify = 18059,
		// Token: 0x04001219 RID: 4633
		AbyssChallengeRoomInfoNotify = 18217,
		// Token: 0x0400121A RID: 4634
		AbyssRoleSelectUpdateNotify = 19763,
		// Token: 0x0400121B RID: 4635
		FishingPortUpdateNotify = 17589,
		// Token: 0x0400121C RID: 4636
		BabelActivityUseReviveCountNotify = 18819,
		// Token: 0x0400121D RID: 4637
		AbyssReviveNotify = 24492,
		// Token: 0x0400121E RID: 4638
		GravityFlipUpdateTypeNotify = 29623,
		// Token: 0x0400121F RID: 4639
		ClientVersionNoMatchNotify = 16267,
		// Token: 0x04001220 RID: 4640
		RacingBetsPlayerInfoUpdateNotify = 24358,
		// Token: 0x04001221 RID: 4641
		FishingNetCabinUpdateNotify = 20945,
		// Token: 0x04001222 RID: 4642
		ExploreActivityTaskInfoNotify = 16491,
		// Token: 0x04001223 RID: 4643
		RacingBetsTaskNotify = 15994,
		// Token: 0x04001224 RID: 4644
		EntityHeadInfoNotify = 19315,
		// Token: 0x04001225 RID: 4645
		RogueResTalentUnlockNotify = 24327,
		// Token: 0x04001226 RID: 4646
		RogueResEndingUpdateNotify = 16750,
		// Token: 0x04001227 RID: 4647
		RogueResTaskUpdateNotify = 24660,
		// Token: 0x04001228 RID: 4648
		RogueResIllustrationUpdateNotify = 24683,
		// Token: 0x04001229 RID: 4649
		BabelActivityInstInfoNotify = 17488,
		// Token: 0x0400122A RID: 4650
		MoveSplineStatusNotify = 17431,
		// Token: 0x0400122B RID: 4651
		AbyssRoleAddNotify = 23255,
		// Token: 0x0400122C RID: 4652
		AbyssPluginItemAddNotify = 15136,
		// Token: 0x0400122D RID: 4653
		AbyssPluginItemRemoveNotify = 25037,
		// Token: 0x0400122E RID: 4654
		AvignonTaskNotify = 21154,
		// Token: 0x0400122F RID: 4655
		RogueResOpDataNotify = 27709,
		// Token: 0x04001230 RID: 4656
		RogueResInstOptionsNotify = 16744,
		// Token: 0x04001231 RID: 4657
		DebugFightErrInfoNotify = 28626,
		// Token: 0x04001232 RID: 4658
		ActionFinishImmediatelyNotify = 24609,
		// Token: 0x04001233 RID: 4659
		SummonRandomNotify = 28895,
		// Token: 0x04001234 RID: 4660
		BabelActivityItemNumUpdateNotify = 28082,
		// Token: 0x04001235 RID: 4661
		H5CircumFluenceActivityDataNotify = 16402,
		// Token: 0x04001236 RID: 4662
		RoleFlyEquipNotify = 21114,
		// Token: 0x04001237 RID: 4663
		RogueResRoomInfoNotify = 28115,
		// Token: 0x04001238 RID: 4664
		RacingBetsSettleNotify = 28131,
		// Token: 0x04001239 RID: 4665
		RogueResCurrencyNotify = 29934,
		// Token: 0x0400123A RID: 4666
		RogueResCurrencyUpdateNotify = 20861,
		// Token: 0x0400123B RID: 4667
		RogueResInstGlobalDataNotify = 25331,
		// Token: 0x0400123C RID: 4668
		RogueResGridDataUpdateNotify = 28389,
		// Token: 0x0400123D RID: 4669
		RogueResGainDataTotalNotify = 19437,
		// Token: 0x0400123E RID: 4670
		RogueResGainDataUpdateNotify = 29404,
		// Token: 0x0400123F RID: 4671
		RoleFlyEquipChangeNotify = 19754,
		// Token: 0x04001240 RID: 4672
		AbyssReviveTimeNotify = 26847,
		// Token: 0x04001241 RID: 4673
		DangoMonopolyTaskUpdateNotify = 22180,
		// Token: 0x04001242 RID: 4674
		RogueResPlayerStatusUpdateNotify = 23230,
		// Token: 0x04001243 RID: 4675
		RogueResFovUpdateNotify = 17242,
		// Token: 0x04001244 RID: 4676
		RogueResMoodUpdateNotify = 26318,
		// Token: 0x04001245 RID: 4677
		DangoMonopolySceneGridInfoNotify = 23339,
		// Token: 0x04001246 RID: 4678
		RogueResOpDataUpdateNotify = 29300,
		// Token: 0x04001247 RID: 4679
		EntityFlyEquipChangeNotify = 16196,
		// Token: 0x04001248 RID: 4680
		FlyEquipAddNotify = 21836,
		// Token: 0x04001249 RID: 4681
		NewLinkNotify = 21875,
		// Token: 0x0400124A RID: 4682
		ChapterUpdateNotify = 25234,
		// Token: 0x0400124B RID: 4683
		InspirationUpdateNotify = 20356,
		// Token: 0x0400124C RID: 4684
		ScheduleRewardUpdateNotify = 18703,
		// Token: 0x0400124D RID: 4685
		ActivityResultUpdateNotify = 22938,
		// Token: 0x0400124E RID: 4686
		CiacconaActivityStateUnlockUpdateNotify = 17332,
		// Token: 0x0400124F RID: 4687
		RogueResInstOptionsUpdateNotify = 28509,
		// Token: 0x04001250 RID: 4688
		RogueResElementUpdateNotify = 27121,
		// Token: 0x04001251 RID: 4689
		RacingBetLegMatchResultNotify = 29552,
		// Token: 0x04001252 RID: 4690
		RogueResTeamLevelUpdateNotify = 18322,
		// Token: 0x04001253 RID: 4691
		ConfirmResourceQuestNotify = 18602,
		// Token: 0x04001254 RID: 4692
		WaitQuestConfirmResourceNotify = 29463,
		// Token: 0x04001255 RID: 4693
		DetectionInvisibleNotify = 15166,
		// Token: 0x04001256 RID: 4694
		PlayerGravityUpdateNotify = 23394,
		// Token: 0x04001257 RID: 4695
		DangoMonopolyTaskAddNotify = 18048,
		// Token: 0x04001258 RID: 4696
		DangoMonopolyTaskRemoveNotify = 22199,
		// Token: 0x04001259 RID: 4697
		RogueResRoleBondUpdateNotify = 21609,
		// Token: 0x0400125A RID: 4698
		RogueResTotalShopItemUpdateNotify = 29902,
		// Token: 0x0400125B RID: 4699
		SystemMarkHideInfoNotify = 19492,
		// Token: 0x0400125C RID: 4700
		PhantomBattleChallengeInfoUpdateNotify = 17529,
		// Token: 0x0400125D RID: 4701
		PhantomBattleTaskInfoNotify = 29022,
		// Token: 0x0400125E RID: 4702
		PhantomBattleMasterInfoNotify = 21654,
		// Token: 0x0400125F RID: 4703
		PhantomBattleBadgeInfoUpdateNotify = 20719,
		// Token: 0x04001260 RID: 4704
		PhantomBattleBadgeRewardInfoUpdateNotify = 20290,
		// Token: 0x04001261 RID: 4705
		PhantomBattleCardInfoUpdateNotify = 26022,
		// Token: 0x04001262 RID: 4706
		PhantomBattleCardRewardInfoUpdateNotify = 18519,
		// Token: 0x04001263 RID: 4707
		PhantomBattleRoleInfoUpdateNotify = 20429,
		// Token: 0x04001264 RID: 4708
		PhantomBattleCardGroupInfoNotify = 17347,
		// Token: 0x04001265 RID: 4709
		PhantomBattleBoardInfoNotify = 18147,
		// Token: 0x04001266 RID: 4710
		PhantomBattleHandCardInfoUpdateNotify = 28224,
		// Token: 0x04001267 RID: 4711
		PhantomBattleDealCardNotify = 15397,
		// Token: 0x04001268 RID: 4712
		PhantomBattleDealCardReplaceNotify = 23835,
		// Token: 0x04001269 RID: 4713
		PhantomBattleRoundChangeNotify = 19265,
		// Token: 0x0400126A RID: 4714
		BirthDayInfoNotify = 20525,
		// Token: 0x0400126B RID: 4715
		EntityRewardItemNotify = 29972,
		// Token: 0x0400126C RID: 4716
		DangoMonopolyRewardNotify = 18485,
		// Token: 0x0400126D RID: 4717
		ApplyBuffFailedNotify = 19969,
		// Token: 0x0400126E RID: 4718
		ConsumptiveTaskInfoNotify = 22181,
		// Token: 0x0400126F RID: 4719
		TemplateEntitySpawnerContentNotify = 18989,
		// Token: 0x04001270 RID: 4720
		NpcPhantomBattleFightInfoNotify = 21331,
		// Token: 0x04001271 RID: 4721
		PhantomBattleDeployNotify = 25628,
		// Token: 0x04001272 RID: 4722
		PhantomBattleGamerStatusInfoNotify = 22067,
		// Token: 0x04001273 RID: 4723
		PhantomBattleCardAttrInfoNotify = 27398,
		// Token: 0x04001274 RID: 4724
		PhantomBattleSelectTargetEffectNotify = 21545,
		// Token: 0x04001275 RID: 4725
		PhantomBattleSkillTriggerInfoNotify = 29886,
		// Token: 0x04001276 RID: 4726
		PhantomBattleBuffTriggerInfoNotify = 21641,
		// Token: 0x04001277 RID: 4727
		InstSaveDataNotify = 21061,
		// Token: 0x04001278 RID: 4728
		RogueResMoodRangeUpdateNotify = 19251,
		// Token: 0x04001279 RID: 4729
		MoraleInfoNotify = 21439,
		// Token: 0x0400127A RID: 4730
		QuestFocusInfoNotify = 16030,
		// Token: 0x0400127B RID: 4731
		PhantomBattleBvBLoadingNotify = 21837,
		// Token: 0x0400127C RID: 4732
		PhantomBattleBvBFightNotify = 19494,
		// Token: 0x0400127D RID: 4733
		PhantomBattleBvBSettleNotify = 21619,
		// Token: 0x0400127E RID: 4734
		DirectTrainPreOpenCloseNotify = 24510,
		// Token: 0x0400127F RID: 4735
		PhantomBattleBoardSettleNotify = 19126,
		// Token: 0x04001280 RID: 4736
		DebugDrawPosNotify = 20580,
		// Token: 0x04001281 RID: 4737
		RacingBetLegMatchSettleNotify = 27991,
		// Token: 0x04001282 RID: 4738
		PhantomBattleAddBuffInfoNotify = 22993,
		// Token: 0x04001283 RID: 4739
		DirectTrainInfoNotify = 28851,
		// Token: 0x04001284 RID: 4740
		PhantomBattleDiscardCardNotify = 27588,
		// Token: 0x04001285 RID: 4741
		PhantomBattleFourCTaskInfoUpdateNotify = 26498,
		// Token: 0x04001286 RID: 4742
		PhantomBattleFourCTaskDealCardNotify = 20251,
		// Token: 0x04001287 RID: 4743
		SlashAndTowerOverNotify = 17309,
		// Token: 0x04001288 RID: 4744
		QuestReviewInfoNotify = 25208,
		// Token: 0x04001289 RID: 4745
		NewbieCarnivalTaskDataUpdateNotify = 23985,
		// Token: 0x0400128A RID: 4746
		TimeLockInfoNotify = 16370,
		// Token: 0x0400128B RID: 4747
		PhantomBattleCardUpdateNotify = 15912,
		// Token: 0x0400128C RID: 4748
		NewbieCarnivalTaskJumpUpdateNotify = 26302,
		// Token: 0x0400128D RID: 4749
		StartSetQuestFocusNotify = 28873,
		// Token: 0x0400128E RID: 4750
		PhantomBattleCardPosChangeNotify = 23839,
		// Token: 0x0400128F RID: 4751
		RogueResFormationUpdateNotify = 28455,
		// Token: 0x04001290 RID: 4752
		PhantomBattleChallengeUpdateNotify = 27137,
		// Token: 0x04001291 RID: 4753
		FloroRanchUpdatePlayerInfoNotify = 23957,
		// Token: 0x04001292 RID: 4754
		ActionOperationScreenNotify = 16381,
		// Token: 0x04001293 RID: 4755
		PhantomBattleSelectReserveCardNotify = 19284,
		// Token: 0x04001294 RID: 4756
		PhantomBattleBurnBuffNotify = 18581,
		// Token: 0x04001295 RID: 4757
		LifePointChallengeUpdateNotify = 21262,
		// Token: 0x04001296 RID: 4758
		TestCmdNotify = 20443,
		// Token: 0x04001297 RID: 4759
		ShopBuyNotify = 16134,
		// Token: 0x04001298 RID: 4760
		QuestLockInfoNotify = 17725,
		// Token: 0x04001299 RID: 4761
		GridCellUpdateNotify = 28675,
		// Token: 0x0400129A RID: 4762
		InteractQuestSuspendEntityNotify = 22595,
		// Token: 0x0400129B RID: 4763
		FloroRanchPlayGmInfoUpdateNotify = 26408,
		// Token: 0x0400129C RID: 4764
		ResetQuestFocusModeNotify = 25104,
		// Token: 0x0400129D RID: 4765
		TrapDefensePreviewStartNotify = 23247,
		// Token: 0x0400129E RID: 4766
		RoleGoDownNotify = 19940,
		// Token: 0x0400129F RID: 4767
		StopHoldHandNotify = 16932,
		// Token: 0x040012A0 RID: 4768
		LowMemoryChangeSceneStartNotify = 25971,
		// Token: 0x040012A1 RID: 4769
		TrapDefenseRewardGainingGroupsNotify = 22298,
		// Token: 0x040012A2 RID: 4770
		TrapDefenseSyncGainingGroupsNotify = 25763,
		// Token: 0x040012A3 RID: 4771
		SimpleCombatEntityBuffUpdateNotify = 18273,
		// Token: 0x040012A4 RID: 4772
		TrapDefenseSystemInfoNotify = 23974,
		// Token: 0x040012A5 RID: 4773
		ItemPkgFullNotify = 15052,
		// Token: 0x040012A6 RID: 4774
		TrapDefenseChallengeUpdateNotify = 16595,
		// Token: 0x040012A7 RID: 4775
		TrapDefenseRewardUpdateNotify = 20145,
		// Token: 0x040012A8 RID: 4776
		TrapDefenseSpecialRewardUpdateNotify = 21344,
		// Token: 0x040012A9 RID: 4777
		TrapDefenseDevelopInfoUpdateNotify = 16748,
		// Token: 0x040012AA RID: 4778
		TrapDefenseTechUpdateNotify = 29048,
		// Token: 0x040012AB RID: 4779
		FunPlayChallengeInfoUpdateNotify = 28208,
		// Token: 0x040012AC RID: 4780
		FunPlayChallengeSettleNotify = 17763,
		// Token: 0x040012AD RID: 4781
		TrapDefenseChallengeResultNotify = 27045,
		// Token: 0x040012AE RID: 4782
		TrapDefenseStepUpdateNotify = 23425,
		// Token: 0x040012AF RID: 4783
		TrapDefenseSystemInfoUpdateNotify = 18546,
		// Token: 0x040012B0 RID: 4784
		TrapDefenseSpawnMonsterWaveEndNotify = 26815,
		// Token: 0x040012B1 RID: 4785
		TrapDefenseMonsterConsecutiveKillsNotify = 19577,
		// Token: 0x040012B2 RID: 4786
		TrapDefenseBdUpdateNotify = 15259,
		// Token: 0x040012B3 RID: 4787
		SimpleCombatEntitySubTypeChangeNotify = 25732,
		// Token: 0x040012B4 RID: 4788
		TrapDefenseEntityDataChangeNotify = 18208,
		// Token: 0x040012B5 RID: 4789
		TrapDefenseTechPointUpdateNotify = 15898,
		// Token: 0x040012B6 RID: 4790
		CommonUiSettingNotify = 16208,
		// Token: 0x040012B7 RID: 4791
		TrapDefenseItemUpdateNotify = 26436,
		// Token: 0x040012B8 RID: 4792
		LineCrossActivityUpdateNotify = 27261,
		// Token: 0x040012B9 RID: 4793
		TrapDefenseGainingGroupUpdateNotify = 21410,
		// Token: 0x040012BA RID: 4794
		PhotoFightResultNotify = 17633,
		// Token: 0x040012BB RID: 4795
		PhotoFightLevelInfoNotify = 18787,
		// Token: 0x040012BC RID: 4796
		SimpleCombatEntityBuffLayerCountNotify = 29187,
		// Token: 0x040012BD RID: 4797
		EntityCalabashSkinChangeNotify = 25793,
		// Token: 0x040012BE RID: 4798
		SurvivorsOpDataUpdateNotify = 20390,
		// Token: 0x040012BF RID: 4799
		SurvivorsOpDataForceChangeNotify = 20232,
		// Token: 0x040012C0 RID: 4800
		SurvivorsGainDataUpdateNotify = 28759,
		// Token: 0x040012C1 RID: 4801
		SurvivorsInstGlobalDataNotify = 28285,
		// Token: 0x040012C2 RID: 4802
		SurvivorsStepUpdateNotify = 24499,
		// Token: 0x040012C3 RID: 4803
		QuestTreeInfoNotify = 24869,
		// Token: 0x040012C4 RID: 4804
		CalabashSkinTakeOnNotify = 22784,
		// Token: 0x040012C5 RID: 4805
		CalabashSkinUpdateNotify = 18523,
		// Token: 0x040012C6 RID: 4806
		YuXueModeInfoNotify = 19246,
		// Token: 0x040012C7 RID: 4807
		TrapDefenseBdGroupUnlockNotify = 28407,
		// Token: 0x040012C8 RID: 4808
		SurvivorsSpawnMonsterWaveEndNotify = 21452,
		// Token: 0x040012C9 RID: 4809
		SurvivorsMonsterConsecutiveKillsNotify = 26546,
		// Token: 0x040012CA RID: 4810
		SurvivorsVarRecordNotify = 20648,
		// Token: 0x040012CB RID: 4811
		SurvivorsTaskDataUpdateNotify = 26512,
		// Token: 0x040012CC RID: 4812
		SurvivorsHandBooskUnlockNotify = 25363,
		// Token: 0x040012CD RID: 4813
		SurvivorsTalentUnlockNotify = 26156,
		// Token: 0x040012CE RID: 4814
		SurvivorsChallengeInfoUpdateNotify = 17917,
		// Token: 0x040012CF RID: 4815
		WeaponSkinUpdateNotify = 20115,
		// Token: 0x040012D0 RID: 4816
		RoleSkinChangeNotify = 16509,
		// Token: 0x040012D1 RID: 4817
		PlayerHeadUpdateNotify = 26848,
		// Token: 0x040012D2 RID: 4818
		RoleUpdateDevelopTargetNotify = 29070,
		// Token: 0x040012D3 RID: 4819
		InfrFireAddNotify = 18395,
		// Token: 0x040012D4 RID: 4820
		InfrRoadUpdateNotify = 23036,
		// Token: 0x040012D5 RID: 4821
		CharacterMoveToPointNotify = 29143,
		// Token: 0x040012D6 RID: 4822
		InfrFireUpdateNotify = 18262,
		// Token: 0x040012D7 RID: 4823
		PackAnimChangedNotify = 23124,
		// Token: 0x040012D8 RID: 4824
		RogueWeeklyInteractionResultNotify = 25625,
		// Token: 0x040012D9 RID: 4825
		HonamiStoryLimitTaskInfoUpdateNotify = 22327,
		// Token: 0x040012DA RID: 4826
		HonamiStoryAreaTaskInfoRefreshNotify = 26269,
		// Token: 0x040012DB RID: 4827
		HonamiStoryAreaTaskInfoUpdateNotify = 25370,
		// Token: 0x040012DC RID: 4828
		HonamiStoryBagInfoUpdateNotify = 23184,
		// Token: 0x040012DD RID: 4829
		HonamiStoryRoleUpdateNotify = 17089,
		// Token: 0x040012DE RID: 4830
		HonamiStoryAddWeaponNotify = 23284,
		// Token: 0x040012DF RID: 4831
		HonamiStoryItemCollectionInfoUpdateNotify = 16250,
		// Token: 0x040012E0 RID: 4832
		HonamiStoryMascotInfoUpdateNotify = 22035,
		// Token: 0x040012E1 RID: 4833
		HonamiStoryAreaInfoUpdateNotify = 15296,
		// Token: 0x040012E2 RID: 4834
		HonamiStoryInstInfoNotify = 17000,
		// Token: 0x040012E3 RID: 4835
		HonamiStoryPollutionUpdateNotify = 21640,
		// Token: 0x040012E4 RID: 4836
		HonamiStoryInstSettleNotify = 23167,
		// Token: 0x040012E5 RID: 4837
		HonamiStoryInstTopTowerSettleNotify = 24069,
		// Token: 0x040012E6 RID: 4838
		HonamiStorySafeLeaveNotify = 17990,
		// Token: 0x040012E7 RID: 4839
		HonamiStoryPollutionBoxSteadyLimitNotify = 17818,
		// Token: 0x040012E8 RID: 4840
		HonamiStoryScoreRewardInfoUpdateNotify = 18607,
		// Token: 0x040012E9 RID: 4841
		EntityHonamiStoryEnhanceLevelNotify = 16677,
		// Token: 0x040012EA RID: 4842
		SunSpiritListNotify = 15581,
		// Token: 0x040012EB RID: 4843
		SunSpiritCollectNotify = 27484,
		// Token: 0x040012EC RID: 4844
		SunSpiritUpdateNotify = 28796,
		// Token: 0x040012ED RID: 4845
		RollBlockOpenGamePlayNotify = 15482,
		// Token: 0x040012EE RID: 4846
		RollBlockCloseGamePlayNotify = 21222,
		// Token: 0x040012EF RID: 4847
		RollBlockSyncInfoNotify = 29588,
		// Token: 0x040012F0 RID: 4848
		HonamiStoryLimitShopConsumeNumNotify = 16893,
		// Token: 0x040012F1 RID: 4849
		SurvivorsComboParamUpdateNotify = 20928,
		// Token: 0x040012F2 RID: 4850
		SunSpiritActionOperationNotify = 15928,
		// Token: 0x040012F3 RID: 4851
		HonamiStoryBagSizeUpdateNotify = 24747,
		// Token: 0x040012F4 RID: 4852
		MotorTaskInfoNotify = 22808,
		// Token: 0x040012F5 RID: 4853
		PhantomInteractionInfoUpdateNotify = 29193,
		// Token: 0x040012F6 RID: 4854
		PhantomInteractionUnlockNotify = 23244,
		// Token: 0x040012F7 RID: 4855
		ChangeSceneRoadNotify = 21251,
		// Token: 0x040012F8 RID: 4856
		MotorTaskUpdateNotify = 22342,
		// Token: 0x040012F9 RID: 4857
		MotorTechUnlockNotify = 17862,
		// Token: 0x040012FA RID: 4858
		MotorTechTreeUnlockNotify = 20699,
		// Token: 0x040012FB RID: 4859
		MotorDataNotify = 25272,
		// Token: 0x040012FC RID: 4860
		DetectionTargetChangeNotify = 15512,
		// Token: 0x040012FD RID: 4861
		AreaTerminalInfoNotify = 19616,
		// Token: 0x040012FE RID: 4862
		HonamiStoryTopInfoNotify = 26555,
		// Token: 0x040012FF RID: 4863
		RbBlockStateChangeNotify = 27504,
		// Token: 0x04001300 RID: 4864
		HonamiStorySetFormationNotify = 18653,
		// Token: 0x04001301 RID: 4865
		VisionTriggerNotify = 24819,
		// Token: 0x04001302 RID: 4866
		SceneBlockSplitHumanChangleNotify = 28372,
		// Token: 0x04001303 RID: 4867
		SceneBlockSplitHumanFullNotify = 18425,
		// Token: 0x04001304 RID: 4868
		RemoveBuffByServerIdS2cRequestNotify = 15505,
		// Token: 0x04001305 RID: 4869
		MotorExpAddNotify = 20982,
		// Token: 0x04001306 RID: 4870
		SceneBlockSplitHumanSwitchStateNotify = 18158,
		// Token: 0x04001307 RID: 4871
		HonamiStoryTalentInfoUpdateNotify = 19936,
		// Token: 0x04001308 RID: 4872
		PhantomBattleAreaSkillCdNotify = 24988,
		// Token: 0x04001309 RID: 4873
		PhantomBattleAreaSkillNotify = 16501,
		// Token: 0x0400130A RID: 4874
		PhantomBattleCardDurableEmptyNotify = 24020,
		// Token: 0x0400130B RID: 4875
		ArtemisNodeUpdateNotify = 21651,
		// Token: 0x0400130C RID: 4876
		SceneBlockSplitPopWindowNotify = 24204,
		// Token: 0x0400130D RID: 4877
		DecalAddNotify = 17780,
		// Token: 0x0400130E RID: 4878
		DecalRemoveNotify = 23152,
		// Token: 0x0400130F RID: 4879
		RoleSceneVoiceSwitchNotify = 23430,
		// Token: 0x04001310 RID: 4880
		CoopRoleInfoUpdateNotify = 27573,
		// Token: 0x04001311 RID: 4881
		HonamiStoryResidentTaskInfoUpdateNotify = 19128,
		// Token: 0x04001312 RID: 4882
		HonamiStoryTotalRevenueNotify = 23885,
		// Token: 0x04001313 RID: 4883
		MotorOutlookAddNotify = 24099,
		// Token: 0x04001314 RID: 4884
		MotorOutlookOwnedChangeNotify = 22922,
		// Token: 0x04001315 RID: 4885
		MotorOutlookEquippedChangeNotify = 15683,
		// Token: 0x04001316 RID: 4886
		RollBlockUpdateGamePlayNotify = 24110,
		// Token: 0x04001317 RID: 4887
		MotorcycleTaskUpdateNotify = 20545,
		// Token: 0x04001318 RID: 4888
		PhantomBattleCallCardNotify = 24644,
		// Token: 0x04001319 RID: 4889
		EntityMotorOutlookChangeNotify = 29444,
		// Token: 0x0400131A RID: 4890
		ShortMessageUpdateNotify = 23082,
		// Token: 0x0400131B RID: 4891
		InfrLibraryTaskUpdateNotify = 15668,
		// Token: 0x0400131C RID: 4892
		RoadNetworkEntityStartNavNotify = 28943,
		// Token: 0x0400131D RID: 4893
		RollBlockResetGamePlayNotify = 26331,
		// Token: 0x0400131E RID: 4894
		MotorOutlookRegionInfoNotify = 17258,
		// Token: 0x0400131F RID: 4895
		VehicleShareNotify = 17830,
		// Token: 0x04001320 RID: 4896
		RoadBookInfoUpdateNotify = 20058,
		// Token: 0x04001321 RID: 4897
		MotorParkourLevelRewardUpdateNotify = 16941,
		// Token: 0x04001322 RID: 4898
		MotorParkourResultNotify = 25444,
		// Token: 0x04001323 RID: 4899
		InfrThemeActivityTaskDataUpdateNotify = 20438,
		// Token: 0x04001324 RID: 4900
		SkinRewardInfoUpdateNotify = 15316,
		// Token: 0x04001325 RID: 4901
		NewTowerResultNotify = 23657,
		// Token: 0x04001326 RID: 4902
		MotorFightTalentTreeUpdateNotify = 21599,
		// Token: 0x04001327 RID: 4903
		MotorFightItemUpdateNotify = 22316,
		// Token: 0x04001328 RID: 4904
		MotorFightRoleUpdateNotify = 19840,
		// Token: 0x04001329 RID: 4905
		MotorFightLevelUpdateNotify = 26610,
		// Token: 0x0400132A RID: 4906
		MotorFightTaskUpdateNotify = 28108,
		// Token: 0x0400132B RID: 4907
		HonamiStoryLifeSupportNotify = 22572,
		// Token: 0x0400132C RID: 4908
		FireShopCoinNotify = 29285,
		// Token: 0x0400132D RID: 4909
		EncircleChallengeUpdateNotify = 21412,
		// Token: 0x0400132E RID: 4910
		HookLockBatchCollectNotify = 26841,
		// Token: 0x0400132F RID: 4911
		NewTowerUpdateRecordNotify = 28883,
		// Token: 0x04001330 RID: 4912
		PhantomDirectRefiningWeeklyResetNotify = 28896,
		// Token: 0x04001331 RID: 4913
		ShortMessageItemUpdateNotify = 18965,
		// Token: 0x04001332 RID: 4914
		MotorBattleContextNotify = 29330,
		// Token: 0x04001333 RID: 4915
		PhantomBattleReconstructCardNotify = 15963,
		// Token: 0x04001334 RID: 4916
		RollBlockUpdateAvailableInputsNotify = 26586,
		// Token: 0x04001335 RID: 4917
		NewPlayerSupportActivityTaskUpdateNotify = 19012,
		// Token: 0x04001336 RID: 4918
		MotorParkourStartNotify = 27385,
		// Token: 0x04001337 RID: 4919
		RegressTrialRoleUnlockNotify = 21529,
		// Token: 0x04001338 RID: 4920
		WeatherControlUnlockNotify = 22697,
		// Token: 0x04001339 RID: 4921
		TotalTopUpRewardNotify = 17958,
		// Token: 0x0400133A RID: 4922
		BookItemUpdateNotify = 27626,
		// Token: 0x0400133B RID: 4923
		EffectiveWeekCardInfoNotify = 22090,
		// Token: 0x0400133C RID: 4924
		NewPlayerSupportActivityTrialRoleUpdateNotify = 27128,
		// Token: 0x0400133D RID: 4925
		MotorFightRefreshSubLevelNotify = 22478,
		// Token: 0x0400133E RID: 4926
		H5ViewActivityDataNotify = 28624,
		// Token: 0x0400133F RID: 4927
		PhantomBattleSkillEffectFailNotify = 29240,
		// Token: 0x04001340 RID: 4928
		NewTowerTaskDataUpdateNotify = 20235,
		// Token: 0x04001341 RID: 4929
		NewTowerLevelUnlockNotify = 23956,
		// Token: 0x04001342 RID: 4930
		RoleConfigInfoNotify = 18911,
		// Token: 0x04001343 RID: 4931
		RoleConfigInfoUpdateNotify = 16265,
		// Token: 0x04001344 RID: 4932
		SceneRoadSyncNotify = 17096,
		// Token: 0x04001345 RID: 4933
		MotorFightGameOverNotify = 15356,
		// Token: 0x04001346 RID: 4934
		TotalTopUpActivityInfoNotify = 24740,
		// Token: 0x04001347 RID: 4935
		TransformBuffStackNotify = 21805,
		// Token: 0x04001348 RID: 4936
		RegressActivityTrialRoleUpdateNotify = 19657,
		// Token: 0x04001349 RID: 4937
		MotorFightRoundInfoNotify = 26380,
		// Token: 0x0400134A RID: 4938
		MotorFightBossDropNotify = 15088,
		// Token: 0x0400134B RID: 4939
		NewTowerRoundUpdateNotify = 23161,
		// Token: 0x0400134C RID: 4940
		RollBlockItemUpdateNotify = 22864,
		// Token: 0x0400134D RID: 4941
		MotorFightMonsterDropNotify = 27596,
		// Token: 0x0400134E RID: 4942
		MotorAnimReplaySampleUdpNotify = 17840,
		// Token: 0x0400134F RID: 4943
		SpringFestivalAreaUnlockNotify = 16024,
		// Token: 0x04001350 RID: 4944
		GivebackInfoUpdateNotify = 27995,
		// Token: 0x04001351 RID: 4945
		MotorFightScoreNotify = 18613,
		// Token: 0x04001352 RID: 4946
		RoleDevelopConfigUpdateNotify = 25103,
		// Token: 0x04001353 RID: 4947
		MotorLockedTechUpdateNotify = 23811,
		// Token: 0x04001354 RID: 4948
		ActionResetPosPrePerformanceNotify = 27087,
		// Token: 0x04001355 RID: 4949
		MotorFightAddBuffNotify = 18353,
		// Token: 0x04001356 RID: 4950
		LevelPlayGainRewardInfoNotify = 25358,
		// Token: 0x04001357 RID: 4951
		SpringFestivalUpdateNotify = 16164,
		// Token: 0x04001358 RID: 4952
		PhantomMusicNotify = 19275,
		// Token: 0x04001359 RID: 4953
		FlagChallengeTaskInfoUpdateNotify = 28118,
		// Token: 0x0400135A RID: 4954
		FlagChallengeLevelInfoUpdateNotify = 27954,
		// Token: 0x0400135B RID: 4955
		FlagStrongholdInfoUpdateNotify = 22966,
		// Token: 0x0400135C RID: 4956
		FlagChallengePerRoleLevelNotify = 25423,
		// Token: 0x0400135D RID: 4957
		FlagChallengeTempRoleLevelNotify = 20785,
		// Token: 0x0400135E RID: 4958
		FlagChallengeInstNotify = 28262,
		// Token: 0x0400135F RID: 4959
		MotorDevelopTaskUpdateNotify = 27674,
		// Token: 0x04001360 RID: 4960
		SpringFestivalAtmosphereUpdateNotify = 26608,
		// Token: 0x04001361 RID: 4961
		FlagChallengeSettleNotify = 26883,
		// Token: 0x04001362 RID: 4962
		KurotatoStepUpdateNotify = 21986,
		// Token: 0x04001363 RID: 4963
		GivebackUnlockNotify = 15923,
		// Token: 0x04001364 RID: 4964
		MotorFightAddEnemyBuffNotify = 17969,
		// Token: 0x04001365 RID: 4965
		MotorFightRefreshCollectionTimesChangeNotify = 16712,
		// Token: 0x04001366 RID: 4966
		FurnitureUnlockNotify = 29232,
		// Token: 0x04001367 RID: 4967
		MotorFightAddCollectionNotify = 27020,
		// Token: 0x04001368 RID: 4968
		MotorSummonAndRideNotify = 21704,
		// Token: 0x04001369 RID: 4969
		KurotatoChestRewardNotify = 24115,
		// Token: 0x0400136A RID: 4970
		KurotatoUpgradeRewardNotify = 18286,
		// Token: 0x0400136B RID: 4971
		KurotatoShopRewardNotify = 15439,
		// Token: 0x0400136C RID: 4972
		KurotatoSystemInfoNotify = 17800,
		// Token: 0x0400136D RID: 4973
		KurotatoItemUpdateNotify = 15702,
		// Token: 0x0400136E RID: 4974
		ConfirmCompleteRefMp4QuestNotify = 20002,
		// Token: 0x0400136F RID: 4975
		FeiXuePreheatInfoUpdateNotify = 21876,
		// Token: 0x04001370 RID: 4976
		StorageInfoNotify = 17245,
		// Token: 0x04001371 RID: 4977
		RhythmRoleUpdateNotify = 27775,
		// Token: 0x04001372 RID: 4978
		RhythmSubLevelUpdateNotify = 18647,
		// Token: 0x04001373 RID: 4979
		RhythmTaskUpdateNotify = 15309,
		// Token: 0x04001374 RID: 4980
		DropCatchLevelRewardUpdateNotify = 22284,
		// Token: 0x04001375 RID: 4981
		SplinePositionNotify = 28425,
		// Token: 0x04001376 RID: 4982
		TimeScheduleTriggerNotify = 26967,
		// Token: 0x04001377 RID: 4983
		KurotatoWeaponUpdateNotify = 22797,
		// Token: 0x04001378 RID: 4984
		NewTowerSeasonTaskDataUpdateNotify = 24370,
		// Token: 0x04001379 RID: 4985
		WillSwitchSceneGroupNotify = 24534,
		// Token: 0x0400137A RID: 4986
		RhythmShipStartNotify = 24795,
		// Token: 0x0400137B RID: 4987
		FlagChallengeBoxExpNotify = 22380,
		// Token: 0x0400137C RID: 4988
		ConsumptiveTotalScoreNotify = 22825,
		// Token: 0x0400137D RID: 4989
		EnterAreaNotify = 25064,
		// Token: 0x0400137E RID: 4990
		RecallInfoNotify = 25321,
		// Token: 0x0400137F RID: 4991
		EntityDressOrnamentChangeNotify = 24410,
		// Token: 0x04001380 RID: 4992
		OrnamentInfoNotify = 15327,
		// Token: 0x04001381 RID: 4993
		OrnamentUnlockNotify = 27985,
		// Token: 0x04001382 RID: 4994
		OrnamentDressInfoUpdateNotify = 29379,
		// Token: 0x04001383 RID: 4995
		SimpleCombatEntityAttributeUpdateNotify = 16636,
		// Token: 0x04001384 RID: 4996
		AvoidBlockSettlementNotify = 23761,
		// Token: 0x04001385 RID: 4997
		AvoidBlockRoundInfoNotify = 21465,
		// Token: 0x04001386 RID: 4998
		CompleteMarkNotify = 27647,
		// Token: 0x04001387 RID: 4999
		FlagChallengeUnlockTeleporterNotify = 27289,
		// Token: 0x04001388 RID: 5000
		PlayerXboxSessionNotify = 28993,
		// Token: 0x04001389 RID: 5001
		PinballSettleNotify = 24613,
		// Token: 0x0400138A RID: 5002
		PinballInGameStateChangeNotify = 20926,
		// Token: 0x0400138B RID: 5003
		KurotatoPropertyUpdateNotify = 22357,
		// Token: 0x0400138C RID: 5004
		PinballUpdateNotify = 19395,
		// Token: 0x0400138D RID: 5005
		BulletPatternNotify = 24460,
		// Token: 0x0400138E RID: 5006
		BeamReceiveNotify = 17895,
		// Token: 0x0400138F RID: 5007
		InfrV2TreeUpdateNotify = 19674,
		// Token: 0x04001390 RID: 5008
		RogueInstExtraInfoUpdateNotify = 18838,
		// Token: 0x04001391 RID: 5009
		InfrV2FireUpdateNotify = 15857,
		// Token: 0x04001392 RID: 5010
		InfrV2TaskDataUpdateNotify = 20489,
		// Token: 0x04001393 RID: 5011
		WuWuTaskUpdateNotify = 24180,
		// Token: 0x04001394 RID: 5012
		ThemeCeleWuWuTaskNotify = 29613,
		// Token: 0x04001395 RID: 5013
		BossPilingTaskInfoUpdateNotify = 15232,
		// Token: 0x04001396 RID: 5014
		BossPilingLevelInfoUpdateNotify = 29397,
		// Token: 0x04001397 RID: 5015
		BossPilingInstNotify = 15347,
		// Token: 0x04001398 RID: 5016
		BossPilingBuffUpdateNotify = 19869,
		// Token: 0x04001399 RID: 5017
		BossPilingSettleNotify = 25811,
		// Token: 0x0400139A RID: 5018
		MotorDecalUpdateNotify = 20711,
		// Token: 0x0400139B RID: 5019
		MotorOutlookFullChangeNotify = 16805,
		// Token: 0x0400139C RID: 5020
		PinballInGameStarChangeNotify = 22124,
		// Token: 0x0400139D RID: 5021
		FsmMontageDurationNotify = 24356,
		// Token: 0x0400139E RID: 5022
		QuestBranchUpdateNotify = 26971,
		// Token: 0x0400139F RID: 5023
		MotorPositionStateNotify = 20614,
		// Token: 0x040013A0 RID: 5024
		GachaAccumulateInfoNotify = 21430,
		// Token: 0x040013A1 RID: 5025
		InfrV2TreeFinishCondUpdateNotify = 21763,
		// Token: 0x040013A2 RID: 5026
		EdgeRunnerUpdateNotify = 23668,
		// Token: 0x040013A3 RID: 5027
		KurotatoLevelDataUpdateNotify = 17855,
		// Token: 0x040013A4 RID: 5028
		KurotatoRoleUnlockNotify = 16470,
		// Token: 0x040013A5 RID: 5029
		KurotatoWeaponUnlockNotify = 17432,
		// Token: 0x040013A6 RID: 5030
		KurotatoItemUnlockNotify = 20943,
		// Token: 0x040013A7 RID: 5031
		KurotatoResTaskUpdateNotify = 27726,
		// Token: 0x040013A8 RID: 5032
		KurotatoLimitTaskUpdateNotify = 29083,
		// Token: 0x040013A9 RID: 5033
		PinballUpdateWaveNotify = 23526,
		// Token: 0x040013AA RID: 5034
		WeeklyFrameworkInfoUpdateNotify = 24665,
		// Token: 0x040013AB RID: 5035
		KurotatoSettlementNotify = 24835,
		// Token: 0x040013AC RID: 5036
		EdgeRunnerLordGymLevelPlayResultNotify = 24470,
		// Token: 0x040013AD RID: 5037
		MotorOnlineRankSnapshotNotify = 21549,
		// Token: 0x040013AE RID: 5038
		FloroRanchPlayWeeklyNotify = 27614,
		// Token: 0x040013AF RID: 5039
		StorageInfoUpdateNotify = 24810,
		// Token: 0x040013B0 RID: 5040
		KurotatoRoleRecordNotify = 29827,
		// Token: 0x040013B1 RID: 5041
		OnlineMotorSettleNotify = 28720,
		// Token: 0x040013B2 RID: 5042
		OnlineMotorUpdateNotify = 20286,
		// Token: 0x040013B3 RID: 5043
		PinballStartNotify = 29654,
		// Token: 0x040013B4 RID: 5044
		DollDeliveryNotify = 15165,
		// Token: 0x040013B5 RID: 5045
		PinballFixSpawnFinishNotify = 22699,
		// Token: 0x040013B6 RID: 5046
		EdgeRunnerPreUnlockAvailableNotify = 29069,
		// Token: 0x040013B7 RID: 5047
		InfrV2InfoNotify = 17182,
		// Token: 0x040013B8 RID: 5048
		RemovePreloadFlowsNotify = 24692,
		// Token: 0x040013B9 RID: 5049
		PinballSpawnFirstFinishNotify = 26869,
		// Token: 0x040013BA RID: 5050
		FloroRanchPlayWeeklyEndNotify = 19055,
		// Token: 0x040013BB RID: 5051
		KurotatoDieNotify = 24258,
		// Token: 0x040013BC RID: 5052
		MotorOnlineRankRuleIdsNotify = 29052,
		// Token: 0x040013BD RID: 5053
		OnlineMotorStartNotify = 20033,
		// Token: 0x040013BE RID: 5054
		NewPlayerSupportActivityTrialRoleUpdateV2Notify = 15348,
		// Token: 0x040013BF RID: 5055
		OnlineMotorEndNotify = 28235,
		// Token: 0x040013C0 RID: 5056
		NewPlayerSupportV2GachaRoleUpdateNotify = 20716,
		// Token: 0x040013C1 RID: 5057
		RealmBetweenInfoUpdateNotify = 25055,
		// Token: 0x040013C2 RID: 5058
		RogueTowerTrialReChallengeNotify = 19059,
		// Token: 0x040013C3 RID: 5059
		RogueTowerTrialResultNotify = 20375,
		// Token: 0x040013C4 RID: 5060
		RogueTowerTrialSelectBossNotify = 16751,
		// Token: 0x040013C5 RID: 5061
		SheriffAnomalyInfoUpdateNotify = 17753,
		// Token: 0x040013C6 RID: 5062
		SheriffCriminalUpdateNotify = 29606,
		// Token: 0x040013C7 RID: 5063
		MiniWriteLetterLoginNotify = 21985,
		// Token: 0x040013C8 RID: 5064
		TimeScheduleIdleNotify = 18933,
		// Token: 0x040013C9 RID: 5065
		GachaDiscountNotify = 15918,
		// Token: 0x040013CA RID: 5066
		KurotatoRefineWeaponNotify = 26350,
		// Token: 0x040013CB RID: 5067
		RecallQuestListNotify = 19235,
		// Token: 0x040013CC RID: 5068
		TraceRecallQuestNotify = 22097,
		// Token: 0x040013CD RID: 5069
		RecallQuestChangeTraceNotify = 28015,
		// Token: 0x040013CE RID: 5070
		RecallQuestRollBackEndNotify = 27936,
		// Token: 0x040013CF RID: 5071
		RecallQuestStatusUpdateNotify = 16968,
		// Token: 0x040013D0 RID: 5072
		RecallQuestFinishListNotify = 26450,
		// Token: 0x040013D1 RID: 5073
		DestroyRecallQuestsNotify = 16440,
		// Token: 0x040013D2 RID: 5074
		NewbieAdventureTaskUpdateNotify = 27178,
		// Token: 0x040013D3 RID: 5075
		NewbieCourseV2RewardNotify = 28195,
		// Token: 0x040013D4 RID: 5076
		NewbieMainTaskUpdateNotify = 27645,
		// Token: 0x040013D5 RID: 5077
		RecallQuestGiveUpNotify = 22535,
		// Token: 0x040013D6 RID: 5078
		RecallItemBagDeltaNotify = 27494,
		// Token: 0x040013D7 RID: 5079
		ActivityRecommendNotify = 24619,
		// Token: 0x040013D8 RID: 5080
		RecallItemBagRemoveNotify = 16591,
		// Token: 0x040013D9 RID: 5081
		NewTowerMonsterHpInfoNotify = 25553,
		// Token: 0x040013DA RID: 5082
		LordGymGroupInfoUpdateNotify = 22195,
		// Token: 0x040013DB RID: 5083
		KurotatoAllItemUpdateNotify = 28952,
		// Token: 0x040013DC RID: 5084
		SimpleCombatBeginNotify = 26690,
		// Token: 0x040013DD RID: 5085
		SimpleCombatEndNotify = 26778,
		// Token: 0x040013DE RID: 5086
		RoverRogueResultNotify = 19486,
		// Token: 0x040013DF RID: 5087
		RoverRogueRoomInfoNotify = 25772,
		// Token: 0x040013E0 RID: 5088
		RoverRogueChooseDataNotify = 17268,
		// Token: 0x040013E1 RID: 5089
		RoverRogueSubLevelNotify = 15783,
		// Token: 0x040013E2 RID: 5090
		RoverRogueShopUpdateNotify = 18904,
		// Token: 0x040013E3 RID: 5091
		RoverRogueInfoNotify = 16398,
		// Token: 0x040013E4 RID: 5092
		RoverRogueGainDataUpdateNotify = 18551,
		// Token: 0x040013E5 RID: 5093
		RoverRogueCurrencyNotify = 23276,
		// Token: 0x040013E6 RID: 5094
		PlayerRecallInfoNotify = 20622,
		// Token: 0x040013E7 RID: 5095
		DangoBrawlInstBaseNotify = 16916,
		// Token: 0x040013E8 RID: 5096
		DangoBrawlInstEventSelectNotify = 16117,
		// Token: 0x040013E9 RID: 5097
		DangoBrawlInstPrepareNotify = 27221,
		// Token: 0x040013EA RID: 5098
		DangoBrawlRoundSwitchNotify = 28886,
		// Token: 0x040013EB RID: 5099
		DangoBrawlCoinUpdateNotify = 29648,
		// Token: 0x040013EC RID: 5100
		DangoBrawlSettleNotify = 18644,
		// Token: 0x040013ED RID: 5101
		RoverRogueGainGetOrLoseNotify = 26853,
		// Token: 0x040013EE RID: 5102
		RoverRogueUpdateReviveTimesNotify = 15569,
		// Token: 0x040013EF RID: 5103
		KurotatoNextWaveTypeNotify = 27025,
		// Token: 0x040013F0 RID: 5104
		RoverRogueBlessGroupSelectNotify = 23210,
		// Token: 0x040013F1 RID: 5105
		DirectTrainInfoUpdateNotify = 16954,
		// Token: 0x040013F2 RID: 5106
		LeaveQuestRecallNotify = 20978,
		// Token: 0x040013F3 RID: 5107
		RoverRogueEventNotify = 16943,
		// Token: 0x040013F4 RID: 5108
		DangoBrawlFighterAttrChangeNotify = 29224,
		// Token: 0x040013F5 RID: 5109
		DangoBrawlTaskUpdateNotify = 21615,
		// Token: 0x040013F6 RID: 5110
		DangoBrawlRoleUnlockNotify = 15179,
		// Token: 0x040013F7 RID: 5111
		DangoBrawlItemUnlockNotify = 22794,
		// Token: 0x040013F8 RID: 5112
		PlayerNetStateS2cNotify = 18103,
		// Token: 0x040013F9 RID: 5113
		KurotatoReChallengeCountNotify = 19047,
		// Token: 0x040013FA RID: 5114
		RoverRogueLootChangeNotify = 22228,
		// Token: 0x040013FB RID: 5115
		RecallExploreSkillRouletteNotify = 27174,
		// Token: 0x040013FC RID: 5116
		RoverRogueTalentUnlockNotify = 24427,
		// Token: 0x040013FD RID: 5117
		RoverRogueTaskUpdateNotify = 23286,
		// Token: 0x040013FE RID: 5118
		DangoBrawlFightActionNotify = 21289,
		// Token: 0x040013FF RID: 5119
		DangoBrawlBagUpdateNotify = 24695,
		// Token: 0x04001400 RID: 5120
		PlayerTitleInfoUpdateNotify = 20253,
		// Token: 0x04001401 RID: 5121
		PlayInstShareFirstInfoNotify = 22822,
		// Token: 0x04001402 RID: 5122
		RoverRogueResourcesUpdateNotify = 27960,
		// Token: 0x04001403 RID: 5123
		ZitherPlayNoteNotify = 19034,
		// Token: 0x04001404 RID: 5124
		ElementalAbilityUpdateNotify = 28668,
		// Token: 0x04001405 RID: 5125
		QingXiaoTaskUpdateNotify = 22617,
		// Token: 0x04001406 RID: 5126
		EntityElementalAbilityEnableNotify = 16885,
		// Token: 0x04001407 RID: 5127
		SheriffZoneItemUpdateNotify = 18326,
		// Token: 0x04001408 RID: 5128
		DangoBrawlStartFightNotify = 21162,
		// Token: 0x04001409 RID: 5129
		GiantSystemInfoNotify = 29120,
		// Token: 0x0400140A RID: 5130
		GiantResponseNotify = 18571,
		// Token: 0x0400140B RID: 5131
		GiantModelEnableNotify = 17776,
		// Token: 0x0400140C RID: 5132
		GiantEcoUnlockNotify = 29556,
		// Token: 0x0400140D RID: 5133
		CombatValNotify = 18757,
		// Token: 0x0400140E RID: 5134
		CombatValDecayBeginNotify = 27363,
		// Token: 0x0400140F RID: 5135
		DangoBrawlChallengeUnlockNotify = 22943,
		// Token: 0x04001410 RID: 5136
		PlayerHandFoundationCoreChangeNotify = 29717,
		// Token: 0x04001411 RID: 5137
		EntityFoundationCoreChangeNotify = 24775,
		// Token: 0x04001412 RID: 5138
		TimePointRewardActivityConditionNotify = 21826,
		// Token: 0x04001413 RID: 5139
		RecallMapMarkInfoNotify = 22163,
		// Token: 0x04001414 RID: 5140
		DangoBrawlSaveMatchBriefNotify = 15653,
		// Token: 0x04001415 RID: 5141
		RecallMapMarkUpdateNotify = 15791,
		// Token: 0x04001416 RID: 5142
		GiantItemUnlockNotify = 25972,
		// Token: 0x04001417 RID: 5143
		SolarSchoolTaskUpdateNotify = 16887,
		// Token: 0x04001418 RID: 5144
		SolarSchoolGalleryUpdateNotify = 15173,
		// Token: 0x04001419 RID: 5145
		GiantItemAccessUnlockNotify = 23920,
		// Token: 0x0400141A RID: 5146
		GiantItemAccessProgressChangeNotify = 25359,
		// Token: 0x0400141B RID: 5147
		GiantTotalStableValueUpdateNotify = 27023,
		// Token: 0x0400141C RID: 5148
		SquadPropChangedNotify = 20340,
		// Token: 0x0400141D RID: 5149
		GiantActivityNodeActiveNotify = 18243,
		// Token: 0x0400141E RID: 5150
		DangoBrawlLoseCountUpdateNotify = 26926,
		// Token: 0x0400141F RID: 5151
		RoverRogueShopInfoUpdateNotify = 23170,
		// Token: 0x04001420 RID: 5152
		BanItemUseNotify = 22869,
		// Token: 0x04001421 RID: 5153
		TreasureChestCountNotify = 23149,
		// Token: 0x04001422 RID: 5154
		DangoBrawlItemGiveCoinNotify = 26647,
		// Token: 0x04001423 RID: 5155
		DangoBrawlItemEffectShowNotify = 15034,
		// Token: 0x04001424 RID: 5156
		DangoBrawlActivityLimitCoinUpdateNotify = 25541,
		// Token: 0x04001425 RID: 5157
		TreasureChestCountIncrementNotify = 25587,
		// Token: 0x04001426 RID: 5158
		RoleTowerChallengeSettleNotify = 15085,
		// Token: 0x04001427 RID: 5159
		RoleTowerRewardTaskUpdateNotify = 23293,
		// Token: 0x04001428 RID: 5160
		RoleTowerScoreTaskUpdateNotify = 24764,
		// Token: 0x04001429 RID: 5161
		RoleTowerChallengeUpdateNotify = 21751,
		// Token: 0x0400142A RID: 5162
		RoleTowerTokenUpdateNotify = 18236,
		// Token: 0x0400142B RID: 5163
		PhantomEquipGroupInfoNotify = 16384,
		// Token: 0x0400142C RID: 5164
		RecallItemBagObtainNotify = 15236,
		// Token: 0x0400142D RID: 5165
		DamageShowNotify = 16964,
		// Token: 0x0400142E RID: 5166
		RecallItemRewardNotify = 27085,
		// Token: 0x0400142F RID: 5167
		RoleTowerStepUpdateNotify = 25704,
		// Token: 0x04001430 RID: 5168
		RoleTowerTimerDataUpdateNotify = 20667,
		// Token: 0x04001431 RID: 5169
		RoleTowerTimerDurationUpdateNotify = 19870,
		// Token: 0x04001432 RID: 5170
		RoleTowerScoreUpdateNotify = 28517,
		// Token: 0x04001433 RID: 5171
		RoleTowerFloorSettleNotify = 22389,
		// Token: 0x04001434 RID: 5172
		RoleTowerUnlockTokenUpdateNotify = 20373,
		// Token: 0x04001435 RID: 5173
		AccessForceClosedAreaNotify = 27267,
		// Token: 0x04001436 RID: 5174
		RoleTowerDieNotify = 26184,
		// Token: 0x04001437 RID: 5175
		RoleTowerItemUpdateNotify = 23300,
		// Token: 0x04001438 RID: 5176
		FollowerChairPresentationChangeNotify = 29665,
		// Token: 0x04001439 RID: 5177
		RecallInstSaveDataNotify = 22471,
		// Token: 0x0400143A RID: 5178
		GuideGroupResetNotify = 29638,
		// Token: 0x0400143B RID: 5179
		RoleTowerPhantomAddAttrsUpdateNotify = 26773,
		// Token: 0x0400143C RID: 5180
		ServerConfigVersionInfoNotify = 28553,
		// Token: 0x0400143D RID: 5181
		PostAkEventNotify = 19508
	}
}
