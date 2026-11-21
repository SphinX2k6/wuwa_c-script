using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE6 RID: 23526
	public class INpcRideInVehiclePerformTypeT
	{
		// Token: 0x1700AC2D RID: 44077
		// (get) Token: 0x06026DAC RID: 159148 RVA: 0x00551E8F File Offset: 0x0055008F
		// (set) Token: 0x06026DAD RID: 159149 RVA: 0x00551E97 File Offset: 0x00550097
		public EVehicleType Type { get; set; }

		// Token: 0x1700AC2E RID: 44078
		// (get) Token: 0x06026DAE RID: 159150 RVA: 0x00551EA0 File Offset: 0x005500A0
		// (set) Token: 0x06026DAF RID: 159151 RVA: 0x00551EA8 File Offset: 0x005500A8
		public string Montage { get; set; }

		// Token: 0x06026DB0 RID: 159152 RVA: 0x00551EB1 File Offset: 0x005500B1
		public INpcRideInVehiclePerformTypeT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
		}
	}
}
