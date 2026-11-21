using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002A36 RID: 10806
[UClass("/Game/Aki/TypeScript/Game/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Utils/GlobalBlueprintFunctionLibrary.GlobalBlueprintFunctionLibrary_C")]
public class GlobalBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601B3A1 RID: 111521 RVA: 0x0085BEE6 File Offset: 0x0085A0E6
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static UObject GetBpEventManager()
	{
		return GlobalData.BpEventManager;
	}

	// Token: 0x0601B3A2 RID: 111522 RVA: 0x0085BEED File Offset: 0x0085A0ED
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static UObject GetBpFightManager()
	{
		return GlobalData.BpFightManager;
	}

	// Token: 0x0601B3A3 RID: 111523 RVA: 0x0085BEF4 File Offset: 0x0085A0F4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (GlobalBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Utils/GlobalBlueprintFunctionLibrary.GlobalBlueprintFunctionLibrary_C");
		}
		return GlobalBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601B3A4 RID: 111524 RVA: 0x0085BF18 File Offset: 0x0085A118
	public GlobalBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(GlobalBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B3A5 RID: 111525 RVA: 0x0085BF40 File Offset: 0x0085A140
	[NullableContext(1)]
	public GlobalBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GlobalBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B3A6 RID: 111526 RVA: 0x0085BF73 File Offset: 0x0085A173
	protected GlobalBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601B3A7 RID: 111527 RVA: 0x0085BF7C File Offset: 0x0085A17C
	protected unsafe static void __CPPCALL_GetBpEventManager_Implementation(GlobalBlueprintFunctionLibrary.__GetBpEventManager_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UObject bpEventManager = GlobalBlueprintFunctionLibrary.GetBpEventManager();
		ptr = ((bpEventManager != null) ? bpEventManager.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601B3A8 RID: 111528 RVA: 0x0085BF98 File Offset: 0x0085A198
	protected unsafe static void __CPPCALL_GetBpFightManager_Implementation(GlobalBlueprintFunctionLibrary.__GetBpFightManager_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UObject bpFightManager = GlobalBlueprintFunctionLibrary.GetBpFightManager();
		ptr = ((bpFightManager != null) ? bpFightManager.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0400EC76 RID: 60534
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Utils/GlobalBlueprintFunctionLibrary.GlobalBlueprintFunctionLibrary_C";

	// Token: 0x0400EC77 RID: 60535
	private static IntPtr _ClassPtr;

	// Token: 0x0400EC78 RID: 60536
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008A8B RID: 35467
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetBpEventManager_FunctionParams
	{
		// Token: 0x0402BFB0 RID: 180144
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BFB1 RID: 180145
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02008A8C RID: 35468
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetBpFightManager_FunctionParams
	{
		// Token: 0x0402BFB2 RID: 180146
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402BFB3 RID: 180147
		[FieldOffset(8)]
		public IntPtr __Result;
	}
}
