using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004048 RID: 16456
	[NullableContext(2)]
	public interface IPlotAutoSelectOptionComponentContext
	{
		// Token: 0x17005407 RID: 21511
		// (get) Token: 0x06029B53 RID: 170835
		// (set) Token: 0x06029B54 RID: 170836
		UUISliderComponent OptionLimitBar { get; set; }

		// Token: 0x17005408 RID: 21512
		// (get) Token: 0x06029B55 RID: 170837
		// (set) Token: 0x06029B56 RID: 170838
		UUISliderComponent AutoSelectTimeBar { get; set; }

		// Token: 0x17005409 RID: 21513
		// (get) Token: 0x06029B57 RID: 170839
		// (set) Token: 0x06029B58 RID: 170840
		UUIItem ImportantList { get; set; }

		// Token: 0x1700540A RID: 21514
		// (get) Token: 0x06029B59 RID: 170841
		// (set) Token: 0x06029B5A RID: 170842
		UUITexture ImportantOptionTipsIcon { get; set; }

		// Token: 0x1700540B RID: 21515
		// (get) Token: 0x06029B5B RID: 170843
		// (set) Token: 0x06029B5C RID: 170844
		UUIText ImportantOptionTipsText { get; set; }

		// Token: 0x1700540C RID: 21516
		// (get) Token: 0x06029B5D RID: 170845
		// (set) Token: 0x06029B5E RID: 170846
		Func<ITalkItem> GetCurrentContentDelegate { get; set; }

		// Token: 0x1700540D RID: 21517
		// (get) Token: 0x06029B5F RID: 170847
		// (set) Token: 0x06029B60 RID: 170848
		Func<PlotOptionItem> GetSelectedOptionDelegate { get; set; }

		// Token: 0x1700540E RID: 21518
		// (get) Token: 0x06029B61 RID: 170849
		// (set) Token: 0x06029B62 RID: 170850
		[Nullable(new byte[]
		{
			2,
			2,
			1
		})]
		Func<PlotOptionItem[]> GetOptionItemsDelegate { [return: Nullable(new byte[]
		{
			2,
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			2,
			1
		})] set; }

		// Token: 0x1700540F RID: 21519
		// (get) Token: 0x06029B63 RID: 170851
		// (set) Token: 0x06029B64 RID: 170852
		Func<float> GetAudioRemainingTimeDelegate { get; set; }

		// Token: 0x17005410 RID: 21520
		// (get) Token: 0x06029B65 RID: 170853
		// (set) Token: 0x06029B66 RID: 170854
		Func<float> GetAutoSelectExtraWaitTimeDelegate { get; set; }

		// Token: 0x17005411 RID: 21521
		// (get) Token: 0x06029B67 RID: 170855
		// (set) Token: 0x06029B68 RID: 170856
		Action<int> SelectOptionByIndexDelegate { get; set; }

		// Token: 0x17005412 RID: 21522
		// (get) Token: 0x06029B69 RID: 170857
		// (set) Token: 0x06029B6A RID: 170858
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		Action<string, UUITexture> SetTextureByPathDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17005413 RID: 21523
		// (get) Token: 0x06029B6B RID: 170859
		// (set) Token: 0x06029B6C RID: 170860
		Action RefreshAutoPlayButtonDelegate { get; set; }
	}
}
