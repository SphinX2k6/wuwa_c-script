using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000151 RID: 337
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePosition.TsAnimNotifyStatePosition_C")]
public class TsAnimNotifyStatePosition : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700036F RID: 879
	// (get) Token: 0x06001522 RID: 5410 RVA: 0x000773FB File Offset: 0x000755FB
	// (set) Token: 0x06001523 RID: 5411 RVA: 0x0007740F File Offset: 0x0007560F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector 移动速度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePosition.__PropertyOffset_移动速度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePosition.__PropertyOffset_移动速度) = value;
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06001524 RID: 5412 RVA: 0x00077424 File Offset: 0x00075624
	// (set) Token: 0x06001525 RID: 5413 RVA: 0x00077438 File Offset: 0x00075638
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat 速度曲线
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStatePosition.__PropertyOffset_速度曲线);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStatePosition.__PropertyOffset_速度曲线, value);
		}
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x06001526 RID: 5414 RVA: 0x0007744D File Offset: 0x0007564D
	// (set) Token: 0x06001527 RID: 5415 RVA: 0x0007745D File Offset: 0x0007565D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否持续朝向目标
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePosition.__PropertyOffset_是否持续朝向目标) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePosition.__PropertyOffset_是否持续朝向目标) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x00077470 File Offset: 0x00075670
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStatePosition.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001529 RID: 5417 RVA: 0x00077530 File Offset: 0x00075730
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			object obj;
			if (characterActorComponent == null)
			{
				obj = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				obj = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				FVector 移动速度 = this.移动速度;
				obj2.SetAddMoveWithMesh(meshComp, new FVectorDouble(ref 移动速度), totalDuration, this.速度曲线);
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00077590 File Offset: 0x00075790
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStatePosition.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x00077650 File Offset: 0x00075850
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if (!this.是否持续朝向目标)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			object obj;
			if (characterActorComponent == null)
			{
				obj = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				obj = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				FTransformDouble ftransformDouble = tsBaseCharacter.D_GetTransform();
				FVector 移动速度 = this.移动速度;
				obj2.SetAddMoveWorldSpeedWithMesh(meshComp, UKismetMathLibrary.D_TransformDirection(ftransformDouble, new FVectorDouble(ref 移动速度)));
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x000776C0 File Offset: 0x000758C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStatePosition.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600152D RID: 5421 RVA: 0x00077778 File Offset: 0x00075978
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			object obj;
			if (characterActorComponent == null)
			{
				obj = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				obj = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.StopAddMoveWithMesh(meshComp);
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x000777C4 File Offset: 0x000759C4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStatePosition.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600152F RID: 5423 RVA: 0x00077854 File Offset: 0x00075A54
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "位移到坐标点";
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x0007785B File Offset: 0x00075A5B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStatePosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePosition.TsAnimNotifyStatePosition_C");
		}
		return TsAnimNotifyStatePosition._ClassPtr;
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x00077880 File Offset: 0x00075A80
	public TsAnimNotifyStatePosition() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x000778A8 File Offset: 0x00075AA8
	[NullableContext(1)]
	public TsAnimNotifyStatePosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x000778DB File Offset: 0x00075ADB
	protected TsAnimNotifyStatePosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x000778E4 File Offset: 0x00075AE4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x00077920 File Offset: 0x00075B20
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x0007795C File Offset: 0x00075B5C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x0007798F File Offset: 0x00075B8F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EE2 RID: 3810
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePosition.TsAnimNotifyStatePosition_C";

	// Token: 0x04000EE3 RID: 3811
	private static IntPtr _ClassPtr;

	// Token: 0x04000EE4 RID: 3812
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EE5 RID: 3813
	private static int __PropertyOffset_移动速度;

	// Token: 0x04000EE6 RID: 3814
	private static int __PropertyOffset_速度曲线;

	// Token: 0x04000EE7 RID: 3815
	private static int __PropertyOffset_是否持续朝向目标;
}
