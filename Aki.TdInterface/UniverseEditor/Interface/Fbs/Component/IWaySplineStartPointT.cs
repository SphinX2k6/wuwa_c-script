using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B66 RID: 23398
	public class IWaySplineStartPointT
	{
		// Token: 0x1700B0C5 RID: 45253
		// (get) Token: 0x0602809D RID: 163997 RVA: 0x0058139F File Offset: 0x0057F59F
		// (set) Token: 0x0602809E RID: 163998 RVA: 0x005813A7 File Offset: 0x0057F5A7
		public EWaySplinePointType Type { get; set; }

		// Token: 0x1700B0C6 RID: 45254
		// (get) Token: 0x0602809F RID: 163999 RVA: 0x005813B0 File Offset: 0x0057F5B0
		// (set) Token: 0x060280A0 RID: 164000 RVA: 0x005813B8 File Offset: 0x0057F5B8
		public IVehicleGenerationConfigT GenerationConfig { get; set; }

		// Token: 0x060280A1 RID: 164001 RVA: 0x005813C1 File Offset: 0x0057F5C1
		public IWaySplineStartPointT()
		{
			this.Type = EWaySplinePointType.Common;
			this.GenerationConfig = null;
		}
	}
}
