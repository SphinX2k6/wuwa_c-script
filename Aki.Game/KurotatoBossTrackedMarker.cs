using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CB7 RID: 7351
[NullableContext(1)]
[Nullable(0)]
public class KurotatoBossTrackedMarker : UiPanelBase
{
	// Token: 0x17001202 RID: 4610
	// (get) Token: 0x0600DE13 RID: 56851 RVA: 0x0033E8A0 File Offset: 0x0033CAA0
	protected int CurHp
	{
		get
		{
			TMap<EKSC_AttrType, int> attrMap = this.AttrMap;
			int? num = (attrMap != null) ? attrMap.GetValueOrNull(EKSC_AttrType.Life) : null;
			if (num != null && num.GetValueOrDefault() > 0)
			{
				return num.Value;
			}
			return 0;
		}
	}

	// Token: 0x17001203 RID: 4611
	// (get) Token: 0x0600DE14 RID: 56852 RVA: 0x0033E8E8 File Offset: 0x0033CAE8
	protected int MaxHp
	{
		get
		{
			TMap<EKSC_AttrType, int> attrMap = this.AttrMap;
			int? num = (attrMap != null) ? attrMap.GetValueOrNull(EKSC_AttrType.LifeMax) : null;
			if (num != null && num.GetValueOrDefault() > 0)
			{
				this.LastValidMaxHp = num.Value;
				return num.Value;
			}
			return this.LastValidMaxHp;
		}
	}

	// Token: 0x0600DE15 RID: 56853 RVA: 0x0033E940 File Offset: 0x0033CB40
	public KurotatoBossTrackedMarker(int entityId)
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

