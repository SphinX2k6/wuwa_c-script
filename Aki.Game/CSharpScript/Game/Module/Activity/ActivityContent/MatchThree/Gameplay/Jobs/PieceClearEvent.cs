using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02005487 RID: 21639
	public struct PieceClearEvent
	{
		// Token: 0x06035B63 RID: 220003 RVA: 0x00F025F8 File Offset: 0x00F007F8
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

		// Token: 0x0401C6AC RID: 116396
		public GridPosition Pos;

		// Token: 0x0401C6AD RID: 116397
		public EPieceType Type;

		// Token: 0x0401C6AE RID: 116398
		public EPieceClearReason Reason;

		// Token: 0x0401C6AF RID: 116399
		public int DelayMs;

		// Token: 0x0401C6B0 RID: 116400
		public GridPosition? TrailFrom;

		// Token: 0x0401C6B1 RID: 116401
		public EDirectedTrailType DirectedTrail;

		// Token: 0x0401C6B2 RID: 116402
		public bool OpensDirectedTrails;

		// Token: 0x0401C6B3 RID: 116403
		public GridPosition? WaitLandAt;

		// Token: 0x0401C6B4 RID: 116404
		public GridPosition? WaitDetonationAt;

		// Token: 0x0401C6B5 RID: 116405
		public bool OpensDetonation;

		// Token: 0x0401C6B6 RID: 116406
		public int EnergyTrail;

		// Token: 0x0401C6B7 RID: 116407
		public ERecycleTrailType RecycleTrail;

		// Token: 0x0401C6B8 RID: 116408
		public bool PlayCrossClearAudio;

		// Token: 0x0401C6B9 RID: 116409
		public EPieceType? SpawnType;

		// Token: 0x0401C6BA RID: 116410
		[Nullable(2)]
		public Piece SpawnPiece;
	}
}
