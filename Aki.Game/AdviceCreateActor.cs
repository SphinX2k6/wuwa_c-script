using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016BD RID: 5821
[NullableContext(2)]
[Nullable(0)]
public class AdviceCreateActor
{
	// Token: 0x0600A647 RID: 42567 RVA: 0x00253112 File Offset: 0x00251312
	public void Init()
	{
		this.InitInternalActor();
		this.LoadDefaultModel();
	}

	// Token: 0x0600A648 RID: 42568 RVA: 0x00253120 File Offset: 0x00251320
	public void PlayAnimation(int motionId)
	{
		this.SetInteractionActorActive(false);
		this.Play(motionId);
	}

	// Token: 0x0600A649 RID: 42569 RVA: 0x00253130 File Offset: 0x00251330
	private void SetInteractionActorActive(bool state)
	{
		TArray<AActor> sceneInteractionAllActorsInLevel = SceneInteractionManager.Get().GetSceneInteractionAllActorsInLevel(this.SceneInteractionLevelHandleId);
		if (sceneInteractionAllActorsInLevel == null)
		{
			return;
		}
		int num = sceneInteractionAllActorsInLevel.Num();
		for (int i = 0; i < num; i++)
		{
			AActor aactor = sceneInteractionAllActorsInLevel.Get(i);
			if (aactor != null)
			{
				aactor.SetActorHiddenInGame(!state);
			}
		}
	}

	// Token: 0x0600A64A RID: 42570 RVA: 0x0025317A File Offset: 0x0025137A
	public void HideAnimation()
	{
		this.ClearTimer();
		this.RemoveMat();
		if (this.SkeletalMeshInternal != null)
		{
			this.SkeletalMeshInternal.SetHiddenInGame(true, false);
			this.SkeletalMeshInternal.Stop();
		}
		this.SetInteractionActorActive(true);
	}

