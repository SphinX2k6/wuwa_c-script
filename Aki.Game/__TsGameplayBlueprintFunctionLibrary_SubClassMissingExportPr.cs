using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EA4 RID: 11940
public class __TsGameplayBlueprintFunctionLibrary_SubClassMissingExportProxy : __TsGameplayBlueprintFunctionLibrary_InheritProxy
{
	// Token: 0x0601C893 RID: 116883 RVA: 0x008BD230 File Offset: 0x008BB430
	[NullableContext(1)]
	protected __TsGameplayBlueprintFunctionLibrary_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsGameplayBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C894 RID: 116884 RVA: 0x008BD263 File Offset: 0x008BB463
	protected __TsGameplayBlueprintFunctionLibrary_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}
}
