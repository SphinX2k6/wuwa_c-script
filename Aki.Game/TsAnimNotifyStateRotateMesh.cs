using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000161 RID: 353
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateMesh.TsAnimNotifyStateRotateMesh_C")]
public class TsAnimNotifyStateRotateMesh : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003BC RID: 956
	// (get) Token: 0x06001682 RID: 5762 RVA: 0x0007D79F File Offset: 0x0007B99F
	// (set) Token: 0x06001683 RID: 5763 RVA: 0x0007D7AF File Offset: 0x0007B9AF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 旋转速度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateMesh.__PropertyOffset_旋转速度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateMesh.__PropertyOffset_旋转速度) = value;
		}
	}

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x06001684 RID: 5764 RVA: 0x0007D7C0 File Offset: 0x0007B9C0
	// (set) Token: 0x06001685 RID: 5765 RVA: 0x0007D7D0 File Offset: 0x0007B9D0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否自动朝向目标
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateMesh.__PropertyOffset_是否自动朝向目标) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateMesh.__PropertyOffset_是否自动朝向目标) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x06001686 RID: 5766 RVA: 0x0007D7E1 File Offset: 0x0007B9E1
	// (set) Token: 0x06001687 RID: 5767 RVA: 0x0007D7F1 File Offset: 0x0007B9F1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否平滑旋转
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateMesh.__PropertyOffset_是否平滑旋转) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateMesh.__PropertyOffset_是否平滑旋转) = (value ? 1 : 0);
		}
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x06001688 RID: 5768 RVA: 0x0007D802 File Offset: 0x0007BA02
	// (set) Token: 0x06001689 RID: 5769 RVA: 0x0007D812 File Offset: 0x0007BA12
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 是否接受输入控制
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateMesh.__PropertyOffset_是否接受输入控制) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateRotateMesh.__PropertyOffset_是否接受输入控制) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x0007D824 File Offset: 0x0007BA24
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateRotateMesh.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600168B RID: 5771 RVA: 0x0007D8E4 File Offset: 0x0007BAE4
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Init();
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			this.BaseChar = tsBaseCharacter;
			return true;
		}
		return false;
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x0007D910 File Offset: 0x0007BB10
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateRotateMesh.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600168D RID: 5773 RVA: 0x0007D9D0 File Offset: 0x0007BBD0
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter baseChar = this.BaseChar;
		if (baseChar == null || !baseChar.IsValid())
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = this.BaseChar.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		BaseMoveComponent component2 = entity.GetComponent<BaseMoveComponent>();
		if (component == null || !component.Valid || (component2 == null || !component2.Valid))
		{
			return false;
		}
		EntityHandle skillTargetForAns = component.GetSkillTargetForAns();
		AActor aactor;
		if (skillTargetForAns == null)
		{
			aactor = null;
		}
		else
		{
			WorldEntity entity2 = skillTargetForAns.Entity;
			if (entity2 == null)
			{
				aactor = null;
			}
			else
			{
				BaseActorComponent component3 = entity2.GetComponent<BaseActorComponent>();
				aactor = ((component3 != null) ? component3.Owner : null);
			}
		}
		AActor aactor2 = aactor;
		Transform actorTransform = this.ActorTransform;
		FTransformDouble ftransformDouble = this.BaseChar.D_GetTransform();
		actorTransform.FromUeTransform(ftransformDouble);
		float num;
		if (this.是否自动朝向目标 && aactor2 != null && aactor2.IsValid())
		{
			Vector tmpVector = this.TmpVector;
			FVectorDouble fvectorDouble = aactor2.D_K2_GetActorLocation();
			tmpVector.FromUeVector(fvectorDouble);
			MathUtils.Instance.InverseTransformPosition(this.ActorTransform.GetLocation(), this.ActorTransform.GetRotation().Rotator(null), this.ActorTransform.GetScale3D(), this.TmpVector, this.TmpVector);
			this.TmpVector.ToOrientationRotator(this.TmpRotator);
			num = this.TmpRotator.Yaw - 90f;
		}
		else
		{
			if (!component2.HasMoveInput || !this.是否接受输入控制)
			{
				return true;
			}
			Vector tmpVector2 = this.TmpVector;
			FVectorDouble fvectorDouble = this.BaseChar.CharacterActorComponent.InputDirect;
			tmpVector2.FromUeVector(fvectorDouble);
			MathUtils.Instance.InverseTransformPosition(this.ActorTransform.GetLocation(), this.ActorTransform.GetRotation().Rotator(null), this.ActorTransform.GetScale3D(), this.TmpVector, this.TmpVector);
			this.TmpVector.ToOrientationRotator(this.TmpRotator);
			num = this.TmpRotator.Yaw - 90f;
		}
		float yaw = this.BaseChar.Mesh.RelativeRotation.Yaw;
		while (num - yaw > 180f)
		{
			num -= 360f;
		}
		while (yaw - num > 180f)
		{
			num += 360f;
		}
		float num2 = num - yaw;
		if (num2 == 0f)
		{
			return true;
		}
		if (this.旋转速度 > 0f)
		{
			num = MathUtils.Instance.Clamp(this.旋转速度 * frameDeltaTime / Math.Abs(num2), 0f, 1f) * num2 + yaw;
		}
		this.BaseChar.Mesh.K2_SetRelativeRotation(new FRotator(0f, num, 0f), false, ref WorldGlobal.SweepHitResult, false);
		return true;
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x0007DC84 File Offset: 0x0007BE84
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateRotateMesh.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600168F RID: 5775 RVA: 0x0007DD3C File Offset: 0x0007BF3C
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner != null && owner.IsValid())
		{
			TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				tsBaseCharacter.CharacterActorComponent.SetActorRotationWithPriority(UKismetMathLibrary.ComposeRotators(tsBaseCharacter.Mesh.K2_GetComponentRotation(), new FRotator(0f, 90f, 0f)), "TsAnimNotifyStateRotateMesh", ESetRotationPriority.Movement, true, false);
				tsBaseCharacter.Mesh.K2_SetRelativeRotation(new FRotator(0f, -90f, 0f), false, ref WorldGlobal.SweepHitResult, false);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x0007DDC6 File Offset: 0x0007BFC6
	private void Init()
	{
		this.BaseChar = null;
		this.TmpVector = Vector.Create();
		this.ActorTransform = Transform.Create();
		this.TmpRotator = Rotator.Create();
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x0007DDF0 File Offset: 0x0007BFF0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateRotateMesh) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateRotateMesh.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001692 RID: 5778 RVA: 0x0007DE80 File Offset: 0x0007C080
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "旋转网格体";
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x0007DE87 File Offset: 0x0007C087
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotateMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateMesh.TsAnimNotifyStateRotateMesh_C");
		}
		return TsAnimNotifyStateRotateMesh._ClassPtr;
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x0007DEAC File Offset: 0x0007C0AC
	public TsAnimNotifyStateRotateMesh() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x0007DED4 File Offset: 0x0007C0D4
	[NullableContext(1)]
	public TsAnimNotifyStateRotateMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x0007DF07 File Offset: 0x0007C107
	protected TsAnimNotifyStateRotateMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x0007DF10 File Offset: 0x0007C110
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x0007DF4C File Offset: 0x0007C14C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x0007DF88 File Offset: 0x0007C188
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x0007DFBB File Offset: 0x0007C1BB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F9E RID: 3998
	private TsBaseCharacter BaseChar;

	// Token: 0x04000F9F RID: 3999
	private Vector TmpVector;

	// Token: 0x04000FA0 RID: 4000
	private Transform ActorTransform;

	// Token: 0x04000FA1 RID: 4001
	private Rotator TmpRotator;

	// Token: 0x04000FA2 RID: 4002
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateMesh.TsAnimNotifyStateRotateMesh_C";

	// Token: 0x04000FA3 RID: 4003
	private static IntPtr _ClassPtr;

	// Token: 0x04000FA4 RID: 4004
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FA5 RID: 4005
	private static int __PropertyOffset_旋转速度;

	// Token: 0x04000FA6 RID: 4006
	private static int __PropertyOffset_是否自动朝向目标;

	// Token: 0x04000FA7 RID: 4007
	private static int __PropertyOffset_是否平滑旋转;

	// Token: 0x04000FA8 RID: 4008
	private static int __PropertyOffset_是否接受输入控制;
}
