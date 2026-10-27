using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D0E RID: 19726
	public interface IRoleDevelopNeedItem
	{
		// Token: 0x17007DE5 RID: 32229
		// (get) Token: 0x06032FCA RID: 208842
		// (set) Token: 0x06032FCB RID: 208843
		int ItemId { get; set; }

		// Token: 0x17007DE6 RID: 32230
		// (get) Token: 0x06032FCC RID: 208844
		// (set) Token: 0x06032FCD RID: 208845
		int Count { get; set; }

		// Token: 0x17007DE7 RID: 32231
		// (get) Token: 0x06032FCE RID: 208846
		// (set) Token: 0x06032FCF RID: 208847
		EItemMaterialType? Type { get; set; }
	}
}
