using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007909 RID: 30985
	public class ISlashTowerPrefabConfigT
	{
		// Token: 0x1700E34C RID: 58188
		// (get) Token: 0x060368EC RID: 223468 RVA: 0x0074D714 File Offset: 0x0074B914
		// (set) Token: 0x060368ED RID: 223469 RVA: 0x0074D71C File Offset: 0x0074B91C
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700E34D RID: 58189
		// (get) Token: 0x060368EE RID: 223470 RVA: 0x0074D725 File Offset: 0x0074B925
		// (set) Token: 0x060368EF RID: 223471 RVA: 0x0074D72D File Offset: 0x0074B92D
		public int Index { get; set; }

		// Token: 0x060368F0 RID: 223472 RVA: 0x0074D736 File Offset: 0x0074B936
		public ISlashTowerPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.Index = 0;
		}
	}
}
