using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F1 RID: 25841
	public struct ICommonBtConditionInfo : IFlatbufferObject
	{
		// Token: 0x1700BE8A RID: 48778
		// (get) Token: 0x0602BF10 RID: 179984 RVA: 0x005F96AC File Offset: 0x005F78AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BF11 RID: 179985 RVA: 0x005F96B9 File Offset: 0x005F78B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BF12 RID: 179986 RVA: 0x005F96C0 File Offset: 0x005F78C0
		public static ICommonBtConditionInfo GetRootAsICommonBtConditionInfo(ByteBuffer _bb)
		{
			return ICommonBtConditionInfo.GetRootAsICommonBtConditionInfo(_bb, default(ICommonBtConditionInfo));
		}

		// Token: 0x0602BF13 RID: 179987 RVA: 0x005F96DC File Offset: 0x005F78DC
		public static ICommonBtConditionInfo GetRootAsICommonBtConditionInfo(ByteBuffer _bb, ICommonBtConditionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BF14 RID: 179988 RVA: 0x005F96F9 File Offset: 0x005F78F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BF15 RID: 179989 RVA: 0x005F9708 File Offset: 0x005F7908
		public ICommonBtConditionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE8B RID: 48779
		// (get) Token: 0x0602BF16 RID: 179990 RVA: 0x005F9718 File Offset: 0x005F7918
		public int TaskId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE8C RID: 48780
		// (get) Token: 0x0602BF17 RID: 179991 RVA: 0x005F9754 File Offset: 0x005F7954
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

		// Token: 0x0602BF18 RID: 179992 RVA: 0x005F9790 File Offset: 0x005F7990
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BF19 RID: 179993 RVA: 0x005F97D4 File Offset: 0x005F79D4
		public ICondition2 ConditionAsICondition2()
		{
			return this.Condition<ICondition2>().Value;
		}

		// Token: 0x0602BF1A RID: 179994 RVA: 0x005F97F0 File Offset: 0x005F79F0
		public ICompareVarCondition ConditionAsICompareVarCondition()
		{
			return this.Condition<ICompareVarCondition>().Value;
		}

		// Token: 0x0602BF1B RID: 179995 RVA: 0x005F980C File Offset: 0x005F7A0C
		public IQuestStateEqualCondition ConditionAsIQuestStateEqualCondition()
		{
			return this.Condition<IQuestStateEqualCondition>().Value;
		}

		// Token: 0x0602BF1C RID: 179996 RVA: 0x005F9828 File Offset: 0x005F7A28
		public ICompareExploreLevelCondition ConditionAsICompareExploreLevelCondition()
		{
			return this.Condition<ICompareExploreLevelCondition>().Value;
		}

		// Token: 0x0602BF1D RID: 179997 RVA: 0x005F9844 File Offset: 0x005F7A44
		public ICompareCalabashLevelCondition ConditionAsICompareCalabashLevelCondition()
		{
			return this.Condition<ICompareCalabashLevelCondition>().Value;
		}

		// Token: 0x0602BF1E RID: 179998 RVA: 0x005F9860 File Offset: 0x005F7A60
		public ICompareLiftCondition ConditionAsICompareLiftCondition()
		{
			return this.Condition<ICompareLiftCondition>().Value;
		}

		// Token: 0x0602BF1F RID: 179999 RVA: 0x005F987C File Offset: 0x005F7A7C
		public ICompareEntityStateCondition ConditionAsICompareEntityStateCondition()
		{
			return this.Condition<ICompareEntityStateCondition>().Value;
		}

		// Token: 0x0602BF20 RID: 180000 RVA: 0x005F9898 File Offset: 0x005F7A98
		public ICompareNpcPerformStateCondition ConditionAsICompareNpcPerformStateCondition()
		{
			return this.Condition<ICompareNpcPerformStateCondition>().Value;
		}

		// Token: 0x0602BF21 RID: 180001 RVA: 0x005F98B4 File Offset: 0x005F7AB4
		public ICheckTreasureBeenClaimedCondition ConditionAsICheckTreasureBeenClaimedCondition()
		{
			return this.Condition<ICheckTreasureBeenClaimedCondition>().Value;
		}

		// Token: 0x0602BF22 RID: 180002 RVA: 0x005F98D0 File Offset: 0x005F7AD0
		public ICompareEntityGroupStateCondition ConditionAsICompareEntityGroupStateCondition()
		{
			return this.Condition<ICompareEntityGroupStateCondition>().Value;
		}

		// Token: 0x0602BF23 RID: 180003 RVA: 0x005F98EC File Offset: 0x005F7AEC
		public ICompareEntitySelfStateCondition ConditionAsICompareEntitySelfStateCondition()
		{
			return this.Condition<ICompareEntitySelfStateCondition>().Value;
		}

		// Token: 0x0602BF24 RID: 180004 RVA: 0x005F9908 File Offset: 0x005F7B08
		public ICompareLevelPlayRewardStateCondition ConditionAsICompareLevelPlayRewardStateCondition()
		{
			return this.Condition<ICompareLevelPlayRewardStateCondition>().Value;
		}

		// Token: 0x0602BF25 RID: 180005 RVA: 0x005F9924 File Offset: 0x005F7B24
		public IHourToHourCondition ConditionAsIHourToHourCondition()
		{
			return this.Condition<IHourToHourCondition>().Value;
		}

		// Token: 0x0602BF26 RID: 180006 RVA: 0x005F9940 File Offset: 0x005F7B40
		public IRangeSphere ConditionAsIRangeSphere()
		{
			return this.Condition<IRangeSphere>().Value;
		}

		// Token: 0x0602BF27 RID: 180007 RVA: 0x005F995C File Offset: 0x005F7B5C
		public ICheckItems ConditionAsICheckItems()
		{
			return this.Condition<ICheckItems>().Value;
		}

		// Token: 0x0602BF28 RID: 180008 RVA: 0x005F9978 File Offset: 0x005F7B78
		public IHasBuff ConditionAsIHasBuff()
		{
			return this.Condition<IHasBuff>().Value;
		}

		// Token: 0x0602BF29 RID: 180009 RVA: 0x005F9994 File Offset: 0x005F7B94
		public ICheckSystemFunction ConditionAsICheckSystemFunction()
		{
			return this.Condition<ICheckSystemFunction>().Value;
		}

		// Token: 0x0602BF2A RID: 180010 RVA: 0x005F99B0 File Offset: 0x005F7BB0
		public ICheckAiState ConditionAsICheckAiState()
		{
			return this.Condition<ICheckAiState>().Value;
		}

		// Token: 0x0602BF2B RID: 180011 RVA: 0x005F99CC File Offset: 0x005F7BCC
		public ICompareDungeonId ConditionAsICompareDungeonId()
		{
			return this.Condition<ICompareDungeonId>().Value;
		}

		// Token: 0x0602BF2C RID: 180012 RVA: 0x005F99E8 File Offset: 0x005F7BE8
		public ICompareTimePeriod ConditionAsICompareTimePeriod()
		{
			return this.Condition<ICompareTimePeriod>().Value;
		}

		// Token: 0x0602BF2D RID: 180013 RVA: 0x005F9A04 File Offset: 0x005F7C04
		public ICompareWeather ConditionAsICompareWeather()
		{
			return this.Condition<ICompareWeather>().Value;
		}

		// Token: 0x0602BF2E RID: 180014 RVA: 0x005F9A20 File Offset: 0x005F7C20
		public ICheckLevelPlayState ConditionAsICheckLevelPlayState()
		{
			return this.Condition<ICheckLevelPlayState>().Value;
		}

		// Token: 0x0602BF2F RID: 180015 RVA: 0x005F9A3C File Offset: 0x005F7C3C
		public ICheckLevelPlayCompleteNumber ConditionAsICheckLevelPlayCompleteNumber()
		{
			return this.Condition<ICheckLevelPlayCompleteNumber>().Value;
		}

		// Token: 0x0602BF30 RID: 180016 RVA: 0x005F9A58 File Offset: 0x005F7C58
		public ICheckLevelPlayChildQuestFinished ConditionAsICheckLevelPlayChildQuestFinished()
		{
			return this.Condition<ICheckLevelPlayChildQuestFinished>().Value;
		}

		// Token: 0x0602BF31 RID: 180017 RVA: 0x005F9A74 File Offset: 0x005F7C74
		public ICheckCurrentRole ConditionAsICheckCurrentRole()
		{
			return this.Condition<ICheckCurrentRole>().Value;
		}

		// Token: 0x0602BF32 RID: 180018 RVA: 0x005F9A90 File Offset: 0x005F7C90
		public ICheckPlayerGender ConditionAsICheckPlayerGender()
		{
			return this.Condition<ICheckPlayerGender>().Value;
		}

		// Token: 0x0602BF33 RID: 180019 RVA: 0x005F9AAC File Offset: 0x005F7CAC
		public ICheckInCombat ConditionAsICheckInCombat()
		{
			return this.Condition<ICheckInCombat>().Value;
		}

		// Token: 0x0602BF34 RID: 180020 RVA: 0x005F9AC8 File Offset: 0x005F7CC8
		public ICheckHasFollowShooter ConditionAsICheckHasFollowShooter()
		{
			return this.Condition<ICheckHasFollowShooter>().Value;
		}

		// Token: 0x0602BF35 RID: 180021 RVA: 0x005F9AE4 File Offset: 0x005F7CE4
		public ICheckFollowShooterActive ConditionAsICheckFollowShooterActive()
		{
			return this.Condition<ICheckFollowShooterActive>().Value;
		}

		// Token: 0x0602BF36 RID: 180022 RVA: 0x005F9B00 File Offset: 0x005F7D00
		public ICheckChildQuestFinished ConditionAsICheckChildQuestFinished()
		{
			return this.Condition<ICheckChildQuestFinished>().Value;
		}

		// Token: 0x0602BF37 RID: 180023 RVA: 0x005F9B1C File Offset: 0x005F7D1C
		public ICheckSyncLevelPlayCompleteNumber ConditionAsICheckSyncLevelPlayCompleteNumber()
		{
			return this.Condition<ICheckSyncLevelPlayCompleteNumber>().Value;
		}

		// Token: 0x0602BF38 RID: 180024 RVA: 0x005F9B38 File Offset: 0x005F7D38
		public ICheckCrossSceneSyncKillMonsterFinished ConditionAsICheckCrossSceneSyncKillMonsterFinished()
		{
			return this.Condition<ICheckCrossSceneSyncKillMonsterFinished>().Value;
		}

		// Token: 0x0602BF39 RID: 180025 RVA: 0x005F9B54 File Offset: 0x005F7D54
		public ICheckNodeStatus ConditionAsICheckNodeStatus()
		{
			return this.Condition<ICheckNodeStatus>().Value;
		}

		// Token: 0x0602BF3A RID: 180026 RVA: 0x005F9B70 File Offset: 0x005F7D70
		public ICheckChildQuestStatus ConditionAsICheckChildQuestStatus()
		{
			return this.Condition<ICheckChildQuestStatus>().Value;
		}

		// Token: 0x0602BF3B RID: 180027 RVA: 0x005F9B8C File Offset: 0x005F7D8C
		public ICheckEntitiesExist ConditionAsICheckEntitiesExist()
		{
			return this.Condition<ICheckEntitiesExist>().Value;
		}

		// Token: 0x0602BF3C RID: 180028 RVA: 0x005F9BA8 File Offset: 0x005F7DA8
		public ICheckPlayerPosition ConditionAsICheckPlayerPosition()
		{
			return this.Condition<ICheckPlayerPosition>().Value;
		}

		// Token: 0x0602BF3D RID: 180029 RVA: 0x005F9BC4 File Offset: 0x005F7DC4
		public ICheckEntityPosition ConditionAsICheckEntityPosition()
		{
			return this.Condition<ICheckEntityPosition>().Value;
		}

		// Token: 0x0602BF3E RID: 180030 RVA: 0x005F9BE0 File Offset: 0x005F7DE0
		public ICheckDungeonFinish ConditionAsICheckDungeonFinish()
		{
			return this.Condition<ICheckDungeonFinish>().Value;
		}

		// Token: 0x0602BF3F RID: 180031 RVA: 0x005F9BFC File Offset: 0x005F7DFC
		public ICheckEntityIsVisibility ConditionAsICheckEntityIsVisibility()
		{
			return this.Condition<ICheckEntityIsVisibility>().Value;
		}

		// Token: 0x0602BF40 RID: 180032 RVA: 0x005F9C18 File Offset: 0x005F7E18
		public IComparePlayerMotionState ConditionAsIComparePlayerMotionState()
		{
			return this.Condition<IComparePlayerMotionState>().Value;
		}

		// Token: 0x0602BF41 RID: 180033 RVA: 0x005F9C34 File Offset: 0x005F7E34
		public IComparePlayerMotionState2 ConditionAsIComparePlayerMotionState2()
		{
			return this.Condition<IComparePlayerMotionState2>().Value;
		}

		// Token: 0x0602BF42 RID: 180034 RVA: 0x005F9C50 File Offset: 0x005F7E50
		public ICheckDataLayerCondition ConditionAsICheckDataLayerCondition()
		{
			return this.Condition<ICheckDataLayerCondition>().Value;
		}

		// Token: 0x0602BF43 RID: 180035 RVA: 0x005F9C6C File Offset: 0x005F7E6C
		public ICheckHookLockPointCondition ConditionAsICheckHookLockPointCondition()
		{
			return this.Condition<ICheckHookLockPointCondition>().Value;
		}

		// Token: 0x0602BF44 RID: 180036 RVA: 0x005F9C88 File Offset: 0x005F7E88
		public ICheckPlayerSkillReadyCondition ConditionAsICheckPlayerSkillReadyCondition()
		{
			return this.Condition<ICheckPlayerSkillReadyCondition>().Value;
		}

		// Token: 0x0602BF45 RID: 180037 RVA: 0x005F9CA4 File Offset: 0x005F7EA4
		public ICheckPlayerUseSkillCondition ConditionAsICheckPlayerUseSkillCondition()
		{
			return this.Condition<ICheckPlayerUseSkillCondition>().Value;
		}

		// Token: 0x0602BF46 RID: 180038 RVA: 0x005F9CC0 File Offset: 0x005F7EC0
		public ICheckPlayerStateRestrictionCondition ConditionAsICheckPlayerStateRestrictionCondition()
		{
			return this.Condition<ICheckPlayerStateRestrictionCondition>().Value;
		}

		// Token: 0x0602BF47 RID: 180039 RVA: 0x005F9CDC File Offset: 0x005F7EDC
		public ICheckLordGymFinishCondition ConditionAsICheckLordGymFinishCondition()
		{
			return this.Condition<ICheckLordGymFinishCondition>().Value;
		}

		// Token: 0x0602BF48 RID: 180040 RVA: 0x005F9CF8 File Offset: 0x005F7EF8
		public ICheckCalabashDevelopRewardCondition ConditionAsICheckCalabashDevelopRewardCondition()
		{
			return this.Condition<ICheckCalabashDevelopRewardCondition>().Value;
		}

		// Token: 0x0602BF49 RID: 180041 RVA: 0x005F9D14 File Offset: 0x005F7F14
		public ICompareFishingPrestigeLevelCondition ConditionAsICompareFishingPrestigeLevelCondition()
		{
			return this.Condition<ICompareFishingPrestigeLevelCondition>().Value;
		}

		// Token: 0x0602BF4A RID: 180042 RVA: 0x005F9D30 File Offset: 0x005F7F30
		public ICheckCertainFishingItemCount ConditionAsICheckCertainFishingItemCount()
		{
			return this.Condition<ICheckCertainFishingItemCount>().Value;
		}

		// Token: 0x0602BF4B RID: 180043 RVA: 0x005F9D4C File Offset: 0x005F7F4C
		public ICompleteCertainFishingEntrust ConditionAsICompleteCertainFishingEntrust()
		{
			return this.Condition<ICompleteCertainFishingEntrust>().Value;
		}

		// Token: 0x0602BF4C RID: 180044 RVA: 0x005F9D68 File Offset: 0x005F7F68
		public ICompareFishingBoatState ConditionAsICompareFishingBoatState()
		{
			return this.Condition<ICompareFishingBoatState>().Value;
		}

		// Token: 0x0602BF4D RID: 180045 RVA: 0x005F9D84 File Offset: 0x005F7F84
		public ICheckJigsawInfoCondition ConditionAsICheckJigsawInfoCondition()
		{
			return this.Condition<ICheckJigsawInfoCondition>().Value;
		}

		// Token: 0x0602BF4E RID: 180046 RVA: 0x005F9DA0 File Offset: 0x005F7FA0
		public ICheckGameplayTagCondition ConditionAsICheckGameplayTagCondition()
		{
			return this.Condition<ICheckGameplayTagCondition>().Value;
		}

		// Token: 0x0602BF4F RID: 180047 RVA: 0x005F9DBC File Offset: 0x005F7FBC
		public ICheckFormationRoleInfoCondition ConditionAsICheckFormationRoleInfoCondition()
		{
			return this.Condition<ICheckFormationRoleInfoCondition>().Value;
		}

		// Token: 0x0602BF50 RID: 180048 RVA: 0x005F9DD8 File Offset: 0x005F7FD8
		public ICheckTargetAttributeCondition ConditionAsICheckTargetAttributeCondition()
		{
			return this.Condition<ICheckTargetAttributeCondition>().Value;
		}

		// Token: 0x0602BF51 RID: 180049 RVA: 0x005F9DF4 File Offset: 0x005F7FF4
		public ICheckRogueAbilitySelectCondition ConditionAsICheckRogueAbilitySelectCondition()
		{
			return this.Condition<ICheckRogueAbilitySelectCondition>().Value;
		}

		// Token: 0x0602BF52 RID: 180050 RVA: 0x005F9E10 File Offset: 0x005F8010
		public ICheckDirectionCondition ConditionAsICheckDirectionCondition()
		{
			return this.Condition<ICheckDirectionCondition>().Value;
		}

		// Token: 0x0602BF53 RID: 180051 RVA: 0x005F9E2C File Offset: 0x005F802C
		public ICheckSceneItemDirectionCondition ConditionAsICheckSceneItemDirectionCondition()
		{
			return this.Condition<ICheckSceneItemDirectionCondition>().Value;
		}

		// Token: 0x0602BF54 RID: 180052 RVA: 0x005F9E48 File Offset: 0x005F8048
		public ICheckPlayerFaceToCondition ConditionAsICheckPlayerFaceToCondition()
		{
			return this.Condition<ICheckPlayerFaceToCondition>().Value;
		}

		// Token: 0x0602BF55 RID: 180053 RVA: 0x005F9E64 File Offset: 0x005F8064
		public ICheckPlayerCanJoinActivityCondition ConditionAsICheckPlayerCanJoinActivityCondition()
		{
			return this.Condition<ICheckPlayerCanJoinActivityCondition>().Value;
		}

		// Token: 0x0602BF56 RID: 180054 RVA: 0x005F9E80 File Offset: 0x005F8080
		public ICheckSystemStateCondition ConditionAsICheckSystemStateCondition()
		{
			return this.Condition<ICheckSystemStateCondition>().Value;
		}

		// Token: 0x0602BF57 RID: 180055 RVA: 0x005F9E9C File Offset: 0x005F809C
		public ICheckInRangeCondition ConditionAsICheckInRangeCondition()
		{
			return this.Condition<ICheckInRangeCondition>().Value;
		}

		// Token: 0x0602BF58 RID: 180056 RVA: 0x005F9EB8 File Offset: 0x005F80B8
		public ICheckInRangeProperlyCondition ConditionAsICheckInRangeProperlyCondition()
		{
			return this.Condition<ICheckInRangeProperlyCondition>().Value;
		}

		// Token: 0x0602BF59 RID: 180057 RVA: 0x005F9ED4 File Offset: 0x005F80D4
		public ICheckEntityLockedCondition ConditionAsICheckEntityLockedCondition()
		{
			return this.Condition<ICheckEntityLockedCondition>().Value;
		}

		// Token: 0x0602BF5A RID: 180058 RVA: 0x005F9EF0 File Offset: 0x005F80F0
		public ICompareTeammateDieCondition ConditionAsICompareTeammateDieCondition()
		{
			return this.Condition<ICompareTeammateDieCondition>().Value;
		}

		// Token: 0x0602BF5B RID: 180059 RVA: 0x005F9F0C File Offset: 0x005F810C
		public IListenEntitySelfEventCondition ConditionAsIListenEntitySelfEventCondition()
		{
			return this.Condition<IListenEntitySelfEventCondition>().Value;
		}

		// Token: 0x0602BF5C RID: 180060 RVA: 0x005F9F28 File Offset: 0x005F8128
		public ICheckEntityDistanceCondition ConditionAsICheckEntityDistanceCondition()
		{
			return this.Condition<ICheckEntityDistanceCondition>().Value;
		}

		// Token: 0x0602BF5D RID: 180061 RVA: 0x005F9F44 File Offset: 0x005F8144
		public ICheckEntityHasSceneItemAttributeTag ConditionAsICheckEntityHasSceneItemAttributeTag()
		{
			return this.Condition<ICheckEntityHasSceneItemAttributeTag>().Value;
		}

		// Token: 0x0602BF5E RID: 180062 RVA: 0x005F9F60 File Offset: 0x005F8160
		public IListenEntityThroughPortal ConditionAsIListenEntityThroughPortal()
		{
			return this.Condition<IListenEntityThroughPortal>().Value;
		}

		// Token: 0x0602BF5F RID: 180063 RVA: 0x005F9F7C File Offset: 0x005F817C
		public ICheckTeleControlState ConditionAsICheckTeleControlState()
		{
			return this.Condition<ICheckTeleControlState>().Value;
		}

		// Token: 0x0602BF60 RID: 180064 RVA: 0x005F9F98 File Offset: 0x005F8198
		public ICustomJsonCondition ConditionAsICustomJsonCondition()
		{
			return this.Condition<ICustomJsonCondition>().Value;
		}

		// Token: 0x0602BF61 RID: 180065 RVA: 0x005F9FB4 File Offset: 0x005F81B4
		public ICheckChessWinner ConditionAsICheckChessWinner()
		{
			return this.Condition<ICheckChessWinner>().Value;
		}

		// Token: 0x0602BF62 RID: 180066 RVA: 0x005F9FD0 File Offset: 0x005F81D0
		public ICheckVehicleCondition ConditionAsICheckVehicleCondition()
		{
			return this.Condition<ICheckVehicleCondition>().Value;
		}

		// Token: 0x0602BF63 RID: 180067 RVA: 0x005F9FEC File Offset: 0x005F81EC
		public ICheckMechState ConditionAsICheckMechState()
		{
			return this.Condition<ICheckMechState>().Value;
		}

		// Token: 0x0602BF64 RID: 180068 RVA: 0x005FA008 File Offset: 0x005F8208
		public ICheckExploreSkillState ConditionAsICheckExploreSkillState()
		{
			return this.Condition<ICheckExploreSkillState>().Value;
		}

		// Token: 0x0602BF65 RID: 180069 RVA: 0x005FA024 File Offset: 0x005F8224
		public ICompareAlertValue ConditionAsICompareAlertValue()
		{
			return this.Condition<ICompareAlertValue>().Value;
		}

		// Token: 0x0602BF66 RID: 180070 RVA: 0x005FA040 File Offset: 0x005F8240
		public ICheckEntityGravityDirection ConditionAsICheckEntityGravityDirection()
		{
			return this.Condition<ICheckEntityGravityDirection>().Value;
		}

		// Token: 0x0602BF67 RID: 180071 RVA: 0x005FA05C File Offset: 0x005F825C
		public ICheckCollectAnimalParts ConditionAsICheckCollectAnimalParts()
		{
			return this.Condition<ICheckCollectAnimalParts>().Value;
		}

		// Token: 0x0602BF68 RID: 180072 RVA: 0x005FA078 File Offset: 0x005F8278
		public ICheckPreloadComplete ConditionAsICheckPreloadComplete()
		{
			return this.Condition<ICheckPreloadComplete>().Value;
		}

		// Token: 0x0602BF69 RID: 180073 RVA: 0x005FA094 File Offset: 0x005F8294
		public ICheckFinishLoading ConditionAsICheckFinishLoading()
		{
			return this.Condition<ICheckFinishLoading>().Value;
		}

		// Token: 0x0602BF6A RID: 180074 RVA: 0x005FA0B0 File Offset: 0x005F82B0
		public ICheckFishingPointHasFish ConditionAsICheckFishingPointHasFish()
		{
			return this.Condition<ICheckFishingPointHasFish>().Value;
		}

		// Token: 0x0602BF6B RID: 180075 RVA: 0x005FA0CC File Offset: 0x005F82CC
		public ICheckFishingCageFillingRatio ConditionAsICheckFishingCageFillingRatio()
		{
			return this.Condition<ICheckFishingCageFillingRatio>().Value;
		}

		// Token: 0x0602BF6C RID: 180076 RVA: 0x005FA0E8 File Offset: 0x005F82E8
		public ICompareFishingTechLevel ConditionAsICompareFishingTechLevel()
		{
			return this.Condition<ICompareFishingTechLevel>().Value;
		}

		// Token: 0x0602BF6D RID: 180077 RVA: 0x005FA104 File Offset: 0x005F8304
		public ICheckGuestCharacter ConditionAsICheckGuestCharacter()
		{
			return this.Condition<ICheckGuestCharacter>().Value;
		}

		// Token: 0x0602BF6E RID: 180078 RVA: 0x005FA120 File Offset: 0x005F8320
		public ICheckSubLevelState ConditionAsICheckSubLevelState()
		{
			return this.Condition<ICheckSubLevelState>().Value;
		}

		// Token: 0x0602BF6F RID: 180079 RVA: 0x005FA13C File Offset: 0x005F833C
		public IComparePlayerNumInDungeon ConditionAsIComparePlayerNumInDungeon()
		{
			return this.Condition<IComparePlayerNumInDungeon>().Value;
		}

		// Token: 0x0602BF70 RID: 180080 RVA: 0x005FA158 File Offset: 0x005F8358
		public ICheckAlertAreaEnabled ConditionAsICheckAlertAreaEnabled()
		{
			return this.Condition<ICheckAlertAreaEnabled>().Value;
		}

		// Token: 0x0602BF71 RID: 180081 RVA: 0x005FA174 File Offset: 0x005F8374
		public ICheckClientEvent ConditionAsICheckClientEvent()
		{
			return this.Condition<ICheckClientEvent>().Value;
		}

		// Token: 0x0602BF72 RID: 180082 RVA: 0x005FA190 File Offset: 0x005F8390
		public ICheckIsGramophonePlayingMusic ConditionAsICheckIsGramophonePlayingMusic()
		{
			return this.Condition<ICheckIsGramophonePlayingMusic>().Value;
		}

		// Token: 0x0602BF73 RID: 180083 RVA: 0x005FA1AC File Offset: 0x005F83AC
		public ICheckEntityReward ConditionAsICheckEntityReward()
		{
			return this.Condition<ICheckEntityReward>().Value;
		}

		// Token: 0x0602BF74 RID: 180084 RVA: 0x005FA1C8 File Offset: 0x005F83C8
		public ICheckDungeonHasSaveConfig ConditionAsICheckDungeonHasSaveConfig()
		{
			return this.Condition<ICheckDungeonHasSaveConfig>().Value;
		}

		// Token: 0x0602BF75 RID: 180085 RVA: 0x005FA1E4 File Offset: 0x005F83E4
		public ICheckSystemEventBvb ConditionAsICheckSystemEventBvb()
		{
			return this.Condition<ICheckSystemEventBvb>().Value;
		}

		// Token: 0x0602BF76 RID: 180086 RVA: 0x005FA200 File Offset: 0x005F8400
		public ICheckDangoCultivationProgress ConditionAsICheckDangoCultivationProgress()
		{
			return this.Condition<ICheckDangoCultivationProgress>().Value;
		}

		// Token: 0x0602BF77 RID: 180087 RVA: 0x005FA21C File Offset: 0x005F841C
		public ICheckPlayerMoraleLevelRange ConditionAsICheckPlayerMoraleLevelRange()
		{
			return this.Condition<ICheckPlayerMoraleLevelRange>().Value;
		}

		// Token: 0x0602BF78 RID: 180088 RVA: 0x005FA238 File Offset: 0x005F8438
		public ICheckIsGlobalTimeScaleEnabled ConditionAsICheckIsGlobalTimeScaleEnabled()
		{
			return this.Condition<ICheckIsGlobalTimeScaleEnabled>().Value;
		}

		// Token: 0x0602BF79 RID: 180089 RVA: 0x005FA254 File Offset: 0x005F8454
		public ISaveConfigEnterMethod ConditionAsISaveConfigEnterMethod()
		{
			return this.Condition<ISaveConfigEnterMethod>().Value;
		}

		// Token: 0x0602BF7A RID: 180090 RVA: 0x005FA270 File Offset: 0x005F8470
		public ICheckIsEntityTimeScaleEnabled ConditionAsICheckIsEntityTimeScaleEnabled()
		{
			return this.Condition<ICheckIsEntityTimeScaleEnabled>().Value;
		}

		// Token: 0x0602BF7B RID: 180091 RVA: 0x005FA28C File Offset: 0x005F848C
		public ICheckIsCharacterHoldingHands ConditionAsICheckIsCharacterHoldingHands()
		{
			return this.Condition<ICheckIsCharacterHoldingHands>().Value;
		}

		// Token: 0x0602BF7C RID: 180092 RVA: 0x005FA2A8 File Offset: 0x005F84A8
		public ICheckIsTrackingCurrentQuest ConditionAsICheckIsTrackingCurrentQuest()
		{
			return this.Condition<ICheckIsTrackingCurrentQuest>().Value;
		}

		// Token: 0x0602BF7D RID: 180093 RVA: 0x005FA2C4 File Offset: 0x005F84C4
		public ICheckIsTrackingQuest ConditionAsICheckIsTrackingQuest()
		{
			return this.Condition<ICheckIsTrackingQuest>().Value;
		}

		// Token: 0x0602BF7E RID: 180094 RVA: 0x005FA2E0 File Offset: 0x005F84E0
		public ICheckMusicEvent ConditionAsICheckMusicEvent()
		{
			return this.Condition<ICheckMusicEvent>().Value;
		}

		// Token: 0x0602BF7F RID: 180095 RVA: 0x005FA2FC File Offset: 0x005F84FC
		public ICompareGameDifficulty ConditionAsICompareGameDifficulty()
		{
			return this.Condition<ICompareGameDifficulty>().Value;
		}

		// Token: 0x0602BF80 RID: 180096 RVA: 0x005FA318 File Offset: 0x005F8518
		public ICheckPhotographCameraParam ConditionAsICheckPhotographCameraParam()
		{
			return this.Condition<ICheckPhotographCameraParam>().Value;
		}

		// Token: 0x0602BF81 RID: 180097 RVA: 0x005FA334 File Offset: 0x005F8534
		public ICheckEntityHasBuff ConditionAsICheckEntityHasBuff()
		{
			return this.Condition<ICheckEntityHasBuff>().Value;
		}

		// Token: 0x0602BF82 RID: 180098 RVA: 0x005FA350 File Offset: 0x005F8550
		public ICheckEntityBuffStack ConditionAsICheckEntityBuffStack()
		{
			return this.Condition<ICheckEntityBuffStack>().Value;
		}

		// Token: 0x0602BF83 RID: 180099 RVA: 0x005FA36C File Offset: 0x005F856C
		public ICheckAvailableSunSpiritCount ConditionAsICheckAvailableSunSpiritCount()
		{
			return this.Condition<ICheckAvailableSunSpiritCount>().Value;
		}

		// Token: 0x0602BF84 RID: 180100 RVA: 0x005FA388 File Offset: 0x005F8588
		public ICheckPlayerEnterClientTriggerDir ConditionAsICheckPlayerEnterClientTriggerDir()
		{
			return this.Condition<ICheckPlayerEnterClientTriggerDir>().Value;
		}

		// Token: 0x0602BF85 RID: 180101 RVA: 0x005FA3A4 File Offset: 0x005F85A4
		public ICheckPlayerRelativeDistance ConditionAsICheckPlayerRelativeDistance()
		{
			return this.Condition<ICheckPlayerRelativeDistance>().Value;
		}

		// Token: 0x0602BF86 RID: 180102 RVA: 0x005FA3C0 File Offset: 0x005F85C0
		public ICheckPlayerRelativeAngle ConditionAsICheckPlayerRelativeAngle()
		{
			return this.Condition<ICheckPlayerRelativeAngle>().Value;
		}

		// Token: 0x0602BF87 RID: 180103 RVA: 0x005FA3DC File Offset: 0x005F85DC
		public ICheckHonamiStoryGetItem ConditionAsICheckHonamiStoryGetItem()
		{
			return this.Condition<ICheckHonamiStoryGetItem>().Value;
		}

		// Token: 0x0602BF88 RID: 180104 RVA: 0x005FA3F8 File Offset: 0x005F85F8
		public ICheckHonamiStoryEquipItem ConditionAsICheckHonamiStoryEquipItem()
		{
			return this.Condition<ICheckHonamiStoryEquipItem>().Value;
		}

		// Token: 0x0602BF89 RID: 180105 RVA: 0x005FA414 File Offset: 0x005F8614
		public ICheckHonamiStoryActivateTalent ConditionAsICheckHonamiStoryActivateTalent()
		{
			return this.Condition<ICheckHonamiStoryActivateTalent>().Value;
		}

		// Token: 0x0602BF8A RID: 180106 RVA: 0x005FA430 File Offset: 0x005F8630
		public ICheckHonamiStoryUnlockSlot ConditionAsICheckHonamiStoryUnlockSlot()
		{
			return this.Condition<ICheckHonamiStoryUnlockSlot>().Value;
		}

		// Token: 0x0602BF8B RID: 180107 RVA: 0x005FA44C File Offset: 0x005F864C
		public ICheckHonamiStoryLifeSupportLevel ConditionAsICheckHonamiStoryLifeSupportLevel()
		{
			return this.Condition<ICheckHonamiStoryLifeSupportLevel>().Value;
		}

		// Token: 0x0602BF8C RID: 180108 RVA: 0x005FA468 File Offset: 0x005F8668
		public ICheckHonamiStoryTowerComplete ConditionAsICheckHonamiStoryTowerComplete()
		{
			return this.Condition<ICheckHonamiStoryTowerComplete>().Value;
		}

		// Token: 0x0602BF8D RID: 180109 RVA: 0x005FA484 File Offset: 0x005F8684
		public ICheckHonamiStoryPlayerCorruptedLevel ConditionAsICheckHonamiStoryPlayerCorruptedLevel()
		{
			return this.Condition<ICheckHonamiStoryPlayerCorruptedLevel>().Value;
		}

		// Token: 0x0602BF8E RID: 180110 RVA: 0x005FA4A0 File Offset: 0x005F86A0
		public ICheckHonamiStoryUnlockMascot ConditionAsICheckHonamiStoryUnlockMascot()
		{
			return this.Condition<ICheckHonamiStoryUnlockMascot>().Value;
		}

		// Token: 0x0602BF8F RID: 180111 RVA: 0x005FA4BC File Offset: 0x005F86BC
		public ICheckHonamiStoryChestOpenTime ConditionAsICheckHonamiStoryChestOpenTime()
		{
			return this.Condition<ICheckHonamiStoryChestOpenTime>().Value;
		}

		// Token: 0x0602BF90 RID: 180112 RVA: 0x005FA4D8 File Offset: 0x005F86D8
		public ICheckHonamiStorySuccessfulEvacuation ConditionAsICheckHonamiStorySuccessfulEvacuation()
		{
			return this.Condition<ICheckHonamiStorySuccessfulEvacuation>().Value;
		}

		// Token: 0x0602BF91 RID: 180113 RVA: 0x005FA4F4 File Offset: 0x005F86F4
		public ICheckBvbChallengeState ConditionAsICheckBvbChallengeState()
		{
			return this.Condition<ICheckBvbChallengeState>().Value;
		}

		// Token: 0x0602BF92 RID: 180114 RVA: 0x005FA510 File Offset: 0x005F8710
		public ICheckBvbActivityRank ConditionAsICheckBvbActivityRank()
		{
			return this.Condition<ICheckBvbActivityRank>().Value;
		}

		// Token: 0x0602BF93 RID: 180115 RVA: 0x005FA52C File Offset: 0x005F872C
		public ICheckDiceGameChallengeState ConditionAsICheckDiceGameChallengeState()
		{
			return this.Condition<ICheckDiceGameChallengeState>().Value;
		}

		// Token: 0x0602BF94 RID: 180116 RVA: 0x005FA548 File Offset: 0x005F8748
		public ICompareDiceGameRankLevel ConditionAsICompareDiceGameRankLevel()
		{
			return this.Condition<ICompareDiceGameRankLevel>().Value;
		}

		// Token: 0x0602BF95 RID: 180117 RVA: 0x005FA564 File Offset: 0x005F8764
		public ICheckCollectedSunSpiritCount ConditionAsICheckCollectedSunSpiritCount()
		{
			return this.Condition<ICheckCollectedSunSpiritCount>().Value;
		}

		// Token: 0x0602BF96 RID: 180118 RVA: 0x005FA580 File Offset: 0x005F8780
		public ICheckTargetSunSpiritCollected ConditionAsICheckTargetSunSpiritCollected()
		{
			return this.Condition<ICheckTargetSunSpiritCollected>().Value;
		}

		// Token: 0x0602BF97 RID: 180119 RVA: 0x005FA59C File Offset: 0x005F879C
		public ICheckPlayerIsInDeadEyeProcess ConditionAsICheckPlayerIsInDeadEyeProcess()
		{
			return this.Condition<ICheckPlayerIsInDeadEyeProcess>().Value;
		}

		// Token: 0x0602BF98 RID: 180120 RVA: 0x005FA5B8 File Offset: 0x005F87B8
		public ICheckEntitySelfDirection ConditionAsICheckEntitySelfDirection()
		{
			return this.Condition<ICheckEntitySelfDirection>().Value;
		}

		// Token: 0x0602BF99 RID: 180121 RVA: 0x005FA5D4 File Offset: 0x005F87D4
		public ICheckDollGrabItemComboAchievedInOnceDelivery ConditionAsICheckDollGrabItemComboAchievedInOnceDelivery()
		{
			return this.Condition<ICheckDollGrabItemComboAchievedInOnceDelivery>().Value;
		}

		// Token: 0x0602BF9A RID: 180122 RVA: 0x005FA5F0 File Offset: 0x005F87F0
		public ICheckDollGrabShowcaseItemComboAchieved ConditionAsICheckDollGrabShowcaseItemComboAchieved()
		{
			return this.Condition<ICheckDollGrabShowcaseItemComboAchieved>().Value;
		}

		// Token: 0x0602BF9B RID: 180123 RVA: 0x005FA60C File Offset: 0x005F880C
		public ICheckRoverRogueAbilitySelectCondition ConditionAsICheckRoverRogueAbilitySelectCondition()
		{
			return this.Condition<ICheckRoverRogueAbilitySelectCondition>().Value;
		}

		// Token: 0x0602BF9C RID: 180124 RVA: 0x005FA628 File Offset: 0x005F8828
		public ICheckDollGrabMachineFinished ConditionAsICheckDollGrabMachineFinished()
		{
			return this.Condition<ICheckDollGrabMachineFinished>().Value;
		}

		// Token: 0x0602BF9D RID: 180125 RVA: 0x005FA644 File Offset: 0x005F8844
		public ICheckTrafficBlocked ConditionAsICheckTrafficBlocked()
		{
			return this.Condition<ICheckTrafficBlocked>().Value;
		}

		// Token: 0x0602BF9E RID: 180126 RVA: 0x005FA660 File Offset: 0x005F8860
		public ICheckDrinksPreferenceLevel ConditionAsICheckDrinksPreferenceLevel()
		{
			return this.Condition<ICheckDrinksPreferenceLevel>().Value;
		}

		// Token: 0x0602BF9F RID: 180127 RVA: 0x005FA67C File Offset: 0x005F887C
		public ICheckPlayerIsInMotorcycleCruise ConditionAsICheckPlayerIsInMotorcycleCruise()
		{
			return this.Condition<ICheckPlayerIsInMotorcycleCruise>().Value;
		}

		// Token: 0x0602BFA0 RID: 180128 RVA: 0x005FA698 File Offset: 0x005F8898
		public ICheckPlayerIsControlledByAi ConditionAsICheckPlayerIsControlledByAi()
		{
			return this.Condition<ICheckPlayerIsControlledByAi>().Value;
		}

		// Token: 0x0602BFA1 RID: 180129 RVA: 0x005FA6B4 File Offset: 0x005F88B4
		public ICheckTetrisEndlessScore ConditionAsICheckTetrisEndlessScore()
		{
			return this.Condition<ICheckTetrisEndlessScore>().Value;
		}

		// Token: 0x0602BFA2 RID: 180130 RVA: 0x005FA6D0 File Offset: 0x005F88D0
		public ICheckDartLevelComplete ConditionAsICheckDartLevelComplete()
		{
			return this.Condition<ICheckDartLevelComplete>().Value;
		}

		// Token: 0x0602BFA3 RID: 180131 RVA: 0x005FA6EC File Offset: 0x005F88EC
		public ICheckAtlasUnlocked ConditionAsICheckAtlasUnlocked()
		{
			return this.Condition<ICheckAtlasUnlocked>().Value;
		}

		// Token: 0x0602BFA4 RID: 180132 RVA: 0x005FA708 File Offset: 0x005F8908
		public ICheckSheriffUnlockEnding ConditionAsICheckSheriffUnlockEnding()
		{
			return this.Condition<ICheckSheriffUnlockEnding>().Value;
		}

		// Token: 0x0602BFA5 RID: 180133 RVA: 0x005FA724 File Offset: 0x005F8924
		public ICheckIsInDragActorPlay ConditionAsICheckIsInDragActorPlay()
		{
			return this.Condition<ICheckIsInDragActorPlay>().Value;
		}

		// Token: 0x0602BFA6 RID: 180134 RVA: 0x005FA740 File Offset: 0x005F8940
		public ICheckIsInDollGrabGamePlay ConditionAsICheckIsInDollGrabGamePlay()
		{
			return this.Condition<ICheckIsInDollGrabGamePlay>().Value;
		}

		// Token: 0x0602BFA7 RID: 180135 RVA: 0x005FA75C File Offset: 0x005F895C
		public ICheckIsInDartGameplay ConditionAsICheckIsInDartGameplay()
		{
			return this.Condition<ICheckIsInDartGameplay>().Value;
		}

		// Token: 0x0602BFA8 RID: 180136 RVA: 0x005FA778 File Offset: 0x005F8978
		public ICheckIsInRideFlyingCarGameplay ConditionAsICheckIsInRideFlyingCarGameplay()
		{
			return this.Condition<ICheckIsInRideFlyingCarGameplay>().Value;
		}

		// Token: 0x0602BFA9 RID: 180137 RVA: 0x005FA794 File Offset: 0x005F8994
		public ICheckEntityPrefabPerformanceType ConditionAsICheckEntityPrefabPerformanceType()
		{
			return this.Condition<ICheckEntityPrefabPerformanceType>().Value;
		}

		// Token: 0x0602BFAA RID: 180138 RVA: 0x005FA7B0 File Offset: 0x005F89B0
		public ICheckIsSupportedWalking ConditionAsICheckIsSupportedWalking()
		{
			return this.Condition<ICheckIsSupportedWalking>().Value;
		}

		// Token: 0x0602BFAB RID: 180139 RVA: 0x005FA7CC File Offset: 0x005F89CC
		public ICheckGiantStableValue ConditionAsICheckGiantStableValue()
		{
			return this.Condition<ICheckGiantStableValue>().Value;
		}

		// Token: 0x0602BFAC RID: 180140 RVA: 0x005FA7E8 File Offset: 0x005F89E8
		public ICheckGiantTotalProgressCanActivateNode ConditionAsICheckGiantTotalProgressCanActivateNode()
		{
			return this.Condition<ICheckGiantTotalProgressCanActivateNode>().Value;
		}

		// Token: 0x0602BFAD RID: 180141 RVA: 0x005FA804 File Offset: 0x005F8A04
		public ICheckGiantTotalProgressInteractActivatedNode ConditionAsICheckGiantTotalProgressInteractActivatedNode()
		{
			return this.Condition<ICheckGiantTotalProgressInteractActivatedNode>().Value;
		}

		// Token: 0x0602BFAE RID: 180142 RVA: 0x005FA820 File Offset: 0x005F8A20
		public ICheckGiantRegionCultivationTriggeredUpgradeLevel ConditionAsICheckGiantRegionCultivationTriggeredUpgradeLevel()
		{
			return this.Condition<ICheckGiantRegionCultivationTriggeredUpgradeLevel>().Value;
		}

		// Token: 0x0602BFAF RID: 180143 RVA: 0x005FA83C File Offset: 0x005F8A3C
		public ICheckElementalBoxState ConditionAsICheckElementalBoxState()
		{
			return this.Condition<ICheckElementalBoxState>().Value;
		}

		// Token: 0x0602BFB0 RID: 180144 RVA: 0x005FA858 File Offset: 0x005F8A58
		public ICheckIsTargetHoldElementalBox ConditionAsICheckIsTargetHoldElementalBox()
		{
			return this.Condition<ICheckIsTargetHoldElementalBox>().Value;
		}

		// Token: 0x0602BFB1 RID: 180145 RVA: 0x005FA874 File Offset: 0x005F8A74
		public ICheckElementalEffectActive ConditionAsICheckElementalEffectActive()
		{
			return this.Condition<ICheckElementalEffectActive>().Value;
		}

		// Token: 0x0602BFB2 RID: 180146 RVA: 0x005FA890 File Offset: 0x005F8A90
		public ICheckElementalWaterBoxStagnationSeq ConditionAsICheckElementalWaterBoxStagnationSeq()
		{
			return this.Condition<ICheckElementalWaterBoxStagnationSeq>().Value;
		}

		// Token: 0x0602BFB3 RID: 180147 RVA: 0x005FA8AC File Offset: 0x005F8AAC
		public ICompareSeasonAndWeather ConditionAsICompareSeasonAndWeather()
		{
			return this.Condition<ICompareSeasonAndWeather>().Value;
		}

		// Token: 0x0602BFB4 RID: 180148 RVA: 0x005FA8C8 File Offset: 0x005F8AC8
		public ICheckIsSpecialWeatherUnlocked ConditionAsICheckIsSpecialWeatherUnlocked()
		{
			return this.Condition<ICheckIsSpecialWeatherUnlocked>().Value;
		}

		// Token: 0x0602BFB5 RID: 180149 RVA: 0x005FA8E4 File Offset: 0x005F8AE4
		public ICheckCollectiblesDetectionAllowed ConditionAsICheckCollectiblesDetectionAllowed()
		{
			return this.Condition<ICheckCollectiblesDetectionAllowed>().Value;
		}

		// Token: 0x0602BFB6 RID: 180150 RVA: 0x005FA8FF File Offset: 0x005F8AFF
		public static Offset<ICommonBtConditionInfo> CreateICommonBtConditionInfo(FlatBufferBuilder builder, int TaskId = 0, ICondition2_Union Condition_type = ICondition2_Union.NONE, int ConditionOffset = 0)
		{
			builder.StartTable(3);
			ICommonBtConditionInfo.AddCondition(builder, ConditionOffset);
			ICommonBtConditionInfo.AddTaskId(builder, TaskId);
			ICommonBtConditionInfo.AddConditionType(builder, Condition_type);
			return ICommonBtConditionInfo.EndICommonBtConditionInfo(builder);
		}

		// Token: 0x0602BFB7 RID: 180151 RVA: 0x005FA923 File Offset: 0x005F8B23
		public static void StartICommonBtConditionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BFB8 RID: 180152 RVA: 0x005FA92C File Offset: 0x005F8B2C
		public static void AddTaskId(FlatBufferBuilder builder, int taskId)
		{
			builder.AddInt(0, taskId, 0);
		}

		// Token: 0x0602BFB9 RID: 180153 RVA: 0x005FA937 File Offset: 0x005F8B37
		public static void AddConditionType(FlatBufferBuilder builder, ICondition2_Union conditionType)
		{
			builder.AddByte(1, (byte)conditionType, 0);
		}

		// Token: 0x0602BFBA RID: 180154 RVA: 0x005FA942 File Offset: 0x005F8B42
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(2, conditionOffset, 0);
		}

		// Token: 0x0602BFBB RID: 180155 RVA: 0x005FA94D File Offset: 0x005F8B4D
		public static Offset<ICommonBtConditionInfo> EndICommonBtConditionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtConditionInfo>(builder.EndTable());
		}

		// Token: 0x0602BFBC RID: 180156 RVA: 0x005FA95C File Offset: 0x005F8B5C
		public ICommonBtConditionInfoT UnPack()
		{
			ICommonBtConditionInfoT commonBtConditionInfoT = new ICommonBtConditionInfoT();
			this.UnPackTo(commonBtConditionInfoT);
			return commonBtConditionInfoT;
		}

		// Token: 0x0602BFBD RID: 180157 RVA: 0x005FA978 File Offset: 0x005F8B78
		public void UnPackTo(ICommonBtConditionInfoT _o)
		{
			_o.TaskId = this.TaskId;
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

		// Token: 0x0602BFBE RID: 180158 RVA: 0x005FD154 File Offset: 0x005FB354
		public static Offset<ICommonBtConditionInfo> Pack(FlatBufferBuilder builder, ICommonBtConditionInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtConditionInfo>);
			}
			ICondition2_Union condition_type = (_o.Condition == null) ? ICondition2_Union.NONE : _o.Condition.Type;
			int conditionOffset = (_o.Condition == null) ? 0 : ICondition2_UnionUnion.Pack(builder, _o.Condition);
			return ICommonBtConditionInfo.CreateICommonBtConditionInfo(builder, _o.TaskId, condition_type, conditionOffset);
		}

		// Token: 0x04010682 RID: 67202
		private Table __p;
	}
}
