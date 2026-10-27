using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000190 RID: 400
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddTag.TsAnimNotifyAddTag_C")]
public class TsAnimNotifyAddTag : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000422 RID: 1058
	// (get) Token: 0x0600197C RID: 6524 RVA: 0x00086AA7 File Offset: 0x00084CA7
	// (set) Token: 0x0600197D RID: 6525 RVA: 0x00086ABB File Offset: 0x00084CBB
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

	// Token: 0x0600197E RID: 6526 RVA: 0x00086AD0 File Offset: 0x00084CD0
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

	// Token: 0x0600197F RID: 6527 RVA: 0x00086B70 File Offset: 0x00084D70
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

	// Token: 0x06001980 RID: 6528 RVA: 0x00086BE4 File Offset: 0x00084DE4
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

	// Token: 0x06001981 RID: 6529 RVA: 0x00086C5F File Offset: 0x00084E5F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "添加Tag";
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x00086C66 File Offset: 0x00084E66
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAddTag._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddTag.TsAnimNotifyAddTag_C");
		}
		return TsAnimNotifyAddTag._ClassPtr;
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x00086C8C File Offset: 0x00084E8C
	public TsAnimNotifyAddTag() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddTag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x00086CB4 File Offset: 0x00084EB4
	[NullableContext(1)]
	public TsAnimNotifyAddTag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddTag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x00086CE7 File Offset: 0x00084EE7
	protected TsAnimNotifyAddTag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x00086CF0 File Offset: 0x00084EF0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x00086D23 File Offset: 0x00084F23
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010C3 RID: 4291
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddTag.TsAnimNotifyAddTag_C";

	// Token: 0x040010C4 RID: 4292
	private static IntPtr _ClassPtr;

	// Token: 0x040010C5 RID: 4293
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010C6 RID: 4294
	private static int __PropertyOffset_Tag;
}
