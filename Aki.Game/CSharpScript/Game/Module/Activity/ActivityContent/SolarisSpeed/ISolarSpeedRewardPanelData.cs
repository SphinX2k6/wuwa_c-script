using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005030 RID: 20528
	[NullableContext(1)]
	public interface ISolarSpeedRewardPanelData
	{
		// Token: 0x17006425 RID: 25637
		// (get) Token: 0x06033629 RID: 210473
		// (set) Token: 0x0603362A RID: 210474
		List<ISolarSpeedTabCellPanelData> TabDataList { get; set; }

		// Token: 0x17006426 RID: 25638
		// (get) Token: 0x0603362B RID: 210475
		// (set) Token: 0x0603362C RID: 210476
		List<ISolarSpeedRewardCellPanelData> RewardDataList { get; set; }
	}
}
