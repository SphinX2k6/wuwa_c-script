using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006ECA RID: 28362
	[NullableContext(2)]
	[Nullable(0)]
	public class EndlessAudioStateInfo
	{
		// Token: 0x060450E5 RID: 282853 RVA: 0x0110F0AC File Offset: 0x0110D2AC
		[NullableContext(1)]
		public EndlessAudioStateInfo(float duration, IDollGrabStageAudioState audioState)
		{
			this.Duration = duration;
			this.AudioState = audioState;
		}

		// Token: 0x060450E6 RID: 282854 RVA: 0x0110F0C4 File Offset: 0x0110D2C4
		public void StartAudio()
		{
			if (this.Duration != 0f)
			{
				this.AudioTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					AudioSystem.Instance.SetState(this.AudioState.Group, this.AudioState.State, true);
					this.AudioTimerHandle = null;
				}, this.Duration * 1000f, null, null, true, 1f);
				return;
			}
			AudioSystem.Instance.SetState(this.AudioState.Group, this.AudioState.State, true);
		}

		// Token: 0x060450E7 RID: 282855 RVA: 0x0110F130 File Offset: 0x0110D330
		public void StopAudio()
		{
			if (this.AudioTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.AudioTimerHandle);
				this.AudioTimerHandle = null;
			}
		}

		// Token: 0x060450E8 RID: 282856 RVA: 0x0110F152 File Offset: 0x0110D352
		public void PauseAudio()
		{
			if (this.AudioTimerHandle != null)
			{
				TimerSystem.Instance.Pause(this.AudioTimerHandle, null);
			}
		}

		// Token: 0x060450E9 RID: 282857 RVA: 0x0110F16E File Offset: 0x0110D36E
		public void ResumeAudio()
		{
			if (this.AudioTimerHandle != null)
			{
				TimerSystem.Instance.Resume(this.AudioTimerHandle);
			}
		}

		// Token: 0x04023F65 RID: 147301
		public float Duration;

		// Token: 0x04023F66 RID: 147302
		public IDollGrabStageAudioState AudioState;

		// Token: 0x04023F67 RID: 147303
		public TimerHandle AudioTimerHandle;
	}
}
