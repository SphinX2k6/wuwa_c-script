using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003993 RID: 14739
	[NullableContext(2)]
	[Nullable(0)]
	public class UiCameraSequenceComponent : UiCameraComponent
	{
		// Token: 0x17004D77 RID: 19831
		// (get) Token: 0x06025F40 RID: 155456 RVA: 0x00AA7220 File Offset: 0x00AA5420
		public bool IsPlaying
		{
			get
			{
				return this.LoadHandleId != 0 || this.SequenceActor != null;
			}
		}

		// Token: 0x06025F41 RID: 155457 RVA: 0x00AA7235 File Offset: 0x00AA5435
		public bool PlaySequence([Nullable(1)] TSoftObjectPtr<ULevelSequence> sequence, float playRate, bool reverse, AActor originActor = null, Action<bool> onFinished = null, Action onStarted = null)
		{
			return this.LoadAndPlay(sequence, playRate, reverse, originActor, onFinished, onStarted);
		}

		// Token: 0x06025F42 RID: 155458 RVA: 0x00AA7246 File Offset: 0x00AA5446
		public void Pause()
		{
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			if (sequenceActor == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = sequenceActor.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.Pause();
		}

		// Token: 0x06025F43 RID: 155459 RVA: 0x00AA7264 File Offset: 0x00AA5464
		public void Continue()
		{
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			bool flag;
			if (sequenceActor == null)
			{
				flag = false;
			}
			else
			{
				ULevelSequencePlayer sequencePlayer = sequenceActor.SequencePlayer;
				flag = ((sequencePlayer != null) ? new bool?(sequencePlayer.IsPaused()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				this.SequenceActor.SequencePlayer.Play();
			}
		}

		// Token: 0x06025F44 RID: 155460 RVA: 0x00AA72B6 File Offset: 0x00AA54B6
		public void SetTransformOrigin(FTransformDouble transform)
		{
			if (this.SequenceActor == null || this.InstanceData == null)
			{
				return;
			}
			this.SequenceActor.bOverrideInstanceData = true;
			this.InstanceData.TransformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(transform);
		}

		// Token: 0x06025F45 RID: 155461 RVA: 0x00AA72E6 File Offset: 0x00AA54E6
		public void SetTransformOriginActor(AActor actor)
		{
			if (this.SequenceActor == null || this.InstanceData == null || actor == null)
			{
				return;
			}
			this.SequenceActor.bOverrideInstanceData = true;
			this.InstanceData.TransformOriginActor = actor;
		}

		// Token: 0x06025F46 RID: 155462 RVA: 0x00AA7314 File Offset: 0x00AA5514
		[NullableContext(1)]
		public void AddEvent(string eventName, Action callback)
		{
			this.EventName = eventName;
			this.EventCallback = callback;
		}

		// Token: 0x06025F47 RID: 155463 RVA: 0x00AA7324 File Offset: 0x00AA5524
		[NullableContext(1)]
		public void ExecuteEvent(string eventName)
		{
			if (this.EventName == eventName)
			{
				Action eventCallback = this.EventCallback;
				if (eventCallback == null)
				{
					return;
				}
				eventCallback();
			}
		}

		// Token: 0x06025F48 RID: 155464 RVA: 0x00AA7344 File Offset: 0x00AA5544
		public void StopSequence(bool notifyInterrupted = true)
		{
			this.SequenceOperationId++;
			object obj = notifyInterrupted ? this.FinishedCallback : null;
			this.FinishedCallback = null;
			this.DestroySequence();
			object obj2 = obj;
			if (obj2 == null)
			{
				return;
			}
			obj2(false);
		}

		// Token: 0x06025F49 RID: 155465 RVA: 0x00AA7378 File Offset: 0x00AA5578
		public override void Clear()
		{
			this.StopSequence(false);
		}

		// Token: 0x06025F4A RID: 155466 RVA: 0x00AA7384 File Offset: 0x00AA5584
		private unsafe bool LoadAndPlay([Nullable(1)] TSoftObjectPtr<ULevelSequence> sequence, float playRate, bool reverse, AActor originActor, Action<bool> onFinished, Action onStarted)
		{
			UiCameraSequenceComponent.<>c__DisplayClass22_0 CS$<>8__locals1 = new UiCameraSequenceComponent.<>c__DisplayClass22_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.sequence = sequence;
			CS$<>8__locals1.playRate = playRate;
			CS$<>8__locals1.reverse = reverse;
			CS$<>8__locals1.originActor = originActor;
			CS$<>8__locals1.onStarted = onStarted;
			TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(CS$<>8__locals1.sequence);
			if (!UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
			{
				return false;
			}
			this.StopSequence(true);
			UiCameraSequenceComponent.<>c__DisplayClass22_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.SequenceOperationId + 1;
			this.SequenceOperationId = num;
			CS$<>8__locals2.operationId = num;
			this.FinishedCallback = onFinished;
			this.LoadHandleId = ResourceSystem.Instance.LoadAsync<ULevelSequence>(CS$<>8__locals1.sequence.ToAssetPathName(), delegate([Nullable(2)] ULevelSequence levelSequence, string _)
			{
				if (CS$<>8__locals1.operationId != CS$<>8__locals1.<>4__this.SequenceOperationId)
				{
					return;
				}
				CS$<>8__locals1.<>4__this.LoadHandleId = 0;
				if (levelSequence == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCamera;
					ELogAuthor author = ELogAuthor.BB;
					string message = "Ui相机Sequence加载失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Sequence", CS$<>8__locals1.sequence.ToAssetPathName());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationId", CS$<>8__locals1.operationId);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					CS$<>8__locals1.<>4__this.Finish(false);
					return;
				}
				CS$<>8__locals1.<>4__this.Play(levelSequence, CS$<>8__locals1.playRate, CS$<>8__locals1.reverse, CS$<>8__locals1.originActor, CS$<>8__locals1.operationId, CS$<>8__locals1.onStarted);
			}, 100, "Ui.UiCamera");
			return true;
		}

		// Token: 0x06025F4B RID: 155467 RVA: 0x00AA7430 File Offset: 0x00AA5630
		private unsafe void Play([Nullable(1)] ULevelSequence sequence, float playRate, bool reverse, AActor originActor, int operationId, Action onStarted)
		{
			ULevelSequencePlayer.CreateLevelSequencePlayer(GlobalData.World, sequence, new FMovieSceneSequencePlaybackSettings(), ref this.SequenceActor);
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			if (((sequenceActor != null) ? sequenceActor.SequencePlayer : null) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Ui相机SequencePlayer创建失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Sequence", sequence.GetName());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OperationId", operationId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.Finish(false);
				return;
			}
			this.SequenceActor.SetSequence(sequence);
			this.SequenceActor.SetTickableWhenPaused(true);
			this.InstanceData = (this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData);
			this.SetTransformOriginActor(originActor);
			this.BindCameras(sequence, operationId);
			ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
			sequencePlayer.SetPlayRate(playRate);
			sequencePlayer.OnFinished.Add(new Action(this.OnFinished));
			if (reverse)
			{
				sequencePlayer.PlayReverse();
			}
			else
			{
				sequencePlayer.Play();
			}
			if (onStarted != null)
			{
				onStarted();
			}
		}

		// Token: 0x06025F4C RID: 155468 RVA: 0x00AA7554 File Offset: 0x00AA5754
		[NullableContext(1)]
		private void BindCameras(ULevelSequence sequence, int operationId)
		{
			if (this.SequenceActor == null)
			{
				return;
			}
			this.SequenceActor.ResetBindings();
			if (sequence.HasBindingTag(UiCameraSequenceComponent.BlackTextureBindingTag, true))
			{
				this.BindBlackScreen(this.SequenceActor, operationId).Forget();
			}
			if (sequence.HasBindingTag(UiCameraSequenceComponent.UiCameraBindingTag, true) && base.Owner.CameraActor != null)
			{
				this.SequenceActor.AddBindingByTag(UiCameraSequenceComponent.UiCameraBindingTag, base.Owner.CameraActor, false, false);
			}
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			ACameraActor acameraActor;
			if (fightCamera == null)
			{
				acameraActor = null;
			}
			else
			{
				FightCameraDisplayComponent component = fightCamera.GetComponent<FightCameraDisplayComponent>();
				acameraActor = ((component != null) ? component.CameraActor : null);
			}
			ACameraActor acameraActor2 = acameraActor;
			if (sequence.HasBindingTag(UiCameraSequenceComponent.FightCameraBindingTag, true) && acameraActor2 != null)
			{
				this.SequenceActor.AddBindingByTag(UiCameraSequenceComponent.FightCameraBindingTag, acameraActor2, false, false);
			}
		}

		// Token: 0x06025F4D RID: 155469 RVA: 0x00AA7619 File Offset: 0x00AA5819
		private void OnFinished()
		{
			this.Finish(true);
		}

		// Token: 0x06025F4E RID: 155470 RVA: 0x00AA7624 File Offset: 0x00AA5824
		private void Finish(bool completed)
		{
			this.SequenceOperationId++;
			Action<bool> finishedCallback = this.FinishedCallback;
			this.FinishedCallback = null;
			if (completed)
			{
				UiCameraNormalMode uiCameraNormalMode = base.Mode as UiCameraNormalMode;
				if (uiCameraNormalMode != null)
				{
					uiCameraNormalMode.RefreshBlendInCameraSequenceOutput();
				}
			}
			this.DestroySequence();
			if (finishedCallback == null)
			{
				return;
			}
			finishedCallback(completed);
		}

		// Token: 0x06025F4F RID: 155471 RVA: 0x00AA7678 File Offset: 0x00AA5878
		private void DestroySequence()
		{
			if (this.LoadHandleId != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandleId);
				this.LoadHandleId = 0;
			}
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			ULevelSequencePlayer ulevelSequencePlayer = (sequenceActor != null) ? sequenceActor.SequencePlayer : null;
			if (ulevelSequencePlayer != null)
			{
				ulevelSequencePlayer.OnFinished.Remove(new Action(this.OnFinished));
				ulevelSequencePlayer.Stop();
			}
			ALevelSequenceActor sequenceActor2 = this.SequenceActor;
			if (sequenceActor2 != null)
			{
				sequenceActor2.SetShouldLatentDestroy(true);
			}
			this.SequenceActor = null;
			this.InstanceData = null;
			this.EventName = string.Empty;
			this.EventCallback = null;
			this.DestroyBlackScreen();
		}

		// Token: 0x06025F50 RID: 155472 RVA: 0x00AA7710 File Offset: 0x00AA5910
		[NullableContext(1)]
		private UniTask BindBlackScreen(ALevelSequenceActor sequenceActor, int operationId)
		{
			UiCameraSequenceComponent.<BindBlackScreen>d__28 <BindBlackScreen>d__;
			<BindBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BindBlackScreen>d__.<>4__this = this;
			<BindBlackScreen>d__.sequenceActor = sequenceActor;
			<BindBlackScreen>d__.operationId = operationId;
			<BindBlackScreen>d__.<>1__state = -1;
			<BindBlackScreen>d__.<>t__builder.Start<UiCameraSequenceComponent.<BindBlackScreen>d__28>(ref <BindBlackScreen>d__);
			return <BindBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x06025F51 RID: 155473 RVA: 0x00AA7763 File Offset: 0x00AA5963
		private void DestroyBlackScreen()
		{
			UiCameraSequenceBlackScreenView blackScreenView = this.BlackScreenView;
			if (blackScreenView != null)
			{
				blackScreenView.Destroy(null);
			}
			this.BlackScreenView = null;
		}

		// Token: 0x04014DF7 RID: 85495
		private static readonly FName UiCameraBindingTag = new FName("UiCamera");

		// Token: 0x04014DF8 RID: 85496
		private static readonly FName FightCameraBindingTag = new FName("FightCamera");

		// Token: 0x04014DF9 RID: 85497
		private static readonly FName BlackTextureBindingTag = new FName("BlackTexture");

		// Token: 0x04014DFA RID: 85498
		private ALevelSequenceActor SequenceActor;

		// Token: 0x04014DFB RID: 85499
		private UDefaultLevelSequenceInstanceData InstanceData;

		// Token: 0x04014DFC RID: 85500
		private Action<bool> FinishedCallback;

		// Token: 0x04014DFD RID: 85501
		private Action EventCallback;

		// Token: 0x04014DFE RID: 85502
		[Nullable(1)]
		private string EventName = string.Empty;

		// Token: 0x04014DFF RID: 85503
		private int LoadHandleId;

		// Token: 0x04014E00 RID: 85504
		private int SequenceOperationId;

		// Token: 0x04014E01 RID: 85505
		private UiCameraSequenceBlackScreenView BlackScreenView;
	}
}
