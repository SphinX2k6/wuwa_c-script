using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DC RID: 476
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetTransformWithModelBuffer.TsAnimNotifySetTransformWithModelBuffer_C")]
public class TsAnimNotifySetTransformWithModelBuffer : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004D5 RID: 1237
	// (get) Token: 0x06001E00 RID: 7680 RVA: 0x0009B2D7 File Offset: 0x000994D7
	// (set) Token: 0x06001E01 RID: 7681 RVA: 0x0009B2EB File Offset: 0x000994EB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string LocationKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySetTransformWithModelBuffer.__PropertyOffset_LocationKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySetTransformWithModelBuffer.__PropertyOffset_LocationKey)), value);
		}
	}

	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x06001E02 RID: 7682 RVA: 0x0009B300 File Offset: 0x00099500
	// (set) Token: 0x06001E03 RID: 7683 RVA: 0x0009B314 File Offset: 0x00099514
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string RotatorKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySetTransformWithModelBuffer.__PropertyOffset_RotatorKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifySetTransformWithModelBuffer.__PropertyOffset_RotatorKey)), value);
		}
	}

	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x06001E04 RID: 7684 RVA: 0x0009B329 File Offset: 0x00099529
	// (set) Token: 0x06001E05 RID: 7685 RVA: 0x0009B339 File Offset: 0x00099539
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TimeLength
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifySetTransformWithModelBuffer.__PropertyOffset_TimeLength);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifySetTransformWithModelBuffer.__PropertyOffset_TimeLength) = value;
		}
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x0009B34C File Offset: 0x0009954C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySetTransformWithModelBuffer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySetTransformWithModelBuffer.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x0009B404 File Offset: 0x00099604
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = characterActorComponent.Entity;
		FTransformDouble ftransformDouble = (owner as TsBaseCharacter).D_GetTransform();
		if (!string.IsNullOrEmpty(this.LocationKey))
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(entity.Id, this.LocationKey);
			if (vectorValueByEntity != null)
			{
				FVectorDouble fvectorDouble = WorldGlobal.ToUeVector(vectorValueByEntity);
				ftransformDouble.SetLocation(fvectorDouble);
			}
		}
		if (!string.IsNullOrEmpty(this.RotatorKey))
		{
			Aki.Protocol.Rotator rotatorValueByEntity = BlackboardController.Instance.GetRotatorValueByEntity(entity.Id, this.RotatorKey);
			if (rotatorValueByEntity != null)
			{
				FQuat fquat = WorldGlobal.ToUeRotator(rotatorValueByEntity).Quaternion();
				ftransformDouble.SetRotation(fquat);
			}
		}
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component == null || !component.Valid)
		{
			characterActorComponent.SetActorTransform(ftransformDouble, "TsAnimNotifySetTransformWithModelBuffer", true, null);
		}
		else
		{
			component.SetTransformWithModelBuffer(ftransformDouble, this.TimeLength, null, true);
		}
		return true;
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x0009B510 File Offset: 0x00099710
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySetTransformWithModelBuffer) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifySetTransformWithModelBuffer.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x0009B5A0 File Offset: 0x000997A0
	protected override string GetNotifyName_Implementation()
	{
		return "怪物趴墙";
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x0009B5A7 File Offset: 0x000997A7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySetTransformWithModelBuffer._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetTransformWithModelBuffer.TsAnimNotifySetTransformWithModelBuffer_C");
		}
		return TsAnimNotifySetTransformWithModelBuffer._ClassPtr;
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x0009B5CC File Offset: 0x000997CC
	public TsAnimNotifySetTransformWithModelBuffer() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetTransformWithModelBuffer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x0009B5F4 File Offset: 0x000997F4
	public TsAnimNotifySetTransformWithModelBuffer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetTransformWithModelBuffer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x0009B627 File Offset: 0x00099827
	protected TsAnimNotifySetTransformWithModelBuffer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x0009B630 File Offset: 0x00099830
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x0009B663 File Offset: 0x00099863
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400128A RID: 4746
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetTransformWithModelBuffer.TsAnimNotifySetTransformWithModelBuffer_C";

	// Token: 0x0400128B RID: 4747
	private static IntPtr _ClassPtr;

	// Token: 0x0400128C RID: 4748
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400128D RID: 4749
	private static int __PropertyOffset_LocationKey;

	// Token: 0x0400128E RID: 4750
	private static int __PropertyOffset_RotatorKey;

	// Token: 0x0400128F RID: 4751
	private static int __PropertyOffset_TimeLength;
}
