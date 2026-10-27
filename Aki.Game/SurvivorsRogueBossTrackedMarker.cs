using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D1B RID: 7451
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueBossTrackedMarker : UiPanelBase
{
	// Token: 0x0600E153 RID: 57683 RVA: 0x0034DEA8 File Offset: 0x0034C0A8
	public SurvivorsRogueBossTrackedMarker(int entityId)
	{
		this.TrackedEntityId = entityId;
		SurvivorsRogueSubModel survivorsRogueSubModel = KuroSimpleCombatController.Instance.GetSubModel(EKscGameplayType.SurvivorsRogue) as SurvivorsRogueSubModel;
		this.TrackedEntity = survivorsRogueSubModel.KscEntities.GetValueOrDefault(entityId);
		this.ScreenPosition = Vector2D.Create();
		this.LastScreenPosition = Vector2D.Create();
		this.TempRotator = new Rotator();
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
		this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
	}

	// Token: 0x0600E154 RID: 57684 RVA: 0x0034DF86 File Offset: 0x0034C186
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600E155 RID: 57685 RVA: 0x0034DFA9 File Offset: 0x0034C1A9
	protected override void OnStart()
	{
		this.DirectionArrow = base.GetItem(0);
		this.AnimSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.AnimSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.Recycle();
			}
		}, false);
	}

	// Token: 0x0600E156 RID: 57686 RVA: 0x0034DFE4 File Offset: 0x0034C1E4
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		if (this.AnimSequencePlayer.IsPlayingSequence("Close"))
		{
			this.AnimSequencePlayer.StopSequenceByKey("Close", false, false);
		}
		this.AnimSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600E157 RID: 57687 RVA: 0x0034E035 File Offset: 0x0034C235
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600E158 RID: 57688 RVA: 0x0034E03E File Offset: 0x0034C23E
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600E159 RID: 57689 RVA: 0x0034E048 File Offset: 0x0034C248
	public UniTask CreateByPoolResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
	{
		SurvivorsRogueBossTrackedMarker.<CreateByPoolResourceIdAsync>d__27 <CreateByPoolResourceIdAsync>d__;
		<CreateByPoolResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateByPoolResourceIdAsync>d__.<>4__this = this;
		<CreateByPoolResourceIdAsync>d__.resourceId = resourceId;
		<CreateByPoolResourceIdAsync>d__.parentItem = parentItem;
		<CreateByPoolResourceIdAsync>d__.<>1__state = -1;
		<CreateByPoolResourceIdAsync>d__.<>t__builder.Start<SurvivorsRogueBossTrackedMarker.<CreateByPoolResourceIdAsync>d__27>(ref <CreateByPoolResourceIdAsync>d__);
		return <CreateByPoolResourceIdAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E15A RID: 57690 RVA: 0x0034E09C File Offset: 0x0034C29C
	private UniTask CreatePoolActorAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
	{
		SurvivorsRogueBossTrackedMarker.<CreatePoolActorAsync>d__28 <CreatePoolActorAsync>d__;
		<CreatePoolActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePoolActorAsync>d__.<>4__this = this;
		<CreatePoolActorAsync>d__.resourceId = resourceId;
		<CreatePoolActorAsync>d__.parentItem = parentItem;
		<CreatePoolActorAsync>d__.<>1__state = -1;
		<CreatePoolActorAsync>d__.<>t__builder.Start<SurvivorsRogueBossTrackedMarker.<CreatePoolActorAsync>d__28>(ref <CreatePoolActorAsync>d__);
		return <CreatePoolActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E15B RID: 57691 RVA: 0x0034E0EF File Offset: 0x0034C2EF
	public void Recycle()
	{
		UiActorPool.Instance.RecycleAsync(this.MarkerActor, this.ResourceId);
	}

	// Token: 0x0600E15C RID: 57692 RVA: 0x0034E108 File Offset: 0x0034C308
	public void DelayRecycle()
	{
		if (this.AnimSequencePlayer.IsPlayingSequence("Start"))
		{
			this.AnimSequencePlayer.StopSequenceByKey("Start", false, false);
		}
		else if (this.AnimSequencePlayer.IsPlayingSequence("Close"))
		{
			return;
		}
		this.AnimSequencePlayer.PlayOrReplaySequenceByName("Close", false, null);
	}

	// Token: 0x0600E15D RID: 57693 RVA: 0x0034E168 File Offset: 0x0034C368
	public void OnTick(float deltaTime)
	{
		if (!this.TickEnabled)
		{
			return;
		}
		if (Global.CharacterController == null || this.TrackedEntity == null)
		{
			return;
		}
		AKSC_Entity kscEntity = this.TrackedEntity.KscEntity;
		if (kscEntity == null)
		{
			return;
		}
		this.UpdateTargetPosition(kscEntity.K2_GetActorLocation());
	}

	// Token: 0x0600E15E RID: 57694 RVA: 0x0034E1AC File Offset: 0x0034C3AC
	public void UpdateTargetPosition(FVector targetPosition)
	{
		TsCharacterController characterController = Global.CharacterController;
		APlayerController player = characterController;
		FVectorDouble fvectorDouble = targetPosition;
		bool flag = UGameplayStatics.D_ProjectWorldToScreen(player, fvectorDouble, ref this.ScreenPositionRef, false);
		if (!flag)
		{
			FTransformDouble? cameraTransform = CameraModel.Instance.MainModel.CameraTransform;
			FTransformDouble value = cameraTransform.Value;
			fvectorDouble = targetPosition;
			FVectorDouble fvectorDouble2 = value.InverseTransformPositionNoScale(fvectorDouble);
			fvectorDouble2.X = -fvectorDouble2.X;
			FVectorDouble fvectorDouble3 = cameraTransform.Value.TransformPositionNoScale(fvectorDouble2);
			UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble3, ref this.ScreenPositionRef, false);
		}
		this.ScreenPosition.Set((double)this.ScreenPositionRef.X, (double)this.ScreenPositionRef.Y);
		if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0))
		{
			this.LastScreenPosition.DeepCopy(this.ScreenPosition);
			BattleUiModel instance = BattleUiModel.Instance;
			this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
			this.InRange = this.ClampToEllipse(this.ScreenPosition, flag);
			this.RootItem.SetAnchorOffset(this.ScreenPosition.ToUeVector2D(false));
			if (!this.InRange)
			{
				this.TempRotator.Reset();
				this.TempRotator.Yaw = (float)(Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.2957763671875);
				UUIItem directionArrow = this.DirectionArrow;
				FRotator frotator = this.TempRotator.ToUeRotator();
				directionArrow.SetUIRelativeRotation(frotator);
				base.SetUiActive(true);
				return;
			}
			base.SetUiActive(false);
		}
	}

	// Token: 0x0600E15F RID: 57695 RVA: 0x0034E358 File Offset: 0x0034C558
	protected bool ClampToEllipse(Vector2D vector, bool inFront)
	{
		double x = vector.X;
		double y = vector.Y;
		float limitA = this.LimitA;
		float limitB = this.LimitB;
		if (inFront && x * x / (double)(limitA * limitA) + y * y / (double)(limitB * limitB) <= 1.0)
		{
			return true;
		}
		double inB = (double)(limitA * limitB) / Math.Sqrt((double)(limitB * limitB) * x * x + (double)(limitA * limitA) * y * y);
		vector.MultiplyEqual(inB);
		return false;
	}

	// Token: 0x04006810 RID: 26640
	private const float MAX_A = 1176f;

	// Token: 0x04006811 RID: 26641
	private const float MARGIN_A = 1008f;

	// Token: 0x04006812 RID: 26642
	private const float MAX_B = 712.5f;

	// Token: 0x04006813 RID: 26643
	private const float MARGIN_B = 495f;

	// Token: 0x04006814 RID: 26644
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x04006815 RID: 26645
	[Nullable(2)]
	protected UUIItem DirectionArrow;

	// Token: 0x04006816 RID: 26646
	[Nullable(2)]
	protected UiPoolActor MarkerActor;

	// Token: 0x04006817 RID: 26647
	[Nullable(2)]
	protected string ResourceId;

	// Token: 0x04006818 RID: 26648
	protected LevelSequencePlayer AnimSequencePlayer;

	// Token: 0x04006819 RID: 26649
	protected FVector2D ScreenPositionRef;

	// Token: 0x0400681A RID: 26650
	protected int TrackedEntityId;

	// Token: 0x0400681B RID: 26651
	[Nullable(2)]
	protected KscEntityHandle TrackedEntity;

	// Token: 0x0400681C RID: 26652
	protected Vector2D ScreenPosition;

	// Token: 0x0400681D RID: 26653
	protected Vector2D LastScreenPosition;

	// Token: 0x0400681E RID: 26654
	protected readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x0400681F RID: 26655
	protected bool InRange;

	// Token: 0x04006820 RID: 26656
	protected Rotator TempRotator;

	// Token: 0x04006821 RID: 26657
	protected float LimitA;

	// Token: 0x04006822 RID: 26658
	protected float LimitB;

	// Token: 0x04006823 RID: 26659
	protected bool TickEnabled;

	// Token: 0x02008311 RID: 33553
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402ABF6 RID: 175094
		public const int DirectionArrow = 0;
	}
}
