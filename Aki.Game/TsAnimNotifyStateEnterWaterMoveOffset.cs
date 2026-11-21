using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000134 RID: 308
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnterWaterMoveOffset.TsAnimNotifyStateEnterWaterMoveOffset_C")]
public class TsAnimNotifyStateEnterWaterMoveOffset : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000320 RID: 800
	// (get) Token: 0x060012F0 RID: 4848 RVA: 0x0006C4EF File Offset: 0x0006A6EF
	// (set) Token: 0x060012F1 RID: 4849 RVA: 0x0006C4FF File Offset: 0x0006A6FF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EnterWaterVelocityZ
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateEnterWaterMoveOffset.__PropertyOffset_EnterWaterVelocityZ);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateEnterWaterMoveOffset.__PropertyOffset_EnterWaterVelocityZ) = value;
		}
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x0006C510 File Offset: 0x0006A710
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateEnterWaterMoveOffset) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateEnterWaterMoveOffset.StaticClass(), out intPtr, out num))
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

	// Token: 0x060012F3 RID: 4851 RVA: 0x0006C5D0 File Offset: 0x0006A7D0
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null)
			{
				(owner as TsBaseCharacter).SetAnimRootMotionTranslationScale(MathUtils.Instance.Clamp(Math.Abs((owner as TsBaseCharacter).CharacterMovement.Velocity.Z) / this.EnterWaterVelocityZ, 0.7f, 1f));
				CharacterSwimComponent component = entity.GetComponent<CharacterSwimComponent>();
				if (component != null)
				{
					component.SetEnterWaterState(true);
				}
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "No Entity for TsBaseCharacter";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", owner);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", owner.D_K2_GetActorLocation());
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return false;
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x0006C6BC File Offset: 0x0006A8BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateEnterWaterMoveOffset) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateEnterWaterMoveOffset.StaticClass(), out intPtr, out num))
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

	// Token: 0x060012F5 RID: 4853 RVA: 0x0006C774 File Offset: 0x0006A974
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity != null)
			{
				(owner as TsBaseCharacter).SetAnimRootMotionTranslationScale(1f);
				CharacterSwimComponent component = entity.GetComponent<CharacterSwimComponent>();
				if (component != null)
				{
					component.SetEnterWaterState(false);
				}
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "No Entity for TsBaseCharacter";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", owner);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("location", owner.D_K2_GetActorLocation());
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return false;
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x0006C830 File Offset: 0x0006AA30
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateEnterWaterMoveOffset) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateEnterWaterMoveOffset.StaticClass(), out intPtr, out num))
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

	// Token: 0x060012F7 RID: 4855 RVA: 0x0006C8C0 File Offset: 0x0006AAC0
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "空中落水移动";
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x0006C8C7 File Offset: 0x0006AAC7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateEnterWaterMoveOffset._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnterWaterMoveOffset.TsAnimNotifyStateEnterWaterMoveOffset_C");
		}
		return TsAnimNotifyStateEnterWaterMoveOffset._ClassPtr;
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x0006C8EC File Offset: 0x0006AAEC
	public TsAnimNotifyStateEnterWaterMoveOffset() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnterWaterMoveOffset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x0006C914 File Offset: 0x0006AB14
	[NullableContext(1)]
	public TsAnimNotifyStateEnterWaterMoveOffset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateEnterWaterMoveOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x0006C947 File Offset: 0x0006AB47
	protected TsAnimNotifyStateEnterWaterMoveOffset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x0006C950 File Offset: 0x0006AB50
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x0006C98C File Offset: 0x0006AB8C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x0006C9BF File Offset: 0x0006ABBF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E03 RID: 3587
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateEnterWaterMoveOffset.TsAnimNotifyStateEnterWaterMoveOffset_C";

	// Token: 0x04000E04 RID: 3588
	private static IntPtr _ClassPtr;

	// Token: 0x04000E05 RID: 3589
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E06 RID: 3590
	private static int __PropertyOffset_EnterWaterVelocityZ;
}
