using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F42 RID: 12098
public class __CombatDebugBlueprintFunctionLibrary_SubClassMissingExportProxy : __CombatDebugBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601CAEF RID: 117487 RVA: 0x008C10A8 File Offset: 0x008BF2A8
	[NullableContext(1)]
	protected __CombatDebugBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CombatDebugBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAF0 RID: 117488 RVA: 0x008C10DB File Offset: 0x008BF2DB
	protected __CombatDebugBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
