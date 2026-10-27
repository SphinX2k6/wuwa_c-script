using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using CSharpScript.Game.World.Controller;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200005D RID: 93
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskQueryFleeLocation.TsTaskQueryFleeLocation_C")]
public class TsTaskQueryFleeLocation : TsTaskAbortImmediatelyBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x060003A1 RID: 929 RVA: 0x00010D18 File Offset: 0x0000EF18
	static TsTaskQueryFleeLocation()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsTaskQueryFleeLocation.CreateStaticDefaultValue), new Action(TsTaskQueryFleeLocation.ResetStaticDefaultValue));
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00010D74 File Offset: 0x0000EF74
	public static void CreateStaticDefaultValue()
	{
		TsTaskQueryFleeLocation.QuaternionQueue = new List<Quat>();
		TsTaskQueryFleeLocation.QuaternionQueue.Add(Quat.Create(0.0, 0.0, 0.0, 1.0));
		int num = 6;
		for (int i = 1; i < num; i++)
		{
			float num2 = (float)((double)(i * 30) * 0.5 * 0.01745329238474369);
			Quat item = Quat.Create(0.0, 0.0, Math.Sin((double)num2), Math.Cos((double)num2));
			TsTaskQueryFleeLocation.QuaternionQueue.Add(item);
			Quat item2 = Quat.Create(0.0, 0.0, Math.Sin((double)(-(double)num2)), Math.Cos((double)(-(double)num2)));
			TsTaskQueryFleeLocation.QuaternionQueue.Add(item2);
		}
		TsTaskQueryFleeLocation.StaticVariablesInited = true;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00010E59 File Offset: 0x0000F059
	public static void ResetStaticDefaultValue()
	{
		TsTaskQueryFleeLocation.QuaternionQueue = null;
		TsTaskQueryFleeLocation.StaticVariablesInited = false;
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060003A4 RID: 932 RVA: 0x00010E67 File Offset: 0x0000F067
	// (set) Token: 0x060003A5 RID: 933 RVA: 0x00010E7B File Offset: 0x0000F07B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskQueryFleeLocation.__PropertyOffset_TargetKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskQueryFleeLocation.__PropertyOffset_TargetKey)), value);
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060003A6 RID: 934 RVA: 0x00010E90 File Offset: 0x0000F090
	// (set) Token: 0x060003A7 RID: 935 RVA: 0x00010EA0 File Offset: 0x0000F0A0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskQueryFleeLocation.__PropertyOffset_DebugMode) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskQueryFleeLocation.__PropertyOffset_DebugMode) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060003A8 RID: 936 RVA: 0x00010EB1 File Offset: 0x0000F0B1
	// (set) Token: 0x060003A9 RID: 937 RVA: 0x00010EC1 File Offset: 0x0000F0C1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Radius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskQueryFleeLocation.__PropertyOffset_Radius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskQueryFleeLocation.__PropertyOffset_Radius) = value;
		}
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00010ED4 File Offset: 0x0000F0D4
	private static void InitStaticVariables()
	{
		TsTaskQueryFleeLocation.QuaternionQueue = new List<Quat>();
		TsTaskQueryFleeLocation.QuaternionQueue.Add(Quat.Create(0.0, 0.0, 0.0, 1.0));
		int num = 6;
		for (int i = 1; i < num; i++)
		{
			float num2 = (float)((double)(i * 30) * 0.5 * 0.01745329238474369);
			Quat item = Quat.Create(0.0, 0.0, Math.Sin((double)num2), Math.Cos((double)num2));
			TsTaskQueryFleeLocation.QuaternionQueue.Add(item);
			Quat item2 = Quat.Create(0.0, 0.0, Math.Sin((double)(-(double)num2)), Math.Cos((double)(-(double)num2)));
			TsTaskQueryFleeLocation.QuaternionQueue.Add(item2);
		}
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00010FB4 File Offset: 0x0000F1B4
	private void InitTsVariables(AiController aiController)
	{
		if (!this.IsInitTsVariables)
		{
			this.TsTargetKey = this.TargetKey;
			this.TsRadius = this.Radius;
			this.VectorCache1 = Vector.Create();
			this.VectorCache2 = Vector.Create();
			this.VectorCache3 = Vector.Create();
			this.QuatNodeQueue = new List<QuatNode>();
			foreach (Quat quat in TsTaskQueryFleeLocation.QuaternionQueue)
			{
				QuatNode item = new QuatNode(quat, Math.Abs(quat.Z));
				this.QuatNodeQueue.Add(item);
			}
			this.NavigationPath = new List<Vector>();
			this.CdInternal = -1.0;
			this.IsInitTsVariables = true;
		}
	}

	// Token: 0x060003AC RID: 940 RVA: 0x0001108C File Offset: 0x0000F28C
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

	// Token: 0x060003AD RID: 941 RVA: 0x00011128 File Offset: 0x0000F328
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (!TsTaskQueryFleeLocation.StaticVariablesInited)
		{
			TsTaskQueryFleeLocation.InitStaticVariables();
			TsTaskQueryFleeLocation.StaticVariablesInited = true;
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
		this.InitTsVariables(aiController);
		bool animalDebug = ServerGmController.Instance.AnimalDebug;
		if (animalDebug)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "AnimalDebug SwitchAnimalState2";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WorldTimeSeconds", Time.Instance.WorldTimeSeconds);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CdInternal", this.CdInternal);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		if (Time.Instance.WorldTimeSeconds < this.CdInternal)
		{
			base.Finish(false);
			return;
		}
		this.CdInternal = Time.Instance.WorldTimeSeconds + 0.5;
		this.Character = aiController.CharActorComp;
		if (!this.FindTarget())
		{
			if (ServerGmController.Instance.AnimalDebug)
			{
				Log.Instance.Info(ELogModule.AI, ELogAuthor.LCZ, "AnimalDebug QueryFlee2 FindTarget Failed", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			base.Finish(false);
			return;
		}
		if (!this.QueryFleeLocation())
		{
			if (animalDebug)
			{
				Log.Instance.Info(ELogModule.AI, ELogAuthor.LCZ, "AnimalDebug QueryFlee3 QueryFleeLocation Failed", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			base.Finish(false);
			return;
		}
		int count = this.NavigationPath.Count;
		Vector vector = this.NavigationPath[count - 1];
		BlackboardController.Instance.SetVectorValueByEntity(this.Character.Entity.Id, "FleeLocation", (double)((float)vector.X), (double)((float)vector.Y), (double)((float)vector.Z));
		if (animalDebug)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.AI;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "AnimalDebug QueryFlee4";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("FleeLocation", vector);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		base.Finish(true);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00011364 File Offset: 0x0000F564
	private bool FindTarget()
	{
		if (this.TsTargetKey != "")
		{
			int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(this.Character.Entity.Id, this.TsTargetKey);
			if (entityIdByEntity != null)
			{
				Entity entity = EntitySystem.Instance.Get(entityIdByEntity.Value);
				if (entity != null)
				{
					this.TargetCharacter = entity.GetComponent<CharacterActorComponent>();
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x000113D4 File Offset: 0x0000F5D4
	private unsafe bool QueryFleeLocation()
	{
		Vector actorLocationProxy = this.Character.ActorLocationProxy;
		actorLocationProxy.Subtraction(this.TargetCharacter.ActorLocationProxy, this.VectorCache1);
		this.VectorCache1.Z = 0.0;
		this.VectorCache1.Normalize(9.99999993922529E-09);
		this.VectorCache3.DeepCopy(this.VectorCache1);
		this.VectorCache1.MultiplyEqual((double)this.TsRadius);
		this.FoundPath = false;
		Vector actorForwardProxy = this.Character.ActorForwardProxy;
		foreach (QuatNode quatNode in this.QuatNodeQueue)
		{
			quatNode.Quaternion.RotateVector(this.VectorCache1, this.VectorCache2);
			quatNode.VectorCache.DeepCopy(this.VectorCache2);
			this.VectorCache2.Z = 0.0;
			this.VectorCache2.Normalize(9.99999993922529E-09);
			quatNode.Cost = 0.5 * (1.0 - actorForwardProxy.DotProduct(this.VectorCache2));
			quatNode.VectorCache.AdditionEqual(actorLocationProxy);
		}
		double turnCostWeight = 0.25;
		double num = this.VectorCache3.DotProduct(actorForwardProxy);
		if (num > 0.707)
		{
			turnCostWeight = 1.0;
		}
		else if (num > 0.0)
		{
			turnCostWeight = 0.75;
		}
		this.QuatNodeQueue.Sort((QuatNode a, QuatNode b) => (turnCostWeight * (a.Cost - b.Cost) + (1.0 - turnCostWeight) * (a.CostBase - b.CostBase)).CompareTo(0.0));
		this.DebugDraw2();
		foreach (QuatNode quatNode2 in this.QuatNodeQueue)
		{
			FVectorDouble fvectorDouble = default(FVectorDouble);
			UObject world = GlobalData.World;
			FVectorDouble fvectorDouble2 = quatNode2.VectorCache.ToUeVector(false);
			if (UNavigationSystemV1.D_K2_ProjectPointToNavigation(world, fvectorDouble2, ref fvectorDouble, null, default(TSubclassOf<UNavigationQueryFilter>), TsTaskQueryFleeLocation.QueryExtent, -1.0))
			{
				Vector vector = Vector.Create(fvectorDouble);
				bool flag = AiControllerLibrary.NavigationFindPath(GlobalData.World, actorLocationProxy.ToUeVector(false), vector.ToUeVector(false), this.NavigationPath, null, null);
				if (flag)
				{
					this.FoundPath = flag;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Test;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "FoundPath";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "Actor";
					CharacterActorComponent character = this.Character;
					ptr = new ValueTuple<string, object>(item, (character != null) ? character.Actor.GetName() : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("target", vector);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("self", actorLocationProxy);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				if (this.FoundPath)
				{
					if (GlobalData.IsPlayInEditor && this.DebugMode)
					{
						this.DebugDraw(vector.ToUeVector(false), ColorUtils.LinearGreen);
						break;
					}
					break;
				}
				else if (GlobalData.IsPlayInEditor && this.DebugMode)
				{
					this.DebugDraw(quatNode2.VectorCache.ToUeVector(false), ColorUtils.LinearRed);
				}
			}
			else if (GlobalData.IsPlayInEditor && this.DebugMode)
			{
				this.DebugDraw(quatNode2.VectorCache.ToUeVector(false), ColorUtils.LinearRed);
			}
		}
		return this.FoundPath;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00011798 File Offset: 0x0000F998
	private void DebugDraw(FVectorDouble location, FLinearColor color)
	{
		UKismetSystemLibrary.D_DrawDebugSphere(this, location, 20f, 10, new FLinearColor?(color), 5f, 0f);
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x000117B8 File Offset: 0x0000F9B8
	private void DebugDraw2()
	{
		bool isPlayInEditor = GlobalData.IsPlayInEditor;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x000117CB File Offset: 0x0000F9CB
	protected override void OnClear()
	{
		this.Character = null;
		this.TargetCharacter = null;
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x000117DB File Offset: 0x0000F9DB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskQueryFleeLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskQueryFleeLocation.TsTaskQueryFleeLocation_C");
		}
		return TsTaskQueryFleeLocation._ClassPtr;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00011800 File Offset: 0x0000FA00
	public TsTaskQueryFleeLocation() : this(BuiltinUtils.AllocNativeUObject(TsTaskQueryFleeLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00011828 File Offset: 0x0000FA28
	public TsTaskQueryFleeLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskQueryFleeLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x0001185B File Offset: 0x0000FA5B
	protected TsTaskQueryFleeLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x0001187C File Offset: 0x0000FA7C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000269 RID: 617
	private const string BLACKBOARD_KEY_FLEE_LOCATION = "FleeLocation";

	// Token: 0x0400026A RID: 618
	private const int ANGLE_INTERVAL = 30;

	// Token: 0x0400026B RID: 619
	private const int RADIUS = 300;

	// Token: 0x0400026C RID: 620
	private const double TURN_COST_WEIGHT = 0.25;

	// Token: 0x0400026D RID: 621
	private const double TURN_COST_WEIGHT_2 = 0.75;

	// Token: 0x0400026E RID: 622
	private const double TURN_COST_WEIGHT_3 = 1.0;

	// Token: 0x0400026F RID: 623
	private const int TURN_COST_DIVIDING_LINE_2 = 0;

	// Token: 0x04000270 RID: 624
	private const double TURN_COST_DIVIDING_LINE_3 = 0.707;

	// Token: 0x04000271 RID: 625
	private const bool TEST_MODE = false;

	// Token: 0x04000272 RID: 626
	private const double QUERY_LOCATION_CD = 0.5;

	// Token: 0x04000273 RID: 627
	private static readonly FVectorDouble QueryExtent = new FVectorDouble(100.0, 100.0, 1000.0);

	// Token: 0x04000274 RID: 628
	[Nullable(2)]
	private CharacterActorComponent Character;

	// Token: 0x04000275 RID: 629
	[Nullable(2)]
	private CharacterActorComponent TargetCharacter;

	// Token: 0x04000276 RID: 630
	private bool IsInitTsVariables;

	// Token: 0x04000277 RID: 631
	private string TsTargetKey = "";

	// Token: 0x04000278 RID: 632
	private int TsRadius = 300;

	// Token: 0x04000279 RID: 633
	[Nullable(2)]
	private Vector VectorCache1;

	// Token: 0x0400027A RID: 634
	[Nullable(2)]
	private Vector VectorCache2;

	// Token: 0x0400027B RID: 635
	[Nullable(2)]
	private Vector VectorCache3;

	// Token: 0x0400027C RID: 636
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<QuatNode> QuatNodeQueue;

	// Token: 0x0400027D RID: 637
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> NavigationPath;

	// Token: 0x0400027E RID: 638
	private bool FoundPath;

	// Token: 0x0400027F RID: 639
	private double CdInternal;

	// Token: 0x04000280 RID: 640
	private static bool StaticVariablesInited = false;

	// Token: 0x04000281 RID: 641
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<Quat> QuaternionQueue = null;

	// Token: 0x04000282 RID: 642
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskQueryFleeLocation.TsTaskQueryFleeLocation_C";

	// Token: 0x04000283 RID: 643
	private static IntPtr _ClassPtr;

	// Token: 0x04000284 RID: 644
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000285 RID: 645
	private static int __PropertyOffset_TargetKey;

	// Token: 0x04000286 RID: 646
	private static int __PropertyOffset_DebugMode;

	// Token: 0x04000287 RID: 647
	private static int __PropertyOffset_Radius;
}
