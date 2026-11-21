using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200407A RID: 16506
	public class FlowActionBeginFlowTemplate : FlowActionBase
	{
		// Token: 0x06029DA1 RID: 171425 RVA: 0x00BD59C8 File Offset: 0x00BD3BC8
		protected override void OnExecute()
		{
			EPlotLevel? plotLevel = PlotModel.Instance.PlotConfig.PlotLevel;
			if (plotLevel.GetValueOrDefault() == EPlotLevel.LevelD)
			{
				BeginFlowTemplate beginFlowTemplate = this.ActionInfo.Params as BeginFlowTemplate;
				PlotModel.Instance.StartLevelDMouthBinding((beginFlowTemplate != null) ? beginFlowTemplate.Actors : null);
				base.FinishExecute(true, true);
				return;
			}
			if (plotLevel.GetValueOrDefault() != EPlotLevel.LevelC)
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

		// Token: 0x06029DA2 RID: 171426 RVA: 0x00BD5A73 File Offset: 0x00BD3C73
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
