using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200502E RID: 20526
	[NullableContext(1)]
	public interface ISolarSpeedRewardViewData
	{
		// Token: 0x1700641D RID: 25629
		// (get) Token: 0x06033618 RID: 210456
		// (set) Token: 0x06033619 RID: 210457
		string TitleTextId { get; set; }

		// Token: 0x1700641E RID: 25630
		// (get) Token: 0x0603361A RID: 210458
		// (set) Token: 0x0603361B RID: 210459
		string TitleIconPath { get; set; }

		// Token: 0x1700641F RID: 25631
		// (get) Token: 0x0603361C RID: 210460
		// (set) Token: 0x0603361D RID: 210461
		string Score { get; set; }

		// Token: 0x17006420 RID: 25632
		// (get) Token: 0x0603361E RID: 210462
		// (set) Token: 0x0603361F RID: 210463
		ISolarSpeedRewardPanelData RewardPanelData { get; set; }
	}
}
