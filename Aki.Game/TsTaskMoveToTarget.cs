using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000069 RID: 105
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskMoveToTarget.TsTaskMoveToTarget_C")]
public class TsTaskMoveToTarget : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000464 RID: 1124 RVA: 0x0001511F File Offset: 0x0001331F
	// (set) Token: 0x06000465 RID: 1125 RVA: 0x0001512F File Offset: 0x0001332F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_MoveMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_MoveMode) = value;
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000466 RID: 1126 RVA: 0x00015140 File Offset: 0x00013340
	// (set) Token: 0x06000467 RID: 1127 RVA: 0x00015150 File Offset: 0x00013350
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000468 RID: 1128 RVA: 0x00015161 File Offset: 0x00013361
	// (set) Token: 0x06000469 RID: 1129 RVA: 0x00015171 File Offset: 0x00013371
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsFollow
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_IsFollow) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_IsFollow) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x0600046A RID: 1130 RVA: 0x00015182 File Offset: 0x00013382
	// (set) Token: 0x0600046B RID: 1131 RVA: 0x00015192 File Offset: 0x00013392
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TargetEntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_TargetEntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_TargetEntityId) = value;
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x0600046C RID: 1132 RVA: 0x000151A3 File Offset: 0x000133A3
	// (set) Token: 0x0600046D RID: 1133 RVA: 0x000151B7 File Offset: 0x000133B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector TargetPos
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_TargetPos);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_TargetPos) = value;
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600046E RID: 1134 RVA: 0x000151CC File Offset: 0x000133CC
	// (set) Token: 0x0600046F RID: 1135 RVA: 0x000151DC File Offset: 0x000133DC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsFly
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_IsFly) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_IsFly) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000470 RID: 1136 RVA: 0x000151ED File Offset: 0x000133ED
	// (set) Token: 0x06000471 RID: 1137 RVA: 0x000151FD File Offset: 0x000133FD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Distance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_Distance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToTarget.__PropertyOffset_Distance) = value;
		}
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00015210 File Offset: 0x00013410
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveMode = this.MoveMode;
			this.TsMoveState = this.MoveState;
			this.TsIsFollow = this.IsFollow;
			this.TsIsFly = this.IsFly;
			this.TsDistance = this.Distance;
			this.TsTargetEntityId = this.TargetEntityId;
			this.TsTargetPos = Vector.Create((double)this.TargetPos.X, (double)this.TargetPos.Y, (double)this.TargetPos.Z);
			this.LastLocation = Vector.Create();
			this.TargetLocation = Vector.Create();
			this.TmpVector = Vector.Create();
		}
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x000152D0 File Offset: 0x000134D0
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

	// Token: 0x06000474 RID: 1140 RVA: 0x0001536C File Offset: 0x0001356C
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(true);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Entity entity = charActorComp.Entity;
		this.MoveComp = entity.GetComponent<BaseMoveComponent>();
		if (!this.GetMoveToTargetPosition(this.TargetLocation))
		{
			base.FinishExecute(true);
			return;
		}
		if (!this.TryFindPathToTarget(this.TargetLocation))
		{
			base.Finish(true);
			return;
		}
		this.LastTime = Time.Instance.WorldTime;
		Vector lastLocation = this.LastLocation;
		if (lastLocation != null)
		{
			lastLocation.Reset();
		}
		Vector lastLocation2 = this.LastLocation;
		if (lastLocation2 == null)
		{
			return;
		}
		lastLocation2.DeepCopy(charActorComp.ActorLocationProxy);
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00015450 File Offset: 0x00013650
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

	// Token: 0x06000476 RID: 1142 RVA: 0x000154F0 File Offset: 0x000136F0
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			base.Finish(true);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (this.CheckMoveFailed(charActorComp, deltaSeconds))
		{
			base.Finish(true);
			return;
		}
		if (this.TsIsFollow)
		{
			if (!this.GetMoveToTargetPosition(this.TmpVector))
			{
				base.Finish(true);
				return;
			}
			if (Vector.DistSquared(this.TmpVector, this.TargetLocation) > (double)(this.TsDistance * this.TsDistance))
			{
				if (!this.TryFindPathToTarget(this.TmpVector))
				{
					base.Finish(true);
					return;
				}
				this.TargetLocation.DeepCopy(this.TmpVector);
			}
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x0001559C File Offset: 0x0001379C
	protected override void OnClear()
	{
		if (this.MoveComp != null)
		{
			this.MoveComp.StopMoveNew("TsTaskMoveToTarget.OnClear");
			this.MoveComp = null;
		}
		this.LastTime = 0.0;
		this.MoveFailedCountDown = 0.0;
		Vector lastLocation = this.LastLocation;
		if (lastLocation != null)
		{
			lastLocation.Reset();
		}
		Vector targetLocation = this.TargetLocation;
		if (targetLocation == null)
		{
			return;
		}
		targetLocation.Reset();
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00015608 File Offset: 0x00013808
	[NullableContext(1)]
	private bool CheckMoveFailed(CharacterActorComponent character, float deltaTime)
	{
		double num = Vector.Dist(character.ActorLocationProxy, this.LastLocation);
		if ((Time.Instance.WorldTime - this.LastTime) * 0.0010000000474974513 * 20.0 >= num)
		{
			this.MoveFailedCountDown += (double)deltaTime;
			if (this.MoveFailedCountDown >= 5.0)
			{
				character.SetActorLocation(this.TargetLocation.ToUeVector(false), "[TsTaskMoveToLocation]长时间处于某点", false);
				return true;
			}
		}
		else
		{
			this.MoveFailedCountDown = 0.0;
		}
		this.LastTime = Time.Instance.WorldTime;
		this.LastLocation.DeepCopy(character.ActorLocationProxy);
		return false;
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x000156BC File Offset: 0x000138BC
	[NullableContext(1)]
	private bool TryFindPathToTarget(Vector target)
	{
		if (this.MoveComp == null)
		{
			return false;
		}
		Action<ELevelEventState> item = delegate(ELevelEventState _)
		{
			base.Finish(true);
		};
		MoveToLocationController moveController = this.MoveComp.MoveController;
		MoveToPointConfigImpl moveToPointConfigImpl = new MoveToPointConfigImpl();
		moveToPointConfigImpl.Position = target;
		moveToPointConfigImpl.MoveState = new ECharMoveState?(this.ConvertToCharMoveState(this.TsMoveState));
		moveToPointConfigImpl.IsFly = new bool?(this.TsIsFly);
		moveToPointConfigImpl.Distance = new double?((double)this.TsDistance);
		moveToPointConfigImpl.UseNearestDirection = new bool?(false);
		moveToPointConfigImpl.CallbackList = new List<Action<ELevelEventState>>
		{
			item
		};
		moveToPointConfigImpl.ResetCondition = (() => false);
		return moveController.NavigateMoveToLocation(moveToPointConfigImpl, new bool?(true), false, "TsTaskMoveToTarget.TryFindPathToTarget");
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00015785 File Offset: 0x00013985
	private ECharMoveState ConvertToCharMoveState(int state)
	{
		if (state == 1)
		{
			return ECharMoveState.Walk;
		}
		if (state != 2)
		{
			return ECharMoveState.Walk;
		}
		return ECharMoveState.Run;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00015798 File Offset: 0x00013998
	[NullableContext(1)]
	private bool GetMoveToTargetPosition(Vector outPosition)
	{
		switch (this.TsMoveMode)
		{
		case 1:
			outPosition.DeepCopy(this.TsTargetPos);
			break;
		case 2:
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				return false;
			}
			outPosition.DeepCopy(baseCharacter.CharacterActorComponent.ActorLocationProxy);
			break;
		}
		case 3:
		{
			CreatureModel instance = CreatureModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(this.TsTargetEntityId) : null;
			if (entityHandle == null || !entityHandle.Valid)
			{
				return false;
			}
			BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
			outPosition.DeepCopy(component.ActorLocationProxy);
			break;
		}
		default:
			return false;
		}
		return true;
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00015844 File Offset: 0x00013A44
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskMoveToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskMoveToTarget.TsTaskMoveToTarget_C");
		}
		return TsTaskMoveToTarget._ClassPtr;
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00015868 File Offset: 0x00013A68
	public TsTaskMoveToTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00015890 File Offset: 0x00013A90
	[NullableContext(1)]
	public TsTaskMoveToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000158C3 File Offset: 0x00013AC3
	protected TsTaskMoveToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000158CC File Offset: 0x00013ACC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x000158FC File Offset: 0x00013AFC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000302 RID: 770
	private const int MIN_MOVE_SPEED = 20;

	// Token: 0x04000303 RID: 771
	private const int MOVE_FAILED_TIME = 5;

	// Token: 0x04000304 RID: 772
	private const int MIN_ARRIVE_DISTANCE_TOLERANCE = 30;

	// Token: 0x04000305 RID: 773
	private bool IsInitTsVariables;

	// Token: 0x04000306 RID: 774
	private int TsMoveMode;

	// Token: 0x04000307 RID: 775
	private int TsMoveState;

	// Token: 0x04000308 RID: 776
	private bool TsIsFollow;

	// Token: 0x04000309 RID: 777
	private bool TsIsFly;

	// Token: 0x0400030A RID: 778
	private int TsTargetEntityId;

	// Token: 0x0400030B RID: 779
	private Vector TsTargetPos;

	// Token: 0x0400030C RID: 780
	private int TsDistance;

	// Token: 0x0400030D RID: 781
	private BaseMoveComponent MoveComp;

	// Token: 0x0400030E RID: 782
	private Vector LastLocation;

	// Token: 0x0400030F RID: 783
	private Vector TargetLocation;

	// Token: 0x04000310 RID: 784
	private Vector TmpVector;

	// Token: 0x04000311 RID: 785
	private double LastTime;

	// Token: 0x04000312 RID: 786
	private double MoveFailedCountDown;

	// Token: 0x04000313 RID: 787
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskMoveToTarget.TsTaskMoveToTarget_C";

	// Token: 0x04000314 RID: 788
	private static IntPtr _ClassPtr;

	// Token: 0x04000315 RID: 789
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000316 RID: 790
	private static int __PropertyOffset_MoveMode;

	// Token: 0x04000317 RID: 791
	private static int __PropertyOffset_MoveState;

	// Token: 0x04000318 RID: 792
	private static int __PropertyOffset_IsFollow;

	// Token: 0x04000319 RID: 793
	private static int __PropertyOffset_TargetEntityId;

	// Token: 0x0400031A RID: 794
	private static int __PropertyOffset_TargetPos;

	// Token: 0x0400031B RID: 795
	private static int __PropertyOffset_IsFly;

	// Token: 0x0400031C RID: 796
	private static int __PropertyOffset_Distance;
}
