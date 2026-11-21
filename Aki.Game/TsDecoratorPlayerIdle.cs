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
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000D9FB File Offset: 0x0000BBFB
	// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000DA0B File Offset: 0x0000BC0B
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

	// Token: 0x060002D9 RID: 729 RVA: 0x0000DA1C File Offset: 0x0000BC1C
	private void InitTsVariables()
	{
		if (this.TsIdleTimeThreshold == 0f || GlobalData.IsPlayInEditor)
		{
			this.TsIdleTimeThreshold = this.IdleTimeThreshold * (float)TimeUtil.Instance.InverseMillisecond;
		}
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000DA4C File Offset: 0x0000BC4C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorPlayerIdle) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorPlayerIdle.StaticClass(), out intPtr, out num))
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

	// Token: 0x060002DB RID: 731 RVA: 0x0000DB02 File Offset: 0x0000BD02
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		return IdlePerformModel.Instance.GetIdleTime() >= this.TsIdleTimeThreshold;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0000DB1F File Offset: 0x0000BD1F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorPlayerIdle._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorPlayerIdle.TsDecoratorPlayerIdle_C");
		}
		return TsDecoratorPlayerIdle._ClassPtr;
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0000DB44 File Offset: 0x0000BD44
	public TsDecoratorPlayerIdle() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerIdle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0000DB6C File Offset: 0x0000BD6C
	[NullableContext(1)]
	public TsDecoratorPlayerIdle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerIdle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0000DB9F File Offset: 0x0000BD9F
	protected TsDecoratorPlayerIdle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
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
