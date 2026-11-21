using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB6 RID: 23478
	public class INpcAwakeShowT
	{
		// Token: 0x1700AB9E RID: 43934
		// (get) Token: 0x06026B55 RID: 158549 RVA: 0x0054C72F File Offset: 0x0054A92F
		// (set) Token: 0x06026B56 RID: 158550 RVA: 0x0054C737 File Offset: 0x0054A937
		public IMontageIdT RegisteredMontageId { get; set; }

		// Token: 0x1700AB9F RID: 43935
		// (get) Token: 0x06026B57 RID: 158551 RVA: 0x0054C740 File Offset: 0x0054A940
		// (set) Token: 0x06026B58 RID: 158552 RVA: 0x0054C748 File Offset: 0x0054A948
		public string MaterialDa { get; set; }

		// Token: 0x06026B59 RID: 158553 RVA: 0x0054C751 File Offset: 0x0054A951
		public INpcAwakeShowT()
		{
			this.RegisteredMontageId = null;
			this.MaterialDa = null;
		}
	}
}
