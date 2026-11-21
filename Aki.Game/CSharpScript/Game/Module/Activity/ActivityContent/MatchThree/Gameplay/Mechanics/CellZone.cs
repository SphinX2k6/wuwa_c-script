using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Mechanics
{
	// Token: 0x02005468 RID: 21608
	public readonly struct CellZone
	{
		// Token: 0x06035A59 RID: 219737 RVA: 0x00EFC7A6 File Offset: 0x00EFA9A6
		public CellZone(int rowStart, int rowEnd, int colStart, int colEnd)
		{
			this.RowStart = rowStart;
			this.RowEnd = rowEnd;
			this.ColStart = colStart;
			this.ColEnd = colEnd;
		}

		// Token: 0x06035A5A RID: 219738 RVA: 0x00EFC7C5 File Offset: 0x00EFA9C5
		public bool Contains(int row, int col)
		{
			return row >= this.RowStart && row <= this.RowEnd && col >= this.ColStart && col <= this.ColEnd;
		}

		// Token: 0x0401C5C3 RID: 116163
		public readonly int RowStart;

		// Token: 0x0401C5C4 RID: 116164
		public readonly int RowEnd;

		// Token: 0x0401C5C5 RID: 116165
		public readonly int ColStart;

		// Token: 0x0401C5C6 RID: 116166
		public readonly int ColEnd;
	}
}
