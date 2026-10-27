using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050B4 RID: 20660
	public class FlowActionCloseFlowTemplate : FlowActionBase
	{
		// Token: 0x06034EC2 RID: 216770 RVA: 0x00C88EBC File Offset: 0x00C870BC
		protected override void OnExecute()
		{
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

		// Token: 0x06034EC3 RID: 216771 RVA: 0x00C88F0F File Offset: 0x00C8710F
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
