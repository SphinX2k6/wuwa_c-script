using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050AC RID: 20652
	public class FlowActionChangeActorTalker : FlowActionBase
	{
		// Token: 0x06034EAF RID: 216751 RVA: 0x00C88888 File Offset: 0x00C86A88
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
