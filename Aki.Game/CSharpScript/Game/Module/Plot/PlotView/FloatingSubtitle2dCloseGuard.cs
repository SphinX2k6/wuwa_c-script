using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005044 RID: 20548
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatingSubtitle2dCloseGuard
	{
		// Token: 0x0603496E RID: 215406 RVA: 0x00C6B820 File Offset: 0x00C69A20
		public void Start(SimpleLevelSequenceActor sequenceActor, ULevelSequence sequence, PlayLevelSequence config)
		{
			this.Stop();
			TPlayMode? tplayMode;
			if (!this.IsSubtitleSequence(config.LevelSequencePath) || string.IsNullOrEmpty(config.Mark) || ((config.PlayMode != null) ? tplayMode.GetValueOrDefault().ToEnumString() : null) == EPlayLevelSequenceType.Loop.ToEnumString())
			{
				return;
			}
			UMovieScene movieScene = sequence.GetMovieScene();
			UMovieSceneSequencePlayer player = sequenceActor.GetPlayer();
			if (movieScene == null || (player == null || !player.IsValid()))
			{
				return;
			}
			TArray<FMovieSceneMarkedFrame> markedFrames = movieScene.MarkedFrames;
			int? num = null;
			int num2 = int.MinValue;
			for (int i = 0; i < markedFrames.Num(); i++)
			{
				FMovieSceneMarkedFrame fmovieSceneMarkedFrame = markedFrames.Get(i);
				num2 = Math.Max(num2, fmovieSceneMarkedFrame.FrameNumber.Value);
				if (fmovieSceneMarkedFrame.Label == config.Mark && num == null)
				{
					num = new int?(fmovieSceneMarkedFrame.FrameNumber.Value);
				}
			}
			if (num == null || num.Value != num2)
			{
				return;
			}
			FFrameRate tickResolution = movieScene.TickResolution;
			this.LastMarkSeconds = (double)num2 * (double)tickResolution.Denominator / (double)tickResolution.Numerator;
			this.Player = player;
			player.OnPause.Add(new Action(this.OnPause));
		}

		// Token: 0x0603496F RID: 215407 RVA: 0x00C6B96F File Offset: 0x00C69B6F
		public void Stop()
		{
			UMovieSceneSequencePlayer player = this.Player;
			if (player != null && player.IsValid())
			{
				this.Player.OnPause.Remove(new Action(this.OnPause));
			}
			this.Player = null;
		}

		// Token: 0x06034970 RID: 215408 RVA: 0x00C6B9A8 File Offset: 0x00C69BA8
		private void OnPause()
		{
			UMovieSceneSequencePlayer player = this.Player;
			if (player == null || !player.IsValid())
			{
				return;
			}
			FQualifiedFrameTime currentTime = player.GetCurrentTime();
			if (Math.Abs(((double)currentTime.Time.FrameNumber.Value + (double)currentTime.Time.SubFrame) * (double)currentTime.Rate.Denominator / (double)currentTime.Rate.Numerator - this.LastMarkSeconds) > 1E-06)
			{
				return;
			}
			this.Stop();
			UiViewBase view = UiManager.Instance.GetViewByName(EUiViewName.PlotArtWord2dView);
			if (view == null || view.ClosePromise != null)
			{
				return;
			}
			int viewId = view.GetViewId();
			TimerSystem.Instance.Next(delegate(float _)
			{
				if (UiManager.Instance.GetView(viewId) != view || view.ClosePromise != null)
				{
					return;
				}
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[FloatingSubtitle2dCloseGuard]到达最后Mark，保底关闭残留字幕";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewId", viewId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				UiManager.Instance.CloseViewById(viewId, null);
			}, null, null);
		}

		// Token: 0x06034971 RID: 215409 RVA: 0x00C6BA88 File Offset: 0x00C69C88
		private bool IsSubtitleSequence(string path)
		{
			return path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_1.3_7_2Dzimu_1" || path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_2.3_7_2Dzimu_2" || path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_3.3_7_2Dzimu_3" || path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_2_kill.3_7_2Dzimu_2_kill" || path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_kill.3_7_2Dzimu_kill";
		}

		// Token: 0x0401C06C RID: 114796
		[Nullable(2)]
		private UMovieSceneSequencePlayer Player;

		// Token: 0x0401C06D RID: 114797
		private double LastMarkSeconds;
	}
}
