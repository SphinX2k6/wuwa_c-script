using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000077 RID: 119
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcBoardVehicle.TsTaskNpcBoardVehicle_C")]
public class TsTaskNpcBoardVehicle : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x0600057E RID: 1406 RVA: 0x0001A3A5 File Offset: 0x000185A5
	// (set) Token: 0x0600057F RID: 1407 RVA: 0x0001A3B5 File Offset: 0x000185B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MaxExecuteTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcBoardVehicle.__PropertyOffset_MaxExecuteTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcBoardVehicle.__PropertyOffset_MaxExecuteTime) = value;
		}
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0001A3C6 File Offset: 0x000185C6
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMaxExecuteTime = this.MaxExecuteTime;
		}
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0001A3EC File Offset: 0x000185EC
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

	// Token: 0x06000582 RID: 1410 RVA: 0x0001A488 File Offset: 0x00018688
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
			string message2 = "[TsTaskNpcBoardVehicle] 失败:NPC未绑定任何载具";
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
			string message3 = "[TsTaskNpcBoardVehicle] 失败:载具实体失效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", ridingVehicle);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.FinishExecute(false);
			return;
		}
		this.IsBoarding = false;
		this.ExecuteTimeStamp = Time.Instance.WorldTime;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0001A624 File Offset: 0x00018824
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

	// Token: 0x06000584 RID: 1412 RVA: 0x0001A6C4 File Offset: 0x000188C4
	[NullableContext(2)]
	protected unsafe virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!(ownerController is TsAiController))
		{
			base.Finish(false);
			return;
		}
		AiController aiController = ((TsAiController)ownerController).AiController;
		if (((aiController != null) ? aiController.CharActorComp : null) == null)
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
			string message = "[TsTaskNpcBoardVehicle] 失败:NPC实体失效";
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
			string message2 = "[TsTaskNpcBoardVehicle] 失败:载具实体失效";
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
			string message3 = "[TsTaskNpcBoardVehicle] 失败:上车超时";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			base.Finish(false);
			return;
		}
		if (this.IsBoarding)
		{
			return;
		}
		string enterVehicleMontageByCachedDirection = NpcVehicleRiderController.Instance.GetEnterVehicleMontageByCachedDirection(this.NpcEntityId);
		int? rideSeat = NpcVehicleRiderController.Instance.GetRideSeat(this.NpcEntityId);
		if (rideSeat == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Vehicle;
			ELogAuthor author4 = ELogAuthor.ZJL;
			string message4 = "[TsTaskNpcBoardVehicle] 失败:没有找到合适座位";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			base.Finish(false);
			return;
		}
		this.IsBoarding = true;
		NpcVehicleRiderController.Instance.BoardVehicle(this.NpcEntityId, this.VehicleEntityId, enterVehicleMontageByCachedDirection, rideSeat.Value, delegate(bool success, UAnimMontage montage)
		{
			if (!success)
			{
				base.Finish(false);
				return;
			}
			if (!NpcVehicleRiderController.Instance.SetNpcVehicleRideState(this.NpcEntityId, ENpcVehicleRideState.OnVehicleWaiting))
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.Vehicle;
				ELogAuthor author5 = ELogAuthor.ZJL;
				string message5 = "[TsTaskNpcBoardVehicle] 失败:设置已上车待命状态失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
				instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
				base.Finish(false);
				return;
			}
			base.Finish(true);
		});
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0001A979 File Offset: 0x00018B79
	protected override void OnClear()
	{
		this.IsBoarding = false;
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0001A982 File Offset: 0x00018B82
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcBoardVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcBoardVehicle.TsTaskNpcBoardVehicle_C");
		}
		return TsTaskNpcBoardVehicle._ClassPtr;
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0001A9A8 File Offset: 0x00018BA8
	public TsTaskNpcBoardVehicle() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcBoardVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0001A9D0 File Offset: 0x00018BD0
	[NullableContext(1)]
	public TsTaskNpcBoardVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcBoardVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0001AA03 File Offset: 0x00018C03
	protected TsTaskNpcBoardVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0001AA0C File Offset: 0x00018C0C
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x0001AA3C File Offset: 0x00018C3C
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040003F1 RID: 1009
	private bool IsInitTsVariables;

	// Token: 0x040003F2 RID: 1010
	private int TsMaxExecuteTime;

	// Token: 0x040003F3 RID: 1011
	private int NpcEntityId;

	// Token: 0x040003F4 RID: 1012
	private int VehicleEntityId;

	// Token: 0x040003F5 RID: 1013
	private bool IsBoarding;

	// Token: 0x040003F6 RID: 1014
	private double ExecuteTimeStamp;

	// Token: 0x040003F7 RID: 1015
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcBoardVehicle.TsTaskNpcBoardVehicle_C";

	// Token: 0x040003F8 RID: 1016
	private static IntPtr _ClassPtr;

	// Token: 0x040003F9 RID: 1017
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003FA RID: 1018
	private static int __PropertyOffset_MaxExecuteTime;
}
