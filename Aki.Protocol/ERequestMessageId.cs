using System;

namespace Aki.Protocol
{
	// Token: 0x0200000A RID: 10
	public enum ERequestMessageId
	{
		// Token: 0x040014AF RID: 5295
		CreateCharacterRequest = 101,
		// Token: 0x040014B0 RID: 5296
		LoginRequest = 103,
		// Token: 0x040014B1 RID: 5297
		EnterGameRequest = 105,
		// Token: 0x040014B2 RID: 5298
		ReconnectRequest = 107,
		// Token: 0x040014B3 RID: 5299
		ProtoKeyRequest = 111,
		// Token: 0x040014B4 RID: 5300
		AchievementInfoRequest = 22315,
		// Token: 0x040014B5 RID: 5301
		AchievementReceiveRequest = 16062,
		// Token: 0x040014B6 RID: 5302
		AchievementFinishRequest = 27912,
		// Token: 0x040014B7 RID: 5303
		ActionFinishRequest = 27577,
		// Token: 0x040014B8 RID: 5304
		GmLevelActionRequest = 29805,
		// Token: 0x040014B9 RID: 5305
		ActivityRequest = 16076,
		// Token: 0x040014BA RID: 5306
		ActivityFirstReadRequest = 19271,
		// Token: 0x040014BB RID: 5307
		SignActivityRequest = 29384,
		// Token: 0x040014BC RID: 5308
		HarvestActivityPointRequest = 15260,
		// Token: 0x040014BD RID: 5309
		HarvestActivityLevelRequest = 27602,
		// Token: 0x040014BE RID: 5310
		HarvestActivityLevelDiffRequest = 16220,
		// Token: 0x040014BF RID: 5311
		HarvestActivityResultRequest = 22854,
		// Token: 0x040014C0 RID: 5312
		PhantomCollectReceiveRequest = 24841,
		// Token: 0x040014C1 RID: 5313
		AdventureManualDataRequest = 25198,
		// Token: 0x040014C2 RID: 5314
		GetAdventureRewardRequest = 26242,
		// Token: 0x040014C3 RID: 5315
		GetChapterRewardRequest = 26818,
		// Token: 0x040014C4 RID: 5316
		DetectionRequest = 15268,
		// Token: 0x040014C5 RID: 5317
		AdventureManualRequest = 17641,
		// Token: 0x040014C6 RID: 5318
		ReceivedSilentFirstAwardRequest = 17342,
		// Token: 0x040014C7 RID: 5319
		SelectDetectionTargetRequest = 21057,
		// Token: 0x040014C8 RID: 5320
		MonsterDetectionInfoRequest = 28163,
		// Token: 0x040014C9 RID: 5321
		NormalMonsterManualInfoRequest = 22245,
		// Token: 0x040014CA RID: 5322
		GetDetectionLabelInfoRequest = 22348,
		// Token: 0x040014CB RID: 5323
		AdviceSetRequest = 24164,
		// Token: 0x040014CC RID: 5324
		AdviceRequest = 23265,
		// Token: 0x040014CD RID: 5325
		AdviceCreateRequest = 21703,
		// Token: 0x040014CE RID: 5326
		AdviceModifyRequest = 28074,
		// Token: 0x040014CF RID: 5327
		AdviceDeleteRequest = 18057,
		// Token: 0x040014D0 RID: 5328
		AdviceVoteRequest = 23765,
		// Token: 0x040014D1 RID: 5329
		AiInformationRequest = 18681,
		// Token: 0x040014D2 RID: 5330
		AiBlackboardsRequest = 22558,
		// Token: 0x040014D3 RID: 5331
		AiBlackboardCdRequest = 15625,
		// Token: 0x040014D4 RID: 5332
		AiHateRequest = 27610,
		// Token: 0x040014D5 RID: 5333
		AiControlSwitchRequest = 27014,
		// Token: 0x040014D6 RID: 5334
		EnterAreaRequest = 22737,
		// Token: 0x040014D7 RID: 5335
		ReportPlayerRequest = 24953,
		// Token: 0x040014D8 RID: 5336
		ModifyNameRequest = 18421,
		// Token: 0x040014D9 RID: 5337
		ModifySignatureRequest = 16561,
		// Token: 0x040014DA RID: 5338
		ChangeHeadPhotoRequest = 26439,
		// Token: 0x040014DB RID: 5339
		ClientBasicInfoRequest = 23592,
		// Token: 0x040014DC RID: 5340
		PlayerBasicInfoGetRequest = 23383,
		// Token: 0x040014DD RID: 5341
		BirthdayInitRequest = 21136,
		// Token: 0x040014DE RID: 5342
		RoleShowListUpdateRequest = 27889,
		// Token: 0x040014DF RID: 5343
		ChangeCardRequest = 23459,
		// Token: 0x040014E0 RID: 5344
		ReadCardRequest = 15318,
		// Token: 0x040014E1 RID: 5345
		BirthdayShowSetRequest = 27980,
		// Token: 0x040014E2 RID: 5346
		BattlePassRequest = 22649,
		// Token: 0x040014E3 RID: 5347
		BattlePassTakeRewardRequest = 27378,
		// Token: 0x040014E4 RID: 5348
		BattlePassRecurringTakeRequest = 29679,
		// Token: 0x040014E5 RID: 5349
		BattlePassTakeAllRewardRequest = 21032,
		// Token: 0x040014E6 RID: 5350
		BattlePassTaskRequest = 22950,
		// Token: 0x040014E7 RID: 5351
		BattlePassTaskTakeRequest = 29651,
		// Token: 0x040014E8 RID: 5352
		BattlePassLevelUpRequest = 26786,
		// Token: 0x040014E9 RID: 5353
		SubmitNodeRequest = 21759,
		// Token: 0x040014EA RID: 5354
		HandInItemRequest = 21324,
		// Token: 0x040014EB RID: 5355
		BtSetTimerInfoRequest = 19327,
		// Token: 0x040014EC RID: 5356
		BtForcedOccupationRequest = 25189,
		// Token: 0x040014ED RID: 5357
		BtGiveUpRequest = 18051,
		// Token: 0x040014EE RID: 5358
		BtRollbackRequest = 23225,
		// Token: 0x040014EF RID: 5359
		SneakRequest = 15909,
		// Token: 0x040014F0 RID: 5360
		SneakTimeRequest = 27089,
		// Token: 0x040014F1 RID: 5361
		TimerEndRequest = 28680,
		// Token: 0x040014F2 RID: 5362
		UiGamePlayRequest = 24744,
		// Token: 0x040014F3 RID: 5363
		NpcTraceFailedRequest = 29936,
		// Token: 0x040014F4 RID: 5364
		WorldBlackboardRequest = 22945,
		// Token: 0x040014F5 RID: 5365
		EntityBlackboardRequest = 19528,
		// Token: 0x040014F6 RID: 5366
		BlockListRequest = 22469,
		// Token: 0x040014F7 RID: 5367
		BlockPlayerRequest = 26186,
		// Token: 0x040014F8 RID: 5368
		UnblockPlayerRequest = 25581,
		// Token: 0x040014F9 RID: 5369
		PlaceItemOnBoardRequest = 23598,
		// Token: 0x040014FA RID: 5370
		CommitBoardRequest = 22677,
		// Token: 0x040014FB RID: 5371
		MovePlacementRequest = 26801,
		// Token: 0x040014FC RID: 5372
		ApplyGameplayEffectRequest = 26992,
		// Token: 0x040014FD RID: 5373
		RemoveGameplayEffectRequest = 15998,
		// Token: 0x040014FE RID: 5374
		OrderApplyBuffRequest = 21297,
		// Token: 0x040014FF RID: 5375
		OrderRemoveBuffRequest = 26903,
		// Token: 0x04001500 RID: 5376
		ActivateBuffRequest = 27416,
		// Token: 0x04001501 RID: 5377
		OrderRemoveBuffByTagsRequest = 20210,
		// Token: 0x04001502 RID: 5378
		BuffEffectExecuteRequest = 19635,
		// Token: 0x04001503 RID: 5379
		BuffStackCountRequest = 24150,
		// Token: 0x04001504 RID: 5380
		BuffEffectRequest = 22402,
		// Token: 0x04001505 RID: 5381
		BuffItemRequest = 17824,
		// Token: 0x04001506 RID: 5382
		CalabashMsgRequest = 23687,
		// Token: 0x04001507 RID: 5383
		CalabashLevelRewardRequest = 28983,
		// Token: 0x04001508 RID: 5384
		CdKeyVerifyRequest = 17701,
		// Token: 0x04001509 RID: 5385
		ChatRequest = 28634,
		// Token: 0x0400150A RID: 5386
		PrivateChatRequest = 18832,
		// Token: 0x0400150B RID: 5387
		PrivateChatHistoryRequest = 20338,
		// Token: 0x0400150C RID: 5388
		PrivateChatDataRequest = 17748,
		// Token: 0x0400150D RID: 5389
		ChatMutePlayerRequest = 26518,
		// Token: 0x0400150E RID: 5390
		PrivateChatOperateRequest = 16521,
		// Token: 0x0400150F RID: 5391
		ChannelChatRequest = 18878,
		// Token: 0x04001510 RID: 5392
		CombatSendPackRequest = 26497,
		// Token: 0x04001511 RID: 5393
		CombatMaxCaseMessageRequest = 28528,
		// Token: 0x04001512 RID: 5394
		FixToolRequest = 16354,
		// Token: 0x04001513 RID: 5395
		CookFormulaRequest = 27218,
		// Token: 0x04001514 RID: 5396
		CookFoodRequest = 29582,
		// Token: 0x04001515 RID: 5397
		FoodProcessRequest = 21214,
		// Token: 0x04001516 RID: 5398
		CertificateLevelRewardRequest = 15228,
		// Token: 0x04001517 RID: 5399
		CookingDataRequest = 24585,
		// Token: 0x04001518 RID: 5400
		InteractiveUpdateRequest = 23869,
		// Token: 0x04001519 RID: 5401
		DailyAdventurePtRewardRequest = 24837,
		// Token: 0x0400151A RID: 5402
		DailyAdventureTaskRewardRequest = 23720,
		// Token: 0x0400151B RID: 5403
		CheatInputRequest = 16047,
		// Token: 0x0400151C RID: 5404
		EnableDamageRecordRequest = 27554,
		// Token: 0x0400151D RID: 5405
		OutputDebugInfoRequest = 20551,
		// Token: 0x0400151E RID: 5406
		PickUpDropItemRequest = 29110,
		// Token: 0x0400151F RID: 5407
		ElevatorStateChangeRequest = 22336,
		// Token: 0x04001520 RID: 5408
		EnergySyncRequest = 17150,
		// Token: 0x04001521 RID: 5409
		ChangeStateRequest = 20524,
		// Token: 0x04001522 RID: 5410
		ChangeStateConfirmRequest = 17371,
		// Token: 0x04001523 RID: 5411
		FsmConditionPassRequest = 21831,
		// Token: 0x04001524 RID: 5412
		GmEntityFsmGroupInfoRequest = 24535,
		// Token: 0x04001525 RID: 5413
		EntityBuffProducerRequest = 18892,
		// Token: 0x04001526 RID: 5414
		EntityBuffProducerOperateRequest = 25261,
		// Token: 0x04001527 RID: 5415
		LogicStateInitRequest = 18260,
		// Token: 0x04001528 RID: 5416
		SwitchLogicStateRequest = 17062,
		// Token: 0x04001529 RID: 5417
		EntityActiveRequest = 26157,
		// Token: 0x0400152A RID: 5418
		AnimationGameplayTagRequest = 20782,
		// Token: 0x0400152B RID: 5419
		AnimalDieRequest = 20952,
		// Token: 0x0400152C RID: 5420
		AnimalDestroyRequest = 26360,
		// Token: 0x0400152D RID: 5421
		AnimalDropRequest = 27068,
		// Token: 0x0400152E RID: 5422
		EntityInteractRequest = 23858,
		// Token: 0x0400152F RID: 5423
		EntityRandomInteractRequest = 18332,
		// Token: 0x04001530 RID: 5424
		EntityDynamicInteractRequest = 15821,
		// Token: 0x04001531 RID: 5425
		EntityPosAbnormalRequest = 26177,
		// Token: 0x04001532 RID: 5426
		EntityAdsorbRequest = 24232,
		// Token: 0x04001533 RID: 5427
		BoneVisibleChangeRequest = 18467,
		// Token: 0x04001534 RID: 5428
		EntityStaticHookMoveRequest = 23825,
		// Token: 0x04001535 RID: 5429
		EntityPatrolStartRequest = 26715,
		// Token: 0x04001536 RID: 5430
		EntityPatrolStopRequest = 24266,
		// Token: 0x04001537 RID: 5431
		EntityPatrolChangeDirRequest = 16389,
		// Token: 0x04001538 RID: 5432
		VfxNpcPatrolFinishRequest = 26210,
		// Token: 0x04001539 RID: 5433
		EntitySendEventRequest = 22433,
		// Token: 0x0400153A RID: 5434
		AccessPasserbyNpcSpawnerRequest = 21857,
		// Token: 0x0400153B RID: 5435
		ExploreProgressRequest = 19630,
		// Token: 0x0400153C RID: 5436
		ExploreScoreRewardRequest = 23970,
		// Token: 0x0400153D RID: 5437
		CountryExploreScoreInfoRequest = 16184,
		// Token: 0x0400153E RID: 5438
		VisionExploreSkillSetRequest = 16974,
		// Token: 0x0400153F RID: 5439
		ExploreSkillRouletteSetRequest = 15609,
		// Token: 0x04001540 RID: 5440
		ExploreSkillPullGiantRequest = 25809,
		// Token: 0x04001541 RID: 5441
		UseDetectionSkillRequest = 29977,
		// Token: 0x04001542 RID: 5442
		SetFanNumberOfTurnsRequest = 22814,
		// Token: 0x04001543 RID: 5443
		SetBaoziStateRequest = 28381,
		// Token: 0x04001544 RID: 5444
		SetFanStateRequest = 16914,
		// Token: 0x04001545 RID: 5445
		RoleFavorListRequest = 22639,
		// Token: 0x04001546 RID: 5446
		RoleFavorUnLockRequest = 18650,
		// Token: 0x04001547 RID: 5447
		RoleFavorAcceptQuestRequest = 27516,
		// Token: 0x04001548 RID: 5448
		RoleFavorTalkScoreRequest = 18847,
		// Token: 0x04001549 RID: 5449
		RoleMotionUnLockRequest = 29130,
		// Token: 0x0400154A RID: 5450
		SkillRequest = 28732,
		// Token: 0x0400154B RID: 5451
		UseSkillRequest = 15873,
		// Token: 0x0400154C RID: 5452
		EndSkillRequest = 26657,
		// Token: 0x0400154D RID: 5453
		InterruptSkillInDelayRequest = 24013,
		// Token: 0x0400154E RID: 5454
		UseSkillFailRequest = 15861,
		// Token: 0x0400154F RID: 5455
		HitRequest = 17489,
		// Token: 0x04001550 RID: 5456
		HitEndRequest = 19130,
		// Token: 0x04001551 RID: 5457
		CaughtRequest = 17706,
		// Token: 0x04001552 RID: 5458
		CreateBulletRequest = 18246,
		// Token: 0x04001553 RID: 5459
		DestroyBulletRequest = 27103,
		// Token: 0x04001554 RID: 5460
		ModifyBulletParamsRequest = 29414,
		// Token: 0x04001555 RID: 5461
		DamageExecuteRequest = 18654,
		// Token: 0x04001556 RID: 5462
		PassiveSkillAddRequest = 17475,
		// Token: 0x04001557 RID: 5463
		PassiveSkillRemoveRequest = 20977,
		// Token: 0x04001558 RID: 5464
		EnterViewDirectionRequest = 25151,
		// Token: 0x04001559 RID: 5465
		ExitViewDirectionRequest = 16245,
		// Token: 0x0400155A RID: 5466
		TriggerExitSkillRequest = 23172,
		// Token: 0x0400155B RID: 5467
		CharacterDeathRequest = 21948,
		// Token: 0x0400155C RID: 5468
		SwitchBattleModeRequest = 18672,
		// Token: 0x0400155D RID: 5469
		LandingDamageRequest = 27510,
		// Token: 0x0400155E RID: 5470
		EntityIsVisibleRequest = 26500,
		// Token: 0x0400155F RID: 5471
		ActorVisibleRequest = 17594,
		// Token: 0x04001560 RID: 5472
		SwitchCharacterStateRequest = 26359,
		// Token: 0x04001561 RID: 5473
		BattleStateChangeRequest = 19982,
		// Token: 0x04001562 RID: 5474
		ToughCalcExtraRatioChangeRequest = 25451,
		// Token: 0x04001563 RID: 5475
		MonsterBoomRequest = 17163,
		// Token: 0x04001564 RID: 5476
		EntityBattleInfoRequest = 23936,
		// Token: 0x04001565 RID: 5477
		MontagePlayRequest = 27974,
		// Token: 0x04001566 RID: 5478
		ANStartRequest = 25509,
		// Token: 0x04001567 RID: 5479
		SwitchRoleRequest = 27457,
		// Token: 0x04001568 RID: 5480
		UpdateFormationRequest = 23144,
		// Token: 0x04001569 RID: 5481
		UpdateFightRoleRequest = 24496,
		// Token: 0x0400156A RID: 5482
		GetFormationDataRequest = 20343,
		// Token: 0x0400156B RID: 5483
		FlowEndRequest = 26672,
		// Token: 0x0400156C RID: 5484
		FlowRestartRequest = 24285,
		// Token: 0x0400156D RID: 5485
		FlowActionRequest = 22962,
		// Token: 0x0400156E RID: 5486
		ForgeInfoRequest = 16907,
		// Token: 0x0400156F RID: 5487
		ForgeItemRequest = 21849,
		// Token: 0x04001570 RID: 5488
		ForgeFormulaUnlockRequest = 23395,
		// Token: 0x04001571 RID: 5489
		FormationRequest = 22596,
		// Token: 0x04001572 RID: 5490
		FormationSwitchCurrentRequest = 25699,
		// Token: 0x04001573 RID: 5491
		FormationModifyRequest = 15057,
		// Token: 0x04001574 RID: 5492
		FormationChangeRequest = 16758,
		// Token: 0x04001575 RID: 5493
		FormationSwitchRoleRequest = 22661,
		// Token: 0x04001576 RID: 5494
		ClientCurrentRoleReportRequest = 19037,
		// Token: 0x04001577 RID: 5495
		FriendAllRequest = 29479,
		// Token: 0x04001578 RID: 5496
		FriendApplySendRequest = 19323,
		// Token: 0x04001579 RID: 5497
		FriendApplyHandleRequest = 24610,
		// Token: 0x0400157A RID: 5498
		FriendRemarkRequest = 19201,
		// Token: 0x0400157B RID: 5499
		FriendDeleteRequest = 27693,
		// Token: 0x0400157C RID: 5500
		FriendRecentlyTeamRequest = 22709,
		// Token: 0x0400157D RID: 5501
		FuncShowRequest = 25127,
		// Token: 0x0400157E RID: 5502
		GachaInfoRequest = 25069,
		// Token: 0x0400157F RID: 5503
		GachaRequest = 19232,
		// Token: 0x04001580 RID: 5504
		GachaUsePoolRequest = 29160,
		// Token: 0x04001581 RID: 5505
		GatherActivityRewardRequest = 22600,
		// Token: 0x04001582 RID: 5506
		GuideInfoRequest = 15732,
		// Token: 0x04001583 RID: 5507
		GuideTriggerRequest = 27818,
		// Token: 0x04001584 RID: 5508
		GuideFinishRequest = 22758,
		// Token: 0x04001585 RID: 5509
		HeartbeatRequest = 1650,
		// Token: 0x04001586 RID: 5510
		GatewayEchoRequest = 29209,
		// Token: 0x04001587 RID: 5511
		IllustratedRedDotRequest = 17930,
		// Token: 0x04001588 RID: 5512
		IllustratedInfoRequest = 15484,
		// Token: 0x04001589 RID: 5513
		IllustratedUnlockRequest = 19831,
		// Token: 0x0400158A RID: 5514
		IllustratedReadRequest = 19077,
		// Token: 0x0400158B RID: 5515
		InfluenceInfoRequest = 29194,
		// Token: 0x0400158C RID: 5516
		InfluenceRewardRequest = 19523,
		// Token: 0x0400158D RID: 5517
		ReadDisplayInfoRequest = 22933,
		// Token: 0x0400158E RID: 5518
		EnterInstRequest = 18872,
		// Token: 0x0400158F RID: 5519
		UnlockInstEntranceRequest = 16204,
		// Token: 0x04001590 RID: 5520
		InstEntranceDetailRequest = 19282,
		// Token: 0x04001591 RID: 5521
		LeaveInstRequest = 21028,
		// Token: 0x04001592 RID: 5522
		GetInstExchangeRewardRequest = 25904,
		// Token: 0x04001593 RID: 5523
		ExchangeRewardInfoRequest = 25606,
		// Token: 0x04001594 RID: 5524
		SingleInstRechallengeRequest = 20682,
		// Token: 0x04001595 RID: 5525
		ItemDecomposeRequest = 17570,
		// Token: 0x04001596 RID: 5526
		ItemDecomposePreviewRequest = 26576,
		// Token: 0x04001597 RID: 5527
		ItemLockRequest = 26312,
		// Token: 0x04001598 RID: 5528
		ItemUseRequest = 15211,
		// Token: 0x04001599 RID: 5529
		ItemGiftUseRequest = 25405,
		// Token: 0x0400159A RID: 5530
		NormalItemRequest = 17423,
		// Token: 0x0400159B RID: 5531
		WeaponItemRequest = 28901,
		// Token: 0x0400159C RID: 5532
		PhantomItemRequest = 24954,
		// Token: 0x0400159D RID: 5533
		InvalidItemRequest = 17597,
		// Token: 0x0400159E RID: 5534
		ShowInvalidItemRequest = 22706,
		// Token: 0x0400159F RID: 5535
		ValidTimeItemRequest = 17241,
		// Token: 0x040015A0 RID: 5536
		ItemExchangeInfoRequest = 16256,
		// Token: 0x040015A1 RID: 5537
		ItemExchangeRequest = 16929,
		// Token: 0x040015A2 RID: 5538
		LevelPlayRewardRequest = 20160,
		// Token: 0x040015A3 RID: 5539
		LivenessRequest = 19066,
		// Token: 0x040015A4 RID: 5540
		LivenessTaskTakeRequest = 29864,
		// Token: 0x040015A5 RID: 5541
		LivenessTakeRequest = 24082,
		// Token: 0x040015A6 RID: 5542
		LoadEquipInfoRequest = 28824,
		// Token: 0x040015A7 RID: 5543
		EquipTakeOnRequest = 21385,
		// Token: 0x040015A8 RID: 5544
		LordGymInfoRequest = 24178,
		// Token: 0x040015A9 RID: 5545
		LordGymBeginRequest = 16902,
		// Token: 0x040015AA RID: 5546
		LordGymReadRequest = 22064,
		// Token: 0x040015AB RID: 5547
		MailReadRequest = 20227,
		// Token: 0x040015AC RID: 5548
		MailGetAttachmentRequest = 15409,
		// Token: 0x040015AD RID: 5549
		MailDeleteRequest = 23960,
		// Token: 0x040015AE RID: 5550
		MapMarkInfoRequest = 29776,
		// Token: 0x040015AF RID: 5551
		MapUnlockFieldInfoRequest = 15442,
		// Token: 0x040015B0 RID: 5552
		MapMarkRequest = 16871,
		// Token: 0x040015B1 RID: 5553
		MapRemoveMarkRequest = 16284,
		// Token: 0x040015B2 RID: 5554
		MapTraceInfoRequest = 20733,
		// Token: 0x040015B3 RID: 5555
		MapTraceRequest = 24772,
		// Token: 0x040015B4 RID: 5556
		MapCancelTraceRequest = 17205,
		// Token: 0x040015B5 RID: 5557
		MapReplaceMarkRequest = 28254,
		// Token: 0x040015B6 RID: 5558
		MapRemoveAllMarkRequest = 26361,
		// Token: 0x040015B7 RID: 5559
		MapMarkInfoUpdateRequest = 26212,
		// Token: 0x040015B8 RID: 5560
		StartMatchRequest = 23965,
		// Token: 0x040015B9 RID: 5561
		CancelMatchRequest = 15153,
		// Token: 0x040015BA RID: 5562
		MatchConfirmRequest = 17484,
		// Token: 0x040015BB RID: 5563
		MatchChangeRoleRequest = 21491,
		// Token: 0x040015BC RID: 5564
		MatchChangeReadyRequest = 26852,
		// Token: 0x040015BD RID: 5565
		LeaveMatchTeamRequest = 27683,
		// Token: 0x040015BE RID: 5566
		KickMatchTeamPlayerRequest = 24963,
		// Token: 0x040015BF RID: 5567
		SetMatchTeamMatchFlagRequest = 22339,
		// Token: 0x040015C0 RID: 5568
		EnterMatchInstRequest = 23840,
		// Token: 0x040015C1 RID: 5569
		TeamChallengeRequest = 16714,
		// Token: 0x040015C2 RID: 5570
		TeamMatchInviteRequest = 18437,
		// Token: 0x040015C3 RID: 5571
		TeamMatchAcceptInviteRequest = 22419,
		// Token: 0x040015C4 RID: 5572
		MatchChangePlayerUiStateRequest = 29714,
		// Token: 0x040015C5 RID: 5573
		HandInMingSuRequest = 20726,
		// Token: 0x040015C6 RID: 5574
		ActiveDragonPoolRequest = 27171,
		// Token: 0x040015C7 RID: 5575
		DragonPoolConfRequest = 18045,
		// Token: 0x040015C8 RID: 5576
		MonthCardRequest = 22235,
		// Token: 0x040015C9 RID: 5577
		MutiplayerTeamRefreshNearListRequest = 17426,
		// Token: 0x040015CA RID: 5578
		NetTestDataRequest = 17003,
		// Token: 0x040015CB RID: 5579
		NewBieCourseRewardRequest = 28328,
		// Token: 0x040015CC RID: 5580
		NewJourneyRequest = 21748,
		// Token: 0x040015CD RID: 5581
		ParkourChallengeRequest = 21481,
		// Token: 0x040015CE RID: 5582
		ParkourChallengeTakeRequest = 24399,
		// Token: 0x040015CF RID: 5583
		ParkourChallengeTransRequest = 27756,
		// Token: 0x040015D0 RID: 5584
		PartComponentInitRequest = 18536,
		// Token: 0x040015D1 RID: 5585
		PartUpdateRequest = 22158,
		// Token: 0x040015D2 RID: 5586
		PayInfoRequest = 23421,
		// Token: 0x040015D3 RID: 5587
		PayItemRequest = 16704,
		// Token: 0x040015D4 RID: 5588
		PayGiftInfoRequest = 21361,
		// Token: 0x040015D5 RID: 5589
		PayGiftRequest = 16617,
		// Token: 0x040015D6 RID: 5590
		PayShopInfoRequest = 21126,
		// Token: 0x040015D7 RID: 5591
		PayShopUpdateRequest = 29578,
		// Token: 0x040015D8 RID: 5592
		PayShopItemUpdateRequest = 21015,
		// Token: 0x040015D9 RID: 5593
		PayShopBuyRequest = 28780,
		// Token: 0x040015DA RID: 5594
		PayShopDirectBuyRequest = 28237,
		// Token: 0x040015DB RID: 5595
		PhantomLevelUpRequest = 25666,
		// Token: 0x040015DC RID: 5596
		PhantomPutOnRequest = 25608,
		// Token: 0x040015DD RID: 5597
		PhantomReturnPreviewRequest = 18276,
		// Token: 0x040015DE RID: 5598
		PhantomReturnRequest = 16594,
		// Token: 0x040015DF RID: 5599
		PhantomRecommendRequest = 21254,
		// Token: 0x040015E0 RID: 5600
		PhantomAutoPutRequest = 25130,
		// Token: 0x040015E1 RID: 5601
		PhantomIdentifyRequest = 26204,
		// Token: 0x040015E2 RID: 5602
		PhantomSkinChangeRequest = 22400,
		// Token: 0x040015E3 RID: 5603
		PhantomRefiningRequest = 27747,
		// Token: 0x040015E4 RID: 5604
		UpdatePlayerPassiveSkillRequest = 20221,
		// Token: 0x040015E5 RID: 5605
		PlayerMotionRequest = 17665,
		// Token: 0x040015E6 RID: 5606
		PressRequest = 15361,
		// Token: 0x040015E7 RID: 5607
		PressGameRequest = 19675,
		// Token: 0x040015E8 RID: 5608
		ProgressBarFinishRequest = 24347,
		// Token: 0x040015E9 RID: 5609
		FormationAttrRequest = 19501,
		// Token: 0x040015EA RID: 5610
		FragileChangeRequest = 22818,
		// Token: 0x040015EB RID: 5611
		CheckPublicResourceVersionRequest = 17400,
		// Token: 0x040015EC RID: 5612
		TraceQuestRequest = 26774,
		// Token: 0x040015ED RID: 5613
		QuestFinishActionRequest = 15063,
		// Token: 0x040015EE RID: 5614
		QuestActionRequest = 18164,
		// Token: 0x040015EF RID: 5615
		QuestNpcMoveOverRequest = 19428,
		// Token: 0x040015F0 RID: 5616
		QuestFinishActionEndRequest = 29054,
		// Token: 0x040015F1 RID: 5617
		DailyQuestChangePreferRequest = 23357,
		// Token: 0x040015F2 RID: 5618
		DailyQuestGetRewardRequest = 15012,
		// Token: 0x040015F3 RID: 5619
		RoleQuestAcceptRequest = 18275,
		// Token: 0x040015F4 RID: 5620
		RoleQuestPointStateRequest = 29691,
		// Token: 0x040015F5 RID: 5621
		QuestRedDotRequest = 28280,
		// Token: 0x040015F6 RID: 5622
		ApplyRechallengeRequest = 24437,
		// Token: 0x040015F7 RID: 5623
		ReceiveRechallengeRequest = 25942,
		// Token: 0x040015F8 RID: 5624
		InviteRechallengeRequest = 27109,
		// Token: 0x040015F9 RID: 5625
		ReviveRequest = 15137,
		// Token: 0x040015FA RID: 5626
		AddReviveRegionRequest = 21181,
		// Token: 0x040015FB RID: 5627
		RemoveReviveRegionRequest = 15252,
		// Token: 0x040015FC RID: 5628
		RoguelikeRefreshGainRequest = 20860,
		// Token: 0x040015FD RID: 5629
		RoguelikeChooseDataRequest = 25554,
		// Token: 0x040015FE RID: 5630
		RoguelikeChooseDataResultRequest = 18731,
		// Token: 0x040015FF RID: 5631
		RoguelikeLastInfoRequest = 17013,
		// Token: 0x04001600 RID: 5632
		RoguelikeStartRequest = 22052,
		// Token: 0x04001601 RID: 5633
		RoguelikeQuitRequest = 18528,
		// Token: 0x04001602 RID: 5634
		RoguelikeResultRequest = 20242,
		// Token: 0x04001603 RID: 5635
		RoguelikeGotoNextRoomRequest = 20444,
		// Token: 0x04001604 RID: 5636
		RoguelikeTalentInfoRequest = 17548,
		// Token: 0x04001605 RID: 5637
		RoguelikeTalentLevelUpRequest = 29178,
		// Token: 0x04001606 RID: 5638
		RoguelikeSeasonDataRequest = 15218,
		// Token: 0x04001607 RID: 5639
		RoguelikeTokenReceiveRequest = 18099,
		// Token: 0x04001608 RID: 5640
		RoguelikeSeasonRewardReceiveRequest = 20035,
		// Token: 0x04001609 RID: 5641
		RoguelikeGiveUpGainRequest = 29402,
		// Token: 0x0400160A RID: 5642
		PbGetRoleListRequest = 28529,
		// Token: 0x0400160B RID: 5643
		PbUpLevelRoleRequest = 17360,
		// Token: 0x0400160C RID: 5644
		PbOverRoleRequest = 17152,
		// Token: 0x0400160D RID: 5645
		PbUpLevelSkillRequest = 25868,
		// Token: 0x0400160E RID: 5646
		RoleLevelUpViewRequest = 21169,
		// Token: 0x0400160F RID: 5647
		RoleBreakThroughViewRequest = 22171,
		// Token: 0x04001610 RID: 5648
		RoleSkillLevelUpViewRequest = 28071,
		// Token: 0x04001611 RID: 5649
		RoleSkillViewRequest = 22013,
		// Token: 0x04001612 RID: 5650
		RoleActivateSkillRequest = 17616,
		// Token: 0x04001613 RID: 5651
		ResonantChainUnlockRequest = 17339,
		// Token: 0x04001614 RID: 5652
		RoleSexChangeRequest = 17543,
		// Token: 0x04001615 RID: 5653
		RoleElementChangeRequest = 29639,
		// Token: 0x04001616 RID: 5654
		TrialRoleRewardRequest = 22659,
		// Token: 0x04001617 RID: 5655
		CaptureEntityRequest = 15300,
		// Token: 0x04001618 RID: 5656
		RemoveSummonEntityRequest = 17165,
		// Token: 0x04001619 RID: 5657
		ChangeEntityRoleRequest = 24621,
		// Token: 0x0400161A RID: 5658
		EntityOnLandedRequest = 21482,
		// Token: 0x0400161B RID: 5659
		AttributeInitRequest = 18143,
		// Token: 0x0400161C RID: 5660
		AttributeChangedRequest = 19018,
		// Token: 0x0400161D RID: 5661
		AnimationStateInitRequest = 29999,
		// Token: 0x0400161E RID: 5662
		AnimationStateChangedRequest = 17015,
		// Token: 0x0400161F RID: 5663
		HardnessModeChangedRequest = 19311,
		// Token: 0x04001620 RID: 5664
		SummonRequest = 26598,
		// Token: 0x04001621 RID: 5665
		Summon2Request = 24593,
		// Token: 0x04001622 RID: 5666
		RemoveInstanceTimerRequest = 24804,
		// Token: 0x04001623 RID: 5667
		UpdateSceneDateRequest = 25350,
		// Token: 0x04001624 RID: 5668
		DiscardWeaponRequest = 18527,
		// Token: 0x04001625 RID: 5669
		CreatStoryCharacterRequest = 29348,
		// Token: 0x04001626 RID: 5670
		DeleteStoryCharacterRequest = 22583,
		// Token: 0x04001627 RID: 5671
		CreatureDetailRequest = 21574,
		// Token: 0x04001628 RID: 5672
		ChangeEntityStateRequest = 18733,
		// Token: 0x04001629 RID: 5673
		FoundationRequest = 23886,
		// Token: 0x0400162A RID: 5674
		BeControlledRequest = 16785,
		// Token: 0x0400162B RID: 5675
		BeControlledShowRequest = 20029,
		// Token: 0x0400162C RID: 5676
		BeControlledThrowRequest = 25094,
		// Token: 0x0400162D RID: 5677
		GravityGearRequest = 28261,
		// Token: 0x0400162E RID: 5678
		ChangeWeatherRequest = 29890,
		// Token: 0x0400162F RID: 5679
		FollowTrackRequest = 25969,
		// Token: 0x04001630 RID: 5680
		SetInitTagRequest = 19030,
		// Token: 0x04001631 RID: 5681
		DrownRequest = 25778,
		// Token: 0x04001632 RID: 5682
		DrownEndTeleportRequest = 21245,
		// Token: 0x04001633 RID: 5683
		MonsterDrownRequest = 20753,
		// Token: 0x04001634 RID: 5684
		SceneLoadingFinishRequest = 27192,
		// Token: 0x04001635 RID: 5685
		SitChairRequest = 25917,
		// Token: 0x04001636 RID: 5686
		BeControlledDestroyRequest = 26102,
		// Token: 0x04001637 RID: 5687
		ChangeDataLayerFinishRequest = 16648,
		// Token: 0x04001638 RID: 5688
		MoveSceneItemResetPositionRequest = 27648,
		// Token: 0x04001639 RID: 5689
		HookLockPointRequest = 16301,
		// Token: 0x0400163A RID: 5690
		CheckGearRequest = 27460,
		// Token: 0x0400163B RID: 5691
		SceneItemStateRequest = 23046,
		// Token: 0x0400163C RID: 5692
		MaterialRequest = 17530,
		// Token: 0x0400163D RID: 5693
		CommonOrganResetTimeRequest = 22989,
		// Token: 0x0400163E RID: 5694
		TargetGearHitRequest = 20478,
		// Token: 0x0400163F RID: 5695
		ThrowDamageRequest = 25936,
		// Token: 0x04001640 RID: 5696
		GetRewardTreasureBoxRequest = 20848,
		// Token: 0x04001641 RID: 5697
		MobileButtonSettingUpdateRequest = 25947,
		// Token: 0x04001642 RID: 5698
		LanguageSettingUpdateRequest = 22740,
		// Token: 0x04001643 RID: 5699
		ShopInfoRequest = 29540,
		// Token: 0x04001644 RID: 5700
		ShopBuyRequest = 28078,
		// Token: 0x04001645 RID: 5701
		ShopUpdateRequest = 17187,
		// Token: 0x04001646 RID: 5702
		SneakFinishRequest = 20851,
		// Token: 0x04001647 RID: 5703
		SpecialItemEquipRequest = 17718,
		// Token: 0x04001648 RID: 5704
		SpecialItemUnEquipRequest = 19843,
		// Token: 0x04001649 RID: 5705
		SynthesisInfoRequest = 25534,
		// Token: 0x0400164A RID: 5706
		SynthesisItemRequest = 24085,
		// Token: 0x0400164B RID: 5707
		SynthesisLevelRewardRequest = 15075,
		// Token: 0x0400164C RID: 5708
		SynthesisFormulaUnlockRequest = 23511,
		// Token: 0x0400164D RID: 5709
		TeleportDataRequest = 18464,
		// Token: 0x0400164E RID: 5710
		TeleportTransferRequest = 24606,
		// Token: 0x0400164F RID: 5711
		TeleportFinishRequest = 28614,
		// Token: 0x04001650 RID: 5712
		UnOpenedAreaPullbackRequest = 17532,
		// Token: 0x04001651 RID: 5713
		RemoveTemporaryTeleportRequest = 22106,
		// Token: 0x04001652 RID: 5714
		TeleportToTargetRequest = 28616,
		// Token: 0x04001653 RID: 5715
		ThirdPartyShareRequest = 17006,
		// Token: 0x04001654 RID: 5716
		RTimeStopRequest = 16580,
		// Token: 0x04001655 RID: 5717
		RTimeStopInstRequest = 18157,
		// Token: 0x04001656 RID: 5718
		TimelineTraceStartRequest = 29145,
		// Token: 0x04001657 RID: 5719
		TimelineTraceControlRequest = 26029,
		// Token: 0x04001658 RID: 5720
		TimelineTraceExitRequest = 28107,
		// Token: 0x04001659 RID: 5721
		TimeCheckRequest = 28799,
		// Token: 0x0400165A RID: 5722
		TowerRequest = 26406,
		// Token: 0x0400165B RID: 5723
		TowerSeasonUpdateRequest = 24072,
		// Token: 0x0400165C RID: 5724
		TowerFormationRecommendRequest = 16303,
		// Token: 0x0400165D RID: 5725
		TowerRewardRequest = 27282,
		// Token: 0x0400165E RID: 5726
		TowerStartRequest = 19933,
		// Token: 0x0400165F RID: 5727
		TowerResetRequest = 27650,
		// Token: 0x04001660 RID: 5728
		TowerApplyFloorDataRequest = 21733,
		// Token: 0x04001661 RID: 5729
		TowerGuideActivityRewardRequest = 16778,
		// Token: 0x04001662 RID: 5730
		TowerGuideActivityInfoRequest = 19610,
		// Token: 0x04001663 RID: 5731
		TurntableCompleteRequest = 20102,
		// Token: 0x04001664 RID: 5732
		TutorialInfoRequest = 15006,
		// Token: 0x04001665 RID: 5733
		TutorialReceiveRequest = 27270,
		// Token: 0x04001666 RID: 5734
		TutorialUnlockRequest = 21852,
		// Token: 0x04001667 RID: 5735
		WeaponLevelUpRequest = 19242,
		// Token: 0x04001668 RID: 5736
		WeaponBreachRequest = 16833,
		// Token: 0x04001669 RID: 5737
		WeaponResonUpRequest = 17476,
		// Token: 0x0400166A RID: 5738
		WorldLevelDownRequest = 17014,
		// Token: 0x0400166B RID: 5739
		WorldLevelRegainRequest = 26635,
		// Token: 0x0400166C RID: 5740
		WorldEnterPermissionsRequest = 20021,
		// Token: 0x0400166D RID: 5741
		ApplyJoinWorldRequest = 17687,
		// Token: 0x0400166E RID: 5742
		AgreeJoinResultRequest = 16876,
		// Token: 0x0400166F RID: 5743
		LobbyListRequest = 28398,
		// Token: 0x04001670 RID: 5744
		LobbyQueryPlayersRequest = 27890,
		// Token: 0x04001671 RID: 5745
		LeaveWorldTeamRequest = 16004,
		// Token: 0x04001672 RID: 5746
		KickWorldTeamRequest = 27061,
		// Token: 0x04001673 RID: 5747
		EntityBeamReceiveRequest = 22992,
		// Token: 0x04001674 RID: 5748
		AttachEntityRequest = 25142,
		// Token: 0x04001675 RID: 5749
		EntityPatrolAddTagRequest = 22474,
		// Token: 0x04001676 RID: 5750
		LongShanTaskRewardRequest = 26202,
		// Token: 0x04001677 RID: 5751
		EntityAccessRangeRequest = 22475,
		// Token: 0x04001678 RID: 5752
		PlayerAccessRangeRequest = 20505,
		// Token: 0x04001679 RID: 5753
		RoguelikePopularEntriesInfoRequest = 26192,
		// Token: 0x0400167A RID: 5754
		RoguelikePopularEntriesChangeRequest = 24745,
		// Token: 0x0400167B RID: 5755
		HookLockPointFinishRequest = 15520,
		// Token: 0x0400167C RID: 5756
		BuildingLevelUpRequest = 22480,
		// Token: 0x0400167D RID: 5757
		RoleTrainRequest = 15533,
		// Token: 0x0400167E RID: 5758
		AcceptEntrustRequest = 29331,
		// Token: 0x0400167F RID: 5759
		InvestRequest = 16522,
		// Token: 0x04001680 RID: 5760
		TrackMoonEntrustDataRequest = 28535,
		// Token: 0x04001681 RID: 5761
		TrackMoonRoleDataRequest = 20217,
		// Token: 0x04001682 RID: 5762
		RunTurntableActivityRequest = 15007,
		// Token: 0x04001683 RID: 5763
		TrackMoonBuildingDataRequest = 26292,
		// Token: 0x04001684 RID: 5764
		BuildingUnLockRequest = 26985,
		// Token: 0x04001685 RID: 5765
		BossRushClaimRewardRequest = 17500,
		// Token: 0x04001686 RID: 5766
		BossRushSettlementRequest = 19575,
		// Token: 0x04001687 RID: 5767
		SceneModeChangeFinishRequest = 16826,
		// Token: 0x04001688 RID: 5768
		RoguelikeTrialRoleInfoRequest = 19261,
		// Token: 0x04001689 RID: 5769
		PhotoMemoryRequest = 25225,
		// Token: 0x0400168A RID: 5770
		PhotoMemoryRewardRequest = 27468,
		// Token: 0x0400168B RID: 5771
		SceneItemSetPosSenderRequest = 26876,
		// Token: 0x0400168C RID: 5772
		TraceEntityPosRequest = 21153,
		// Token: 0x0400168D RID: 5773
		CombatMessagePrefixInfoRequest = 28795,
		// Token: 0x0400168E RID: 5774
		CombatMessagePostInfoRequest = 17769,
		// Token: 0x0400168F RID: 5775
		TrackMoonTargetRewardRequest = 19837,
		// Token: 0x04001690 RID: 5776
		FsmStateBehaviorRequest = 23005,
		// Token: 0x04001691 RID: 5777
		FsmPlayMontageRequest = 25815,
		// Token: 0x04001692 RID: 5778
		RTimeStopAnimRequest = 28674,
		// Token: 0x04001693 RID: 5779
		RolePropRequest = 29283,
		// Token: 0x04001694 RID: 5780
		TrackMoonSettleRequest = 15206,
		// Token: 0x04001695 RID: 5781
		TrackMoonIllustratedRequest = 21304,
		// Token: 0x04001696 RID: 5782
		TowerDefenceInstanceRewardRequest = 23941,
		// Token: 0x04001697 RID: 5783
		TowerDefenceScoreRewardRequest = 18725,
		// Token: 0x04001698 RID: 5784
		FlowTeleportToPlotPosRequest = 20939,
		// Token: 0x04001699 RID: 5785
		ConnectorConnectEntityRequest = 29745,
		// Token: 0x0400169A RID: 5786
		BeControlledEntityHoverRequest = 15955,
		// Token: 0x0400169B RID: 5787
		InitRangeRequest = 16207,
		// Token: 0x0400169C RID: 5788
		TrackMoonActivityRewardRequest = 28834,
		// Token: 0x0400169D RID: 5789
		TimePointActivityRewardRequest = 25635,
		// Token: 0x0400169E RID: 5790
		CircumFluenceTaskRewardRequest = 25593,
		// Token: 0x0400169F RID: 5791
		GameplayCueRequest = 20852,
		// Token: 0x040016A0 RID: 5792
		SceneItemStopRequest = 29926,
		// Token: 0x040016A1 RID: 5793
		RoguelikeRoleRoomSelectRequest = 18165,
		// Token: 0x040016A2 RID: 5794
		SecFBRoundStartFlowRequest = 23993,
		// Token: 0x040016A3 RID: 5795
		SecGetReportData2FlowRequest = 23542,
		// Token: 0x040016A4 RID: 5796
		SecFBRoundEndFlowReportRequest = 17956,
		// Token: 0x040016A5 RID: 5797
		SecRoleFightFlowRequest = 21319,
		// Token: 0x040016A6 RID: 5798
		SecWorldInfoFlowRequest = 24782,
		// Token: 0x040016A7 RID: 5799
		SecWorldStartFlowRequest = 27803,
		// Token: 0x040016A8 RID: 5800
		SecWorldSEndFlowRequest = 16078,
		// Token: 0x040016A9 RID: 5801
		AwakeDynamicPortalRequest = 24473,
		// Token: 0x040016AA RID: 5802
		GachaPoolDetailRequest = 21264,
		// Token: 0x040016AB RID: 5803
		OpenSystemBoardResultRequest = 24936,
		// Token: 0x040016AC RID: 5804
		SceneItemMoveTargetRequest = 24132,
		// Token: 0x040016AD RID: 5805
		TrackMoonBuildFlowRequest = 21892,
		// Token: 0x040016AE RID: 5806
		CorniceMeetingRewardRequest = 18385,
		// Token: 0x040016AF RID: 5807
		TraceMoonPhaseRewardRequest = 23777,
		// Token: 0x040016B0 RID: 5808
		LevelPlaySwitchSportModeRequest = 23163,
		// Token: 0x040016B1 RID: 5809
		PlayerPsnInfoGetRequest = 29956,
		// Token: 0x040016B2 RID: 5810
		PsnSettingUpdateRequest = 24513,
		// Token: 0x040016B3 RID: 5811
		PsnSettingRequest = 29119,
		// Token: 0x040016B4 RID: 5812
		RiskHarvestInstRewardRequest = 16068,
		// Token: 0x040016B5 RID: 5813
		RiskHarvestScoreRewardRequest = 26581,
		// Token: 0x040016B6 RID: 5814
		ItemDisuseRequest = 20767,
		// Token: 0x040016B7 RID: 5815
		PhantomBatchRefiningRequest = 27203,
		// Token: 0x040016B8 RID: 5816
		PassPortalRequest = 20215,
		// Token: 0x040016B9 RID: 5817
		EnrichmentAreaRequest = 27870,
		// Token: 0x040016BA RID: 5818
		RiskHarvestBuffUnlockRewardRequest = 29264,
		// Token: 0x040016BB RID: 5819
		RiskHarvestBuffCountRewardRequest = 16445,
		// Token: 0x040016BC RID: 5820
		BlackCoastThemeTaskRewardRequest = 23757,
		// Token: 0x040016BD RID: 5821
		BlackCoastThemeActiveRewardRequest = 26746,
		// Token: 0x040016BE RID: 5822
		PlayerCreatePsnSessionRequest = 21404,
		// Token: 0x040016BF RID: 5823
		RenjuResetRequest = 16999,
		// Token: 0x040016C0 RID: 5824
		CorniceChallengeTransRequest = 23951,
		// Token: 0x040016C1 RID: 5825
		GameplayTagRequest = 17502,
		// Token: 0x040016C2 RID: 5826
		ExecuteQteRequest = 25206,
		// Token: 0x040016C3 RID: 5827
		RiskHarvestSettleRequest = 29019,
		// Token: 0x040016C4 RID: 5828
		MingSuHandRewardRequest = 28370,
		// Token: 0x040016C5 RID: 5829
		SubmitAwakeAndLoadEntityNodeRequest = 17608,
		// Token: 0x040016C6 RID: 5830
		RoguelikeRoleInstStartRequest = 27659,
		// Token: 0x040016C7 RID: 5831
		RoguelikeBossInstStartRequest = 28063,
		// Token: 0x040016C8 RID: 5832
		PreheatSignRewardRequest = 20458,
		// Token: 0x040016C9 RID: 5833
		PreheatSignSurveyInfoRequest = 15013,
		// Token: 0x040016CA RID: 5834
		DarkCoastInfoRequest = 20643,
		// Token: 0x040016CB RID: 5835
		InputSettingRequest = 28228,
		// Token: 0x040016CC RID: 5836
		InputSettingUpdateRequest = 20344,
		// Token: 0x040016CD RID: 5837
		RoguelikeWriteCatRewardRequest = 26136,
		// Token: 0x040016CE RID: 5838
		ConnectorCanConnectRequest = 27563,
		// Token: 0x040016CF RID: 5839
		ScratchCardRewardRequest = 23653,
		// Token: 0x040016D0 RID: 5840
		TeleportDungeonActionRequest = 17415,
		// Token: 0x040016D1 RID: 5841
		SubmitWalkingPatternPointRequest = 17328,
		// Token: 0x040016D2 RID: 5842
		RoguelikeWriteCatBossRewardRequest = 19415,
		// Token: 0x040016D3 RID: 5843
		RoguelikeWriteCatLevelPlayRewardRequest = 25589,
		// Token: 0x040016D4 RID: 5844
		PlayerPsnBlockListRequest = 16257,
		// Token: 0x040016D5 RID: 5845
		VacuumCleanerRequest = 22748,
		// Token: 0x040016D6 RID: 5846
		BossRushChooseBuffRequest = 29389,
		// Token: 0x040016D7 RID: 5847
		BossRushBuffChooseResultRequest = 23159,
		// Token: 0x040016D8 RID: 5848
		JoinSceneNotifyConfirmRequest = 22643,
		// Token: 0x040016D9 RID: 5849
		MailBindInfoRequest = 19713,
		// Token: 0x040016DA RID: 5850
		MailBindRewardRequest = 24034,
		// Token: 0x040016DB RID: 5851
		MailBindRequest = 22555,
		// Token: 0x040016DC RID: 5852
		HookLockPointExitRequest = 15425,
		// Token: 0x040016DD RID: 5853
		VehicleRequest = 21983,
		// Token: 0x040016DE RID: 5854
		PullingFoundationRequest = 19966,
		// Token: 0x040016DF RID: 5855
		AddTreasureBoxSlotRequest = 23884,
		// Token: 0x040016E0 RID: 5856
		RemoveTreasureBoxSlotRequest = 21336,
		// Token: 0x040016E1 RID: 5857
		UseSoundBoxSkillRequest = 15919,
		// Token: 0x040016E2 RID: 5858
		AddTemporaryTeleportRequest = 25491,
		// Token: 0x040016E3 RID: 5859
		BossRushLevelScoreRewardRequest = 24337,
		// Token: 0x040016E4 RID: 5860
		EquipSkinTakeOnRequest = 16426,
		// Token: 0x040016E5 RID: 5861
		EquipSkinUnLoadRequest = 25017,
		// Token: 0x040016E6 RID: 5862
		SubmitPhotoNodeRequest = 24093,
		// Token: 0x040016E7 RID: 5863
		RogueWhiteCatLimitedRewardRequest = 29426,
		// Token: 0x040016E8 RID: 5864
		ScratchCardActivityInfoRequest = 27153,
		// Token: 0x040016E9 RID: 5865
		QuestReadyForGiveUpRequest = 27030,
		// Token: 0x040016EA RID: 5866
		RogueWhiteCatRecordRequest = 23990,
		// Token: 0x040016EB RID: 5867
		SetAlertUiVisibleRequest = 25636,
		// Token: 0x040016EC RID: 5868
		CombineEntitiesRequest = 28910,
		// Token: 0x040016ED RID: 5869
		GiftPackPreviewRequest = 29403,
		// Token: 0x040016EE RID: 5870
		LastBigSceneMiniMapInfoRequest = 28705,
		// Token: 0x040016EF RID: 5871
		DissolveCombineRelationRequest = 20585,
		// Token: 0x040016F0 RID: 5872
		ExploreSkillCustomRequest = 28056,
		// Token: 0x040016F1 RID: 5873
		AchievementUpdateRequest = 28975,
		// Token: 0x040016F2 RID: 5874
		SeamlessTeleportRequest = 17907,
		// Token: 0x040016F3 RID: 5875
		RogueBlackFlowerRequest = 24506,
		// Token: 0x040016F4 RID: 5876
		UpdateSceneGroupDataRequest = 16945,
		// Token: 0x040016F5 RID: 5877
		MowTowerSettlementRequest = 26061,
		// Token: 0x040016F6 RID: 5878
		MowTowerLevelsRewardRequest = 16582,
		// Token: 0x040016F7 RID: 5879
		RoleSkinChangeRequest = 26398,
		// Token: 0x040016F8 RID: 5880
		RoleSkinRequest = 26601,
		// Token: 0x040016F9 RID: 5881
		PhantomMusicUnlockRequest = 25144,
		// Token: 0x040016FA RID: 5882
		PhantomMusicInfoRequest = 16180,
		// Token: 0x040016FB RID: 5883
		PhantomMusicSwitchRequest = 23417,
		// Token: 0x040016FC RID: 5884
		UpdateSceneItemBlackboardRequest = 15059,
		// Token: 0x040016FD RID: 5885
		VehicleChangePassengerRequest = 22200,
		// Token: 0x040016FE RID: 5886
		VehicleRemovePassengerRequest = 26143,
		// Token: 0x040016FF RID: 5887
		LevelSequenceFrameEventActionRequest = 20312,
		// Token: 0x04001700 RID: 5888
		SimpleTrackReportRequest = 15365,
		// Token: 0x04001701 RID: 5889
		PlayerVoxelEnvRequest = 27177,
		// Token: 0x04001702 RID: 5890
		MapTravelFullRewardRequest = 21062,
		// Token: 0x04001703 RID: 5891
		MapTravelLevelUpRequest = 24973,
		// Token: 0x04001704 RID: 5892
		SpringSignDrawRoleRequest = 18204,
		// Token: 0x04001705 RID: 5893
		LevelPlayVarRequest = 17974,
		// Token: 0x04001706 RID: 5894
		MaterialReplaceRequest = 26427,
		// Token: 0x04001707 RID: 5895
		ExploreProgressRewardRequest = 29451,
		// Token: 0x04001708 RID: 5896
		SpringSignDrawRewardRequest = 17001,
		// Token: 0x04001709 RID: 5897
		EntityCameraAlertRequest = 15507,
		// Token: 0x0400170A RID: 5898
		ThroughTrainRequest = 26589,
		// Token: 0x0400170B RID: 5899
		FarmGoldLevelDiffRequest = 19651,
		// Token: 0x0400170C RID: 5900
		CheckUseSoundBoxSkillRequest = 16116,
		// Token: 0x0400170D RID: 5901
		FarmGoldPointRequest = 25630,
		// Token: 0x0400170E RID: 5902
		FarmGoldLevelPlayRequest = 22663,
		// Token: 0x0400170F RID: 5903
		SpringSignSkinRewardRequest = 20317,
		// Token: 0x04001710 RID: 5904
		FarmGoldResultRequest = 20486,
		// Token: 0x04001711 RID: 5905
		FlowSeqSetPlayerPosRequest = 29398,
		// Token: 0x04001712 RID: 5906
		SplineMoveRequest = 26613,
		// Token: 0x04001713 RID: 5907
		LevelPlayStateRequest = 16155,
		// Token: 0x04001714 RID: 5908
		PlayerHeadRequest = 18199,
		// Token: 0x04001715 RID: 5909
		EntityWalkingPatternFinishRequest = 29045,
		// Token: 0x04001716 RID: 5910
		QueryOnlinePlayersAreaRequest = 15827,
		// Token: 0x04001717 RID: 5911
		MapTravelTaskRewardRequest = 24943,
		// Token: 0x04001718 RID: 5912
		MapTravelSoarRewardRequest = 15351,
		// Token: 0x04001719 RID: 5913
		FishingInfoRequest = 18438,
		// Token: 0x0400171A RID: 5914
		FishingIllustratedRewardRequest = 26334,
		// Token: 0x0400171B RID: 5915
		FishingCabinPutRequest = 27290,
		// Token: 0x0400171C RID: 5916
		FishingQuickSellPreviewRequest = 29724,
		// Token: 0x0400171D RID: 5917
		FishingQuickSellRequest = 19986,
		// Token: 0x0400171E RID: 5918
		FishingSellPreviewRequest = 25932,
		// Token: 0x0400171F RID: 5919
		FishingSellRequest = 18289,
		// Token: 0x04001720 RID: 5920
		FishingSailingRequest = 21616,
		// Token: 0x04001721 RID: 5921
		FishingEntrustHandInRequest = 19706,
		// Token: 0x04001722 RID: 5922
		FishingEntrustTraceRequest = 21717,
		// Token: 0x04001723 RID: 5923
		FishingEntrustRefreshRequest = 22223,
		// Token: 0x04001724 RID: 5924
		FishingShipFixRequest = 15255,
		// Token: 0x04001725 RID: 5925
		FishingTechLevelUpRequest = 18947,
		// Token: 0x04001726 RID: 5926
		AccessPathConfigRequest = 28506,
		// Token: 0x04001727 RID: 5927
		PlayerGameTokenRequest = 18839,
		// Token: 0x04001728 RID: 5928
		RenjuExitMatchedActionRequest = 25656,
		// Token: 0x04001729 RID: 5929
		TrialRoleSkinRewardRequest = 27840,
		// Token: 0x0400172A RID: 5930
		LevelPlayStateListRequest = 17858,
		// Token: 0x0400172B RID: 5931
		SpringSignPhotoRewardRequest = 26463,
		// Token: 0x0400172C RID: 5932
		PhantomEquipGroupInfosRequest = 25068,
		// Token: 0x0400172D RID: 5933
		AddPhantomEquipGroupRequest = 18869,
		// Token: 0x0400172E RID: 5934
		DeletePhantomEquipGroupRequest = 28863,
		// Token: 0x0400172F RID: 5935
		TopPhantomEquipGroupRequest = 19922,
		// Token: 0x04001730 RID: 5936
		ChangePhantomEquipGroupNameRequest = 18907,
		// Token: 0x04001731 RID: 5937
		FishingCompleteRequest = 21375,
		// Token: 0x04001732 RID: 5938
		TeleportFlowEndRequest = 16124,
		// Token: 0x04001733 RID: 5939
		RiskHarvestStarRewardRequest = 22005,
		// Token: 0x04001734 RID: 5940
		PhantomFetterRecommendRequest = 29643,
		// Token: 0x04001735 RID: 5941
		PhantomAttrRecommendRequest = 18178,
		// Token: 0x04001736 RID: 5942
		FishingEntrustAcceptRequest = 28651,
		// Token: 0x04001737 RID: 5943
		FishingExitRequest = 16269,
		// Token: 0x04001738 RID: 5944
		FishingShipSkinChangeRequest = 17127,
		// Token: 0x04001739 RID: 5945
		FishingPointInfoRequest = 22194,
		// Token: 0x0400173A RID: 5946
		FishingCageInfoRequest = 26932,
		// Token: 0x0400173B RID: 5947
		FishingHandInRequest = 17299,
		// Token: 0x0400173C RID: 5948
		FishingSkillBombRequest = 23767,
		// Token: 0x0400173D RID: 5949
		FishingSkillBaitRequest = 28647,
		// Token: 0x0400173E RID: 5950
		FishingSkillTeleportRequest = 18398,
		// Token: 0x0400173F RID: 5951
		RogueWeeklyRewardRequest = 16216,
		// Token: 0x04001740 RID: 5952
		RogueWeeklyGotoNextRoomRequest = 24488,
		// Token: 0x04001741 RID: 5953
		SlashAndTowerInfoRequest = 21662,
		// Token: 0x04001742 RID: 5954
		SlashAndTowerScoreRewardRequest = 25485,
		// Token: 0x04001743 RID: 5955
		EndLessHistoryRequest = 20333,
		// Token: 0x04001744 RID: 5956
		SlashAndTowerSaveRecordRequest = 19751,
		// Token: 0x04001745 RID: 5957
		SlashAndTowerResetRequest = 27317,
		// Token: 0x04001746 RID: 5958
		SlashAndTowerRecommendRequest = 29840,
		// Token: 0x04001747 RID: 5959
		BossRushTaskRewardRequest = 25214,
		// Token: 0x04001748 RID: 5960
		UsePhantomEquipGroupRequest = 23641,
		// Token: 0x04001749 RID: 5961
		FishingActivityLimitRewardRequest = 26494,
		// Token: 0x0400174A RID: 5962
		FishingActivityMilestoneRewardRequest = 25523,
		// Token: 0x0400174B RID: 5963
		TeamParkourRewardRequest = 19943,
		// Token: 0x0400174C RID: 5964
		RogueWeeklyResultRequest = 28144,
		// Token: 0x0400174D RID: 5965
		RogueWeeklyOptionSelectRequest = 19544,
		// Token: 0x0400174E RID: 5966
		ThroughTrainFinishViewRequest = 16804,
		// Token: 0x0400174F RID: 5967
		ActivityPreOpenRequest = 18144,
		// Token: 0x04001750 RID: 5968
		LstBattleRecordRequest = 29144,
		// Token: 0x04001751 RID: 5969
		RogueWeeklyStartRequest = 28012,
		// Token: 0x04001752 RID: 5970
		FishingTeleportToBoatRequest = 23911,
		// Token: 0x04001753 RID: 5971
		TowerDefenceRandListRequest = 16075,
		// Token: 0x04001754 RID: 5972
		TowerDefenceRankShowNameRequest = 16285,
		// Token: 0x04001755 RID: 5973
		BabelTowerTaskRewardRequest = 24223,
		// Token: 0x04001756 RID: 5974
		BabelTowerDailyTaskRewardRequest = 25570,
		// Token: 0x04001757 RID: 5975
		ResetBabelTowerLevelRequest = 22844,
		// Token: 0x04001758 RID: 5976
		BabelTowerSettlementRequest = 26063,
		// Token: 0x04001759 RID: 5977
		RogueWeeklyBlackFlowerRequest = 21004,
		// Token: 0x0400175A RID: 5978
		SceneSubLevelsRequest = 16545,
		// Token: 0x0400175B RID: 5979
		PlayerTitleRequest = 25420,
		// Token: 0x0400175C RID: 5980
		ChangePlayerTitleRequest = 28211,
		// Token: 0x0400175D RID: 5981
		AwakeItemVehicleRequest = 27784,
		// Token: 0x0400175E RID: 5982
		SelectBabelActivityDeTermRequest = 17576,
		// Token: 0x0400175F RID: 5983
		GravityFlipInteractRequest = 24889,
		// Token: 0x04001760 RID: 5984
		AbyssChallengeUnlockRequest = 23937,
		// Token: 0x04001761 RID: 5985
		AbyssChallengeQuitRequest = 20789,
		// Token: 0x04001762 RID: 5986
		AbyssLikeRequest = 15542,
		// Token: 0x04001763 RID: 5987
		AbyssChallengeGotoNextRoomRequest = 25389,
		// Token: 0x04001764 RID: 5988
		AbyssRewardRequest = 27914,
		// Token: 0x04001765 RID: 5989
		AbyssLittleRoleLevelUpRequest = 21041,
		// Token: 0x04001766 RID: 5990
		AbyssPluginPutRequest = 27978,
		// Token: 0x04001767 RID: 5991
		AbyssPluginSynthesisRequest = 15330,
		// Token: 0x04001768 RID: 5992
		AbyssRankListRequest = 21276,
		// Token: 0x04001769 RID: 5993
		AbyssShowNameRequest = 25707,
		// Token: 0x0400176A RID: 5994
		AbyssReviveCharacterRequest = 19506,
		// Token: 0x0400176B RID: 5995
		SceneItemMoveSplineRequest = 28835,
		// Token: 0x0400176C RID: 5996
		RacingBetsLegMatchInfoRequest = 26734,
		// Token: 0x0400176D RID: 5997
		RacingBetsMatchInfoRequest = 27743,
		// Token: 0x0400176E RID: 5998
		RacingBetsPlayerInfoRequest = 22312,
		// Token: 0x0400176F RID: 5999
		RacingBetsRankRequest = 28072,
		// Token: 0x04001770 RID: 6000
		RacingBetsGearRequest = 16270,
		// Token: 0x04001771 RID: 6001
		RacingBetsTaskRequest = 26366,
		// Token: 0x04001772 RID: 6002
		RacingBetsTaskRewardRequest = 17938,
		// Token: 0x04001773 RID: 6003
		RacingBetMatchRoundRequest = 17145,
		// Token: 0x04001774 RID: 6004
		RacingBetsBulletScreenRequest = 21780,
		// Token: 0x04001775 RID: 6005
		RogueWeeklyLastInfoRequest = 27120,
		// Token: 0x04001776 RID: 6006
		RacingBetsUpdateOddsRequest = 17175,
		// Token: 0x04001777 RID: 6007
		ExploreActivityTaskRewardRequest = 27918,
		// Token: 0x04001778 RID: 6008
		PhantomPolishRequest = 25622,
		// Token: 0x04001779 RID: 6009
		TowerDefenceSelfPassRequest = 15513,
		// Token: 0x0400177A RID: 6010
		AbyssSelfPassRequest = 25588,
		// Token: 0x0400177B RID: 6011
		RogueResTalentSkillLevelRequest = 21757,
		// Token: 0x0400177C RID: 6012
		RogueResEndingRewardRequest = 28009,
		// Token: 0x0400177D RID: 6013
		RogueResTaskAwardRequest = 24834,
		// Token: 0x0400177E RID: 6014
		RogueResIllustrationAwardRequest = 19081,
		// Token: 0x0400177F RID: 6015
		AvignonRewardRequest = 16650,
		// Token: 0x04001780 RID: 6016
		RogueResMoveRequest = 26615,
		// Token: 0x04001781 RID: 6017
		RogueResGridEventRequest = 16464,
		// Token: 0x04001782 RID: 6018
		RogueResOpDoneRequest = 27894,
		// Token: 0x04001783 RID: 6019
		RogueResInstStartRequest = 21018,
		// Token: 0x04001784 RID: 6020
		RogueResInstResultRequest = 22518,
		// Token: 0x04001785 RID: 6021
		RogueResLastInstInfoRequest = 29790,
		// Token: 0x04001786 RID: 6022
		RacingBetsGearRefundRequest = 22909,
		// Token: 0x04001787 RID: 6023
		SummonRandomRequest = 19590,
		// Token: 0x04001788 RID: 6024
		StopMoveSplineRequest = 28704,
		// Token: 0x04001789 RID: 6025
		FlySkinWearRequest = 22343,
		// Token: 0x0400178A RID: 6026
		FlySkinWearAllRoleRequest = 17655,
		// Token: 0x0400178B RID: 6027
		RogueResGotoNextRoomRequest = 22010,
		// Token: 0x0400178C RID: 6028
		FlySkinUnLoadRequest = 22401,
		// Token: 0x0400178D RID: 6029
		DangoMonopolyDiceRequest = 19414,
		// Token: 0x0400178E RID: 6030
		DangoMonopolyGridRewardRequest = 22355,
		// Token: 0x0400178F RID: 6031
		DangoMonopolyBoardRewardRequest = 29315,
		// Token: 0x04001790 RID: 6032
		DangoMonopolyTaskRewardRequest = 28152,
		// Token: 0x04001791 RID: 6033
		RacingBetMatchRequest = 27478,
		// Token: 0x04001792 RID: 6034
		LoadingLevelAreaRequest = 15203,
		// Token: 0x04001793 RID: 6035
		DangoMonopolyNextBoardRequest = 19220,
		// Token: 0x04001794 RID: 6036
		AddChapterResultRequest = 28807,
		// Token: 0x04001795 RID: 6037
		ChapterResultRewardRequest = 24597,
		// Token: 0x04001796 RID: 6038
		InspirationUnlockChoiceRequest = 19608,
		// Token: 0x04001797 RID: 6039
		ActivityResultRewardRequest = 19569,
		// Token: 0x04001798 RID: 6040
		ScheduleRewardRequest = 15291,
		// Token: 0x04001799 RID: 6041
		FlySkinAllUnLoadRequest = 17171,
		// Token: 0x0400179A RID: 6042
		RogueResChangeFormationRequest = 24365,
		// Token: 0x0400179B RID: 6043
		RegressBonusRequest = 27943,
		// Token: 0x0400179C RID: 6044
		RegressTaskRequest = 17178,
		// Token: 0x0400179D RID: 6045
		ConfirmQuestResourceRequest = 23000,
		// Token: 0x0400179E RID: 6046
		ConsumptiveRewardRequest = 26335,
		// Token: 0x0400179F RID: 6047
		LinkageRewardRequest = 25785,
		// Token: 0x040017A0 RID: 6048
		RacingBetMatchActionRequest = 19065,
		// Token: 0x040017A1 RID: 6049
		RacingBetMatchRoundActionRequest = 16403,
		// Token: 0x040017A2 RID: 6050
		RogueResSwitchFormationRequest = 27031,
		// Token: 0x040017A3 RID: 6051
		RacingBetMatchInfoRequest = 23216,
		// Token: 0x040017A4 RID: 6052
		PhantomBattleTaskRewardRequest = 22908,
		// Token: 0x040017A5 RID: 6053
		PhantomBattleMasterLevelRewardRequest = 25661,
		// Token: 0x040017A6 RID: 6054
		PhantomBattleBadgeRewardRequest = 22984,
		// Token: 0x040017A7 RID: 6055
		PhantomBattleCardOutLookUpRequest = 21176,
		// Token: 0x040017A8 RID: 6056
		PhantomBattleCardRewardRequest = 24305,
		// Token: 0x040017A9 RID: 6057
		PhantomBattleRoleRewardRequest = 29748,
		// Token: 0x040017AA RID: 6058
		PhantomBattleCardGroupAddRequest = 16307,
		// Token: 0x040017AB RID: 6059
		PhantomBattleCardGroupUpdateRequest = 21338,
		// Token: 0x040017AC RID: 6060
		PhantomBattleCardGroupNameRequest = 18469,
		// Token: 0x040017AD RID: 6061
		PhantomBattleDealCardReplaceRequest = 19834,
		// Token: 0x040017AE RID: 6062
		PhantomBattleEnterSlotRequest = 21374,
		// Token: 0x040017AF RID: 6063
		PhantomBattleEvolveRequest = 20873,
		// Token: 0x040017B0 RID: 6064
		PhantomBattleBackLibraryRequest = 22264,
		// Token: 0x040017B1 RID: 6065
		PhantomBattleRoundOverRequest = 22166,
		// Token: 0x040017B2 RID: 6066
		PhantomBattleSlotInsteadRequest = 28150,
		// Token: 0x040017B3 RID: 6067
		BirthDayCardRoleRequest = 24371,
		// Token: 0x040017B4 RID: 6068
		BirthDayRewardRequest = 17381,
		// Token: 0x040017B5 RID: 6069
		DirectTrainInfoRequest = 29272,
		// Token: 0x040017B6 RID: 6070
		RegressQuestionOpenRequest = 21964,
		// Token: 0x040017B7 RID: 6071
		PhantomBattleLeaveSlotRequest = 19738,
		// Token: 0x040017B8 RID: 6072
		PhantomBattleSelectTargetRequest = 20698,
		// Token: 0x040017B9 RID: 6073
		ConsumptiveActivityInfoRequest = 24785,
		// Token: 0x040017BA RID: 6074
		PhantomBattleCardRoleSkillRequest = 16984,
		// Token: 0x040017BB RID: 6075
		PhantomBattleCardSkillRequest = 19909,
		// Token: 0x040017BC RID: 6076
		SetQuestFocusModeRequest = 16174,
		// Token: 0x040017BD RID: 6077
		CancelQuestFocusModeRequest = 15853,
		// Token: 0x040017BE RID: 6078
		PhantomBattleNpcShowOverRequest = 29519,
		// Token: 0x040017BF RID: 6079
		PhantomBattleBvBLoadingFinishRequest = 20661,
		// Token: 0x040017C0 RID: 6080
		PhantomBattleStartRequest = 18864,
		// Token: 0x040017C1 RID: 6081
		AcceptFocusWaitQuestRequest = 25258,
		// Token: 0x040017C2 RID: 6082
		PhantomBattleDiscardCardRequest = 16286,
		// Token: 0x040017C3 RID: 6083
		NavigationFindPathRequest = 27225,
		// Token: 0x040017C4 RID: 6084
		PhantomBattleCardGroupDeleteRequest = 16154,
		// Token: 0x040017C5 RID: 6085
		QuestReviewInfoRequest = 23616,
		// Token: 0x040017C6 RID: 6086
		NewbieCarnivalSwitchRoleRequest = 26924,
		// Token: 0x040017C7 RID: 6087
		NewbieCarnivalAwardRequest = 27569,
		// Token: 0x040017C8 RID: 6088
		PhantomBattleCardSelectRequest = 16151,
		// Token: 0x040017C9 RID: 6089
		PhantomBattleCardTargetInfoRequest = 22368,
		// Token: 0x040017CA RID: 6090
		PhantomBattleCardRoleTargetInfoRequest = 29346,
		// Token: 0x040017CB RID: 6091
		PhantomBattleCardUnlockRequest = 19404,
		// Token: 0x040017CC RID: 6092
		OccupyRewardRequest = 18660,
		// Token: 0x040017CD RID: 6093
		SetQuestResourceStateRequest = 23014,
		// Token: 0x040017CE RID: 6094
		LongShanScoreRewardRequest = 15312,
		// Token: 0x040017CF RID: 6095
		BathChangeCameraRequest = 23750,
		// Token: 0x040017D0 RID: 6096
		BathPhotoRequest = 23123,
		// Token: 0x040017D1 RID: 6097
		FinishDownloadQuestResourceRequest = 21668,
		// Token: 0x040017D2 RID: 6098
		PhantomBattleBackSlotCardLibraryRequest = 18589,
		// Token: 0x040017D3 RID: 6099
		FloroRanchUnlockTechPointRequest = 23148,
		// Token: 0x040017D4 RID: 6100
		FloroRanchRewardTaskRequest = 27434,
		// Token: 0x040017D5 RID: 6101
		FloroRanchRewardMilestoneRequest = 25505,
		// Token: 0x040017D6 RID: 6102
		FloroRanchStartPlayRequest = 25857,
		// Token: 0x040017D7 RID: 6103
		FloroRanchSettleRequest = 22514,
		// Token: 0x040017D8 RID: 6104
		FloroRanchPlayNextDayRequest = 20630,
		// Token: 0x040017D9 RID: 6105
		FloroRanchPlayGachaRequest = 18280,
		// Token: 0x040017DA RID: 6106
		FloroRanchPlayShopBuyRequest = 23342,
		// Token: 0x040017DB RID: 6107
		FloroRanchPlayEventChoiceRequest = 22212,
		// Token: 0x040017DC RID: 6108
		FloroRanchPlayTributeRequest = 21163,
		// Token: 0x040017DD RID: 6109
		FloroRanchPlayUnlimitedModeRequest = 25585,
		// Token: 0x040017DE RID: 6110
		KcpConvRequest = 3728,
		// Token: 0x040017DF RID: 6111
		ActionOperationScreenSuccessRequest = 15213,
		// Token: 0x040017E0 RID: 6112
		PhantomBattleSelectReserveCardRequest = 22146,
		// Token: 0x040017E1 RID: 6113
		FloroRanchPlayRemoveUnitRequest = 24002,
		// Token: 0x040017E2 RID: 6114
		PhantomBattleSlotCardSkillRequest = 26717,
		// Token: 0x040017E3 RID: 6115
		ConstructTrapRequest = 17132,
		// Token: 0x040017E4 RID: 6116
		DeconstructTrapRequest = 20360,
		// Token: 0x040017E5 RID: 6117
		PhantomBattleReChallengeRequest = 27585,
		// Token: 0x040017E6 RID: 6118
		FloroRanchPlayRefreshShopRequest = 28500,
		// Token: 0x040017E7 RID: 6119
		FloroRanchPlayRefreshGachaRequest = 23703,
		// Token: 0x040017E8 RID: 6120
		PhantomBattleDebugInfoRequest = 23362,
		// Token: 0x040017E9 RID: 6121
		MoralePosRequest = 17542,
		// Token: 0x040017EA RID: 6122
		RunTestRequest = 29128,
		// Token: 0x040017EB RID: 6123
		PhantomSettingRequest = 24025,
		// Token: 0x040017EC RID: 6124
		PhantomSettingUpdateRequest = 27251,
		// Token: 0x040017ED RID: 6125
		PhantomBatchOperRequest = 15779,
		// Token: 0x040017EE RID: 6126
		VehiclePlatformGetOnRequest = 21411,
		// Token: 0x040017EF RID: 6127
		PolluteGridCellRequest = 21401,
		// Token: 0x040017F0 RID: 6128
		LifePointChallengeStartRequest = 17900,
		// Token: 0x040017F1 RID: 6129
		FloroRanchPlaySelectCardGroupRequest = 20063,
		// Token: 0x040017F2 RID: 6130
		SimpleCombatEntityDieRequest = 24565,
		// Token: 0x040017F3 RID: 6131
		MoraleTreasureBoxTraceRequest = 26624,
		// Token: 0x040017F4 RID: 6132
		MulAchievementReceiveRequest = 28143,
		// Token: 0x040017F5 RID: 6133
		MulRoguelikeWriteCatRewardRequest = 24493,
		// Token: 0x040017F6 RID: 6134
		MulRogueWeeklyRewardRequest = 16599,
		// Token: 0x040017F7 RID: 6135
		MulPhantomBattleMasterLevelRewardRequest = 18455,
		// Token: 0x040017F8 RID: 6136
		MulGetAdventureRewardRequest = 21424,
		// Token: 0x040017F9 RID: 6137
		MulCalabashLevelRewardRequest = 17463,
		// Token: 0x040017FA RID: 6138
		MulExploreScoreRewardRequest = 20889,
		// Token: 0x040017FB RID: 6139
		MulFishingIllustratedRewardRequest = 25002,
		// Token: 0x040017FC RID: 6140
		MulMapTravelTaskRewardRequest = 22390,
		// Token: 0x040017FD RID: 6141
		FloroRanchPlayGachaRefreshRequest = 17012,
		// Token: 0x040017FE RID: 6142
		FloroRanchExecuteSkillPlayRequest = 29254,
		// Token: 0x040017FF RID: 6143
		HoldHandRequest = 15637,
		// Token: 0x04001800 RID: 6144
		TrapDefensePreviewFinishRequest = 16711,
		// Token: 0x04001801 RID: 6145
		FloroRanchSettleDataRequest = 23504,
		// Token: 0x04001802 RID: 6146
		SetFocusModeDeterCondRequest = 23749,
		// Token: 0x04001803 RID: 6147
		LowMemoryChangeSceneFinishRequest = 20606,
		// Token: 0x04001804 RID: 6148
		RogueWeeklyArtifactInfoRequest = 27043,
		// Token: 0x04001805 RID: 6149
		RogueWeeklyArtifactSelectRequest = 22776,
		// Token: 0x04001806 RID: 6150
		TrapDefenseRefreshGainingGroupRequest = 25671,
		// Token: 0x04001807 RID: 6151
		TrapDefenseSelectGainingGroupRequest = 18252,
		// Token: 0x04001808 RID: 6152
		TrapDefenseTechUnlockRequest = 21102,
		// Token: 0x04001809 RID: 6153
		TrapDefenseGetRewardRequest = 24481,
		// Token: 0x0400180A RID: 6154
		TrapDefenseGetSpecialRewardRequest = 18758,
		// Token: 0x0400180B RID: 6155
		TrapDefenseBuildingLevelUpRequest = 18133,
		// Token: 0x0400180C RID: 6156
		TrapDefenseBuildingBranchRequest = 17310,
		// Token: 0x0400180D RID: 6157
		TrapDefenseAuxiliaryLevelUpRequest = 20936,
		// Token: 0x0400180E RID: 6158
		TrapDefenseAuxiliaryBranchRequest = 16263,
		// Token: 0x0400180F RID: 6159
		FunPlayChallengeAwardRequest = 25841,
		// Token: 0x04001810 RID: 6160
		LevelPlayOpenRequest = 23577,
		// Token: 0x04001811 RID: 6161
		TrapDefenseChallengeQuitRequest = 24031,
		// Token: 0x04001812 RID: 6162
		TrapDefenseBuildingResetRequest = 18594,
		// Token: 0x04001813 RID: 6163
		TrapDefenseAuxiliaryResetRequest = 26508,
		// Token: 0x04001814 RID: 6164
		TrapDefenseDevelopResetRequest = 21084,
		// Token: 0x04001815 RID: 6165
		ExploreEntityTraceRequest = 20228,
		// Token: 0x04001816 RID: 6166
		CommonTouchUiSettingUpdateRequest = 21364,
		// Token: 0x04001817 RID: 6167
		TrapDefenseSlotUpdateRequest = 28106,
		// Token: 0x04001818 RID: 6168
		SceneItemSequenceFrameEndRequest = 24870,
		// Token: 0x04001819 RID: 6169
		MulMapTravelSoarRewardRequest = 19711,
		// Token: 0x0400181A RID: 6170
		PhantomSettingBatchUpdateRequest = 21039,
		// Token: 0x0400181B RID: 6171
		FloroRanchFirstEnterRequest = 27487,
		// Token: 0x0400181C RID: 6172
		FloroRanchAnimationRequest = 25219,
		// Token: 0x0400181D RID: 6173
		BlackSwordChallengeInfoRequest = 22114,
		// Token: 0x0400181E RID: 6174
		RoleOperateSelfBgmRequest = 19564,
		// Token: 0x0400181F RID: 6175
		TrapDefenseRefreshShopRequest = 17409,
		// Token: 0x04001820 RID: 6176
		TrapDefenseBuyShopProductRequest = 17521,
		// Token: 0x04001821 RID: 6177
		SceneItemSequenceFrameStartRequest = 20858,
		// Token: 0x04001822 RID: 6178
		MoonPhaseRandomRequest = 15067,
		// Token: 0x04001823 RID: 6179
		MoonPhaseRewardRequest = 21365,
		// Token: 0x04001824 RID: 6180
		TrapDefenseUseItemRequest = 16123,
		// Token: 0x04001825 RID: 6181
		LineCrossChallengeStartRequest = 26440,
		// Token: 0x04001826 RID: 6182
		RoleIllustratedInfoRequest = 23991,
		// Token: 0x04001827 RID: 6183
		TrapDefenseCurChallengeInfoRequest = 19548,
		// Token: 0x04001828 RID: 6184
		RoleDevelopConfigRequest = 29877,
		// Token: 0x04001829 RID: 6185
		PhotoFightTaskRewardRequest = 24443,
		// Token: 0x0400182A RID: 6186
		PhotoFightSettleRequest = 15995,
		// Token: 0x0400182B RID: 6187
		TrapDefenseQuickEquipRequest = 18555,
		// Token: 0x0400182C RID: 6188
		FloroRanchCloseTaskRequest = 20552,
		// Token: 0x0400182D RID: 6189
		CalabashSkinTakeOnRequest = 27489,
		// Token: 0x0400182E RID: 6190
		WuWuKujiGachaRequest = 24138,
		// Token: 0x0400182F RID: 6191
		SurvivorsOpDoneRequest = 27513,
		// Token: 0x04001830 RID: 6192
		SurvivorsLockRequest = 19978,
		// Token: 0x04001831 RID: 6193
		QuestTreeInfoRequest = 15519,
		// Token: 0x04001832 RID: 6194
		LoadCalabashSkinInfoRequest = 20817,
		// Token: 0x04001833 RID: 6195
		SetPlayerYuXueModeRequest = 18715,
		// Token: 0x04001834 RID: 6196
		SetBtObjYuXueModeRequest = 23639,
		// Token: 0x04001835 RID: 6197
		GetYuXueModeInfoRequest = 26654,
		// Token: 0x04001836 RID: 6198
		SurvivorsResultRequest = 17323,
		// Token: 0x04001837 RID: 6199
		SurvivorsStepAdvanceRequest = 28159,
		// Token: 0x04001838 RID: 6200
		WeatherControlRequest = 25604,
		// Token: 0x04001839 RID: 6201
		SurvivorsWeaponInfoRequest = 19901,
		// Token: 0x0400183A RID: 6202
		SurvivorsNormalAwardRequest = 25147,
		// Token: 0x0400183B RID: 6203
		SurvivorsScoreAwardRequest = 19499,
		// Token: 0x0400183C RID: 6204
		SurvivorsTalentLevelUpRequest = 24431,
		// Token: 0x0400183D RID: 6205
		BatchSynthesisItemRequest = 19088,
		// Token: 0x0400183E RID: 6206
		SurvivorsLastInfoRequest = 23667,
		// Token: 0x0400183F RID: 6207
		RoleUpdateDevelopTargetRequest = 29614,
		// Token: 0x04001840 RID: 6208
		InfrInfoRequest = 21330,
		// Token: 0x04001841 RID: 6209
		InfrArchiveTaskRewardRequest = 18945,
		// Token: 0x04001842 RID: 6210
		InfrManualSwitchTraceRoadRequest = 20148,
		// Token: 0x04001843 RID: 6211
		InfrFireNoticeRequest = 29298,
		// Token: 0x04001844 RID: 6212
		MainPhantomRecommendRequest = 15154,
		// Token: 0x04001845 RID: 6213
		InfrLevelUpRequest = 18803,
		// Token: 0x04001846 RID: 6214
		InfrRoadBuildRequest = 20207,
		// Token: 0x04001847 RID: 6215
		BlackSwordChallengeMarkItemPanelInfoRequest = 29544,
		// Token: 0x04001848 RID: 6216
		HonamiStoryBagOperateRequest = 19759,
		// Token: 0x04001849 RID: 6217
		HonamiStoryEquipRoleRequest = 21590,
		// Token: 0x0400184A RID: 6218
		HonamiStoryUnlockSlotRequest = 26265,
		// Token: 0x0400184B RID: 6219
		HonamiStoryWeaponDressRequest = 17346,
		// Token: 0x0400184C RID: 6220
		HonamiStorySellItemRequest = 16688,
		// Token: 0x0400184D RID: 6221
		HonamiStoryLifeSupportUpRequest = 24974,
		// Token: 0x0400184E RID: 6222
		HonamiStoryActivateTalentRequest = 29239,
		// Token: 0x0400184F RID: 6223
		HonamiStoryItemCollectionRequest = 27262,
		// Token: 0x04001850 RID: 6224
		HonamiStoryMascotRewardRequest = 27581,
		// Token: 0x04001851 RID: 6225
		HonamiStoryAreaSecretRewardRequest = 25409,
		// Token: 0x04001852 RID: 6226
		HonamiStoryLimitTaskRewardRequest = 26293,
		// Token: 0x04001853 RID: 6227
		HonamiStoryScoreRewardRequest = 16084,
		// Token: 0x04001854 RID: 6228
		HonamiStoryPickUpItemRequest = 17260,
		// Token: 0x04001855 RID: 6229
		HonamiStoryDiscardItemRequest = 19973,
		// Token: 0x04001856 RID: 6230
		HonamiStoryInstLeaveRequest = 19853,
		// Token: 0x04001857 RID: 6231
		GetTraceQuestYuXueModeRequest = 27604,
		// Token: 0x04001858 RID: 6232
		RollBlockResetGamePlayRequest = 22610,
		// Token: 0x04001859 RID: 6233
		RollBlockMovementFinishRequest = 25774,
		// Token: 0x0400185A RID: 6234
		HonamiStoryLockItemRequest = 23316,
		// Token: 0x0400185B RID: 6235
		MulCorniceMeetingRewardRequest = 20556,
		// Token: 0x0400185C RID: 6236
		RollBlockInputRequest = 19364,
		// Token: 0x0400185D RID: 6237
		MotorTechLevelUpRequest = 27727,
		// Token: 0x0400185E RID: 6238
		WeatherControlInfoRequest = 25430,
		// Token: 0x0400185F RID: 6239
		ButtonIsEnableRequest = 18232,
		// Token: 0x04001860 RID: 6240
		MotorLevelOneKeyRewardRequest = 15900,
		// Token: 0x04001861 RID: 6241
		MotorInfoRequest = 17813,
		// Token: 0x04001862 RID: 6242
		MotorTaskOneKeyRewardRequest = 27567,
		// Token: 0x04001863 RID: 6243
		PhantomInteractionEquipRequest = 21354,
		// Token: 0x04001864 RID: 6244
		PhantomInteractionSkinChangeRequest = 21448,
		// Token: 0x04001865 RID: 6245
		MotorTechTreeSwitchRequest = 25166,
		// Token: 0x04001866 RID: 6246
		AreaTerminalPinOperationRequest = 21848,
		// Token: 0x04001867 RID: 6247
		GetDetectionTargetRequest = 20959,
		// Token: 0x04001868 RID: 6248
		InfrThemeActivityAwardRequest = 20474,
		// Token: 0x04001869 RID: 6249
		MotorSliderRequest = 22317,
		// Token: 0x0400186A RID: 6250
		BossRushBatchClaimRewardRequest = 27431,
		// Token: 0x0400186B RID: 6251
		PhantomBattleAreaSkillRequest = 25124,
		// Token: 0x0400186C RID: 6252
		PhantomBattlePhantomCardSkillRequest = 28104,
		// Token: 0x0400186D RID: 6253
		ArtemisNodeUpdateRequest = 26355,
		// Token: 0x0400186E RID: 6254
		AddDecalRequest = 29268,
		// Token: 0x0400186F RID: 6255
		CoopRoleRewardRequest = 25686,
		// Token: 0x04001870 RID: 6256
		CoopSpRewardRequest = 22261,
		// Token: 0x04001871 RID: 6257
		HonamiStoryResidentTaskRewardRequest = 27298,
		// Token: 0x04001872 RID: 6258
		RollBlockExitGamePlayRequest = 28361,
		// Token: 0x04001873 RID: 6259
		RollBlockToggleHintRequest = 15560,
		// Token: 0x04001874 RID: 6260
		MotorChangeOutlookRequest = 27172,
		// Token: 0x04001875 RID: 6261
		VehicleEnterSharingRequest = 25279,
		// Token: 0x04001876 RID: 6262
		RollBlockSwitchControlBlockRequest = 17791,
		// Token: 0x04001877 RID: 6263
		MotorLinkTaskRequest = 23517,
		// Token: 0x04001878 RID: 6264
		InstEntityTeleportRequest = 20901,
		// Token: 0x04001879 RID: 6265
		DeadeyeShootHitRequest = 15008,
		// Token: 0x0400187A RID: 6266
		MotorUseSkinRequest = 19760,
		// Token: 0x0400187B RID: 6267
		PhantomBattleCallCardRequest = 25399,
		// Token: 0x0400187C RID: 6268
		ShortMessageInfoRequest = 19425,
		// Token: 0x0400187D RID: 6269
		ShortMessageReadRequest = 25131,
		// Token: 0x0400187E RID: 6270
		ShortMessageReplyRequest = 22894,
		// Token: 0x0400187F RID: 6271
		ShortMessageReceivedRequest = 29328,
		// Token: 0x04001880 RID: 6272
		InfrPhoneTaskRewardRequest = 16037,
		// Token: 0x04001881 RID: 6273
		ShortMessageUpdateRequest = 22887,
		// Token: 0x04001882 RID: 6274
		BeamCastHitPlayerRequest = 24426,
		// Token: 0x04001883 RID: 6275
		CaptureBatchEntityRequest = 28951,
		// Token: 0x04001884 RID: 6276
		RoadBookFullRewardRequest = 25619,
		// Token: 0x04001885 RID: 6277
		RoadBookLevelUpRequest = 21349,
		// Token: 0x04001886 RID: 6278
		RoadBookTaskRewardRequest = 28058,
		// Token: 0x04001887 RID: 6279
		RoadBookMotorRewardRequest = 19974,
		// Token: 0x04001888 RID: 6280
		MotorParkourLevelRewardRequest = 18192,
		// Token: 0x04001889 RID: 6281
		PhantomBatchPolishRequest = 17121,
		// Token: 0x0400188A RID: 6282
		PhantomBattleCheckCardSkillUnlockRequest = 28636,
		// Token: 0x0400188B RID: 6283
		PhantomVicePolishRequest = 21223,
		// Token: 0x0400188C RID: 6284
		PhantomVicePolishAckRequest = 26021,
		// Token: 0x0400188D RID: 6285
		FurnitureDiySaveRequest = 21389,
		// Token: 0x0400188E RID: 6286
		InfrManualCancelTraceRoadRequest = 17676,
		// Token: 0x0400188F RID: 6287
		SkinRewardRequest = 21395,
		// Token: 0x04001890 RID: 6288
		InfrArchiveReadRequest = 26051,
		// Token: 0x04001891 RID: 6289
		AtomicProcessTeleportRequest = 24800,
		// Token: 0x04001892 RID: 6290
		NewTowerUpdateRecordRequest = 16212,
		// Token: 0x04001893 RID: 6291
		NewTowerRewardRequest = 19524,
		// Token: 0x04001894 RID: 6292
		MotorFightTalentUpRequest = 28481,
		// Token: 0x04001895 RID: 6293
		MotorFightOneKeyRewardRequest = 27302,
		// Token: 0x04001896 RID: 6294
		MotorFightRankListRequest = 22743,
		// Token: 0x04001897 RID: 6295
		PhantomBattleGuideRewardRequest = 26718,
		// Token: 0x04001898 RID: 6296
		JokerGuessStartNewRequest = 16872,
		// Token: 0x04001899 RID: 6297
		JokerGuessPlayCardRequest = 18401,
		// Token: 0x0400189A RID: 6298
		JokerGuessDrawCardRequest = 29650,
		// Token: 0x0400189B RID: 6299
		JokerGuessUseSkillRequest = 18807,
		// Token: 0x0400189C RID: 6300
		EncircleChallengeStartRequest = 28751,
		// Token: 0x0400189D RID: 6301
		EncircleChallengeCompleteRequest = 23593,
		// Token: 0x0400189E RID: 6302
		NewTowerCycleStartRequest = 16812,
		// Token: 0x0400189F RID: 6303
		PhantomMusicCollectUpdateRequest = 18730,
		// Token: 0x040018A0 RID: 6304
		H5CircumFluenceActivityReadRequest = 20511,
		// Token: 0x040018A1 RID: 6305
		HookLockBatchCollectRequest = 26268,
		// Token: 0x040018A2 RID: 6306
		MotorFightSettleRequest = 15544,
		// Token: 0x040018A3 RID: 6307
		MotorFightLastSaveDataRequest = 16858,
		// Token: 0x040018A4 RID: 6308
		PhantomBattleRepeatedTaskRewardRequest = 22983,
		// Token: 0x040018A5 RID: 6309
		NewTowerRoleEnergyRequest = 24038,
		// Token: 0x040018A6 RID: 6310
		HonamiStoryActivityInfoRequest = 20790,
		// Token: 0x040018A7 RID: 6311
		PhantomBatchDirectRefiningRequest = 29456,
		// Token: 0x040018A8 RID: 6312
		PilotThrowOperationRequest = 20827,
		// Token: 0x040018A9 RID: 6313
		ShortMessageShowChangeRequest = 27855,
		// Token: 0x040018AA RID: 6314
		NewPlayerSupportRewardTaskRequest = 15421,
		// Token: 0x040018AB RID: 6315
		NewPlayerSupportTrialRoleLvUpRequest = 24142,
		// Token: 0x040018AC RID: 6316
		PhantomBattleReconstructCardRequest = 26025,
		// Token: 0x040018AD RID: 6317
		RegressDisposableRewardRequest = 29911,
		// Token: 0x040018AE RID: 6318
		ExploreSkillActionRequest = 17369,
		// Token: 0x040018AF RID: 6319
		InstTeleportToResetPointRequest = 19204,
		// Token: 0x040018B0 RID: 6320
		NewTowerClearRecordRequest = 23758,
		// Token: 0x040018B1 RID: 6321
		GetLevelPlayRewardsRequest = 16467,
		// Token: 0x040018B2 RID: 6322
		MotorOutlookInfoRequest = 16618,
		// Token: 0x040018B3 RID: 6323
		Summon3Request = 29752,
		// Token: 0x040018B4 RID: 6324
		RegressTrialRoleLvUpRequest = 16654,
		// Token: 0x040018B5 RID: 6325
		GravityHookLockPointChangeGravityRequest = 27548,
		// Token: 0x040018B6 RID: 6326
		TotalTopUpScoreInfoRequest = 18368,
		// Token: 0x040018B7 RID: 6327
		TotalTopUpRewardRequest = 27942,
		// Token: 0x040018B8 RID: 6328
		NewPlayerSupportSetCurUseTrialRoleRequest = 22855,
		// Token: 0x040018B9 RID: 6329
		MotorFightEnterSubLevelRequest = 28999,
		// Token: 0x040018BA RID: 6330
		MotorFightKillRequest = 24452,
		// Token: 0x040018BB RID: 6331
		AtomicProcessAddBuffRequest = 27678,
		// Token: 0x040018BC RID: 6332
		BrochureRewardRequest = 20771,
		// Token: 0x040018BD RID: 6333
		WeekCardInfoRequest = 26823,
		// Token: 0x040018BE RID: 6334
		WeekCardRewardRequest = 18381,
		// Token: 0x040018BF RID: 6335
		SeamlessTeleportVehicleRequest = 16695,
		// Token: 0x040018C0 RID: 6336
		RegressRepeatedTaskRequest = 26659,
		// Token: 0x040018C1 RID: 6337
		MotorCreateRequest = 29157,
		// Token: 0x040018C2 RID: 6338
		RegressBuyBonusLvRequest = 25368,
		// Token: 0x040018C3 RID: 6339
		RegressSetCurUseTrialRoleRequest = 27245,
		// Token: 0x040018C4 RID: 6340
		H5ViewActivityReadRequest = 22263,
		// Token: 0x040018C5 RID: 6341
		RoleSkillBranchModifyRequest = 26316,
		// Token: 0x040018C6 RID: 6342
		MixDrinkSettleRequest = 28130,
		// Token: 0x040018C7 RID: 6343
		MixDrinkTopicSelectRequest = 27388,
		// Token: 0x040018C8 RID: 6344
		MotorFightPlayerDeadRequest = 22425,
		// Token: 0x040018C9 RID: 6345
		WeatherSwitchInfoRequest = 27924,
		// Token: 0x040018CA RID: 6346
		MotorFightRefreshNextWaveGroupRequest = 16568,
		// Token: 0x040018CB RID: 6347
		RollBlockGamePlayReadyRequest = 26018,
		// Token: 0x040018CC RID: 6348
		MotorFightSelectCollectionRequest = 19245,
		// Token: 0x040018CD RID: 6349
		EntityEnterVehicleRequest = 27542,
		// Token: 0x040018CE RID: 6350
		FarmGoldLevelPlayRepeatedRequest = 21472,
		// Token: 0x040018CF RID: 6351
		MotorFightSelectBuffGateRequest = 16560,
		// Token: 0x040018D0 RID: 6352
		GivebackInfoRequest = 15189,
		// Token: 0x040018D1 RID: 6353
		GivebackRewardRequest = 23197,
		// Token: 0x040018D2 RID: 6354
		FarmGoldPointRepeatedRequest = 29763,
		// Token: 0x040018D3 RID: 6355
		ActionResetPosPrePerformanceEndRequest = 19745,
		// Token: 0x040018D4 RID: 6356
		MotorFightRefreshCollectionRequest = 22653,
		// Token: 0x040018D5 RID: 6357
		ExhibitionItemSaveRequest = 24520,
		// Token: 0x040018D6 RID: 6358
		SpringFestivalTaskRewardRequest = 27247,
		// Token: 0x040018D7 RID: 6359
		SpringFestivalScoreRewardRequest = 17619,
		// Token: 0x040018D8 RID: 6360
		SpringFestivalAtmosphereRewardRequest = 24192,
		// Token: 0x040018D9 RID: 6361
		EnterBigWorldInstRequest = 17063,
		// Token: 0x040018DA RID: 6362
		PhantomMusicSaveRequest = 17072,
		// Token: 0x040018DB RID: 6363
		FlagChallengeRewardRequest = 19079,
		// Token: 0x040018DC RID: 6364
		MotorDevelopTaskRewardRequest = 16150,
		// Token: 0x040018DD RID: 6365
		VehicleFinishRequest = 19634,
		// Token: 0x040018DE RID: 6366
		AtomicProcessRemoveBuffRequest = 19269,
		// Token: 0x040018DF RID: 6367
		ActivityPayShopBuyRequest = 23899,
		// Token: 0x040018E0 RID: 6368
		TetrisUpdateRequest = 25007,
		// Token: 0x040018E1 RID: 6369
		NewTrialRoleGetNightmarePhantomInstInfoRequest = 17854,
		// Token: 0x040018E2 RID: 6370
		MixDrinkRoleInviteRequest = 20628,
		// Token: 0x040018E3 RID: 6371
		MotorFightRankListSelfDataRequest = 28172,
		// Token: 0x040018E4 RID: 6372
		PhBaPlanUsePlanRequest = 27699,
		// Token: 0x040018E5 RID: 6373
		PhBaPlanSaveUsePlanRequest = 15491,
		// Token: 0x040018E6 RID: 6374
		PhBaPlanFindPlanRequest = 29810,
		// Token: 0x040018E7 RID: 6375
		KurotatoChestRewardSelectRequest = 16722,
		// Token: 0x040018E8 RID: 6376
		KurotatoUpgradeRewardSelectRequest = 20748,
		// Token: 0x040018E9 RID: 6377
		KurotatoUpgradeRewardRefreshRequest = 19521,
		// Token: 0x040018EA RID: 6378
		KurotatoShopRewardSelectRequest = 25262,
		// Token: 0x040018EB RID: 6379
		KurotatoShopRewardLockRequest = 27851,
		// Token: 0x040018EC RID: 6380
		KurotatoShopRewardRefreshRequest = 27770,
		// Token: 0x040018ED RID: 6381
		MixDrinkRoleRewardRequest = 21940,
		// Token: 0x040018EE RID: 6382
		JokerGuessRewardRequest = 26198,
		// Token: 0x040018EF RID: 6383
		StorageInfoRequest = 20672,
		// Token: 0x040018F0 RID: 6384
		StorageInfoUpdateRequest = 22023,
		// Token: 0x040018F1 RID: 6385
		FeiXuePreheatInfoRewardRequest = 17951,
		// Token: 0x040018F2 RID: 6386
		RhythmChangePartnerRoleRequest = 23553,
		// Token: 0x040018F3 RID: 6387
		RhythmRankListRequest = 26399,
		// Token: 0x040018F4 RID: 6388
		RhythmRankListSelfDataRequest = 25501,
		// Token: 0x040018F5 RID: 6389
		RhythmSettleRequest = 18268,
		// Token: 0x040018F6 RID: 6390
		RhythmSetRedDotRequest = 24911,
		// Token: 0x040018F7 RID: 6391
		RhythmTaskOneKeyRewardRequest = 27736,
		// Token: 0x040018F8 RID: 6392
		DropCatchLevelRewardRequest = 26230,
		// Token: 0x040018F9 RID: 6393
		DropCatchLevelFinishRequest = 23994,
		// Token: 0x040018FA RID: 6394
		SplinePositionUpdateRequest = 24134,
		// Token: 0x040018FB RID: 6395
		KurotatoEndShopStepRequest = 26067,
		// Token: 0x040018FC RID: 6396
		NewTowerLastCycleInfoRequest = 17540,
		// Token: 0x040018FD RID: 6397
		NewTowerSeasonRewardRequest = 23587,
		// Token: 0x040018FE RID: 6398
		NewTowerRecommendRequest = 23165,
		// Token: 0x040018FF RID: 6399
		ScheduleNpcUpdatePosRequest = 21451,
		// Token: 0x04001900 RID: 6400
		KurotatoRefineWeaponRequest = 28420,
		// Token: 0x04001901 RID: 6401
		PhBaPlanSetPlanStatusRequest = 24251,
		// Token: 0x04001902 RID: 6402
		PhBaPlanUpdatePlanRequest = 23537,
		// Token: 0x04001903 RID: 6403
		PhBaPlanSetFiveStarSwitchRequest = 17981,
		// Token: 0x04001904 RID: 6404
		NewTowerSeasonScoreRewardRequest = 26245,
		// Token: 0x04001905 RID: 6405
		StartRecallRequest = 18032,
		// Token: 0x04001906 RID: 6406
		ChangeOrnamentRequest = 16754,
		// Token: 0x04001907 RID: 6407
		DropCatchInfoRequest = 21673,
		// Token: 0x04001908 RID: 6408
		AvoidBlockSubmitOverNodeRequest = 28527,
		// Token: 0x04001909 RID: 6409
		KurotatoSellWeaponRequest = 28213,
		// Token: 0x0400190A RID: 6410
		TetrisFinishRequest = 15095,
		// Token: 0x0400190B RID: 6411
		RacingBetsCloseSettleMenuRequest = 15685,
		// Token: 0x0400190C RID: 6412
		PlayerXboxInfoGetRequest = 17106,
		// Token: 0x0400190D RID: 6413
		PlayerCreateXboxSessionRequest = 19073,
		// Token: 0x0400190E RID: 6414
		PlayerXboxBlockListRequest = 17705,
		// Token: 0x0400190F RID: 6415
		XboxSettingUpdateRequest = 17883,
		// Token: 0x04001910 RID: 6416
		XboxSettingRequest = 17199,
		// Token: 0x04001911 RID: 6417
		PinballTeamReviveRequest = 26619,
		// Token: 0x04001912 RID: 6418
		PinballSetPayloadRequest = 23171,
		// Token: 0x04001913 RID: 6419
		RoleSkillQuickLevelUpRequest = 29438,
		// Token: 0x04001914 RID: 6420
		GaSwitchCommonEnemyProCampRequest = 18387,
		// Token: 0x04001915 RID: 6421
		PinballTeamDieRequest = 15247,
		// Token: 0x04001916 RID: 6422
		PinballQuitRequest = 23709,
		// Token: 0x04001917 RID: 6423
		PinballBonusFullWinRequest = 19347,
		// Token: 0x04001918 RID: 6424
		PinballInGameSyncPayloadRequest = 18030,
		// Token: 0x04001919 RID: 6425
		PinballTaskRewardRequest = 17084,
		// Token: 0x0400191A RID: 6426
		PinballRoleLevelUpRequest = 20427,
		// Token: 0x0400191B RID: 6427
		PinballWeaponDegradeRequest = 15550,
		// Token: 0x0400191C RID: 6428
		PinballWeaponWearRequest = 22578,
		// Token: 0x0400191D RID: 6429
		PinballFriendRankRequest = 27697,
		// Token: 0x0400191E RID: 6430
		InfrV2InfoRequest = 20516,
		// Token: 0x0400191F RID: 6431
		InfrV2LevelUpRequest = 26367,
		// Token: 0x04001920 RID: 6432
		InfrV2TreeBuildRequest = 17207,
		// Token: 0x04001921 RID: 6433
		InfrV2ManualSwitchTraceTreeRequest = 24316,
		// Token: 0x04001922 RID: 6434
		InfrV2ManualCancelTraceTreeRequest = 25977,
		// Token: 0x04001923 RID: 6435
		RogueInstExtraInfoRequest = 28775,
		// Token: 0x04001924 RID: 6436
		InfrV2ScoreRewardRequest = 29142,
		// Token: 0x04001925 RID: 6437
		InfrV2TaskRewardRequest = 17782,
		// Token: 0x04001926 RID: 6438
		RhythmMainLineInfoRequest = 17348,
		// Token: 0x04001927 RID: 6439
		ThemePersonalScoreRequest = 20050,
		// Token: 0x04001928 RID: 6440
		ThemeWorldScoreRequest = 27224,
		// Token: 0x04001929 RID: 6441
		WuWuTaskRewardRequest = 20996,
		// Token: 0x0400192A RID: 6442
		BossPilingRewardRequest = 21613,
		// Token: 0x0400192B RID: 6443
		PhBaPlanBatchOperRequest = 26395,
		// Token: 0x0400192C RID: 6444
		MotorOutlookCreatePresetRequest = 19553,
		// Token: 0x0400192D RID: 6445
		MotorOutlookDeletePresetRequest = 27629,
		// Token: 0x0400192E RID: 6446
		MotorOutlookEditPresetRequest = 26832,
		// Token: 0x0400192F RID: 6447
		FlowerPollutionRequest = 22707,
		// Token: 0x04001930 RID: 6448
		MotorDecalTaskRequest = 17341,
		// Token: 0x04001931 RID: 6449
		MotorDecalMotorIpRequest = 27551,
		// Token: 0x04001932 RID: 6450
		BossPilingSettleRequest = 19863,
		// Token: 0x04001933 RID: 6451
		RacingBetsRepeatedTaskRewardRequest = 25268,
		// Token: 0x04001934 RID: 6452
		LinkageCheckInRewardRequest = 17237,
		// Token: 0x04001935 RID: 6453
		GolemCrackUpdateRequest = 18010,
		// Token: 0x04001936 RID: 6454
		QuestBranchRequest = 19642,
		// Token: 0x04001937 RID: 6455
		QuestBranchSelectRequest = 19447,
		// Token: 0x04001938 RID: 6456
		RoleGiftRewardRequest = 29332,
		// Token: 0x04001939 RID: 6457
		NewTowerSeasonTaskDataUpdateRequest = 18463,
		// Token: 0x0400193A RID: 6458
		WuWuPackageRewardRequest = 18557,
		// Token: 0x0400193B RID: 6459
		PinballInGameKickBallRequest = 22423,
		// Token: 0x0400193C RID: 6460
		GachaAccumulateInfoRequest = 28411,
		// Token: 0x0400193D RID: 6461
		GachaAccumulateRewardRequest = 21085,
		// Token: 0x0400193E RID: 6462
		PlayerEnterPollutionRequest = 27660,
		// Token: 0x0400193F RID: 6463
		QuickHackSkillRequest = 23390,
		// Token: 0x04001940 RID: 6464
		EdgeRunnerFunctionPreUnlockRequest = 21322,
		// Token: 0x04001941 RID: 6465
		EdgeRunnerScoreRewardRequest = 28427,
		// Token: 0x04001942 RID: 6466
		EdgeRunnerTaskRewardRequest = 28256,
		// Token: 0x04001943 RID: 6467
		KurotatoScoreTaskReceiveRequest = 25395,
		// Token: 0x04001944 RID: 6468
		KurotatoResTaskReceiveRequest = 16881,
		// Token: 0x04001945 RID: 6469
		KurotatoLimitTaskReceiveRequest = 19700,
		// Token: 0x04001946 RID: 6470
		KurotatoRoleRecordRequest = 25830,
		// Token: 0x04001947 RID: 6471
		WeeklyFrameworkInfoRequest = 29511,
		// Token: 0x04001948 RID: 6472
		WeeklyFrameworkScoreRewardRequest = 27471,
		// Token: 0x04001949 RID: 6473
		FloroRanchWeeklyRequest = 18853,
		// Token: 0x0400194A RID: 6474
		DollGrabRequest = 17827,
		// Token: 0x0400194B RID: 6475
		DollGrabTimeBallRequest = 15812,
		// Token: 0x0400194C RID: 6476
		DollGarbStartRequest = 25749,
		// Token: 0x0400194D RID: 6477
		ApplySceneClientEntityIncIdRequest = 24599,
		// Token: 0x0400194E RID: 6478
		AvoidBlockClientInitDoneRequest = 15216,
		// Token: 0x0400194F RID: 6479
		ConsumptiveActivityScoreRequest = 21065,
		// Token: 0x04001950 RID: 6480
		MonsterPatrolPointReachedRequest = 27779,
		// Token: 0x04001951 RID: 6481
		ClientPullResourcePackageRequest = 28300,
		// Token: 0x04001952 RID: 6482
		NewHandInItemRequest = 23060,
		// Token: 0x04001953 RID: 6483
		DollDeliveryRequest = 17654,
		// Token: 0x04001954 RID: 6484
		OnlineMotorActivityLevelRequest = 24796,
		// Token: 0x04001955 RID: 6485
		PlayerVoiceLanguageRequest = 22437,
		// Token: 0x04001956 RID: 6486
		PlayerRoleVoiceSetRequest = 22391,
		// Token: 0x04001957 RID: 6487
		FloroRanchEventChoiceRequest = 25648,
		// Token: 0x04001958 RID: 6488
		KurotatoSettlementRequest = 29686,
		// Token: 0x04001959 RID: 6489
		RemoteBatchCollectRequest = 20492,
		// Token: 0x0400195A RID: 6490
		BatchMaterialReplaceRequest = 25690,
		// Token: 0x0400195B RID: 6491
		NewPlayerSupportSetCurUseTrialRoleV2Request = 19403,
		// Token: 0x0400195C RID: 6492
		ChangeSummonEntityStateRequest = 23569,
		// Token: 0x0400195D RID: 6493
		NewPlayerSupportTrialRoleLvUpV2Request = 17058,
		// Token: 0x0400195E RID: 6494
		RealmBetweenFullRewardRequest = 15385,
		// Token: 0x0400195F RID: 6495
		RealmBetweenLevelUpRequest = 27479,
		// Token: 0x04001960 RID: 6496
		RealmBetweenTaskRewardRequest = 19830,
		// Token: 0x04001961 RID: 6497
		RealmBetweenMotorRewardRequest = 27266,
		// Token: 0x04001962 RID: 6498
		RogueArchiveListRequest = 28324,
		// Token: 0x04001963 RID: 6499
		RogueArchiveSaveRequest = 20091,
		// Token: 0x04001964 RID: 6500
		RogueTowerTrialStartRequest = 24725,
		// Token: 0x04001965 RID: 6501
		RogueTowerTrialSelectBossRequest = 22870,
		// Token: 0x04001966 RID: 6502
		RogueTowerTrialReChallengeRequest = 24158,
		// Token: 0x04001967 RID: 6503
		RogueTowerTrialResultRequest = 19883,
		// Token: 0x04001968 RID: 6504
		SheriffZoneInfoRequest = 20973,
		// Token: 0x04001969 RID: 6505
		KurotatoEndSpecialWaveCombatRequest = 16538,
		// Token: 0x0400196A RID: 6506
		BabelTowerShowNameRequest = 16067,
		// Token: 0x0400196B RID: 6507
		BabelTowerRankListRequest = 29408,
		// Token: 0x0400196C RID: 6508
		BabelTowerSelfPassRequest = 27544,
		// Token: 0x0400196D RID: 6509
		DollGrabStopRequest = 18186,
		// Token: 0x0400196E RID: 6510
		RogueTowerTrialGiveUpTempArchiveRequest = 20363,
		// Token: 0x0400196F RID: 6511
		MiniWriteLetterSaveContentRequest = 26392,
		// Token: 0x04001970 RID: 6512
		SignActivityFreeDropRequest = 27704,
		// Token: 0x04001971 RID: 6513
		KurotatoReChallengeRequest = 20651,
		// Token: 0x04001972 RID: 6514
		DollGrabPauseStartRequest = 16209,
		// Token: 0x04001973 RID: 6515
		DollGrabPauseEndRequest = 15196,
		// Token: 0x04001974 RID: 6516
		TraceRecallQuestRequest = 25878,
		// Token: 0x04001975 RID: 6517
		RecallQuestFinishActionRequest = 28969,
		// Token: 0x04001976 RID: 6518
		RecallQuestActionRequest = 28770,
		// Token: 0x04001977 RID: 6519
		RecallQuestNpcMoveOverRequest = 26604,
		// Token: 0x04001978 RID: 6520
		RecallQuestFinishActionEndRequest = 21179,
		// Token: 0x04001979 RID: 6521
		NewbieAdventureTaskRewardRequest = 29376,
		// Token: 0x0400197A RID: 6522
		NewbieAdventureChapterDropRequest = 16662,
		// Token: 0x0400197B RID: 6523
		NewbieAdventureRoleRewardRequest = 16825,
		// Token: 0x0400197C RID: 6524
		NewbieCourseV2RewardRequest = 27099,
		// Token: 0x0400197D RID: 6525
		NewbieFetchScoreRewardRequest = 25135,
		// Token: 0x0400197E RID: 6526
		FloroRanchOutRequest = 23261,
		// Token: 0x0400197F RID: 6527
		RecallQuestReadyForGiveUpRequest = 17217,
		// Token: 0x04001980 RID: 6528
		ResonantChainOptionalLimitRequest = 17766,
		// Token: 0x04001981 RID: 6529
		QueryRecallItemBagRequest = 20446,
		// Token: 0x04001982 RID: 6530
		SetClientGlobalVarRequest = 22272,
		// Token: 0x04001983 RID: 6531
		DollGarbInsertCoinRequest = 28609,
		// Token: 0x04001984 RID: 6532
		RoverRogueQuitRequest = 27391,
		// Token: 0x04001985 RID: 6533
		RoverRogueResultRequest = 28320,
		// Token: 0x04001986 RID: 6534
		RoverRogueChooseDataResultRequest = 29940,
		// Token: 0x04001987 RID: 6535
		RoverRogueRefreshGainRequest = 29906,
		// Token: 0x04001988 RID: 6536
		RoverRogueGiveUpGainRequest = 28315,
		// Token: 0x04001989 RID: 6537
		RoverRogueGotoNextRoomCommitRequest = 21542,
		// Token: 0x0400198A RID: 6538
		RoverRogueInsListRequest = 29791,
		// Token: 0x0400198B RID: 6539
		RoverRogueTalentInfoRequest = 18812,
		// Token: 0x0400198C RID: 6540
		RoverRogueTalentUnlockRequest = 16548,
		// Token: 0x0400198D RID: 6541
		RoverRogueShopBuyRequest = 15194,
		// Token: 0x0400198E RID: 6542
		RoverRogueShopRefreshRequest = 21321,
		// Token: 0x0400198F RID: 6543
		DangoBrawlBagOperateRequest = 27984,
		// Token: 0x04001990 RID: 6544
		DangoBrawlShopRefreshRequest = 23068,
		// Token: 0x04001991 RID: 6545
		DangoBrawlShopLockRequest = 24357,
		// Token: 0x04001992 RID: 6546
		DangoBrawlShopBuyRequest = 24895,
		// Token: 0x04001993 RID: 6547
		DangoBrawlShopSellRequest = 29894,
		// Token: 0x04001994 RID: 6548
		DangoBrawlShopComposeRequest = 20473,
		// Token: 0x04001995 RID: 6549
		DangoBrawlEventRefreshRequest = 28024,
		// Token: 0x04001996 RID: 6550
		DangoBrawlEventSelectRequest = 19472,
		// Token: 0x04001997 RID: 6551
		DangoBrawlStartFightRequest = 26094,
		// Token: 0x04001998 RID: 6552
		DangoBrawlFightOverRequest = 28918,
		// Token: 0x04001999 RID: 6553
		RoverRogueBlessGroupSelectRequest = 25277,
		// Token: 0x0400199A RID: 6554
		NewTowerMedalInfoRequest = 26935,
		// Token: 0x0400199B RID: 6555
		RoverRogueEventSelectRequest = 25790,
		// Token: 0x0400199C RID: 6556
		MotorUseSceneRequest = 15459,
		// Token: 0x0400199D RID: 6557
		DangoBrawlSettleRequest = 28335,
		// Token: 0x0400199E RID: 6558
		DangoBrawlTaskRewardRequest = 19998,
		// Token: 0x0400199F RID: 6559
		UpdatePhantomEquipGroupRequest = 22464,
		// Token: 0x040019A0 RID: 6560
		QuestFastReturnPosRequest = 23769,
		// Token: 0x040019A1 RID: 6561
		LevelPlayFastReturnPosRequest = 27495,
		// Token: 0x040019A2 RID: 6562
		FastReturnDungeonRequest = 26812,
		// Token: 0x040019A3 RID: 6563
		DollSmallMapInfoRequest = 20965,
		// Token: 0x040019A4 RID: 6564
		RoverRogueLootInfoRequest = 19483,
		// Token: 0x040019A5 RID: 6565
		RoverRogueLootChangeRequest = 22152,
		// Token: 0x040019A6 RID: 6566
		KurotatoStepAdvanceRequest = 16129,
		// Token: 0x040019A7 RID: 6567
		RecallExploreSkillRouletteSetRequest = 29727,
		// Token: 0x040019A8 RID: 6568
		RoverRogueTaskRewardTakeRequest = 29942,
		// Token: 0x040019A9 RID: 6569
		SceneGroupDataAndCurFormationEntityRequest = 26969,
		// Token: 0x040019AA RID: 6570
		KurotatoGoldAddRequest = 18249,
		// Token: 0x040019AB RID: 6571
		TowerDefenceChallengeQuitRequest = 27718,
		// Token: 0x040019AC RID: 6572
		KurotatoLevelRecordDeleteRequest = 20893,
		// Token: 0x040019AD RID: 6573
		MailFavoriteRequest = 20816,
		// Token: 0x040019AE RID: 6574
		ConditionGroupStateRequest = 25810,
		// Token: 0x040019AF RID: 6575
		ZitherPlayStateRequest = 21137,
		// Token: 0x040019B0 RID: 6576
		EntityAccessCasketRequest = 17160,
		// Token: 0x040019B1 RID: 6577
		PlayerAccessCasketRequest = 19061,
		// Token: 0x040019B2 RID: 6578
		QingXiaoTaskRewardRequest = 29336,
		// Token: 0x040019B3 RID: 6579
		GiantDeliveryItemRequest = 26525,
		// Token: 0x040019B4 RID: 6580
		GiantMaxLevelDeliveryItemRequest = 24629,
		// Token: 0x040019B5 RID: 6581
		MatchThreeStarRequest = 19959,
		// Token: 0x040019B6 RID: 6582
		MatchThreeEndRequest = 29259,
		// Token: 0x040019B7 RID: 6583
		DangoBrawlScoreRewardRequest = 15066,
		// Token: 0x040019B8 RID: 6584
		FoundationCoreOperateRequest = 27836,
		// Token: 0x040019B9 RID: 6585
		CameraSettingQueryRequest = 26920,
		// Token: 0x040019BA RID: 6586
		CameraSettingModifyRequest = 28953,
		// Token: 0x040019BB RID: 6587
		RecallTeleportToMarkIdRequest = 23922,
		// Token: 0x040019BC RID: 6588
		ShortMessageChatThemeChangeRequest = 29084,
		// Token: 0x040019BD RID: 6589
		ShortMessageChatCharmChangeRequest = 23634,
		// Token: 0x040019BE RID: 6590
		RenameFormationRequest = 26314,
		// Token: 0x040019BF RID: 6591
		SolarSchoolSaveRequest = 18477,
		// Token: 0x040019C0 RID: 6592
		SolarSchoolLoadRequest = 15073,
		// Token: 0x040019C1 RID: 6593
		SolarSchoolSetFlowRequest = 21219,
		// Token: 0x040019C2 RID: 6594
		SolarSchoolReachEndingRequest = 27408,
		// Token: 0x040019C3 RID: 6595
		SolarSchoolOneKeyRewardRequest = 22187,
		// Token: 0x040019C4 RID: 6596
		SolarSchoolBatchSyncRequest = 28917,
		// Token: 0x040019C5 RID: 6597
		SolarSchoolOneKeyGalleryRewardRequest = 26247,
		// Token: 0x040019C6 RID: 6598
		ReorderFormationRequest = 27566,
		// Token: 0x040019C7 RID: 6599
		GiantStableValueActivityRequest = 20090,
		// Token: 0x040019C8 RID: 6600
		RecallItemUseRequest = 18849,
		// Token: 0x040019C9 RID: 6601
		GameStatsShowRequest = 16656,
		// Token: 0x040019CA RID: 6602
		SelfPortraitStateRequest = 17018,
		// Token: 0x040019CB RID: 6603
		LoopTeleportVolumeActionRequest = 22884,
		// Token: 0x040019CC RID: 6604
		SolarSchoolTaskProgressRewardRequest = 22424,
		// Token: 0x040019CD RID: 6605
		RoleTowerSaveDeleteRequest = 29169,
		// Token: 0x040019CE RID: 6606
		RoleTowerChallengeSettleRequest = 19036,
		// Token: 0x040019CF RID: 6607
		RoleTowerRankRequest = 19891,
		// Token: 0x040019D0 RID: 6608
		RoleTowerRewardTaskReceiveRequest = 29411,
		// Token: 0x040019D1 RID: 6609
		RoleTowerScoreRewardReceiveRequest = 20934,
		// Token: 0x040019D2 RID: 6610
		TeamRecommendRequest = 19191,
		// Token: 0x040019D3 RID: 6611
		WellStreamingFinisRequest = 20746,
		// Token: 0x040019D4 RID: 6612
		TimePointActivityBatchRewardRequest = 28173,
		// Token: 0x040019D5 RID: 6613
		RoleTowerStepAdvanceRequest = 23562,
		// Token: 0x040019D6 RID: 6614
		RoleTowerStageSettleRequest = 23809,
		// Token: 0x040019D7 RID: 6615
		RoleTowerStageRetryRequest = 28382,
		// Token: 0x040019D8 RID: 6616
		RoleTowerRankRewardReceiveRequest = 23829,
		// Token: 0x040019D9 RID: 6617
		RoleTowerConsumeItemRequest = 17781,
		// Token: 0x040019DA RID: 6618
		RoleTowerPhantomAddAttrsRequest = 29253,
		// Token: 0x040019DB RID: 6619
		RoleTowerAttributeQueryRequest = 26515
	}
}
