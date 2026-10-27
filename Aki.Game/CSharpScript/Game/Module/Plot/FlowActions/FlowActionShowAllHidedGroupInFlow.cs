using System;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050D7 RID: 20695
	public class FlowActionShowAllHidedGroupInFlow : FlowActionBase
	{
		// Token: 0x06034F54 RID: 216916 RVA: 0x00C8B8A0 File Offset: 0x00C89AA0
		protected override void OnExecute()
		{
			PlotModel.Instance.PlotCleanRange.Close();
		}

		// Token: 0x06034F55 RID: 216917 RVA: 0x00C8B8B1 File Offset: 0x00C89AB1
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
