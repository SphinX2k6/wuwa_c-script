using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F2B RID: 20267
	[NullableContext(2)]
	[Nullable(0)]
	public class WheelTowerResultViewData : IWheelTowerResultViewData
	{
		// Token: 0x17006364 RID: 25444
		// (get) Token: 0x06032EEA RID: 208618 RVA: 0x00E477DB File Offset: 0x00E459DB
		// (set) Token: 0x06032EEB RID: 208619 RVA: 0x00E477E3 File Offset: 0x00E459E3
		public bool EndlessMode { get; set; }

		// Token: 0x17006365 RID: 25445
		// (get) Token: 0x06032EEC RID: 208620 RVA: 0x00E477EC File Offset: 0x00E459EC
		// (set) Token: 0x06032EED RID: 208621 RVA: 0x00E477F4 File Offset: 0x00E459F4
		public int TotalRound { get; set; }

		// Token: 0x17006366 RID: 25446
		// (get) Token: 0x06032EEE RID: 208622 RVA: 0x00E477FD File Offset: 0x00E459FD
		// (set) Token: 0x06032EEF RID: 208623 RVA: 0x00E47805 File Offset: 0x00E45A05
		public int CurrentRound { get; set; }

		// Token: 0x17006367 RID: 25447
		// (get) Token: 0x06032EF0 RID: 208624 RVA: 0x00E4780E File Offset: 0x00E45A0E
		// (set) Token: 0x06032EF1 RID: 208625 RVA: 0x00E47816 File Offset: 0x00E45A16
		public int TotalScore { get; set; }

		// Token: 0x17006368 RID: 25448
		// (get) Token: 0x06032EF2 RID: 208626 RVA: 0x00E4781F File Offset: 0x00E45A1F
		// (set) Token: 0x06032EF3 RID: 208627 RVA: 0x00E47827 File Offset: 0x00E45A27
		public int CurrentScore { get; set; }

		// Token: 0x17006369 RID: 25449
		// (get) Token: 0x06032EF4 RID: 208628 RVA: 0x00E47830 File Offset: 0x00E45A30
		// (set) Token: 0x06032EF5 RID: 208629 RVA: 0x00E47838 File Offset: 0x00E45A38
		[Nullable(1)]
		public List<IBossItemData> BossInfoList { [NullableContext(1)] get; [NullableContext(1)] set; } = new List<IBossItemData>();

		// Token: 0x1700636A RID: 25450
		// (get) Token: 0x06032EF6 RID: 208630 RVA: 0x00E47841 File Offset: 0x00E45A41
		// (set) Token: 0x06032EF7 RID: 208631 RVA: 0x00E47849 File Offset: 0x00E45A49
		public IWheelTowerResultViewButtonData LeftButtonData { get; set; }

		// Token: 0x1700636B RID: 25451
		// (get) Token: 0x06032EF8 RID: 208632 RVA: 0x00E47852 File Offset: 0x00E45A52
		// (set) Token: 0x06032EF9 RID: 208633 RVA: 0x00E4785A File Offset: 0x00E45A5A
		public IWheelTowerResultViewButtonData CenterButtonData { get; set; }

		// Token: 0x1700636C RID: 25452
		// (get) Token: 0x06032EFA RID: 208634 RVA: 0x00E47863 File Offset: 0x00E45A63
		// (set) Token: 0x06032EFB RID: 208635 RVA: 0x00E4786B File Offset: 0x00E45A6B
		public IWheelTowerResultViewButtonData RightButtonData { get; set; }

		// Token: 0x1700636D RID: 25453
		// (get) Token: 0x06032EFC RID: 208636 RVA: 0x00E47874 File Offset: 0x00E45A74
		// (set) Token: 0x06032EFD RID: 208637 RVA: 0x00E4787C File Offset: 0x00E45A7C
		public bool? ShowEndlessUnlockTips { get; set; }
	}
}
