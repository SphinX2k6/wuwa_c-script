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

// Token: 0x02000B7E RID: 2942
[NullableContext(2)]
[Nullable(0)]
public class AdviceMotionActor
{
	// Token: 0x06007A86 RID: 31366 RVA: 0x0025F22C File Offset: 0x0025D42C
	public void PlayMotion(int entityId)
	{
		this.CurrentEntity = entityId;
		this.InitInternalActor(entityId, delegate
		{
			this.PlayInteractAnimation(entityId);
		});
	}

	// Token: 0x06007A87 RID: 31367 RVA: 0x0025F274 File Offset: 0x0025D474
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

	// Token: 0x06007A88 RID: 31368 RVA: 0x0025F4BC File Offset: 0x0025D6BC
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

	// Token: 0x06007A89 RID: 31369 RVA: 0x0025F610 File Offset: 0x0025D810
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

	// Token: 0x06007A8A RID: 31370 RVA: 0x0025F674 File Offset: 0x0025D874
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

	// Token: 0x06007A8B RID: 31371 RVA: 0x0025F6BB File Offset: 0x0025D8BB
	private void ClearTimer()
	{
		this.PlayState = false;
		if (this.RevertTimer != null)
		{
			TimerSystem.Instance.Remove(this.RevertTimer);
			this.RevertTimer = null;
		}
	}

	// Token: 0x06007A8C RID: 31372 RVA: 0x0025F6E4 File Offset: 0x0025D8E4
	private void RemoveMat()
	{
		if (this.CharRenderingComponent != null && this.MaterialEffectHandle > 0)
		{
			this.CharRenderingComponent.RemoveMaterialControllerDataWithEnding(this.MaterialEffectHandle);
			this.MaterialEffectHandle = 0;
		}
	}

	// Token: 0x06007A8D RID: 31373 RVA: 0x0025F710 File Offset: 0x0025D910
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

	// Token: 0x04004BF4 RID: 19444
	private TimerHandle RevertTimer;

	// Token: 0x04004BF5 RID: 19445
	protected AActor ActorInternal;

	// Token: 0x04004BF6 RID: 19446
	protected USkeletalMeshComponent SkeletalMeshInternal;

	// Token: 0x04004BF7 RID: 19447
	private CharRenderingComponent CharRenderingComponent;

	// Token: 0x04004BF8 RID: 19448
	private int MaterialEffectHandle;

	// Token: 0x04004BF9 RID: 19449
	private int CurrentEntity;

	// Token: 0x04004BFA RID: 19450
	private bool PlayState;

	// Token: 0x04004BFB RID: 19451
	private const int REVERTIME = 3000;
}
