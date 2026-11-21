using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FCC RID: 16332
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotProgressSequencePlayer
	{
		// Token: 0x1700539E RID: 21406
		// (get) Token: 0x06029500 RID: 169216 RVA: 0x00B9BF7E File Offset: 0x00B9A17E
		public bool IsPlaying
		{
			get
			{
				return this.ResourcePath != null;
			}
		}

		// Token: 0x06029501 RID: 169217 RVA: 0x00B9BF8C File Offset: 0x00B9A18C
		public void Play(string levelSequencePath, Vector startLocation, Vector endLocation, [Nullable(2)] IFloatingSubtitleLanguageDiff preprocessOperation = null)
		{
			if (this.IsPlaying)
			{
				this.Stop();
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[PlotProgressSequencePlayer]Play";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", levelSequencePath);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ResourcePath = levelSequencePath;
			this.PreprocessOperation = preprocessOperation;
			this.StartLocation.FromUeVector(startLocation);
			this.TmpVector.FromUeVector(endLocation);
			this.TmpVector.Subtraction(this.StartLocation, this.Direct);
			this.Distance = (float)this.Direct.Size();
			if ((double)this.Distance > 1E-08)
			{
				this.Direct.DivisionEqual((double)this.Distance);
			}
			ResourceSystem.Instance.LoadAsync<ULevelSequence>(levelSequencePath, new Action<ULevelSequence, string>(this.OnLoadComplete), 100, "js_undefined");
		}

		// Token: 0x06029502 RID: 169218 RVA: 0x00B9C064 File Offset: 0x00B9A264
		public void Stop()
		{
			if (!this.IsPlaying)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "[PlotProgressSequencePlayer]Stop";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", this.ResourcePath);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ResourcePath = null;
			this.PreprocessOperation = null;
			if (this.SequenceActor != null)
			{
				this.SequencePlayer.Stop();
				ALevelSequenceActor tmp = this.SequenceActor;
				TimerSystem.Instance.Next(delegate(float _)
				{
					ActorSystem.Instance.Put("PlotProgressSequencePlayer.Stop", tmp, null);
				}, null, null);
				this.SequenceActor = null;
				this.SequencePlayer = null;
			}
		}

		// Token: 0x06029503 RID: 169219 RVA: 0x00B9C100 File Offset: 0x00B9A300
		public void OnTick(float delta)
		{
			if (this.SequencePlayer == null)
			{
				return;
			}
			float num = this.GetProcess() * this.FrameLength;
			float num2 = (float)Math.Floor((double)num);
			this.CurrentFrame.FrameNumber = new FFrameNumber
			{
				Value = (int)num2
			};
			this.CurrentFrame.SubFrame = num - num2;
			this.SequencePlayer.PlayToFrame(this.CurrentFrame);
		}

		// Token: 0x06029504 RID: 169220 RVA: 0x00B9C164 File Offset: 0x00B9A364
		private void OnLoadComplete([Nullable(2)] ULevelSequence levelSequence, string path)
		{
			if (path != this.ResourcePath)
			{
				return;
			}
			if (levelSequence == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[PlotProgressSequencePlayer]Sequence加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ResourcePath = null;
				this.PreprocessOperation = null;
				return;
			}
			FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
			fmovieSceneSequencePlaybackSettings.bDisableMovementInput = false;
			fmovieSceneSequencePlaybackSettings.bDisableLookAtInput = false;
			this.SequenceActor = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, false) as ALevelSequenceActor);
			this.SequenceActor.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
			LevelSequencePreprocessHelper.Instance.Apply(levelSequence, this.PreprocessOperation);
			this.SequenceActor.SetSequence(levelSequence);
			this.SequenceActor.bOverrideInstanceData = true;
			this.SequencePlayer = this.SequenceActor.SequencePlayer;
			this.SequencePlayer.Play();
			this.SequencePlayer.SetPlayRate(0f);
			this.SequencePlayer.Pause();
			this.FrameLength = (float)this.SequencePlayer.GetEndTime().Time.FrameNumber.Value;
		}

		// Token: 0x06029505 RID: 169221 RVA: 0x00B9C280 File Offset: 0x00B9A480
		private float GetProcess()
		{
			if (Global.BaseCharacter == null || (double)this.Distance < 1E-08)
			{
				return 0f;
			}
			Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.Subtraction(this.StartLocation, this.TmpVector);
			double currentValue = this.TmpVector.DotProduct(this.Direct) / (double)this.Distance;
			return (float)MathUtils.Instance.Clamp(currentValue, 0.0, 1.0);
		}

		// Token: 0x04016859 RID: 92249
		[Nullable(2)]
		private string ResourcePath;

		// Token: 0x0401685A RID: 92250
		[Nullable(2)]
		private ALevelSequenceActor SequenceActor;

		// Token: 0x0401685B RID: 92251
		[Nullable(2)]
		private ULevelSequencePlayer SequencePlayer;

		// Token: 0x0401685C RID: 92252
		[Nullable(2)]
		private IFloatingSubtitleLanguageDiff PreprocessOperation;

		// Token: 0x0401685D RID: 92253
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401685E RID: 92254
		private readonly Vector Direct = Vector.Create();

		// Token: 0x0401685F RID: 92255
		private float Distance;

		// Token: 0x04016860 RID: 92256
		private float FrameLength;

		// Token: 0x04016861 RID: 92257
		private readonly FFrameTime CurrentFrame = new FFrameTime();

		// Token: 0x04016862 RID: 92258
		private readonly Vector TmpVector = Vector.Create();
	}
}
