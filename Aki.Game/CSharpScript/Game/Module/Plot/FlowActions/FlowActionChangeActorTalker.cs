using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200407C RID: 16508
	public class FlowActionChangeActorTalker : FlowActionBase
	{
		// Token: 0x06029DA8 RID: 171432 RVA: 0x00BD5B44 File Offset: 0x00BD3D44
		protected override void OnExecute()
		{
			ChangeActorTalker changeActorTalker = this.ActionInfo.Params as ChangeActorTalker;
			if (changeActorTalker == null)
			{
				return;
			}
			PlotModel.Instance.SetActorName(changeActorTalker);
		}
	}
}
