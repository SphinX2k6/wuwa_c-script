using System;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060D0 RID: 24784
	public class ContinuousArea : Area
	{
		// Token: 0x0603B6C7 RID: 243399 RVA: 0x010D0433 File Offset: 0x010CE633
		public ContinuousArea(int ContinuousIndex, int StartCellIndex, int EndCellIndex, EArrowDirection ArrowDirection) : base(StartCellIndex, EndCellIndex, ArrowDirection)
		{
			this.ContinuousIndex = ContinuousIndex;
		}

		// Token: 0x0401F524 RID: 128292
		public int ContinuousIndex;
	}
}
