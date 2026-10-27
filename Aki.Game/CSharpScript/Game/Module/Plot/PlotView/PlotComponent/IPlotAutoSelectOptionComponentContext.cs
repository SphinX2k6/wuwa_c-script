using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005078 RID: 20600
	[NullableContext(2)]
	public interface IPlotAutoSelectOptionComponentContext
	{
		// Token: 0x17008047 RID: 32839
		// (get) Token: 0x06034C5E RID: 216158
		// (set) Token: 0x06034C5F RID: 216159
		UUISliderComponent OptionLimitBar { get; set; }

		// Token: 0x17008048 RID: 32840
		// (get) Token: 0x06034C60 RID: 216160
		// (set) Token: 0x06034C61 RID: 216161
		UUISliderComponent AutoSelectTimeBar { get; set; }

		// Token: 0x17008049 RID: 32841
		// (get) Token: 0x06034C62 RID: 216162
		// (set) Token: 0x06034C63 RID: 216163
		UUIItem ImportantList { get; set; }

		// Token: 0x1700804A RID: 32842
		// (get) Token: 0x06034C64 RID: 216164
		// (set) Token: 0x06034C65 RID: 216165
		UUITexture ImportantOptionTipsIcon { get; set; }

		// Token: 0x1700804B RID: 32843
		// (get) Token: 0x06034C66 RID: 216166
		// (set) Token: 0x06034C67 RID: 216167
		UUIText ImportantOptionTipsText { get; set; }

		// Token: 0x1700804C RID: 32844
		// (get) Token: 0x06034C68 RID: 216168
		// (set) Token: 0x06034C69 RID: 216169
		Func<ITalkItem> GetCurrentContentDelegate { get; set; }

		// Token: 0x1700804D RID: 32845
		// (get) Token: 0x06034C6A RID: 216170
		// (set) Token: 0x06034C6B RID: 216171
		Func<PlotOptionItem> GetSelectedOptionDelegate { get; set; }

		// Token: 0x1700804E RID: 32846
		// (get) Token: 0x06034C6C RID: 216172
		// (set) Token: 0x06034C6D RID: 216173
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

		// Token: 0x1700804F RID: 32847
		// (get) Token: 0x06034C6E RID: 216174
		// (set) Token: 0x06034C6F RID: 216175
		Func<float> GetAudioRemainingTimeDelegate { get; set; }

		// Token: 0x17008050 RID: 32848
		// (get) Token: 0x06034C70 RID: 216176
		// (set) Token: 0x06034C71 RID: 216177
		Func<float> GetAutoSelectExtraWaitTimeDelegate { get; set; }

		// Token: 0x17008051 RID: 32849
		// (get) Token: 0x06034C72 RID: 216178
		// (set) Token: 0x06034C73 RID: 216179
		Action<int> SelectOptionByIndexDelegate { get; set; }

		// Token: 0x17008052 RID: 32850
		// (get) Token: 0x06034C74 RID: 216180
		// (set) Token: 0x06034C75 RID: 216181
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

		// Token: 0x17008053 RID: 32851
		// (get) Token: 0x06034C76 RID: 216182
		// (set) Token: 0x06034C77 RID: 216183
		Action RefreshAutoPlayButtonDelegate { get; set; }
	}
}
