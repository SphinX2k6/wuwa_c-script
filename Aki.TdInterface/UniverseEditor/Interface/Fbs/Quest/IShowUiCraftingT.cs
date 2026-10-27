using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004128 RID: 16680
	public class IShowUiCraftingT
	{
		// Token: 0x17007626 RID: 30246
		// (get) Token: 0x06018720 RID: 100128 RVA: 0x003868D8 File Offset: 0x00384AD8
		// (set) Token: 0x06018721 RID: 100129 RVA: 0x003868E0 File Offset: 0x00384AE0
		public EShowUiType Type { get; set; }

		// Token: 0x17007627 RID: 30247
		// (get) Token: 0x06018722 RID: 100130 RVA: 0x003868E9 File Offset: 0x00384AE9
		// (set) Token: 0x06018723 RID: 100131 RVA: 0x003868F1 File Offset: 0x00384AF1
		public List<int> EntityIds { get; set; }

		// Token: 0x17007628 RID: 30248
		// (get) Token: 0x06018724 RID: 100132 RVA: 0x003868FA File Offset: 0x00384AFA
		// (set) Token: 0x06018725 RID: 100133 RVA: 0x00386902 File Offset: 0x00384B02
		public List<int> ProductIds { get; set; }

		// Token: 0x17007629 RID: 30249
		// (get) Token: 0x06018726 RID: 100134 RVA: 0x0038690B File Offset: 0x00384B0B
		// (set) Token: 0x06018727 RID: 100135 RVA: 0x00386913 File Offset: 0x00384B13
		public byte NullMask { get; set; }

		// Token: 0x06018728 RID: 100136 RVA: 0x0038691C File Offset: 0x00384B1C
		public IShowUiCraftingT()
		{
			this.Type = EShowUiType.All;
			this.EntityIds = null;
			this.ProductIds = null;
			this.NullMask = 0;
		}
	}
}
