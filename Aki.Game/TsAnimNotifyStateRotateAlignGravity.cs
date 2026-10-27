using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200015B RID: 347
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateAlignGravity.TsAnimNotifyStateRotateAlignGravity_C")]
public class TsAnimNotifyStateRotateAlignGravity : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000390 RID: 912
	// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00077123 File Offset: 0x00075323
	// (set) Token: 0x060015B3 RID: 5555 RVA: 0x00077133 File Offset: 0x00075333
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

	// Token: 0x17000391 RID: 913
	// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00077144 File Offset: 0x00075344
	// (set) Token: 0x060015B5 RID: 5557 RVA: 0x00077154 File Offset: 0x00075354
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

	// Token: 0x17000392 RID: 914
	// (get) Token: 0x060015B6 RID: 5558 RVA: 0x00077165 File Offset: 0x00075365
	// (set) Token: 0x060015B7 RID: 5559 RVA: 0x00077175 File Offset: 0x00075375
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

	// Token: 0x060015B8 RID: 5560 RVA: 0x00077188 File Offset: 0x00075388
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

	// Token: 0x060015B9 RID: 5561 RVA: 0x00077230 File Offset: 0x00075430
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor aactor = (meshComp != null) ? meshComp.GetOwner() : null;
		return aactor != null && aactor is TsBaseCharacter && (aactor as TsBaseCharacter).CharacterActorComponent != null;
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x00077268 File Offset: 0x00075468
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00077310 File Offset: 0x00075510
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

	// Token: 0x060015BC RID: 5564 RVA: 0x0007754C File Offset: 0x0007574C
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

	// Token: 0x060015BD RID: 5565 RVA: 0x000775EC File Offset: 0x000757EC
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

	// Token: 0x060015BE RID: 5566 RVA: 0x0007773C File Offset: 0x0007593C
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

	// Token: 0x060015BF RID: 5567 RVA: 0x000777B7 File Offset: 0x000759B7
	protected override string GetNotifyName_Implementation()
	{
		return "旋转对齐Up到重力反方向";
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x000777C0 File Offset: 0x000759C0
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

	// Token: 0x060015C1 RID: 5569 RVA: 0x00077830 File Offset: 0x00075A30
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotateAlignGravity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateAlignGravity.TsAnimNotifyStateRotateAlignGravity_C");
		}
		return TsAnimNotifyStateRotateAlignGravity._ClassPtr;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00077854 File Offset: 0x00075A54
	public TsAnimNotifyStateRotateAlignGravity() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateAlignGravity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x0007787C File Offset: 0x00075A7C
	public TsAnimNotifyStateRotateAlignGravity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateAlignGravity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x000778B0 File Offset: 0x00075AB0
	protected TsAnimNotifyStateRotateAlignGravity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00077980 File Offset: 0x00075B80
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x000779BC File Offset: 0x00075BBC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x000779F8 File Offset: 0x00075BF8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x00077A2B File Offset: 0x00075C2B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F40 RID: 3904
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x04000F41 RID: 3905
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x04000F42 RID: 3906
	private readonly Vector TempVector3 = Vector.Create();

	// Token: 0x04000F43 RID: 3907
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x04000F44 RID: 3908
	private readonly Quat TempQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F45 RID: 3909
	private readonly Quat TempQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F46 RID: 3910
	private readonly Quat TempQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04000F47 RID: 3911
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateAlignGravity.TsAnimNotifyStateRotateAlignGravity_C";

	// Token: 0x04000F48 RID: 3912
	private static IntPtr _ClassPtr;

	// Token: 0x04000F49 RID: 3913
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F4A RID: 3914
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000F4B RID: 3915
	private static int __PropertyOffset_ModelBufferTime;

	// Token: 0x04000F4C RID: 3916
	private static int __PropertyOffset_DebugDraw;
}
