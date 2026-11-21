using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C7E RID: 31870
	public class ITriggerSpecificScanEffectT
	{
		// Token: 0x1700EE9E RID: 61086
		// (get) Token: 0x0603977B RID: 235387 RVA: 0x007C1F45 File Offset: 0x007C0145
		// (set) Token: 0x0603977C RID: 235388 RVA: 0x007C1F4D File Offset: 0x007C014D
		public TSpecificScanEffectUnion ScanEffect { get; set; }

		// Token: 0x0603977D RID: 235389 RVA: 0x007C1F56 File Offset: 0x007C0156
		public ITriggerSpecificScanEffectT()
		{
			this.ScanEffect = null;
		}
	}
}
