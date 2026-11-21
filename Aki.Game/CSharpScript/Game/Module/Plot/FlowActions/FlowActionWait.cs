using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040AE RID: 16558
	public class FlowActionWait : FlowActionBase
	{
		// Token: 0x06029E66 RID: 171622 RVA: 0x00BD922C File Offset: 0x00BD742C
		protected override void OnExecute()
		{
			Wait wait = this.ActionInfo.Params as Wait;
			this.TimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float id)
			{
				this.TimerId = null;
				base.FinishExecute(true, true);
			}, wait.Time * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		}

		// Token: 0x06029E67 RID: 171623 RVA: 0x00BD9280 File Offset: 0x00BD7480
		protected override void OnInterruptExecute()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
			base.FinishExecute(true, true);
		}

		// Token: 0x04016D49 RID: 93513
		[Nullable(2)]
		private TimerHandle TimerId;
	}
}
