using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200009F RID: 159
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFlee.TsTaskFlee_C")]
public class TsTaskFlee : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000850 RID: 2128 RVA: 0x000291C9 File Offset: 0x000273C9
	// (set) Token: 0x06000851 RID: 2129 RVA: 0x000291DD File Offset: 0x000273DD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFlee.__PropertyOffset_TargetKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFlee.__PropertyOffset_TargetKey)), value);
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000852 RID: 2130 RVA: 0x000291F2 File Offset: 0x000273F2
	// (set) Token: 0x06000853 RID: 2131 RVA: 0x00029202 File Offset: 0x00027402
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OverrideTurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_OverrideTurnSpeed) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_OverrideTurnSpeed) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000854 RID: 2132 RVA: 0x00029213 File Offset: 0x00027413
	// (set) Token: 0x06000855 RID: 2133 RVA: 0x00029223 File Offset: 0x00027423
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000856 RID: 2134 RVA: 0x00029234 File Offset: 0x00027434
	// (set) Token: 0x06000857 RID: 2135 RVA: 0x00029244 File Offset: 0x00027444
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ForceNavigation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_ForceNavigation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_ForceNavigation) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000858 RID: 2136 RVA: 0x00029255 File Offset: 0x00027455
	// (set) Token: 0x06000859 RID: 2137 RVA: 0x00029265 File Offset: 0x00027465
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool LeapMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_LeapMode) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_LeapMode) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x0600085A RID: 2138 RVA: 0x00029276 File Offset: 0x00027476
	// (set) Token: 0x0600085B RID: 2139 RVA: 0x00029286 File Offset: 0x00027486
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LeapDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_LeapDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFlee.__PropertyOffset_LeapDistance) = value;
		}
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00029298 File Offset: 0x00027498
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTargetKey = this.TargetKey;
			this.TsOverrideTurnSpeed = this.OverrideTurnSpeed;
			this.TsTurnSpeed = (float)this.TurnSpeed;
			this.TsForceNavigation = this.ForceNavigation;
			this.TsLeapMode = this.LeapMode;
			this.TsLeapDistance = this.LeapDistance;
		}
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00029304 File Offset: 0x00027504
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

	// Token: 0x0600085E RID: 2142 RVA: 0x000293A0 File Offset: 0x000275A0
	[NullableContext(2)]
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
			return;
		}
		if (aiController.AiFlee == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "没有配置逃跑";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		CharacterActorComponent characterActorComponent = null;
		if (!string.IsNullOrEmpty(this.TsTargetKey))
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(aiController.CharActorComp.Entity.Id, this.TsTargetKey);
			if (entityIdByEntity != null)
			{
				Entity entity = EntitySystem.Instance.Get(entityIdByEntity.Value);
				if (entity != null)
				{
					characterActorComponent = entity.GetComponent<CharacterActorComponent>();
				}
			}
		}
		else
		{
			AiHateList aiHateList = aiController.AiHateList;
			EntityHandle entityHandle = (aiHateList != null) ? aiHateList.GetCurrentTarget() : null;
			CharacterActorComponent characterActorComponent2;
			if (entityHandle == null)
			{
				characterActorComponent2 = null;
			}
			else
			{
				WorldEntity entity2 = entityHandle.Entity;
				characterActorComponent2 = ((entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null);
			}
			characterActorComponent = characterActorComponent2;
		}
		if (characterActorComponent == null)
		{
			this.FoundPath = false;
			base.Finish(true);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.CJH;
			string message3 = "CharacterActorComponent Invalid";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return;
		}
		Entity entity3 = charActorComp.Entity;
		if (entity3 == null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.BehaviorTree;
			ELogAuthor author4 = ELogAuthor.CJH;
			string message4 = "Entity Invalid";
			ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			return;
		}
		this.MoveComp = entity3.GetComponent<CharacterMoveComponent>();
		if (this.MoveComp == null)
		{
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.BehaviorTree;
			ELogAuthor author5 = ELogAuthor.CJH;
			string message5 = "CharacterMoveComponent Invalid";
			ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
			return;
		}
		if (this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Flying)
		{
			this.IsFlying = true;
		}
		global::Vector actorLocationProxy = charActorComp.ActorLocationProxy;
		global::Vector vector = global::Vector.Create();
		actorLocationProxy.Subtraction(characterActorComponent.ActorLocationProxy, vector);
		vector.Z = 0.0;
		vector.Normalize(9.999999974752427E-07);
		global::Vector vector2 = global::Vector.Create(-vector.Y, vector.X, 0.0);
		AiFlee value = aiController.AiFlee.Value;
		double num = MathUtils.Instance.GetRandomRange((double)value.FleeAngle.Value.Min, (double)value.FleeAngle.Value.Max) * 0.01745329238474369;
		double num2 = Math.Cos(num);
		double num3 = Math.Sin(num);
		double randomRange = MathUtils.Instance.GetRandomRange((double)value.FleeDistance.Value.Min, (double)value.FleeDistance.Value.Max);
		double num4 = 0.0;
		if (this.IsFlying)
		{
			num4 = (double)value.FleeHeight;
		}
		FVectorDouble fvectorDouble = new FVectorDouble(actorLocationProxy.X + (vector.X * num2 + vector2.X * num3) * randomRange, actorLocationProxy.Y + (vector.Y * num2 + vector2.Y * num3) * randomRange, actorLocationProxy.Z + num4);
		if (this.NavigationPath == null)
		{
			this.NavigationPath = new List<global::Vector>();
		}
		if (!this.IsFlying)
		{
			this.FoundPath = AiControllerLibrary.NavigationFindPath(ownerController, actorLocationProxy.ToUeVector(false), fvectorDouble, this.NavigationPath, null, null);
		}
		else
		{
			global::Vector item = global::Vector.Create(actorLocationProxy);
			this.FoundPath = true;
			this.NavigationPath.Clear();
			this.NavigationPath.Add(item);
			this.NavigationPath.Add(global::Vector.Create(fvectorDouble));
		}
		if (!this.TsForceNavigation && !this.FoundPath)
		{
			global::Vector item2 = global::Vector.Create(actorLocationProxy);
			this.FoundPath = true;
			this.NavigationPath.Clear();
			this.NavigationPath.Add(item2);
			this.NavigationPath.Add(global::Vector.Create(fvectorDouble));
		}
		if (!this.FoundPath)
		{
			FVectorDouble to = default(FVectorDouble);
			if (UNavigationSystemV1.D_K2_ProjectPointToNavigation(GlobalData.World, fvectorDouble, ref to, null, default(TSubclassOf<UNavigationQueryFilter>), new FVectorDouble(randomRange, randomRange, 100.0), -1.0))
			{
				this.FoundPath = AiControllerLibrary.NavigationFindPath(ownerController, actorLocationProxy.ToUeVector(false), to, this.NavigationPath, null, null);
			}
		}
		if (!this.FoundPath)
		{
			base.Finish(true);
			return;
		}
		this.CurrentNavigationIndex = 1;
		this.NavigationEndTime = Time.Instance.WorldTime + (double)value.TimeMilliseconds;
		BaseUnifiedStateComponent component = aiController.CharAiDesignComp.Entity.GetComponent<BaseUnifiedStateComponent>();
		if (component != null && component.Valid)
		{
			component.SetMoveState(ECharMoveState.Run);
		}
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x000298EC File Offset: 0x00027AEC
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

	// Token: 0x06000860 RID: 2144 RVA: 0x0002998C File Offset: 0x00027B8C
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			base.FinishExecute(false);
			return;
		}
		if (Time.Instance.WorldTime > this.NavigationEndTime)
		{
			base.Finish(true);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (this.MoveComp.CharacterMovement.MovementMode == EMovementMode.MOVE_Flying)
		{
			this.IsFlying = true;
		}
		else
		{
			this.IsFlying = false;
		}
		global::Vector vector = global::Vector.Create(this.NavigationPath[this.CurrentNavigationIndex]);
		vector.Subtraction(charActorComp.ActorLocationProxy, vector);
		if (!this.IsFlying)
		{
			GravityUtils.Instance.ConvertToPlanarVectorForActor(charActorComp, vector);
		}
		double num = vector.Size();
		this.CompleteDistance = (this.TsLeapMode ? this.TsLeapDistance : 50f);
		if (num < (double)this.CompleteDistance)
		{
			this.CurrentNavigationIndex++;
			if (this.CurrentNavigationIndex == this.NavigationPath.Count)
			{
				base.Finish(true);
				return;
			}
		}
		vector.Z /= num;
		vector.X /= num;
		vector.Y /= num;
		charActorComp.SetInputDirect(vector, false);
		if (this.TsOverrideTurnSpeed)
		{
			AiControllerLibrary.TurnToDirect(charActorComp, vector, this.TsTurnSpeed, false, 0f);
			return;
		}
		CharacterActorComponent actorComp = charActorComp;
		global::Vector direct = vector;
		AiWanderInfos aiWanderInfos = aiController.AiWanderInfos;
		AiControllerLibrary.TurnToDirect(actorComp, direct, (aiWanderInfos != null && aiWanderInfos.AiWander != null) ? aiController.AiWanderInfos.AiWander.Value.TurnSpeed : 360f, false, 0f);
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00029B30 File Offset: 0x00027D30
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			AiControllerLibrary.ClearInput(tsAiController);
		}
		this.MoveComp = null;
		this.NavigationPath = null;
		this.FoundPath = false;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00029B67 File Offset: 0x00027D67
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFlee._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFlee.TsTaskFlee_C");
		}
		return TsTaskFlee._ClassPtr;
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00029B8C File Offset: 0x00027D8C
	public TsTaskFlee() : this(BuiltinUtils.AllocNativeUObject(TsTaskFlee.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00029BB4 File Offset: 0x00027DB4
	public TsTaskFlee(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFlee.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00029BE7 File Offset: 0x00027DE7
	protected TsTaskFlee(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00029BFC File Offset: 0x00027DFC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00029C2C File Offset: 0x00027E2C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000639 RID: 1593
	private const float NEAR_ZERO = 1E-06f;

	// Token: 0x0400063A RID: 1594
	private const float NAVIGATION_COMPLETE_DISTANCE = 50f;

	// Token: 0x0400063B RID: 1595
	private const double EDGE_Z = 100.0;

	// Token: 0x0400063C RID: 1596
	private bool IsInitTsVariables;

	// Token: 0x0400063D RID: 1597
	private string TsTargetKey = "";

	// Token: 0x0400063E RID: 1598
	private bool TsOverrideTurnSpeed;

	// Token: 0x0400063F RID: 1599
	private float TsTurnSpeed;

	// Token: 0x04000640 RID: 1600
	private bool TsForceNavigation;

	// Token: 0x04000641 RID: 1601
	private bool TsLeapMode;

	// Token: 0x04000642 RID: 1602
	private float TsLeapDistance;

	// Token: 0x04000643 RID: 1603
	private bool FoundPath;

	// Token: 0x04000644 RID: 1604
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> NavigationPath;

	// Token: 0x04000645 RID: 1605
	private int CurrentNavigationIndex;

	// Token: 0x04000646 RID: 1606
	private double NavigationEndTime;

	// Token: 0x04000647 RID: 1607
	private bool IsFlying;

	// Token: 0x04000648 RID: 1608
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x04000649 RID: 1609
	private float CompleteDistance;

	// Token: 0x0400064A RID: 1610
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFlee.TsTaskFlee_C";

	// Token: 0x0400064B RID: 1611
	private static IntPtr _ClassPtr;

	// Token: 0x0400064C RID: 1612
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400064D RID: 1613
	private static int __PropertyOffset_TargetKey;

	// Token: 0x0400064E RID: 1614
	private static int __PropertyOffset_OverrideTurnSpeed;

	// Token: 0x0400064F RID: 1615
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000650 RID: 1616
	private static int __PropertyOffset_ForceNavigation;

	// Token: 0x04000651 RID: 1617
	private static int __PropertyOffset_LeapMode;

	// Token: 0x04000652 RID: 1618
	private static int __PropertyOffset_LeapDistance;
}
