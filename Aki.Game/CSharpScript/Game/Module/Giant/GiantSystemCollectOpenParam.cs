using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x0200493E RID: 18750
	public class GiantSystemCollectOpenParam : IGiantSystemCollectOpenParam
	{
		// Token: 0x17005EF7 RID: 24311
		// (get) Token: 0x0602F03E RID: 192574 RVA: 0x00D1CA87 File Offset: 0x00D1AC87
		// (set) Token: 0x0602F03F RID: 192575 RVA: 0x00D1CA8F File Offset: 0x00D1AC8F
		public GiantEcoNetType EcoType { get; set; }

		// Token: 0x17005EF8 RID: 24312
		// (get) Token: 0x0602F040 RID: 192576 RVA: 0x00D1CA98 File Offset: 0x00D1AC98
		// (set) Token: 0x0602F041 RID: 192577 RVA: 0x00D1CAA0 File Offset: 0x00D1ACA0
		public int IncId { get; set; }
	}
}
