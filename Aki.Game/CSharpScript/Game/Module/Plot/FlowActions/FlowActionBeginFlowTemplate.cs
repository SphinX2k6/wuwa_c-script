using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050AA RID: 20650
	public class FlowActionBeginFlowTemplate : FlowActionBase
	{
		// Token: 0x06034EA8 RID: 216744 RVA: 0x00C88748 File Offset: 0x00C86948
		protected override void OnExecute()
		{
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() != EPlotLevel.LevelC)
			{
				base.FinishExecute(true, true);
				return;
			}
			if (PlotModel.Instance.IsInTemplate())
			{
				base.FinishExecute(true, true);
				return;
			}
			PlotModel.Instance.StartPlotTemplate(this.ActionInfo.Params as BeginFlowTemplate, this.Context, delegate
			{
				base.FinishExecute(true, true);
			});
		}

		// Token: 0x06034EA9 RID: 216745 RVA: 0x00C887B6 File Offset: 0x00C869B6
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
