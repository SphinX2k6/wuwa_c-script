using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Audio;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x0200409D RID: 16541
	public class FlowActionSetAudioState : FlowActionBase
	{
		// Token: 0x06029E1A RID: 171546 RVA: 0x00BD79C8 File Offset: 0x00BD5BC8
		protected override void OnExecute()
		{
			SetAudioState setAudioState = this.ActionInfo.Params as SetAudioState;
			if (setAudioState == null)
			{
				return;
			}
			GameAudioController.Instance.UpdateAudioStatebyClient(setAudioState.AudioConfig);
		}

		// Token: 0x06029E1B RID: 171547 RVA: 0x00BD79FA File Offset: 0x00BD5BFA
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
