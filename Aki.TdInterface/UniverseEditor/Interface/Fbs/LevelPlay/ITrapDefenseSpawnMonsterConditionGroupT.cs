using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A32 RID: 18994
	public class ITrapDefenseSpawnMonsterConditionGroupT
	{
		// Token: 0x1700853E RID: 34110
		// (get) Token: 0x0601C84C RID: 116812 RVA: 0x00406867 File Offset: 0x00404A67
		// (set) Token: 0x0601C84D RID: 116813 RVA: 0x0040686F File Offset: 0x00404A6F
		public EConditionCount Type { get; set; }

		// Token: 0x1700853F RID: 34111
		// (get) Token: 0x0601C84E RID: 116814 RVA: 0x00406878 File Offset: 0x00404A78
		// (set) Token: 0x0601C84F RID: 116815 RVA: 0x00406880 File Offset: 0x00404A80
		public List<TTrapDefenseSpawnMonsterConditionUnion> Conditions { get; set; }

		// Token: 0x0601C850 RID: 116816 RVA: 0x00406889 File Offset: 0x00404A89
		public ITrapDefenseSpawnMonsterConditionGroupT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
