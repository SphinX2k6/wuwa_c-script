using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200408D RID: 16525
	public class FlowActionHideByRangeInFlow : FlowActionBase
	{
		// Token: 0x06029DDB RID: 171483 RVA: 0x00BD6B74 File Offset: 0x00BD4D74
		protected override void OnExecute()
		{
			HideByRangeInFlow param = this.ActionInfo.Params as HideByRangeInFlow;
			PlotModel.Instance.PlotCleanRange.Open(param);
		}

		// Token: 0x06029DDC RID: 171484 RVA: 0x00BD6BA2 File Offset: 0x00BD4DA2
		protected override void OnBackgroundExecute()
		{
		}
	}
}
