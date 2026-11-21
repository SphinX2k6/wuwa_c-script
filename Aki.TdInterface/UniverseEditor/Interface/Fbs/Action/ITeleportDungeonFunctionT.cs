using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B67 RID: 31591
	public class ITeleportDungeonFunctionT
	{
		// Token: 0x1700EC90 RID: 60560
		// (get) Token: 0x06038E64 RID: 233060 RVA: 0x007B1457 File Offset: 0x007AF657
		// (set) Token: 0x06038E65 RID: 233061 RVA: 0x007B145F File Offset: 0x007AF65F
		public EEnableFunctionType Type { get; set; }

		// Token: 0x1700EC91 RID: 60561
		// (get) Token: 0x06038E66 RID: 233062 RVA: 0x007B1468 File Offset: 0x007AF668
		// (set) Token: 0x06038E67 RID: 233063 RVA: 0x007B1470 File Offset: 0x007AF670
		public bool Enable { get; set; }

		// Token: 0x1700EC92 RID: 60562
		// (get) Token: 0x06038E68 RID: 233064 RVA: 0x007B1479 File Offset: 0x007AF679
		// (set) Token: 0x06038E69 RID: 233065 RVA: 0x007B1481 File Offset: 0x007AF681
		public List<int> DungeonList { get; set; }

		// Token: 0x1700EC93 RID: 60563
		// (get) Token: 0x06038E6A RID: 233066 RVA: 0x007B148A File Offset: 0x007AF68A
		// (set) Token: 0x06038E6B RID: 233067 RVA: 0x007B1492 File Offset: 0x007AF692
		public byte NullMask { get; set; }

		// Token: 0x06038E6C RID: 233068 RVA: 0x007B149B File Offset: 0x007AF69B
		public ITeleportDungeonFunctionT()
		{
			this.Type = EEnableFunctionType.TeleportDungeon;
			this.Enable = false;
			this.DungeonList = null;
			this.NullMask = 0;
		}
	}
}
