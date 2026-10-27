using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D0 RID: 16848
	public class ITetrisSingleGridT
	{
		// Token: 0x17007776 RID: 30582
		// (get) Token: 0x06018D1E RID: 101662 RVA: 0x003923D1 File Offset: 0x003905D1
		// (set) Token: 0x06018D1F RID: 101663 RVA: 0x003923D9 File Offset: 0x003905D9
		public ITetrisSingleBlockT Block { get; set; }

		// Token: 0x06018D20 RID: 101664 RVA: 0x003923E2 File Offset: 0x003905E2
		public ITetrisSingleGridT()
		{
			this.Block = null;
		}
	}
}
