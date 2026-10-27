using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004600 RID: 17920
	public class TDartSkillConditionUnion
	{
		// Token: 0x17007F5F RID: 32607
		// (get) Token: 0x0601B251 RID: 111185 RVA: 0x003DE2EC File Offset: 0x003DC4EC
		// (set) Token: 0x0601B252 RID: 111186 RVA: 0x003DE2F4 File Offset: 0x003DC4F4
		public TDartSkillCondition Type { get; set; }

		// Token: 0x17007F60 RID: 32608
		// (get) Token: 0x0601B253 RID: 111187 RVA: 0x003DE2FD File Offset: 0x003DC4FD
		// (set) Token: 0x0601B254 RID: 111188 RVA: 0x003DE305 File Offset: 0x003DC505
		public object Value { get; set; }

		// Token: 0x0601B255 RID: 111189 RVA: 0x003DE30E File Offset: 0x003DC50E
		public TDartSkillConditionUnion()
		{
			this.Type = TDartSkillCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601B256 RID: 111190 RVA: 0x003DE324 File Offset: 0x003DC524
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B257 RID: 111191 RVA: 0x003DE336 File Offset: 0x003DC536
		public IBehindScoreGeConditionT AsIBehindScoreGeCondition()
		{
			return this.As<IBehindScoreGeConditionT>();
		}

		// Token: 0x0601B258 RID: 111192 RVA: 0x003DE33E File Offset: 0x003DC53E
		public static TDartSkillConditionUnion FromIBehindScoreGeCondition(IBehindScoreGeConditionT _ibehindscoregecondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IBehindScoreGeCondition,
				Value = _ibehindscoregecondition
			};
		}

		// Token: 0x0601B259 RID: 111193 RVA: 0x003DE353 File Offset: 0x003DC553
		public IBehindScoreLeConditionT AsIBehindScoreLeCondition()
		{
			return this.As<IBehindScoreLeConditionT>();
		}

		// Token: 0x0601B25A RID: 111194 RVA: 0x003DE35B File Offset: 0x003DC55B
		public static TDartSkillConditionUnion FromIBehindScoreLeCondition(IBehindScoreLeConditionT _ibehindscorelecondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IBehindScoreLeCondition,
				Value = _ibehindscorelecondition
			};
		}

		// Token: 0x0601B25B RID: 111195 RVA: 0x003DE370 File Offset: 0x003DC570
		public IFirstRoundsConditionT AsIFirstRoundsCondition()
		{
			return this.As<IFirstRoundsConditionT>();
		}

		// Token: 0x0601B25C RID: 111196 RVA: 0x003DE378 File Offset: 0x003DC578
		public static TDartSkillConditionUnion FromIFirstRoundsCondition(IFirstRoundsConditionT _ifirstroundscondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IFirstRoundsCondition,
				Value = _ifirstroundscondition
			};
		}

		// Token: 0x0601B25D RID: 111197 RVA: 0x003DE38D File Offset: 0x003DC58D
		public IRemainScoreCanWinConditionT AsIRemainScoreCanWinCondition()
		{
			return this.As<IRemainScoreCanWinConditionT>();
		}

		// Token: 0x0601B25E RID: 111198 RVA: 0x003DE395 File Offset: 0x003DC595
		public static TDartSkillConditionUnion FromIRemainScoreCanWinCondition(IRemainScoreCanWinConditionT _iremainscorecanwincondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IRemainScoreCanWinCondition,
				Value = _iremainscorecanwincondition
			};
		}

		// Token: 0x0601B25F RID: 111199 RVA: 0x003DE3AA File Offset: 0x003DC5AA
		public IRemainScoreGeConditionT AsIRemainScoreGeCondition()
		{
			return this.As<IRemainScoreGeConditionT>();
		}

		// Token: 0x0601B260 RID: 111200 RVA: 0x003DE3B2 File Offset: 0x003DC5B2
		public static TDartSkillConditionUnion FromIRemainScoreGeCondition(IRemainScoreGeConditionT _iremainscoregecondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IRemainScoreGeCondition,
				Value = _iremainscoregecondition
			};
		}

		// Token: 0x0601B261 RID: 111201 RVA: 0x003DE3C7 File Offset: 0x003DC5C7
		public IRemainScoreLeConditionT AsIRemainScoreLeCondition()
		{
			return this.As<IRemainScoreLeConditionT>();
		}

		// Token: 0x0601B262 RID: 111202 RVA: 0x003DE3CF File Offset: 0x003DC5CF
		public static TDartSkillConditionUnion FromIRemainScoreLeCondition(IRemainScoreLeConditionT _iremainscorelecondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IRemainScoreLeCondition,
				Value = _iremainscorelecondition
			};
		}

		// Token: 0x0601B263 RID: 111203 RVA: 0x003DE3E4 File Offset: 0x003DC5E4
		public IRoundIndexConditionT AsIRoundIndexCondition()
		{
			return this.As<IRoundIndexConditionT>();
		}

		// Token: 0x0601B264 RID: 111204 RVA: 0x003DE3EC File Offset: 0x003DC5EC
		public static TDartSkillConditionUnion FromIRoundIndexCondition(IRoundIndexConditionT _iroundindexcondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IRoundIndexCondition,
				Value = _iroundindexcondition
			};
		}

		// Token: 0x0601B265 RID: 111205 RVA: 0x003DE404 File Offset: 0x003DC604
		public static int Pack(FlatBufferBuilder builder, TDartSkillConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TDartSkillCondition.IBehindScoreGeCondition:
				return IBehindScoreGeCondition.Pack(builder, _o.AsIBehindScoreGeCondition()).Value;
			case TDartSkillCondition.IBehindScoreLeCondition:
				return IBehindScoreLeCondition.Pack(builder, _o.AsIBehindScoreLeCondition()).Value;
			case TDartSkillCondition.IFirstRoundsCondition:
				return IFirstRoundsCondition.Pack(builder, _o.AsIFirstRoundsCondition()).Value;
			case TDartSkillCondition.IRemainScoreCanWinCondition:
				return IRemainScoreCanWinCondition.Pack(builder, _o.AsIRemainScoreCanWinCondition()).Value;
			case TDartSkillCondition.IRemainScoreGeCondition:
				return IRemainScoreGeCondition.Pack(builder, _o.AsIRemainScoreGeCondition()).Value;
			case TDartSkillCondition.IRemainScoreLeCondition:
				return IRemainScoreLeCondition.Pack(builder, _o.AsIRemainScoreLeCondition()).Value;
			case TDartSkillCondition.IRoundIndexCondition:
				return IRoundIndexCondition.Pack(builder, _o.AsIRoundIndexCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
