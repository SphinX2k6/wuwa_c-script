using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C3 RID: 451
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyLeaveVehicle.TsAnimNotifyLeaveVehicle_C")]
public class TsAnimNotifyLeaveVehicle : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000484 RID: 1156
	// (get) Token: 0x06001C37 RID: 7223 RVA: 0x000903C7 File Offset: 0x0008E5C7
	// (set) Token: 0x06001C38 RID: 7224 RVA: 0x000903D7 File Offset: 0x0008E5D7
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

	// Token: 0x06001C39 RID: 7225 RVA: 0x000903E8 File Offset: 0x0008E5E8
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

	// Token: 0x06001C3A RID: 7226 RVA: 0x00090488 File Offset: 0x0008E688
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

	// Token: 0x06001C3B RID: 7227 RVA: 0x00090508 File Offset: 0x0008E708
	[NullableContext(1)]
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

	// Token: 0x06001C3C RID: 7228 RVA: 0x00090583 File Offset: 0x0008E783
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "退出乘坐状态";
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x0009058A File Offset: 0x0008E78A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyLeaveVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyLeaveVehicle.TsAnimNotifyLeaveVehicle_C");
		}
		return TsAnimNotifyLeaveVehicle._ClassPtr;
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x000905B0 File Offset: 0x0008E7B0
	public TsAnimNotifyLeaveVehicle() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyLeaveVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x000905D8 File Offset: 0x0008E7D8
	[NullableContext(1)]
	public TsAnimNotifyLeaveVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyLeaveVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C40 RID: 7232 RVA: 0x0009060B File Offset: 0x0008E80B
	protected TsAnimNotifyLeaveVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C41 RID: 7233 RVA: 0x00090614 File Offset: 0x0008E814
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C42 RID: 7234 RVA: 0x00090647 File Offset: 0x0008E847
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011D3 RID: 4563
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyLeaveVehicle.TsAnimNotifyLeaveVehicle_C";

	// Token: 0x040011D4 RID: 4564
	private static IntPtr _ClassPtr;

	// Token: 0x040011D5 RID: 4565
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011D6 RID: 4566
	private static int __PropertyOffset_ExitType;
}
