using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066EB RID: 26347
	public interface IDropCatchRoleItemData
	{
		// Token: 0x17009651 RID: 38481
		// (get) Token: 0x06041D5E RID: 269662
		// (set) Token: 0x06041D5F RID: 269663
		int RoleCfgId { get; set; }

		// Token: 0x17009652 RID: 38482
		// (get) Token: 0x06041D60 RID: 269664
		// (set) Token: 0x06041D61 RID: 269665
		int BookCfgId { get; set; }

		// Token: 0x17009653 RID: 38483
		// (get) Token: 0x06041D62 RID: 269666
		// (set) Token: 0x06041D63 RID: 269667
		bool IsUnlock { get; set; }
	}
}
