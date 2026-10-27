using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016B RID: 363
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetRootMotionScale.TsAnimNotifyStateSetRootMotionScale_C")]
public class TsAnimNotifyStateSetRootMotionScale : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x060016ED RID: 5869 RVA: 0x0007C20F File Offset: 0x0007A40F
	// (set) Token: 0x060016EE RID: 5870 RVA: 0x0007C223 File Offset: 0x0007A423
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSetRootMotionScale.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSetRootMotionScale.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x0007C238 File Offset: 0x0007A438
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

	// Token: 0x060016F0 RID: 5872 RVA: 0x0007C2E0 File Offset: 0x0007A4E0
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		if (characterActorComponent.GetSequenceBinding())
		{
			return false;
		}
		if (!characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		BaseTagComponent component = characterActorComponent.Entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.HasTag(this.Tag.TagId()))
		{
			return false;
		}
		if (this.Tag.TagId() == GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.超级跳跃"])
		{
			BaseAttributeComponent component2 = characterActorComponent.Entity.GetComponent<BaseAttributeComponent>();
			float num = (component2 != null) ? (component2.GetCurrentValue(EAttributeType.Jump) / 10000f) : 1f;
			(owner as TsBaseCharacter).SetAnimRootMotionTranslationScale(num);
			CharacterMoveComponent component3 = characterActorComponent.Entity.GetComponent<CharacterMoveComponent>();
			if (component3 != null)
			{
				component3.JumpUpRate = MathUtils.Instance.Clamp(0.3f + 1f / num, 0.3f, 1f);
			}
		}
		return true;
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x0007C3E8 File Offset: 0x0007A5E8
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

	// Token: 0x060016F2 RID: 5874 RVA: 0x0007C488 File Offset: 0x0007A688
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		if (characterActorComponent.GetSequenceBinding())
		{
			return false;
		}
		if (!characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		CharacterMoveComponent component = characterActorComponent.Entity.GetComponent<CharacterMoveComponent>();
		if (component != null)
		{
			component.JumpUpRate = 1f;
		}
		tsBaseCharacter.SetAnimRootMotionTranslationScale(1f);
		return true;
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x0007C4FC File Offset: 0x0007A6FC
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

	// Token: 0x060016F4 RID: 5876 RVA: 0x0007C577 File Offset: 0x0007A777
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置RootMotion缩放比例";
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x0007C57E File Offset: 0x0007A77E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetRootMotionScale._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetRootMotionScale.TsAnimNotifyStateSetRootMotionScale_C");
		}
		return TsAnimNotifyStateSetRootMotionScale._ClassPtr;
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x0007C5A4 File Offset: 0x0007A7A4
	public TsAnimNotifyStateSetRootMotionScale() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetRootMotionScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x0007C5CC File Offset: 0x0007A7CC
	[NullableContext(1)]
	public TsAnimNotifyStateSetRootMotionScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetRootMotionScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x0007C5FF File Offset: 0x0007A7FF
	protected TsAnimNotifyStateSetRootMotionScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x0007C608 File Offset: 0x0007A808
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x0007C644 File Offset: 0x0007A844
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x0007C677 File Offset: 0x0007A877
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000FBE RID: 4030
	private const float MIN_JUMP_UP_RATE = 0.3f;

	// Token: 0x04000FBF RID: 4031
	private const float MAX_JUMP_UP_RATE = 1f;

	// Token: 0x04000FC0 RID: 4032
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetRootMotionScale.TsAnimNotifyStateSetRootMotionScale_C";

	// Token: 0x04000FC1 RID: 4033
	private static IntPtr _ClassPtr;

	// Token: 0x04000FC2 RID: 4034
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FC3 RID: 4035
	private static int __PropertyOffset_Tag;
}
