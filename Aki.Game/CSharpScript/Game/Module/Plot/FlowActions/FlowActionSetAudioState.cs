using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Audio;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050CD RID: 20685
	public class FlowActionSetAudioState : FlowActionBase
	{
		// Token: 0x06034F21 RID: 216865 RVA: 0x00C8A6E0 File Offset: 0x00C888E0
		protected override void OnExecute()
		{
			SetAudioState setAudioState = this.ActionInfo.Params as SetAudioState;
			if (setAudioState == null)
			{
				return;
			}
			GameAudioController.Instance.UpdateAudioStatebyClient(setAudioState.AudioConfig);
		}

		// Token: 0x06034F22 RID: 216866 RVA: 0x00C8A712 File Offset: 0x00C88912
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
