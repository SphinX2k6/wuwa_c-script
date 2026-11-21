using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040AA RID: 16554
	public class FlowActionStopUiScreenEffect : FlowActionBase
	{
		// Token: 0x06029E5A RID: 171610 RVA: 0x00BD8E74 File Offset: 0x00BD7074
		protected override void OnExecute()
		{
			StopUiScreenEffect stopUiScreenEffect = this.ActionInfo.Params as StopUiScreenEffect;
			ScreenEffectModel.Instance.EndScreenEffectByPath(stopUiScreenEffect.EffectDaPath);
		}
	}
}
