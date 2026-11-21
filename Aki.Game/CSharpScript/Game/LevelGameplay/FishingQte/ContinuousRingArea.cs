using System;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB3 RID: 24499
	public class ContinuousRingArea : RingArea
	{
		// Token: 0x17006F3E RID: 28478
		// (get) Token: 0x0603ADD4 RID: 241108 RVA: 0x010A238B File Offset: 0x010A058B
		// (set) Token: 0x0603ADD5 RID: 241109 RVA: 0x010A2393 File Offset: 0x010A0593
		public int ContinuousIndex { get; set; }

		// Token: 0x0603ADD6 RID: 241110 RVA: 0x010A239C File Offset: 0x010A059C
		public ContinuousRingArea(int continuousIndex, int startCellIndex, int endCellIndex, EArrowDirection arrowDirection) : base(startCellIndex, endCellIndex, arrowDirection)
		{
			this.ContinuousIndex = continuousIndex;
		}
	}
}
