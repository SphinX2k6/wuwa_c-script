using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D2 RID: 22482
	[NullableContext(2)]
	public interface IRewardExploreConfirmButton
	{
		// Token: 0x170089BA RID: 35258
		// (get) Token: 0x06039281 RID: 234113
		// (set) Token: 0x06039282 RID: 234114
		[Nullable(1)]
		string ButtonTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170089BB RID: 35259
		// (get) Token: 0x06039283 RID: 234115
		// (set) Token: 0x06039284 RID: 234116
		string DescriptionTextId { get; set; }

		// Token: 0x170089BC RID: 35260
		// (get) Token: 0x06039285 RID: 234117
		// (set) Token: 0x06039286 RID: 234118
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<object> DescriptionArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170089BD RID: 35261
		// (get) Token: 0x06039287 RID: 234119
		// (set) Token: 0x06039288 RID: 234120
		int? TimeDown { get; set; }

		// Token: 0x170089BE RID: 35262
		// (get) Token: 0x06039289 RID: 234121
		// (set) Token: 0x0603928A RID: 234122
		bool IsTimeDownCloseView { get; set; }

		// Token: 0x170089BF RID: 35263
		// (get) Token: 0x0603928B RID: 234123
		// (set) Token: 0x0603928C RID: 234124
		Action OnTimeDownOnCallback { get; set; }

		// Token: 0x170089C0 RID: 35264
		// (get) Token: 0x0603928D RID: 234125
		// (set) Token: 0x0603928E RID: 234126
		bool IsClickedCloseView { get; set; }

		// Token: 0x170089C1 RID: 35265
		// (get) Token: 0x0603928F RID: 234127
		// (set) Token: 0x06039290 RID: 234128
		Action<int> OnClickedCallback { get; set; }

		// Token: 0x170089C2 RID: 35266
		// (get) Token: 0x06039291 RID: 234129
		// (set) Token: 0x06039292 RID: 234130
		int? ClickCd { get; set; }
	}
}
