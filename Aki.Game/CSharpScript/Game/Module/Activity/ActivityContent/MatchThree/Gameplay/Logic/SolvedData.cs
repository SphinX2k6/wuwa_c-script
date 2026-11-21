using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x0200547E RID: 21630
	[NullableContext(1)]
	[Nullable(0)]
	public class SolvedData
	{
		// Token: 0x06035B46 RID: 219974 RVA: 0x00F021DE File Offset: 0x00F003DE
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

		// Token: 0x0401C684 RID: 116356
		public readonly List<ItemSequence> Sequences = new List<ItemSequence>();

		// Token: 0x0401C685 RID: 116357
		public readonly List<SpawnSlot> SpecialItemSlots = new List<SpawnSlot>();

		// Token: 0x0401C686 RID: 116358
		public readonly List<EPieceType> ClearedThisSegment = new List<EPieceType>();

		// Token: 0x0401C687 RID: 116359
		public int SegmentScore;

		// Token: 0x0401C688 RID: 116360
		public int SegmentCharge;

		// Token: 0x0401C689 RID: 116361
		public int SegmentTrailCharge;

		// Token: 0x0401C68A RID: 116362
		public int MovesDelta;

		// Token: 0x0401C68B RID: 116363
		public int SegmentTurnGain;

		// Token: 0x0401C68C RID: 116364
		public bool TrackRecycleCharger;

		// Token: 0x0401C68D RID: 116365
		public bool TrackRecycleHourglass;

		// Token: 0x0401C68E RID: 116366
		public int RecycleChargerClearCount;

		// Token: 0x0401C68F RID: 116367
		public int RecycleHourglassClearCount;

		// Token: 0x0401C690 RID: 116368
		public int SegmentRecycleChargerClearCount;

		// Token: 0x0401C691 RID: 116369
		public int SegmentRecycleHourglassClearCount;
	}
}
