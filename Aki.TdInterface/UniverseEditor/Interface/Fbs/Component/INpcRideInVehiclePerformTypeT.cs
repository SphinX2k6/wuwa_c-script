using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005648 RID: 22088
	public class INpcRideInVehiclePerformTypeT
	{
		// Token: 0x1700A3A3 RID: 41891
		// (get) Token: 0x06024B8D RID: 150413 RVA: 0x0051156B File Offset: 0x0050F76B
		// (set) Token: 0x06024B8E RID: 150414 RVA: 0x00511573 File Offset: 0x0050F773
		public EVehicleType Type { get; set; }

		// Token: 0x1700A3A4 RID: 41892
		// (get) Token: 0x06024B8F RID: 150415 RVA: 0x0051157C File Offset: 0x0050F77C
		// (set) Token: 0x06024B90 RID: 150416 RVA: 0x00511584 File Offset: 0x0050F784
		public string Montage { get; set; }

		// Token: 0x06024B91 RID: 150417 RVA: 0x0051158D File Offset: 0x0050F78D
		public INpcRideInVehiclePerformTypeT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
		}
	}
}
