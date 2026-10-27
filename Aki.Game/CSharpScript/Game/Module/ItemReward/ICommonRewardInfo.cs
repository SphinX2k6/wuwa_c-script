using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B6 RID: 22454
	[NullableContext(2)]
	public interface ICommonRewardInfo : IRewardInfo
	{
		// Token: 0x1700892A RID: 35114
		// (get) Token: 0x06039153 RID: 233811
		// (set) Token: 0x06039154 RID: 233812
		ERewardInfoType Type { get; set; }

		// Token: 0x1700892B RID: 35115
		// (get) Token: 0x06039155 RID: 233813
		// (set) Token: 0x06039156 RID: 233814
		string Title { get; set; }

		// Token: 0x1700892C RID: 35116
		// (get) Token: 0x06039157 RID: 233815
		// (set) Token: 0x06039158 RID: 233816
		string ContinueText { get; set; }

		// Token: 0x1700892D RID: 35117
		// (get) Token: 0x06039159 RID: 233817
		// (set) Token: 0x0603915A RID: 233818
		bool IsItemVisible { get; set; }

		// Token: 0x1700892E RID: 35118
		// (get) Token: 0x0603915B RID: 233819
		// (set) Token: 0x0603915C RID: 233820
		Action OnCloseCallback { get; set; }

		// Token: 0x1700892F RID: 35119
		// (get) Token: 0x0603915D RID: 233821
		// (set) Token: 0x0603915E RID: 233822
		string LeftBtnTextId { get; set; }

		// Token: 0x17008930 RID: 35120
		// (get) Token: 0x0603915F RID: 233823
		// (set) Token: 0x06039160 RID: 233824
		string RightBtnTextId { get; set; }

		// Token: 0x17008931 RID: 35121
		// (get) Token: 0x06039161 RID: 233825
		// (set) Token: 0x06039162 RID: 233826
		Action LeftAction { get; set; }

		// Token: 0x17008932 RID: 35122
		// (get) Token: 0x06039163 RID: 233827
		// (set) Token: 0x06039164 RID: 233828
		Action RightAction { get; set; }

		// Token: 0x17008933 RID: 35123
		// (get) Token: 0x06039165 RID: 233829
		// (set) Token: 0x06039166 RID: 233830
		bool? DisableMaskClose { get; set; }

		// Token: 0x17008934 RID: 35124
		// (get) Token: 0x06039167 RID: 233831
		// (set) Token: 0x06039168 RID: 233832
		bool? TipsCanSkip { get; set; }
	}
}
