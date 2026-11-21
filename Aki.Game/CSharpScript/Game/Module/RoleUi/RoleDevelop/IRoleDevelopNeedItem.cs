using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CC5 RID: 15557
	public interface IRoleDevelopNeedItem
	{
		// Token: 0x1700518F RID: 20879
		// (get) Token: 0x06027DA8 RID: 163240
		// (set) Token: 0x06027DA9 RID: 163241
		int ItemId { get; set; }

		// Token: 0x17005190 RID: 20880
		// (get) Token: 0x06027DAA RID: 163242
		// (set) Token: 0x06027DAB RID: 163243
		int Count { get; set; }

		// Token: 0x17005191 RID: 20881
		// (get) Token: 0x06027DAC RID: 163244
		// (set) Token: 0x06027DAD RID: 163245
		EItemMaterialType? Type { get; set; }
	}
}
