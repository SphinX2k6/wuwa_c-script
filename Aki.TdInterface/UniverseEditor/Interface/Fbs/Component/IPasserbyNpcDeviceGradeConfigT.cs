using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C64 RID: 23652
	public class IPasserbyNpcDeviceGradeConfigT
	{
		// Token: 0x1700ADDA RID: 44506
		// (get) Token: 0x060273E1 RID: 160737 RVA: 0x00560409 File Offset: 0x0055E609
		// (set) Token: 0x060273E2 RID: 160738 RVA: 0x00560411 File Offset: 0x0055E611
		public IPasserbyNpcSpawnCountOverrideT SpawnCountOverride { get; set; }

		// Token: 0x060273E3 RID: 160739 RVA: 0x0056041A File Offset: 0x0055E61A
		public IPasserbyNpcDeviceGradeConfigT()
		{
			this.SpawnCountOverride = null;
		}
	}
}
