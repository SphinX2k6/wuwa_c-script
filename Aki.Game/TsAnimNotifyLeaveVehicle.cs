using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C7 RID: 455
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyLeaveVehicle.TsAnimNotifyLeaveVehicle_C")]
public class TsAnimNotifyLeaveVehicle : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x00096F37 File Offset: 0x00095137
	// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x00096F47 File Offset: 0x00095147
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ExitType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyLeaveVehicle.__PropertyOffset_ExitType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyLeaveVehicle.__PropertyOffset_ExitType) = value;
		}
	}

	// Token: 0x06001CD6 RID: 7382 RVA: 0x00096F58 File Offset: 0x00095158
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyLeaveVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyLeaveVehicle.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001CD7 RID: 7383 RVA: 0x00097010 File Offset: 0x00095210
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseVehicle))
		{
			return true;
		}
		Entity entityNoBlueprint = (owner as TsBaseVehicle).GetEntityNoBlueprint();
		BaseVehiclePerformComponent baseVehiclePerformComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<BaseVehiclePerformComponent>() : null;
		if (((baseVehiclePerformComponent != null) ? baseVehiclePerformComponent.Driver : null) != null)
		{
			BaseActorComponent component = baseVehiclePerformComponent.Driver.GetComponent<BaseActorComponent>();
			bool flag = component != null && component.IsMoveAutonomousProxy;
			baseVehiclePerformComponent.TryLeaveAtOnce(baseVehiclePerformComponent.Driver, (this.ExitType != 0) ? ELeaveVehicleType.StandUp : ELeaveVehicleType.Launch, "TsAnimNotifyLeaveVehicle", !flag);
		}
		return true;
	}

	// Token: 0x06001CD8 RID: 7384 RVA: 0x00097090 File Offset: 0x00095290
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyLeaveVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyLeaveVehicle.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001CD9 RID: 7385 RVA: 0x00097120 File Offset: 0x00095320
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "退出乘坐状态";
	}

	// Token: 0x06001CDA RID: 7386 RVA: 0x00097127 File Offset: 0x00095327
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyLeaveVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyLeaveVehicle.TsAnimNotifyLeaveVehicle_C");
		}
		return TsAnimNotifyLeaveVehicle._ClassPtr;
	}

	// Token: 0x06001CDB RID: 7387 RVA: 0x0009714C File Offset: 0x0009534C
	public TsAnimNotifyLeaveVehicle() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyLeaveVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CDC RID: 7388 RVA: 0x00097174 File Offset: 0x00095374
	[NullableContext(1)]
	public TsAnimNotifyLeaveVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyLeaveVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CDD RID: 7389 RVA: 0x000971A7 File Offset: 0x000953A7
	protected TsAnimNotifyLeaveVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CDE RID: 7390 RVA: 0x000971B0 File Offset: 0x000953B0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CDF RID: 7391 RVA: 0x000971E3 File Offset: 0x000953E3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001216 RID: 4630
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyLeaveVehicle.TsAnimNotifyLeaveVehicle_C";

	// Token: 0x04001217 RID: 4631
	private static IntPtr _ClassPtr;

	// Token: 0x04001218 RID: 4632
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001219 RID: 4633
	private static int __PropertyOffset_ExitType;
}
