using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060B1 RID: 24753
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedRewardViewData : ISolarSpeedRewardViewData
	{
		// Token: 0x170090BF RID: 37055
		// (get) Token: 0x0603E95C RID: 256348 RVA: 0x00F203EF File Offset: 0x00F1E5EF
		// (set) Token: 0x0603E95D RID: 256349 RVA: 0x00F203F7 File Offset: 0x00F1E5F7
		public string TitleTextId { get; set; }

		// Token: 0x170090C0 RID: 37056
		// (get) Token: 0x0603E95E RID: 256350 RVA: 0x00F20400 File Offset: 0x00F1E600
		// (set) Token: 0x0603E95F RID: 256351 RVA: 0x00F20408 File Offset: 0x00F1E608
		public string TitleIconPath { get; set; }

		// Token: 0x170090C1 RID: 37057
		// (get) Token: 0x0603E960 RID: 256352 RVA: 0x00F20411 File Offset: 0x00F1E611
		// (set) Token: 0x0603E961 RID: 256353 RVA: 0x00F20419 File Offset: 0x00F1E619
		public string Score { get; set; }

		// Token: 0x170090C2 RID: 37058
		// (get) Token: 0x0603E962 RID: 256354 RVA: 0x00F20422 File Offset: 0x00F1E622
		// (set) Token: 0x0603E963 RID: 256355 RVA: 0x00F2042A File Offset: 0x00F1E62A
		public ISolarSpeedRewardPanelData RewardPanelData { get; set; }
	}
}
