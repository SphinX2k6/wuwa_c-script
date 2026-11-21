using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C2 RID: 21442
	public class IAllRefreshContentT
	{
		// Token: 0x170097AA RID: 38826
		// (get) Token: 0x0602179D RID: 137117 RVA: 0x0049DFF3 File Offset: 0x0049C1F3
		// (set) Token: 0x0602179E RID: 137118 RVA: 0x0049DFFB File Offset: 0x0049C1FB
		public ERefreshContent Type { get; set; }

		// Token: 0x170097AB RID: 38827
		// (get) Token: 0x0602179F RID: 137119 RVA: 0x0049E004 File Offset: 0x0049C204
		// (set) Token: 0x060217A0 RID: 137120 RVA: 0x0049E00C File Offset: 0x0049C20C
		public List<int> EntityIds { get; set; }

		// Token: 0x060217A1 RID: 137121 RVA: 0x0049E015 File Offset: 0x0049C215
		public IAllRefreshContentT()
		{
			this.Type = ERefreshContent.All;
			this.EntityIds = null;
		}
	}
}
