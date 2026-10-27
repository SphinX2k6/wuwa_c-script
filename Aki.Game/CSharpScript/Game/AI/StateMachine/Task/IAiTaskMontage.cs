using System;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x02007322 RID: 29474
	public interface IAiTaskMontage
	{
		// Token: 0x17009F8D RID: 40845
		// (get) Token: 0x0604858F RID: 296335
		// (set) Token: 0x06048590 RID: 296336
		bool Playing { get; set; }

		// Token: 0x17009F8E RID: 40846
		// (get) Token: 0x06048591 RID: 296337
		bool HasResource { get; }

		// Token: 0x06048592 RID: 296338
		double GetTimeElapsing();

		// Token: 0x17009F8F RID: 40847
		// (get) Token: 0x06048593 RID: 296339
		// (set) Token: 0x06048594 RID: 296340
		float RemainedTrigger { get; set; }

		// Token: 0x06048595 RID: 296341
		double GetTimeLength();

		// Token: 0x06048596 RID: 296342
		double GetTimeRemaining();
	}
}
