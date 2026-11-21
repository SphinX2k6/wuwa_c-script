using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000C8 RID: 200
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTerritoryWander.TsTaskTerritoryWander_C")]
public class TsTaskTerritoryWander : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0003AC4D File Offset: 0x00038E4D
	// (set) Token: 0x06000B8C RID: 2956 RVA: 0x0003AC61 File Offset: 0x00038E61
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string RangeCenterKey
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTerritoryWander.__PropertyOffset_RangeCenterKey)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskTerritoryWander.__PropertyOffset_RangeCenterKey)), value);
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0003AC76 File Offset: 0x00038E76
	// (set) Token: 0x06000B8E RID: 2958 RVA: 0x0003AC86 File Offset: 0x00038E86
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float RangeRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_RangeRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_RangeRadius) = value;
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0003AC97 File Offset: 0x00038E97
	// (set) Token: 0x06000B90 RID: 2960 RVA: 0x0003ACA7 File Offset: 0x00038EA7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Angle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_Angle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_Angle) = value;
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06000B91 RID: 2961 RVA: 0x0003ACB8 File Offset: 0x00038EB8
	// (set) Token: 0x06000B92 RID: 2962 RVA: 0x0003ACC8 File Offset: 0x00038EC8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float InnerDiameter
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_InnerDiameter);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_InnerDiameter) = value;
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06000B93 RID: 2963 RVA: 0x0003ACD9 File Offset: 0x00038ED9
	// (set) Token: 0x06000B94 RID: 2964 RVA: 0x0003ACE9 File Offset: 0x00038EE9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OuterDiameter
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_OuterDiameter);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_OuterDiameter) = value;
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0003ACFA File Offset: 0x00038EFA
	// (set) Token: 0x06000B96 RID: 2966 RVA: 0x0003AD0A File Offset: 0x00038F0A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ForceNavigation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_ForceNavigation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_ForceNavigation) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0003AD1B File Offset: 0x00038F1B
	// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0003AD2B File Offset: 0x00038F2B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0003AD3C File Offset: 0x00038F3C
	// (set) Token: 0x06000B9A RID: 2970 RVA: 0x0003AD4C File Offset: 0x00038F4C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_DebugMode) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTerritoryWander.__PropertyOffset_DebugMode) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x0003AD60 File Offset: 0x00038F60
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsRangeCenterKey = this.RangeCenterKey;
			this.TsRangeRadius = this.RangeRadius;
			this.TsAngle = this.Angle;
			this.TsInnerDiameter = this.InnerDiameter;
			this.TsOuterDiameter = this.OuterDiameter;
			this.TsForceNavigation = this.ForceNavigation;
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsDebugMode = this.DebugMode;
		}
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x0003ADE4 File Offset: 0x00038FE4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTerritoryWander) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskTerritoryWander.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000B9D RID: 2973 RVA: 0x0003AE94 File Offset: 0x00039094
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
			base.FinishExecute(false);
			return;
		}
		this.ActorComp = aiController.CharActorComp;
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Valid)
		{
			base.Finish(false);
			return;
		}
		Entity entity = this.ActorComp.Entity;
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		this.MoveComp = entity.GetComponent<CharacterMoveComponent>();
		this.UnifiedStateComp = entity.GetComponent<BaseUnifiedStateComponent>();
		if (this.RangeCenter == null)
		{
			if (this.TsRangeCenterKey != "")
			{
				int id = entity.Id;
				Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(id, this.TsRangeCenterKey);
				if (vectorValueByEntity == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.BehaviorTree;
					ELogAuthor author2 = ELogAuthor.CJH;
					string message2 = "不存在Blackboard Value";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Key", this.TsRangeCenterKey);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					base.Finish(false);
					return;
				}
				this.RangeCenter = global::Vector.Create(vectorValueByEntity);
			}
			else
			{
				Aki.Protocol.Vector initLocation = component.GetInitLocation();
				this.RangeCenter = global::Vector.Create((double)initLocation.X, (double)initLocation.Y, (double)initLocation.Z);
			}
		}
		if (this.CacheVector == null)
		{
			this.CacheVector = global::Vector.Create();
		}
		this.FindWanderLocation();
		this.FindWanderPath();
		this.NavigationEndTime = Time.Instance.WorldTime + 5000.0;
		this.CurrentNavigationIndex = 1;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x0003B040 File Offset: 0x00039240
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTerritoryWander) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTerritoryWander.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000B9F RID: 2975 RVA: 0x0003B0F8 File Offset: 0x000392F8
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (!(ownerController is TsAiController))
		{
			base.Finish(false);
			return;
		}
		if (this.TsForceNavigation && !this.FoundPath)
		{
			base.Finish(false);
			return;
		}
		CharacterMoveComponent moveComp = this.MoveComp;
		if (moveComp == null || !moveComp.CanMove())
		{
			base.Finish(false);
			return;
		}
		if (Time.Instance.WorldTime > this.NavigationEndTime)
		{
			base.Finish(true);
			return;
		}
		BaseUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
		if (unifiedStateComp != null && unifiedStateComp.Valid)
		{
			this.UnifiedStateComp.SetMoveState(global::ECharMoveState.Walk);
		}
		global::Vector inV = this.NavigationPath[this.CurrentNavigationIndex];
		this.CacheVector.FromUeVector(inV);
		this.CacheVector.Subtraction(this.ActorComp.ActorLocationProxy, this.CacheVector);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.CacheVector);
		double num = this.CacheVector.Size();
		this.CacheVector.Normalize(9.99999993922529E-09);
		if (this.CurrentNavigationIndex == this.NavigationPath.Count - 1 && num < 20.0)
		{
			base.Finish(true);
			return;
		}
		if (num < 20.0)
		{
			this.CurrentNavigationIndex++;
		}
		this.ActorComp.SetInputDirect(this.CacheVector, false, EInputDirectSpace.World);
		AiControllerLibrary.TurnToDirect(this.ActorComp, this.CacheVector, this.TsTurnSpeed, false, 0f);
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x0003B274 File Offset: 0x00039474
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"X",
		"Y"
	})]
	private ValueTuple<double, double> RandomPointInFanRing(double inner, double outer, double minAngle, double maxAngle)
	{
		if (minAngle > maxAngle || inner > outer || inner < 0.0)
		{
			return new ValueTuple<double, double>(0.0, 0.0);
		}
		double randomRange = MathUtils.Instance.GetRandomRange(inner * inner, outer * outer);
		double randomRange2 = MathUtils.Instance.GetRandomRange(minAngle, maxAngle);
		double num = Math.Sqrt(randomRange);
		return new ValueTuple<double, double>(num * Math.Cos(randomRange2), num * Math.Sin(randomRange2));
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x0003B2E8 File Offset: 0x000394E8
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			AiControllerLibrary.ClearInput(tsAiController);
		}
		BaseUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
		if (unifiedStateComp != null)
		{
			unifiedStateComp.SetMoveState(global::ECharMoveState.Stand);
		}
		this.ActorComp = null;
		this.MoveComp = null;
		this.UnifiedStateComp = null;
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x0003B334 File Offset: 0x00039534
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void FindWanderLocation()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTerritoryWander) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("FindWanderLocation"), TsTaskTerritoryWander.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.FindWanderLocation_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x0003B390 File Offset: 0x00039590
	protected void FindWanderLocation_Implementation()
	{
		if (this.TargetLocation == null)
		{
			this.TargetLocation = global::Vector.Create();
		}
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		ValueTuple<double, double> valueTuple = this.RandomPointInFanRing((double)this.TsInnerDiameter, (double)this.TsOuterDiameter, (double)((this.ActorComp.ActorRotationProxy.Yaw - this.TsAngle / 2f) / 180f) * 3.14, (double)((this.ActorComp.ActorRotationProxy.Yaw + this.TsAngle / 2f) / 180f) * 3.14);
		this.TargetLocation.X = actorLocationProxy.X + valueTuple.Item1;
		this.TargetLocation.Y = actorLocationProxy.Y + valueTuple.Item2;
		this.TargetLocation.Z = actorLocationProxy.Z;
		if (global::Vector.DistSquared2D(this.TargetLocation, this.RangeCenter) >= (double)(this.TsRangeRadius * this.TsRangeRadius))
		{
			this.TargetLocation.X = actorLocationProxy.X - valueTuple.Item1;
			this.TargetLocation.Y = actorLocationProxy.Y - valueTuple.Item2;
			if (global::Vector.DistSquared2D(this.TargetLocation, this.RangeCenter) >= (double)(this.TsRangeRadius * this.TsRangeRadius))
			{
				this.TargetLocation.X = this.RangeCenter.X;
				this.TargetLocation.Y = this.RangeCenter.Y;
			}
			this.TargetLocation.Z = actorLocationProxy.Z;
		}
		this.DebugDraw();
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x0003B528 File Offset: 0x00039728
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void FindWanderPath()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTerritoryWander) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("FindWanderPath"), TsTaskTerritoryWander.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.FindWanderPath_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x0003B584 File Offset: 0x00039784
	protected void FindWanderPath_Implementation()
	{
		if (this.NavigationPath == null)
		{
			this.NavigationPath = new List<global::Vector>();
		}
		this.FoundPath = AiControllerLibrary.NavigationFindPath(this, this.ActorComp.ActorLocation, this.TargetLocation.ToUeVector(false), this.NavigationPath, null, null);
		if (!this.FoundPath)
		{
			this.NavigationPath.Clear();
			this.NavigationPath.Add(this.ActorComp.ActorLocationProxy);
			this.NavigationPath.Add(this.TargetLocation);
		}
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x0003B61C File Offset: 0x0003981C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void DebugDraw()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTerritoryWander) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("DebugDraw"), TsTaskTerritoryWander.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.DebugDraw_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x0003B678 File Offset: 0x00039878
	protected void DebugDraw_Implementation()
	{
		if (this.TsDebugMode && GlobalData.IsPlayInEditor)
		{
			UKismetSystemLibrary.D_DrawDebugCone(this, this.ActorComp.ActorLocation, this.ActorComp.ActorForward, this.TsOuterDiameter, (float)((double)(this.TsAngle / 360f) * 3.14), 0f, 12, ColorUtils.LinearGreen, 3f, 0f);
			UKismetSystemLibrary.D_DrawDebugCone(this, this.ActorComp.ActorLocation, this.ActorComp.ActorForward, this.TsInnerDiameter, (float)((double)(this.TsAngle / 360f) * 3.14), 0f, 12, ColorUtils.LinearRed, 3f, 0f);
			UKismetSystemLibrary.D_DrawDebugCircle(this, this.RangeCenter.ToUeVector(false), this.TsRangeRadius, 24, new FLinearColor?(ColorUtils.LinearYellow), 3f, 0f, new FVectorDouble?(global::Vector.Create(1.0, 0.0, 0.0).ToUeVector(false)), new FVectorDouble?(global::Vector.Create(0.0, 1.0, 0.0).ToUeVector(false)), true);
			UKismetSystemLibrary.D_DrawDebugSphere(this, this.TargetLocation.ToUeVector(false), 30f, 10, new FLinearColor?(ColorUtils.LinearRed), 3f, 0f);
		}
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x0003B7EC File Offset: 0x000399EC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTerritoryWander._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTerritoryWander.TsTaskTerritoryWander_C");
		}
		return TsTaskTerritoryWander._ClassPtr;
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x0003B810 File Offset: 0x00039A10
	public TsTaskTerritoryWander() : this(BuiltinUtils.AllocNativeUObject(TsTaskTerritoryWander.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x0003B838 File Offset: 0x00039A38
	[NullableContext(1)]
	public TsTaskTerritoryWander(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTerritoryWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x0003B86B File Offset: 0x00039A6B
	protected TsTaskTerritoryWander(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x0003B880 File Offset: 0x00039A80
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x0003B8B0 File Offset: 0x00039AB0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x0003B8E3 File Offset: 0x00039AE3
	protected virtual void __CPPCALL_FindWanderLocation_Implementation()
	{
		this.FindWanderLocation_Implementation();
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x0003B8EB File Offset: 0x00039AEB
	protected virtual void __CPPCALL_FindWanderPath_Implementation()
	{
		this.FindWanderPath_Implementation();
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x0003B8F3 File Offset: 0x00039AF3
	protected virtual void __CPPCALL_DebugDraw_Implementation()
	{
		this.DebugDraw_Implementation();
	}

	// Token: 0x04000912 RID: 2322
	private const double PI = 3.14;

	// Token: 0x04000913 RID: 2323
	private const int NAVIGATION_END_TIME = 5000;

	// Token: 0x04000914 RID: 2324
	private const int NAVIGATION_COMPLETE_DISTANCE = 20;

	// Token: 0x04000915 RID: 2325
	private global::Vector RangeCenter;

	// Token: 0x04000916 RID: 2326
	private global::Vector TargetLocation;

	// Token: 0x04000917 RID: 2327
	private bool FoundPath;

	// Token: 0x04000918 RID: 2328
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> NavigationPath;

	// Token: 0x04000919 RID: 2329
	private int CurrentNavigationIndex;

	// Token: 0x0400091A RID: 2330
	private CharacterActorComponent ActorComp;

	// Token: 0x0400091B RID: 2331
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400091C RID: 2332
	private BaseUnifiedStateComponent UnifiedStateComp;

	// Token: 0x0400091D RID: 2333
	private global::Vector CacheVector;

	// Token: 0x0400091E RID: 2334
	private double NavigationEndTime;

	// Token: 0x0400091F RID: 2335
	private bool IsInitTsVariables;

	// Token: 0x04000920 RID: 2336
	[Nullable(1)]
	private string TsRangeCenterKey = "";

	// Token: 0x04000921 RID: 2337
	private float TsRangeRadius;

	// Token: 0x04000922 RID: 2338
	private float TsAngle;

	// Token: 0x04000923 RID: 2339
	private float TsInnerDiameter;

	// Token: 0x04000924 RID: 2340
	private float TsOuterDiameter;

	// Token: 0x04000925 RID: 2341
	private bool TsForceNavigation;

	// Token: 0x04000926 RID: 2342
	private float TsTurnSpeed;

	// Token: 0x04000927 RID: 2343
	private bool TsDebugMode;

	// Token: 0x04000928 RID: 2344
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTerritoryWander.TsTaskTerritoryWander_C";

	// Token: 0x04000929 RID: 2345
	private static IntPtr _ClassPtr;

	// Token: 0x0400092A RID: 2346
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400092B RID: 2347
	private static int __PropertyOffset_RangeCenterKey;

	// Token: 0x0400092C RID: 2348
	private static int __PropertyOffset_RangeRadius;

	// Token: 0x0400092D RID: 2349
	private static int __PropertyOffset_Angle;

	// Token: 0x0400092E RID: 2350
	private static int __PropertyOffset_InnerDiameter;

	// Token: 0x0400092F RID: 2351
	private static int __PropertyOffset_OuterDiameter;

	// Token: 0x04000930 RID: 2352
	private static int __PropertyOffset_ForceNavigation;

	// Token: 0x04000931 RID: 2353
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000932 RID: 2354
	private static int __PropertyOffset_DebugMode;
}
