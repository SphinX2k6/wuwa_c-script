using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200006C RID: 108
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcMoveToChair.TsTaskNpcMoveToChair_C")]
public class TsTaskNpcMoveToChair : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000BA RID: 186
	// (get) Token: 0x0600049F RID: 1183 RVA: 0x00015F75 File Offset: 0x00014175
	// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00015F85 File Offset: 0x00014185
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ChairEntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcMoveToChair.__PropertyOffset_ChairEntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcMoveToChair.__PropertyOffset_ChairEntityId) = value;
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00015F96 File Offset: 0x00014196
	// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00015FA6 File Offset: 0x000141A6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool QuickFinish
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcMoveToChair.__PropertyOffset_QuickFinish) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcMoveToChair.__PropertyOffset_QuickFinish) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00015FB7 File Offset: 0x000141B7
	// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00015FBF File Offset: 0x000141BF
	private TsTaskNpcMoveToChair.ETaskPhase Phase
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

	// Token: 0x060004A5 RID: 1189 RVA: 0x00015FD4 File Offset: 0x000141D4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsChairEntityId = this.ChairEntityId;
			this.TsQuickFinish = this.QuickFinish;
			this.ChairNearbyPos = Vector.Create();
			this.ChairSitPos = Vector.Create();
			this.TempVec = Vector.Create();
			this.TempRotator = Rotator.Create();
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x0001603C File Offset: 0x0001423C
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
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
			string message2 = "[TsTaskNpcMoveToChair]MoveComp不合法";
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
		this.ChairController.Possess(this.Entity, false);
		this.ChairController.IgnoreCollision();
		this.IsPossessed = true;
		if (this.TsQuickFinish)
		{
			Vector actorLocationProxy = this.Character.ActorLocationProxy;
			Vector sitLocation = this.ChairController.GetSitLocation();
			this.ChairSitPos.Set(sitLocation.X, sitLocation.Y, actorLocationProxy.Z);
			Vector forwardDirection = this.ChairController.GetForwardDirection();
			MathUtils.Instance.VectorToRotator(forwardDirection, this.TempRotator);
			this.Character.SetActorLocationAndRotation(this.ChairSitPos.ToUeVector(false), this.TempRotator.ToUeRotator(), "TsTaskNpcMoveToChair.QuickFinish", false, null);
			this.Character.ClearInput(true, true);
			this.Character.SetInputFacing(forwardDirection, false);
			this.ReleaseChair();
			base.FinishExecute(true);
			return;
		}
		this.Phase = TsTaskNpcMoveToChair.ETaskPhase.Execute;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x000162DC File Offset: 0x000144DC
	[UFunction(EFunctionFlags.FUNC_None)]
	public override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.TsQuickFinish)
		{
			base.FinishExecute(true);
			return;
		}
		switch (this.Phase)
		{
		case TsTaskNpcMoveToChair.ETaskPhase.Execute:
			this.Phase = TsTaskNpcMoveToChair.ETaskPhase.MoveNearby;
			return;
		case TsTaskNpcMoveToChair.ETaskPhase.MoveNearby:
			this.ExecuteMoveNearby();
			return;
		case TsTaskNpcMoveToChair.ETaskPhase.MoveClose:
			this.ExecuteMoveClose();
			return;
		case TsTaskNpcMoveToChair.ETaskPhase.TurnTo:
			this.ExecuteTurnTo();
			return;
		case TsTaskNpcMoveToChair.ETaskPhase.Finish:
			this.ReleaseChair();
			base.Finish(true);
			return;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[TsTaskNpcMoveToChair] 阶段切换出错";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurPhase", this.Phase);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		}
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x0001637C File Offset: 0x0001457C
	protected override void OnAbort()
	{
		if (this.Phase == TsTaskNpcMoveToChair.ETaskPhase.MoveNearby || this.Phase == TsTaskNpcMoveToChair.ETaskPhase.MoveClose)
		{
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.StopMoveNew(null);
			}
		}
		else if (this.Phase == TsTaskNpcMoveToChair.ETaskPhase.TurnTo)
		{
			CharacterActorComponent character = this.Character;
			if (character != null)
			{
				character.ClearInput(false, true);
			}
		}
		this.ReleaseChair();
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x000163D1 File Offset: 0x000145D1
	protected override void OnClear()
	{
		this.Character = null;
		this.MovementMode = EMovementMode.MOVE_None;
		this.IsExecuteMoveNearby = false;
		this.IsExecuteMoveClose = false;
		this.IsExecuteTurnTo = false;
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x000163F6 File Offset: 0x000145F6
	private void ReleaseChair()
	{
		if (this.IsPossessed && this.ChairController != null)
		{
			this.ChairController.ResetCollision();
			this.ChairController.UnPossess(this.Entity);
			this.IsPossessed = false;
		}
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0001642C File Offset: 0x0001462C
	private void ExecuteMoveNearby()
	{
		if (this.IsExecuteMoveNearby)
		{
			return;
		}
		this.IsExecuteMoveNearby = true;
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
				this.Phase = TsTaskNpcMoveToChair.ETaskPhase.MoveClose;
			},
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveComp.MoveAlongPath(config, null);
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00016524 File Offset: 0x00014724
	private void ExecuteMoveClose()
	{
		if (this.IsExecuteMoveClose)
		{
			return;
		}
		this.IsExecuteMoveClose = true;
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
				this.Phase = TsTaskNpcMoveToChair.ETaskPhase.TurnTo;
			},
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveComp.MoveAlongPath(config, null);
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x0001661C File Offset: 0x0001481C
	private void ExecuteTurnTo()
	{
		if (GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.Character) < 10f)
		{
			this.MoveComp.CharacterMovement.MovementMode = this.MovementMode;
			this.Phase = TsTaskNpcMoveToChair.ETaskPhase.Finish;
			return;
		}
		if (this.IsExecuteTurnTo)
		{
			return;
		}
		this.IsExecuteTurnTo = true;
		this.ChairController.GetForwardDirection().Multiply(200.0, this.TempVec);
		this.TempVec.AdditionEqual(this.ChairNearbyPos);
		this.MovementMode = this.MoveComp.CharacterMovement.MovementMode;
		this.MoveComp.CharacterMovement.MovementMode = EMovementMode.MOVE_Walking;
		AiControllerLibrary.TurnToTarget(this.Character, this.TempVec, 200f, false, 0f);
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x000166F2 File Offset: 0x000148F2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcMoveToChair._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcMoveToChair.TsTaskNpcMoveToChair_C");
		}
		return TsTaskNpcMoveToChair._ClassPtr;
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00016718 File Offset: 0x00014918
	public TsTaskNpcMoveToChair() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcMoveToChair.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00016740 File Offset: 0x00014940
	[NullableContext(1)]
	public TsTaskNpcMoveToChair(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcMoveToChair.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00016773 File Offset: 0x00014973
	protected TsTaskNpcMoveToChair(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x0001677C File Offset: 0x0001497C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x000167AC File Offset: 0x000149AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400032F RID: 815
	private const int TOLERANCE = 10;

	// Token: 0x04000330 RID: 816
	private const int TURN_SPEED = 200;

	// Token: 0x04000331 RID: 817
	private const int NEARBY_CHAIR_OFFSET = 70;

	// Token: 0x04000332 RID: 818
	private const int MOVE_TO_CHAIR_SPEED = 70;

	// Token: 0x04000333 RID: 819
	private const int MOVE_TO_NEARBY_CHAIR_SPEED = 100;

	// Token: 0x04000334 RID: 820
	private const int MOVE_TO_CHAIR_DISTANCE_TOLERANCE = 5;

	// Token: 0x04000335 RID: 821
	private EMovementMode MovementMode;

	// Token: 0x04000336 RID: 822
	private TsTaskNpcMoveToChair.ETaskPhase PhaseInternal;

	// Token: 0x04000337 RID: 823
	private bool IsExecuteMoveNearby;

	// Token: 0x04000338 RID: 824
	private bool IsExecuteMoveClose;

	// Token: 0x04000339 RID: 825
	private bool IsExecuteTurnTo;

	// Token: 0x0400033A RID: 826
	private bool IsPossessed;

	// Token: 0x0400033B RID: 827
	private Entity Entity;

	// Token: 0x0400033C RID: 828
	private CharacterActorComponent Character;

	// Token: 0x0400033D RID: 829
	private BaseMoveComponent MoveComp;

	// Token: 0x0400033E RID: 830
	private PawnChairController ChairController;

	// Token: 0x0400033F RID: 831
	private bool IsInitTsVariables;

	// Token: 0x04000340 RID: 832
	private int TsChairEntityId;

	// Token: 0x04000341 RID: 833
	private bool TsQuickFinish;

	// Token: 0x04000342 RID: 834
	private Vector ChairNearbyPos;

	// Token: 0x04000343 RID: 835
	private Vector ChairSitPos;

	// Token: 0x04000344 RID: 836
	private Vector TempVec;

	// Token: 0x04000345 RID: 837
	private Rotator TempRotator;

	// Token: 0x04000346 RID: 838
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcMoveToChair.TsTaskNpcMoveToChair_C";

	// Token: 0x04000347 RID: 839
	private static IntPtr _ClassPtr;

	// Token: 0x04000348 RID: 840
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000349 RID: 841
	private static int __PropertyOffset_ChairEntityId;

	// Token: 0x0400034A RID: 842
	private static int __PropertyOffset_QuickFinish;

	// Token: 0x02007373 RID: 29555
	[NullableContext(0)]
	private enum ETaskPhase
	{
		// Token: 0x040265D7 RID: 157143
		None,
		// Token: 0x040265D8 RID: 157144
		Execute,
		// Token: 0x040265D9 RID: 157145
		MoveNearby,
		// Token: 0x040265DA RID: 157146
		MoveClose,
		// Token: 0x040265DB RID: 157147
		TurnTo,
		// Token: 0x040265DC RID: 157148
		Finish
	}
}
