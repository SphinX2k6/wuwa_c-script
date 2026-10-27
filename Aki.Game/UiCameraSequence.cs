using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C38 RID: 11320
[NullableContext(1)]
[Nullable(0)]
public class UiCameraSequence
{
	// Token: 0x060179D9 RID: 96729 RVA: 0x00602AE0 File Offset: 0x00600CE0
	public void InitializeUiCameraSequence(ULevelSequence levelSequence)
	{
		this.SequenceActor = this.CreateLevelSequenceActor(levelSequence);
		this.SequenceActor.bOverrideInstanceData = false;
		this.LevelSequenceInstanceData = (this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData);
		this.TryAddBindUiCameraSequence(this.SequenceActor);
	}

	// Token: 0x060179DA RID: 96730 RVA: 0x00602B20 File Offset: 0x00600D20
	public void PlayUiCameraSequence(float playRate, bool bReverse = false, bool bAutoDestroyBlackScreen = true)
	{
		if (this.SequenceActor == null)
		{
			return;
		}
		this.IsAutoDestroyBlackScreen = bAutoDestroyBlackScreen;
		ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.SetPlayRate(playRate);
		sequencePlayer.OnFinished.Add(new Action(this.OnUiCameraSequenceFinished));
		if (bReverse)
		{
			sequencePlayer.PlayReverse();
			return;
		}
		sequencePlayer.Play();
	}

	// Token: 0x060179DB RID: 96731 RVA: 0x00602B7C File Offset: 0x00600D7C
	public void Pause()
	{
		if (this.SequenceActor == null || !this.SequenceActor.IsValid())
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

	// Token: 0x060179DC RID: 96732 RVA: 0x00602BC0 File Offset: 0x00600DC0
	public void Continue()
	{
		if (this.SequenceActor == null || !this.SequenceActor.IsValid())
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

	// Token: 0x060179DD RID: 96733 RVA: 0x00602C09 File Offset: 0x00600E09
	public void DestroyUiCameraSequence(bool bDestroyBlackScreen = true)
	{
		this.StopUiCameraSequence();
		this.DestroySequenceActor();
		if (bDestroyBlackScreen)
		{
			this.DestroyBlackScreenView();
		}
		this.OnUiCameraSequenceFinishedCallbackList.Clear();
		this.OnCallUiCameraSequenceEvent = null;
		this.UiCameraSequenceEventName = null;
	}

	// Token: 0x060179DE RID: 96734 RVA: 0x00602C3C File Offset: 0x00600E3C
	private void FinishUiCameraSequence()
	{
		foreach (Action<UiCameraSequence> action in this.OnUiCameraSequenceFinishedCallbackList)
		{
			action(this);
		}
		this.DestroyUiCameraSequence(this.IsAutoDestroyBlackScreen);
	}

	// Token: 0x060179DF RID: 96735 RVA: 0x00602C9C File Offset: 0x00600E9C
	private void StopUiCameraSequence()
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
		sequencePlayer.Stop();
	}

	// Token: 0x060179E0 RID: 96736 RVA: 0x00602CB8 File Offset: 0x00600EB8
	private void DestroySequenceActor()
	{
		if (this.SequenceActor == null)
		{
			return;
		}
		this.SequenceActor.SetShouldLatentDestroy(true);
		this.SequenceActor = null;
	}

	// Token: 0x060179E1 RID: 96737 RVA: 0x00602CD6 File Offset: 0x00600ED6
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

	// Token: 0x060179E2 RID: 96738 RVA: 0x00602CFC File Offset: 0x00600EFC
	public void SetTransformOrigin(FTransformDouble transform)
	{
		if (this.LevelSequenceInstanceData == null || this.SequenceActor == null)
		{
			return;
		}
		this.SequenceActor.bOverrideInstanceData = true;
		FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(transform);
		this.LevelSequenceInstanceData.TransformOrigin = transformOrigin;
	}

	// Token: 0x060179E3 RID: 96739 RVA: 0x00602D39 File Offset: 0x00600F39
	public void SetTransformOriginActor(AActor actor)
	{
		if (this.LevelSequenceInstanceData == null || this.SequenceActor == null)
		{
			return;
		}
		this.SequenceActor.bOverrideInstanceData = true;
		this.LevelSequenceInstanceData.TransformOriginActor = actor;
	}

	// Token: 0x060179E4 RID: 96740 RVA: 0x00602D64 File Offset: 0x00600F64
	public void AddUiCameraSequenceEvent(string eventName, Action callback)
	{
		this.UiCameraSequenceEventName = eventName;
		this.OnCallUiCameraSequenceEvent = callback;
	}

	// Token: 0x060179E5 RID: 96741 RVA: 0x00602D74 File Offset: 0x00600F74
	public void AddUiCameraSequenceFinishedCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<UiCameraSequence> callback)
	{
		if (callback == null)
		{
			return;
		}
		this.OnUiCameraSequenceFinishedCallbackList.Add(callback);
	}

