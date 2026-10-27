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

// Token: 0x0200019E RID: 414
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraShake.TsAnimNotifyCameraShake_C")]
public class TsAnimNotifyCameraShake : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00089C27 File Offset: 0x00087E27
	// (set) Token: 0x06001A57 RID: 6743 RVA: 0x00089C3B File Offset: 0x00087E3B
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

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00089C50 File Offset: 0x00087E50
	// (set) Token: 0x06001A59 RID: 6745 RVA: 0x00089C60 File Offset: 0x00087E60
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

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00089C71 File Offset: 0x00087E71
	// (set) Token: 0x06001A5B RID: 6747 RVA: 0x00089C81 File Offset: 0x00087E81
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

	// Token: 0x06001A5C RID: 6748 RVA: 0x00089C94 File Offset: 0x00087E94
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x00089D34 File Offset: 0x00087F34
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
			TSubclassOf<UCameraShakeBase> shakeClass = this.震动配置.Get().ToClass();
			AActor owner2 = meshComp.GetOwner();
			instance.PlayWorldCameraShake(shakeClass, (owner2 != null) ? new FVectorDouble?(owner2.D_K2_GetActorLocation()) : null, this.Radius, this.Radius, 1f, true, "MainCamera");
		}
		return true;
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x00089E94 File Offset: 0x00088094
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x00089F0F File Offset: 0x0008810F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "相机震屏";
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x00089F16 File Offset: 0x00088116
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCameraShake._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraShake.TsAnimNotifyCameraShake_C");
		}
		return TsAnimNotifyCameraShake._ClassPtr;
	}

	// Token: 0x06001A61 RID: 6753 RVA: 0x00089F3C File Offset: 0x0008813C
	public TsAnimNotifyCameraShake() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x00089F64 File Offset: 0x00088164
	[NullableContext(1)]
	public TsAnimNotifyCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x00089F97 File Offset: 0x00088197
	protected TsAnimNotifyCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x00089FA0 File Offset: 0x000881A0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A65 RID: 6757 RVA: 0x00089FD3 File Offset: 0x000881D3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001120 RID: 4384
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCameraShake.TsAnimNotifyCameraShake_C";

	// Token: 0x04001121 RID: 4385
	private static IntPtr _ClassPtr;

	// Token: 0x04001122 RID: 4386
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001123 RID: 4387
	private static int __PropertyOffset_震动配置;

	// Token: 0x04001124 RID: 4388
	private static int __PropertyOffset_bForSelf;

	// Token: 0x04001125 RID: 4389
	private static int __PropertyOffset_Radius;
}
