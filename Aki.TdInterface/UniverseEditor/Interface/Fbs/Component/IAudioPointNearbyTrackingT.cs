using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004ED8 RID: 20184
	public class IAudioPointNearbyTrackingT
	{
		// Token: 0x170090E2 RID: 37090
		// (get) Token: 0x0601FD01 RID: 130305 RVA: 0x0046D608 File Offset: 0x0046B808
		// (set) Token: 0x0601FD02 RID: 130306 RVA: 0x0046D610 File Offset: 0x0046B810
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x170090E3 RID: 37091
		// (get) Token: 0x0601FD03 RID: 130307 RVA: 0x0046D619 File Offset: 0x0046B819
		// (set) Token: 0x0601FD04 RID: 130308 RVA: 0x0046D621 File Offset: 0x0046B821
		public int NearRadius { get; set; }

		// Token: 0x170090E4 RID: 37092
		// (get) Token: 0x0601FD05 RID: 130309 RVA: 0x0046D62A File Offset: 0x0046B82A
		// (set) Token: 0x0601FD06 RID: 130310 RVA: 0x0046D632 File Offset: 0x0046B832
		public int MiddleRadius { get; set; }

		// Token: 0x170090E5 RID: 37093
		// (get) Token: 0x0601FD07 RID: 130311 RVA: 0x0046D63B File Offset: 0x0046B83B
		// (set) Token: 0x0601FD08 RID: 130312 RVA: 0x0046D643 File Offset: 0x0046B843
		public int FarRadius { get; set; }

		// Token: 0x0601FD09 RID: 130313 RVA: 0x0046D64C File Offset: 0x0046B84C
		public IAudioPointNearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.NearRadius = 0;
			this.MiddleRadius = 0;
			this.FarRadius = 0;
		}
	}
}
