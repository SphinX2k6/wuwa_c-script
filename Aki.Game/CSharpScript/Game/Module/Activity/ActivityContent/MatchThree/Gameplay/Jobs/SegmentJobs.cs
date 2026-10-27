using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200651B RID: 25883
	[NullableContext(1)]
	[Nullable(0)]
	public class SegmentJobs
	{
		// Token: 0x06040EB3 RID: 265907 RVA: 0x00FBB872 File Offset: 0x00FB9A72
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

		// Token: 0x06040EB4 RID: 265908 RVA: 0x00FBB89C File Offset: 0x00FB9A9C
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

		// Token: 0x04021DC6 RID: 138694
		public readonly List<IJob> Jobs = new List<IJob>();

		// Token: 0x04021DC7 RID: 138695
		public readonly BatchJob<MechanicTipEvent> MechanicTips = new BatchJob<MechanicTipEvent>(4, (IMatchThreePresentation v, List<MechanicTipEvent> e) => v.PlayMechanicTipAsync(e));

		// Token: 0x04021DC8 RID: 138696
		public readonly BatchJob<SkillTipEvent> SkillTips = new BatchJob<SkillTipEvent>(4, (IMatchThreePresentation v, List<SkillTipEvent> e) => v.PlaySkillTipAsync(e));

		// Token: 0x04021DC9 RID: 138697
		public readonly BatchJob<SkillTrailEvent> SkillTrails = new BatchJob<SkillTrailEvent>(5, (IMatchThreePresentation v, List<SkillTrailEvent> e) => v.PlaySkillTrailAsync(e));

		// Token: 0x04021DCA RID: 138698
		public readonly BatchJob<MechanicTrailEvent> MechanicTrails = new BatchJob<MechanicTrailEvent>(5, (IMatchThreePresentation v, List<MechanicTrailEvent> e) => v.PlayMechanicTrailAsync(e));

		// Token: 0x04021DCB RID: 138699
		public readonly BatchJob<RecycleTrailSettleEvent> RecycleTrailSettles = new BatchJob<RecycleTrailSettleEvent>(11, (IMatchThreePresentation v, List<RecycleTrailSettleEvent> e) => v.PlayRecycleTrailSettleAsync(e));

		// Token: 0x04021DCC RID: 138700
		public readonly BatchJob<ScorePopEvent> ScorePops = new BatchJob<ScorePopEvent>(10, (IMatchThreePresentation v, List<ScorePopEvent> e) => v.PlayScorePopAsync(e));

		// Token: 0x04021DCD RID: 138701
		public readonly BatchJob<PieceTransformEvent> Transforms = new BatchJob<PieceTransformEvent>(6, (IMatchThreePresentation v, List<PieceTransformEvent> e) => v.PlayPieceTransformAsync(e));

		// Token: 0x04021DCE RID: 138702
		public readonly BatchJob<PieceAttachEvent> Attaches = new BatchJob<PieceAttachEvent>(6, (IMatchThreePresentation v, List<PieceAttachEvent> e) => v.PlayPieceAttachAsync(e));

		// Token: 0x04021DCF RID: 138703
		public readonly BatchJob<PieceRecolorEvent> Recolors = new BatchJob<PieceRecolorEvent>(5, (IMatchThreePresentation v, List<PieceRecolorEvent> e) => v.PlayPieceRecolorAsync(e));

		// Token: 0x04021DD0 RID: 138704
		public readonly BoardJob Board = new BoardJob();
	}
}
