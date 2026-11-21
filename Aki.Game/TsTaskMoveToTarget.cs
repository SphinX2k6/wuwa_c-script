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
	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000466 RID: 1126 RVA: 0x00015A5B File Offset: 0x00013C5B
	// (set) Token: 0x06000467 RID: 1127 RVA: 0x00015A6B File Offset: 0x00013C6B
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

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000468 RID: 1128 RVA: 0x00015A7C File Offset: 0x00013C7C
	// (set) Token: 0x06000469 RID: 1129 RVA: 0x00015A8C File Offset: 0x00013C8C
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

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x0600046A RID: 1130 RVA: 0x00015A9D File Offset: 0x00013C9D
	// (set) Token: 0x0600046B RID: 1131 RVA: 0x00015AAD File Offset: 0x00013CAD
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

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x0600046C RID: 1132 RVA: 0x00015ABE File Offset: 0x00013CBE
	// (set) Token: 0x0600046D RID: 1133 RVA: 0x00015ACE File Offset: 0x00013CCE
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

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600046E RID: 1134 RVA: 0x00015ADF File Offset: 0x00013CDF
	// (set) Token: 0x0600046F RID: 1135 RVA: 0x00015AF3 File Offset: 0x00013CF3
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

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000470 RID: 1136 RVA: 0x00015B08 File Offset: 0x00013D08
	// (set) Token: 0x06000471 RID: 1137 RVA: 0x00015B18 File Offset: 0x00013D18
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

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000472 RID: 1138 RVA: 0x00015B29 File Offset: 0x00013D29
	// (set) Token: 0x06000473 RID: 1139 RVA: 0x00015B39 File Offset: 0x00013D39
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

	// Token: 0x06000474 RID: 1140 RVA: 0x00015B4C File Offset: 0x00013D4C
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

	// Token: 0x06000475 RID: 1141 RVA: 0x00015C0C File Offset: 0x00013E0C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskMoveToTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskMoveToTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000476 RID: 1142 RVA: 0x00015CBC File Offset: 0x00013EBC
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

	// Token: 0x06000477 RID: 1143 RVA: 0x00015DA0 File Offset: 0x00013FA0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskMoveToTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskMoveToTarget.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00015E58 File Offset: 0x00014058
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

	// Token: 0x06000479 RID: 1145 RVA: 0x00015F04 File Offset: 0x00014104
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

	// Token: 0x0600047A RID: 1146 RVA: 0x00015F70 File Offset: 0x00014170
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

	// Token: 0x0600047B RID: 1147 RVA: 0x00016024 File Offset: 0x00014224
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

	// Token: 0x0600047C RID: 1148 RVA: 0x000160ED File Offset: 0x000142ED
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

	// Token: 0x0600047D RID: 1149 RVA: 0x00016100 File Offset: 0x00014300
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

	// Token: 0x0600047E RID: 1150 RVA: 0x000161AC File Offset: 0x000143AC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskMoveToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskMoveToTarget.TsTaskMoveToTarget_C");
		}
		return TsTaskMoveToTarget._ClassPtr;
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000161D0 File Offset: 0x000143D0
	public TsTaskMoveToTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000161F8 File Offset: 0x000143F8
	[NullableContext(1)]
	public TsTaskMoveToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x0001622B File Offset: 0x0001442B
	protected TsTaskMoveToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00016234 File Offset: 0x00014434
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00016264 File Offset: 0x00014464
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000304 RID: 772
	private const int MIN_MOVE_SPEED = 20;

	// Token: 0x04000305 RID: 773
	private const int MOVE_FAILED_TIME = 5;

	// Token: 0x04000306 RID: 774
	private const int MIN_ARRIVE_DISTANCE_TOLERANCE = 30;

	// Token: 0x04000307 RID: 775
	private bool IsInitTsVariables;

	// Token: 0x04000308 RID: 776
	private int TsMoveMode;

	// Token: 0x04000309 RID: 777
	private int TsMoveState;

	// Token: 0x0400030A RID: 778
	private bool TsIsFollow;

	// Token: 0x0400030B RID: 779
	private bool TsIsFly;

	// Token: 0x0400030C RID: 780
	private int TsTargetEntityId;

	// Token: 0x0400030D RID: 781
	private Vector TsTargetPos;

	// Token: 0x0400030E RID: 782
	private int TsDistance;

	// Token: 0x0400030F RID: 783
	private BaseMoveComponent MoveComp;

	// Token: 0x04000310 RID: 784
	private Vector LastLocation;

	// Token: 0x04000311 RID: 785
	private Vector TargetLocation;

	// Token: 0x04000312 RID: 786
	private Vector TmpVector;

	// Token: 0x04000313 RID: 787
	private double LastTime;

	// Token: 0x04000314 RID: 788
	private double MoveFailedCountDown;

	// Token: 0x04000315 RID: 789
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskMoveToTarget.TsTaskMoveToTarget_C";

	// Token: 0x04000316 RID: 790
	private static IntPtr _ClassPtr;

	// Token: 0x04000317 RID: 791
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000318 RID: 792
	private static int __PropertyOffset_MoveMode;

	// Token: 0x04000319 RID: 793
	private static int __PropertyOffset_MoveState;

	// Token: 0x0400031A RID: 794
	private static int __PropertyOffset_IsFollow;

	// Token: 0x0400031B RID: 795
	private static int __PropertyOffset_TargetEntityId;

	// Token: 0x0400031C RID: 796
	private static int __PropertyOffset_TargetPos;

	// Token: 0x0400031D RID: 797
	private static int __PropertyOffset_IsFly;

	// Token: 0x0400031E RID: 798
	private static int __PropertyOffset_Distance;
}
