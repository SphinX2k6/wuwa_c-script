using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB8 RID: 28600
	public class ISetBattleStateT
	{
		// Token: 0x1700D45C RID: 54364
		// (get) Token: 0x060328CA RID: 207050 RVA: 0x006D259D File Offset: 0x006D079D
		// (set) Token: 0x060328CB RID: 207051 RVA: 0x006D25A5 File Offset: 0x006D07A5
		public TStateOptionUnion StateOption { get; set; }

		// Token: 0x060328CC RID: 207052 RVA: 0x006D25AE File Offset: 0x006D07AE
		public ISetBattleStateT()
		{
			this.StateOption = null;
		}
	}
}
