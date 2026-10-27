using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A4 RID: 420
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSkillPriority.TsAnimNotifyChangeSkillPriority_C")]
public class TsAnimNotifyChangeSkillPriority : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0008ADA7 File Offset: 0x00088FA7
	// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x0008ADB7 File Offset: 0x00088FB7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Priority
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyChangeSkillPriority.__PropertyOffset_Priority);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyChangeSkillPriority.__PropertyOffset_Priority) = value;
		}
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x0008ADC8 File Offset: 0x00088FC8
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

	// Token: 0x06001AAA RID: 6826 RVA: 0x0008AE68 File Offset: 0x00089068
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			CharacterSkillComponent characterSkillComponent = (entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent != null && !characterSkillComponent.IsSkillMontageInvalid(animation.GetName()))
			{
				characterSkillComponent.SetSkillPriority(characterSkillComponent.GetSkillIdWithGroupId(1), (int)this.Priority);
			}
		}
		return true;
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x0008AECC File Offset: 0x000890CC
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

	// Token: 0x06001AAC RID: 6828 RVA: 0x0008AF47 File Offset: 0x00089147
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "修改技能优先级";
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x0008AF4E File Offset: 0x0008914E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeSkillPriority._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSkillPriority.TsAnimNotifyChangeSkillPriority_C");
		}
		return TsAnimNotifyChangeSkillPriority._ClassPtr;
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x0008AF74 File Offset: 0x00089174
	public TsAnimNotifyChangeSkillPriority() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSkillPriority.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x0008AF9C File Offset: 0x0008919C
	[NullableContext(1)]
	public TsAnimNotifyChangeSkillPriority(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSkillPriority.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x0008AFCF File Offset: 0x000891CF
	protected TsAnimNotifyChangeSkillPriority(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001AB1 RID: 6833 RVA: 0x0008AFD8 File Offset: 0x000891D8
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x0008B00B File Offset: 0x0008920B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400113F RID: 4415
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSkillPriority.TsAnimNotifyChangeSkillPriority_C";

	// Token: 0x04001140 RID: 4416
	private static IntPtr _ClassPtr;

	// Token: 0x04001141 RID: 4417
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001142 RID: 4418
	private static int __PropertyOffset_Priority;
}