	// Token: 0x0600DE16 RID: 56854 RVA: 0x0033EA3B File Offset: 0x0033CC3B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600DE17 RID: 56855 RVA: 0x0033EA74 File Offset: 0x0033CC74
	protected override void OnStart()
	{
		this.DirectionArrow = base.GetItem(0);
		this.TextureHpBar = base.GetTexture(1);
		this.HpBarLerpDuration = (float)ConfigCommonParamById.GetIntConfig("KurotatoBossHpBarAttenuateSpeed").Value;
		this.AnimSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.AnimSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.Recycle();
			}
		}, false);
	}

	// Token: 0x0600DE18 RID: 56856 RVA: 0x0033EAE0 File Offset: 0x0033CCE0
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		if (this.InRange)
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

	// Token: 0x0600DE19 RID: 56857 RVA: 0x0033EB4D File Offset: 0x0033CD4D
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600DE1A RID: 56858 RVA: 0x0033EB56 File Offset: 0x0033CD56
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600DE1B RID: 56859 RVA: 0x0033EB60 File Offset: 0x0033CD60
	public UniTask CreateByPoolResourceIdAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
	{
		KurotatoBossTrackedMarker.<CreateByPoolResourceIdAsync>d__39 <CreateByPoolResourceIdAsync>d__;
		<CreateByPoolResourceIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateByPoolResourceIdAsync>d__.<>4__this = this;
		<CreateByPoolResourceIdAsync>d__.resourceId = resourceId;
		<CreateByPoolResourceIdAsync>d__.parentItem = parentItem;
		<CreateByPoolResourceIdAsync>d__.<>1__state = -1;
		<CreateByPoolResourceIdAsync>d__.<>t__builder.Start<KurotatoBossTrackedMarker.<CreateByPoolResourceIdAsync>d__39>(ref <CreateByPoolResourceIdAsync>d__);
		return <CreateByPoolResourceIdAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DE1C RID: 56860 RVA: 0x0033EBB4 File Offset: 0x0033CDB4
	private UniTask CreatePoolActorAsync(string resourceId, [Nullable(2)] UUIItem parentItem = null)
	{
		KurotatoBossTrackedMarker.<CreatePoolActorAsync>d__40 <CreatePoolActorAsync>d__;
		<CreatePoolActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePoolActorAsync>d__.<>4__this = this;
		<CreatePoolActorAsync>d__.resourceId = resourceId;
		<CreatePoolActorAsync>d__.parentItem = parentItem;
		<CreatePoolActorAsync>d__.<>1__state = -1;
		<CreatePoolActorAsync>d__.<>t__builder.Start<KurotatoBossTrackedMarker.<CreatePoolActorAsync>d__40>(ref <CreatePoolActorAsync>d__);
		return <CreatePoolActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DE1D RID: 56861 RVA: 0x0033EC07 File Offset: 0x0033CE07
	public void Recycle()
	{
		UiActorPool.Instance.RecycleAsync(this.MarkerActor, this.ResourceId);
	}

	// Token: 0x0600DE1E RID: 56862 RVA: 0x0033EC20 File Offset: 0x0033CE20
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

	// Token: 0x0600DE1F RID: 56863 RVA: 0x0033EC94 File Offset: 0x0033CE94
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
		this.TickHpBar(deltaTime);
	}

	// Token: 0x0600DE20 RID: 56864 RVA: 0x0033ECE0 File Offset: 0x0033CEE0
	private void TickHpBar(float delta)
	{
		if (this.AttrMap == null)
		{
			KscEntityHandle trackedEntity = this.TrackedEntity;
			TMap<EKSC_AttrType, int> attrMap;
			if (trackedEntity == null)
			{
				attrMap = null;
			}
			else
			{
				AKSC_Entity kscEntity = trackedEntity.KscEntity;
				if (kscEntity == null)
				{
					attrMap = null;
				}
				else
				{
					UKSC_SkillComp skillComp = kscEntity.GetSkillComp();
					if (skillComp == null)
					{
						attrMap = null;
					}
					else
					{
						UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
						attrMap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
					}
				}
			}
			this.AttrMap = attrMap;
			if (this.AttrMap == null)
			{
				return;
			}
		}
		if (this.MaxHp <= 0)
		{
			return;
		}
		float num = MathUtils.Instance.Clamp((float)this.CurHp / (float)this.MaxHp, 0f, 1f);
		if (this.CurrentBarPercent < 0f)
		{
			this.ApplyBarPercent(num);
			return;
		}
		if (num >= this.CurrentBarPercent)
		{
			if (num != this.CurrentBarPercent)
			{
				this.ApplyBarPercent(num);
			}
			this.HpBarLerpTime = -1f;
			return;
		}
		if (this.HpBarLerpTime < 0f || num != this.TargetBarPercent)
		{
			this.SourceBarPercent = this.CurrentBarPercent;
			this.TargetBarPercent = num;
			this.HpBarLerpTime = 0f;
		}
		this.HpBarLerpTime += delta;
		if (this.HpBarLerpTime >= this.HpBarLerpDuration)
		{
			this.ApplyBarPercent(this.TargetBarPercent);
			this.HpBarLerpTime = -1f;
			return;
		}
		float alpha = this.HpBarLerpTime / this.HpBarLerpDuration;
		this.ApplyBarPercent(MathUtils.Instance.Lerp(this.SourceBarPercent, this.TargetBarPercent, alpha));
	}

	// Token: 0x0600DE21 RID: 56865 RVA: 0x0033EE37 File Offset: 0x0033D037
	private void ApplyBarPercent(float percent)
	{
		this.CurrentBarPercent = percent;
		this.TextureHpBar.SetFillAmount(percent);
	}

	// Token: 0x0600DE22 RID: 56866 RVA: 0x0033EE4C File Offset: 0x0033D04C
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
				this.TempRotator.Yaw = (float)(Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.2957763671875 - 90.0);
				UUIItem directionArrow = this.DirectionArrow;
				FRotator frotator = this.TempRotator.ToUeRotator();
				directionArrow.SetUIRelativeRotation(frotator);
				base.SetUiActive(true);
				return;
			}
			base.SetUiActive(false);
		}
	}

	// Token: 0x0600DE23 RID: 56867 RVA: 0x0033F000 File Offset: 0x0033D200
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

	// Token: 0x040065D7 RID: 26071
	private const float MAX_A = 1176f;

	// Token: 0x040065D8 RID: 26072
	private const float MARGIN_A = 1008f;

	// Token: 0x040065D9 RID: 26073
	private const float MAX_B = 712.5f;

	// Token: 0x040065DA RID: 26074
	private const float MARGIN_B = 495f;

	// Token: 0x040065DB RID: 26075
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x040065DC RID: 26076
	[Nullable(2)]
	protected UUIItem DirectionArrow;

	// Token: 0x040065DD RID: 26077
	protected UUITexture TextureHpBar;

	// Token: 0x040065DE RID: 26078
	[Nullable(2)]
	protected UiPoolActor MarkerActor;

	// Token: 0x040065DF RID: 26079
	[Nullable(2)]
	protected string ResourceId;

	// Token: 0x040065E0 RID: 26080
	[Nullable(2)]
	protected LevelSequencePlayer AnimSequencePlayer;

	// Token: 0x040065E1 RID: 26081
	protected FVector2D ScreenPositionRef;

	// Token: 0x040065E2 RID: 26082
	protected int TrackedEntityId;

	// Token: 0x040065E3 RID: 26083
	[Nullable(2)]
	protected KscEntityHandle TrackedEntity;

	// Token: 0x040065E4 RID: 26084
	protected Vector2D ScreenPosition;

	// Token: 0x040065E5 RID: 26085
	protected Vector2D LastScreenPosition;

	// Token: 0x040065E6 RID: 26086
	protected readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x040065E7 RID: 26087
	protected bool InRange;

	// Token: 0x040065E8 RID: 26088
	protected Rotator TempRotator;

	// Token: 0x040065E9 RID: 26089
	protected float LimitA;

	// Token: 0x040065EA RID: 26090
	protected float LimitB;

	// Token: 0x040065EB RID: 26091
	protected bool TickEnabled;

	// Token: 0x040065EC RID: 26092
	[Nullable(2)]
	protected TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x040065ED RID: 26093
	protected int LastValidMaxHp = -1;

	// Token: 0x040065EE RID: 26094
	protected float CurrentBarPercent = -1f;

	// Token: 0x040065EF RID: 26095
	protected float SourceBarPercent;

	// Token: 0x040065F0 RID: 26096
	protected float TargetBarPercent;

	// Token: 0x040065F1 RID: 26097
	protected float HpBarLerpTime = -1f;

	// Token: 0x040065F2 RID: 26098
	protected float HpBarLerpDuration;

	// Token: 0x0200829E RID: 33438
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402A9BA RID: 174522
		public const int DirectionArrow = 0;

		// Token: 0x0402A9BB RID: 174523
		public const int TextureHpBar = 1;
	}
}
