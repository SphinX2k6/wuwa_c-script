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

// Token: 0x02002A3E RID: 10814
[UClass("/Game/Aki/TypeScript/Game/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Utils/SwitcherLibrary.SwitcherLibrary_C")]
public class SwitcherLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601B3F6 RID: 111606 RVA: 0x0085E764 File Offset: 0x0085C964
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

	// Token: 0x0601B3F7 RID: 111607 RVA: 0x0085E7C8 File Offset: 0x0085C9C8
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

	// Token: 0x0601B3F8 RID: 111608 RVA: 0x0085E7F8 File Offset: 0x0085C9F8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetSwitcher(string switcherName)
	{
		ValueTuple<Func<bool>, Action<bool>> valueTuple;
		return SwitcherManager.Instance.AllSwitcher.TryGetValue(switcherName, out valueTuple) && valueTuple.Item1();
	}

	// Token: 0x0601B3F9 RID: 111609 RVA: 0x0085E826 File Offset: 0x0085CA26
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (SwitcherLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Utils/SwitcherLibrary.SwitcherLibrary_C");
		}
		return SwitcherLibrary._ClassPtr;
	}

	// Token: 0x0601B3FA RID: 111610 RVA: 0x0085E84C File Offset: 0x0085CA4C
	public SwitcherLibrary() : this(BuiltinUtils.AllocNativeUObject(SwitcherLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B3FB RID: 111611 RVA: 0x0085E874 File Offset: 0x0085CA74
	[NullableContext(1)]
	public SwitcherLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SwitcherLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B3FC RID: 111612 RVA: 0x0085E8A7 File Offset: 0x0085CAA7
	protected SwitcherLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601B3FD RID: 111613 RVA: 0x0085E8B0 File Offset: 0x0085CAB0
	protected unsafe static void __CPPCALL_GetAllSwitcher_Implementation(SwitcherLibrary.__GetAllSwitcher_FunctionParams* __Params)
	{
		TArray<string> allSwitcher = SwitcherLibrary.GetAllSwitcher();
		if (allSwitcher == null)
		{
			return;
		}
		allSwitcher.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601B3FE RID: 111614 RVA: 0x0085E8DC File Offset: 0x0085CADC
	protected unsafe static void __CPPCALL_SetSwitcher_Implementation(SwitcherLibrary.__SetSwitcher_FunctionParams* __Params)
	{
		SwitcherLibrary.SetSwitcher(FString.ToString((void*)(&__Params->switcherName)), __Params->value);
	}

	// Token: 0x0601B3FF RID: 111615 RVA: 0x0085E8F8 File Offset: 0x0085CAF8
	protected unsafe static void __CPPCALL_GetSwitcher_Implementation(SwitcherLibrary.__GetSwitcher_FunctionParams* __Params)
	{
		string switcherName = FString.ToString((void*)(&__Params->switcherName));
		__Params->__Result = SwitcherLibrary.GetSwitcher(switcherName);
	}

	// Token: 0x0400EC9E RID: 60574
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Utils/SwitcherLibrary.SwitcherLibrary_C";

	// Token: 0x0400EC9F RID: 60575
	private static IntPtr _ClassPtr;

	// Token: 0x0400ECA0 RID: 60576
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008A8F RID: 35471
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAllSwitcher_FunctionParams
	{
		// Token: 0x0402BFBC RID: 180156
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BFBD RID: 180157
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02008A90 RID: 35472
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetSwitcher_FunctionParams
	{
		// Token: 0x0402BFBE RID: 180158
		[FieldOffset(0)]
		public FString switcherName;

		// Token: 0x0402BFBF RID: 180159
		[FieldOffset(16)]
		public bool value;

		// Token: 0x0402BFC0 RID: 180160
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008A91 RID: 35473
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSwitcher_FunctionParams
	{
		// Token: 0x0402BFC1 RID: 180161
		[FieldOffset(0)]
		public FString switcherName;

		// Token: 0x0402BFC2 RID: 180162
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402BFC3 RID: 180163
		[FieldOffset(24)]
		public bool __Result;
	}
}
