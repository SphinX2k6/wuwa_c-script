using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A68 RID: 19048
	public class TDartSkillConditionUnion
	{
		// Token: 0x170085A0 RID: 34208
		// (get) Token: 0x0601CA26 RID: 117286 RVA: 0x0040A588 File Offset: 0x00408788
		// (set) Token: 0x0601CA27 RID: 117287 RVA: 0x0040A590 File Offset: 0x00408790
		public TDartSkillCondition Type { get; set; }

		// Token: 0x170085A1 RID: 34209
		// (get) Token: 0x0601CA28 RID: 117288 RVA: 0x0040A599 File Offset: 0x00408799
		// (set) Token: 0x0601CA29 RID: 117289 RVA: 0x0040A5A1 File Offset: 0x004087A1
		public object Value { get; set; }

		// Token: 0x0601CA2A RID: 117290 RVA: 0x0040A5AA File Offset: 0x004087AA
		public TDartSkillConditionUnion()
		{
			this.Type = TDartSkillCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA2B RID: 117291 RVA: 0x0040A5C0 File Offset: 0x004087C0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CA2C RID: 117292 RVA: 0x0040A5D2 File Offset: 0x004087D2
		public IBehindScoreGeConditionT AsIBehindScoreGeCondition()
		{
			return this.As<IBehindScoreGeConditionT>();
		}

		// Token: 0x0601CA2D RID: 117293 RVA: 0x0040A5DA File Offset: 0x004087DA
		public static TDartSkillConditionUnion FromIBehindScoreGeCondition(IBehindScoreGeConditionT _ibehindscoregecondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IBehindScoreGeCondition,
				Value = _ibehindscoregecondition
			};
		}

		// Token: 0x0601CA2E RID: 117294 RVA: 0x0040A5EF File Offset: 0x004087EF
		public IBehindScoreLeConditionT AsIBehindScoreLeCondition()
		{
			return this.As<IBehindScoreLeConditionT>();
		}

		// Token: 0x0601CA2F RID: 117295 RVA: 0x0040A5F7 File Offset: 0x004087F7
		public static TDartSkillConditionUnion FromIBehindScoreLeCondition(IBehindScoreLeConditionT _ibehindscorelecondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IBehindScoreLeCondition,
				Value = _ibehindscorelecondition
			};
		}

		// Token: 0x0601CA30 RID: 117296 RVA: 0x0040A60C File Offset: 0x0040880C
		public IFirstRoundsConditionT AsIFirstRoundsCondition()
		{
			return this.As<IFirstRoundsConditionT>();
		}

		// Token: 0x0601CA31 RID: 117297 RVA: 0x0040A614 File Offset: 0x00408814
		public static TDartSkillConditionUnion FromIFirstRoundsCondition(IFirstRoundsConditionT _ifirstroundscondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IFirstRoundsCondition,
				Value = _ifirstroundscondition
			};
		}

		// Token: 0x0601CA32 RID: 117298 RVA: 0x0040A629 File Offset: 0x00408829
		public IRemainScoreCanWinConditionT AsIRemainScoreCanWinCondition()
		{
			return this.As<IRemainScoreCanWinConditionT>();
		}

		// Token: 0x0601CA33 RID: 117299 RVA: 0x0040A631 File Offset: 0x00408831
		public static TDartSkillConditionUnion FromIRemainScoreCanWinCondition(IRemainScoreCanWinConditionT _iremainscorecanwincondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IRemainScoreCanWinCondition,
				Value = _iremainscorecanwincondition
			};
		}

		// Token: 0x0601CA34 RID: 117300 RVA: 0x0040A646 File Offset: 0x00408846
		public IRemainScoreGeConditionT AsIRemainScoreGeCondition()
		{
			return this.As<IRemainScoreGeConditionT>();
		}

		// Token: 0x0601CA35 RID: 117301 RVA: 0x0040A64E File Offset: 0x0040884E
		public static TDartSkillConditionUnion FromIRemainScoreGeCondition(IRemainScoreGeConditionT _iremainscoregecondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IRemainScoreGeCondition,
				Value = _iremainscoregecondition
			};
		}

		// Token: 0x0601CA36 RID: 117302 RVA: 0x0040A663 File Offset: 0x00408863
		public IRemainScoreLeConditionT AsIRemainScoreLeCondition()
		{
			return this.As<IRemainScoreLeConditionT>();
		}

		// Token: 0x0601CA37 RID: 117303 RVA: 0x0040A66B File Offset: 0x0040886B
		public static TDartSkillConditionUnion FromIRemainScoreLeCondition(IRemainScoreLeConditionT _iremainscorelecondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IRemainScoreLeCondition,
				Value = _iremainscorelecondition
			};
		}

		// Token: 0x0601CA38 RID: 117304 RVA: 0x0040A680 File Offset: 0x00408880
		public IRoundIndexConditionT AsIRoundIndexCondition()
		{
			return this.As<IRoundIndexConditionT>();
		}

		// Token: 0x0601CA39 RID: 117305 RVA: 0x0040A688 File Offset: 0x00408888
		public static TDartSkillConditionUnion FromIRoundIndexCondition(IRoundIndexConditionT _iroundindexcondition)
		{
			return new TDartSkillConditionUnion
			{
				Type = TDartSkillCondition.IRoundIndexCondition,
				Value = _iroundindexcondition
			};
		}

		// Token: 0x0601CA3A RID: 117306 RVA: 0x0040A6A0 File Offset: 0x004088A0
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
