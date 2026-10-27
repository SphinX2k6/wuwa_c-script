using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000035 RID: 53
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckDay.TsDecoratorCheckDay_C")]
public class TsDecoratorCheckDay : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060001E2 RID: 482 RVA: 0x000096AB File Offset: 0x000078AB
	// (set) Token: 0x060001E3 RID: 483 RVA: 0x000096B3 File Offset: 0x000078B3
	public EDayState CheckDayState { get; set; }

	// Token: 0x060001E4 RID: 484 RVA: 0x000096BC File Offset: 0x000078BC
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

	// Token: 0x060001E5 RID: 485 RVA: 0x0000975C File Offset: 0x0000795C
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		bool result;
		if (this.CheckDayState == EDayState.白天)
		{
			result = TimeOfDayController.Instance.CheckInMinuteSpan(360, 1080);
		}
		else
		{
			result = !TimeOfDayController.Instance.CheckInMinuteSpan(360, 1080);
		}
		return result;
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x000097A3 File Offset: 0x000079A3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckDay._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckDay.TsDecoratorCheckDay_C");
		}
		return TsDecoratorCheckDay._ClassPtr;
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x000097C8 File Offset: 0x000079C8
	public TsDecoratorCheckDay() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckDay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x000097F0 File Offset: 0x000079F0
	[NullableContext(1)]
	public TsDecoratorCheckDay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckDay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00009823 File Offset: 0x00007A23
	protected TsDecoratorCheckDay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0000982C File Offset: 0x00007A2C
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000144 RID: 324
	private const int DAY_MINITE_START = 360;

	// Token: 0x04000145 RID: 325
	private const int DAY_MINITE_END = 1080;

	// Token: 0x04000147 RID: 327
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckDay.TsDecoratorCheckDay_C";

	// Token: 0x04000148 RID: 328
	private static IntPtr _ClassPtr;

	// Token: 0x04000149 RID: 329
	private static IntPtr _ClassDefaultObjectPtr;
}
