using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018D RID: 397
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWaterfallMove.TsAnimNotifyStateWaterfallMove_C")]
public class TsAnimNotifyStateWaterfallMove : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600199C RID: 6556 RVA: 0x0008AC64 File Offset: 0x00088E64
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWaterfallMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateWaterfallMove.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600199D RID: 6557 RVA: 0x0008AD24 File Offset: 0x00088F24
	[NullableContext(2)]
	protected unsafe virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (!(owner is TsBaseVehicle))
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = (owner as TsBaseVehicle).VehicleActorComponent;
		Entity entity = (vehicleActorComponent != null) ? vehicleActorComponent.Entity : null;
		GongduolaPerformComponent performComp = (entity != null) ? entity.GetComponent<GongduolaPerformComponent>() : null;
		GongduolaPerformComponent performComp4 = performComp;
		if (performComp4 == null || !performComp4.IsWaterfallMove)
		{
			return false;
		}
		VehicleTagComponent vehicleTagComponent = (entity != null) ? entity.GetComponent<VehicleTagComponent>() : null;
		if (vehicleTagComponent != null)
		{
			vehicleTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.贡多拉.攀瀑.攀瀑一阶段"]));
		}
		if (vehicleTagComponent != null)
		{
			vehicleTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.贡多拉.攀瀑.攀瀑二阶段"]));
		}
		VehicleAnimationComponent vehicleAnimationComponent = (entity != null) ? entity.GetComponent<VehicleAnimationComponent>() : null;
		if (vehicleAnimationComponent != null)
		{
			vehicleAnimationComponent.ConsumeRootMotion();
		}
		performComp.WaterfallHideVehicleAndPassenger(true, "贡多拉攀瀑入水");
		Rotator rotator = Rotator.Create();
		performComp.WaterfallDirect.Rotation(rotator);
		if (!performComp.IsWaterfallDynamicGravity)
		{
			((entity != null) ? entity.GetComponent<VehicleActorComponent>() : null).SetActorRotation(rotator.ToUeRotator(), "攀瀑进入二阶段设置旋转", false);
		}
		((entity != null) ? entity.GetComponent<VehicleMoveComponent>() : null).MoveAlongPath(new IMoveVehicleConfig
		{
			SplineId = performComp.WaterfallSplineId,
			SimulateRotation = new bool?(false),
			NeedSync = new bool?(false),
			DynamicGravity = new bool?(performComp.IsWaterfallDynamicGravity),
			OnMoveEndHandle = delegate(bool result)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Vehicle;
				ELogAuthor author2 = ELogAuthor.YJX;
				string message2 = "贡多拉攀瀑样条移动结束";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
				string item2 = "PbDataId";
				VehicleActorComponent vehicleActorComponent3 = (owner as TsBaseVehicle).VehicleActorComponent;
				ptr2 = new ValueTuple<string, object>(item2, (vehicleActorComponent3 != null) ? new int?(vehicleActorComponent3.CreatureData.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SplineId", performComp.WaterfallSplineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Result", result);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				if (!result)
				{
					GongduolaPerformComponent performComp2 = performComp;
					if (performComp2 == null)
					{
						return;
					}
					performComp2.ForceEndWaterfallMove();
					return;
				}
				else
				{
					GongduolaPerformComponent performComp3 = performComp;
					if (performComp3 == null)
					{
						return;
					}
					performComp3.OnWaterfallMoveBeginEnd();
					return;
				}
			}
		});
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Vehicle;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "贡多拉攀瀑进入二阶段";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
		string item = "PbDataId";
		VehicleActorComponent vehicleActorComponent2 = (owner as TsBaseVehicle).VehicleActorComponent;
		ptr = new ValueTuple<string, object>(item, (vehicleActorComponent2 != null) ? new int?(vehicleActorComponent2.CreatureData.GetPbDataId()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", performComp.WaterfallSplineId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Passengers", performComp.PassengerInfoMap);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		return true;
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x0008AF7C File Offset: 0x0008917C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWaterfallMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateWaterfallMove.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600199F RID: 6559 RVA: 0x0008B034 File Offset: 0x00089234
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (!(owner is TsBaseVehicle))
		{
			return false;
		}
		VehicleActorComponent vehicleActorComponent = (owner as TsBaseVehicle).VehicleActorComponent;
		Entity entity = (vehicleActorComponent != null) ? vehicleActorComponent.Entity : null;
		GongduolaPerformComponent gongduolaPerformComponent = (entity != null) ? entity.GetComponent<GongduolaPerformComponent>() : null;
		if (gongduolaPerformComponent == null || !gongduolaPerformComponent.IsWaterfallMove)
		{
			return false;
		}
		gongduolaPerformComponent.EndWaterfallMove();
		return true;
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x0008B098 File Offset: 0x00089298
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateWaterfallMove) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateWaterfallMove.StaticClass(), out intPtr, out num))
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

	// Token: 0x060019A1 RID: 6561 RVA: 0x0008B128 File Offset: 0x00089328
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "贡多拉攀瀑";
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x0008B12F File Offset: 0x0008932F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWaterfallMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWaterfallMove.TsAnimNotifyStateWaterfallMove_C");
		}
		return TsAnimNotifyStateWaterfallMove._ClassPtr;
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x0008B154 File Offset: 0x00089354
	public TsAnimNotifyStateWaterfallMove() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWaterfallMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x0008B17C File Offset: 0x0008937C
	[NullableContext(1)]
	public TsAnimNotifyStateWaterfallMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWaterfallMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x0008B1AF File Offset: 0x000893AF
	protected TsAnimNotifyStateWaterfallMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x0008B1B8 File Offset: 0x000893B8
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x0008B1F4 File Offset: 0x000893F4
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x0008B227 File Offset: 0x00089427
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010D0 RID: 4304
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWaterfallMove.TsAnimNotifyStateWaterfallMove_C";

	// Token: 0x040010D1 RID: 4305
	private static IntPtr _ClassPtr;

	// Token: 0x040010D2 RID: 4306
	private static IntPtr _ClassDefaultObjectPtr;
}
