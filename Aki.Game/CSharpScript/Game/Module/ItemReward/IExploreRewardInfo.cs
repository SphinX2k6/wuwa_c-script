using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004791 RID: 18321
	[NullableContext(2)]
	public interface IExploreRewardInfo : IRewardInfo
	{
		// Token: 0x17005D1C RID: 23836
		// (get) Token: 0x0602E0B9 RID: 188601
		// (set) Token: 0x0602E0BA RID: 188602
		ERewardInfoType Type { get; set; }

		// Token: 0x17005D1D RID: 23837
		// (get) Token: 0x0602E0BB RID: 188603
		// (set) Token: 0x0602E0BC RID: 188604
		bool IsSuccess { get; set; }

		// Token: 0x17005D1E RID: 23838
		// (get) Token: 0x0602E0BD RID: 188605
		// (set) Token: 0x0602E0BE RID: 188606
		string Title { get; set; }

		// Token: 0x17005D1F RID: 23839
		// (get) Token: 0x0602E0BF RID: 188607
		// (set) Token: 0x0602E0C0 RID: 188608
		string TitleHexColor { get; set; }

		// Token: 0x17005D20 RID: 23840
		// (get) Token: 0x0602E0C1 RID: 188609
		// (set) Token: 0x0602E0C2 RID: 188610
		string TitleIconPath { get; set; }

		// Token: 0x17005D21 RID: 23841
		// (get) Token: 0x0602E0C3 RID: 188611
		// (set) Token: 0x0602E0C4 RID: 188612
		string TitleIconHexColor { get; set; }

		// Token: 0x17005D22 RID: 23842
		// (get) Token: 0x0602E0C5 RID: 188613
		// (set) Token: 0x0602E0C6 RID: 188614
		bool IsRecordVisible { get; set; }

		// Token: 0x17005D23 RID: 23843
		// (get) Token: 0x0602E0C7 RID: 188615
		// (set) Token: 0x0602E0C8 RID: 188616
		bool IsItemVisible { get; set; }

		// Token: 0x17005D24 RID: 23844
		// (get) Token: 0x0602E0C9 RID: 188617
		// (set) Token: 0x0602E0CA RID: 188618
		bool IsExploreProgressVisible { get; set; }

		// Token: 0x17005D25 RID: 23845
		// (get) Token: 0x0602E0CB RID: 188619
		// (set) Token: 0x0602E0CC RID: 188620
		string ExploreBarTipsTextId { get; set; }

		// Token: 0x17005D26 RID: 23846
		// (get) Token: 0x0602E0CD RID: 188621
		// (set) Token: 0x0602E0CE RID: 188622
		bool IsDescription { get; set; }

		// Token: 0x17005D27 RID: 23847
		// (get) Token: 0x0602E0CF RID: 188623
		// (set) Token: 0x0602E0D0 RID: 188624
		string Description { get; set; }

		// Token: 0x17005D28 RID: 23848
		// (get) Token: 0x0602E0D1 RID: 188625
		// (set) Token: 0x0602E0D2 RID: 188626
		bool? IsShowOnlineChallengePlayer { get; set; }

		// Token: 0x17005D29 RID: 23849
		// (get) Token: 0x0602E0D3 RID: 188627
		// (set) Token: 0x0602E0D4 RID: 188628
		string Tip { get; set; }

		// Token: 0x17005D2A RID: 23850
		// (get) Token: 0x0602E0D5 RID: 188629
		// (set) Token: 0x0602E0D6 RID: 188630
		bool? IsRewardMultiLine { get; set; }

		// Token: 0x17005D2B RID: 23851
		// (get) Token: 0x0602E0D7 RID: 188631
		// (set) Token: 0x0602E0D8 RID: 188632
		Action OnCloseCallback { get; set; }

		// Token: 0x17005D2C RID: 23852
		// (get) Token: 0x0602E0D9 RID: 188633
		// (set) Token: 0x0602E0DA RID: 188634
		bool? IsBagFull { get; set; }
	}
}
