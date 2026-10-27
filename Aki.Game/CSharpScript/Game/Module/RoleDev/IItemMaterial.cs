using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CBA RID: 19642
	public interface IItemMaterial
	{
		// Token: 0x17007D1D RID: 32029
		// (get) Token: 0x06032B7D RID: 207741
		// (set) Token: 0x06032B7E RID: 207742
		int ItemId { get; set; }

		// Token: 0x17007D1E RID: 32030
		// (get) Token: 0x06032B7F RID: 207743
		// (set) Token: 0x06032B80 RID: 207744
		int RequiredCount { get; set; }
	}
}
