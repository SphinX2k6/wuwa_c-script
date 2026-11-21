using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000044 RID: 68
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorGeneralConditionCheck.TsDecoratorGeneralConditionCheck_C")]
public class TsDecoratorGeneralConditionCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000289 RID: 649 RVA: 0x0000C62F File Offset: 0x0000A82F
	// (set) Token: 0x0600028A RID: 650 RVA: 0x0000C643 File Offset: 0x0000A843
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ConditionGroupId
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorGeneralConditionCheck.__PropertyOffset_ConditionGroupId)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorGeneralConditionCheck.__PropertyOffset_ConditionGroupId)), value);
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x0600028B RID: 651 RVA: 0x0000C658 File Offset: 0x0000A858
	// (set) Token: 0x0600028C RID: 652 RVA: 0x0000C668 File Offset: 0x0000A868
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CompareValue
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorGeneralConditionCheck.__PropertyOffset_CompareValue) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorGeneralConditionCheck.__PropertyOffset_CompareValue) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0000C679 File Offset: 0x0000A879
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsConditionGroupId = this.ConditionGroupId;
			this.TsCompareValue = this.CompareValue;
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0000C6AC File Offset: 0x0000A8AC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorGeneralConditionCheck) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorGeneralConditionCheck.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600028F RID: 655 RVA: 0x0000C762 File Offset: 0x0000A962
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		return this.TsConditionGroupId != "" && LevelGeneralController.Instance.CheckCondition(this.TsConditionGroupId, null, true, Array.Empty<object>()) == this.TsCompareValue;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0000C79D File Offset: 0x0000A99D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorGeneralConditionCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorGeneralConditionCheck.TsDecoratorGeneralConditionCheck_C");
		}
		return TsDecoratorGeneralConditionCheck._ClassPtr;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
	public TsDecoratorGeneralConditionCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorGeneralConditionCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000292 RID: 658 RVA: 0x0000C7EC File Offset: 0x0000A9EC
	public TsDecoratorGeneralConditionCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorGeneralConditionCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000293 RID: 659 RVA: 0x0000C81F File Offset: 0x0000AA1F
	protected TsDecoratorGeneralConditionCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000294 RID: 660 RVA: 0x0000C834 File Offset: 0x0000AA34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040001AE RID: 430
	private bool IsInitTsVariables;

	// Token: 0x040001AF RID: 431
	private string TsConditionGroupId = "";

	// Token: 0x040001B0 RID: 432
	private bool TsCompareValue;

	// Token: 0x040001B1 RID: 433
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorGeneralConditionCheck.TsDecoratorGeneralConditionCheck_C";

	// Token: 0x040001B2 RID: 434
	private static IntPtr _ClassPtr;

	// Token: 0x040001B3 RID: 435
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040001B4 RID: 436
	private static int __PropertyOffset_ConditionGroupId;

	// Token: 0x040001B5 RID: 437
	private static int __PropertyOffset_CompareValue;
}
