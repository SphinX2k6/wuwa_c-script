using System;

namespace Aki.Protocol
{
	// Token: 0x0200000A RID: 10
	public enum ERequestMessageId
	{
		// Token: 0x0400147B RID: 5243
		CreateCharacterRequest = 101,
		// Token: 0x0400147C RID: 5244
		LoginRequest = 103,
		// Token: 0x0400147D RID: 5245
		EnterGameRequest = 105,
		// Token: 0x0400147E RID: 5246
		ReconnectRequest = 107,
		// Token: 0x0400147F RID: 5247
		ProtoKeyRequest = 111,
		// Token: 0x04001480 RID: 5248
		AchievementInfoRequest = 23322,
		// Token: 0x04001481 RID: 5249
		AchievementReceiveRequest = 16111,
		// Token: 0x04001482 RID: 5250
		AchievementFinishRequest = 16752,
		// Token: 0x04001483 RID: 5251
		ActionFinishRequest = 27144,
		// Token: 0x04001484 RID: 5252
		GmLevelActionRequest = 15038,
		// Token: 0x04001485 RID: 5253
		ActivityRequest = 24675,
		// Token: 0x04001486 RID: 5254
		ActivityFirstReadRequest = 21916,
		// Token: 0x04001487 RID: 5255
		SignActivityRequest = 27564,
		// Token: 0x04001488 RID: 5256
		HarvestActivityPointRequest = 29278,
		// Token: 0x04001489 RID: 5257
		HarvestActivityLevelRequest = 23568,
		// Token: 0x0400148A RID: 5258
		HarvestActivityLevelDiffRequest = 24064,
		// Token: 0x0400148B RID: 5259
		HarvestActivityResultRequest = 16437,
		// Token: 0x0400148C RID: 5260
		PhantomCollectReceiveRequest = 18117,
		// Token: 0x0400148D RID: 5261
		AdventureManualDataRequest = 29621,
		// Token: 0x0400148E RID: 5262
		GetAdventureRewardRequest = 27637,
		// Token: 0x0400148F RID: 5263
		GetChapterRewardRequest = 21975,
		// Token: 0x04001490 RID: 5264
		DetectionRequest = 26178,
		// Token: 0x04001491 RID: 5265
		AdventureManualRequest = 26238,
		// Token: 0x04001492 RID: 5266
		ReceivedSilentFirstAwardRequest = 29881,
		// Token: 0x04001493 RID: 5267
		SelectDetectionTargetRequest = 28315,
		// Token: 0x04001494 RID: 5268
		MonsterDetectionInfoRequest = 28081,
		// Token: 0x04001495 RID: 5269
		NormalMonsterManualInfoRequest = 21805,
		// Token: 0x04001496 RID: 5270
		GetDetectionLabelInfoRequest = 15760,
		// Token: 0x04001497 RID: 5271
		AdviceSetRequest = 17909,
		// Token: 0x04001498 RID: 5272
		AdviceRequest = 24258,
		// Token: 0x04001499 RID: 5273
		AdviceCreateRequest = 16066,
		// Token: 0x0400149A RID: 5274
		AdviceModifyRequest = 17345,
		// Token: 0x0400149B RID: 5275
		AdviceDeleteRequest = 19569,
		// Token: 0x0400149C RID: 5276
		AdviceVoteRequest = 26463,
		// Token: 0x0400149D RID: 5277
		AiInformationRequest = 27094,
		// Token: 0x0400149E RID: 5278
		AiBlackboardsRequest = 17413,
		// Token: 0x0400149F RID: 5279
		AiBlackboardCdRequest = 28767,
		// Token: 0x040014A0 RID: 5280
		AiHateRequest = 27946,
		// Token: 0x040014A1 RID: 5281
		AiControlSwitchRequest = 18300,
		// Token: 0x040014A2 RID: 5282
		EnterAreaRequest = 28495,
		// Token: 0x040014A3 RID: 5283
		ReportPlayerRequest = 25202,
		// Token: 0x040014A4 RID: 5284
		ModifyNameRequest = 20729,
		// Token: 0x040014A5 RID: 5285
		ModifySignatureRequest = 21047,
		// Token: 0x040014A6 RID: 5286
		ChangeHeadPhotoRequest = 17034,
		// Token: 0x040014A7 RID: 5287
		ClientBasicInfoRequest = 20137,
		// Token: 0x040014A8 RID: 5288
		PlayerBasicInfoGetRequest = 19634,
		// Token: 0x040014A9 RID: 5289
		BirthdayInitRequest = 25294,
		// Token: 0x040014AA RID: 5290
		RoleShowListUpdateRequest = 16909,
		// Token: 0x040014AB RID: 5291
		ChangeCardRequest = 20690,
		// Token: 0x040014AC RID: 5292
		ReadCardRequest = 18462,
		// Token: 0x040014AD RID: 5293
		BirthdayShowSetRequest = 27587,
		// Token: 0x040014AE RID: 5294
		BattlePassRequest = 28338,
		// Token: 0x040014AF RID: 5295
		BattlePassTakeRewardRequest = 17354,
		// Token: 0x040014B0 RID: 5296
		BattlePassRecurringTakeRequest = 26547,
		// Token: 0x040014B1 RID: 5297
		BattlePassTakeAllRewardRequest = 19919,
		// Token: 0x040014B2 RID: 5298
		BattlePassTaskRequest = 20446,
		// Token: 0x040014B3 RID: 5299
		BattlePassTaskTakeRequest = 27478,
		// Token: 0x040014B4 RID: 5300
		BattlePassLevelUpRequest = 28304,
		// Token: 0x040014B5 RID: 5301
		SubmitNodeRequest = 19815,
		// Token: 0x040014B6 RID: 5302
		HandInItemRequest = 22822,
		// Token: 0x040014B7 RID: 5303
		BtSetTimerInfoRequest = 16825,
		// Token: 0x040014B8 RID: 5304
		BtForcedOccupationRequest = 20760,
		// Token: 0x040014B9 RID: 5305
		BtGiveUpRequest = 20571,
		// Token: 0x040014BA RID: 5306
		BtRollbackRequest = 27940,
		// Token: 0x040014BB RID: 5307
		SneakRequest = 28095,
		// Token: 0x040014BC RID: 5308
		SneakTimeRequest = 24968,
		// Token: 0x040014BD RID: 5309
		TimerEndRequest = 15205,
		// Token: 0x040014BE RID: 5310
		UiGamePlayRequest = 20564,
		// Token: 0x040014BF RID: 5311
		NpcTraceFailedRequest = 27353,
		// Token: 0x040014C0 RID: 5312
		WorldBlackboardRequest = 19106,
		// Token: 0x040014C1 RID: 5313
		EntityBlackboardRequest = 15598,
		// Token: 0x040014C2 RID: 5314
		BlockListRequest = 18290,
		// Token: 0x040014C3 RID: 5315
		BlockPlayerRequest = 16633,
		// Token: 0x040014C4 RID: 5316
		UnblockPlayerRequest = 16206,
		// Token: 0x040014C5 RID: 5317
		PlaceItemOnBoardRequest = 29265,
		// Token: 0x040014C6 RID: 5318
		CommitBoardRequest = 18174,
		// Token: 0x040014C7 RID: 5319
		MovePlacementRequest = 21717,
		// Token: 0x040014C8 RID: 5320
		ApplyGameplayEffectRequest = 22973,
		// Token: 0x040014C9 RID: 5321
		RemoveGameplayEffectRequest = 19884,
		// Token: 0x040014CA RID: 5322
		OrderApplyBuffRequest = 21800,
		// Token: 0x040014CB RID: 5323
		OrderRemoveBuffRequest = 29255,
		// Token: 0x040014CC RID: 5324
		ActivateBuffRequest = 17149,
		// Token: 0x040014CD RID: 5325
		OrderRemoveBuffByTagsRequest = 22742,
		// Token: 0x040014CE RID: 5326
		BuffEffectExecuteRequest = 26094,
		// Token: 0x040014CF RID: 5327
		BuffStackCountRequest = 19820,
		// Token: 0x040014D0 RID: 5328
		BuffEffectRequest = 22540,
		// Token: 0x040014D1 RID: 5329
		BuffItemRequest = 23217,
		// Token: 0x040014D2 RID: 5330
		CalabashMsgRequest = 22482,
		// Token: 0x040014D3 RID: 5331
		CalabashLevelRewardRequest = 23794,
		// Token: 0x040014D4 RID: 5332
		CdKeyVerifyRequest = 27335,
		// Token: 0x040014D5 RID: 5333
		ChatRequest = 27797,
		// Token: 0x040014D6 RID: 5334
		PrivateChatRequest = 23483,
		// Token: 0x040014D7 RID: 5335
		PrivateChatHistoryRequest = 23362,
		// Token: 0x040014D8 RID: 5336
		PrivateChatDataRequest = 16343,
		// Token: 0x040014D9 RID: 5337
		ChatMutePlayerRequest = 16226,
		// Token: 0x040014DA RID: 5338
		PrivateChatOperateRequest = 27275,
		// Token: 0x040014DB RID: 5339
		ChannelChatRequest = 19772,
		// Token: 0x040014DC RID: 5340
		CombatSendPackRequest = 19470,
		// Token: 0x040014DD RID: 5341
		CombatMaxCaseMessageRequest = 22467,
		// Token: 0x040014DE RID: 5342
		FixToolRequest = 18028,
		// Token: 0x040014DF RID: 5343
		CookFormulaRequest = 20428,
		// Token: 0x040014E0 RID: 5344
		CookFoodRequest = 28222,
		// Token: 0x040014E1 RID: 5345
		FoodProcessRequest = 18213,
		// Token: 0x040014E2 RID: 5346
		CertificateLevelRewardRequest = 16054,
		// Token: 0x040014E3 RID: 5347
		CookingDataRequest = 22249,
		// Token: 0x040014E4 RID: 5348
		InteractiveUpdateRequest = 19271,
		// Token: 0x040014E5 RID: 5349
		DailyAdventurePtRewardRequest = 17854,
		// Token: 0x040014E6 RID: 5350
		DailyAdventureTaskRewardRequest = 15828,
		// Token: 0x040014E7 RID: 5351
		CheatInputRequest = 26873,
		// Token: 0x040014E8 RID: 5352
		EnableDamageRecordRequest = 25565,
		// Token: 0x040014E9 RID: 5353
		OutputDebugInfoRequest = 28615,
		// Token: 0x040014EA RID: 5354
		PickUpDropItemRequest = 24705,
		// Token: 0x040014EB RID: 5355
		ElevatorStateChangeRequest = 23005,
		// Token: 0x040014EC RID: 5356
		EnergySyncRequest = 24596,
		// Token: 0x040014ED RID: 5357
		ChangeStateRequest = 25799,
		// Token: 0x040014EE RID: 5358
		ChangeStateConfirmRequest = 27052,
		// Token: 0x040014EF RID: 5359
		FsmConditionPassRequest = 22886,
		// Token: 0x040014F0 RID: 5360
		GmEntityFsmGroupInfoRequest = 22037,
		// Token: 0x040014F1 RID: 5361
		EntityBuffProducerRequest = 18682,
		// Token: 0x040014F2 RID: 5362
		EntityBuffProducerOperateRequest = 26503,
		// Token: 0x040014F3 RID: 5363
		LogicStateInitRequest = 26172,
		// Token: 0x040014F4 RID: 5364
		SwitchLogicStateRequest = 18438,
		// Token: 0x040014F5 RID: 5365
		EntityActiveRequest = 28481,
		// Token: 0x040014F6 RID: 5366
		AnimationGameplayTagRequest = 25863,
		// Token: 0x040014F7 RID: 5367
		AnimalDieRequest = 21599,
		// Token: 0x040014F8 RID: 5368
		AnimalDestroyRequest = 16245,
		// Token: 0x040014F9 RID: 5369
		AnimalDropRequest = 29107,
		// Token: 0x040014FA RID: 5370
		EntityInteractRequest = 18643,
		// Token: 0x040014FB RID: 5371
		EntityRandomInteractRequest = 23187,
		// Token: 0x040014FC RID: 5372
		EntityDynamicInteractRequest = 18350,
		// Token: 0x040014FD RID: 5373
		EntityPosAbnormalRequest = 26606,
		// Token: 0x040014FE RID: 5374
		EntityAdsorbRequest = 16297,
		// Token: 0x040014FF RID: 5375
		BoneVisibleChangeRequest = 20124,
		// Token: 0x04001500 RID: 5376
		EntityStaticHookMoveRequest = 18356,
		// Token: 0x04001501 RID: 5377
		EntityPatrolStartRequest = 29907,
		// Token: 0x04001502 RID: 5378
		EntityPatrolStopRequest = 27475,
		// Token: 0x04001503 RID: 5379
		EntityPatrolChangeDirRequest = 26382,
		// Token: 0x04001504 RID: 5380
		VfxNpcPatrolFinishRequest = 17617,
		// Token: 0x04001505 RID: 5381
		EntitySendEventRequest = 20081,
		// Token: 0x04001506 RID: 5382
		AccessPasserbyNpcSpawnerRequest = 29764,
		// Token: 0x04001507 RID: 5383
		ExploreProgressRequest = 19237,
		// Token: 0x04001508 RID: 5384
		ExploreScoreRewardRequest = 22561,
		// Token: 0x04001509 RID: 5385
		CountryExploreScoreInfoRequest = 25855,
		// Token: 0x0400150A RID: 5386
		VisionExploreSkillSetRequest = 23633,
		// Token: 0x0400150B RID: 5387
		ExploreSkillRouletteSetRequest = 25875,
		// Token: 0x0400150C RID: 5388
		ExploreSkillPullGiantRequest = 26996,
		// Token: 0x0400150D RID: 5389
		UseDetectionSkillRequest = 16737,
		// Token: 0x0400150E RID: 5390
		SetFanNumberOfTurnsRequest = 28291,
		// Token: 0x0400150F RID: 5391
		SetBaoziStateRequest = 18278,
		// Token: 0x04001510 RID: 5392
		SetFanStateRequest = 19934,
		// Token: 0x04001511 RID: 5393
		RoleFavorListRequest = 28257,
		// Token: 0x04001512 RID: 5394
		RoleFavorUnLockRequest = 28764,
		// Token: 0x04001513 RID: 5395
		RoleFavorAcceptQuestRequest = 18026,
		// Token: 0x04001514 RID: 5396
		RoleFavorTalkScoreRequest = 22288,
		// Token: 0x04001515 RID: 5397
		RoleMotionUnLockRequest = 22268,
		// Token: 0x04001516 RID: 5398
		SkillRequest = 29518,
		// Token: 0x04001517 RID: 5399
		UseSkillRequest = 21005,
		// Token: 0x04001518 RID: 5400
		EndSkillRequest = 24580,
		// Token: 0x04001519 RID: 5401
		InterruptSkillInDelayRequest = 17561,
		// Token: 0x0400151A RID: 5402
		UseSkillFailRequest = 22140,
		// Token: 0x0400151B RID: 5403
		HitRequest = 15093,
		// Token: 0x0400151C RID: 5404
		HitEndRequest = 25554,
		// Token: 0x0400151D RID: 5405
		CaughtRequest = 21766,
		// Token: 0x0400151E RID: 5406
		CreateBulletRequest = 16833,
		// Token: 0x0400151F RID: 5407
		DestroyBulletRequest = 26218,
		// Token: 0x04001520 RID: 5408
		ModifyBulletParamsRequest = 16767,
		// Token: 0x04001521 RID: 5409
		DamageExecuteRequest = 22022,
		// Token: 0x04001522 RID: 5410
		PassiveSkillAddRequest = 23740,
		// Token: 0x04001523 RID: 5411
		PassiveSkillRemoveRequest = 21925,
		// Token: 0x04001524 RID: 5412
		EnterViewDirectionRequest = 18587,
		// Token: 0x04001525 RID: 5413
		ExitViewDirectionRequest = 25488,
		// Token: 0x04001526 RID: 5414
		TriggerExitSkillRequest = 29898,
		// Token: 0x04001527 RID: 5415
		CharacterDeathRequest = 27163,
		// Token: 0x04001528 RID: 5416
		SwitchBattleModeRequest = 24463,
		// Token: 0x04001529 RID: 5417
		LandingDamageRequest = 23415,
		// Token: 0x0400152A RID: 5418
		EntityIsVisibleRequest = 24121,
		// Token: 0x0400152B RID: 5419
		ActorVisibleRequest = 20487,
		// Token: 0x0400152C RID: 5420
		SwitchCharacterStateRequest = 27567,
		// Token: 0x0400152D RID: 5421
		BattleStateChangeRequest = 19661,
		// Token: 0x0400152E RID: 5422
		ToughCalcExtraRatioChangeRequest = 23954,
		// Token: 0x0400152F RID: 5423
		MonsterBoomRequest = 27664,
		// Token: 0x04001530 RID: 5424
		EntityBattleInfoRequest = 17230,
		// Token: 0x04001531 RID: 5425
		MontagePlayRequest = 22974,
		// Token: 0x04001532 RID: 5426
		ANStartRequest = 23064,
		// Token: 0x04001533 RID: 5427
		SwitchRoleRequest = 20789,
		// Token: 0x04001534 RID: 5428
		UpdateFormationRequest = 18636,
		// Token: 0x04001535 RID: 5429
		UpdateFightRoleRequest = 26624,
		// Token: 0x04001536 RID: 5430
		GetFormationDataRequest = 17698,
		// Token: 0x04001537 RID: 5431
		FlowEndRequest = 16032,
		// Token: 0x04001538 RID: 5432
		FlowRestartRequest = 24934,
		// Token: 0x04001539 RID: 5433
		FlowActionRequest = 21156,
		// Token: 0x0400153A RID: 5434
		ForgeInfoRequest = 23896,
		// Token: 0x0400153B RID: 5435
		ForgeItemRequest = 22375,
		// Token: 0x0400153C RID: 5436
		ForgeFormulaUnlockRequest = 21366,
		// Token: 0x0400153D RID: 5437
		FormationRequest = 23200,
		// Token: 0x0400153E RID: 5438
		FormationSwitchCurrentRequest = 20059,
		// Token: 0x0400153F RID: 5439
		FormationModifyRequest = 21924,
		// Token: 0x04001540 RID: 5440
		FormationChangeRequest = 28405,
		// Token: 0x04001541 RID: 5441
		FormationSwitchRoleRequest = 27304,
		// Token: 0x04001542 RID: 5442
		ClientCurrentRoleReportRequest = 27281,
		// Token: 0x04001543 RID: 5443
		FriendAllRequest = 16982,
		// Token: 0x04001544 RID: 5444
		FriendApplySendRequest = 16030,
		// Token: 0x04001545 RID: 5445
		FriendApplyHandleRequest = 24797,
		// Token: 0x04001546 RID: 5446
		FriendRemarkRequest = 23751,
		// Token: 0x04001547 RID: 5447
		FriendDeleteRequest = 23712,
		// Token: 0x04001548 RID: 5448
		FriendRecentlyTeamRequest = 15455,
		// Token: 0x04001549 RID: 5449
		FuncShowRequest = 15710,
		// Token: 0x0400154A RID: 5450
		GachaInfoRequest = 28888,
		// Token: 0x0400154B RID: 5451
		GachaRequest = 25270,
		// Token: 0x0400154C RID: 5452
		GachaUsePoolRequest = 21879,
		// Token: 0x0400154D RID: 5453
		GatherActivityRewardRequest = 24573,
		// Token: 0x0400154E RID: 5454
		GuideInfoRequest = 17498,
		// Token: 0x0400154F RID: 5455
		GuideTriggerRequest = 28091,
		// Token: 0x04001550 RID: 5456
		GuideFinishRequest = 23117,
		// Token: 0x04001551 RID: 5457
		HeartbeatRequest = 1650,
		// Token: 0x04001552 RID: 5458
		GatewayEchoRequest = 28532,
		// Token: 0x04001553 RID: 5459
		IllustratedRedDotRequest = 25943,
		// Token: 0x04001554 RID: 5460
		IllustratedInfoRequest = 17985,
		// Token: 0x04001555 RID: 5461
		IllustratedUnlockRequest = 20120,
		// Token: 0x04001556 RID: 5462
		IllustratedReadRequest = 26576,
		// Token: 0x04001557 RID: 5463
		InfluenceInfoRequest = 25529,
		// Token: 0x04001558 RID: 5464
		InfluenceRewardRequest = 16109,
		// Token: 0x04001559 RID: 5465
		ReadDisplayInfoRequest = 17532,
		// Token: 0x0400155A RID: 5466
		EnterInstRequest = 17431,
		// Token: 0x0400155B RID: 5467
		UnlockInstEntranceRequest = 19928,
		// Token: 0x0400155C RID: 5468
		InstEntranceDetailRequest = 24602,
		// Token: 0x0400155D RID: 5469
		LeaveInstRequest = 28370,
		// Token: 0x0400155E RID: 5470
		GetInstExchangeRewardRequest = 25650,
		// Token: 0x0400155F RID: 5471
		ExchangeRewardInfoRequest = 26002,
		// Token: 0x04001560 RID: 5472
		SingleInstRechallengeRequest = 19217,
		// Token: 0x04001561 RID: 5473
		ItemDecomposeRequest = 16771,
		// Token: 0x04001562 RID: 5474
		ItemDecomposePreviewRequest = 27713,
		// Token: 0x04001563 RID: 5475
		ItemLockRequest = 25683,
		// Token: 0x04001564 RID: 5476
		ItemUseRequest = 16031,
		// Token: 0x04001565 RID: 5477
		ItemGiftUseRequest = 18386,
		// Token: 0x04001566 RID: 5478
		NormalItemRequest = 22983,
		// Token: 0x04001567 RID: 5479
		WeaponItemRequest = 25468,
		// Token: 0x04001568 RID: 5480
		PhantomItemRequest = 24659,
		// Token: 0x04001569 RID: 5481
		InvalidItemRequest = 25813,
		// Token: 0x0400156A RID: 5482
		ShowInvalidItemRequest = 28036,
		// Token: 0x0400156B RID: 5483
		ValidTimeItemRequest = 16123,
		// Token: 0x0400156C RID: 5484
		ItemExchangeInfoRequest = 17245,
		// Token: 0x0400156D RID: 5485
		ItemExchangeRequest = 24108,
		// Token: 0x0400156E RID: 5486
		LevelPlayRewardRequest = 24224,
		// Token: 0x0400156F RID: 5487
		LivenessRequest = 25906,
		// Token: 0x04001570 RID: 5488
		LivenessTaskTakeRequest = 23058,
		// Token: 0x04001571 RID: 5489
		LivenessTakeRequest = 29270,
		// Token: 0x04001572 RID: 5490
		LoadEquipInfoRequest = 25260,
		// Token: 0x04001573 RID: 5491
		EquipTakeOnRequest = 29592,
		// Token: 0x04001574 RID: 5492
		LordGymInfoRequest = 24619,
		// Token: 0x04001575 RID: 5493
		LordGymBeginRequest = 24586,
		// Token: 0x04001576 RID: 5494
		LordGymReadRequest = 29647,
		// Token: 0x04001577 RID: 5495
		MailReadRequest = 29441,
		// Token: 0x04001578 RID: 5496
		MailGetAttachmentRequest = 24199,
		// Token: 0x04001579 RID: 5497
		MailDeleteRequest = 18443,
		// Token: 0x0400157A RID: 5498
		MapMarkInfoRequest = 21577,
		// Token: 0x0400157B RID: 5499
		MapUnlockFieldInfoRequest = 23298,
		// Token: 0x0400157C RID: 5500
		MapMarkRequest = 18642,
		// Token: 0x0400157D RID: 5501
		MapRemoveMarkRequest = 15669,
		// Token: 0x0400157E RID: 5502
		MapTraceInfoRequest = 22743,
		// Token: 0x0400157F RID: 5503
		MapTraceRequest = 17647,
		// Token: 0x04001580 RID: 5504
		MapCancelTraceRequest = 29421,
		// Token: 0x04001581 RID: 5505
		MapReplaceMarkRequest = 17142,
		// Token: 0x04001582 RID: 5506
		MapRemoveAllMarkRequest = 15166,
		// Token: 0x04001583 RID: 5507
		MapMarkInfoUpdateRequest = 20363,
		// Token: 0x04001584 RID: 5508
		StartMatchRequest = 21756,
		// Token: 0x04001585 RID: 5509
		CancelMatchRequest = 26931,
		// Token: 0x04001586 RID: 5510
		MatchConfirmRequest = 20944,
		// Token: 0x04001587 RID: 5511
		MatchChangeRoleRequest = 16318,
		// Token: 0x04001588 RID: 5512
		MatchChangeReadyRequest = 17228,
		// Token: 0x04001589 RID: 5513
		LeaveMatchTeamRequest = 28110,
		// Token: 0x0400158A RID: 5514
		KickMatchTeamPlayerRequest = 25677,
		// Token: 0x0400158B RID: 5515
		SetMatchTeamMatchFlagRequest = 18868,
		// Token: 0x0400158C RID: 5516
		EnterMatchInstRequest = 21561,
		// Token: 0x0400158D RID: 5517
		TeamChallengeRequest = 26370,
		// Token: 0x0400158E RID: 5518
		TeamMatchInviteRequest = 17409,
		// Token: 0x0400158F RID: 5519
		TeamMatchAcceptInviteRequest = 26322,
		// Token: 0x04001590 RID: 5520
		MatchChangePlayerUiStateRequest = 24320,
		// Token: 0x04001591 RID: 5521
		HandInMingSuRequest = 23496,
		// Token: 0x04001592 RID: 5522
		ActiveDragonPoolRequest = 29864,
		// Token: 0x04001593 RID: 5523
		DragonPoolConfRequest = 21659,
		// Token: 0x04001594 RID: 5524
		MonthCardRequest = 15066,
		// Token: 0x04001595 RID: 5525
		MutiplayerTeamRefreshNearListRequest = 27911,
		// Token: 0x04001596 RID: 5526
		NetTestDataRequest = 16056,
		// Token: 0x04001597 RID: 5527
		NewBieCourseRewardRequest = 29127,
		// Token: 0x04001598 RID: 5528
		NewJourneyRequest = 24090,
		// Token: 0x04001599 RID: 5529
		ParkourChallengeRequest = 20163,
		// Token: 0x0400159A RID: 5530
		ParkourChallengeTakeRequest = 23686,
		// Token: 0x0400159B RID: 5531
		ParkourChallengeTransRequest = 23432,
		// Token: 0x0400159C RID: 5532
		PartComponentInitRequest = 17744,
		// Token: 0x0400159D RID: 5533
		PartUpdateRequest = 23337,
		// Token: 0x0400159E RID: 5534
		PayInfoRequest = 18331,
		// Token: 0x0400159F RID: 5535
		PayItemRequest = 28472,
		// Token: 0x040015A0 RID: 5536
		PayGiftInfoRequest = 26799,
		// Token: 0x040015A1 RID: 5537
		PayGiftRequest = 21930,
		// Token: 0x040015A2 RID: 5538
		PayShopInfoRequest = 20758,
		// Token: 0x040015A3 RID: 5539
		PayShopUpdateRequest = 17383,
		// Token: 0x040015A4 RID: 5540
		PayShopItemUpdateRequest = 16274,
		// Token: 0x040015A5 RID: 5541
		PayShopBuyRequest = 23126,
		// Token: 0x040015A6 RID: 5542
		PayShopDirectBuyRequest = 28521,
		// Token: 0x040015A7 RID: 5543
		PhantomLevelUpRequest = 16448,
		// Token: 0x040015A8 RID: 5544
		PhantomPutOnRequest = 29319,
		// Token: 0x040015A9 RID: 5545
		PhantomReturnPreviewRequest = 29070,
		// Token: 0x040015AA RID: 5546
		PhantomReturnRequest = 19584,
		// Token: 0x040015AB RID: 5547
		PhantomRecommendRequest = 26086,
		// Token: 0x040015AC RID: 5548
		PhantomAutoPutRequest = 26414,
		// Token: 0x040015AD RID: 5549
		PhantomIdentifyRequest = 18169,
		// Token: 0x040015AE RID: 5550
		PhantomSkinChangeRequest = 25116,
		// Token: 0x040015AF RID: 5551
		PhantomRefiningRequest = 25546,
		// Token: 0x040015B0 RID: 5552
		UpdatePlayerPassiveSkillRequest = 16711,
		// Token: 0x040015B1 RID: 5553
		PlayerMotionRequest = 18827,
		// Token: 0x040015B2 RID: 5554
		PressRequest = 21606,
		// Token: 0x040015B3 RID: 5555
		PressGameRequest = 15600,
		// Token: 0x040015B4 RID: 5556
		ProgressBarFinishRequest = 17360,
		// Token: 0x040015B5 RID: 5557
		FormationAttrRequest = 21778,
		// Token: 0x040015B6 RID: 5558
		FragileChangeRequest = 29703,
		// Token: 0x040015B7 RID: 5559
		CheckPublicResourceVersionRequest = 28539,
		// Token: 0x040015B8 RID: 5560
		TraceQuestRequest = 28978,
		// Token: 0x040015B9 RID: 5561
		QuestFinishActionRequest = 26719,
		// Token: 0x040015BA RID: 5562
		QuestActionRequest = 21411,
		// Token: 0x040015BB RID: 5563
		QuestNpcMoveOverRequest = 23456,
		// Token: 0x040015BC RID: 5564
		QuestFinishActionEndRequest = 20075,
		// Token: 0x040015BD RID: 5565
		DailyQuestChangePreferRequest = 18344,
		// Token: 0x040015BE RID: 5566
		DailyQuestGetRewardRequest = 29092,
		// Token: 0x040015BF RID: 5567
		RoleQuestAcceptRequest = 18997,
		// Token: 0x040015C0 RID: 5568
		RoleQuestPointStateRequest = 15049,
		// Token: 0x040015C1 RID: 5569
		QuestRedDotRequest = 16021,
		// Token: 0x040015C2 RID: 5570
		ApplyRechallengeRequest = 21016,
		// Token: 0x040015C3 RID: 5571
		ReceiveRechallengeRequest = 15865,
		// Token: 0x040015C4 RID: 5572
		InviteRechallengeRequest = 27217,
		// Token: 0x040015C5 RID: 5573
		ReviveRequest = 18644,
		// Token: 0x040015C6 RID: 5574
		AddReviveRegionRequest = 23120,
		// Token: 0x040015C7 RID: 5575
		RemoveReviveRegionRequest = 25255,
		// Token: 0x040015C8 RID: 5576
		RoguelikeRefreshGainRequest = 29603,
		// Token: 0x040015C9 RID: 5577
		RoguelikeChooseDataRequest = 21182,
		// Token: 0x040015CA RID: 5578
		RoguelikeChooseDataResultRequest = 26274,
		// Token: 0x040015CB RID: 5579
		RoguelikeLastInfoRequest = 26510,
		// Token: 0x040015CC RID: 5580
		RoguelikeStartRequest = 29795,
		// Token: 0x040015CD RID: 5581
		RoguelikeQuitRequest = 16370,
		// Token: 0x040015CE RID: 5582
		RoguelikeResultRequest = 21292,
		// Token: 0x040015CF RID: 5583
		RoguelikeGotoNextRoomRequest = 19829,
		// Token: 0x040015D0 RID: 5584
		RoguelikeTalentInfoRequest = 21173,
		// Token: 0x040015D1 RID: 5585
		RoguelikeTalentLevelUpRequest = 26893,
		// Token: 0x040015D2 RID: 5586
		RoguelikeSeasonDataRequest = 22746,
		// Token: 0x040015D3 RID: 5587
		RoguelikeTokenReceiveRequest = 24840,
		// Token: 0x040015D4 RID: 5588
		RoguelikeSeasonRewardReceiveRequest = 16953,
		// Token: 0x040015D5 RID: 5589
		RoguelikeGiveUpGainRequest = 27974,
		// Token: 0x040015D6 RID: 5590
		PbGetRoleListRequest = 26301,
		// Token: 0x040015D7 RID: 5591
		PbUpLevelRoleRequest = 15445,
		// Token: 0x040015D8 RID: 5592
		PbOverRoleRequest = 18138,
		// Token: 0x040015D9 RID: 5593
		PbUpLevelSkillRequest = 22382,
		// Token: 0x040015DA RID: 5594
		RoleLevelUpViewRequest = 19849,
		// Token: 0x040015DB RID: 5595
		RoleBreakThroughViewRequest = 25405,
		// Token: 0x040015DC RID: 5596
		RoleSkillLevelUpViewRequest = 18841,
		// Token: 0x040015DD RID: 5597
		RoleSkillViewRequest = 26728,
		// Token: 0x040015DE RID: 5598
		RoleActivateSkillRequest = 20952,
		// Token: 0x040015DF RID: 5599
		ResonantChainUnlockRequest = 15098,
		// Token: 0x040015E0 RID: 5600
		RoleSexChangeRequest = 24765,
		// Token: 0x040015E1 RID: 5601
		RoleElementChangeRequest = 20709,
		// Token: 0x040015E2 RID: 5602
		TrialRoleRewardRequest = 28460,
		// Token: 0x040015E3 RID: 5603
		CaptureEntityRequest = 15078,
		// Token: 0x040015E4 RID: 5604
		RemoveSummonEntityRequest = 18845,
		// Token: 0x040015E5 RID: 5605
		ChangeEntityRoleRequest = 24583,
		// Token: 0x040015E6 RID: 5606
		EntityOnLandedRequest = 25532,
		// Token: 0x040015E7 RID: 5607
		AttributeInitRequest = 22401,
		// Token: 0x040015E8 RID: 5608
		AttributeChangedRequest = 17782,
		// Token: 0x040015E9 RID: 5609
		AnimationStateInitRequest = 16475,
		// Token: 0x040015EA RID: 5610
		AnimationStateChangedRequest = 26812,
		// Token: 0x040015EB RID: 5611
		HardnessModeChangedRequest = 18173,
		// Token: 0x040015EC RID: 5612
		SummonRequest = 27379,
		// Token: 0x040015ED RID: 5613
		Summon2Request = 19448,
		// Token: 0x040015EE RID: 5614
		RemoveInstanceTimerRequest = 26557,
		// Token: 0x040015EF RID: 5615
		UpdateSceneDateRequest = 15194,
		// Token: 0x040015F0 RID: 5616
		DiscardWeaponRequest = 15239,
		// Token: 0x040015F1 RID: 5617
		CreatStoryCharacterRequest = 24716,
		// Token: 0x040015F2 RID: 5618
		DeleteStoryCharacterRequest = 27194,
		// Token: 0x040015F3 RID: 5619
		CreatureDetailRequest = 19517,
		// Token: 0x040015F4 RID: 5620
		ChangeEntityStateRequest = 22928,
		// Token: 0x040015F5 RID: 5621
		FoundationRequest = 24967,
		// Token: 0x040015F6 RID: 5622
		BeControlledRequest = 24899,
		// Token: 0x040015F7 RID: 5623
		BeControlledShowRequest = 15548,
		// Token: 0x040015F8 RID: 5624
		BeControlledThrowRequest = 17791,
		// Token: 0x040015F9 RID: 5625
		GravityGearRequest = 21311,
		// Token: 0x040015FA RID: 5626
		ChangeWeatherRequest = 25213,
		// Token: 0x040015FB RID: 5627
		FollowTrackRequest = 15030,
		// Token: 0x040015FC RID: 5628
		SetInitTagRequest = 23652,
		// Token: 0x040015FD RID: 5629
		DrownRequest = 18070,
		// Token: 0x040015FE RID: 5630
		DrownEndTeleportRequest = 20649,
		// Token: 0x040015FF RID: 5631
		MonsterDrownRequest = 21217,
		// Token: 0x04001600 RID: 5632
		SceneLoadingFinishRequest = 20048,
		// Token: 0x04001601 RID: 5633
		SitChairRequest = 25632,
		// Token: 0x04001602 RID: 5634
		BeControlledDestroyRequest = 22559,
		// Token: 0x04001603 RID: 5635
		ChangeDataLayerFinishRequest = 27553,
		// Token: 0x04001604 RID: 5636
		MoveSceneItemResetPositionRequest = 16218,
		// Token: 0x04001605 RID: 5637
		HookLockPointRequest = 18814,
		// Token: 0x04001606 RID: 5638
		CheckGearRequest = 26428,
		// Token: 0x04001607 RID: 5639
		SceneItemStateRequest = 29477,
		// Token: 0x04001608 RID: 5640
		MaterialRequest = 18588,
		// Token: 0x04001609 RID: 5641
		CommonOrganResetTimeRequest = 27765,
		// Token: 0x0400160A RID: 5642
		TargetGearHitRequest = 15247,
		// Token: 0x0400160B RID: 5643
		ThrowDamageRequest = 28170,
		// Token: 0x0400160C RID: 5644
		GetRewardTreasureBoxRequest = 24443,
		// Token: 0x0400160D RID: 5645
		MobileButtonSettingUpdateRequest = 17995,
		// Token: 0x0400160E RID: 5646
		LanguageSettingUpdateRequest = 15385,
		// Token: 0x0400160F RID: 5647
		ShopInfoRequest = 17320,
		// Token: 0x04001610 RID: 5648
		ShopBuyRequest = 16667,
		// Token: 0x04001611 RID: 5649
		ShopUpdateRequest = 17990,
		// Token: 0x04001612 RID: 5650
		SneakFinishRequest = 20117,
		// Token: 0x04001613 RID: 5651
		SpecialItemEquipRequest = 25881,
		// Token: 0x04001614 RID: 5652
		SpecialItemUnEquipRequest = 22601,
		// Token: 0x04001615 RID: 5653
		SynthesisInfoRequest = 21275,
		// Token: 0x04001616 RID: 5654
		SynthesisItemRequest = 17552,
		// Token: 0x04001617 RID: 5655
		SynthesisLevelRewardRequest = 17671,
		// Token: 0x04001618 RID: 5656
		SynthesisFormulaUnlockRequest = 23907,
		// Token: 0x04001619 RID: 5657
		TeleportDataRequest = 22238,
		// Token: 0x0400161A RID: 5658
		TeleportTransferRequest = 29918,
		// Token: 0x0400161B RID: 5659
		TeleportFinishRequest = 23654,
		// Token: 0x0400161C RID: 5660
		UnOpenedAreaPullbackRequest = 22608,
		// Token: 0x0400161D RID: 5661
		RemoveTemporaryTeleportRequest = 29103,
		// Token: 0x0400161E RID: 5662
		TeleportToTargetRequest = 20294,
		// Token: 0x0400161F RID: 5663
		ThirdPartyShareRequest = 27585,
		// Token: 0x04001620 RID: 5664
		RTimeStopRequest = 17578,
		// Token: 0x04001621 RID: 5665
		RTimeStopInstRequest = 21786,
		// Token: 0x04001622 RID: 5666
		TimelineTraceStartRequest = 17394,
		// Token: 0x04001623 RID: 5667
		TimelineTraceControlRequest = 17862,
		// Token: 0x04001624 RID: 5668
		TimelineTraceExitRequest = 24811,
		// Token: 0x04001625 RID: 5669
		TimeCheckRequest = 28306,
		// Token: 0x04001626 RID: 5670
		TowerRequest = 20908,
		// Token: 0x04001627 RID: 5671
		TowerSeasonUpdateRequest = 20997,
		// Token: 0x04001628 RID: 5672
		TowerFormationRecommendRequest = 16517,
		// Token: 0x04001629 RID: 5673
		TowerRewardRequest = 21982,
		// Token: 0x0400162A RID: 5674
		TowerStartRequest = 27135,
		// Token: 0x0400162B RID: 5675
		TowerResetRequest = 19406,
		// Token: 0x0400162C RID: 5676
		TowerApplyFloorDataRequest = 25005,
		// Token: 0x0400162D RID: 5677
		TowerGuideActivityRewardRequest = 28023,
		// Token: 0x0400162E RID: 5678
		TowerGuideActivityInfoRequest = 15265,
		// Token: 0x0400162F RID: 5679
		TurntableCompleteRequest = 17646,
		// Token: 0x04001630 RID: 5680
		TutorialInfoRequest = 15592,
		// Token: 0x04001631 RID: 5681
		TutorialReceiveRequest = 25497,
		// Token: 0x04001632 RID: 5682
		TutorialUnlockRequest = 26906,
		// Token: 0x04001633 RID: 5683
		WeaponLevelUpRequest = 28155,
		// Token: 0x04001634 RID: 5684
		WeaponBreachRequest = 17857,
		// Token: 0x04001635 RID: 5685
		WeaponResonUpRequest = 27212,
		// Token: 0x04001636 RID: 5686
		WorldLevelDownRequest = 16824,
		// Token: 0x04001637 RID: 5687
		WorldLevelRegainRequest = 20287,
		// Token: 0x04001638 RID: 5688
		WorldEnterPermissionsRequest = 24417,
		// Token: 0x04001639 RID: 5689
		ApplyJoinWorldRequest = 26630,
		// Token: 0x0400163A RID: 5690
		AgreeJoinResultRequest = 23449,
		// Token: 0x0400163B RID: 5691
		LobbyListRequest = 27091,
		// Token: 0x0400163C RID: 5692
		LobbyQueryPlayersRequest = 27293,
		// Token: 0x0400163D RID: 5693
		LeaveWorldTeamRequest = 25798,
		// Token: 0x0400163E RID: 5694
		KickWorldTeamRequest = 23500,
		// Token: 0x0400163F RID: 5695
		EntityBeamReceiveRequest = 27206,
		// Token: 0x04001640 RID: 5696
		AttachEntityRequest = 22935,
		// Token: 0x04001641 RID: 5697
		EntityPatrolAddTagRequest = 24527,
		// Token: 0x04001642 RID: 5698
		LongShanTaskRewardRequest = 25899,
		// Token: 0x04001643 RID: 5699
		EntityAccessRangeRequest = 23148,
		// Token: 0x04001644 RID: 5700
		PlayerAccessRangeRequest = 26712,
		// Token: 0x04001645 RID: 5701
		RoguelikePopularEntriesInfoRequest = 29132,
		// Token: 0x04001646 RID: 5702
		RoguelikePopularEntriesChangeRequest = 19865,
		// Token: 0x04001647 RID: 5703
		HookLockPointFinishRequest = 17312,
		// Token: 0x04001648 RID: 5704
		BuildingLevelUpRequest = 28202,
		// Token: 0x04001649 RID: 5705
		RoleTrainRequest = 22959,
		// Token: 0x0400164A RID: 5706
		AcceptEntrustRequest = 15620,
		// Token: 0x0400164B RID: 5707
		InvestRequest = 20937,
		// Token: 0x0400164C RID: 5708
		TrackMoonEntrustDataRequest = 21209,
		// Token: 0x0400164D RID: 5709
		TrackMoonRoleDataRequest = 15705,
		// Token: 0x0400164E RID: 5710
		RunTurntableActivityRequest = 15475,
		// Token: 0x0400164F RID: 5711
		TrackMoonBuildingDataRequest = 15645,
		// Token: 0x04001650 RID: 5712
		BuildingUnLockRequest = 20679,
		// Token: 0x04001651 RID: 5713
		BossRushClaimRewardRequest = 29802,
		// Token: 0x04001652 RID: 5714
		BossRushSettlementRequest = 24466,
		// Token: 0x04001653 RID: 5715
		SceneModeChangeFinishRequest = 19453,
		// Token: 0x04001654 RID: 5716
		RoguelikeTrialRoleInfoRequest = 18768,
		// Token: 0x04001655 RID: 5717
		PhotoMemoryRequest = 16350,
		// Token: 0x04001656 RID: 5718
		PhotoMemoryRewardRequest = 15289,
		// Token: 0x04001657 RID: 5719
		SceneItemSetPosSenderRequest = 19577,
		// Token: 0x04001658 RID: 5720
		TraceEntityPosRequest = 16467,
		// Token: 0x04001659 RID: 5721
		CombatMessagePrefixInfoRequest = 21140,
		// Token: 0x0400165A RID: 5722
		CombatMessagePostInfoRequest = 15505,
		// Token: 0x0400165B RID: 5723
		TrackMoonTargetRewardRequest = 17884,
		// Token: 0x0400165C RID: 5724
		FsmStateBehaviorRequest = 15369,
		// Token: 0x0400165D RID: 5725
		FsmPlayMontageRequest = 25452,
		// Token: 0x0400165E RID: 5726
		RTimeStopAnimRequest = 28204,
		// Token: 0x0400165F RID: 5727
		RolePropRequest = 22020,
		// Token: 0x04001660 RID: 5728
		TrackMoonSettleRequest = 22986,
		// Token: 0x04001661 RID: 5729
		TrackMoonIllustratedRequest = 18233,
		// Token: 0x04001662 RID: 5730
		TowerDefenceInstanceRewardRequest = 28922,
		// Token: 0x04001663 RID: 5731
		TowerDefenceScoreRewardRequest = 17847,
		// Token: 0x04001664 RID: 5732
		FlowTeleportToPlotPosRequest = 16785,
		// Token: 0x04001665 RID: 5733
		ConnectorConnectEntityRequest = 29122,
		// Token: 0x04001666 RID: 5734
		BeControlledEntityHoverRequest = 15453,
		// Token: 0x04001667 RID: 5735
		InitRangeRequest = 29050,
		// Token: 0x04001668 RID: 5736
		TrackMoonActivityRewardRequest = 26656,
		// Token: 0x04001669 RID: 5737
		TimePointActivityRewardRequest = 21232,
		// Token: 0x0400166A RID: 5738
		CircumFluenceTaskRewardRequest = 17180,
		// Token: 0x0400166B RID: 5739
		GameplayCueRequest = 20103,
		// Token: 0x0400166C RID: 5740
		SceneItemStopRequest = 26861,
		// Token: 0x0400166D RID: 5741
		RoguelikeRoleRoomSelectRequest = 26267,
		// Token: 0x0400166E RID: 5742
		SecFBRoundStartFlowRequest = 28936,
		// Token: 0x0400166F RID: 5743
		SecGetReportData2FlowRequest = 27333,
		// Token: 0x04001670 RID: 5744
		SecFBRoundEndFlowReportRequest = 28654,
		// Token: 0x04001671 RID: 5745
		SecRoleFightFlowRequest = 23744,
		// Token: 0x04001672 RID: 5746
		SecWorldInfoFlowRequest = 18083,
		// Token: 0x04001673 RID: 5747
		SecWorldStartFlowRequest = 18243,
		// Token: 0x04001674 RID: 5748
		SecWorldSEndFlowRequest = 23884,
		// Token: 0x04001675 RID: 5749
		AwakeDynamicPortalRequest = 25931,
		// Token: 0x04001676 RID: 5750
		GachaPoolDetailRequest = 28380,
		// Token: 0x04001677 RID: 5751
		OpenSystemBoardResultRequest = 20900,
		// Token: 0x04001678 RID: 5752
		SceneItemMoveTargetRequest = 20302,
		// Token: 0x04001679 RID: 5753
		TrackMoonBuildFlowRequest = 18395,
		// Token: 0x0400167A RID: 5754
		CorniceMeetingRewardRequest = 26725,
		// Token: 0x0400167B RID: 5755
		TraceMoonPhaseRewardRequest = 15762,
		// Token: 0x0400167C RID: 5756
		LevelPlaySwitchSportModeRequest = 19509,
		// Token: 0x0400167D RID: 5757
		PlayerPsnInfoGetRequest = 20153,
		// Token: 0x0400167E RID: 5758
		PsnSettingUpdateRequest = 19585,
		// Token: 0x0400167F RID: 5759
		PsnSettingRequest = 24714,
		// Token: 0x04001680 RID: 5760
		RiskHarvestInstRewardRequest = 27572,
		// Token: 0x04001681 RID: 5761
		RiskHarvestScoreRewardRequest = 21426,
		// Token: 0x04001682 RID: 5762
		ItemDisuseRequest = 23288,
		// Token: 0x04001683 RID: 5763
		PhantomBatchRefiningRequest = 15619,
		// Token: 0x04001684 RID: 5764
		PassPortalRequest = 26467,
		// Token: 0x04001685 RID: 5765
		EnrichmentAreaRequest = 29419,
		// Token: 0x04001686 RID: 5766
		RiskHarvestBuffUnlockRewardRequest = 28209,
		// Token: 0x04001687 RID: 5767
		RiskHarvestBuffCountRewardRequest = 15493,
		// Token: 0x04001688 RID: 5768
		BlackCoastThemeTaskRewardRequest = 22379,
		// Token: 0x04001689 RID: 5769
		BlackCoastThemeActiveRewardRequest = 23707,
		// Token: 0x0400168A RID: 5770
		PlayerCreatePsnSessionRequest = 29372,
		// Token: 0x0400168B RID: 5771
		RenjuResetRequest = 20123,
		// Token: 0x0400168C RID: 5772
		CorniceChallengeTransRequest = 29837,
		// Token: 0x0400168D RID: 5773
		GameplayTagRequest = 25844,
		// Token: 0x0400168E RID: 5774
		ExecuteQteRequest = 29269,
		// Token: 0x0400168F RID: 5775
		RiskHarvestSettleRequest = 18062,
		// Token: 0x04001690 RID: 5776
		MingSuHandRewardRequest = 28128,
		// Token: 0x04001691 RID: 5777
		SubmitAwakeAndLoadEntityNodeRequest = 26833,
		// Token: 0x04001692 RID: 5778
		RoguelikeRoleInstStartRequest = 17317,
		// Token: 0x04001693 RID: 5779
		RoguelikeBossInstStartRequest = 23564,
		// Token: 0x04001694 RID: 5780
		PreheatSignRewardRequest = 29281,
		// Token: 0x04001695 RID: 5781
		PreheatSignSurveyInfoRequest = 16302,
		// Token: 0x04001696 RID: 5782
		DarkCoastInfoRequest = 29597,
		// Token: 0x04001697 RID: 5783
		InputSettingRequest = 17784,
		// Token: 0x04001698 RID: 5784
		InputSettingUpdateRequest = 29143,
		// Token: 0x04001699 RID: 5785
		RoguelikeWriteCatRewardRequest = 25605,
		// Token: 0x0400169A RID: 5786
		ConnectorCanConnectRequest = 19355,
		// Token: 0x0400169B RID: 5787
		ScratchCardRewardRequest = 28502,
		// Token: 0x0400169C RID: 5788
		TeleportDungeonActionRequest = 25153,
		// Token: 0x0400169D RID: 5789
		SubmitWalkingPatternPointRequest = 25883,
		// Token: 0x0400169E RID: 5790
		RoguelikeWriteCatBossRewardRequest = 25187,
		// Token: 0x0400169F RID: 5791
		RoguelikeWriteCatLevelPlayRewardRequest = 24513,
		// Token: 0x040016A0 RID: 5792
		PlayerPsnBlockListRequest = 18200,
		// Token: 0x040016A1 RID: 5793
		VacuumCleanerRequest = 23579,
		// Token: 0x040016A2 RID: 5794
		BossRushChooseBuffRequest = 24869,
		// Token: 0x040016A3 RID: 5795
		BossRushBuffChooseResultRequest = 23993,
		// Token: 0x040016A4 RID: 5796
		JoinSceneNotifyConfirmRequest = 27120,
		// Token: 0x040016A5 RID: 5797
		MailBindInfoRequest = 26354,
		// Token: 0x040016A6 RID: 5798
		MailBindRewardRequest = 26509,
		// Token: 0x040016A7 RID: 5799
		MailBindRequest = 25162,
		// Token: 0x040016A8 RID: 5800
		HookLockPointExitRequest = 28147,
		// Token: 0x040016A9 RID: 5801
		VehicleRequest = 29971,
		// Token: 0x040016AA RID: 5802
		PullingFoundationRequest = 25845,
		// Token: 0x040016AB RID: 5803
		AddTreasureBoxSlotRequest = 24696,
		// Token: 0x040016AC RID: 5804
		RemoveTreasureBoxSlotRequest = 15750,
		// Token: 0x040016AD RID: 5805
		UseSoundBoxSkillRequest = 26214,
		// Token: 0x040016AE RID: 5806
		AddTemporaryTeleportRequest = 29476,
		// Token: 0x040016AF RID: 5807
		BossRushLevelScoreRewardRequest = 23421,
		// Token: 0x040016B0 RID: 5808
		EquipSkinTakeOnRequest = 26203,
		// Token: 0x040016B1 RID: 5809
		EquipSkinUnLoadRequest = 16068,
		// Token: 0x040016B2 RID: 5810
		SubmitPhotoNodeRequest = 25793,
		// Token: 0x040016B3 RID: 5811
		RogueWhiteCatLimitedRewardRequest = 18506,
		// Token: 0x040016B4 RID: 5812
		ScratchCardActivityInfoRequest = 28606,
		// Token: 0x040016B5 RID: 5813
		QuestReadyForGiveUpRequest = 19607,
		// Token: 0x040016B6 RID: 5814
		RogueWhiteCatRecordRequest = 23656,
		// Token: 0x040016B7 RID: 5815
		SetAlertUiVisibleRequest = 15594,
		// Token: 0x040016B8 RID: 5816
		CombineEntitiesRequest = 19641,
		// Token: 0x040016B9 RID: 5817
		GiftPackPreviewRequest = 16675,
		// Token: 0x040016BA RID: 5818
		LastBigSceneMiniMapInfoRequest = 16921,
		// Token: 0x040016BB RID: 5819
		DissolveCombineRelationRequest = 21623,
		// Token: 0x040016BC RID: 5820
		ExploreSkillCustomRequest = 25431,
		// Token: 0x040016BD RID: 5821
		AchievementUpdateRequest = 29393,
		// Token: 0x040016BE RID: 5822
		SeamlessTeleportRequest = 28869,
		// Token: 0x040016BF RID: 5823
		RogueBlackFlowerRequest = 29618,
		// Token: 0x040016C0 RID: 5824
		UpdateSceneGroupDataRequest = 23380,
		// Token: 0x040016C1 RID: 5825
		MowTowerSettlementRequest = 25440,
		// Token: 0x040016C2 RID: 5826
		MowTowerLevelsRewardRequest = 27598,
		// Token: 0x040016C3 RID: 5827
		RoleSkinChangeRequest = 25393,
		// Token: 0x040016C4 RID: 5828
		RoleSkinRequest = 23414,
		// Token: 0x040016C5 RID: 5829
		PhantomMusicUnlockRequest = 15391,
		// Token: 0x040016C6 RID: 5830
		PhantomMusicInfoRequest = 19247,
		// Token: 0x040016C7 RID: 5831
		PhantomMusicSwitchRequest = 27185,
		// Token: 0x040016C8 RID: 5832
		UpdateSceneItemBlackboardRequest = 20774,
		// Token: 0x040016C9 RID: 5833
		VehicleChangePassengerRequest = 21416,
		// Token: 0x040016CA RID: 5834
		VehicleRemovePassengerRequest = 22646,
		// Token: 0x040016CB RID: 5835
		LevelSequenceFrameEventActionRequest = 24567,
		// Token: 0x040016CC RID: 5836
		SimpleTrackReportRequest = 26465,
		// Token: 0x040016CD RID: 5837
		PlayerVoxelEnvRequest = 18071,
		// Token: 0x040016CE RID: 5838
		MapTravelFullRewardRequest = 25797,
		// Token: 0x040016CF RID: 5839
		MapTravelLevelUpRequest = 25161,
		// Token: 0x040016D0 RID: 5840
		SpringSignDrawRoleRequest = 26720,
		// Token: 0x040016D1 RID: 5841
		LevelPlayVarRequest = 15438,
		// Token: 0x040016D2 RID: 5842
		MaterialReplaceRequest = 16956,
		// Token: 0x040016D3 RID: 5843
		ExploreProgressRewardRequest = 17400,
		// Token: 0x040016D4 RID: 5844
		SpringSignDrawRewardRequest = 15126,
		// Token: 0x040016D5 RID: 5845
		EntityCameraAlertRequest = 27538,
		// Token: 0x040016D6 RID: 5846
		ThroughTrainRequest = 15113,
		// Token: 0x040016D7 RID: 5847
		FarmGoldLevelDiffRequest = 28967,
		// Token: 0x040016D8 RID: 5848
		CheckUseSoundBoxSkillRequest = 24052,
		// Token: 0x040016D9 RID: 5849
		FarmGoldPointRequest = 18106,
		// Token: 0x040016DA RID: 5850
		FarmGoldLevelPlayRequest = 28418,
		// Token: 0x040016DB RID: 5851
		SpringSignSkinRewardRequest = 16596,
		// Token: 0x040016DC RID: 5852
		FarmGoldResultRequest = 29811,
		// Token: 0x040016DD RID: 5853
		FlowSeqSetPlayerPosRequest = 21021,
		// Token: 0x040016DE RID: 5854
		SplineMoveRequest = 16693,
		// Token: 0x040016DF RID: 5855
		LevelPlayStateRequest = 19230,
		// Token: 0x040016E0 RID: 5856
		PlayerHeadRequest = 26575,
		// Token: 0x040016E1 RID: 5857
		EntityWalkingPatternFinishRequest = 24720,
		// Token: 0x040016E2 RID: 5858
		QueryOnlinePlayersAreaRequest = 18422,
		// Token: 0x040016E3 RID: 5859
		MapTravelTaskRewardRequest = 19004,
		// Token: 0x040016E4 RID: 5860
		MapTravelSoarRewardRequest = 21758,
		// Token: 0x040016E5 RID: 5861
		FishingInfoRequest = 17766,
		// Token: 0x040016E6 RID: 5862
		FishingIllustratedRewardRequest = 16271,
		// Token: 0x040016E7 RID: 5863
		FishingCabinPutRequest = 25860,
		// Token: 0x040016E8 RID: 5864
		FishingQuickSellPreviewRequest = 18031,
		// Token: 0x040016E9 RID: 5865
		FishingQuickSellRequest = 23963,
		// Token: 0x040016EA RID: 5866
		FishingSellPreviewRequest = 20524,
		// Token: 0x040016EB RID: 5867
		FishingSellRequest = 27511,
		// Token: 0x040016EC RID: 5868
		FishingSailingRequest = 23442,
		// Token: 0x040016ED RID: 5869
		FishingEntrustHandInRequest = 22195,
		// Token: 0x040016EE RID: 5870
		FishingEntrustTraceRequest = 26469,
		// Token: 0x040016EF RID: 5871
		FishingEntrustRefreshRequest = 25644,
		// Token: 0x040016F0 RID: 5872
		FishingShipFixRequest = 19300,
		// Token: 0x040016F1 RID: 5873
		FishingTechLevelUpRequest = 16447,
		// Token: 0x040016F2 RID: 5874
		AccessPathConfigRequest = 16883,
		// Token: 0x040016F3 RID: 5875
		PlayerGameTokenRequest = 23683,
		// Token: 0x040016F4 RID: 5876
		RenjuExitMatchedActionRequest = 20413,
		// Token: 0x040016F5 RID: 5877
		TrialRoleSkinRewardRequest = 19389,
		// Token: 0x040016F6 RID: 5878
		LevelPlayStateListRequest = 25471,
		// Token: 0x040016F7 RID: 5879
		SpringSignPhotoRewardRequest = 25857,
		// Token: 0x040016F8 RID: 5880
		PhantomEquipGroupInfosRequest = 18533,
		// Token: 0x040016F9 RID: 5881
		AddPhantomEquipGroupRequest = 24382,
		// Token: 0x040016FA RID: 5882
		DeletePhantomEquipGroupRequest = 26973,
		// Token: 0x040016FB RID: 5883
		TopPhantomEquipGroupRequest = 20387,
		// Token: 0x040016FC RID: 5884
		ChangePhantomEquipGroupNameRequest = 18119,
		// Token: 0x040016FD RID: 5885
		FishingCompleteRequest = 29131,
		// Token: 0x040016FE RID: 5886
		TeleportFlowEndRequest = 21234,
		// Token: 0x040016FF RID: 5887
		RiskHarvestStarRewardRequest = 24832,
		// Token: 0x04001700 RID: 5888
		PhantomFetterRecommendRequest = 15990,
		// Token: 0x04001701 RID: 5889
		PhantomAttrRecommendRequest = 29865,
		// Token: 0x04001702 RID: 5890
		FishingEntrustAcceptRequest = 21980,
		// Token: 0x04001703 RID: 5891
		FishingExitRequest = 27861,
		// Token: 0x04001704 RID: 5892
		FishingShipSkinChangeRequest = 16229,
		// Token: 0x04001705 RID: 5893
		FishingPointInfoRequest = 24764,
		// Token: 0x04001706 RID: 5894
		FishingCageInfoRequest = 16732,
		// Token: 0x04001707 RID: 5895
		FishingHandInRequest = 26983,
		// Token: 0x04001708 RID: 5896
		FishingSkillBombRequest = 15602,
		// Token: 0x04001709 RID: 5897
		FishingSkillBaitRequest = 19403,
		// Token: 0x0400170A RID: 5898
		FishingSkillTeleportRequest = 26598,
		// Token: 0x0400170B RID: 5899
		RogueWeeklyRewardRequest = 21313,
		// Token: 0x0400170C RID: 5900
		RogueWeeklyGotoNextRoomRequest = 19170,
		// Token: 0x0400170D RID: 5901
		SlashAndTowerInfoRequest = 26076,
		// Token: 0x0400170E RID: 5902
		SlashAndTowerScoreRewardRequest = 28028,
		// Token: 0x0400170F RID: 5903
		EndLessHistoryRequest = 24101,
		// Token: 0x04001710 RID: 5904
		SlashAndTowerSaveRecordRequest = 19636,
		// Token: 0x04001711 RID: 5905
		SlashAndTowerResetRequest = 20373,
		// Token: 0x04001712 RID: 5906
		SlashAndTowerRecommendRequest = 22684,
		// Token: 0x04001713 RID: 5907
		BossRushTaskRewardRequest = 27175,
		// Token: 0x04001714 RID: 5908
		UsePhantomEquipGroupRequest = 17437,
		// Token: 0x04001715 RID: 5909
		FishingActivityLimitRewardRequest = 29602,
		// Token: 0x04001716 RID: 5910
		FishingActivityMilestoneRewardRequest = 20542,
		// Token: 0x04001717 RID: 5911
		TeamParkourRewardRequest = 19176,
		// Token: 0x04001718 RID: 5912
		RogueWeeklyResultRequest = 25097,
		// Token: 0x04001719 RID: 5913
		RogueWeeklyOptionSelectRequest = 20557,
		// Token: 0x0400171A RID: 5914
		ThroughTrainFinishViewRequest = 18707,
		// Token: 0x0400171B RID: 5915
		ActivityPreOpenRequest = 20615,
		// Token: 0x0400171C RID: 5916
		LstBattleRecordRequest = 18253,
		// Token: 0x0400171D RID: 5917
		RogueWeeklyStartRequest = 26066,
		// Token: 0x0400171E RID: 5918
		FishingTeleportToBoatRequest = 28699,
		// Token: 0x0400171F RID: 5919
		TowerDefenceRandListRequest = 19374,
		// Token: 0x04001720 RID: 5920
		TowerDefenceRankShowNameRequest = 21818,
		// Token: 0x04001721 RID: 5921
		BabelTowerTaskRewardRequest = 16805,
		// Token: 0x04001722 RID: 5922
		BabelTowerDailyTaskRewardRequest = 26699,
		// Token: 0x04001723 RID: 5923
		ResetBabelTowerLevelRequest = 20991,
		// Token: 0x04001724 RID: 5924
		BabelTowerSettlementRequest = 25214,
		// Token: 0x04001725 RID: 5925
		RogueWeeklyBlackFlowerRequest = 18903,
		// Token: 0x04001726 RID: 5926
		SceneSubLevelsRequest = 25079,
		// Token: 0x04001727 RID: 5927
		PlayerTitleRequest = 21582,
		// Token: 0x04001728 RID: 5928
		ChangePlayerTitleRequest = 22152,
		// Token: 0x04001729 RID: 5929
		AwakeItemVehicleRequest = 15589,
		// Token: 0x0400172A RID: 5930
		SelectBabelActivityDeTermRequest = 22917,
		// Token: 0x0400172B RID: 5931
		GravityFlipInteractRequest = 16440,
		// Token: 0x0400172C RID: 5932
		AbyssChallengeUnlockRequest = 21327,
		// Token: 0x0400172D RID: 5933
		AbyssChallengeQuitRequest = 15291,
		// Token: 0x0400172E RID: 5934
		AbyssLikeRequest = 16399,
		// Token: 0x0400172F RID: 5935
		AbyssChallengeGotoNextRoomRequest = 20543,
		// Token: 0x04001730 RID: 5936
		AbyssRewardRequest = 18308,
		// Token: 0x04001731 RID: 5937
		AbyssLittleRoleLevelUpRequest = 22340,
		// Token: 0x04001732 RID: 5938
		AbyssPluginPutRequest = 17042,
		// Token: 0x04001733 RID: 5939
		AbyssPluginSynthesisRequest = 22615,
		// Token: 0x04001734 RID: 5940
		AbyssRankListRequest = 26103,
		// Token: 0x04001735 RID: 5941
		AbyssShowNameRequest = 28814,
		// Token: 0x04001736 RID: 5942
		AbyssReviveCharacterRequest = 16144,
		// Token: 0x04001737 RID: 5943
		SceneItemMoveSplineRequest = 24048,
		// Token: 0x04001738 RID: 5944
		RacingBetsLegMatchInfoRequest = 27433,
		// Token: 0x04001739 RID: 5945
		RacingBetsMatchInfoRequest = 15531,
		// Token: 0x0400173A RID: 5946
		RacingBetsPlayerInfoRequest = 23533,
		// Token: 0x0400173B RID: 5947
		RacingBetsRankRequest = 16670,
		// Token: 0x0400173C RID: 5948
		RacingBetsGearRequest = 28576,
		// Token: 0x0400173D RID: 5949
		RacingBetsTaskRequest = 25921,
		// Token: 0x0400173E RID: 5950
		RacingBetsTaskRewardRequest = 16541,
		// Token: 0x0400173F RID: 5951
		RacingBetMatchRoundRequest = 21053,
		// Token: 0x04001740 RID: 5952
		RacingBetsBulletScreenRequest = 29326,
		// Token: 0x04001741 RID: 5953
		RogueWeeklyLastInfoRequest = 29824,
		// Token: 0x04001742 RID: 5954
		RacingBetsUpdateOddsRequest = 28583,
		// Token: 0x04001743 RID: 5955
		ExploreActivityTaskRewardRequest = 28364,
		// Token: 0x04001744 RID: 5956
		PhantomPolishRequest = 28425,
		// Token: 0x04001745 RID: 5957
		TowerDefenceSelfPassRequest = 21596,
		// Token: 0x04001746 RID: 5958
		AbyssSelfPassRequest = 19384,
		// Token: 0x04001747 RID: 5959
		RogueResTalentSkillLevelRequest = 18391,
		// Token: 0x04001748 RID: 5960
		RogueResEndingRewardRequest = 25016,
		// Token: 0x04001749 RID: 5961
		RogueResTaskAwardRequest = 24996,
		// Token: 0x0400174A RID: 5962
		RogueResIllustrationAwardRequest = 28613,
		// Token: 0x0400174B RID: 5963
		AvignonRewardRequest = 23689,
		// Token: 0x0400174C RID: 5964
		RogueResMoveRequest = 24363,
		// Token: 0x0400174D RID: 5965
		RogueResGridEventRequest = 20462,
		// Token: 0x0400174E RID: 5966
		RogueResOpDoneRequest = 23138,
		// Token: 0x0400174F RID: 5967
		RogueResInstStartRequest = 16991,
		// Token: 0x04001750 RID: 5968
		RogueResInstResultRequest = 19690,
		// Token: 0x04001751 RID: 5969
		RogueResLastInstInfoRequest = 18322,
		// Token: 0x04001752 RID: 5970
		RacingBetsGearRefundRequest = 19077,
		// Token: 0x04001753 RID: 5971
		SummonRandomRequest = 18382,
		// Token: 0x04001754 RID: 5972
		StopMoveSplineRequest = 26851,
		// Token: 0x04001755 RID: 5973
		FlySkinWearRequest = 15148,
		// Token: 0x04001756 RID: 5974
		FlySkinWearAllRoleRequest = 19185,
		// Token: 0x04001757 RID: 5975
		RogueResGotoNextRoomRequest = 15168,
		// Token: 0x04001758 RID: 5976
		FlySkinUnLoadRequest = 20032,
		// Token: 0x04001759 RID: 5977
		DangoMonopolyDiceRequest = 28626,
		// Token: 0x0400175A RID: 5978
		DangoMonopolyGridRewardRequest = 20431,
		// Token: 0x0400175B RID: 5979
		DangoMonopolyBoardRewardRequest = 27429,
		// Token: 0x0400175C RID: 5980
		DangoMonopolyTaskRewardRequest = 25756,
		// Token: 0x0400175D RID: 5981
		RacingBetMatchRequest = 19337,
		// Token: 0x0400175E RID: 5982
		LoadingLevelAreaRequest = 24141,
		// Token: 0x0400175F RID: 5983
		DangoMonopolyNextBoardRequest = 26450,
		// Token: 0x04001760 RID: 5984
		AddChapterResultRequest = 21695,
		// Token: 0x04001761 RID: 5985
		ChapterResultRewardRequest = 20453,
		// Token: 0x04001762 RID: 5986
		InspirationUnlockChoiceRequest = 29979,
		// Token: 0x04001763 RID: 5987
		ActivityResultRewardRequest = 16280,
		// Token: 0x04001764 RID: 5988
		ScheduleRewardRequest = 18448,
		// Token: 0x04001765 RID: 5989
		FlySkinAllUnLoadRequest = 17550,
		// Token: 0x04001766 RID: 5990
		RogueResChangeFormationRequest = 28484,
		// Token: 0x04001767 RID: 5991
		RegressBonusRequest = 24329,
		// Token: 0x04001768 RID: 5992
		RegressTaskRequest = 21404,
		// Token: 0x04001769 RID: 5993
		ConfirmQuestResourceRequest = 27492,
		// Token: 0x0400176A RID: 5994
		ConsumptiveRewardRequest = 28551,
		// Token: 0x0400176B RID: 5995
		LinkageRewardRequest = 16047,
		// Token: 0x0400176C RID: 5996
		RacingBetMatchActionRequest = 17379,
		// Token: 0x0400176D RID: 5997
		RacingBetMatchRoundActionRequest = 28283,
		// Token: 0x0400176E RID: 5998
		RogueResSwitchFormationRequest = 28562,
		// Token: 0x0400176F RID: 5999
		RacingBetMatchInfoRequest = 28035,
		// Token: 0x04001770 RID: 6000
		PhantomBattleTaskRewardRequest = 29515,
		// Token: 0x04001771 RID: 6001
		PhantomBattleMasterLevelRewardRequest = 28662,
		// Token: 0x04001772 RID: 6002
		PhantomBattleBadgeRewardRequest = 25505,
		// Token: 0x04001773 RID: 6003
		PhantomBattleCardOutLookUpRequest = 28432,
		// Token: 0x04001774 RID: 6004
		PhantomBattleCardRewardRequest = 21697,
		// Token: 0x04001775 RID: 6005
		PhantomBattleRoleRewardRequest = 26163,
		// Token: 0x04001776 RID: 6006
		PhantomBattleCardGroupAddRequest = 19376,
		// Token: 0x04001777 RID: 6007
		PhantomBattleCardGroupUpdateRequest = 20057,
		// Token: 0x04001778 RID: 6008
		PhantomBattleCardGroupNameRequest = 25885,
		// Token: 0x04001779 RID: 6009
		PhantomBattleDealCardReplaceRequest = 23882,
		// Token: 0x0400177A RID: 6010
		PhantomBattleEnterSlotRequest = 16359,
		// Token: 0x0400177B RID: 6011
		PhantomBattleEvolveRequest = 18425,
		// Token: 0x0400177C RID: 6012
		PhantomBattleBackLibraryRequest = 25172,
		// Token: 0x0400177D RID: 6013
		PhantomBattleRoundOverRequest = 24624,
		// Token: 0x0400177E RID: 6014
		PhantomBattleSlotInsteadRequest = 22801,
		// Token: 0x0400177F RID: 6015
		BirthDayCardRoleRequest = 25746,
		// Token: 0x04001780 RID: 6016
		BirthDayRewardRequest = 20245,
		// Token: 0x04001781 RID: 6017
		DirectTrainInfoRequest = 26229,
		// Token: 0x04001782 RID: 6018
		RegressQuestionOpenRequest = 25100,
		// Token: 0x04001783 RID: 6019
		PhantomBattleLeaveSlotRequest = 17547,
		// Token: 0x04001784 RID: 6020
		PhantomBattleSelectTargetRequest = 24025,
		// Token: 0x04001785 RID: 6021
		ConsumptiveActivityInfoRequest = 18867,
		// Token: 0x04001786 RID: 6022
		PhantomBattleCardRoleSkillRequest = 17639,
		// Token: 0x04001787 RID: 6023
		PhantomBattleCardSkillRequest = 15904,
		// Token: 0x04001788 RID: 6024
		SetQuestFocusModeRequest = 29838,
		// Token: 0x04001789 RID: 6025
		CancelQuestFocusModeRequest = 23764,
		// Token: 0x0400178A RID: 6026
		PhantomBattleNpcShowOverRequest = 26102,
		// Token: 0x0400178B RID: 6027
		PhantomBattleBvBLoadingFinishRequest = 21700,
		// Token: 0x0400178C RID: 6028
		PhantomBattleStartRequest = 21680,
		// Token: 0x0400178D RID: 6029
		AcceptFocusWaitQuestRequest = 29846,
		// Token: 0x0400178E RID: 6030
		PhantomBattleDiscardCardRequest = 21509,
		// Token: 0x0400178F RID: 6031
		NavigationFindPathRequest = 24357,
		// Token: 0x04001790 RID: 6032
		PhantomBattleCardGroupDeleteRequest = 22811,
		// Token: 0x04001791 RID: 6033
		QuestReviewInfoRequest = 24599,
		// Token: 0x04001792 RID: 6034
		NewbieCarnivalSwitchRoleRequest = 17631,
		// Token: 0x04001793 RID: 6035
		NewbieCarnivalAwardRequest = 17112,
		// Token: 0x04001794 RID: 6036
		PhantomBattleCardSelectRequest = 15431,
		// Token: 0x04001795 RID: 6037
		PhantomBattleCardTargetInfoRequest = 19967,
		// Token: 0x04001796 RID: 6038
		PhantomBattleCardRoleTargetInfoRequest = 21677,
		// Token: 0x04001797 RID: 6039
		PhantomBattleCardUnlockRequest = 25809,
		// Token: 0x04001798 RID: 6040
		OccupyRewardRequest = 20644,
		// Token: 0x04001799 RID: 6041
		SetQuestResourceStateRequest = 29385,
		// Token: 0x0400179A RID: 6042
		LongShanScoreRewardRequest = 17915,
		// Token: 0x0400179B RID: 6043
		BathChangeCameraRequest = 29105,
		// Token: 0x0400179C RID: 6044
		BathPhotoRequest = 26824,
		// Token: 0x0400179D RID: 6045
		FinishDownloadQuestResourceRequest = 29854,
		// Token: 0x0400179E RID: 6046
		PhantomBattleBackSlotCardLibraryRequest = 27245,
		// Token: 0x0400179F RID: 6047
		FloroRanchUnlockTechPointRequest = 24158,
		// Token: 0x040017A0 RID: 6048
		FloroRanchRewardTaskRequest = 16221,
		// Token: 0x040017A1 RID: 6049
		FloroRanchRewardMilestoneRequest = 27873,
		// Token: 0x040017A2 RID: 6050
		FloroRanchStartPlayRequest = 16910,
		// Token: 0x040017A3 RID: 6051
		FloroRanchSettleRequest = 28679,
		// Token: 0x040017A4 RID: 6052
		FloroRanchPlayNextDayRequest = 29541,
		// Token: 0x040017A5 RID: 6053
		FloroRanchPlayGachaRequest = 24204,
		// Token: 0x040017A6 RID: 6054
		FloroRanchPlayShopBuyRequest = 16947,
		// Token: 0x040017A7 RID: 6055
		FloroRanchPlayEventChoiceRequest = 23181,
		// Token: 0x040017A8 RID: 6056
		FloroRanchPlayTributeRequest = 27731,
		// Token: 0x040017A9 RID: 6057
		FloroRanchPlayUnlimitedModeRequest = 23389,
		// Token: 0x040017AA RID: 6058
		KcpConvRequest = 3728,
		// Token: 0x040017AB RID: 6059
		ActionOperationScreenSuccessRequest = 20776,
		// Token: 0x040017AC RID: 6060
		PhantomBattleSelectReserveCardRequest = 20746,
		// Token: 0x040017AD RID: 6061
		FloroRanchPlayRemoveUnitRequest = 22961,
		// Token: 0x040017AE RID: 6062
		PhantomBattleSlotCardSkillRequest = 22653,
		// Token: 0x040017AF RID: 6063
		ConstructTrapRequest = 21336,
		// Token: 0x040017B0 RID: 6064
		DeconstructTrapRequest = 15715,
		// Token: 0x040017B1 RID: 6065
		PhantomBattleReChallengeRequest = 23304,
		// Token: 0x040017B2 RID: 6066
		FloroRanchPlayRefreshShopRequest = 25019,
		// Token: 0x040017B3 RID: 6067
		FloroRanchPlayRefreshGachaRequest = 20257,
		// Token: 0x040017B4 RID: 6068
		PhantomBattleDebugInfoRequest = 24959,
		// Token: 0x040017B5 RID: 6069
		MoralePosRequest = 24392,
		// Token: 0x040017B6 RID: 6070
		RunTestRequest = 20152,
		// Token: 0x040017B7 RID: 6071
		PhantomSettingRequest = 26762,
		// Token: 0x040017B8 RID: 6072
		PhantomSettingUpdateRequest = 26506,
		// Token: 0x040017B9 RID: 6073
		PhantomBatchOperRequest = 29114,
		// Token: 0x040017BA RID: 6074
		VehiclePlatformGetOnRequest = 22526,
		// Token: 0x040017BB RID: 6075
		PolluteGridCellRequest = 18862,
		// Token: 0x040017BC RID: 6076
		LifePointChallengeStartRequest = 20181,
		// Token: 0x040017BD RID: 6077
		FloroRanchPlaySelectCardGroupRequest = 15883,
		// Token: 0x040017BE RID: 6078
		SimpleCombatEntityDieRequest = 25559,
		// Token: 0x040017BF RID: 6079
		MoraleTreasureBoxTraceRequest = 26205,
		// Token: 0x040017C0 RID: 6080
		MulAchievementReceiveRequest = 20609,
		// Token: 0x040017C1 RID: 6081
		MulRoguelikeWriteCatRewardRequest = 27734,
		// Token: 0x040017C2 RID: 6082
		MulRogueWeeklyRewardRequest = 28205,
		// Token: 0x040017C3 RID: 6083
		MulPhantomBattleMasterLevelRewardRequest = 26911,
		// Token: 0x040017C4 RID: 6084
		MulGetAdventureRewardRequest = 15472,
		// Token: 0x040017C5 RID: 6085
		MulCalabashLevelRewardRequest = 27027,
		// Token: 0x040017C6 RID: 6086
		MulExploreScoreRewardRequest = 18094,
		// Token: 0x040017C7 RID: 6087
		MulFishingIllustratedRewardRequest = 23031,
		// Token: 0x040017C8 RID: 6088
		MulMapTravelTaskRewardRequest = 29978,
		// Token: 0x040017C9 RID: 6089
		FloroRanchPlayGachaRefreshRequest = 24913,
		// Token: 0x040017CA RID: 6090
		FloroRanchExecuteSkillPlayRequest = 23150,
		// Token: 0x040017CB RID: 6091
		HoldHandRequest = 26904,
		// Token: 0x040017CC RID: 6092
		TrapDefensePreviewFinishRequest = 26107,
		// Token: 0x040017CD RID: 6093
		FloroRanchSettleDataRequest = 22870,
		// Token: 0x040017CE RID: 6094
		SetFocusModeDeterCondRequest = 27054,
		// Token: 0x040017CF RID: 6095
		LowMemoryChangeSceneFinishRequest = 22050,
		// Token: 0x040017D0 RID: 6096
		RogueWeeklyArtifactInfoRequest = 29939,
		// Token: 0x040017D1 RID: 6097
		RogueWeeklyArtifactSelectRequest = 23037,
		// Token: 0x040017D2 RID: 6098
		TrapDefenseRefreshGainingGroupRequest = 27268,
		// Token: 0x040017D3 RID: 6099
		TrapDefenseSelectGainingGroupRequest = 23459,
		// Token: 0x040017D4 RID: 6100
		TrapDefenseTechUnlockRequest = 28920,
		// Token: 0x040017D5 RID: 6101
		TrapDefenseGetRewardRequest = 21539,
		// Token: 0x040017D6 RID: 6102
		TrapDefenseGetSpecialRewardRequest = 15114,
		// Token: 0x040017D7 RID: 6103
		TrapDefenseBuildingLevelUpRequest = 26196,
		// Token: 0x040017D8 RID: 6104
		TrapDefenseBuildingBranchRequest = 27569,
		// Token: 0x040017D9 RID: 6105
		TrapDefenseAuxiliaryLevelUpRequest = 25960,
		// Token: 0x040017DA RID: 6106
		TrapDefenseAuxiliaryBranchRequest = 19295,
		// Token: 0x040017DB RID: 6107
		FunPlayChallengeAwardRequest = 24156,
		// Token: 0x040017DC RID: 6108
		LevelPlayOpenRequest = 16306,
		// Token: 0x040017DD RID: 6109
		TrapDefenseChallengeQuitRequest = 17166,
		// Token: 0x040017DE RID: 6110
		TrapDefenseBuildingResetRequest = 19127,
		// Token: 0x040017DF RID: 6111
		TrapDefenseAuxiliaryResetRequest = 17701,
		// Token: 0x040017E0 RID: 6112
		TrapDefenseDevelopResetRequest = 22176,
		// Token: 0x040017E1 RID: 6113
		ExploreEntityTraceRequest = 29165,
		// Token: 0x040017E2 RID: 6114
		CommonTouchUiSettingUpdateRequest = 20368,
		// Token: 0x040017E3 RID: 6115
		TrapDefenseSlotUpdateRequest = 29634,
		// Token: 0x040017E4 RID: 6116
		SceneItemSequenceFrameEndRequest = 15970,
		// Token: 0x040017E5 RID: 6117
		MulMapTravelSoarRewardRequest = 28556,
		// Token: 0x040017E6 RID: 6118
		PhantomSettingBatchUpdateRequest = 26395,
		// Token: 0x040017E7 RID: 6119
		FloroRanchFirstEnterRequest = 26054,
		// Token: 0x040017E8 RID: 6120
		FloroRanchAnimationRequest = 15672,
		// Token: 0x040017E9 RID: 6121
		BlackSwordChallengeInfoRequest = 21267,
		// Token: 0x040017EA RID: 6122
		RoleOperateSelfBgmRequest = 24710,
		// Token: 0x040017EB RID: 6123
		TrapDefenseRefreshShopRequest = 22766,
		// Token: 0x040017EC RID: 6124
		TrapDefenseBuyShopProductRequest = 19270,
		// Token: 0x040017ED RID: 6125
		SceneItemSequenceFrameStartRequest = 22424,
		// Token: 0x040017EE RID: 6126
		MoonPhaseRandomRequest = 15178,
		// Token: 0x040017EF RID: 6127
		MoonPhaseRewardRequest = 27767,
		// Token: 0x040017F0 RID: 6128
		TrapDefenseUseItemRequest = 18631,
		// Token: 0x040017F1 RID: 6129
		LineCrossChallengeStartRequest = 18834,
		// Token: 0x040017F2 RID: 6130
		RoleIllustratedInfoRequest = 26704,
		// Token: 0x040017F3 RID: 6131
		TrapDefenseCurChallengeInfoRequest = 27431,
		// Token: 0x040017F4 RID: 6132
		RoleDevelopConfigRequest = 17421,
		// Token: 0x040017F5 RID: 6133
		PhotoFightTaskRewardRequest = 21817,
		// Token: 0x040017F6 RID: 6134
		PhotoFightSettleRequest = 27242,
		// Token: 0x040017F7 RID: 6135
		TrapDefenseQuickEquipRequest = 20940,
		// Token: 0x040017F8 RID: 6136
		FloroRanchCloseTaskRequest = 22122,
		// Token: 0x040017F9 RID: 6137
		CalabashSkinTakeOnRequest = 20574,
		// Token: 0x040017FA RID: 6138
		WuWuKujiGachaRequest = 16766,
		// Token: 0x040017FB RID: 6139
		SurvivorsOpDoneRequest = 26819,
		// Token: 0x040017FC RID: 6140
		SurvivorsLockRequest = 18939,
		// Token: 0x040017FD RID: 6141
		QuestTreeInfoRequest = 17462,
		// Token: 0x040017FE RID: 6142
		LoadCalabashSkinInfoRequest = 26014,
		// Token: 0x040017FF RID: 6143
		SetPlayerYuXueModeRequest = 21804,
		// Token: 0x04001800 RID: 6144
		SetBtObjYuXueModeRequest = 18881,
		// Token: 0x04001801 RID: 6145
		GetYuXueModeInfoRequest = 18449,
		// Token: 0x04001802 RID: 6146
		SurvivorsResultRequest = 17194,
		// Token: 0x04001803 RID: 6147
		SurvivorsStepAdvanceRequest = 17496,
		// Token: 0x04001804 RID: 6148
		WeatherControlRequest = 19192,
		// Token: 0x04001805 RID: 6149
		SurvivorsWeaponInfoRequest = 19675,
		// Token: 0x04001806 RID: 6150
		SurvivorsNormalAwardRequest = 29160,
		// Token: 0x04001807 RID: 6151
		SurvivorsScoreAwardRequest = 18039,
		// Token: 0x04001808 RID: 6152
		SurvivorsTalentLevelUpRequest = 29153,
		// Token: 0x04001809 RID: 6153
		BatchSynthesisItemRequest = 26865,
		// Token: 0x0400180A RID: 6154
		SurvivorsLastInfoRequest = 27662,
		// Token: 0x0400180B RID: 6155
		RoleUpdateDevelopTargetRequest = 29361,
		// Token: 0x0400180C RID: 6156
		InfrInfoRequest = 26916,
		// Token: 0x0400180D RID: 6157
		InfrArchiveTaskRewardRequest = 23218,
		// Token: 0x0400180E RID: 6158
		InfrManualSwitchTraceRoadRequest = 23717,
		// Token: 0x0400180F RID: 6159
		InfrFireNoticeRequest = 21139,
		// Token: 0x04001810 RID: 6160
		MainPhantomRecommendRequest = 19481,
		// Token: 0x04001811 RID: 6161
		InfrLevelUpRequest = 24462,
		// Token: 0x04001812 RID: 6162
		InfrRoadBuildRequest = 26235,
		// Token: 0x04001813 RID: 6163
		BlackSwordChallengeMarkItemPanelInfoRequest = 27609,
		// Token: 0x04001814 RID: 6164
		HonamiStoryBagOperateRequest = 20504,
		// Token: 0x04001815 RID: 6165
		HonamiStoryEquipRoleRequest = 27034,
		// Token: 0x04001816 RID: 6166
		HonamiStoryUnlockSlotRequest = 16355,
		// Token: 0x04001817 RID: 6167
		HonamiStoryWeaponDressRequest = 23107,
		// Token: 0x04001818 RID: 6168
		HonamiStorySellItemRequest = 25624,
		// Token: 0x04001819 RID: 6169
		HonamiStoryLifeSupportUpRequest = 17291,
		// Token: 0x0400181A RID: 6170
		HonamiStoryActivateTalentRequest = 26246,
		// Token: 0x0400181B RID: 6171
		HonamiStoryItemCollectionRequest = 20939,
		// Token: 0x0400181C RID: 6172
		HonamiStoryMascotRewardRequest = 19377,
		// Token: 0x0400181D RID: 6173
		HonamiStoryAreaSecretRewardRequest = 21261,
		// Token: 0x0400181E RID: 6174
		HonamiStoryLimitTaskRewardRequest = 15084,
		// Token: 0x0400181F RID: 6175
		HonamiStoryScoreRewardRequest = 20667,
		// Token: 0x04001820 RID: 6176
		HonamiStoryPickUpItemRequest = 24310,
		// Token: 0x04001821 RID: 6177
		HonamiStoryDiscardItemRequest = 20391,
		// Token: 0x04001822 RID: 6178
		HonamiStoryInstLeaveRequest = 24314,
		// Token: 0x04001823 RID: 6179
		GetTraceQuestYuXueModeRequest = 27714,
		// Token: 0x04001824 RID: 6180
		RollBlockResetGamePlayRequest = 20443,
		// Token: 0x04001825 RID: 6181
		RollBlockMovementFinishRequest = 25423,
		// Token: 0x04001826 RID: 6182
		HonamiStoryLockItemRequest = 20634,
		// Token: 0x04001827 RID: 6183
		MulCorniceMeetingRewardRequest = 28733,
		// Token: 0x04001828 RID: 6184
		RollBlockInputRequest = 25360,
		// Token: 0x04001829 RID: 6185
		MotorTechLevelUpRequest = 24261,
		// Token: 0x0400182A RID: 6186
		WeatherControlInfoRequest = 18581,
		// Token: 0x0400182B RID: 6187
		ButtonIsEnableRequest = 26588,
		// Token: 0x0400182C RID: 6188
		MotorLevelOneKeyRewardRequest = 25015,
		// Token: 0x0400182D RID: 6189
		MotorInfoRequest = 16731,
		// Token: 0x0400182E RID: 6190
		MotorTaskOneKeyRewardRequest = 25118,
		// Token: 0x0400182F RID: 6191
		PhantomInteractionEquipRequest = 16770,
		// Token: 0x04001830 RID: 6192
		PhantomInteractionSkinChangeRequest = 26605,
		// Token: 0x04001831 RID: 6193
		MotorTechTreeSwitchRequest = 28833,
		// Token: 0x04001832 RID: 6194
		AreaTerminalPinOperationRequest = 29677,
		// Token: 0x04001833 RID: 6195
		GetDetectionTargetRequest = 28235,
		// Token: 0x04001834 RID: 6196
		InfrThemeActivityAwardRequest = 25047,
		// Token: 0x04001835 RID: 6197
		MotorSliderRequest = 23230,
		// Token: 0x04001836 RID: 6198
		BossRushBatchClaimRewardRequest = 23121,
		// Token: 0x04001837 RID: 6199
		PhantomBattleAreaSkillRequest = 22966,
		// Token: 0x04001838 RID: 6200
		PhantomBattlePhantomCardSkillRequest = 19409,
		// Token: 0x04001839 RID: 6201
		ArtemisNodeUpdateRequest = 15301,
		// Token: 0x0400183A RID: 6202
		AddDecalRequest = 18113,
		// Token: 0x0400183B RID: 6203
		CoopRoleRewardRequest = 15123,
		// Token: 0x0400183C RID: 6204
		CoopSpRewardRequest = 23809,
		// Token: 0x0400183D RID: 6205
		HonamiStoryResidentTaskRewardRequest = 27008,
		// Token: 0x0400183E RID: 6206
		RollBlockExitGamePlayRequest = 25320,
		// Token: 0x0400183F RID: 6207
		RollBlockToggleHintRequest = 15024,
		// Token: 0x04001840 RID: 6208
		MotorChangeOutlookRequest = 17225,
		// Token: 0x04001841 RID: 6209
		VehicleEnterSharingRequest = 24127,
		// Token: 0x04001842 RID: 6210
		RollBlockSwitchControlBlockRequest = 16642,
		// Token: 0x04001843 RID: 6211
		MotorLinkTaskRequest = 18830,
		// Token: 0x04001844 RID: 6212
		InstEntityTeleportRequest = 16644,
		// Token: 0x04001845 RID: 6213
		DeadeyeShootHitRequest = 27253,
		// Token: 0x04001846 RID: 6214
		MotorUseSkinRequest = 26877,
		// Token: 0x04001847 RID: 6215
		PhantomBattleCallCardRequest = 16342,
		// Token: 0x04001848 RID: 6216
		ShortMessageInfoRequest = 15653,
		// Token: 0x04001849 RID: 6217
		ShortMessageReadRequest = 15211,
		// Token: 0x0400184A RID: 6218
		ShortMessageReplyRequest = 17071,
		// Token: 0x0400184B RID: 6219
		ShortMessageReceivedRequest = 16353,
		// Token: 0x0400184C RID: 6220
		InfrPhoneTaskRewardRequest = 22319,
		// Token: 0x0400184D RID: 6221
		ShortMessageUpdateRequest = 17215,
		// Token: 0x0400184E RID: 6222
		BeamCastHitPlayerRequest = 25375,
		// Token: 0x0400184F RID: 6223
		CaptureBatchEntityRequest = 17846,
		// Token: 0x04001850 RID: 6224
		RoadBookFullRewardRequest = 18824,
		// Token: 0x04001851 RID: 6225
		RoadBookLevelUpRequest = 24814,
		// Token: 0x04001852 RID: 6226
		RoadBookTaskRewardRequest = 29300,
		// Token: 0x04001853 RID: 6227
		RoadBookMotorRewardRequest = 29858,
		// Token: 0x04001854 RID: 6228
		MotorParkourLevelRewardRequest = 15375,
		// Token: 0x04001855 RID: 6229
		PhantomBatchPolishRequest = 22703,
		// Token: 0x04001856 RID: 6230
		PhantomBattleCheckCardSkillUnlockRequest = 15765,
		// Token: 0x04001857 RID: 6231
		PhantomVicePolishRequest = 19711,
		// Token: 0x04001858 RID: 6232
		PhantomVicePolishAckRequest = 21501,
		// Token: 0x04001859 RID: 6233
		FurnitureDiySaveRequest = 21612,
		// Token: 0x0400185A RID: 6234
		InfrManualCancelTraceRoadRequest = 19233,
		// Token: 0x0400185B RID: 6235
		SkinRewardRequest = 17224,
		// Token: 0x0400185C RID: 6236
		InfrArchiveReadRequest = 21062,
		// Token: 0x0400185D RID: 6237
		AtomicProcessTeleportRequest = 26055,
		// Token: 0x0400185E RID: 6238
		NewTowerUpdateRecordRequest = 26763,
		// Token: 0x0400185F RID: 6239
		NewTowerRewardRequest = 20887,
		// Token: 0x04001860 RID: 6240
		MotorFightTalentUpRequest = 29225,
		// Token: 0x04001861 RID: 6241
		MotorFightOneKeyRewardRequest = 22785,
		// Token: 0x04001862 RID: 6242
		MotorFightRankListRequest = 21341,
		// Token: 0x04001863 RID: 6243
		PhantomBattleGuideRewardRequest = 17961,
		// Token: 0x04001864 RID: 6244
		JokerGuessStartNewRequest = 28688,
		// Token: 0x04001865 RID: 6245
		JokerGuessPlayCardRequest = 17130,
		// Token: 0x04001866 RID: 6246
		JokerGuessDrawCardRequest = 21109,
		// Token: 0x04001867 RID: 6247
		JokerGuessUseSkillRequest = 23048,
		// Token: 0x04001868 RID: 6248
		EncircleChallengeStartRequest = 21480,
		// Token: 0x04001869 RID: 6249
		EncircleChallengeCompleteRequest = 15763,
		// Token: 0x0400186A RID: 6250
		NewTowerCycleStartRequest = 21855,
		// Token: 0x0400186B RID: 6251
		PhantomMusicCollectUpdateRequest = 24815,
		// Token: 0x0400186C RID: 6252
		H5CircumFluenceActivityReadRequest = 23797,
		// Token: 0x0400186D RID: 6253
		HookLockBatchCollectRequest = 17206,
		// Token: 0x0400186E RID: 6254
		MotorFightSettleRequest = 25017,
		// Token: 0x0400186F RID: 6255
		MotorFightLastSaveDataRequest = 22296,
		// Token: 0x04001870 RID: 6256
		PhantomBattleRepeatedTaskRewardRequest = 23196,
		// Token: 0x04001871 RID: 6257
		NewTowerRoleEnergyRequest = 25896,
		// Token: 0x04001872 RID: 6258
		HonamiStoryActivityInfoRequest = 22792,
		// Token: 0x04001873 RID: 6259
		PhantomBatchDirectRefiningRequest = 25223,
		// Token: 0x04001874 RID: 6260
		PilotThrowOperationRequest = 20946,
		// Token: 0x04001875 RID: 6261
		ShortMessageShowChangeRequest = 27422,
		// Token: 0x04001876 RID: 6262
		NewPlayerSupportRewardTaskRequest = 25884,
		// Token: 0x04001877 RID: 6263
		NewPlayerSupportTrialRoleLvUpRequest = 27199,
		// Token: 0x04001878 RID: 6264
		PhantomBattleReconstructCardRequest = 28082,
		// Token: 0x04001879 RID: 6265
		RegressDisposableRewardRequest = 17251,
		// Token: 0x0400187A RID: 6266
		ExploreSkillActionRequest = 25144,
		// Token: 0x0400187B RID: 6267
		InstTeleportToResetPointRequest = 20140,
		// Token: 0x0400187C RID: 6268
		NewTowerClearRecordRequest = 22324,
		// Token: 0x0400187D RID: 6269
		GetLevelPlayRewardsRequest = 19971,
		// Token: 0x0400187E RID: 6270
		MotorOutlookInfoRequest = 24056,
		// Token: 0x0400187F RID: 6271
		Summon3Request = 22732,
		// Token: 0x04001880 RID: 6272
		RegressTrialRoleLvUpRequest = 27895,
		// Token: 0x04001881 RID: 6273
		GravityHookLockPointChangeGravityRequest = 18495,
		// Token: 0x04001882 RID: 6274
		TotalTopUpScoreInfoRequest = 22350,
		// Token: 0x04001883 RID: 6275
		TotalTopUpRewardRequest = 23916,
		// Token: 0x04001884 RID: 6276
		NewPlayerSupportSetCurUseTrialRoleRequest = 15519,
		// Token: 0x04001885 RID: 6277
		MotorFightEnterSubLevelRequest = 25986,
		// Token: 0x04001886 RID: 6278
		MotorFightKillRequest = 17673,
		// Token: 0x04001887 RID: 6279
		AtomicProcessAddBuffRequest = 16727,
		// Token: 0x04001888 RID: 6280
		BrochureRewardRequest = 28387,
		// Token: 0x04001889 RID: 6281
		WeekCardInfoRequest = 15779,
		// Token: 0x0400188A RID: 6282
		WeekCardRewardRequest = 15854,
		// Token: 0x0400188B RID: 6283
		SeamlessTeleportVehicleRequest = 16632,
		// Token: 0x0400188C RID: 6284
		RegressRepeatedTaskRequest = 27083,
		// Token: 0x0400188D RID: 6285
		MotorCreateRequest = 23555,
		// Token: 0x0400188E RID: 6286
		RegressBuyBonusLvRequest = 16574,
		// Token: 0x0400188F RID: 6287
		RegressSetCurUseTrialRoleRequest = 28325,
		// Token: 0x04001890 RID: 6288
		H5ViewActivityReadRequest = 28203,
		// Token: 0x04001891 RID: 6289
		RoleSkillBranchModifyRequest = 27456,
		// Token: 0x04001892 RID: 6290
		MixDrinkSettleRequest = 23581,
		// Token: 0x04001893 RID: 6291
		MixDrinkTopicSelectRequest = 17303,
		// Token: 0x04001894 RID: 6292
		MotorFightPlayerDeadRequest = 21022,
		// Token: 0x04001895 RID: 6293
		WeatherSwitchInfoRequest = 17029,
		// Token: 0x04001896 RID: 6294
		MotorFightRefreshNextWaveGroupRequest = 18493,
		// Token: 0x04001897 RID: 6295
		RollBlockGamePlayReadyRequest = 20611,
		// Token: 0x04001898 RID: 6296
		MotorFightSelectCollectionRequest = 15634,
		// Token: 0x04001899 RID: 6297
		EntityEnterVehicleRequest = 23956,
		// Token: 0x0400189A RID: 6298
		FarmGoldLevelPlayRepeatedRequest = 20085,
		// Token: 0x0400189B RID: 6299
		MotorFightSelectBuffGateRequest = 18769,
		// Token: 0x0400189C RID: 6300
		GivebackInfoRequest = 15161,
		// Token: 0x0400189D RID: 6301
		GivebackRewardRequest = 23177,
		// Token: 0x0400189E RID: 6302
		FarmGoldPointRepeatedRequest = 25310,
		// Token: 0x0400189F RID: 6303
		ActionResetPosPrePerformanceEndRequest = 17446,
		// Token: 0x040018A0 RID: 6304
		MotorFightRefreshCollectionRequest = 22546,
		// Token: 0x040018A1 RID: 6305
		ExhibitionItemSaveRequest = 18118,
		// Token: 0x040018A2 RID: 6306
		SpringFestivalTaskRewardRequest = 23817,
		// Token: 0x040018A3 RID: 6307
		SpringFestivalScoreRewardRequest = 16898,
		// Token: 0x040018A4 RID: 6308
		SpringFestivalAtmosphereRewardRequest = 18419,
		// Token: 0x040018A5 RID: 6309
		EnterBigWorldInstRequest = 16410,
		// Token: 0x040018A6 RID: 6310
		PhantomMusicSaveRequest = 25322,
		// Token: 0x040018A7 RID: 6311
		FlagChallengeRewardRequest = 21551,
		// Token: 0x040018A8 RID: 6312
		MotorDevelopTaskRewardRequest = 27103,
		// Token: 0x040018A9 RID: 6313
		VehicleFinishRequest = 18022,
		// Token: 0x040018AA RID: 6314
		AtomicProcessRemoveBuffRequest = 27565,
		// Token: 0x040018AB RID: 6315
		ActivityPayShopBuyRequest = 29230,
		// Token: 0x040018AC RID: 6316
		TetrisUpdateRequest = 15349,
		// Token: 0x040018AD RID: 6317
		NewTrialRoleGetNightmarePhantomInstInfoRequest = 29530,
		// Token: 0x040018AE RID: 6318
		MixDrinkRoleInviteRequest = 18883,
		// Token: 0x040018AF RID: 6319
		MotorFightRankListSelfDataRequest = 19112,
		// Token: 0x040018B0 RID: 6320
		PhBaPlanUsePlanRequest = 15249,
		// Token: 0x040018B1 RID: 6321
		PhBaPlanSaveUsePlanRequest = 27330,
		// Token: 0x040018B2 RID: 6322
		PhBaPlanFindPlanRequest = 22650,
		// Token: 0x040018B3 RID: 6323
		KurotatoChestRewardSelectRequest = 19001,
		// Token: 0x040018B4 RID: 6324
		KurotatoUpgradeRewardSelectRequest = 20545,
		// Token: 0x040018B5 RID: 6325
		KurotatoUpgradeRewardRefreshRequest = 25898,
		// Token: 0x040018B6 RID: 6326
		KurotatoShopRewardSelectRequest = 24909,
		// Token: 0x040018B7 RID: 6327
		KurotatoShopRewardLockRequest = 22092,
		// Token: 0x040018B8 RID: 6328
		KurotatoShopRewardRefreshRequest = 24293,
		// Token: 0x040018B9 RID: 6329
		MixDrinkRoleRewardRequest = 20051,
		// Token: 0x040018BA RID: 6330
		JokerGuessRewardRequest = 24268,
		// Token: 0x040018BB RID: 6331
		StorageInfoRequest = 25920,
		// Token: 0x040018BC RID: 6332
		StorageInfoUpdateRequest = 21380,
		// Token: 0x040018BD RID: 6333
		FeiXuePreheatInfoRewardRequest = 16511,
		// Token: 0x040018BE RID: 6334
		RhythmChangePartnerRoleRequest = 27219,
		// Token: 0x040018BF RID: 6335
		RhythmRankListRequest = 25012,
		// Token: 0x040018C0 RID: 6336
		RhythmRankListSelfDataRequest = 18805,
		// Token: 0x040018C1 RID: 6337
		RhythmSettleRequest = 23554,
		// Token: 0x040018C2 RID: 6338
		RhythmSetRedDotRequest = 20712,
		// Token: 0x040018C3 RID: 6339
		RhythmTaskOneKeyRewardRequest = 23309,
		// Token: 0x040018C4 RID: 6340
		DropCatchLevelRewardRequest = 20994,
		// Token: 0x040018C5 RID: 6341
		DropCatchLevelFinishRequest = 21819,
		// Token: 0x040018C6 RID: 6342
		SplinePositionUpdateRequest = 28181,
		// Token: 0x040018C7 RID: 6343
		KurotatoEndShopStepRequest = 17398,
		// Token: 0x040018C8 RID: 6344
		NewTowerLastCycleInfoRequest = 25259,
		// Token: 0x040018C9 RID: 6345
		NewTowerSeasonRewardRequest = 20810,
		// Token: 0x040018CA RID: 6346
		NewTowerRecommendRequest = 20297,
		// Token: 0x040018CB RID: 6347
		ScheduleNpcUpdatePosRequest = 28259,
		// Token: 0x040018CC RID: 6348
		KurotatoRefineWeaponRequest = 27957,
		// Token: 0x040018CD RID: 6349
		PhBaPlanSetPlanStatusRequest = 16741,
		// Token: 0x040018CE RID: 6350
		PhBaPlanUpdatePlanRequest = 28006,
		// Token: 0x040018CF RID: 6351
		PhBaPlanSetFiveStarSwitchRequest = 25722,
		// Token: 0x040018D0 RID: 6352
		NewTowerSeasonScoreRewardRequest = 26749,
		// Token: 0x040018D1 RID: 6353
		StartRecallRequest = 20244,
		// Token: 0x040018D2 RID: 6354
		ChangeOrnamentRequest = 27956,
		// Token: 0x040018D3 RID: 6355
		DropCatchInfoRequest = 21559,
		// Token: 0x040018D4 RID: 6356
		AvoidBlockSubmitOverNodeRequest = 16244,
		// Token: 0x040018D5 RID: 6357
		KurotatoSellWeaponRequest = 26554,
		// Token: 0x040018D6 RID: 6358
		TetrisFinishRequest = 18718,
		// Token: 0x040018D7 RID: 6359
		RacingBetsCloseSettleMenuRequest = 16577,
		// Token: 0x040018D8 RID: 6360
		PlayerXboxInfoGetRequest = 21683,
		// Token: 0x040018D9 RID: 6361
		PlayerCreateXboxSessionRequest = 27825,
		// Token: 0x040018DA RID: 6362
		PlayerXboxBlockListRequest = 28660,
		// Token: 0x040018DB RID: 6363
		XboxSettingUpdateRequest = 20700,
		// Token: 0x040018DC RID: 6364
		XboxSettingRequest = 21284,
		// Token: 0x040018DD RID: 6365
		PinballTeamReviveRequest = 29847,
		// Token: 0x040018DE RID: 6366
		PinballSetPayloadRequest = 29166,
		// Token: 0x040018DF RID: 6367
		RoleSkillQuickLevelUpRequest = 29779,
		// Token: 0x040018E0 RID: 6368
		GaSwitchCommonEnemyProCampRequest = 17625,
		// Token: 0x040018E1 RID: 6369
		PinballTeamDieRequest = 24584,
		// Token: 0x040018E2 RID: 6370
		PinballQuitRequest = 28824,
		// Token: 0x040018E3 RID: 6371
		PinballBonusFullWinRequest = 23910,
		// Token: 0x040018E4 RID: 6372
		PinballInGameSyncPayloadRequest = 21563,
		// Token: 0x040018E5 RID: 6373
		PinballTaskRewardRequest = 19362,
		// Token: 0x040018E6 RID: 6374
		PinballRoleLevelUpRequest = 17691,
		// Token: 0x040018E7 RID: 6375
		PinballWeaponDegradeRequest = 24517,
		// Token: 0x040018E8 RID: 6376
		PinballWeaponWearRequest = 26957,
		// Token: 0x040018E9 RID: 6377
		PinballFriendRankRequest = 15366,
		// Token: 0x040018EA RID: 6378
		InfrV2InfoRequest = 21305,
		// Token: 0x040018EB RID: 6379
		InfrV2LevelUpRequest = 20713,
		// Token: 0x040018EC RID: 6380
		InfrV2TreeBuildRequest = 21969,
		// Token: 0x040018ED RID: 6381
		InfrV2ManualSwitchTraceTreeRequest = 27880,
		// Token: 0x040018EE RID: 6382
		InfrV2ManualCancelTraceTreeRequest = 16247,
		// Token: 0x040018EF RID: 6383
		RogueInstExtraInfoRequest = 25243,
		// Token: 0x040018F0 RID: 6384
		InfrV2ScoreRewardRequest = 17050,
		// Token: 0x040018F1 RID: 6385
		InfrV2TaskRewardRequest = 24745,
		// Token: 0x040018F2 RID: 6386
		RhythmMainLineInfoRequest = 17337,
		// Token: 0x040018F3 RID: 6387
		ThemePersonalScoreRequest = 25800,
		// Token: 0x040018F4 RID: 6388
		ThemeWorldScoreRequest = 27613,
		// Token: 0x040018F5 RID: 6389
		WuWuTaskRewardRequest = 17363,
		// Token: 0x040018F6 RID: 6390
		BossPilingRewardRequest = 17008,
		// Token: 0x040018F7 RID: 6391
		PhBaPlanBatchOperRequest = 28530,
		// Token: 0x040018F8 RID: 6392
		MotorOutlookCreatePresetRequest = 21586,
		// Token: 0x040018F9 RID: 6393
		MotorOutlookDeletePresetRequest = 27258,
		// Token: 0x040018FA RID: 6394
		MotorOutlookEditPresetRequest = 22163,
		// Token: 0x040018FB RID: 6395
		FlowerPollutionRequest = 21028,
		// Token: 0x040018FC RID: 6396
		MotorDecalTaskRequest = 17422,
		// Token: 0x040018FD RID: 6397
		MotorDecalMotorIpRequest = 16237,
		// Token: 0x040018FE RID: 6398
		BossPilingSettleRequest = 17839,
		// Token: 0x040018FF RID: 6399
		RacingBetsRepeatedTaskRewardRequest = 28433,
		// Token: 0x04001900 RID: 6400
		LinkageCheckInRewardRequest = 25948,
		// Token: 0x04001901 RID: 6401
		GolemCrackUpdateRequest = 29338,
		// Token: 0x04001902 RID: 6402
		QuestBranchRequest = 29163,
		// Token: 0x04001903 RID: 6403
		QuestBranchSelectRequest = 20377,
		// Token: 0x04001904 RID: 6404
		RoleGiftRewardRequest = 26345,
		// Token: 0x04001905 RID: 6405
		NewTowerSeasonTaskDataUpdateRequest = 16526,
		// Token: 0x04001906 RID: 6406
		WuWuPackageRewardRequest = 29680,
		// Token: 0x04001907 RID: 6407
		PinballInGameKickBallRequest = 25787,
		// Token: 0x04001908 RID: 6408
		GachaAccumulateInfoRequest = 22393,
		// Token: 0x04001909 RID: 6409
		GachaAccumulateRewardRequest = 29657,
		// Token: 0x0400190A RID: 6410
		PlayerEnterPollutionRequest = 16885,
		// Token: 0x0400190B RID: 6411
		QuickHackSkillRequest = 25674,
		// Token: 0x0400190C RID: 6412
		EdgeRunnerFunctionPreUnlockRequest = 19702,
		// Token: 0x0400190D RID: 6413
		EdgeRunnerScoreRewardRequest = 17999,
		// Token: 0x0400190E RID: 6414
		EdgeRunnerTaskRewardRequest = 24142,
		// Token: 0x0400190F RID: 6415
		KurotatoScoreTaskReceiveRequest = 23998,
		// Token: 0x04001910 RID: 6416
		KurotatoResTaskReceiveRequest = 26341,
		// Token: 0x04001911 RID: 6417
		KurotatoLimitTaskReceiveRequest = 29669,
		// Token: 0x04001912 RID: 6418
		KurotatoRoleRecordRequest = 24358,
		// Token: 0x04001913 RID: 6419
		WeeklyFrameworkInfoRequest = 16625,
		// Token: 0x04001914 RID: 6420
		WeeklyFrameworkScoreRewardRequest = 28000,
		// Token: 0x04001915 RID: 6421
		FloroRanchWeeklyRequest = 23105,
		// Token: 0x04001916 RID: 6422
		DollGrabRequest = 17423,
		// Token: 0x04001917 RID: 6423
		DollGrabTimeBallRequest = 15115,
		// Token: 0x04001918 RID: 6424
		DollGarbStartRequest = 16837,
		// Token: 0x04001919 RID: 6425
		AvoidBlockClientInitDoneRequest = 24150,
		// Token: 0x0400191A RID: 6426
		ConsumptiveActivityScoreRequest = 27461,
		// Token: 0x0400191B RID: 6427
		MonsterPatrolPointReachedRequest = 27527,
		// Token: 0x0400191C RID: 6428
		ClientPullResourcePackageRequest = 26961,
		// Token: 0x0400191D RID: 6429
		NewHandInItemRequest = 24640,
		// Token: 0x0400191E RID: 6430
		DollDeliveryRequest = 22224,
		// Token: 0x0400191F RID: 6431
		OnlineMotorActivityLevelRequest = 15684,
		// Token: 0x04001920 RID: 6432
		PlayerVoiceLanguageRequest = 29926,
		// Token: 0x04001921 RID: 6433
		PlayerRoleVoiceSetRequest = 20371,
		// Token: 0x04001922 RID: 6434
		FloroRanchEventChoiceRequest = 24306,
		// Token: 0x04001923 RID: 6435
		KurotatoSettlementRequest = 18635,
		// Token: 0x04001924 RID: 6436
		RemoteBatchCollectRequest = 22702,
		// Token: 0x04001925 RID: 6437
		BatchMaterialReplaceRequest = 23293,
		// Token: 0x04001926 RID: 6438
		NewPlayerSupportSetCurUseTrialRoleV2Request = 25773,
		// Token: 0x04001927 RID: 6439
		ChangeSummonEntityStateRequest = 26759,
		// Token: 0x04001928 RID: 6440
		NewPlayerSupportTrialRoleLvUpV2Request = 24861,
		// Token: 0x04001929 RID: 6441
		RealmBetweenFullRewardRequest = 27929,
		// Token: 0x0400192A RID: 6442
		RealmBetweenLevelUpRequest = 24178,
		// Token: 0x0400192B RID: 6443
		RealmBetweenTaskRewardRequest = 26496,
		// Token: 0x0400192C RID: 6444
		RealmBetweenMotorRewardRequest = 22394,
		// Token: 0x0400192D RID: 6445
		RogueArchiveListRequest = 29771,
		// Token: 0x0400192E RID: 6446
		RogueArchiveSaveRequest = 25782,
		// Token: 0x0400192F RID: 6447
		RogueTowerTrialStartRequest = 21807,
		// Token: 0x04001930 RID: 6448
		RogueTowerTrialSelectBossRequest = 15164,
		// Token: 0x04001931 RID: 6449
		RogueTowerTrialReChallengeRequest = 23366,
		// Token: 0x04001932 RID: 6450
		RogueTowerTrialResultRequest = 17805,
		// Token: 0x04001933 RID: 6451
		SheriffZoneInfoRequest = 17467,
		// Token: 0x04001934 RID: 6452
		KurotatoEndSpecialWaveCombatRequest = 24724,
		// Token: 0x04001935 RID: 6453
		BabelTowerShowNameRequest = 24234,
		// Token: 0x04001936 RID: 6454
		BabelTowerRankListRequest = 16651,
		// Token: 0x04001937 RID: 6455
		BabelTowerSelfPassRequest = 21395,
		// Token: 0x04001938 RID: 6456
		DollGrabStopRequest = 17493,
		// Token: 0x04001939 RID: 6457
		RogueTowerTrialGiveUpTempArchiveRequest = 21241,
		// Token: 0x0400193A RID: 6458
		MiniWriteLetterSaveContentRequest = 25919,
		// Token: 0x0400193B RID: 6459
		SignActivityFreeDropRequest = 29512,
		// Token: 0x0400193C RID: 6460
		KurotatoReChallengeRequest = 22515,
		// Token: 0x0400193D RID: 6461
		DollGrabPauseStartRequest = 19546,
		// Token: 0x0400193E RID: 6462
		DollGrabPauseEndRequest = 23827,
		// Token: 0x0400193F RID: 6463
		TraceRecallQuestRequest = 28149,
		// Token: 0x04001940 RID: 6464
		RecallQuestFinishActionRequest = 27112,
		// Token: 0x04001941 RID: 6465
		RecallQuestActionRequest = 18918,
		// Token: 0x04001942 RID: 6466
		RecallQuestNpcMoveOverRequest = 22658,
		// Token: 0x04001943 RID: 6467
		RecallQuestFinishActionEndRequest = 16583,
		// Token: 0x04001944 RID: 6468
		NewbieAdventureTaskRewardRequest = 17476,
		// Token: 0x04001945 RID: 6469
		NewbieAdventureChapterDropRequest = 21108,
		// Token: 0x04001946 RID: 6470
		NewbieAdventureRoleRewardRequest = 24679,
		// Token: 0x04001947 RID: 6471
		NewbieCourseV2RewardRequest = 16575,
		// Token: 0x04001948 RID: 6472
		NewbieFetchScoreRewardRequest = 26025,
		// Token: 0x04001949 RID: 6473
		FloroRanchOutRequest = 26316,
		// Token: 0x0400194A RID: 6474
		RecallQuestReadyForGiveUpRequest = 19845,
		// Token: 0x0400194B RID: 6475
		ResonantChainOptionalLimitRequest = 18010,
		// Token: 0x0400194C RID: 6476
		QueryRecallItemBagRequest = 26265,
		// Token: 0x0400194D RID: 6477
		SetClientGlobalVarRequest = 28443,
		// Token: 0x0400194E RID: 6478
		DollGarbInsertCoinRequest = 22346,
		// Token: 0x0400194F RID: 6479
		RoverRogueQuitRequest = 22259,
		// Token: 0x04001950 RID: 6480
		RoverRogueResultRequest = 20506,
		// Token: 0x04001951 RID: 6481
		RoverRogueChooseDataResultRequest = 19909,
		// Token: 0x04001952 RID: 6482
		RoverRogueRefreshGainRequest = 20036,
		// Token: 0x04001953 RID: 6483
		RoverRogueGiveUpGainRequest = 17559,
		// Token: 0x04001954 RID: 6484
		RoverRogueGotoNextRoomCommitRequest = 24658,
		// Token: 0x04001955 RID: 6485
		RoverRogueInsListRequest = 22892,
		// Token: 0x04001956 RID: 6486
		RoverRogueTalentInfoRequest = 22199,
		// Token: 0x04001957 RID: 6487
		RoverRogueTalentUnlockRequest = 19911,
		// Token: 0x04001958 RID: 6488
		RoverRogueShopBuyRequest = 17480,
		// Token: 0x04001959 RID: 6489
		RoverRogueShopRefreshRequest = 18096,
		// Token: 0x0400195A RID: 6490
		DangoBrawlBagOperateRequest = 16736,
		// Token: 0x0400195B RID: 6491
		DangoBrawlShopRefreshRequest = 27387,
		// Token: 0x0400195C RID: 6492
		DangoBrawlShopLockRequest = 15276,
		// Token: 0x0400195D RID: 6493
		DangoBrawlShopBuyRequest = 16336,
		// Token: 0x0400195E RID: 6494
		DangoBrawlShopSellRequest = 17114,
		// Token: 0x0400195F RID: 6495
		DangoBrawlShopComposeRequest = 18102,
		// Token: 0x04001960 RID: 6496
		DangoBrawlEventRefreshRequest = 24299,
		// Token: 0x04001961 RID: 6497
		DangoBrawlEventSelectRequest = 20144,
		// Token: 0x04001962 RID: 6498
		DangoBrawlStartFightRequest = 19061,
		// Token: 0x04001963 RID: 6499
		DangoBrawlFightOverRequest = 24115,
		// Token: 0x04001964 RID: 6500
		RoverRogueBlessGroupSelectRequest = 20925,
		// Token: 0x04001965 RID: 6501
		NewTowerMedalInfoRequest = 19895,
		// Token: 0x04001966 RID: 6502
		RoverRogueEventSelectRequest = 25491,
		// Token: 0x04001967 RID: 6503
		MotorUseSceneRequest = 24816,
		// Token: 0x04001968 RID: 6504
		DarkTideSwitchVisionRequest = 27020,
		// Token: 0x04001969 RID: 6505
		DangoBrawlSettleRequest = 20328,
		// Token: 0x0400196A RID: 6506
		DangoBrawlTaskRewardRequest = 20110,
		// Token: 0x0400196B RID: 6507
		DarkTideDiscardItemRequest = 20955,
		// Token: 0x0400196C RID: 6508
		DarkTidePickUpItemRequest = 23254,
		// Token: 0x0400196D RID: 6509
		DarkTideBagSortRequest = 17853,
		// Token: 0x0400196E RID: 6510
		QuestFastReturnPosRequest = 19158,
		// Token: 0x0400196F RID: 6511
		LevelPlayFastReturnPosRequest = 16463,
		// Token: 0x04001970 RID: 6512
		FastReturnDungeonRequest = 26075,
		// Token: 0x04001971 RID: 6513
		DollSmallMapInfoRequest = 21017,
		// Token: 0x04001972 RID: 6514
		DarkTideMapMarkRequest = 16419,
		// Token: 0x04001973 RID: 6515
		DarkTideItemMarkRequest = 21315,
		// Token: 0x04001974 RID: 6516
		RoverRogueLootInfoRequest = 28236,
		// Token: 0x04001975 RID: 6517
		RoverRogueLootChangeRequest = 18020,
		// Token: 0x04001976 RID: 6518
		KurotatoStepAdvanceRequest = 19987,
		// Token: 0x04001977 RID: 6519
		RecallExploreSkillRouletteSetRequest = 20923,
		// Token: 0x04001978 RID: 6520
		RoverRogueTaskRewardTakeRequest = 25823,
		// Token: 0x04001979 RID: 6521
		SceneGroupDataAndCurFormationEntityRequest = 18649,
		// Token: 0x0400197A RID: 6522
		KurotatoGoldAddRequest = 29200,
		// Token: 0x0400197B RID: 6523
		TowerDefenceChallengeQuitRequest = 29237,
		// Token: 0x0400197C RID: 6524
		KurotatoLevelRecordDeleteRequest = 20207,
		// Token: 0x0400197D RID: 6525
		MailFavoriteRequest = 20098,
		// Token: 0x0400197E RID: 6526
		ConditionGroupStateRequest = 16491,
		// Token: 0x0400197F RID: 6527
		ZitherPlayStateRequest = 17270,
		// Token: 0x04001980 RID: 6528
		EntityAccessCasketRequest = 26836,
		// Token: 0x04001981 RID: 6529
		PlayerAccessCasketRequest = 24257,
		// Token: 0x04001982 RID: 6530
		QingXiaoTaskRewardRequest = 26165,
		// Token: 0x04001983 RID: 6531
		GiantDeliveryItemRequest = 23968,
		// Token: 0x04001984 RID: 6532
		GiantMaxLevelDeliveryItemRequest = 24688,
		// Token: 0x04001985 RID: 6533
		MatchThreeStarRequest = 21794,
		// Token: 0x04001986 RID: 6534
		MatchThreeEndRequest = 24146,
		// Token: 0x04001987 RID: 6535
		DangoBrawlScoreRewardRequest = 28029,
		// Token: 0x04001988 RID: 6536
		FoundationCoreOperateRequest = 22998,
		// Token: 0x04001989 RID: 6537
		CameraSettingQueryRequest = 16381,
		// Token: 0x0400198A RID: 6538
		CameraSettingModifyRequest = 18483,
		// Token: 0x0400198B RID: 6539
		RecallTeleportToMarkIdRequest = 27287,
		// Token: 0x0400198C RID: 6540
		ShortMessageChatThemeChangeRequest = 27042,
		// Token: 0x0400198D RID: 6541
		ShortMessageChatCharmChangeRequest = 29957,
		// Token: 0x0400198E RID: 6542
		RenameFormationRequest = 24542,
		// Token: 0x0400198F RID: 6543
		ReorderFormationRequest = 18507,
		// Token: 0x04001990 RID: 6544
		GiantStableValueActivityRequest = 18354,
		// Token: 0x04001991 RID: 6545
		RecallItemUseRequest = 26379,
		// Token: 0x04001992 RID: 6546
		GameStatsShowRequest = 26099,
		// Token: 0x04001993 RID: 6547
		SelfPortraitStateRequest = 25316,
		// Token: 0x04001994 RID: 6548
		LoopTeleportVolumeActionRequest = 17374,
		// Token: 0x04001995 RID: 6549
		WellStreamingFinisRequest = 25917,
		// Token: 0x04001996 RID: 6550
		TimePointActivityBatchRewardRequest = 15010
	}
}
