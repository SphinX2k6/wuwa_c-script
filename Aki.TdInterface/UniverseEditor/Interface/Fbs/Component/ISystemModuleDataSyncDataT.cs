using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200602A RID: 24618
	public class ISystemModuleDataSyncDataT
	{
		// Token: 0x1700B6A5 RID: 46757
		// (get) Token: 0x06029861 RID: 170081 RVA: 0x005AAC8A File Offset: 0x005A8E8A
		// (set) Token: 0x06029862 RID: 170082 RVA: 0x005AAC92 File Offset: 0x005A8E92
		public ESyncDataSystemType Type { get; set; }

		// Token: 0x06029863 RID: 170083 RVA: 0x005AAC9B File Offset: 0x005A8E9B
		public ISystemModuleDataSyncDataT()
		{
			this.Type = ESyncDataSystemType.MotorRacing;
		}
	}
}
