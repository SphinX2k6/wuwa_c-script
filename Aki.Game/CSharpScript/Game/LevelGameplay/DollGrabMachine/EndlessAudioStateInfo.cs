using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x0200604A RID: 24650
	[NullableContext(2)]
	[Nullable(0)]
	public class EndlessAudioStateInfo
	{
		// Token: 0x0603B286 RID: 242310 RVA: 0x010B9188 File Offset: 0x010B7388
		[NullableContext(1)]
		public EndlessAudioStateInfo(float duration, IDollGrabStageAudioState audioState)
		{
			this.Duration = duration;
			this.AudioState = audioState;
		}

		// Token: 0x0603B287 RID: 242311 RVA: 0x010B91A0 File Offset: 0x010B73A0
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

		// Token: 0x0603B288 RID: 242312 RVA: 0x010B920C File Offset: 0x010B740C
		public void StopAudio()
		{
			if (this.AudioTimerHandle != null)
			{
				TimerSystem.Instance.Remove(this.AudioTimerHandle);
				this.AudioTimerHandle = null;
			}
		}

		// Token: 0x0603B289 RID: 242313 RVA: 0x010B922E File Offset: 0x010B742E
		public void PauseAudio()
		{
			if (this.AudioTimerHandle != null)
			{
				TimerSystem.Instance.Pause(this.AudioTimerHandle, null);
			}
		}

		// Token: 0x0603B28A RID: 242314 RVA: 0x010B924A File Offset: 0x010B744A
		public void ResumeAudio()
		{
			if (this.AudioTimerHandle != null)
			{
				TimerSystem.Instance.Resume(this.AudioTimerHandle);
			}
		}

		// Token: 0x0401F218 RID: 127512
		public float Duration;

		// Token: 0x0401F219 RID: 127513
		public IDollGrabStageAudioState AudioState;

		// Token: 0x0401F21A RID: 127514
		public TimerHandle AudioTimerHandle;
	}
}
