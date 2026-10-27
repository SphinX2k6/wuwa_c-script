using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050CE RID: 20686
	public class FlowActionSetCameraAnim : FlowActionBase
	{
		// Token: 0x06034F24 RID: 216868 RVA: 0x00C8A722 File Offset: 0x00C88922
		protected override void OnExecute()
		{
			PlotModel.Instance.PlayCameraAnim(this.ActionInfo.Params as SetCameraAnim);
		}
	}
}
