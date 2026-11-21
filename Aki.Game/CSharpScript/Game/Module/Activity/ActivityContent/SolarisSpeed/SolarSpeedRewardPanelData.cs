using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005031 RID: 20529
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedRewardPanelData : ISolarSpeedRewardPanelData
	{
		// Token: 0x17006427 RID: 25639
		// (get) Token: 0x0603362D RID: 210477 RVA: 0x00E671FF File Offset: 0x00E653FF
		// (set) Token: 0x0603362E RID: 210478 RVA: 0x00E67207 File Offset: 0x00E65407
		public List<ISolarSpeedTabCellPanelData> TabDataList { get; set; }

		// Token: 0x17006428 RID: 25640
		// (get) Token: 0x0603362F RID: 210479 RVA: 0x00E67210 File Offset: 0x00E65410
		// (set) Token: 0x06033630 RID: 210480 RVA: 0x00E67218 File Offset: 0x00E65418
		public List<ISolarSpeedRewardCellPanelData> RewardDataList { get; set; }
	}
}
