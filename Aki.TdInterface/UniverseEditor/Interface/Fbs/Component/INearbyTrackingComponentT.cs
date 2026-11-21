using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B92 RID: 23442
	public class INearbyTrackingComponentT
	{
		// Token: 0x1700AB59 RID: 43865
		// (get) Token: 0x06026A2F RID: 158255 RVA: 0x0054A5D3 File Offset: 0x005487D3
		// (set) Token: 0x06026A30 RID: 158256 RVA: 0x0054A5DB File Offset: 0x005487DB
		public bool Disabled { get; set; }

		// Token: 0x1700AB5A RID: 43866
		// (get) Token: 0x06026A31 RID: 158257 RVA: 0x0054A5E4 File Offset: 0x005487E4
		// (set) Token: 0x06026A32 RID: 158258 RVA: 0x0054A5EC File Offset: 0x005487EC
		public bool IsEnable { get; set; }

		// Token: 0x1700AB5B RID: 43867
		// (get) Token: 0x06026A33 RID: 158259 RVA: 0x0054A5F5 File Offset: 0x005487F5
		// (set) Token: 0x06026A34 RID: 158260 RVA: 0x0054A5FD File Offset: 0x005487FD
		public bool IsEnableWhileUnlock { get; set; }

		// Token: 0x1700AB5C RID: 43868
		// (get) Token: 0x06026A35 RID: 158261 RVA: 0x0054A606 File Offset: 0x00548806
		// (set) Token: 0x06026A36 RID: 158262 RVA: 0x0054A60E File Offset: 0x0054880E
		public bool IsEnbaleWhileHoming { get; set; }

		// Token: 0x1700AB5D RID: 43869
		// (get) Token: 0x06026A37 RID: 158263 RVA: 0x0054A617 File Offset: 0x00548817
		// (set) Token: 0x06026A38 RID: 158264 RVA: 0x0054A61F File Offset: 0x0054881F
		public TNearbyTrackingUnion TrackingType { get; set; }

		// Token: 0x1700AB5E RID: 43870
		// (get) Token: 0x06026A39 RID: 158265 RVA: 0x0054A628 File Offset: 0x00548828
		// (set) Token: 0x06026A3A RID: 158266 RVA: 0x0054A630 File Offset: 0x00548830
		public byte NullMask { get; set; }

		// Token: 0x06026A3B RID: 158267 RVA: 0x0054A639 File Offset: 0x00548839
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
