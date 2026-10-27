using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x02002C52 RID: 11346
[NullableContext(2)]
[Nullable(0)]
public class UiCameraStructure
{
	// Token: 0x06017AC6 RID: 96966 RVA: 0x0060581F File Offset: 0x00603A1F
	[NullableContext(1)]
	public void Initialize(UiCamera ownerUiCamera)
	{
		this.OwnerUiCamera = ownerUiCamera;
		this.CameraActor = this.OwnerUiCamera.GetCameraActor();
		this.OwnActor = this.OnSpawnStructureActor();
		this.SpringArmComponent = this.OnSetSpringArmComponent();
		this.OnInitialize();
	}

	// Token: 0x06017AC7 RID: 96967 RVA: 0x00605857 File Offset: 0x00603A57
	public void Destroy()
	{
		this.Deactivate();
		this.OnDestroy();
		this.CameraActor = null;
		this.OwnActor = null;
	}

	// Token: 0x06017AC8 RID: 96968 RVA: 0x00605873 File Offset: 0x00603A73
	public bool IsValid()
	{
		return this.CameraActor != null && this.OwnActor != null && this.CameraActor.IsValid() && this.OwnActor.IsValid();
	}

	// Token: 0x06017AC9 RID: 96969 RVA: 0x006058A4 File Offset: 0x00603AA4
	public void Activate()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.BB;
		string message = "激活相机结构";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.OnActivate();
	}

	// Token: 0x06017ACA RID: 96970 RVA: 0x006058E8 File Offset: 0x00603AE8
	public void Deactivate()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.BB;
		string message = "休眠相机结构";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.OnDeactivate();
	}

	// Token: 0x06017ACB RID: 96971 RVA: 0x0060592C File Offset: 0x00603B2C
	protected virtual void OnActivate()
	{
	}

	// Token: 0x06017ACC RID: 96972 RVA: 0x0060592E File Offset: 0x00603B2E
	protected virtual void OnDeactivate()
	{
	}

	// Token: 0x06017ACD RID: 96973 RVA: 0x00605930 File Offset: 0x00603B30
	protected virtual AActor OnSpawnStructureActor()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.BB;
		string message = "没有创建StructureActor";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06017ACE RID: 96974 RVA: 0x00605970 File Offset: 0x00603B70
	protected virtual USpringArmComponent OnSetSpringArmComponent()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.BB;
		string message = "没有实现OnSetSpringArmComponent";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06017ACF RID: 96975 RVA: 0x006059AF File Offset: 0x00603BAF
	[NullableContext(1)]
	public USpringArmComponent GetSpringArmComponent()
	{
		return this.SpringArmComponent;
	}

	// Token: 0x06017AD0 RID: 96976 RVA: 0x006059B7 File Offset: 0x00603BB7
	protected virtual void OnInitialize()
	{
	}

	// Token: 0x06017AD1 RID: 96977 RVA: 0x006059B9 File Offset: 0x00603BB9
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06017AD2 RID: 96978 RVA: 0x006059BC File Offset: 0x00603BBC
	[NullableContext(1)]
	protected void AttachToComponent(USceneComponent sceneComponent, FName slotName = default(FName), EAttachmentRule locationRule = EAttachmentRule.SnapToTarget, EAttachmentRule rotationRule = EAttachmentRule.SnapToTarget, EAttachmentRule scaleRule = EAttachmentRule.KeepWorld)
	{
		if (slotName.Equals(default(FName)))
		{
			slotName = FNameUtil.NONE;
		}
		BP_CineCamera_C cameraActor = this.CameraActor;
		if (cameraActor == null || !cameraActor.IsValid())
		{
			return;
		}
		this.CameraActor.K2_AttachToComponent(sceneComponent, slotName, locationRule, rotationRule, scaleRule, false, true);
	}

	// Token: 0x06017AD3 RID: 96979 RVA: 0x00605A0E File Offset: 0x00603C0E
	protected void DetachFromComponent(EDetachmentRule locationRule = EDetachmentRule.KeepWorld, EDetachmentRule rotationRule = EDetachmentRule.KeepWorld, EDetachmentRule scaleRule = EDetachmentRule.KeepWorld)
	{
		BP_CineCamera_C cameraActor = this.CameraActor;
		if (cameraActor == null || !cameraActor.IsValid())
		{
			return;
		}
		this.CameraActor.K2_DetachFromActor(locationRule, rotationRule, scaleRule);
	}

	// Token: 0x06017AD4 RID: 96980 RVA: 0x00605A36 File Offset: 0x00603C36
	public void DetachUiCameraSpringActor(EDetachmentRule locationRule, EDetachmentRule rotationRule, EDetachmentRule scaleRule)
	{
		AActor ownActor = this.OwnActor;
		if (ownActor == null)
		{
			return;
		}
		ownActor.K2_DetachFromActor(locationRule, rotationRule, scaleRule);
	}

	// Token: 0x06017AD5 RID: 96981 RVA: 0x00605A4C File Offset: 0x00603C4C
	public void SetActorTransform(FTransformDouble transform)
	{
		FHitResult fhitResult = new FHitResult();
		this.OwnActor.D_K2_SetActorTransform(transform, false, ref fhitResult, false);
	}

	// Token: 0x06017AD6 RID: 96982 RVA: 0x00605A74 File Offset: 0x00603C74
	public void SetActorLocation(FVectorDouble location)
	{
		if (this.OwnActor.D_K2_GetActorLocation().Equals(location, 1E-08))
		{
			return;
		}
		FHitResult fhitResult = new FHitResult();
		this.OwnActor.D_K2_SetActorLocation(location, false, ref fhitResult, false);
	}

	// Token: 0x06017AD7 RID: 96983 RVA: 0x00605ABC File Offset: 0x00603CBC
	public void SetActorRelativeLocation(FVectorDouble location)
	{
		FHitResult fhitResult = new FHitResult();
		if (this.OwnActor.GetParentComponent() != null)
		{
			this.OwnActor.D_K2_SetActorRelativeLocation(location, false, ref fhitResult, false);
			return;
		}
		this.OwnActor.D_K2_SetActorLocation(location, false, ref fhitResult, false);
	}

	// Token: 0x06017AD8 RID: 96984 RVA: 0x00605B00 File Offset: 0x00603D00
	public void SetCameraActorRelativeLocation(FVectorDouble location)
	{
		FHitResult fhitResult = new FHitResult();
		this.CameraActor.D_K2_SetActorRelativeLocation(location, false, ref fhitResult, false);
	}

	// Token: 0x06017AD9 RID: 96985 RVA: 0x00605B23 File Offset: 0x00603D23
	public void SetActorRotation(FRotator rotation)
	{
		if (UKismetMathLibrary.EqualEqual_RotatorRotator(this.OwnActor.K2_GetActorRotation(), rotation, 0.0001f))
		{
			return;
		}
		this.OwnActor.K2_SetActorRotation(rotation, false);
	}

	// Token: 0x06017ADA RID: 96986 RVA: 0x00605B4C File Offset: 0x00603D4C
	public void SetActorLocationAndRotation(FVectorDouble location, FRotator rotation)
	{
		FHitResult fhitResult = new FHitResult();
		this.OwnActor.D_K2_SetActorLocationAndRotation(location, rotation, true, ref fhitResult, false);
	}

	// Token: 0x06017ADB RID: 96987 RVA: 0x00605B74 File Offset: 0x00603D74
	public void SetUiCameraAnimationRelativeRotation(FRotator rotation)
	{
		FHitResult fhitResult = new FHitResult();
		this.OwnActor.K2_SetActorRelativeRotation(rotation, false, ref fhitResult, false);
	}

	// Token: 0x06017ADC RID: 96988 RVA: 0x00605B98 File Offset: 0x00603D98
	public void SetSprintArmRelativeRotation(FRotator rotation)
	{
		FHitResult fhitResult = new FHitResult();
		this.SpringArmComponent.K2_SetRelativeRotation(rotation, false, ref fhitResult, false);
	}

	// Token: 0x06017ADD RID: 96989 RVA: 0x00605BBC File Offset: 0x00603DBC
	public void SetSpringArmRelativeLocation(FVectorDouble location)
	{
		FHitResult fhitResult = new FHitResult();
		this.SpringArmComponent.D_K2_SetRelativeLocation(location, false, ref fhitResult, false);
	}

	// Token: 0x06017ADE RID: 96990 RVA: 0x00605BDF File Offset: 0x00603DDF
	public void SetCollisionTest(bool bCollisionTest)
	{
		this.SpringArmComponent.bDoCollisionTest = bCollisionTest;
	}

	// Token: 0x06017ADF RID: 96991 RVA: 0x00605BED File Offset: 0x00603DED
	public void SetSpringArmLength(float length)
	{
		this.SpringArmComponent.TargetArmLength = length;
	}

	// Token: 0x06017AE0 RID: 96992 RVA: 0x00605BFB File Offset: 0x00603DFB
	public float GetSpringArmLength()
	{
		return this.SpringArmComponent.TargetArmLength;
	}

	// Token: 0x06017AE1 RID: 96993 RVA: 0x00605C08 File Offset: 0x00603E08
	public FVectorDouble GetSpringRelativeLocation()
	{
		FVector relativeLocation = this.SpringArmComponent.RelativeLocation;
		return new FVectorDouble(ref relativeLocation);
	}

	// Token: 0x06017AE2 RID: 96994 RVA: 0x00605C28 File Offset: 0x00603E28
	public FRotator GetSpringRelativeRotation()
	{
		return this.SpringArmComponent.RelativeRotation;
	}

	// Token: 0x06017AE3 RID: 96995 RVA: 0x00605C35 File Offset: 0x00603E35
	public FVectorDouble GetActorLocation()
	{
		return this.OwnActor.D_K2_GetActorLocation();
	}

	// Token: 0x06017AE4 RID: 96996 RVA: 0x00605C42 File Offset: 0x00603E42
	public FRotator GetActorRotation()
	{
		return this.OwnActor.K2_GetActorRotation();
	}

	// Token: 0x06017AE5 RID: 96997 RVA: 0x00605C4F File Offset: 0x00603E4F
	[NullableContext(1)]
	public AActor GetOwnActor()
	{
		return this.OwnActor;
	}

	// Token: 0x0400B06B RID: 45163
	private UiCamera OwnerUiCamera;

	// Token: 0x0400B06C RID: 45164
	protected BP_CineCamera_C CameraActor;

	// Token: 0x0400B06D RID: 45165
	protected USpringArmComponent SpringArmComponent;

	// Token: 0x0400B06E RID: 45166
	protected AActor OwnActor;
}
