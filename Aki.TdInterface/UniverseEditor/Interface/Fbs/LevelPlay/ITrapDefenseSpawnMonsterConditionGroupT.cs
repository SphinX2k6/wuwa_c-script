using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045CA RID: 17866
	public class ITrapDefenseSpawnMonsterConditionGroupT
	{
		// Token: 0x17007EFD RID: 32509
		// (get) Token: 0x0601B077 RID: 110711 RVA: 0x003DA5CB File Offset: 0x003D87CB
		// (set) Token: 0x0601B078 RID: 110712 RVA: 0x003DA5D3 File Offset: 0x003D87D3
		public EConditionCount Type { get; set; }

		// Token: 0x17007EFE RID: 32510
		// (get) Token: 0x0601B079 RID: 110713 RVA: 0x003DA5DC File Offset: 0x003D87DC
		// (set) Token: 0x0601B07A RID: 110714 RVA: 0x003DA5E4 File Offset: 0x003D87E4
		public List<TTrapDefenseSpawnMonsterConditionUnion> Conditions { get; set; }

		// Token: 0x0601B07B RID: 110715 RVA: 0x003DA5ED File Offset: 0x003D87ED
		public ITrapDefenseSpawnMonsterConditionGroupT()
		{
			this.Type = EConditionCount.All;
			this.Conditions = null;
		}
	}
}
