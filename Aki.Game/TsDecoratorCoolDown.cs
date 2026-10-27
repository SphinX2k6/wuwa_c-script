using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200003F RID: 63
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCoolDown.TsDecoratorCoolDown_C")]
public class TsDecoratorCoolDown : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700005A RID: 90
	// (get) Token: 0x0600024B RID: 587 RVA: 0x0000B1AF File Offset: 0x000093AF
	// (set) Token: 0x0600024C RID: 588 RVA: 0x0000B1BF File Offset: 0x000093BF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Id
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCoolDown.__PropertyOffset_Id);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCoolDown.__PropertyOffset_Id) = value;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x0600024D RID: 589 RVA: 0x0000B1D0 File Offset: 0x000093D0
	// (set) Token: 0x0600024E RID: 590 RVA: 0x0000B1E4 File Offset: 0x000093E4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FFloatRange RandomCdTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCoolDown.__PropertyOffset_RandomCdTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCoolDown.__PropertyOffset_RandomCdTime) = value;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600024F RID: 591 RVA: 0x0000B1F9 File Offset: 0x000093F9
	// (set) Token: 0x06000250 RID: 592 RVA: 0x0000B209 File Offset: 0x00009409
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ReturnTrueFirstTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCoolDown.__PropertyOffset_ReturnTrueFirstTime) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCoolDown.__PropertyOffset_ReturnTrueFirstTime) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000251 RID: 593 RVA: 0x0000B21A File Offset: 0x0000941A
	// (set) Token: 0x06000252 RID: 594 RVA: 0x0000B22A File Offset: 0x0000942A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsOnlyCheckCoolDown
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCoolDown.__PropertyOffset_IsOnlyCheckCoolDown) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCoolDown.__PropertyOffset_IsOnlyCheckCoolDown) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000B23C File Offset: 0x0000943C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsId = this.Id;
			this.TsRandomCdTime = new FastUeFloatRange(this.RandomCdTime);
			this.TsReturnTrueFirstTime = this.ReturnTrueFirstTime;
			this.TsIsOnlyCheckCoolDown = this.IsOnlyCheckCoolDown;
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0000B294 File Offset: 0x00009494
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0000B334 File Offset: 0x00009534
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		this.InitTsVariables();
		double num = GameModeModel.Instance.IsMulti ? TimeUtil.Instance.GetServerTimeStamp() : Time.Instance.WorldTime;
		double coolDownTime = aiController.GetCoolDownTime(this.TsId);
		if (coolDownTime == 0.0)
		{
			this.SetCoolDownTime(aiController, num);
			return this.TsReturnTrueFirstTime;
		}
		if (coolDownTime > num)
		{
			return false;
		}
		this.SetCoolDownTime(aiController, num);
		return true;
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0000B3B0 File Offset: 0x000095B0
	[NullableContext(1)]
	private void SetCoolDownTime(AiController ownerController, double worldTime)
	{
		if (this.TsIsOnlyCheckCoolDown)
		{
			return;
		}
		double nextTime = worldTime + MathUtils.Instance.GetRandomRange(this.TsRandomCdTime.LowerBoundValue, this.TsRandomCdTime.UpperBoundValue);
		ownerController.SetCoolDownTime(this.TsId, nextTime, true, "行为树");
	}

	// Token: 0x06000257 RID: 599 RVA: 0x0000B3FC File Offset: 0x000095FC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCoolDown._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCoolDown.TsDecoratorCoolDown_C");
		}
		return TsDecoratorCoolDown._ClassPtr;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0000B420 File Offset: 0x00009620
	public TsDecoratorCoolDown() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCoolDown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0000B448 File Offset: 0x00009648
	[NullableContext(1)]
	public TsDecoratorCoolDown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCoolDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0000B47B File Offset: 0x0000967B
	protected TsDecoratorCoolDown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x0000B484 File Offset: 0x00009684
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000183 RID: 387
	private bool IsInitTsVariables;

	// Token: 0x04000184 RID: 388
	public int TsId;

	// Token: 0x04000185 RID: 389
	[Nullable(2)]
	public FastUeFloatRange TsRandomCdTime;

	// Token: 0x04000186 RID: 390
	public bool TsReturnTrueFirstTime;

	// Token: 0x04000187 RID: 391
	public bool TsIsOnlyCheckCoolDown;

	// Token: 0x04000188 RID: 392
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCoolDown.TsDecoratorCoolDown_C";

	// Token: 0x04000189 RID: 393
	private static IntPtr _ClassPtr;

	// Token: 0x0400018A RID: 394
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400018B RID: 395
	private static int __PropertyOffset_Id;

	// Token: 0x0400018C RID: 396
	private static int __PropertyOffset_RandomCdTime;

	// Token: 0x0400018D RID: 397
	private static int __PropertyOffset_ReturnTrueFirstTime;

	// Token: 0x0400018E RID: 398
	private static int __PropertyOffset_IsOnlyCheckCoolDown;
}
