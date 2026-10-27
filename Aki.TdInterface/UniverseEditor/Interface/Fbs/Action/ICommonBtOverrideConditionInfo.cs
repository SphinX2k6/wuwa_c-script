using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200646B RID: 25707
	public struct ICommonBtOverrideConditionInfo : IFlatbufferObject
	{
		// Token: 0x1700BF4E RID: 48974
		// (get) Token: 0x0602C7D6 RID: 182230 RVA: 0x00619DE8 File Offset: 0x00617FE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C7D7 RID: 182231 RVA: 0x00619DF5 File Offset: 0x00617FF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C7D8 RID: 182232 RVA: 0x00619DFC File Offset: 0x00617FFC
		public static ICommonBtOverrideConditionInfo GetRootAsICommonBtOverrideConditionInfo(ByteBuffer _bb)
		{
			return ICommonBtOverrideConditionInfo.GetRootAsICommonBtOverrideConditionInfo(_bb, default(ICommonBtOverrideConditionInfo));
		}

		// Token: 0x0602C7D9 RID: 182233 RVA: 0x00619E18 File Offset: 0x00618018
		public static ICommonBtOverrideConditionInfo GetRootAsICommonBtOverrideConditionInfo(ByteBuffer _bb, ICommonBtOverrideConditionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C7DA RID: 182234 RVA: 0x00619E35 File Offset: 0x00618035
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C7DB RID: 182235 RVA: 0x00619E44 File Offset: 0x00618044
		public ICommonBtOverrideConditionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF4F RID: 48975
		// (get) Token: 0x0602C7DC RID: 182236 RVA: 0x00619E54 File Offset: 0x00618054
		public ECommonBtPlaceholderTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonBtPlaceholderTargetType.Action;
				}
				return (ECommonBtPlaceholderTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF50 RID: 48976
		// (get) Token: 0x0602C7DD RID: 182237 RVA: 0x00619E90 File Offset: 0x00618090
		public ICondition2_Union ConditionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ICondition2_Union.NONE;
				}
				return (ICondition2_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C7DE RID: 182238 RVA: 0x00619ECC File Offset: 0x006180CC
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C7DF RID: 182239 RVA: 0x00619F10 File Offset: 0x00618110
		public ICondition2 ConditionAsICondition2()
		{
			return this.Condition<ICondition2>().Value;
		}

		// Token: 0x0602C7E0 RID: 182240 RVA: 0x00619F2C File Offset: 0x0061812C
		public ICompareVarCondition ConditionAsICompareVarCondition()
		{
			return this.Condition<ICompareVarCondition>().Value;
		}

		// Token: 0x0602C7E1 RID: 182241 RVA: 0x00619F48 File Offset: 0x00618148
		public IQuestStateEqualCondition ConditionAsIQuestStateEqualCondition()
		{
			return this.Condition<IQuestStateEqualCondition>().Value;
		}

		// Token: 0x0602C7E2 RID: 182242 RVA: 0x00619F64 File Offset: 0x00618164
		public ICompareExploreLevelCondition ConditionAsICompareExploreLevelCondition()
		{
			return this.Condition<ICompareExploreLevelCondition>().Value;
		}

		// Token: 0x0602C7E3 RID: 182243 RVA: 0x00619F80 File Offset: 0x00618180
		public ICompareCalabashLevelCondition ConditionAsICompareCalabashLevelCondition()
		{
			return this.Condition<ICompareCalabashLevelCondition>().Value;
		}

		// Token: 0x0602C7E4 RID: 182244 RVA: 0x00619F9C File Offset: 0x0061819C
		public ICompareLiftCondition ConditionAsICompareLiftCondition()
		{
			return this.Condition<ICompareLiftCondition>().Value;
		}

		// Token: 0x0602C7E5 RID: 182245 RVA: 0x00619FB8 File Offset: 0x006181B8
		public ICompareEntityStateCondition ConditionAsICompareEntityStateCondition()
		{
			return this.Condition<ICompareEntityStateCondition>().Value;
		}

		// Token: 0x0602C7E6 RID: 182246 RVA: 0x00619FD4 File Offset: 0x006181D4
		public ICompareNpcPerformStateCondition ConditionAsICompareNpcPerformStateCondition()
		{
			return this.Condition<ICompareNpcPerformStateCondition>().Value;
		}

		// Token: 0x0602C7E7 RID: 182247 RVA: 0x00619FF0 File Offset: 0x006181F0
		public ICheckTreasureBeenClaimedCondition ConditionAsICheckTreasureBeenClaimedCondition()
		{
			return this.Condition<ICheckTreasureBeenClaimedCondition>().Value;
		}

		// Token: 0x0602C7E8 RID: 182248 RVA: 0x0061A00C File Offset: 0x0061820C
		public ICompareEntityGroupStateCondition ConditionAsICompareEntityGroupStateCondition()
		{
			return this.Condition<ICompareEntityGroupStateCondition>().Value;
		}

		// Token: 0x0602C7E9 RID: 182249 RVA: 0x0061A028 File Offset: 0x00618228
		public ICompareEntitySelfStateCondition ConditionAsICompareEntitySelfStateCondition()
		{
			return this.Condition<ICompareEntitySelfStateCondition>().Value;
		}

		// Token: 0x0602C7EA RID: 182250 RVA: 0x0061A044 File Offset: 0x00618244
		public ICompareLevelPlayRewardStateCondition ConditionAsICompareLevelPlayRewardStateCondition()
		{
			return this.Condition<ICompareLevelPlayRewardStateCondition>().Value;
		}

		// Token: 0x0602C7EB RID: 182251 RVA: 0x0061A060 File Offset: 0x00618260
		public IHourToHourCondition ConditionAsIHourToHourCondition()
		{
			return this.Condition<IHourToHourCondition>().Value;
		}

		// Token: 0x0602C7EC RID: 182252 RVA: 0x0061A07C File Offset: 0x0061827C
		public IRangeSphere ConditionAsIRangeSphere()
		{
			return this.Condition<IRangeSphere>().Value;
		}

		// Token: 0x0602C7ED RID: 182253 RVA: 0x0061A098 File Offset: 0x00618298
		public ICheckItems ConditionAsICheckItems()
		{
			return this.Condition<ICheckItems>().Value;
		}

		// Token: 0x0602C7EE RID: 182254 RVA: 0x0061A0B4 File Offset: 0x006182B4
		public IHasBuff ConditionAsIHasBuff()
		{
			return this.Condition<IHasBuff>().Value;
		}

		// Token: 0x0602C7EF RID: 182255 RVA: 0x0061A0D0 File Offset: 0x006182D0
		public ICheckSystemFunction ConditionAsICheckSystemFunction()
		{
			return this.Condition<ICheckSystemFunction>().Value;
		}

		// Token: 0x0602C7F0 RID: 182256 RVA: 0x0061A0EC File Offset: 0x006182EC
		public ICheckAiState ConditionAsICheckAiState()
		{
			return this.Condition<ICheckAiState>().Value;
		}

		// Token: 0x0602C7F1 RID: 182257 RVA: 0x0061A108 File Offset: 0x00618308
		public ICompareDungeonId ConditionAsICompareDungeonId()
		{
			return this.Condition<ICompareDungeonId>().Value;
		}

		// Token: 0x0602C7F2 RID: 182258 RVA: 0x0061A124 File Offset: 0x00618324
		public ICompareTimePeriod ConditionAsICompareTimePeriod()
		{
			return this.Condition<ICompareTimePeriod>().Value;
		}

		// Token: 0x0602C7F3 RID: 182259 RVA: 0x0061A140 File Offset: 0x00618340
		public ICompareWeather ConditionAsICompareWeather()
		{
			return this.Condition<ICompareWeather>().Value;
		}

		// Token: 0x0602C7F4 RID: 182260 RVA: 0x0061A15C File Offset: 0x0061835C
		public ICheckLevelPlayState ConditionAsICheckLevelPlayState()
		{
			return this.Condition<ICheckLevelPlayState>().Value;
		}

		// Token: 0x0602C7F5 RID: 182261 RVA: 0x0061A178 File Offset: 0x00618378
		public ICheckLevelPlayCompleteNumber ConditionAsICheckLevelPlayCompleteNumber()
		{
			return this.Condition<ICheckLevelPlayCompleteNumber>().Value;
		}

		// Token: 0x0602C7F6 RID: 182262 RVA: 0x0061A194 File Offset: 0x00618394
		public ICheckLevelPlayChildQuestFinished ConditionAsICheckLevelPlayChildQuestFinished()
		{
			return this.Condition<ICheckLevelPlayChildQuestFinished>().Value;
		}

		// Token: 0x0602C7F7 RID: 182263 RVA: 0x0061A1B0 File Offset: 0x006183B0
		public ICheckCurrentRole ConditionAsICheckCurrentRole()
		{
			return this.Condition<ICheckCurrentRole>().Value;
		}

		// Token: 0x0602C7F8 RID: 182264 RVA: 0x0061A1CC File Offset: 0x006183CC
		public ICheckPlayerGender ConditionAsICheckPlayerGender()
		{
			return this.Condition<ICheckPlayerGender>().Value;
		}

		// Token: 0x0602C7F9 RID: 182265 RVA: 0x0061A1E8 File Offset: 0x006183E8
		public ICheckInCombat ConditionAsICheckInCombat()
		{
			return this.Condition<ICheckInCombat>().Value;
		}

		// Token: 0x0602C7FA RID: 182266 RVA: 0x0061A204 File Offset: 0x00618404
		public ICheckHasFollowShooter ConditionAsICheckHasFollowShooter()
		{
			return this.Condition<ICheckHasFollowShooter>().Value;
		}

		// Token: 0x0602C7FB RID: 182267 RVA: 0x0061A220 File Offset: 0x00618420
		public ICheckFollowShooterActive ConditionAsICheckFollowShooterActive()
		{
			return this.Condition<ICheckFollowShooterActive>().Value;
		}

		// Token: 0x0602C7FC RID: 182268 RVA: 0x0061A23C File Offset: 0x0061843C
		public ICheckChildQuestFinished ConditionAsICheckChildQuestFinished()
		{
			return this.Condition<ICheckChildQuestFinished>().Value;
		}

		// Token: 0x0602C7FD RID: 182269 RVA: 0x0061A258 File Offset: 0x00618458
		public ICheckSyncLevelPlayCompleteNumber ConditionAsICheckSyncLevelPlayCompleteNumber()
		{
			return this.Condition<ICheckSyncLevelPlayCompleteNumber>().Value;
		}

		// Token: 0x0602C7FE RID: 182270 RVA: 0x0061A274 File Offset: 0x00618474
		public ICheckCrossSceneSyncKillMonsterFinished ConditionAsICheckCrossSceneSyncKillMonsterFinished()
		{
			return this.Condition<ICheckCrossSceneSyncKillMonsterFinished>().Value;
		}

		// Token: 0x0602C7FF RID: 182271 RVA: 0x0061A290 File Offset: 0x00618490
		public ICheckNodeStatus ConditionAsICheckNodeStatus()
		{
			return this.Condition<ICheckNodeStatus>().Value;
		}

		// Token: 0x0602C800 RID: 182272 RVA: 0x0061A2AC File Offset: 0x006184AC
		public ICheckChildQuestStatus ConditionAsICheckChildQuestStatus()
		{
			return this.Condition<ICheckChildQuestStatus>().Value;
		}

		// Token: 0x0602C801 RID: 182273 RVA: 0x0061A2C8 File Offset: 0x006184C8
		public ICheckEntitiesExist ConditionAsICheckEntitiesExist()
		{
			return this.Condition<ICheckEntitiesExist>().Value;
		}

		// Token: 0x0602C802 RID: 182274 RVA: 0x0061A2E4 File Offset: 0x006184E4
		public ICheckPlayerPosition ConditionAsICheckPlayerPosition()
		{
			return this.Condition<ICheckPlayerPosition>().Value;
		}

		// Token: 0x0602C803 RID: 182275 RVA: 0x0061A300 File Offset: 0x00618500
		public ICheckEntityPosition ConditionAsICheckEntityPosition()
		{
			return this.Condition<ICheckEntityPosition>().Value;
		}

		// Token: 0x0602C804 RID: 182276 RVA: 0x0061A31C File Offset: 0x0061851C
		public ICheckDungeonFinish ConditionAsICheckDungeonFinish()
		{
			return this.Condition<ICheckDungeonFinish>().Value;
		}

		// Token: 0x0602C805 RID: 182277 RVA: 0x0061A338 File Offset: 0x00618538
		public ICheckEntityIsVisibility ConditionAsICheckEntityIsVisibility()
		{
			return this.Condition<ICheckEntityIsVisibility>().Value;
		}

		// Token: 0x0602C806 RID: 182278 RVA: 0x0061A354 File Offset: 0x00618554
		public IComparePlayerMotionState ConditionAsIComparePlayerMotionState()
		{
			return this.Condition<IComparePlayerMotionState>().Value;
		}

		// Token: 0x0602C807 RID: 182279 RVA: 0x0061A370 File Offset: 0x00618570
		public IComparePlayerMotionState2 ConditionAsIComparePlayerMotionState2()
		{
			return this.Condition<IComparePlayerMotionState2>().Value;
		}

		// Token: 0x0602C808 RID: 182280 RVA: 0x0061A38C File Offset: 0x0061858C
		public ICheckDataLayerCondition ConditionAsICheckDataLayerCondition()
		{
			return this.Condition<ICheckDataLayerCondition>().Value;
		}

		// Token: 0x0602C809 RID: 182281 RVA: 0x0061A3A8 File Offset: 0x006185A8
		public ICheckHookLockPointCondition ConditionAsICheckHookLockPointCondition()
		{
			return this.Condition<ICheckHookLockPointCondition>().Value;
		}

		// Token: 0x0602C80A RID: 182282 RVA: 0x0061A3C4 File Offset: 0x006185C4
		public ICheckPlayerSkillReadyCondition ConditionAsICheckPlayerSkillReadyCondition()
		{
			return this.Condition<ICheckPlayerSkillReadyCondition>().Value;
		}

		// Token: 0x0602C80B RID: 182283 RVA: 0x0061A3E0 File Offset: 0x006185E0
		public ICheckPlayerUseSkillCondition ConditionAsICheckPlayerUseSkillCondition()
		{
			return this.Condition<ICheckPlayerUseSkillCondition>().Value;
		}

		// Token: 0x0602C80C RID: 182284 RVA: 0x0061A3FC File Offset: 0x006185FC
		public ICheckPlayerStateRestrictionCondition ConditionAsICheckPlayerStateRestrictionCondition()
		{
			return this.Condition<ICheckPlayerStateRestrictionCondition>().Value;
		}

		// Token: 0x0602C80D RID: 182285 RVA: 0x0061A418 File Offset: 0x00618618
		public ICheckLordGymFinishCondition ConditionAsICheckLordGymFinishCondition()
		{
			return this.Condition<ICheckLordGymFinishCondition>().Value;
		}

		// Token: 0x0602C80E RID: 182286 RVA: 0x0061A434 File Offset: 0x00618634
		public ICheckCalabashDevelopRewardCondition ConditionAsICheckCalabashDevelopRewardCondition()
		{
			return this.Condition<ICheckCalabashDevelopRewardCondition>().Value;
		}

		// Token: 0x0602C80F RID: 182287 RVA: 0x0061A450 File Offset: 0x00618650
		public ICompareFishingPrestigeLevelCondition ConditionAsICompareFishingPrestigeLevelCondition()
		{
			return this.Condition<ICompareFishingPrestigeLevelCondition>().Value;
		}

		// Token: 0x0602C810 RID: 182288 RVA: 0x0061A46C File Offset: 0x0061866C
		public ICheckCertainFishingItemCount ConditionAsICheckCertainFishingItemCount()
		{
			return this.Condition<ICheckCertainFishingItemCount>().Value;
		}

		// Token: 0x0602C811 RID: 182289 RVA: 0x0061A488 File Offset: 0x00618688
		public ICompleteCertainFishingEntrust ConditionAsICompleteCertainFishingEntrust()
		{
			return this.Condition<ICompleteCertainFishingEntrust>().Value;
		}

		// Token: 0x0602C812 RID: 182290 RVA: 0x0061A4A4 File Offset: 0x006186A4
		public ICompareFishingBoatState ConditionAsICompareFishingBoatState()
		{
			return this.Condition<ICompareFishingBoatState>().Value;
		}

		// Token: 0x0602C813 RID: 182291 RVA: 0x0061A4C0 File Offset: 0x006186C0
		public ICheckJigsawInfoCondition ConditionAsICheckJigsawInfoCondition()
		{
			return this.Condition<ICheckJigsawInfoCondition>().Value;
		}

		// Token: 0x0602C814 RID: 182292 RVA: 0x0061A4DC File Offset: 0x006186DC
		public ICheckGameplayTagCondition ConditionAsICheckGameplayTagCondition()
		{
			return this.Condition<ICheckGameplayTagCondition>().Value;
		}

		// Token: 0x0602C815 RID: 182293 RVA: 0x0061A4F8 File Offset: 0x006186F8
		public ICheckFormationRoleInfoCondition ConditionAsICheckFormationRoleInfoCondition()
		{
			return this.Condition<ICheckFormationRoleInfoCondition>().Value;
		}

		// Token: 0x0602C816 RID: 182294 RVA: 0x0061A514 File Offset: 0x00618714
		public ICheckTargetAttributeCondition ConditionAsICheckTargetAttributeCondition()
		{
			return this.Condition<ICheckTargetAttributeCondition>().Value;
		}

		// Token: 0x0602C817 RID: 182295 RVA: 0x0061A530 File Offset: 0x00618730
		public ICheckRogueAbilitySelectCondition ConditionAsICheckRogueAbilitySelectCondition()
		{
			return this.Condition<ICheckRogueAbilitySelectCondition>().Value;
		}

		// Token: 0x0602C818 RID: 182296 RVA: 0x0061A54C File Offset: 0x0061874C
		public ICheckDirectionCondition ConditionAsICheckDirectionCondition()
		{
			return this.Condition<ICheckDirectionCondition>().Value;
		}

		// Token: 0x0602C819 RID: 182297 RVA: 0x0061A568 File Offset: 0x00618768
		public ICheckSceneItemDirectionCondition ConditionAsICheckSceneItemDirectionCondition()
		{
			return this.Condition<ICheckSceneItemDirectionCondition>().Value;
		}

		// Token: 0x0602C81A RID: 182298 RVA: 0x0061A584 File Offset: 0x00618784
		public ICheckPlayerFaceToCondition ConditionAsICheckPlayerFaceToCondition()
		{
			return this.Condition<ICheckPlayerFaceToCondition>().Value;
		}

		// Token: 0x0602C81B RID: 182299 RVA: 0x0061A5A0 File Offset: 0x006187A0
		public ICheckPlayerCanJoinActivityCondition ConditionAsICheckPlayerCanJoinActivityCondition()
		{
			return this.Condition<ICheckPlayerCanJoinActivityCondition>().Value;
		}

		// Token: 0x0602C81C RID: 182300 RVA: 0x0061A5BC File Offset: 0x006187BC
		public ICheckSystemStateCondition ConditionAsICheckSystemStateCondition()
		{
			return this.Condition<ICheckSystemStateCondition>().Value;
		}

		// Token: 0x0602C81D RID: 182301 RVA: 0x0061A5D8 File Offset: 0x006187D8
		public ICheckInRangeCondition ConditionAsICheckInRangeCondition()
		{
			return this.Condition<ICheckInRangeCondition>().Value;
		}

		// Token: 0x0602C81E RID: 182302 RVA: 0x0061A5F4 File Offset: 0x006187F4
		public ICheckInRangeProperlyCondition ConditionAsICheckInRangeProperlyCondition()
		{
			return this.Condition<ICheckInRangeProperlyCondition>().Value;
		}

		// Token: 0x0602C81F RID: 182303 RVA: 0x0061A610 File Offset: 0x00618810
		public ICheckEntityLockedCondition ConditionAsICheckEntityLockedCondition()
		{
			return this.Condition<ICheckEntityLockedCondition>().Value;
		}

		// Token: 0x0602C820 RID: 182304 RVA: 0x0061A62C File Offset: 0x0061882C
		public ICompareTeammateDieCondition ConditionAsICompareTeammateDieCondition()
		{
			return this.Condition<ICompareTeammateDieCondition>().Value;
		}

		// Token: 0x0602C821 RID: 182305 RVA: 0x0061A648 File Offset: 0x00618848
		public IListenEntitySelfEventCondition ConditionAsIListenEntitySelfEventCondition()
		{
			return this.Condition<IListenEntitySelfEventCondition>().Value;
		}

		// Token: 0x0602C822 RID: 182306 RVA: 0x0061A664 File Offset: 0x00618864
		public ICheckEntityDistanceCondition ConditionAsICheckEntityDistanceCondition()
		{
			return this.Condition<ICheckEntityDistanceCondition>().Value;
		}

		// Token: 0x0602C823 RID: 182307 RVA: 0x0061A680 File Offset: 0x00618880
		public ICheckEntityHasSceneItemAttributeTag ConditionAsICheckEntityHasSceneItemAttributeTag()
		{
			return this.Condition<ICheckEntityHasSceneItemAttributeTag>().Value;
		}

		// Token: 0x0602C824 RID: 182308 RVA: 0x0061A69C File Offset: 0x0061889C
		public IListenEntityThroughPortal ConditionAsIListenEntityThroughPortal()
		{
			return this.Condition<IListenEntityThroughPortal>().Value;
		}

		// Token: 0x0602C825 RID: 182309 RVA: 0x0061A6B8 File Offset: 0x006188B8
		public ICheckTeleControlState ConditionAsICheckTeleControlState()
		{
			return this.Condition<ICheckTeleControlState>().Value;
		}

		// Token: 0x0602C826 RID: 182310 RVA: 0x0061A6D4 File Offset: 0x006188D4
		public ICustomJsonCondition ConditionAsICustomJsonCondition()
		{
			return this.Condition<ICustomJsonCondition>().Value;
		}

		// Token: 0x0602C827 RID: 182311 RVA: 0x0061A6F0 File Offset: 0x006188F0
		public ICheckChessWinner ConditionAsICheckChessWinner()
		{
			return this.Condition<ICheckChessWinner>().Value;
		}

		// Token: 0x0602C828 RID: 182312 RVA: 0x0061A70C File Offset: 0x0061890C
		public ICheckVehicleCondition ConditionAsICheckVehicleCondition()
		{
			return this.Condition<ICheckVehicleCondition>().Value;
		}

		// Token: 0x0602C829 RID: 182313 RVA: 0x0061A728 File Offset: 0x00618928
		public ICompareAlertValue ConditionAsICompareAlertValue()
		{
			return this.Condition<ICompareAlertValue>().Value;
		}

		// Token: 0x0602C82A RID: 182314 RVA: 0x0061A744 File Offset: 0x00618944
		public ICheckEntityGravityDirection ConditionAsICheckEntityGravityDirection()
		{
			return this.Condition<ICheckEntityGravityDirection>().Value;
		}

		// Token: 0x0602C82B RID: 182315 RVA: 0x0061A760 File Offset: 0x00618960
		public ICheckCollectAnimalParts ConditionAsICheckCollectAnimalParts()
		{
			return this.Condition<ICheckCollectAnimalParts>().Value;
		}

		// Token: 0x0602C82C RID: 182316 RVA: 0x0061A77C File Offset: 0x0061897C
		public ICheckFinishLoading ConditionAsICheckFinishLoading()
		{
			return this.Condition<ICheckFinishLoading>().Value;
		}

		// Token: 0x0602C82D RID: 182317 RVA: 0x0061A798 File Offset: 0x00618998
		public ICheckFishingPointHasFish ConditionAsICheckFishingPointHasFish()
		{
			return this.Condition<ICheckFishingPointHasFish>().Value;
		}

		// Token: 0x0602C82E RID: 182318 RVA: 0x0061A7B4 File Offset: 0x006189B4
		public ICheckFishingCageFillingRatio ConditionAsICheckFishingCageFillingRatio()
		{
			return this.Condition<ICheckFishingCageFillingRatio>().Value;
		}

		// Token: 0x0602C82F RID: 182319 RVA: 0x0061A7D0 File Offset: 0x006189D0
		public ICompareFishingTechLevel ConditionAsICompareFishingTechLevel()
		{
			return this.Condition<ICompareFishingTechLevel>().Value;
		}

		// Token: 0x0602C830 RID: 182320 RVA: 0x0061A7EC File Offset: 0x006189EC
		public ICheckGuestCharacter ConditionAsICheckGuestCharacter()
		{
			return this.Condition<ICheckGuestCharacter>().Value;
		}

		// Token: 0x0602C831 RID: 182321 RVA: 0x0061A808 File Offset: 0x00618A08
		public ICheckSubLevelState ConditionAsICheckSubLevelState()
		{
			return this.Condition<ICheckSubLevelState>().Value;
		}

		// Token: 0x0602C832 RID: 182322 RVA: 0x0061A824 File Offset: 0x00618A24
		public IComparePlayerNumInDungeon ConditionAsIComparePlayerNumInDungeon()
		{
			return this.Condition<IComparePlayerNumInDungeon>().Value;
		}

		// Token: 0x0602C833 RID: 182323 RVA: 0x0061A840 File Offset: 0x00618A40
		public ICheckAlertAreaEnabled ConditionAsICheckAlertAreaEnabled()
		{
			return this.Condition<ICheckAlertAreaEnabled>().Value;
		}

		// Token: 0x0602C834 RID: 182324 RVA: 0x0061A85C File Offset: 0x00618A5C
		public ICheckClientEvent ConditionAsICheckClientEvent()
		{
			return this.Condition<ICheckClientEvent>().Value;
		}

		// Token: 0x0602C835 RID: 182325 RVA: 0x0061A878 File Offset: 0x00618A78
		public ICheckIsGramophonePlayingMusic ConditionAsICheckIsGramophonePlayingMusic()
		{
			return this.Condition<ICheckIsGramophonePlayingMusic>().Value;
		}

		// Token: 0x0602C836 RID: 182326 RVA: 0x0061A894 File Offset: 0x00618A94
		public ICheckEntityReward ConditionAsICheckEntityReward()
		{
			return this.Condition<ICheckEntityReward>().Value;
		}

		// Token: 0x0602C837 RID: 182327 RVA: 0x0061A8B0 File Offset: 0x00618AB0
		public ICheckDungeonHasSaveConfig ConditionAsICheckDungeonHasSaveConfig()
		{
			return this.Condition<ICheckDungeonHasSaveConfig>().Value;
		}

		// Token: 0x0602C838 RID: 182328 RVA: 0x0061A8CC File Offset: 0x00618ACC
		public ICheckSystemEventBvb ConditionAsICheckSystemEventBvb()
		{
			return this.Condition<ICheckSystemEventBvb>().Value;
		}

		// Token: 0x0602C839 RID: 182329 RVA: 0x0061A8E8 File Offset: 0x00618AE8
		public ICheckDangoCultivationProgress ConditionAsICheckDangoCultivationProgress()
		{
			return this.Condition<ICheckDangoCultivationProgress>().Value;
		}

		// Token: 0x0602C83A RID: 182330 RVA: 0x0061A904 File Offset: 0x00618B04
		public ICheckPlayerMoraleLevelRange ConditionAsICheckPlayerMoraleLevelRange()
		{
			return this.Condition<ICheckPlayerMoraleLevelRange>().Value;
		}

		// Token: 0x0602C83B RID: 182331 RVA: 0x0061A920 File Offset: 0x00618B20
		public ICheckIsGlobalTimeScaleEnabled ConditionAsICheckIsGlobalTimeScaleEnabled()
		{
			return this.Condition<ICheckIsGlobalTimeScaleEnabled>().Value;
		}

		// Token: 0x0602C83C RID: 182332 RVA: 0x0061A93C File Offset: 0x00618B3C
		public ISaveConfigEnterMethod ConditionAsISaveConfigEnterMethod()
		{
			return this.Condition<ISaveConfigEnterMethod>().Value;
		}

		// Token: 0x0602C83D RID: 182333 RVA: 0x0061A958 File Offset: 0x00618B58
		public ICheckIsEntityTimeScaleEnabled ConditionAsICheckIsEntityTimeScaleEnabled()
		{
			return this.Condition<ICheckIsEntityTimeScaleEnabled>().Value;
		}

		// Token: 0x0602C83E RID: 182334 RVA: 0x0061A974 File Offset: 0x00618B74
		public ICheckIsCharacterHoldingHands ConditionAsICheckIsCharacterHoldingHands()
		{
			return this.Condition<ICheckIsCharacterHoldingHands>().Value;
		}

		// Token: 0x0602C83F RID: 182335 RVA: 0x0061A990 File Offset: 0x00618B90
		public ICheckIsTrackingCurrentQuest ConditionAsICheckIsTrackingCurrentQuest()
		{
			return this.Condition<ICheckIsTrackingCurrentQuest>().Value;
		}

		// Token: 0x0602C840 RID: 182336 RVA: 0x0061A9AC File Offset: 0x00618BAC
		public ICheckIsTrackingQuest ConditionAsICheckIsTrackingQuest()
		{
			return this.Condition<ICheckIsTrackingQuest>().Value;
		}

		// Token: 0x0602C841 RID: 182337 RVA: 0x0061A9C8 File Offset: 0x00618BC8
		public ICheckMusicEvent ConditionAsICheckMusicEvent()
		{
			return this.Condition<ICheckMusicEvent>().Value;
		}

		// Token: 0x0602C842 RID: 182338 RVA: 0x0061A9E4 File Offset: 0x00618BE4
		public ICompareGameDifficulty ConditionAsICompareGameDifficulty()
		{
			return this.Condition<ICompareGameDifficulty>().Value;
		}

		// Token: 0x0602C843 RID: 182339 RVA: 0x0061AA00 File Offset: 0x00618C00
		public ICheckPhotographCameraParam ConditionAsICheckPhotographCameraParam()
		{
			return this.Condition<ICheckPhotographCameraParam>().Value;
		}

		// Token: 0x0602C844 RID: 182340 RVA: 0x0061AA1C File Offset: 0x00618C1C
		public ICheckEntityHasBuff ConditionAsICheckEntityHasBuff()
		{
			return this.Condition<ICheckEntityHasBuff>().Value;
		}

		// Token: 0x0602C845 RID: 182341 RVA: 0x0061AA38 File Offset: 0x00618C38
		public ICheckEntityBuffStack ConditionAsICheckEntityBuffStack()
		{
			return this.Condition<ICheckEntityBuffStack>().Value;
		}

		// Token: 0x0602C846 RID: 182342 RVA: 0x0061AA54 File Offset: 0x00618C54
		public ICheckAvailableSunSpiritCount ConditionAsICheckAvailableSunSpiritCount()
		{
			return this.Condition<ICheckAvailableSunSpiritCount>().Value;
		}

		// Token: 0x0602C847 RID: 182343 RVA: 0x0061AA70 File Offset: 0x00618C70
		public ICheckPlayerEnterClientTriggerDir ConditionAsICheckPlayerEnterClientTriggerDir()
		{
			return this.Condition<ICheckPlayerEnterClientTriggerDir>().Value;
		}

		// Token: 0x0602C848 RID: 182344 RVA: 0x0061AA8C File Offset: 0x00618C8C
		public ICheckPlayerRelativeDistance ConditionAsICheckPlayerRelativeDistance()
		{
			return this.Condition<ICheckPlayerRelativeDistance>().Value;
		}

		// Token: 0x0602C849 RID: 182345 RVA: 0x0061AAA8 File Offset: 0x00618CA8
		public ICheckPlayerRelativeAngle ConditionAsICheckPlayerRelativeAngle()
		{
			return this.Condition<ICheckPlayerRelativeAngle>().Value;
		}

		// Token: 0x0602C84A RID: 182346 RVA: 0x0061AAC4 File Offset: 0x00618CC4
		public ICheckHonamiStoryGetItem ConditionAsICheckHonamiStoryGetItem()
		{
			return this.Condition<ICheckHonamiStoryGetItem>().Value;
		}

		// Token: 0x0602C84B RID: 182347 RVA: 0x0061AAE0 File Offset: 0x00618CE0
		public ICheckHonamiStoryEquipItem ConditionAsICheckHonamiStoryEquipItem()
		{
			return this.Condition<ICheckHonamiStoryEquipItem>().Value;
		}

		// Token: 0x0602C84C RID: 182348 RVA: 0x0061AAFC File Offset: 0x00618CFC
		public ICheckHonamiStoryActivateTalent ConditionAsICheckHonamiStoryActivateTalent()
		{
			return this.Condition<ICheckHonamiStoryActivateTalent>().Value;
		}

		// Token: 0x0602C84D RID: 182349 RVA: 0x0061AB18 File Offset: 0x00618D18
		public ICheckHonamiStoryUnlockSlot ConditionAsICheckHonamiStoryUnlockSlot()
		{
			return this.Condition<ICheckHonamiStoryUnlockSlot>().Value;
		}

		// Token: 0x0602C84E RID: 182350 RVA: 0x0061AB34 File Offset: 0x00618D34
		public ICheckHonamiStoryLifeSupportLevel ConditionAsICheckHonamiStoryLifeSupportLevel()
		{
			return this.Condition<ICheckHonamiStoryLifeSupportLevel>().Value;
		}

		// Token: 0x0602C84F RID: 182351 RVA: 0x0061AB50 File Offset: 0x00618D50
		public ICheckHonamiStoryTowerComplete ConditionAsICheckHonamiStoryTowerComplete()
		{
			return this.Condition<ICheckHonamiStoryTowerComplete>().Value;
		}

		// Token: 0x0602C850 RID: 182352 RVA: 0x0061AB6C File Offset: 0x00618D6C
		public ICheckHonamiStoryPlayerCorruptedLevel ConditionAsICheckHonamiStoryPlayerCorruptedLevel()
		{
			return this.Condition<ICheckHonamiStoryPlayerCorruptedLevel>().Value;
		}

		// Token: 0x0602C851 RID: 182353 RVA: 0x0061AB88 File Offset: 0x00618D88
		public ICheckHonamiStoryUnlockMascot ConditionAsICheckHonamiStoryUnlockMascot()
		{
			return this.Condition<ICheckHonamiStoryUnlockMascot>().Value;
		}

		// Token: 0x0602C852 RID: 182354 RVA: 0x0061ABA4 File Offset: 0x00618DA4
		public ICheckHonamiStoryChestOpenTime ConditionAsICheckHonamiStoryChestOpenTime()
		{
			return this.Condition<ICheckHonamiStoryChestOpenTime>().Value;
		}

		// Token: 0x0602C853 RID: 182355 RVA: 0x0061ABC0 File Offset: 0x00618DC0
		public ICheckHonamiStorySuccessfulEvacuation ConditionAsICheckHonamiStorySuccessfulEvacuation()
		{
			return this.Condition<ICheckHonamiStorySuccessfulEvacuation>().Value;
		}

		// Token: 0x0602C854 RID: 182356 RVA: 0x0061ABDC File Offset: 0x00618DDC
		public ICheckBvbChallengeState ConditionAsICheckBvbChallengeState()
		{
			return this.Condition<ICheckBvbChallengeState>().Value;
		}

		// Token: 0x0602C855 RID: 182357 RVA: 0x0061ABF8 File Offset: 0x00618DF8
		public ICheckBvbActivityRank ConditionAsICheckBvbActivityRank()
		{
			return this.Condition<ICheckBvbActivityRank>().Value;
		}

		// Token: 0x0602C856 RID: 182358 RVA: 0x0061AC14 File Offset: 0x00618E14
		public ICheckCollectedSunSpiritCount ConditionAsICheckCollectedSunSpiritCount()
		{
			return this.Condition<ICheckCollectedSunSpiritCount>().Value;
		}

		// Token: 0x0602C857 RID: 182359 RVA: 0x0061AC30 File Offset: 0x00618E30
		public ICheckTargetSunSpiritCollected ConditionAsICheckTargetSunSpiritCollected()
		{
			return this.Condition<ICheckTargetSunSpiritCollected>().Value;
		}

		// Token: 0x0602C858 RID: 182360 RVA: 0x0061AC4C File Offset: 0x00618E4C
		public ICheckPlayerIsInDeadEyeProcess ConditionAsICheckPlayerIsInDeadEyeProcess()
		{
			return this.Condition<ICheckPlayerIsInDeadEyeProcess>().Value;
		}

		// Token: 0x0602C859 RID: 182361 RVA: 0x0061AC68 File Offset: 0x00618E68
		public ICheckEntitySelfDirection ConditionAsICheckEntitySelfDirection()
		{
			return this.Condition<ICheckEntitySelfDirection>().Value;
		}

		// Token: 0x0602C85A RID: 182362 RVA: 0x0061AC84 File Offset: 0x00618E84
		public ICheckDollGrabItemComboAchievedInOnceDelivery ConditionAsICheckDollGrabItemComboAchievedInOnceDelivery()
		{
			return this.Condition<ICheckDollGrabItemComboAchievedInOnceDelivery>().Value;
		}

		// Token: 0x0602C85B RID: 182363 RVA: 0x0061ACA0 File Offset: 0x00618EA0
		public ICheckDollGrabShowcaseItemComboAchieved ConditionAsICheckDollGrabShowcaseItemComboAchieved()
		{
			return this.Condition<ICheckDollGrabShowcaseItemComboAchieved>().Value;
		}

		// Token: 0x0602C85C RID: 182364 RVA: 0x0061ACBC File Offset: 0x00618EBC
		public ICheckRoverRogueAbilitySelectCondition ConditionAsICheckRoverRogueAbilitySelectCondition()
		{
			return this.Condition<ICheckRoverRogueAbilitySelectCondition>().Value;
		}

		// Token: 0x0602C85D RID: 182365 RVA: 0x0061ACD8 File Offset: 0x00618ED8
		public ICheckDollGrabMachineFinished ConditionAsICheckDollGrabMachineFinished()
		{
			return this.Condition<ICheckDollGrabMachineFinished>().Value;
		}

		// Token: 0x0602C85E RID: 182366 RVA: 0x0061ACF4 File Offset: 0x00618EF4
		public ICheckTrafficBlocked ConditionAsICheckTrafficBlocked()
		{
			return this.Condition<ICheckTrafficBlocked>().Value;
		}

		// Token: 0x0602C85F RID: 182367 RVA: 0x0061AD10 File Offset: 0x00618F10
		public ICheckDrinksPreferenceLevel ConditionAsICheckDrinksPreferenceLevel()
		{
			return this.Condition<ICheckDrinksPreferenceLevel>().Value;
		}

		// Token: 0x0602C860 RID: 182368 RVA: 0x0061AD2C File Offset: 0x00618F2C
		public ICheckPlayerIsInMotorcycleCruise ConditionAsICheckPlayerIsInMotorcycleCruise()
		{
			return this.Condition<ICheckPlayerIsInMotorcycleCruise>().Value;
		}

		// Token: 0x0602C861 RID: 182369 RVA: 0x0061AD48 File Offset: 0x00618F48
		public ICheckTetrisEndlessScore ConditionAsICheckTetrisEndlessScore()
		{
			return this.Condition<ICheckTetrisEndlessScore>().Value;
		}

		// Token: 0x0602C862 RID: 182370 RVA: 0x0061AD64 File Offset: 0x00618F64
		public ICheckAtlasUnlocked ConditionAsICheckAtlasUnlocked()
		{
			return this.Condition<ICheckAtlasUnlocked>().Value;
		}

		// Token: 0x0602C863 RID: 182371 RVA: 0x0061AD80 File Offset: 0x00618F80
		public ICheckSheriffUnlockEnding ConditionAsICheckSheriffUnlockEnding()
		{
			return this.Condition<ICheckSheriffUnlockEnding>().Value;
		}

		// Token: 0x0602C864 RID: 182372 RVA: 0x0061AD9C File Offset: 0x00618F9C
		public ICheckIsInDragActorPlay ConditionAsICheckIsInDragActorPlay()
		{
			return this.Condition<ICheckIsInDragActorPlay>().Value;
		}

		// Token: 0x0602C865 RID: 182373 RVA: 0x0061ADB8 File Offset: 0x00618FB8
		public ICheckIsInDollGrabGamePlay ConditionAsICheckIsInDollGrabGamePlay()
		{
			return this.Condition<ICheckIsInDollGrabGamePlay>().Value;
		}

		// Token: 0x0602C866 RID: 182374 RVA: 0x0061ADD4 File Offset: 0x00618FD4
		public ICheckEntityPrefabPerformanceType ConditionAsICheckEntityPrefabPerformanceType()
		{
			return this.Condition<ICheckEntityPrefabPerformanceType>().Value;
		}

		// Token: 0x0602C867 RID: 182375 RVA: 0x0061ADF0 File Offset: 0x00618FF0
		public ICheckIsSupportedWalking ConditionAsICheckIsSupportedWalking()
		{
			return this.Condition<ICheckIsSupportedWalking>().Value;
		}

		// Token: 0x0602C868 RID: 182376 RVA: 0x0061AE0C File Offset: 0x0061900C
		public ICheckGiantStableValue ConditionAsICheckGiantStableValue()
		{
			return this.Condition<ICheckGiantStableValue>().Value;
		}

		// Token: 0x0602C869 RID: 182377 RVA: 0x0061AE28 File Offset: 0x00619028
		public ICheckGiantTotalProgressCanActivateNode ConditionAsICheckGiantTotalProgressCanActivateNode()
		{
			return this.Condition<ICheckGiantTotalProgressCanActivateNode>().Value;
		}

		// Token: 0x0602C86A RID: 182378 RVA: 0x0061AE44 File Offset: 0x00619044
		public ICheckGiantTotalProgressInteractActivatedNode ConditionAsICheckGiantTotalProgressInteractActivatedNode()
		{
			return this.Condition<ICheckGiantTotalProgressInteractActivatedNode>().Value;
		}

		// Token: 0x0602C86B RID: 182379 RVA: 0x0061AE60 File Offset: 0x00619060
		public ICheckGiantRegionCultivationTriggeredUpgradeLevel ConditionAsICheckGiantRegionCultivationTriggeredUpgradeLevel()
		{
			return this.Condition<ICheckGiantRegionCultivationTriggeredUpgradeLevel>().Value;
		}

		// Token: 0x0602C86C RID: 182380 RVA: 0x0061AE7C File Offset: 0x0061907C
		public ICheckElementalBoxState ConditionAsICheckElementalBoxState()
		{
			return this.Condition<ICheckElementalBoxState>().Value;
		}

		// Token: 0x0602C86D RID: 182381 RVA: 0x0061AE98 File Offset: 0x00619098
		public ICheckIsTargetHoldElementalBox ConditionAsICheckIsTargetHoldElementalBox()
		{
			return this.Condition<ICheckIsTargetHoldElementalBox>().Value;
		}

		// Token: 0x0602C86E RID: 182382 RVA: 0x0061AEB4 File Offset: 0x006190B4
		public ICheckElementalEffectActive ConditionAsICheckElementalEffectActive()
		{
			return this.Condition<ICheckElementalEffectActive>().Value;
		}

		// Token: 0x0602C86F RID: 182383 RVA: 0x0061AED0 File Offset: 0x006190D0
		public ICheckElementalWaterBoxStagnationSeq ConditionAsICheckElementalWaterBoxStagnationSeq()
		{
			return this.Condition<ICheckElementalWaterBoxStagnationSeq>().Value;
		}

		// Token: 0x0602C870 RID: 182384 RVA: 0x0061AEEB File Offset: 0x006190EB
		public static Offset<ICommonBtOverrideConditionInfo> CreateICommonBtOverrideConditionInfo(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType Type = ECommonBtPlaceholderTargetType.Action, ICondition2_Union Condition_type = ICondition2_Union.NONE, int ConditionOffset = 0)
		{
			builder.StartTable(3);
			ICommonBtOverrideConditionInfo.AddCondition(builder, ConditionOffset);
			ICommonBtOverrideConditionInfo.AddConditionType(builder, Condition_type);
			ICommonBtOverrideConditionInfo.AddType(builder, Type);
			return ICommonBtOverrideConditionInfo.EndICommonBtOverrideConditionInfo(builder);
		}

		// Token: 0x0602C871 RID: 182385 RVA: 0x0061AF0F File Offset: 0x0061910F
		public static void StartICommonBtOverrideConditionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C872 RID: 182386 RVA: 0x0061AF18 File Offset: 0x00619118
		public static void AddType(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C873 RID: 182387 RVA: 0x0061AF23 File Offset: 0x00619123
		public static void AddConditionType(FlatBufferBuilder builder, ICondition2_Union conditionType)
		{
			builder.AddByte(1, (byte)conditionType, 0);
		}

		// Token: 0x0602C874 RID: 182388 RVA: 0x0061AF2E File Offset: 0x0061912E
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(2, conditionOffset, 0);
		}

		// Token: 0x0602C875 RID: 182389 RVA: 0x0061AF39 File Offset: 0x00619139
		public static Offset<ICommonBtOverrideConditionInfo> EndICommonBtOverrideConditionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtOverrideConditionInfo>(builder.EndTable());
		}

		// Token: 0x0602C876 RID: 182390 RVA: 0x0061AF48 File Offset: 0x00619148
		public ICommonBtOverrideConditionInfoT UnPack()
		{
			ICommonBtOverrideConditionInfoT commonBtOverrideConditionInfoT = new ICommonBtOverrideConditionInfoT();
			this.UnPackTo(commonBtOverrideConditionInfoT);
			return commonBtOverrideConditionInfoT;
		}

		// Token: 0x0602C877 RID: 182391 RVA: 0x0061AF64 File Offset: 0x00619164
		public void UnPackTo(ICommonBtOverrideConditionInfoT _o)
		{
			_o.Type = this.Type;
			_o.Condition = new ICondition2_UnionUnion();
			_o.Condition.Type = this.ConditionType;
			switch (this.ConditionType)
			{
			case ICondition2_Union.ICondition2:
				_o.Condition.Value = ((this.Condition<ICondition2>() != null) ? this.Condition<ICondition2>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareVarCondition:
				_o.Condition.Value = ((this.Condition<ICompareVarCondition>() != null) ? this.Condition<ICompareVarCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IQuestStateEqualCondition:
				_o.Condition.Value = ((this.Condition<IQuestStateEqualCondition>() != null) ? this.Condition<IQuestStateEqualCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareExploreLevelCondition:
				_o.Condition.Value = ((this.Condition<ICompareExploreLevelCondition>() != null) ? this.Condition<ICompareExploreLevelCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareCalabashLevelCondition:
				_o.Condition.Value = ((this.Condition<ICompareCalabashLevelCondition>() != null) ? this.Condition<ICompareCalabashLevelCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareLiftCondition:
				_o.Condition.Value = ((this.Condition<ICompareLiftCondition>() != null) ? this.Condition<ICompareLiftCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareEntityStateCondition:
				_o.Condition.Value = ((this.Condition<ICompareEntityStateCondition>() != null) ? this.Condition<ICompareEntityStateCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareNpcPerformStateCondition:
				_o.Condition.Value = ((this.Condition<ICompareNpcPerformStateCondition>() != null) ? this.Condition<ICompareNpcPerformStateCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckTreasureBeenClaimedCondition:
				_o.Condition.Value = ((this.Condition<ICheckTreasureBeenClaimedCondition>() != null) ? this.Condition<ICheckTreasureBeenClaimedCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareEntityGroupStateCondition:
				_o.Condition.Value = ((this.Condition<ICompareEntityGroupStateCondition>() != null) ? this.Condition<ICompareEntityGroupStateCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareEntitySelfStateCondition:
				_o.Condition.Value = ((this.Condition<ICompareEntitySelfStateCondition>() != null) ? this.Condition<ICompareEntitySelfStateCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareLevelPlayRewardStateCondition:
				_o.Condition.Value = ((this.Condition<ICompareLevelPlayRewardStateCondition>() != null) ? this.Condition<ICompareLevelPlayRewardStateCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IHourToHourCondition:
				_o.Condition.Value = ((this.Condition<IHourToHourCondition>() != null) ? this.Condition<IHourToHourCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IRangeSphere:
				_o.Condition.Value = ((this.Condition<IRangeSphere>() != null) ? this.Condition<IRangeSphere>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckItems:
				_o.Condition.Value = ((this.Condition<ICheckItems>() != null) ? this.Condition<ICheckItems>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IHasBuff:
				_o.Condition.Value = ((this.Condition<IHasBuff>() != null) ? this.Condition<IHasBuff>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckSystemFunction:
				_o.Condition.Value = ((this.Condition<ICheckSystemFunction>() != null) ? this.Condition<ICheckSystemFunction>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckAiState:
				_o.Condition.Value = ((this.Condition<ICheckAiState>() != null) ? this.Condition<ICheckAiState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareDungeonId:
				_o.Condition.Value = ((this.Condition<ICompareDungeonId>() != null) ? this.Condition<ICompareDungeonId>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareTimePeriod:
				_o.Condition.Value = ((this.Condition<ICompareTimePeriod>() != null) ? this.Condition<ICompareTimePeriod>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareWeather:
				_o.Condition.Value = ((this.Condition<ICompareWeather>() != null) ? this.Condition<ICompareWeather>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckLevelPlayState:
				_o.Condition.Value = ((this.Condition<ICheckLevelPlayState>() != null) ? this.Condition<ICheckLevelPlayState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckLevelPlayCompleteNumber:
				_o.Condition.Value = ((this.Condition<ICheckLevelPlayCompleteNumber>() != null) ? this.Condition<ICheckLevelPlayCompleteNumber>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckLevelPlayChildQuestFinished:
				_o.Condition.Value = ((this.Condition<ICheckLevelPlayChildQuestFinished>() != null) ? this.Condition<ICheckLevelPlayChildQuestFinished>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckCurrentRole:
				_o.Condition.Value = ((this.Condition<ICheckCurrentRole>() != null) ? this.Condition<ICheckCurrentRole>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerGender:
				_o.Condition.Value = ((this.Condition<ICheckPlayerGender>() != null) ? this.Condition<ICheckPlayerGender>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckInCombat:
				_o.Condition.Value = ((this.Condition<ICheckInCombat>() != null) ? this.Condition<ICheckInCombat>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHasFollowShooter:
				_o.Condition.Value = ((this.Condition<ICheckHasFollowShooter>() != null) ? this.Condition<ICheckHasFollowShooter>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckFollowShooterActive:
				_o.Condition.Value = ((this.Condition<ICheckFollowShooterActive>() != null) ? this.Condition<ICheckFollowShooterActive>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckChildQuestFinished:
				_o.Condition.Value = ((this.Condition<ICheckChildQuestFinished>() != null) ? this.Condition<ICheckChildQuestFinished>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckSyncLevelPlayCompleteNumber:
				_o.Condition.Value = ((this.Condition<ICheckSyncLevelPlayCompleteNumber>() != null) ? this.Condition<ICheckSyncLevelPlayCompleteNumber>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckCrossSceneSyncKillMonsterFinished:
				_o.Condition.Value = ((this.Condition<ICheckCrossSceneSyncKillMonsterFinished>() != null) ? this.Condition<ICheckCrossSceneSyncKillMonsterFinished>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckNodeStatus:
				_o.Condition.Value = ((this.Condition<ICheckNodeStatus>() != null) ? this.Condition<ICheckNodeStatus>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckChildQuestStatus:
				_o.Condition.Value = ((this.Condition<ICheckChildQuestStatus>() != null) ? this.Condition<ICheckChildQuestStatus>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntitiesExist:
				_o.Condition.Value = ((this.Condition<ICheckEntitiesExist>() != null) ? this.Condition<ICheckEntitiesExist>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerPosition:
				_o.Condition.Value = ((this.Condition<ICheckPlayerPosition>() != null) ? this.Condition<ICheckPlayerPosition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityPosition:
				_o.Condition.Value = ((this.Condition<ICheckEntityPosition>() != null) ? this.Condition<ICheckEntityPosition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDungeonFinish:
				_o.Condition.Value = ((this.Condition<ICheckDungeonFinish>() != null) ? this.Condition<ICheckDungeonFinish>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityIsVisibility:
				_o.Condition.Value = ((this.Condition<ICheckEntityIsVisibility>() != null) ? this.Condition<ICheckEntityIsVisibility>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IComparePlayerMotionState:
				_o.Condition.Value = ((this.Condition<IComparePlayerMotionState>() != null) ? this.Condition<IComparePlayerMotionState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IComparePlayerMotionState2:
				_o.Condition.Value = ((this.Condition<IComparePlayerMotionState2>() != null) ? this.Condition<IComparePlayerMotionState2>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDataLayerCondition:
				_o.Condition.Value = ((this.Condition<ICheckDataLayerCondition>() != null) ? this.Condition<ICheckDataLayerCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHookLockPointCondition:
				_o.Condition.Value = ((this.Condition<ICheckHookLockPointCondition>() != null) ? this.Condition<ICheckHookLockPointCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerSkillReadyCondition:
				_o.Condition.Value = ((this.Condition<ICheckPlayerSkillReadyCondition>() != null) ? this.Condition<ICheckPlayerSkillReadyCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerUseSkillCondition:
				_o.Condition.Value = ((this.Condition<ICheckPlayerUseSkillCondition>() != null) ? this.Condition<ICheckPlayerUseSkillCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerStateRestrictionCondition:
				_o.Condition.Value = ((this.Condition<ICheckPlayerStateRestrictionCondition>() != null) ? this.Condition<ICheckPlayerStateRestrictionCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckLordGymFinishCondition:
				_o.Condition.Value = ((this.Condition<ICheckLordGymFinishCondition>() != null) ? this.Condition<ICheckLordGymFinishCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckCalabashDevelopRewardCondition:
				_o.Condition.Value = ((this.Condition<ICheckCalabashDevelopRewardCondition>() != null) ? this.Condition<ICheckCalabashDevelopRewardCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareFishingPrestigeLevelCondition:
				_o.Condition.Value = ((this.Condition<ICompareFishingPrestigeLevelCondition>() != null) ? this.Condition<ICompareFishingPrestigeLevelCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckCertainFishingItemCount:
				_o.Condition.Value = ((this.Condition<ICheckCertainFishingItemCount>() != null) ? this.Condition<ICheckCertainFishingItemCount>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompleteCertainFishingEntrust:
				_o.Condition.Value = ((this.Condition<ICompleteCertainFishingEntrust>() != null) ? this.Condition<ICompleteCertainFishingEntrust>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareFishingBoatState:
				_o.Condition.Value = ((this.Condition<ICompareFishingBoatState>() != null) ? this.Condition<ICompareFishingBoatState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckJigsawInfoCondition:
				_o.Condition.Value = ((this.Condition<ICheckJigsawInfoCondition>() != null) ? this.Condition<ICheckJigsawInfoCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckGameplayTagCondition:
				_o.Condition.Value = ((this.Condition<ICheckGameplayTagCondition>() != null) ? this.Condition<ICheckGameplayTagCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckFormationRoleInfoCondition:
				_o.Condition.Value = ((this.Condition<ICheckFormationRoleInfoCondition>() != null) ? this.Condition<ICheckFormationRoleInfoCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckTargetAttributeCondition:
				_o.Condition.Value = ((this.Condition<ICheckTargetAttributeCondition>() != null) ? this.Condition<ICheckTargetAttributeCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckRogueAbilitySelectCondition:
				_o.Condition.Value = ((this.Condition<ICheckRogueAbilitySelectCondition>() != null) ? this.Condition<ICheckRogueAbilitySelectCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDirectionCondition:
				_o.Condition.Value = ((this.Condition<ICheckDirectionCondition>() != null) ? this.Condition<ICheckDirectionCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckSceneItemDirectionCondition:
				_o.Condition.Value = ((this.Condition<ICheckSceneItemDirectionCondition>() != null) ? this.Condition<ICheckSceneItemDirectionCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerFaceToCondition:
				_o.Condition.Value = ((this.Condition<ICheckPlayerFaceToCondition>() != null) ? this.Condition<ICheckPlayerFaceToCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerCanJoinActivityCondition:
				_o.Condition.Value = ((this.Condition<ICheckPlayerCanJoinActivityCondition>() != null) ? this.Condition<ICheckPlayerCanJoinActivityCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckSystemStateCondition:
				_o.Condition.Value = ((this.Condition<ICheckSystemStateCondition>() != null) ? this.Condition<ICheckSystemStateCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckInRangeCondition:
				_o.Condition.Value = ((this.Condition<ICheckInRangeCondition>() != null) ? this.Condition<ICheckInRangeCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckInRangeProperlyCondition:
				_o.Condition.Value = ((this.Condition<ICheckInRangeProperlyCondition>() != null) ? this.Condition<ICheckInRangeProperlyCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityLockedCondition:
				_o.Condition.Value = ((this.Condition<ICheckEntityLockedCondition>() != null) ? this.Condition<ICheckEntityLockedCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareTeammateDieCondition:
				_o.Condition.Value = ((this.Condition<ICompareTeammateDieCondition>() != null) ? this.Condition<ICompareTeammateDieCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IListenEntitySelfEventCondition:
				_o.Condition.Value = ((this.Condition<IListenEntitySelfEventCondition>() != null) ? this.Condition<IListenEntitySelfEventCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityDistanceCondition:
				_o.Condition.Value = ((this.Condition<ICheckEntityDistanceCondition>() != null) ? this.Condition<ICheckEntityDistanceCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityHasSceneItemAttributeTag:
				_o.Condition.Value = ((this.Condition<ICheckEntityHasSceneItemAttributeTag>() != null) ? this.Condition<ICheckEntityHasSceneItemAttributeTag>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IListenEntityThroughPortal:
				_o.Condition.Value = ((this.Condition<IListenEntityThroughPortal>() != null) ? this.Condition<IListenEntityThroughPortal>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckTeleControlState:
				_o.Condition.Value = ((this.Condition<ICheckTeleControlState>() != null) ? this.Condition<ICheckTeleControlState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICustomJsonCondition:
				_o.Condition.Value = ((this.Condition<ICustomJsonCondition>() != null) ? this.Condition<ICustomJsonCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckChessWinner:
				_o.Condition.Value = ((this.Condition<ICheckChessWinner>() != null) ? this.Condition<ICheckChessWinner>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckVehicleCondition:
				_o.Condition.Value = ((this.Condition<ICheckVehicleCondition>() != null) ? this.Condition<ICheckVehicleCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareAlertValue:
				_o.Condition.Value = ((this.Condition<ICompareAlertValue>() != null) ? this.Condition<ICompareAlertValue>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityGravityDirection:
				_o.Condition.Value = ((this.Condition<ICheckEntityGravityDirection>() != null) ? this.Condition<ICheckEntityGravityDirection>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckCollectAnimalParts:
				_o.Condition.Value = ((this.Condition<ICheckCollectAnimalParts>() != null) ? this.Condition<ICheckCollectAnimalParts>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckFinishLoading:
				_o.Condition.Value = ((this.Condition<ICheckFinishLoading>() != null) ? this.Condition<ICheckFinishLoading>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckFishingPointHasFish:
				_o.Condition.Value = ((this.Condition<ICheckFishingPointHasFish>() != null) ? this.Condition<ICheckFishingPointHasFish>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckFishingCageFillingRatio:
				_o.Condition.Value = ((this.Condition<ICheckFishingCageFillingRatio>() != null) ? this.Condition<ICheckFishingCageFillingRatio>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareFishingTechLevel:
				_o.Condition.Value = ((this.Condition<ICompareFishingTechLevel>() != null) ? this.Condition<ICompareFishingTechLevel>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckGuestCharacter:
				_o.Condition.Value = ((this.Condition<ICheckGuestCharacter>() != null) ? this.Condition<ICheckGuestCharacter>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckSubLevelState:
				_o.Condition.Value = ((this.Condition<ICheckSubLevelState>() != null) ? this.Condition<ICheckSubLevelState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.IComparePlayerNumInDungeon:
				_o.Condition.Value = ((this.Condition<IComparePlayerNumInDungeon>() != null) ? this.Condition<IComparePlayerNumInDungeon>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckAlertAreaEnabled:
				_o.Condition.Value = ((this.Condition<ICheckAlertAreaEnabled>() != null) ? this.Condition<ICheckAlertAreaEnabled>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckClientEvent:
				_o.Condition.Value = ((this.Condition<ICheckClientEvent>() != null) ? this.Condition<ICheckClientEvent>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsGramophonePlayingMusic:
				_o.Condition.Value = ((this.Condition<ICheckIsGramophonePlayingMusic>() != null) ? this.Condition<ICheckIsGramophonePlayingMusic>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityReward:
				_o.Condition.Value = ((this.Condition<ICheckEntityReward>() != null) ? this.Condition<ICheckEntityReward>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDungeonHasSaveConfig:
				_o.Condition.Value = ((this.Condition<ICheckDungeonHasSaveConfig>() != null) ? this.Condition<ICheckDungeonHasSaveConfig>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckSystemEventBvb:
				_o.Condition.Value = ((this.Condition<ICheckSystemEventBvb>() != null) ? this.Condition<ICheckSystemEventBvb>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDangoCultivationProgress:
				_o.Condition.Value = ((this.Condition<ICheckDangoCultivationProgress>() != null) ? this.Condition<ICheckDangoCultivationProgress>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerMoraleLevelRange:
				_o.Condition.Value = ((this.Condition<ICheckPlayerMoraleLevelRange>() != null) ? this.Condition<ICheckPlayerMoraleLevelRange>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsGlobalTimeScaleEnabled:
				_o.Condition.Value = ((this.Condition<ICheckIsGlobalTimeScaleEnabled>() != null) ? this.Condition<ICheckIsGlobalTimeScaleEnabled>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ISaveConfigEnterMethod:
				_o.Condition.Value = ((this.Condition<ISaveConfigEnterMethod>() != null) ? this.Condition<ISaveConfigEnterMethod>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsEntityTimeScaleEnabled:
				_o.Condition.Value = ((this.Condition<ICheckIsEntityTimeScaleEnabled>() != null) ? this.Condition<ICheckIsEntityTimeScaleEnabled>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsCharacterHoldingHands:
				_o.Condition.Value = ((this.Condition<ICheckIsCharacterHoldingHands>() != null) ? this.Condition<ICheckIsCharacterHoldingHands>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsTrackingCurrentQuest:
				_o.Condition.Value = ((this.Condition<ICheckIsTrackingCurrentQuest>() != null) ? this.Condition<ICheckIsTrackingCurrentQuest>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsTrackingQuest:
				_o.Condition.Value = ((this.Condition<ICheckIsTrackingQuest>() != null) ? this.Condition<ICheckIsTrackingQuest>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckMusicEvent:
				_o.Condition.Value = ((this.Condition<ICheckMusicEvent>() != null) ? this.Condition<ICheckMusicEvent>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareGameDifficulty:
				_o.Condition.Value = ((this.Condition<ICompareGameDifficulty>() != null) ? this.Condition<ICompareGameDifficulty>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPhotographCameraParam:
				_o.Condition.Value = ((this.Condition<ICheckPhotographCameraParam>() != null) ? this.Condition<ICheckPhotographCameraParam>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityHasBuff:
				_o.Condition.Value = ((this.Condition<ICheckEntityHasBuff>() != null) ? this.Condition<ICheckEntityHasBuff>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityBuffStack:
				_o.Condition.Value = ((this.Condition<ICheckEntityBuffStack>() != null) ? this.Condition<ICheckEntityBuffStack>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckAvailableSunSpiritCount:
				_o.Condition.Value = ((this.Condition<ICheckAvailableSunSpiritCount>() != null) ? this.Condition<ICheckAvailableSunSpiritCount>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerEnterClientTriggerDir:
				_o.Condition.Value = ((this.Condition<ICheckPlayerEnterClientTriggerDir>() != null) ? this.Condition<ICheckPlayerEnterClientTriggerDir>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerRelativeDistance:
				_o.Condition.Value = ((this.Condition<ICheckPlayerRelativeDistance>() != null) ? this.Condition<ICheckPlayerRelativeDistance>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerRelativeAngle:
				_o.Condition.Value = ((this.Condition<ICheckPlayerRelativeAngle>() != null) ? this.Condition<ICheckPlayerRelativeAngle>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryGetItem:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryGetItem>() != null) ? this.Condition<ICheckHonamiStoryGetItem>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryEquipItem:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryEquipItem>() != null) ? this.Condition<ICheckHonamiStoryEquipItem>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryActivateTalent:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryActivateTalent>() != null) ? this.Condition<ICheckHonamiStoryActivateTalent>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryUnlockSlot:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryUnlockSlot>() != null) ? this.Condition<ICheckHonamiStoryUnlockSlot>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryLifeSupportLevel:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryLifeSupportLevel>() != null) ? this.Condition<ICheckHonamiStoryLifeSupportLevel>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryTowerComplete:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryTowerComplete>() != null) ? this.Condition<ICheckHonamiStoryTowerComplete>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryPlayerCorruptedLevel:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryPlayerCorruptedLevel>() != null) ? this.Condition<ICheckHonamiStoryPlayerCorruptedLevel>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryUnlockMascot:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryUnlockMascot>() != null) ? this.Condition<ICheckHonamiStoryUnlockMascot>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStoryChestOpenTime:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStoryChestOpenTime>() != null) ? this.Condition<ICheckHonamiStoryChestOpenTime>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckHonamiStorySuccessfulEvacuation:
				_o.Condition.Value = ((this.Condition<ICheckHonamiStorySuccessfulEvacuation>() != null) ? this.Condition<ICheckHonamiStorySuccessfulEvacuation>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckBvbChallengeState:
				_o.Condition.Value = ((this.Condition<ICheckBvbChallengeState>() != null) ? this.Condition<ICheckBvbChallengeState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckBvbActivityRank:
				_o.Condition.Value = ((this.Condition<ICheckBvbActivityRank>() != null) ? this.Condition<ICheckBvbActivityRank>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckCollectedSunSpiritCount:
				_o.Condition.Value = ((this.Condition<ICheckCollectedSunSpiritCount>() != null) ? this.Condition<ICheckCollectedSunSpiritCount>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckTargetSunSpiritCollected:
				_o.Condition.Value = ((this.Condition<ICheckTargetSunSpiritCollected>() != null) ? this.Condition<ICheckTargetSunSpiritCollected>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerIsInDeadEyeProcess:
				_o.Condition.Value = ((this.Condition<ICheckPlayerIsInDeadEyeProcess>() != null) ? this.Condition<ICheckPlayerIsInDeadEyeProcess>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntitySelfDirection:
				_o.Condition.Value = ((this.Condition<ICheckEntitySelfDirection>() != null) ? this.Condition<ICheckEntitySelfDirection>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDollGrabItemComboAchievedInOnceDelivery:
				_o.Condition.Value = ((this.Condition<ICheckDollGrabItemComboAchievedInOnceDelivery>() != null) ? this.Condition<ICheckDollGrabItemComboAchievedInOnceDelivery>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDollGrabShowcaseItemComboAchieved:
				_o.Condition.Value = ((this.Condition<ICheckDollGrabShowcaseItemComboAchieved>() != null) ? this.Condition<ICheckDollGrabShowcaseItemComboAchieved>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckRoverRogueAbilitySelectCondition:
				_o.Condition.Value = ((this.Condition<ICheckRoverRogueAbilitySelectCondition>() != null) ? this.Condition<ICheckRoverRogueAbilitySelectCondition>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDollGrabMachineFinished:
				_o.Condition.Value = ((this.Condition<ICheckDollGrabMachineFinished>() != null) ? this.Condition<ICheckDollGrabMachineFinished>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckTrafficBlocked:
				_o.Condition.Value = ((this.Condition<ICheckTrafficBlocked>() != null) ? this.Condition<ICheckTrafficBlocked>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDrinksPreferenceLevel:
				_o.Condition.Value = ((this.Condition<ICheckDrinksPreferenceLevel>() != null) ? this.Condition<ICheckDrinksPreferenceLevel>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckPlayerIsInMotorcycleCruise:
				_o.Condition.Value = ((this.Condition<ICheckPlayerIsInMotorcycleCruise>() != null) ? this.Condition<ICheckPlayerIsInMotorcycleCruise>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckTetrisEndlessScore:
				_o.Condition.Value = ((this.Condition<ICheckTetrisEndlessScore>() != null) ? this.Condition<ICheckTetrisEndlessScore>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckAtlasUnlocked:
				_o.Condition.Value = ((this.Condition<ICheckAtlasUnlocked>() != null) ? this.Condition<ICheckAtlasUnlocked>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckSheriffUnlockEnding:
				_o.Condition.Value = ((this.Condition<ICheckSheriffUnlockEnding>() != null) ? this.Condition<ICheckSheriffUnlockEnding>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsInDragActorPlay:
				_o.Condition.Value = ((this.Condition<ICheckIsInDragActorPlay>() != null) ? this.Condition<ICheckIsInDragActorPlay>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsInDollGrabGamePlay:
				_o.Condition.Value = ((this.Condition<ICheckIsInDollGrabGamePlay>() != null) ? this.Condition<ICheckIsInDollGrabGamePlay>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckEntityPrefabPerformanceType:
				_o.Condition.Value = ((this.Condition<ICheckEntityPrefabPerformanceType>() != null) ? this.Condition<ICheckEntityPrefabPerformanceType>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsSupportedWalking:
				_o.Condition.Value = ((this.Condition<ICheckIsSupportedWalking>() != null) ? this.Condition<ICheckIsSupportedWalking>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckGiantStableValue:
				_o.Condition.Value = ((this.Condition<ICheckGiantStableValue>() != null) ? this.Condition<ICheckGiantStableValue>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckGiantTotalProgressCanActivateNode:
				_o.Condition.Value = ((this.Condition<ICheckGiantTotalProgressCanActivateNode>() != null) ? this.Condition<ICheckGiantTotalProgressCanActivateNode>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckGiantTotalProgressInteractActivatedNode:
				_o.Condition.Value = ((this.Condition<ICheckGiantTotalProgressInteractActivatedNode>() != null) ? this.Condition<ICheckGiantTotalProgressInteractActivatedNode>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckGiantRegionCultivationTriggeredUpgradeLevel:
				_o.Condition.Value = ((this.Condition<ICheckGiantRegionCultivationTriggeredUpgradeLevel>() != null) ? this.Condition<ICheckGiantRegionCultivationTriggeredUpgradeLevel>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckElementalBoxState:
				_o.Condition.Value = ((this.Condition<ICheckElementalBoxState>() != null) ? this.Condition<ICheckElementalBoxState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsTargetHoldElementalBox:
				_o.Condition.Value = ((this.Condition<ICheckIsTargetHoldElementalBox>() != null) ? this.Condition<ICheckIsTargetHoldElementalBox>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckElementalEffectActive:
				_o.Condition.Value = ((this.Condition<ICheckElementalEffectActive>() != null) ? this.Condition<ICheckElementalEffectActive>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckElementalWaterBoxStagnationSeq:
				_o.Condition.Value = ((this.Condition<ICheckElementalWaterBoxStagnationSeq>() != null) ? this.Condition<ICheckElementalWaterBoxStagnationSeq>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602C878 RID: 182392 RVA: 0x0061D350 File Offset: 0x0061B550
		public static Offset<ICommonBtOverrideConditionInfo> Pack(FlatBufferBuilder builder, ICommonBtOverrideConditionInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtOverrideConditionInfo>);
			}
			ICondition2_Union condition_type = (_o.Condition == null) ? ICondition2_Union.NONE : _o.Condition.Type;
			int conditionOffset = (_o.Condition == null) ? 0 : ICondition2_UnionUnion.Pack(builder, _o.Condition);
			return ICommonBtOverrideConditionInfo.CreateICommonBtOverrideConditionInfo(builder, _o.Type, condition_type, conditionOffset);
		}

		// Token: 0x04010A69 RID: 68201
		private Table __p;
	}
}
