using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050D1 RID: 20689
	public class FlowActionSetFlowTemplate : FlowActionBase
	{
		// Token: 0x06034F2E RID: 216878 RVA: 0x00C8AC70 File Offset: 0x00C88E70
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

		// Token: 0x06034F2F RID: 216879 RVA: 0x00C8ACC3 File Offset: 0x00C88EC3
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
