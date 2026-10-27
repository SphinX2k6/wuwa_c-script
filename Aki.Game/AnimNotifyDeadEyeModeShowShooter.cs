using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02001A73 RID: 6771
[UClass("/Game/Aki/TypeScript/Game/Module/DeadEyeMode/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyDeadEyeModeShowShooter.AnimNotifyDeadEyeModeShowShooter_C")]
public class AnimNotifyDeadEyeModeShowShooter : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600C764 RID: 51044 RVA: 0x002D6754 File Offset: 0x002D4954
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

	// Token: 0x0600C765 RID: 51045 RVA: 0x002D67F4 File Offset: 0x002D49F4
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

	// Token: 0x0600C766 RID: 51046 RVA: 0x002D6831 File Offset: 0x002D4A31
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyDeadEyeModeShowShooter._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyDeadEyeModeShowShooter.AnimNotifyDeadEyeModeShowShooter_C");
		}
		return AnimNotifyDeadEyeModeShowShooter._ClassPtr;
	}

	// Token: 0x0600C767 RID: 51047 RVA: 0x002D6858 File Offset: 0x002D4A58
	public AnimNotifyDeadEyeModeShowShooter() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDeadEyeModeShowShooter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600C768 RID: 51048 RVA: 0x002D6880 File Offset: 0x002D4A80
	[NullableContext(1)]
	public AnimNotifyDeadEyeModeShowShooter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDeadEyeModeShowShooter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600C769 RID: 51049 RVA: 0x002D68B3 File Offset: 0x002D4AB3
	protected AnimNotifyDeadEyeModeShowShooter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600C76A RID: 51050 RVA: 0x002D68BC File Offset: 0x002D4ABC
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04005BF9 RID: 23545
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/DeadEyeMode/AnimNotifyDeadEyeModeShowShooter.AnimNotifyDeadEyeModeShowShooter_C";

	// Token: 0x04005BFA RID: 23546
	private static IntPtr _ClassPtr;

	// Token: 0x04005BFB RID: 23547
	private static IntPtr _ClassDefaultObjectPtr;
}
