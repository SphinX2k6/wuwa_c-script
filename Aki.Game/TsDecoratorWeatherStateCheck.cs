using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Weather;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000054 RID: 84
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorWeatherStateCheck.TsDecoratorWeatherStateCheck_C")]
public class TsDecoratorWeatherStateCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000330 RID: 816 RVA: 0x0000EAAF File Offset: 0x0000CCAF
	// (set) Token: 0x06000331 RID: 817 RVA: 0x0000EABF File Offset: 0x0000CCBF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int WeatherStateId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorWeatherStateCheck.__PropertyOffset_WeatherStateId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorWeatherStateCheck.__PropertyOffset_WeatherStateId) = value;
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000332 RID: 818 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
	// (set) Token: 0x06000333 RID: 819 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EArithmeticKeyOperation> CheckType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorWeatherStateCheck.__PropertyOffset_CheckType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorWeatherStateCheck.__PropertyOffset_CheckType) = value;
		}
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0000EAF9 File Offset: 0x0000CCF9
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsWeatherStateId = this.WeatherStateId;
			this.TsCheckType = this.CheckType;
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0000EB30 File Offset: 0x0000CD30
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

	// Token: 0x06000336 RID: 822 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if ((ownerController as TsAiController).AiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.InitTsVariables();
		WeatherModel instance2 = WeatherModel.Instance;
		if (instance2 == null)
		{
			return false;
		}
		int currentWeatherId = instance2.CurrentWeatherId;
		switch (this.TsCheckType)
		{
		case EArithmeticKeyOperation.Equal:
			return currentWeatherId == this.TsWeatherStateId;
		case EArithmeticKeyOperation.NotEqual:
			return currentWeatherId != this.TsWeatherStateId;
		case EArithmeticKeyOperation.Less:
			return currentWeatherId < this.TsWeatherStateId;
		case EArithmeticKeyOperation.LessOrEqual:
			return currentWeatherId <= this.TsWeatherStateId;
		case EArithmeticKeyOperation.Greater:
			return currentWeatherId > this.TsWeatherStateId;
		case EArithmeticKeyOperation.GreaterOrEqual:
			return currentWeatherId >= this.TsWeatherStateId;
		default:
			return false;
		}
	}

	// Token: 0x06000337 RID: 823 RVA: 0x0000ECA6 File Offset: 0x0000CEA6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorWeatherStateCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorWeatherStateCheck.TsDecoratorWeatherStateCheck_C");
		}
		return TsDecoratorWeatherStateCheck._ClassPtr;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0000ECCC File Offset: 0x0000CECC
	public TsDecoratorWeatherStateCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorWeatherStateCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
	[NullableContext(1)]
	public TsDecoratorWeatherStateCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorWeatherStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0000ED27 File Offset: 0x0000CF27
	protected TsDecoratorWeatherStateCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0000ED30 File Offset: 0x0000CF30
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000216 RID: 534
	private bool IsInitTsVariables;

	// Token: 0x04000217 RID: 535
	private int TsWeatherStateId;

	// Token: 0x04000218 RID: 536
	private EArithmeticKeyOperation TsCheckType;

	// Token: 0x04000219 RID: 537
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorWeatherStateCheck.TsDecoratorWeatherStateCheck_C";

	// Token: 0x0400021A RID: 538
	private static IntPtr _ClassPtr;

	// Token: 0x0400021B RID: 539
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400021C RID: 540
	private static int __PropertyOffset_WeatherStateId;

	// Token: 0x0400021D RID: 541
	private static int __PropertyOffset_CheckType;
}
