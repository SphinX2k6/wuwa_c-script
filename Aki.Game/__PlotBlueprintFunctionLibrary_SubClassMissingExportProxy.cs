using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E44 RID: 11844
public class __PlotBlueprintFunctionLibrary_SubClassMissingExportProxy : __PlotBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C79E RID: 116638 RVA: 0x008BB934 File Offset: 0x008B9B34
	[NullableContext(1)]
	protected __PlotBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C79F RID: 116639 RVA: 0x008BB967 File Offset: 0x008B9B67
	protected __PlotBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
