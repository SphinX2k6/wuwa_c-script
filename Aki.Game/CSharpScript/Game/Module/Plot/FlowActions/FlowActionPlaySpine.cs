using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050CA RID: 20682
	public class FlowActionPlaySpine : FlowActionBase
	{
		// Token: 0x06034F16 RID: 216854 RVA: 0x00C8A3D8 File Offset: 0x00C885D8
		protected override void OnExecute()
		{
			SetSpineAnimation setSpineAnimation = this.ActionInfo.Params as SetSpineAnimation;
			if (setSpineAnimation != null && setSpineAnimation.Config.Type == ESetSpineAnimation.Play)
			{
				EventSystem.Instance.Emit<string, bool>(EEventName.PlayPlotSpine, setSpineAnimation.Config.Name, setSpineAnimation.Config.IsLoop);
			}
		}

		// Token: 0x06034F17 RID: 216855 RVA: 0x00C8A42C File Offset: 0x00C8862C
		protected override void OnBackgroundExecute()
		{
		}
	}
}
