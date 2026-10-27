using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.UI.NewModule.UiCameraAnimation;
using UnrealEngine;

// Token: 0x02002C51 RID: 11345
[NullableContext(1)]
[Nullable(0)]
public class UiCameraSpringStructure : UiCameraStructure
{
	// Token: 0x06017ABC RID: 96956 RVA: 0x006056E0 File Offset: 0x006038E0
	protected override AActor OnSpawnStructureActor()
	{
		UObject world = GlobalData.World;
		FQuat fquat = new FQuat(0f, 0f, 0f, 0f);
		FVector fvector = new FVector(0f);
		FVector fvector2 = new FVector(1f, 1f, 1f);
		FTransform ftransform = new FTransform(ref fquat, ref fvector, ref fvector2);
		BP_UiCameraAnimation_C bp_UiCameraAnimation_C = UGameplayStatics.BeginDeferredActorSpawnFromClass(world, BP_UiCameraAnimation_C.StaticClass(), ftransform, ESpawnActorCollisionHandlingMethod.Undefined, null) as BP_UiCameraAnimation_C;
		bp_UiCameraAnimation_C.SetTickableWhenPaused(true);
		UGameplayStatics.FinishSpawningActor(bp_UiCameraAnimation_C, ftransform);
		this.UiCameraSpringActor = bp_UiCameraAnimation_C;
		USpringArmComponent springArm = this.UiCameraSpringActor.SpringArm;
		if (springArm != null)
		{
			springArm.SetTickableWhenPaused(true);
		}
		UCameraComponent camera = this.UiCameraSpringActor.Camera;
		if (camera != null)
		{
			camera.SetTickableWhenPaused(true);
		}
		return bp_UiCameraAnimation_C;
	}

	// Token: 0x06017ABD RID: 96957 RVA: 0x00605798 File Offset: 0x00603998
	protected override USpringArmComponent OnSetSpringArmComponent()
	{
		return this.UiCameraSpringActor.SpringArm;
	}

	// Token: 0x06017ABE RID: 96958 RVA: 0x006057A5 File Offset: 0x006039A5
	protected override void OnInitialize()
	{
	}

	// Token: 0x06017ABF RID: 96959 RVA: 0x006057A7 File Offset: 0x006039A7
	protected override void OnDestroy()
	{
		ActorSystem.Instance.Put("UiCameraSpringStructure.OnDestroy", this.UiCameraSpringActor, null);
		this.UiCameraSpringActor = null;
	}

	// Token: 0x06017AC0 RID: 96960 RVA: 0x006057C7 File Offset: 0x006039C7
	protected override void OnActivate()
	{
		this.CameraActorAttachToSpringActor();
	}

	// Token: 0x06017AC1 RID: 96961 RVA: 0x006057CF File Offset: 0x006039CF
	protected override void OnDeactivate()
	{
		this.CameraActorDetachFromSpringActor();
	}

	// Token: 0x06017AC2 RID: 96962 RVA: 0x006057D8 File Offset: 0x006039D8
	public void CameraActorAttachToSpringActor()
	{
		UCameraComponent camera = this.UiCameraSpringActor.Camera;
		base.AttachToComponent(camera, default(FName), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld);
	}

	// Token: 0x06017AC3 RID: 96963 RVA: 0x00605804 File Offset: 0x00603A04
	public void CameraActorDetachFromSpringActor()
	{
		base.DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
	}

	// Token: 0x06017AC4 RID: 96964 RVA: 0x0060580F File Offset: 0x00603A0F
	public BP_UiCameraAnimation_C GetSpringActor()
	{
		return this.UiCameraSpringActor;
	}

	// Token: 0x0400B06A RID: 45162
	[Nullable(2)]
	private BP_UiCameraAnimation_C UiCameraSpringActor;
}
