using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EA0 RID: 11936
public class __TsControlBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsControlBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C88B RID: 116875 RVA: 0x008BD140 File Offset: 0x008BB340
	[NullableContext(1)]
	protected __TsControlBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsControlBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C88C RID: 116876 RVA: 0x008BD173 File Offset: 0x008BB373
	protected __TsControlBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
