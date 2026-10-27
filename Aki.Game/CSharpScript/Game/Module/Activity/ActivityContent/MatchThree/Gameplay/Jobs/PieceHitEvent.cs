using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200650E RID: 25870
	public struct PieceHitEvent
	{
		// Token: 0x06040EA3 RID: 265891 RVA: 0x00FBB6A4 File Offset: 0x00FB98A4
		public PieceHitEvent(GridPosition pos, int delayMs)
		{
			this.Pos = pos;
			this.DelayMs = delayMs;
			this.TrailFrom = null;
			this.DirectedTrail = EDirectedTrailType.None;
			this.OpensDirectedTrails = false;
			this.WaitLandAt = null;
			this.WaitDetonationAt = null;
			this.OpensDetonation = false;
			this.Lives = -1;
			this.StatePiece = null;
			this.PlayAnim = true;
			this.PlayCrossClearAudio = false;
		}

		// Token: 0x04021D97 RID: 138647
		public GridPosition Pos;

		// Token: 0x04021D98 RID: 138648
		public int DelayMs;

		// Token: 0x04021D99 RID: 138649
		public GridPosition? TrailFrom;

		// Token: 0x04021D9A RID: 138650
		public EDirectedTrailType DirectedTrail;

		// Token: 0x04021D9B RID: 138651
		public bool OpensDirectedTrails;

		// Token: 0x04021D9C RID: 138652
		public GridPosition? WaitLandAt;

		// Token: 0x04021D9D RID: 138653
		public GridPosition? WaitDetonationAt;

		// Token: 0x04021D9E RID: 138654
		public bool OpensDetonation;

		// Token: 0x04021D9F RID: 138655
		public int Lives;

		// Token: 0x04021DA0 RID: 138656
		[Nullable(2)]
		public Piece StatePiece;

		// Token: 0x04021DA1 RID: 138657
		public bool PlayAnim;

		// Token: 0x04021DA2 RID: 138658
		public bool PlayCrossClearAudio;
	}
}
