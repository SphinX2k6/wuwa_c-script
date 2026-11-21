using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011E0 RID: 4576
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoguePlayerTrackerMarker : UiPanelBase
{
	// Token: 0x17001243 RID: 4675
	// (get) Token: 0x0600B5A6 RID: 46502 RVA: 0x0035AE94 File Offset: 0x00359094
	private FVector? TrackingPosition
	{
		get
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			CharacterActorComponent characterActorComponent = this.CharacterActorComponent;
			bool flag;
			if (characterActorComponent == null)
			{
				flag = true;
			}
			else
			{
				TsBaseCharacter actor = characterActorComponent.Actor;
				flag = !((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				this.CharacterActorComponent = ((getCurrentEntity != null) ? getCurrentEntity.Entity.GetComponent<CharacterActorComponent>() : null);
				this.Offset = ((this.CharacterActorComponent != null) ? Vector.Create(0.0, 0.0, (double)(this.CharacterActorComponent.HalfHeight * 2f + 60f)) : Vector.Create(0.0, 0.0, 0.0));
			}
			CharacterActorComponent characterActorComponent2 = this.CharacterActorComponent;
			bool flag2;
			if (characterActorComponent2 == null)
			{
				flag2 = true;
			}
			else
			{
				TsBaseCharacter actor2 = characterActorComponent2.Actor;
				flag2 = !((actor2 != null) ? new bool?(actor2.IsValid()) : null).GetValueOrDefault();
			}
			if (flag2)
			{
				return null;
			}
			Vector vector = Vector.Create();
			Vector vector2 = Vector.Create();
			TsBaseCharacter actor3 = this.CharacterActorComponent.Actor;
			FVectorDouble fvectorDouble;
			if (actor3 != null)
			{
				bool flag3 = false;
				TArray<FName> allSocketNames = actor3.Mesh.GetAllSocketNames();
				int num = allSocketNames.Num();
				for (int i = 0; i < num; i++)
				{
					if (allSocketNames.Get(i) == SurvivorsRoguePlayerTrackerMarker.MARKER_TRACE_SOCKET)
					{
						flag3 = true;
						break;
					}
				}
				if (flag3)
				{
					Vector vector3 = vector2;
					fvectorDouble = this.CharacterActorComponent.Actor.Mesh.D_GetSocketLocation(SurvivorsRoguePlayerTrackerMarker.MARKER_TRACE_SOCKET);
					vector3.FromUeVector(fvectorDouble);
					vector2.Addition(this.Offset, vector);
				}
				else
				{
					Vector vector4 = vector2;
					fvectorDouble = this.CharacterActorComponent.Actor.Mesh.D_K2_GetComponentLocation();
					vector4.FromUeVector(fvectorDouble);
				}
			}
			else
			{
				Vector vector5 = vector2;
				FVector fvector = this.CharacterActorComponent.Actor.K2_GetActorLocation();
				vector5.FromUeVector(fvector);
			}
			fvectorDouble = vector.ToUeVector(false);
			return new FVector?(fvectorDouble);
		}
	}

	// Token: 0x0600B5A8 RID: 46504 RVA: 0x0035B0C6 File Offset: 0x003592C6
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600B5A9 RID: 46505 RVA: 0x0035B0D9 File Offset: 0x003592D9
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600B5AA RID: 46506 RVA: 0x0035B0E2 File Offset: 0x003592E2
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600B5AB RID: 46507 RVA: 0x0035B0EC File Offset: 0x003592EC
	public void ShowTips()
	{
		base.Show(null);
		if (this.SequencePlayer.IsPlayingSequence("Close"))
		{
			this.SequencePlayer.StopSequenceByKey("Close", false, false);
		}
		this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600B5AC RID: 46508 RVA: 0x0035B140 File Offset: 0x00359340
	public void HideTips()
	{
		if (!base.IsShowOrShowing)
		{
			return;
		}
		if (this.SequencePlayer.IsPlayingSequence("Start"))
		{
			this.SequencePlayer.StopSequenceByKey("Start", false, false);
		}
		else if (this.SequencePlayer.IsPlayingSequence("Close"))
		{
			return;
		}
		this.SequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
	}

	// Token: 0x0600B5AD RID: 46509 RVA: 0x0035B1AC File Offset: 0x003593AC
	public void OnTick(float delta)
	{
		if (!this.TickEnabled)
		{
			return;
		}
		if (Global.CharacterController == null)
		{
			return;
		}
		FVector? trackingPosition = this.TrackingPosition;
		if (trackingPosition == null)
		{
			return;
		}
		APlayerController characterController = Global.CharacterController;
		FVector value = trackingPosition.Value;
		FVectorDouble fvectorDouble = value;
		UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref this.ScreenPositionRef, false);
		this.ScreenPosition.Set((double)this.ScreenPositionRef.X, (double)this.ScreenPositionRef.Y);
		if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0))
		{
			this.LastScreenPosition.DeepCopy(this.ScreenPosition);
			BattleUiModel instance = BattleUiModel.Instance;
			this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
			this.RootItem.SetAnchorOffset(this.ScreenPosition.ToUeVector2D(false));
		}
	}

	// Token: 0x04006924 RID: 26916
	private static readonly FName MARKER_TRACE_SOCKET = new FName("Root");

	// Token: 0x04006925 RID: 26917
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x04006926 RID: 26918
	protected FVector2D ScreenPositionRef;

	// Token: 0x04006927 RID: 26919
	protected readonly Vector2D ScreenPosition = Vector2D.Create();

	// Token: 0x04006928 RID: 26920
	protected readonly Vector2D LastScreenPosition = Vector2D.Create();

	// Token: 0x04006929 RID: 26921
	protected Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x0400692A RID: 26922
	[Nullable(2)]
	protected Vector Offset;

	// Token: 0x0400692B RID: 26923
	[Nullable(2)]
	protected CharacterActorComponent CharacterActorComponent;

	// Token: 0x0400692C RID: 26924
	protected bool TickEnabled;
}
