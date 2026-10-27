using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200009E RID: 158
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindRandomPosition.TsTaskFindRandomPosition_C")]
public class TsTaskFindRandomPosition : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700015D RID: 349
	// (get) Token: 0x0600083D RID: 2109 RVA: 0x00028DFD File Offset: 0x00026FFD
	// (set) Token: 0x0600083E RID: 2110 RVA: 0x00028E11 File Offset: 0x00027011
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector StartPositionOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindRandomPosition.__PropertyOffset_StartPositionOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindRandomPosition.__PropertyOffset_StartPositionOffset) = value;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x0600083F RID: 2111 RVA: 0x00028E26 File Offset: 0x00027026
	// (set) Token: 0x06000840 RID: 2112 RVA: 0x00028E36 File Offset: 0x00027036
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MinRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindRandomPosition.__PropertyOffset_MinRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindRandomPosition.__PropertyOffset_MinRange) = value;
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000841 RID: 2113 RVA: 0x00028E47 File Offset: 0x00027047
	// (set) Token: 0x06000842 RID: 2114 RVA: 0x00028E57 File Offset: 0x00027057
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindRandomPosition.__PropertyOffset_MaxRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindRandomPosition.__PropertyOffset_MaxRange) = value;
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000843 RID: 2115 RVA: 0x00028E68 File Offset: 0x00027068
	// (set) Token: 0x06000844 RID: 2116 RVA: 0x00028E78 File Offset: 0x00027078
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseFullRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindRandomPosition.__PropertyOffset_UseFullRange) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindRandomPosition.__PropertyOffset_UseFullRange) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000845 RID: 2117 RVA: 0x00028E89 File Offset: 0x00027089
	// (set) Token: 0x06000846 RID: 2118 RVA: 0x00028E9D File Offset: 0x0002709D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string SaveBlackBoardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindRandomPosition.__PropertyOffset_SaveBlackBoardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindRandomPosition.__PropertyOffset_SaveBlackBoardKey)), value);
		}
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00028EB4 File Offset: 0x000270B4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsStartPositionOffset = Vector.Create(this.StartPositionOffset);
			this.TsMinRange = this.MinRange;
			this.TsMaxRange = this.MaxRange;
			this.TsUseFullRange = this.UseFullRange;
			this.TsSaveBlackBoardKey = this.SaveBlackBoardKey;
		}
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00028F20 File Offset: 0x00027120
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

	// Token: 0x06000849 RID: 2121 RVA: 0x00028FBC File Offset: 0x000271BC
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
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (!string.IsNullOrEmpty(this.TsSaveBlackBoardKey))
		{
			Vector vector = this.CalculateTargetPosition(charActorComp);
			BlackboardController.Instance.SetVectorValueByEntity(charActorComp.Entity.Id, this.TsSaveBlackBoardKey, (double)((float)vector.X), (double)((float)vector.Y), (double)((float)vector.Z));
		}
		base.FinishExecute(true);
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x0002907C File Offset: 0x0002727C
	private Vector CalculateTargetPosition(CharacterActorComponent actorComp)
	{
		Vector actorLocationProxy = actorComp.ActorLocationProxy;
		IVector actorForwardProxy = actorComp.ActorForwardProxy;
		float randomFloatNumber = MathUtils.Instance.GetRandomFloatNumber(0f, 360f);
		Vector vector = Vector.Create(actorForwardProxy);
		vector.RotateAngleAxis((double)randomFloatNumber, Vector.UpVectorProxy, vector);
		Vector vector2 = Vector.Create(this.TsStartPositionOffset);
		vector2.AdditionEqual(actorLocationProxy);
		Vector inB = vector.MultiplyEqual((double)(this.TsUseFullRange ? this.TsMaxRange : MathUtils.Instance.GetRandomFloatNumber(this.TsMinRange, this.TsMaxRange)));
		return vector2.AdditionEqual(inB);
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00029106 File Offset: 0x00027306
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindRandomPosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindRandomPosition.TsTaskFindRandomPosition_C");
		}
		return TsTaskFindRandomPosition._ClassPtr;
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x0002912C File Offset: 0x0002732C
	public TsTaskFindRandomPosition() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindRandomPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00029154 File Offset: 0x00027354
	public TsTaskFindRandomPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindRandomPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00029187 File Offset: 0x00027387
	protected TsTaskFindRandomPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0002919C File Offset: 0x0002739C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400062A RID: 1578
	private const float PI_DEG_DOUBLE = 360f;

	// Token: 0x0400062B RID: 1579
	private bool IsInitTsVariables;

	// Token: 0x0400062C RID: 1580
	[Nullable(2)]
	private Vector TsStartPositionOffset;

	// Token: 0x0400062D RID: 1581
	private float TsMinRange;

	// Token: 0x0400062E RID: 1582
	private float TsMaxRange;

	// Token: 0x0400062F RID: 1583
	private bool TsUseFullRange;

	// Token: 0x04000630 RID: 1584
	private string TsSaveBlackBoardKey = "";

	// Token: 0x04000631 RID: 1585
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindRandomPosition.TsTaskFindRandomPosition_C";

	// Token: 0x04000632 RID: 1586
	private static IntPtr _ClassPtr;

	// Token: 0x04000633 RID: 1587
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000634 RID: 1588
	private static int __PropertyOffset_StartPositionOffset;

	// Token: 0x04000635 RID: 1589
	private static int __PropertyOffset_MinRange;

	// Token: 0x04000636 RID: 1590
	private static int __PropertyOffset_MaxRange;

	// Token: 0x04000637 RID: 1591
	private static int __PropertyOffset_UseFullRange;

	// Token: 0x04000638 RID: 1592
	private static int __PropertyOffset_SaveBlackBoardKey;
}
