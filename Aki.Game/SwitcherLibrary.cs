using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020034CA RID: 13514
[UClass("/Game/Aki/TypeScript/Game/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Utils/SwitcherLibrary.SwitcherLibrary_C")]
public class SwitcherLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D6F7 RID: 120567 RVA: 0x008372BC File Offset: 0x008354BC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<string> GetAllSwitcher()
	{
		Dictionary<string, ValueTuple<Func<bool>, Action<bool>>> allSwitcher = SwitcherManager.Instance.AllSwitcher;
		TArray<string> tarray = new TArray<string>();
		foreach (KeyValuePair<string, ValueTuple<Func<bool>, Action<bool>>> keyValuePair in allSwitcher)
		{
			tarray.Add(keyValuePair.Key);
		}
		return tarray;
	}

	// Token: 0x0601D6F8 RID: 120568 RVA: 0x00837320 File Offset: 0x00835520
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSwitcher(string switcherName, bool value)
	{
		ValueTuple<Func<bool>, Action<bool>> valueTuple;
		if (SwitcherManager.Instance.AllSwitcher.TryGetValue(switcherName, out valueTuple))
		{
			valueTuple.Item2(value);
		}
	}

	// Token: 0x0601D6F9 RID: 120569 RVA: 0x00837350 File Offset: 0x00835550
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetSwitcher(string switcherName)
	{
		ValueTuple<Func<bool>, Action<bool>> valueTuple;
		return SwitcherManager.Instance.AllSwitcher.TryGetValue(switcherName, out valueTuple) && valueTuple.Item1();
	}

	// Token: 0x0601D6FA RID: 120570 RVA: 0x0083737E File Offset: 0x0083557E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SwitcherLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Utils/SwitcherLibrary.SwitcherLibrary_C");
		}
		return SwitcherLibrary._ClassPtr;
	}

	// Token: 0x0601D6FB RID: 120571 RVA: 0x008373A4 File Offset: 0x008355A4
	public SwitcherLibrary() : this(BuiltinUtils.AllocNativeUObject(SwitcherLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D6FC RID: 120572 RVA: 0x008373CC File Offset: 0x008355CC
	[NullableContext(1)]
	public SwitcherLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SwitcherLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D6FD RID: 120573 RVA: 0x008373FF File Offset: 0x008355FF
	protected SwitcherLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D6FE RID: 120574 RVA: 0x00837408 File Offset: 0x00835608
	protected unsafe static void __CPPCALL_GetAllSwitcher_Implementation(SwitcherLibrary.__GetAllSwitcher_FunctionParams* __Params)
	{
		TArray<string> allSwitcher = SwitcherLibrary.GetAllSwitcher();
		if (allSwitcher == null)
		{
			return;
		}
		allSwitcher.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601D6FF RID: 120575 RVA: 0x00837434 File Offset: 0x00835634
	protected unsafe static void __CPPCALL_SetSwitcher_Implementation(SwitcherLibrary.__SetSwitcher_FunctionParams* __Params)
	{
		SwitcherLibrary.SetSwitcher(FString.ToString((void*)(&__Params->switcherName)), __Params->value);
	}

	// Token: 0x0601D700 RID: 120576 RVA: 0x00837450 File Offset: 0x00835650
	protected unsafe static void __CPPCALL_GetSwitcher_Implementation(SwitcherLibrary.__GetSwitcher_FunctionParams* __Params)
	{
		string switcherName = FString.ToString((void*)(&__Params->switcherName));
		__Params->__Result = SwitcherLibrary.GetSwitcher(switcherName);
	}

	// Token: 0x0400E7EA RID: 59370
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Utils/SwitcherLibrary.SwitcherLibrary_C";

	// Token: 0x0400E7EB RID: 59371
	private static IntPtr _ClassPtr;

	// Token: 0x0400E7EC RID: 59372
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009875 RID: 39029
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAllSwitcher_FunctionParams
	{
		// Token: 0x04030939 RID: 198969
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0403093A RID: 198970
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02009876 RID: 39030
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetSwitcher_FunctionParams
	{
		// Token: 0x0403093B RID: 198971
		[FieldOffset(0)]
		public FString switcherName;

		// Token: 0x0403093C RID: 198972
		[FieldOffset(16)]
		public bool value;

		// Token: 0x0403093D RID: 198973
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009877 RID: 39031
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSwitcher_FunctionParams
	{
		// Token: 0x0403093E RID: 198974
		[FieldOffset(0)]
		public FString switcherName;

		// Token: 0x0403093F RID: 198975
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04030940 RID: 198976
		[FieldOffset(24)]
		public bool __Result;
	}
}
