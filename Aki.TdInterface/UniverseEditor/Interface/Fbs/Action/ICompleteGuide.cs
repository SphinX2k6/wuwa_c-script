using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064B9 RID: 25785
	public struct ICompleteGuide : IFlatbufferObject
	{
		// Token: 0x1700BFD9 RID: 49113
		// (get) Token: 0x0602CB50 RID: 183120 RVA: 0x00622B82 File Offset: 0x00620D82
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CB51 RID: 183121 RVA: 0x00622B8F File Offset: 0x00620D8F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CB52 RID: 183122 RVA: 0x00622B98 File Offset: 0x00620D98
		public static ICompleteGuide GetRootAsICompleteGuide(ByteBuffer _bb)
		{
			return ICompleteGuide.GetRootAsICompleteGuide(_bb, default(ICompleteGuide));
		}

		// Token: 0x0602CB53 RID: 183123 RVA: 0x00622BB4 File Offset: 0x00620DB4
		public static ICompleteGuide GetRootAsICompleteGuide(ByteBuffer _bb, ICompleteGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CB54 RID: 183124 RVA: 0x00622BD1 File Offset: 0x00620DD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CB55 RID: 183125 RVA: 0x00622BE0 File Offset: 0x00620DE0
		public ICompleteGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFDA RID: 49114
		// (get) Token: 0x0602CB56 RID: 183126 RVA: 0x00622BF0 File Offset: 0x00620DF0
		public EGuideTriggerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGuideTriggerType.BeginnerGuide;
				}
				return (EGuideTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB57 RID: 183127 RVA: 0x00622C2C File Offset: 0x00620E2C
		public ICondition2_Union ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return ICondition2_Union.NONE;
			}
			return (ICondition2_Union)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BFDB RID: 49115
		// (get) Token: 0x0602CB58 RID: 183128 RVA: 0x00622C6C File Offset: 0x00620E6C
		public int ConditionsTypeLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602CB59 RID: 183129 RVA: 0x00622C97 File Offset: 0x00620E97
		public Span<ICondition2_Union> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<ICondition2_Union>(6, 1);
		}

		// Token: 0x0602CB5A RID: 183130 RVA: 0x00622CA8 File Offset: 0x00620EA8
		public ICondition2_Union[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ICondition2_Union[] array = new ICondition2_Union[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ICondition2_Union)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602CB5B RID: 183131 RVA: 0x00622D14 File Offset: 0x00620F14
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BFDC RID: 49116
		// (get) Token: 0x0602CB5C RID: 183132 RVA: 0x00622D5C File Offset: 0x00620F5C
		public int ConditionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700BFDD RID: 49117
		// (get) Token: 0x0602CB5D RID: 183133 RVA: 0x00622D88 File Offset: 0x00620F88
		public int GuideId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFDE RID: 49118
		// (get) Token: 0x0602CB5E RID: 183134 RVA: 0x00622DC8 File Offset: 0x00620FC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB5F RID: 183135 RVA: 0x00622E05 File Offset: 0x00621005
		public static Offset<ICompleteGuide> CreateICompleteGuide(FlatBufferBuilder builder, EGuideTriggerType Type = EGuideTriggerType.BeginnerGuide, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset), int GuideId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICompleteGuide.AddGuideId(builder, GuideId);
			ICompleteGuide.AddConditions(builder, ConditionsOffset);
			ICompleteGuide.AddConditionsType(builder, Conditions_typeOffset);
			ICompleteGuide.AddNullMask(builder, NullMask);
			ICompleteGuide.AddType(builder, Type);
			return ICompleteGuide.EndICompleteGuide(builder);
		}

		// Token: 0x0602CB60 RID: 183136 RVA: 0x00622E39 File Offset: 0x00621039
		public static void StartICompleteGuide(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602CB61 RID: 183137 RVA: 0x00622E42 File Offset: 0x00621042
		public static void AddType(FlatBufferBuilder builder, EGuideTriggerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CB62 RID: 183138 RVA: 0x00622E4D File Offset: 0x0062104D
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0602CB63 RID: 183139 RVA: 0x00622E60 File Offset: 0x00621060
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, ICondition2_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CB64 RID: 183140 RVA: 0x00622E97 File Offset: 0x00621097
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ICondition2_Union[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ICondition2_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CB65 RID: 183141 RVA: 0x00622EB1 File Offset: 0x006210B1
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<ICondition2_Union> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ICondition2_Union>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CB66 RID: 183142 RVA: 0x00622ECF File Offset: 0x006210CF
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ICondition2_Union>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CB67 RID: 183143 RVA: 0x00622EE8 File Offset: 0x006210E8
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602CB68 RID: 183144 RVA: 0x00622EF3 File Offset: 0x006210F3
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0602CB69 RID: 183145 RVA: 0x00622F04 File Offset: 0x00621104
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CB6A RID: 183146 RVA: 0x00622F3B File Offset: 0x0062113B
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CB6B RID: 183147 RVA: 0x00622F55 File Offset: 0x00621155
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CB6C RID: 183148 RVA: 0x00622F73 File Offset: 0x00621173
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CB6D RID: 183149 RVA: 0x00622F8C File Offset: 0x0062118C
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CB6E RID: 183150 RVA: 0x00622F97 File Offset: 0x00621197
		public static void AddGuideId(FlatBufferBuilder builder, int guideId)
		{
			builder.AddInt(3, guideId, 0);
		}

		// Token: 0x0602CB6F RID: 183151 RVA: 0x00622FA2 File Offset: 0x006211A2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602CB70 RID: 183152 RVA: 0x00622FAD File Offset: 0x006211AD
		public static Offset<ICompleteGuide> EndICompleteGuide(FlatBufferBuilder builder)
		{
			return new Offset<ICompleteGuide>(builder.EndTable());
		}

		// Token: 0x0602CB71 RID: 183153 RVA: 0x00622FBC File Offset: 0x006211BC
		public ICompleteGuideT UnPack()
		{
			ICompleteGuideT completeGuideT = new ICompleteGuideT();
			this.UnPackTo(completeGuideT);
			return completeGuideT;
		}

		// Token: 0x0602CB72 RID: 183154 RVA: 0x00622FD8 File Offset: 0x006211D8
		public void UnPackTo(ICompleteGuideT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<ICondition2_UnionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				ICondition2_UnionUnion condition2_UnionUnion = new ICondition2_UnionUnion();
				condition2_UnionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case ICondition2_Union.ICondition2:
					condition2_UnionUnion.Value = ((this.Conditions<ICondition2>(i) != null) ? this.Conditions<ICondition2>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareVarCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareVarCondition>(i) != null) ? this.Conditions<ICompareVarCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IQuestStateEqualCondition:
					condition2_UnionUnion.Value = ((this.Conditions<IQuestStateEqualCondition>(i) != null) ? this.Conditions<IQuestStateEqualCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareExploreLevelCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareExploreLevelCondition>(i) != null) ? this.Conditions<ICompareExploreLevelCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareCalabashLevelCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareCalabashLevelCondition>(i) != null) ? this.Conditions<ICompareCalabashLevelCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareLiftCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareLiftCondition>(i) != null) ? this.Conditions<ICompareLiftCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareEntityStateCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareEntityStateCondition>(i) != null) ? this.Conditions<ICompareEntityStateCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareNpcPerformStateCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareNpcPerformStateCondition>(i) != null) ? this.Conditions<ICompareNpcPerformStateCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckTreasureBeenClaimedCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckTreasureBeenClaimedCondition>(i) != null) ? this.Conditions<ICheckTreasureBeenClaimedCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareEntityGroupStateCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareEntityGroupStateCondition>(i) != null) ? this.Conditions<ICompareEntityGroupStateCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareEntitySelfStateCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareEntitySelfStateCondition>(i) != null) ? this.Conditions<ICompareEntitySelfStateCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareLevelPlayRewardStateCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareLevelPlayRewardStateCondition>(i) != null) ? this.Conditions<ICompareLevelPlayRewardStateCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IHourToHourCondition:
					condition2_UnionUnion.Value = ((this.Conditions<IHourToHourCondition>(i) != null) ? this.Conditions<IHourToHourCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IRangeSphere:
					condition2_UnionUnion.Value = ((this.Conditions<IRangeSphere>(i) != null) ? this.Conditions<IRangeSphere>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckItems:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckItems>(i) != null) ? this.Conditions<ICheckItems>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IHasBuff:
					condition2_UnionUnion.Value = ((this.Conditions<IHasBuff>(i) != null) ? this.Conditions<IHasBuff>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckSystemFunction:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckSystemFunction>(i) != null) ? this.Conditions<ICheckSystemFunction>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckAiState:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckAiState>(i) != null) ? this.Conditions<ICheckAiState>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareDungeonId:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareDungeonId>(i) != null) ? this.Conditions<ICompareDungeonId>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareTimePeriod:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareTimePeriod>(i) != null) ? this.Conditions<ICompareTimePeriod>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareWeather:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareWeather>(i) != null) ? this.Conditions<ICompareWeather>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckLevelPlayState:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckLevelPlayState>(i) != null) ? this.Conditions<ICheckLevelPlayState>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckLevelPlayCompleteNumber:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckLevelPlayCompleteNumber>(i) != null) ? this.Conditions<ICheckLevelPlayCompleteNumber>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckLevelPlayChildQuestFinished:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckLevelPlayChildQuestFinished>(i) != null) ? this.Conditions<ICheckLevelPlayChildQuestFinished>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckCurrentRole:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckCurrentRole>(i) != null) ? this.Conditions<ICheckCurrentRole>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerGender:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerGender>(i) != null) ? this.Conditions<ICheckPlayerGender>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckInCombat:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckInCombat>(i) != null) ? this.Conditions<ICheckInCombat>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHasFollowShooter:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHasFollowShooter>(i) != null) ? this.Conditions<ICheckHasFollowShooter>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckFollowShooterActive:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckFollowShooterActive>(i) != null) ? this.Conditions<ICheckFollowShooterActive>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckChildQuestFinished:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckChildQuestFinished>(i) != null) ? this.Conditions<ICheckChildQuestFinished>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckSyncLevelPlayCompleteNumber:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckSyncLevelPlayCompleteNumber>(i) != null) ? this.Conditions<ICheckSyncLevelPlayCompleteNumber>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckCrossSceneSyncKillMonsterFinished:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckCrossSceneSyncKillMonsterFinished>(i) != null) ? this.Conditions<ICheckCrossSceneSyncKillMonsterFinished>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckNodeStatus:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckNodeStatus>(i) != null) ? this.Conditions<ICheckNodeStatus>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckChildQuestStatus:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckChildQuestStatus>(i) != null) ? this.Conditions<ICheckChildQuestStatus>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntitiesExist:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntitiesExist>(i) != null) ? this.Conditions<ICheckEntitiesExist>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerPosition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerPosition>(i) != null) ? this.Conditions<ICheckPlayerPosition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityPosition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityPosition>(i) != null) ? this.Conditions<ICheckEntityPosition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDungeonFinish:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDungeonFinish>(i) != null) ? this.Conditions<ICheckDungeonFinish>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityIsVisibility:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityIsVisibility>(i) != null) ? this.Conditions<ICheckEntityIsVisibility>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IComparePlayerMotionState:
					condition2_UnionUnion.Value = ((this.Conditions<IComparePlayerMotionState>(i) != null) ? this.Conditions<IComparePlayerMotionState>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IComparePlayerMotionState2:
					condition2_UnionUnion.Value = ((this.Conditions<IComparePlayerMotionState2>(i) != null) ? this.Conditions<IComparePlayerMotionState2>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDataLayerCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDataLayerCondition>(i) != null) ? this.Conditions<ICheckDataLayerCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHookLockPointCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHookLockPointCondition>(i) != null) ? this.Conditions<ICheckHookLockPointCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerSkillReadyCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerSkillReadyCondition>(i) != null) ? this.Conditions<ICheckPlayerSkillReadyCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerUseSkillCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerUseSkillCondition>(i) != null) ? this.Conditions<ICheckPlayerUseSkillCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerStateRestrictionCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerStateRestrictionCondition>(i) != null) ? this.Conditions<ICheckPlayerStateRestrictionCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckLordGymFinishCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckLordGymFinishCondition>(i) != null) ? this.Conditions<ICheckLordGymFinishCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckCalabashDevelopRewardCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckCalabashDevelopRewardCondition>(i) != null) ? this.Conditions<ICheckCalabashDevelopRewardCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareFishingPrestigeLevelCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareFishingPrestigeLevelCondition>(i) != null) ? this.Conditions<ICompareFishingPrestigeLevelCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckCertainFishingItemCount:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckCertainFishingItemCount>(i) != null) ? this.Conditions<ICheckCertainFishingItemCount>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompleteCertainFishingEntrust:
					condition2_UnionUnion.Value = ((this.Conditions<ICompleteCertainFishingEntrust>(i) != null) ? this.Conditions<ICompleteCertainFishingEntrust>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareFishingBoatState:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareFishingBoatState>(i) != null) ? this.Conditions<ICompareFishingBoatState>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckJigsawInfoCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckJigsawInfoCondition>(i) != null) ? this.Conditions<ICheckJigsawInfoCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckGameplayTagCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckGameplayTagCondition>(i) != null) ? this.Conditions<ICheckGameplayTagCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckFormationRoleInfoCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckFormationRoleInfoCondition>(i) != null) ? this.Conditions<ICheckFormationRoleInfoCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckTargetAttributeCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckTargetAttributeCondition>(i) != null) ? this.Conditions<ICheckTargetAttributeCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckRogueAbilitySelectCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckRogueAbilitySelectCondition>(i) != null) ? this.Conditions<ICheckRogueAbilitySelectCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDirectionCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDirectionCondition>(i) != null) ? this.Conditions<ICheckDirectionCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckSceneItemDirectionCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckSceneItemDirectionCondition>(i) != null) ? this.Conditions<ICheckSceneItemDirectionCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerFaceToCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerFaceToCondition>(i) != null) ? this.Conditions<ICheckPlayerFaceToCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerCanJoinActivityCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerCanJoinActivityCondition>(i) != null) ? this.Conditions<ICheckPlayerCanJoinActivityCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckSystemStateCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckSystemStateCondition>(i) != null) ? this.Conditions<ICheckSystemStateCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckInRangeCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckInRangeCondition>(i) != null) ? this.Conditions<ICheckInRangeCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckInRangeProperlyCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckInRangeProperlyCondition>(i) != null) ? this.Conditions<ICheckInRangeProperlyCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityLockedCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityLockedCondition>(i) != null) ? this.Conditions<ICheckEntityLockedCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareTeammateDieCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareTeammateDieCondition>(i) != null) ? this.Conditions<ICompareTeammateDieCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IListenEntitySelfEventCondition:
					condition2_UnionUnion.Value = ((this.Conditions<IListenEntitySelfEventCondition>(i) != null) ? this.Conditions<IListenEntitySelfEventCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityDistanceCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityDistanceCondition>(i) != null) ? this.Conditions<ICheckEntityDistanceCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityHasSceneItemAttributeTag:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityHasSceneItemAttributeTag>(i) != null) ? this.Conditions<ICheckEntityHasSceneItemAttributeTag>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IListenEntityThroughPortal:
					condition2_UnionUnion.Value = ((this.Conditions<IListenEntityThroughPortal>(i) != null) ? this.Conditions<IListenEntityThroughPortal>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckTeleControlState:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckTeleControlState>(i) != null) ? this.Conditions<ICheckTeleControlState>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICustomJsonCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICustomJsonCondition>(i) != null) ? this.Conditions<ICustomJsonCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckChessWinner:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckChessWinner>(i) != null) ? this.Conditions<ICheckChessWinner>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckVehicleCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckVehicleCondition>(i) != null) ? this.Conditions<ICheckVehicleCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareAlertValue:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareAlertValue>(i) != null) ? this.Conditions<ICompareAlertValue>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityGravityDirection:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityGravityDirection>(i) != null) ? this.Conditions<ICheckEntityGravityDirection>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckCollectAnimalParts:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckCollectAnimalParts>(i) != null) ? this.Conditions<ICheckCollectAnimalParts>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckFinishLoading:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckFinishLoading>(i) != null) ? this.Conditions<ICheckFinishLoading>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckFishingPointHasFish:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckFishingPointHasFish>(i) != null) ? this.Conditions<ICheckFishingPointHasFish>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckFishingCageFillingRatio:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckFishingCageFillingRatio>(i) != null) ? this.Conditions<ICheckFishingCageFillingRatio>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareFishingTechLevel:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareFishingTechLevel>(i) != null) ? this.Conditions<ICompareFishingTechLevel>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckGuestCharacter:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckGuestCharacter>(i) != null) ? this.Conditions<ICheckGuestCharacter>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckSubLevelState:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckSubLevelState>(i) != null) ? this.Conditions<ICheckSubLevelState>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.IComparePlayerNumInDungeon:
					condition2_UnionUnion.Value = ((this.Conditions<IComparePlayerNumInDungeon>(i) != null) ? this.Conditions<IComparePlayerNumInDungeon>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckAlertAreaEnabled:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckAlertAreaEnabled>(i) != null) ? this.Conditions<ICheckAlertAreaEnabled>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckClientEvent:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckClientEvent>(i) != null) ? this.Conditions<ICheckClientEvent>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsGramophonePlayingMusic:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsGramophonePlayingMusic>(i) != null) ? this.Conditions<ICheckIsGramophonePlayingMusic>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityReward:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityReward>(i) != null) ? this.Conditions<ICheckEntityReward>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDungeonHasSaveConfig:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDungeonHasSaveConfig>(i) != null) ? this.Conditions<ICheckDungeonHasSaveConfig>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckSystemEventBvb:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckSystemEventBvb>(i) != null) ? this.Conditions<ICheckSystemEventBvb>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDangoCultivationProgress:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDangoCultivationProgress>(i) != null) ? this.Conditions<ICheckDangoCultivationProgress>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerMoraleLevelRange:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerMoraleLevelRange>(i) != null) ? this.Conditions<ICheckPlayerMoraleLevelRange>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsGlobalTimeScaleEnabled:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsGlobalTimeScaleEnabled>(i) != null) ? this.Conditions<ICheckIsGlobalTimeScaleEnabled>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ISaveConfigEnterMethod:
					condition2_UnionUnion.Value = ((this.Conditions<ISaveConfigEnterMethod>(i) != null) ? this.Conditions<ISaveConfigEnterMethod>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsEntityTimeScaleEnabled:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsEntityTimeScaleEnabled>(i) != null) ? this.Conditions<ICheckIsEntityTimeScaleEnabled>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsCharacterHoldingHands:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsCharacterHoldingHands>(i) != null) ? this.Conditions<ICheckIsCharacterHoldingHands>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsTrackingCurrentQuest:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsTrackingCurrentQuest>(i) != null) ? this.Conditions<ICheckIsTrackingCurrentQuest>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsTrackingQuest:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsTrackingQuest>(i) != null) ? this.Conditions<ICheckIsTrackingQuest>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckMusicEvent:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckMusicEvent>(i) != null) ? this.Conditions<ICheckMusicEvent>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICompareGameDifficulty:
					condition2_UnionUnion.Value = ((this.Conditions<ICompareGameDifficulty>(i) != null) ? this.Conditions<ICompareGameDifficulty>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPhotographCameraParam:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPhotographCameraParam>(i) != null) ? this.Conditions<ICheckPhotographCameraParam>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityHasBuff:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityHasBuff>(i) != null) ? this.Conditions<ICheckEntityHasBuff>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityBuffStack:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityBuffStack>(i) != null) ? this.Conditions<ICheckEntityBuffStack>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckAvailableSunSpiritCount:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckAvailableSunSpiritCount>(i) != null) ? this.Conditions<ICheckAvailableSunSpiritCount>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerEnterClientTriggerDir:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerEnterClientTriggerDir>(i) != null) ? this.Conditions<ICheckPlayerEnterClientTriggerDir>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerRelativeDistance:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerRelativeDistance>(i) != null) ? this.Conditions<ICheckPlayerRelativeDistance>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerRelativeAngle:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerRelativeAngle>(i) != null) ? this.Conditions<ICheckPlayerRelativeAngle>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryGetItem:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryGetItem>(i) != null) ? this.Conditions<ICheckHonamiStoryGetItem>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryEquipItem:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryEquipItem>(i) != null) ? this.Conditions<ICheckHonamiStoryEquipItem>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryActivateTalent:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryActivateTalent>(i) != null) ? this.Conditions<ICheckHonamiStoryActivateTalent>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryUnlockSlot:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryUnlockSlot>(i) != null) ? this.Conditions<ICheckHonamiStoryUnlockSlot>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryLifeSupportLevel:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryLifeSupportLevel>(i) != null) ? this.Conditions<ICheckHonamiStoryLifeSupportLevel>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryTowerComplete:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryTowerComplete>(i) != null) ? this.Conditions<ICheckHonamiStoryTowerComplete>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryPlayerCorruptedLevel:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryPlayerCorruptedLevel>(i) != null) ? this.Conditions<ICheckHonamiStoryPlayerCorruptedLevel>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryUnlockMascot:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryUnlockMascot>(i) != null) ? this.Conditions<ICheckHonamiStoryUnlockMascot>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStoryChestOpenTime:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStoryChestOpenTime>(i) != null) ? this.Conditions<ICheckHonamiStoryChestOpenTime>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckHonamiStorySuccessfulEvacuation:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckHonamiStorySuccessfulEvacuation>(i) != null) ? this.Conditions<ICheckHonamiStorySuccessfulEvacuation>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckBvbChallengeState:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckBvbChallengeState>(i) != null) ? this.Conditions<ICheckBvbChallengeState>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckBvbActivityRank:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckBvbActivityRank>(i) != null) ? this.Conditions<ICheckBvbActivityRank>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckCollectedSunSpiritCount:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckCollectedSunSpiritCount>(i) != null) ? this.Conditions<ICheckCollectedSunSpiritCount>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckTargetSunSpiritCollected:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckTargetSunSpiritCollected>(i) != null) ? this.Conditions<ICheckTargetSunSpiritCollected>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerIsInDeadEyeProcess:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerIsInDeadEyeProcess>(i) != null) ? this.Conditions<ICheckPlayerIsInDeadEyeProcess>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntitySelfDirection:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntitySelfDirection>(i) != null) ? this.Conditions<ICheckEntitySelfDirection>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDollGrabItemComboAchievedInOnceDelivery:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDollGrabItemComboAchievedInOnceDelivery>(i) != null) ? this.Conditions<ICheckDollGrabItemComboAchievedInOnceDelivery>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDollGrabShowcaseItemComboAchieved:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDollGrabShowcaseItemComboAchieved>(i) != null) ? this.Conditions<ICheckDollGrabShowcaseItemComboAchieved>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckRoverRogueAbilitySelectCondition:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckRoverRogueAbilitySelectCondition>(i) != null) ? this.Conditions<ICheckRoverRogueAbilitySelectCondition>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDollGrabMachineFinished:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDollGrabMachineFinished>(i) != null) ? this.Conditions<ICheckDollGrabMachineFinished>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckTrafficBlocked:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckTrafficBlocked>(i) != null) ? this.Conditions<ICheckTrafficBlocked>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckDrinksPreferenceLevel:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckDrinksPreferenceLevel>(i) != null) ? this.Conditions<ICheckDrinksPreferenceLevel>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckPlayerIsInMotorcycleCruise:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckPlayerIsInMotorcycleCruise>(i) != null) ? this.Conditions<ICheckPlayerIsInMotorcycleCruise>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckTetrisEndlessScore:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckTetrisEndlessScore>(i) != null) ? this.Conditions<ICheckTetrisEndlessScore>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckAtlasUnlocked:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckAtlasUnlocked>(i) != null) ? this.Conditions<ICheckAtlasUnlocked>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckSheriffUnlockEnding:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckSheriffUnlockEnding>(i) != null) ? this.Conditions<ICheckSheriffUnlockEnding>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsInDragActorPlay:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsInDragActorPlay>(i) != null) ? this.Conditions<ICheckIsInDragActorPlay>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsInDollGrabGamePlay:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsInDollGrabGamePlay>(i) != null) ? this.Conditions<ICheckIsInDollGrabGamePlay>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckEntityPrefabPerformanceType:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckEntityPrefabPerformanceType>(i) != null) ? this.Conditions<ICheckEntityPrefabPerformanceType>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsSupportedWalking:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsSupportedWalking>(i) != null) ? this.Conditions<ICheckIsSupportedWalking>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckGiantStableValue:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckGiantStableValue>(i) != null) ? this.Conditions<ICheckGiantStableValue>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckGiantTotalProgressCanActivateNode:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckGiantTotalProgressCanActivateNode>(i) != null) ? this.Conditions<ICheckGiantTotalProgressCanActivateNode>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckGiantTotalProgressInteractActivatedNode:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckGiantTotalProgressInteractActivatedNode>(i) != null) ? this.Conditions<ICheckGiantTotalProgressInteractActivatedNode>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckGiantRegionCultivationTriggeredUpgradeLevel:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckGiantRegionCultivationTriggeredUpgradeLevel>(i) != null) ? this.Conditions<ICheckGiantRegionCultivationTriggeredUpgradeLevel>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckElementalBoxState:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckElementalBoxState>(i) != null) ? this.Conditions<ICheckElementalBoxState>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckIsTargetHoldElementalBox:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckIsTargetHoldElementalBox>(i) != null) ? this.Conditions<ICheckIsTargetHoldElementalBox>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckElementalEffectActive:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckElementalEffectActive>(i) != null) ? this.Conditions<ICheckElementalEffectActive>(i).Value.UnPack() : null);
					break;
				case ICondition2_Union.ICheckElementalWaterBoxStagnationSeq:
					condition2_UnionUnion.Value = ((this.Conditions<ICheckElementalWaterBoxStagnationSeq>(i) != null) ? this.Conditions<ICheckElementalWaterBoxStagnationSeq>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(condition2_UnionUnion);
			}
			_o.GuideId = this.GuideId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CB73 RID: 183155 RVA: 0x006254AC File Offset: 0x006236AC
		public static Offset<ICompleteGuide> Pack(FlatBufferBuilder builder, ICompleteGuideT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompleteGuide>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				ICondition2_Union[] array = new ICondition2_Union[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = ICompleteGuide.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ICondition2_UnionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = ICompleteGuide.CreateConditionsVector(builder, array2);
			}
			return ICompleteGuide.CreateICompleteGuide(builder, _o.Type, conditions_typeOffset, conditionsOffset, _o.GuideId, _o.NullMask);
		}

		// Token: 0x04010AE9 RID: 68329
		private Table __p;
	}
}
