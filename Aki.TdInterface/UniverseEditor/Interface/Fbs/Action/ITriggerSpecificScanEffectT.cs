using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748B RID: 29835
	public class ITriggerSpecificScanEffectT
	{
		// Token: 0x1700E27F RID: 57983
		// (get) Token: 0x0603638E RID: 222094 RVA: 0x0075F189 File Offset: 0x0075D389
		// (set) Token: 0x0603638F RID: 222095 RVA: 0x0075F191 File Offset: 0x0075D391
		public TSpecificScanEffectUnion ScanEffect { get; set; }

		// Token: 0x06036390 RID: 222096 RVA: 0x0075F19A File Offset: 0x0075D39A
		public ITriggerSpecificScanEffectT()
		{
			this.ScanEffect = null;
		}
	}
}
