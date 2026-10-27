using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000059 RID: 89
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalMoveTo.TsTaskAnimalMoveTo_C")]
public class TsTaskAnimalMoveTo : TsTaskAbortImmediatelyBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000362 RID: 866 RVA: 0x0000FC41 File Offset: 0x0000DE41
	static TsTaskAnimalMoveTo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsTaskAnimalMoveTo.CreateStaticDefaultValue), new Action(TsTaskAnimalMoveTo.ResetStaticDefaultValue));
	}

	// Token: 0x06000363 RID: 867 RVA: 0x0000FC60 File Offset: 0x0000DE60
	public static void CreateStaticDefaultValue()
	{
		TsTaskAnimalMoveTo.AnimalValidMoveState = new HashSet<global::ECharMoveState>();
		TsTaskAnimalMoveTo.AnimalValidMoveState.Add(global::ECharMoveState.Walk);
		TsTaskAnimalMoveTo.AnimalValidMoveState.Add(global::ECharMoveState.Run);
		TsTaskAnimalMoveTo.AnimalValidMoveState.Add(global::ECharMoveState.NormalSwim);
		TsTaskAnimalMoveTo.StaticVariablesInited = true;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x0000FC97 File Offset: 0x0000DE97
	public static void ResetStaticDefaultValue()
	{
		TsTaskAnimalMoveTo.StaticVariablesInited = false;
		TsTaskAnimalMoveTo.AnimalValidMoveState = null;
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000365 RID: 869 RVA: 0x0000FCA5 File Offset: 0x0000DEA5
	// (set) Token: 0x06000366 RID: 870 RVA: 0x0000FCB5 File Offset: 0x0000DEB5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECharState MoveState
	{
		get
		{
			return (ECharState)(*(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_MoveState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_MoveState) = (byte)value;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000367 RID: 871 RVA: 0x0000FCC6 File Offset: 0x0000DEC6
	// (set) Token: 0x06000368 RID: 872 RVA: 0x0000FCD6 File Offset: 0x0000DED6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NavigationOn
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_NavigationOn) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_NavigationOn) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000369 RID: 873 RVA: 0x0000FCE7 File Offset: 0x0000DEE7
	// (set) Token: 0x0600036A RID: 874 RVA: 0x0000FCFB File Offset: 0x0000DEFB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetLocation
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_TargetLocation)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_TargetLocation)), value);
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x0600036B RID: 875 RVA: 0x0000FD10 File Offset: 0x0000DF10
	// (set) Token: 0x0600036C RID: 876 RVA: 0x0000FD20 File Offset: 0x0000DF20
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x0600036D RID: 877 RVA: 0x0000FD31 File Offset: 0x0000DF31
	// (set) Token: 0x0600036E RID: 878 RVA: 0x0000FD41 File Offset: 0x0000DF41
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int LimitTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_LimitTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_LimitTime) = value;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x0600036F RID: 879 RVA: 0x0000FD52 File Offset: 0x0000DF52
	// (set) Token: 0x06000370 RID: 880 RVA: 0x0000FD62 File Offset: 0x0000DF62
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool RootMotion
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_RootMotion) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_RootMotion) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000371 RID: 881 RVA: 0x0000FD73 File Offset: 0x0000DF73
	// (set) Token: 0x06000372 RID: 882 RVA: 0x0000FD83 File Offset: 0x0000DF83
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int DistanceErrorThreshold
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_DistanceErrorThreshold);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAnimalMoveTo.__PropertyOffset_DistanceErrorThreshold) = value;
		}
	}

	// Token: 0x06000373 RID: 883 RVA: 0x0000FD94 File Offset: 0x0000DF94
	private static void InitStaticVariables()
	{
		TsTaskAnimalMoveTo.AnimalValidMoveState = new HashSet<global::ECharMoveState>();
		TsTaskAnimalMoveTo.AnimalValidMoveState.Add(global::ECharMoveState.Walk);
		TsTaskAnimalMoveTo.AnimalValidMoveState.Add(global::ECharMoveState.Run);
		TsTaskAnimalMoveTo.AnimalValidMoveState.Add(global::ECharMoveState.NormalSwim);
		TsTaskAnimalMoveTo.StaticVariablesInited = true;
	}

	// Token: 0x06000374 RID: 884 RVA: 0x0000FDCC File Offset: 0x0000DFCC
	private void InitTsVariables(Entity entity)
	{
		if (!this.IsInitTsVariables)
		{
			this.TsMoveState = (global::ECharMoveState)this.MoveState;
			this.TsNavigationOn = this.NavigationOn;
			this.TsTargetLocation = this.TargetLocation;
			this.TsLimitTime = (double)(this.LimitTime * TimeUtil.Instance.InverseMillisecond);
			this.TsTurnSpeed = this.TurnSpeed;
			this.TargetCache = global::Vector.Create();
			this.TsRootMotion = this.RootMotion;
			this.TsDistanceErrorThreshold = ((this.TsMoveState == global::ECharMoveState.NormalSwim) ? ((float)this.DistanceErrorThreshold) : ((float)Math.Max(100, this.DistanceErrorThreshold)));
			this.IsInitTsVariables = true;
		}
	}

	// Token: 0x06000375 RID: 885 RVA: 0x0000FE74 File Offset: 0x0000E074
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

	// Token: 0x06000376 RID: 886 RVA: 0x0000FF10 File Offset: 0x0000E110
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (!TsTaskAnimalMoveTo.StaticVariablesInited)
		{
			TsTaskAnimalMoveTo.InitStaticVariables();
		}
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Entity entity = (charActorComp != null) ? charActorComp.Entity : null;
		if (entity == null || !entity.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables(entity);
		if (!TsTaskAnimalMoveTo.AnimalValidMoveState.Contains(this.TsMoveState))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.CJH;
			string message2 = "错误的移动状态";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(false);
			return;
		}
		Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(entity.Id, this.TsTargetLocation);
		this.TargetCache.DeepCopy(vectorValueByEntity);
		this.AnimalMoveToController = new AnimalMoveToController(entity);
		this.AnimalMoveToController.Init(this.TsMoveState, this.TsRootMotion);
		this.AnimalMoveToController.Start(this.TargetCache, this.TsNavigationOn, this.TsTurnSpeed, (double)this.TsDistanceErrorThreshold);
		this.EndTime = double.MaxValue;
		if (this.TsLimitTime > 0.0)
		{
			this.EndTime = Time.Instance.WorldTime + this.TsLimitTime;
		}
	}

	// Token: 0x06000377 RID: 887 RVA: 0x000100A0 File Offset: 0x0000E2A0
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

	// Token: 0x06000378 RID: 888 RVA: 0x00010140 File Offset: 0x0000E340
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.TsLimitTime > 0.0 && this.EndTime < Time.Instance.WorldTime)
		{
			this.AnimalMoveToController.Stop();
			base.Finish(true);
			return;
		}
		EAnimalMoveToState eanimalMoveToState = this.AnimalMoveToController.Update(deltaSeconds);
		if (eanimalMoveToState == EAnimalMoveToState.Success)
		{
			base.Finish(true);
			return;
		}
		if (eanimalMoveToState != EAnimalMoveToState.Failure)
		{
			return;
		}
		base.Finish(false);
	}

	// Token: 0x06000379 RID: 889 RVA: 0x000101A8 File Offset: 0x0000E3A8
	protected override void OnClear()
	{
		AnimalMoveToController animalMoveToController = this.AnimalMoveToController;
		if (animalMoveToController != null)
		{
			animalMoveToController.Finish();
		}
		this.AnimalMoveToController = null;
	}

	// Token: 0x0600037A RID: 890 RVA: 0x000101C2 File Offset: 0x0000E3C2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAnimalMoveTo._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalMoveTo.TsTaskAnimalMoveTo_C");
		}
		return TsTaskAnimalMoveTo._ClassPtr;
	}

	// Token: 0x0600037B RID: 891 RVA: 0x000101E8 File Offset: 0x0000E3E8
	public TsTaskAnimalMoveTo() : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalMoveTo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00010210 File Offset: 0x0000E410
	public TsTaskAnimalMoveTo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalMoveTo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00010243 File Offset: 0x0000E443
	protected TsTaskAnimalMoveTo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00010260 File Offset: 0x0000E460
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00010290 File Offset: 0x0000E490
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000238 RID: 568
	private const int DEFAULT_DISTANCE_ERROR_THRESHOLD = 100;

	// Token: 0x04000239 RID: 569
	private bool IsInitTsVariables;

	// Token: 0x0400023A RID: 570
	private double TsLimitTime;

	// Token: 0x0400023B RID: 571
	private float TsTurnSpeed;

	// Token: 0x0400023C RID: 572
	private global::ECharMoveState TsMoveState = global::ECharMoveState.Walk;

	// Token: 0x0400023D RID: 573
	private bool TsNavigationOn;

	// Token: 0x0400023E RID: 574
	private string TsTargetLocation = "";

	// Token: 0x0400023F RID: 575
	private bool TsRootMotion;

	// Token: 0x04000240 RID: 576
	private float TsDistanceErrorThreshold;

	// Token: 0x04000241 RID: 577
	[Nullable(2)]
	private AnimalMoveToController AnimalMoveToController;

	// Token: 0x04000242 RID: 578
	[Nullable(2)]
	private global::Vector TargetCache;

	// Token: 0x04000243 RID: 579
	private double EndTime;

	// Token: 0x04000244 RID: 580
	private static bool StaticVariablesInited;

	// Token: 0x04000245 RID: 581
	[Nullable(2)]
	private static HashSet<global::ECharMoveState> AnimalValidMoveState;

	// Token: 0x04000246 RID: 582
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalMoveTo.TsTaskAnimalMoveTo_C";

	// Token: 0x04000247 RID: 583
	private static IntPtr _ClassPtr;

	// Token: 0x04000248 RID: 584
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000249 RID: 585
	private static int __PropertyOffset_MoveState;

	// Token: 0x0400024A RID: 586
	private static int __PropertyOffset_NavigationOn;

	// Token: 0x0400024B RID: 587
	private static int __PropertyOffset_TargetLocation;

	// Token: 0x0400024C RID: 588
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x0400024D RID: 589
	private static int __PropertyOffset_LimitTime;

	// Token: 0x0400024E RID: 590
	private static int __PropertyOffset_RootMotion;

	// Token: 0x0400024F RID: 591
	private static int __PropertyOffset_DistanceErrorThreshold;
}
