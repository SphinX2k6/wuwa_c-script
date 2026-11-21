using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E41 RID: 11841
public class __PlotActorBlueprintFunctionLibrary_InheritProxy : PlotActorBlueprintFunctionLibrary
{
	// Token: 0x0601C798 RID: 116632 RVA: 0x008BB880 File Offset: 0x008B9A80
	[NullableContext(1)]
	public __PlotActorBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C799 RID: 116633 RVA: 0x008BB8B3 File Offset: 0x008B9AB3
	protected __PlotActorBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
