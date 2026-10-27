using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004059 RID: 16473
	public class IQuestStatisticsType_UnionUnion
	{
		// Token: 0x170073FA RID: 29690
		// (get) Token: 0x06017E0C RID: 97804 RVA: 0x0037225C File Offset: 0x0037045C
		// (set) Token: 0x06017E0D RID: 97805 RVA: 0x00372264 File Offset: 0x00370464
		public IQuestStatisticsType_Union Type { get; set; }

		// Token: 0x170073FB RID: 29691
		// (get) Token: 0x06017E0E RID: 97806 RVA: 0x0037226D File Offset: 0x0037046D
		// (set) Token: 0x06017E0F RID: 97807 RVA: 0x00372275 File Offset: 0x00370475
		public object Value { get; set; }

		// Token: 0x06017E10 RID: 97808 RVA: 0x0037227E File Offset: 0x0037047E
		public IQuestStatisticsType_UnionUnion()
		{
			this.Type = IQuestStatisticsType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017E11 RID: 97809 RVA: 0x00372294 File Offset: 0x00370494
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017E12 RID: 97810 RVA: 0x003722A6 File Offset: 0x003704A6
		public IQuestStatisticsTypeT AsIQuestStatisticsType()
		{
			return this.As<IQuestStatisticsTypeT>();
		}

		// Token: 0x06017E13 RID: 97811 RVA: 0x003722AE File Offset: 0x003704AE
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsType(IQuestStatisticsTypeT _iqueststatisticstype)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsType,
				Value = _iqueststatisticstype
			};
		}

		// Token: 0x06017E14 RID: 97812 RVA: 0x003722C3 File Offset: 0x003704C3
		public IQuestStatisticsCollectT AsIQuestStatisticsCollect()
		{
			return this.As<IQuestStatisticsCollectT>();
		}

		// Token: 0x06017E15 RID: 97813 RVA: 0x003722CB File Offset: 0x003704CB
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsCollect(IQuestStatisticsCollectT _iqueststatisticscollect)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsCollect,
				Value = _iqueststatisticscollect
			};
		}

		// Token: 0x06017E16 RID: 97814 RVA: 0x003722E0 File Offset: 0x003704E0
		public IQuestStatisticsUseSkillT AsIQuestStatisticsUseSkill()
		{
			return this.As<IQuestStatisticsUseSkillT>();
		}

		// Token: 0x06017E17 RID: 97815 RVA: 0x003722E8 File Offset: 0x003704E8
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsUseSkill(IQuestStatisticsUseSkillT _iqueststatisticsuseskill)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsUseSkill,
				Value = _iqueststatisticsuseskill
			};
		}

		// Token: 0x06017E18 RID: 97816 RVA: 0x003722FD File Offset: 0x003704FD
		public IQuestStatisticsUseSkillNewT AsIQuestStatisticsUseSkillNew()
		{
			return this.As<IQuestStatisticsUseSkillNewT>();
		}

		// Token: 0x06017E19 RID: 97817 RVA: 0x00372305 File Offset: 0x00370505
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsUseSkillNew(IQuestStatisticsUseSkillNewT _iqueststatisticsuseskillnew)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsUseSkillNew,
				Value = _iqueststatisticsuseskillnew
			};
		}

		// Token: 0x06017E1A RID: 97818 RVA: 0x0037231A File Offset: 0x0037051A
		public IQuestStatisticsPlayerTriggerMotionT AsIQuestStatisticsPlayerTriggerMotion()
		{
			return this.As<IQuestStatisticsPlayerTriggerMotionT>();
		}

		// Token: 0x06017E1B RID: 97819 RVA: 0x00372322 File Offset: 0x00370522
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsPlayerTriggerMotion(IQuestStatisticsPlayerTriggerMotionT _iqueststatisticsplayertriggermotion)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsPlayerTriggerMotion,
				Value = _iqueststatisticsplayertriggermotion
			};
		}

		// Token: 0x06017E1C RID: 97820 RVA: 0x00372337 File Offset: 0x00370537
		public IQuestStaticTimerT AsIQuestStaticTimer()
		{
			return this.As<IQuestStaticTimerT>();
		}

		// Token: 0x06017E1D RID: 97821 RVA: 0x0037233F File Offset: 0x0037053F
		public static IQuestStatisticsType_UnionUnion FromIQuestStaticTimer(IQuestStaticTimerT _iqueststatictimer)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStaticTimer,
				Value = _iqueststatictimer
			};
		}

		// Token: 0x06017E1E RID: 97822 RVA: 0x00372354 File Offset: 0x00370554
		public IQuestMonsterPointT AsIQuestMonsterPoint()
		{
			return this.As<IQuestMonsterPointT>();
		}

		// Token: 0x06017E1F RID: 97823 RVA: 0x0037235C File Offset: 0x0037055C
		public static IQuestStatisticsType_UnionUnion FromIQuestMonsterPoint(IQuestMonsterPointT _iquestmonsterpoint)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestMonsterPoint,
				Value = _iquestmonsterpoint
			};
		}

		// Token: 0x06017E20 RID: 97824 RVA: 0x00372371 File Offset: 0x00370571
		public IQuestMonsterRemainingHealthT AsIQuestMonsterRemainingHealth()
		{
			return this.As<IQuestMonsterRemainingHealthT>();
		}

		// Token: 0x06017E21 RID: 97825 RVA: 0x00372379 File Offset: 0x00370579
		public static IQuestStatisticsType_UnionUnion FromIQuestMonsterRemainingHealth(IQuestMonsterRemainingHealthT _iquestmonsterremaininghealth)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestMonsterRemainingHealth,
				Value = _iquestmonsterremaininghealth
			};
		}

		// Token: 0x06017E22 RID: 97826 RVA: 0x0037238E File Offset: 0x0037058E
		public IQuestMonsterHealthScoreT AsIQuestMonsterHealthScore()
		{
			return this.As<IQuestMonsterHealthScoreT>();
		}

		// Token: 0x06017E23 RID: 97827 RVA: 0x00372396 File Offset: 0x00370596
		public static IQuestStatisticsType_UnionUnion FromIQuestMonsterHealthScore(IQuestMonsterHealthScoreT _iquestmonsterhealthscore)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestMonsterHealthScore,
				Value = _iquestmonsterhealthscore
			};
		}

		// Token: 0x06017E24 RID: 97828 RVA: 0x003723AC File Offset: 0x003705AC
		public IQuestPlayerHitStatisticsT AsIQuestPlayerHitStatistics()
		{
			return this.As<IQuestPlayerHitStatisticsT>();
		}

		// Token: 0x06017E25 RID: 97829 RVA: 0x003723B4 File Offset: 0x003705B4
		public static IQuestStatisticsType_UnionUnion FromIQuestPlayerHitStatistics(IQuestPlayerHitStatisticsT _iquestplayerhitstatistics)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestPlayerHitStatistics,
				Value = _iquestplayerhitstatistics
			};
		}

		// Token: 0x06017E26 RID: 97830 RVA: 0x003723CA File Offset: 0x003705CA
		public IQuestMechaTrackScoreT AsIQuestMechaTrackScore()
		{
			return this.As<IQuestMechaTrackScoreT>();
		}

		// Token: 0x06017E27 RID: 97831 RVA: 0x003723D2 File Offset: 0x003705D2
		public static IQuestStatisticsType_UnionUnion FromIQuestMechaTrackScore(IQuestMechaTrackScoreT _iquestmechatrackscore)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestMechaTrackScore,
				Value = _iquestmechatrackscore
			};
		}

		// Token: 0x06017E28 RID: 97832 RVA: 0x003723E8 File Offset: 0x003705E8
		public static int Pack(FlatBufferBuilder builder, IQuestStatisticsType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IQuestStatisticsType_Union.IQuestStatisticsType:
				return IQuestStatisticsType.Pack(builder, _o.AsIQuestStatisticsType()).Value;
			case IQuestStatisticsType_Union.IQuestStatisticsCollect:
				return IQuestStatisticsCollect.Pack(builder, _o.AsIQuestStatisticsCollect()).Value;
			case IQuestStatisticsType_Union.IQuestStatisticsUseSkill:
				return IQuestStatisticsUseSkill.Pack(builder, _o.AsIQuestStatisticsUseSkill()).Value;
			case IQuestStatisticsType_Union.IQuestStatisticsUseSkillNew:
				return IQuestStatisticsUseSkillNew.Pack(builder, _o.AsIQuestStatisticsUseSkillNew()).Value;
			case IQuestStatisticsType_Union.IQuestStatisticsPlayerTriggerMotion:
				return IQuestStatisticsPlayerTriggerMotion.Pack(builder, _o.AsIQuestStatisticsPlayerTriggerMotion()).Value;
			case IQuestStatisticsType_Union.IQuestStaticTimer:
				return IQuestStaticTimer.Pack(builder, _o.AsIQuestStaticTimer()).Value;
			case IQuestStatisticsType_Union.IQuestMonsterPoint:
				return IQuestMonsterPoint.Pack(builder, _o.AsIQuestMonsterPoint()).Value;
			case IQuestStatisticsType_Union.IQuestMonsterRemainingHealth:
				return IQuestMonsterRemainingHealth.Pack(builder, _o.AsIQuestMonsterRemainingHealth()).Value;
			case IQuestStatisticsType_Union.IQuestMonsterHealthScore:
				return IQuestMonsterHealthScore.Pack(builder, _o.AsIQuestMonsterHealthScore()).Value;
			case IQuestStatisticsType_Union.IQuestPlayerHitStatistics:
				return IQuestPlayerHitStatistics.Pack(builder, _o.AsIQuestPlayerHitStatistics()).Value;
			case IQuestStatisticsType_Union.IQuestMechaTrackScore:
				return IQuestMechaTrackScore.Pack(builder, _o.AsIQuestMechaTrackScore()).Value;
			default:
				return 0;
			}
		}
	}
}
