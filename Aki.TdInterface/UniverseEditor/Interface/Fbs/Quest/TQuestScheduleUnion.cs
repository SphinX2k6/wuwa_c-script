using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042FD RID: 17149
	public class TQuestScheduleUnion
	{
		// Token: 0x17007960 RID: 31072
		// (get) Token: 0x060196DD RID: 104157 RVA: 0x003A5492 File Offset: 0x003A3692
		// (set) Token: 0x060196DE RID: 104158 RVA: 0x003A549A File Offset: 0x003A369A
		public TQuestSchedule Type { get; set; }

		// Token: 0x17007961 RID: 31073
		// (get) Token: 0x060196DF RID: 104159 RVA: 0x003A54A3 File Offset: 0x003A36A3
		// (set) Token: 0x060196E0 RID: 104160 RVA: 0x003A54AB File Offset: 0x003A36AB
		public object Value { get; set; }

		// Token: 0x060196E1 RID: 104161 RVA: 0x003A54B4 File Offset: 0x003A36B4
		public TQuestScheduleUnion()
		{
			this.Type = TQuestSchedule.NONE;
			this.Value = null;
		}

		// Token: 0x060196E2 RID: 104162 RVA: 0x003A54CA File Offset: 0x003A36CA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060196E3 RID: 104163 RVA: 0x003A54DC File Offset: 0x003A36DC
		public IQuestScheduleBtTreeVarT AsIQuestScheduleBtTreeVar()
		{
			return this.As<IQuestScheduleBtTreeVarT>();
		}

		// Token: 0x060196E4 RID: 104164 RVA: 0x003A54E4 File Offset: 0x003A36E4
		public static TQuestScheduleUnion FromIQuestScheduleBtTreeVar(IQuestScheduleBtTreeVarT _iquestschedulebttreevar)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleBtTreeVar,
				Value = _iquestschedulebttreevar
			};
		}

		// Token: 0x060196E5 RID: 104165 RVA: 0x003A54F9 File Offset: 0x003A36F9
		public IQuestScheduleChildQuestCompletedT AsIQuestScheduleChildQuestCompleted()
		{
			return this.As<IQuestScheduleChildQuestCompletedT>();
		}

		// Token: 0x060196E6 RID: 104166 RVA: 0x003A5501 File Offset: 0x003A3701
		public static TQuestScheduleUnion FromIQuestScheduleChildQuestCompleted(IQuestScheduleChildQuestCompletedT _iquestschedulechildquestcompleted)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleChildQuestCompleted,
				Value = _iquestschedulechildquestcompleted
			};
		}

		// Token: 0x060196E7 RID: 104167 RVA: 0x003A5516 File Offset: 0x003A3716
		public IQuestScheduleChildQuestCompletedCountT AsIQuestScheduleChildQuestCompletedCount()
		{
			return this.As<IQuestScheduleChildQuestCompletedCountT>();
		}

		// Token: 0x060196E8 RID: 104168 RVA: 0x003A551E File Offset: 0x003A371E
		public static TQuestScheduleUnion FromIQuestScheduleChildQuestCompletedCount(IQuestScheduleChildQuestCompletedCountT _iquestschedulechildquestcompletedcount)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleChildQuestCompletedCount,
				Value = _iquestschedulechildquestcompletedcount
			};
		}

		// Token: 0x060196E9 RID: 104169 RVA: 0x003A5533 File Offset: 0x003A3733
		public IQuestScheduleDistanceValueT AsIQuestScheduleDistanceValue()
		{
			return this.As<IQuestScheduleDistanceValueT>();
		}

		// Token: 0x060196EA RID: 104170 RVA: 0x003A553B File Offset: 0x003A373B
		public static TQuestScheduleUnion FromIQuestScheduleDistanceValue(IQuestScheduleDistanceValueT _iquestscheduledistancevalue)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleDistanceValue,
				Value = _iquestscheduledistancevalue
			};
		}

		// Token: 0x060196EB RID: 104171 RVA: 0x003A5550 File Offset: 0x003A3750
		public IQuestScheduleEntityHPT AsIQuestScheduleEntityHP()
		{
			return this.As<IQuestScheduleEntityHPT>();
		}

		// Token: 0x060196EC RID: 104172 RVA: 0x003A5558 File Offset: 0x003A3758
		public static TQuestScheduleUnion FromIQuestScheduleEntityHP(IQuestScheduleEntityHPT _iquestscheduleentityhp)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleEntityHP,
				Value = _iquestscheduleentityhp
			};
		}

		// Token: 0x060196ED RID: 104173 RVA: 0x003A556D File Offset: 0x003A376D
		public IQuestScheduleMeetConditionT AsIQuestScheduleMeetCondition()
		{
			return this.As<IQuestScheduleMeetConditionT>();
		}

		// Token: 0x060196EE RID: 104174 RVA: 0x003A5575 File Offset: 0x003A3775
		public static TQuestScheduleUnion FromIQuestScheduleMeetCondition(IQuestScheduleMeetConditionT _iquestschedulemeetcondition)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleMeetCondition,
				Value = _iquestschedulemeetcondition
			};
		}

		// Token: 0x060196EF RID: 104175 RVA: 0x003A558A File Offset: 0x003A378A
		public IQuestScheduleMultiBtTreeVarT AsIQuestScheduleMultiBtTreeVar()
		{
			return this.As<IQuestScheduleMultiBtTreeVarT>();
		}

		// Token: 0x060196F0 RID: 104176 RVA: 0x003A5592 File Offset: 0x003A3792
		public static TQuestScheduleUnion FromIQuestScheduleMultiBtTreeVar(IQuestScheduleMultiBtTreeVarT _iquestschedulemultibttreevar)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleMultiBtTreeVar,
				Value = _iquestschedulemultibttreevar
			};
		}

		// Token: 0x060196F1 RID: 104177 RVA: 0x003A55A7 File Offset: 0x003A37A7
		public IQuestScheduleNoneT AsIQuestScheduleNone()
		{
			return this.As<IQuestScheduleNoneT>();
		}

		// Token: 0x060196F2 RID: 104178 RVA: 0x003A55AF File Offset: 0x003A37AF
		public static TQuestScheduleUnion FromIQuestScheduleNone(IQuestScheduleNoneT _iquestschedulenone)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleNone,
				Value = _iquestschedulenone
			};
		}

		// Token: 0x060196F3 RID: 104179 RVA: 0x003A55C4 File Offset: 0x003A37C4
		public IQuestScheduleProgressValueT AsIQuestScheduleProgressValue()
		{
			return this.As<IQuestScheduleProgressValueT>();
		}

		// Token: 0x060196F4 RID: 104180 RVA: 0x003A55CC File Offset: 0x003A37CC
		public static TQuestScheduleUnion FromIQuestScheduleProgressValue(IQuestScheduleProgressValueT _iquestscheduleprogressvalue)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleProgressValue,
				Value = _iquestscheduleprogressvalue
			};
		}

		// Token: 0x060196F5 RID: 104181 RVA: 0x003A55E2 File Offset: 0x003A37E2
		public IQuestScheduleRoleTowerChallengeTitleT AsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.As<IQuestScheduleRoleTowerChallengeTitleT>();
		}

		// Token: 0x060196F6 RID: 104182 RVA: 0x003A55EA File Offset: 0x003A37EA
		public static TQuestScheduleUnion FromIQuestScheduleRoleTowerChallengeTitle(IQuestScheduleRoleTowerChallengeTitleT _iquestscheduleroletowerchallengetitle)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleRoleTowerChallengeTitle,
				Value = _iquestscheduleroletowerchallengetitle
			};
		}

		// Token: 0x060196F7 RID: 104183 RVA: 0x003A5600 File Offset: 0x003A3800
		public IQuestScheduleScoreT AsIQuestScheduleScore()
		{
			return this.As<IQuestScheduleScoreT>();
		}

		// Token: 0x060196F8 RID: 104184 RVA: 0x003A5608 File Offset: 0x003A3808
		public static TQuestScheduleUnion FromIQuestScheduleScore(IQuestScheduleScoreT _iquestschedulescore)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleScore,
				Value = _iquestschedulescore
			};
		}

		// Token: 0x060196F9 RID: 104185 RVA: 0x003A561E File Offset: 0x003A381E
		public IQuestScheduleTimeLeftT AsIQuestScheduleTimeLeft()
		{
			return this.As<IQuestScheduleTimeLeftT>();
		}

		// Token: 0x060196FA RID: 104186 RVA: 0x003A5626 File Offset: 0x003A3826
		public static TQuestScheduleUnion FromIQuestScheduleTimeLeft(IQuestScheduleTimeLeftT _iquestscheduletimeleft)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleTimeLeft,
				Value = _iquestscheduletimeleft
			};
		}

		// Token: 0x060196FB RID: 104187 RVA: 0x003A563C File Offset: 0x003A383C
		public IQuestScheduleTowerChallengeTitleT AsIQuestScheduleTowerChallengeTitle()
		{
			return this.As<IQuestScheduleTowerChallengeTitleT>();
		}

		// Token: 0x060196FC RID: 104188 RVA: 0x003A5644 File Offset: 0x003A3844
		public static TQuestScheduleUnion FromIQuestScheduleTowerChallengeTitle(IQuestScheduleTowerChallengeTitleT _iquestscheduletowerchallengetitle)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleTowerChallengeTitle,
				Value = _iquestscheduletowerchallengetitle
			};
		}

		// Token: 0x060196FD RID: 104189 RVA: 0x003A565C File Offset: 0x003A385C
		public static int Pack(FlatBufferBuilder builder, TQuestScheduleUnion _o)
		{
			switch (_o.Type)
			{
			case TQuestSchedule.IQuestScheduleBtTreeVar:
				return IQuestScheduleBtTreeVar.Pack(builder, _o.AsIQuestScheduleBtTreeVar()).Value;
			case TQuestSchedule.IQuestScheduleChildQuestCompleted:
				return IQuestScheduleChildQuestCompleted.Pack(builder, _o.AsIQuestScheduleChildQuestCompleted()).Value;
			case TQuestSchedule.IQuestScheduleChildQuestCompletedCount:
				return IQuestScheduleChildQuestCompletedCount.Pack(builder, _o.AsIQuestScheduleChildQuestCompletedCount()).Value;
			case TQuestSchedule.IQuestScheduleDistanceValue:
				return IQuestScheduleDistanceValue.Pack(builder, _o.AsIQuestScheduleDistanceValue()).Value;
			case TQuestSchedule.IQuestScheduleEntityHP:
				return IQuestScheduleEntityHP.Pack(builder, _o.AsIQuestScheduleEntityHP()).Value;
			case TQuestSchedule.IQuestScheduleMeetCondition:
				return IQuestScheduleMeetCondition.Pack(builder, _o.AsIQuestScheduleMeetCondition()).Value;
			case TQuestSchedule.IQuestScheduleMultiBtTreeVar:
				return IQuestScheduleMultiBtTreeVar.Pack(builder, _o.AsIQuestScheduleMultiBtTreeVar()).Value;
			case TQuestSchedule.IQuestScheduleNone:
				return IQuestScheduleNone.Pack(builder, _o.AsIQuestScheduleNone()).Value;
			case TQuestSchedule.IQuestScheduleProgressValue:
				return IQuestScheduleProgressValue.Pack(builder, _o.AsIQuestScheduleProgressValue()).Value;
			case TQuestSchedule.IQuestScheduleRoleTowerChallengeTitle:
				return IQuestScheduleRoleTowerChallengeTitle.Pack(builder, _o.AsIQuestScheduleRoleTowerChallengeTitle()).Value;
			case TQuestSchedule.IQuestScheduleScore:
				return IQuestScheduleScore.Pack(builder, _o.AsIQuestScheduleScore()).Value;
			case TQuestSchedule.IQuestScheduleTimeLeft:
				return IQuestScheduleTimeLeft.Pack(builder, _o.AsIQuestScheduleTimeLeft()).Value;
			case TQuestSchedule.IQuestScheduleTowerChallengeTitle:
				return IQuestScheduleTowerChallengeTitle.Pack(builder, _o.AsIQuestScheduleTowerChallengeTitle()).Value;
			default:
				return 0;
			}
		}
	}
}
