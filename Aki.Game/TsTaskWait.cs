using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000CF RID: 207
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWait.TsTaskWait_C")]
public class TsTaskWait : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000241 RID: 577
	// (get) Token: 0x06000C44 RID: 3140 RVA: 0x0003EB8B File Offset: 0x0003CD8B
	// (set) Token: 0x06000C45 RID: 3141 RVA: 0x0003EB9B File Offset: 0x0003CD9B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int TimeMillisecond
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWait.__PropertyOffset_TimeMillisecond);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWait.__PropertyOffset_TimeMillisecond) = value;
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0003EBAC File Offset: 0x0003CDAC
	// (set) Token: 0x06000C47 RID: 3143 RVA: 0x0003EBC0 File Offset: 0x0003CDC0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyTime
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWait.__PropertyOffset_BlackboardKeyTime)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskWait.__PropertyOffset_BlackboardKeyTime)), value);
		}
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0003EBD5 File Offset: 0x0003CDD5
	// (set) Token: 0x06000C49 RID: 3145 RVA: 0x0003EBE5 File Offset: 0x0003CDE5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int RandomTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskWait.__PropertyOffset_RandomTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskWait.__PropertyOffset_RandomTime) = value;
		}
	}

	// Token: 0x06000C4A RID: 3146 RVA: 0x0003EBF6 File Offset: 0x0003CDF6
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTimeMillisecond = this.TimeMillisecond;
			this.TsBlackboardKeyTime = this.BlackboardKeyTime;
			this.TsRandomTime = this.RandomTime;
		}
	}

	// Token: 0x06000C4B RID: 3147 RVA: 0x0003EC34 File Offset: 0x0003CE34
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

	// Token: 0x06000C4C RID: 3148 RVA: 0x0003ECD0 File Offset: 0x0003CED0
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		int num = this.TsTimeMillisecond;
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController != null && this.TsBlackboardKeyTime != "")
		{
			int valueOrDefault = BlackboardController.Instance.GetIntValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardKeyTime).GetValueOrDefault();
			if (valueOrDefault != 0)
			{
				num = valueOrDefault;
			}
		}
		this.EndTime = Time.Instance.Now + (double)num + MathUtils.Instance.GetRandomRange(0.0, (double)this.TsRandomTime);
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x0003ED70 File Offset: 0x0003CF70
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

	// Token: 0x06000C4E RID: 3150 RVA: 0x0003EE10 File Offset: 0x0003D010
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.EndTime < Time.Instance.Now)
		{
			base.Finish(true);
		}
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x0003EE2B File Offset: 0x0003D02B
	protected override void OnClear()
	{
		this.EndTime = 0.0;
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x0003EE3C File Offset: 0x0003D03C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskWait._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWait.TsTaskWait_C");
		}
		return TsTaskWait._ClassPtr;
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x0003EE60 File Offset: 0x0003D060
	public TsTaskWait() : this(BuiltinUtils.AllocNativeUObject(TsTaskWait.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x0003EE88 File Offset: 0x0003D088
	public TsTaskWait(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x0003EEBB File Offset: 0x0003D0BB
	protected TsTaskWait(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x0003EED0 File Offset: 0x0003D0D0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x0003EF00 File Offset: 0x0003D100
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040009C9 RID: 2505
	private bool IsInitTsVariables;

	// Token: 0x040009CA RID: 2506
	private int TsTimeMillisecond;

	// Token: 0x040009CB RID: 2507
	private string TsBlackboardKeyTime = "";

	// Token: 0x040009CC RID: 2508
	private int TsRandomTime;

	// Token: 0x040009CD RID: 2509
	private double EndTime;

	// Token: 0x040009CE RID: 2510
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWait.TsTaskWait_C";

	// Token: 0x040009CF RID: 2511
	private static IntPtr _ClassPtr;

	// Token: 0x040009D0 RID: 2512
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040009D1 RID: 2513
	private static int __PropertyOffset_TimeMillisecond;

	// Token: 0x040009D2 RID: 2514
	private static int __PropertyOffset_BlackboardKeyTime;

	// Token: 0x040009D3 RID: 2515
	private static int __PropertyOffset_RandomTime;
}
