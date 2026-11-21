using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C6C RID: 15468
	public class ItemMaterial : IItemMaterial
	{
		// Token: 0x170050C9 RID: 20681
		// (get) Token: 0x06027935 RID: 162101 RVA: 0x00B19E89 File Offset: 0x00B18089
		// (set) Token: 0x06027936 RID: 162102 RVA: 0x00B19E91 File Offset: 0x00B18091
		public int ItemId { get; set; }

		// Token: 0x170050CA RID: 20682
		// (get) Token: 0x06027937 RID: 162103 RVA: 0x00B19E9A File Offset: 0x00B1809A
		// (set) Token: 0x06027938 RID: 162104 RVA: 0x00B19EA2 File Offset: 0x00B180A2
		public int RequiredCount { get; set; }
	}
}
