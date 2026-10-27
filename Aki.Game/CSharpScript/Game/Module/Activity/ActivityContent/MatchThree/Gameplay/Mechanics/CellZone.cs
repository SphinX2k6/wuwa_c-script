using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x020064EA RID: 25834
	public readonly struct CellZone
	{
		// Token: 0x06040D95 RID: 265621 RVA: 0x00FB5776 File Offset: 0x00FB3976
		public CellZone(int rowStart, int rowEnd, int colStart, int colEnd)
		{
			this.RowStart = rowStart;
			this.RowEnd = rowEnd;
			this.ColStart = colStart;
			this.ColEnd = colEnd;
		}

		// Token: 0x06040D96 RID: 265622 RVA: 0x00FB5795 File Offset: 0x00FB3995
		public bool Contains(int row, int col)
		{
			return row >= this.RowStart && row <= this.RowEnd && col >= this.ColStart && col <= this.ColEnd;
		}

		// Token: 0x04021C92 RID: 138386
		public readonly int RowStart;

		// Token: 0x04021C93 RID: 138387
		public readonly int RowEnd;

		// Token: 0x04021C94 RID: 138388
		public readonly int ColStart;

		// Token: 0x04021C95 RID: 138389
		public readonly int ColEnd;
	}
}
