using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000074 RID: 116
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToPosition.TsTaskTurnToPosition_C")]
public class TsTaskTurnToPosition : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06000554 RID: 1364 RVA: 0x0001A2B9 File Offset: 0x000184B9
	// (set) Token: 0x06000555 RID: 1365 RVA: 0x0001A2CD File Offset: 0x000184CD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector TargetPos
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToPosition.__PropertyOffset_TargetPos);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToPosition.__PropertyOffset_TargetPos) = value;
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06000556 RID: 1366 RVA: 0x0001A2E2 File Offset: 0x000184E2
	// (set) Token: 0x06000557 RID: 1367 RVA: 0x0001A2F2 File Offset: 0x000184F2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToPosition.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToPosition.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000558 RID: 1368 RVA: 0x0001A303 File Offset: 0x00018503
	// (set) Token: 0x06000559 RID: 1369 RVA: 0x0001A313 File Offset: 0x00018513
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe bool IsInitTsVariables
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToPosition.__PropertyOffset_IsInitTsVariables) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToPosition.__PropertyOffset_IsInitTsVariables) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0001A324 File Offset: 0x00018524
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTargetPos = Vector.Create((double)this.TargetPos.X, (double)this.TargetPos.Y, (double)this.TargetPos.Z);
			this.TsTurnSpeed = this.TurnSpeed;
		}
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x0001A384 File Offset: 0x00018584
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToPosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskTurnToPosition.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600055C RID: 1372 RVA: 0x0001A434 File Offset: 0x00018634
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
		Entity entity = aiController.CharAiDesignComp.Entity;
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (entity == null || !entity.Valid)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.LevelAi;
			ELogAuthor author2 = ELogAuthor.CJH;
			string message2 = "执行转向动作时实体不存在:";
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
			ELogAuthor author3 = ELogAuthor.YJX;
			string message3 = "[TsTaskTurnToPosition]无效的CharacterMovement";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			base.FinishExecute(true);
			return;
		}
		this.MovementMode = ucharacterMovementComponent.MovementMode;
		ucharacterMovementComponent.MovementMode = EMovementMode.MOVE_Walking;
		AiControllerLibrary.TurnToTarget(this.Character, this.TsTargetPos, this.TsTurnSpeed, false, 0f);
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0001A59C File Offset: 0x0001879C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToPosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTurnToPosition.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600055E RID: 1374 RVA: 0x0001A654 File Offset: 0x00018854
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.Character) < 3f)
		{
			this.Character.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.MovementMode;
			base.Finish(true);
		}
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x0001A6A4 File Offset: 0x000188A4
	protected override void OnAbort()
	{
		CharacterActorComponent character = this.Character;
		if (character == null)
		{
			return;
		}
		character.ClearInput(false, true);
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x0001A6B8 File Offset: 0x000188B8
	protected override void OnClear()
	{
		this.Character = null;
		this.MovementMode = EMovementMode.MOVE_None;
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x0001A6C8 File Offset: 0x000188C8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToPosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToPosition.TsTaskTurnToPosition_C");
		}
		return TsTaskTurnToPosition._ClassPtr;
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x0001A6EC File Offset: 0x000188EC
	public TsTaskTurnToPosition() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x0001A714 File Offset: 0x00018914
	[NullableContext(1)]
	public TsTaskTurnToPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0001A747 File Offset: 0x00018947
	protected TsTaskTurnToPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0001A75C File Offset: 0x0001895C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0001A78C File Offset: 0x0001898C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040003D6 RID: 982
	private const float TOLERANCE = 3f;

	// Token: 0x040003D7 RID: 983
	private Vector TsTargetPos;

	// Token: 0x040003D8 RID: 984
	private float TsTurnSpeed = 180f;

	// Token: 0x040003D9 RID: 985
	private CharacterActorComponent Character;

	// Token: 0x040003DA RID: 986
	private EMovementMode MovementMode;

	// Token: 0x040003DB RID: 987
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToPosition.TsTaskTurnToPosition_C";

	// Token: 0x040003DC RID: 988
	private static IntPtr _ClassPtr;

	// Token: 0x040003DD RID: 989
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003DE RID: 990
	private static int __PropertyOffset_TargetPos;

	// Token: 0x040003DF RID: 991
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x040003E0 RID: 992
	private static int __PropertyOffset_IsInitTsVariables;
}
