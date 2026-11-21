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
	// (get) Token: 0x06000330 RID: 816 RVA: 0x0000F17F File Offset: 0x0000D37F
	// (set) Token: 0x06000331 RID: 817 RVA: 0x0000F18F File Offset: 0x0000D38F
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
	// (get) Token: 0x06000332 RID: 818 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
	// (set) Token: 0x06000333 RID: 819 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
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

	// Token: 0x06000334 RID: 820 RVA: 0x0000F1C9 File Offset: 0x0000D3C9
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsWeatherStateId = this.WeatherStateId;
			this.TsCheckType = this.CheckType;
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0000F200 File Offset: 0x0000D400
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorWeatherStateCheck) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorWeatherStateCheck.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000336 RID: 822 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
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

	// Token: 0x06000337 RID: 823 RVA: 0x0000F38E File Offset: 0x0000D58E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorWeatherStateCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorWeatherStateCheck.TsDecoratorWeatherStateCheck_C");
		}
		return TsDecoratorWeatherStateCheck._ClassPtr;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
	public TsDecoratorWeatherStateCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorWeatherStateCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0000F3DC File Offset: 0x0000D5DC
	[NullableContext(1)]
	public TsDecoratorWeatherStateCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorWeatherStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0000F40F File Offset: 0x0000D60F
	protected TsDecoratorWeatherStateCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0000F418 File Offset: 0x0000D618
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
