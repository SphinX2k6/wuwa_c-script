using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005089 RID: 20617
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotOptionComponent
	{
		// Token: 0x06034D10 RID: 216336 RVA: 0x00C7DE88 File Offset: 0x00C7C088
		public void Init(PlotOptionComponentContext context)
		{
			this.OptionsRefreshDelegate = context.OptionsRefreshDelegate;
			this.OptionsShowDelegate = context.OptionsShowDelegate;
			this.OptionsHideDelegate = context.OptionsHideDelegate;
		}

		// Token: 0x06034D11 RID: 216337 RVA: 0x00C7DEAE File Offset: 0x00C7C0AE
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

		// Token: 0x06034D12 RID: 216338 RVA: 0x00C7DECD File Offset: 0x00C7C0CD
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

		// Token: 0x06034D13 RID: 216339 RVA: 0x00C7DEF0 File Offset: 0x00C7C0F0
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

		// Token: 0x06034D14 RID: 216340 RVA: 0x00C7DF14 File Offset: 0x00C7C114
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

		// Token: 0x0401C236 RID: 115254
		private bool IsVisible;

		// Token: 0x0401C237 RID: 115255
		protected List<ITalkOption> Options = new List<ITalkOption>();

		// Token: 0x0401C238 RID: 115256
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<ITalkOption[]> OptionsRefreshDelegate;

		// Token: 0x0401C239 RID: 115257
		[Nullable(2)]
		private Action OptionsShowDelegate;

		// Token: 0x0401C23A RID: 115258
		[Nullable(2)]
		private Action OptionsHideDelegate;
	}
}
