using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x020066DB RID: 26331
	public interface IDropCatchLevelItemData
	{
		// Token: 0x17009645 RID: 38469
		// (get) Token: 0x06041D22 RID: 269602
		// (set) Token: 0x06041D23 RID: 269603
		int CfgId { get; set; }

		// Token: 0x17009646 RID: 38470
		// (get) Token: 0x06041D24 RID: 269604
		// (set) Token: 0x06041D25 RID: 269605
		EDropCatchLevelState? State { get; set; }

		// Token: 0x17009647 RID: 38471
		// (get) Token: 0x06041D26 RID: 269606
		// (set) Token: 0x06041D27 RID: 269607
		bool HasRedPoint { get; set; }
	}
}
