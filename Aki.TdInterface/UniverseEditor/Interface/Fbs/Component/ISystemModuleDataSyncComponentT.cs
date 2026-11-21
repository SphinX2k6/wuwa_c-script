using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006027 RID: 24615
	public class ISystemModuleDataSyncComponentT
	{
		// Token: 0x1700B6A0 RID: 46752
		// (get) Token: 0x0602984B RID: 170059 RVA: 0x005AAAA1 File Offset: 0x005A8CA1
		// (set) Token: 0x0602984C RID: 170060 RVA: 0x005AAAA9 File Offset: 0x005A8CA9
		public bool Disabled { get; set; }

		// Token: 0x1700B6A1 RID: 46753
		// (get) Token: 0x0602984D RID: 170061 RVA: 0x005AAAB2 File Offset: 0x005A8CB2
		// (set) Token: 0x0602984E RID: 170062 RVA: 0x005AAABA File Offset: 0x005A8CBA
		public ISystemModuleDataSyncMotorRacingT SystemModuleData { get; set; }

		// Token: 0x1700B6A2 RID: 46754
		// (get) Token: 0x0602984F RID: 170063 RVA: 0x005AAAC3 File Offset: 0x005A8CC3
		// (set) Token: 0x06029850 RID: 170064 RVA: 0x005AAACB File Offset: 0x005A8CCB
		public byte NullMask { get; set; }

		// Token: 0x06029851 RID: 170065 RVA: 0x005AAAD4 File Offset: 0x005A8CD4
		public ISystemModuleDataSyncComponentT()
		{
			this.Disabled = false;
			this.SystemModuleData = null;
			this.NullMask = 0;
		}
	}
}
