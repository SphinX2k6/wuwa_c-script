using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000073 RID: 115
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToNpcVehicle.TsTaskTurnToNpcVehicle_C")]
public class TsTaskTurnToNpcVehicle : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000540 RID: 1344 RVA: 0x00019BDB File Offset: 0x00017DDB
	// (set) Token: 0x06000541 RID: 1345 RVA: 0x00019BEB File Offset: 0x00017DEB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToNpcVehicle.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToNpcVehicle.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06000542 RID: 1346 RVA: 0x00019BFC File Offset: 0x00017DFC
	// (set) Token: 0x06000543 RID: 1347 RVA: 0x00019C0C File Offset: 0x00017E0C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MovementMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToNpcVehicle.__PropertyOffset_MovementMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToNpcVehicle.__PropertyOffset_MovementMode) = value;
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x06000544 RID: 1348 RVA: 0x00019C1D File Offset: 0x00017E1D
	// (set) Token: 0x06000545 RID: 1349 RVA: 0x00019C2D File Offset: 0x00017E2D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableDebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToNpcVehicle.__PropertyOffset_EnableDebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToNpcVehicle.__PropertyOffset_EnableDebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00019C3E File Offset: 0x00017E3E
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsMovementMode = (EMovementMode)this.MovementMode;
		}
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00019C70 File Offset: 0x00017E70
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToNpcVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskTurnToNpcVehicle.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000548 RID: 1352 RVA: 0x00019D20 File Offset: 0x00017F20
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(true);
			return;
		}
		Entity entity = aiController.CharAiDesignComp.Entity;
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (entity == null || !entity.Valid)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.LevelAi;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "执行转向骑乘载具时实体不存在:";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(true);
			return;
		}
		this.Character = entity.GetComponent<CharacterActorComponent>();
		BaseMoveComponent component2 = entity.GetComponent<BaseMoveComponent>();
		UCharacterMovementComponent ucharacterMovementComponent = (component2 != null) ? component2.CharacterMovement : null;
		if (ucharacterMovementComponent == null || !ucharacterMovementComponent.IsValid())
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.LevelAi;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "[TsTaskTurnToNpcVehicle]无效的CharacterMovement";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			base.FinishExecute(true);
			return;
		}
		this.OriginalMovementMode = ucharacterMovementComponent.MovementMode;
		ucharacterMovementComponent.MovementMode = this.TsMovementMode;
		int id = entity.Id;
		int? ridingVehicle = NpcVehicleRiderController.Instance.GetRidingVehicle(id);
		if (ridingVehicle == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.LevelAi;
			ELogAuthor author4 = ELogAuthor.ZJL;
			string message4 = "[TsTaskTurnToNpcVehicle]NPC没有骑乘载具";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("NpcEntityId", id);
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			ucharacterMovementComponent.MovementMode = this.OriginalMovementMode;
			base.FinishExecute(true);
			return;
		}
		MathUtils.Instance.CommonTempVector.Reset();
		if (!NpcVehicleRiderController.Instance.GetNpcRideFacingDirection(id, ridingVehicle.Value, MathUtils.Instance.CommonTempVector))
		{
			ucharacterMovementComponent.MovementMode = this.OriginalMovementMode;
			base.FinishExecute(true);
			return;
		}
		AiControllerLibrary.TurnToDirect(this.Character, MathUtils.Instance.CommonTempVector, this.TsTurnSpeed, false, 0f);
		this.TmpTargetDirection.DeepCopy(MathUtils.Instance.CommonTempVector);
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00019F50 File Offset: 0x00018150
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToNpcVehicle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTurnToNpcVehicle.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600054A RID: 1354 RVA: 0x0001A008 File Offset: 0x00018208
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.EnableDebugDraw)
		{
			this.DrawDebugRotation();
		}
		if (GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.Character) < 3f)
		{
			this.Character.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.OriginalMovementMode;
			base.Finish(true);
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0001A068 File Offset: 0x00018268
	private void DrawDebugRotation()
	{
		CharacterActorComponent character = this.Character;
		if (character == null || !character.Valid)
		{
			return;
		}
		Vector actorLocationProxy = character.ActorLocationProxy;
		this.TmpArrowEnd.DeepCopy(character.ActorForwardProxy);
		this.TmpArrowEnd.MultiplyEqual(200.0);
		this.TmpArrowEnd.AdditionEqual(actorLocationProxy);
		UKismetSystemLibrary.D_DrawDebugArrow(this, actorLocationProxy.ToUeVector(false), this.TmpArrowEnd.ToUeVector(false), 60f, TsTaskTurnToNpcVehicle.CurrentRotationColor, 0f, 2f);
		this.TmpArrowEnd.DeepCopy(this.TmpTargetDirection);
		this.TmpArrowEnd.MultiplyEqual(200.0);
		this.TmpArrowEnd.AdditionEqual(actorLocationProxy);
		UKismetSystemLibrary.D_DrawDebugArrow(this, actorLocationProxy.ToUeVector(false), this.TmpArrowEnd.ToUeVector(false), 60f, TsTaskTurnToNpcVehicle.TargetRotationColor, 0f, 2f);
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0001A155 File Offset: 0x00018355
	protected override void OnClear()
	{
		this.Character = null;
		this.OriginalMovementMode = EMovementMode.MOVE_None;
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0001A165 File Offset: 0x00018365
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToNpcVehicle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToNpcVehicle.TsTaskTurnToNpcVehicle_C");
		}
		return TsTaskTurnToNpcVehicle._ClassPtr;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0001A18C File Offset: 0x0001838C
	public TsTaskTurnToNpcVehicle() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToNpcVehicle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0001A1B4 File Offset: 0x000183B4
	[NullableContext(1)]
	public TsTaskTurnToNpcVehicle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToNpcVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0001A1E7 File Offset: 0x000183E7
	protected TsTaskTurnToNpcVehicle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0001A218 File Offset: 0x00018418
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0001A248 File Offset: 0x00018448
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040003C2 RID: 962
	private const float TOLERANCE = 3f;

	// Token: 0x040003C3 RID: 963
	private const float DEBUG_ARROW_LENGTH = 200f;

	// Token: 0x040003C4 RID: 964
	private const float DEBUG_ARROW_SIZE = 60f;

	// Token: 0x040003C5 RID: 965
	private const float DEBUG_DRAW_DURATION = 0f;

	// Token: 0x040003C6 RID: 966
	private const float DEBUG_DRAW_THICKNESS = 2f;

	// Token: 0x040003C7 RID: 967
	private static readonly FLinearColor CurrentRotationColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x040003C8 RID: 968
	private static readonly FLinearColor TargetRotationColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x040003C9 RID: 969
	private float TsTurnSpeed = 180f;

	// Token: 0x040003CA RID: 970
	private EMovementMode TsMovementMode = EMovementMode.MOVE_Walking;

	// Token: 0x040003CB RID: 971
	[Nullable(2)]
	private CharacterActorComponent Character;

	// Token: 0x040003CC RID: 972
	[Nullable(1)]
	private readonly Vector TmpTargetDirection = Vector.Create();

	// Token: 0x040003CD RID: 973
	[Nullable(1)]
	private readonly Vector TmpArrowEnd = Vector.Create();

	// Token: 0x040003CE RID: 974
	private EMovementMode OriginalMovementMode;

	// Token: 0x040003CF RID: 975
	private bool IsInitTsVariables;

	// Token: 0x040003D0 RID: 976
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToNpcVehicle.TsTaskTurnToNpcVehicle_C";

	// Token: 0x040003D1 RID: 977
	private static IntPtr _ClassPtr;

	// Token: 0x040003D2 RID: 978
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003D3 RID: 979
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x040003D4 RID: 980
	private static int __PropertyOffset_MovementMode;

	// Token: 0x040003D5 RID: 981
	private static int __PropertyOffset_EnableDebugDraw;
}
