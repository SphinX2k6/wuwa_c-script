using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037C2 RID: 14274
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelTextPlayer
	{
		// Token: 0x17004C8D RID: 19597
		// (get) Token: 0x060252B4 RID: 152244 RVA: 0x00A7C5AA File Offset: 0x00A7A7AA
		public bool IsTyping
		{
			get
			{
				return this.TypingPromise != null;
			}
		}

		// Token: 0x060252B5 RID: 152245 RVA: 0x00A7C5B8 File Offset: 0x00A7A7B8
		public VisualNovelTextPlayer(UUIText textComponent, [Nullable(2)] PlotTextScrollComponent textScroll = null)
		{
			this.TextComponent = textComponent;
			this.TextScroll = textScroll;
			AActor owner = textComponent.GetOwner();
			UUIEffectTextAnimation textAnimComp = owner.GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation;
			ULGUIPlayTweenComponent tweenComp = owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent;
			this.TextWriter = new PlotTextWriterComponent();
			this.TextWriter.Init(new PlotTextWriterComponentContext
			{
				TextComponent = textComponent,
				TextAnimComp = textAnimComp,
				TweenComp = tweenComp,
				OnAnimCompleteDelegate = new Action(this.OnTypingFinished),
				OnStopDelegate = new Action(this.OnTypingFinished)
			});
			PlotTextScrollComponent textScroll2 = this.TextScroll;
			if (textScroll2 == null)
			{
				return;
			}
			textScroll2.SetDelayCharNum(PlotComponentUtils.GetTextScrollDelayCharNum());
		}

		// Token: 0x060252B6 RID: 152246 RVA: 0x00A7C680 File Offset: 0x00A7A880
		public UniTask PlayAsync(string content, EVisualNovelPlaybackMode playbackMode)
		{
			VisualNovelTextPlayer.<PlayAsync>d__10 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.content = content;
			<PlayAsync>d__.playbackMode = playbackMode;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<VisualNovelTextPlayer.<PlayAsync>d__10>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252B7 RID: 152247 RVA: 0x00A7C6D3 File Offset: 0x00A7A8D3
		public void CompleteTyping()
		{
			UniTaskCompletionSource typingPromise = this.TypingPromise;
			this.JumpToEnd();
			this.OnTypingFinished();
		}

		// Token: 0x060252B8 RID: 152248 RVA: 0x00A7C6E8 File Offset: 0x00A7A8E8
		public void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = playbackRate;
			ULTweener currentTweener = this.CurrentTweener;
			if (currentTweener != null)
			{
				currentTweener.SetSpeed(this.PlaybackRate);
			}
			PlotTextScrollComponent textScroll = this.TextScroll;
			if (textScroll == null)
			{
				return;
			}
			textScroll.SetPlayRate(this.PlaybackRate);
		}

		// Token: 0x060252B9 RID: 152249 RVA: 0x00A7C720 File Offset: 0x00A7A920
		public void SetPaused(bool paused)
		{
			if (this.IsPaused == paused)
			{
				return;
			}
			this.IsPaused = paused;
			if (paused)
			{
				PlotTextScrollComponent textScroll = this.TextScroll;
				if (textScroll != null)
				{
					textScroll.Pause();
				}
			}
			else
			{
				PlotTextScrollComponent textScroll2 = this.TextScroll;
				if (textScroll2 != null)
				{
					textScroll2.Resume();
				}
			}
			if (this.CurrentTweener == null)
			{
				return;
			}
			if (paused)
			{
				this.CurrentTweener.Pause();
				return;
			}
			this.CurrentTweener.Resume();
		}

		// Token: 0x060252BA RID: 152250 RVA: 0x00A7C788 File Offset: 0x00A7A988
		public void Destroy()
		{
			this.CompleteTyping();
			this.TextWriter.Clear();
		}

		// Token: 0x060252BB RID: 152251 RVA: 0x00A7C79C File Offset: 0x00A7A99C
		[Conditional("UE_BUILD_DEBUG")]
		[Conditional("UE_BUILD_DEVELOPMENT")]
		private void TraceState(string eventName, string details = "")
		{
			bool flag = this.TextComponent.IsValid();
			if (flag)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.TextComponent.ObjectIndex);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.TextComponent.ObjectSerialNumber);
				defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (flag)
			{
				ULTweener currentTweener = this.CurrentTweener;
				if (currentTweener != null && currentTweener.IsValid())
				{
					ULTweenBPLibrary.IsTweening(this.TextComponent, this.CurrentTweener);
				}
			}
		}

		// Token: 0x060252BC RID: 152252 RVA: 0x00A7C823 File Offset: 0x00A7AA23
		private static bool CanPlay(string content, EVisualNovelPlaybackMode playbackMode)
		{
			return !string.IsNullOrEmpty(content) && playbackMode != EVisualNovelPlaybackMode.Skip;
		}

		// Token: 0x060252BD RID: 152253 RVA: 0x00A7C836 File Offset: 0x00A7AA36
		private void JumpToEnd()
		{
			this.TextWriter.JumpToEnd();
			PlotTextScrollComponent textScroll = this.TextScroll;
			if (textScroll == null)
			{
				return;
			}
			textScroll.JumpToEnd();
		}

		// Token: 0x060252BE RID: 152254 RVA: 0x00A7C853 File Offset: 0x00A7AA53
		private void OnTypingFinished()
		{
			UniTaskCompletionSource typingPromise = this.TypingPromise;
			this.TypingPromise = null;
			if (typingPromise == null)
			{
				return;
			}
			typingPromise.TrySetResult();
		}

		// Token: 0x040148F0 RID: 84208
		private readonly UUIText TextComponent;

		// Token: 0x040148F1 RID: 84209
		private readonly PlotTextWriterComponent TextWriter;

		// Token: 0x040148F2 RID: 84210
		[Nullable(2)]
		private readonly PlotTextScrollComponent TextScroll;

		// Token: 0x040148F3 RID: 84211
		[Nullable(2)]
		private ULTweener CurrentTweener;

		// Token: 0x040148F4 RID: 84212
		[Nullable(2)]
		private UniTaskCompletionSource TypingPromise;

		// Token: 0x040148F5 RID: 84213
		private float PlaybackRate = 1f;

		// Token: 0x040148F6 RID: 84214
		private bool IsPaused;
	}
}
