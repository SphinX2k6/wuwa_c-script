using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001A74 RID: 6772
[UClass("/Game/Aki/TypeScript/Game/Module/DeadEyeMode/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyTriggerDeadEyeMode.AnimNotifyTriggerDeadEyeMode_C")]
public class AnimNotifyTriggerDeadEyeMode : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600C76B RID: 51051 RVA: 0x002D68F0 File Offset: 0x002D4AF0
	[NullableContext(1)]
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

	// Token: 0x0600C76C RID: 51052 RVA: 0x002D6990 File Offset: 0x002D4B90
	[NullableContext(1)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!meshComp.IsVisible())
		{
			return false;
		}
		TsBaseVehicle tsBaseVehicle = meshComp.GetOwner() as TsBaseVehicle;
		if (tsBaseVehicle != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnDeadEyeModeTrigger, tsBaseVehicle.EntityId);
		}
		return true;
	}

	// Token: 0x0600C76D RID: 51053 RVA: 0x002D69CD File Offset: 0x002D4BCD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyTriggerDeadEyeMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyTriggerDeadEyeMode.AnimNotifyTriggerDeadEyeMode_C");
		}
		return AnimNotifyTriggerDeadEyeMode._ClassPtr;
	}

	// Token: 0x0600C76E RID: 51054 RVA: 0x002D69F4 File Offset: 0x002D4BF4
	public AnimNotifyTriggerDeadEyeMode() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyTriggerDeadEyeMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600C76F RID: 51055 RVA: 0x002D6A1C File Offset: 0x002D4C1C
	[NullableContext(1)]
	public AnimNotifyTriggerDeadEyeMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyTriggerDeadEyeMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600C770 RID: 51056 RVA: 0x002D6A4F File Offset: 0x002D4C4F
	protected AnimNotifyTriggerDeadEyeMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600C771 RID: 51057 RVA: 0x002D6A58 File Offset: 0x002D4C58
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04005BFC RID: 23548
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyTriggerDeadEyeMode.AnimNotifyTriggerDeadEyeMode_C";

	// Token: 0x04005BFD RID: 23549
	private static IntPtr _ClassPtr;

	// Token: 0x04005BFE RID: 23550
	private static IntPtr _ClassDefaultObjectPtr;
}
