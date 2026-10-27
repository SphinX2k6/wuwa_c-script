using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A5 RID: 421
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSlot.TsAnimNotifyChangeSlot_C")]
public class TsAnimNotifyChangeSlot : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x0008B01F File Offset: 0x0008921F
	// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x0008B033 File Offset: 0x00089233
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

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x0008B048 File Offset: 0x00089248
	// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x0008B05C File Offset: 0x0008925C
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

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x0008B071 File Offset: 0x00089271
	// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x0008B085 File Offset: 0x00089285
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

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0008B09C File Offset: 0x0008929C
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

	// Token: 0x06001ABA RID: 6842 RVA: 0x0008B13C File Offset: 0x0008933C
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

	// Token: 0x06001ABB RID: 6843 RVA: 0x0008B22C File Offset: 0x0008942C
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

	// Token: 0x06001ABC RID: 6844 RVA: 0x0008B2A7 File Offset: 0x000894A7
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "切换组件到指定插槽";
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x0008B2AE File Offset: 0x000894AE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeSlot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSlot.TsAnimNotifyChangeSlot_C");
		}
		return TsAnimNotifyChangeSlot._ClassPtr;
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x0008B2D4 File Offset: 0x000894D4
	public TsAnimNotifyChangeSlot() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x0008B2FC File Offset: 0x000894FC
	[NullableContext(1)]
	public TsAnimNotifyChangeSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x0008B32F File Offset: 0x0008952F
	protected TsAnimNotifyChangeSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x0008B338 File Offset: 0x00089538
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x0008B36B File Offset: 0x0008956B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001143 RID: 4419
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSlot.TsAnimNotifyChangeSlot_C";

	// Token: 0x04001144 RID: 4420
	private static IntPtr _ClassPtr;

	// Token: 0x04001145 RID: 4421
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001146 RID: 4422
	private static int __PropertyOffset_ComponentName;

	// Token: 0x04001147 RID: 4423
	private static int __PropertyOffset_SwitchToSlotName;

	// Token: 0x04001148 RID: 4424
	private static int __PropertyOffset_SlotTransform;
}
