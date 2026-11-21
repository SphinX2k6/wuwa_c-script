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
	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0003F6B7 File Offset: 0x0003D8B7
	// (set) Token: 0x06000C4B RID: 3147 RVA: 0x0003F6C7 File Offset: 0x0003D8C7
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

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0003F6D8 File Offset: 0x0003D8D8
	// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0003F6EC File Offset: 0x0003D8EC
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

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0003F701 File Offset: 0x0003D901
	// (set) Token: 0x06000C4F RID: 3151 RVA: 0x0003F711 File Offset: 0x0003D911
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

	// Token: 0x06000C50 RID: 3152 RVA: 0x0003F722 File Offset: 0x0003D922
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

	// Token: 0x06000C51 RID: 3153 RVA: 0x0003F760 File Offset: 0x0003D960
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskWait) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskWait.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000C52 RID: 3154 RVA: 0x0003F810 File Offset: 0x0003DA10
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

	// Token: 0x06000C53 RID: 3155 RVA: 0x0003F8B0 File Offset: 0x0003DAB0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskWait) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskWait.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000C54 RID: 3156 RVA: 0x0003F968 File Offset: 0x0003DB68
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.EndTime < Time.Instance.Now)
		{
			base.Finish(true);
		}
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x0003F983 File Offset: 0x0003DB83
	protected override void OnClear()
	{
		this.EndTime = 0.0;
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x0003F994 File Offset: 0x0003DB94
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskWait._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWait.TsTaskWait_C");
		}
		return TsTaskWait._ClassPtr;
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x0003F9B8 File Offset: 0x0003DBB8
	public TsTaskWait() : this(BuiltinUtils.AllocNativeUObject(TsTaskWait.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
	public TsTaskWait(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskWait.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x0003FA13 File Offset: 0x0003DC13
	protected TsTaskWait(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x0003FA28 File Offset: 0x0003DC28
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x0003FA58 File Offset: 0x0003DC58
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040009D1 RID: 2513
	private bool IsInitTsVariables;

	// Token: 0x040009D2 RID: 2514
	private int TsTimeMillisecond;

	// Token: 0x040009D3 RID: 2515
	private string TsBlackboardKeyTime = "";

	// Token: 0x040009D4 RID: 2516
	private int TsRandomTime;

	// Token: 0x040009D5 RID: 2517
	private double EndTime;

	// Token: 0x040009D6 RID: 2518
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskWait.TsTaskWait_C";

	// Token: 0x040009D7 RID: 2519
	private static IntPtr _ClassPtr;

	// Token: 0x040009D8 RID: 2520
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040009D9 RID: 2521
	private static int __PropertyOffset_TimeMillisecond;

	// Token: 0x040009DA RID: 2522
	private static int __PropertyOffset_BlackboardKeyTime;

	// Token: 0x040009DB RID: 2523
	private static int __PropertyOffset_RandomTime;
}
