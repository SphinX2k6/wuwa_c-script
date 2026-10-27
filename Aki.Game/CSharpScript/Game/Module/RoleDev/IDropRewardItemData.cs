using System;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CC2 RID: 19650
	public interface IDropRewardItemData
	{
		// Token: 0x17007D35 RID: 32053
		// (get) Token: 0x06032BB1 RID: 207793
		// (set) Token: 0x06032BB2 RID: 207794
		int ItemId { get; set; }

		// Token: 0x17007D36 RID: 32054
		// (get) Token: 0x06032BB3 RID: 207795
		// (set) Token: 0x06032BB4 RID: 207796
		int Count { get; set; }

		// Token: 0x17007D37 RID: 32055
		// (get) Token: 0x06032BB5 RID: 207797
		// (set) Token: 0x06032BB6 RID: 207798
		bool HaveFinish { get; set; }
	}
}
