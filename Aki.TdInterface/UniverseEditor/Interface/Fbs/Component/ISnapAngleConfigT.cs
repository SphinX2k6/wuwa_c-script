using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593F RID: 22847
	public class ISnapAngleConfigT
	{
		// Token: 0x1700AB81 RID: 43905
		// (get) Token: 0x06026A9E RID: 158366 RVA: 0x005532E4 File Offset: 0x005514E4
		// (set) Token: 0x06026A9F RID: 158367 RVA: 0x005532EC File Offset: 0x005514EC
		public float Angle { get; set; }

		// Token: 0x1700AB82 RID: 43906
		// (get) Token: 0x06026AA0 RID: 158368 RVA: 0x005532F5 File Offset: 0x005514F5
		// (set) Token: 0x06026AA1 RID: 158369 RVA: 0x005532FD File Offset: 0x005514FD
		public float Range { get; set; }

		// Token: 0x06026AA2 RID: 158370 RVA: 0x00553306 File Offset: 0x00551506
		public ISnapAngleConfigT()
		{
			this.Angle = 0f;
			this.Range = 0f;
		}
	}
}
