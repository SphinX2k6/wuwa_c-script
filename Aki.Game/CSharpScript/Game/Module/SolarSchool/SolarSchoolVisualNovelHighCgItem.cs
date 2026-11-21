using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A73 RID: 23155
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelHighCgItem : UiPanelBase
	{
		// Token: 0x060390CC RID: 233676 RVA: 0x00FFA684 File Offset: 0x00FF8884
		public UniTask PrepareAsync(string path, UUIItem parentItem)
		{
			this.PrepareTask = base.CreateByPathAsync(path, parentItem, false).Preserve();
			return this.PrepareTask;
		}

		// Token: 0x060390CD RID: 233677 RVA: 0x00FFA6B0 File Offset: 0x00FF88B0
		[NullableContext(0)]
		public UniTask<bool> WaitPreparedAsync()
		{
			SolarSchoolVisualNovelHighCgItem.<WaitPreparedAsync>d__5 <WaitPreparedAsync>d__;
			<WaitPreparedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<WaitPreparedAsync>d__.<>4__this = this;
			<WaitPreparedAsync>d__.<>1__state = -1;
			<WaitPreparedAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelHighCgItem.<WaitPreparedAsync>d__5>(ref <WaitPreparedAsync>d__);
			return <WaitPreparedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390CE RID: 233678 RVA: 0x00FFA6F3 File Offset: 0x00FF88F3
		protected override void OnStart()
		{
			if (this.RootItem == null)
			{
				return;
			}
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStarted));
		}

		// Token: 0x060390CF RID: 233679 RVA: 0x00FFA726 File Offset: 0x00FF8926
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			this.SequencePlayer = null;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Clear();
		}

		// Token: 0x060390D0 RID: 233680 RVA: 0x00FFA740 File Offset: 0x00FF8940
		protected override UniTask OnShowAsyncImplementImplement()
		{
			SolarSchoolVisualNovelHighCgItem.<OnShowAsyncImplementImplement>d__8 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<SolarSchoolVisualNovelHighCgItem.<OnShowAsyncImplementImplement>d__8>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060390D1 RID: 233681 RVA: 0x00FFA783 File Offset: 0x00FF8983
		public UniTask PlayCloseAsync()
		{
			return this.PlaySequenceAsync("Close");
		}

		// Token: 0x060390D2 RID: 233682 RVA: 0x00FFA790 File Offset: 0x00FF8990
		public UniTask PlayAnimationAsync(string animationName)
		{
			if (string.IsNullOrEmpty(animationName))
			{
				return UniTask.CompletedTask;
			}
			return this.PlaySequenceAsync(animationName);
		}

		// Token: 0x060390D3 RID: 233683 RVA: 0x00FFA7A8 File Offset: 0x00FF89A8
		public void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = playbackRate;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			string text = (sequencePlayer != null) ? sequencePlayer.GetCurrentSequence() : null;
			if (text != null)
			{
				this.ApplyPlaybackRate(text);
			}
		}

		// Token: 0x060390D4 RID: 233684 RVA: 0x00FFA7D9 File Offset: 0x00FF89D9
		public void SetPaused(bool paused)
		{
			if (this.IsPaused == paused)
			{
				return;
			}
			this.IsPaused = paused;
			if (paused)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PauseSequence();
				return;
			}
			else
			{
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.ResumeSequence();
				return;
			}
		}

		// Token: 0x060390D5 RID: 233685 RVA: 0x00FFA810 File Offset: 0x00FF8A10
		private UniTask PlaySequenceAsync(string sequenceName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return UniTask.CompletedTask;
			}
			sequencePlayer.StopCurrentSequence(false, false);
			CustomPromise<bool> stopPromise = new CustomPromise<bool>();
			return sequencePlayer.PlaySequenceAsync(sequenceName, stopPromise, false, false, new float?(this.PlaybackRate), false);
		}

		// Token: 0x060390D6 RID: 233686 RVA: 0x00FFA851 File Offset: 0x00FF8A51
		private void OnSequenceStarted(string sequenceName)
		{
			this.ApplyPlaybackRate(sequenceName);
			if (this.IsPaused)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PauseSequence();
			}
		}

		// Token: 0x060390D7 RID: 233687 RVA: 0x00FFA872 File Offset: 0x00FF8A72
		private void ApplyPlaybackRate(string sequenceName)
		{
			ALevelSequenceActor sequencePlayerByKey = this.RootActor.GetSequencePlayerByKey(sequenceName);
			if (sequencePlayerByKey == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.SetPlayRate(this.PlaybackRate);
		}

		// Token: 0x0401E04E RID: 122958
		private UniTask PrepareTask = UniTask.CompletedTask;

		// Token: 0x0401E04F RID: 122959
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401E050 RID: 122960
		private float PlaybackRate = 1f;

		// Token: 0x0401E051 RID: 122961
		private bool IsPaused;
	}
}
