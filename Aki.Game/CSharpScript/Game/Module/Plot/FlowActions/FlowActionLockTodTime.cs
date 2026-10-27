using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C2 RID: 20674
	public class FlowActionLockTodTime : FlowActionBase
	{
		// Token: 0x06034EF3 RID: 216819 RVA: 0x00C89AF4 File Offset: 0x00C87CF4
		protected override void OnExecute()
		{
			SetTimeLockState setTimeLockState = this.ActionInfo.Params as SetTimeLockState;
			if (setTimeLockState == null)
			{
				base.FinishExecute(false, true);
				return;
			}
			ELockState lockState = setTimeLockState.LockState;
			if (lockState == ELockState.Lock)
			{
				PlotModel.Instance.PlotTimeOfDay.PauseTime();
				return;
			}
			if (lockState != ELockState.Unlock)
			{
				return;
			}
			PlotModel.Instance.PlotTimeOfDay.ResumeTime();
		}

		// Token: 0x06034EF4 RID: 216820 RVA: 0x00C89B4C File Offset: 0x00C87D4C
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
			base.FinishExecute(true, true);
		}
	}
}
