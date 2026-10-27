using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EAE RID: 24238
	public struct ICommonBtConditionInfo : IFlatbufferObject
	{
		// Token: 0x1700B51F RID: 46367
		// (get) Token: 0x06029868 RID: 170088 RVA: 0x005B0708 File Offset: 0x005AE908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029869 RID: 170089 RVA: 0x005B0715 File Offset: 0x005AE915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602986A RID: 170090 RVA: 0x005B071C File Offset: 0x005AE91C
		public static ICommonBtConditionInfo GetRootAsICommonBtConditionInfo(ByteBuffer _bb)
		{
			return ICommonBtConditionInfo.GetRootAsICommonBtConditionInfo(_bb, default(ICommonBtConditionInfo));
		}

		// Token: 0x0602986B RID: 170091 RVA: 0x005B0738 File Offset: 0x005AE938
		public static ICommonBtConditionInfo GetRootAsICommonBtConditionInfo(ByteBuffer _bb, ICommonBtConditionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602986C RID: 170092 RVA: 0x005B0755 File Offset: 0x005AE955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602986D RID: 170093 RVA: 0x005B0764 File Offset: 0x005AE964
		public ICommonBtConditionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B520 RID: 46368
		// (get) Token: 0x0602986E RID: 170094 RVA: 0x005B0774 File Offset: 0x005AE974
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

		// Token: 0x1700B521 RID: 46369
		// (get) Token: 0x0602986F RID: 170095 RVA: 0x005B07B0 File Offset: 0x005AE9B0
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

		// Token: 0x06029870 RID: 170096 RVA: 0x005B07EC File Offset: 0x005AE9EC
		public TTable? Condition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029871 RID: 170097 RVA: 0x005B0830 File Offset: 0x005AEA30
		public ICondition2 ConditionAsICondition2()
		{
			return this.Condition<ICondition2>().Value;
		}

		// Token: 0x06029872 RID: 170098 RVA: 0x005B084C File Offset: 0x005AEA4C
		public ICompareVarCondition ConditionAsICompareVarCondition()
		{
			return this.Condition<ICompareVarCondition>().Value;
		}

		// Token: 0x06029873 RID: 170099 RVA: 0x005B0868 File Offset: 0x005AEA68
		public IQuestStateEqualCondition ConditionAsIQuestStateEqualCondition()
		{
			return this.Condition<IQuestStateEqualCondition>().Value;
		}

		// Token: 0x06029874 RID: 170100 RVA: 0x005B0884 File Offset: 0x005AEA84
		public ICompareExploreLevelCondition ConditionAsICompareExploreLevelCondition()
		{
			return this.Condition<ICompareExploreLevelCondition>().Value;
		}

		// Token: 0x06029875 RID: 170101 RVA: 0x005B08A0 File Offset: 0x005AEAA0
		public ICompareCalabashLevelCondition ConditionAsICompareCalabashLevelCondition()
		{
			return this.Condition<ICompareCalabashLevelCondition>().Value;
		}

		// Token: 0x06029876 RID: 170102 RVA: 0x005B08BC File Offset: 0x005AEABC
		public ICompareLiftCondition ConditionAsICompareLiftCondition()
		{
			return this.Condition<ICompareLiftCondition>().Value;
		}

		// Token: 0x06029877 RID: 170103 RVA: 0x005B08D8 File Offset: 0x005AEAD8
		public ICompareEntityStateCondition ConditionAsICompareEntityStateCondition()
		{
			return this.Condition<ICompareEntityStateCondition>().Value;
		}

		// Token: 0x06029878 RID: 170104 RVA: 0x005B08F4 File Offset: 0x005AEAF4
		public ICompareNpcPerformStateCondition ConditionAsICompareNpcPerformStateCondition()
		{
			return this.Condition<ICompareNpcPerformStateCondition>().Value;
		}

		// Token: 0x06029879 RID: 170105 RVA: 0x005B0910 File Offset: 0x005AEB10
		public ICheckTreasureBeenClaimedCondition ConditionAsICheckTreasureBeenClaimedCondition()
		{
			return this.Condition<ICheckTreasureBeenClaimedCondition>().Value;
		}

		// Token: 0x0602987A RID: 170106 RVA: 0x005B092C File Offset: 0x005AEB2C
		public ICompareEntityGroupStateCondition ConditionAsICompareEntityGroupStateCondition()
		{
			return this.Condition<ICompareEntityGroupStateCondition>().Value;
		}

		// Token: 0x0602987B RID: 170107 RVA: 0x005B0948 File Offset: 0x005AEB48
		public ICompareEntitySelfStateCondition ConditionAsICompareEntitySelfStateCondition()
		{
			return this.Condition<ICompareEntitySelfStateCondition>().Value;
		}

		// Token: 0x0602987C RID: 170108 RVA: 0x005B0964 File Offset: 0x005AEB64
		public ICompareLevelPlayRewardStateCondition ConditionAsICompareLevelPlayRewardStateCondition()
		{
			return this.Condition<ICompareLevelPlayRewardStateCondition>().Value;
		}

		// Token: 0x0602987D RID: 170109 RVA: 0x005B0980 File Offset: 0x005AEB80
		public IHourToHourCondition ConditionAsIHourToHourCondition()
		{
			return this.Condition<IHourToHourCondition>().Value;
		}

		// Token: 0x0602987E RID: 170110 RVA: 0x005B099C File Offset: 0x005AEB9C
		public IRangeSphere ConditionAsIRangeSphere()
		{
			return this.Condition<IRangeSphere>().Value;
		}

		// Token: 0x0602987F RID: 170111 RVA: 0x005B09B8 File Offset: 0x005AEBB8
		public ICheckItems ConditionAsICheckItems()
		{
			return this.Condition<ICheckItems>().Value;
		}

		// Token: 0x06029880 RID: 170112 RVA: 0x005B09D4 File Offset: 0x005AEBD4
		public IHasBuff ConditionAsIHasBuff()
		{
			return this.Condition<IHasBuff>().Value;
		}

		// Token: 0x06029881 RID: 170113 RVA: 0x005B09F0 File Offset: 0x005AEBF0
		public ICheckSystemFunction ConditionAsICheckSystemFunction()
		{
			return this.Condition<ICheckSystemFunction>().Value;
		}

		// Token: 0x06029882 RID: 170114 RVA: 0x005B0A0C File Offset: 0x005AEC0C
		public ICheckAiState ConditionAsICheckAiState()
		{
			return this.Condition<ICheckAiState>().Value;
		}

		// Token: 0x06029883 RID: 170115 RVA: 0x005B0A28 File Offset: 0x005AEC28
		public ICompareDungeonId ConditionAsICompareDungeonId()
		{
			return this.Condition<ICompareDungeonId>().Value;
		}

		// Token: 0x06029884 RID: 170116 RVA: 0x005B0A44 File Offset: 0x005AEC44
		public ICompareTimePeriod ConditionAsICompareTimePeriod()
		{
			return this.Condition<ICompareTimePeriod>().Value;
		}

		// Token: 0x06029885 RID: 170117 RVA: 0x005B0A60 File Offset: 0x005AEC60
		public ICompareWeather ConditionAsICompareWeather()
		{
			return this.Condition<ICompareWeather>().Value;
		}

		// Token: 0x06029886 RID: 170118 RVA: 0x005B0A7C File Offset: 0x005AEC7C
		public ICheckLevelPlayState ConditionAsICheckLevelPlayState()
		{
			return this.Condition<ICheckLevelPlayState>().Value;
		}

		// Token: 0x06029887 RID: 170119 RVA: 0x005B0A98 File Offset: 0x005AEC98
		public ICheckLevelPlayCompleteNumber ConditionAsICheckLevelPlayCompleteNumber()
		{
			return this.Condition<ICheckLevelPlayCompleteNumber>().Value;
		}

		// Token: 0x06029888 RID: 170120 RVA: 0x005B0AB4 File Offset: 0x005AECB4
		public ICheckLevelPlayChildQuestFinished ConditionAsICheckLevelPlayChildQuestFinished()
		{
			return this.Condition<ICheckLevelPlayChildQuestFinished>().Value;
		}

		// Token: 0x06029889 RID: 170121 RVA: 0x005B0AD0 File Offset: 0x005AECD0
		public ICheckCurrentRole ConditionAsICheckCurrentRole()
		{
			return this.Condition<ICheckCurrentRole>().Value;
		}

		// Token: 0x0602988A RID: 170122 RVA: 0x005B0AEC File Offset: 0x005AECEC
		public ICheckPlayerGender ConditionAsICheckPlayerGender()
		{
			return this.Condition<ICheckPlayerGender>().Value;
		}

		// Token: 0x0602988B RID: 170123 RVA: 0x005B0B08 File Offset: 0x005AED08
		public ICheckInCombat ConditionAsICheckInCombat()
		{
			return this.Condition<ICheckInCombat>().Value;
		}

		// Token: 0x0602988C RID: 170124 RVA: 0x005B0B24 File Offset: 0x005AED24
		public ICheckHasFollowShooter ConditionAsICheckHasFollowShooter()
		{
			return this.Condition<ICheckHasFollowShooter>().Value;
		}

		// Token: 0x0602988D RID: 170125 RVA: 0x005B0B40 File Offset: 0x005AED40
		public ICheckFollowShooterActive ConditionAsICheckFollowShooterActive()
		{
			return this.Condition<ICheckFollowShooterActive>().Value;
		}

		// Token: 0x0602988E RID: 170126 RVA: 0x005B0B5C File Offset: 0x005AED5C
		public ICheckChildQuestFinished ConditionAsICheckChildQuestFinished()
		{
			return this.Condition<ICheckChildQuestFinished>().Value;
		}

		// Token: 0x0602988F RID: 170127 RVA: 0x005B0B78 File Offset: 0x005AED78
		public ICheckSyncLevelPlayCompleteNumber ConditionAsICheckSyncLevelPlayCompleteNumber()
		{
			return this.Condition<ICheckSyncLevelPlayCompleteNumber>().Value;
		}

		// Token: 0x06029890 RID: 170128 RVA: 0x005B0B94 File Offset: 0x005AED94
		public ICheckCrossSceneSyncKillMonsterFinished ConditionAsICheckCrossSceneSyncKillMonsterFinished()
		{
			return this.Condition<ICheckCrossSceneSyncKillMonsterFinished>().Value;
		}

		// Token: 0x06029891 RID: 170129 RVA: 0x005B0BB0 File Offset: 0x005AEDB0
		public ICheckNodeStatus ConditionAsICheckNodeStatus()
		{
			return this.Condition<ICheckNodeStatus>().Value;
		}

		// Token: 0x06029892 RID: 170130 RVA: 0x005B0BCC File Offset: 0x005AEDCC
		public ICheckChildQuestStatus ConditionAsICheckChildQuestStatus()
		{
			return this.Condition<ICheckChildQuestStatus>().Value;
		}

		// Token: 0x06029893 RID: 170131 RVA: 0x005B0BE8 File Offset: 0x005AEDE8
		public ICheckEntitiesExist ConditionAsICheckEntitiesExist()
		{
			return this.Condition<ICheckEntitiesExist>().Value;
		}

		// Token: 0x06029894 RID: 170132 RVA: 0x005B0C04 File Offset: 0x005AEE04
		public ICheckPlayerPosition ConditionAsICheckPlayerPosition()
		{
			return this.Condition<ICheckPlayerPosition>().Value;
		}

		// Token: 0x06029895 RID: 170133 RVA: 0x005B0C20 File Offset: 0x005AEE20
		public ICheckEntityPosition ConditionAsICheckEntityPosition()
		{
			return this.Condition<ICheckEntityPosition>().Value;
		}

		// Token: 0x06029896 RID: 170134 RVA: 0x005B0C3C File Offset: 0x005AEE3C
		public ICheckDungeonFinish ConditionAsICheckDungeonFinish()
		{
			return this.Condition<ICheckDungeonFinish>().Value;
		}

		// Token: 0x06029897 RID: 170135 RVA: 0x005B0C58 File Offset: 0x005AEE58
		public ICheckEntityIsVisibility ConditionAsICheckEntityIsVisibility()
		{
			return this.Condition<ICheckEntityIsVisibility>().Value;
		}

		// Token: 0x06029898 RID: 170136 RVA: 0x005B0C74 File Offset: 0x005AEE74
		public IComparePlayerMotionState ConditionAsIComparePlayerMotionState()
		{
			return this.Condition<IComparePlayerMotionState>().Value;
		}

		// Token: 0x06029899 RID: 170137 RVA: 0x005B0C90 File Offset: 0x005AEE90
		public IComparePlayerMotionState2 ConditionAsIComparePlayerMotionState2()
		{
			return this.Condition<IComparePlayerMotionState2>().Value;
		}

		// Token: 0x0602989A RID: 170138 RVA: 0x005B0CAC File Offset: 0x005AEEAC
		public ICheckDataLayerCondition ConditionAsICheckDataLayerCondition()
		{
			return this.Condition<ICheckDataLayerCondition>().Value;
		}

		// Token: 0x0602989B RID: 170139 RVA: 0x005B0CC8 File Offset: 0x005AEEC8
		public ICheckHookLockPointCondition ConditionAsICheckHookLockPointCondition()
		{
			return this.Condition<ICheckHookLockPointCondition>().Value;
		}

		// Token: 0x0602989C RID: 170140 RVA: 0x005B0CE4 File Offset: 0x005AEEE4
		public ICheckPlayerSkillReadyCondition ConditionAsICheckPlayerSkillReadyCondition()
		{
			return this.Condition<ICheckPlayerSkillReadyCondition>().Value;
		}

		// Token: 0x0602989D RID: 170141 RVA: 0x005B0D00 File Offset: 0x005AEF00
		public ICheckPlayerUseSkillCondition ConditionAsICheckPlayerUseSkillCondition()
		{
			return this.Condition<ICheckPlayerUseSkillCondition>().Value;
		}

		// Token: 0x0602989E RID: 170142 RVA: 0x005B0D1C File Offset: 0x005AEF1C
		public ICheckPlayerStateRestrictionCondition ConditionAsICheckPlayerStateRestrictionCondition()
		{
			return this.Condition<ICheckPlayerStateRestrictionCondition>().Value;
		}

		// Token: 0x0602989F RID: 170143 RVA: 0x005B0D38 File Offset: 0x005AEF38
		public ICheckLordGymFinishCondition ConditionAsICheckLordGymFinishCondition()
		{
			return this.Condition<ICheckLordGymFinishCondition>().Value;
		}

		// Token: 0x060298A0 RID: 170144 RVA: 0x005B0D54 File Offset: 0x005AEF54
		public ICheckCalabashDevelopRewardCondition ConditionAsICheckCalabashDevelopRewardCondition()
		{
			return this.Condition<ICheckCalabashDevelopRewardCondition>().Value;
		}

		// Token: 0x060298A1 RID: 170145 RVA: 0x005B0D70 File Offset: 0x005AEF70
		public ICompareFishingPrestigeLevelCondition ConditionAsICompareFishingPrestigeLevelCondition()
		{
			return this.Condition<ICompareFishingPrestigeLevelCondition>().Value;
		}

		// Token: 0x060298A2 RID: 170146 RVA: 0x005B0D8C File Offset: 0x005AEF8C
		public ICheckCertainFishingItemCount ConditionAsICheckCertainFishingItemCount()
		{
			return this.Condition<ICheckCertainFishingItemCount>().Value;
		}

		// Token: 0x060298A3 RID: 170147 RVA: 0x005B0DA8 File Offset: 0x005AEFA8
		public ICompleteCertainFishingEntrust ConditionAsICompleteCertainFishingEntrust()
		{
			return this.Condition<ICompleteCertainFishingEntrust>().Value;
		}

		// Token: 0x060298A4 RID: 170148 RVA: 0x005B0DC4 File Offset: 0x005AEFC4
		public ICompareFishingBoatState ConditionAsICompareFishingBoatState()
		{
			return this.Condition<ICompareFishingBoatState>().Value;
		}

		// Token: 0x060298A5 RID: 170149 RVA: 0x005B0DE0 File Offset: 0x005AEFE0
		public ICheckJigsawInfoCondition ConditionAsICheckJigsawInfoCondition()
		{
			return this.Condition<ICheckJigsawInfoCondition>().Value;
		}

		// Token: 0x060298A6 RID: 170150 RVA: 0x005B0DFC File Offset: 0x005AEFFC
		public ICheckGameplayTagCondition ConditionAsICheckGameplayTagCondition()
		{
			return this.Condition<ICheckGameplayTagCondition>().Value;
		}

		// Token: 0x060298A7 RID: 170151 RVA: 0x005B0E18 File Offset: 0x005AF018
		public ICheckFormationRoleInfoCondition ConditionAsICheckFormationRoleInfoCondition()
		{
			return this.Condition<ICheckFormationRoleInfoCondition>().Value;
		}

		// Token: 0x060298A8 RID: 170152 RVA: 0x005B0E34 File Offset: 0x005AF034
		public ICheckTargetAttributeCondition ConditionAsICheckTargetAttributeCondition()
		{
			return this.Condition<ICheckTargetAttributeCondition>().Value;
		}

		// Token: 0x060298A9 RID: 170153 RVA: 0x005B0E50 File Offset: 0x005AF050
		public ICheckRogueAbilitySelectCondition ConditionAsICheckRogueAbilitySelectCondition()
		{
			return this.Condition<ICheckRogueAbilitySelectCondition>().Value;
		}

		// Token: 0x060298AA RID: 170154 RVA: 0x005B0E6C File Offset: 0x005AF06C
		public ICheckDirectionCondition ConditionAsICheckDirectionCondition()
		{
			return this.Condition<ICheckDirectionCondition>().Value;
		}

		// Token: 0x060298AB RID: 170155 RVA: 0x005B0E88 File Offset: 0x005AF088
		public ICheckSceneItemDirectionCondition ConditionAsICheckSceneItemDirectionCondition()
		{
			return this.Condition<ICheckSceneItemDirectionCondition>().Value;
		}

		// Token: 0x060298AC RID: 170156 RVA: 0x005B0EA4 File Offset: 0x005AF0A4
		public ICheckPlayerFaceToCondition ConditionAsICheckPlayerFaceToCondition()
		{
			return this.Condition<ICheckPlayerFaceToCondition>().Value;
		}

		// Token: 0x060298AD RID: 170157 RVA: 0x005B0EC0 File Offset: 0x005AF0C0
		public ICheckPlayerCanJoinActivityCondition ConditionAsICheckPlayerCanJoinActivityCondition()
		{
			return this.Condition<ICheckPlayerCanJoinActivityCondition>().Value;
		}

		// Token: 0x060298AE RID: 170158 RVA: 0x005B0EDC File Offset: 0x005AF0DC
		public ICheckSystemStateCondition ConditionAsICheckSystemStateCondition()
		{
			return this.Condition<ICheckSystemStateCondition>().Value;
		}

		// Token: 0x060298AF RID: 170159 RVA: 0x005B0EF8 File Offset: 0x005AF0F8
		public ICheckInRangeCondition ConditionAsICheckInRangeCondition()
		{
			return this.Condition<ICheckInRangeCondition>().Value;
		}

		// Token: 0x060298B0 RID: 170160 RVA: 0x005B0F14 File Offset: 0x005AF114
		public ICheckInRangeProperlyCondition ConditionAsICheckInRangeProperlyCondition()
		{
			return this.Condition<ICheckInRangeProperlyCondition>().Value;
		}

		// Token: 0x060298B1 RID: 170161 RVA: 0x005B0F30 File Offset: 0x005AF130
		public ICheckEntityLockedCondition ConditionAsICheckEntityLockedCondition()
		{
			return this.Condition<ICheckEntityLockedCondition>().Value;
		}

		// Token: 0x060298B2 RID: 170162 RVA: 0x005B0F4C File Offset: 0x005AF14C
		public ICompareTeammateDieCondition ConditionAsICompareTeammateDieCondition()
		{
			return this.Condition<ICompareTeammateDieCondition>().Value;
		}

		// Token: 0x060298B3 RID: 170163 RVA: 0x005B0F68 File Offset: 0x005AF168
		public IListenEntitySelfEventCondition ConditionAsIListenEntitySelfEventCondition()
		{
			return this.Condition<IListenEntitySelfEventCondition>().Value;
		}

		// Token: 0x060298B4 RID: 170164 RVA: 0x005B0F84 File Offset: 0x005AF184
		public ICheckEntityDistanceCondition ConditionAsICheckEntityDistanceCondition()
		{
			return this.Condition<ICheckEntityDistanceCondition>().Value;
		}

		// Token: 0x060298B5 RID: 170165 RVA: 0x005B0FA0 File Offset: 0x005AF1A0
		public ICheckEntityHasSceneItemAttributeTag ConditionAsICheckEntityHasSceneItemAttributeTag()
		{
			return this.Condition<ICheckEntityHasSceneItemAttributeTag>().Value;
		}

		// Token: 0x060298B6 RID: 170166 RVA: 0x005B0FBC File Offset: 0x005AF1BC
		public IListenEntityThroughPortal ConditionAsIListenEntityThroughPortal()
		{
			return this.Condition<IListenEntityThroughPortal>().Value;
		}

		// Token: 0x060298B7 RID: 170167 RVA: 0x005B0FD8 File Offset: 0x005AF1D8
		public ICheckTeleControlState ConditionAsICheckTeleControlState()
		{
			return this.Condition<ICheckTeleControlState>().Value;
		}

		// Token: 0x060298B8 RID: 170168 RVA: 0x005B0FF4 File Offset: 0x005AF1F4
		public ICustomJsonCondition ConditionAsICustomJsonCondition()
		{
			return this.Condition<ICustomJsonCondition>().Value;
		}

		// Token: 0x060298B9 RID: 170169 RVA: 0x005B1010 File Offset: 0x005AF210
		public ICheckChessWinner ConditionAsICheckChessWinner()
		{
			return this.Condition<ICheckChessWinner>().Value;
		}

		// Token: 0x060298BA RID: 170170 RVA: 0x005B102C File Offset: 0x005AF22C
		public ICheckVehicleCondition ConditionAsICheckVehicleCondition()
		{
			return this.Condition<ICheckVehicleCondition>().Value;
		}

		// Token: 0x060298BB RID: 170171 RVA: 0x005B1048 File Offset: 0x005AF248
		public ICompareAlertValue ConditionAsICompareAlertValue()
		{
			return this.Condition<ICompareAlertValue>().Value;
		}

		// Token: 0x060298BC RID: 170172 RVA: 0x005B1064 File Offset: 0x005AF264
		public ICheckEntityGravityDirection ConditionAsICheckEntityGravityDirection()
		{
			return this.Condition<ICheckEntityGravityDirection>().Value;
		}

		// Token: 0x060298BD RID: 170173 RVA: 0x005B1080 File Offset: 0x005AF280
		public ICheckCollectAnimalParts ConditionAsICheckCollectAnimalParts()
		{
			return this.Condition<ICheckCollectAnimalParts>().Value;
		}

		// Token: 0x060298BE RID: 170174 RVA: 0x005B109C File Offset: 0x005AF29C
		public ICheckFinishLoading ConditionAsICheckFinishLoading()
		{
			return this.Condition<ICheckFinishLoading>().Value;
		}

		// Token: 0x060298BF RID: 170175 RVA: 0x005B10B8 File Offset: 0x005AF2B8
		public ICheckFishingPointHasFish ConditionAsICheckFishingPointHasFish()
		{
			return this.Condition<ICheckFishingPointHasFish>().Value;
		}

		// Token: 0x060298C0 RID: 170176 RVA: 0x005B10D4 File Offset: 0x005AF2D4
		public ICheckFishingCageFillingRatio ConditionAsICheckFishingCageFillingRatio()
		{
			return this.Condition<ICheckFishingCageFillingRatio>().Value;
		}

		// Token: 0x060298C1 RID: 170177 RVA: 0x005B10F0 File Offset: 0x005AF2F0
		public ICompareFishingTechLevel ConditionAsICompareFishingTechLevel()
		{
			return this.Condition<ICompareFishingTechLevel>().Value;
		}

		// Token: 0x060298C2 RID: 170178 RVA: 0x005B110C File Offset: 0x005AF30C
		public ICheckGuestCharacter ConditionAsICheckGuestCharacter()
		{
			return this.Condition<ICheckGuestCharacter>().Value;
		}

		// Token: 0x060298C3 RID: 170179 RVA: 0x005B1128 File Offset: 0x005AF328
		public ICheckSubLevelState ConditionAsICheckSubLevelState()
		{
			return this.Condition<ICheckSubLevelState>().Value;
		}

		// Token: 0x060298C4 RID: 170180 RVA: 0x005B1144 File Offset: 0x005AF344
		public IComparePlayerNumInDungeon ConditionAsIComparePlayerNumInDungeon()
		{
			return this.Condition<IComparePlayerNumInDungeon>().Value;
		}

		// Token: 0x060298C5 RID: 170181 RVA: 0x005B1160 File Offset: 0x005AF360
		public ICheckAlertAreaEnabled ConditionAsICheckAlertAreaEnabled()
		{
			return this.Condition<ICheckAlertAreaEnabled>().Value;
		}

		// Token: 0x060298C6 RID: 170182 RVA: 0x005B117C File Offset: 0x005AF37C
		public ICheckClientEvent ConditionAsICheckClientEvent()
		{
			return this.Condition<ICheckClientEvent>().Value;
		}

		// Token: 0x060298C7 RID: 170183 RVA: 0x005B1198 File Offset: 0x005AF398
		public ICheckIsGramophonePlayingMusic ConditionAsICheckIsGramophonePlayingMusic()
		{
			return this.Condition<ICheckIsGramophonePlayingMusic>().Value;
		}

		// Token: 0x060298C8 RID: 170184 RVA: 0x005B11B4 File Offset: 0x005AF3B4
		public ICheckEntityReward ConditionAsICheckEntityReward()
		{
			return this.Condition<ICheckEntityReward>().Value;
		}

		// Token: 0x060298C9 RID: 170185 RVA: 0x005B11D0 File Offset: 0x005AF3D0
		public ICheckDungeonHasSaveConfig ConditionAsICheckDungeonHasSaveConfig()
		{
			return this.Condition<ICheckDungeonHasSaveConfig>().Value;
		}

		// Token: 0x060298CA RID: 170186 RVA: 0x005B11EC File Offset: 0x005AF3EC
		public ICheckSystemEventBvb ConditionAsICheckSystemEventBvb()
		{
			return this.Condition<ICheckSystemEventBvb>().Value;
		}

		// Token: 0x060298CB RID: 170187 RVA: 0x005B1208 File Offset: 0x005AF408
		public ICheckDangoCultivationProgress ConditionAsICheckDangoCultivationProgress()
		{
			return this.Condition<ICheckDangoCultivationProgress>().Value;
		}

		// Token: 0x060298CC RID: 170188 RVA: 0x005B1224 File Offset: 0x005AF424
		public ICheckPlayerMoraleLevelRange ConditionAsICheckPlayerMoraleLevelRange()
		{
			return this.Condition<ICheckPlayerMoraleLevelRange>().Value;
		}

		// Token: 0x060298CD RID: 170189 RVA: 0x005B1240 File Offset: 0x005AF440
		public ICheckIsGlobalTimeScaleEnabled ConditionAsICheckIsGlobalTimeScaleEnabled()
		{
			return this.Condition<ICheckIsGlobalTimeScaleEnabled>().Value;
		}

		// Token: 0x060298CE RID: 170190 RVA: 0x005B125C File Offset: 0x005AF45C
		public ISaveConfigEnterMethod ConditionAsISaveConfigEnterMethod()
		{
			return this.Condition<ISaveConfigEnterMethod>().Value;
		}

		// Token: 0x060298CF RID: 170191 RVA: 0x005B1278 File Offset: 0x005AF478
		public ICheckIsEntityTimeScaleEnabled ConditionAsICheckIsEntityTimeScaleEnabled()
		{
			return this.Condition<ICheckIsEntityTimeScaleEnabled>().Value;
		}

		// Token: 0x060298D0 RID: 170192 RVA: 0x005B1294 File Offset: 0x005AF494
		public ICheckIsCharacterHoldingHands ConditionAsICheckIsCharacterHoldingHands()
		{
			return this.Condition<ICheckIsCharacterHoldingHands>().Value;
		}

		// Token: 0x060298D1 RID: 170193 RVA: 0x005B12B0 File Offset: 0x005AF4B0
		public ICheckIsTrackingCurrentQuest ConditionAsICheckIsTrackingCurrentQuest()
		{
			return this.Condition<ICheckIsTrackingCurrentQuest>().Value;
		}

		// Token: 0x060298D2 RID: 170194 RVA: 0x005B12CC File Offset: 0x005AF4CC
		public ICheckIsTrackingQuest ConditionAsICheckIsTrackingQuest()
		{
			return this.Condition<ICheckIsTrackingQuest>().Value;
		}

		// Token: 0x060298D3 RID: 170195 RVA: 0x005B12E8 File Offset: 0x005AF4E8
		public ICheckMusicEvent ConditionAsICheckMusicEvent()
		{
			return this.Condition<ICheckMusicEvent>().Value;
		}

		// Token: 0x060298D4 RID: 170196 RVA: 0x005B1304 File Offset: 0x005AF504
		public ICompareGameDifficulty ConditionAsICompareGameDifficulty()
		{
			return this.Condition<ICompareGameDifficulty>().Value;
		}

		// Token: 0x060298D5 RID: 170197 RVA: 0x005B1320 File Offset: 0x005AF520
		public ICheckPhotographCameraParam ConditionAsICheckPhotographCameraParam()
		{
			return this.Condition<ICheckPhotographCameraParam>().Value;
		}

		// Token: 0x060298D6 RID: 170198 RVA: 0x005B133C File Offset: 0x005AF53C
		public ICheckEntityHasBuff ConditionAsICheckEntityHasBuff()
		{
			return this.Condition<ICheckEntityHasBuff>().Value;
		}

		// Token: 0x060298D7 RID: 170199 RVA: 0x005B1358 File Offset: 0x005AF558
		public ICheckEntityBuffStack ConditionAsICheckEntityBuffStack()
		{
			return this.Condition<ICheckEntityBuffStack>().Value;
		}

		// Token: 0x060298D8 RID: 170200 RVA: 0x005B1374 File Offset: 0x005AF574
		public ICheckAvailableSunSpiritCount ConditionAsICheckAvailableSunSpiritCount()
		{
			return this.Condition<ICheckAvailableSunSpiritCount>().Value;
		}

		// Token: 0x060298D9 RID: 170201 RVA: 0x005B1390 File Offset: 0x005AF590
		public ICheckPlayerEnterClientTriggerDir ConditionAsICheckPlayerEnterClientTriggerDir()
		{
			return this.Condition<ICheckPlayerEnterClientTriggerDir>().Value;
		}

		// Token: 0x060298DA RID: 170202 RVA: 0x005B13AC File Offset: 0x005AF5AC
		public ICheckPlayerRelativeDistance ConditionAsICheckPlayerRelativeDistance()
		{
			return this.Condition<ICheckPlayerRelativeDistance>().Value;
		}

		// Token: 0x060298DB RID: 170203 RVA: 0x005B13C8 File Offset: 0x005AF5C8
		public ICheckPlayerRelativeAngle ConditionAsICheckPlayerRelativeAngle()
		{
			return this.Condition<ICheckPlayerRelativeAngle>().Value;
		}

		// Token: 0x060298DC RID: 170204 RVA: 0x005B13E4 File Offset: 0x005AF5E4
		public ICheckHonamiStoryGetItem ConditionAsICheckHonamiStoryGetItem()
		{
			return this.Condition<ICheckHonamiStoryGetItem>().Value;
		}

		// Token: 0x060298DD RID: 170205 RVA: 0x005B1400 File Offset: 0x005AF600
		public ICheckHonamiStoryEquipItem ConditionAsICheckHonamiStoryEquipItem()
		{
			return this.Condition<ICheckHonamiStoryEquipItem>().Value;
		}

		// Token: 0x060298DE RID: 170206 RVA: 0x005B141C File Offset: 0x005AF61C
		public ICheckHonamiStoryActivateTalent ConditionAsICheckHonamiStoryActivateTalent()
		{
			return this.Condition<ICheckHonamiStoryActivateTalent>().Value;
		}

		// Token: 0x060298DF RID: 170207 RVA: 0x005B1438 File Offset: 0x005AF638
		public ICheckHonamiStoryUnlockSlot ConditionAsICheckHonamiStoryUnlockSlot()
		{
			return this.Condition<ICheckHonamiStoryUnlockSlot>().Value;
		}

		// Token: 0x060298E0 RID: 170208 RVA: 0x005B1454 File Offset: 0x005AF654
		public ICheckHonamiStoryLifeSupportLevel ConditionAsICheckHonamiStoryLifeSupportLevel()
		{
			return this.Condition<ICheckHonamiStoryLifeSupportLevel>().Value;
		}

		// Token: 0x060298E1 RID: 170209 RVA: 0x005B1470 File Offset: 0x005AF670
		public ICheckHonamiStoryTowerComplete ConditionAsICheckHonamiStoryTowerComplete()
		{
			return this.Condition<ICheckHonamiStoryTowerComplete>().Value;
		}

		// Token: 0x060298E2 RID: 170210 RVA: 0x005B148C File Offset: 0x005AF68C
		public ICheckHonamiStoryPlayerCorruptedLevel ConditionAsICheckHonamiStoryPlayerCorruptedLevel()
		{
			return this.Condition<ICheckHonamiStoryPlayerCorruptedLevel>().Value;
		}

		// Token: 0x060298E3 RID: 170211 RVA: 0x005B14A8 File Offset: 0x005AF6A8
		public ICheckHonamiStoryUnlockMascot ConditionAsICheckHonamiStoryUnlockMascot()
		{
			return this.Condition<ICheckHonamiStoryUnlockMascot>().Value;
		}

		// Token: 0x060298E4 RID: 170212 RVA: 0x005B14C4 File Offset: 0x005AF6C4
		public ICheckHonamiStoryChestOpenTime ConditionAsICheckHonamiStoryChestOpenTime()
		{
			return this.Condition<ICheckHonamiStoryChestOpenTime>().Value;
		}

		// Token: 0x060298E5 RID: 170213 RVA: 0x005B14E0 File Offset: 0x005AF6E0
		public ICheckHonamiStorySuccessfulEvacuation ConditionAsICheckHonamiStorySuccessfulEvacuation()
		{
			return this.Condition<ICheckHonamiStorySuccessfulEvacuation>().Value;
		}

		// Token: 0x060298E6 RID: 170214 RVA: 0x005B14FC File Offset: 0x005AF6FC
		public ICheckBvbChallengeState ConditionAsICheckBvbChallengeState()
		{
			return this.Condition<ICheckBvbChallengeState>().Value;
		}

		// Token: 0x060298E7 RID: 170215 RVA: 0x005B1518 File Offset: 0x005AF718
		public ICheckBvbActivityRank ConditionAsICheckBvbActivityRank()
		{
			return this.Condition<ICheckBvbActivityRank>().Value;
		}

		// Token: 0x060298E8 RID: 170216 RVA: 0x005B1534 File Offset: 0x005AF734
		public ICheckCollectedSunSpiritCount ConditionAsICheckCollectedSunSpiritCount()
		{
			return this.Condition<ICheckCollectedSunSpiritCount>().Value;
		}

		// Token: 0x060298E9 RID: 170217 RVA: 0x005B1550 File Offset: 0x005AF750
		public ICheckTargetSunSpiritCollected ConditionAsICheckTargetSunSpiritCollected()
		{
			return this.Condition<ICheckTargetSunSpiritCollected>().Value;
		}

		// Token: 0x060298EA RID: 170218 RVA: 0x005B156C File Offset: 0x005AF76C
		public ICheckPlayerIsInDeadEyeProcess ConditionAsICheckPlayerIsInDeadEyeProcess()
		{
			return this.Condition<ICheckPlayerIsInDeadEyeProcess>().Value;
		}

		// Token: 0x060298EB RID: 170219 RVA: 0x005B1588 File Offset: 0x005AF788
		public ICheckEntitySelfDirection ConditionAsICheckEntitySelfDirection()
		{
			return this.Condition<ICheckEntitySelfDirection>().Value;
		}

		// Token: 0x060298EC RID: 170220 RVA: 0x005B15A4 File Offset: 0x005AF7A4
		public ICheckDollGrabItemComboAchievedInOnceDelivery ConditionAsICheckDollGrabItemComboAchievedInOnceDelivery()
		{
			return this.Condition<ICheckDollGrabItemComboAchievedInOnceDelivery>().Value;
		}

		// Token: 0x060298ED RID: 170221 RVA: 0x005B15C0 File Offset: 0x005AF7C0
		public ICheckDollGrabShowcaseItemComboAchieved ConditionAsICheckDollGrabShowcaseItemComboAchieved()
		{
			return this.Condition<ICheckDollGrabShowcaseItemComboAchieved>().Value;
		}

		// Token: 0x060298EE RID: 170222 RVA: 0x005B15DC File Offset: 0x005AF7DC
		public ICheckRoverRogueAbilitySelectCondition ConditionAsICheckRoverRogueAbilitySelectCondition()
		{
			return this.Condition<ICheckRoverRogueAbilitySelectCondition>().Value;
		}

		// Token: 0x060298EF RID: 170223 RVA: 0x005B15F8 File Offset: 0x005AF7F8
		public ICheckDollGrabMachineFinished ConditionAsICheckDollGrabMachineFinished()
		{
			return this.Condition<ICheckDollGrabMachineFinished>().Value;
		}

		// Token: 0x060298F0 RID: 170224 RVA: 0x005B1614 File Offset: 0x005AF814
		public ICheckTrafficBlocked ConditionAsICheckTrafficBlocked()
		{
			return this.Condition<ICheckTrafficBlocked>().Value;
		}

		// Token: 0x060298F1 RID: 170225 RVA: 0x005B1630 File Offset: 0x005AF830
		public ICheckDrinksPreferenceLevel ConditionAsICheckDrinksPreferenceLevel()
		{
			return this.Condition<ICheckDrinksPreferenceLevel>().Value;
		}

		// Token: 0x060298F2 RID: 170226 RVA: 0x005B164C File Offset: 0x005AF84C
		public ICheckPlayerIsInMotorcycleCruise ConditionAsICheckPlayerIsInMotorcycleCruise()
		{
			return this.Condition<ICheckPlayerIsInMotorcycleCruise>().Value;
		}

		// Token: 0x060298F3 RID: 170227 RVA: 0x005B1668 File Offset: 0x005AF868
		public ICheckTetrisEndlessScore ConditionAsICheckTetrisEndlessScore()
		{
			return this.Condition<ICheckTetrisEndlessScore>().Value;
		}

		// Token: 0x060298F4 RID: 170228 RVA: 0x005B1684 File Offset: 0x005AF884
		public ICheckAtlasUnlocked ConditionAsICheckAtlasUnlocked()
		{
			return this.Condition<ICheckAtlasUnlocked>().Value;
		}

		// Token: 0x060298F5 RID: 170229 RVA: 0x005B16A0 File Offset: 0x005AF8A0
		public ICheckSheriffUnlockEnding ConditionAsICheckSheriffUnlockEnding()
		{
			return this.Condition<ICheckSheriffUnlockEnding>().Value;
		}

		// Token: 0x060298F6 RID: 170230 RVA: 0x005B16BC File Offset: 0x005AF8BC
		public ICheckIsInDragActorPlay ConditionAsICheckIsInDragActorPlay()
		{
			return this.Condition<ICheckIsInDragActorPlay>().Value;
		}

		// Token: 0x060298F7 RID: 170231 RVA: 0x005B16D8 File Offset: 0x005AF8D8
		public ICheckIsInDollGrabGamePlay ConditionAsICheckIsInDollGrabGamePlay()
		{
			return this.Condition<ICheckIsInDollGrabGamePlay>().Value;
		}

		// Token: 0x060298F8 RID: 170232 RVA: 0x005B16F4 File Offset: 0x005AF8F4
		public ICheckEntityPrefabPerformanceType ConditionAsICheckEntityPrefabPerformanceType()
		{
			return this.Condition<ICheckEntityPrefabPerformanceType>().Value;
		}

		// Token: 0x060298F9 RID: 170233 RVA: 0x005B1710 File Offset: 0x005AF910
		public ICheckIsSupportedWalking ConditionAsICheckIsSupportedWalking()
		{
			return this.Condition<ICheckIsSupportedWalking>().Value;
		}

		// Token: 0x060298FA RID: 170234 RVA: 0x005B172C File Offset: 0x005AF92C
		public ICheckGiantStableValue ConditionAsICheckGiantStableValue()
		{
			return this.Condition<ICheckGiantStableValue>().Value;
		}

		// Token: 0x060298FB RID: 170235 RVA: 0x005B1748 File Offset: 0x005AF948
		public ICheckGiantTotalProgressCanActivateNode ConditionAsICheckGiantTotalProgressCanActivateNode()
		{
			return this.Condition<ICheckGiantTotalProgressCanActivateNode>().Value;
		}

		// Token: 0x060298FC RID: 170236 RVA: 0x005B1764 File Offset: 0x005AF964
		public ICheckGiantTotalProgressInteractActivatedNode ConditionAsICheckGiantTotalProgressInteractActivatedNode()
		{
			return this.Condition<ICheckGiantTotalProgressInteractActivatedNode>().Value;
		}

		// Token: 0x060298FD RID: 170237 RVA: 0x005B1780 File Offset: 0x005AF980
		public ICheckGiantRegionCultivationTriggeredUpgradeLevel ConditionAsICheckGiantRegionCultivationTriggeredUpgradeLevel()
		{
			return this.Condition<ICheckGiantRegionCultivationTriggeredUpgradeLevel>().Value;
		}

		// Token: 0x060298FE RID: 170238 RVA: 0x005B179C File Offset: 0x005AF99C
		public ICheckElementalBoxState ConditionAsICheckElementalBoxState()
		{
			return this.Condition<ICheckElementalBoxState>().Value;
		}

		// Token: 0x060298FF RID: 170239 RVA: 0x005B17B8 File Offset: 0x005AF9B8
		public ICheckIsTargetHoldElementalBox ConditionAsICheckIsTargetHoldElementalBox()
		{
			return this.Condition<ICheckIsTargetHoldElementalBox>().Value;
		}

		// Token: 0x06029900 RID: 170240 RVA: 0x005B17D4 File Offset: 0x005AF9D4
		public ICheckElementalEffectActive ConditionAsICheckElementalEffectActive()
		{
			return this.Condition<ICheckElementalEffectActive>().Value;
		}

		// Token: 0x06029901 RID: 170241 RVA: 0x005B17F0 File Offset: 0x005AF9F0
		public ICheckElementalWaterBoxStagnationSeq ConditionAsICheckElementalWaterBoxStagnationSeq()
		{
			return this.Condition<ICheckElementalWaterBoxStagnationSeq>().Value;
		}

		// Token: 0x06029902 RID: 170242 RVA: 0x005B180B File Offset: 0x005AFA0B
		public static Offset<ICommonBtConditionInfo> CreateICommonBtConditionInfo(FlatBufferBuilder builder, int TaskId = 0, ICondition2_Union Condition_type = ICondition2_Union.NONE, int ConditionOffset = 0)
		{
			builder.StartTable(3);
			ICommonBtConditionInfo.AddCondition(builder, ConditionOffset);
			ICommonBtConditionInfo.AddTaskId(builder, TaskId);
			ICommonBtConditionInfo.AddConditionType(builder, Condition_type);
			return ICommonBtConditionInfo.EndICommonBtConditionInfo(builder);
		}

		// Token: 0x06029903 RID: 170243 RVA: 0x005B182F File Offset: 0x005AFA2F
		public static void StartICommonBtConditionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029904 RID: 170244 RVA: 0x005B1838 File Offset: 0x005AFA38
		public static void AddTaskId(FlatBufferBuilder builder, int taskId)
		{
			builder.AddInt(0, taskId, 0);
		}

		// Token: 0x06029905 RID: 170245 RVA: 0x005B1843 File Offset: 0x005AFA43
		public static void AddConditionType(FlatBufferBuilder builder, ICondition2_Union conditionType)
		{
			builder.AddByte(1, (byte)conditionType, 0);
		}

		// Token: 0x06029906 RID: 170246 RVA: 0x005B184E File Offset: 0x005AFA4E
		public static void AddCondition(FlatBufferBuilder builder, int conditionOffset)
		{
			builder.AddOffset(2, conditionOffset, 0);
		}

		// Token: 0x06029907 RID: 170247 RVA: 0x005B1859 File Offset: 0x005AFA59
		public static Offset<ICommonBtConditionInfo> EndICommonBtConditionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtConditionInfo>(builder.EndTable());
		}

		// Token: 0x06029908 RID: 170248 RVA: 0x005B1868 File Offset: 0x005AFA68
		public ICommonBtConditionInfoT UnPack()
		{
			ICommonBtConditionInfoT commonBtConditionInfoT = new ICommonBtConditionInfoT();
			this.UnPackTo(commonBtConditionInfoT);
			return commonBtConditionInfoT;
		}

		// Token: 0x06029909 RID: 170249 RVA: 0x005B1884 File Offset: 0x005AFA84
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

		// Token: 0x0602990A RID: 170250 RVA: 0x005B3C70 File Offset: 0x005B1E70
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

		// Token: 0x0400F91F RID: 63775
		private Table __p;
	}
}
