using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000175 RID: 373
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSight.TsAnimNotifyStateSight_C")]
public class TsAnimNotifyStateSight : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x060017EC RID: 6124 RVA: 0x00083797 File Offset: 0x00081997
	// (set) Token: 0x060017ED RID: 6125 RVA: 0x000837AB File Offset: 0x000819AB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D 距离区间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSight.__PropertyOffset_距离区间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSight.__PropertyOffset_距离区间) = value;
		}
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x060017EE RID: 6126 RVA: 0x000837C0 File Offset: 0x000819C0
	// (set) Token: 0x060017EF RID: 6127 RVA: 0x000837D4 File Offset: 0x000819D4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D 水平区间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSight.__PropertyOffset_水平区间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSight.__PropertyOffset_水平区间) = value;
		}
	}

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x060017F0 RID: 6128 RVA: 0x000837E9 File Offset: 0x000819E9
	// (set) Token: 0x060017F1 RID: 6129 RVA: 0x000837FD File Offset: 0x000819FD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector2D 垂直区间
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateSight.__PropertyOffset_垂直区间);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateSight.__PropertyOffset_垂直区间) = value;
		}
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00083814 File Offset: 0x00081A14
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSight) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateSight.StaticClass(), out intPtr, out num))
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

	// Token: 0x060017F3 RID: 6131 RVA: 0x000838D4 File Offset: 0x00081AD4
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		CharacterAnimationComponent characterAnimationComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>() : null;
		if (characterAnimationComponent == null)
		{
			return false;
		}
		if (characterAnimationComponent.GetSightCameraData() == null)
		{
			characterAnimationComponent.SetSightCameraData(new SightCameraData
			{
				SightMinDistance = this.距离区间.X,
				SightMaxDistance = this.距离区间.Y,
				SightHorizontalAngleL = (float)MathUtils.Instance.NormalizeDeg180((double)this.水平区间.X),
				SightHorizontalAngleR = (float)MathUtils.Instance.NormalizeDeg180((double)this.水平区间.Y),
				SightVerticalAngleB = (float)MathUtils.Instance.NormalizeDeg180((double)this.垂直区间.X),
				SightVerticalAngleT = (float)MathUtils.Instance.NormalizeDeg180((double)this.垂直区间.Y)
			});
			this.EnableSight = true;
		}
		return true;
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x000839CC File Offset: 0x00081BCC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateSight) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateSight.StaticClass(), out intPtr, out num))
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

	// Token: 0x060017F5 RID: 6133 RVA: 0x00083A84 File Offset: 0x00081C84
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		CharacterAnimationComponent characterAnimationComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>() : null;
		if (characterAnimationComponent == null)
		{
			return false;
		}
		if (this.EnableSight)
		{
			characterAnimationComponent.SetSightCameraData(null);
			this.EnableSight = false;
		}
		return true;
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x00083ADB File Offset: 0x00081CDB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSight._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSight.TsAnimNotifyStateSight_C");
		}
		return TsAnimNotifyStateSight._ClassPtr;
	}

	// Token: 0x060017F7 RID: 6135 RVA: 0x00083B00 File Offset: 0x00081D00
	public TsAnimNotifyStateSight() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060017F8 RID: 6136 RVA: 0x00083B28 File Offset: 0x00081D28
	[NullableContext(1)]
	public TsAnimNotifyStateSight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x00083B5B File Offset: 0x00081D5B
	protected TsAnimNotifyStateSight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x00083B64 File Offset: 0x00081D64
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x00083BA0 File Offset: 0x00081DA0
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04001022 RID: 4130
	private bool EnableSight;

	// Token: 0x04001023 RID: 4131
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSight.TsAnimNotifyStateSight_C";

	// Token: 0x04001024 RID: 4132
	private static IntPtr _ClassPtr;

	// Token: 0x04001025 RID: 4133
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001026 RID: 4134
	private static int __PropertyOffset_距离区间;

	// Token: 0x04001027 RID: 4135
	private static int __PropertyOffset_水平区间;

	// Token: 0x04001028 RID: 4136
	private static int __PropertyOffset_垂直区间;
}
