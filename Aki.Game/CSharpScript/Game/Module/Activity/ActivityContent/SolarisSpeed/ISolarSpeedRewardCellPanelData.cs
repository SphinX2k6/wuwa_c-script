using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005034 RID: 20532
	[NullableContext(1)]
	public interface ISolarSpeedRewardCellPanelData
	{
		// Token: 0x17006433 RID: 25651
		// (get) Token: 0x06033647 RID: 210503
		// (set) Token: 0x06033648 RID: 210504
		int RewardId { get; set; }

		// Token: 0x17006434 RID: 25652
		// (get) Token: 0x06033649 RID: 210505
		// (set) Token: 0x0603364A RID: 210506
		string TitleTextId { get; set; }

		// Token: 0x17006435 RID: 25653
		// (get) Token: 0x0603364B RID: 210507
		// (set) Token: 0x0603364C RID: 210508
		string ProgressTextId { get; set; }

		// Token: 0x17006436 RID: 25654
		// (get) Token: 0x0603364D RID: 210509
		// (set) Token: 0x0603364E RID: 210510
		string[] ProgressTextArgs { get; set; }

		// Token: 0x17006437 RID: 25655
		// (get) Token: 0x0603364F RID: 210511
		// (set) Token: 0x06033650 RID: 210512
		TItem[] ItemsData { get; set; }

		// Token: 0x17006438 RID: 25656
		// (get) Token: 0x06033651 RID: 210513
		// (set) Token: 0x06033652 RID: 210514
		string ButtonTextId { get; set; }

		// Token: 0x17006439 RID: 25657
		// (get) Token: 0x06033653 RID: 210515
		// (set) Token: 0x06033654 RID: 210516
		bool ButtonActive { get; set; }

		// Token: 0x1700643A RID: 25658
		// (get) Token: 0x06033655 RID: 210517
		// (set) Token: 0x06033656 RID: 210518
		bool RightActive { get; set; }

		// Token: 0x1700643B RID: 25659
		// (get) Token: 0x06033657 RID: 210519
		// (set) Token: 0x06033658 RID: 210520
		bool DoneSpriteActive { get; set; }
	}
}
