using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1D RID: 23069
	public class ISystemModuleDataSyncDataT
	{
		// Token: 0x1700AD6D RID: 44397
		// (get) Token: 0x060272E9 RID: 160489 RVA: 0x00563CC6 File Offset: 0x00561EC6
		// (set) Token: 0x060272EA RID: 160490 RVA: 0x00563CCE File Offset: 0x00561ECE
		public ESyncDataSystemType Type { get; set; }

		// Token: 0x060272EB RID: 160491 RVA: 0x00563CD7 File Offset: 0x00561ED7
		public ISystemModuleDataSyncDataT()
		{
			this.Type = ESyncDataSystemType.MotorRacing;
		}
	}
}
