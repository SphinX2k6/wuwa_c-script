using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200015F RID: 351
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateAlignGravity.TsAnimNotifyStateRotateAlignGravity_C")]
public class TsAnimNotifyStateRotateAlignGravity : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x0600164F RID: 5711 RVA: 0x0007C7F3 File Offset: 0x0007A9F3
	// (set) Token: 0x06001650 RID: 5712 RVA: 0x0007C803 File Offset: 0x0007AA03
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateAlignGravity.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateAlignGravity.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x06001651 RID: 5713 RVA: 0x0007C814 File Offset: 0x0007AA14
	// (set) Token: 0x06001652 RID: 5714 RVA: 0x0007C824 File Offset: 0x0007AA24
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ModelBufferTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateAlignGravity.__PropertyOffset_ModelBufferTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateAlignGravity.__PropertyOffset_ModelBufferTime) = value;
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06001653 RID: 5715 RVA: 0x0007C835 File Offset: 0x0007AA35
	// (set) Token: 0x06001654 RID: 5716 RVA: 0x0007C845 File Offset: 0x0007AA45
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateAlignGravity.__PropertyOffset_DebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateAlignGravity.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x0007C858 File Offset: 0x0007AA58
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateAlignGravity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateRotateAlignGravity.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001656 RID: 5718 RVA: 0x0007C918 File Offset: 0x0007AB18
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		return aactor != null && aactor is TsBaseCharacter && (aactor as TsBaseCharacter).CharacterActorComponent != null;
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x0007C950 File Offset: 0x0007AB50
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateAlignGravity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateRotateAlignGravity.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001658 RID: 5720 RVA: 0x0007CA10 File Offset: 0x0007AC10
	[NullableContext(2)]
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if ((double)frameDeltaTime < 0.0001)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (characterActorComponent == null)
		{
			return false;
		}
		BaseMoveComponent moveComp = characterActorComponent.MoveComp;
		if (moveComp == null)
		{
			return false;
		}
		CharacterDriveVehicleComponent component = characterActorComponent.Entity.GetComponent<CharacterDriveVehicleComponent>();
		if (component != null && component.IsOnVehicle)
		{
			return true;
		}
		Vector gravityUp = moveComp.GravityUp;
		if (Math.Abs(MathUtils.Instance.GetAngleByVectorDot(gravityUp, characterActorComponent.ActorUpProxy)) < 1.0)
		{
			return true;
		}
		this.DrawAllow(characterActorComponent.ActorLocationProxy, gravityUp, ColorUtils.LinearBlue);
		this.TempVector.DeepCopy(characterActorComponent.ActorForwardProxy);
		this.DrawAllow(characterActorComponent.ActorLocationProxy, characterActorComponent.ActorForwardProxy, ColorUtils.LinearWhite);
		Vector actorRightProxy = characterActorComponent.ActorRightProxy;
		this.DrawAllow(characterActorComponent.ActorLocationProxy, actorRightProxy, ColorUtils.LinearGreen);
		Vector.VectorPlaneProject(this.TempVector, gravityUp, this.TempVector2);
		if (this.TempVector2.IsNearlyZero(9.999999747378752E-05))
		{
			actorRightProxy.CrossProduct(gravityUp, this.TempVector2);
		}
		this.DrawAllow(characterActorComponent.ActorLocationProxy, this.TempVector2, ColorUtils.LinearRed);
		MathUtils.Instance.LookRotationForwardFirst(this.TempVector2, gravityUp, this.TempRotator);
		this.TempRotator.Quaternion(this.TempQuat);
		characterActorComponent.ActorQuatProxy.Inverse(this.TempQuat2);
		this.TempQuat2.Multiply(this.TempQuat, this.TempQuat3);
		float num = (float)this.TurnSpeed * frameDeltaTime;
		double num2 = Math.Abs(Math.Acos(this.TempQuat3.W) * 2.0 * 57.295780181884766);
		float slerp;
		if (num2 < 0.0001)
		{
			slerp = 1f;
		}
		else
		{
			slerp = (float)MathUtils.Instance.Clamp((double)num / num2, 0.0, 1.0);
		}
		Quat.Slerp(characterActorComponent.ActorQuatProxy, this.TempQuat, slerp, this.TempQuat3);
		this.TempQuat3.Rotator(this.TempRotator);
		characterActorComponent.SetActorRotation(this.TempRotator.ToUeRotator(), "TsAnimNotifyStateRotateAlignGravity.Tick", false);
		return true;
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x0007CC54 File Offset: 0x0007AE54
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateAlignGravity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateRotateAlignGravity.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600165A RID: 5722 RVA: 0x0007CD0C File Offset: 0x0007AF0C
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null)
		{
			return false;
		}
		BaseMoveComponent moveComp = characterActorComponent.MoveComp;
		if (moveComp == null)
		{
			return false;
		}
		CharacterDriveVehicleComponent component = characterActorComponent.Entity.GetComponent<CharacterDriveVehicleComponent>();
		if (component != null && component.IsOnVehicle)
		{
			return true;
		}
		Vector gravityUp = moveComp.GravityUp;
		if (Math.Abs(MathUtils.Instance.GetAngleByVectorDot(gravityUp, characterActorComponent.ActorUpProxy)) < 1.0)
		{
			return true;
		}
		this.TempVector.DeepCopy(characterActorComponent.ActorForwardProxy);
		Vector actorRightProxy = characterActorComponent.ActorRightProxy;
		Vector.VectorPlaneProject(this.TempVector, gravityUp, this.TempVector2);
		if (this.TempVector2.IsNearlyZero(9.999999747378752E-05))
		{
			actorRightProxy.CrossProduct(gravityUp, this.TempVector2);
		}
		MathUtils.Instance.LookRotationForwardFirst(this.TempVector2, gravityUp, this.TempRotator);
		CharacterAnimationComponent component2 = characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
		FTransformDouble? ftransformDouble = (component2 != null) ? new FTransformDouble?(component2.GetMeshTransform()) : null;
		characterActorComponent.SetActorRotation(this.TempRotator.ToUeRotator(), "TsAnimNotifyStateRotateAlignGravity.End", false);
		if (component2 != null && ftransformDouble != null && component2 != null)
		{
			component2.SetModelBuffer(ftransformDouble.Value, (float)this.ModelBufferTime);
		}
		return true;
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x0007CE68 File Offset: 0x0007B068
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateAlignGravity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateRotateAlignGravity.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600165C RID: 5724 RVA: 0x0007CEF8 File Offset: 0x0007B0F8
	protected override string GetNotifyName_Implementation()
	{
		return "旋转对齐Up到重力反方向";
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x0007CF00 File Offset: 0x0007B100
	private void DrawAllow(Vector startLoc, Vector direction, FLinearColor color)
	{
		if (this.DebugDraw)
		{
			this.TempVector3.DeepCopy(direction);
			this.TempVector3.MultiplyEqual(100.0);
			this.TempVector3.AdditionEqual(startLoc);
			UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, startLoc.ToUeVector(false), this.TempVector3.ToUeVector(false), 30f, color, 0f, 0f);
		}
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x0007CF70 File Offset: 0x0007B170
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotateAlignGravity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateAlignGravity.TsAnimNotifyStateRotateAlignGravity_C");
		}
		return TsAnimNotifyStateRotateAlignGravity._ClassPtr;
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x0007CF94 File Offset: 0x0007B194
	public TsAnimNotifyStateRotateAlignGravity() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateAlignGravity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x0007CFBC File Offset: 0x0007B1BC
	public TsAnimNotifyStateRotateAlignGravity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateAlignGravity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x0007CFF0 File Offset: 0x0007B1F0
	protected TsAnimNotifyStateRotateAlignGravity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x0007D0C0 File Offset: 0x0007B2C0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x0007D0FC File Offset: 0x0007B2FC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x0007D138 File Offset: 0x0007B338
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x0007D16B File Offset: 0x0007B36B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F83 RID: 3971
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x04000F84 RID: 3972
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x04000F85 RID: 3973
	private readonly Vector TempVector3 = Vector.Create();

	// Token: 0x04000F86 RID: 3974
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x04000F87 RID: 3975
	private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F88 RID: 3976
	private readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F89 RID: 3977
	private readonly Quat TempQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F8A RID: 3978
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateAlignGravity.TsAnimNotifyStateRotateAlignGravity_C";

	// Token: 0x04000F8B RID: 3979
	private static IntPtr _ClassPtr;

	// Token: 0x04000F8C RID: 3980
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F8D RID: 3981
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000F8E RID: 3982
	private static int __PropertyOffset_ModelBufferTime;

	// Token: 0x04000F8F RID: 3983
	private static int __PropertyOffset_DebugDraw;
}
