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
	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0005F3D3 File Offset: 0x0005D5D3
	// (set) Token: 0x060010C5 RID: 4293 RVA: 0x0005F3E7 File Offset: 0x0005D5E7
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

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0005F3FC File Offset: 0x0005D5FC
	// (set) Token: 0x060010C7 RID: 4295 RVA: 0x0005F435 File Offset: 0x0005D635
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

	// Token: 0x060010C8 RID: 4296 RVA: 0x0005F460 File Offset: 0x0005D660
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0005F508 File Offset: 0x0005D708
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

	// Token: 0x060010CA RID: 4298 RVA: 0x0005F6DC File Offset: 0x0005D8DC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
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

	// Token: 0x060010CB RID: 4299 RVA: 0x0005F77C File Offset: 0x0005D97C
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

	// Token: 0x060010CC RID: 4300 RVA: 0x0005F7FC File Offset: 0x0005D9FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x060010CD RID: 4301 RVA: 0x0005F877 File Offset: 0x0005DA77
	protected override string GetNotifyName_Implementation()
	{
		return "相机震屏ANS";
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x0005F87E File Offset: 0x0005DA7E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateCameraShake._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraShake.TsAnimNotifyStateCameraShake_C");
		}
		return TsAnimNotifyStateCameraShake._ClassPtr;
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x0005F8A4 File Offset: 0x0005DAA4
	public TsAnimNotifyStateCameraShake() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x0005F8CC File Offset: 0x0005DACC
	public TsAnimNotifyStateCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x0005F8FF File Offset: 0x0005DAFF
	protected TsAnimNotifyStateCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x0005F920 File Offset: 0x0005DB20
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x0005F95C File Offset: 0x0005DB5C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x0005F98F File Offset: 0x0005DB8F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CC6 RID: 3270
	private readonly Dictionary<USkeletalMeshComponent, int> CameraShakeInstanceIdMap = new Dictionary<USkeletalMeshComponent, int>();

	// Token: 0x04000CC7 RID: 3271
	private readonly HashSet<USkeletalMeshComponent> PlayingForceFeedback = new HashSet<USkeletalMeshComponent>();

	// Token: 0x04000CC8 RID: 3272
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateCameraShake.TsAnimNotifyStateCameraShake_C";

	// Token: 0x04000CC9 RID: 3273
	private static IntPtr _ClassPtr;

	// Token: 0x04000CCA RID: 3274
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CCB RID: 3275
	private static int __PropertyOffset_震动配置;

	// Token: 0x04000CCC RID: 3276
	private static int __PropertyOffset_ExcludeTag;

	// Token: 0x04000CCD RID: 3277
	[Nullable(2)]
	private FGameplayTagContainer _ExcludeTag;
}
