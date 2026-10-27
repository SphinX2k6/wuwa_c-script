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
	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002EA7B File Offset: 0x0002CC7B
	// (set) Token: 0x06000933 RID: 2355 RVA: 0x0002EA8B File Offset: 0x0002CC8B
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

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002EA9C File Offset: 0x0002CC9C
	// (set) Token: 0x06000935 RID: 2357 RVA: 0x0002EAAC File Offset: 0x0002CCAC
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

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002EABD File Offset: 0x0002CCBD
	// (set) Token: 0x06000937 RID: 2359 RVA: 0x0002EAD1 File Offset: 0x0002CCD1
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

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002EAE6 File Offset: 0x0002CCE6
	// (set) Token: 0x06000939 RID: 2361 RVA: 0x0002EAF6 File Offset: 0x0002CCF6
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

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002EB07 File Offset: 0x0002CD07
	// (set) Token: 0x0600093B RID: 2363 RVA: 0x0002EB17 File Offset: 0x0002CD17
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskMoveToLocation.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002EB28 File Offset: 0x0002CD28
	// (set) Token: 0x0600093D RID: 2365 RVA: 0x0002EB38 File Offset: 0x0002CD38
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

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x0600093E RID: 2366 RVA: 0x0002EB49 File Offset: 0x0002CD49
	// (set) Token: 0x0600093F RID: 2367 RVA: 0x0002EB59 File Offset: 0x0002CD59
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

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000940 RID: 2368 RVA: 0x0002EB6A File Offset: 0x0002CD6A
	// (set) Token: 0x06000941 RID: 2369 RVA: 0x0002EB7A File Offset: 0x0002CD7A
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

	// Token: 0x06000942 RID: 2370 RVA: 0x0002EB8C File Offset: 0x0002CD8C
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
		}
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x0002EBF8 File Offset: 0x0002CDF8
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

	// Token: 0x06000944 RID: 2372 RVA: 0x0002EC94 File Offset: 0x0002CE94
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
			Distance = new float?(this.EndDistance + scaledRadius)
		};
		this.TsMoveHandleId = this.MoveComp.MoveAlongPath(config, "TsTaskMoveToLocation.ReceiveExecuteAI");
		if (this.TsLimitTime > -1.0)
		{
			this.EndTime = Time.Instance.WorldTime + this.TsLimitTime;
		}
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x0002EEF4 File Offset: 0x0002D0F4
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

	// Token: 0x06000946 RID: 2374 RVA: 0x0002EF94 File Offset: 0x0002D194
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

	// Token: 0x06000947 RID: 2375 RVA: 0x0002EFD0 File Offset: 0x0002D1D0
	protected override void OnClear()
	{
		if (this.MoveComp != null)
		{
			this.MoveComp.StopMoveByHandleId(this.TsMoveHandleId, "TsTaskMoveToLocation.OnClear");
			this.MoveComp = null;
		}
		this.EndTime = 0.0;
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x0002F006 File Offset: 0x0002D206
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskMoveToLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskMoveToLocation.TsTaskMoveToLocation_C");
		}
		return TsTaskMoveToLocation._ClassPtr;
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x0002F02C File Offset: 0x0002D22C
	public TsTaskMoveToLocation() : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x0002F054 File Offset: 0x0002D254
	public TsTaskMoveToLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x0002F087 File Offset: 0x0002D287
	protected TsTaskMoveToLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x0002F09C File Offset: 0x0002D29C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x0002F0CC File Offset: 0x0002D2CC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000715 RID: 1813
	private const string CURRENT_PLAYER = "_currentPlayer";

	// Token: 0x04000716 RID: 1814
	private bool IsInitTsVariables;

	// Token: 0x04000717 RID: 1815
	private int TsMoveState;

	// Token: 0x04000718 RID: 1816
	private bool TsNavigationOn;

	// Token: 0x04000719 RID: 1817
	private string TsBlackboardLocation = "";

	// Token: 0x0400071A RID: 1818
	private bool TsOpenDebugNode;

	// Token: 0x0400071B RID: 1819
	private double TsLimitTime;

	// Token: 0x0400071C RID: 1820
	private bool TsIsFly;

	// Token: 0x0400071D RID: 1821
	private double EndTime;

	// Token: 0x0400071E RID: 1822
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400071F RID: 1823
	private int TsMoveHandleId;

	// Token: 0x04000720 RID: 1824
	[Nullable(2)]
	private Action<ELevelEventState> HandleMoveEnd;

	// Token: 0x04000721 RID: 1825
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskMoveToLocation.TsTaskMoveToLocation_C";

	// Token: 0x04000722 RID: 1826
	private static IntPtr _ClassPtr;

	// Token: 0x04000723 RID: 1827
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000724 RID: 1828
	private static int __PropertyOffset_MoveState;

	// Token: 0x04000725 RID: 1829
	private static int __PropertyOffset_NavigationOn;

	// Token: 0x04000726 RID: 1830
	private static int __PropertyOffset_BlackboardLocation;

	// Token: 0x04000727 RID: 1831
	private static int __PropertyOffset_EndDistance;

	// Token: 0x04000728 RID: 1832
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000729 RID: 1833
	private static int __PropertyOffset_OpenDebugNode;

	// Token: 0x0400072A RID: 1834
	private static int __PropertyOffset_LimitTime;

	// Token: 0x0400072B RID: 1835
	private static int __PropertyOffset_IsFly;
}
