using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000146 RID: 326
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyMeshLocation.TsAnimNotifyStateModifyMeshLocation_C")]
public class TsAnimNotifyStateModifyMeshLocation : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000342 RID: 834
	// (get) Token: 0x0600140D RID: 5133 RVA: 0x0006FEAF File Offset: 0x0006E0AF
	// (set) Token: 0x0600140E RID: 5134 RVA: 0x0006FEC3 File Offset: 0x0006E0C3
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

	// Token: 0x0600140F RID: 5135 RVA: 0x0006FED8 File Offset: 0x0006E0D8
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

	// Token: 0x06001410 RID: 5136 RVA: 0x0006FF80 File Offset: 0x0006E180
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

	// Token: 0x06001411 RID: 5137 RVA: 0x00070014 File Offset: 0x0006E214
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

	// Token: 0x06001412 RID: 5138 RVA: 0x000700B4 File Offset: 0x0006E2B4
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

	// Token: 0x06001413 RID: 5139 RVA: 0x00070160 File Offset: 0x0006E360
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

	// Token: 0x06001414 RID: 5140 RVA: 0x000701DB File Offset: 0x0006E3DB
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "调整Mesh相对位置";
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x000701E2 File Offset: 0x0006E3E2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateModifyMeshLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyMeshLocation.TsAnimNotifyStateModifyMeshLocation_C");
		}
		return TsAnimNotifyStateModifyMeshLocation._ClassPtr;
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00070208 File Offset: 0x0006E408
	public TsAnimNotifyStateModifyMeshLocation() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateModifyMeshLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00070230 File Offset: 0x0006E430
	[NullableContext(1)]
	public TsAnimNotifyStateModifyMeshLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateModifyMeshLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x00070263 File Offset: 0x0006E463
	protected TsAnimNotifyStateModifyMeshLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x0007026C File Offset: 0x0006E46C
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x000702A8 File Offset: 0x0006E4A8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x000702DB File Offset: 0x0006E4DB
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000E7B RID: 3707
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateModifyMeshLocation.TsAnimNotifyStateModifyMeshLocation_C";

	// Token: 0x04000E7C RID: 3708
	private static IntPtr _ClassPtr;

	// Token: 0x04000E7D RID: 3709
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000E7E RID: 3710
	private static int __PropertyOffset_RelativeLocation;
}
