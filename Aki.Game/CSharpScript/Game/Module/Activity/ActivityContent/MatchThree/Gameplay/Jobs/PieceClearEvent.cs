using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006509 RID: 25865
	public struct PieceClearEvent
	{
		// Token: 0x06040E9F RID: 265887 RVA: 0x00FBB5C8 File Offset: 0x00FB97C8
		public PieceClearEvent(GridPosition pos, EPieceType type, EPieceClearReason reason = EPieceClearReason.Matched, int delayMs = 0)
		{
			this.Pos = pos;
			this.Type = type;
			this.Reason = reason;
			this.DelayMs = delayMs;
			this.TrailFrom = null;
			this.DirectedTrail = EDirectedTrailType.None;
			this.OpensDirectedTrails = false;
			this.WaitLandAt = null;
			this.WaitDetonationAt = null;
			this.OpensDetonation = false;
			this.EnergyTrail = 0;
			this.RecycleTrail = ERecycleTrailType.None;
			this.PlayCrossClearAudio = false;
			this.SpawnType = null;
			this.SpawnPiece = null;
		}

		// Token: 0x04021D7B RID: 138619
		public GridPosition Pos;

		// Token: 0x04021D7C RID: 138620
		public EPieceType Type;

		// Token: 0x04021D7D RID: 138621
		public EPieceClearReason Reason;

		// Token: 0x04021D7E RID: 138622
		public int DelayMs;

		// Token: 0x04021D7F RID: 138623
		public GridPosition? TrailFrom;

		// Token: 0x04021D80 RID: 138624
		public EDirectedTrailType DirectedTrail;

		// Token: 0x04021D81 RID: 138625
		public bool OpensDirectedTrails;

		// Token: 0x04021D82 RID: 138626
		public GridPosition? WaitLandAt;

		// Token: 0x04021D83 RID: 138627
		public GridPosition? WaitDetonationAt;

		// Token: 0x04021D84 RID: 138628
		public bool OpensDetonation;

		// Token: 0x04021D85 RID: 138629
		public int EnergyTrail;

		// Token: 0x04021D86 RID: 138630
		public ERecycleTrailType RecycleTrail;

		// Token: 0x04021D87 RID: 138631
		public bool PlayCrossClearAudio;

		// Token: 0x04021D88 RID: 138632
		public EPieceType? SpawnType;

		// Token: 0x04021D89 RID: 138633
		[Nullable(2)]
		public Piece SpawnPiece;
	}
}
