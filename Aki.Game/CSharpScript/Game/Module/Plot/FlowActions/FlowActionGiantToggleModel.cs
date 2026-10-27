using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Giant;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050BB RID: 20667
	public class FlowActionGiantToggleModel : FlowActionBase
	{
		// Token: 0x06034EDC RID: 216796 RVA: 0x00C89754 File Offset: 0x00C87954
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

		// Token: 0x06034EDD RID: 216797 RVA: 0x00C89798 File Offset: 0x00C87998
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
