using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C8 RID: 26824
	public class IHandInItemViewStyleT
	{
		// Token: 0x1700C70E RID: 50958
		// (get) Token: 0x0602EC9A RID: 191642 RVA: 0x00662A6E File Offset: 0x00660C6E
		// (set) Token: 0x0602EC9B RID: 191643 RVA: 0x00662A76 File Offset: 0x00660C76
		public EDeliverItemProbeCollectibleViewStyle Type { get; set; }

		// Token: 0x0602EC9C RID: 191644 RVA: 0x00662A7F File Offset: 0x00660C7F
		public IHandInItemViewStyleT()
		{
			this.Type = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
		}
	}
}
