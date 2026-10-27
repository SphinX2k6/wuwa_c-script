using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D1C RID: 19740
	public interface IDropRewardItemData
	{
		// Token: 0x17007E0D RID: 32269
		// (get) Token: 0x06033020 RID: 208928
		// (set) Token: 0x06033021 RID: 208929
		int ItemId { get; set; }

		// Token: 0x17007E0E RID: 32270
		// (get) Token: 0x06033022 RID: 208930
		// (set) Token: 0x06033023 RID: 208931
		int Count { get; set; }

		// Token: 0x17007E0F RID: 32271
		// (get) Token: 0x06033024 RID: 208932
		// (set) Token: 0x06033025 RID: 208933
		bool HaveFinish { get; set; }
	}
}
