using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F44 RID: 12100
public class __GlobalBlueprintFunctionLibrary_SubClassMissingExportProxy : __GlobalBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601CAF3 RID: 117491 RVA: 0x008C1120 File Offset: 0x008BF320
	[NullableContext(1)]
	protected __GlobalBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GlobalBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAF4 RID: 117492 RVA: 0x008C1153 File Offset: 0x008BF353
	protected __GlobalBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
