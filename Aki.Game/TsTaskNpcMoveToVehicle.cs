using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200007A RID: 122
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcMoveToVehicle.TsTaskNpcMoveToVehicle_C")]
public class TsTaskNpcMoveToVehicle : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001B805 File Offset: 0x00019A05
	// (set) Token: 0x060005AD RID: 1453 RVA: 0x0001B815 File Offset: 0x00019A15
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcMoveToVehicle.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcMoveToVehicle.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001B826 File Offset: 0x00019A26
	// (set) Token: 0x060005AF RID: 1455 RVA: 0x0001B836 File Offset: 0x00019A36
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EndDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcMoveToVehicle.__PropertyOffset_EndDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcMoveToVehicle.__PropertyOffset_EndDistance) = value;
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001B847 File Offset: 0x00019A47
	// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0001B857 File Offset: 0x00019A57
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableDebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcMoveToVehicle.__PropertyOffset_EnableDebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcMoveToVehicle.__PropertyOffset_EnableDebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0001B868 File Offset: 0x00019A68
	private void OnMoveEnd(ELevelEventState result)
	{
		if (result == ELevelEventState.Success)
		{
			base.Finish(true);
			return;
		}
		this.LogMoveFailed(result);
		base.Finish(false);
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x0001B884 File Offset: 0x00019A84
	private unsafe void LogMoveFailed(ELevelEventState result)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Vehicle;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "[TsTaskNpcMoveToVehicle] 失败:移动到载具上车点失败(路径中断/不可达)";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Result", result);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x0001B918 File Offset: 0x00019B18
	private void DrawDebugWaypoints(Vector start)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(this, start.ToUeVector(false), 40f, 12, new FLinearColor?(TsTaskNpcMoveToVehicle.StartColor), 15f, 3f);
		foreach (Vector vector in this.TargetPath)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(this, vector.ToUeVector(false), 40f, 12, new FLinearColor?(TsTaskNpcMoveToVehicle.WaypointColor), 15f, 3f);
		}
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x0001B9B4 File Offset: 0x00019BB4
	private void DrawDebugEnterBoxes()
	{
		VehicleEnterBoxDebugGeometry debugBoxGeometry = this.DebugBoxGeometry;
		if (!NpcVehicleRiderController.Instance.GetVehicleEnterBoxDebugGeometry(this.NpcEntityId, this.VehicleEntityId, debugBoxGeometry))
		{
			return;
		}
		FVectorDouble center = debugBoxGeometry.Center.ToUeVector(false);
		FRotator rotation = debugBoxGeometry.Rotation.ToUeRotator();
		UKismetSystemLibrary.D_DrawDebugBox(this, center, new FVectorDouble((double)debugBoxGeometry.ObstacleHalfLength, (double)debugBoxGeometry.ObstacleHalfWidth, 100.0), TsTaskNpcMoveToVehicle.ObstacleBoxColor, rotation, 15f, 3f);
		UKismetSystemLibrary.D_DrawDebugBox(this, center, new FVectorDouble((double)debugBoxGeometry.WaypointHalfLength, debugBoxGeometry.WaypointHalfWidth, 100.0), TsTaskNpcMoveToVehicle.WaypointBoxColor, rotation, 15f, 3f);
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x0001BA60 File Offset: 0x00019C60
	private void DrawDebugPath(Vector start)
	{
		if (this.TargetPath.Count == 0)
		{
			return;
		}
		Vector vector = start;
		foreach (Vector vector2 in this.TargetPath)
		{
			UKismetSystemLibrary.D_DrawDebugArrow(this, vector.ToUeVector(false), vector2.ToUeVector(false), 80f, TsTaskNpcMoveToVehicle.PathArrowColor, 15f, 3f);
			vector = vector2;
		}
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x0001BAE8 File Offset: 0x00019CE8
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveState = this.MoveState;
			this.TsEndDistance = this.EndDistance;
			this.TargetPath.Clear();
		}
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x0001BB24 File Offset: 0x00019D24
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

	// Token: 0x060005B9 RID: 1465 RVA: 0x0001BBC0 File Offset: 0x00019DC0
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
		{
			base.Finish(false);
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
			base.Finish(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			base.Finish(false);
			return;
		}
		Entity entity = charActorComp.Entity;
		this.NpcEntityId = entity.Id;
		int? ridingVehicle = NpcVehicleRiderController.Instance.GetRidingVehicle(this.NpcEntityId);
		if (ridingVehicle == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[TsTaskNpcMoveToVehicle] 失败:NPC未绑定任何载具";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.Finish(false);
			return;
		}
		this.VehicleEntityId = ridingVehicle.Value;
		Entity entity2 = EntitySystem.Instance.Get(ridingVehicle.Value);
		if (entity2 == null || !entity2.Active)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Vehicle;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "[TsTaskNpcMoveToVehicle] 失败:载具实体失效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", ridingVehicle);
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			NpcVehicleRiderController.Instance.NotifyRideEntityInvalid(this.VehicleEntityId);
			base.Finish(false);
			return;
		}
		if (!NpcVehicleRiderController.Instance.GetVehicleEnterPath(this.NpcEntityId, ridingVehicle.Value, this.TargetPath))
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Vehicle;
			ELogAuthor author4 = ELogAuthor.ZJL;
			string message4 = "[TsTaskNpcMoveToVehicle] 失败:载具上车点不可达";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("VehicleEntityId", ridingVehicle);
			instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			NpcVehicleRiderController.Instance.ReleaseVehicle(this.NpcEntityId);
			base.Finish(false);
			return;
		}
		this.MoveComp = entity.GetComponent<BaseMoveComponent>();
		if (this.MoveComp == null)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.BehaviorTree;
			ELogAuthor author5 = ELogAuthor.ZJL;
			string message5 = "NPC缺少移动组件";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			NpcVehicleRiderController.Instance.ReleaseVehicle(this.NpcEntityId);
			base.Finish(false);
			return;
		}
		List<MoveCharacterPoint> list = new List<MoveCharacterPoint>();
		for (int i = 0; i < this.TargetPath.Count; i++)
		{
			list.Add(new MoveCharacterPoint
			{
				Index = i,
				Position = this.TargetPath[i],
				MoveState = new EPatrolMoveState?((EPatrolMoveState)this.TsMoveState)
			});
		}
		if (this.EnableDebugDraw)
		{
			BaseActorComponent component = entity.GetComponent<BaseActorComponent>();
			Vector vector = (component != null) ? component.ActorLocationProxy : null;
			if (vector != null)
			{
				this.DrawDebugEnterBoxes();
				this.DrawDebugWaypoints(vector);
				this.DrawDebugPath(vector);
			}
		}
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = list,
			Navigation = true,
			IsFly = false,
			DebugMode = false,
			Loop = false,
			Callback = new Action<ELevelEventState>(this.OnMoveEnd),
			ReturnFalseWhenNavigationFailed = true,
			Distance = new float?(this.TsEndDistance),
			EnablePlayerAccurateMoveToTarget = new bool?(true)
		};
		this.MoveHandleId = this.MoveComp.MoveAlongPath(config, "TsTaskNpcMoveToVehicle.ReceiveExecuteAI");
		Log instance6 = Log.Instance;
		ELogModule module6 = ELogModule.Vehicle;
		ELogAuthor author6 = ELogAuthor.ZJL;
		string message6 = "[TsTaskNpcMoveToVehicle] 开始移动到载具上车点";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("VehicleEntityId", ridingVehicle);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("PathPointCount", list.Count);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("MoveState", this.TsMoveState);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("EndDistance", this.TsEndDistance);
		instance6.Info(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 5));
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0001C02C File Offset: 0x0001A22C
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

	// Token: 0x060005BB RID: 1467 RVA: 0x0001C0CC File Offset: 0x0001A2CC
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
			string message = "[TsTaskNpcMoveToVehicle] 失败:NPC实体失效";
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
			string message2 = "[TsTaskNpcMoveToVehicle] 失败:载具实体失效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcEntityId", this.NpcEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			NpcVehicleRiderController.Instance.NotifyRideEntityInvalid(this.VehicleEntityId);
			base.Finish(false);
		}
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0001C1FC File Offset: 0x0001A3FC
	protected override void OnClear()
	{
		if (this.MoveComp != null)
		{
			this.MoveComp.StopMoveByHandleId(this.MoveHandleId, "TsTaskNpcMoveToVehicle.OnClear");
			this.MoveComp = null;
		}
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0001C224 File Offset: 0x0001A424
	protected override void OnAbort()
	{
		if (this.MoveComp != null)
		{
			this.MoveComp.StopMoveByHandleId(this.MoveHandleId, "TsTaskNpcMoveToVehicle.OnAbort");
			this.MoveComp = null;
		}
		if (NpcVehicleRiderController.Instance.GetRidingVehicle(this.NpcEntityId) != null)
		{
			NpcVehicleRiderController.Instance.ReleaseVehicle(this.NpcEntityId);
		}
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0001C281 File Offset: 0x0001A481
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcMoveToVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcMoveToVehicle.TsTaskNpcMoveToVehicle_C");
		}
		return TsTaskNpcMoveToVehicle._ClassPtr;
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
	public TsTaskNpcMoveToVehicle() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcMoveToVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
	public TsTaskNpcMoveToVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcMoveToVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0001C303 File Offset: 0x0001A503
	protected TsTaskNpcMoveToVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x0001C324 File Offset: 0x0001A524
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x0001C354 File Offset: 0x0001A554
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000412 RID: 1042
	private const float DEBUG_BOX_HALF_HEIGHT = 100f;

	// Token: 0x04000413 RID: 1043
	private const float DEBUG_DRAW_DURATION = 15f;

	// Token: 0x04000414 RID: 1044
	private const float DEBUG_DRAW_THICKNESS = 3f;

	// Token: 0x04000415 RID: 1045
	private const float DEBUG_PATH_ARROW_SIZE = 80f;

	// Token: 0x04000416 RID: 1046
	private const float DEBUG_WAYPOINT_RADIUS = 40f;

	// Token: 0x04000417 RID: 1047
	private const int DEBUG_WAYPOINT_SEGMENTS = 12;

	// Token: 0x04000418 RID: 1048
	private static readonly FLinearColor ObstacleBoxColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000419 RID: 1049
	private static readonly FLinearColor WaypointBoxColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x0400041A RID: 1050
	private static readonly FLinearColor WaypointColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x0400041B RID: 1051
	private static readonly FLinearColor StartColor = new FLinearColor(1f, 0f, 1f, 1f);

	// Token: 0x0400041C RID: 1052
	private static readonly FLinearColor PathArrowColor = new FLinearColor(0f, 1f, 1f, 1f);

	// Token: 0x0400041D RID: 1053
	private bool IsInitTsVariables;

	// Token: 0x0400041E RID: 1054
	private int TsMoveState;

	// Token: 0x0400041F RID: 1055
	private float TsEndDistance;

	// Token: 0x04000420 RID: 1056
	private readonly List<Vector> TargetPath = new List<Vector>();

	// Token: 0x04000421 RID: 1057
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x04000422 RID: 1058
	private int MoveHandleId;

	// Token: 0x04000423 RID: 1059
	private int NpcEntityId;

	// Token: 0x04000424 RID: 1060
	private int VehicleEntityId;

	// Token: 0x04000425 RID: 1061
	private readonly VehicleEnterBoxDebugGeometry DebugBoxGeometry = new VehicleEnterBoxDebugGeometry();

	// Token: 0x04000426 RID: 1062
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcMoveToVehicle.TsTaskNpcMoveToVehicle_C";

	// Token: 0x04000427 RID: 1063
	private static IntPtr _ClassPtr;

	// Token: 0x04000428 RID: 1064
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000429 RID: 1065
	private static int __PropertyOffset_MoveState;

	// Token: 0x0400042A RID: 1066
	private static int __PropertyOffset_EndDistance;

	// Token: 0x0400042B RID: 1067
	private static int __PropertyOffset_EnableDebugDraw;
}
