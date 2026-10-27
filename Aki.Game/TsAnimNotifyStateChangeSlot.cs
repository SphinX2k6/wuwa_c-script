using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200011D RID: 285
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateChangeSlot.TsAnimNotifyStateChangeSlot_C")]
public class TsAnimNotifyStateChangeSlot : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002BB RID: 699
	// (get) Token: 0x0600110B RID: 4363 RVA: 0x000608A7 File Offset: 0x0005EAA7
	// (set) Token: 0x0600110C RID: 4364 RVA: 0x000608BB File Offset: 0x0005EABB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ComponentName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateChangeSlot.__PropertyOffset_ComponentName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateChangeSlot.__PropertyOffset_ComponentName)), value);
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x0600110D RID: 4365 RVA: 0x000608D0 File Offset: 0x0005EAD0
	// (set) Token: 0x0600110E RID: 4366 RVA: 0x000608E4 File Offset: 0x0005EAE4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SwitchToSlotName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateChangeSlot.__PropertyOffset_SwitchToSlotName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateChangeSlot.__PropertyOffset_SwitchToSlotName) = value;
		}
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x0600110F RID: 4367 RVA: 0x000608F9 File Offset: 0x0005EAF9
	// (set) Token: 0x06001110 RID: 4368 RVA: 0x0006090D File Offset: 0x0005EB0D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FTransform SlotTransform
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateChangeSlot.__PropertyOffset_SlotTransform);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateChangeSlot.__PropertyOffset_SlotTransform) = value;
		}
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00060924 File Offset: 0x0005EB24
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

	// Token: 0x06001112 RID: 4370 RVA: 0x000609CC File Offset: 0x0005EBCC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
		SubMeshComponent subMeshComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<SubMeshComponent>() : null;
		if (subMeshComponent != null)
		{
			subMeshComponent.SetSubMeshAttach(this.ComponentName, this.SwitchToSlotName, this.SlotTransform);
		}
		return true;
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00060A20 File Offset: 0x0005EC20
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

	// Token: 0x06001114 RID: 4372 RVA: 0x00060AC0 File Offset: 0x0005ECC0
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
		SubMeshComponent subMeshComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<SubMeshComponent>() : null;
		if (subMeshComponent != null)
		{
			subMeshComponent.ResetSubMeshAttach(this.ComponentName);
		}
		return true;
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00060B08 File Offset: 0x0005ED08
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

	// Token: 0x06001116 RID: 4374 RVA: 0x00060B83 File Offset: 0x0005ED83
	protected override string GetNotifyName_Implementation()
	{
		return "切换组件到指定插槽";
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00060B8A File Offset: 0x0005ED8A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateChangeSlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateChangeSlot.TsAnimNotifyStateChangeSlot_C");
		}
		return TsAnimNotifyStateChangeSlot._ClassPtr;
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00060BB0 File Offset: 0x0005EDB0
	public TsAnimNotifyStateChangeSlot() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateChangeSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00060BD8 File Offset: 0x0005EDD8
	public TsAnimNotifyStateChangeSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateChangeSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00060C0B File Offset: 0x0005EE0B
	protected TsAnimNotifyStateChangeSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00060C14 File Offset: 0x0005EE14
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00060C50 File Offset: 0x0005EE50
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00060C83 File Offset: 0x0005EE83
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CE2 RID: 3298
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateChangeSlot.TsAnimNotifyStateChangeSlot_C";

	// Token: 0x04000CE3 RID: 3299
	private static IntPtr _ClassPtr;

	// Token: 0x04000CE4 RID: 3300
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CE5 RID: 3301
	private static int __PropertyOffset_ComponentName;

	// Token: 0x04000CE6 RID: 3302
	private static int __PropertyOffset_SwitchToSlotName;

	// Token: 0x04000CE7 RID: 3303
	private static int __PropertyOffset_SlotTransform;
}
