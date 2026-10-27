using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004300 RID: 17152
	public class TQuestStatisticsUnion
	{
		// Token: 0x17007962 RID: 31074
		// (get) Token: 0x060196FF RID: 104191 RVA: 0x003A586F File Offset: 0x003A3A6F
		// (set) Token: 0x06019700 RID: 104192 RVA: 0x003A5877 File Offset: 0x003A3A77
		public TQuestStatistics Type { get; set; }

		// Token: 0x17007963 RID: 31075
		// (get) Token: 0x06019701 RID: 104193 RVA: 0x003A5880 File Offset: 0x003A3A80
		// (set) Token: 0x06019702 RID: 104194 RVA: 0x003A5888 File Offset: 0x003A3A88
		public object Value { get; set; }

		// Token: 0x06019703 RID: 104195 RVA: 0x003A5891 File Offset: 0x003A3A91
		public TQuestStatisticsUnion()
		{
			this.Type = TQuestStatistics.NONE;
			this.Value = null;
		}

		// Token: 0x06019704 RID: 104196 RVA: 0x003A58A7 File Offset: 0x003A3AA7
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019705 RID: 104197 RVA: 0x003A58B9 File Offset: 0x003A3AB9
		public IQuestMechaTrackScoreT AsIQuestMechaTrackScore()
		{
			return this.As<IQuestMechaTrackScoreT>();
		}

		// Token: 0x06019706 RID: 104198 RVA: 0x003A58C1 File Offset: 0x003A3AC1
		public static TQuestStatisticsUnion FromIQuestMechaTrackScore(IQuestMechaTrackScoreT _iquestmechatrackscore)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestMechaTrackScore,
				Value = _iquestmechatrackscore
			};
		}

		// Token: 0x06019707 RID: 104199 RVA: 0x003A58D6 File Offset: 0x003A3AD6
		public IQuestMonsterHealthScoreT AsIQuestMonsterHealthScore()
		{
			return this.As<IQuestMonsterHealthScoreT>();
		}

		// Token: 0x06019708 RID: 104200 RVA: 0x003A58DE File Offset: 0x003A3ADE
		public static TQuestStatisticsUnion FromIQuestMonsterHealthScore(IQuestMonsterHealthScoreT _iquestmonsterhealthscore)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestMonsterHealthScore,
				Value = _iquestmonsterhealthscore
			};
		}

		// Token: 0x06019709 RID: 104201 RVA: 0x003A58F3 File Offset: 0x003A3AF3
		public IQuestMonsterPointT AsIQuestMonsterPoint()
		{
			return this.As<IQuestMonsterPointT>();
		}

		// Token: 0x0601970A RID: 104202 RVA: 0x003A58FB File Offset: 0x003A3AFB
		public static TQuestStatisticsUnion FromIQuestMonsterPoint(IQuestMonsterPointT _iquestmonsterpoint)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestMonsterPoint,
				Value = _iquestmonsterpoint
			};
		}

		// Token: 0x0601970B RID: 104203 RVA: 0x003A5910 File Offset: 0x003A3B10
		public IQuestMonsterRemainingHealthT AsIQuestMonsterRemainingHealth()
		{
			return this.As<IQuestMonsterRemainingHealthT>();
		}

		// Token: 0x0601970C RID: 104204 RVA: 0x003A5918 File Offset: 0x003A3B18
		public static TQuestStatisticsUnion FromIQuestMonsterRemainingHealth(IQuestMonsterRemainingHealthT _iquestmonsterremaininghealth)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestMonsterRemainingHealth,
				Value = _iquestmonsterremaininghealth
			};
		}

		// Token: 0x0601970D RID: 104205 RVA: 0x003A592D File Offset: 0x003A3B2D
		public IQuestPlayerHitStatisticsT AsIQuestPlayerHitStatistics()
		{
			return this.As<IQuestPlayerHitStatisticsT>();
		}

		// Token: 0x0601970E RID: 104206 RVA: 0x003A5935 File Offset: 0x003A3B35
		public static TQuestStatisticsUnion FromIQuestPlayerHitStatistics(IQuestPlayerHitStatisticsT _iquestplayerhitstatistics)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestPlayerHitStatistics,
				Value = _iquestplayerhitstatistics
			};
		}

		// Token: 0x0601970F RID: 104207 RVA: 0x003A594A File Offset: 0x003A3B4A
		public IQuestStaticTimerT AsIQuestStaticTimer()
		{
			return this.As<IQuestStaticTimerT>();
		}

		// Token: 0x06019710 RID: 104208 RVA: 0x003A5952 File Offset: 0x003A3B52
		public static TQuestStatisticsUnion FromIQuestStaticTimer(IQuestStaticTimerT _iqueststatictimer)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStaticTimer,
				Value = _iqueststatictimer
			};
		}

		// Token: 0x06019711 RID: 104209 RVA: 0x003A5967 File Offset: 0x003A3B67
		public IQuestStatisticsCollectT AsIQuestStatisticsCollect()
		{
			return this.As<IQuestStatisticsCollectT>();
		}

		// Token: 0x06019712 RID: 104210 RVA: 0x003A596F File Offset: 0x003A3B6F
		public static TQuestStatisticsUnion FromIQuestStatisticsCollect(IQuestStatisticsCollectT _iqueststatisticscollect)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStatisticsCollect,
				Value = _iqueststatisticscollect
			};
		}

		// Token: 0x06019713 RID: 104211 RVA: 0x003A5984 File Offset: 0x003A3B84
		public IQuestStatisticsPlayerTriggerMotionT AsIQuestStatisticsPlayerTriggerMotion()
		{
			return this.As<IQuestStatisticsPlayerTriggerMotionT>();
		}

		// Token: 0x06019714 RID: 104212 RVA: 0x003A598C File Offset: 0x003A3B8C
		public static TQuestStatisticsUnion FromIQuestStatisticsPlayerTriggerMotion(IQuestStatisticsPlayerTriggerMotionT _iqueststatisticsplayertriggermotion)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStatisticsPlayerTriggerMotion,
				Value = _iqueststatisticsplayertriggermotion
			};
		}

		// Token: 0x06019715 RID: 104213 RVA: 0x003A59A1 File Offset: 0x003A3BA1
		public IQuestStatisticsUseSkillT AsIQuestStatisticsUseSkill()
		{
			return this.As<IQuestStatisticsUseSkillT>();
		}

		// Token: 0x06019716 RID: 104214 RVA: 0x003A59A9 File Offset: 0x003A3BA9
		public static TQuestStatisticsUnion FromIQuestStatisticsUseSkill(IQuestStatisticsUseSkillT _iqueststatisticsuseskill)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStatisticsUseSkill,
				Value = _iqueststatisticsuseskill
			};
		}

		// Token: 0x06019717 RID: 104215 RVA: 0x003A59BF File Offset: 0x003A3BBF
		public IQuestStatisticsUseSkillNewT AsIQuestStatisticsUseSkillNew()
		{
			return this.As<IQuestStatisticsUseSkillNewT>();
		}

		// Token: 0x06019718 RID: 104216 RVA: 0x003A59C7 File Offset: 0x003A3BC7
		public static TQuestStatisticsUnion FromIQuestStatisticsUseSkillNew(IQuestStatisticsUseSkillNewT _iqueststatisticsuseskillnew)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStatisticsUseSkillNew,
				Value = _iqueststatisticsuseskillnew
			};
		}

		// Token: 0x06019719 RID: 104217 RVA: 0x003A59E0 File Offset: 0x003A3BE0
		public static int Pack(FlatBufferBuilder builder, TQuestStatisticsUnion _o)
		{
			switch (_o.Type)
			{
			case TQuestStatistics.IQuestMechaTrackScore:
				return IQuestMechaTrackScore.Pack(builder, _o.AsIQuestMechaTrackScore()).Value;
			case TQuestStatistics.IQuestMonsterHealthScore:
				return IQuestMonsterHealthScore.Pack(builder, _o.AsIQuestMonsterHealthScore()).Value;
			case TQuestStatistics.IQuestMonsterPoint:
				return IQuestMonsterPoint.Pack(builder, _o.AsIQuestMonsterPoint()).Value;
			case TQuestStatistics.IQuestMonsterRemainingHealth:
				return IQuestMonsterRemainingHealth.Pack(builder, _o.AsIQuestMonsterRemainingHealth()).Value;
			case TQuestStatistics.IQuestPlayerHitStatistics:
				return IQuestPlayerHitStatistics.Pack(builder, _o.AsIQuestPlayerHitStatistics()).Value;
			case TQuestStatistics.IQuestStaticTimer:
				return IQuestStaticTimer.Pack(builder, _o.AsIQuestStaticTimer()).Value;
			case TQuestStatistics.IQuestStatisticsCollect:
				return IQuestStatisticsCollect.Pack(builder, _o.AsIQuestStatisticsCollect()).Value;
			case TQuestStatistics.IQuestStatisticsPlayerTriggerMotion:
				return IQuestStatisticsPlayerTriggerMotion.Pack(builder, _o.AsIQuestStatisticsPlayerTriggerMotion()).Value;
			case TQuestStatistics.IQuestStatisticsUseSkill:
				return IQuestStatisticsUseSkill.Pack(builder, _o.AsIQuestStatisticsUseSkill()).Value;
			case TQuestStatistics.IQuestStatisticsUseSkillNew:
				return IQuestStatisticsUseSkillNew.Pack(builder, _o.AsIQuestStatisticsUseSkillNew()).Value;
			default:
				return 0;
			}
		}
	}
}
