using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02006500 RID: 25856
	[NullableContext(1)]
	[Nullable(0)]
	public class SolvedData
	{
		// Token: 0x06040E82 RID: 265858 RVA: 0x00FBB1AE File Offset: 0x00FB93AE
		public void BeginSegment()
		{
			this.ClearedThisSegment.Clear();
			this.SegmentScore = 0;
			this.SegmentCharge = 0;
			this.SegmentTrailCharge = 0;
			this.SegmentTurnGain = 0;
			this.SegmentRecycleChargerClearCount = 0;
			this.SegmentRecycleHourglassClearCount = 0;
		}

		// Token: 0x04021D53 RID: 138579
		public readonly List<ItemSequence> Sequences = new List<ItemSequence>();

		// Token: 0x04021D54 RID: 138580
		public readonly List<SpawnSlot> SpecialItemSlots = new List<SpawnSlot>();

		// Token: 0x04021D55 RID: 138581
		public readonly List<EPieceType> ClearedThisSegment = new List<EPieceType>();

		// Token: 0x04021D56 RID: 138582
		public int SegmentScore;

		// Token: 0x04021D57 RID: 138583
		public int SegmentCharge;

		// Token: 0x04021D58 RID: 138584
		public int SegmentTrailCharge;

		// Token: 0x04021D59 RID: 138585
		public int MovesDelta;

		// Token: 0x04021D5A RID: 138586
		public int SegmentTurnGain;

		// Token: 0x04021D5B RID: 138587
		public bool TrackRecycleCharger;

		// Token: 0x04021D5C RID: 138588
		public bool TrackRecycleHourglass;

		// Token: 0x04021D5D RID: 138589
		public int RecycleChargerClearCount;

		// Token: 0x04021D5E RID: 138590
		public int RecycleHourglassClearCount;

		// Token: 0x04021D5F RID: 138591
		public int SegmentRecycleChargerClearCount;

		// Token: 0x04021D60 RID: 138592
		public int SegmentRecycleHourglassClearCount;
	}
}
