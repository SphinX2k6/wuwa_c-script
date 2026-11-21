using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F2A RID: 20266
	[NullableContext(2)]
	public interface IWheelTowerResultViewData
	{
		// Token: 0x1700635A RID: 25434
		// (get) Token: 0x06032ED6 RID: 208598
		// (set) Token: 0x06032ED7 RID: 208599
		bool EndlessMode { get; set; }

		// Token: 0x1700635B RID: 25435
		// (get) Token: 0x06032ED8 RID: 208600
		// (set) Token: 0x06032ED9 RID: 208601
		int TotalRound { get; set; }

		// Token: 0x1700635C RID: 25436
		// (get) Token: 0x06032EDA RID: 208602
		// (set) Token: 0x06032EDB RID: 208603
		int CurrentRound { get; set; }

		// Token: 0x1700635D RID: 25437
		// (get) Token: 0x06032EDC RID: 208604
		// (set) Token: 0x06032EDD RID: 208605
		int TotalScore { get; set; }

		// Token: 0x1700635E RID: 25438
		// (get) Token: 0x06032EDE RID: 208606
		// (set) Token: 0x06032EDF RID: 208607
		int CurrentScore { get; set; }

		// Token: 0x1700635F RID: 25439
		// (get) Token: 0x06032EE0 RID: 208608
		// (set) Token: 0x06032EE1 RID: 208609
		[Nullable(1)]
		List<IBossItemData> BossInfoList { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17006360 RID: 25440
		// (get) Token: 0x06032EE2 RID: 208610
		// (set) Token: 0x06032EE3 RID: 208611
		IWheelTowerResultViewButtonData LeftButtonData { get; set; }

		// Token: 0x17006361 RID: 25441
		// (get) Token: 0x06032EE4 RID: 208612
		// (set) Token: 0x06032EE5 RID: 208613
		IWheelTowerResultViewButtonData CenterButtonData { get; set; }

		// Token: 0x17006362 RID: 25442
		// (get) Token: 0x06032EE6 RID: 208614
		// (set) Token: 0x06032EE7 RID: 208615
		IWheelTowerResultViewButtonData RightButtonData { get; set; }

		// Token: 0x17006363 RID: 25443
		// (get) Token: 0x06032EE8 RID: 208616
		// (set) Token: 0x06032EE9 RID: 208617
		bool? ShowEndlessUnlockTips { get; set; }
	}
}
