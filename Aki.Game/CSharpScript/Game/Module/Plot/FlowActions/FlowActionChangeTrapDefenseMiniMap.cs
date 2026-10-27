using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050B3 RID: 20659
	public class FlowActionChangeTrapDefenseMiniMap : FlowActionBase
	{
		// Token: 0x06034EC0 RID: 216768 RVA: 0x00C88E84 File Offset: 0x00C87084
		protected override void OnExecute()
		{
			TrapDefenseChangeMiniMap trapDefenseChangeMiniMap = this.ActionInfo.Params as TrapDefenseChangeMiniMap;
			TrapDefenseController.Instance.ChangeMap(trapDefenseChangeMiniMap.MiniMapId);
		}
	}
}
