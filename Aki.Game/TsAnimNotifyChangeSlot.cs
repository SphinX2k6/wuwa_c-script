using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A9 RID: 425
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSlot.TsAnimNotifyChangeSlot_C")]
public class TsAnimNotifyChangeSlot : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00091717 File Offset: 0x0008F917
	// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0009172B File Offset: 0x0008F92B
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ComponentName
	{
		[NullableContext(2)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyChangeSlot.__PropertyOffset_ComponentName)));
		}
		[NullableContext(2)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyChangeSlot.__PropertyOffset_ComponentName)), value);
		}
	}

	// Token: 0x17000478 RID: 1144
	// (get) Token: 0x06001B52 RID: 6994 RVA: 0x00091740 File Offset: 0x0008F940
	// (set) Token: 0x06001B53 RID: 6995 RVA: 0x00091754 File Offset: 0x0008F954
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName SwitchToSlotName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyChangeSlot.__PropertyOffset_SwitchToSlotName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyChangeSlot.__PropertyOffset_SwitchToSlotName) = value;
		}
	}

	// Token: 0x17000479 RID: 1145
	// (get) Token: 0x06001B54 RID: 6996 RVA: 0x00091769 File Offset: 0x0008F969
	// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0009177D File Offset: 0x0008F97D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FTransform SlotTransform
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyChangeSlot.__PropertyOffset_SlotTransform);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyChangeSlot.__PropertyOffset_SlotTransform) = value;
		}
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x00091794 File Offset: 0x0008F994
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyChangeSlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyChangeSlot.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B57 RID: 6999 RVA: 0x0009184C File Offset: 0x0008FA4C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null)
		{
			return false;
		}
		USkeletalMeshComponent skeletalMesh = characterActorComponent.SkeletalMesh;
		int? num = (skeletalMesh != null) ? new int?(skeletalMesh.GetNumChildrenComponents()) : null;
		int num2 = 0;
		USkeletalMeshComponent uskeletalMeshComponent;
		for (;;)
		{
			int num3 = num2;
			int? num4 = num;
			if (!(num3 < num4.GetValueOrDefault() & num4 != null))
			{
				return true;
			}
			USkeletalMeshComponent skeletalMesh2 = characterActorComponent.SkeletalMesh;
			USceneComponent usceneComponent = (skeletalMesh2 != null) ? skeletalMesh2.GetChildComponent(num2) : null;
			if (usceneComponent != null && usceneComponent.GetName() == this.ComponentName)
			{
				uskeletalMeshComponent = (usceneComponent as USkeletalMeshComponent);
				if (uskeletalMeshComponent != null)
				{
					break;
				}
			}
			num2++;
		}
		uskeletalMeshComponent.K2_AttachToComponent(characterActorComponent.SkeletalMesh, this.SwitchToSlotName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, true, true);
		FTransform slotTransform = this.SlotTransform;
		FHitResult fhitResult = new FHitResult();
		USceneComponent usceneComponent2 = uskeletalMeshComponent;
		FTransform slotTransform2 = this.SlotTransform;
		usceneComponent2.K2_SetRelativeTransform(slotTransform2, false, ref fhitResult, true);
		return true;
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x0009193C File Offset: 0x0008FB3C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyChangeSlot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyChangeSlot.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B59 RID: 7001 RVA: 0x000919CC File Offset: 0x0008FBCC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "切换组件到指定插槽";
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x000919D3 File Offset: 0x0008FBD3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeSlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSlot.TsAnimNotifyChangeSlot_C");
		}
		return TsAnimNotifyChangeSlot._ClassPtr;
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x000919F8 File Offset: 0x0008FBF8
	public TsAnimNotifyChangeSlot() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x00091A20 File Offset: 0x0008FC20
	[NullableContext(1)]
	public TsAnimNotifyChangeSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x00091A53 File Offset: 0x0008FC53
	protected TsAnimNotifyChangeSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x00091A5C File Offset: 0x0008FC5C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x00091A8F File Offset: 0x0008FC8F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001186 RID: 4486
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSlot.TsAnimNotifyChangeSlot_C";

	// Token: 0x04001187 RID: 4487
	private static IntPtr _ClassPtr;

	// Token: 0x04001188 RID: 4488
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001189 RID: 4489
	private static int __PropertyOffset_ComponentName;

	// Token: 0x0400118A RID: 4490
	private static int __PropertyOffset_SwitchToSlotName;

	// Token: 0x0400118B RID: 4491
	private static int __PropertyOffset_SlotTransform;
}
