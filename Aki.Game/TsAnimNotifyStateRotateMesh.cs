using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200015D RID: 349
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateMesh.TsAnimNotifyStateRotateMesh_C")]
public class TsAnimNotifyStateRotateMesh : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700039A RID: 922
	// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0007801B File Offset: 0x0007621B
	// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0007802B File Offset: 0x0007622B
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

	// Token: 0x1700039B RID: 923
	// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0007803C File Offset: 0x0007623C
	// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0007804C File Offset: 0x0007624C
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

	// Token: 0x1700039C RID: 924
	// (get) Token: 0x060015E9 RID: 5609 RVA: 0x0007805D File Offset: 0x0007625D
	// (set) Token: 0x060015EA RID: 5610 RVA: 0x0007806D File Offset: 0x0007626D
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

	// Token: 0x1700039D RID: 925
	// (get) Token: 0x060015EB RID: 5611 RVA: 0x0007807E File Offset: 0x0007627E
	// (set) Token: 0x060015EC RID: 5612 RVA: 0x0007808E File Offset: 0x0007628E
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

	// Token: 0x060015ED RID: 5613 RVA: 0x000780A0 File Offset: 0x000762A0
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

	// Token: 0x060015EE RID: 5614 RVA: 0x00078148 File Offset: 0x00076348
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

	// Token: 0x060015EF RID: 5615 RVA: 0x00078174 File Offset: 0x00076374
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

	// Token: 0x060015F0 RID: 5616 RVA: 0x0007821C File Offset: 0x0007641C
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

	// Token: 0x060015F1 RID: 5617 RVA: 0x000784D0 File Offset: 0x000766D0
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

	// Token: 0x060015F2 RID: 5618 RVA: 0x00078570 File Offset: 0x00076770
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

	// Token: 0x060015F3 RID: 5619 RVA: 0x000785FA File Offset: 0x000767FA
	private void Init()
	{
		this.BaseChar = null;
		this.TmpVector = Vector.Create();
		this.ActorTransform = Transform.Create();
		this.TmpRotator = Rotator.Create();
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00078624 File Offset: 0x00076824
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

	// Token: 0x060015F5 RID: 5621 RVA: 0x0007869F File Offset: 0x0007689F
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "旋转网格体";
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x000786A6 File Offset: 0x000768A6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateRotateMesh._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateMesh.TsAnimNotifyStateRotateMesh_C");
		}
		return TsAnimNotifyStateRotateMesh._ClassPtr;
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x000786CC File Offset: 0x000768CC
	public TsAnimNotifyStateRotateMesh() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x000786F4 File Offset: 0x000768F4
	[NullableContext(1)]
	public TsAnimNotifyStateRotateMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateRotateMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x00078727 File Offset: 0x00076927
	protected TsAnimNotifyStateRotateMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x00078730 File Offset: 0x00076930
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x0007876C File Offset: 0x0007696C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x000787A8 File Offset: 0x000769A8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x000787DB File Offset: 0x000769DB
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F5B RID: 3931
	private TsBaseCharacter BaseChar;

	// Token: 0x04000F5C RID: 3932
	private Vector TmpVector;

	// Token: 0x04000F5D RID: 3933
	private Transform ActorTransform;

	// Token: 0x04000F5E RID: 3934
	private Rotator TmpRotator;

	// Token: 0x04000F5F RID: 3935
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateRotateMesh.TsAnimNotifyStateRotateMesh_C";

	// Token: 0x04000F60 RID: 3936
	private static IntPtr _ClassPtr;

	// Token: 0x04000F61 RID: 3937
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F62 RID: 3938
	private static int __PropertyOffset_旋转速度;

	// Token: 0x04000F63 RID: 3939
	private static int __PropertyOffset_是否自动朝向目标;

	// Token: 0x04000F64 RID: 3940
	private static int __PropertyOffset_是否平滑旋转;

	// Token: 0x04000F65 RID: 3941
	private static int __PropertyOffset_是否接受输入控制;
}
