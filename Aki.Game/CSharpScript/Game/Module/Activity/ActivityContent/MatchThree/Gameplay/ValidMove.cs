using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064BB RID: 25787
	public struct ValidMove
	{
		// Token: 0x06040BA2 RID: 265122 RVA: 0x00FAB810 File Offset: 0x00FA9A10
		public ValidMove(GridPosition a, GridPosition b)
		{
			this.A = a;
			this.B = b;
		}

		// Token: 0x04021B5C RID: 138076
		public GridPosition A;

		// Token: 0x04021B5D RID: 138077
		public GridPosition B;
	}
}
