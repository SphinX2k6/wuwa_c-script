using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB0 RID: 27568
	public class INotifyMonsterPlayStandbyTagsT
	{
		// Token: 0x1700CCE8 RID: 52456
		// (get) Token: 0x060306E1 RID: 198369 RVA: 0x00693CD5 File Offset: 0x00691ED5
		// (set) Token: 0x060306E2 RID: 198370 RVA: 0x00693CDD File Offset: 0x00691EDD
		public ESetBattleStateType Type { get; set; }

		// Token: 0x1700CCE9 RID: 52457
		// (get) Token: 0x060306E3 RID: 198371 RVA: 0x00693CE6 File Offset: 0x00691EE6
		// (set) Token: 0x060306E4 RID: 198372 RVA: 0x00693CEE File Offset: 0x00691EEE
		public List<IMonsterStandByConfigT> StandbyConfigs { get; set; }

		// Token: 0x1700CCEA RID: 52458
		// (get) Token: 0x060306E5 RID: 198373 RVA: 0x00693CF7 File Offset: 0x00691EF7
		// (set) Token: 0x060306E6 RID: 198374 RVA: 0x00693CFF File Offset: 0x00691EFF
		public byte NullMask { get; set; }

		// Token: 0x060306E7 RID: 198375 RVA: 0x00693D08 File Offset: 0x00691F08
		public INotifyMonsterPlayStandbyTagsT()
		{
			this.Type = ESetBattleStateType.SetBattleTag;
			this.StandbyConfigs = null;
			this.NullMask = 0;
		}
	}
}
