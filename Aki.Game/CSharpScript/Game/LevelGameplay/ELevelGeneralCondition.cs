using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069AE RID: 27054
	[EnumExtensions]
	public enum ELevelGeneralCondition
	{
		// Token: 0x040230DA RID: 143578
		DistanceLess,
		// Token: 0x040230DB RID: 143579
		SelfTagCheck,
		// Token: 0x040230DC RID: 143580
		ItemCheck,
		// Token: 0x040230DD RID: 143581
		CheckItemWithOperator,
		// Token: 0x040230DE RID: 143582
		CheckDis,
		// Token: 0x040230DF RID: 143583
		TargetTagCheck,
		// Token: 0x040230E0 RID: 143584
		CheckOnTrap,
		// Token: 0x040230E1 RID: 143585
		CheckDirection,
		// Token: 0x040230E2 RID: 143586
		QuestState,
		// Token: 0x040230E3 RID: 143587
		CheckStrikeInfo,
		// Token: 0x040230E4 RID: 143588
		CheckLevel,
		// Token: 0x040230E5 RID: 143589
		CheckLevelOp,
		// Token: 0x040230E6 RID: 143590
		CheckGuideStatus,
		// Token: 0x040230E7 RID: 143591
		CheckCharacterTag,
		// Token: 0x040230E8 RID: 143592
		CheckCharacterTagByEvent,
		// Token: 0x040230E9 RID: 143593
		CheckCharacterTagNotByEvent,
		// Token: 0x040230EA RID: 143594
		CheckCharacterVehicleTagByEvent,
		// Token: 0x040230EB RID: 143595
		CheckCharacterVehicleTagNotByEvent,
		// Token: 0x040230EC RID: 143596
		DragonPoolState,
		// Token: 0x040230ED RID: 143597
		SceneStepState,
		// Token: 0x040230EE RID: 143598
		CheckTeleportStatus,
		// Token: 0x040230EF RID: 143599
		RoleLevel,
		// Token: 0x040230F0 RID: 143600
		CheckRoleLevel,
		// Token: 0x040230F1 RID: 143601
		CheckRoleOwned,
		// Token: 0x040230F2 RID: 143602
		RoleBreach,
		// Token: 0x040230F3 RID: 143603
		SelfGameplayTagCheck,
		// Token: 0x040230F4 RID: 143604
		CheckInTodTimeSpan,
		// Token: 0x040230F5 RID: 143605
		[EnumStringMember("CheckEntityCommonTag")]
		CheckSceneItemTag,
		// Token: 0x040230F6 RID: 143606
		IsPlayer,
		// Token: 0x040230F7 RID: 143607
		CheckEntityConfigId,
		// Token: 0x040230F8 RID: 143608
		CheckSelfEntityCommonTag,
		// Token: 0x040230F9 RID: 143609
		CheckInstanceEntranceUnlockStatus,
		// Token: 0x040230FA RID: 143610
		CheckOriginWorldLevel,
		// Token: 0x040230FB RID: 143611
		CheckCurWorldLevel,
		// Token: 0x040230FC RID: 143612
		CheckCurWorldLevelOp,
		// Token: 0x040230FD RID: 143613
		StartShootTarget,
		// Token: 0x040230FE RID: 143614
		CheckInstanceState,
		// Token: 0x040230FF RID: 143615
		CheckInstanceMatchAble,
		// Token: 0x04023100 RID: 143616
		MoveStateCheck,
		// Token: 0x04023101 RID: 143617
		[EnumStringMember("LevelConditionCheckBuff")]
		CheckBuff,
		// Token: 0x04023102 RID: 143618
		CheckUIState,
		// Token: 0x04023103 RID: 143619
		CheckUIOpen,
		// Token: 0x04023104 RID: 143620
		CheckUIOpenDone,
		// Token: 0x04023105 RID: 143621
		CheckUIShowDone,
		// Token: 0x04023106 RID: 143622
		CheckInputAction,
		// Token: 0x04023107 RID: 143623
		CheckClientUseSkill,
		// Token: 0x04023108 RID: 143624
		CheckClientUseVisionSkill,
		// Token: 0x04023109 RID: 143625
		CheckBattleRole,
		// Token: 0x0402310A RID: 143626
		CheckEquippedPhantom,
		// Token: 0x0402310B RID: 143627
		CheckEnemyBuff,
		// Token: 0x0402310C RID: 143628
		CheckEnemyTag,
		// Token: 0x0402310D RID: 143629
		CheckSkillPoint,
		// Token: 0x0402310E RID: 143630
		CheckExploreSkill,
		// Token: 0x0402310F RID: 143631
		CheckFightEnergyBar,
		// Token: 0x04023110 RID: 143632
		CheckFightEnergyBall,
		// Token: 0x04023111 RID: 143633
		FunctionUnlock,
		// Token: 0x04023112 RID: 143634
		GetNewItem,
		// Token: 0x04023113 RID: 143635
		HarmonyQte,
		// Token: 0x04023114 RID: 143636
		GetWhichRole,
		// Token: 0x04023115 RID: 143637
		HpLowerThan,
		// Token: 0x04023116 RID: 143638
		FightWithMonster,
		// Token: 0x04023117 RID: 143639
		PawnInRange,
		// Token: 0x04023118 RID: 143640
		SlotOfCurrentRole,
		// Token: 0x04023119 RID: 143641
		PhantomTargetLevel,
		// Token: 0x0402311A RID: 143642
		CheckClientQuest,
		// Token: 0x0402311B RID: 143643
		CheckClientQuestNode,
		// Token: 0x0402311C RID: 143644
		PhantomMaxLevel,
		// Token: 0x0402311D RID: 143645
		RoleTargetLevel,
		// Token: 0x0402311E RID: 143646
		RoleSkillTargetLevel,
		// Token: 0x0402311F RID: 143647
		BattleRoleIsNot,
		// Token: 0x04023120 RID: 143648
		BattleRoleWeaponType,
		// Token: 0x04023121 RID: 143649
		FormationAnyRoleDead,
		// Token: 0x04023122 RID: 143650
		ComboTeachingState,
		// Token: 0x04023123 RID: 143651
		OnViewClose,
		// Token: 0x04023124 RID: 143652
		OnPlayerUseSkill,
		// Token: 0x04023125 RID: 143653
		OnSkillButtonDataRefresh,
		// Token: 0x04023126 RID: 143654
		FinishGuideStepByEvent,
		// Token: 0x04023127 RID: 143655
		PlayerRevive,
		// Token: 0x04023128 RID: 143656
		CheckTeamRoleCouldLevelUp,
		// Token: 0x04023129 RID: 143657
		CheckTeamWeaponCouldLevelUp,
		// Token: 0x0402312A RID: 143658
		ClientCalabashLevel,
		// Token: 0x0402312B RID: 143659
		TeamRoleLevel,
		// Token: 0x0402312C RID: 143660
		TeamWeaponLevel,
		// Token: 0x0402312D RID: 143661
		TeamCouldEquipPhantom,
		// Token: 0x0402312E RID: 143662
		CheckAnyPhantomCouldUpdate,
		// Token: 0x0402312F RID: 143663
		CheckAnyRoleFullPhantom,
		// Token: 0x04023130 RID: 143664
		CheckRolePhantomNum,
		// Token: 0x04023131 RID: 143665
		CheckItemCountByType,
		// Token: 0x04023132 RID: 143666
		CheckRouletteEquipItemId,
		// Token: 0x04023133 RID: 143667
		CheckVisionIntensifyTabOpen,
		// Token: 0x04023134 RID: 143668
		CheckAccountSettingOpen,
		// Token: 0x04023135 RID: 143669
		CheckOnTreasureBoxOpen,
		// Token: 0x04023136 RID: 143670
		CheckWeaponCount,
		// Token: 0x04023137 RID: 143671
		CheckOnCostInsufficient,
		// Token: 0x04023138 RID: 143672
		CheckRangeByPbDataId,
		// Token: 0x04023139 RID: 143673
		CheckDungeonId,
		// Token: 0x0402313A RID: 143674
		CheckRogueTerm,
		// Token: 0x0402313B RID: 143675
		CheckTeleportTypeUnlock,
		// Token: 0x0402313C RID: 143676
		CheckTypeItemPickUp,
		// Token: 0x0402313D RID: 143677
		CheckDungeonFinished,
		// Token: 0x0402313E RID: 143678
		CheckRogueCanUnlockSkill,
		// Token: 0x0402313F RID: 143679
		CheckPositionRolePhantomSkillEquip,
		// Token: 0x04023140 RID: 143680
		CheckHasFirstPhantomAtPosition,
		// Token: 0x04023141 RID: 143681
		CheckWorldMapSecondaryUiOpened,
		// Token: 0x04023142 RID: 143682
		CheckHasUnlockAffixInBossRush,
		// Token: 0x04023143 RID: 143683
		OnChangeBossRushBuff,
		// Token: 0x04023144 RID: 143684
		RoguelikeHasSelectEntryAndShow,
		// Token: 0x04023145 RID: 143685
		CheckActivityOpen,
		// Token: 0x04023146 RID: 143686
		CheckHasSkinInRoleSkinSubView,
		// Token: 0x04023147 RID: 143687
		OnTakingPhoto,
		// Token: 0x04023148 RID: 143688
		HasNotInvitedRoleInSpring25,
		// Token: 0x04023149 RID: 143689
		CheckMapFocusByQuestId,
		// Token: 0x0402314A RID: 143690
		OnWorldMapGravityBtnShow,
		// Token: 0x0402314B RID: 143691
		PickupInTowerDefenceBattle,
		// Token: 0x0402314C RID: 143692
		CheckOnSelectMenuMainType,
		// Token: 0x0402314D RID: 143693
		OnShowPhantomInFormation,
		// Token: 0x0402314E RID: 143694
		ForMoonChasingCheckTargetBuiltCount,
		// Token: 0x0402314F RID: 143695
		ForMoonChasingCheckHasCanLevelUpBuilding,
		// Token: 0x04023150 RID: 143696
		ForMoonChasingCheckNeedBranch,
		// Token: 0x04023151 RID: 143697
		ForMoonChasingCheckHasNotFinishedTask,
		// Token: 0x04023152 RID: 143698
		ForMoonChasingCheckTaskState,
		// Token: 0x04023153 RID: 143699
		ForMoonChasingCheckMainlineTaskDone,
		// Token: 0x04023154 RID: 143700
		ForMoonChasingOpenInteractive,
		// Token: 0x04023155 RID: 143701
		CheckPureModeWhenBattleViewActive,
		// Token: 0x04023156 RID: 143702
		OnActivitySubViewDone,
		// Token: 0x04023157 RID: 143703
		CheckLockEnemyMode,
		// Token: 0x04023158 RID: 143704
		CheckIsShowProgressBarInMapExploreDetailView,
		// Token: 0x04023159 RID: 143705
		CheckIsMulti,
		// Token: 0x0402315A RID: 143706
		CheckFishingRoleTechViewOpen,
		// Token: 0x0402315B RID: 143707
		CheckFishingDockyardItemTipsShown,
		// Token: 0x0402315C RID: 143708
		CheckShipTowerTeamOpen,
		// Token: 0x0402315D RID: 143709
		CheckDockyardWareHouseHasItem,
		// Token: 0x0402315E RID: 143710
		CheckFishingQteBtnHitValidArea,
		// Token: 0x0402315F RID: 143711
		OnFishingQteScoreReachedMaximum,
		// Token: 0x04023160 RID: 143712
		CheckFishingTechUnlock,
		// Token: 0x04023161 RID: 143713
		OnFishingBackpackBtnStateChange,
		// Token: 0x04023162 RID: 143714
		CheckFishingEntrustState,
		// Token: 0x04023163 RID: 143715
		CheckFishingWareHouseItemListLength,
		// Token: 0x04023164 RID: 143716
		CheckCurFishingEntrustAvailablePeriod,
		// Token: 0x04023165 RID: 143717
		OnTreasureCompassUnitShow,
		// Token: 0x04023166 RID: 143718
		OnFishingBackpackQuickSellToggleShow,
		// Token: 0x04023167 RID: 143719
		HideSettingInCloudGame,
		// Token: 0x04023168 RID: 143720
		OnPlayerTitleUnlock,
		// Token: 0x04023169 RID: 143721
		CheckDangoMonopolyHasFinishedRound,
		// Token: 0x0402316A RID: 143722
		OnDangoMonopolyMoveStop,
		// Token: 0x0402316B RID: 143723
		OnDangoMonopolyViewShowProcessEnd,
		// Token: 0x0402316C RID: 143724
		OnDangoAbyssPluginRoleSelect,
		// Token: 0x0402316D RID: 143725
		CheckDangoMatchState,
		// Token: 0x0402316E RID: 143726
		CheckDangoMatchPlayerNumType,
		// Token: 0x0402316F RID: 143727
		OnEnterDangoMatchView,
		// Token: 0x04023170 RID: 143728
		OnDangoMonopolyViewStart,
		// Token: 0x04023171 RID: 143729
		OnCiacconaAvgInspirationChoiceShow,
		// Token: 0x04023172 RID: 143730
		OnCiacconaChapterFirstStart,
		// Token: 0x04023173 RID: 143731
		OnCiacconaChapterRestart,
		// Token: 0x04023174 RID: 143732
		OnMovieRogueInfoRefreshWithMultipleEnds,
		// Token: 0x04023175 RID: 143733
		CheckMovieRogueFinishedEndingCount,
		// Token: 0x04023176 RID: 143734
		OnDangoAbyssEnterWithTeamExploreBtn,
		// Token: 0x04023177 RID: 143735
		OnDangoAbyssEquipPluginWithValidChange,
		// Token: 0x04023178 RID: 143736
		OnDangoAbyssEquipPluginWithInvalid,
		// Token: 0x04023179 RID: 143737
		OnMovieRogueLinkRefresh,
		// Token: 0x0402317A RID: 143738
		OnMovieRogueMapMoveEnd,
		// Token: 0x0402317B RID: 143739
		OnMapRogueEventDetailShow,
		// Token: 0x0402317C RID: 143740
		CheckMapRogueEventDetailShow,
		// Token: 0x0402317D RID: 143741
		OnDangoMonopolyCameraFocusOnMainDango,
		// Token: 0x0402317E RID: 143742
		CheckDangoAbyssProgress,
		// Token: 0x0402317F RID: 143743
		CheckDangoAbyssHasItemByType,
		// Token: 0x04023180 RID: 143744
		CheckDangoMatchFinalEnd,
		// Token: 0x04023181 RID: 143745
		CheckGridHasExplored,
		// Token: 0x04023182 RID: 143746
		GolemHackingID,
		// Token: 0x04023183 RID: 143747
		WeeklyChallengeOpen,
		// Token: 0x04023184 RID: 143748
		OnUiTabViewShow,
		// Token: 0x04023185 RID: 143749
		OnNewViewCovered,
		// Token: 0x04023186 RID: 143750
		OnHandCardsShow,
		// Token: 0x04023187 RID: 143751
		OnCardDetailShowWithFactor,
		// Token: 0x04023188 RID: 143752
		OnMonsterNumReachLimit,
		// Token: 0x04023189 RID: 143753
		OnGetSpCard,
		// Token: 0x0402318A RID: 143754
		CheckPhantomArenaChallengeId,
		// Token: 0x0402318B RID: 143755
		CheckClientQuestNodeStatus,
		// Token: 0x0402318C RID: 143756
		CheckAnyMoraleAreaFinishWithReward,
		// Token: 0x0402318D RID: 143757
		OnMoraleTempExpItemShow,
		// Token: 0x0402318E RID: 143758
		OnPhantomArenaChildViewShow,
		// Token: 0x0402318F RID: 143759
		CheckNoMoraleAreaFinished,
		// Token: 0x04023190 RID: 143760
		OnFloroRanchCardCountReachTarget,
		// Token: 0x04023191 RID: 143761
		CheckFloroRanchRound,
		// Token: 0x04023192 RID: 143762
		FloroRanchActivityID,
		// Token: 0x04023193 RID: 143763
		CheckFloroRanchHasTechCanUnlock,
		// Token: 0x04023194 RID: 143764
		OnKingShipFirstAttrShow,
		// Token: 0x04023195 RID: 143765
		OnKingShipAllAttrShown,
		// Token: 0x04023196 RID: 143766
		OnFloroRanchSettleViewOpenWithEndlessMode,
		// Token: 0x04023197 RID: 143767
		CheckFloroRanchLevel,
		// Token: 0x04023198 RID: 143768
		OnFloroRanchStageStartTaskFinish,
		// Token: 0x04023199 RID: 143769
		CheckTrapDefenseTalentCanUnlock,
		// Token: 0x0402319A RID: 143770
		CheckTrapDefenseHasCanUpgradeMachine,
		// Token: 0x0402319B RID: 143771
		OnTrapDefenseAuxiliaryMachineUpgradeToMax,
		// Token: 0x0402319C RID: 143772
		OnTrapDefenseMachineCanChooseBranch,
		// Token: 0x0402319D RID: 143773
		CheckTrapDefenseLevelFinish,
		// Token: 0x0402319E RID: 143774
		CheckTrapDefenseRogueUnlock,
		// Token: 0x0402319F RID: 143775
		OnTrapDefenseBuffGroupUpgrade,
		// Token: 0x040231A0 RID: 143776
		TrapDefenseTotalStar,
		// Token: 0x040231A1 RID: 143777
		TrapDefensePassFullStar,
		// Token: 0x040231A2 RID: 143778
		TrapDefenseChallengeStar,
		// Token: 0x040231A3 RID: 143779
		OnTrapDefenseBuildingDevelopPreviewBtnShow,
		// Token: 0x040231A4 RID: 143780
		OnTrapDefenseDeployingBuilding,
		// Token: 0x040231A5 RID: 143781
		OnTrapDefenseBuildingDevelopBottomLayoutShow,
		// Token: 0x040231A6 RID: 143782
		CheckTrapDefenseMachineLevel,
		// Token: 0x040231A7 RID: 143783
		CheckTrapDefenseTalentUnlock,
		// Token: 0x040231A8 RID: 143784
		OnTrapDefenseMainLevelViewOpen,
		// Token: 0x040231A9 RID: 143785
		OnVisionIntensifyViewShow,
		// Token: 0x040231AA RID: 143786
		OnSurvivorsRogueEndlessToggleShow,
		// Token: 0x040231AB RID: 143787
		OnSurvivorsRogueComboBuffShow,
		// Token: 0x040231AC RID: 143788
		CheckFightPhotoHasTarget,
		// Token: 0x040231AD RID: 143789
		CheckFightPhotoLevelFinished,
		// Token: 0x040231AE RID: 143790
		CheckCalabashChildFunctionOpen,
		// Token: 0x040231AF RID: 143791
		OnSurvivorsRoguePopViewRefresh,
		// Token: 0x040231B0 RID: 143792
		CheckSurvivorRogueTalentCanUnlock,
		// Token: 0x040231B1 RID: 143793
		CheckSurvivorRogueHasWeaponBond,
		// Token: 0x040231B2 RID: 143794
		OnSurvivorsRogueWeaponDetailTabViewShow,
		// Token: 0x040231B3 RID: 143795
		AlwaysFalse,
		// Token: 0x040231B4 RID: 143796
		OnEnterOrExitBattle,
		// Token: 0x040231B5 RID: 143797
		OnHonamiStoryLifeSupportChange,
		// Token: 0x040231B6 RID: 143798
		OnPickUpHonamiStoryItem,
		// Token: 0x040231B7 RID: 143799
		OnSceneItemDurabilityEmpty,
		// Token: 0x040231B8 RID: 143800
		CheckPickUpHonamiStoryItemType,
		// Token: 0x040231B9 RID: 143801
		IsHasRecommendRecActivity,
		// Token: 0x040231BA RID: 143802
		CheckMotorMovieModeStateChange,
		// Token: 0x040231BB RID: 143803
		OnMotorMusicPlayerShow,
		// Token: 0x040231BC RID: 143804
		OnMapCustomMarkPanelShow,
		// Token: 0x040231BD RID: 143805
		OnPhantomArenaChooseCardPanelShow,
		// Token: 0x040231BE RID: 143806
		OnPhantomArenaDiscardCardPanelShow,
		// Token: 0x040231BF RID: 143807
		OnMotorDiyViewShow,
		// Token: 0x040231C0 RID: 143808
		OnPhantomArenaPlayFieldEffect,
		// Token: 0x040231C1 RID: 143809
		OnRollBlockDifficultyChanged,
		// Token: 0x040231C2 RID: 143810
		CheckDungeonTypes,
		// Token: 0x040231C3 RID: 143811
		OnEnterWheelTowerEndlessMode,
		// Token: 0x040231C4 RID: 143812
		OnGuideTriggerEvent,
		// Token: 0x040231C5 RID: 143813
		CheckUiItemShow,
		// Token: 0x040231C6 RID: 143814
		CheckExploreSkillFlag,
		// Token: 0x040231C7 RID: 143815
		CheckGuessJokerRound,
		// Token: 0x040231C8 RID: 143816
		CheckMotorFightLevelFinished,
		// Token: 0x040231C9 RID: 143817
		CheckEncircleChallengeId,
		// Token: 0x040231CA RID: 143818
		OnFlagChallengeCalculatedLevelOver,
		// Token: 0x040231CB RID: 143819
		CheckTetrisLevelId,
		// Token: 0x040231CC RID: 143820
		CheckRhythmShipSubLevelHasRank,
		// Token: 0x040231CD RID: 143821
		CheckDropCatchGameplayId,
		// Token: 0x040231CE RID: 143822
		CheckTetrisScore,
		// Token: 0x040231CF RID: 143823
		CheckNewPlayerSupportV2,
		// Token: 0x040231D0 RID: 143824
		CheckPinballLevelPass,
		// Token: 0x040231D1 RID: 143825
		CheckPinballWeaponCount,
		// Token: 0x040231D2 RID: 143826
		OnNormalTopViewChange,
		// Token: 0x040231D3 RID: 143827
		CheckPopIsTargetOrEmpty,
		// Token: 0x040231D4 RID: 143828
		CheckKurotatoLevelWave,
		// Token: 0x040231D5 RID: 143829
		CheckKurotatoLevelFinished,
		// Token: 0x040231D6 RID: 143830
		CheckTrialRole,
		// Token: 0x040231D7 RID: 143831
		CheckInteractiveItemsFunctionEnable,
		// Token: 0x040231D8 RID: 143832
		CheckPhantomTeam,
		// Token: 0x040231D9 RID: 143833
		CheckTrialAssist,
		// Token: 0x040231DA RID: 143834
		CheckQuestClosedSegment,
		// Token: 0x040231DB RID: 143835
		CheckGameplayClosedSegment,
		// Token: 0x040231DC RID: 143836
		CheckOperationRestrict,
		// Token: 0x040231DD RID: 143837
		CheckCameraMode,
		// Token: 0x040231DE RID: 143838
		CheckCharacterMotionState,
		// Token: 0x040231DF RID: 143839
		CheckCharacterTagsRestrict,
		// Token: 0x040231E0 RID: 143840
		CheckInteracting,
		// Token: 0x040231E1 RID: 143841
		CheckRoverlikeInstPassed,
		// Token: 0x040231E2 RID: 143842
		CheckSubPackageDownLoadBtnShow,
		// Token: 0x040231E3 RID: 143843
		CheckFightSpecialEnergyFull,
		// Token: 0x040231E4 RID: 143844
		CheckNewbieGuideV2,
		// Token: 0x040231E5 RID: 143845
		CheckFormationViewDimension,
		// Token: 0x040231E6 RID: 143846
		CheckGiantCanChangeMood,
		// Token: 0x040231E7 RID: 143847
		CheckInMatchThreeLevel,
		// Token: 0x040231E8 RID: 143848
		CheckMatchThreeLevelUnlocked,
		// Token: 0x040231E9 RID: 143849
		CheckMatchThreeSmallSkillCharged,
		// Token: 0x040231EA RID: 143850
		CheckMatchThreeBoardHasComponent,
		// Token: 0x040231EB RID: 143851
		OnDangoBrawlBackpackAddItem,
		// Token: 0x040231EC RID: 143852
		CheckDangoBrawlLevelRound,
		// Token: 0x040231ED RID: 143853
		OnDangoBrawlHasCombinableItem,
		// Token: 0x040231EE RID: 143854
		CheckDangoBrawlLevelPassed
	}
}