	// Token: 0x0600A64B RID: 42571 RVA: 0x002531B0 File Offset: 0x002513B0
	private void LoadDefaultModel()
	{
		SModelConfig modelConfig = ModelUtil.GetModelConfig(AdviceConfig.Instance.GetAdviceDefaultModelConfig());
		if (modelConfig == null)
		{
			return;
		}
		FSoftObjectPath 场景交互物 = modelConfig.场景交互物;
		if (场景交互物 == null)
		{
			return;
		}
		global::Vector vector = global::Vector.Create();
		Rotator rotator = Rotator.Create();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null) == null)
		{
			return;
		}
		vector.DeepCopy(baseCharacter.CharacterActorComponent.ActorLocationProxy);
		global::Vector vector2 = vector;
		double z = vector2.Z;
		UCapsuleComponent capsuleComponent = baseCharacter.CharacterActorComponent.Actor.CapsuleComponent;
		vector2.Z = z - (double)((capsuleComponent != null) ? capsuleComponent.GetScaledCapsuleHalfHeight() : 0f);
		rotator.DeepCopy(baseCharacter.CharacterActorComponent.ActorRotationProxy);
		AActor currentCameraActor = CameraModel.Instance.MainModel.CurrentCameraActor;
		if (currentCameraActor != null)
		{
			rotator.Yaw = currentCameraActor.D_GetTransform().Rotator().Yaw + 90f;
		}
		this.SceneInteractionLevelHandleId = SceneInteractionManager.Get().CreateSceneInteractionLevel(场景交互物.AssetPathName.ToString(), new EKuroSceneInteractionState?(EKuroSceneInteractionState.State1), vector.ToUeVector(false), rotator.ToUeRotator(), null, true, false, 0, 0, null);
	}

	// Token: 0x0600A64C RID: 42572 RVA: 0x002532D4 File Offset: 0x002514D4
	private void InitInternalActor()
	{
		if (this.ActorInternal == null)
		{
			this.ActorInternal = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
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
		if (this.SkeletalMeshInternal != null)
		{
			this.SkeletalMeshInternal.SetHiddenInGame(true, false);
			this.SkeletalMeshInternal.Stop();
		}
		this.RefreshPosition();
		if (this.ActorInternal != null)
		{
			this.ActorInternal.OnDestroyed.Add(new Action<AActor>(this.OnActorDestroy));
		}
	}

	// Token: 0x0600A64D RID: 42573 RVA: 0x00253410 File Offset: 0x00251610
	public void RefreshPosition()
	{
		global::Vector vector = global::Vector.Create();
		Rotator rotator = Rotator.Create();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null) == null)
		{
			return;
		}
		vector.DeepCopy(baseCharacter.CharacterActorComponent.ActorLocationProxy);
		global::Vector vector2 = vector;
		double z = vector2.Z;
		UCapsuleComponent capsuleComponent = baseCharacter.CharacterActorComponent.Actor.CapsuleComponent;
		vector2.Z = z - (double)((capsuleComponent != null) ? capsuleComponent.GetScaledCapsuleHalfHeight() : 0f);
		rotator.DeepCopy(baseCharacter.CharacterActorComponent.ActorRotationProxy);
		AActor currentCameraActor = CameraModel.Instance.MainModel.CurrentCameraActor;
		if (currentCameraActor != null)
		{
			rotator.Yaw = currentCameraActor.D_GetTransform().Rotator().Yaw + 90f;
		}
		FHitResult fhitResult = new FHitResult();
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null)
		{
			actorInternal.D_K2_SetActorLocation(vector.ToUeVector(false), false, ref fhitResult, true);
		}
		AActor actorInternal2 = this.ActorInternal;
		if (actorInternal2 == null)
		{
			return;
		}
		actorInternal2.K2_SetActorRotation(rotator.ToUeRotator(), false);
	}

	// Token: 0x0600A64E RID: 42574 RVA: 0x00253500 File Offset: 0x00251700
	private void Play(int motionId)
	{
		this.PlayState = true;
		this.ClearTimer();
		this.RemoveMat();
		USkeletalMeshComponent meshComponent = this.SkeletalMeshInternal;
		if (this.SkeletalMeshInternal != null)
		{
			this.SkeletalMeshInternal.SetHiddenInGame(true, false);
			this.SkeletalMeshInternal.Stop();
		}
		int? motionRoleId = MotionConfig.Instance.GetMotionRoleId(motionId);
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
		this.AnimateAssetState = false;
		this.MeshLoadState = false;
		this.MatLoadState = false;
		this.CurrentAnimateAsset = null;
		string memoryTag = UiConfig.Instance.GetMemoryTag(EUiViewName.AdviceCreateView);
		ResourceSystem.Instance.LoadAsync<USkeletalMesh>(modelConfig.网格体.ToAssetPathName(), delegate([Nullable(2)] USkeletalMesh result, string path)
		{
			if (meshComponent != null && result != null)
			{
				meshComponent.SetSkeletalMesh(result, true);
			}
			this.MeshLoadState = true;
			this.CheckLoadStateAndShowActor();
		}, 100, memoryTag);
		string motionAnimation = MotionConfig.Instance.GetMotionAnimation(motionId);
		if (motionAnimation != null)
		{
			ResourceSystem.Instance.LoadAsync<UAnimationAsset>(motionAnimation, delegate([Nullable(2)] UAnimationAsset result, string path)
			{
				this.AnimateAssetState = true;
				this.CurrentAnimateAsset = result;
				this.CheckLoadStateAndShowActor();
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
			string adviceModelMat = AdviceConfig.Instance.GetAdviceModelMat();
			ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(adviceModelMat, delegate([Nullable(2)] PD_CharacterControllerData_C result, string path)
			{
				this.MatLoadState = true;
				if (this.PlayState && this.CharRenderingComponent != null && result != null)
				{
					this.MaterialEffectHandle = this.CharRenderingComponent.AddMaterialControllerData(result);
				}
				this.CheckLoadStateAndShowActor();
			}, 100, memoryTag);
		}
		this.RevertTimer = TimerSystem.Instance.Delay(new TTimerAction(this.RevertToNormalModel), 3000f, null, null, true, 1f);
	}

	// Token: 0x0600A64F RID: 42575 RVA: 0x002536C0 File Offset: 0x002518C0
	private void CheckLoadStateAndShowActor()
	{
		if (this.MatLoadState && this.MeshLoadState && this.AnimateAssetState && this.PlayState && this.SkeletalMeshInternal != null)
		{
			this.SkeletalMeshInternal.SetHiddenInGame(false, false);
			this.SkeletalMeshInternal.Play(true);
			if (this.CurrentAnimateAsset != null)
			{
				this.SkeletalMeshInternal.PlayAnimation(this.CurrentAnimateAsset as UAnimationAsset, false);
			}
		}
	}

	// Token: 0x0600A650 RID: 42576 RVA: 0x0025372D File Offset: 0x0025192D
	private void RevertToNormalModel(float deltaTime)
	{
		this.RemoveMat();
		if (this.SkeletalMeshInternal != null)
		{
			this.SkeletalMeshInternal.SetHiddenInGame(true, false);
			this.SkeletalMeshInternal.Stop();
		}
		this.ClearTimer();
		this.SetInteractionActorActive(true);
	}

	// Token: 0x0600A651 RID: 42577 RVA: 0x00253762 File Offset: 0x00251962
	private void RemoveMat()
	{
		if (this.CharRenderingComponent != null && this.MaterialEffectHandle > 0)
		{
			this.CharRenderingComponent.RemoveMaterialControllerDataWithEnding(this.MaterialEffectHandle);
			this.MaterialEffectHandle = 0;
		}
	}

	// Token: 0x0600A652 RID: 42578 RVA: 0x00253790 File Offset: 0x00251990
	public void Destroy()
	{
		this.ClearTimer();
		SceneInteractionManager.Get().DestroySceneInteraction(this.SceneInteractionLevelHandleId);
		if (this.ActorInternal != null)
		{
			ActorSystem.Instance.Put("AdviceCreateActor.Destroy", this.ActorInternal, null);
			this.ActorInternal = null;
		}
		AdviceModel.Instance.OnAdviceCreateActorDestroy();
	}

	// Token: 0x0600A653 RID: 42579 RVA: 0x002537E4 File Offset: 0x002519E4
	private void ClearTimer()
	{
		if (this.RevertTimer != null)
		{
			TimerSystem.Instance.Remove(this.RevertTimer);
			this.RevertTimer = null;
		}
	}

	// Token: 0x0600A654 RID: 42580 RVA: 0x00253808 File Offset: 0x00251A08
	private void OnActorDestroy(AActor actor)
	{
		this.ClearTimer();
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			ActorSystem.Instance.Put("AdviceCreateActor.OnActorDestroy", this.ActorInternal, null);
			this.ActorInternal = null;
		}
		AdviceModel.Instance.OnAdviceCreateActorDestroy();
	}

	// Token: 0x04004B03 RID: 19203
	protected AActor ActorInternal;

	// Token: 0x04004B04 RID: 19204
	protected USkeletalMeshComponent SkeletalMeshInternal;

	// Token: 0x04004B05 RID: 19205
	private CharRenderingComponent CharRenderingComponent;

	// Token: 0x04004B06 RID: 19206
	private int MaterialEffectHandle;

	// Token: 0x04004B07 RID: 19207
	private bool PlayState;

	// Token: 0x04004B08 RID: 19208
	private int SceneInteractionLevelHandleId;

	// Token: 0x04004B09 RID: 19209
	private TimerHandle RevertTimer;

	// Token: 0x04004B0A RID: 19210
	private object CurrentAnimateAsset;

	// Token: 0x04004B0B RID: 19211
	private bool AnimateAssetState;

	// Token: 0x04004B0C RID: 19212
	private bool MeshLoadState;

	// Token: 0x04004B0D RID: 19213
	private bool MatLoadState;

	// Token: 0x04004B0E RID: 19214
	private const int REVERTIME = 3000;
}
