using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004792 RID: 18322
	[NullableContext(2)]
	[Nullable(0)]
	public class ExploreRewardInfo : RewardInfo, IExploreRewardInfo, IRewardInfo
	{
		// Token: 0x17005D2D RID: 23853
		// (get) Token: 0x0602E0DB RID: 188635 RVA: 0x00CDEC0F File Offset: 0x00CDCE0F
		// (set) Token: 0x0602E0DC RID: 188636 RVA: 0x00CDEC17 File Offset: 0x00CDCE17
		public new ERewardInfoType Type { get; set; } = ERewardInfoType.Explore;

		// Token: 0x17005D2E RID: 23854
		// (get) Token: 0x0602E0DD RID: 188637 RVA: 0x00CDEC20 File Offset: 0x00CDCE20
		// (set) Token: 0x0602E0DE RID: 188638 RVA: 0x00CDEC28 File Offset: 0x00CDCE28
		public bool IsSuccess { get; set; }

		// Token: 0x17005D2F RID: 23855
		// (get) Token: 0x0602E0DF RID: 188639 RVA: 0x00CDEC31 File Offset: 0x00CDCE31
		// (set) Token: 0x0602E0E0 RID: 188640 RVA: 0x00CDEC39 File Offset: 0x00CDCE39
		public string Title { get; set; }

		// Token: 0x17005D30 RID: 23856
		// (get) Token: 0x0602E0E1 RID: 188641 RVA: 0x00CDEC42 File Offset: 0x00CDCE42
		// (set) Token: 0x0602E0E2 RID: 188642 RVA: 0x00CDEC4A File Offset: 0x00CDCE4A
		public string TitleHexColor { get; set; }

		// Token: 0x17005D31 RID: 23857
		// (get) Token: 0x0602E0E3 RID: 188643 RVA: 0x00CDEC53 File Offset: 0x00CDCE53
		// (set) Token: 0x0602E0E4 RID: 188644 RVA: 0x00CDEC5B File Offset: 0x00CDCE5B
		public string TitleIconPath { get; set; }

		// Token: 0x17005D32 RID: 23858
		// (get) Token: 0x0602E0E5 RID: 188645 RVA: 0x00CDEC64 File Offset: 0x00CDCE64
		// (set) Token: 0x0602E0E6 RID: 188646 RVA: 0x00CDEC6C File Offset: 0x00CDCE6C
		public string TitleIconHexColor { get; set; }

		// Token: 0x17005D33 RID: 23859
		// (get) Token: 0x0602E0E7 RID: 188647 RVA: 0x00CDEC75 File Offset: 0x00CDCE75
		// (set) Token: 0x0602E0E8 RID: 188648 RVA: 0x00CDEC7D File Offset: 0x00CDCE7D
		public bool IsRecordVisible { get; set; }

		// Token: 0x17005D34 RID: 23860
		// (get) Token: 0x0602E0E9 RID: 188649 RVA: 0x00CDEC86 File Offset: 0x00CDCE86
		// (set) Token: 0x0602E0EA RID: 188650 RVA: 0x00CDEC8E File Offset: 0x00CDCE8E
		public bool IsItemVisible { get; set; }

		// Token: 0x17005D35 RID: 23861
		// (get) Token: 0x0602E0EB RID: 188651 RVA: 0x00CDEC97 File Offset: 0x00CDCE97
		// (set) Token: 0x0602E0EC RID: 188652 RVA: 0x00CDEC9F File Offset: 0x00CDCE9F
		public bool IsExploreProgressVisible { get; set; }

		// Token: 0x17005D36 RID: 23862
		// (get) Token: 0x0602E0ED RID: 188653 RVA: 0x00CDECA8 File Offset: 0x00CDCEA8
		// (set) Token: 0x0602E0EE RID: 188654 RVA: 0x00CDECB0 File Offset: 0x00CDCEB0
		public string ExploreBarTipsTextId { get; set; }

		// Token: 0x17005D37 RID: 23863
		// (get) Token: 0x0602E0EF RID: 188655 RVA: 0x00CDECB9 File Offset: 0x00CDCEB9
		// (set) Token: 0x0602E0F0 RID: 188656 RVA: 0x00CDECC1 File Offset: 0x00CDCEC1
		public bool IsDescription { get; set; }

		// Token: 0x17005D38 RID: 23864
		// (get) Token: 0x0602E0F1 RID: 188657 RVA: 0x00CDECCA File Offset: 0x00CDCECA
		// (set) Token: 0x0602E0F2 RID: 188658 RVA: 0x00CDECD2 File Offset: 0x00CDCED2
		public string Description { get; set; }

		// Token: 0x17005D39 RID: 23865
		// (get) Token: 0x0602E0F3 RID: 188659 RVA: 0x00CDECDB File Offset: 0x00CDCEDB
		// (set) Token: 0x0602E0F4 RID: 188660 RVA: 0x00CDECE3 File Offset: 0x00CDCEE3
		public bool? IsShowOnlineChallengePlayer { get; set; }

		// Token: 0x17005D3A RID: 23866
		// (get) Token: 0x0602E0F5 RID: 188661 RVA: 0x00CDECEC File Offset: 0x00CDCEEC
		// (set) Token: 0x0602E0F6 RID: 188662 RVA: 0x00CDECF4 File Offset: 0x00CDCEF4
		public string Tip { get; set; }

		// Token: 0x17005D3B RID: 23867
		// (get) Token: 0x0602E0F7 RID: 188663 RVA: 0x00CDECFD File Offset: 0x00CDCEFD
		// (set) Token: 0x0602E0F8 RID: 188664 RVA: 0x00CDED05 File Offset: 0x00CDCF05
		public bool? IsRewardMultiLine { get; set; }

		// Token: 0x17005D3C RID: 23868
		// (get) Token: 0x0602E0F9 RID: 188665 RVA: 0x00CDED0E File Offset: 0x00CDCF0E
		// (set) Token: 0x0602E0FA RID: 188666 RVA: 0x00CDED16 File Offset: 0x00CDCF16
		public Action OnCloseCallback { get; set; }

		// Token: 0x17005D3D RID: 23869
		// (get) Token: 0x0602E0FB RID: 188667 RVA: 0x00CDED1F File Offset: 0x00CDCF1F
		// (set) Token: 0x0602E0FC RID: 188668 RVA: 0x00CDED27 File Offset: 0x00CDCF27
		public bool? IsBagFull { get; set; }
	}
}
