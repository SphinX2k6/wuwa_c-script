using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200478D RID: 18317
	[NullableContext(2)]
	public interface ICommonRewardInfo : IRewardInfo
	{
		// Token: 0x17005CF2 RID: 23794
		// (get) Token: 0x0602E063 RID: 188515
		// (set) Token: 0x0602E064 RID: 188516
		ERewardInfoType Type { get; set; }

		// Token: 0x17005CF3 RID: 23795
		// (get) Token: 0x0602E065 RID: 188517
		// (set) Token: 0x0602E066 RID: 188518
		string Title { get; set; }

		// Token: 0x17005CF4 RID: 23796
		// (get) Token: 0x0602E067 RID: 188519
		// (set) Token: 0x0602E068 RID: 188520
		string ContinueText { get; set; }

		// Token: 0x17005CF5 RID: 23797
		// (get) Token: 0x0602E069 RID: 188521
		// (set) Token: 0x0602E06A RID: 188522
		bool IsItemVisible { get; set; }

		// Token: 0x17005CF6 RID: 23798
		// (get) Token: 0x0602E06B RID: 188523
		// (set) Token: 0x0602E06C RID: 188524
		Action OnCloseCallback { get; set; }

		// Token: 0x17005CF7 RID: 23799
		// (get) Token: 0x0602E06D RID: 188525
		// (set) Token: 0x0602E06E RID: 188526
		string LeftBtnTextId { get; set; }

		// Token: 0x17005CF8 RID: 23800
		// (get) Token: 0x0602E06F RID: 188527
		// (set) Token: 0x0602E070 RID: 188528
		string RightBtnTextId { get; set; }

		// Token: 0x17005CF9 RID: 23801
		// (get) Token: 0x0602E071 RID: 188529
		// (set) Token: 0x0602E072 RID: 188530
		Action LeftAction { get; set; }

		// Token: 0x17005CFA RID: 23802
		// (get) Token: 0x0602E073 RID: 188531
		// (set) Token: 0x0602E074 RID: 188532
		Action RightAction { get; set; }

		// Token: 0x17005CFB RID: 23803
		// (get) Token: 0x0602E075 RID: 188533
		// (set) Token: 0x0602E076 RID: 188534
		bool? DisableMaskClose { get; set; }

		// Token: 0x17005CFC RID: 23804
		// (get) Token: 0x0602E077 RID: 188535
		// (set) Token: 0x0602E078 RID: 188536
		bool? TipsCanSkip { get; set; }
	}
}
