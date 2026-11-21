using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel.Action
{
	// Token: 0x020037D2 RID: 14290
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelMovieAction : VisualNovelAction
	{
		// Token: 0x0602532A RID: 152362 RVA: 0x00A7DEC0 File Offset: 0x00A7C0C0
		public VisualNovelMovieAction(VisualNovelContext context, PlayMovie movie, bool remainViewWhenEnd) : base(context)
		{
			this.Movie = movie;
			this.RemainViewWhenEnd = remainViewWhenEnd;
		}

		// Token: 0x0602532B RID: 152363 RVA: 0x00A7DED8 File Offset: 0x00A7C0D8
		protected override UniTask ExecuteCoreAsync()
		{
			VisualNovelMovieAction.<ExecuteCoreAsync>d__6 <ExecuteCoreAsync>d__;
			<ExecuteCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteCoreAsync>d__.<>4__this = this;
			<ExecuteCoreAsync>d__.<>1__state = -1;
			<ExecuteCoreAsync>d__.<>t__builder.Start<VisualNovelMovieAction.<ExecuteCoreAsync>d__6>(ref <ExecuteCoreAsync>d__);
			return <ExecuteCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602532C RID: 152364 RVA: 0x00A7DF1B File Offset: 0x00A7C11B
		public override bool TryComplete()
		{
			if (!base.IsExecuting || this.CloseRequested)
			{
				return false;
			}
			this.CloseRequested = true;
			if (this.IsVideoReady)
			{
				this.CloseVideo();
			}
			return true;
		}

		// Token: 0x0602532D RID: 152365 RVA: 0x00A7DF45 File Offset: 0x00A7C145
		internal override void Release()
		{
			if (base.IsExecuting)
			{
				this.TryComplete();
			}
		}

		// Token: 0x0602532E RID: 152366 RVA: 0x00A7DF56 File Offset: 0x00A7C156
		private void OnVideoEnd()
		{
			base.Context.IsMovieViewRemained = this.RemainViewWhenEnd;
			this.Complete();
		}

		// Token: 0x0602532F RID: 152367 RVA: 0x00A7DF70 File Offset: 0x00A7C170
		private void Complete()
		{
			VideoLauncher.SetupFrameEvent(null, null);
			UniTaskCompletionSource completion = this.Completion;
			if (completion == null)
			{
				return;
			}
			this.Completion = null;
			completion.TrySetResult();
		}

		// Token: 0x06025330 RID: 152368 RVA: 0x00A7DF9D File Offset: 0x00A7C19D
		private void CloseVideo()
		{
			VideoLauncher.CloseVideoCg(delegate(bool _)
			{
				base.Context.IsMovieViewRemained = false;
				this.Complete();
			});
		}

		// Token: 0x06025331 RID: 152369 RVA: 0x00A7DFB0 File Offset: 0x00A7C1B0
		private static void ExecuteFrameEventActions(List<ActionInfo> actions)
		{
			foreach (ActionInfo actionInfo in actions)
			{
				if (!actionInfo.Disabled.GetValueOrDefault())
				{
					PostAkEvent postAkEvent = actionInfo.Params as PostAkEvent;
					if (postAkEvent != null)
					{
						IPostAkEventMusicSubtitle postAkEventMusicSubtitle = postAkEvent.EventConfig as IPostAkEventMusicSubtitle;
						if (postAkEventMusicSubtitle != null)
						{
							MusicSubtitleManager.Play(postAkEventMusicSubtitle);
							continue;
						}
					}
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.VisualNovel;
					ELogAuthor author = ELogAuthor.LZK;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("视觉小说视频帧事件不支持该行为: ");
					defaultInterpolatedStringHandler.AppendFormatted<EAction>(actionInfo.Name);
					instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
		}

		// Token: 0x06025332 RID: 152370 RVA: 0x00A7E07C File Offset: 0x00A7C27C
		private ShowVideoCgConfig CreateConfig()
		{
			return new ShowVideoCgConfig
			{
				BackgroundFade = this.Movie.BackgroundFade,
				RemainViewWhenEnd = new bool?(this.RemainViewWhenEnd),
				InPlot = new bool?(false),
				ProgramSpecialConfig = this.Movie.ProgramSpecialConfig,
				Mp4FadeOutTime = this.Movie.Mp4FadeOutTime,
				BlackBorderFadeOutTime = this.Movie.BlackBorderFadeOutTime,
				Mp4BlendAnim = this.Movie.Mp4BlendAnim,
				SkipType = EVideoSkipType.Normal,
				SkipCallback = delegate
				{
					this.TryComplete();
				}
			};
		}

		// Token: 0x04014939 RID: 84281
		private readonly PlayMovie Movie;

		// Token: 0x0401493A RID: 84282
		private readonly bool RemainViewWhenEnd;

		// Token: 0x0401493B RID: 84283
		[Nullable(2)]
		private UniTaskCompletionSource Completion;

		// Token: 0x0401493C RID: 84284
		private bool IsVideoReady;

		// Token: 0x0401493D RID: 84285
		private bool CloseRequested;

		// Token: 0x0200954A RID: 38218
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402EA05 RID: 190981
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<List<ActionInfo>> <0>__ExecuteFrameEventActions;
		}
	}
}
