using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200006D RID: 109
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcSitOnChair.TsTaskNpcSitOnChair_C")]
public class TsTaskNpcSitOnChair : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060004B8 RID: 1208 RVA: 0x000171A5 File Offset: 0x000153A5
	// (set) Token: 0x060004B9 RID: 1209 RVA: 0x000171B5 File Offset: 0x000153B5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ChairEntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcSitOnChair.__PropertyOffset_ChairEntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcSitOnChair.__PropertyOffset_ChairEntityId) = value;
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x060004BA RID: 1210 RVA: 0x000171C6 File Offset: 0x000153C6
	// (set) Token: 0x060004BB RID: 1211 RVA: 0x000171DA File Offset: 0x000153DA
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string MontagePath
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcSitOnChair.__PropertyOffset_MontagePath)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcSitOnChair.__PropertyOffset_MontagePath)), value);
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060004BC RID: 1212 RVA: 0x000171EF File Offset: 0x000153EF
	// (set) Token: 0x060004BD RID: 1213 RVA: 0x000171FF File Offset: 0x000153FF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LoopDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcSitOnChair.__PropertyOffset_LoopDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcSitOnChair.__PropertyOffset_LoopDuration) = value;
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060004BE RID: 1214 RVA: 0x00017210 File Offset: 0x00015410
	// (set) Token: 0x060004BF RID: 1215 RVA: 0x00017220 File Offset: 0x00015420
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int RepeatTimes
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcSitOnChair.__PropertyOffset_RepeatTimes);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcSitOnChair.__PropertyOffset_RepeatTimes) = value;
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00017231 File Offset: 0x00015431
	// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00017239 File Offset: 0x00015439
	private TsTaskNpcSitOnChair.ETaskPhase Phase
	{
		get
		{
			return this.PhaseInternal;
		}
		set
		{
			if (this.PhaseInternal == value)
			{
				return;
			}
			this.PhaseInternal = value;
		}
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0001724C File Offset: 0x0001544C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsChairEntityId = this.ChairEntityId;
			this.TsMontagePath = this.MontagePath;
			this.TsLoopDuration = this.LoopDuration;
			this.TsRepeatTimes = this.RepeatTimes;
			this.ChairNearbyPos = Vector.Create();
			this.ChairSitPos = Vector.Create();
			this.TempVec = Vector.Create();
		}
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x000172C0 File Offset: 0x000154C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskNpcSitOnChair) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskNpcSitOnChair.StaticClass(), out intPtr, out num))
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

	// Token: 0x060004C4 RID: 1220 RVA: 0x00017370 File Offset: 0x00015570
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
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
		this.Entity = aiController.CharAiDesignComp.Entity;
		this.Character = this.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComp = this.Entity.GetComponent<BaseMoveComponent>();
		this.AnimComp = this.Entity.GetComponent<CharacterAnimationComponent>();
		BaseMoveComponent moveComp = this.MoveComp;
		bool flag;
		if (moveComp == null)
		{
			flag = true;
		}
		else
		{
			UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
			flag = !((characterMovement != null) ? new bool?(characterMovement.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.YJX;
			string message2 = "[TsTaskSitOnChair]MoveComp不合法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.Character.CreatureData.GetPbDataId());
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.FinishExecute(true);
			return;
		}
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.TsChairEntityId);
		object obj;
		if (entityByPbDataId == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityByPbDataId.Entity;
			if (entity == null)
			{
				obj = null;
			}
			else
			{
				PawnInteractNewComponent component = entity.GetComponent<PawnInteractNewComponent>();
				obj = ((component != null) ? component.GetSubEntityInteractLogicController() : null);
			}
		}
		this.ChairController = (obj as PawnChairController);
		if (this.ChairController == null || !this.ChairController.IsSceneInteractionLoadCompleted())
		{
			base.FinishExecute(true);
			return;
		}
		if (this.TsMontagePath == "")
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.YJX;
			string message3 = "[TsTaskSitOnChair]无效的Montage路径";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", this.Character.CreatureData.GetPbDataId());
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			base.FinishExecute(true);
			return;
		}
		this.Phase = TsTaskNpcSitOnChair.ETaskPhase.Execute;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x000175C4 File Offset: 0x000157C4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskNpcSitOnChair) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskNpcSitOnChair.StaticClass(), out intPtr, out num))
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

	// Token: 0x060004C6 RID: 1222 RVA: 0x0001767C File Offset: 0x0001587C
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		switch (this.Phase)
		{
		case TsTaskNpcSitOnChair.ETaskPhase.Execute:
			this.Phase = TsTaskNpcSitOnChair.ETaskPhase.MoveNearby;
			return;
		case TsTaskNpcSitOnChair.ETaskPhase.MoveNearby:
			this.ExecuteMoveNearby();
			return;
		case TsTaskNpcSitOnChair.ETaskPhase.MoveClose:
			this.ExecuteMoveClose();
			return;
		case TsTaskNpcSitOnChair.ETaskPhase.TurnTo:
			this.ExecuteTurnTo();
			return;
		case TsTaskNpcSitOnChair.ETaskPhase.PlayMontage:
			this.ExecutePlayMontage();
			return;
		case TsTaskNpcSitOnChair.ETaskPhase.MoveAway:
			this.ExecuteMoveAway();
			return;
		case TsTaskNpcSitOnChair.ETaskPhase.Finish:
			base.Finish(true);
			return;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[TsTaskTurnAndSit] 阶段切换出错";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurPhase", this.Phase);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		}
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x0001771C File Offset: 0x0001591C
	protected override void OnAbort()
	{
		if (this.Phase == TsTaskNpcSitOnChair.ETaskPhase.MoveNearby || this.Phase == TsTaskNpcSitOnChair.ETaskPhase.MoveClose || this.Phase == TsTaskNpcSitOnChair.ETaskPhase.MoveAway)
		{
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp == null)
			{
				return;
			}
			moveComp.StopMoveNew(null);
			return;
		}
		else
		{
			if (this.Phase != TsTaskNpcSitOnChair.ETaskPhase.TurnTo)
			{
				if (this.Phase == TsTaskNpcSitOnChair.ETaskPhase.PlayMontage)
				{
					if (this.NeedSetSeatMorph)
					{
						this.NeedSetSeatMorph = false;
						if (this.AnimComp != null)
						{
							PawnChairController chairController = this.ChairController;
							if (((chairController != null) ? chairController.Entity : null) != null)
							{
								AnimController.Instance.SetSeatMorph(this.ChairController.Entity, this.AnimComp.Entity.Id, 0.0);
							}
						}
					}
					Entity entity = this.Entity;
					BasePerformComponent basePerformComponent = (entity != null) ? entity.GetComponent<BasePerformComponent>() : null;
					if (this.PlayingMontage != -1)
					{
						if (basePerformComponent != null)
						{
							basePerformComponent.VolatileMontageStopByLoad(EPerformMode.Ecology, this.PlayingMontage, EStopMethod.BlendOut);
						}
						this.PlayingMontage = -1;
					}
				}
				return;
			}
			CharacterActorComponent character = this.Character;
			if (character == null)
			{
				return;
			}
			character.ClearInput(false, true);
			return;
		}
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x0001780B File Offset: 0x00015A0B
	protected override void OnClear()
	{
		this.Character = null;
		this.MovementMode = EMovementMode.MOVE_None;
		this.IsExecuteMoveNearby = false;
		this.IsExecuteMoveClose = false;
		this.IsExecuteTurnTo = false;
		this.IsExecutePlayMontage = false;
		this.IsExecuteMoveAway = false;
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00017840 File Offset: 0x00015A40
	private void ExecuteMoveNearby()
	{
		if (this.IsExecuteMoveNearby)
		{
			return;
		}
		this.IsExecuteMoveNearby = true;
		this.ChairController.Possess(this.Entity, false);
		Vector sitLocation = this.ChairController.GetSitLocation();
		this.ChairController.GetForwardDirection().Multiply(70.0, this.ChairNearbyPos);
		this.ChairNearbyPos.AdditionEqual(sitLocation);
		MoveCharacterPoint item = new MoveCharacterPoint
		{
			Index = 0,
			Position = this.ChairNearbyPos,
			MoveState = new EPatrolMoveState?(EPatrolMoveState.Walk),
			MoveSpeed = new float?((float)100)
		};
		List<MoveCharacterPoint> value = new List<MoveCharacterPoint>
		{
			item
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = value,
			Navigation = true,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Distance = new float?((float)5),
			Callback = delegate(ELevelEventState result)
			{
				BaseMoveComponent moveComp = this.MoveComp;
				if (moveComp != null)
				{
					moveComp.StopMoveNew(null);
				}
				this.Phase = TsTaskNpcSitOnChair.ETaskPhase.MoveClose;
			},
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveComp.MoveAlongPath(config, null);
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x0001794C File Offset: 0x00015B4C
	private void ExecuteMoveClose()
	{
		if (this.IsExecuteMoveClose)
		{
			return;
		}
		this.IsExecuteMoveClose = true;
		this.ChairController.Possess(this.Entity, false);
		this.ChairController.IgnoreCollision();
		Vector actorLocationProxy = this.Character.ActorLocationProxy;
		Vector sitLocation = this.ChairController.GetSitLocation();
		this.ChairSitPos.Set(sitLocation.X, sitLocation.Y, actorLocationProxy.Z);
		MoveCharacterPoint item = new MoveCharacterPoint
		{
			Index = 0,
			Position = this.ChairSitPos,
			MoveState = new EPatrolMoveState?(EPatrolMoveState.Walk),
			MoveSpeed = new float?((float)70)
		};
		List<MoveCharacterPoint> value = new List<MoveCharacterPoint>
		{
			item
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = value,
			Navigation = true,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Distance = new float?((float)5),
			Callback = delegate(ELevelEventState result)
			{
				BaseMoveComponent moveComp = this.MoveComp;
				if (moveComp != null)
				{
					moveComp.StopMoveNew(null);
				}
				this.Phase = TsTaskNpcSitOnChair.ETaskPhase.TurnTo;
			},
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveComp.MoveAlongPath(config, null);
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00017A60 File Offset: 0x00015C60
	private void ExecuteTurnTo()
	{
		if (!this.IsExecuteTurnTo)
		{
			this.IsExecuteTurnTo = true;
			this.ChairController.GetForwardDirection().Multiply(200.0, this.TempVec);
			this.TempVec.AdditionEqual(this.ChairNearbyPos);
			this.MovementMode = this.MoveComp.CharacterMovement.MovementMode;
			this.MoveComp.CharacterMovement.MovementMode = EMovementMode.MOVE_Walking;
			AiControllerLibrary.TurnToTarget(this.Character, this.TempVec, 200f, false, 0f);
			return;
		}
		if (GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.Character) < 10f)
		{
			this.MoveComp.CharacterMovement.MovementMode = this.MovementMode;
			this.Phase = TsTaskNpcSitOnChair.ETaskPhase.PlayMontage;
			return;
		}
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00017B38 File Offset: 0x00015D38
	private void ExecutePlayMontage()
	{
		if (this.IsExecutePlayMontage)
		{
			if (this.NeedSetSeatMorph && this.AnimComp != null)
			{
				PawnChairController chairController = this.ChairController;
				if (((chairController != null) ? chairController.Entity : null) != null)
				{
					UAnimInstance animInstance = this.AnimComp.GetAnimInstance();
					float num = (animInstance != null) ? animInstance.GetCurveValue(CharacterNameDefines.Instance.SEAT_MORPH) : 0f;
					AnimController.Instance.SetSeatMorph(this.ChairController.Entity, this.AnimComp.Entity.Id, (double)num);
				}
			}
			return;
		}
		this.IsExecutePlayMontage = true;
		PawnChairController chairController2 = this.ChairController;
		bool? flag;
		if (chairController2 == null)
		{
			flag = null;
		}
		else
		{
			Entity entity = chairController2.Entity;
			if (entity == null)
			{
				flag = null;
			}
			else
			{
				SceneItemProceduralMaterialComponent component = entity.GetComponent<SceneItemProceduralMaterialComponent>();
				flag = ((component != null) ? new bool?(component.HasCustomType(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair)) : null);
			}
		}
		bool? flag2 = flag;
		this.NeedSetSeatMorph = (flag2.GetValueOrDefault() && this.AnimComp != null);
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			animComp.SetLocationAndRotatorWithModelBuffer(this.ChairSitPos.ToUeVector(false), this.Character.ActorRotationProxy.ToUeRotator(), 200f, "TsTaskNpcSitOnChair.ExecuteTurnToFinish", ESetRotationPriority.Anim, true);
		}
		BasePerformComponent component2 = this.Entity.GetComponent<BasePerformComponent>();
		this.PlayingMontage = component2.VolatileMontagePlayByLoad(EPerformMode.Ecology, this.TsMontagePath, null, null, delegate(UAnimMontage montage, bool _)
		{
			if (montage != null)
			{
				this.Phase = TsTaskNpcSitOnChair.ETaskPhase.MoveAway;
				return;
			}
			base.FinishExecute(true);
		}, new float?(this.TsLoopDuration), new float?((float)this.TsRepeatTimes), new bool?(false), new bool?(false), new bool?(false));
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00017CBC File Offset: 0x00015EBC
	private void ExecuteMoveAway()
	{
		if (this.IsExecuteMoveAway)
		{
			return;
		}
		if (this.NeedSetSeatMorph)
		{
			this.NeedSetSeatMorph = false;
			if (this.AnimComp != null)
			{
				PawnChairController chairController = this.ChairController;
				if (((chairController != null) ? chairController.Entity : null) != null)
				{
					AnimController.Instance.SetSeatMorph(this.ChairController.Entity, this.AnimComp.Entity.Id, 0.0);
				}
			}
		}
		this.IsExecuteMoveAway = true;
		this.ChairController.UnPossess(this.Entity);
		MoveCharacterPoint item = new MoveCharacterPoint
		{
			Index = 0,
			Position = this.ChairNearbyPos,
			MoveState = new EPatrolMoveState?(EPatrolMoveState.Walk),
			MoveSpeed = new float?((float)70)
		};
		List<MoveCharacterPoint> value = new List<MoveCharacterPoint>
		{
			item
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = value,
			Navigation = true,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Distance = new float?((float)5),
			Callback = delegate(ELevelEventState result)
			{
				this.MoveComp.StopMoveNew(null);
				this.ChairController.ResetCollision();
				this.ChairController.UnPossess(this.Entity);
				this.Phase = TsTaskNpcSitOnChair.ETaskPhase.Finish;
			},
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveComp.MoveAlongPath(config, null);
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00017DE6 File Offset: 0x00015FE6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcSitOnChair._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcSitOnChair.TsTaskNpcSitOnChair_C");
		}
		return TsTaskNpcSitOnChair._ClassPtr;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00017E0C File Offset: 0x0001600C
	public TsTaskNpcSitOnChair() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcSitOnChair.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00017E34 File Offset: 0x00016034
	[NullableContext(1)]
	public TsTaskNpcSitOnChair(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcSitOnChair.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00017E67 File Offset: 0x00016067
	protected TsTaskNpcSitOnChair(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00017E84 File Offset: 0x00016084
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00017EB4 File Offset: 0x000160B4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400034D RID: 845
	private const int TOLERANCE = 10;

	// Token: 0x0400034E RID: 846
	private const int TURN_SPEED = 200;

	// Token: 0x0400034F RID: 847
	private const int NEARBY_CHAIR_OFFSET = 70;

	// Token: 0x04000350 RID: 848
	private const int MOVE_TO_CHAIR_SPEED = 70;

	// Token: 0x04000351 RID: 849
	private const int MOVE_TO_NEARBY_CHAIR_SPEED = 100;

	// Token: 0x04000352 RID: 850
	private const int MOVE_TO_CHAIR_DISTANCE_TOLERANCE = 5;

	// Token: 0x04000353 RID: 851
	private const int MODEL_BUFFER_SMOOTH_TIME = 200;

	// Token: 0x04000354 RID: 852
	private EMovementMode MovementMode;

	// Token: 0x04000355 RID: 853
	private int PlayingMontage = -1;

	// Token: 0x04000356 RID: 854
	private TsTaskNpcSitOnChair.ETaskPhase PhaseInternal;

	// Token: 0x04000357 RID: 855
	private bool IsExecuteMoveNearby;

	// Token: 0x04000358 RID: 856
	private bool IsExecuteMoveClose;

	// Token: 0x04000359 RID: 857
	private bool IsExecuteTurnTo;

	// Token: 0x0400035A RID: 858
	private bool IsExecutePlayMontage;

	// Token: 0x0400035B RID: 859
	private bool NeedSetSeatMorph;

	// Token: 0x0400035C RID: 860
	private bool IsExecuteMoveAway;

	// Token: 0x0400035D RID: 861
	private Entity Entity;

	// Token: 0x0400035E RID: 862
	private CharacterActorComponent Character;

	// Token: 0x0400035F RID: 863
	private BaseMoveComponent MoveComp;

	// Token: 0x04000360 RID: 864
	private CharacterAnimationComponent AnimComp;

	// Token: 0x04000361 RID: 865
	private PawnChairController ChairController;

	// Token: 0x04000362 RID: 866
	private bool IsInitTsVariables;

	// Token: 0x04000363 RID: 867
	private int TsChairEntityId;

	// Token: 0x04000364 RID: 868
	[Nullable(1)]
	private string TsMontagePath = "";

	// Token: 0x04000365 RID: 869
	private float TsLoopDuration;

	// Token: 0x04000366 RID: 870
	private int TsRepeatTimes;

	// Token: 0x04000367 RID: 871
	private Vector ChairNearbyPos;

	// Token: 0x04000368 RID: 872
	private Vector ChairSitPos;

	// Token: 0x04000369 RID: 873
	private Vector TempVec;

	// Token: 0x0400036A RID: 874
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcSitOnChair.TsTaskNpcSitOnChair_C";

	// Token: 0x0400036B RID: 875
	private static IntPtr _ClassPtr;

	// Token: 0x0400036C RID: 876
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400036D RID: 877
	private static int __PropertyOffset_ChairEntityId;

	// Token: 0x0400036E RID: 878
	private static int __PropertyOffset_MontagePath;

	// Token: 0x0400036F RID: 879
	private static int __PropertyOffset_LoopDuration;

	// Token: 0x04000370 RID: 880
	private static int __PropertyOffset_RepeatTimes;

	// Token: 0x020064F7 RID: 25847
	[NullableContext(0)]
	private enum ETaskPhase
	{
		// Token: 0x040218D4 RID: 137428
		None,
		// Token: 0x040218D5 RID: 137429
		Execute,
		// Token: 0x040218D6 RID: 137430
		MoveNearby,
		// Token: 0x040218D7 RID: 137431
		MoveClose,
		// Token: 0x040218D8 RID: 137432
		TurnTo,
		// Token: 0x040218D9 RID: 137433
		PlayMontage,
		// Token: 0x040218DA RID: 137434
		MoveAway,
		// Token: 0x040218DB RID: 137435
		Finish
	}
}
