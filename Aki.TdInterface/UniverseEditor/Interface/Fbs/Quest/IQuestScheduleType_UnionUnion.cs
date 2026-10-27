using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004047 RID: 16455
	public class IQuestScheduleType_UnionUnion
	{
		// Token: 0x170073D0 RID: 29648
		// (get) Token: 0x06017D28 RID: 97576 RVA: 0x0036FC85 File Offset: 0x0036DE85
		// (set) Token: 0x06017D29 RID: 97577 RVA: 0x0036FC8D File Offset: 0x0036DE8D
		public IQuestScheduleType_Union Type { get; set; }

		// Token: 0x170073D1 RID: 29649
		// (get) Token: 0x06017D2A RID: 97578 RVA: 0x0036FC96 File Offset: 0x0036DE96
		// (set) Token: 0x06017D2B RID: 97579 RVA: 0x0036FC9E File Offset: 0x0036DE9E
		public object Value { get; set; }

		// Token: 0x06017D2C RID: 97580 RVA: 0x0036FCA7 File Offset: 0x0036DEA7
		public IQuestScheduleType_UnionUnion()
		{
			this.Type = IQuestScheduleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017D2D RID: 97581 RVA: 0x0036FCBD File Offset: 0x0036DEBD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017D2E RID: 97582 RVA: 0x0036FCCF File Offset: 0x0036DECF
		public IQuestScheduleTypeT AsIQuestScheduleType()
		{
			return this.As<IQuestScheduleTypeT>();
		}

		// Token: 0x06017D2F RID: 97583 RVA: 0x0036FCD7 File Offset: 0x0036DED7
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleType(IQuestScheduleTypeT _iquestscheduletype)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleType,
				Value = _iquestscheduletype
			};
		}

		// Token: 0x06017D30 RID: 97584 RVA: 0x0036FCEC File Offset: 0x0036DEEC
		public IQuestScheduleNoneT AsIQuestScheduleNone()
		{
			return this.As<IQuestScheduleNoneT>();
		}

		// Token: 0x06017D31 RID: 97585 RVA: 0x0036FCF4 File Offset: 0x0036DEF4
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleNone(IQuestScheduleNoneT _iquestschedulenone)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleNone,
				Value = _iquestschedulenone
			};
		}

		// Token: 0x06017D32 RID: 97586 RVA: 0x0036FD09 File Offset: 0x0036DF09
		public IQuestScheduleEntityHPT AsIQuestScheduleEntityHP()
		{
			return this.As<IQuestScheduleEntityHPT>();
		}

		// Token: 0x06017D33 RID: 97587 RVA: 0x0036FD11 File Offset: 0x0036DF11
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleEntityHP(IQuestScheduleEntityHPT _iquestscheduleentityhp)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleEntityHP,
				Value = _iquestscheduleentityhp
			};
		}

		// Token: 0x06017D34 RID: 97588 RVA: 0x0036FD26 File Offset: 0x0036DF26
		public IQuestScheduleScoreT AsIQuestScheduleScore()
		{
			return this.As<IQuestScheduleScoreT>();
		}

		// Token: 0x06017D35 RID: 97589 RVA: 0x0036FD2E File Offset: 0x0036DF2E
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleScore(IQuestScheduleScoreT _iquestschedulescore)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleScore,
				Value = _iquestschedulescore
			};
		}

		// Token: 0x06017D36 RID: 97590 RVA: 0x0036FD43 File Offset: 0x0036DF43
		public IQuestScheduleChildQuestCompletedT AsIQuestScheduleChildQuestCompleted()
		{
			return this.As<IQuestScheduleChildQuestCompletedT>();
		}

		// Token: 0x06017D37 RID: 97591 RVA: 0x0036FD4B File Offset: 0x0036DF4B
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleChildQuestCompleted(IQuestScheduleChildQuestCompletedT _iquestschedulechildquestcompleted)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleChildQuestCompleted,
				Value = _iquestschedulechildquestcompleted
			};
		}

		// Token: 0x06017D38 RID: 97592 RVA: 0x0036FD60 File Offset: 0x0036DF60
		public IQuestScheduleChildQuestCompletedCountT AsIQuestScheduleChildQuestCompletedCount()
		{
			return this.As<IQuestScheduleChildQuestCompletedCountT>();
		}

		// Token: 0x06017D39 RID: 97593 RVA: 0x0036FD68 File Offset: 0x0036DF68
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleChildQuestCompletedCount(IQuestScheduleChildQuestCompletedCountT _iquestschedulechildquestcompletedcount)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleChildQuestCompletedCount,
				Value = _iquestschedulechildquestcompletedcount
			};
		}

		// Token: 0x06017D3A RID: 97594 RVA: 0x0036FD7D File Offset: 0x0036DF7D
		public IQuestScheduleTowerChallengeTitleT AsIQuestScheduleTowerChallengeTitle()
		{
			return this.As<IQuestScheduleTowerChallengeTitleT>();
		}

		// Token: 0x06017D3B RID: 97595 RVA: 0x0036FD85 File Offset: 0x0036DF85
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleTowerChallengeTitle(IQuestScheduleTowerChallengeTitleT _iquestscheduletowerchallengetitle)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleTowerChallengeTitle,
				Value = _iquestscheduletowerchallengetitle
			};
		}

		// Token: 0x06017D3C RID: 97596 RVA: 0x0036FD9A File Offset: 0x0036DF9A
		public IQuestScheduleRoleTowerChallengeTitleT AsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.As<IQuestScheduleRoleTowerChallengeTitleT>();
		}

		// Token: 0x06017D3D RID: 97597 RVA: 0x0036FDA2 File Offset: 0x0036DFA2
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleRoleTowerChallengeTitle(IQuestScheduleRoleTowerChallengeTitleT _iquestscheduleroletowerchallengetitle)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleRoleTowerChallengeTitle,
				Value = _iquestscheduleroletowerchallengetitle
			};
		}

		// Token: 0x06017D3E RID: 97598 RVA: 0x0036FDB7 File Offset: 0x0036DFB7
		public IQuestScheduleBtTreeVarT AsIQuestScheduleBtTreeVar()
		{
			return this.As<IQuestScheduleBtTreeVarT>();
		}

		// Token: 0x06017D3F RID: 97599 RVA: 0x0036FDBF File Offset: 0x0036DFBF
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleBtTreeVar(IQuestScheduleBtTreeVarT _iquestschedulebttreevar)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleBtTreeVar,
				Value = _iquestschedulebttreevar
			};
		}

		// Token: 0x06017D40 RID: 97600 RVA: 0x0036FDD5 File Offset: 0x0036DFD5
		public IQuestScheduleMultiBtTreeVarT AsIQuestScheduleMultiBtTreeVar()
		{
			return this.As<IQuestScheduleMultiBtTreeVarT>();
		}

		// Token: 0x06017D41 RID: 97601 RVA: 0x0036FDDD File Offset: 0x0036DFDD
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleMultiBtTreeVar(IQuestScheduleMultiBtTreeVarT _iquestschedulemultibttreevar)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleMultiBtTreeVar,
				Value = _iquestschedulemultibttreevar
			};
		}

		// Token: 0x06017D42 RID: 97602 RVA: 0x0036FDF3 File Offset: 0x0036DFF3
		public IQuestScheduleTimeLeftT AsIQuestScheduleTimeLeft()
		{
			return this.As<IQuestScheduleTimeLeftT>();
		}

		// Token: 0x06017D43 RID: 97603 RVA: 0x0036FDFB File Offset: 0x0036DFFB
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleTimeLeft(IQuestScheduleTimeLeftT _iquestscheduletimeleft)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleTimeLeft,
				Value = _iquestscheduletimeleft
			};
		}

		// Token: 0x06017D44 RID: 97604 RVA: 0x0036FE11 File Offset: 0x0036E011
		public IQuestScheduleMeetConditionT AsIQuestScheduleMeetCondition()
		{
			return this.As<IQuestScheduleMeetConditionT>();
		}

		// Token: 0x06017D45 RID: 97605 RVA: 0x0036FE19 File Offset: 0x0036E019
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleMeetCondition(IQuestScheduleMeetConditionT _iquestschedulemeetcondition)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleMeetCondition,
				Value = _iquestschedulemeetcondition
			};
		}

		// Token: 0x06017D46 RID: 97606 RVA: 0x0036FE2F File Offset: 0x0036E02F
		public IQuestScheduleProgressValueT AsIQuestScheduleProgressValue()
		{
			return this.As<IQuestScheduleProgressValueT>();
		}

		// Token: 0x06017D47 RID: 97607 RVA: 0x0036FE37 File Offset: 0x0036E037
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleProgressValue(IQuestScheduleProgressValueT _iquestscheduleprogressvalue)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleProgressValue,
				Value = _iquestscheduleprogressvalue
			};
		}

		// Token: 0x06017D48 RID: 97608 RVA: 0x0036FE4D File Offset: 0x0036E04D
		public IQuestScheduleDistanceValueT AsIQuestScheduleDistanceValue()
		{
			return this.As<IQuestScheduleDistanceValueT>();
		}

		// Token: 0x06017D49 RID: 97609 RVA: 0x0036FE55 File Offset: 0x0036E055
		public static IQuestScheduleType_UnionUnion FromIQuestScheduleDistanceValue(IQuestScheduleDistanceValueT _iquestscheduledistancevalue)
		{
			return new IQuestScheduleType_UnionUnion
			{
				Type = IQuestScheduleType_Union.IQuestScheduleDistanceValue,
				Value = _iquestscheduledistancevalue
			};
		}

		// Token: 0x06017D4A RID: 97610 RVA: 0x0036FE6C File Offset: 0x0036E06C
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
