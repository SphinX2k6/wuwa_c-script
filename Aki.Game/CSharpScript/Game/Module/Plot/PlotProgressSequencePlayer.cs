using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02005002 RID: 20482
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotProgressSequencePlayer
	{
		// Token: 0x17007FE9 RID: 32745
		// (get) Token: 0x06034673 RID: 214643 RVA: 0x00C521FA File Offset: 0x00C503FA
		public bool IsPlaying
		{
			get
			{
				return this.ResourcePath != null;
			}
		}

		// Token: 0x06034674 RID: 214644 RVA: 0x00C52208 File Offset: 0x00C50408
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

		// Token: 0x06034675 RID: 214645 RVA: 0x00C522E0 File Offset: 0x00C504E0
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

		// Token: 0x06034676 RID: 214646 RVA: 0x00C5237C File Offset: 0x00C5057C
		public void OnTick(float delta)
		{
			if (this.SequencePlayer == null)
			{
				return;
			}
			float num = this.GetProcess() * this.FrameLength;
			float num2 = (float)Math.Floor((double)num);
			this.CurrentFrame.FrameNumber = new FFrameNumber((int)num2);
			this.CurrentFrame.SubFrame = num - num2;
			this.SequencePlayer.PlayToFrame(this.CurrentFrame);
		}

		// Token: 0x06034677 RID: 214647 RVA: 0x00C523DC File Offset: 0x00C505DC
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

		// Token: 0x06034678 RID: 214648 RVA: 0x00C524F8 File Offset: 0x00C506F8
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

		// Token: 0x0401BE7C RID: 114300
		[Nullable(2)]
		private string ResourcePath;

		// Token: 0x0401BE7D RID: 114301
		[Nullable(2)]
		private ALevelSequenceActor SequenceActor;

		// Token: 0x0401BE7E RID: 114302
		[Nullable(2)]
		private ULevelSequencePlayer SequencePlayer;

		// Token: 0x0401BE7F RID: 114303
		[Nullable(2)]
		private IFloatingSubtitleLanguageDiff PreprocessOperation;

		// Token: 0x0401BE80 RID: 114304
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401BE81 RID: 114305
		private readonly Vector Direct = Vector.Create();

		// Token: 0x0401BE82 RID: 114306
		private float Distance;

		// Token: 0x0401BE83 RID: 114307
		private float FrameLength;

		// Token: 0x0401BE84 RID: 114308
		private readonly FFrameTime CurrentFrame = new FFrameTime();

		// Token: 0x0401BE85 RID: 114309
		private readonly Vector TmpVector = Vector.Create();
	}
}
