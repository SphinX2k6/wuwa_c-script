using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200519C RID: 20892
	public class IEntityMatchDynamicT
	{
		// Token: 0x170098A1 RID: 39073
		// (get) Token: 0x06021CC9 RID: 138441 RVA: 0x004B0553 File Offset: 0x004AE753
		// (set) Token: 0x06021CCA RID: 138442 RVA: 0x004B055B File Offset: 0x004AE75B
		public EEntityMatchType Type { get; set; }

		// Token: 0x170098A2 RID: 39074
		// (get) Token: 0x06021CCB RID: 138443 RVA: 0x004B0564 File Offset: 0x004AE764
		// (set) Token: 0x06021CCC RID: 138444 RVA: 0x004B056C File Offset: 0x004AE76C
		public List<IDynamicEntityMatchT> MatchEntity { get; set; }

		// Token: 0x06021CCD RID: 138445 RVA: 0x004B0575 File Offset: 0x004AE775
		public IEntityMatchDynamicT()
		{
			this.Type = EEntityMatchType.Player;
			this.MatchEntity = null;
		}
	}
}
