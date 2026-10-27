using System;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F4E RID: 28494
	public class Area
	{
		// Token: 0x06045517 RID: 283927 RVA: 0x0112643C File Offset: 0x0112463C
		public Area(int StartCellIndex, int EndCellIndex, EArrowDirection ArrowDirection)
		{
			this.StartCellIndex = StartCellIndex;
			this.EndCellIndex = EndCellIndex;
			this.ArrowDirection = ArrowDirection;
		}

		// Token: 0x06045518 RID: 283928 RVA: 0x0112645C File Offset: 0x0112465C
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

		// Token: 0x0402426C RID: 148076
		public int StartCellIndex;

		// Token: 0x0402426D RID: 148077
		public int EndCellIndex;

		// Token: 0x0402426E RID: 148078
		public EArrowDirection ArrowDirection;
	}
}
