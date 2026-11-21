using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037DD RID: 14301
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class VisualNovelTextAction : VisualNovelAction
	{
		// Token: 0x0602536C RID: 152428 RVA: 0x00A7EB04 File Offset: 0x00A7CD04
		[NullableContext(1)]
		public VisualNovelTextAction(VisualNovelContext context, VisualNovelItem item) : base(context)
		{
			this.Item = item;
			this.DialogueDelay = item.DialogueDelay;
			this.ClickProtectionTime = item.ClickProtectionTime;
			this.ClickShowFull = item.ClickShowFull;
		}

		// Token: 0x0602536D RID: 152429 RVA: 0x00A7EB38 File Offset: 0x00A7CD38
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelTextAction.<ExecuteCoreAsync>d__17 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelTextAction.<ExecuteCoreAsync>d__17>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602536E RID: 152430 RVA: 0x00A7EB7C File Offset: 0x00A7CD7C
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			VisualNovelDelayAction clickProtection = this.ClickProtection;
			if (clickProtection != null)
			{
				clickProtection.SetPlaybackRate(base.PlaybackRate);
			}
			VisualNovelAction startPerformances = this.StartPerformances;
			if (startPerformances != null)
			{
				startPerformances.SetPlaybackRate(base.PlaybackRate);
			}
			VisualNovelDelayAction delay = this.Delay;
			if (delay != null)
			{
				delay.SetPlaybackRate(base.PlaybackRate);
			}
			VisualNovelShowTextAction showText = this.ShowText;
			if (showText != null)
			{
				showText.SetPlaybackRate(base.PlaybackRate);
			}
			VisualNovelWaitInputAction waitInput = this.WaitInput;
			if (waitInput != null)
			{
				waitInput.SetPlaybackRate(base.PlaybackRate);
			}
			VisualNovelAction endPerformances = this.EndPerformances;
			if (endPerformances != null)
			{
				endPerformances.SetPlaybackRate(base.PlaybackRate);
			}
			VisualNovelShowChoicesAction showChoices = this.ShowChoices;
			if (showChoices == null)
			{
				return;
			}
			showChoices.SetPlaybackRate(base.PlaybackRate);
		}

		// Token: 0x0602536F RID: 152431 RVA: 0x00A7EC30 File Offset: 0x00A7CE30
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			VisualNovelDelayAction clickProtection = this.ClickProtection;
			if (clickProtection != null)
			{
				clickProtection.SetPaused(paused);
			}
			VisualNovelAction startPerformances = this.StartPerformances;
			if (startPerformances != null)
			{
				startPerformances.SetPaused(paused);
			}
			VisualNovelDelayAction delay = this.Delay;
			if (delay != null)
			{
				delay.SetPaused(paused);
			}
			VisualNovelShowTextAction showText = this.ShowText;
			if (showText != null)
			{
				showText.SetPaused(paused);
			}
			VisualNovelWaitInputAction waitInput = this.WaitInput;
			if (waitInput != null)
			{
				waitInput.SetPaused(paused);
			}
			VisualNovelAction endPerformances = this.EndPerformances;
			if (endPerformances != null)
			{
				endPerformances.SetPaused(paused);
			}
			VisualNovelShowChoicesAction showChoices = this.ShowChoices;
			if (showChoices == null)
			{
				return;
			}
			showChoices.SetPaused(paused);
		}

		// Token: 0x06025370 RID: 152432 RVA: 0x00A7ECC4 File Offset: 0x00A7CEC4
		public override bool TryComplete()
		{
			if (this.ClickProtection != null && base.Context.PlaybackMode != EVisualNovelPlaybackMode.Skip)
			{
				return false;
			}
			VisualNovelDelayAction clickProtection = this.ClickProtection;
			if (clickProtection != null)
			{
				clickProtection.TryComplete();
			}
			bool result;
			switch (this.Phase)
			{
			case VisualNovelTextAction.EPhase.Delaying:
				result = this.TryCompleteDelayPhase();
				break;
			case VisualNovelTextAction.EPhase.Typing:
				result = this.TryCompleteTypingPhase();
				break;
			case VisualNovelTextAction.EPhase.WaitingForInput:
				result = this.TryCompleteWaitingPhase();
				break;
			case VisualNovelTextAction.EPhase.PlayingEndPerformances:
			{
				VisualNovelAction endPerformances = this.EndPerformances;
				result = (endPerformances != null && endPerformances.TryComplete());
				break;
			}
			case VisualNovelTextAction.EPhase.Choosing:
			{
				VisualNovelShowChoicesAction showChoices = this.ShowChoices;
				result = (showChoices != null && showChoices.TryComplete());
				break;
			}
			default:
				result = false;
				break;
			}
			return result;
		}

		// Token: 0x06025371 RID: 152433 RVA: 0x00A7ED68 File Offset: 0x00A7CF68
		internal override void Release()
		{
			this.Release(this.ClickProtection);
			UniTaskCompletionSource clickProtectionCompletion = this.ClickProtectionCompletion;
			if (clickProtectionCompletion != null)
			{
				clickProtectionCompletion.TrySetCanceled(default(CancellationToken));
			}
			this.Release(this.StartPerformances);
			this.Release(this.CgAction);
			this.CgAction = null;
			this.Release(this.Delay);
			this.Release(this.ShowText);
			this.Release(this.WaitInput);
			this.Release(this.EndPerformances);
			this.Release(this.ShowChoices);
			this.ClickProtection = null;
			this.ClickProtectionCompletion = null;
			this.StartPerformances = null;
			this.Delay = null;
			this.ShowText = null;
			this.WaitInput = null;
			this.EndPerformances = null;
			this.ShowChoices = null;
			this.Phase = VisualNovelTextAction.EPhase.None;
			this.CompleteTextImmediately = false;
		}

		// Token: 0x06025372 RID: 152434 RVA: 0x00A7EE40 File Offset: 0x00A7D040
		private void StartClickProtection()
		{
			if (this.ClickProtectionTime <= 0f)
			{
				return;
			}
			VisualNovelDelayAction visualNovelDelayAction = new VisualNovelDelayAction(base.Context, this.ClickProtectionTime);
			UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
			this.ClickProtection = visualNovelDelayAction;
			this.ClickProtectionCompletion = uniTaskCompletionSource;
			visualNovelDelayAction.SetPlaybackRate(base.PlaybackRate);
			visualNovelDelayAction.SetPaused(base.IsPaused);
			this.CompleteClickProtectionAsync(visualNovelDelayAction, uniTaskCompletionSource).Forget();
		}

		// Token: 0x06025373 RID: 152435 RVA: 0x00A7EEA8 File Offset: 0x00A7D0A8
		private UniTask WaitForClickProtectionAsync()
		{
			VisualNovelTextAction.<WaitForClickProtectionAsync>d__23 <WaitForClickProtectionAsync>d__;
			<WaitForClickProtectionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitForClickProtectionAsync>d__.<>4__this = this;
			<WaitForClickProtectionAsync>d__.<>1__state = -1;
			<WaitForClickProtectionAsync>d__.<>t__builder.Start<VisualNovelTextAction.<WaitForClickProtectionAsync>d__23>(ref <WaitForClickProtectionAsync>d__);
			return <WaitForClickProtectionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025374 RID: 152436 RVA: 0x00A7EEEC File Offset: 0x00A7D0EC
		[NullableContext(1)]
		private UniTask CompleteClickProtectionAsync(VisualNovelDelayAction clickProtection, UniTaskCompletionSource completion)
		{
			VisualNovelTextAction.<CompleteClickProtectionAsync>d__24 <CompleteClickProtectionAsync>d__;
			<CompleteClickProtectionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CompleteClickProtectionAsync>d__.<>4__this = this;
			<CompleteClickProtectionAsync>d__.clickProtection = clickProtection;
			<CompleteClickProtectionAsync>d__.completion = completion;
			<CompleteClickProtectionAsync>d__.<>1__state = -1;
			<CompleteClickProtectionAsync>d__.<>t__builder.Start<VisualNovelTextAction.<CompleteClickProtectionAsync>d__24>(ref <CompleteClickProtectionAsync>d__);
			return <CompleteClickProtectionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025375 RID: 152437 RVA: 0x00A7EF40 File Offset: 0x00A7D140
		private bool TryCompleteWaitingPhase()
		{
			VisualNovelWaitInputAction waitInput = this.WaitInput;
			bool result = waitInput != null && waitInput.TryComplete();
			VisualNovelAction startPerformances = this.StartPerformances;
			if (startPerformances != null && startPerformances.TryComplete())
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06025376 RID: 152438 RVA: 0x00A7EF77 File Offset: 0x00A7D177
		private bool TryCompleteTypingPhase()
		{
			if (this.ClickShowFull || base.Context.PlaybackMode == EVisualNovelPlaybackMode.Skip)
			{
				VisualNovelShowTextAction showText = this.ShowText;
				return showText != null && showText.TryComplete();
			}
			return false;
		}

		// Token: 0x06025377 RID: 152439 RVA: 0x00A7EFA2 File Offset: 0x00A7D1A2
		private bool TryCompleteDelayPhase()
		{
			if (!this.ClickShowFull && base.Context.PlaybackMode != EVisualNovelPlaybackMode.Skip)
			{
				return false;
			}
			this.CompleteTextImmediately = true;
			VisualNovelDelayAction delay = this.Delay;
			return delay != null && delay.TryComplete();
		}

		// Token: 0x06025378 RID: 152440 RVA: 0x00A7EFD4 File Offset: 0x00A7D1D4
		private void Release(VisualNovelAction action)
		{
			if (action == null)
			{
				return;
			}
			action.Release();
		}

		// Token: 0x04014953 RID: 84307
		[Nullable(1)]
		private readonly VisualNovelItem Item;

		// Token: 0x04014954 RID: 84308
		private readonly float DialogueDelay;

		// Token: 0x04014955 RID: 84309
		private readonly float ClickProtectionTime;

		// Token: 0x04014956 RID: 84310
		private readonly bool ClickShowFull;

		// Token: 0x04014957 RID: 84311
		private VisualNovelDelayAction ClickProtection;

		// Token: 0x04014958 RID: 84312
		private UniTaskCompletionSource ClickProtectionCompletion;

		// Token: 0x04014959 RID: 84313
		private VisualNovelAction StartPerformances;

		// Token: 0x0401495A RID: 84314
		private VisualNovelCgAction CgAction;

		// Token: 0x0401495B RID: 84315
		private VisualNovelDelayAction Delay;

		// Token: 0x0401495C RID: 84316
		private VisualNovelShowTextAction ShowText;

		// Token: 0x0401495D RID: 84317
		private VisualNovelWaitInputAction WaitInput;

		// Token: 0x0401495E RID: 84318
		private VisualNovelAction EndPerformances;

		// Token: 0x0401495F RID: 84319
		private VisualNovelShowChoicesAction ShowChoices;

		// Token: 0x04014960 RID: 84320
		private VisualNovelTextAction.EPhase Phase;

		// Token: 0x04014961 RID: 84321
		private bool CompleteTextImmediately;

		// Token: 0x02009555 RID: 38229
		[NullableContext(0)]
		private enum EPhase
		{
			// Token: 0x0402EA35 RID: 191029
			None,
			// Token: 0x0402EA36 RID: 191030
			Delaying,
			// Token: 0x0402EA37 RID: 191031
			Typing,
			// Token: 0x0402EA38 RID: 191032
			WaitingForInput,
			// Token: 0x0402EA39 RID: 191033
			PlayingEndPerformances,
			// Token: 0x0402EA3A RID: 191034
			Choosing
		}
	}
}
