using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200409A RID: 16538
	public class FlowActionPlaySpine : FlowActionBase
	{
		// Token: 0x06029E0F RID: 171535 RVA: 0x00BD76C0 File Offset: 0x00BD58C0
		protected override void OnExecute()
		{
			SetSpineAnimation setSpineAnimation = this.ActionInfo.Params as SetSpineAnimation;
			if (setSpineAnimation != null && setSpineAnimation.Config.Type == ESetSpineAnimation.Play)
			{
				EventSystem.Instance.Emit<string, bool>(EEventName.PlayPlotSpine, setSpineAnimation.Config.Name, setSpineAnimation.Config.IsLoop);
			}
		}

		// Token: 0x06029E10 RID: 171536 RVA: 0x00BD7714 File Offset: 0x00BD5914
		protected override void OnBackgroundExecute()
		{
		}
	}
}
