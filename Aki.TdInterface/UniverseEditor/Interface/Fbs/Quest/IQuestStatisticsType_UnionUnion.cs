using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200449A RID: 17562
	public class IQuestStatisticsType_UnionUnion
	{
		// Token: 0x170079FC RID: 31228
		// (get) Token: 0x060194A5 RID: 103589 RVA: 0x0039C050 File Offset: 0x0039A250
		// (set) Token: 0x060194A6 RID: 103590 RVA: 0x0039C058 File Offset: 0x0039A258
		public IQuestStatisticsType_Union Type { get; set; }

		// Token: 0x170079FD RID: 31229
		// (get) Token: 0x060194A7 RID: 103591 RVA: 0x0039C061 File Offset: 0x0039A261
		// (set) Token: 0x060194A8 RID: 103592 RVA: 0x0039C069 File Offset: 0x0039A269
		public object Value { get; set; }

		// Token: 0x060194A9 RID: 103593 RVA: 0x0039C072 File Offset: 0x0039A272
		public IQuestStatisticsType_UnionUnion()
		{
			this.Type = IQuestStatisticsType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060194AA RID: 103594 RVA: 0x0039C088 File Offset: 0x0039A288
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060194AB RID: 103595 RVA: 0x0039C09A File Offset: 0x0039A29A
		public IQuestStatisticsTypeT AsIQuestStatisticsType()
		{
			return this.As<IQuestStatisticsTypeT>();
		}

		// Token: 0x060194AC RID: 103596 RVA: 0x0039C0A2 File Offset: 0x0039A2A2
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsType(IQuestStatisticsTypeT _iqueststatisticstype)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsType,
				Value = _iqueststatisticstype
			};
		}

		// Token: 0x060194AD RID: 103597 RVA: 0x0039C0B7 File Offset: 0x0039A2B7
		public IQuestStatisticsCollectT AsIQuestStatisticsCollect()
		{
			return this.As<IQuestStatisticsCollectT>();
		}

		// Token: 0x060194AE RID: 103598 RVA: 0x0039C0BF File Offset: 0x0039A2BF
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsCollect(IQuestStatisticsCollectT _iqueststatisticscollect)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsCollect,
				Value = _iqueststatisticscollect
			};
		}

		// Token: 0x060194AF RID: 103599 RVA: 0x0039C0D4 File Offset: 0x0039A2D4
		public IQuestStatisticsUseSkillT AsIQuestStatisticsUseSkill()
		{
			return this.As<IQuestStatisticsUseSkillT>();
		}

		// Token: 0x060194B0 RID: 103600 RVA: 0x0039C0DC File Offset: 0x0039A2DC
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsUseSkill(IQuestStatisticsUseSkillT _iqueststatisticsuseskill)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsUseSkill,
				Value = _iqueststatisticsuseskill
			};
		}

		// Token: 0x060194B1 RID: 103601 RVA: 0x0039C0F1 File Offset: 0x0039A2F1
		public IQuestStatisticsUseSkillNewT AsIQuestStatisticsUseSkillNew()
		{
			return this.As<IQuestStatisticsUseSkillNewT>();
		}

		// Token: 0x060194B2 RID: 103602 RVA: 0x0039C0F9 File Offset: 0x0039A2F9
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsUseSkillNew(IQuestStatisticsUseSkillNewT _iqueststatisticsuseskillnew)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsUseSkillNew,
				Value = _iqueststatisticsuseskillnew
			};
		}

		// Token: 0x060194B3 RID: 103603 RVA: 0x0039C10E File Offset: 0x0039A30E
		public IQuestStatisticsPlayerTriggerMotionT AsIQuestStatisticsPlayerTriggerMotion()
		{
			return this.As<IQuestStatisticsPlayerTriggerMotionT>();
		}

		// Token: 0x060194B4 RID: 103604 RVA: 0x0039C116 File Offset: 0x0039A316
		public static IQuestStatisticsType_UnionUnion FromIQuestStatisticsPlayerTriggerMotion(IQuestStatisticsPlayerTriggerMotionT _iqueststatisticsplayertriggermotion)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStatisticsPlayerTriggerMotion,
				Value = _iqueststatisticsplayertriggermotion
			};
		}

		// Token: 0x060194B5 RID: 103605 RVA: 0x0039C12B File Offset: 0x0039A32B
		public IQuestStaticTimerT AsIQuestStaticTimer()
		{
			return this.As<IQuestStaticTimerT>();
		}

		// Token: 0x060194B6 RID: 103606 RVA: 0x0039C133 File Offset: 0x0039A333
		public static IQuestStatisticsType_UnionUnion FromIQuestStaticTimer(IQuestStaticTimerT _iqueststatictimer)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestStaticTimer,
				Value = _iqueststatictimer
			};
		}

		// Token: 0x060194B7 RID: 103607 RVA: 0x0039C148 File Offset: 0x0039A348
		public IQuestMonsterPointT AsIQuestMonsterPoint()
		{
			return this.As<IQuestMonsterPointT>();
		}

		// Token: 0x060194B8 RID: 103608 RVA: 0x0039C150 File Offset: 0x0039A350
		public static IQuestStatisticsType_UnionUnion FromIQuestMonsterPoint(IQuestMonsterPointT _iquestmonsterpoint)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestMonsterPoint,
				Value = _iquestmonsterpoint
			};
		}

		// Token: 0x060194B9 RID: 103609 RVA: 0x0039C165 File Offset: 0x0039A365
		public IQuestMonsterRemainingHealthT AsIQuestMonsterRemainingHealth()
		{
			return this.As<IQuestMonsterRemainingHealthT>();
		}

		// Token: 0x060194BA RID: 103610 RVA: 0x0039C16D File Offset: 0x0039A36D
		public static IQuestStatisticsType_UnionUnion FromIQuestMonsterRemainingHealth(IQuestMonsterRemainingHealthT _iquestmonsterremaininghealth)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestMonsterRemainingHealth,
				Value = _iquestmonsterremaininghealth
			};
		}

		// Token: 0x060194BB RID: 103611 RVA: 0x0039C182 File Offset: 0x0039A382
		public IQuestMonsterHealthScoreT AsIQuestMonsterHealthScore()
		{
			return this.As<IQuestMonsterHealthScoreT>();
		}

		// Token: 0x060194BC RID: 103612 RVA: 0x0039C18A File Offset: 0x0039A38A
		public static IQuestStatisticsType_UnionUnion FromIQuestMonsterHealthScore(IQuestMonsterHealthScoreT _iquestmonsterhealthscore)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestMonsterHealthScore,
				Value = _iquestmonsterhealthscore
			};
		}

		// Token: 0x060194BD RID: 103613 RVA: 0x0039C1A0 File Offset: 0x0039A3A0
		public IQuestPlayerHitStatisticsT AsIQuestPlayerHitStatistics()
		{
			return this.As<IQuestPlayerHitStatisticsT>();
		}

		// Token: 0x060194BE RID: 103614 RVA: 0x0039C1A8 File Offset: 0x0039A3A8
		public static IQuestStatisticsType_UnionUnion FromIQuestPlayerHitStatistics(IQuestPlayerHitStatisticsT _iquestplayerhitstatistics)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestPlayerHitStatistics,
				Value = _iquestplayerhitstatistics
			};
		}

		// Token: 0x060194BF RID: 103615 RVA: 0x0039C1BE File Offset: 0x0039A3BE
		public IQuestMechaTrackScoreT AsIQuestMechaTrackScore()
		{
			return this.As<IQuestMechaTrackScoreT>();
		}

		// Token: 0x060194C0 RID: 103616 RVA: 0x0039C1C6 File Offset: 0x0039A3C6
		public static IQuestStatisticsType_UnionUnion FromIQuestMechaTrackScore(IQuestMechaTrackScoreT _iquestmechatrackscore)
		{
			return new IQuestStatisticsType_UnionUnion
			{
				Type = IQuestStatisticsType_Union.IQuestMechaTrackScore,
				Value = _iquestmechatrackscore
			};
		}

		// Token: 0x060194C1 RID: 103617 RVA: 0x0039C1DC File Offset: 0x0039A3DC
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
