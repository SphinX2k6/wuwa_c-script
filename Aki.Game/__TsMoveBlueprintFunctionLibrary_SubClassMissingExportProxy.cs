using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003931 RID: 14641
public class __TsMoveBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsMoveBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601EBF2 RID: 125938 RVA: 0x008993DC File Offset: 0x008975DC
	[NullableContext(1)]
	protected __TsMoveBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsMoveBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EBF3 RID: 125939 RVA: 0x0089940F File Offset: 0x0089760F
	protected __TsMoveBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
