using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016C6 RID: 5830
[NullableContext(2)]
[Nullable(0)]
public class AdviceMotionActor
{
	// Token: 0x0600A6A6 RID: 42662 RVA: 0x00254E1C File Offset: 0x0025301C
	public void PlayMotion(int entityId)
	{
		this.CurrentEntity = entityId;
		this.InitInternalActor(entityId, delegate
		{
			this.PlayInteractAnimation(entityId);
		});
	}

	// Token: 0x0600A6A7 RID: 42663 RVA: 0x00254E64 File Offset: 0x00253064
	[NullableContext(1)]
	private void InitInternalActor(int entityId, Action loadMeshCompleteCall)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return;
		}
		SceneItemActorComponent component = entity.GetComponent<SceneItemActorComponent>();
		CreatureDataComponent component2 = entity.GetComponent<CreatureDataComponent>();
		if (component != null)
		{
			bool flag;
			if (component2 == null)
			{
				flag = (null != null);
			}
			else
			{
				AdviceEntityData adviceInfo = component2.GetAdviceInfo();
				flag = (((adviceInfo != null) ? adviceInfo.GetAdviceData() : null) != null);
			}
			if (flag)
			{
				long adviceMotionId = component2.GetAdviceInfo().GetAdviceData().GetAdviceMotionId();
				if (adviceMotionId == 0L)
				{
					return;
				}
				if (this.ActorInternal == null)
				{
					this.ActorInternal = ActorSystem.Instance.Get(AActor.StaticClass(), component.ActorTransform, null, true);
					AActor actorInternal = this.ActorInternal;
					this.SkeletalMeshInternal = (((actorInternal != null) ? actorInternal.AddComponentByClass(USkeletalMeshComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) : null) as USkeletalMeshComponent);
					AActor actorInternal2 = this.ActorInternal;
					this.CharRenderingComponent = (((actorInternal2 != null) ? actorInternal2.AddComponentByClass(CharRenderingComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) : null) as CharRenderingComponent);
					if (this.SkeletalMeshInternal != null)
					{
						this.SkeletalMeshInternal.SetEnableGravity(false);
						this.SkeletalMeshInternal.SetCollisionEnabled(ECollisionEnabled.NoCollision);
						this.SkeletalMeshInternal.SetSimulatePhysics(false);
					}
					if (this.CharRenderingComponent != null)
					{
						this.CharRenderingComponent.Init(ECharacterRenderingType.LocalPlayer);
					}
				}
				FHitResult fhitResult = new FHitResult();
				AActor actorInternal3 = this.ActorInternal;
				if (actorInternal3 != null)
				{
					actorInternal3.D_K2_SetActorRelativeLocation(component.ActorLocationProxy.ToUeVector(false), false, ref fhitResult, true);
				}
				AActor actorInternal4 = this.ActorInternal;
				if (actorInternal4 != null)
				{
					actorInternal4.K2_SetActorRotation(component.ActorRotationProxy.ToUeRotator(), false);
				}
				int? motionRoleId = MotionConfig.Instance.GetMotionRoleId((int)adviceMotionId);
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(motionRoleId.GetValueOrDefault());
				if (roleConfig == null)
				{
					return;
				}
				SModelConfig modelConfig = ModelUtil.GetModelConfig(roleConfig.Value.MeshId);
				if (modelConfig == null)
				{
					return;
				}
				string memoryTag = UiConfig.Instance.GetMemoryTag(EUiViewName.AdviceInfoView);
				ResourceSystem.Instance.LoadAsync<USkeletalMesh>(modelConfig.网格体.ToAssetPathName(), delegate([Nullable(2)] USkeletalMesh result, string path)
				{
					if (this.SkeletalMeshInternal != null && result != null)
					{
						this.SkeletalMeshInternal.SetSkeletalMesh(result, true);
						this.SkeletalMeshInternal.SetHiddenInGame(true, false);
					}
					loadMeshCompleteCall();
				}, 100, memoryTag);
				if (this.ActorInternal != null)
				{
					this.ActorInternal.OnDestroyed.Add(new Action<AActor>(this.OnActorDestroy));
				}
				return;
			}
		}
	}

	// Token: 0x0600A6A8 RID: 42664 RVA: 0x002550AC File Offset: 0x002532AC
	private void PlayInteractAnimation(int entityId)
	{
		this.ClearTimer();
		this.PlayState = true;
		this.RemoveMat();
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		bool flag;
		if (component == null)
		{
			flag = (null != null);
		}
		else
		{
			AdviceEntityData adviceInfo = component.GetAdviceInfo();
			flag = (((adviceInfo != null) ? adviceInfo.GetAdviceData() : null) != null);
		}
		if (!flag)
		{
			return;
		}
		long adviceMotionId = component.GetAdviceInfo().GetAdviceData().GetAdviceMotionId();
		if (adviceMotionId == 0L)
		{
			return;
		}
		this.RemoveMat();
		USkeletalMeshComponent meshComponent = this.SkeletalMeshInternal;
		string motionAnimation = MotionConfig.Instance.GetMotionAnimation((int)adviceMotionId);
		string memoryTag = UiConfig.Instance.GetMemoryTag(EUiViewName.AdviceInfoView);
		if (motionAnimation != null)
		{
			ResourceSystem.Instance.LoadAsync<UAnimationAsset>(motionAnimation, delegate([Nullable(2)] UAnimationAsset result, string path)
			{
				if (this.PlayState && meshComponent != null && result != null)
				{
					meshComponent.PlayAnimation(result, false);
				}
				this.OnLoadCompleteCheckForShow();
			}, 100, memoryTag);
		}
		if (meshComponent != null)
		{
			meshComponent.SetPlayRate(1f);
			meshComponent.SetPosition(1f, true);
		}
		if (this.CharRenderingComponent != null && this.SkeletalMeshInternal != null)
		{
			this.CharRenderingComponent.AddComponentByCase(ECharacterControllerCaseType.BodyCase0, this.SkeletalMeshInternal);
		}
		if (this.CharRenderingComponent != null)
		{
			string adviceModelMat = AdviceConfig.Instance.GetAdviceModelMat();
			ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(adviceModelMat, delegate([Nullable(2)] PD_CharacterControllerData_C result, string path)
			{
				if (this.PlayState && this.CharRenderingComponent != null && result != null)
				{
					this.MaterialEffectHandle = this.CharRenderingComponent.AddMaterialControllerData(result);
				}
				this.OnLoadCompleteCheckForShow();
			}, 100, memoryTag);
		}
		AdviceModel.Instance.AddPlayingMotionEntity(this.CurrentEntity, this);
	}

	// Token: 0x0600A6A9 RID: 42665 RVA: 0x00255200 File Offset: 0x00253400
	private void OnLoadCompleteCheckForShow()
	{
		USkeletalMeshComponent meshComponent = this.SkeletalMeshInternal;
		if (meshComponent != null && this.PlayState && this.MaterialEffectHandle > 0)
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				if (meshComponent != null && this.PlayState && this.MaterialEffectHandle > 0)
				{
					meshComponent.SetHiddenInGame(false, false);
					this.RevertTimer = TimerSystem.Instance.Delay(new TTimerAction(this.RevertToNormalModel), 3000f, null, null, true, 1f);
				}
			}, 20f, null, null, true, 1f);
		}
	}

	// Token: 0x0600A6AA RID: 42666 RVA: 0x00255264 File Offset: 0x00253464
	private void RevertToNormalModel(float deltaTime)
	{
		this.RemoveMat();
		USkeletalMeshComponent skeletalMeshInternal = this.SkeletalMeshInternal;
		if (skeletalMeshInternal != null)
		{
			skeletalMeshInternal.SetHiddenInGame(true, false);
		}
		this.RevertTimer = null;
		AdviceModel.Instance.RecycleMotionActor(this);
		AdviceModel.Instance.RemovePlayingMotionEntity(this.CurrentEntity);
	}

	// Token: 0x0600A6AB RID: 42667 RVA: 0x002552AB File Offset: 0x002534AB
	private void ClearTimer()
	{
		this.PlayState = false;
		if (this.RevertTimer != null)
		{
			TimerSystem.Instance.Remove(this.RevertTimer);
			this.RevertTimer = null;
		}
	}

	// Token: 0x0600A6AC RID: 42668 RVA: 0x002552D4 File Offset: 0x002534D4
	private void RemoveMat()
	{
		if (this.CharRenderingComponent != null && this.MaterialEffectHandle > 0)
		{
			this.CharRenderingComponent.RemoveMaterialControllerDataWithEnding(this.MaterialEffectHandle);
			this.MaterialEffectHandle = 0;
		}
	}

	// Token: 0x0600A6AD RID: 42669 RVA: 0x00255300 File Offset: 0x00253500
	public void OnActorDestroy(AActor actor)
	{
		this.ClearTimer();
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			ActorSystem.Instance.Put("AdviceMotionActor.OnActorDestroy", this.ActorInternal, null);
			this.ActorInternal = null;
		}
		AdviceModel.Instance.RemovePlayingMotionEntity(this.CurrentEntity);
		AdviceModel.Instance.RemoveMotionActor(this);
	}

	// Token: 0x04004B4D RID: 19277
	private TimerHandle RevertTimer;

	// Token: 0x04004B4E RID: 19278
	protected AActor ActorInternal;

	// Token: 0x04004B4F RID: 19279
	protected USkeletalMeshComponent SkeletalMeshInternal;

	// Token: 0x04004B50 RID: 19280
	private CharRenderingComponent CharRenderingComponent;

	// Token: 0x04004B51 RID: 19281
	private int MaterialEffectHandle;

	// Token: 0x04004B52 RID: 19282
	private int CurrentEntity;

	// Token: 0x04004B53 RID: 19283
	private bool PlayState;

	// Token: 0x04004B54 RID: 19284
	private const int REVERTIME = 3000;
}
