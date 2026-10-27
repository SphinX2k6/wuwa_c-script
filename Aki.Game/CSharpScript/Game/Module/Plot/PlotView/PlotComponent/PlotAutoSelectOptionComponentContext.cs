using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005079 RID: 20601
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAutoSelectOptionComponentContext : IPlotAutoSelectOptionComponentContext
	{
		// Token: 0x17008054 RID: 32852
		// (get) Token: 0x06034C78 RID: 216184 RVA: 0x00C7CB6F File Offset: 0x00C7AD6F
		// (set) Token: 0x06034C79 RID: 216185 RVA: 0x00C7CB77 File Offset: 0x00C7AD77
		public UUISliderComponent OptionLimitBar { get; set; }

		// Token: 0x17008055 RID: 32853
		// (get) Token: 0x06034C7A RID: 216186 RVA: 0x00C7CB80 File Offset: 0x00C7AD80
		// (set) Token: 0x06034C7B RID: 216187 RVA: 0x00C7CB88 File Offset: 0x00C7AD88
		public UUISliderComponent AutoSelectTimeBar { get; set; }

		// Token: 0x17008056 RID: 32854
		// (get) Token: 0x06034C7C RID: 216188 RVA: 0x00C7CB91 File Offset: 0x00C7AD91
		// (set) Token: 0x06034C7D RID: 216189 RVA: 0x00C7CB99 File Offset: 0x00C7AD99
		public UUIItem ImportantList { get; set; }

		// Token: 0x17008057 RID: 32855
		// (get) Token: 0x06034C7E RID: 216190 RVA: 0x00C7CBA2 File Offset: 0x00C7ADA2
		// (set) Token: 0x06034C7F RID: 216191 RVA: 0x00C7CBAA File Offset: 0x00C7ADAA
		public UUITexture ImportantOptionTipsIcon { get; set; }

		// Token: 0x17008058 RID: 32856
		// (get) Token: 0x06034C80 RID: 216192 RVA: 0x00C7CBB3 File Offset: 0x00C7ADB3
		// (set) Token: 0x06034C81 RID: 216193 RVA: 0x00C7CBBB File Offset: 0x00C7ADBB
		public UUIText ImportantOptionTipsText { get; set; }

		// Token: 0x17008059 RID: 32857
		// (get) Token: 0x06034C82 RID: 216194 RVA: 0x00C7CBC4 File Offset: 0x00C7ADC4
		// (set) Token: 0x06034C83 RID: 216195 RVA: 0x00C7CBCC File Offset: 0x00C7ADCC
		public Func<ITalkItem> GetCurrentContentDelegate { get; set; }

		// Token: 0x1700805A RID: 32858
		// (get) Token: 0x06034C84 RID: 216196 RVA: 0x00C7CBD5 File Offset: 0x00C7ADD5
		// (set) Token: 0x06034C85 RID: 216197 RVA: 0x00C7CBDD File Offset: 0x00C7ADDD
		public Func<PlotOptionItem> GetSelectedOptionDelegate { get; set; }

		// Token: 0x1700805B RID: 32859
		// (get) Token: 0x06034C86 RID: 216198 RVA: 0x00C7CBE6 File Offset: 0x00C7ADE6
		// (set) Token: 0x06034C87 RID: 216199 RVA: 0x00C7CBEE File Offset: 0x00C7ADEE
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

		// Token: 0x1700805C RID: 32860
		// (get) Token: 0x06034C88 RID: 216200 RVA: 0x00C7CBF7 File Offset: 0x00C7ADF7
		// (set) Token: 0x06034C89 RID: 216201 RVA: 0x00C7CBFF File Offset: 0x00C7ADFF
		public Func<float> GetAudioRemainingTimeDelegate { get; set; }

		// Token: 0x1700805D RID: 32861
		// (get) Token: 0x06034C8A RID: 216202 RVA: 0x00C7CC08 File Offset: 0x00C7AE08
		// (set) Token: 0x06034C8B RID: 216203 RVA: 0x00C7CC10 File Offset: 0x00C7AE10
		public Func<float> GetAutoSelectExtraWaitTimeDelegate { get; set; }

		// Token: 0x1700805E RID: 32862
		// (get) Token: 0x06034C8C RID: 216204 RVA: 0x00C7CC19 File Offset: 0x00C7AE19
		// (set) Token: 0x06034C8D RID: 216205 RVA: 0x00C7CC21 File Offset: 0x00C7AE21
		public Action<int> SelectOptionByIndexDelegate { get; set; }

		// Token: 0x1700805F RID: 32863
		// (get) Token: 0x06034C8E RID: 216206 RVA: 0x00C7CC2A File Offset: 0x00C7AE2A
		// (set) Token: 0x06034C8F RID: 216207 RVA: 0x00C7CC32 File Offset: 0x00C7AE32
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

		// Token: 0x17008060 RID: 32864
		// (get) Token: 0x06034C90 RID: 216208 RVA: 0x00C7CC3B File Offset: 0x00C7AE3B
		// (set) Token: 0x06034C91 RID: 216209 RVA: 0x00C7CC43 File Offset: 0x00C7AE43
		public Action RefreshAutoPlayButtonDelegate { get; set; }
	}
}
