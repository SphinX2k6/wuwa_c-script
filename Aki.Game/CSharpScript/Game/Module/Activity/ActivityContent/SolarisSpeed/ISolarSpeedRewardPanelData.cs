using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B2 RID: 24754
	[NullableContext(1)]
	public interface ISolarSpeedRewardPanelData
	{
		// Token: 0x170090C3 RID: 37059
		// (get) Token: 0x0603E965 RID: 256357
		// (set) Token: 0x0603E966 RID: 256358
		List<ISolarSpeedTabCellPanelData> TabDataList { get; set; }

		// Token: 0x170090C4 RID: 37060
		// (get) Token: 0x0603E967 RID: 256359
		// (set) Token: 0x0603E968 RID: 256360
		List<ISolarSpeedRewardCellPanelData> RewardDataList { get; set; }
	}
}
