using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005499 RID: 21657
	[NullableContext(1)]
	[Nullable(0)]
	public class SegmentJobs
	{
		// Token: 0x06035B77 RID: 220023 RVA: 0x00F028A2 File Offset: 0x00F00AA2
		public static void Pack<[Nullable(2)] T>(List<T> src, BatchJob<T> dst, List<IJob> jobs)
		{
			if (src.Count == 0)
			{
				return;
			}
			dst.Events.Clear();
			dst.Events.AddRange(src);
			jobs.Add(dst);
		}

		// Token: 0x06035B78 RID: 220024 RVA: 0x00F028CC File Offset: 0x00F00ACC
		public void PackBoard(List<PieceClearEvent> clears, List<PieceHitEvent> hits, List<PieceMoveEvent> moves)
		{
			this.Board.Segment.Clear();
			this.Board.Segment.Clears.AddRange(clears);
			this.Board.Segment.Hits.AddRange(hits);
			this.Board.Segment.Moves.AddRange(moves);
			if (!this.Board.Segment.IsEmpty)
			{
				this.Jobs.Add(this.Board);
			}
		}

		// Token: 0x0401C6F7 RID: 116471
		public readonly List<IJob> Jobs = new List<IJob>();

		// Token: 0x0401C6F8 RID: 116472
		public readonly BatchJob<MechanicTipEvent> MechanicTips = new BatchJob<MechanicTipEvent>(4, (IMatchThreePresentation v, List<MechanicTipEvent> e) => v.PlayMechanicTipAsync(e));

		// Token: 0x0401C6F9 RID: 116473
		public readonly BatchJob<SkillTipEvent> SkillTips = new BatchJob<SkillTipEvent>(4, (IMatchThreePresentation v, List<SkillTipEvent> e) => v.PlaySkillTipAsync(e));

		// Token: 0x0401C6FA RID: 116474
		public readonly BatchJob<SkillTrailEvent> SkillTrails = new BatchJob<SkillTrailEvent>(5, (IMatchThreePresentation v, List<SkillTrailEvent> e) => v.PlaySkillTrailAsync(e));

		// Token: 0x0401C6FB RID: 116475
		public readonly BatchJob<MechanicTrailEvent> MechanicTrails = new BatchJob<MechanicTrailEvent>(5, (IMatchThreePresentation v, List<MechanicTrailEvent> e) => v.PlayMechanicTrailAsync(e));

		// Token: 0x0401C6FC RID: 116476
		public readonly BatchJob<RecycleTrailSettleEvent> RecycleTrailSettles = new BatchJob<RecycleTrailSettleEvent>(11, (IMatchThreePresentation v, List<RecycleTrailSettleEvent> e) => v.PlayRecycleTrailSettleAsync(e));

		// Token: 0x0401C6FD RID: 116477
		public readonly BatchJob<ScorePopEvent> ScorePops = new BatchJob<ScorePopEvent>(10, (IMatchThreePresentation v, List<ScorePopEvent> e) => v.PlayScorePopAsync(e));

		// Token: 0x0401C6FE RID: 116478
		public readonly BatchJob<PieceTransformEvent> Transforms = new BatchJob<PieceTransformEvent>(6, (IMatchThreePresentation v, List<PieceTransformEvent> e) => v.PlayPieceTransformAsync(e));

		// Token: 0x0401C6FF RID: 116479
		public readonly BatchJob<PieceAttachEvent> Attaches = new BatchJob<PieceAttachEvent>(6, (IMatchThreePresentation v, List<PieceAttachEvent> e) => v.PlayPieceAttachAsync(e));

		// Token: 0x0401C700 RID: 116480
		public readonly BatchJob<PieceRecolorEvent> Recolors = new BatchJob<PieceRecolorEvent>(5, (IMatchThreePresentation v, List<PieceRecolorEvent> e) => v.PlayPieceRecolorAsync(e));

		// Token: 0x0401C701 RID: 116481
		public readonly BoardJob Board = new BoardJob();
	}
}
