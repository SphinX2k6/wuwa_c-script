using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField;
using CSharpScript.Game.NewWorld.SceneItem.Controller;
using CSharpScript.Game.NewWorld.SceneItem.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200005B RID: 91
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskGraphSelectPoint.TsTaskGraphSelectPoint_C")]
public class TsTaskGraphSelectPoint : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000087 RID: 135
	// (get) Token: 0x0600038D RID: 909 RVA: 0x00010738 File Offset: 0x0000E938
	// (set) Token: 0x0600038E RID: 910 RVA: 0x0001074C File Offset: 0x0000E94C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetPointKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_TargetPointKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_TargetPointKey)), value);
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x0600038F RID: 911 RVA: 0x00010761 File Offset: 0x0000E961
	// (set) Token: 0x06000390 RID: 912 RVA: 0x00010775 File Offset: 0x0000E975
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetNodeIdKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_TargetNodeIdKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_TargetNodeIdKey)), value);
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x06000391 RID: 913 RVA: 0x0001078A File Offset: 0x0000E98A
	// (set) Token: 0x06000392 RID: 914 RVA: 0x0001079A File Offset: 0x0000E99A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OnNodeRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_OnNodeRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_OnNodeRadius) = value;
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x06000393 RID: 915 RVA: 0x000107AB File Offset: 0x0000E9AB
	// (set) Token: 0x06000394 RID: 916 RVA: 0x000107BB File Offset: 0x0000E9BB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool AwayFromPlayer
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_AwayFromPlayer) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_AwayFromPlayer) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000395 RID: 917 RVA: 0x000107CC File Offset: 0x0000E9CC
	// (set) Token: 0x06000396 RID: 918 RVA: 0x000107DC File Offset: 0x0000E9DC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FindGraphRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_FindGraphRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskGraphSelectPoint.__PropertyOffset_FindGraphRadius) = value;
		}
	}

	// Token: 0x06000397 RID: 919 RVA: 0x000107F0 File Offset: 0x0000E9F0
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTargetPointKey = this.TargetPointKey;
			this.TsTargetNodeIdKey = this.TargetNodeIdKey;
			this.TsOnNodeRadius = ((this.OnNodeRadius > 0f) ? this.OnNodeRadius : 100f);
			this.TsAwayFromPlayer = this.AwayFromPlayer;
			this.TsFindGraphRadius = this.FindGraphRadius;
		}
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00010864 File Offset: 0x0000EA64
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

	// Token: 0x06000399 RID: 921 RVA: 0x00010900 File Offset: 0x0000EB00
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.XDW;
			string message = "错误的Controller类型";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", (ownerController != null) ? ownerController.GetClass().GetName() : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NodeName", base.NodeName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NodeId", base.NodeId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			base.Finish(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			base.Finish(false);
			return;
		}
		if (this.TsTargetPointKey == "")
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.XDW;
			string message2 = "未配置TargetPointKey";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NodeName", base.NodeName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("NodeId", base.NodeId);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			base.Finish(false);
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null)
		{
			base.Finish(false);
			return;
		}
		Vector actorLocationProxy = charActorComp.ActorLocationProxy;
		ISceneItemGraph sceneItemGraph = SceneItemGraphController.Instance.FindNearestGraph(actorLocationProxy, this.TsFindGraphRadius);
		if (sceneItemGraph == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.XDW;
			string message3 = "场景中找不到3D图组件";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("EntityId", charActorComp.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("NodeName", base.NodeName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("NodeId", base.NodeId);
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			base.Finish(false);
			return;
		}
		ISceneItemGraphSelectResult sceneItemGraphSelectResult;
		if (this.TsAwayFromPlayer)
		{
			Vector tempPlayerLocation = TsTaskGraphSelectPoint.TempPlayerLocation;
			tempPlayerLocation.DeepCopy(characterActorComponent.ActorLocationProxy);
			sceneItemGraphSelectResult = ElementalFieldGraphController.Instance.SelectFleePoint(sceneItemGraph, actorLocationProxy, tempPlayerLocation, this.TsOnNodeRadius, null);
		}
		else
		{
			sceneItemGraphSelectResult = ElementalFieldGraphController.Instance.SelectWanderPoint(sceneItemGraph, actorLocationProxy, this.TsOnNodeRadius, null);
		}
		if (sceneItemGraphSelectResult == null)
		{
			base.Finish(false);
			return;
		}
		int id = charActorComp.Entity.Id;
		BlackboardController.Instance.SetVectorValueByEntity(id, this.TsTargetPointKey, (double)((float)sceneItemGraphSelectResult.Location.X), (double)((float)sceneItemGraphSelectResult.Location.Y), (double)((float)sceneItemGraphSelectResult.Location.Z));
		if (this.TsTargetNodeIdKey != "")
		{
			BlackboardController.Instance.SetIntValueByEntity(id, this.TsTargetNodeIdKey, sceneItemGraphSelectResult.NodeId);
		}
		base.Finish(true);
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00010C00 File Offset: 0x0000EE00
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskGraphSelectPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskGraphSelectPoint.TsTaskGraphSelectPoint_C");
		}
		return TsTaskGraphSelectPoint._ClassPtr;
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00010C24 File Offset: 0x0000EE24
	public TsTaskGraphSelectPoint() : this(BuiltinUtils.AllocNativeUObject(TsTaskGraphSelectPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00010C4C File Offset: 0x0000EE4C
	public TsTaskGraphSelectPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGraphSelectPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00010C7F File Offset: 0x0000EE7F
	protected TsTaskGraphSelectPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00010CA8 File Offset: 0x0000EEA8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000255 RID: 597
	private const int DEFAULT_ON_NODE_RADIUS = 100;

	// Token: 0x04000256 RID: 598
	private bool IsInitTsVariables;

	// Token: 0x04000257 RID: 599
	private string TsTargetPointKey = "";

	// Token: 0x04000258 RID: 600
	private string TsTargetNodeIdKey = "";

	// Token: 0x04000259 RID: 601
	private float TsOnNodeRadius;

	// Token: 0x0400025A RID: 602
	private bool TsAwayFromPlayer = true;

	// Token: 0x0400025B RID: 603
	private float TsFindGraphRadius;

	// Token: 0x0400025C RID: 604
	[StaticVariableRuleIgnore]
	private static readonly Vector TempPlayerLocation = Vector.Create();

	// Token: 0x0400025D RID: 605
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskGraphSelectPoint.TsTaskGraphSelectPoint_C";

	// Token: 0x0400025E RID: 606
	private static IntPtr _ClassPtr;

	// Token: 0x0400025F RID: 607
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000260 RID: 608
	private static int __PropertyOffset_TargetPointKey;

	// Token: 0x04000261 RID: 609
	private static int __PropertyOffset_TargetNodeIdKey;

	// Token: 0x04000262 RID: 610
	private static int __PropertyOffset_OnNodeRadius;

	// Token: 0x04000263 RID: 611
	private static int __PropertyOffset_AwayFromPlayer;

	// Token: 0x04000264 RID: 612
	private static int __PropertyOffset_FindGraphRadius;
}
