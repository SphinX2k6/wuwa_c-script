using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004083 RID: 16515
	public class FlowActionChangeTrapDefenseMiniMap : FlowActionBase
	{
		// Token: 0x06029DB9 RID: 171449 RVA: 0x00BD6140 File Offset: 0x00BD4340
		protected override void OnExecute()
		{
			TrapDefenseChangeMiniMap trapDefenseChangeMiniMap = this.ActionInfo.Params as TrapDefenseChangeMiniMap;
			TrapDefenseController.Instance.ChangeMap(trapDefenseChangeMiniMap.MiniMapId);
		}
	}
}
