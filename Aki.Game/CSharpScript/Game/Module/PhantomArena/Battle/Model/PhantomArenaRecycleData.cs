using System;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200426F RID: 17007
	public class PhantomArenaRecycleData
	{
		// Token: 0x17005692 RID: 22162
		// (get) Token: 0x0602B112 RID: 176402 RVA: 0x00C1C3E1 File Offset: 0x00C1A5E1
		public bool IsSeal
		{
			get
			{
				return this.SealRemainRound > 0;
			}
		}

		// Token: 0x04017481 RID: 95361
		public int SealRemainRound;
	}
}
