using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200613A RID: 24890
	public class IVehicleMontagePlayConfigT
	{
		// Token: 0x1700B968 RID: 47464
		// (get) Token: 0x0602A3CE RID: 173006 RVA: 0x005C3A99 File Offset: 0x005C1C99
		// (set) Token: 0x0602A3CF RID: 173007 RVA: 0x005C3AA1 File Offset: 0x005C1CA1
		public float MinMontageSpeedFactor { get; set; }

		// Token: 0x1700B969 RID: 47465
		// (get) Token: 0x0602A3D0 RID: 173008 RVA: 0x005C3AAA File Offset: 0x005C1CAA
		// (set) Token: 0x0602A3D1 RID: 173009 RVA: 0x005C3AB2 File Offset: 0x005C1CB2
		public float MaxMontageSpeedFactor { get; set; }

		// Token: 0x1700B96A RID: 47466
		// (get) Token: 0x0602A3D2 RID: 173010 RVA: 0x005C3ABB File Offset: 0x005C1CBB
		// (set) Token: 0x0602A3D3 RID: 173011 RVA: 0x005C3AC3 File Offset: 0x005C1CC3
		public float MinVehicleSpeed { get; set; }

		// Token: 0x1700B96B RID: 47467
		// (get) Token: 0x0602A3D4 RID: 173012 RVA: 0x005C3ACC File Offset: 0x005C1CCC
		// (set) Token: 0x0602A3D5 RID: 173013 RVA: 0x005C3AD4 File Offset: 0x005C1CD4
		public float MaxVehicleSpeed { get; set; }

		// Token: 0x1700B96C RID: 47468
		// (get) Token: 0x0602A3D6 RID: 173014 RVA: 0x005C3ADD File Offset: 0x005C1CDD
		// (set) Token: 0x0602A3D7 RID: 173015 RVA: 0x005C3AE5 File Offset: 0x005C1CE5
		public string TargetState { get; set; }

		// Token: 0x0602A3D8 RID: 173016 RVA: 0x005C3AEE File Offset: 0x005C1CEE
		public IVehicleMontagePlayConfigT()
		{
			this.MinMontageSpeedFactor = 0f;
			this.MaxMontageSpeedFactor = 0f;
			this.MinVehicleSpeed = 0f;
			this.MaxVehicleSpeed = 0f;
			this.TargetState = null;
		}
	}
}
