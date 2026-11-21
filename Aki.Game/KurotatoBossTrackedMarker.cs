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

// Token: 0x02001179 RID: 4473
[NullableContext(1)]
[Nullable(0)]
public class KurotatoBossTrackedMarker : UiPanelBase
{
	// Token: 0x1700122C RID: 4652
	// (get) Token: 0x0600B230 RID: 45616 RVA: 0x0034A2DC File Offset: 0x003484DC
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

	// Token: 0x1700122D RID: 4653
	// (get) Token: 0x0600B231 RID: 45617 RVA: 0x0034A324 File Offset: 0x00348524
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

	// Token: 0x0600B232 RID: 45618 RVA: 0x0034A37C File Offset: 0x0034857C
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

	// Token: 0x0600B233 RID: 45619 RVA: 0x0034A477 File Offset: 0x00348677
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0600B234 RID: 45620 RVA: 0x0034A4B0 File Offset: 0x003486B0
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

	// Token: 0x0600B235 RID: 45621 RVA: 0x0034A51C File Offset: 0x0034871C
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

	// Token: 0x0600B236 RID: 45622 RVA: 0x0034A589 File Offset: 0x00348789
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600B237 RID: 45623 RVA: 0x0034A592 File Offset: 0x00348792
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600B238 RID: 45624 RVA: 0x0034A59C File Offset: 0x0034879C
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

	// Token: 0x0600B239 RID: 45625 RVA: 0x0034A5F0 File Offset: 0x003487F0
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

	// Token: 0x0600B23A RID: 45626 RVA: 0x0034A643 File Offset: 0x00348843
	public void Recycle()
	{
		UiActorPool.Instance.RecycleAsync(this.MarkerActor, this.ResourceId);
	}

	// Token: 0x0600B23B RID: 45627 RVA: 0x0034A65C File Offset: 0x0034885C
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

	// Token: 0x0600B23C RID: 45628 RVA: 0x0034A6D0 File Offset: 0x003488D0
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

	// Token: 0x0600B23D RID: 45629 RVA: 0x0034A71C File Offset: 0x0034891C
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

	// Token: 0x0600B23E RID: 45630 RVA: 0x0034A873 File Offset: 0x00348A73
	private void ApplyBarPercent(float percent)
	{
		this.CurrentBarPercent = percent;
		this.TextureHpBar.SetFillAmount(percent);
	}

	// Token: 0x0600B23F RID: 45631 RVA: 0x0034A888 File Offset: 0x00348A88
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

	// Token: 0x0600B240 RID: 45632 RVA: 0x0034AA3C File Offset: 0x00348C3C
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

	// Token: 0x040066B6 RID: 26294
	private const float MAX_A = 1176f;

	// Token: 0x040066B7 RID: 26295
	private const float MARGIN_A = 1008f;

	// Token: 0x040066B8 RID: 26296
	private const float MAX_B = 712.5f;

	// Token: 0x040066B9 RID: 26297
	private const float MARGIN_B = 495f;

	// Token: 0x040066BA RID: 26298
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x040066BB RID: 26299
	[Nullable(2)]
	protected UUIItem DirectionArrow;

	// Token: 0x040066BC RID: 26300
	protected UUITexture TextureHpBar;

	// Token: 0x040066BD RID: 26301
	[Nullable(2)]
	protected UiPoolActor MarkerActor;

	// Token: 0x040066BE RID: 26302
	[Nullable(2)]
	protected string ResourceId;

	// Token: 0x040066BF RID: 26303
	[Nullable(2)]
	protected LevelSequencePlayer AnimSequencePlayer;

	// Token: 0x040066C0 RID: 26304
	protected FVector2D ScreenPositionRef;

	// Token: 0x040066C1 RID: 26305
	protected int TrackedEntityId;

	// Token: 0x040066C2 RID: 26306
	[Nullable(2)]
	protected KscEntityHandle TrackedEntity;

	// Token: 0x040066C3 RID: 26307
	protected Vector2D ScreenPosition;

	// Token: 0x040066C4 RID: 26308
	protected Vector2D LastScreenPosition;

	// Token: 0x040066C5 RID: 26309
	protected readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x040066C6 RID: 26310
	protected bool InRange;

	// Token: 0x040066C7 RID: 26311
	protected Rotator TempRotator;

	// Token: 0x040066C8 RID: 26312
	protected float LimitA;

	// Token: 0x040066C9 RID: 26313
	protected float LimitB;

	// Token: 0x040066CA RID: 26314
	protected bool TickEnabled;

	// Token: 0x040066CB RID: 26315
	[Nullable(2)]
	protected TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x040066CC RID: 26316
	protected int LastValidMaxHp = -1;

	// Token: 0x040066CD RID: 26317
	protected float CurrentBarPercent = -1f;

	// Token: 0x040066CE RID: 26318
	protected float SourceBarPercent;

	// Token: 0x040066CF RID: 26319
	protected float TargetBarPercent;

	// Token: 0x040066D0 RID: 26320
	protected float HpBarLerpTime = -1f;

	// Token: 0x040066D1 RID: 26321
	protected float HpBarLerpDuration;

	// Token: 0x02007428 RID: 29736
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025CE5 RID: 154853
		public const int DirectionArrow = 0;

		// Token: 0x04025CE6 RID: 154854
		public const int TextureHpBar = 1;
	}
}