	// Token: 0x060179E6 RID: 96742 RVA: 0x00602D86 File Offset: 0x00600F86
	private void OnUiCameraSequenceFinished()
	{
		this.FinishUiCameraSequence();
	}

	// Token: 0x060179E7 RID: 96743 RVA: 0x00602D90 File Offset: 0x00600F90
	[return: Nullable(2)]
	private ALevelSequenceActor CreateLevelSequenceActor(ULevelSequence levelSequence)
	{
		ALevelSequenceActor result = new ALevelSequenceActor();
		ULevelSequencePlayer.CreateLevelSequencePlayer(GlobalData.World, levelSequence, new FMovieSceneSequencePlaybackSettings(), ref result);
		return result;
	}

	// Token: 0x060179E8 RID: 96744 RVA: 0x00602DB8 File Offset: 0x00600FB8
	private UniTask TryAddBindUiCameraSequence(ALevelSequenceActor sequenceActor)
	{
		UiCameraSequence.<TryAddBindUiCameraSequence>d__25 <TryAddBindUiCameraSequence>d__;
		<TryAddBindUiCameraSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryAddBindUiCameraSequence>d__.<>4__this = this;
		<TryAddBindUiCameraSequence>d__.sequenceActor = sequenceActor;
		<TryAddBindUiCameraSequence>d__.<>1__state = -1;
		<TryAddBindUiCameraSequence>d__.<>t__builder.Start<UiCameraSequence.<TryAddBindUiCameraSequence>d__25>(ref <TryAddBindUiCameraSequence>d__);
		return <TryAddBindUiCameraSequence>d__.<>t__builder.Task;
	}

	// Token: 0x060179E9 RID: 96745 RVA: 0x00602E04 File Offset: 0x00601004
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<BlackScreenView> NewBlackScreenView()
	{
		UiCameraSequence.<NewBlackScreenView>d__26 <NewBlackScreenView>d__;
		<NewBlackScreenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<BlackScreenView>.Create();
		<NewBlackScreenView>d__.<>4__this = this;
		<NewBlackScreenView>d__.<>1__state = -1;
		<NewBlackScreenView>d__.<>t__builder.Start<UiCameraSequence.<NewBlackScreenView>d__26>(ref <NewBlackScreenView>d__);
		return <NewBlackScreenView>d__.<>t__builder.Task;
	}

	// Token: 0x060179EA RID: 96746 RVA: 0x00602E47 File Offset: 0x00601047
	public void DestroyBlackScreenView()
	{
		if (this.BlackScreenViewInternal == null)
		{
			return;
		}
		this.BlackScreenViewInternal.Destroy(null);
		this.BlackScreenViewInternal = null;
	}

	// Token: 0x0400B019 RID: 45081
	private static readonly FName BLACK_TEXTURE_TAG = new FName("BlackTexture");

	// Token: 0x0400B01A RID: 45082
	private static readonly FName UI_CAMERA = new FName("UiCamera");

	// Token: 0x0400B01B RID: 45083
	private static readonly FName FIGHT_CAMERA = new FName("FightCamera");

	// Token: 0x0400B01C RID: 45084
	[Nullable(2)]
	private ALevelSequenceActor SequenceActor;

	// Token: 0x0400B01D RID: 45085
	[Nullable(2)]
	private UDefaultLevelSequenceInstanceData LevelSequenceInstanceData;

	// Token: 0x0400B01E RID: 45086
	[Nullable(2)]
	private BlackScreenView BlackScreenViewInternal;

	// Token: 0x0400B01F RID: 45087
	[Nullable(new byte[]
	{
		1,
		2,
		1
	})]
	private readonly List<Action<UiCameraSequence>> OnUiCameraSequenceFinishedCallbackList = new List<Action<UiCameraSequence>>();

	// Token: 0x0400B020 RID: 45088
	private bool IsAutoDestroyBlackScreen;

	// Token: 0x0400B021 RID: 45089
	[Nullable(2)]
	private Action OnCallUiCameraSequenceEvent;

	// Token: 0x0400B022 RID: 45090
	[Nullable(2)]
	private string UiCameraSequenceEventName;
}
