using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007362 RID: 29538
	public class IOpenGiantDeliveryWithReturnT
	{
		// Token: 0x1700D8A3 RID: 55459
		// (get) Token: 0x060338C4 RID: 211140 RVA: 0x006F2A29 File Offset: 0x006F0C29
		// (set) Token: 0x060338C5 RID: 211141 RVA: 0x006F2A31 File Offset: 0x006F0C31
		public ESystemType Type { get; set; }

		// Token: 0x1700D8A4 RID: 55460
		// (get) Token: 0x060338C6 RID: 211142 RVA: 0x006F2A3A File Offset: 0x006F0C3A
		// (set) Token: 0x060338C7 RID: 211143 RVA: 0x006F2A42 File Offset: 0x006F0C42
		public EGiantEcoType EcoType { get; set; }

		// Token: 0x1700D8A5 RID: 55461
		// (get) Token: 0x060338C8 RID: 211144 RVA: 0x006F2A4B File Offset: 0x006F0C4B
		// (set) Token: 0x060338C9 RID: 211145 RVA: 0x006F2A53 File Offset: 0x006F0C53
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x060338CA RID: 211146 RVA: 0x006F2A5C File Offset: 0x006F0C5C
		public IOpenGiantDeliveryWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.EcoType = EGiantEcoType.Fire;
			this.ReturnVar = null;
		}
	}
}
