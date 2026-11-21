using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040A2 RID: 16546
	public class FlowActionSetHeadIconVisible : FlowActionBase
	{
		// Token: 0x06029E2B RID: 171563 RVA: 0x00BD7FC8 File Offset: 0x00BD61C8
		protected override void OnExecute()
		{
			SetHeadIconVisible config = this.ActionInfo.Params as SetHeadIconVisible;
			this.Active = true;
			PlotController.Instance.PlotViewManager.UpdatePortraitVisible(config, new Action(this.OnFinishSet));
		}

		// Token: 0x06029E2C RID: 171564 RVA: 0x00BD8009 File Offset: 0x00BD6209
		private void OnFinishSet()
		{
			if (this == null || !this.Active)
			{
				return;
			}
			this.Active = false;
			base.FinishExecute(true, true);
		}

		// Token: 0x06029E2D RID: 171565 RVA: 0x00BD802C File Offset: 0x00BD622C
		protected override void OnInterruptExecute()
		{
			this.Active = false;
			base.FinishExecute(true, true);
		}

		// Token: 0x04016D3E RID: 93502
		private bool Active;
	}
}
