using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B15 RID: 23317
	public class IVehicleGenerateByVehicleEntityTemplateT
	{
		// Token: 0x1700AFFB RID: 45051
		// (get) Token: 0x06027D70 RID: 163184 RVA: 0x0057AC5A File Offset: 0x00578E5A
		// (set) Token: 0x06027D71 RID: 163185 RVA: 0x0057AC62 File Offset: 0x00578E62
		public EVehicleGenerationType Type { get; set; }

		// Token: 0x1700AFFC RID: 45052
		// (get) Token: 0x06027D72 RID: 163186 RVA: 0x0057AC6B File Offset: 0x00578E6B
		// (set) Token: 0x06027D73 RID: 163187 RVA: 0x0057AC73 File Offset: 0x00578E73
		public int Id { get; set; }

		// Token: 0x1700AFFD RID: 45053
		// (get) Token: 0x06027D74 RID: 163188 RVA: 0x0057AC7C File Offset: 0x00578E7C
		// (set) Token: 0x06027D75 RID: 163189 RVA: 0x0057AC84 File Offset: 0x00578E84
		public int Weight { get; set; }

		// Token: 0x06027D76 RID: 163190 RVA: 0x0057AC8D File Offset: 0x00578E8D
		public IVehicleGenerateByVehicleEntityTemplateT()
		{
			this.Type = EVehicleGenerationType.VehicleEntityTemplate;
			this.Id = 0;
			this.Weight = 0;
		}
	}
}
