using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002CB0 RID: 11440
[NullableContext(2)]
[Nullable(0)]
public class UiRoleHuluLightSequenceComponent : UiModelComponentBase, IUiModelVisible
{
	// Token: 0x06017E75 RID: 97909 RVA: 0x00613890 File Offset: 0x00611A90
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x06017E76 RID: 97910 RVA: 0x006138A4 File Offset: 0x00611AA4
	private void CreateLevelSequencePlayer()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("LevelSequence_HuluLight");
		this.HandleId = ResourceSystem.Instance.LoadAsync<ULevelSequence>(resourcePath, delegate([Nullable(2)] ULevelSequence levelSequenceObject, string _)
		{
			if (ObjectUtils.IsValid(levelSequenceObject))
			{
				FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
				fmovieSceneSequencePlaybackSettings.bRestoreState = true;
				fmovieSceneSequencePlaybackSettings.bPauseAtEnd = true;
				this.SequenceActor = (ActorSystem.Instance.Spawn(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null) as ALevelSequenceActor);
				this.SequenceActor.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
				this.SequenceActor.SetSequence(levelSequenceObject);
				this.LevelSequencePlayer = this.SequenceActor.SequencePlayer;
				if (this.LevelSequencePlayer != null)
				{
					this.PlayLightSequence();
				}
			}
		}, 100, "Ui.UiSceneModel");
	}

	// Token: 0x06017E77 RID: 97911 RVA: 0x006138E8 File Offset: 0x00611AE8
	public void PlayLightSequence()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.SequenceActor.bOverrideInstanceData = true;
			UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
			Vector location = Transform.Create(this.ActorComponent.MainMeshComponent.D_GetSocketTransform(CharacterNameDefines.Instance.GLIDEING_SOCKETNAME, ERelativeTransformSpace.RTS_World)).GetLocation();
			Transform transform = Transform.Create();
			transform.SetLocation(location);
			udefaultLevelSequenceInstanceData.TransformOrigin = transform.ToUeTransformOld();
			this.LevelSequencePlayer.Play();
			return;
		}
		if (this.HandleId == -1)
		{
			this.CreateLevelSequencePlayer();
		}
	}

	// Token: 0x06017E78 RID: 97912 RVA: 0x00613977 File Offset: 0x00611B77
	public void StopLightSequence()
	{
		if (this.LevelSequencePlayer != null)
		{
			this.LevelSequencePlayer.Stop();
			return;
		}
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleId = -1;
		}
	}

	// Token: 0x06017E79 RID: 97913 RVA: 0x006139B0 File Offset: 0x00611BB0
	protected override void OnEnd()
	{
		this.StopLightSequence();
		ALevelSequenceActor tmp = this.SequenceActor;
		TimerSystem.Instance.Next(delegate(float delta)
		{
			ActorSystem.Instance.Put("UiRoleHuluLightSequenceComponent.OnEnd", tmp, null);
		}, null, null);
		this.LevelSequencePlayer = null;
		this.SequenceActor = null;
	}

	// Token: 0x06017E7A RID: 97914 RVA: 0x006139FC File Offset: 0x00611BFC
	public void OnModelVisibleChange(bool visible)
	{
		if (!visible)
		{
			this.StopLightSequence();
		}
	}

	// Token: 0x0400B237 RID: 45623
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B238 RID: 45624
	private ULevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B239 RID: 45625
	private ALevelSequenceActor SequenceActor;

	// Token: 0x0400B23A RID: 45626
	private int HandleId = -1;
}
