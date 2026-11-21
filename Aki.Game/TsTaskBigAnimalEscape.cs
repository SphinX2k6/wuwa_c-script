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
	// Token: 0x17000118 RID: 280
	// (get) Token: 0x060006EB RID: 1771 RVA: 0x00023463 File Offset: 0x00021663
	// (set) Token: 0x060006EC RID: 1772 RVA: 0x00023477 File Offset: 0x00021677
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

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x060006ED RID: 1773 RVA: 0x0002348C File Offset: 0x0002168C
	// (set) Token: 0x060006EE RID: 1774 RVA: 0x0002349C File Offset: 0x0002169C
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

	// Token: 0x060006EF RID: 1775 RVA: 0x000234B0 File Offset: 0x000216B0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void InitTsVariables()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBigAnimalEscape) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitTsVariables"), TsTaskBigAnimalEscape.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitTsVariables_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00023509 File Offset: 0x00021709
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsEnemyKey = this.EnemyKey;
			this.TsTurnSpeed = this.TurnSpeed;
		}
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x0002353C File Offset: 0x0002173C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBigAnimalEscape) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskBigAnimalEscape.StaticClass(), out intPtr, out num))
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

	// Token: 0x060006F2 RID: 1778 RVA: 0x000235EC File Offset: 0x000217EC
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

	// Token: 0x060006F3 RID: 1779 RVA: 0x000237C0 File Offset: 0x000219C0
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

	// Token: 0x060006F4 RID: 1780 RVA: 0x000238D0 File Offset: 0x00021AD0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void InitData()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBigAnimalEscape) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitData"), TsTaskBigAnimalEscape.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitData_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x0002392C File Offset: 0x00021B2C
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

	// Token: 0x060006F6 RID: 1782 RVA: 0x00023984 File Offset: 0x00021B84
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

	// Token: 0x060006F7 RID: 1783 RVA: 0x00023ADC File Offset: 0x00021CDC
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

	// Token: 0x060006F8 RID: 1784 RVA: 0x00023C84 File Offset: 0x00021E84
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void FindMovePath()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBigAnimalEscape) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("FindMovePath"), TsTaskBigAnimalEscape.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.FindMovePath_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x00023CE0 File Offset: 0x00021EE0
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

	// Token: 0x060006FA RID: 1786 RVA: 0x00023DA4 File Offset: 0x00021FA4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void GenerateFailurePath()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBigAnimalEscape) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GenerateFailurePath"), TsTaskBigAnimalEscape.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.GenerateFailurePath_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00023E00 File Offset: 0x00022000
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

	// Token: 0x060006FC RID: 1788 RVA: 0x00023EB0 File Offset: 0x000220B0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBigAnimalEscape) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskBigAnimalEscape.StaticClass(), out intPtr, out num))
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

	// Token: 0x060006FD RID: 1789 RVA: 0x00023F68 File Offset: 0x00022168
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
		this.ActorComp.SetInputDirect(vector, false, EInputDirectSpace.World);
		AiControllerLibrary.TurnToDirect(this.ActorComp, vector, this.TsTurnSpeed, false, 0f);
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x0002411B File Offset: 0x0002231B
	protected override void OnClear()
	{
		this.OptimalDirections.Clear();
		this.FoundLocation = false;
		this.FoundPath = false;
		this.MovePath.Clear();
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00024141 File Offset: 0x00022341
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskBigAnimalEscape._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBigAnimalEscape.TsTaskBigAnimalEscape_C");
		}
		return TsTaskBigAnimalEscape._ClassPtr;
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00024168 File Offset: 0x00022368
	public TsTaskBigAnimalEscape() : this(BuiltinUtils.AllocNativeUObject(TsTaskBigAnimalEscape.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00024190 File Offset: 0x00022390
	public TsTaskBigAnimalEscape(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBigAnimalEscape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000241C3 File Offset: 0x000223C3
	protected TsTaskBigAnimalEscape(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x000241D7 File Offset: 0x000223D7
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x000241E0 File Offset: 0x000223E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x0002420D File Offset: 0x0002240D
	protected virtual void __CPPCALL_InitData_Implementation()
	{
		this.InitData_Implementation();
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00024215 File Offset: 0x00022415
	protected virtual void __CPPCALL_FindMovePath_Implementation()
	{
		this.FindMovePath_Implementation();
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x0002421D File Offset: 0x0002241D
	protected virtual void __CPPCALL_GenerateFailurePath_Implementation()
	{
		this.GenerateFailurePath_Implementation();
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00024228 File Offset: 0x00022428
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400050B RID: 1291
	private const double FRONT_RANDOM_RAD = 0.26;

	// Token: 0x0400050C RID: 1292
	private const int HALF_PI_DEG = 90;

	// Token: 0x0400050D RID: 1293
	private const int DOUBLE_PI_DEG = 360;

	// Token: 0x0400050E RID: 1294
	private const int INSPECTION_INTERVAL = 200;

	// Token: 0x0400050F RID: 1295
	private const int DEBUG_SEGMENTS = 10;

	// Token: 0x04000510 RID: 1296
	private const int DEBUG_RADIUS = 30;

	// Token: 0x04000511 RID: 1297
	private const float DEBUG_TIME = 2.5f;

	// Token: 0x04000512 RID: 1298
	private const int TURN_COMPLETE_DEG = 30;

	// Token: 0x04000513 RID: 1299
	private const int NAVIGATION_COMPLETE_DISTANCE = 2500;

	// Token: 0x04000514 RID: 1300
	private const bool DEBUG_MODE = true;

	// Token: 0x04000515 RID: 1301
	private bool IsInitTsVariables;

	// Token: 0x04000516 RID: 1302
	private string TsEnemyKey = "";

	// Token: 0x04000517 RID: 1303
	private float TsTurnSpeed;

	// Token: 0x04000518 RID: 1304
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x04000519 RID: 1305
	[Nullable(2)]
	private CharacterActorComponent TargetActorComp;

	// Token: 0x0400051A RID: 1306
	private bool Initialized;

	// Token: 0x0400051B RID: 1307
	private double AngleMin;

	// Token: 0x0400051C RID: 1308
	private double AngleMax;

	// Token: 0x0400051D RID: 1309
	private double InnerDiameter;

	// Token: 0x0400051E RID: 1310
	private double OuterDiameter;

	// Token: 0x0400051F RID: 1311
	private double EscapeEndTime;

	// Token: 0x04000520 RID: 1312
	private bool FoundLocation;

	// Token: 0x04000521 RID: 1313
	private FVectorDouble? EscapeLocation;

	// Token: 0x04000522 RID: 1314
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> OptimalDirections;

	// Token: 0x04000523 RID: 1315
	protected bool FoundPath;

	// Token: 0x04000524 RID: 1316
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> MovePath;

	// Token: 0x04000525 RID: 1317
	private int CurrentMoveIndex;

	// Token: 0x04000526 RID: 1318
	private bool NeedTurn;

	// Token: 0x04000527 RID: 1319
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBigAnimalEscape.TsTaskBigAnimalEscape_C";

	// Token: 0x04000528 RID: 1320
	private static IntPtr _ClassPtr;

	// Token: 0x04000529 RID: 1321
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400052A RID: 1322
	private static int __PropertyOffset_EnemyKey;

	// Token: 0x0400052B RID: 1323
	private static int __PropertyOffset_TurnSpeed;
}
