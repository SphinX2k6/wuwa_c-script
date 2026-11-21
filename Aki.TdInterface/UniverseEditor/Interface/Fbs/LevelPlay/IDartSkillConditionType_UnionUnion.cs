using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048F1 RID: 18673
	public class IDartSkillConditionType_UnionUnion
	{
		// Token: 0x1700820F RID: 33295
		// (get) Token: 0x0601BA6F RID: 113263 RVA: 0x003E8F19 File Offset: 0x003E7119
		// (set) Token: 0x0601BA70 RID: 113264 RVA: 0x003E8F21 File Offset: 0x003E7121
		public IDartSkillConditionType_Union Type { get; set; }

		// Token: 0x17008210 RID: 33296
		// (get) Token: 0x0601BA71 RID: 113265 RVA: 0x003E8F2A File Offset: 0x003E712A
		// (set) Token: 0x0601BA72 RID: 113266 RVA: 0x003E8F32 File Offset: 0x003E7132
		public object Value { get; set; }

		// Token: 0x0601BA73 RID: 113267 RVA: 0x003E8F3B File Offset: 0x003E713B
		public IDartSkillConditionType_UnionUnion()
		{
			this.Type = IDartSkillConditionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601BA74 RID: 113268 RVA: 0x003E8F51 File Offset: 0x003E7151
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601BA75 RID: 113269 RVA: 0x003E8F63 File Offset: 0x003E7163
		public IDartSkillConditionTypeT AsIDartSkillConditionType()
		{
			return this.As<IDartSkillConditionTypeT>();
		}

		// Token: 0x0601BA76 RID: 113270 RVA: 0x003E8F6B File Offset: 0x003E716B
		public static IDartSkillConditionType_UnionUnion FromIDartSkillConditionType(IDartSkillConditionTypeT _idartskillconditiontype)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IDartSkillConditionType,
				Value = _idartskillconditiontype
			};
		}

		// Token: 0x0601BA77 RID: 113271 RVA: 0x003E8F80 File Offset: 0x003E7180
		public IRemainScoreGeConditionT AsIRemainScoreGeCondition()
		{
			return this.As<IRemainScoreGeConditionT>();
		}

		// Token: 0x0601BA78 RID: 113272 RVA: 0x003E8F88 File Offset: 0x003E7188
		public static IDartSkillConditionType_UnionUnion FromIRemainScoreGeCondition(IRemainScoreGeConditionT _iremainscoregecondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IRemainScoreGeCondition,
				Value = _iremainscoregecondition
			};
		}

		// Token: 0x0601BA79 RID: 113273 RVA: 0x003E8F9D File Offset: 0x003E719D
		public IRemainScoreLeConditionT AsIRemainScoreLeCondition()
		{
			return this.As<IRemainScoreLeConditionT>();
		}

		// Token: 0x0601BA7A RID: 113274 RVA: 0x003E8FA5 File Offset: 0x003E71A5
		public static IDartSkillConditionType_UnionUnion FromIRemainScoreLeCondition(IRemainScoreLeConditionT _iremainscorelecondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IRemainScoreLeCondition,
				Value = _iremainscorelecondition
			};
		}

		// Token: 0x0601BA7B RID: 113275 RVA: 0x003E8FBA File Offset: 0x003E71BA
		public IBehindScoreGeConditionT AsIBehindScoreGeCondition()
		{
			return this.As<IBehindScoreGeConditionT>();
		}

		// Token: 0x0601BA7C RID: 113276 RVA: 0x003E8FC2 File Offset: 0x003E71C2
		public static IDartSkillConditionType_UnionUnion FromIBehindScoreGeCondition(IBehindScoreGeConditionT _ibehindscoregecondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IBehindScoreGeCondition,
				Value = _ibehindscoregecondition
			};
		}

		// Token: 0x0601BA7D RID: 113277 RVA: 0x003E8FD7 File Offset: 0x003E71D7
		public IBehindScoreLeConditionT AsIBehindScoreLeCondition()
		{
			return this.As<IBehindScoreLeConditionT>();
		}

		// Token: 0x0601BA7E RID: 113278 RVA: 0x003E8FDF File Offset: 0x003E71DF
		public static IDartSkillConditionType_UnionUnion FromIBehindScoreLeCondition(IBehindScoreLeConditionT _ibehindscorelecondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IBehindScoreLeCondition,
				Value = _ibehindscorelecondition
			};
		}

		// Token: 0x0601BA7F RID: 113279 RVA: 0x003E8FF4 File Offset: 0x003E71F4
		public IRemainScoreCanWinConditionT AsIRemainScoreCanWinCondition()
		{
			return this.As<IRemainScoreCanWinConditionT>();
		}

		// Token: 0x0601BA80 RID: 113280 RVA: 0x003E8FFC File Offset: 0x003E71FC
		public static IDartSkillConditionType_UnionUnion FromIRemainScoreCanWinCondition(IRemainScoreCanWinConditionT _iremainscorecanwincondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IRemainScoreCanWinCondition,
				Value = _iremainscorecanwincondition
			};
		}

		// Token: 0x0601BA81 RID: 113281 RVA: 0x003E9011 File Offset: 0x003E7211
		public IRoundIndexConditionT AsIRoundIndexCondition()
		{
			return this.As<IRoundIndexConditionT>();
		}

		// Token: 0x0601BA82 RID: 113282 RVA: 0x003E9019 File Offset: 0x003E7219
		public static IDartSkillConditionType_UnionUnion FromIRoundIndexCondition(IRoundIndexConditionT _iroundindexcondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IRoundIndexCondition,
				Value = _iroundindexcondition
			};
		}

		// Token: 0x0601BA83 RID: 113283 RVA: 0x003E902E File Offset: 0x003E722E
		public IFirstRoundsConditionT AsIFirstRoundsCondition()
		{
			return this.As<IFirstRoundsConditionT>();
		}

		// Token: 0x0601BA84 RID: 113284 RVA: 0x003E9036 File Offset: 0x003E7236
		public static IDartSkillConditionType_UnionUnion FromIFirstRoundsCondition(IFirstRoundsConditionT _ifirstroundscondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IFirstRoundsCondition,
				Value = _ifirstroundscondition
			};
		}

		// Token: 0x0601BA85 RID: 113285 RVA: 0x003E904C File Offset: 0x003E724C
		public static int Pack(FlatBufferBuilder builder, IDartSkillConditionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDartSkillConditionType_Union.IDartSkillConditionType:
				return IDartSkillConditionType.Pack(builder, _o.AsIDartSkillConditionType()).Value;
			case IDartSkillConditionType_Union.IRemainScoreGeCondition:
				return IRemainScoreGeCondition.Pack(builder, _o.AsIRemainScoreGeCondition()).Value;
			case IDartSkillConditionType_Union.IRemainScoreLeCondition:
				return IRemainScoreLeCondition.Pack(builder, _o.AsIRemainScoreLeCondition()).Value;
			case IDartSkillConditionType_Union.IBehindScoreGeCondition:
				return IBehindScoreGeCondition.Pack(builder, _o.AsIBehindScoreGeCondition()).Value;
			case IDartSkillConditionType_Union.IBehindScoreLeCondition:
				return IBehindScoreLeCondition.Pack(builder, _o.AsIBehindScoreLeCondition()).Value;
			case IDartSkillConditionType_Union.IRemainScoreCanWinCondition:
				return IRemainScoreCanWinCondition.Pack(builder, _o.AsIRemainScoreCanWinCondition()).Value;
			case IDartSkillConditionType_Union.IRoundIndexCondition:
				return IRoundIndexCondition.Pack(builder, _o.AsIRoundIndexCondition()).Value;
			case IDartSkillConditionType_Union.IFirstRoundsCondition:
				return IFirstRoundsCondition.Pack(builder, _o.AsIFirstRoundsCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
