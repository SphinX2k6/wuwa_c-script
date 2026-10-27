using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C4C RID: 11340
[NullableContext(1)]
[Nullable(0)]
public class UiCameraSequenceComponent : UiCameraComponent
{
	// Token: 0x06017A6D RID: 96877 RVA: 0x00604B72 File Offset: 0x00602D72
	public UiCameraSequenceComponent()
	{
		this.OnUiCameraSequenceFinishedCallbackList = new List<Action>();
	}

	// Token: 0x06017A6E RID: 96878 RVA: 0x00604B85 File Offset: 0x00602D85
	protected override void OnDestroy()
	{
		this.DestroyUiCameraSequence(true, ERestoreStateType.NotSet);
	}

	// Token: 0x06017A6F RID: 96879 RVA: 0x00604B90 File Offset: 0x00602D90
	public void PlayUiCameraSequence(ULevelSequence levelSequence, float playRate = 1f, bool bReverse = false, bool bAutoDestroyBlackScreen = true, [Nullable(2)] AActor originActor = null)
	{
		this.SequenceActor = this.CreateLevelSequenceActor(levelSequence);
		if (this.SequenceActor == null)
		{
			return;
		}
		this.SequenceActor.bOverrideInstanceData = false;
		this.LevelSequenceInstanceData = (this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData);
		this.SequenceActor.SetTickableWhenPaused(true);
		this.SetTransformOriginActor(originActor);
		this.TryAddBindUiCameraSequence(this.SequenceActor);
		this.IsAutoDestroyBlackScreen = bAutoDestroyBlackScreen;
		ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
		sequencePlayer.SetPlayRate(playRate);
		sequencePlayer.OnFinished.Add(new Action(this.OnUiCameraSequenceFinished));
		sequencePlayer.OnStop.Add(new Action(this.OnUiCameraSequenceStop));
		sequencePlayer.OnPlay.Add(new Action(this.OnUiCameraSequencePlay));
		sequencePlayer.OnPlayReverse.Add(new Action(this.OnUiCameraSequenceOnPlayReverse));
		if (bReverse)
		{
			sequencePlayer.PlayReverse();
			return;
		}
		sequencePlayer.Play();
	}

