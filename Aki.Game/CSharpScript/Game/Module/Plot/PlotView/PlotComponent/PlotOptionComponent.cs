using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004059 RID: 16473
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotOptionComponent
	{
		// Token: 0x06029C05 RID: 171013 RVA: 0x00BCB260 File Offset: 0x00BC9460
		public void Init(PlotOptionComponentContext context)
		{
			this.OptionsRefreshDelegate = context.OptionsRefreshDelegate;
			this.OptionsShowDelegate = context.OptionsShowDelegate;
			this.OptionsHideDelegate = context.OptionsHideDelegate;
		}

		// Token: 0x06029C06 RID: 171014 RVA: 0x00BCB286 File Offset: 0x00BC9486
		public void RefreshOptions(ITalkOption[] options)
		{
			this.Options = new List<ITalkOption>(options);
			Action<ITalkOption[]> optionsRefreshDelegate = this.OptionsRefreshDelegate;
			if (optionsRefreshDelegate == null)
			{
				return;
			}
			optionsRefreshDelegate(options);
		}

		// Token: 0x06029C07 RID: 171015 RVA: 0x00BCB2A5 File Offset: 0x00BC94A5
		public void ShowOptions()
		{
			if (this.IsVisible)
			{
				return;
			}
			Action optionsShowDelegate = this.OptionsShowDelegate;
			if (optionsShowDelegate != null)
			{
				optionsShowDelegate();
			}
			this.IsVisible = true;
		}

		// Token: 0x06029C08 RID: 171016 RVA: 0x00BCB2C8 File Offset: 0x00BC94C8
		public void HideOptions()
		{
			if (!this.IsVisible)
			{
				return;
			}
			Action optionsHideDelegate = this.OptionsHideDelegate;
			if (optionsHideDelegate != null)
			{
				optionsHideDelegate();
			}
			this.IsVisible = false;
		}

		// Token: 0x06029C09 RID: 171017 RVA: 0x00BCB2EC File Offset: 0x00BC94EC
		public void SelectOption(int optionIndex)
		{
			List<ITalkOption> options = this.Options;
			if (optionIndex >= options.Count)
			{
				return;
			}
			ITalkOption talkOption;
			if (!options.TryGetValue(optionIndex, out talkOption))
			{
				return;
			}
			FlowController.Instance.FlowShowTalk.SelectOption(optionIndex, talkOption.Actions);
		}

		// Token: 0x04016C61 RID: 93281
		private bool IsVisible;

		// Token: 0x04016C62 RID: 93282
		protected List<ITalkOption> Options = new List<ITalkOption>();

		// Token: 0x04016C63 RID: 93283
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<ITalkOption[]> OptionsRefreshDelegate;

		// Token: 0x04016C64 RID: 93284
		[Nullable(2)]
		private Action OptionsShowDelegate;

		// Token: 0x04016C65 RID: 93285
		[Nullable(2)]
		private Action OptionsHideDelegate;
	}
}
