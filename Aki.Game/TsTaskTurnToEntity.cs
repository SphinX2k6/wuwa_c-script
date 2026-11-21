using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000072 RID: 114
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToEntity.TsTaskTurnToEntity_C")]
public class TsTaskTurnToEntity : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06000529 RID: 1321 RVA: 0x000194C9 File Offset: 0x000176C9
	// (set) Token: 0x0600052A RID: 1322 RVA: 0x000194D9 File Offset: 0x000176D9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TurnMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_TurnMode);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_TurnMode) = value;
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x0600052B RID: 1323 RVA: 0x000194EA File Offset: 0x000176EA
	// (set) Token: 0x0600052C RID: 1324 RVA: 0x000194FA File Offset: 0x000176FA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TargetEntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_TargetEntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_TargetEntityId) = value;
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001950B File Offset: 0x0001770B
	// (set) Token: 0x0600052E RID: 1326 RVA: 0x0001951F File Offset: 0x0001771F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector TargetPos
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_TargetPos);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_TargetPos) = value;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x0600052F RID: 1327 RVA: 0x00019534 File Offset: 0x00017734
	// (set) Token: 0x06000530 RID: 1328 RVA: 0x00019544 File Offset: 0x00017744
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000531 RID: 1329 RVA: 0x00019555 File Offset: 0x00017755
	// (set) Token: 0x06000532 RID: 1330 RVA: 0x00019565 File Offset: 0x00017765
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseLookAtForSmallAngle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_UseLookAtForSmallAngle) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTurnToEntity.__PropertyOffset_UseLookAtForSmallAngle) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00019578 File Offset: 0x00017778
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTurnMode = this.TurnMode;
			this.TsTargetEntityId = this.TargetEntityId;
			this.TsTargetPos = Vector.Create((double)this.TargetPos.X, (double)this.TargetPos.Y, (double)this.TargetPos.Z);
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsUseLookAtForSmallAngle = this.UseLookAtForSmallAngle;
		}
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x000195FC File Offset: 0x000177FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToEntity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskTurnToEntity.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000535 RID: 1333 RVA: 0x000196AC File Offset: 0x000178AC
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
			string message3 = "[TsTaskTurnToEntity]无效的CharacterMovement";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("PbDataId", component.GetPbDataId());
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			base.FinishExecute(true);
			return;
		}
		MathUtils.Instance.CommonTempVector.Reset();
		this.SightTarget = null;
		if (!this.GetTurnToPosition(MathUtils.Instance.CommonTempVector))
		{
			base.FinishExecute(true);
			return;
		}
		CommonNpcPerformComponent component3 = entity.GetComponent<CommonNpcPerformComponent>();
		bool flag = this.TsUseLookAtForSmallAngle && component3 != null && NpcTurnToLookAtUtils.ShouldUseLookAtForSmallAngle(this.Character, MathUtils.Instance.CommonTempVector, 30);
		if (!flag)
		{
			this.MovementMode = ucharacterMovementComponent.MovementMode;
			ucharacterMovementComponent.MovementMode = EMovementMode.MOVE_Walking;
		}
		if (NpcTurnToLookAtUtils.TurnToTargetOrLookAtForSmallAngle(entity, this.Character, MathUtils.Instance.CommonTempVector, this.TsTurnSpeed, false, 0f, flag, new OneOf<BaseActorComponent, Vector, AActor>?(this.SightTarget ?? Vector.Create(MathUtils.Instance.CommonTempVector))) == ETurnToTargetResult.LookAt)
		{
			base.FinishExecute(true);
			return;
		}
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x000198C0 File Offset: 0x00017AC0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTurnToEntity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTurnToEntity.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000537 RID: 1335 RVA: 0x00019978 File Offset: 0x00017B78
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.Character) < 3f)
		{
			this.Character.Entity.GetComponent<BaseMoveComponent>().CharacterMovement.MovementMode = this.MovementMode;
			base.Finish(true);
		}
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x000199C8 File Offset: 0x00017BC8
	protected override void OnClear()
	{
		this.Character = null;
		this.MovementMode = EMovementMode.MOVE_None;
		this.SightTarget = null;
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x000199E4 File Offset: 0x00017BE4
	[NullableContext(1)]
	private bool GetTurnToPosition(Vector outPosition)
	{
		switch (this.TsTurnMode)
		{
		case 2:
		{
			CreatureModel instance = CreatureModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetEntityByPbDataId(this.TsTargetEntityId) : null;
			if (entityHandle == null || !entityHandle.Valid)
			{
				return false;
			}
			BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
			outPosition.DeepCopy(component.ActorLocationProxy);
			this.SightTarget = new OneOf<BaseActorComponent, Vector, AActor>?(component);
			break;
		}
		case 3:
			outPosition.DeepCopy(this.TsTargetPos);
			this.SightTarget = new OneOf<BaseActorComponent, Vector, AActor>?(Vector.Create(outPosition));
			break;
		case 4:
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			if (baseCharacter == null || !baseCharacter.IsValid() || (characterActorComponent == null || !characterActorComponent.Valid))
			{
				return false;
			}
			outPosition.DeepCopy(characterActorComponent.ActorLocationProxy);
			this.SightTarget = new OneOf<BaseActorComponent, Vector, AActor>?(characterActorComponent);
			break;
		}
		default:
			return false;
		}
		return true;
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00019AE4 File Offset: 0x00017CE4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTurnToEntity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToEntity.TsTaskTurnToEntity_C");
		}
		return TsTaskTurnToEntity._ClassPtr;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00019B08 File Offset: 0x00017D08
	public TsTaskTurnToEntity() : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00019B30 File Offset: 0x00017D30
	[NullableContext(1)]
	public TsTaskTurnToEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00019B63 File Offset: 0x00017D63
	protected TsTaskTurnToEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00019B78 File Offset: 0x00017D78
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00019BA8 File Offset: 0x00017DA8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040003B0 RID: 944
	private const float TOLERANCE = 3f;

	// Token: 0x040003B1 RID: 945
	private int TsTurnMode;

	// Token: 0x040003B2 RID: 946
	private int TsTargetEntityId;

	// Token: 0x040003B3 RID: 947
	private Vector TsTargetPos;

	// Token: 0x040003B4 RID: 948
	private float TsTurnSpeed = 180f;

	// Token: 0x040003B5 RID: 949
	private bool TsUseLookAtForSmallAngle;

	// Token: 0x040003B6 RID: 950
	private CharacterActorComponent Character;

	// Token: 0x040003B7 RID: 951
	private EMovementMode MovementMode;

	// Token: 0x040003B8 RID: 952
	private bool IsInitTsVariables;

	// Token: 0x040003B9 RID: 953
	[Nullable(new byte[]
	{
		0,
		1,
		1,
		1
	})]
	private OneOf<BaseActorComponent, Vector, AActor>? SightTarget;

	// Token: 0x040003BA RID: 954
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskTurnToEntity.TsTaskTurnToEntity_C";

	// Token: 0x040003BB RID: 955
	private static IntPtr _ClassPtr;

	// Token: 0x040003BC RID: 956
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003BD RID: 957
	private static int __PropertyOffset_TurnMode;

	// Token: 0x040003BE RID: 958
	private static int __PropertyOffset_TargetEntityId;

	// Token: 0x040003BF RID: 959
	private static int __PropertyOffset_TargetPos;

	// Token: 0x040003C0 RID: 960
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x040003C1 RID: 961
	private static int __PropertyOffset_UseLookAtForSmallAngle;
}
