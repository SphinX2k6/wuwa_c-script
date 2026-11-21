using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037BE RID: 14270
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelScreenEffectItem : UiPanelBase
	{
		// Token: 0x17004C88 RID: 19592
		// (get) Token: 0x06025252 RID: 152146 RVA: 0x00A7A547 File Offset: 0x00A78747
		public string Path { get; }

		// Token: 0x06025253 RID: 152147 RVA: 0x00A7A54F File Offset: 0x00A7874F
		public VisualNovelScreenEffectItem(string path)
		{
			this.Path = path;
		}

		// Token: 0x06025254 RID: 152148 RVA: 0x00A7A580 File Offset: 0x00A78780
		public UniTask PrepareAsync(UUIItem parentItem)
		{
			this.PrepareTask = base.CreateByPathAsync(this.Path, parentItem, false).Preserve();
			return this.PrepareTask;
		}

		// Token: 0x06025255 RID: 152149 RVA: 0x00A7A5B0 File Offset: 0x00A787B0
		public UniTask InitializeAsync()
		{
			VisualNovelScreenEffectItem.<InitializeAsync>d__14 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<VisualNovelScreenEffectItem.<InitializeAsync>d__14>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025256 RID: 152150 RVA: 0x00A7A5F3 File Offset: 0x00A787F3
		protected override void OnStart()
		{
			if (this.IsDisposed || this.RootItem == null)
			{
				return;
			}
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStarted));
		}

		// Token: 0x06025257 RID: 152151 RVA: 0x00A7A62E File Offset: 0x00A7882E
		protected override void OnBeforeDestroy()
		{
			this.ClearPlayback();
		}

		// Token: 0x06025258 RID: 152152 RVA: 0x00A7A636 File Offset: 0x00A78836
		private void ClearPlayback()
		{
			this.IsDisposed = true;
			this.Initialized.TrySetResult();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			this.SequencePlayer = null;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Clear();
		}

		// Token: 0x06025259 RID: 152153 RVA: 0x00A7A662 File Offset: 0x00A78862
		public UniTask PlayStartAsync()
		{
			if (this.IsDisposed || this.IsClosing)
			{
				return UniTask.CompletedTask;
			}
			return this.PlaySequenceAsync("Start", this.CompleteStart);
		}

		// Token: 0x0602525A RID: 152154 RVA: 0x00A7A68C File Offset: 0x00A7888C
		public UniTask PlayCloseAsync()
		{
			VisualNovelScreenEffectItem.<PlayCloseAsync>d__19 <PlayCloseAsync>d__;
			<PlayCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseAsync>d__.<>4__this = this;
			<PlayCloseAsync>d__.<>1__state = -1;
			<PlayCloseAsync>d__.<>t__builder.Start<VisualNovelScreenEffectItem.<PlayCloseAsync>d__19>(ref <PlayCloseAsync>d__);
			return <PlayCloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602525B RID: 152155 RVA: 0x00A7A6CF File Offset: 0x00A788CF
		public void Complete()
		{
			if (this.IsClosing)
			{
				this.CompleteClose = true;
			}
			else
			{
				this.CompleteStart = true;
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.StopCurrentSequence(true, true);
		}

		// Token: 0x0602525C RID: 152156 RVA: 0x00A7A6FC File Offset: 0x00A788FC
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

		// Token: 0x0602525D RID: 152157 RVA: 0x00A7A72D File Offset: 0x00A7892D
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

		// Token: 0x0602525E RID: 152158 RVA: 0x00A7A764 File Offset: 0x00A78964
		public void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}
			this.ClearPlayback();
			base.SetUiActive(false);
			base.Destroy(null);
		}

		// Token: 0x0602525F RID: 152159 RVA: 0x00A7A784 File Offset: 0x00A78984
		private UniTask PlaySequenceAsync(string sequenceName, bool complete)
		{
			if (this.SequencePlayer == null)
			{
				return UniTask.CompletedTask;
			}
			CustomPromise<bool> stopPromise = new CustomPromise<bool>();
			return this.SequencePlayer.PlaySequenceAsync(sequenceName, stopPromise, false, false, new float?(this.PlaybackRate), complete);
		}

		// Token: 0x06025260 RID: 152160 RVA: 0x00A7A7C0 File Offset: 0x00A789C0
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

		// Token: 0x06025261 RID: 152161 RVA: 0x00A7A7E1 File Offset: 0x00A789E1
		private void ApplyPlaybackRate(string sequenceName)
		{
			AUIBaseActor rootActor = this.RootActor;
			object obj;
			if (rootActor == null)
			{
				obj = null;
			}
			else
			{
				ALevelSequenceActor sequencePlayerByKey = rootActor.GetSequencePlayerByKey(sequenceName);
				obj = ((sequencePlayerByKey != null) ? sequencePlayerByKey.SequencePlayer : null);
			}
			object obj2 = obj;
			if (obj2 == null)
			{
				return;
			}
			obj2.SetPlayRate(this.PlaybackRate);
		}

		// Token: 0x040148A9 RID: 84137
		private readonly UniTaskCompletionSource Initialized = new UniTaskCompletionSource();

		// Token: 0x040148AA RID: 84138
		private UniTask PrepareTask = UniTask.CompletedTask;

		// Token: 0x040148AB RID: 84139
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x040148AC RID: 84140
		private float PlaybackRate = 1f;

		// Token: 0x040148AD RID: 84141
		private bool IsPaused;

		// Token: 0x040148AE RID: 84142
		private bool IsClosing;

		// Token: 0x040148AF RID: 84143
		private bool IsDisposed;

		// Token: 0x040148B0 RID: 84144
		private bool CompleteStart;

		// Token: 0x040148B1 RID: 84145
		private bool CompleteClose;
	}
}
