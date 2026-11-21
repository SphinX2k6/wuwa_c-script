using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200007D RID: 125
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcReserveVehicle.TsTaskNpcReserveVehicle_C")]
public class TsTaskNpcReserveVehicle : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600060B RID: 1547 RVA: 0x0001EBA8 File Offset: 0x0001CDA8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskNpcReserveVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskNpcReserveVehicle.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x0001EC58 File Offset: 0x0001CE58
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		Log.Instance.Info(ELogModule.BehaviorTree, ELogAuthor.ZJL, "尝试绑定", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (!(ownerController is TsAiController))
		{
			base.FinishExecute(false);
			return;
		}
		AiController aiController = ((TsAiController)ownerController).AiController;
		CharacterActorComponent characterActorComponent = (aiController != null) ? aiController.CharActorComp : null;
		if (characterActorComponent == null)
		{
			base.FinishExecute(false);
			return;
		}
		int id = characterActorComponent.Entity.Id;
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(id, "SearchedRideableVehicleEntityId");
		if (intValueByEntity != null)
		{
			int? num = intValueByEntity;
			int num2 = 0;
			if (!(num.GetValueOrDefault() <= num2 & num != null))
			{
				if (!NpcVehicleRiderController.Instance.TryReserveVehicle(id, intValueByEntity.Value))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.BehaviorTree;
					ELogAuthor author = ELogAuthor.ZJL;
					string message = "预占载具失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("npcEntityId", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("vehicleEntityId", intValueByEntity);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					base.FinishExecute(false);
					return;
				}
				if (!NpcVehicleRiderController.Instance.SetNpcVehicleRideState(id, ENpcVehicleRideState.MoveToVehicle))
				{
					NpcVehicleRiderController.Instance.ReleaseVehicle(id);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.BehaviorTree;
					ELogAuthor author2 = ELogAuthor.ZJL;
					string message2 = "置前往状态失败，回滚预占";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("npcEntityId", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("vehicleEntityId", intValueByEntity);
					instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					base.FinishExecute(false);
					return;
				}
				base.FinishExecute(true);
				return;
			}
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.BehaviorTree;
		ELogAuthor author3 = ELogAuthor.ZJL;
		string message3 = "黑板中没有可用载具";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("vehicleEntityId", intValueByEntity);
		instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		base.FinishExecute(false);
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0001EE2C File Offset: 0x0001D02C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcReserveVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcReserveVehicle.TsTaskNpcReserveVehicle_C");
		}
		return TsTaskNpcReserveVehicle._ClassPtr;
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0001EE50 File Offset: 0x0001D050
	public TsTaskNpcReserveVehicle() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcReserveVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0001EE78 File Offset: 0x0001D078
	[NullableContext(1)]
	public TsTaskNpcReserveVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcReserveVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x0001EEAB File Offset: 0x0001D0AB
	protected TsTaskNpcReserveVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000470 RID: 1136
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcReserveVehicle.TsTaskNpcReserveVehicle_C";

	// Token: 0x04000471 RID: 1137
	private static IntPtr _ClassPtr;

	// Token: 0x04000472 RID: 1138
	private static IntPtr _ClassDefaultObjectPtr;
}
