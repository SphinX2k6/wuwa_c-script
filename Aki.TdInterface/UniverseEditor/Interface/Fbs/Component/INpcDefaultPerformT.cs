using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBF RID: 23487
	public class INpcDefaultPerformT
	{
		// Token: 0x1700ABAB RID: 43947
		// (get) Token: 0x06026B9D RID: 158621 RVA: 0x0054CF3B File Offset: 0x0054B13B
		// (set) Token: 0x06026B9E RID: 158622 RVA: 0x0054CF43 File Offset: 0x0054B143
		public List<int> BuffEffectIds { get; set; }

		// Token: 0x1700ABAC RID: 43948
		// (get) Token: 0x06026B9F RID: 158623 RVA: 0x0054CF4C File Offset: 0x0054B14C
		// (set) Token: 0x06026BA0 RID: 158624 RVA: 0x0054CF54 File Offset: 0x0054B154
		public byte NullMask { get; set; }

		// Token: 0x06026BA1 RID: 158625 RVA: 0x0054CF5D File Offset: 0x0054B15D
		public INpcDefaultPerformT()
		{
			this.BuffEffectIds = null;
			this.NullMask = 0;
		}
	}
}
