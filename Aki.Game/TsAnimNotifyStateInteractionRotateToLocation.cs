using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200013E RID: 318
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInteractionRotateToLocation.TsAnimNotifyStateInteractionRotateToLocation_C")]
public class TsAnimNotifyStateInteractionRotateToLocation : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600137C RID: 4988 RVA: 0x0006D4BC File Offset: 0x0006B6BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = TotalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x0006D564 File Offset: 0x0006B764
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

	// Token: 0x0600137E RID: 4990 RVA: 0x0006D634 File Offset: 0x0006B834
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((MeshComp != null) ? MeshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((Animation != null) ? Animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = FrameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x0006D6DC File Offset: 0x0006B8DC
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

	// Token: 0x06001380 RID: 4992 RVA: 0x0006D744 File Offset: 0x0006B944
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

	// Token: 0x06001381 RID: 4993 RVA: 0x0006D7BF File Offset: 0x0006B9BF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置交互动作旋转和位置";
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x0006D7C6 File Offset: 0x0006B9C6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateInteractionRotateToLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInteractionRotateToLocation.TsAnimNotifyStateInteractionRotateToLocation_C");
		}
		return TsAnimNotifyStateInteractionRotateToLocation._ClassPtr;
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x0006D7EC File Offset: 0x0006B9EC
	public TsAnimNotifyStateInteractionRotateToLocation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateInteractionRotateToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x0006D814 File Offset: 0x0006BA14
	[NullableContext(1)]
	public TsAnimNotifyStateInteractionRotateToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateInteractionRotateToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x0006D847 File Offset: 0x0006BA47
	protected TsAnimNotifyStateInteractionRotateToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x0006D850 File Offset: 0x0006BA50
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x0006D88C File Offset: 0x0006BA8C
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x0006D8C5 File Offset: 0x0006BAC5
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E31 RID: 3633
	private float RotateSpeed;

	// Token: 0x04000E32 RID: 3634
	private float Rotator;

	// Token: 0x04000E33 RID: 3635
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateInteractionRotateToLocation.TsAnimNotifyStateInteractionRotateToLocation_C";

	// Token: 0x04000E34 RID: 3636
	private static IntPtr _ClassPtr;

	// Token: 0x04000E35 RID: 3637
	private static IntPtr _ClassDefaultObjectPtr;
}
