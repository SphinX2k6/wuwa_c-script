using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042FC RID: 17148
	public class IItemTypeVariableT
	{
		// Token: 0x1700756C RID: 30060
		// (get) Token: 0x0601817A RID: 98682 RVA: 0x0036FF55 File Offset: 0x0036E155
		// (set) Token: 0x0601817B RID: 98683 RVA: 0x0036FF5D File Offset: 0x0036E15D
		public EHandInItemType Type { get; set; }

		// Token: 0x1700756D RID: 30061
		// (get) Token: 0x0601817C RID: 98684 RVA: 0x0036FF66 File Offset: 0x0036E166
		// (set) Token: 0x0601817D RID: 98685 RVA: 0x0036FF6E File Offset: 0x0036E16E
		public TVarRefUnion Var { get; set; }

		// Token: 0x1700756E RID: 30062
		// (get) Token: 0x0601817E RID: 98686 RVA: 0x0036FF77 File Offset: 0x0036E177
		// (set) Token: 0x0601817F RID: 98687 RVA: 0x0036FF7F File Offset: 0x0036E17F
		public int ItemType { get; set; }

		// Token: 0x06018180 RID: 98688 RVA: 0x0036FF88 File Offset: 0x0036E188
		public IItemTypeVariableT()
		{
			this.Type = EHandInItemType.ItemIds;
			this.Var = null;
			this.ItemType = 0;
		}
	}
}
