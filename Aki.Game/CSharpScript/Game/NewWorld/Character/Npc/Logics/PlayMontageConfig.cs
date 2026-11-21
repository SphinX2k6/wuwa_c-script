using System;

namespace CSharpScript.Game.NewWorld.Character.Npc.Logics
{
	// Token: 0x020062FA RID: 25338
	public class PlayMontageConfig
	{
		// Token: 0x0603D4AA RID: 251050 RVA: 0x011B5BF0 File Offset: 0x011B3DF0
		public PlayMontageConfig(int times = 0, double duration = 0.0, bool playLoop = false, bool infinite = false)
		{
			this.RepeatTimes = times;
			this.LoopDuration = duration;
			this.IsPlayLoop = (playLoop || this.LoopDuration != 0.0);
			this.IsInfiniteLoop = (infinite || this.LoopDuration < 0.0 || this.RepeatTimes < 0);
		}

		// Token: 0x0603D4AB RID: 251051 RVA: 0x011B5C58 File Offset: 0x011B3E58
		public void CalculatePlayTime(double onceTime)
		{
			this.OncePlayTime = onceTime;
			this.PlayMontageTime = ((this.LoopDuration != 0.0 && this.LoopDuration > 0.0) ? (this.LoopDuration * 1000.0) : ((this.RepeatTimes != 0 && this.RepeatTimes > 0) ? ((double)this.RepeatTimes * onceTime) : onceTime));
			if (!this.IsInfiniteLoop)
			{
				if (this.PlayMontageTime < 20.0)
				{
					this.PlayMontageTime = Math.Max(onceTime, 20.0);
				}
				if (this.PlayMontageTime > 180000.0)
				{
					this.IsInfiniteLoop = true;
				}
			}
		}

		// Token: 0x0402081A RID: 133146
		private const int SECOND_TO_MILLISECOND = 1000;

		// Token: 0x0402081B RID: 133147
		public double PlayMontageTime;

		// Token: 0x0402081C RID: 133148
		public double OncePlayTime;

		// Token: 0x0402081D RID: 133149
		public bool IsInfiniteLoop;

		// Token: 0x0402081E RID: 133150
		public bool IsPlayLoop;

		// Token: 0x0402081F RID: 133151
		private readonly double LoopDuration;

		// Token: 0x04020820 RID: 133152
		private readonly int RepeatTimes;
	}
}
