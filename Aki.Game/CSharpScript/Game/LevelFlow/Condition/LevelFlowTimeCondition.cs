using System;

namespace CSharpScript.Game.LevelFlow.Condition
{
	// Token: 0x020060F9 RID: 24825
	public class LevelFlowTimeCondition : LevelFlowConditionBase
	{
		// Token: 0x0603B852 RID: 243794 RVA: 0x010DEC1A File Offset: 0x010DCE1A
		public void Init(float waitTime)
		{
			this.WaitTime = waitTime;
			this.CurrentTime = 0f;
		}

		// Token: 0x0603B853 RID: 243795 RVA: 0x010DEC2E File Offset: 0x010DCE2E
		protected override void OnTick(float delta)
		{
			this.CurrentTime += delta;
			if (this.CurrentTime >= this.WaitTime)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0401F647 RID: 128583
		private float WaitTime;

		// Token: 0x0401F648 RID: 128584
		private float CurrentTime;
	}
}
