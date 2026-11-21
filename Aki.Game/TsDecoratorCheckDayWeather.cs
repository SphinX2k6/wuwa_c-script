using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Enum;
using AkiClient.Game.Aki.Data.Condition.Enum;
using CSharpScript.Game.Module.Weather;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000036 RID: 54
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckDayWeather.TsDecoratorCheckDayWeather_C")]
public class TsDecoratorCheckDayWeather : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060001EB RID: 491 RVA: 0x00009BCB File Offset: 0x00007DCB
	// (set) Token: 0x060001EC RID: 492 RVA: 0x00009BDB File Offset: 0x00007DDB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EDayState CheckDayState
	{
		get
		{
			return (EDayState)(*(base.NativePtr + (IntPtr)TsDecoratorCheckDayWeather.__PropertyOffset_CheckDayState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckDayWeather.__PropertyOffset_CheckDayState) = (byte)value;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060001ED RID: 493 RVA: 0x00009BEC File Offset: 0x00007DEC
	// (set) Token: 0x060001EE RID: 494 RVA: 0x00009BFC File Offset: 0x00007DFC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EWeatherState CheckWeatherState
	{
		get
		{
			return (EWeatherState)(*(base.NativePtr + (IntPtr)TsDecoratorCheckDayWeather.__PropertyOffset_CheckWeatherState));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckDayWeather.__PropertyOffset_CheckWeatherState) = (byte)value;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060001EF RID: 495 RVA: 0x00009C0D File Offset: 0x00007E0D
	// (set) Token: 0x060001F0 RID: 496 RVA: 0x00009C1D File Offset: 0x00007E1D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe SConditionGroupType ConditionType
	{
		get
		{
			return (SConditionGroupType)(*(base.NativePtr + (IntPtr)TsDecoratorCheckDayWeather.__PropertyOffset_ConditionType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckDayWeather.__PropertyOffset_ConditionType) = (byte)value;
		}
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00009C30 File Offset: 0x00007E30
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorCheckDayWeather) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorCheckDayWeather.StaticClass(), out intPtr, out num))
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

	// Token: 0x060001F2 RID: 498 RVA: 0x00009CE8 File Offset: 0x00007EE8
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		WeatherDefines.EWeatherType currentWeatherType = WeatherModel.Instance.GetCurrentWeatherType();
		bool flag;
		if (this.CheckDayState == EDayState.白天)
		{
			flag = TimeOfDayController.Instance.CheckInMinuteSpan(360, 1080);
		}
		else
		{
			flag = !TimeOfDayController.Instance.CheckInMinuteSpan(360, 1080);
		}
		bool flag2 = false;
		switch (currentWeatherType)
		{
		case WeatherDefines.EWeatherType.Sunny:
			flag2 = (this.CheckWeatherState == EWeatherState.晴天);
			break;
		case WeatherDefines.EWeatherType.Cloudy:
			flag2 = (this.CheckWeatherState == EWeatherState.多云);
			break;
		case WeatherDefines.EWeatherType.Rainy:
			flag2 = (this.CheckWeatherState == EWeatherState.下雨);
			break;
		case WeatherDefines.EWeatherType.ThunderRain:
			flag2 = (this.CheckWeatherState == EWeatherState.打雷);
			break;
		case WeatherDefines.EWeatherType.Snowy:
			flag2 = (this.CheckWeatherState == EWeatherState.下雪);
			break;
		}
		if (this.ConditionType != SConditionGroupType.AND)
		{
			return flag || flag2;
		}
		return flag && flag2;
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00009DA5 File Offset: 0x00007FA5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckDayWeather._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckDayWeather.TsDecoratorCheckDayWeather_C");
		}
		return TsDecoratorCheckDayWeather._ClassPtr;
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00009DCC File Offset: 0x00007FCC
	public TsDecoratorCheckDayWeather() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckDayWeather.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00009DF4 File Offset: 0x00007FF4
	[NullableContext(1)]
	public TsDecoratorCheckDayWeather(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckDayWeather.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00009E27 File Offset: 0x00008027
	protected TsDecoratorCheckDayWeather(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00009E30 File Offset: 0x00008030
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400014A RID: 330
	private const int DAY_MINITE_START = 360;

	// Token: 0x0400014B RID: 331
	private const int DAY_MINITE_END = 1080;

	// Token: 0x0400014C RID: 332
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/TsDecoratorCheckDayWeather.TsDecoratorCheckDayWeather_C";

	// Token: 0x0400014D RID: 333
	private static IntPtr _ClassPtr;

	// Token: 0x0400014E RID: 334
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400014F RID: 335
	private static int __PropertyOffset_CheckDayState;

	// Token: 0x04000150 RID: 336
	private static int __PropertyOffset_CheckWeatherState;

	// Token: 0x04000151 RID: 337
	private static int __PropertyOffset_ConditionType;
}
