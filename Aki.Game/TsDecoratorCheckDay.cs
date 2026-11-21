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
	// (get) Token: 0x060001E2 RID: 482 RVA: 0x000099FF File Offset: 0x00007BFF
	// (set) Token: 0x060001E3 RID: 483 RVA: 0x00009A07 File Offset: 0x00007C07
	public EDayState CheckDayState { get; set; }

	// Token: 0x060001E4 RID: 484 RVA: 0x00009A10 File Offset: 0x00007C10
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorCheckDay) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorCheckDay.StaticClass(), out intPtr, out num))
		{
			return this.PerformConditionCheckAI_Implementation(ownerController, controlledPawn);
		}
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr = stackalloc UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00009AC8 File Offset: 0x00007CC8
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

	// Token: 0x060001E6 RID: 486 RVA: 0x00009B0F File Offset: 0x00007D0F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckDay._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckDay.TsDecoratorCheckDay_C");
		}
		return TsDecoratorCheckDay._ClassPtr;
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00009B34 File Offset: 0x00007D34
	public TsDecoratorCheckDay() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckDay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00009B5C File Offset: 0x00007D5C
	[NullableContext(1)]
	public TsDecoratorCheckDay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckDay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00009B8F File Offset: 0x00007D8F
	protected TsDecoratorCheckDay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00009B98 File Offset: 0x00007D98
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
