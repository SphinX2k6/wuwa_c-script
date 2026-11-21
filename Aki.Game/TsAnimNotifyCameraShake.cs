using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A2 RID: 418
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraShake.TsAnimNotifyCameraShake_C")]
public class TsAnimNotifyCameraShake : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700046B RID: 1131
	// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00090213 File Offset: 0x0008E413
	// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x00090227 File Offset: 0x0008E427
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TSubclassOf<UMatineeCameraShake> 震动配置
	{
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraShake.__PropertyOffset_震动配置);
		}
		[param: Nullable(new byte[]
		{
			0,
			1
		})]
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraShake.__PropertyOffset_震动配置) = value;
		}
	}

	// Token: 0x1700046C RID: 1132
	// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x0009023C File Offset: 0x0008E43C
	// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0009024C File Offset: 0x0008E44C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bForSelf
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraShake.__PropertyOffset_bForSelf) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraShake.__PropertyOffset_bForSelf) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x0009025D File Offset: 0x0008E45D
	// (set) Token: 0x06001AF8 RID: 6904 RVA: 0x0009026D File Offset: 0x0008E46D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Radius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCameraShake.__PropertyOffset_Radius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCameraShake.__PropertyOffset_Radius) = value;
		}
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x00090280 File Offset: 0x0008E480
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyCameraShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyCameraShake.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x00090338 File Offset: 0x0008E538
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
		if (tsBaseCharacter == null && tsBaseVehicle == null)
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById((tsBaseCharacter != null) ? tsBaseCharacter.EntityId : tsBaseVehicle.EntityId);
		if (entityById == null || !entityById.Valid)
		{
			return false;
		}
		if (!CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityById))
		{
			return false;
		}
		if (!CameraUtility.CheckCameraShakeCondition(entityById))
		{
			return false;
		}
		ECustomCameraMode? cameraMode = CameraController.Instance.MainModel.CameraMode;
		ECustomCameraMode ecustomCameraMode = ECustomCameraMode.LockOn;
		if (!(cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null))
		{
			return false;
		}
		if (!CameraController.Instance.GetMainPlayerCameraManager().IsValid())
		{
			return false;
		}
		if (this.bForSelf)
		{
			CameraController.Instance.PlayCameraShake(this.震动配置.Get().ToClass(), new float?(CameraController.Instance.MainModel.ShakeModify), new ECameraShakePlaySpace?(ECameraShakePlaySpace.CameraLocal), null, true, false, "MainCamera");
		}
		else
		{
			CameraController instance = CameraController.Instance;
			TSubclassOf<UCameraShakeBase>? shakeClass = new TSubclassOf<UCameraShakeBase>?(this.震动配置.Get().ToClass());
			AActor owner2 = meshComp.GetOwner();
			instance.PlayWorldCameraShake(shakeClass, (owner2 != null) ? new FVectorDouble?(owner2.D_K2_GetActorLocation()) : null, this.Radius, this.Radius, 1f, true, "MainCamera");
		}
		return true;
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x0009049C File Offset: 0x0008E69C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyCameraShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyCameraShake.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x0009052C File Offset: 0x0008E72C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "相机震屏";
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x00090533 File Offset: 0x0008E733
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCameraShake._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraShake.TsAnimNotifyCameraShake_C");
		}
		return TsAnimNotifyCameraShake._ClassPtr;
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x00090558 File Offset: 0x0008E758
	public TsAnimNotifyCameraShake() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x00090580 File Offset: 0x0008E780
	[NullableContext(1)]
	public TsAnimNotifyCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x000905B3 File Offset: 0x0008E7B3
	protected TsAnimNotifyCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x000905BC File Offset: 0x0008E7BC
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x000905EF File Offset: 0x0008E7EF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001163 RID: 4451
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraShake.TsAnimNotifyCameraShake_C";

	// Token: 0x04001164 RID: 4452
	private static IntPtr _ClassPtr;

	// Token: 0x04001165 RID: 4453
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001166 RID: 4454
	private static int __PropertyOffset_震动配置;

	// Token: 0x04001167 RID: 4455
	private static int __PropertyOffset_bForSelf;

	// Token: 0x04001168 RID: 4456
	private static int __PropertyOffset_Radius;
}
