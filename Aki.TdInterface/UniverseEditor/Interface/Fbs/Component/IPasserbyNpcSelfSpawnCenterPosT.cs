using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB2 RID: 23730
	public class IPasserbyNpcSelfSpawnCenterPosT
	{
		// Token: 0x1700AE56 RID: 44630
		// (get) Token: 0x0602760F RID: 161295 RVA: 0x00563F76 File Offset: 0x00562176
		// (set) Token: 0x06027610 RID: 161296 RVA: 0x00563F7E File Offset: 0x0056217E
		public EPasserbyNpcSpawnCenterPosType Type { get; set; }

		// Token: 0x06027611 RID: 161297 RVA: 0x00563F87 File Offset: 0x00562187
		public IPasserbyNpcSelfSpawnCenterPosT()
		{
			this.Type = EPasserbyNpcSpawnCenterPosType.Self;
		}
	}
}
