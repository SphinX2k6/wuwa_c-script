using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020034C2 RID: 13506
[UClass("/Game/Aki/TypeScript/Game/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Utils/GlobalBlueprintFunctionLibrary.GlobalBlueprintFunctionLibrary_C")]
public class GlobalBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D6A2 RID: 120482 RVA: 0x00834A3E File Offset: 0x00832C3E
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static UObject GetBpEventManager()
	{
		return GlobalData.BpEventManager;
	}

	// Token: 0x0601D6A3 RID: 120483 RVA: 0x00834A45 File Offset: 0x00832C45
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static UObject GetBpFightManager()
	{
		return GlobalData.BpFightManager;
	}

	// Token: 0x0601D6A4 RID: 120484 RVA: 0x00834A4C File Offset: 0x00832C4C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (GlobalBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Utils/GlobalBlueprintFunctionLibrary.GlobalBlueprintFunctionLibrary_C");
		}
		return GlobalBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601D6A5 RID: 120485 RVA: 0x00834A70 File Offset: 0x00832C70
	public GlobalBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(GlobalBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D6A6 RID: 120486 RVA: 0x00834A98 File Offset: 0x00832C98
	[NullableContext(1)]
	public GlobalBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GlobalBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D6A7 RID: 120487 RVA: 0x00834ACB File Offset: 0x00832CCB
	protected GlobalBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D6A8 RID: 120488 RVA: 0x00834AD4 File Offset: 0x00832CD4
	protected unsafe static void __CPPCALL_GetBpEventManager_Implementation(GlobalBlueprintFunctionLibrary.__GetBpEventManager_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UObject bpEventManager = GlobalBlueprintFunctionLibrary.GetBpEventManager();
		ptr = ((bpEventManager != null) ? bpEventManager.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601D6A9 RID: 120489 RVA: 0x00834AF0 File Offset: 0x00832CF0
	protected unsafe static void __CPPCALL_GetBpFightManager_Implementation(GlobalBlueprintFunctionLibrary.__GetBpFightManager_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UObject bpFightManager = GlobalBlueprintFunctionLibrary.GetBpFightManager();
		ptr = ((bpFightManager != null) ? bpFightManager.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0400E7C2 RID: 59330
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Utils/GlobalBlueprintFunctionLibrary.GlobalBlueprintFunctionLibrary_C";

	// Token: 0x0400E7C3 RID: 59331
	private static IntPtr _ClassPtr;

	// Token: 0x0400E7C4 RID: 59332
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009871 RID: 39025
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetBpEventManager_FunctionParams
	{
		// Token: 0x0403092D RID: 198957
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0403092E RID: 198958
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02009872 RID: 39026
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetBpFightManager_FunctionParams
	{
		// Token: 0x0403092F RID: 198959
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04030930 RID: 198960
		[FieldOffset(8)]
		public IntPtr __Result;
	}
}
