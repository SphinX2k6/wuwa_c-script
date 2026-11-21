using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E30 RID: 11824
public class __UiBlueprintFunctionLibrary_SubClassMissingExportProxy : __UiBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C75D RID: 116573 RVA: 0x008BB2D8 File Offset: 0x008B94D8
	[NullableContext(1)]
	protected __UiBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UiBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C75E RID: 116574 RVA: 0x008BB30B File Offset: 0x008B950B
	protected __UiBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
