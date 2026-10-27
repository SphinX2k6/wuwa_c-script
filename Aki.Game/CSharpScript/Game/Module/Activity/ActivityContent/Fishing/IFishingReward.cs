using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065F9 RID: 26105
	public interface IFishingReward
	{
		// Token: 0x170095CC RID: 38348
		// (get) Token: 0x060416EC RID: 268012
		// (set) Token: 0x060416ED RID: 268013
		int Id { get; set; }

		// Token: 0x170095CD RID: 38349
		// (get) Token: 0x060416EE RID: 268014
		// (set) Token: 0x060416EF RID: 268015
		int Current { get; set; }

		// Token: 0x170095CE RID: 38350
		// (get) Token: 0x060416F0 RID: 268016
		// (set) Token: 0x060416F1 RID: 268017
		int Target { get; set; }

		// Token: 0x170095CF RID: 38351
		// (get) Token: 0x060416F2 RID: 268018
		// (set) Token: 0x060416F3 RID: 268019
		bool IsFinished { get; set; }

		// Token: 0x170095D0 RID: 38352
		// (get) Token: 0x060416F4 RID: 268020
		// (set) Token: 0x060416F5 RID: 268021
		bool IsTaken { get; set; }
	}
}
