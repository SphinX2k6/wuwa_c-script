using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000188 RID: 392
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWalkOnWater.TsAnimNotifyStateWalkOnWater_C")]
public class TsAnimNotifyStateWalkOnWater : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x060018EE RID: 6382 RVA: 0x0008464F File Offset: 0x0008284F
	// (set) Token: 0x060018EF RID: 6383 RVA: 0x00084663 File Offset: 0x00082863
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

	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00084678 File Offset: 0x00082878
	// (set) Token: 0x060018F1 RID: 6385 RVA: 0x00084688 File Offset: 0x00082888
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

	// Token: 0x060018F2 RID: 6386 RVA: 0x0008469C File Offset: 0x0008289C
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

	// Token: 0x060018F3 RID: 6387 RVA: 0x00084744 File Offset: 0x00082944
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

	// Token: 0x060018F4 RID: 6388 RVA: 0x000847A4 File Offset: 0x000829A4
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

	// Token: 0x060018F5 RID: 6389 RVA: 0x00084844 File Offset: 0x00082A44
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

	// Token: 0x060018F6 RID: 6390 RVA: 0x000848A0 File Offset: 0x00082AA0
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

	// Token: 0x060018F7 RID: 6391 RVA: 0x0008491B File Offset: 0x00082B1B
	protected override string GetNotifyName_Implementation()
	{
		return "水上行走";
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x00084922 File Offset: 0x00082B22
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWalkOnWater._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWalkOnWater.TsAnimNotifyStateWalkOnWater_C");
		}
		return TsAnimNotifyStateWalkOnWater._ClassPtr;
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x00084948 File Offset: 0x00082B48
	public TsAnimNotifyStateWalkOnWater() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWalkOnWater.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x00084970 File Offset: 0x00082B70
	public TsAnimNotifyStateWalkOnWater(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWalkOnWater.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x000849A3 File Offset: 0x00082BA3
	protected TsAnimNotifyStateWalkOnWater(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x000849AC File Offset: 0x00082BAC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x000849E8 File Offset: 0x00082BE8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x00084A1B File Offset: 0x00082C1B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001088 RID: 4232
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWalkOnWater.TsAnimNotifyStateWalkOnWater_C";

	// Token: 0x04001089 RID: 4233
	private static IntPtr _ClassPtr;

	// Token: 0x0400108A RID: 4234
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400108B RID: 4235
	private static int __PropertyOffset_Key;

	// Token: 0x0400108C RID: 4236
	private static int __PropertyOffset_FixLocation;
}
