using System;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E32 RID: 28210
	public class ContinuousRingArea : RingArea
	{
		// Token: 0x17009A29 RID: 39465
		// (get) Token: 0x06044C46 RID: 281670 RVA: 0x010F7CB7 File Offset: 0x010F5EB7
		// (set) Token: 0x06044C47 RID: 281671 RVA: 0x010F7CBF File Offset: 0x010F5EBF
		public int ContinuousIndex { get; set; }

		// Token: 0x06044C48 RID: 281672 RVA: 0x010F7CC8 File Offset: 0x010F5EC8
		public ContinuousRingArea(int continuousIndex, int startCellIndex, int endCellIndex, EArrowDirection arrowDirection) : base(startCellIndex, endCellIndex, arrowDirection)
		{
			this.ContinuousIndex = continuousIndex;
		}
	}
}
