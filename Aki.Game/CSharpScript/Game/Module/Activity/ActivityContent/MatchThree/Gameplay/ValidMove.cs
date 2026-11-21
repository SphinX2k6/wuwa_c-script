using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005439 RID: 21561
	public struct ValidMove
	{
		// Token: 0x06035866 RID: 219238 RVA: 0x00EF2858 File Offset: 0x00EF0A58
		public ValidMove(GridPosition a, GridPosition b)
		{
			this.A = a;
			this.B = b;
		}

		// Token: 0x0401C48D RID: 115853
		public GridPosition A;

		// Token: 0x0401C48E RID: 115854
		public GridPosition B;
	}
}
