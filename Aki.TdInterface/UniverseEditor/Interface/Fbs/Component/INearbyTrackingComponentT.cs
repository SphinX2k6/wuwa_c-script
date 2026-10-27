using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F4 RID: 22004
	public class INearbyTrackingComponentT
	{
		// Token: 0x1700A2D1 RID: 41681
		// (get) Token: 0x06024821 RID: 149537 RVA: 0x00509FFF File Offset: 0x005081FF
		// (set) Token: 0x06024822 RID: 149538 RVA: 0x0050A007 File Offset: 0x00508207
		public bool Disabled { get; set; }

		// Token: 0x1700A2D2 RID: 41682
		// (get) Token: 0x06024823 RID: 149539 RVA: 0x0050A010 File Offset: 0x00508210
		// (set) Token: 0x06024824 RID: 149540 RVA: 0x0050A018 File Offset: 0x00508218
		public bool IsEnable { get; set; }

		// Token: 0x1700A2D3 RID: 41683
		// (get) Token: 0x06024825 RID: 149541 RVA: 0x0050A021 File Offset: 0x00508221
		// (set) Token: 0x06024826 RID: 149542 RVA: 0x0050A029 File Offset: 0x00508229
		public bool IsEnableWhileUnlock { get; set; }

		// Token: 0x1700A2D4 RID: 41684
		// (get) Token: 0x06024827 RID: 149543 RVA: 0x0050A032 File Offset: 0x00508232
		// (set) Token: 0x06024828 RID: 149544 RVA: 0x0050A03A File Offset: 0x0050823A
		public bool IsEnbaleWhileHoming { get; set; }

		// Token: 0x1700A2D5 RID: 41685
		// (get) Token: 0x06024829 RID: 149545 RVA: 0x0050A043 File Offset: 0x00508243
		// (set) Token: 0x0602482A RID: 149546 RVA: 0x0050A04B File Offset: 0x0050824B
		public TNearbyTrackingUnion TrackingType { get; set; }

		// Token: 0x1700A2D6 RID: 41686
		// (get) Token: 0x0602482B RID: 149547 RVA: 0x0050A054 File Offset: 0x00508254
		// (set) Token: 0x0602482C RID: 149548 RVA: 0x0050A05C File Offset: 0x0050825C
		public byte NullMask { get; set; }

		// Token: 0x0602482D RID: 149549 RVA: 0x0050A065 File Offset: 0x00508265
		public INearbyTrackingComponentT()
		{
			this.Disabled = false;
			this.IsEnable = false;
			this.IsEnableWhileUnlock = false;
			this.IsEnbaleWhileHoming = false;
			this.TrackingType = null;
			this.NullMask = 0;
		}
	}
}
