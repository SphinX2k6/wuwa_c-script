using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005731 RID: 22321
	public class IPhysHandleConfigT
	{
		// Token: 0x1700A65C RID: 42588
		// (get) Token: 0x060255D6 RID: 153046 RVA: 0x00527DA0 File Offset: 0x00525FA0
		// (set) Token: 0x060255D7 RID: 153047 RVA: 0x00527DA8 File Offset: 0x00525FA8
		public int PhysHandleLinearDamping { get; set; }

		// Token: 0x1700A65D RID: 42589
		// (get) Token: 0x060255D8 RID: 153048 RVA: 0x00527DB1 File Offset: 0x00525FB1
		// (set) Token: 0x060255D9 RID: 153049 RVA: 0x00527DB9 File Offset: 0x00525FB9
		public int PhysHandleAngularStiffness { get; set; }

		// Token: 0x1700A65E RID: 42590
		// (get) Token: 0x060255DA RID: 153050 RVA: 0x00527DC2 File Offset: 0x00525FC2
		// (set) Token: 0x060255DB RID: 153051 RVA: 0x00527DCA File Offset: 0x00525FCA
		public int PhysHandleLinearStiffness { get; set; }

		// Token: 0x1700A65F RID: 42591
		// (get) Token: 0x060255DC RID: 153052 RVA: 0x00527DD3 File Offset: 0x00525FD3
		// (set) Token: 0x060255DD RID: 153053 RVA: 0x00527DDB File Offset: 0x00525FDB
		public int PhysHandleAngularDamping { get; set; }

		// Token: 0x060255DE RID: 153054 RVA: 0x00527DE4 File Offset: 0x00525FE4
		public IPhysHandleConfigT()
		{
			this.PhysHandleLinearDamping = 0;
			this.PhysHandleAngularStiffness = 0;
			this.PhysHandleLinearStiffness = 0;
			this.PhysHandleAngularDamping = 0;
		}
	}
}
