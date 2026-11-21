using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200475C RID: 18268
	public class TQuestScheduleUnion
	{
		// Token: 0x17007F93 RID: 32659
		// (get) Token: 0x0601AE5F RID: 110175 RVA: 0x003D0DC2 File Offset: 0x003CEFC2
		// (set) Token: 0x0601AE60 RID: 110176 RVA: 0x003D0DCA File Offset: 0x003CEFCA
		public TQuestSchedule Type { get; set; }

		// Token: 0x17007F94 RID: 32660
		// (get) Token: 0x0601AE61 RID: 110177 RVA: 0x003D0DD3 File Offset: 0x003CEFD3
		// (set) Token: 0x0601AE62 RID: 110178 RVA: 0x003D0DDB File Offset: 0x003CEFDB
		public object Value { get; set; }

		// Token: 0x0601AE63 RID: 110179 RVA: 0x003D0DE4 File Offset: 0x003CEFE4
		public TQuestScheduleUnion()
		{
			this.Type = TQuestSchedule.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE64 RID: 110180 RVA: 0x003D0DFA File Offset: 0x003CEFFA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE65 RID: 110181 RVA: 0x003D0E0C File Offset: 0x003CF00C
		public IQuestScheduleBtTreeVarT AsIQuestScheduleBtTreeVar()
		{
			return this.As<IQuestScheduleBtTreeVarT>();
		}

		// Token: 0x0601AE66 RID: 110182 RVA: 0x003D0E14 File Offset: 0x003CF014
		public static TQuestScheduleUnion FromIQuestScheduleBtTreeVar(IQuestScheduleBtTreeVarT _iquestschedulebttreevar)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleBtTreeVar,
				Value = _iquestschedulebttreevar
			};
		}

		// Token: 0x0601AE67 RID: 110183 RVA: 0x003D0E29 File Offset: 0x003CF029
		public IQuestScheduleChildQuestCompletedT AsIQuestScheduleChildQuestCompleted()
		{
			return this.As<IQuestScheduleChildQuestCompletedT>();
		}

		// Token: 0x0601AE68 RID: 110184 RVA: 0x003D0E31 File Offset: 0x003CF031
		public static TQuestScheduleUnion FromIQuestScheduleChildQuestCompleted(IQuestScheduleChildQuestCompletedT _iquestschedulechildquestcompleted)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleChildQuestCompleted,
				Value = _iquestschedulechildquestcompleted
			};
		}

		// Token: 0x0601AE69 RID: 110185 RVA: 0x003D0E46 File Offset: 0x003CF046
		public IQuestScheduleChildQuestCompletedCountT AsIQuestScheduleChildQuestCompletedCount()
		{
			return this.As<IQuestScheduleChildQuestCompletedCountT>();
		}

		// Token: 0x0601AE6A RID: 110186 RVA: 0x003D0E4E File Offset: 0x003CF04E
		public static TQuestScheduleUnion FromIQuestScheduleChildQuestCompletedCount(IQuestScheduleChildQuestCompletedCountT _iquestschedulechildquestcompletedcount)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleChildQuestCompletedCount,
				Value = _iquestschedulechildquestcompletedcount
			};
		}

		// Token: 0x0601AE6B RID: 110187 RVA: 0x003D0E63 File Offset: 0x003CF063
		public IQuestScheduleDistanceValueT AsIQuestScheduleDistanceValue()
		{
			return this.As<IQuestScheduleDistanceValueT>();
		}

		// Token: 0x0601AE6C RID: 110188 RVA: 0x003D0E6B File Offset: 0x003CF06B
		public static TQuestScheduleUnion FromIQuestScheduleDistanceValue(IQuestScheduleDistanceValueT _iquestscheduledistancevalue)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleDistanceValue,
				Value = _iquestscheduledistancevalue
			};
		}

		// Token: 0x0601AE6D RID: 110189 RVA: 0x003D0E80 File Offset: 0x003CF080
		public IQuestScheduleEntityHPT AsIQuestScheduleEntityHP()
		{
			return this.As<IQuestScheduleEntityHPT>();
		}

		// Token: 0x0601AE6E RID: 110190 RVA: 0x003D0E88 File Offset: 0x003CF088
		public static TQuestScheduleUnion FromIQuestScheduleEntityHP(IQuestScheduleEntityHPT _iquestscheduleentityhp)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleEntityHP,
				Value = _iquestscheduleentityhp
			};
		}

		// Token: 0x0601AE6F RID: 110191 RVA: 0x003D0E9D File Offset: 0x003CF09D
		public IQuestScheduleMeetConditionT AsIQuestScheduleMeetCondition()
		{
			return this.As<IQuestScheduleMeetConditionT>();
		}

		// Token: 0x0601AE70 RID: 110192 RVA: 0x003D0EA5 File Offset: 0x003CF0A5
		public static TQuestScheduleUnion FromIQuestScheduleMeetCondition(IQuestScheduleMeetConditionT _iquestschedulemeetcondition)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleMeetCondition,
				Value = _iquestschedulemeetcondition
			};
		}

		// Token: 0x0601AE71 RID: 110193 RVA: 0x003D0EBA File Offset: 0x003CF0BA
		public IQuestScheduleMultiBtTreeVarT AsIQuestScheduleMultiBtTreeVar()
		{
			return this.As<IQuestScheduleMultiBtTreeVarT>();
		}

		// Token: 0x0601AE72 RID: 110194 RVA: 0x003D0EC2 File Offset: 0x003CF0C2
		public static TQuestScheduleUnion FromIQuestScheduleMultiBtTreeVar(IQuestScheduleMultiBtTreeVarT _iquestschedulemultibttreevar)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleMultiBtTreeVar,
				Value = _iquestschedulemultibttreevar
			};
		}

		// Token: 0x0601AE73 RID: 110195 RVA: 0x003D0ED7 File Offset: 0x003CF0D7
		public IQuestScheduleNoneT AsIQuestScheduleNone()
		{
			return this.As<IQuestScheduleNoneT>();
		}

		// Token: 0x0601AE74 RID: 110196 RVA: 0x003D0EDF File Offset: 0x003CF0DF
		public static TQuestScheduleUnion FromIQuestScheduleNone(IQuestScheduleNoneT _iquestschedulenone)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleNone,
				Value = _iquestschedulenone
			};
		}

		// Token: 0x0601AE75 RID: 110197 RVA: 0x003D0EF4 File Offset: 0x003CF0F4
		public IQuestScheduleProgressValueT AsIQuestScheduleProgressValue()
		{
			return this.As<IQuestScheduleProgressValueT>();
		}

		// Token: 0x0601AE76 RID: 110198 RVA: 0x003D0EFC File Offset: 0x003CF0FC
		public static TQuestScheduleUnion FromIQuestScheduleProgressValue(IQuestScheduleProgressValueT _iquestscheduleprogressvalue)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleProgressValue,
				Value = _iquestscheduleprogressvalue
			};
		}

		// Token: 0x0601AE77 RID: 110199 RVA: 0x003D0F12 File Offset: 0x003CF112
		public IQuestScheduleRoleTowerChallengeTitleT AsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.As<IQuestScheduleRoleTowerChallengeTitleT>();
		}

		// Token: 0x0601AE78 RID: 110200 RVA: 0x003D0F1A File Offset: 0x003CF11A
		public static TQuestScheduleUnion FromIQuestScheduleRoleTowerChallengeTitle(IQuestScheduleRoleTowerChallengeTitleT _iquestscheduleroletowerchallengetitle)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleRoleTowerChallengeTitle,
				Value = _iquestscheduleroletowerchallengetitle
			};
		}

		// Token: 0x0601AE79 RID: 110201 RVA: 0x003D0F30 File Offset: 0x003CF130
		public IQuestScheduleScoreT AsIQuestScheduleScore()
		{
			return this.As<IQuestScheduleScoreT>();
		}

		// Token: 0x0601AE7A RID: 110202 RVA: 0x003D0F38 File Offset: 0x003CF138
		public static TQuestScheduleUnion FromIQuestScheduleScore(IQuestScheduleScoreT _iquestschedulescore)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleScore,
				Value = _iquestschedulescore
			};
		}

		// Token: 0x0601AE7B RID: 110203 RVA: 0x003D0F4E File Offset: 0x003CF14E
		public IQuestScheduleTimeLeftT AsIQuestScheduleTimeLeft()
		{
			return this.As<IQuestScheduleTimeLeftT>();
		}

		// Token: 0x0601AE7C RID: 110204 RVA: 0x003D0F56 File Offset: 0x003CF156
		public static TQuestScheduleUnion FromIQuestScheduleTimeLeft(IQuestScheduleTimeLeftT _iquestscheduletimeleft)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleTimeLeft,
				Value = _iquestscheduletimeleft
			};
		}

		// Token: 0x0601AE7D RID: 110205 RVA: 0x003D0F6C File Offset: 0x003CF16C
		public IQuestScheduleTowerChallengeTitleT AsIQuestScheduleTowerChallengeTitle()
		{
			return this.As<IQuestScheduleTowerChallengeTitleT>();
		}

		// Token: 0x0601AE7E RID: 110206 RVA: 0x003D0F74 File Offset: 0x003CF174
		public static TQuestScheduleUnion FromIQuestScheduleTowerChallengeTitle(IQuestScheduleTowerChallengeTitleT _iquestscheduletowerchallengetitle)
		{
			return new TQuestScheduleUnion
			{
				Type = TQuestSchedule.IQuestScheduleTowerChallengeTitle,
				Value = _iquestscheduletowerchallengetitle
			};
		}

		// Token: 0x0601AE7F RID: 110207 RVA: 0x003D0F8C File Offset: 0x003CF18C
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
