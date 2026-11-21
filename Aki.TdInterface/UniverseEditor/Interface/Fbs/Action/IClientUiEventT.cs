using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8A RID: 27274
	public class IClientUiEventT
	{
		// Token: 0x1700C851 RID: 51281
		// (get) Token: 0x0602ECDF RID: 191711 RVA: 0x00661127 File Offset: 0x0065F327
		// (set) Token: 0x0602ECE0 RID: 191712 RVA: 0x0066112F File Offset: 0x0065F32F
		public EClientEventTarget Type { get; set; }

		// Token: 0x1700C852 RID: 51282
		// (get) Token: 0x0602ECE1 RID: 191713 RVA: 0x00661138 File Offset: 0x0065F338
		// (set) Token: 0x0602ECE2 RID: 191714 RVA: 0x00661140 File Offset: 0x0065F340
		public TClientEventUiUnion Ui { get; set; }

		// Token: 0x0602ECE3 RID: 191715 RVA: 0x00661149 File Offset: 0x0065F349
		public IClientUiEventT()
		{
			this.Type = EClientEventTarget.Self;
			this.Ui = null;
		}
	}
}
