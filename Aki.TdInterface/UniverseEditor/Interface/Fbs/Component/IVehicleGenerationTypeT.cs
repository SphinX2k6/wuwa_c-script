using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1E RID: 23326
	public class IVehicleGenerationTypeT
	{
		// Token: 0x1700B015 RID: 45077
		// (get) Token: 0x06027DDC RID: 163292 RVA: 0x0057BB36 File Offset: 0x00579D36
		// (set) Token: 0x06027DDD RID: 163293 RVA: 0x0057BB3E File Offset: 0x00579D3E
		public EVehicleGenerationType Type { get; set; }

		// Token: 0x1700B016 RID: 45078
		// (get) Token: 0x06027DDE RID: 163294 RVA: 0x0057BB47 File Offset: 0x00579D47
		// (set) Token: 0x06027DDF RID: 163295 RVA: 0x0057BB4F File Offset: 0x00579D4F
		public int Id { get; set; }

		// Token: 0x1700B017 RID: 45079
		// (get) Token: 0x06027DE0 RID: 163296 RVA: 0x0057BB58 File Offset: 0x00579D58
		// (set) Token: 0x06027DE1 RID: 163297 RVA: 0x0057BB60 File Offset: 0x00579D60
		public int Weight { get; set; }

		// Token: 0x06027DE2 RID: 163298 RVA: 0x0057BB69 File Offset: 0x00579D69
		public IVehicleGenerationTypeT()
		{
			this.Type = EVehicleGenerationType.VehicleEntityTemplate;
			this.Id = 0;
			this.Weight = 0;
		}
	}
}