	// Token: 0x06017A70 RID: 96880 RVA: 0x00604C7C File Offset: 0x00602E7C
	public UniTask LoadAndPlayUiCameraSequence(TSoftObjectPtr<ULevelSequence> sequenceSoftObjectPtr, float playRate, bool bReverse, [Nullable(2)] AActor originActor = null)
	{
		UiCameraSequenceComponent.<LoadAndPlayUiCameraSequence>d__12 <LoadAndPlayUiCameraSequence>d__;
		<LoadAndPlayUiCameraSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadAndPlayUiCameraSequence>d__.<>4__this = this;
		<LoadAndPlayUiCameraSequence>d__.sequenceSoftObjectPtr = sequenceSoftObjectPtr;
		<LoadAndPlayUiCameraSequence>d__.playRate = playRate;
		<LoadAndPlayUiCameraSequence>d__.bReverse = bReverse;
		<LoadAndPlayUiCameraSequence>d__.originActor = originActor;
		<LoadAndPlayUiCameraSequence>d__.<>1__state = -1;
		<LoadAndPlayUiCameraSequence>d__.<>t__builder.Start<UiCameraSequenceComponent.<LoadAndPlayUiCameraSequence>d__12>(ref <LoadAndPlayUiCameraSequence>d__);
		return <LoadAndPlayUiCameraSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06017A71 RID: 96881 RVA: 0x00604CE0 File Offset: 0x00602EE0
	public void Pause()
	{
		ALevelSequenceActor sequenceActor = this.SequenceActor;
		if (sequenceActor == null || !sequenceActor.IsValid())
		{
			return;
		}
		ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
		if (sequencePlayer == null || !sequencePlayer.IsValid())
		{
			return;
		}
		sequencePlayer.Pause();
	}

	// Token: 0x06017A72 RID: 96882 RVA: 0x00604D2C File Offset: 0x00602F2C
	public void Continue()
	{
		ALevelSequenceActor sequenceActor = this.SequenceActor;
		if (sequenceActor == null || !sequenceActor.IsValid())
		{
			return;
		}
		ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
		if (sequencePlayer == null || !sequencePlayer.IsValid())
		{
			return;
		}
		if (sequencePlayer.IsPaused())
		{
			sequencePlayer.Play();
		}
	}

	// Token: 0x06017A73 RID: 96883 RVA: 0x00604D7D File Offset: 0x00602F7D
	public void DestroyUiCameraSequence(bool bDestroyBlackScreen = true, ERestoreStateType restoreStateType = ERestoreStateType.NotSet)
	{
		this.StopUiCameraSequence(bDestroyBlackScreen, restoreStateType);
		this.DestroySequenceActor();
	}

	// Token: 0x06017A74 RID: 96884 RVA: 0x00604D90 File Offset: 0x00602F90
	private void FinishUiCameraSequence()
	{
		for (int i = 0; i < this.OnUiCameraSequenceFinishedCallbackList.Count; i++)
		{
			this.OnUiCameraSequenceFinishedCallbackList[i]();
		}
		this.DestroyUiCameraSequence(this.IsAutoDestroyBlackScreen, ERestoreStateType.NotSet);
	}

	// Token: 0x06017A75 RID: 96885 RVA: 0x00604DD4 File Offset: 0x00602FD4
	private void StopUiCameraSequence(bool bDestroyBlackScreen = true, ERestoreStateType restoreStateType = ERestoreStateType.NotSet)
	{
		if (this.SequenceActor != null)
		{
			ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
			if (restoreStateType != ERestoreStateType.NotSet)
			{
				sequencePlayer.PlaybackSettings.bRestoreState = (restoreStateType == ERestoreStateType.Restore);
			}
			sequencePlayer.Stop();
		}
		if (bDestroyBlackScreen)
		{
			this.DestroyBlackScreenView();
		}
		if (this.LoadSequenceHandleId != 0)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadSequenceHandleId);
			this.LoadSequenceHandleId = 0;
		}
	}

	// Token: 0x06017A76 RID: 96886 RVA: 0x00604E35 File Offset: 0x00603035
	private void DestroySequenceActor()
	{
		ALevelSequenceActor sequenceActor = this.SequenceActor;
		if (sequenceActor != null)
		{
			sequenceActor.SetShouldLatentDestroy(true);
		}
		this.SequenceActor = null;
		this.OnUiCameraSequenceFinishedCallbackList.Clear();
		this.OnCallUiCameraSequenceEvent = null;
		this.UiCameraSequenceEventName = null;
	}

	// Token: 0x06017A77 RID: 96887 RVA: 0x00604E69 File Offset: 0x00603069
	public void ExecuteUiCameraSequenceEvent(string eventName)
	{
		if (this.OnCallUiCameraSequenceEvent == null)
		{
			return;
		}
		if (this.UiCameraSequenceEventName != eventName)
		{
			return;
		}
		this.OnCallUiCameraSequenceEvent();
	}

	// Token: 0x06017A78 RID: 96888 RVA: 0x00604E90 File Offset: 0x00603090
	public void SetTransformOrigin(FTransformDouble transform)
	{
		if (this.LevelSequenceInstanceData == null)
		{
			return;
		}
		this.SequenceActor.bOverrideInstanceData = true;
		FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(transform);
		this.LevelSequenceInstanceData.TransformOrigin = transformOrigin;
	}

	// Token: 0x06017A79 RID: 96889 RVA: 0x00604EC5 File Offset: 0x006030C5
	[NullableContext(2)]
	public void SetTransformOriginActor(AActor actor)
	{
		if (this.LevelSequenceInstanceData == null)
		{
			return;
		}
		this.SequenceActor.bOverrideInstanceData = true;
		this.LevelSequenceInstanceData.TransformOriginActor = actor;
	}

	// Token: 0x06017A7A RID: 96890 RVA: 0x00604EE8 File Offset: 0x006030E8
	public void AddUiCameraSequenceEvent(string eventName, Action callback)
	{
		this.UiCameraSequenceEventName = eventName;
		this.OnCallUiCameraSequenceEvent = callback;
	}

	// Token: 0x06017A7B RID: 96891 RVA: 0x00604EF8 File Offset: 0x006030F8
	public void AddUiCameraSequenceFinishedCallback(Action onUiCameraSequenceFinishedCallback)
	{
		if (onUiCameraSequenceFinishedCallback == null)
		{
			return;
		}
		this.OnUiCameraSequenceFinishedCallbackList.Add(onUiCameraSequenceFinishedCallback);
	}

	// Token: 0x06017A7C RID: 96892 RVA: 0x00604F0A File Offset: 0x0060310A
	private void OnUiCameraSequencePlay()
	{
		this.WaitPlayPromise.SetResult();
	}

	// Token: 0x06017A7D RID: 96893 RVA: 0x00604F17 File Offset: 0x00603117
	private void OnUiCameraSequenceOnPlayReverse()
	{
		this.WaitPlayPromise.SetResult();
	}

	// Token: 0x06017A7E RID: 96894 RVA: 0x00604F24 File Offset: 0x00603124
	private void OnUiCameraSequenceFinished()
	{
		this.FinishUiCameraSequence();
	}

	// Token: 0x06017A7F RID: 96895 RVA: 0x00604F2C File Offset: 0x0060312C
	private void OnUiCameraSequenceStop()
	{
		if (this.IsAutoDestroyBlackScreen)
		{
			this.DestroyBlackScreenView();
		}
	}

	// Token: 0x06017A80 RID: 96896 RVA: 0x00604F3C File Offset: 0x0060313C
	private ALevelSequenceActor CreateLevelSequenceActor(ULevelSequence levelSequence)
	{
		ALevelSequenceActor alevelSequenceActor = null;
		ULevelSequencePlayer.CreateLevelSequencePlayer(GlobalData.World, levelSequence, new FMovieSceneSequencePlaybackSettings(), ref alevelSequenceActor);
		alevelSequenceActor.SetSequence(levelSequence);
		return alevelSequenceActor;
	}

	// Token: 0x06017A81 RID: 96897 RVA: 0x00604F68 File Offset: 0x00603168
	private void TryAddBindUiCameraSequence(ALevelSequenceActor sequenceActor)
	{
		sequenceActor.ResetBindings();
		ULevelSequence sequence = sequenceActor.GetSequence();
		if (sequence.HasBindingTag(UiCameraSequenceDefine.BLACK_TEXTURE_TAG, true))
		{
			this.NewBlackScreenView().ContinueWith(delegate(BlackScreenView blackScreenView)
			{
				AActor blackScreenTextureActor = blackScreenView.GetBlackScreenTextureActor();
				sequenceActor.AddBindingByTag(UiCameraSequenceDefine.BLACK_TEXTURE_TAG, blackScreenTextureActor, false, false);
			});
		}
		if (sequence.HasBindingTag(UiCameraSequenceDefine.UI_CAMERA, true))
		{
			sequenceActor.AddBindingByTag(UiCameraSequenceDefine.UI_CAMERA, this.CameraActor, false, false);
		}
		if (sequence.HasBindingTag(UiCameraSequenceDefine.FIGHT_CAMERA, true))
		{
			ACameraActor cameraActor = CameraController.Instance.MainModel.FightCamera.GetComponent<FightCameraDisplayComponent>().CameraActor;
			sequenceActor.AddBindingByTag(UiCameraSequenceDefine.FIGHT_CAMERA, cameraActor, false, false);
		}
	}

	// Token: 0x06017A82 RID: 96898 RVA: 0x00605020 File Offset: 0x00603220
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<BlackScreenView> NewBlackScreenView()
	{
		UiCameraSequenceComponent.<NewBlackScreenView>d__30 <NewBlackScreenView>d__;
		<NewBlackScreenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<BlackScreenView>.Create();
		<NewBlackScreenView>d__.<>4__this = this;
		<NewBlackScreenView>d__.<>1__state = -1;
		<NewBlackScreenView>d__.<>t__builder.Start<UiCameraSequenceComponent.<NewBlackScreenView>d__30>(ref <NewBlackScreenView>d__);
		return <NewBlackScreenView>d__.<>t__builder.Task;
	}

	// Token: 0x06017A83 RID: 96899 RVA: 0x00605063 File Offset: 0x00603263
	public void DestroyBlackScreenView()
	{
		if (this.BlackScreenViewInternal == null)
		{
			return;
		}
		this.BlackScreenViewInternal.Destroy(null);
		this.BlackScreenViewInternal = null;
	}

	// Token: 0x0400B05A RID: 45146
	[Nullable(2)]
	private ALevelSequenceActor SequenceActor;

	// Token: 0x0400B05B RID: 45147
	[Nullable(2)]
	private UDefaultLevelSequenceInstanceData LevelSequenceInstanceData;

	// Token: 0x0400B05C RID: 45148
	[Nullable(2)]
	private BlackScreenView BlackScreenViewInternal;

	// Token: 0x0400B05D RID: 45149
	private readonly List<Action> OnUiCameraSequenceFinishedCallbackList;

	// Token: 0x0400B05E RID: 45150
	private bool IsAutoDestroyBlackScreen;

	// Token: 0x0400B05F RID: 45151
	[Nullable(2)]
	private Action OnCallUiCameraSequenceEvent;

	// Token: 0x0400B060 RID: 45152
	[Nullable(2)]
	private string UiCameraSequenceEventName;

	// Token: 0x0400B061 RID: 45153
	private int LoadSequenceHandleId;

	// Token: 0x0400B062 RID: 45154
	[Nullable(2)]
	private CustomPromise WaitPlayPromise;
}
