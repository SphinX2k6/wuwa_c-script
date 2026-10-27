using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200012A RID: 298
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDisableCameraCollision.TsAnimNotifyStateDisableCameraCollision_C")]
public class TsAnimNotifyStateDisableCameraCollision : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001244 RID: 4676 RVA: 0x0006793C File Offset: 0x00065B3C
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

	// Token: 0x06001245 RID: 4677 RVA: 0x000679E4 File Offset: 0x00065BE4
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || (characterActorComponent == null || !characterActorComponent.IsAutonomousProxy))
		{
			return false;
		}
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera != null)
		{
			FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
			if (logicComponent != null)
			{
				logicComponent.LockCameraCollision(ECameraCollisionLockType.LevelEventDisableCameraCollision);
			}
		}
		Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "关闭相机碰撞", default(ReadOnlySpan<ValueTuple<string, object>>));
		return true;
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x00067A78 File Offset: 0x00065C78
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

	// Token: 0x06001247 RID: 4679 RVA: 0x00067B18 File Offset: 0x00065D18
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (aactor as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || (characterActorComponent == null || !characterActorComponent.IsAutonomousProxy))
		{
			return false;
		}
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera != null)
		{
			FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
			if (logicComponent != null)
			{
				logicComponent.UnlockCameraCollision(ECameraCollisionLockType.LevelEventDisableCameraCollision);
			}
		}
		Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "启用相机碰撞", default(ReadOnlySpan<ValueTuple<string, object>>));
		return true;
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00067BB0 File Offset: 0x00065DB0
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

	// Token: 0x06001249 RID: 4681 RVA: 0x00067C2B File Offset: 0x00065E2B
	protected override string GetNotifyName_Implementation()
	{
		return "关闭相机碰撞";
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00067C32 File Offset: 0x00065E32
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateDisableCameraCollision._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDisableCameraCollision.TsAnimNotifyStateDisableCameraCollision_C");
		}
		return TsAnimNotifyStateDisableCameraCollision._ClassPtr;
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00067C58 File Offset: 0x00065E58
	public TsAnimNotifyStateDisableCameraCollision() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDisableCameraCollision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00067C80 File Offset: 0x00065E80
	public TsAnimNotifyStateDisableCameraCollision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateDisableCameraCollision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00067CB3 File Offset: 0x00065EB3
	protected TsAnimNotifyStateDisableCameraCollision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00067CBC File Offset: 0x00065EBC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00067CF8 File Offset: 0x00065EF8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00067D2B File Offset: 0x00065F2B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000DA6 RID: 3494
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateDisableCameraCollision.TsAnimNotifyStateDisableCameraCollision_C";

	// Token: 0x04000DA7 RID: 3495
	private static IntPtr _ClassPtr;

	// Token: 0x04000DA8 RID: 3496
	private static IntPtr _ClassDefaultObjectPtr;
}
