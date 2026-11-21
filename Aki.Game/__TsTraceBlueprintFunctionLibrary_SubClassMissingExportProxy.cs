using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EB0 RID: 11952
public class __TsTraceBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsTraceBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C8AB RID: 116907 RVA: 0x008BD500 File Offset: 0x008BB700
	[NullableContext(1)]
	protected __TsTraceBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTraceBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C8AC RID: 116908 RVA: 0x008BD533 File Offset: 0x008BB733
	protected __TsTraceBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
