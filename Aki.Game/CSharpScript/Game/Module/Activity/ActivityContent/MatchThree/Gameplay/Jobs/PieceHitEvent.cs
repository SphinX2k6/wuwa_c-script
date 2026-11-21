using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200548C RID: 21644
	public struct PieceHitEvent
	{
		// Token: 0x06035B67 RID: 220007 RVA: 0x00F026D4 File Offset: 0x00F008D4
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

		// Token: 0x0401C6C8 RID: 116424
		public GridPosition Pos;

		// Token: 0x0401C6C9 RID: 116425
		public int DelayMs;

		// Token: 0x0401C6CA RID: 116426
		public GridPosition? TrailFrom;

		// Token: 0x0401C6CB RID: 116427
		public EDirectedTrailType DirectedTrail;

		// Token: 0x0401C6CC RID: 116428
		public bool OpensDirectedTrails;

		// Token: 0x0401C6CD RID: 116429
		public GridPosition? WaitLandAt;

		// Token: 0x0401C6CE RID: 116430
		public GridPosition? WaitDetonationAt;

		// Token: 0x0401C6CF RID: 116431
		public bool OpensDetonation;

		// Token: 0x0401C6D0 RID: 116432
		public int Lives;

		// Token: 0x0401C6D1 RID: 116433
		[Nullable(2)]
		public Piece StatePiece;

		// Token: 0x0401C6D2 RID: 116434
		public bool PlayAnim;

		// Token: 0x0401C6D3 RID: 116435
		public bool PlayCrossClearAudio;
	}
}
