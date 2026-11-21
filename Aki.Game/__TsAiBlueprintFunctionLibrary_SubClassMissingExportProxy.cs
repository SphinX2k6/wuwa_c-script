using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E9C RID: 11932
public class __TsAiBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsAiBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C883 RID: 116867 RVA: 0x008BD050 File Offset: 0x008BB250
	[NullableContext(1)]
	protected __TsAiBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C884 RID: 116868 RVA: 0x008BD083 File Offset: 0x008BB283
	protected __TsAiBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
