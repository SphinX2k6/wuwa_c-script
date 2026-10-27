using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D1E RID: 7454
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoguePlayerTrackerMarker : UiPanelBase
{
	// Token: 0x17001219 RID: 4633
	// (get) Token: 0x0600E189 RID: 57737 RVA: 0x0034F464 File Offset: 0x0034D664
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

	// Token: 0x0600E18B RID: 57739 RVA: 0x0034F696 File Offset: 0x0034D896
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600E18C RID: 57740 RVA: 0x0034F6A9 File Offset: 0x0034D8A9
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600E18D RID: 57741 RVA: 0x0034F6B2 File Offset: 0x0034D8B2
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600E18E RID: 57742 RVA: 0x0034F6BC File Offset: 0x0034D8BC
	public void ShowTips()
	{
		base.Show(null);
		if (this.SequencePlayer.IsPlayingSequence("Close"))
		{
			this.SequencePlayer.StopSequenceByKey("Close", false, false);
		}
		this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600E18F RID: 57743 RVA: 0x0034F710 File Offset: 0x0034D910
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

	// Token: 0x0600E190 RID: 57744 RVA: 0x0034F77C File Offset: 0x0034D97C
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

	// Token: 0x04006845 RID: 26693
	private static readonly FName MARKER_TRACE_SOCKET = new FName("Root");

	// Token: 0x04006846 RID: 26694
	protected LevelSequencePlayer SequencePlayer;

	// Token: 0x04006847 RID: 26695
	protected FVector2D ScreenPositionRef;

	// Token: 0x04006848 RID: 26696
	protected readonly Vector2D ScreenPosition = Vector2D.Create();

	// Token: 0x04006849 RID: 26697
	protected readonly Vector2D LastScreenPosition = Vector2D.Create();

	// Token: 0x0400684A RID: 26698
	protected Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x0400684B RID: 26699
	[Nullable(2)]
	protected Vector Offset;

	// Token: 0x0400684C RID: 26700
	[Nullable(2)]
	protected CharacterActorComponent CharacterActorComponent;

	// Token: 0x0400684D RID: 26701
	protected bool TickEnabled;
}
