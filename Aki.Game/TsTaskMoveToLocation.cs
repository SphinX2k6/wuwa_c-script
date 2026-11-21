using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000A9 RID: 169
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskMoveToLocation.TsTaskMoveToLocation_C")]
public class TsTaskMoveToLocation : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002FA1B File Offset: 0x0002DC1B
	// (set) Token: 0x06000937 RID: 2359 RVA: 0x0002FA2B File Offset: 0x0002DC2B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002FA3C File Offset: 0x0002DC3C
	// (set) Token: 0x06000939 RID: 2361 RVA: 0x0002FA4C File Offset: 0x0002DC4C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NavigationOn
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_NavigationOn) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_NavigationOn) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002FA5D File Offset: 0x0002DC5D
	// (set) Token: 0x0600093B RID: 2363 RVA: 0x0002FA71 File Offset: 0x0002DC71
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardLocation
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskMoveToLocation.__PropertyOffset_BlackboardLocation)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskMoveToLocation.__PropertyOffset_BlackboardLocation)), value);
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002FA86 File Offset: 0x0002DC86
	// (set) Token: 0x0600093D RID: 2365 RVA: 0x0002FA96 File Offset: 0x0002DC96
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EndDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_EndDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_EndDistance) = value;
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x0600093E RID: 2366 RVA: 0x0002FAA7 File Offset: 0x0002DCA7
	// (set) Token: 0x0600093F RID: 2367 RVA: 0x0002FAB7 File Offset: 0x0002DCB7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnToSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_TurnToSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_TurnToSpeed) = value;
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000940 RID: 2368 RVA: 0x0002FAC8 File Offset: 0x0002DCC8
	// (set) Token: 0x06000941 RID: 2369 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OpenDebugNode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_OpenDebugNode) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_OpenDebugNode) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06000942 RID: 2370 RVA: 0x0002FAE9 File Offset: 0x0002DCE9
	// (set) Token: 0x06000943 RID: 2371 RVA: 0x0002FAF9 File Offset: 0x0002DCF9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int LimitTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_LimitTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_LimitTime) = value;
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000944 RID: 2372 RVA: 0x0002FB0A File Offset: 0x0002DD0A
	// (set) Token: 0x06000945 RID: 2373 RVA: 0x0002FB1A File Offset: 0x0002DD1A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsFly
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_IsFly) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_IsFly) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000946 RID: 2374 RVA: 0x0002FB2B File Offset: 0x0002DD2B
	// (set) Token: 0x06000947 RID: 2375 RVA: 0x0002FB3B File Offset: 0x0002DD3B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EndDistanceWhenAllPoints
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_EndDistanceWhenAllPoints) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_EndDistanceWhenAllPoints) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x0002FB4C File Offset: 0x0002DD4C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveState = this.MoveState;
			this.TsNavigationOn = this.NavigationOn;
			this.TsBlackboardLocation = this.BlackboardLocation;
			this.TsOpenDebugNode = this.OpenDebugNode;
			this.TsLimitTime = (double)this.LimitTime;
			this.TsIsFly = this.IsFly;
			this.TsEndDistanceWhenAllPoints = this.EndDistanceWhenAllPoints;
			this.TsTurnToSpeed = this.TurnToSpeed;
		}
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskMoveToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskMoveToLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600094A RID: 2378 RVA: 0x0002FC80 File Offset: 0x0002DE80
	[NullableContext(2)]
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
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Entity entity = charActorComp.Entity;
		global::Vector vector = global::Vector.Create();
		if (this.TsBlackboardLocation == "_currentPlayer")
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			global::Vector vector2;
			if (baseCharacter == null)
			{
				vector2 = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				vector2 = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
			}
			global::Vector vector3 = vector2;
			if (vector3 != null)
			{
				vector.DeepCopy(vector3);
			}
		}
		else
		{
			Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(entity.Id, this.TsBlackboardLocation);
			if (vectorValueByEntity != null)
			{
				vector.DeepCopy(vectorValueByEntity);
			}
		}
		if (vector.IsNearlyZero(9.999999747378752E-05))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "TsTaskMoveToLocation没有获取到目标坐标";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BehaviorTree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BlackboardLocation", this.TsBlackboardLocation);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.Finish(false);
			return;
		}
		if (this.HandleMoveEnd == null)
		{
			this.HandleMoveEnd = delegate(ELevelEventState result)
			{
				if (result == ELevelEventState.Success)
				{
					base.Finish(true);
					return;
				}
				base.Finish(false);
			};
		}
		this.MoveComp = entity.GetComponent<BaseMoveComponent>();
		MoveCharacterPoint moveCharacterPoint = new MoveCharacterPoint
		{
			Index = 0,
			Position = vector,
			MoveState = new EPatrolMoveState?((EPatrolMoveState)this.TsMoveState)
		};
		float scaledRadius = charActorComp.ScaledRadius;
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = new MoveCharacterPoint[]
			{
				moveCharacterPoint
			},
			Navigation = this.TsNavigationOn,
			IsFly = this.TsIsFly,
			DebugMode = this.TsOpenDebugNode,
			Loop = false,
			Callback = this.HandleMoveEnd,
			ReturnFalseWhenNavigationFailed = true,
			Distance = new float?(this.EndDistance + scaledRadius),
			TurnSpeed = new float?(this.TsTurnToSpeed),
			EndDistanceAllPoints = new bool?(this.TsEndDistanceWhenAllPoints)
		};
		this.TsMoveHandleId = this.MoveComp.MoveAlongPath(config, "TsTaskMoveToLocation.ReceiveExecuteAI");
		if (this.TsLimitTime > -1.0)
		{
			this.EndTime = Time.Instance.WorldTime + this.TsLimitTime;
		}
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x0002FF04 File Offset: 0x0002E104
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskMoveToLocation) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskMoveToLocation.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600094C RID: 2380 RVA: 0x0002FFBC File Offset: 0x0002E1BC
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!(ownerController is TsAiController))
		{
			base.Finish(false);
			return;
		}
		if (this.TsLimitTime > -1.0 && this.EndTime < Time.Instance.WorldTime)
		{
			base.Finish(true);
		}
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x0002FFF8 File Offset: 0x0002E1F8
	protected override void OnClear()
	{
		if (this.MoveComp != null)
		{
			this.MoveComp.StopMoveByHandleId(this.TsMoveHandleId, "TsTaskMoveToLocation.OnClear");
			this.MoveComp = null;
		}
		this.EndTime = 0.0;
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x0003002E File Offset: 0x0002E22E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskMoveToLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskMoveToLocation.TsTaskMoveToLocation_C");
		}
		return TsTaskMoveToLocation._ClassPtr;
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00030054 File Offset: 0x0002E254
	public TsTaskMoveToLocation() : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x0003007C File Offset: 0x0002E27C
	public TsTaskMoveToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x000300AF File Offset: 0x0002E2AF
	protected TsTaskMoveToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x000300C4 File Offset: 0x0002E2C4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x000300F4 File Offset: 0x0002E2F4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000719 RID: 1817
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x0400071A RID: 1818
	private bool IsInitTsVariables;

	// Token: 0x0400071B RID: 1819
	private int TsMoveState;

	// Token: 0x0400071C RID: 1820
	private bool TsNavigationOn;

	// Token: 0x0400071D RID: 1821
	private string TsBlackboardLocation = "";

	// Token: 0x0400071E RID: 1822
	private bool TsOpenDebugNode;

	// Token: 0x0400071F RID: 1823
	private double TsLimitTime;

	// Token: 0x04000720 RID: 1824
	private bool TsIsFly;

	// Token: 0x04000721 RID: 1825
	private bool TsEndDistanceWhenAllPoints;

	// Token: 0x04000722 RID: 1826
	private float TsTurnToSpeed;

	// Token: 0x04000723 RID: 1827
	private double EndTime;

	// Token: 0x04000724 RID: 1828
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x04000725 RID: 1829
	private int TsMoveHandleId;

	// Token: 0x04000726 RID: 1830
	[Nullable(2)]
	private Action<ELevelEventState> HandleMoveEnd;

	// Token: 0x04000727 RID: 1831
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskMoveToLocation.TsTaskMoveToLocation_C";

	// Token: 0x04000728 RID: 1832
	private static IntPtr _ClassPtr;

	// Token: 0x04000729 RID: 1833
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400072A RID: 1834
	private static int __PropertyOffset_MoveState;

	// Token: 0x0400072B RID: 1835
	private static int __PropertyOffset_NavigationOn;

	// Token: 0x0400072C RID: 1836
	private static int __PropertyOffset_BlackboardLocation;

	// Token: 0x0400072D RID: 1837
	private static int __PropertyOffset_EndDistance;

	// Token: 0x0400072E RID: 1838
	private static int __PropertyOffset_TurnToSpeed;

	// Token: 0x0400072F RID: 1839
	private static int __PropertyOffset_OpenDebugNode;

	// Token: 0x04000730 RID: 1840
	private static int __PropertyOffset_LimitTime;

	// Token: 0x04000731 RID: 1841
	private static int __PropertyOffset_IsFly;

	// Token: 0x04000732 RID: 1842
	private static int __PropertyOffset_EndDistanceWhenAllPoints;
}
