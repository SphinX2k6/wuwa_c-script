using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1A RID: 23066
	public class ISystemModuleDataSyncComponentT
	{
		// Token: 0x1700AD68 RID: 44392
		// (get) Token: 0x060272D3 RID: 160467 RVA: 0x00563ADD File Offset: 0x00561CDD
		// (set) Token: 0x060272D4 RID: 160468 RVA: 0x00563AE5 File Offset: 0x00561CE5
		public bool Disabled { get; set; }

		// Token: 0x1700AD69 RID: 44393
		// (get) Token: 0x060272D5 RID: 160469 RVA: 0x00563AEE File Offset: 0x00561CEE
		// (set) Token: 0x060272D6 RID: 160470 RVA: 0x00563AF6 File Offset: 0x00561CF6
		public ISystemModuleDataSyncMotorRacingT SystemModuleData { get; set; }

		// Token: 0x1700AD6A RID: 44394
		// (get) Token: 0x060272D7 RID: 160471 RVA: 0x00563AFF File Offset: 0x00561CFF
		// (set) Token: 0x060272D8 RID: 160472 RVA: 0x00563B07 File Offset: 0x00561D07
		public byte NullMask { get; set; }

		// Token: 0x060272D9 RID: 160473 RVA: 0x00563B10 File Offset: 0x00561D10
		public ISystemModuleDataSyncComponentT()
		{
			this.Disabled = false;
			this.SystemModuleData = null;
			this.NullMask = 0;
		}
	}
}
