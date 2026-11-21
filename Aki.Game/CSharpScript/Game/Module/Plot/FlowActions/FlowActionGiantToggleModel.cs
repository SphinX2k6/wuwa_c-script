using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Giant;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200408B RID: 16523
	public class FlowActionGiantToggleModel : FlowActionBase
	{
		// Token: 0x06029DD5 RID: 171477 RVA: 0x00BD6A3C File Offset: 0x00BD4C3C
		protected override void OnExecute()
		{
			GiantToggleModel giantToggleModel = this.ActionInfo.Params as GiantToggleModel;
			if (giantToggleModel == null)
			{
				base.FinishExecute(false, true);
				return;
			}
			GiantController.Instance.SetBodyVisible(giantToggleModel.IsEnabled);
			base.FinishExecute(true, true);
		}

		// Token: 0x06029DD6 RID: 171478 RVA: 0x00BD6A80 File Offset: 0x00BD4C80
		protected override void OnBackgroundExecute()
		{
			GiantToggleModel giantToggleModel = this.ActionInfo.Params as GiantToggleModel;
			if (giantToggleModel == null)
			{
				base.FinishExecute(true, true);
				return;
			}
			GiantController.Instance.SetBodyVisible(giantToggleModel.IsEnabled);
			base.FinishExecute(true, true);
		}
	}
}
