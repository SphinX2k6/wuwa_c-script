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
	// Token: 0x170002BE RID: 702
	// (get) Token: 0x06001111 RID: 4369 RVA: 0x00061D93 File Offset: 0x0005FF93
	// (set) Token: 0x06001112 RID: 4370 RVA: 0x00061DA7 File Offset: 0x0005FFA7
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

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x06001113 RID: 4371 RVA: 0x00061DBC File Offset: 0x0005FFBC
	// (set) Token: 0x06001114 RID: 4372 RVA: 0x00061DD0 File Offset: 0x0005FFD0
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

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x06001115 RID: 4373 RVA: 0x00061DE5 File Offset: 0x0005FFE5
	// (set) Token: 0x06001116 RID: 4374 RVA: 0x00061DF9 File Offset: 0x0005FFF9
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

	// Token: 0x06001117 RID: 4375 RVA: 0x00061E10 File Offset: 0x00060010
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateChangeSlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateChangeSlot.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001118 RID: 4376 RVA: 0x00061ED0 File Offset: 0x000600D0
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

	// Token: 0x06001119 RID: 4377 RVA: 0x00061F24 File Offset: 0x00060124
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateChangeSlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateChangeSlot.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600111A RID: 4378 RVA: 0x00061FDC File Offset: 0x000601DC
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

	// Token: 0x0600111B RID: 4379 RVA: 0x00062024 File Offset: 0x00060224
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateChangeSlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateChangeSlot.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600111C RID: 4380 RVA: 0x000620B4 File Offset: 0x000602B4
	protected override string GetNotifyName_Implementation()
	{
		return "切换组件到指定插槽";
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x000620BB File Offset: 0x000602BB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateChangeSlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateChangeSlot.TsAnimNotifyStateChangeSlot_C");
		}
		return TsAnimNotifyStateChangeSlot._ClassPtr;
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x000620E0 File Offset: 0x000602E0
	public TsAnimNotifyStateChangeSlot() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateChangeSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00062108 File Offset: 0x00060308
	public TsAnimNotifyStateChangeSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateChangeSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x0006213B File Offset: 0x0006033B
	protected TsAnimNotifyStateChangeSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00062144 File Offset: 0x00060344
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00062180 File Offset: 0x00060380
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x000621B3 File Offset: 0x000603B3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CEA RID: 3306
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateChangeSlot.TsAnimNotifyStateChangeSlot_C";

	// Token: 0x04000CEB RID: 3307
	private static IntPtr _ClassPtr;

	// Token: 0x04000CEC RID: 3308
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CED RID: 3309
	private static int __PropertyOffset_ComponentName;

	// Token: 0x04000CEE RID: 3310
	private static int __PropertyOffset_SwitchToSlotName;

	// Token: 0x04000CEF RID: 3311
	private static int __PropertyOffset_SlotTransform;
}
