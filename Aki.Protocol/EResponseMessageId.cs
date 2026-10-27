using System;

namespace Aki.Protocol
{
	// Token: 0x0200000B RID: 11
	public enum EResponseMessageId
	{
		// Token: 0x04001998 RID: 6552
		CreateCharacterResponse = 102,
		// Token: 0x04001999 RID: 6553
		LoginResponse = 104,
		// Token: 0x0400199A RID: 6554
		EnterGameResponse = 106,
		// Token: 0x0400199B RID: 6555
		ReconnectResponse = 108,
		// Token: 0x0400199C RID: 6556
		ProtoKeyResponse = 112,
		// Token: 0x0400199D RID: 6557
		AchievementInfoResponse = 26649,
		// Token: 0x0400199E RID: 6558
		AchievementReceiveResponse = 22908,
		// Token: 0x0400199F RID: 6559
		AchievementFinishResponse = 21914,
		// Token: 0x040019A0 RID: 6560
		ActionFinishResponse,
		// Token: 0x040019A1 RID: 6561
		GmLevelActionResponse = 17916,
		// Token: 0x040019A2 RID: 6562
		ActivityResponse = 24041,
		// Token: 0x040019A3 RID: 6563
		ActivityFirstReadResponse = 25958,
		// Token: 0x040019A4 RID: 6564
		SignActivityResponse = 18069,
		// Token: 0x040019A5 RID: 6565
		HarvestActivityPointResponse = 22430,
		// Token: 0x040019A6 RID: 6566
		HarvestActivityLevelResponse = 15302,
		// Token: 0x040019A7 RID: 6567
		HarvestActivityLevelDiffResponse = 15960,
		// Token: 0x040019A8 RID: 6568
		HarvestActivityResultResponse = 24362,
		// Token: 0x040019A9 RID: 6569
		PhantomCollectReceiveResponse = 23631,
		// Token: 0x040019AA RID: 6570
		AdventureManualDataResponse = 17876,
		// Token: 0x040019AB RID: 6571
		GetAdventureRewardResponse = 19480,
		// Token: 0x040019AC RID: 6572
		GetChapterRewardResponse = 17302,
		// Token: 0x040019AD RID: 6573
		DetectionResponse = 17538,
		// Token: 0x040019AE RID: 6574
		AdventureManualResponse = 23292,
		// Token: 0x040019AF RID: 6575
		ReceivedSilentFirstAwardResponse = 15246,
		// Token: 0x040019B0 RID: 6576
		SelectDetectionTargetResponse = 22576,
		// Token: 0x040019B1 RID: 6577
		MonsterDetectionInfoResponse = 22038,
		// Token: 0x040019B2 RID: 6578
		NormalMonsterManualInfoResponse = 23619,
		// Token: 0x040019B3 RID: 6579
		GetDetectionLabelInfoResponse = 24360,
		// Token: 0x040019B4 RID: 6580
		AdviceSetResponse = 27439,
		// Token: 0x040019B5 RID: 6581
		AdviceResponse = 17200,
		// Token: 0x040019B6 RID: 6582
		AdviceCreateResponse = 19595,
		// Token: 0x040019B7 RID: 6583
		AdviceModifyResponse = 25965,
		// Token: 0x040019B8 RID: 6584
		AdviceDeleteResponse = 28461,
		// Token: 0x040019B9 RID: 6585
		AdviceVoteResponse = 25631,
		// Token: 0x040019BA RID: 6586
		AiInformationResponse = 16509,
		// Token: 0x040019BB RID: 6587
		AiBlackboardsResponse = 23212,
		// Token: 0x040019BC RID: 6588
		AiBlackboardCdResponse = 24526,
		// Token: 0x040019BD RID: 6589
		AiHateResponse = 28446,
		// Token: 0x040019BE RID: 6590
		AiControlSwitchResponse = 19656,
		// Token: 0x040019BF RID: 6591
		EnterAreaResponse = 23858,
		// Token: 0x040019C0 RID: 6592
		ReportPlayerResponse = 23940,
		// Token: 0x040019C1 RID: 6593
		ModifyNameResponse = 29083,
		// Token: 0x040019C2 RID: 6594
		ModifySignatureResponse = 19625,
		// Token: 0x040019C3 RID: 6595
		ChangeHeadPhotoResponse = 20433,
		// Token: 0x040019C4 RID: 6596
		ClientBasicInfoResponse = 29135,
		// Token: 0x040019C5 RID: 6597
		PlayerBasicInfoGetResponse = 22549,
		// Token: 0x040019C6 RID: 6598
		BirthdayInitResponse = 23451,
		// Token: 0x040019C7 RID: 6599
		RoleShowListUpdateResponse = 21892,
		// Token: 0x040019C8 RID: 6600
		ChangeCardResponse = 28852,
		// Token: 0x040019C9 RID: 6601
		ReadCardResponse = 25329,
		// Token: 0x040019CA RID: 6602
		BirthdayShowSetResponse = 19338,
		// Token: 0x040019CB RID: 6603
		BattlePassResponse = 26818,
		// Token: 0x040019CC RID: 6604
		BattlePassTakeRewardResponse = 16911,
		// Token: 0x040019CD RID: 6605
		BattlePassRecurringTakeResponse = 22206,
		// Token: 0x040019CE RID: 6606
		BattlePassTakeAllRewardResponse = 28865,
		// Token: 0x040019CF RID: 6607
		BattlePassTaskResponse = 21675,
		// Token: 0x040019D0 RID: 6608
		BattlePassTaskTakeResponse = 16270,
		// Token: 0x040019D1 RID: 6609
		BattlePassLevelUpResponse = 21544,
		// Token: 0x040019D2 RID: 6610
		SubmitNodeResponse = 22370,
		// Token: 0x040019D3 RID: 6611
		HandInItemResponse = 26177,
		// Token: 0x040019D4 RID: 6612
		BtSetTimerInfoResponse = 26365,
		// Token: 0x040019D5 RID: 6613
		BtForcedOccupationResponse = 20380,
		// Token: 0x040019D6 RID: 6614
		BtGiveUpResponse = 23416,
		// Token: 0x040019D7 RID: 6615
		BtRollbackResponse = 25479,
		// Token: 0x040019D8 RID: 6616
		SneakResponse = 20692,
		// Token: 0x040019D9 RID: 6617
		SneakTimeResponse = 18825,
		// Token: 0x040019DA RID: 6618
		TimerEndResponse = 27179,
		// Token: 0x040019DB RID: 6619
		UiGamePlayResponse = 18181,
		// Token: 0x040019DC RID: 6620
		NpcTraceFailedResponse = 26082,
		// Token: 0x040019DD RID: 6621
		WorldBlackboardResponse = 23698,
		// Token: 0x040019DE RID: 6622
		EntityBlackboardResponse = 24947,
		// Token: 0x040019DF RID: 6623
		BlockListResponse = 16716,
		// Token: 0x040019E0 RID: 6624
		BlockPlayerResponse = 21431,
		// Token: 0x040019E1 RID: 6625
		UnblockPlayerResponse = 27927,
		// Token: 0x040019E2 RID: 6626
		PlaceItemOnBoardResponse = 18063,
		// Token: 0x040019E3 RID: 6627
		CommitBoardResponse = 15817,
		// Token: 0x040019E4 RID: 6628
		MovePlacementResponse = 27133,
		// Token: 0x040019E5 RID: 6629
		ApplyGameplayEffectResponse = 22915,
		// Token: 0x040019E6 RID: 6630
		RemoveGameplayEffectResponse = 28077,
		// Token: 0x040019E7 RID: 6631
		OrderApplyBuffResponse = 27266,
		// Token: 0x040019E8 RID: 6632
		OrderRemoveBuffResponse = 17452,
		// Token: 0x040019E9 RID: 6633
		ActivateBuffResponse = 19917,
		// Token: 0x040019EA RID: 6634
		OrderRemoveBuffByTagsResponse = 16551,
		// Token: 0x040019EB RID: 6635
		BuffEffectExecuteResponse = 17533,
		// Token: 0x040019EC RID: 6636
		BuffStackCountResponse = 26251,
		// Token: 0x040019ED RID: 6637
		BuffEffectResponse = 16967,
		// Token: 0x040019EE RID: 6638
		BuffItemResponse = 22356,
		// Token: 0x040019EF RID: 6639
		CalabashMsgResponse = 16706,
		// Token: 0x040019F0 RID: 6640
		CalabashLevelRewardResponse = 25587,
		// Token: 0x040019F1 RID: 6641
		CdKeyVerifyResponse = 28544,
		// Token: 0x040019F2 RID: 6642
		ChatResponse = 18241,
		// Token: 0x040019F3 RID: 6643
		PrivateChatResponse = 16640,
		// Token: 0x040019F4 RID: 6644
		PrivateChatHistoryResponse = 29725,
		// Token: 0x040019F5 RID: 6645
		PrivateChatDataResponse = 19466,
		// Token: 0x040019F6 RID: 6646
		ChatMutePlayerResponse = 26353,
		// Token: 0x040019F7 RID: 6647
		PrivateChatOperateResponse = 16211,
		// Token: 0x040019F8 RID: 6648
		ChannelChatResponse = 18195,
		// Token: 0x040019F9 RID: 6649
		CombatSendPackResponse = 20332,
		// Token: 0x040019FA RID: 6650
		CombatMaxCaseMessageResponse = 19109,
		// Token: 0x040019FB RID: 6651
		FixToolResponse = 23245,
		// Token: 0x040019FC RID: 6652
		CookFormulaResponse = 25849,
		// Token: 0x040019FD RID: 6653
		CookFoodResponse = 23290,
		// Token: 0x040019FE RID: 6654
		FoodProcessResponse = 25197,
		// Token: 0x040019FF RID: 6655
		CertificateLevelRewardResponse = 20218,
		// Token: 0x04001A00 RID: 6656
		CookingDataResponse = 24521,
		// Token: 0x04001A01 RID: 6657
		InteractiveUpdateResponse = 15988,
		// Token: 0x04001A02 RID: 6658
		DailyAdventurePtRewardResponse = 16430,
		// Token: 0x04001A03 RID: 6659
		DailyAdventureTaskRewardResponse = 16686,
		// Token: 0x04001A04 RID: 6660
		CheatInputResponse = 20265,
		// Token: 0x04001A05 RID: 6661
		EnableDamageRecordResponse = 20429,
		// Token: 0x04001A06 RID: 6662
		OutputDebugInfoResponse = 25805,
		// Token: 0x04001A07 RID: 6663
		PickUpDropItemResponse = 22257,
		// Token: 0x04001A08 RID: 6664
		ElevatorStateChangeResponse = 16901,
		// Token: 0x04001A09 RID: 6665
		EnergySyncResponse = 18125,
		// Token: 0x04001A0A RID: 6666
		ChangeStateResponse = 27097,
		// Token: 0x04001A0B RID: 6667
		ChangeStateConfirmResponse = 23779,
		// Token: 0x04001A0C RID: 6668
		FsmConditionPassResponse = 27979,
		// Token: 0x04001A0D RID: 6669
		GmEntityFsmGroupInfoResponse = 15216,
		// Token: 0x04001A0E RID: 6670
		EntityBuffProducerResponse = 22006,
		// Token: 0x04001A0F RID: 6671
		EntityBuffProducerOperateResponse = 27203,
		// Token: 0x04001A10 RID: 6672
		LogicStateInitResponse = 25241,
		// Token: 0x04001A11 RID: 6673
		SwitchLogicStateResponse = 25754,
		// Token: 0x04001A12 RID: 6674
		EntityActiveResponse = 26702,
		// Token: 0x04001A13 RID: 6675
		AnimationGameplayTagResponse = 20718,
		// Token: 0x04001A14 RID: 6676
		AnimalDieResponse = 22932,
		// Token: 0x04001A15 RID: 6677
		AnimalDestroyResponse = 26691,
		// Token: 0x04001A16 RID: 6678
		AnimalDropResponse = 25751,
		// Token: 0x04001A17 RID: 6679
		EntityInteractResponse = 29908,
		// Token: 0x04001A18 RID: 6680
		EntityRandomInteractResponse = 20654,
		// Token: 0x04001A19 RID: 6681
		EntityDynamicInteractResponse = 17030,
		// Token: 0x04001A1A RID: 6682
		EntityPosAbnormalResponse = 21848,
		// Token: 0x04001A1B RID: 6683
		EntityAdsorbResponse = 25318,
		// Token: 0x04001A1C RID: 6684
		BoneVisibleChangeResponse = 20334,
		// Token: 0x04001A1D RID: 6685
		EntityStaticHookMoveResponse = 24175,
		// Token: 0x04001A1E RID: 6686
		EntityPatrolStartResponse = 23660,
		// Token: 0x04001A1F RID: 6687
		EntityPatrolStopResponse = 23618,
		// Token: 0x04001A20 RID: 6688
		EntityPatrolChangeDirResponse = 23851,
		// Token: 0x04001A21 RID: 6689
		VfxNpcPatrolFinishResponse = 19912,
		// Token: 0x04001A22 RID: 6690
		EntitySendEventResponse = 25789,
		// Token: 0x04001A23 RID: 6691
		AccessPasserbyNpcSpawnerResponse = 25897,
		// Token: 0x04001A24 RID: 6692
		ExploreProgressResponse = 26475,
		// Token: 0x04001A25 RID: 6693
		ExploreScoreRewardResponse = 16181,
		// Token: 0x04001A26 RID: 6694
		CountryExploreScoreInfoResponse = 19799,
		// Token: 0x04001A27 RID: 6695
		VisionExploreSkillSetResponse = 18650,
		// Token: 0x04001A28 RID: 6696
		ExploreSkillRouletteSetResponse = 24039,
		// Token: 0x04001A29 RID: 6697
		ExploreSkillPullGiantResponse = 27102,
		// Token: 0x04001A2A RID: 6698
		UseDetectionSkillResponse = 29685,
		// Token: 0x04001A2B RID: 6699
		SetFanNumberOfTurnsResponse = 27529,
		// Token: 0x04001A2C RID: 6700
		SetBaoziStateResponse = 19707,
		// Token: 0x04001A2D RID: 6701
		SetFanStateResponse = 23657,
		// Token: 0x04001A2E RID: 6702
		RoleFavorListResponse = 24905,
		// Token: 0x04001A2F RID: 6703
		RoleFavorUnLockResponse = 20728,
		// Token: 0x04001A30 RID: 6704
		RoleFavorAcceptQuestResponse = 29317,
		// Token: 0x04001A31 RID: 6705
		RoleFavorTalkScoreResponse = 17643,
		// Token: 0x04001A32 RID: 6706
		RoleMotionUnLockResponse = 28146,
		// Token: 0x04001A33 RID: 6707
		SkillResponse = 20499,
		// Token: 0x04001A34 RID: 6708
		UseSkillResponse = 28239,
		// Token: 0x04001A35 RID: 6709
		EndSkillResponse = 29159,
		// Token: 0x04001A36 RID: 6710
		InterruptSkillInDelayResponse = 15726,
		// Token: 0x04001A37 RID: 6711
		UseSkillFailResponse = 28988,
		// Token: 0x04001A38 RID: 6712
		HitResponse = 16481,
		// Token: 0x04001A39 RID: 6713
		HitEndResponse = 28059,
		// Token: 0x04001A3A RID: 6714
		CaughtResponse = 17589,
		// Token: 0x04001A3B RID: 6715
		CreateBulletResponse = 20162,
		// Token: 0x04001A3C RID: 6716
		DestroyBulletResponse = 22475,
		// Token: 0x04001A3D RID: 6717
		ModifyBulletParamsResponse = 21100,
		// Token: 0x04001A3E RID: 6718
		DamageExecuteResponse = 22796,
		// Token: 0x04001A3F RID: 6719
		PassiveSkillAddResponse = 20187,
		// Token: 0x04001A40 RID: 6720
		PassiveSkillRemoveResponse = 20593,
		// Token: 0x04001A41 RID: 6721
		EnterViewDirectionResponse = 26211,
		// Token: 0x04001A42 RID: 6722
		ExitViewDirectionResponse = 20227,
		// Token: 0x04001A43 RID: 6723
		TriggerExitSkillResponse = 22190,
		// Token: 0x04001A44 RID: 6724
		CharacterDeathResponse = 22581,
		// Token: 0x04001A45 RID: 6725
		SwitchBattleModeResponse = 26064,
		// Token: 0x04001A46 RID: 6726
		LandingDamageResponse = 29437,
		// Token: 0x04001A47 RID: 6727
		EntityIsVisibleResponse = 27951,
		// Token: 0x04001A48 RID: 6728
		ActorVisibleResponse = 29481,
		// Token: 0x04001A49 RID: 6729
		SwitchCharacterStateResponse = 24015,
		// Token: 0x04001A4A RID: 6730
		BattleStateChangeResponse = 27150,
		// Token: 0x04001A4B RID: 6731
		ToughCalcExtraRatioChangeResponse = 18566,
		// Token: 0x04001A4C RID: 6732
		MonsterBoomResponse = 23701,
		// Token: 0x04001A4D RID: 6733
		EntityBattleInfoResponse = 24276,
		// Token: 0x04001A4E RID: 6734
		MontagePlayResponse = 23384,
		// Token: 0x04001A4F RID: 6735
		ANStartResponse = 15208,
		// Token: 0x04001A50 RID: 6736
		SwitchRoleResponse = 16059,
		// Token: 0x04001A51 RID: 6737
		UpdateFormationResponse = 25651,
		// Token: 0x04001A52 RID: 6738
		UpdateFightRoleResponse = 18693,
		// Token: 0x04001A53 RID: 6739
		GetFormationDataResponse = 22433,
		// Token: 0x04001A54 RID: 6740
		FlowEndResponse = 24390,
		// Token: 0x04001A55 RID: 6741
		FlowRestartResponse = 27398,
		// Token: 0x04001A56 RID: 6742
		FlowActionResponse = 21929,
		// Token: 0x04001A57 RID: 6743
		ForgeInfoResponse = 28293,
		// Token: 0x04001A58 RID: 6744
		ForgeItemResponse = 27784,
		// Token: 0x04001A59 RID: 6745
		ForgeFormulaUnlockResponse = 18480,
		// Token: 0x04001A5A RID: 6746
		FormationResponse = 18151,
		// Token: 0x04001A5B RID: 6747
		FormationSwitchCurrentResponse = 15112,
		// Token: 0x04001A5C RID: 6748
		FormationModifyResponse = 25309,
		// Token: 0x04001A5D RID: 6749
		FormationChangeResponse = 22944,
		// Token: 0x04001A5E RID: 6750
		FormationSwitchRoleResponse = 23668,
		// Token: 0x04001A5F RID: 6751
		ClientCurrentRoleReportResponse = 24285,
		// Token: 0x04001A60 RID: 6752
		FriendAllResponse = 17252,
		// Token: 0x04001A61 RID: 6753
		FriendApplySendResponse = 19754,
		// Token: 0x04001A62 RID: 6754
		FriendApplyHandleResponse = 23606,
		// Token: 0x04001A63 RID: 6755
		FriendRemarkResponse = 20061,
		// Token: 0x04001A64 RID: 6756
		FriendDeleteResponse = 29748,
		// Token: 0x04001A65 RID: 6757
		FriendRecentlyTeamResponse = 18777,
		// Token: 0x04001A66 RID: 6758
		FuncShowResponse = 21886,
		// Token: 0x04001A67 RID: 6759
		GachaInfoResponse = 18695,
		// Token: 0x04001A68 RID: 6760
		GachaResponse = 19056,
		// Token: 0x04001A69 RID: 6761
		GachaUsePoolResponse = 25952,
		// Token: 0x04001A6A RID: 6762
		GatherActivityRewardResponse = 20681,
		// Token: 0x04001A6B RID: 6763
		GuideInfoResponse = 23730,
		// Token: 0x04001A6C RID: 6764
		GuideTriggerResponse = 25821,
		// Token: 0x04001A6D RID: 6765
		GuideFinishResponse = 25597,
		// Token: 0x04001A6E RID: 6766
		HeartbeatResponse = 1651,
		// Token: 0x04001A6F RID: 6767
		GatewayEchoResponse = 21290,
		// Token: 0x04001A70 RID: 6768
		IllustratedRedDotResponse = 15199,
		// Token: 0x04001A71 RID: 6769
		IllustratedInfoResponse = 24603,
		// Token: 0x04001A72 RID: 6770
		IllustratedUnlockResponse = 18471,
		// Token: 0x04001A73 RID: 6771
		IllustratedReadResponse = 20958,
		// Token: 0x04001A74 RID: 6772
		InfluenceInfoResponse = 29322,
		// Token: 0x04001A75 RID: 6773
		InfluenceRewardResponse = 26210,
		// Token: 0x04001A76 RID: 6774
		ReadDisplayInfoResponse = 21345,
		// Token: 0x04001A77 RID: 6775
		EnterInstResponse = 19352,
		// Token: 0x04001A78 RID: 6776
		UnlockInstEntranceResponse = 29172,
		// Token: 0x04001A79 RID: 6777
		InstEntranceDetailResponse = 25904,
		// Token: 0x04001A7A RID: 6778
		LeaveInstResponse = 21587,
		// Token: 0x04001A7B RID: 6779
		GetInstExchangeRewardResponse = 21421,
		// Token: 0x04001A7C RID: 6780
		ExchangeRewardInfoResponse = 28025,
		// Token: 0x04001A7D RID: 6781
		SingleInstRechallengeResponse = 21069,
		// Token: 0x04001A7E RID: 6782
		ItemDecomposeResponse = 23183,
		// Token: 0x04001A7F RID: 6783
		ItemDecomposePreviewResponse = 16088,
		// Token: 0x04001A80 RID: 6784
		ItemLockResponse = 18915,
		// Token: 0x04001A81 RID: 6785
		ItemUseResponse = 21012,
		// Token: 0x04001A82 RID: 6786
		ItemGiftUseResponse = 17290,
		// Token: 0x04001A83 RID: 6787
		NormalItemResponse = 22445,
		// Token: 0x04001A84 RID: 6788
		WeaponItemResponse = 27089,
		// Token: 0x04001A85 RID: 6789
		PhantomItemResponse = 26275,
		// Token: 0x04001A86 RID: 6790
		InvalidItemResponse = 25487,
		// Token: 0x04001A87 RID: 6791
		ShowInvalidItemResponse = 18549,
		// Token: 0x04001A88 RID: 6792
		ValidTimeItemResponse = 20447,
		// Token: 0x04001A89 RID: 6793
		ItemExchangeInfoResponse = 20569,
		// Token: 0x04001A8A RID: 6794
		ItemExchangeResponse = 23286,
		// Token: 0x04001A8B RID: 6795
		LevelPlayRewardResponse = 21572,
		// Token: 0x04001A8C RID: 6796
		LivenessResponse = 28359,
		// Token: 0x04001A8D RID: 6797
		LivenessTaskTakeResponse = 18488,
		// Token: 0x04001A8E RID: 6798
		LivenessTakeResponse = 20024,
		// Token: 0x04001A8F RID: 6799
		LoadEquipInfoResponse = 23620,
		// Token: 0x04001A90 RID: 6800
		EquipTakeOnResponse = 28184,
		// Token: 0x04001A91 RID: 6801
		LordGymInfoResponse = 27687,
		// Token: 0x04001A92 RID: 6802
		LordGymBeginResponse = 22749,
		// Token: 0x04001A93 RID: 6803
		LordGymReadResponse = 18978,
		// Token: 0x04001A94 RID: 6804
		MailReadResponse = 28318,
		// Token: 0x04001A95 RID: 6805
		MailGetAttachmentResponse = 27409,
		// Token: 0x04001A96 RID: 6806
		MailDeleteResponse = 20393,
		// Token: 0x04001A97 RID: 6807
		MapMarkInfoResponse = 21025,
		// Token: 0x04001A98 RID: 6808
		MapUnlockFieldInfoResponse = 24181,
		// Token: 0x04001A99 RID: 6809
		MapMarkResponse = 27926,
		// Token: 0x04001A9A RID: 6810
		MapRemoveMarkResponse = 24173,
		// Token: 0x04001A9B RID: 6811
		MapTraceInfoResponse = 28319,
		// Token: 0x04001A9C RID: 6812
		MapTraceResponse = 22948,
		// Token: 0x04001A9D RID: 6813
		MapCancelTraceResponse = 29919,
		// Token: 0x04001A9E RID: 6814
		MapReplaceMarkResponse = 24504,
		// Token: 0x04001A9F RID: 6815
		MapRemoveAllMarkResponse = 23583,
		// Token: 0x04001AA0 RID: 6816
		MapMarkInfoUpdateResponse = 17549,
		// Token: 0x04001AA1 RID: 6817
		StartMatchResponse = 20517,
		// Token: 0x04001AA2 RID: 6818
		CancelMatchResponse = 17942,
		// Token: 0x04001AA3 RID: 6819
		MatchConfirmResponse = 18498,
		// Token: 0x04001AA4 RID: 6820
		MatchChangeRoleResponse = 20466,
		// Token: 0x04001AA5 RID: 6821
		MatchChangeReadyResponse = 15160,
		// Token: 0x04001AA6 RID: 6822
		LeaveMatchTeamResponse = 29714,
		// Token: 0x04001AA7 RID: 6823
		KickMatchTeamPlayerResponse = 23716,
		// Token: 0x04001AA8 RID: 6824
		SetMatchTeamMatchFlagResponse = 23137,
		// Token: 0x04001AA9 RID: 6825
		EnterMatchInstResponse = 20833,
		// Token: 0x04001AAA RID: 6826
		TeamChallengeResponse = 19774,
		// Token: 0x04001AAB RID: 6827
		TeamMatchInviteResponse = 29449,
		// Token: 0x04001AAC RID: 6828
		TeamMatchAcceptInviteResponse = 16611,
		// Token: 0x04001AAD RID: 6829
		MatchChangePlayerUiStateResponse = 20959,
		// Token: 0x04001AAE RID: 6830
		HandInMingSuResponse = 23593,
		// Token: 0x04001AAF RID: 6831
		ActiveDragonPoolResponse = 29130,
		// Token: 0x04001AB0 RID: 6832
		DragonPoolConfResponse = 24543,
		// Token: 0x04001AB1 RID: 6833
		MonthCardResponse = 29522,
		// Token: 0x04001AB2 RID: 6834
		MutiplayerTeamRefreshNearListResponse = 20855,
		// Token: 0x04001AB3 RID: 6835
		NetTestDataResponse = 29222,
		// Token: 0x04001AB4 RID: 6836
		NewBieCourseRewardResponse = 23806,
		// Token: 0x04001AB5 RID: 6837
		NewJourneyResponse = 16530,
		// Token: 0x04001AB6 RID: 6838
		ParkourChallengeResponse = 29088,
		// Token: 0x04001AB7 RID: 6839
		ParkourChallengeTakeResponse = 23450,
		// Token: 0x04001AB8 RID: 6840
		ParkourChallengeTransResponse = 23607,
		// Token: 0x04001AB9 RID: 6841
		PartComponentInitResponse = 25211,
		// Token: 0x04001ABA RID: 6842
		PartUpdateResponse = 28131,
		// Token: 0x04001ABB RID: 6843
		PayInfoResponse = 25815,
		// Token: 0x04001ABC RID: 6844
		PayItemResponse = 16661,
		// Token: 0x04001ABD RID: 6845
		PayGiftInfoResponse = 16033,
		// Token: 0x04001ABE RID: 6846
		PayGiftResponse = 16671,
		// Token: 0x04001ABF RID: 6847
		PayShopInfoResponse = 25954,
		// Token: 0x04001AC0 RID: 6848
		PayShopUpdateResponse = 22804,
		// Token: 0x04001AC1 RID: 6849
		PayShopItemUpdateResponse = 27686,
		// Token: 0x04001AC2 RID: 6850
		PayShopBuyResponse = 25381,
		// Token: 0x04001AC3 RID: 6851
		PayShopDirectBuyResponse = 20285,
		// Token: 0x04001AC4 RID: 6852
		PhantomLevelUpResponse = 22489,
		// Token: 0x04001AC5 RID: 6853
		PhantomPutOnResponse = 16317,
		// Token: 0x04001AC6 RID: 6854
		PhantomReturnPreviewResponse = 27740,
		// Token: 0x04001AC7 RID: 6855
		PhantomReturnResponse = 21387,
		// Token: 0x04001AC8 RID: 6856
		PhantomRecommendResponse = 28376,
		// Token: 0x04001AC9 RID: 6857
		PhantomAutoPutResponse = 19223,
		// Token: 0x04001ACA RID: 6858
		PhantomIdentifyResponse = 21034,
		// Token: 0x04001ACB RID: 6859
		PhantomSkinChangeResponse = 29630,
		// Token: 0x04001ACC RID: 6860
		PhantomRefiningResponse = 29840,
		// Token: 0x04001ACD RID: 6861
		UpdatePlayerPassiveSkillResponse = 20928,
		// Token: 0x04001ACE RID: 6862
		PlayerMotionResponse = 21104,
		// Token: 0x04001ACF RID: 6863
		PressResponse = 26869,
		// Token: 0x04001AD0 RID: 6864
		PressGameResponse = 22730,
		// Token: 0x04001AD1 RID: 6865
		ProgressBarFinishResponse = 23237,
		// Token: 0x04001AD2 RID: 6866
		FormationAttrResponse = 26997,
		// Token: 0x04001AD3 RID: 6867
		FragileChangeResponse = 16203,
		// Token: 0x04001AD4 RID: 6868
		CheckPublicResourceVersionResponse = 15757,
		// Token: 0x04001AD5 RID: 6869
		TraceQuestResponse = 29698,
		// Token: 0x04001AD6 RID: 6870
		QuestFinishActionResponse = 26546,
		// Token: 0x04001AD7 RID: 6871
		QuestActionResponse = 16333,
		// Token: 0x04001AD8 RID: 6872
		QuestNpcMoveOverResponse = 19722,
		// Token: 0x04001AD9 RID: 6873
		QuestFinishActionEndResponse = 16750,
		// Token: 0x04001ADA RID: 6874
		DailyQuestChangePreferResponse = 27145,
		// Token: 0x04001ADB RID: 6875
		DailyQuestGetRewardResponse = 21514,
		// Token: 0x04001ADC RID: 6876
		RoleQuestAcceptResponse = 24464,
		// Token: 0x04001ADD RID: 6877
		RoleQuestPointStateResponse = 22800,
		// Token: 0x04001ADE RID: 6878
		QuestRedDotResponse = 18604,
		// Token: 0x04001ADF RID: 6879
		ApplyRechallengeResponse = 22112,
		// Token: 0x04001AE0 RID: 6880
		ReceiveRechallengeResponse = 26240,
		// Token: 0x04001AE1 RID: 6881
		InviteRechallengeResponse = 16100,
		// Token: 0x04001AE2 RID: 6882
		ReviveResponse = 29474,
		// Token: 0x04001AE3 RID: 6883
		AddReviveRegionResponse = 28871,
		// Token: 0x04001AE4 RID: 6884
		RemoveReviveRegionResponse = 19851,
		// Token: 0x04001AE5 RID: 6885
		RoguelikeRefreshGainResponse = 25725,
		// Token: 0x04001AE6 RID: 6886
		RoguelikeChooseDataResponse = 21308,
		// Token: 0x04001AE7 RID: 6887
		RoguelikeChooseDataResultResponse = 17572,
		// Token: 0x04001AE8 RID: 6888
		RoguelikeLastInfoResponse = 16971,
		// Token: 0x04001AE9 RID: 6889
		RoguelikeStartResponse = 28058,
		// Token: 0x04001AEA RID: 6890
		RoguelikeQuitResponse = 15309,
		// Token: 0x04001AEB RID: 6891
		RoguelikeResultResponse = 28757,
		// Token: 0x04001AEC RID: 6892
		RoguelikeGotoNextRoomResponse = 22376,
		// Token: 0x04001AED RID: 6893
		RoguelikeTalentInfoResponse = 23720,
		// Token: 0x04001AEE RID: 6894
		RoguelikeTalentLevelUpResponse = 21035,
		// Token: 0x04001AEF RID: 6895
		RoguelikeSeasonDataResponse = 29540,
		// Token: 0x04001AF0 RID: 6896
		RoguelikeTokenReceiveResponse = 28422,
		// Token: 0x04001AF1 RID: 6897
		RoguelikeSeasonRewardReceiveResponse = 26366,
		// Token: 0x04001AF2 RID: 6898
		RoguelikeGiveUpGainResponse = 25582,
		// Token: 0x04001AF3 RID: 6899
		PbGetRoleListResponse = 25557,
		// Token: 0x04001AF4 RID: 6900
		PbUpLevelRoleResponse = 17222,
		// Token: 0x04001AF5 RID: 6901
		PbOverRoleResponse = 29016,
		// Token: 0x04001AF6 RID: 6902
		PbUpLevelSkillResponse = 17988,
		// Token: 0x04001AF7 RID: 6903
		RoleLevelUpViewResponse = 15925,
		// Token: 0x04001AF8 RID: 6904
		RoleBreakThroughViewResponse = 21102,
		// Token: 0x04001AF9 RID: 6905
		RoleSkillLevelUpViewResponse = 17683,
		// Token: 0x04001AFA RID: 6906
		RoleSkillViewResponse = 20300,
		// Token: 0x04001AFB RID: 6907
		RoleActivateSkillResponse = 17555,
		// Token: 0x04001AFC RID: 6908
		ResonantChainUnlockResponse = 29448,
		// Token: 0x04001AFD RID: 6909
		RoleSexChangeResponse = 18787,
		// Token: 0x04001AFE RID: 6910
		RoleElementChangeResponse = 17259,
		// Token: 0x04001AFF RID: 6911
		TrialRoleRewardResponse = 23104,
		// Token: 0x04001B00 RID: 6912
		CaptureEntityResponse = 22470,
		// Token: 0x04001B01 RID: 6913
		RemoveSummonEntityResponse = 17688,
		// Token: 0x04001B02 RID: 6914
		ChangeEntityRoleResponse = 24212,
		// Token: 0x04001B03 RID: 6915
		EntityOnLandedResponse = 17811,
		// Token: 0x04001B04 RID: 6916
		AttributeInitResponse = 29079,
		// Token: 0x04001B05 RID: 6917
		AttributeChangedResponse = 21027,
		// Token: 0x04001B06 RID: 6918
		AnimationStateInitResponse = 28333,
		// Token: 0x04001B07 RID: 6919
		AnimationStateChangedResponse = 16407,
		// Token: 0x04001B08 RID: 6920
		HardnessModeChangedResponse = 27736,
		// Token: 0x04001B09 RID: 6921
		SummonResponse = 18705,
		// Token: 0x04001B0A RID: 6922
		Summon2Response = 28056,
		// Token: 0x04001B0B RID: 6923
		RemoveInstanceTimerResponse = 19370,
		// Token: 0x04001B0C RID: 6924
		UpdateSceneDateResponse = 18163,
		// Token: 0x04001B0D RID: 6925
		DiscardWeaponResponse = 22877,
		// Token: 0x04001B0E RID: 6926
		CreatStoryCharacterResponse = 24862,
		// Token: 0x04001B0F RID: 6927
		DeleteStoryCharacterResponse = 29781,
		// Token: 0x04001B10 RID: 6928
		CreatureDetailResponse = 18855,
		// Token: 0x04001B11 RID: 6929
		ChangeEntityStateResponse = 28032,
		// Token: 0x04001B12 RID: 6930
		FoundationResponse = 17723,
		// Token: 0x04001B13 RID: 6931
		BeControlledResponse = 18432,
		// Token: 0x04001B14 RID: 6932
		BeControlledShowResponse = 26724,
		// Token: 0x04001B15 RID: 6933
		BeControlledThrowResponse = 28508,
		// Token: 0x04001B16 RID: 6934
		GravityGearResponse = 25409,
		// Token: 0x04001B17 RID: 6935
		ChangeWeatherResponse = 21042,
		// Token: 0x04001B18 RID: 6936
		FollowTrackResponse = 22950,
		// Token: 0x04001B19 RID: 6937
		SetInitTagResponse = 24518,
		// Token: 0x04001B1A RID: 6938
		DrownResponse = 18315,
		// Token: 0x04001B1B RID: 6939
		DrownEndTeleportResponse = 17520,
		// Token: 0x04001B1C RID: 6940
		MonsterDrownResponse = 25334,
		// Token: 0x04001B1D RID: 6941
		SceneLoadingFinishResponse = 25807,
		// Token: 0x04001B1E RID: 6942
		SitChairResponse = 22930,
		// Token: 0x04001B1F RID: 6943
		BeControlledDestroyResponse = 24018,
		// Token: 0x04001B20 RID: 6944
		ChangeDataLayerFinishResponse = 27963,
		// Token: 0x04001B21 RID: 6945
		MoveSceneItemResetPositionResponse = 29511,
		// Token: 0x04001B22 RID: 6946
		HookLockPointResponse = 23488,
		// Token: 0x04001B23 RID: 6947
		CheckGearResponse = 16110,
		// Token: 0x04001B24 RID: 6948
		SceneItemStateResponse = 19635,
		// Token: 0x04001B25 RID: 6949
		MaterialResponse = 22263,
		// Token: 0x04001B26 RID: 6950
		CommonOrganResetTimeResponse = 24405,
		// Token: 0x04001B27 RID: 6951
		TargetGearHitResponse = 18922,
		// Token: 0x04001B28 RID: 6952
		ThrowDamageResponse = 26863,
		// Token: 0x04001B29 RID: 6953
		GetRewardTreasureBoxResponse = 28349,
		// Token: 0x04001B2A RID: 6954
		MobileButtonSettingUpdateResponse = 27442,
		// Token: 0x04001B2B RID: 6955
		LanguageSettingUpdateResponse = 27367,
		// Token: 0x04001B2C RID: 6956
		ShopInfoResponse = 24794,
		// Token: 0x04001B2D RID: 6957
		ShopBuyResponse = 25673,
		// Token: 0x04001B2E RID: 6958
		ShopUpdateResponse = 28984,
		// Token: 0x04001B2F RID: 6959
		SneakFinishResponse = 18398,
		// Token: 0x04001B30 RID: 6960
		SpecialItemEquipResponse = 19540,
		// Token: 0x04001B31 RID: 6961
		SpecialItemUnEquipResponse = 27162,
		// Token: 0x04001B32 RID: 6962
		SynthesisInfoResponse = 15373,
		// Token: 0x04001B33 RID: 6963
		SynthesisItemResponse = 24016,
		// Token: 0x04001B34 RID: 6964
		SynthesisLevelRewardResponse = 26239,
		// Token: 0x04001B35 RID: 6965
		SynthesisFormulaUnlockResponse = 17641,
		// Token: 0x04001B36 RID: 6966
		TeleportDataResponse = 18941,
		// Token: 0x04001B37 RID: 6967
		TeleportTransferResponse = 24923,
		// Token: 0x04001B38 RID: 6968
		TeleportFinishResponse = 18021,
		// Token: 0x04001B39 RID: 6969
		UnOpenedAreaPullbackResponse = 16235,
		// Token: 0x04001B3A RID: 6970
		RemoveTemporaryTeleportResponse = 24806,
		// Token: 0x04001B3B RID: 6971
		TeleportToTargetResponse = 16327,
		// Token: 0x04001B3C RID: 6972
		ThirdPartyShareResponse = 29740,
		// Token: 0x04001B3D RID: 6973
		RTimeStopResponse = 29193,
		// Token: 0x04001B3E RID: 6974
		RTimeStopInstResponse = 29799,
		// Token: 0x04001B3F RID: 6975
		TimelineTraceStartResponse = 21613,
		// Token: 0x04001B40 RID: 6976
		TimelineTraceControlResponse = 28330,
		// Token: 0x04001B41 RID: 6977
		TimelineTraceExitResponse = 26335,
		// Token: 0x04001B42 RID: 6978
		TimeCheckResponse = 17250,
		// Token: 0x04001B43 RID: 6979
		TowerResponse = 16485,
		// Token: 0x04001B44 RID: 6980
		TowerSeasonUpdateResponse = 18739,
		// Token: 0x04001B45 RID: 6981
		TowerFormationRecommendResponse = 18909,
		// Token: 0x04001B46 RID: 6982
		TowerRewardResponse = 20230,
		// Token: 0x04001B47 RID: 6983
		TowerStartResponse = 18078,
		// Token: 0x04001B48 RID: 6984
		TowerResetResponse = 22328,
		// Token: 0x04001B49 RID: 6985
		TowerApplyFloorDataResponse = 29629,
		// Token: 0x04001B4A RID: 6986
		TowerGuideActivityRewardResponse = 18982,
		// Token: 0x04001B4B RID: 6987
		TowerGuideActivityInfoResponse = 18537,
		// Token: 0x04001B4C RID: 6988
		TurntableCompleteResponse = 22465,
		// Token: 0x04001B4D RID: 6989
		TutorialInfoResponse = 26976,
		// Token: 0x04001B4E RID: 6990
		TutorialReceiveResponse = 26141,
		// Token: 0x04001B4F RID: 6991
		TutorialUnlockResponse = 21973,
		// Token: 0x04001B50 RID: 6992
		WeaponLevelUpResponse = 21842,
		// Token: 0x04001B51 RID: 6993
		WeaponBreachResponse = 24159,
		// Token: 0x04001B52 RID: 6994
		WeaponResonUpResponse = 24490,
		// Token: 0x04001B53 RID: 6995
		WorldLevelDownResponse = 27079,
		// Token: 0x04001B54 RID: 6996
		WorldLevelRegainResponse = 22321,
		// Token: 0x04001B55 RID: 6997
		WorldEnterPermissionsResponse = 26732,
		// Token: 0x04001B56 RID: 6998
		ApplyJoinWorldResponse = 24536,
		// Token: 0x04001B57 RID: 6999
		AgreeJoinResultResponse = 19703,
		// Token: 0x04001B58 RID: 7000
		LobbyListResponse = 16660,
		// Token: 0x04001B59 RID: 7001
		LobbyQueryPlayersResponse = 23831,
		// Token: 0x04001B5A RID: 7002
		LeaveWorldTeamResponse = 16965,
		// Token: 0x04001B5B RID: 7003
		KickWorldTeamResponse = 19020,
		// Token: 0x04001B5C RID: 7004
		EntityBeamReceiveResponse = 21799,
		// Token: 0x04001B5D RID: 7005
		AttachEntityResponse = 16598,
		// Token: 0x04001B5E RID: 7006
		EntityPatrolAddTagResponse = 26261,
		// Token: 0x04001B5F RID: 7007
		LongShanTaskRewardResponse = 22021,
		// Token: 0x04001B60 RID: 7008
		EntityAccessRangeResponse = 22572,
		// Token: 0x04001B61 RID: 7009
		PlayerAccessRangeResponse = 19314,
		// Token: 0x04001B62 RID: 7010
		RoguelikePopularEntriesInfoResponse = 24291,
		// Token: 0x04001B63 RID: 7011
		RoguelikePopularEntriesChangeResponse = 25998,
		// Token: 0x04001B64 RID: 7012
		HookLockPointFinishResponse = 15889,
		// Token: 0x04001B65 RID: 7013
		BuildingLevelUpResponse = 22769,
		// Token: 0x04001B66 RID: 7014
		RoleTrainResponse = 26024,
		// Token: 0x04001B67 RID: 7015
		AcceptEntrustResponse = 29986,
		// Token: 0x04001B68 RID: 7016
		InvestResponse = 21729,
		// Token: 0x04001B69 RID: 7017
		TrackMoonEntrustDataResponse = 17258,
		// Token: 0x04001B6A RID: 7018
		TrackMoonRoleDataResponse = 29783,
		// Token: 0x04001B6B RID: 7019
		RunTurntableActivityResponse = 26481,
		// Token: 0x04001B6C RID: 7020
		TrackMoonBuildingDataResponse = 20309,
		// Token: 0x04001B6D RID: 7021
		BuildingUnLockResponse = 22569,
		// Token: 0x04001B6E RID: 7022
		BossRushClaimRewardResponse = 20167,
		// Token: 0x04001B6F RID: 7023
		BossRushSettlementResponse = 15915,
		// Token: 0x04001B70 RID: 7024
		SceneModeChangeFinishResponse = 15283,
		// Token: 0x04001B71 RID: 7025
		RoguelikeTrialRoleInfoResponse = 28212,
		// Token: 0x04001B72 RID: 7026
		PhotoMemoryResponse = 24419,
		// Token: 0x04001B73 RID: 7027
		PhotoMemoryRewardResponse = 16842,
		// Token: 0x04001B74 RID: 7028
		SceneItemSetPosSenderResponse = 25717,
		// Token: 0x04001B75 RID: 7029
		TraceEntityPosResponse = 25394,
		// Token: 0x04001B76 RID: 7030
		CombatMessagePrefixInfoResponse = 26444,
		// Token: 0x04001B77 RID: 7031
		CombatMessagePostInfoResponse = 20596,
		// Token: 0x04001B78 RID: 7032
		TrackMoonTargetRewardResponse = 26623,
		// Token: 0x04001B79 RID: 7033
		FsmStateBehaviorResponse = 18875,
		// Token: 0x04001B7A RID: 7034
		FsmPlayMontageResponse = 22825,
		// Token: 0x04001B7B RID: 7035
		RTimeStopAnimResponse = 20676,
		// Token: 0x04001B7C RID: 7036
		RolePropResponse = 19787,
		// Token: 0x04001B7D RID: 7037
		TrackMoonSettleResponse = 21671,
		// Token: 0x04001B7E RID: 7038
		TrackMoonIllustratedResponse = 18884,
		// Token: 0x04001B7F RID: 7039
		TowerDefenceInstanceRewardResponse = 23869,
		// Token: 0x04001B80 RID: 7040
		TowerDefenceScoreRewardResponse = 21331,
		// Token: 0x04001B81 RID: 7041
		FlowTeleportToPlotPosResponse = 27445,
		// Token: 0x04001B82 RID: 7042
		ConnectorConnectEntityResponse = 21486,
		// Token: 0x04001B83 RID: 7043
		BeControlledEntityHoverResponse = 15043,
		// Token: 0x04001B84 RID: 7044
		InitRangeResponse = 19814,
		// Token: 0x04001B85 RID: 7045
		TrackMoonActivityRewardResponse = 18470,
		// Token: 0x04001B86 RID: 7046
		TimePointActivityRewardResponse = 28642,
		// Token: 0x04001B87 RID: 7047
		CircumFluenceTaskRewardResponse = 19238,
		// Token: 0x04001B88 RID: 7048
		GameplayCueResponse = 21252,
		// Token: 0x04001B89 RID: 7049
		SceneItemStopResponse = 23071,
		// Token: 0x04001B8A RID: 7050
		RoguelikeRoleRoomSelectResponse = 27983,
		// Token: 0x04001B8B RID: 7051
		SecFBRoundStartFlowResponse = 18546,
		// Token: 0x04001B8C RID: 7052
		SecGetReportData2FlowResponse = 27302,
		// Token: 0x04001B8D RID: 7053
		SecFBRoundEndFlowReportResponse = 28053,
		// Token: 0x04001B8E RID: 7054
		SecRoleFightFlowResponse = 16148,
		// Token: 0x04001B8F RID: 7055
		SecWorldInfoFlowResponse = 24938,
		// Token: 0x04001B90 RID: 7056
		SecWorldStartFlowResponse = 27691,
		// Token: 0x04001B91 RID: 7057
		AwakeDynamicPortalResponse = 29309,
		// Token: 0x04001B92 RID: 7058
		GachaPoolDetailResponse = 26540,
		// Token: 0x04001B93 RID: 7059
		SecWorldSEndFlowResponse = 18732,
		// Token: 0x04001B94 RID: 7060
		OpenSystemBoardResultResponse = 17436,
		// Token: 0x04001B95 RID: 7061
		SceneItemMoveTargetResponse = 17935,
		// Token: 0x04001B96 RID: 7062
		TrackMoonBuildFlowResponse = 18212,
		// Token: 0x04001B97 RID: 7063
		CorniceMeetingRewardResponse = 22628,
		// Token: 0x04001B98 RID: 7064
		TraceMoonPhaseRewardResponse = 18742,
		// Token: 0x04001B99 RID: 7065
		LevelPlaySwitchSportModeResponse = 22082,
		// Token: 0x04001B9A RID: 7066
		PlayerPsnInfoGetResponse = 15989,
		// Token: 0x04001B9B RID: 7067
		PsnSettingUpdateResponse = 18454,
		// Token: 0x04001B9C RID: 7068
		PsnSettingResponse = 24512,
		// Token: 0x04001B9D RID: 7069
		RiskHarvestScoreRewardResponse = 27124,
		// Token: 0x04001B9E RID: 7070
		ItemDisuseResponse = 29774,
		// Token: 0x04001B9F RID: 7071
		PhantomBatchRefiningResponse = 22170,
		// Token: 0x04001BA0 RID: 7072
		RiskHarvestInstRewardResponse = 29859,
		// Token: 0x04001BA1 RID: 7073
		PassPortalResponse = 19351,
		// Token: 0x04001BA2 RID: 7074
		EnrichmentAreaResponse = 18556,
		// Token: 0x04001BA3 RID: 7075
		RiskHarvestBuffUnlockRewardResponse = 21018,
		// Token: 0x04001BA4 RID: 7076
		RiskHarvestBuffCountRewardResponse = 20737,
		// Token: 0x04001BA5 RID: 7077
		BlackCoastThemeTaskRewardResponse = 28490,
		// Token: 0x04001BA6 RID: 7078
		BlackCoastThemeActiveRewardResponse = 28700,
		// Token: 0x04001BA7 RID: 7079
		PlayerCreatePsnSessionResponse = 23299,
		// Token: 0x04001BA8 RID: 7080
		RenjuResetResponse = 28995,
		// Token: 0x04001BA9 RID: 7081
		CorniceChallengeTransResponse = 26808,
		// Token: 0x04001BAA RID: 7082
		GameplayTagResponse = 28943,
		// Token: 0x04001BAB RID: 7083
		ExecuteQteResponse = 26990,
		// Token: 0x04001BAC RID: 7084
		RiskHarvestSettleResponse = 28863,
		// Token: 0x04001BAD RID: 7085
		MingSuHandRewardResponse = 16113,
		// Token: 0x04001BAE RID: 7086
		SubmitAwakeAndLoadEntityNodeResponse = 29216,
		// Token: 0x04001BAF RID: 7087
		RoguelikeRoleInstStartResponse = 16214,
		// Token: 0x04001BB0 RID: 7088
		RoguelikeBossInstStartResponse = 17253,
		// Token: 0x04001BB1 RID: 7089
		PreheatSignRewardResponse = 15694,
		// Token: 0x04001BB2 RID: 7090
		PreheatSignSurveyInfoResponse = 24249,
		// Token: 0x04001BB3 RID: 7091
		DarkCoastInfoResponse = 20782,
		// Token: 0x04001BB4 RID: 7092
		InputSettingResponse = 18992,
		// Token: 0x04001BB5 RID: 7093
		InputSettingUpdateResponse = 29097,
		// Token: 0x04001BB6 RID: 7094
		RoguelikeWriteCatRewardResponse = 28034,
		// Token: 0x04001BB7 RID: 7095
		ConnectorCanConnectResponse = 29950,
		// Token: 0x04001BB8 RID: 7096
		ScratchCardRewardResponse = 18651,
		// Token: 0x04001BB9 RID: 7097
		TeleportDungeonActionResponse = 17189,
		// Token: 0x04001BBA RID: 7098
		SubmitWalkingPatternPointResponse = 24149,
		// Token: 0x04001BBB RID: 7099
		RoguelikeWriteCatBossRewardResponse = 21248,
		// Token: 0x04001BBC RID: 7100
		RoguelikeWriteCatLevelPlayRewardResponse = 25902,
		// Token: 0x04001BBD RID: 7101
		PlayerPsnBlockListResponse = 26528,
		// Token: 0x04001BBE RID: 7102
		VacuumCleanerResponse = 23100,
		// Token: 0x04001BBF RID: 7103
		BossRushChooseBuffResponse = 16679,
		// Token: 0x04001BC0 RID: 7104
		BossRushBuffChooseResultResponse = 21177,
		// Token: 0x04001BC1 RID: 7105
		JoinSceneNotifyConfirmResponse = 29017,
		// Token: 0x04001BC2 RID: 7106
		MailBindRewardResponse = 15814,
		// Token: 0x04001BC3 RID: 7107
		MailBindInfoResponse = 26430,
		// Token: 0x04001BC4 RID: 7108
		MailBindResponse = 20479,
		// Token: 0x04001BC5 RID: 7109
		HookLockPointExitResponse = 18710,
		// Token: 0x04001BC6 RID: 7110
		VehicleResponse = 18852,
		// Token: 0x04001BC7 RID: 7111
		PullingFoundationResponse = 29401,
		// Token: 0x04001BC8 RID: 7112
		AddTreasureBoxSlotResponse = 29769,
		// Token: 0x04001BC9 RID: 7113
		RemoveTreasureBoxSlotResponse = 27840,
		// Token: 0x04001BCA RID: 7114
		UseSoundBoxSkillResponse = 29780,
		// Token: 0x04001BCB RID: 7115
		AddTemporaryTeleportResponse = 17932,
		// Token: 0x04001BCC RID: 7116
		BossRushLevelScoreRewardResponse = 28357,
		// Token: 0x04001BCD RID: 7117
		EquipSkinTakeOnResponse = 24452,
		// Token: 0x04001BCE RID: 7118
		EquipSkinUnLoadResponse = 16037,
		// Token: 0x04001BCF RID: 7119
		SubmitPhotoNodeResponse = 29717,
		// Token: 0x04001BD0 RID: 7120
		RogueWhiteCatLimitedRewardResponse = 25642,
		// Token: 0x04001BD1 RID: 7121
		ScratchCardActivityInfoResponse = 16768,
		// Token: 0x04001BD2 RID: 7122
		QuestReadyForGiveUpResponse = 20397,
		// Token: 0x04001BD3 RID: 7123
		RogueWhiteCatRecordResponse = 15186,
		// Token: 0x04001BD4 RID: 7124
		SetAlertUiVisibleResponse = 19633,
		// Token: 0x04001BD5 RID: 7125
		CombineEntitiesResponse = 17364,
		// Token: 0x04001BD6 RID: 7126
		GiftPackPreviewResponse = 25776,
		// Token: 0x04001BD7 RID: 7127
		LastBigSceneMiniMapInfoResponse = 23770,
		// Token: 0x04001BD8 RID: 7128
		DissolveCombineRelationResponse = 23102,
		// Token: 0x04001BD9 RID: 7129
		ExploreSkillCustomResponse = 29046,
		// Token: 0x04001BDA RID: 7130
		AchievementUpdateResponse = 21082,
		// Token: 0x04001BDB RID: 7131
		SeamlessTeleportResponse = 19267,
		// Token: 0x04001BDC RID: 7132
		RogueBlackFlowerResponse = 18239,
		// Token: 0x04001BDD RID: 7133
		UpdateSceneGroupDataResponse = 25607,
		// Token: 0x04001BDE RID: 7134
		MowTowerSettlementResponse = 24294,
		// Token: 0x04001BDF RID: 7135
		MowTowerLevelsRewardResponse = 25477,
		// Token: 0x04001BE0 RID: 7136
		RoleSkinChangeResponse = 23541,
		// Token: 0x04001BE1 RID: 7137
		RoleSkinResponse = 22316,
		// Token: 0x04001BE2 RID: 7138
		PhantomMusicUnlockResponse = 19978,
		// Token: 0x04001BE3 RID: 7139
		PhantomMusicInfoResponse = 22582,
		// Token: 0x04001BE4 RID: 7140
		PhantomMusicSwitchResponse = 22198,
		// Token: 0x04001BE5 RID: 7141
		UpdateSceneItemBlackboardResponse = 29196,
		// Token: 0x04001BE6 RID: 7142
		VehicleChangePassengerResponse = 20697,
		// Token: 0x04001BE7 RID: 7143
		VehicleRemovePassengerResponse = 23958,
		// Token: 0x04001BE8 RID: 7144
		LevelSequenceFrameEventActionResponse = 26441,
		// Token: 0x04001BE9 RID: 7145
		SimpleTrackReportResponse = 22473,
		// Token: 0x04001BEA RID: 7146
		PlayerVoxelEnvResponse = 21932,
		// Token: 0x04001BEB RID: 7147
		MapTravelFullRewardResponse = 18919,
		// Token: 0x04001BEC RID: 7148
		MapTravelLevelUpResponse = 29440,
		// Token: 0x04001BED RID: 7149
		SpringSignDrawRoleResponse = 27629,
		// Token: 0x04001BEE RID: 7150
		LevelPlayVarResponse = 15621,
		// Token: 0x04001BEF RID: 7151
		MaterialReplaceResponse = 20685,
		// Token: 0x04001BF0 RID: 7152
		ExploreProgressRewardResponse = 25710,
		// Token: 0x04001BF1 RID: 7153
		SpringSignDrawRewardResponse = 28746,
		// Token: 0x04001BF2 RID: 7154
		EntityCameraAlertResponse = 27719,
		// Token: 0x04001BF3 RID: 7155
		ThroughTrainResponse = 26744,
		// Token: 0x04001BF4 RID: 7156
		CheckUseSoundBoxSkillResponse = 25981,
		// Token: 0x04001BF5 RID: 7157
		FarmGoldPointResponse = 21245,
		// Token: 0x04001BF6 RID: 7158
		FarmGoldLevelPlayResponse = 17979,
		// Token: 0x04001BF7 RID: 7159
		FarmGoldLevelDiffResponse = 17755,
		// Token: 0x04001BF8 RID: 7160
		SpringSignSkinRewardResponse = 27228,
		// Token: 0x04001BF9 RID: 7161
		FarmGoldResultResponse = 28241,
		// Token: 0x04001BFA RID: 7162
		FlowSeqSetPlayerPosResponse = 29220,
		// Token: 0x04001BFB RID: 7163
		SplineMoveResponse = 29534,
		// Token: 0x04001BFC RID: 7164
		LevelPlayStateResponse = 24154,
		// Token: 0x04001BFD RID: 7165
		PlayerHeadResponse = 20990,
		// Token: 0x04001BFE RID: 7166
		EntityWalkingPatternFinishResponse = 18680,
		// Token: 0x04001BFF RID: 7167
		QueryOnlinePlayersAreaResponse = 18627,
		// Token: 0x04001C00 RID: 7168
		MapTravelTaskRewardResponse = 29561,
		// Token: 0x04001C01 RID: 7169
		MapTravelSoarRewardResponse = 15096,
		// Token: 0x04001C02 RID: 7170
		FishingInfoResponse = 22596,
		// Token: 0x04001C03 RID: 7171
		FishingIllustratedRewardResponse = 27625,
		// Token: 0x04001C04 RID: 7172
		FishingCabinPutResponse = 19250,
		// Token: 0x04001C05 RID: 7173
		FishingQuickSellPreviewResponse = 20069,
		// Token: 0x04001C06 RID: 7174
		FishingQuickSellResponse = 26816,
		// Token: 0x04001C07 RID: 7175
		FishingSellPreviewResponse = 28511,
		// Token: 0x04001C08 RID: 7176
		FishingSellResponse = 29274,
		// Token: 0x04001C09 RID: 7177
		FishingSailingResponse = 16408,
		// Token: 0x04001C0A RID: 7178
		FishingEntrustHandInResponse = 25865,
		// Token: 0x04001C0B RID: 7179
		FishingEntrustTraceResponse = 16672,
		// Token: 0x04001C0C RID: 7180
		FishingEntrustRefreshResponse = 28664,
		// Token: 0x04001C0D RID: 7181
		FishingShipFixResponse = 20583,
		// Token: 0x04001C0E RID: 7182
		FishingTechLevelUpResponse = 25533,
		// Token: 0x04001C0F RID: 7183
		AccessPathConfigResponse = 24933,
		// Token: 0x04001C10 RID: 7184
		PlayerGameTokenResponse = 28955,
		// Token: 0x04001C11 RID: 7185
		RenjuExitMatchedActionResponse = 18128,
		// Token: 0x04001C12 RID: 7186
		TrialRoleSkinRewardResponse = 19716,
		// Token: 0x04001C13 RID: 7187
		LevelPlayStateListResponse = 20073,
		// Token: 0x04001C14 RID: 7188
		SpringSignPhotoRewardResponse = 26603,
		// Token: 0x04001C15 RID: 7189
		PhantomEquipGroupInfosResponse = 21429,
		// Token: 0x04001C16 RID: 7190
		AddPhantomEquipGroupResponse = 18193,
		// Token: 0x04001C17 RID: 7191
		DeletePhantomEquipGroupResponse = 26711,
		// Token: 0x04001C18 RID: 7192
		ChangePhantomEquipGroupNameResponse = 18227,
		// Token: 0x04001C19 RID: 7193
		TopPhantomEquipGroupResponse = 27536,
		// Token: 0x04001C1A RID: 7194
		FishingCompleteResponse = 21524,
		// Token: 0x04001C1B RID: 7195
		TeleportFlowEndResponse = 18758,
		// Token: 0x04001C1C RID: 7196
		RiskHarvestStarRewardResponse = 22246,
		// Token: 0x04001C1D RID: 7197
		PhantomFetterRecommendResponse = 15665,
		// Token: 0x04001C1E RID: 7198
		PhantomAttrRecommendResponse = 22535,
		// Token: 0x04001C1F RID: 7199
		FishingEntrustAcceptResponse = 28877,
		// Token: 0x04001C20 RID: 7200
		FishingExitResponse = 17597,
		// Token: 0x04001C21 RID: 7201
		FishingShipSkinChangeResponse = 15401,
		// Token: 0x04001C22 RID: 7202
		FishingPointInfoResponse = 18952,
		// Token: 0x04001C23 RID: 7203
		FishingCageInfoResponse = 25777,
		// Token: 0x04001C24 RID: 7204
		FishingHandInResponse = 15662,
		// Token: 0x04001C25 RID: 7205
		FishingSkillBombResponse = 25718,
		// Token: 0x04001C26 RID: 7206
		FishingSkillBaitResponse = 18662,
		// Token: 0x04001C27 RID: 7207
		FishingSkillTeleportResponse = 21518,
		// Token: 0x04001C28 RID: 7208
		RogueWeeklyRewardResponse = 26201,
		// Token: 0x04001C29 RID: 7209
		RogueWeeklyGotoNextRoomResponse = 26948,
		// Token: 0x04001C2A RID: 7210
		SlashAndTowerInfoResponse = 22143,
		// Token: 0x04001C2B RID: 7211
		SlashAndTowerScoreRewardResponse = 18008,
		// Token: 0x04001C2C RID: 7212
		EndLessHistoryResponse = 22456,
		// Token: 0x04001C2D RID: 7213
		SlashAndTowerSaveRecordResponse = 18715,
		// Token: 0x04001C2E RID: 7214
		SlashAndTowerResetResponse = 18583,
		// Token: 0x04001C2F RID: 7215
		SlashAndTowerRecommendResponse = 15984,
		// Token: 0x04001C30 RID: 7216
		BossRushTaskRewardResponse = 15100,
		// Token: 0x04001C31 RID: 7217
		UsePhantomEquipGroupResponse = 21750,
		// Token: 0x04001C32 RID: 7218
		FishingActivityLimitRewardResponse = 18435,
		// Token: 0x04001C33 RID: 7219
		FishingActivityMilestoneRewardResponse = 27837,
		// Token: 0x04001C34 RID: 7220
		TeamParkourRewardResponse = 16986,
		// Token: 0x04001C35 RID: 7221
		RogueWeeklyResultResponse = 16682,
		// Token: 0x04001C36 RID: 7222
		RogueWeeklyOptionSelectResponse = 19745,
		// Token: 0x04001C37 RID: 7223
		ThroughTrainFinishViewResponse = 26237,
		// Token: 0x04001C38 RID: 7224
		ActivityPreOpenResponse = 26244,
		// Token: 0x04001C39 RID: 7225
		LstBattleRecordResponse = 15485,
		// Token: 0x04001C3A RID: 7226
		RogueWeeklyStartResponse = 17543,
		// Token: 0x04001C3B RID: 7227
		FishingTeleportToBoatResponse = 16996,
		// Token: 0x04001C3C RID: 7228
		TowerDefenceRandListResponse = 17275,
		// Token: 0x04001C3D RID: 7229
		TowerDefenceRankShowNameResponse = 21093,
		// Token: 0x04001C3E RID: 7230
		BabelTowerTaskRewardResponse = 21846,
		// Token: 0x04001C3F RID: 7231
		BabelTowerDailyTaskRewardResponse = 20492,
		// Token: 0x04001C40 RID: 7232
		ResetBabelTowerLevelResponse = 22385,
		// Token: 0x04001C41 RID: 7233
		BabelTowerSettlementResponse = 24625,
		// Token: 0x04001C42 RID: 7234
		RogueWeeklyBlackFlowerResponse = 29161,
		// Token: 0x04001C43 RID: 7235
		SceneSubLevelsResponse = 27152,
		// Token: 0x04001C44 RID: 7236
		PlayerTitleResponse = 18669,
		// Token: 0x04001C45 RID: 7237
		ChangePlayerTitleResponse = 21696,
		// Token: 0x04001C46 RID: 7238
		AwakeItemVehicleResponse = 15101,
		// Token: 0x04001C47 RID: 7239
		SelectBabelActivityDeTermResponse = 21621,
		// Token: 0x04001C48 RID: 7240
		GravityFlipInteractResponse = 24474,
		// Token: 0x04001C49 RID: 7241
		AbyssChallengeUnlockResponse = 20260,
		// Token: 0x04001C4A RID: 7242
		AbyssChallengeQuitResponse = 15723,
		// Token: 0x04001C4B RID: 7243
		AbyssLikeResponse = 17535,
		// Token: 0x04001C4C RID: 7244
		AbyssChallengeGotoNextRoomResponse = 22250,
		// Token: 0x04001C4D RID: 7245
		AbyssRewardResponse = 15163,
		// Token: 0x04001C4E RID: 7246
		AbyssLittleRoleLevelUpResponse = 15774,
		// Token: 0x04001C4F RID: 7247
		AbyssPluginPutResponse = 27879,
		// Token: 0x04001C50 RID: 7248
		AbyssPluginSynthesisResponse = 19445,
		// Token: 0x04001C51 RID: 7249
		AbyssRankListResponse = 21709,
		// Token: 0x04001C52 RID: 7250
		AbyssShowNameResponse = 16143,
		// Token: 0x04001C53 RID: 7251
		AbyssReviveCharacterResponse = 23705,
		// Token: 0x04001C54 RID: 7252
		SceneItemMoveSplineResponse = 29851,
		// Token: 0x04001C55 RID: 7253
		RacingBetsLegMatchInfoResponse = 18082,
		// Token: 0x04001C56 RID: 7254
		RacingBetsMatchInfoResponse = 15383,
		// Token: 0x04001C57 RID: 7255
		RacingBetsPlayerInfoResponse = 28603,
		// Token: 0x04001C58 RID: 7256
		RacingBetsRankResponse = 28404,
		// Token: 0x04001C59 RID: 7257
		RacingBetsGearResponse = 26722,
		// Token: 0x04001C5A RID: 7258
		RacingBetsTaskResponse = 22403,
		// Token: 0x04001C5B RID: 7259
		RacingBetMatchRoundResponse = 29752,
		// Token: 0x04001C5C RID: 7260
		RacingBetsBulletScreenResponse = 26542,
		// Token: 0x04001C5D RID: 7261
		RacingBetsTaskRewardResponse = 18798,
		// Token: 0x04001C5E RID: 7262
		RogueWeeklyLastInfoResponse = 15761,
		// Token: 0x04001C5F RID: 7263
		RacingBetsUpdateOddsResponse = 16685,
		// Token: 0x04001C60 RID: 7264
		ExploreActivityTaskRewardResponse = 25543,
		// Token: 0x04001C61 RID: 7265
		PhantomPolishResponse = 16484,
		// Token: 0x04001C62 RID: 7266
		TowerDefenceSelfPassResponse = 25970,
		// Token: 0x04001C63 RID: 7267
		AbyssSelfPassResponse = 22042,
		// Token: 0x04001C64 RID: 7268
		RogueResTalentSkillLevelResponse = 15225,
		// Token: 0x04001C65 RID: 7269
		RogueResEndingRewardResponse = 24880,
		// Token: 0x04001C66 RID: 7270
		RogueResTaskAwardResponse = 24954,
		// Token: 0x04001C67 RID: 7271
		RogueResIllustrationAwardResponse = 23918,
		// Token: 0x04001C68 RID: 7272
		AvignonRewardResponse = 29765,
		// Token: 0x04001C69 RID: 7273
		RogueResMoveResponse = 27678,
		// Token: 0x04001C6A RID: 7274
		RogueResGridEventResponse = 25023,
		// Token: 0x04001C6B RID: 7275
		RogueResOpDoneResponse = 20903,
		// Token: 0x04001C6C RID: 7276
		RogueResInstStartResponse = 15616,
		// Token: 0x04001C6D RID: 7277
		RogueResLastInstInfoResponse = 29600,
		// Token: 0x04001C6E RID: 7278
		RacingBetsGearRefundResponse = 16117,
		// Token: 0x04001C6F RID: 7279
		SummonRandomResponse = 19533,
		// Token: 0x04001C70 RID: 7280
		RogueResInstResultResponse = 21394,
		// Token: 0x04001C71 RID: 7281
		StopMoveSplineResponse = 19432,
		// Token: 0x04001C72 RID: 7282
		FlySkinWearResponse = 17717,
		// Token: 0x04001C73 RID: 7283
		FlySkinWearAllRoleResponse = 25354,
		// Token: 0x04001C74 RID: 7284
		RogueResGotoNextRoomResponse = 25469,
		// Token: 0x04001C75 RID: 7285
		FlySkinUnLoadResponse = 23595,
		// Token: 0x04001C76 RID: 7286
		DangoMonopolyDiceResponse = 29407,
		// Token: 0x04001C77 RID: 7287
		DangoMonopolyGridRewardResponse = 16416,
		// Token: 0x04001C78 RID: 7288
		DangoMonopolyBoardRewardResponse = 19522,
		// Token: 0x04001C79 RID: 7289
		DangoMonopolyTaskRewardResponse = 27164,
		// Token: 0x04001C7A RID: 7290
		RacingBetMatchResponse = 29502,
		// Token: 0x04001C7B RID: 7291
		LoadingLevelAreaResponse = 19391,
		// Token: 0x04001C7C RID: 7292
		DangoMonopolyNextBoardResponse = 16590,
		// Token: 0x04001C7D RID: 7293
		AddChapterResultResponse = 27547,
		// Token: 0x04001C7E RID: 7294
		ChapterResultRewardResponse = 28736,
		// Token: 0x04001C7F RID: 7295
		InspirationUnlockChoiceResponse = 24295,
		// Token: 0x04001C80 RID: 7296
		ActivityResultRewardResponse = 28339,
		// Token: 0x04001C81 RID: 7297
		ScheduleRewardResponse = 26326,
		// Token: 0x04001C82 RID: 7298
		FlySkinAllUnLoadResponse = 16998,
		// Token: 0x04001C83 RID: 7299
		RogueResChangeFormationResponse = 18969,
		// Token: 0x04001C84 RID: 7300
		RegressBonusResponse = 16360,
		// Token: 0x04001C85 RID: 7301
		RegressTaskResponse = 24403,
		// Token: 0x04001C86 RID: 7302
		ConfirmQuestResourceResponse = 26295,
		// Token: 0x04001C87 RID: 7303
		ConsumptiveRewardResponse = 23419,
		// Token: 0x04001C88 RID: 7304
		LinkageRewardResponse = 25500,
		// Token: 0x04001C89 RID: 7305
		RacingBetMatchActionResponse = 25269,
		// Token: 0x04001C8A RID: 7306
		RacingBetMatchRoundActionResponse = 15882,
		// Token: 0x04001C8B RID: 7307
		RogueResSwitchFormationResponse = 19117,
		// Token: 0x04001C8C RID: 7308
		RacingBetMatchInfoResponse = 22985,
		// Token: 0x04001C8D RID: 7309
		PhantomBattleTaskRewardResponse = 20933,
		// Token: 0x04001C8E RID: 7310
		PhantomBattleMasterLevelRewardResponse = 26202,
		// Token: 0x04001C8F RID: 7311
		PhantomBattleBadgeRewardResponse = 28194,
		// Token: 0x04001C90 RID: 7312
		PhantomBattleCardOutLookUpResponse = 15581,
		// Token: 0x04001C91 RID: 7313
		PhantomBattleCardRewardResponse = 20785,
		// Token: 0x04001C92 RID: 7314
		PhantomBattleRoleRewardResponse = 21447,
		// Token: 0x04001C93 RID: 7315
		PhantomBattleCardGroupAddResponse = 17478,
		// Token: 0x04001C94 RID: 7316
		PhantomBattleCardGroupUpdateResponse = 26320,
		// Token: 0x04001C95 RID: 7317
		PhantomBattleCardGroupNameResponse = 26266,
		// Token: 0x04001C96 RID: 7318
		PhantomBattleDealCardReplaceResponse = 23721,
		// Token: 0x04001C97 RID: 7319
		PhantomBattleEnterSlotResponse = 15195,
		// Token: 0x04001C98 RID: 7320
		PhantomBattleEvolveResponse = 26438,
		// Token: 0x04001C99 RID: 7321
		PhantomBattleBackLibraryResponse = 29876,
		// Token: 0x04001C9A RID: 7322
		PhantomBattleRoundOverResponse = 25961,
		// Token: 0x04001C9B RID: 7323
		PhantomBattleSlotInsteadResponse = 27889,
		// Token: 0x04001C9C RID: 7324
		BirthDayCardRoleResponse = 16190,
		// Token: 0x04001C9D RID: 7325
		BirthDayRewardResponse = 21898,
		// Token: 0x04001C9E RID: 7326
		DirectTrainInfoResponse = 28515,
		// Token: 0x04001C9F RID: 7327
		RegressQuestionOpenResponse = 19944,
		// Token: 0x04001CA0 RID: 7328
		PhantomBattleLeaveSlotResponse = 25036,
		// Token: 0x04001CA1 RID: 7329
		PhantomBattleSelectTargetResponse = 25311,
		// Token: 0x04001CA2 RID: 7330
		ConsumptiveActivityInfoResponse = 24847,
		// Token: 0x04001CA3 RID: 7331
		PhantomBattleCardRoleSkillResponse = 23783,
		// Token: 0x04001CA4 RID: 7332
		PhantomBattleCardSkillResponse = 19901,
		// Token: 0x04001CA5 RID: 7333
		SetQuestFocusModeResponse = 21189,
		// Token: 0x04001CA6 RID: 7334
		CancelQuestFocusModeResponse = 29321,
		// Token: 0x04001CA7 RID: 7335
		PhantomBattleNpcShowOverResponse = 17530,
		// Token: 0x04001CA8 RID: 7336
		PhantomBattleBvBLoadingFinishResponse = 24562,
		// Token: 0x04001CA9 RID: 7337
		PhantomBattleStartResponse = 24441,
		// Token: 0x04001CAA RID: 7338
		AcceptFocusWaitQuestResponse = 17260,
		// Token: 0x04001CAB RID: 7339
		PhantomBattleDiscardCardResponse = 17740,
		// Token: 0x04001CAC RID: 7340
		NavigationFindPathResponse = 25627,
		// Token: 0x04001CAD RID: 7341
		PhantomBattleCardGroupDeleteResponse = 29932,
		// Token: 0x04001CAE RID: 7342
		QuestReviewInfoResponse = 16788,
		// Token: 0x04001CAF RID: 7343
		NewbieCarnivalSwitchRoleResponse = 18412,
		// Token: 0x04001CB0 RID: 7344
		NewbieCarnivalAwardResponse = 25525,
		// Token: 0x04001CB1 RID: 7345
		PhantomBattleCardSelectResponse = 24389,
		// Token: 0x04001CB2 RID: 7346
		PhantomBattleCardTargetInfoResponse = 20438,
		// Token: 0x04001CB3 RID: 7347
		PhantomBattleCardRoleTargetInfoResponse = 27282,
		// Token: 0x04001CB4 RID: 7348
		PhantomBattleCardUnlockResponse = 16683,
		// Token: 0x04001CB5 RID: 7349
		OccupyRewardResponse = 22814,
		// Token: 0x04001CB6 RID: 7350
		SetQuestResourceStateResponse = 25299,
		// Token: 0x04001CB7 RID: 7351
		LongShanScoreRewardResponse = 26718,
		// Token: 0x04001CB8 RID: 7352
		BathChangeCameraResponse = 24262,
		// Token: 0x04001CB9 RID: 7353
		BathPhotoResponse = 16457,
		// Token: 0x04001CBA RID: 7354
		FinishDownloadQuestResourceResponse = 24046,
		// Token: 0x04001CBB RID: 7355
		PhantomBattleBackSlotCardLibraryResponse = 22253,
		// Token: 0x04001CBC RID: 7356
		FloroRanchUnlockTechPointResponse = 23616,
		// Token: 0x04001CBD RID: 7357
		FloroRanchRewardTaskResponse = 28020,
		// Token: 0x04001CBE RID: 7358
		FloroRanchRewardMilestoneResponse = 27049,
		// Token: 0x04001CBF RID: 7359
		FloroRanchStartPlayResponse = 26272,
		// Token: 0x04001CC0 RID: 7360
		FloroRanchSettleResponse = 25335,
		// Token: 0x04001CC1 RID: 7361
		FloroRanchPlayNextDayResponse = 19866,
		// Token: 0x04001CC2 RID: 7362
		FloroRanchPlayGachaResponse = 26482,
		// Token: 0x04001CC3 RID: 7363
		FloroRanchPlayShopBuyResponse = 21023,
		// Token: 0x04001CC4 RID: 7364
		FloroRanchPlayEventChoiceResponse = 19545,
		// Token: 0x04001CC5 RID: 7365
		FloroRanchPlayTributeResponse = 19879,
		// Token: 0x04001CC6 RID: 7366
		FloroRanchPlayUnlimitedModeResponse = 22265,
		// Token: 0x04001CC7 RID: 7367
		KcpConvResponse = 3729,
		// Token: 0x04001CC8 RID: 7368
		ActionOperationScreenSuccessResponse = 17481,
		// Token: 0x04001CC9 RID: 7369
		PhantomBattleSelectReserveCardResponse = 18367,
		// Token: 0x04001CCA RID: 7370
		FloroRanchPlayRemoveUnitResponse = 27510,
		// Token: 0x04001CCB RID: 7371
		PhantomBattleSlotCardSkillResponse = 26443,
		// Token: 0x04001CCC RID: 7372
		ConstructTrapResponse = 28302,
		// Token: 0x04001CCD RID: 7373
		DeconstructTrapResponse = 17614,
		// Token: 0x04001CCE RID: 7374
		PhantomBattleReChallengeResponse = 25507,
		// Token: 0x04001CCF RID: 7375
		FloroRanchPlayRefreshShopResponse = 18811,
		// Token: 0x04001CD0 RID: 7376
		FloroRanchPlayRefreshGachaResponse = 27548,
		// Token: 0x04001CD1 RID: 7377
		PhantomBattleDebugInfoResponse = 20930,
		// Token: 0x04001CD2 RID: 7378
		MoralePosResponse = 16263,
		// Token: 0x04001CD3 RID: 7379
		RunTestResponse = 21458,
		// Token: 0x04001CD4 RID: 7380
		PhantomSettingResponse = 29364,
		// Token: 0x04001CD5 RID: 7381
		PhantomSettingUpdateResponse = 20909,
		// Token: 0x04001CD6 RID: 7382
		PhantomBatchOperResponse = 18810,
		// Token: 0x04001CD7 RID: 7383
		VehiclePlatformGetOnResponse = 28415,
		// Token: 0x04001CD8 RID: 7384
		PolluteGridCellResponse = 29018,
		// Token: 0x04001CD9 RID: 7385
		LifePointChallengeStartResponse = 29239,
		// Token: 0x04001CDA RID: 7386
		FloroRanchPlaySelectCardGroupResponse = 24077,
		// Token: 0x04001CDB RID: 7387
		SimpleCombatEntityDieResponse = 28019,
		// Token: 0x04001CDC RID: 7388
		MoraleTreasureBoxTraceResponse = 20050,
		// Token: 0x04001CDD RID: 7389
		MulAchievementReceiveResponse = 29250,
		// Token: 0x04001CDE RID: 7390
		MulRoguelikeWriteCatRewardResponse = 20956,
		// Token: 0x04001CDF RID: 7391
		MulRogueWeeklyRewardResponse = 23258,
		// Token: 0x04001CE0 RID: 7392
		MulPhantomBattleMasterLevelRewardResponse = 21948,
		// Token: 0x04001CE1 RID: 7393
		MulGetAdventureRewardResponse = 15647,
		// Token: 0x04001CE2 RID: 7394
		MulCalabashLevelRewardResponse = 17924,
		// Token: 0x04001CE3 RID: 7395
		MulExploreScoreRewardResponse = 15959,
		// Token: 0x04001CE4 RID: 7396
		MulFishingIllustratedRewardResponse = 29037,
		// Token: 0x04001CE5 RID: 7397
		MulMapTravelTaskRewardResponse = 22477,
		// Token: 0x04001CE6 RID: 7398
		FloroRanchPlayGachaRefreshResponse = 22802,
		// Token: 0x04001CE7 RID: 7399
		FloroRanchExecuteSkillPlayResponse = 26537,
		// Token: 0x04001CE8 RID: 7400
		HoldHandResponse = 26804,
		// Token: 0x04001CE9 RID: 7401
		TrapDefensePreviewFinishResponse = 26110,
		// Token: 0x04001CEA RID: 7402
		FloroRanchSettleDataResponse = 21024,
		// Token: 0x04001CEB RID: 7403
		SetFocusModeDeterCondResponse = 22252,
		// Token: 0x04001CEC RID: 7404
		LowMemoryChangeSceneFinishResponse = 15315,
		// Token: 0x04001CED RID: 7405
		RogueWeeklyArtifactInfoResponse = 15940,
		// Token: 0x04001CEE RID: 7406
		RogueWeeklyArtifactSelectResponse = 16473,
		// Token: 0x04001CEF RID: 7407
		TrapDefenseRefreshGainingGroupResponse = 19444,
		// Token: 0x04001CF0 RID: 7408
		TrapDefenseSelectGainingGroupResponse = 20864,
		// Token: 0x04001CF1 RID: 7409
		TrapDefenseTechUnlockResponse = 24341,
		// Token: 0x04001CF2 RID: 7410
		TrapDefenseGetRewardResponse = 22279,
		// Token: 0x04001CF3 RID: 7411
		TrapDefenseGetSpecialRewardResponse = 19710,
		// Token: 0x04001CF4 RID: 7412
		TrapDefenseBuildingLevelUpResponse = 28185,
		// Token: 0x04001CF5 RID: 7413
		TrapDefenseBuildingBranchResponse = 17534,
		// Token: 0x04001CF6 RID: 7414
		TrapDefenseAuxiliaryLevelUpResponse = 18673,
		// Token: 0x04001CF7 RID: 7415
		TrapDefenseAuxiliaryBranchResponse = 24209,
		// Token: 0x04001CF8 RID: 7416
		FunPlayChallengeAwardResponse = 15240,
		// Token: 0x04001CF9 RID: 7417
		LevelPlayOpenResponse = 15023,
		// Token: 0x04001CFA RID: 7418
		TrapDefenseChallengeQuitResponse = 24998,
		// Token: 0x04001CFB RID: 7419
		TrapDefenseBuildingResetResponse = 18053,
		// Token: 0x04001CFC RID: 7420
		TrapDefenseAuxiliaryResetResponse = 26880,
		// Token: 0x04001CFD RID: 7421
		TrapDefenseDevelopResetResponse = 17328,
		// Token: 0x04001CFE RID: 7422
		ExploreEntityTraceResponse = 26058,
		// Token: 0x04001CFF RID: 7423
		CommonTouchUiSettingUpdateResponse = 21615,
		// Token: 0x04001D00 RID: 7424
		TrapDefenseSlotUpdateResponse = 18521,
		// Token: 0x04001D01 RID: 7425
		SceneItemSequenceFrameStartResponse = 22907,
		// Token: 0x04001D02 RID: 7426
		SceneItemSequenceFrameEndResponse = 20290,
		// Token: 0x04001D03 RID: 7427
		MulMapTravelSoarRewardResponse = 28256,
		// Token: 0x04001D04 RID: 7428
		PhantomSettingBatchUpdateResponse = 25796,
		// Token: 0x04001D05 RID: 7429
		FloroRanchFirstEnterResponse = 21638,
		// Token: 0x04001D06 RID: 7430
		FloroRanchAnimationResponse = 18911,
		// Token: 0x04001D07 RID: 7431
		BlackSwordChallengeInfoResponse = 15067,
		// Token: 0x04001D08 RID: 7432
		RoleOperateSelfBgmResponse = 26577,
		// Token: 0x04001D09 RID: 7433
		TrapDefenseRefreshShopResponse = 27769,
		// Token: 0x04001D0A RID: 7434
		TrapDefenseBuyShopProductResponse = 18945,
		// Token: 0x04001D0B RID: 7435
		MoonPhaseRandomResponse = 27423,
		// Token: 0x04001D0C RID: 7436
		MoonPhaseRewardResponse = 20673,
		// Token: 0x04001D0D RID: 7437
		TrapDefenseUseItemResponse = 27014,
		// Token: 0x04001D0E RID: 7438
		LineCrossChallengeStartResponse = 19877,
		// Token: 0x04001D0F RID: 7439
		RoleIllustratedInfoResponse = 16765,
		// Token: 0x04001D10 RID: 7440
		TrapDefenseCurChallengeInfoResponse = 27808,
		// Token: 0x04001D11 RID: 7441
		RoleDevelopConfigResponse = 15651,
		// Token: 0x04001D12 RID: 7442
		PhotoFightTaskRewardResponse = 22692,
		// Token: 0x04001D13 RID: 7443
		PhotoFightSettleResponse = 20695,
		// Token: 0x04001D14 RID: 7444
		TrapDefenseQuickEquipResponse = 21470,
		// Token: 0x04001D15 RID: 7445
		FloroRanchCloseTaskResponse = 22776,
		// Token: 0x04001D16 RID: 7446
		CalabashSkinTakeOnResponse = 29991,
		// Token: 0x04001D17 RID: 7447
		WuWuKujiGachaResponse = 15175,
		// Token: 0x04001D18 RID: 7448
		SurvivorsOpDoneResponse = 22698,
		// Token: 0x04001D19 RID: 7449
		SurvivorsLockResponse = 25907,
		// Token: 0x04001D1A RID: 7450
		QuestTreeInfoResponse = 15806,
		// Token: 0x04001D1B RID: 7451
		LoadCalabashSkinInfoResponse = 17073,
		// Token: 0x04001D1C RID: 7452
		SetPlayerYuXueModeResponse = 15847,
		// Token: 0x04001D1D RID: 7453
		SetBtObjYuXueModeResponse = 27148,
		// Token: 0x04001D1E RID: 7454
		GetYuXueModeInfoResponse = 16446,
		// Token: 0x04001D1F RID: 7455
		SurvivorsResultResponse = 15576,
		// Token: 0x04001D20 RID: 7456
		SurvivorsStepAdvanceResponse = 18453,
		// Token: 0x04001D21 RID: 7457
		WeatherControlResponse = 27673,
		// Token: 0x04001D22 RID: 7458
		SurvivorsWeaponInfoResponse = 18985,
		// Token: 0x04001D23 RID: 7459
		SurvivorsNormalAwardResponse = 21229,
		// Token: 0x04001D24 RID: 7460
		SurvivorsScoreAwardResponse = 18111,
		// Token: 0x04001D25 RID: 7461
		SurvivorsTalentLevelUpResponse = 23041,
		// Token: 0x04001D26 RID: 7462
		BatchSynthesisItemResponse = 20888,
		// Token: 0x04001D27 RID: 7463
		SurvivorsLastInfoResponse = 15138,
		// Token: 0x04001D28 RID: 7464
		RoleUpdateDevelopTargetResponse = 19264,
		// Token: 0x04001D29 RID: 7465
		MainPhantomRecommendResponse = 17594,
		// Token: 0x04001D2A RID: 7466
		InfrInfoResponse = 24251,
		// Token: 0x04001D2B RID: 7467
		InfrArchiveTaskRewardResponse = 20584,
		// Token: 0x04001D2C RID: 7468
		InfrManualSwitchTraceRoadResponse = 22149,
		// Token: 0x04001D2D RID: 7469
		InfrFireNoticeResponse = 23545,
		// Token: 0x04001D2E RID: 7470
		InfrLevelUpResponse = 23326,
		// Token: 0x04001D2F RID: 7471
		InfrRoadBuildResponse = 22831,
		// Token: 0x04001D30 RID: 7472
		BlackSwordChallengeMarkItemPanelInfoResponse = 20814,
		// Token: 0x04001D31 RID: 7473
		HonamiStoryBagOperateResponse = 21239,
		// Token: 0x04001D32 RID: 7474
		HonamiStoryEquipRoleResponse = 28938,
		// Token: 0x04001D33 RID: 7475
		HonamiStoryUnlockSlotResponse = 27913,
		// Token: 0x04001D34 RID: 7476
		HonamiStoryWeaponDressResponse = 29480,
		// Token: 0x04001D35 RID: 7477
		HonamiStorySellItemResponse = 18536,
		// Token: 0x04001D36 RID: 7478
		HonamiStoryLifeSupportUpResponse = 22538,
		// Token: 0x04001D37 RID: 7479
		HonamiStoryActivateTalentResponse = 28751,
		// Token: 0x04001D38 RID: 7480
		HonamiStoryItemCollectionResponse = 16494,
		// Token: 0x04001D39 RID: 7481
		HonamiStoryMascotRewardResponse = 25929,
		// Token: 0x04001D3A RID: 7482
		HonamiStoryAreaSecretRewardResponse = 26290,
		// Token: 0x04001D3B RID: 7483
		HonamiStoryLimitTaskRewardResponse = 27065,
		// Token: 0x04001D3C RID: 7484
		HonamiStoryScoreRewardResponse = 26582,
		// Token: 0x04001D3D RID: 7485
		HonamiStoryPickUpItemResponse = 27375,
		// Token: 0x04001D3E RID: 7486
		HonamiStoryDiscardItemResponse = 24394,
		// Token: 0x04001D3F RID: 7487
		HonamiStoryInstLeaveResponse = 16258,
		// Token: 0x04001D40 RID: 7488
		GetTraceQuestYuXueModeResponse = 17059,
		// Token: 0x04001D41 RID: 7489
		RollBlockResetGamePlayResponse = 29620,
		// Token: 0x04001D42 RID: 7490
		HonamiStoryLockItemResponse = 22131,
		// Token: 0x04001D43 RID: 7491
		RollBlockMovementFinishResponse = 22850,
		// Token: 0x04001D44 RID: 7492
		MulCorniceMeetingRewardResponse = 16872,
		// Token: 0x04001D45 RID: 7493
		RollBlockInputResponse = 29397,
		// Token: 0x04001D46 RID: 7494
		MotorTechLevelUpResponse = 27374,
		// Token: 0x04001D47 RID: 7495
		WeatherControlInfoResponse = 15945,
		// Token: 0x04001D48 RID: 7496
		ButtonIsEnableResponse = 19953,
		// Token: 0x04001D49 RID: 7497
		MotorLevelOneKeyRewardResponse = 26315,
		// Token: 0x04001D4A RID: 7498
		MotorInfoResponse = 27754,
		// Token: 0x04001D4B RID: 7499
		MotorTaskOneKeyRewardResponse = 26287,
		// Token: 0x04001D4C RID: 7500
		PhantomInteractionEquipResponse = 25626,
		// Token: 0x04001D4D RID: 7501
		PhantomInteractionSkinChangeResponse = 20674,
		// Token: 0x04001D4E RID: 7502
		MotorTechTreeSwitchResponse = 29362,
		// Token: 0x04001D4F RID: 7503
		AreaTerminalPinOperationResponse = 21372,
		// Token: 0x04001D50 RID: 7504
		GetDetectionTargetResponse = 19055,
		// Token: 0x04001D51 RID: 7505
		InfrThemeActivityAwardResponse = 26171,
		// Token: 0x04001D52 RID: 7506
		MotorSliderResponse = 17663,
		// Token: 0x04001D53 RID: 7507
		BossRushBatchClaimRewardResponse = 23711,
		// Token: 0x04001D54 RID: 7508
		PhantomBattleAreaSkillResponse = 18122,
		// Token: 0x04001D55 RID: 7509
		PhantomBattlePhantomCardSkillResponse = 25369,
		// Token: 0x04001D56 RID: 7510
		ArtemisNodeUpdateResponse = 26895,
		// Token: 0x04001D57 RID: 7511
		AddDecalResponse = 29445,
		// Token: 0x04001D58 RID: 7512
		CoopRoleRewardResponse = 17866,
		// Token: 0x04001D59 RID: 7513
		CoopSpRewardResponse = 16957,
		// Token: 0x04001D5A RID: 7514
		HonamiStoryResidentTaskRewardResponse = 19821,
		// Token: 0x04001D5B RID: 7515
		RollBlockExitGamePlayResponse = 19646,
		// Token: 0x04001D5C RID: 7516
		RollBlockToggleHintResponse = 25640,
		// Token: 0x04001D5D RID: 7517
		MotorChangeOutlookResponse = 21672,
		// Token: 0x04001D5E RID: 7518
		VehicleEnterSharingResponse = 29612,
		// Token: 0x04001D5F RID: 7519
		RollBlockSwitchControlBlockResponse = 28564,
		// Token: 0x04001D60 RID: 7520
		MotorLinkTaskResponse = 20877,
		// Token: 0x04001D61 RID: 7521
		InstEntityTeleportResponse = 28666,
		// Token: 0x04001D62 RID: 7522
		DeadeyeShootHitResponse = 23822,
		// Token: 0x04001D63 RID: 7523
		MotorUseSkinResponse = 18288,
		// Token: 0x04001D64 RID: 7524
		PhantomBattleCallCardResponse = 19169,
		// Token: 0x04001D65 RID: 7525
		ShortMessageInfoResponse = 23875,
		// Token: 0x04001D66 RID: 7526
		ShortMessageReadResponse = 21455,
		// Token: 0x04001D67 RID: 7527
		ShortMessageReplyResponse = 20362,
		// Token: 0x04001D68 RID: 7528
		ShortMessageReceivedResponse = 18956,
		// Token: 0x04001D69 RID: 7529
		InfrPhoneTaskRewardResponse = 23125,
		// Token: 0x04001D6A RID: 7530
		ShortMessageUpdateResponse = 17070,
		// Token: 0x04001D6B RID: 7531
		BeamCastHitPlayerResponse = 18932,
		// Token: 0x04001D6C RID: 7532
		CaptureBatchEntityResponse = 18685,
		// Token: 0x04001D6D RID: 7533
		RoadBookFullRewardResponse = 25470,
		// Token: 0x04001D6E RID: 7534
		RoadBookLevelUpResponse = 16518,
		// Token: 0x04001D6F RID: 7535
		RoadBookTaskRewardResponse = 27039,
		// Token: 0x04001D70 RID: 7536
		RoadBookMotorRewardResponse = 15914,
		// Token: 0x04001D71 RID: 7537
		MotorParkourLevelRewardResponse = 19468,
		// Token: 0x04001D72 RID: 7538
		PhantomBatchPolishResponse = 26035,
		// Token: 0x04001D73 RID: 7539
		PhantomBattleCheckCardSkillUnlockResponse = 18934,
		// Token: 0x04001D74 RID: 7540
		PhantomVicePolishResponse = 27294,
		// Token: 0x04001D75 RID: 7541
		PhantomVicePolishAckResponse = 22926,
		// Token: 0x04001D76 RID: 7542
		FurnitureDiySaveResponse = 27663,
		// Token: 0x04001D77 RID: 7543
		InfrManualCancelTraceRoadResponse = 21107,
		// Token: 0x04001D78 RID: 7544
		SkinRewardResponse = 26041,
		// Token: 0x04001D79 RID: 7545
		InfrArchiveReadResponse = 25225,
		// Token: 0x04001D7A RID: 7546
		AtomicProcessTeleportResponse = 27447,
		// Token: 0x04001D7B RID: 7547
		NewTowerCycleStartResponse = 27252,
		// Token: 0x04001D7C RID: 7548
		NewTowerUpdateRecordResponse = 23318,
		// Token: 0x04001D7D RID: 7549
		NewTowerRewardResponse = 18751,
		// Token: 0x04001D7E RID: 7550
		MotorFightTalentUpResponse = 19118,
		// Token: 0x04001D7F RID: 7551
		MotorFightOneKeyRewardResponse = 26998,
		// Token: 0x04001D80 RID: 7552
		MotorFightRankListResponse = 21992,
		// Token: 0x04001D81 RID: 7553
		PhantomBattleGuideRewardResponse = 23453,
		// Token: 0x04001D82 RID: 7554
		JokerGuessStartNewResponse = 24323,
		// Token: 0x04001D83 RID: 7555
		JokerGuessPlayCardResponse = 15319,
		// Token: 0x04001D84 RID: 7556
		JokerGuessDrawCardResponse = 20858,
		// Token: 0x04001D85 RID: 7557
		JokerGuessUseSkillResponse = 26805,
		// Token: 0x04001D86 RID: 7558
		EncircleChallengeStartResponse = 28360,
		// Token: 0x04001D87 RID: 7559
		EncircleChallengeCompleteResponse = 23650,
		// Token: 0x04001D88 RID: 7560
		PhantomMusicCollectUpdateResponse = 29261,
		// Token: 0x04001D89 RID: 7561
		H5CircumFluenceActivityReadResponse = 27658,
		// Token: 0x04001D8A RID: 7562
		HookLockBatchCollectResponse = 19834,
		// Token: 0x04001D8B RID: 7563
		MotorFightSettleResponse = 28563,
		// Token: 0x04001D8C RID: 7564
		MotorFightLastSaveDataResponse = 24235,
		// Token: 0x04001D8D RID: 7565
		PhantomBattleRepeatedTaskRewardResponse = 29535,
		// Token: 0x04001D8E RID: 7566
		NewTowerRoleEnergyResponse = 20585,
		// Token: 0x04001D8F RID: 7567
		HonamiStoryActivityInfoResponse = 24610,
		// Token: 0x04001D90 RID: 7568
		PhantomBatchDirectRefiningResponse = 29320,
		// Token: 0x04001D91 RID: 7569
		PilotThrowOperationResponse = 18656,
		// Token: 0x04001D92 RID: 7570
		ShortMessageShowChangeResponse = 29072,
		// Token: 0x04001D93 RID: 7571
		NewPlayerSupportRewardTaskResponse = 15261,
		// Token: 0x04001D94 RID: 7572
		NewPlayerSupportTrialRoleLvUpResponse = 24698,
		// Token: 0x04001D95 RID: 7573
		PhantomBattleReconstructCardResponse = 18514,
		// Token: 0x04001D96 RID: 7574
		RegressDisposableRewardResponse = 20754,
		// Token: 0x04001D97 RID: 7575
		ExploreSkillActionResponse = 16000,
		// Token: 0x04001D98 RID: 7576
		InstTeleportToResetPointResponse = 20995,
		// Token: 0x04001D99 RID: 7577
		NewTowerClearRecordResponse = 27464,
		// Token: 0x04001D9A RID: 7578
		GetLevelPlayRewardsResponse = 20173,
		// Token: 0x04001D9B RID: 7579
		MotorOutlookInfoResponse = 15636,
		// Token: 0x04001D9C RID: 7580
		Summon3Response = 29484,
		// Token: 0x04001D9D RID: 7581
		RegressTrialRoleLvUpResponse = 18298,
		// Token: 0x04001D9E RID: 7582
		GravityHookLockPointChangeGravityResponse = 15803,
		// Token: 0x04001D9F RID: 7583
		TotalTopUpScoreInfoResponse = 21941,
		// Token: 0x04001DA0 RID: 7584
		TotalTopUpRewardResponse = 24834,
		// Token: 0x04001DA1 RID: 7585
		NewPlayerSupportSetCurUseTrialRoleResponse = 22287,
		// Token: 0x04001DA2 RID: 7586
		MotorFightEnterSubLevelResponse = 20665,
		// Token: 0x04001DA3 RID: 7587
		MotorFightKillResponse = 25235,
		// Token: 0x04001DA4 RID: 7588
		AtomicProcessAddBuffResponse = 19678,
		// Token: 0x04001DA5 RID: 7589
		BrochureRewardResponse = 22272,
		// Token: 0x04001DA6 RID: 7590
		WeekCardInfoResponse = 19836,
		// Token: 0x04001DA7 RID: 7591
		WeekCardRewardResponse = 21630,
		// Token: 0x04001DA8 RID: 7592
		SeamlessTeleportVehicleResponse = 29328,
		// Token: 0x04001DA9 RID: 7593
		RegressRepeatedTaskResponse = 26458,
		// Token: 0x04001DAA RID: 7594
		MotorCreateResponse = 27756,
		// Token: 0x04001DAB RID: 7595
		RegressBuyBonusLvResponse = 28709,
		// Token: 0x04001DAC RID: 7596
		RegressSetCurUseTrialRoleResponse = 28925,
		// Token: 0x04001DAD RID: 7597
		H5ViewActivityReadResponse = 19853,
		// Token: 0x04001DAE RID: 7598
		RoleSkillBranchModifyResponse = 17930,
		// Token: 0x04001DAF RID: 7599
		MixDrinkSettleResponse = 27018,
		// Token: 0x04001DB0 RID: 7600
		MixDrinkTopicSelectResponse = 22606,
		// Token: 0x04001DB1 RID: 7601
		MotorFightPlayerDeadResponse = 17964,
		// Token: 0x04001DB2 RID: 7602
		WeatherSwitchInfoResponse = 21840,
		// Token: 0x04001DB3 RID: 7603
		MotorFightRefreshNextWaveGroupResponse = 25991,
		// Token: 0x04001DB4 RID: 7604
		RollBlockGamePlayReadyResponse = 19471,
		// Token: 0x04001DB5 RID: 7605
		MotorFightSelectCollectionResponse = 16600,
		// Token: 0x04001DB6 RID: 7606
		EntityEnterVehicleResponse = 28752,
		// Token: 0x04001DB7 RID: 7607
		FarmGoldLevelPlayRepeatedResponse = 20555,
		// Token: 0x04001DB8 RID: 7608
		MotorFightSelectBuffGateResponse = 20172,
		// Token: 0x04001DB9 RID: 7609
		GivebackInfoResponse = 29313,
		// Token: 0x04001DBA RID: 7610
		GivebackRewardResponse = 26121,
		// Token: 0x04001DBB RID: 7611
		FarmGoldPointRepeatedResponse = 25184,
		// Token: 0x04001DBC RID: 7612
		ActionResetPosPrePerformanceEndResponse = 27855,
		// Token: 0x04001DBD RID: 7613
		MotorFightRefreshCollectionResponse = 29219,
		// Token: 0x04001DBE RID: 7614
		ExhibitionItemSaveResponse = 24838,
		// Token: 0x04001DBF RID: 7615
		SpringFestivalTaskRewardResponse = 24773,
		// Token: 0x04001DC0 RID: 7616
		SpringFestivalScoreRewardResponse = 26022,
		// Token: 0x04001DC1 RID: 7617
		SpringFestivalAtmosphereRewardResponse = 28012,
		// Token: 0x04001DC2 RID: 7618
		EnterBigWorldInstResponse = 16135,
		// Token: 0x04001DC3 RID: 7619
		PhantomMusicSaveResponse = 19149,
		// Token: 0x04001DC4 RID: 7620
		FlagChallengeRewardResponse = 16460,
		// Token: 0x04001DC5 RID: 7621
		MotorDevelopTaskRewardResponse = 28453,
		// Token: 0x04001DC6 RID: 7622
		VehicleFinishResponse = 23136,
		// Token: 0x04001DC7 RID: 7623
		AtomicProcessRemoveBuffResponse = 23095,
		// Token: 0x04001DC8 RID: 7624
		ActivityPayShopBuyResponse = 18847,
		// Token: 0x04001DC9 RID: 7625
		TetrisUpdateResponse = 24555,
		// Token: 0x04001DCA RID: 7626
		NewTrialRoleGetNightmarePhantomInstInfoResponse = 27671,
		// Token: 0x04001DCB RID: 7627
		MixDrinkRoleInviteResponse = 28226,
		// Token: 0x04001DCC RID: 7628
		MotorFightRankListSelfDataResponse = 27580,
		// Token: 0x04001DCD RID: 7629
		PhBaPlanUsePlanResponse = 24680,
		// Token: 0x04001DCE RID: 7630
		PhBaPlanSaveUsePlanResponse = 16798,
		// Token: 0x04001DCF RID: 7631
		PhBaPlanFindPlanResponse = 27942,
		// Token: 0x04001DD0 RID: 7632
		KurotatoChestRewardSelectResponse = 25445,
		// Token: 0x04001DD1 RID: 7633
		KurotatoUpgradeRewardSelectResponse = 21419,
		// Token: 0x04001DD2 RID: 7634
		KurotatoUpgradeRewardRefreshResponse = 15573,
		// Token: 0x04001DD3 RID: 7635
		KurotatoShopRewardSelectResponse = 15517,
		// Token: 0x04001DD4 RID: 7636
		KurotatoShopRewardLockResponse = 16545,
		// Token: 0x04001DD5 RID: 7637
		KurotatoShopRewardRefreshResponse = 22871,
		// Token: 0x04001DD6 RID: 7638
		MixDrinkRoleRewardResponse = 17448,
		// Token: 0x04001DD7 RID: 7639
		JokerGuessRewardResponse = 22205,
		// Token: 0x04001DD8 RID: 7640
		StorageInfoResponse = 20464,
		// Token: 0x04001DD9 RID: 7641
		StorageInfoUpdateResponse = 15571,
		// Token: 0x04001DDA RID: 7642
		FeiXuePreheatInfoRewardResponse = 22363,
		// Token: 0x04001DDB RID: 7643
		RhythmChangePartnerRoleResponse = 15635,
		// Token: 0x04001DDC RID: 7644
		RhythmRankListResponse = 26876,
		// Token: 0x04001DDD RID: 7645
		RhythmRankListSelfDataResponse = 19090,
		// Token: 0x04001DDE RID: 7646
		RhythmSettleResponse = 21204,
		// Token: 0x04001DDF RID: 7647
		RhythmSetRedDotResponse = 27076,
		// Token: 0x04001DE0 RID: 7648
		RhythmTaskOneKeyRewardResponse = 18542,
		// Token: 0x04001DE1 RID: 7649
		DropCatchLevelRewardResponse = 19373,
		// Token: 0x04001DE2 RID: 7650
		DropCatchLevelFinishResponse = 17151,
		// Token: 0x04001DE3 RID: 7651
		SplinePositionUpdateResponse = 29241,
		// Token: 0x04001DE4 RID: 7652
		KurotatoEndShopStepResponse = 27759,
		// Token: 0x04001DE5 RID: 7653
		NewTowerLastCycleInfoResponse = 20840,
		// Token: 0x04001DE6 RID: 7654
		NewTowerSeasonRewardResponse = 28087,
		// Token: 0x04001DE7 RID: 7655
		NewTowerRecommendResponse = 15516,
		// Token: 0x04001DE8 RID: 7656
		ScheduleNpcUpdatePosResponse = 27257,
		// Token: 0x04001DE9 RID: 7657
		KurotatoRefineWeaponResponse = 29507,
		// Token: 0x04001DEA RID: 7658
		PhBaPlanSetPlanStatusResponse = 16878,
		// Token: 0x04001DEB RID: 7659
		PhBaPlanUpdatePlanResponse = 29442,
		// Token: 0x04001DEC RID: 7660
		PhBaPlanSetFiveStarSwitchResponse = 16406,
		// Token: 0x04001DED RID: 7661
		NewTowerSeasonScoreRewardResponse = 15733,
		// Token: 0x04001DEE RID: 7662
		StartRecallResponse = 23357,
		// Token: 0x04001DEF RID: 7663
		ChangeOrnamentResponse = 19523,
		// Token: 0x04001DF0 RID: 7664
		DropCatchInfoResponse = 26922,
		// Token: 0x04001DF1 RID: 7665
		AvoidBlockSubmitOverNodeResponse = 23361,
		// Token: 0x04001DF2 RID: 7666
		KurotatoSellWeaponResponse = 21719,
		// Token: 0x04001DF3 RID: 7667
		TetrisFinishResponse = 27836,
		// Token: 0x04001DF4 RID: 7668
		RacingBetsCloseSettleMenuResponse = 22872,
		// Token: 0x04001DF5 RID: 7669
		PlayerXboxInfoGetResponse = 27026,
		// Token: 0x04001DF6 RID: 7670
		PlayerCreateXboxSessionResponse = 17732,
		// Token: 0x04001DF7 RID: 7671
		PlayerXboxBlockListResponse = 24484,
		// Token: 0x04001DF8 RID: 7672
		XboxSettingUpdateResponse = 25251,
		// Token: 0x04001DF9 RID: 7673
		XboxSettingResponse = 23818,
		// Token: 0x04001DFA RID: 7674
		PinballTeamReviveResponse = 17085,
		// Token: 0x04001DFB RID: 7675
		PinballSetPayloadResponse = 24616,
		// Token: 0x04001DFC RID: 7676
		RoleSkillQuickLevelUpResponse = 18822,
		// Token: 0x04001DFD RID: 7677
		GaSwitchCommonEnemyProCampResponse = 23547,
		// Token: 0x04001DFE RID: 7678
		PinballTeamDieResponse = 24554,
		// Token: 0x04001DFF RID: 7679
		PinballQuitResponse = 17521,
		// Token: 0x04001E00 RID: 7680
		PinballBonusFullWinResponse = 22647,
		// Token: 0x04001E01 RID: 7681
		PinballInGameSyncPayloadResponse = 19461,
		// Token: 0x04001E02 RID: 7682
		PinballTaskRewardResponse = 20552,
		// Token: 0x04001E03 RID: 7683
		PinballRoleLevelUpResponse = 28040,
		// Token: 0x04001E04 RID: 7684
		PinballWeaponDegradeResponse = 16001,
		// Token: 0x04001E05 RID: 7685
		PinballWeaponWearResponse = 25098,
		// Token: 0x04001E06 RID: 7686
		PinballFriendRankResponse = 24014,
		// Token: 0x04001E07 RID: 7687
		InfrV2InfoResponse = 17321,
		// Token: 0x04001E08 RID: 7688
		InfrV2LevelUpResponse = 26991,
		// Token: 0x04001E09 RID: 7689
		InfrV2TreeBuildResponse = 28890,
		// Token: 0x04001E0A RID: 7690
		InfrV2ManualSwitchTraceTreeResponse = 28071,
		// Token: 0x04001E0B RID: 7691
		InfrV2ManualCancelTraceTreeResponse = 28628,
		// Token: 0x04001E0C RID: 7692
		RogueInstExtraInfoResponse = 29662,
		// Token: 0x04001E0D RID: 7693
		InfrV2ScoreRewardResponse = 23928,
		// Token: 0x04001E0E RID: 7694
		InfrV2TaskRewardResponse = 26303,
		// Token: 0x04001E0F RID: 7695
		RhythmMainLineInfoResponse = 25817,
		// Token: 0x04001E10 RID: 7696
		ThemePersonalScoreResponse = 17773,
		// Token: 0x04001E11 RID: 7697
		ThemeWorldScoreResponse = 15587,
		// Token: 0x04001E12 RID: 7698
		WuWuTaskRewardResponse = 29886,
		// Token: 0x04001E13 RID: 7699
		BossPilingRewardResponse = 25013,
		// Token: 0x04001E14 RID: 7700
		PhBaPlanBatchOperResponse = 25404,
		// Token: 0x04001E15 RID: 7701
		MotorOutlookCreatePresetResponse = 17753,
		// Token: 0x04001E16 RID: 7702
		MotorOutlookDeletePresetResponse = 28770,
		// Token: 0x04001E17 RID: 7703
		MotorOutlookEditPresetResponse = 24760,
		// Token: 0x04001E18 RID: 7704
		FlowerPollutionResponse = 26670,
		// Token: 0x04001E19 RID: 7705
		MotorDecalTaskResponse = 26679,
		// Token: 0x04001E1A RID: 7706
		MotorDecalMotorIpResponse = 24987,
		// Token: 0x04001E1B RID: 7707
		BossPilingSettleResponse = 26669,
		// Token: 0x04001E1C RID: 7708
		RacingBetsRepeatedTaskRewardResponse = 15170,
		// Token: 0x04001E1D RID: 7709
		LinkageCheckInRewardResponse = 16096,
		// Token: 0x04001E1E RID: 7710
		GolemCrackUpdateResponse = 16269,
		// Token: 0x04001E1F RID: 7711
		QuestBranchResponse = 24229,
		// Token: 0x04001E20 RID: 7712
		QuestBranchSelectResponse = 16841,
		// Token: 0x04001E21 RID: 7713
		RoleGiftRewardResponse = 20539,
		// Token: 0x04001E22 RID: 7714
		NewTowerSeasonTaskDataUpdateResponse = 17355,
		// Token: 0x04001E23 RID: 7715
		WuWuPackageRewardResponse = 20803,
		// Token: 0x04001E24 RID: 7716
		PinballInGameKickBallResponse = 26970,
		// Token: 0x04001E25 RID: 7717
		GachaAccumulateInfoResponse = 20853,
		// Token: 0x04001E26 RID: 7718
		GachaAccumulateRewardResponse = 19810,
		// Token: 0x04001E27 RID: 7719
		PlayerEnterPollutionResponse = 29461,
		// Token: 0x04001E28 RID: 7720
		QuickHackSkillResponse = 25512,
		// Token: 0x04001E29 RID: 7721
		EdgeRunnerFunctionPreUnlockResponse = 22129,
		// Token: 0x04001E2A RID: 7722
		EdgeRunnerScoreRewardResponse = 27370,
		// Token: 0x04001E2B RID: 7723
		EdgeRunnerTaskRewardResponse = 22840,
		// Token: 0x04001E2C RID: 7724
		KurotatoScoreTaskReceiveResponse = 25285,
		// Token: 0x04001E2D RID: 7725
		KurotatoResTaskReceiveResponse = 26068,
		// Token: 0x04001E2E RID: 7726
		KurotatoLimitTaskReceiveResponse = 18530,
		// Token: 0x04001E2F RID: 7727
		KurotatoRoleRecordResponse = 25139,
		// Token: 0x04001E30 RID: 7728
		WeeklyFrameworkInfoResponse = 19130,
		// Token: 0x04001E31 RID: 7729
		WeeklyFrameworkScoreRewardResponse = 28631,
		// Token: 0x04001E32 RID: 7730
		FloroRanchWeeklyResponse = 15313,
		// Token: 0x04001E33 RID: 7731
		DollGrabResponse = 18423,
		// Token: 0x04001E34 RID: 7732
		DollGrabTimeBallResponse = 24886,
		// Token: 0x04001E35 RID: 7733
		DollGarbStartResponse = 18927,
		// Token: 0x04001E36 RID: 7734
		AvoidBlockClientInitDoneResponse = 24499,
		// Token: 0x04001E37 RID: 7735
		ConsumptiveActivityScoreResponse = 15172,
		// Token: 0x04001E38 RID: 7736
		MonsterPatrolPointReachedResponse = 23552,
		// Token: 0x04001E39 RID: 7737
		ClientPullResourcePackageResponse = 26304,
		// Token: 0x04001E3A RID: 7738
		NewHandInItemResponse = 23562,
		// Token: 0x04001E3B RID: 7739
		DollDeliveryResponse = 22869,
		// Token: 0x04001E3C RID: 7740
		OnlineMotorActivityLevelResponse = 22472,
		// Token: 0x04001E3D RID: 7741
		PlayerVoiceLanguageResponse = 17604,
		// Token: 0x04001E3E RID: 7742
		PlayerRoleVoiceSetResponse = 15331,
		// Token: 0x04001E3F RID: 7743
		FloroRanchEventChoiceResponse = 21742,
		// Token: 0x04001E40 RID: 7744
		KurotatoSettlementResponse = 21645,
		// Token: 0x04001E41 RID: 7745
		RemoteBatchCollectResponse = 24465,
		// Token: 0x04001E42 RID: 7746
		BatchMaterialReplaceResponse = 27844,
		// Token: 0x04001E43 RID: 7747
		NewPlayerSupportSetCurUseTrialRoleV2Response = 28224,
		// Token: 0x04001E44 RID: 7748
		ChangeSummonEntityStateResponse = 21132,
		// Token: 0x04001E45 RID: 7749
		NewPlayerSupportTrialRoleLvUpV2Response = 18194,
		// Token: 0x04001E46 RID: 7750
		RealmBetweenFullRewardResponse = 17101,
		// Token: 0x04001E47 RID: 7751
		RealmBetweenLevelUpResponse = 15881,
		// Token: 0x04001E48 RID: 7752
		RealmBetweenTaskRewardResponse = 27072,
		// Token: 0x04001E49 RID: 7753
		RealmBetweenMotorRewardResponse = 16795,
		// Token: 0x04001E4A RID: 7754
		RogueArchiveListResponse = 21294,
		// Token: 0x04001E4B RID: 7755
		RogueArchiveSaveResponse = 27259,
		// Token: 0x04001E4C RID: 7756
		RogueTowerTrialStartResponse = 24439,
		// Token: 0x04001E4D RID: 7757
		RogueTowerTrialSelectBossResponse = 22338,
		// Token: 0x04001E4E RID: 7758
		RogueTowerTrialReChallengeResponse = 26407,
		// Token: 0x04001E4F RID: 7759
		RogueTowerTrialResultResponse = 15310,
		// Token: 0x04001E50 RID: 7760
		SheriffZoneInfoResponse = 25267,
		// Token: 0x04001E51 RID: 7761
		KurotatoEndSpecialWaveCombatResponse = 15668,
		// Token: 0x04001E52 RID: 7762
		BabelTowerShowNameResponse = 20786,
		// Token: 0x04001E53 RID: 7763
		BabelTowerRankListResponse = 21141,
		// Token: 0x04001E54 RID: 7764
		BabelTowerSelfPassResponse = 21358,
		// Token: 0x04001E55 RID: 7765
		DollGrabStopResponse = 15359,
		// Token: 0x04001E56 RID: 7766
		RogueTowerTrialGiveUpTempArchiveResponse = 29294,
		// Token: 0x04001E57 RID: 7767
		MiniWriteLetterSaveContentResponse = 23170,
		// Token: 0x04001E58 RID: 7768
		SignActivityFreeDropResponse = 27652,
		// Token: 0x04001E59 RID: 7769
		KurotatoReChallengeResponse = 16458,
		// Token: 0x04001E5A RID: 7770
		DollGrabPauseStartResponse = 24478,
		// Token: 0x04001E5B RID: 7771
		DollGrabPauseEndResponse = 29848,
		// Token: 0x04001E5C RID: 7772
		TraceRecallQuestResponse = 27297,
		// Token: 0x04001E5D RID: 7773
		RecallQuestFinishActionResponse = 28795,
		// Token: 0x04001E5E RID: 7774
		RecallQuestActionResponse = 25218,
		// Token: 0x04001E5F RID: 7775
		RecallQuestNpcMoveOverResponse = 18418,
		// Token: 0x04001E60 RID: 7776
		NewbieAdventureTaskRewardResponse = 20663,
		// Token: 0x04001E61 RID: 7777
		NewbieAdventureChapterDropResponse = 20800,
		// Token: 0x04001E62 RID: 7778
		NewbieAdventureRoleRewardResponse = 25004,
		// Token: 0x04001E63 RID: 7779
		NewbieCourseV2RewardResponse = 21399,
		// Token: 0x04001E64 RID: 7780
		NewbieFetchScoreRewardResponse = 22454,
		// Token: 0x04001E65 RID: 7781
		RecallQuestFinishActionEndResponse = 22532,
		// Token: 0x04001E66 RID: 7782
		FloroRanchOutResponse = 21325,
		// Token: 0x04001E67 RID: 7783
		RecallQuestReadyForGiveUpResponse = 19174,
		// Token: 0x04001E68 RID: 7784
		ResonantChainOptionalLimitResponse = 22963,
		// Token: 0x04001E69 RID: 7785
		QueryRecallItemBagResponse = 22846,
		// Token: 0x04001E6A RID: 7786
		SetClientGlobalVarResponse = 22056,
		// Token: 0x04001E6B RID: 7787
		DollGarbInsertCoinResponse = 17171,
		// Token: 0x04001E6C RID: 7788
		RoverRogueQuitResponse = 27155,
		// Token: 0x04001E6D RID: 7789
		RoverRogueResultResponse = 18585,
		// Token: 0x04001E6E RID: 7790
		RoverRogueChooseDataResultResponse = 18760,
		// Token: 0x04001E6F RID: 7791
		RoverRogueRefreshGainResponse = 28469,
		// Token: 0x04001E70 RID: 7792
		RoverRogueGiveUpGainResponse = 20859,
		// Token: 0x04001E71 RID: 7793
		RoverRogueGotoNextRoomCommitResponse = 18455,
		// Token: 0x04001E72 RID: 7794
		RoverRogueInsListResponse = 21420,
		// Token: 0x04001E73 RID: 7795
		RoverRogueTalentInfoResponse = 24083,
		// Token: 0x04001E74 RID: 7796
		RoverRogueTalentUnlockResponse = 22696,
		// Token: 0x04001E75 RID: 7797
		RoverRogueShopBuyResponse = 29643,
		// Token: 0x04001E76 RID: 7798
		RoverRogueShopRefreshResponse = 25485,
		// Token: 0x04001E77 RID: 7799
		DangoBrawlBagOperateResponse = 26530,
		// Token: 0x04001E78 RID: 7800
		DangoBrawlShopRefreshResponse = 22722,
		// Token: 0x04001E79 RID: 7801
		DangoBrawlShopLockResponse = 16429,
		// Token: 0x04001E7A RID: 7802
		DangoBrawlShopBuyResponse = 15499,
		// Token: 0x04001E7B RID: 7803
		DangoBrawlShopSellResponse = 20763,
		// Token: 0x04001E7C RID: 7804
		DangoBrawlShopComposeResponse = 25732,
		// Token: 0x04001E7D RID: 7805
		DangoBrawlEventRefreshResponse = 23486,
		// Token: 0x04001E7E RID: 7806
		DangoBrawlEventSelectResponse = 22706,
		// Token: 0x04001E7F RID: 7807
		DangoBrawlStartFightResponse = 21032,
		// Token: 0x04001E80 RID: 7808
		DangoBrawlFightOverResponse = 19008,
		// Token: 0x04001E81 RID: 7809
		RoverRogueBlessGroupSelectResponse = 20594,
		// Token: 0x04001E82 RID: 7810
		NewTowerMedalInfoResponse = 15134,
		// Token: 0x04001E83 RID: 7811
		RoverRogueEventSelectResponse = 29946,
		// Token: 0x04001E84 RID: 7812
		MotorUseSceneResponse = 23495,
		// Token: 0x04001E85 RID: 7813
		DarkTideSwitchVisionResponse = 26299,
		// Token: 0x04001E86 RID: 7814
		DangoBrawlSettleResponse = 27928,
		// Token: 0x04001E87 RID: 7815
		DangoBrawlTaskRewardResponse = 16585,
		// Token: 0x04001E88 RID: 7816
		DarkTideDiscardItemResponse = 19686,
		// Token: 0x04001E89 RID: 7817
		DarkTidePickUpItemResponse = 18475,
		// Token: 0x04001E8A RID: 7818
		DarkTideBagSortResponse = 27116,
		// Token: 0x04001E8B RID: 7819
		QuestFastReturnPosResponse = 19847,
		// Token: 0x04001E8C RID: 7820
		LevelPlayFastReturnPosResponse = 18541,
		// Token: 0x04001E8D RID: 7821
		FastReturnDungeonResponse = 22693,
		// Token: 0x04001E8E RID: 7822
		DollSmallMapInfoResponse = 22797,
		// Token: 0x04001E8F RID: 7823
		DarkTideMapMarkResponse = 17014,
		// Token: 0x04001E90 RID: 7824
		DarkTideItemMarkResponse = 29034,
		// Token: 0x04001E91 RID: 7825
		RoverRogueLootInfoResponse = 20010,
		// Token: 0x04001E92 RID: 7826
		RoverRogueLootChangeResponse = 20028,
		// Token: 0x04001E93 RID: 7827
		KurotatoStepAdvanceResponse = 20011,
		// Token: 0x04001E94 RID: 7828
		RecallExploreSkillRouletteSetResponse = 23185,
		// Token: 0x04001E95 RID: 7829
		RoverRogueTaskRewardTakeResponse = 20042,
		// Token: 0x04001E96 RID: 7830
		SceneGroupDataAndCurFormationEntityResponse = 23762,
		// Token: 0x04001E97 RID: 7831
		KurotatoGoldAddResponse = 26245,
		// Token: 0x04001E98 RID: 7832
		TowerDefenceChallengeQuitResponse = 29413,
		// Token: 0x04001E99 RID: 7833
		KurotatoLevelRecordDeleteResponse = 29888,
		// Token: 0x04001E9A RID: 7834
		MailFavoriteResponse = 26065,
		// Token: 0x04001E9B RID: 7835
		ConditionGroupStateResponse = 21511,
		// Token: 0x04001E9C RID: 7836
		ZitherPlayStateResponse = 16415,
		// Token: 0x04001E9D RID: 7837
		EntityAccessCasketResponse = 16078,
		// Token: 0x04001E9E RID: 7838
		PlayerAccessCasketResponse = 26332,
		// Token: 0x04001E9F RID: 7839
		QingXiaoTaskRewardResponse = 24325,
		// Token: 0x04001EA0 RID: 7840
		GiantDeliveryItemResponse = 20317,
		// Token: 0x04001EA1 RID: 7841
		GiantMaxLevelDeliveryItemResponse = 17949,
		// Token: 0x04001EA2 RID: 7842
		MatchThreeStarResponse = 19999,
		// Token: 0x04001EA3 RID: 7843
		MatchThreeEndResponse = 28958,
		// Token: 0x04001EA4 RID: 7844
		DangoBrawlScoreRewardResponse = 27166,
		// Token: 0x04001EA5 RID: 7845
		FoundationCoreOperateResponse = 21475,
		// Token: 0x04001EA6 RID: 7846
		CameraSettingQueryResponse = 22753,
		// Token: 0x04001EA7 RID: 7847
		CameraSettingModifyResponse = 17786,
		// Token: 0x04001EA8 RID: 7848
		RecallTeleportToMarkIdResponse = 18152,
		// Token: 0x04001EA9 RID: 7849
		ShortMessageChatThemeChangeResponse = 19186,
		// Token: 0x04001EAA RID: 7850
		ShortMessageChatCharmChangeResponse = 18908,
		// Token: 0x04001EAB RID: 7851
		RenameFormationResponse = 17954,
		// Token: 0x04001EAC RID: 7852
		ReorderFormationResponse = 25008,
		// Token: 0x04001EAD RID: 7853
		GiantStableValueActivityResponse = 29866,
		// Token: 0x04001EAE RID: 7854
		RecallItemUseResponse = 28729,
		// Token: 0x04001EAF RID: 7855
		GameStatsShowResponse = 19755,
		// Token: 0x04001EB0 RID: 7856
		SelfPortraitStateResponse = 25392,
		// Token: 0x04001EB1 RID: 7857
		LoopTeleportVolumeActionResponse = 18393,
		// Token: 0x04001EB2 RID: 7858
		WellStreamingFinisResponse = 28686,
		// Token: 0x04001EB3 RID: 7859
		TimePointActivityBatchRewardResponse = 22079
	}
}
