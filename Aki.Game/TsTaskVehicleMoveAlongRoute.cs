using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200007F RID: 127
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskVehicleMoveAlongRoute.TsTaskVehicleMoveAlongRoute_C")]
public class TsTaskVehicleMoveAlongRoute : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001E5F5 File Offset: 0x0001C7F5
	// (set) Token: 0x06000618 RID: 1560 RVA: 0x0001E605 File Offset: 0x0001C805
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MaxExecuteTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskVehicleMoveAlongRoute.__PropertyOffset_MaxExecuteTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskVehicleMoveAlongRoute.__PropertyOffset_MaxExecuteTime) = value;
		}
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x0001E616 File Offset: 0x0001C816
	private void OnMoveEnd(ELevelEventState result)
	{
		this.ConcludeAtEndpoint();
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x0001E61E File Offset: 0x0001C81E
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMaxExecuteTime = this.MaxExecuteTime;
		}
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x0001E644 File Offset: 0x0001C844
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

	// Token: 0x0600061C RID: 1564 RVA: 0x0001E6E0 File Offset: 0x0001C8E0
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		this.ResetRuntimeState();
		if (!(ownerController is TsAiController))
		{
			this.FailExecute(false);
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
			this.FailExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			this.FailExecute(false);
			return;
		}
		this.VehicleEntityId = charActorComp.Entity.Id;
		int? availableRouteNpc = NpcVehicleRiderController.Instance.GetAvailableRouteNpc(this.VehicleEntityId);
		if (availableRouteNpc == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[TsTaskVehicleMoveAlongRoute] 失败:无可用移动目标乘客";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.FailExecute(false);
			return;
		}
		int? npcTargetSplinePbDataId = NpcVehicleRiderController.Instance.GetNpcTargetSplinePbDataId(availableRouteNpc.Value);
		if (npcTargetSplinePbDataId != null)
		{
			int? num = npcTargetSplinePbDataId;
			int num2 = 0;
			if (!(num.GetValueOrDefault() <= num2 & num != null))
			{
				int? num3 = NpcVehicleRiderController.Instance.ActivateNpcRouteBySpline(this.VehicleEntityId, npcTargetSplinePbDataId.Value);
				if (num3 == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Vehicle;
					ELogAuthor author3 = ELogAuthor.ZJL;
					string message3 = "[TsTaskVehicleMoveAlongRoute] 失败:激活样条路线失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplinePbDataId", npcTargetSplinePbDataId);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.FailExecute(false);
					return;
				}
				this.ServedNpcEntityId = num3.Value;
				this.MoveComp = charActorComp.Entity.GetComponent<BaseMoveComponent>();
				if (this.MoveComp == null)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Vehicle;
					ELogAuthor author4 = ELogAuthor.ZJL;
					string message4 = "[TsTaskVehicleMoveAlongRoute] 失败:载具缺少移动组件";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					this.FailExecute(true);
					return;
				}
				this.ExecuteTimeStamp = Time.Instance.WorldTime;
				if (!this.StartMoveAlongRoute(npcTargetSplinePbDataId.Value, charActorComp.CreatureData.GetPbDataId()))
				{
					this.FailExecute(true);
				}
				return;
			}
		}
		Log instance5 = Log.Instance;
		ELogModule module5 = ELogModule.Vehicle;
		ELogAuthor author5 = ELogAuthor.ZJL;
		string message5 = "[TsTaskVehicleMoveAlongRoute] 失败:乘客未登记有效样条";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("NpcEntityId", availableRouteNpc);
		instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		this.FailExecute(false);
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x0001E998 File Offset: 0x0001CB98
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

	// Token: 0x0600061E RID: 1566 RVA: 0x0001EA38 File Offset: 0x0001CC38
	[NullableContext(2)]
	protected unsafe virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.Finished)
		{
			return;
		}
		if (!(ownerController is TsAiController))
		{
			this.FailExecute(false);
			return;
		}
		Entity entity = EntitySystem.Instance.Get(this.ServedNpcEntityId);
		if (entity == null || !entity.Active)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[TsTaskVehicleMoveAlongRoute] 失败:被服务NPC实体失效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ServedNpcEntityId", this.ServedNpcEntityId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			NpcVehicleRiderController.Instance.ReleaseVehicle(this.ServedNpcEntityId);
			this.FailExecute(false);
			return;
		}
		if (Time.Instance.WorldTime > this.ExecuteTimeStamp + (double)this.TsMaxExecuteTime)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[TsTaskVehicleMoveAlongRoute] 样条移动超时, 按到达终点收尾";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ServedNpcEntityId", this.ServedNpcEntityId);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.ConcludeAtEndpoint();
		}
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x0001EB8F File Offset: 0x0001CD8F
	private void ConcludeAtEndpoint()
	{
		if (this.Finished)
		{
			return;
		}
		this.Finished = true;
		base.Finish(this.ApplyEndpointState());
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x0001EBAD File Offset: 0x0001CDAD
	private void ResetRuntimeState()
	{
		this.VehicleEntityId = 0;
		this.ServedNpcEntityId = 0;
		this.MoveComp = null;
		this.MoveHandleId = 0;
		this.ExecuteTimeStamp = 0.0;
		this.Finished = false;
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x0001EBE1 File Offset: 0x0001CDE1
	private void FailExecute(bool releaseServedNpc = false)
	{
		if (this.Finished)
		{
			return;
		}
		if (releaseServedNpc && this.ServedNpcEntityId != 0)
		{
			NpcVehicleRiderController.Instance.ReleaseVehicle(this.ServedNpcEntityId);
		}
		this.Finished = true;
		base.Finish(false);
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x0001EC18 File Offset: 0x0001CE18
	private bool StartMoveAlongRoute(int splinePbDataId, int vehiclePbDataId)
	{
		if (this.MoveComp == null)
		{
			return false;
		}
		MoveCharacterConfig moveCharacterConfig = this.CreateMoveConfig(splinePbDataId, vehiclePbDataId);
		if (moveCharacterConfig == null)
		{
			return false;
		}
		this.MoveHandleId = this.MoveComp.MoveAlongPath(moveCharacterConfig, "TsTaskVehicleMoveAlongRoute.StartMoveAlongRoute");
		return true;
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x0001EC58 File Offset: 0x0001CE58
	[NullableContext(2)]
	private unsafe MoveCharacterConfig CreateMoveConfig(int splinePbDataId, int vehiclePbDataId)
	{
		GameSplineComponent gameSplineComponent = new GameSplineComponent(splinePbDataId);
		if (!gameSplineComponent.InitializeWithSubPoints(vehiclePbDataId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[TsTaskVehicleMoveAlongRoute] 失败:NPC移动组件初始化样条失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplinePbDataId", splinePbDataId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		if (gameSplineComponent.PathPoint.Count < 2)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[TsTaskVehicleMoveAlongRoute] 失败:NPC移动组件样条点数量不足";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SplinePbDataId", splinePbDataId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return null;
		}
		List<MoveCharacterPoint> list = new List<MoveCharacterPoint>();
		int num = 0;
		foreach (PatrolPoint patrolPoint in gameSplineComponent.PathPoint)
		{
			MoveCharacterPoint item = new MoveCharacterPoint
			{
				Index = (patrolPoint.IsMain ? num : -1),
				Position = patrolPoint.Point,
				MoveState = new EPatrolMoveState?((EPatrolMoveState)patrolPoint.MoveState)
			};
			if (patrolPoint.IsMain)
			{
				num++;
			}
			list.Add(item);
		}
		BaseMoveComponent moveComp = this.MoveComp;
		CharacterActorComponent characterActorComponent = (moveComp != null) ? moveComp.ActorComp : null;
		int num2 = (characterActorComponent != null) ? this.FindNearestNextPointIndex(list, characterActorComponent.ActorLocationProxy, characterActorComponent.ActorForwardProxy) : 0;
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Vehicle;
		ELogAuthor author3 = ELogAuthor.ZJL;
		string message3 = "[TsTaskVehicleMoveAlongRoute] 创建移动配置完成";
		<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray6<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("VehicleEntityId", this.VehicleEntityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("SplinePbDataId", splinePbDataId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("移动点数量", list.Count);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("主锚点数量", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("起始点Index", num2);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("载具位置", (characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 6));
		return new MoveCharacterConfig
		{
			Points = list,
			Navigation = true,
			StrictNavigation = new bool?(true),
			IsFly = false,
			DebugMode = true,
			Loop = false,
			CircleMove = new bool?(false),
			UsePreviousIndex = new bool?(false),
			UseNearestPoint = new bool?(true),
			StartIndex = new int?(num2),
			TurnSpeed = new float?(0f),
			ReturnFalseWhenNavigationFailed = true,
			ReturnTimeoutFailed = new float?((float)300000),
			Callback = new Action<ELevelEventState>(this.OnMoveEnd)
		};
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x0001EFA0 File Offset: 0x0001D1A0
	private int FindNearestNextPointIndex(List<MoveCharacterPoint> movePoints, Vector currentLocation, Vector forward)
	{
		int result = 0;
		double num = double.MaxValue;
		for (int i = 0; i < movePoints.Count - 1; i++)
		{
			Vector position = movePoints[i].Position;
			Vector position2 = movePoints[i + 1].Position;
			position2.Subtraction(position, this.NearestSegmentVector);
			double num2 = this.NearestSegmentVector.Size();
			if (num2 > 0.0)
			{
				currentLocation.Subtraction(position2, this.NearestToPointVector);
				if (this.NearestSegmentVector.DotProduct(this.NearestToPointVector) <= 0.0)
				{
					currentLocation.Subtraction(position, this.NearestToPointVector);
					if (this.NearestSegmentVector.DotProduct(this.NearestToPointVector) >= 0.0 && this.NearestSegmentVector.DotProduct(forward) >= 0.0)
					{
						this.NearestSegmentVector.CrossProduct(this.NearestToPointVector, this.NearestCrossVector);
						double num3 = this.NearestCrossVector.Size() / num2;
						if (num3 < num)
						{
							num = num3;
							result = i + 1;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x0001F0BC File Offset: 0x0001D2BC
	private bool ApplyEndpointState()
	{
		Entity entity = EntitySystem.Instance.Get(this.ServedNpcEntityId);
		if (entity != null && entity.Active)
		{
			NpcVehicleRiderController.Instance.SetNpcVehicleRideState(this.ServedNpcEntityId, ENpcVehicleRideState.WaitingToDismount);
			return true;
		}
		NpcVehicleRiderController.Instance.ReleaseVehicle(this.ServedNpcEntityId);
		return false;
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x0001F10D File Offset: 0x0001D30D
	protected override void OnAbort()
	{
		if (this.Finished || this.ServedNpcEntityId == 0)
		{
			return;
		}
		this.Finished = true;
		this.ApplyEndpointState();
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x0001F12E File Offset: 0x0001D32E
	protected override void OnClear()
	{
		if (this.MoveComp != null)
		{
			this.MoveComp.StopMoveByHandleId(this.MoveHandleId, "TsTaskVehicleMoveAlongRoute.OnClear");
		}
		this.MoveComp = null;
		this.MoveHandleId = 0;
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0001F15C File Offset: 0x0001D35C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskVehicleMoveAlongRoute._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskVehicleMoveAlongRoute.TsTaskVehicleMoveAlongRoute_C");
		}
		return TsTaskVehicleMoveAlongRoute._ClassPtr;
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x0001F180 File Offset: 0x0001D380
	public TsTaskVehicleMoveAlongRoute() : this(BuiltinUtils.AllocNativeUObject(TsTaskVehicleMoveAlongRoute.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
	public TsTaskVehicleMoveAlongRoute(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskVehicleMoveAlongRoute.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x0001F1DB File Offset: 0x0001D3DB
	protected TsTaskVehicleMoveAlongRoute(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0001F208 File Offset: 0x0001D408
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0001F238 File Offset: 0x0001D438
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000473 RID: 1139
	private const int DEFAULT_MAX_EXECUTE_TIME = 300000;

	// Token: 0x04000474 RID: 1140
	private const int DEFAULT_MOVE_STATE = 1;

	// Token: 0x04000475 RID: 1141
	private bool IsInitTsVariables;

	// Token: 0x04000476 RID: 1142
	private int TsMaxExecuteTime;

	// Token: 0x04000477 RID: 1143
	private int VehicleEntityId;

	// Token: 0x04000478 RID: 1144
	private int ServedNpcEntityId;

	// Token: 0x04000479 RID: 1145
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400047A RID: 1146
	private int MoveHandleId;

	// Token: 0x0400047B RID: 1147
	private double ExecuteTimeStamp;

	// Token: 0x0400047C RID: 1148
	private bool Finished;

	// Token: 0x0400047D RID: 1149
	private readonly Vector NearestSegmentVector = Vector.Create();

	// Token: 0x0400047E RID: 1150
	private readonly Vector NearestToPointVector = Vector.Create();

	// Token: 0x0400047F RID: 1151
	private readonly Vector NearestCrossVector = Vector.Create();

	// Token: 0x04000480 RID: 1152
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskVehicleMoveAlongRoute.TsTaskVehicleMoveAlongRoute_C";

	// Token: 0x04000481 RID: 1153
	private static IntPtr _ClassPtr;

	// Token: 0x04000482 RID: 1154
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000483 RID: 1155
	private static int __PropertyOffset_MaxExecuteTime;
}
