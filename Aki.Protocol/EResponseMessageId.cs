using System;

namespace Aki.Protocol
{
	// Token: 0x0200000B RID: 11
	public enum EResponseMessageId
	{
		// Token: 0x040019DD RID: 6621
		CreateCharacterResponse = 102,
		// Token: 0x040019DE RID: 6622
		LoginResponse = 104,
		// Token: 0x040019DF RID: 6623
		EnterGameResponse = 106,
		// Token: 0x040019E0 RID: 6624
		ReconnectResponse = 108,
		// Token: 0x040019E1 RID: 6625
		ProtoKeyResponse = 112,
		// Token: 0x040019E2 RID: 6626
		AchievementInfoResponse = 19753,
		// Token: 0x040019E3 RID: 6627
		AchievementReceiveResponse = 25408,
		// Token: 0x040019E4 RID: 6628
		AchievementFinishResponse = 19182,
		// Token: 0x040019E5 RID: 6629
		ActionFinishResponse = 26069,
		// Token: 0x040019E6 RID: 6630
		GmLevelActionResponse = 26699,
		// Token: 0x040019E7 RID: 6631
		ActivityResponse = 15999,
		// Token: 0x040019E8 RID: 6632
		ActivityFirstReadResponse = 19193,
		// Token: 0x040019E9 RID: 6633
		SignActivityResponse = 18799,
		// Token: 0x040019EA RID: 6634
		HarvestActivityPointResponse = 26658,
		// Token: 0x040019EB RID: 6635
		HarvestActivityLevelResponse = 23959,
		// Token: 0x040019EC RID: 6636
		HarvestActivityLevelDiffResponse = 28299,
		// Token: 0x040019ED RID: 6637
		HarvestActivityResultResponse = 19031,
		// Token: 0x040019EE RID: 6638
		PhantomCollectReceiveResponse = 21188,
		// Token: 0x040019EF RID: 6639
		AdventureManualDataResponse = 24214,
		// Token: 0x040019F0 RID: 6640
		GetAdventureRewardResponse = 25347,
		// Token: 0x040019F1 RID: 6641
		GetChapterRewardResponse = 18554,
		// Token: 0x040019F2 RID: 6642
		DetectionResponse = 17575,
		// Token: 0x040019F3 RID: 6643
		AdventureManualResponse = 19686,
		// Token: 0x040019F4 RID: 6644
		ReceivedSilentFirstAwardResponse = 28437,
		// Token: 0x040019F5 RID: 6645
		SelectDetectionTargetResponse = 15118,
		// Token: 0x040019F6 RID: 6646
		MonsterDetectionInfoResponse = 17979,
		// Token: 0x040019F7 RID: 6647
		NormalMonsterManualInfoResponse = 22708,
		// Token: 0x040019F8 RID: 6648
		GetDetectionLabelInfoResponse = 21286,
		// Token: 0x040019F9 RID: 6649
		AdviceSetResponse = 20925,
		// Token: 0x040019FA RID: 6650
		AdviceResponse = 28955,
		// Token: 0x040019FB RID: 6651
		AdviceCreateResponse = 19764,
		// Token: 0x040019FC RID: 6652
		AdviceModifyResponse = 18162,
		// Token: 0x040019FD RID: 6653
		AdviceDeleteResponse = 28966,
		// Token: 0x040019FE RID: 6654
		AdviceVoteResponse = 18076,
		// Token: 0x040019FF RID: 6655
		AiInformationResponse = 20922,
		// Token: 0x04001A00 RID: 6656
		AiBlackboardsResponse = 27598,
		// Token: 0x04001A01 RID: 6657
		AiBlackboardCdResponse = 29807,
		// Token: 0x04001A02 RID: 6658
		AiHateResponse = 20048,
		// Token: 0x04001A03 RID: 6659
		AiControlSwitchResponse = 29374,
		// Token: 0x04001A04 RID: 6660
		EnterAreaResponse = 17162,
		// Token: 0x04001A05 RID: 6661
		ReportPlayerResponse = 22547,
		// Token: 0x04001A06 RID: 6662
		ModifyNameResponse = 16293,
		// Token: 0x04001A07 RID: 6663
		ModifySignatureResponse = 18895,
		// Token: 0x04001A08 RID: 6664
		ChangeHeadPhotoResponse = 28817,
		// Token: 0x04001A09 RID: 6665
		ClientBasicInfoResponse = 19121,
		// Token: 0x04001A0A RID: 6666
		PlayerBasicInfoGetResponse = 19022,
		// Token: 0x04001A0B RID: 6667
		BirthdayInitResponse = 29356,
		// Token: 0x04001A0C RID: 6668
		RoleShowListUpdateResponse = 23280,
		// Token: 0x04001A0D RID: 6669
		ChangeCardResponse = 29040,
		// Token: 0x04001A0E RID: 6670
		ReadCardResponse = 19779,
		// Token: 0x04001A0F RID: 6671
		BirthdayShowSetResponse = 29672,
		// Token: 0x04001A10 RID: 6672
		BattlePassResponse = 26557,
		// Token: 0x04001A11 RID: 6673
		BattlePassTakeRewardResponse = 29764,
		// Token: 0x04001A12 RID: 6674
		BattlePassRecurringTakeResponse = 27272,
		// Token: 0x04001A13 RID: 6675
		BattlePassTakeAllRewardResponse = 27259,
		// Token: 0x04001A14 RID: 6676
		BattlePassTaskResponse = 27662,
		// Token: 0x04001A15 RID: 6677
		BattlePassTaskTakeResponse = 17148,
		// Token: 0x04001A16 RID: 6678
		BattlePassLevelUpResponse = 19912,
		// Token: 0x04001A17 RID: 6679
		SubmitNodeResponse = 21283,
		// Token: 0x04001A18 RID: 6680
		HandInItemResponse = 21737,
		// Token: 0x04001A19 RID: 6681
		BtSetTimerInfoResponse = 20250,
		// Token: 0x04001A1A RID: 6682
		BtForcedOccupationResponse = 24742,
		// Token: 0x04001A1B RID: 6683
		BtGiveUpResponse = 22791,
		// Token: 0x04001A1C RID: 6684
		BtRollbackResponse = 22916,
		// Token: 0x04001A1D RID: 6685
		SneakResponse = 27480,
		// Token: 0x04001A1E RID: 6686
		SneakTimeResponse = 16525,
		// Token: 0x04001A1F RID: 6687
		TimerEndResponse = 29668,
		// Token: 0x04001A20 RID: 6688
		UiGamePlayResponse = 19566,
		// Token: 0x04001A21 RID: 6689
		NpcTraceFailedResponse = 19981,
		// Token: 0x04001A22 RID: 6690
		WorldBlackboardResponse = 19301,
		// Token: 0x04001A23 RID: 6691
		EntityBlackboardResponse = 26328,
		// Token: 0x04001A24 RID: 6692
		BlockListResponse = 23512,
		// Token: 0x04001A25 RID: 6693
		BlockPlayerResponse = 25057,
		// Token: 0x04001A26 RID: 6694
		UnblockPlayerResponse = 26572,
		// Token: 0x04001A27 RID: 6695
		PlaceItemOnBoardResponse = 22601,
		// Token: 0x04001A28 RID: 6696
		CommitBoardResponse = 16328,
		// Token: 0x04001A29 RID: 6697
		MovePlacementResponse = 29380,
		// Token: 0x04001A2A RID: 6698
		ApplyGameplayEffectResponse = 23904,
		// Token: 0x04001A2B RID: 6699
		RemoveGameplayEffectResponse = 29948,
		// Token: 0x04001A2C RID: 6700
		OrderApplyBuffResponse = 15979,
		// Token: 0x04001A2D RID: 6701
		OrderRemoveBuffResponse = 17733,
		// Token: 0x04001A2E RID: 6702
		ActivateBuffResponse = 19166,
		// Token: 0x04001A2F RID: 6703
		OrderRemoveBuffByTagsResponse = 20335,
		// Token: 0x04001A30 RID: 6704
		BuffEffectExecuteResponse = 27923,
		// Token: 0x04001A31 RID: 6705
		BuffStackCountResponse = 16438,
		// Token: 0x04001A32 RID: 6706
		BuffEffectResponse = 20053,
		// Token: 0x04001A33 RID: 6707
		BuffItemResponse = 21929,
		// Token: 0x04001A34 RID: 6708
		CalabashMsgResponse = 15659,
		// Token: 0x04001A35 RID: 6709
		CalabashLevelRewardResponse = 23187,
		// Token: 0x04001A36 RID: 6710
		CdKeyVerifyResponse = 19513,
		// Token: 0x04001A37 RID: 6711
		ChatResponse = 26663,
		// Token: 0x04001A38 RID: 6712
		PrivateChatResponse = 21677,
		// Token: 0x04001A39 RID: 6713
		PrivateChatHistoryResponse = 24958,
		// Token: 0x04001A3A RID: 6714
		PrivateChatDataResponse = 27414,
		// Token: 0x04001A3B RID: 6715
		ChatMutePlayerResponse = 26851,
		// Token: 0x04001A3C RID: 6716
		PrivateChatOperateResponse = 26788,
		// Token: 0x04001A3D RID: 6717
		ChannelChatResponse = 20052,
		// Token: 0x04001A3E RID: 6718
		CombatSendPackResponse = 21536,
		// Token: 0x04001A3F RID: 6719
		CombatMaxCaseMessageResponse = 15035,
		// Token: 0x04001A40 RID: 6720
		FixToolResponse = 20809,
		// Token: 0x04001A41 RID: 6721
		CookFormulaResponse = 23024,
		// Token: 0x04001A42 RID: 6722
		CookFoodResponse = 23883,
		// Token: 0x04001A43 RID: 6723
		FoodProcessResponse = 23327,
		// Token: 0x04001A44 RID: 6724
		CertificateLevelRewardResponse = 25731,
		// Token: 0x04001A45 RID: 6725
		CookingDataResponse = 26168,
		// Token: 0x04001A46 RID: 6726
		InteractiveUpdateResponse = 23737,
		// Token: 0x04001A47 RID: 6727
		DailyAdventurePtRewardResponse = 17678,
		// Token: 0x04001A48 RID: 6728
		DailyAdventureTaskRewardResponse = 17499,
		// Token: 0x04001A49 RID: 6729
		CheatInputResponse = 27253,
		// Token: 0x04001A4A RID: 6730
		EnableDamageRecordResponse = 27761,
		// Token: 0x04001A4B RID: 6731
		OutputDebugInfoResponse = 22307,
		// Token: 0x04001A4C RID: 6732
		PickUpDropItemResponse = 24726,
		// Token: 0x04001A4D RID: 6733
		ElevatorStateChangeResponse = 19002,
		// Token: 0x04001A4E RID: 6734
		EnergySyncResponse = 16637,
		// Token: 0x04001A4F RID: 6735
		ChangeStateResponse = 28519,
		// Token: 0x04001A50 RID: 6736
		ChangeStateConfirmResponse = 22660,
		// Token: 0x04001A51 RID: 6737
		FsmConditionPassResponse = 18028,
		// Token: 0x04001A52 RID: 6738
		GmEntityFsmGroupInfoResponse = 19279,
		// Token: 0x04001A53 RID: 6739
		EntityBuffProducerResponse = 18914,
		// Token: 0x04001A54 RID: 6740
		EntityBuffProducerOperateResponse = 22978,
		// Token: 0x04001A55 RID: 6741
		LogicStateInitResponse = 29984,
		// Token: 0x04001A56 RID: 6742
		SwitchLogicStateResponse = 22141,
		// Token: 0x04001A57 RID: 6743
		EntityActiveResponse = 19734,
		// Token: 0x04001A58 RID: 6744
		AnimationGameplayTagResponse = 18524,
		// Token: 0x04001A59 RID: 6745
		AnimalDieResponse = 15258,
		// Token: 0x04001A5A RID: 6746
		AnimalDestroyResponse = 26151,
		// Token: 0x04001A5B RID: 6747
		AnimalDropResponse = 29883,
		// Token: 0x04001A5C RID: 6748
		EntityInteractResponse = 29979,
		// Token: 0x04001A5D RID: 6749
		EntityRandomInteractResponse = 25922,
		// Token: 0x04001A5E RID: 6750
		EntityDynamicInteractResponse = 29039,
		// Token: 0x04001A5F RID: 6751
		EntityPosAbnormalResponse = 24226,
		// Token: 0x04001A60 RID: 6752
		EntityAdsorbResponse = 27477,
		// Token: 0x04001A61 RID: 6753
		BoneVisibleChangeResponse = 21695,
		// Token: 0x04001A62 RID: 6754
		EntityStaticHookMoveResponse = 15040,
		// Token: 0x04001A63 RID: 6755
		EntityPatrolStartResponse = 19013,
		// Token: 0x04001A64 RID: 6756
		EntityPatrolStopResponse = 19611,
		// Token: 0x04001A65 RID: 6757
		EntityPatrolChangeDirResponse = 26449,
		// Token: 0x04001A66 RID: 6758
		VfxNpcPatrolFinishResponse = 16241,
		// Token: 0x04001A67 RID: 6759
		EntitySendEventResponse = 21355,
		// Token: 0x04001A68 RID: 6760
		AccessPasserbyNpcSpawnerResponse = 17585,
		// Token: 0x04001A69 RID: 6761
		ExploreProgressResponse = 29853,
		// Token: 0x04001A6A RID: 6762
		ExploreScoreRewardResponse = 18852,
		// Token: 0x04001A6B RID: 6763
		CountryExploreScoreInfoResponse = 24983,
		// Token: 0x04001A6C RID: 6764
		VisionExploreSkillSetResponse = 18378,
		// Token: 0x04001A6D RID: 6765
		ExploreSkillRouletteSetResponse = 27182,
		// Token: 0x04001A6E RID: 6766
		ExploreSkillPullGiantResponse = 21630,
		// Token: 0x04001A6F RID: 6767
		UseDetectionSkillResponse = 23849,
		// Token: 0x04001A70 RID: 6768
		SetFanNumberOfTurnsResponse = 27911,
		// Token: 0x04001A71 RID: 6769
		SetBaoziStateResponse = 29269,
		// Token: 0x04001A72 RID: 6770
		SetFanStateResponse = 24361,
		// Token: 0x04001A73 RID: 6771
		RoleFavorListResponse = 28736,
		// Token: 0x04001A74 RID: 6772
		RoleFavorUnLockResponse = 21000,
		// Token: 0x04001A75 RID: 6773
		RoleFavorAcceptQuestResponse = 17922,
		// Token: 0x04001A76 RID: 6774
		RoleFavorTalkScoreResponse = 15509,
		// Token: 0x04001A77 RID: 6775
		RoleMotionUnLockResponse = 24424,
		// Token: 0x04001A78 RID: 6776
		SkillResponse = 17453,
		// Token: 0x04001A79 RID: 6777
		UseSkillResponse = 21045,
		// Token: 0x04001A7A RID: 6778
		EndSkillResponse = 24932,
		// Token: 0x04001A7B RID: 6779
		InterruptSkillInDelayResponse = 28034,
		// Token: 0x04001A7C RID: 6780
		UseSkillFailResponse = 22556,
		// Token: 0x04001A7D RID: 6781
		HitResponse = 27996,
		// Token: 0x04001A7E RID: 6782
		HitEndResponse = 27143,
		// Token: 0x04001A7F RID: 6783
		CaughtResponse = 22560,
		// Token: 0x04001A80 RID: 6784
		CreateBulletResponse = 19384,
		// Token: 0x04001A81 RID: 6785
		DestroyBulletResponse = 29062,
		// Token: 0x04001A82 RID: 6786
		ModifyBulletParamsResponse = 17302,
		// Token: 0x04001A83 RID: 6787
		DamageExecuteResponse = 16478,
		// Token: 0x04001A84 RID: 6788
		PassiveSkillAddResponse = 26311,
		// Token: 0x04001A85 RID: 6789
		PassiveSkillRemoveResponse = 22073,
		// Token: 0x04001A86 RID: 6790
		EnterViewDirectionResponse = 28371,
		// Token: 0x04001A87 RID: 6791
		ExitViewDirectionResponse = 28401,
		// Token: 0x04001A88 RID: 6792
		TriggerExitSkillResponse = 18531,
		// Token: 0x04001A89 RID: 6793
		CharacterDeathResponse = 25795,
		// Token: 0x04001A8A RID: 6794
		SwitchBattleModeResponse = 19436,
		// Token: 0x04001A8B RID: 6795
		LandingDamageResponse = 27519,
		// Token: 0x04001A8C RID: 6796
		EntityIsVisibleResponse = 27947,
		// Token: 0x04001A8D RID: 6797
		ActorVisibleResponse = 23563,
		// Token: 0x04001A8E RID: 6798
		SwitchCharacterStateResponse = 26238,
		// Token: 0x04001A8F RID: 6799
		BattleStateChangeResponse = 22078,
		// Token: 0x04001A90 RID: 6800
		ToughCalcExtraRatioChangeResponse = 29306,
		// Token: 0x04001A91 RID: 6801
		MonsterBoomResponse = 28184,
		// Token: 0x04001A92 RID: 6802
		EntityBattleInfoResponse = 23069,
		// Token: 0x04001A93 RID: 6803
		MontagePlayResponse = 19825,
		// Token: 0x04001A94 RID: 6804
		ANStartResponse = 25684,
		// Token: 0x04001A95 RID: 6805
		SwitchRoleResponse = 16820,
		// Token: 0x04001A96 RID: 6806
		UpdateFormationResponse = 24546,
		// Token: 0x04001A97 RID: 6807
		UpdateFightRoleResponse = 19583,
		// Token: 0x04001A98 RID: 6808
		GetFormationDataResponse = 18668,
		// Token: 0x04001A99 RID: 6809
		FlowEndResponse = 29872,
		// Token: 0x04001A9A RID: 6810
		FlowRestartResponse = 23746,
		// Token: 0x04001A9B RID: 6811
		FlowActionResponse = 29226,
		// Token: 0x04001A9C RID: 6812
		ForgeInfoResponse = 18747,
		// Token: 0x04001A9D RID: 6813
		ForgeItemResponse = 24992,
		// Token: 0x04001A9E RID: 6814
		ForgeFormulaUnlockResponse = 26326,
		// Token: 0x04001A9F RID: 6815
		FormationResponse = 20142,
		// Token: 0x04001AA0 RID: 6816
		FormationSwitchCurrentResponse = 22323,
		// Token: 0x04001AA1 RID: 6817
		FormationModifyResponse = 18825,
		// Token: 0x04001AA2 RID: 6818
		FormationChangeResponse = 18622,
		// Token: 0x04001AA3 RID: 6819
		FormationSwitchRoleResponse = 27628,
		// Token: 0x04001AA4 RID: 6820
		ClientCurrentRoleReportResponse = 15392,
		// Token: 0x04001AA5 RID: 6821
		FriendAllResponse = 20502,
		// Token: 0x04001AA6 RID: 6822
		FriendApplySendResponse = 15562,
		// Token: 0x04001AA7 RID: 6823
		FriendApplyHandleResponse = 20998,
		// Token: 0x04001AA8 RID: 6824
		FriendRemarkResponse = 29476,
		// Token: 0x04001AA9 RID: 6825
		FriendDeleteResponse = 17425,
		// Token: 0x04001AAA RID: 6826
		FriendRecentlyTeamResponse = 24249,
		// Token: 0x04001AAB RID: 6827
		FuncShowResponse = 21232,
		// Token: 0x04001AAC RID: 6828
		GachaInfoResponse = 22256,
		// Token: 0x04001AAD RID: 6829
		GachaResponse = 28271,
		// Token: 0x04001AAE RID: 6830
		GachaUsePoolResponse = 19735,
		// Token: 0x04001AAF RID: 6831
		GatherActivityRewardResponse = 29225,
		// Token: 0x04001AB0 RID: 6832
		GuideInfoResponse = 26611,
		// Token: 0x04001AB1 RID: 6833
		GuideTriggerResponse = 25835,
		// Token: 0x04001AB2 RID: 6834
		GuideFinishResponse = 21373,
		// Token: 0x04001AB3 RID: 6835
		HeartbeatResponse = 1651,
		// Token: 0x04001AB4 RID: 6836
		GatewayEchoResponse = 23722,
		// Token: 0x04001AB5 RID: 6837
		IllustratedRedDotResponse = 26946,
		// Token: 0x04001AB6 RID: 6838
		IllustratedInfoResponse = 28603,
		// Token: 0x04001AB7 RID: 6839
		IllustratedUnlockResponse = 20078,
		// Token: 0x04001AB8 RID: 6840
		IllustratedReadResponse = 27163,
		// Token: 0x04001AB9 RID: 6841
		InfluenceInfoResponse = 21485,
		// Token: 0x04001ABA RID: 6842
		InfluenceRewardResponse = 21130,
		// Token: 0x04001ABB RID: 6843
		ReadDisplayInfoResponse = 20372,
		// Token: 0x04001ABC RID: 6844
		EnterInstResponse = 18932,
		// Token: 0x04001ABD RID: 6845
		UnlockInstEntranceResponse = 24736,
		// Token: 0x04001ABE RID: 6846
		InstEntranceDetailResponse = 26537,
		// Token: 0x04001ABF RID: 6847
		LeaveInstResponse = 20271,
		// Token: 0x04001AC0 RID: 6848
		GetInstExchangeRewardResponse = 23064,
		// Token: 0x04001AC1 RID: 6849
		ExchangeRewardInfoResponse = 23945,
		// Token: 0x04001AC2 RID: 6850
		SingleInstRechallengeResponse = 23802,
		// Token: 0x04001AC3 RID: 6851
		ItemDecomposeResponse = 24230,
		// Token: 0x04001AC4 RID: 6852
		ItemDecomposePreviewResponse = 16064,
		// Token: 0x04001AC5 RID: 6853
		ItemLockResponse = 22732,
		// Token: 0x04001AC6 RID: 6854
		ItemUseResponse = 21049,
		// Token: 0x04001AC7 RID: 6855
		ItemGiftUseResponse = 25639,
		// Token: 0x04001AC8 RID: 6856
		NormalItemResponse = 22771,
		// Token: 0x04001AC9 RID: 6857
		WeaponItemResponse = 24074,
		// Token: 0x04001ACA RID: 6858
		PhantomItemResponse = 24418,
		// Token: 0x04001ACB RID: 6859
		InvalidItemResponse = 25982,
		// Token: 0x04001ACC RID: 6860
		ShowInvalidItemResponse = 17796,
		// Token: 0x04001ACD RID: 6861
		ValidTimeItemResponse = 16298,
		// Token: 0x04001ACE RID: 6862
		ItemExchangeInfoResponse = 19721,
		// Token: 0x04001ACF RID: 6863
		ItemExchangeResponse = 24645,
		// Token: 0x04001AD0 RID: 6864
		LevelPlayRewardResponse = 17215,
		// Token: 0x04001AD1 RID: 6865
		LivenessResponse = 26035,
		// Token: 0x04001AD2 RID: 6866
		LivenessTaskTakeResponse = 23181,
		// Token: 0x04001AD3 RID: 6867
		LivenessTakeResponse = 15626,
		// Token: 0x04001AD4 RID: 6868
		LoadEquipInfoResponse = 29155,
		// Token: 0x04001AD5 RID: 6869
		EquipTakeOnResponse = 29980,
		// Token: 0x04001AD6 RID: 6870
		LordGymInfoResponse = 24508,
		// Token: 0x04001AD7 RID: 6871
		LordGymBeginResponse = 25090,
		// Token: 0x04001AD8 RID: 6872
		LordGymReadResponse = 21070,
		// Token: 0x04001AD9 RID: 6873
		MailReadResponse = 23666,
		// Token: 0x04001ADA RID: 6874
		MailGetAttachmentResponse = 26747,
		// Token: 0x04001ADB RID: 6875
		MailDeleteResponse = 22089,
		// Token: 0x04001ADC RID: 6876
		MapMarkInfoResponse = 19613,
		// Token: 0x04001ADD RID: 6877
		MapUnlockFieldInfoResponse = 19902,
		// Token: 0x04001ADE RID: 6878
		MapMarkResponse = 18621,
		// Token: 0x04001ADF RID: 6879
		MapRemoveMarkResponse = 29212,
		// Token: 0x04001AE0 RID: 6880
		MapTraceInfoResponse = 20456,
		// Token: 0x04001AE1 RID: 6881
		MapTraceResponse = 24396,
		// Token: 0x04001AE2 RID: 6882
		MapCancelTraceResponse = 26282,
		// Token: 0x04001AE3 RID: 6883
		MapReplaceMarkResponse = 25551,
		// Token: 0x04001AE4 RID: 6884
		MapRemoveAllMarkResponse = 23743,
		// Token: 0x04001AE5 RID: 6885
		MapMarkInfoUpdateResponse = 26030,
		// Token: 0x04001AE6 RID: 6886
		StartMatchResponse = 24408,
		// Token: 0x04001AE7 RID: 6887
		CancelMatchResponse = 17155,
		// Token: 0x04001AE8 RID: 6888
		MatchConfirmResponse = 15699,
		// Token: 0x04001AE9 RID: 6889
		MatchChangeRoleResponse = 21111,
		// Token: 0x04001AEA RID: 6890
		MatchChangeReadyResponse = 20725,
		// Token: 0x04001AEB RID: 6891
		LeaveMatchTeamResponse = 18375,
		// Token: 0x04001AEC RID: 6892
		KickMatchTeamPlayerResponse = 21595,
		// Token: 0x04001AED RID: 6893
		SetMatchTeamMatchFlagResponse = 19772,
		// Token: 0x04001AEE RID: 6894
		EnterMatchInstResponse = 15610,
		// Token: 0x04001AEF RID: 6895
		TeamChallengeResponse = 21288,
		// Token: 0x04001AF0 RID: 6896
		TeamMatchInviteResponse = 17491,
		// Token: 0x04001AF1 RID: 6897
		TeamMatchAcceptInviteResponse = 26064,
		// Token: 0x04001AF2 RID: 6898
		MatchChangePlayerUiStateResponse = 20111,
		// Token: 0x04001AF3 RID: 6899
		HandInMingSuResponse = 25984,
		// Token: 0x04001AF4 RID: 6900
		ActiveDragonPoolResponse = 25761,
		// Token: 0x04001AF5 RID: 6901
		DragonPoolConfResponse = 16385,
		// Token: 0x04001AF6 RID: 6902
		MonthCardResponse = 26286,
		// Token: 0x04001AF7 RID: 6903
		MutiplayerTeamRefreshNearListResponse = 20108,
		// Token: 0x04001AF8 RID: 6904
		NetTestDataResponse = 23468,
		// Token: 0x04001AF9 RID: 6905
		NewBieCourseRewardResponse = 17644,
		// Token: 0x04001AFA RID: 6906
		NewJourneyResponse = 17635,
		// Token: 0x04001AFB RID: 6907
		ParkourChallengeResponse = 28350,
		// Token: 0x04001AFC RID: 6908
		ParkourChallengeTakeResponse = 21667,
		// Token: 0x04001AFD RID: 6909
		ParkourChallengeTransResponse = 16542,
		// Token: 0x04001AFE RID: 6910
		PartComponentInitResponse = 17051,
		// Token: 0x04001AFF RID: 6911
		PartUpdateResponse = 23891,
		// Token: 0x04001B00 RID: 6912
		PayInfoResponse = 21829,
		// Token: 0x04001B01 RID: 6913
		PayItemResponse = 22536,
		// Token: 0x04001B02 RID: 6914
		PayGiftInfoResponse = 15822,
		// Token: 0x04001B03 RID: 6915
		PayGiftResponse = 21886,
		// Token: 0x04001B04 RID: 6916
		PayShopInfoResponse = 28666,
		// Token: 0x04001B05 RID: 6917
		PayShopUpdateResponse = 26133,
		// Token: 0x04001B06 RID: 6918
		PayShopItemUpdateResponse = 16503,
		// Token: 0x04001B07 RID: 6919
		PayShopBuyResponse = 19539,
		// Token: 0x04001B08 RID: 6920
		PayShopDirectBuyResponse = 29388,
		// Token: 0x04001B09 RID: 6921
		PhantomLevelUpResponse = 29647,
		// Token: 0x04001B0A RID: 6922
		PhantomPutOnResponse = 21144,
		// Token: 0x04001B0B RID: 6923
		PhantomReturnPreviewResponse = 21268,
		// Token: 0x04001B0C RID: 6924
		PhantomReturnResponse = 20325,
		// Token: 0x04001B0D RID: 6925
		PhantomRecommendResponse = 26730,
		// Token: 0x04001B0E RID: 6926
		PhantomAutoPutResponse = 21508,
		// Token: 0x04001B0F RID: 6927
		PhantomIdentifyResponse = 19102,
		// Token: 0x04001B10 RID: 6928
		PhantomSkinChangeResponse = 26665,
		// Token: 0x04001B11 RID: 6929
		PhantomRefiningResponse = 27651,
		// Token: 0x04001B12 RID: 6930
		UpdatePlayerPassiveSkillResponse = 22796,
		// Token: 0x04001B13 RID: 6931
		PlayerMotionResponse = 29174,
		// Token: 0x04001B14 RID: 6932
		PressResponse = 25825,
		// Token: 0x04001B15 RID: 6933
		PressGameResponse = 23963,
		// Token: 0x04001B16 RID: 6934
		ProgressBarFinishResponse = 25134,
		// Token: 0x04001B17 RID: 6935
		FormationAttrResponse = 28542,
		// Token: 0x04001B18 RID: 6936
		FragileChangeResponse = 21843,
		// Token: 0x04001B19 RID: 6937
		CheckPublicResourceVersionResponse = 21060,
		// Token: 0x04001B1A RID: 6938
		TraceQuestResponse = 15680,
		// Token: 0x04001B1B RID: 6939
		QuestFinishActionResponse = 17278,
		// Token: 0x04001B1C RID: 6940
		QuestActionResponse = 15105,
		// Token: 0x04001B1D RID: 6941
		QuestNpcMoveOverResponse = 21885,
		// Token: 0x04001B1E RID: 6942
		QuestFinishActionEndResponse = 18310,
		// Token: 0x04001B1F RID: 6943
		DailyQuestChangePreferResponse = 15733,
		// Token: 0x04001B20 RID: 6944
		DailyQuestGetRewardResponse = 21806,
		// Token: 0x04001B21 RID: 6945
		RoleQuestAcceptResponse = 18875,
		// Token: 0x04001B22 RID: 6946
		RoleQuestPointStateResponse = 24846,
		// Token: 0x04001B23 RID: 6947
		QuestRedDotResponse = 29563,
		// Token: 0x04001B24 RID: 6948
		ApplyRechallengeResponse = 29801,
		// Token: 0x04001B25 RID: 6949
		ReceiveRechallengeResponse = 21241,
		// Token: 0x04001B26 RID: 6950
		InviteRechallengeResponse = 15563,
		// Token: 0x04001B27 RID: 6951
		ReviveResponse = 24465,
		// Token: 0x04001B28 RID: 6952
		AddReviveRegionResponse = 19029,
		// Token: 0x04001B29 RID: 6953
		RemoveReviveRegionResponse = 19862,
		// Token: 0x04001B2A RID: 6954
		RoguelikeRefreshGainResponse = 23711,
		// Token: 0x04001B2B RID: 6955
		RoguelikeChooseDataResponse = 17486,
		// Token: 0x04001B2C RID: 6956
		RoguelikeChooseDataResultResponse = 18902,
		// Token: 0x04001B2D RID: 6957
		RoguelikeLastInfoResponse = 24998,
		// Token: 0x04001B2E RID: 6958
		RoguelikeStartResponse = 22991,
		// Token: 0x04001B2F RID: 6959
		RoguelikeQuitResponse = 18512,
		// Token: 0x04001B30 RID: 6960
		RoguelikeResultResponse = 15568,
		// Token: 0x04001B31 RID: 6961
		RoguelikeGotoNextRoomResponse = 23489,
		// Token: 0x04001B32 RID: 6962
		RoguelikeTalentInfoResponse = 29814,
		// Token: 0x04001B33 RID: 6963
		RoguelikeTalentLevelUpResponse = 24087,
		// Token: 0x04001B34 RID: 6964
		RoguelikeSeasonDataResponse = 18829,
		// Token: 0x04001B35 RID: 6965
		RoguelikeTokenReceiveResponse = 15495,
		// Token: 0x04001B36 RID: 6966
		RoguelikeSeasonRewardReceiveResponse = 18258,
		// Token: 0x04001B37 RID: 6967
		RoguelikeGiveUpGainResponse = 21026,
		// Token: 0x04001B38 RID: 6968
		PbGetRoleListResponse = 28176,
		// Token: 0x04001B39 RID: 6969
		PbUpLevelRoleResponse = 24873,
		// Token: 0x04001B3A RID: 6970
		PbOverRoleResponse = 25986,
		// Token: 0x04001B3B RID: 6971
		PbUpLevelSkillResponse = 26023,
		// Token: 0x04001B3C RID: 6972
		RoleLevelUpViewResponse = 17361,
		// Token: 0x04001B3D RID: 6973
		RoleBreakThroughViewResponse = 29247,
		// Token: 0x04001B3E RID: 6974
		RoleSkillLevelUpViewResponse = 23907,
		// Token: 0x04001B3F RID: 6975
		RoleSkillViewResponse = 17396,
		// Token: 0x04001B40 RID: 6976
		RoleActivateSkillResponse = 17055,
		// Token: 0x04001B41 RID: 6977
		ResonantChainUnlockResponse = 21735,
		// Token: 0x04001B42 RID: 6978
		RoleSexChangeResponse = 23208,
		// Token: 0x04001B43 RID: 6979
		RoleElementChangeResponse = 17531,
		// Token: 0x04001B44 RID: 6980
		TrialRoleRewardResponse = 26824,
		// Token: 0x04001B45 RID: 6981
		CaptureEntityResponse = 15289,
		// Token: 0x04001B46 RID: 6982
		RemoveSummonEntityResponse = 28927,
		// Token: 0x04001B47 RID: 6983
		ChangeEntityRoleResponse = 28494,
		// Token: 0x04001B48 RID: 6984
		EntityOnLandedResponse = 27404,
		// Token: 0x04001B49 RID: 6985
		AttributeInitResponse = 18934,
		// Token: 0x04001B4A RID: 6986
		AttributeChangedResponse = 24670,
		// Token: 0x04001B4B RID: 6987
		AnimationStateInitResponse = 27644,
		// Token: 0x04001B4C RID: 6988
		AnimationStateChangedResponse = 23977,
		// Token: 0x04001B4D RID: 6989
		HardnessModeChangedResponse = 25063,
		// Token: 0x04001B4E RID: 6990
		SummonResponse = 15829,
		// Token: 0x04001B4F RID: 6991
		Summon2Response = 20104,
		// Token: 0x04001B50 RID: 6992
		RemoveInstanceTimerResponse = 22241,
		// Token: 0x04001B51 RID: 6993
		UpdateSceneDateResponse = 24289,
		// Token: 0x04001B52 RID: 6994
		DiscardWeaponResponse = 20992,
		// Token: 0x04001B53 RID: 6995
		CreatStoryCharacterResponse = 24319,
		// Token: 0x04001B54 RID: 6996
		DeleteStoryCharacterResponse = 16614,
		// Token: 0x04001B55 RID: 6997
		CreatureDetailResponse = 16069,
		// Token: 0x04001B56 RID: 6998
		ChangeEntityStateResponse = 21818,
		// Token: 0x04001B57 RID: 6999
		FoundationResponse = 26544,
		// Token: 0x04001B58 RID: 7000
		BeControlledResponse = 24551,
		// Token: 0x04001B59 RID: 7001
		BeControlledShowResponse = 26477,
		// Token: 0x04001B5A RID: 7002
		BeControlledThrowResponse = 16431,
		// Token: 0x04001B5B RID: 7003
		GravityGearResponse = 27144,
		// Token: 0x04001B5C RID: 7004
		ChangeWeatherResponse = 19397,
		// Token: 0x04001B5D RID: 7005
		FollowTrackResponse = 21101,
		// Token: 0x04001B5E RID: 7006
		SetInitTagResponse = 17305,
		// Token: 0x04001B5F RID: 7007
		DrownResponse = 21329,
		// Token: 0x04001B60 RID: 7008
		DrownEndTeleportResponse = 20620,
		// Token: 0x04001B61 RID: 7009
		MonsterDrownResponse = 22186,
		// Token: 0x04001B62 RID: 7010
		SceneLoadingFinishResponse = 28792,
		// Token: 0x04001B63 RID: 7011
		SitChairResponse = 15985,
		// Token: 0x04001B64 RID: 7012
		BeControlledDestroyResponse = 21659,
		// Token: 0x04001B65 RID: 7013
		ChangeDataLayerFinishResponse = 20475,
		// Token: 0x04001B66 RID: 7014
		MoveSceneItemResetPositionResponse = 20105,
		// Token: 0x04001B67 RID: 7015
		HookLockPointResponse = 24512,
		// Token: 0x04001B68 RID: 7016
		CheckGearResponse = 26915,
		// Token: 0x04001B69 RID: 7017
		SceneItemStateResponse = 17526,
		// Token: 0x04001B6A RID: 7018
		MaterialResponse = 26538,
		// Token: 0x04001B6B RID: 7019
		CommonOrganResetTimeResponse = 18085,
		// Token: 0x04001B6C RID: 7020
		TargetGearHitResponse = 15616,
		// Token: 0x04001B6D RID: 7021
		ThrowDamageResponse = 26400,
		// Token: 0x04001B6E RID: 7022
		GetRewardTreasureBoxResponse = 23102,
		// Token: 0x04001B6F RID: 7023
		MobileButtonSettingUpdateResponse = 22058,
		// Token: 0x04001B70 RID: 7024
		LanguageSettingUpdateResponse = 23816,
		// Token: 0x04001B71 RID: 7025
		ShopInfoResponse = 28926,
		// Token: 0x04001B72 RID: 7026
		ShopBuyResponse = 27294,
		// Token: 0x04001B73 RID: 7027
		ShopUpdateResponse = 27292,
		// Token: 0x04001B74 RID: 7028
		SneakFinishResponse = 25091,
		// Token: 0x04001B75 RID: 7029
		SpecialItemEquipResponse = 17256,
		// Token: 0x04001B76 RID: 7030
		SpecialItemUnEquipResponse = 24255,
		// Token: 0x04001B77 RID: 7031
		SynthesisInfoResponse = 19842,
		// Token: 0x04001B78 RID: 7032
		SynthesisItemResponse = 24774,
		// Token: 0x04001B79 RID: 7033
		SynthesisLevelRewardResponse = 21274,
		// Token: 0x04001B7A RID: 7034
		SynthesisFormulaUnlockResponse = 23763,
		// Token: 0x04001B7B RID: 7035
		TeleportDataResponse = 24608,
		// Token: 0x04001B7C RID: 7036
		TeleportTransferResponse = 29947,
		// Token: 0x04001B7D RID: 7037
		TeleportFinishResponse = 24577,
		// Token: 0x04001B7E RID: 7038
		UnOpenedAreaPullbackResponse = 23277,
		// Token: 0x04001B7F RID: 7039
		RemoveTemporaryTeleportResponse = 28735,
		// Token: 0x04001B80 RID: 7040
		TeleportToTargetResponse = 17547,
		// Token: 0x04001B81 RID: 7041
		ThirdPartyShareResponse = 20634,
		// Token: 0x04001B82 RID: 7042
		RTimeStopResponse = 24814,
		// Token: 0x04001B83 RID: 7043
		RTimeStopInstResponse = 15227,
		// Token: 0x04001B84 RID: 7044
		TimelineTraceStartResponse = 21855,
		// Token: 0x04001B85 RID: 7045
		TimelineTraceControlResponse = 23257,
		// Token: 0x04001B86 RID: 7046
		TimelineTraceExitResponse = 16487,
		// Token: 0x04001B87 RID: 7047
		TimeCheckResponse = 28031,
		// Token: 0x04001B88 RID: 7048
		TowerResponse = 21047,
		// Token: 0x04001B89 RID: 7049
		TowerSeasonUpdateResponse = 21534,
		// Token: 0x04001B8A RID: 7050
		TowerFormationRecommendResponse = 26594,
		// Token: 0x04001B8B RID: 7051
		TowerRewardResponse = 16113,
		// Token: 0x04001B8C RID: 7052
		TowerStartResponse = 27533,
		// Token: 0x04001B8D RID: 7053
		TowerResetResponse = 26793,
		// Token: 0x04001B8E RID: 7054
		TowerApplyFloorDataResponse = 18513,
		// Token: 0x04001B8F RID: 7055
		TowerGuideActivityRewardResponse = 22907,
		// Token: 0x04001B90 RID: 7056
		TowerGuideActivityInfoResponse = 23078,
		// Token: 0x04001B91 RID: 7057
		TurntableCompleteResponse = 18435,
		// Token: 0x04001B92 RID: 7058
		TutorialInfoResponse = 22904,
		// Token: 0x04001B93 RID: 7059
		TutorialReceiveResponse = 18170,
		// Token: 0x04001B94 RID: 7060
		TutorialUnlockResponse = 26280,
		// Token: 0x04001B95 RID: 7061
		WeaponLevelUpResponse = 17061,
		// Token: 0x04001B96 RID: 7062
		WeaponBreachResponse = 26514,
		// Token: 0x04001B97 RID: 7063
		WeaponResonUpResponse = 21310,
		// Token: 0x04001B98 RID: 7064
		WorldLevelDownResponse = 28190,
		// Token: 0x04001B99 RID: 7065
		WorldLevelRegainResponse = 23479,
		// Token: 0x04001B9A RID: 7066
		WorldEnterPermissionsResponse = 24472,
		// Token: 0x04001B9B RID: 7067
		ApplyJoinWorldResponse = 15396,
		// Token: 0x04001B9C RID: 7068
		AgreeJoinResultResponse = 24721,
		// Token: 0x04001B9D RID: 7069
		LobbyListResponse = 18705,
		// Token: 0x04001B9E RID: 7070
		LobbyQueryPlayersResponse = 25999,
		// Token: 0x04001B9F RID: 7071
		LeaveWorldTeamResponse = 16579,
		// Token: 0x04001BA0 RID: 7072
		KickWorldTeamResponse = 26682,
		// Token: 0x04001BA1 RID: 7073
		EntityBeamReceiveResponse = 27467,
		// Token: 0x04001BA2 RID: 7074
		AttachEntityResponse = 18874,
		// Token: 0x04001BA3 RID: 7075
		EntityPatrolAddTagResponse = 21942,
		// Token: 0x04001BA4 RID: 7076
		LongShanTaskRewardResponse = 25642,
		// Token: 0x04001BA5 RID: 7077
		EntityAccessRangeResponse = 15094,
		// Token: 0x04001BA6 RID: 7078
		PlayerAccessRangeResponse = 29671,
		// Token: 0x04001BA7 RID: 7079
		RoguelikePopularEntriesInfoResponse = 29994,
		// Token: 0x04001BA8 RID: 7080
		RoguelikePopularEntriesChangeResponse = 20560,
		// Token: 0x04001BA9 RID: 7081
		HookLockPointFinishResponse = 27227,
		// Token: 0x04001BAA RID: 7082
		BuildingLevelUpResponse = 26925,
		// Token: 0x04001BAB RID: 7083
		RoleTrainResponse = 22364,
		// Token: 0x04001BAC RID: 7084
		AcceptEntrustResponse = 21620,
		// Token: 0x04001BAD RID: 7085
		InvestResponse = 17799,
		// Token: 0x04001BAE RID: 7086
		TrackMoonEntrustDataResponse = 19470,
		// Token: 0x04001BAF RID: 7087
		TrackMoonRoleDataResponse = 20611,
		// Token: 0x04001BB0 RID: 7088
		RunTurntableActivityResponse = 15518,
		// Token: 0x04001BB1 RID: 7089
		TrackMoonBuildingDataResponse = 15600,
		// Token: 0x04001BB2 RID: 7090
		BuildingUnLockResponse = 28422,
		// Token: 0x04001BB3 RID: 7091
		BossRushClaimRewardResponse = 23469,
		// Token: 0x04001BB4 RID: 7092
		BossRushSettlementResponse = 25837,
		// Token: 0x04001BB5 RID: 7093
		SceneModeChangeFinishResponse = 20026,
		// Token: 0x04001BB6 RID: 7094
		RoguelikeTrialRoleInfoResponse = 15508,
		// Token: 0x04001BB7 RID: 7095
		PhotoMemoryResponse = 22761,
		// Token: 0x04001BB8 RID: 7096
		PhotoMemoryRewardResponse = 15832,
		// Token: 0x04001BB9 RID: 7097
		SceneItemSetPosSenderResponse = 19612,
		// Token: 0x04001BBA RID: 7098
		TraceEntityPosResponse = 16641,
		// Token: 0x04001BBB RID: 7099
		CombatMessagePrefixInfoResponse = 16765,
		// Token: 0x04001BBC RID: 7100
		CombatMessagePostInfoResponse = 29434,
		// Token: 0x04001BBD RID: 7101
		TrackMoonTargetRewardResponse = 17100,
		// Token: 0x04001BBE RID: 7102
		FsmStateBehaviorResponse = 21048,
		// Token: 0x04001BBF RID: 7103
		FsmPlayMontageResponse = 25141,
		// Token: 0x04001BC0 RID: 7104
		RTimeStopAnimResponse = 29834,
		// Token: 0x04001BC1 RID: 7105
		RolePropResponse = 16928,
		// Token: 0x04001BC2 RID: 7106
		TrackMoonSettleResponse = 27600,
		// Token: 0x04001BC3 RID: 7107
		TrackMoonIllustratedResponse = 24278,
		// Token: 0x04001BC4 RID: 7108
		TowerDefenceInstanceRewardResponse = 20681,
		// Token: 0x04001BC5 RID: 7109
		TowerDefenceScoreRewardResponse = 15411,
		// Token: 0x04001BC6 RID: 7110
		FlowTeleportToPlotPosResponse = 28245,
		// Token: 0x04001BC7 RID: 7111
		ConnectorConnectEntityResponse = 15177,
		// Token: 0x04001BC8 RID: 7112
		BeControlledEntityHoverResponse = 27351,
		// Token: 0x04001BC9 RID: 7113
		InitRangeResponse = 18075,
		// Token: 0x04001BCA RID: 7114
		TrackMoonActivityRewardResponse = 24303,
		// Token: 0x04001BCB RID: 7115
		TimePointActivityRewardResponse = 18317,
		// Token: 0x04001BCC RID: 7116
		CircumFluenceTaskRewardResponse = 21293,
		// Token: 0x04001BCD RID: 7117
		GameplayCueResponse = 15031,
		// Token: 0x04001BCE RID: 7118
		SceneItemStopResponse = 20130,
		// Token: 0x04001BCF RID: 7119
		RoguelikeRoleRoomSelectResponse = 15944,
		// Token: 0x04001BD0 RID: 7120
		SecFBRoundStartFlowResponse = 26201,
		// Token: 0x04001BD1 RID: 7121
		SecGetReportData2FlowResponse = 20463,
		// Token: 0x04001BD2 RID: 7122
		SecFBRoundEndFlowReportResponse = 16776,
		// Token: 0x04001BD3 RID: 7123
		SecRoleFightFlowResponse = 29975,
		// Token: 0x04001BD4 RID: 7124
		SecWorldInfoFlowResponse = 21356,
		// Token: 0x04001BD5 RID: 7125
		SecWorldStartFlowResponse = 17814,
		// Token: 0x04001BD6 RID: 7126
		AwakeDynamicPortalResponse = 17133,
		// Token: 0x04001BD7 RID: 7127
		GachaPoolDetailResponse = 18488,
		// Token: 0x04001BD8 RID: 7128
		SecWorldSEndFlowResponse = 17703,
		// Token: 0x04001BD9 RID: 7129
		OpenSystemBoardResultResponse = 23490,
		// Token: 0x04001BDA RID: 7130
		SceneItemMoveTargetResponse = 23917,
		// Token: 0x04001BDB RID: 7131
		TrackMoonBuildFlowResponse = 22345,
		// Token: 0x04001BDC RID: 7132
		CorniceMeetingRewardResponse = 18253,
		// Token: 0x04001BDD RID: 7133
		TraceMoonPhaseRewardResponse = 17223,
		// Token: 0x04001BDE RID: 7134
		LevelPlaySwitchSportModeResponse = 28737,
		// Token: 0x04001BDF RID: 7135
		PlayerPsnInfoGetResponse = 21086,
		// Token: 0x04001BE0 RID: 7136
		PsnSettingUpdateResponse = 19977,
		// Token: 0x04001BE1 RID: 7137
		PsnSettingResponse = 23928,
		// Token: 0x04001BE2 RID: 7138
		RiskHarvestScoreRewardResponse = 27437,
		// Token: 0x04001BE3 RID: 7139
		ItemDisuseResponse = 28866,
		// Token: 0x04001BE4 RID: 7140
		PhantomBatchRefiningResponse = 18643,
		// Token: 0x04001BE5 RID: 7141
		RiskHarvestInstRewardResponse = 25323,
		// Token: 0x04001BE6 RID: 7142
		PassPortalResponse = 27969,
		// Token: 0x04001BE7 RID: 7143
		EnrichmentAreaResponse = 27649,
		// Token: 0x04001BE8 RID: 7144
		RiskHarvestBuffUnlockRewardResponse = 27680,
		// Token: 0x04001BE9 RID: 7145
		RiskHarvestBuffCountRewardResponse = 25669,
		// Token: 0x04001BEA RID: 7146
		BlackCoastThemeTaskRewardResponse = 20483,
		// Token: 0x04001BEB RID: 7147
		BlackCoastThemeActiveRewardResponse = 28050,
		// Token: 0x04001BEC RID: 7148
		PlayerCreatePsnSessionResponse = 16742,
		// Token: 0x04001BED RID: 7149
		RenjuResetResponse = 24055,
		// Token: 0x04001BEE RID: 7150
		CorniceChallengeTransResponse = 28762,
		// Token: 0x04001BEF RID: 7151
		GameplayTagResponse = 16302,
		// Token: 0x04001BF0 RID: 7152
		ExecuteQteResponse = 20100,
		// Token: 0x04001BF1 RID: 7153
		RiskHarvestSettleResponse = 25343,
		// Token: 0x04001BF2 RID: 7154
		MingSuHandRewardResponse = 22679,
		// Token: 0x04001BF3 RID: 7155
		SubmitAwakeAndLoadEntityNodeResponse = 16025,
		// Token: 0x04001BF4 RID: 7156
		RoguelikeRoleInstStartResponse = 18259,
		// Token: 0x04001BF5 RID: 7157
		RoguelikeBossInstStartResponse = 21669,
		// Token: 0x04001BF6 RID: 7158
		PreheatSignRewardResponse = 27792,
		// Token: 0x04001BF7 RID: 7159
		PreheatSignSurveyInfoResponse = 20369,
		// Token: 0x04001BF8 RID: 7160
		DarkCoastInfoResponse = 20081,
		// Token: 0x04001BF9 RID: 7161
		InputSettingResponse = 20083,
		// Token: 0x04001BFA RID: 7162
		InputSettingUpdateResponse = 20916,
		// Token: 0x04001BFB RID: 7163
		RoguelikeWriteCatRewardResponse = 22912,
		// Token: 0x04001BFC RID: 7164
		ConnectorCanConnectResponse = 17977,
		// Token: 0x04001BFD RID: 7165
		ScratchCardRewardResponse = 15806,
		// Token: 0x04001BFE RID: 7166
		TeleportDungeonActionResponse = 18689,
		// Token: 0x04001BFF RID: 7167
		SubmitWalkingPatternPointResponse = 25667,
		// Token: 0x04001C00 RID: 7168
		RoguelikeWriteCatBossRewardResponse = 23662,
		// Token: 0x04001C01 RID: 7169
		RoguelikeWriteCatLevelPlayRewardResponse = 22369,
		// Token: 0x04001C02 RID: 7170
		PlayerPsnBlockListResponse = 17327,
		// Token: 0x04001C03 RID: 7171
		VacuumCleanerResponse = 22664,
		// Token: 0x04001C04 RID: 7172
		BossRushChooseBuffResponse = 19084,
		// Token: 0x04001C05 RID: 7173
		BossRushBuffChooseResultResponse = 24781,
		// Token: 0x04001C06 RID: 7174
		JoinSceneNotifyConfirmResponse = 17440,
		// Token: 0x04001C07 RID: 7175
		MailBindRewardResponse = 27161,
		// Token: 0x04001C08 RID: 7176
		MailBindInfoResponse = 24222,
		// Token: 0x04001C09 RID: 7177
		MailBindResponse = 28055,
		// Token: 0x04001C0A RID: 7178
		HookLockPointExitResponse = 28458,
		// Token: 0x04001C0B RID: 7179
		VehicleResponse = 23682,
		// Token: 0x04001C0C RID: 7180
		PullingFoundationResponse = 21229,
		// Token: 0x04001C0D RID: 7181
		AddTreasureBoxSlotResponse = 16859,
		// Token: 0x04001C0E RID: 7182
		RemoveTreasureBoxSlotResponse = 24211,
		// Token: 0x04001C0F RID: 7183
		UseSoundBoxSkillResponse = 22512,
		// Token: 0x04001C10 RID: 7184
		AddTemporaryTeleportResponse = 20601,
		// Token: 0x04001C11 RID: 7185
		BossRushLevelScoreRewardResponse = 17469,
		// Token: 0x04001C12 RID: 7186
		EquipSkinTakeOnResponse = 26442,
		// Token: 0x04001C13 RID: 7187
		EquipSkinUnLoadResponse = 15525,
		// Token: 0x04001C14 RID: 7188
		SubmitPhotoNodeResponse = 23527,
		// Token: 0x04001C15 RID: 7189
		RogueWhiteCatLimitedRewardResponse = 25823,
		// Token: 0x04001C16 RID: 7190
		ScratchCardActivityInfoResponse = 24195,
		// Token: 0x04001C17 RID: 7191
		QuestReadyForGiveUpResponse = 19178,
		// Token: 0x04001C18 RID: 7192
		RogueWhiteCatRecordResponse = 27210,
		// Token: 0x04001C19 RID: 7193
		SetAlertUiVisibleResponse = 26471,
		// Token: 0x04001C1A RID: 7194
		CombineEntitiesResponse = 16600,
		// Token: 0x04001C1B RID: 7195
		GiftPackPreviewResponse = 29486,
		// Token: 0x04001C1C RID: 7196
		LastBigSceneMiniMapInfoResponse = 20403,
		// Token: 0x04001C1D RID: 7197
		DissolveCombineRelationResponse = 20084,
		// Token: 0x04001C1E RID: 7198
		ExploreSkillCustomResponse = 25414,
		// Token: 0x04001C1F RID: 7199
		AchievementUpdateResponse = 22115,
		// Token: 0x04001C20 RID: 7200
		SeamlessTeleportResponse = 15205,
		// Token: 0x04001C21 RID: 7201
		RogueBlackFlowerResponse = 19376,
		// Token: 0x04001C22 RID: 7202
		UpdateSceneGroupDataResponse = 19725,
		// Token: 0x04001C23 RID: 7203
		MowTowerSettlementResponse = 27490,
		// Token: 0x04001C24 RID: 7204
		MowTowerLevelsRewardResponse = 17233,
		// Token: 0x04001C25 RID: 7205
		RoleSkinChangeResponse = 27229,
		// Token: 0x04001C26 RID: 7206
		RoleSkinResponse = 15433,
		// Token: 0x04001C27 RID: 7207
		PhantomMusicUnlockResponse = 23502,
		// Token: 0x04001C28 RID: 7208
		PhantomMusicInfoResponse = 16334,
		// Token: 0x04001C29 RID: 7209
		PhantomMusicSwitchResponse = 15618,
		// Token: 0x04001C2A RID: 7210
		UpdateSceneItemBlackboardResponse = 19386,
		// Token: 0x04001C2B RID: 7211
		VehicleChangePassengerResponse = 21531,
		// Token: 0x04001C2C RID: 7212
		VehicleRemovePassengerResponse = 20287,
		// Token: 0x04001C2D RID: 7213
		LevelSequenceFrameEventActionResponse = 20164,
		// Token: 0x04001C2E RID: 7214
		SimpleTrackReportResponse = 23444,
		// Token: 0x04001C2F RID: 7215
		PlayerVoxelEnvResponse = 15604,
		// Token: 0x04001C30 RID: 7216
		MapTravelFullRewardResponse = 18348,
		// Token: 0x04001C31 RID: 7217
		MapTravelLevelUpResponse = 26622,
		// Token: 0x04001C32 RID: 7218
		SpringSignDrawRoleResponse = 25860,
		// Token: 0x04001C33 RID: 7219
		LevelPlayVarResponse = 21256,
		// Token: 0x04001C34 RID: 7220
		MaterialReplaceResponse = 17042,
		// Token: 0x04001C35 RID: 7221
		ExploreProgressRewardResponse = 28094,
		// Token: 0x04001C36 RID: 7222
		SpringSignDrawRewardResponse = 23619,
		// Token: 0x04001C37 RID: 7223
		EntityCameraAlertResponse = 21236,
		// Token: 0x04001C38 RID: 7224
		ThroughTrainResponse = 29273,
		// Token: 0x04001C39 RID: 7225
		CheckUseSoundBoxSkillResponse = 18835,
		// Token: 0x04001C3A RID: 7226
		FarmGoldPointResponse = 27220,
		// Token: 0x04001C3B RID: 7227
		FarmGoldLevelPlayResponse = 26415,
		// Token: 0x04001C3C RID: 7228
		FarmGoldLevelDiffResponse = 26855,
		// Token: 0x04001C3D RID: 7229
		SpringSignSkinRewardResponse = 26418,
		// Token: 0x04001C3E RID: 7230
		FarmGoldResultResponse = 24579,
		// Token: 0x04001C3F RID: 7231
		FlowSeqSetPlayerPosResponse = 16827,
		// Token: 0x04001C40 RID: 7232
		SplineMoveResponse = 26766,
		// Token: 0x04001C41 RID: 7233
		LevelPlayStateResponse = 29313,
		// Token: 0x04001C42 RID: 7234
		PlayerHeadResponse = 22413,
		// Token: 0x04001C43 RID: 7235
		EntityWalkingPatternFinishResponse = 23002,
		// Token: 0x04001C44 RID: 7236
		QueryOnlinePlayersAreaResponse = 21413,
		// Token: 0x04001C45 RID: 7237
		MapTravelTaskRewardResponse = 28036,
		// Token: 0x04001C46 RID: 7238
		MapTravelSoarRewardResponse = 24818,
		// Token: 0x04001C47 RID: 7239
		FishingInfoResponse = 22673,
		// Token: 0x04001C48 RID: 7240
		FishingIllustratedRewardResponse = 27309,
		// Token: 0x04001C49 RID: 7241
		FishingCabinPutResponse = 27464,
		// Token: 0x04001C4A RID: 7242
		FishingQuickSellPreviewResponse = 25935,
		// Token: 0x04001C4B RID: 7243
		FishingQuickSellResponse = 24478,
		// Token: 0x04001C4C RID: 7244
		FishingSellPreviewResponse = 23795,
		// Token: 0x04001C4D RID: 7245
		FishingSellResponse = 23025,
		// Token: 0x04001C4E RID: 7246
		FishingSailingResponse = 20883,
		// Token: 0x04001C4F RID: 7247
		FishingEntrustHandInResponse = 28305,
		// Token: 0x04001C50 RID: 7248
		FishingEntrustTraceResponse = 29628,
		// Token: 0x04001C51 RID: 7249
		FishingEntrustRefreshResponse = 16187,
		// Token: 0x04001C52 RID: 7250
		FishingShipFixResponse = 21934,
		// Token: 0x04001C53 RID: 7251
		FishingTechLevelUpResponse = 24459,
		// Token: 0x04001C54 RID: 7252
		AccessPathConfigResponse = 22626,
		// Token: 0x04001C55 RID: 7253
		PlayerGameTokenResponse = 26225,
		// Token: 0x04001C56 RID: 7254
		RenjuExitMatchedActionResponse = 26468,
		// Token: 0x04001C57 RID: 7255
		TrialRoleSkinRewardResponse = 25081,
		// Token: 0x04001C58 RID: 7256
		LevelPlayStateListResponse = 24664,
		// Token: 0x04001C59 RID: 7257
		SpringSignPhotoRewardResponse = 20917,
		// Token: 0x04001C5A RID: 7258
		PhantomEquipGroupInfosResponse = 17071,
		// Token: 0x04001C5B RID: 7259
		AddPhantomEquipGroupResponse = 17340,
		// Token: 0x04001C5C RID: 7260
		DeletePhantomEquipGroupResponse = 16721,
		// Token: 0x04001C5D RID: 7261
		ChangePhantomEquipGroupNameResponse = 16060,
		// Token: 0x04001C5E RID: 7262
		TopPhantomEquipGroupResponse = 24824,
		// Token: 0x04001C5F RID: 7263
		FishingCompleteResponse = 23801,
		// Token: 0x04001C60 RID: 7264
		TeleportFlowEndResponse = 15441,
		// Token: 0x04001C61 RID: 7265
		RiskHarvestStarRewardResponse = 17366,
		// Token: 0x04001C62 RID: 7266
		PhantomFetterRecommendResponse = 25672,
		// Token: 0x04001C63 RID: 7267
		PhantomAttrRecommendResponse = 29590,
		// Token: 0x04001C64 RID: 7268
		FishingEntrustAcceptResponse = 18952,
		// Token: 0x04001C65 RID: 7269
		FishingExitResponse = 15747,
		// Token: 0x04001C66 RID: 7270
		FishingShipSkinChangeResponse = 21884,
		// Token: 0x04001C67 RID: 7271
		FishingPointInfoResponse = 19378,
		// Token: 0x04001C68 RID: 7272
		FishingCageInfoResponse = 16693,
		// Token: 0x04001C69 RID: 7273
		FishingHandInResponse = 18677,
		// Token: 0x04001C6A RID: 7274
		FishingSkillBombResponse = 16903,
		// Token: 0x04001C6B RID: 7275
		FishingSkillBaitResponse = 27026,
		// Token: 0x04001C6C RID: 7276
		FishingSkillTeleportResponse = 18913,
		// Token: 0x04001C6D RID: 7277
		RogueWeeklyRewardResponse = 23902,
		// Token: 0x04001C6E RID: 7278
		RogueWeeklyGotoNextRoomResponse = 29783,
		// Token: 0x04001C6F RID: 7279
		SlashAndTowerInfoResponse = 29704,
		// Token: 0x04001C70 RID: 7280
		SlashAndTowerScoreRewardResponse = 18302,
		// Token: 0x04001C71 RID: 7281
		EndLessHistoryResponse = 29560,
		// Token: 0x04001C72 RID: 7282
		SlashAndTowerSaveRecordResponse = 27817,
		// Token: 0x04001C73 RID: 7283
		SlashAndTowerResetResponse = 29466,
		// Token: 0x04001C74 RID: 7284
		SlashAndTowerRecommendResponse = 23623,
		// Token: 0x04001C75 RID: 7285
		BossRushTaskRewardResponse = 24143,
		// Token: 0x04001C76 RID: 7286
		UsePhantomEquipGroupResponse = 19113,
		// Token: 0x04001C77 RID: 7287
		FishingActivityLimitRewardResponse = 23099,
		// Token: 0x04001C78 RID: 7288
		FishingActivityMilestoneRewardResponse = 21498,
		// Token: 0x04001C79 RID: 7289
		TeamParkourRewardResponse = 28854,
		// Token: 0x04001C7A RID: 7290
		RogueWeeklyResultResponse = 20631,
		// Token: 0x04001C7B RID: 7291
		RogueWeeklyOptionSelectResponse = 15921,
		// Token: 0x04001C7C RID: 7292
		ThroughTrainFinishViewResponse = 19302,
		// Token: 0x04001C7D RID: 7293
		ActivityPreOpenResponse = 26181,
		// Token: 0x04001C7E RID: 7294
		LstBattleRecordResponse = 21300,
		// Token: 0x04001C7F RID: 7295
		RogueWeeklyStartResponse = 18980,
		// Token: 0x04001C80 RID: 7296
		FishingTeleportToBoatResponse = 21519,
		// Token: 0x04001C81 RID: 7297
		TowerDefenceRandListResponse = 29510,
		// Token: 0x04001C82 RID: 7298
		TowerDefenceRankShowNameResponse = 17528,
		// Token: 0x04001C83 RID: 7299
		BabelTowerTaskRewardResponse = 16607,
		// Token: 0x04001C84 RID: 7300
		BabelTowerDailyTaskRewardResponse = 23540,
		// Token: 0x04001C85 RID: 7301
		ResetBabelTowerLevelResponse = 27850,
		// Token: 0x04001C86 RID: 7302
		BabelTowerSettlementResponse = 22271,
		// Token: 0x04001C87 RID: 7303
		RogueWeeklyBlackFlowerResponse = 21684,
		// Token: 0x04001C88 RID: 7304
		SceneSubLevelsResponse = 22498,
		// Token: 0x04001C89 RID: 7305
		PlayerTitleResponse = 23404,
		// Token: 0x04001C8A RID: 7306
		ChangePlayerTitleResponse = 23826,
		// Token: 0x04001C8B RID: 7307
		AwakeItemVehicleResponse = 16446,
		// Token: 0x04001C8C RID: 7308
		SelectBabelActivityDeTermResponse = 17683,
		// Token: 0x04001C8D RID: 7309
		GravityFlipInteractResponse = 19707,
		// Token: 0x04001C8E RID: 7310
		AbyssChallengeUnlockResponse = 21147,
		// Token: 0x04001C8F RID: 7311
		AbyssChallengeQuitResponse = 25360,
		// Token: 0x04001C90 RID: 7312
		AbyssLikeResponse = 21792,
		// Token: 0x04001C91 RID: 7313
		AbyssChallengeGotoNextRoomResponse = 27237,
		// Token: 0x04001C92 RID: 7314
		AbyssRewardResponse = 26593,
		// Token: 0x04001C93 RID: 7315
		AbyssLittleRoleLevelUpResponse = 22337,
		// Token: 0x04001C94 RID: 7316
		AbyssPluginPutResponse = 23547,
		// Token: 0x04001C95 RID: 7317
		AbyssPluginSynthesisResponse = 20432,
		// Token: 0x04001C96 RID: 7318
		AbyssRankListResponse = 25849,
		// Token: 0x04001C97 RID: 7319
		AbyssShowNameResponse = 18840,
		// Token: 0x04001C98 RID: 7320
		AbyssReviveCharacterResponse = 17377,
		// Token: 0x04001C99 RID: 7321
		SceneItemMoveSplineResponse = 24723,
		// Token: 0x04001C9A RID: 7322
		RacingBetsLegMatchInfoResponse = 29075,
		// Token: 0x04001C9B RID: 7323
		RacingBetsMatchInfoResponse = 27440,
		// Token: 0x04001C9C RID: 7324
		RacingBetsPlayerInfoResponse = 21541,
		// Token: 0x04001C9D RID: 7325
		RacingBetsRankResponse = 21901,
		// Token: 0x04001C9E RID: 7326
		RacingBetsGearResponse = 29611,
		// Token: 0x04001C9F RID: 7327
		RacingBetsTaskResponse = 28070,
		// Token: 0x04001CA0 RID: 7328
		RacingBetMatchRoundResponse = 19125,
		// Token: 0x04001CA1 RID: 7329
		RacingBetsBulletScreenResponse = 19809,
		// Token: 0x04001CA2 RID: 7330
		RacingBetsTaskRewardResponse = 20940,
		// Token: 0x04001CA3 RID: 7331
		RogueWeeklyLastInfoResponse = 16590,
		// Token: 0x04001CA4 RID: 7332
		RacingBetsUpdateOddsResponse = 19078,
		// Token: 0x04001CA5 RID: 7333
		ExploreActivityTaskRewardResponse = 19374,
		// Token: 0x04001CA6 RID: 7334
		PhantomPolishResponse = 25461,
		// Token: 0x04001CA7 RID: 7335
		TowerDefenceSelfPassResponse = 28825,
		// Token: 0x04001CA8 RID: 7336
		AbyssSelfPassResponse = 15039,
		// Token: 0x04001CA9 RID: 7337
		RogueResTalentSkillLevelResponse = 15004,
		// Token: 0x04001CAA RID: 7338
		RogueResEndingRewardResponse = 17493,
		// Token: 0x04001CAB RID: 7339
		RogueResTaskAwardResponse = 29739,
		// Token: 0x04001CAC RID: 7340
		RogueResIllustrationAwardResponse = 24417,
		// Token: 0x04001CAD RID: 7341
		AvignonRewardResponse = 26226,
		// Token: 0x04001CAE RID: 7342
		RogueResMoveResponse = 15952,
		// Token: 0x04001CAF RID: 7343
		RogueResGridEventResponse = 28230,
		// Token: 0x04001CB0 RID: 7344
		RogueResOpDoneResponse = 16584,
		// Token: 0x04001CB1 RID: 7345
		RogueResInstStartResponse = 29103,
		// Token: 0x04001CB2 RID: 7346
		RogueResLastInstInfoResponse = 18335,
		// Token: 0x04001CB3 RID: 7347
		RacingBetsGearRefundResponse = 17259,
		// Token: 0x04001CB4 RID: 7348
		SummonRandomResponse = 17070,
		// Token: 0x04001CB5 RID: 7349
		RogueResInstResultResponse = 28357,
		// Token: 0x04001CB6 RID: 7350
		StopMoveSplineResponse = 24675,
		// Token: 0x04001CB7 RID: 7351
		FlySkinWearResponse = 25179,
		// Token: 0x04001CB8 RID: 7352
		FlySkinWearAllRoleResponse = 15632,
		// Token: 0x04001CB9 RID: 7353
		RogueResGotoNextRoomResponse = 16110,
		// Token: 0x04001CBA RID: 7354
		FlySkinUnLoadResponse = 29892,
		// Token: 0x04001CBB RID: 7355
		DangoMonopolyDiceResponse = 24491,
		// Token: 0x04001CBC RID: 7356
		DangoMonopolyGridRewardResponse = 18776,
		// Token: 0x04001CBD RID: 7357
		DangoMonopolyBoardRewardResponse = 26889,
		// Token: 0x04001CBE RID: 7358
		DangoMonopolyTaskRewardResponse = 20830,
		// Token: 0x04001CBF RID: 7359
		RacingBetMatchResponse = 18394,
		// Token: 0x04001CC0 RID: 7360
		LoadingLevelAreaResponse = 20507,
		// Token: 0x04001CC1 RID: 7361
		DangoMonopolyNextBoardResponse = 18128,
		// Token: 0x04001CC2 RID: 7362
		AddChapterResultResponse = 19681,
		// Token: 0x04001CC3 RID: 7363
		ChapterResultRewardResponse = 15304,
		// Token: 0x04001CC4 RID: 7364
		InspirationUnlockChoiceResponse = 23610,
		// Token: 0x04001CC5 RID: 7365
		ActivityResultRewardResponse = 18003,
		// Token: 0x04001CC6 RID: 7366
		ScheduleRewardResponse = 24763,
		// Token: 0x04001CC7 RID: 7367
		FlySkinAllUnLoadResponse = 25150,
		// Token: 0x04001CC8 RID: 7368
		RogueResChangeFormationResponse = 23844,
		// Token: 0x04001CC9 RID: 7369
		RegressBonusResponse = 23806,
		// Token: 0x04001CCA RID: 7370
		RegressTaskResponse = 29284,
		// Token: 0x04001CCB RID: 7371
		ConfirmQuestResourceResponse = 24175,
		// Token: 0x04001CCC RID: 7372
		ConsumptiveRewardResponse = 25276,
		// Token: 0x04001CCD RID: 7373
		LinkageRewardResponse = 23303,
		// Token: 0x04001CCE RID: 7374
		RacingBetMatchActionResponse = 23348,
		// Token: 0x04001CCF RID: 7375
		RacingBetMatchRoundActionResponse = 24685,
		// Token: 0x04001CD0 RID: 7376
		RogueResSwitchFormationResponse = 22098,
		// Token: 0x04001CD1 RID: 7377
		RacingBetMatchInfoResponse = 23023,
		// Token: 0x04001CD2 RID: 7378
		PhantomBattleTaskRewardResponse = 27700,
		// Token: 0x04001CD3 RID: 7379
		PhantomBattleMasterLevelRewardResponse = 22561,
		// Token: 0x04001CD4 RID: 7380
		PhantomBattleBadgeRewardResponse = 24270,
		// Token: 0x04001CD5 RID: 7381
		PhantomBattleCardOutLookUpResponse = 28304,
		// Token: 0x04001CD6 RID: 7382
		PhantomBattleCardRewardResponse = 25254,
		// Token: 0x04001CD7 RID: 7383
		PhantomBattleRoleRewardResponse = 26978,
		// Token: 0x04001CD8 RID: 7384
		PhantomBattleCardGroupAddResponse = 16063,
		// Token: 0x04001CD9 RID: 7385
		PhantomBattleCardGroupUpdateResponse = 19388,
		// Token: 0x04001CDA RID: 7386
		PhantomBattleCardGroupNameResponse = 26141,
		// Token: 0x04001CDB RID: 7387
		PhantomBattleDealCardReplaceResponse = 29228,
		// Token: 0x04001CDC RID: 7388
		PhantomBattleEnterSlotResponse = 16311,
		// Token: 0x04001CDD RID: 7389
		PhantomBattleEvolveResponse = 20416,
		// Token: 0x04001CDE RID: 7390
		PhantomBattleBackLibraryResponse = 15743,
		// Token: 0x04001CDF RID: 7391
		PhantomBattleRoundOverResponse = 18522,
		// Token: 0x04001CE0 RID: 7392
		PhantomBattleSlotInsteadResponse = 17240,
		// Token: 0x04001CE1 RID: 7393
		BirthDayCardRoleResponse = 22249,
		// Token: 0x04001CE2 RID: 7394
		BirthDayRewardResponse = 22398,
		// Token: 0x04001CE3 RID: 7395
		DirectTrainInfoResponse = 19087,
		// Token: 0x04001CE4 RID: 7396
		RegressQuestionOpenResponse = 22169,
		// Token: 0x04001CE5 RID: 7397
		PhantomBattleLeaveSlotResponse = 25415,
		// Token: 0x04001CE6 RID: 7398
		PhantomBattleSelectTargetResponse = 24690,
		// Token: 0x04001CE7 RID: 7399
		ConsumptiveActivityInfoResponse = 18014,
		// Token: 0x04001CE8 RID: 7400
		PhantomBattleCardRoleSkillResponse = 18955,
		// Token: 0x04001CE9 RID: 7401
		PhantomBattleCardSkillResponse = 26492,
		// Token: 0x04001CEA RID: 7402
		SetQuestFocusModeResponse = 22593,
		// Token: 0x04001CEB RID: 7403
		CancelQuestFocusModeResponse = 28253,
		// Token: 0x04001CEC RID: 7404
		PhantomBattleNpcShowOverResponse = 15620,
		// Token: 0x04001CED RID: 7405
		PhantomBattleBvBLoadingFinishResponse = 29345,
		// Token: 0x04001CEE RID: 7406
		PhantomBattleStartResponse = 26552,
		// Token: 0x04001CEF RID: 7407
		AcceptFocusWaitQuestResponse = 23033,
		// Token: 0x04001CF0 RID: 7408
		PhantomBattleDiscardCardResponse = 25508,
		// Token: 0x04001CF1 RID: 7409
		NavigationFindPathResponse = 27703,
		// Token: 0x04001CF2 RID: 7410
		PhantomBattleCardGroupDeleteResponse = 25229,
		// Token: 0x04001CF3 RID: 7411
		QuestReviewInfoResponse = 25121,
		// Token: 0x04001CF4 RID: 7412
		NewbieCarnivalSwitchRoleResponse = 27062,
		// Token: 0x04001CF5 RID: 7413
		NewbieCarnivalAwardResponse = 19176,
		// Token: 0x04001CF6 RID: 7414
		PhantomBattleCardSelectResponse = 19276,
		// Token: 0x04001CF7 RID: 7415
		PhantomBattleCardTargetInfoResponse = 17636,
		// Token: 0x04001CF8 RID: 7416
		PhantomBattleCardRoleTargetInfoResponse = 20116,
		// Token: 0x04001CF9 RID: 7417
		PhantomBattleCardUnlockResponse = 23550,
		// Token: 0x04001CFA RID: 7418
		OccupyRewardResponse = 24387,
		// Token: 0x04001CFB RID: 7419
		SetQuestResourceStateResponse = 27184,
		// Token: 0x04001CFC RID: 7420
		LongShanScoreRewardResponse = 29191,
		// Token: 0x04001CFD RID: 7421
		BathChangeCameraResponse = 21598,
		// Token: 0x04001CFE RID: 7422
		BathPhotoResponse = 16666,
		// Token: 0x04001CFF RID: 7423
		FinishDownloadQuestResourceResponse = 19405,
		// Token: 0x04001D00 RID: 7424
		PhantomBattleBackSlotCardLibraryResponse = 24521,
		// Token: 0x04001D01 RID: 7425
		FloroRanchUnlockTechPointResponse = 18079,
		// Token: 0x04001D02 RID: 7426
		FloroRanchRewardTaskResponse = 24696,
		// Token: 0x04001D03 RID: 7427
		FloroRanchRewardMilestoneResponse = 24536,
		// Token: 0x04001D04 RID: 7428
		FloroRanchStartPlayResponse = 23655,
		// Token: 0x04001D05 RID: 7429
		FloroRanchSettleResponse = 29820,
		// Token: 0x04001D06 RID: 7430
		FloroRanchPlayNextDayResponse = 26348,
		// Token: 0x04001D07 RID: 7431
		FloroRanchPlayGachaResponse = 26388,
		// Token: 0x04001D08 RID: 7432
		FloroRanchPlayShopBuyResponse = 15480,
		// Token: 0x04001D09 RID: 7433
		FloroRanchPlayEventChoiceResponse = 21433,
		// Token: 0x04001D0A RID: 7434
		FloroRanchPlayTributeResponse = 27951,
		// Token: 0x04001D0B RID: 7435
		FloroRanchPlayUnlimitedModeResponse = 20504,
		// Token: 0x04001D0C RID: 7436
		KcpConvResponse = 3729,
		// Token: 0x04001D0D RID: 7437
		ActionOperationScreenSuccessResponse = 28397,
		// Token: 0x04001D0E RID: 7438
		PhantomBattleSelectReserveCardResponse = 27073,
		// Token: 0x04001D0F RID: 7439
		FloroRanchPlayRemoveUnitResponse = 16556,
		// Token: 0x04001D10 RID: 7440
		PhantomBattleSlotCardSkillResponse = 26700,
		// Token: 0x04001D11 RID: 7441
		ConstructTrapResponse = 23882,
		// Token: 0x04001D12 RID: 7442
		DeconstructTrapResponse = 20270,
		// Token: 0x04001D13 RID: 7443
		PhantomBattleReChallengeResponse = 25662,
		// Token: 0x04001D14 RID: 7444
		FloroRanchPlayRefreshShopResponse = 18191,
		// Token: 0x04001D15 RID: 7445
		FloroRanchPlayRefreshGachaResponse = 29452,
		// Token: 0x04001D16 RID: 7446
		PhantomBattleDebugInfoResponse = 17509,
		// Token: 0x04001D17 RID: 7447
		MoralePosResponse = 29731,
		// Token: 0x04001D18 RID: 7448
		RunTestResponse = 22000,
		// Token: 0x04001D19 RID: 7449
		PhantomSettingResponse = 29760,
		// Token: 0x04001D1A RID: 7450
		PhantomSettingUpdateResponse = 25467,
		// Token: 0x04001D1B RID: 7451
		PhantomBatchOperResponse = 25271,
		// Token: 0x04001D1C RID: 7452
		VehiclePlatformGetOnResponse = 18298,
		// Token: 0x04001D1D RID: 7453
		PolluteGridCellResponse = 19787,
		// Token: 0x04001D1E RID: 7454
		LifePointChallengeStartResponse = 22206,
		// Token: 0x04001D1F RID: 7455
		FloroRanchPlaySelectCardGroupResponse = 19257,
		// Token: 0x04001D20 RID: 7456
		SimpleCombatEntityDieResponse = 16558,
		// Token: 0x04001D21 RID: 7457
		MoraleTreasureBoxTraceResponse = 23584,
		// Token: 0x04001D22 RID: 7458
		MulAchievementReceiveResponse = 19770,
		// Token: 0x04001D23 RID: 7459
		MulRoguelikeWriteCatRewardResponse = 19677,
		// Token: 0x04001D24 RID: 7460
		MulRogueWeeklyRewardResponse = 28198,
		// Token: 0x04001D25 RID: 7461
		MulPhantomBattleMasterLevelRewardResponse = 15639,
		// Token: 0x04001D26 RID: 7462
		MulGetAdventureRewardResponse = 24375,
		// Token: 0x04001D27 RID: 7463
		MulCalabashLevelRewardResponse = 17527,
		// Token: 0x04001D28 RID: 7464
		MulExploreScoreRewardResponse = 27486,
		// Token: 0x04001D29 RID: 7465
		MulFishingIllustratedRewardResponse = 28177,
		// Token: 0x04001D2A RID: 7466
		MulMapTravelTaskRewardResponse = 16436,
		// Token: 0x04001D2B RID: 7467
		FloroRanchPlayGachaRefreshResponse = 18822,
		// Token: 0x04001D2C RID: 7468
		FloroRanchExecuteSkillPlayResponse = 28746,
		// Token: 0x04001D2D RID: 7469
		HoldHandResponse = 26676,
		// Token: 0x04001D2E RID: 7470
		TrapDefensePreviewFinishResponse = 26099,
		// Token: 0x04001D2F RID: 7471
		FloroRanchSettleDataResponse = 22164,
		// Token: 0x04001D30 RID: 7472
		SetFocusModeDeterCondResponse = 15892,
		// Token: 0x04001D31 RID: 7473
		LowMemoryChangeSceneFinishResponse = 18214,
		// Token: 0x04001D32 RID: 7474
		RogueWeeklyArtifactInfoResponse = 16633,
		// Token: 0x04001D33 RID: 7475
		RogueWeeklyArtifactSelectResponse = 17264,
		// Token: 0x04001D34 RID: 7476
		TrapDefenseRefreshGainingGroupResponse = 20307,
		// Token: 0x04001D35 RID: 7477
		TrapDefenseSelectGainingGroupResponse = 25867,
		// Token: 0x04001D36 RID: 7478
		TrapDefenseTechUnlockResponse = 19615,
		// Token: 0x04001D37 RID: 7479
		TrapDefenseGetRewardResponse = 26764,
		// Token: 0x04001D38 RID: 7480
		TrapDefenseGetSpecialRewardResponse = 27113,
		// Token: 0x04001D39 RID: 7481
		TrapDefenseBuildingLevelUpResponse = 21393,
		// Token: 0x04001D3A RID: 7482
		TrapDefenseBuildingBranchResponse = 16970,
		// Token: 0x04001D3B RID: 7483
		TrapDefenseAuxiliaryLevelUpResponse = 24981,
		// Token: 0x04001D3C RID: 7484
		TrapDefenseAuxiliaryBranchResponse = 27327,
		// Token: 0x04001D3D RID: 7485
		FunPlayChallengeAwardResponse = 24010,
		// Token: 0x04001D3E RID: 7486
		LevelPlayOpenResponse = 15142,
		// Token: 0x04001D3F RID: 7487
		TrapDefenseChallengeQuitResponse = 27534,
		// Token: 0x04001D40 RID: 7488
		TrapDefenseBuildingResetResponse = 20421,
		// Token: 0x04001D41 RID: 7489
		TrapDefenseAuxiliaryResetResponse = 29607,
		// Token: 0x04001D42 RID: 7490
		TrapDefenseDevelopResetResponse = 24446,
		// Token: 0x04001D43 RID: 7491
		ExploreEntityTraceResponse = 29477,
		// Token: 0x04001D44 RID: 7492
		CommonTouchUiSettingUpdateResponse = 19580,
		// Token: 0x04001D45 RID: 7493
		TrapDefenseSlotUpdateResponse = 20401,
		// Token: 0x04001D46 RID: 7494
		SceneItemSequenceFrameStartResponse = 16917,
		// Token: 0x04001D47 RID: 7495
		SceneItemSequenceFrameEndResponse = 24461,
		// Token: 0x04001D48 RID: 7496
		MulMapTravelSoarRewardResponse = 16779,
		// Token: 0x04001D49 RID: 7497
		PhantomSettingBatchUpdateResponse = 28959,
		// Token: 0x04001D4A RID: 7498
		FloroRanchFirstEnterResponse = 27776,
		// Token: 0x04001D4B RID: 7499
		FloroRanchAnimationResponse = 22651,
		// Token: 0x04001D4C RID: 7500
		BlackSwordChallengeInfoResponse = 20453,
		// Token: 0x04001D4D RID: 7501
		RoleOperateSelfBgmResponse = 25411,
		// Token: 0x04001D4E RID: 7502
		TrapDefenseRefreshShopResponse = 29329,
		// Token: 0x04001D4F RID: 7503
		TrapDefenseBuyShopProductResponse = 29351,
		// Token: 0x04001D50 RID: 7504
		MoonPhaseRandomResponse = 18392,
		// Token: 0x04001D51 RID: 7505
		MoonPhaseRewardResponse = 15018,
		// Token: 0x04001D52 RID: 7506
		TrapDefenseUseItemResponse = 28819,
		// Token: 0x04001D53 RID: 7507
		LineCrossChallengeStartResponse = 21987,
		// Token: 0x04001D54 RID: 7508
		RoleIllustratedInfoResponse = 22483,
		// Token: 0x04001D55 RID: 7509
		TrapDefenseCurChallengeInfoResponse = 19452,
		// Token: 0x04001D56 RID: 7510
		RoleDevelopConfigResponse = 23021,
		// Token: 0x04001D57 RID: 7511
		PhotoFightTaskRewardResponse = 20913,
		// Token: 0x04001D58 RID: 7512
		PhotoFightSettleResponse = 26567,
		// Token: 0x04001D59 RID: 7513
		TrapDefenseQuickEquipResponse = 20626,
		// Token: 0x04001D5A RID: 7514
		FloroRanchCloseTaskResponse = 19666,
		// Token: 0x04001D5B RID: 7515
		CalabashSkinTakeOnResponse = 28468,
		// Token: 0x04001D5C RID: 7516
		WuWuKujiGachaResponse = 17008,
		// Token: 0x04001D5D RID: 7517
		SurvivorsOpDoneResponse = 18127,
		// Token: 0x04001D5E RID: 7518
		SurvivorsLockResponse = 24428,
		// Token: 0x04001D5F RID: 7519
		QuestTreeInfoResponse = 15945,
		// Token: 0x04001D60 RID: 7520
		LoadCalabashSkinInfoResponse = 18646,
		// Token: 0x04001D61 RID: 7521
		SetPlayerYuXueModeResponse = 22623,
		// Token: 0x04001D62 RID: 7522
		SetBtObjYuXueModeResponse = 23727,
		// Token: 0x04001D63 RID: 7523
		GetYuXueModeInfoResponse = 17403,
		// Token: 0x04001D64 RID: 7524
		SurvivorsResultResponse = 24240,
		// Token: 0x04001D65 RID: 7525
		SurvivorsStepAdvanceResponse = 23962,
		// Token: 0x04001D66 RID: 7526
		WeatherControlResponse = 28028,
		// Token: 0x04001D67 RID: 7527
		SurvivorsWeaponInfoResponse = 23080,
		// Token: 0x04001D68 RID: 7528
		SurvivorsNormalAwardResponse = 24955,
		// Token: 0x04001D69 RID: 7529
		SurvivorsScoreAwardResponse = 23924,
		// Token: 0x04001D6A RID: 7530
		SurvivorsTalentLevelUpResponse = 23700,
		// Token: 0x04001D6B RID: 7531
		BatchSynthesisItemResponse = 26720,
		// Token: 0x04001D6C RID: 7532
		SurvivorsLastInfoResponse = 28545,
		// Token: 0x04001D6D RID: 7533
		RoleUpdateDevelopTargetResponse = 16891,
		// Token: 0x04001D6E RID: 7534
		MainPhantomRecommendResponse = 26732,
		// Token: 0x04001D6F RID: 7535
		InfrInfoResponse = 29855,
		// Token: 0x04001D70 RID: 7536
		InfrArchiveTaskRewardResponse = 28194,
		// Token: 0x04001D71 RID: 7537
		InfrManualSwitchTraceRoadResponse = 19643,
		// Token: 0x04001D72 RID: 7538
		InfrFireNoticeResponse = 27191,
		// Token: 0x04001D73 RID: 7539
		InfrLevelUpResponse = 17552,
		// Token: 0x04001D74 RID: 7540
		InfrRoadBuildResponse = 22175,
		// Token: 0x04001D75 RID: 7541
		BlackSwordChallengeMarkItemPanelInfoResponse = 19063,
		// Token: 0x04001D76 RID: 7542
		HonamiStoryBagOperateResponse = 17717,
		// Token: 0x04001D77 RID: 7543
		HonamiStoryEquipRoleResponse = 27622,
		// Token: 0x04001D78 RID: 7544
		HonamiStoryUnlockSlotResponse = 16925,
		// Token: 0x04001D79 RID: 7545
		HonamiStoryWeaponDressResponse = 26893,
		// Token: 0x04001D7A RID: 7546
		HonamiStorySellItemResponse = 15708,
		// Token: 0x04001D7B RID: 7547
		HonamiStoryLifeSupportUpResponse = 29000,
		// Token: 0x04001D7C RID: 7548
		HonamiStoryActivateTalentResponse = 16479,
		// Token: 0x04001D7D RID: 7549
		HonamiStoryItemCollectionResponse = 17176,
		// Token: 0x04001D7E RID: 7550
		HonamiStoryMascotRewardResponse = 28960,
		// Token: 0x04001D7F RID: 7551
		HonamiStoryAreaSecretRewardResponse = 21464,
		// Token: 0x04001D80 RID: 7552
		HonamiStoryLimitTaskRewardResponse = 20813,
		// Token: 0x04001D81 RID: 7553
		HonamiStoryScoreRewardResponse = 27500,
		// Token: 0x04001D82 RID: 7554
		HonamiStoryPickUpItemResponse = 19769,
		// Token: 0x04001D83 RID: 7555
		HonamiStoryDiscardItemResponse = 20810,
		// Token: 0x04001D84 RID: 7556
		HonamiStoryInstLeaveResponse = 23019,
		// Token: 0x04001D85 RID: 7557
		GetTraceQuestYuXueModeResponse = 20487,
		// Token: 0x04001D86 RID: 7558
		RollBlockResetGamePlayResponse = 26645,
		// Token: 0x04001D87 RID: 7559
		HonamiStoryLockItemResponse = 21718,
		// Token: 0x04001D88 RID: 7560
		RollBlockMovementFinishResponse = 20004,
		// Token: 0x04001D89 RID: 7561
		MulCorniceMeetingRewardResponse = 22551,
		// Token: 0x04001D8A RID: 7562
		RollBlockInputResponse = 17349,
		// Token: 0x04001D8B RID: 7563
		MotorTechLevelUpResponse = 15127,
		// Token: 0x04001D8C RID: 7564
		WeatherControlInfoResponse = 26543,
		// Token: 0x04001D8D RID: 7565
		ButtonIsEnableResponse = 25924,
		// Token: 0x04001D8E RID: 7566
		MotorLevelOneKeyRewardResponse = 17604,
		// Token: 0x04001D8F RID: 7567
		MotorInfoResponse = 22936,
		// Token: 0x04001D90 RID: 7568
		MotorTaskOneKeyRewardResponse = 26986,
		// Token: 0x04001D91 RID: 7569
		PhantomInteractionEquipResponse = 21997,
		// Token: 0x04001D92 RID: 7570
		PhantomInteractionSkinChangeResponse = 18194,
		// Token: 0x04001D93 RID: 7571
		MotorTechTreeSwitchResponse = 17554,
		// Token: 0x04001D94 RID: 7572
		AreaTerminalPinOperationResponse = 27615,
		// Token: 0x04001D95 RID: 7573
		GetDetectionTargetResponse = 24853,
		// Token: 0x04001D96 RID: 7574
		InfrThemeActivityAwardResponse = 21087,
		// Token: 0x04001D97 RID: 7575
		MotorSliderResponse = 16957,
		// Token: 0x04001D98 RID: 7576
		BossRushBatchClaimRewardResponse = 26097,
		// Token: 0x04001D99 RID: 7577
		PhantomBattleAreaSkillResponse = 29761,
		// Token: 0x04001D9A RID: 7578
		PhantomBattlePhantomCardSkillResponse = 22092,
		// Token: 0x04001D9B RID: 7579
		ArtemisNodeUpdateResponse = 18649,
		// Token: 0x04001D9C RID: 7580
		AddDecalResponse = 19752,
		// Token: 0x04001D9D RID: 7581
		CoopRoleRewardResponse = 25354,
		// Token: 0x04001D9E RID: 7582
		CoopSpRewardResponse = 19720,
		// Token: 0x04001D9F RID: 7583
		HonamiStoryResidentTaskRewardResponse = 15037,
		// Token: 0x04001DA0 RID: 7584
		RollBlockExitGamePlayResponse = 21367,
		// Token: 0x04001DA1 RID: 7585
		RollBlockToggleHintResponse = 16448,
		// Token: 0x04001DA2 RID: 7586
		MotorChangeOutlookResponse = 26904,
		// Token: 0x04001DA3 RID: 7587
		VehicleEnterSharingResponse = 25137,
		// Token: 0x04001DA4 RID: 7588
		RollBlockSwitchControlBlockResponse = 22237,
		// Token: 0x04001DA5 RID: 7589
		MotorLinkTaskResponse = 22394,
		// Token: 0x04001DA6 RID: 7590
		InstEntityTeleportResponse = 25123,
		// Token: 0x04001DA7 RID: 7591
		DeadeyeShootHitResponse = 21965,
		// Token: 0x04001DA8 RID: 7592
		MotorUseSkinResponse = 22488,
		// Token: 0x04001DA9 RID: 7593
		PhantomBattleCallCardResponse = 26502,
		// Token: 0x04001DAA RID: 7594
		ShortMessageInfoResponse = 17966,
		// Token: 0x04001DAB RID: 7595
		ShortMessageReadResponse = 16177,
		// Token: 0x04001DAC RID: 7596
		ShortMessageReplyResponse = 24310,
		// Token: 0x04001DAD RID: 7597
		ShortMessageReceivedResponse = 21328,
		// Token: 0x04001DAE RID: 7598
		InfrPhoneTaskRewardResponse = 18459,
		// Token: 0x04001DAF RID: 7599
		ShortMessageUpdateResponse = 19489,
		// Token: 0x04001DB0 RID: 7600
		BeamCastHitPlayerResponse = 21555,
		// Token: 0x04001DB1 RID: 7601
		CaptureBatchEntityResponse = 25668,
		// Token: 0x04001DB2 RID: 7602
		RoadBookFullRewardResponse = 26687,
		// Token: 0x04001DB3 RID: 7603
		RoadBookLevelUpResponse = 19714,
		// Token: 0x04001DB4 RID: 7604
		RoadBookTaskRewardResponse = 24523,
		// Token: 0x04001DB5 RID: 7605
		RoadBookMotorRewardResponse = 23361,
		// Token: 0x04001DB6 RID: 7606
		MotorParkourLevelRewardResponse = 21142,
		// Token: 0x04001DB7 RID: 7607
		PhantomBatchPolishResponse = 21024,
		// Token: 0x04001DB8 RID: 7608
		PhantomBattleCheckCardSkillUnlockResponse = 22143,
		// Token: 0x04001DB9 RID: 7609
		PhantomVicePolishResponse = 25546,
		// Token: 0x04001DBA RID: 7610
		PhantomVicePolishAckResponse = 22940,
		// Token: 0x04001DBB RID: 7611
		FurnitureDiySaveResponse = 25998,
		// Token: 0x04001DBC RID: 7612
		InfrManualCancelTraceRoadResponse = 25842,
		// Token: 0x04001DBD RID: 7613
		SkinRewardResponse = 20013,
		// Token: 0x04001DBE RID: 7614
		InfrArchiveReadResponse = 19607,
		// Token: 0x04001DBF RID: 7615
		AtomicProcessTeleportResponse = 27008,
		// Token: 0x04001DC0 RID: 7616
		NewTowerCycleStartResponse = 15315,
		// Token: 0x04001DC1 RID: 7617
		NewTowerUpdateRecordResponse = 25854,
		// Token: 0x04001DC2 RID: 7618
		NewTowerRewardResponse = 15099,
		// Token: 0x04001DC3 RID: 7619
		MotorFightTalentUpResponse = 24183,
		// Token: 0x04001DC4 RID: 7620
		MotorFightOneKeyRewardResponse = 18713,
		// Token: 0x04001DC5 RID: 7621
		MotorFightRankListResponse = 22100,
		// Token: 0x04001DC6 RID: 7622
		PhantomBattleGuideRewardResponse = 21038,
		// Token: 0x04001DC7 RID: 7623
		JokerGuessStartNewResponse = 18171,
		// Token: 0x04001DC8 RID: 7624
		JokerGuessPlayCardResponse = 19352,
		// Token: 0x04001DC9 RID: 7625
		JokerGuessDrawCardResponse = 27976,
		// Token: 0x04001DCA RID: 7626
		JokerGuessUseSkillResponse = 28232,
		// Token: 0x04001DCB RID: 7627
		EncircleChallengeStartResponse = 25305,
		// Token: 0x04001DCC RID: 7628
		EncircleChallengeCompleteResponse = 23637,
		// Token: 0x04001DCD RID: 7629
		PhantomMusicCollectUpdateResponse = 18049,
		// Token: 0x04001DCE RID: 7630
		H5CircumFluenceActivityReadResponse = 22858,
		// Token: 0x04001DCF RID: 7631
		HookLockBatchCollectResponse = 26873,
		// Token: 0x04001DD0 RID: 7632
		MotorFightSettleResponse = 19184,
		// Token: 0x04001DD1 RID: 7633
		MotorFightLastSaveDataResponse = 19578,
		// Token: 0x04001DD2 RID: 7634
		PhantomBattleRepeatedTaskRewardResponse = 16815,
		// Token: 0x04001DD3 RID: 7635
		NewTowerRoleEnergyResponse = 25538,
		// Token: 0x04001DD4 RID: 7636
		HonamiStoryActivityInfoResponse = 24959,
		// Token: 0x04001DD5 RID: 7637
		PhantomBatchDirectRefiningResponse = 28755,
		// Token: 0x04001DD6 RID: 7638
		PilotThrowOperationResponse = 28660,
		// Token: 0x04001DD7 RID: 7639
		ShortMessageShowChangeResponse = 27652,
		// Token: 0x04001DD8 RID: 7640
		NewPlayerSupportRewardTaskResponse = 25832,
		// Token: 0x04001DD9 RID: 7641
		NewPlayerSupportTrialRoleLvUpResponse = 22280,
		// Token: 0x04001DDA RID: 7642
		PhantomBattleReconstructCardResponse = 16661,
		// Token: 0x04001DDB RID: 7643
		RegressDisposableRewardResponse = 23423,
		// Token: 0x04001DDC RID: 7644
		ExploreSkillActionResponse = 19712,
		// Token: 0x04001DDD RID: 7645
		InstTeleportToResetPointResponse = 16034,
		// Token: 0x04001DDE RID: 7646
		NewTowerClearRecordResponse = 19209,
		// Token: 0x04001DDF RID: 7647
		GetLevelPlayRewardsResponse = 19260,
		// Token: 0x04001DE0 RID: 7648
		MotorOutlookInfoResponse = 18366,
		// Token: 0x04001DE1 RID: 7649
		Summon3Response = 25946,
		// Token: 0x04001DE2 RID: 7650
		RegressTrialRoleLvUpResponse = 29813,
		// Token: 0x04001DE3 RID: 7651
		GravityHookLockPointChangeGravityResponse = 22328,
		// Token: 0x04001DE4 RID: 7652
		TotalTopUpScoreInfoResponse = 28081,
		// Token: 0x04001DE5 RID: 7653
		TotalTopUpRewardResponse = 22019,
		// Token: 0x04001DE6 RID: 7654
		NewPlayerSupportSetCurUseTrialRoleResponse = 29875,
		// Token: 0x04001DE7 RID: 7655
		MotorFightEnterSubLevelResponse = 21543,
		// Token: 0x04001DE8 RID: 7656
		MotorFightKillResponse = 16884,
		// Token: 0x04001DE9 RID: 7657
		AtomicProcessAddBuffResponse = 15504,
		// Token: 0x04001DEA RID: 7658
		BrochureRewardResponse = 22634,
		// Token: 0x04001DEB RID: 7659
		WeekCardInfoResponse = 16279,
		// Token: 0x04001DEC RID: 7660
		WeekCardRewardResponse = 15339,
		// Token: 0x04001DED RID: 7661
		SeamlessTeleportVehicleResponse = 24419,
		// Token: 0x04001DEE RID: 7662
		RegressRepeatedTaskResponse = 26837,
		// Token: 0x04001DEF RID: 7663
		MotorCreateResponse = 16761,
		// Token: 0x04001DF0 RID: 7664
		RegressBuyBonusLvResponse = 25492,
		// Token: 0x04001DF1 RID: 7665
		RegressSetCurUseTrialRoleResponse = 26566,
		// Token: 0x04001DF2 RID: 7666
		H5ViewActivityReadResponse = 15198,
		// Token: 0x04001DF3 RID: 7667
		RoleSkillBranchModifyResponse = 23107,
		// Token: 0x04001DF4 RID: 7668
		MixDrinkSettleResponse = 19105,
		// Token: 0x04001DF5 RID: 7669
		MixDrinkTopicSelectResponse = 26371,
		// Token: 0x04001DF6 RID: 7670
		MotorFightPlayerDeadResponse = 23704,
		// Token: 0x04001DF7 RID: 7671
		WeatherSwitchInfoResponse = 27053,
		// Token: 0x04001DF8 RID: 7672
		MotorFightRefreshNextWaveGroupResponse = 27635,
		// Token: 0x04001DF9 RID: 7673
		RollBlockGamePlayReadyResponse = 23212,
		// Token: 0x04001DFA RID: 7674
		MotorFightSelectCollectionResponse = 18857,
		// Token: 0x04001DFB RID: 7675
		EntityEnterVehicleResponse = 25217,
		// Token: 0x04001DFC RID: 7676
		FarmGoldLevelPlayRepeatedResponse = 16947,
		// Token: 0x04001DFD RID: 7677
		MotorFightSelectBuffGateResponse = 22911,
		// Token: 0x04001DFE RID: 7678
		GivebackInfoResponse = 19180,
		// Token: 0x04001DFF RID: 7679
		GivebackRewardResponse = 20769,
		// Token: 0x04001E00 RID: 7680
		FarmGoldPointRepeatedResponse = 18879,
		// Token: 0x04001E01 RID: 7681
		ActionResetPosPrePerformanceEndResponse = 29352,
		// Token: 0x04001E02 RID: 7682
		MotorFightRefreshCollectionResponse = 18221,
		// Token: 0x04001E03 RID: 7683
		ExhibitionItemSaveResponse = 18661,
		// Token: 0x04001E04 RID: 7684
		SpringFestivalTaskRewardResponse = 19632,
		// Token: 0x04001E05 RID: 7685
		SpringFestivalScoreRewardResponse = 20918,
		// Token: 0x04001E06 RID: 7686
		SpringFestivalAtmosphereRewardResponse = 17452,
		// Token: 0x04001E07 RID: 7687
		EnterBigWorldInstResponse = 15876,
		// Token: 0x04001E08 RID: 7688
		PhantomMusicSaveResponse = 25499,
		// Token: 0x04001E09 RID: 7689
		FlagChallengeRewardResponse = 20586,
		// Token: 0x04001E0A RID: 7690
		MotorDevelopTaskRewardResponse = 29442,
		// Token: 0x04001E0B RID: 7691
		VehicleFinishResponse = 17721,
		// Token: 0x04001E0C RID: 7692
		AtomicProcessRemoveBuffResponse = 24883,
		// Token: 0x04001E0D RID: 7693
		ActivityPayShopBuyResponse = 29072,
		// Token: 0x04001E0E RID: 7694
		TetrisUpdateResponse = 21709,
		// Token: 0x04001E0F RID: 7695
		NewTrialRoleGetNightmarePhantomInstInfoResponse = 19481,
		// Token: 0x04001E10 RID: 7696
		MixDrinkRoleInviteResponse = 18245,
		// Token: 0x04001E11 RID: 7697
		MotorFightRankListSelfDataResponse = 18113,
		// Token: 0x04001E12 RID: 7698
		PhBaPlanUsePlanResponse = 17771,
		// Token: 0x04001E13 RID: 7699
		PhBaPlanSaveUsePlanResponse = 26457,
		// Token: 0x04001E14 RID: 7700
		PhBaPlanFindPlanResponse = 26108,
		// Token: 0x04001E15 RID: 7701
		KurotatoChestRewardSelectResponse = 22900,
		// Token: 0x04001E16 RID: 7702
		KurotatoUpgradeRewardSelectResponse = 24364,
		// Token: 0x04001E17 RID: 7703
		KurotatoUpgradeRewardRefreshResponse = 21421,
		// Token: 0x04001E18 RID: 7704
		KurotatoShopRewardSelectResponse = 28684,
		// Token: 0x04001E19 RID: 7705
		KurotatoShopRewardLockResponse = 15987,
		// Token: 0x04001E1A RID: 7706
		KurotatoShopRewardRefreshResponse = 16518,
		// Token: 0x04001E1B RID: 7707
		MixDrinkRoleRewardResponse = 21453,
		// Token: 0x04001E1C RID: 7708
		JokerGuessRewardResponse = 20099,
		// Token: 0x04001E1D RID: 7709
		StorageInfoResponse = 15837,
		// Token: 0x04001E1E RID: 7710
		StorageInfoUpdateResponse = 24640,
		// Token: 0x04001E1F RID: 7711
		FeiXuePreheatInfoRewardResponse = 26680,
		// Token: 0x04001E20 RID: 7712
		RhythmChangePartnerRoleResponse = 23561,
		// Token: 0x04001E21 RID: 7713
		RhythmRankListResponse = 26553,
		// Token: 0x04001E22 RID: 7714
		RhythmRankListSelfDataResponse = 24201,
		// Token: 0x04001E23 RID: 7715
		RhythmSettleResponse = 18537,
		// Token: 0x04001E24 RID: 7716
		RhythmSetRedDotResponse = 21670,
		// Token: 0x04001E25 RID: 7717
		RhythmTaskOneKeyRewardResponse = 28347,
		// Token: 0x04001E26 RID: 7718
		DropCatchLevelRewardResponse = 27201,
		// Token: 0x04001E27 RID: 7719
		DropCatchLevelFinishResponse = 24353,
		// Token: 0x04001E28 RID: 7720
		SplinePositionUpdateResponse = 29976,
		// Token: 0x04001E29 RID: 7721
		KurotatoEndShopStepResponse = 23609,
		// Token: 0x04001E2A RID: 7722
		NewTowerLastCycleInfoResponse = 17319,
		// Token: 0x04001E2B RID: 7723
		NewTowerSeasonRewardResponse = 20020,
		// Token: 0x04001E2C RID: 7724
		NewTowerRecommendResponse = 15290,
		// Token: 0x04001E2D RID: 7725
		ScheduleNpcUpdatePosResponse = 19698,
		// Token: 0x04001E2E RID: 7726
		KurotatoRefineWeaponResponse = 23434,
		// Token: 0x04001E2F RID: 7727
		PhBaPlanSetPlanStatusResponse = 26043,
		// Token: 0x04001E30 RID: 7728
		PhBaPlanUpdatePlanResponse = 20521,
		// Token: 0x04001E31 RID: 7729
		PhBaPlanSetFiveStarSwitchResponse = 24842,
		// Token: 0x04001E32 RID: 7730
		NewTowerSeasonScoreRewardResponse = 24617,
		// Token: 0x04001E33 RID: 7731
		StartRecallResponse = 22108,
		// Token: 0x04001E34 RID: 7732
		ChangeOrnamentResponse = 23664,
		// Token: 0x04001E35 RID: 7733
		DropCatchInfoResponse = 26513,
		// Token: 0x04001E36 RID: 7734
		AvoidBlockSubmitOverNodeResponse = 27806,
		// Token: 0x04001E37 RID: 7735
		KurotatoSellWeaponResponse = 24086,
		// Token: 0x04001E38 RID: 7736
		TetrisFinishResponse = 16139,
		// Token: 0x04001E39 RID: 7737
		RacingBetsCloseSettleMenuResponse = 23836,
		// Token: 0x04001E3A RID: 7738
		PlayerXboxInfoGetResponse = 29123,
		// Token: 0x04001E3B RID: 7739
		PlayerCreateXboxSessionResponse = 17939,
		// Token: 0x04001E3C RID: 7740
		PlayerXboxBlockListResponse = 26733,
		// Token: 0x04001E3D RID: 7741
		XboxSettingUpdateResponse = 16049,
		// Token: 0x04001E3E RID: 7742
		XboxSettingResponse = 16665,
		// Token: 0x04001E3F RID: 7743
		PinballTeamReviveResponse = 15477,
		// Token: 0x04001E40 RID: 7744
		PinballSetPayloadResponse = 26267,
		// Token: 0x04001E41 RID: 7745
		RoleSkillQuickLevelUpResponse = 24928,
		// Token: 0x04001E42 RID: 7746
		GaSwitchCommonEnemyProCampResponse = 20488,
		// Token: 0x04001E43 RID: 7747
		PinballTeamDieResponse = 15684,
		// Token: 0x04001E44 RID: 7748
		PinballQuitResponse = 21377,
		// Token: 0x04001E45 RID: 7749
		PinballBonusFullWinResponse = 16828,
		// Token: 0x04001E46 RID: 7750
		PinballInGameSyncPayloadResponse = 24557,
		// Token: 0x04001E47 RID: 7751
		PinballTaskRewardResponse = 16536,
		// Token: 0x04001E48 RID: 7752
		PinballRoleLevelUpResponse = 29568,
		// Token: 0x04001E49 RID: 7753
		PinballWeaponDegradeResponse = 24456,
		// Token: 0x04001E4A RID: 7754
		PinballWeaponWearResponse = 17279,
		// Token: 0x04001E4B RID: 7755
		PinballFriendRankResponse = 20019,
		// Token: 0x04001E4C RID: 7756
		InfrV2InfoResponse = 26149,
		// Token: 0x04001E4D RID: 7757
		InfrV2LevelUpResponse = 29561,
		// Token: 0x04001E4E RID: 7758
		InfrV2TreeBuildResponse = 28858,
		// Token: 0x04001E4F RID: 7759
		InfrV2ManualSwitchTraceTreeResponse = 26046,
		// Token: 0x04001E50 RID: 7760
		InfrV2ManualCancelTraceTreeResponse = 16976,
		// Token: 0x04001E51 RID: 7761
		RogueInstExtraInfoResponse = 19878,
		// Token: 0x04001E52 RID: 7762
		InfrV2ScoreRewardResponse = 27040,
		// Token: 0x04001E53 RID: 7763
		InfrV2TaskRewardResponse = 16735,
		// Token: 0x04001E54 RID: 7764
		RhythmMainLineInfoResponse = 21999,
		// Token: 0x04001E55 RID: 7765
		ThemePersonalScoreResponse = 18903,
		// Token: 0x04001E56 RID: 7766
		ThemeWorldScoreResponse = 29997,
		// Token: 0x04001E57 RID: 7767
		WuWuTaskRewardResponse = 20425,
		// Token: 0x04001E58 RID: 7768
		BossPilingRewardResponse = 26058,
		// Token: 0x04001E59 RID: 7769
		PhBaPlanBatchOperResponse = 28424,
		// Token: 0x04001E5A RID: 7770
		MotorOutlookCreatePresetResponse = 22153,
		// Token: 0x04001E5B RID: 7771
		MotorOutlookDeletePresetResponse = 16772,
		// Token: 0x04001E5C RID: 7772
		MotorOutlookEditPresetResponse = 23910,
		// Token: 0x04001E5D RID: 7773
		FlowerPollutionResponse = 23879,
		// Token: 0x04001E5E RID: 7774
		MotorDecalTaskResponse = 22439,
		// Token: 0x04001E5F RID: 7775
		MotorDecalMotorIpResponse = 27523,
		// Token: 0x04001E60 RID: 7776
		BossPilingSettleResponse = 17879,
		// Token: 0x04001E61 RID: 7777
		RacingBetsRepeatedTaskRewardResponse = 22994,
		// Token: 0x04001E62 RID: 7778
		LinkageCheckInRewardResponse = 19375,
		// Token: 0x04001E63 RID: 7779
		GolemCrackUpdateResponse = 25396,
		// Token: 0x04001E64 RID: 7780
		QuestBranchResponse = 20238,
		// Token: 0x04001E65 RID: 7781
		QuestBranchSelectResponse = 29618,
		// Token: 0x04001E66 RID: 7782
		RoleGiftRewardResponse = 28753,
		// Token: 0x04001E67 RID: 7783
		NewTowerSeasonTaskDataUpdateResponse = 28342,
		// Token: 0x04001E68 RID: 7784
		WuWuPackageRewardResponse = 17971,
		// Token: 0x04001E69 RID: 7785
		PinballInGameKickBallResponse = 23854,
		// Token: 0x04001E6A RID: 7786
		GachaAccumulateInfoResponse = 21629,
		// Token: 0x04001E6B RID: 7787
		GachaAccumulateRewardResponse = 20196,
		// Token: 0x04001E6C RID: 7788
		PlayerEnterPollutionResponse = 20980,
		// Token: 0x04001E6D RID: 7789
		QuickHackSkillResponse = 17263,
		// Token: 0x04001E6E RID: 7790
		EdgeRunnerFunctionPreUnlockResponse = 20110,
		// Token: 0x04001E6F RID: 7791
		EdgeRunnerScoreRewardResponse = 20097,
		// Token: 0x04001E70 RID: 7792
		EdgeRunnerTaskRewardResponse = 17834,
		// Token: 0x04001E71 RID: 7793
		KurotatoScoreTaskReceiveResponse = 20122,
		// Token: 0x04001E72 RID: 7794
		KurotatoResTaskReceiveResponse = 21172,
		// Token: 0x04001E73 RID: 7795
		KurotatoLimitTaskReceiveResponse = 20933,
		// Token: 0x04001E74 RID: 7796
		KurotatoRoleRecordResponse = 16983,
		// Token: 0x04001E75 RID: 7797
		WeeklyFrameworkInfoResponse = 22499,
		// Token: 0x04001E76 RID: 7798
		WeeklyFrameworkScoreRewardResponse = 23966,
		// Token: 0x04001E77 RID: 7799
		FloroRanchWeeklyResponse = 28219,
		// Token: 0x04001E78 RID: 7800
		DollGrabResponse = 17987,
		// Token: 0x04001E79 RID: 7801
		DollGrabTimeBallResponse = 18865,
		// Token: 0x04001E7A RID: 7802
		DollGarbStartResponse = 22696,
		// Token: 0x04001E7B RID: 7803
		ApplySceneClientEntityIncIdResponse = 20448,
		// Token: 0x04001E7C RID: 7804
		AvoidBlockClientInitDoneResponse = 23288,
		// Token: 0x04001E7D RID: 7805
		ConsumptiveActivityScoreResponse = 15654,
		// Token: 0x04001E7E RID: 7806
		MonsterPatrolPointReachedResponse = 21552,
		// Token: 0x04001E7F RID: 7807
		ClientPullResourcePackageResponse = 28454,
		// Token: 0x04001E80 RID: 7808
		NewHandInItemResponse = 24260,
		// Token: 0x04001E81 RID: 7809
		DollDeliveryResponse = 16482,
		// Token: 0x04001E82 RID: 7810
		OnlineMotorActivityLevelResponse = 18856,
		// Token: 0x04001E83 RID: 7811
		PlayerVoiceLanguageResponse = 27315,
		// Token: 0x04001E84 RID: 7812
		PlayerRoleVoiceSetResponse = 22358,
		// Token: 0x04001E85 RID: 7813
		FloroRanchEventChoiceResponse = 29916,
		// Token: 0x04001E86 RID: 7814
		KurotatoSettlementResponse = 24003,
		// Token: 0x04001E87 RID: 7815
		RemoteBatchCollectResponse = 20188,
		// Token: 0x04001E88 RID: 7816
		BatchMaterialReplaceResponse = 21431,
		// Token: 0x04001E89 RID: 7817
		NewPlayerSupportSetCurUseTrialRoleV2Response = 19230,
		// Token: 0x04001E8A RID: 7818
		ChangeSummonEntityStateResponse = 23698,
		// Token: 0x04001E8B RID: 7819
		NewPlayerSupportTrialRoleLvUpV2Response = 25380,
		// Token: 0x04001E8C RID: 7820
		RealmBetweenFullRewardResponse = 18737,
		// Token: 0x04001E8D RID: 7821
		RealmBetweenLevelUpResponse = 27232,
		// Token: 0x04001E8E RID: 7822
		RealmBetweenTaskRewardResponse = 26868,
		// Token: 0x04001E8F RID: 7823
		RealmBetweenMotorRewardResponse = 20454,
		// Token: 0x04001E90 RID: 7824
		RogueArchiveListResponse = 26762,
		// Token: 0x04001E91 RID: 7825
		RogueArchiveSaveResponse = 29633,
		// Token: 0x04001E92 RID: 7826
		RogueTowerTrialStartResponse = 23092,
		// Token: 0x04001E93 RID: 7827
		RogueTowerTrialSelectBossResponse = 28302,
		// Token: 0x04001E94 RID: 7828
		RogueTowerTrialReChallengeResponse = 15271,
		// Token: 0x04001E95 RID: 7829
		RogueTowerTrialResultResponse = 19217,
		// Token: 0x04001E96 RID: 7830
		SheriffZoneInfoResponse = 25351,
		// Token: 0x04001E97 RID: 7831
		KurotatoEndSpecialWaveCombatResponse = 21746,
		// Token: 0x04001E98 RID: 7832
		BabelTowerShowNameResponse = 28419,
		// Token: 0x04001E99 RID: 7833
		BabelTowerRankListResponse = 16572,
		// Token: 0x04001E9A RID: 7834
		BabelTowerSelfPassResponse = 15993,
		// Token: 0x04001E9B RID: 7835
		DollGrabStopResponse = 22720,
		// Token: 0x04001E9C RID: 7836
		RogueTowerTrialGiveUpTempArchiveResponse = 25299,
		// Token: 0x04001E9D RID: 7837
		MiniWriteLetterSaveContentResponse = 17140,
		// Token: 0x04001E9E RID: 7838
		SignActivityFreeDropResponse = 15457,
		// Token: 0x04001E9F RID: 7839
		KurotatoReChallengeResponse = 18670,
		// Token: 0x04001EA0 RID: 7840
		DollGrabPauseStartResponse = 17732,
		// Token: 0x04001EA1 RID: 7841
		DollGrabPauseEndResponse = 17158,
		// Token: 0x04001EA2 RID: 7842
		TraceRecallQuestResponse = 28806,
		// Token: 0x04001EA3 RID: 7843
		RecallQuestFinishActionResponse = 15780,
		// Token: 0x04001EA4 RID: 7844
		RecallQuestActionResponse = 22619,
		// Token: 0x04001EA5 RID: 7845
		RecallQuestNpcMoveOverResponse = 19333,
		// Token: 0x04001EA6 RID: 7846
		NewbieAdventureTaskRewardResponse = 15720,
		// Token: 0x04001EA7 RID: 7847
		NewbieAdventureChapterDropResponse = 19337,
		// Token: 0x04001EA8 RID: 7848
		NewbieAdventureRoleRewardResponse = 17073,
		// Token: 0x04001EA9 RID: 7849
		NewbieCourseV2RewardResponse = 16170,
		// Token: 0x04001EAA RID: 7850
		NewbieFetchScoreRewardResponse = 29217,
		// Token: 0x04001EAB RID: 7851
		RecallQuestFinishActionEndResponse = 18345,
		// Token: 0x04001EAC RID: 7852
		FloroRanchOutResponse = 25979,
		// Token: 0x04001EAD RID: 7853
		RecallQuestReadyForGiveUpResponse = 21194,
		// Token: 0x04001EAE RID: 7854
		ResonantChainOptionalLimitResponse = 27438,
		// Token: 0x04001EAF RID: 7855
		QueryRecallItemBagResponse = 25460,
		// Token: 0x04001EB0 RID: 7856
		SetClientGlobalVarResponse = 17849,
		// Token: 0x04001EB1 RID: 7857
		DollGarbInsertCoinResponse = 28733,
		// Token: 0x04001EB2 RID: 7858
		RoverRogueQuitResponse = 16168,
		// Token: 0x04001EB3 RID: 7859
		RoverRogueResultResponse = 20710,
		// Token: 0x04001EB4 RID: 7860
		RoverRogueChooseDataResultResponse = 20137,
		// Token: 0x04001EB5 RID: 7861
		RoverRogueRefreshGainResponse = 21110,
		// Token: 0x04001EB6 RID: 7862
		RoverRogueGiveUpGainResponse = 19016,
		// Token: 0x04001EB7 RID: 7863
		RoverRogueGotoNextRoomCommitResponse = 29236,
		// Token: 0x04001EB8 RID: 7864
		RoverRogueInsListResponse = 27005,
		// Token: 0x04001EB9 RID: 7865
		RoverRogueTalentInfoResponse = 15617,
		// Token: 0x04001EBA RID: 7866
		RoverRogueTalentUnlockResponse = 15025,
		// Token: 0x04001EBB RID: 7867
		RoverRogueShopBuyResponse = 29518,
		// Token: 0x04001EBC RID: 7868
		RoverRogueShopRefreshResponse = 21963,
		// Token: 0x04001EBD RID: 7869
		DangoBrawlBagOperateResponse = 17507,
		// Token: 0x04001EBE RID: 7870
		DangoBrawlShopRefreshResponse = 15810,
		// Token: 0x04001EBF RID: 7871
		DangoBrawlShopLockResponse = 19957,
		// Token: 0x04001EC0 RID: 7872
		DangoBrawlShopBuyResponse = 25948,
		// Token: 0x04001EC1 RID: 7873
		DangoBrawlShopSellResponse = 24125,
		// Token: 0x04001EC2 RID: 7874
		DangoBrawlShopComposeResponse = 15368,
		// Token: 0x04001EC3 RID: 7875
		DangoBrawlEventRefreshResponse = 27098,
		// Token: 0x04001EC4 RID: 7876
		DangoBrawlEventSelectResponse = 29706,
		// Token: 0x04001EC5 RID: 7877
		DangoBrawlStartFightResponse = 28659,
		// Token: 0x04001EC6 RID: 7878
		DangoBrawlFightOverResponse = 16631,
		// Token: 0x04001EC7 RID: 7879
		RoverRogueBlessGroupSelectResponse = 16971,
		// Token: 0x04001EC8 RID: 7880
		NewTowerMedalInfoResponse = 27000,
		// Token: 0x04001EC9 RID: 7881
		RoverRogueEventSelectResponse = 18651,
		// Token: 0x04001ECA RID: 7882
		MotorUseSceneResponse = 26625,
		// Token: 0x04001ECB RID: 7883
		DangoBrawlSettleResponse = 24979,
		// Token: 0x04001ECC RID: 7884
		DangoBrawlTaskRewardResponse = 20255,
		// Token: 0x04001ECD RID: 7885
		UpdatePhantomEquipGroupResponse = 27868,
		// Token: 0x04001ECE RID: 7886
		QuestFastReturnPosResponse = 28798,
		// Token: 0x04001ECF RID: 7887
		LevelPlayFastReturnPosResponse = 17289,
		// Token: 0x04001ED0 RID: 7888
		FastReturnDungeonResponse = 24553,
		// Token: 0x04001ED1 RID: 7889
		DollSmallMapInfoResponse = 19076,
		// Token: 0x04001ED2 RID: 7890
		RoverRogueLootInfoResponse = 17028,
		// Token: 0x04001ED3 RID: 7891
		RoverRogueLootChangeResponse = 28188,
		// Token: 0x04001ED4 RID: 7892
		KurotatoStepAdvanceResponse = 15011,
		// Token: 0x04001ED5 RID: 7893
		RecallExploreSkillRouletteSetResponse = 25464,
		// Token: 0x04001ED6 RID: 7894
		RoverRogueTaskRewardTakeResponse = 15438,
		// Token: 0x04001ED7 RID: 7895
		SceneGroupDataAndCurFormationEntityResponse = 28552,
		// Token: 0x04001ED8 RID: 7896
		KurotatoGoldAddResponse = 25569,
		// Token: 0x04001ED9 RID: 7897
		TowerDefenceChallengeQuitResponse = 16362,
		// Token: 0x04001EDA RID: 7898
		KurotatoLevelRecordDeleteResponse = 27741,
		// Token: 0x04001EDB RID: 7899
		MailFavoriteResponse = 17919,
		// Token: 0x04001EDC RID: 7900
		ConditionGroupStateResponse = 16252,
		// Token: 0x04001EDD RID: 7901
		ZitherPlayStateResponse = 25209,
		// Token: 0x04001EDE RID: 7902
		EntityAccessCasketResponse = 21699,
		// Token: 0x04001EDF RID: 7903
		PlayerAccessCasketResponse = 18900,
		// Token: 0x04001EE0 RID: 7904
		QingXiaoTaskRewardResponse = 21118,
		// Token: 0x04001EE1 RID: 7905
		GiantDeliveryItemResponse = 18294,
		// Token: 0x04001EE2 RID: 7906
		GiantMaxLevelDeliveryItemResponse = 28669,
		// Token: 0x04001EE3 RID: 7907
		MatchThreeStarResponse = 28482,
		// Token: 0x04001EE4 RID: 7908
		MatchThreeEndResponse = 20119,
		// Token: 0x04001EE5 RID: 7909
		DangoBrawlScoreRewardResponse = 24133,
		// Token: 0x04001EE6 RID: 7910
		FoundationCoreOperateResponse = 23558,
		// Token: 0x04001EE7 RID: 7911
		CameraSettingQueryResponse = 25637,
		// Token: 0x04001EE8 RID: 7912
		CameraSettingModifyResponse = 26725,
		// Token: 0x04001EE9 RID: 7913
		RecallTeleportToMarkIdResponse = 19697,
		// Token: 0x04001EEA RID: 7914
		ShortMessageChatThemeChangeResponse = 21146,
		// Token: 0x04001EEB RID: 7915
		ShortMessageChatCharmChangeResponse = 15958,
		// Token: 0x04001EEC RID: 7916
		RenameFormationResponse = 18743,
		// Token: 0x04001EED RID: 7917
		SolarSchoolSaveResponse = 21936,
		// Token: 0x04001EEE RID: 7918
		SolarSchoolLoadResponse = 18031,
		// Token: 0x04001EEF RID: 7919
		SolarSchoolSetFlowResponse = 27809,
		// Token: 0x04001EF0 RID: 7920
		SolarSchoolReachEndingResponse = 23961,
		// Token: 0x04001EF1 RID: 7921
		SolarSchoolOneKeyRewardResponse = 26713,
		// Token: 0x04001EF2 RID: 7922
		SolarSchoolBatchSyncResponse = 26100,
		// Token: 0x04001EF3 RID: 7923
		SolarSchoolOneKeyGalleryRewardResponse = 19859,
		// Token: 0x04001EF4 RID: 7924
		ReorderFormationResponse = 28600,
		// Token: 0x04001EF5 RID: 7925
		GiantStableValueActivityResponse = 27413,
		// Token: 0x04001EF6 RID: 7926
		RecallItemUseResponse = 19067,
		// Token: 0x04001EF7 RID: 7927
		GameStatsShowResponse = 18943,
		// Token: 0x04001EF8 RID: 7928
		SelfPortraitStateResponse = 28546,
		// Token: 0x04001EF9 RID: 7929
		LoopTeleportVolumeActionResponse = 25898,
		// Token: 0x04001EFA RID: 7930
		SolarSchoolTaskProgressRewardResponse = 18486,
		// Token: 0x04001EFB RID: 7931
		RoleTowerSaveDeleteResponse = 15219,
		// Token: 0x04001EFC RID: 7932
		RoleTowerChallengeSettleResponse = 18185,
		// Token: 0x04001EFD RID: 7933
		RoleTowerRankResponse = 25174,
		// Token: 0x04001EFE RID: 7934
		RoleTowerRewardTaskReceiveResponse = 18563,
		// Token: 0x04001EFF RID: 7935
		RoleTowerScoreRewardReceiveResponse = 25210,
		// Token: 0x04001F00 RID: 7936
		TeamRecommendResponse = 16900,
		// Token: 0x04001F01 RID: 7937
		WellStreamingFinisResponse = 24801,
		// Token: 0x04001F02 RID: 7938
		TimePointActivityBatchRewardResponse = 15156,
		// Token: 0x04001F03 RID: 7939
		RoleTowerStepAdvanceResponse = 28939,
		// Token: 0x04001F04 RID: 7940
		RoleTowerStageSettleResponse = 15371,
		// Token: 0x04001F05 RID: 7941
		RoleTowerStageRetryResponse = 27529,
		// Token: 0x04001F06 RID: 7942
		RoleTowerRankRewardReceiveResponse = 24106,
		// Token: 0x04001F07 RID: 7943
		RoleTowerConsumeItemResponse = 16552,
		// Token: 0x04001F08 RID: 7944
		RoleTowerPhantomAddAttrsResponse = 25433,
		// Token: 0x04001F09 RID: 7945
		RoleTowerAttributeQueryResponse = 29708
	}
}
