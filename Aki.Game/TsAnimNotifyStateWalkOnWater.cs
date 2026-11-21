using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018C RID: 396
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWalkOnWater.TsAnimNotifyStateWalkOnWater_C")]
public class TsAnimNotifyStateWalkOnWater : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x0600198B RID: 6539 RVA: 0x0008A83F File Offset: 0x00088A3F
	// (set) Token: 0x0600198C RID: 6540 RVA: 0x0008A853 File Offset: 0x00088A53
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Key
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateWalkOnWater.__PropertyOffset_Key)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsAnimNotifyStateWalkOnWater.__PropertyOffset_Key)), value);
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x0600198D RID: 6541 RVA: 0x0008A868 File Offset: 0x00088A68
	// (set) Token: 0x0600198E RID: 6542 RVA: 0x0008A878 File Offset: 0x00088A78
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool FixLocation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateWalkOnWater.__PropertyOffset_FixLocation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateWalkOnWater.__PropertyOffset_FixLocation) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600198F RID: 6543 RVA: 0x0008A88C File Offset: 0x00088A8C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWalkOnWater) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateWalkOnWater.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001990 RID: 6544 RVA: 0x0008A94C File Offset: 0x00088B4C
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
			object obj;
			if (tsBaseCharacter == null)
			{
				obj = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				obj = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			object obj2 = obj;
			CharacterWalkOnWaterComponent characterWalkOnWaterComponent = (obj2 != null) ? obj2.GetComponent<CharacterWalkOnWaterComponent>() : null;
			if (characterWalkOnWaterComponent != null)
			{
				characterWalkOnWaterComponent.EnableOrDisableWalkOnWater(true, this.Key, this.FixLocation);
			}
		}
		return true;
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x0008A9AC File Offset: 0x00088BAC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWalkOnWater) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateWalkOnWater.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001992 RID: 6546 RVA: 0x0008AA64 File Offset: 0x00088C64
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner is TsBaseCharacter)
		{
			TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
			object obj;
			if (tsBaseCharacter == null)
			{
				obj = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
				obj = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			object obj2 = obj;
			CharacterWalkOnWaterComponent characterWalkOnWaterComponent = (obj2 != null) ? obj2.GetComponent<CharacterWalkOnWaterComponent>() : null;
			if (characterWalkOnWaterComponent != null)
			{
				characterWalkOnWaterComponent.EnableOrDisableWalkOnWater(false, this.Key, false);
			}
		}
		return true;
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x0008AAC0 File Offset: 0x00088CC0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWalkOnWater) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateWalkOnWater.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001994 RID: 6548 RVA: 0x0008AB50 File Offset: 0x00088D50
	protected override string GetNotifyName_Implementation()
	{
		return "水上行走";
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x0008AB57 File Offset: 0x00088D57
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWalkOnWater._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWalkOnWater.TsAnimNotifyStateWalkOnWater_C");
		}
		return TsAnimNotifyStateWalkOnWater._ClassPtr;
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x0008AB7C File Offset: 0x00088D7C
	public TsAnimNotifyStateWalkOnWater() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWalkOnWater.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x0008ABA4 File Offset: 0x00088DA4
	public TsAnimNotifyStateWalkOnWater(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWalkOnWater.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x0008ABD7 File Offset: 0x00088DD7
	protected TsAnimNotifyStateWalkOnWater(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x0008ABE0 File Offset: 0x00088DE0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x0008AC1C File Offset: 0x00088E1C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x0008AC4F File Offset: 0x00088E4F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010CB RID: 4299
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWalkOnWater.TsAnimNotifyStateWalkOnWater_C";

	// Token: 0x040010CC RID: 4300
	private static IntPtr _ClassPtr;

	// Token: 0x040010CD RID: 4301
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010CE RID: 4302
	private static int __PropertyOffset_Key;

	// Token: 0x040010CF RID: 4303
	private static int __PropertyOffset_FixLocation;
}
