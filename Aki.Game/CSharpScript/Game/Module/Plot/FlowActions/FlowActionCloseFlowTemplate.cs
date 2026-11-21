using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004084 RID: 16516
	public class FlowActionCloseFlowTemplate : FlowActionBase
	{
		// Token: 0x06029DBB RID: 171451 RVA: 0x00BD6178 File Offset: 0x00BD4378
		protected override void OnExecute()
		{
			EPlotLevel? plotLevel = PlotModel.Instance.PlotConfig.PlotLevel;
			if (plotLevel.GetValueOrDefault() == EPlotLevel.LevelD)
			{
				PlotModel.Instance.EndLevelDMouthBinding();
				base.FinishExecute(true, true);
				return;
			}
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() != EPlotLevel.LevelC)
			{
				base.FinishExecute(true, true);
				return;
			}
			PlotModel.Instance.EndPlotTemplate(this.ActionInfo.Params as CloseFlowTemplate, delegate
			{
				base.FinishExecute(true, true);
			});
		}

		// Token: 0x06029DBC RID: 171452 RVA: 0x00BD61F8 File Offset: 0x00BD43F8
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
