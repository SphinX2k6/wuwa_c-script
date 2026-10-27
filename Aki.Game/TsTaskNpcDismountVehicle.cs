using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000078 RID: 120
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcDismountVehicle.TsTaskNpcDismountVehicle_C")]
public class TsTaskNpcDismountVehicle : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001AB17 File Offset: 0x00018D17
	// (set) Token: 0x0600058E RID: 1422 RVA: 0x0001AB27 File Offset: 0x00018D27
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MaxExecuteTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcDismountVehicle.__PropertyOffset_MaxExecuteTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcDismountVehicle.__PropertyOffset_MaxExecuteTime) = value;
		}
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x0001AB38 File Offset: 0x00018D38
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMaxExecuteTime = this.MaxExecuteTime;
		}
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x0001AB5C File Offset: 0x00018D5C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x0001ABF8 File Offset: 0x00018DF8
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
		{
			base.FinishExecute(false);
			return;
		}
		AiController aiController = ((TsAiController)ownerController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			base.FinishExecute(false);
			return;
		}
		this.NpcEntityId = charActorComp.Entity.Id;
		int? ridingVehicle = NpcVehicleRiderController.Instance.GetRidingVehicle(this.NpcEntityId);
		if (ridingVehicle == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[TsTaskNpcDismountVehicle] 失败:NPC未绑定任何载具";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(false);
			return;
		}
		this.VehicleEntityId = ridingVehicle.Value;
		Entity entity = EntitySystem.Instance.Get(ridingVehicle.Value);
		if (entity == null || !entity.Active)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Vehicle;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "[TsTaskNpcDismountVehicle] 失败:载具实体失效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", ridingVehicle);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.FinishExecute(false);
			return;
		}
		this.IsDismounting = false;
		this.ExecuteTimeStamp = Time.Instance.WorldTime;
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0001AD94 File Offset: 0x00018F94
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0001AE34 File Offset: 0x00019034
	[NullableContext(2)]
	protected unsafe virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!(ownerController is TsAiController))
		{
			base.Finish(false);
			return;
		}
		Entity entity = EntitySystem.Instance.Get(this.NpcEntityId);
		if (entity == null || !entity.Active)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[TsTaskNpcDismountVehicle] 失败:NPC实体失效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			NpcVehicleRiderController.Instance.ReleaseVehicle(this.NpcEntityId);
			base.Finish(false);
			return;
		}
		Entity entity2 = EntitySystem.Instance.Get(this.VehicleEntityId);
		if (entity2 == null || !entity2.Active)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[TsTaskNpcDismountVehicle] 失败:载具实体失效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			NpcVehicleRiderController.Instance.NotifyRideEntityInvalid(this.VehicleEntityId);
			base.Finish(false);
			return;
		}
		if (Time.Instance.WorldTime > this.ExecuteTimeStamp + (double)this.TsMaxExecuteTime)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Vehicle;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "[TsTaskNpcDismountVehicle] 失败:下车超时";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			base.Finish(false);
			return;
		}
		if (this.IsDismounting)
		{
			return;
		}
		LeaveVehicleDirectionAndMontage randomLeaveVehicleDirectionAndMontage = NpcVehicleRiderController.Instance.GetRandomLeaveVehicleDirectionAndMontage(this.NpcEntityId);
		string montagePath = ((randomLeaveVehicleDirectionAndMontage != null) ? randomLeaveVehicleDirectionAndMontage.Montage : null) ?? "";
		CommonNpcPerformComponent.EEnterVehicleDirection direction = (randomLeaveVehicleDirectionAndMontage != null) ? randomLeaveVehicleDirectionAndMontage.Direction : CommonNpcPerformComponent.EEnterVehicleDirection.Left;
		this.IsDismounting = true;
		NpcVehicleRiderController.Instance.DismountVehicle(this.NpcEntityId, this.VehicleEntityId, montagePath, direction, delegate(bool success, UAnimMontage montage)
		{
			if (!success)
			{
				base.Finish(false);
				return;
			}
			if (!NpcVehicleRiderController.Instance.ReleaseVehicle(this.NpcEntityId))
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Vehicle;
				ELogAuthor author4 = ELogAuthor.ZJL;
				string message4 = "[TsTaskNpcDismountVehicle] 失败:解绑NPC与载具失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				base.Finish(false);
				return;
			}
			base.Finish(true);
		});
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0001B059 File Offset: 0x00019259
	protected override void OnClear()
	{
		this.IsDismounting = false;
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0001B062 File Offset: 0x00019262
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcDismountVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcDismountVehicle.TsTaskNpcDismountVehicle_C");
		}
		return TsTaskNpcDismountVehicle._ClassPtr;
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0001B088 File Offset: 0x00019288
	public TsTaskNpcDismountVehicle() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcDismountVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0001B0B0 File Offset: 0x000192B0
	[NullableContext(1)]
	public TsTaskNpcDismountVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcDismountVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0001B0E3 File Offset: 0x000192E3
	protected TsTaskNpcDismountVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0001B0EC File Offset: 0x000192EC
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x0001B11C File Offset: 0x0001931C
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040003FB RID: 1019
	private bool IsInitTsVariables;

	// Token: 0x040003FC RID: 1020
	private int TsMaxExecuteTime;

	// Token: 0x040003FD RID: 1021
	private int NpcEntityId;

	// Token: 0x040003FE RID: 1022
	private int VehicleEntityId;

	// Token: 0x040003FF RID: 1023
	private bool IsDismounting;

	// Token: 0x04000400 RID: 1024
	private double ExecuteTimeStamp;

	// Token: 0x04000401 RID: 1025
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcDismountVehicle.TsTaskNpcDismountVehicle_C";

	// Token: 0x04000402 RID: 1026
	private static IntPtr _ClassPtr;

	// Token: 0x04000403 RID: 1027
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000404 RID: 1028
	private static int __PropertyOffset_MaxExecuteTime;
}
