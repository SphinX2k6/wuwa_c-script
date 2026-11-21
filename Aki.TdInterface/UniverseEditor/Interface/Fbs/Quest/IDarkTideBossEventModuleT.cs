using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E5 RID: 16869
	public class IDarkTideBossEventModuleT
	{
		// Token: 0x170072EE RID: 29422
		// (get) Token: 0x06017690 RID: 95888 RVA: 0x0035893F File Offset: 0x00356B3F
		// (set) Token: 0x06017691 RID: 95889 RVA: 0x00358947 File Offset: 0x00356B47
		public EDarkTideModuleType Type { get; set; }

		// Token: 0x170072EF RID: 29423
		// (get) Token: 0x06017692 RID: 95890 RVA: 0x00358950 File Offset: 0x00356B50
		// (set) Token: 0x06017693 RID: 95891 RVA: 0x00358958 File Offset: 0x00356B58
		public TDarkTideBossEventUnion EventType { get; set; }

		// Token: 0x06017694 RID: 95892 RVA: 0x00358961 File Offset: 0x00356B61
		public IDarkTideBossEventModuleT()
		{
			this.Type = EDarkTideModuleType.BossEvent;
			this.EventType = null;
		}
	}
}
