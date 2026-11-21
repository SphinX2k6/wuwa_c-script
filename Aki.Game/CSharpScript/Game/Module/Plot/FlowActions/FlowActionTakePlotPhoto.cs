using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040AC RID: 16556
	public class FlowActionTakePlotPhoto : FlowActionBase
	{
		// Token: 0x06029E61 RID: 171617 RVA: 0x00BD90B0 File Offset: 0x00BD72B0
		protected override void OnExecute()
		{
			if (!(this.ActionInfo.Params is TakePlotPhoto))
			{
				base.FinishExecute(true, true);
				return;
			}
			if (!UiManager.Instance.IsViewShow(EUiViewName.PlotPhotoView))
			{
				UiManager.Instance.OpenView(EUiViewName.PlotPhotoView, new Action(this.OnViewClose), null);
			}
		}

		// Token: 0x06029E62 RID: 171618 RVA: 0x00BD9105 File Offset: 0x00BD7305
		private void OnViewClose()
		{
			base.FinishExecute(true, true);
		}
	}
}
