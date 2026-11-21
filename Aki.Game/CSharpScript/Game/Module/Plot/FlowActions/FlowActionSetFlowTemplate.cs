using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040A1 RID: 16545
	public class FlowActionSetFlowTemplate : FlowActionBase
	{
		// Token: 0x06029E27 RID: 171559 RVA: 0x00BD7F58 File Offset: 0x00BD6158
		protected override void OnExecute()
		{
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() != EPlotLevel.LevelC)
			{
				base.FinishExecute(true, true);
				return;
			}
			PlotModel.Instance.SetPlotTemplate(this.ActionInfo.Params as SetFlowTemplate, delegate
			{
				base.FinishExecute(true, true);
			});
		}

		// Token: 0x06029E28 RID: 171560 RVA: 0x00BD7FAB File Offset: 0x00BD61AB
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
