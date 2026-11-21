using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C6B RID: 15467
	public interface IItemMaterial
	{
		// Token: 0x170050C7 RID: 20679
		// (get) Token: 0x06027931 RID: 162097
		// (set) Token: 0x06027932 RID: 162098
		int ItemId { get; set; }

		// Token: 0x170050C8 RID: 20680
		// (get) Token: 0x06027933 RID: 162099
		// (set) Token: 0x06027934 RID: 162100
		int RequiredCount { get; set; }
	}
}
