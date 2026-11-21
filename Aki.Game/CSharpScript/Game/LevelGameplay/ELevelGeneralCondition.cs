using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B0A RID: 23306
	[EnumExtensions]
	public enum ELevelGeneralCondition
	{
		// Token: 0x0401E2C2 RID: 123586
		DistanceLess,
		// Token: 0x0401E2C3 RID: 123587
		SelfTagCheck,
		// Token: 0x0401E2C4 RID: 123588
		ItemCheck,
		// Token: 0x0401E2C5 RID: 123589
		CheckItemWithOperator,
		// Token: 0x0401E2C6 RID: 123590
		CheckDis,
		// Token: 0x0401E2C7 RID: 123591
		TargetTagCheck,
		// Token: 0x0401E2C8 RID: 123592
		CheckOnTrap,
		// Token: 0x0401E2C9 RID: 123593
		CheckDirection,
		// Token: 0x0401E2CA RID: 123594
		QuestState,
		// Token: 0x0401E2CB RID: 123595
		CheckStrikeInfo,
		// Token: 0x0401E2CC RID: 123596
		CheckLevel,
		// Token: 0x0401E2CD RID: 123597
		CheckLevelOp,
		// Token: 0x0401E2CE RID: 123598
		CheckGuideStatus,
		// Token: 0x0401E2CF RID: 123599
		CheckCharacterTag,
		// Token: 0x0401E2D0 RID: 123600
		CheckCharacterTagByEvent,
		// Token: 0x0401E2D1 RID: 123601
		CheckCharacterTagNotByEvent,
		// Token: 0x0401E2D2 RID: 123602
		CheckCharacterVehicleTagByEvent,
		// Token: 0x0401E2D3 RID: 123603
		CheckCharacterVehicleTagNotByEvent,
		// Token: 0x0401E2D4 RID: 123604
		DragonPoolState,
		// Token: 0x0401E2D5 RID: 123605
		SceneStepState,
		// Token: 0x0401E2D6 RID: 123606
		CheckTeleportStatus,
		// Token: 0x0401E2D7 RID: 123607
		RoleLevel,
		// Token: 0x0401E2D8 RID: 123608
		CheckRoleLevel,
		// Token: 0x0401E2D9 RID: 123609
		CheckRoleOwned,
		// Token: 0x0401E2DA RID: 123610
		RoleBreach,
		// Token: 0x0401E2DB RID: 123611
		SelfGameplayTagCheck,
		// Token: 0x0401E2DC RID: 123612
		CheckInTodTimeSpan,
		// Token: 0x0401E2DD RID: 123613
		[EnumStringMember("CheckEntityCommonTag")]
		CheckSceneItemTag,
		// Token: 0x0401E2DE RID: 123614
		IsPlayer,
		// Token: 0x0401E2DF RID: 123615
		CheckEntityConfigId,
		// Token: 0x0401E2E0 RID: 123616
		CheckSelfEntityCommonTag,
		// Token: 0x0401E2E1 RID: 123617
		CheckInstanceEntranceUnlockStatus,
		// Token: 0x0401E2E2 RID: 123618
		CheckOriginWorldLevel,
		// Token: 0x0401E2E3 RID: 123619
		CheckCurWorldLevel,
		// Token: 0x0401E2E4 RID: 123620
		CheckCurWorldLevelOp,
		// Token: 0x0401E2E5 RID: 123621
		StartShootTarget,
		// Token: 0x0401E2E6 RID: 123622
		CheckInstanceState,
		// Token: 0x0401E2E7 RID: 123623
		CheckInstanceMatchAble,
		// Token: 0x0401E2E8 RID: 123624
		MoveStateCheck,
		// Token: 0x0401E2E9 RID: 123625
		[EnumStringMember("LevelConditionCheckBuff")]
		CheckBuff,
		// Token: 0x0401E2EA RID: 123626
		CheckUIState,
		// Token: 0x0401E2EB RID: 123627
		CheckUIOpen,
		// Token: 0x0401E2EC RID: 123628
		CheckUIOpenDone,
		// Token: 0x0401E2ED RID: 123629
		CheckUIShowDone,
		// Token: 0x0401E2EE RID: 123630
		CheckInputAction,
		// Token: 0x0401E2EF RID: 123631
		CheckClientUseSkill,
		// Token: 0x0401E2F0 RID: 123632
		CheckClientUseVisionSkill,
		// Token: 0x0401E2F1 RID: 123633
		CheckBattleRole,
		// Token: 0x0401E2F2 RID: 123634
		CheckEquippedPhantom,
		// Token: 0x0401E2F3 RID: 123635
		CheckEnemyBuff,
		// Token: 0x0401E2F4 RID: 123636
		CheckEnemyTag,
		// Token: 0x0401E2F5 RID: 123637
		CheckSkillPoint,
		// Token: 0x0401E2F6 RID: 123638
		CheckExploreSkill,
		// Token: 0x0401E2F7 RID: 123639
		CheckFightEnergyBar,
		// Token: 0x0401E2F8 RID: 123640
		CheckFightEnergyBall,
		// Token: 0x0401E2F9 RID: 123641
		FunctionUnlock,
		// Token: 0x0401E2FA RID: 123642
		GetNewItem,
		// Token: 0x0401E2FB RID: 123643
		HarmonyQte,
		// Token: 0x0401E2FC RID: 123644
		GetWhichRole,
		// Token: 0x0401E2FD RID: 123645
		HpLowerThan,
		// Token: 0x0401E2FE RID: 123646
		FightWithMonster,
		// Token: 0x0401E2FF RID: 123647
		PawnInRange,
		// Token: 0x0401E300 RID: 123648
		SlotOfCurrentRole,
		// Token: 0x0401E301 RID: 123649
		PhantomTargetLevel,
		// Token: 0x0401E302 RID: 123650
		CheckClientQuest,
		// Token: 0x0401E303 RID: 123651
		CheckClientQuestNode,
		// Token: 0x0401E304 RID: 123652
		PhantomMaxLevel,
		// Token: 0x0401E305 RID: 123653
		RoleTargetLevel,
		// Token: 0x0401E306 RID: 123654
		RoleSkillTargetLevel,
		// Token: 0x0401E307 RID: 123655
		BattleRoleIsNot,
		// Token: 0x0401E308 RID: 123656
		BattleRoleWeaponType,
		// Token: 0x0401E309 RID: 123657
		FormationAnyRoleDead,
		// Token: 0x0401E30A RID: 123658
		ComboTeachingState,
		// Token: 0x0401E30B RID: 123659
		OnViewClose,
		// Token: 0x0401E30C RID: 123660
		OnPlayerUseSkill,
		// Token: 0x0401E30D RID: 123661
		OnSkillButtonDataRefresh,
		// Token: 0x0401E30E RID: 123662
		FinishGuideStepByEvent,
		// Token: 0x0401E30F RID: 123663
		PlayerRevive,
		// Token: 0x0401E310 RID: 123664
		CheckTeamRoleCouldLevelUp,
		// Token: 0x0401E311 RID: 123665
		CheckTeamWeaponCouldLevelUp,
		// Token: 0x0401E312 RID: 123666
		ClientCalabashLevel,
		// Token: 0x0401E313 RID: 123667
		TeamRoleLevel,
		// Token: 0x0401E314 RID: 123668
		TeamWeaponLevel,
		// Token: 0x0401E315 RID: 123669
		TeamCouldEquipPhantom,
		// Token: 0x0401E316 RID: 123670
		CheckAnyPhantomCouldUpdate,
		// Token: 0x0401E317 RID: 123671
		CheckAnyRoleFullPhantom,
		// Token: 0x0401E318 RID: 123672
		CheckRolePhantomNum,
		// Token: 0x0401E319 RID: 123673
		CheckItemCountByType,
		// Token: 0x0401E31A RID: 123674
		CheckRouletteEquipItemId,
		// Token: 0x0401E31B RID: 123675
		CheckVisionIntensifyTabOpen,
		// Token: 0x0401E31C RID: 123676
		CheckAccountSettingOpen,
		// Token: 0x0401E31D RID: 123677
		CheckOnTreasureBoxOpen,
		// Token: 0x0401E31E RID: 123678
		CheckWeaponCount,
		// Token: 0x0401E31F RID: 123679
		CheckOnCostInsufficient,
		// Token: 0x0401E320 RID: 123680
		CheckRangeByPbDataId,
		// Token: 0x0401E321 RID: 123681
		CheckDungeonId,
		// Token: 0x0401E322 RID: 123682
		CheckRogueTerm,
		// Token: 0x0401E323 RID: 123683
		CheckTeleportTypeUnlock,
		// Token: 0x0401E324 RID: 123684
		CheckTypeItemPickUp,
		// Token: 0x0401E325 RID: 123685
		CheckDungeonFinished,
		// Token: 0x0401E326 RID: 123686
		CheckRogueCanUnlockSkill,
		// Token: 0x0401E327 RID: 123687
		CheckPositionRolePhantomSkillEquip,
		// Token: 0x0401E328 RID: 123688
		CheckHasFirstPhantomAtPosition,
		// Token: 0x0401E329 RID: 123689
		CheckWorldMapSecondaryUiOpened,
		// Token: 0x0401E32A RID: 123690
		CheckHasUnlockAffixInBossRush,
		// Token: 0x0401E32B RID: 123691
		OnChangeBossRushBuff,
		// Token: 0x0401E32C RID: 123692
		RoguelikeHasSelectEntryAndShow,
		// Token: 0x0401E32D RID: 123693
		CheckActivityOpen,
		// Token: 0x0401E32E RID: 123694
		CheckHasSkinInRoleSkinSubView,
		// Token: 0x0401E32F RID: 123695
		OnTakingPhoto,
		// Token: 0x0401E330 RID: 123696
		HasNotInvitedRoleInSpring25,
		// Token: 0x0401E331 RID: 123697
		CheckMapFocusByQuestId,
		// Token: 0x0401E332 RID: 123698
		OnWorldMapGravityBtnShow,
		// Token: 0x0401E333 RID: 123699
		PickupInTowerDefenceBattle,
		// Token: 0x0401E334 RID: 123700
		CheckOnSelectMenuMainType,
		// Token: 0x0401E335 RID: 123701
		OnShowPhantomInFormation,
		// Token: 0x0401E336 RID: 123702
		ForMoonChasingCheckTargetBuiltCount,
		// Token: 0x0401E337 RID: 123703
		ForMoonChasingCheckHasCanLevelUpBuilding,
		// Token: 0x0401E338 RID: 123704
		ForMoonChasingCheckNeedBranch,
		// Token: 0x0401E339 RID: 123705
		ForMoonChasingCheckHasNotFinishedTask,
		// Token: 0x0401E33A RID: 123706
		ForMoonChasingCheckTaskState,
		// Token: 0x0401E33B RID: 123707
		ForMoonChasingCheckMainlineTaskDone,
		// Token: 0x0401E33C RID: 123708
		ForMoonChasingOpenInteractive,
		// Token: 0x0401E33D RID: 123709
		CheckPureModeWhenBattleViewActive,
		// Token: 0x0401E33E RID: 123710
		OnActivitySubViewDone,
		// Token: 0x0401E33F RID: 123711
		CheckLockEnemyMode,
		// Token: 0x0401E340 RID: 123712
		CheckIsShowProgressBarInMapExploreDetailView,
		// Token: 0x0401E341 RID: 123713
		CheckIsMulti,
		// Token: 0x0401E342 RID: 123714
		CheckFishingRoleTechViewOpen,
		// Token: 0x0401E343 RID: 123715
		CheckFishingDockyardItemTipsShown,
		// Token: 0x0401E344 RID: 123716
		CheckShipTowerTeamOpen,
		// Token: 0x0401E345 RID: 123717
		CheckDockyardWareHouseHasItem,
		// Token: 0x0401E346 RID: 123718
		CheckFishingQteBtnHitValidArea,
		// Token: 0x0401E347 RID: 123719
		OnFishingQteScoreReachedMaximum,
		// Token: 0x0401E348 RID: 123720
		CheckFishingTechUnlock,
		// Token: 0x0401E349 RID: 123721
		OnFishingBackpackBtnStateChange,
		// Token: 0x0401E34A RID: 123722
		CheckFishingEntrustState,
		// Token: 0x0401E34B RID: 123723
		CheckFishingWareHouseItemListLength,
		// Token: 0x0401E34C RID: 123724
		CheckCurFishingEntrustAvailablePeriod,
		// Token: 0x0401E34D RID: 123725
		OnTreasureCompassUnitShow,
		// Token: 0x0401E34E RID: 123726
		OnFishingBackpackQuickSellToggleShow,
		// Token: 0x0401E34F RID: 123727
		HideSettingInCloudGame,
		// Token: 0x0401E350 RID: 123728
		OnPlayerTitleUnlock,
		// Token: 0x0401E351 RID: 123729
		CheckDangoMonopolyHasFinishedRound,
		// Token: 0x0401E352 RID: 123730
		OnDangoMonopolyMoveStop,
		// Token: 0x0401E353 RID: 123731
		OnDangoMonopolyViewShowProcessEnd,
		// Token: 0x0401E354 RID: 123732
		OnDangoAbyssPluginRoleSelect,
		// Token: 0x0401E355 RID: 123733
		CheckDangoMatchState,
		// Token: 0x0401E356 RID: 123734
		CheckDangoMatchPlayerNumType,
		// Token: 0x0401E357 RID: 123735
		OnEnterDangoMatchView,
		// Token: 0x0401E358 RID: 123736
		OnDangoMonopolyViewStart,
		// Token: 0x0401E359 RID: 123737
		OnCiacconaAvgInspirationChoiceShow,
		// Token: 0x0401E35A RID: 123738
		OnCiacconaChapterFirstStart,
		// Token: 0x0401E35B RID: 123739
		OnCiacconaChapterRestart,
		// Token: 0x0401E35C RID: 123740
		OnMovieRogueInfoRefreshWithMultipleEnds,
		// Token: 0x0401E35D RID: 123741
		CheckMovieRogueFinishedEndingCount,
		// Token: 0x0401E35E RID: 123742
		OnDangoAbyssEnterWithTeamExploreBtn,
		// Token: 0x0401E35F RID: 123743
		OnDangoAbyssEquipPluginWithValidChange,
		// Token: 0x0401E360 RID: 123744
		OnDangoAbyssEquipPluginWithInvalid,
		// Token: 0x0401E361 RID: 123745
		OnMovieRogueLinkRefresh,
		// Token: 0x0401E362 RID: 123746
		OnMovieRogueMapMoveEnd,
		// Token: 0x0401E363 RID: 123747
		OnMapRogueEventDetailShow,
		// Token: 0x0401E364 RID: 123748
		CheckMapRogueEventDetailShow,
		// Token: 0x0401E365 RID: 123749
		OnDangoMonopolyCameraFocusOnMainDango,
		// Token: 0x0401E366 RID: 123750
		CheckDangoAbyssProgress,
		// Token: 0x0401E367 RID: 123751
		CheckDangoAbyssHasItemByType,
		// Token: 0x0401E368 RID: 123752
		CheckDangoMatchFinalEnd,
		// Token: 0x0401E369 RID: 123753
		CheckGridHasExplored,
		// Token: 0x0401E36A RID: 123754
		GolemHackingID,
		// Token: 0x0401E36B RID: 123755
		WeeklyChallengeOpen,
		// Token: 0x0401E36C RID: 123756
		OnUiTabViewShow,
		// Token: 0x0401E36D RID: 123757
		OnNewViewCovered,
		// Token: 0x0401E36E RID: 123758
		OnHandCardsShow,
		// Token: 0x0401E36F RID: 123759
		OnCardDetailShowWithFactor,
		// Token: 0x0401E370 RID: 123760
		OnMonsterNumReachLimit,
		// Token: 0x0401E371 RID: 123761
		OnGetSpCard,
		// Token: 0x0401E372 RID: 123762
		CheckPhantomArenaChallengeId,
		// Token: 0x0401E373 RID: 123763
		CheckClientQuestNodeStatus,
		// Token: 0x0401E374 RID: 123764
		CheckAnyMoraleAreaFinishWithReward,
		// Token: 0x0401E375 RID: 123765
		OnMoraleTempExpItemShow,
		// Token: 0x0401E376 RID: 123766
		OnPhantomArenaChildViewShow,
		// Token: 0x0401E377 RID: 123767
		CheckNoMoraleAreaFinished,
		// Token: 0x0401E378 RID: 123768
		OnFloroRanchCardCountReachTarget,
		// Token: 0x0401E379 RID: 123769
		CheckFloroRanchRound,
		// Token: 0x0401E37A RID: 123770
		FloroRanchActivityID,
		// Token: 0x0401E37B RID: 123771
		CheckFloroRanchHasTechCanUnlock,
		// Token: 0x0401E37C RID: 123772
		OnKingShipFirstAttrShow,
		// Token: 0x0401E37D RID: 123773
		OnKingShipAllAttrShown,
		// Token: 0x0401E37E RID: 123774
		OnFloroRanchSettleViewOpenWithEndlessMode,
		// Token: 0x0401E37F RID: 123775
		CheckFloroRanchLevel,
		// Token: 0x0401E380 RID: 123776
		OnFloroRanchStageStartTaskFinish,
		// Token: 0x0401E381 RID: 123777
		CheckTrapDefenseTalentCanUnlock,
		// Token: 0x0401E382 RID: 123778
		CheckTrapDefenseHasCanUpgradeMachine,
		// Token: 0x0401E383 RID: 123779
		OnTrapDefenseAuxiliaryMachineUpgradeToMax,
		// Token: 0x0401E384 RID: 123780
		OnTrapDefenseMachineCanChooseBranch,
		// Token: 0x0401E385 RID: 123781
		CheckTrapDefenseLevelFinish,
		// Token: 0x0401E386 RID: 123782
		CheckTrapDefenseRogueUnlock,
		// Token: 0x0401E387 RID: 123783
		OnTrapDefenseBuffGroupUpgrade,
		// Token: 0x0401E388 RID: 123784
		TrapDefenseTotalStar,
		// Token: 0x0401E389 RID: 123785
		TrapDefensePassFullStar,
		// Token: 0x0401E38A RID: 123786
		TrapDefenseChallengeStar,
		// Token: 0x0401E38B RID: 123787
		OnTrapDefenseBuildingDevelopPreviewBtnShow,
		// Token: 0x0401E38C RID: 123788
		OnTrapDefenseDeployingBuilding,
		// Token: 0x0401E38D RID: 123789
		OnTrapDefenseBuildingDevelopBottomLayoutShow,
		// Token: 0x0401E38E RID: 123790
		CheckTrapDefenseMachineLevel,
		// Token: 0x0401E38F RID: 123791
		CheckTrapDefenseTalentUnlock,
		// Token: 0x0401E390 RID: 123792
		OnTrapDefenseMainLevelViewOpen,
		// Token: 0x0401E391 RID: 123793
		OnVisionIntensifyViewShow,
		// Token: 0x0401E392 RID: 123794
		OnSurvivorsRogueEndlessToggleShow,
		// Token: 0x0401E393 RID: 123795
		OnSurvivorsRogueComboBuffShow,
		// Token: 0x0401E394 RID: 123796
		CheckFightPhotoHasTarget,
		// Token: 0x0401E395 RID: 123797
		CheckFightPhotoLevelFinished,
		// Token: 0x0401E396 RID: 123798
		CheckCalabashChildFunctionOpen,
		// Token: 0x0401E397 RID: 123799
		OnSurvivorsRoguePopViewRefresh,
		// Token: 0x0401E398 RID: 123800
		CheckSurvivorRogueTalentCanUnlock,
		// Token: 0x0401E399 RID: 123801
		CheckSurvivorRogueHasWeaponBond,
		// Token: 0x0401E39A RID: 123802
		OnSurvivorsRogueWeaponDetailTabViewShow,
		// Token: 0x0401E39B RID: 123803
		AlwaysFalse,
		// Token: 0x0401E39C RID: 123804
		OnEnterOrExitBattle,
		// Token: 0x0401E39D RID: 123805
		OnHonamiStoryLifeSupportChange,
		// Token: 0x0401E39E RID: 123806
		OnPickUpHonamiStoryItem,
		// Token: 0x0401E39F RID: 123807
		OnSceneItemDurabilityEmpty,
		// Token: 0x0401E3A0 RID: 123808
		CheckPickUpHonamiStoryItemType,
		// Token: 0x0401E3A1 RID: 123809
		IsHasRecommendRecActivity,
		// Token: 0x0401E3A2 RID: 123810
		CheckMotorMovieModeStateChange,
		// Token: 0x0401E3A3 RID: 123811
		OnMotorMusicPlayerShow,
		// Token: 0x0401E3A4 RID: 123812
		OnMapCustomMarkPanelShow,
		// Token: 0x0401E3A5 RID: 123813
		OnPhantomArenaChooseCardPanelShow,
		// Token: 0x0401E3A6 RID: 123814
		OnPhantomArenaDiscardCardPanelShow,
		// Token: 0x0401E3A7 RID: 123815
		OnMotorDiyViewShow,
		// Token: 0x0401E3A8 RID: 123816
		OnPhantomArenaPlayFieldEffect,
		// Token: 0x0401E3A9 RID: 123817
		OnRollBlockDifficultyChanged,
		// Token: 0x0401E3AA RID: 123818
		CheckDungeonTypes,
		// Token: 0x0401E3AB RID: 123819
		OnEnterWheelTowerEndlessMode,
		// Token: 0x0401E3AC RID: 123820
		OnGuideTriggerEvent,
		// Token: 0x0401E3AD RID: 123821
		CheckUiItemShow,
		// Token: 0x0401E3AE RID: 123822
		CheckExploreSkillFlag,
		// Token: 0x0401E3AF RID: 123823
		CheckGuessJokerRound,
		// Token: 0x0401E3B0 RID: 123824
		CheckMotorFightLevelFinished,
		// Token: 0x0401E3B1 RID: 123825
		CheckEncircleChallengeId,
		// Token: 0x0401E3B2 RID: 123826
		OnFlagChallengeCalculatedLevelOver,
		// Token: 0x0401E3B3 RID: 123827
		CheckTetrisLevelId,
		// Token: 0x0401E3B4 RID: 123828
		CheckRhythmShipSubLevelHasRank,
		// Token: 0x0401E3B5 RID: 123829
		CheckDropCatchGameplayId,
		// Token: 0x0401E3B6 RID: 123830
		CheckTetrisScore,
		// Token: 0x0401E3B7 RID: 123831
		CheckNewPlayerSupportV2,
		// Token: 0x0401E3B8 RID: 123832
		CheckPinballLevelPass,
		// Token: 0x0401E3B9 RID: 123833
		CheckPinballWeaponCount,
		// Token: 0x0401E3BA RID: 123834
		OnNormalTopViewChange,
		// Token: 0x0401E3BB RID: 123835
		CheckPopIsTargetOrEmpty,
		// Token: 0x0401E3BC RID: 123836
		CheckKurotatoLevelWave,
		// Token: 0x0401E3BD RID: 123837
		CheckKurotatoLevelFinished,
		// Token: 0x0401E3BE RID: 123838
		CheckTrialRole,
		// Token: 0x0401E3BF RID: 123839
		CheckInteractiveItemsFunctionEnable,
		// Token: 0x0401E3C0 RID: 123840
		CheckPhantomTeam,
		// Token: 0x0401E3C1 RID: 123841
		CheckTrialAssist,
		// Token: 0x0401E3C2 RID: 123842
		CheckQuestClosedSegment,
		// Token: 0x0401E3C3 RID: 123843
		CheckGameplayClosedSegment,
		// Token: 0x0401E3C4 RID: 123844
		CheckOperationRestrict,
		// Token: 0x0401E3C5 RID: 123845
		CheckCameraMode,
		// Token: 0x0401E3C6 RID: 123846
		CheckCharacterMotionState,
		// Token: 0x0401E3C7 RID: 123847
		CheckCharacterTagsRestrict,
		// Token: 0x0401E3C8 RID: 123848
		CheckInteracting,
		// Token: 0x0401E3C9 RID: 123849
		CheckRoverlikeInstPassed,
		// Token: 0x0401E3CA RID: 123850
		CheckSubPackageDownLoadBtnShow,
		// Token: 0x0401E3CB RID: 123851
		CheckFightSpecialEnergyFull,
		// Token: 0x0401E3CC RID: 123852
		CheckNewbieGuideV2,
		// Token: 0x0401E3CD RID: 123853
		CheckFormationViewDimension,
		// Token: 0x0401E3CE RID: 123854
		CheckGiantCanChangeMood,
		// Token: 0x0401E3CF RID: 123855
		CheckInMatchThreeLevel,
		// Token: 0x0401E3D0 RID: 123856
		CheckMatchThreeLevelUnlocked,
		// Token: 0x0401E3D1 RID: 123857
		CheckMatchThreeSmallSkillCharged,
		// Token: 0x0401E3D2 RID: 123858
		CheckMatchThreeBoardHasComponent,
		// Token: 0x0401E3D3 RID: 123859
		OnDangoBrawlBackpackAddItem,
		// Token: 0x0401E3D4 RID: 123860
		CheckDangoBrawlLevelRound,
		// Token: 0x0401E3D5 RID: 123861
		OnDangoBrawlHasCombinableItem,
		// Token: 0x0401E3D6 RID: 123862
		CheckDangoBrawlLevelPassed,
		// Token: 0x0401E3D7 RID: 123863
		OnSolarSchoolItemTipsRefreshed,
		// Token: 0x0401E3D8 RID: 123864
		CheckRoleTowerEquippedToken,
		// Token: 0x0401E3D9 RID: 123865
		CheckRoleTowerCurrentStage,
		// Token: 0x0401E3DA RID: 123866
		CheckRoleTowerEchoLevel,
		// Token: 0x0401E3DB RID: 123867
		CheckActivityCondition,
		// Token: 0x0401E3DC RID: 123868
		OnCommonChildViewShowDone,
		// Token: 0x0401E3DD RID: 123869
		CheckPlayerInOpenArea
	}
}
