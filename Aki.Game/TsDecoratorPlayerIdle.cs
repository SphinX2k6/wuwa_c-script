using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200004C RID: 76
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorPlayerIdle.TsDecoratorPlayerIdle_C")]
public class TsDecoratorPlayerIdle : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000D3F3 File Offset: 0x0000B5F3
	// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000D403 File Offset: 0x0000B603
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float IdleTimeThreshold
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorPlayerIdle.__PropertyOffset_IdleTimeThreshold);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorPlayerIdle.__PropertyOffset_IdleTimeThreshold) = value;
		}
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0000D414 File Offset: 0x0000B614
	private void InitTsVariables()
	{
		if (this.TsIdleTimeThreshold == 0f || GlobalData.IsPlayInEditor)
		{
			this.TsIdleTimeThreshold = this.IdleTimeThreshold * (float)TimeUtil.Instance.InverseMillisecond;
		}
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000D444 File Offset: 0x0000B644
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

	// Token: 0x060002DB RID: 731 RVA: 0x0000D4E3 File Offset: 0x0000B6E3
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		return IdlePerformModel.Instance.GetIdleTime() >= this.TsIdleTimeThreshold;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0000D500 File Offset: 0x0000B700
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorPlayerIdle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorPlayerIdle.TsDecoratorPlayerIdle_C");
		}
		return TsDecoratorPlayerIdle._ClassPtr;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0000D524 File Offset: 0x0000B724
	public TsDecoratorPlayerIdle() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerIdle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0000D54C File Offset: 0x0000B74C
	[NullableContext(1)]
	public TsDecoratorPlayerIdle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerIdle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0000D57F File Offset: 0x0000B77F
	protected TsDecoratorPlayerIdle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0000D588 File Offset: 0x0000B788
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001DD RID: 477
	private float TsIdleTimeThreshold;

	// Token: 0x040001DE RID: 478
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorPlayerIdle.TsDecoratorPlayerIdle_C";

	// Token: 0x040001DF RID: 479
	private static IntPtr _ClassPtr;

	// Token: 0x040001E0 RID: 480
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001E1 RID: 481
	private static int __PropertyOffset_IdleTimeThreshold;
}
