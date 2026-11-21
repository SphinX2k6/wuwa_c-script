using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD3 RID: 27347
	public struct ICommonBtOverrideConditionInfo : IFlatbufferObject
	{
		// Token: 0x1700C8D0 RID: 51408
		// (get) Token: 0x0602EF1B RID: 192283 RVA: 0x00664EB4 File Offset: 0x006630B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EF1C RID: 192284 RVA: 0x00664EC1 File Offset: 0x006630C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EF1D RID: 192285 RVA: 0x00664EC8 File Offset: 0x006630C8
		public static ICommonBtOverrideConditionInfo GetRootAsICommonBtOverrideConditionInfo(ByteBuffer _bb)
		{
			return ICommonBtOverrideConditionInfo.GetRootAsICommonBtOverrideConditionInfo(_bb, default(ICommonBtOverrideConditionInfo));
		}

		// Token: 0x0602EF1E RID: 192286 RVA: 0x00664EE4 File Offset: 0x006630E4
		public static ICommonBtOverrideConditionInfo GetRootAsICommonBtOverrideConditionInfo(ByteBuffer _bb, ICommonBtOverrideConditionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EF1F RID: 192287 RVA: 0x00664F01 File Offset: 0x00663101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EF20 RID: 192288 RVA: 0x00664F10 File Offset: 0x00663110
		public ICommonBtOverrideConditionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8D1 RID: 51409
		// (get) Token: 0x0602EF21 RID: 192289 RVA: 0x00664F20 File Offset: 0x00663120
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

		// Token: 0x1700C8D2 RID: 51410
		// (get) Token: 0x0602EF22 RID: 192290 RVA: 0x00664F5C File Offset: 0x0066315C
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

		// Token: 0x0602EF23 RID: 192291 RVA: 0x00664F98 File Offset: 0x00663198
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EF24 RID: 192292 RVA: 0x00664FDC File Offset: 0x006631DC
		public ICondition2 ConditionAsICondition2()
		{
			return this.Condition<ICondition2>().Value;
		}

		// Token: 0x0602EF25 RID: 192293 RVA: 0x00664FF8 File Offset: 0x006631F8
		public ICompareVarCondition ConditionAsICompareVarCondition()
		{
			return this.Condition<ICompareVarCondition>().Value;
		}

		// Token: 0x0602EF26 RID: 192294 RVA: 0x00665014 File Offset: 0x00663214
		public IQuestStateEqualCondition ConditionAsIQuestStateEqualCondition()
		{
			return this.Condition<IQuestStateEqualCondition>().Value;
		}

		// Token: 0x0602EF27 RID: 192295 RVA: 0x00665030 File Offset: 0x00663230
		public ICompareExploreLevelCondition ConditionAsICompareExploreLevelCondition()
		{
			return this.Condition<ICompareExploreLevelCondition>().Value;
		}

		// Token: 0x0602EF28 RID: 192296 RVA: 0x0066504C File Offset: 0x0066324C
		public ICompareCalabashLevelCondition ConditionAsICompareCalabashLevelCondition()
		{
			return this.Condition<ICompareCalabashLevelCondition>().Value;
		}

		// Token: 0x0602EF29 RID: 192297 RVA: 0x00665068 File Offset: 0x00663268
		public ICompareLiftCondition ConditionAsICompareLiftCondition()
		{
			return this.Condition<ICompareLiftCondition>().Value;
		}

		// Token: 0x0602EF2A RID: 192298 RVA: 0x00665084 File Offset: 0x00663284
		public ICompareEntityStateCondition ConditionAsICompareEntityStateCondition()
		{
			return this.Condition<ICompareEntityStateCondition>().Value;
		}

		// Token: 0x0602EF2B RID: 192299 RVA: 0x006650A0 File Offset: 0x006632A0
		public ICompareNpcPerformStateCondition ConditionAsICompareNpcPerformStateCondition()
		{
			return this.Condition<ICompareNpcPerformStateCondition>().Value;
		}

		// Token: 0x0602EF2C RID: 192300 RVA: 0x006650BC File Offset: 0x006632BC
		public ICheckTreasureBeenClaimedCondition ConditionAsICheckTreasureBeenClaimedCondition()
		{
			return this.Condition<ICheckTreasureBeenClaimedCondition>().Value;
		}

		// Token: 0x0602EF2D RID: 192301 RVA: 0x006650D8 File Offset: 0x006632D8
		public ICompareEntityGroupStateCondition ConditionAsICompareEntityGroupStateCondition()
		{
			return this.Condition<ICompareEntityGroupStateCondition>().Value;
		}

		// Token: 0x0602EF2E RID: 192302 RVA: 0x006650F4 File Offset: 0x006632F4
		public ICompareEntitySelfStateCondition ConditionAsICompareEntitySelfStateCondition()
		{
			return this.Condition<ICompareEntitySelfStateCondition>().Value;
		}

		// Token: 0x0602EF2F RID: 192303 RVA: 0x00665110 File Offset: 0x00663310
		public ICompareLevelPlayRewardStateCondition ConditionAsICompareLevelPlayRewardStateCondition()
		{
			return this.Condition<ICompareLevelPlayRewardStateCondition>().Value;
		}

		// Token: 0x0602EF30 RID: 192304 RVA: 0x0066512C File Offset: 0x0066332C
		public IHourToHourCondition ConditionAsIHourToHourCondition()
		{
			return this.Condition<IHourToHourCondition>().Value;
		}

		// Token: 0x0602EF31 RID: 192305 RVA: 0x00665148 File Offset: 0x00663348
		public IRangeSphere ConditionAsIRangeSphere()
		{
			return this.Condition<IRangeSphere>().Value;
		}

		// Token: 0x0602EF32 RID: 192306 RVA: 0x00665164 File Offset: 0x00663364
		public ICheckItems ConditionAsICheckItems()
		{
			return this.Condition<ICheckItems>().Value;
		}

		// Token: 0x0602EF33 RID: 192307 RVA: 0x00665180 File Offset: 0x00663380
		public IHasBuff ConditionAsIHasBuff()
		{
			return this.Condition<IHasBuff>().Value;
		}

		// Token: 0x0602EF34 RID: 192308 RVA: 0x0066519C File Offset: 0x0066339C
		public ICheckSystemFunction ConditionAsICheckSystemFunction()
		{
			return this.Condition<ICheckSystemFunction>().Value;
		}

		// Token: 0x0602EF35 RID: 192309 RVA: 0x006651B8 File Offset: 0x006633B8
		public ICheckAiState ConditionAsICheckAiState()
		{
			return this.Condition<ICheckAiState>().Value;
		}

		// Token: 0x0602EF36 RID: 192310 RVA: 0x006651D4 File Offset: 0x006633D4
		public ICompareDungeonId ConditionAsICompareDungeonId()
		{
			return this.Condition<ICompareDungeonId>().Value;
		}

		// Token: 0x0602EF37 RID: 192311 RVA: 0x006651F0 File Offset: 0x006633F0
		public ICompareTimePeriod ConditionAsICompareTimePeriod()
		{
			return this.Condition<ICompareTimePeriod>().Value;
		}

		// Token: 0x0602EF38 RID: 192312 RVA: 0x0066520C File Offset: 0x0066340C
		public ICompareWeather ConditionAsICompareWeather()
		{
			return this.Condition<ICompareWeather>().Value;
		}

		// Token: 0x0602EF39 RID: 192313 RVA: 0x00665228 File Offset: 0x00663428
		public ICheckLevelPlayState ConditionAsICheckLevelPlayState()
		{
			return this.Condition<ICheckLevelPlayState>().Value;
		}

		// Token: 0x0602EF3A RID: 192314 RVA: 0x00665244 File Offset: 0x00663444
		public ICheckLevelPlayCompleteNumber ConditionAsICheckLevelPlayCompleteNumber()
		{
			return this.Condition<ICheckLevelPlayCompleteNumber>().Value;
		}

		// Token: 0x0602EF3B RID: 192315 RVA: 0x00665260 File Offset: 0x00663460
		public ICheckLevelPlayChildQuestFinished ConditionAsICheckLevelPlayChildQuestFinished()
		{
			return this.Condition<ICheckLevelPlayChildQuestFinished>().Value;
		}

		// Token: 0x0602EF3C RID: 192316 RVA: 0x0066527C File Offset: 0x0066347C
		public ICheckCurrentRole ConditionAsICheckCurrentRole()
		{
			return this.Condition<ICheckCurrentRole>().Value;
		}

		// Token: 0x0602EF3D RID: 192317 RVA: 0x00665298 File Offset: 0x00663498
		public ICheckPlayerGender ConditionAsICheckPlayerGender()
		{
			return this.Condition<ICheckPlayerGender>().Value;
		}

		// Token: 0x0602EF3E RID: 192318 RVA: 0x006652B4 File Offset: 0x006634B4
		public ICheckInCombat ConditionAsICheckInCombat()
		{
			return this.Condition<ICheckInCombat>().Value;
		}

		// Token: 0x0602EF3F RID: 192319 RVA: 0x006652D0 File Offset: 0x006634D0
		public ICheckHasFollowShooter ConditionAsICheckHasFollowShooter()
		{
			return this.Condition<ICheckHasFollowShooter>().Value;
		}

		// Token: 0x0602EF40 RID: 192320 RVA: 0x006652EC File Offset: 0x006634EC
		public ICheckFollowShooterActive ConditionAsICheckFollowShooterActive()
		{
			return this.Condition<ICheckFollowShooterActive>().Value;
		}

		// Token: 0x0602EF41 RID: 192321 RVA: 0x00665308 File Offset: 0x00663508
		public ICheckChildQuestFinished ConditionAsICheckChildQuestFinished()
		{
			return this.Condition<ICheckChildQuestFinished>().Value;
		}

		// Token: 0x0602EF42 RID: 192322 RVA: 0x00665324 File Offset: 0x00663524
		public ICheckSyncLevelPlayCompleteNumber ConditionAsICheckSyncLevelPlayCompleteNumber()
		{
			return this.Condition<ICheckSyncLevelPlayCompleteNumber>().Value;
		}

		// Token: 0x0602EF43 RID: 192323 RVA: 0x00665340 File Offset: 0x00663540
		public ICheckCrossSceneSyncKillMonsterFinished ConditionAsICheckCrossSceneSyncKillMonsterFinished()
		{
			return this.Condition<ICheckCrossSceneSyncKillMonsterFinished>().Value;
		}

		// Token: 0x0602EF44 RID: 192324 RVA: 0x0066535C File Offset: 0x0066355C
		public ICheckNodeStatus ConditionAsICheckNodeStatus()
		{
			return this.Condition<ICheckNodeStatus>().Value;
		}

		// Token: 0x0602EF45 RID: 192325 RVA: 0x00665378 File Offset: 0x00663578
		public ICheckChildQuestStatus ConditionAsICheckChildQuestStatus()
		{
			return this.Condition<ICheckChildQuestStatus>().Value;
		}

		// Token: 0x0602EF46 RID: 192326 RVA: 0x00665394 File Offset: 0x00663594
		public ICheckEntitiesExist ConditionAsICheckEntitiesExist()
		{
			return this.Condition<ICheckEntitiesExist>().Value;
		}

		// Token: 0x0602EF47 RID: 192327 RVA: 0x006653B0 File Offset: 0x006635B0
		public ICheckPlayerPosition ConditionAsICheckPlayerPosition()
		{
			return this.Condition<ICheckPlayerPosition>().Value;
		}

		// Token: 0x0602EF48 RID: 192328 RVA: 0x006653CC File Offset: 0x006635CC
		public ICheckEntityPosition ConditionAsICheckEntityPosition()
		{
			return this.Condition<ICheckEntityPosition>().Value;
		}

		// Token: 0x0602EF49 RID: 192329 RVA: 0x006653E8 File Offset: 0x006635E8
		public ICheckDungeonFinish ConditionAsICheckDungeonFinish()
		{
			return this.Condition<ICheckDungeonFinish>().Value;
		}

		// Token: 0x0602EF4A RID: 192330 RVA: 0x00665404 File Offset: 0x00663604
		public ICheckEntityIsVisibility ConditionAsICheckEntityIsVisibility()
		{
			return this.Condition<ICheckEntityIsVisibility>().Value;
		}

		// Token: 0x0602EF4B RID: 192331 RVA: 0x00665420 File Offset: 0x00663620
		public IComparePlayerMotionState ConditionAsIComparePlayerMotionState()
		{
			return this.Condition<IComparePlayerMotionState>().Value;
		}

		// Token: 0x0602EF4C RID: 192332 RVA: 0x0066543C File Offset: 0x0066363C
		public IComparePlayerMotionState2 ConditionAsIComparePlayerMotionState2()
		{
			return this.Condition<IComparePlayerMotionState2>().Value;
		}

		// Token: 0x0602EF4D RID: 192333 RVA: 0x00665458 File Offset: 0x00663658
		public ICheckDataLayerCondition ConditionAsICheckDataLayerCondition()
		{
			return this.Condition<ICheckDataLayerCondition>().Value;
		}

		// Token: 0x0602EF4E RID: 192334 RVA: 0x00665474 File Offset: 0x00663674
		public ICheckHookLockPointCondition ConditionAsICheckHookLockPointCondition()
		{
			return this.Condition<ICheckHookLockPointCondition>().Value;
		}

		// Token: 0x0602EF4F RID: 192335 RVA: 0x00665490 File Offset: 0x00663690
		public ICheckPlayerSkillReadyCondition ConditionAsICheckPlayerSkillReadyCondition()
		{
			return this.Condition<ICheckPlayerSkillReadyCondition>().Value;
		}

		// Token: 0x0602EF50 RID: 192336 RVA: 0x006654AC File Offset: 0x006636AC
		public ICheckPlayerUseSkillCondition ConditionAsICheckPlayerUseSkillCondition()
		{
			return this.Condition<ICheckPlayerUseSkillCondition>().Value;
		}

		// Token: 0x0602EF51 RID: 192337 RVA: 0x006654C8 File Offset: 0x006636C8
		public ICheckPlayerStateRestrictionCondition ConditionAsICheckPlayerStateRestrictionCondition()
		{
			return this.Condition<ICheckPlayerStateRestrictionCondition>().Value;
		}

		// Token: 0x0602EF52 RID: 192338 RVA: 0x006654E4 File Offset: 0x006636E4
		public ICheckLordGymFinishCondition ConditionAsICheckLordGymFinishCondition()
		{
			return this.Condition<ICheckLordGymFinishCondition>().Value;
		}

		// Token: 0x0602EF53 RID: 192339 RVA: 0x00665500 File Offset: 0x00663700
		public ICheckCalabashDevelopRewardCondition ConditionAsICheckCalabashDevelopRewardCondition()
		{
			return this.Condition<ICheckCalabashDevelopRewardCondition>().Value;
		}

		// Token: 0x0602EF54 RID: 192340 RVA: 0x0066551C File Offset: 0x0066371C
		public ICompareFishingPrestigeLevelCondition ConditionAsICompareFishingPrestigeLevelCondition()
		{
			return this.Condition<ICompareFishingPrestigeLevelCondition>().Value;
		}

		// Token: 0x0602EF55 RID: 192341 RVA: 0x00665538 File Offset: 0x00663738
		public ICheckCertainFishingItemCount ConditionAsICheckCertainFishingItemCount()
		{
			return this.Condition<ICheckCertainFishingItemCount>().Value;
		}

		// Token: 0x0602EF56 RID: 192342 RVA: 0x00665554 File Offset: 0x00663754
		public ICompleteCertainFishingEntrust ConditionAsICompleteCertainFishingEntrust()
		{
			return this.Condition<ICompleteCertainFishingEntrust>().Value;
		}

		// Token: 0x0602EF57 RID: 192343 RVA: 0x00665570 File Offset: 0x00663770
		public ICompareFishingBoatState ConditionAsICompareFishingBoatState()
		{
			return this.Condition<ICompareFishingBoatState>().Value;
		}

		// Token: 0x0602EF58 RID: 192344 RVA: 0x0066558C File Offset: 0x0066378C
		public ICheckJigsawInfoCondition ConditionAsICheckJigsawInfoCondition()
		{
			return this.Condition<ICheckJigsawInfoCondition>().Value;
		}

		// Token: 0x0602EF59 RID: 192345 RVA: 0x006655A8 File Offset: 0x006637A8
		public ICheckGameplayTagCondition ConditionAsICheckGameplayTagCondition()
		{
			return this.Condition<ICheckGameplayTagCondition>().Value;
		}

		// Token: 0x0602EF5A RID: 192346 RVA: 0x006655C4 File Offset: 0x006637C4
		public ICheckFormationRoleInfoCondition ConditionAsICheckFormationRoleInfoCondition()
		{
			return this.Condition<ICheckFormationRoleInfoCondition>().Value;
		}

		// Token: 0x0602EF5B RID: 192347 RVA: 0x006655E0 File Offset: 0x006637E0
		public ICheckTargetAttributeCondition ConditionAsICheckTargetAttributeCondition()
		{
			return this.Condition<ICheckTargetAttributeCondition>().Value;
		}

		// Token: 0x0602EF5C RID: 192348 RVA: 0x006655FC File Offset: 0x006637FC
		public ICheckRogueAbilitySelectCondition ConditionAsICheckRogueAbilitySelectCondition()
		{
			return this.Condition<ICheckRogueAbilitySelectCondition>().Value;
		}

		// Token: 0x0602EF5D RID: 192349 RVA: 0x00665618 File Offset: 0x00663818
		public ICheckDirectionCondition ConditionAsICheckDirectionCondition()
		{
			return this.Condition<ICheckDirectionCondition>().Value;
		}

		// Token: 0x0602EF5E RID: 192350 RVA: 0x00665634 File Offset: 0x00663834
		public ICheckSceneItemDirectionCondition ConditionAsICheckSceneItemDirectionCondition()
		{
			return this.Condition<ICheckSceneItemDirectionCondition>().Value;
		}

		// Token: 0x0602EF5F RID: 192351 RVA: 0x00665650 File Offset: 0x00663850
		public ICheckPlayerFaceToCondition ConditionAsICheckPlayerFaceToCondition()
		{
			return this.Condition<ICheckPlayerFaceToCondition>().Value;
		}

		// Token: 0x0602EF60 RID: 192352 RVA: 0x0066566C File Offset: 0x0066386C
		public ICheckPlayerCanJoinActivityCondition ConditionAsICheckPlayerCanJoinActivityCondition()
		{
			return this.Condition<ICheckPlayerCanJoinActivityCondition>().Value;
		}

		// Token: 0x0602EF61 RID: 192353 RVA: 0x00665688 File Offset: 0x00663888
		public ICheckSystemStateCondition ConditionAsICheckSystemStateCondition()
		{
			return this.Condition<ICheckSystemStateCondition>().Value;
		}

		// Token: 0x0602EF62 RID: 192354 RVA: 0x006656A4 File Offset: 0x006638A4
		public ICheckInRangeCondition ConditionAsICheckInRangeCondition()
		{
			return this.Condition<ICheckInRangeCondition>().Value;
		}

		// Token: 0x0602EF63 RID: 192355 RVA: 0x006656C0 File Offset: 0x006638C0
		public ICheckInRangeProperlyCondition ConditionAsICheckInRangeProperlyCondition()
		{
			return this.Condition<ICheckInRangeProperlyCondition>().Value;
		}

		// Token: 0x0602EF64 RID: 192356 RVA: 0x006656DC File Offset: 0x006638DC
		public ICheckEntityLockedCondition ConditionAsICheckEntityLockedCondition()
		{
			return this.Condition<ICheckEntityLockedCondition>().Value;
		}

		// Token: 0x0602EF65 RID: 192357 RVA: 0x006656F8 File Offset: 0x006638F8
		public ICompareTeammateDieCondition ConditionAsICompareTeammateDieCondition()
		{
			return this.Condition<ICompareTeammateDieCondition>().Value;
		}

		// Token: 0x0602EF66 RID: 192358 RVA: 0x00665714 File Offset: 0x00663914
		public IListenEntitySelfEventCondition ConditionAsIListenEntitySelfEventCondition()
		{
			return this.Condition<IListenEntitySelfEventCondition>().Value;
		}

		// Token: 0x0602EF67 RID: 192359 RVA: 0x00665730 File Offset: 0x00663930
		public ICheckEntityDistanceCondition ConditionAsICheckEntityDistanceCondition()
		{
			return this.Condition<ICheckEntityDistanceCondition>().Value;
		}

		// Token: 0x0602EF68 RID: 192360 RVA: 0x0066574C File Offset: 0x0066394C
		public ICheckEntityHasSceneItemAttributeTag ConditionAsICheckEntityHasSceneItemAttributeTag()
		{
			return this.Condition<ICheckEntityHasSceneItemAttributeTag>().Value;
		}

		// Token: 0x0602EF69 RID: 192361 RVA: 0x00665768 File Offset: 0x00663968
		public IListenEntityThroughPortal ConditionAsIListenEntityThroughPortal()
		{
			return this.Condition<IListenEntityThroughPortal>().Value;
		}

		// Token: 0x0602EF6A RID: 192362 RVA: 0x00665784 File Offset: 0x00663984
		public ICheckTeleControlState ConditionAsICheckTeleControlState()
		{
			return this.Condition<ICheckTeleControlState>().Value;
		}

		// Token: 0x0602EF6B RID: 192363 RVA: 0x006657A0 File Offset: 0x006639A0
		public ICustomJsonCondition ConditionAsICustomJsonCondition()
		{
			return this.Condition<ICustomJsonCondition>().Value;
		}

		// Token: 0x0602EF6C RID: 192364 RVA: 0x006657BC File Offset: 0x006639BC
		public ICheckChessWinner ConditionAsICheckChessWinner()
		{
			return this.Condition<ICheckChessWinner>().Value;
		}

		// Token: 0x0602EF6D RID: 192365 RVA: 0x006657D8 File Offset: 0x006639D8
		public ICheckVehicleCondition ConditionAsICheckVehicleCondition()
		{
			return this.Condition<ICheckVehicleCondition>().Value;
		}

		// Token: 0x0602EF6E RID: 192366 RVA: 0x006657F4 File Offset: 0x006639F4
		public ICheckMechState ConditionAsICheckMechState()
		{
			return this.Condition<ICheckMechState>().Value;
		}

		// Token: 0x0602EF6F RID: 192367 RVA: 0x00665810 File Offset: 0x00663A10
		public ICheckExploreSkillState ConditionAsICheckExploreSkillState()
		{
			return this.Condition<ICheckExploreSkillState>().Value;
		}

		// Token: 0x0602EF70 RID: 192368 RVA: 0x0066582C File Offset: 0x00663A2C
		public ICompareAlertValue ConditionAsICompareAlertValue()
		{
			return this.Condition<ICompareAlertValue>().Value;
		}

		// Token: 0x0602EF71 RID: 192369 RVA: 0x00665848 File Offset: 0x00663A48
		public ICheckEntityGravityDirection ConditionAsICheckEntityGravityDirection()
		{
			return this.Condition<ICheckEntityGravityDirection>().Value;
		}

		// Token: 0x0602EF72 RID: 192370 RVA: 0x00665864 File Offset: 0x00663A64
		public ICheckCollectAnimalParts ConditionAsICheckCollectAnimalParts()
		{
			return this.Condition<ICheckCollectAnimalParts>().Value;
		}

		// Token: 0x0602EF73 RID: 192371 RVA: 0x00665880 File Offset: 0x00663A80
		public ICheckPreloadComplete ConditionAsICheckPreloadComplete()
		{
			return this.Condition<ICheckPreloadComplete>().Value;
		}

		// Token: 0x0602EF74 RID: 192372 RVA: 0x0066589C File Offset: 0x00663A9C
		public ICheckFinishLoading ConditionAsICheckFinishLoading()
		{
			return this.Condition<ICheckFinishLoading>().Value;
		}

		// Token: 0x0602EF75 RID: 192373 RVA: 0x006658B8 File Offset: 0x00663AB8
		public ICheckFishingPointHasFish ConditionAsICheckFishingPointHasFish()
		{
			return this.Condition<ICheckFishingPointHasFish>().Value;
		}

		// Token: 0x0602EF76 RID: 192374 RVA: 0x006658D4 File Offset: 0x00663AD4
		public ICheckFishingCageFillingRatio ConditionAsICheckFishingCageFillingRatio()
		{
			return this.Condition<ICheckFishingCageFillingRatio>().Value;
		}

		// Token: 0x0602EF77 RID: 192375 RVA: 0x006658F0 File Offset: 0x00663AF0
		public ICompareFishingTechLevel ConditionAsICompareFishingTechLevel()
		{
			return this.Condition<ICompareFishingTechLevel>().Value;
		}

		// Token: 0x0602EF78 RID: 192376 RVA: 0x0066590C File Offset: 0x00663B0C
		public ICheckGuestCharacter ConditionAsICheckGuestCharacter()
		{
			return this.Condition<ICheckGuestCharacter>().Value;
		}

		// Token: 0x0602EF79 RID: 192377 RVA: 0x00665928 File Offset: 0x00663B28
		public ICheckSubLevelState ConditionAsICheckSubLevelState()
		{
			return this.Condition<ICheckSubLevelState>().Value;
		}

		// Token: 0x0602EF7A RID: 192378 RVA: 0x00665944 File Offset: 0x00663B44
		public IComparePlayerNumInDungeon ConditionAsIComparePlayerNumInDungeon()
		{
			return this.Condition<IComparePlayerNumInDungeon>().Value;
		}

		// Token: 0x0602EF7B RID: 192379 RVA: 0x00665960 File Offset: 0x00663B60
		public ICheckAlertAreaEnabled ConditionAsICheckAlertAreaEnabled()
		{
			return this.Condition<ICheckAlertAreaEnabled>().Value;
		}

		// Token: 0x0602EF7C RID: 192380 RVA: 0x0066597C File Offset: 0x00663B7C
		public ICheckClientEvent ConditionAsICheckClientEvent()
		{
			return this.Condition<ICheckClientEvent>().Value;
		}

		// Token: 0x0602EF7D RID: 192381 RVA: 0x00665998 File Offset: 0x00663B98
		public ICheckIsGramophonePlayingMusic ConditionAsICheckIsGramophonePlayingMusic()
		{
			return this.Condition<ICheckIsGramophonePlayingMusic>().Value;
		}

		// Token: 0x0602EF7E RID: 192382 RVA: 0x006659B4 File Offset: 0x00663BB4
		public ICheckEntityReward ConditionAsICheckEntityReward()
		{
			return this.Condition<ICheckEntityReward>().Value;
		}

		// Token: 0x0602EF7F RID: 192383 RVA: 0x006659D0 File Offset: 0x00663BD0
		public ICheckDungeonHasSaveConfig ConditionAsICheckDungeonHasSaveConfig()
		{
			return this.Condition<ICheckDungeonHasSaveConfig>().Value;
		}

		// Token: 0x0602EF80 RID: 192384 RVA: 0x006659EC File Offset: 0x00663BEC
		public ICheckSystemEventBvb ConditionAsICheckSystemEventBvb()
		{
			return this.Condition<ICheckSystemEventBvb>().Value;
		}

		// Token: 0x0602EF81 RID: 192385 RVA: 0x00665A08 File Offset: 0x00663C08
		public ICheckDangoCultivationProgress ConditionAsICheckDangoCultivationProgress()
		{
			return this.Condition<ICheckDangoCultivationProgress>().Value;
		}

		// Token: 0x0602EF82 RID: 192386 RVA: 0x00665A24 File Offset: 0x00663C24
		public ICheckPlayerMoraleLevelRange ConditionAsICheckPlayerMoraleLevelRange()
		{
			return this.Condition<ICheckPlayerMoraleLevelRange>().Value;
		}

		// Token: 0x0602EF83 RID: 192387 RVA: 0x00665A40 File Offset: 0x00663C40
		public ICheckIsGlobalTimeScaleEnabled ConditionAsICheckIsGlobalTimeScaleEnabled()
		{
			return this.Condition<ICheckIsGlobalTimeScaleEnabled>().Value;
		}

		// Token: 0x0602EF84 RID: 192388 RVA: 0x00665A5C File Offset: 0x00663C5C
		public ISaveConfigEnterMethod ConditionAsISaveConfigEnterMethod()
		{
			return this.Condition<ISaveConfigEnterMethod>().Value;
		}

		// Token: 0x0602EF85 RID: 192389 RVA: 0x00665A78 File Offset: 0x00663C78
		public ICheckIsEntityTimeScaleEnabled ConditionAsICheckIsEntityTimeScaleEnabled()
		{
			return this.Condition<ICheckIsEntityTimeScaleEnabled>().Value;
		}

		// Token: 0x0602EF86 RID: 192390 RVA: 0x00665A94 File Offset: 0x00663C94
		public ICheckIsCharacterHoldingHands ConditionAsICheckIsCharacterHoldingHands()
		{
			return this.Condition<ICheckIsCharacterHoldingHands>().Value;
		}

		// Token: 0x0602EF87 RID: 192391 RVA: 0x00665AB0 File Offset: 0x00663CB0
		public ICheckIsTrackingCurrentQuest ConditionAsICheckIsTrackingCurrentQuest()
		{
			return this.Condition<ICheckIsTrackingCurrentQuest>().Value;
		}

		// Token: 0x0602EF88 RID: 192392 RVA: 0x00665ACC File Offset: 0x00663CCC
		public ICheckIsTrackingQuest ConditionAsICheckIsTrackingQuest()
		{
			return this.Condition<ICheckIsTrackingQuest>().Value;
		}

		// Token: 0x0602EF89 RID: 192393 RVA: 0x00665AE8 File Offset: 0x00663CE8
		public ICheckMusicEvent ConditionAsICheckMusicEvent()
		{
			return this.Condition<ICheckMusicEvent>().Value;
		}

		// Token: 0x0602EF8A RID: 192394 RVA: 0x00665B04 File Offset: 0x00663D04
		public ICompareGameDifficulty ConditionAsICompareGameDifficulty()
		{
			return this.Condition<ICompareGameDifficulty>().Value;
		}

		// Token: 0x0602EF8B RID: 192395 RVA: 0x00665B20 File Offset: 0x00663D20
		public ICheckPhotographCameraParam ConditionAsICheckPhotographCameraParam()
		{
			return this.Condition<ICheckPhotographCameraParam>().Value;
		}

		// Token: 0x0602EF8C RID: 192396 RVA: 0x00665B3C File Offset: 0x00663D3C
		public ICheckEntityHasBuff ConditionAsICheckEntityHasBuff()
		{
			return this.Condition<ICheckEntityHasBuff>().Value;
		}

		// Token: 0x0602EF8D RID: 192397 RVA: 0x00665B58 File Offset: 0x00663D58
		public ICheckEntityBuffStack ConditionAsICheckEntityBuffStack()
		{
			return this.Condition<ICheckEntityBuffStack>().Value;
		}

		// Token: 0x0602EF8E RID: 192398 RVA: 0x00665B74 File Offset: 0x00663D74
		public ICheckAvailableSunSpiritCount ConditionAsICheckAvailableSunSpiritCount()
		{
			return this.Condition<ICheckAvailableSunSpiritCount>().Value;
		}

		// Token: 0x0602EF8F RID: 192399 RVA: 0x00665B90 File Offset: 0x00663D90
		public ICheckPlayerEnterClientTriggerDir ConditionAsICheckPlayerEnterClientTriggerDir()
		{
			return this.Condition<ICheckPlayerEnterClientTriggerDir>().Value;
		}

		// Token: 0x0602EF90 RID: 192400 RVA: 0x00665BAC File Offset: 0x00663DAC
		public ICheckPlayerRelativeDistance ConditionAsICheckPlayerRelativeDistance()
		{
			return this.Condition<ICheckPlayerRelativeDistance>().Value;
		}

		// Token: 0x0602EF91 RID: 192401 RVA: 0x00665BC8 File Offset: 0x00663DC8
		public ICheckPlayerRelativeAngle ConditionAsICheckPlayerRelativeAngle()
		{
			return this.Condition<ICheckPlayerRelativeAngle>().Value;
		}

		// Token: 0x0602EF92 RID: 192402 RVA: 0x00665BE4 File Offset: 0x00663DE4
		public ICheckHonamiStoryGetItem ConditionAsICheckHonamiStoryGetItem()
		{
			return this.Condition<ICheckHonamiStoryGetItem>().Value;
		}

		// Token: 0x0602EF93 RID: 192403 RVA: 0x00665C00 File Offset: 0x00663E00
		public ICheckHonamiStoryEquipItem ConditionAsICheckHonamiStoryEquipItem()
		{
			return this.Condition<ICheckHonamiStoryEquipItem>().Value;
		}

		// Token: 0x0602EF94 RID: 192404 RVA: 0x00665C1C File Offset: 0x00663E1C
		public ICheckHonamiStoryActivateTalent ConditionAsICheckHonamiStoryActivateTalent()
		{
			return this.Condition<ICheckHonamiStoryActivateTalent>().Value;
		}

		// Token: 0x0602EF95 RID: 192405 RVA: 0x00665C38 File Offset: 0x00663E38
		public ICheckHonamiStoryUnlockSlot ConditionAsICheckHonamiStoryUnlockSlot()
		{
			return this.Condition<ICheckHonamiStoryUnlockSlot>().Value;
		}

		// Token: 0x0602EF96 RID: 192406 RVA: 0x00665C54 File Offset: 0x00663E54
		public ICheckHonamiStoryLifeSupportLevel ConditionAsICheckHonamiStoryLifeSupportLevel()
		{
			return this.Condition<ICheckHonamiStoryLifeSupportLevel>().Value;
		}

		// Token: 0x0602EF97 RID: 192407 RVA: 0x00665C70 File Offset: 0x00663E70
		public ICheckHonamiStoryTowerComplete ConditionAsICheckHonamiStoryTowerComplete()
		{
			return this.Condition<ICheckHonamiStoryTowerComplete>().Value;
		}

		// Token: 0x0602EF98 RID: 192408 RVA: 0x00665C8C File Offset: 0x00663E8C
		public ICheckHonamiStoryPlayerCorruptedLevel ConditionAsICheckHonamiStoryPlayerCorruptedLevel()
		{
			return this.Condition<ICheckHonamiStoryPlayerCorruptedLevel>().Value;
		}

		// Token: 0x0602EF99 RID: 192409 RVA: 0x00665CA8 File Offset: 0x00663EA8
		public ICheckHonamiStoryUnlockMascot ConditionAsICheckHonamiStoryUnlockMascot()
		{
			return this.Condition<ICheckHonamiStoryUnlockMascot>().Value;
		}

		// Token: 0x0602EF9A RID: 192410 RVA: 0x00665CC4 File Offset: 0x00663EC4
		public ICheckHonamiStoryChestOpenTime ConditionAsICheckHonamiStoryChestOpenTime()
		{
			return this.Condition<ICheckHonamiStoryChestOpenTime>().Value;
		}

		// Token: 0x0602EF9B RID: 192411 RVA: 0x00665CE0 File Offset: 0x00663EE0
		public ICheckHonamiStorySuccessfulEvacuation ConditionAsICheckHonamiStorySuccessfulEvacuation()
		{
			return this.Condition<ICheckHonamiStorySuccessfulEvacuation>().Value;
		}

		// Token: 0x0602EF9C RID: 192412 RVA: 0x00665CFC File Offset: 0x00663EFC
		public ICheckBvbChallengeState ConditionAsICheckBvbChallengeState()
		{
			return this.Condition<ICheckBvbChallengeState>().Value;
		}

		// Token: 0x0602EF9D RID: 192413 RVA: 0x00665D18 File Offset: 0x00663F18
		public ICheckBvbActivityRank ConditionAsICheckBvbActivityRank()
		{
			return this.Condition<ICheckBvbActivityRank>().Value;
		}

		// Token: 0x0602EF9E RID: 192414 RVA: 0x00665D34 File Offset: 0x00663F34
		public ICheckDiceGameChallengeState ConditionAsICheckDiceGameChallengeState()
		{
			return this.Condition<ICheckDiceGameChallengeState>().Value;
		}

		// Token: 0x0602EF9F RID: 192415 RVA: 0x00665D50 File Offset: 0x00663F50
		public ICompareDiceGameRankLevel ConditionAsICompareDiceGameRankLevel()
		{
			return this.Condition<ICompareDiceGameRankLevel>().Value;
		}

		// Token: 0x0602EFA0 RID: 192416 RVA: 0x00665D6C File Offset: 0x00663F6C
		public ICheckCollectedSunSpiritCount ConditionAsICheckCollectedSunSpiritCount()
		{
			return this.Condition<ICheckCollectedSunSpiritCount>().Value;
		}

		// Token: 0x0602EFA1 RID: 192417 RVA: 0x00665D88 File Offset: 0x00663F88
		public ICheckTargetSunSpiritCollected ConditionAsICheckTargetSunSpiritCollected()
		{
			return this.Condition<ICheckTargetSunSpiritCollected>().Value;
		}

		// Token: 0x0602EFA2 RID: 192418 RVA: 0x00665DA4 File Offset: 0x00663FA4
		public ICheckPlayerIsInDeadEyeProcess ConditionAsICheckPlayerIsInDeadEyeProcess()
		{
			return this.Condition<ICheckPlayerIsInDeadEyeProcess>().Value;
		}

		// Token: 0x0602EFA3 RID: 192419 RVA: 0x00665DC0 File Offset: 0x00663FC0
		public ICheckEntitySelfDirection ConditionAsICheckEntitySelfDirection()
		{
			return this.Condition<ICheckEntitySelfDirection>().Value;
		}

		// Token: 0x0602EFA4 RID: 192420 RVA: 0x00665DDC File Offset: 0x00663FDC
		public ICheckDollGrabItemComboAchievedInOnceDelivery ConditionAsICheckDollGrabItemComboAchievedInOnceDelivery()
		{
			return this.Condition<ICheckDollGrabItemComboAchievedInOnceDelivery>().Value;
		}

		// Token: 0x0602EFA5 RID: 192421 RVA: 0x00665DF8 File Offset: 0x00663FF8
		public ICheckDollGrabShowcaseItemComboAchieved ConditionAsICheckDollGrabShowcaseItemComboAchieved()
		{
			return this.Condition<ICheckDollGrabShowcaseItemComboAchieved>().Value;
		}

		// Token: 0x0602EFA6 RID: 192422 RVA: 0x00665E14 File Offset: 0x00664014
		public ICheckRoverRogueAbilitySelectCondition ConditionAsICheckRoverRogueAbilitySelectCondition()
		{
			return this.Condition<ICheckRoverRogueAbilitySelectCondition>().Value;
		}

		// Token: 0x0602EFA7 RID: 192423 RVA: 0x00665E30 File Offset: 0x00664030
		public ICheckDollGrabMachineFinished ConditionAsICheckDollGrabMachineFinished()
		{
			return this.Condition<ICheckDollGrabMachineFinished>().Value;
		}

		// Token: 0x0602EFA8 RID: 192424 RVA: 0x00665E4C File Offset: 0x0066404C
		public ICheckTrafficBlocked ConditionAsICheckTrafficBlocked()
		{
			return this.Condition<ICheckTrafficBlocked>().Value;
		}

		// Token: 0x0602EFA9 RID: 192425 RVA: 0x00665E68 File Offset: 0x00664068
		public ICheckDrinksPreferenceLevel ConditionAsICheckDrinksPreferenceLevel()
		{
			return this.Condition<ICheckDrinksPreferenceLevel>().Value;
		}

		// Token: 0x0602EFAA RID: 192426 RVA: 0x00665E84 File Offset: 0x00664084
		public ICheckPlayerIsInMotorcycleCruise ConditionAsICheckPlayerIsInMotorcycleCruise()
		{
			return this.Condition<ICheckPlayerIsInMotorcycleCruise>().Value;
		}

		// Token: 0x0602EFAB RID: 192427 RVA: 0x00665EA0 File Offset: 0x006640A0
		public ICheckPlayerIsControlledByAi ConditionAsICheckPlayerIsControlledByAi()
		{
			return this.Condition<ICheckPlayerIsControlledByAi>().Value;
		}

		// Token: 0x0602EFAC RID: 192428 RVA: 0x00665EBC File Offset: 0x006640BC
		public ICheckTetrisEndlessScore ConditionAsICheckTetrisEndlessScore()
		{
			return this.Condition<ICheckTetrisEndlessScore>().Value;
		}

		// Token: 0x0602EFAD RID: 192429 RVA: 0x00665ED8 File Offset: 0x006640D8
		public ICheckDartLevelComplete ConditionAsICheckDartLevelComplete()
		{
			return this.Condition<ICheckDartLevelComplete>().Value;
		}

		// Token: 0x0602EFAE RID: 192430 RVA: 0x00665EF4 File Offset: 0x006640F4
		public ICheckAtlasUnlocked ConditionAsICheckAtlasUnlocked()
		{
			return this.Condition<ICheckAtlasUnlocked>().Value;
		}

		// Token: 0x0602EFAF RID: 192431 RVA: 0x00665F10 File Offset: 0x00664110
		public ICheckSheriffUnlockEnding ConditionAsICheckSheriffUnlockEnding()
		{
			return this.Condition<ICheckSheriffUnlockEnding>().Value;
		}

		// Token: 0x0602EFB0 RID: 192432 RVA: 0x00665F2C File Offset: 0x0066412C
		public ICheckIsInDragActorPlay ConditionAsICheckIsInDragActorPlay()
		{
			return this.Condition<ICheckIsInDragActorPlay>().Value;
		}

		// Token: 0x0602EFB1 RID: 192433 RVA: 0x00665F48 File Offset: 0x00664148
		public ICheckIsInDollGrabGamePlay ConditionAsICheckIsInDollGrabGamePlay()
		{
			return this.Condition<ICheckIsInDollGrabGamePlay>().Value;
		}

		// Token: 0x0602EFB2 RID: 192434 RVA: 0x00665F64 File Offset: 0x00664164
		public ICheckIsInDartGameplay ConditionAsICheckIsInDartGameplay()
		{
			return this.Condition<ICheckIsInDartGameplay>().Value;
		}

		// Token: 0x0602EFB3 RID: 192435 RVA: 0x00665F80 File Offset: 0x00664180
		public ICheckIsInRideFlyingCarGameplay ConditionAsICheckIsInRideFlyingCarGameplay()
		{
			return this.Condition<ICheckIsInRideFlyingCarGameplay>().Value;
		}

		// Token: 0x0602EFB4 RID: 192436 RVA: 0x00665F9C File Offset: 0x0066419C
		public ICheckEntityPrefabPerformanceType ConditionAsICheckEntityPrefabPerformanceType()
		{
			return this.Condition<ICheckEntityPrefabPerformanceType>().Value;
		}

		// Token: 0x0602EFB5 RID: 192437 RVA: 0x00665FB8 File Offset: 0x006641B8
		public ICheckIsSupportedWalking ConditionAsICheckIsSupportedWalking()
		{
			return this.Condition<ICheckIsSupportedWalking>().Value;
		}

		// Token: 0x0602EFB6 RID: 192438 RVA: 0x00665FD4 File Offset: 0x006641D4
		public ICheckGiantStableValue ConditionAsICheckGiantStableValue()
		{
			return this.Condition<ICheckGiantStableValue>().Value;
		}

		// Token: 0x0602EFB7 RID: 192439 RVA: 0x00665FF0 File Offset: 0x006641F0
		public ICheckGiantTotalProgressCanActivateNode ConditionAsICheckGiantTotalProgressCanActivateNode()
		{
			return this.Condition<ICheckGiantTotalProgressCanActivateNode>().Value;
		}

		// Token: 0x0602EFB8 RID: 192440 RVA: 0x0066600C File Offset: 0x0066420C
		public ICheckGiantTotalProgressInteractActivatedNode ConditionAsICheckGiantTotalProgressInteractActivatedNode()
		{
			return this.Condition<ICheckGiantTotalProgressInteractActivatedNode>().Value;
		}

		// Token: 0x0602EFB9 RID: 192441 RVA: 0x00666028 File Offset: 0x00664228
		public ICheckGiantRegionCultivationTriggeredUpgradeLevel ConditionAsICheckGiantRegionCultivationTriggeredUpgradeLevel()
		{
			return this.Condition<ICheckGiantRegionCultivationTriggeredUpgradeLevel>().Value;
		}

		// Token: 0x0602EFBA RID: 192442 RVA: 0x00666044 File Offset: 0x00664244
		public ICheckElementalBoxState ConditionAsICheckElementalBoxState()
		{
			return this.Condition<ICheckElementalBoxState>().Value;
		}

		// Token: 0x0602EFBB RID: 192443 RVA: 0x00666060 File Offset: 0x00664260
		public ICheckIsTargetHoldElementalBox ConditionAsICheckIsTargetHoldElementalBox()
		{
			return this.Condition<ICheckIsTargetHoldElementalBox>().Value;
		}

		// Token: 0x0602EFBC RID: 192444 RVA: 0x0066607C File Offset: 0x0066427C
		public ICheckElementalEffectActive ConditionAsICheckElementalEffectActive()
		{
			return this.Condition<ICheckElementalEffectActive>().Value;
		}

		// Token: 0x0602EFBD RID: 192445 RVA: 0x00666098 File Offset: 0x00664298
		public ICheckElementalWaterBoxStagnationSeq ConditionAsICheckElementalWaterBoxStagnationSeq()
		{
			return this.Condition<ICheckElementalWaterBoxStagnationSeq>().Value;
		}

		// Token: 0x0602EFBE RID: 192446 RVA: 0x006660B4 File Offset: 0x006642B4
		public ICompareSeasonAndWeather ConditionAsICompareSeasonAndWeather()
		{
			return this.Condition<ICompareSeasonAndWeather>().Value;
		}

		// Token: 0x0602EFBF RID: 192447 RVA: 0x006660D0 File Offset: 0x006642D0
		public ICheckIsSpecialWeatherUnlocked ConditionAsICheckIsSpecialWeatherUnlocked()
		{
			return this.Condition<ICheckIsSpecialWeatherUnlocked>().Value;
		}

		// Token: 0x0602EFC0 RID: 192448 RVA: 0x006660EC File Offset: 0x006642EC
		public ICheckCollectiblesDetectionAllowed ConditionAsICheckCollectiblesDetectionAllowed()
		{
			return this.Condition<ICheckCollectiblesDetectionAllowed>().Value;
		}

		// Token: 0x0602EFC1 RID: 192449 RVA: 0x00666107 File Offset: 0x00664307
		public static Offset<ICommonBtOverrideConditionInfo> CreateICommonBtOverrideConditionInfo(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType Type = ECommonBtPlaceholderTargetType.Action, ICondition2_Union Condition_type = ICondition2_Union.NONE, int ConditionOffset = 0)
		{
			builder.StartTable(3);
			ICommonBtOverrideConditionInfo.AddCondition(builder, ConditionOffset);
			ICommonBtOverrideConditionInfo.AddConditionType(builder, Condition_type);
			ICommonBtOverrideConditionInfo.AddType(builder, Type);
			return ICommonBtOverrideConditionInfo.EndICommonBtOverrideConditionInfo(builder);
		}

		// Token: 0x0602EFC2 RID: 192450 RVA: 0x0066612B File Offset: 0x0066432B
		public static void StartICommonBtOverrideConditionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EFC3 RID: 192451 RVA: 0x00666134 File Offset: 0x00664334
		public static void AddType(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EFC4 RID: 192452 RVA: 0x0066613F File Offset: 0x0066433F
		public static void AddConditionType(FlatBufferBuilder builder, ICondition2_Union conditionType)
		{
			builder.AddByte(1, (byte)conditionType, 0);
		}

		// Token: 0x0602EFC5 RID: 192453 RVA: 0x0066614A File Offset: 0x0066434A
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(2, conditionOffset, 0);
		}

		// Token: 0x0602EFC6 RID: 192454 RVA: 0x00666155 File Offset: 0x00664355
		public static Offset<ICommonBtOverrideConditionInfo> EndICommonBtOverrideConditionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtOverrideConditionInfo>(builder.EndTable());
		}

		// Token: 0x0602EFC7 RID: 192455 RVA: 0x00666164 File Offset: 0x00664364
		public ICommonBtOverrideConditionInfoT UnPack()
		{
			ICommonBtOverrideConditionInfoT commonBtOverrideConditionInfoT = new ICommonBtOverrideConditionInfoT();
			this.UnPackTo(commonBtOverrideConditionInfoT);
			return commonBtOverrideConditionInfoT;
		}

		// Token: 0x0602EFC8 RID: 192456 RVA: 0x00666180 File Offset: 0x00664380
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
			case ICondition2_Union.ICheckMechState:
				_o.Condition.Value = ((this.Condition<ICheckMechState>() != null) ? this.Condition<ICheckMechState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckExploreSkillState:
				_o.Condition.Value = ((this.Condition<ICheckExploreSkillState>() != null) ? this.Condition<ICheckExploreSkillState>().Value.UnPack() : null);
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
			case ICondition2_Union.ICheckPreloadComplete:
				_o.Condition.Value = ((this.Condition<ICheckPreloadComplete>() != null) ? this.Condition<ICheckPreloadComplete>().Value.UnPack() : null);
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
			case ICondition2_Union.ICheckDiceGameChallengeState:
				_o.Condition.Value = ((this.Condition<ICheckDiceGameChallengeState>() != null) ? this.Condition<ICheckDiceGameChallengeState>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICompareDiceGameRankLevel:
				_o.Condition.Value = ((this.Condition<ICompareDiceGameRankLevel>() != null) ? this.Condition<ICompareDiceGameRankLevel>().Value.UnPack() : null);
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
			case ICondition2_Union.ICheckPlayerIsControlledByAi:
				_o.Condition.Value = ((this.Condition<ICheckPlayerIsControlledByAi>() != null) ? this.Condition<ICheckPlayerIsControlledByAi>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckTetrisEndlessScore:
				_o.Condition.Value = ((this.Condition<ICheckTetrisEndlessScore>() != null) ? this.Condition<ICheckTetrisEndlessScore>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckDartLevelComplete:
				_o.Condition.Value = ((this.Condition<ICheckDartLevelComplete>() != null) ? this.Condition<ICheckDartLevelComplete>().Value.UnPack() : null);
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
			case ICondition2_Union.ICheckIsInDartGameplay:
				_o.Condition.Value = ((this.Condition<ICheckIsInDartGameplay>() != null) ? this.Condition<ICheckIsInDartGameplay>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsInRideFlyingCarGameplay:
				_o.Condition.Value = ((this.Condition<ICheckIsInRideFlyingCarGameplay>() != null) ? this.Condition<ICheckIsInRideFlyingCarGameplay>().Value.UnPack() : null);
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
			case ICondition2_Union.ICompareSeasonAndWeather:
				_o.Condition.Value = ((this.Condition<ICompareSeasonAndWeather>() != null) ? this.Condition<ICompareSeasonAndWeather>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckIsSpecialWeatherUnlocked:
				_o.Condition.Value = ((this.Condition<ICheckIsSpecialWeatherUnlocked>() != null) ? this.Condition<ICheckIsSpecialWeatherUnlocked>().Value.UnPack() : null);
				return;
			case ICondition2_Union.ICheckCollectiblesDetectionAllowed:
				_o.Condition.Value = ((this.Condition<ICheckCollectiblesDetectionAllowed>() != null) ? this.Condition<ICheckCollectiblesDetectionAllowed>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602EFC9 RID: 192457 RVA: 0x0066895C File Offset: 0x00666B5C
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

		// Token: 0x04011874 RID: 71796
		private Table __p;
	}
}
