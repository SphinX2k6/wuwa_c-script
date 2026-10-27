using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057B8 RID: 22456
	[NullableContext(2)]
	public interface ICompositeRewardInfo : IRewardInfo
	{
		// Token: 0x17008940 RID: 35136
		// (get) Token: 0x06039180 RID: 233856
		// (set) Token: 0x06039181 RID: 233857
		ERewardInfoType Type { get; set; }

		// Token: 0x17008941 RID: 35137
		// (get) Token: 0x06039182 RID: 233858
		// (set) Token: 0x06039183 RID: 233859
		int Id { get; set; }

		// Token: 0x17008942 RID: 35138
		// (get) Token: 0x06039184 RID: 233860
		// (set) Token: 0x06039185 RID: 233861
		bool IsSuccess { get; set; }

		// Token: 0x17008943 RID: 35139
		// (get) Token: 0x06039186 RID: 233862
		// (set) Token: 0x06039187 RID: 233863
		string Title { get; set; }

		// Token: 0x17008944 RID: 35140
		// (get) Token: 0x06039188 RID: 233864
		// (set) Token: 0x06039189 RID: 233865
		string ContinueText { get; set; }

		// Token: 0x17008945 RID: 35141
		// (get) Token: 0x0603918A RID: 233866
		// (set) Token: 0x0603918B RID: 233867
		string TitleIconPath { get; set; }

		// Token: 0x17008946 RID: 35142
		// (get) Token: 0x0603918C RID: 233868
		// (set) Token: 0x0603918D RID: 233869
		bool IsProgressVisible { get; set; }

		// Token: 0x17008947 RID: 35143
		// (get) Token: 0x0603918E RID: 233870
		// (set) Token: 0x0603918F RID: 233871
		[Nullable(1)]
		string ProgressBarTitle { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17008948 RID: 35144
		// (get) Token: 0x06039190 RID: 233872
		// (set) Token: 0x06039191 RID: 233873
		int ProgressBarAnimationTime { get; set; }

		// Token: 0x17008949 RID: 35145
		// (get) Token: 0x06039192 RID: 233874
		// (set) Token: 0x06039193 RID: 233875
		bool IsItemVisible { get; set; }
	}
}
