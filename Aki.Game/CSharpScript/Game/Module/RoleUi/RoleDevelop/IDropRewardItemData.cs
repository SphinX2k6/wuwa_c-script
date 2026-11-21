using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02003CD5 RID: 15573
	public interface IDropRewardItemData
	{
		// Token: 0x170051BD RID: 20925
		// (get) Token: 0x06027E0B RID: 163339
		// (set) Token: 0x06027E0C RID: 163340
		int ItemId { get; set; }

		// Token: 0x170051BE RID: 20926
		// (get) Token: 0x06027E0D RID: 163341
		// (set) Token: 0x06027E0E RID: 163342
		int Count { get; set; }

		// Token: 0x170051BF RID: 20927
		// (get) Token: 0x06027E0F RID: 163343
		// (set) Token: 0x06027E10 RID: 163344
		bool HaveFinish { get; set; }
	}
}
