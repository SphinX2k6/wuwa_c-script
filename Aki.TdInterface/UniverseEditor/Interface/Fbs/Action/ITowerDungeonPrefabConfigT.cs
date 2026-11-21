using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C15 RID: 31765
	public class ITowerDungeonPrefabConfigT
	{
		// Token: 0x1700EDD8 RID: 60888
		// (get) Token: 0x06039400 RID: 234496 RVA: 0x007BB870 File Offset: 0x007B9A70
		// (set) Token: 0x06039401 RID: 234497 RVA: 0x007BB878 File Offset: 0x007B9A78
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700EDD9 RID: 60889
		// (get) Token: 0x06039402 RID: 234498 RVA: 0x007BB881 File Offset: 0x007B9A81
		// (set) Token: 0x06039403 RID: 234499 RVA: 0x007BB889 File Offset: 0x007B9A89
		public int Index { get; set; }

		// Token: 0x06039404 RID: 234500 RVA: 0x007BB892 File Offset: 0x007B9A92
		public ITowerDungeonPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.Index = 0;
		}
	}
}
