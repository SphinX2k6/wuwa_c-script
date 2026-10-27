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
	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00039A09 File Offset: 0x00037C09
	// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00039A1D File Offset: 0x00037C1D
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

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00039A32 File Offset: 0x00037C32
	// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00039A42 File Offset: 0x00037C42
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

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00039A53 File Offset: 0x00037C53
	// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00039A63 File Offset: 0x00037C63
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

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00039A74 File Offset: 0x00037C74
	// (set) Token: 0x06000B8C RID: 2956 RVA: 0x00039A84 File Offset: 0x00037C84
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

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00039A95 File Offset: 0x00037C95
	// (set) Token: 0x06000B8E RID: 2958 RVA: 0x00039AA5 File Offset: 0x00037CA5
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

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00039AB6 File Offset: 0x00037CB6
	// (set) Token: 0x06000B90 RID: 2960 RVA: 0x00039AC6 File Offset: 0x00037CC6
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

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00039AD7 File Offset: 0x00037CD7
	// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00039AE7 File Offset: 0x00037CE7
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

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00039AF8 File Offset: 0x00037CF8
	// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00039B08 File Offset: 0x00037D08
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

	// Token: 0x06000B95 RID: 2965 RVA: 0x00039B1C File Offset: 0x00037D1C
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

	// Token: 0x06000B96 RID: 2966 RVA: 0x00039BA0 File Offset: 0x00037DA0
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

	// Token: 0x06000B97 RID: 2967 RVA: 0x00039C3C File Offset: 0x00037E3C
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

	// Token: 0x06000B98 RID: 2968 RVA: 0x00039DE8 File Offset: 0x00037FE8
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

	// Token: 0x06000B99 RID: 2969 RVA: 0x00039E88 File Offset: 0x00038088
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
		this.ActorComp.SetInputDirect(this.CacheVector, false);
		AiControllerLibrary.TurnToDirect(this.ActorComp, this.CacheVector, this.TsTurnSpeed, false, 0f);
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x0003A000 File Offset: 0x00038200
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

	// Token: 0x06000B9B RID: 2971 RVA: 0x0003A074 File Offset: 0x00038274
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

	// Token: 0x06000B9C RID: 2972 RVA: 0x0003A0C0 File Offset: 0x000382C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void FindWanderLocation()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FindWanderLocation"), out num);
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

	// Token: 0x06000B9D RID: 2973 RVA: 0x0003A130 File Offset: 0x00038330
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

	// Token: 0x06000B9E RID: 2974 RVA: 0x0003A2C8 File Offset: 0x000384C8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void FindWanderPath()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("FindWanderPath"), out num);
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

	// Token: 0x06000B9F RID: 2975 RVA: 0x0003A338 File Offset: 0x00038538
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

	// Token: 0x06000BA0 RID: 2976 RVA: 0x0003A3D0 File Offset: 0x000385D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void DebugDraw()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("DebugDraw"), out num);
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

	// Token: 0x06000BA1 RID: 2977 RVA: 0x0003A440 File Offset: 0x00038640
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

	// Token: 0x06000BA2 RID: 2978 RVA: 0x0003A5B4 File Offset: 0x000387B4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTerritoryWander._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTerritoryWander.TsTaskTerritoryWander_C");
		}
		return TsTaskTerritoryWander._ClassPtr;
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x0003A5D8 File Offset: 0x000387D8
	public TsTaskTerritoryWander() : this(BuiltinUtils.AllocNativeUObject(TsTaskTerritoryWander.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x0003A600 File Offset: 0x00038800
	[NullableContext(1)]
	public TsTaskTerritoryWander(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTerritoryWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x0003A633 File Offset: 0x00038833
	protected TsTaskTerritoryWander(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x0003A648 File Offset: 0x00038848
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x0003A678 File Offset: 0x00038878
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x0003A6AB File Offset: 0x000388AB
	protected virtual void __CPPCALL_FindWanderLocation_Implementation()
	{
		this.FindWanderLocation_Implementation();
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x0003A6B3 File Offset: 0x000388B3
	protected virtual void __CPPCALL_FindWanderPath_Implementation()
	{
		this.FindWanderPath_Implementation();
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x0003A6BB File Offset: 0x000388BB
	protected virtual void __CPPCALL_DebugDraw_Implementation()
	{
		this.DebugDraw_Implementation();
	}

	// Token: 0x0400090A RID: 2314
	private const double PI = 3.14;

	// Token: 0x0400090B RID: 2315
	private const int NAVIGATION_END_TIME = 5000;

	// Token: 0x0400090C RID: 2316
	private const int NAVIGATION_COMPLETE_DISTANCE = 20;

	// Token: 0x0400090D RID: 2317
	private global::Vector RangeCenter;

	// Token: 0x0400090E RID: 2318
	private global::Vector TargetLocation;

	// Token: 0x0400090F RID: 2319
	private bool FoundPath;

	// Token: 0x04000910 RID: 2320
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> NavigationPath;

	// Token: 0x04000911 RID: 2321
	private int CurrentNavigationIndex;

	// Token: 0x04000912 RID: 2322
	private CharacterActorComponent ActorComp;

	// Token: 0x04000913 RID: 2323
	private CharacterMoveComponent MoveComp;

	// Token: 0x04000914 RID: 2324
	private BaseUnifiedStateComponent UnifiedStateComp;

	// Token: 0x04000915 RID: 2325
	private global::Vector CacheVector;

	// Token: 0x04000916 RID: 2326
	private double NavigationEndTime;

	// Token: 0x04000917 RID: 2327
	private bool IsInitTsVariables;

	// Token: 0x04000918 RID: 2328
	[Nullable(1)]
	private string TsRangeCenterKey = "";

	// Token: 0x04000919 RID: 2329
	private float TsRangeRadius;

	// Token: 0x0400091A RID: 2330
	private float TsAngle;

	// Token: 0x0400091B RID: 2331
	private float TsInnerDiameter;

	// Token: 0x0400091C RID: 2332
	private float TsOuterDiameter;

	// Token: 0x0400091D RID: 2333
	private bool TsForceNavigation;

	// Token: 0x0400091E RID: 2334
	private float TsTurnSpeed;

	// Token: 0x0400091F RID: 2335
	private bool TsDebugMode;

	// Token: 0x04000920 RID: 2336
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTerritoryWander.TsTaskTerritoryWander_C";

	// Token: 0x04000921 RID: 2337
	private static IntPtr _ClassPtr;

	// Token: 0x04000922 RID: 2338
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000923 RID: 2339
	private static int __PropertyOffset_RangeCenterKey;

	// Token: 0x04000924 RID: 2340
	private static int __PropertyOffset_RangeRadius;

	// Token: 0x04000925 RID: 2341
	private static int __PropertyOffset_Angle;

	// Token: 0x04000926 RID: 2342
	private static int __PropertyOffset_InnerDiameter;

	// Token: 0x04000927 RID: 2343
	private static int __PropertyOffset_OuterDiameter;

	// Token: 0x04000928 RID: 2344
	private static int __PropertyOffset_ForceNavigation;

	// Token: 0x04000929 RID: 2345
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x0400092A RID: 2346
	private static int __PropertyOffset_DebugMode;
}
