using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050D2 RID: 20690
	public class FlowActionSetHeadIconVisible : FlowActionBase
	{
		// Token: 0x06034F32 RID: 216882 RVA: 0x00C8ACE0 File Offset: 0x00C88EE0
		protected override void OnExecute()
		{
			SetHeadIconVisible config = this.ActionInfo.Params as SetHeadIconVisible;
			this.Active = true;
			PlotController.Instance.PlotViewManager.UpdatePortraitVisible(config, new Action(this.OnFinishSet));
		}

		// Token: 0x06034F33 RID: 216883 RVA: 0x00C8AD21 File Offset: 0x00C88F21
		private void OnFinishSet()
		{
			if (this == null || !this.Active)
			{
				return;
			}
			this.Active = false;
			base.FinishExecute(true, true);
		}

		// Token: 0x06034F34 RID: 216884 RVA: 0x00C8AD44 File Offset: 0x00C88F44
		protected override void OnInterruptExecute()
		{
			this.Active = false;
			base.FinishExecute(true, true);
		}

		// Token: 0x0401C30D RID: 115469
		private bool Active;
	}
}
