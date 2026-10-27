using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050DA RID: 20698
	public class FlowActionStopUiScreenEffect : FlowActionBase
	{
		// Token: 0x06034F61 RID: 216929 RVA: 0x00C8BB8C File Offset: 0x00C89D8C
		protected override void OnExecute()
		{
			StopUiScreenEffect stopUiScreenEffect = this.ActionInfo.Params as StopUiScreenEffect;
			ScreenEffectModel.Instance.EndScreenEffectByPath(stopUiScreenEffect.EffectDaPath);
		}
	}
}
