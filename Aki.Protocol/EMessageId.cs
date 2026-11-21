using System;

namespace Aki.Protocol
{
	// Token: 0x02000007 RID: 7
	public enum EMessageId
	{
		// Token: 0x04000024 RID: 36
		CreateCharacterRequest = 101,
		// Token: 0x04000025 RID: 37
		CreateCharacterResponse,
		// Token: 0x04000026 RID: 38
		LoginRequest,
		// Token: 0x04000027 RID: 39
		LoginResponse,
		// Token: 0x04000028 RID: 40
		EnterGameRequest,
		// Token: 0x04000029 RID: 41
		EnterGameResponse,
		// Token: 0x0400002A RID: 42
		ReconnectRequest,
		// Token: 0x0400002B RID: 43
		ReconnectResponse,
		// Token: 0x0400002C RID: 44
		LoginNotify,
		// Token: 0x0400002D RID: 45
		LogoutNotify,
		// Token: 0x0400002E RID: 46
		ProtoKeyRequest,
		// Token: 0x0400002F RID: 47
		ProtoKeyResponse,
		// Token: 0x04000030 RID: 48
		PushDataCompleteNotify,
		// Token: 0x04000031 RID: 49
		ExitGamePush,
		// Token: 0x04000032 RID: 50
		SwitchNodeNotify,
		// Token: 0x04000033 RID: 51
		CheckClientPush,
		// Token: 0x04000034 RID: 52
		AceAntiDataPush = 21559,
		// Token: 0x04000035 RID: 53
		AceAntiDataNotify = 24754,
		// Token: 0x04000036 RID: 54
		AchievementInfoRequest = 22315,
		// Token: 0x04000037 RID: 55
		AchievementInfoResponse = 19753,
		// Token: 0x04000038 RID: 56
		AchievementReceiveRequest = 16062,
		// Token: 0x04000039 RID: 57
		AchievementReceiveResponse = 25408,
		// Token: 0x0400003A RID: 58
		AchievementProgressNotify = 29757,
		// Token: 0x0400003B RID: 59
		AchievementListProgressNotify = 29111,
		// Token: 0x0400003C RID: 60
		AchievementGroupProgressNotify = 18514,
		// Token: 0x0400003D RID: 61
		AchievementFinishRequest = 27912,
		// Token: 0x0400003E RID: 62
		AchievementFinishResponse = 19182,
		// Token: 0x0400003F RID: 63
		ActionNotify = 27631,
		// Token: 0x04000040 RID: 64
		ActionErrorCodeNotify = 21270,
		// Token: 0x04000041 RID: 65
		ActionFinishRequest = 27577,
		// Token: 0x04000042 RID: 66
		ActionFinishResponse = 26069,
		// Token: 0x04000043 RID: 67
		GmLevelActionRequest = 29805,
		// Token: 0x04000044 RID: 68
		GmLevelActionResponse = 26699,
		// Token: 0x04000045 RID: 69
		OperationRestrictionNotify = 15930,
		// Token: 0x04000046 RID: 70
		ActivityRequest = 16076,
		// Token: 0x04000047 RID: 71
		ActivityResponse = 15999,
		// Token: 0x04000048 RID: 72
		ActivityFirstReadRequest = 19271,
		// Token: 0x04000049 RID: 73
		ActivityFirstReadResponse = 19193,
		// Token: 0x0400004A RID: 74
		ActivityUpdateNotify = 17864,
		// Token: 0x0400004B RID: 75
		ActivityDisableNotify = 18605,
		// Token: 0x0400004C RID: 76
		SignActivityRequest = 29384,
		// Token: 0x0400004D RID: 77
		SignActivityResponse = 18799,
		// Token: 0x0400004E RID: 78
		SignActivitySignStateNotify = 27234,
		// Token: 0x0400004F RID: 79
		SignActivityKeepTimeNotify = 16823,
		// Token: 0x04000050 RID: 80
		HarvestActivityPointRequest = 15260,
		// Token: 0x04000051 RID: 81
		HarvestActivityPointResponse = 26658,
		// Token: 0x04000052 RID: 82
		HarvestActivityLevelRequest = 27602,
		// Token: 0x04000053 RID: 83
		HarvestActivityLevelResponse = 23959,
		// Token: 0x04000054 RID: 84
		HarvestActivityLevelDiffRequest = 16220,
		// Token: 0x04000055 RID: 85
		HarvestActivityLevelDiffResponse = 28299,
		// Token: 0x04000056 RID: 86
		HarvestActivityPointNotify = 23843,
		// Token: 0x04000057 RID: 87
		HarvestActivityLevelNotify = 22145,
		// Token: 0x04000058 RID: 88
		HarvestActivityResultRequest = 22854,
		// Token: 0x04000059 RID: 89
		HarvestActivityResultResponse = 19031,
		// Token: 0x0400005A RID: 90
		HarvestActivityResultNotify = 22031,
		// Token: 0x0400005B RID: 91
		PhantomCollectReceiveRequest = 24841,
		// Token: 0x0400005C RID: 92
		PhantomCollectReceiveResponse = 21188,
		// Token: 0x0400005D RID: 93
		PhantomCollectUpdateNotify = 23250,
		// Token: 0x0400005E RID: 94
		AdventureManualDataRequest = 25198,
		// Token: 0x0400005F RID: 95
		AdventureManualDataResponse = 24214,
		// Token: 0x04000060 RID: 96
		GetAdventureRewardRequest = 26242,
		// Token: 0x04000061 RID: 97
		GetAdventureRewardResponse = 25347,
		// Token: 0x04000062 RID: 98
		GetChapterRewardRequest = 26818,
		// Token: 0x04000063 RID: 99
		GetChapterRewardResponse = 18554,
		// Token: 0x04000064 RID: 100
		DetectionRequest = 15268,
		// Token: 0x04000065 RID: 101
		DetectionResponse = 17575,
		// Token: 0x04000066 RID: 102
		AdventureUpdateNotify = 22975,
		// Token: 0x04000067 RID: 103
		AdventureManualRequest = 17641,
		// Token: 0x04000068 RID: 104
		AdventureManualResponse = 19686,
		// Token: 0x04000069 RID: 105
		ReceivedSilentFirstAwardRequest = 17342,
		// Token: 0x0400006A RID: 106
		ReceivedSilentFirstAwardResponse = 28437,
		// Token: 0x0400006B RID: 107
		SlientFirstAwardNotify = 17464,
		// Token: 0x0400006C RID: 108
		UpdateMonsterUnlockNotify = 17351,
		// Token: 0x0400006D RID: 109
		SelectDetectionTargetRequest = 21057,
		// Token: 0x0400006E RID: 110
		SelectDetectionTargetResponse = 15118,
		// Token: 0x0400006F RID: 111
		FollowDetectionTargetUpdateNotify = 17471,
		// Token: 0x04000070 RID: 112
		MonsterDetectionInfoRequest = 28163,
		// Token: 0x04000071 RID: 113
		MonsterDetectionInfoResponse = 17979,
		// Token: 0x04000072 RID: 114
		NormalMonsterManualInfoRequest = 22245,
		// Token: 0x04000073 RID: 115
		NormalMonsterManualInfoResponse = 22708,
		// Token: 0x04000074 RID: 116
		GetDetectionLabelInfoRequest = 22348,
		// Token: 0x04000075 RID: 117
		GetDetectionLabelInfoResponse = 21286,
		// Token: 0x04000076 RID: 118
		AddUnlockedGuideNotify = 28351,
		// Token: 0x04000077 RID: 119
		AddUnlockedDetectionTextNotify = 17144,
		// Token: 0x04000078 RID: 120
		AdviceSettingNotify = 22745,
		// Token: 0x04000079 RID: 121
		AdviceSetRequest = 24164,
		// Token: 0x0400007A RID: 122
		AdviceSetResponse = 20925,
		// Token: 0x0400007B RID: 123
		AdviceContentUpdateNotify = 16880,
		// Token: 0x0400007C RID: 124
		AdviceVoteUpdateNotify = 15493,
		// Token: 0x0400007D RID: 125
		AdviceRequest = 23265,
		// Token: 0x0400007E RID: 126
		AdviceResponse = 28955,
		// Token: 0x0400007F RID: 127
		AdviceUpdateNotify = 21702,
		// Token: 0x04000080 RID: 128
		AdviceCreateRequest,
		// Token: 0x04000081 RID: 129
		AdviceCreateResponse = 19764,
		// Token: 0x04000082 RID: 130
		AdviceModifyRequest = 28074,
		// Token: 0x04000083 RID: 131
		AdviceModifyResponse = 18162,
		// Token: 0x04000084 RID: 132
		AdviceDeleteRequest = 18057,
		// Token: 0x04000085 RID: 133
		AdviceDeleteResponse = 28966,
		// Token: 0x04000086 RID: 134
		AdviceVoteRequest = 23765,
		// Token: 0x04000087 RID: 135
		AdviceVoteResponse = 18076,
		// Token: 0x04000088 RID: 136
		AiInformationRequest = 18681,
		// Token: 0x04000089 RID: 137
		AiInformationResponse = 20922,
		// Token: 0x0400008A RID: 138
		AiInformationNotify = 26510,
		// Token: 0x0400008B RID: 139
		AiBlackboardsRequest = 22558,
		// Token: 0x0400008C RID: 140
		AiBlackboardsResponse = 27598,
		// Token: 0x0400008D RID: 141
		AiBlackboardCdRequest = 15625,
		// Token: 0x0400008E RID: 142
		AiBlackboardCdResponse = 29807,
		// Token: 0x0400008F RID: 143
		AiBlackboardCdNotify = 26019,
		// Token: 0x04000090 RID: 144
		AiHateRequest = 27610,
		// Token: 0x04000091 RID: 145
		AiHateResponse = 20048,
		// Token: 0x04000092 RID: 146
		AiHateNotify = 17752,
		// Token: 0x04000093 RID: 147
		AiControlSwitchRequest = 27014,
		// Token: 0x04000094 RID: 148
		AiControlSwitchResponse = 29374,
		// Token: 0x04000095 RID: 149
		AiControlSwitchNotify = 16041,
		// Token: 0x04000096 RID: 150
		PreAiControlSwitchNotify = 29939,
		// Token: 0x04000097 RID: 151
		EnterAreaRequest = 22737,
		// Token: 0x04000098 RID: 152
		EnterAreaResponse = 17162,
		// Token: 0x04000099 RID: 153
		BanChatNotify = 23415,
		// Token: 0x0400009A RID: 154
		ReportPlayerRequest = 24953,
		// Token: 0x0400009B RID: 155
		ReportPlayerResponse = 22547,
		// Token: 0x0400009C RID: 156
		PlayerRenameNotify = 16634,
		// Token: 0x0400009D RID: 157
		BasicInfoNotify = 21993,
		// Token: 0x0400009E RID: 158
		ModifyNameRequest = 18421,
		// Token: 0x0400009F RID: 159
		ModifyNameResponse = 16293,
		// Token: 0x040000A0 RID: 160
		ModifySignatureRequest = 16561,
		// Token: 0x040000A1 RID: 161
		ModifySignatureResponse = 18895,
		// Token: 0x040000A2 RID: 162
		ChangeHeadPhotoRequest = 26439,
		// Token: 0x040000A3 RID: 163
		ChangeHeadPhotoResponse = 28817,
		// Token: 0x040000A4 RID: 164
		UnlockHeadPhotoNotify = 23177,
		// Token: 0x040000A5 RID: 165
		UnlockHeadFrameNotify = 19052,
		// Token: 0x040000A6 RID: 166
		ClientBasicInfoRequest = 23592,
		// Token: 0x040000A7 RID: 167
		ClientBasicInfoResponse = 19121,
		// Token: 0x040000A8 RID: 168
		PlayerBasicInfoGetRequest = 23383,
		// Token: 0x040000A9 RID: 169
		PlayerBasicInfoGetResponse = 19022,
		// Token: 0x040000AA RID: 170
		BirthdayInitRequest = 21136,
		// Token: 0x040000AB RID: 171
		BirthdayInitResponse = 29356,
		// Token: 0x040000AC RID: 172
		RoleShowListUpdateRequest = 27889,
		// Token: 0x040000AD RID: 173
		RoleShowListUpdateResponse = 23280,
		// Token: 0x040000AE RID: 174
		HeadIdUpdateNotify = 24865,
		// Token: 0x040000AF RID: 175
		RoleShowListUpdateNotify = 27858,
		// Token: 0x040000B0 RID: 176
		ChangeCardRequest = 23459,
		// Token: 0x040000B1 RID: 177
		ChangeCardResponse = 29040,
		// Token: 0x040000B2 RID: 178
		ReadCardRequest = 15318,
		// Token: 0x040000B3 RID: 179
		ReadCardResponse = 19779,
		// Token: 0x040000B4 RID: 180
		UnlockCardNotify = 22072,
		// Token: 0x040000B5 RID: 181
		BirthdayShowSetRequest = 27980,
		// Token: 0x040000B6 RID: 182
		BirthdayShowSetResponse = 29672,
		// Token: 0x040000B7 RID: 183
		BattlePassRequest = 22649,
		// Token: 0x040000B8 RID: 184
		BattlePassResponse = 26557,
		// Token: 0x040000B9 RID: 185
		BattlePassPaidNotify = 17219,
		// Token: 0x040000BA RID: 186
		BattlePassTakeRewardRequest = 27378,
		// Token: 0x040000BB RID: 187
		BattlePassTakeRewardResponse = 29764,
		// Token: 0x040000BC RID: 188
		BattlePassRecurringTakeRequest = 29679,
		// Token: 0x040000BD RID: 189
		BattlePassRecurringTakeResponse = 27272,
		// Token: 0x040000BE RID: 190
		BattlePassTakeAllRewardRequest = 21032,
		// Token: 0x040000BF RID: 191
		BattlePassTakeAllRewardResponse = 27259,
		// Token: 0x040000C0 RID: 192
		BattlePassExpUpdateNotify = 20892,
		// Token: 0x040000C1 RID: 193
		BattlePassTaskRequest = 22950,
		// Token: 0x040000C2 RID: 194
		BattlePassTaskResponse = 27662,
		// Token: 0x040000C3 RID: 195
		BattlePassTaskUpdateNotify = 17567,
		// Token: 0x040000C4 RID: 196
		BattlePassTaskTakeRequest = 29651,
		// Token: 0x040000C5 RID: 197
		BattlePassTaskTakeResponse = 17148,
		// Token: 0x040000C6 RID: 198
		BattlePassEnterPush = 20512,
		// Token: 0x040000C7 RID: 199
		BattlePassLevelUpRequest = 26786,
		// Token: 0x040000C8 RID: 200
		BattlePassLevelUpResponse = 19912,
		// Token: 0x040000C9 RID: 201
		BehaviorTreeInfoNotify = 16786,
		// Token: 0x040000CA RID: 202
		BehaviorTreeDeleteNotify = 28831,
		// Token: 0x040000CB RID: 203
		UpdateNodeProgressNotify = 21488,
		// Token: 0x040000CC RID: 204
		UpdateChildQuestNodeStatusNotify = 22070,
		// Token: 0x040000CD RID: 205
		UpdateNodeStatusNotify = 23007,
		// Token: 0x040000CE RID: 206
		SubmitNodeRequest = 21759,
		// Token: 0x040000CF RID: 207
		SubmitNodeResponse = 21283,
		// Token: 0x040000D0 RID: 208
		HandInItemRequest = 21324,
		// Token: 0x040000D1 RID: 209
		HandInItemResponse = 21737,
		// Token: 0x040000D2 RID: 210
		BtSetTimerInfoRequest = 19327,
		// Token: 0x040000D3 RID: 211
		BtSetTimerInfoResponse = 20250,
		// Token: 0x040000D4 RID: 212
		BtSuspendNotify = 29172,
		// Token: 0x040000D5 RID: 213
		OccupationInfoNotify = 16517,
		// Token: 0x040000D6 RID: 214
		AddOccupationInfoNotify = 19074,
		// Token: 0x040000D7 RID: 215
		RemoveOccupationInfoNotify = 23251,
		// Token: 0x040000D8 RID: 216
		TimeOccupationNotify = 17295,
		// Token: 0x040000D9 RID: 217
		BtForcedOccupationRequest = 25189,
		// Token: 0x040000DA RID: 218
		BtForcedOccupationResponse = 24742,
		// Token: 0x040000DB RID: 219
		BtGiveUpRequest = 18051,
		// Token: 0x040000DC RID: 220
		BtGiveUpResponse = 22791,
		// Token: 0x040000DD RID: 221
		BtRollbackNotify = 18266,
		// Token: 0x040000DE RID: 222
		BtRollbackRequest = 23225,
		// Token: 0x040000DF RID: 223
		BtRollbackResponse = 22916,
		// Token: 0x040000E0 RID: 224
		BtRollbackStartNotify = 26088,
		// Token: 0x040000E1 RID: 225
		BtRollbackInfoNotify = 26092,
		// Token: 0x040000E2 RID: 226
		SneakRequest = 15909,
		// Token: 0x040000E3 RID: 227
		SneakResponse = 27480,
		// Token: 0x040000E4 RID: 228
		SneakTimeRequest = 27089,
		// Token: 0x040000E5 RID: 229
		SneakTimeResponse = 16525,
		// Token: 0x040000E6 RID: 230
		SneakNotify = 20617,
		// Token: 0x040000E7 RID: 231
		UpdateTimerInfoNotify = 27863,
		// Token: 0x040000E8 RID: 232
		TimerEndRequest = 28680,
		// Token: 0x040000E9 RID: 233
		TimerEndResponse = 29668,
		// Token: 0x040000EA RID: 234
		UiGamePlayRequest = 24744,
		// Token: 0x040000EB RID: 235
		UiGamePlayResponse = 19566,
		// Token: 0x040000EC RID: 236
		NpcTraceFailedRequest = 29936,
		// Token: 0x040000ED RID: 237
		NpcTraceFailedResponse = 19981,
		// Token: 0x040000EE RID: 238
		BtVarUpdateNotify = 25834,
		// Token: 0x040000EF RID: 239
		UpdateEnableSystemNotify = 17615,
		// Token: 0x040000F0 RID: 240
		WorldBlackboardRequest = 22945,
		// Token: 0x040000F1 RID: 241
		WorldBlackboardResponse = 19301,
		// Token: 0x040000F2 RID: 242
		WorldBlackboardNotify = 23585,
		// Token: 0x040000F3 RID: 243
		EntityBlackboardRequest = 19528,
		// Token: 0x040000F4 RID: 244
		EntityBlackboardResponse = 26328,
		// Token: 0x040000F5 RID: 245
		EntityBlackboardNotify = 17963,
		// Token: 0x040000F6 RID: 246
		BlockListRequest = 22469,
		// Token: 0x040000F7 RID: 247
		BlockListResponse = 23512,
		// Token: 0x040000F8 RID: 248
		BlockPlayerRequest = 26186,
		// Token: 0x040000F9 RID: 249
		BlockPlayerResponse = 25057,
		// Token: 0x040000FA RID: 250
		UnblockPlayerRequest = 25581,
		// Token: 0x040000FB RID: 251
		UnblockPlayerResponse = 26572,
		// Token: 0x040000FC RID: 252
		RemovePlacementFromBoardNotify = 22490,
		// Token: 0x040000FD RID: 253
		AddPlacementNotify = 19989,
		// Token: 0x040000FE RID: 254
		PlacementInfoChangeNotify = 19545,
		// Token: 0x040000FF RID: 255
		PlaceItemOnBoardRequest = 23598,
		// Token: 0x04000100 RID: 256
		PlaceItemOnBoardResponse = 22601,
		// Token: 0x04000101 RID: 257
		PlaceItemOnBoardNotify = 15283,
		// Token: 0x04000102 RID: 258
		CommitBoardRequest = 22677,
		// Token: 0x04000103 RID: 259
		CommitBoardResponse = 16328,
		// Token: 0x04000104 RID: 260
		CommitBoardSuccessNotify = 21576,
		// Token: 0x04000105 RID: 261
		MovePlacementRequest = 26801,
		// Token: 0x04000106 RID: 262
		MovePlacementResponse = 29380,
		// Token: 0x04000107 RID: 263
		MovePlacementNotify = 21148,
		// Token: 0x04000108 RID: 264
		BoardGridDynamicConfigChangeNotify = 23350,
		// Token: 0x04000109 RID: 265
		ApplyGameplayEffectRequest = 26992,
		// Token: 0x0400010A RID: 266
		ApplyGameplayEffectResponse = 23904,
		// Token: 0x0400010B RID: 267
		ApplyGameplayEffectNotify = 26040,
		// Token: 0x0400010C RID: 268
		RemoveGameplayEffectRequest = 15998,
		// Token: 0x0400010D RID: 269
		RemoveGameplayEffectResponse = 29948,
		// Token: 0x0400010E RID: 270
		RemoveGameplayEffectNotify = 18172,
		// Token: 0x0400010F RID: 271
		OrderApplyBuffRequest = 21297,
		// Token: 0x04000110 RID: 272
		OrderApplyBuffResponse = 15979,
		// Token: 0x04000111 RID: 273
		OrderRemoveBuffRequest = 26903,
		// Token: 0x04000112 RID: 274
		OrderRemoveBuffResponse = 17733,
		// Token: 0x04000113 RID: 275
		OrderApplyBuffNotify = 19792,
		// Token: 0x04000114 RID: 276
		OrderRemoveBuffNotify = 20935,
		// Token: 0x04000115 RID: 277
		ApplyBuffS2cRequestNotify = 17614,
		// Token: 0x04000116 RID: 278
		ApplyBuffS2cResponsePush = 17435,
		// Token: 0x04000117 RID: 279
		RemoveBuffS2cRequestNotify = 28392,
		// Token: 0x04000118 RID: 280
		RemoveBuffS2cResponsePush = 16300,
		// Token: 0x04000119 RID: 281
		RemoveBuffByIdS2cRequestNotify = 25284,
		// Token: 0x0400011A RID: 282
		RemoveBuffByIdS2cResponsePush = 15939,
		// Token: 0x0400011B RID: 283
		ActivateBuffRequest = 27416,
		// Token: 0x0400011C RID: 284
		ActivateBuffResponse = 19166,
		// Token: 0x0400011D RID: 285
		ActivateBuffNotify = 29719,
		// Token: 0x0400011E RID: 286
		OrderRemoveBuffByTagsRequest = 20210,
		// Token: 0x0400011F RID: 287
		OrderRemoveBuffByTagsResponse = 20335,
		// Token: 0x04000120 RID: 288
		OrderRemoveBuffByTagsNotify = 23871,
		// Token: 0x04000121 RID: 289
		BuffEffectExecuteRequest = 19635,
		// Token: 0x04000122 RID: 290
		BuffEffectExecuteResponse = 27923,
		// Token: 0x04000123 RID: 291
		BuffStackCountRequest = 24150,
		// Token: 0x04000124 RID: 292
		BuffStackCountResponse = 16438,
		// Token: 0x04000125 RID: 293
		BuffStackCountNotify = 19317,
		// Token: 0x04000126 RID: 294
		BuffEffectRequest = 22402,
		// Token: 0x04000127 RID: 295
		BuffEffectResponse = 20053,
		// Token: 0x04000128 RID: 296
		BuffItemRequest = 17824,
		// Token: 0x04000129 RID: 297
		BuffItemResponse = 21929,
		// Token: 0x0400012A RID: 298
		BuffItemNotify = 19426,
		// Token: 0x0400012B RID: 299
		BuffItemUpdateNotify = 15200,
		// Token: 0x0400012C RID: 300
		CalabashMsgNotify = 29927,
		// Token: 0x0400012D RID: 301
		CalabashMsgRequest = 23687,
		// Token: 0x0400012E RID: 302
		CalabashMsgResponse = 15659,
		// Token: 0x0400012F RID: 303
		CalabashExpAddNotify = 20523,
		// Token: 0x04000130 RID: 304
		CalabashDevelopRewardUnlockNotify = 17081,
		// Token: 0x04000131 RID: 305
		CalabashLevelsRewardNotify = 19440,
		// Token: 0x04000132 RID: 306
		CalabashLevelRewardRequest = 28983,
		// Token: 0x04000133 RID: 307
		CalabashLevelRewardResponse = 23187,
		// Token: 0x04000134 RID: 308
		CdKeyVerifyRequest = 17701,
		// Token: 0x04000135 RID: 309
		CdKeyVerifyResponse = 19513,
		// Token: 0x04000136 RID: 310
		ChatRequest = 28634,
		// Token: 0x04000137 RID: 311
		ChatResponse = 26663,
		// Token: 0x04000138 RID: 312
		ChatNotify = 27064,
		// Token: 0x04000139 RID: 313
		SysInfoNotify = 23221,
		// Token: 0x0400013A RID: 314
		SysErrorNotify = 27956,
		// Token: 0x0400013B RID: 315
		ConsoleNotify = 19286,
		// Token: 0x0400013C RID: 316
		PrivateChatRequest = 18832,
		// Token: 0x0400013D RID: 317
		PrivateChatResponse = 21677,
		// Token: 0x0400013E RID: 318
		PrivateMessageNotify = 21956,
		// Token: 0x0400013F RID: 319
		PrivateChatHistoryRequest = 20338,
		// Token: 0x04000140 RID: 320
		PrivateChatHistoryResponse = 24958,
		// Token: 0x04000141 RID: 321
		PrivateChatHistoryNotify = 16299,
		// Token: 0x04000142 RID: 322
		PrivateChatDataRequest = 17748,
		// Token: 0x04000143 RID: 323
		PrivateChatDataResponse = 27414,
		// Token: 0x04000144 RID: 324
		ChatMutePlayerRequest = 26518,
		// Token: 0x04000145 RID: 325
		ChatMutePlayerResponse = 26851,
		// Token: 0x04000146 RID: 326
		PrivateChatOperateRequest = 16521,
		// Token: 0x04000147 RID: 327
		PrivateChatOperateResponse = 26788,
		// Token: 0x04000148 RID: 328
		ChatMutePlayerListNotify = 29806,
		// Token: 0x04000149 RID: 329
		ChannelChatRequest = 18878,
		// Token: 0x0400014A RID: 330
		ChannelChatResponse = 20052,
		// Token: 0x0400014B RID: 331
		ChannelChatMessageNotify = 19107,
		// Token: 0x0400014C RID: 332
		ChannelChatHistoryNotify = 24562,
		// Token: 0x0400014D RID: 333
		CombatSendPackRequest = 26497,
		// Token: 0x0400014E RID: 334
		CombatSendPackResponse = 21536,
		// Token: 0x0400014F RID: 335
		CombatReceivePackNotify = 29973,
		// Token: 0x04000150 RID: 336
		CombatMaxCaseMessageRequest = 28528,
		// Token: 0x04000151 RID: 337
		CombatMaxCaseMessageResponse = 15035,
		// Token: 0x04000152 RID: 338
		PhotographPush = 27304,
		// Token: 0x04000153 RID: 339
		ControlInfoNotify = 22309,
		// Token: 0x04000154 RID: 340
		AddForbidControlNotify = 19356,
		// Token: 0x04000155 RID: 341
		RemoveForbidControlNotify = 25975,
		// Token: 0x04000156 RID: 342
		FixToolRequest = 16354,
		// Token: 0x04000157 RID: 343
		FixToolResponse = 20809,
		// Token: 0x04000158 RID: 344
		CookFormulaRequest = 27218,
		// Token: 0x04000159 RID: 345
		CookFormulaResponse = 23024,
		// Token: 0x0400015A RID: 346
		CookFoodRequest = 29582,
		// Token: 0x0400015B RID: 347
		CookFoodResponse = 23883,
		// Token: 0x0400015C RID: 348
		FoodProcessRequest = 21214,
		// Token: 0x0400015D RID: 349
		FoodProcessResponse = 23327,
		// Token: 0x0400015E RID: 350
		CertificateLevelRewardRequest = 15228,
		// Token: 0x0400015F RID: 351
		CertificateLevelRewardResponse = 25731,
		// Token: 0x04000160 RID: 352
		CookingInfoUpdateNotify = 24324,
		// Token: 0x04000161 RID: 353
		CookingFormulaUpdateNotify = 28308,
		// Token: 0x04000162 RID: 354
		CookingDataRequest = 24585,
		// Token: 0x04000163 RID: 355
		CookingDataResponse = 26168,
		// Token: 0x04000164 RID: 356
		InteractiveUpdateRequest = 23869,
		// Token: 0x04000165 RID: 357
		InteractiveUpdateResponse = 23737,
		// Token: 0x04000166 RID: 358
		DailyAdventureTaskUpdateNotify = 28227,
		// Token: 0x04000167 RID: 359
		DailyAdventurePtRewardRequest = 24837,
		// Token: 0x04000168 RID: 360
		DailyAdventurePtRewardResponse = 17678,
		// Token: 0x04000169 RID: 361
		DailyAdventureTaskRewardRequest = 23720,
		// Token: 0x0400016A RID: 362
		DailyAdventureTaskRewardResponse = 17499,
		// Token: 0x0400016B RID: 363
		CheatInputRequest = 16047,
		// Token: 0x0400016C RID: 364
		CheatInputResponse = 27253,
		// Token: 0x0400016D RID: 365
		DamageRecordNotify = 15583,
		// Token: 0x0400016E RID: 366
		EnableDamageRecordRequest = 27554,
		// Token: 0x0400016F RID: 367
		EnableDamageRecordResponse = 27761,
		// Token: 0x04000170 RID: 368
		GmVoxelInfoNotify = 23572,
		// Token: 0x04000171 RID: 369
		GmIsOverlapNotify = 26170,
		// Token: 0x04000172 RID: 370
		OutputDebugInfoRequest = 20551,
		// Token: 0x04000173 RID: 371
		OutputDebugInfoResponse = 22307,
		// Token: 0x04000174 RID: 372
		DropInBagNotify = 28463,
		// Token: 0x04000175 RID: 373
		PickUpDropItemRequest = 29110,
		// Token: 0x04000176 RID: 374
		PickUpDropItemResponse = 24726,
		// Token: 0x04000177 RID: 375
		ElevatorStateChangeRequest = 22336,
		// Token: 0x04000178 RID: 376
		ElevatorStateChangeResponse = 19002,
		// Token: 0x04000179 RID: 377
		ElevatorMoveNotify = 19828,
		// Token: 0x0400017A RID: 378
		EnergyUpdateNotify = 24514,
		// Token: 0x0400017B RID: 379
		EnergySyncRequest = 17150,
		// Token: 0x0400017C RID: 380
		EnergySyncResponse = 16637,
		// Token: 0x0400017D RID: 381
		ChangeStateRequest = 20524,
		// Token: 0x0400017E RID: 382
		ChangeStateResponse = 28519,
		// Token: 0x0400017F RID: 383
		ChangeStateNotify = 19168,
		// Token: 0x04000180 RID: 384
		ChangeStateConfirmRequest = 17371,
		// Token: 0x04000181 RID: 385
		ChangeStateConfirmResponse = 22660,
		// Token: 0x04000182 RID: 386
		ChangeStateConfirmNotify = 27547,
		// Token: 0x04000183 RID: 387
		FsmConditionPassRequest = 21831,
		// Token: 0x04000184 RID: 388
		FsmConditionPassResponse = 18028,
		// Token: 0x04000185 RID: 389
		FsmResetNotify = 28366,
		// Token: 0x04000186 RID: 390
		FsmBlackboardNotify = 21151,
		// Token: 0x04000187 RID: 391
		FsmCustomBlackboardNotify = 18543,
		// Token: 0x04000188 RID: 392
		GmEntityFsmGroupInfoRequest = 24535,
		// Token: 0x04000189 RID: 393
		GmEntityFsmGroupInfoResponse = 19279,
		// Token: 0x0400018A RID: 394
		EntityAddNotify = 20302,
		// Token: 0x0400018B RID: 395
		EntityRemoveNotify = 17927,
		// Token: 0x0400018C RID: 396
		CommonOrganActionListNotify = 25907,
		// Token: 0x0400018D RID: 397
		TestSpawnTemplateEntityPush = 28168,
		// Token: 0x0400018E RID: 398
		EntranceStateNotify = 25612,
		// Token: 0x0400018F RID: 399
		EntityBuffProducerRequest = 18892,
		// Token: 0x04000190 RID: 400
		EntityBuffProducerResponse = 18914,
		// Token: 0x04000191 RID: 401
		EntityBuffProducerOperateRequest = 25261,
		// Token: 0x04000192 RID: 402
		EntityBuffProducerOperateResponse = 22978,
		// Token: 0x04000193 RID: 403
		LogicStateInitRequest = 18260,
		// Token: 0x04000194 RID: 404
		LogicStateInitResponse = 29984,
		// Token: 0x04000195 RID: 405
		LogicStateInitNotify = 16553,
		// Token: 0x04000196 RID: 406
		SwitchLogicStateRequest = 17062,
		// Token: 0x04000197 RID: 407
		SwitchLogicStateResponse = 22141,
		// Token: 0x04000198 RID: 408
		SwitchLogicStateNotify = 25764,
		// Token: 0x04000199 RID: 409
		EntityActiveRequest = 26157,
		// Token: 0x0400019A RID: 410
		EntityActiveResponse = 19734,
		// Token: 0x0400019B RID: 411
		AnimationGameplayTagRequest = 20782,
		// Token: 0x0400019C RID: 412
		AnimationGameplayTagResponse = 18524,
		// Token: 0x0400019D RID: 413
		AnimationGameplayTagNotify = 17808,
		// Token: 0x0400019E RID: 414
		AnimalDieRequest = 20952,
		// Token: 0x0400019F RID: 415
		AnimalDieResponse = 15258,
		// Token: 0x040001A0 RID: 416
		AnimalDieNotify = 24686,
		// Token: 0x040001A1 RID: 417
		AnimalDestroyRequest = 26360,
		// Token: 0x040001A2 RID: 418
		AnimalDestroyResponse = 26151,
		// Token: 0x040001A3 RID: 419
		AnimalDropRequest = 27068,
		// Token: 0x040001A4 RID: 420
		AnimalDropResponse = 29883,
		// Token: 0x040001A5 RID: 421
		EntityStateReadyNotify = 27022,
		// Token: 0x040001A6 RID: 422
		EntityInteractRequest = 23858,
		// Token: 0x040001A7 RID: 423
		EntityInteractResponse = 29979,
		// Token: 0x040001A8 RID: 424
		EntityRandomInteractRequest = 18332,
		// Token: 0x040001A9 RID: 425
		EntityRandomInteractResponse = 25922,
		// Token: 0x040001AA RID: 426
		EntityDynamicInteractRequest = 15821,
		// Token: 0x040001AB RID: 427
		EntityDynamicInteractResponse = 29039,
		// Token: 0x040001AC RID: 428
		EntityAddDynamicInteractNotify = 17186,
		// Token: 0x040001AD RID: 429
		EntityChangeDynamicInteractTextNotify = 25073,
		// Token: 0x040001AE RID: 430
		EntityRemoveDynamicInteractNotify = 18312,
		// Token: 0x040001AF RID: 431
		EntityInteractingNotify = 17894,
		// Token: 0x040001B0 RID: 432
		EntityAddBubbleNotify = 22334,
		// Token: 0x040001B1 RID: 433
		EntityRemoveBubbleNotify = 21182,
		// Token: 0x040001B2 RID: 434
		EntityPosAbnormalRequest = 26177,
		// Token: 0x040001B3 RID: 435
		EntityPosAbnormalResponse = 24226,
		// Token: 0x040001B4 RID: 436
		EntityAdsorbRequest = 24232,
		// Token: 0x040001B5 RID: 437
		EntityAdsorbResponse = 27477,
		// Token: 0x040001B6 RID: 438
		BoneVisibleChangeRequest = 18467,
		// Token: 0x040001B7 RID: 439
		BoneVisibleChangeResponse = 21695,
		// Token: 0x040001B8 RID: 440
		BoneVisibleChangeNotify = 29713,
		// Token: 0x040001B9 RID: 441
		EntityEquipChangeNotify = 27672,
		// Token: 0x040001BA RID: 442
		EntityStaticHookMoveRequest = 23825,
		// Token: 0x040001BB RID: 443
		EntityStaticHookMoveResponse = 15040,
		// Token: 0x040001BC RID: 444
		EntityStaticHookMoveNotify = 26154,
		// Token: 0x040001BD RID: 445
		SilenceNpcNotify = 17104,
		// Token: 0x040001BE RID: 446
		EntityPatrolStartRequest = 26715,
		// Token: 0x040001BF RID: 447
		EntityPatrolStartResponse = 19013,
		// Token: 0x040001C0 RID: 448
		EntityPatrolStopRequest = 24266,
		// Token: 0x040001C1 RID: 449
		EntityPatrolStopResponse = 19611,
		// Token: 0x040001C2 RID: 450
		EntityPatrolChangeDirRequest = 16389,
		// Token: 0x040001C3 RID: 451
		EntityPatrolChangeDirResponse = 26449,
		// Token: 0x040001C4 RID: 452
		VfxNpcPatrolFinishRequest = 26210,
		// Token: 0x040001C5 RID: 453
		VfxNpcPatrolFinishResponse = 16241,
		// Token: 0x040001C6 RID: 454
		EntitySendEventRequest = 22433,
		// Token: 0x040001C7 RID: 455
		EntitySendEventResponse = 21355,
		// Token: 0x040001C8 RID: 456
		AccessPasserbyNpcSpawnerRequest = 21857,
		// Token: 0x040001C9 RID: 457
		AccessPasserbyNpcSpawnerResponse = 17585,
		// Token: 0x040001CA RID: 458
		ExploreProgressRequest = 19630,
		// Token: 0x040001CB RID: 459
		ExploreProgressResponse = 29853,
		// Token: 0x040001CC RID: 460
		ExploreScoreRewardRequest = 23970,
		// Token: 0x040001CD RID: 461
		ExploreScoreRewardResponse = 18852,
		// Token: 0x040001CE RID: 462
		CountryExploreScoreInfoRequest = 16184,
		// Token: 0x040001CF RID: 463
		CountryExploreScoreInfoResponse = 24983,
		// Token: 0x040001D0 RID: 464
		ExploreLevelNotify = 24649,
		// Token: 0x040001D1 RID: 465
		ExploreToolUpdateNotify = 26462,
		// Token: 0x040001D2 RID: 466
		ExploreToolAllNotify = 23555,
		// Token: 0x040001D3 RID: 467
		ExploreSkillRouletteUpdateNotify = 25728,
		// Token: 0x040001D4 RID: 468
		VisionExploreSkillSetRequest = 16974,
		// Token: 0x040001D5 RID: 469
		VisionExploreSkillSetResponse = 18378,
		// Token: 0x040001D6 RID: 470
		VisionExploreSkillNotify = 17772,
		// Token: 0x040001D7 RID: 471
		ExploreSkillRouletteSetRequest = 15609,
		// Token: 0x040001D8 RID: 472
		ExploreSkillRouletteSetResponse = 27182,
		// Token: 0x040001D9 RID: 473
		ExploreSkillPullGiantRequest = 25809,
		// Token: 0x040001DA RID: 474
		ExploreSkillPullGiantResponse = 21630,
		// Token: 0x040001DB RID: 475
		UseDetectionSkillRequest = 29977,
		// Token: 0x040001DC RID: 476
		UseDetectionSkillResponse = 23849,
		// Token: 0x040001DD RID: 477
		ExploreToolAuthorizationNotify = 16622,
		// Token: 0x040001DE RID: 478
		SetFanNumberOfTurnsRequest = 22814,
		// Token: 0x040001DF RID: 479
		SetFanNumberOfTurnsResponse = 27911,
		// Token: 0x040001E0 RID: 480
		SetBaoziStateRequest = 28381,
		// Token: 0x040001E1 RID: 481
		SetBaoziStateResponse = 29269,
		// Token: 0x040001E2 RID: 482
		SetFanStateRequest = 16914,
		// Token: 0x040001E3 RID: 483
		SetFanStateResponse = 24361,
		// Token: 0x040001E4 RID: 484
		RoleFavorListRequest = 22639,
		// Token: 0x040001E5 RID: 485
		RoleFavorListResponse = 28736,
		// Token: 0x040001E6 RID: 486
		RoleFavorListNotify = 29381,
		// Token: 0x040001E7 RID: 487
		RoleFavorActiveNotify = 18931,
		// Token: 0x040001E8 RID: 488
		RoleFavorLevelUpdateNotify = 18110,
		// Token: 0x040001E9 RID: 489
		RoleFavorNewCanUnLockNotify = 24807,
		// Token: 0x040001EA RID: 490
		RoleFavorExpTipsNotify = 18293,
		// Token: 0x040001EB RID: 491
		RoleFavorFinishConditionNotify = 25609,
		// Token: 0x040001EC RID: 492
		RoleFavorUnLockRequest = 18650,
		// Token: 0x040001ED RID: 493
		RoleFavorUnLockResponse = 21000,
		// Token: 0x040001EE RID: 494
		RoleFavorNewQuestUpdateNotify = 26296,
		// Token: 0x040001EF RID: 495
		RoleFavorAcceptQuestRequest = 27516,
		// Token: 0x040001F0 RID: 496
		RoleFavorAcceptQuestResponse = 17922,
		// Token: 0x040001F1 RID: 497
		RoleFavorTalkScoreRequest = 18847,
		// Token: 0x040001F2 RID: 498
		RoleFavorTalkScoreResponse = 15509,
		// Token: 0x040001F3 RID: 499
		RoleMotionUnLockRequest = 29130,
		// Token: 0x040001F4 RID: 500
		RoleMotionUnLockResponse = 24424,
		// Token: 0x040001F5 RID: 501
		RoleMotionNewCanUnLockNotify = 29340,
		// Token: 0x040001F6 RID: 502
		RoleMotionActiveNotify = 23591,
		// Token: 0x040001F7 RID: 503
		RoleMotionListNotify = 16046,
		// Token: 0x040001F8 RID: 504
		RoleMotionFinishConditionNotify = 25957,
		// Token: 0x040001F9 RID: 505
		SkillRequest = 28732,
		// Token: 0x040001FA RID: 506
		SkillResponse = 17453,
		// Token: 0x040001FB RID: 507
		SkillNotify = 19915,
		// Token: 0x040001FC RID: 508
		UseSkillRequest = 15873,
		// Token: 0x040001FD RID: 509
		UseSkillResponse = 21045,
		// Token: 0x040001FE RID: 510
		UseSkillNotify = 19813,
		// Token: 0x040001FF RID: 511
		EndSkillRequest = 26657,
		// Token: 0x04000200 RID: 512
		EndSkillResponse = 24932,
		// Token: 0x04000201 RID: 513
		EndSkillNotify = 27580,
		// Token: 0x04000202 RID: 514
		InterruptSkillInDelayRequest = 24013,
		// Token: 0x04000203 RID: 515
		InterruptSkillInDelayResponse = 28034,
		// Token: 0x04000204 RID: 516
		UseSkillFailRequest = 15861,
		// Token: 0x04000205 RID: 517
		UseSkillFailResponse = 22556,
		// Token: 0x04000206 RID: 518
		HitRequest = 17489,
		// Token: 0x04000207 RID: 519
		HitResponse = 27996,
		// Token: 0x04000208 RID: 520
		HitNotify = 20656,
		// Token: 0x04000209 RID: 521
		HitEndRequest = 19130,
		// Token: 0x0400020A RID: 522
		HitEndResponse = 27143,
		// Token: 0x0400020B RID: 523
		CaughtRequest = 17706,
		// Token: 0x0400020C RID: 524
		CaughtResponse = 22560,
		// Token: 0x0400020D RID: 525
		CaughtNotify = 29446,
		// Token: 0x0400020E RID: 526
		CreateBulletRequest = 18246,
		// Token: 0x0400020F RID: 527
		CreateBulletResponse = 19384,
		// Token: 0x04000210 RID: 528
		CreateBulletNotify = 15915,
		// Token: 0x04000211 RID: 529
		DestroyBulletRequest = 27103,
		// Token: 0x04000212 RID: 530
		DestroyBulletResponse = 29062,
		// Token: 0x04000213 RID: 531
		DestroyBulletNotify = 16659,
		// Token: 0x04000214 RID: 532
		ModifyBulletParamsRequest = 29414,
		// Token: 0x04000215 RID: 533
		ModifyBulletParamsResponse = 17302,
		// Token: 0x04000216 RID: 534
		ModifyBulletParamsNotify = 28690,
		// Token: 0x04000217 RID: 535
		DamageExecuteRequest = 18654,
		// Token: 0x04000218 RID: 536
		DamageExecuteResponse = 16478,
		// Token: 0x04000219 RID: 537
		DamageExecuteNotify = 28829,
		// Token: 0x0400021A RID: 538
		PassiveSkillAddRequest = 17475,
		// Token: 0x0400021B RID: 539
		PassiveSkillAddResponse = 26311,
		// Token: 0x0400021C RID: 540
		PassiveSkillRemoveRequest = 20977,
		// Token: 0x0400021D RID: 541
		PassiveSkillRemoveResponse = 22073,
		// Token: 0x0400021E RID: 542
		PassiveSkillAddNotify = 25025,
		// Token: 0x0400021F RID: 543
		PassiveSkillRemoveNotify = 21248,
		// Token: 0x04000220 RID: 544
		EnterViewDirectionRequest = 25151,
		// Token: 0x04000221 RID: 545
		EnterViewDirectionResponse = 28371,
		// Token: 0x04000222 RID: 546
		ExitViewDirectionRequest = 16245,
		// Token: 0x04000223 RID: 547
		ExitViewDirectionResponse = 28401,
		// Token: 0x04000224 RID: 548
		TriggerExitSkillRequest = 23172,
		// Token: 0x04000225 RID: 549
		TriggerExitSkillResponse = 18531,
		// Token: 0x04000226 RID: 550
		CharacterDeathPush = 23389,
		// Token: 0x04000227 RID: 551
		CharacterDeathRequest = 21948,
		// Token: 0x04000228 RID: 552
		CharacterDeathResponse = 25795,
		// Token: 0x04000229 RID: 553
		InstFightEndPush = 27687,
		// Token: 0x0400022A RID: 554
		SwitchBattleModeRequest = 18672,
		// Token: 0x0400022B RID: 555
		SwitchBattleModeResponse = 19436,
		// Token: 0x0400022C RID: 556
		SwitchBattleModeNotify = 24840,
		// Token: 0x0400022D RID: 557
		BattleLogNotify = 19877,
		// Token: 0x0400022E RID: 558
		LandingDamageRequest = 27510,
		// Token: 0x0400022F RID: 559
		LandingDamageResponse = 27519,
		// Token: 0x04000230 RID: 560
		EntityIsVisibleRequest = 26500,
		// Token: 0x04000231 RID: 561
		EntityIsVisibleResponse = 27947,
		// Token: 0x04000232 RID: 562
		EntityIsVisibleNotify = 27390,
		// Token: 0x04000233 RID: 563
		ActorVisibleRequest = 17594,
		// Token: 0x04000234 RID: 564
		ActorVisibleResponse = 23563,
		// Token: 0x04000235 RID: 565
		ActorVisibleNotify = 29002,
		// Token: 0x04000236 RID: 566
		SwitchCharacterStateRequest = 26359,
		// Token: 0x04000237 RID: 567
		SwitchCharacterStateResponse = 26238,
		// Token: 0x04000238 RID: 568
		SwitchCharacterStateNotify = 17711,
		// Token: 0x04000239 RID: 569
		BattleStateChangeRequest = 19982,
		// Token: 0x0400023A RID: 570
		BattleStateChangeResponse = 22078,
		// Token: 0x0400023B RID: 571
		BattleStateChangeNotify = 17671,
		// Token: 0x0400023C RID: 572
		ToughCalcExtraRatioChangeRequest = 25451,
		// Token: 0x0400023D RID: 573
		ToughCalcExtraRatioChangeResponse = 29306,
		// Token: 0x0400023E RID: 574
		MonsterBoomRequest = 17163,
		// Token: 0x0400023F RID: 575
		MonsterBoomResponse = 28184,
		// Token: 0x04000240 RID: 576
		EntityBattleInfoRequest = 23936,
		// Token: 0x04000241 RID: 577
		EntityBattleInfoResponse = 23069,
		// Token: 0x04000242 RID: 578
		MontagePlayRequest = 27974,
		// Token: 0x04000243 RID: 579
		MontagePlayResponse = 19825,
		// Token: 0x04000244 RID: 580
		MontagePlayNotify = 19227,
		// Token: 0x04000245 RID: 581
		ANStartRequest = 25509,
		// Token: 0x04000246 RID: 582
		ANStartResponse = 25684,
		// Token: 0x04000247 RID: 583
		ANStartNotify = 16944,
		// Token: 0x04000248 RID: 584
		CharacterBattleStateChangeNotify = 16199,
		// Token: 0x04000249 RID: 585
		PlayerBattleStateChangeNotify = 15313,
		// Token: 0x0400024A RID: 586
		ShieldUpdateNotify = 27866,
		// Token: 0x0400024B RID: 587
		SwitchRoleRequest = 27457,
		// Token: 0x0400024C RID: 588
		SwitchRoleResponse = 16820,
		// Token: 0x0400024D RID: 589
		SwitchRoleNotify = 26835,
		// Token: 0x0400024E RID: 590
		DieSwitchRoleNotify = 23281,
		// Token: 0x0400024F RID: 591
		UpdateFormationRequest = 23144,
		// Token: 0x04000250 RID: 592
		UpdateFormationResponse = 24546,
		// Token: 0x04000251 RID: 593
		UpdateFormationNotify = 20593,
		// Token: 0x04000252 RID: 594
		UpdateFightRoleRequest = 24496,
		// Token: 0x04000253 RID: 595
		UpdateFightRoleResponse = 19583,
		// Token: 0x04000254 RID: 596
		FormationAutoAddRoleNotify = 28861,
		// Token: 0x04000255 RID: 597
		GetFormationDataRequest = 20343,
		// Token: 0x04000256 RID: 598
		GetFormationDataResponse = 18668,
		// Token: 0x04000257 RID: 599
		FormationUpdateNotify = 19741,
		// Token: 0x04000258 RID: 600
		FlowStartNotify = 25049,
		// Token: 0x04000259 RID: 601
		FlowEndRequest = 26672,
		// Token: 0x0400025A RID: 602
		FlowEndResponse = 29872,
		// Token: 0x0400025B RID: 603
		FlowEndNotify = 29697,
		// Token: 0x0400025C RID: 604
		FlowRestartRequest = 24285,
		// Token: 0x0400025D RID: 605
		FlowRestartResponse = 23746,
		// Token: 0x0400025E RID: 606
		FlowActionRequest = 22962,
		// Token: 0x0400025F RID: 607
		FlowActionResponse = 29226,
		// Token: 0x04000260 RID: 608
		FlowShowEntityNotify = 28233,
		// Token: 0x04000261 RID: 609
		ShowPasserByNpcNotify = 29077,
		// Token: 0x04000262 RID: 610
		FlowServerSkipNotify = 21217,
		// Token: 0x04000263 RID: 611
		ForgeInfoRequest = 16907,
		// Token: 0x04000264 RID: 612
		ForgeInfoResponse = 18747,
		// Token: 0x04000265 RID: 613
		ForgeItemRequest = 21849,
		// Token: 0x04000266 RID: 614
		ForgeItemResponse = 24992,
		// Token: 0x04000267 RID: 615
		ForgeItemInfoUpdateNotify = 28572,
		// Token: 0x04000268 RID: 616
		ForgeFormulaUnlockRequest = 23395,
		// Token: 0x04000269 RID: 617
		ForgeFormulaUnlockResponse = 26326,
		// Token: 0x0400026A RID: 618
		FormationRequest = 22596,
		// Token: 0x0400026B RID: 619
		FormationResponse = 20142,
		// Token: 0x0400026C RID: 620
		FormationSwitchCurrentRequest = 25699,
		// Token: 0x0400026D RID: 621
		FormationSwitchCurrentResponse = 22323,
		// Token: 0x0400026E RID: 622
		FormationModifyRequest = 15057,
		// Token: 0x0400026F RID: 623
		FormationModifyResponse = 18825,
		// Token: 0x04000270 RID: 624
		FormationChangeRequest = 16758,
		// Token: 0x04000271 RID: 625
		FormationChangeResponse = 18622,
		// Token: 0x04000272 RID: 626
		FormationSwitchRoleRequest = 22661,
		// Token: 0x04000273 RID: 627
		FormationSwitchRoleResponse = 27628,
		// Token: 0x04000274 RID: 628
		PbFormationAutoAddRoleNotify = 21027,
		// Token: 0x04000275 RID: 629
		PhantomFormationChangeNotify = 16773,
		// Token: 0x04000276 RID: 630
		ClientCurrentRoleReportRequest = 19037,
		// Token: 0x04000277 RID: 631
		ClientCurrentRoleReportResponse = 15392,
		// Token: 0x04000278 RID: 632
		FriendAllRequest = 29479,
		// Token: 0x04000279 RID: 633
		FriendAllResponse = 20502,
		// Token: 0x0400027A RID: 634
		FriendAddedNotify = 23136,
		// Token: 0x0400027B RID: 635
		FriendDeletedNotify = 15578,
		// Token: 0x0400027C RID: 636
		FriendApplyReceivedNotify = 17101,
		// Token: 0x0400027D RID: 637
		FriendApplyDeletedNotify = 18666,
		// Token: 0x0400027E RID: 638
		FriendApplySendRequest = 19323,
		// Token: 0x0400027F RID: 639
		FriendApplySendResponse = 15562,
		// Token: 0x04000280 RID: 640
		FriendApplyHandleRequest = 24610,
		// Token: 0x04000281 RID: 641
		FriendApplyHandleResponse = 20998,
		// Token: 0x04000282 RID: 642
		FriendRemarkRequest = 19201,
		// Token: 0x04000283 RID: 643
		FriendRemarkResponse = 29476,
		// Token: 0x04000284 RID: 644
		FriendDeleteRequest = 27693,
		// Token: 0x04000285 RID: 645
		FriendDeleteResponse = 17425,
		// Token: 0x04000286 RID: 646
		FriendRecentlyTeamRequest = 22709,
		// Token: 0x04000287 RID: 647
		FriendRecentlyTeamResponse = 24249,
		// Token: 0x04000288 RID: 648
		FriendRecentlyTeamUpdateNotify = 26784,
		// Token: 0x04000289 RID: 649
		FuncOpenNotify = 19093,
		// Token: 0x0400028A RID: 650
		FuncOpenConfirmNotify = 19104,
		// Token: 0x0400028B RID: 651
		FuncOpenUpdateNotify = 18542,
		// Token: 0x0400028C RID: 652
		FuncShowRequest = 25127,
		// Token: 0x0400028D RID: 653
		FuncShowResponse = 21232,
		// Token: 0x0400028E RID: 654
		GachaInfoRequest = 25069,
		// Token: 0x0400028F RID: 655
		GachaInfoResponse = 22256,
		// Token: 0x04000290 RID: 656
		GachaRequest = 19232,
		// Token: 0x04000291 RID: 657
		GachaResponse = 28271,
		// Token: 0x04000292 RID: 658
		GachaResultNotify = 20485,
		// Token: 0x04000293 RID: 659
		GachaUsePoolRequest = 29160,
		// Token: 0x04000294 RID: 660
		GachaUsePoolResponse = 19735,
		// Token: 0x04000295 RID: 661
		GatherTaskRecordNotify = 25663,
		// Token: 0x04000296 RID: 662
		GatherClueInfoNotify = 19010,
		// Token: 0x04000297 RID: 663
		SubmitItemInfoNotify = 22681,
		// Token: 0x04000298 RID: 664
		GatherActivityRewardRequest = 22600,
		// Token: 0x04000299 RID: 665
		GatherActivityRewardResponse = 29225,
		// Token: 0x0400029A RID: 666
		GuideInfoRequest = 15732,
		// Token: 0x0400029B RID: 667
		GuideInfoResponse = 26611,
		// Token: 0x0400029C RID: 668
		GuideTriggerRequest = 27818,
		// Token: 0x0400029D RID: 669
		GuideTriggerResponse = 25835,
		// Token: 0x0400029E RID: 670
		GuideFinishRequest = 22758,
		// Token: 0x0400029F RID: 671
		GuideFinishResponse = 21373,
		// Token: 0x040002A0 RID: 672
		GuideCondDoneNotify = 18752,
		// Token: 0x040002A1 RID: 673
		HeartbeatRequest = 1650,
		// Token: 0x040002A2 RID: 674
		HeartbeatResponse,
		// Token: 0x040002A3 RID: 675
		GatewayEchoRequest = 29209,
		// Token: 0x040002A4 RID: 676
		GatewayEchoResponse = 23722,
		// Token: 0x040002A5 RID: 677
		IllustratedRedDotRequest = 17930,
		// Token: 0x040002A6 RID: 678
		IllustratedRedDotResponse = 26946,
		// Token: 0x040002A7 RID: 679
		IllustratedInfoRequest = 15484,
		// Token: 0x040002A8 RID: 680
		IllustratedInfoResponse = 28603,
		// Token: 0x040002A9 RID: 681
		IllustratedUnlockRequest = 19831,
		// Token: 0x040002AA RID: 682
		IllustratedUnlockResponse = 20078,
		// Token: 0x040002AB RID: 683
		IllustratedUnlockNotify = 29822,
		// Token: 0x040002AC RID: 684
		IllustratedReadRequest = 19077,
		// Token: 0x040002AD RID: 685
		IllustratedReadResponse = 27163,
		// Token: 0x040002AE RID: 686
		InfluenceInfoRequest = 29194,
		// Token: 0x040002AF RID: 687
		InfluenceInfoResponse = 21485,
		// Token: 0x040002B0 RID: 688
		InfluenceInfoUpdateNotify = 26930,
		// Token: 0x040002B1 RID: 689
		InfluenceRewardRequest = 19523,
		// Token: 0x040002B2 RID: 690
		InfluenceRewardResponse = 21130,
		// Token: 0x040002B3 RID: 691
		ReadDisplayInfoRequest = 22933,
		// Token: 0x040002B4 RID: 692
		ReadDisplayInfoResponse = 20372,
		// Token: 0x040002B5 RID: 693
		InstDataNotify = 18211,
		// Token: 0x040002B6 RID: 694
		UpdateEnterInfoNotify = 24015,
		// Token: 0x040002B7 RID: 695
		EnterInstRequest = 18872,
		// Token: 0x040002B8 RID: 696
		EnterInstResponse = 18932,
		// Token: 0x040002B9 RID: 697
		UnlockInstEntranceRequest = 16204,
		// Token: 0x040002BA RID: 698
		UnlockInstEntranceResponse = 24736,
		// Token: 0x040002BB RID: 699
		InstEntranceDetailRequest = 19282,
		// Token: 0x040002BC RID: 700
		InstEntranceDetailResponse = 26537,
		// Token: 0x040002BD RID: 701
		LeaveInstRequest = 21028,
		// Token: 0x040002BE RID: 702
		LeaveInstResponse = 20271,
		// Token: 0x040002BF RID: 703
		InstPlayDataNotify = 18768,
		// Token: 0x040002C0 RID: 704
		GetInstExchangeRewardRequest = 25904,
		// Token: 0x040002C1 RID: 705
		GetInstExchangeRewardResponse = 23064,
		// Token: 0x040002C2 RID: 706
		InstSettleNotify = 21939,
		// Token: 0x040002C3 RID: 707
		InstResultNotify = 26696,
		// Token: 0x040002C4 RID: 708
		ExchangeRewardInfoRequest = 25606,
		// Token: 0x040002C5 RID: 709
		ExchangeRewardInfoResponse = 23945,
		// Token: 0x040002C6 RID: 710
		ExchangeRewardInfoNotify = 22486,
		// Token: 0x040002C7 RID: 711
		ExchangeSharedInfoNotify = 23282,
		// Token: 0x040002C8 RID: 712
		InstTimeoutNotify = 27732,
		// Token: 0x040002C9 RID: 713
		SingleInstRechallengeRequest = 20682,
		// Token: 0x040002CA RID: 714
		SingleInstRechallengeResponse = 23802,
		// Token: 0x040002CB RID: 715
		ItemDecomposeRequest = 17570,
		// Token: 0x040002CC RID: 716
		ItemDecomposeResponse = 24230,
		// Token: 0x040002CD RID: 717
		ItemDecomposePreviewRequest = 26576,
		// Token: 0x040002CE RID: 718
		ItemDecomposePreviewResponse = 16064,
		// Token: 0x040002CF RID: 719
		ItemLockRequest = 26312,
		// Token: 0x040002D0 RID: 720
		ItemLockResponse = 22732,
		// Token: 0x040002D1 RID: 721
		ItemUseRequest = 15211,
		// Token: 0x040002D2 RID: 722
		ItemUseResponse = 21049,
		// Token: 0x040002D3 RID: 723
		ItemRewardNotify = 22096,
		// Token: 0x040002D4 RID: 724
		ItemGiftUseRequest = 25405,
		// Token: 0x040002D5 RID: 725
		ItemGiftUseResponse = 25639,
		// Token: 0x040002D6 RID: 726
		ItemGiftUseNotify = 18287,
		// Token: 0x040002D7 RID: 727
		NormalItemRequest = 17423,
		// Token: 0x040002D8 RID: 728
		NormalItemResponse = 22771,
		// Token: 0x040002D9 RID: 729
		NormalItemUpdateNotify = 27265,
		// Token: 0x040002DA RID: 730
		NormalItemRemoveNotify = 19848,
		// Token: 0x040002DB RID: 731
		NormalItemAddNotify = 24714,
		// Token: 0x040002DC RID: 732
		WeaponItemRequest = 28901,
		// Token: 0x040002DD RID: 733
		WeaponItemResponse = 24074,
		// Token: 0x040002DE RID: 734
		WeaponItemAddNotify = 22519,
		// Token: 0x040002DF RID: 735
		WeaponItemRemoveNotify = 19935,
		// Token: 0x040002E0 RID: 736
		PhantomItemRequest = 24954,
		// Token: 0x040002E1 RID: 737
		PhantomItemResponse = 24418,
		// Token: 0x040002E2 RID: 738
		PhantomItemAddNotify = 25657,
		// Token: 0x040002E3 RID: 739
		PhantomItemRemoveNotify = 15222,
		// Token: 0x040002E4 RID: 740
		ItemFuncValueUpdateNotify = 25472,
		// Token: 0x040002E5 RID: 741
		ItemObtainNotify = 18089,
		// Token: 0x040002E6 RID: 742
		ItemPkgOpenNotify = 17095,
		// Token: 0x040002E7 RID: 743
		InvalidItemRequest = 17597,
		// Token: 0x040002E8 RID: 744
		InvalidItemResponse = 25982,
		// Token: 0x040002E9 RID: 745
		ShowInvalidItemRequest = 22706,
		// Token: 0x040002EA RID: 746
		ShowInvalidItemResponse = 17796,
		// Token: 0x040002EB RID: 747
		ValidTimeItemRequest = 17241,
		// Token: 0x040002EC RID: 748
		ValidTimeItemResponse = 16298,
		// Token: 0x040002ED RID: 749
		ValidTimeItemUpdateNotify = 15855,
		// Token: 0x040002EE RID: 750
		ValidTimeItemRemoveNotify = 20989,
		// Token: 0x040002EF RID: 751
		ValidTimeItemAddNotify = 19758,
		// Token: 0x040002F0 RID: 752
		ItemExchangeInfoRequest = 16256,
		// Token: 0x040002F1 RID: 753
		ItemExchangeInfoResponse = 19721,
		// Token: 0x040002F2 RID: 754
		ItemExchangeRequest = 16929,
		// Token: 0x040002F3 RID: 755
		ItemExchangeResponse = 24645,
		// Token: 0x040002F4 RID: 756
		EnterLevelPlayNotify = 28613,
		// Token: 0x040002F5 RID: 757
		LeaveLevelPlayNotify = 25269,
		// Token: 0x040002F6 RID: 758
		LevelPlayInfoNotify = 28525,
		// Token: 0x040002F7 RID: 759
		LevelPlayFirstNotify = 28089,
		// Token: 0x040002F8 RID: 760
		LevelPlayStateNotify = 19272,
		// Token: 0x040002F9 RID: 761
		LevelPlayOpenTimeNotify = 27112,
		// Token: 0x040002FA RID: 762
		LevelPlayRewardRequest = 20160,
		// Token: 0x040002FB RID: 763
		LevelPlayRewardResponse = 17215,
		// Token: 0x040002FC RID: 764
		LevelPlayRewardNotify = 25939,
		// Token: 0x040002FD RID: 765
		LevelPlayRewardCountResetNotify = 24225,
		// Token: 0x040002FE RID: 766
		LivenessRequest = 19066,
		// Token: 0x040002FF RID: 767
		LivenessResponse = 26035,
		// Token: 0x04000300 RID: 768
		LivenessCountUpdateNotify = 22746,
		// Token: 0x04000301 RID: 769
		LivenessUpdateNotify = 20096,
		// Token: 0x04000302 RID: 770
		LivenessRefreshNotify = 17669,
		// Token: 0x04000303 RID: 771
		LivenessTaskTakeRequest = 29864,
		// Token: 0x04000304 RID: 772
		LivenessTaskTakeResponse = 23181,
		// Token: 0x04000305 RID: 773
		LivenessTakeRequest = 24082,
		// Token: 0x04000306 RID: 774
		LivenessTakeResponse = 15626,
		// Token: 0x04000307 RID: 775
		LoadEquipInfoRequest = 28824,
		// Token: 0x04000308 RID: 776
		LoadEquipInfoResponse = 29155,
		// Token: 0x04000309 RID: 777
		EquipTakeOnRequest = 21385,
		// Token: 0x0400030A RID: 778
		EquipTakeOnResponse = 29980,
		// Token: 0x0400030B RID: 779
		EquipTakeOnNotify = 25950,
		// Token: 0x0400030C RID: 780
		LordGymInfoRequest = 24178,
		// Token: 0x0400030D RID: 781
		LordGymInfoResponse = 24508,
		// Token: 0x0400030E RID: 782
		LordGymUnlockNotify = 25755,
		// Token: 0x0400030F RID: 783
		LordGymBeginRequest = 16902,
		// Token: 0x04000310 RID: 784
		LordGymBeginResponse = 25090,
		// Token: 0x04000311 RID: 785
		LordGymReadRequest = 22064,
		// Token: 0x04000312 RID: 786
		LordGymReadResponse = 21070,
		// Token: 0x04000313 RID: 787
		LordGymLevelPlayResultNotify = 17494,
		// Token: 0x04000314 RID: 788
		MailInfosNotify = 20632,
		// Token: 0x04000315 RID: 789
		MailDeleteNotify = 29079,
		// Token: 0x04000316 RID: 790
		MailAddNotify = 21273,
		// Token: 0x04000317 RID: 791
		MailReadRequest = 20227,
		// Token: 0x04000318 RID: 792
		MailReadResponse = 23666,
		// Token: 0x04000319 RID: 793
		MailGetAttachmentRequest = 15409,
		// Token: 0x0400031A RID: 794
		MailGetAttachmentResponse = 26747,
		// Token: 0x0400031B RID: 795
		MailDeleteRequest = 23960,
		// Token: 0x0400031C RID: 796
		MailDeleteResponse = 22089,
		// Token: 0x0400031D RID: 797
		MapMarkInfoRequest = 29776,
		// Token: 0x0400031E RID: 798
		MapMarkInfoResponse = 19613,
		// Token: 0x0400031F RID: 799
		MapUnlockFieldInfoRequest = 15442,
		// Token: 0x04000320 RID: 800
		MapUnlockFieldInfoResponse = 19902,
		// Token: 0x04000321 RID: 801
		MapMarkShowIdInfoUpdateNotify = 16700,
		// Token: 0x04000322 RID: 802
		MapMarkRequest = 16871,
		// Token: 0x04000323 RID: 803
		MapMarkResponse = 18621,
		// Token: 0x04000324 RID: 804
		MapRemoveMarkRequest = 16284,
		// Token: 0x04000325 RID: 805
		MapRemoveMarkResponse = 29212,
		// Token: 0x04000326 RID: 806
		MapUnlockFieldNotify = 22762,
		// Token: 0x04000327 RID: 807
		MapTraceInfoRequest = 20733,
		// Token: 0x04000328 RID: 808
		MapTraceInfoResponse = 20456,
		// Token: 0x04000329 RID: 809
		MapTraceRequest = 24772,
		// Token: 0x0400032A RID: 810
		MapTraceResponse = 24396,
		// Token: 0x0400032B RID: 811
		MapCancelTraceRequest = 17205,
		// Token: 0x0400032C RID: 812
		MapCancelTraceResponse = 26282,
		// Token: 0x0400032D RID: 813
		MapReplaceMarkRequest = 28254,
		// Token: 0x0400032E RID: 814
		MapReplaceMarkResponse = 25551,
		// Token: 0x0400032F RID: 815
		MapCancelTraceNotify = 17682,
		// Token: 0x04000330 RID: 816
		MapTraceNotify = 26739,
		// Token: 0x04000331 RID: 817
		MapRemoveAllMarkRequest = 26361,
		// Token: 0x04000332 RID: 818
		MapRemoveAllMarkResponse = 23743,
		// Token: 0x04000333 RID: 819
		MapMarkInfoNotify = 27725,
		// Token: 0x04000334 RID: 820
		UnlockMarkNotify = 25945,
		// Token: 0x04000335 RID: 821
		MapOpenPush = 19992,
		// Token: 0x04000336 RID: 822
		MapMarkInfoUpdateRequest = 26212,
		// Token: 0x04000337 RID: 823
		MapMarkInfoUpdateResponse = 26030,
		// Token: 0x04000338 RID: 824
		RemoveMarkInfoNotify = 26990,
		// Token: 0x04000339 RID: 825
		AddMarkInfoNotify = 19623,
		// Token: 0x0400033A RID: 826
		StartMatchRequest = 23965,
		// Token: 0x0400033B RID: 827
		StartMatchResponse = 24408,
		// Token: 0x0400033C RID: 828
		StartMatchNotify = 23110,
		// Token: 0x0400033D RID: 829
		CancelMatchRequest = 15153,
		// Token: 0x0400033E RID: 830
		CancelMatchResponse = 17155,
		// Token: 0x0400033F RID: 831
		CancelMatchNotify = 18579,
		// Token: 0x04000340 RID: 832
		MatchFailNotify = 23326,
		// Token: 0x04000341 RID: 833
		MatchTeamNotify = 25195,
		// Token: 0x04000342 RID: 834
		MatchConfirmRequest = 17484,
		// Token: 0x04000343 RID: 835
		MatchConfirmResponse = 15699,
		// Token: 0x04000344 RID: 836
		MatchConfirmNotify = 29850,
		// Token: 0x04000345 RID: 837
		MatchingNotify = 20424,
		// Token: 0x04000346 RID: 838
		MatchTeamStateNotify = 19812,
		// Token: 0x04000347 RID: 839
		MatchChangeRoleRequest = 21491,
		// Token: 0x04000348 RID: 840
		MatchChangeRoleResponse = 21111,
		// Token: 0x04000349 RID: 841
		MatchChangeRoleNotify = 24116,
		// Token: 0x0400034A RID: 842
		MatchChangeReadyRequest = 26852,
		// Token: 0x0400034B RID: 843
		MatchChangeReadyResponse = 20725,
		// Token: 0x0400034C RID: 844
		MatchChangeReadyNotify = 17363,
		// Token: 0x0400034D RID: 845
		LeaveMatchTeamRequest = 27683,
		// Token: 0x0400034E RID: 846
		LeaveMatchTeamResponse = 18375,
		// Token: 0x0400034F RID: 847
		LeaveMatchTeamNotify = 21476,
		// Token: 0x04000350 RID: 848
		EnterMatchTeamNotify = 23456,
		// Token: 0x04000351 RID: 849
		KickMatchTeamPlayerRequest = 24963,
		// Token: 0x04000352 RID: 850
		KickMatchTeamPlayerResponse = 21595,
		// Token: 0x04000353 RID: 851
		SetMatchTeamMatchFlagRequest = 22339,
		// Token: 0x04000354 RID: 852
		SetMatchTeamMatchFlagResponse = 19772,
		// Token: 0x04000355 RID: 853
		TeamMatchFlagNotify = 15636,
		// Token: 0x04000356 RID: 854
		EnterMatchInstRequest = 23840,
		// Token: 0x04000357 RID: 855
		EnterMatchInstResponse = 15610,
		// Token: 0x04000358 RID: 856
		TeamChallengeRequest = 16714,
		// Token: 0x04000359 RID: 857
		TeamChallengeResponse = 21288,
		// Token: 0x0400035A RID: 858
		TeamMatchInviteRequest = 18437,
		// Token: 0x0400035B RID: 859
		TeamMatchInviteResponse = 17491,
		// Token: 0x0400035C RID: 860
		TeamMatchInviteNotify = 24663,
		// Token: 0x0400035D RID: 861
		TeamMatchAcceptInviteRequest = 22419,
		// Token: 0x0400035E RID: 862
		TeamMatchAcceptInviteResponse = 26064,
		// Token: 0x0400035F RID: 863
		TeamMatchAcceptInviteNotify = 24254,
		// Token: 0x04000360 RID: 864
		MatchChangePlayerUiStateRequest = 29714,
		// Token: 0x04000361 RID: 865
		MatchChangePlayerUiStateResponse = 20111,
		// Token: 0x04000362 RID: 866
		MatchChangePlayerUiStateNotify = 16156,
		// Token: 0x04000363 RID: 867
		MessageDecodeFailNotify = 25607,
		// Token: 0x04000364 RID: 868
		HandInMingSuRequest = 20726,
		// Token: 0x04000365 RID: 869
		HandInMingSuResponse = 25984,
		// Token: 0x04000366 RID: 870
		ActiveDragonPoolRequest = 27171,
		// Token: 0x04000367 RID: 871
		ActiveDragonPoolResponse = 25761,
		// Token: 0x04000368 RID: 872
		DragonPoolConfRequest = 18045,
		// Token: 0x04000369 RID: 873
		DragonPoolConfResponse = 16385,
		// Token: 0x0400036A RID: 874
		MonsterGachaDataChangeNotify = 15207,
		// Token: 0x0400036B RID: 875
		MonthCardRequest = 22235,
		// Token: 0x0400036C RID: 876
		MonthCardResponse = 26286,
		// Token: 0x0400036D RID: 877
		MonthCardDailyRewardNotify = 28994,
		// Token: 0x0400036E RID: 878
		MonthCardUseNotify = 17882,
		// Token: 0x0400036F RID: 879
		MutiplayerTeamRefreshNearListRequest = 17426,
		// Token: 0x04000370 RID: 880
		MutiplayerTeamRefreshNearListResponse = 20108,
		// Token: 0x04000371 RID: 881
		NetTestDataPush = 24898,
		// Token: 0x04000372 RID: 882
		NetTestDataNotify = 15406,
		// Token: 0x04000373 RID: 883
		NetTestDataRequest = 17003,
		// Token: 0x04000374 RID: 884
		NetTestDataResponse = 23468,
		// Token: 0x04000375 RID: 885
		NewBieCourseRewardNotify = 18692,
		// Token: 0x04000376 RID: 886
		NewBieCourseRewardRequest = 28328,
		// Token: 0x04000377 RID: 887
		NewBieCourseRewardResponse = 17644,
		// Token: 0x04000378 RID: 888
		NewJourneyRequest = 21748,
		// Token: 0x04000379 RID: 889
		NewJourneyResponse = 17635,
		// Token: 0x0400037A RID: 890
		ParkourChallengeRequest = 21481,
		// Token: 0x0400037B RID: 891
		ParkourChallengeResponse = 28350,
		// Token: 0x0400037C RID: 892
		ParkourChallengeOpenNotify = 21077,
		// Token: 0x0400037D RID: 893
		ParkourChallengeTakeRequest = 24399,
		// Token: 0x0400037E RID: 894
		ParkourChallengeTakeResponse = 21667,
		// Token: 0x0400037F RID: 895
		ParkourChallengeEndNotify = 21009,
		// Token: 0x04000380 RID: 896
		ParkourChallengeTransRequest = 27756,
		// Token: 0x04000381 RID: 897
		ParkourChallengeTransResponse = 16542,
		// Token: 0x04000382 RID: 898
		PartComponentInitRequest = 18536,
		// Token: 0x04000383 RID: 899
		PartComponentInitResponse = 17051,
		// Token: 0x04000384 RID: 900
		PartComponentInitNotify = 25520,
		// Token: 0x04000385 RID: 901
		PartUpdateRequest = 22158,
		// Token: 0x04000386 RID: 902
		PartUpdateResponse = 23891,
		// Token: 0x04000387 RID: 903
		PartUpdateNotify = 24482,
		// Token: 0x04000388 RID: 904
		PayInfoRequest = 23421,
		// Token: 0x04000389 RID: 905
		PayInfoResponse = 21829,
		// Token: 0x0400038A RID: 906
		PayItemRequest = 16704,
		// Token: 0x0400038B RID: 907
		PayItemResponse = 22536,
		// Token: 0x0400038C RID: 908
		PayItemSuccessNotify = 25610,
		// Token: 0x0400038D RID: 909
		ResetSpecialBonusNotify = 21478,
		// Token: 0x0400038E RID: 910
		PayGiftInfoRequest = 21361,
		// Token: 0x0400038F RID: 911
		PayGiftInfoResponse = 15822,
		// Token: 0x04000390 RID: 912
		PayGiftRequest = 16617,
		// Token: 0x04000391 RID: 913
		PayGiftResponse = 21886,
		// Token: 0x04000392 RID: 914
		PayGiftSuccessNotify = 23351,
		// Token: 0x04000393 RID: 915
		PayShopInfoNotify = 29139,
		// Token: 0x04000394 RID: 916
		PayShopInfoRequest = 21126,
		// Token: 0x04000395 RID: 917
		PayShopInfoResponse = 28666,
		// Token: 0x04000396 RID: 918
		PayShopUpdateRequest = 29578,
		// Token: 0x04000397 RID: 919
		PayShopUpdateResponse = 26133,
		// Token: 0x04000398 RID: 920
		PayShopItemUpdateRequest = 21015,
		// Token: 0x04000399 RID: 921
		PayShopItemUpdateResponse = 16503,
		// Token: 0x0400039A RID: 922
		PayShopBuyRequest = 28780,
		// Token: 0x0400039B RID: 923
		PayShopBuyResponse = 19539,
		// Token: 0x0400039C RID: 924
		PayShopUnlockNotify = 16644,
		// Token: 0x0400039D RID: 925
		PayShopDirectBuyRequest = 28237,
		// Token: 0x0400039E RID: 926
		PayShopDirectBuyResponse = 29388,
		// Token: 0x0400039F RID: 927
		PayShopDirectBuyNotify = 18553,
		// Token: 0x040003A0 RID: 928
		PayShopConditionFinishNotify = 17751,
		// Token: 0x040003A1 RID: 929
		PhantomLevelUpRequest = 25666,
		// Token: 0x040003A2 RID: 930
		PhantomLevelUpResponse = 29647,
		// Token: 0x040003A3 RID: 931
		PhantomEquipInfoNotify = 29430,
		// Token: 0x040003A4 RID: 932
		PhantomPutOnRequest = 25608,
		// Token: 0x040003A5 RID: 933
		PhantomPutOnResponse = 21144,
		// Token: 0x040003A6 RID: 934
		PhantomReturnPreviewRequest = 18276,
		// Token: 0x040003A7 RID: 935
		PhantomReturnPreviewResponse = 21268,
		// Token: 0x040003A8 RID: 936
		PhantomReturnRequest = 16594,
		// Token: 0x040003A9 RID: 937
		PhantomReturnResponse = 20325,
		// Token: 0x040003AA RID: 938
		PhantomRecommendRequest = 21254,
		// Token: 0x040003AB RID: 939
		PhantomRecommendResponse = 26730,
		// Token: 0x040003AC RID: 940
		PhantomAutoPutRequest = 25130,
		// Token: 0x040003AD RID: 941
		PhantomAutoPutResponse = 21508,
		// Token: 0x040003AE RID: 942
		PhantomItemUpdateNotify = 16679,
		// Token: 0x040003AF RID: 943
		RolePhantomPropUpdateNotify = 23146,
		// Token: 0x040003B0 RID: 944
		PhantomIdentifyRequest = 26204,
		// Token: 0x040003B1 RID: 945
		PhantomIdentifyResponse = 19102,
		// Token: 0x040003B2 RID: 946
		PhantomUpdateNotify = 17025,
		// Token: 0x040003B3 RID: 947
		PhantomSkinAddNotify = 20095,
		// Token: 0x040003B4 RID: 948
		PhantomSkinChangeRequest = 22400,
		// Token: 0x040003B5 RID: 949
		PhantomSkinChangeResponse = 26665,
		// Token: 0x040003B6 RID: 950
		PhantomUnlockNotify = 27009,
		// Token: 0x040003B7 RID: 951
		PhantomRefiningRequest = 27747,
		// Token: 0x040003B8 RID: 952
		PhantomRefiningResponse = 27651,
		// Token: 0x040003B9 RID: 953
		PlayerAttrNotify = 17685,
		// Token: 0x040003BA RID: 954
		PassiveSkillNotify = 17786,
		// Token: 0x040003BB RID: 955
		UpdatePlayerPassiveSkillRequest = 20221,
		// Token: 0x040003BC RID: 956
		UpdatePlayerPassiveSkillResponse = 22796,
		// Token: 0x040003BD RID: 957
		PlayerVarNotify = 27186,
		// Token: 0x040003BE RID: 958
		PlayerMotionRequest = 17665,
		// Token: 0x040003BF RID: 959
		PlayerMotionResponse = 29174,
		// Token: 0x040003C0 RID: 960
		PressRequest = 15361,
		// Token: 0x040003C1 RID: 961
		PressResponse = 25825,
		// Token: 0x040003C2 RID: 962
		PressNotify = 15929,
		// Token: 0x040003C3 RID: 963
		PressGameRequest = 19675,
		// Token: 0x040003C4 RID: 964
		PressGameResponse = 23963,
		// Token: 0x040003C5 RID: 965
		PressGameNotify = 22674,
		// Token: 0x040003C6 RID: 966
		ProgressBarFinishRequest = 24347,
		// Token: 0x040003C7 RID: 967
		ProgressBarFinishResponse = 25134,
		// Token: 0x040003C8 RID: 968
		FormationAttrNotify = 16879,
		// Token: 0x040003C9 RID: 969
		FormationAttrRequest = 19501,
		// Token: 0x040003CA RID: 970
		FormationAttrResponse = 28542,
		// Token: 0x040003CB RID: 971
		RecoverPropChangedNotify = 17789,
		// Token: 0x040003CC RID: 972
		FragileChangeRequest = 22818,
		// Token: 0x040003CD RID: 973
		FragileChangeResponse = 21843,
		// Token: 0x040003CE RID: 974
		CheckPublicResourceVersionRequest = 17400,
		// Token: 0x040003CF RID: 975
		CheckPublicResourceVersionResponse = 21060,
		// Token: 0x040003D0 RID: 976
		JSPatchNotify = 19879,
		// Token: 0x040003D1 RID: 977
		QuestListNotify = 18320,
		// Token: 0x040003D2 RID: 978
		TraceQuestNotify = 25995,
		// Token: 0x040003D3 RID: 979
		TraceQuestRequest = 26774,
		// Token: 0x040003D4 RID: 980
		TraceQuestResponse = 15680,
		// Token: 0x040003D5 RID: 981
		QuestFinishActionRequest = 15063,
		// Token: 0x040003D6 RID: 982
		QuestFinishActionResponse = 17278,
		// Token: 0x040003D7 RID: 983
		QuestActionRequest = 18164,
		// Token: 0x040003D8 RID: 984
		QuestActionResponse = 15105,
		// Token: 0x040003D9 RID: 985
		QuestReadyListNotify = 29359,
		// Token: 0x040003DA RID: 986
		QuestShowListNotify = 24184,
		// Token: 0x040003DB RID: 987
		QuestNpcMoveOverRequest = 19428,
		// Token: 0x040003DC RID: 988
		QuestNpcMoveOverResponse = 21885,
		// Token: 0x040003DD RID: 989
		QuestStateUpdateNotify = 25205,
		// Token: 0x040003DE RID: 990
		QuestFinishActionEndRequest = 29054,
		// Token: 0x040003DF RID: 991
		QuestFinishActionEndResponse = 18310,
		// Token: 0x040003E0 RID: 992
		QuestFinishListNotify = 17785,
		// Token: 0x040003E1 RID: 993
		DailyQuestUnlockAreaNotify = 16310,
		// Token: 0x040003E2 RID: 994
		DailyQuestStateNotify = 26923,
		// Token: 0x040003E3 RID: 995
		DailyQuestChangePreferRequest = 23357,
		// Token: 0x040003E4 RID: 996
		DailyQuestChangePreferResponse = 15733,
		// Token: 0x040003E5 RID: 997
		DailyQuestGetRewardRequest = 15012,
		// Token: 0x040003E6 RID: 998
		DailyQuestGetRewardResponse = 21806,
		// Token: 0x040003E7 RID: 999
		DailyQuestCancelNotify = 29129,
		// Token: 0x040003E8 RID: 1000
		RoleQuestAcceptRequest = 18275,
		// Token: 0x040003E9 RID: 1001
		RoleQuestAcceptResponse = 18875,
		// Token: 0x040003EA RID: 1002
		RoleQuestStateNotify = 15015,
		// Token: 0x040003EB RID: 1003
		RoleQuestNewUnlockNotify = 16834,
		// Token: 0x040003EC RID: 1004
		RoleQuestPointStateRequest = 29691,
		// Token: 0x040003ED RID: 1005
		RoleQuestPointStateResponse = 24846,
		// Token: 0x040003EE RID: 1006
		DestroyQuestsNotify = 20252,
		// Token: 0x040003EF RID: 1007
		AutoQuestNotify = 20792,
		// Token: 0x040003F0 RID: 1008
		QuestRedDotRequest = 28280,
		// Token: 0x040003F1 RID: 1009
		QuestRedDotResponse = 29563,
		// Token: 0x040003F2 RID: 1010
		QuestRedDotNotify = 19285,
		// Token: 0x040003F3 RID: 1011
		ApplyRechallengeRequest = 24437,
		// Token: 0x040003F4 RID: 1012
		ApplyRechallengeResponse = 29801,
		// Token: 0x040003F5 RID: 1013
		ReceiveRechallengeNotify = 29770,
		// Token: 0x040003F6 RID: 1014
		ReceiveRechallengeRequest = 25942,
		// Token: 0x040003F7 RID: 1015
		ReceiveRechallengeResponse = 21241,
		// Token: 0x040003F8 RID: 1016
		InviteRechallengeRequest = 27109,
		// Token: 0x040003F9 RID: 1017
		InviteRechallengeResponse = 15563,
		// Token: 0x040003FA RID: 1018
		InviteRechallengeNotify = 28944,
		// Token: 0x040003FB RID: 1019
		ReceiveRechallengePlayerIdsNotify = 29063,
		// Token: 0x040003FC RID: 1020
		PlayerDeadNotify = 23671,
		// Token: 0x040003FD RID: 1021
		PlayerReviveNotify = 22493,
		// Token: 0x040003FE RID: 1022
		ReviveRequest = 15137,
		// Token: 0x040003FF RID: 1023
		ReviveResponse = 24465,
		// Token: 0x04000400 RID: 1024
		AddReviveRegionRequest = 21181,
		// Token: 0x04000401 RID: 1025
		AddReviveRegionResponse = 19029,
		// Token: 0x04000402 RID: 1026
		RemoveReviveRegionRequest = 15252,
		// Token: 0x04000403 RID: 1027
		RemoveReviveRegionResponse = 19862,
		// Token: 0x04000404 RID: 1028
		RoguelikeCurrencyNotify = 29861,
		// Token: 0x04000405 RID: 1029
		RoguelikeCurrencyUpdateNotify = 24300,
		// Token: 0x04000406 RID: 1030
		RoguelikeInfoNotify = 15467,
		// Token: 0x04000407 RID: 1031
		RoguelikeRefreshGainRequest = 20860,
		// Token: 0x04000408 RID: 1032
		RoguelikeRefreshGainResponse = 23711,
		// Token: 0x04000409 RID: 1033
		RoguelikeChooseDataRequest = 25554,
		// Token: 0x0400040A RID: 1034
		RoguelikeChooseDataResponse = 17486,
		// Token: 0x0400040B RID: 1035
		RoguelikeChooseDataNotify = 26262,
		// Token: 0x0400040C RID: 1036
		RoguelikeChooseDataResultRequest = 18731,
		// Token: 0x0400040D RID: 1037
		RoguelikeChooseDataResultResponse = 18902,
		// Token: 0x0400040E RID: 1038
		RoguelikeEventGainNotify = 17169,
		// Token: 0x0400040F RID: 1039
		RoguelikeLastInfoRequest = 17013,
		// Token: 0x04000410 RID: 1040
		RoguelikeLastInfoResponse = 24998,
		// Token: 0x04000411 RID: 1041
		RoguelikeStartRequest = 22052,
		// Token: 0x04000412 RID: 1042
		RoguelikeStartResponse = 22991,
		// Token: 0x04000413 RID: 1043
		RoguelikeQuitRequest = 18528,
		// Token: 0x04000414 RID: 1044
		RoguelikeQuitResponse = 18512,
		// Token: 0x04000415 RID: 1045
		RoguelikeResultNotify = 22995,
		// Token: 0x04000416 RID: 1046
		RoguelikeResultRequest = 20242,
		// Token: 0x04000417 RID: 1047
		RoguelikeResultResponse = 15568,
		// Token: 0x04000418 RID: 1048
		RoguelikeSubLevelNotify = 29131,
		// Token: 0x04000419 RID: 1049
		RoguelikeGotoNextRoomRequest = 20444,
		// Token: 0x0400041A RID: 1050
		RoguelikeGotoNextRoomResponse = 23489,
		// Token: 0x0400041B RID: 1051
		RoguelikeRoomInfoNotify = 18663,
		// Token: 0x0400041C RID: 1052
		RoguelikeTalentInfoRequest = 17548,
		// Token: 0x0400041D RID: 1053
		RoguelikeTalentInfoResponse = 29814,
		// Token: 0x0400041E RID: 1054
		RoguelikeTalentLevelUpRequest = 29178,
		// Token: 0x0400041F RID: 1055
		RoguelikeTalentLevelUpResponse = 24087,
		// Token: 0x04000420 RID: 1056
		RoguelikeTalentUnlockNotify = 17875,
		// Token: 0x04000421 RID: 1057
		RoguelikeSeasonDataRequest = 15218,
		// Token: 0x04000422 RID: 1058
		RoguelikeSeasonDataResponse = 18829,
		// Token: 0x04000423 RID: 1059
		RoguelikeTokenReceiveRequest = 18099,
		// Token: 0x04000424 RID: 1060
		RoguelikeTokenReceiveResponse = 15495,
		// Token: 0x04000425 RID: 1061
		RoguelikeSeasonRewardReceiveRequest = 20035,
		// Token: 0x04000426 RID: 1062
		RoguelikeSeasonRewardReceiveResponse = 18258,
		// Token: 0x04000427 RID: 1063
		RoguelikeGiveUpGainRequest = 29402,
		// Token: 0x04000428 RID: 1064
		RoguelikeGiveUpGainResponse = 21026,
		// Token: 0x04000429 RID: 1065
		PbGetRoleListRequest = 28529,
		// Token: 0x0400042A RID: 1066
		PbGetRoleListResponse = 28176,
		// Token: 0x0400042B RID: 1067
		PbGetRoleListNotify = 23798,
		// Token: 0x0400042C RID: 1068
		PbRoleActiveNotify = 16014,
		// Token: 0x0400042D RID: 1069
		PbUpLevelRoleRequest = 17360,
		// Token: 0x0400042E RID: 1070
		PbUpLevelRoleResponse = 24873,
		// Token: 0x0400042F RID: 1071
		PbOverRoleRequest = 17152,
		// Token: 0x04000430 RID: 1072
		PbOverRoleResponse = 25986,
		// Token: 0x04000431 RID: 1073
		PbUpLevelSkillRequest = 25868,
		// Token: 0x04000432 RID: 1074
		PbUpLevelSkillResponse = 26023,
		// Token: 0x04000433 RID: 1075
		PbRolePropsNotify = 17579,
		// Token: 0x04000434 RID: 1076
		PbRoleExpNotify = 26249,
		// Token: 0x04000435 RID: 1077
		PbRoleResonLockFinishNotify = 26928,
		// Token: 0x04000436 RID: 1078
		PbRoleScenePropsNotify = 18564,
		// Token: 0x04000437 RID: 1079
		PbRoleSkillLevelNotify = 16361,
		// Token: 0x04000438 RID: 1080
		RoleLevelUpViewRequest = 21169,
		// Token: 0x04000439 RID: 1081
		RoleLevelUpViewResponse = 17361,
		// Token: 0x0400043A RID: 1082
		RoleBreakThroughViewRequest = 22171,
		// Token: 0x0400043B RID: 1083
		RoleBreakThroughViewResponse = 29247,
		// Token: 0x0400043C RID: 1084
		RoleSkillLevelUpViewRequest = 28071,
		// Token: 0x0400043D RID: 1085
		RoleSkillLevelUpViewResponse = 23907,
		// Token: 0x0400043E RID: 1086
		RoleSkillViewRequest = 22013,
		// Token: 0x0400043F RID: 1087
		RoleSkillViewResponse = 17396,
		// Token: 0x04000440 RID: 1088
		RoleChangeNameNotify = 27785,
		// Token: 0x04000441 RID: 1089
		RoleTrialOpenNotify = 17675,
		// Token: 0x04000442 RID: 1090
		RoleTrialCloseNotify = 16731,
		// Token: 0x04000443 RID: 1091
		RoleActivateSkillRequest = 17616,
		// Token: 0x04000444 RID: 1092
		RoleActivateSkillResponse = 17055,
		// Token: 0x04000445 RID: 1093
		RoleSkillNodeNotify = 24848,
		// Token: 0x04000446 RID: 1094
		ResonantChainUnlockRequest = 17339,
		// Token: 0x04000447 RID: 1095
		ResonantChainUnlockResponse = 21735,
		// Token: 0x04000448 RID: 1096
		RoleSexChangeRequest = 17543,
		// Token: 0x04000449 RID: 1097
		RoleSexChangeResponse = 23208,
		// Token: 0x0400044A RID: 1098
		RoleElementChangeRequest = 29639,
		// Token: 0x0400044B RID: 1099
		RoleElementChangeResponse = 17531,
		// Token: 0x0400044C RID: 1100
		RoleChangeNotify = 18718,
		// Token: 0x0400044D RID: 1101
		RoleChangeUnlockNotify = 20322,
		// Token: 0x0400044E RID: 1102
		MaxMessageIdPush = 22976,
		// Token: 0x0400044F RID: 1103
		TrialRoleRewardRequest = 22659,
		// Token: 0x04000450 RID: 1104
		TrialRoleRewardResponse = 26824,
		// Token: 0x04000451 RID: 1105
		RoleTrialSettleNotify = 22045,
		// Token: 0x04000452 RID: 1106
		EntityLivingStatusNotify = 24917,
		// Token: 0x04000453 RID: 1107
		UpdatePlayerAllFightRoleNotify = 20791,
		// Token: 0x04000454 RID: 1108
		UpdatePlayersFightRolesInfoNotify = 16745,
		// Token: 0x04000455 RID: 1109
		UpdatePlayerSingleFightRoleNotify = 28925,
		// Token: 0x04000456 RID: 1110
		ChangePlayerFightRoleNotify = 25527,
		// Token: 0x04000457 RID: 1111
		SceneAreaStateNotify = 15646,
		// Token: 0x04000458 RID: 1112
		HostTeleportUnlockNotify = 25070,
		// Token: 0x04000459 RID: 1113
		HostFogIdUnlockNotify = 21721,
		// Token: 0x0400045A RID: 1114
		SyncSceneTimeNotify = 28973,
		// Token: 0x0400045B RID: 1115
		ChangeSceneModeNotify = 20701,
		// Token: 0x0400045C RID: 1116
		ScenePlayerOfflineNotify = 21816,
		// Token: 0x0400045D RID: 1117
		JoinSceneNotify = 20597,
		// Token: 0x0400045E RID: 1118
		OtherJoinSceneNotify = 22182,
		// Token: 0x0400045F RID: 1119
		LeaveSceneNotify = 21944,
		// Token: 0x04000460 RID: 1120
		MovePackagePush = 18855,
		// Token: 0x04000461 RID: 1121
		MovePackageNotify = 17980,
		// Token: 0x04000462 RID: 1122
		UDPMovePackagePush = 18826,
		// Token: 0x04000463 RID: 1123
		UDPMovePackageNotify = 21168,
		// Token: 0x04000464 RID: 1124
		EntitySimplyMoveInfoPackagePush = 23337,
		// Token: 0x04000465 RID: 1125
		MoveSceneItemPush = 20741,
		// Token: 0x04000466 RID: 1126
		MoveSceneItemNotify = 26459,
		// Token: 0x04000467 RID: 1127
		ChangeMonsterRoleNotify = 22631,
		// Token: 0x04000468 RID: 1128
		CaptureEntityRequest = 15300,
		// Token: 0x04000469 RID: 1129
		CaptureEntityResponse = 15289,
		// Token: 0x0400046A RID: 1130
		RemoveSummonEntityRequest = 17165,
		// Token: 0x0400046B RID: 1131
		RemoveSummonEntityResponse = 28927,
		// Token: 0x0400046C RID: 1132
		ChangeEntityRoleRequest = 24621,
		// Token: 0x0400046D RID: 1133
		ChangeEntityRoleResponse = 28494,
		// Token: 0x0400046E RID: 1134
		EntityOnLandedRequest = 21482,
		// Token: 0x0400046F RID: 1135
		EntityOnLandedResponse = 27404,
		// Token: 0x04000470 RID: 1136
		EntityOnLandedNotify = 29646,
		// Token: 0x04000471 RID: 1137
		AttributeInitRequest = 18143,
		// Token: 0x04000472 RID: 1138
		AttributeInitResponse = 18934,
		// Token: 0x04000473 RID: 1139
		AttributeInitNotify = 21138,
		// Token: 0x04000474 RID: 1140
		AttributeChangedRequest = 19018,
		// Token: 0x04000475 RID: 1141
		AttributeChangedResponse = 24670,
		// Token: 0x04000476 RID: 1142
		AttributeChangedNotify = 26859,
		// Token: 0x04000477 RID: 1143
		MonsterLevelNotify = 28638,
		// Token: 0x04000478 RID: 1144
		MonsterLevelArrayNotify = 19542,
		// Token: 0x04000479 RID: 1145
		MonsterAttributeNotify = 25923,
		// Token: 0x0400047A RID: 1146
		MonsterAttributeArrayNotify = 24398,
		// Token: 0x0400047B RID: 1147
		AnimationStateInitRequest = 29999,
		// Token: 0x0400047C RID: 1148
		AnimationStateInitResponse = 27644,
		// Token: 0x0400047D RID: 1149
		AnimationStateInitNotify = 23601,
		// Token: 0x0400047E RID: 1150
		AnimationStateChangedRequest = 17015,
		// Token: 0x0400047F RID: 1151
		AnimationStateChangedResponse = 23977,
		// Token: 0x04000480 RID: 1152
		AnimationStateChangedNotify = 24252,
		// Token: 0x04000481 RID: 1153
		GameplayTagInitNotify = 17191,
		// Token: 0x04000482 RID: 1154
		GameplayTagChangedNotify = 17995,
		// Token: 0x04000483 RID: 1155
		EntityCommonTagNotify = 20031,
		// Token: 0x04000484 RID: 1156
		ChangeControlRoleNotify = 29562,
		// Token: 0x04000485 RID: 1157
		HardnessModeChangedRequest = 19311,
		// Token: 0x04000486 RID: 1158
		HardnessModeChangedResponse = 25063,
		// Token: 0x04000487 RID: 1159
		HardnessModeChangedNotify = 22866,
		// Token: 0x04000488 RID: 1160
		SummonRequest = 26598,
		// Token: 0x04000489 RID: 1161
		SummonResponse = 15829,
		// Token: 0x0400048A RID: 1162
		Summon2Request = 24593,
		// Token: 0x0400048B RID: 1163
		Summon2Response = 20104,
		// Token: 0x0400048C RID: 1164
		SummonEntityNotify = 19653,
		// Token: 0x0400048D RID: 1165
		VisionSkillCallNotify = 23392,
		// Token: 0x0400048E RID: 1166
		InstanceTimerNotify = 15453,
		// Token: 0x0400048F RID: 1167
		UpdateInstanceTimerNotify = 17805,
		// Token: 0x04000490 RID: 1168
		RemoveInstanceTimerNotify = 27135,
		// Token: 0x04000491 RID: 1169
		RemoveInstanceTimerRequest = 24804,
		// Token: 0x04000492 RID: 1170
		RemoveInstanceTimerResponse = 22241,
		// Token: 0x04000493 RID: 1171
		UpdateInstanceOwnerInfoNotify = 29689,
		// Token: 0x04000494 RID: 1172
		UpdateOwnerMingSuGenNotify = 28808,
		// Token: 0x04000495 RID: 1173
		AddSysBuffNotify = 19225,
		// Token: 0x04000496 RID: 1174
		UpdateSysBuffNotify = 23927,
		// Token: 0x04000497 RID: 1175
		RemoveSysBuffNotify = 23366,
		// Token: 0x04000498 RID: 1176
		UpdateSceneDateRequest = 25350,
		// Token: 0x04000499 RID: 1177
		UpdateSceneDateResponse = 24289,
		// Token: 0x0400049A RID: 1178
		SceneDateNotify = 25540,
		// Token: 0x0400049B RID: 1179
		HoldWeaponPush = 24879,
		// Token: 0x0400049C RID: 1180
		DiscardWeaponPush = 20653,
		// Token: 0x0400049D RID: 1181
		DiscardWeaponRequest = 18527,
		// Token: 0x0400049E RID: 1182
		DiscardWeaponResponse = 20992,
		// Token: 0x0400049F RID: 1183
		HoldWeaponNotify = 15700,
		// Token: 0x040004A0 RID: 1184
		CreatStoryCharacterRequest = 29348,
		// Token: 0x040004A1 RID: 1185
		CreatStoryCharacterResponse = 24319,
		// Token: 0x040004A2 RID: 1186
		DeleteStoryCharacterRequest = 22583,
		// Token: 0x040004A3 RID: 1187
		DeleteStoryCharacterResponse = 16614,
		// Token: 0x040004A4 RID: 1188
		EnterAoiNotify = 20155,
		// Token: 0x040004A5 RID: 1189
		AddEntityAoiNotify = 21567,
		// Token: 0x040004A6 RID: 1190
		LeaveAoiNotify = 19141,
		// Token: 0x040004A7 RID: 1191
		RemoveEntityAoiNotify = 17978,
		// Token: 0x040004A8 RID: 1192
		PlayerAoiRangeNotify = 17622,
		// Token: 0x040004A9 RID: 1193
		SceneGamePlayInfoNotify = 21532,
		// Token: 0x040004AA RID: 1194
		SceneGamePlayFirstNotify = 21553,
		// Token: 0x040004AB RID: 1195
		SceneGamePlayStatusNotify = 24317,
		// Token: 0x040004AC RID: 1196
		SceneGamePlayScopeNotify = 18816,
		// Token: 0x040004AD RID: 1197
		SceneGamePlayOpenTimeNotify = 17378,
		// Token: 0x040004AE RID: 1198
		CreatureDetailRequest = 21574,
		// Token: 0x040004AF RID: 1199
		CreatureDetailResponse = 16069,
		// Token: 0x040004B0 RID: 1200
		ResetLocationForZRangeNotify = 21097,
		// Token: 0x040004B1 RID: 1201
		ChangeEntityStateRequest = 18733,
		// Token: 0x040004B2 RID: 1202
		ChangeEntityStateResponse = 21818,
		// Token: 0x040004B3 RID: 1203
		FoundationRequest = 23886,
		// Token: 0x040004B4 RID: 1204
		FoundationResponse = 26544,
		// Token: 0x040004B5 RID: 1205
		BeControlledPosInFoundationNotify = 23363,
		// Token: 0x040004B6 RID: 1206
		BeControlledRequest = 16785,
		// Token: 0x040004B7 RID: 1207
		BeControlledResponse = 24551,
		// Token: 0x040004B8 RID: 1208
		BeControlledNotify = 17537,
		// Token: 0x040004B9 RID: 1209
		BeControlledShowRequest = 20029,
		// Token: 0x040004BA RID: 1210
		BeControlledShowResponse = 26477,
		// Token: 0x040004BB RID: 1211
		BeControlledShowNotify = 23631,
		// Token: 0x040004BC RID: 1212
		BeControlledThrowRequest = 25094,
		// Token: 0x040004BD RID: 1213
		BeControlledThrowResponse = 16431,
		// Token: 0x040004BE RID: 1214
		RelationIdNotify = 26419,
		// Token: 0x040004BF RID: 1215
		EntityPosResetNotify = 19731,
		// Token: 0x040004C0 RID: 1216
		GravityGearRequest = 28261,
		// Token: 0x040004C1 RID: 1217
		GravityGearResponse = 27144,
		// Token: 0x040004C2 RID: 1218
		WeatherNotify = 21865,
		// Token: 0x040004C3 RID: 1219
		ChangeWeatherRequest = 29890,
		// Token: 0x040004C4 RID: 1220
		ChangeWeatherResponse = 19397,
		// Token: 0x040004C5 RID: 1221
		FollowTrackRequest = 25969,
		// Token: 0x040004C6 RID: 1222
		FollowTrackResponse = 21101,
		// Token: 0x040004C7 RID: 1223
		SetInitTagRequest = 19030,
		// Token: 0x040004C8 RID: 1224
		SetInitTagResponse = 17305,
		// Token: 0x040004C9 RID: 1225
		PlayerRebackSceneNotify = 26270,
		// Token: 0x040004CA RID: 1226
		DrownRequest = 25778,
		// Token: 0x040004CB RID: 1227
		DrownResponse = 21329,
		// Token: 0x040004CC RID: 1228
		DrownNotify = 16564,
		// Token: 0x040004CD RID: 1229
		DrownEndTeleportRequest = 21245,
		// Token: 0x040004CE RID: 1230
		DrownEndTeleportResponse = 20620,
		// Token: 0x040004CF RID: 1231
		MonsterDrownRequest = 20753,
		// Token: 0x040004D0 RID: 1232
		MonsterDrownResponse = 22186,
		// Token: 0x040004D1 RID: 1233
		EnableNearbyTrackingNotify = 26906,
		// Token: 0x040004D2 RID: 1234
		SceneSubLevelsChangedNotify = 22107,
		// Token: 0x040004D3 RID: 1235
		SceneSubLevelsNotify = 21860,
		// Token: 0x040004D4 RID: 1236
		SceneLoadingFinishRequest = 27192,
		// Token: 0x040004D5 RID: 1237
		SceneLoadingFinishResponse = 28792,
		// Token: 0x040004D6 RID: 1238
		SceneLoadingTimeOutNotify = 15159,
		// Token: 0x040004D7 RID: 1239
		SceneLoadingFinishNotify = 28319,
		// Token: 0x040004D8 RID: 1240
		ResetPointEntityNotify = 29014,
		// Token: 0x040004D9 RID: 1241
		SitChairRequest = 25917,
		// Token: 0x040004DA RID: 1242
		SitChairResponse = 15985,
		// Token: 0x040004DB RID: 1243
		BeControlledDestroyRequest = 26102,
		// Token: 0x040004DC RID: 1244
		BeControlledDestroyResponse = 21659,
		// Token: 0x040004DD RID: 1245
		SceneTestNotify = 25522,
		// Token: 0x040004DE RID: 1246
		SceneChangeDataLayerNotify = 15688,
		// Token: 0x040004DF RID: 1247
		ChangeDataLayerFinishRequest = 16648,
		// Token: 0x040004E0 RID: 1248
		ChangeDataLayerFinishResponse = 20475,
		// Token: 0x040004E1 RID: 1249
		MoveSceneItemResetPositionRequest = 27648,
		// Token: 0x040004E2 RID: 1250
		MoveSceneItemResetPositionResponse = 20105,
		// Token: 0x040004E3 RID: 1251
		HookLockPointRequest = 16301,
		// Token: 0x040004E4 RID: 1252
		HookLockPointResponse = 24512,
		// Token: 0x040004E5 RID: 1253
		CheckGearRequest = 27460,
		// Token: 0x040004E6 RID: 1254
		CheckGearResponse = 26915,
		// Token: 0x040004E7 RID: 1255
		SceneItemStateRequest = 23046,
		// Token: 0x040004E8 RID: 1256
		SceneItemStateResponse = 17526,
		// Token: 0x040004E9 RID: 1257
		EntityLoadCompleteNotify = 21435,
		// Token: 0x040004EA RID: 1258
		MaterialRequest = 17530,
		// Token: 0x040004EB RID: 1259
		MaterialResponse = 26538,
		// Token: 0x040004EC RID: 1260
		MaterialNotify = 26008,
		// Token: 0x040004ED RID: 1261
		CommonOrganResetTimeRequest = 22989,
		// Token: 0x040004EE RID: 1262
		CommonOrganResetTimeResponse = 18085,
		// Token: 0x040004EF RID: 1263
		SceneStepGroupInfoNotify = 17210,
		// Token: 0x040004F0 RID: 1264
		SceneStepInfoNotify = 16336,
		// Token: 0x040004F1 RID: 1265
		TargetGearHitRequest = 20478,
		// Token: 0x040004F2 RID: 1266
		TargetGearHitResponse = 15616,
		// Token: 0x040004F3 RID: 1267
		ThrowDamageRequest = 25936,
		// Token: 0x040004F4 RID: 1268
		ThrowDamageResponse = 26400,
		// Token: 0x040004F5 RID: 1269
		ThrowDamageNotify = 18961,
		// Token: 0x040004F6 RID: 1270
		ThrowDamageRecoveryNotify = 29960,
		// Token: 0x040004F7 RID: 1271
		GetRewardTreasureBoxRequest = 20848,
		// Token: 0x040004F8 RID: 1272
		GetRewardTreasureBoxResponse = 23102,
		// Token: 0x040004F9 RID: 1273
		SettingNotify = 17038,
		// Token: 0x040004FA RID: 1274
		MobileButtonSettingUpdateRequest = 25947,
		// Token: 0x040004FB RID: 1275
		MobileButtonSettingUpdateResponse = 22058,
		// Token: 0x040004FC RID: 1276
		LanguageSettingUpdateRequest = 22740,
		// Token: 0x040004FD RID: 1277
		LanguageSettingUpdateResponse = 23816,
		// Token: 0x040004FE RID: 1278
		ShopInfoRequest = 29540,
		// Token: 0x040004FF RID: 1279
		ShopInfoResponse = 28926,
		// Token: 0x04000500 RID: 1280
		ShopInfoNotify = 18614,
		// Token: 0x04000501 RID: 1281
		ShopBuyRequest = 28078,
		// Token: 0x04000502 RID: 1282
		ShopBuyResponse = 27294,
		// Token: 0x04000503 RID: 1283
		ShopUpdateRequest = 17187,
		// Token: 0x04000504 RID: 1284
		ShopUpdateResponse = 27292,
		// Token: 0x04000505 RID: 1285
		ShopUnlockNotify = 23429,
		// Token: 0x04000506 RID: 1286
		SneakGameStateNotify = 25864,
		// Token: 0x04000507 RID: 1287
		SneakFinishRequest = 20851,
		// Token: 0x04000508 RID: 1288
		SneakFinishResponse = 25091,
		// Token: 0x04000509 RID: 1289
		SpecialItemNotify = 20874,
		// Token: 0x0400050A RID: 1290
		SpecialItemEquipRequest = 17718,
		// Token: 0x0400050B RID: 1291
		SpecialItemEquipResponse = 17256,
		// Token: 0x0400050C RID: 1292
		SpecialItemUnEquipRequest = 19843,
		// Token: 0x0400050D RID: 1293
		SpecialItemUnEquipResponse = 24255,
		// Token: 0x0400050E RID: 1294
		SynthesisInfoRequest = 25534,
		// Token: 0x0400050F RID: 1295
		SynthesisInfoResponse = 19842,
		// Token: 0x04000510 RID: 1296
		SynthesisItemRequest = 24085,
		// Token: 0x04000511 RID: 1297
		SynthesisItemResponse = 24774,
		// Token: 0x04000512 RID: 1298
		SynthesisInfoUpdateNotify = 26909,
		// Token: 0x04000513 RID: 1299
		SynthesisLevelRewardRequest = 15075,
		// Token: 0x04000514 RID: 1300
		SynthesisLevelRewardResponse = 21274,
		// Token: 0x04000515 RID: 1301
		SynthesisLevelUpdateNotify = 18205,
		// Token: 0x04000516 RID: 1302
		SynthesisFormulaUnlockRequest = 23511,
		// Token: 0x04000517 RID: 1303
		SynthesisFormulaUnlockResponse = 23763,
		// Token: 0x04000518 RID: 1304
		TeleportUpdateNotify = 25294,
		// Token: 0x04000519 RID: 1305
		TeleportDataRequest = 18464,
		// Token: 0x0400051A RID: 1306
		TeleportDataResponse = 24608,
		// Token: 0x0400051B RID: 1307
		TeleportTransferRequest = 24606,
		// Token: 0x0400051C RID: 1308
		TeleportTransferResponse = 29947,
		// Token: 0x0400051D RID: 1309
		TeleportNotify = 25575,
		// Token: 0x0400051E RID: 1310
		TeleportFinishRequest = 28614,
		// Token: 0x0400051F RID: 1311
		TeleportFinishResponse = 24577,
		// Token: 0x04000520 RID: 1312
		FallFinishNotify = 22427,
		// Token: 0x04000521 RID: 1313
		UnOpenedAreaPullbackRequest = 17532,
		// Token: 0x04000522 RID: 1314
		UnOpenedAreaPullbackResponse = 23277,
		// Token: 0x04000523 RID: 1315
		TemporaryTeleportAllInfoNotify = 27094,
		// Token: 0x04000524 RID: 1316
		AddTemporaryTeleportInfoNotify = 22362,
		// Token: 0x04000525 RID: 1317
		RemoveTemporaryTeleportNotify = 21656,
		// Token: 0x04000526 RID: 1318
		TemporaryTeleportChangeNotify = 28744,
		// Token: 0x04000527 RID: 1319
		RemoveTemporaryTeleportRequest = 22106,
		// Token: 0x04000528 RID: 1320
		RemoveTemporaryTeleportResponse = 28735,
		// Token: 0x04000529 RID: 1321
		TeleportToTargetRequest = 28616,
		// Token: 0x0400052A RID: 1322
		TeleportToTargetResponse = 17547,
		// Token: 0x0400052B RID: 1323
		ThirdPartySharedNotify = 17110,
		// Token: 0x0400052C RID: 1324
		ThirdPartyShareRequest = 17006,
		// Token: 0x0400052D RID: 1325
		ThirdPartyShareResponse = 20634,
		// Token: 0x0400052E RID: 1326
		TimeStopPush = 16707,
		// Token: 0x0400052F RID: 1327
		RTimeStopRequest = 16580,
		// Token: 0x04000530 RID: 1328
		RTimeStopResponse = 24814,
		// Token: 0x04000531 RID: 1329
		RTimeStopInstRequest = 18157,
		// Token: 0x04000532 RID: 1330
		RTimeStopInstResponse = 15227,
		// Token: 0x04000533 RID: 1331
		TimelineTraceStartRequest = 29145,
		// Token: 0x04000534 RID: 1332
		TimelineTraceStartResponse = 21855,
		// Token: 0x04000535 RID: 1333
		TimelineTraceControlRequest = 26029,
		// Token: 0x04000536 RID: 1334
		TimelineTraceControlResponse = 23257,
		// Token: 0x04000537 RID: 1335
		TimelineTraceExitRequest = 28107,
		// Token: 0x04000538 RID: 1336
		TimelineTraceExitResponse = 16487,
		// Token: 0x04000539 RID: 1337
		TimeCheckRequest = 28799,
		// Token: 0x0400053A RID: 1338
		TimeCheckNotify = 18938,
		// Token: 0x0400053B RID: 1339
		TimeCheckResponse = 28031,
		// Token: 0x0400053C RID: 1340
		TowerRequest = 26406,
		// Token: 0x0400053D RID: 1341
		TowerResponse = 21047,
		// Token: 0x0400053E RID: 1342
		TowerSeasonUpdateRequest = 24072,
		// Token: 0x0400053F RID: 1343
		TowerSeasonUpdateResponse = 21534,
		// Token: 0x04000540 RID: 1344
		TowerFormationRecommendRequest = 16303,
		// Token: 0x04000541 RID: 1345
		TowerFormationRecommendResponse = 26594,
		// Token: 0x04000542 RID: 1346
		TowerRewardRequest = 27282,
		// Token: 0x04000543 RID: 1347
		TowerRewardResponse = 16113,
		// Token: 0x04000544 RID: 1348
		TowerStartRequest = 19933,
		// Token: 0x04000545 RID: 1349
		TowerStartResponse = 27533,
		// Token: 0x04000546 RID: 1350
		TowerResetRequest = 27650,
		// Token: 0x04000547 RID: 1351
		TowerResetResponse = 26793,
		// Token: 0x04000548 RID: 1352
		TowerApplyFloorDataRequest = 21733,
		// Token: 0x04000549 RID: 1353
		TowerApplyFloorDataResponse = 18513,
		// Token: 0x0400054A RID: 1354
		TowerEndNotify = 28183,
		// Token: 0x0400054B RID: 1355
		TowerFloorUpdateNotify = 17128,
		// Token: 0x0400054C RID: 1356
		TowerDifficultyUpdateNotify = 24752,
		// Token: 0x0400054D RID: 1357
		TowerInfoUpdateNotify = 27219,
		// Token: 0x0400054E RID: 1358
		TowerGuideActivityRewardRequest = 16778,
		// Token: 0x0400054F RID: 1359
		TowerGuideActivityRewardResponse = 22907,
		// Token: 0x04000550 RID: 1360
		TowerGuideActivityInfoRequest = 19610,
		// Token: 0x04000551 RID: 1361
		TowerGuideActivityInfoResponse = 23078,
		// Token: 0x04000552 RID: 1362
		TurntableCompleteRequest = 20102,
		// Token: 0x04000553 RID: 1363
		TurntableCompleteResponse = 18435,
		// Token: 0x04000554 RID: 1364
		TutorialInfoRequest = 15006,
		// Token: 0x04000555 RID: 1365
		TutorialInfoResponse = 22904,
		// Token: 0x04000556 RID: 1366
		TutorialUnlockNotify = 25322,
		// Token: 0x04000557 RID: 1367
		TutorialReceiveRequest = 27270,
		// Token: 0x04000558 RID: 1368
		TutorialReceiveResponse = 18170,
		// Token: 0x04000559 RID: 1369
		TutorialUnlockRequest = 21852,
		// Token: 0x0400055A RID: 1370
		TutorialUnlockResponse = 26280,
		// Token: 0x0400055B RID: 1371
		VisionSkillChangeNotify = 25196,
		// Token: 0x0400055C RID: 1372
		WeaponLevelUpRequest = 19242,
		// Token: 0x0400055D RID: 1373
		WeaponLevelUpResponse = 17061,
		// Token: 0x0400055E RID: 1374
		WeaponBreachRequest = 16833,
		// Token: 0x0400055F RID: 1375
		WeaponBreachResponse = 26514,
		// Token: 0x04000560 RID: 1376
		WeaponResonUpRequest = 17476,
		// Token: 0x04000561 RID: 1377
		WeaponResonUpResponse = 21310,
		// Token: 0x04000562 RID: 1378
		WeaponAllInfoNotify = 16632,
		// Token: 0x04000563 RID: 1379
		WeaponAddNotify = 20872,
		// Token: 0x04000564 RID: 1380
		WeaponRemoveNotify = 15552,
		// Token: 0x04000565 RID: 1381
		WorldLevelDownRequest = 17014,
		// Token: 0x04000566 RID: 1382
		WorldLevelDownResponse = 28190,
		// Token: 0x04000567 RID: 1383
		WorldLevelRegainRequest = 26635,
		// Token: 0x04000568 RID: 1384
		WorldLevelRegainResponse = 23479,
		// Token: 0x04000569 RID: 1385
		WorldEnterPermissionsRequest = 20021,
		// Token: 0x0400056A RID: 1386
		WorldEnterPermissionsResponse = 24472,
		// Token: 0x0400056B RID: 1387
		ApplyJoinWorldRequest = 17687,
		// Token: 0x0400056C RID: 1388
		ApplyJoinWorldResponse = 15396,
		// Token: 0x0400056D RID: 1389
		ApplyJoinWorldNotify = 27800,
		// Token: 0x0400056E RID: 1390
		AgreeJoinResultRequest = 16876,
		// Token: 0x0400056F RID: 1391
		AgreeJoinResultResponse = 24721,
		// Token: 0x04000570 RID: 1392
		AgreeJoinResultNotify = 21974,
		// Token: 0x04000571 RID: 1393
		ApplyerEnterSceneNotify = 24262,
		// Token: 0x04000572 RID: 1394
		AllApplyJoinNotify = 16708,
		// Token: 0x04000573 RID: 1395
		LobbyListRequest = 28398,
		// Token: 0x04000574 RID: 1396
		LobbyListResponse = 18705,
		// Token: 0x04000575 RID: 1397
		LobbyQueryPlayersRequest = 27890,
		// Token: 0x04000576 RID: 1398
		LobbyQueryPlayersResponse = 25999,
		// Token: 0x04000577 RID: 1399
		WorldTeamPlayerInfoChangeNotify = 27539,
		// Token: 0x04000578 RID: 1400
		JoinWorldTeamNotify = 17115,
		// Token: 0x04000579 RID: 1401
		PlayerLeaveWorldTeamNotify = 21585,
		// Token: 0x0400057A RID: 1402
		PlayerEnterWorldTeamNotify = 21617,
		// Token: 0x0400057B RID: 1403
		LeaveWorldTeamRequest = 16004,
		// Token: 0x0400057C RID: 1404
		LeaveWorldTeamResponse = 16579,
		// Token: 0x0400057D RID: 1405
		KickWorldTeamRequest = 27061,
		// Token: 0x0400057E RID: 1406
		KickWorldTeamResponse = 26682,
		// Token: 0x0400057F RID: 1407
		RobotDestinationPush = 24844,
		// Token: 0x04000580 RID: 1408
		RobotDestinationNotify = 21753,
		// Token: 0x04000581 RID: 1409
		UpdateWorldTeamPlayerFightInfoNotify = 20243,
		// Token: 0x04000582 RID: 1410
		PlayerNetStatePush = 24558,
		// Token: 0x04000583 RID: 1411
		PlayerNetStateNotify = 25067,
		// Token: 0x04000584 RID: 1412
		PlayerTeleportStateNotify = 27864,
		// Token: 0x04000585 RID: 1413
		SignatureUpdateNotify = 28884,
		// Token: 0x04000586 RID: 1414
		EntityBeamReceiveRequest = 22992,
		// Token: 0x04000587 RID: 1415
		EntityBeamReceiveResponse = 27467,
		// Token: 0x04000588 RID: 1416
		AttachEntityRequest = 25142,
		// Token: 0x04000589 RID: 1417
		AttachEntityResponse = 18874,
		// Token: 0x0400058A RID: 1418
		EntityAttachChangeNotify = 26817,
		// Token: 0x0400058B RID: 1419
		EntityPatrolAddTagRequest = 22474,
		// Token: 0x0400058C RID: 1420
		EntityPatrolAddTagResponse = 21942,
		// Token: 0x0400058D RID: 1421
		BattleScoreNotify = 25993,
		// Token: 0x0400058E RID: 1422
		LongShanStageUpdateNotify = 22723,
		// Token: 0x0400058F RID: 1423
		LongShanTaskRewardRequest = 26202,
		// Token: 0x04000590 RID: 1424
		LongShanTaskRewardResponse = 25642,
		// Token: 0x04000591 RID: 1425
		MultiMapInfoNotify = 20261,
		// Token: 0x04000592 RID: 1426
		UnlockMapBlockNotify = 15704,
		// Token: 0x04000593 RID: 1427
		UnlockMultiMapNotify = 29531,
		// Token: 0x04000594 RID: 1428
		EntityAccessRangeRequest = 22475,
		// Token: 0x04000595 RID: 1429
		EntityAccessRangeResponse = 15094,
		// Token: 0x04000596 RID: 1430
		PlayerAccessRangeRequest = 20505,
		// Token: 0x04000597 RID: 1431
		PlayerAccessRangeResponse = 29671,
		// Token: 0x04000598 RID: 1432
		EntityAccessRangeNotify = 23916,
		// Token: 0x04000599 RID: 1433
		PlayerAccessRangeNotify = 24586,
		// Token: 0x0400059A RID: 1434
		TrampleGearTransitionNotify = 28029,
		// Token: 0x0400059B RID: 1435
		RoguelikePopularEntriesInfoRequest = 26192,
		// Token: 0x0400059C RID: 1436
		RoguelikePopularEntriesInfoResponse = 29994,
		// Token: 0x0400059D RID: 1437
		RoguelikePopularEntriesChangeRequest = 24745,
		// Token: 0x0400059E RID: 1438
		RoguelikePopularEntriesChangeResponse = 20560,
		// Token: 0x0400059F RID: 1439
		PlayerSkillInfoPbNotify = 29311,
		// Token: 0x040005A0 RID: 1440
		SwitchSceneGroupNotify = 21909,
		// Token: 0x040005A1 RID: 1441
		UpdateSceneGroupDataNotify = 22332,
		// Token: 0x040005A2 RID: 1442
		AfterJoinSceneNotify = 28489,
		// Token: 0x040005A3 RID: 1443
		HookLockPointFinishRequest = 15520,
		// Token: 0x040005A4 RID: 1444
		HookLockPointFinishResponse = 27227,
		// Token: 0x040005A5 RID: 1445
		BuildingLevelUpRequest = 22480,
		// Token: 0x040005A6 RID: 1446
		BuildingLevelUpResponse = 26925,
		// Token: 0x040005A7 RID: 1447
		RoleTrainRequest = 15533,
		// Token: 0x040005A8 RID: 1448
		RoleTrainResponse = 22364,
		// Token: 0x040005A9 RID: 1449
		AcceptEntrustRequest = 29331,
		// Token: 0x040005AA RID: 1450
		AcceptEntrustResponse = 21620,
		// Token: 0x040005AB RID: 1451
		InvestRequest = 16522,
		// Token: 0x040005AC RID: 1452
		InvestResponse = 17799,
		// Token: 0x040005AD RID: 1453
		TrackMoonEntrustDataRequest = 28535,
		// Token: 0x040005AE RID: 1454
		TrackMoonEntrustDataResponse = 19470,
		// Token: 0x040005AF RID: 1455
		TrackMoonRoleDataRequest = 20217,
		// Token: 0x040005B0 RID: 1456
		TrackMoonRoleDataResponse = 20611,
		// Token: 0x040005B1 RID: 1457
		RunTurntableActivityRequest = 15007,
		// Token: 0x040005B2 RID: 1458
		RunTurntableActivityResponse = 15518,
		// Token: 0x040005B3 RID: 1459
		TrackMoonBuildingDataRequest = 26292,
		// Token: 0x040005B4 RID: 1460
		TrackMoonBuildingDataResponse = 15600,
		// Token: 0x040005B5 RID: 1461
		BuildingUnLockRequest = 26985,
		// Token: 0x040005B6 RID: 1462
		BuildingUnLockResponse = 28422,
		// Token: 0x040005B7 RID: 1463
		AudioStateUpdateNotify = 17667,
		// Token: 0x040005B8 RID: 1464
		BossRushClaimRewardRequest = 17500,
		// Token: 0x040005B9 RID: 1465
		BossRushClaimRewardResponse = 23469,
		// Token: 0x040005BA RID: 1466
		BossRushSettlementRequest = 19575,
		// Token: 0x040005BB RID: 1467
		BossRushSettlementResponse = 25837,
		// Token: 0x040005BC RID: 1468
		BossRushResultNotify = 16040,
		// Token: 0x040005BD RID: 1469
		BossRushLevelInfoNotify = 28132,
		// Token: 0x040005BE RID: 1470
		TrackMoonConditionNotify = 23338,
		// Token: 0x040005BF RID: 1471
		EntityVarUpdateNotify = 28972,
		// Token: 0x040005C0 RID: 1472
		SceneModeChangeFinishRequest = 16826,
		// Token: 0x040005C1 RID: 1473
		SceneModeChangeFinishResponse = 20026,
		// Token: 0x040005C2 RID: 1474
		RoguelikeGainDataUpdateNotify = 22913,
		// Token: 0x040005C3 RID: 1475
		OutputDebugInfoNotify = 26742,
		// Token: 0x040005C4 RID: 1476
		RoguelikeTrialRoleInfoRequest = 19261,
		// Token: 0x040005C5 RID: 1477
		RoguelikeTrialRoleInfoResponse = 15508,
		// Token: 0x040005C6 RID: 1478
		PhotoMemoryRequest = 25225,
		// Token: 0x040005C7 RID: 1479
		PhotoMemoryResponse = 22761,
		// Token: 0x040005C8 RID: 1480
		PhotoMemoryUpdateNotify = 20573,
		// Token: 0x040005C9 RID: 1481
		PhotoMemoryCollectNotify = 21614,
		// Token: 0x040005CA RID: 1482
		PhotoMemoryRewardRequest = 27468,
		// Token: 0x040005CB RID: 1483
		PhotoMemoryRewardResponse = 15832,
		// Token: 0x040005CC RID: 1484
		ChangeSceneModeEndNotify = 17107,
		// Token: 0x040005CD RID: 1485
		SceneItemSetPosSenderRequest = 26876,
		// Token: 0x040005CE RID: 1486
		SceneItemSetPosSenderResponse = 19612,
		// Token: 0x040005CF RID: 1487
		SceneItemSetPosSenderNotify = 15429,
		// Token: 0x040005D0 RID: 1488
		TraceEntityPosRequest = 21153,
		// Token: 0x040005D1 RID: 1489
		TraceEntityPosResponse = 16641,
		// Token: 0x040005D2 RID: 1490
		CombatMessagePrefixInfoRequest = 28795,
		// Token: 0x040005D3 RID: 1491
		CombatMessagePrefixInfoResponse = 16765,
		// Token: 0x040005D4 RID: 1492
		CombatMessagePostInfoRequest = 17769,
		// Token: 0x040005D5 RID: 1493
		CombatMessagePostInfoResponse = 29434,
		// Token: 0x040005D6 RID: 1494
		TrackMoonTargetRewardRequest = 19837,
		// Token: 0x040005D7 RID: 1495
		TrackMoonTargetRewardResponse = 17100,
		// Token: 0x040005D8 RID: 1496
		TrackMoonTargetUpdateNotify = 20094,
		// Token: 0x040005D9 RID: 1497
		FsmStateBehaviorRequest = 23005,
		// Token: 0x040005DA RID: 1498
		FsmStateBehaviorResponse = 21048,
		// Token: 0x040005DB RID: 1499
		FsmPlayMontageRequest = 25815,
		// Token: 0x040005DC RID: 1500
		FsmPlayMontageResponse = 25141,
		// Token: 0x040005DD RID: 1501
		RTimeStopAnimRequest = 28674,
		// Token: 0x040005DE RID: 1502
		RTimeStopAnimResponse = 29834,
		// Token: 0x040005DF RID: 1503
		RolePropRequest = 29283,
		// Token: 0x040005E0 RID: 1504
		RolePropResponse = 16928,
		// Token: 0x040005E1 RID: 1505
		PlayerLivingStatesNotify = 26412,
		// Token: 0x040005E2 RID: 1506
		TrackMoonSettleRequest = 15206,
		// Token: 0x040005E3 RID: 1507
		TrackMoonSettleResponse = 27600,
		// Token: 0x040005E4 RID: 1508
		TrackMoonIllustratedRequest = 21304,
		// Token: 0x040005E5 RID: 1509
		TrackMoonIllustratedResponse = 24278,
		// Token: 0x040005E6 RID: 1510
		TrackMoonIllustratedNotify = 28408,
		// Token: 0x040005E7 RID: 1511
		BossRushFailResultNotify = 19850,
		// Token: 0x040005E8 RID: 1512
		TowerDefenceInfoUpdateNotify = 20433,
		// Token: 0x040005E9 RID: 1513
		TowerDefenceInstanceInfoUpdateNotify = 18881,
		// Token: 0x040005EA RID: 1514
		TowerDefencePhantomInfoUpdateNotify = 19510,
		// Token: 0x040005EB RID: 1515
		TowerDefenceInstanceRewardRequest = 23941,
		// Token: 0x040005EC RID: 1516
		TowerDefenceInstanceRewardResponse = 20681,
		// Token: 0x040005ED RID: 1517
		TowerDefenceScoreRewardRequest = 18725,
		// Token: 0x040005EE RID: 1518
		TowerDefenceScoreRewardResponse = 15411,
		// Token: 0x040005EF RID: 1519
		TowerDefenceEndNotify = 21135,
		// Token: 0x040005F0 RID: 1520
		FlowTeleportToPlotPosRequest = 20939,
		// Token: 0x040005F1 RID: 1521
		FlowTeleportToPlotPosResponse = 28245,
		// Token: 0x040005F2 RID: 1522
		ConnectorConnectEntityRequest = 29745,
		// Token: 0x040005F3 RID: 1523
		ConnectorConnectEntityResponse = 15177,
		// Token: 0x040005F4 RID: 1524
		ConnectorConnectEntityNotify = 29082,
		// Token: 0x040005F5 RID: 1525
		BeControlledEntityHoverRequest = 15955,
		// Token: 0x040005F6 RID: 1526
		BeControlledEntityHoverResponse = 27351,
		// Token: 0x040005F7 RID: 1527
		InitRangeRequest = 16207,
		// Token: 0x040005F8 RID: 1528
		InitRangeResponse = 18075,
		// Token: 0x040005F9 RID: 1529
		TrackMoonActivityRewardRequest = 28834,
		// Token: 0x040005FA RID: 1530
		TrackMoonActivityRewardResponse = 24303,
		// Token: 0x040005FB RID: 1531
		TimePointActivityRewardRequest = 25635,
		// Token: 0x040005FC RID: 1532
		TimePointActivityRewardResponse = 18317,
		// Token: 0x040005FD RID: 1533
		NameModifyNotify = 26559,
		// Token: 0x040005FE RID: 1534
		FirecrackerEntityCreatedNotify = 27748,
		// Token: 0x040005FF RID: 1535
		CircumFluenceTaskRewardRequest = 25593,
		// Token: 0x04000600 RID: 1536
		CircumFluenceTaskRewardResponse = 21293,
		// Token: 0x04000601 RID: 1537
		PlayerFollowerNotify = 27250,
		// Token: 0x04000602 RID: 1538
		GameplayCueRequest = 20852,
		// Token: 0x04000603 RID: 1539
		GameplayCueResponse = 15031,
		// Token: 0x04000604 RID: 1540
		GameplayCueNotify = 21307,
		// Token: 0x04000605 RID: 1541
		SceneItemStopRequest = 29926,
		// Token: 0x04000606 RID: 1542
		SceneItemStopResponse = 20130,
		// Token: 0x04000607 RID: 1543
		TowerDefenceEnterInstNotify = 29765,
		// Token: 0x04000608 RID: 1544
		ServerCommandNotify = 27430,
		// Token: 0x04000609 RID: 1545
		RoguelikeRoleRoomNotify = 26103,
		// Token: 0x0400060A RID: 1546
		RoguelikeRoleRoomSelectRequest = 18165,
		// Token: 0x0400060B RID: 1547
		RoguelikeRoleRoomSelectResponse = 15944,
		// Token: 0x0400060C RID: 1548
		SetNpcPerformStateNotify = 16291,
		// Token: 0x0400060D RID: 1549
		BattleAntiCheatingLogNotify = 27447,
		// Token: 0x0400060E RID: 1550
		SecFBRoundStartFlowRequest = 23993,
		// Token: 0x0400060F RID: 1551
		SecFBRoundStartFlowResponse = 26201,
		// Token: 0x04000610 RID: 1552
		SecGetReportData2FlowRequest = 23542,
		// Token: 0x04000611 RID: 1553
		SecGetReportData2FlowResponse = 20463,
		// Token: 0x04000612 RID: 1554
		SecFBRoundEndFlowReportRequest = 17956,
		// Token: 0x04000613 RID: 1555
		SecFBRoundEndFlowReportResponse = 16776,
		// Token: 0x04000614 RID: 1556
		SecRoleFightFlowRequest = 21319,
		// Token: 0x04000615 RID: 1557
		SecRoleFightFlowResponse = 29975,
		// Token: 0x04000616 RID: 1558
		SecWorldInfoFlowRequest = 24782,
		// Token: 0x04000617 RID: 1559
		SecWorldInfoFlowResponse = 21356,
		// Token: 0x04000618 RID: 1560
		SecWorldStartFlowRequest = 27803,
		// Token: 0x04000619 RID: 1561
		SecWorldStartFlowResponse = 17814,
		// Token: 0x0400061A RID: 1562
		SecWorldSEndFlowRequest = 16078,
		// Token: 0x0400061B RID: 1563
		AwakeDynamicPortalRequest = 24473,
		// Token: 0x0400061C RID: 1564
		AwakeDynamicPortalResponse = 17133,
		// Token: 0x0400061D RID: 1565
		TimeResetNotify = 19363,
		// Token: 0x0400061E RID: 1566
		GachaPoolDetailRequest = 21264,
		// Token: 0x0400061F RID: 1567
		GachaPoolDetailResponse = 18488,
		// Token: 0x04000620 RID: 1568
		SecWorldSEndFlowResponse = 17703,
		// Token: 0x04000621 RID: 1569
		ActionOpenSystemBoardNotify = 21125,
		// Token: 0x04000622 RID: 1570
		OpenSystemBoardResultRequest = 24936,
		// Token: 0x04000623 RID: 1571
		OpenSystemBoardResultResponse = 23490,
		// Token: 0x04000624 RID: 1572
		SceneItemMoveTargetRequest = 24132,
		// Token: 0x04000625 RID: 1573
		SceneItemMoveTargetNotify = 22412,
		// Token: 0x04000626 RID: 1574
		SceneItemMoveTargetResponse = 23917,
		// Token: 0x04000627 RID: 1575
		EntityTimeFlowPush = 25621,
		// Token: 0x04000628 RID: 1576
		TrackMoonRolePropChangeNotify = 27561,
		// Token: 0x04000629 RID: 1577
		TrackMoonBuildFlowRequest = 21892,
		// Token: 0x0400062A RID: 1578
		TrackMoonBuildFlowResponse = 22345,
		// Token: 0x0400062B RID: 1579
		CorniceMeetingRewardRequest = 18385,
		// Token: 0x0400062C RID: 1580
		CorniceMeetingRewardResponse = 18253,
		// Token: 0x0400062D RID: 1581
		CorniceChallengeEndNotify = 18364,
		// Token: 0x0400062E RID: 1582
		QuestChangeTraceNotify = 22862,
		// Token: 0x0400062F RID: 1583
		TraceMoonPhaseRewardRequest = 23777,
		// Token: 0x04000630 RID: 1584
		TraceMoonPhaseRewardResponse = 17223,
		// Token: 0x04000631 RID: 1585
		TrackMoonTokenCoinNotify = 19882,
		// Token: 0x04000632 RID: 1586
		LevelPlaySwitchSportModeRequest = 23163,
		// Token: 0x04000633 RID: 1587
		LevelPlaySwitchSportModeResponse = 28737,
		// Token: 0x04000634 RID: 1588
		PlayerPsnInfoGetRequest = 29956,
		// Token: 0x04000635 RID: 1589
		PlayerPsnInfoGetResponse = 21086,
		// Token: 0x04000636 RID: 1590
		PsnSettingUpdateRequest = 24513,
		// Token: 0x04000637 RID: 1591
		PsnSettingUpdateResponse = 19977,
		// Token: 0x04000638 RID: 1592
		PsnSettingRequest = 29119,
		// Token: 0x04000639 RID: 1593
		PsnSettingResponse = 23928,
		// Token: 0x0400063A RID: 1594
		RiskHarvestEndNotify = 25888,
		// Token: 0x0400063B RID: 1595
		RiskHarvestInstUpdateNotify = 18648,
		// Token: 0x0400063C RID: 1596
		RiskHarvestArtifactNotify = 21422,
		// Token: 0x0400063D RID: 1597
		RiskHarvestInstRewardRequest = 16068,
		// Token: 0x0400063E RID: 1598
		RiskHarvestScoreRewardRequest = 26581,
		// Token: 0x0400063F RID: 1599
		RiskHarvestScoreRewardResponse = 27437,
		// Token: 0x04000640 RID: 1600
		RiskHarvestBuffUpdateNotify = 28221,
		// Token: 0x04000641 RID: 1601
		RiskHarvestBuffUnlockNotify = 16190,
		// Token: 0x04000642 RID: 1602
		ItemDisuseRequest = 20767,
		// Token: 0x04000643 RID: 1603
		ItemDisuseResponse = 28866,
		// Token: 0x04000644 RID: 1604
		PhantomBatchRefiningRequest = 27203,
		// Token: 0x04000645 RID: 1605
		PhantomBatchRefiningResponse = 18643,
		// Token: 0x04000646 RID: 1606
		RiskHarvestInstRewardResponse = 25323,
		// Token: 0x04000647 RID: 1607
		PassPortalRequest = 20215,
		// Token: 0x04000648 RID: 1608
		PassPortalResponse = 27969,
		// Token: 0x04000649 RID: 1609
		BtRangeFailWarningNotify = 22612,
		// Token: 0x0400064A RID: 1610
		BtCancelRangeFailWarningNotify = 29677,
		// Token: 0x0400064B RID: 1611
		EnrichmentAreaRequest = 27870,
		// Token: 0x0400064C RID: 1612
		EnrichmentAreaResponse = 27649,
		// Token: 0x0400064D RID: 1613
		RiskHarvestBuffUnlockRewardRequest = 29264,
		// Token: 0x0400064E RID: 1614
		RiskHarvestBuffUnlockRewardResponse = 27680,
		// Token: 0x0400064F RID: 1615
		RiskHarvestBuffCountRewardRequest = 16445,
		// Token: 0x04000650 RID: 1616
		RiskHarvestBuffCountRewardResponse = 25669,
		// Token: 0x04000651 RID: 1617
		RiskHarvestActivityUpdateNotify = 18015,
		// Token: 0x04000652 RID: 1618
		BlackCoastThemeStageUpdateNotify = 25531,
		// Token: 0x04000653 RID: 1619
		BlackCoastThemeTaskRewardRequest = 23757,
		// Token: 0x04000654 RID: 1620
		BlackCoastThemeTaskRewardResponse = 20483,
		// Token: 0x04000655 RID: 1621
		BlackCoastThemeActiveRewardRequest = 26746,
		// Token: 0x04000656 RID: 1622
		BlackCoastThemeActiveRewardResponse = 28050,
		// Token: 0x04000657 RID: 1623
		PlayerCreatePsnSessionRequest = 21404,
		// Token: 0x04000658 RID: 1624
		PlayerCreatePsnSessionResponse = 16742,
		// Token: 0x04000659 RID: 1625
		PlayerPsnSessionNotify = 15107,
		// Token: 0x0400065A RID: 1626
		PortalReplaceNotify = 28606,
		// Token: 0x0400065B RID: 1627
		RenjuResetRequest = 16999,
		// Token: 0x0400065C RID: 1628
		RenjuResetResponse = 24055,
		// Token: 0x0400065D RID: 1629
		CorniceChallengeTransRequest = 23951,
		// Token: 0x0400065E RID: 1630
		CorniceChallengeTransResponse = 28762,
		// Token: 0x0400065F RID: 1631
		FightDataCheckNotify = 22139,
		// Token: 0x04000660 RID: 1632
		GameplayTagRequest = 17502,
		// Token: 0x04000661 RID: 1633
		GameplayTagResponse = 16302,
		// Token: 0x04000662 RID: 1634
		ExecuteQteRequest = 25206,
		// Token: 0x04000663 RID: 1635
		ExecuteQteResponse = 20100,
		// Token: 0x04000664 RID: 1636
		TowerDefenceRoleReviveNotify = 18859,
		// Token: 0x04000665 RID: 1637
		TowerDefencePlayerReviveNotify = 29503,
		// Token: 0x04000666 RID: 1638
		LevelPlayerRewardHintNotify = 27910,
		// Token: 0x04000667 RID: 1639
		RiskHarvestSettleRequest = 29019,
		// Token: 0x04000668 RID: 1640
		RiskHarvestSettleResponse = 25343,
		// Token: 0x04000669 RID: 1641
		AppGradeNotify = 26027,
		// Token: 0x0400066A RID: 1642
		LinkingStateNotify = 27470,
		// Token: 0x0400066B RID: 1643
		LinkExitNotify = 16547,
		// Token: 0x0400066C RID: 1644
		MingSuHandRewardRequest = 28370,
		// Token: 0x0400066D RID: 1645
		MingSuHandRewardResponse = 22679,
		// Token: 0x0400066E RID: 1646
		SubmitAwakeAndLoadEntityNodeRequest = 17608,
		// Token: 0x0400066F RID: 1647
		SubmitAwakeAndLoadEntityNodeResponse = 16025,
		// Token: 0x04000670 RID: 1648
		RogueWhiteCatDataUpdateNotify = 27640,
		// Token: 0x04000671 RID: 1649
		RoguelikeRoleInstStartRequest = 27659,
		// Token: 0x04000672 RID: 1650
		RoguelikeRoleInstStartResponse = 18259,
		// Token: 0x04000673 RID: 1651
		RoguelikeBossInstStartRequest = 28063,
		// Token: 0x04000674 RID: 1652
		RoguelikeBossInstStartResponse = 21669,
		// Token: 0x04000675 RID: 1653
		PreheatSignRewardRequest = 20458,
		// Token: 0x04000676 RID: 1654
		PreheatSignRewardResponse = 27792,
		// Token: 0x04000677 RID: 1655
		PreheatSignSurveyInfoRequest = 15013,
		// Token: 0x04000678 RID: 1656
		PreheatSignSurveyInfoResponse = 20369,
		// Token: 0x04000679 RID: 1657
		UpdateEnableFunctionNotify = 21861,
		// Token: 0x0400067A RID: 1658
		DarkCoastInfoRequest = 20643,
		// Token: 0x0400067B RID: 1659
		DarkCoastInfoResponse = 20081,
		// Token: 0x0400067C RID: 1660
		InputSettingRequest = 28228,
		// Token: 0x0400067D RID: 1661
		InputSettingResponse = 20083,
		// Token: 0x0400067E RID: 1662
		InputSettingUpdateRequest = 20344,
		// Token: 0x0400067F RID: 1663
		InputSettingUpdateResponse = 20916,
		// Token: 0x04000680 RID: 1664
		InputSettingUpdateNotify = 25153,
		// Token: 0x04000681 RID: 1665
		MapCustomMarkUpdateNotify = 24503,
		// Token: 0x04000682 RID: 1666
		RoguelikeWriteCatRewardRequest = 26136,
		// Token: 0x04000683 RID: 1667
		RoguelikeWriteCatRewardResponse = 22912,
		// Token: 0x04000684 RID: 1668
		PayGiftConditionFinishNotify = 23030,
		// Token: 0x04000685 RID: 1669
		GetDebugInfoNotify = 20169,
		// Token: 0x04000686 RID: 1670
		ConnectorCanConnectRequest = 27563,
		// Token: 0x04000687 RID: 1671
		ConnectorCanConnectResponse = 17977,
		// Token: 0x04000688 RID: 1672
		ScratchCardRewardRequest = 23653,
		// Token: 0x04000689 RID: 1673
		ScratchCardRewardResponse = 15806,
		// Token: 0x0400068A RID: 1674
		TeleportDungeonActionNotify = 25362,
		// Token: 0x0400068B RID: 1675
		TeleportDungeonActionRequest = 17415,
		// Token: 0x0400068C RID: 1676
		TeleportDungeonActionResponse = 18689,
		// Token: 0x0400068D RID: 1677
		SceneItemAttributeChangeNotify = 17296,
		// Token: 0x0400068E RID: 1678
		SubmitWalkingPatternPointRequest = 17328,
		// Token: 0x0400068F RID: 1679
		SubmitWalkingPatternPointResponse = 25667,
		// Token: 0x04000690 RID: 1680
		AchievementCountChangeNotify = 20230,
		// Token: 0x04000691 RID: 1681
		RoguelikeWriteCatBossRewardRequest = 19415,
		// Token: 0x04000692 RID: 1682
		RoguelikeWriteCatBossRewardResponse = 23662,
		// Token: 0x04000693 RID: 1683
		RoguelikeWriteCatLevelPlayRewardRequest = 25589,
		// Token: 0x04000694 RID: 1684
		RoguelikeWriteCatLevelPlayRewardResponse = 22369,
		// Token: 0x04000695 RID: 1685
		PlayerPsnBlockListRequest = 16257,
		// Token: 0x04000696 RID: 1686
		PlayerPsnBlockListResponse = 17327,
		// Token: 0x04000697 RID: 1687
		VacuumCleanerRequest = 22748,
		// Token: 0x04000698 RID: 1688
		VacuumCleanerResponse = 22664,
		// Token: 0x04000699 RID: 1689
		BossRushChooseBuffRequest = 29389,
		// Token: 0x0400069A RID: 1690
		BossRushChooseBuffResponse = 19084,
		// Token: 0x0400069B RID: 1691
		BossRushBuffChooseResultRequest = 23159,
		// Token: 0x0400069C RID: 1692
		BossRushBuffChooseResultResponse = 24781,
		// Token: 0x0400069D RID: 1693
		ContextIdNotify = 17290,
		// Token: 0x0400069E RID: 1694
		ExecuteQteNotify = 24112,
		// Token: 0x0400069F RID: 1695
		JoinSceneNotifyConfirmRequest = 22643,
		// Token: 0x040006A0 RID: 1696
		JoinSceneNotifyConfirmResponse = 17440,
		// Token: 0x040006A1 RID: 1697
		SyncPlayerLocationNotify = 24978,
		// Token: 0x040006A2 RID: 1698
		MailBindInfoRequest = 19713,
		// Token: 0x040006A3 RID: 1699
		MailBindRewardRequest = 24034,
		// Token: 0x040006A4 RID: 1700
		MailBindRewardResponse = 27161,
		// Token: 0x040006A5 RID: 1701
		MailBindInfoResponse = 24222,
		// Token: 0x040006A6 RID: 1702
		MailBindRequest = 22555,
		// Token: 0x040006A7 RID: 1703
		MailBindResponse = 28055,
		// Token: 0x040006A8 RID: 1704
		MailBindInfoNotify = 21177,
		// Token: 0x040006A9 RID: 1705
		PrivateChatClearNotify = 19574,
		// Token: 0x040006AA RID: 1706
		HookLockPointExitRequest = 15425,
		// Token: 0x040006AB RID: 1707
		HookLockPointExitResponse = 28458,
		// Token: 0x040006AC RID: 1708
		ScratchCardCountInfoNotify = 16808,
		// Token: 0x040006AD RID: 1709
		WeaponSkinAddNotify = 17173,
		// Token: 0x040006AE RID: 1710
		WeaponSkinUnLoadNotify = 17893,
		// Token: 0x040006AF RID: 1711
		VehicleRequest = 21983,
		// Token: 0x040006B0 RID: 1712
		VehicleResponse = 23682,
		// Token: 0x040006B1 RID: 1713
		PullingFoundationRequest = 19966,
		// Token: 0x040006B2 RID: 1714
		PullingFoundationResponse = 21229,
		// Token: 0x040006B3 RID: 1715
		ItemRelateFoundationNotify = 19604,
		// Token: 0x040006B4 RID: 1716
		AddTreasureBoxSlotRequest = 23884,
		// Token: 0x040006B5 RID: 1717
		AddTreasureBoxSlotResponse = 16859,
		// Token: 0x040006B6 RID: 1718
		RemoveTreasureBoxSlotRequest = 21336,
		// Token: 0x040006B7 RID: 1719
		RemoveTreasureBoxSlotResponse = 24211,
		// Token: 0x040006B8 RID: 1720
		UseSoundBoxSkillRequest = 15919,
		// Token: 0x040006B9 RID: 1721
		UseSoundBoxSkillResponse = 22512,
		// Token: 0x040006BA RID: 1722
		AddTemporaryTeleportRequest = 25491,
		// Token: 0x040006BB RID: 1723
		AddTemporaryTeleportResponse = 20601,
		// Token: 0x040006BC RID: 1724
		VehicleUpdateNotify = 28018,
		// Token: 0x040006BD RID: 1725
		BossRushLevelScoreRewardRequest = 24337,
		// Token: 0x040006BE RID: 1726
		BossRushLevelScoreRewardResponse = 17469,
		// Token: 0x040006BF RID: 1727
		EquipSkinTakeOnRequest = 16426,
		// Token: 0x040006C0 RID: 1728
		EquipSkinTakeOnResponse = 26442,
		// Token: 0x040006C1 RID: 1729
		EquipSkinUnLoadRequest = 25017,
		// Token: 0x040006C2 RID: 1730
		EquipSkinUnLoadResponse = 15525,
		// Token: 0x040006C3 RID: 1731
		SubmitPhotoNodeRequest = 24093,
		// Token: 0x040006C4 RID: 1732
		SubmitPhotoNodeResponse = 23527,
		// Token: 0x040006C5 RID: 1733
		EntityPreloadNotify = 28870,
		// Token: 0x040006C6 RID: 1734
		QuestRollBackEndNotify = 27925,
		// Token: 0x040006C7 RID: 1735
		TreasureBoxSlotAllInfoNotify = 27789,
		// Token: 0x040006C8 RID: 1736
		RogueWhiteCatLimitedUpdateNotify = 28734,
		// Token: 0x040006C9 RID: 1737
		RogueWhiteCatLimitedRewardRequest = 29426,
		// Token: 0x040006CA RID: 1738
		RogueWhiteCatLimitedRewardResponse = 25823,
		// Token: 0x040006CB RID: 1739
		EntityEquipSkinChangeNotify = 17965,
		// Token: 0x040006CC RID: 1740
		ScratchCardActivityInfoRequest = 27153,
		// Token: 0x040006CD RID: 1741
		ScratchCardActivityInfoResponse = 24195,
		// Token: 0x040006CE RID: 1742
		QuestGiveUpNotify = 26304,
		// Token: 0x040006CF RID: 1743
		QuestReadyForGiveUpRequest = 27030,
		// Token: 0x040006D0 RID: 1744
		QuestReadyForGiveUpResponse = 19178,
		// Token: 0x040006D1 RID: 1745
		BattleScoreEnableNotify = 24023,
		// Token: 0x040006D2 RID: 1746
		ModifyEntityCampNotify = 21724,
		// Token: 0x040006D3 RID: 1747
		RogueWhiteCatRecordRequest = 23990,
		// Token: 0x040006D4 RID: 1748
		RogueWhiteCatRecordResponse = 27210,
		// Token: 0x040006D5 RID: 1749
		SetAlertUiVisibleRequest = 25636,
		// Token: 0x040006D6 RID: 1750
		SetAlertUiVisibleResponse = 26471,
		// Token: 0x040006D7 RID: 1751
		AlertAreaNotify = 25643,
		// Token: 0x040006D8 RID: 1752
		CombineEntitiesRequest = 28910,
		// Token: 0x040006D9 RID: 1753
		AddCombineEntitiesRelationNotify = 24720,
		// Token: 0x040006DA RID: 1754
		RemoveCombineRelationNotify = 18044,
		// Token: 0x040006DB RID: 1755
		CombineEntitiesResponse = 16600,
		// Token: 0x040006DC RID: 1756
		GiftPackPreviewRequest = 29403,
		// Token: 0x040006DD RID: 1757
		GiftPackPreviewResponse = 29486,
		// Token: 0x040006DE RID: 1758
		LastBigSceneMiniMapInfoRequest = 28705,
		// Token: 0x040006DF RID: 1759
		LastBigSceneMiniMapInfoResponse = 20403,
		// Token: 0x040006E0 RID: 1760
		DissolveCombineRelationRequest = 20585,
		// Token: 0x040006E1 RID: 1761
		DissolveCombineRelationResponse = 20084,
		// Token: 0x040006E2 RID: 1762
		RogueLevelPlayNotify = 29192,
		// Token: 0x040006E3 RID: 1763
		ActionRelatedEntityInfoNotify = 24779,
		// Token: 0x040006E4 RID: 1764
		GachaNewNotify = 15278,
		// Token: 0x040006E5 RID: 1765
		ExploreSkillCustomRequest = 28056,
		// Token: 0x040006E6 RID: 1766
		ExploreSkillCustomResponse = 25414,
		// Token: 0x040006E7 RID: 1767
		AchievementUpdateRequest = 28975,
		// Token: 0x040006E8 RID: 1768
		AchievementUpdateResponse = 22115,
		// Token: 0x040006E9 RID: 1769
		TestDamageRecordNotify = 25211,
		// Token: 0x040006EA RID: 1770
		RogueBossLinkSettleNotify = 19729,
		// Token: 0x040006EB RID: 1771
		SeamlessTeleportRequest = 17907,
		// Token: 0x040006EC RID: 1772
		SeamlessTeleportResponse = 15205,
		// Token: 0x040006ED RID: 1773
		RogueBlackFlowerNotify = 24206,
		// Token: 0x040006EE RID: 1774
		RogueBlackFlowerRequest = 24506,
		// Token: 0x040006EF RID: 1775
		RogueBlackFlowerResponse = 19376,
		// Token: 0x040006F0 RID: 1776
		UpdateSceneGroupDataRequest = 16945,
		// Token: 0x040006F1 RID: 1777
		UpdateSceneGroupDataResponse = 19725,
		// Token: 0x040006F2 RID: 1778
		CombatDataMaxNotify = 27399,
		// Token: 0x040006F3 RID: 1779
		MowTowerSettlementRequest = 26061,
		// Token: 0x040006F4 RID: 1780
		MowTowerSettlementResponse = 27490,
		// Token: 0x040006F5 RID: 1781
		MowTowerFirstScoreNotify = 28712,
		// Token: 0x040006F6 RID: 1782
		MowTowerResultNotify = 17664,
		// Token: 0x040006F7 RID: 1783
		MowTowerLevelsRewardRequest = 16582,
		// Token: 0x040006F8 RID: 1784
		MowTowerLevelsRewardResponse = 17233,
		// Token: 0x040006F9 RID: 1785
		RoleSkinChangeRequest = 26398,
		// Token: 0x040006FA RID: 1786
		RoleSkinChangeResponse = 27229,
		// Token: 0x040006FB RID: 1787
		RoleSkinUpdateNotify = 26056,
		// Token: 0x040006FC RID: 1788
		RoleSkinRequest = 26601,
		// Token: 0x040006FD RID: 1789
		RoleSkinResponse = 15433,
		// Token: 0x040006FE RID: 1790
		RoleSkinAddNotify = 20442,
		// Token: 0x040006FF RID: 1791
		SceneItemAiEnableNotify = 26148,
		// Token: 0x04000700 RID: 1792
		SceneItemAiDisableNotify = 21693,
		// Token: 0x04000701 RID: 1793
		TeamMatchInviteRetToHostNotify = 15606,
		// Token: 0x04000702 RID: 1794
		SceneItemAiPatrolPointNotify = 28782,
		// Token: 0x04000703 RID: 1795
		SceneItemBlackboardNotify = 20724,
		// Token: 0x04000704 RID: 1796
		TeleportDungeonForbidNotify = 28830,
		// Token: 0x04000705 RID: 1797
		EntityGravityUpdateNotify = 26798,
		// Token: 0x04000706 RID: 1798
		PhantomMusicUnlockRequest = 25144,
		// Token: 0x04000707 RID: 1799
		PhantomMusicUnlockResponse = 23502,
		// Token: 0x04000708 RID: 1800
		PhantomMusicInfoRequest = 16180,
		// Token: 0x04000709 RID: 1801
		PhantomMusicInfoResponse = 16334,
		// Token: 0x0400070A RID: 1802
		PhantomMusicSwitchRequest = 23417,
		// Token: 0x0400070B RID: 1803
		PhantomMusicSwitchResponse = 15618,
		// Token: 0x0400070C RID: 1804
		UpdateSceneItemBlackboardRequest = 15059,
		// Token: 0x0400070D RID: 1805
		UpdateSceneItemBlackboardResponse = 19386,
		// Token: 0x0400070E RID: 1806
		MowTowerLevelsInfoUpdateNotify = 16031,
		// Token: 0x0400070F RID: 1807
		VehicleChangePassengerRequest = 22200,
		// Token: 0x04000710 RID: 1808
		VehicleChangePassengerResponse = 21531,
		// Token: 0x04000711 RID: 1809
		VehicleRemovePassengerRequest = 26143,
		// Token: 0x04000712 RID: 1810
		VehicleRemovePassengerResponse = 20287,
		// Token: 0x04000713 RID: 1811
		VehiclePassengerUpdateNotify = 20875,
		// Token: 0x04000714 RID: 1812
		AnimalCollectStateNotify = 28587,
		// Token: 0x04000715 RID: 1813
		LevelSequenceFrameEventActionRequest = 20312,
		// Token: 0x04000716 RID: 1814
		LevelSequenceFrameEventActionResponse = 20164,
		// Token: 0x04000717 RID: 1815
		SimpleTrackReportRequest = 15365,
		// Token: 0x04000718 RID: 1816
		SimpleTrackReportResponse = 23444,
		// Token: 0x04000719 RID: 1817
		PlayerVoxelEnvRequest = 27177,
		// Token: 0x0400071A RID: 1818
		PlayerVoxelEnvResponse = 15604,
		// Token: 0x0400071B RID: 1819
		TurntableTaskUpdateNotify = 20220,
		// Token: 0x0400071C RID: 1820
		MapTravelInfoUpdateNotify = 23579,
		// Token: 0x0400071D RID: 1821
		MapTravelFullRewardRequest = 21062,
		// Token: 0x0400071E RID: 1822
		MapTravelFullRewardResponse = 18348,
		// Token: 0x0400071F RID: 1823
		MapTravelLevelUpRequest = 24973,
		// Token: 0x04000720 RID: 1824
		MapTravelLevelUpResponse = 26622,
		// Token: 0x04000721 RID: 1825
		SpringSignDrawRoleRequest = 18204,
		// Token: 0x04000722 RID: 1826
		SpringSignDrawRoleResponse = 25860,
		// Token: 0x04000723 RID: 1827
		LevelPlayVarRequest = 17974,
		// Token: 0x04000724 RID: 1828
		LevelPlayVarResponse = 21256,
		// Token: 0x04000725 RID: 1829
		MaterialReplaceRequest = 26427,
		// Token: 0x04000726 RID: 1830
		MaterialReplaceResponse = 17042,
		// Token: 0x04000727 RID: 1831
		ExploreProgressRewardRequest = 29451,
		// Token: 0x04000728 RID: 1832
		ExploreProgressRewardResponse = 28094,
		// Token: 0x04000729 RID: 1833
		ExploreProgressRewardIdsNotify = 25441,
		// Token: 0x0400072A RID: 1834
		RoleTrialUiEndPush = 29512,
		// Token: 0x0400072B RID: 1835
		SpringSignDrawRewardRequest = 17001,
		// Token: 0x0400072C RID: 1836
		SpringSignDrawRewardResponse = 23619,
		// Token: 0x0400072D RID: 1837
		EntityCameraAlertRequest = 15507,
		// Token: 0x0400072E RID: 1838
		EntityCameraAlertResponse = 21236,
		// Token: 0x0400072F RID: 1839
		ThroughTrainRequest = 26589,
		// Token: 0x04000730 RID: 1840
		ThroughTrainResponse = 29273,
		// Token: 0x04000731 RID: 1841
		BoardCanMovePlacementNotify = 27769,
		// Token: 0x04000732 RID: 1842
		FarmGoldLevelDiffRequest = 19651,
		// Token: 0x04000733 RID: 1843
		FarmGoldResultNotify = 20566,
		// Token: 0x04000734 RID: 1844
		FarmGoldLevelNotify = 24429,
		// Token: 0x04000735 RID: 1845
		CheckUseSoundBoxSkillRequest = 16116,
		// Token: 0x04000736 RID: 1846
		CheckUseSoundBoxSkillResponse = 18835,
		// Token: 0x04000737 RID: 1847
		FarmGoldPointRequest = 25630,
		// Token: 0x04000738 RID: 1848
		FarmGoldPointResponse = 27220,
		// Token: 0x04000739 RID: 1849
		FarmGoldLevelPlayRequest = 22663,
		// Token: 0x0400073A RID: 1850
		FarmGoldLevelPlayResponse = 26415,
		// Token: 0x0400073B RID: 1851
		FarmGoldLevelDiffResponse = 26855,
		// Token: 0x0400073C RID: 1852
		SpringSignSkinRewardRequest = 20317,
		// Token: 0x0400073D RID: 1853
		SpringSignSkinRewardResponse = 26418,
		// Token: 0x0400073E RID: 1854
		FarmGoldResultRequest = 20486,
		// Token: 0x0400073F RID: 1855
		FarmGoldResultResponse = 24579,
		// Token: 0x04000740 RID: 1856
		FlowSeqSetPlayerPosRequest = 29398,
		// Token: 0x04000741 RID: 1857
		FlowSeqSetPlayerPosResponse = 16827,
		// Token: 0x04000742 RID: 1858
		TeamTeleportStartNotify = 25696,
		// Token: 0x04000743 RID: 1859
		SplineMoveRequest = 26613,
		// Token: 0x04000744 RID: 1860
		SplineMoveResponse = 26766,
		// Token: 0x04000745 RID: 1861
		SplineMoveNotify = 26842,
		// Token: 0x04000746 RID: 1862
		LevelPlayStateRequest = 16155,
		// Token: 0x04000747 RID: 1863
		LevelPlayStateResponse = 29313,
		// Token: 0x04000748 RID: 1864
		TeleportVehicleNotify = 22711,
		// Token: 0x04000749 RID: 1865
		PlayerHeadRequest = 18199,
		// Token: 0x0400074A RID: 1866
		PlayerHeadResponse = 22413,
		// Token: 0x0400074B RID: 1867
		PlayerHeadAddNotify = 29216,
		// Token: 0x0400074C RID: 1868
		VehicleUpdateEntityNotify = 16415,
		// Token: 0x0400074D RID: 1869
		EntityWalkingPatternFinishRequest = 29045,
		// Token: 0x0400074E RID: 1870
		EntityWalkingPatternFinishResponse = 23002,
		// Token: 0x0400074F RID: 1871
		QueryOnlinePlayersAreaRequest = 15827,
		// Token: 0x04000750 RID: 1872
		QueryOnlinePlayersAreaResponse = 21413,
		// Token: 0x04000751 RID: 1873
		DetectionPreOpenNotify = 23923,
		// Token: 0x04000752 RID: 1874
		MapTravelTaskRewardRequest = 24943,
		// Token: 0x04000753 RID: 1875
		MapTravelTaskRewardResponse = 28036,
		// Token: 0x04000754 RID: 1876
		MapTravelSoarRewardRequest = 15351,
		// Token: 0x04000755 RID: 1877
		MapTravelSoarRewardResponse = 24818,
		// Token: 0x04000756 RID: 1878
		FishingInfoRequest = 18438,
		// Token: 0x04000757 RID: 1879
		FishingInfoResponse = 22673,
		// Token: 0x04000758 RID: 1880
		FishingInfoUpdateNotify = 19875,
		// Token: 0x04000759 RID: 1881
		FishingShipInfoUpdateNotify = 16082,
		// Token: 0x0400075A RID: 1882
		FishingTechInfoUpdateNotify = 29078,
		// Token: 0x0400075B RID: 1883
		FishingIllustratedInfoUpdateNotify = 28244,
		// Token: 0x0400075C RID: 1884
		FishingIllustratedRewardInfoUpdateNotify = 26235,
		// Token: 0x0400075D RID: 1885
		FishingSceneFishCageInfoUpdateNotify = 25515,
		// Token: 0x0400075E RID: 1886
		SceneFishPointInfoUpdateNotify = 17940,
		// Token: 0x0400075F RID: 1887
		FishingIllustratedRewardRequest = 26334,
		// Token: 0x04000760 RID: 1888
		FishingIllustratedRewardResponse = 27309,
		// Token: 0x04000761 RID: 1889
		FishingCabinPutRequest = 27290,
		// Token: 0x04000762 RID: 1890
		FishingCabinPutResponse = 27464,
		// Token: 0x04000763 RID: 1891
		FishingQuickSellPreviewRequest = 29724,
		// Token: 0x04000764 RID: 1892
		FishingQuickSellPreviewResponse = 25935,
		// Token: 0x04000765 RID: 1893
		FishingQuickSellRequest = 19986,
		// Token: 0x04000766 RID: 1894
		FishingQuickSellResponse = 24478,
		// Token: 0x04000767 RID: 1895
		FishingSellPreviewRequest = 25932,
		// Token: 0x04000768 RID: 1896
		FishingSellPreviewResponse = 23795,
		// Token: 0x04000769 RID: 1897
		FishingSellRequest = 18289,
		// Token: 0x0400076A RID: 1898
		FishingSellResponse = 23025,
		// Token: 0x0400076B RID: 1899
		FishingSailingRequest = 21616,
		// Token: 0x0400076C RID: 1900
		FishingSailingResponse = 20883,
		// Token: 0x0400076D RID: 1901
		FishingEntrustHandInRequest = 19706,
		// Token: 0x0400076E RID: 1902
		FishingEntrustHandInResponse = 28305,
		// Token: 0x0400076F RID: 1903
		FishingEntrustTraceRequest = 21717,
		// Token: 0x04000770 RID: 1904
		FishingEntrustTraceResponse = 29628,
		// Token: 0x04000771 RID: 1905
		FishingEntrustRefreshRequest = 22223,
		// Token: 0x04000772 RID: 1906
		FishingEntrustRefreshResponse = 16187,
		// Token: 0x04000773 RID: 1907
		FishingShipForceBackNotify = 28002,
		// Token: 0x04000774 RID: 1908
		FishingShipFixRequest = 15255,
		// Token: 0x04000775 RID: 1909
		FishingShipFixResponse = 21934,
		// Token: 0x04000776 RID: 1910
		FishingTechLevelUpRequest = 18947,
		// Token: 0x04000777 RID: 1911
		FishingTechLevelUpResponse = 24459,
		// Token: 0x04000778 RID: 1912
		FishingItemAddNotify = 22817,
		// Token: 0x04000779 RID: 1913
		FishingNoticeUpdateNotify = 15366,
		// Token: 0x0400077A RID: 1914
		AccessPathConfigRequest = 28506,
		// Token: 0x0400077B RID: 1915
		AccessPathConfigResponse = 22626,
		// Token: 0x0400077C RID: 1916
		PlayerGameTokenRequest = 18839,
		// Token: 0x0400077D RID: 1917
		PlayerGameTokenResponse = 26225,
		// Token: 0x0400077E RID: 1918
		RenjuExitMatchedActionRequest = 25656,
		// Token: 0x0400077F RID: 1919
		RenjuExitMatchedActionResponse = 26468,
		// Token: 0x04000780 RID: 1920
		HookLockPointInfoNotify = 21402,
		// Token: 0x04000781 RID: 1921
		HandInInfoUpdateNotify = 25098,
		// Token: 0x04000782 RID: 1922
		TrialRoleSkinRewardRequest = 27840,
		// Token: 0x04000783 RID: 1923
		TrialRoleSkinRewardResponse = 25081,
		// Token: 0x04000784 RID: 1924
		RoleSkinTrialSettleNotify = 25987,
		// Token: 0x04000785 RID: 1925
		RoleSkinTrialUiEndPush = 26571,
		// Token: 0x04000786 RID: 1926
		LevelPlayStateListRequest = 17858,
		// Token: 0x04000787 RID: 1927
		LevelPlayStateListResponse = 24664,
		// Token: 0x04000788 RID: 1928
		SpringSignPhotoRewardRequest = 26463,
		// Token: 0x04000789 RID: 1929
		SpringSignPhotoRewardResponse = 20917,
		// Token: 0x0400078A RID: 1930
		BuffDurationNotify = 24676,
		// Token: 0x0400078B RID: 1931
		PhantomEquipGroupInfosRequest = 25068,
		// Token: 0x0400078C RID: 1932
		PhantomEquipGroupInfosResponse = 17071,
		// Token: 0x0400078D RID: 1933
		AddPhantomEquipGroupRequest = 18869,
		// Token: 0x0400078E RID: 1934
		AddPhantomEquipGroupResponse = 17340,
		// Token: 0x0400078F RID: 1935
		DeletePhantomEquipGroupRequest = 28863,
		// Token: 0x04000790 RID: 1936
		DeletePhantomEquipGroupResponse = 16721,
		// Token: 0x04000791 RID: 1937
		TopPhantomEquipGroupRequest = 19922,
		// Token: 0x04000792 RID: 1938
		ChangePhantomEquipGroupNameRequest = 18907,
		// Token: 0x04000793 RID: 1939
		ChangePhantomEquipGroupNameResponse = 16060,
		// Token: 0x04000794 RID: 1940
		TopPhantomEquipGroupResponse = 24824,
		// Token: 0x04000795 RID: 1941
		FishingCompleteRequest = 21375,
		// Token: 0x04000796 RID: 1942
		FishingCompleteResponse = 23801,
		// Token: 0x04000797 RID: 1943
		TeleportFlowEndRequest = 16124,
		// Token: 0x04000798 RID: 1944
		TeleportFlowEndResponse = 15441,
		// Token: 0x04000799 RID: 1945
		TeleportFlowNotify = 27892,
		// Token: 0x0400079A RID: 1946
		RiskHarvestStarRewardRequest = 22005,
		// Token: 0x0400079B RID: 1947
		RiskHarvestStarRewardResponse = 17366,
		// Token: 0x0400079C RID: 1948
		FishingEntrustUpdateNotify = 28710,
		// Token: 0x0400079D RID: 1949
		PhantomFetterRecommendRequest = 29643,
		// Token: 0x0400079E RID: 1950
		PhantomFetterRecommendResponse = 25672,
		// Token: 0x0400079F RID: 1951
		PhantomAttrRecommendRequest = 18178,
		// Token: 0x040007A0 RID: 1952
		PhantomAttrRecommendResponse = 29590,
		// Token: 0x040007A1 RID: 1953
		FishingEntrustAcceptRequest = 28651,
		// Token: 0x040007A2 RID: 1954
		FishingEntrustAcceptResponse = 18952,
		// Token: 0x040007A3 RID: 1955
		FishingExitRequest = 16269,
		// Token: 0x040007A4 RID: 1956
		FishingExitResponse = 15747,
		// Token: 0x040007A5 RID: 1957
		FishingPortUnlockNotify = 23503,
		// Token: 0x040007A6 RID: 1958
		FishingShipSkinChangeRequest = 17127,
		// Token: 0x040007A7 RID: 1959
		FishingShipSkinChangeResponse = 21884,
		// Token: 0x040007A8 RID: 1960
		FishingPointInfoRequest = 22194,
		// Token: 0x040007A9 RID: 1961
		FishingPointInfoResponse = 19378,
		// Token: 0x040007AA RID: 1962
		FishingCageInfoRequest = 26932,
		// Token: 0x040007AB RID: 1963
		FishingCageInfoResponse = 16693,
		// Token: 0x040007AC RID: 1964
		AiInformationPush = 22125,
		// Token: 0x040007AD RID: 1965
		AiBlackboardsPush = 16697,
		// Token: 0x040007AE RID: 1966
		AiBlackboardCdPush = 18641,
		// Token: 0x040007AF RID: 1967
		AiHatePush = 22440,
		// Token: 0x040007B0 RID: 1968
		ApplyGameplayEffectPush = 17445,
		// Token: 0x040007B1 RID: 1969
		RemoveGameplayEffectPush = 29542,
		// Token: 0x040007B2 RID: 1970
		ActivateBuffPush = 16028,
		// Token: 0x040007B3 RID: 1971
		BuffStackCountPush = 17747,
		// Token: 0x040007B4 RID: 1972
		BuffEffectPush = 26677,
		// Token: 0x040007B5 RID: 1973
		ChangeStateConfirmPush = 24241,
		// Token: 0x040007B6 RID: 1974
		FsmPlayMontagePush = 28981,
		// Token: 0x040007B7 RID: 1975
		LogicStateInitPush = 16642,
		// Token: 0x040007B8 RID: 1976
		SwitchLogicStatePush = 18461,
		// Token: 0x040007B9 RID: 1977
		AnimationGameplayTagPush = 15510,
		// Token: 0x040007BA RID: 1978
		BoneVisibleChangePush = 20838,
		// Token: 0x040007BB RID: 1979
		EntityStaticHookMovePush = 20537,
		// Token: 0x040007BC RID: 1980
		EndSkillPush = 18120,
		// Token: 0x040007BD RID: 1981
		InterruptSkillInDelayPush = 25432,
		// Token: 0x040007BE RID: 1982
		UseSkillFailPush = 15749,
		// Token: 0x040007BF RID: 1983
		HitEndPush = 15924,
		// Token: 0x040007C0 RID: 1984
		CaughtPush = 16870,
		// Token: 0x040007C1 RID: 1985
		CreateBulletPush = 26882,
		// Token: 0x040007C2 RID: 1986
		DestroyBulletPush = 28662,
		// Token: 0x040007C3 RID: 1987
		ModifyBulletParamsPush = 16856,
		// Token: 0x040007C4 RID: 1988
		PassiveSkillAddPush = 19744,
		// Token: 0x040007C5 RID: 1989
		PassiveSkillRemovePush = 21698,
		// Token: 0x040007C6 RID: 1990
		EnterViewDirectionPush = 19916,
		// Token: 0x040007C7 RID: 1991
		ExitViewDirectionPush = 16646,
		// Token: 0x040007C8 RID: 1992
		TriggerExitSkillPush = 24805,
		// Token: 0x040007C9 RID: 1993
		EntityIsVisiblePush = 29093,
		// Token: 0x040007CA RID: 1994
		ActorVisiblePush = 16875,
		// Token: 0x040007CB RID: 1995
		SwitchCharacterStatePush = 17009,
		// Token: 0x040007CC RID: 1996
		BattleStateChangePush = 19385,
		// Token: 0x040007CD RID: 1997
		ToughCalcExtraRatioChangePush = 24735,
		// Token: 0x040007CE RID: 1998
		MonsterBoomPush = 25242,
		// Token: 0x040007CF RID: 1999
		ANStartPush = 19776,
		// Token: 0x040007D0 RID: 2000
		GameplayTagPush = 24743,
		// Token: 0x040007D1 RID: 2001
		GameplayCuePush = 21343,
		// Token: 0x040007D2 RID: 2002
		ExecuteQtePush = 16952,
		// Token: 0x040007D3 RID: 2003
		ClientCurrentRoleReportPush = 29219,
		// Token: 0x040007D4 RID: 2004
		PartUpdatePush = 25777,
		// Token: 0x040007D5 RID: 2005
		AnimationStateInitPush = 22251,
		// Token: 0x040007D6 RID: 2006
		AnimationStateChangedPush = 24970,
		// Token: 0x040007D7 RID: 2007
		DrownPush = 29058,
		// Token: 0x040007D8 RID: 2008
		DrownEndTeleportPush = 23918,
		// Token: 0x040007D9 RID: 2009
		MonsterDrownPush = 26858,
		// Token: 0x040007DA RID: 2010
		MaterialPush = 27552,
		// Token: 0x040007DB RID: 2011
		RTimeStopAnimPush = 28729,
		// Token: 0x040007DC RID: 2012
		RTimeStopPush = 21080,
		// Token: 0x040007DD RID: 2013
		RTimeStopInstPush = 20960,
		// Token: 0x040007DE RID: 2014
		FishingHandInRequest = 17299,
		// Token: 0x040007DF RID: 2015
		FishingHandInResponse = 18677,
		// Token: 0x040007E0 RID: 2016
		FishingSkillBombRequest = 23767,
		// Token: 0x040007E1 RID: 2017
		FishingSkillBombResponse = 16903,
		// Token: 0x040007E2 RID: 2018
		FishingSkillBaitRequest = 28647,
		// Token: 0x040007E3 RID: 2019
		FishingSkillBaitResponse = 27026,
		// Token: 0x040007E4 RID: 2020
		FishingSkillTeleportRequest = 18398,
		// Token: 0x040007E5 RID: 2021
		FishingSkillTeleportResponse = 18913,
		// Token: 0x040007E6 RID: 2022
		RogueWeeklyRewardRequest = 16216,
		// Token: 0x040007E7 RID: 2023
		RogueWeeklyRewardResponse = 23902,
		// Token: 0x040007E8 RID: 2024
		RogueWeeklyRoomInfoNotify = 18827,
		// Token: 0x040007E9 RID: 2025
		RogueWeeklyGotoNextRoomRequest = 24488,
		// Token: 0x040007EA RID: 2026
		RogueWeeklyGotoNextRoomResponse = 29783,
		// Token: 0x040007EB RID: 2027
		RogueWeeklySubLevelNotify = 21204,
		// Token: 0x040007EC RID: 2028
		RogueWeeklyResultNotify = 19127,
		// Token: 0x040007ED RID: 2029
		SlashAndTowerInfoRequest = 21662,
		// Token: 0x040007EE RID: 2030
		SlashAndTowerInfoResponse = 29704,
		// Token: 0x040007EF RID: 2031
		SlashAndTowerScoreRewardRequest = 25485,
		// Token: 0x040007F0 RID: 2032
		SlashAndTowerScoreRewardResponse = 18302,
		// Token: 0x040007F1 RID: 2033
		EndLessHistoryRequest = 20333,
		// Token: 0x040007F2 RID: 2034
		EndLessHistoryResponse = 29560,
		// Token: 0x040007F3 RID: 2035
		SlashAndTowerResultNotify = 24868,
		// Token: 0x040007F4 RID: 2036
		SlashAndTowerLevelPlayNotify = 18154,
		// Token: 0x040007F5 RID: 2037
		SlashAndTowerSaveRecordRequest = 19751,
		// Token: 0x040007F6 RID: 2038
		SlashAndTowerSaveRecordResponse = 27817,
		// Token: 0x040007F7 RID: 2039
		SlashAndTowerResetRequest = 27317,
		// Token: 0x040007F8 RID: 2040
		SlashAndTowerResetResponse = 29466,
		// Token: 0x040007F9 RID: 2041
		SlashAndTowerRecommendRequest = 29840,
		// Token: 0x040007FA RID: 2042
		SlashAndTowerRecommendResponse = 23623,
		// Token: 0x040007FB RID: 2043
		SceneTempFishPointInfoUpdateNotify = 16073,
		// Token: 0x040007FC RID: 2044
		BossRushTaskUpdateNotify = 28139,
		// Token: 0x040007FD RID: 2045
		BossRushTaskRewardRequest = 25214,
		// Token: 0x040007FE RID: 2046
		BossRushTaskRewardResponse = 24143,
		// Token: 0x040007FF RID: 2047
		CharacterLookAtNotify = 24799,
		// Token: 0x04000800 RID: 2048
		UsePhantomEquipGroupRequest = 23641,
		// Token: 0x04000801 RID: 2049
		UsePhantomEquipGroupResponse = 19113,
		// Token: 0x04000802 RID: 2050
		FishingActivityLimitTaskNotify = 28644,
		// Token: 0x04000803 RID: 2051
		FishingActivityMileStoneNotify = 19138,
		// Token: 0x04000804 RID: 2052
		FishingActivityLimitRewardRequest = 26494,
		// Token: 0x04000805 RID: 2053
		FishingActivityLimitRewardResponse = 23099,
		// Token: 0x04000806 RID: 2054
		FishingActivityMilestoneRewardRequest = 25523,
		// Token: 0x04000807 RID: 2055
		FishingActivityMilestoneRewardResponse = 21498,
		// Token: 0x04000808 RID: 2056
		FishingBoatDieNotify = 19589,
		// Token: 0x04000809 RID: 2057
		TeamParkourRewardRequest = 19943,
		// Token: 0x0400080A RID: 2058
		TeamParkourRewardResponse = 28854,
		// Token: 0x0400080B RID: 2059
		TeamParkourTaskNotify = 18720,
		// Token: 0x0400080C RID: 2060
		TeamParkourSettleNotify = 16281,
		// Token: 0x0400080D RID: 2061
		RogueWeeklyResultRequest = 28144,
		// Token: 0x0400080E RID: 2062
		RogueWeeklyResultResponse = 20631,
		// Token: 0x0400080F RID: 2063
		RogueWeeklyInstInfoNotify = 15788,
		// Token: 0x04000810 RID: 2064
		RogueWeeklyOptionSelectRequest = 19544,
		// Token: 0x04000811 RID: 2065
		RogueWeeklyOptionSelectResponse = 15921,
		// Token: 0x04000812 RID: 2066
		PlayEntityMontagePush = 24591,
		// Token: 0x04000813 RID: 2067
		ThroughTrainForceRemindNotify = 29505,
		// Token: 0x04000814 RID: 2068
		ThroughTrainFinishViewRequest = 16804,
		// Token: 0x04000815 RID: 2069
		ThroughTrainFinishViewResponse = 19302,
		// Token: 0x04000816 RID: 2070
		FishingActivityMilestoneItemNumNotify = 24887,
		// Token: 0x04000817 RID: 2071
		AddHackingEntityNotify = 28303,
		// Token: 0x04000818 RID: 2072
		RemoveHackingEntityNotify = 20772,
		// Token: 0x04000819 RID: 2073
		BossRushSelectBuffNotify = 23543,
		// Token: 0x0400081A RID: 2074
		ActivityPreOpenRequest = 18144,
		// Token: 0x0400081B RID: 2075
		ActivityPreOpenResponse = 26181,
		// Token: 0x0400081C RID: 2076
		ActionGroupCreateNotify = 25896,
		// Token: 0x0400081D RID: 2077
		ActionGroupCompleteNotify = 17755,
		// Token: 0x0400081E RID: 2078
		ShopInfoUpdateNotify = 28209,
		// Token: 0x0400081F RID: 2079
		LstBattleRecordRequest = 29144,
		// Token: 0x04000820 RID: 2080
		LstBattleRecordResponse = 21300,
		// Token: 0x04000821 RID: 2081
		RogueWeeklyStartRequest = 28012,
		// Token: 0x04000822 RID: 2082
		RogueWeeklyStartResponse = 18980,
		// Token: 0x04000823 RID: 2083
		RogueWeeklyCurrencyNotify = 25282,
		// Token: 0x04000824 RID: 2084
		RogueWeeklyCurrencyUpdateNotify = 15390,
		// Token: 0x04000825 RID: 2085
		FishingGhostStateNotify = 15355,
		// Token: 0x04000826 RID: 2086
		FishingSkinUnlockNotify = 18702,
		// Token: 0x04000827 RID: 2087
		FishingTeleportToBoatRequest = 23911,
		// Token: 0x04000828 RID: 2088
		FishingTeleportToBoatResponse = 21519,
		// Token: 0x04000829 RID: 2089
		TowerDefenceRandListRequest = 16075,
		// Token: 0x0400082A RID: 2090
		TowerDefenceRandListResponse = 29510,
		// Token: 0x0400082B RID: 2091
		TowerDefenceRankShowNameRequest = 16285,
		// Token: 0x0400082C RID: 2092
		TowerDefenceRankShowNameResponse = 17528,
		// Token: 0x0400082D RID: 2093
		BabelActivityLevelInfoNotify = 21440,
		// Token: 0x0400082E RID: 2094
		BabelActivityBuffInfoNotify = 21577,
		// Token: 0x0400082F RID: 2095
		BabelActivityTaskInfoNotify = 21420,
		// Token: 0x04000830 RID: 2096
		BabelActivityDailyTaskInfoNotify = 23786,
		// Token: 0x04000831 RID: 2097
		BabelTowerTaskRewardRequest = 24223,
		// Token: 0x04000832 RID: 2098
		BabelTowerTaskRewardResponse = 16607,
		// Token: 0x04000833 RID: 2099
		BabelTowerDailyTaskRewardRequest = 25570,
		// Token: 0x04000834 RID: 2100
		BabelTowerDailyTaskRewardResponse = 23540,
		// Token: 0x04000835 RID: 2101
		ResetBabelTowerLevelRequest = 22844,
		// Token: 0x04000836 RID: 2102
		ResetBabelTowerLevelResponse = 27850,
		// Token: 0x04000837 RID: 2103
		AddGuestNotify = 15984,
		// Token: 0x04000838 RID: 2104
		RemoveGuestNotify = 18978,
		// Token: 0x04000839 RID: 2105
		BabelActivitySettleInfoNotify = 16355,
		// Token: 0x0400083A RID: 2106
		BabelTowerSettlementRequest = 26063,
		// Token: 0x0400083B RID: 2107
		BabelTowerSettlementResponse = 22271,
		// Token: 0x0400083C RID: 2108
		RogueWeeklyBlackFlowerNotify = 22410,
		// Token: 0x0400083D RID: 2109
		RogueWeeklyBlackFlowerRequest = 21004,
		// Token: 0x0400083E RID: 2110
		RogueWeeklyBlackFlowerResponse = 21684,
		// Token: 0x0400083F RID: 2111
		SceneSubLevelsRequest = 16545,
		// Token: 0x04000840 RID: 2112
		SceneSubLevelsResponse = 22498,
		// Token: 0x04000841 RID: 2113
		PlayerTitleUpdateNotify = 24894,
		// Token: 0x04000842 RID: 2114
		DressPlayerTitleUpdateNotify = 19561,
		// Token: 0x04000843 RID: 2115
		PlayerTitleRequest = 25420,
		// Token: 0x04000844 RID: 2116
		PlayerTitleResponse = 23404,
		// Token: 0x04000845 RID: 2117
		ChangePlayerTitleRequest = 28211,
		// Token: 0x04000846 RID: 2118
		ChangePlayerTitleResponse = 23826,
		// Token: 0x04000847 RID: 2119
		AwakeItemVehicleRequest = 27784,
		// Token: 0x04000848 RID: 2120
		AwakeItemVehicleResponse = 16446,
		// Token: 0x04000849 RID: 2121
		ReplaceVehicleEntityNotify = 28957,
		// Token: 0x0400084A RID: 2122
		BabelActivityDeTermInfoNotify = 24618,
		// Token: 0x0400084B RID: 2123
		SelectBabelActivityDeTermRequest = 17576,
		// Token: 0x0400084C RID: 2124
		SelectBabelActivityDeTermResponse = 17683,
		// Token: 0x0400084D RID: 2125
		GravityFlipInteractRequest = 24889,
		// Token: 0x0400084E RID: 2126
		GravityFlipInteractResponse = 19707,
		// Token: 0x0400084F RID: 2127
		AbyssRoleInfoUpdateNotify = 17390,
		// Token: 0x04000850 RID: 2128
		AbyssPluginItemInfoUpdateNotify = 23091,
		// Token: 0x04000851 RID: 2129
		AbyssRewardsUpdateNotify = 21881,
		// Token: 0x04000852 RID: 2130
		AbyssChallengeUpdateNotify = 20812,
		// Token: 0x04000853 RID: 2131
		AbyssChallengeUnlockRequest = 23937,
		// Token: 0x04000854 RID: 2132
		AbyssChallengeUnlockResponse = 21147,
		// Token: 0x04000855 RID: 2133
		AbyssChallengeQuitRequest = 20789,
		// Token: 0x04000856 RID: 2134
		AbyssChallengeQuitResponse = 25360,
		// Token: 0x04000857 RID: 2135
		AbyssChallengeResultNotify = 27258,
		// Token: 0x04000858 RID: 2136
		AbyssLikeRequest = 15542,
		// Token: 0x04000859 RID: 2137
		AbyssLikeResponse = 21792,
		// Token: 0x0400085A RID: 2138
		AbyssLikeNotify = 22047,
		// Token: 0x0400085B RID: 2139
		AbyssChallengeSubLevelNotify = 18059,
		// Token: 0x0400085C RID: 2140
		AbyssChallengeGotoNextRoomRequest = 25389,
		// Token: 0x0400085D RID: 2141
		AbyssChallengeGotoNextRoomResponse = 27237,
		// Token: 0x0400085E RID: 2142
		AbyssChallengeRoomInfoNotify = 18217,
		// Token: 0x0400085F RID: 2143
		AbyssRewardRequest = 27914,
		// Token: 0x04000860 RID: 2144
		AbyssRewardResponse = 26593,
		// Token: 0x04000861 RID: 2145
		AbyssLittleRoleLevelUpRequest = 21041,
		// Token: 0x04000862 RID: 2146
		AbyssLittleRoleLevelUpResponse = 22337,
		// Token: 0x04000863 RID: 2147
		AbyssPluginPutRequest = 27978,
		// Token: 0x04000864 RID: 2148
		AbyssPluginPutResponse = 23547,
		// Token: 0x04000865 RID: 2149
		AbyssPluginSynthesisRequest = 15330,
		// Token: 0x04000866 RID: 2150
		AbyssPluginSynthesisResponse = 20432,
		// Token: 0x04000867 RID: 2151
		AbyssRankListRequest = 21276,
		// Token: 0x04000868 RID: 2152
		AbyssRankListResponse = 25849,
		// Token: 0x04000869 RID: 2153
		AbyssShowNameRequest = 25707,
		// Token: 0x0400086A RID: 2154
		AbyssShowNameResponse = 18840,
		// Token: 0x0400086B RID: 2155
		AbyssRoleSelectUpdateNotify = 19763,
		// Token: 0x0400086C RID: 2156
		FishingPortUpdateNotify = 17589,
		// Token: 0x0400086D RID: 2157
		BabelActivityUseReviveCountNotify = 18819,
		// Token: 0x0400086E RID: 2158
		AbyssReviveCharacterRequest = 19506,
		// Token: 0x0400086F RID: 2159
		AbyssReviveCharacterResponse = 17377,
		// Token: 0x04000870 RID: 2160
		AbyssReviveNotify = 24492,
		// Token: 0x04000871 RID: 2161
		GravityFlipUpdateTypeNotify = 29623,
		// Token: 0x04000872 RID: 2162
		ClientVersionNoMatchNotify = 16267,
		// Token: 0x04000873 RID: 2163
		SceneItemMoveSplineRequest = 28835,
		// Token: 0x04000874 RID: 2164
		SceneItemMoveSplineResponse = 24723,
		// Token: 0x04000875 RID: 2165
		RacingBetsLegMatchInfoRequest = 26734,
		// Token: 0x04000876 RID: 2166
		RacingBetsLegMatchInfoResponse = 29075,
		// Token: 0x04000877 RID: 2167
		RacingBetsMatchInfoRequest = 27743,
		// Token: 0x04000878 RID: 2168
		RacingBetsMatchInfoResponse = 27440,
		// Token: 0x04000879 RID: 2169
		RacingBetsPlayerInfoRequest = 22312,
		// Token: 0x0400087A RID: 2170
		RacingBetsPlayerInfoResponse = 21541,
		// Token: 0x0400087B RID: 2171
		RacingBetsRankRequest = 28072,
		// Token: 0x0400087C RID: 2172
		RacingBetsRankResponse = 21901,
		// Token: 0x0400087D RID: 2173
		RacingBetsGearRequest = 16270,
		// Token: 0x0400087E RID: 2174
		RacingBetsGearResponse = 29611,
		// Token: 0x0400087F RID: 2175
		RacingBetsPlayerInfoUpdateNotify = 24358,
		// Token: 0x04000880 RID: 2176
		RacingBetsTaskRequest = 26366,
		// Token: 0x04000881 RID: 2177
		RacingBetsTaskResponse = 28070,
		// Token: 0x04000882 RID: 2178
		RacingBetsTaskRewardRequest = 17938,
		// Token: 0x04000883 RID: 2179
		RacingBetMatchRoundRequest = 17145,
		// Token: 0x04000884 RID: 2180
		RacingBetMatchRoundResponse = 19125,
		// Token: 0x04000885 RID: 2181
		RacingBetsBulletScreenRequest = 21780,
		// Token: 0x04000886 RID: 2182
		RacingBetsBulletScreenResponse = 19809,
		// Token: 0x04000887 RID: 2183
		RacingBetsTaskRewardResponse = 20940,
		// Token: 0x04000888 RID: 2184
		FishingNetCabinUpdateNotify = 20945,
		// Token: 0x04000889 RID: 2185
		RogueWeeklyLastInfoRequest = 27120,
		// Token: 0x0400088A RID: 2186
		RogueWeeklyLastInfoResponse = 16590,
		// Token: 0x0400088B RID: 2187
		RacingBetsUpdateOddsRequest = 17175,
		// Token: 0x0400088C RID: 2188
		RacingBetsUpdateOddsResponse = 19078,
		// Token: 0x0400088D RID: 2189
		ExploreActivityTaskInfoNotify = 16491,
		// Token: 0x0400088E RID: 2190
		ExploreActivityTaskRewardRequest = 27918,
		// Token: 0x0400088F RID: 2191
		ExploreActivityTaskRewardResponse = 19374,
		// Token: 0x04000890 RID: 2192
		RacingBetsTaskNotify = 15994,
		// Token: 0x04000891 RID: 2193
		EntityHeadInfoNotify = 19315,
		// Token: 0x04000892 RID: 2194
		PhantomPolishRequest = 25622,
		// Token: 0x04000893 RID: 2195
		PhantomPolishResponse = 25461,
		// Token: 0x04000894 RID: 2196
		TowerDefenceSelfPassRequest = 15513,
		// Token: 0x04000895 RID: 2197
		TowerDefenceSelfPassResponse = 28825,
		// Token: 0x04000896 RID: 2198
		AbyssSelfPassRequest = 25588,
		// Token: 0x04000897 RID: 2199
		AbyssSelfPassResponse = 15039,
		// Token: 0x04000898 RID: 2200
		RogueResTalentSkillLevelRequest = 21757,
		// Token: 0x04000899 RID: 2201
		RogueResTalentSkillLevelResponse = 15004,
		// Token: 0x0400089A RID: 2202
		RogueResTalentUnlockNotify = 24327,
		// Token: 0x0400089B RID: 2203
		RogueResEndingUpdateNotify = 16750,
		// Token: 0x0400089C RID: 2204
		RogueResEndingRewardRequest = 28009,
		// Token: 0x0400089D RID: 2205
		RogueResEndingRewardResponse = 17493,
		// Token: 0x0400089E RID: 2206
		RogueResTaskUpdateNotify = 24660,
		// Token: 0x0400089F RID: 2207
		RogueResIllustrationUpdateNotify = 24683,
		// Token: 0x040008A0 RID: 2208
		RogueResTaskAwardRequest = 24834,
		// Token: 0x040008A1 RID: 2209
		RogueResTaskAwardResponse = 29739,
		// Token: 0x040008A2 RID: 2210
		RogueResIllustrationAwardRequest = 19081,
		// Token: 0x040008A3 RID: 2211
		RogueResIllustrationAwardResponse = 24417,
		// Token: 0x040008A4 RID: 2212
		BabelActivityInstInfoNotify = 17488,
		// Token: 0x040008A5 RID: 2213
		MoveSplineStatusNotify = 17431,
		// Token: 0x040008A6 RID: 2214
		AbyssRoleAddNotify = 23255,
		// Token: 0x040008A7 RID: 2215
		AbyssPluginItemAddNotify = 15136,
		// Token: 0x040008A8 RID: 2216
		AbyssPluginItemRemoveNotify = 25037,
		// Token: 0x040008A9 RID: 2217
		AvignonRewardRequest = 16650,
		// Token: 0x040008AA RID: 2218
		AvignonRewardResponse = 26226,
		// Token: 0x040008AB RID: 2219
		AvignonTaskNotify = 21154,
		// Token: 0x040008AC RID: 2220
		RogueResMoveRequest = 26615,
		// Token: 0x040008AD RID: 2221
		RogueResMoveResponse = 15952,
		// Token: 0x040008AE RID: 2222
		RogueResGridEventRequest = 16464,
		// Token: 0x040008AF RID: 2223
		RogueResGridEventResponse = 28230,
		// Token: 0x040008B0 RID: 2224
		RogueResOpDataNotify = 27709,
		// Token: 0x040008B1 RID: 2225
		RogueResOpDoneRequest = 27894,
		// Token: 0x040008B2 RID: 2226
		RogueResOpDoneResponse = 16584,
		// Token: 0x040008B3 RID: 2227
		RogueResInstOptionsNotify = 16744,
		// Token: 0x040008B4 RID: 2228
		RogueResInstStartRequest = 21018,
		// Token: 0x040008B5 RID: 2229
		RogueResInstStartResponse = 29103,
		// Token: 0x040008B6 RID: 2230
		RogueResInstResultRequest = 22518,
		// Token: 0x040008B7 RID: 2231
		RogueResLastInstInfoRequest = 29790,
		// Token: 0x040008B8 RID: 2232
		RogueResLastInstInfoResponse = 18335,
		// Token: 0x040008B9 RID: 2233
		DebugFightErrInfoNotify = 28626,
		// Token: 0x040008BA RID: 2234
		ActionFinishImmediatelyNotify = 24609,
		// Token: 0x040008BB RID: 2235
		BeforeHitPush = 21161,
		// Token: 0x040008BC RID: 2236
		RacingBetsGearRefundRequest = 22909,
		// Token: 0x040008BD RID: 2237
		RacingBetsGearRefundResponse = 17259,
		// Token: 0x040008BE RID: 2238
		SummonRandomRequest = 19590,
		// Token: 0x040008BF RID: 2239
		SummonRandomResponse = 17070,
		// Token: 0x040008C0 RID: 2240
		SummonRandomNotify = 28895,
		// Token: 0x040008C1 RID: 2241
		RogueResInstResultResponse = 28357,
		// Token: 0x040008C2 RID: 2242
		BabelActivityItemNumUpdateNotify = 28082,
		// Token: 0x040008C3 RID: 2243
		StopMoveSplineRequest = 28704,
		// Token: 0x040008C4 RID: 2244
		StopMoveSplineResponse = 24675,
		// Token: 0x040008C5 RID: 2245
		H5CircumFluenceActivityDataNotify = 16402,
		// Token: 0x040008C6 RID: 2246
		RoleFlyEquipNotify = 21114,
		// Token: 0x040008C7 RID: 2247
		FlySkinWearRequest = 22343,
		// Token: 0x040008C8 RID: 2248
		FlySkinWearResponse = 25179,
		// Token: 0x040008C9 RID: 2249
		FlySkinWearAllRoleRequest = 17655,
		// Token: 0x040008CA RID: 2250
		FlySkinWearAllRoleResponse = 15632,
		// Token: 0x040008CB RID: 2251
		RogueResRoomInfoNotify = 28115,
		// Token: 0x040008CC RID: 2252
		RogueResGotoNextRoomRequest = 22010,
		// Token: 0x040008CD RID: 2253
		RogueResGotoNextRoomResponse = 16110,
		// Token: 0x040008CE RID: 2254
		RacingBetsSettleNotify = 28131,
		// Token: 0x040008CF RID: 2255
		FlySkinUnLoadRequest = 22401,
		// Token: 0x040008D0 RID: 2256
		FlySkinUnLoadResponse = 29892,
		// Token: 0x040008D1 RID: 2257
		RogueResCurrencyNotify = 29934,
		// Token: 0x040008D2 RID: 2258
		RogueResCurrencyUpdateNotify = 20861,
		// Token: 0x040008D3 RID: 2259
		RogueResInstGlobalDataNotify = 25331,
		// Token: 0x040008D4 RID: 2260
		RogueResGridDataUpdateNotify = 28389,
		// Token: 0x040008D5 RID: 2261
		RogueResGainDataTotalNotify = 19437,
		// Token: 0x040008D6 RID: 2262
		RogueResGainDataUpdateNotify = 29404,
		// Token: 0x040008D7 RID: 2263
		DangoMonopolyDiceRequest = 19414,
		// Token: 0x040008D8 RID: 2264
		DangoMonopolyDiceResponse = 24491,
		// Token: 0x040008D9 RID: 2265
		DangoMonopolyGridRewardRequest = 22355,
		// Token: 0x040008DA RID: 2266
		DangoMonopolyGridRewardResponse = 18776,
		// Token: 0x040008DB RID: 2267
		DangoMonopolyBoardRewardRequest = 29315,
		// Token: 0x040008DC RID: 2268
		DangoMonopolyBoardRewardResponse = 26889,
		// Token: 0x040008DD RID: 2269
		DangoMonopolyTaskRewardRequest = 28152,
		// Token: 0x040008DE RID: 2270
		DangoMonopolyTaskRewardResponse = 20830,
		// Token: 0x040008DF RID: 2271
		RoleFlyEquipChangeNotify = 19754,
		// Token: 0x040008E0 RID: 2272
		AbyssReviveTimeNotify = 26847,
		// Token: 0x040008E1 RID: 2273
		RacingBetMatchRequest = 27478,
		// Token: 0x040008E2 RID: 2274
		RacingBetMatchResponse = 18394,
		// Token: 0x040008E3 RID: 2275
		DangoMonopolyTaskUpdateNotify = 22180,
		// Token: 0x040008E4 RID: 2276
		RogueResPlayerStatusUpdateNotify = 23230,
		// Token: 0x040008E5 RID: 2277
		RogueResFovUpdateNotify = 17242,
		// Token: 0x040008E6 RID: 2278
		RogueResMoodUpdateNotify = 26318,
		// Token: 0x040008E7 RID: 2279
		LoadingLevelAreaRequest = 15203,
		// Token: 0x040008E8 RID: 2280
		LoadingLevelAreaResponse = 20507,
		// Token: 0x040008E9 RID: 2281
		DangoMonopolySceneGridInfoNotify = 23339,
		// Token: 0x040008EA RID: 2282
		RogueResOpDataUpdateNotify = 29300,
		// Token: 0x040008EB RID: 2283
		DangoMonopolyNextBoardRequest = 19220,
		// Token: 0x040008EC RID: 2284
		DangoMonopolyNextBoardResponse = 18128,
		// Token: 0x040008ED RID: 2285
		EntityFlyEquipChangeNotify = 16196,
		// Token: 0x040008EE RID: 2286
		FlyEquipAddNotify = 21836,
		// Token: 0x040008EF RID: 2287
		NewLinkNotify = 21875,
		// Token: 0x040008F0 RID: 2288
		NewLinkBurstPush = 28450,
		// Token: 0x040008F1 RID: 2289
		AddChapterResultRequest = 28807,
		// Token: 0x040008F2 RID: 2290
		AddChapterResultResponse = 19681,
		// Token: 0x040008F3 RID: 2291
		ChapterResultRewardRequest = 24597,
		// Token: 0x040008F4 RID: 2292
		ChapterResultRewardResponse = 15304,
		// Token: 0x040008F5 RID: 2293
		InspirationUnlockChoiceRequest = 19608,
		// Token: 0x040008F6 RID: 2294
		InspirationUnlockChoiceResponse = 23610,
		// Token: 0x040008F7 RID: 2295
		ActivityResultRewardRequest = 19569,
		// Token: 0x040008F8 RID: 2296
		ActivityResultRewardResponse = 18003,
		// Token: 0x040008F9 RID: 2297
		ScheduleRewardRequest = 15291,
		// Token: 0x040008FA RID: 2298
		ScheduleRewardResponse = 24763,
		// Token: 0x040008FB RID: 2299
		ChapterUpdateNotify = 25234,
		// Token: 0x040008FC RID: 2300
		InspirationUpdateNotify = 20356,
		// Token: 0x040008FD RID: 2301
		ScheduleRewardUpdateNotify = 18703,
		// Token: 0x040008FE RID: 2302
		FlySkinAllUnLoadRequest = 17171,
		// Token: 0x040008FF RID: 2303
		FlySkinAllUnLoadResponse = 25150,
		// Token: 0x04000900 RID: 2304
		ActivityResultUpdateNotify = 22938,
		// Token: 0x04000901 RID: 2305
		CiacconaActivityStateUnlockUpdateNotify = 17332,
		// Token: 0x04000902 RID: 2306
		RogueResInstOptionsUpdateNotify = 28509,
		// Token: 0x04000903 RID: 2307
		RogueResElementUpdateNotify = 27121,
		// Token: 0x04000904 RID: 2308
		RacingBetLegMatchResultNotify = 29552,
		// Token: 0x04000905 RID: 2309
		RogueResTeamLevelUpdateNotify = 18322,
		// Token: 0x04000906 RID: 2310
		RogueResChangeFormationRequest = 24365,
		// Token: 0x04000907 RID: 2311
		RogueResChangeFormationResponse = 23844,
		// Token: 0x04000908 RID: 2312
		RegressBonusRequest = 27943,
		// Token: 0x04000909 RID: 2313
		RegressBonusResponse = 23806,
		// Token: 0x0400090A RID: 2314
		RegressTaskRequest = 17178,
		// Token: 0x0400090B RID: 2315
		RegressTaskResponse = 29284,
		// Token: 0x0400090C RID: 2316
		ConfirmQuestResourceRequest = 23000,
		// Token: 0x0400090D RID: 2317
		ConfirmQuestResourceResponse = 24175,
		// Token: 0x0400090E RID: 2318
		ConfirmResourceQuestNotify = 18602,
		// Token: 0x0400090F RID: 2319
		WaitQuestConfirmResourceNotify = 29463,
		// Token: 0x04000910 RID: 2320
		ConsumptiveRewardRequest = 26335,
		// Token: 0x04000911 RID: 2321
		ConsumptiveRewardResponse = 25276,
		// Token: 0x04000912 RID: 2322
		LinkageRewardRequest = 25785,
		// Token: 0x04000913 RID: 2323
		LinkageRewardResponse = 23303,
		// Token: 0x04000914 RID: 2324
		RacingBetMatchActionRequest = 19065,
		// Token: 0x04000915 RID: 2325
		RacingBetMatchActionResponse = 23348,
		// Token: 0x04000916 RID: 2326
		RacingBetMatchRoundActionRequest = 16403,
		// Token: 0x04000917 RID: 2327
		RacingBetMatchRoundActionResponse = 24685,
		// Token: 0x04000918 RID: 2328
		DetectionInvisibleNotify = 15166,
		// Token: 0x04000919 RID: 2329
		PlayerGravityUpdateNotify = 23394,
		// Token: 0x0400091A RID: 2330
		DangoMonopolyTaskAddNotify = 18048,
		// Token: 0x0400091B RID: 2331
		DangoMonopolyTaskRemoveNotify = 22199,
		// Token: 0x0400091C RID: 2332
		RogueResSwitchFormationRequest = 27031,
		// Token: 0x0400091D RID: 2333
		RogueResSwitchFormationResponse = 22098,
		// Token: 0x0400091E RID: 2334
		RogueResRoleBondUpdateNotify = 21609,
		// Token: 0x0400091F RID: 2335
		RacingBetMatchInfoRequest = 23216,
		// Token: 0x04000920 RID: 2336
		RacingBetMatchInfoResponse = 23023,
		// Token: 0x04000921 RID: 2337
		RogueResTotalShopItemUpdateNotify = 29902,
		// Token: 0x04000922 RID: 2338
		SystemMarkHideInfoNotify = 19492,
		// Token: 0x04000923 RID: 2339
		PhantomBattleChallengeInfoUpdateNotify = 17529,
		// Token: 0x04000924 RID: 2340
		PhantomBattleTaskInfoNotify = 29022,
		// Token: 0x04000925 RID: 2341
		PhantomBattleTaskRewardRequest = 22908,
		// Token: 0x04000926 RID: 2342
		PhantomBattleTaskRewardResponse = 27700,
		// Token: 0x04000927 RID: 2343
		PhantomBattleMasterInfoNotify = 21654,
		// Token: 0x04000928 RID: 2344
		PhantomBattleMasterLevelRewardRequest = 25661,
		// Token: 0x04000929 RID: 2345
		PhantomBattleMasterLevelRewardResponse = 22561,
		// Token: 0x0400092A RID: 2346
		PhantomBattleBadgeInfoUpdateNotify = 20719,
		// Token: 0x0400092B RID: 2347
		PhantomBattleBadgeRewardInfoUpdateNotify = 20290,
		// Token: 0x0400092C RID: 2348
		PhantomBattleBadgeRewardRequest = 22984,
		// Token: 0x0400092D RID: 2349
		PhantomBattleBadgeRewardResponse = 24270,
		// Token: 0x0400092E RID: 2350
		PhantomBattleCardInfoUpdateNotify = 26022,
		// Token: 0x0400092F RID: 2351
		PhantomBattleCardOutLookUpRequest = 21176,
		// Token: 0x04000930 RID: 2352
		PhantomBattleCardOutLookUpResponse = 28304,
		// Token: 0x04000931 RID: 2353
		PhantomBattleCardRewardInfoUpdateNotify = 18519,
		// Token: 0x04000932 RID: 2354
		PhantomBattleCardRewardRequest = 24305,
		// Token: 0x04000933 RID: 2355
		PhantomBattleCardRewardResponse = 25254,
		// Token: 0x04000934 RID: 2356
		PhantomBattleRoleInfoUpdateNotify = 20429,
		// Token: 0x04000935 RID: 2357
		PhantomBattleRoleRewardRequest = 29748,
		// Token: 0x04000936 RID: 2358
		PhantomBattleRoleRewardResponse = 26978,
		// Token: 0x04000937 RID: 2359
		PhantomBattleCardGroupInfoNotify = 17347,
		// Token: 0x04000938 RID: 2360
		PhantomBattleCardGroupAddRequest = 16307,
		// Token: 0x04000939 RID: 2361
		PhantomBattleCardGroupAddResponse = 16063,
		// Token: 0x0400093A RID: 2362
		PhantomBattleCardGroupUpdateRequest = 21338,
		// Token: 0x0400093B RID: 2363
		PhantomBattleCardGroupUpdateResponse = 19388,
		// Token: 0x0400093C RID: 2364
		PhantomBattleCardGroupNameRequest = 18469,
		// Token: 0x0400093D RID: 2365
		PhantomBattleCardGroupNameResponse = 26141,
		// Token: 0x0400093E RID: 2366
		PhantomBattleBoardInfoNotify = 18147,
		// Token: 0x0400093F RID: 2367
		PhantomBattleHandCardInfoUpdateNotify = 28224,
		// Token: 0x04000940 RID: 2368
		PhantomBattleDealCardNotify = 15397,
		// Token: 0x04000941 RID: 2369
		PhantomBattleDealCardReplaceNotify = 23835,
		// Token: 0x04000942 RID: 2370
		PhantomBattleDealCardReplaceRequest = 19834,
		// Token: 0x04000943 RID: 2371
		PhantomBattleDealCardReplaceResponse = 29228,
		// Token: 0x04000944 RID: 2372
		PhantomBattleEnterSlotRequest = 21374,
		// Token: 0x04000945 RID: 2373
		PhantomBattleEnterSlotResponse = 16311,
		// Token: 0x04000946 RID: 2374
		PhantomBattleEvolveRequest = 20873,
		// Token: 0x04000947 RID: 2375
		PhantomBattleEvolveResponse = 20416,
		// Token: 0x04000948 RID: 2376
		PhantomBattleBackLibraryRequest = 22264,
		// Token: 0x04000949 RID: 2377
		PhantomBattleBackLibraryResponse = 15743,
		// Token: 0x0400094A RID: 2378
		PhantomBattleRoundOverRequest = 22166,
		// Token: 0x0400094B RID: 2379
		PhantomBattleRoundOverResponse = 18522,
		// Token: 0x0400094C RID: 2380
		PhantomBattleSlotInsteadRequest = 28150,
		// Token: 0x0400094D RID: 2381
		PhantomBattleSlotInsteadResponse = 17240,
		// Token: 0x0400094E RID: 2382
		PhantomBattleRoundChangeNotify = 19265,
		// Token: 0x0400094F RID: 2383
		BirthDayCardRoleRequest = 24371,
		// Token: 0x04000950 RID: 2384
		BirthDayCardRoleResponse = 22249,
		// Token: 0x04000951 RID: 2385
		BirthDayRewardRequest = 17381,
		// Token: 0x04000952 RID: 2386
		BirthDayRewardResponse = 22398,
		// Token: 0x04000953 RID: 2387
		BirthDayInfoNotify = 20525,
		// Token: 0x04000954 RID: 2388
		EntityRewardItemNotify = 29972,
		// Token: 0x04000955 RID: 2389
		DangoMonopolyRewardNotify = 18485,
		// Token: 0x04000956 RID: 2390
		ApplyBuffFailedNotify = 19969,
		// Token: 0x04000957 RID: 2391
		ConsumptiveTaskInfoNotify = 22181,
		// Token: 0x04000958 RID: 2392
		TemplateEntitySpawnerContentNotify = 18989,
		// Token: 0x04000959 RID: 2393
		DirectTrainInfoRequest = 29272,
		// Token: 0x0400095A RID: 2394
		DirectTrainInfoResponse = 19087,
		// Token: 0x0400095B RID: 2395
		RegressQuestionOpenRequest = 21964,
		// Token: 0x0400095C RID: 2396
		RegressQuestionOpenResponse = 22169,
		// Token: 0x0400095D RID: 2397
		NpcPhantomBattleFightInfoNotify = 21331,
		// Token: 0x0400095E RID: 2398
		PhantomBattleDeployNotify = 25628,
		// Token: 0x0400095F RID: 2399
		PhantomBattleGamerStatusInfoNotify = 22067,
		// Token: 0x04000960 RID: 2400
		PhantomBattleCardAttrInfoNotify = 27398,
		// Token: 0x04000961 RID: 2401
		PhantomBattleLeaveSlotRequest = 19738,
		// Token: 0x04000962 RID: 2402
		PhantomBattleLeaveSlotResponse = 25415,
		// Token: 0x04000963 RID: 2403
		PhantomBattleSelectTargetEffectNotify = 21545,
		// Token: 0x04000964 RID: 2404
		PhantomBattleSelectTargetRequest = 20698,
		// Token: 0x04000965 RID: 2405
		PhantomBattleSelectTargetResponse = 24690,
		// Token: 0x04000966 RID: 2406
		PhantomBattleSkillTriggerInfoNotify = 29886,
		// Token: 0x04000967 RID: 2407
		PhantomBattleBuffTriggerInfoNotify = 21641,
		// Token: 0x04000968 RID: 2408
		ConsumptiveActivityInfoRequest = 24785,
		// Token: 0x04000969 RID: 2409
		ConsumptiveActivityInfoResponse = 18014,
		// Token: 0x0400096A RID: 2410
		PhantomBattleCardRoleSkillRequest = 16984,
		// Token: 0x0400096B RID: 2411
		PhantomBattleCardRoleSkillResponse = 18955,
		// Token: 0x0400096C RID: 2412
		PhantomBattleCardSkillRequest = 19909,
		// Token: 0x0400096D RID: 2413
		PhantomBattleCardSkillResponse = 26492,
		// Token: 0x0400096E RID: 2414
		InstSaveDataNotify = 21061,
		// Token: 0x0400096F RID: 2415
		RogueResMoodRangeUpdateNotify = 19251,
		// Token: 0x04000970 RID: 2416
		MoraleInfoNotify = 21439,
		// Token: 0x04000971 RID: 2417
		SetQuestFocusModeRequest = 16174,
		// Token: 0x04000972 RID: 2418
		SetQuestFocusModeResponse = 22593,
		// Token: 0x04000973 RID: 2419
		CancelQuestFocusModeRequest = 15853,
		// Token: 0x04000974 RID: 2420
		CancelQuestFocusModeResponse = 28253,
		// Token: 0x04000975 RID: 2421
		QuestFocusInfoNotify = 16030,
		// Token: 0x04000976 RID: 2422
		PhantomBattleNpcShowOverRequest = 29519,
		// Token: 0x04000977 RID: 2423
		PhantomBattleNpcShowOverResponse = 15620,
		// Token: 0x04000978 RID: 2424
		PhantomBattleBvBLoadingNotify = 21837,
		// Token: 0x04000979 RID: 2425
		PhantomBattleBvBLoadingFinishRequest = 20661,
		// Token: 0x0400097A RID: 2426
		PhantomBattleBvBLoadingFinishResponse = 29345,
		// Token: 0x0400097B RID: 2427
		PhantomBattleBvBFightNotify = 19494,
		// Token: 0x0400097C RID: 2428
		PhantomBattleBvBSettleNotify = 21619,
		// Token: 0x0400097D RID: 2429
		PhantomBattleStartRequest = 18864,
		// Token: 0x0400097E RID: 2430
		PhantomBattleStartResponse = 26552,
		// Token: 0x0400097F RID: 2431
		DirectTrainPreOpenCloseNotify = 24510,
		// Token: 0x04000980 RID: 2432
		PhantomBattleBoardSettleNotify = 19126,
		// Token: 0x04000981 RID: 2433
		DebugDrawPosNotify = 20580,
		// Token: 0x04000982 RID: 2434
		RacingBetLegMatchSettleNotify = 27991,
		// Token: 0x04000983 RID: 2435
		PhantomBattleAddBuffInfoNotify = 22993,
		// Token: 0x04000984 RID: 2436
		DirectTrainInfoNotify = 28851,
		// Token: 0x04000985 RID: 2437
		AcceptFocusWaitQuestRequest = 25258,
		// Token: 0x04000986 RID: 2438
		AcceptFocusWaitQuestResponse = 23033,
		// Token: 0x04000987 RID: 2439
		PhantomBattleDiscardCardNotify = 27588,
		// Token: 0x04000988 RID: 2440
		PhantomBattleDiscardCardRequest = 16286,
		// Token: 0x04000989 RID: 2441
		PhantomBattleDiscardCardResponse = 25508,
		// Token: 0x0400098A RID: 2442
		NavigationFindPathRequest = 27225,
		// Token: 0x0400098B RID: 2443
		NavigationFindPathResponse = 27703,
		// Token: 0x0400098C RID: 2444
		PhantomBattleFourCTaskInfoUpdateNotify = 26498,
		// Token: 0x0400098D RID: 2445
		PhantomBattleFourCTaskDealCardNotify = 20251,
		// Token: 0x0400098E RID: 2446
		PhantomBattleCardGroupDeleteRequest = 16154,
		// Token: 0x0400098F RID: 2447
		PhantomBattleCardGroupDeleteResponse = 25229,
		// Token: 0x04000990 RID: 2448
		SlashAndTowerOverNotify = 17309,
		// Token: 0x04000991 RID: 2449
		QuestReviewInfoNotify = 25208,
		// Token: 0x04000992 RID: 2450
		QuestReviewInfoRequest = 23616,
		// Token: 0x04000993 RID: 2451
		QuestReviewInfoResponse = 25121,
		// Token: 0x04000994 RID: 2452
		RefreshBuffDurationPush = 24982,
		// Token: 0x04000995 RID: 2453
		NewbieCarnivalSwitchRoleRequest = 26924,
		// Token: 0x04000996 RID: 2454
		NewbieCarnivalSwitchRoleResponse = 27062,
		// Token: 0x04000997 RID: 2455
		NewbieCarnivalTaskDataUpdateNotify = 23985,
		// Token: 0x04000998 RID: 2456
		NewbieCarnivalAwardRequest = 27569,
		// Token: 0x04000999 RID: 2457
		NewbieCarnivalAwardResponse = 19176,
		// Token: 0x0400099A RID: 2458
		PhantomBattleCardSelectRequest = 16151,
		// Token: 0x0400099B RID: 2459
		PhantomBattleCardSelectResponse = 19276,
		// Token: 0x0400099C RID: 2460
		PhantomBattleCardTargetInfoRequest = 22368,
		// Token: 0x0400099D RID: 2461
		PhantomBattleCardTargetInfoResponse = 17636,
		// Token: 0x0400099E RID: 2462
		PhantomBattleCardRoleTargetInfoRequest = 29346,
		// Token: 0x0400099F RID: 2463
		PhantomBattleCardRoleTargetInfoResponse = 20116,
		// Token: 0x040009A0 RID: 2464
		TimeLockInfoNotify = 16370,
		// Token: 0x040009A1 RID: 2465
		PhantomBattleCardUnlockRequest = 19404,
		// Token: 0x040009A2 RID: 2466
		PhantomBattleCardUnlockResponse = 23550,
		// Token: 0x040009A3 RID: 2467
		PhantomBattleCardUpdateNotify = 15912,
		// Token: 0x040009A4 RID: 2468
		OccupyRewardRequest = 18660,
		// Token: 0x040009A5 RID: 2469
		OccupyRewardResponse = 24387,
		// Token: 0x040009A6 RID: 2470
		SetQuestResourceStateRequest = 23014,
		// Token: 0x040009A7 RID: 2471
		SetQuestResourceStateResponse = 27184,
		// Token: 0x040009A8 RID: 2472
		NewbieCarnivalTaskJumpUpdateNotify = 26302,
		// Token: 0x040009A9 RID: 2473
		StartSetQuestFocusNotify = 28873,
		// Token: 0x040009AA RID: 2474
		PhantomBattleCardPosChangeNotify = 23839,
		// Token: 0x040009AB RID: 2475
		RogueResFormationUpdateNotify = 28455,
		// Token: 0x040009AC RID: 2476
		LongShanScoreRewardRequest = 15312,
		// Token: 0x040009AD RID: 2477
		LongShanScoreRewardResponse = 29191,
		// Token: 0x040009AE RID: 2478
		BathChangeCameraRequest = 23750,
		// Token: 0x040009AF RID: 2479
		BathChangeCameraResponse = 21598,
		// Token: 0x040009B0 RID: 2480
		BathPhotoRequest = 23123,
		// Token: 0x040009B1 RID: 2481
		BathPhotoResponse = 16666,
		// Token: 0x040009B2 RID: 2482
		PhantomBattleChallengeUpdateNotify = 27137,
		// Token: 0x040009B3 RID: 2483
		FinishDownloadQuestResourceRequest = 21668,
		// Token: 0x040009B4 RID: 2484
		FinishDownloadQuestResourceResponse = 19405,
		// Token: 0x040009B5 RID: 2485
		PhantomBattleBackSlotCardLibraryRequest = 18589,
		// Token: 0x040009B6 RID: 2486
		PhantomBattleBackSlotCardLibraryResponse = 24521,
		// Token: 0x040009B7 RID: 2487
		FloroRanchUnlockTechPointRequest = 23148,
		// Token: 0x040009B8 RID: 2488
		FloroRanchUnlockTechPointResponse = 18079,
		// Token: 0x040009B9 RID: 2489
		FloroRanchRewardTaskRequest = 27434,
		// Token: 0x040009BA RID: 2490
		FloroRanchRewardTaskResponse = 24696,
		// Token: 0x040009BB RID: 2491
		FloroRanchRewardMilestoneRequest = 25505,
		// Token: 0x040009BC RID: 2492
		FloroRanchRewardMilestoneResponse = 24536,
		// Token: 0x040009BD RID: 2493
		FloroRanchStartPlayRequest = 25857,
		// Token: 0x040009BE RID: 2494
		FloroRanchStartPlayResponse = 23655,
		// Token: 0x040009BF RID: 2495
		FloroRanchSettleRequest = 22514,
		// Token: 0x040009C0 RID: 2496
		FloroRanchSettleResponse = 29820,
		// Token: 0x040009C1 RID: 2497
		FloroRanchPlayNextDayRequest = 20630,
		// Token: 0x040009C2 RID: 2498
		FloroRanchPlayNextDayResponse = 26348,
		// Token: 0x040009C3 RID: 2499
		FloroRanchPlayGachaRequest = 18280,
		// Token: 0x040009C4 RID: 2500
		FloroRanchPlayGachaResponse = 26388,
		// Token: 0x040009C5 RID: 2501
		FloroRanchPlayShopBuyRequest = 23342,
		// Token: 0x040009C6 RID: 2502
		FloroRanchPlayShopBuyResponse = 15480,
		// Token: 0x040009C7 RID: 2503
		FloroRanchPlayEventChoiceRequest = 22212,
		// Token: 0x040009C8 RID: 2504
		FloroRanchPlayEventChoiceResponse = 21433,
		// Token: 0x040009C9 RID: 2505
		FloroRanchPlayTributeRequest = 21163,
		// Token: 0x040009CA RID: 2506
		FloroRanchPlayTributeResponse = 27951,
		// Token: 0x040009CB RID: 2507
		FloroRanchPlayUnlimitedModeRequest = 25585,
		// Token: 0x040009CC RID: 2508
		FloroRanchPlayUnlimitedModeResponse = 20504,
		// Token: 0x040009CD RID: 2509
		FloroRanchUpdatePlayerInfoNotify = 23957,
		// Token: 0x040009CE RID: 2510
		KcpConvRequest = 3728,
		// Token: 0x040009CF RID: 2511
		KcpConvResponse,
		// Token: 0x040009D0 RID: 2512
		ActionOperationScreenNotify = 16381,
		// Token: 0x040009D1 RID: 2513
		ActionOperationScreenSuccessRequest = 15213,
		// Token: 0x040009D2 RID: 2514
		ActionOperationScreenSuccessResponse = 28397,
		// Token: 0x040009D3 RID: 2515
		PhantomBattleSelectReserveCardNotify = 19284,
		// Token: 0x040009D4 RID: 2516
		PhantomBattleSelectReserveCardRequest = 22146,
		// Token: 0x040009D5 RID: 2517
		PhantomBattleSelectReserveCardResponse = 27073,
		// Token: 0x040009D6 RID: 2518
		FloroRanchPlayRemoveUnitRequest = 24002,
		// Token: 0x040009D7 RID: 2519
		FloroRanchPlayRemoveUnitResponse = 16556,
		// Token: 0x040009D8 RID: 2520
		PhantomBattleSlotCardSkillRequest = 26717,
		// Token: 0x040009D9 RID: 2521
		PhantomBattleSlotCardSkillResponse = 26700,
		// Token: 0x040009DA RID: 2522
		PhantomBattleBurnBuffNotify = 18581,
		// Token: 0x040009DB RID: 2523
		ConstructTrapRequest = 17132,
		// Token: 0x040009DC RID: 2524
		ConstructTrapResponse = 23882,
		// Token: 0x040009DD RID: 2525
		DeconstructTrapRequest = 20360,
		// Token: 0x040009DE RID: 2526
		DeconstructTrapResponse = 20270,
		// Token: 0x040009DF RID: 2527
		PhantomBattleReChallengeRequest = 27585,
		// Token: 0x040009E0 RID: 2528
		PhantomBattleReChallengeResponse = 25662,
		// Token: 0x040009E1 RID: 2529
		FloroRanchPlayRefreshShopRequest = 28500,
		// Token: 0x040009E2 RID: 2530
		FloroRanchPlayRefreshShopResponse = 18191,
		// Token: 0x040009E3 RID: 2531
		FloroRanchPlayRefreshGachaRequest = 23703,
		// Token: 0x040009E4 RID: 2532
		FloroRanchPlayRefreshGachaResponse = 29452,
		// Token: 0x040009E5 RID: 2533
		PhantomBattleDebugInfoRequest = 23362,
		// Token: 0x040009E6 RID: 2534
		PhantomBattleDebugInfoResponse = 17509,
		// Token: 0x040009E7 RID: 2535
		MoralePosRequest = 17542,
		// Token: 0x040009E8 RID: 2536
		MoralePosResponse = 29731,
		// Token: 0x040009E9 RID: 2537
		SlowTimePush = 19838,
		// Token: 0x040009EA RID: 2538
		LifePointChallengeUpdateNotify = 21262,
		// Token: 0x040009EB RID: 2539
		RunTestRequest = 29128,
		// Token: 0x040009EC RID: 2540
		RunTestResponse = 22000,
		// Token: 0x040009ED RID: 2541
		PhantomSettingRequest = 24025,
		// Token: 0x040009EE RID: 2542
		PhantomSettingResponse = 29760,
		// Token: 0x040009EF RID: 2543
		TestCmdNotify = 20443,
		// Token: 0x040009F0 RID: 2544
		PhantomSettingUpdateRequest = 27251,
		// Token: 0x040009F1 RID: 2545
		PhantomSettingUpdateResponse = 25467,
		// Token: 0x040009F2 RID: 2546
		PhantomBatchOperRequest = 15779,
		// Token: 0x040009F3 RID: 2547
		PhantomBatchOperResponse = 25271,
		// Token: 0x040009F4 RID: 2548
		ShopBuyNotify = 16134,
		// Token: 0x040009F5 RID: 2549
		QuestLockInfoNotify = 17725,
		// Token: 0x040009F6 RID: 2550
		GridCellUpdateNotify = 28675,
		// Token: 0x040009F7 RID: 2551
		VehiclePlatformGetOnRequest = 21411,
		// Token: 0x040009F8 RID: 2552
		VehiclePlatformGetOnResponse = 18298,
		// Token: 0x040009F9 RID: 2553
		PolluteGridCellRequest = 21401,
		// Token: 0x040009FA RID: 2554
		PolluteGridCellResponse = 19787,
		// Token: 0x040009FB RID: 2555
		LifePointChallengeStartRequest = 17900,
		// Token: 0x040009FC RID: 2556
		LifePointChallengeStartResponse = 22206,
		// Token: 0x040009FD RID: 2557
		FloroRanchPlaySelectCardGroupRequest = 20063,
		// Token: 0x040009FE RID: 2558
		FloroRanchPlaySelectCardGroupResponse = 19257,
		// Token: 0x040009FF RID: 2559
		SimpleCombatEntityDieRequest = 24565,
		// Token: 0x04000A00 RID: 2560
		SimpleCombatEntityDieResponse = 16558,
		// Token: 0x04000A01 RID: 2561
		InteractQuestSuspendEntityNotify = 22595,
		// Token: 0x04000A02 RID: 2562
		MoraleTreasureBoxTraceRequest = 26624,
		// Token: 0x04000A03 RID: 2563
		MoraleTreasureBoxTraceResponse = 23584,
		// Token: 0x04000A04 RID: 2564
		MulAchievementReceiveRequest = 28143,
		// Token: 0x04000A05 RID: 2565
		MulAchievementReceiveResponse = 19770,
		// Token: 0x04000A06 RID: 2566
		MulRoguelikeWriteCatRewardRequest = 24493,
		// Token: 0x04000A07 RID: 2567
		MulRoguelikeWriteCatRewardResponse = 19677,
		// Token: 0x04000A08 RID: 2568
		MulRogueWeeklyRewardRequest = 16599,
		// Token: 0x04000A09 RID: 2569
		MulRogueWeeklyRewardResponse = 28198,
		// Token: 0x04000A0A RID: 2570
		MulPhantomBattleMasterLevelRewardRequest = 18455,
		// Token: 0x04000A0B RID: 2571
		MulPhantomBattleMasterLevelRewardResponse = 15639,
		// Token: 0x04000A0C RID: 2572
		MulGetAdventureRewardRequest = 21424,
		// Token: 0x04000A0D RID: 2573
		MulGetAdventureRewardResponse = 24375,
		// Token: 0x04000A0E RID: 2574
		MulCalabashLevelRewardRequest = 17463,
		// Token: 0x04000A0F RID: 2575
		MulCalabashLevelRewardResponse = 17527,
		// Token: 0x04000A10 RID: 2576
		MulExploreScoreRewardRequest = 20889,
		// Token: 0x04000A11 RID: 2577
		MulExploreScoreRewardResponse = 27486,
		// Token: 0x04000A12 RID: 2578
		MulFishingIllustratedRewardRequest = 25002,
		// Token: 0x04000A13 RID: 2579
		MulFishingIllustratedRewardResponse = 28177,
		// Token: 0x04000A14 RID: 2580
		MulMapTravelTaskRewardRequest = 22390,
		// Token: 0x04000A15 RID: 2581
		MulMapTravelTaskRewardResponse = 16436,
		// Token: 0x04000A16 RID: 2582
		FloroRanchPlayGmInfoUpdateNotify = 26408,
		// Token: 0x04000A17 RID: 2583
		FloroRanchPlayGachaRefreshRequest = 17012,
		// Token: 0x04000A18 RID: 2584
		FloroRanchPlayGachaRefreshResponse = 18822,
		// Token: 0x04000A19 RID: 2585
		ResetQuestFocusModeNotify = 25104,
		// Token: 0x04000A1A RID: 2586
		FloroRanchExecuteSkillPlayRequest = 29254,
		// Token: 0x04000A1B RID: 2587
		FloroRanchExecuteSkillPlayResponse = 28746,
		// Token: 0x04000A1C RID: 2588
		HoldHandRequest = 15637,
		// Token: 0x04000A1D RID: 2589
		HoldHandResponse = 26676,
		// Token: 0x04000A1E RID: 2590
		TrapDefensePreviewFinishRequest = 16711,
		// Token: 0x04000A1F RID: 2591
		TrapDefensePreviewFinishResponse = 26099,
		// Token: 0x04000A20 RID: 2592
		TrapDefensePreviewStartNotify = 23247,
		// Token: 0x04000A21 RID: 2593
		RoleGoDownPush = 16452,
		// Token: 0x04000A22 RID: 2594
		RoleGoDownNotify = 19940,
		// Token: 0x04000A23 RID: 2595
		FloroRanchSettleDataRequest = 23504,
		// Token: 0x04000A24 RID: 2596
		FloroRanchSettleDataResponse = 22164,
		// Token: 0x04000A25 RID: 2597
		SetFocusModeDeterCondRequest = 23749,
		// Token: 0x04000A26 RID: 2598
		SetFocusModeDeterCondResponse = 15892,
		// Token: 0x04000A27 RID: 2599
		StopHoldHandNotify = 16932,
		// Token: 0x04000A28 RID: 2600
		LowMemoryChangeSceneStartNotify = 25971,
		// Token: 0x04000A29 RID: 2601
		LowMemoryChangeSceneFinishRequest = 20606,
		// Token: 0x04000A2A RID: 2602
		LowMemoryChangeSceneFinishResponse = 18214,
		// Token: 0x04000A2B RID: 2603
		RogueWeeklyArtifactInfoRequest = 27043,
		// Token: 0x04000A2C RID: 2604
		RogueWeeklyArtifactInfoResponse = 16633,
		// Token: 0x04000A2D RID: 2605
		RogueWeeklyArtifactSelectRequest = 22776,
		// Token: 0x04000A2E RID: 2606
		RogueWeeklyArtifactSelectResponse = 17264,
		// Token: 0x04000A2F RID: 2607
		TrapDefenseRewardGainingGroupsNotify = 22298,
		// Token: 0x04000A30 RID: 2608
		TrapDefenseRefreshGainingGroupRequest = 25671,
		// Token: 0x04000A31 RID: 2609
		TrapDefenseRefreshGainingGroupResponse = 20307,
		// Token: 0x04000A32 RID: 2610
		TrapDefenseSelectGainingGroupRequest = 18252,
		// Token: 0x04000A33 RID: 2611
		TrapDefenseSelectGainingGroupResponse = 25867,
		// Token: 0x04000A34 RID: 2612
		TrapDefenseSyncGainingGroupsNotify = 25763,
		// Token: 0x04000A35 RID: 2613
		SimpleCombatEntityBuffUpdateNotify = 18273,
		// Token: 0x04000A36 RID: 2614
		TrapDefenseSystemInfoNotify = 23974,
		// Token: 0x04000A37 RID: 2615
		ItemPkgFullNotify = 15052,
		// Token: 0x04000A38 RID: 2616
		TrapDefenseChallengeUpdateNotify = 16595,
		// Token: 0x04000A39 RID: 2617
		TrapDefenseRewardUpdateNotify = 20145,
		// Token: 0x04000A3A RID: 2618
		TrapDefenseSpecialRewardUpdateNotify = 21344,
		// Token: 0x04000A3B RID: 2619
		TrapDefenseDevelopInfoUpdateNotify = 16748,
		// Token: 0x04000A3C RID: 2620
		TrapDefenseTechUpdateNotify = 29048,
		// Token: 0x04000A3D RID: 2621
		TrapDefenseTechUnlockRequest = 21102,
		// Token: 0x04000A3E RID: 2622
		TrapDefenseTechUnlockResponse = 19615,
		// Token: 0x04000A3F RID: 2623
		TrapDefenseGetRewardRequest = 24481,
		// Token: 0x04000A40 RID: 2624
		TrapDefenseGetRewardResponse = 26764,
		// Token: 0x04000A41 RID: 2625
		TrapDefenseGetSpecialRewardRequest = 18758,
		// Token: 0x04000A42 RID: 2626
		TrapDefenseGetSpecialRewardResponse = 27113,
		// Token: 0x04000A43 RID: 2627
		TrapDefenseBuildingLevelUpRequest = 18133,
		// Token: 0x04000A44 RID: 2628
		TrapDefenseBuildingLevelUpResponse = 21393,
		// Token: 0x04000A45 RID: 2629
		TrapDefenseBuildingBranchRequest = 17310,
		// Token: 0x04000A46 RID: 2630
		TrapDefenseBuildingBranchResponse = 16970,
		// Token: 0x04000A47 RID: 2631
		TrapDefenseAuxiliaryLevelUpRequest = 20936,
		// Token: 0x04000A48 RID: 2632
		TrapDefenseAuxiliaryLevelUpResponse = 24981,
		// Token: 0x04000A49 RID: 2633
		TrapDefenseAuxiliaryBranchRequest = 16263,
		// Token: 0x04000A4A RID: 2634
		TrapDefenseAuxiliaryBranchResponse = 27327,
		// Token: 0x04000A4B RID: 2635
		FunPlayChallengeInfoUpdateNotify = 28208,
		// Token: 0x04000A4C RID: 2636
		FunPlayChallengeAwardRequest = 25841,
		// Token: 0x04000A4D RID: 2637
		FunPlayChallengeAwardResponse = 24010,
		// Token: 0x04000A4E RID: 2638
		FunPlayChallengeSettleNotify = 17763,
		// Token: 0x04000A4F RID: 2639
		LevelPlayOpenRequest = 23577,
		// Token: 0x04000A50 RID: 2640
		LevelPlayOpenResponse = 15142,
		// Token: 0x04000A51 RID: 2641
		TrapDefenseChallengeResultNotify = 27045,
		// Token: 0x04000A52 RID: 2642
		TrapDefenseChallengeQuitRequest = 24031,
		// Token: 0x04000A53 RID: 2643
		TrapDefenseChallengeQuitResponse = 27534,
		// Token: 0x04000A54 RID: 2644
		TrapDefenseBuildingResetRequest = 18594,
		// Token: 0x04000A55 RID: 2645
		TrapDefenseBuildingResetResponse = 20421,
		// Token: 0x04000A56 RID: 2646
		TrapDefenseAuxiliaryResetRequest = 26508,
		// Token: 0x04000A57 RID: 2647
		TrapDefenseAuxiliaryResetResponse = 29607,
		// Token: 0x04000A58 RID: 2648
		TrapDefenseDevelopResetRequest = 21084,
		// Token: 0x04000A59 RID: 2649
		TrapDefenseDevelopResetResponse = 24446,
		// Token: 0x04000A5A RID: 2650
		ExploreEntityTraceRequest = 20228,
		// Token: 0x04000A5B RID: 2651
		ExploreEntityTraceResponse = 29477,
		// Token: 0x04000A5C RID: 2652
		CommonTouchUiSettingUpdateRequest = 21364,
		// Token: 0x04000A5D RID: 2653
		CommonTouchUiSettingUpdateResponse = 19580,
		// Token: 0x04000A5E RID: 2654
		TrapDefenseSlotUpdateRequest = 28106,
		// Token: 0x04000A5F RID: 2655
		TrapDefenseSlotUpdateResponse = 20401,
		// Token: 0x04000A60 RID: 2656
		SceneItemSequenceFrameStartResponse = 16917,
		// Token: 0x04000A61 RID: 2657
		SceneItemSequenceFrameEndRequest = 24870,
		// Token: 0x04000A62 RID: 2658
		SceneItemSequenceFrameEndResponse = 24461,
		// Token: 0x04000A63 RID: 2659
		MulMapTravelSoarRewardRequest = 19711,
		// Token: 0x04000A64 RID: 2660
		MulMapTravelSoarRewardResponse = 16779,
		// Token: 0x04000A65 RID: 2661
		TrapDefenseStepUpdateNotify = 23425,
		// Token: 0x04000A66 RID: 2662
		PhantomSettingBatchUpdateRequest = 21039,
		// Token: 0x04000A67 RID: 2663
		PhantomSettingBatchUpdateResponse = 28959,
		// Token: 0x04000A68 RID: 2664
		TrapDefenseSystemInfoUpdateNotify = 18546,
		// Token: 0x04000A69 RID: 2665
		TrapDefenseSpawnMonsterWaveEndNotify = 26815,
		// Token: 0x04000A6A RID: 2666
		TrapDefenseMonsterConsecutiveKillsNotify = 19577,
		// Token: 0x04000A6B RID: 2667
		FloroRanchFirstEnterRequest = 27487,
		// Token: 0x04000A6C RID: 2668
		FloroRanchFirstEnterResponse = 27776,
		// Token: 0x04000A6D RID: 2669
		FloroRanchAnimationRequest = 25219,
		// Token: 0x04000A6E RID: 2670
		FloroRanchAnimationResponse = 22651,
		// Token: 0x04000A6F RID: 2671
		TrapDefenseBdUpdateNotify = 15259,
		// Token: 0x04000A70 RID: 2672
		BlackSwordChallengeInfoRequest = 22114,
		// Token: 0x04000A71 RID: 2673
		BlackSwordChallengeInfoResponse = 20453,
		// Token: 0x04000A72 RID: 2674
		RoleOperateSelfBgmRequest = 19564,
		// Token: 0x04000A73 RID: 2675
		RoleOperateSelfBgmResponse = 25411,
		// Token: 0x04000A74 RID: 2676
		SimpleCombatEntitySubTypeChangeNotify = 25732,
		// Token: 0x04000A75 RID: 2677
		TrapDefenseRefreshShopRequest = 17409,
		// Token: 0x04000A76 RID: 2678
		TrapDefenseRefreshShopResponse = 29329,
		// Token: 0x04000A77 RID: 2679
		TrapDefenseBuyShopProductRequest = 17521,
		// Token: 0x04000A78 RID: 2680
		TrapDefenseBuyShopProductResponse = 29351,
		// Token: 0x04000A79 RID: 2681
		TrapDefenseEntityDataChangeNotify = 18208,
		// Token: 0x04000A7A RID: 2682
		TrapDefenseTechPointUpdateNotify = 15898,
		// Token: 0x04000A7B RID: 2683
		SceneItemSequenceFrameStartRequest = 20858,
		// Token: 0x04000A7C RID: 2684
		MoonPhaseRandomRequest = 15067,
		// Token: 0x04000A7D RID: 2685
		MoonPhaseRandomResponse = 18392,
		// Token: 0x04000A7E RID: 2686
		MoonPhaseRewardRequest = 21365,
		// Token: 0x04000A7F RID: 2687
		MoonPhaseRewardResponse = 15018,
		// Token: 0x04000A80 RID: 2688
		CommonUiSettingNotify = 16208,
		// Token: 0x04000A81 RID: 2689
		TrapDefenseItemUpdateNotify = 26436,
		// Token: 0x04000A82 RID: 2690
		TrapDefenseUseItemRequest = 16123,
		// Token: 0x04000A83 RID: 2691
		TrapDefenseUseItemResponse = 28819,
		// Token: 0x04000A84 RID: 2692
		LineCrossActivityUpdateNotify = 27261,
		// Token: 0x04000A85 RID: 2693
		LineCrossChallengeStartRequest = 26440,
		// Token: 0x04000A86 RID: 2694
		LineCrossChallengeStartResponse = 21987,
		// Token: 0x04000A87 RID: 2695
		RoleIllustratedInfoRequest = 23991,
		// Token: 0x04000A88 RID: 2696
		RoleIllustratedInfoResponse = 22483,
		// Token: 0x04000A89 RID: 2697
		TrapDefenseCurChallengeInfoRequest = 19548,
		// Token: 0x04000A8A RID: 2698
		TrapDefenseCurChallengeInfoResponse = 19452,
		// Token: 0x04000A8B RID: 2699
		TrapDefenseGainingGroupUpdateNotify = 21410,
		// Token: 0x04000A8C RID: 2700
		RoleDevelopConfigRequest = 29877,
		// Token: 0x04000A8D RID: 2701
		RoleDevelopConfigResponse = 23021,
		// Token: 0x04000A8E RID: 2702
		PhotoFightResultNotify = 17633,
		// Token: 0x04000A8F RID: 2703
		PhotoFightTaskRewardRequest = 24443,
		// Token: 0x04000A90 RID: 2704
		PhotoFightTaskRewardResponse = 20913,
		// Token: 0x04000A91 RID: 2705
		PhotoFightSettleRequest = 15995,
		// Token: 0x04000A92 RID: 2706
		PhotoFightSettleResponse = 26567,
		// Token: 0x04000A93 RID: 2707
		TrapDefenseQuickEquipRequest = 18555,
		// Token: 0x04000A94 RID: 2708
		TrapDefenseQuickEquipResponse = 20626,
		// Token: 0x04000A95 RID: 2709
		PhotoFightLevelInfoNotify = 18787,
		// Token: 0x04000A96 RID: 2710
		SimpleCombatEntityBuffLayerCountNotify = 29187,
		// Token: 0x04000A97 RID: 2711
		FloroRanchCloseTaskRequest = 20552,
		// Token: 0x04000A98 RID: 2712
		FloroRanchCloseTaskResponse = 19666,
		// Token: 0x04000A99 RID: 2713
		FsmConditionPassPush = 24334,
		// Token: 0x04000A9A RID: 2714
		EntityCalabashSkinChangeNotify = 25793,
		// Token: 0x04000A9B RID: 2715
		CalabashSkinTakeOnRequest = 27489,
		// Token: 0x04000A9C RID: 2716
		CalabashSkinTakeOnResponse = 28468,
		// Token: 0x04000A9D RID: 2717
		WuWuKujiGachaRequest = 24138,
		// Token: 0x04000A9E RID: 2718
		WuWuKujiGachaResponse = 17008,
		// Token: 0x04000A9F RID: 2719
		SurvivorsOpDataUpdateNotify = 20390,
		// Token: 0x04000AA0 RID: 2720
		SurvivorsOpDataForceChangeNotify = 20232,
		// Token: 0x04000AA1 RID: 2721
		SurvivorsGainDataUpdateNotify = 28759,
		// Token: 0x04000AA2 RID: 2722
		SurvivorsOpDoneRequest = 27513,
		// Token: 0x04000AA3 RID: 2723
		SurvivorsOpDoneResponse = 18127,
		// Token: 0x04000AA4 RID: 2724
		SurvivorsLockRequest = 19978,
		// Token: 0x04000AA5 RID: 2725
		SurvivorsLockResponse = 24428,
		// Token: 0x04000AA6 RID: 2726
		SurvivorsInstGlobalDataNotify = 28285,
		// Token: 0x04000AA7 RID: 2727
		SurvivorsStepUpdateNotify = 24499,
		// Token: 0x04000AA8 RID: 2728
		QuestTreeInfoRequest = 15519,
		// Token: 0x04000AA9 RID: 2729
		QuestTreeInfoResponse = 15945,
		// Token: 0x04000AAA RID: 2730
		QuestTreeInfoNotify = 24869,
		// Token: 0x04000AAB RID: 2731
		LoadCalabashSkinInfoRequest = 20817,
		// Token: 0x04000AAC RID: 2732
		LoadCalabashSkinInfoResponse = 18646,
		// Token: 0x04000AAD RID: 2733
		CalabashSkinTakeOnNotify = 22784,
		// Token: 0x04000AAE RID: 2734
		CalabashSkinUpdateNotify = 18523,
		// Token: 0x04000AAF RID: 2735
		YuXueModeInfoNotify = 19246,
		// Token: 0x04000AB0 RID: 2736
		SetPlayerYuXueModeRequest = 18715,
		// Token: 0x04000AB1 RID: 2737
		SetPlayerYuXueModeResponse = 22623,
		// Token: 0x04000AB2 RID: 2738
		SetBtObjYuXueModeRequest = 23639,
		// Token: 0x04000AB3 RID: 2739
		SetBtObjYuXueModeResponse = 23727,
		// Token: 0x04000AB4 RID: 2740
		GetYuXueModeInfoRequest = 26654,
		// Token: 0x04000AB5 RID: 2741
		GetYuXueModeInfoResponse = 17403,
		// Token: 0x04000AB6 RID: 2742
		TrapDefenseBdGroupUnlockNotify = 28407,
		// Token: 0x04000AB7 RID: 2743
		SurvivorsSpawnMonsterWaveEndNotify = 21452,
		// Token: 0x04000AB8 RID: 2744
		SurvivorsMonsterConsecutiveKillsNotify = 26546,
		// Token: 0x04000AB9 RID: 2745
		SurvivorsResultRequest = 17323,
		// Token: 0x04000ABA RID: 2746
		SurvivorsResultResponse = 24240,
		// Token: 0x04000ABB RID: 2747
		SurvivorsStepAdvanceRequest = 28159,
		// Token: 0x04000ABC RID: 2748
		SurvivorsStepAdvanceResponse = 23962,
		// Token: 0x04000ABD RID: 2749
		WeatherControlRequest = 25604,
		// Token: 0x04000ABE RID: 2750
		WeatherControlResponse = 28028,
		// Token: 0x04000ABF RID: 2751
		SurvivorsVarRecordNotify = 20648,
		// Token: 0x04000AC0 RID: 2752
		SurvivorsWeaponInfoRequest = 19901,
		// Token: 0x04000AC1 RID: 2753
		SurvivorsWeaponInfoResponse = 23080,
		// Token: 0x04000AC2 RID: 2754
		SurvivorsTaskDataUpdateNotify = 26512,
		// Token: 0x04000AC3 RID: 2755
		SurvivorsNormalAwardRequest = 25147,
		// Token: 0x04000AC4 RID: 2756
		SurvivorsNormalAwardResponse = 24955,
		// Token: 0x04000AC5 RID: 2757
		SurvivorsScoreAwardRequest = 19499,
		// Token: 0x04000AC6 RID: 2758
		SurvivorsScoreAwardResponse = 23924,
		// Token: 0x04000AC7 RID: 2759
		SurvivorsHandBooskUnlockNotify = 25363,
		// Token: 0x04000AC8 RID: 2760
		SurvivorsTalentLevelUpRequest = 24431,
		// Token: 0x04000AC9 RID: 2761
		SurvivorsTalentLevelUpResponse = 23700,
		// Token: 0x04000ACA RID: 2762
		SurvivorsTalentUnlockNotify = 26156,
		// Token: 0x04000ACB RID: 2763
		BatchSynthesisItemRequest = 19088,
		// Token: 0x04000ACC RID: 2764
		BatchSynthesisItemResponse = 26720,
		// Token: 0x04000ACD RID: 2765
		SurvivorsLastInfoRequest = 23667,
		// Token: 0x04000ACE RID: 2766
		SurvivorsLastInfoResponse = 28545,
		// Token: 0x04000ACF RID: 2767
		SurvivorsChallengeInfoUpdateNotify = 17917,
		// Token: 0x04000AD0 RID: 2768
		SimpleCombatEntitySyncAttributePush = 24434,
		// Token: 0x04000AD1 RID: 2769
		WeaponSkinUpdateNotify = 20115,
		// Token: 0x04000AD2 RID: 2770
		RoleSkinChangeNotify = 16509,
		// Token: 0x04000AD3 RID: 2771
		PlayerHeadUpdateNotify = 26848,
		// Token: 0x04000AD4 RID: 2772
		RoleUpdateDevelopTargetRequest = 29614,
		// Token: 0x04000AD5 RID: 2773
		RoleUpdateDevelopTargetResponse = 16891,
		// Token: 0x04000AD6 RID: 2774
		RoleUpdateDevelopTargetNotify = 29070,
		// Token: 0x04000AD7 RID: 2775
		MainPhantomRecommendResponse = 26732,
		// Token: 0x04000AD8 RID: 2776
		InfrInfoRequest = 21330,
		// Token: 0x04000AD9 RID: 2777
		InfrInfoResponse = 29855,
		// Token: 0x04000ADA RID: 2778
		InfrArchiveTaskRewardRequest = 18945,
		// Token: 0x04000ADB RID: 2779
		InfrArchiveTaskRewardResponse = 28194,
		// Token: 0x04000ADC RID: 2780
		InfrManualSwitchTraceRoadRequest = 20148,
		// Token: 0x04000ADD RID: 2781
		InfrManualSwitchTraceRoadResponse = 19643,
		// Token: 0x04000ADE RID: 2782
		InfrFireNoticeRequest = 29298,
		// Token: 0x04000ADF RID: 2783
		InfrFireNoticeResponse = 27191,
		// Token: 0x04000AE0 RID: 2784
		InfrFireAddNotify = 18395,
		// Token: 0x04000AE1 RID: 2785
		InfrRoadUpdateNotify = 23036,
		// Token: 0x04000AE2 RID: 2786
		CharacterMoveToPointNotify = 29143,
		// Token: 0x04000AE3 RID: 2787
		InfrFireUpdateNotify = 18262,
		// Token: 0x04000AE4 RID: 2788
		PackAnimChangedNotify = 23124,
		// Token: 0x04000AE5 RID: 2789
		MainPhantomRecommendRequest = 15154,
		// Token: 0x04000AE6 RID: 2790
		InfrLevelUpRequest = 18803,
		// Token: 0x04000AE7 RID: 2791
		InfrLevelUpResponse = 17552,
		// Token: 0x04000AE8 RID: 2792
		InfrRoadBuildRequest = 20207,
		// Token: 0x04000AE9 RID: 2793
		InfrRoadBuildResponse = 22175,
		// Token: 0x04000AEA RID: 2794
		CharacterMoveToPointEndPush = 27483,
		// Token: 0x04000AEB RID: 2795
		BlackSwordChallengeMarkItemPanelInfoRequest = 29544,
		// Token: 0x04000AEC RID: 2796
		BlackSwordChallengeMarkItemPanelInfoResponse = 19063,
		// Token: 0x04000AED RID: 2797
		RogueWeeklyInteractionResultNotify = 25625,
		// Token: 0x04000AEE RID: 2798
		HonamiStoryLimitTaskInfoUpdateNotify = 22327,
		// Token: 0x04000AEF RID: 2799
		HonamiStoryAreaTaskInfoRefreshNotify = 26269,
		// Token: 0x04000AF0 RID: 2800
		HonamiStoryAreaTaskInfoUpdateNotify = 25370,
		// Token: 0x04000AF1 RID: 2801
		HonamiStoryBagInfoUpdateNotify = 23184,
		// Token: 0x04000AF2 RID: 2802
		HonamiStoryBagOperateRequest = 19759,
		// Token: 0x04000AF3 RID: 2803
		HonamiStoryBagOperateResponse = 17717,
		// Token: 0x04000AF4 RID: 2804
		HonamiStoryRoleUpdateNotify = 17089,
		// Token: 0x04000AF5 RID: 2805
		HonamiStoryEquipRoleRequest = 21590,
		// Token: 0x04000AF6 RID: 2806
		HonamiStoryEquipRoleResponse = 27622,
		// Token: 0x04000AF7 RID: 2807
		HonamiStoryUnlockSlotRequest = 26265,
		// Token: 0x04000AF8 RID: 2808
		HonamiStoryUnlockSlotResponse = 16925,
		// Token: 0x04000AF9 RID: 2809
		HonamiStoryAddWeaponNotify = 23284,
		// Token: 0x04000AFA RID: 2810
		HonamiStoryWeaponDressRequest = 17346,
		// Token: 0x04000AFB RID: 2811
		HonamiStoryWeaponDressResponse = 26893,
		// Token: 0x04000AFC RID: 2812
		HonamiStorySellItemRequest = 16688,
		// Token: 0x04000AFD RID: 2813
		HonamiStorySellItemResponse = 15708,
		// Token: 0x04000AFE RID: 2814
		HonamiStoryLifeSupportUpRequest = 24974,
		// Token: 0x04000AFF RID: 2815
		HonamiStoryLifeSupportUpResponse = 29000,
		// Token: 0x04000B00 RID: 2816
		HonamiStoryActivateTalentRequest = 29239,
		// Token: 0x04000B01 RID: 2817
		HonamiStoryActivateTalentResponse = 16479,
		// Token: 0x04000B02 RID: 2818
		HonamiStoryItemCollectionInfoUpdateNotify = 16250,
		// Token: 0x04000B03 RID: 2819
		HonamiStoryItemCollectionRequest = 27262,
		// Token: 0x04000B04 RID: 2820
		HonamiStoryItemCollectionResponse = 17176,
		// Token: 0x04000B05 RID: 2821
		HonamiStoryMascotInfoUpdateNotify = 22035,
		// Token: 0x04000B06 RID: 2822
		HonamiStoryMascotRewardRequest = 27581,
		// Token: 0x04000B07 RID: 2823
		HonamiStoryMascotRewardResponse = 28960,
		// Token: 0x04000B08 RID: 2824
		HonamiStoryAreaInfoUpdateNotify = 15296,
		// Token: 0x04000B09 RID: 2825
		HonamiStoryAreaSecretRewardRequest = 25409,
		// Token: 0x04000B0A RID: 2826
		HonamiStoryAreaSecretRewardResponse = 21464,
		// Token: 0x04000B0B RID: 2827
		HonamiStoryLimitTaskRewardRequest = 26293,
		// Token: 0x04000B0C RID: 2828
		HonamiStoryLimitTaskRewardResponse = 20813,
		// Token: 0x04000B0D RID: 2829
		HonamiStoryScoreRewardRequest = 16084,
		// Token: 0x04000B0E RID: 2830
		HonamiStoryScoreRewardResponse = 27500,
		// Token: 0x04000B0F RID: 2831
		HonamiStoryPickUpItemRequest = 17260,
		// Token: 0x04000B10 RID: 2832
		HonamiStoryPickUpItemResponse = 19769,
		// Token: 0x04000B11 RID: 2833
		HonamiStoryDiscardItemRequest = 19973,
		// Token: 0x04000B12 RID: 2834
		HonamiStoryDiscardItemResponse = 20810,
		// Token: 0x04000B13 RID: 2835
		HonamiStoryInstInfoNotify = 17000,
		// Token: 0x04000B14 RID: 2836
		HonamiStoryPollutionUpdateNotify = 21640,
		// Token: 0x04000B15 RID: 2837
		HonamiStoryInstSettleNotify = 23167,
		// Token: 0x04000B16 RID: 2838
		HonamiStoryInstTopTowerSettleNotify = 24069,
		// Token: 0x04000B17 RID: 2839
		HonamiStoryInstLeaveRequest = 19853,
		// Token: 0x04000B18 RID: 2840
		HonamiStoryInstLeaveResponse = 23019,
		// Token: 0x04000B19 RID: 2841
		HonamiStorySafeLeaveNotify = 17990,
		// Token: 0x04000B1A RID: 2842
		HonamiStoryPollutionBoxSteadyLimitNotify = 17818,
		// Token: 0x04000B1B RID: 2843
		HonamiStoryScoreRewardInfoUpdateNotify = 18607,
		// Token: 0x04000B1C RID: 2844
		GetTraceQuestYuXueModeRequest = 27604,
		// Token: 0x04000B1D RID: 2845
		GetTraceQuestYuXueModeResponse = 20487,
		// Token: 0x04000B1E RID: 2846
		EntityHonamiStoryEnhanceLevelNotify = 16677,
		// Token: 0x04000B1F RID: 2847
		SunSpiritListNotify = 15581,
		// Token: 0x04000B20 RID: 2848
		SunSpiritCollectNotify = 27484,
		// Token: 0x04000B21 RID: 2849
		SunSpiritUpdateNotify = 28796,
		// Token: 0x04000B22 RID: 2850
		RollBlockOpenGamePlayNotify = 15482,
		// Token: 0x04000B23 RID: 2851
		RollBlockResetGamePlayRequest = 22610,
		// Token: 0x04000B24 RID: 2852
		RollBlockResetGamePlayResponse = 26645,
		// Token: 0x04000B25 RID: 2853
		RollBlockMovementFinishRequest = 25774,
		// Token: 0x04000B26 RID: 2854
		HonamiStoryLockItemRequest = 23316,
		// Token: 0x04000B27 RID: 2855
		HonamiStoryLockItemResponse = 21718,
		// Token: 0x04000B28 RID: 2856
		RollBlockCloseGamePlayNotify = 21222,
		// Token: 0x04000B29 RID: 2857
		RollBlockSyncInfoNotify = 29588,
		// Token: 0x04000B2A RID: 2858
		RollBlockMovementFinishResponse = 20004,
		// Token: 0x04000B2B RID: 2859
		MulCorniceMeetingRewardRequest = 20556,
		// Token: 0x04000B2C RID: 2860
		MulCorniceMeetingRewardResponse = 22551,
		// Token: 0x04000B2D RID: 2861
		SunSpiritActionOperationEndPush = 22214,
		// Token: 0x04000B2E RID: 2862
		HonamiStoryLimitShopConsumeNumNotify = 16893,
		// Token: 0x04000B2F RID: 2863
		BuffEffectExecutePush = 18599,
		// Token: 0x04000B30 RID: 2864
		RollBlockInputRequest = 19364,
		// Token: 0x04000B31 RID: 2865
		RollBlockInputResponse = 17349,
		// Token: 0x04000B32 RID: 2866
		SurvivorsComboParamUpdateNotify = 20928,
		// Token: 0x04000B33 RID: 2867
		SunSpiritActionOperationNotify = 15928,
		// Token: 0x04000B34 RID: 2868
		MotorTechLevelUpRequest = 27727,
		// Token: 0x04000B35 RID: 2869
		MotorTechLevelUpResponse = 15127,
		// Token: 0x04000B36 RID: 2870
		WeatherControlInfoRequest = 25430,
		// Token: 0x04000B37 RID: 2871
		WeatherControlInfoResponse = 26543,
		// Token: 0x04000B38 RID: 2872
		ButtonIsEnableRequest = 18232,
		// Token: 0x04000B39 RID: 2873
		ButtonIsEnableResponse = 25924,
		// Token: 0x04000B3A RID: 2874
		MotorLevelOneKeyRewardRequest = 15900,
		// Token: 0x04000B3B RID: 2875
		MotorLevelOneKeyRewardResponse = 17604,
		// Token: 0x04000B3C RID: 2876
		HonamiStoryBagSizeUpdateNotify = 24747,
		// Token: 0x04000B3D RID: 2877
		MotorInfoRequest = 17813,
		// Token: 0x04000B3E RID: 2878
		MotorInfoResponse = 22936,
		// Token: 0x04000B3F RID: 2879
		MotorTaskOneKeyRewardRequest = 27567,
		// Token: 0x04000B40 RID: 2880
		MotorTaskOneKeyRewardResponse = 26986,
		// Token: 0x04000B41 RID: 2881
		MotorTaskInfoNotify = 22808,
		// Token: 0x04000B42 RID: 2882
		PhantomInteractionEquipRequest = 21354,
		// Token: 0x04000B43 RID: 2883
		PhantomInteractionEquipResponse = 21997,
		// Token: 0x04000B44 RID: 2884
		PhantomInteractionSkinChangeRequest = 21448,
		// Token: 0x04000B45 RID: 2885
		PhantomInteractionSkinChangeResponse = 18194,
		// Token: 0x04000B46 RID: 2886
		PhantomInteractionInfoUpdateNotify = 29193,
		// Token: 0x04000B47 RID: 2887
		PhantomInteractionUnlockNotify = 23244,
		// Token: 0x04000B48 RID: 2888
		ChangeSceneRoadNotify = 21251,
		// Token: 0x04000B49 RID: 2889
		MotorTechTreeSwitchRequest = 25166,
		// Token: 0x04000B4A RID: 2890
		MotorTechTreeSwitchResponse = 17554,
		// Token: 0x04000B4B RID: 2891
		MotorTaskUpdateNotify = 22342,
		// Token: 0x04000B4C RID: 2892
		MotorTechUnlockNotify = 17862,
		// Token: 0x04000B4D RID: 2893
		MotorTechTreeUnlockNotify = 20699,
		// Token: 0x04000B4E RID: 2894
		MotorDataNotify = 25272,
		// Token: 0x04000B4F RID: 2895
		AreaTerminalPinOperationRequest = 21848,
		// Token: 0x04000B50 RID: 2896
		AreaTerminalPinOperationResponse = 27615,
		// Token: 0x04000B51 RID: 2897
		GetDetectionTargetRequest = 20959,
		// Token: 0x04000B52 RID: 2898
		GetDetectionTargetResponse = 24853,
		// Token: 0x04000B53 RID: 2899
		DetectionTargetChangeNotify = 15512,
		// Token: 0x04000B54 RID: 2900
		AreaTerminalInfoNotify = 19616,
		// Token: 0x04000B55 RID: 2901
		InfrThemeActivityAwardRequest = 20474,
		// Token: 0x04000B56 RID: 2902
		InfrThemeActivityAwardResponse = 21087,
		// Token: 0x04000B57 RID: 2903
		HonamiStoryTopInfoNotify = 26555,
		// Token: 0x04000B58 RID: 2904
		RbBlockStateChangeNotify = 27504,
		// Token: 0x04000B59 RID: 2905
		HonamiStorySetFormationNotify = 18653,
		// Token: 0x04000B5A RID: 2906
		MotorSliderRequest = 22317,
		// Token: 0x04000B5B RID: 2907
		MotorSliderResponse = 16957,
		// Token: 0x04000B5C RID: 2908
		VisionTriggerPush = 28446,
		// Token: 0x04000B5D RID: 2909
		VisionTriggerNotify = 24819,
		// Token: 0x04000B5E RID: 2910
		SceneBlockSplitClientLoginPush = 24812,
		// Token: 0x04000B5F RID: 2911
		SceneBlockChangePush = 18483,
		// Token: 0x04000B60 RID: 2912
		SceneBlockSplitHumanChangleNotify = 28372,
		// Token: 0x04000B61 RID: 2913
		SceneBlockSplitHumanFullNotify = 18425,
		// Token: 0x04000B62 RID: 2914
		RemoveBuffByServerIdS2cRequestNotify = 15505,
		// Token: 0x04000B63 RID: 2915
		MotorExpAddNotify = 20982,
		// Token: 0x04000B64 RID: 2916
		SceneBlockSplitHumanSwitchStateNotify = 18158,
		// Token: 0x04000B65 RID: 2917
		SceneBlockSplitSwitchStatePush = 29772,
		// Token: 0x04000B66 RID: 2918
		HonamiStoryTalentInfoUpdateNotify = 19936,
		// Token: 0x04000B67 RID: 2919
		BossRushBatchClaimRewardRequest = 27431,
		// Token: 0x04000B68 RID: 2920
		BossRushBatchClaimRewardResponse = 26097,
		// Token: 0x04000B69 RID: 2921
		PhantomBattleAreaSkillRequest = 25124,
		// Token: 0x04000B6A RID: 2922
		PhantomBattleAreaSkillResponse = 29761,
		// Token: 0x04000B6B RID: 2923
		PhantomBattleAreaSkillCdNotify = 24988,
		// Token: 0x04000B6C RID: 2924
		PhantomBattleAreaSkillNotify = 16501,
		// Token: 0x04000B6D RID: 2925
		PhantomBattlePhantomCardSkillRequest = 28104,
		// Token: 0x04000B6E RID: 2926
		PhantomBattlePhantomCardSkillResponse = 22092,
		// Token: 0x04000B6F RID: 2927
		PhantomBattleCardDurableEmptyNotify = 24020,
		// Token: 0x04000B70 RID: 2928
		ArtemisNodeUpdateNotify = 21651,
		// Token: 0x04000B71 RID: 2929
		ArtemisNodeUpdateRequest = 26355,
		// Token: 0x04000B72 RID: 2930
		ArtemisNodeUpdateResponse = 18649,
		// Token: 0x04000B73 RID: 2931
		SceneBlockSplitPopWindowNotify = 24204,
		// Token: 0x04000B74 RID: 2932
		AddDecalRequest = 29268,
		// Token: 0x04000B75 RID: 2933
		AddDecalResponse = 19752,
		// Token: 0x04000B76 RID: 2934
		DecalAddNotify = 17780,
		// Token: 0x04000B77 RID: 2935
		DecalRemoveNotify = 23152,
		// Token: 0x04000B78 RID: 2936
		RoleSceneVoiceSwitchNotify = 23430,
		// Token: 0x04000B79 RID: 2937
		CoopRoleRewardRequest = 25686,
		// Token: 0x04000B7A RID: 2938
		CoopRoleRewardResponse = 25354,
		// Token: 0x04000B7B RID: 2939
		CoopSpRewardRequest = 22261,
		// Token: 0x04000B7C RID: 2940
		CoopSpRewardResponse = 19720,
		// Token: 0x04000B7D RID: 2941
		CoopRoleInfoUpdateNotify = 27573,
		// Token: 0x04000B7E RID: 2942
		HonamiStoryResidentTaskInfoUpdateNotify = 19128,
		// Token: 0x04000B7F RID: 2943
		HonamiStoryResidentTaskRewardRequest = 27298,
		// Token: 0x04000B80 RID: 2944
		HonamiStoryResidentTaskRewardResponse = 15037,
		// Token: 0x04000B81 RID: 2945
		HonamiStoryTotalRevenueNotify = 23885,
		// Token: 0x04000B82 RID: 2946
		RollBlockExitGamePlayRequest = 28361,
		// Token: 0x04000B83 RID: 2947
		RollBlockExitGamePlayResponse = 21367,
		// Token: 0x04000B84 RID: 2948
		RollBlockToggleHintRequest = 15560,
		// Token: 0x04000B85 RID: 2949
		RollBlockToggleHintResponse = 16448,
		// Token: 0x04000B86 RID: 2950
		MotorChangeOutlookRequest = 27172,
		// Token: 0x04000B87 RID: 2951
		MotorChangeOutlookResponse = 26904,
		// Token: 0x04000B88 RID: 2952
		MotorOutlookAddNotify = 24099,
		// Token: 0x04000B89 RID: 2953
		VehicleEnterSharingRequest = 25279,
		// Token: 0x04000B8A RID: 2954
		VehicleEnterSharingResponse = 25137,
		// Token: 0x04000B8B RID: 2955
		RollBlockSwitchControlBlockRequest = 17791,
		// Token: 0x04000B8C RID: 2956
		RollBlockSwitchControlBlockResponse = 22237,
		// Token: 0x04000B8D RID: 2957
		MotorOutlookOwnedChangeNotify = 22922,
		// Token: 0x04000B8E RID: 2958
		MotorOutlookEquippedChangeNotify = 15683,
		// Token: 0x04000B8F RID: 2959
		RollBlockUpdateGamePlayNotify = 24110,
		// Token: 0x04000B90 RID: 2960
		MotorLinkTaskRequest = 23517,
		// Token: 0x04000B91 RID: 2961
		MotorLinkTaskResponse = 22394,
		// Token: 0x04000B92 RID: 2962
		MotorcycleTaskUpdateNotify = 20545,
		// Token: 0x04000B93 RID: 2963
		InstEntityTeleportRequest = 20901,
		// Token: 0x04000B94 RID: 2964
		InstEntityTeleportResponse = 25123,
		// Token: 0x04000B95 RID: 2965
		DeadeyeShootHitRequest = 15008,
		// Token: 0x04000B96 RID: 2966
		DeadeyeShootHitResponse = 21965,
		// Token: 0x04000B97 RID: 2967
		MotorUseSkinRequest = 19760,
		// Token: 0x04000B98 RID: 2968
		MotorUseSkinResponse = 22488,
		// Token: 0x04000B99 RID: 2969
		PhantomBattleCallCardNotify = 24644,
		// Token: 0x04000B9A RID: 2970
		PhantomBattleCallCardRequest = 25399,
		// Token: 0x04000B9B RID: 2971
		PhantomBattleCallCardResponse = 26502,
		// Token: 0x04000B9C RID: 2972
		EntityMotorOutlookChangeNotify = 29444,
		// Token: 0x04000B9D RID: 2973
		ShortMessageInfoRequest = 19425,
		// Token: 0x04000B9E RID: 2974
		ShortMessageInfoResponse = 17966,
		// Token: 0x04000B9F RID: 2975
		ShortMessageReadRequest = 25131,
		// Token: 0x04000BA0 RID: 2976
		ShortMessageReadResponse = 16177,
		// Token: 0x04000BA1 RID: 2977
		ShortMessageReplyRequest = 22894,
		// Token: 0x04000BA2 RID: 2978
		ShortMessageReplyResponse = 24310,
		// Token: 0x04000BA3 RID: 2979
		ShortMessageReceivedRequest = 29328,
		// Token: 0x04000BA4 RID: 2980
		ShortMessageReceivedResponse = 21328,
		// Token: 0x04000BA5 RID: 2981
		ShortMessageUpdateNotify = 23082,
		// Token: 0x04000BA6 RID: 2982
		RoadNetworkEntityUpdateCurRoadPush = 17914,
		// Token: 0x04000BA7 RID: 2983
		InfrPhoneTaskRewardRequest = 16037,
		// Token: 0x04000BA8 RID: 2984
		InfrPhoneTaskRewardResponse = 18459,
		// Token: 0x04000BA9 RID: 2985
		InfrLibraryTaskUpdateNotify = 15668,
		// Token: 0x04000BAA RID: 2986
		RoadNetworkEntityStartNavNotify = 28943,
		// Token: 0x04000BAB RID: 2987
		RollBlockResetGamePlayNotify = 26331,
		// Token: 0x04000BAC RID: 2988
		ShortMessageUpdateRequest = 22887,
		// Token: 0x04000BAD RID: 2989
		ShortMessageUpdateResponse = 19489,
		// Token: 0x04000BAE RID: 2990
		BeamCastHitPlayerRequest = 24426,
		// Token: 0x04000BAF RID: 2991
		BeamCastHitPlayerResponse = 21555,
		// Token: 0x04000BB0 RID: 2992
		CaptureBatchEntityRequest = 28951,
		// Token: 0x04000BB1 RID: 2993
		CaptureBatchEntityResponse = 25668,
		// Token: 0x04000BB2 RID: 2994
		MotorOutlookRegionInfoNotify = 17258,
		// Token: 0x04000BB3 RID: 2995
		VehicleShareNotify = 17830,
		// Token: 0x04000BB4 RID: 2996
		RoadBookInfoUpdateNotify = 20058,
		// Token: 0x04000BB5 RID: 2997
		RoadBookFullRewardRequest = 25619,
		// Token: 0x04000BB6 RID: 2998
		RoadBookFullRewardResponse = 26687,
		// Token: 0x04000BB7 RID: 2999
		RoadBookLevelUpRequest = 21349,
		// Token: 0x04000BB8 RID: 3000
		RoadBookLevelUpResponse = 19714,
		// Token: 0x04000BB9 RID: 3001
		RoadBookTaskRewardRequest = 28058,
		// Token: 0x04000BBA RID: 3002
		RoadBookTaskRewardResponse = 24523,
		// Token: 0x04000BBB RID: 3003
		RoadBookMotorRewardRequest = 19974,
		// Token: 0x04000BBC RID: 3004
		RoadBookMotorRewardResponse = 23361,
		// Token: 0x04000BBD RID: 3005
		MotorParkourLevelRewardRequest = 18192,
		// Token: 0x04000BBE RID: 3006
		MotorParkourLevelRewardResponse = 21142,
		// Token: 0x04000BBF RID: 3007
		MotorParkourLevelRewardUpdateNotify = 16941,
		// Token: 0x04000BC0 RID: 3008
		PhantomBatchPolishRequest = 17121,
		// Token: 0x04000BC1 RID: 3009
		PhantomBatchPolishResponse = 21024,
		// Token: 0x04000BC2 RID: 3010
		MotorParkourResultNotify = 25444,
		// Token: 0x04000BC3 RID: 3011
		PhantomBattleCheckCardSkillUnlockRequest = 28636,
		// Token: 0x04000BC4 RID: 3012
		PhantomBattleCheckCardSkillUnlockResponse = 22143,
		// Token: 0x04000BC5 RID: 3013
		PhantomVicePolishRequest = 21223,
		// Token: 0x04000BC6 RID: 3014
		PhantomVicePolishResponse = 25546,
		// Token: 0x04000BC7 RID: 3015
		PhantomVicePolishAckRequest = 26021,
		// Token: 0x04000BC8 RID: 3016
		PhantomVicePolishAckResponse = 22940,
		// Token: 0x04000BC9 RID: 3017
		InfrThemeActivityTaskDataUpdateNotify = 20438,
		// Token: 0x04000BCA RID: 3018
		FurnitureDiySaveRequest = 21389,
		// Token: 0x04000BCB RID: 3019
		FurnitureDiySaveResponse = 25998,
		// Token: 0x04000BCC RID: 3020
		InfrManualCancelTraceRoadRequest = 17676,
		// Token: 0x04000BCD RID: 3021
		InfrManualCancelTraceRoadResponse = 25842,
		// Token: 0x04000BCE RID: 3022
		SkinRewardRequest = 21395,
		// Token: 0x04000BCF RID: 3023
		SkinRewardResponse = 20013,
		// Token: 0x04000BD0 RID: 3024
		SkinRewardInfoUpdateNotify = 15316,
		// Token: 0x04000BD1 RID: 3025
		InfrArchiveReadRequest = 26051,
		// Token: 0x04000BD2 RID: 3026
		InfrArchiveReadResponse = 19607,
		// Token: 0x04000BD3 RID: 3027
		AtomicProcessTeleportRequest = 24800,
		// Token: 0x04000BD4 RID: 3028
		AtomicProcessTeleportResponse = 27008,
		// Token: 0x04000BD5 RID: 3029
		NewTowerCycleStartResponse = 15315,
		// Token: 0x04000BD6 RID: 3030
		NewTowerResultNotify = 23657,
		// Token: 0x04000BD7 RID: 3031
		NewTowerUpdateRecordRequest = 16212,
		// Token: 0x04000BD8 RID: 3032
		NewTowerUpdateRecordResponse = 25854,
		// Token: 0x04000BD9 RID: 3033
		NewTowerRewardRequest = 19524,
		// Token: 0x04000BDA RID: 3034
		NewTowerRewardResponse = 15099,
		// Token: 0x04000BDB RID: 3035
		MotorFightTalentUpRequest = 28481,
		// Token: 0x04000BDC RID: 3036
		MotorFightTalentUpResponse = 24183,
		// Token: 0x04000BDD RID: 3037
		MotorFightOneKeyRewardRequest = 27302,
		// Token: 0x04000BDE RID: 3038
		MotorFightOneKeyRewardResponse = 18713,
		// Token: 0x04000BDF RID: 3039
		MotorFightRankListRequest = 22743,
		// Token: 0x04000BE0 RID: 3040
		MotorFightRankListResponse = 22100,
		// Token: 0x04000BE1 RID: 3041
		MotorFightTalentTreeUpdateNotify = 21599,
		// Token: 0x04000BE2 RID: 3042
		MotorFightItemUpdateNotify = 22316,
		// Token: 0x04000BE3 RID: 3043
		MotorFightRoleUpdateNotify = 19840,
		// Token: 0x04000BE4 RID: 3044
		MotorFightLevelUpdateNotify = 26610,
		// Token: 0x04000BE5 RID: 3045
		MotorFightTaskUpdateNotify = 28108,
		// Token: 0x04000BE6 RID: 3046
		HonamiStoryLifeSupportNotify = 22572,
		// Token: 0x04000BE7 RID: 3047
		PhantomBattleGuideRewardRequest = 26718,
		// Token: 0x04000BE8 RID: 3048
		PhantomBattleGuideRewardResponse = 21038,
		// Token: 0x04000BE9 RID: 3049
		FireShopCoinNotify = 29285,
		// Token: 0x04000BEA RID: 3050
		JokerGuessStartNewRequest = 16872,
		// Token: 0x04000BEB RID: 3051
		JokerGuessStartNewResponse = 18171,
		// Token: 0x04000BEC RID: 3052
		JokerGuessPlayCardRequest = 18401,
		// Token: 0x04000BED RID: 3053
		JokerGuessPlayCardResponse = 19352,
		// Token: 0x04000BEE RID: 3054
		JokerGuessDrawCardRequest = 29650,
		// Token: 0x04000BEF RID: 3055
		JokerGuessDrawCardResponse = 27976,
		// Token: 0x04000BF0 RID: 3056
		JokerGuessUseSkillRequest = 18807,
		// Token: 0x04000BF1 RID: 3057
		JokerGuessUseSkillResponse = 28232,
		// Token: 0x04000BF2 RID: 3058
		EncircleChallengeStartRequest = 28751,
		// Token: 0x04000BF3 RID: 3059
		EncircleChallengeStartResponse = 25305,
		// Token: 0x04000BF4 RID: 3060
		EncircleChallengeCompleteRequest = 23593,
		// Token: 0x04000BF5 RID: 3061
		EncircleChallengeCompleteResponse = 23637,
		// Token: 0x04000BF6 RID: 3062
		EncircleChallengeUpdateNotify = 21412,
		// Token: 0x04000BF7 RID: 3063
		NewTowerCycleStartRequest = 16812,
		// Token: 0x04000BF8 RID: 3064
		PhantomMusicCollectUpdateRequest = 18730,
		// Token: 0x04000BF9 RID: 3065
		PhantomMusicCollectUpdateResponse = 18049,
		// Token: 0x04000BFA RID: 3066
		H5CircumFluenceActivityReadRequest = 20511,
		// Token: 0x04000BFB RID: 3067
		H5CircumFluenceActivityReadResponse = 22858,
		// Token: 0x04000BFC RID: 3068
		HookLockBatchCollectRequest = 26268,
		// Token: 0x04000BFD RID: 3069
		HookLockBatchCollectResponse = 26873,
		// Token: 0x04000BFE RID: 3070
		HookLockBatchCollectNotify = 26841,
		// Token: 0x04000BFF RID: 3071
		MotorFightSettleRequest = 15544,
		// Token: 0x04000C00 RID: 3072
		MotorFightSettleResponse = 19184,
		// Token: 0x04000C01 RID: 3073
		MotorFightLastSaveDataRequest = 16858,
		// Token: 0x04000C02 RID: 3074
		MotorFightLastSaveDataResponse = 19578,
		// Token: 0x04000C03 RID: 3075
		PhantomBattleRepeatedTaskRewardRequest = 22983,
		// Token: 0x04000C04 RID: 3076
		PhantomBattleRepeatedTaskRewardResponse = 16815,
		// Token: 0x04000C05 RID: 3077
		NewTowerUpdateRecordNotify = 28883,
		// Token: 0x04000C06 RID: 3078
		NewTowerRoleEnergyRequest = 24038,
		// Token: 0x04000C07 RID: 3079
		NewTowerRoleEnergyResponse = 25538,
		// Token: 0x04000C08 RID: 3080
		HonamiStoryActivityInfoRequest = 20790,
		// Token: 0x04000C09 RID: 3081
		HonamiStoryActivityInfoResponse = 24959,
		// Token: 0x04000C0A RID: 3082
		PhantomBatchDirectRefiningRequest = 29456,
		// Token: 0x04000C0B RID: 3083
		PhantomBatchDirectRefiningResponse = 28755,
		// Token: 0x04000C0C RID: 3084
		PhantomDirectRefiningWeeklyResetNotify = 28896,
		// Token: 0x04000C0D RID: 3085
		PilotThrowOperationRequest = 20827,
		// Token: 0x04000C0E RID: 3086
		PilotThrowOperationResponse = 28660,
		// Token: 0x04000C0F RID: 3087
		ShortMessageItemUpdateNotify = 18965,
		// Token: 0x04000C10 RID: 3088
		ShortMessageShowChangeRequest = 27855,
		// Token: 0x04000C11 RID: 3089
		ShortMessageShowChangeResponse = 27652,
		// Token: 0x04000C12 RID: 3090
		MotorBattleContextNotify = 29330,
		// Token: 0x04000C13 RID: 3091
		NewPlayerSupportRewardTaskRequest = 15421,
		// Token: 0x04000C14 RID: 3092
		NewPlayerSupportRewardTaskResponse = 25832,
		// Token: 0x04000C15 RID: 3093
		NewPlayerSupportTrialRoleLvUpRequest = 24142,
		// Token: 0x04000C16 RID: 3094
		NewPlayerSupportTrialRoleLvUpResponse = 22280,
		// Token: 0x04000C17 RID: 3095
		PhantomBattleReconstructCardNotify = 15963,
		// Token: 0x04000C18 RID: 3096
		PhantomBattleReconstructCardRequest = 26025,
		// Token: 0x04000C19 RID: 3097
		PhantomBattleReconstructCardResponse = 16661,
		// Token: 0x04000C1A RID: 3098
		RegressDisposableRewardRequest = 29911,
		// Token: 0x04000C1B RID: 3099
		RegressDisposableRewardResponse = 23423,
		// Token: 0x04000C1C RID: 3100
		ExploreSkillActionRequest = 17369,
		// Token: 0x04000C1D RID: 3101
		ExploreSkillActionResponse = 19712,
		// Token: 0x04000C1E RID: 3102
		InstTeleportToResetPointRequest = 19204,
		// Token: 0x04000C1F RID: 3103
		InstTeleportToResetPointResponse = 16034,
		// Token: 0x04000C20 RID: 3104
		RollBlockUpdateAvailableInputsNotify = 26586,
		// Token: 0x04000C21 RID: 3105
		NewTowerClearRecordRequest = 23758,
		// Token: 0x04000C22 RID: 3106
		NewTowerClearRecordResponse = 19209,
		// Token: 0x04000C23 RID: 3107
		GetLevelPlayRewardsRequest = 16467,
		// Token: 0x04000C24 RID: 3108
		GetLevelPlayRewardsResponse = 19260,
		// Token: 0x04000C25 RID: 3109
		NewPlayerSupportActivityTaskUpdateNotify = 19012,
		// Token: 0x04000C26 RID: 3110
		MotorParkourStartNotify = 27385,
		// Token: 0x04000C27 RID: 3111
		MotorOutlookInfoRequest = 16618,
		// Token: 0x04000C28 RID: 3112
		MotorOutlookInfoResponse = 18366,
		// Token: 0x04000C29 RID: 3113
		Summon3Request = 29752,
		// Token: 0x04000C2A RID: 3114
		Summon3Response = 25946,
		// Token: 0x04000C2B RID: 3115
		RegressTrialRoleUnlockNotify = 21529,
		// Token: 0x04000C2C RID: 3116
		RegressTrialRoleLvUpRequest = 16654,
		// Token: 0x04000C2D RID: 3117
		RegressTrialRoleLvUpResponse = 29813,
		// Token: 0x04000C2E RID: 3118
		GravityHookLockPointChangeGravityRequest = 27548,
		// Token: 0x04000C2F RID: 3119
		GravityHookLockPointChangeGravityResponse = 22328,
		// Token: 0x04000C30 RID: 3120
		WeatherControlUnlockNotify = 22697,
		// Token: 0x04000C31 RID: 3121
		TotalTopUpScoreInfoRequest = 18368,
		// Token: 0x04000C32 RID: 3122
		TotalTopUpScoreInfoResponse = 28081,
		// Token: 0x04000C33 RID: 3123
		TotalTopUpRewardNotify = 17958,
		// Token: 0x04000C34 RID: 3124
		TotalTopUpRewardRequest = 27942,
		// Token: 0x04000C35 RID: 3125
		TotalTopUpRewardResponse = 22019,
		// Token: 0x04000C36 RID: 3126
		SceneBlockSplitPlayerNeedBlockPush = 29579,
		// Token: 0x04000C37 RID: 3127
		NewPlayerSupportSetCurUseTrialRoleRequest = 22855,
		// Token: 0x04000C38 RID: 3128
		NewPlayerSupportSetCurUseTrialRoleResponse = 29875,
		// Token: 0x04000C39 RID: 3129
		MotorFightEnterSubLevelRequest = 28999,
		// Token: 0x04000C3A RID: 3130
		MotorFightEnterSubLevelResponse = 21543,
		// Token: 0x04000C3B RID: 3131
		MotorFightKillRequest = 24452,
		// Token: 0x04000C3C RID: 3132
		MotorFightKillResponse = 16884,
		// Token: 0x04000C3D RID: 3133
		AtomicProcessAddBuffRequest = 27678,
		// Token: 0x04000C3E RID: 3134
		AtomicProcessAddBuffResponse = 15504,
		// Token: 0x04000C3F RID: 3135
		BrochureRewardRequest = 20771,
		// Token: 0x04000C40 RID: 3136
		BrochureRewardResponse = 22634,
		// Token: 0x04000C41 RID: 3137
		BookItemUpdateNotify = 27626,
		// Token: 0x04000C42 RID: 3138
		EffectiveWeekCardInfoNotify = 22090,
		// Token: 0x04000C43 RID: 3139
		WeekCardInfoRequest = 26823,
		// Token: 0x04000C44 RID: 3140
		WeekCardInfoResponse = 16279,
		// Token: 0x04000C45 RID: 3141
		WeekCardRewardRequest = 18381,
		// Token: 0x04000C46 RID: 3142
		WeekCardRewardResponse = 15339,
		// Token: 0x04000C47 RID: 3143
		SeamlessTeleportVehicleRequest = 16695,
		// Token: 0x04000C48 RID: 3144
		SeamlessTeleportVehicleResponse = 24419,
		// Token: 0x04000C49 RID: 3145
		NewPlayerSupportActivityTrialRoleUpdateNotify = 27128,
		// Token: 0x04000C4A RID: 3146
		RegressRepeatedTaskRequest = 26659,
		// Token: 0x04000C4B RID: 3147
		RegressRepeatedTaskResponse = 26837,
		// Token: 0x04000C4C RID: 3148
		MotorCreateResponse = 16761,
		// Token: 0x04000C4D RID: 3149
		MotorCreateRequest = 29157,
		// Token: 0x04000C4E RID: 3150
		MotorFightRefreshSubLevelNotify = 22478,
		// Token: 0x04000C4F RID: 3151
		RegressBuyBonusLvRequest = 25368,
		// Token: 0x04000C50 RID: 3152
		RegressBuyBonusLvResponse = 25492,
		// Token: 0x04000C51 RID: 3153
		RegressSetCurUseTrialRoleRequest = 27245,
		// Token: 0x04000C52 RID: 3154
		RegressSetCurUseTrialRoleResponse = 26566,
		// Token: 0x04000C53 RID: 3155
		H5ViewActivityDataNotify = 28624,
		// Token: 0x04000C54 RID: 3156
		H5ViewActivityReadRequest = 22263,
		// Token: 0x04000C55 RID: 3157
		H5ViewActivityReadResponse = 15198,
		// Token: 0x04000C56 RID: 3158
		PhantomBattleSkillEffectFailNotify = 29240,
		// Token: 0x04000C57 RID: 3159
		NewTowerTaskDataUpdateNotify = 20235,
		// Token: 0x04000C58 RID: 3160
		NewTowerLevelUnlockNotify = 23956,
		// Token: 0x04000C59 RID: 3161
		RoleConfigInfoNotify = 18911,
		// Token: 0x04000C5A RID: 3162
		RoleSkillBranchModifyRequest = 26316,
		// Token: 0x04000C5B RID: 3163
		RoleSkillBranchModifyResponse = 23107,
		// Token: 0x04000C5C RID: 3164
		RoleConfigInfoUpdateNotify = 16265,
		// Token: 0x04000C5D RID: 3165
		MixDrinkSettleRequest = 28130,
		// Token: 0x04000C5E RID: 3166
		MixDrinkSettleResponse = 19105,
		// Token: 0x04000C5F RID: 3167
		MixDrinkTopicSelectRequest = 27388,
		// Token: 0x04000C60 RID: 3168
		MixDrinkTopicSelectResponse = 26371,
		// Token: 0x04000C61 RID: 3169
		SceneRoadSyncNotify = 17096,
		// Token: 0x04000C62 RID: 3170
		MotorFightPlayerDeadRequest = 22425,
		// Token: 0x04000C63 RID: 3171
		MotorFightPlayerDeadResponse = 23704,
		// Token: 0x04000C64 RID: 3172
		MotorFightGameOverNotify = 15356,
		// Token: 0x04000C65 RID: 3173
		TotalTopUpActivityInfoNotify = 24740,
		// Token: 0x04000C66 RID: 3174
		TransformBuffStackNotify = 21805,
		// Token: 0x04000C67 RID: 3175
		WeatherSwitchInfoRequest = 27924,
		// Token: 0x04000C68 RID: 3176
		WeatherSwitchInfoResponse = 27053,
		// Token: 0x04000C69 RID: 3177
		RegressActivityTrialRoleUpdateNotify = 19657,
		// Token: 0x04000C6A RID: 3178
		MotorFightRefreshNextWaveGroupRequest = 16568,
		// Token: 0x04000C6B RID: 3179
		MotorFightRefreshNextWaveGroupResponse = 27635,
		// Token: 0x04000C6C RID: 3180
		MotorFightRoundInfoNotify = 26380,
		// Token: 0x04000C6D RID: 3181
		RollBlockGamePlayReadyRequest = 26018,
		// Token: 0x04000C6E RID: 3182
		RollBlockGamePlayReadyResponse = 23212,
		// Token: 0x04000C6F RID: 3183
		MotorFightBossDropNotify = 15088,
		// Token: 0x04000C70 RID: 3184
		MotorFightSelectCollectionRequest = 19245,
		// Token: 0x04000C71 RID: 3185
		MotorFightSelectCollectionResponse = 18857,
		// Token: 0x04000C72 RID: 3186
		NewTowerRoundUpdateNotify = 23161,
		// Token: 0x04000C73 RID: 3187
		EntityEnterVehicleRequest = 27542,
		// Token: 0x04000C74 RID: 3188
		EntityEnterVehicleResponse = 25217,
		// Token: 0x04000C75 RID: 3189
		RollBlockItemUpdateNotify = 22864,
		// Token: 0x04000C76 RID: 3190
		FarmGoldLevelPlayRepeatedRequest = 21472,
		// Token: 0x04000C77 RID: 3191
		FarmGoldLevelPlayRepeatedResponse = 16947,
		// Token: 0x04000C78 RID: 3192
		MotorFightSelectBuffGateRequest = 16560,
		// Token: 0x04000C79 RID: 3193
		MotorFightSelectBuffGateResponse = 22911,
		// Token: 0x04000C7A RID: 3194
		MotorFightMonsterDropNotify = 27596,
		// Token: 0x04000C7B RID: 3195
		MotorAnimReplaySampleUdpPush = 18728,
		// Token: 0x04000C7C RID: 3196
		MotorAnimReplaySampleUdpNotify = 17840,
		// Token: 0x04000C7D RID: 3197
		SpringFestivalAreaUnlockNotify = 16024,
		// Token: 0x04000C7E RID: 3198
		GivebackInfoRequest = 15189,
		// Token: 0x04000C7F RID: 3199
		GivebackInfoResponse = 19180,
		// Token: 0x04000C80 RID: 3200
		GivebackRewardRequest = 23197,
		// Token: 0x04000C81 RID: 3201
		GivebackRewardResponse = 20769,
		// Token: 0x04000C82 RID: 3202
		GivebackInfoUpdateNotify = 27995,
		// Token: 0x04000C83 RID: 3203
		FarmGoldPointRepeatedRequest = 29763,
		// Token: 0x04000C84 RID: 3204
		FarmGoldPointRepeatedResponse = 18879,
		// Token: 0x04000C85 RID: 3205
		MotorFightScoreNotify = 18613,
		// Token: 0x04000C86 RID: 3206
		RoleDevelopConfigUpdateNotify = 25103,
		// Token: 0x04000C87 RID: 3207
		MotorLockedTechUpdateNotify = 23811,
		// Token: 0x04000C88 RID: 3208
		ActionResetPosPrePerformanceNotify = 27087,
		// Token: 0x04000C89 RID: 3209
		ActionResetPosPrePerformanceEndRequest = 19745,
		// Token: 0x04000C8A RID: 3210
		ActionResetPosPrePerformanceEndResponse = 29352,
		// Token: 0x04000C8B RID: 3211
		MotorFightRefreshCollectionRequest = 22653,
		// Token: 0x04000C8C RID: 3212
		MotorFightRefreshCollectionResponse = 18221,
		// Token: 0x04000C8D RID: 3213
		MotorIsEnablePush = 16848,
		// Token: 0x04000C8E RID: 3214
		MotorFightAddBuffNotify = 18353,
		// Token: 0x04000C8F RID: 3215
		ExhibitionItemSaveRequest = 24520,
		// Token: 0x04000C90 RID: 3216
		ExhibitionItemSaveResponse = 18661,
		// Token: 0x04000C91 RID: 3217
		SpringFestivalTaskRewardRequest = 27247,
		// Token: 0x04000C92 RID: 3218
		SpringFestivalTaskRewardResponse = 19632,
		// Token: 0x04000C93 RID: 3219
		SpringFestivalScoreRewardRequest = 17619,
		// Token: 0x04000C94 RID: 3220
		SpringFestivalScoreRewardResponse = 20918,
		// Token: 0x04000C95 RID: 3221
		LevelPlayGainRewardInfoNotify = 25358,
		// Token: 0x04000C96 RID: 3222
		SpringFestivalUpdateNotify = 16164,
		// Token: 0x04000C97 RID: 3223
		SpringFestivalAtmosphereRewardRequest = 24192,
		// Token: 0x04000C98 RID: 3224
		SpringFestivalAtmosphereRewardResponse = 17452,
		// Token: 0x04000C99 RID: 3225
		EnterBigWorldInstRequest = 17063,
		// Token: 0x04000C9A RID: 3226
		EnterBigWorldInstResponse = 15876,
		// Token: 0x04000C9B RID: 3227
		PhantomMusicSaveRequest = 17072,
		// Token: 0x04000C9C RID: 3228
		PhantomMusicSaveResponse = 25499,
		// Token: 0x04000C9D RID: 3229
		PhantomMusicNotify = 19275,
		// Token: 0x04000C9E RID: 3230
		FlagChallengeTaskInfoUpdateNotify = 28118,
		// Token: 0x04000C9F RID: 3231
		FlagChallengeLevelInfoUpdateNotify = 27954,
		// Token: 0x04000CA0 RID: 3232
		FlagStrongholdInfoUpdateNotify = 22966,
		// Token: 0x04000CA1 RID: 3233
		FlagChallengePerRoleLevelNotify = 25423,
		// Token: 0x04000CA2 RID: 3234
		FlagChallengeTempRoleLevelNotify = 20785,
		// Token: 0x04000CA3 RID: 3235
		FlagChallengeInstNotify = 28262,
		// Token: 0x04000CA4 RID: 3236
		FlagChallengeRewardRequest = 19079,
		// Token: 0x04000CA5 RID: 3237
		FlagChallengeRewardResponse = 20586,
		// Token: 0x04000CA6 RID: 3238
		MotorDevelopTaskRewardRequest = 16150,
		// Token: 0x04000CA7 RID: 3239
		MotorDevelopTaskRewardResponse = 29442,
		// Token: 0x04000CA8 RID: 3240
		MotorDevelopTaskUpdateNotify = 27674,
		// Token: 0x04000CA9 RID: 3241
		VehicleFinishRequest = 19634,
		// Token: 0x04000CAA RID: 3242
		VehicleFinishResponse = 17721,
		// Token: 0x04000CAB RID: 3243
		AtomicProcessRemoveBuffRequest = 19269,
		// Token: 0x04000CAC RID: 3244
		AtomicProcessRemoveBuffResponse = 24883,
		// Token: 0x04000CAD RID: 3245
		ActivityPayShopBuyRequest = 23899,
		// Token: 0x04000CAE RID: 3246
		ActivityPayShopBuyResponse = 29072,
		// Token: 0x04000CAF RID: 3247
		SpringFestivalAtmosphereUpdateNotify = 26608,
		// Token: 0x04000CB0 RID: 3248
		FlagChallengeSettleNotify = 26883,
		// Token: 0x04000CB1 RID: 3249
		KurotatoStepUpdateNotify = 21986,
		// Token: 0x04000CB2 RID: 3250
		GivebackUnlockNotify = 15923,
		// Token: 0x04000CB3 RID: 3251
		MotorFightAddEnemyBuffNotify = 17969,
		// Token: 0x04000CB4 RID: 3252
		MotorFightRefreshCollectionTimesChangeNotify = 16712,
		// Token: 0x04000CB5 RID: 3253
		FurnitureUnlockNotify = 29232,
		// Token: 0x04000CB6 RID: 3254
		MotorFightAddCollectionNotify = 27020,
		// Token: 0x04000CB7 RID: 3255
		TetrisUpdateRequest = 25007,
		// Token: 0x04000CB8 RID: 3256
		TetrisUpdateResponse = 21709,
		// Token: 0x04000CB9 RID: 3257
		NewTrialRoleGetNightmarePhantomInstInfoRequest = 17854,
		// Token: 0x04000CBA RID: 3258
		NewTrialRoleGetNightmarePhantomInstInfoResponse = 19481,
		// Token: 0x04000CBB RID: 3259
		MotorSummonAndRidePush = 18805,
		// Token: 0x04000CBC RID: 3260
		MotorSummonAndRideNotify = 21704,
		// Token: 0x04000CBD RID: 3261
		MixDrinkRoleInviteRequest = 20628,
		// Token: 0x04000CBE RID: 3262
		MixDrinkRoleInviteResponse = 18245,
		// Token: 0x04000CBF RID: 3263
		MotorFightRankListSelfDataRequest = 28172,
		// Token: 0x04000CC0 RID: 3264
		MotorFightRankListSelfDataResponse = 18113,
		// Token: 0x04000CC1 RID: 3265
		PhBaPlanUsePlanRequest = 27699,
		// Token: 0x04000CC2 RID: 3266
		PhBaPlanUsePlanResponse = 17771,
		// Token: 0x04000CC3 RID: 3267
		PhBaPlanSaveUsePlanRequest = 15491,
		// Token: 0x04000CC4 RID: 3268
		PhBaPlanSaveUsePlanResponse = 26457,
		// Token: 0x04000CC5 RID: 3269
		PhBaPlanFindPlanRequest = 29810,
		// Token: 0x04000CC6 RID: 3270
		PhBaPlanFindPlanResponse = 26108,
		// Token: 0x04000CC7 RID: 3271
		KurotatoChestRewardNotify = 24115,
		// Token: 0x04000CC8 RID: 3272
		KurotatoChestRewardSelectRequest = 16722,
		// Token: 0x04000CC9 RID: 3273
		KurotatoChestRewardSelectResponse = 22900,
		// Token: 0x04000CCA RID: 3274
		KurotatoUpgradeRewardNotify = 18286,
		// Token: 0x04000CCB RID: 3275
		KurotatoUpgradeRewardSelectRequest = 20748,
		// Token: 0x04000CCC RID: 3276
		KurotatoUpgradeRewardSelectResponse = 24364,
		// Token: 0x04000CCD RID: 3277
		KurotatoUpgradeRewardRefreshRequest = 19521,
		// Token: 0x04000CCE RID: 3278
		KurotatoUpgradeRewardRefreshResponse = 21421,
		// Token: 0x04000CCF RID: 3279
		KurotatoShopRewardNotify = 15439,
		// Token: 0x04000CD0 RID: 3280
		KurotatoShopRewardSelectRequest = 25262,
		// Token: 0x04000CD1 RID: 3281
		KurotatoShopRewardSelectResponse = 28684,
		// Token: 0x04000CD2 RID: 3282
		KurotatoShopRewardLockRequest = 27851,
		// Token: 0x04000CD3 RID: 3283
		KurotatoShopRewardLockResponse = 15987,
		// Token: 0x04000CD4 RID: 3284
		KurotatoShopRewardRefreshRequest = 27770,
		// Token: 0x04000CD5 RID: 3285
		KurotatoShopRewardRefreshResponse = 16518,
		// Token: 0x04000CD6 RID: 3286
		MixDrinkRoleRewardRequest = 21940,
		// Token: 0x04000CD7 RID: 3287
		MixDrinkRoleRewardResponse = 21453,
		// Token: 0x04000CD8 RID: 3288
		JokerGuessRewardRequest = 26198,
		// Token: 0x04000CD9 RID: 3289
		JokerGuessRewardResponse = 20099,
		// Token: 0x04000CDA RID: 3290
		StorageInfoRequest = 20672,
		// Token: 0x04000CDB RID: 3291
		StorageInfoResponse = 15837,
		// Token: 0x04000CDC RID: 3292
		StorageInfoUpdateRequest = 22023,
		// Token: 0x04000CDD RID: 3293
		StorageInfoUpdateResponse = 24640,
		// Token: 0x04000CDE RID: 3294
		KurotatoSystemInfoNotify = 17800,
		// Token: 0x04000CDF RID: 3295
		KurotatoItemUpdateNotify = 15702,
		// Token: 0x04000CE0 RID: 3296
		ConfirmCompleteRefMp4QuestNotify = 20002,
		// Token: 0x04000CE1 RID: 3297
		FeiXuePreheatInfoUpdateNotify = 21876,
		// Token: 0x04000CE2 RID: 3298
		FeiXuePreheatInfoRewardRequest = 17951,
		// Token: 0x04000CE3 RID: 3299
		FeiXuePreheatInfoRewardResponse = 26680,
		// Token: 0x04000CE4 RID: 3300
		StorageInfoNotify = 17245,
		// Token: 0x04000CE5 RID: 3301
		RhythmChangePartnerRoleRequest = 23553,
		// Token: 0x04000CE6 RID: 3302
		RhythmChangePartnerRoleResponse = 23561,
		// Token: 0x04000CE7 RID: 3303
		RhythmRankListRequest = 26399,
		// Token: 0x04000CE8 RID: 3304
		RhythmRankListResponse = 26553,
		// Token: 0x04000CE9 RID: 3305
		RhythmRankListSelfDataRequest = 25501,
		// Token: 0x04000CEA RID: 3306
		RhythmRankListSelfDataResponse = 24201,
		// Token: 0x04000CEB RID: 3307
		RhythmSettleRequest = 18268,
		// Token: 0x04000CEC RID: 3308
		RhythmSettleResponse = 18537,
		// Token: 0x04000CED RID: 3309
		RhythmRoleUpdateNotify = 27775,
		// Token: 0x04000CEE RID: 3310
		RhythmSubLevelUpdateNotify = 18647,
		// Token: 0x04000CEF RID: 3311
		RhythmSetRedDotRequest = 24911,
		// Token: 0x04000CF0 RID: 3312
		RhythmSetRedDotResponse = 21670,
		// Token: 0x04000CF1 RID: 3313
		RhythmTaskOneKeyRewardRequest = 27736,
		// Token: 0x04000CF2 RID: 3314
		RhythmTaskOneKeyRewardResponse = 28347,
		// Token: 0x04000CF3 RID: 3315
		RhythmTaskUpdateNotify = 15309,
		// Token: 0x04000CF4 RID: 3316
		DropCatchLevelRewardRequest = 26230,
		// Token: 0x04000CF5 RID: 3317
		DropCatchLevelRewardResponse = 27201,
		// Token: 0x04000CF6 RID: 3318
		DropCatchLevelRewardUpdateNotify = 22284,
		// Token: 0x04000CF7 RID: 3319
		DropCatchLevelFinishRequest = 23994,
		// Token: 0x04000CF8 RID: 3320
		DropCatchLevelFinishResponse = 24353,
		// Token: 0x04000CF9 RID: 3321
		SplinePositionUpdateRequest = 24134,
		// Token: 0x04000CFA RID: 3322
		SplinePositionUpdateResponse = 29976,
		// Token: 0x04000CFB RID: 3323
		SplinePositionNotify = 28425,
		// Token: 0x04000CFC RID: 3324
		TimeScheduleTriggerNotify = 26967,
		// Token: 0x04000CFD RID: 3325
		MotorFightRefreshBossPush = 23084,
		// Token: 0x04000CFE RID: 3326
		KurotatoWeaponUpdateNotify = 22797,
		// Token: 0x04000CFF RID: 3327
		KurotatoEndShopStepRequest = 26067,
		// Token: 0x04000D00 RID: 3328
		KurotatoEndShopStepResponse = 23609,
		// Token: 0x04000D01 RID: 3329
		NewTowerLastCycleInfoRequest = 17540,
		// Token: 0x04000D02 RID: 3330
		NewTowerLastCycleInfoResponse = 17319,
		// Token: 0x04000D03 RID: 3331
		NewTowerSeasonRewardRequest = 23587,
		// Token: 0x04000D04 RID: 3332
		NewTowerSeasonRewardResponse = 20020,
		// Token: 0x04000D05 RID: 3333
		NewTowerSeasonTaskDataUpdateNotify = 24370,
		// Token: 0x04000D06 RID: 3334
		NewTowerRecommendRequest = 23165,
		// Token: 0x04000D07 RID: 3335
		NewTowerRecommendResponse = 15290,
		// Token: 0x04000D08 RID: 3336
		BlackScreenStatePush = 15727,
		// Token: 0x04000D09 RID: 3337
		ScheduleNpcUpdatePosRequest = 21451,
		// Token: 0x04000D0A RID: 3338
		ScheduleNpcUpdatePosResponse = 19698,
		// Token: 0x04000D0B RID: 3339
		WillSwitchSceneGroupNotify = 24534,
		// Token: 0x04000D0C RID: 3340
		KurotatoRefineWeaponRequest = 28420,
		// Token: 0x04000D0D RID: 3341
		KurotatoRefineWeaponResponse = 23434,
		// Token: 0x04000D0E RID: 3342
		RhythmShipStartNotify = 24795,
		// Token: 0x04000D0F RID: 3343
		PhBaPlanSetPlanStatusRequest = 24251,
		// Token: 0x04000D10 RID: 3344
		PhBaPlanSetPlanStatusResponse = 26043,
		// Token: 0x04000D11 RID: 3345
		PhBaPlanUpdatePlanRequest = 23537,
		// Token: 0x04000D12 RID: 3346
		PhBaPlanUpdatePlanResponse = 20521,
		// Token: 0x04000D13 RID: 3347
		FlagChallengeBoxExpNotify = 22380,
		// Token: 0x04000D14 RID: 3348
		PhBaPlanSetFiveStarSwitchRequest = 17981,
		// Token: 0x04000D15 RID: 3349
		PhBaPlanSetFiveStarSwitchResponse = 24842,
		// Token: 0x04000D16 RID: 3350
		NewTowerSeasonScoreRewardRequest = 26245,
		// Token: 0x04000D17 RID: 3351
		NewTowerSeasonScoreRewardResponse = 24617,
		// Token: 0x04000D18 RID: 3352
		MotorCycleCruiseStatePush = 28534,
		// Token: 0x04000D19 RID: 3353
		ConsumptiveTotalScoreNotify = 22825,
		// Token: 0x04000D1A RID: 3354
		EnterAreaNotify = 25064,
		// Token: 0x04000D1B RID: 3355
		RecallInfoNotify = 25321,
		// Token: 0x04000D1C RID: 3356
		StartRecallRequest = 18032,
		// Token: 0x04000D1D RID: 3357
		StartRecallResponse = 22108,
		// Token: 0x04000D1E RID: 3358
		EntityDressOrnamentChangeNotify = 24410,
		// Token: 0x04000D1F RID: 3359
		OrnamentInfoNotify = 15327,
		// Token: 0x04000D20 RID: 3360
		OrnamentUnlockNotify = 27985,
		// Token: 0x04000D21 RID: 3361
		OrnamentDressInfoUpdateNotify = 29379,
		// Token: 0x04000D22 RID: 3362
		ChangeOrnamentRequest = 16754,
		// Token: 0x04000D23 RID: 3363
		ChangeOrnamentResponse = 23664,
		// Token: 0x04000D24 RID: 3364
		SimpleCombatEntityAttributeUpdateNotify = 16636,
		// Token: 0x04000D25 RID: 3365
		DropCatchInfoRequest = 21673,
		// Token: 0x04000D26 RID: 3366
		DropCatchInfoResponse = 26513,
		// Token: 0x04000D27 RID: 3367
		AvoidBlockSubmitOverNodeRequest = 28527,
		// Token: 0x04000D28 RID: 3368
		AvoidBlockSubmitOverNodeResponse = 27806,
		// Token: 0x04000D29 RID: 3369
		AvoidBlockSettlementNotify = 23761,
		// Token: 0x04000D2A RID: 3370
		AvoidBlockRoundInfoNotify = 21465,
		// Token: 0x04000D2B RID: 3371
		KurotatoSellWeaponRequest = 28213,
		// Token: 0x04000D2C RID: 3372
		KurotatoSellWeaponResponse = 24086,
		// Token: 0x04000D2D RID: 3373
		CompleteMarkNotify = 27647,
		// Token: 0x04000D2E RID: 3374
		TetrisFinishRequest = 15095,
		// Token: 0x04000D2F RID: 3375
		TetrisFinishResponse = 16139,
		// Token: 0x04000D30 RID: 3376
		RacingBetsCloseSettleMenuRequest = 15685,
		// Token: 0x04000D31 RID: 3377
		RacingBetsCloseSettleMenuResponse = 23836,
		// Token: 0x04000D32 RID: 3378
		FlagChallengeUnlockTeleporterNotify = 27289,
		// Token: 0x04000D33 RID: 3379
		PlayerXboxInfoGetRequest = 17106,
		// Token: 0x04000D34 RID: 3380
		PlayerXboxInfoGetResponse = 29123,
		// Token: 0x04000D35 RID: 3381
		PlayerCreateXboxSessionRequest = 19073,
		// Token: 0x04000D36 RID: 3382
		PlayerCreateXboxSessionResponse = 17939,
		// Token: 0x04000D37 RID: 3383
		PlayerXboxSessionNotify = 28993,
		// Token: 0x04000D38 RID: 3384
		PlayerXboxBlockListRequest = 17705,
		// Token: 0x04000D39 RID: 3385
		PlayerXboxBlockListResponse = 26733,
		// Token: 0x04000D3A RID: 3386
		XboxSettingUpdateRequest = 17883,
		// Token: 0x04000D3B RID: 3387
		XboxSettingUpdateResponse = 16049,
		// Token: 0x04000D3C RID: 3388
		XboxSettingRequest = 17199,
		// Token: 0x04000D3D RID: 3389
		XboxSettingResponse = 16665,
		// Token: 0x04000D3E RID: 3390
		PinballTeamReviveRequest = 26619,
		// Token: 0x04000D3F RID: 3391
		PinballTeamReviveResponse = 15477,
		// Token: 0x04000D40 RID: 3392
		PinballSetPayloadRequest = 23171,
		// Token: 0x04000D41 RID: 3393
		PinballSetPayloadResponse = 26267,
		// Token: 0x04000D42 RID: 3394
		PinballSettleNotify = 24613,
		// Token: 0x04000D43 RID: 3395
		RoleSkillQuickLevelUpRequest = 29438,
		// Token: 0x04000D44 RID: 3396
		RoleSkillQuickLevelUpResponse = 24928,
		// Token: 0x04000D45 RID: 3397
		GaSwitchCommonEnemyProCampRequest = 18387,
		// Token: 0x04000D46 RID: 3398
		GaSwitchCommonEnemyProCampResponse = 20488,
		// Token: 0x04000D47 RID: 3399
		PinballTeamDieRequest = 15247,
		// Token: 0x04000D48 RID: 3400
		PinballTeamDieResponse = 15684,
		// Token: 0x04000D49 RID: 3401
		PinballQuitRequest = 23709,
		// Token: 0x04000D4A RID: 3402
		PinballQuitResponse = 21377,
		// Token: 0x04000D4B RID: 3403
		PinballBonusFullWinRequest = 19347,
		// Token: 0x04000D4C RID: 3404
		PinballBonusFullWinResponse = 16828,
		// Token: 0x04000D4D RID: 3405
		PinballInGameStateChangeNotify = 20926,
		// Token: 0x04000D4E RID: 3406
		PinballInGameSyncPayloadRequest = 18030,
		// Token: 0x04000D4F RID: 3407
		PinballInGameSyncPayloadResponse = 24557,
		// Token: 0x04000D50 RID: 3408
		KurotatoPropertyUpdateNotify = 22357,
		// Token: 0x04000D51 RID: 3409
		PinballTaskRewardRequest = 17084,
		// Token: 0x04000D52 RID: 3410
		PinballTaskRewardResponse = 16536,
		// Token: 0x04000D53 RID: 3411
		PinballRoleLevelUpRequest = 20427,
		// Token: 0x04000D54 RID: 3412
		PinballRoleLevelUpResponse = 29568,
		// Token: 0x04000D55 RID: 3413
		PinballWeaponDegradeRequest = 15550,
		// Token: 0x04000D56 RID: 3414
		PinballWeaponDegradeResponse = 24456,
		// Token: 0x04000D57 RID: 3415
		PinballWeaponWearRequest = 22578,
		// Token: 0x04000D58 RID: 3416
		PinballWeaponWearResponse = 17279,
		// Token: 0x04000D59 RID: 3417
		PinballFriendRankRequest = 27697,
		// Token: 0x04000D5A RID: 3418
		PinballFriendRankResponse = 20019,
		// Token: 0x04000D5B RID: 3419
		PinballUpdateNotify = 19395,
		// Token: 0x04000D5C RID: 3420
		BulletPatternPush = 15914,
		// Token: 0x04000D5D RID: 3421
		BulletPatternNotify = 24460,
		// Token: 0x04000D5E RID: 3422
		BeamReceiveNotify = 17895,
		// Token: 0x04000D5F RID: 3423
		InfrV2InfoRequest = 20516,
		// Token: 0x04000D60 RID: 3424
		InfrV2InfoResponse = 26149,
		// Token: 0x04000D61 RID: 3425
		InfrV2LevelUpRequest = 26367,
		// Token: 0x04000D62 RID: 3426
		InfrV2LevelUpResponse = 29561,
		// Token: 0x04000D63 RID: 3427
		InfrV2TreeBuildRequest = 17207,
		// Token: 0x04000D64 RID: 3428
		InfrV2TreeBuildResponse = 28858,
		// Token: 0x04000D65 RID: 3429
		InfrV2TreeUpdateNotify = 19674,
		// Token: 0x04000D66 RID: 3430
		InfrV2ManualSwitchTraceTreeRequest = 24316,
		// Token: 0x04000D67 RID: 3431
		InfrV2ManualSwitchTraceTreeResponse = 26046,
		// Token: 0x04000D68 RID: 3432
		InfrV2ManualCancelTraceTreeRequest = 25977,
		// Token: 0x04000D69 RID: 3433
		InfrV2ManualCancelTraceTreeResponse = 16976,
		// Token: 0x04000D6A RID: 3434
		RogueInstExtraInfoRequest = 28775,
		// Token: 0x04000D6B RID: 3435
		RogueInstExtraInfoResponse = 19878,
		// Token: 0x04000D6C RID: 3436
		RogueInstExtraInfoUpdateNotify = 18838,
		// Token: 0x04000D6D RID: 3437
		InfrV2FireUpdateNotify = 15857,
		// Token: 0x04000D6E RID: 3438
		InfrV2TaskDataUpdateNotify = 20489,
		// Token: 0x04000D6F RID: 3439
		InfrV2ScoreRewardRequest = 29142,
		// Token: 0x04000D70 RID: 3440
		InfrV2ScoreRewardResponse = 27040,
		// Token: 0x04000D71 RID: 3441
		InfrV2TaskRewardRequest = 17782,
		// Token: 0x04000D72 RID: 3442
		InfrV2TaskRewardResponse = 16735,
		// Token: 0x04000D73 RID: 3443
		RhythmMainLineInfoRequest = 17348,
		// Token: 0x04000D74 RID: 3444
		RhythmMainLineInfoResponse = 21999,
		// Token: 0x04000D75 RID: 3445
		ThemePersonalScoreRequest = 20050,
		// Token: 0x04000D76 RID: 3446
		ThemePersonalScoreResponse = 18903,
		// Token: 0x04000D77 RID: 3447
		ThemeWorldScoreRequest = 27224,
		// Token: 0x04000D78 RID: 3448
		ThemeWorldScoreResponse = 29997,
		// Token: 0x04000D79 RID: 3449
		WuWuTaskUpdateNotify = 24180,
		// Token: 0x04000D7A RID: 3450
		WuWuTaskRewardRequest = 20996,
		// Token: 0x04000D7B RID: 3451
		WuWuTaskRewardResponse = 20425,
		// Token: 0x04000D7C RID: 3452
		ThemeCeleWuWuTaskNotify = 29613,
		// Token: 0x04000D7D RID: 3453
		BossPilingTaskInfoUpdateNotify = 15232,
		// Token: 0x04000D7E RID: 3454
		BossPilingLevelInfoUpdateNotify = 29397,
		// Token: 0x04000D7F RID: 3455
		BossPilingInstNotify = 15347,
		// Token: 0x04000D80 RID: 3456
		BossPilingBuffUpdateNotify = 19869,
		// Token: 0x04000D81 RID: 3457
		BossPilingSettleNotify = 25811,
		// Token: 0x04000D82 RID: 3458
		BossPilingRewardRequest = 21613,
		// Token: 0x04000D83 RID: 3459
		BossPilingRewardResponse = 26058,
		// Token: 0x04000D84 RID: 3460
		PhBaPlanBatchOperRequest = 26395,
		// Token: 0x04000D85 RID: 3461
		PhBaPlanBatchOperResponse = 28424,
		// Token: 0x04000D86 RID: 3462
		MotorOutlookCreatePresetRequest = 19553,
		// Token: 0x04000D87 RID: 3463
		MotorOutlookCreatePresetResponse = 22153,
		// Token: 0x04000D88 RID: 3464
		MotorOutlookDeletePresetRequest = 27629,
		// Token: 0x04000D89 RID: 3465
		MotorOutlookDeletePresetResponse = 16772,
		// Token: 0x04000D8A RID: 3466
		MotorOutlookEditPresetRequest = 26832,
		// Token: 0x04000D8B RID: 3467
		MotorOutlookEditPresetResponse = 23910,
		// Token: 0x04000D8C RID: 3468
		FlowerPollutionRequest = 22707,
		// Token: 0x04000D8D RID: 3469
		FlowerPollutionResponse = 23879,
		// Token: 0x04000D8E RID: 3470
		MotorDecalTaskRequest = 17341,
		// Token: 0x04000D8F RID: 3471
		MotorDecalTaskResponse = 22439,
		// Token: 0x04000D90 RID: 3472
		MotorDecalUpdateNotify = 20711,
		// Token: 0x04000D91 RID: 3473
		FlowerPollutionSplinePush = 18370,
		// Token: 0x04000D92 RID: 3474
		MotorDecalMotorIpRequest = 27551,
		// Token: 0x04000D93 RID: 3475
		MotorDecalMotorIpResponse = 27523,
		// Token: 0x04000D94 RID: 3476
		MotorOutlookFullChangeNotify = 16805,
		// Token: 0x04000D95 RID: 3477
		BossPilingSettleRequest = 19863,
		// Token: 0x04000D96 RID: 3478
		BossPilingSettleResponse = 17879,
		// Token: 0x04000D97 RID: 3479
		PinballInGameStarChangeNotify = 22124,
		// Token: 0x04000D98 RID: 3480
		FsmMontageDurationNotify = 24356,
		// Token: 0x04000D99 RID: 3481
		RacingBetsRepeatedTaskRewardRequest = 25268,
		// Token: 0x04000D9A RID: 3482
		RacingBetsRepeatedTaskRewardResponse = 22994,
		// Token: 0x04000D9B RID: 3483
		LinkageCheckInRewardRequest = 17237,
		// Token: 0x04000D9C RID: 3484
		LinkageCheckInRewardResponse = 19375,
		// Token: 0x04000D9D RID: 3485
		GolemCrackUpdateRequest = 18010,
		// Token: 0x04000D9E RID: 3486
		GolemCrackUpdateResponse = 25396,
		// Token: 0x04000D9F RID: 3487
		QuickHackRamVerifyPush = 22375,
		// Token: 0x04000DA0 RID: 3488
		QuestBranchRequest = 19642,
		// Token: 0x04000DA1 RID: 3489
		QuestBranchResponse = 20238,
		// Token: 0x04000DA2 RID: 3490
		QuestBranchSelectRequest = 19447,
		// Token: 0x04000DA3 RID: 3491
		QuestBranchSelectResponse = 29618,
		// Token: 0x04000DA4 RID: 3492
		QuestBranchUpdateNotify = 26971,
		// Token: 0x04000DA5 RID: 3493
		RoleGiftRewardRequest = 29332,
		// Token: 0x04000DA6 RID: 3494
		RoleGiftRewardResponse = 28753,
		// Token: 0x04000DA7 RID: 3495
		NewTowerSeasonTaskDataUpdateRequest = 18463,
		// Token: 0x04000DA8 RID: 3496
		NewTowerSeasonTaskDataUpdateResponse = 28342,
		// Token: 0x04000DA9 RID: 3497
		WuWuPackageRewardRequest = 18557,
		// Token: 0x04000DAA RID: 3498
		WuWuPackageRewardResponse = 17971,
		// Token: 0x04000DAB RID: 3499
		MotorPositionStatePush = 28875,
		// Token: 0x04000DAC RID: 3500
		MotorPositionStateNotify = 20614,
		// Token: 0x04000DAD RID: 3501
		PinballInGameKickBallRequest = 22423,
		// Token: 0x04000DAE RID: 3502
		PinballInGameKickBallResponse = 23854,
		// Token: 0x04000DAF RID: 3503
		GachaAccumulateInfoRequest = 28411,
		// Token: 0x04000DB0 RID: 3504
		GachaAccumulateInfoResponse = 21629,
		// Token: 0x04000DB1 RID: 3505
		GachaAccumulateInfoNotify = 21430,
		// Token: 0x04000DB2 RID: 3506
		GachaAccumulateRewardRequest = 21085,
		// Token: 0x04000DB3 RID: 3507
		GachaAccumulateRewardResponse = 20196,
		// Token: 0x04000DB4 RID: 3508
		PlayerEnterPollutionRequest = 27660,
		// Token: 0x04000DB5 RID: 3509
		PlayerEnterPollutionResponse = 20980,
		// Token: 0x04000DB6 RID: 3510
		InfrV2TreeFinishCondUpdateNotify = 21763,
		// Token: 0x04000DB7 RID: 3511
		QuickHackSkillRequest = 23390,
		// Token: 0x04000DB8 RID: 3512
		QuickHackSkillResponse = 17263,
		// Token: 0x04000DB9 RID: 3513
		EdgeRunnerFunctionPreUnlockRequest = 21322,
		// Token: 0x04000DBA RID: 3514
		EdgeRunnerFunctionPreUnlockResponse = 20110,
		// Token: 0x04000DBB RID: 3515
		EdgeRunnerScoreRewardRequest = 28427,
		// Token: 0x04000DBC RID: 3516
		EdgeRunnerScoreRewardResponse = 20097,
		// Token: 0x04000DBD RID: 3517
		EdgeRunnerUpdateNotify = 23668,
		// Token: 0x04000DBE RID: 3518
		EdgeRunnerTaskRewardRequest = 28256,
		// Token: 0x04000DBF RID: 3519
		EdgeRunnerTaskRewardResponse = 17834,
		// Token: 0x04000DC0 RID: 3520
		KurotatoLevelDataUpdateNotify = 17855,
		// Token: 0x04000DC1 RID: 3521
		KurotatoRoleUnlockNotify = 16470,
		// Token: 0x04000DC2 RID: 3522
		KurotatoWeaponUnlockNotify = 17432,
		// Token: 0x04000DC3 RID: 3523
		KurotatoItemUnlockNotify = 20943,
		// Token: 0x04000DC4 RID: 3524
		KurotatoScoreTaskReceiveRequest = 25395,
		// Token: 0x04000DC5 RID: 3525
		KurotatoScoreTaskReceiveResponse = 20122,
		// Token: 0x04000DC6 RID: 3526
		KurotatoResTaskUpdateNotify = 27726,
		// Token: 0x04000DC7 RID: 3527
		KurotatoResTaskReceiveRequest = 16881,
		// Token: 0x04000DC8 RID: 3528
		KurotatoResTaskReceiveResponse = 21172,
		// Token: 0x04000DC9 RID: 3529
		KurotatoLimitTaskUpdateNotify = 29083,
		// Token: 0x04000DCA RID: 3530
		KurotatoLimitTaskReceiveRequest = 19700,
		// Token: 0x04000DCB RID: 3531
		KurotatoLimitTaskReceiveResponse = 20933,
		// Token: 0x04000DCC RID: 3532
		KurotatoRoleRecordRequest = 25830,
		// Token: 0x04000DCD RID: 3533
		KurotatoRoleRecordResponse = 16983,
		// Token: 0x04000DCE RID: 3534
		PinballUpdateWaveNotify = 23526,
		// Token: 0x04000DCF RID: 3535
		WeeklyFrameworkInfoRequest = 29511,
		// Token: 0x04000DD0 RID: 3536
		WeeklyFrameworkInfoResponse = 22499,
		// Token: 0x04000DD1 RID: 3537
		WeeklyFrameworkInfoUpdateNotify = 24665,
		// Token: 0x04000DD2 RID: 3538
		WeeklyFrameworkScoreRewardRequest = 27471,
		// Token: 0x04000DD3 RID: 3539
		WeeklyFrameworkScoreRewardResponse = 23966,
		// Token: 0x04000DD4 RID: 3540
		FloroRanchWeeklyRequest = 18853,
		// Token: 0x04000DD5 RID: 3541
		FloroRanchWeeklyResponse = 28219,
		// Token: 0x04000DD6 RID: 3542
		DollGrabRequest = 17827,
		// Token: 0x04000DD7 RID: 3543
		DollGrabResponse = 17987,
		// Token: 0x04000DD8 RID: 3544
		DollGrabTimeBallRequest = 15812,
		// Token: 0x04000DD9 RID: 3545
		DollGrabTimeBallResponse = 18865,
		// Token: 0x04000DDA RID: 3546
		DollGarbStartRequest = 25749,
		// Token: 0x04000DDB RID: 3547
		DollGarbStartResponse = 22696,
		// Token: 0x04000DDC RID: 3548
		ApplySceneClientEntityIncIdRequest = 24599,
		// Token: 0x04000DDD RID: 3549
		ApplySceneClientEntityIncIdResponse = 20448,
		// Token: 0x04000DDE RID: 3550
		KurotatoSettlementNotify = 24835,
		// Token: 0x04000DDF RID: 3551
		KurotatoSyncEntityDealDamagePush = 23335,
		// Token: 0x04000DE0 RID: 3552
		AvoidBlockClientInitDoneRequest = 15216,
		// Token: 0x04000DE1 RID: 3553
		AvoidBlockClientInitDoneResponse = 23288,
		// Token: 0x04000DE2 RID: 3554
		EdgeRunnerLordGymLevelPlayResultNotify = 24470,
		// Token: 0x04000DE3 RID: 3555
		MotorOnlineProgressReportPush = 18346,
		// Token: 0x04000DE4 RID: 3556
		MotorOnlineRankSnapshotNotify = 21549,
		// Token: 0x04000DE5 RID: 3557
		FloroRanchPlayWeeklyNotify = 27614,
		// Token: 0x04000DE6 RID: 3558
		StorageInfoUpdateNotify = 24810,
		// Token: 0x04000DE7 RID: 3559
		QuickHackOpenPush = 25808,
		// Token: 0x04000DE8 RID: 3560
		ConsumptiveActivityScoreRequest = 21065,
		// Token: 0x04000DE9 RID: 3561
		ConsumptiveActivityScoreResponse = 15654,
		// Token: 0x04000DEA RID: 3562
		MonsterPatrolPointReachedRequest = 27779,
		// Token: 0x04000DEB RID: 3563
		MonsterPatrolPointReachedResponse = 21552,
		// Token: 0x04000DEC RID: 3564
		KurotatoRoleRecordNotify = 29827,
		// Token: 0x04000DED RID: 3565
		ClientPullResourcePackageRequest = 28300,
		// Token: 0x04000DEE RID: 3566
		ClientPullResourcePackageResponse = 28454,
		// Token: 0x04000DEF RID: 3567
		NewHandInItemRequest = 23060,
		// Token: 0x04000DF0 RID: 3568
		NewHandInItemResponse = 24260,
		// Token: 0x04000DF1 RID: 3569
		DollDeliveryRequest = 17654,
		// Token: 0x04000DF2 RID: 3570
		DollDeliveryResponse = 16482,
		// Token: 0x04000DF3 RID: 3571
		OnlineMotorActivityLevelRequest = 24796,
		// Token: 0x04000DF4 RID: 3572
		OnlineMotorActivityLevelResponse = 18856,
		// Token: 0x04000DF5 RID: 3573
		OnlineMotorSettleNotify = 28720,
		// Token: 0x04000DF6 RID: 3574
		OnlineMotorUpdateNotify = 20286,
		// Token: 0x04000DF7 RID: 3575
		PlayerVoiceLanguageRequest = 22437,
		// Token: 0x04000DF8 RID: 3576
		PlayerVoiceLanguageResponse = 27315,
		// Token: 0x04000DF9 RID: 3577
		PlayerRoleVoiceSetRequest = 22391,
		// Token: 0x04000DFA RID: 3578
		PlayerRoleVoiceSetResponse = 22358,
		// Token: 0x04000DFB RID: 3579
		PinballStartNotify = 29654,
		// Token: 0x04000DFC RID: 3580
		FloroRanchEventChoiceRequest = 25648,
		// Token: 0x04000DFD RID: 3581
		FloroRanchEventChoiceResponse = 29916,
		// Token: 0x04000DFE RID: 3582
		DollDeliveryNotify = 15165,
		// Token: 0x04000DFF RID: 3583
		PinballFixSpawnFinishNotify = 22699,
		// Token: 0x04000E00 RID: 3584
		EdgeRunnerPreUnlockAvailableNotify = 29069,
		// Token: 0x04000E01 RID: 3585
		InfrV2InfoNotify = 17182,
		// Token: 0x04000E02 RID: 3586
		KurotatoSettlementRequest = 29686,
		// Token: 0x04000E03 RID: 3587
		KurotatoSettlementResponse = 24003,
		// Token: 0x04000E04 RID: 3588
		RemovePreloadFlowsNotify = 24692,
		// Token: 0x04000E05 RID: 3589
		PinballSpawnFirstFinishNotify = 26869,
		// Token: 0x04000E06 RID: 3590
		RemoteBatchCollectRequest = 20492,
		// Token: 0x04000E07 RID: 3591
		RemoteBatchCollectResponse = 20188,
		// Token: 0x04000E08 RID: 3592
		FloroRanchPlayWeeklyEndNotify = 19055,
		// Token: 0x04000E09 RID: 3593
		BatchMaterialReplaceRequest = 25690,
		// Token: 0x04000E0A RID: 3594
		BatchMaterialReplaceResponse = 21431,
		// Token: 0x04000E0B RID: 3595
		KurotatoDieNotify = 24258,
		// Token: 0x04000E0C RID: 3596
		MotorOnlineRankRuleIdsNotify = 29052,
		// Token: 0x04000E0D RID: 3597
		OnlineMotorStartNotify = 20033,
		// Token: 0x04000E0E RID: 3598
		NewPlayerSupportSetCurUseTrialRoleV2Request = 19403,
		// Token: 0x04000E0F RID: 3599
		NewPlayerSupportSetCurUseTrialRoleV2Response = 19230,
		// Token: 0x04000E10 RID: 3600
		NewPlayerSupportActivityTrialRoleUpdateV2Notify = 15348,
		// Token: 0x04000E11 RID: 3601
		OnlineMotorEndNotify = 28235,
		// Token: 0x04000E12 RID: 3602
		ChangeSummonEntityStateRequest = 23569,
		// Token: 0x04000E13 RID: 3603
		ChangeSummonEntityStateResponse = 23698,
		// Token: 0x04000E14 RID: 3604
		NewPlayerSupportTrialRoleLvUpV2Request = 17058,
		// Token: 0x04000E15 RID: 3605
		NewPlayerSupportTrialRoleLvUpV2Response = 25380,
		// Token: 0x04000E16 RID: 3606
		NewPlayerSupportV2GachaRoleUpdateNotify = 20716,
		// Token: 0x04000E17 RID: 3607
		RealmBetweenInfoUpdateNotify = 25055,
		// Token: 0x04000E18 RID: 3608
		RealmBetweenFullRewardRequest = 15385,
		// Token: 0x04000E19 RID: 3609
		RealmBetweenFullRewardResponse = 18737,
		// Token: 0x04000E1A RID: 3610
		RealmBetweenLevelUpRequest = 27479,
		// Token: 0x04000E1B RID: 3611
		RealmBetweenLevelUpResponse = 27232,
		// Token: 0x04000E1C RID: 3612
		RealmBetweenTaskRewardRequest = 19830,
		// Token: 0x04000E1D RID: 3613
		RealmBetweenTaskRewardResponse = 26868,
		// Token: 0x04000E1E RID: 3614
		RealmBetweenMotorRewardRequest = 27266,
		// Token: 0x04000E1F RID: 3615
		RealmBetweenMotorRewardResponse = 20454,
		// Token: 0x04000E20 RID: 3616
		RogueArchiveListRequest = 28324,
		// Token: 0x04000E21 RID: 3617
		RogueArchiveListResponse = 26762,
		// Token: 0x04000E22 RID: 3618
		RogueArchiveSaveRequest = 20091,
		// Token: 0x04000E23 RID: 3619
		RogueArchiveSaveResponse = 29633,
		// Token: 0x04000E24 RID: 3620
		RogueTowerTrialStartRequest = 24725,
		// Token: 0x04000E25 RID: 3621
		RogueTowerTrialStartResponse = 23092,
		// Token: 0x04000E26 RID: 3622
		RogueTowerTrialSelectBossRequest = 22870,
		// Token: 0x04000E27 RID: 3623
		RogueTowerTrialSelectBossResponse = 28302,
		// Token: 0x04000E28 RID: 3624
		RogueTowerTrialReChallengeNotify = 19059,
		// Token: 0x04000E29 RID: 3625
		RogueTowerTrialReChallengeRequest = 24158,
		// Token: 0x04000E2A RID: 3626
		RogueTowerTrialReChallengeResponse = 15271,
		// Token: 0x04000E2B RID: 3627
		RogueTowerTrialResultNotify = 20375,
		// Token: 0x04000E2C RID: 3628
		RogueTowerTrialResultRequest = 19883,
		// Token: 0x04000E2D RID: 3629
		RogueTowerTrialResultResponse = 19217,
		// Token: 0x04000E2E RID: 3630
		RogueTowerTrialSelectBossNotify = 16751,
		// Token: 0x04000E2F RID: 3631
		SheriffZoneInfoRequest = 20973,
		// Token: 0x04000E30 RID: 3632
		SheriffZoneInfoResponse = 25351,
		// Token: 0x04000E31 RID: 3633
		SheriffAnomalyInfoUpdateNotify = 17753,
		// Token: 0x04000E32 RID: 3634
		SheriffCriminalUpdateNotify = 29606,
		// Token: 0x04000E33 RID: 3635
		DodgeInfoPush = 17078,
		// Token: 0x04000E34 RID: 3636
		KurotatoEndSpecialWaveCombatRequest = 16538,
		// Token: 0x04000E35 RID: 3637
		KurotatoEndSpecialWaveCombatResponse = 21746,
		// Token: 0x04000E36 RID: 3638
		BabelTowerShowNameRequest = 16067,
		// Token: 0x04000E37 RID: 3639
		BabelTowerShowNameResponse = 28419,
		// Token: 0x04000E38 RID: 3640
		BabelTowerRankListRequest = 29408,
		// Token: 0x04000E39 RID: 3641
		BabelTowerRankListResponse = 16572,
		// Token: 0x04000E3A RID: 3642
		BabelTowerSelfPassRequest = 27544,
		// Token: 0x04000E3B RID: 3643
		BabelTowerSelfPassResponse = 15993,
		// Token: 0x04000E3C RID: 3644
		DollGrabStopRequest = 18186,
		// Token: 0x04000E3D RID: 3645
		DollGrabStopResponse = 22720,
		// Token: 0x04000E3E RID: 3646
		RogueTowerTrialGiveUpTempArchiveRequest = 20363,
		// Token: 0x04000E3F RID: 3647
		RogueTowerTrialGiveUpTempArchiveResponse = 25299,
		// Token: 0x04000E40 RID: 3648
		MiniWriteLetterSaveContentRequest = 26392,
		// Token: 0x04000E41 RID: 3649
		MiniWriteLetterSaveContentResponse = 17140,
		// Token: 0x04000E42 RID: 3650
		MiniWriteLetterLoginNotify = 21985,
		// Token: 0x04000E43 RID: 3651
		SignActivityFreeDropRequest = 27704,
		// Token: 0x04000E44 RID: 3652
		SignActivityFreeDropResponse = 15457,
		// Token: 0x04000E45 RID: 3653
		KurotatoReChallengeRequest = 20651,
		// Token: 0x04000E46 RID: 3654
		KurotatoReChallengeResponse = 18670,
		// Token: 0x04000E47 RID: 3655
		TimeScheduleIdleNotify = 18933,
		// Token: 0x04000E48 RID: 3656
		DollGrabPauseStartRequest = 16209,
		// Token: 0x04000E49 RID: 3657
		DollGrabPauseStartResponse = 17732,
		// Token: 0x04000E4A RID: 3658
		DollGrabPauseEndRequest = 15196,
		// Token: 0x04000E4B RID: 3659
		DollGrabPauseEndResponse = 17158,
		// Token: 0x04000E4C RID: 3660
		GachaDiscountNotify = 15918,
		// Token: 0x04000E4D RID: 3661
		KurotatoRefineWeaponNotify = 26350,
		// Token: 0x04000E4E RID: 3662
		RecallQuestListNotify = 19235,
		// Token: 0x04000E4F RID: 3663
		TraceRecallQuestNotify = 22097,
		// Token: 0x04000E50 RID: 3664
		TraceRecallQuestRequest = 25878,
		// Token: 0x04000E51 RID: 3665
		TraceRecallQuestResponse = 28806,
		// Token: 0x04000E52 RID: 3666
		RecallQuestChangeTraceNotify = 28015,
		// Token: 0x04000E53 RID: 3667
		RecallQuestFinishActionRequest = 28969,
		// Token: 0x04000E54 RID: 3668
		RecallQuestFinishActionResponse = 15780,
		// Token: 0x04000E55 RID: 3669
		RecallQuestActionRequest = 28770,
		// Token: 0x04000E56 RID: 3670
		RecallQuestActionResponse = 22619,
		// Token: 0x04000E57 RID: 3671
		RecallQuestNpcMoveOverRequest = 26604,
		// Token: 0x04000E58 RID: 3672
		RecallQuestNpcMoveOverResponse = 19333,
		// Token: 0x04000E59 RID: 3673
		RecallQuestRollBackEndNotify = 27936,
		// Token: 0x04000E5A RID: 3674
		RecallQuestStatusUpdateNotify = 16968,
		// Token: 0x04000E5B RID: 3675
		RecallQuestFinishActionEndRequest = 21179,
		// Token: 0x04000E5C RID: 3676
		RecallQuestFinishListNotify = 26450,
		// Token: 0x04000E5D RID: 3677
		DestroyRecallQuestsNotify = 16440,
		// Token: 0x04000E5E RID: 3678
		NewbieAdventureTaskRewardRequest = 29376,
		// Token: 0x04000E5F RID: 3679
		NewbieAdventureTaskRewardResponse = 15720,
		// Token: 0x04000E60 RID: 3680
		NewbieAdventureChapterDropRequest = 16662,
		// Token: 0x04000E61 RID: 3681
		NewbieAdventureChapterDropResponse = 19337,
		// Token: 0x04000E62 RID: 3682
		NewbieAdventureRoleRewardRequest = 16825,
		// Token: 0x04000E63 RID: 3683
		NewbieAdventureRoleRewardResponse = 17073,
		// Token: 0x04000E64 RID: 3684
		NewbieAdventureTaskUpdateNotify = 27178,
		// Token: 0x04000E65 RID: 3685
		NewbieCourseV2RewardNotify = 28195,
		// Token: 0x04000E66 RID: 3686
		NewbieCourseV2RewardRequest = 27099,
		// Token: 0x04000E67 RID: 3687
		NewbieCourseV2RewardResponse = 16170,
		// Token: 0x04000E68 RID: 3688
		NewbieFetchScoreRewardRequest = 25135,
		// Token: 0x04000E69 RID: 3689
		NewbieFetchScoreRewardResponse = 29217,
		// Token: 0x04000E6A RID: 3690
		NewbieMainTaskUpdateNotify = 27645,
		// Token: 0x04000E6B RID: 3691
		RecallQuestFinishActionEndResponse = 18345,
		// Token: 0x04000E6C RID: 3692
		FloroRanchOutRequest = 23261,
		// Token: 0x04000E6D RID: 3693
		FloroRanchOutResponse = 25979,
		// Token: 0x04000E6E RID: 3694
		RecallQuestGiveUpNotify = 22535,
		// Token: 0x04000E6F RID: 3695
		RecallQuestReadyForGiveUpRequest = 17217,
		// Token: 0x04000E70 RID: 3696
		RecallQuestReadyForGiveUpResponse = 21194,
		// Token: 0x04000E71 RID: 3697
		ResonantChainOptionalLimitRequest = 17766,
		// Token: 0x04000E72 RID: 3698
		ResonantChainOptionalLimitResponse = 27438,
		// Token: 0x04000E73 RID: 3699
		RecallItemBagDeltaNotify = 27494,
		// Token: 0x04000E74 RID: 3700
		QueryRecallItemBagRequest = 20446,
		// Token: 0x04000E75 RID: 3701
		QueryRecallItemBagResponse = 25460,
		// Token: 0x04000E76 RID: 3702
		ActivityRecommendNotify = 24619,
		// Token: 0x04000E77 RID: 3703
		SetClientGlobalVarRequest = 22272,
		// Token: 0x04000E78 RID: 3704
		SetClientGlobalVarResponse = 17849,
		// Token: 0x04000E79 RID: 3705
		RecallItemBagRemoveNotify = 16591,
		// Token: 0x04000E7A RID: 3706
		RoleTrialSceneRollbackPush = 22790,
		// Token: 0x04000E7B RID: 3707
		NewTowerMonsterHpInfoNotify = 25553,
		// Token: 0x04000E7C RID: 3708
		LordGymGroupInfoUpdateNotify = 22195,
		// Token: 0x04000E7D RID: 3709
		DollGarbInsertCoinRequest = 28609,
		// Token: 0x04000E7E RID: 3710
		DollGarbInsertCoinResponse = 28733,
		// Token: 0x04000E7F RID: 3711
		KurotatoAllItemUpdateNotify = 28952,
		// Token: 0x04000E80 RID: 3712
		SimpleCombatBeginNotify = 26690,
		// Token: 0x04000E81 RID: 3713
		SimpleCombatEndNotify = 26778,
		// Token: 0x04000E82 RID: 3714
		RoverRogueQuitRequest = 27391,
		// Token: 0x04000E83 RID: 3715
		RoverRogueQuitResponse = 16168,
		// Token: 0x04000E84 RID: 3716
		RoverRogueResultRequest = 28320,
		// Token: 0x04000E85 RID: 3717
		RoverRogueResultResponse = 20710,
		// Token: 0x04000E86 RID: 3718
		RoverRogueResultNotify = 19486,
		// Token: 0x04000E87 RID: 3719
		RoverRogueRoomInfoNotify = 25772,
		// Token: 0x04000E88 RID: 3720
		RoverRogueChooseDataNotify = 17268,
		// Token: 0x04000E89 RID: 3721
		RoverRogueChooseDataResultRequest = 29940,
		// Token: 0x04000E8A RID: 3722
		RoverRogueChooseDataResultResponse = 20137,
		// Token: 0x04000E8B RID: 3723
		RoverRogueRefreshGainRequest = 29906,
		// Token: 0x04000E8C RID: 3724
		RoverRogueRefreshGainResponse = 21110,
		// Token: 0x04000E8D RID: 3725
		RoverRogueGiveUpGainRequest = 28315,
		// Token: 0x04000E8E RID: 3726
		RoverRogueGiveUpGainResponse = 19016,
		// Token: 0x04000E8F RID: 3727
		RoverRogueSubLevelNotify = 15783,
		// Token: 0x04000E90 RID: 3728
		RoverRogueGotoNextRoomCommitRequest = 21542,
		// Token: 0x04000E91 RID: 3729
		RoverRogueGotoNextRoomCommitResponse = 29236,
		// Token: 0x04000E92 RID: 3730
		RoverRogueInsListRequest = 29791,
		// Token: 0x04000E93 RID: 3731
		RoverRogueInsListResponse = 27005,
		// Token: 0x04000E94 RID: 3732
		RoverRogueTalentInfoRequest = 18812,
		// Token: 0x04000E95 RID: 3733
		RoverRogueTalentInfoResponse = 15617,
		// Token: 0x04000E96 RID: 3734
		RoverRogueTalentUnlockRequest = 16548,
		// Token: 0x04000E97 RID: 3735
		RoverRogueTalentUnlockResponse = 15025,
		// Token: 0x04000E98 RID: 3736
		RoverRogueShopBuyRequest = 15194,
		// Token: 0x04000E99 RID: 3737
		RoverRogueShopBuyResponse = 29518,
		// Token: 0x04000E9A RID: 3738
		RoverRogueShopRefreshRequest = 21321,
		// Token: 0x04000E9B RID: 3739
		RoverRogueShopRefreshResponse = 21963,
		// Token: 0x04000E9C RID: 3740
		RoverRogueShopUpdateNotify = 18904,
		// Token: 0x04000E9D RID: 3741
		RoverRogueInfoNotify = 16398,
		// Token: 0x04000E9E RID: 3742
		RoverRogueGainDataUpdateNotify = 18551,
		// Token: 0x04000E9F RID: 3743
		RoverRogueCurrencyNotify = 23276,
		// Token: 0x04000EA0 RID: 3744
		PlayerRecallInfoNotify = 20622,
		// Token: 0x04000EA1 RID: 3745
		DangoBrawlInstBaseNotify = 16916,
		// Token: 0x04000EA2 RID: 3746
		DangoBrawlInstEventSelectNotify = 16117,
		// Token: 0x04000EA3 RID: 3747
		DangoBrawlInstPrepareNotify = 27221,
		// Token: 0x04000EA4 RID: 3748
		DangoBrawlRoundSwitchNotify = 28886,
		// Token: 0x04000EA5 RID: 3749
		DangoBrawlBagOperateRequest = 27984,
		// Token: 0x04000EA6 RID: 3750
		DangoBrawlBagOperateResponse = 17507,
		// Token: 0x04000EA7 RID: 3751
		DangoBrawlCoinUpdateNotify = 29648,
		// Token: 0x04000EA8 RID: 3752
		DangoBrawlShopRefreshRequest = 23068,
		// Token: 0x04000EA9 RID: 3753
		DangoBrawlShopRefreshResponse = 15810,
		// Token: 0x04000EAA RID: 3754
		DangoBrawlShopLockRequest = 24357,
		// Token: 0x04000EAB RID: 3755
		DangoBrawlShopLockResponse = 19957,
		// Token: 0x04000EAC RID: 3756
		DangoBrawlShopBuyRequest = 24895,
		// Token: 0x04000EAD RID: 3757
		DangoBrawlShopBuyResponse = 25948,
		// Token: 0x04000EAE RID: 3758
		DangoBrawlShopSellRequest = 29894,
		// Token: 0x04000EAF RID: 3759
		DangoBrawlShopSellResponse = 24125,
		// Token: 0x04000EB0 RID: 3760
		DangoBrawlShopComposeRequest = 20473,
		// Token: 0x04000EB1 RID: 3761
		DangoBrawlShopComposeResponse = 15368,
		// Token: 0x04000EB2 RID: 3762
		DangoBrawlEventRefreshRequest = 28024,
		// Token: 0x04000EB3 RID: 3763
		DangoBrawlEventRefreshResponse = 27098,
		// Token: 0x04000EB4 RID: 3764
		DangoBrawlEventSelectRequest = 19472,
		// Token: 0x04000EB5 RID: 3765
		DangoBrawlEventSelectResponse = 29706,
		// Token: 0x04000EB6 RID: 3766
		DangoBrawlStartFightRequest = 26094,
		// Token: 0x04000EB7 RID: 3767
		DangoBrawlStartFightResponse = 28659,
		// Token: 0x04000EB8 RID: 3768
		DangoBrawlFightOverRequest = 28918,
		// Token: 0x04000EB9 RID: 3769
		DangoBrawlFightOverResponse = 16631,
		// Token: 0x04000EBA RID: 3770
		DangoBrawlSettleNotify = 18644,
		// Token: 0x04000EBB RID: 3771
		RoverRogueGainGetOrLoseNotify = 26853,
		// Token: 0x04000EBC RID: 3772
		RoverRogueUpdateReviveTimesNotify = 15569,
		// Token: 0x04000EBD RID: 3773
		KurotatoNextWaveTypeNotify = 27025,
		// Token: 0x04000EBE RID: 3774
		RoverRogueBlessGroupSelectNotify = 23210,
		// Token: 0x04000EBF RID: 3775
		RoverRogueBlessGroupSelectRequest = 25277,
		// Token: 0x04000EC0 RID: 3776
		RoverRogueBlessGroupSelectResponse = 16971,
		// Token: 0x04000EC1 RID: 3777
		DirectTrainInfoUpdateNotify = 16954,
		// Token: 0x04000EC2 RID: 3778
		NewTowerMedalInfoRequest = 26935,
		// Token: 0x04000EC3 RID: 3779
		NewTowerMedalInfoResponse = 27000,
		// Token: 0x04000EC4 RID: 3780
		LeaveQuestRecallNotify = 20978,
		// Token: 0x04000EC5 RID: 3781
		RoverRogueEventNotify = 16943,
		// Token: 0x04000EC6 RID: 3782
		RoverRogueEventSelectRequest = 25790,
		// Token: 0x04000EC7 RID: 3783
		RoverRogueEventSelectResponse = 18651,
		// Token: 0x04000EC8 RID: 3784
		MotorUseSceneRequest = 15459,
		// Token: 0x04000EC9 RID: 3785
		MotorUseSceneResponse = 26625,
		// Token: 0x04000ECA RID: 3786
		DangoBrawlFighterAttrChangeNotify = 29224,
		// Token: 0x04000ECB RID: 3787
		DangoBrawlSettleRequest = 28335,
		// Token: 0x04000ECC RID: 3788
		DangoBrawlSettleResponse = 24979,
		// Token: 0x04000ECD RID: 3789
		DangoBrawlTaskUpdateNotify = 21615,
		// Token: 0x04000ECE RID: 3790
		DangoBrawlRoleUnlockNotify = 15179,
		// Token: 0x04000ECF RID: 3791
		DangoBrawlItemUnlockNotify = 22794,
		// Token: 0x04000ED0 RID: 3792
		DangoBrawlTaskRewardRequest = 19998,
		// Token: 0x04000ED1 RID: 3793
		DangoBrawlTaskRewardResponse = 20255,
		// Token: 0x04000ED2 RID: 3794
		PlayerNetStateS2cNotify = 18103,
		// Token: 0x04000ED3 RID: 3795
		PlayerNetStateBackServerPush = 19999,
		// Token: 0x04000ED4 RID: 3796
		UpdatePhantomEquipGroupRequest = 22464,
		// Token: 0x04000ED5 RID: 3797
		UpdatePhantomEquipGroupResponse = 27868,
		// Token: 0x04000ED6 RID: 3798
		QuestFastReturnPosRequest = 23769,
		// Token: 0x04000ED7 RID: 3799
		QuestFastReturnPosResponse = 28798,
		// Token: 0x04000ED8 RID: 3800
		LevelPlayFastReturnPosRequest = 27495,
		// Token: 0x04000ED9 RID: 3801
		LevelPlayFastReturnPosResponse = 17289,
		// Token: 0x04000EDA RID: 3802
		FastReturnDungeonRequest = 26812,
		// Token: 0x04000EDB RID: 3803
		FastReturnDungeonResponse = 24553,
		// Token: 0x04000EDC RID: 3804
		DollSmallMapInfoRequest = 20965,
		// Token: 0x04000EDD RID: 3805
		DollSmallMapInfoResponse = 19076,
		// Token: 0x04000EDE RID: 3806
		RoverRogueLootInfoRequest = 19483,
		// Token: 0x04000EDF RID: 3807
		RoverRogueLootInfoResponse = 17028,
		// Token: 0x04000EE0 RID: 3808
		KurotatoReChallengeCountNotify = 19047,
		// Token: 0x04000EE1 RID: 3809
		RoverRogueLootChangeNotify = 22228,
		// Token: 0x04000EE2 RID: 3810
		RoverRogueLootChangeRequest = 22152,
		// Token: 0x04000EE3 RID: 3811
		RoverRogueLootChangeResponse = 28188,
		// Token: 0x04000EE4 RID: 3812
		KurotatoStepAdvanceRequest = 16129,
		// Token: 0x04000EE5 RID: 3813
		KurotatoStepAdvanceResponse = 15011,
		// Token: 0x04000EE6 RID: 3814
		RecallExploreSkillRouletteSetRequest = 29727,
		// Token: 0x04000EE7 RID: 3815
		RecallExploreSkillRouletteSetResponse = 25464,
		// Token: 0x04000EE8 RID: 3816
		RecallExploreSkillRouletteNotify = 27174,
		// Token: 0x04000EE9 RID: 3817
		RoverRogueTalentUnlockNotify = 24427,
		// Token: 0x04000EEA RID: 3818
		RoverRogueTaskUpdateNotify = 23286,
		// Token: 0x04000EEB RID: 3819
		RoverRogueTaskRewardTakeRequest = 29942,
		// Token: 0x04000EEC RID: 3820
		RoverRogueTaskRewardTakeResponse = 15438,
		// Token: 0x04000EED RID: 3821
		DangoBrawlFightActionNotify = 21289,
		// Token: 0x04000EEE RID: 3822
		SceneGroupDataAndCurFormationEntityRequest = 26969,
		// Token: 0x04000EEF RID: 3823
		SceneGroupDataAndCurFormationEntityResponse = 28552,
		// Token: 0x04000EF0 RID: 3824
		DangoBrawlBagUpdateNotify = 24695,
		// Token: 0x04000EF1 RID: 3825
		KurotatoGoldAddRequest = 18249,
		// Token: 0x04000EF2 RID: 3826
		KurotatoGoldAddResponse = 25569,
		// Token: 0x04000EF3 RID: 3827
		TowerDefenceChallengeQuitRequest = 27718,
		// Token: 0x04000EF4 RID: 3828
		TowerDefenceChallengeQuitResponse = 16362,
		// Token: 0x04000EF5 RID: 3829
		PlayerTitleInfoUpdateNotify = 20253,
		// Token: 0x04000EF6 RID: 3830
		KurotatoLevelRecordDeleteRequest = 20893,
		// Token: 0x04000EF7 RID: 3831
		KurotatoLevelRecordDeleteResponse = 27741,
		// Token: 0x04000EF8 RID: 3832
		PlayInstShareFirstInfoNotify = 22822,
		// Token: 0x04000EF9 RID: 3833
		MailFavoriteRequest = 20816,
		// Token: 0x04000EFA RID: 3834
		MailFavoriteResponse = 17919,
		// Token: 0x04000EFB RID: 3835
		RoverRogueResourcesUpdateNotify = 27960,
		// Token: 0x04000EFC RID: 3836
		ConditionGroupStateRequest = 25810,
		// Token: 0x04000EFD RID: 3837
		ConditionGroupStateResponse = 16252,
		// Token: 0x04000EFE RID: 3838
		ZitherPlayStateRequest = 21137,
		// Token: 0x04000EFF RID: 3839
		ZitherPlayStateResponse = 25209,
		// Token: 0x04000F00 RID: 3840
		ZitherPlayNotePush = 16749,
		// Token: 0x04000F01 RID: 3841
		ZitherPlayNoteNotify = 19034,
		// Token: 0x04000F02 RID: 3842
		ElementalAbilityUpdateNotify = 28668,
		// Token: 0x04000F03 RID: 3843
		EntityAccessCasketRequest = 17160,
		// Token: 0x04000F04 RID: 3844
		EntityAccessCasketResponse = 21699,
		// Token: 0x04000F05 RID: 3845
		PlayerAccessCasketRequest = 19061,
		// Token: 0x04000F06 RID: 3846
		PlayerAccessCasketResponse = 18900,
		// Token: 0x04000F07 RID: 3847
		QingXiaoTaskUpdateNotify = 22617,
		// Token: 0x04000F08 RID: 3848
		QingXiaoTaskRewardRequest = 29336,
		// Token: 0x04000F09 RID: 3849
		QingXiaoTaskRewardResponse = 21118,
		// Token: 0x04000F0A RID: 3850
		EntityElementalAbilityEnableNotify = 16885,
		// Token: 0x04000F0B RID: 3851
		SheriffZoneItemUpdateNotify = 18326,
		// Token: 0x04000F0C RID: 3852
		DangoBrawlStartFightNotify = 21162,
		// Token: 0x04000F0D RID: 3853
		GiantDeliveryItemRequest = 26525,
		// Token: 0x04000F0E RID: 3854
		GiantDeliveryItemResponse = 18294,
		// Token: 0x04000F0F RID: 3855
		GiantSystemInfoNotify = 29120,
		// Token: 0x04000F10 RID: 3856
		GiantResponseNotify = 18571,
		// Token: 0x04000F11 RID: 3857
		GiantModelEnableNotify = 17776,
		// Token: 0x04000F12 RID: 3858
		GiantEcoUnlockNotify = 29556,
		// Token: 0x04000F13 RID: 3859
		GiantMaxLevelDeliveryItemRequest = 24629,
		// Token: 0x04000F14 RID: 3860
		GiantMaxLevelDeliveryItemResponse = 28669,
		// Token: 0x04000F15 RID: 3861
		MatchThreeStarRequest = 19959,
		// Token: 0x04000F16 RID: 3862
		MatchThreeStarResponse = 28482,
		// Token: 0x04000F17 RID: 3863
		MatchThreeEndRequest = 29259,
		// Token: 0x04000F18 RID: 3864
		MatchThreeEndResponse = 20119,
		// Token: 0x04000F19 RID: 3865
		DangoBrawlScoreRewardRequest = 15066,
		// Token: 0x04000F1A RID: 3866
		DangoBrawlScoreRewardResponse = 24133,
		// Token: 0x04000F1B RID: 3867
		CombatValNotify = 18757,
		// Token: 0x04000F1C RID: 3868
		CombatValDecayBeginNotify = 27363,
		// Token: 0x04000F1D RID: 3869
		DangoBrawlChallengeUnlockNotify = 22943,
		// Token: 0x04000F1E RID: 3870
		FoundationCoreOperateRequest = 27836,
		// Token: 0x04000F1F RID: 3871
		FoundationCoreOperateResponse = 23558,
		// Token: 0x04000F20 RID: 3872
		PlayerHandFoundationCoreChangeNotify = 29717,
		// Token: 0x04000F21 RID: 3873
		EntityFoundationCoreChangeNotify = 24775,
		// Token: 0x04000F22 RID: 3874
		TimePointRewardActivityConditionNotify = 21826,
		// Token: 0x04000F23 RID: 3875
		CameraSettingQueryRequest = 26920,
		// Token: 0x04000F24 RID: 3876
		CameraSettingQueryResponse = 25637,
		// Token: 0x04000F25 RID: 3877
		CameraSettingModifyRequest = 28953,
		// Token: 0x04000F26 RID: 3878
		CameraSettingModifyResponse = 26725,
		// Token: 0x04000F27 RID: 3879
		RecallMapMarkInfoNotify = 22163,
		// Token: 0x04000F28 RID: 3880
		RecallTeleportToMarkIdRequest = 23922,
		// Token: 0x04000F29 RID: 3881
		RecallTeleportToMarkIdResponse = 19697,
		// Token: 0x04000F2A RID: 3882
		DangoBrawlSaveMatchBriefNotify = 15653,
		// Token: 0x04000F2B RID: 3883
		RecallMapMarkUpdateNotify = 15791,
		// Token: 0x04000F2C RID: 3884
		ShortMessageChatThemeChangeRequest = 29084,
		// Token: 0x04000F2D RID: 3885
		ShortMessageChatThemeChangeResponse = 21146,
		// Token: 0x04000F2E RID: 3886
		ShortMessageChatCharmChangeRequest = 23634,
		// Token: 0x04000F2F RID: 3887
		ShortMessageChatCharmChangeResponse = 15958,
		// Token: 0x04000F30 RID: 3888
		GiantItemUnlockNotify = 25972,
		// Token: 0x04000F31 RID: 3889
		RenameFormationRequest = 26314,
		// Token: 0x04000F32 RID: 3890
		RenameFormationResponse = 18743,
		// Token: 0x04000F33 RID: 3891
		SolarSchoolSaveRequest = 18477,
		// Token: 0x04000F34 RID: 3892
		SolarSchoolSaveResponse = 21936,
		// Token: 0x04000F35 RID: 3893
		SolarSchoolLoadRequest = 15073,
		// Token: 0x04000F36 RID: 3894
		SolarSchoolLoadResponse = 18031,
		// Token: 0x04000F37 RID: 3895
		SolarSchoolSetFlowRequest = 21219,
		// Token: 0x04000F38 RID: 3896
		SolarSchoolSetFlowResponse = 27809,
		// Token: 0x04000F39 RID: 3897
		SolarSchoolReachEndingRequest = 27408,
		// Token: 0x04000F3A RID: 3898
		SolarSchoolReachEndingResponse = 23961,
		// Token: 0x04000F3B RID: 3899
		SolarSchoolOneKeyRewardRequest = 22187,
		// Token: 0x04000F3C RID: 3900
		SolarSchoolOneKeyRewardResponse = 26713,
		// Token: 0x04000F3D RID: 3901
		SolarSchoolTaskUpdateNotify = 16887,
		// Token: 0x04000F3E RID: 3902
		SolarSchoolBatchSyncRequest = 28917,
		// Token: 0x04000F3F RID: 3903
		SolarSchoolBatchSyncResponse = 26100,
		// Token: 0x04000F40 RID: 3904
		SolarSchoolOneKeyGalleryRewardRequest = 26247,
		// Token: 0x04000F41 RID: 3905
		SolarSchoolOneKeyGalleryRewardResponse = 19859,
		// Token: 0x04000F42 RID: 3906
		SolarSchoolGalleryUpdateNotify = 15173,
		// Token: 0x04000F43 RID: 3907
		ReorderFormationRequest = 27566,
		// Token: 0x04000F44 RID: 3908
		ReorderFormationResponse = 28600,
		// Token: 0x04000F45 RID: 3909
		GiantItemAccessUnlockNotify = 23920,
		// Token: 0x04000F46 RID: 3910
		GiantItemAccessProgressChangeNotify = 25359,
		// Token: 0x04000F47 RID: 3911
		GiantStableValueActivityRequest = 20090,
		// Token: 0x04000F48 RID: 3912
		GiantStableValueActivityResponse = 27413,
		// Token: 0x04000F49 RID: 3913
		GiantTotalStableValueUpdateNotify = 27023,
		// Token: 0x04000F4A RID: 3914
		SquadPropChangedNotify = 20340,
		// Token: 0x04000F4B RID: 3915
		GiantActivityNodeActiveNotify = 18243,
		// Token: 0x04000F4C RID: 3916
		RecallItemUseRequest = 18849,
		// Token: 0x04000F4D RID: 3917
		RecallItemUseResponse = 19067,
		// Token: 0x04000F4E RID: 3918
		DangoBrawlLoseCountUpdateNotify = 26926,
		// Token: 0x04000F4F RID: 3919
		RoverRogueShopInfoUpdateNotify = 23170,
		// Token: 0x04000F50 RID: 3920
		BanItemUseNotify = 22869,
		// Token: 0x04000F51 RID: 3921
		TreasureChestCountNotify = 23149,
		// Token: 0x04000F52 RID: 3922
		DangoBrawlItemGiveCoinNotify = 26647,
		// Token: 0x04000F53 RID: 3923
		DangoBrawlItemEffectShowNotify = 15034,
		// Token: 0x04000F54 RID: 3924
		GameStatsShowRequest = 16656,
		// Token: 0x04000F55 RID: 3925
		GameStatsShowResponse = 18943,
		// Token: 0x04000F56 RID: 3926
		DangoBrawlActivityLimitCoinUpdateNotify = 25541,
		// Token: 0x04000F57 RID: 3927
		TreasureChestCountIncrementNotify = 25587,
		// Token: 0x04000F58 RID: 3928
		SelfPortraitStateRequest = 17018,
		// Token: 0x04000F59 RID: 3929
		SelfPortraitStateResponse = 28546,
		// Token: 0x04000F5A RID: 3930
		LoopTeleportVolumeActionRequest = 22884,
		// Token: 0x04000F5B RID: 3931
		LoopTeleportVolumeActionResponse = 25898,
		// Token: 0x04000F5C RID: 3932
		SolarSchoolTaskProgressRewardRequest = 22424,
		// Token: 0x04000F5D RID: 3933
		SolarSchoolTaskProgressRewardResponse = 18486,
		// Token: 0x04000F5E RID: 3934
		RoleTowerSaveDeleteRequest = 29169,
		// Token: 0x04000F5F RID: 3935
		RoleTowerSaveDeleteResponse = 15219,
		// Token: 0x04000F60 RID: 3936
		RoleTowerChallengeSettleRequest = 19036,
		// Token: 0x04000F61 RID: 3937
		RoleTowerChallengeSettleResponse = 18185,
		// Token: 0x04000F62 RID: 3938
		RoleTowerChallengeSettleNotify = 15085,
		// Token: 0x04000F63 RID: 3939
		RoleTowerRankRequest = 19891,
		// Token: 0x04000F64 RID: 3940
		RoleTowerRankResponse = 25174,
		// Token: 0x04000F65 RID: 3941
		RoleTowerRewardTaskReceiveRequest = 29411,
		// Token: 0x04000F66 RID: 3942
		RoleTowerRewardTaskReceiveResponse = 18563,
		// Token: 0x04000F67 RID: 3943
		RoleTowerScoreRewardReceiveRequest = 20934,
		// Token: 0x04000F68 RID: 3944
		RoleTowerScoreRewardReceiveResponse = 25210,
		// Token: 0x04000F69 RID: 3945
		RoleTowerRewardTaskUpdateNotify = 23293,
		// Token: 0x04000F6A RID: 3946
		RoleTowerScoreTaskUpdateNotify = 24764,
		// Token: 0x04000F6B RID: 3947
		RoleTowerChallengeUpdateNotify = 21751,
		// Token: 0x04000F6C RID: 3948
		RoleTowerTokenUpdateNotify = 18236,
		// Token: 0x04000F6D RID: 3949
		TeamRecommendRequest = 19191,
		// Token: 0x04000F6E RID: 3950
		TeamRecommendResponse = 16900,
		// Token: 0x04000F6F RID: 3951
		PhantomEquipGroupInfoNotify = 16384,
		// Token: 0x04000F70 RID: 3952
		RecallItemBagObtainNotify = 15236,
		// Token: 0x04000F71 RID: 3953
		DamageShowNotify = 16964,
		// Token: 0x04000F72 RID: 3954
		WellStreamingFinisRequest = 20746,
		// Token: 0x04000F73 RID: 3955
		WellStreamingFinisResponse = 24801,
		// Token: 0x04000F74 RID: 3956
		RecallItemRewardNotify = 27085,
		// Token: 0x04000F75 RID: 3957
		TimePointActivityBatchRewardRequest = 28173,
		// Token: 0x04000F76 RID: 3958
		TimePointActivityBatchRewardResponse = 15156,
		// Token: 0x04000F77 RID: 3959
		RoleTowerStepUpdateNotify = 25704,
		// Token: 0x04000F78 RID: 3960
		RoleTowerStepAdvanceRequest = 23562,
		// Token: 0x04000F79 RID: 3961
		RoleTowerStepAdvanceResponse = 28939,
		// Token: 0x04000F7A RID: 3962
		RoleTowerTimerDataUpdateNotify = 20667,
		// Token: 0x04000F7B RID: 3963
		RoleTowerTimerDurationUpdateNotify = 19870,
		// Token: 0x04000F7C RID: 3964
		RoleTowerStageSettleRequest = 23809,
		// Token: 0x04000F7D RID: 3965
		RoleTowerStageSettleResponse = 15371,
		// Token: 0x04000F7E RID: 3966
		RoleTowerStageRetryRequest = 28382,
		// Token: 0x04000F7F RID: 3967
		RoleTowerStageRetryResponse = 27529,
		// Token: 0x04000F80 RID: 3968
		RoleTowerScoreUpdateNotify = 28517,
		// Token: 0x04000F81 RID: 3969
		RoleTowerFloorSettleNotify = 22389,
		// Token: 0x04000F82 RID: 3970
		RoleTowerRankRewardReceiveRequest = 23829,
		// Token: 0x04000F83 RID: 3971
		RoleTowerRankRewardReceiveResponse = 24106,
		// Token: 0x04000F84 RID: 3972
		RoleTowerUnlockTokenUpdateNotify = 20373,
		// Token: 0x04000F85 RID: 3973
		AccessForceClosedAreaNotify = 27267,
		// Token: 0x04000F86 RID: 3974
		RoleTowerConsumeItemRequest = 17781,
		// Token: 0x04000F87 RID: 3975
		RoleTowerConsumeItemResponse = 16552,
		// Token: 0x04000F88 RID: 3976
		RoleTowerDieNotify = 26184,
		// Token: 0x04000F89 RID: 3977
		RoleTowerItemUpdateNotify = 23300,
		// Token: 0x04000F8A RID: 3978
		FollowerChairPresentationPush = 24462,
		// Token: 0x04000F8B RID: 3979
		FollowerChairPresentationChangeNotify = 29665,
		// Token: 0x04000F8C RID: 3980
		RecallInstSaveDataNotify = 22471,
		// Token: 0x04000F8D RID: 3981
		GuideGroupResetNotify = 29638,
		// Token: 0x04000F8E RID: 3982
		RoleTowerPhantomAddAttrsUpdateNotify = 26773,
		// Token: 0x04000F8F RID: 3983
		ServerConfigVersionInfoNotify = 28553,
		// Token: 0x04000F90 RID: 3984
		RoleTowerPhantomAddAttrsRequest = 29253,
		// Token: 0x04000F91 RID: 3985
		RoleTowerPhantomAddAttrsResponse = 25433,
		// Token: 0x04000F92 RID: 3986
		PostAkEventNotify = 19508,
		// Token: 0x04000F93 RID: 3987
		RoleTowerAttributeQueryRequest = 26515,
		// Token: 0x04000F94 RID: 3988
		RoleTowerAttributeQueryResponse = 29708
	}
}
