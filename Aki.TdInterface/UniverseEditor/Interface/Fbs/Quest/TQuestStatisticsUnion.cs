using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200475F RID: 18271
	public class TQuestStatisticsUnion
	{
		// Token: 0x17007F95 RID: 32661
		// (get) Token: 0x0601AE81 RID: 110209 RVA: 0x003D119F File Offset: 0x003CF39F
		// (set) Token: 0x0601AE82 RID: 110210 RVA: 0x003D11A7 File Offset: 0x003CF3A7
		public TQuestStatistics Type { get; set; }

		// Token: 0x17007F96 RID: 32662
		// (get) Token: 0x0601AE83 RID: 110211 RVA: 0x003D11B0 File Offset: 0x003CF3B0
		// (set) Token: 0x0601AE84 RID: 110212 RVA: 0x003D11B8 File Offset: 0x003CF3B8
		public object Value { get; set; }

		// Token: 0x0601AE85 RID: 110213 RVA: 0x003D11C1 File Offset: 0x003CF3C1
		public TQuestStatisticsUnion()
		{
			this.Type = TQuestStatistics.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE86 RID: 110214 RVA: 0x003D11D7 File Offset: 0x003CF3D7
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE87 RID: 110215 RVA: 0x003D11E9 File Offset: 0x003CF3E9
		public IQuestMechaTrackScoreT AsIQuestMechaTrackScore()
		{
			return this.As<IQuestMechaTrackScoreT>();
		}

		// Token: 0x0601AE88 RID: 110216 RVA: 0x003D11F1 File Offset: 0x003CF3F1
		public static TQuestStatisticsUnion FromIQuestMechaTrackScore(IQuestMechaTrackScoreT _iquestmechatrackscore)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestMechaTrackScore,
				Value = _iquestmechatrackscore
			};
		}

		// Token: 0x0601AE89 RID: 110217 RVA: 0x003D1206 File Offset: 0x003CF406
		public IQuestMonsterHealthScoreT AsIQuestMonsterHealthScore()
		{
			return this.As<IQuestMonsterHealthScoreT>();
		}

		// Token: 0x0601AE8A RID: 110218 RVA: 0x003D120E File Offset: 0x003CF40E
		public static TQuestStatisticsUnion FromIQuestMonsterHealthScore(IQuestMonsterHealthScoreT _iquestmonsterhealthscore)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestMonsterHealthScore,
				Value = _iquestmonsterhealthscore
			};
		}

		// Token: 0x0601AE8B RID: 110219 RVA: 0x003D1223 File Offset: 0x003CF423
		public IQuestMonsterPointT AsIQuestMonsterPoint()
		{
			return this.As<IQuestMonsterPointT>();
		}

		// Token: 0x0601AE8C RID: 110220 RVA: 0x003D122B File Offset: 0x003CF42B
		public static TQuestStatisticsUnion FromIQuestMonsterPoint(IQuestMonsterPointT _iquestmonsterpoint)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestMonsterPoint,
				Value = _iquestmonsterpoint
			};
		}

		// Token: 0x0601AE8D RID: 110221 RVA: 0x003D1240 File Offset: 0x003CF440
		public IQuestMonsterRemainingHealthT AsIQuestMonsterRemainingHealth()
		{
			return this.As<IQuestMonsterRemainingHealthT>();
		}

		// Token: 0x0601AE8E RID: 110222 RVA: 0x003D1248 File Offset: 0x003CF448
		public static TQuestStatisticsUnion FromIQuestMonsterRemainingHealth(IQuestMonsterRemainingHealthT _iquestmonsterremaininghealth)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestMonsterRemainingHealth,
				Value = _iquestmonsterremaininghealth
			};
		}

		// Token: 0x0601AE8F RID: 110223 RVA: 0x003D125D File Offset: 0x003CF45D
		public IQuestPlayerHitStatisticsT AsIQuestPlayerHitStatistics()
		{
			return this.As<IQuestPlayerHitStatisticsT>();
		}

		// Token: 0x0601AE90 RID: 110224 RVA: 0x003D1265 File Offset: 0x003CF465
		public static TQuestStatisticsUnion FromIQuestPlayerHitStatistics(IQuestPlayerHitStatisticsT _iquestplayerhitstatistics)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestPlayerHitStatistics,
				Value = _iquestplayerhitstatistics
			};
		}

		// Token: 0x0601AE91 RID: 110225 RVA: 0x003D127A File Offset: 0x003CF47A
		public IQuestStaticTimerT AsIQuestStaticTimer()
		{
			return this.As<IQuestStaticTimerT>();
		}

		// Token: 0x0601AE92 RID: 110226 RVA: 0x003D1282 File Offset: 0x003CF482
		public static TQuestStatisticsUnion FromIQuestStaticTimer(IQuestStaticTimerT _iqueststatictimer)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStaticTimer,
				Value = _iqueststatictimer
			};
		}

		// Token: 0x0601AE93 RID: 110227 RVA: 0x003D1297 File Offset: 0x003CF497
		public IQuestStatisticsCollectT AsIQuestStatisticsCollect()
		{
			return this.As<IQuestStatisticsCollectT>();
		}

		// Token: 0x0601AE94 RID: 110228 RVA: 0x003D129F File Offset: 0x003CF49F
		public static TQuestStatisticsUnion FromIQuestStatisticsCollect(IQuestStatisticsCollectT _iqueststatisticscollect)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStatisticsCollect,
				Value = _iqueststatisticscollect
			};
		}

		// Token: 0x0601AE95 RID: 110229 RVA: 0x003D12B4 File Offset: 0x003CF4B4
		public IQuestStatisticsPlayerTriggerMotionT AsIQuestStatisticsPlayerTriggerMotion()
		{
			return this.As<IQuestStatisticsPlayerTriggerMotionT>();
		}

		// Token: 0x0601AE96 RID: 110230 RVA: 0x003D12BC File Offset: 0x003CF4BC
		public static TQuestStatisticsUnion FromIQuestStatisticsPlayerTriggerMotion(IQuestStatisticsPlayerTriggerMotionT _iqueststatisticsplayertriggermotion)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStatisticsPlayerTriggerMotion,
				Value = _iqueststatisticsplayertriggermotion
			};
		}

		// Token: 0x0601AE97 RID: 110231 RVA: 0x003D12D1 File Offset: 0x003CF4D1
		public IQuestStatisticsUseSkillT AsIQuestStatisticsUseSkill()
		{
			return this.As<IQuestStatisticsUseSkillT>();
		}

		// Token: 0x0601AE98 RID: 110232 RVA: 0x003D12D9 File Offset: 0x003CF4D9
		public static TQuestStatisticsUnion FromIQuestStatisticsUseSkill(IQuestStatisticsUseSkillT _iqueststatisticsuseskill)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStatisticsUseSkill,
				Value = _iqueststatisticsuseskill
			};
		}

		// Token: 0x0601AE99 RID: 110233 RVA: 0x003D12EF File Offset: 0x003CF4EF
		public IQuestStatisticsUseSkillNewT AsIQuestStatisticsUseSkillNew()
		{
			return this.As<IQuestStatisticsUseSkillNewT>();
		}

		// Token: 0x0601AE9A RID: 110234 RVA: 0x003D12F7 File Offset: 0x003CF4F7
		public static TQuestStatisticsUnion FromIQuestStatisticsUseSkillNew(IQuestStatisticsUseSkillNewT _iqueststatisticsuseskillnew)
		{
			return new TQuestStatisticsUnion
			{
				Type = TQuestStatistics.IQuestStatisticsUseSkillNew,
				Value = _iqueststatisticsuseskillnew
			};
		}

		// Token: 0x0601AE9B RID: 110235 RVA: 0x003D1310 File Offset: 0x003CF510
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
