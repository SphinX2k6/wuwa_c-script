using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200612E RID: 24878
	public class IVehicleGenerateByVehicleTeamTemplateT
	{
		// Token: 0x1700B94A RID: 47434
		// (get) Token: 0x0602A34E RID: 172878 RVA: 0x005C293E File Offset: 0x005C0B3E
		// (set) Token: 0x0602A34F RID: 172879 RVA: 0x005C2946 File Offset: 0x005C0B46
		public EVehicleGenerationType Type { get; set; }

		// Token: 0x1700B94B RID: 47435
		// (get) Token: 0x0602A350 RID: 172880 RVA: 0x005C294F File Offset: 0x005C0B4F
		// (set) Token: 0x0602A351 RID: 172881 RVA: 0x005C2957 File Offset: 0x005C0B57
		public int Id { get; set; }

		// Token: 0x1700B94C RID: 47436
		// (get) Token: 0x0602A352 RID: 172882 RVA: 0x005C2960 File Offset: 0x005C0B60
		// (set) Token: 0x0602A353 RID: 172883 RVA: 0x005C2968 File Offset: 0x005C0B68
		public int Weight { get; set; }

		// Token: 0x0602A354 RID: 172884 RVA: 0x005C2971 File Offset: 0x005C0B71
		public IVehicleGenerateByVehicleTeamTemplateT()
		{
			this.Type = EVehicleGenerationType.VehicleEntityTemplate;
			this.Id = 0;
			this.Weight = 0;
		}
	}
}
