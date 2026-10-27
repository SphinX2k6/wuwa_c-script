using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000171 RID: 369
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSight.TsAnimNotifyStateSight_C")]
public class TsAnimNotifyStateSight : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170003CF RID: 975
	// (get) Token: 0x0600174F RID: 5967 RVA: 0x0007DB1F File Offset: 0x0007BD1F
	// (set) Token: 0x06001750 RID: 5968 RVA: 0x0007DB33 File Offset: 0x0007BD33
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

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x06001751 RID: 5969 RVA: 0x0007DB48 File Offset: 0x0007BD48
	// (set) Token: 0x06001752 RID: 5970 RVA: 0x0007DB5C File Offset: 0x0007BD5C
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

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x06001753 RID: 5971 RVA: 0x0007DB71 File Offset: 0x0007BD71
	// (set) Token: 0x06001754 RID: 5972 RVA: 0x0007DB85 File Offset: 0x0007BD85
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

	// Token: 0x06001755 RID: 5973 RVA: 0x0007DB9C File Offset: 0x0007BD9C
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

	// Token: 0x06001756 RID: 5974 RVA: 0x0007DC44 File Offset: 0x0007BE44
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

	// Token: 0x06001757 RID: 5975 RVA: 0x0007DD3C File Offset: 0x0007BF3C
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

	// Token: 0x06001758 RID: 5976 RVA: 0x0007DDDC File Offset: 0x0007BFDC
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

	// Token: 0x06001759 RID: 5977 RVA: 0x0007DE33 File Offset: 0x0007C033
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateSight._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSight.TsAnimNotifyStateSight_C");
		}
		return TsAnimNotifyStateSight._ClassPtr;
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x0007DE58 File Offset: 0x0007C058
	public TsAnimNotifyStateSight() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x0007DE80 File Offset: 0x0007C080
	[NullableContext(1)]
	public TsAnimNotifyStateSight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateSight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x0007DEB3 File Offset: 0x0007C0B3
	protected TsAnimNotifyStateSight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x0007DEBC File Offset: 0x0007C0BC
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x0007DEF8 File Offset: 0x0007C0F8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000FDF RID: 4063
	private bool EnableSight;

	// Token: 0x04000FE0 RID: 4064
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateSight.TsAnimNotifyStateSight_C";

	// Token: 0x04000FE1 RID: 4065
	private static IntPtr _ClassPtr;

	// Token: 0x04000FE2 RID: 4066
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000FE3 RID: 4067
	private static int __PropertyOffset_距离区间;

	// Token: 0x04000FE4 RID: 4068
	private static int __PropertyOffset_水平区间;

	// Token: 0x04000FE5 RID: 4069
	private static int __PropertyOffset_垂直区间;
}
