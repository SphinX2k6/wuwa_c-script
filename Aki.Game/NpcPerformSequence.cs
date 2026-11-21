using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200279A RID: 10138
[NullableContext(2)]
[Nullable(0)]
public class NpcPerformSequence
{
	// Token: 0x06019695 RID: 104085 RVA: 0x007C5B6C File Offset: 0x007C3D6C
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

	// Token: 0x06019696 RID: 104086 RVA: 0x007C5C0C File Offset: 0x007C3E0C
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

	// Token: 0x06019697 RID: 104087 RVA: 0x007C5CEF File Offset: 0x007C3EEF
	private void OnDestroyedWhenFinished()
	{
		this.Finish();
		this.DestroyInternal();
	}

	// Token: 0x06019698 RID: 104088 RVA: 0x007C5D00 File Offset: 0x007C3F00
	[NullableContext(1)]
	public void SetTransformOriginEntity(Entity entity)
	{
		AActor owner = entity.GetComponent<BaseActorComponent>().Owner;
		this.SetTransformOriginActor(owner);
	}

	// Token: 0x06019699 RID: 104089 RVA: 0x007C5D20 File Offset: 0x007C3F20
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

	// Token: 0x0601969A RID: 104090 RVA: 0x007C5D44 File Offset: 0x007C3F44
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

	// Token: 0x0601969B RID: 104091 RVA: 0x007C5DC4 File Offset: 0x007C3FC4
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

	// Token: 0x0601969C RID: 104092 RVA: 0x007C5E89 File Offset: 0x007C4089
	public void AddBindingByTag(FName tag, AActor actor)
	{
		this.LevelSequenceActor.AddBindingByTag(tag, actor, false, true);
	}

	// Token: 0x0601969D RID: 104093 RVA: 0x007C5E9C File Offset: 0x007C409C
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

	// Token: 0x0601969E RID: 104094 RVA: 0x007C5F40 File Offset: 0x007C4140
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

	// Token: 0x0601969F RID: 104095 RVA: 0x007C5FB8 File Offset: 0x007C41B8
	public void Stop()
	{
		Log.Instance.Info(ELogModule.NPC, ELogAuthor.WLJ, "[CollectionItemDisplay]Npc表现Sequence被停止", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.StopInternal();
	}

	// Token: 0x060196A0 RID: 104096 RVA: 0x007C5FEC File Offset: 0x007C41EC
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

	// Token: 0x060196A1 RID: 104097 RVA: 0x007C603A File Offset: 0x007C423A
	public void Pause()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null || !levelSequencePlayer.IsValid())
		{
			return;
		}
		this.LevelSequencePlayer.Pause();
	}

	// Token: 0x060196A2 RID: 104098 RVA: 0x007C605F File Offset: 0x007C425F
	public void Continue()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null || !levelSequencePlayer.IsValid())
		{
			return;
		}
		this.LevelSequencePlayer.Play();
	}

	// Token: 0x060196A3 RID: 104099 RVA: 0x007C6084 File Offset: 0x007C4284
	public bool IsPlaying()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		return levelSequencePlayer != null && levelSequencePlayer.IsValid() && this.LevelSequencePlayer.IsPlaying();
	}

	// Token: 0x060196A4 RID: 104100 RVA: 0x007C60AA File Offset: 0x007C42AA
	public bool IsValid()
	{
		ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		return levelSequencePlayer != null && levelSequencePlayer.IsValid();
	}

	// Token: 0x060196A5 RID: 104101 RVA: 0x007C60C0 File Offset: 0x007C42C0
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

	// Token: 0x060196A6 RID: 104102 RVA: 0x007C6110 File Offset: 0x007C4310
	private void Finish()
	{
		CameraController.Instance.ExitCameraMode(ECustomCameraMode.Sequence, 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, "MainCamera", null);
		if (this.OnFinishedCallback != null)
		{
			this.OnFinishedCallback();
		}
		EventSystem.Instance.Emit(EEventName.OnNpcPerformSequenceFinished);
	}

	// Token: 0x0400DEA9 RID: 57001
	private readonly FName sequenceCameraTag = new FName("SequenceCamera");

	// Token: 0x0400DEAA RID: 57002
	[Nullable(1)]
	private string SequencePath = "";

	// Token: 0x0400DEAB RID: 57003
	private int? LoadSequenceHandleId;

	// Token: 0x0400DEAC RID: 57004
	private ULevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400DEAD RID: 57005
	private ALevelSequenceActor LevelSequenceActor;

	// Token: 0x0400DEAE RID: 57006
	private UDefaultLevelSequenceInstanceData LevelSequenceInstanceData;

	// Token: 0x0400DEAF RID: 57007
	private Action OnFinishedCallback;
}
