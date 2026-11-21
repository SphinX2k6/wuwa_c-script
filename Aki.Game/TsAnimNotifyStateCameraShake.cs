using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Extension;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000119 RID: 281
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraShake.TsAnimNotifyStateCameraShake_C")]
public class TsAnimNotifyStateCameraShake : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x060010CA RID: 4298 RVA: 0x000607AF File Offset: 0x0005E9AF
	// (set) Token: 0x060010CB RID: 4299 RVA: 0x000607C3 File Offset: 0x0005E9C3
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
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraShake.__PropertyOffset_震动配置);
		}
		[param: Nullable(new byte[]
		{
			0,
			1
		})]
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraShake.__PropertyOffset_震动配置) = value;
		}
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x060010CC RID: 4300 RVA: 0x000607D8 File Offset: 0x0005E9D8
	// (set) Token: 0x060010CD RID: 4301 RVA: 0x00060811 File Offset: 0x0005EA11
	[UProperty(EPropertyFlags.CPF_None)]
	public FGameplayTagContainer ExcludeTag
	{
		get
		{
			base.FastCheckIsValid();
			FGameplayTagContainer result;
			if ((result = this._ExcludeTag) == null)
			{
				result = (this._ExcludeTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)TsAnimNotifyStateCameraShake.__PropertyOffset_ExcludeTag, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateCameraShake.__PropertyOffset_ExcludeTag, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x0006083C File Offset: 0x0005EA3C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateCameraShake.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x000608FC File Offset: 0x0005EAFC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter) && !(owner is TsBaseVehicle))
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		int num;
		if (tsBaseCharacter == null)
		{
			TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
			if (tsBaseVehicle == null)
			{
				num = 0;
			}
			else
			{
				num = tsBaseVehicle.EntityId;
			}
		}
		else
		{
			num = tsBaseCharacter.EntityId;
		}
		int entityId = num;
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
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
		TsBaseCharacter tsBaseCharacter2 = owner as TsBaseCharacter;
		Entity entity;
		if (tsBaseCharacter2 == null)
		{
			TsBaseVehicle tsBaseVehicle2 = owner as TsBaseVehicle;
			if (tsBaseVehicle2 == null)
			{
				entity = null;
			}
			else
			{
				entity = tsBaseVehicle2.GetEntityNoBlueprint();
			}
		}
		else
		{
			entity = tsBaseCharacter2.GetEntityNoBlueprint();
		}
		Entity entity2 = entity;
		BaseTagComponent baseTagComponent = (entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent == null || !baseTagComponent.HasAnyTagContainer(this.ExcludeTag))
		{
			int cameraShakeInstanceId;
			if (this.CameraShakeInstanceIdMap.TryGetValue(meshComp, out cameraShakeInstanceId))
			{
				CameraController.Instance.StopCameraShake(cameraShakeInstanceId, true, "MainCamera");
			}
			this.CameraShakeInstanceIdMap[meshComp] = CameraController.Instance.PlayCameraShake(this.震动配置.Get().ToWeakClass(), new float?(CameraController.Instance.MainModel.ShakeModify), new ECameraShakePlaySpace?(ECameraShakePlaySpace.CameraLocal), null, true, true, "MainCamera");
		}
		else
		{
			this.PlayingForceFeedback.Add(meshComp);
			CameraController.Instance.PlayForceFeedbackFromCameraShake(new TSubclassOf<UCameraShakeBase>?(this.震动配置.As<UCameraShakeBase>()), "MainCamera");
		}
		return true;
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x00060AD0 File Offset: 0x0005ECD0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateCameraShake.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00060B88 File Offset: 0x0005ED88
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int cameraShakeInstanceId;
		if (this.CameraShakeInstanceIdMap.TryGetValue(meshComp, out cameraShakeInstanceId))
		{
			CameraController.Instance.StopCameraShake(cameraShakeInstanceId, true, "MainCamera");
			this.CameraShakeInstanceIdMap.Remove(meshComp);
		}
		if (this.PlayingForceFeedback.Contains(meshComp))
		{
			CameraController.Instance.StopForceFeedbackFromCameraShake(new TSubclassOf<UCameraShakeBase>?(this.震动配置.Get()), "MainCamera");
			this.PlayingForceFeedback.Remove(meshComp);
		}
		return true;
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x00060C08 File Offset: 0x0005EE08
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateCameraShake) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateCameraShake.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x00060C98 File Offset: 0x0005EE98
	protected override string GetNotifyName_Implementation()
	{
		return "相机震屏ANS";
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x00060C9F File Offset: 0x0005EE9F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCameraShake._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraShake.TsAnimNotifyStateCameraShake_C");
		}
		return TsAnimNotifyStateCameraShake._ClassPtr;
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00060CC4 File Offset: 0x0005EEC4
	public TsAnimNotifyStateCameraShake() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00060CEC File Offset: 0x0005EEEC
	public TsAnimNotifyStateCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00060D1F File Offset: 0x0005EF1F
	protected TsAnimNotifyStateCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x00060D40 File Offset: 0x0005EF40
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x00060D7C File Offset: 0x0005EF7C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00060DAF File Offset: 0x0005EFAF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CCE RID: 3278
	private readonly Dictionary<USkeletalMeshComponent, int> CameraShakeInstanceIdMap = new Dictionary<USkeletalMeshComponent, int>();

	// Token: 0x04000CCF RID: 3279
	private readonly HashSet<USkeletalMeshComponent> PlayingForceFeedback = new HashSet<USkeletalMeshComponent>();

	// Token: 0x04000CD0 RID: 3280
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraShake.TsAnimNotifyStateCameraShake_C";

	// Token: 0x04000CD1 RID: 3281
	private static IntPtr _ClassPtr;

	// Token: 0x04000CD2 RID: 3282
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CD3 RID: 3283
	private static int __PropertyOffset_震动配置;

	// Token: 0x04000CD4 RID: 3284
	private static int __PropertyOffset_ExcludeTag;

	// Token: 0x04000CD5 RID: 3285
	[Nullable(2)]
	private FGameplayTagContainer _ExcludeTag;
}
