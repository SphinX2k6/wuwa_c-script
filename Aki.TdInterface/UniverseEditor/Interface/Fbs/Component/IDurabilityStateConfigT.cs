using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050CA RID: 20682
	public class IDurabilityStateConfigT
	{
		// Token: 0x17009682 RID: 38530
		// (get) Token: 0x06021455 RID: 136277 RVA: 0x0049F241 File Offset: 0x0049D441
		// (set) Token: 0x06021456 RID: 136278 RVA: 0x0049F249 File Offset: 0x0049D449
		public bool NonDestructable { get; set; }

		// Token: 0x17009683 RID: 38531
		// (get) Token: 0x06021457 RID: 136279 RVA: 0x0049F252 File Offset: 0x0049D452
		// (set) Token: 0x06021458 RID: 136280 RVA: 0x0049F25A File Offset: 0x0049D45A
		public List<IDurabilityStateT> DurabilityStates { get; set; }

		// Token: 0x17009684 RID: 38532
		// (get) Token: 0x06021459 RID: 136281 RVA: 0x0049F263 File Offset: 0x0049D463
		// (set) Token: 0x0602145A RID: 136282 RVA: 0x0049F26B File Offset: 0x0049D46B
		public byte NullMask { get; set; }

		// Token: 0x0602145B RID: 136283 RVA: 0x0049F274 File Offset: 0x0049D474
		public IDurabilityStateConfigT()
		{
			this.NonDestructable = false;
			this.DurabilityStates = null;
			this.NullMask = 0;
		}
	}
}
