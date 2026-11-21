using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200014A RID: 330
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyMeshLocation.TsAnimNotifyStateModifyMeshLocation_C")]
public class TsAnimNotifyStateModifyMeshLocation : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000364 RID: 868
	// (get) Token: 0x060014AA RID: 5290 RVA: 0x000750F3 File Offset: 0x000732F3
	// (set) Token: 0x060014AB RID: 5291 RVA: 0x00075107 File Offset: 0x00073307
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector RelativeLocation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateModifyMeshLocation.__PropertyOffset_RelativeLocation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateModifyMeshLocation.__PropertyOffset_RelativeLocation) = value;
		}
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x0007511C File Offset: 0x0007331C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateModifyMeshLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateModifyMeshLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x060014AD RID: 5293 RVA: 0x000751DC File Offset: 0x000733DC
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = ((TsBaseCharacter)owner).GetEntityNoBlueprint();
		CharacterAnimationComponent characterAnimationComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterAnimationComponent>() : null;
		if (characterAnimationComponent != null && characterAnimationComponent.Valid)
		{
			TsBaseCharacter actor = characterAnimationComponent.Actor;
			if (((actor != null) ? actor.Mesh : null) != null && characterAnimationComponent.Actor.Mesh.IsValid())
			{
				Vector commonTempVector = MathUtils.Instance.CommonTempVector;
				FVector relativeLocation = this.RelativeLocation;
				commonTempVector.FromUeVector(relativeLocation);
				characterAnimationComponent.AddModelLocation(MathUtils.Instance.CommonTempVector);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x00075270 File Offset: 0x00073470
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateModifyMeshLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateModifyMeshLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x060014AF RID: 5295 RVA: 0x00075328 File Offset: 0x00073528
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = ((TsBaseCharacter)owner).GetEntityNoBlueprint();
		CharacterAnimationComponent characterAnimationComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterAnimationComponent>() : null;
		if (characterAnimationComponent != null && characterAnimationComponent.Valid)
		{
			TsBaseCharacter actor = characterAnimationComponent.Actor;
			if (((actor != null) ? actor.Mesh : null) != null && characterAnimationComponent.Actor.Mesh.IsValid())
			{
				Vector commonTempVector = MathUtils.Instance.CommonTempVector;
				FVector relativeLocation = this.RelativeLocation;
				commonTempVector.FromUeVector(relativeLocation);
				MathUtils.Instance.CommonTempVector.UnaryNegation(MathUtils.Instance.CommonTempVector);
				characterAnimationComponent.AddModelLocation(MathUtils.Instance.CommonTempVector);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x000753D4 File Offset: 0x000735D4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateModifyMeshLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateModifyMeshLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x060014B1 RID: 5297 RVA: 0x00075464 File Offset: 0x00073664
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "调整Mesh相对位置";
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x0007546B File Offset: 0x0007366B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateModifyMeshLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyMeshLocation.TsAnimNotifyStateModifyMeshLocation_C");
		}
		return TsAnimNotifyStateModifyMeshLocation._ClassPtr;
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00075490 File Offset: 0x00073690
	public TsAnimNotifyStateModifyMeshLocation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateModifyMeshLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x000754B8 File Offset: 0x000736B8
	[NullableContext(1)]
	public TsAnimNotifyStateModifyMeshLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateModifyMeshLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x000754EB File Offset: 0x000736EB
	protected TsAnimNotifyStateModifyMeshLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x000754F4 File Offset: 0x000736F4
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00075530 File Offset: 0x00073730
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x00075563 File Offset: 0x00073763
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000EBE RID: 3774
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyMeshLocation.TsAnimNotifyStateModifyMeshLocation_C";

	// Token: 0x04000EBF RID: 3775
	private static IntPtr _ClassPtr;

	// Token: 0x04000EC0 RID: 3776
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000EC1 RID: 3777
	private static int __PropertyOffset_RelativeLocation;
}
