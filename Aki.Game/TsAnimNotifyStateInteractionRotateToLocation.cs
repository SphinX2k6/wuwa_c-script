using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000142 RID: 322
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInteractionRotateToLocation.TsAnimNotifyStateInteractionRotateToLocation_C")]
public class TsAnimNotifyStateInteractionRotateToLocation : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001419 RID: 5145 RVA: 0x0007257C File Offset: 0x0007077C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateInteractionRotateToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateInteractionRotateToLocation.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(MeshComp, Animation, TotalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = TotalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x0007263C File Offset: 0x0007083C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
	{
		AActor owner = MeshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = ((TsBaseCharacter)owner).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		CharacterActionComponent characterActionComponent = (entity != null) ? entity.GetComponent<CharacterActionComponent>() : null;
		CharacterActorComponent characterActorComponent2 = (entity != null) ? entity.GetComponent<CharacterActorComponent>() : null;
		if (characterActionComponent == null || !characterActionComponent.Valid || characterActorComponent2 == null || !characterActorComponent2.Valid)
		{
			return false;
		}
		Vector vector = Vector.Create();
		characterActionComponent.GetInteractionTargetLocation().Subtraction(characterActorComponent2.ActorLocationProxy, vector);
		this.Rotator = (float)vector.HeadingAngle() * 57.29578f;
		float num = characterActorComponent2.ActorRotationProxy.Yaw - this.Rotator;
		if (num > 180f)
		{
			num = 360f - num;
		}
		num = Math.Abs(num);
		this.RotateSpeed = num / TotalDuration;
		return true;
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x0007270C File Offset: 0x0007090C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateInteractionRotateToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateInteractionRotateToLocation.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(MeshComp, Animation, FrameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = FrameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x000727CC File Offset: 0x000709CC
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = MeshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		CharacterMoveComponent characterMoveComponent;
		if (characterActorComponent == null)
		{
			characterMoveComponent = null;
		}
		else
		{
			Entity entity = characterActorComponent.Entity;
			characterMoveComponent = ((entity != null) ? entity.GetComponent<CharacterMoveComponent>() : null);
		}
		CharacterMoveComponent characterMoveComponent2 = characterMoveComponent;
		if (characterMoveComponent2 == null)
		{
			return false;
		}
		characterMoveComponent2.SmoothCharacterRotationByValue(0f, this.Rotator, 0f, this.RotateSpeed, FrameDeltaTime, "TsAnimNotifyStateInteractionRotateToLocation");
		return true;
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x00072834 File Offset: 0x00070A34
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateInteractionRotateToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateInteractionRotateToLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600141E RID: 5150 RVA: 0x000728C4 File Offset: 0x00070AC4
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置交互动作旋转和位置";
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x000728CB File Offset: 0x00070ACB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateInteractionRotateToLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInteractionRotateToLocation.TsAnimNotifyStateInteractionRotateToLocation_C");
		}
		return TsAnimNotifyStateInteractionRotateToLocation._ClassPtr;
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x000728F0 File Offset: 0x00070AF0
	public TsAnimNotifyStateInteractionRotateToLocation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateInteractionRotateToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x00072918 File Offset: 0x00070B18
	[NullableContext(1)]
	public TsAnimNotifyStateInteractionRotateToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateInteractionRotateToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0007294B File Offset: 0x00070B4B
	protected TsAnimNotifyStateInteractionRotateToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x00072954 File Offset: 0x00070B54
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x00072990 File Offset: 0x00070B90
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x000729C9 File Offset: 0x00070BC9
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E74 RID: 3700
	private float RotateSpeed;

	// Token: 0x04000E75 RID: 3701
	private float Rotator;

	// Token: 0x04000E76 RID: 3702
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInteractionRotateToLocation.TsAnimNotifyStateInteractionRotateToLocation_C";

	// Token: 0x04000E77 RID: 3703
	private static IntPtr _ClassPtr;

	// Token: 0x04000E78 RID: 3704
	private static IntPtr _ClassDefaultObjectPtr;
}
