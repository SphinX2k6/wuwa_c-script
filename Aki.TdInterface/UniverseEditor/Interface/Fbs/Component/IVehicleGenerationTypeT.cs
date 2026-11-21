using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006134 RID: 24884
	public class IVehicleGenerationTypeT
	{
		// Token: 0x1700B95D RID: 47453
		// (get) Token: 0x0602A3A0 RID: 172960 RVA: 0x005C358A File Offset: 0x005C178A
		// (set) Token: 0x0602A3A1 RID: 172961 RVA: 0x005C3592 File Offset: 0x005C1792
		public EVehicleGenerationType Type { get; set; }

		// Token: 0x1700B95E RID: 47454
		// (get) Token: 0x0602A3A2 RID: 172962 RVA: 0x005C359B File Offset: 0x005C179B
		// (set) Token: 0x0602A3A3 RID: 172963 RVA: 0x005C35A3 File Offset: 0x005C17A3
		public int Id { get; set; }

		// Token: 0x1700B95F RID: 47455
		// (get) Token: 0x0602A3A4 RID: 172964 RVA: 0x005C35AC File Offset: 0x005C17AC
		// (set) Token: 0x0602A3A5 RID: 172965 RVA: 0x005C35B4 File Offset: 0x005C17B4
		public int Weight { get; set; }

		// Token: 0x0602A3A6 RID: 172966 RVA: 0x005C35BD File Offset: 0x005C17BD
		public IVehicleGenerationTypeT()
		{
			this.Type = EVehicleGenerationType.VehicleEntityTemplate;
			this.Id = 0;
			this.Weight = 0;
		}
	}
}
