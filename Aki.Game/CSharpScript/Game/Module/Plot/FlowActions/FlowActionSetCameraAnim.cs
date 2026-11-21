using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200409E RID: 16542
	public class FlowActionSetCameraAnim : FlowActionBase
	{
		// Token: 0x06029E1D RID: 171549 RVA: 0x00BD7A0A File Offset: 0x00BD5C0A
		protected override void OnExecute()
		{
			PlotModel.Instance.PlayCameraAnim(this.ActionInfo.Params as SetCameraAnim);
		}
	}
}
