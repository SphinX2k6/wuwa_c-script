using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CBB RID: 19643
	public class ItemMaterial : IItemMaterial
	{
		// Token: 0x17007D1F RID: 32031
		// (get) Token: 0x06032B81 RID: 207745 RVA: 0x00BD50F1 File Offset: 0x00BD32F1
		// (set) Token: 0x06032B82 RID: 207746 RVA: 0x00BD50F9 File Offset: 0x00BD32F9
		public int ItemId { get; set; }

		// Token: 0x17007D20 RID: 32032
		// (get) Token: 0x06032B83 RID: 207747 RVA: 0x00BD5102 File Offset: 0x00BD3302
		// (set) Token: 0x06032B84 RID: 207748 RVA: 0x00BD510A File Offset: 0x00BD330A
		public int RequiredCount { get; set; }
	}
}
