using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066EB RID: 26347
	public enum IActionParams_Union_0 : byte
	{
		// Token: 0x04011058 RID: 69720
		NONE,
		// Token: 0x04011059 RID: 69721
		IActionParams,
		// Token: 0x0401105A RID: 69722
		IInvoke,
		// Token: 0x0401105B RID: 69723
		IInteract,
		// Token: 0x0401105C RID: 69724
		IFinishCondition,
		// Token: 0x0401105D RID: 69725
		IGetRewardByInteract,
		// Token: 0x0401105E RID: 69726
		IWaitUntilLevelSequenceReachMark,
		// Token: 0x0401105F RID: 69727
		IClearEntityVisibleTag,
		// Token: 0x04011060 RID: 69728
		ISetEntityPos,
		// Token: 0x04011061 RID: 69729
		IResetEntityPos,
		// Token: 0x04011062 RID: 69730
		IServerSetPlayerPos,
		// Token: 0x04011063 RID: 69731
		IFixTeleControllerPos,
		// Token: 0x04011064 RID: 69732
		IFixTeleControllerResetPos,
		// Token: 0x04011065 RID: 69733
		IFixFoundationRelation,
		// Token: 0x04011066 RID: 69734
		ITraceCurrentQuest,
		// Token: 0x04011067 RID: 69735
		IFixShowTargetRange,
		// Token: 0x04011068 RID: 69736
		IFixGetItem,
		// Token: 0x04011069 RID: 69737
		ILog,
		// Token: 0x0401106A RID: 69738
		IShowMessage,
		// Token: 0x0401106B RID: 69739
		IPrompt,
		// Token: 0x0401106C RID: 69740
		ISendNpcMail,
		// Token: 0x0401106D RID: 69741
		IAdjustTodTime,
		// Token: 0x0401106E RID: 69742
		ISetAreaTimeState,
		// Token: 0x0401106F RID: 69743
		ISetTimeScale,
		// Token: 0x04011070 RID: 69744
		IJumpTalk,
		// Token: 0x04011071 RID: 69745
		ISetHeadIconVisible,
		// Token: 0x04011072 RID: 69746
		IPlayMontage,
		// Token: 0x04011073 RID: 69747
		IAvgPlayRoleAction,
		// Token: 0x04011074 RID: 69748
		IAvgMoveRole,
		// Token: 0x04011075 RID: 69749
		IAvgFocusRole,
		// Token: 0x04011076 RID: 69750
		IAvgShakeUi,
		// Token: 0x04011077 RID: 69751
		IDestroyDynamicEntities,
		// Token: 0x04011078 RID: 69752
		IActorLookAt,
		// Token: 0x04011079 RID: 69753
		IActorTurnTo,
		// Token: 0x0401107A RID: 69754
		IShowTalk,
		// Token: 0x0401107B RID: 69755
		IFinishTalk,
		// Token: 0x0401107C RID: 69756
		IShowCenterText,
		// Token: 0x0401107D RID: 69757
		IFinishState,
		// Token: 0x0401107E RID: 69758
		IChangeState,
		// Token: 0x0401107F RID: 69759
		IChangeBehaviorState,
		// Token: 0x04011080 RID: 69760
		ISetBehaviorIsPaused,
		// Token: 0x04011081 RID: 69761
		IChangeRandomState,
		// Token: 0x04011082 RID: 69762
		IChangeActorState,
		// Token: 0x04011083 RID: 69763
		IChangeOtherState,
		// Token: 0x04011084 RID: 69764
		ISetCameraMode,
		// Token: 0x04011085 RID: 69765
		IModifySceneUiSubtitle,
		// Token: 0x04011086 RID: 69766
		ISetPlotMode,
		// Token: 0x04011087 RID: 69767
		IPlaySequenceData,
		// Token: 0x04011088 RID: 69768
		IPlayCustomSequence,
		// Token: 0x04011089 RID: 69769
		IPlayMovie,
		// Token: 0x0401108A RID: 69770
		IPlayEffect,
		// Token: 0x0401108B RID: 69771
		IPlayEffect2,
		// Token: 0x0401108C RID: 69772
		IPlayCommonEffect,
		// Token: 0x0401108D RID: 69773
		IPlayScreenEffect,
		// Token: 0x0401108E RID: 69774
		ISwitchEffectState,
		// Token: 0x0401108F RID: 69775
		IPlayDissolveEffect,
		// Token: 0x04011090 RID: 69776
		IPlayMpcEffect,
		// Token: 0x04011091 RID: 69777
		IRemoveEffect,
		// Token: 0x04011092 RID: 69778
		IWait,
		// Token: 0x04011093 RID: 69779
		IMoveToPosA,
		// Token: 0x04011094 RID: 69780
		ISetMoveSpeed,
		// Token: 0x04011095 RID: 69781
		ISetPosA,
		// Token: 0x04011096 RID: 69782
		IFaceToPos,
		// Token: 0x04011097 RID: 69783
		ISpawnChild,
		// Token: 0x04011098 RID: 69784
		ISimpleMove,
		// Token: 0x04011099 RID: 69785
		ISetNumberVar,
		// Token: 0x0401109A RID: 69786
		ISyncVarToActorState,
		// Token: 0x0401109B RID: 69787
		IDoCalculate,
		// Token: 0x0401109C RID: 69788
		ICallByCondition,
		// Token: 0x0401109D RID: 69789
		ICallFunction,
		// Token: 0x0401109E RID: 69790
		IAddFlowInteractOption,
		// Token: 0x0401109F RID: 69791
		IRemoveFlowInteractOption,
		// Token: 0x040110A0 RID: 69792
		IChangeInteractOptionText,
		// Token: 0x040110A1 RID: 69793
		ISpawnEntity,
		// Token: 0x040110A2 RID: 69794
		IDestroyAllChild,
		// Token: 0x040110A3 RID: 69795
		IDestroyEntity,
		// Token: 0x040110A4 RID: 69796
		IPlayFlow,
		// Token: 0x040110A5 RID: 69797
		IBubbleData,
		// Token: 0x040110A6 RID: 69798
		IPlayerLookAt,
		// Token: 0x040110A7 RID: 69799
		IEntityLookAt,
		// Token: 0x040110A8 RID: 69800
		ICharacterLookAt,
		// Token: 0x040110A9 RID: 69801
		IPlayerLookTowards,
		// Token: 0x040110AA RID: 69802
		IEntityTurnTo,
		// Token: 0x040110AB RID: 69803
		ICameraLookAt,
		// Token: 0x040110AC RID: 69804
		IStopCameraLookAt,
		// Token: 0x040110AD RID: 69805
		ISetVar,
		// Token: 0x040110AE RID: 69806
		ISetActorVar,
		// Token: 0x040110AF RID: 69807
		ICalculateVar,
		// Token: 0x040110B0 RID: 69808
		IRandomVar,
		// Token: 0x040110B1 RID: 69809
		IGuideTrigger,
		// Token: 0x040110B2 RID: 69810
		ICompleteGuide,
		// Token: 0x040110B3 RID: 69811
		IGetItem,
		// Token: 0x040110B4 RID: 69812
		IDestroyQuestItem,
		// Token: 0x040110B5 RID: 69813
		IAwakeEntity,
		// Token: 0x040110B6 RID: 69814
		ISetEntityVisible,
		// Token: 0x040110B7 RID: 69815
		ISetEntityClientVisible,
		// Token: 0x040110B8 RID: 69816
		ISetEntityClientVisibleSave,
		// Token: 0x040110B9 RID: 69817
		ILockEntity,
		// Token: 0x040110BA RID: 69818
		IUnlockEntity,
		// Token: 0x040110BB RID: 69819
		ICompleteChildQuest,
		// Token: 0x040110BC RID: 69820
		IAcceptCurrentQuest,
		// Token: 0x040110BD RID: 69821
		IFinishDoInteract,
		// Token: 0x040110BE RID: 69822
		IModifyEntityDecoration,
		// Token: 0x040110BF RID: 69823
		IAddBuffToEntity,
		// Token: 0x040110C0 RID: 69824
		IAddBuffToPlayer,
		// Token: 0x040110C1 RID: 69825
		IAddBuffToFollowShooter,
		// Token: 0x040110C2 RID: 69826
		IOpenSystemBoard,
		// Token: 0x040110C3 RID: 69827
		IOpenSystemFunction,
		// Token: 0x040110C4 RID: 69828
		IChangeEntityState,
		// Token: 0x040110C5 RID: 69829
		IChangeEntityStateDirectly,
		// Token: 0x040110C6 RID: 69830
		IChangeEntityStateBatchDirectly,
		// Token: 0x040110C7 RID: 69831
		IChangeEntityStateLoop,
		// Token: 0x040110C8 RID: 69832
		IChangeNpcPerformState,
		// Token: 0x040110C9 RID: 69833
		ISetForceLock,
		// Token: 0x040110CA RID: 69834
		ISetAreaState,
		// Token: 0x040110CB RID: 69835
		ISetWuYinQuState,
		// Token: 0x040110CC RID: 69836
		IRemoveBuffFromEntity,
		// Token: 0x040110CD RID: 69837
		IRemoveBuffFromPlayer,
		// Token: 0x040110CE RID: 69838
		ICollect,
		// Token: 0x040110CF RID: 69839
		IDestroy,
		// Token: 0x040110D0 RID: 69840
		IDestroySelf,
		// Token: 0x040110D1 RID: 69841
		ISetPlayerMoveControl,
		// Token: 0x040110D2 RID: 69842
		IUnlockTeleportTrigger,
		// Token: 0x040110D3 RID: 69843
		IChangeTeamPosition,
		// Token: 0x040110D4 RID: 69844
		IClientChangeTeamPosition,
		// Token: 0x040110D5 RID: 69845
		IClaimLevelPlayReward,
		// Token: 0x040110D6 RID: 69846
		IClaimDynamicEntityReward,
		// Token: 0x040110D7 RID: 69847
		IClearFishingCabinInSaleItems,
		// Token: 0x040110D8 RID: 69848
		IAcceptFishingEntrust,
		// Token: 0x040110D9 RID: 69849
		IDestroyFishingBoat,
		// Token: 0x040110DA RID: 69850
		ITeleportDungeon,
		// Token: 0x040110DB RID: 69851
		IStopUiScreenEffect,
		// Token: 0x040110DC RID: 69852
		IClaimDungeonReward,
		// Token: 0x040110DD RID: 69853
		ISettlementDungeon,
		// Token: 0x040110DE RID: 69854
		IExitDungeon,
		// Token: 0x040110DF RID: 69855
		IUnlockDungeonEntry,
		// Token: 0x040110E0 RID: 69856
		IFinishDungeon,
		// Token: 0x040110E1 RID: 69857
		ISetReviveRegion,
		// Token: 0x040110E2 RID: 69858
		IPromptQuestChapterUI,
		// Token: 0x040110E3 RID: 69859
		IFireBullet,
		// Token: 0x040110E4 RID: 69860
		IFireBulletEffect,
		// Token: 0x040110E5 RID: 69861
		ISetAssistCharacterPos,
		// Token: 0x040110E6 RID: 69862
		ISetPlayerPos,
		// Token: 0x040110E7 RID: 69863
		IClientSetPlayerPos,
		// Token: 0x040110E8 RID: 69864
		IClientPreEnableSubLevels,
		// Token: 0x040110E9 RID: 69865
		IRogueGotoNextFloor,
		// Token: 0x040110EA RID: 69866
		IRogueSelectRoom,
		// Token: 0x040110EB RID: 69867
		IRogueActivatePortal,
		// Token: 0x040110EC RID: 69868
		IRogueReceiveReward,
		// Token: 0x040110ED RID: 69869
		IChangeSelfEntityState,
		// Token: 0x040110EE RID: 69870
		IInterludeActions,
		// Token: 0x040110EF RID: 69871
		IAddBuffToTriggeredEntity,
		// Token: 0x040110F0 RID: 69872
		IRemoveBuffToTriggeredEntity,
		// Token: 0x040110F1 RID: 69873
		IDetectTrigger,
		// Token: 0x040110F2 RID: 69874
		IItemFoundationMatch,
		// Token: 0x040110F3 RID: 69875
		ISetBattleState,
		// Token: 0x040110F4 RID: 69876
		IExecBattleAction,
		// Token: 0x040110F5 RID: 69877
		IExecClientMonsterNpcInteract,
		// Token: 0x040110F6 RID: 69878
		IExecClientBattleAction,
		// Token: 0x040110F7 RID: 69879
		IWaitBattleCondition,
		// Token: 0x040110F8 RID: 69880
		IEnableHostility,
		// Token: 0x040110F9 RID: 69881
		IUnlockSystemItem,
		// Token: 0x040110FA RID: 69882
		IClientUnlockAchievementSystemItem,
		// Token: 0x040110FB RID: 69883
		IAddPlayBubble,
		// Token: 0x040110FC RID: 69884
		IPlayBubble,
		// Token: 0x040110FD RID: 69885
		IClearPlayBubble,
		// Token: 0x040110FE RID: 69886
		IMoveWithSpline,
		// Token: 0x040110FF RID: 69887
		INewMoveWithSpline,
		// Token: 0x04011100 RID: 69888
		IStopNewMoveWithSpline,
		// Token: 0x04011101 RID: 69889
		ICharacterMoveToPoint,
		// Token: 0x04011102 RID: 69890
		IPlayerMoveToPoint,
		// Token: 0x04011103 RID: 69891
		INpcMoveToPoint,
		// Token: 0x04011104 RID: 69892
		IToggleScanSplineEffect,
		// Token: 0x04011105 RID: 69893
		IOpenTraceSpline,
		// Token: 0x04011106 RID: 69894
		ICloseTraceSpline,
		// Token: 0x04011107 RID: 69895
		ITraceSpline,
		// Token: 0x04011108 RID: 69896
		IEnableAI,
		// Token: 0x04011109 RID: 69897
		IRunActions,
		// Token: 0x0401110A RID: 69898
		ICommonTip,
		// Token: 0x0401110B RID: 69899
		ICommonTip2,
		// Token: 0x0401110C RID: 69900
		IEndCommonTip,
		// Token: 0x0401110D RID: 69901
		IEnableNearbyTracking,
		// Token: 0x0401110E RID: 69902
		ISendAiEvent,
		// Token: 0x0401110F RID: 69903
		IEnableLevelPlay,
		// Token: 0x04011110 RID: 69904
		IServerForceEnableLevelPlay,
		// Token: 0x04011111 RID: 69905
		ITeleportDungeonPos,
		// Token: 0x04011112 RID: 69906
		IFadeInScreen,
		// Token: 0x04011113 RID: 69907
		IFadeOutScreen,
		// Token: 0x04011114 RID: 69908
		IStartFlowTemplate,
		// Token: 0x04011115 RID: 69909
		IEndFlowTemplate,
		// Token: 0x04011116 RID: 69910
		ICloseFlowTemplate,
		// Token: 0x04011117 RID: 69911
		IChangeFlowTemplate,
		// Token: 0x04011118 RID: 69912
		IBeginFlowTemplate,
		// Token: 0x04011119 RID: 69913
		ISetFlowTemplate,
		// Token: 0x0401111A RID: 69914
		IHideTargetRange,
		// Token: 0x0401111B RID: 69915
		IShowTargetRange,
		// Token: 0x0401111C RID: 69916
		IHideSpecificEntities,
		// Token: 0x0401111D RID: 69917
		IShowSpecificEntities,
		// Token: 0x0401111E RID: 69918
		IHideGroup,
		// Token: 0x0401111F RID: 69919
		IShowHidedGroup,
		// Token: 0x04011120 RID: 69920
		ISetSubScreenMode,
		// Token: 0x04011121 RID: 69921
		IToggleDragActorPlay,
		// Token: 0x04011122 RID: 69922
		IDarkTideSetMapMarkState,
		// Token: 0x04011123 RID: 69923
		IManualOccupations,
		// Token: 0x04011124 RID: 69924
		IForceOccupations,
		// Token: 0x04011125 RID: 69925
		IChangeFightTeam,
		// Token: 0x04011126 RID: 69926
		IActiveRange,
		// Token: 0x04011127 RID: 69927
		IAddTrialCharacter,
		// Token: 0x04011128 RID: 69928
		IUpdateTrialCharacter,
		// Token: 0x04011129 RID: 69929
		IRestoreTrialCharacter,
		// Token: 0x0401112A RID: 69930
		IRemoveTrialCharacter,
		// Token: 0x0401112B RID: 69931
		IAddGuestCharacter,
		// Token: 0x0401112C RID: 69932
		IRemoveGuestCharacter,
		// Token: 0x0401112D RID: 69933
		IDestroyQuest,
		// Token: 0x0401112E RID: 69934
		ISetCameraAnim,
		// Token: 0x0401112F RID: 69935
		IChangeTimer,
		// Token: 0x04011130 RID: 69936
		IToggleTimerPauseState,
		// Token: 0x04011131 RID: 69937
		IRotatorEntity,
		// Token: 0x04011132 RID: 69938
		IUnLimitPlayerOperation,
		// Token: 0x04011133 RID: 69939
		ILimitPlayerOperation,
		// Token: 0x04011134 RID: 69940
		IEnableSystem,
		// Token: 0x04011135 RID: 69941
		ILeisureInteract,
		// Token: 0x04011136 RID: 69942
		INpcLeisureInteract,
		// Token: 0x04011137 RID: 69943
		IPostAkEvent,
		// Token: 0x04011138 RID: 69944
		IMoveSceneItem,
		// Token: 0x04011139 RID: 69945
		IStopSceneItemMove,
		// Token: 0x0401113A RID: 69946
		IChangeLiftTarget,
		// Token: 0x0401113B RID: 69947
		IHideByRangeInFlow,
		// Token: 0x0401113C RID: 69948
		IShowAllHidedGroupInFlow,
		// Token: 0x0401113D RID: 69949
		IOpenSimpleGameplay,
		// Token: 0x0401113E RID: 69950
		IToggleRideFlyingCarUiGameplay,
		// Token: 0x0401113F RID: 69951
		IChangePhantom,
		// Token: 0x04011140 RID: 69952
		IRestorePhantom,
		// Token: 0x04011141 RID: 69953
		ITakePlotPhoto,
		// Token: 0x04011142 RID: 69954
		IChangeActorTalker,
		// Token: 0x04011143 RID: 69955
		ISwitchSubLevels,
		// Token: 0x04011144 RID: 69956
		ISwitchSubLevelsDirectly,
		// Token: 0x04011145 RID: 69957
		IPreloadSubLevels,
		// Token: 0x04011146 RID: 69958
		ISwitchPermission,
		// Token: 0x04011147 RID: 69959
		ISwitchDataLayers,
		// Token: 0x04011148 RID: 69960
		IActivateResetPoint,
		// Token: 0x04011149 RID: 69961
		ITeleportToLatestResetPoint,
		// Token: 0x0401114A RID: 69962
		ISetWeather,
		// Token: 0x0401114B RID: 69963
		ISetTimeLockState,
		// Token: 0x0401114C RID: 69964
		ISetWeatherLockState,
		// Token: 0x0401114D RID: 69965
		IClientSetSeasonState,
		// Token: 0x0401114E RID: 69966
		IAxisLockScreenConfig,
		// Token: 0x0401114F RID: 69967
		IAdjustPlayerCamera,
		// Token: 0x04011150 RID: 69968
		IRestorePlayerCameraAdjustment,
		// Token: 0x04011151 RID: 69969
		IAdjustPlayerCameraGravity,
		// Token: 0x04011152 RID: 69970
		IEnterMovieCamera,
		// Token: 0x04011153 RID: 69971
		IExitMovieCamera,
		// Token: 0x04011154 RID: 69972
		IResetPlayerCameraFocus,
		// Token: 0x04011155 RID: 69973
		IUsePhantomSkill,
		// Token: 0x04011156 RID: 69974
		IChangePhantomFormation,
		// Token: 0x04011157 RID: 69975
		IRestorePhantomFormation
	}
}
