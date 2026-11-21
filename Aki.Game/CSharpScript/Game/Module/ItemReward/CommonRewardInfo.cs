using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200478E RID: 18318
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonRewardInfo : RewardInfo, ICommonRewardInfo, IRewardInfo
	{
		// Token: 0x17005CFD RID: 23805
		// (get) Token: 0x0602E079 RID: 188537 RVA: 0x00CDEA8C File Offset: 0x00CDCC8C
		// (set) Token: 0x0602E07A RID: 188538 RVA: 0x00CDEA94 File Offset: 0x00CDCC94
		public new ERewardInfoType Type { get; set; } = ERewardInfoType.Common;

		// Token: 0x17005CFE RID: 23806
		// (get) Token: 0x0602E07B RID: 188539 RVA: 0x00CDEA9D File Offset: 0x00CDCC9D
		// (set) Token: 0x0602E07C RID: 188540 RVA: 0x00CDEAA5 File Offset: 0x00CDCCA5
		public string Title { get; set; }

		// Token: 0x17005CFF RID: 23807
		// (get) Token: 0x0602E07D RID: 188541 RVA: 0x00CDEAAE File Offset: 0x00CDCCAE
		// (set) Token: 0x0602E07E RID: 188542 RVA: 0x00CDEAB6 File Offset: 0x00CDCCB6
		public string ContinueText { get; set; }

		// Token: 0x17005D00 RID: 23808
		// (get) Token: 0x0602E07F RID: 188543 RVA: 0x00CDEABF File Offset: 0x00CDCCBF
		// (set) Token: 0x0602E080 RID: 188544 RVA: 0x00CDEAC7 File Offset: 0x00CDCCC7
		public bool IsItemVisible { get; set; }

		// Token: 0x17005D01 RID: 23809
		// (get) Token: 0x0602E081 RID: 188545 RVA: 0x00CDEAD0 File Offset: 0x00CDCCD0
		// (set) Token: 0x0602E082 RID: 188546 RVA: 0x00CDEAD8 File Offset: 0x00CDCCD8
		public Action OnCloseCallback { get; set; }

		// Token: 0x17005D02 RID: 23810
		// (get) Token: 0x0602E083 RID: 188547 RVA: 0x00CDEAE1 File Offset: 0x00CDCCE1
		// (set) Token: 0x0602E084 RID: 188548 RVA: 0x00CDEAE9 File Offset: 0x00CDCCE9
		public string LeftBtnTextId { get; set; }

		// Token: 0x17005D03 RID: 23811
		// (get) Token: 0x0602E085 RID: 188549 RVA: 0x00CDEAF2 File Offset: 0x00CDCCF2
		// (set) Token: 0x0602E086 RID: 188550 RVA: 0x00CDEAFA File Offset: 0x00CDCCFA
		public string RightBtnTextId { get; set; }

		// Token: 0x17005D04 RID: 23812
		// (get) Token: 0x0602E087 RID: 188551 RVA: 0x00CDEB03 File Offset: 0x00CDCD03
		// (set) Token: 0x0602E088 RID: 188552 RVA: 0x00CDEB0B File Offset: 0x00CDCD0B
		public Action LeftAction { get; set; }

		// Token: 0x17005D05 RID: 23813
		// (get) Token: 0x0602E089 RID: 188553 RVA: 0x00CDEB14 File Offset: 0x00CDCD14
		// (set) Token: 0x0602E08A RID: 188554 RVA: 0x00CDEB1C File Offset: 0x00CDCD1C
		public Action RightAction { get; set; }

		// Token: 0x17005D06 RID: 23814
		// (get) Token: 0x0602E08B RID: 188555 RVA: 0x00CDEB25 File Offset: 0x00CDCD25
		// (set) Token: 0x0602E08C RID: 188556 RVA: 0x00CDEB2D File Offset: 0x00CDCD2D
		public bool? DisableMaskClose { get; set; }

		// Token: 0x17005D07 RID: 23815
		// (get) Token: 0x0602E08D RID: 188557 RVA: 0x00CDEB36 File Offset: 0x00CDCD36
		// (set) Token: 0x0602E08E RID: 188558 RVA: 0x00CDEB3E File Offset: 0x00CDCD3E
		public bool? TipsCanSkip { get; set; }
	}
}
