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

// Token: 0x02001CC0 RID: 7360
[NullableContext(1)]
[Nullable(0)]
public class KurotatoTreasureBoxTrackedMarker : UiPanelBase
{
	// Token: 0x0600DEA5 RID: 56997 RVA: 0x00341820 File Offset: 0x0033FA20
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

	// Token: 0x0600DEA6 RID: 56998 RVA: 0x003418FE File Offset: 0x0033FAFE
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem))
		};
	}

	// Token: 0x0600DEA7 RID: 56999 RVA: 0x00341921 File Offset: 0x0033FB21
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

	// Token: 0x0600DEA8 RID: 57000 RVA: 0x0034195C File Offset: 0x0033FB5C
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

	// Token: 0x0600DEA9 RID: 57001 RVA: 0x003419C9 File Offset: 0x0033FBC9
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600DEAA RID: 57002 RVA: 0x003419D2 File Offset: 0x0033FBD2
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600DEAB RID: 57003 RVA: 0x003419DC File Offset: 0x0033FBDC
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

	// Token: 0x0600DEAC RID: 57004 RVA: 0x00341A30 File Offset: 0x0033FC30
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

	// Token: 0x0600DEAD RID: 57005 RVA: 0x00341A83 File Offset: 0x0033FC83
	public void Recycle()
	{
		UiActorPool.Instance.RecycleAsync(this.MarkerActor, this.ResourceId);
	}

	// Token: 0x0600DEAE RID: 57006 RVA: 0x00341A9C File Offset: 0x0033FC9C
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

	// Token: 0x0600DEAF RID: 57007 RVA: 0x00341B10 File Offset: 0x0033FD10
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

	// Token: 0x0600DEB0 RID: 57008 RVA: 0x00341B9C File Offset: 0x0033FD9C
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

	// Token: 0x0600DEB1 RID: 57009 RVA: 0x00341D38 File Offset: 0x0033FF38
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

	// Token: 0x0400663C RID: 26172
	private const float MAX_A = 1176f;

	// Token: 0x0400663D RID: 26173
	private const float MARGIN_A = 1008f;

	// Token: 0x0400663E RID: 26174
	private const float MAX_B = 712.5f;

	// Token: 0x0400663F RID: 26175
	private const float MARGIN_B = 495f;

	// Token: 0x04006640 RID: 26176
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x04006641 RID: 26177
	private const float AUTO_HIDE_DELAY_MS = 3000f;

	// Token: 0x04006642 RID: 26178
	[Nullable(2)]
	protected UUIItem DirectionArrow;

	// Token: 0x04006643 RID: 26179
	[Nullable(2)]
	protected UiPoolActor MarkerActor;

	// Token: 0x04006644 RID: 26180
	[Nullable(2)]
	protected string ResourceId;

	// Token: 0x04006645 RID: 26181
	[Nullable(2)]
	protected LevelSequencePlayer AnimSequencePlayer;

	// Token: 0x04006646 RID: 26182
	protected FVector2D ScreenPositionRef;

	// Token: 0x04006647 RID: 26183
	protected int TrackedEntityId;

	// Token: 0x04006648 RID: 26184
	[Nullable(2)]
	protected KscEntityHandle TrackedEntity;

	// Token: 0x04006649 RID: 26185
	protected Vector2D ScreenPosition;

	// Token: 0x0400664A RID: 26186
	protected Vector2D LastScreenPosition;

	// Token: 0x0400664B RID: 26187
	protected readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x0400664C RID: 26188
	protected Rotator TempRotator;

	// Token: 0x0400664D RID: 26189
	protected float LimitA;

	// Token: 0x0400664E RID: 26190
	protected float LimitB;

	// Token: 0x0400664F RID: 26191
	protected bool TickEnabled;

	// Token: 0x04006650 RID: 26192
	protected float ElapsedMs;

	// Token: 0x04006651 RID: 26193
	protected bool HasHidden;

	// Token: 0x020082AF RID: 33455
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AA21 RID: 174625
		public const int DirectionArrow = 0;
	}
}
