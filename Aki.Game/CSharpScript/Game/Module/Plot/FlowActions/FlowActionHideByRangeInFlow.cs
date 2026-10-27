using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050BD RID: 20669
	public class FlowActionHideByRangeInFlow : FlowActionBase
	{
		// Token: 0x06034EE2 RID: 216802 RVA: 0x00C8988C File Offset: 0x00C87A8C
		protected override void OnExecute()
		{
			HideByRangeInFlow param = this.ActionInfo.Params as HideByRangeInFlow;
			PlotModel.Instance.PlotCleanRange.Open(param);
		}

		// Token: 0x06034EE3 RID: 216803 RVA: 0x00C898BA File Offset: 0x00C87ABA
		protected override void OnBackgroundExecute()
		{
		}
	}
}
