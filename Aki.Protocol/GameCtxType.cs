using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001642 RID: 5698
	public enum GameCtxType
	{
		// Token: 0x0400C1F8 RID: 49656
		[OriginalName("BehaviorTree")]
		BehaviorTree,
		// Token: 0x0400C1F9 RID: 49657
		[OriginalName("Entity")]
		Entity,
		// Token: 0x0400C1FA RID: 49658
		[OriginalName("NormalInteract")]
		NormalInteract,
		// Token: 0x0400C1FB RID: 49659
		[OriginalName("DynamicInteract")]
		DynamicInteract,
		// Token: 0x0400C1FC RID: 49660
		[OriginalName("RandomInteract")]
		RandomInteract,
		// Token: 0x0400C1FD RID: 49661
		[OriginalName("EntityStateChangeAction")]
		EntityStateChangeAction,
		// Token: 0x0400C1FE RID: 49662
		[OriginalName("EntityGroupAction")]
		EntityGroupAction,
		// Token: 0x0400C1FF RID: 49663
		[OriginalName("EntityTrigger")]
		EntityTrigger,
		// Token: 0x0400C200 RID: 49664
		[OriginalName("EntityLeaveTrigger")]
		EntityLeaveTrigger,
		// Token: 0x0400C201 RID: 49665
		[OriginalName("EntityDestructible")]
		EntityDestructible,
		// Token: 0x0400C202 RID: 49666
		[OriginalName("EntityTimelineTrack")]
		EntityTimelineTrack,
		// Token: 0x0400C203 RID: 49667
		[OriginalName("LevelPlayOpenAction")]
		LevelPlayOpenAction,
		// Token: 0x0400C204 RID: 49668
		[OriginalName("LevelPlayRewardAction")]
		LevelPlayRewardAction,
		// Token: 0x0400C205 RID: 49669
		[OriginalName("QuestActiveAction")]
		QuestActiveAction,
		// Token: 0x0400C206 RID: 49670
		[OriginalName("QuestAcceptAction")]
		QuestAcceptAction,
		// Token: 0x0400C207 RID: 49671
		[OriginalName("QuestFinishAction")]
		QuestFinishAction,
		// Token: 0x0400C208 RID: 49672
		[OriginalName("ChildQuestNodeEnterAction")]
		ChildQuestNodeEnterAction,
		// Token: 0x0400C209 RID: 49673
		[OriginalName("ChildQuestNodeFinishAction")]
		ChildQuestNodeFinishAction,
		// Token: 0x0400C20A RID: 49674
		[OriginalName("SuccessNodeAction")]
		SuccessNodeAction,
		// Token: 0x0400C20B RID: 49675
		[OriginalName("FailedNodeAction")]
		FailedNodeAction,
		// Token: 0x0400C20C RID: 49676
		[OriginalName("CompositionEnterAction")]
		CompositionEnterAction,
		// Token: 0x0400C20D RID: 49677
		[OriginalName("EntityConditionListeningAction")]
		EntityConditionListeningAction,
		// Token: 0x0400C20E RID: 49678
		[OriginalName("PlayFlowChildQuestNode")]
		PlayFlowChildQuestNode,
		// Token: 0x0400C20F RID: 49679
		[OriginalName("HandInItemChildQuestNode")]
		HandInItemChildQuestNode,
		// Token: 0x0400C210 RID: 49680
		[OriginalName("DoInteractChildQuestNode")]
		DoInteractChildQuestNode,
		// Token: 0x0400C211 RID: 49681
		[OriginalName("ActionGroupNodeAction")]
		ActionGroupNodeAction,
		// Token: 0x0400C212 RID: 49682
		[OriginalName("ExploreSkillPullGiantAction")]
		ExploreSkillPullGiantAction,
		// Token: 0x0400C213 RID: 49683
		[OriginalName("LevelPlay")]
		LevelPlay,
		// Token: 0x0400C214 RID: 49684
		[OriginalName("GmLevelAction")]
		GmLevelAction,
		// Token: 0x0400C215 RID: 49685
		[OriginalName("GmPlayFlow")]
		GmPlayFlow,
		// Token: 0x0400C216 RID: 49686
		[OriginalName("SceneItemLifeCycleComponentCreate")]
		SceneItemLifeCycleComponentCreate,
		// Token: 0x0400C217 RID: 49687
		[OriginalName("SceneItemLifeCycleComponentDetroy")]
		SceneItemLifeCycleComponentDetroy,
		// Token: 0x0400C218 RID: 49688
		[OriginalName("GameCtxGm")]
		GameCtxGm,
		// Token: 0x0400C219 RID: 49689
		[OriginalName("FlowActionCtx")]
		FlowActionCtx,
		// Token: 0x0400C21A RID: 49690
		[OriginalName("DailyQuestTerminateAction")]
		DailyQuestTerminateAction,
		// Token: 0x0400C21B RID: 49691
		[OriginalName("ChildQuestNodeFixAction")]
		ChildQuestNodeFixAction,
		// Token: 0x0400C21C RID: 49692
		[OriginalName("ConditionNodeFixAction")]
		ConditionNodeFixAction,
		// Token: 0x0400C21D RID: 49693
		[OriginalName("EntityFixAction")]
		EntityFixAction,
		// Token: 0x0400C21E RID: 49694
		[OriginalName("ConditionNode")]
		ConditionNode,
		// Token: 0x0400C21F RID: 49695
		[OriginalName("EntityBeamReceiveAction")]
		EntityBeamReceiveAction,
		// Token: 0x0400C220 RID: 49696
		[OriginalName("EntityGroupFailureAction")]
		EntityGroupFailureAction,
		// Token: 0x0400C221 RID: 49697
		[OriginalName("ChildQuestNodeCondition")]
		ChildQuestNodeCondition,
		// Token: 0x0400C222 RID: 49698
		[OriginalName("EntityStateChangeConditionAction")]
		EntityStateChangeConditionAction,
		// Token: 0x0400C223 RID: 49699
		[OriginalName("RequestPlayerGameCurrStateBt")]
		RequestPlayerGameCurrStateBt,
		// Token: 0x0400C224 RID: 49700
		[OriginalName("RequestEntityCurrState")]
		RequestEntityCurrState,
		// Token: 0x0400C225 RID: 49701
		[OriginalName("TriggerConditionListeningAction")]
		TriggerConditionListeningAction,
		// Token: 0x0400C226 RID: 49702
		[OriginalName("FlowStartTeleport")]
		FlowStartTeleport,
		// Token: 0x0400C227 RID: 49703
		[OriginalName("EntityVisibleCondition")]
		EntityVisibleCondition,
		// Token: 0x0400C228 RID: 49704
		[OriginalName("FailedNodeTeleport")]
		FailedNodeTeleport,
		// Token: 0x0400C229 RID: 49705
		[OriginalName("LeaveInstEscActionCtx")]
		LeaveInstEscActionCtx,
		// Token: 0x0400C22A RID: 49706
		[OriginalName("TrampleActiveActionCtx")]
		TrampleActiveActionCtx,
		// Token: 0x0400C22B RID: 49707
		[OriginalName("TrampleDeActiveActionCtx")]
		TrampleDeActiveActionCtx,
		// Token: 0x0400C22C RID: 49708
		[OriginalName("DefaultGameCtx")]
		DefaultGameCtx,
		// Token: 0x0400C22D RID: 49709
		[OriginalName("LevelPlayExploratoryCtx")]
		LevelPlayExploratoryCtx,
		// Token: 0x0400C22E RID: 49710
		[OriginalName("RenjuCompleteActionCtx")]
		RenjuCompleteActionCtx,
		// Token: 0x0400C22F RID: 49711
		[OriginalName("JigsawFoundationMatchedActionCtx")]
		JigsawFoundationMatchedActionCtx,
		// Token: 0x0400C230 RID: 49712
		[OriginalName("CompositionFixAction")]
		CompositionFixAction,
		// Token: 0x0400C231 RID: 49713
		[OriginalName("JigsawFoundationUnMatchedActionCtx")]
		JigsawFoundationUnMatchedActionCtx,
		// Token: 0x0400C232 RID: 49714
		[OriginalName("HookLockPointActionCtx")]
		HookLockPointActionCtx,
		// Token: 0x0400C233 RID: 49715
		[OriginalName("ClientTriggerActionCtx")]
		ClientTriggerActionCtx,
		// Token: 0x0400C234 RID: 49716
		[OriginalName("ExploreSkillCustomAction")]
		ExploreSkillCustomAction,
		// Token: 0x0400C235 RID: 49717
		[OriginalName("LevelSequenceFrameEventAction")]
		LevelSequenceFrameEventAction,
		// Token: 0x0400C236 RID: 49718
		[OriginalName("JigsawFoundationMatchedConditionActionCtx")]
		JigsawFoundationMatchedConditionActionCtx,
		// Token: 0x0400C237 RID: 49719
		[OriginalName("CameraAlertComponentCreate")]
		CameraAlertComponentCreate,
		// Token: 0x0400C238 RID: 49720
		[OriginalName("RenjuExitMatchedAction")]
		RenjuExitMatchedAction,
		// Token: 0x0400C239 RID: 49721
		[OriginalName("RenjuExitUnMatchedAction")]
		RenjuExitUnMatchedAction,
		// Token: 0x0400C23A RID: 49722
		[OriginalName("LevelPlayDestroyAction")]
		LevelPlayDestroyAction,
		// Token: 0x0400C23B RID: 49723
		[OriginalName("EffectAreaConditionListeningAction")]
		EffectAreaConditionListeningAction,
		// Token: 0x0400C23C RID: 49724
		[OriginalName("OccupationInfoAction")]
		OccupationInfoAction,
		// Token: 0x0400C23D RID: 49725
		[OriginalName("EntityHeadInfoCondition")]
		EntityHeadInfoCondition,
		// Token: 0x0400C23E RID: 49726
		[OriginalName("TemplateSpawnerConditionListen")]
		TemplateSpawnerConditionListen,
		// Token: 0x0400C23F RID: 49727
		[OriginalName("TemplateSpawnerAction")]
		TemplateSpawnerAction,
		// Token: 0x0400C240 RID: 49728
		[OriginalName("BatchRefresherConditionListen")]
		BatchRefresherConditionListen,
		// Token: 0x0400C241 RID: 49729
		[OriginalName("QuestDestroyAction")]
		QuestDestroyAction,
		// Token: 0x0400C242 RID: 49730
		[OriginalName("RequestGameCurrState")]
		RequestGameCurrState,
		// Token: 0x0400C243 RID: 49731
		[OriginalName("TemplateSpawnerStateConditionListen")]
		TemplateSpawnerStateConditionListen,
		// Token: 0x0400C244 RID: 49732
		[OriginalName("CompositionConditionEnterAction")]
		CompositionConditionEnterAction,
		// Token: 0x0400C245 RID: 49733
		[OriginalName("TrapDefenseSystem")]
		TrapDefenseSystem,
		// Token: 0x0400C246 RID: 49734
		[OriginalName("SceneItemSequenceFrameEventActionCtx")]
		SceneItemSequenceFrameEventActionCtx,
		// Token: 0x0400C247 RID: 49735
		[OriginalName("TargetGearHitPart")]
		TargetGearHitPart,
		// Token: 0x0400C248 RID: 49736
		[OriginalName("GlobalFixCtx")]
		GlobalFixCtx,
		// Token: 0x0400C249 RID: 49737
		[OriginalName("ChildQuestNodeStuckCheckAction")]
		ChildQuestNodeStuckCheckAction,
		// Token: 0x0400C24A RID: 49738
		[OriginalName("GameCurrFetchVar")]
		GameCurrFetchVar,
		// Token: 0x0400C24B RID: 49739
		[OriginalName("EntityAfterConditionActionCtx")]
		EntityAfterConditionActionCtx,
		// Token: 0x0400C24C RID: 49740
		[OriginalName("ChildQuestNodePreCondition")]
		ChildQuestNodePreCondition,
		// Token: 0x0400C24D RID: 49741
		[OriginalName("BtNodePreCondition")]
		BtNodePreCondition,
		// Token: 0x0400C24E RID: 49742
		[OriginalName("DynamicSpawnMonsterRefresherConditionListen")]
		DynamicSpawnMonsterRefresherConditionListen,
		// Token: 0x0400C24F RID: 49743
		[OriginalName("BeamCastHitPlayerActionCtx")]
		BeamCastHitPlayerActionCtx,
		// Token: 0x0400C250 RID: 49744
		[OriginalName("MotorSliderCtx")]
		MotorSliderCtx,
		// Token: 0x0400C251 RID: 49745
		[OriginalName("RollBlockGamePlayActionCtx")]
		RollBlockGamePlayActionCtx,
		// Token: 0x0400C252 RID: 49746
		[OriginalName("MotorParkourSystem")]
		MotorParkourSystem,
		// Token: 0x0400C253 RID: 49747
		[OriginalName("TransferCtx")]
		TransferCtx,
		// Token: 0x0400C254 RID: 49748
		[OriginalName("SystemModuleDataSyncComponent")]
		SystemModuleDataSyncComponent,
		// Token: 0x0400C255 RID: 49749
		[OriginalName("DynamicEntityRewardCtx")]
		DynamicEntityRewardCtx,
		// Token: 0x0400C256 RID: 49750
		[OriginalName("ExploreSkillAction")]
		ExploreSkillAction,
		// Token: 0x0400C257 RID: 49751
		[OriginalName("MotorFightActivity")]
		MotorFightActivity,
		// Token: 0x0400C258 RID: 49752
		[OriginalName("PasserByNpcSpawnerConditionListenCtx")]
		PasserByNpcSpawnerConditionListenCtx,
		// Token: 0x0400C259 RID: 49753
		[OriginalName("EffectAreaListeningAction")]
		EffectAreaListeningAction,
		// Token: 0x0400C25A RID: 49754
		[OriginalName("SurvivorsSystem")]
		SurvivorsSystem,
		// Token: 0x0400C25B RID: 49755
		[OriginalName("TimeScheduleConditionCtx")]
		TimeScheduleConditionCtx,
		// Token: 0x0400C25C RID: 49756
		[OriginalName("EntityBeamReceiveConditionCtx")]
		EntityBeamReceiveConditionCtx,
		// Token: 0x0400C25D RID: 49757
		[OriginalName("FlowerPollutionActionCtx")]
		FlowerPollutionActionCtx,
		// Token: 0x0400C25E RID: 49758
		[OriginalName("KurotatoSystem")]
		KurotatoSystem,
		// Token: 0x0400C25F RID: 49759
		[OriginalName("EntityQuickHackSkill")]
		EntityQuickHackSkill,
		// Token: 0x0400C260 RID: 49760
		[OriginalName("RecallQuestActiveAction")]
		RecallQuestActiveAction,
		// Token: 0x0400C261 RID: 49761
		[OriginalName("RecallQuestAcceptAction")]
		RecallQuestAcceptAction,
		// Token: 0x0400C262 RID: 49762
		[OriginalName("RecallQuestFinishAction")]
		RecallQuestFinishAction,
		// Token: 0x0400C263 RID: 49763
		[OriginalName("RecallQuestDestroyAction")]
		RecallQuestDestroyAction,
		// Token: 0x0400C264 RID: 49764
		[OriginalName("EdDebugEnterAction")]
		EdDebugEnterAction = 3401,
		// Token: 0x0400C265 RID: 49765
		[OriginalName("SetClientGlobalVarAction")]
		SetClientGlobalVarAction,
		// Token: 0x0400C266 RID: 49766
		[OriginalName("CasketTrigger")]
		CasketTrigger = 3501,
		// Token: 0x0400C267 RID: 49767
		[OriginalName("FoundationCoreOperate")]
		FoundationCoreOperate,
		// Token: 0x0400C268 RID: 49768
		[OriginalName("TargetGearActionByHitType")]
		TargetGearActionByHitType = 3701,
		// Token: 0x0400C269 RID: 49769
		[OriginalName("LoopTeleportVolume")]
		LoopTeleportVolume,
		// Token: 0x0400C26A RID: 49770
		[OriginalName("LongPressInteract")]
		LongPressInteract,
		// Token: 0x0400C26B RID: 49771
		[OriginalName("LevelPlayActiveConditionCtx")]
		LevelPlayActiveConditionCtx = 3801
	}
}
