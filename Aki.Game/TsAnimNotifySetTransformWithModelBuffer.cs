using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001D8 RID: 472
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetTransformWithModelBuffer.TsAnimNotifySetTransformWithModelBuffer_C")]
public class TsAnimNotifySetTransformWithModelBuffer : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B3 RID: 1203
	// (get) Token: 0x06001D63 RID: 7523 RVA: 0x0009440F File Offset: 0x0009260F
	// (set) Token: 0x06001D64 RID: 7524 RVA: 0x00094423 File Offset: 0x00092623
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

	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x06001D65 RID: 7525 RVA: 0x00094438 File Offset: 0x00092638
	// (set) Token: 0x06001D66 RID: 7526 RVA: 0x0009444C File Offset: 0x0009264C
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

	// Token: 0x170004B5 RID: 1205
	// (get) Token: 0x06001D67 RID: 7527 RVA: 0x00094461 File Offset: 0x00092661
	// (set) Token: 0x06001D68 RID: 7528 RVA: 0x00094471 File Offset: 0x00092671
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

	// Token: 0x06001D69 RID: 7529 RVA: 0x00094484 File Offset: 0x00092684
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
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

	// Token: 0x06001D6A RID: 7530 RVA: 0x00094524 File Offset: 0x00092724
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

	// Token: 0x06001D6B RID: 7531 RVA: 0x00094630 File Offset: 0x00092830
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001D6C RID: 7532 RVA: 0x000946AB File Offset: 0x000928AB
	protected override string GetNotifyName_Implementation()
	{
		return "怪物趴墙";
	}

	// Token: 0x06001D6D RID: 7533 RVA: 0x000946B2 File Offset: 0x000928B2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySetTransformWithModelBuffer._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetTransformWithModelBuffer.TsAnimNotifySetTransformWithModelBuffer_C");
		}
		return TsAnimNotifySetTransformWithModelBuffer._ClassPtr;
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x000946D8 File Offset: 0x000928D8
	public TsAnimNotifySetTransformWithModelBuffer() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetTransformWithModelBuffer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D6F RID: 7535 RVA: 0x00094700 File Offset: 0x00092900
	public TsAnimNotifySetTransformWithModelBuffer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySetTransformWithModelBuffer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x00094733 File Offset: 0x00092933
	protected TsAnimNotifySetTransformWithModelBuffer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x0009473C File Offset: 0x0009293C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x0009476F File Offset: 0x0009296F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001247 RID: 4679
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySetTransformWithModelBuffer.TsAnimNotifySetTransformWithModelBuffer_C";

	// Token: 0x04001248 RID: 4680
	private static IntPtr _ClassPtr;

	// Token: 0x04001249 RID: 4681
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400124A RID: 4682
	private static int __PropertyOffset_LocationKey;

	// Token: 0x0400124B RID: 4683
	private static int __PropertyOffset_RotatorKey;

	// Token: 0x0400124C RID: 4684
	private static int __PropertyOffset_TimeLength;
}
