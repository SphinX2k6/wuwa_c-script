using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A8 RID: 424
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSkillPriority.TsAnimNotifyChangeSkillPriority_C")]
public class TsAnimNotifyChangeSkillPriority : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000476 RID: 1142
	// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00091473 File Offset: 0x0008F673
	// (set) Token: 0x06001B45 RID: 6981 RVA: 0x00091483 File Offset: 0x0008F683
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

	// Token: 0x06001B46 RID: 6982 RVA: 0x00091494 File Offset: 0x0008F694
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyChangeSkillPriority) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyChangeSkillPriority.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B47 RID: 6983 RVA: 0x0009154C File Offset: 0x0008F74C
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

	// Token: 0x06001B48 RID: 6984 RVA: 0x000915B0 File Offset: 0x0008F7B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyChangeSkillPriority) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyChangeSkillPriority.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001B49 RID: 6985 RVA: 0x00091640 File Offset: 0x0008F840
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "修改技能优先级";
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x00091647 File Offset: 0x0008F847
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeSkillPriority._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSkillPriority.TsAnimNotifyChangeSkillPriority_C");
		}
		return TsAnimNotifyChangeSkillPriority._ClassPtr;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x0009166C File Offset: 0x0008F86C
	public TsAnimNotifyChangeSkillPriority() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSkillPriority.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x00091694 File Offset: 0x0008F894
	[NullableContext(1)]
	public TsAnimNotifyChangeSkillPriority(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeSkillPriority.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x000916C7 File Offset: 0x0008F8C7
	protected TsAnimNotifyChangeSkillPriority(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x000916D0 File Offset: 0x0008F8D0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x00091703 File Offset: 0x0008F903
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001182 RID: 4482
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeSkillPriority.TsAnimNotifyChangeSkillPriority_C";

	// Token: 0x04001183 RID: 4483
	private static IntPtr _ClassPtr;

	// Token: 0x04001184 RID: 4484
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001185 RID: 4485
	private static int __PropertyOffset_Priority;
}
