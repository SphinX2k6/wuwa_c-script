using System;

namespace CSharpScript.Game.NewWorld.Character.Npc.Logics
{
	// Token: 0x02007095 RID: 28821
	public class PlayMontageConfig
	{
		// Token: 0x060463BF RID: 287679 RVA: 0x01192AE4 File Offset: 0x01190CE4
		public PlayMontageConfig(int times = 0, double duration = 0.0, bool playLoop = false, bool infinite = false)
		{
			this.RepeatTimes = times;
			this.LoopDuration = duration;
			this.IsPlayLoop = (playLoop || this.LoopDuration != 0.0);
			this.IsInfiniteLoop = (infinite || this.LoopDuration < 0.0 || this.RepeatTimes < 0);
		}

		// Token: 0x060463C0 RID: 287680 RVA: 0x01192B4C File Offset: 0x01190D4C
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

		// Token: 0x04024CC8 RID: 150728
		private const int SECOND_TO_MILLISECOND = 1000;

		// Token: 0x04024CC9 RID: 150729
		public double PlayMontageTime;

		// Token: 0x04024CCA RID: 150730
		public double OncePlayTime;

		// Token: 0x04024CCB RID: 150731
		public bool IsInfiniteLoop;

		// Token: 0x04024CCC RID: 150732
		public bool IsPlayLoop;

		// Token: 0x04024CCD RID: 150733
		private readonly double LoopDuration;

		// Token: 0x04024CCE RID: 150734
		private readonly int RepeatTimes;
	}
}
