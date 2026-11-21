using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x0200379E RID: 14238
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelAudioEvent
	{
		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x06025083 RID: 151683 RVA: 0x00A7570B File Offset: 0x00A7390B
		public UniTask Completion
		{
			get
			{
				return this.CompletionSource.Task;
			}
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x06025084 RID: 151684 RVA: 0x00A75718 File Offset: 0x00A73918
		public UniTask Started
		{
			get
			{
				return this.StartedSource.Task;
			}
		}

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x06025085 RID: 151685 RVA: 0x00A75725 File Offset: 0x00A73925
		// (set) Token: 0x06025086 RID: 151686 RVA: 0x00A7572D File Offset: 0x00A7392D
		public bool IsCompleted { get; private set; }

		// Token: 0x06025087 RID: 151687 RVA: 0x00A75738 File Offset: 0x00A73938
		public VisualNovelAudioEvent(string eventName, float fadeOutTime, Action<VisualNovelAudioEvent> onCompleted, string externalSourceName = "", string externalSourceMediaName = "", bool completeByDuration = true, [Nullable(2)] SpineMouthAnimation mouthAnimation = null)
		{
			this.EventName = eventName;
			this.FadeOutTime = fadeOutTime;
			this.OnCompleted = onCompleted;
			this.ExternalSourceName = externalSourceName;
			this.ExternalSourceMediaName = externalSourceMediaName;
			this.CompleteByDuration = completeByDuration;
			this.MouthAnimation = mouthAnimation;
		}

		// Token: 0x06025088 RID: 151688 RVA: 0x00A757A1 File Offset: 0x00A739A1
		public bool HasMouthAnimation()
		{
			return this.MouthAnimation != null;
		}

		// Token: 0x06025089 RID: 151689 RVA: 0x00A757AC File Offset: 0x00A739AC
		public EVisualNovelMouthShape GetMouthShape()
		{
			if (this.IsCompleted || this.MouthAnimation == null)
			{
				return EVisualNovelMouthShape.Closed;
			}
			int? sourcePlayPosition = AudioSystem.Instance.GetSourcePlayPosition(this.Handle, false);
			if (sourcePlayPosition == null)
			{
				return EVisualNovelMouthShape.Closed;
			}
			return this.MouthAnimation.GetShape(sourcePlayPosition.Value);
		}

		// Token: 0x0602508A RID: 151690 RVA: 0x00A757FC File Offset: 0x00A739FC
		public bool Play()
		{
			PostEventArgs value = new PostEventArgs
			{
				CallbackMask = new ECallbackMask?((ECallbackMask)9),
				CallbackHandler = new Action<EAkCallbackType, UAkCallbackInfo>(this.OnAudioCallback),
				ExternalSourceName = this.ExternalSourceName,
				ExternalSourceMediaName = this.ExternalSourceMediaName
			};
			this.Handle = AudioSystem.Instance.PostEvent(this.EventName, null, new PostEventArgs?(value));
			if (this.Handle > 0)
			{
				return true;
			}
			this.Complete();
			return false;
		}

		// Token: 0x0602508B RID: 151691 RVA: 0x00A7587D File Offset: 0x00A73A7D
		public void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = playbackRate;
			TimerHandle durationTimer = this.DurationTimer;
			if (durationTimer == null)
			{
				return;
			}
			durationTimer.ChangeDilation(this.PlaybackRate);
		}

		// Token: 0x0602508C RID: 151692 RVA: 0x00A758A0 File Offset: 0x00A73AA0
		public void SetPaused(bool paused)
		{
			if (this.IsPaused == paused)
			{
				return;
			}
			this.IsPaused = paused;
			if (this.Handle > 0)
			{
				ExecuteActionArgs value = new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				};
				AudioSystem.Instance.ExecuteAction(this.Handle, paused ? EAudioActionType.Pause : EAudioActionType.Resume, new ExecuteActionArgs?(value));
			}
			if (this.DurationTimer == null || this.DurationTimer.IsPause() == paused)
			{
				return;
			}
			if (paused)
			{
				this.DurationTimer.Pause();
				return;
			}
			this.DurationTimer.Resume();
		}

		// Token: 0x0602508D RID: 151693 RVA: 0x00A75930 File Offset: 0x00A73B30
		public void Stop()
		{
			if (this.IsCompleted)
			{
				return;
			}
			if (this.Handle > 0)
			{
				ExecuteActionArgs value = new ExecuteActionArgs
				{
					TransitionDuration = new int?((int)(this.FadeOutTime * 1000f))
				};
				AudioSystem.Instance.ExecuteAction(this.Handle, EAudioActionType.Stop, new ExecuteActionArgs?(value));
			}
			this.Complete();
		}

		// Token: 0x0602508E RID: 151694 RVA: 0x00A75990 File Offset: 0x00A73B90
		[NullableContext(2)]
		private void OnAudioCallback(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
		{
			if (this.IsCompleted)
			{
				return;
			}
			if (callbackType == EAkCallbackType.EndOfEvent)
			{
				this.Complete();
				return;
			}
			if (callbackType != EAkCallbackType.Duration)
			{
				return;
			}
			this.StartedSource.TrySetResult();
			if (this.CompleteByDuration)
			{
				UAkDurationCallbackInfo uakDurationCallbackInfo = callbackInfo as UAkDurationCallbackInfo;
				if (uakDurationCallbackInfo != null)
				{
					this.StartDurationTimer(uakDurationCallbackInfo.Duration);
				}
			}
		}

		// Token: 0x0602508F RID: 151695 RVA: 0x00A759E0 File Offset: 0x00A73BE0
		private void StartDurationTimer(float duration)
		{
			if (duration <= 0f || this.DurationTimer != null)
			{
				return;
			}
			this.DurationTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.Stop();
			}, Math.Max(duration, 20f), null, "VisualNovelAudioEvent", true, this.PlaybackRate);
			if (this.IsPaused)
			{
				TimerHandle durationTimer = this.DurationTimer;
				if (durationTimer == null)
				{
					return;
				}
				durationTimer.Pause();
			}
		}

		// Token: 0x06025090 RID: 151696 RVA: 0x00A75A4C File Offset: 0x00A73C4C
		private void Complete()
		{
			if (this.IsCompleted)
			{
				return;
			}
			this.IsCompleted = true;
			this.MouthAnimation = null;
			this.StartedSource.TrySetResult();
			TimerHandle durationTimer = this.DurationTimer;
			if (durationTimer != null && durationTimer.Valid())
			{
				this.DurationTimer.Remove();
			}
			this.DurationTimer = null;
			this.CompletionSource.TrySetResult();
			this.OnCompleted(this);
		}

		// Token: 0x040147B9 RID: 83897
		private readonly string EventName;

		// Token: 0x040147BA RID: 83898
		private readonly float FadeOutTime;

		// Token: 0x040147BB RID: 83899
		private readonly string ExternalSourceName;

		// Token: 0x040147BC RID: 83900
		private readonly string ExternalSourceMediaName;

		// Token: 0x040147BD RID: 83901
		private readonly bool CompleteByDuration;

		// Token: 0x040147BE RID: 83902
		[Nullable(2)]
		private SpineMouthAnimation MouthAnimation;

		// Token: 0x040147BF RID: 83903
		private readonly Action<VisualNovelAudioEvent> OnCompleted;

		// Token: 0x040147C0 RID: 83904
		private readonly UniTaskCompletionSource CompletionSource = new UniTaskCompletionSource();

		// Token: 0x040147C1 RID: 83905
		private readonly UniTaskCompletionSource StartedSource = new UniTaskCompletionSource();

		// Token: 0x040147C2 RID: 83906
		[Nullable(2)]
		private TimerHandle DurationTimer;

		// Token: 0x040147C3 RID: 83907
		private int Handle;

		// Token: 0x040147C4 RID: 83908
		private float PlaybackRate = 1f;

		// Token: 0x040147C5 RID: 83909
		private bool IsPaused;
	}
}
