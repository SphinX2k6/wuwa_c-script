using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Vehicle.Common;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E6 RID: 486
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleBounce.TsAnimNotifyVehicleBounce_C")]
public class TsAnimNotifyVehicleBounce : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x06001EAC RID: 7852 RVA: 0x0009DAAF File Offset: 0x0009BCAF
	// (set) Token: 0x06001EAD RID: 7853 RVA: 0x0009DABF File Offset: 0x0009BCBF
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

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x06001EAE RID: 7854 RVA: 0x0009DAD0 File Offset: 0x0009BCD0
	// (set) Token: 0x06001EAF RID: 7855 RVA: 0x0009DAE0 File Offset: 0x0009BCE0
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

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0009DAF1 File Offset: 0x0009BCF1
	// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0009DB01 File Offset: 0x0009BD01
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

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0009DB12 File Offset: 0x0009BD12
	// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0009DB22 File Offset: 0x0009BD22
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

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0009DB34 File Offset: 0x0009BD34
	// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0009DB6D File Offset: 0x0009BD6D
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

	// Token: 0x06001EB6 RID: 7862 RVA: 0x0009DB94 File Offset: 0x0009BD94
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyVehicleBounce) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyVehicleBounce.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001EB7 RID: 7863 RVA: 0x0009DC4C File Offset: 0x0009BE4C
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

	// Token: 0x06001EB8 RID: 7864 RVA: 0x0009DD00 File Offset: 0x0009BF00
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyVehicleBounce) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyVehicleBounce.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001EB9 RID: 7865 RVA: 0x0009DD90 File Offset: 0x0009BF90
	protected override string GetNotifyName_Implementation()
	{
		return "载具弹射运动";
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x0009DD97 File Offset: 0x0009BF97
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyVehicleBounce._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleBounce.TsAnimNotifyVehicleBounce_C");
		}
		return TsAnimNotifyVehicleBounce._ClassPtr;
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x0009DDBC File Offset: 0x0009BFBC
	public TsAnimNotifyVehicleBounce() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleBounce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x0009DDE4 File Offset: 0x0009BFE4
	public TsAnimNotifyVehicleBounce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleBounce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x0009DE17 File Offset: 0x0009C017
	protected TsAnimNotifyVehicleBounce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x0009DE20 File Offset: 0x0009C020
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x0009DE53 File Offset: 0x0009C053
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012D7 RID: 4823
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyVehicleBounce.TsAnimNotifyVehicleBounce_C";

	// Token: 0x040012D8 RID: 4824
	private static IntPtr _ClassPtr;

	// Token: 0x040012D9 RID: 4825
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012DA RID: 4826
	private static int __PropertyOffset_Time;

	// Token: 0x040012DB RID: 4827
	private static int __PropertyOffset_Height;

	// Token: 0x040012DC RID: 4828
	private static int __PropertyOffset_UseLocalUp;

	// Token: 0x040012DD RID: 4829
	private static int __PropertyOffset_NotClearDownVelocity;

	// Token: 0x040012DE RID: 4830
	private static int __PropertyOffset_MotionCurve;

	// Token: 0x040012DF RID: 4831
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UCurveFloat> _MotionCurve;
}
