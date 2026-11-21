using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F2C RID: 12076
public class __EffectBlueprintFunctionLibrary_SubClassMissingExportProxy : __EffectBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601CA74 RID: 117364 RVA: 0x008C0670 File Offset: 0x008BE870
	[NullableContext(1)]
	protected __EffectBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(EffectBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA75 RID: 117365 RVA: 0x008C06A3 File Offset: 0x008BE8A3
	protected __EffectBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
