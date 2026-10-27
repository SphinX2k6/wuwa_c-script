using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005839 RID: 22585
	public class IRefreshSingleT
	{
		// Token: 0x1700A8B1 RID: 43185
		// (get) Token: 0x06025FCD RID: 155597 RVA: 0x0053CA5F File Offset: 0x0053AC5F
		// (set) Token: 0x06025FCE RID: 155598 RVA: 0x0053CA67 File Offset: 0x0053AC67
		public int RefreshInterval { get; set; }

		// Token: 0x1700A8B2 RID: 43186
		// (get) Token: 0x06025FCF RID: 155599 RVA: 0x0053CA70 File Offset: 0x0053AC70
		// (set) Token: 0x06025FD0 RID: 155600 RVA: 0x0053CA78 File Offset: 0x0053AC78
		public int MaxRefreshTimes { get; set; }

		// Token: 0x1700A8B3 RID: 43187
		// (get) Token: 0x06025FD1 RID: 155601 RVA: 0x0053CA81 File Offset: 0x0053AC81
		// (set) Token: 0x06025FD2 RID: 155602 RVA: 0x0053CA89 File Offset: 0x0053AC89
		public bool DelayRefresh { get; set; }

		// Token: 0x1700A8B4 RID: 43188
		// (get) Token: 0x06025FD3 RID: 155603 RVA: 0x0053CA92 File Offset: 0x0053AC92
		// (set) Token: 0x06025FD4 RID: 155604 RVA: 0x0053CA9A File Offset: 0x0053AC9A
		public ITempleGuidT TemplateGuid { get; set; }

		// Token: 0x06025FD5 RID: 155605 RVA: 0x0053CAA3 File Offset: 0x0053ACA3
		public IRefreshSingleT()
		{
			this.RefreshInterval = 0;
			this.MaxRefreshTimes = 0;
			this.DelayRefresh = false;
			this.TemplateGuid = null;
		}
	}
}
