using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F6 RID: 17142
	public class IItemIdVariableT
	{
		// Token: 0x1700755E RID: 30046
		// (get) Token: 0x06018137 RID: 98615 RVA: 0x0036F67D File Offset: 0x0036D87D
		// (set) Token: 0x06018138 RID: 98616 RVA: 0x0036F685 File Offset: 0x0036D885
		public EHandInItemType Type { get; set; }

		// Token: 0x1700755F RID: 30047
		// (get) Token: 0x06018139 RID: 98617 RVA: 0x0036F68E File Offset: 0x0036D88E
		// (set) Token: 0x0601813A RID: 98618 RVA: 0x0036F696 File Offset: 0x0036D896
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007560 RID: 30048
		// (get) Token: 0x0601813B RID: 98619 RVA: 0x0036F69F File Offset: 0x0036D89F
		// (set) Token: 0x0601813C RID: 98620 RVA: 0x0036F6A7 File Offset: 0x0036D8A7
		public int ItemId { get; set; }

		// Token: 0x0601813D RID: 98621 RVA: 0x0036F6B0 File Offset: 0x0036D8B0
		public IItemIdVariableT()
		{
			this.Type = EHandInItemType.ItemIds;
			this.Var = null;
			this.ItemId = 0;
		}
	}
}
