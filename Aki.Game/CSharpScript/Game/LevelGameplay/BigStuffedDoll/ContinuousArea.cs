using System;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F4F RID: 28495
	public class ContinuousArea : Area
	{
		// Token: 0x06045519 RID: 283929 RVA: 0x01126487 File Offset: 0x01124687
		public ContinuousArea(int ContinuousIndex, int StartCellIndex, int EndCellIndex, EArrowDirection ArrowDirection) : base(StartCellIndex, EndCellIndex, ArrowDirection)
		{
			this.ContinuousIndex = ContinuousIndex;
		}

		// Token: 0x0402426F RID: 148079
		public int ContinuousIndex;
	}
}
