using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Weather;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001AA RID: 426
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeWeather.TsAnimNotifyChangeWeather_C")]
public class TsAnimNotifyChangeWeather : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700047A RID: 1146
	// (get) Token: 0x06001B60 RID: 7008 RVA: 0x00091AA3 File Offset: 0x0008FCA3
	// (set) Token: 0x06001B61 RID: 7009 RVA: 0x00091AB3 File Offset: 0x0008FCB3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Weather
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyChangeWeather.__PropertyOffset_Weather);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyChangeWeather.__PropertyOffset_Weather) = value;
		}
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x00091AC4 File Offset: 0x0008FCC4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.Weather == 0)
		{
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.GHY, "[TsAnimNotifyChangeWeather] Weather 未设置!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}
		WeatherController.Instance.RequestChangeWeather(this.Weather, new ChangeWeatherReason?(ChangeWeatherReason.ClientSkill));
		return true;
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x00091B0E File Offset: 0x0008FD0E
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "切换天气";
	}

	// Token: 0x06001B64 RID: 7012 RVA: 0x00091B15 File Offset: 0x0008FD15
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeWeather._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeWeather.TsAnimNotifyChangeWeather_C");
		}
		return TsAnimNotifyChangeWeather._ClassPtr;
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x00091B3C File Offset: 0x0008FD3C
	public TsAnimNotifyChangeWeather() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeWeather.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x00091B64 File Offset: 0x0008FD64
	[NullableContext(1)]
	public TsAnimNotifyChangeWeather(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeWeather.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x00091B97 File Offset: 0x0008FD97
	protected TsAnimNotifyChangeWeather(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x00091BA0 File Offset: 0x0008FDA0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x00091BD3 File Offset: 0x0008FDD3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x0400118C RID: 4492
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeWeather.TsAnimNotifyChangeWeather_C";

	// Token: 0x0400118D RID: 4493
	private static IntPtr _ClassPtr;

	// Token: 0x0400118E RID: 4494
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400118F RID: 4495
	private static int __PropertyOffset_Weather;
}
