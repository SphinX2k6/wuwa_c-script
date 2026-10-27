using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C0 RID: 22208
	public class IPasserbyNpcDeviceGradeConfigT
	{
		// Token: 0x1700A546 RID: 42310
		// (get) Token: 0x0602518C RID: 151948 RVA: 0x0051F4C1 File Offset: 0x0051D6C1
		// (set) Token: 0x0602518D RID: 151949 RVA: 0x0051F4C9 File Offset: 0x0051D6C9
		public IPasserbyNpcSpawnCountOverrideT SpawnCountOverride { get; set; }

		// Token: 0x0602518E RID: 151950 RVA: 0x0051F4D2 File Offset: 0x0051D6D2
		public IPasserbyNpcDeviceGradeConfigT()
		{
			this.SpawnCountOverride = null;
		}
	}
}
