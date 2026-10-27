using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006571 RID: 25969
	public class IDeliverItemProbeCollectibleViewStyleT
	{
		// Token: 0x1700C0F9 RID: 49401
		// (get) Token: 0x0602D0E6 RID: 184550 RVA: 0x0062EB36 File Offset: 0x0062CD36
		// (set) Token: 0x0602D0E7 RID: 184551 RVA: 0x0062EB3E File Offset: 0x0062CD3E
		public EDeliverItemProbeCollectibleViewStyle Type { get; set; }

		// Token: 0x0602D0E8 RID: 184552 RVA: 0x0062EB47 File Offset: 0x0062CD47
		public IDeliverItemProbeCollectibleViewStyleT()
		{
			this.Type = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
		}
	}
}
