using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000156 RID: 342
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateResponseSignal.TsAnimNotifyStateResponseSignal_C")]
public class TsAnimNotifyStateResponseSignal : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000377 RID: 887
	// (get) Token: 0x0600154A RID: 5450 RVA: 0x000757F3 File Offset: 0x000739F3
	// (set) Token: 0x0600154B RID: 5451 RVA: 0x00075803 File Offset: 0x00073A03
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Signal
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateResponseSignal.__PropertyOffset_Signal);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateResponseSignal.__PropertyOffset_Signal) = value;
		}
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00075814 File Offset: 0x00073A14
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

	// Token: 0x0600154D RID: 5453 RVA: 0x000758BC File Offset: 0x00073ABC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById((aactor as TsBaseCharacter).EntityId);
		CharacterInteractivePerformComponent characterInteractivePerformComponent;
		if (entityById == null)
		{
			characterInteractivePerformComponent = null;
		}
		else
		{
			WorldEntity entity = entityById.Entity;
			characterInteractivePerformComponent = ((entity != null) ? entity.GetComponent<CharacterInteractivePerformComponent>() : null);
		}
		CharacterInteractivePerformComponent characterInteractivePerformComponent2 = characterInteractivePerformComponent;
		CharacterHoldingHandsComponent characterHoldingHandsComponent;
		if (entityById == null)
		{
			characterHoldingHandsComponent = null;
		}
		else
		{
			WorldEntity entity2 = entityById.Entity;
			characterHoldingHandsComponent = ((entity2 != null) ? entity2.GetComponent<CharacterHoldingHandsComponent>() : null);
		}
		CharacterHoldingHandsComponent characterHoldingHandsComponent2 = characterHoldingHandsComponent;
		if (characterInteractivePerformComponent2 == null || characterHoldingHandsComponent2 == null)
		{
			return false;
		}
		characterInteractivePerformComponent2.AddResponseSignal(this.Signal, "");
		return true;
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x00075944 File Offset: 0x00073B44
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

	// Token: 0x0600154F RID: 5455 RVA: 0x000759E4 File Offset: 0x00073BE4
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById((aactor as TsBaseCharacter).EntityId);
		CharacterInteractivePerformComponent characterInteractivePerformComponent;
		if (entityById == null)
		{
			characterInteractivePerformComponent = null;
		}
		else
		{
			WorldEntity entity = entityById.Entity;
			characterInteractivePerformComponent = ((entity != null) ? entity.GetComponent<CharacterInteractivePerformComponent>() : null);
		}
		CharacterInteractivePerformComponent characterInteractivePerformComponent2 = characterInteractivePerformComponent;
		CharacterHoldingHandsComponent characterHoldingHandsComponent;
		if (entityById == null)
		{
			characterHoldingHandsComponent = null;
		}
		else
		{
			WorldEntity entity2 = entityById.Entity;
			characterHoldingHandsComponent = ((entity2 != null) ? entity2.GetComponent<CharacterHoldingHandsComponent>() : null);
		}
		CharacterHoldingHandsComponent characterHoldingHandsComponent2 = characterHoldingHandsComponent;
		if (characterInteractivePerformComponent2 == null || characterHoldingHandsComponent2 == null)
		{
			return false;
		}
		characterInteractivePerformComponent2.RemoveResponseSignal(this.Signal);
		return true;
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x00075A68 File Offset: 0x00073C68
	[NullableContext(1)]
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

	// Token: 0x06001551 RID: 5457 RVA: 0x00075AE3 File Offset: 0x00073CE3
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "响应交互动作";
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x00075AEA File Offset: 0x00073CEA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateResponseSignal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateResponseSignal.TsAnimNotifyStateResponseSignal_C");
		}
		return TsAnimNotifyStateResponseSignal._ClassPtr;
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x00075B10 File Offset: 0x00073D10
	public TsAnimNotifyStateResponseSignal() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateResponseSignal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00075B38 File Offset: 0x00073D38
	[NullableContext(1)]
	public TsAnimNotifyStateResponseSignal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateResponseSignal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00075B6B File Offset: 0x00073D6B
	protected TsAnimNotifyStateResponseSignal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00075B74 File Offset: 0x00073D74
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x00075BB0 File Offset: 0x00073DB0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x00075BE3 File Offset: 0x00073DE3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F0C RID: 3852
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateResponseSignal.TsAnimNotifyStateResponseSignal_C";

	// Token: 0x04000F0D RID: 3853
	private static IntPtr _ClassPtr;

	// Token: 0x04000F0E RID: 3854
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F0F RID: 3855
	private static int __PropertyOffset_Signal;
}
