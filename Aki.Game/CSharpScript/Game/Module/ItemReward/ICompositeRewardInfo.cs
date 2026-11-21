using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200478F RID: 18319
	[NullableContext(2)]
	public interface ICompositeRewardInfo : IRewardInfo
	{
		// Token: 0x17005D08 RID: 23816
		// (get) Token: 0x0602E090 RID: 188560
		// (set) Token: 0x0602E091 RID: 188561
		ERewardInfoType Type { get; set; }

		// Token: 0x17005D09 RID: 23817
		// (get) Token: 0x0602E092 RID: 188562
		// (set) Token: 0x0602E093 RID: 188563
		int Id { get; set; }

		// Token: 0x17005D0A RID: 23818
		// (get) Token: 0x0602E094 RID: 188564
		// (set) Token: 0x0602E095 RID: 188565
		bool IsSuccess { get; set; }

		// Token: 0x17005D0B RID: 23819
		// (get) Token: 0x0602E096 RID: 188566
		// (set) Token: 0x0602E097 RID: 188567
		string Title { get; set; }

		// Token: 0x17005D0C RID: 23820
		// (get) Token: 0x0602E098 RID: 188568
		// (set) Token: 0x0602E099 RID: 188569
		string ContinueText { get; set; }

		// Token: 0x17005D0D RID: 23821
		// (get) Token: 0x0602E09A RID: 188570
		// (set) Token: 0x0602E09B RID: 188571
		string TitleIconPath { get; set; }

		// Token: 0x17005D0E RID: 23822
		// (get) Token: 0x0602E09C RID: 188572
		// (set) Token: 0x0602E09D RID: 188573
		bool IsProgressVisible { get; set; }

		// Token: 0x17005D0F RID: 23823
		// (get) Token: 0x0602E09E RID: 188574
		// (set) Token: 0x0602E09F RID: 188575
		[Nullable(1)]
		string ProgressBarTitle { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005D10 RID: 23824
		// (get) Token: 0x0602E0A0 RID: 188576
		// (set) Token: 0x0602E0A1 RID: 188577
		int ProgressBarAnimationTime { get; set; }

		// Token: 0x17005D11 RID: 23825
		// (get) Token: 0x0602E0A2 RID: 188578
		// (set) Token: 0x0602E0A3 RID: 188579
		bool IsItemVisible { get; set; }
	}
}
