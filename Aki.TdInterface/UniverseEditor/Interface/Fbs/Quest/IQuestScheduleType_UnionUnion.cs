using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004488 RID: 17544
	public class IQuestScheduleType_UnionUnion
	{
		// Token: 0x170079D2 RID: 31186
		// (get) Token: 0x060193C1 RID: 103361 RVA: 0x00399A79 File Offset: 0x00397C79
		// (set) Token: 0x060193C2 RID: 103362 RVA: 0x00399A81 File Offset: 0x00397C81
		public IQuestScheduleType_Union Type { get; set; }

		// Token: 0x170079D3 RID: 31187
		// (get) Token: 0x060193C3 RID: 103363 RVA: 0x00399A8A File Offset: 0x00397C8A
		// (set) Token: 0x060193C4 RID: 103364 RVA: 0x00399A92 File Offset: 0x00397C92
		public object Value { get; set; }

		// Token: 0x060193C5 RID: 103365 RVA: 0x00399A9B File Offset: 0x00397C9B
		public IQuestScheduleType_UnionUnion()
		{
			this.Type = IQuestScheduleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060193C6 RID: 103366 RVA: 0x00399AB1 File Offset: 0x00397CB1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060193C7 RID: 103367 RVA: 0x00399AC3 File Offset: 0x00397CC3
		public IQuestScheduleTypeT AsIQuestScheduleType()
		{
			return this.As<IQuestScheduleTypeT>();
		}

		// Token: 0x060193C8 RID: 103368 RVA: 0x00399ACB File Offset: 0x00397CCB
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleType(IQuestScheduleTypeT _iquestscheduletype)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleType,
				Value = _iquestscheduletype
			};
		}

		// Token: 0x060193C9 RID: 103369 RVA: 0x00399AE0 File Offset: 0x00397CE0
		public IQuestScheduleNoneT AsIQuestScheduleNone()
		{
			return this.As<IQuestScheduleNoneT>();
		}

		// Token: 0x060193CA RID: 103370 RVA: 0x00399AE8 File Offset: 0x00397CE8
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleNone(IQuestScheduleNoneT _iquestschedulenone)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleNone,
				Value = _iquestschedulenone
			};
		}

		// Token: 0x060193CB RID: 103371 RVA: 0x00399AFD File Offset: 0x00397CFD
		public IQuestScheduleEntityHPT AsIQuestScheduleEntityHP()
		{
			return this.As<IQuestScheduleEntityHPT>();
		}

		// Token: 0x060193CC RID: 103372 RVA: 0x00399B05 File Offset: 0x00397D05
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleEntityHP(IQuestScheduleEntityHPT _iquestscheduleentityhp)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleEntityHP,
				Value = _iquestscheduleentityhp
			};
		}

		// Token: 0x060193CD RID: 103373 RVA: 0x00399B1A File Offset: 0x00397D1A
		public IQuestScheduleScoreT AsIQuestScheduleScore()
		{
			return this.As<IQuestScheduleScoreT>();
		}

		// Token: 0x060193CE RID: 103374 RVA: 0x00399B22 File Offset: 0x00397D22
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleScore(IQuestScheduleScoreT _iquestschedulescore)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleScore,
				Value = _iquestschedulescore
			};
		}

		// Token: 0x060193CF RID: 103375 RVA: 0x00399B37 File Offset: 0x00397D37
		public IQuestScheduleChildQuestCompletedT AsIQuestScheduleChildQuestCompleted()
		{
			return this.As<IQuestScheduleChildQuestCompletedT>();
		}

		// Token: 0x060193D0 RID: 103376 RVA: 0x00399B3F File Offset: 0x00397D3F
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleChildQuestCompleted(IQuestScheduleChildQuestCompletedT _iquestschedulechildquestcompleted)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleChildQuestCompleted,
				Value = _iquestschedulechildquestcompleted
			};
		}

		// Token: 0x060193D1 RID: 103377 RVA: 0x00399B54 File Offset: 0x00397D54
		public IQuestScheduleChildQuestCompletedCountT AsIQuestScheduleChildQuestCompletedCount()
		{
			return this.As<IQuestScheduleChildQuestCompletedCountT>();
		}

		// Token: 0x060193D2 RID: 103378 RVA: 0x00399B5C File Offset: 0x00397D5C
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleChildQuestCompletedCount(IQuestScheduleChildQuestCompletedCountT _iquestschedulechildquestcompletedcount)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleChildQuestCompletedCount,
				Value = _iquestschedulechildquestcompletedcount
			};
		}

		// Token: 0x060193D3 RID: 103379 RVA: 0x00399B71 File Offset: 0x00397D71
		public IQuestScheduleTowerChallengeTitleT AsIQuestScheduleTowerChallengeTitle()
		{
			return this.As<IQuestScheduleTowerChallengeTitleT>();
		}

		// Token: 0x060193D4 RID: 103380 RVA: 0x00399B79 File Offset: 0x00397D79
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleTowerChallengeTitle(IQuestScheduleTowerChallengeTitleT _iquestscheduletowerchallengetitle)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleTowerChallengeTitle,
				Value = _iquestscheduletowerchallengetitle
			};
		}

		// Token: 0x060193D5 RID: 103381 RVA: 0x00399B8E File Offset: 0x00397D8E
		public IQuestScheduleRoleTowerChallengeTitleT AsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.As<IQuestScheduleRoleTowerChallengeTitleT>();
		}

		// Token: 0x060193D6 RID: 103382 RVA: 0x00399B96 File Offset: 0x00397D96
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleRoleTowerChallengeTitle(IQuestScheduleRoleTowerChallengeTitleT _iquestscheduleroletowerchallengetitle)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleRoleTowerChallengeTitle,
				Value = _iquestscheduleroletowerchallengetitle
			};
		}

		// Token: 0x060193D7 RID: 103383 RVA: 0x00399BAB File Offset: 0x00397DAB
		public IQuestScheduleBtTreeVarT AsIQuestScheduleBtTreeVar()
		{
			return this.As<IQuestScheduleBtTreeVarT>();
		}

		// Token: 0x060193D8 RID: 103384 RVA: 0x00399BB3 File Offset: 0x00397DB3
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleBtTreeVar(IQuestScheduleBtTreeVarT _iquestschedulebttreevar)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleBtTreeVar,
				Value = _iquestschedulebttreevar
			};
		}

		// Token: 0x060193D9 RID: 103385 RVA: 0x00399BC9 File Offset: 0x00397DC9
		public IQuestScheduleMultiBtTreeVarT AsIQuestScheduleMultiBtTreeVar()
		{
			return this.As<IQuestScheduleMultiBtTreeVarT>();
		}

		// Token: 0x060193DA RID: 103386 RVA: 0x00399BD1 File Offset: 0x00397DD1
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleMultiBtTreeVar(IQuestScheduleMultiBtTreeVarT _iquestschedulemultibttreevar)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleMultiBtTreeVar,
				Value = _iquestschedulemultibttreevar
			};
		}

		// Token: 0x060193DB RID: 103387 RVA: 0x00399BE7 File Offset: 0x00397DE7
		public IQuestScheduleTimeLeftT AsIQuestScheduleTimeLeft()
		{
			return this.As<IQuestScheduleTimeLeftT>();
		}

		// Token: 0x060193DC RID: 103388 RVA: 0x00399BEF File Offset: 0x00397DEF
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleTimeLeft(IQuestScheduleTimeLeftT _iquestscheduletimeleft)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleTimeLeft,
				Value = _iquestscheduletimeleft
			};
		}

		// Token: 0x060193DD RID: 103389 RVA: 0x00399C05 File Offset: 0x00397E05
		public IQuestScheduleMeetConditionT AsIQuestScheduleMeetCondition()
		{
			return this.As<IQuestScheduleMeetConditionT>();
		}

		// Token: 0x060193DE RID: 103390 RVA: 0x00399C0D File Offset: 0x00397E0D
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleMeetCondition(IQuestScheduleMeetConditionT _iquestschedulemeetcondition)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleMeetCondition,
				Value = _iquestschedulemeetcondition
			};
		}

		// Token: 0x060193DF RID: 103391 RVA: 0x00399C23 File Offset: 0x00397E23
		public IQuestScheduleProgressValueT AsIQuestScheduleProgressValue()
		{
			return this.As<IQuestScheduleProgressValueT>();
		}

		// Token: 0x060193E0 RID: 103392 RVA: 0x00399C2B File Offset: 0x00397E2B
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleProgressValue(IQuestScheduleProgressValueT _iquestscheduleprogressvalue)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleProgressValue,
				Value = _iquestscheduleprogressvalue
			};
		}

		// Token: 0x060193E1 RID: 103393 RVA: 0x00399C41 File Offset: 0x00397E41
		public IQuestScheduleDistanceValueT AsIQuestScheduleDistanceValue()
		{
			return this.As<IQuestScheduleDistanceValueT>();
		}

		// Token: 0x060193E2 RID: 103394 RVA: 0x00399C49 File Offset: 0x00397E49
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleDistanceValue(IQuestScheduleDistanceValueT _iquestscheduledistancevalue)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleDistanceValue,
				Value = _iquestscheduledistancevalue
			};
		}

		// Token: 0x060193E3 RID: 103395 RVA: 0x00399C60 File Offset: 0x00397E60
		public static int Pack(FlatBufferBuilder builder, IQuestScheduleType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IQuestScheduleType_Union.IQuestScheduleType:
				return IQuestScheduleType.Pack(builder, _o.AsIQuestScheduleType()).Value;
			case IQuestScheduleType_Union.IQuestScheduleNone:
				return IQuestScheduleNone.Pack(builder, _o.AsIQuestScheduleNone()).Value;
			case IQuestScheduleType_Union.IQuestScheduleEntityHP:
				return IQuestScheduleEntityHP.Pack(builder, _o.AsIQuestScheduleEntityHP()).Value;
			case IQuestScheduleType_Union.IQuestScheduleScore:
				return IQuestScheduleScore.Pack(builder, _o.AsIQuestScheduleScore()).Value;
			case IQuestScheduleType_Union.IQuestScheduleChildQuestCompleted:
				return IQuestScheduleChildQuestCompleted.Pack(builder, _o.AsIQuestScheduleChildQuestCompleted()).Value;
			case IQuestScheduleType_Union.IQuestScheduleChildQuestCompletedCount:
				return IQuestScheduleChildQuestCompletedCount.Pack(builder, _o.AsIQuestScheduleChildQuestCompletedCount()).Value;
			case IQuestScheduleType_Union.IQuestScheduleTowerChallengeTitle:
				return IQuestScheduleTowerChallengeTitle.Pack(builder, _o.AsIQuestScheduleTowerChallengeTitle()).Value;
			case IQuestScheduleType_Union.IQuestScheduleRoleTowerChallengeTitle:
				return IQuestScheduleRoleTowerChallengeTitle.Pack(builder, _o.AsIQuestScheduleRoleTowerChallengeTitle()).Value;
			case IQuestScheduleType_Union.IQuestScheduleBtTreeVar:
				return IQuestScheduleBtTreeVar.Pack(builder, _o.AsIQuestScheduleBtTreeVar()).Value;
			case IQuestScheduleType_Union.IQuestScheduleMultiBtTreeVar:
				return IQuestScheduleMultiBtTreeVar.Pack(builder, _o.AsIQuestScheduleMultiBtTreeVar()).Value;
			case IQuestScheduleType_Union.IQuestScheduleTimeLeft:
				return IQuestScheduleTimeLeft.Pack(builder, _o.AsIQuestScheduleTimeLeft()).Value;
			case IQuestScheduleType_Union.IQuestScheduleMeetCondition:
				return IQuestScheduleMeetCondition.Pack(builder, _o.AsIQuestScheduleMeetCondition()).Value;
			case IQuestScheduleType_Union.IQuestScheduleProgressValue:
				return IQuestScheduleProgressValue.Pack(builder, _o.AsIQuestScheduleProgressValue()).Value;
			case IQuestScheduleType_Union.IQuestScheduleDistanceValue:
				return IQuestScheduleDistanceValue.Pack(builder, _o.AsIQuestScheduleDistanceValue()).Value;
			default:
				return 0;
			}
		}
	}
}
