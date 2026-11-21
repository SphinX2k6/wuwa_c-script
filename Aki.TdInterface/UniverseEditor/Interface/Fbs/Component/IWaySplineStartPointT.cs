using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200617C RID: 24956
	public class IWaySplineStartPointT
	{
		// Token: 0x1700BA0D RID: 47629
		// (get) Token: 0x0602A661 RID: 173665 RVA: 0x005C8E2F File Offset: 0x005C702F
		// (set) Token: 0x0602A662 RID: 173666 RVA: 0x005C8E37 File Offset: 0x005C7037
		public EWaySplinePointType Type { get; set; }

		// Token: 0x1700BA0E RID: 47630
		// (get) Token: 0x0602A663 RID: 173667 RVA: 0x005C8E40 File Offset: 0x005C7040
		// (set) Token: 0x0602A664 RID: 173668 RVA: 0x005C8E48 File Offset: 0x005C7048
		public IVehicleGenerationConfigT GenerationConfig { get; set; }

		// Token: 0x0602A665 RID: 173669 RVA: 0x005C8E51 File Offset: 0x005C7051
		public IWaySplineStartPointT()
		{
			this.Type = EWaySplinePointType.Common;
			this.GenerationConfig = null;
		}
	}
}
