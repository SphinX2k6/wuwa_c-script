using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004489 RID: 17545
	public class IDartSkillConditionType_UnionUnion
	{
		// Token: 0x17007BD0 RID: 31696
		// (get) Token: 0x0601A29E RID: 107166 RVA: 0x003BCD0D File Offset: 0x003BAF0D
		// (set) Token: 0x0601A29F RID: 107167 RVA: 0x003BCD15 File Offset: 0x003BAF15
		public IDartSkillConditionType_Union Type { get; set; }

		// Token: 0x17007BD1 RID: 31697
		// (get) Token: 0x0601A2A0 RID: 107168 RVA: 0x003BCD1E File Offset: 0x003BAF1E
		// (set) Token: 0x0601A2A1 RID: 107169 RVA: 0x003BCD26 File Offset: 0x003BAF26
		public object Value { get; set; }

		// Token: 0x0601A2A2 RID: 107170 RVA: 0x003BCD2F File Offset: 0x003BAF2F
		public IDartSkillConditionType_UnionUnion()
		{
			this.Type = IDartSkillConditionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A2A3 RID: 107171 RVA: 0x003BCD45 File Offset: 0x003BAF45
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A2A4 RID: 107172 RVA: 0x003BCD57 File Offset: 0x003BAF57
		public IDartSkillConditionTypeT AsIDartSkillConditionType()
		{
			return this.As<IDartSkillConditionTypeT>();
		}

		// Token: 0x0601A2A5 RID: 107173 RVA: 0x003BCD5F File Offset: 0x003BAF5F
		public static IDartSkillConditionType_UnionUnion FromIDartSkillConditionType(IDartSkillConditionTypeT _idartskillconditiontype)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IDartSkillConditionType,
				Value = _idartskillconditiontype
			};
		}

		// Token: 0x0601A2A6 RID: 107174 RVA: 0x003BCD74 File Offset: 0x003BAF74
		public IRemainScoreGeConditionT AsIRemainScoreGeCondition()
		{
			return this.As<IRemainScoreGeConditionT>();
		}

		// Token: 0x0601A2A7 RID: 107175 RVA: 0x003BCD7C File Offset: 0x003BAF7C
		public static IDartSkillConditionType_UnionUnion FromIRemainScoreGeCondition(IRemainScoreGeConditionT _iremainscoregecondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IRemainScoreGeCondition,
				Value = _iremainscoregecondition
			};
		}

		// Token: 0x0601A2A8 RID: 107176 RVA: 0x003BCD91 File Offset: 0x003BAF91
		public IRemainScoreLeConditionT AsIRemainScoreLeCondition()
		{
			return this.As<IRemainScoreLeConditionT>();
		}

		// Token: 0x0601A2A9 RID: 107177 RVA: 0x003BCD99 File Offset: 0x003BAF99
		public static IDartSkillConditionType_UnionUnion FromIRemainScoreLeCondition(IRemainScoreLeConditionT _iremainscorelecondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IRemainScoreLeCondition,
				Value = _iremainscorelecondition
			};
		}

		// Token: 0x0601A2AA RID: 107178 RVA: 0x003BCDAE File Offset: 0x003BAFAE
		public IBehindScoreGeConditionT AsIBehindScoreGeCondition()
		{
			return this.As<IBehindScoreGeConditionT>();
		}

		// Token: 0x0601A2AB RID: 107179 RVA: 0x003BCDB6 File Offset: 0x003BAFB6
		public static IDartSkillConditionType_UnionUnion FromIBehindScoreGeCondition(IBehindScoreGeConditionT _ibehindscoregecondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IBehindScoreGeCondition,
				Value = _ibehindscoregecondition
			};
		}

		// Token: 0x0601A2AC RID: 107180 RVA: 0x003BCDCB File Offset: 0x003BAFCB
		public IBehindScoreLeConditionT AsIBehindScoreLeCondition()
		{
			return this.As<IBehindScoreLeConditionT>();
		}

		// Token: 0x0601A2AD RID: 107181 RVA: 0x003BCDD3 File Offset: 0x003BAFD3
		public static IDartSkillConditionType_UnionUnion FromIBehindScoreLeCondition(IBehindScoreLeConditionT _ibehindscorelecondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IBehindScoreLeCondition,
				Value = _ibehindscorelecondition
			};
		}

		// Token: 0x0601A2AE RID: 107182 RVA: 0x003BCDE8 File Offset: 0x003BAFE8
		public IRemainScoreCanWinConditionT AsIRemainScoreCanWinCondition()
		{
			return this.As<IRemainScoreCanWinConditionT>();
		}

		// Token: 0x0601A2AF RID: 107183 RVA: 0x003BCDF0 File Offset: 0x003BAFF0
		public static IDartSkillConditionType_UnionUnion FromIRemainScoreCanWinCondition(IRemainScoreCanWinConditionT _iremainscorecanwincondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IRemainScoreCanWinCondition,
				Value = _iremainscorecanwincondition
			};
		}

		// Token: 0x0601A2B0 RID: 107184 RVA: 0x003BCE05 File Offset: 0x003BB005
		public IRoundIndexConditionT AsIRoundIndexCondition()
		{
			return this.As<IRoundIndexConditionT>();
		}

		// Token: 0x0601A2B1 RID: 107185 RVA: 0x003BCE0D File Offset: 0x003BB00D
		public static IDartSkillConditionType_UnionUnion FromIRoundIndexCondition(IRoundIndexConditionT _iroundindexcondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IRoundIndexCondition,
				Value = _iroundindexcondition
			};
		}

		// Token: 0x0601A2B2 RID: 107186 RVA: 0x003BCE22 File Offset: 0x003BB022
		public IFirstRoundsConditionT AsIFirstRoundsCondition()
		{
			return this.As<IFirstRoundsConditionT>();
		}

		// Token: 0x0601A2B3 RID: 107187 RVA: 0x003BCE2A File Offset: 0x003BB02A
		public static IDartSkillConditionType_UnionUnion FromIFirstRoundsCondition(IFirstRoundsConditionT _ifirstroundscondition)
		{
			return new IDartSkillConditionType_UnionUnion
			{
				Type = IDartSkillConditionType_Union.IFirstRoundsCondition,
				Value = _ifirstroundscondition
			};
		}

		// Token: 0x0601A2B4 RID: 107188 RVA: 0x003BCE40 File Offset: 0x003BB040
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
