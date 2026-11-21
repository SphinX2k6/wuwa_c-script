using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002209 RID: 8713
[NullableContext(2)]
[Nullable(0)]
public class UiRoleHuluLightSequenceComponent : UiModelComponentBase, IUiModelVisible
{
	// Token: 0x060156E9 RID: 87785 RVA: 0x0063941C File Offset: 0x0063761C
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
	}

	// Token: 0x060156EA RID: 87786 RVA: 0x00639430 File Offset: 0x00637630
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

	// Token: 0x060156EB RID: 87787 RVA: 0x00639474 File Offset: 0x00637674
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

	// Token: 0x060156EC RID: 87788 RVA: 0x00639503 File Offset: 0x00637703
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

	// Token: 0x060156ED RID: 87789 RVA: 0x0063953C File Offset: 0x0063773C
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

	// Token: 0x060156EE RID: 87790 RVA: 0x00639588 File Offset: 0x00637788
	public void OnModelVisibleChange(bool visible)
	{
		if (!visible)
		{
			this.StopLightSequence();
		}
	}

	// Token: 0x0400B5A2 RID: 46498
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B5A3 RID: 46499
	private ULevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B5A4 RID: 46500
	private ALevelSequenceActor SequenceActor;

	// Token: 0x0400B5A5 RID: 46501
	private int HandleId = -1;
}
