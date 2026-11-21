using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004013 RID: 16403
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatingSubtitle2dCloseGuard
	{
		// Token: 0x0602984A RID: 170058 RVA: 0x00BB88C0 File Offset: 0x00BB6AC0
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

		// Token: 0x0602984B RID: 170059 RVA: 0x00BB8A0F File Offset: 0x00BB6C0F
		public void Stop()
		{
			UMovieSceneSequencePlayer player = this.Player;
			if (player != null && player.IsValid())
			{
				this.Player.OnPause.Remove(new Action(this.OnPause));
			}
			this.Player = null;
		}

		// Token: 0x0602984C RID: 170060 RVA: 0x00BB8A48 File Offset: 0x00BB6C48
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

		// Token: 0x0602984D RID: 170061 RVA: 0x00BB8B28 File Offset: 0x00BB6D28
		private bool IsSubtitleSequence(string path)
		{
			return path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_1.3_7_2Dzimu_1" || path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_2.3_7_2Dzimu_2" || path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_3.3_7_2Dzimu_3" || path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_2_kill.3_7_2Dzimu_2_kill" || path == "/Game/Aki/Sequence/Level/3_7/Huoxia/DiTianJian/3_7_2Dzimu_kill.3_7_2Dzimu_kill";
		}

		// Token: 0x04016A8F RID: 92815
		[Nullable(2)]
		private UMovieSceneSequencePlayer Player;

		// Token: 0x04016A90 RID: 92816
		private double LastMarkSeconds;
	}
}
