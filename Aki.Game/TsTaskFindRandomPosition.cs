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
	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000841 RID: 2113 RVA: 0x00029C39 File Offset: 0x00027E39
	// (set) Token: 0x06000842 RID: 2114 RVA: 0x00029C4D File Offset: 0x00027E4D
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

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000843 RID: 2115 RVA: 0x00029C62 File Offset: 0x00027E62
	// (set) Token: 0x06000844 RID: 2116 RVA: 0x00029C72 File Offset: 0x00027E72
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

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000845 RID: 2117 RVA: 0x00029C83 File Offset: 0x00027E83
	// (set) Token: 0x06000846 RID: 2118 RVA: 0x00029C93 File Offset: 0x00027E93
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

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06000847 RID: 2119 RVA: 0x00029CA4 File Offset: 0x00027EA4
	// (set) Token: 0x06000848 RID: 2120 RVA: 0x00029CB4 File Offset: 0x00027EB4
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

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000849 RID: 2121 RVA: 0x00029CC5 File Offset: 0x00027EC5
	// (set) Token: 0x0600084A RID: 2122 RVA: 0x00029CD9 File Offset: 0x00027ED9
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

	// Token: 0x0600084B RID: 2123 RVA: 0x00029CF0 File Offset: 0x00027EF0
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

	// Token: 0x0600084C RID: 2124 RVA: 0x00029D5C File Offset: 0x00027F5C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFindRandomPosition) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskFindRandomPosition.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600084D RID: 2125 RVA: 0x00029E0C File Offset: 0x0002800C
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

	// Token: 0x0600084E RID: 2126 RVA: 0x00029ECC File Offset: 0x000280CC
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

	// Token: 0x0600084F RID: 2127 RVA: 0x00029F56 File Offset: 0x00028156
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindRandomPosition._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindRandomPosition.TsTaskFindRandomPosition_C");
		}
		return TsTaskFindRandomPosition._ClassPtr;
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00029F7C File Offset: 0x0002817C
	public TsTaskFindRandomPosition() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindRandomPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00029FA4 File Offset: 0x000281A4
	public TsTaskFindRandomPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindRandomPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00029FD7 File Offset: 0x000281D7
	protected TsTaskFindRandomPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00029FEC File Offset: 0x000281EC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400062E RID: 1582
	private const float PI_DEG_DOUBLE = 360f;

	// Token: 0x0400062F RID: 1583
	private bool IsInitTsVariables;

	// Token: 0x04000630 RID: 1584
	[Nullable(2)]
	private Vector TsStartPositionOffset;

	// Token: 0x04000631 RID: 1585
	private float TsMinRange;

	// Token: 0x04000632 RID: 1586
	private float TsMaxRange;

	// Token: 0x04000633 RID: 1587
	private bool TsUseFullRange;

	// Token: 0x04000634 RID: 1588
	private string TsSaveBlackBoardKey = "";

	// Token: 0x04000635 RID: 1589
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindRandomPosition.TsTaskFindRandomPosition_C";

	// Token: 0x04000636 RID: 1590
	private static IntPtr _ClassPtr;

	// Token: 0x04000637 RID: 1591
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000638 RID: 1592
	private static int __PropertyOffset_StartPositionOffset;

	// Token: 0x04000639 RID: 1593
	private static int __PropertyOffset_MinRange;

	// Token: 0x0400063A RID: 1594
	private static int __PropertyOffset_MaxRange;

	// Token: 0x0400063B RID: 1595
	private static int __PropertyOffset_UseFullRange;

	// Token: 0x0400063C RID: 1596
	private static int __PropertyOffset_SaveBlackBoardKey;
}
