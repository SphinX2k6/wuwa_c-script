using System;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060CF RID: 24783
	public class Area
	{
		// Token: 0x0603B6C5 RID: 243397 RVA: 0x010D03E8 File Offset: 0x010CE5E8
		public Area(int StartCellIndex, int EndCellIndex, EArrowDirection ArrowDirection)
		{
			this.StartCellIndex = StartCellIndex;
			this.EndCellIndex = EndCellIndex;
			this.ArrowDirection = ArrowDirection;
		}

		// Token: 0x0603B6C6 RID: 243398 RVA: 0x010D0408 File Offset: 0x010CE608
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

		// Token: 0x0401F521 RID: 128289
		public int StartCellIndex;

		// Token: 0x0401F522 RID: 128290
		public int EndCellIndex;

		// Token: 0x0401F523 RID: 128291
		public EArrowDirection ArrowDirection;
	}
}
