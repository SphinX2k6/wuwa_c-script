using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Vehicle.Common;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E2 RID: 482
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleBounce.TsAnimNotifyVehicleBounce_C")]
public class TsAnimNotifyVehicleBounce : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x06001E0F RID: 7695 RVA: 0x00096A5B File Offset: 0x00094C5B
	// (set) Token: 0x06001E10 RID: 7696 RVA: 0x00096A6B File Offset: 0x00094C6B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Time
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_Time);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_Time) = value;
		}
	}

	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00096A7C File Offset: 0x00094C7C
	// (set) Token: 0x06001E12 RID: 7698 RVA: 0x00096A8C File Offset: 0x00094C8C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Height
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_Height);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_Height) = value;
		}
	}

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00096A9D File Offset: 0x00094C9D
	// (set) Token: 0x06001E14 RID: 7700 RVA: 0x00096AAD File Offset: 0x00094CAD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseLocalUp
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_UseLocalUp) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_UseLocalUp) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00096ABE File Offset: 0x00094CBE
	// (set) Token: 0x06001E16 RID: 7702 RVA: 0x00096ACE File Offset: 0x00094CCE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NotClearDownVelocity
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_NotClearDownVelocity) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_NotClearDownVelocity) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00096AE0 File Offset: 0x00094CE0
	// (set) Token: 0x06001E18 RID: 7704 RVA: 0x00096B19 File Offset: 0x00094D19
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UCurveFloat> MotionCurve
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UCurveFloat> result;
			if ((result = this._MotionCurve) == null)
			{
				result = (this._MotionCurve = new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_MotionCurve, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyVehicleBounce.__PropertyOffset_MotionCurve, 1);
		}
	}

	// Token: 0x06001E19 RID: 7705 RVA: 0x00096B40 File Offset: 0x00094D40
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

	// Token: 0x06001E1A RID: 7706 RVA: 0x00096BE0 File Offset: 0x00094DE0
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseVehicle))
		{
			return false;
		}
		Entity entityNoBlueprint = (owner as TsBaseVehicle).GetEntityNoBlueprint();
		VehicleActionComponent vehicleActionComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<VehicleActionComponent>() : null;
		if (vehicleActionComponent == null)
		{
			return false;
		}
		VehicleActionComponent vehicleActionComponent2 = vehicleActionComponent;
		BounceParam bounceParam = new BounceParam();
		bounceParam.Time = new float?(this.Time);
		bounceParam.Height = new float?(this.Height);
		TSoftObjectPtr<UCurveFloat> motionCurve = this.MotionCurve;
		bounceParam.CurvePath = (((motionCurve != null) ? motionCurve.ToAssetPathName() : null) ?? "");
		bounceParam.UseLocalUp = new bool?(this.UseLocalUp);
		bounceParam.NotClearDownVelocity = new bool?(this.NotClearDownVelocity);
		vehicleActionComponent2.StartBounce(bounceParam).Forget<bool>();
		return true;
	}

	// Token: 0x06001E1B RID: 7707 RVA: 0x00096C94 File Offset: 0x00094E94
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

	// Token: 0x06001E1C RID: 7708 RVA: 0x00096D0F File Offset: 0x00094F0F
	protected override string GetNotifyName_Implementation()
	{
		return "载具弹射运动";
	}

	// Token: 0x06001E1D RID: 7709 RVA: 0x00096D16 File Offset: 0x00094F16
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyVehicleBounce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleBounce.TsAnimNotifyVehicleBounce_C");
		}
		return TsAnimNotifyVehicleBounce._ClassPtr;
	}

	// Token: 0x06001E1E RID: 7710 RVA: 0x00096D3C File Offset: 0x00094F3C
	public TsAnimNotifyVehicleBounce() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleBounce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E1F RID: 7711 RVA: 0x00096D64 File Offset: 0x00094F64
	public TsAnimNotifyVehicleBounce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleBounce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E20 RID: 7712 RVA: 0x00096D97 File Offset: 0x00094F97
	protected TsAnimNotifyVehicleBounce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E21 RID: 7713 RVA: 0x00096DA0 File Offset: 0x00094FA0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E22 RID: 7714 RVA: 0x00096DD3 File Offset: 0x00094FD3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001294 RID: 4756
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleBounce.TsAnimNotifyVehicleBounce_C";

	// Token: 0x04001295 RID: 4757
	private static IntPtr _ClassPtr;

	// Token: 0x04001296 RID: 4758
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001297 RID: 4759
	private static int __PropertyOffset_Time;

	// Token: 0x04001298 RID: 4760
	private static int __PropertyOffset_Height;

	// Token: 0x04001299 RID: 4761
	private static int __PropertyOffset_UseLocalUp;

	// Token: 0x0400129A RID: 4762
	private static int __PropertyOffset_NotClearDownVelocity;

	// Token: 0x0400129B RID: 4763
	private static int __PropertyOffset_MotionCurve;

	// Token: 0x0400129C RID: 4764
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UCurveFloat> _MotionCurve;
}
