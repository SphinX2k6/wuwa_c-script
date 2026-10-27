using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D3 RID: 21971
	public class IMovablePlatformVehicleFeatureT
	{
		// Token: 0x1700A288 RID: 41608
		// (get) Token: 0x060246E3 RID: 149219 RVA: 0x00507789 File Offset: 0x00505989
		// (set) Token: 0x060246E4 RID: 149220 RVA: 0x00507791 File Offset: 0x00505991
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x1700A289 RID: 41609
		// (get) Token: 0x060246E5 RID: 149221 RVA: 0x0050779A File Offset: 0x0050599A
		// (set) Token: 0x060246E6 RID: 149222 RVA: 0x005077A2 File Offset: 0x005059A2
		public List<int> PlayerAttachTags { get; set; }

		// Token: 0x1700A28A RID: 41610
		// (get) Token: 0x060246E7 RID: 149223 RVA: 0x005077AB File Offset: 0x005059AB
		// (set) Token: 0x060246E8 RID: 149224 RVA: 0x005077B3 File Offset: 0x005059B3
		public int SafePointId { get; set; }

		// Token: 0x060246E9 RID: 149225 RVA: 0x005077BC File Offset: 0x005059BC
		public IMovablePlatformVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
			this.PlayerAttachTags = null;
			this.SafePointId = 0;
		}
	}
}
