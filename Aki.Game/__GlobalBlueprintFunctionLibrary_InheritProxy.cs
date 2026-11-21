using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F43 RID: 12099
public class __GlobalBlueprintFunctionLibrary_InheritProxy : GlobalBlueprintFunctionLibrary
{
	// Token: 0x0601CAF1 RID: 117489 RVA: 0x008C10E4 File Offset: 0x008BF2E4
	[NullableContext(1)]
	public __GlobalBlueprintFunctionLibrary_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GlobalBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAF2 RID: 117490 RVA: 0x008C1117 File Offset: 0x008BF317
	protected __GlobalBlueprintFunctionLibrary_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
