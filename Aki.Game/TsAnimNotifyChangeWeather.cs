using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Weather;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A6 RID: 422
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeWeather.TsAnimNotifyChangeWeather_C")]
public class TsAnimNotifyChangeWeather : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0008B37F File Offset: 0x0008957F
	// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x0008B38F File Offset: 0x0008958F
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

	// Token: 0x06001AC5 RID: 6853 RVA: 0x0008B3A0 File Offset: 0x000895A0
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

	// Token: 0x06001AC6 RID: 6854 RVA: 0x0008B3EA File Offset: 0x000895EA
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "切换天气";
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x0008B3F1 File Offset: 0x000895F1
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyChangeWeather._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeWeather.TsAnimNotifyChangeWeather_C");
		}
		return TsAnimNotifyChangeWeather._ClassPtr;
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x0008B418 File Offset: 0x00089618
	public TsAnimNotifyChangeWeather() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeWeather.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x0008B440 File Offset: 0x00089640
	[NullableContext(1)]
	public TsAnimNotifyChangeWeather(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyChangeWeather.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x0008B473 File Offset: 0x00089673
	protected TsAnimNotifyChangeWeather(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x0008B47C File Offset: 0x0008967C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x0008B4AF File Offset: 0x000896AF
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04001149 RID: 4425
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyChangeWeather.TsAnimNotifyChangeWeather_C";

	// Token: 0x0400114A RID: 4426
	private static IntPtr _ClassPtr;

	// Token: 0x0400114B RID: 4427
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400114C RID: 4428
	private static int __PropertyOffset_Weather;
}
