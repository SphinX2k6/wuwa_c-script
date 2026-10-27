using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C8 RID: 456
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQuitAiming.TsAnimNotifyQuitAiming_C")]
public class TsAnimNotifyQuitAiming : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000490 RID: 1168
	// (get) Token: 0x06001C81 RID: 7297 RVA: 0x000912AF File Offset: 0x0008F4AF
	// (set) Token: 0x06001C82 RID: 7298 RVA: 0x000912C3 File Offset: 0x0008F4C3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyQuitAiming.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyQuitAiming.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x000912D8 File Offset: 0x0008F4D8
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

	// Token: 0x06001C84 RID: 7300 RVA: 0x00091378 File Offset: 0x0008F578
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
			if (!tsBaseCharacter.CharacterActorComponent.IsWorldOwner())
			{
				return false;
			}
			if (this.Tag.TagName == "None" || entity.GetComponent<BaseTagComponent>().HasTag(this.Tag.TagId()))
			{
				entity.GetComponent<CharacterUnifiedStateComponent>().ExitAimStatus();
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001C85 RID: 7301 RVA: 0x000913F4 File Offset: 0x0008F5F4
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

	// Token: 0x06001C86 RID: 7302 RVA: 0x0009146F File Offset: 0x0008F66F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "退出瞄准模式";
	}

	// Token: 0x06001C87 RID: 7303 RVA: 0x00091476 File Offset: 0x0008F676
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyQuitAiming._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQuitAiming.TsAnimNotifyQuitAiming_C");
		}
		return TsAnimNotifyQuitAiming._ClassPtr;
	}

	// Token: 0x06001C88 RID: 7304 RVA: 0x0009149C File Offset: 0x0008F69C
	public TsAnimNotifyQuitAiming() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQuitAiming.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C89 RID: 7305 RVA: 0x000914C4 File Offset: 0x0008F6C4
	[NullableContext(1)]
	public TsAnimNotifyQuitAiming(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQuitAiming.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C8A RID: 7306 RVA: 0x000914F7 File Offset: 0x0008F6F7
	protected TsAnimNotifyQuitAiming(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C8B RID: 7307 RVA: 0x00091500 File Offset: 0x0008F700
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C8C RID: 7308 RVA: 0x00091533 File Offset: 0x0008F733
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011EE RID: 4590
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyQuitAiming.TsAnimNotifyQuitAiming_C";

	// Token: 0x040011EF RID: 4591
	private static IntPtr _ClassPtr;

	// Token: 0x040011F0 RID: 4592
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011F1 RID: 4593
	private static int __PropertyOffset_Tag;
}
