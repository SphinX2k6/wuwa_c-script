using System;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB2 RID: 24498
	public class RingArea
	{
		// Token: 0x17006F3B RID: 28475
		// (get) Token: 0x0603ADCC RID: 241100 RVA: 0x010A2310 File Offset: 0x010A0510
		// (set) Token: 0x0603ADCD RID: 241101 RVA: 0x010A2318 File Offset: 0x010A0518
		public int StartCellIndex { get; set; }

		// Token: 0x17006F3C RID: 28476
		// (get) Token: 0x0603ADCE RID: 241102 RVA: 0x010A2321 File Offset: 0x010A0521
		// (set) Token: 0x0603ADCF RID: 241103 RVA: 0x010A2329 File Offset: 0x010A0529
		public int EndCellIndex { get; set; }

		// Token: 0x17006F3D RID: 28477
		// (get) Token: 0x0603ADD0 RID: 241104 RVA: 0x010A2332 File Offset: 0x010A0532
		// (set) Token: 0x0603ADD1 RID: 241105 RVA: 0x010A233A File Offset: 0x010A053A
		public EArrowDirection ArrowDirection { get; set; }

		// Token: 0x0603ADD2 RID: 241106 RVA: 0x010A2343 File Offset: 0x010A0543
		public RingArea(int startCellIndex, int endCellIndex, EArrowDirection arrowDirection)
		{
			this.StartCellIndex = startCellIndex;
			this.EndCellIndex = endCellIndex;
			this.ArrowDirection = arrowDirection;
		}

		// Token: 0x0603ADD3 RID: 241107 RVA: 0x010A2360 File Offset: 0x010A0560
		public void OnArrowDirectionReverse()
		{
			EArrowDirection arrowDirection = this.ArrowDirection;
			if (arrowDirection == EArrowDirection.Clockwise)
			{
				this.ArrowDirection = EArrowDirection.Anticlockwise;
				return;
			}
			if (arrowDirection != EArrowDirection.Anticlockwise)
			{
				return;
			}
			this.ArrowDirection = EArrowDirection.Clockwise;
		}
	}
}
