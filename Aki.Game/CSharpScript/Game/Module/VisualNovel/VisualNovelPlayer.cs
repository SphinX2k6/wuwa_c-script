using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.OperationRestrict;
using CSharpScript.Game.Module.Dialogue;
using CSharpScript.Game.Module.VisualNovel.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037BB RID: 14267
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelPlayer
	{
		// Token: 0x17004C85 RID: 19589
		// (get) Token: 0x060251FD RID: 152061 RVA: 0x00A78B12 File Offset: 0x00A76D12
		public VisualNovelContext Context { get; }

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x060251FE RID: 152062 RVA: 0x00A78B1A File Offset: 0x00A76D1A
		// (set) Token: 0x060251FF RID: 152063 RVA: 0x00A78B22 File Offset: 0x00A76D22
		[Nullable(2)]
		public string ErrorMessage { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17004C87 RID: 19591
		// (get) Token: 0x06025200 RID: 152064 RVA: 0x00A78B2B File Offset: 0x00A76D2B
		// (set) Token: 0x06025201 RID: 152065 RVA: 0x00A78B33 File Offset: 0x00A76D33
		public bool UltraFastForwardBlocked { get; set; }

		// Token: 0x06025202 RID: 152066 RVA: 0x00A78B3C File Offset: 0x00A76D3C
		public VisualNovelPlayer(VisualNovelContext context)
		{
			this.Context = context;
			this.Context.BindPlayer(this);
		}

		// Token: 0x06025203 RID: 152067 RVA: 0x00A78B58 File Offset: 0x00A76D58
		[NullableContext(0)]
		public UniTask<bool> PrepareAsync()
		{
			VisualNovelPlayer.<PrepareAsync>d__23 <PrepareAsync>d__;
			<PrepareAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PrepareAsync>d__.<>4__this = this;
			<PrepareAsync>d__.<>1__state = -1;
			<PrepareAsync>d__.<>t__builder.Start<VisualNovelPlayer.<PrepareAsync>d__23>(ref <PrepareAsync>d__);
			return <PrepareAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025204 RID: 152068 RVA: 0x00A78B9C File Offset: 0x00A76D9C
		[NullableContext(0)]
		public UniTask<bool> PlayAsync()
		{
			VisualNovelPlayer.<PlayAsync>d__24 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<VisualNovelPlayer.<PlayAsync>d__24>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025205 RID: 152069 RVA: 0x00A78BE0 File Offset: 0x00A76DE0
		private UniTask PlayDialogueAsync(ShowTalk showTalk)
		{
			VisualNovelPlayer.<PlayDialogueAsync>d__25 <PlayDialogueAsync>d__;
			<PlayDialogueAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDialogueAsync>d__.<>4__this = this;
			<PlayDialogueAsync>d__.showTalk = showTalk;
			<PlayDialogueAsync>d__.<>1__state = -1;
			<PlayDialogueAsync>d__.<>t__builder.Start<VisualNovelPlayer.<PlayDialogueAsync>d__25>(ref <PlayDialogueAsync>d__);
			return <PlayDialogueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025206 RID: 152070 RVA: 0x00A78C2C File Offset: 0x00A76E2C
		private void RecordPlotKey(VisualNovelItem item)
		{
			int? plotKeyId = item.PlotKeyId;
			if (plotKeyId != null)
			{
				this.Context.ReadRecord.Record(plotKeyId.Value);
			}
		}

		// Token: 0x06025207 RID: 152071 RVA: 0x00A78C64 File Offset: 0x00A76E64
		private UniTask PlayMovieAsync(PlayMovie movie, bool remainViewWhenEnd)
		{
			VisualNovelPlayer.<PlayMovieAsync>d__27 <PlayMovieAsync>d__;
			<PlayMovieAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMovieAsync>d__.<>4__this = this;
			<PlayMovieAsync>d__.movie = movie;
			<PlayMovieAsync>d__.remainViewWhenEnd = remainViewWhenEnd;
			<PlayMovieAsync>d__.<>1__state = -1;
			<PlayMovieAsync>d__.<>t__builder.Start<VisualNovelPlayer.<PlayMovieAsync>d__27>(ref <PlayMovieAsync>d__);
			return <PlayMovieAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025208 RID: 152072 RVA: 0x00A78CB8 File Offset: 0x00A76EB8
		private UniTask ExecuteActionAsync(VisualNovelAction action)
		{
			VisualNovelPlayer.<ExecuteActionAsync>d__28 <ExecuteActionAsync>d__;
			<ExecuteActionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteActionAsync>d__.<>4__this = this;
			<ExecuteActionAsync>d__.action = action;
			<ExecuteActionAsync>d__.<>1__state = -1;
			<ExecuteActionAsync>d__.<>t__builder.Start<VisualNovelPlayer.<ExecuteActionAsync>d__28>(ref <ExecuteActionAsync>d__);
			return <ExecuteActionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025209 RID: 152073 RVA: 0x00A78D04 File Offset: 0x00A76F04
		[NullableContext(0)]
		public UniTask<int> ShowChoicesAsync([Nullable(1)] VisualNovelItem item)
		{
			VisualNovelPlayer.<ShowChoicesAsync>d__29 <ShowChoicesAsync>d__;
			<ShowChoicesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
			<ShowChoicesAsync>d__.<>4__this = this;
			<ShowChoicesAsync>d__.item = item;
			<ShowChoicesAsync>d__.<>1__state = -1;
			<ShowChoicesAsync>d__.<>t__builder.Start<VisualNovelPlayer.<ShowChoicesAsync>d__29>(ref <ShowChoicesAsync>d__);
			return <ShowChoicesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602520A RID: 152074 RVA: 0x00A78D4F File Offset: 0x00A76F4F
		public void NotifyChoiceCommitted()
		{
			if (this.PendingChoiceData == null)
			{
				return;
			}
			this.PendingChoiceData = null;
			this.CurrentItemWasRead = false;
			this.FastForwardStoppedUntilRelease = false;
		}

		// Token: 0x0602520B RID: 152075 RVA: 0x00A78D70 File Offset: 0x00A76F70
		private VisualNovelChoiceData CreateChoiceData(VisualNovelItem item)
		{
			List<VisualNovelChoiceOption> list = new List<VisualNovelChoiceOption>();
			foreach (VisualNovelOption visualNovelOption in item.Options)
			{
				if (!visualNovelOption.Hidden)
				{
					bool flag = this.IsConditionMet(visualNovelOption);
					if (flag || !visualNovelOption.HideWhenConditionUnmet)
					{
						bool isRead = (item.OptionGroupType == EVisualNovelOptionGroupType.FullScreen || visualNovelOption.ReadMarkEnabled) && visualNovelOption.PlotOptionId != null && this.Context.ReadRecord.Contains(visualNovelOption.PlotOptionId.Value);
						bool isLocked = !flag;
						EVisualNovelChoiceState choiceState = VisualNovelPlayer.GetChoiceState(isLocked, isRead);
						string optionTextKey = VisualNovelPlayer.GetOptionTextKey(visualNovelOption, isLocked);
						string optionConditionText = this.GetOptionConditionText(visualNovelOption, isLocked);
						VisualNovelChoiceOption item2 = new VisualNovelChoiceOption(visualNovelOption.SourceIndex, visualNovelOption.PlotOptionId, choiceState, optionTextKey, optionConditionText, visualNovelOption.ConfirmBoxId);
						list.Add(item2);
					}
				}
			}
			return new VisualNovelChoiceData(item.QuestionTextKey, list, item.OptionGroupType);
		}

		// Token: 0x0602520C RID: 152076 RVA: 0x00A78E88 File Offset: 0x00A77088
		private bool IsConditionMet(VisualNovelOption option)
		{
			return option.Condition == null || this.Context.ConfigCenter.IsOptionConditionMet(option.Condition);
		}

		// Token: 0x0602520D RID: 152077 RVA: 0x00A78EAA File Offset: 0x00A770AA
		private static EVisualNovelChoiceState GetChoiceState(bool isLocked, bool isRead)
		{
			if (isLocked)
			{
				return EVisualNovelChoiceState.Locked;
			}
			if (isRead)
			{
				return EVisualNovelChoiceState.Selected;
			}
			return EVisualNovelChoiceState.Unselected;
		}

		// Token: 0x0602520E RID: 152078 RVA: 0x00A78EB8 File Offset: 0x00A770B8
		private static string GetOptionTextKey(VisualNovelOption option, bool isLocked)
		{
			if (isLocked && !string.IsNullOrEmpty(option.TextKeyWhenConditionUnmet))
			{
				return option.TextKeyWhenConditionUnmet;
			}
			if (!string.IsNullOrEmpty(option.TextKey))
			{
				return option.TextKey;
			}
			if (option.TextId != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[TextId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(option.TextId.Value);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return string.Empty;
		}

		// Token: 0x0602520F RID: 152079 RVA: 0x00A78F44 File Offset: 0x00A77144
		private string GetOptionConditionText(VisualNovelOption option, bool isLocked)
		{
			if (option.Condition == null)
			{
				return string.Empty;
			}
			if (isLocked && option.HideConditionTextWhenUnmet)
			{
				return string.Empty;
			}
			string optionConditionText = this.Context.ConfigCenter.GetOptionConditionText(option.Condition);
			if (!string.IsNullOrEmpty(optionConditionText))
			{
				return optionConditionText;
			}
			if (!isLocked || !option.HasLockTip)
			{
				return string.Empty;
			}
			return ConfigMultiTextLang.GetLocalTextNew(option.LockTipTextKey, null) ?? string.Empty;
		}

		// Token: 0x06025210 RID: 152080 RVA: 0x00A78FB8 File Offset: 0x00A771B8
		private int SelectFirstAvailableOption(VisualNovelItem item, IReadOnlyList<VisualNovelChoiceOption> options, bool skipSelected)
		{
			foreach (VisualNovelChoiceOption visualNovelChoiceOption in options)
			{
				if (visualNovelChoiceOption.State != EVisualNovelChoiceState.Locked && (!skipSelected || !this.HasSelectedOption(visualNovelChoiceOption)))
				{
					this.ConfirmChoice(item, visualNovelChoiceOption);
					return visualNovelChoiceOption.SourceIndex;
				}
			}
			string text;
			if (!skipSelected)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("TalkItem ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(item.Id);
				defaultInterpolatedStringHandler.AppendLiteral(" 没有可自动选择的选项");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("TalkItem ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(item.Id);
				defaultInterpolatedStringHandler.AppendLiteral(" 没有尚未选择的可用选项");
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string errorMessage = text;
			this.Fail(errorMessage);
			return -1;
		}

		// Token: 0x06025211 RID: 152081 RVA: 0x00A790A0 File Offset: 0x00A772A0
		private bool HasSelectedOption(VisualNovelChoiceOption option)
		{
			return option.PlotOptionId != null && this.Context.ReadRecord.Contains(option.PlotOptionId.Value);
		}

		// Token: 0x06025212 RID: 152082 RVA: 0x00A790DD File Offset: 0x00A772DD
		public void ContinueDialogue()
		{
			if (this.Context.IsStopped)
			{
				return;
			}
			this.ApplyJump(this.Context.Script.GetCurrentJump());
		}

		// Token: 0x06025213 RID: 152083 RVA: 0x00A79104 File Offset: 0x00A77304
		private bool ApplyJump(DialogueJump? jump)
		{
			if (jump == null)
			{
				return false;
			}
			if (jump.Value.EndsDialogue)
			{
				this.Context.Script.Jump(new DialogueJump?(jump.Value));
				this.Context.NextItem = null;
				return true;
			}
			DialogueItem dialogueItem = this.Context.Script.Jump(new DialogueJump?(jump.Value));
			if (dialogueItem == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("找不到目标 TalkItem: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(jump.Value.TargetId);
				this.Fail(defaultInterpolatedStringHandler.ToStringAndClear());
				return true;
			}
			this.Context.NextItem = this.Context.GetItem(dialogueItem);
			if (this.Context.NextItem == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
				defaultInterpolatedStringHandler.AppendLiteral("找不到可播放的目标 TalkItem: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(dialogueItem.Id);
				this.Fail(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			return true;
		}

		// Token: 0x06025214 RID: 152084 RVA: 0x00A79208 File Offset: 0x00A77408
		private void ConfirmChoice(VisualNovelItem item, VisualNovelChoiceOption option)
		{
			if (option.PlotOptionId != null)
			{
				int? num;
				num.GetValueOrDefault().ToString();
			}
			int? plotOptionId = option.PlotOptionId;
			if (plotOptionId != null)
			{
				this.Context.ReadRecord.Record(plotOptionId.Value);
			}
			DialogueOption dialogueOption = this.Context.Script.SelectOption(option.SourceIndex);
			if (!this.ApplyJump((dialogueOption != null) ? dialogueOption.Jump : null))
			{
				this.ContinueDialogue();
			}
		}

		// Token: 0x06025215 RID: 152085 RVA: 0x00A79298 File Offset: 0x00A77498
		public void Fail(string errorMessage)
		{
			this.ErrorMessage = errorMessage;
			this.Context.NextItem = null;
			global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, errorMessage, default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06025216 RID: 152086 RVA: 0x00A792D4 File Offset: 0x00A774D4
		public void Stop()
		{
			if (this.Context.IsStopped)
			{
				return;
			}
			this.Context.Audio.StopVoice();
			this.UnbindViewEvents();
			this.Context.Stop();
			this.SetScenePaused(true);
			this.StopPendingOperations();
			this.Context.CancelExecutingActions();
		}

		// Token: 0x06025217 RID: 152087 RVA: 0x00A79328 File Offset: 0x00A77528
		public void Pause()
		{
			if (!this.Context.IsReady)
			{
				return;
			}
			this.EndFastForward();
			if (!this.Context.Pause())
			{
				return;
			}
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction != null)
			{
				currentAction.SetPaused(true);
			}
			this.SetScenePaused(true);
			this.Context.View.SetPaused(true);
		}

		// Token: 0x06025218 RID: 152088 RVA: 0x00A79384 File Offset: 0x00A77584
		public void Resume()
		{
			if (!this.Context.IsPaused || !this.Context.IsReady)
			{
				return;
			}
			this.SetScenePaused(false);
			this.Context.View.SetPaused(false);
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction != null)
			{
				currentAction.SetPaused(false);
			}
			this.Context.Resume();
			this.TryCompleteCurrentActionForSkip();
		}

		// Token: 0x06025219 RID: 152089 RVA: 0x00A793E8 File Offset: 0x00A775E8
		public void SetDialogueVisible(bool visible)
		{
			this.Context.DialogueVisible = visible;
			this.Context.View.SetDialogueVisible(visible);
		}

		// Token: 0x0602521A RID: 152090 RVA: 0x00A79407 File Offset: 0x00A77607
		public void SetAutoButtonVisible(bool visible)
		{
			this.Context.AutoButtonVisible = visible;
			this.Context.View.SetAutoButtonVisible(visible);
			this.Context.View.SetPlaybackMode(this.Context.PlaybackMode);
		}

		// Token: 0x0602521B RID: 152091 RVA: 0x00A79441 File Offset: 0x00A77641
		public void SetReviewButtonVisible(bool visible)
		{
			this.Context.ReviewButtonVisible = visible;
			this.Context.View.SetReviewButtonVisible(visible);
		}

		// Token: 0x0602521C RID: 152092 RVA: 0x00A79460 File Offset: 0x00A77660
		public void SetMenuButtonVisible(bool visible)
		{
			this.Context.MenuButtonVisible = visible;
			this.Context.View.SetMenuButtonVisible(visible);
		}

		// Token: 0x0602521D RID: 152093 RVA: 0x00A7947F File Offset: 0x00A7767F
		public void SetAccelerateButtonVisible(bool visible)
		{
			visible = (visible && this.Context.FastForwardEnabled);
			this.Context.AccelerateButtonVisible = visible;
			this.Context.View.SetAccelerateButtonVisible(visible);
		}

		// Token: 0x0602521E RID: 152094 RVA: 0x00A794B1 File Offset: 0x00A776B1
		public void SetHideUiButtonVisible(bool visible)
		{
			this.Context.HideUiButtonVisible = visible;
			this.Context.View.SetHideUiButtonVisible(visible);
		}

		// Token: 0x0602521F RID: 152095 RVA: 0x00A794D0 File Offset: 0x00A776D0
		public void SetUltraFastForwardButtonVisible(bool visible)
		{
			this.Context.UltraFastForwardButtonVisible = visible;
			this.Context.View.SetUltraFastForwardButtonVisible(visible);
		}

		// Token: 0x06025220 RID: 152096 RVA: 0x00A794F0 File Offset: 0x00A776F0
		private void BindViewEvents()
		{
			this.UnbindViewEvents();
			IVisualNovelView view = this.Context.View;
			this.BoundView = view;
			view.ContinueRequested += this.OnContinue;
			view.ChoiceSelected += this.OnChoiceSelected;
			view.AutoPlayRequested += this.ToggleAutoPlay;
			view.FastForwardStarted += this.StartFastForward;
			view.FastForwardEnded += this.EndFastForward;
			view.UltraFastForwardRequested += this.StartUltraFastForward;
			view.SetPlaybackMode(this.Context.PlaybackMode);
		}

		// Token: 0x06025221 RID: 152097 RVA: 0x00A79594 File Offset: 0x00A77794
		private void UnbindViewEvents()
		{
			IVisualNovelView boundView = this.BoundView;
			if (boundView == null)
			{
				return;
			}
			this.BoundView = null;
			boundView.ContinueRequested -= this.OnContinue;
			boundView.ChoiceSelected -= this.OnChoiceSelected;
			boundView.AutoPlayRequested -= this.ToggleAutoPlay;
			boundView.FastForwardStarted -= this.StartFastForward;
			boundView.FastForwardEnded -= this.EndFastForward;
			boundView.UltraFastForwardRequested -= this.StartUltraFastForward;
		}

		// Token: 0x06025222 RID: 152098 RVA: 0x00A7961F File Offset: 0x00A7781F
		private void OnContinue()
		{
			if (this.Context.IsPaused || this.Context.IsInputLocked)
			{
				return;
			}
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction == null)
			{
				return;
			}
			currentAction.TryComplete();
		}

		// Token: 0x06025223 RID: 152099 RVA: 0x00A7964D File Offset: 0x00A7784D
		private void OnChoiceSelected(int optionIndex)
		{
			if (this.Context.IsPaused || this.Context.IsInputLocked)
			{
				return;
			}
			UniTaskCompletionSource<int> choicePromise = this.ChoicePromise;
			this.ChoicePromise = null;
			if (choicePromise == null)
			{
				return;
			}
			choicePromise.TrySetResult(optionIndex);
		}

		// Token: 0x06025224 RID: 152100 RVA: 0x00A79684 File Offset: 0x00A77884
		private void ToggleAutoPlay()
		{
			if (this.Context.IsPaused || this.Context.IsInputLocked)
			{
				return;
			}
			EVisualNovelPlaybackMode playbackMode = (this.Context.PlaybackMode == EVisualNovelPlaybackMode.Auto) ? EVisualNovelPlaybackMode.Manual : EVisualNovelPlaybackMode.Auto;
			this.SetPlaybackMode(playbackMode);
		}

		// Token: 0x06025225 RID: 152101 RVA: 0x00A796C8 File Offset: 0x00A778C8
		private void StartFastForward()
		{
			if (!this.Context.FastForwardEnabled || this.FastForwardStoppedUntilRelease)
			{
				this.RejectFastForward(this.FastForwardStoppedUntilRelease ? "stoppedUntilRelease" : "disabled");
				return;
			}
			if (this.Context.IsPaused || this.Context.IsInputLocked || this.PendingChoiceData != null)
			{
				this.RejectFastForward((this.PendingChoiceData != null) ? "choicePending" : (this.Context.IsPaused ? "paused" : "inputLocked"));
				return;
			}
			EVisualNovelPlaybackMode playbackMode = this.Context.PlaybackMode;
			bool flag = playbackMode - EVisualNovelPlaybackMode.FastForward <= 1;
			if (flag)
			{
				this.RejectFastForward("alreadyFast");
				return;
			}
			this.PlaybackModeBeforeFastForward = this.Context.PlaybackMode;
			this.SetPlaybackMode(EVisualNovelPlaybackMode.FastForward);
		}

		// Token: 0x06025226 RID: 152102 RVA: 0x00A79795 File Offset: 0x00A77995
		private void EndFastForward()
		{
			this.FastForwardStoppedUntilRelease = false;
			if (this.Context.IsInputLocked)
			{
				return;
			}
			if (this.Context.PlaybackMode != EVisualNovelPlaybackMode.FastForward)
			{
				return;
			}
			this.SetPlaybackMode(this.PlaybackModeBeforeFastForward);
		}

		// Token: 0x06025227 RID: 152103 RVA: 0x00A797C7 File Offset: 0x00A779C7
		private void RejectFastForward(string reason)
		{
		}

		// Token: 0x06025228 RID: 152104 RVA: 0x00A797C9 File Offset: 0x00A779C9
		private void StopFastForward()
		{
			if (this.Context.IsInputLocked || this.Context.PlaybackMode != EVisualNovelPlaybackMode.FastForward)
			{
				return;
			}
			this.FastForwardStoppedUntilRelease = true;
			this.SetPlaybackMode(this.PlaybackModeBeforeFastForward);
		}

		// Token: 0x06025229 RID: 152105 RVA: 0x00A797FA File Offset: 0x00A779FA
		private void StartUltraFastForward()
		{
			if (this.Context.IsPaused || this.Context.IsInputLocked)
			{
				return;
			}
			if (this.UltraFastForwardBlocked)
			{
				return;
			}
			this.SetPlaybackMode(EVisualNovelPlaybackMode.UltraFastForward);
		}

		// Token: 0x0602522A RID: 152106 RVA: 0x00A79828 File Offset: 0x00A77A28
		public void SetPlaybackMode(EVisualNovelPlaybackMode playbackMode)
		{
			if (this.Context.IsPaused)
			{
				return;
			}
			if (playbackMode == EVisualNovelPlaybackMode.FastForward && !this.Context.FastForwardEnabled)
			{
				return;
			}
			if (this.PendingChoiceData != null)
			{
				if (playbackMode == EVisualNovelPlaybackMode.FastForward)
				{
					return;
				}
				if (playbackMode == EVisualNovelPlaybackMode.UltraFastForward)
				{
					return;
				}
				if (playbackMode == EVisualNovelPlaybackMode.Skip)
				{
					return;
				}
			}
			this.Context.SetPlaybackMode(playbackMode);
			this.Context.Audio.SetVoiceEnabled(playbackMode != EVisualNovelPlaybackMode.UltraFastForward);
			this.Context.View.SetPlaybackMode(playbackMode);
			this.SetInputLocked(playbackMode == EVisualNovelPlaybackMode.UltraFastForward);
			float num;
			if (playbackMode != EVisualNovelPlaybackMode.FastForward)
			{
				if (playbackMode != EVisualNovelPlaybackMode.UltraFastForward)
				{
					num = 1f;
				}
				else
				{
					num = this.Context.UltraFastForwardRate;
				}
			}
			else
			{
				num = this.GetFastForwardRate();
			}
			float playbackRate = num;
			this.SetPlaybackRate(playbackRate);
			this.TryCompleteCurrentActionForSkip();
		}

		// Token: 0x0602522B RID: 152107 RVA: 0x00A798E0 File Offset: 0x00A77AE0
		private float GetFastForwardRate()
		{
			if (!this.CurrentItemWasRead)
			{
				return this.Context.FastForwardRate;
			}
			return this.Context.ReadFastForwardRate;
		}

		// Token: 0x0602522C RID: 152108 RVA: 0x00A79901 File Offset: 0x00A77B01
		public void StopUltraFastForward(string reason)
		{
			if (this.Context.PlaybackMode != EVisualNovelPlaybackMode.UltraFastForward)
			{
				return;
			}
			this.SetPlaybackMode(EVisualNovelPlaybackMode.Manual);
		}

		// Token: 0x0602522D RID: 152109 RVA: 0x00A7991C File Offset: 0x00A77B1C
		public void SetPlaybackRate(float playbackRate)
		{
			if (this.PendingChoiceData != null && playbackRate > 1f)
			{
				return;
			}
			this.Context.SetPlaybackRate(playbackRate);
			if (this.Context.IsReady)
			{
				foreach (VisualNovelCharacter visualNovelCharacter in this.Context.Scene.GetCharacters())
				{
					visualNovelCharacter.SetPlaybackRate(this.Context.PlaybackRate);
				}
				VisualNovelBackground background = this.Context.Scene.GetBackground();
				if (background != null)
				{
					background.SetPlaybackRate(this.Context.PlaybackRate);
				}
				this.Context.View.SetPlaybackRate(this.Context.PlaybackRate);
			}
			this.Context.Effects.SetPlaybackRate(this.Context.PlaybackRate);
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction == null)
			{
				return;
			}
			currentAction.SetPlaybackRate(this.Context.PlaybackRate);
		}

		// Token: 0x0602522E RID: 152110 RVA: 0x00A79A20 File Offset: 0x00A77C20
		internal void PrepareCharacter(VisualNovelCharacter character)
		{
			character.SetPlaybackRate(this.Context.PlaybackRate);
			character.SetPaused(this.Context.IsPaused);
			character.SetTemporarilyHidden(this.Context.AreCharactersTemporarilyHidden);
			int avgTalkerId = character.GetAvgTalkerId();
			character.SetSpeaking(avgTalkerId != 0 && avgTalkerId == this.Context.CurrentAvgTalkerId);
			if (avgTalkerId == this.VoiceAvgTalkerId)
			{
				VisualNovelAudioEvent characterVoice = this.CharacterVoice;
				if (characterVoice != null && !characterVoice.IsCompleted)
				{
					character.SetVoice(this.CharacterVoice);
				}
			}
		}

		// Token: 0x0602522F RID: 152111 RVA: 0x00A79AB0 File Offset: 0x00A77CB0
		internal void RefreshCharacterSpeakingState()
		{
			foreach (VisualNovelCharacter visualNovelCharacter in this.Context.Scene.GetCharacters())
			{
				if (visualNovelCharacter.CharacterId != null)
				{
					int avgTalkerId = visualNovelCharacter.GetAvgTalkerId();
					visualNovelCharacter.SetSpeaking(avgTalkerId != 0 && avgTalkerId == this.Context.CurrentAvgTalkerId);
				}
			}
		}

		// Token: 0x06025230 RID: 152112 RVA: 0x00A79B34 File Offset: 0x00A77D34
		internal void SetCharacterVoice(int avgTalkerId, VisualNovelAudioEvent voice)
		{
			this.CharacterVoice = voice;
			this.VoiceAvgTalkerId = avgTalkerId;
			if (avgTalkerId == 0)
			{
				return;
			}
			foreach (VisualNovelCharacter visualNovelCharacter in this.Context.Scene.GetCharacters())
			{
				if (visualNovelCharacter.CharacterId != null && visualNovelCharacter.GetAvgTalkerId() == avgTalkerId)
				{
					visualNovelCharacter.SetVoice(voice);
				}
			}
		}

		// Token: 0x06025231 RID: 152113 RVA: 0x00A79BB8 File Offset: 0x00A77DB8
		private void SetScenePaused(bool paused)
		{
			this.Context.Effects.SetPaused(paused);
			if (!this.Context.IsReady)
			{
				return;
			}
			foreach (VisualNovelCharacter visualNovelCharacter in this.Context.Scene.GetCharacters())
			{
				visualNovelCharacter.SetPaused(paused);
			}
			VisualNovelBackground background = this.Context.Scene.GetBackground();
			if (background == null)
			{
				return;
			}
			background.SetPaused(paused);
		}

		// Token: 0x06025232 RID: 152114 RVA: 0x00A79C48 File Offset: 0x00A77E48
		private void TryCompleteCurrentActionForSkip()
		{
			if (this.Context.IsPaused || this.Context.PlaybackMode != EVisualNovelPlaybackMode.Skip)
			{
				return;
			}
			VisualNovelAction currentAction = this.CurrentAction;
			if (currentAction == null)
			{
				return;
			}
			currentAction.TryComplete();
		}

		// Token: 0x06025233 RID: 152115 RVA: 0x00A79C78 File Offset: 0x00A77E78
		private void StopPendingOperations()
		{
			this.SetInputLocked(false);
			UniTaskCompletionSource<int> choicePromise = this.ChoicePromise;
			if (choicePromise != null)
			{
				choicePromise.TrySetResult(-1);
			}
			this.ChoicePromise = null;
			this.PendingChoiceData = null;
			VisualNovelAction currentAction = this.CurrentAction;
			this.CurrentAction = null;
			if (currentAction == null)
			{
				return;
			}
			currentAction.Release();
		}

		// Token: 0x06025234 RID: 152116 RVA: 0x00A79CC4 File Offset: 0x00A77EC4
		private void SetInputLocked(bool locked)
		{
			if (this.Context.IsInputLocked == locked)
			{
				return;
			}
			this.Context.SetInputLocked(locked);
			if (this.Context.IsReady)
			{
				this.Context.View.SetInputLocked(locked);
			}
			if (locked)
			{
				this.LockPlayerInput();
				return;
			}
			this.RestorePlayerInput();
		}

		// Token: 0x06025235 RID: 152117 RVA: 0x00A79D1C File Offset: 0x00A77F1C
		private void LockPlayerInput()
		{
			LevelEventLockInputState instance = LevelEventLockInputState.Instance;
			this.InputWasLocked = instance.RealLockInput;
			this.InputTagsBeforeLock = (this.InputWasLocked ? new List<string>(instance.InputTagNames) : null);
			OperationRestrictUtils.Instance.SetInputDisableAll();
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x06025236 RID: 152118 RVA: 0x00A79D6C File Offset: 0x00A77F6C
		private void RestorePlayerInput()
		{
			LevelEventLockInputState instance = LevelEventLockInputState.Instance;
			if (!instance.RealLockInput || instance.InputTagNames.Count != 0)
			{
				this.InputTagsBeforeLock = null;
				this.InputWasLocked = false;
				return;
			}
			if (this.InputWasLocked)
			{
				instance.Lock(this.InputTagsBeforeLock ?? new List<string>());
			}
			else
			{
				OperationRestrictUtils.Instance.SetInputUnlock();
			}
			this.InputTagsBeforeLock = null;
			this.InputWasLocked = false;
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x0401488C RID: 84108
		private EVisualNovelPlaybackMode PlaybackModeBeforeFastForward;

		// Token: 0x0401488D RID: 84109
		[Nullable(2)]
		private UniTaskCompletionSource<int> ChoicePromise;

		// Token: 0x0401488E RID: 84110
		[Nullable(2)]
		private VisualNovelChoiceData PendingChoiceData;

		// Token: 0x0401488F RID: 84111
		[Nullable(2)]
		private VisualNovelAction CurrentAction;

		// Token: 0x04014890 RID: 84112
		[Nullable(2)]
		private IVisualNovelView BoundView;

		// Token: 0x04014891 RID: 84113
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> InputTagsBeforeLock;

		// Token: 0x04014892 RID: 84114
		private bool InputWasLocked;

		// Token: 0x04014893 RID: 84115
		[Nullable(2)]
		private VisualNovelAudioEvent CharacterVoice;

		// Token: 0x04014894 RID: 84116
		private int VoiceAvgTalkerId;

		// Token: 0x04014895 RID: 84117
		private bool CurrentItemWasRead;

		// Token: 0x04014896 RID: 84118
		private bool FastForwardStoppedUntilRelease;
	}
}
