using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E43 RID: 11843
public class __PlotBlueprintFunctionLibrary_InheritProxy : PlotBlueprintFunctionLibrary
{
	// Token: 0x0601C79C RID: 116636 RVA: 0x008BB8F8 File Offset: 0x008B9AF8
	[NullableContext(1)]
	public __PlotBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PlotBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C79D RID: 116637 RVA: 0x008BB92B File Offset: 0x008B9B2B
	protected __PlotBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
