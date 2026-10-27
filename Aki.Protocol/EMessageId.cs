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
		AceAntiDataPush = 25028,
		// Token: 0x04000035 RID: 53
		AceAntiDataNotify = 28711,
		// Token: 0x04000036 RID: 54
		AchievementInfoRequest = 23322,
		// Token: 0x04000037 RID: 55
		AchievementInfoResponse = 26649,
		// Token: 0x04000038 RID: 56
		AchievementReceiveRequest = 16111,
		// Token: 0x04000039 RID: 57
		AchievementReceiveResponse = 22908,
		// Token: 0x0400003A RID: 58
		AchievementProgressNotify = 25834,
		// Token: 0x0400003B RID: 59
		AchievementListProgressNotify = 23250,
		// Token: 0x0400003C RID: 60
		AchievementGroupProgressNotify = 15821,
		// Token: 0x0400003D RID: 61
		AchievementFinishRequest = 16752,
		// Token: 0x0400003E RID: 62
		AchievementFinishResponse = 21914,
		// Token: 0x0400003F RID: 63
		ActionNotify = 24784,
		// Token: 0x04000040 RID: 64
		ActionErrorCodeNotify = 20519,
		// Token: 0x04000041 RID: 65
		ActionFinishRequest = 27144,
		// Token: 0x04000042 RID: 66
		ActionFinishResponse = 21915,
		// Token: 0x04000043 RID: 67
		GmLevelActionRequest = 15038,
		// Token: 0x04000044 RID: 68
		GmLevelActionResponse = 17916,
		// Token: 0x04000045 RID: 69
		OperationRestrictionNotify = 19069,
		// Token: 0x04000046 RID: 70
		ActivityRequest = 24675,
		// Token: 0x04000047 RID: 71
		ActivityResponse = 24041,
		// Token: 0x04000048 RID: 72
		ActivityFirstReadRequest = 21916,
		// Token: 0x04000049 RID: 73
		ActivityFirstReadResponse = 25958,
		// Token: 0x0400004A RID: 74
		ActivityUpdateNotify = 22413,
		// Token: 0x0400004B RID: 75
		ActivityDisableNotify = 18208,
		// Token: 0x0400004C RID: 76
		SignActivityRequest = 27564,
		// Token: 0x0400004D RID: 77
		SignActivityResponse = 18069,
		// Token: 0x0400004E RID: 78
		SignActivitySignStateNotify = 23272,
		// Token: 0x0400004F RID: 79
		SignActivityKeepTimeNotify = 20038,
		// Token: 0x04000050 RID: 80
		HarvestActivityPointRequest = 29278,
		// Token: 0x04000051 RID: 81
		HarvestActivityPointResponse = 22430,
		// Token: 0x04000052 RID: 82
		HarvestActivityLevelRequest = 23568,
		// Token: 0x04000053 RID: 83
		HarvestActivityLevelResponse = 15302,
		// Token: 0x04000054 RID: 84
		HarvestActivityLevelDiffRequest = 24064,
		// Token: 0x04000055 RID: 85
		HarvestActivityLevelDiffResponse = 15960,
		// Token: 0x04000056 RID: 86
		HarvestActivityPointNotify = 29118,
		// Token: 0x04000057 RID: 87
		HarvestActivityLevelNotify = 22544,
		// Token: 0x04000058 RID: 88
		HarvestActivityResultRequest = 16437,
		// Token: 0x04000059 RID: 89
		HarvestActivityResultResponse = 24362,
		// Token: 0x0400005A RID: 90
		HarvestActivityResultNotify = 28748,
		// Token: 0x0400005B RID: 91
		PhantomCollectReceiveRequest = 18117,
		// Token: 0x0400005C RID: 92
		PhantomCollectReceiveResponse = 23631,
		// Token: 0x0400005D RID: 93
		PhantomCollectUpdateNotify = 28121,
		// Token: 0x0400005E RID: 94
		AdventureManualDataRequest = 29621,
		// Token: 0x0400005F RID: 95
		AdventureManualDataResponse = 17876,
		// Token: 0x04000060 RID: 96
		GetAdventureRewardRequest = 27637,
		// Token: 0x04000061 RID: 97
		GetAdventureRewardResponse = 19480,
		// Token: 0x04000062 RID: 98
		GetChapterRewardRequest = 21975,
		// Token: 0x04000063 RID: 99
		GetChapterRewardResponse = 17302,
		// Token: 0x04000064 RID: 100
		DetectionRequest = 26178,
		// Token: 0x04000065 RID: 101
		DetectionResponse = 17538,
		// Token: 0x04000066 RID: 102
		AdventureUpdateNotify = 25180,
		// Token: 0x04000067 RID: 103
		AdventureManualRequest = 26238,
		// Token: 0x04000068 RID: 104
		AdventureManualResponse = 23292,
		// Token: 0x04000069 RID: 105
		ReceivedSilentFirstAwardRequest = 29881,
		// Token: 0x0400006A RID: 106
		ReceivedSilentFirstAwardResponse = 15246,
		// Token: 0x0400006B RID: 107
		SlientFirstAwardNotify = 18295,
		// Token: 0x0400006C RID: 108
		UpdateMonsterUnlockNotify = 22978,
		// Token: 0x0400006D RID: 109
		SelectDetectionTargetRequest = 28315,
		// Token: 0x0400006E RID: 110
		SelectDetectionTargetResponse = 22576,
		// Token: 0x0400006F RID: 111
		FollowDetectionTargetUpdateNotify = 26429,
		// Token: 0x04000070 RID: 112
		MonsterDetectionInfoRequest = 28081,
		// Token: 0x04000071 RID: 113
		MonsterDetectionInfoResponse = 22038,
		// Token: 0x04000072 RID: 114
		NormalMonsterManualInfoRequest = 21805,
		// Token: 0x04000073 RID: 115
		NormalMonsterManualInfoResponse = 23619,
		// Token: 0x04000074 RID: 116
		GetDetectionLabelInfoRequest = 15760,
		// Token: 0x04000075 RID: 117
		GetDetectionLabelInfoResponse = 24360,
		// Token: 0x04000076 RID: 118
		AddUnlockedGuideNotify = 23741,
		// Token: 0x04000077 RID: 119
		AddUnlockedDetectionTextNotify = 15632,
		// Token: 0x04000078 RID: 120
		AdviceSettingNotify = 18981,
		// Token: 0x04000079 RID: 121
		AdviceSetRequest = 17909,
		// Token: 0x0400007A RID: 122
		AdviceSetResponse = 27439,
		// Token: 0x0400007B RID: 123
		AdviceContentUpdateNotify = 26061,
		// Token: 0x0400007C RID: 124
		AdviceVoteUpdateNotify = 25803,
		// Token: 0x0400007D RID: 125
		AdviceRequest = 24258,
		// Token: 0x0400007E RID: 126
		AdviceResponse = 17200,
		// Token: 0x0400007F RID: 127
		AdviceUpdateNotify = 25178,
		// Token: 0x04000080 RID: 128
		AdviceCreateRequest = 16066,
		// Token: 0x04000081 RID: 129
		AdviceCreateResponse = 19595,
		// Token: 0x04000082 RID: 130
		AdviceModifyRequest = 17345,
		// Token: 0x04000083 RID: 131
		AdviceModifyResponse = 25965,
		// Token: 0x04000084 RID: 132
		AdviceDeleteRequest = 19569,
		// Token: 0x04000085 RID: 133
		AdviceDeleteResponse = 28461,
		// Token: 0x04000086 RID: 134
		AdviceVoteRequest = 26463,
		// Token: 0x04000087 RID: 135
		AdviceVoteResponse = 25631,
		// Token: 0x04000088 RID: 136
		AiInformationRequest = 27094,
		// Token: 0x04000089 RID: 137
		AiInformationResponse = 16509,
		// Token: 0x0400008A RID: 138
		AiInformationNotify = 27868,
		// Token: 0x0400008B RID: 139
		AiBlackboardsRequest = 17413,
		// Token: 0x0400008C RID: 140
		AiBlackboardsResponse = 23212,
		// Token: 0x0400008D RID: 141
		AiBlackboardCdRequest = 28767,
		// Token: 0x0400008E RID: 142
		AiBlackboardCdResponse = 24526,
		// Token: 0x0400008F RID: 143
		AiBlackboardCdNotify = 26627,
		// Token: 0x04000090 RID: 144
		AiHateRequest = 27946,
		// Token: 0x04000091 RID: 145
		AiHateResponse = 28446,
		// Token: 0x04000092 RID: 146
		AiHateNotify = 21698,
		// Token: 0x04000093 RID: 147
		AiControlSwitchRequest = 18300,
		// Token: 0x04000094 RID: 148
		AiControlSwitchResponse = 19656,
		// Token: 0x04000095 RID: 149
		AiControlSwitchNotify = 29617,
		// Token: 0x04000096 RID: 150
		PreAiControlSwitchNotify = 18803,
		// Token: 0x04000097 RID: 151
		EnterAreaRequest = 28495,
		// Token: 0x04000098 RID: 152
		EnterAreaResponse = 23858,
		// Token: 0x04000099 RID: 153
		BanChatNotify = 23311,
		// Token: 0x0400009A RID: 154
		ReportPlayerRequest = 25202,
		// Token: 0x0400009B RID: 155
		ReportPlayerResponse = 23940,
		// Token: 0x0400009C RID: 156
		PlayerRenameNotify = 17369,
		// Token: 0x0400009D RID: 157
		BasicInfoNotify = 15380,
		// Token: 0x0400009E RID: 158
		ModifyNameRequest = 20729,
		// Token: 0x0400009F RID: 159
		ModifyNameResponse = 29083,
		// Token: 0x040000A0 RID: 160
		ModifySignatureRequest = 21047,
		// Token: 0x040000A1 RID: 161
		ModifySignatureResponse = 19625,
		// Token: 0x040000A2 RID: 162
		ChangeHeadPhotoRequest = 17034,
		// Token: 0x040000A3 RID: 163
		ChangeHeadPhotoResponse = 20433,
		// Token: 0x040000A4 RID: 164
		UnlockHeadPhotoNotify = 29887,
		// Token: 0x040000A5 RID: 165
		UnlockHeadFrameNotify = 20396,
		// Token: 0x040000A6 RID: 166
		ClientBasicInfoRequest = 20137,
		// Token: 0x040000A7 RID: 167
		ClientBasicInfoResponse = 29135,
		// Token: 0x040000A8 RID: 168
		PlayerBasicInfoGetRequest = 19634,
		// Token: 0x040000A9 RID: 169
		PlayerBasicInfoGetResponse = 22549,
		// Token: 0x040000AA RID: 170
		BirthdayInitRequest = 25294,
		// Token: 0x040000AB RID: 171
		BirthdayInitResponse = 23451,
		// Token: 0x040000AC RID: 172
		RoleShowListUpdateRequest = 16909,
		// Token: 0x040000AD RID: 173
		RoleShowListUpdateResponse = 21892,
		// Token: 0x040000AE RID: 174
		HeadIdUpdateNotify = 17973,
		// Token: 0x040000AF RID: 175
		RoleShowListUpdateNotify = 27519,
		// Token: 0x040000B0 RID: 176
		ChangeCardRequest = 20690,
		// Token: 0x040000B1 RID: 177
		ChangeCardResponse = 28852,
		// Token: 0x040000B2 RID: 178
		ReadCardRequest = 18462,
		// Token: 0x040000B3 RID: 179
		ReadCardResponse = 25329,
		// Token: 0x040000B4 RID: 180
		UnlockCardNotify = 19442,
		// Token: 0x040000B5 RID: 181
		BirthdayShowSetRequest = 27587,
		// Token: 0x040000B6 RID: 182
		BirthdayShowSetResponse = 19338,
		// Token: 0x040000B7 RID: 183
		BattlePassRequest = 28338,
		// Token: 0x040000B8 RID: 184
		BattlePassResponse = 26818,
		// Token: 0x040000B9 RID: 185
		BattlePassPaidNotify = 17586,
		// Token: 0x040000BA RID: 186
		BattlePassTakeRewardRequest = 17354,
		// Token: 0x040000BB RID: 187
		BattlePassTakeRewardResponse = 16911,
		// Token: 0x040000BC RID: 188
		BattlePassRecurringTakeRequest = 26547,
		// Token: 0x040000BD RID: 189
		BattlePassRecurringTakeResponse = 22206,
		// Token: 0x040000BE RID: 190
		BattlePassTakeAllRewardRequest = 19919,
		// Token: 0x040000BF RID: 191
		BattlePassTakeAllRewardResponse = 28865,
		// Token: 0x040000C0 RID: 192
		BattlePassExpUpdateNotify = 21684,
		// Token: 0x040000C1 RID: 193
		BattlePassTaskRequest = 20446,
		// Token: 0x040000C2 RID: 194
		BattlePassTaskResponse = 21675,
		// Token: 0x040000C3 RID: 195
		BattlePassTaskUpdateNotify = 26276,
		// Token: 0x040000C4 RID: 196
		BattlePassTaskTakeRequest = 27478,
		// Token: 0x040000C5 RID: 197
		BattlePassTaskTakeResponse = 16270,
		// Token: 0x040000C6 RID: 198
		BattlePassEnterPush = 19788,
		// Token: 0x040000C7 RID: 199
		BattlePassLevelUpRequest = 28304,
		// Token: 0x040000C8 RID: 200
		BattlePassLevelUpResponse = 21544,
		// Token: 0x040000C9 RID: 201
		BehaviorTreeInfoNotify = 27985,
		// Token: 0x040000CA RID: 202
		BehaviorTreeDeleteNotify = 27847,
		// Token: 0x040000CB RID: 203
		UpdateNodeProgressNotify = 27949,
		// Token: 0x040000CC RID: 204
		UpdateChildQuestNodeStatusNotify = 20398,
		// Token: 0x040000CD RID: 205
		UpdateNodeStatusNotify = 18896,
		// Token: 0x040000CE RID: 206
		SubmitNodeRequest = 19815,
		// Token: 0x040000CF RID: 207
		SubmitNodeResponse = 22370,
		// Token: 0x040000D0 RID: 208
		HandInItemRequest = 22822,
		// Token: 0x040000D1 RID: 209
		HandInItemResponse = 26177,
		// Token: 0x040000D2 RID: 210
		BtSetTimerInfoRequest = 16825,
		// Token: 0x040000D3 RID: 211
		BtSetTimerInfoResponse = 26365,
		// Token: 0x040000D4 RID: 212
		BtSuspendNotify = 27231,
		// Token: 0x040000D5 RID: 213
		OccupationInfoNotify = 27173,
		// Token: 0x040000D6 RID: 214
		AddOccupationInfoNotify = 25073,
		// Token: 0x040000D7 RID: 215
		RemoveOccupationInfoNotify = 28337,
		// Token: 0x040000D8 RID: 216
		TimeOccupationNotify = 26393,
		// Token: 0x040000D9 RID: 217
		BtForcedOccupationRequest = 20760,
		// Token: 0x040000DA RID: 218
		BtForcedOccupationResponse = 20380,
		// Token: 0x040000DB RID: 219
		BtGiveUpRequest = 20571,
		// Token: 0x040000DC RID: 220
		BtGiveUpResponse = 23416,
		// Token: 0x040000DD RID: 221
		BtRollbackNotify = 29964,
		// Token: 0x040000DE RID: 222
		BtRollbackRequest = 27940,
		// Token: 0x040000DF RID: 223
		BtRollbackResponse = 25479,
		// Token: 0x040000E0 RID: 224
		BtRollbackStartNotify = 29608,
		// Token: 0x040000E1 RID: 225
		BtRollbackInfoNotify = 20660,
		// Token: 0x040000E2 RID: 226
		SneakRequest = 28095,
		// Token: 0x040000E3 RID: 227
		SneakResponse = 20692,
		// Token: 0x040000E4 RID: 228
		SneakTimeRequest = 24968,
		// Token: 0x040000E5 RID: 229
		SneakTimeResponse = 18825,
		// Token: 0x040000E6 RID: 230
		SneakNotify = 24240,
		// Token: 0x040000E7 RID: 231
		UpdateTimerInfoNotify = 28030,
		// Token: 0x040000E8 RID: 232
		TimerEndRequest = 15205,
		// Token: 0x040000E9 RID: 233
		TimerEndResponse = 27179,
		// Token: 0x040000EA RID: 234
		UiGamePlayRequest = 20564,
		// Token: 0x040000EB RID: 235
		UiGamePlayResponse = 18181,
		// Token: 0x040000EC RID: 236
		NpcTraceFailedRequest = 27353,
		// Token: 0x040000ED RID: 237
		NpcTraceFailedResponse = 26082,
		// Token: 0x040000EE RID: 238
		BtVarUpdateNotify = 17997,
		// Token: 0x040000EF RID: 239
		UpdateEnableSystemNotify = 25057,
		// Token: 0x040000F0 RID: 240
		WorldBlackboardRequest = 19106,
		// Token: 0x040000F1 RID: 241
		WorldBlackboardResponse = 23698,
		// Token: 0x040000F2 RID: 242
		WorldBlackboardNotify = 27748,
		// Token: 0x040000F3 RID: 243
		EntityBlackboardRequest = 15598,
		// Token: 0x040000F4 RID: 244
		EntityBlackboardResponse = 24947,
		// Token: 0x040000F5 RID: 245
		EntityBlackboardNotify = 16442,
		// Token: 0x040000F6 RID: 246
		BlockListRequest = 18290,
		// Token: 0x040000F7 RID: 247
		BlockListResponse = 16716,
		// Token: 0x040000F8 RID: 248
		BlockPlayerRequest = 16633,
		// Token: 0x040000F9 RID: 249
		BlockPlayerResponse = 21431,
		// Token: 0x040000FA RID: 250
		UnblockPlayerRequest = 16206,
		// Token: 0x040000FB RID: 251
		UnblockPlayerResponse = 27927,
		// Token: 0x040000FC RID: 252
		RemovePlacementFromBoardNotify = 19759,
		// Token: 0x040000FD RID: 253
		AddPlacementNotify = 17686,
		// Token: 0x040000FE RID: 254
		PlacementInfoChangeNotify = 24946,
		// Token: 0x040000FF RID: 255
		PlaceItemOnBoardRequest = 29265,
		// Token: 0x04000100 RID: 256
		PlaceItemOnBoardResponse = 18063,
		// Token: 0x04000101 RID: 257
		PlaceItemOnBoardNotify = 22990,
		// Token: 0x04000102 RID: 258
		CommitBoardRequest = 18174,
		// Token: 0x04000103 RID: 259
		CommitBoardResponse = 15817,
		// Token: 0x04000104 RID: 260
		CommitBoardSuccessNotify = 17294,
		// Token: 0x04000105 RID: 261
		MovePlacementRequest = 21717,
		// Token: 0x04000106 RID: 262
		MovePlacementResponse = 27133,
		// Token: 0x04000107 RID: 263
		MovePlacementNotify = 29257,
		// Token: 0x04000108 RID: 264
		BoardGridDynamicConfigChangeNotify = 29632,
		// Token: 0x04000109 RID: 265
		ApplyGameplayEffectRequest = 22973,
		// Token: 0x0400010A RID: 266
		ApplyGameplayEffectResponse = 22915,
		// Token: 0x0400010B RID: 267
		ApplyGameplayEffectNotify = 25830,
		// Token: 0x0400010C RID: 268
		RemoveGameplayEffectRequest = 19884,
		// Token: 0x0400010D RID: 269
		RemoveGameplayEffectResponse = 28077,
		// Token: 0x0400010E RID: 270
		RemoveGameplayEffectNotify = 18345,
		// Token: 0x0400010F RID: 271
		OrderApplyBuffRequest = 21800,
		// Token: 0x04000110 RID: 272
		OrderApplyBuffResponse = 27266,
		// Token: 0x04000111 RID: 273
		OrderRemoveBuffRequest = 29255,
		// Token: 0x04000112 RID: 274
		OrderRemoveBuffResponse = 17452,
		// Token: 0x04000113 RID: 275
		OrderApplyBuffNotify = 26471,
		// Token: 0x04000114 RID: 276
		OrderRemoveBuffNotify = 17807,
		// Token: 0x04000115 RID: 277
		ApplyBuffS2cRequestNotify = 18641,
		// Token: 0x04000116 RID: 278
		ApplyBuffS2cResponsePush = 16890,
		// Token: 0x04000117 RID: 279
		RemoveBuffS2cRequestNotify = 20022,
		// Token: 0x04000118 RID: 280
		RemoveBuffS2cResponsePush = 23971,
		// Token: 0x04000119 RID: 281
		RemoveBuffByIdS2cRequestNotify = 19482,
		// Token: 0x0400011A RID: 282
		RemoveBuffByIdS2cResponsePush = 19162,
		// Token: 0x0400011B RID: 283
		ActivateBuffRequest = 17149,
		// Token: 0x0400011C RID: 284
		ActivateBuffResponse = 19917,
		// Token: 0x0400011D RID: 285
		ActivateBuffNotify = 28221,
		// Token: 0x0400011E RID: 286
		OrderRemoveBuffByTagsRequest = 22742,
		// Token: 0x0400011F RID: 287
		OrderRemoveBuffByTagsResponse = 16551,
		// Token: 0x04000120 RID: 288
		OrderRemoveBuffByTagsNotify = 24520,
		// Token: 0x04000121 RID: 289
		BuffEffectExecuteRequest = 26094,
		// Token: 0x04000122 RID: 290
		BuffEffectExecuteResponse = 17533,
		// Token: 0x04000123 RID: 291
		BuffStackCountRequest = 19820,
		// Token: 0x04000124 RID: 292
		BuffStackCountResponse = 26251,
		// Token: 0x04000125 RID: 293
		BuffStackCountNotify = 29363,
		// Token: 0x04000126 RID: 294
		BuffEffectRequest = 22540,
		// Token: 0x04000127 RID: 295
		BuffEffectResponse = 16967,
		// Token: 0x04000128 RID: 296
		BuffItemRequest = 23217,
		// Token: 0x04000129 RID: 297
		BuffItemResponse = 22356,
		// Token: 0x0400012A RID: 298
		BuffItemNotify = 19044,
		// Token: 0x0400012B RID: 299
		BuffItemUpdateNotify = 28896,
		// Token: 0x0400012C RID: 300
		CalabashMsgNotify = 18974,
		// Token: 0x0400012D RID: 301
		CalabashMsgRequest = 22482,
		// Token: 0x0400012E RID: 302
		CalabashMsgResponse = 16706,
		// Token: 0x0400012F RID: 303
		CalabashExpAddNotify = 18431,
		// Token: 0x04000130 RID: 304
		CalabashDevelopRewardUnlockNotify = 19666,
		// Token: 0x04000131 RID: 305
		CalabashLevelsRewardNotify = 15335,
		// Token: 0x04000132 RID: 306
		CalabashLevelRewardRequest = 23794,
		// Token: 0x04000133 RID: 307
		CalabashLevelRewardResponse = 25587,
		// Token: 0x04000134 RID: 308
		CdKeyVerifyRequest = 27335,
		// Token: 0x04000135 RID: 309
		CdKeyVerifyResponse = 28544,
		// Token: 0x04000136 RID: 310
		ChatRequest = 27797,
		// Token: 0x04000137 RID: 311
		ChatResponse = 18241,
		// Token: 0x04000138 RID: 312
		ChatNotify = 29969,
		// Token: 0x04000139 RID: 313
		SysInfoNotify = 22193,
		// Token: 0x0400013A RID: 314
		SysErrorNotify = 16045,
		// Token: 0x0400013B RID: 315
		ConsoleNotify = 21407,
		// Token: 0x0400013C RID: 316
		PrivateChatRequest = 23483,
		// Token: 0x0400013D RID: 317
		PrivateChatResponse = 16640,
		// Token: 0x0400013E RID: 318
		PrivateMessageNotify = 24284,
		// Token: 0x0400013F RID: 319
		PrivateChatHistoryRequest = 23362,
		// Token: 0x04000140 RID: 320
		PrivateChatHistoryResponse = 29725,
		// Token: 0x04000141 RID: 321
		PrivateChatHistoryNotify = 24594,
		// Token: 0x04000142 RID: 322
		PrivateChatDataRequest = 16343,
		// Token: 0x04000143 RID: 323
		PrivateChatDataResponse = 19466,
		// Token: 0x04000144 RID: 324
		ChatMutePlayerRequest = 16226,
		// Token: 0x04000145 RID: 325
		ChatMutePlayerResponse = 26353,
		// Token: 0x04000146 RID: 326
		PrivateChatOperateRequest = 27275,
		// Token: 0x04000147 RID: 327
		PrivateChatOperateResponse = 16211,
		// Token: 0x04000148 RID: 328
		ChatMutePlayerListNotify = 18916,
		// Token: 0x04000149 RID: 329
		ChannelChatRequest = 19772,
		// Token: 0x0400014A RID: 330
		ChannelChatResponse = 18195,
		// Token: 0x0400014B RID: 331
		ChannelChatMessageNotify = 29952,
		// Token: 0x0400014C RID: 332
		ChannelChatHistoryNotify = 18271,
		// Token: 0x0400014D RID: 333
		CombatSendPackRequest = 19470,
		// Token: 0x0400014E RID: 334
		CombatSendPackResponse = 20332,
		// Token: 0x0400014F RID: 335
		CombatReceivePackNotify = 25706,
		// Token: 0x04000150 RID: 336
		CombatMaxCaseMessageRequest = 22467,
		// Token: 0x04000151 RID: 337
		CombatMaxCaseMessageResponse = 19109,
		// Token: 0x04000152 RID: 338
		PhotographPush = 26905,
		// Token: 0x04000153 RID: 339
		ControlInfoNotify = 22077,
		// Token: 0x04000154 RID: 340
		AddForbidControlNotify = 29379,
		// Token: 0x04000155 RID: 341
		RemoveForbidControlNotify = 27763,
		// Token: 0x04000156 RID: 342
		FixToolRequest = 18028,
		// Token: 0x04000157 RID: 343
		FixToolResponse = 23245,
		// Token: 0x04000158 RID: 344
		CookFormulaRequest = 20428,
		// Token: 0x04000159 RID: 345
		CookFormulaResponse = 25849,
		// Token: 0x0400015A RID: 346
		CookFoodRequest = 28222,
		// Token: 0x0400015B RID: 347
		CookFoodResponse = 23290,
		// Token: 0x0400015C RID: 348
		FoodProcessRequest = 18213,
		// Token: 0x0400015D RID: 349
		FoodProcessResponse = 25197,
		// Token: 0x0400015E RID: 350
		CertificateLevelRewardRequest = 16054,
		// Token: 0x0400015F RID: 351
		CertificateLevelRewardResponse = 20218,
		// Token: 0x04000160 RID: 352
		CookingInfoUpdateNotify = 18067,
		// Token: 0x04000161 RID: 353
		CookingFormulaUpdateNotify = 22353,
		// Token: 0x04000162 RID: 354
		CookingDataRequest = 22249,
		// Token: 0x04000163 RID: 355
		CookingDataResponse = 24521,
		// Token: 0x04000164 RID: 356
		InteractiveUpdateRequest = 19271,
		// Token: 0x04000165 RID: 357
		InteractiveUpdateResponse = 15988,
		// Token: 0x04000166 RID: 358
		DailyAdventureTaskUpdateNotify = 19886,
		// Token: 0x04000167 RID: 359
		DailyAdventurePtRewardRequest = 17854,
		// Token: 0x04000168 RID: 360
		DailyAdventurePtRewardResponse = 16430,
		// Token: 0x04000169 RID: 361
		DailyAdventureTaskRewardRequest = 15828,
		// Token: 0x0400016A RID: 362
		DailyAdventureTaskRewardResponse = 16686,
		// Token: 0x0400016B RID: 363
		CheatInputRequest = 26873,
		// Token: 0x0400016C RID: 364
		CheatInputResponse = 20265,
		// Token: 0x0400016D RID: 365
		DamageRecordNotify = 22979,
		// Token: 0x0400016E RID: 366
		EnableDamageRecordRequest = 25565,
		// Token: 0x0400016F RID: 367
		EnableDamageRecordResponse = 20429,
		// Token: 0x04000170 RID: 368
		GmVoxelInfoNotify = 26875,
		// Token: 0x04000171 RID: 369
		GmIsOverlapNotify = 25221,
		// Token: 0x04000172 RID: 370
		OutputDebugInfoRequest = 28615,
		// Token: 0x04000173 RID: 371
		OutputDebugInfoResponse = 25805,
		// Token: 0x04000174 RID: 372
		DropInBagNotify = 21527,
		// Token: 0x04000175 RID: 373
		PickUpDropItemRequest = 24705,
		// Token: 0x04000176 RID: 374
		PickUpDropItemResponse = 22257,
		// Token: 0x04000177 RID: 375
		ElevatorStateChangeRequest = 23005,
		// Token: 0x04000178 RID: 376
		ElevatorStateChangeResponse = 16901,
		// Token: 0x04000179 RID: 377
		ElevatorMoveNotify = 17500,
		// Token: 0x0400017A RID: 378
		EnergyUpdateNotify = 19527,
		// Token: 0x0400017B RID: 379
		EnergySyncRequest = 24596,
		// Token: 0x0400017C RID: 380
		EnergySyncResponse = 18125,
		// Token: 0x0400017D RID: 381
		ChangeStateRequest = 25799,
		// Token: 0x0400017E RID: 382
		ChangeStateResponse = 27097,
		// Token: 0x0400017F RID: 383
		ChangeStateNotify = 21371,
		// Token: 0x04000180 RID: 384
		ChangeStateConfirmRequest = 27052,
		// Token: 0x04000181 RID: 385
		ChangeStateConfirmResponse = 23779,
		// Token: 0x04000182 RID: 386
		ChangeStateConfirmNotify = 20811,
		// Token: 0x04000183 RID: 387
		FsmConditionPassRequest = 22886,
		// Token: 0x04000184 RID: 388
		FsmConditionPassResponse = 27979,
		// Token: 0x04000185 RID: 389
		FsmResetNotify = 16867,
		// Token: 0x04000186 RID: 390
		FsmBlackboardNotify = 18761,
		// Token: 0x04000187 RID: 391
		FsmCustomBlackboardNotify = 19239,
		// Token: 0x04000188 RID: 392
		GmEntityFsmGroupInfoRequest = 22037,
		// Token: 0x04000189 RID: 393
		GmEntityFsmGroupInfoResponse = 15216,
		// Token: 0x0400018A RID: 394
		EntityAddNotify = 25185,
		// Token: 0x0400018B RID: 395
		EntityRemoveNotify = 17769,
		// Token: 0x0400018C RID: 396
		CommonOrganActionListNotify = 26803,
		// Token: 0x0400018D RID: 397
		TestSpawnTemplateEntityPush = 19647,
		// Token: 0x0400018E RID: 398
		EntranceStateNotify = 25077,
		// Token: 0x0400018F RID: 399
		EntityBuffProducerRequest = 18682,
		// Token: 0x04000190 RID: 400
		EntityBuffProducerResponse = 22006,
		// Token: 0x04000191 RID: 401
		EntityBuffProducerOperateRequest = 26503,
		// Token: 0x04000192 RID: 402
		EntityBuffProducerOperateResponse = 27203,
		// Token: 0x04000193 RID: 403
		LogicStateInitRequest = 26172,
		// Token: 0x04000194 RID: 404
		LogicStateInitResponse = 25241,
		// Token: 0x04000195 RID: 405
		LogicStateInitNotify = 24779,
		// Token: 0x04000196 RID: 406
		SwitchLogicStateRequest = 18438,
		// Token: 0x04000197 RID: 407
		SwitchLogicStateResponse = 25754,
		// Token: 0x04000198 RID: 408
		SwitchLogicStateNotify = 19887,
		// Token: 0x04000199 RID: 409
		EntityActiveRequest = 28481,
		// Token: 0x0400019A RID: 410
		EntityActiveResponse = 26702,
		// Token: 0x0400019B RID: 411
		AnimationGameplayTagRequest = 25863,
		// Token: 0x0400019C RID: 412
		AnimationGameplayTagResponse = 20718,
		// Token: 0x0400019D RID: 413
		AnimationGameplayTagNotify = 17636,
		// Token: 0x0400019E RID: 414
		AnimalDieRequest = 21599,
		// Token: 0x0400019F RID: 415
		AnimalDieResponse = 22932,
		// Token: 0x040001A0 RID: 416
		AnimalDieNotify = 28384,
		// Token: 0x040001A1 RID: 417
		AnimalDestroyRequest = 16245,
		// Token: 0x040001A2 RID: 418
		AnimalDestroyResponse = 26691,
		// Token: 0x040001A3 RID: 419
		AnimalDropRequest = 29107,
		// Token: 0x040001A4 RID: 420
		AnimalDropResponse = 25751,
		// Token: 0x040001A5 RID: 421
		EntityStateReadyNotify = 23517,
		// Token: 0x040001A6 RID: 422
		EntityInteractRequest = 18643,
		// Token: 0x040001A7 RID: 423
		EntityInteractResponse = 29908,
		// Token: 0x040001A8 RID: 424
		EntityRandomInteractRequest = 23187,
		// Token: 0x040001A9 RID: 425
		EntityRandomInteractResponse = 20654,
		// Token: 0x040001AA RID: 426
		EntityDynamicInteractRequest = 18350,
		// Token: 0x040001AB RID: 427
		EntityDynamicInteractResponse = 17030,
		// Token: 0x040001AC RID: 428
		EntityAddDynamicInteractNotify = 26347,
		// Token: 0x040001AD RID: 429
		EntityChangeDynamicInteractTextNotify = 23782,
		// Token: 0x040001AE RID: 430
		EntityRemoveDynamicInteractNotify = 19212,
		// Token: 0x040001AF RID: 431
		EntityInteractingNotify = 29944,
		// Token: 0x040001B0 RID: 432
		EntityAddBubbleNotify = 21249,
		// Token: 0x040001B1 RID: 433
		EntityRemoveBubbleNotify = 20077,
		// Token: 0x040001B2 RID: 434
		EntityPosAbnormalRequest = 26606,
		// Token: 0x040001B3 RID: 435
		EntityPosAbnormalResponse = 21848,
		// Token: 0x040001B4 RID: 436
		EntityAdsorbRequest = 16297,
		// Token: 0x040001B5 RID: 437
		EntityAdsorbResponse = 25318,
		// Token: 0x040001B6 RID: 438
		BoneVisibleChangeRequest = 20124,
		// Token: 0x040001B7 RID: 439
		BoneVisibleChangeResponse = 20334,
		// Token: 0x040001B8 RID: 440
		BoneVisibleChangeNotify = 16295,
		// Token: 0x040001B9 RID: 441
		EntityEquipChangeNotify = 16817,
		// Token: 0x040001BA RID: 442
		EntityStaticHookMoveRequest = 18356,
		// Token: 0x040001BB RID: 443
		EntityStaticHookMoveResponse = 24175,
		// Token: 0x040001BC RID: 444
		EntityStaticHookMoveNotify = 26938,
		// Token: 0x040001BD RID: 445
		SilenceNpcNotify = 21690,
		// Token: 0x040001BE RID: 446
		EntityPatrolStartRequest = 29907,
		// Token: 0x040001BF RID: 447
		EntityPatrolStartResponse = 23660,
		// Token: 0x040001C0 RID: 448
		EntityPatrolStopRequest = 27475,
		// Token: 0x040001C1 RID: 449
		EntityPatrolStopResponse = 23618,
		// Token: 0x040001C2 RID: 450
		EntityPatrolChangeDirRequest = 26382,
		// Token: 0x040001C3 RID: 451
		EntityPatrolChangeDirResponse = 23851,
		// Token: 0x040001C4 RID: 452
		VfxNpcPatrolFinishRequest = 17617,
		// Token: 0x040001C5 RID: 453
		VfxNpcPatrolFinishResponse = 19912,
		// Token: 0x040001C6 RID: 454
		EntitySendEventRequest = 20081,
		// Token: 0x040001C7 RID: 455
		EntitySendEventResponse = 25789,
		// Token: 0x040001C8 RID: 456
		AccessPasserbyNpcSpawnerRequest = 29764,
		// Token: 0x040001C9 RID: 457
		AccessPasserbyNpcSpawnerResponse = 25897,
		// Token: 0x040001CA RID: 458
		ExploreProgressRequest = 19237,
		// Token: 0x040001CB RID: 459
		ExploreProgressResponse = 26475,
		// Token: 0x040001CC RID: 460
		ExploreScoreRewardRequest = 22561,
		// Token: 0x040001CD RID: 461
		ExploreScoreRewardResponse = 16181,
		// Token: 0x040001CE RID: 462
		CountryExploreScoreInfoRequest = 25855,
		// Token: 0x040001CF RID: 463
		CountryExploreScoreInfoResponse = 19799,
		// Token: 0x040001D0 RID: 464
		ExploreLevelNotify = 26692,
		// Token: 0x040001D1 RID: 465
		ExploreToolUpdateNotify = 27860,
		// Token: 0x040001D2 RID: 466
		ExploreToolAllNotify = 27129,
		// Token: 0x040001D3 RID: 467
		ExploreSkillRouletteUpdateNotify = 25292,
		// Token: 0x040001D4 RID: 468
		VisionExploreSkillSetRequest = 23633,
		// Token: 0x040001D5 RID: 469
		VisionExploreSkillSetResponse = 18650,
		// Token: 0x040001D6 RID: 470
		VisionExploreSkillNotify = 15314,
		// Token: 0x040001D7 RID: 471
		ExploreSkillRouletteSetRequest = 25875,
		// Token: 0x040001D8 RID: 472
		ExploreSkillRouletteSetResponse = 24039,
		// Token: 0x040001D9 RID: 473
		ExploreSkillPullGiantRequest = 26996,
		// Token: 0x040001DA RID: 474
		ExploreSkillPullGiantResponse = 27102,
		// Token: 0x040001DB RID: 475
		UseDetectionSkillRequest = 16737,
		// Token: 0x040001DC RID: 476
		UseDetectionSkillResponse = 29685,
		// Token: 0x040001DD RID: 477
		ExploreToolAuthorizationNotify = 18264,
		// Token: 0x040001DE RID: 478
		SetFanNumberOfTurnsRequest = 28291,
		// Token: 0x040001DF RID: 479
		SetFanNumberOfTurnsResponse = 27529,
		// Token: 0x040001E0 RID: 480
		SetBaoziStateRequest = 18278,
		// Token: 0x040001E1 RID: 481
		SetBaoziStateResponse = 19707,
		// Token: 0x040001E2 RID: 482
		SetFanStateRequest = 19934,
		// Token: 0x040001E3 RID: 483
		SetFanStateResponse = 23657,
		// Token: 0x040001E4 RID: 484
		RoleFavorListRequest = 28257,
		// Token: 0x040001E5 RID: 485
		RoleFavorListResponse = 24905,
		// Token: 0x040001E6 RID: 486
		RoleFavorListNotify = 19733,
		// Token: 0x040001E7 RID: 487
		RoleFavorActiveNotify = 26927,
		// Token: 0x040001E8 RID: 488
		RoleFavorLevelUpdateNotify = 23198,
		// Token: 0x040001E9 RID: 489
		RoleFavorNewCanUnLockNotify = 17127,
		// Token: 0x040001EA RID: 490
		RoleFavorExpTipsNotify = 28482,
		// Token: 0x040001EB RID: 491
		RoleFavorFinishConditionNotify = 29435,
		// Token: 0x040001EC RID: 492
		RoleFavorUnLockRequest = 28764,
		// Token: 0x040001ED RID: 493
		RoleFavorUnLockResponse = 20728,
		// Token: 0x040001EE RID: 494
		RoleFavorNewQuestUpdateNotify = 27058,
		// Token: 0x040001EF RID: 495
		RoleFavorAcceptQuestRequest = 18026,
		// Token: 0x040001F0 RID: 496
		RoleFavorAcceptQuestResponse = 29317,
		// Token: 0x040001F1 RID: 497
		RoleFavorTalkScoreRequest = 22288,
		// Token: 0x040001F2 RID: 498
		RoleFavorTalkScoreResponse = 17643,
		// Token: 0x040001F3 RID: 499
		RoleMotionUnLockRequest = 22268,
		// Token: 0x040001F4 RID: 500
		RoleMotionUnLockResponse = 28146,
		// Token: 0x040001F5 RID: 501
		RoleMotionNewCanUnLockNotify = 21957,
		// Token: 0x040001F6 RID: 502
		RoleMotionActiveNotify = 22861,
		// Token: 0x040001F7 RID: 503
		RoleMotionListNotify = 16513,
		// Token: 0x040001F8 RID: 504
		RoleMotionFinishConditionNotify = 20870,
		// Token: 0x040001F9 RID: 505
		SkillRequest = 29518,
		// Token: 0x040001FA RID: 506
		SkillResponse = 20499,
		// Token: 0x040001FB RID: 507
		SkillNotify = 20156,
		// Token: 0x040001FC RID: 508
		UseSkillRequest = 21005,
		// Token: 0x040001FD RID: 509
		UseSkillResponse = 28239,
		// Token: 0x040001FE RID: 510
		UseSkillNotify = 20528,
		// Token: 0x040001FF RID: 511
		EndSkillRequest = 24580,
		// Token: 0x04000200 RID: 512
		EndSkillResponse = 29159,
		// Token: 0x04000201 RID: 513
		EndSkillNotify = 25131,
		// Token: 0x04000202 RID: 514
		InterruptSkillInDelayRequest = 17561,
		// Token: 0x04000203 RID: 515
		InterruptSkillInDelayResponse = 15726,
		// Token: 0x04000204 RID: 516
		UseSkillFailRequest = 22140,
		// Token: 0x04000205 RID: 517
		UseSkillFailResponse = 28988,
		// Token: 0x04000206 RID: 518
		HitRequest = 15093,
		// Token: 0x04000207 RID: 519
		HitResponse = 16481,
		// Token: 0x04000208 RID: 520
		HitNotify = 27776,
		// Token: 0x04000209 RID: 521
		HitEndRequest = 25554,
		// Token: 0x0400020A RID: 522
		HitEndResponse = 28059,
		// Token: 0x0400020B RID: 523
		CaughtRequest = 21766,
		// Token: 0x0400020C RID: 524
		CaughtResponse = 17589,
		// Token: 0x0400020D RID: 525
		CaughtNotify = 17797,
		// Token: 0x0400020E RID: 526
		CreateBulletRequest = 16833,
		// Token: 0x0400020F RID: 527
		CreateBulletResponse = 20162,
		// Token: 0x04000210 RID: 528
		CreateBulletNotify = 29868,
		// Token: 0x04000211 RID: 529
		DestroyBulletRequest = 26218,
		// Token: 0x04000212 RID: 530
		DestroyBulletResponse = 22475,
		// Token: 0x04000213 RID: 531
		DestroyBulletNotify = 16776,
		// Token: 0x04000214 RID: 532
		ModifyBulletParamsRequest = 16767,
		// Token: 0x04000215 RID: 533
		ModifyBulletParamsResponse = 21100,
		// Token: 0x04000216 RID: 534
		ModifyBulletParamsNotify = 17666,
		// Token: 0x04000217 RID: 535
		DamageExecuteRequest = 22022,
		// Token: 0x04000218 RID: 536
		DamageExecuteResponse = 22796,
		// Token: 0x04000219 RID: 537
		DamageExecuteNotify = 28964,
		// Token: 0x0400021A RID: 538
		PassiveSkillAddRequest = 23740,
		// Token: 0x0400021B RID: 539
		PassiveSkillAddResponse = 20187,
		// Token: 0x0400021C RID: 540
		PassiveSkillRemoveRequest = 21925,
		// Token: 0x0400021D RID: 541
		PassiveSkillRemoveResponse = 20593,
		// Token: 0x0400021E RID: 542
		PassiveSkillAddNotify = 22690,
		// Token: 0x0400021F RID: 543
		PassiveSkillRemoveNotify = 22034,
		// Token: 0x04000220 RID: 544
		EnterViewDirectionRequest = 18587,
		// Token: 0x04000221 RID: 545
		EnterViewDirectionResponse = 26211,
		// Token: 0x04000222 RID: 546
		ExitViewDirectionRequest = 25488,
		// Token: 0x04000223 RID: 547
		ExitViewDirectionResponse = 20227,
		// Token: 0x04000224 RID: 548
		TriggerExitSkillRequest = 29898,
		// Token: 0x04000225 RID: 549
		TriggerExitSkillResponse = 22190,
		// Token: 0x04000226 RID: 550
		CharacterDeathPush = 16870,
		// Token: 0x04000227 RID: 551
		CharacterDeathRequest = 27163,
		// Token: 0x04000228 RID: 552
		CharacterDeathResponse = 22581,
		// Token: 0x04000229 RID: 553
		InstFightEndPush = 27255,
		// Token: 0x0400022A RID: 554
		SwitchBattleModeRequest = 24463,
		// Token: 0x0400022B RID: 555
		SwitchBattleModeResponse = 26064,
		// Token: 0x0400022C RID: 556
		SwitchBattleModeNotify = 24226,
		// Token: 0x0400022D RID: 557
		BattleLogNotify = 29071,
		// Token: 0x0400022E RID: 558
		LandingDamageRequest = 23415,
		// Token: 0x0400022F RID: 559
		LandingDamageResponse = 29437,
		// Token: 0x04000230 RID: 560
		EntityIsVisibleRequest = 24121,
		// Token: 0x04000231 RID: 561
		EntityIsVisibleResponse = 27951,
		// Token: 0x04000232 RID: 562
		EntityIsVisibleNotify = 17405,
		// Token: 0x04000233 RID: 563
		ActorVisibleRequest = 20487,
		// Token: 0x04000234 RID: 564
		ActorVisibleResponse = 29481,
		// Token: 0x04000235 RID: 565
		ActorVisibleNotify = 23346,
		// Token: 0x04000236 RID: 566
		SwitchCharacterStateRequest = 27567,
		// Token: 0x04000237 RID: 567
		SwitchCharacterStateResponse = 24015,
		// Token: 0x04000238 RID: 568
		SwitchCharacterStateNotify = 15678,
		// Token: 0x04000239 RID: 569
		BattleStateChangeRequest = 19661,
		// Token: 0x0400023A RID: 570
		BattleStateChangeResponse = 27150,
		// Token: 0x0400023B RID: 571
		BattleStateChangeNotify = 22142,
		// Token: 0x0400023C RID: 572
		ToughCalcExtraRatioChangeRequest = 23954,
		// Token: 0x0400023D RID: 573
		ToughCalcExtraRatioChangeResponse = 18566,
		// Token: 0x0400023E RID: 574
		MonsterBoomRequest = 27664,
		// Token: 0x0400023F RID: 575
		MonsterBoomResponse = 23701,
		// Token: 0x04000240 RID: 576
		EntityBattleInfoRequest = 17230,
		// Token: 0x04000241 RID: 577
		EntityBattleInfoResponse = 24276,
		// Token: 0x04000242 RID: 578
		MontagePlayRequest = 22974,
		// Token: 0x04000243 RID: 579
		MontagePlayResponse = 23384,
		// Token: 0x04000244 RID: 580
		MontagePlayNotify = 17788,
		// Token: 0x04000245 RID: 581
		ANStartRequest = 23064,
		// Token: 0x04000246 RID: 582
		ANStartResponse = 15208,
		// Token: 0x04000247 RID: 583
		ANStartNotify = 24660,
		// Token: 0x04000248 RID: 584
		CharacterBattleStateChangeNotify = 25768,
		// Token: 0x04000249 RID: 585
		PlayerBattleStateChangeNotify = 25044,
		// Token: 0x0400024A RID: 586
		ShieldUpdateNotify = 26592,
		// Token: 0x0400024B RID: 587
		SwitchRoleRequest = 20789,
		// Token: 0x0400024C RID: 588
		SwitchRoleResponse = 16059,
		// Token: 0x0400024D RID: 589
		SwitchRoleNotify = 21436,
		// Token: 0x0400024E RID: 590
		DieSwitchRoleNotify = 28430,
		// Token: 0x0400024F RID: 591
		UpdateFormationRequest = 18636,
		// Token: 0x04000250 RID: 592
		UpdateFormationResponse = 25651,
		// Token: 0x04000251 RID: 593
		UpdateFormationNotify = 23626,
		// Token: 0x04000252 RID: 594
		UpdateFightRoleRequest = 26624,
		// Token: 0x04000253 RID: 595
		UpdateFightRoleResponse = 18693,
		// Token: 0x04000254 RID: 596
		FormationAutoAddRoleNotify = 24318,
		// Token: 0x04000255 RID: 597
		GetFormationDataRequest = 17698,
		// Token: 0x04000256 RID: 598
		GetFormationDataResponse = 22433,
		// Token: 0x04000257 RID: 599
		FormationUpdateNotify = 16510,
		// Token: 0x04000258 RID: 600
		FlowStartNotify = 23786,
		// Token: 0x04000259 RID: 601
		FlowEndRequest = 16032,
		// Token: 0x0400025A RID: 602
		FlowEndResponse = 24390,
		// Token: 0x0400025B RID: 603
		FlowEndNotify = 22237,
		// Token: 0x0400025C RID: 604
		FlowRestartRequest = 24934,
		// Token: 0x0400025D RID: 605
		FlowRestartResponse = 27398,
		// Token: 0x0400025E RID: 606
		FlowActionRequest = 21156,
		// Token: 0x0400025F RID: 607
		FlowActionResponse = 21929,
		// Token: 0x04000260 RID: 608
		FlowShowEntityNotify = 21334,
		// Token: 0x04000261 RID: 609
		ShowPasserByNpcNotify = 24738,
		// Token: 0x04000262 RID: 610
		FlowServerSkipNotify = 21461,
		// Token: 0x04000263 RID: 611
		ForgeInfoRequest = 23896,
		// Token: 0x04000264 RID: 612
		ForgeInfoResponse = 28293,
		// Token: 0x04000265 RID: 613
		ForgeItemRequest = 22375,
		// Token: 0x04000266 RID: 614
		ForgeItemResponse = 27784,
		// Token: 0x04000267 RID: 615
		ForgeItemInfoUpdateNotify = 18614,
		// Token: 0x04000268 RID: 616
		ForgeFormulaUnlockRequest = 21366,
		// Token: 0x04000269 RID: 617
		ForgeFormulaUnlockResponse = 18480,
		// Token: 0x0400026A RID: 618
		FormationRequest = 23200,
		// Token: 0x0400026B RID: 619
		FormationResponse = 18151,
		// Token: 0x0400026C RID: 620
		FormationSwitchCurrentRequest = 20059,
		// Token: 0x0400026D RID: 621
		FormationSwitchCurrentResponse = 15112,
		// Token: 0x0400026E RID: 622
		FormationModifyRequest = 21924,
		// Token: 0x0400026F RID: 623
		FormationModifyResponse = 25309,
		// Token: 0x04000270 RID: 624
		FormationChangeRequest = 28405,
		// Token: 0x04000271 RID: 625
		FormationChangeResponse = 22944,
		// Token: 0x04000272 RID: 626
		FormationSwitchRoleRequest = 27304,
		// Token: 0x04000273 RID: 627
		FormationSwitchRoleResponse = 23668,
		// Token: 0x04000274 RID: 628
		PbFormationAutoAddRoleNotify = 17889,
		// Token: 0x04000275 RID: 629
		PhantomFormationChangeNotify = 28651,
		// Token: 0x04000276 RID: 630
		ClientCurrentRoleReportRequest = 27281,
		// Token: 0x04000277 RID: 631
		ClientCurrentRoleReportResponse = 24285,
		// Token: 0x04000278 RID: 632
		FriendAllRequest = 16982,
		// Token: 0x04000279 RID: 633
		FriendAllResponse = 17252,
		// Token: 0x0400027A RID: 634
		FriendAddedNotify = 28906,
		// Token: 0x0400027B RID: 635
		FriendDeletedNotify = 25733,
		// Token: 0x0400027C RID: 636
		FriendApplyReceivedNotify = 17851,
		// Token: 0x0400027D RID: 637
		FriendApplyDeletedNotify = 25186,
		// Token: 0x0400027E RID: 638
		FriendApplySendRequest = 16030,
		// Token: 0x0400027F RID: 639
		FriendApplySendResponse = 19754,
		// Token: 0x04000280 RID: 640
		FriendApplyHandleRequest = 24797,
		// Token: 0x04000281 RID: 641
		FriendApplyHandleResponse = 23606,
		// Token: 0x04000282 RID: 642
		FriendRemarkRequest = 23751,
		// Token: 0x04000283 RID: 643
		FriendRemarkResponse = 20061,
		// Token: 0x04000284 RID: 644
		FriendDeleteRequest = 23712,
		// Token: 0x04000285 RID: 645
		FriendDeleteResponse = 29748,
		// Token: 0x04000286 RID: 646
		FriendRecentlyTeamRequest = 15455,
		// Token: 0x04000287 RID: 647
		FriendRecentlyTeamResponse = 18777,
		// Token: 0x04000288 RID: 648
		FriendRecentlyTeamUpdateNotify = 17712,
		// Token: 0x04000289 RID: 649
		FuncOpenNotify = 23390,
		// Token: 0x0400028A RID: 650
		FuncOpenConfirmNotify = 24775,
		// Token: 0x0400028B RID: 651
		FuncOpenUpdateNotify = 16322,
		// Token: 0x0400028C RID: 652
		FuncShowRequest = 15710,
		// Token: 0x0400028D RID: 653
		FuncShowResponse = 21886,
		// Token: 0x0400028E RID: 654
		GachaInfoRequest = 28888,
		// Token: 0x0400028F RID: 655
		GachaInfoResponse = 18695,
		// Token: 0x04000290 RID: 656
		GachaRequest = 25270,
		// Token: 0x04000291 RID: 657
		GachaResponse = 19056,
		// Token: 0x04000292 RID: 658
		GachaResultNotify = 26700,
		// Token: 0x04000293 RID: 659
		GachaUsePoolRequest = 21879,
		// Token: 0x04000294 RID: 660
		GachaUsePoolResponse = 25952,
		// Token: 0x04000295 RID: 661
		GatherTaskRecordNotify = 25315,
		// Token: 0x04000296 RID: 662
		GatherClueInfoNotify = 22089,
		// Token: 0x04000297 RID: 663
		SubmitItemInfoNotify = 22231,
		// Token: 0x04000298 RID: 664
		GatherActivityRewardRequest = 24573,
		// Token: 0x04000299 RID: 665
		GatherActivityRewardResponse = 20681,
		// Token: 0x0400029A RID: 666
		GuideInfoRequest = 17498,
		// Token: 0x0400029B RID: 667
		GuideInfoResponse = 23730,
		// Token: 0x0400029C RID: 668
		GuideTriggerRequest = 28091,
		// Token: 0x0400029D RID: 669
		GuideTriggerResponse = 25821,
		// Token: 0x0400029E RID: 670
		GuideFinishRequest = 23117,
		// Token: 0x0400029F RID: 671
		GuideFinishResponse = 25597,
		// Token: 0x040002A0 RID: 672
		GuideCondDoneNotify = 16087,
		// Token: 0x040002A1 RID: 673
		HeartbeatRequest = 1650,
		// Token: 0x040002A2 RID: 674
		HeartbeatResponse,
		// Token: 0x040002A3 RID: 675
		GatewayEchoRequest = 28532,
		// Token: 0x040002A4 RID: 676
		GatewayEchoResponse = 21290,
		// Token: 0x040002A5 RID: 677
		IllustratedRedDotRequest = 25943,
		// Token: 0x040002A6 RID: 678
		IllustratedRedDotResponse = 15199,
		// Token: 0x040002A7 RID: 679
		IllustratedInfoRequest = 17985,
		// Token: 0x040002A8 RID: 680
		IllustratedInfoResponse = 24603,
		// Token: 0x040002A9 RID: 681
		IllustratedUnlockRequest = 20120,
		// Token: 0x040002AA RID: 682
		IllustratedUnlockResponse = 18471,
		// Token: 0x040002AB RID: 683
		IllustratedUnlockNotify = 23144,
		// Token: 0x040002AC RID: 684
		IllustratedReadRequest = 26576,
		// Token: 0x040002AD RID: 685
		IllustratedReadResponse = 20958,
		// Token: 0x040002AE RID: 686
		InfluenceInfoRequest = 25529,
		// Token: 0x040002AF RID: 687
		InfluenceInfoResponse = 29322,
		// Token: 0x040002B0 RID: 688
		InfluenceInfoUpdateNotify = 23919,
		// Token: 0x040002B1 RID: 689
		InfluenceRewardRequest = 16109,
		// Token: 0x040002B2 RID: 690
		InfluenceRewardResponse = 26210,
		// Token: 0x040002B3 RID: 691
		ReadDisplayInfoRequest = 17532,
		// Token: 0x040002B4 RID: 692
		ReadDisplayInfoResponse = 21345,
		// Token: 0x040002B5 RID: 693
		InstDataNotify = 27555,
		// Token: 0x040002B6 RID: 694
		UpdateEnterInfoNotify = 26418,
		// Token: 0x040002B7 RID: 695
		EnterInstRequest = 17431,
		// Token: 0x040002B8 RID: 696
		EnterInstResponse = 19352,
		// Token: 0x040002B9 RID: 697
		UnlockInstEntranceRequest = 19928,
		// Token: 0x040002BA RID: 698
		UnlockInstEntranceResponse = 29172,
		// Token: 0x040002BB RID: 699
		InstEntranceDetailRequest = 24602,
		// Token: 0x040002BC RID: 700
		InstEntranceDetailResponse = 25904,
		// Token: 0x040002BD RID: 701
		LeaveInstRequest = 28370,
		// Token: 0x040002BE RID: 702
		LeaveInstResponse = 21587,
		// Token: 0x040002BF RID: 703
		InstPlayDataNotify = 15456,
		// Token: 0x040002C0 RID: 704
		GetInstExchangeRewardRequest = 25650,
		// Token: 0x040002C1 RID: 705
		GetInstExchangeRewardResponse = 21421,
		// Token: 0x040002C2 RID: 706
		InstSettleNotify = 18806,
		// Token: 0x040002C3 RID: 707
		InstResultNotify = 15136,
		// Token: 0x040002C4 RID: 708
		ExchangeRewardInfoRequest = 26002,
		// Token: 0x040002C5 RID: 709
		ExchangeRewardInfoResponse = 28025,
		// Token: 0x040002C6 RID: 710
		ExchangeRewardInfoNotify = 20442,
		// Token: 0x040002C7 RID: 711
		ExchangeSharedInfoNotify = 22397,
		// Token: 0x040002C8 RID: 712
		InstTimeoutNotify = 21516,
		// Token: 0x040002C9 RID: 713
		SingleInstRechallengeRequest = 19217,
		// Token: 0x040002CA RID: 714
		SingleInstRechallengeResponse = 21069,
		// Token: 0x040002CB RID: 715
		ItemDecomposeRequest = 16771,
		// Token: 0x040002CC RID: 716
		ItemDecomposeResponse = 23183,
		// Token: 0x040002CD RID: 717
		ItemDecomposePreviewRequest = 27713,
		// Token: 0x040002CE RID: 718
		ItemDecomposePreviewResponse = 16088,
		// Token: 0x040002CF RID: 719
		ItemLockRequest = 25683,
		// Token: 0x040002D0 RID: 720
		ItemLockResponse = 18915,
		// Token: 0x040002D1 RID: 721
		ItemUseRequest = 16031,
		// Token: 0x040002D2 RID: 722
		ItemUseResponse = 21012,
		// Token: 0x040002D3 RID: 723
		ItemRewardNotify = 21938,
		// Token: 0x040002D4 RID: 724
		ItemGiftUseRequest = 18386,
		// Token: 0x040002D5 RID: 725
		ItemGiftUseResponse = 17290,
		// Token: 0x040002D6 RID: 726
		ItemGiftUseNotify = 28048,
		// Token: 0x040002D7 RID: 727
		NormalItemRequest = 22983,
		// Token: 0x040002D8 RID: 728
		NormalItemResponse = 22445,
		// Token: 0x040002D9 RID: 729
		NormalItemUpdateNotify = 20661,
		// Token: 0x040002DA RID: 730
		NormalItemRemoveNotify = 29178,
		// Token: 0x040002DB RID: 731
		NormalItemAddNotify = 15755,
		// Token: 0x040002DC RID: 732
		WeaponItemRequest = 25468,
		// Token: 0x040002DD RID: 733
		WeaponItemResponse = 27089,
		// Token: 0x040002DE RID: 734
		WeaponItemAddNotify = 24339,
		// Token: 0x040002DF RID: 735
		WeaponItemRemoveNotify = 16873,
		// Token: 0x040002E0 RID: 736
		PhantomItemRequest = 24659,
		// Token: 0x040002E1 RID: 737
		PhantomItemResponse = 26275,
		// Token: 0x040002E2 RID: 738
		PhantomItemAddNotify = 17848,
		// Token: 0x040002E3 RID: 739
		PhantomItemRemoveNotify = 29775,
		// Token: 0x040002E4 RID: 740
		ItemFuncValueUpdateNotify = 23784,
		// Token: 0x040002E5 RID: 741
		ItemObtainNotify = 25181,
		// Token: 0x040002E6 RID: 742
		ItemPkgOpenNotify = 29428,
		// Token: 0x040002E7 RID: 743
		InvalidItemRequest = 25813,
		// Token: 0x040002E8 RID: 744
		InvalidItemResponse = 25487,
		// Token: 0x040002E9 RID: 745
		ShowInvalidItemRequest = 28036,
		// Token: 0x040002EA RID: 746
		ShowInvalidItemResponse = 18549,
		// Token: 0x040002EB RID: 747
		ValidTimeItemRequest = 16123,
		// Token: 0x040002EC RID: 748
		ValidTimeItemResponse = 20447,
		// Token: 0x040002ED RID: 749
		ValidTimeItemUpdateNotify = 19123,
		// Token: 0x040002EE RID: 750
		ValidTimeItemRemoveNotify = 18573,
		// Token: 0x040002EF RID: 751
		ValidTimeItemAddNotify = 21350,
		// Token: 0x040002F0 RID: 752
		ItemExchangeInfoRequest = 17245,
		// Token: 0x040002F1 RID: 753
		ItemExchangeInfoResponse = 20569,
		// Token: 0x040002F2 RID: 754
		ItemExchangeRequest = 24108,
		// Token: 0x040002F3 RID: 755
		ItemExchangeResponse = 23286,
		// Token: 0x040002F4 RID: 756
		EnterLevelPlayNotify = 28880,
		// Token: 0x040002F5 RID: 757
		LeaveLevelPlayNotify = 23737,
		// Token: 0x040002F6 RID: 758
		LevelPlayInfoNotify = 19789,
		// Token: 0x040002F7 RID: 759
		LevelPlayFirstNotify = 22014,
		// Token: 0x040002F8 RID: 760
		LevelPlayStateNotify = 17840,
		// Token: 0x040002F9 RID: 761
		LevelPlayOpenTimeNotify = 16016,
		// Token: 0x040002FA RID: 762
		LevelPlayRewardRequest = 24224,
		// Token: 0x040002FB RID: 763
		LevelPlayRewardResponse = 21572,
		// Token: 0x040002FC RID: 764
		LevelPlayRewardNotify = 28898,
		// Token: 0x040002FD RID: 765
		LevelPlayRewardCountResetNotify = 15831,
		// Token: 0x040002FE RID: 766
		LivenessRequest = 25906,
		// Token: 0x040002FF RID: 767
		LivenessResponse = 28359,
		// Token: 0x04000300 RID: 768
		LivenessCountUpdateNotify = 20808,
		// Token: 0x04000301 RID: 769
		LivenessUpdateNotify = 15921,
		// Token: 0x04000302 RID: 770
		LivenessRefreshNotify = 27908,
		// Token: 0x04000303 RID: 771
		LivenessTaskTakeRequest = 23058,
		// Token: 0x04000304 RID: 772
		LivenessTaskTakeResponse = 18488,
		// Token: 0x04000305 RID: 773
		LivenessTakeRequest = 29270,
		// Token: 0x04000306 RID: 774
		LivenessTakeResponse = 20024,
		// Token: 0x04000307 RID: 775
		LoadEquipInfoRequest = 25260,
		// Token: 0x04000308 RID: 776
		LoadEquipInfoResponse = 23620,
		// Token: 0x04000309 RID: 777
		EquipTakeOnRequest = 29592,
		// Token: 0x0400030A RID: 778
		EquipTakeOnResponse = 28184,
		// Token: 0x0400030B RID: 779
		EquipTakeOnNotify = 28760,
		// Token: 0x0400030C RID: 780
		LordGymInfoRequest = 24619,
		// Token: 0x0400030D RID: 781
		LordGymInfoResponse = 27687,
		// Token: 0x0400030E RID: 782
		LordGymUnlockNotify = 19541,
		// Token: 0x0400030F RID: 783
		LordGymBeginRequest = 24586,
		// Token: 0x04000310 RID: 784
		LordGymBeginResponse = 22749,
		// Token: 0x04000311 RID: 785
		LordGymReadRequest = 29647,
		// Token: 0x04000312 RID: 786
		LordGymReadResponse = 18978,
		// Token: 0x04000313 RID: 787
		LordGymLevelPlayResultNotify = 29109,
		// Token: 0x04000314 RID: 788
		MailInfosNotify = 25021,
		// Token: 0x04000315 RID: 789
		MailDeleteNotify = 16201,
		// Token: 0x04000316 RID: 790
		MailAddNotify = 29640,
		// Token: 0x04000317 RID: 791
		MailReadRequest = 29441,
		// Token: 0x04000318 RID: 792
		MailReadResponse = 28318,
		// Token: 0x04000319 RID: 793
		MailGetAttachmentRequest = 24199,
		// Token: 0x0400031A RID: 794
		MailGetAttachmentResponse = 27409,
		// Token: 0x0400031B RID: 795
		MailDeleteRequest = 18443,
		// Token: 0x0400031C RID: 796
		MailDeleteResponse = 20393,
		// Token: 0x0400031D RID: 797
		MapMarkInfoRequest = 21577,
		// Token: 0x0400031E RID: 798
		MapMarkInfoResponse = 21025,
		// Token: 0x0400031F RID: 799
		MapUnlockFieldInfoRequest = 23298,
		// Token: 0x04000320 RID: 800
		MapUnlockFieldInfoResponse = 24181,
		// Token: 0x04000321 RID: 801
		MapMarkShowIdInfoUpdateNotify = 20835,
		// Token: 0x04000322 RID: 802
		MapMarkRequest = 18642,
		// Token: 0x04000323 RID: 803
		MapMarkResponse = 27926,
		// Token: 0x04000324 RID: 804
		MapRemoveMarkRequest = 15669,
		// Token: 0x04000325 RID: 805
		MapRemoveMarkResponse = 24173,
		// Token: 0x04000326 RID: 806
		MapUnlockFieldNotify = 18018,
		// Token: 0x04000327 RID: 807
		MapTraceInfoRequest = 22743,
		// Token: 0x04000328 RID: 808
		MapTraceInfoResponse = 28319,
		// Token: 0x04000329 RID: 809
		MapTraceRequest = 17647,
		// Token: 0x0400032A RID: 810
		MapTraceResponse = 22948,
		// Token: 0x0400032B RID: 811
		MapCancelTraceRequest = 29421,
		// Token: 0x0400032C RID: 812
		MapCancelTraceResponse = 29919,
		// Token: 0x0400032D RID: 813
		MapReplaceMarkRequest = 17142,
		// Token: 0x0400032E RID: 814
		MapReplaceMarkResponse = 24504,
		// Token: 0x0400032F RID: 815
		MapCancelTraceNotify = 25230,
		// Token: 0x04000330 RID: 816
		MapTraceNotify = 23529,
		// Token: 0x04000331 RID: 817
		MapRemoveAllMarkRequest = 15166,
		// Token: 0x04000332 RID: 818
		MapRemoveAllMarkResponse = 23583,
		// Token: 0x04000333 RID: 819
		MapMarkInfoNotify = 16185,
		// Token: 0x04000334 RID: 820
		UnlockMarkNotify = 26611,
		// Token: 0x04000335 RID: 821
		MapOpenPush = 21465,
		// Token: 0x04000336 RID: 822
		MapMarkInfoUpdateRequest = 20363,
		// Token: 0x04000337 RID: 823
		MapMarkInfoUpdateResponse = 17549,
		// Token: 0x04000338 RID: 824
		RemoveMarkInfoNotify = 24260,
		// Token: 0x04000339 RID: 825
		AddMarkInfoNotify = 28060,
		// Token: 0x0400033A RID: 826
		StartMatchRequest = 21756,
		// Token: 0x0400033B RID: 827
		StartMatchResponse = 20517,
		// Token: 0x0400033C RID: 828
		StartMatchNotify = 23153,
		// Token: 0x0400033D RID: 829
		CancelMatchRequest = 26931,
		// Token: 0x0400033E RID: 830
		CancelMatchResponse = 17942,
		// Token: 0x0400033F RID: 831
		CancelMatchNotify = 15420,
		// Token: 0x04000340 RID: 832
		MatchFailNotify = 22367,
		// Token: 0x04000341 RID: 833
		MatchTeamNotify = 15432,
		// Token: 0x04000342 RID: 834
		MatchConfirmRequest = 20944,
		// Token: 0x04000343 RID: 835
		MatchConfirmResponse = 18498,
		// Token: 0x04000344 RID: 836
		MatchConfirmNotify = 17104,
		// Token: 0x04000345 RID: 837
		MatchingNotify = 17009,
		// Token: 0x04000346 RID: 838
		MatchTeamStateNotify = 15902,
		// Token: 0x04000347 RID: 839
		MatchChangeRoleRequest = 16318,
		// Token: 0x04000348 RID: 840
		MatchChangeRoleResponse = 20466,
		// Token: 0x04000349 RID: 841
		MatchChangeRoleNotify = 15946,
		// Token: 0x0400034A RID: 842
		MatchChangeReadyRequest = 17228,
		// Token: 0x0400034B RID: 843
		MatchChangeReadyResponse = 15160,
		// Token: 0x0400034C RID: 844
		MatchChangeReadyNotify = 15244,
		// Token: 0x0400034D RID: 845
		LeaveMatchTeamRequest = 28110,
		// Token: 0x0400034E RID: 846
		LeaveMatchTeamResponse = 29714,
		// Token: 0x0400034F RID: 847
		LeaveMatchTeamNotify = 19226,
		// Token: 0x04000350 RID: 848
		EnterMatchTeamNotify = 28195,
		// Token: 0x04000351 RID: 849
		KickMatchTeamPlayerRequest = 25677,
		// Token: 0x04000352 RID: 850
		KickMatchTeamPlayerResponse = 23716,
		// Token: 0x04000353 RID: 851
		SetMatchTeamMatchFlagRequest = 18868,
		// Token: 0x04000354 RID: 852
		SetMatchTeamMatchFlagResponse = 23137,
		// Token: 0x04000355 RID: 853
		TeamMatchFlagNotify = 29741,
		// Token: 0x04000356 RID: 854
		EnterMatchInstRequest = 21561,
		// Token: 0x04000357 RID: 855
		EnterMatchInstResponse = 20833,
		// Token: 0x04000358 RID: 856
		TeamChallengeRequest = 26370,
		// Token: 0x04000359 RID: 857
		TeamChallengeResponse = 19774,
		// Token: 0x0400035A RID: 858
		TeamMatchInviteRequest = 17409,
		// Token: 0x0400035B RID: 859
		TeamMatchInviteResponse = 29449,
		// Token: 0x0400035C RID: 860
		TeamMatchInviteNotify = 24891,
		// Token: 0x0400035D RID: 861
		TeamMatchAcceptInviteRequest = 26322,
		// Token: 0x0400035E RID: 862
		TeamMatchAcceptInviteResponse = 16611,
		// Token: 0x0400035F RID: 863
		TeamMatchAcceptInviteNotify = 16329,
		// Token: 0x04000360 RID: 864
		MatchChangePlayerUiStateRequest = 24320,
		// Token: 0x04000361 RID: 865
		MatchChangePlayerUiStateResponse = 20959,
		// Token: 0x04000362 RID: 866
		MatchChangePlayerUiStateNotify = 20049,
		// Token: 0x04000363 RID: 867
		MessageDecodeFailNotify = 19803,
		// Token: 0x04000364 RID: 868
		HandInMingSuRequest = 23496,
		// Token: 0x04000365 RID: 869
		HandInMingSuResponse = 23593,
		// Token: 0x04000366 RID: 870
		ActiveDragonPoolRequest = 29864,
		// Token: 0x04000367 RID: 871
		ActiveDragonPoolResponse = 29130,
		// Token: 0x04000368 RID: 872
		DragonPoolConfRequest = 21659,
		// Token: 0x04000369 RID: 873
		DragonPoolConfResponse = 24543,
		// Token: 0x0400036A RID: 874
		MonsterGachaDataChangeNotify = 15337,
		// Token: 0x0400036B RID: 875
		MonthCardRequest = 15066,
		// Token: 0x0400036C RID: 876
		MonthCardResponse = 29522,
		// Token: 0x0400036D RID: 877
		MonthCardDailyRewardNotify = 20826,
		// Token: 0x0400036E RID: 878
		MonthCardUseNotify = 29912,
		// Token: 0x0400036F RID: 879
		MutiplayerTeamRefreshNearListRequest = 27911,
		// Token: 0x04000370 RID: 880
		MutiplayerTeamRefreshNearListResponse = 20855,
		// Token: 0x04000371 RID: 881
		NetTestDataPush = 21765,
		// Token: 0x04000372 RID: 882
		NetTestDataNotify = 17969,
		// Token: 0x04000373 RID: 883
		NetTestDataRequest = 16056,
		// Token: 0x04000374 RID: 884
		NetTestDataResponse = 29222,
		// Token: 0x04000375 RID: 885
		NewBieCourseRewardNotify = 21899,
		// Token: 0x04000376 RID: 886
		NewBieCourseRewardRequest = 29127,
		// Token: 0x04000377 RID: 887
		NewBieCourseRewardResponse = 23806,
		// Token: 0x04000378 RID: 888
		NewJourneyRequest = 24090,
		// Token: 0x04000379 RID: 889
		NewJourneyResponse = 16530,
		// Token: 0x0400037A RID: 890
		ParkourChallengeRequest = 20163,
		// Token: 0x0400037B RID: 891
		ParkourChallengeResponse = 29088,
		// Token: 0x0400037C RID: 892
		ParkourChallengeOpenNotify = 25157,
		// Token: 0x0400037D RID: 893
		ParkourChallengeTakeRequest = 23686,
		// Token: 0x0400037E RID: 894
		ParkourChallengeTakeResponse = 23450,
		// Token: 0x0400037F RID: 895
		ParkourChallengeEndNotify = 15236,
		// Token: 0x04000380 RID: 896
		ParkourChallengeTransRequest = 23432,
		// Token: 0x04000381 RID: 897
		ParkourChallengeTransResponse = 23607,
		// Token: 0x04000382 RID: 898
		PartComponentInitRequest = 17744,
		// Token: 0x04000383 RID: 899
		PartComponentInitResponse = 25211,
		// Token: 0x04000384 RID: 900
		PartComponentInitNotify = 27435,
		// Token: 0x04000385 RID: 901
		PartUpdateRequest = 23337,
		// Token: 0x04000386 RID: 902
		PartUpdateResponse = 28131,
		// Token: 0x04000387 RID: 903
		PartUpdateNotify = 23036,
		// Token: 0x04000388 RID: 904
		PayInfoRequest = 18331,
		// Token: 0x04000389 RID: 905
		PayInfoResponse = 25815,
		// Token: 0x0400038A RID: 906
		PayItemRequest = 28472,
		// Token: 0x0400038B RID: 907
		PayItemResponse = 16661,
		// Token: 0x0400038C RID: 908
		PayItemSuccessNotify = 25980,
		// Token: 0x0400038D RID: 909
		ResetSpecialBonusNotify = 29227,
		// Token: 0x0400038E RID: 910
		PayGiftInfoRequest = 26799,
		// Token: 0x0400038F RID: 911
		PayGiftInfoResponse = 16033,
		// Token: 0x04000390 RID: 912
		PayGiftRequest = 21930,
		// Token: 0x04000391 RID: 913
		PayGiftResponse = 16671,
		// Token: 0x04000392 RID: 914
		PayGiftSuccessNotify = 23642,
		// Token: 0x04000393 RID: 915
		PayShopInfoNotify = 26161,
		// Token: 0x04000394 RID: 916
		PayShopInfoRequest = 20758,
		// Token: 0x04000395 RID: 917
		PayShopInfoResponse = 25954,
		// Token: 0x04000396 RID: 918
		PayShopUpdateRequest = 17383,
		// Token: 0x04000397 RID: 919
		PayShopUpdateResponse = 22804,
		// Token: 0x04000398 RID: 920
		PayShopItemUpdateRequest = 16274,
		// Token: 0x04000399 RID: 921
		PayShopItemUpdateResponse = 27686,
		// Token: 0x0400039A RID: 922
		PayShopBuyRequest = 23126,
		// Token: 0x0400039B RID: 923
		PayShopBuyResponse = 25381,
		// Token: 0x0400039C RID: 924
		PayShopUnlockNotify = 26780,
		// Token: 0x0400039D RID: 925
		PayShopDirectBuyRequest = 28521,
		// Token: 0x0400039E RID: 926
		PayShopDirectBuyResponse = 20285,
		// Token: 0x0400039F RID: 927
		PayShopDirectBuyNotify = 27230,
		// Token: 0x040003A0 RID: 928
		PayShopConditionFinishNotify = 16372,
		// Token: 0x040003A1 RID: 929
		PhantomLevelUpRequest = 16448,
		// Token: 0x040003A2 RID: 930
		PhantomLevelUpResponse = 22489,
		// Token: 0x040003A3 RID: 931
		PhantomEquipInfoNotify = 15372,
		// Token: 0x040003A4 RID: 932
		PhantomPutOnRequest = 29319,
		// Token: 0x040003A5 RID: 933
		PhantomPutOnResponse = 16317,
		// Token: 0x040003A6 RID: 934
		PhantomReturnPreviewRequest = 29070,
		// Token: 0x040003A7 RID: 935
		PhantomReturnPreviewResponse = 27740,
		// Token: 0x040003A8 RID: 936
		PhantomReturnRequest = 19584,
		// Token: 0x040003A9 RID: 937
		PhantomReturnResponse = 21387,
		// Token: 0x040003AA RID: 938
		PhantomRecommendRequest = 26086,
		// Token: 0x040003AB RID: 939
		PhantomRecommendResponse = 28376,
		// Token: 0x040003AC RID: 940
		PhantomAutoPutRequest = 26414,
		// Token: 0x040003AD RID: 941
		PhantomAutoPutResponse = 19223,
		// Token: 0x040003AE RID: 942
		PhantomItemUpdateNotify = 28162,
		// Token: 0x040003AF RID: 943
		RolePhantomPropUpdateNotify = 23392,
		// Token: 0x040003B0 RID: 944
		PhantomIdentifyRequest = 18169,
		// Token: 0x040003B1 RID: 945
		PhantomIdentifyResponse = 21034,
		// Token: 0x040003B2 RID: 946
		PhantomUpdateNotify = 28427,
		// Token: 0x040003B3 RID: 947
		PhantomSkinAddNotify = 24383,
		// Token: 0x040003B4 RID: 948
		PhantomSkinChangeRequest = 25116,
		// Token: 0x040003B5 RID: 949
		PhantomSkinChangeResponse = 29630,
		// Token: 0x040003B6 RID: 950
		PhantomUnlockNotify = 18900,
		// Token: 0x040003B7 RID: 951
		PhantomRefiningRequest = 25546,
		// Token: 0x040003B8 RID: 952
		PhantomRefiningResponse = 29840,
		// Token: 0x040003B9 RID: 953
		PlayerAttrNotify = 20778,
		// Token: 0x040003BA RID: 954
		PassiveSkillNotify = 26386,
		// Token: 0x040003BB RID: 955
		UpdatePlayerPassiveSkillRequest = 16711,
		// Token: 0x040003BC RID: 956
		UpdatePlayerPassiveSkillResponse = 20928,
		// Token: 0x040003BD RID: 957
		PlayerVarNotify = 23542,
		// Token: 0x040003BE RID: 958
		PlayerMotionRequest = 18827,
		// Token: 0x040003BF RID: 959
		PlayerMotionResponse = 21104,
		// Token: 0x040003C0 RID: 960
		PressRequest = 21606,
		// Token: 0x040003C1 RID: 961
		PressResponse = 26869,
		// Token: 0x040003C2 RID: 962
		PressNotify = 28317,
		// Token: 0x040003C3 RID: 963
		PressGameRequest = 15600,
		// Token: 0x040003C4 RID: 964
		PressGameResponse = 22730,
		// Token: 0x040003C5 RID: 965
		PressGameNotify = 17678,
		// Token: 0x040003C6 RID: 966
		ProgressBarFinishRequest = 17360,
		// Token: 0x040003C7 RID: 967
		ProgressBarFinishResponse = 23237,
		// Token: 0x040003C8 RID: 968
		FormationAttrNotify = 26658,
		// Token: 0x040003C9 RID: 969
		FormationAttrRequest = 21778,
		// Token: 0x040003CA RID: 970
		FormationAttrResponse = 26997,
		// Token: 0x040003CB RID: 971
		RecoverPropChangedNotify = 29454,
		// Token: 0x040003CC RID: 972
		FragileChangeRequest = 29703,
		// Token: 0x040003CD RID: 973
		FragileChangeResponse = 16203,
		// Token: 0x040003CE RID: 974
		CheckPublicResourceVersionRequest = 28539,
		// Token: 0x040003CF RID: 975
		CheckPublicResourceVersionResponse = 15757,
		// Token: 0x040003D0 RID: 976
		JSPatchNotify = 25006,
		// Token: 0x040003D1 RID: 977
		QuestListNotify = 23759,
		// Token: 0x040003D2 RID: 978
		TraceQuestNotify = 26198,
		// Token: 0x040003D3 RID: 979
		TraceQuestRequest = 28978,
		// Token: 0x040003D4 RID: 980
		TraceQuestResponse = 29698,
		// Token: 0x040003D5 RID: 981
		QuestFinishActionRequest = 26719,
		// Token: 0x040003D6 RID: 982
		QuestFinishActionResponse = 26546,
		// Token: 0x040003D7 RID: 983
		QuestActionRequest = 21411,
		// Token: 0x040003D8 RID: 984
		QuestActionResponse = 16333,
		// Token: 0x040003D9 RID: 985
		QuestReadyListNotify = 24620,
		// Token: 0x040003DA RID: 986
		QuestShowListNotify = 17562,
		// Token: 0x040003DB RID: 987
		QuestNpcMoveOverRequest = 23456,
		// Token: 0x040003DC RID: 988
		QuestNpcMoveOverResponse = 19722,
		// Token: 0x040003DD RID: 989
		QuestStateUpdateNotify = 28378,
		// Token: 0x040003DE RID: 990
		QuestFinishActionEndRequest = 20075,
		// Token: 0x040003DF RID: 991
		QuestFinishActionEndResponse = 16750,
		// Token: 0x040003E0 RID: 992
		QuestFinishListNotify = 17000,
		// Token: 0x040003E1 RID: 993
		DailyQuestUnlockAreaNotify = 27366,
		// Token: 0x040003E2 RID: 994
		DailyQuestStateNotify = 22047,
		// Token: 0x040003E3 RID: 995
		DailyQuestChangePreferRequest = 18344,
		// Token: 0x040003E4 RID: 996
		DailyQuestChangePreferResponse = 27145,
		// Token: 0x040003E5 RID: 997
		DailyQuestGetRewardRequest = 29092,
		// Token: 0x040003E6 RID: 998
		DailyQuestGetRewardResponse = 21514,
		// Token: 0x040003E7 RID: 999
		DailyQuestCancelNotify = 20367,
		// Token: 0x040003E8 RID: 1000
		RoleQuestAcceptRequest = 18997,
		// Token: 0x040003E9 RID: 1001
		RoleQuestAcceptResponse = 24464,
		// Token: 0x040003EA RID: 1002
		RoleQuestStateNotify = 22674,
		// Token: 0x040003EB RID: 1003
		RoleQuestNewUnlockNotify = 26215,
		// Token: 0x040003EC RID: 1004
		RoleQuestPointStateRequest = 15049,
		// Token: 0x040003ED RID: 1005
		RoleQuestPointStateResponse = 22800,
		// Token: 0x040003EE RID: 1006
		DestroyQuestsNotify = 17308,
		// Token: 0x040003EF RID: 1007
		AutoQuestNotify = 16961,
		// Token: 0x040003F0 RID: 1008
		QuestRedDotRequest = 16021,
		// Token: 0x040003F1 RID: 1009
		QuestRedDotResponse = 18604,
		// Token: 0x040003F2 RID: 1010
		QuestRedDotNotify = 23522,
		// Token: 0x040003F3 RID: 1011
		ApplyRechallengeRequest = 21016,
		// Token: 0x040003F4 RID: 1012
		ApplyRechallengeResponse = 22112,
		// Token: 0x040003F5 RID: 1013
		ReceiveRechallengeNotify = 17918,
		// Token: 0x040003F6 RID: 1014
		ReceiveRechallengeRequest = 15865,
		// Token: 0x040003F7 RID: 1015
		ReceiveRechallengeResponse = 26240,
		// Token: 0x040003F8 RID: 1016
		InviteRechallengeRequest = 27217,
		// Token: 0x040003F9 RID: 1017
		InviteRechallengeResponse = 16100,
		// Token: 0x040003FA RID: 1018
		InviteRechallengeNotify = 19929,
		// Token: 0x040003FB RID: 1019
		ReceiveRechallengePlayerIdsNotify = 15842,
		// Token: 0x040003FC RID: 1020
		PlayerDeadNotify = 27670,
		// Token: 0x040003FD RID: 1021
		PlayerReviveNotify = 27617,
		// Token: 0x040003FE RID: 1022
		ReviveRequest = 18644,
		// Token: 0x040003FF RID: 1023
		ReviveResponse = 29474,
		// Token: 0x04000400 RID: 1024
		AddReviveRegionRequest = 23120,
		// Token: 0x04000401 RID: 1025
		AddReviveRegionResponse = 28871,
		// Token: 0x04000402 RID: 1026
		RemoveReviveRegionRequest = 25255,
		// Token: 0x04000403 RID: 1027
		RemoveReviveRegionResponse = 19851,
		// Token: 0x04000404 RID: 1028
		RoguelikeCurrencyNotify = 17560,
		// Token: 0x04000405 RID: 1029
		RoguelikeCurrencyUpdateNotify = 29332,
		// Token: 0x04000406 RID: 1030
		RoguelikeInfoNotify = 16321,
		// Token: 0x04000407 RID: 1031
		RoguelikeRefreshGainRequest = 29603,
		// Token: 0x04000408 RID: 1032
		RoguelikeRefreshGainResponse = 25725,
		// Token: 0x04000409 RID: 1033
		RoguelikeChooseDataRequest = 21182,
		// Token: 0x0400040A RID: 1034
		RoguelikeChooseDataResponse = 21308,
		// Token: 0x0400040B RID: 1035
		RoguelikeChooseDataNotify = 24553,
		// Token: 0x0400040C RID: 1036
		RoguelikeChooseDataResultRequest = 26274,
		// Token: 0x0400040D RID: 1037
		RoguelikeChooseDataResultResponse = 17572,
		// Token: 0x0400040E RID: 1038
		RoguelikeEventGainNotify = 24233,
		// Token: 0x0400040F RID: 1039
		RoguelikeLastInfoRequest = 26510,
		// Token: 0x04000410 RID: 1040
		RoguelikeLastInfoResponse = 16971,
		// Token: 0x04000411 RID: 1041
		RoguelikeStartRequest = 29795,
		// Token: 0x04000412 RID: 1042
		RoguelikeStartResponse = 28058,
		// Token: 0x04000413 RID: 1043
		RoguelikeQuitRequest = 16370,
		// Token: 0x04000414 RID: 1044
		RoguelikeQuitResponse = 15309,
		// Token: 0x04000415 RID: 1045
		RoguelikeResultNotify = 27722,
		// Token: 0x04000416 RID: 1046
		RoguelikeResultRequest = 21292,
		// Token: 0x04000417 RID: 1047
		RoguelikeResultResponse = 28757,
		// Token: 0x04000418 RID: 1048
		RoguelikeSubLevelNotify = 24792,
		// Token: 0x04000419 RID: 1049
		RoguelikeGotoNextRoomRequest = 19829,
		// Token: 0x0400041A RID: 1050
		RoguelikeGotoNextRoomResponse = 22376,
		// Token: 0x0400041B RID: 1051
		RoguelikeRoomInfoNotify = 20950,
		// Token: 0x0400041C RID: 1052
		RoguelikeTalentInfoRequest = 21173,
		// Token: 0x0400041D RID: 1053
		RoguelikeTalentInfoResponse = 23720,
		// Token: 0x0400041E RID: 1054
		RoguelikeTalentLevelUpRequest = 26893,
		// Token: 0x0400041F RID: 1055
		RoguelikeTalentLevelUpResponse = 21035,
		// Token: 0x04000420 RID: 1056
		RoguelikeTalentUnlockNotify = 25010,
		// Token: 0x04000421 RID: 1057
		RoguelikeSeasonDataRequest = 22746,
		// Token: 0x04000422 RID: 1058
		RoguelikeSeasonDataResponse = 29540,
		// Token: 0x04000423 RID: 1059
		RoguelikeTokenReceiveRequest = 24840,
		// Token: 0x04000424 RID: 1060
		RoguelikeTokenReceiveResponse = 28422,
		// Token: 0x04000425 RID: 1061
		RoguelikeSeasonRewardReceiveRequest = 16953,
		// Token: 0x04000426 RID: 1062
		RoguelikeSeasonRewardReceiveResponse = 26366,
		// Token: 0x04000427 RID: 1063
		RoguelikeGiveUpGainRequest = 27974,
		// Token: 0x04000428 RID: 1064
		RoguelikeGiveUpGainResponse = 25582,
		// Token: 0x04000429 RID: 1065
		PbGetRoleListRequest = 26301,
		// Token: 0x0400042A RID: 1066
		PbGetRoleListResponse = 25557,
		// Token: 0x0400042B RID: 1067
		PbGetRoleListNotify = 18368,
		// Token: 0x0400042C RID: 1068
		PbRoleActiveNotify = 27050,
		// Token: 0x0400042D RID: 1069
		PbUpLevelRoleRequest = 15445,
		// Token: 0x0400042E RID: 1070
		PbUpLevelRoleResponse = 17222,
		// Token: 0x0400042F RID: 1071
		PbOverRoleRequest = 18138,
		// Token: 0x04000430 RID: 1072
		PbOverRoleResponse = 29016,
		// Token: 0x04000431 RID: 1073
		PbUpLevelSkillRequest = 22382,
		// Token: 0x04000432 RID: 1074
		PbUpLevelSkillResponse = 17988,
		// Token: 0x04000433 RID: 1075
		PbRolePropsNotify = 28533,
		// Token: 0x04000434 RID: 1076
		PbRoleExpNotify = 27992,
		// Token: 0x04000435 RID: 1077
		PbRoleResonLockFinishNotify = 22856,
		// Token: 0x04000436 RID: 1078
		PbRoleScenePropsNotify = 28749,
		// Token: 0x04000437 RID: 1079
		PbRoleSkillLevelNotify = 17396,
		// Token: 0x04000438 RID: 1080
		RoleLevelUpViewRequest = 19849,
		// Token: 0x04000439 RID: 1081
		RoleLevelUpViewResponse = 15925,
		// Token: 0x0400043A RID: 1082
		RoleBreakThroughViewRequest = 25405,
		// Token: 0x0400043B RID: 1083
		RoleBreakThroughViewResponse = 21102,
		// Token: 0x0400043C RID: 1084
		RoleSkillLevelUpViewRequest = 18841,
		// Token: 0x0400043D RID: 1085
		RoleSkillLevelUpViewResponse = 17683,
		// Token: 0x0400043E RID: 1086
		RoleSkillViewRequest = 26728,
		// Token: 0x0400043F RID: 1087
		RoleSkillViewResponse = 20300,
		// Token: 0x04000440 RID: 1088
		RoleChangeNameNotify = 26144,
		// Token: 0x04000441 RID: 1089
		RoleTrialOpenNotify = 16081,
		// Token: 0x04000442 RID: 1090
		RoleTrialCloseNotify = 29420,
		// Token: 0x04000443 RID: 1091
		RoleActivateSkillRequest = 20952,
		// Token: 0x04000444 RID: 1092
		RoleActivateSkillResponse = 17555,
		// Token: 0x04000445 RID: 1093
		RoleSkillNodeNotify = 18129,
		// Token: 0x04000446 RID: 1094
		ResonantChainUnlockRequest = 15098,
		// Token: 0x04000447 RID: 1095
		ResonantChainUnlockResponse = 29448,
		// Token: 0x04000448 RID: 1096
		RoleSexChangeRequest = 24765,
		// Token: 0x04000449 RID: 1097
		RoleSexChangeResponse = 18787,
		// Token: 0x0400044A RID: 1098
		RoleElementChangeRequest = 20709,
		// Token: 0x0400044B RID: 1099
		RoleElementChangeResponse = 17259,
		// Token: 0x0400044C RID: 1100
		RoleChangeNotify = 28197,
		// Token: 0x0400044D RID: 1101
		RoleChangeUnlockNotify = 26358,
		// Token: 0x0400044E RID: 1102
		MaxMessageIdPush = 23839,
		// Token: 0x0400044F RID: 1103
		TrialRoleRewardRequest = 28460,
		// Token: 0x04000450 RID: 1104
		TrialRoleRewardResponse = 23104,
		// Token: 0x04000451 RID: 1105
		RoleTrialSettleNotify = 25527,
		// Token: 0x04000452 RID: 1106
		EntityLivingStatusNotify = 23945,
		// Token: 0x04000453 RID: 1107
		UpdatePlayerAllFightRoleNotify = 21051,
		// Token: 0x04000454 RID: 1108
		UpdatePlayersFightRolesInfoNotify = 18899,
		// Token: 0x04000455 RID: 1109
		UpdatePlayerSingleFightRoleNotify = 18580,
		// Token: 0x04000456 RID: 1110
		ChangePlayerFightRoleNotify = 27633,
		// Token: 0x04000457 RID: 1111
		SceneAreaStateNotify = 27914,
		// Token: 0x04000458 RID: 1112
		HostTeleportUnlockNotify = 22223,
		// Token: 0x04000459 RID: 1113
		HostFogIdUnlockNotify = 28107,
		// Token: 0x0400045A RID: 1114
		SyncSceneTimeNotify = 26685,
		// Token: 0x0400045B RID: 1115
		ChangeSceneModeNotify = 29411,
		// Token: 0x0400045C RID: 1116
		ScenePlayerOfflineNotify = 20659,
		// Token: 0x0400045D RID: 1117
		JoinSceneNotify = 18559,
		// Token: 0x0400045E RID: 1118
		OtherJoinSceneNotify = 22868,
		// Token: 0x0400045F RID: 1119
		LeaveSceneNotify = 28361,
		// Token: 0x04000460 RID: 1120
		MovePackagePush = 24756,
		// Token: 0x04000461 RID: 1121
		MovePackageNotify = 17992,
		// Token: 0x04000462 RID: 1122
		UDPMovePackagePush = 24978,
		// Token: 0x04000463 RID: 1123
		UDPMovePackageNotify = 25437,
		// Token: 0x04000464 RID: 1124
		EntitySimplyMoveInfoPackagePush = 18037,
		// Token: 0x04000465 RID: 1125
		MoveSceneItemPush = 21046,
		// Token: 0x04000466 RID: 1126
		MoveSceneItemNotify = 24344,
		// Token: 0x04000467 RID: 1127
		ChangeMonsterRoleNotify = 28069,
		// Token: 0x04000468 RID: 1128
		CaptureEntityRequest = 15078,
		// Token: 0x04000469 RID: 1129
		CaptureEntityResponse = 22470,
		// Token: 0x0400046A RID: 1130
		RemoveSummonEntityRequest = 18845,
		// Token: 0x0400046B RID: 1131
		RemoveSummonEntityResponse = 17688,
		// Token: 0x0400046C RID: 1132
		ChangeEntityRoleRequest = 24583,
		// Token: 0x0400046D RID: 1133
		ChangeEntityRoleResponse = 24212,
		// Token: 0x0400046E RID: 1134
		EntityOnLandedRequest = 25532,
		// Token: 0x0400046F RID: 1135
		EntityOnLandedResponse = 17811,
		// Token: 0x04000470 RID: 1136
		EntityOnLandedNotify = 25577,
		// Token: 0x04000471 RID: 1137
		AttributeInitRequest = 22401,
		// Token: 0x04000472 RID: 1138
		AttributeInitResponse = 29079,
		// Token: 0x04000473 RID: 1139
		AttributeInitNotify = 19205,
		// Token: 0x04000474 RID: 1140
		AttributeChangedRequest = 17782,
		// Token: 0x04000475 RID: 1141
		AttributeChangedResponse = 21027,
		// Token: 0x04000476 RID: 1142
		AttributeChangedNotify = 27832,
		// Token: 0x04000477 RID: 1143
		MonsterLevelNotify = 24635,
		// Token: 0x04000478 RID: 1144
		MonsterLevelArrayNotify = 27665,
		// Token: 0x04000479 RID: 1145
		MonsterAttributeNotify = 26755,
		// Token: 0x0400047A RID: 1146
		MonsterAttributeArrayNotify = 27454,
		// Token: 0x0400047B RID: 1147
		AnimationStateInitRequest = 16475,
		// Token: 0x0400047C RID: 1148
		AnimationStateInitResponse = 28333,
		// Token: 0x0400047D RID: 1149
		AnimationStateInitNotify = 27651,
		// Token: 0x0400047E RID: 1150
		AnimationStateChangedRequest = 26812,
		// Token: 0x0400047F RID: 1151
		AnimationStateChangedResponse = 16407,
		// Token: 0x04000480 RID: 1152
		AnimationStateChangedNotify = 15580,
		// Token: 0x04000481 RID: 1153
		GameplayTagInitNotify = 17063,
		// Token: 0x04000482 RID: 1154
		GameplayTagChangedNotify = 28388,
		// Token: 0x04000483 RID: 1155
		EntityCommonTagNotify = 19566,
		// Token: 0x04000484 RID: 1156
		ChangeControlRoleNotify = 26484,
		// Token: 0x04000485 RID: 1157
		HardnessModeChangedRequest = 18173,
		// Token: 0x04000486 RID: 1158
		HardnessModeChangedResponse = 27736,
		// Token: 0x04000487 RID: 1159
		HardnessModeChangedNotify = 24870,
		// Token: 0x04000488 RID: 1160
		SummonRequest = 27379,
		// Token: 0x04000489 RID: 1161
		SummonResponse = 18705,
		// Token: 0x0400048A RID: 1162
		Summon2Request = 19448,
		// Token: 0x0400048B RID: 1163
		Summon2Response = 28056,
		// Token: 0x0400048C RID: 1164
		SummonEntityNotify = 15942,
		// Token: 0x0400048D RID: 1165
		VisionSkillCallNotify = 27773,
		// Token: 0x0400048E RID: 1166
		InstanceTimerNotify = 28918,
		// Token: 0x0400048F RID: 1167
		UpdateInstanceTimerNotify = 20590,
		// Token: 0x04000490 RID: 1168
		RemoveInstanceTimerNotify = 26626,
		// Token: 0x04000491 RID: 1169
		RemoveInstanceTimerRequest = 26557,
		// Token: 0x04000492 RID: 1170
		RemoveInstanceTimerResponse = 19370,
		// Token: 0x04000493 RID: 1171
		UpdateInstanceOwnerInfoNotify = 16427,
		// Token: 0x04000494 RID: 1172
		UpdateOwnerMingSuGenNotify = 27693,
		// Token: 0x04000495 RID: 1173
		AddSysBuffNotify = 21803,
		// Token: 0x04000496 RID: 1174
		UpdateSysBuffNotify = 29655,
		// Token: 0x04000497 RID: 1175
		RemoveSysBuffNotify = 24831,
		// Token: 0x04000498 RID: 1176
		UpdateSceneDateRequest = 15194,
		// Token: 0x04000499 RID: 1177
		UpdateSceneDateResponse = 18163,
		// Token: 0x0400049A RID: 1178
		SceneDateNotify = 29275,
		// Token: 0x0400049B RID: 1179
		HoldWeaponPush = 26659,
		// Token: 0x0400049C RID: 1180
		DiscardWeaponPush = 20752,
		// Token: 0x0400049D RID: 1181
		DiscardWeaponRequest = 15239,
		// Token: 0x0400049E RID: 1182
		DiscardWeaponResponse = 22877,
		// Token: 0x0400049F RID: 1183
		HoldWeaponNotify = 29731,
		// Token: 0x040004A0 RID: 1184
		CreatStoryCharacterRequest = 24716,
		// Token: 0x040004A1 RID: 1185
		CreatStoryCharacterResponse = 24862,
		// Token: 0x040004A2 RID: 1186
		DeleteStoryCharacterRequest = 27194,
		// Token: 0x040004A3 RID: 1187
		DeleteStoryCharacterResponse = 29781,
		// Token: 0x040004A4 RID: 1188
		EnterAoiNotify = 20418,
		// Token: 0x040004A5 RID: 1189
		AddEntityAoiNotify = 21738,
		// Token: 0x040004A6 RID: 1190
		LeaveAoiNotify = 24943,
		// Token: 0x040004A7 RID: 1191
		RemoveEntityAoiNotify = 22294,
		// Token: 0x040004A8 RID: 1192
		PlayerAoiRangeNotify = 17657,
		// Token: 0x040004A9 RID: 1193
		SceneGamePlayInfoNotify = 18306,
		// Token: 0x040004AA RID: 1194
		SceneGamePlayFirstNotify = 28356,
		// Token: 0x040004AB RID: 1195
		SceneGamePlayStatusNotify = 20225,
		// Token: 0x040004AC RID: 1196
		SceneGamePlayScopeNotify = 25818,
		// Token: 0x040004AD RID: 1197
		SceneGamePlayOpenTimeNotify = 21473,
		// Token: 0x040004AE RID: 1198
		CreatureDetailRequest = 19517,
		// Token: 0x040004AF RID: 1199
		CreatureDetailResponse = 18855,
		// Token: 0x040004B0 RID: 1200
		ResetLocationForZRangeNotify = 26153,
		// Token: 0x040004B1 RID: 1201
		ChangeEntityStateRequest = 22928,
		// Token: 0x040004B2 RID: 1202
		ChangeEntityStateResponse = 28032,
		// Token: 0x040004B3 RID: 1203
		FoundationRequest = 24967,
		// Token: 0x040004B4 RID: 1204
		FoundationResponse = 17723,
		// Token: 0x040004B5 RID: 1205
		BeControlledPosInFoundationNotify = 23053,
		// Token: 0x040004B6 RID: 1206
		BeControlledRequest = 24899,
		// Token: 0x040004B7 RID: 1207
		BeControlledResponse = 18432,
		// Token: 0x040004B8 RID: 1208
		BeControlledNotify = 28228,
		// Token: 0x040004B9 RID: 1209
		BeControlledShowRequest = 15548,
		// Token: 0x040004BA RID: 1210
		BeControlledShowResponse = 26724,
		// Token: 0x040004BB RID: 1211
		BeControlledShowNotify = 16761,
		// Token: 0x040004BC RID: 1212
		BeControlledThrowRequest = 17791,
		// Token: 0x040004BD RID: 1213
		BeControlledThrowResponse = 28508,
		// Token: 0x040004BE RID: 1214
		RelationIdNotify = 17936,
		// Token: 0x040004BF RID: 1215
		EntityPosResetNotify = 25086,
		// Token: 0x040004C0 RID: 1216
		GravityGearRequest = 21311,
		// Token: 0x040004C1 RID: 1217
		GravityGearResponse = 25409,
		// Token: 0x040004C2 RID: 1218
		WeatherNotify = 18291,
		// Token: 0x040004C3 RID: 1219
		ChangeWeatherRequest = 25213,
		// Token: 0x040004C4 RID: 1220
		ChangeWeatherResponse = 21042,
		// Token: 0x040004C5 RID: 1221
		FollowTrackRequest = 15030,
		// Token: 0x040004C6 RID: 1222
		FollowTrackResponse = 22950,
		// Token: 0x040004C7 RID: 1223
		SetInitTagRequest = 23652,
		// Token: 0x040004C8 RID: 1224
		SetInitTagResponse = 24518,
		// Token: 0x040004C9 RID: 1225
		PlayerRebackSceneNotify = 25253,
		// Token: 0x040004CA RID: 1226
		DrownRequest = 18070,
		// Token: 0x040004CB RID: 1227
		DrownResponse = 18315,
		// Token: 0x040004CC RID: 1228
		DrownNotify = 26523,
		// Token: 0x040004CD RID: 1229
		DrownEndTeleportRequest = 20649,
		// Token: 0x040004CE RID: 1230
		DrownEndTeleportResponse = 17520,
		// Token: 0x040004CF RID: 1231
		MonsterDrownRequest = 21217,
		// Token: 0x040004D0 RID: 1232
		MonsterDrownResponse = 25334,
		// Token: 0x040004D1 RID: 1233
		EnableNearbyTrackingNotify = 27628,
		// Token: 0x040004D2 RID: 1234
		SceneSubLevelsChangedNotify = 23168,
		// Token: 0x040004D3 RID: 1235
		SceneSubLevelsNotify = 22380,
		// Token: 0x040004D4 RID: 1236
		SceneLoadingFinishRequest = 20048,
		// Token: 0x040004D5 RID: 1237
		SceneLoadingFinishResponse = 25807,
		// Token: 0x040004D6 RID: 1238
		SceneLoadingTimeOutNotify = 27994,
		// Token: 0x040004D7 RID: 1239
		SceneLoadingFinishNotify = 22001,
		// Token: 0x040004D8 RID: 1240
		ResetPointEntityNotify = 16945,
		// Token: 0x040004D9 RID: 1241
		SitChairRequest = 25632,
		// Token: 0x040004DA RID: 1242
		SitChairResponse = 22930,
		// Token: 0x040004DB RID: 1243
		BeControlledDestroyRequest = 22559,
		// Token: 0x040004DC RID: 1244
		BeControlledDestroyResponse = 24018,
		// Token: 0x040004DD RID: 1245
		SceneTestNotify = 22242,
		// Token: 0x040004DE RID: 1246
		SceneChangeDataLayerNotify = 16684,
		// Token: 0x040004DF RID: 1247
		ChangeDataLayerFinishRequest = 27553,
		// Token: 0x040004E0 RID: 1248
		ChangeDataLayerFinishResponse = 27963,
		// Token: 0x040004E1 RID: 1249
		MoveSceneItemResetPositionRequest = 16218,
		// Token: 0x040004E2 RID: 1250
		MoveSceneItemResetPositionResponse = 29511,
		// Token: 0x040004E3 RID: 1251
		HookLockPointRequest = 18814,
		// Token: 0x040004E4 RID: 1252
		HookLockPointResponse = 23488,
		// Token: 0x040004E5 RID: 1253
		CheckGearRequest = 26428,
		// Token: 0x040004E6 RID: 1254
		CheckGearResponse = 16110,
		// Token: 0x040004E7 RID: 1255
		SceneItemStateRequest = 29477,
		// Token: 0x040004E8 RID: 1256
		SceneItemStateResponse = 19635,
		// Token: 0x040004E9 RID: 1257
		EntityLoadCompleteNotify = 29145,
		// Token: 0x040004EA RID: 1258
		MaterialRequest = 18588,
		// Token: 0x040004EB RID: 1259
		MaterialResponse = 22263,
		// Token: 0x040004EC RID: 1260
		MaterialNotify = 29636,
		// Token: 0x040004ED RID: 1261
		CommonOrganResetTimeRequest = 27765,
		// Token: 0x040004EE RID: 1262
		CommonOrganResetTimeResponse = 24405,
		// Token: 0x040004EF RID: 1263
		SceneStepGroupInfoNotify = 24473,
		// Token: 0x040004F0 RID: 1264
		SceneStepInfoNotify = 23865,
		// Token: 0x040004F1 RID: 1265
		TargetGearHitRequest = 15247,
		// Token: 0x040004F2 RID: 1266
		TargetGearHitResponse = 18922,
		// Token: 0x040004F3 RID: 1267
		ThrowDamageRequest = 28170,
		// Token: 0x040004F4 RID: 1268
		ThrowDamageResponse = 26863,
		// Token: 0x040004F5 RID: 1269
		ThrowDamageNotify = 29882,
		// Token: 0x040004F6 RID: 1270
		ThrowDamageRecoveryNotify = 26175,
		// Token: 0x040004F7 RID: 1271
		GetRewardTreasureBoxRequest = 24443,
		// Token: 0x040004F8 RID: 1272
		GetRewardTreasureBoxResponse = 28349,
		// Token: 0x040004F9 RID: 1273
		SettingNotify = 22267,
		// Token: 0x040004FA RID: 1274
		MobileButtonSettingUpdateRequest = 17995,
		// Token: 0x040004FB RID: 1275
		MobileButtonSettingUpdateResponse = 27442,
		// Token: 0x040004FC RID: 1276
		LanguageSettingUpdateRequest = 15385,
		// Token: 0x040004FD RID: 1277
		LanguageSettingUpdateResponse = 27367,
		// Token: 0x040004FE RID: 1278
		ShopInfoRequest = 17320,
		// Token: 0x040004FF RID: 1279
		ShopInfoResponse = 24794,
		// Token: 0x04000500 RID: 1280
		ShopInfoNotify = 19667,
		// Token: 0x04000501 RID: 1281
		ShopBuyRequest = 16667,
		// Token: 0x04000502 RID: 1282
		ShopBuyResponse = 25673,
		// Token: 0x04000503 RID: 1283
		ShopUpdateRequest = 17990,
		// Token: 0x04000504 RID: 1284
		ShopUpdateResponse = 28984,
		// Token: 0x04000505 RID: 1285
		ShopUnlockNotify = 21280,
		// Token: 0x04000506 RID: 1286
		SneakGameStateNotify = 15930,
		// Token: 0x04000507 RID: 1287
		SneakFinishRequest = 20117,
		// Token: 0x04000508 RID: 1288
		SneakFinishResponse = 18398,
		// Token: 0x04000509 RID: 1289
		SpecialItemNotify = 26157,
		// Token: 0x0400050A RID: 1290
		SpecialItemEquipRequest = 25881,
		// Token: 0x0400050B RID: 1291
		SpecialItemEquipResponse = 19540,
		// Token: 0x0400050C RID: 1292
		SpecialItemUnEquipRequest = 22601,
		// Token: 0x0400050D RID: 1293
		SpecialItemUnEquipResponse = 27162,
		// Token: 0x0400050E RID: 1294
		SynthesisInfoRequest = 21275,
		// Token: 0x0400050F RID: 1295
		SynthesisInfoResponse = 15373,
		// Token: 0x04000510 RID: 1296
		SynthesisItemRequest = 17552,
		// Token: 0x04000511 RID: 1297
		SynthesisItemResponse = 24016,
		// Token: 0x04000512 RID: 1298
		SynthesisInfoUpdateNotify = 19611,
		// Token: 0x04000513 RID: 1299
		SynthesisLevelRewardRequest = 17671,
		// Token: 0x04000514 RID: 1300
		SynthesisLevelRewardResponse = 26239,
		// Token: 0x04000515 RID: 1301
		SynthesisLevelUpdateNotify = 17684,
		// Token: 0x04000516 RID: 1302
		SynthesisFormulaUnlockRequest = 23907,
		// Token: 0x04000517 RID: 1303
		SynthesisFormulaUnlockResponse = 17641,
		// Token: 0x04000518 RID: 1304
		TeleportUpdateNotify = 23109,
		// Token: 0x04000519 RID: 1305
		TeleportDataRequest = 22238,
		// Token: 0x0400051A RID: 1306
		TeleportDataResponse = 18941,
		// Token: 0x0400051B RID: 1307
		TeleportTransferRequest = 29918,
		// Token: 0x0400051C RID: 1308
		TeleportTransferResponse = 24923,
		// Token: 0x0400051D RID: 1309
		TeleportNotify = 18633,
		// Token: 0x0400051E RID: 1310
		TeleportFinishRequest = 23654,
		// Token: 0x0400051F RID: 1311
		TeleportFinishResponse = 18021,
		// Token: 0x04000520 RID: 1312
		FallFinishNotify = 24409,
		// Token: 0x04000521 RID: 1313
		UnOpenedAreaPullbackRequest = 22608,
		// Token: 0x04000522 RID: 1314
		UnOpenedAreaPullbackResponse = 16235,
		// Token: 0x04000523 RID: 1315
		TemporaryTeleportAllInfoNotify = 23653,
		// Token: 0x04000524 RID: 1316
		AddTemporaryTeleportInfoNotify = 15428,
		// Token: 0x04000525 RID: 1317
		RemoveTemporaryTeleportNotify = 19531,
		// Token: 0x04000526 RID: 1318
		TemporaryTeleportChangeNotify = 19202,
		// Token: 0x04000527 RID: 1319
		RemoveTemporaryTeleportRequest = 29103,
		// Token: 0x04000528 RID: 1320
		RemoveTemporaryTeleportResponse = 24806,
		// Token: 0x04000529 RID: 1321
		TeleportToTargetRequest = 20294,
		// Token: 0x0400052A RID: 1322
		TeleportToTargetResponse = 16327,
		// Token: 0x0400052B RID: 1323
		ThirdPartySharedNotify = 23622,
		// Token: 0x0400052C RID: 1324
		ThirdPartyShareRequest = 27585,
		// Token: 0x0400052D RID: 1325
		ThirdPartyShareResponse = 29740,
		// Token: 0x0400052E RID: 1326
		TimeStopPush = 23351,
		// Token: 0x0400052F RID: 1327
		RTimeStopRequest = 17578,
		// Token: 0x04000530 RID: 1328
		RTimeStopResponse = 29193,
		// Token: 0x04000531 RID: 1329
		RTimeStopInstRequest = 21786,
		// Token: 0x04000532 RID: 1330
		RTimeStopInstResponse = 29799,
		// Token: 0x04000533 RID: 1331
		TimelineTraceStartRequest = 17394,
		// Token: 0x04000534 RID: 1332
		TimelineTraceStartResponse = 21613,
		// Token: 0x04000535 RID: 1333
		TimelineTraceControlRequest = 17862,
		// Token: 0x04000536 RID: 1334
		TimelineTraceControlResponse = 28330,
		// Token: 0x04000537 RID: 1335
		TimelineTraceExitRequest = 24811,
		// Token: 0x04000538 RID: 1336
		TimelineTraceExitResponse = 26335,
		// Token: 0x04000539 RID: 1337
		TimeCheckRequest = 28306,
		// Token: 0x0400053A RID: 1338
		TimeCheckNotify = 20474,
		// Token: 0x0400053B RID: 1339
		TimeCheckResponse = 17250,
		// Token: 0x0400053C RID: 1340
		TowerRequest = 20908,
		// Token: 0x0400053D RID: 1341
		TowerResponse = 16485,
		// Token: 0x0400053E RID: 1342
		TowerSeasonUpdateRequest = 20997,
		// Token: 0x0400053F RID: 1343
		TowerSeasonUpdateResponse = 18739,
		// Token: 0x04000540 RID: 1344
		TowerFormationRecommendRequest = 16517,
		// Token: 0x04000541 RID: 1345
		TowerFormationRecommendResponse = 18909,
		// Token: 0x04000542 RID: 1346
		TowerRewardRequest = 21982,
		// Token: 0x04000543 RID: 1347
		TowerRewardResponse = 20230,
		// Token: 0x04000544 RID: 1348
		TowerStartRequest = 27135,
		// Token: 0x04000545 RID: 1349
		TowerStartResponse = 18078,
		// Token: 0x04000546 RID: 1350
		TowerResetRequest = 19406,
		// Token: 0x04000547 RID: 1351
		TowerResetResponse = 22328,
		// Token: 0x04000548 RID: 1352
		TowerApplyFloorDataRequest = 25005,
		// Token: 0x04000549 RID: 1353
		TowerApplyFloorDataResponse = 29629,
		// Token: 0x0400054A RID: 1354
		TowerEndNotify = 15343,
		// Token: 0x0400054B RID: 1355
		TowerFloorUpdateNotify = 20319,
		// Token: 0x0400054C RID: 1356
		TowerDifficultyUpdateNotify = 17198,
		// Token: 0x0400054D RID: 1357
		TowerInfoUpdateNotify = 23114,
		// Token: 0x0400054E RID: 1358
		TowerGuideActivityRewardRequest = 28023,
		// Token: 0x0400054F RID: 1359
		TowerGuideActivityRewardResponse = 18982,
		// Token: 0x04000550 RID: 1360
		TowerGuideActivityInfoRequest = 15265,
		// Token: 0x04000551 RID: 1361
		TowerGuideActivityInfoResponse = 18537,
		// Token: 0x04000552 RID: 1362
		TurntableCompleteRequest = 17646,
		// Token: 0x04000553 RID: 1363
		TurntableCompleteResponse = 22465,
		// Token: 0x04000554 RID: 1364
		TutorialInfoRequest = 15592,
		// Token: 0x04000555 RID: 1365
		TutorialInfoResponse = 26976,
		// Token: 0x04000556 RID: 1366
		TutorialUnlockNotify = 28355,
		// Token: 0x04000557 RID: 1367
		TutorialReceiveRequest = 25497,
		// Token: 0x04000558 RID: 1368
		TutorialReceiveResponse = 26141,
		// Token: 0x04000559 RID: 1369
		TutorialUnlockRequest = 26906,
		// Token: 0x0400055A RID: 1370
		TutorialUnlockResponse = 21973,
		// Token: 0x0400055B RID: 1371
		VisionSkillChangeNotify = 15184,
		// Token: 0x0400055C RID: 1372
		WeaponLevelUpRequest = 28155,
		// Token: 0x0400055D RID: 1373
		WeaponLevelUpResponse = 21842,
		// Token: 0x0400055E RID: 1374
		WeaponBreachRequest = 17857,
		// Token: 0x0400055F RID: 1375
		WeaponBreachResponse = 24159,
		// Token: 0x04000560 RID: 1376
		WeaponResonUpRequest = 27212,
		// Token: 0x04000561 RID: 1377
		WeaponResonUpResponse = 24490,
		// Token: 0x04000562 RID: 1378
		WeaponAllInfoNotify = 19780,
		// Token: 0x04000563 RID: 1379
		WeaponAddNotify = 18560,
		// Token: 0x04000564 RID: 1380
		WeaponRemoveNotify = 25207,
		// Token: 0x04000565 RID: 1381
		WorldLevelDownRequest = 16824,
		// Token: 0x04000566 RID: 1382
		WorldLevelDownResponse = 27079,
		// Token: 0x04000567 RID: 1383
		WorldLevelRegainRequest = 20287,
		// Token: 0x04000568 RID: 1384
		WorldLevelRegainResponse = 22321,
		// Token: 0x04000569 RID: 1385
		WorldEnterPermissionsRequest = 24417,
		// Token: 0x0400056A RID: 1386
		WorldEnterPermissionsResponse = 26732,
		// Token: 0x0400056B RID: 1387
		ApplyJoinWorldRequest = 26630,
		// Token: 0x0400056C RID: 1388
		ApplyJoinWorldResponse = 24536,
		// Token: 0x0400056D RID: 1389
		ApplyJoinWorldNotify = 15258,
		// Token: 0x0400056E RID: 1390
		AgreeJoinResultRequest = 23449,
		// Token: 0x0400056F RID: 1391
		AgreeJoinResultResponse = 19703,
		// Token: 0x04000570 RID: 1392
		AgreeJoinResultNotify = 20337,
		// Token: 0x04000571 RID: 1393
		ApplyerEnterSceneNotify = 20705,
		// Token: 0x04000572 RID: 1394
		AllApplyJoinNotify = 28635,
		// Token: 0x04000573 RID: 1395
		LobbyListRequest = 27091,
		// Token: 0x04000574 RID: 1396
		LobbyListResponse = 16660,
		// Token: 0x04000575 RID: 1397
		LobbyQueryPlayersRequest = 27293,
		// Token: 0x04000576 RID: 1398
		LobbyQueryPlayersResponse = 23831,
		// Token: 0x04000577 RID: 1399
		WorldTeamPlayerInfoChangeNotify = 24636,
		// Token: 0x04000578 RID: 1400
		JoinWorldTeamNotify = 24920,
		// Token: 0x04000579 RID: 1401
		PlayerLeaveWorldTeamNotify = 15054,
		// Token: 0x0400057A RID: 1402
		PlayerEnterWorldTeamNotify = 19236,
		// Token: 0x0400057B RID: 1403
		LeaveWorldTeamRequest = 25798,
		// Token: 0x0400057C RID: 1404
		LeaveWorldTeamResponse = 16965,
		// Token: 0x0400057D RID: 1405
		KickWorldTeamRequest = 23500,
		// Token: 0x0400057E RID: 1406
		KickWorldTeamResponse = 19020,
		// Token: 0x0400057F RID: 1407
		RobotDestinationPush = 20295,
		// Token: 0x04000580 RID: 1408
		RobotDestinationNotify = 20116,
		// Token: 0x04000581 RID: 1409
		UpdateWorldTeamPlayerFightInfoNotify = 18073,
		// Token: 0x04000582 RID: 1410
		PlayerNetStatePush = 17456,
		// Token: 0x04000583 RID: 1411
		PlayerNetStateNotify = 20034,
		// Token: 0x04000584 RID: 1412
		PlayerTeleportStateNotify = 27500,
		// Token: 0x04000585 RID: 1413
		SignatureUpdateNotify = 20375,
		// Token: 0x04000586 RID: 1414
		EntityBeamReceiveRequest = 27206,
		// Token: 0x04000587 RID: 1415
		EntityBeamReceiveResponse = 21799,
		// Token: 0x04000588 RID: 1416
		AttachEntityRequest = 22935,
		// Token: 0x04000589 RID: 1417
		AttachEntityResponse = 16598,
		// Token: 0x0400058A RID: 1418
		EntityAttachChangeNotify = 15996,
		// Token: 0x0400058B RID: 1419
		EntityPatrolAddTagRequest = 24527,
		// Token: 0x0400058C RID: 1420
		EntityPatrolAddTagResponse = 26261,
		// Token: 0x0400058D RID: 1421
		BattleScoreNotify = 17365,
		// Token: 0x0400058E RID: 1422
		LongShanStageUpdateNotify = 24809,
		// Token: 0x0400058F RID: 1423
		LongShanTaskRewardRequest = 25899,
		// Token: 0x04000590 RID: 1424
		LongShanTaskRewardResponse = 22021,
		// Token: 0x04000591 RID: 1425
		MultiMapInfoNotify = 29652,
		// Token: 0x04000592 RID: 1426
		UnlockMapBlockNotify = 15090,
		// Token: 0x04000593 RID: 1427
		UnlockMultiMapNotify = 21647,
		// Token: 0x04000594 RID: 1428
		EntityAccessRangeRequest = 23148,
		// Token: 0x04000595 RID: 1429
		EntityAccessRangeResponse = 22572,
		// Token: 0x04000596 RID: 1430
		PlayerAccessRangeRequest = 26712,
		// Token: 0x04000597 RID: 1431
		PlayerAccessRangeResponse = 19314,
		// Token: 0x04000598 RID: 1432
		EntityAccessRangeNotify = 24009,
		// Token: 0x04000599 RID: 1433
		PlayerAccessRangeNotify = 19051,
		// Token: 0x0400059A RID: 1434
		TrampleGearTransitionNotify = 26985,
		// Token: 0x0400059B RID: 1435
		RoguelikePopularEntriesInfoRequest = 29132,
		// Token: 0x0400059C RID: 1436
		RoguelikePopularEntriesInfoResponse = 24291,
		// Token: 0x0400059D RID: 1437
		RoguelikePopularEntriesChangeRequest = 19865,
		// Token: 0x0400059E RID: 1438
		RoguelikePopularEntriesChangeResponse = 25998,
		// Token: 0x0400059F RID: 1439
		PlayerSkillInfoPbNotify = 20458,
		// Token: 0x040005A0 RID: 1440
		SwitchSceneGroupNotify = 23134,
		// Token: 0x040005A1 RID: 1441
		UpdateSceneGroupDataNotify = 17286,
		// Token: 0x040005A2 RID: 1442
		AfterJoinSceneNotify = 22156,
		// Token: 0x040005A3 RID: 1443
		HookLockPointFinishRequest = 17312,
		// Token: 0x040005A4 RID: 1444
		HookLockPointFinishResponse = 15889,
		// Token: 0x040005A5 RID: 1445
		BuildingLevelUpRequest = 28202,
		// Token: 0x040005A6 RID: 1446
		BuildingLevelUpResponse = 22769,
		// Token: 0x040005A7 RID: 1447
		RoleTrainRequest = 22959,
		// Token: 0x040005A8 RID: 1448
		RoleTrainResponse = 26024,
		// Token: 0x040005A9 RID: 1449
		AcceptEntrustRequest = 15620,
		// Token: 0x040005AA RID: 1450
		AcceptEntrustResponse = 29986,
		// Token: 0x040005AB RID: 1451
		InvestRequest = 20937,
		// Token: 0x040005AC RID: 1452
		InvestResponse = 21729,
		// Token: 0x040005AD RID: 1453
		TrackMoonEntrustDataRequest = 21209,
		// Token: 0x040005AE RID: 1454
		TrackMoonEntrustDataResponse = 17258,
		// Token: 0x040005AF RID: 1455
		TrackMoonRoleDataRequest = 15705,
		// Token: 0x040005B0 RID: 1456
		TrackMoonRoleDataResponse = 29783,
		// Token: 0x040005B1 RID: 1457
		RunTurntableActivityRequest = 15475,
		// Token: 0x040005B2 RID: 1458
		RunTurntableActivityResponse = 26481,
		// Token: 0x040005B3 RID: 1459
		TrackMoonBuildingDataRequest = 15645,
		// Token: 0x040005B4 RID: 1460
		TrackMoonBuildingDataResponse = 20309,
		// Token: 0x040005B5 RID: 1461
		BuildingUnLockRequest = 20679,
		// Token: 0x040005B6 RID: 1462
		BuildingUnLockResponse = 22569,
		// Token: 0x040005B7 RID: 1463
		AudioStateUpdateNotify = 16806,
		// Token: 0x040005B8 RID: 1464
		BossRushClaimRewardRequest = 29802,
		// Token: 0x040005B9 RID: 1465
		BossRushClaimRewardResponse = 20167,
		// Token: 0x040005BA RID: 1466
		BossRushSettlementRequest = 24466,
		// Token: 0x040005BB RID: 1467
		BossRushSettlementResponse = 15915,
		// Token: 0x040005BC RID: 1468
		BossRushResultNotify = 28412,
		// Token: 0x040005BD RID: 1469
		BossRushLevelInfoNotify = 24337,
		// Token: 0x040005BE RID: 1470
		TrackMoonConditionNotify = 29252,
		// Token: 0x040005BF RID: 1471
		EntityVarUpdateNotify = 18216,
		// Token: 0x040005C0 RID: 1472
		SceneModeChangeFinishRequest = 19453,
		// Token: 0x040005C1 RID: 1473
		SceneModeChangeFinishResponse = 15283,
		// Token: 0x040005C2 RID: 1474
		RoguelikeGainDataUpdateNotify = 26618,
		// Token: 0x040005C3 RID: 1475
		OutputDebugInfoNotify = 19792,
		// Token: 0x040005C4 RID: 1476
		RoguelikeTrialRoleInfoRequest = 18768,
		// Token: 0x040005C5 RID: 1477
		RoguelikeTrialRoleInfoResponse = 28212,
		// Token: 0x040005C6 RID: 1478
		PhotoMemoryRequest = 16350,
		// Token: 0x040005C7 RID: 1479
		PhotoMemoryResponse = 24419,
		// Token: 0x040005C8 RID: 1480
		PhotoMemoryUpdateNotify = 28595,
		// Token: 0x040005C9 RID: 1481
		PhotoMemoryCollectNotify = 16791,
		// Token: 0x040005CA RID: 1482
		PhotoMemoryRewardRequest = 15289,
		// Token: 0x040005CB RID: 1483
		PhotoMemoryRewardResponse = 16842,
		// Token: 0x040005CC RID: 1484
		ChangeSceneModeEndNotify = 27746,
		// Token: 0x040005CD RID: 1485
		SceneItemSetPosSenderRequest = 19577,
		// Token: 0x040005CE RID: 1486
		SceneItemSetPosSenderResponse = 25717,
		// Token: 0x040005CF RID: 1487
		SceneItemSetPosSenderNotify = 16894,
		// Token: 0x040005D0 RID: 1488
		TraceEntityPosRequest = 16467,
		// Token: 0x040005D1 RID: 1489
		TraceEntityPosResponse = 25394,
		// Token: 0x040005D2 RID: 1490
		CombatMessagePrefixInfoRequest = 21140,
		// Token: 0x040005D3 RID: 1491
		CombatMessagePrefixInfoResponse = 26444,
		// Token: 0x040005D4 RID: 1492
		CombatMessagePostInfoRequest = 15505,
		// Token: 0x040005D5 RID: 1493
		CombatMessagePostInfoResponse = 20596,
		// Token: 0x040005D6 RID: 1494
		TrackMoonTargetRewardRequest = 17884,
		// Token: 0x040005D7 RID: 1495
		TrackMoonTargetRewardResponse = 26623,
		// Token: 0x040005D8 RID: 1496
		TrackMoonTargetUpdateNotify = 22048,
		// Token: 0x040005D9 RID: 1497
		FsmStateBehaviorRequest = 15369,
		// Token: 0x040005DA RID: 1498
		FsmStateBehaviorResponse = 18875,
		// Token: 0x040005DB RID: 1499
		FsmPlayMontageRequest = 25452,
		// Token: 0x040005DC RID: 1500
		FsmPlayMontageResponse = 22825,
		// Token: 0x040005DD RID: 1501
		RTimeStopAnimRequest = 28204,
		// Token: 0x040005DE RID: 1502
		RTimeStopAnimResponse = 20676,
		// Token: 0x040005DF RID: 1503
		RolePropRequest = 22020,
		// Token: 0x040005E0 RID: 1504
		RolePropResponse = 19787,
		// Token: 0x040005E1 RID: 1505
		PlayerLivingStatesNotify = 22492,
		// Token: 0x040005E2 RID: 1506
		TrackMoonSettleRequest = 22986,
		// Token: 0x040005E3 RID: 1507
		TrackMoonSettleResponse = 21671,
		// Token: 0x040005E4 RID: 1508
		TrackMoonIllustratedRequest = 18233,
		// Token: 0x040005E5 RID: 1509
		TrackMoonIllustratedResponse = 18884,
		// Token: 0x040005E6 RID: 1510
		TrackMoonIllustratedNotify = 18595,
		// Token: 0x040005E7 RID: 1511
		BossRushFailResultNotify = 28650,
		// Token: 0x040005E8 RID: 1512
		TowerDefenceInfoUpdateNotify = 18554,
		// Token: 0x040005E9 RID: 1513
		TowerDefenceInstanceInfoUpdateNotify = 27413,
		// Token: 0x040005EA RID: 1514
		TowerDefencePhantomInfoUpdateNotify = 24798,
		// Token: 0x040005EB RID: 1515
		TowerDefenceInstanceRewardRequest = 28922,
		// Token: 0x040005EC RID: 1516
		TowerDefenceInstanceRewardResponse = 23869,
		// Token: 0x040005ED RID: 1517
		TowerDefenceScoreRewardRequest = 17847,
		// Token: 0x040005EE RID: 1518
		TowerDefenceScoreRewardResponse = 21331,
		// Token: 0x040005EF RID: 1519
		TowerDefenceEndNotify = 27964,
		// Token: 0x040005F0 RID: 1520
		FlowTeleportToPlotPosRequest = 16785,
		// Token: 0x040005F1 RID: 1521
		FlowTeleportToPlotPosResponse = 27445,
		// Token: 0x040005F2 RID: 1522
		ConnectorConnectEntityRequest = 29122,
		// Token: 0x040005F3 RID: 1523
		ConnectorConnectEntityResponse = 21486,
		// Token: 0x040005F4 RID: 1524
		ConnectorConnectEntityNotify = 21398,
		// Token: 0x040005F5 RID: 1525
		BeControlledEntityHoverRequest = 15453,
		// Token: 0x040005F6 RID: 1526
		BeControlledEntityHoverResponse = 15043,
		// Token: 0x040005F7 RID: 1527
		InitRangeRequest = 29050,
		// Token: 0x040005F8 RID: 1528
		InitRangeResponse = 19814,
		// Token: 0x040005F9 RID: 1529
		TrackMoonActivityRewardRequest = 26656,
		// Token: 0x040005FA RID: 1530
		TrackMoonActivityRewardResponse = 18470,
		// Token: 0x040005FB RID: 1531
		TimePointActivityRewardRequest = 21232,
		// Token: 0x040005FC RID: 1532
		TimePointActivityRewardResponse = 28642,
		// Token: 0x040005FD RID: 1533
		NameModifyNotify = 24589,
		// Token: 0x040005FE RID: 1534
		FirecrackerEntityCreatedNotify = 21194,
		// Token: 0x040005FF RID: 1535
		CircumFluenceTaskRewardRequest = 17180,
		// Token: 0x04000600 RID: 1536
		CircumFluenceTaskRewardResponse = 19238,
		// Token: 0x04000601 RID: 1537
		PlayerFollowerNotify = 27918,
		// Token: 0x04000602 RID: 1538
		GameplayCueRequest = 20103,
		// Token: 0x04000603 RID: 1539
		GameplayCueResponse = 21252,
		// Token: 0x04000604 RID: 1540
		GameplayCueNotify = 29715,
		// Token: 0x04000605 RID: 1541
		SceneItemStopRequest = 26861,
		// Token: 0x04000606 RID: 1542
		SceneItemStopResponse = 23071,
		// Token: 0x04000607 RID: 1543
		TowerDefenceEnterInstNotify = 21747,
		// Token: 0x04000608 RID: 1544
		ServerCommandNotify = 21667,
		// Token: 0x04000609 RID: 1545
		RoguelikeRoleRoomNotify = 15652,
		// Token: 0x0400060A RID: 1546
		RoguelikeRoleRoomSelectRequest = 26267,
		// Token: 0x0400060B RID: 1547
		RoguelikeRoleRoomSelectResponse = 27983,
		// Token: 0x0400060C RID: 1548
		SetNpcPerformStateNotify = 20027,
		// Token: 0x0400060D RID: 1549
		BattleAntiCheatingLogNotify = 24393,
		// Token: 0x0400060E RID: 1550
		SecFBRoundStartFlowRequest = 28936,
		// Token: 0x0400060F RID: 1551
		SecFBRoundStartFlowResponse = 18546,
		// Token: 0x04000610 RID: 1552
		SecGetReportData2FlowRequest = 27333,
		// Token: 0x04000611 RID: 1553
		SecGetReportData2FlowResponse = 27302,
		// Token: 0x04000612 RID: 1554
		SecFBRoundEndFlowReportRequest = 28654,
		// Token: 0x04000613 RID: 1555
		SecFBRoundEndFlowReportResponse = 28053,
		// Token: 0x04000614 RID: 1556
		SecRoleFightFlowRequest = 23744,
		// Token: 0x04000615 RID: 1557
		SecRoleFightFlowResponse = 16148,
		// Token: 0x04000616 RID: 1558
		SecWorldInfoFlowRequest = 18083,
		// Token: 0x04000617 RID: 1559
		SecWorldInfoFlowResponse = 24938,
		// Token: 0x04000618 RID: 1560
		SecWorldStartFlowRequest = 18243,
		// Token: 0x04000619 RID: 1561
		SecWorldStartFlowResponse = 27691,
		// Token: 0x0400061A RID: 1562
		SecWorldSEndFlowRequest = 23884,
		// Token: 0x0400061B RID: 1563
		AwakeDynamicPortalRequest = 25931,
		// Token: 0x0400061C RID: 1564
		AwakeDynamicPortalResponse = 29309,
		// Token: 0x0400061D RID: 1565
		TimeResetNotify = 21493,
		// Token: 0x0400061E RID: 1566
		GachaPoolDetailRequest = 28380,
		// Token: 0x0400061F RID: 1567
		GachaPoolDetailResponse = 26540,
		// Token: 0x04000620 RID: 1568
		SecWorldSEndFlowResponse = 18732,
		// Token: 0x04000621 RID: 1569
		ActionOpenSystemBoardNotify = 28172,
		// Token: 0x04000622 RID: 1570
		OpenSystemBoardResultRequest = 20900,
		// Token: 0x04000623 RID: 1571
		OpenSystemBoardResultResponse = 17436,
		// Token: 0x04000624 RID: 1572
		SceneItemMoveTargetRequest = 20302,
		// Token: 0x04000625 RID: 1573
		SceneItemMoveTargetNotify = 15478,
		// Token: 0x04000626 RID: 1574
		SceneItemMoveTargetResponse = 17935,
		// Token: 0x04000627 RID: 1575
		EntityTimeFlowPush = 25999,
		// Token: 0x04000628 RID: 1576
		TrackMoonRolePropChangeNotify = 24089,
		// Token: 0x04000629 RID: 1577
		TrackMoonBuildFlowRequest = 18395,
		// Token: 0x0400062A RID: 1578
		TrackMoonBuildFlowResponse = 18212,
		// Token: 0x0400062B RID: 1579
		CorniceMeetingRewardRequest = 26725,
		// Token: 0x0400062C RID: 1580
		CorniceMeetingRewardResponse = 22628,
		// Token: 0x0400062D RID: 1581
		CorniceChallengeEndNotify = 16495,
		// Token: 0x0400062E RID: 1582
		QuestChangeTraceNotify = 16354,
		// Token: 0x0400062F RID: 1583
		TraceMoonPhaseRewardRequest = 15762,
		// Token: 0x04000630 RID: 1584
		TraceMoonPhaseRewardResponse = 18742,
		// Token: 0x04000631 RID: 1585
		TrackMoonTokenCoinNotify = 20701,
		// Token: 0x04000632 RID: 1586
		LevelPlaySwitchSportModeRequest = 19509,
		// Token: 0x04000633 RID: 1587
		LevelPlaySwitchSportModeResponse = 22082,
		// Token: 0x04000634 RID: 1588
		PlayerPsnInfoGetRequest = 20153,
		// Token: 0x04000635 RID: 1589
		PlayerPsnInfoGetResponse = 15989,
		// Token: 0x04000636 RID: 1590
		PsnSettingUpdateRequest = 19585,
		// Token: 0x04000637 RID: 1591
		PsnSettingUpdateResponse = 18454,
		// Token: 0x04000638 RID: 1592
		PsnSettingRequest = 24714,
		// Token: 0x04000639 RID: 1593
		PsnSettingResponse = 24512,
		// Token: 0x0400063A RID: 1594
		RiskHarvestEndNotify = 25092,
		// Token: 0x0400063B RID: 1595
		RiskHarvestInstUpdateNotify = 20169,
		// Token: 0x0400063C RID: 1596
		RiskHarvestArtifactNotify = 23260,
		// Token: 0x0400063D RID: 1597
		RiskHarvestInstRewardRequest = 27572,
		// Token: 0x0400063E RID: 1598
		RiskHarvestScoreRewardRequest = 21426,
		// Token: 0x0400063F RID: 1599
		RiskHarvestScoreRewardResponse = 27124,
		// Token: 0x04000640 RID: 1600
		RiskHarvestBuffUpdateNotify = 17563,
		// Token: 0x04000641 RID: 1601
		RiskHarvestBuffUnlockNotify = 18477,
		// Token: 0x04000642 RID: 1602
		ItemDisuseRequest = 23288,
		// Token: 0x04000643 RID: 1603
		ItemDisuseResponse = 29774,
		// Token: 0x04000644 RID: 1604
		PhantomBatchRefiningRequest = 15619,
		// Token: 0x04000645 RID: 1605
		PhantomBatchRefiningResponse = 22170,
		// Token: 0x04000646 RID: 1606
		RiskHarvestInstRewardResponse = 29859,
		// Token: 0x04000647 RID: 1607
		PassPortalRequest = 26467,
		// Token: 0x04000648 RID: 1608
		PassPortalResponse = 19351,
		// Token: 0x04000649 RID: 1609
		BtRangeFailWarningNotify = 15770,
		// Token: 0x0400064A RID: 1610
		BtCancelRangeFailWarningNotify = 19492,
		// Token: 0x0400064B RID: 1611
		EnrichmentAreaRequest = 29419,
		// Token: 0x0400064C RID: 1612
		EnrichmentAreaResponse = 18556,
		// Token: 0x0400064D RID: 1613
		RiskHarvestBuffUnlockRewardRequest = 28209,
		// Token: 0x0400064E RID: 1614
		RiskHarvestBuffUnlockRewardResponse = 21018,
		// Token: 0x0400064F RID: 1615
		RiskHarvestBuffCountRewardRequest = 15493,
		// Token: 0x04000650 RID: 1616
		RiskHarvestBuffCountRewardResponse = 20737,
		// Token: 0x04000651 RID: 1617
		RiskHarvestActivityUpdateNotify = 26346,
		// Token: 0x04000652 RID: 1618
		BlackCoastThemeStageUpdateNotify = 26169,
		// Token: 0x04000653 RID: 1619
		BlackCoastThemeTaskRewardRequest = 22379,
		// Token: 0x04000654 RID: 1620
		BlackCoastThemeTaskRewardResponse = 28490,
		// Token: 0x04000655 RID: 1621
		BlackCoastThemeActiveRewardRequest = 23707,
		// Token: 0x04000656 RID: 1622
		BlackCoastThemeActiveRewardResponse = 28700,
		// Token: 0x04000657 RID: 1623
		PlayerCreatePsnSessionRequest = 29372,
		// Token: 0x04000658 RID: 1624
		PlayerCreatePsnSessionResponse = 23299,
		// Token: 0x04000659 RID: 1625
		PlayerPsnSessionNotify = 16152,
		// Token: 0x0400065A RID: 1626
		PortalReplaceNotify = 18706,
		// Token: 0x0400065B RID: 1627
		RenjuResetRequest = 20123,
		// Token: 0x0400065C RID: 1628
		RenjuResetResponse = 28995,
		// Token: 0x0400065D RID: 1629
		CorniceChallengeTransRequest = 29837,
		// Token: 0x0400065E RID: 1630
		CorniceChallengeTransResponse = 26808,
		// Token: 0x0400065F RID: 1631
		FightDataCheckNotify = 17021,
		// Token: 0x04000660 RID: 1632
		GameplayTagRequest = 25844,
		// Token: 0x04000661 RID: 1633
		GameplayTagResponse = 28943,
		// Token: 0x04000662 RID: 1634
		ExecuteQteRequest = 29269,
		// Token: 0x04000663 RID: 1635
		ExecuteQteResponse = 26990,
		// Token: 0x04000664 RID: 1636
		TowerDefenceRoleReviveNotify = 16084,
		// Token: 0x04000665 RID: 1637
		TowerDefencePlayerReviveNotify = 18289,
		// Token: 0x04000666 RID: 1638
		LevelPlayerRewardHintNotify = 29490,
		// Token: 0x04000667 RID: 1639
		RiskHarvestSettleRequest = 18062,
		// Token: 0x04000668 RID: 1640
		RiskHarvestSettleResponse = 28863,
		// Token: 0x04000669 RID: 1641
		AppGradeNotify = 15895,
		// Token: 0x0400066A RID: 1642
		LinkingStateNotify = 28844,
		// Token: 0x0400066B RID: 1643
		LinkExitNotify = 26223,
		// Token: 0x0400066C RID: 1644
		MingSuHandRewardRequest = 28128,
		// Token: 0x0400066D RID: 1645
		MingSuHandRewardResponse = 16113,
		// Token: 0x0400066E RID: 1646
		SubmitAwakeAndLoadEntityNodeRequest = 26833,
		// Token: 0x0400066F RID: 1647
		SubmitAwakeAndLoadEntityNodeResponse = 29216,
		// Token: 0x04000670 RID: 1648
		RogueWhiteCatDataUpdateNotify = 26688,
		// Token: 0x04000671 RID: 1649
		RoguelikeRoleInstStartRequest = 17317,
		// Token: 0x04000672 RID: 1650
		RoguelikeRoleInstStartResponse = 16214,
		// Token: 0x04000673 RID: 1651
		RoguelikeBossInstStartRequest = 23564,
		// Token: 0x04000674 RID: 1652
		RoguelikeBossInstStartResponse = 17253,
		// Token: 0x04000675 RID: 1653
		PreheatSignRewardRequest = 29281,
		// Token: 0x04000676 RID: 1654
		PreheatSignRewardResponse = 15694,
		// Token: 0x04000677 RID: 1655
		PreheatSignSurveyInfoRequest = 16302,
		// Token: 0x04000678 RID: 1656
		PreheatSignSurveyInfoResponse = 24249,
		// Token: 0x04000679 RID: 1657
		UpdateEnableFunctionNotify = 24510,
		// Token: 0x0400067A RID: 1658
		DarkCoastInfoRequest = 29597,
		// Token: 0x0400067B RID: 1659
		DarkCoastInfoResponse = 20782,
		// Token: 0x0400067C RID: 1660
		InputSettingRequest = 17784,
		// Token: 0x0400067D RID: 1661
		InputSettingResponse = 18992,
		// Token: 0x0400067E RID: 1662
		InputSettingUpdateRequest = 29143,
		// Token: 0x0400067F RID: 1663
		InputSettingUpdateResponse = 29097,
		// Token: 0x04000680 RID: 1664
		InputSettingUpdateNotify = 18450,
		// Token: 0x04000681 RID: 1665
		MapCustomMarkUpdateNotify = 20105,
		// Token: 0x04000682 RID: 1666
		RoguelikeWriteCatRewardRequest = 25605,
		// Token: 0x04000683 RID: 1667
		RoguelikeWriteCatRewardResponse = 28034,
		// Token: 0x04000684 RID: 1668
		PayGiftConditionFinishNotify = 22528,
		// Token: 0x04000685 RID: 1669
		GetDebugInfoNotify = 15849,
		// Token: 0x04000686 RID: 1670
		ConnectorCanConnectRequest = 19355,
		// Token: 0x04000687 RID: 1671
		ConnectorCanConnectResponse = 29950,
		// Token: 0x04000688 RID: 1672
		ScratchCardRewardRequest = 28502,
		// Token: 0x04000689 RID: 1673
		ScratchCardRewardResponse = 18651,
		// Token: 0x0400068A RID: 1674
		TeleportDungeonActionNotify = 18177,
		// Token: 0x0400068B RID: 1675
		TeleportDungeonActionRequest = 25153,
		// Token: 0x0400068C RID: 1676
		TeleportDungeonActionResponse = 17189,
		// Token: 0x0400068D RID: 1677
		SceneItemAttributeChangeNotify = 18254,
		// Token: 0x0400068E RID: 1678
		SubmitWalkingPatternPointRequest = 25883,
		// Token: 0x0400068F RID: 1679
		SubmitWalkingPatternPointResponse = 24149,
		// Token: 0x04000690 RID: 1680
		AchievementCountChangeNotify = 28476,
		// Token: 0x04000691 RID: 1681
		RoguelikeWriteCatBossRewardRequest = 25187,
		// Token: 0x04000692 RID: 1682
		RoguelikeWriteCatBossRewardResponse = 21248,
		// Token: 0x04000693 RID: 1683
		RoguelikeWriteCatLevelPlayRewardRequest = 24513,
		// Token: 0x04000694 RID: 1684
		RoguelikeWriteCatLevelPlayRewardResponse = 25902,
		// Token: 0x04000695 RID: 1685
		PlayerPsnBlockListRequest = 18200,
		// Token: 0x04000696 RID: 1686
		PlayerPsnBlockListResponse = 26528,
		// Token: 0x04000697 RID: 1687
		VacuumCleanerRequest = 23579,
		// Token: 0x04000698 RID: 1688
		VacuumCleanerResponse = 23100,
		// Token: 0x04000699 RID: 1689
		BossRushChooseBuffRequest = 24869,
		// Token: 0x0400069A RID: 1690
		BossRushChooseBuffResponse = 16679,
		// Token: 0x0400069B RID: 1691
		BossRushBuffChooseResultRequest = 23993,
		// Token: 0x0400069C RID: 1692
		BossRushBuffChooseResultResponse = 21177,
		// Token: 0x0400069D RID: 1693
		ContextIdNotify = 16119,
		// Token: 0x0400069E RID: 1694
		ExecuteQteNotify = 20131,
		// Token: 0x0400069F RID: 1695
		JoinSceneNotifyConfirmRequest = 27120,
		// Token: 0x040006A0 RID: 1696
		JoinSceneNotifyConfirmResponse = 29017,
		// Token: 0x040006A1 RID: 1697
		SyncPlayerLocationNotify = 16455,
		// Token: 0x040006A2 RID: 1698
		MailBindInfoRequest = 26354,
		// Token: 0x040006A3 RID: 1699
		MailBindRewardRequest = 26509,
		// Token: 0x040006A4 RID: 1700
		MailBindRewardResponse = 15814,
		// Token: 0x040006A5 RID: 1701
		MailBindInfoResponse = 26430,
		// Token: 0x040006A6 RID: 1702
		MailBindRequest = 25162,
		// Token: 0x040006A7 RID: 1703
		MailBindResponse = 20479,
		// Token: 0x040006A8 RID: 1704
		MailBindInfoNotify = 16566,
		// Token: 0x040006A9 RID: 1705
		PrivateChatClearNotify = 21637,
		// Token: 0x040006AA RID: 1706
		HookLockPointExitRequest = 28147,
		// Token: 0x040006AB RID: 1707
		HookLockPointExitResponse = 18710,
		// Token: 0x040006AC RID: 1708
		ScratchCardCountInfoNotify = 29035,
		// Token: 0x040006AD RID: 1709
		WeaponSkinAddNotify = 21360,
		// Token: 0x040006AE RID: 1710
		WeaponSkinUnLoadNotify = 20040,
		// Token: 0x040006AF RID: 1711
		VehicleRequest = 29971,
		// Token: 0x040006B0 RID: 1712
		VehicleResponse = 18852,
		// Token: 0x040006B1 RID: 1713
		PullingFoundationRequest = 25845,
		// Token: 0x040006B2 RID: 1714
		PullingFoundationResponse = 29401,
		// Token: 0x040006B3 RID: 1715
		ItemRelateFoundationNotify = 20976,
		// Token: 0x040006B4 RID: 1716
		AddTreasureBoxSlotRequest = 24696,
		// Token: 0x040006B5 RID: 1717
		AddTreasureBoxSlotResponse = 29769,
		// Token: 0x040006B6 RID: 1718
		RemoveTreasureBoxSlotRequest = 15750,
		// Token: 0x040006B7 RID: 1719
		RemoveTreasureBoxSlotResponse = 27840,
		// Token: 0x040006B8 RID: 1720
		UseSoundBoxSkillRequest = 26214,
		// Token: 0x040006B9 RID: 1721
		UseSoundBoxSkillResponse = 29780,
		// Token: 0x040006BA RID: 1722
		AddTemporaryTeleportRequest = 29476,
		// Token: 0x040006BB RID: 1723
		AddTemporaryTeleportResponse = 17932,
		// Token: 0x040006BC RID: 1724
		VehicleUpdateNotify = 23879,
		// Token: 0x040006BD RID: 1725
		BossRushLevelScoreRewardRequest = 23421,
		// Token: 0x040006BE RID: 1726
		BossRushLevelScoreRewardResponse = 28357,
		// Token: 0x040006BF RID: 1727
		EquipSkinTakeOnRequest = 26203,
		// Token: 0x040006C0 RID: 1728
		EquipSkinTakeOnResponse = 24452,
		// Token: 0x040006C1 RID: 1729
		EquipSkinUnLoadRequest = 16068,
		// Token: 0x040006C2 RID: 1730
		EquipSkinUnLoadResponse = 16037,
		// Token: 0x040006C3 RID: 1731
		SubmitPhotoNodeRequest = 25793,
		// Token: 0x040006C4 RID: 1732
		SubmitPhotoNodeResponse = 29717,
		// Token: 0x040006C5 RID: 1733
		EntityPreloadNotify = 24436,
		// Token: 0x040006C6 RID: 1734
		QuestRollBackEndNotify = 15053,
		// Token: 0x040006C7 RID: 1735
		TreasureBoxSlotAllInfoNotify = 20020,
		// Token: 0x040006C8 RID: 1736
		RogueWhiteCatLimitedUpdateNotify = 17645,
		// Token: 0x040006C9 RID: 1737
		RogueWhiteCatLimitedRewardRequest = 18506,
		// Token: 0x040006CA RID: 1738
		RogueWhiteCatLimitedRewardResponse = 25642,
		// Token: 0x040006CB RID: 1739
		EntityEquipSkinChangeNotify = 23591,
		// Token: 0x040006CC RID: 1740
		ScratchCardActivityInfoRequest = 28606,
		// Token: 0x040006CD RID: 1741
		ScratchCardActivityInfoResponse = 16768,
		// Token: 0x040006CE RID: 1742
		QuestGiveUpNotify = 29826,
		// Token: 0x040006CF RID: 1743
		QuestReadyForGiveUpRequest = 19607,
		// Token: 0x040006D0 RID: 1744
		QuestReadyForGiveUpResponse = 20397,
		// Token: 0x040006D1 RID: 1745
		BattleScoreEnableNotify = 20406,
		// Token: 0x040006D2 RID: 1746
		ModifyEntityCampNotify = 28258,
		// Token: 0x040006D3 RID: 1747
		RogueWhiteCatRecordRequest = 23656,
		// Token: 0x040006D4 RID: 1748
		RogueWhiteCatRecordResponse = 15186,
		// Token: 0x040006D5 RID: 1749
		SetAlertUiVisibleRequest = 15594,
		// Token: 0x040006D6 RID: 1750
		SetAlertUiVisibleResponse = 19633,
		// Token: 0x040006D7 RID: 1751
		AlertAreaNotify = 26602,
		// Token: 0x040006D8 RID: 1752
		CombineEntitiesRequest = 19641,
		// Token: 0x040006D9 RID: 1753
		AddCombineEntitiesRelationNotify = 25278,
		// Token: 0x040006DA RID: 1754
		RemoveCombineRelationNotify = 17117,
		// Token: 0x040006DB RID: 1755
		CombineEntitiesResponse = 17364,
		// Token: 0x040006DC RID: 1756
		GiftPackPreviewRequest = 16675,
		// Token: 0x040006DD RID: 1757
		GiftPackPreviewResponse = 25776,
		// Token: 0x040006DE RID: 1758
		LastBigSceneMiniMapInfoRequest = 16921,
		// Token: 0x040006DF RID: 1759
		LastBigSceneMiniMapInfoResponse = 23770,
		// Token: 0x040006E0 RID: 1760
		DissolveCombineRelationRequest = 21623,
		// Token: 0x040006E1 RID: 1761
		DissolveCombineRelationResponse = 23102,
		// Token: 0x040006E2 RID: 1762
		RogueLevelPlayNotify = 21815,
		// Token: 0x040006E3 RID: 1763
		ActionRelatedEntityInfoNotify = 16914,
		// Token: 0x040006E4 RID: 1764
		GachaNewNotify = 18079,
		// Token: 0x040006E5 RID: 1765
		ExploreSkillCustomRequest = 25431,
		// Token: 0x040006E6 RID: 1766
		ExploreSkillCustomResponse = 29046,
		// Token: 0x040006E7 RID: 1767
		AchievementUpdateRequest = 29393,
		// Token: 0x040006E8 RID: 1768
		AchievementUpdateResponse = 21082,
		// Token: 0x040006E9 RID: 1769
		TestDamageRecordNotify = 22542,
		// Token: 0x040006EA RID: 1770
		RogueBossLinkSettleNotify = 21333,
		// Token: 0x040006EB RID: 1771
		SeamlessTeleportRequest = 28869,
		// Token: 0x040006EC RID: 1772
		SeamlessTeleportResponse = 19267,
		// Token: 0x040006ED RID: 1773
		RogueBlackFlowerNotify = 18190,
		// Token: 0x040006EE RID: 1774
		RogueBlackFlowerRequest = 29618,
		// Token: 0x040006EF RID: 1775
		RogueBlackFlowerResponse = 18239,
		// Token: 0x040006F0 RID: 1776
		UpdateSceneGroupDataRequest = 23380,
		// Token: 0x040006F1 RID: 1777
		UpdateSceneGroupDataResponse = 25607,
		// Token: 0x040006F2 RID: 1778
		CombatDataMaxNotify = 28947,
		// Token: 0x040006F3 RID: 1779
		MowTowerSettlementRequest = 25440,
		// Token: 0x040006F4 RID: 1780
		MowTowerSettlementResponse = 24294,
		// Token: 0x040006F5 RID: 1781
		MowTowerFirstScoreNotify = 22248,
		// Token: 0x040006F6 RID: 1782
		MowTowerResultNotify = 26088,
		// Token: 0x040006F7 RID: 1783
		MowTowerLevelsRewardRequest = 27598,
		// Token: 0x040006F8 RID: 1784
		MowTowerLevelsRewardResponse = 25477,
		// Token: 0x040006F9 RID: 1785
		RoleSkinChangeRequest = 25393,
		// Token: 0x040006FA RID: 1786
		RoleSkinChangeResponse = 23541,
		// Token: 0x040006FB RID: 1787
		RoleSkinUpdateNotify = 18921,
		// Token: 0x040006FC RID: 1788
		RoleSkinRequest = 23414,
		// Token: 0x040006FD RID: 1789
		RoleSkinResponse = 22316,
		// Token: 0x040006FE RID: 1790
		RoleSkinAddNotify = 23089,
		// Token: 0x040006FF RID: 1791
		SceneItemAiEnableNotify = 26846,
		// Token: 0x04000700 RID: 1792
		SceneItemAiDisableNotify = 29959,
		// Token: 0x04000701 RID: 1793
		TeamMatchInviteRetToHostNotify = 25396,
		// Token: 0x04000702 RID: 1794
		SceneItemAiPatrolPointNotify = 15402,
		// Token: 0x04000703 RID: 1795
		SceneItemBlackboardNotify = 28473,
		// Token: 0x04000704 RID: 1796
		TeleportDungeonForbidNotify = 17358,
		// Token: 0x04000705 RID: 1797
		EntityGravityUpdateNotify = 19228,
		// Token: 0x04000706 RID: 1798
		PhantomMusicUnlockRequest = 15391,
		// Token: 0x04000707 RID: 1799
		PhantomMusicUnlockResponse = 19978,
		// Token: 0x04000708 RID: 1800
		PhantomMusicInfoRequest = 19247,
		// Token: 0x04000709 RID: 1801
		PhantomMusicInfoResponse = 22582,
		// Token: 0x0400070A RID: 1802
		PhantomMusicSwitchRequest = 27185,
		// Token: 0x0400070B RID: 1803
		PhantomMusicSwitchResponse = 22198,
		// Token: 0x0400070C RID: 1804
		UpdateSceneItemBlackboardRequest = 20774,
		// Token: 0x0400070D RID: 1805
		UpdateSceneItemBlackboardResponse = 29196,
		// Token: 0x0400070E RID: 1806
		MowTowerLevelsInfoUpdateNotify = 15746,
		// Token: 0x0400070F RID: 1807
		VehicleChangePassengerRequest = 21416,
		// Token: 0x04000710 RID: 1808
		VehicleChangePassengerResponse = 20697,
		// Token: 0x04000711 RID: 1809
		VehicleRemovePassengerRequest = 22646,
		// Token: 0x04000712 RID: 1810
		VehicleRemovePassengerResponse = 23958,
		// Token: 0x04000713 RID: 1811
		VehiclePassengerUpdateNotify = 21681,
		// Token: 0x04000714 RID: 1812
		AnimalCollectStateNotify = 20565,
		// Token: 0x04000715 RID: 1813
		LevelSequenceFrameEventActionRequest = 24567,
		// Token: 0x04000716 RID: 1814
		LevelSequenceFrameEventActionResponse = 26441,
		// Token: 0x04000717 RID: 1815
		SimpleTrackReportRequest = 26465,
		// Token: 0x04000718 RID: 1816
		SimpleTrackReportResponse = 22473,
		// Token: 0x04000719 RID: 1817
		PlayerVoxelEnvRequest = 18071,
		// Token: 0x0400071A RID: 1818
		PlayerVoxelEnvResponse = 21932,
		// Token: 0x0400071B RID: 1819
		TurntableTaskUpdateNotify = 26417,
		// Token: 0x0400071C RID: 1820
		MapTravelInfoUpdateNotify = 17425,
		// Token: 0x0400071D RID: 1821
		MapTravelFullRewardRequest = 25797,
		// Token: 0x0400071E RID: 1822
		MapTravelFullRewardResponse = 18919,
		// Token: 0x0400071F RID: 1823
		MapTravelLevelUpRequest = 25161,
		// Token: 0x04000720 RID: 1824
		MapTravelLevelUpResponse = 29440,
		// Token: 0x04000721 RID: 1825
		SpringSignDrawRoleRequest = 26720,
		// Token: 0x04000722 RID: 1826
		SpringSignDrawRoleResponse = 27629,
		// Token: 0x04000723 RID: 1827
		LevelPlayVarRequest = 15438,
		// Token: 0x04000724 RID: 1828
		LevelPlayVarResponse = 15621,
		// Token: 0x04000725 RID: 1829
		MaterialReplaceRequest = 16956,
		// Token: 0x04000726 RID: 1830
		MaterialReplaceResponse = 20685,
		// Token: 0x04000727 RID: 1831
		ExploreProgressRewardRequest = 17400,
		// Token: 0x04000728 RID: 1832
		ExploreProgressRewardResponse = 25710,
		// Token: 0x04000729 RID: 1833
		ExploreProgressRewardIdsNotify = 18889,
		// Token: 0x0400072A RID: 1834
		RoleTrialUiEndPush = 26138,
		// Token: 0x0400072B RID: 1835
		SpringSignDrawRewardRequest = 15126,
		// Token: 0x0400072C RID: 1836
		SpringSignDrawRewardResponse = 28746,
		// Token: 0x0400072D RID: 1837
		EntityCameraAlertRequest = 27538,
		// Token: 0x0400072E RID: 1838
		EntityCameraAlertResponse = 27719,
		// Token: 0x0400072F RID: 1839
		ThroughTrainRequest = 15113,
		// Token: 0x04000730 RID: 1840
		ThroughTrainResponse = 26744,
		// Token: 0x04000731 RID: 1841
		BoardCanMovePlacementNotify = 26498,
		// Token: 0x04000732 RID: 1842
		FarmGoldLevelDiffRequest = 28967,
		// Token: 0x04000733 RID: 1843
		FarmGoldResultNotify = 21768,
		// Token: 0x04000734 RID: 1844
		FarmGoldLevelNotify = 26870,
		// Token: 0x04000735 RID: 1845
		CheckUseSoundBoxSkillRequest = 24052,
		// Token: 0x04000736 RID: 1846
		CheckUseSoundBoxSkillResponse = 25981,
		// Token: 0x04000737 RID: 1847
		FarmGoldPointRequest = 18106,
		// Token: 0x04000738 RID: 1848
		FarmGoldPointResponse = 21245,
		// Token: 0x04000739 RID: 1849
		FarmGoldLevelPlayRequest = 28418,
		// Token: 0x0400073A RID: 1850
		FarmGoldLevelPlayResponse = 17979,
		// Token: 0x0400073B RID: 1851
		FarmGoldLevelDiffResponse = 17755,
		// Token: 0x0400073C RID: 1852
		SpringSignSkinRewardRequest = 16596,
		// Token: 0x0400073D RID: 1853
		SpringSignSkinRewardResponse = 27228,
		// Token: 0x0400073E RID: 1854
		FarmGoldResultRequest = 29811,
		// Token: 0x0400073F RID: 1855
		FarmGoldResultResponse = 28241,
		// Token: 0x04000740 RID: 1856
		FlowSeqSetPlayerPosRequest = 21021,
		// Token: 0x04000741 RID: 1857
		FlowSeqSetPlayerPosResponse = 29220,
		// Token: 0x04000742 RID: 1858
		TeamTeleportStartNotify = 27952,
		// Token: 0x04000743 RID: 1859
		SplineMoveRequest = 16693,
		// Token: 0x04000744 RID: 1860
		SplineMoveResponse = 29534,
		// Token: 0x04000745 RID: 1861
		SplineMoveNotify = 19766,
		// Token: 0x04000746 RID: 1862
		LevelPlayStateRequest = 19230,
		// Token: 0x04000747 RID: 1863
		LevelPlayStateResponse = 24154,
		// Token: 0x04000748 RID: 1864
		TeleportVehicleNotify = 22384,
		// Token: 0x04000749 RID: 1865
		PlayerHeadRequest = 26575,
		// Token: 0x0400074A RID: 1866
		PlayerHeadResponse = 20990,
		// Token: 0x0400074B RID: 1867
		PlayerHeadAddNotify = 24903,
		// Token: 0x0400074C RID: 1868
		VehicleUpdateEntityNotify = 25063,
		// Token: 0x0400074D RID: 1869
		EntityWalkingPatternFinishRequest = 24720,
		// Token: 0x0400074E RID: 1870
		EntityWalkingPatternFinishResponse = 18680,
		// Token: 0x0400074F RID: 1871
		QueryOnlinePlayersAreaRequest = 18422,
		// Token: 0x04000750 RID: 1872
		QueryOnlinePlayersAreaResponse = 18627,
		// Token: 0x04000751 RID: 1873
		DetectionPreOpenNotify = 19627,
		// Token: 0x04000752 RID: 1874
		MapTravelTaskRewardRequest = 19004,
		// Token: 0x04000753 RID: 1875
		MapTravelTaskRewardResponse = 29561,
		// Token: 0x04000754 RID: 1876
		MapTravelSoarRewardRequest = 21758,
		// Token: 0x04000755 RID: 1877
		MapTravelSoarRewardResponse = 15096,
		// Token: 0x04000756 RID: 1878
		FishingInfoRequest = 17766,
		// Token: 0x04000757 RID: 1879
		FishingInfoResponse = 22596,
		// Token: 0x04000758 RID: 1880
		FishingInfoUpdateNotify = 22579,
		// Token: 0x04000759 RID: 1881
		FishingShipInfoUpdateNotify = 22031,
		// Token: 0x0400075A RID: 1882
		FishingTechInfoUpdateNotify = 17814,
		// Token: 0x0400075B RID: 1883
		FishingIllustratedInfoUpdateNotify = 18459,
		// Token: 0x0400075C RID: 1884
		FishingIllustratedRewardInfoUpdateNotify = 27592,
		// Token: 0x0400075D RID: 1885
		FishingSceneFishCageInfoUpdateNotify = 18416,
		// Token: 0x0400075E RID: 1886
		SceneFishPointInfoUpdateNotify = 26043,
		// Token: 0x0400075F RID: 1887
		FishingIllustratedRewardRequest = 16271,
		// Token: 0x04000760 RID: 1888
		FishingIllustratedRewardResponse = 27625,
		// Token: 0x04000761 RID: 1889
		FishingCabinPutRequest = 25860,
		// Token: 0x04000762 RID: 1890
		FishingCabinPutResponse = 19250,
		// Token: 0x04000763 RID: 1891
		FishingQuickSellPreviewRequest = 18031,
		// Token: 0x04000764 RID: 1892
		FishingQuickSellPreviewResponse = 20069,
		// Token: 0x04000765 RID: 1893
		FishingQuickSellRequest = 23963,
		// Token: 0x04000766 RID: 1894
		FishingQuickSellResponse = 26816,
		// Token: 0x04000767 RID: 1895
		FishingSellPreviewRequest = 20524,
		// Token: 0x04000768 RID: 1896
		FishingSellPreviewResponse = 28511,
		// Token: 0x04000769 RID: 1897
		FishingSellRequest = 27511,
		// Token: 0x0400076A RID: 1898
		FishingSellResponse = 29274,
		// Token: 0x0400076B RID: 1899
		FishingSailingRequest = 23442,
		// Token: 0x0400076C RID: 1900
		FishingSailingResponse = 16408,
		// Token: 0x0400076D RID: 1901
		FishingEntrustHandInRequest = 22195,
		// Token: 0x0400076E RID: 1902
		FishingEntrustHandInResponse = 25865,
		// Token: 0x0400076F RID: 1903
		FishingEntrustTraceRequest = 26469,
		// Token: 0x04000770 RID: 1904
		FishingEntrustTraceResponse = 16672,
		// Token: 0x04000771 RID: 1905
		FishingEntrustRefreshRequest = 25644,
		// Token: 0x04000772 RID: 1906
		FishingEntrustRefreshResponse = 28664,
		// Token: 0x04000773 RID: 1907
		FishingShipForceBackNotify = 28191,
		// Token: 0x04000774 RID: 1908
		FishingShipFixRequest = 19300,
		// Token: 0x04000775 RID: 1909
		FishingShipFixResponse = 20583,
		// Token: 0x04000776 RID: 1910
		FishingTechLevelUpRequest = 16447,
		// Token: 0x04000777 RID: 1911
		FishingTechLevelUpResponse = 25533,
		// Token: 0x04000778 RID: 1912
		FishingItemAddNotify = 27090,
		// Token: 0x04000779 RID: 1913
		FishingNoticeUpdateNotify = 25001,
		// Token: 0x0400077A RID: 1914
		AccessPathConfigRequest = 16883,
		// Token: 0x0400077B RID: 1915
		AccessPathConfigResponse = 24933,
		// Token: 0x0400077C RID: 1916
		PlayerGameTokenRequest = 23683,
		// Token: 0x0400077D RID: 1917
		PlayerGameTokenResponse = 28955,
		// Token: 0x0400077E RID: 1918
		RenjuExitMatchedActionRequest = 20413,
		// Token: 0x0400077F RID: 1919
		RenjuExitMatchedActionResponse = 18128,
		// Token: 0x04000780 RID: 1920
		HookLockPointInfoNotify = 24148,
		// Token: 0x04000781 RID: 1921
		HandInInfoUpdateNotify = 18524,
		// Token: 0x04000782 RID: 1922
		TrialRoleSkinRewardRequest = 19389,
		// Token: 0x04000783 RID: 1923
		TrialRoleSkinRewardResponse = 19716,
		// Token: 0x04000784 RID: 1924
		RoleSkinTrialSettleNotify = 20469,
		// Token: 0x04000785 RID: 1925
		RoleSkinTrialUiEndPush = 22109,
		// Token: 0x04000786 RID: 1926
		LevelPlayStateListRequest = 25471,
		// Token: 0x04000787 RID: 1927
		LevelPlayStateListResponse = 20073,
		// Token: 0x04000788 RID: 1928
		SpringSignPhotoRewardRequest = 25857,
		// Token: 0x04000789 RID: 1929
		SpringSignPhotoRewardResponse = 26603,
		// Token: 0x0400078A RID: 1930
		BuffDurationNotify = 16974,
		// Token: 0x0400078B RID: 1931
		PhantomEquipGroupInfosRequest = 18533,
		// Token: 0x0400078C RID: 1932
		PhantomEquipGroupInfosResponse = 21429,
		// Token: 0x0400078D RID: 1933
		AddPhantomEquipGroupRequest = 24382,
		// Token: 0x0400078E RID: 1934
		AddPhantomEquipGroupResponse = 18193,
		// Token: 0x0400078F RID: 1935
		DeletePhantomEquipGroupRequest = 26973,
		// Token: 0x04000790 RID: 1936
		DeletePhantomEquipGroupResponse = 26711,
		// Token: 0x04000791 RID: 1937
		TopPhantomEquipGroupRequest = 20387,
		// Token: 0x04000792 RID: 1938
		ChangePhantomEquipGroupNameRequest = 18119,
		// Token: 0x04000793 RID: 1939
		ChangePhantomEquipGroupNameResponse = 18227,
		// Token: 0x04000794 RID: 1940
		TopPhantomEquipGroupResponse = 27536,
		// Token: 0x04000795 RID: 1941
		FishingCompleteRequest = 29131,
		// Token: 0x04000796 RID: 1942
		FishingCompleteResponse = 21524,
		// Token: 0x04000797 RID: 1943
		TeleportFlowEndRequest = 21234,
		// Token: 0x04000798 RID: 1944
		TeleportFlowEndResponse = 18758,
		// Token: 0x04000799 RID: 1945
		TeleportFlowNotify = 17285,
		// Token: 0x0400079A RID: 1946
		RiskHarvestStarRewardRequest = 24832,
		// Token: 0x0400079B RID: 1947
		RiskHarvestStarRewardResponse = 22246,
		// Token: 0x0400079C RID: 1948
		FishingEntrustUpdateNotify = 23340,
		// Token: 0x0400079D RID: 1949
		PhantomFetterRecommendRequest = 15990,
		// Token: 0x0400079E RID: 1950
		PhantomFetterRecommendResponse = 15665,
		// Token: 0x0400079F RID: 1951
		PhantomAttrRecommendRequest = 29865,
		// Token: 0x040007A0 RID: 1952
		PhantomAttrRecommendResponse = 22535,
		// Token: 0x040007A1 RID: 1953
		FishingEntrustAcceptRequest = 21980,
		// Token: 0x040007A2 RID: 1954
		FishingEntrustAcceptResponse = 28877,
		// Token: 0x040007A3 RID: 1955
		FishingExitRequest = 27861,
		// Token: 0x040007A4 RID: 1956
		FishingExitResponse = 17597,
		// Token: 0x040007A5 RID: 1957
		FishingPortUnlockNotify = 29311,
		// Token: 0x040007A6 RID: 1958
		FishingShipSkinChangeRequest = 16229,
		// Token: 0x040007A7 RID: 1959
		FishingShipSkinChangeResponse = 15401,
		// Token: 0x040007A8 RID: 1960
		FishingPointInfoRequest = 24764,
		// Token: 0x040007A9 RID: 1961
		FishingPointInfoResponse = 18952,
		// Token: 0x040007AA RID: 1962
		FishingCageInfoRequest = 16732,
		// Token: 0x040007AB RID: 1963
		FishingCageInfoResponse = 25777,
		// Token: 0x040007AC RID: 1964
		AiInformationPush = 20879,
		// Token: 0x040007AD RID: 1965
		AiBlackboardsPush = 21837,
		// Token: 0x040007AE RID: 1966
		AiBlackboardCdPush = 25416,
		// Token: 0x040007AF RID: 1967
		AiHatePush = 25194,
		// Token: 0x040007B0 RID: 1968
		ApplyGameplayEffectPush = 29488,
		// Token: 0x040007B1 RID: 1969
		RemoveGameplayEffectPush = 20358,
		// Token: 0x040007B2 RID: 1970
		ActivateBuffPush = 20926,
		// Token: 0x040007B3 RID: 1971
		BuffStackCountPush = 21666,
		// Token: 0x040007B4 RID: 1972
		BuffEffectPush = 20706,
		// Token: 0x040007B5 RID: 1973
		ChangeStateConfirmPush = 16165,
		// Token: 0x040007B6 RID: 1974
		FsmPlayMontagePush = 23876,
		// Token: 0x040007B7 RID: 1975
		LogicStateInitPush = 20507,
		// Token: 0x040007B8 RID: 1976
		SwitchLogicStatePush = 27786,
		// Token: 0x040007B9 RID: 1977
		AnimationGameplayTagPush = 20216,
		// Token: 0x040007BA RID: 1978
		BoneVisibleChangePush = 19234,
		// Token: 0x040007BB RID: 1979
		EntityStaticHookMovePush = 27494,
		// Token: 0x040007BC RID: 1980
		EndSkillPush = 15273,
		// Token: 0x040007BD RID: 1981
		InterruptSkillInDelayPush = 24695,
		// Token: 0x040007BE RID: 1982
		UseSkillFailPush = 22464,
		// Token: 0x040007BF RID: 1983
		HitEndPush = 21148,
		// Token: 0x040007C0 RID: 1984
		CaughtPush = 19906,
		// Token: 0x040007C1 RID: 1985
		CreateBulletPush = 15442,
		// Token: 0x040007C2 RID: 1986
		DestroyBulletPush = 22933,
		// Token: 0x040007C3 RID: 1987
		ModifyBulletParamsPush = 21952,
		// Token: 0x040007C4 RID: 1988
		PassiveSkillAddPush = 21813,
		// Token: 0x040007C5 RID: 1989
		PassiveSkillRemovePush = 15649,
		// Token: 0x040007C6 RID: 1990
		EnterViewDirectionPush = 28007,
		// Token: 0x040007C7 RID: 1991
		ExitViewDirectionPush = 19441,
		// Token: 0x040007C8 RID: 1992
		TriggerExitSkillPush = 20414,
		// Token: 0x040007C9 RID: 1993
		EntityIsVisiblePush = 23399,
		// Token: 0x040007CA RID: 1994
		ActorVisiblePush = 22507,
		// Token: 0x040007CB RID: 1995
		SwitchCharacterStatePush = 19156,
		// Token: 0x040007CC RID: 1996
		BattleStateChangePush = 29436,
		// Token: 0x040007CD RID: 1997
		ToughCalcExtraRatioChangePush = 24319,
		// Token: 0x040007CE RID: 1998
		MonsterBoomPush = 26387,
		// Token: 0x040007CF RID: 1999
		ANStartPush = 22773,
		// Token: 0x040007D0 RID: 2000
		GameplayTagPush = 20435,
		// Token: 0x040007D1 RID: 2001
		GameplayCuePush = 19183,
		// Token: 0x040007D2 RID: 2002
		ExecuteQtePush = 24316,
		// Token: 0x040007D3 RID: 2003
		ClientCurrentRoleReportPush = 20213,
		// Token: 0x040007D4 RID: 2004
		PartUpdatePush = 29042,
		// Token: 0x040007D5 RID: 2005
		AnimationStateInitPush = 29933,
		// Token: 0x040007D6 RID: 2006
		AnimationStateChangedPush = 20495,
		// Token: 0x040007D7 RID: 2007
		DrownPush = 18544,
		// Token: 0x040007D8 RID: 2008
		DrownEndTeleportPush = 20074,
		// Token: 0x040007D9 RID: 2009
		MonsterDrownPush = 24106,
		// Token: 0x040007DA RID: 2010
		MaterialPush = 24645,
		// Token: 0x040007DB RID: 2011
		RTimeStopAnimPush = 23930,
		// Token: 0x040007DC RID: 2012
		RTimeStopPush = 19986,
		// Token: 0x040007DD RID: 2013
		RTimeStopInstPush = 20510,
		// Token: 0x040007DE RID: 2014
		FishingHandInRequest = 26983,
		// Token: 0x040007DF RID: 2015
		FishingHandInResponse = 15662,
		// Token: 0x040007E0 RID: 2016
		FishingSkillBombRequest = 15602,
		// Token: 0x040007E1 RID: 2017
		FishingSkillBombResponse = 25718,
		// Token: 0x040007E2 RID: 2018
		FishingSkillBaitRequest = 19403,
		// Token: 0x040007E3 RID: 2019
		FishingSkillBaitResponse = 18662,
		// Token: 0x040007E4 RID: 2020
		FishingSkillTeleportRequest = 26598,
		// Token: 0x040007E5 RID: 2021
		FishingSkillTeleportResponse = 21518,
		// Token: 0x040007E6 RID: 2022
		RogueWeeklyRewardRequest = 21313,
		// Token: 0x040007E7 RID: 2023
		RogueWeeklyRewardResponse = 26201,
		// Token: 0x040007E8 RID: 2024
		RogueWeeklyRoomInfoNotify = 21270,
		// Token: 0x040007E9 RID: 2025
		RogueWeeklyGotoNextRoomRequest = 19170,
		// Token: 0x040007EA RID: 2026
		RogueWeeklyGotoNextRoomResponse = 26948,
		// Token: 0x040007EB RID: 2027
		RogueWeeklySubLevelNotify = 29246,
		// Token: 0x040007EC RID: 2028
		RogueWeeklyResultNotify = 23363,
		// Token: 0x040007ED RID: 2029
		SlashAndTowerInfoRequest = 26076,
		// Token: 0x040007EE RID: 2030
		SlashAndTowerInfoResponse = 22143,
		// Token: 0x040007EF RID: 2031
		SlashAndTowerScoreRewardRequest = 28028,
		// Token: 0x040007F0 RID: 2032
		SlashAndTowerScoreRewardResponse = 18008,
		// Token: 0x040007F1 RID: 2033
		EndLessHistoryRequest = 24101,
		// Token: 0x040007F2 RID: 2034
		EndLessHistoryResponse = 22456,
		// Token: 0x040007F3 RID: 2035
		SlashAndTowerResultNotify = 15320,
		// Token: 0x040007F4 RID: 2036
		SlashAndTowerLevelPlayNotify = 17693,
		// Token: 0x040007F5 RID: 2037
		SlashAndTowerSaveRecordRequest = 19636,
		// Token: 0x040007F6 RID: 2038
		SlashAndTowerSaveRecordResponse = 18715,
		// Token: 0x040007F7 RID: 2039
		SlashAndTowerResetRequest = 20373,
		// Token: 0x040007F8 RID: 2040
		SlashAndTowerResetResponse = 18583,
		// Token: 0x040007F9 RID: 2041
		SlashAndTowerRecommendRequest = 22684,
		// Token: 0x040007FA RID: 2042
		SlashAndTowerRecommendResponse = 15984,
		// Token: 0x040007FB RID: 2043
		SceneTempFishPointInfoUpdateNotify = 16713,
		// Token: 0x040007FC RID: 2044
		BossRushTaskUpdateNotify = 23983,
		// Token: 0x040007FD RID: 2045
		BossRushTaskRewardRequest = 27175,
		// Token: 0x040007FE RID: 2046
		BossRushTaskRewardResponse = 15100,
		// Token: 0x040007FF RID: 2047
		CharacterLookAtNotify = 25173,
		// Token: 0x04000800 RID: 2048
		UsePhantomEquipGroupRequest = 17437,
		// Token: 0x04000801 RID: 2049
		UsePhantomEquipGroupResponse = 21750,
		// Token: 0x04000802 RID: 2050
		FishingActivityLimitTaskNotify = 21833,
		// Token: 0x04000803 RID: 2051
		FishingActivityMileStoneNotify = 16931,
		// Token: 0x04000804 RID: 2052
		FishingActivityLimitRewardRequest = 29602,
		// Token: 0x04000805 RID: 2053
		FishingActivityLimitRewardResponse = 18435,
		// Token: 0x04000806 RID: 2054
		FishingActivityMilestoneRewardRequest = 20542,
		// Token: 0x04000807 RID: 2055
		FishingActivityMilestoneRewardResponse = 27837,
		// Token: 0x04000808 RID: 2056
		FishingBoatDieNotify = 26943,
		// Token: 0x04000809 RID: 2057
		TeamParkourRewardRequest = 19176,
		// Token: 0x0400080A RID: 2058
		TeamParkourRewardResponse = 16986,
		// Token: 0x0400080B RID: 2059
		TeamParkourTaskNotify = 19512,
		// Token: 0x0400080C RID: 2060
		TeamParkourSettleNotify = 25201,
		// Token: 0x0400080D RID: 2061
		RogueWeeklyResultRequest = 25097,
		// Token: 0x0400080E RID: 2062
		RogueWeeklyResultResponse = 16682,
		// Token: 0x0400080F RID: 2063
		RogueWeeklyInstInfoNotify = 26665,
		// Token: 0x04000810 RID: 2064
		RogueWeeklyOptionSelectRequest = 20557,
		// Token: 0x04000811 RID: 2065
		RogueWeeklyOptionSelectResponse = 19745,
		// Token: 0x04000812 RID: 2066
		PlayEntityMontagePush = 22159,
		// Token: 0x04000813 RID: 2067
		ThroughTrainForceRemindNotify = 19334,
		// Token: 0x04000814 RID: 2068
		ThroughTrainFinishViewRequest = 18707,
		// Token: 0x04000815 RID: 2069
		ThroughTrainFinishViewResponse = 26237,
		// Token: 0x04000816 RID: 2070
		FishingActivityMilestoneItemNumNotify = 23932,
		// Token: 0x04000817 RID: 2071
		AddHackingEntityNotify = 17276,
		// Token: 0x04000818 RID: 2072
		RemoveHackingEntityNotify = 22506,
		// Token: 0x04000819 RID: 2073
		BossRushSelectBuffNotify = 16943,
		// Token: 0x0400081A RID: 2074
		ActivityPreOpenRequest = 20615,
		// Token: 0x0400081B RID: 2075
		ActivityPreOpenResponse = 26244,
		// Token: 0x0400081C RID: 2076
		ActionGroupCreateNotify = 21691,
		// Token: 0x0400081D RID: 2077
		ActionGroupCompleteNotify = 25820,
		// Token: 0x0400081E RID: 2078
		ShopInfoUpdateNotify = 26089,
		// Token: 0x0400081F RID: 2079
		LstBattleRecordRequest = 18253,
		// Token: 0x04000820 RID: 2080
		LstBattleRecordResponse = 15485,
		// Token: 0x04000821 RID: 2081
		RogueWeeklyStartRequest = 26066,
		// Token: 0x04000822 RID: 2082
		RogueWeeklyStartResponse = 17543,
		// Token: 0x04000823 RID: 2083
		RogueWeeklyCurrencyNotify = 18949,
		// Token: 0x04000824 RID: 2084
		RogueWeeklyCurrencyUpdateNotify = 18251,
		// Token: 0x04000825 RID: 2085
		FishingGhostStateNotify = 27726,
		// Token: 0x04000826 RID: 2086
		FishingSkinUnlockNotify = 17605,
		// Token: 0x04000827 RID: 2087
		FishingTeleportToBoatRequest = 28699,
		// Token: 0x04000828 RID: 2088
		FishingTeleportToBoatResponse = 16996,
		// Token: 0x04000829 RID: 2089
		TowerDefenceRandListRequest = 19374,
		// Token: 0x0400082A RID: 2090
		TowerDefenceRandListResponse = 17275,
		// Token: 0x0400082B RID: 2091
		TowerDefenceRankShowNameRequest = 21818,
		// Token: 0x0400082C RID: 2092
		TowerDefenceRankShowNameResponse = 21093,
		// Token: 0x0400082D RID: 2093
		BabelActivityLevelInfoNotify = 28436,
		// Token: 0x0400082E RID: 2094
		BabelActivityBuffInfoNotify = 24665,
		// Token: 0x0400082F RID: 2095
		BabelActivityTaskInfoNotify = 22425,
		// Token: 0x04000830 RID: 2096
		BabelActivityDailyTaskInfoNotify = 20204,
		// Token: 0x04000831 RID: 2097
		BabelTowerTaskRewardRequest = 16805,
		// Token: 0x04000832 RID: 2098
		BabelTowerTaskRewardResponse = 21846,
		// Token: 0x04000833 RID: 2099
		BabelTowerDailyTaskRewardRequest = 26699,
		// Token: 0x04000834 RID: 2100
		BabelTowerDailyTaskRewardResponse = 20492,
		// Token: 0x04000835 RID: 2101
		ResetBabelTowerLevelRequest = 20991,
		// Token: 0x04000836 RID: 2102
		ResetBabelTowerLevelResponse = 22385,
		// Token: 0x04000837 RID: 2103
		AddGuestNotify = 26842,
		// Token: 0x04000838 RID: 2104
		RemoveGuestNotify = 15691,
		// Token: 0x04000839 RID: 2105
		BabelActivitySettleInfoNotify = 29450,
		// Token: 0x0400083A RID: 2106
		BabelTowerSettlementRequest = 25214,
		// Token: 0x0400083B RID: 2107
		BabelTowerSettlementResponse = 24625,
		// Token: 0x0400083C RID: 2108
		RogueWeeklyBlackFlowerNotify = 24088,
		// Token: 0x0400083D RID: 2109
		RogueWeeklyBlackFlowerRequest = 18903,
		// Token: 0x0400083E RID: 2110
		RogueWeeklyBlackFlowerResponse = 29161,
		// Token: 0x0400083F RID: 2111
		SceneSubLevelsRequest = 25079,
		// Token: 0x04000840 RID: 2112
		SceneSubLevelsResponse = 27152,
		// Token: 0x04000841 RID: 2113
		PlayerTitleUpdateNotify = 21787,
		// Token: 0x04000842 RID: 2114
		DressPlayerTitleUpdateNotify = 19326,
		// Token: 0x04000843 RID: 2115
		PlayerTitleRequest = 21582,
		// Token: 0x04000844 RID: 2116
		PlayerTitleResponse = 18669,
		// Token: 0x04000845 RID: 2117
		ChangePlayerTitleRequest = 22152,
		// Token: 0x04000846 RID: 2118
		ChangePlayerTitleResponse = 21696,
		// Token: 0x04000847 RID: 2119
		AwakeItemVehicleRequest = 15589,
		// Token: 0x04000848 RID: 2120
		AwakeItemVehicleResponse = 15101,
		// Token: 0x04000849 RID: 2121
		ReplaceVehicleEntityNotify = 18061,
		// Token: 0x0400084A RID: 2122
		BabelActivityDeTermInfoNotify = 23405,
		// Token: 0x0400084B RID: 2123
		SelectBabelActivityDeTermRequest = 22917,
		// Token: 0x0400084C RID: 2124
		SelectBabelActivityDeTermResponse = 21621,
		// Token: 0x0400084D RID: 2125
		GravityFlipInteractRequest = 16440,
		// Token: 0x0400084E RID: 2126
		GravityFlipInteractResponse = 24474,
		// Token: 0x0400084F RID: 2127
		AbyssRoleInfoUpdateNotify = 27295,
		// Token: 0x04000850 RID: 2128
		AbyssPluginItemInfoUpdateNotify = 25376,
		// Token: 0x04000851 RID: 2129
		AbyssRewardsUpdateNotify = 21674,
		// Token: 0x04000852 RID: 2130
		AbyssChallengeUpdateNotify = 19331,
		// Token: 0x04000853 RID: 2131
		AbyssChallengeUnlockRequest = 21327,
		// Token: 0x04000854 RID: 2132
		AbyssChallengeUnlockResponse = 20260,
		// Token: 0x04000855 RID: 2133
		AbyssChallengeQuitRequest = 15291,
		// Token: 0x04000856 RID: 2134
		AbyssChallengeQuitResponse = 15723,
		// Token: 0x04000857 RID: 2135
		AbyssChallengeResultNotify = 18887,
		// Token: 0x04000858 RID: 2136
		AbyssLikeRequest = 16399,
		// Token: 0x04000859 RID: 2137
		AbyssLikeResponse = 17535,
		// Token: 0x0400085A RID: 2138
		AbyssLikeNotify = 17176,
		// Token: 0x0400085B RID: 2139
		AbyssChallengeSubLevelNotify = 19107,
		// Token: 0x0400085C RID: 2140
		AbyssChallengeGotoNextRoomRequest = 20543,
		// Token: 0x0400085D RID: 2141
		AbyssChallengeGotoNextRoomResponse = 22250,
		// Token: 0x0400085E RID: 2142
		AbyssChallengeRoomInfoNotify = 19560,
		// Token: 0x0400085F RID: 2143
		AbyssRewardRequest = 18308,
		// Token: 0x04000860 RID: 2144
		AbyssRewardResponse = 15163,
		// Token: 0x04000861 RID: 2145
		AbyssLittleRoleLevelUpRequest = 22340,
		// Token: 0x04000862 RID: 2146
		AbyssLittleRoleLevelUpResponse = 15774,
		// Token: 0x04000863 RID: 2147
		AbyssPluginPutRequest = 17042,
		// Token: 0x04000864 RID: 2148
		AbyssPluginPutResponse = 27879,
		// Token: 0x04000865 RID: 2149
		AbyssPluginSynthesisRequest = 22615,
		// Token: 0x04000866 RID: 2150
		AbyssPluginSynthesisResponse = 19445,
		// Token: 0x04000867 RID: 2151
		AbyssRankListRequest = 26103,
		// Token: 0x04000868 RID: 2152
		AbyssRankListResponse = 21709,
		// Token: 0x04000869 RID: 2153
		AbyssShowNameRequest = 28814,
		// Token: 0x0400086A RID: 2154
		AbyssShowNameResponse = 16143,
		// Token: 0x0400086B RID: 2155
		AbyssRoleSelectUpdateNotify = 24255,
		// Token: 0x0400086C RID: 2156
		FishingPortUpdateNotify = 27457,
		// Token: 0x0400086D RID: 2157
		BabelActivityUseReviveCountNotify = 15978,
		// Token: 0x0400086E RID: 2158
		AbyssReviveCharacterRequest = 16144,
		// Token: 0x0400086F RID: 2159
		AbyssReviveCharacterResponse = 23705,
		// Token: 0x04000870 RID: 2160
		AbyssReviveNotify = 23441,
		// Token: 0x04000871 RID: 2161
		GravityFlipUpdateTypeNotify = 19748,
		// Token: 0x04000872 RID: 2162
		ClientVersionNoMatchNotify = 27011,
		// Token: 0x04000873 RID: 2163
		SceneItemMoveSplineRequest = 24048,
		// Token: 0x04000874 RID: 2164
		SceneItemMoveSplineResponse = 29851,
		// Token: 0x04000875 RID: 2165
		RacingBetsLegMatchInfoRequest = 27433,
		// Token: 0x04000876 RID: 2166
		RacingBetsLegMatchInfoResponse = 18082,
		// Token: 0x04000877 RID: 2167
		RacingBetsMatchInfoRequest = 15531,
		// Token: 0x04000878 RID: 2168
		RacingBetsMatchInfoResponse = 15383,
		// Token: 0x04000879 RID: 2169
		RacingBetsPlayerInfoRequest = 23533,
		// Token: 0x0400087A RID: 2170
		RacingBetsPlayerInfoResponse = 28603,
		// Token: 0x0400087B RID: 2171
		RacingBetsRankRequest = 16670,
		// Token: 0x0400087C RID: 2172
		RacingBetsRankResponse = 28404,
		// Token: 0x0400087D RID: 2173
		RacingBetsGearRequest = 28576,
		// Token: 0x0400087E RID: 2174
		RacingBetsGearResponse = 26722,
		// Token: 0x0400087F RID: 2175
		RacingBetsPlayerInfoUpdateNotify = 28840,
		// Token: 0x04000880 RID: 2176
		RacingBetsTaskRequest = 25921,
		// Token: 0x04000881 RID: 2177
		RacingBetsTaskResponse = 22403,
		// Token: 0x04000882 RID: 2178
		RacingBetsTaskRewardRequest = 16541,
		// Token: 0x04000883 RID: 2179
		RacingBetMatchRoundRequest = 21053,
		// Token: 0x04000884 RID: 2180
		RacingBetMatchRoundResponse = 29752,
		// Token: 0x04000885 RID: 2181
		RacingBetsBulletScreenRequest = 29326,
		// Token: 0x04000886 RID: 2182
		RacingBetsBulletScreenResponse = 26542,
		// Token: 0x04000887 RID: 2183
		RacingBetsTaskRewardResponse = 18798,
		// Token: 0x04000888 RID: 2184
		FishingNetCabinUpdateNotify = 29286,
		// Token: 0x04000889 RID: 2185
		RogueWeeklyLastInfoRequest = 29824,
		// Token: 0x0400088A RID: 2186
		RogueWeeklyLastInfoResponse = 15761,
		// Token: 0x0400088B RID: 2187
		RacingBetsUpdateOddsRequest = 28583,
		// Token: 0x0400088C RID: 2188
		RacingBetsUpdateOddsResponse = 16685,
		// Token: 0x0400088D RID: 2189
		ExploreActivityTaskInfoNotify = 21764,
		// Token: 0x0400088E RID: 2190
		ExploreActivityTaskRewardRequest = 28364,
		// Token: 0x0400088F RID: 2191
		ExploreActivityTaskRewardResponse = 25543,
		// Token: 0x04000890 RID: 2192
		RacingBetsTaskNotify = 17279,
		// Token: 0x04000891 RID: 2193
		EntityHeadInfoNotify = 29559,
		// Token: 0x04000892 RID: 2194
		PhantomPolishRequest = 28425,
		// Token: 0x04000893 RID: 2195
		PhantomPolishResponse = 16484,
		// Token: 0x04000894 RID: 2196
		TowerDefenceSelfPassRequest = 21596,
		// Token: 0x04000895 RID: 2197
		TowerDefenceSelfPassResponse = 25970,
		// Token: 0x04000896 RID: 2198
		AbyssSelfPassRequest = 19384,
		// Token: 0x04000897 RID: 2199
		AbyssSelfPassResponse = 22042,
		// Token: 0x04000898 RID: 2200
		RogueResTalentSkillLevelRequest = 18391,
		// Token: 0x04000899 RID: 2201
		RogueResTalentSkillLevelResponse = 15225,
		// Token: 0x0400089A RID: 2202
		RogueResTalentUnlockNotify = 25233,
		// Token: 0x0400089B RID: 2203
		RogueResEndingUpdateNotify = 27739,
		// Token: 0x0400089C RID: 2204
		RogueResEndingRewardRequest = 25016,
		// Token: 0x0400089D RID: 2205
		RogueResEndingRewardResponse = 24880,
		// Token: 0x0400089E RID: 2206
		RogueResTaskUpdateNotify = 18189,
		// Token: 0x0400089F RID: 2207
		RogueResIllustrationUpdateNotify = 25481,
		// Token: 0x040008A0 RID: 2208
		RogueResTaskAwardRequest = 24996,
		// Token: 0x040008A1 RID: 2209
		RogueResTaskAwardResponse = 24954,
		// Token: 0x040008A2 RID: 2210
		RogueResIllustrationAwardRequest = 28613,
		// Token: 0x040008A3 RID: 2211
		RogueResIllustrationAwardResponse = 23918,
		// Token: 0x040008A4 RID: 2212
		BabelActivityInstInfoNotify = 26859,
		// Token: 0x040008A5 RID: 2213
		MoveSplineStatusNotify = 18808,
		// Token: 0x040008A6 RID: 2214
		AbyssRoleAddNotify = 21949,
		// Token: 0x040008A7 RID: 2215
		AbyssPluginItemAddNotify = 27619,
		// Token: 0x040008A8 RID: 2216
		AbyssPluginItemRemoveNotify = 21718,
		// Token: 0x040008A9 RID: 2217
		AvignonRewardRequest = 23689,
		// Token: 0x040008AA RID: 2218
		AvignonRewardResponse = 29765,
		// Token: 0x040008AB RID: 2219
		AvignonTaskNotify = 26663,
		// Token: 0x040008AC RID: 2220
		RogueResMoveRequest = 24363,
		// Token: 0x040008AD RID: 2221
		RogueResMoveResponse = 27678,
		// Token: 0x040008AE RID: 2222
		RogueResGridEventRequest = 20462,
		// Token: 0x040008AF RID: 2223
		RogueResGridEventResponse = 25023,
		// Token: 0x040008B0 RID: 2224
		RogueResOpDataNotify = 28593,
		// Token: 0x040008B1 RID: 2225
		RogueResOpDoneRequest = 23138,
		// Token: 0x040008B2 RID: 2226
		RogueResOpDoneResponse = 20903,
		// Token: 0x040008B3 RID: 2227
		RogueResInstOptionsNotify = 20056,
		// Token: 0x040008B4 RID: 2228
		RogueResInstStartRequest = 16991,
		// Token: 0x040008B5 RID: 2229
		RogueResInstStartResponse = 15616,
		// Token: 0x040008B6 RID: 2230
		RogueResInstResultRequest = 19690,
		// Token: 0x040008B7 RID: 2231
		RogueResLastInstInfoRequest = 18322,
		// Token: 0x040008B8 RID: 2232
		RogueResLastInstInfoResponse = 29600,
		// Token: 0x040008B9 RID: 2233
		DebugFightErrInfoNotify = 15787,
		// Token: 0x040008BA RID: 2234
		ActionFinishImmediatelyNotify = 22694,
		// Token: 0x040008BB RID: 2235
		BeforeHitPush = 21067,
		// Token: 0x040008BC RID: 2236
		RacingBetsGearRefundRequest = 19077,
		// Token: 0x040008BD RID: 2237
		RacingBetsGearRefundResponse = 16117,
		// Token: 0x040008BE RID: 2238
		SummonRandomRequest = 18382,
		// Token: 0x040008BF RID: 2239
		SummonRandomResponse = 19533,
		// Token: 0x040008C0 RID: 2240
		SummonRandomNotify = 25992,
		// Token: 0x040008C1 RID: 2241
		RogueResInstResultResponse = 21394,
		// Token: 0x040008C2 RID: 2242
		BabelActivityItemNumUpdateNotify = 28972,
		// Token: 0x040008C3 RID: 2243
		StopMoveSplineRequest = 26851,
		// Token: 0x040008C4 RID: 2244
		StopMoveSplineResponse = 19432,
		// Token: 0x040008C5 RID: 2245
		H5CircumFluenceActivityDataNotify = 24475,
		// Token: 0x040008C6 RID: 2246
		RoleFlyEquipNotify = 29874,
		// Token: 0x040008C7 RID: 2247
		FlySkinWearRequest = 15148,
		// Token: 0x040008C8 RID: 2248
		FlySkinWearResponse = 17717,
		// Token: 0x040008C9 RID: 2249
		FlySkinWearAllRoleRequest = 19185,
		// Token: 0x040008CA RID: 2250
		FlySkinWearAllRoleResponse = 25354,
		// Token: 0x040008CB RID: 2251
		RogueResRoomInfoNotify = 20943,
		// Token: 0x040008CC RID: 2252
		RogueResGotoNextRoomRequest = 15168,
		// Token: 0x040008CD RID: 2253
		RogueResGotoNextRoomResponse = 25469,
		// Token: 0x040008CE RID: 2254
		RacingBetsSettleNotify = 19536,
		// Token: 0x040008CF RID: 2255
		FlySkinUnLoadRequest = 20032,
		// Token: 0x040008D0 RID: 2256
		FlySkinUnLoadResponse = 23595,
		// Token: 0x040008D1 RID: 2257
		RogueResCurrencyNotify = 29732,
		// Token: 0x040008D2 RID: 2258
		RogueResCurrencyUpdateNotify = 15356,
		// Token: 0x040008D3 RID: 2259
		RogueResInstGlobalDataNotify = 23490,
		// Token: 0x040008D4 RID: 2260
		RogueResGridDataUpdateNotify = 15986,
		// Token: 0x040008D5 RID: 2261
		RogueResGainDataTotalNotify = 24073,
		// Token: 0x040008D6 RID: 2262
		RogueResGainDataUpdateNotify = 29611,
		// Token: 0x040008D7 RID: 2263
		DangoMonopolyDiceRequest = 28626,
		// Token: 0x040008D8 RID: 2264
		DangoMonopolyDiceResponse = 29407,
		// Token: 0x040008D9 RID: 2265
		DangoMonopolyGridRewardRequest = 20431,
		// Token: 0x040008DA RID: 2266
		DangoMonopolyGridRewardResponse = 16416,
		// Token: 0x040008DB RID: 2267
		DangoMonopolyBoardRewardRequest = 27429,
		// Token: 0x040008DC RID: 2268
		DangoMonopolyBoardRewardResponse = 19522,
		// Token: 0x040008DD RID: 2269
		DangoMonopolyTaskRewardRequest = 25756,
		// Token: 0x040008DE RID: 2270
		DangoMonopolyTaskRewardResponse = 27164,
		// Token: 0x040008DF RID: 2271
		RoleFlyEquipChangeNotify = 20739,
		// Token: 0x040008E0 RID: 2272
		AbyssReviveTimeNotify = 19368,
		// Token: 0x040008E1 RID: 2273
		RacingBetMatchRequest = 19337,
		// Token: 0x040008E2 RID: 2274
		RacingBetMatchResponse = 29502,
		// Token: 0x040008E3 RID: 2275
		DangoMonopolyTaskUpdateNotify = 19371,
		// Token: 0x040008E4 RID: 2276
		RogueResPlayerStatusUpdateNotify = 29412,
		// Token: 0x040008E5 RID: 2277
		RogueResFovUpdateNotify = 27113,
		// Token: 0x040008E6 RID: 2278
		RogueResMoodUpdateNotify = 18361,
		// Token: 0x040008E7 RID: 2279
		LoadingLevelAreaRequest = 24141,
		// Token: 0x040008E8 RID: 2280
		LoadingLevelAreaResponse = 19391,
		// Token: 0x040008E9 RID: 2281
		DangoMonopolySceneGridInfoNotify = 28572,
		// Token: 0x040008EA RID: 2282
		RogueResOpDataUpdateNotify = 15468,
		// Token: 0x040008EB RID: 2283
		DangoMonopolyNextBoardRequest = 26450,
		// Token: 0x040008EC RID: 2284
		DangoMonopolyNextBoardResponse = 16590,
		// Token: 0x040008ED RID: 2285
		EntityFlyEquipChangeNotify = 17450,
		// Token: 0x040008EE RID: 2286
		FlyEquipAddNotify = 16449,
		// Token: 0x040008EF RID: 2287
		NewLinkNotify = 23833,
		// Token: 0x040008F0 RID: 2288
		NewLinkBurstPush = 22970,
		// Token: 0x040008F1 RID: 2289
		AddChapterResultRequest = 21695,
		// Token: 0x040008F2 RID: 2290
		AddChapterResultResponse = 27547,
		// Token: 0x040008F3 RID: 2291
		ChapterResultRewardRequest = 20453,
		// Token: 0x040008F4 RID: 2292
		ChapterResultRewardResponse = 28736,
		// Token: 0x040008F5 RID: 2293
		InspirationUnlockChoiceRequest = 29979,
		// Token: 0x040008F6 RID: 2294
		InspirationUnlockChoiceResponse = 24295,
		// Token: 0x040008F7 RID: 2295
		ActivityResultRewardRequest = 16280,
		// Token: 0x040008F8 RID: 2296
		ActivityResultRewardResponse = 28339,
		// Token: 0x040008F9 RID: 2297
		ScheduleRewardRequest = 18448,
		// Token: 0x040008FA RID: 2298
		ScheduleRewardResponse = 26326,
		// Token: 0x040008FB RID: 2299
		ChapterUpdateNotify = 28416,
		// Token: 0x040008FC RID: 2300
		InspirationUpdateNotify = 24547,
		// Token: 0x040008FD RID: 2301
		ScheduleRewardUpdateNotify = 24945,
		// Token: 0x040008FE RID: 2302
		FlySkinAllUnLoadRequest = 17550,
		// Token: 0x040008FF RID: 2303
		FlySkinAllUnLoadResponse = 16998,
		// Token: 0x04000900 RID: 2304
		ActivityResultUpdateNotify = 22058,
		// Token: 0x04000901 RID: 2305
		CiacconaActivityStateUnlockUpdateNotify = 27426,
		// Token: 0x04000902 RID: 2306
		RogueResInstOptionsUpdateNotify = 29683,
		// Token: 0x04000903 RID: 2307
		RogueResElementUpdateNotify = 17669,
		// Token: 0x04000904 RID: 2308
		RacingBetLegMatchResultNotify = 24273,
		// Token: 0x04000905 RID: 2309
		RogueResTeamLevelUpdateNotify = 29805,
		// Token: 0x04000906 RID: 2310
		RogueResChangeFormationRequest = 28484,
		// Token: 0x04000907 RID: 2311
		RogueResChangeFormationResponse = 18969,
		// Token: 0x04000908 RID: 2312
		RegressBonusRequest = 24329,
		// Token: 0x04000909 RID: 2313
		RegressBonusResponse = 16360,
		// Token: 0x0400090A RID: 2314
		RegressTaskRequest = 21404,
		// Token: 0x0400090B RID: 2315
		RegressTaskResponse = 24403,
		// Token: 0x0400090C RID: 2316
		ConfirmQuestResourceRequest = 27492,
		// Token: 0x0400090D RID: 2317
		ConfirmQuestResourceResponse = 26295,
		// Token: 0x0400090E RID: 2318
		ConfirmResourceQuestNotify = 27650,
		// Token: 0x0400090F RID: 2319
		WaitQuestConfirmResourceNotify = 27440,
		// Token: 0x04000910 RID: 2320
		ConsumptiveRewardRequest = 28551,
		// Token: 0x04000911 RID: 2321
		ConsumptiveRewardResponse = 23419,
		// Token: 0x04000912 RID: 2322
		LinkageRewardRequest = 16047,
		// Token: 0x04000913 RID: 2323
		LinkageRewardResponse = 25500,
		// Token: 0x04000914 RID: 2324
		RacingBetMatchActionRequest = 17379,
		// Token: 0x04000915 RID: 2325
		RacingBetMatchActionResponse = 25269,
		// Token: 0x04000916 RID: 2326
		RacingBetMatchRoundActionRequest = 28283,
		// Token: 0x04000917 RID: 2327
		RacingBetMatchRoundActionResponse = 15882,
		// Token: 0x04000918 RID: 2328
		DetectionInvisibleNotify = 26507,
		// Token: 0x04000919 RID: 2329
		PlayerGravityUpdateNotify = 28738,
		// Token: 0x0400091A RID: 2330
		DangoMonopolyTaskAddNotify = 23445,
		// Token: 0x0400091B RID: 2331
		DangoMonopolyTaskRemoveNotify = 20133,
		// Token: 0x0400091C RID: 2332
		RogueResSwitchFormationRequest = 28562,
		// Token: 0x0400091D RID: 2333
		RogueResSwitchFormationResponse = 19117,
		// Token: 0x0400091E RID: 2334
		RogueResRoleBondUpdateNotify = 19491,
		// Token: 0x0400091F RID: 2335
		RacingBetMatchInfoRequest = 28035,
		// Token: 0x04000920 RID: 2336
		RacingBetMatchInfoResponse = 22985,
		// Token: 0x04000921 RID: 2337
		RogueResTotalShopItemUpdateNotify = 23383,
		// Token: 0x04000922 RID: 2338
		SystemMarkHideInfoNotify = 17890,
		// Token: 0x04000923 RID: 2339
		PhantomBattleChallengeInfoUpdateNotify = 20648,
		// Token: 0x04000924 RID: 2340
		PhantomBattleTaskInfoNotify = 26339,
		// Token: 0x04000925 RID: 2341
		PhantomBattleTaskRewardRequest = 29515,
		// Token: 0x04000926 RID: 2342
		PhantomBattleTaskRewardResponse = 20933,
		// Token: 0x04000927 RID: 2343
		PhantomBattleMasterInfoNotify = 18038,
		// Token: 0x04000928 RID: 2344
		PhantomBattleMasterLevelRewardRequest = 28662,
		// Token: 0x04000929 RID: 2345
		PhantomBattleMasterLevelRewardResponse = 26202,
		// Token: 0x0400092A RID: 2346
		PhantomBattleBadgeInfoUpdateNotify = 22202,
		// Token: 0x0400092B RID: 2347
		PhantomBattleBadgeRewardInfoUpdateNotify = 25204,
		// Token: 0x0400092C RID: 2348
		PhantomBattleBadgeRewardRequest = 25505,
		// Token: 0x0400092D RID: 2349
		PhantomBattleBadgeRewardResponse = 28194,
		// Token: 0x0400092E RID: 2350
		PhantomBattleCardInfoUpdateNotify = 16880,
		// Token: 0x0400092F RID: 2351
		PhantomBattleCardOutLookUpRequest = 28432,
		// Token: 0x04000930 RID: 2352
		PhantomBattleCardOutLookUpResponse = 15581,
		// Token: 0x04000931 RID: 2353
		PhantomBattleCardRewardInfoUpdateNotify = 19146,
		// Token: 0x04000932 RID: 2354
		PhantomBattleCardRewardRequest = 21697,
		// Token: 0x04000933 RID: 2355
		PhantomBattleCardRewardResponse = 20785,
		// Token: 0x04000934 RID: 2356
		PhantomBattleRoleInfoUpdateNotify = 26654,
		// Token: 0x04000935 RID: 2357
		PhantomBattleRoleRewardRequest = 26163,
		// Token: 0x04000936 RID: 2358
		PhantomBattleRoleRewardResponse = 21447,
		// Token: 0x04000937 RID: 2359
		PhantomBattleCardGroupInfoNotify = 22666,
		// Token: 0x04000938 RID: 2360
		PhantomBattleCardGroupAddRequest = 19376,
		// Token: 0x04000939 RID: 2361
		PhantomBattleCardGroupAddResponse = 17478,
		// Token: 0x0400093A RID: 2362
		PhantomBattleCardGroupUpdateRequest = 20057,
		// Token: 0x0400093B RID: 2363
		PhantomBattleCardGroupUpdateResponse = 26320,
		// Token: 0x0400093C RID: 2364
		PhantomBattleCardGroupNameRequest = 25885,
		// Token: 0x0400093D RID: 2365
		PhantomBattleCardGroupNameResponse = 26266,
		// Token: 0x0400093E RID: 2366
		PhantomBattleBoardInfoNotify = 24606,
		// Token: 0x0400093F RID: 2367
		PhantomBattleHandCardInfoUpdateNotify = 25772,
		// Token: 0x04000940 RID: 2368
		PhantomBattleDealCardNotify = 26464,
		// Token: 0x04000941 RID: 2369
		PhantomBattleDealCardReplaceNotify = 27437,
		// Token: 0x04000942 RID: 2370
		PhantomBattleDealCardReplaceRequest = 23882,
		// Token: 0x04000943 RID: 2371
		PhantomBattleDealCardReplaceResponse = 23721,
		// Token: 0x04000944 RID: 2372
		PhantomBattleEnterSlotRequest = 16359,
		// Token: 0x04000945 RID: 2373
		PhantomBattleEnterSlotResponse = 15195,
		// Token: 0x04000946 RID: 2374
		PhantomBattleEvolveRequest = 18425,
		// Token: 0x04000947 RID: 2375
		PhantomBattleEvolveResponse = 26438,
		// Token: 0x04000948 RID: 2376
		PhantomBattleBackLibraryRequest = 25172,
		// Token: 0x04000949 RID: 2377
		PhantomBattleBackLibraryResponse = 29876,
		// Token: 0x0400094A RID: 2378
		PhantomBattleRoundOverRequest = 24624,
		// Token: 0x0400094B RID: 2379
		PhantomBattleRoundOverResponse = 25961,
		// Token: 0x0400094C RID: 2380
		PhantomBattleSlotInsteadRequest = 22801,
		// Token: 0x0400094D RID: 2381
		PhantomBattleSlotInsteadResponse = 27889,
		// Token: 0x0400094E RID: 2382
		PhantomBattleRoundChangeNotify = 24896,
		// Token: 0x0400094F RID: 2383
		BirthDayCardRoleRequest = 25746,
		// Token: 0x04000950 RID: 2384
		BirthDayCardRoleResponse = 16190,
		// Token: 0x04000951 RID: 2385
		BirthDayRewardRequest = 20245,
		// Token: 0x04000952 RID: 2386
		BirthDayRewardResponse = 21898,
		// Token: 0x04000953 RID: 2387
		BirthDayInfoNotify = 19209,
		// Token: 0x04000954 RID: 2388
		EntityRewardItemNotify = 15063,
		// Token: 0x04000955 RID: 2389
		DangoMonopolyRewardNotify = 18421,
		// Token: 0x04000956 RID: 2390
		ApplyBuffFailedNotify = 22435,
		// Token: 0x04000957 RID: 2391
		ConsumptiveTaskInfoNotify = 22419,
		// Token: 0x04000958 RID: 2392
		TemplateEntitySpawnerContentNotify = 27757,
		// Token: 0x04000959 RID: 2393
		DirectTrainInfoRequest = 26229,
		// Token: 0x0400095A RID: 2394
		DirectTrainInfoResponse = 28515,
		// Token: 0x0400095B RID: 2395
		RegressQuestionOpenRequest = 25100,
		// Token: 0x0400095C RID: 2396
		RegressQuestionOpenResponse = 19944,
		// Token: 0x0400095D RID: 2397
		NpcPhantomBattleFightInfoNotify = 15338,
		// Token: 0x0400095E RID: 2398
		PhantomBattleDeployNotify = 18865,
		// Token: 0x0400095F RID: 2399
		PhantomBattleGamerStatusInfoNotify = 26461,
		// Token: 0x04000960 RID: 2400
		PhantomBattleCardAttrInfoNotify = 26580,
		// Token: 0x04000961 RID: 2401
		PhantomBattleLeaveSlotRequest = 17547,
		// Token: 0x04000962 RID: 2402
		PhantomBattleLeaveSlotResponse = 25036,
		// Token: 0x04000963 RID: 2403
		PhantomBattleSelectTargetEffectNotify = 22838,
		// Token: 0x04000964 RID: 2404
		PhantomBattleSelectTargetRequest = 24025,
		// Token: 0x04000965 RID: 2405
		PhantomBattleSelectTargetResponse = 25311,
		// Token: 0x04000966 RID: 2406
		PhantomBattleSkillTriggerInfoNotify = 24105,
		// Token: 0x04000967 RID: 2407
		PhantomBattleBuffTriggerInfoNotify = 18740,
		// Token: 0x04000968 RID: 2408
		ConsumptiveActivityInfoRequest = 18867,
		// Token: 0x04000969 RID: 2409
		ConsumptiveActivityInfoResponse = 24847,
		// Token: 0x0400096A RID: 2410
		PhantomBattleCardRoleSkillRequest = 17639,
		// Token: 0x0400096B RID: 2411
		PhantomBattleCardRoleSkillResponse = 23783,
		// Token: 0x0400096C RID: 2412
		PhantomBattleCardSkillRequest = 15904,
		// Token: 0x0400096D RID: 2413
		PhantomBattleCardSkillResponse = 19901,
		// Token: 0x0400096E RID: 2414
		InstSaveDataNotify = 29945,
		// Token: 0x0400096F RID: 2415
		RogueResMoodRangeUpdateNotify = 29633,
		// Token: 0x04000970 RID: 2416
		MoraleInfoNotify = 18749,
		// Token: 0x04000971 RID: 2417
		SetQuestFocusModeRequest = 29838,
		// Token: 0x04000972 RID: 2418
		SetQuestFocusModeResponse = 21189,
		// Token: 0x04000973 RID: 2419
		CancelQuestFocusModeRequest = 23764,
		// Token: 0x04000974 RID: 2420
		CancelQuestFocusModeResponse = 29321,
		// Token: 0x04000975 RID: 2421
		QuestFocusInfoNotify = 18164,
		// Token: 0x04000976 RID: 2422
		PhantomBattleNpcShowOverRequest = 26102,
		// Token: 0x04000977 RID: 2423
		PhantomBattleNpcShowOverResponse = 17530,
		// Token: 0x04000978 RID: 2424
		PhantomBattleBvBLoadingNotify = 24799,
		// Token: 0x04000979 RID: 2425
		PhantomBattleBvBLoadingFinishRequest = 21700,
		// Token: 0x0400097A RID: 2426
		PhantomBattleBvBLoadingFinishResponse = 24562,
		// Token: 0x0400097B RID: 2427
		PhantomBattleBvBFightNotify = 27009,
		// Token: 0x0400097C RID: 2428
		PhantomBattleBvBSettleNotify = 19121,
		// Token: 0x0400097D RID: 2429
		PhantomBattleStartRequest = 21680,
		// Token: 0x0400097E RID: 2430
		PhantomBattleStartResponse = 24441,
		// Token: 0x0400097F RID: 2431
		DirectTrainPreOpenCloseNotify = 23904,
		// Token: 0x04000980 RID: 2432
		PhantomBattleBoardSettleNotify = 21589,
		// Token: 0x04000981 RID: 2433
		DebugDrawPosNotify = 20812,
		// Token: 0x04000982 RID: 2434
		RacingBetLegMatchSettleNotify = 24713,
		// Token: 0x04000983 RID: 2435
		PhantomBattleAddBuffInfoNotify = 16131,
		// Token: 0x04000984 RID: 2436
		DirectTrainInfoNotify = 28529,
		// Token: 0x04000985 RID: 2437
		AcceptFocusWaitQuestRequest = 29846,
		// Token: 0x04000986 RID: 2438
		AcceptFocusWaitQuestResponse = 17260,
		// Token: 0x04000987 RID: 2439
		PhantomBattleDiscardCardNotify = 17903,
		// Token: 0x04000988 RID: 2440
		PhantomBattleDiscardCardRequest = 21509,
		// Token: 0x04000989 RID: 2441
		PhantomBattleDiscardCardResponse = 17740,
		// Token: 0x0400098A RID: 2442
		NavigationFindPathRequest = 24357,
		// Token: 0x0400098B RID: 2443
		NavigationFindPathResponse = 25627,
		// Token: 0x0400098C RID: 2444
		PhantomBattleFourCTaskInfoUpdateNotify = 27016,
		// Token: 0x0400098D RID: 2445
		PhantomBattleFourCTaskDealCardNotify = 29973,
		// Token: 0x0400098E RID: 2446
		PhantomBattleCardGroupDeleteRequest = 22811,
		// Token: 0x0400098F RID: 2447
		PhantomBattleCardGroupDeleteResponse = 29932,
		// Token: 0x04000990 RID: 2448
		SlashAndTowerOverNotify = 25940,
		// Token: 0x04000991 RID: 2449
		QuestReviewInfoNotify = 28644,
		// Token: 0x04000992 RID: 2450
		QuestReviewInfoRequest = 24599,
		// Token: 0x04000993 RID: 2451
		QuestReviewInfoResponse = 16788,
		// Token: 0x04000994 RID: 2452
		RefreshBuffDurationPush = 27178,
		// Token: 0x04000995 RID: 2453
		NewbieCarnivalSwitchRoleRequest = 17631,
		// Token: 0x04000996 RID: 2454
		NewbieCarnivalSwitchRoleResponse = 18412,
		// Token: 0x04000997 RID: 2455
		NewbieCarnivalTaskDataUpdateNotify = 29644,
		// Token: 0x04000998 RID: 2456
		NewbieCarnivalAwardRequest = 17112,
		// Token: 0x04000999 RID: 2457
		NewbieCarnivalAwardResponse = 25525,
		// Token: 0x0400099A RID: 2458
		PhantomBattleCardSelectRequest = 15431,
		// Token: 0x0400099B RID: 2459
		PhantomBattleCardSelectResponse = 24389,
		// Token: 0x0400099C RID: 2460
		PhantomBattleCardTargetInfoRequest = 19967,
		// Token: 0x0400099D RID: 2461
		PhantomBattleCardTargetInfoResponse = 20438,
		// Token: 0x0400099E RID: 2462
		PhantomBattleCardRoleTargetInfoRequest = 21677,
		// Token: 0x0400099F RID: 2463
		PhantomBattleCardRoleTargetInfoResponse = 27282,
		// Token: 0x040009A0 RID: 2464
		TimeLockInfoNotify = 21913,
		// Token: 0x040009A1 RID: 2465
		PhantomBattleCardUnlockRequest = 25809,
		// Token: 0x040009A2 RID: 2466
		PhantomBattleCardUnlockResponse = 16683,
		// Token: 0x040009A3 RID: 2467
		PhantomBattleCardUpdateNotify = 19936,
		// Token: 0x040009A4 RID: 2468
		OccupyRewardRequest = 20644,
		// Token: 0x040009A5 RID: 2469
		OccupyRewardResponse = 22814,
		// Token: 0x040009A6 RID: 2470
		SetQuestResourceStateRequest = 29385,
		// Token: 0x040009A7 RID: 2471
		SetQuestResourceStateResponse = 25299,
		// Token: 0x040009A8 RID: 2472
		NewbieCarnivalTaskJumpUpdateNotify = 20522,
		// Token: 0x040009A9 RID: 2473
		StartSetQuestFocusNotify = 17380,
		// Token: 0x040009AA RID: 2474
		PhantomBattleCardPosChangeNotify = 20505,
		// Token: 0x040009AB RID: 2475
		RogueResFormationUpdateNotify = 29375,
		// Token: 0x040009AC RID: 2476
		LongShanScoreRewardRequest = 17915,
		// Token: 0x040009AD RID: 2477
		LongShanScoreRewardResponse = 26718,
		// Token: 0x040009AE RID: 2478
		BathChangeCameraRequest = 29105,
		// Token: 0x040009AF RID: 2479
		BathChangeCameraResponse = 24262,
		// Token: 0x040009B0 RID: 2480
		BathPhotoRequest = 26824,
		// Token: 0x040009B1 RID: 2481
		BathPhotoResponse = 16457,
		// Token: 0x040009B2 RID: 2482
		PhantomBattleChallengeUpdateNotify = 26160,
		// Token: 0x040009B3 RID: 2483
		FinishDownloadQuestResourceRequest = 29854,
		// Token: 0x040009B4 RID: 2484
		FinishDownloadQuestResourceResponse = 24046,
		// Token: 0x040009B5 RID: 2485
		PhantomBattleBackSlotCardLibraryRequest = 27245,
		// Token: 0x040009B6 RID: 2486
		PhantomBattleBackSlotCardLibraryResponse = 22253,
		// Token: 0x040009B7 RID: 2487
		FloroRanchUnlockTechPointRequest = 24158,
		// Token: 0x040009B8 RID: 2488
		FloroRanchUnlockTechPointResponse = 23616,
		// Token: 0x040009B9 RID: 2489
		FloroRanchRewardTaskRequest = 16221,
		// Token: 0x040009BA RID: 2490
		FloroRanchRewardTaskResponse = 28020,
		// Token: 0x040009BB RID: 2491
		FloroRanchRewardMilestoneRequest = 27873,
		// Token: 0x040009BC RID: 2492
		FloroRanchRewardMilestoneResponse = 27049,
		// Token: 0x040009BD RID: 2493
		FloroRanchStartPlayRequest = 16910,
		// Token: 0x040009BE RID: 2494
		FloroRanchStartPlayResponse = 26272,
		// Token: 0x040009BF RID: 2495
		FloroRanchSettleRequest = 28679,
		// Token: 0x040009C0 RID: 2496
		FloroRanchSettleResponse = 25335,
		// Token: 0x040009C1 RID: 2497
		FloroRanchPlayNextDayRequest = 29541,
		// Token: 0x040009C2 RID: 2498
		FloroRanchPlayNextDayResponse = 19866,
		// Token: 0x040009C3 RID: 2499
		FloroRanchPlayGachaRequest = 24204,
		// Token: 0x040009C4 RID: 2500
		FloroRanchPlayGachaResponse = 26482,
		// Token: 0x040009C5 RID: 2501
		FloroRanchPlayShopBuyRequest = 16947,
		// Token: 0x040009C6 RID: 2502
		FloroRanchPlayShopBuyResponse = 21023,
		// Token: 0x040009C7 RID: 2503
		FloroRanchPlayEventChoiceRequest = 23181,
		// Token: 0x040009C8 RID: 2504
		FloroRanchPlayEventChoiceResponse = 19545,
		// Token: 0x040009C9 RID: 2505
		FloroRanchPlayTributeRequest = 27731,
		// Token: 0x040009CA RID: 2506
		FloroRanchPlayTributeResponse = 19879,
		// Token: 0x040009CB RID: 2507
		FloroRanchPlayUnlimitedModeRequest = 23389,
		// Token: 0x040009CC RID: 2508
		FloroRanchPlayUnlimitedModeResponse = 22265,
		// Token: 0x040009CD RID: 2509
		FloroRanchUpdatePlayerInfoNotify = 22040,
		// Token: 0x040009CE RID: 2510
		KcpConvRequest = 3728,
		// Token: 0x040009CF RID: 2511
		KcpConvResponse,
		// Token: 0x040009D0 RID: 2512
		ActionOperationScreenNotify = 18224,
		// Token: 0x040009D1 RID: 2513
		ActionOperationScreenSuccessRequest = 20776,
		// Token: 0x040009D2 RID: 2514
		ActionOperationScreenSuccessResponse = 17481,
		// Token: 0x040009D3 RID: 2515
		PhantomBattleSelectReserveCardNotify = 24681,
		// Token: 0x040009D4 RID: 2516
		PhantomBattleSelectReserveCardRequest = 20746,
		// Token: 0x040009D5 RID: 2517
		PhantomBattleSelectReserveCardResponse = 18367,
		// Token: 0x040009D6 RID: 2518
		FloroRanchPlayRemoveUnitRequest = 22961,
		// Token: 0x040009D7 RID: 2519
		FloroRanchPlayRemoveUnitResponse = 27510,
		// Token: 0x040009D8 RID: 2520
		PhantomBattleSlotCardSkillRequest = 22653,
		// Token: 0x040009D9 RID: 2521
		PhantomBattleSlotCardSkillResponse = 26443,
		// Token: 0x040009DA RID: 2522
		PhantomBattleBurnBuffNotify = 21033,
		// Token: 0x040009DB RID: 2523
		ConstructTrapRequest = 21336,
		// Token: 0x040009DC RID: 2524
		ConstructTrapResponse = 28302,
		// Token: 0x040009DD RID: 2525
		DeconstructTrapRequest = 15715,
		// Token: 0x040009DE RID: 2526
		DeconstructTrapResponse = 17614,
		// Token: 0x040009DF RID: 2527
		PhantomBattleReChallengeRequest = 23304,
		// Token: 0x040009E0 RID: 2528
		PhantomBattleReChallengeResponse = 25507,
		// Token: 0x040009E1 RID: 2529
		FloroRanchPlayRefreshShopRequest = 25019,
		// Token: 0x040009E2 RID: 2530
		FloroRanchPlayRefreshShopResponse = 18811,
		// Token: 0x040009E3 RID: 2531
		FloroRanchPlayRefreshGachaRequest = 20257,
		// Token: 0x040009E4 RID: 2532
		FloroRanchPlayRefreshGachaResponse = 27548,
		// Token: 0x040009E5 RID: 2533
		PhantomBattleDebugInfoRequest = 24959,
		// Token: 0x040009E6 RID: 2534
		PhantomBattleDebugInfoResponse = 20930,
		// Token: 0x040009E7 RID: 2535
		MoralePosRequest = 24392,
		// Token: 0x040009E8 RID: 2536
		MoralePosResponse = 16263,
		// Token: 0x040009E9 RID: 2537
		SlowTimePush = 28835,
		// Token: 0x040009EA RID: 2538
		LifePointChallengeUpdateNotify = 15515,
		// Token: 0x040009EB RID: 2539
		RunTestRequest = 20152,
		// Token: 0x040009EC RID: 2540
		RunTestResponse = 21458,
		// Token: 0x040009ED RID: 2541
		PhantomSettingRequest = 26762,
		// Token: 0x040009EE RID: 2542
		PhantomSettingResponse = 29364,
		// Token: 0x040009EF RID: 2543
		TestCmdNotify = 21962,
		// Token: 0x040009F0 RID: 2544
		PhantomSettingUpdateRequest = 26506,
		// Token: 0x040009F1 RID: 2545
		PhantomSettingUpdateResponse = 20909,
		// Token: 0x040009F2 RID: 2546
		PhantomBatchOperRequest = 29114,
		// Token: 0x040009F3 RID: 2547
		PhantomBatchOperResponse = 18810,
		// Token: 0x040009F4 RID: 2548
		ShopBuyNotify = 21076,
		// Token: 0x040009F5 RID: 2549
		QuestLockInfoNotify = 17210,
		// Token: 0x040009F6 RID: 2550
		GridCellUpdateNotify = 25103,
		// Token: 0x040009F7 RID: 2551
		VehiclePlatformGetOnRequest = 22526,
		// Token: 0x040009F8 RID: 2552
		VehiclePlatformGetOnResponse = 28415,
		// Token: 0x040009F9 RID: 2553
		PolluteGridCellRequest = 18862,
		// Token: 0x040009FA RID: 2554
		PolluteGridCellResponse = 29018,
		// Token: 0x040009FB RID: 2555
		LifePointChallengeStartRequest = 20181,
		// Token: 0x040009FC RID: 2556
		LifePointChallengeStartResponse = 29239,
		// Token: 0x040009FD RID: 2557
		FloroRanchPlaySelectCardGroupRequest = 15883,
		// Token: 0x040009FE RID: 2558
		FloroRanchPlaySelectCardGroupResponse = 24077,
		// Token: 0x040009FF RID: 2559
		SimpleCombatEntityDieRequest = 25559,
		// Token: 0x04000A00 RID: 2560
		SimpleCombatEntityDieResponse = 28019,
		// Token: 0x04000A01 RID: 2561
		InteractQuestSuspendEntityNotify = 28715,
		// Token: 0x04000A02 RID: 2562
		MoraleTreasureBoxTraceRequest = 26205,
		// Token: 0x04000A03 RID: 2563
		MoraleTreasureBoxTraceResponse = 20050,
		// Token: 0x04000A04 RID: 2564
		MulAchievementReceiveRequest = 20609,
		// Token: 0x04000A05 RID: 2565
		MulAchievementReceiveResponse = 29250,
		// Token: 0x04000A06 RID: 2566
		MulRoguelikeWriteCatRewardRequest = 27734,
		// Token: 0x04000A07 RID: 2567
		MulRoguelikeWriteCatRewardResponse = 20956,
		// Token: 0x04000A08 RID: 2568
		MulRogueWeeklyRewardRequest = 28205,
		// Token: 0x04000A09 RID: 2569
		MulRogueWeeklyRewardResponse = 23258,
		// Token: 0x04000A0A RID: 2570
		MulPhantomBattleMasterLevelRewardRequest = 26911,
		// Token: 0x04000A0B RID: 2571
		MulPhantomBattleMasterLevelRewardResponse = 21948,
		// Token: 0x04000A0C RID: 2572
		MulGetAdventureRewardRequest = 15472,
		// Token: 0x04000A0D RID: 2573
		MulGetAdventureRewardResponse = 15647,
		// Token: 0x04000A0E RID: 2574
		MulCalabashLevelRewardRequest = 27027,
		// Token: 0x04000A0F RID: 2575
		MulCalabashLevelRewardResponse = 17924,
		// Token: 0x04000A10 RID: 2576
		MulExploreScoreRewardRequest = 18094,
		// Token: 0x04000A11 RID: 2577
		MulExploreScoreRewardResponse = 15959,
		// Token: 0x04000A12 RID: 2578
		MulFishingIllustratedRewardRequest = 23031,
		// Token: 0x04000A13 RID: 2579
		MulFishingIllustratedRewardResponse = 29037,
		// Token: 0x04000A14 RID: 2580
		MulMapTravelTaskRewardRequest = 29978,
		// Token: 0x04000A15 RID: 2581
		MulMapTravelTaskRewardResponse = 22477,
		// Token: 0x04000A16 RID: 2582
		FloroRanchPlayGmInfoUpdateNotify = 19286,
		// Token: 0x04000A17 RID: 2583
		FloroRanchPlayGachaRefreshRequest = 24913,
		// Token: 0x04000A18 RID: 2584
		FloroRanchPlayGachaRefreshResponse = 22802,
		// Token: 0x04000A19 RID: 2585
		ResetQuestFocusModeNotify = 27177,
		// Token: 0x04000A1A RID: 2586
		FloroRanchExecuteSkillPlayRequest = 23150,
		// Token: 0x04000A1B RID: 2587
		FloroRanchExecuteSkillPlayResponse = 26537,
		// Token: 0x04000A1C RID: 2588
		HoldHandRequest = 26904,
		// Token: 0x04000A1D RID: 2589
		HoldHandResponse = 26804,
		// Token: 0x04000A1E RID: 2590
		TrapDefensePreviewFinishRequest = 26107,
		// Token: 0x04000A1F RID: 2591
		TrapDefensePreviewFinishResponse = 26110,
		// Token: 0x04000A20 RID: 2592
		TrapDefensePreviewStartNotify = 28509,
		// Token: 0x04000A21 RID: 2593
		RoleGoDownPush = 21463,
		// Token: 0x04000A22 RID: 2594
		RoleGoDownNotify = 24225,
		// Token: 0x04000A23 RID: 2595
		FloroRanchSettleDataRequest = 22870,
		// Token: 0x04000A24 RID: 2596
		FloroRanchSettleDataResponse = 21024,
		// Token: 0x04000A25 RID: 2597
		SetFocusModeDeterCondRequest = 27054,
		// Token: 0x04000A26 RID: 2598
		SetFocusModeDeterCondResponse = 22252,
		// Token: 0x04000A27 RID: 2599
		StopHoldHandNotify = 29128,
		// Token: 0x04000A28 RID: 2600
		LowMemoryChangeSceneStartNotify = 26026,
		// Token: 0x04000A29 RID: 2601
		LowMemoryChangeSceneFinishRequest = 22050,
		// Token: 0x04000A2A RID: 2602
		LowMemoryChangeSceneFinishResponse = 15315,
		// Token: 0x04000A2B RID: 2603
		RogueWeeklyArtifactInfoRequest = 29939,
		// Token: 0x04000A2C RID: 2604
		RogueWeeklyArtifactInfoResponse = 15940,
		// Token: 0x04000A2D RID: 2605
		RogueWeeklyArtifactSelectRequest = 23037,
		// Token: 0x04000A2E RID: 2606
		RogueWeeklyArtifactSelectResponse = 16473,
		// Token: 0x04000A2F RID: 2607
		TrapDefenseRewardGainingGroupsNotify = 15832,
		// Token: 0x04000A30 RID: 2608
		TrapDefenseRefreshGainingGroupRequest = 27268,
		// Token: 0x04000A31 RID: 2609
		TrapDefenseRefreshGainingGroupResponse = 19444,
		// Token: 0x04000A32 RID: 2610
		TrapDefenseSelectGainingGroupRequest = 23459,
		// Token: 0x04000A33 RID: 2611
		TrapDefenseSelectGainingGroupResponse = 20864,
		// Token: 0x04000A34 RID: 2612
		TrapDefenseSyncGainingGroupsNotify = 15348,
		// Token: 0x04000A35 RID: 2613
		SimpleCombatEntityBuffUpdateNotify = 17893,
		// Token: 0x04000A36 RID: 2614
		TrapDefenseSystemInfoNotify = 25227,
		// Token: 0x04000A37 RID: 2615
		ItemPkgFullNotify = 29804,
		// Token: 0x04000A38 RID: 2616
		TrapDefenseChallengeUpdateNotify = 28586,
		// Token: 0x04000A39 RID: 2617
		TrapDefenseRewardUpdateNotify = 29453,
		// Token: 0x04000A3A RID: 2618
		TrapDefenseSpecialRewardUpdateNotify = 24748,
		// Token: 0x04000A3B RID: 2619
		TrapDefenseDevelopInfoUpdateNotify = 27912,
		// Token: 0x04000A3C RID: 2620
		TrapDefenseTechUpdateNotify = 28334,
		// Token: 0x04000A3D RID: 2621
		TrapDefenseTechUnlockRequest = 28920,
		// Token: 0x04000A3E RID: 2622
		TrapDefenseTechUnlockResponse = 24341,
		// Token: 0x04000A3F RID: 2623
		TrapDefenseGetRewardRequest = 21539,
		// Token: 0x04000A40 RID: 2624
		TrapDefenseGetRewardResponse = 22279,
		// Token: 0x04000A41 RID: 2625
		TrapDefenseGetSpecialRewardRequest = 15114,
		// Token: 0x04000A42 RID: 2626
		TrapDefenseGetSpecialRewardResponse = 19710,
		// Token: 0x04000A43 RID: 2627
		TrapDefenseBuildingLevelUpRequest = 26196,
		// Token: 0x04000A44 RID: 2628
		TrapDefenseBuildingLevelUpResponse = 28185,
		// Token: 0x04000A45 RID: 2629
		TrapDefenseBuildingBranchRequest = 27569,
		// Token: 0x04000A46 RID: 2630
		TrapDefenseBuildingBranchResponse = 17534,
		// Token: 0x04000A47 RID: 2631
		TrapDefenseAuxiliaryLevelUpRequest = 25960,
		// Token: 0x04000A48 RID: 2632
		TrapDefenseAuxiliaryLevelUpResponse = 18673,
		// Token: 0x04000A49 RID: 2633
		TrapDefenseAuxiliaryBranchRequest = 19295,
		// Token: 0x04000A4A RID: 2634
		TrapDefenseAuxiliaryBranchResponse = 24209,
		// Token: 0x04000A4B RID: 2635
		FunPlayChallengeInfoUpdateNotify = 21748,
		// Token: 0x04000A4C RID: 2636
		FunPlayChallengeAwardRequest = 24156,
		// Token: 0x04000A4D RID: 2637
		FunPlayChallengeAwardResponse = 15240,
		// Token: 0x04000A4E RID: 2638
		FunPlayChallengeSettleNotify = 20471,
		// Token: 0x04000A4F RID: 2639
		LevelPlayOpenRequest = 16306,
		// Token: 0x04000A50 RID: 2640
		LevelPlayOpenResponse = 15023,
		// Token: 0x04000A51 RID: 2641
		TrapDefenseChallengeResultNotify = 19080,
		// Token: 0x04000A52 RID: 2642
		TrapDefenseChallengeQuitRequest = 17166,
		// Token: 0x04000A53 RID: 2643
		TrapDefenseChallengeQuitResponse = 24998,
		// Token: 0x04000A54 RID: 2644
		TrapDefenseBuildingResetRequest = 19127,
		// Token: 0x04000A55 RID: 2645
		TrapDefenseBuildingResetResponse = 18053,
		// Token: 0x04000A56 RID: 2646
		TrapDefenseAuxiliaryResetRequest = 17701,
		// Token: 0x04000A57 RID: 2647
		TrapDefenseAuxiliaryResetResponse = 26880,
		// Token: 0x04000A58 RID: 2648
		TrapDefenseDevelopResetRequest = 22176,
		// Token: 0x04000A59 RID: 2649
		TrapDefenseDevelopResetResponse = 17328,
		// Token: 0x04000A5A RID: 2650
		ExploreEntityTraceRequest = 29165,
		// Token: 0x04000A5B RID: 2651
		ExploreEntityTraceResponse = 26058,
		// Token: 0x04000A5C RID: 2652
		CommonTouchUiSettingUpdateRequest = 20368,
		// Token: 0x04000A5D RID: 2653
		CommonTouchUiSettingUpdateResponse = 21615,
		// Token: 0x04000A5E RID: 2654
		TrapDefenseSlotUpdateRequest = 29634,
		// Token: 0x04000A5F RID: 2655
		TrapDefenseSlotUpdateResponse = 18521,
		// Token: 0x04000A60 RID: 2656
		SceneItemSequenceFrameStartResponse = 22907,
		// Token: 0x04000A61 RID: 2657
		SceneItemSequenceFrameEndRequest = 15970,
		// Token: 0x04000A62 RID: 2658
		SceneItemSequenceFrameEndResponse = 20290,
		// Token: 0x04000A63 RID: 2659
		MulMapTravelSoarRewardRequest = 28556,
		// Token: 0x04000A64 RID: 2660
		MulMapTravelSoarRewardResponse = 28256,
		// Token: 0x04000A65 RID: 2661
		TrapDefenseStepUpdateNotify = 25839,
		// Token: 0x04000A66 RID: 2662
		PhantomSettingBatchUpdateRequest = 26395,
		// Token: 0x04000A67 RID: 2663
		PhantomSettingBatchUpdateResponse = 25796,
		// Token: 0x04000A68 RID: 2664
		TrapDefenseSystemInfoUpdateNotify = 16215,
		// Token: 0x04000A69 RID: 2665
		TrapDefenseSpawnMonsterWaveEndNotify = 29527,
		// Token: 0x04000A6A RID: 2666
		TrapDefenseMonsterConsecutiveKillsNotify = 19882,
		// Token: 0x04000A6B RID: 2667
		FloroRanchFirstEnterRequest = 26054,
		// Token: 0x04000A6C RID: 2668
		FloroRanchFirstEnterResponse = 21638,
		// Token: 0x04000A6D RID: 2669
		FloroRanchAnimationRequest = 15672,
		// Token: 0x04000A6E RID: 2670
		FloroRanchAnimationResponse = 18911,
		// Token: 0x04000A6F RID: 2671
		TrapDefenseBdUpdateNotify = 19038,
		// Token: 0x04000A70 RID: 2672
		BlackSwordChallengeInfoRequest = 21267,
		// Token: 0x04000A71 RID: 2673
		BlackSwordChallengeInfoResponse = 15067,
		// Token: 0x04000A72 RID: 2674
		RoleOperateSelfBgmRequest = 24710,
		// Token: 0x04000A73 RID: 2675
		RoleOperateSelfBgmResponse = 26577,
		// Token: 0x04000A74 RID: 2676
		SimpleCombatEntitySubTypeChangeNotify = 26830,
		// Token: 0x04000A75 RID: 2677
		TrapDefenseRefreshShopRequest = 22766,
		// Token: 0x04000A76 RID: 2678
		TrapDefenseRefreshShopResponse = 27769,
		// Token: 0x04000A77 RID: 2679
		TrapDefenseBuyShopProductRequest = 19270,
		// Token: 0x04000A78 RID: 2680
		TrapDefenseBuyShopProductResponse = 18945,
		// Token: 0x04000A79 RID: 2681
		TrapDefenseEntityDataChangeNotify = 22179,
		// Token: 0x04000A7A RID: 2682
		TrapDefenseTechPointUpdateNotify = 22033,
		// Token: 0x04000A7B RID: 2683
		SceneItemSequenceFrameStartRequest = 22424,
		// Token: 0x04000A7C RID: 2684
		MoonPhaseRandomRequest = 15178,
		// Token: 0x04000A7D RID: 2685
		MoonPhaseRandomResponse = 27423,
		// Token: 0x04000A7E RID: 2686
		MoonPhaseRewardRequest = 27767,
		// Token: 0x04000A7F RID: 2687
		MoonPhaseRewardResponse = 20673,
		// Token: 0x04000A80 RID: 2688
		CommonUiSettingNotify = 29215,
		// Token: 0x04000A81 RID: 2689
		TrapDefenseItemUpdateNotify = 23792,
		// Token: 0x04000A82 RID: 2690
		TrapDefenseUseItemRequest = 18631,
		// Token: 0x04000A83 RID: 2691
		TrapDefenseUseItemResponse = 27014,
		// Token: 0x04000A84 RID: 2692
		LineCrossActivityUpdateNotify = 19172,
		// Token: 0x04000A85 RID: 2693
		LineCrossChallengeStartRequest = 18834,
		// Token: 0x04000A86 RID: 2694
		LineCrossChallengeStartResponse = 19877,
		// Token: 0x04000A87 RID: 2695
		RoleIllustratedInfoRequest = 26704,
		// Token: 0x04000A88 RID: 2696
		RoleIllustratedInfoResponse = 16765,
		// Token: 0x04000A89 RID: 2697
		TrapDefenseCurChallengeInfoRequest = 27431,
		// Token: 0x04000A8A RID: 2698
		TrapDefenseCurChallengeInfoResponse = 27808,
		// Token: 0x04000A8B RID: 2699
		TrapDefenseGainingGroupUpdateNotify = 28590,
		// Token: 0x04000A8C RID: 2700
		RoleDevelopConfigRequest = 17421,
		// Token: 0x04000A8D RID: 2701
		RoleDevelopConfigResponse = 15651,
		// Token: 0x04000A8E RID: 2702
		PhotoFightResultNotify = 26116,
		// Token: 0x04000A8F RID: 2703
		PhotoFightTaskRewardRequest = 21817,
		// Token: 0x04000A90 RID: 2704
		PhotoFightTaskRewardResponse = 22692,
		// Token: 0x04000A91 RID: 2705
		PhotoFightSettleRequest = 27242,
		// Token: 0x04000A92 RID: 2706
		PhotoFightSettleResponse = 20695,
		// Token: 0x04000A93 RID: 2707
		TrapDefenseQuickEquipRequest = 20940,
		// Token: 0x04000A94 RID: 2708
		TrapDefenseQuickEquipResponse = 21470,
		// Token: 0x04000A95 RID: 2709
		PhotoFightLevelInfoNotify = 16757,
		// Token: 0x04000A96 RID: 2710
		SimpleCombatEntityBuffLayerCountNotify = 22102,
		// Token: 0x04000A97 RID: 2711
		FloroRanchCloseTaskRequest = 22122,
		// Token: 0x04000A98 RID: 2712
		FloroRanchCloseTaskResponse = 22776,
		// Token: 0x04000A99 RID: 2713
		FsmConditionPassPush = 19070,
		// Token: 0x04000A9A RID: 2714
		EntityCalabashSkinChangeNotify = 15059,
		// Token: 0x04000A9B RID: 2715
		CalabashSkinTakeOnRequest = 20574,
		// Token: 0x04000A9C RID: 2716
		CalabashSkinTakeOnResponse = 29991,
		// Token: 0x04000A9D RID: 2717
		WuWuKujiGachaRequest = 16766,
		// Token: 0x04000A9E RID: 2718
		WuWuKujiGachaResponse = 15175,
		// Token: 0x04000A9F RID: 2719
		SurvivorsOpDataUpdateNotify = 15846,
		// Token: 0x04000AA0 RID: 2720
		SurvivorsOpDataForceChangeNotify = 24578,
		// Token: 0x04000AA1 RID: 2721
		SurvivorsGainDataUpdateNotify = 19888,
		// Token: 0x04000AA2 RID: 2722
		SurvivorsOpDoneRequest = 26819,
		// Token: 0x04000AA3 RID: 2723
		SurvivorsOpDoneResponse = 22698,
		// Token: 0x04000AA4 RID: 2724
		SurvivorsLockRequest = 18939,
		// Token: 0x04000AA5 RID: 2725
		SurvivorsLockResponse = 25907,
		// Token: 0x04000AA6 RID: 2726
		SurvivorsInstGlobalDataNotify = 25324,
		// Token: 0x04000AA7 RID: 2727
		SurvivorsStepUpdateNotify = 27029,
		// Token: 0x04000AA8 RID: 2728
		QuestTreeInfoRequest = 17462,
		// Token: 0x04000AA9 RID: 2729
		QuestTreeInfoResponse = 15806,
		// Token: 0x04000AAA RID: 2730
		QuestTreeInfoNotify = 15465,
		// Token: 0x04000AAB RID: 2731
		LoadCalabashSkinInfoRequest = 26014,
		// Token: 0x04000AAC RID: 2732
		LoadCalabashSkinInfoResponse = 17073,
		// Token: 0x04000AAD RID: 2733
		CalabashSkinTakeOnNotify = 27504,
		// Token: 0x04000AAE RID: 2734
		CalabashSkinUpdateNotify = 23736,
		// Token: 0x04000AAF RID: 2735
		YuXueModeInfoNotify = 27043,
		// Token: 0x04000AB0 RID: 2736
		SetPlayerYuXueModeRequest = 21804,
		// Token: 0x04000AB1 RID: 2737
		SetPlayerYuXueModeResponse = 15847,
		// Token: 0x04000AB2 RID: 2738
		SetBtObjYuXueModeRequest = 18881,
		// Token: 0x04000AB3 RID: 2739
		SetBtObjYuXueModeResponse = 27148,
		// Token: 0x04000AB4 RID: 2740
		GetYuXueModeInfoRequest = 18449,
		// Token: 0x04000AB5 RID: 2741
		GetYuXueModeInfoResponse = 16446,
		// Token: 0x04000AB6 RID: 2742
		TrapDefenseBdGroupUnlockNotify = 21201,
		// Token: 0x04000AB7 RID: 2743
		SurvivorsSpawnMonsterWaveEndNotify = 21097,
		// Token: 0x04000AB8 RID: 2744
		SurvivorsMonsterConsecutiveKillsNotify = 23401,
		// Token: 0x04000AB9 RID: 2745
		SurvivorsResultRequest = 17194,
		// Token: 0x04000ABA RID: 2746
		SurvivorsResultResponse = 15576,
		// Token: 0x04000ABB RID: 2747
		SurvivorsStepAdvanceRequest = 17496,
		// Token: 0x04000ABC RID: 2748
		SurvivorsStepAdvanceResponse = 18453,
		// Token: 0x04000ABD RID: 2749
		WeatherControlRequest = 19192,
		// Token: 0x04000ABE RID: 2750
		WeatherControlResponse = 27673,
		// Token: 0x04000ABF RID: 2751
		SurvivorsVarRecordNotify = 25152,
		// Token: 0x04000AC0 RID: 2752
		SurvivorsWeaponInfoRequest = 19675,
		// Token: 0x04000AC1 RID: 2753
		SurvivorsWeaponInfoResponse = 18985,
		// Token: 0x04000AC2 RID: 2754
		SurvivorsTaskDataUpdateNotify = 24480,
		// Token: 0x04000AC3 RID: 2755
		SurvivorsNormalAwardRequest = 29160,
		// Token: 0x04000AC4 RID: 2756
		SurvivorsNormalAwardResponse = 21229,
		// Token: 0x04000AC5 RID: 2757
		SurvivorsScoreAwardRequest = 18039,
		// Token: 0x04000AC6 RID: 2758
		SurvivorsScoreAwardResponse = 18111,
		// Token: 0x04000AC7 RID: 2759
		SurvivorsHandBooskUnlockNotify = 23073,
		// Token: 0x04000AC8 RID: 2760
		SurvivorsTalentLevelUpRequest = 29153,
		// Token: 0x04000AC9 RID: 2761
		SurvivorsTalentLevelUpResponse = 23041,
		// Token: 0x04000ACA RID: 2762
		SurvivorsTalentUnlockNotify = 20550,
		// Token: 0x04000ACB RID: 2763
		BatchSynthesisItemRequest = 26865,
		// Token: 0x04000ACC RID: 2764
		BatchSynthesisItemResponse = 20888,
		// Token: 0x04000ACD RID: 2765
		SurvivorsLastInfoRequest = 27662,
		// Token: 0x04000ACE RID: 2766
		SurvivorsLastInfoResponse = 15138,
		// Token: 0x04000ACF RID: 2767
		SurvivorsChallengeInfoUpdateNotify = 20450,
		// Token: 0x04000AD0 RID: 2768
		SimpleCombatEntitySyncAttributePush = 29113,
		// Token: 0x04000AD1 RID: 2769
		WeaponSkinUpdateNotify = 26225,
		// Token: 0x04000AD2 RID: 2770
		RoleSkinChangeNotify = 18513,
		// Token: 0x04000AD3 RID: 2771
		PlayerHeadUpdateNotify = 19263,
		// Token: 0x04000AD4 RID: 2772
		RoleUpdateDevelopTargetRequest = 29361,
		// Token: 0x04000AD5 RID: 2773
		RoleUpdateDevelopTargetResponse = 19264,
		// Token: 0x04000AD6 RID: 2774
		RoleUpdateDevelopTargetNotify = 24438,
		// Token: 0x04000AD7 RID: 2775
		MainPhantomRecommendResponse = 17594,
		// Token: 0x04000AD8 RID: 2776
		InfrInfoRequest = 26916,
		// Token: 0x04000AD9 RID: 2777
		InfrInfoResponse = 24251,
		// Token: 0x04000ADA RID: 2778
		InfrArchiveTaskRewardRequest = 23218,
		// Token: 0x04000ADB RID: 2779
		InfrArchiveTaskRewardResponse = 20584,
		// Token: 0x04000ADC RID: 2780
		InfrManualSwitchTraceRoadRequest = 23717,
		// Token: 0x04000ADD RID: 2781
		InfrManualSwitchTraceRoadResponse = 22149,
		// Token: 0x04000ADE RID: 2782
		InfrFireNoticeRequest = 21139,
		// Token: 0x04000ADF RID: 2783
		InfrFireNoticeResponse = 23545,
		// Token: 0x04000AE0 RID: 2784
		InfrFireAddNotify = 19099,
		// Token: 0x04000AE1 RID: 2785
		InfrRoadUpdateNotify = 16869,
		// Token: 0x04000AE2 RID: 2786
		CharacterMoveToPointNotify = 27358,
		// Token: 0x04000AE3 RID: 2787
		InfrFireUpdateNotify = 23308,
		// Token: 0x04000AE4 RID: 2788
		PackAnimChangedNotify = 27418,
		// Token: 0x04000AE5 RID: 2789
		MainPhantomRecommendRequest = 19481,
		// Token: 0x04000AE6 RID: 2790
		InfrLevelUpRequest = 24462,
		// Token: 0x04000AE7 RID: 2791
		InfrLevelUpResponse = 23326,
		// Token: 0x04000AE8 RID: 2792
		InfrRoadBuildRequest = 26235,
		// Token: 0x04000AE9 RID: 2793
		InfrRoadBuildResponse = 22831,
		// Token: 0x04000AEA RID: 2794
		CharacterMoveToPointEndPush = 21734,
		// Token: 0x04000AEB RID: 2795
		BlackSwordChallengeMarkItemPanelInfoRequest = 27609,
		// Token: 0x04000AEC RID: 2796
		BlackSwordChallengeMarkItemPanelInfoResponse = 20814,
		// Token: 0x04000AED RID: 2797
		RogueWeeklyInteractionResultNotify = 20079,
		// Token: 0x04000AEE RID: 2798
		HonamiStoryLimitTaskInfoUpdateNotify = 21435,
		// Token: 0x04000AEF RID: 2799
		HonamiStoryAreaTaskInfoRefreshNotify = 28536,
		// Token: 0x04000AF0 RID: 2800
		HonamiStoryAreaTaskInfoUpdateNotify = 22423,
		// Token: 0x04000AF1 RID: 2801
		HonamiStoryBagInfoUpdateNotify = 24569,
		// Token: 0x04000AF2 RID: 2802
		HonamiStoryBagOperateRequest = 20504,
		// Token: 0x04000AF3 RID: 2803
		HonamiStoryBagOperateResponse = 21239,
		// Token: 0x04000AF4 RID: 2804
		HonamiStoryRoleUpdateNotify = 15005,
		// Token: 0x04000AF5 RID: 2805
		HonamiStoryEquipRoleRequest = 27034,
		// Token: 0x04000AF6 RID: 2806
		HonamiStoryEquipRoleResponse = 28938,
		// Token: 0x04000AF7 RID: 2807
		HonamiStoryUnlockSlotRequest = 16355,
		// Token: 0x04000AF8 RID: 2808
		HonamiStoryUnlockSlotResponse = 27913,
		// Token: 0x04000AF9 RID: 2809
		HonamiStoryAddWeaponNotify = 24790,
		// Token: 0x04000AFA RID: 2810
		HonamiStoryWeaponDressRequest = 23107,
		// Token: 0x04000AFB RID: 2811
		HonamiStoryWeaponDressResponse = 29480,
		// Token: 0x04000AFC RID: 2812
		HonamiStorySellItemRequest = 25624,
		// Token: 0x04000AFD RID: 2813
		HonamiStorySellItemResponse = 18536,
		// Token: 0x04000AFE RID: 2814
		HonamiStoryLifeSupportUpRequest = 17291,
		// Token: 0x04000AFF RID: 2815
		HonamiStoryLifeSupportUpResponse = 22538,
		// Token: 0x04000B00 RID: 2816
		HonamiStoryActivateTalentRequest = 26246,
		// Token: 0x04000B01 RID: 2817
		HonamiStoryActivateTalentResponse = 28751,
		// Token: 0x04000B02 RID: 2818
		HonamiStoryItemCollectionInfoUpdateNotify = 20304,
		// Token: 0x04000B03 RID: 2819
		HonamiStoryItemCollectionRequest = 20939,
		// Token: 0x04000B04 RID: 2820
		HonamiStoryItemCollectionResponse = 16494,
		// Token: 0x04000B05 RID: 2821
		HonamiStoryMascotInfoUpdateNotify = 19969,
		// Token: 0x04000B06 RID: 2822
		HonamiStoryMascotRewardRequest = 19377,
		// Token: 0x04000B07 RID: 2823
		HonamiStoryMascotRewardResponse = 25929,
		// Token: 0x04000B08 RID: 2824
		HonamiStoryAreaInfoUpdateNotify = 21643,
		// Token: 0x04000B09 RID: 2825
		HonamiStoryAreaSecretRewardRequest = 21261,
		// Token: 0x04000B0A RID: 2826
		HonamiStoryAreaSecretRewardResponse = 26290,
		// Token: 0x04000B0B RID: 2827
		HonamiStoryLimitTaskRewardRequest = 15084,
		// Token: 0x04000B0C RID: 2828
		HonamiStoryLimitTaskRewardResponse = 27065,
		// Token: 0x04000B0D RID: 2829
		HonamiStoryScoreRewardRequest = 20667,
		// Token: 0x04000B0E RID: 2830
		HonamiStoryScoreRewardResponse = 26582,
		// Token: 0x04000B0F RID: 2831
		HonamiStoryPickUpItemRequest = 24310,
		// Token: 0x04000B10 RID: 2832
		HonamiStoryPickUpItemResponse = 27375,
		// Token: 0x04000B11 RID: 2833
		HonamiStoryDiscardItemRequest = 20391,
		// Token: 0x04000B12 RID: 2834
		HonamiStoryDiscardItemResponse = 24394,
		// Token: 0x04000B13 RID: 2835
		HonamiStoryInstInfoNotify = 16347,
		// Token: 0x04000B14 RID: 2836
		HonamiStoryPollutionUpdateNotify = 20668,
		// Token: 0x04000B15 RID: 2837
		HonamiStoryInstSettleNotify = 21849,
		// Token: 0x04000B16 RID: 2838
		HonamiStoryInstTopTowerSettleNotify = 15272,
		// Token: 0x04000B17 RID: 2839
		HonamiStoryInstLeaveRequest = 24314,
		// Token: 0x04000B18 RID: 2840
		HonamiStoryInstLeaveResponse = 16258,
		// Token: 0x04000B19 RID: 2841
		HonamiStorySafeLeaveNotify = 23728,
		// Token: 0x04000B1A RID: 2842
		HonamiStoryPollutionBoxSteadyLimitNotify = 17022,
		// Token: 0x04000B1B RID: 2843
		HonamiStoryScoreRewardInfoUpdateNotify = 16232,
		// Token: 0x04000B1C RID: 2844
		GetTraceQuestYuXueModeRequest = 27714,
		// Token: 0x04000B1D RID: 2845
		GetTraceQuestYuXueModeResponse = 17059,
		// Token: 0x04000B1E RID: 2846
		EntityHonamiStoryEnhanceLevelNotify = 29068,
		// Token: 0x04000B1F RID: 2847
		SunSpiritListNotify = 21877,
		// Token: 0x04000B20 RID: 2848
		SunSpiritCollectNotify = 24685,
		// Token: 0x04000B21 RID: 2849
		SunSpiritUpdateNotify = 24091,
		// Token: 0x04000B22 RID: 2850
		RollBlockOpenGamePlayNotify = 21277,
		// Token: 0x04000B23 RID: 2851
		RollBlockResetGamePlayRequest = 20443,
		// Token: 0x04000B24 RID: 2852
		RollBlockResetGamePlayResponse = 29620,
		// Token: 0x04000B25 RID: 2853
		RollBlockMovementFinishRequest = 25423,
		// Token: 0x04000B26 RID: 2854
		HonamiStoryLockItemRequest = 20634,
		// Token: 0x04000B27 RID: 2855
		HonamiStoryLockItemResponse = 22131,
		// Token: 0x04000B28 RID: 2856
		RollBlockCloseGamePlayNotify = 19604,
		// Token: 0x04000B29 RID: 2857
		RollBlockSyncInfoNotify = 21853,
		// Token: 0x04000B2A RID: 2858
		RollBlockMovementFinishResponse = 22850,
		// Token: 0x04000B2B RID: 2859
		MulCorniceMeetingRewardRequest = 28733,
		// Token: 0x04000B2C RID: 2860
		MulCorniceMeetingRewardResponse = 16872,
		// Token: 0x04000B2D RID: 2861
		SunSpiritActionOperationEndPush = 20253,
		// Token: 0x04000B2E RID: 2862
		HonamiStoryLimitShopConsumeNumNotify = 27498,
		// Token: 0x04000B2F RID: 2863
		BuffEffectExecutePush = 18099,
		// Token: 0x04000B30 RID: 2864
		RollBlockInputRequest = 25360,
		// Token: 0x04000B31 RID: 2865
		RollBlockInputResponse = 29397,
		// Token: 0x04000B32 RID: 2866
		SurvivorsComboParamUpdateNotify = 27463,
		// Token: 0x04000B33 RID: 2867
		SunSpiritActionOperationNotify = 22508,
		// Token: 0x04000B34 RID: 2868
		MotorTechLevelUpRequest = 24261,
		// Token: 0x04000B35 RID: 2869
		MotorTechLevelUpResponse = 27374,
		// Token: 0x04000B36 RID: 2870
		WeatherControlInfoRequest = 18581,
		// Token: 0x04000B37 RID: 2871
		WeatherControlInfoResponse = 15945,
		// Token: 0x04000B38 RID: 2872
		ButtonIsEnableRequest = 26588,
		// Token: 0x04000B39 RID: 2873
		ButtonIsEnableResponse = 19953,
		// Token: 0x04000B3A RID: 2874
		MotorLevelOneKeyRewardRequest = 25015,
		// Token: 0x04000B3B RID: 2875
		MotorLevelOneKeyRewardResponse = 26315,
		// Token: 0x04000B3C RID: 2876
		HonamiStoryBagSizeUpdateNotify = 23119,
		// Token: 0x04000B3D RID: 2877
		MotorInfoRequest = 16731,
		// Token: 0x04000B3E RID: 2878
		MotorInfoResponse = 27754,
		// Token: 0x04000B3F RID: 2879
		MotorTaskOneKeyRewardRequest = 25118,
		// Token: 0x04000B40 RID: 2880
		MotorTaskOneKeyRewardResponse = 26287,
		// Token: 0x04000B41 RID: 2881
		MotorTaskInfoNotify = 22685,
		// Token: 0x04000B42 RID: 2882
		PhantomInteractionEquipRequest = 16770,
		// Token: 0x04000B43 RID: 2883
		PhantomInteractionEquipResponse = 25626,
		// Token: 0x04000B44 RID: 2884
		PhantomInteractionSkinChangeRequest = 26605,
		// Token: 0x04000B45 RID: 2885
		PhantomInteractionSkinChangeResponse = 20674,
		// Token: 0x04000B46 RID: 2886
		PhantomInteractionInfoUpdateNotify = 18664,
		// Token: 0x04000B47 RID: 2887
		PhantomInteractionUnlockNotify = 16490,
		// Token: 0x04000B48 RID: 2888
		ChangeSceneRoadNotify = 18972,
		// Token: 0x04000B49 RID: 2889
		MotorTechTreeSwitchRequest = 28833,
		// Token: 0x04000B4A RID: 2890
		MotorTechTreeSwitchResponse = 29362,
		// Token: 0x04000B4B RID: 2891
		MotorTaskUpdateNotify = 23000,
		// Token: 0x04000B4C RID: 2892
		MotorTechUnlockNotify = 22153,
		// Token: 0x04000B4D RID: 2893
		MotorTechTreeUnlockNotify = 16286,
		// Token: 0x04000B4E RID: 2894
		MotorDataNotify = 25061,
		// Token: 0x04000B4F RID: 2895
		AreaTerminalPinOperationRequest = 29677,
		// Token: 0x04000B50 RID: 2896
		AreaTerminalPinOperationResponse = 21372,
		// Token: 0x04000B51 RID: 2897
		GetDetectionTargetRequest = 28235,
		// Token: 0x04000B52 RID: 2898
		GetDetectionTargetResponse = 19055,
		// Token: 0x04000B53 RID: 2899
		DetectionTargetChangeNotify = 25568,
		// Token: 0x04000B54 RID: 2900
		AreaTerminalInfoNotify = 22310,
		// Token: 0x04000B55 RID: 2901
		InfrThemeActivityAwardRequest = 25047,
		// Token: 0x04000B56 RID: 2902
		InfrThemeActivityAwardResponse = 26171,
		// Token: 0x04000B57 RID: 2903
		HonamiStoryTopInfoNotify = 23604,
		// Token: 0x04000B58 RID: 2904
		RbBlockStateChangeNotify = 19426,
		// Token: 0x04000B59 RID: 2905
		HonamiStorySetFormationNotify = 27708,
		// Token: 0x04000B5A RID: 2906
		MotorSliderRequest = 23230,
		// Token: 0x04000B5B RID: 2907
		MotorSliderResponse = 17663,
		// Token: 0x04000B5C RID: 2908
		VisionTriggerPush = 19341,
		// Token: 0x04000B5D RID: 2909
		VisionTriggerNotify = 21314,
		// Token: 0x04000B5E RID: 2910
		SceneBlockSplitClientLoginPush = 18577,
		// Token: 0x04000B5F RID: 2911
		SceneBlockChangePush = 19606,
		// Token: 0x04000B60 RID: 2912
		SceneBlockSplitHumanChangleNotify = 26500,
		// Token: 0x04000B61 RID: 2913
		SceneBlockSplitHumanFullNotify = 28122,
		// Token: 0x04000B62 RID: 2914
		RemoveBuffByServerIdS2cRequestNotify = 23494,
		// Token: 0x04000B63 RID: 2915
		MotorExpAddNotify = 28144,
		// Token: 0x04000B64 RID: 2916
		SceneBlockSplitHumanSwitchStateNotify = 22518,
		// Token: 0x04000B65 RID: 2917
		SceneBlockSplitSwitchStatePush = 15490,
		// Token: 0x04000B66 RID: 2918
		HonamiStoryTalentInfoUpdateNotify = 28280,
		// Token: 0x04000B67 RID: 2919
		BossRushBatchClaimRewardRequest = 23121,
		// Token: 0x04000B68 RID: 2920
		BossRushBatchClaimRewardResponse = 23711,
		// Token: 0x04000B69 RID: 2921
		PhantomBattleAreaSkillRequest = 22966,
		// Token: 0x04000B6A RID: 2922
		PhantomBattleAreaSkillResponse = 18122,
		// Token: 0x04000B6B RID: 2923
		PhantomBattleAreaSkillCdNotify = 22971,
		// Token: 0x04000B6C RID: 2924
		PhantomBattleAreaSkillNotify = 25473,
		// Token: 0x04000B6D RID: 2925
		PhantomBattlePhantomCardSkillRequest = 19409,
		// Token: 0x04000B6E RID: 2926
		PhantomBattlePhantomCardSkillResponse = 25369,
		// Token: 0x04000B6F RID: 2927
		PhantomBattleCardDurableEmptyNotify = 17095,
		// Token: 0x04000B70 RID: 2928
		ArtemisNodeUpdateNotify = 15008,
		// Token: 0x04000B71 RID: 2929
		ArtemisNodeUpdateRequest = 15301,
		// Token: 0x04000B72 RID: 2930
		ArtemisNodeUpdateResponse = 26895,
		// Token: 0x04000B73 RID: 2931
		SceneBlockSplitPopWindowNotify = 22587,
		// Token: 0x04000B74 RID: 2932
		AddDecalRequest = 18113,
		// Token: 0x04000B75 RID: 2933
		AddDecalResponse = 29445,
		// Token: 0x04000B76 RID: 2934
		DecalAddNotify = 16035,
		// Token: 0x04000B77 RID: 2935
		DecalRemoveNotify = 28009,
		// Token: 0x04000B78 RID: 2936
		RoleSceneVoiceSwitchNotify = 17013,
		// Token: 0x04000B79 RID: 2937
		CoopRoleRewardRequest = 15123,
		// Token: 0x04000B7A RID: 2938
		CoopRoleRewardResponse = 17866,
		// Token: 0x04000B7B RID: 2939
		CoopSpRewardRequest = 23809,
		// Token: 0x04000B7C RID: 2940
		CoopSpRewardResponse = 16957,
		// Token: 0x04000B7D RID: 2941
		CoopRoleInfoUpdateNotify = 28969,
		// Token: 0x04000B7E RID: 2942
		HonamiStoryResidentTaskInfoUpdateNotify = 24495,
		// Token: 0x04000B7F RID: 2943
		HonamiStoryResidentTaskRewardRequest = 27008,
		// Token: 0x04000B80 RID: 2944
		HonamiStoryResidentTaskRewardResponse = 19821,
		// Token: 0x04000B81 RID: 2945
		HonamiStoryTotalRevenueNotify = 25388,
		// Token: 0x04000B82 RID: 2946
		RollBlockExitGamePlayRequest = 25320,
		// Token: 0x04000B83 RID: 2947
		RollBlockExitGamePlayResponse = 19646,
		// Token: 0x04000B84 RID: 2948
		RollBlockToggleHintRequest = 15024,
		// Token: 0x04000B85 RID: 2949
		RollBlockToggleHintResponse = 25640,
		// Token: 0x04000B86 RID: 2950
		MotorChangeOutlookRequest = 17225,
		// Token: 0x04000B87 RID: 2951
		MotorChangeOutlookResponse = 21672,
		// Token: 0x04000B88 RID: 2952
		MotorOutlookAddNotify = 22787,
		// Token: 0x04000B89 RID: 2953
		VehicleEnterSharingRequest = 24127,
		// Token: 0x04000B8A RID: 2954
		VehicleEnterSharingResponse = 29612,
		// Token: 0x04000B8B RID: 2955
		RollBlockSwitchControlBlockRequest = 16642,
		// Token: 0x04000B8C RID: 2956
		RollBlockSwitchControlBlockResponse = 28564,
		// Token: 0x04000B8D RID: 2957
		MotorOutlookOwnedChangeNotify = 29827,
		// Token: 0x04000B8E RID: 2958
		MotorOutlookEquippedChangeNotify = 16900,
		// Token: 0x04000B8F RID: 2959
		RollBlockUpdateGamePlayNotify = 22853,
		// Token: 0x04000B90 RID: 2960
		MotorLinkTaskRequest = 18830,
		// Token: 0x04000B91 RID: 2961
		MotorLinkTaskResponse = 20877,
		// Token: 0x04000B92 RID: 2962
		MotorcycleTaskUpdateNotify = 20935,
		// Token: 0x04000B93 RID: 2963
		InstEntityTeleportRequest = 16644,
		// Token: 0x04000B94 RID: 2964
		InstEntityTeleportResponse = 28666,
		// Token: 0x04000B95 RID: 2965
		DeadeyeShootHitRequest = 27253,
		// Token: 0x04000B96 RID: 2966
		DeadeyeShootHitResponse = 23822,
		// Token: 0x04000B97 RID: 2967
		MotorUseSkinRequest = 26877,
		// Token: 0x04000B98 RID: 2968
		MotorUseSkinResponse = 18288,
		// Token: 0x04000B99 RID: 2969
		PhantomBattleCallCardNotify = 15843,
		// Token: 0x04000B9A RID: 2970
		PhantomBattleCallCardRequest = 16342,
		// Token: 0x04000B9B RID: 2971
		PhantomBattleCallCardResponse = 19169,
		// Token: 0x04000B9C RID: 2972
		EntityMotorOutlookChangeNotify = 22728,
		// Token: 0x04000B9D RID: 2973
		ShortMessageInfoRequest = 15653,
		// Token: 0x04000B9E RID: 2974
		ShortMessageInfoResponse = 23875,
		// Token: 0x04000B9F RID: 2975
		ShortMessageReadRequest = 15211,
		// Token: 0x04000BA0 RID: 2976
		ShortMessageReadResponse = 21455,
		// Token: 0x04000BA1 RID: 2977
		ShortMessageReplyRequest = 17071,
		// Token: 0x04000BA2 RID: 2978
		ShortMessageReplyResponse = 20362,
		// Token: 0x04000BA3 RID: 2979
		ShortMessageReceivedRequest = 16353,
		// Token: 0x04000BA4 RID: 2980
		ShortMessageReceivedResponse = 18956,
		// Token: 0x04000BA5 RID: 2981
		ShortMessageUpdateNotify = 19211,
		// Token: 0x04000BA6 RID: 2982
		RoadNetworkEntityUpdateCurRoadPush = 24166,
		// Token: 0x04000BA7 RID: 2983
		InfrPhoneTaskRewardRequest = 22319,
		// Token: 0x04000BA8 RID: 2984
		InfrPhoneTaskRewardResponse = 23125,
		// Token: 0x04000BA9 RID: 2985
		InfrLibraryTaskUpdateNotify = 21906,
		// Token: 0x04000BAA RID: 2986
		RoadNetworkEntityStartNavNotify = 28503,
		// Token: 0x04000BAB RID: 2987
		RollBlockResetGamePlayNotify = 27566,
		// Token: 0x04000BAC RID: 2988
		ShortMessageUpdateRequest = 17215,
		// Token: 0x04000BAD RID: 2989
		ShortMessageUpdateResponse = 17070,
		// Token: 0x04000BAE RID: 2990
		BeamCastHitPlayerRequest = 25375,
		// Token: 0x04000BAF RID: 2991
		BeamCastHitPlayerResponse = 18932,
		// Token: 0x04000BB0 RID: 2992
		CaptureBatchEntityRequest = 17846,
		// Token: 0x04000BB1 RID: 2993
		CaptureBatchEntityResponse = 18685,
		// Token: 0x04000BB2 RID: 2994
		MotorOutlookRegionInfoNotify = 23727,
		// Token: 0x04000BB3 RID: 2995
		VehicleShareNotify = 25947,
		// Token: 0x04000BB4 RID: 2996
		RoadBookInfoUpdateNotify = 19177,
		// Token: 0x04000BB5 RID: 2997
		RoadBookFullRewardRequest = 18824,
		// Token: 0x04000BB6 RID: 2998
		RoadBookFullRewardResponse = 25470,
		// Token: 0x04000BB7 RID: 2999
		RoadBookLevelUpRequest = 24814,
		// Token: 0x04000BB8 RID: 3000
		RoadBookLevelUpResponse = 16518,
		// Token: 0x04000BB9 RID: 3001
		RoadBookTaskRewardRequest = 29300,
		// Token: 0x04000BBA RID: 3002
		RoadBookTaskRewardResponse = 27039,
		// Token: 0x04000BBB RID: 3003
		RoadBookMotorRewardRequest = 29858,
		// Token: 0x04000BBC RID: 3004
		RoadBookMotorRewardResponse = 15914,
		// Token: 0x04000BBD RID: 3005
		MotorParkourLevelRewardRequest = 15375,
		// Token: 0x04000BBE RID: 3006
		MotorParkourLevelRewardResponse = 19468,
		// Token: 0x04000BBF RID: 3007
		MotorParkourLevelRewardUpdateNotify = 17426,
		// Token: 0x04000BC0 RID: 3008
		PhantomBatchPolishRequest = 22703,
		// Token: 0x04000BC1 RID: 3009
		PhantomBatchPolishResponse = 26035,
		// Token: 0x04000BC2 RID: 3010
		MotorParkourResultNotify = 16702,
		// Token: 0x04000BC3 RID: 3011
		PhantomBattleCheckCardSkillUnlockRequest = 15765,
		// Token: 0x04000BC4 RID: 3012
		PhantomBattleCheckCardSkillUnlockResponse = 18934,
		// Token: 0x04000BC5 RID: 3013
		PhantomVicePolishRequest = 19711,
		// Token: 0x04000BC6 RID: 3014
		PhantomVicePolishResponse = 27294,
		// Token: 0x04000BC7 RID: 3015
		PhantomVicePolishAckRequest = 21501,
		// Token: 0x04000BC8 RID: 3016
		PhantomVicePolishAckResponse = 22926,
		// Token: 0x04000BC9 RID: 3017
		InfrThemeActivityTaskDataUpdateNotify = 24908,
		// Token: 0x04000BCA RID: 3018
		FurnitureDiySaveRequest = 21612,
		// Token: 0x04000BCB RID: 3019
		FurnitureDiySaveResponse = 27663,
		// Token: 0x04000BCC RID: 3020
		InfrManualCancelTraceRoadRequest = 19233,
		// Token: 0x04000BCD RID: 3021
		InfrManualCancelTraceRoadResponse = 21107,
		// Token: 0x04000BCE RID: 3022
		SkinRewardRequest = 17224,
		// Token: 0x04000BCF RID: 3023
		SkinRewardResponse = 26041,
		// Token: 0x04000BD0 RID: 3024
		SkinRewardInfoUpdateNotify = 26166,
		// Token: 0x04000BD1 RID: 3025
		InfrArchiveReadRequest = 21062,
		// Token: 0x04000BD2 RID: 3026
		InfrArchiveReadResponse = 25225,
		// Token: 0x04000BD3 RID: 3027
		AtomicProcessTeleportRequest = 26055,
		// Token: 0x04000BD4 RID: 3028
		AtomicProcessTeleportResponse = 27447,
		// Token: 0x04000BD5 RID: 3029
		NewTowerCycleStartResponse = 27252,
		// Token: 0x04000BD6 RID: 3030
		NewTowerResultNotify = 22039,
		// Token: 0x04000BD7 RID: 3031
		NewTowerUpdateRecordRequest = 26763,
		// Token: 0x04000BD8 RID: 3032
		NewTowerUpdateRecordResponse = 23318,
		// Token: 0x04000BD9 RID: 3033
		NewTowerRewardRequest = 20887,
		// Token: 0x04000BDA RID: 3034
		NewTowerRewardResponse = 18751,
		// Token: 0x04000BDB RID: 3035
		MotorFightTalentUpRequest = 29225,
		// Token: 0x04000BDC RID: 3036
		MotorFightTalentUpResponse = 19118,
		// Token: 0x04000BDD RID: 3037
		MotorFightOneKeyRewardRequest = 22785,
		// Token: 0x04000BDE RID: 3038
		MotorFightOneKeyRewardResponse = 26998,
		// Token: 0x04000BDF RID: 3039
		MotorFightRankListRequest = 21341,
		// Token: 0x04000BE0 RID: 3040
		MotorFightRankListResponse = 21992,
		// Token: 0x04000BE1 RID: 3041
		MotorFightTalentTreeUpdateNotify = 28750,
		// Token: 0x04000BE2 RID: 3042
		MotorFightItemUpdateNotify = 29340,
		// Token: 0x04000BE3 RID: 3043
		MotorFightRoleUpdateNotify = 28456,
		// Token: 0x04000BE4 RID: 3044
		MotorFightLevelUpdateNotify = 16531,
		// Token: 0x04000BE5 RID: 3045
		MotorFightTaskUpdateNotify = 24956,
		// Token: 0x04000BE6 RID: 3046
		HonamiStoryLifeSupportNotify = 25628,
		// Token: 0x04000BE7 RID: 3047
		PhantomBattleGuideRewardRequest = 17961,
		// Token: 0x04000BE8 RID: 3048
		PhantomBattleGuideRewardResponse = 23453,
		// Token: 0x04000BE9 RID: 3049
		FireShopCoinNotify = 25358,
		// Token: 0x04000BEA RID: 3050
		JokerGuessStartNewRequest = 28688,
		// Token: 0x04000BEB RID: 3051
		JokerGuessStartNewResponse = 24323,
		// Token: 0x04000BEC RID: 3052
		JokerGuessPlayCardRequest = 17130,
		// Token: 0x04000BED RID: 3053
		JokerGuessPlayCardResponse = 15319,
		// Token: 0x04000BEE RID: 3054
		JokerGuessDrawCardRequest = 21109,
		// Token: 0x04000BEF RID: 3055
		JokerGuessDrawCardResponse = 20858,
		// Token: 0x04000BF0 RID: 3056
		JokerGuessUseSkillRequest = 23048,
		// Token: 0x04000BF1 RID: 3057
		JokerGuessUseSkillResponse = 26805,
		// Token: 0x04000BF2 RID: 3058
		EncircleChallengeStartRequest = 21480,
		// Token: 0x04000BF3 RID: 3059
		EncircleChallengeStartResponse = 28360,
		// Token: 0x04000BF4 RID: 3060
		EncircleChallengeCompleteRequest = 15763,
		// Token: 0x04000BF5 RID: 3061
		EncircleChallengeCompleteResponse = 23650,
		// Token: 0x04000BF6 RID: 3062
		EncircleChallengeUpdateNotify = 22754,
		// Token: 0x04000BF7 RID: 3063
		NewTowerCycleStartRequest = 21855,
		// Token: 0x04000BF8 RID: 3064
		PhantomMusicCollectUpdateRequest = 24815,
		// Token: 0x04000BF9 RID: 3065
		PhantomMusicCollectUpdateResponse = 29261,
		// Token: 0x04000BFA RID: 3066
		H5CircumFluenceActivityReadRequest = 23797,
		// Token: 0x04000BFB RID: 3067
		H5CircumFluenceActivityReadResponse = 27658,
		// Token: 0x04000BFC RID: 3068
		HookLockBatchCollectRequest = 17206,
		// Token: 0x04000BFD RID: 3069
		HookLockBatchCollectResponse = 19834,
		// Token: 0x04000BFE RID: 3070
		HookLockBatchCollectNotify = 15974,
		// Token: 0x04000BFF RID: 3071
		MotorFightSettleRequest = 25017,
		// Token: 0x04000C00 RID: 3072
		MotorFightSettleResponse = 28563,
		// Token: 0x04000C01 RID: 3073
		MotorFightLastSaveDataRequest = 22296,
		// Token: 0x04000C02 RID: 3074
		MotorFightLastSaveDataResponse = 24235,
		// Token: 0x04000C03 RID: 3075
		PhantomBattleRepeatedTaskRewardRequest = 23196,
		// Token: 0x04000C04 RID: 3076
		PhantomBattleRepeatedTaskRewardResponse = 29535,
		// Token: 0x04000C05 RID: 3077
		NewTowerUpdateRecordNotify = 15739,
		// Token: 0x04000C06 RID: 3078
		NewTowerRoleEnergyRequest = 25896,
		// Token: 0x04000C07 RID: 3079
		NewTowerRoleEnergyResponse = 20585,
		// Token: 0x04000C08 RID: 3080
		HonamiStoryActivityInfoRequest = 22792,
		// Token: 0x04000C09 RID: 3081
		HonamiStoryActivityInfoResponse = 24610,
		// Token: 0x04000C0A RID: 3082
		PhantomBatchDirectRefiningRequest = 25223,
		// Token: 0x04000C0B RID: 3083
		PhantomBatchDirectRefiningResponse = 29320,
		// Token: 0x04000C0C RID: 3084
		PhantomDirectRefiningWeeklyResetNotify = 23980,
		// Token: 0x04000C0D RID: 3085
		PilotThrowOperationRequest = 20946,
		// Token: 0x04000C0E RID: 3086
		PilotThrowOperationResponse = 18656,
		// Token: 0x04000C0F RID: 3087
		ShortMessageItemUpdateNotify = 29198,
		// Token: 0x04000C10 RID: 3088
		ShortMessageShowChangeRequest = 27422,
		// Token: 0x04000C11 RID: 3089
		ShortMessageShowChangeResponse = 29072,
		// Token: 0x04000C12 RID: 3090
		MotorBattleContextNotify = 18170,
		// Token: 0x04000C13 RID: 3091
		NewPlayerSupportRewardTaskRequest = 25884,
		// Token: 0x04000C14 RID: 3092
		NewPlayerSupportRewardTaskResponse = 15261,
		// Token: 0x04000C15 RID: 3093
		NewPlayerSupportTrialRoleLvUpRequest = 27199,
		// Token: 0x04000C16 RID: 3094
		NewPlayerSupportTrialRoleLvUpResponse = 24698,
		// Token: 0x04000C17 RID: 3095
		PhantomBattleReconstructCardNotify = 18858,
		// Token: 0x04000C18 RID: 3096
		PhantomBattleReconstructCardRequest = 28082,
		// Token: 0x04000C19 RID: 3097
		PhantomBattleReconstructCardResponse = 18514,
		// Token: 0x04000C1A RID: 3098
		RegressDisposableRewardRequest = 17251,
		// Token: 0x04000C1B RID: 3099
		RegressDisposableRewardResponse = 20754,
		// Token: 0x04000C1C RID: 3100
		ExploreSkillActionRequest = 25144,
		// Token: 0x04000C1D RID: 3101
		ExploreSkillActionResponse = 16000,
		// Token: 0x04000C1E RID: 3102
		InstTeleportToResetPointRequest = 20140,
		// Token: 0x04000C1F RID: 3103
		InstTeleportToResetPointResponse = 20995,
		// Token: 0x04000C20 RID: 3104
		RollBlockUpdateAvailableInputsNotify = 23864,
		// Token: 0x04000C21 RID: 3105
		NewTowerClearRecordRequest = 22324,
		// Token: 0x04000C22 RID: 3106
		NewTowerClearRecordResponse = 27464,
		// Token: 0x04000C23 RID: 3107
		GetLevelPlayRewardsRequest = 19971,
		// Token: 0x04000C24 RID: 3108
		GetLevelPlayRewardsResponse = 20173,
		// Token: 0x04000C25 RID: 3109
		NewPlayerSupportActivityTaskUpdateNotify = 27935,
		// Token: 0x04000C26 RID: 3110
		MotorParkourStartNotify = 21824,
		// Token: 0x04000C27 RID: 3111
		MotorOutlookInfoRequest = 24056,
		// Token: 0x04000C28 RID: 3112
		MotorOutlookInfoResponse = 15636,
		// Token: 0x04000C29 RID: 3113
		Summon3Request = 22732,
		// Token: 0x04000C2A RID: 3114
		Summon3Response = 29484,
		// Token: 0x04000C2B RID: 3115
		RegressTrialRoleUnlockNotify = 26108,
		// Token: 0x04000C2C RID: 3116
		RegressTrialRoleLvUpRequest = 27895,
		// Token: 0x04000C2D RID: 3117
		RegressTrialRoleLvUpResponse = 18298,
		// Token: 0x04000C2E RID: 3118
		GravityHookLockPointChangeGravityRequest = 18495,
		// Token: 0x04000C2F RID: 3119
		GravityHookLockPointChangeGravityResponse = 15803,
		// Token: 0x04000C30 RID: 3120
		WeatherControlUnlockNotify = 15470,
		// Token: 0x04000C31 RID: 3121
		TotalTopUpScoreInfoRequest = 22350,
		// Token: 0x04000C32 RID: 3122
		TotalTopUpScoreInfoResponse = 21941,
		// Token: 0x04000C33 RID: 3123
		TotalTopUpRewardNotify = 26650,
		// Token: 0x04000C34 RID: 3124
		TotalTopUpRewardRequest = 23916,
		// Token: 0x04000C35 RID: 3125
		TotalTopUpRewardResponse = 24834,
		// Token: 0x04000C36 RID: 3126
		SceneBlockSplitPlayerNeedBlockPush = 16044,
		// Token: 0x04000C37 RID: 3127
		NewPlayerSupportSetCurUseTrialRoleRequest = 15519,
		// Token: 0x04000C38 RID: 3128
		NewPlayerSupportSetCurUseTrialRoleResponse = 22287,
		// Token: 0x04000C39 RID: 3129
		MotorFightEnterSubLevelRequest = 25986,
		// Token: 0x04000C3A RID: 3130
		MotorFightEnterSubLevelResponse = 20665,
		// Token: 0x04000C3B RID: 3131
		MotorFightKillRequest = 17673,
		// Token: 0x04000C3C RID: 3132
		MotorFightKillResponse = 25235,
		// Token: 0x04000C3D RID: 3133
		AtomicProcessAddBuffRequest = 16727,
		// Token: 0x04000C3E RID: 3134
		AtomicProcessAddBuffResponse = 19678,
		// Token: 0x04000C3F RID: 3135
		BrochureRewardRequest = 28387,
		// Token: 0x04000C40 RID: 3136
		BrochureRewardResponse = 22272,
		// Token: 0x04000C41 RID: 3137
		BookItemUpdateNotify = 26909,
		// Token: 0x04000C42 RID: 3138
		EffectiveWeekCardInfoNotify = 16179,
		// Token: 0x04000C43 RID: 3139
		WeekCardInfoRequest = 15779,
		// Token: 0x04000C44 RID: 3140
		WeekCardInfoResponse = 19836,
		// Token: 0x04000C45 RID: 3141
		WeekCardRewardRequest = 15854,
		// Token: 0x04000C46 RID: 3142
		WeekCardRewardResponse = 21630,
		// Token: 0x04000C47 RID: 3143
		SeamlessTeleportVehicleRequest = 16632,
		// Token: 0x04000C48 RID: 3144
		SeamlessTeleportVehicleResponse = 29328,
		// Token: 0x04000C49 RID: 3145
		NewPlayerSupportActivityTrialRoleUpdateNotify = 16807,
		// Token: 0x04000C4A RID: 3146
		RegressRepeatedTaskRequest = 27083,
		// Token: 0x04000C4B RID: 3147
		RegressRepeatedTaskResponse = 26458,
		// Token: 0x04000C4C RID: 3148
		MotorCreateResponse = 27756,
		// Token: 0x04000C4D RID: 3149
		MotorCreateRequest = 23555,
		// Token: 0x04000C4E RID: 3150
		MotorFightRefreshSubLevelNotify = 27381,
		// Token: 0x04000C4F RID: 3151
		RegressBuyBonusLvRequest = 16574,
		// Token: 0x04000C50 RID: 3152
		RegressBuyBonusLvResponse = 28709,
		// Token: 0x04000C51 RID: 3153
		RegressSetCurUseTrialRoleRequest = 28325,
		// Token: 0x04000C52 RID: 3154
		RegressSetCurUseTrialRoleResponse = 28925,
		// Token: 0x04000C53 RID: 3155
		H5ViewActivityDataNotify = 25838,
		// Token: 0x04000C54 RID: 3156
		H5ViewActivityReadRequest = 28203,
		// Token: 0x04000C55 RID: 3157
		H5ViewActivityReadResponse = 19853,
		// Token: 0x04000C56 RID: 3158
		PhantomBattleSkillEffectFailNotify = 23479,
		// Token: 0x04000C57 RID: 3159
		NewTowerTaskDataUpdateNotify = 23458,
		// Token: 0x04000C58 RID: 3160
		NewTowerLevelUnlockNotify = 27780,
		// Token: 0x04000C59 RID: 3161
		RoleConfigInfoNotify = 18250,
		// Token: 0x04000C5A RID: 3162
		RoleSkillBranchModifyRequest = 27456,
		// Token: 0x04000C5B RID: 3163
		RoleSkillBranchModifyResponse = 17930,
		// Token: 0x04000C5C RID: 3164
		RoleConfigInfoUpdateNotify = 24298,
		// Token: 0x04000C5D RID: 3165
		MixDrinkSettleRequest = 23581,
		// Token: 0x04000C5E RID: 3166
		MixDrinkSettleResponse = 27018,
		// Token: 0x04000C5F RID: 3167
		MixDrinkTopicSelectRequest = 17303,
		// Token: 0x04000C60 RID: 3168
		MixDrinkTopicSelectResponse = 22606,
		// Token: 0x04000C61 RID: 3169
		SceneRoadSyncNotify = 29415,
		// Token: 0x04000C62 RID: 3170
		MotorFightPlayerDeadRequest = 21022,
		// Token: 0x04000C63 RID: 3171
		MotorFightPlayerDeadResponse = 17964,
		// Token: 0x04000C64 RID: 3172
		MotorFightGameOverNotify = 24027,
		// Token: 0x04000C65 RID: 3173
		TotalTopUpActivityInfoNotify = 27743,
		// Token: 0x04000C66 RID: 3174
		TransformBuffStackNotify = 27991,
		// Token: 0x04000C67 RID: 3175
		WeatherSwitchInfoRequest = 17029,
		// Token: 0x04000C68 RID: 3176
		WeatherSwitchInfoResponse = 21840,
		// Token: 0x04000C69 RID: 3177
		RegressActivityTrialRoleUpdateNotify = 23826,
		// Token: 0x04000C6A RID: 3178
		MotorFightRefreshNextWaveGroupRequest = 18493,
		// Token: 0x04000C6B RID: 3179
		MotorFightRefreshNextWaveGroupResponse = 25991,
		// Token: 0x04000C6C RID: 3180
		MotorFightRoundInfoNotify = 18494,
		// Token: 0x04000C6D RID: 3181
		RollBlockGamePlayReadyRequest = 20611,
		// Token: 0x04000C6E RID: 3182
		RollBlockGamePlayReadyResponse = 19471,
		// Token: 0x04000C6F RID: 3183
		MotorFightBossDropNotify = 23836,
		// Token: 0x04000C70 RID: 3184
		MotorFightSelectCollectionRequest = 15634,
		// Token: 0x04000C71 RID: 3185
		MotorFightSelectCollectionResponse = 16600,
		// Token: 0x04000C72 RID: 3186
		NewTowerRoundUpdateNotify = 20449,
		// Token: 0x04000C73 RID: 3187
		EntityEnterVehicleRequest = 23956,
		// Token: 0x04000C74 RID: 3188
		EntityEnterVehicleResponse = 28752,
		// Token: 0x04000C75 RID: 3189
		RollBlockItemUpdateNotify = 23026,
		// Token: 0x04000C76 RID: 3190
		FarmGoldLevelPlayRepeatedRequest = 20085,
		// Token: 0x04000C77 RID: 3191
		FarmGoldLevelPlayRepeatedResponse = 20555,
		// Token: 0x04000C78 RID: 3192
		MotorFightSelectBuffGateRequest = 18769,
		// Token: 0x04000C79 RID: 3193
		MotorFightSelectBuffGateResponse = 20172,
		// Token: 0x04000C7A RID: 3194
		MotorFightMonsterDropNotify = 15577,
		// Token: 0x04000C7B RID: 3195
		MotorAnimReplaySampleUdpPush = 25977,
		// Token: 0x04000C7C RID: 3196
		MotorAnimReplaySampleUdpNotify = 25598,
		// Token: 0x04000C7D RID: 3197
		SpringFestivalAreaUnlockNotify = 17922,
		// Token: 0x04000C7E RID: 3198
		GivebackInfoRequest = 15161,
		// Token: 0x04000C7F RID: 3199
		GivebackInfoResponse = 29313,
		// Token: 0x04000C80 RID: 3200
		GivebackRewardRequest = 23177,
		// Token: 0x04000C81 RID: 3201
		GivebackRewardResponse = 26121,
		// Token: 0x04000C82 RID: 3202
		GivebackInfoUpdateNotify = 20857,
		// Token: 0x04000C83 RID: 3203
		FarmGoldPointRepeatedRequest = 25310,
		// Token: 0x04000C84 RID: 3204
		FarmGoldPointRepeatedResponse = 25184,
		// Token: 0x04000C85 RID: 3205
		MotorFightScoreNotify = 18508,
		// Token: 0x04000C86 RID: 3206
		RoleDevelopConfigUpdateNotify = 25367,
		// Token: 0x04000C87 RID: 3207
		MotorLockedTechUpdateNotify = 18686,
		// Token: 0x04000C88 RID: 3208
		ActionResetPosPrePerformanceNotify = 15572,
		// Token: 0x04000C89 RID: 3209
		ActionResetPosPrePerformanceEndRequest = 17446,
		// Token: 0x04000C8A RID: 3210
		ActionResetPosPrePerformanceEndResponse = 27855,
		// Token: 0x04000C8B RID: 3211
		MotorFightRefreshCollectionRequest = 22546,
		// Token: 0x04000C8C RID: 3212
		MotorFightRefreshCollectionResponse = 29219,
		// Token: 0x04000C8D RID: 3213
		MotorIsEnablePush = 28828,
		// Token: 0x04000C8E RID: 3214
		MotorFightAddBuffNotify = 27308,
		// Token: 0x04000C8F RID: 3215
		ExhibitionItemSaveRequest = 18118,
		// Token: 0x04000C90 RID: 3216
		ExhibitionItemSaveResponse = 24838,
		// Token: 0x04000C91 RID: 3217
		SpringFestivalTaskRewardRequest = 23817,
		// Token: 0x04000C92 RID: 3218
		SpringFestivalTaskRewardResponse = 24773,
		// Token: 0x04000C93 RID: 3219
		SpringFestivalScoreRewardRequest = 16898,
		// Token: 0x04000C94 RID: 3220
		SpringFestivalScoreRewardResponse = 26022,
		// Token: 0x04000C95 RID: 3221
		LevelPlayGainRewardInfoNotify = 18892,
		// Token: 0x04000C96 RID: 3222
		SpringFestivalUpdateNotify = 17951,
		// Token: 0x04000C97 RID: 3223
		SpringFestivalAtmosphereRewardRequest = 18419,
		// Token: 0x04000C98 RID: 3224
		SpringFestivalAtmosphereRewardResponse = 28012,
		// Token: 0x04000C99 RID: 3225
		EnterBigWorldInstRequest = 16410,
		// Token: 0x04000C9A RID: 3226
		EnterBigWorldInstResponse = 16135,
		// Token: 0x04000C9B RID: 3227
		PhantomMusicSaveRequest = 25322,
		// Token: 0x04000C9C RID: 3228
		PhantomMusicSaveResponse = 19149,
		// Token: 0x04000C9D RID: 3229
		PhantomMusicNotify = 16079,
		// Token: 0x04000C9E RID: 3230
		FlagChallengeTaskInfoUpdateNotify = 17747,
		// Token: 0x04000C9F RID: 3231
		FlagChallengeLevelInfoUpdateNotify = 15056,
		// Token: 0x04000CA0 RID: 3232
		FlagStrongholdInfoUpdateNotify = 23830,
		// Token: 0x04000CA1 RID: 3233
		FlagChallengePerRoleLevelNotify = 17390,
		// Token: 0x04000CA2 RID: 3234
		FlagChallengeTempRoleLevelNotify = 25219,
		// Token: 0x04000CA3 RID: 3235
		FlagChallengeInstNotify = 19288,
		// Token: 0x04000CA4 RID: 3236
		FlagChallengeRewardRequest = 21551,
		// Token: 0x04000CA5 RID: 3237
		FlagChallengeRewardResponse = 16460,
		// Token: 0x04000CA6 RID: 3238
		MotorDevelopTaskRewardRequest = 27103,
		// Token: 0x04000CA7 RID: 3239
		MotorDevelopTaskRewardResponse = 28453,
		// Token: 0x04000CA8 RID: 3240
		MotorDevelopTaskUpdateNotify = 15550,
		// Token: 0x04000CA9 RID: 3241
		VehicleFinishRequest = 18022,
		// Token: 0x04000CAA RID: 3242
		VehicleFinishResponse = 23136,
		// Token: 0x04000CAB RID: 3243
		AtomicProcessRemoveBuffRequest = 27565,
		// Token: 0x04000CAC RID: 3244
		AtomicProcessRemoveBuffResponse = 23095,
		// Token: 0x04000CAD RID: 3245
		ActivityPayShopBuyRequest = 29230,
		// Token: 0x04000CAE RID: 3246
		ActivityPayShopBuyResponse = 18847,
		// Token: 0x04000CAF RID: 3247
		SpringFestivalAtmosphereUpdateNotify = 15997,
		// Token: 0x04000CB0 RID: 3248
		FlagChallengeSettleNotify = 20618,
		// Token: 0x04000CB1 RID: 3249
		KurotatoStepUpdateNotify = 16601,
		// Token: 0x04000CB2 RID: 3250
		GivebackUnlockNotify = 21002,
		// Token: 0x04000CB3 RID: 3251
		MotorFightAddEnemyBuffNotify = 16034,
		// Token: 0x04000CB4 RID: 3252
		MotorFightRefreshCollectionTimesChangeNotify = 20476,
		// Token: 0x04000CB5 RID: 3253
		FurnitureUnlockNotify = 19142,
		// Token: 0x04000CB6 RID: 3254
		MotorFightAddCollectionNotify = 25419,
		// Token: 0x04000CB7 RID: 3255
		TetrisUpdateRequest = 15349,
		// Token: 0x04000CB8 RID: 3256
		TetrisUpdateResponse = 24555,
		// Token: 0x04000CB9 RID: 3257
		NewTrialRoleGetNightmarePhantomInstInfoRequest = 29530,
		// Token: 0x04000CBA RID: 3258
		NewTrialRoleGetNightmarePhantomInstInfoResponse = 27671,
		// Token: 0x04000CBB RID: 3259
		MotorSummonAndRidePush = 23028,
		// Token: 0x04000CBC RID: 3260
		MotorSummonAndRideNotify = 20643,
		// Token: 0x04000CBD RID: 3261
		MixDrinkRoleInviteRequest = 18883,
		// Token: 0x04000CBE RID: 3262
		MixDrinkRoleInviteResponse = 28226,
		// Token: 0x04000CBF RID: 3263
		MotorFightRankListSelfDataRequest = 19112,
		// Token: 0x04000CC0 RID: 3264
		MotorFightRankListSelfDataResponse = 27580,
		// Token: 0x04000CC1 RID: 3265
		PhBaPlanUsePlanRequest = 15249,
		// Token: 0x04000CC2 RID: 3266
		PhBaPlanUsePlanResponse = 24680,
		// Token: 0x04000CC3 RID: 3267
		PhBaPlanSaveUsePlanRequest = 27330,
		// Token: 0x04000CC4 RID: 3268
		PhBaPlanSaveUsePlanResponse = 16798,
		// Token: 0x04000CC5 RID: 3269
		PhBaPlanFindPlanRequest = 22650,
		// Token: 0x04000CC6 RID: 3270
		PhBaPlanFindPlanResponse = 27942,
		// Token: 0x04000CC7 RID: 3271
		KurotatoChestRewardNotify = 25333,
		// Token: 0x04000CC8 RID: 3272
		KurotatoChestRewardSelectRequest = 19001,
		// Token: 0x04000CC9 RID: 3273
		KurotatoChestRewardSelectResponse = 25445,
		// Token: 0x04000CCA RID: 3274
		KurotatoUpgradeRewardNotify = 18341,
		// Token: 0x04000CCB RID: 3275
		KurotatoUpgradeRewardSelectRequest = 20545,
		// Token: 0x04000CCC RID: 3276
		KurotatoUpgradeRewardSelectResponse = 21419,
		// Token: 0x04000CCD RID: 3277
		KurotatoUpgradeRewardRefreshRequest = 25898,
		// Token: 0x04000CCE RID: 3278
		KurotatoUpgradeRewardRefreshResponse = 15573,
		// Token: 0x04000CCF RID: 3279
		KurotatoShopRewardNotify = 25121,
		// Token: 0x04000CD0 RID: 3280
		KurotatoShopRewardSelectRequest = 24909,
		// Token: 0x04000CD1 RID: 3281
		KurotatoShopRewardSelectResponse = 15517,
		// Token: 0x04000CD2 RID: 3282
		KurotatoShopRewardLockRequest = 22092,
		// Token: 0x04000CD3 RID: 3283
		KurotatoShopRewardLockResponse = 16545,
		// Token: 0x04000CD4 RID: 3284
		KurotatoShopRewardRefreshRequest = 24293,
		// Token: 0x04000CD5 RID: 3285
		KurotatoShopRewardRefreshResponse = 22871,
		// Token: 0x04000CD6 RID: 3286
		MixDrinkRoleRewardRequest = 20051,
		// Token: 0x04000CD7 RID: 3287
		MixDrinkRoleRewardResponse = 17448,
		// Token: 0x04000CD8 RID: 3288
		JokerGuessRewardRequest = 24268,
		// Token: 0x04000CD9 RID: 3289
		JokerGuessRewardResponse = 22205,
		// Token: 0x04000CDA RID: 3290
		StorageInfoRequest = 25920,
		// Token: 0x04000CDB RID: 3291
		StorageInfoResponse = 20464,
		// Token: 0x04000CDC RID: 3292
		StorageInfoUpdateRequest = 21380,
		// Token: 0x04000CDD RID: 3293
		StorageInfoUpdateResponse = 15571,
		// Token: 0x04000CDE RID: 3294
		KurotatoSystemInfoNotify = 28540,
		// Token: 0x04000CDF RID: 3295
		KurotatoItemUpdateNotify = 18788,
		// Token: 0x04000CE0 RID: 3296
		ConfirmCompleteRefMp4QuestNotify = 23244,
		// Token: 0x04000CE1 RID: 3297
		FeiXuePreheatInfoUpdateNotify = 24082,
		// Token: 0x04000CE2 RID: 3298
		FeiXuePreheatInfoRewardRequest = 16511,
		// Token: 0x04000CE3 RID: 3299
		FeiXuePreheatInfoRewardResponse = 22363,
		// Token: 0x04000CE4 RID: 3300
		StorageInfoNotify = 24801,
		// Token: 0x04000CE5 RID: 3301
		RhythmChangePartnerRoleRequest = 27219,
		// Token: 0x04000CE6 RID: 3302
		RhythmChangePartnerRoleResponse = 15635,
		// Token: 0x04000CE7 RID: 3303
		RhythmRankListRequest = 25012,
		// Token: 0x04000CE8 RID: 3304
		RhythmRankListResponse = 26876,
		// Token: 0x04000CE9 RID: 3305
		RhythmRankListSelfDataRequest = 18805,
		// Token: 0x04000CEA RID: 3306
		RhythmRankListSelfDataResponse = 19090,
		// Token: 0x04000CEB RID: 3307
		RhythmSettleRequest = 23554,
		// Token: 0x04000CEC RID: 3308
		RhythmSettleResponse = 21204,
		// Token: 0x04000CED RID: 3309
		RhythmRoleUpdateNotify = 24501,
		// Token: 0x04000CEE RID: 3310
		RhythmSubLevelUpdateNotify = 23745,
		// Token: 0x04000CEF RID: 3311
		RhythmSetRedDotRequest = 20712,
		// Token: 0x04000CF0 RID: 3312
		RhythmSetRedDotResponse = 27076,
		// Token: 0x04000CF1 RID: 3313
		RhythmTaskOneKeyRewardRequest = 23309,
		// Token: 0x04000CF2 RID: 3314
		RhythmTaskOneKeyRewardResponse = 18542,
		// Token: 0x04000CF3 RID: 3315
		RhythmTaskUpdateNotify = 20813,
		// Token: 0x04000CF4 RID: 3316
		DropCatchLevelRewardRequest = 20994,
		// Token: 0x04000CF5 RID: 3317
		DropCatchLevelRewardResponse = 19373,
		// Token: 0x04000CF6 RID: 3318
		DropCatchLevelRewardUpdateNotify = 29378,
		// Token: 0x04000CF7 RID: 3319
		DropCatchLevelFinishRequest = 21819,
		// Token: 0x04000CF8 RID: 3320
		DropCatchLevelFinishResponse = 17151,
		// Token: 0x04000CF9 RID: 3321
		SplinePositionUpdateRequest = 28181,
		// Token: 0x04000CFA RID: 3322
		SplinePositionUpdateResponse = 29241,
		// Token: 0x04000CFB RID: 3323
		SplinePositionNotify = 28528,
		// Token: 0x04000CFC RID: 3324
		TimeScheduleTriggerNotify = 20242,
		// Token: 0x04000CFD RID: 3325
		MotorFightRefreshBossPush = 15231,
		// Token: 0x04000CFE RID: 3326
		KurotatoWeaponUpdateNotify = 17722,
		// Token: 0x04000CFF RID: 3327
		KurotatoEndShopStepRequest = 17398,
		// Token: 0x04000D00 RID: 3328
		KurotatoEndShopStepResponse = 27759,
		// Token: 0x04000D01 RID: 3329
		NewTowerLastCycleInfoRequest = 25259,
		// Token: 0x04000D02 RID: 3330
		NewTowerLastCycleInfoResponse = 20840,
		// Token: 0x04000D03 RID: 3331
		NewTowerSeasonRewardRequest = 20810,
		// Token: 0x04000D04 RID: 3332
		NewTowerSeasonRewardResponse = 28087,
		// Token: 0x04000D05 RID: 3333
		NewTowerSeasonTaskDataUpdateNotify = 16522,
		// Token: 0x04000D06 RID: 3334
		NewTowerRecommendRequest = 20297,
		// Token: 0x04000D07 RID: 3335
		NewTowerRecommendResponse = 15516,
		// Token: 0x04000D08 RID: 3336
		BlackScreenStatePush = 16136,
		// Token: 0x04000D09 RID: 3337
		ScheduleNpcUpdatePosRequest = 28259,
		// Token: 0x04000D0A RID: 3338
		ScheduleNpcUpdatePosResponse = 27257,
		// Token: 0x04000D0B RID: 3339
		WillSwitchSceneGroupNotify = 25350,
		// Token: 0x04000D0C RID: 3340
		KurotatoRefineWeaponRequest = 27957,
		// Token: 0x04000D0D RID: 3341
		KurotatoRefineWeaponResponse = 29507,
		// Token: 0x04000D0E RID: 3342
		RhythmShipStartNotify = 22158,
		// Token: 0x04000D0F RID: 3343
		PhBaPlanSetPlanStatusRequest = 16741,
		// Token: 0x04000D10 RID: 3344
		PhBaPlanSetPlanStatusResponse = 16878,
		// Token: 0x04000D11 RID: 3345
		PhBaPlanUpdatePlanRequest = 28006,
		// Token: 0x04000D12 RID: 3346
		PhBaPlanUpdatePlanResponse = 29442,
		// Token: 0x04000D13 RID: 3347
		FlagChallengeBoxExpNotify = 15006,
		// Token: 0x04000D14 RID: 3348
		PhBaPlanSetFiveStarSwitchRequest = 25722,
		// Token: 0x04000D15 RID: 3349
		PhBaPlanSetFiveStarSwitchResponse = 16406,
		// Token: 0x04000D16 RID: 3350
		NewTowerSeasonScoreRewardRequest = 26749,
		// Token: 0x04000D17 RID: 3351
		NewTowerSeasonScoreRewardResponse = 15733,
		// Token: 0x04000D18 RID: 3352
		MotorCycleCruiseStatePush = 28153,
		// Token: 0x04000D19 RID: 3353
		ConsumptiveTotalScoreNotify = 18727,
		// Token: 0x04000D1A RID: 3354
		EnterAreaNotify = 29588,
		// Token: 0x04000D1B RID: 3355
		RecallInfoNotify = 18029,
		// Token: 0x04000D1C RID: 3356
		StartRecallRequest = 20244,
		// Token: 0x04000D1D RID: 3357
		StartRecallResponse = 23357,
		// Token: 0x04000D1E RID: 3358
		EntityDressOrnamentChangeNotify = 19511,
		// Token: 0x04000D1F RID: 3359
		OrnamentInfoNotify = 27306,
		// Token: 0x04000D20 RID: 3360
		OrnamentUnlockNotify = 22041,
		// Token: 0x04000D21 RID: 3361
		OrnamentDressInfoUpdateNotify = 21795,
		// Token: 0x04000D22 RID: 3362
		ChangeOrnamentRequest = 27956,
		// Token: 0x04000D23 RID: 3363
		ChangeOrnamentResponse = 19523,
		// Token: 0x04000D24 RID: 3364
		SimpleCombatEntityAttributeUpdateNotify = 16764,
		// Token: 0x04000D25 RID: 3365
		DropCatchInfoRequest = 21559,
		// Token: 0x04000D26 RID: 3366
		DropCatchInfoResponse = 26922,
		// Token: 0x04000D27 RID: 3367
		AvoidBlockSubmitOverNodeRequest = 16244,
		// Token: 0x04000D28 RID: 3368
		AvoidBlockSubmitOverNodeResponse = 23361,
		// Token: 0x04000D29 RID: 3369
		AvoidBlockSettlementNotify = 23738,
		// Token: 0x04000D2A RID: 3370
		AvoidBlockRoundInfoNotify = 16725,
		// Token: 0x04000D2B RID: 3371
		KurotatoSellWeaponRequest = 26554,
		// Token: 0x04000D2C RID: 3372
		KurotatoSellWeaponResponse = 21719,
		// Token: 0x04000D2D RID: 3373
		CompleteMarkNotify = 27290,
		// Token: 0x04000D2E RID: 3374
		TetrisFinishRequest = 18718,
		// Token: 0x04000D2F RID: 3375
		TetrisFinishResponse = 27836,
		// Token: 0x04000D30 RID: 3376
		RacingBetsCloseSettleMenuRequest = 16577,
		// Token: 0x04000D31 RID: 3377
		RacingBetsCloseSettleMenuResponse = 22872,
		// Token: 0x04000D32 RID: 3378
		FlagChallengeUnlockTeleporterNotify = 28693,
		// Token: 0x04000D33 RID: 3379
		PlayerXboxInfoGetRequest = 21683,
		// Token: 0x04000D34 RID: 3380
		PlayerXboxInfoGetResponse = 27026,
		// Token: 0x04000D35 RID: 3381
		PlayerCreateXboxSessionRequest = 27825,
		// Token: 0x04000D36 RID: 3382
		PlayerCreateXboxSessionResponse = 17732,
		// Token: 0x04000D37 RID: 3383
		PlayerXboxSessionNotify = 27434,
		// Token: 0x04000D38 RID: 3384
		PlayerXboxBlockListRequest = 28660,
		// Token: 0x04000D39 RID: 3385
		PlayerXboxBlockListResponse = 24484,
		// Token: 0x04000D3A RID: 3386
		XboxSettingUpdateRequest = 20700,
		// Token: 0x04000D3B RID: 3387
		XboxSettingUpdateResponse = 25251,
		// Token: 0x04000D3C RID: 3388
		XboxSettingRequest = 21284,
		// Token: 0x04000D3D RID: 3389
		XboxSettingResponse = 23818,
		// Token: 0x04000D3E RID: 3390
		PinballTeamReviveRequest = 29847,
		// Token: 0x04000D3F RID: 3391
		PinballTeamReviveResponse = 17085,
		// Token: 0x04000D40 RID: 3392
		PinballSetPayloadRequest = 29166,
		// Token: 0x04000D41 RID: 3393
		PinballSetPayloadResponse = 24616,
		// Token: 0x04000D42 RID: 3394
		PinballSettleNotify = 19382,
		// Token: 0x04000D43 RID: 3395
		RoleSkillQuickLevelUpRequest = 29779,
		// Token: 0x04000D44 RID: 3396
		RoleSkillQuickLevelUpResponse = 18822,
		// Token: 0x04000D45 RID: 3397
		GaSwitchCommonEnemyProCampRequest = 17625,
		// Token: 0x04000D46 RID: 3398
		GaSwitchCommonEnemyProCampResponse = 23547,
		// Token: 0x04000D47 RID: 3399
		PinballTeamDieRequest = 24584,
		// Token: 0x04000D48 RID: 3400
		PinballTeamDieResponse = 24554,
		// Token: 0x04000D49 RID: 3401
		PinballQuitRequest = 28824,
		// Token: 0x04000D4A RID: 3402
		PinballQuitResponse = 17521,
		// Token: 0x04000D4B RID: 3403
		PinballBonusFullWinRequest = 23910,
		// Token: 0x04000D4C RID: 3404
		PinballBonusFullWinResponse = 22647,
		// Token: 0x04000D4D RID: 3405
		PinballInGameStateChangeNotify = 27614,
		// Token: 0x04000D4E RID: 3406
		PinballInGameSyncPayloadRequest = 21563,
		// Token: 0x04000D4F RID: 3407
		PinballInGameSyncPayloadResponse = 19461,
		// Token: 0x04000D50 RID: 3408
		KurotatoPropertyUpdateNotify = 15776,
		// Token: 0x04000D51 RID: 3409
		PinballTaskRewardRequest = 19362,
		// Token: 0x04000D52 RID: 3410
		PinballTaskRewardResponse = 20552,
		// Token: 0x04000D53 RID: 3411
		PinballRoleLevelUpRequest = 17691,
		// Token: 0x04000D54 RID: 3412
		PinballRoleLevelUpResponse = 28040,
		// Token: 0x04000D55 RID: 3413
		PinballWeaponDegradeRequest = 24517,
		// Token: 0x04000D56 RID: 3414
		PinballWeaponDegradeResponse = 16001,
		// Token: 0x04000D57 RID: 3415
		PinballWeaponWearRequest = 26957,
		// Token: 0x04000D58 RID: 3416
		PinballWeaponWearResponse = 25098,
		// Token: 0x04000D59 RID: 3417
		PinballFriendRankRequest = 15366,
		// Token: 0x04000D5A RID: 3418
		PinballFriendRankResponse = 24014,
		// Token: 0x04000D5B RID: 3419
		PinballUpdateNotify = 26492,
		// Token: 0x04000D5C RID: 3420
		BulletPatternPush = 27859,
		// Token: 0x04000D5D RID: 3421
		BulletPatternNotify = 29108,
		// Token: 0x04000D5E RID: 3422
		BeamReceiveNotify = 18439,
		// Token: 0x04000D5F RID: 3423
		InfrV2InfoRequest = 21305,
		// Token: 0x04000D60 RID: 3424
		InfrV2InfoResponse = 17321,
		// Token: 0x04000D61 RID: 3425
		InfrV2LevelUpRequest = 20713,
		// Token: 0x04000D62 RID: 3426
		InfrV2LevelUpResponse = 26991,
		// Token: 0x04000D63 RID: 3427
		InfrV2TreeBuildRequest = 21969,
		// Token: 0x04000D64 RID: 3428
		InfrV2TreeBuildResponse = 28890,
		// Token: 0x04000D65 RID: 3429
		InfrV2TreeUpdateNotify = 17953,
		// Token: 0x04000D66 RID: 3430
		InfrV2ManualSwitchTraceTreeRequest = 27880,
		// Token: 0x04000D67 RID: 3431
		InfrV2ManualSwitchTraceTreeResponse = 28071,
		// Token: 0x04000D68 RID: 3432
		InfrV2ManualCancelTraceTreeRequest = 16247,
		// Token: 0x04000D69 RID: 3433
		InfrV2ManualCancelTraceTreeResponse = 28628,
		// Token: 0x04000D6A RID: 3434
		RogueInstExtraInfoRequest = 25243,
		// Token: 0x04000D6B RID: 3435
		RogueInstExtraInfoResponse = 29662,
		// Token: 0x04000D6C RID: 3436
		RogueInstExtraInfoUpdateNotify = 25441,
		// Token: 0x04000D6D RID: 3437
		InfrV2FireUpdateNotify = 26200,
		// Token: 0x04000D6E RID: 3438
		InfrV2TaskDataUpdateNotify = 21917,
		// Token: 0x04000D6F RID: 3439
		InfrV2ScoreRewardRequest = 17050,
		// Token: 0x04000D70 RID: 3440
		InfrV2ScoreRewardResponse = 23928,
		// Token: 0x04000D71 RID: 3441
		InfrV2TaskRewardRequest = 24745,
		// Token: 0x04000D72 RID: 3442
		InfrV2TaskRewardResponse = 26303,
		// Token: 0x04000D73 RID: 3443
		RhythmMainLineInfoRequest = 17337,
		// Token: 0x04000D74 RID: 3444
		RhythmMainLineInfoResponse = 25817,
		// Token: 0x04000D75 RID: 3445
		ThemePersonalScoreRequest = 25800,
		// Token: 0x04000D76 RID: 3446
		ThemePersonalScoreResponse = 17773,
		// Token: 0x04000D77 RID: 3447
		ThemeWorldScoreRequest = 27613,
		// Token: 0x04000D78 RID: 3448
		ThemeWorldScoreResponse = 15587,
		// Token: 0x04000D79 RID: 3449
		WuWuTaskUpdateNotify = 16006,
		// Token: 0x04000D7A RID: 3450
		WuWuTaskRewardRequest = 17363,
		// Token: 0x04000D7B RID: 3451
		WuWuTaskRewardResponse = 29886,
		// Token: 0x04000D7C RID: 3452
		ThemeCeleWuWuTaskNotify = 15267,
		// Token: 0x04000D7D RID: 3453
		BossPilingTaskInfoUpdateNotify = 29797,
		// Token: 0x04000D7E RID: 3454
		BossPilingLevelInfoUpdateNotify = 19428,
		// Token: 0x04000D7F RID: 3455
		BossPilingInstNotify = 15085,
		// Token: 0x04000D80 RID: 3456
		BossPilingBuffUpdateNotify = 23086,
		// Token: 0x04000D81 RID: 3457
		BossPilingSettleNotify = 21250,
		// Token: 0x04000D82 RID: 3458
		BossPilingRewardRequest = 17008,
		// Token: 0x04000D83 RID: 3459
		BossPilingRewardResponse = 25013,
		// Token: 0x04000D84 RID: 3460
		PhBaPlanBatchOperRequest = 28530,
		// Token: 0x04000D85 RID: 3461
		PhBaPlanBatchOperResponse = 25404,
		// Token: 0x04000D86 RID: 3462
		MotorOutlookCreatePresetRequest = 21586,
		// Token: 0x04000D87 RID: 3463
		MotorOutlookCreatePresetResponse = 17753,
		// Token: 0x04000D88 RID: 3464
		MotorOutlookDeletePresetRequest = 27258,
		// Token: 0x04000D89 RID: 3465
		MotorOutlookDeletePresetResponse = 28770,
		// Token: 0x04000D8A RID: 3466
		MotorOutlookEditPresetRequest = 22163,
		// Token: 0x04000D8B RID: 3467
		MotorOutlookEditPresetResponse = 24760,
		// Token: 0x04000D8C RID: 3468
		FlowerPollutionRequest = 21028,
		// Token: 0x04000D8D RID: 3469
		FlowerPollutionResponse = 26670,
		// Token: 0x04000D8E RID: 3470
		MotorDecalTaskRequest = 17422,
		// Token: 0x04000D8F RID: 3471
		MotorDecalTaskResponse = 26679,
		// Token: 0x04000D90 RID: 3472
		MotorDecalUpdateNotify = 26984,
		// Token: 0x04000D91 RID: 3473
		FlowerPollutionSplinePush = 21867,
		// Token: 0x04000D92 RID: 3474
		MotorDecalMotorIpRequest = 16237,
		// Token: 0x04000D93 RID: 3475
		MotorDecalMotorIpResponse = 24987,
		// Token: 0x04000D94 RID: 3476
		MotorOutlookFullChangeNotify = 24893,
		// Token: 0x04000D95 RID: 3477
		BossPilingSettleRequest = 17839,
		// Token: 0x04000D96 RID: 3478
		BossPilingSettleResponse = 26669,
		// Token: 0x04000D97 RID: 3479
		PinballInGameStarChangeNotify = 24193,
		// Token: 0x04000D98 RID: 3480
		FsmMontageDurationNotify = 20087,
		// Token: 0x04000D99 RID: 3481
		RacingBetsRepeatedTaskRewardRequest = 28433,
		// Token: 0x04000D9A RID: 3482
		RacingBetsRepeatedTaskRewardResponse = 15170,
		// Token: 0x04000D9B RID: 3483
		LinkageCheckInRewardRequest = 25948,
		// Token: 0x04000D9C RID: 3484
		LinkageCheckInRewardResponse = 16096,
		// Token: 0x04000D9D RID: 3485
		GolemCrackUpdateRequest = 29338,
		// Token: 0x04000D9E RID: 3486
		GolemCrackUpdateResponse = 16269,
		// Token: 0x04000D9F RID: 3487
		QuickHackRamVerifyPush = 25141,
		// Token: 0x04000DA0 RID: 3488
		QuestBranchRequest = 29163,
		// Token: 0x04000DA1 RID: 3489
		QuestBranchResponse = 24229,
		// Token: 0x04000DA2 RID: 3490
		QuestBranchSelectRequest = 20377,
		// Token: 0x04000DA3 RID: 3491
		QuestBranchSelectResponse = 16841,
		// Token: 0x04000DA4 RID: 3492
		QuestBranchUpdateNotify = 15721,
		// Token: 0x04000DA5 RID: 3493
		RoleGiftRewardRequest = 26345,
		// Token: 0x04000DA6 RID: 3494
		RoleGiftRewardResponse = 20539,
		// Token: 0x04000DA7 RID: 3495
		NewTowerSeasonTaskDataUpdateRequest = 16526,
		// Token: 0x04000DA8 RID: 3496
		NewTowerSeasonTaskDataUpdateResponse = 17355,
		// Token: 0x04000DA9 RID: 3497
		WuWuPackageRewardRequest = 29680,
		// Token: 0x04000DAA RID: 3498
		WuWuPackageRewardResponse = 20803,
		// Token: 0x04000DAB RID: 3499
		MotorPositionStatePush = 22169,
		// Token: 0x04000DAC RID: 3500
		MotorPositionStateNotify = 24502,
		// Token: 0x04000DAD RID: 3501
		PinballInGameKickBallRequest = 25787,
		// Token: 0x04000DAE RID: 3502
		PinballInGameKickBallResponse = 26970,
		// Token: 0x04000DAF RID: 3503
		GachaAccumulateInfoRequest = 22393,
		// Token: 0x04000DB0 RID: 3504
		GachaAccumulateInfoResponse = 20853,
		// Token: 0x04000DB1 RID: 3505
		GachaAccumulateInfoNotify = 19571,
		// Token: 0x04000DB2 RID: 3506
		GachaAccumulateRewardRequest = 29657,
		// Token: 0x04000DB3 RID: 3507
		GachaAccumulateRewardResponse = 19810,
		// Token: 0x04000DB4 RID: 3508
		PlayerEnterPollutionRequest = 16885,
		// Token: 0x04000DB5 RID: 3509
		PlayerEnterPollutionResponse = 29461,
		// Token: 0x04000DB6 RID: 3510
		InfrV2TreeFinishCondUpdateNotify = 18202,
		// Token: 0x04000DB7 RID: 3511
		QuickHackSkillRequest = 25674,
		// Token: 0x04000DB8 RID: 3512
		QuickHackSkillResponse = 25512,
		// Token: 0x04000DB9 RID: 3513
		EdgeRunnerFunctionPreUnlockRequest = 19702,
		// Token: 0x04000DBA RID: 3514
		EdgeRunnerFunctionPreUnlockResponse = 22129,
		// Token: 0x04000DBB RID: 3515
		EdgeRunnerScoreRewardRequest = 17999,
		// Token: 0x04000DBC RID: 3516
		EdgeRunnerScoreRewardResponse = 27370,
		// Token: 0x04000DBD RID: 3517
		EdgeRunnerUpdateNotify = 20220,
		// Token: 0x04000DBE RID: 3518
		EdgeRunnerTaskRewardRequest = 24142,
		// Token: 0x04000DBF RID: 3519
		EdgeRunnerTaskRewardResponse = 22840,
		// Token: 0x04000DC0 RID: 3520
		KurotatoLevelDataUpdateNotify = 19312,
		// Token: 0x04000DC1 RID: 3521
		KurotatoRoleUnlockNotify = 18201,
		// Token: 0x04000DC2 RID: 3522
		KurotatoWeaponUnlockNotify = 19005,
		// Token: 0x04000DC3 RID: 3523
		KurotatoItemUnlockNotify = 18731,
		// Token: 0x04000DC4 RID: 3524
		KurotatoScoreTaskReceiveRequest = 23998,
		// Token: 0x04000DC5 RID: 3525
		KurotatoScoreTaskReceiveResponse = 25285,
		// Token: 0x04000DC6 RID: 3526
		KurotatoResTaskUpdateNotify = 26283,
		// Token: 0x04000DC7 RID: 3527
		KurotatoResTaskReceiveRequest = 26341,
		// Token: 0x04000DC8 RID: 3528
		KurotatoResTaskReceiveResponse = 26068,
		// Token: 0x04000DC9 RID: 3529
		KurotatoLimitTaskUpdateNotify = 20647,
		// Token: 0x04000DCA RID: 3530
		KurotatoLimitTaskReceiveRequest = 29669,
		// Token: 0x04000DCB RID: 3531
		KurotatoLimitTaskReceiveResponse = 18530,
		// Token: 0x04000DCC RID: 3532
		KurotatoRoleRecordRequest = 24358,
		// Token: 0x04000DCD RID: 3533
		KurotatoRoleRecordResponse = 25139,
		// Token: 0x04000DCE RID: 3534
		PinballUpdateWaveNotify = 27589,
		// Token: 0x04000DCF RID: 3535
		WeeklyFrameworkInfoRequest = 16625,
		// Token: 0x04000DD0 RID: 3536
		WeeklyFrameworkInfoResponse = 19130,
		// Token: 0x04000DD1 RID: 3537
		WeeklyFrameworkInfoUpdateNotify = 27476,
		// Token: 0x04000DD2 RID: 3538
		WeeklyFrameworkScoreRewardRequest = 28000,
		// Token: 0x04000DD3 RID: 3539
		WeeklyFrameworkScoreRewardResponse = 28631,
		// Token: 0x04000DD4 RID: 3540
		FloroRanchWeeklyRequest = 23105,
		// Token: 0x04000DD5 RID: 3541
		FloroRanchWeeklyResponse = 15313,
		// Token: 0x04000DD6 RID: 3542
		DollGrabRequest = 17423,
		// Token: 0x04000DD7 RID: 3543
		DollGrabResponse = 18423,
		// Token: 0x04000DD8 RID: 3544
		DollGrabTimeBallRequest = 15115,
		// Token: 0x04000DD9 RID: 3545
		DollGrabTimeBallResponse = 24886,
		// Token: 0x04000DDA RID: 3546
		DollGarbStartRequest = 16837,
		// Token: 0x04000DDB RID: 3547
		DollGarbStartResponse = 18927,
		// Token: 0x04000DDC RID: 3548
		KurotatoSettlementNotify = 15404,
		// Token: 0x04000DDD RID: 3549
		KurotatoSyncEntityDealDamagePush = 26756,
		// Token: 0x04000DDE RID: 3550
		AvoidBlockClientInitDoneRequest = 24150,
		// Token: 0x04000DDF RID: 3551
		AvoidBlockClientInitDoneResponse = 24499,
		// Token: 0x04000DE0 RID: 3552
		EdgeRunnerLordGymLevelPlayResultNotify = 25758,
		// Token: 0x04000DE1 RID: 3553
		MotorOnlineProgressReportPush = 15835,
		// Token: 0x04000DE2 RID: 3554
		MotorOnlineRankSnapshotNotify = 28537,
		// Token: 0x04000DE3 RID: 3555
		FloroRanchPlayWeeklyNotify = 27695,
		// Token: 0x04000DE4 RID: 3556
		StorageInfoUpdateNotify = 23161,
		// Token: 0x04000DE5 RID: 3557
		QuickHackOpenPush = 16504,
		// Token: 0x04000DE6 RID: 3558
		ConsumptiveActivityScoreRequest = 27461,
		// Token: 0x04000DE7 RID: 3559
		ConsumptiveActivityScoreResponse = 15172,
		// Token: 0x04000DE8 RID: 3560
		MonsterPatrolPointReachedRequest = 27527,
		// Token: 0x04000DE9 RID: 3561
		MonsterPatrolPointReachedResponse = 23552,
		// Token: 0x04000DEA RID: 3562
		KurotatoRoleRecordNotify = 18134,
		// Token: 0x04000DEB RID: 3563
		ClientPullResourcePackageRequest = 26961,
		// Token: 0x04000DEC RID: 3564
		ClientPullResourcePackageResponse = 26304,
		// Token: 0x04000DED RID: 3565
		NewHandInItemRequest = 24640,
		// Token: 0x04000DEE RID: 3566
		NewHandInItemResponse = 23562,
		// Token: 0x04000DEF RID: 3567
		DollDeliveryRequest = 22224,
		// Token: 0x04000DF0 RID: 3568
		DollDeliveryResponse = 22869,
		// Token: 0x04000DF1 RID: 3569
		OnlineMotorActivityLevelRequest = 15684,
		// Token: 0x04000DF2 RID: 3570
		OnlineMotorActivityLevelResponse = 22472,
		// Token: 0x04000DF3 RID: 3571
		OnlineMotorSettleNotify = 22637,
		// Token: 0x04000DF4 RID: 3572
		OnlineMotorUpdateNotify = 18930,
		// Token: 0x04000DF5 RID: 3573
		PlayerVoiceLanguageRequest = 29926,
		// Token: 0x04000DF6 RID: 3574
		PlayerVoiceLanguageResponse = 17604,
		// Token: 0x04000DF7 RID: 3575
		PlayerRoleVoiceSetRequest = 20371,
		// Token: 0x04000DF8 RID: 3576
		PlayerRoleVoiceSetResponse = 15331,
		// Token: 0x04000DF9 RID: 3577
		PinballStartNotify = 20511,
		// Token: 0x04000DFA RID: 3578
		FloroRanchEventChoiceRequest = 24306,
		// Token: 0x04000DFB RID: 3579
		FloroRanchEventChoiceResponse = 21742,
		// Token: 0x04000DFC RID: 3580
		DollDeliveryNotify = 22651,
		// Token: 0x04000DFD RID: 3581
		PinballFixSpawnFinishNotify = 16738,
		// Token: 0x04000DFE RID: 3582
		EdgeRunnerPreUnlockAvailableNotify = 24277,
		// Token: 0x04000DFF RID: 3583
		InfrV2InfoNotify = 26813,
		// Token: 0x04000E00 RID: 3584
		KurotatoSettlementRequest = 18635,
		// Token: 0x04000E01 RID: 3585
		KurotatoSettlementResponse = 21645,
		// Token: 0x04000E02 RID: 3586
		RemovePreloadFlowsNotify = 19296,
		// Token: 0x04000E03 RID: 3587
		PinballSpawnFirstFinishNotify = 23508,
		// Token: 0x04000E04 RID: 3588
		RemoteBatchCollectRequest = 22702,
		// Token: 0x04000E05 RID: 3589
		RemoteBatchCollectResponse = 24465,
		// Token: 0x04000E06 RID: 3590
		FloroRanchPlayWeeklyEndNotify = 26360,
		// Token: 0x04000E07 RID: 3591
		BatchMaterialReplaceRequest = 23293,
		// Token: 0x04000E08 RID: 3592
		BatchMaterialReplaceResponse = 27844,
		// Token: 0x04000E09 RID: 3593
		KurotatoDieNotify = 19556,
		// Token: 0x04000E0A RID: 3594
		MotorOnlineRankRuleIdsNotify = 28493,
		// Token: 0x04000E0B RID: 3595
		OnlineMotorStartNotify = 18191,
		// Token: 0x04000E0C RID: 3596
		NewPlayerSupportSetCurUseTrialRoleV2Request = 25773,
		// Token: 0x04000E0D RID: 3597
		NewPlayerSupportSetCurUseTrialRoleV2Response = 28224,
		// Token: 0x04000E0E RID: 3598
		NewPlayerSupportActivityTrialRoleUpdateV2Notify = 24111,
		// Token: 0x04000E0F RID: 3599
		OnlineMotorEndNotify = 21868,
		// Token: 0x04000E10 RID: 3600
		ChangeSummonEntityStateRequest = 26759,
		// Token: 0x04000E11 RID: 3601
		ChangeSummonEntityStateResponse = 21132,
		// Token: 0x04000E12 RID: 3602
		NewPlayerSupportTrialRoleLvUpV2Request = 24861,
		// Token: 0x04000E13 RID: 3603
		NewPlayerSupportTrialRoleLvUpV2Response = 18194,
		// Token: 0x04000E14 RID: 3604
		NewPlayerSupportV2GachaRoleUpdateNotify = 25759,
		// Token: 0x04000E15 RID: 3605
		RealmBetweenInfoUpdateNotify = 27851,
		// Token: 0x04000E16 RID: 3606
		RealmBetweenFullRewardRequest = 27929,
		// Token: 0x04000E17 RID: 3607
		RealmBetweenFullRewardResponse = 17101,
		// Token: 0x04000E18 RID: 3608
		RealmBetweenLevelUpRequest = 24178,
		// Token: 0x04000E19 RID: 3609
		RealmBetweenLevelUpResponse = 15881,
		// Token: 0x04000E1A RID: 3610
		RealmBetweenTaskRewardRequest = 26496,
		// Token: 0x04000E1B RID: 3611
		RealmBetweenTaskRewardResponse = 27072,
		// Token: 0x04000E1C RID: 3612
		RealmBetweenMotorRewardRequest = 22394,
		// Token: 0x04000E1D RID: 3613
		RealmBetweenMotorRewardResponse = 16795,
		// Token: 0x04000E1E RID: 3614
		RogueArchiveListRequest = 29771,
		// Token: 0x04000E1F RID: 3615
		RogueArchiveListResponse = 21294,
		// Token: 0x04000E20 RID: 3616
		RogueArchiveSaveRequest = 25782,
		// Token: 0x04000E21 RID: 3617
		RogueArchiveSaveResponse = 27259,
		// Token: 0x04000E22 RID: 3618
		RogueTowerTrialStartRequest = 21807,
		// Token: 0x04000E23 RID: 3619
		RogueTowerTrialStartResponse = 24439,
		// Token: 0x04000E24 RID: 3620
		RogueTowerTrialSelectBossRequest = 15164,
		// Token: 0x04000E25 RID: 3621
		RogueTowerTrialSelectBossResponse = 22338,
		// Token: 0x04000E26 RID: 3622
		RogueTowerTrialReChallengeNotify = 15826,
		// Token: 0x04000E27 RID: 3623
		RogueTowerTrialReChallengeRequest = 23366,
		// Token: 0x04000E28 RID: 3624
		RogueTowerTrialReChallengeResponse = 26407,
		// Token: 0x04000E29 RID: 3625
		RogueTowerTrialResultNotify = 18837,
		// Token: 0x04000E2A RID: 3626
		RogueTowerTrialResultRequest = 17805,
		// Token: 0x04000E2B RID: 3627
		RogueTowerTrialResultResponse = 15310,
		// Token: 0x04000E2C RID: 3628
		RogueTowerTrialSelectBossNotify = 19931,
		// Token: 0x04000E2D RID: 3629
		SheriffZoneInfoRequest = 17467,
		// Token: 0x04000E2E RID: 3630
		SheriffZoneInfoResponse = 25267,
		// Token: 0x04000E2F RID: 3631
		SheriffAnomalyInfoUpdateNotify = 20999,
		// Token: 0x04000E30 RID: 3632
		SheriffCriminalUpdateNotify = 22065,
		// Token: 0x04000E31 RID: 3633
		DodgeInfoPush = 29777,
		// Token: 0x04000E32 RID: 3634
		KurotatoEndSpecialWaveCombatRequest = 24724,
		// Token: 0x04000E33 RID: 3635
		KurotatoEndSpecialWaveCombatResponse = 15668,
		// Token: 0x04000E34 RID: 3636
		BabelTowerShowNameRequest = 24234,
		// Token: 0x04000E35 RID: 3637
		BabelTowerShowNameResponse = 20786,
		// Token: 0x04000E36 RID: 3638
		BabelTowerRankListRequest = 16651,
		// Token: 0x04000E37 RID: 3639
		BabelTowerRankListResponse = 21141,
		// Token: 0x04000E38 RID: 3640
		BabelTowerSelfPassRequest = 21395,
		// Token: 0x04000E39 RID: 3641
		BabelTowerSelfPassResponse = 21358,
		// Token: 0x04000E3A RID: 3642
		DollGrabStopRequest = 17493,
		// Token: 0x04000E3B RID: 3643
		DollGrabStopResponse = 15359,
		// Token: 0x04000E3C RID: 3644
		RogueTowerTrialGiveUpTempArchiveRequest = 21241,
		// Token: 0x04000E3D RID: 3645
		RogueTowerTrialGiveUpTempArchiveResponse = 29294,
		// Token: 0x04000E3E RID: 3646
		MiniWriteLetterSaveContentRequest = 25919,
		// Token: 0x04000E3F RID: 3647
		MiniWriteLetterSaveContentResponse = 23170,
		// Token: 0x04000E40 RID: 3648
		MiniWriteLetterLoginNotify = 26135,
		// Token: 0x04000E41 RID: 3649
		SignActivityFreeDropRequest = 29512,
		// Token: 0x04000E42 RID: 3650
		SignActivityFreeDropResponse = 27652,
		// Token: 0x04000E43 RID: 3651
		KurotatoReChallengeRequest = 22515,
		// Token: 0x04000E44 RID: 3652
		KurotatoReChallengeResponse = 16458,
		// Token: 0x04000E45 RID: 3653
		TimeScheduleIdleNotify = 25662,
		// Token: 0x04000E46 RID: 3654
		DollGrabPauseStartRequest = 19546,
		// Token: 0x04000E47 RID: 3655
		DollGrabPauseStartResponse = 24478,
		// Token: 0x04000E48 RID: 3656
		DollGrabPauseEndRequest = 23827,
		// Token: 0x04000E49 RID: 3657
		DollGrabPauseEndResponse = 29848,
		// Token: 0x04000E4A RID: 3658
		GachaDiscountNotify = 26843,
		// Token: 0x04000E4B RID: 3659
		KurotatoRefineWeaponNotify = 23546,
		// Token: 0x04000E4C RID: 3660
		RecallQuestListNotify = 25593,
		// Token: 0x04000E4D RID: 3661
		TraceRecallQuestNotify = 19408,
		// Token: 0x04000E4E RID: 3662
		TraceRecallQuestRequest = 28149,
		// Token: 0x04000E4F RID: 3663
		TraceRecallQuestResponse = 27297,
		// Token: 0x04000E50 RID: 3664
		RecallQuestChangeTraceNotify = 24980,
		// Token: 0x04000E51 RID: 3665
		RecallQuestFinishActionRequest = 27112,
		// Token: 0x04000E52 RID: 3666
		RecallQuestFinishActionResponse = 28795,
		// Token: 0x04000E53 RID: 3667
		RecallQuestActionRequest = 18918,
		// Token: 0x04000E54 RID: 3668
		RecallQuestActionResponse = 25218,
		// Token: 0x04000E55 RID: 3669
		RecallQuestNpcMoveOverRequest = 22658,
		// Token: 0x04000E56 RID: 3670
		RecallQuestNpcMoveOverResponse = 18418,
		// Token: 0x04000E57 RID: 3671
		RecallQuestRollBackEndNotify = 23374,
		// Token: 0x04000E58 RID: 3672
		RecallQuestStatusUpdateNotify = 20791,
		// Token: 0x04000E59 RID: 3673
		RecallQuestFinishActionEndRequest = 16583,
		// Token: 0x04000E5A RID: 3674
		RecallQuestFinishListNotify = 16834,
		// Token: 0x04000E5B RID: 3675
		DestroyRecallQuestsNotify = 24930,
		// Token: 0x04000E5C RID: 3676
		NewbieAdventureTaskRewardRequest = 17476,
		// Token: 0x04000E5D RID: 3677
		NewbieAdventureTaskRewardResponse = 20663,
		// Token: 0x04000E5E RID: 3678
		NewbieAdventureChapterDropRequest = 21108,
		// Token: 0x04000E5F RID: 3679
		NewbieAdventureChapterDropResponse = 20800,
		// Token: 0x04000E60 RID: 3680
		NewbieAdventureRoleRewardRequest = 24679,
		// Token: 0x04000E61 RID: 3681
		NewbieAdventureRoleRewardResponse = 25004,
		// Token: 0x04000E62 RID: 3682
		NewbieAdventureTaskUpdateNotify = 22437,
		// Token: 0x04000E63 RID: 3683
		NewbieCourseV2RewardNotify = 23862,
		// Token: 0x04000E64 RID: 3684
		NewbieCourseV2RewardRequest = 16575,
		// Token: 0x04000E65 RID: 3685
		NewbieCourseV2RewardResponse = 21399,
		// Token: 0x04000E66 RID: 3686
		NewbieFetchScoreRewardRequest = 26025,
		// Token: 0x04000E67 RID: 3687
		NewbieFetchScoreRewardResponse = 22454,
		// Token: 0x04000E68 RID: 3688
		NewbieMainTaskUpdateNotify = 29029,
		// Token: 0x04000E69 RID: 3689
		RecallQuestFinishActionEndResponse = 22532,
		// Token: 0x04000E6A RID: 3690
		FloroRanchOutRequest = 26316,
		// Token: 0x04000E6B RID: 3691
		FloroRanchOutResponse = 21325,
		// Token: 0x04000E6C RID: 3692
		RecallQuestGiveUpNotify = 22166,
		// Token: 0x04000E6D RID: 3693
		RecallQuestReadyForGiveUpRequest = 19845,
		// Token: 0x04000E6E RID: 3694
		RecallQuestReadyForGiveUpResponse = 19174,
		// Token: 0x04000E6F RID: 3695
		ResonantChainOptionalLimitRequest = 18010,
		// Token: 0x04000E70 RID: 3696
		ResonantChainOptionalLimitResponse = 22963,
		// Token: 0x04000E71 RID: 3697
		RecallItemBagDeltaNotify = 16700,
		// Token: 0x04000E72 RID: 3698
		QueryRecallItemBagRequest = 26265,
		// Token: 0x04000E73 RID: 3699
		QueryRecallItemBagResponse = 22846,
		// Token: 0x04000E74 RID: 3700
		ActivityRecommendNotify = 18576,
		// Token: 0x04000E75 RID: 3701
		SetClientGlobalVarRequest = 28443,
		// Token: 0x04000E76 RID: 3702
		SetClientGlobalVarResponse = 22056,
		// Token: 0x04000E77 RID: 3703
		RecallItemBagRemoveNotify = 16328,
		// Token: 0x04000E78 RID: 3704
		RoleTrialSceneRollbackPush = 15207,
		// Token: 0x04000E79 RID: 3705
		NewTowerMonsterHpInfoNotify = 27762,
		// Token: 0x04000E7A RID: 3706
		LordGymGroupInfoUpdateNotify = 23018,
		// Token: 0x04000E7B RID: 3707
		DollGarbInsertCoinRequest = 22346,
		// Token: 0x04000E7C RID: 3708
		DollGarbInsertCoinResponse = 17171,
		// Token: 0x04000E7D RID: 3709
		KurotatoAllItemUpdateNotify = 15679,
		// Token: 0x04000E7E RID: 3710
		SimpleCombatBeginNotify = 27378,
		// Token: 0x04000E7F RID: 3711
		SimpleCombatEndNotify = 27894,
		// Token: 0x04000E80 RID: 3712
		RoverRogueQuitRequest = 22259,
		// Token: 0x04000E81 RID: 3713
		RoverRogueQuitResponse = 27155,
		// Token: 0x04000E82 RID: 3714
		RoverRogueResultRequest = 20506,
		// Token: 0x04000E83 RID: 3715
		RoverRogueResultResponse = 18585,
		// Token: 0x04000E84 RID: 3716
		RoverRogueResultNotify = 26373,
		// Token: 0x04000E85 RID: 3717
		RoverRogueRoomInfoNotify = 28630,
		// Token: 0x04000E86 RID: 3718
		RoverRogueChooseDataNotify = 26956,
		// Token: 0x04000E87 RID: 3719
		RoverRogueChooseDataResultRequest = 19909,
		// Token: 0x04000E88 RID: 3720
		RoverRogueChooseDataResultResponse = 18760,
		// Token: 0x04000E89 RID: 3721
		RoverRogueRefreshGainRequest = 20036,
		// Token: 0x04000E8A RID: 3722
		RoverRogueRefreshGainResponse = 28469,
		// Token: 0x04000E8B RID: 3723
		RoverRogueGiveUpGainRequest = 17559,
		// Token: 0x04000E8C RID: 3724
		RoverRogueGiveUpGainResponse = 20859,
		// Token: 0x04000E8D RID: 3725
		RoverRogueSubLevelNotify = 29516,
		// Token: 0x04000E8E RID: 3726
		RoverRogueGotoNextRoomCommitRequest = 24658,
		// Token: 0x04000E8F RID: 3727
		RoverRogueGotoNextRoomCommitResponse = 18455,
		// Token: 0x04000E90 RID: 3728
		RoverRogueInsListRequest = 22892,
		// Token: 0x04000E91 RID: 3729
		RoverRogueInsListResponse = 21420,
		// Token: 0x04000E92 RID: 3730
		RoverRogueTalentInfoRequest = 22199,
		// Token: 0x04000E93 RID: 3731
		RoverRogueTalentInfoResponse = 24083,
		// Token: 0x04000E94 RID: 3732
		RoverRogueTalentUnlockRequest = 19911,
		// Token: 0x04000E95 RID: 3733
		RoverRogueTalentUnlockResponse = 22696,
		// Token: 0x04000E96 RID: 3734
		RoverRogueShopBuyRequest = 17480,
		// Token: 0x04000E97 RID: 3735
		RoverRogueShopBuyResponse = 29643,
		// Token: 0x04000E98 RID: 3736
		RoverRogueShopRefreshRequest = 18096,
		// Token: 0x04000E99 RID: 3737
		RoverRogueShopRefreshResponse = 25485,
		// Token: 0x04000E9A RID: 3738
		RoverRogueShopUpdateNotify = 21564,
		// Token: 0x04000E9B RID: 3739
		RoverRogueInfoNotify = 19891,
		// Token: 0x04000E9C RID: 3740
		RoverRogueGainDataUpdateNotify = 23339,
		// Token: 0x04000E9D RID: 3741
		RoverRogueCurrencyNotify = 17019,
		// Token: 0x04000E9E RID: 3742
		PlayerRecallInfoNotify = 26036,
		// Token: 0x04000E9F RID: 3743
		SwitchDarkTideWeaponPush = 15777,
		// Token: 0x04000EA0 RID: 3744
		DangoBrawlInstBaseNotify = 20779,
		// Token: 0x04000EA1 RID: 3745
		DangoBrawlInstEventSelectNotify = 15046,
		// Token: 0x04000EA2 RID: 3746
		DangoBrawlInstPrepareNotify = 29564,
		// Token: 0x04000EA3 RID: 3747
		DangoBrawlRoundSwitchNotify = 27098,
		// Token: 0x04000EA4 RID: 3748
		DangoBrawlBagOperateRequest = 16736,
		// Token: 0x04000EA5 RID: 3749
		DangoBrawlBagOperateResponse = 26530,
		// Token: 0x04000EA6 RID: 3750
		DangoBrawlCoinUpdateNotify = 17630,
		// Token: 0x04000EA7 RID: 3751
		DangoBrawlShopRefreshRequest = 27387,
		// Token: 0x04000EA8 RID: 3752
		DangoBrawlShopRefreshResponse = 22722,
		// Token: 0x04000EA9 RID: 3753
		DangoBrawlShopLockRequest = 15276,
		// Token: 0x04000EAA RID: 3754
		DangoBrawlShopLockResponse = 16429,
		// Token: 0x04000EAB RID: 3755
		DangoBrawlShopBuyRequest = 16336,
		// Token: 0x04000EAC RID: 3756
		DangoBrawlShopBuyResponse = 15499,
		// Token: 0x04000EAD RID: 3757
		DangoBrawlShopSellRequest = 17114,
		// Token: 0x04000EAE RID: 3758
		DangoBrawlShopSellResponse = 20763,
		// Token: 0x04000EAF RID: 3759
		DangoBrawlShopComposeRequest = 18102,
		// Token: 0x04000EB0 RID: 3760
		DangoBrawlShopComposeResponse = 25732,
		// Token: 0x04000EB1 RID: 3761
		DangoBrawlEventRefreshRequest = 24299,
		// Token: 0x04000EB2 RID: 3762
		DangoBrawlEventRefreshResponse = 23486,
		// Token: 0x04000EB3 RID: 3763
		DangoBrawlEventSelectRequest = 20144,
		// Token: 0x04000EB4 RID: 3764
		DangoBrawlEventSelectResponse = 22706,
		// Token: 0x04000EB5 RID: 3765
		DangoBrawlStartFightRequest = 19061,
		// Token: 0x04000EB6 RID: 3766
		DangoBrawlStartFightResponse = 21032,
		// Token: 0x04000EB7 RID: 3767
		DangoBrawlFightOverRequest = 24115,
		// Token: 0x04000EB8 RID: 3768
		DangoBrawlFightOverResponse = 19008,
		// Token: 0x04000EB9 RID: 3769
		DangoBrawlSettleNotify = 17267,
		// Token: 0x04000EBA RID: 3770
		RoverRogueGainGetOrLoseNotify = 20460,
		// Token: 0x04000EBB RID: 3771
		RoverRogueUpdateReviveTimesNotify = 18452,
		// Token: 0x04000EBC RID: 3772
		KurotatoNextWaveTypeNotify = 20306,
		// Token: 0x04000EBD RID: 3773
		RoverRogueBlessGroupSelectNotify = 28895,
		// Token: 0x04000EBE RID: 3774
		RoverRogueBlessGroupSelectRequest = 20925,
		// Token: 0x04000EBF RID: 3775
		RoverRogueBlessGroupSelectResponse = 20594,
		// Token: 0x04000EC0 RID: 3776
		DirectTrainInfoUpdateNotify = 20905,
		// Token: 0x04000EC1 RID: 3777
		NewTowerMedalInfoRequest = 19895,
		// Token: 0x04000EC2 RID: 3778
		NewTowerMedalInfoResponse = 15134,
		// Token: 0x04000EC3 RID: 3779
		LeaveQuestRecallNotify = 16941,
		// Token: 0x04000EC4 RID: 3780
		RoverRogueEventNotify = 15360,
		// Token: 0x04000EC5 RID: 3781
		RoverRogueEventSelectRequest = 25491,
		// Token: 0x04000EC6 RID: 3782
		RoverRogueEventSelectResponse = 29946,
		// Token: 0x04000EC7 RID: 3783
		MotorUseSceneRequest = 24816,
		// Token: 0x04000EC8 RID: 3784
		MotorUseSceneResponse = 23495,
		// Token: 0x04000EC9 RID: 3785
		DarkTideSwitchVisionRequest = 27020,
		// Token: 0x04000ECA RID: 3786
		DarkTideSwitchVisionResponse = 26299,
		// Token: 0x04000ECB RID: 3787
		DangoBrawlFighterAttrChangeNotify = 25853,
		// Token: 0x04000ECC RID: 3788
		DangoBrawlSettleRequest = 20328,
		// Token: 0x04000ECD RID: 3789
		DangoBrawlSettleResponse = 27928,
		// Token: 0x04000ECE RID: 3790
		DangoBrawlTaskUpdateNotify = 28545,
		// Token: 0x04000ECF RID: 3791
		DangoBrawlRoleUnlockNotify = 18339,
		// Token: 0x04000ED0 RID: 3792
		DangoBrawlItemUnlockNotify = 29171,
		// Token: 0x04000ED1 RID: 3793
		DangoBrawlTaskRewardRequest = 20110,
		// Token: 0x04000ED2 RID: 3794
		DangoBrawlTaskRewardResponse = 16585,
		// Token: 0x04000ED3 RID: 3795
		DarkTideDiscardItemRequest = 20955,
		// Token: 0x04000ED4 RID: 3796
		DarkTideDiscardItemResponse = 19686,
		// Token: 0x04000ED5 RID: 3797
		DarkTidePickUpItemRequest = 23254,
		// Token: 0x04000ED6 RID: 3798
		DarkTidePickUpItemResponse = 18475,
		// Token: 0x04000ED7 RID: 3799
		DarkTideBagSortRequest = 17853,
		// Token: 0x04000ED8 RID: 3800
		DarkTideBagSortResponse = 27116,
		// Token: 0x04000ED9 RID: 3801
		PlayerNetStateS2cNotify = 27482,
		// Token: 0x04000EDA RID: 3802
		PlayerNetStateBackServerPush = 23205,
		// Token: 0x04000EDB RID: 3803
		DarkTideBagUpdateNotify = 25791,
		// Token: 0x04000EDC RID: 3804
		SwitchDarkTideWeaponSlotNotify = 18091,
		// Token: 0x04000EDD RID: 3805
		QuestFastReturnPosRequest = 19158,
		// Token: 0x04000EDE RID: 3806
		QuestFastReturnPosResponse = 19847,
		// Token: 0x04000EDF RID: 3807
		LevelPlayFastReturnPosRequest = 16463,
		// Token: 0x04000EE0 RID: 3808
		LevelPlayFastReturnPosResponse = 18541,
		// Token: 0x04000EE1 RID: 3809
		FastReturnDungeonRequest = 26075,
		// Token: 0x04000EE2 RID: 3810
		FastReturnDungeonResponse = 22693,
		// Token: 0x04000EE3 RID: 3811
		DollSmallMapInfoRequest = 21017,
		// Token: 0x04000EE4 RID: 3812
		DollSmallMapInfoResponse = 22797,
		// Token: 0x04000EE5 RID: 3813
		AllDarkTideMapMarkNotify = 22844,
		// Token: 0x04000EE6 RID: 3814
		DarkTideMapMarkRequest = 16419,
		// Token: 0x04000EE7 RID: 3815
		DarkTideMapMarkResponse = 17014,
		// Token: 0x04000EE8 RID: 3816
		DarkTideMapMarkUpdateNotify = 18648,
		// Token: 0x04000EE9 RID: 3817
		DarkTideItemMarkRequest = 21315,
		// Token: 0x04000EEA RID: 3818
		DarkTideItemMarkResponse = 29034,
		// Token: 0x04000EEB RID: 3819
		DarkTideItemMarkUpdateNotify = 20455,
		// Token: 0x04000EEC RID: 3820
		RoverRogueLootInfoRequest = 28236,
		// Token: 0x04000EED RID: 3821
		RoverRogueLootInfoResponse = 20010,
		// Token: 0x04000EEE RID: 3822
		KurotatoReChallengeCountNotify = 19995,
		// Token: 0x04000EEF RID: 3823
		RoverRogueLootChangeNotify = 18535,
		// Token: 0x04000EF0 RID: 3824
		RoverRogueLootChangeRequest = 18020,
		// Token: 0x04000EF1 RID: 3825
		RoverRogueLootChangeResponse = 20028,
		// Token: 0x04000EF2 RID: 3826
		KurotatoStepAdvanceRequest = 19987,
		// Token: 0x04000EF3 RID: 3827
		KurotatoStepAdvanceResponse = 20011,
		// Token: 0x04000EF4 RID: 3828
		DarkTidePoisonCircleDayInitNotify = 18257,
		// Token: 0x04000EF5 RID: 3829
		DarkTidePoisonCircleStartShrinkNotify = 24836,
		// Token: 0x04000EF6 RID: 3830
		DarkTidePoisonCircleStopShrinkNotify = 19681,
		// Token: 0x04000EF7 RID: 3831
		RecallExploreSkillRouletteSetRequest = 20923,
		// Token: 0x04000EF8 RID: 3832
		RecallExploreSkillRouletteSetResponse = 23185,
		// Token: 0x04000EF9 RID: 3833
		RecallExploreSkillRouletteNotify = 15696,
		// Token: 0x04000EFA RID: 3834
		RoverRogueTalentUnlockNotify = 22418,
		// Token: 0x04000EFB RID: 3835
		RoverRogueTaskUpdateNotify = 24544,
		// Token: 0x04000EFC RID: 3836
		RoverRogueTaskRewardTakeRequest = 25823,
		// Token: 0x04000EFD RID: 3837
		RoverRogueTaskRewardTakeResponse = 20042,
		// Token: 0x04000EFE RID: 3838
		DangoBrawlFightActionNotify = 23382,
		// Token: 0x04000EFF RID: 3839
		SceneGroupDataAndCurFormationEntityRequest = 18649,
		// Token: 0x04000F00 RID: 3840
		SceneGroupDataAndCurFormationEntityResponse = 23762,
		// Token: 0x04000F01 RID: 3841
		DangoBrawlBagUpdateNotify = 23151,
		// Token: 0x04000F02 RID: 3842
		KurotatoGoldAddRequest = 29200,
		// Token: 0x04000F03 RID: 3843
		KurotatoGoldAddResponse = 26245,
		// Token: 0x04000F04 RID: 3844
		TowerDefenceChallengeQuitRequest = 29237,
		// Token: 0x04000F05 RID: 3845
		TowerDefenceChallengeQuitResponse = 29413,
		// Token: 0x04000F06 RID: 3846
		DarkTideExtraBagSyncNotify = 29192,
		// Token: 0x04000F07 RID: 3847
		PlayerTitleInfoUpdateNotify = 29816,
		// Token: 0x04000F08 RID: 3848
		KurotatoLevelRecordDeleteRequest = 20207,
		// Token: 0x04000F09 RID: 3849
		KurotatoLevelRecordDeleteResponse = 29888,
		// Token: 0x04000F0A RID: 3850
		PlayInstShareFirstInfoNotify = 26879,
		// Token: 0x04000F0B RID: 3851
		MailFavoriteRequest = 20098,
		// Token: 0x04000F0C RID: 3852
		MailFavoriteResponse = 26065,
		// Token: 0x04000F0D RID: 3853
		RoverRogueResourcesUpdateNotify = 29726,
		// Token: 0x04000F0E RID: 3854
		ConditionGroupStateRequest = 16491,
		// Token: 0x04000F0F RID: 3855
		ConditionGroupStateResponse = 21511,
		// Token: 0x04000F10 RID: 3856
		ZitherPlayStateRequest = 17270,
		// Token: 0x04000F11 RID: 3857
		ZitherPlayStateResponse = 16415,
		// Token: 0x04000F12 RID: 3858
		ZitherPlayNotePush = 27243,
		// Token: 0x04000F13 RID: 3859
		ZitherPlayNoteNotify = 18156,
		// Token: 0x04000F14 RID: 3860
		ElementalAbilityUpdateNotify = 29547,
		// Token: 0x04000F15 RID: 3861
		EntityAccessCasketRequest = 26836,
		// Token: 0x04000F16 RID: 3862
		EntityAccessCasketResponse = 16078,
		// Token: 0x04000F17 RID: 3863
		PlayerAccessCasketRequest = 24257,
		// Token: 0x04000F18 RID: 3864
		PlayerAccessCasketResponse = 26332,
		// Token: 0x04000F19 RID: 3865
		QingXiaoTaskUpdateNotify = 21503,
		// Token: 0x04000F1A RID: 3866
		QingXiaoTaskRewardRequest = 26165,
		// Token: 0x04000F1B RID: 3867
		QingXiaoTaskRewardResponse = 24325,
		// Token: 0x04000F1C RID: 3868
		EntityElementalAbilityEnableNotify = 16164,
		// Token: 0x04000F1D RID: 3869
		SheriffZoneItemUpdateNotify = 28846,
		// Token: 0x04000F1E RID: 3870
		DangoBrawlStartFightNotify = 17934,
		// Token: 0x04000F1F RID: 3871
		GiantDeliveryItemRequest = 23968,
		// Token: 0x04000F20 RID: 3872
		GiantDeliveryItemResponse = 20317,
		// Token: 0x04000F21 RID: 3873
		GiantSystemInfoNotify = 27770,
		// Token: 0x04000F22 RID: 3874
		GiantResponseNotify = 22958,
		// Token: 0x04000F23 RID: 3875
		GiantModelEnableNotify = 29470,
		// Token: 0x04000F24 RID: 3876
		GiantEcoUnlockNotify = 27800,
		// Token: 0x04000F25 RID: 3877
		GiantMaxLevelDeliveryItemRequest = 24688,
		// Token: 0x04000F26 RID: 3878
		GiantMaxLevelDeliveryItemResponse = 17949,
		// Token: 0x04000F27 RID: 3879
		MatchThreeStarRequest = 21794,
		// Token: 0x04000F28 RID: 3880
		MatchThreeStarResponse = 19999,
		// Token: 0x04000F29 RID: 3881
		MatchThreeEndRequest = 24146,
		// Token: 0x04000F2A RID: 3882
		MatchThreeEndResponse = 28958,
		// Token: 0x04000F2B RID: 3883
		DangoBrawlScoreRewardRequest = 28029,
		// Token: 0x04000F2C RID: 3884
		DangoBrawlScoreRewardResponse = 27166,
		// Token: 0x04000F2D RID: 3885
		CombatValNotify = 28115,
		// Token: 0x04000F2E RID: 3886
		CombatValDecayBeginNotify = 19990,
		// Token: 0x04000F2F RID: 3887
		DangoBrawlChallengeUnlockNotify = 26771,
		// Token: 0x04000F30 RID: 3888
		FoundationCoreOperateRequest = 22998,
		// Token: 0x04000F31 RID: 3889
		FoundationCoreOperateResponse = 21475,
		// Token: 0x04000F32 RID: 3890
		PlayerHandFoundationCoreChangeNotify = 19181,
		// Token: 0x04000F33 RID: 3891
		EntityFoundationCoreChangeNotify = 23251,
		// Token: 0x04000F34 RID: 3892
		TimePointRewardActivityConditionNotify = 26647,
		// Token: 0x04000F35 RID: 3893
		CameraSettingQueryRequest = 16381,
		// Token: 0x04000F36 RID: 3894
		CameraSettingQueryResponse = 22753,
		// Token: 0x04000F37 RID: 3895
		CameraSettingModifyRequest = 18483,
		// Token: 0x04000F38 RID: 3896
		CameraSettingModifyResponse = 17786,
		// Token: 0x04000F39 RID: 3897
		RecallMapMarkInfoNotify = 16779,
		// Token: 0x04000F3A RID: 3898
		RecallTeleportToMarkIdRequest = 27287,
		// Token: 0x04000F3B RID: 3899
		RecallTeleportToMarkIdResponse = 18152,
		// Token: 0x04000F3C RID: 3900
		DangoBrawlSaveMatchBriefNotify = 26533,
		// Token: 0x04000F3D RID: 3901
		RecallMapMarkUpdateNotify = 16865,
		// Token: 0x04000F3E RID: 3902
		ShortMessageChatThemeChangeRequest = 27042,
		// Token: 0x04000F3F RID: 3903
		ShortMessageChatThemeChangeResponse = 19186,
		// Token: 0x04000F40 RID: 3904
		ShortMessageChatCharmChangeRequest = 29957,
		// Token: 0x04000F41 RID: 3905
		ShortMessageChatCharmChangeResponse = 18908,
		// Token: 0x04000F42 RID: 3906
		GiantItemUnlockNotify = 18458,
		// Token: 0x04000F43 RID: 3907
		RenameFormationRequest = 24542,
		// Token: 0x04000F44 RID: 3908
		RenameFormationResponse = 17954,
		// Token: 0x04000F45 RID: 3909
		ReorderFormationRequest = 18507,
		// Token: 0x04000F46 RID: 3910
		ReorderFormationResponse = 25008,
		// Token: 0x04000F47 RID: 3911
		GiantItemAccessUnlockNotify = 22982,
		// Token: 0x04000F48 RID: 3912
		GiantItemAccessProgressChangeNotify = 18717,
		// Token: 0x04000F49 RID: 3913
		GiantStableValueActivityRequest = 18354,
		// Token: 0x04000F4A RID: 3914
		GiantStableValueActivityResponse = 29866,
		// Token: 0x04000F4B RID: 3915
		GiantTotalStableValueUpdateNotify = 29495,
		// Token: 0x04000F4C RID: 3916
		SquadPropChangedNotify = 21485,
		// Token: 0x04000F4D RID: 3917
		GiantActivityNodeActiveNotify = 26790,
		// Token: 0x04000F4E RID: 3918
		RecallItemUseRequest = 26379,
		// Token: 0x04000F4F RID: 3919
		RecallItemUseResponse = 28729,
		// Token: 0x04000F50 RID: 3920
		DangoBrawlLoseCountUpdateNotify = 16325,
		// Token: 0x04000F51 RID: 3921
		RoverRogueShopInfoUpdateNotify = 20174,
		// Token: 0x04000F52 RID: 3922
		BanItemUseNotify = 15908,
		// Token: 0x04000F53 RID: 3923
		TreasureChestCountNotify = 21988,
		// Token: 0x04000F54 RID: 3924
		DangoBrawlItemGiveCoinNotify = 15390,
		// Token: 0x04000F55 RID: 3925
		DangoBrawlItemEffectShowNotify = 25822,
		// Token: 0x04000F56 RID: 3926
		GameStatsShowRequest = 26099,
		// Token: 0x04000F57 RID: 3927
		GameStatsShowResponse = 19755,
		// Token: 0x04000F58 RID: 3928
		DangoBrawlActivityLimitCoinUpdateNotify = 27996,
		// Token: 0x04000F59 RID: 3929
		TreasureChestCountIncrementNotify = 19516,
		// Token: 0x04000F5A RID: 3930
		SelfPortraitStateRequest = 25316,
		// Token: 0x04000F5B RID: 3931
		SelfPortraitStateResponse = 25392,
		// Token: 0x04000F5C RID: 3932
		LoopTeleportVolumeActionRequest = 17374,
		// Token: 0x04000F5D RID: 3933
		LoopTeleportVolumeActionResponse = 18393,
		// Token: 0x04000F5E RID: 3934
		PhantomEquipGroupInfoNotify = 18815,
		// Token: 0x04000F5F RID: 3935
		RecallItemBagObtainNotify = 24789,
		// Token: 0x04000F60 RID: 3936
		WellStreamingFinisRequest = 25917,
		// Token: 0x04000F61 RID: 3937
		WellStreamingFinisResponse = 28686,
		// Token: 0x04000F62 RID: 3938
		RecallItemRewardNotify = 22016,
		// Token: 0x04000F63 RID: 3939
		TimePointActivityBatchRewardRequest = 15010,
		// Token: 0x04000F64 RID: 3940
		TimePointActivityBatchRewardResponse = 22079,
		// Token: 0x04000F65 RID: 3941
		FollowerChairPresentationPush = 18876,
		// Token: 0x04000F66 RID: 3942
		FollowerChairPresentationChangeNotify = 15976,
		// Token: 0x04000F67 RID: 3943
		RecallInstSaveDataNotify = 18912,
		// Token: 0x04000F68 RID: 3944
		GuideGroupResetNotify = 29256,
		// Token: 0x04000F69 RID: 3945
		ServerConfigVersionInfoNotify = 19359
	}
}
