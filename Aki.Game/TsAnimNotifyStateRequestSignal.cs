using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000159 RID: 345
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRequestSignal.TsAnimNotifyStateRequestSignal_C")]
public class TsAnimNotifyStateRequestSignal : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000398 RID: 920
	// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0007A93B File Offset: 0x00078B3B
	// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0007A94B File Offset: 0x00078B4B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Signal
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRequestSignal.__PropertyOffset_Signal);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRequestSignal.__PropertyOffset_Signal) = value;
		}
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x0007A95C File Offset: 0x00078B5C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRequestSignal) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateRequestSignal.StaticClass(), out intPtr, out num))
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

	// Token: 0x060015DB RID: 5595 RVA: 0x0007AA1C File Offset: 0x00078C1C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		if (!(aactor is TsBaseCharacter))
		{
			return false;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById((aactor as TsBaseCharacter).EntityId);
		bool flag;
		if (entityById == null)
		{
			flag = (null != null);
		}
		else
		{
			WorldEntity entity = entityById.Entity;
			flag = (((entity != null) ? entity.GetComponent<CharacterInteractivePerformComponent>() : null) != null);
		}
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
		if (!flag || characterHoldingHandsComponent2 == null)
		{
			return false;
		}
		Entity holdingHandsOtherEntity = characterHoldingHandsComponent2.GetHoldingHandsOtherEntity();
		CreatureDataComponent creatureDataComponent = (holdingHandsOtherEntity != null) ? holdingHandsOtherEntity.GetComponent<CreatureDataComponent>() : null;
		CharacterInteractivePerformComponent characterInteractivePerformComponent = (holdingHandsOtherEntity != null) ? holdingHandsOtherEntity.GetComponent<CharacterInteractivePerformComponent>() : null;
		if (characterInteractivePerformComponent == null || creatureDataComponent == null)
		{
			return false;
		}
		RequestPerformParams request = new RequestPerformParams
		{
			Signal = this.Signal,
			Source = entityById.Entity
		};
		characterInteractivePerformComponent.AddRequestSignal(request);
		return true;
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x0007AAE4 File Offset: 0x00078CE4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRequestSignal) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateRequestSignal.StaticClass(), out intPtr, out num))
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

	// Token: 0x060015DD RID: 5597 RVA: 0x0007AB9C File Offset: 0x00078D9C
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
		Entity holdingHandsOtherEntity = characterHoldingHandsComponent2.GetHoldingHandsOtherEntity();
		CharacterInteractivePerformComponent characterInteractivePerformComponent3 = (holdingHandsOtherEntity != null) ? holdingHandsOtherEntity.GetComponent<CharacterInteractivePerformComponent>() : null;
		if (characterInteractivePerformComponent3 == null)
		{
			return false;
		}
		characterInteractivePerformComponent3.RemoveRequestSignal(this.Signal);
		return true;
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x0007AC38 File Offset: 0x00078E38
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRequestSignal) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateRequestSignal.StaticClass(), out intPtr, out num))
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

	// Token: 0x060015DF RID: 5599 RVA: 0x0007ACC8 File Offset: 0x00078EC8
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "请求交互动作";
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x0007ACCF File Offset: 0x00078ECF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRequestSignal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRequestSignal.TsAnimNotifyStateRequestSignal_C");
		}
		return TsAnimNotifyStateRequestSignal._ClassPtr;
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x0007ACF4 File Offset: 0x00078EF4
	public TsAnimNotifyStateRequestSignal() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRequestSignal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x0007AD1C File Offset: 0x00078F1C
	[NullableContext(1)]
	public TsAnimNotifyStateRequestSignal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRequestSignal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x0007AD4F File Offset: 0x00078F4F
	protected TsAnimNotifyStateRequestSignal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x0007AD58 File Offset: 0x00078F58
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x0007AD94 File Offset: 0x00078F94
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x0007ADC7 File Offset: 0x00078FC7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F4B RID: 3915
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRequestSignal.TsAnimNotifyStateRequestSignal_C";

	// Token: 0x04000F4C RID: 3916
	private static IntPtr _ClassPtr;

	// Token: 0x04000F4D RID: 3917
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F4E RID: 3918
	private static int __PropertyOffset_Signal;
}
