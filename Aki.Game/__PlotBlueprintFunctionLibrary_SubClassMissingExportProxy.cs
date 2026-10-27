using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038CB RID: 14539
public class __PlotBlueprintFunctionLibrary_SubClassMissingExportProxy : __PlotBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EAE4 RID: 125668 RVA: 0x008973A0 File Offset: 0x008955A0
	[NullableContext(1)]
	protected __PlotBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAE5 RID: 125669 RVA: 0x008973D3 File Offset: 0x008955D3
	protected __PlotBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
