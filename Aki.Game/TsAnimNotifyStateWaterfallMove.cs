using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000189 RID: 393
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWaterfallMove.TsAnimNotifyStateWaterfallMove_C")]
public class TsAnimNotifyStateWaterfallMove : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x060018FF RID: 6399 RVA: 0x00084A30 File Offset: 0x00082C30
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

	// Token: 0x06001900 RID: 6400 RVA: 0x00084AD8 File Offset: 0x00082CD8
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

	// Token: 0x06001901 RID: 6401 RVA: 0x00084D30 File Offset: 0x00082F30
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

	// Token: 0x06001902 RID: 6402 RVA: 0x00084DD0 File Offset: 0x00082FD0
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

	// Token: 0x06001903 RID: 6403 RVA: 0x00084E34 File Offset: 0x00083034
	[NullableContext(1)]
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

	// Token: 0x06001904 RID: 6404 RVA: 0x00084EAF File Offset: 0x000830AF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "贡多拉攀瀑";
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x00084EB6 File Offset: 0x000830B6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateWaterfallMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWaterfallMove.TsAnimNotifyStateWaterfallMove_C");
		}
		return TsAnimNotifyStateWaterfallMove._ClassPtr;
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x00084EDC File Offset: 0x000830DC
	public TsAnimNotifyStateWaterfallMove() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWaterfallMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001907 RID: 6407 RVA: 0x00084F04 File Offset: 0x00083104
	[NullableContext(1)]
	public TsAnimNotifyStateWaterfallMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateWaterfallMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001908 RID: 6408 RVA: 0x00084F37 File Offset: 0x00083137
	protected TsAnimNotifyStateWaterfallMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001909 RID: 6409 RVA: 0x00084F40 File Offset: 0x00083140
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600190A RID: 6410 RVA: 0x00084F7C File Offset: 0x0008317C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600190B RID: 6411 RVA: 0x00084FAF File Offset: 0x000831AF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400108D RID: 4237
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateWaterfallMove.TsAnimNotifyStateWaterfallMove_C";

	// Token: 0x0400108E RID: 4238
	private static IntPtr _ClassPtr;

	// Token: 0x0400108F RID: 4239
	private static IntPtr _ClassDefaultObjectPtr;
}
