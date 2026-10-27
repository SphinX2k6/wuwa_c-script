using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000150 RID: 336
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionTarget.TsAnimNotifyStatePositionTarget_C")]
public class TsAnimNotifyStatePositionTarget : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000365 RID: 869
	// (get) Token: 0x060014E0 RID: 5344 RVA: 0x00073C6B File Offset: 0x00071E6B
	// (set) Token: 0x060014E1 RID: 5345 RVA: 0x00073C7B File Offset: 0x00071E7B
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

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x060014E2 RID: 5346 RVA: 0x00073C8C File Offset: 0x00071E8C
	// (set) Token: 0x060014E3 RID: 5347 RVA: 0x00073CA0 File Offset: 0x00071EA0
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

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x060014E4 RID: 5348 RVA: 0x00073CB5 File Offset: 0x00071EB5
	// (set) Token: 0x060014E5 RID: 5349 RVA: 0x00073CC5 File Offset: 0x00071EC5
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

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00073CD6 File Offset: 0x00071ED6
	// (set) Token: 0x060014E7 RID: 5351 RVA: 0x00073CE6 File Offset: 0x00071EE6
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

	// Token: 0x060014E8 RID: 5352 RVA: 0x00073CF8 File Offset: 0x00071EF8
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

	// Token: 0x060014E9 RID: 5353 RVA: 0x00073DA0 File Offset: 0x00071FA0
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

	// Token: 0x060014EA RID: 5354 RVA: 0x00073E80 File Offset: 0x00072080
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

	// Token: 0x060014EB RID: 5355 RVA: 0x00073F28 File Offset: 0x00072128
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

	// Token: 0x060014EC RID: 5356 RVA: 0x000740C0 File Offset: 0x000722C0
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

	// Token: 0x060014ED RID: 5357 RVA: 0x0007415F File Offset: 0x0007235F
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		this.经过时间 = 0f;
		return true;
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x0007416D File Offset: 0x0007236D
	private void Init()
	{
		this.经过时间 = 0f;
		this.速度 = Vector.Create();
		this.TmpVector = Vector.Create();
		this.终止逻辑 = false;
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x00074198 File Offset: 0x00072398
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

	// Token: 0x060014F0 RID: 5360 RVA: 0x00074213 File Offset: 0x00072413
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "位移到目标身前";
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x0007421A File Offset: 0x0007241A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStatePositionTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionTarget.TsAnimNotifyStatePositionTarget_C");
		}
		return TsAnimNotifyStatePositionTarget._ClassPtr;
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00074240 File Offset: 0x00072440
	public TsAnimNotifyStatePositionTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePositionTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x00074268 File Offset: 0x00072468
	[NullableContext(1)]
	public TsAnimNotifyStatePositionTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStatePositionTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x0007429B File Offset: 0x0007249B
	protected TsAnimNotifyStatePositionTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x000742A4 File Offset: 0x000724A4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x000742E0 File Offset: 0x000724E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x0007431C File Offset: 0x0007251C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x0007434F File Offset: 0x0007254F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EE2 RID: 3810
	private float 经过时间;

	// Token: 0x04000EE3 RID: 3811
	private Vector 速度;

	// Token: 0x04000EE4 RID: 3812
	private Vector TmpVector;

	// Token: 0x04000EE5 RID: 3813
	private bool 终止逻辑;

	// Token: 0x04000EE6 RID: 3814
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStatePositionTarget.TsAnimNotifyStatePositionTarget_C";

	// Token: 0x04000EE7 RID: 3815
	private static IntPtr _ClassPtr;

	// Token: 0x04000EE8 RID: 3816
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EE9 RID: 3817
	private static int __PropertyOffset_最大速度;

	// Token: 0x04000EEA RID: 3818
	private static int __PropertyOffset_速度变化曲线;

	// Token: 0x04000EEB RID: 3819
	private static int __PropertyOffset_最小距离;

	// Token: 0x04000EEC RID: 3820
	private static int __PropertyOffset_达成条件后终止逻辑;
}
