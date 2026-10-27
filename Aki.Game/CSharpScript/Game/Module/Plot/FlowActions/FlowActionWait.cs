using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050DE RID: 20702
	public class FlowActionWait : FlowActionBase
	{
		// Token: 0x06034F6D RID: 216941 RVA: 0x00C8BF44 File Offset: 0x00C8A144
		protected override void OnExecute()
		{
			Wait wait = this.ActionInfo.Params as Wait;
			this.TimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float id)
			{
				this.TimerId = null;
				base.FinishExecute(true, true);
			}, wait.Time * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		}

		// Token: 0x06034F6E RID: 216942 RVA: 0x00C8BF98 File Offset: 0x00C8A198
		protected override void OnInterruptExecute()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
			base.FinishExecute(true, true);
		}

		// Token: 0x0401C318 RID: 115480
		[Nullable(2)]
		private TimerHandle TimerId;
	}
}
