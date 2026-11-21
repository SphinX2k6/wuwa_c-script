using System;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x020064A5 RID: 25765
	public interface IAiTaskMontage
	{
		// Token: 0x1700772B RID: 30507
		// (get) Token: 0x0603E9DC RID: 256476
		// (set) Token: 0x0603E9DD RID: 256477
		bool Playing { get; set; }

		// Token: 0x1700772C RID: 30508
		// (get) Token: 0x0603E9DE RID: 256478
		bool HasResource { get; }

		// Token: 0x0603E9DF RID: 256479
		double GetTimeElapsing();

		// Token: 0x1700772D RID: 30509
		// (get) Token: 0x0603E9E0 RID: 256480
		// (set) Token: 0x0603E9E1 RID: 256481
		float RemainedTrigger { get; set; }

		// Token: 0x0603E9E2 RID: 256482
		double GetTimeLength();

		// Token: 0x0603E9E3 RID: 256483
		double GetTimeRemaining();
	}
}
