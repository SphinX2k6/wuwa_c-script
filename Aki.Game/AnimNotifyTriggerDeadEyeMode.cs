using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000F33 RID: 3891
[UClass("/Game/Aki/TypeScript/Game/Module/DeadEyeMode/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyTriggerDeadEyeMode.AnimNotifyTriggerDeadEyeMode_C")]
public class AnimNotifyTriggerDeadEyeMode : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x06009B7B RID: 39803 RVA: 0x002E19F8 File Offset: 0x002DFBF8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyTriggerDeadEyeMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), AnimNotifyTriggerDeadEyeMode.StaticClass(), out intPtr, out num))
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

	// Token: 0x06009B7C RID: 39804 RVA: 0x002E1AB0 File Offset: 0x002DFCB0
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

	// Token: 0x06009B7D RID: 39805 RVA: 0x002E1AED File Offset: 0x002DFCED
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyTriggerDeadEyeMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyTriggerDeadEyeMode.AnimNotifyTriggerDeadEyeMode_C");
		}
		return AnimNotifyTriggerDeadEyeMode._ClassPtr;
	}

	// Token: 0x06009B7E RID: 39806 RVA: 0x002E1B14 File Offset: 0x002DFD14
	public AnimNotifyTriggerDeadEyeMode() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyTriggerDeadEyeMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06009B7F RID: 39807 RVA: 0x002E1B3C File Offset: 0x002DFD3C
	[NullableContext(1)]
	public AnimNotifyTriggerDeadEyeMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyTriggerDeadEyeMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06009B80 RID: 39808 RVA: 0x002E1B6F File Offset: 0x002DFD6F
	protected AnimNotifyTriggerDeadEyeMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06009B81 RID: 39809 RVA: 0x002E1B78 File Offset: 0x002DFD78
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04005CCB RID: 23755
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyTriggerDeadEyeMode.AnimNotifyTriggerDeadEyeMode_C";

	// Token: 0x04005CCC RID: 23756
	private static IntPtr _ClassPtr;

	// Token: 0x04005CCD RID: 23757
	private static IntPtr _ClassDefaultObjectPtr;
}
