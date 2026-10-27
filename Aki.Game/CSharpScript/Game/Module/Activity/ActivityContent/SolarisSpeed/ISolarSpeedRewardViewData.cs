using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B0 RID: 24752
	[NullableContext(1)]
	public interface ISolarSpeedRewardViewData
	{
		// Token: 0x170090BB RID: 37051
		// (get) Token: 0x0603E954 RID: 256340
		// (set) Token: 0x0603E955 RID: 256341
		string TitleTextId { get; set; }

		// Token: 0x170090BC RID: 37052
		// (get) Token: 0x0603E956 RID: 256342
		// (set) Token: 0x0603E957 RID: 256343
		string TitleIconPath { get; set; }

		// Token: 0x170090BD RID: 37053
		// (get) Token: 0x0603E958 RID: 256344
		// (set) Token: 0x0603E959 RID: 256345
		string Score { get; set; }

		// Token: 0x170090BE RID: 37054
		// (get) Token: 0x0603E95A RID: 256346
		// (set) Token: 0x0603E95B RID: 256347
		ISolarSpeedRewardPanelData RewardPanelData { get; set; }
	}
}
