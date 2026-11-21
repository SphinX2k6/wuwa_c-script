using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B71 RID: 23409
	public class IMovablePlatformVehicleFeatureT
	{
		// Token: 0x1700AB10 RID: 43792
		// (get) Token: 0x060268F0 RID: 157936 RVA: 0x00547D01 File Offset: 0x00545F01
		// (set) Token: 0x060268F1 RID: 157937 RVA: 0x00547D09 File Offset: 0x00545F09
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x1700AB11 RID: 43793
		// (get) Token: 0x060268F2 RID: 157938 RVA: 0x00547D12 File Offset: 0x00545F12
		// (set) Token: 0x060268F3 RID: 157939 RVA: 0x00547D1A File Offset: 0x00545F1A
		public List<int> PlayerAttachTags { get; set; }

		// Token: 0x1700AB12 RID: 43794
		// (get) Token: 0x060268F4 RID: 157940 RVA: 0x00547D23 File Offset: 0x00545F23
		// (set) Token: 0x060268F5 RID: 157941 RVA: 0x00547D2B File Offset: 0x00545F2B
		public int SafePointId { get; set; }

		// Token: 0x060268F6 RID: 157942 RVA: 0x00547D34 File Offset: 0x00545F34
		public IMovablePlatformVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.PlayerAttachTags = null;
			this.SafePointId = 0;
		}
	}
}
