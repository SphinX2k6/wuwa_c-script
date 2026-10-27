using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050DC RID: 20700
	public class FlowActionTakePlotPhoto : FlowActionBase
	{
		// Token: 0x06034F68 RID: 216936 RVA: 0x00C8BDC8 File Offset: 0x00C89FC8
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

		// Token: 0x06034F69 RID: 216937 RVA: 0x00C8BE1D File Offset: 0x00C8A01D
		private void OnViewClose()
		{
			base.FinishExecute(true, true);
		}
	}
}
