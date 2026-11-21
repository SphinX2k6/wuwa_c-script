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

// Token: 0x020011DD RID: 4573
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueBossTrackedMarker : UiPanelBase
{
	// Token: 0x0600B570 RID: 46448 RVA: 0x003598D8 File Offset: 0x00357AD8
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

	// Token: 0x0600B571 RID: 46449 RVA: 0x003599B6 File Offset: 0x00357BB6
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600B572 RID: 46450 RVA: 0x003599D9 File Offset: 0x00357BD9
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

	// Token: 0x0600B573 RID: 46451 RVA: 0x00359A14 File Offset: 0x00357C14
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		if (this.AnimSequencePlayer.IsPlayingSequence("Close"))
		{
			this.AnimSequencePlayer.StopSequenceByKey("Close", false, false);
		}
		this.AnimSequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600B574 RID: 46452 RVA: 0x00359A65 File Offset: 0x00357C65
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600B575 RID: 46453 RVA: 0x00359A6E File Offset: 0x00357C6E
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600B576 RID: 46454 RVA: 0x00359A78 File Offset: 0x00357C78
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

	// Token: 0x0600B577 RID: 46455 RVA: 0x00359ACC File Offset: 0x00357CCC
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

	// Token: 0x0600B578 RID: 46456 RVA: 0x00359B1F File Offset: 0x00357D1F
	public void Recycle()
	{
		UiActorPool.Instance.RecycleAsync(this.MarkerActor, this.ResourceId);
	}

	// Token: 0x0600B579 RID: 46457 RVA: 0x00359B38 File Offset: 0x00357D38
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

	// Token: 0x0600B57A RID: 46458 RVA: 0x00359B98 File Offset: 0x00357D98
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

	// Token: 0x0600B57B RID: 46459 RVA: 0x00359BDC File Offset: 0x00357DDC
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

	// Token: 0x0600B57C RID: 46460 RVA: 0x00359D88 File Offset: 0x00357F88
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

	// Token: 0x040068EF RID: 26863
	private const float MAX_A = 1176f;

	// Token: 0x040068F0 RID: 26864
	private const float MARGIN_A = 1008f;

	// Token: 0x040068F1 RID: 26865
	private const float MAX_B = 712.5f;

	// Token: 0x040068F2 RID: 26866
	private const float MARGIN_B = 495f;

	// Token: 0x040068F3 RID: 26867
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x040068F4 RID: 26868
	[Nullable(2)]
	protected UUIItem DirectionArrow;

	// Token: 0x040068F5 RID: 26869
	[Nullable(2)]
	protected UiPoolActor MarkerActor;

	// Token: 0x040068F6 RID: 26870
	[Nullable(2)]
	protected string ResourceId;

	// Token: 0x040068F7 RID: 26871
	protected LevelSequencePlayer AnimSequencePlayer;

	// Token: 0x040068F8 RID: 26872
	protected FVector2D ScreenPositionRef;

	// Token: 0x040068F9 RID: 26873
	protected int TrackedEntityId;

	// Token: 0x040068FA RID: 26874
	[Nullable(2)]
	protected KscEntityHandle TrackedEntity;

	// Token: 0x040068FB RID: 26875
	protected Vector2D ScreenPosition;

	// Token: 0x040068FC RID: 26876
	protected Vector2D LastScreenPosition;

	// Token: 0x040068FD RID: 26877
	protected readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x040068FE RID: 26878
	protected bool InRange;

	// Token: 0x040068FF RID: 26879
	protected Rotator TempRotator;

	// Token: 0x04006900 RID: 26880
	protected float LimitA;

	// Token: 0x04006901 RID: 26881
	protected float LimitB;

	// Token: 0x04006902 RID: 26882
	protected bool TickEnabled;

	// Token: 0x0200749A RID: 29850
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025F1E RID: 155422
		public const int DirectionArrow = 0;
	}
}
