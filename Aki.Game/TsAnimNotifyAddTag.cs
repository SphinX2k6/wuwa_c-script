using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000194 RID: 404
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddTag.TsAnimNotifyAddTag_C")]
public class TsAnimNotifyAddTag : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06001A19 RID: 6681 RVA: 0x0008CE43 File Offset: 0x0008B043
	// (set) Token: 0x06001A1A RID: 6682 RVA: 0x0008CE57 File Offset: 0x0008B057
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAddTag.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAddTag.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x0008CE6C File Offset: 0x0008B06C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyAddTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyAddTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A1C RID: 6684 RVA: 0x0008CF24 File Offset: 0x0008B124
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp == null)
		{
			return true;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null && this.Tag.TagName != FName.NAME_None)
		{
			int num = this.Tag.TagId();
			if (num != 0)
			{
				Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
				BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent != null)
				{
					baseTagComponent.TagContainer.UpdateExactTag(ETagChannel.Anim, num, 1);
				}
			}
		}
		return true;
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x0008CF98 File Offset: 0x0008B198
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyAddTag) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyAddTag.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A1E RID: 6686 RVA: 0x0008D028 File Offset: 0x0008B228
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "添加Tag";
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x0008D02F File Offset: 0x0008B22F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAddTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddTag.TsAnimNotifyAddTag_C");
		}
		return TsAnimNotifyAddTag._ClassPtr;
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x0008D054 File Offset: 0x0008B254
	public TsAnimNotifyAddTag() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x0008D07C File Offset: 0x0008B27C
	[NullableContext(1)]
	public TsAnimNotifyAddTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x0008D0AF File Offset: 0x0008B2AF
	protected TsAnimNotifyAddTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x0008D0B8 File Offset: 0x0008B2B8
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x0008D0EB File Offset: 0x0008B2EB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001106 RID: 4358
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddTag.TsAnimNotifyAddTag_C";

	// Token: 0x04001107 RID: 4359
	private static IntPtr _ClassPtr;

	// Token: 0x04001108 RID: 4360
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001109 RID: 4361
	private static int __PropertyOffset_Tag;
}
