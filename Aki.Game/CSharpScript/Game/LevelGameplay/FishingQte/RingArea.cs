using System;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E31 RID: 28209
	public class RingArea
	{
		// Token: 0x17009A26 RID: 39462
		// (get) Token: 0x06044C3E RID: 281662 RVA: 0x010F7C3C File Offset: 0x010F5E3C
		// (set) Token: 0x06044C3F RID: 281663 RVA: 0x010F7C44 File Offset: 0x010F5E44
		public int StartCellIndex { get; set; }

		// Token: 0x17009A27 RID: 39463
		// (get) Token: 0x06044C40 RID: 281664 RVA: 0x010F7C4D File Offset: 0x010F5E4D
		// (set) Token: 0x06044C41 RID: 281665 RVA: 0x010F7C55 File Offset: 0x010F5E55
		public int EndCellIndex { get; set; }

		// Token: 0x17009A28 RID: 39464
		// (get) Token: 0x06044C42 RID: 281666 RVA: 0x010F7C5E File Offset: 0x010F5E5E
		// (set) Token: 0x06044C43 RID: 281667 RVA: 0x010F7C66 File Offset: 0x010F5E66
		public EArrowDirection ArrowDirection { get; set; }

		// Token: 0x06044C44 RID: 281668 RVA: 0x010F7C6F File Offset: 0x010F5E6F
		public RingArea(int startCellIndex, int endCellIndex, EArrowDirection arrowDirection)
		{
			this.StartCellIndex = startCellIndex;
			this.EndCellIndex = endCellIndex;
			this.ArrowDirection = arrowDirection;
		}

		// Token: 0x06044C45 RID: 281669 RVA: 0x010F7C8C File Offset: 0x010F5E8C
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
