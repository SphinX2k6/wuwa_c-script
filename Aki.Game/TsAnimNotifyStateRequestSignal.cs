using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000155 RID: 341
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRequestSignal.TsAnimNotifyStateRequestSignal_C")]
public class TsAnimNotifyStateRequestSignal : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000376 RID: 886
	// (get) Token: 0x0600153B RID: 5435 RVA: 0x00075397 File Offset: 0x00073597
	// (set) Token: 0x0600153C RID: 5436 RVA: 0x000753A7 File Offset: 0x000735A7
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

	// Token: 0x0600153D RID: 5437 RVA: 0x000753B8 File Offset: 0x000735B8
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

	// Token: 0x0600153E RID: 5438 RVA: 0x00075460 File Offset: 0x00073660
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

	// Token: 0x0600153F RID: 5439 RVA: 0x00075528 File Offset: 0x00073728
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

	// Token: 0x06001540 RID: 5440 RVA: 0x000755C8 File Offset: 0x000737C8
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

	// Token: 0x06001541 RID: 5441 RVA: 0x00075664 File Offset: 0x00073864
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

	// Token: 0x06001542 RID: 5442 RVA: 0x000756DF File Offset: 0x000738DF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "请求交互动作";
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x000756E6 File Offset: 0x000738E6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRequestSignal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRequestSignal.TsAnimNotifyStateRequestSignal_C");
		}
		return TsAnimNotifyStateRequestSignal._ClassPtr;
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x0007570C File Offset: 0x0007390C
	public TsAnimNotifyStateRequestSignal() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRequestSignal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x00075734 File Offset: 0x00073934
	[NullableContext(1)]
	public TsAnimNotifyStateRequestSignal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRequestSignal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x00075767 File Offset: 0x00073967
	protected TsAnimNotifyStateRequestSignal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x00075770 File Offset: 0x00073970
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x000757AC File Offset: 0x000739AC
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x000757DF File Offset: 0x000739DF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F08 RID: 3848
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRequestSignal.TsAnimNotifyStateRequestSignal_C";

	// Token: 0x04000F09 RID: 3849
	private static IntPtr _ClassPtr;

	// Token: 0x04000F0A RID: 3850
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F0B RID: 3851
	private static int __PropertyOffset_Signal;
}
