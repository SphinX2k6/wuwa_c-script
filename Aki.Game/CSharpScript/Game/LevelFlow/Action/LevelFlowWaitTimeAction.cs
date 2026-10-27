using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FAE RID: 28590
	public class LevelFlowWaitTimeAction : LevelFlowActionBase
	{
		// Token: 0x060457BC RID: 284604 RVA: 0x0113CA7E File Offset: 0x0113AC7E
		[NullableContext(1)]
		public LevelFlowWaitTimeAction Init(float waitTime)
		{
			this.WaitTime = waitTime * (float)TimeUtil.Instance.InverseMillisecond;
			return this;
		}

		// Token: 0x060457BD RID: 284605 RVA: 0x0113CA94 File Offset: 0x0113AC94
		protected override void OnExecute()
		{
			this.CurrentTime = 0f;
		}

		// Token: 0x060457BE RID: 284606 RVA: 0x0113CAA1 File Offset: 0x0113ACA1
		protected override void OnTick(float delta)
		{
			this.CurrentTime += delta;
			if (this.CurrentTime >= this.WaitTime)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x04024410 RID: 148496
		private float WaitTime;

		// Token: 0x04024411 RID: 148497
		private float CurrentTime;
	}
}
