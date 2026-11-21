using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B3 RID: 22195
	public class IEntityAngleWeightT
	{
		// Token: 0x17009FBC RID: 40892
		// (get) Token: 0x060238DC RID: 145628 RVA: 0x004E3AE4 File Offset: 0x004E1CE4
		// (set) Token: 0x060238DD RID: 145629 RVA: 0x004E3AEC File Offset: 0x004E1CEC
		public int Angle { get; set; }

		// Token: 0x17009FBD RID: 40893
		// (get) Token: 0x060238DE RID: 145630 RVA: 0x004E3AF5 File Offset: 0x004E1CF5
		// (set) Token: 0x060238DF RID: 145631 RVA: 0x004E3AFD File Offset: 0x004E1CFD
		public int Weight { get; set; }

		// Token: 0x060238E0 RID: 145632 RVA: 0x004E3B06 File Offset: 0x004E1D06
		public IEntityAngleWeightT()
		{
			this.Angle = 0;
			this.Weight = 0;
		}
	}
}
