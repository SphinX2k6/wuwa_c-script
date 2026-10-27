using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200514E RID: 20814
	public class IEntityAngleWeightT
	{
		// Token: 0x170097CF RID: 38863
		// (get) Token: 0x06021988 RID: 137608 RVA: 0x004A9B58 File Offset: 0x004A7D58
		// (set) Token: 0x06021989 RID: 137609 RVA: 0x004A9B60 File Offset: 0x004A7D60
		public int Angle { get; set; }

		// Token: 0x170097D0 RID: 38864
		// (get) Token: 0x0602198A RID: 137610 RVA: 0x004A9B69 File Offset: 0x004A7D69
		// (set) Token: 0x0602198B RID: 137611 RVA: 0x004A9B71 File Offset: 0x004A7D71
		public int Weight { get; set; }

		// Token: 0x0602198C RID: 137612 RVA: 0x004A9B7A File Offset: 0x004A7D7A
		public IEntityAngleWeightT()
		{
			this.Angle = 0;
			this.Weight = 0;
		}
	}
}
