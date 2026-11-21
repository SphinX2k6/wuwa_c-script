using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E00 RID: 11776
public class __CameraBlueprintFunctionLibrary_SubClassMissingExportProxy : __CameraBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C6BA RID: 116410 RVA: 0x008BA12C File Offset: 0x008B832C
	[NullableContext(1)]
	protected __CameraBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C6BB RID: 116411 RVA: 0x008BA15F File Offset: 0x008B835F
	protected __CameraBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
