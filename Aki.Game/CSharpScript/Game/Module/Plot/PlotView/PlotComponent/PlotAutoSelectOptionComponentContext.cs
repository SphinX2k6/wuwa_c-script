using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004049 RID: 16457
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAutoSelectOptionComponentContext : IPlotAutoSelectOptionComponentContext
	{
		// Token: 0x17005414 RID: 21524
		// (get) Token: 0x06029B6D RID: 170861 RVA: 0x00BC9F47 File Offset: 0x00BC8147
		// (set) Token: 0x06029B6E RID: 170862 RVA: 0x00BC9F4F File Offset: 0x00BC814F
		public UUISliderComponent OptionLimitBar { get; set; }

		// Token: 0x17005415 RID: 21525
		// (get) Token: 0x06029B6F RID: 170863 RVA: 0x00BC9F58 File Offset: 0x00BC8158
		// (set) Token: 0x06029B70 RID: 170864 RVA: 0x00BC9F60 File Offset: 0x00BC8160
		public UUISliderComponent AutoSelectTimeBar { get; set; }

		// Token: 0x17005416 RID: 21526
		// (get) Token: 0x06029B71 RID: 170865 RVA: 0x00BC9F69 File Offset: 0x00BC8169
		// (set) Token: 0x06029B72 RID: 170866 RVA: 0x00BC9F71 File Offset: 0x00BC8171
		public UUIItem ImportantList { get; set; }

		// Token: 0x17005417 RID: 21527
		// (get) Token: 0x06029B73 RID: 170867 RVA: 0x00BC9F7A File Offset: 0x00BC817A
		// (set) Token: 0x06029B74 RID: 170868 RVA: 0x00BC9F82 File Offset: 0x00BC8182
		public UUITexture ImportantOptionTipsIcon { get; set; }

		// Token: 0x17005418 RID: 21528
		// (get) Token: 0x06029B75 RID: 170869 RVA: 0x00BC9F8B File Offset: 0x00BC818B
		// (set) Token: 0x06029B76 RID: 170870 RVA: 0x00BC9F93 File Offset: 0x00BC8193
		public UUIText ImportantOptionTipsText { get; set; }

		// Token: 0x17005419 RID: 21529
		// (get) Token: 0x06029B77 RID: 170871 RVA: 0x00BC9F9C File Offset: 0x00BC819C
		// (set) Token: 0x06029B78 RID: 170872 RVA: 0x00BC9FA4 File Offset: 0x00BC81A4
		public Func<ITalkItem> GetCurrentContentDelegate { get; set; }

		// Token: 0x1700541A RID: 21530
		// (get) Token: 0x06029B79 RID: 170873 RVA: 0x00BC9FAD File Offset: 0x00BC81AD
		// (set) Token: 0x06029B7A RID: 170874 RVA: 0x00BC9FB5 File Offset: 0x00BC81B5
		public Func<PlotOptionItem> GetSelectedOptionDelegate { get; set; }

		// Token: 0x1700541B RID: 21531
		// (get) Token: 0x06029B7B RID: 170875 RVA: 0x00BC9FBE File Offset: 0x00BC81BE
		// (set) Token: 0x06029B7C RID: 170876 RVA: 0x00BC9FC6 File Offset: 0x00BC81C6
		[Nullable(new byte[]
		{
			2,
			2,
			1
		})]
		public Func<PlotOptionItem[]> GetOptionItemsDelegate { [return: Nullable(new byte[]
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

		// Token: 0x1700541C RID: 21532
		// (get) Token: 0x06029B7D RID: 170877 RVA: 0x00BC9FCF File Offset: 0x00BC81CF
		// (set) Token: 0x06029B7E RID: 170878 RVA: 0x00BC9FD7 File Offset: 0x00BC81D7
		public Func<float> GetAudioRemainingTimeDelegate { get; set; }

		// Token: 0x1700541D RID: 21533
		// (get) Token: 0x06029B7F RID: 170879 RVA: 0x00BC9FE0 File Offset: 0x00BC81E0
		// (set) Token: 0x06029B80 RID: 170880 RVA: 0x00BC9FE8 File Offset: 0x00BC81E8
		public Func<float> GetAutoSelectExtraWaitTimeDelegate { get; set; }

		// Token: 0x1700541E RID: 21534
		// (get) Token: 0x06029B81 RID: 170881 RVA: 0x00BC9FF1 File Offset: 0x00BC81F1
		// (set) Token: 0x06029B82 RID: 170882 RVA: 0x00BC9FF9 File Offset: 0x00BC81F9
		public Action<int> SelectOptionByIndexDelegate { get; set; }

		// Token: 0x1700541F RID: 21535
		// (get) Token: 0x06029B83 RID: 170883 RVA: 0x00BCA002 File Offset: 0x00BC8202
		// (set) Token: 0x06029B84 RID: 170884 RVA: 0x00BCA00A File Offset: 0x00BC820A
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<string, UUITexture> SetTextureByPathDelegate { [return: Nullable(new byte[]
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

		// Token: 0x17005420 RID: 21536
		// (get) Token: 0x06029B85 RID: 170885 RVA: 0x00BCA013 File Offset: 0x00BC8213
		// (set) Token: 0x06029B86 RID: 170886 RVA: 0x00BCA01B File Offset: 0x00BC821B
		public Action RefreshAutoPlayButtonDelegate { get; set; }
	}
}
