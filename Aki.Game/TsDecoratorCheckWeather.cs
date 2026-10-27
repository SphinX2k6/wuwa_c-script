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
	// (get) Token: 0x06000242 RID: 578 RVA: 0x0000AFBF File Offset: 0x000091BF
	// (set) Token: 0x06000243 RID: 579 RVA: 0x0000AFCF File Offset: 0x000091CF
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

	// Token: 0x06000244 RID: 580 RVA: 0x0000AFE0 File Offset: 0x000091E0
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

	// Token: 0x06000245 RID: 581 RVA: 0x0000B080 File Offset: 0x00009280
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

	// Token: 0x06000246 RID: 582 RVA: 0x0000B0F3 File Offset: 0x000092F3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckWeather._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckWeather.TsDecoratorCheckWeather_C");
		}
		return TsDecoratorCheckWeather._ClassPtr;
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0000B118 File Offset: 0x00009318
	public TsDecoratorCheckWeather() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckWeather.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0000B140 File Offset: 0x00009340
	[NullableContext(1)]
	public TsDecoratorCheckWeather(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckWeather.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0000B173 File Offset: 0x00009373
	protected TsDecoratorCheckWeather(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0000B17C File Offset: 0x0000937C
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
