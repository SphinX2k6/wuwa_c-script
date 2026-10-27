using System;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x0200529F RID: 21151
	public class PhantomArenaRecycleData
	{
		// Token: 0x170082D2 RID: 33490
		// (get) Token: 0x06036217 RID: 221719 RVA: 0x00CCECC5 File Offset: 0x00CCCEC5
		public bool IsSeal
		{
			get
			{
				return this.SealRemainRound > 0;
			}
		}

		// Token: 0x0401CA4C RID: 117324
		public int SealRemainRound;
	}
}
