using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EAC RID: 11948
public class __TsMoveBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsMoveBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C8A3 RID: 116899 RVA: 0x008BD410 File Offset: 0x008BB610
	[NullableContext(1)]
	protected __TsMoveBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMoveBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8A4 RID: 116900 RVA: 0x008BD443 File Offset: 0x008BB643
	protected __TsMoveBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
