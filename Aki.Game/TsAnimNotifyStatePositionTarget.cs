using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000154 RID: 340
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionTarget.TsAnimNotifyStatePositionTarget_C")]
public class TsAnimNotifyStatePositionTarget : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000387 RID: 903
	// (get) Token: 0x0600157D RID: 5501 RVA: 0x000790FF File Offset: 0x000772FF
	// (set) Token: 0x0600157E RID: 5502 RVA: 0x0007910F File Offset: 0x0007730F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 最大速度
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionTarget.__PropertyOffset_最大速度);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionTarget.__PropertyOffset_最大速度) = value;
		}
	}

	// Token: 0x17000388 RID: 904
	// (get) Token: 0x0600157F RID: 5503 RVA: 0x00079120 File Offset: 0x00077320
	// (set) Token: 0x06001580 RID: 5504 RVA: 0x00079134 File Offset: 0x00077334
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UCurveFloat 速度变化曲线
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStatePositionTarget.__PropertyOffset_速度变化曲线);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyStatePositionTarget.__PropertyOffset_速度变化曲线, value);
		}
	}

	// Token: 0x17000389 RID: 905
	// (get) Token: 0x06001581 RID: 5505 RVA: 0x00079149 File Offset: 0x00077349
	// (set) Token: 0x06001582 RID: 5506 RVA: 0x00079159 File Offset: 0x00077359
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float 最小距离
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionTarget.__PropertyOffset_最小距离);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionTarget.__PropertyOffset_最小距离) = value;
		}
	}

	// Token: 0x1700038A RID: 906
	// (get) Token: 0x06001583 RID: 5507 RVA: 0x0007916A File Offset: 0x0007736A
	// (set) Token: 0x06001584 RID: 5508 RVA: 0x0007917A File Offset: 0x0007737A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 达成条件后终止逻辑
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionTarget.__PropertyOffset_达成条件后终止逻辑) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStatePositionTarget.__PropertyOffset_达成条件后终止逻辑) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x0007918C File Offset: 0x0007738C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePositionTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStatePositionTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001586 RID: 5510 RVA: 0x0007924C File Offset: 0x0007744C
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		this.Init();
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		if (component == null || !component.Valid)
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
				BaseActorComponent component2 = entity2.GetComponent<BaseActorComponent>();
				aactor = ((component2 != null) ? component2.Owner : null);
			}
		}
		AActor aactor2 = aactor;
		if (aactor2 == null || !aactor2.IsValid())
		{
			return false;
		}
		Vector inB = Vector.Create(owner.D_K2_GetActorLocation());
		Vector.Create(aactor2.D_K2_GetActorLocation()).Subtraction(inB, this.速度);
		this.速度.DivisionEqual((double)totalDuration);
		return true;
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x0007932C File Offset: 0x0007752C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePositionTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStatePositionTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001588 RID: 5512 RVA: 0x000793EC File Offset: 0x000775EC
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		if (this.终止逻辑)
		{
			return false;
		}
		this.经过时间 += frameDeltaTime;
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		Entity entity = tsBaseCharacter.CharacterActorComponent.Entity;
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		if (component == null || !component.Valid)
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
				BaseActorComponent component2 = entity2.GetComponent<BaseActorComponent>();
				aactor = ((component2 != null) ? component2.Owner : null);
			}
		}
		AActor aactor2 = aactor;
		if (aactor2 == null || !aactor2.IsValid())
		{
			return false;
		}
		if (this.最小距离 > 0f)
		{
			Vector v = Vector.Create(owner.D_K2_GetActorLocation());
			Vector v2 = Vector.Create(aactor2.D_K2_GetActorLocation());
			if (Vector.DistSquared(v, v2) <= (double)(this.最小距离 * this.最小距离) && this.达成条件后终止逻辑)
			{
				this.终止逻辑 = true;
				return true;
			}
		}
		UCurveFloat 速度变化曲线 = this.速度变化曲线;
		float num = (速度变化曲线 != null && 速度变化曲线.IsValid()) ? this.速度变化曲线.GetFloatValue(this.经过时间) : 1f;
		this.速度.Multiply((double)num, this.TmpVector);
		this.TmpVector.GetClampedToMaxSize((double)this.最大速度, this.TmpVector);
		this.TmpVector.MultiplyEqual((double)frameDeltaTime);
		BaseMoveComponent component3 = entity.GetComponent<BaseMoveComponent>();
		if (component3 != null)
		{
			component3.SetAddMoveOffset(new FVectorDouble?(this.TmpVector.ToUeVector(false)));
		}
		return true;
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x00079584 File Offset: 0x00077784
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePositionTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStatePositionTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600158A RID: 5514 RVA: 0x0007963A File Offset: 0x0007783A
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		this.经过时间 = 0f;
		return true;
	}

	// Token: 0x0600158B RID: 5515 RVA: 0x00079648 File Offset: 0x00077848
	private void Init()
	{
		this.经过时间 = 0f;
		this.速度 = Vector.Create();
		this.TmpVector = Vector.Create();
		this.终止逻辑 = false;
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x00079674 File Offset: 0x00077874
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStatePositionTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStatePositionTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600158D RID: 5517 RVA: 0x00079704 File Offset: 0x00077904
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "位移到目标身前";
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x0007970B File Offset: 0x0007790B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStatePositionTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionTarget.TsAnimNotifyStatePositionTarget_C");
		}
		return TsAnimNotifyStatePositionTarget._ClassPtr;
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x00079730 File Offset: 0x00077930
	public TsAnimNotifyStatePositionTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePositionTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x00079758 File Offset: 0x00077958
	[NullableContext(1)]
	public TsAnimNotifyStatePositionTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePositionTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x0007978B File Offset: 0x0007798B
	protected TsAnimNotifyStatePositionTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x00079794 File Offset: 0x00077994
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x000797D0 File Offset: 0x000779D0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x0007980C File Offset: 0x00077A0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x0007983F File Offset: 0x00077A3F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000F25 RID: 3877
	private float 经过时间;

	// Token: 0x04000F26 RID: 3878
	private Vector 速度;

	// Token: 0x04000F27 RID: 3879
	private Vector TmpVector;

	// Token: 0x04000F28 RID: 3880
	private bool 终止逻辑;

	// Token: 0x04000F29 RID: 3881
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionTarget.TsAnimNotifyStatePositionTarget_C";

	// Token: 0x04000F2A RID: 3882
	private static IntPtr _ClassPtr;

	// Token: 0x04000F2B RID: 3883
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000F2C RID: 3884
	private static int __PropertyOffset_最大速度;

	// Token: 0x04000F2D RID: 3885
	private static int __PropertyOffset_速度变化曲线;

	// Token: 0x04000F2E RID: 3886
	private static int __PropertyOffset_最小距离;

	// Token: 0x04000F2F RID: 3887
	private static int __PropertyOffset_达成条件后终止逻辑;
}
