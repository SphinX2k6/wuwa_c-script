using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038CA RID: 14538
public class __PlotBlueprintFunctionLibrary_InheritProxy : PlotBlueprintFunctionLibrary
{
	// Token: 0x0601EAE2 RID: 125666 RVA: 0x00897364 File Offset: 0x00895564
	[NullableContext(1)]
	public __PlotBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAE3 RID: 125667 RVA: 0x00897397 File Offset: 0x00895597
	protected __PlotBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
