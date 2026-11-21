using System;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040A7 RID: 16551
	public class FlowActionShowAllHidedGroupInFlow : FlowActionBase
	{
		// Token: 0x06029E4D RID: 171597 RVA: 0x00BD8B88 File Offset: 0x00BD6D88
		protected override void OnExecute()
		{
			PlotModel.Instance.PlotCleanRange.Close();
		}

		// Token: 0x06029E4E RID: 171598 RVA: 0x00BD8B99 File Offset: 0x00BD6D99
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
