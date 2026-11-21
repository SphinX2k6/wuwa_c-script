using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E42 RID: 11842
public class __PlotActorBlueprintFunctionLibrary_SubClassMissingExportProxy : __PlotActorBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C79A RID: 116634 RVA: 0x008BB8BC File Offset: 0x008B9ABC
	[NullableContext(1)]
	protected __PlotActorBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C79B RID: 116635 RVA: 0x008BB8EF File Offset: 0x008B9AEF
	protected __PlotActorBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
