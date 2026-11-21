using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Enum;
using CSharpScript.Game.Module.Weather;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200003E RID: 62
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckWeather.TsDecoratorCheckWeather_C")]
public class TsDecoratorCheckWeather : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000242 RID: 578 RVA: 0x0000B46F File Offset: 0x0000966F
	// (set) Token: 0x06000243 RID: 579 RVA: 0x0000B47F File Offset: 0x0000967F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EWeatherState CheckWeatherState
	{
		get
		{
			return (EWeatherState)(*(base.NativePtr + (IntPtr)TsDecoratorCheckWeather.__PropertyOffset_CheckWeatherState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckWeather.__PropertyOffset_CheckWeatherState) = (byte)value;
		}
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0000B490 File Offset: 0x00009690
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorCheckWeather) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorCheckWeather.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000245 RID: 581 RVA: 0x0000B548 File Offset: 0x00009748
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		WeatherDefines.EWeatherType currentWeatherType = WeatherModel.Instance.GetCurrentWeatherType();
		bool result = false;
		switch (currentWeatherType)
		{
		case WeatherDefines.EWeatherType.Sunny:
			result = (this.CheckWeatherState == EWeatherState.晴天);
			break;
		case WeatherDefines.EWeatherType.Cloudy:
			result = (this.CheckWeatherState == EWeatherState.多云);
			break;
		case WeatherDefines.EWeatherType.Rainy:
			result = (this.CheckWeatherState == EWeatherState.下雨);
			break;
		case WeatherDefines.EWeatherType.ThunderRain:
			result = (this.CheckWeatherState == EWeatherState.打雷);
			break;
		case WeatherDefines.EWeatherType.Snowy:
			result = (this.CheckWeatherState == EWeatherState.下雪);
			break;
		}
		return result;
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0000B5BB File Offset: 0x000097BB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckWeather._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckWeather.TsDecoratorCheckWeather_C");
		}
		return TsDecoratorCheckWeather._ClassPtr;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0000B5E0 File Offset: 0x000097E0
	public TsDecoratorCheckWeather() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckWeather.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0000B608 File Offset: 0x00009808
	[NullableContext(1)]
	public TsDecoratorCheckWeather(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckWeather.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0000B63B File Offset: 0x0000983B
	protected TsDecoratorCheckWeather(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0000B644 File Offset: 0x00009844
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400017F RID: 383
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckWeather.TsDecoratorCheckWeather_C";

	// Token: 0x04000180 RID: 384
	private static IntPtr _ClassPtr;

	// Token: 0x04000181 RID: 385
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000182 RID: 386
	private static int __PropertyOffset_CheckWeatherState;
}
