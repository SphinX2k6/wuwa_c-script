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

// Token: 0x02001182 RID: 4482
[NullableContext(1)]
[Nullable(0)]
public class KurotatoTreasureBoxTrackedMarker : UiPanelBase
{
	// Token: 0x0600B2C2 RID: 45762 RVA: 0x0034D248 File Offset: 0x0034B448
	public KurotatoTreasureBoxTrackedMarker(int entityId)
	{
		this.TrackedEntityId = entityId;
		PotatoSubModel potatoSubModel = KuroSimpleCombatController.Instance.GetSubModel(EKscGameplayType.Potato) as PotatoSubModel;
		this.TrackedEntity = potatoSubModel.KscEntities.GetValueOrDefault(entityId);
		this.ScreenPosition = Vector2D.Create();
		this.LastScreenPosition = Vector2D.Create();
		this.TempRotator = new Rotator();
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
		this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
	}

	// Token: 0x0600B2C3 RID: 45763 RVA: 0x0034D326 File Offset: 0x0034B526
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600B2C4 RID: 45764 RVA: 0x0034D349 File Offset: 0x0034B549
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

	// Token: 0x0600B2C5 RID: 45765 RVA: 0x0034D384 File Offset: 0x0034B584
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		if (this.HasHidden)
		{
			base.SetUiActive(false);
			return;
		}
		LevelSequencePlayer animSequencePlayer = this.AnimSequencePlayer;
		if (animSequencePlayer != null && animSequencePlayer.IsPlayingSequence("Close"))
		{
			this.AnimSequencePlayer.StopSequenceByKey("Close", false, false);
		}
		LevelSequencePlayer animSequencePlayer2 = this.AnimSequencePlayer;
		if (animSequencePlayer2 == null)
		{
			return;
		}
		animSequencePlayer2.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600B2C6 RID: 45766 RVA: 0x0034D3F1 File Offset: 0x0034B5F1
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600B2C7 RID: 45767 RVA: 0x0034D3FA File Offset: 0x0034B5FA
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600B2C8 RID: 45768 RVA: 0x0034D404 File Offset: 0x0034B604
	public UniTask CreateByPoolResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
	{
		KurotatoTreasureBoxTrackedMarker.<CreateByPoolResourceIdAsync>d__29 <CreateByPoolResourceIdAsync>d__;
		<CreateByPoolResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateByPoolResourceIdAsync>d__.<>4__this = this;
		<CreateByPoolResourceIdAsync>d__.resourceId = resourceId;
		<CreateByPoolResourceIdAsync>d__.parentItem = parentItem;
		<CreateByPoolResourceIdAsync>d__.<>1__state = -1;
		<CreateByPoolResourceIdAsync>d__.<>t__builder.Start<KurotatoTreasureBoxTrackedMarker.<CreateByPoolResourceIdAsync>d__29>(ref <CreateByPoolResourceIdAsync>d__);
		return <CreateByPoolResourceIdAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2C9 RID: 45769 RVA: 0x0034D458 File Offset: 0x0034B658
	private UniTask CreatePoolActorAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
	{
		KurotatoTreasureBoxTrackedMarker.<CreatePoolActorAsync>d__30 <CreatePoolActorAsync>d__;
		<CreatePoolActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePoolActorAsync>d__.<>4__this = this;
		<CreatePoolActorAsync>d__.resourceId = resourceId;
		<CreatePoolActorAsync>d__.parentItem = parentItem;
		<CreatePoolActorAsync>d__.<>1__state = -1;
		<CreatePoolActorAsync>d__.<>t__builder.Start<KurotatoTreasureBoxTrackedMarker.<CreatePoolActorAsync>d__30>(ref <CreatePoolActorAsync>d__);
		return <CreatePoolActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B2CA RID: 45770 RVA: 0x0034D4AB File Offset: 0x0034B6AB
	public void Recycle()
	{
		UiActorPool.Instance.RecycleAsync(this.MarkerActor, this.ResourceId);
	}

	// Token: 0x0600B2CB RID: 45771 RVA: 0x0034D4C4 File Offset: 0x0034B6C4
	public void DelayRecycle()
	{
		LevelSequencePlayer animSequencePlayer = this.AnimSequencePlayer;
		if (animSequencePlayer != null && animSequencePlayer.IsPlayingSequence("Start"))
		{
			this.AnimSequencePlayer.StopSequenceByKey("Start", false, false);
		}
		else
		{
			LevelSequencePlayer animSequencePlayer2 = this.AnimSequencePlayer;
			if (animSequencePlayer2 != null && animSequencePlayer2.IsPlayingSequence("Close"))
			{
				return;
			}
		}
		LevelSequencePlayer animSequencePlayer3 = this.AnimSequencePlayer;
		if (animSequencePlayer3 == null)
		{
			return;
		}
		animSequencePlayer3.PlayOrReplaySequenceByName("Close", false, null);
	}

	// Token: 0x0600B2CC RID: 45772 RVA: 0x0034D538 File Offset: 0x0034B738
	public void OnTick(float deltaTime)
	{
		if (!this.TickEnabled || this.HasHidden)
		{
			return;
		}
		this.ElapsedMs += deltaTime;
		if (this.ElapsedMs >= 3000f)
		{
			base.SetUiActive(false);
			this.HasHidden = true;
			return;
		}
		if (Global.CharacterController == null || this.TrackedEntity == null)
		{
			return;
		}
		if (!this.TrackedEntity.Valid)
		{
			base.SetUiActive(false);
			this.HasHidden = true;
			return;
		}
		this.UpdateTargetPosition(this.TrackedEntity.KscEntity.D_K2_GetActorLocation());
	}

	// Token: 0x0600B2CD RID: 45773 RVA: 0x0034D5C4 File Offset: 0x0034B7C4
	public void UpdateTargetPosition(FVectorDouble targetPosition)
	{
		TsCharacterController characterController = Global.CharacterController;
		bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, targetPosition, ref this.ScreenPositionRef, false);
		if (!flag)
		{
			FTransformDouble? cameraTransform = CameraModel.Instance.MainModel.CameraTransform;
			FVectorDouble fvectorDouble = cameraTransform.Value.InverseTransformPositionNoScale(targetPosition);
			fvectorDouble.X = -fvectorDouble.X;
			FVectorDouble fvectorDouble2 = cameraTransform.Value.TransformPositionNoScale(fvectorDouble);
			UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble2, ref this.ScreenPositionRef, false);
		}
		this.ScreenPosition.Set((double)this.ScreenPositionRef.X, (double)this.ScreenPositionRef.Y);
		if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0))
		{
			this.LastScreenPosition.DeepCopy(this.ScreenPosition);
			BattleUiModel instance = BattleUiModel.Instance;
			this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
			bool flag2 = this.ClampToEllipse(this.ScreenPosition, flag);
			this.RootItem.SetAnchorOffset(this.ScreenPosition.ToUeVector2D(false));
			if (!flag2)
			{
				this.TempRotator.Reset();
				this.TempRotator.Yaw = (float)(Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.2957763671875 - 90.0);
				UUIItem directionArrow = this.DirectionArrow;
				FRotator frotator = this.TempRotator.ToUeRotator();
				directionArrow.SetUIRelativeRotation(frotator);
				base.SetUiActive(true);
				return;
			}
			base.SetUiActive(false);
			this.HasHidden = true;
		}
	}

	// Token: 0x0600B2CE RID: 45774 RVA: 0x0034D760 File Offset: 0x0034B960
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

	// Token: 0x0400671B RID: 26395
	private const float MAX_A = 1176f;

	// Token: 0x0400671C RID: 26396
	private const float MARGIN_A = 1008f;

	// Token: 0x0400671D RID: 26397
	private const float MAX_B = 712.5f;

	// Token: 0x0400671E RID: 26398
	private const float MARGIN_B = 495f;

	// Token: 0x0400671F RID: 26399
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x04006720 RID: 26400
	private const float AUTO_HIDE_DELAY_MS = 3000f;

	// Token: 0x04006721 RID: 26401
	[Nullable(2)]
	protected UUIItem DirectionArrow;

	// Token: 0x04006722 RID: 26402
	[Nullable(2)]
	protected UiPoolActor MarkerActor;

	// Token: 0x04006723 RID: 26403
	[Nullable(2)]
	protected string ResourceId;

	// Token: 0x04006724 RID: 26404
	[Nullable(2)]
	protected LevelSequencePlayer AnimSequencePlayer;

	// Token: 0x04006725 RID: 26405
	protected FVector2D ScreenPositionRef;

	// Token: 0x04006726 RID: 26406
	protected int TrackedEntityId;

	// Token: 0x04006727 RID: 26407
	[Nullable(2)]
	protected KscEntityHandle TrackedEntity;

	// Token: 0x04006728 RID: 26408
	protected Vector2D ScreenPosition;

	// Token: 0x04006729 RID: 26409
	protected Vector2D LastScreenPosition;

	// Token: 0x0400672A RID: 26410
	protected readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x0400672B RID: 26411
	protected Rotator TempRotator;

	// Token: 0x0400672C RID: 26412
	protected float LimitA;

	// Token: 0x0400672D RID: 26413
	protected float LimitB;

	// Token: 0x0400672E RID: 26414
	protected bool TickEnabled;

	// Token: 0x0400672F RID: 26415
	protected float ElapsedMs;

	// Token: 0x04006730 RID: 26416
	protected bool HasHidden;

	// Token: 0x02007438 RID: 29752
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025D49 RID: 154953
		public const int DirectionArrow = 0;
	}
}
