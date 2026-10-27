using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C9 RID: 14537
public class __PlotActorBlueprintFunctionLibrary_SubClassMissingExportProxy : __PlotActorBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EAE0 RID: 125664 RVA: 0x00897328 File Offset: 0x00895528
	[NullableContext(1)]
	protected __PlotActorBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAE1 RID: 125665 RVA: 0x0089735B File Offset: 0x0089555B
	protected __PlotActorBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
