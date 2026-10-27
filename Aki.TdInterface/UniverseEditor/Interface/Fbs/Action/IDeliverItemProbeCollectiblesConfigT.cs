using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200656E RID: 25966
	public class IDeliverItemProbeCollectiblesConfigT
	{
		// Token: 0x1700C0F4 RID: 49396
		// (get) Token: 0x0602D0D0 RID: 184528 RVA: 0x0062E91E File Offset: 0x0062CB1E
		// (set) Token: 0x0602D0D1 RID: 184529 RVA: 0x0062E926 File Offset: 0x0062CB26
		public IHandInItemViewStyleT ViewStyle { get; set; }

		// Token: 0x1700C0F5 RID: 49397
		// (get) Token: 0x0602D0D2 RID: 184530 RVA: 0x0062E92F File Offset: 0x0062CB2F
		// (set) Token: 0x0602D0D3 RID: 184531 RVA: 0x0062E937 File Offset: 0x0062CB37
		public IItemCellIndependentDeliverTypeT DeliverType { get; set; }

		// Token: 0x1700C0F6 RID: 49398
		// (get) Token: 0x0602D0D4 RID: 184532 RVA: 0x0062E940 File Offset: 0x0062CB40
		// (set) Token: 0x0602D0D5 RID: 184533 RVA: 0x0062E948 File Offset: 0x0062CB48
		public IPlaceholderCollectibleMarkerTypeT MarkerType { get; set; }

		// Token: 0x0602D0D6 RID: 184534 RVA: 0x0062E951 File Offset: 0x0062CB51
		public IDeliverItemProbeCollectiblesConfigT()
		{
			this.ViewStyle = null;
			this.DeliverType = null;
			this.MarkerType = null;
		}
	}
}
