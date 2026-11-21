using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C73 RID: 15475
	public interface IDropRewardItemData
	{
		// Token: 0x170050DF RID: 20703
		// (get) Token: 0x06027965 RID: 162149
		// (set) Token: 0x06027966 RID: 162150
		int ItemId { get; set; }

		// Token: 0x170050E0 RID: 20704
		// (get) Token: 0x06027967 RID: 162151
		// (set) Token: 0x06027968 RID: 162152
		int Count { get; set; }

		// Token: 0x170050E1 RID: 20705
		// (get) Token: 0x06027969 RID: 162153
		// (set) Token: 0x0602796A RID: 162154
		bool HaveFinish { get; set; }
	}
}
