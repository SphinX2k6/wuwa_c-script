using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200322B RID: 12843
[NullableContext(2)]
[Nullable(0)]
public class NpcPerformSequence
{
	// Token: 0x0601BB10 RID: 113424 RVA: 0x0079D3D0 File Offset: 0x0079B5D0
	public void Destroy()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null && levelSequencePlayer.IsValid() && this.LevelSequencePlayer.IsPlaying())
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.WLJ, "[CollectionItemDisplay]开始销毁Npc表现Sequence时，Sequence仍在播放，等播放完成后销毁", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.LevelSequencePlayer.OnFinished.Clear();
			this.LevelSequencePlayer.OnFinished.Add(new Action(this.OnDestroyedWhenFinished));
			return;
		}
		Log.Instance.Info(ELogModule.NPC, ELogAuthor.WLJ, "[CollectionItemDisplay]开始销毁Npc表现Sequence", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.DestroyInternal();
	}

	// Token: 0x0601BB11 RID: 113425 RVA: 0x0079D470 File Offset: 0x0079B670
	private void DestroyInternal()
	{
		if (this.LoadSequenceHandleId != null)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadSequenceHandleId.Value);
			this.LoadSequenceHandleId = null;
		}
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null && levelSequencePlayer.IsValid())
		{
			this.LevelSequencePlayer.Stop();
			this.LevelSequencePlayer.OnFinished.Clear();
			this.LevelSequencePlayer = null;
		}
		ALevelSequenceActor levelSequenceActor = this.LevelSequenceActor;
		if (levelSequenceActor != null && levelSequenceActor.IsValid())
		{
			ALevelSequenceActor tmp = this.LevelSequenceActor;
			TimerSystem.Instance.Next(delegate(float _)
			{
				ActorSystem.Instance.Put("NpcPerformSequence.DestroyInternal", tmp, null);
			}, null, null);
			this.LevelSequenceActor = null;
		}
		this.LevelSequenceInstanceData = null;
		this.OnFinishedCallback = null;
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
	}

	// Token: 0x0601BB12 RID: 113426 RVA: 0x0079D553 File Offset: 0x0079B753
	private void OnDestroyedWhenFinished()
	{
		this.Finish();
		this.DestroyInternal();
	}

	// Token: 0x0601BB13 RID: 113427 RVA: 0x0079D564 File Offset: 0x0079B764
	[NullableContext(1)]
	public void SetTransformOriginEntity(Entity entity)
	{
		AActor owner = entity.GetComponent<BaseActorComponent>().Owner;
		this.SetTransformOriginActor(owner);
	}

	// Token: 0x0601BB14 RID: 113428 RVA: 0x0079D584 File Offset: 0x0079B784
	[NullableContext(1)]
	public void SetTransformOriginActor(AActor actor)
	{
		if (this.LevelSequenceInstanceData == null)
		{
			return;
		}
		this.LevelSequenceActor.bOverrideInstanceData = true;
		this.LevelSequenceInstanceData.TransformOriginActor = actor;
	}

	// Token: 0x0601BB15 RID: 113429 RVA: 0x0079D5A8 File Offset: 0x0079B7A8
	[NullableContext(1)]
	public void Load(string sequencePath, [Nullable(2)] Action onLoaded = null)
	{
		if (this.SequencePath == sequencePath && this.IsValid())
		{
			if (onLoaded != null)
			{
				onLoaded();
			}
			return;
		}
		this.SequencePath = sequencePath;
		this.LoadSequenceHandleId = new int?(ResourceSystem.Instance.LoadAsync<ULevelSequence>(this.SequencePath, delegate([Nullable(2)] ULevelSequence levelSequence, string _)
		{
			this.CreateLevelSequence(levelSequence);
			if (onLoaded != null)
			{
				onLoaded();
			}
		}, 100, "js_undefined"));
	}

	// Token: 0x0601BB16 RID: 113430 RVA: 0x0079D628 File Offset: 0x0079B828
	public void Play(Action onFinished = null)
	{
		if (!this.IsValid())
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.WLJ, "[CollectionItemDisplay]尝试播放Npc表现Sequence时，LevelSequencePlayer为空或不可用", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.IsPlaying())
		{
			Log.Instance.Info(ELogModule.NPC, ELogAuthor.WLJ, "[CollectionItemDisplay]尝试播放Npc表现Sequence时，Sequence正在播放中,停止后重新播放", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.StopInternal();
		}
		BP_CineCamera_C cineCamera = CameraController.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera;
		cineCamera.ResetSeqCineCamSetting();
		this.AddBindingByTag(this.sequenceCameraTag, cineCamera);
		CameraController.Instance.EnterCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, false, "MainCamera", null);
		this.PlayInternal(onFinished);
		EventSystem.Instance.Emit(EEventName.OnPlayNpcPerformSequence);
	}

	// Token: 0x0601BB17 RID: 113431 RVA: 0x0079D6ED File Offset: 0x0079B8ED
	public void AddBindingByTag(FName tag, AActor actor)
	{
		this.LevelSequenceActor.AddBindingByTag(tag, actor, false, true);
	}

	// Token: 0x0601BB18 RID: 113432 RVA: 0x0079D700 File Offset: 0x0079B900
	private void CreateLevelSequence(ULevelSequence levelSequence)
	{
		this.LevelSequenceActor = ActorSystem.Instance.Get<ALevelSequenceActor>(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null, false);
		this.LevelSequenceActor.SetSequence(levelSequence);
		this.LevelSequencePlayer = this.LevelSequenceActor.SequencePlayer;
		this.LevelSequenceInstanceData = (this.LevelSequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData);
		this.LevelSequenceActor.bOverrideInstanceData = true;
		FVector fvector = new FVector(0f);
		if (levelSequence.GetCenterOffset(ref fvector))
		{
			this.LevelSequenceInstanceData.TransformOrigin = new FTransform(ref fvector);
			return;
		}
		this.LevelSequenceInstanceData.TransformOrigin = new FTransform();
	}

	// Token: 0x0601BB19 RID: 113433 RVA: 0x0079D7A4 File Offset: 0x0079B9A4
	private void PlayInternal(Action onFinished = null)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "[CollectionItemDisplay]开始播放Npc表现Sequence";
		string item = "SequenceName";
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (levelSequencePlayer != null) ? levelSequencePlayer.Sequence : null);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.OnFinishedCallback = onFinished;
		this.LevelSequencePlayer.OnFinished.Add(new Action(this.OnFinished));
		this.LevelSequencePlayer.Play();
	}

	// Token: 0x0601BB1A RID: 113434 RVA: 0x0079D81C File Offset: 0x0079BA1C
	public void Stop()
	{
		Log.Instance.Info(ELogModule.NPC, ELogAuthor.WLJ, "[CollectionItemDisplay]Npc表现Sequence被停止", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.StopInternal();
	}

	// Token: 0x0601BB1B RID: 113435 RVA: 0x0079D850 File Offset: 0x0079BA50
	private void StopInternal()
	{
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null || !levelSequencePlayer.IsValid())
		{
			return;
		}
		this.LevelSequencePlayer.Stop();
	}

	// Token: 0x0601BB1C RID: 113436 RVA: 0x0079D89E File Offset: 0x0079BA9E
	public void Pause()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null || !levelSequencePlayer.IsValid())
		{
			return;
		}
		this.LevelSequencePlayer.Pause();
	}

	// Token: 0x0601BB1D RID: 113437 RVA: 0x0079D8C3 File Offset: 0x0079BAC3
	public void Continue()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null || !levelSequencePlayer.IsValid())
		{
			return;
		}
		this.LevelSequencePlayer.Play();
	}

	// Token: 0x0601BB1E RID: 113438 RVA: 0x0079D8E8 File Offset: 0x0079BAE8
	public bool IsPlaying()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		return levelSequencePlayer != null && levelSequencePlayer.IsValid() && this.LevelSequencePlayer.IsPlaying();
	}

	// Token: 0x0601BB1F RID: 113439 RVA: 0x0079D90E File Offset: 0x0079BB0E
	public bool IsValid()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		return levelSequencePlayer != null && levelSequencePlayer.IsValid();
	}

	// Token: 0x0601BB20 RID: 113440 RVA: 0x0079D924 File Offset: 0x0079BB24
	private void OnFinished()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "[CollectionItemDisplay]Npc表现Sequence播放完成";
		string item = "SequenceName";
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (levelSequencePlayer != null) ? levelSequencePlayer.Sequence : null);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.Finish();
	}

	// Token: 0x0601BB21 RID: 113441 RVA: 0x0079D974 File Offset: 0x0079BB74
	private void Finish()
	{
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		if (this.OnFinishedCallback != null)
		{
			this.OnFinishedCallback();
		}
		EventSystem.Instance.Emit(EEventName.OnNpcPerformSequenceFinished);
	}

	// Token: 0x0400DA0A RID: 55818
	private readonly FName sequenceCameraTag = new FName("SequenceCamera");

	// Token: 0x0400DA0B RID: 55819
	[Nullable(1)]
	private string SequencePath = "";

	// Token: 0x0400DA0C RID: 55820
	private int? LoadSequenceHandleId;

	// Token: 0x0400DA0D RID: 55821
	private ULevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400DA0E RID: 55822
	private ALevelSequenceActor LevelSequenceActor;

	// Token: 0x0400DA0F RID: 55823
	private UDefaultLevelSequenceInstanceData LevelSequenceInstanceData;

	// Token: 0x0400DA10 RID: 55824
	private Action OnFinishedCallback;
}
