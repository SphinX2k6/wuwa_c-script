using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007831 RID: 30769
	public class ISetRegionMpcT
	{
		// Token: 0x1700E1C0 RID: 57792
		// (get) Token: 0x060361C5 RID: 221637 RVA: 0x0073FE18 File Offset: 0x0073E018
		// (set) Token: 0x060361C6 RID: 221638 RVA: 0x0073FE20 File Offset: 0x0073E020
		public ERegionConfigType Type { get; set; }

		// Token: 0x1700E1C1 RID: 57793
		// (get) Token: 0x060361C7 RID: 221639 RVA: 0x0073FE29 File Offset: 0x0073E029
		// (set) Token: 0x060361C8 RID: 221640 RVA: 0x0073FE31 File Offset: 0x0073E031
		public int RegionMpcId { get; set; }

		// Token: 0x060361C9 RID: 221641 RVA: 0x0073FE3A File Offset: 0x0073E03A
		public ISetRegionMpcT()
		{
			this.Type = ERegionConfigType.Mpc;
			this.RegionMpcId = 0;
		}
	}
}
