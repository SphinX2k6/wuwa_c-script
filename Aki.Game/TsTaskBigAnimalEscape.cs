using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200008B RID: 139
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBigAnimalEscape.TsTaskBigAnimalEscape_C")]
public class TsTaskBigAnimalEscape : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000116 RID: 278
	// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0002276F File Offset: 0x0002096F
	// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00022783 File Offset: 0x00020983
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string EnemyKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBigAnimalEscape.__PropertyOffset_EnemyKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBigAnimalEscape.__PropertyOffset_EnemyKey)), value);
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00022798 File Offset: 0x00020998
	// (set) Token: 0x060006EA RID: 1770 RVA: 0x000227A8 File Offset: 0x000209A8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskBigAnimalEscape.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskBigAnimalEscape.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x000227BC File Offset: 0x000209BC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void InitTsVariables()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitTsVariables"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x0002282C File Offset: 0x00020A2C
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsEnemyKey = this.EnemyKey;
			this.TsTurnSpeed = this.TurnSpeed;
		}
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x0002285C File Offset: 0x00020A5C
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

	// Token: 0x060006EE RID: 1774 RVA: 0x000228F8 File Offset: 0x00020AF8
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
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
		AiController aiController = tsAiController.AiController;
		if (!this.InitConfig(aiController))
		{
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		this.ActorComp = aiController.CharActorComp;
		if (this.TsEnemyKey != "")
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(this.ActorComp.Entity.Id, this.TsEnemyKey);
			if (entityIdByEntity != null && entityIdByEntity.Value != 0)
			{
				Entity entity = EntitySystem.Instance.Get(entityIdByEntity.Value);
				if (entity != null)
				{
					this.TargetActorComp = entity.GetComponent<CharacterActorComponent>();
				}
			}
		}
		if (this.TargetActorComp == null)
		{
			this.TargetActorComp = Global.BaseCharacter.CharacterActorComponent;
		}
		this.InitData();
		global::Vector vector = global::Vector.Create();
		this.ActorComp.ActorLocationProxy.Subtraction(this.TargetActorComp.ActorLocationProxy, vector);
		vector.Z = 0.0;
		vector.Normalize(9.99999993922529E-09);
		this.FindOptimalDirections(vector);
		if (this.OptimalDirections.Count == 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.CJH;
			string message2 = "无可行方向，请检查逻辑和配置";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId: ", this.ActorComp.Entity.Id);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.Finish(true);
			return;
		}
		this.FindEscapeLocation();
		this.FindMovePath();
		this.EscapeEndTime = Time.Instance.WorldTime + (double)aiController.AiFlee.Value.TimeMilliseconds;
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00022ACC File Offset: 0x00020CCC
	private bool InitConfig(AiController aiController)
	{
		if (this.Initialized)
		{
			return true;
		}
		AiFlee? aiFlee = aiController.AiFlee;
		if (aiFlee == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "没有配置逃跑";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.AngleMin = (double)aiFlee.Value.FleeAngle.Value.Min;
		this.AngleMax = (double)aiFlee.Value.FleeAngle.Value.Max;
		this.InnerDiameter = (double)aiFlee.Value.FleeDistance.Value.Min;
		this.OuterDiameter = (double)aiFlee.Value.FleeDistance.Value.Max;
		this.Initialized = true;
		return true;
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00022BDC File Offset: 0x00020DDC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void InitData()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00022C4C File Offset: 0x00020E4C
	protected void InitData_Implementation()
	{
		if (this.OptimalDirections == null)
		{
			this.OptimalDirections = new List<global::Vector>();
		}
		if (this.EscapeLocation == null)
		{
			this.EscapeLocation = new FVectorDouble?(new FVectorDouble());
		}
		if (this.MovePath == null)
		{
			this.MovePath = new List<global::Vector>();
		}
		this.CurrentMoveIndex = 1;
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00022CA4 File Offset: 0x00020EA4
	private void FindOptimalDirections(global::Vector departure)
	{
		global::Vector actorForwardProxy = this.ActorComp.ActorForwardProxy;
		double num = Math.Max(this.AngleMax - this.AngleMin, 90.0);
		global::Vector vector = global::Vector.Create();
		departure.Multiply(-1.0, vector);
		int num2 = 4;
		List<ValueTuple<global::Vector, double>> list = new List<ValueTuple<global::Vector, double>>();
		for (int i = 0; i < num2; i++)
		{
			int num3 = i * 90;
			global::Vector vector2 = global::Vector.Create();
			actorForwardProxy.RotateAngleAxis((double)num3, this.ActorComp.ActorUpProxy, vector2);
			double angleByVectorDot = MathUtils.Instance.GetAngleByVectorDot(vector, vector2);
			if (angleByVectorDot >= 90.0)
			{
				angleByVectorDot = MathUtils.Instance.GetAngleByVectorDot(departure, vector2);
				if (angleByVectorDot <= num)
				{
					list.Add(new ValueTuple<global::Vector, double>(vector2, angleByVectorDot));
				}
			}
		}
		list.Sort(([Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<global::Vector, double> a, [Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<global::Vector, double> b) => a.Item2.CompareTo(b.Item2));
		foreach (ValueTuple<global::Vector, double> valueTuple in list)
		{
			this.OptimalDirections.Add(valueTuple.Item1);
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00022DE4 File Offset: 0x00020FE4
	private void FindEscapeLocation()
	{
		global::Vector vector = global::Vector.Create();
		FVectorDouble value = default(FVectorDouble);
		foreach (global::Vector vector2 in this.OptimalDirections)
		{
			for (double num = this.OuterDiameter; num >= this.InnerDiameter; num -= 200.0)
			{
				vector2.Multiply(num, vector);
				vector.AdditionEqual(this.ActorComp.ActorLocationProxy);
				double num2 = num * Math.Sin(0.26);
				UObject world = GlobalData.World;
				FVectorDouble fvectorDouble = vector.ToUeVector(false);
				this.FoundLocation = UNavigationSystemV1.D_K2_GetRandomLocationInNavigableRadius(world, fvectorDouble, ref value, (float)num2, null, default(TSubclassOf<UNavigationQueryFilter>));
				if (this.FoundLocation)
				{
					break;
				}
			}
			if (this.FoundLocation)
			{
				this.EscapeLocation = new FVectorDouble?(value);
				break;
			}
		}
		if (!this.FoundLocation)
		{
			global::Vector vector3 = this.OptimalDirections[0];
			for (double num3 = this.InnerDiameter; num3 > 0.0; num3 -= 200.0)
			{
				vector3.Multiply(num3, vector);
				vector.AdditionEqual(this.ActorComp.ActorLocationProxy);
				UObject world2 = GlobalData.World;
				FVectorDouble fvectorDouble = vector.ToUeVector(false);
				this.FoundLocation = UNavigationSystemV1.D_K2_ProjectPointToNavigation(world2, fvectorDouble, ref value, null, default(TSubclassOf<UNavigationQueryFilter>), default(FVectorDouble), -1.0);
				if (this.FoundLocation)
				{
					this.EscapeLocation = new FVectorDouble?(value);
					return;
				}
			}
		}
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00022F8C File Offset: 0x0002118C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void FindMovePath()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FindMovePath"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00022FFC File Offset: 0x000211FC
	protected void FindMovePath_Implementation()
	{
		if (!this.FoundLocation)
		{
			this.GenerateFailurePath();
			return;
		}
		this.FoundPath = AiControllerLibrary.NavigationFindPath(GlobalData.World, this.ActorComp.ActorLocation, this.EscapeLocation.Value, this.MovePath, null, null);
		if (GlobalData.IsPlayInEditor && this.FoundPath)
		{
			int i = 0;
			int count = this.MovePath.Count;
			while (i < count)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(this, this.MovePath[i].ToUeVector(false), 30f, 10, new FLinearColor?(ColorUtils.LinearGreen), 2.5f, 0f);
				i++;
			}
		}
		if (!this.FoundPath)
		{
			this.GenerateFailurePath();
		}
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x000230C0 File Offset: 0x000212C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void GenerateFailurePath()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GenerateFailurePath"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00023130 File Offset: 0x00021330
	protected void GenerateFailurePath_Implementation()
	{
		global::Vector vector = global::Vector.Create();
		this.OptimalDirections[0].Multiply(200.0, vector);
		vector.AdditionEqual(this.ActorComp.ActorLocationProxy);
		global::Vector item = global::Vector.Create(this.ActorComp.ActorLocationProxy);
		this.MovePath.Clear();
		this.MovePath.Add(item);
		this.MovePath.Add(vector);
		this.FoundPath = true;
		if (GlobalData.IsPlayInEditor)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(this, this.EscapeLocation.Value, 30f, 10, new FLinearColor?(ColorUtils.LinearRed), 2.5f, 0f);
		}
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x000231E0 File Offset: 0x000213E0
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

	// Token: 0x060006F9 RID: 1785 RVA: 0x00023280 File Offset: 0x00021480
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (((tsAiController != null) ? tsAiController.AiController : null) == null)
		{
			base.Finish(false);
			return;
		}
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Valid)
		{
			base.Finish(false);
			return;
		}
		if (Time.Instance.WorldTime > this.EscapeEndTime)
		{
			base.Finish(true);
			return;
		}
		BaseUnifiedStateComponent component = this.ActorComp.Entity.GetComponent<BaseUnifiedStateComponent>();
		global::Vector vector = global::Vector.Create(this.MovePath[this.CurrentMoveIndex]);
		vector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, vector);
		double num = vector.SizeSquared();
		vector.Normalize(9.99999993922529E-09);
		double angleByVectorDot = MathUtils.Instance.GetAngleByVectorDot(this.ActorComp.ActorForwardProxy, vector);
		this.NeedTurn = (angleByVectorDot > 30.0);
		if (this.CurrentMoveIndex == 1 && this.NeedTurn)
		{
			if (component != null && component.Valid)
			{
				component.SetMoveState(ECharMoveState.Stand);
			}
			this.ActorComp.ClearInput(false, true);
			AiControllerLibrary.TurnToDirect(this.ActorComp, vector, this.TsTurnSpeed, false, 0f);
			return;
		}
		if (component != null && component.Valid)
		{
			component.SetMoveState(ECharMoveState.Run);
		}
		if (num < 2500.0)
		{
			this.CurrentMoveIndex++;
			if (this.CurrentMoveIndex == this.MovePath.Count)
			{
				base.Finish(true);
				return;
			}
		}
		this.ActorComp.SetInputDirect(vector, false);
		AiControllerLibrary.TurnToDirect(this.ActorComp, vector, this.TsTurnSpeed, false, 0f);
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x00023428 File Offset: 0x00021628
	protected override void OnClear()
	{
		this.OptimalDirections.Clear();
		this.FoundLocation = false;
		this.FoundPath = false;
		this.MovePath.Clear();
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x0002344E File Offset: 0x0002164E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskBigAnimalEscape._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBigAnimalEscape.TsTaskBigAnimalEscape_C");
		}
		return TsTaskBigAnimalEscape._ClassPtr;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00023474 File Offset: 0x00021674
	public TsTaskBigAnimalEscape() : this(BuiltinUtils.AllocNativeUObject(TsTaskBigAnimalEscape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x0002349C File Offset: 0x0002169C
	public TsTaskBigAnimalEscape(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBigAnimalEscape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x000234CF File Offset: 0x000216CF
	protected TsTaskBigAnimalEscape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x000234E3 File Offset: 0x000216E3
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x000234EC File Offset: 0x000216EC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00023519 File Offset: 0x00021719
	protected virtual void __CPPCALL_InitData_Implementation()
	{
		this.InitData_Implementation();
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00023521 File Offset: 0x00021721
	protected virtual void __CPPCALL_FindMovePath_Implementation()
	{
		this.FindMovePath_Implementation();
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00023529 File Offset: 0x00021729
	protected virtual void __CPPCALL_GenerateFailurePath_Implementation()
	{
		this.GenerateFailurePath_Implementation();
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00023534 File Offset: 0x00021734
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000507 RID: 1287
	private const double FRONT_RANDOM_RAD = 0.26;

	// Token: 0x04000508 RID: 1288
	private const int HALF_PI_DEG = 90;

	// Token: 0x04000509 RID: 1289
	private const int DOUBLE_PI_DEG = 360;

	// Token: 0x0400050A RID: 1290
	private const int INSPECTION_INTERVAL = 200;

	// Token: 0x0400050B RID: 1291
	private const int DEBUG_SEGMENTS = 10;

	// Token: 0x0400050C RID: 1292
	private const int DEBUG_RADIUS = 30;

	// Token: 0x0400050D RID: 1293
	private const float DEBUG_TIME = 2.5f;

	// Token: 0x0400050E RID: 1294
	private const int TURN_COMPLETE_DEG = 30;

	// Token: 0x0400050F RID: 1295
	private const int NAVIGATION_COMPLETE_DISTANCE = 2500;

	// Token: 0x04000510 RID: 1296
	private const bool DEBUG_MODE = true;

	// Token: 0x04000511 RID: 1297
	private bool IsInitTsVariables;

	// Token: 0x04000512 RID: 1298
	private string TsEnemyKey = "";

	// Token: 0x04000513 RID: 1299
	private float TsTurnSpeed;

	// Token: 0x04000514 RID: 1300
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x04000515 RID: 1301
	[Nullable(2)]
	private CharacterActorComponent TargetActorComp;

	// Token: 0x04000516 RID: 1302
	private bool Initialized;

	// Token: 0x04000517 RID: 1303
	private double AngleMin;

	// Token: 0x04000518 RID: 1304
	private double AngleMax;

	// Token: 0x04000519 RID: 1305
	private double InnerDiameter;

	// Token: 0x0400051A RID: 1306
	private double OuterDiameter;

	// Token: 0x0400051B RID: 1307
	private double EscapeEndTime;

	// Token: 0x0400051C RID: 1308
	private bool FoundLocation;

	// Token: 0x0400051D RID: 1309
	private FVectorDouble? EscapeLocation;

	// Token: 0x0400051E RID: 1310
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> OptimalDirections;

	// Token: 0x0400051F RID: 1311
	protected bool FoundPath;

	// Token: 0x04000520 RID: 1312
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> MovePath;

	// Token: 0x04000521 RID: 1313
	private int CurrentMoveIndex;

	// Token: 0x04000522 RID: 1314
	private bool NeedTurn;

	// Token: 0x04000523 RID: 1315
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBigAnimalEscape.TsTaskBigAnimalEscape_C";

	// Token: 0x04000524 RID: 1316
	private static IntPtr _ClassPtr;

	// Token: 0x04000525 RID: 1317
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000526 RID: 1318
	private static int __PropertyOffset_EnemyKey;

	// Token: 0x04000527 RID: 1319
	private static int __PropertyOffset_TurnSpeed;
}
