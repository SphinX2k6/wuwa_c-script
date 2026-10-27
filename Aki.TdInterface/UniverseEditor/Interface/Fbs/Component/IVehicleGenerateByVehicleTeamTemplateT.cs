using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B18 RID: 23320
	public class IVehicleGenerateByVehicleTeamTemplateT
	{
		// Token: 0x1700B002 RID: 45058
		// (get) Token: 0x06027D8A RID: 163210 RVA: 0x0057AEEA File Offset: 0x005790EA
		// (set) Token: 0x06027D8B RID: 163211 RVA: 0x0057AEF2 File Offset: 0x005790F2
		public EVehicleGenerationType Type { get; set; }

		// Token: 0x1700B003 RID: 45059
		// (get) Token: 0x06027D8C RID: 163212 RVA: 0x0057AEFB File Offset: 0x005790FB
		// (set) Token: 0x06027D8D RID: 163213 RVA: 0x0057AF03 File Offset: 0x00579103
		public int Id { get; set; }

		// Token: 0x1700B004 RID: 45060
		// (get) Token: 0x06027D8E RID: 163214 RVA: 0x0057AF0C File Offset: 0x0057910C
		// (set) Token: 0x06027D8F RID: 163215 RVA: 0x0057AF14 File Offset: 0x00579114
		public int Weight { get; set; }

		// Token: 0x06027D90 RID: 163216 RVA: 0x0057AF1D File Offset: 0x0057911D
		public IVehicleGenerateByVehicleTeamTemplateT()
		{
			this.Type = EVehicleGenerationType.VehicleEntityTemplate;
			this.Id = 0;
			this.Weight = 0;
		}
	}
}
