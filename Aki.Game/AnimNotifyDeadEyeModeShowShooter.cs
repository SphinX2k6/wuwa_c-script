using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000F32 RID: 3890
[UClass("/Game/Aki/TypeScript/Game/Module/DeadEyeMode/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyDeadEyeModeShowShooter.AnimNotifyDeadEyeModeShowShooter_C")]
public class AnimNotifyDeadEyeModeShowShooter : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x06009B74 RID: 39796 RVA: 0x002E1844 File Offset: 0x002DFA44
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyDeadEyeModeShowShooter) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), AnimNotifyDeadEyeModeShowShooter.StaticClass(), out intPtr, out num))
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

	// Token: 0x06009B75 RID: 39797 RVA: 0x002E18FC File Offset: 0x002DFAFC
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
			EventSystem.Instance.Emit<int>(EEventName.OnDeadEyeModeShowShooter, tsBaseVehicle.EntityId);
		}
		return true;
	}

	// Token: 0x06009B76 RID: 39798 RVA: 0x002E1939 File Offset: 0x002DFB39
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyDeadEyeModeShowShooter._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyDeadEyeModeShowShooter.AnimNotifyDeadEyeModeShowShooter_C");
		}
		return AnimNotifyDeadEyeModeShowShooter._ClassPtr;
	}

	// Token: 0x06009B77 RID: 39799 RVA: 0x002E1960 File Offset: 0x002DFB60
	public AnimNotifyDeadEyeModeShowShooter() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDeadEyeModeShowShooter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06009B78 RID: 39800 RVA: 0x002E1988 File Offset: 0x002DFB88
	[NullableContext(1)]
	public AnimNotifyDeadEyeModeShowShooter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDeadEyeModeShowShooter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06009B79 RID: 39801 RVA: 0x002E19BB File Offset: 0x002DFBBB
	protected AnimNotifyDeadEyeModeShowShooter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06009B7A RID: 39802 RVA: 0x002E19C4 File Offset: 0x002DFBC4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04005CC8 RID: 23752
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyDeadEyeModeShowShooter.AnimNotifyDeadEyeModeShowShooter_C";

	// Token: 0x04005CC9 RID: 23753
	private static IntPtr _ClassPtr;

	// Token: 0x04005CCA RID: 23754
	private static IntPtr _ClassDefaultObjectPtr;
}
