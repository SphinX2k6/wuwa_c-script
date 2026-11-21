using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200502F RID: 20527
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedRewardViewData : ISolarSpeedRewardViewData
	{
		// Token: 0x17006421 RID: 25633
		// (get) Token: 0x06033620 RID: 210464 RVA: 0x00E671B3 File Offset: 0x00E653B3
		// (set) Token: 0x06033621 RID: 210465 RVA: 0x00E671BB File Offset: 0x00E653BB
		public string TitleTextId { get; set; }

		// Token: 0x17006422 RID: 25634
		// (get) Token: 0x06033622 RID: 210466 RVA: 0x00E671C4 File Offset: 0x00E653C4
		// (set) Token: 0x06033623 RID: 210467 RVA: 0x00E671CC File Offset: 0x00E653CC
		public string TitleIconPath { get; set; }

		// Token: 0x17006423 RID: 25635
		// (get) Token: 0x06033624 RID: 210468 RVA: 0x00E671D5 File Offset: 0x00E653D5
		// (set) Token: 0x06033625 RID: 210469 RVA: 0x00E671DD File Offset: 0x00E653DD
		public string Score { get; set; }

		// Token: 0x17006424 RID: 25636
		// (get) Token: 0x06033626 RID: 210470 RVA: 0x00E671E6 File Offset: 0x00E653E6
		// (set) Token: 0x06033627 RID: 210471 RVA: 0x00E671EE File Offset: 0x00E653EE
		public ISolarSpeedRewardPanelData RewardPanelData { get; set; }
	}
}
