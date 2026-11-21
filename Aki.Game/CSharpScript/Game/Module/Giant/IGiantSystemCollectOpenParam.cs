using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x0200493D RID: 18749
	public interface IGiantSystemCollectOpenParam
	{
		// Token: 0x17005EF5 RID: 24309
		// (get) Token: 0x0602F03A RID: 192570
		// (set) Token: 0x0602F03B RID: 192571
		GiantEcoNetType EcoType { get; set; }

		// Token: 0x17005EF6 RID: 24310
		// (get) Token: 0x0602F03C RID: 192572
		// (set) Token: 0x0602F03D RID: 192573
		int IncId { get; set; }
	}
}
