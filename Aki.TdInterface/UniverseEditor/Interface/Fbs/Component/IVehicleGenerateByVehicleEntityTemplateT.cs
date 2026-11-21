using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200612B RID: 24875
	public class IVehicleGenerateByVehicleEntityTemplateT
	{
		// Token: 0x1700B943 RID: 47427
		// (get) Token: 0x0602A334 RID: 172852 RVA: 0x005C26AE File Offset: 0x005C08AE
		// (set) Token: 0x0602A335 RID: 172853 RVA: 0x005C26B6 File Offset: 0x005C08B6
		public EVehicleGenerationType Type { get; set; }

		// Token: 0x1700B944 RID: 47428
		// (get) Token: 0x0602A336 RID: 172854 RVA: 0x005C26BF File Offset: 0x005C08BF
		// (set) Token: 0x0602A337 RID: 172855 RVA: 0x005C26C7 File Offset: 0x005C08C7
		public int Id { get; set; }

		// Token: 0x1700B945 RID: 47429
		// (get) Token: 0x0602A338 RID: 172856 RVA: 0x005C26D0 File Offset: 0x005C08D0
		// (set) Token: 0x0602A339 RID: 172857 RVA: 0x005C26D8 File Offset: 0x005C08D8
		public int Weight { get; set; }

		// Token: 0x0602A33A RID: 172858 RVA: 0x005C26E1 File Offset: 0x005C08E1
		public IVehicleGenerateByVehicleEntityTemplateT()
		{
			this.Type = EVehicleGenerationType.VehicleEntityTemplate;
			this.Id = 0;
			this.Weight = 0;
		}
	}
}
