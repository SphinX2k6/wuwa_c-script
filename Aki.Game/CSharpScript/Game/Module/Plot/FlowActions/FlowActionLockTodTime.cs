using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004092 RID: 16530
	public class FlowActionLockTodTime : FlowActionBase
	{
		// Token: 0x06029DEC RID: 171500 RVA: 0x00BD6DDC File Offset: 0x00BD4FDC
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

		// Token: 0x06029DED RID: 171501 RVA: 0x00BD6E34 File Offset: 0x00BD5034
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
			base.FinishExecute(true, true);
		}
	}
}
