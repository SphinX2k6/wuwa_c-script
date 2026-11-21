using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC1 RID: 23745
	public class IPasserbyNpcSpawnCenterPosBaseT
	{
		// Token: 0x1700AE69 RID: 44649
		// (get) Token: 0x0602766B RID: 161387 RVA: 0x005647C6 File Offset: 0x005629C6
		// (set) Token: 0x0602766C RID: 161388 RVA: 0x005647CE File Offset: 0x005629CE
		public EPasserbyNpcSpawnCenterPosType Type { get; set; }

		// Token: 0x0602766D RID: 161389 RVA: 0x005647D7 File Offset: 0x005629D7
		public IPasserbyNpcSpawnCenterPosBaseT()
		{
			this.Type = EPasserbyNpcSpawnCenterPosType.Self;
		}
	}
}
