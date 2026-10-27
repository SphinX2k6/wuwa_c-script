using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000149 RID: 329
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateNextAtt.TsAnimNotifyStateNextAtt_C")]
public class TsAnimNotifyStateNextAtt : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600143A RID: 5178 RVA: 0x00070CB4 File Offset: 0x0006EEB4
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

	// Token: 0x0600143B RID: 5179 RVA: 0x00070D5C File Offset: 0x0006EF5C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			CharacterSkillComponent characterSkillComponent;
			if (characterActorComponent == null)
			{
				characterSkillComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				characterSkillComponent = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
			}
			CharacterSkillComponent characterSkillComponent2 = characterSkillComponent;
			if (characterSkillComponent2 != null && characterSkillComponent2.Valid && !characterSkillComponent2.IsSkillMontageInvalid(animation.GetName()))
			{
				characterSkillComponent2.SetSkillAcceptInput(true);
				characterSkillComponent2.CallAnimBreakPoint();
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x00070DC0 File Offset: 0x0006EFC0
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

	// Token: 0x0600143D RID: 5181 RVA: 0x00070E60 File Offset: 0x0006F060
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		CharacterSkillComponent characterSkillComponent;
		if (characterActorComponent == null)
		{
			characterSkillComponent = null;
		}
		else
		{
			Entity entity = characterActorComponent.Entity;
			characterSkillComponent = ((entity != null) ? entity.GetComponent<CharacterSkillComponent>() : null);
		}
		CharacterSkillComponent characterSkillComponent2 = characterSkillComponent;
		CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
		CharacterBuffComponent characterBuffComponent;
		if (characterActorComponent2 == null)
		{
			characterBuffComponent = null;
		}
		else
		{
			Entity entity2 = characterActorComponent2.Entity;
			characterBuffComponent = ((entity2 != null) ? entity2.GetComponent<CharacterBuffComponent>() : null);
		}
		CharacterBuffComponent characterBuffComponent2 = characterBuffComponent;
		if (characterSkillComponent2 != null && characterSkillComponent2.IsSkillMontageInvalid(animation.GetName()))
		{
			return false;
		}
		if (characterSkillComponent2 != null && characterSkillComponent2.Valid)
		{
			characterSkillComponent2.SetSkillAcceptInput(false);
		}
		if (characterBuffComponent2 != null && characterBuffComponent2.Valid && characterBuffComponent2.HasBuffAuthority())
		{
			characterBuffComponent2.RemoveBuff(1101006002L, -1, "从TsAnimNotifyStateNextAtt移除Buff", null, null, null);
		}
		return true;
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x00070F28 File Offset: 0x0006F128
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

	// Token: 0x0600143F RID: 5183 RVA: 0x00070FA3 File Offset: 0x0006F1A3
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "下一个技能";
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x00070FAA File Offset: 0x0006F1AA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateNextAtt._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateNextAtt.TsAnimNotifyStateNextAtt_C");
		}
		return TsAnimNotifyStateNextAtt._ClassPtr;
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00070FD0 File Offset: 0x0006F1D0
	public TsAnimNotifyStateNextAtt() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateNextAtt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x00070FF8 File Offset: 0x0006F1F8
	[NullableContext(1)]
	public TsAnimNotifyStateNextAtt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateNextAtt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x0007102B File Offset: 0x0006F22B
	protected TsAnimNotifyStateNextAtt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00071034 File Offset: 0x0006F234
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00071070 File Offset: 0x0006F270
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x000710A3 File Offset: 0x0006F2A3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E87 RID: 3719
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateNextAtt.TsAnimNotifyStateNextAtt_C";

	// Token: 0x04000E88 RID: 3720
	private static IntPtr _ClassPtr;

	// Token: 0x04000E89 RID: 3721
	private static IntPtr _ClassDefaultObjectPtr;
}
