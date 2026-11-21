using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200016F RID: 367
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetRootMotionScale.TsAnimNotifyStateSetRootMotionScale_C")]
public class TsAnimNotifyStateSetRootMotionScale : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x0600178A RID: 6026 RVA: 0x00081D37 File Offset: 0x0007FF37
	// (set) Token: 0x0600178B RID: 6027 RVA: 0x00081D4B File Offset: 0x0007FF4B
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

	// Token: 0x0600178C RID: 6028 RVA: 0x00081D60 File Offset: 0x0007FF60
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetRootMotionScale) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSetRootMotionScale.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600178D RID: 6029 RVA: 0x00081E20 File Offset: 0x00080020
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

	// Token: 0x0600178E RID: 6030 RVA: 0x00081F28 File Offset: 0x00080128
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetRootMotionScale) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSetRootMotionScale.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600178F RID: 6031 RVA: 0x00081FE0 File Offset: 0x000801E0
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

	// Token: 0x06001790 RID: 6032 RVA: 0x00082054 File Offset: 0x00080254
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSetRootMotionScale) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateSetRootMotionScale.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001791 RID: 6033 RVA: 0x000820E4 File Offset: 0x000802E4
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置RootMotion缩放比例";
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x000820EB File Offset: 0x000802EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSetRootMotionScale._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetRootMotionScale.TsAnimNotifyStateSetRootMotionScale_C");
		}
		return TsAnimNotifyStateSetRootMotionScale._ClassPtr;
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x00082110 File Offset: 0x00080310
	public TsAnimNotifyStateSetRootMotionScale() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetRootMotionScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x00082138 File Offset: 0x00080338
	[NullableContext(1)]
	public TsAnimNotifyStateSetRootMotionScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSetRootMotionScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x0008216B File Offset: 0x0008036B
	protected TsAnimNotifyStateSetRootMotionScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x00082174 File Offset: 0x00080374
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x000821B0 File Offset: 0x000803B0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x000821E3 File Offset: 0x000803E3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001001 RID: 4097
	private const float MIN_JUMP_UP_RATE = 0.3f;

	// Token: 0x04001002 RID: 4098
	private const float MAX_JUMP_UP_RATE = 1f;

	// Token: 0x04001003 RID: 4099
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSetRootMotionScale.TsAnimNotifyStateSetRootMotionScale_C";

	// Token: 0x04001004 RID: 4100
	private static IntPtr _ClassPtr;

	// Token: 0x04001005 RID: 4101
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001006 RID: 4102
	private static int __PropertyOffset_Tag;
}
