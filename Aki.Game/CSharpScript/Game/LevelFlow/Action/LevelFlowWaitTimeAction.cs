using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200612F RID: 24879
	public class LevelFlowWaitTimeAction : LevelFlowActionBase
	{
		// Token: 0x0603B96B RID: 244075 RVA: 0x010E68E2 File Offset: 0x010E4AE2
		[NullableContext(1)]
		public LevelFlowWaitTimeAction Init(float waitTime)
		{
			this.WaitTime = waitTime * (float)TimeUtil.Instance.InverseMillisecond;
			return this;
		}

		// Token: 0x0603B96C RID: 244076 RVA: 0x010E68F8 File Offset: 0x010E4AF8
		protected override void OnExecute()
		{
			this.CurrentTime = 0f;
		}

		// Token: 0x0603B96D RID: 244077 RVA: 0x010E6905 File Offset: 0x010E4B05
		protected override void OnTick(float delta)
		{
			this.CurrentTime += delta;
			if (this.CurrentTime >= this.WaitTime)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0401F6C5 RID: 128709
		private float WaitTime;

		// Token: 0x0401F6C6 RID: 128710
		private float CurrentTime;
	}
}
