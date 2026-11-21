using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005407 RID: 21511
	public class IAudioPointNearbyTrackingT
	{
		// Token: 0x17009855 RID: 38997
		// (get) Token: 0x06021A45 RID: 137797 RVA: 0x004A33D8 File Offset: 0x004A15D8
		// (set) Token: 0x06021A46 RID: 137798 RVA: 0x004A33E0 File Offset: 0x004A15E0
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x17009856 RID: 38998
		// (get) Token: 0x06021A47 RID: 137799 RVA: 0x004A33E9 File Offset: 0x004A15E9
		// (set) Token: 0x06021A48 RID: 137800 RVA: 0x004A33F1 File Offset: 0x004A15F1
		public int NearRadius { get; set; }

		// Token: 0x17009857 RID: 38999
		// (get) Token: 0x06021A49 RID: 137801 RVA: 0x004A33FA File Offset: 0x004A15FA
		// (set) Token: 0x06021A4A RID: 137802 RVA: 0x004A3402 File Offset: 0x004A1602
		public int MiddleRadius { get; set; }

		// Token: 0x17009858 RID: 39000
		// (get) Token: 0x06021A4B RID: 137803 RVA: 0x004A340B File Offset: 0x004A160B
		// (set) Token: 0x06021A4C RID: 137804 RVA: 0x004A3413 File Offset: 0x004A1613
		public int FarRadius { get; set; }

		// Token: 0x06021A4D RID: 137805 RVA: 0x004A341C File Offset: 0x004A161C
		public IAudioPointNearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.NearRadius = 0;
			this.MiddleRadius = 0;
			this.FarRadius = 0;
		}
	}
}
