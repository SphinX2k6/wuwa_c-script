using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038C8 RID: 14536
public class __PlotActorBlueprintFunctionLibrary_InheritProxy : PlotActorBlueprintFunctionLibrary
{
	// Token: 0x0601EADE RID: 125662 RVA: 0x008972EC File Offset: 0x008954EC
	[NullableContext(1)]
	public __PlotActorBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotActorBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EADF RID: 125663 RVA: 0x0089731F File Offset: 0x0089551F
	protected __PlotActorBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
