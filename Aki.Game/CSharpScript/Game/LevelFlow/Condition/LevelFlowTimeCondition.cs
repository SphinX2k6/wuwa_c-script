using System;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x02006F78 RID: 28536
	public class LevelFlowTimeCondition : LevelFlowConditionBase
	{
		// Token: 0x060456A4 RID: 284324 RVA: 0x01134E16 File Offset: 0x01133016
		public void Init(float waitTime)
		{
			this.WaitTime = waitTime;
			this.CurrentTime = 0f;
		}

		// Token: 0x060456A5 RID: 284325 RVA: 0x01134E2A File Offset: 0x0113302A
		protected override void OnTick(float delta)
		{
			this.CurrentTime += delta;
			if (this.CurrentTime >= this.WaitTime)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x04024392 RID: 148370
		private float WaitTime;

		// Token: 0x04024393 RID: 148371
		private float CurrentTime;
	}
}
