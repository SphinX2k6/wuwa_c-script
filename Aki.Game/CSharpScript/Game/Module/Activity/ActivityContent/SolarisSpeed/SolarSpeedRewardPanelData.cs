using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B3 RID: 24755
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedRewardPanelData : ISolarSpeedRewardPanelData
	{
		// Token: 0x170090C5 RID: 37061
		// (get) Token: 0x0603E969 RID: 256361 RVA: 0x00F2043B File Offset: 0x00F1E63B
		// (set) Token: 0x0603E96A RID: 256362 RVA: 0x00F20443 File Offset: 0x00F1E643
		public List<ISolarSpeedTabCellPanelData> TabDataList { get; set; }

		// Token: 0x170090C6 RID: 37062
		// (get) Token: 0x0603E96B RID: 256363 RVA: 0x00F2044C File Offset: 0x00F1E64C
		// (set) Token: 0x0603E96C RID: 256364 RVA: 0x00F20454 File Offset: 0x00F1E654
		public List<ISolarSpeedRewardCellPanelData> RewardDataList { get; set; }
	}
}
