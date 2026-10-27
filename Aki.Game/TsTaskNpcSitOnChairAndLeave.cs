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

// Token: 0x0200006E RID: 110
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcSitOnChairAndLeave.TsTaskNpcSitOnChairAndLeave_C")]
public class TsTaskNpcSitOnChairAndLeave : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000175A7 File Offset: 0x000157A7
	// (set) Token: 0x060004D7 RID: 1239 RVA: 0x000175B7 File Offset: 0x000157B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ChairEntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_ChairEntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_ChairEntityId) = value;
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060004D8 RID: 1240 RVA: 0x000175C8 File Offset: 0x000157C8
	// (set) Token: 0x060004D9 RID: 1241 RVA: 0x000175DC File Offset: 0x000157DC
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string MontagePath
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_MontagePath)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_MontagePath)), value);
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060004DA RID: 1242 RVA: 0x000175F1 File Offset: 0x000157F1
	// (set) Token: 0x060004DB RID: 1243 RVA: 0x00017601 File Offset: 0x00015801
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LoopDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_LoopDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_LoopDuration) = value;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060004DC RID: 1244 RVA: 0x00017612 File Offset: 0x00015812
	// (set) Token: 0x060004DD RID: 1245 RVA: 0x00017622 File Offset: 0x00015822
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int RepeatTimes
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_RepeatTimes);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_RepeatTimes) = value;
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060004DE RID: 1246 RVA: 0x00017633 File Offset: 0x00015833
	// (set) Token: 0x060004DF RID: 1247 RVA: 0x00017643 File Offset: 0x00015843
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EndOnBlendOut
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_EndOnBlendOut) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_EndOnBlendOut) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00017654 File Offset: 0x00015854
	// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00017664 File Offset: 0x00015864
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SkipLeave
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_SkipLeave) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcSitOnChairAndLeave.__PropertyOffset_SkipLeave) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00017675 File Offset: 0x00015875
	// (set) Token: 0x060004E3 RID: 1251 RVA: 0x0001767D File Offset: 0x0001587D
	private TsTaskNpcSitOnChairAndLeave.ETaskPhase Phase
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

	// Token: 0x060004E4 RID: 1252 RVA: 0x00017690 File Offset: 0x00015890
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsChairEntityId = this.ChairEntityId;
			this.TsMontagePath = this.MontagePath;
			this.TsLoopDuration = this.LoopDuration;
			this.TsRepeatTimes = this.RepeatTimes;
			this.TsEndOnBlendOut = this.EndOnBlendOut;
			this.TsSkipLeave = this.SkipLeave;
			this.ChairNearbyPos = Vector.Create();
			this.ChairSitPos = Vector.Create();
		}
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00017714 File Offset: 0x00015914
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
			string message2 = "[TsTaskNpcSitOnChairAndLeave]MoveComp不合法";
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
			string message3 = "[TsTaskNpcSitOnChairAndLeave]无效的Montage路径";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", this.Character.CreatureData.GetPbDataId());
			instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			base.FinishExecute(true);
			return;
		}
		this.ChairController.Possess(this.Entity, false);
		this.ChairController.IgnoreCollision();
		this.IsPossessed = true;
		Vector actorLocationProxy = this.Character.ActorLocationProxy;
		Vector sitLocation = this.ChairController.GetSitLocation();
		this.ChairSitPos.Set(sitLocation.X, sitLocation.Y, actorLocationProxy.Z);
		this.ChairController.GetForwardDirection().Multiply(70.0, this.ChairNearbyPos);
		this.ChairNearbyPos.AdditionEqual(sitLocation);
		this.Phase = TsTaskNpcSitOnChairAndLeave.ETaskPhase.Execute;
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x000179F0 File Offset: 0x00015BF0
	[UFunction(EFunctionFlags.FUNC_None)]
	public override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		switch (this.Phase)
		{
		case TsTaskNpcSitOnChairAndLeave.ETaskPhase.Execute:
			this.Phase = TsTaskNpcSitOnChairAndLeave.ETaskPhase.PlayMontage;
			return;
		case TsTaskNpcSitOnChairAndLeave.ETaskPhase.PlayMontage:
			this.ExecutePlayMontage();
			return;
		case TsTaskNpcSitOnChairAndLeave.ETaskPhase.MoveAway:
			this.ExecuteMoveAway();
			return;
		case TsTaskNpcSitOnChairAndLeave.ETaskPhase.Finish:
			this.ReleaseChair();
			base.Finish(true);
			return;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[TsTaskNpcSitOnChairAndLeave] 阶段切换出错";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurPhase", this.Phase);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		}
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00017A74 File Offset: 0x00015C74
	protected override void OnAbort()
	{
		if (this.Phase == TsTaskNpcSitOnChairAndLeave.ETaskPhase.MoveAway)
		{
			BaseMoveComponent moveComp = this.MoveComp;
			if (moveComp != null)
			{
				moveComp.StopMoveNew(null);
			}
		}
		else if (this.Phase == TsTaskNpcSitOnChairAndLeave.ETaskPhase.PlayMontage)
		{
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
		this.ReleaseChair();
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00017AE1 File Offset: 0x00015CE1
	protected override void OnClear()
	{
		this.Character = null;
		this.IsExecutePlayMontage = false;
		this.IsExecuteMoveAway = false;
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00017AF8 File Offset: 0x00015CF8
	private void ReleaseChair()
	{
		if (this.IsPossessed && this.ChairController != null)
		{
			this.ChairController.ResetCollision();
			this.ChairController.UnPossess(this.Entity);
			this.IsPossessed = false;
		}
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00017B30 File Offset: 0x00015D30
	private void ExecutePlayMontage()
	{
		if (this.IsExecutePlayMontage)
		{
			return;
		}
		this.IsExecutePlayMontage = true;
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			animComp.SetLocationAndRotatorWithModelBuffer(this.ChairSitPos.ToUeVector(false), this.Character.ActorRotationProxy.ToUeRotator(), 200f, "TsTaskNpcSitOnChairAndLeave.ExecutePlayMontage", ESetRotationPriority.Anim, true);
		}
		BasePerformComponent component = this.Entity.GetComponent<BasePerformComponent>();
		this.PlayingMontage = component.VolatileMontagePlayByLoad(EPerformMode.Ecology, this.TsMontagePath, null, null, delegate(UAnimMontage montage, bool _)
		{
			if (montage != null)
			{
				this.Phase = (this.TsSkipLeave ? TsTaskNpcSitOnChairAndLeave.ETaskPhase.Finish : TsTaskNpcSitOnChairAndLeave.ETaskPhase.MoveAway);
				return;
			}
			base.FinishExecute(true);
		}, new float?(this.TsLoopDuration), new float?((float)this.TsRepeatTimes), new bool?(false), new bool?(false), new bool?(this.TsEndOnBlendOut));
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00017BE4 File Offset: 0x00015DE4
	private void ExecuteMoveAway()
	{
		if (this.IsExecuteMoveAway)
		{
			return;
		}
		this.IsExecuteMoveAway = true;
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
				this.Phase = TsTaskNpcSitOnChairAndLeave.ETaskPhase.Finish;
			},
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveComp.MoveAlongPath(config, null);
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00017CA3 File Offset: 0x00015EA3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcSitOnChairAndLeave._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcSitOnChairAndLeave.TsTaskNpcSitOnChairAndLeave_C");
		}
		return TsTaskNpcSitOnChairAndLeave._ClassPtr;
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00017CC8 File Offset: 0x00015EC8
	public TsTaskNpcSitOnChairAndLeave() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcSitOnChairAndLeave.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00017CF0 File Offset: 0x00015EF0
	[NullableContext(1)]
	public TsTaskNpcSitOnChairAndLeave(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcSitOnChairAndLeave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00017D23 File Offset: 0x00015F23
	protected TsTaskNpcSitOnChairAndLeave(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00017D40 File Offset: 0x00015F40
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00017D70 File Offset: 0x00015F70
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400036F RID: 879
	private const int NEARBY_CHAIR_OFFSET = 70;

	// Token: 0x04000370 RID: 880
	private const int MOVE_TO_CHAIR_SPEED = 70;

	// Token: 0x04000371 RID: 881
	private const int MOVE_TO_CHAIR_DISTANCE_TOLERANCE = 5;

	// Token: 0x04000372 RID: 882
	private const int MODEL_BUFFER_SMOOTH_TIME = 200;

	// Token: 0x04000373 RID: 883
	private int PlayingMontage = -1;

	// Token: 0x04000374 RID: 884
	private TsTaskNpcSitOnChairAndLeave.ETaskPhase PhaseInternal;

	// Token: 0x04000375 RID: 885
	private bool IsExecutePlayMontage;

	// Token: 0x04000376 RID: 886
	private bool IsExecuteMoveAway;

	// Token: 0x04000377 RID: 887
	private bool IsPossessed;

	// Token: 0x04000378 RID: 888
	private Entity Entity;

	// Token: 0x04000379 RID: 889
	private CharacterActorComponent Character;

	// Token: 0x0400037A RID: 890
	private BaseMoveComponent MoveComp;

	// Token: 0x0400037B RID: 891
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400037C RID: 892
	private PawnChairController ChairController;

	// Token: 0x0400037D RID: 893
	private bool IsInitTsVariables;

	// Token: 0x0400037E RID: 894
	private int TsChairEntityId;

	// Token: 0x0400037F RID: 895
	[Nullable(1)]
	private string TsMontagePath = "";

	// Token: 0x04000380 RID: 896
	private float TsLoopDuration;

	// Token: 0x04000381 RID: 897
	private int TsRepeatTimes;

	// Token: 0x04000382 RID: 898
	private bool TsEndOnBlendOut;

	// Token: 0x04000383 RID: 899
	private bool TsSkipLeave;

	// Token: 0x04000384 RID: 900
	private Vector ChairNearbyPos;

	// Token: 0x04000385 RID: 901
	private Vector ChairSitPos;

	// Token: 0x04000386 RID: 902
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcSitOnChairAndLeave.TsTaskNpcSitOnChairAndLeave_C";

	// Token: 0x04000387 RID: 903
	private static IntPtr _ClassPtr;

	// Token: 0x04000388 RID: 904
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000389 RID: 905
	private static int __PropertyOffset_ChairEntityId;

	// Token: 0x0400038A RID: 906
	private static int __PropertyOffset_MontagePath;

	// Token: 0x0400038B RID: 907
	private static int __PropertyOffset_LoopDuration;

	// Token: 0x0400038C RID: 908
	private static int __PropertyOffset_RepeatTimes;

	// Token: 0x0400038D RID: 909
	private static int __PropertyOffset_EndOnBlendOut;

	// Token: 0x0400038E RID: 910
	private static int __PropertyOffset_SkipLeave;

	// Token: 0x02007375 RID: 29557
	[NullableContext(0)]
	private enum ETaskPhase
	{
		// Token: 0x040265E7 RID: 157159
		None,
		// Token: 0x040265E8 RID: 157160
		Execute,
		// Token: 0x040265E9 RID: 157161
		PlayMontage,
		// Token: 0x040265EA RID: 157162
		MoveAway,
		// Token: 0x040265EB RID: 157163
		Finish
	}
}
